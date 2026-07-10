/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// IR counterpart of <see cref="ExpressionBuilder"/>. This is a mechanical port; see the
/// remarks on <see cref="IrExpressionBuilderContext"/>.
/// </summary>
internal class IrExpressionBuilder(
    ILogger<IrExpressionBuilder> logger,
    ExpressionBuilderSettings expressionBuilderSettings,
    IrCqlOperatorsBinder cqlOperatorsBinder,
    TupleBuilderCache tupleBuilderCache,
    TypeResolver typeResolver,
    TypeConverter typeConverter,
    IrCqlContextBinder cqlContextBinder)
{
    private readonly ILogger<IrExpressionBuilder> _logger = logger;
    private readonly ExpressionBuilderSettings _expressionBuilderSettings = expressionBuilderSettings;
    private readonly IrCqlOperatorsBinder _cqlOperatorsBinder = cqlOperatorsBinder;
    private readonly TupleBuilderCache _tupleBuilderCache = tupleBuilderCache;
    private readonly TypeResolver _typeResolver = typeResolver;
    private readonly TypeConverter _typeConverter = typeConverter;
    private readonly IrCqlContextBinder _cqlContextBinder = cqlContextBinder;

    /*
     * The IrExpressionBuilderContext is created anew for each of the ProcessXXX methods.
     * This works, because all but the ProcessExpressionDef methods only change state
     * on the IrLibraryExpressionBuilderContext.
     *
     * Only ProcessExpressionDef changes state on the IrExpressionBuilderContext.
     */

    public void ProcessIncludes(IrLibraryExpressionBuilderContext libCtx, IncludeDef includeDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessIncludes(includeDef);

    internal IrExpressionBuilderContext NewExpressionBuilderContext(
        IrLibraryExpressionBuilderContext libCtx,
        Dictionary<string, IrLocal>? operands = null) =>
        new(_logger, _expressionBuilderSettings, _cqlOperatorsBinder, _tupleBuilderCache, _typeResolver, _typeConverter, _cqlContextBinder, libCtx, operands);

    public void ProcessValueSetDef(IrLibraryExpressionBuilderContext libCtx, ValueSetDef valueSetDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessValueSetDef(valueSetDef);

    public void ProcessCodeDef(
        IrLibraryExpressionBuilderContext libCtx,
        CodeDef codeDef,
        HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);

    public void ProcessCodeSystemDef(IrLibraryExpressionBuilderContext libCtx, CodeSystemDef codeSystemDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessCodeSystemDef(codeSystemDef);

    public void ProcessConceptDef(IrLibraryExpressionBuilderContext libCtx, ConceptDef conceptDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessConceptDef(conceptDef);

    public void ProcessParameterDef(IrLibraryExpressionBuilderContext libCtx, ParameterDef parameterDef) =>
        NewExpressionBuilderContext(libCtx)
            .ProcessParameterDef(parameterDef);

    public void ProcessExpressionDef(IrLibraryExpressionBuilderContext libCtx, ExpressionDef expressionDef) =>
        NewExpressionBuilderContext(libCtx, new Dictionary<string, IrLocal>())
            .ProcessExpressionDef(expressionDef);
}
