/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class FhirEnumComparer : CqlComparer<object>
    {
        public static readonly FhirEnumComparer Default = new();

        private FhirEnumComparer() : base(
            CqlComparerEqualsMethod.Compare, CqlComparerNullComparisonStrategy.EitherNullReturnsNull, CqlComparerEquivalentMethod.Equals) { }

        /// <inheritdoc/>
        protected internal override int? CompareValues(object left, object right, string? precision)
        {
            var xType = left.GetType();
            var yType = right.GetType();

            if (xType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(left, right);

                if (typeof(string).IsAssignableFrom(yType))
                    return CompareEnumToString(left, (string)right);
            }
            else if (yType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(left, right);

                if (typeof(string).IsAssignableFrom(xType))
                    return CompareEnumToString(right, (string)left) * -1;
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
    }
}
