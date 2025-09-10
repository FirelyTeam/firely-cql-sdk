/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class IValueComparer<T>() :
        CqlComparer<object>(
            CqlComparerEqualsImplementation.Compare,
            CqlComparerEquivalentImplementation.Compare)
    {
        protected override int? CompareValues(
            object x,
            object y,
            string? precision)
        {
            switch (x, y)
            {
                case (IValue<T> xValue, IValue<T> yValue):
                    if (precision != null)
                        throw new InvalidOperationException($"Precision '{precision}' is not supported for comparing IValue<T>.");
                    return Comparer<T>.Default.Compare(xValue.Value, yValue.Value);
                case (IValue<T> xValue, T yVal):
                    if (precision != null)
                        throw new InvalidOperationException($"Precision '{precision}' is not supported for comparing IValue<T>.");
                    return Comparer<T>.Default.Compare(xValue.Value, yVal);
                case (T , IValue<T>):
                    throw new InvalidOperationException("IValue<T> should always be compared left of T.");
                default:
                    throw new InvalidOperationException($"Cannot compare values of type '{x.GetType()}' and '{y.GetType()}' using IValue<T> comparer.");
            }
        }

        protected override bool IsNull([NotNullWhen(false)] object? value) =>
            value switch
            {
                null        => true,
                IValue<T> v => v.Value is null,
                T           => false,
                _           => throw new InvalidOperationException($"Cannot compare values of type '{value.GetType()}'.")
            };

        protected override int GetHashCodeValue(object value) =>
            value switch
            {
                null        => GetHashCodeForNull(),
                IValue<T> v => v.Value?.GetHashCode() ?? GetHashCodeForNull(),
                T v         => v.GetHashCode(),
                _           => throw new InvalidOperationException($"Cannot compare values of type '{value.GetType()}'.")
            };
    }
}
