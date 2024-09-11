/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Hosting;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Packaging.Hosting;

internal readonly struct CqlPackagingServices(IServiceProvider serviceProvider)
{
    public CqlCodeGenerationServices GetCqlCodeGenerationServices() => new(serviceProvider);

    public CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper => serviceProvider.GetRequiredService<CqlTypeToFhirTypeMapper>();

    public FhirResourcePostProcessor FhirResourcePostProcessor => serviceProvider.GetRequiredService<FhirResourcePostProcessor>();

    public ResourcePackager ResourcePackager => serviceProvider.GetRequiredService<ResourcePackager>();

    public CqlToResourcePackagingPipeline CqlToResourcePackagingPipelineScoped() => serviceProvider.GetRequiredService<CqlToResourcePackagingPipeline>();
}