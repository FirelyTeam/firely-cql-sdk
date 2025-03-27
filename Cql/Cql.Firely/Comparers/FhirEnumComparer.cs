/*
 * Copyright (c) 2024, NCQA and contributors
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

        private FhirEnumComparer() { }

        protected internal override CqlComparerEqualsStrategy GetEqualsStrategy() => CqlComparerEqualsStrategy.Compare;

        protected internal override CqlComparerNullComparisonStrategy GetNullComparisonStrategy() => CqlComparerNullComparisonStrategy.Or;

        protected internal override CqlComparerEquivalentStrategy GetEquivalentStrategy() => CqlComparerEquivalentStrategy.Equals;

        /// <inheritdoc/>
        protected override int? CompareValues(object left, object right, string? precision)
        {
            var xType = left.GetType();
            var yType = right.GetType();
            if (xType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(left, right);
                else if (typeof(string).IsAssignableFrom(yType))
                    return CompareEnumToString(left, (string)right);
            }
            else if (yType.IsEnum)
            {
                if (yType == xType)
                    return Comparer<object>.Default.Compare(left, right);
                else if (typeof(string).IsAssignableFrom(xType))
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

        // /// <inheritdoc/>
        // public bool? Equals(object? left, object? right, string? precision)
        // {
        //     var result = Compare(left, right, precision);
        //     if (result == null) return null;
        //     else return result == 0;
        // }

        // /// <inheritdoc/>
        // public override bool Equivalent(object? left, object? right, string? precision) =>
        //     EquivalentViaEquals(left, right, precision);

        //
        // /// <inheritdoc/>
        // public bool Equivalent(object? left, object? right, string? precision) =>
        //     (Equals(left, right, precision) ?? false) == false;
        //

        // /// <inheritdoc/>
        // public int GetHashCode(object? value) =>
        //     value?.GetHashCode() ?? typeof(object).GetHashCode();
    }
}
