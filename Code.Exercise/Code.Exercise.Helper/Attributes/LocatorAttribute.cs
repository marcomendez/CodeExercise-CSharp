﻿using Code.Exercise.Helper.Enums;
using System;

namespace Code.Exercise.Helper.Attributes
{
    /// <summary>
    /// Handles attributo to property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class LocatorAttribute : Attribute
    {
        public LocatorType LocatorType { get; set; }

        public string LocatorValue { get; set; }

        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="locatorType">Locator type value.</param>
        /// <param name="locatorValue">Locator value.</param>
        public LocatorAttribute(LocatorType locatorType, string locatorValue)
        {
            LocatorType = locatorType;
            LocatorValue = locatorValue;
        }
    }
}
