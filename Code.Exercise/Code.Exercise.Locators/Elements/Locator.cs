using System;
using Code.Exercise.Helper.Enums;
using OpenQA.Selenium;

namespace Code.Exercise.Elements.Locators
{
    public class Locator
    {
        public LocatorType Type { get; set; }

        public string Value { get; set; }

        public Locator(LocatorType type, string value)
        {
            Type = type;
            Value = value;
        }

        public By GetBy()
        {
            switch (Type)
            {
                case LocatorType.XPath:
                    return By.XPath(Value);

                case LocatorType.Name:
                    return By.Name(Value);

                case LocatorType.Id:
                    return By.Id(Value);

                case LocatorType.ClassName:
                    return By.ClassName(Value);

                case LocatorType.CssSelector:
                    return By.CssSelector(Value);

                default:
                    throw new Exception($"Cannot get '{typeof(By)}' object for '{Type}'.");
            }
        }
    }
}
