/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Abstractions;
using Hl7.Fhir.Utility;
using System.Reflection;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class FhirEnumComparer : ICqlComparer
    {

        public static readonly FhirEnumComparer Default = new FhirEnumComparer();
        private FhirEnumComparer() { }
        /// <inheritdoc/>
        public int? Compare(object? x, object? y, string? precision)
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
        public bool? Equals(object? x, object? y, string? precision)
        {
            var result = Compare(x, y, precision);
            if (result == null) return null;
            else return result == 0;
        }

        /// <inheritdoc/>
        public bool Equivalent(object? x, object? y, string? precision) =>
            (Equals(x, y, precision) ?? false) == false;

        /// <inheritdoc/>
        public int GetHashCode(object? x) =>
            x?.GetHashCode() ?? typeof(object).GetHashCode();
    }
}
