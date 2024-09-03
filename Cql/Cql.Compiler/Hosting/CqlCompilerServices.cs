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
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Compiler.Hosting;

internal readonly struct CqlCompilerServices(IServiceProvider serviceProvider)
{
    public IServiceProvider ServiceProvider { get; } = serviceProvider;

    public ModelInspector ModelInspector => ServiceProvider.GetRequiredService<ModelInspector>();

    public TypeConverter TypeConverter => ServiceProvider.GetRequiredService<TypeConverter>();

    public TypeResolver TypeResolver => ServiceProvider.GetRequiredService<TypeResolver>();

    public CqlOperatorsBinder CqlOperatorsBinder => ServiceProvider.GetRequiredService<CqlOperatorsBinder>();

    public CqlContextBinder CqlContextBinder => ServiceProvider.GetRequiredService<CqlContextBinder>();

    public TypeManager TypeManager => ServiceProvider.GetRequiredService<TypeManager>();

    public LibrarySetExpressionBuilder LibrarySetExpressionBuilder => ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();

    public LibraryExpressionBuilder LibraryExpressionBuilder => ServiceProvider.GetRequiredService<LibraryExpressionBuilder>();

    public ExpressionBuilderSettings ExpressionBuilderSettings => ServiceProvider.GetRequiredService<ExpressionBuilderSettings>();

    public ExpressionBuilder ExpressionBuilder => ServiceProvider.GetRequiredService<ExpressionBuilder>();
}