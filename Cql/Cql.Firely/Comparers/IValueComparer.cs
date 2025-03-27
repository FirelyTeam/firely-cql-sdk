/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class IValueComparer<T>() :
        CqlComparer<IValue<T>>(
            CqlComparerEqualsMethod.Compare,
            CqlComparerNullComparisonStrategy.EitherNullReturnsNull,
            CqlComparerEquivalentMethod.Compare)
    {
        protected internal override int? CompareValues(
            IValue<T> left,
            IValue<T> right,
            string? precision)
        {
            return Comparer<T>.Default.Compare(left.Value, right.Value);
        }

        protected override bool IsNull([NotNullWhen(false)] IValue<T>? value)
        {
            return value is null || value.Value is null;
        }

        protected override int GetHashCodeValue(IValue<T> value) =>
            value.Value?.GetHashCode()
            ?? GetHashCodeForNull();
    }
}
