using System;

namespace JasminSharp.Helpers
{
    public class TextValue : Attribute
    {
        public string Value { get; }

        public TextValue(string value)
        {
            Value = value;
        }
    }
}