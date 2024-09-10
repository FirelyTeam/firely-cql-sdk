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
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuilder(
    ILogger<ExpressionBuilder> logger,
    ExpressionBuilderSettings expressionBuilderSettings,
    CqlOperatorsBinder cqlOperatorsBinder,
    TupleBuilderCache tupleBuilderCache,
    TypeResolver typeResolver,
    CqlContextBinder cqlContextBinder)
{
    /*
     * The ExpressionBuilderContext is created anew for each of the ProcessXXX methods.
     * This works, because all but the ProcessExpressionDef methods only change state
     * on the ILibraryExpressionBuilderContext.
     *
     * Only ProcessExpressionDef changes state on the ExpressionBuilderContext.
     */

    public void ProcessIncludes(ILibraryExpressionBuilderContext libCtx, IncludeDef includeDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessIncludes(includeDef);

    internal ExpressionBuilderContext NewExpressionBuilderContext(
        ILibraryExpressionBuilderContext libCtx,
        Dictionary<string, ParameterExpression>? operands = null) =>
        new(logger, expressionBuilderSettings, cqlOperatorsBinder, tupleBuilderCache, typeResolver, cqlContextBinder, libCtx, operands);

    public void ProcessValueSetDef(ILibraryExpressionBuilderContext libCtx, ValueSetDef valueSetDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessValueSetDef(valueSetDef);

    public void ProcessCodeDef(
        ILibraryExpressionBuilderContext libCtx,
        CodeDef codeDef,
        HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);

    public void ProcessCodeSystemDef(ILibraryExpressionBuilderContext libCtx, CodeSystemDef codeSystemDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessCodeSystemDef(codeSystemDef);

    public void ProcessConceptDef(ILibraryExpressionBuilderContext libCtx, ConceptDef conceptDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessConceptDef(conceptDef);

    public void ProcessParameterDef(ILibraryExpressionBuilderContext libCtx, ParameterDef parameterDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessParameterDef(parameterDef);

    public void ProcessExpressionDef(ILibraryExpressionBuilderContext libCtx, ExpressionDef expressionDef) =>
        NewExpressionBuilderContext(libCtx, new Dictionary<string, ParameterExpression>())
            .ProcessExpressionDef(expressionDef);

    internal static PropertyInfo? GetProperty(Type type, string name, TypeResolver typeResolver)
    {
        if (type.IsGenericType)
        {
            var gtd = type.GetGenericTypeDefinition();
            if (gtd == typeof(Nullable<>))
            {
                if (string.Equals(name, "value", StringComparison.OrdinalIgnoreCase))
                {
                    var valueMember = type.GetProperty("Value");
                    return valueMember;
                }
            }
        }

        var member = typeResolver.GetProperty(type, name);
        return member;
    }
}