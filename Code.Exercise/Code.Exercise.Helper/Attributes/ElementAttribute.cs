using Code.Exercise.Helper.Enums;
using System;

namespace Code.Exercise.Helper.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ElementAttribute : Attribute
    {
        public string Name { get; set; }

        public ElementType Type { get; set; }

        public ElementAttribute(string name, ElementType type)
        {
            Name = name;
            Type = type;
        }
    }
}
