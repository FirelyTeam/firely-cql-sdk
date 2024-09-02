/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Conversion;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Compiler.DependencyInjection;

internal class CqlCompilerServices(IServiceProvider serviceProvider) : IDisposable
{
    public IServiceProvider ServiceProvider { get; private set; } = serviceProvider;

    public TypeConverter TypeConverter => ServiceProvider.GetRequiredService<TypeConverter>();

    public TypeResolver TypeResolver => ServiceProvider.GetRequiredService<TypeResolver>();

    public TypeManager TypeManager => ServiceProvider.GetRequiredService<TypeManager>();

    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder => ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();

    public LibraryExpressionBuilder LibraryExpressionBuilder => ServiceProvider.GetRequiredService<LibraryExpressionBuilder>();

    public void Dispose()
    {
        var sp = ServiceProvider;
        ServiceProvider = null!;
        (sp as IDisposable)?.Dispose();
    }
}