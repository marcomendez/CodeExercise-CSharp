using Code.Exercise.Helper.Enums;
using System;

namespace Code.Exercise.Helper.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LocatorAttribute : Attribute
    {
        public LocatorType LocatorType { get; set; }

        public string LocatorValue { get; set; }

        public LocatorAttribute(LocatorType locatorType, string locatorValue)
        {
            LocatorType = locatorType;
            LocatorValue = locatorValue;
        }
    }
}
