/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class ResourceIdCqlComparer(ICqlComparer<string> idComparer) :
        CqlComparerAdapter<Resource, string>(idComparer, resource => resource.Id);
}
