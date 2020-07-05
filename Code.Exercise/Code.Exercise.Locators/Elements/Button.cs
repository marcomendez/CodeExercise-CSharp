﻿using Code.Exercise.Elements.Interfaces;
using Code.Exercise.Elements.Locators;
using Code.Exercise.Helper.Enums;

namespace Code.Exercise.Elements.Elements
{
    /// <summary>
    /// Handles button type elements.
    /// </summary>
    public class Button : WebElement, IClickeable
    {
        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="locator">Locator info.</param>
        public Button(Locator locator) : base(ElementType.Button, locator)
        {
        }

        /// <summary>
        /// Clicks on Element.
        /// </summary>
        public void Click()
        {
            Element.Click();
        }
    }
}
