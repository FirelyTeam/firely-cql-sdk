/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Creates an <see cref="CodeBuilderContext"/> per library; see the remarks there.
/// </summary>
internal class CodeBuilder(
    ILogger<CodeBuilder> logger,
    CodeBuilderSettings expressionBuilderSettings,
    CqlOperatorsBinder cqlOperatorsBinder,
    TupleBuilderCache tupleBuilderCache,
    TypeResolver typeResolver,
    TypeConverter typeConverter,
    CqlContextBinder cqlContextBinder)
{
    private readonly ILogger<CodeBuilder> _logger = logger;
    private readonly CodeBuilderSettings _expressionBuilderSettings = expressionBuilderSettings;
    private readonly CqlOperatorsBinder _cqlOperatorsBinder = cqlOperatorsBinder;
    private readonly TupleBuilderCache _tupleBuilderCache = tupleBuilderCache;
    private readonly TypeResolver _typeResolver = typeResolver;
    private readonly TypeConverter _typeConverter = typeConverter;
    private readonly CqlContextBinder _cqlContextBinder = cqlContextBinder;

    /*
     * The CodeBuilderContext is created anew for each of the ProcessXXX methods.
     * This works, because all but the ProcessExpressionDef methods only change state
     * on the LibraryCodeBuilderContext.
     *
     * Only ProcessExpressionDef changes state on the CodeBuilderContext.
     */

    public void ProcessIncludes(LibraryCodeBuilderContext libCtx, IncludeDef includeDef) =>
        NewCodeBuilderContext(libCtx)
            .ProcessIncludes(includeDef);

    internal CodeBuilderContext NewCodeBuilderContext(
        LibraryCodeBuilderContext libCtx,
        Dictionary<string, CodeLocal>? operands = null) =>
        new(_logger, _expressionBuilderSettings, _cqlOperatorsBinder, _tupleBuilderCache, _typeResolver, _typeConverter, _cqlContextBinder, libCtx, operands);

    public void ProcessValueSetDef(LibraryCodeBuilderContext libCtx, ValueSetDef valueSetDef) =>
        NewCodeBuilderContext(libCtx)
            .ProcessValueSetDef(valueSetDef);

    public void ProcessCodeDef(
        LibraryCodeBuilderContext libCtx,
        CodeDef codeDef,
        HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls) =>
        NewCodeBuilderContext(libCtx)
            .ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);

    public void ProcessCodeSystemDef(LibraryCodeBuilderContext libCtx, CodeSystemDef codeSystemDef) =>
        NewCodeBuilderContext(libCtx)
            .ProcessCodeSystemDef(codeSystemDef);

    public void ProcessConceptDef(LibraryCodeBuilderContext libCtx, ConceptDef conceptDef) =>
        NewCodeBuilderContext(libCtx)
            .ProcessConceptDef(conceptDef);

    public void ProcessParameterDef(LibraryCodeBuilderContext libCtx, ParameterDef parameterDef) =>
        NewCodeBuilderContext(libCtx)
            .ProcessParameterDef(parameterDef);

    public void ProcessExpressionDef(LibraryCodeBuilderContext libCtx, ExpressionDef expressionDef) =>
        NewCodeBuilderContext(libCtx, new Dictionary<string, CodeLocal>())
            .ProcessExpressionDef(expressionDef);
}
