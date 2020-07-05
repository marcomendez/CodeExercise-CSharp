using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper;
using Code.Exercise.Helper.Attributes;
using Code.Exercise.Helper.Enums;
using System;
using System.Linq;
using System.Reflection;
using TechTalk.SpecFlow;

namespace Code.Exercise.Steps
{
    [Binding]
    public class BaseSteps : TechTalk.SpecFlow.Steps
    {
        protected new ScenarioContext ScenarioContext { get; }

        private const string PagesAssemblyName = "Code.Exercise.Pages";

        private const string ElementTypeClassName = "Code.Exercise.Elements.Elements.{0}";

        private const string ElementsAssemblyName = "Code.Exercise.Elements";

        public BaseSteps(ScenarioContext injectedContext)
        {
            ScenarioContext = injectedContext;
        }

        /// <summary>
        /// Sets and Get the current view.
        /// </summary>
        protected Type CurrentViewClassType
        {
            get
            {
                if (!ScenarioContext.Any(p => p.Key.Equals(Keys.CurrentViewClassType)))
                {
                    ScenarioContext.Add(Keys.CurrentViewClassType, string.Empty);
                }
                return (Type)ScenarioContext[Keys.CurrentViewClassType];
            }
            set => ScenarioContext[Keys.CurrentViewClassType] = value;
        }

        /// <summary>
        /// Gets Page class type.
        /// </summary>
        /// <param name="PageName"></param>
        /// <returns>Class type</returns>
        protected Type GetPageClassType(string PageName)
        {
            if (!string.IsNullOrEmpty(PageName))
            {
                CurrentViewClassType = Assembly.Load(PagesAssemblyName)
                                               .GetTypes().Where(classType => classType.IsClass && classType.GetCustomAttribute<PageAttribute>()?.Name == PageName)
                                               .FirstOrDefault();
            }

            return CurrentViewClassType;
        }

        /// <summary>
        /// Gets Element from Page class.
        /// </summary>
        /// <param name="elementName">Element name.</param>
        /// <param name="PageName">Page name.</param>
        /// <returns>Instance of any Element.</returns>
        protected dynamic Element(string elementName, string PageName)
        {
            // Get Page
            var pageClassType = GetPageClassType(PageName);

            // Get Element property information.
            PropertyInfo elementInfo = pageClassType.GetTypeInfo()
                                                    .GetProperties()
                                                    .Where(property => property.GetCustomAttribute<ElementAttribute>().Name == elementName)
                                                    .FirstOrDefault();
            // Get Element type
            ElementType elementType = elementInfo.GetCustomAttribute<ElementAttribute>().Type;

            // Get Element Class
            string elementClass = string.Format(ElementTypeClassName, elementType.ToString());

            // Get Element Class type
            Type elementClassType = Assembly.Load(ElementsAssemblyName).GetType(elementClass);

            // Instance Element
            return Activator.CreateInstance(elementClassType, new object[] { elementName, GetLocator(elementInfo) });
        }

        /// <summary>
        /// Gets Locator.
        /// </summary>
        /// <param name="elementInfo">Element property info.</param>
        /// <returns>Instance of Locator.</returns>
        protected Locator GetLocator(PropertyInfo elementInfo)
        {
            LocatorAttribute locatorAttr = elementInfo.GetCustomAttributes<LocatorAttribute>().FirstOrDefault();
            Locator locator = new Locator(locatorAttr.LocatorType, locatorAttr.LocatorValue);
            return locator;
        }
    }
}
