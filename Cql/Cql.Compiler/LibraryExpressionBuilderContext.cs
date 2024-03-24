using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
[DebuggerDisplay("{DebuggerView}")]
internal partial class ContextualLibraryExpressionBuilder : IBuilderContext
{
    private readonly ILogger<ContextualLibraryExpressionBuilder> _logger;
    private readonly ExpressionBuilderSettings _expressionBuilderSettings;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;
    private readonly ILoggerFactory _loggerFactory;
    private ContextualLibrarySetExpressionBuilder? LibrarySetContext { get; }

    public ContextualLibraryExpressionBuilder(
        Library library,
        ExpressionBuilderSettings expressionBuilderSettings,
        OperatorBinding operatorBinding,
        DefinitionDictionary<LambdaExpression> definitions, 
        TypeManager typeManager,
        ILoggerFactory loggerFactory,
        ContextualLibrarySetExpressionBuilder? libsCtx = null)
    {

        _expressionBuilderSettings = expressionBuilderSettings;
        _operatorBinding = OperatorBindingRethrowDecorator.Decorate(this, operatorBinding);
        Definitions = definitions;
        _typeManager = typeManager;
        _loggerFactory = loggerFactory;
        _logger = loggerFactory.CreateLogger<ContextualLibraryExpressionBuilder>();
        Library = library;
        LibrarySetContext = libsCtx;
        _libraryNameAndVersionByAlias = new();
        _codesByName = new();
        _codesByCodeSystemName = new();
        _codeSystemIdsByCodeSystemRefs = new ByLibraryNameAndNameDictionary<string>();
        BuildUrlByCodeSystemRef();
    }

    public Library Library { get; }

    public string LibraryKey => Library.NameAndVersion()!;

    public bool AllowUnresolvedExternals => _expressionBuilderSettings.AllowUnresolvedExternals;

    public ContextualExpressionBuilder CreateContextualExpressionBuilder(
        Element element) =>
        new(_loggerFactory.CreateLogger<ContextualExpressionBuilder>(), _operatorBinding, _typeManager, _expressionBuilderSettings, this, element);

    #region Definitions

    public DefinitionDictionary<LambdaExpression> Definitions { get; }

    #endregion

    #region Local Library Identifiers

    private readonly Dictionary<string, string> _libraryNameAndVersionByAlias;

    public void AddIncludeAlias(string includeAlias, string includeNameAndVersion) =>
        _libraryNameAndVersionByAlias.Add(includeAlias, includeNameAndVersion);

    public string? GetIncludeNameAndVersion(string? alias, bool throwError = true)
    {
        if (alias == null)
            return LibraryKey;
        if (throwError)
            return _libraryNameAndVersionByAlias[alias];
        _libraryNameAndVersionByAlias.TryGetValue(alias, out string? result);
        return result;
    }

    #endregion

    #region Codes By CodeSystemName

    private readonly Dictionary<string, List<CqlCode>> _codesByCodeSystemName;

    public bool TryGetCodesByCodeSystemName(string codeSystemName, [NotNullWhen(true)] out List<CqlCode>? codes) =>
        _codesByCodeSystemName.TryGetValue(codeSystemName, out codes);

    private List<CqlCode> GetOrCreateCodesByCodeSystemName(string codeSystemName)
    {
        if (_codesByCodeSystemName.TryGetValue(codeSystemName!, out var codings))
            return codings;

        codings = new List<CqlCode>();
        _codesByCodeSystemName.Add(codeSystemName!, codings);
        return codings;
    }

    #endregion

    #region Codes By Name (cross library???)

    private readonly Dictionary<string, CqlCode> _codesByName;

    public bool TryGetCode(CodeRef codeRef, [NotNullWhen(true)] out CqlCode? systemCode) =>
        _codesByName.TryGetValue(codeRef.name, out systemCode);
    
    public void AddCode(CodeDef codeDef, CqlCode cqlCode)
    {
        _codesByName.Add(codeDef.name, cqlCode);

        var codeSystemName = codeDef.codeSystem!.name;
        var codings = GetOrCreateCodesByCodeSystemName(codeSystemName);
        codings.Add(cqlCode);
    }

    #endregion

    #region Url By CodeSystemRef (cross library)

    private readonly ByLibraryNameAndNameDictionary<string> _codeSystemIdsByCodeSystemRefs;

    private void BuildUrlByCodeSystemRef()
    {
        if (LibrarySetContext != null)
        {
            foreach (var libraryDependency in LibrarySetContext.LibrarySet.GetLibraryDependencies(LibraryKey))
            {
                AddCodeSystemRefs(libraryDependency);
            }
        }

        AddCodeSystemRefs(Library);

        void AddCodeSystemRefs(Library library)
        {
            if (library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    _codeSystemIdsByCodeSystemRefs.Add(new(library.NameAndVersion()!, codeSystemDef.name), codeSystemDef.id);
                }
            }
        }
    }

    public bool TryGetCodeSystemName(CodeSystemRef codeSystemRef, [NotNullWhen(true)]out string? url)
    {
        var libraryName = GetIncludeNameAndVersion(codeSystemRef.libraryName);
        return _codeSystemIdsByCodeSystemRefs.TryGetValue(new(libraryName, codeSystemRef.name), out url);
    }

    #endregion

    IBuilderContext? IBuilderContext.OuterContext => LibrarySetContext;

    BuilderContextInfo IBuilderContext.ContextInfo => BuilderContextInfo.FromElement(Library);


    private readonly record struct LibraryNameAndName(string? LibraryName, string Name);

    private class ByLibraryNameAndNameDictionary<TValue> : Dictionary<LibraryNameAndName, TValue>
    {
    }

    public string DebuggerView => this.GetDebuggerView();
}

