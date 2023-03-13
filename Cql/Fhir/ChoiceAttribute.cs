using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Fhir
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ChoiceAttribute: Attribute
    {
        public ChoiceAttribute(Type Type)
        {
            this.Type = Type;
        }
        public Type Type { get; }

        public static T? AsExactly<T>(object? value) 
            where T : class
        {
            if (value is null)
                return null;
            else if (typeof(T) == value.GetType())
                return value as T;
            else return null;
        }
    }
}
