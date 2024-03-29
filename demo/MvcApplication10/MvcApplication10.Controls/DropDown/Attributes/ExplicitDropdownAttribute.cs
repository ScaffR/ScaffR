namespace MvcApplication10.Controls.DropDown.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class ExplicitDropdownAttribute : DropDownAttribute
    {
        public ExplicitDropdownAttribute(): base(null, null)
        {
            
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class DropdownOptionAttribute : Attribute
    {
        private string _text;
        private string _value;
        private int _order;

        public DropdownOptionAttribute(string text, string value, int order)
        {
            _order = order;
            _value = value;
            _text = text;
        }

        public string Text
        {
            get { return _text; }
        }

        public string Value
        {
            get { return _value; }
        }

        public int Order
        {
            get { return _order; }
        }
    }
}