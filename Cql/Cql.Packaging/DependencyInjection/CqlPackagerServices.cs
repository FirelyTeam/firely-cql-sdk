/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.DependencyInjection;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Packaging.DependencyInjection;

internal class CqlPackagerServices(IServiceProvider serviceProvider)
    : CqlCodeGenerationServices(serviceProvider)
{
    public CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper => ServiceProvider.GetRequiredService<CqlTypeToFhirTypeMapper>();

    public FhirResourcePostProcessor FhirResourcePostProcessor => ServiceProvider.GetRequiredService<FhirResourcePostProcessor>();

    public ResourcePackager ResourcePackager => ServiceProvider.GetRequiredService<ResourcePackager>();

    public CqlToResourcePackagingPipeline CqlToResourcePackagingPipeline => ServiceProvider.GetRequiredService<CqlToResourcePackagingPipeline>();
}