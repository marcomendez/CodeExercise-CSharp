using System;

namespace Code.Exercise.Helper.Attributes
{
    /// <summary>
    /// Handles class attributes for pages.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PageAttribute : Attribute
    {
        public string Name { set; get; }

        /// <summary>
        /// Constructors.
        /// </summary>
        /// <param name="name">Name of Attribute.</param>
        public PageAttribute(string name)
        {
            Name = name;
        }
    }
}
