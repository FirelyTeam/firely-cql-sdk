﻿using Hl7.Fhir.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Firely.Comparers
{
    internal class FirelyEnumComparer: ICqlComparer
    {

        public static readonly FirelyEnumComparer Default = new FirelyEnumComparer();
        private FirelyEnumComparer() { }
        /// <inheritdoc/>
        public int? Compare(object x, object y, string? precision)
        {
            if (x == null || y == null) return null;
            var xType = x.GetType();
            var yType = y.GetType();
            if (xType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(x, y);
                else if (typeof(string).IsAssignableFrom(yType))
                    return CompareEnumToString(x, (string)y);
            }
            else if (yType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(x, y);
                else if (typeof(string).IsAssignableFrom(xType))
                    return CompareEnumToString(y, (string)x) * -1;
            }
            return null;
        }

        private static int CompareEnumToString(object @enum, string value)
        {
            var enumType = @enum.GetType();
            var enumStringValue = Enum.GetName(@enum.GetType(), @enum)!;
            var memberInfo = enumType.GetMember(enumStringValue).Single();
            var literalAttribute = memberInfo.GetCustomAttribute<EnumLiteralAttribute>();
            if (literalAttribute != null)
            {
                return string.Compare(literalAttribute.Literal, value, StringComparison.OrdinalIgnoreCase);
            }
            else return string.Compare(enumStringValue, value, StringComparison.OrdinalIgnoreCase);
        }

        /// <inheritdoc/>
        public bool? Equals(object x, object y, string? precision)
        {
            var result = Compare(x, y, precision);
            if (result == null) return null;
            else return result == 0;
        }

        /// <inheritdoc/>
        public bool Equivalent(object x, object y, string? precision) => (Equals(x, y, precision) ?? false) == false;

        /// <inheritdoc/>
        public int GetHashCode(object x)
        {
            if (x == null) return typeof(object).GetHashCode();
            else return x.GetHashCode();
        }
    }
}
