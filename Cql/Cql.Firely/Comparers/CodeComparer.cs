/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class CodeComparer<T> : CqlComparerBase<Code<T>>
        where T : struct, Enum
    {
        public CodeComparer(ICqlComparer valueComparer)
        {
            ValueComparer = valueComparer;
            if (typeof(T).IsEnum ||
                (typeof(T).IsGenericType
                    && typeof(T).GetGenericTypeDefinition() == typeof(Nullable<>)
                    && Nullable.GetUnderlyingType(typeof(T))!.IsEnum))
            {
                CompareFunction = CompareEnums;
                EquivalentFunction = EquivalentEnums;

            }
            else
            {
                CompareFunction = (x, y, precision) => valueComparer.Compare(x, y, precision);
                EquivalentFunction = (x, y, precision) => valueComparer.Equivalent(x, y, precision);
            }
        }

        public ICqlComparer ValueComparer { get; }

        private readonly Func<T?, T?, string?, int?> CompareFunction;
        private readonly Func<T?, T?, string?, bool> EquivalentFunction;

        private int? CompareEnums(T? x, T? y, string? precision) => Comparer<T?>.Default.Compare(x, y);
        private bool EquivalentEnums(T? x, T? y, string? precision) => Equals(x, y);

        public override int? Compare(Code<T>? x, Code<T>? y, string? precision)
        {
            if (x == null || y == null)
                return null;
            return CompareFunction(x.Value!, y.Value!, precision);
        }

        protected override bool EquivalentImpl(Code<T> x, Code<T> y, string? precision) =>
            EquivalentFunction(x.Value!, y.Value!, precision);

        public override int GetHashCode(Code<T>? x) =>
            x == null ? typeof(Code<T>).GetHashCode() : typeof(Code<T>).GetHashCode() ^ x.Value.GetHashCode();
    }
}
