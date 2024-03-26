using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
[DebuggerDisplay("{DebuggerView}")]
internal partial class LibraryExpressionBuilder : IBuilderNode
{
    private readonly ILogger<LibraryExpressionBuilder> _logger;
    private readonly LibraryDefinitionBuilderSettings _libraryDefinitionBuilderSettings;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;
    private readonly ILoggerFactory _loggerFactory;
    public LibrarySetExpressionBuilder? LibrarySetContext { get; }

    public LibraryExpressionBuilder(
        Library library,
        LibraryDefinitionBuilderSettings libraryDefinitionBuilderSettings,
        OperatorBinding operatorBinding,
        DefinitionDictionary<LambdaExpression> libraryDefinitions, 
        TypeManager typeManager,
        ILoggerFactory loggerFactory,
        LibrarySetExpressionBuilder? libsCtx = null)
    {
        // External Services
        _libraryDefinitionBuilderSettings = libraryDefinitionBuilderSettings;
        _operatorBinding = OperatorBindingRethrowDecorator.Decorate(this, operatorBinding);
        _typeManager = typeManager;
        _loggerFactory = loggerFactory;
        _logger = loggerFactory.CreateLogger<LibraryExpressionBuilder>();

        // External State
        LibraryDefinitions = libraryDefinitions;
        Library = library;
        LibrarySetContext = libsCtx;

        // Internal State
        _libraryNameAndVersionByAlias = new();
        _codesByName = new();
        _codesByCodeSystemName = new();
        _codeSystemIdsByCodeSystemRefs = new ByLibraryNameAndNameDictionary<string>();
    }

    public Library Library { get; }

    public string LibraryKey => Library.NameAndVersion()!;

    public bool AllowUnresolvedExternals => _libraryDefinitionBuilderSettings.AllowUnresolvedExternals;

    public ExpressionBuilder CreateExpressionBuilder() =>
        new(_loggerFactory.CreateLogger<ExpressionBuilder>(), _operatorBinding, _typeManager, _libraryDefinitionBuilderSettings, this);

    #region Definitions

    public DefinitionDictionary<LambdaExpression> LibraryDefinitions { get; }

    private void BuildIncludedDefinitions()
    {
        if (LibrarySetContext != null)
        {
            foreach (var libraryDependency in LibrarySetContext.LibrarySet.GetLibraryDependencies(LibraryKey))
            {
                AddDefinitions(libraryDependency);
            }
        }

        void AddDefinitions(Library library)
        {
            string libraryName = library.NameAndVersion(true)!;
            if (!HasAliasForNameAndVersion(libraryName))
                throw new LibraryAliasUnresolvedError(library).ToException();

            if (LibrarySetContext!.LibrarySetDefinitions.TryGetDefinitionsForLibrary(
                    libraryName,
                    out IEnumerable<KeyValuePair<string, List<(Type[], LambdaExpression)>>>? definitions))
            {
                LibraryDefinitions.Merge(libraryName, definitions);
            }
        }
    }

    #endregion

    #region Local Library Identifiers

    private readonly Dictionary<string, string> _libraryNameAndVersionByAlias;

    public void AddAliasForNameAndVersion(string alias, string libraryKey) =>
        _libraryNameAndVersionByAlias.Add(alias, libraryKey);

    public string? GetNameAndVersionFromAlias(string? alias, bool throwError = true)
    {
        if (alias == null)
            return LibraryKey;
        if (throwError)
            return _libraryNameAndVersionByAlias[alias];
        _libraryNameAndVersionByAlias.TryGetValue(alias, out string? libraryKey);
        return libraryKey;
    }

    public bool HasAliasForNameAndVersion(string libraryKey) => 
        _libraryNameAndVersionByAlias.ContainsValue(libraryKey);

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

    private void BuildIncludedCodeSystemRefs()
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
        var libraryName = GetNameAndVersionFromAlias(codeSystemRef.libraryName);
        return _codeSystemIdsByCodeSystemRefs.TryGetValue(new(libraryName, codeSystemRef.name), out url);
    }

    #endregion

    IBuilderNode? IBuilderNode.OuterBuilder => LibrarySetContext;

    BuilderDebuggerInfo? IBuilderNode.BuilderDebuggerInfo => BuilderDebuggerInfo.FromElement(Library);


    private readonly record struct LibraryNameAndName(string? LibraryName, string Name);

    private class ByLibraryNameAndNameDictionary<TValue> : Dictionary<LibraryNameAndName, TValue>
    {
    }

    public string DebuggerView => this.GetDebuggerView();
}

