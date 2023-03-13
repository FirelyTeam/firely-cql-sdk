using Ncqa.Iso8601;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Fhir.R4.Model
{
    // Adds implicit operators to assign the value property of commonly used Element derivations.


    partial class BooleanElement
    {
        public static implicit operator bool?(BooleanElement element) =>
            element is null ? null : element.value;
        public static implicit operator BooleanElement(bool? value) =>
            value is null ? null : new BooleanElement { value = value.Value };
        public static implicit operator BooleanElement(bool value) => new BooleanElement { value = value };

    }
    partial class CanonicalElement
    {
        public static implicit operator string(CanonicalElement element) =>
            element is null ? null : element.value;
        public static implicit operator CanonicalElement(string value) =>
            value is null ? null : new CanonicalElement { value = value };
    }

    

    partial class CodeElement
    {
        public static implicit operator string(CodeElement element) =>
            element is null ? null : element.value;
        public static implicit operator CodeElement(string value) =>
             value is null ? null : new CodeElement { value = value };
    }


    partial class DateTimeElement
    {
        public static implicit operator DateTimeIso8601(DateTimeElement element) =>
            element is null ? null : element.value;
        public static implicit operator DateTimeElement(DateTimeIso8601 value) =>
             value is null ? null : new DateTimeElement { value = value };
    }
    partial class DateElement
    {
        public static implicit operator DateIso8601(DateElement element) =>
            element is null ? null : element.value;
        public static implicit operator DateElement(DateIso8601 value) =>
             value is null ? null : new DateElement { value = value };
    }


    partial class DecimalElement
    {
        public static implicit operator decimal?(DecimalElement element) =>
                  element is null ? null : element.value;
        public static implicit operator DecimalElement(decimal? value) =>
            value is null ? null : new DecimalElement { value = value.Value };
        public static implicit operator DecimalElement(decimal value) => new DecimalElement { value = value };
    }

    partial class IdElement
    {
        public static implicit operator string(IdElement element) =>
            element is null ? null : element.value;
        public static implicit operator IdElement(string value) =>
            value is null ? null : new IdElement { value = value };
    }

    partial class InstantElement
    {
        public static implicit operator DateTimeIso8601(InstantElement element) =>
            element is null ? null : element.value;
        public static implicit operator InstantElement(DateTimeIso8601 value) =>
            value is null ? null : new InstantElement { value = value };
    }

    partial class IntegerElement
    {
        public static implicit operator int?(IntegerElement element) =>
            element is null ? null : element.value;
        public static implicit operator IntegerElement(int? value) =>
            value is null ? null : new IntegerElement { value = value.Value };
        public static implicit operator IntegerElement(int value) => new IntegerElement { value = value };
    }

    partial class PositiveIntElement
    {
        public static implicit operator int?(PositiveIntElement element) =>
            element is null ? null : element.value;
        public static implicit operator PositiveIntElement(int? value) =>
            value is null ? null : new PositiveIntElement { value = value.Value };
        public static implicit operator PositiveIntElement(int value) => new PositiveIntElement { value = value };
    }

    partial class StringElement
    {
        public static implicit operator string(StringElement element) => 
            element is null ? null : element.value;
        public static implicit operator StringElement(string value) =>
            value is null ? null : new IdElement { value = value };
    }

    partial class UnsignedIntElement
    {
        public static implicit operator int?(UnsignedIntElement element) =>
            element is null ? null : element.value;
        public static implicit operator uint?(UnsignedIntElement element) => (uint?)element.value;
        public static implicit operator UnsignedIntElement(uint? value)
        {
            if (value is null)
                return null;
            else if (value > int.MaxValue)
                throw new OverflowException("Unsigned integers are constrained to the range of 0..2,147,483,647");
            else return new UnsignedIntElement { value = (int)value.Value };
        }
        public static implicit operator UnsignedIntElement(uint value)
        {
            if (value > int.MaxValue)
                throw new OverflowException("Unsigned integers are constrained to the range of 0..2,147,483,647");
            else return new UnsignedIntElement { value = (int)value };
        }


        }

    partial class UriElement
    {
        public static implicit operator string(UriElement element) =>
            element is null ? null : element.value;
        public static implicit operator UriElement(string value) =>
            value is null ? null : new UriElement { value = value };

        public static implicit operator Uri(UriElement element) => new Uri(element.value);
        public static implicit operator UriElement(Uri value) =>
            value is null ? null : new UriElement { value = value.ToString() };
    }
}
