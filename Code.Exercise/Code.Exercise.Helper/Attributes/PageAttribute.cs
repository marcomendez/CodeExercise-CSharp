using System;

namespace Code.Exercise.Helper.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PageAttribute : Attribute
    {
        public string Name { set; get; }

        public PageAttribute(string name)
        {
            Name = name;
        }
    }
}
