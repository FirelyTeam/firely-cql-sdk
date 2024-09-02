/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Packaging.DependencyInjection;

internal class CqlPackagerServices(IServiceProvider serviceProvider)
    : CqlCompilerServices(serviceProvider)
{
    public CSharpLibrarySetToStreamsWriter CSharpLibrarySetToStreamsWriter => ServiceProvider.GetRequiredService<CSharpLibrarySetToStreamsWriter>();

    public AssemblyCompiler AssemblyCompiler => ServiceProvider.GetRequiredService<AssemblyCompiler>();
}