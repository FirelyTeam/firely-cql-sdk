/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Fhir.Introspection;

// ReSharper disable once CheckNamespace
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Microsoft.Extensions.DependencyInjection;


internal static class CqlCompilerServiceProviderExtensions
{
    public static ModelInspector GetModelInspector(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<ModelInspector>();

    public static TypeConverter GetTypeConverter(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<TypeConverter>();

    public static TypeResolver GetTypeResolver(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<TypeResolver>();

    public static CqlOperatorsBinder GetCqlOperatorsBinder(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<CqlOperatorsBinder>();

    public static CqlContextBinder GetCqlContextBinder(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<CqlContextBinder>();

    public static TupleBuilderCache GetTupleBuilderCache(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<TupleBuilderCache>();

    public static LibrarySetExpressionBuilder GetLibrarySetExpressionBuilder(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<LibrarySetExpressionBuilder>();

    public static LibraryExpressionBuilder GetLibraryExpressionBuilder(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<LibraryExpressionBuilder>();

    public static ExpressionBuilder GetExpressionBuilder(this IServiceProvider serviceProvider) =>
        serviceProvider.GetRequiredService<ExpressionBuilder>();
}