﻿/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.CodeGeneration.NET.PostProcessors;
using Hl7.Cql.Compiler.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Hl7.Cql.CodeGeneration.NET.DependencyInjection;

internal static class CqlCodeGenerationServicesInitializer
{
    internal static CqlCodeGenerationServices GetCqlCodeGenerationServices(this IServiceProvider serviceProvider) =>
        new CqlCodeGenerationServices(serviceProvider);

    public static IServiceCollection AddCqlCodeGenerationServices(this IServiceCollection services)
    {
        services.AddCqlCompilerServices();

        services.TryAddSingleton<TypeToCSharpConverter>();

        services.TryAddSingleton<CSharpLibrarySetToStreamsWriter>();

        services.TryAddSingletonSwitch<CSharpCodeStreamPostProcessor, WriteToFileCSharpCodeStreamPostProcessor, StubCSharpCodeStreamPostProcessor>(
            sp => sp.GetOptions<CSharpCodeWriterOptions>().Value.OutDirectory switch
            {
                null => 1,
                _    => 0
            });

        services.TryAddSingletonSwitch<AssemblyDataPostProcessor, WriteToFileAssemblyDataPostProcessor, StubAssemblyDataPostProcessor>(
            sp => sp.GetOptions<AssemblyDataWriterOptions>().Value.OutDirectory switch
            {
                null => 1,
                _    => 0
            });

        services.TryAddSingleton<AssemblyCompiler>();

        return services;
    }
}