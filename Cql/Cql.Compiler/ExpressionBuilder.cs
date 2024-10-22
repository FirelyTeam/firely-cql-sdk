/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuilder(
    ILogger<ExpressionBuilder> logger,
    ExpressionBuilderSettings expressionBuilderSettings,
    CqlOperatorsBinder cqlOperatorsBinder,
    TupleBuilderCache tupleBuilderCache,
    TypeResolver typeResolver,
    CqlContextBinder cqlContextBinder,
    IModelProvider modelProvider)
{
    private readonly ILogger<ExpressionBuilder> _logger = logger;
    private readonly ExpressionBuilderSettings _expressionBuilderSettings = expressionBuilderSettings;
    private readonly CqlOperatorsBinder _cqlOperatorsBinder = cqlOperatorsBinder;
    private readonly TupleBuilderCache _tupleBuilderCache = tupleBuilderCache;
    private readonly TypeResolver _typeResolver = typeResolver;
    private readonly CqlContextBinder _cqlContextBinder = cqlContextBinder;
    private readonly IModelProvider _modelProvider = modelProvider;

    /*
     * The ExpressionBuilderContext is created anew for each of the ProcessXXX methods.
     * This works, because all but the ProcessExpressionDef methods only change state
     * on the LibraryExpressionBuilderContext.
     *
     * Only ProcessExpressionDef changes state on the ExpressionBuilderContext.
     */

    public void ProcessIncludes(LibraryExpressionBuilderContext libCtx, IncludeDef includeDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessIncludes(includeDef);

    internal ExpressionBuilderContext NewExpressionBuilderContext(
        LibraryExpressionBuilderContext libCtx,
        Dictionary<string, ParameterExpression>? operands = null) =>
        new(_logger, _expressionBuilderSettings, _cqlOperatorsBinder, _tupleBuilderCache, _typeResolver, _cqlContextBinder, libCtx, _modelProvider, operands);

    public void ProcessValueSetDef(LibraryExpressionBuilderContext libCtx, ValueSetDef valueSetDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessValueSetDef(valueSetDef);

    public void ProcessCodeDef(
        LibraryExpressionBuilderContext libCtx,
        CodeDef codeDef,
        HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);

    public void ProcessCodeSystemDef(LibraryExpressionBuilderContext libCtx, CodeSystemDef codeSystemDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessCodeSystemDef(codeSystemDef);

    public void ProcessConceptDef(LibraryExpressionBuilderContext libCtx, ConceptDef conceptDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessConceptDef(conceptDef);

    public void ProcessParameterDef(LibraryExpressionBuilderContext libCtx, ParameterDef parameterDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessParameterDef(parameterDef);

    public void ProcessExpressionDef(LibraryExpressionBuilderContext libCtx, ExpressionDef expressionDef) =>
        NewExpressionBuilderContext(libCtx, new Dictionary<string, ParameterExpression>())
            .ProcessExpressionDef(expressionDef);
}