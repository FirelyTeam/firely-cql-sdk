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
    internal class CodeComparer<T> : CqlComparer<Code<T>>
        where T : struct, Enum
    {
        public CodeComparer(CqlComparers valueComparer)
        {
            if (typeof(T).IsEnum ||
                (typeof(T).IsGenericType
                    && typeof(T).GetGenericTypeDefinition() == typeof(Nullable<>)
                    && Nullable.GetUnderlyingType(typeof(T))!.IsEnum))
            {
                _compareFunction = CompareEnums;
                _equivalentFunction = EquivalentEnums;

            }
            else
            {
                _compareFunction = (a,b, precision) => valueComparer.Compare(a, b, precision);
                _equivalentFunction = (a, b, precision) => valueComparer.Equivalent(a, b, precision); ;
            }
        }

        delegate int? CompareFunction<in TComp>(TComp? x, TComp? y, string? precision);
        private readonly CompareFunction<T?> _compareFunction;
        delegate bool EquivalentFunction<in TComp>(TComp? x, TComp? y, string? precision);
        private readonly EquivalentFunction<T?> _equivalentFunction;

        private static int? CompareEnums(T? x, T? y, string? precision) => Comparer<T?>.Default.Compare(x, y);

        private static bool EquivalentEnums(T? x, T? y, string? precision) => Equals(x, y);

        // public override int? Compare(Code<T>? x, Code<T>? y, string? precision)
        // {
        //     if (x == null || y == null)
        //         return null;
        //     return _compareFunction(x.Value!, y.Value!, precision);
        // }

        protected override bool IsNull(Code<T>? value) => value?.Value is null;

        public override int? Compare(
            Code<T>? left,
            Code<T>? right,
            string? precision) =>
            _compareFunction(left?.Value!, right?.Value!, precision);

        protected override bool EquivalentValues(Code<T> x, Code<T> y, string? precision) =>
            _equivalentFunction(x.Value!, y.Value!, precision);

        // protected override bool EquivalentImpl(Code<T> x, Code<T> y, string? precision) =>
        //     _equivalentFunction(x.Value!, y.Value!, precision);

        // public override int GetHashCode(Code<T>? x) =>
        //     x == null ? typeof(Code<T>).GetHashCode() : typeof(Code<T>).GetHashCode() ^ x.Value.GetHashCode();

        protected override int GetHashCodeValue(Code<T> value) =>
            GetHashCodeForNull() ^ value.Value.GetHashCode();
    }
}
