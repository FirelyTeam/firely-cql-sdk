/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging.PostProcessors;

internal abstract class FhirResourcePostProcessor
{
    public abstract void ProcessResource(Resource resource);
}

internal class StubFhirResourcePostProcessor : FhirResourcePostProcessor
{
    public override void ProcessResource(Resource resource)
    {
    }
}