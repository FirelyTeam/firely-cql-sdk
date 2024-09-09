/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class IValueComparer<T> : CqlComparerBase<IValue<T>>
    {
        public override int? Compare(IValue<T>? x, IValue<T>? y, string? precision) =>
            x == null || y == null || x.Value == null || y.Value == null
            ? null
            : Comparer<T>.Default.Compare(x.Value, y.Value);

        protected override bool EquivalentImpl(IValue<T> x, IValue<T> y, string? precision) => Compare(x, y, precision) == 0;

        public override int GetHashCode(IValue<T>? x)
        {
            if (x == null || x.Value == null)
                return typeof(Integer).GetHashCode();
            return x.Value.GetHashCode();
        }

    }
}
