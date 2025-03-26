/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;
using TypeExtensions = Hl7.Cql.Abstractions.Infrastructure.TypeExtensions;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class CodeComparer<T> : CqlComparerBase<Code<T>>
        where T : struct, Enum
    {
        public CodeComparer(CqlComparers valueComparer)
        {
            // Comparing Code<TEnum> or Code<TEnum?>
            if (TypeExtensions.IsEnum(typeof(T)))
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

        private static int? CompareEnums(T? x, T? y, string? precision) =>
            CompareOnNullsOnly(x, y)
            ?? Comparer<T?>.Default.Compare(x, y);

        private static bool EquivalentEnums(T? x, T? y, string? precision) =>
            EquivalentOnNullsOnly(x, y)
            ?? Equals(x, y);

        public override int? Compare(Code<T>? x, Code<T>? y, string? precision) =>
            CompareOnNullsOnly(x?.Value, y?.Value)
            ?? _compareFunction(x?.Value!, y?.Value!, precision);

        protected override bool EquivalentImpl(Code<T> x, Code<T> y, string? precision) =>
            _equivalentFunction(x.Value!, y.Value!, precision);

        public override int GetHashCode(Code<T>? x) =>
            x?.Value == null
                ? GetHashCodeForType<Code<T>>()
                : HashCode.Combine(GetHashCodeForType<Code<T>>(), x.Value.GetHashCode());
    }
}
