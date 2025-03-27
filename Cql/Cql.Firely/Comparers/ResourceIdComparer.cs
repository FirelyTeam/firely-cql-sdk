/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class ResourceIdCqlComparer(ICqlComparer<string> idComparer) : CqlComparerNew<Resource>
    {
        protected override bool EquivalentValues(
            Resource left,
            Resource right,
            string? precision) =>
            idComparer.Equivalent(left.Id, right.Id, precision);

        protected override bool? EqualsValues(
            Resource left,
            Resource right,
            string? precision) =>
            idComparer.Equals(left.Id, right.Id, precision);

        protected override int? CompareValues(
            Resource left,
            Resource right,
            string? precision) =>
            idComparer.Compare(left.Id, right.Id, precision);

        protected override bool IsNull([NotNullWhen(false)] Resource? value) =>
            value?.Id is null;

        protected override int GetHashCodeValue(Resource value) =>
            idComparer.GetHashCode(value.Id);
    }

    /*
    internal class ResourceIdCqlComparer(ICqlComparer<string> idComparer) : CqlComparerBase<Resource>
    {
        private ICqlComparer<string> IdComparer { get; } = idComparer ?? throw new ArgumentNullException(nameof(idComparer));

        public override int? Compare(Resource? left, Resource? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            var compareId = IdComparer.Compare(left.Id, right.Id, precision);
            return compareId;

        }

        public override bool? Equals(Resource? left, Resource? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            var compareId = IdComparer.Equals(left.Id, right.Id, precision);
            return compareId;
        }

        protected override bool EquivalentImpl(Resource x, Resource y, string? precision) =>
            IdComparer.Equivalent(x.Id, y.Id, precision);

        public override int GetHashCode(Resource? value)
        {
            if (value == null || value.Id == null)
                return typeof(Resource).GetHashCode();
            else
                return value.Id.GetHashCode();
        }
    }
*/
}
