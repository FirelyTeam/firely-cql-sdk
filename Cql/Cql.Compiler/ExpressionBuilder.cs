/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuilder(
    ILogger<ExpressionBuilder> logger,
    ExpressionBuilderSettings expressionBuilderSettings,
    CqlOperatorsBinder cqlOperatorsBinder,
    TupleBuilderCache tupleBuilderCache,
    TypeConverter typeConverter,
    TypeResolver typeResolver,
    CqlContextBinder cqlContextBinder)
{
    internal readonly CqlOperatorsBinder _cqlOperatorsBinder = cqlOperatorsBinder;
    internal readonly CqlContextBinder _cqlContextBinder = cqlContextBinder;
    internal readonly TupleBuilderCache TupleBuilderCache = tupleBuilderCache;
    internal readonly ILogger<ExpressionBuilder> _logger = logger;
    internal readonly TypeConverter _typeConverter = typeConverter;
    internal readonly TypeResolver _typeResolver = typeResolver;
    internal readonly ExpressionBuilderSettings _expressionBuilderSettings = expressionBuilderSettings;

    /*
     * The ExpressionBuilderContext is created anew for each of the ProcessXXX methods.
     * This works, because all but the ProcessExpressionDef methods only change state
     * on the ILibraryExpressionBuilderContext.
     *
     * Only ProcessExpressionDef changes state on the ExpressionBuilderContext.
     */

    public void ProcessIncludes(ILibraryExpressionBuilderContext libCtx, IncludeDef includeDef)
    {
        ExpressionBuilderContext context = new ExpressionBuilderContext(this, libCtx);
        context.ProcessIncludes(includeDef);
    }

    public void ProcessValueSetDef(ILibraryExpressionBuilderContext libCtx, ValueSetDef valueSetDef)
    {
        ExpressionBuilderContext context = new ExpressionBuilderContext(this, libCtx);
        context.ProcessValueSetDef(valueSetDef);
    }

    public void ProcessCodeDef(
        ILibraryExpressionBuilderContext libCtx,
        CodeDef codeDef,
        HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls)
    {
        ExpressionBuilderContext context = new ExpressionBuilderContext(this, libCtx);
        context.ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);
    }

    public void ProcessCodeSystemDef(ILibraryExpressionBuilderContext libCtx, CodeSystemDef codeSystemDef)
    {
        ExpressionBuilderContext context = new ExpressionBuilderContext(this, libCtx);
        context.ProcessCodeSystemDef(codeSystemDef);
    }

    public void ProcessConceptDef(ILibraryExpressionBuilderContext libCtx, ConceptDef conceptDef)
    {
        ExpressionBuilderContext context = new ExpressionBuilderContext(this, libCtx);
        context.ProcessConceptDef(conceptDef);
    }

    public void ProcessParameterDef(ILibraryExpressionBuilderContext libCtx, ParameterDef parameterDef)
    {
        ExpressionBuilderContext context = new ExpressionBuilderContext(this, libCtx);
        context.ProcessParameterDef(parameterDef);
    }

    public void ProcessExpressionDef(ILibraryExpressionBuilderContext libCtx, ExpressionDef expressionDef)
    {
        ExpressionBuilderContext context = new ExpressionBuilderContext(this, libCtx, new());
        context.ProcessExpressionDef(expressionDef);
    }

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