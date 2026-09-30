/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class ResourceIdCqlComparer(ICqlComparer<string> idComparer) :
        CqlComparerWrapper<Resource, string>(idComparer, r => r.Id)
    {
        private ICqlComparer<string> IdComparer { get; } = idComparer;

        /// <summary>
        /// Two resources are equivalent exactly when <see cref="IdComparer"/> compares their ids as the same, as for
        /// resource equality: the configured id comparer decides resource identity for both operators, not the CQL
        /// string equivalence, which ignores case.
        /// </summary>
        protected override bool EquivalentValues(
            [DisallowNull] Resource x,
            [DisallowNull] Resource y,
            string? precision) =>
            IdComparer.Compare(x.Id, y.Id, precision) == 0;
    }
}
