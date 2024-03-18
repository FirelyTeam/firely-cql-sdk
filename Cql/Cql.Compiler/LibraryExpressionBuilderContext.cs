using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
internal class LibraryExpressionBuilderContext : IBuilderContext
{
    private readonly ExpressionBuilder _expressionBuilder;
    private readonly OperatorBinding _operatorBinding;
    private readonly Library _library;
    private readonly LibrarySetExpressionBuilderContext? _libsCtx;

    public LibraryExpressionBuilderContext(
        Library library,
        ExpressionBuilder expressionBuilder,
        OperatorBinding operatorBinding,
        DefinitionDictionary<LambdaExpression> definitions,
        LibrarySetExpressionBuilderContext? libsCtx = null)
    {

        _expressionBuilder = expressionBuilder;
        _operatorBinding = operatorBinding;
        _definitions = definitions;
        _library = library;
        _libsCtx = libsCtx;
        _localLibraryIdentifiers = new();
        _codesByName = new();
        _codesByCodeSystemName = new();
        _codeSystemIdsByCodeSystemRefs = new ByLibraryNameAndNameDictionary<string>();
        BuildUrlByCodeSystemRef();
    }

    public Elm.Library Library => _library;

    public string LibraryKey => _library.GetNameAndVersion()!;

    public bool AllowUnresolvedExternals => _expressionBuilder.Settings.AllowUnresolvedExternals;

    public ExpressionBuilderContext NewExpressionBuilderContext(
        Elm.Element element) =>
        new ExpressionBuilderContext(
            _operatorBinding,
            _expressionBuilder,
            LibraryExpressionBuilder.ContextParameter,
            _definitions,
            _localLibraryIdentifiers,
            this,
            element);

    #region Definitions

    private readonly DefinitionDictionary<LambdaExpression> _definitions;

    public void AddDefinitionTag(string definition, Type[] signature, string name, params string[] values) =>
        _definitions.AddTag(LibraryKey, definition, signature, name, values);

    public void AddDefinition(string definition, LambdaExpression expression) =>
        _definitions.Add(LibraryKey, definition, expression);

    public void AddDefinition(string definition, Type[] signature, LambdaExpression expression) =>
        _definitions.Add(LibraryKey, definition, signature, expression);

    public bool ContainsDefinition(string definition, Type[] signature) =>
        _definitions.ContainsKey(LibraryKey, definition, signature);

    public bool ContainsDefinition(string definition) =>
        _definitions.ContainsKey(LibraryKey, definition);

    #endregion

    #region Local Library Identifiers

    private readonly Dictionary<string, string> _localLibraryIdentifiers;

    public void AddIncludeAlias(string includeAlias, string includeNameAndVersion) =>
        _localLibraryIdentifiers.Add(includeAlias, includeNameAndVersion);

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

    #region Codes By Name

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

    #region Url By CodeSystemRef

    private readonly ByLibraryNameAndNameDictionary<string> _codeSystemIdsByCodeSystemRefs;

    private void BuildUrlByCodeSystemRef()
    {
        //_library.codeSystems
        if (_libsCtx != null)
        {
            foreach (var libraryDependency in _libsCtx.LibrarySet.GetLibraryDependencies(Library.GetNameAndVersion()!))
            {
                AddCodeSystemRefs(libraryDependency);
            }
        }

        AddCodeSystemRefs(Library);

        void AddCodeSystemRefs(Library library)
        {
            bool isForOwnLibrary = library == Library;

            if (library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    if (isForOwnLibrary)
                    {
                        _codeSystemIdsByCodeSystemRefs.Add(new (null, codeSystemDef.name), codeSystemDef.id);
                    } 
                    else if (codeSystemDef.accessLevel == AccessModifier.Public)
                    {
                        _codeSystemIdsByCodeSystemRefs.Add(new(library.GetNameAndVersion()!, codeSystemDef.name), codeSystemDef.id);
                    }
                }
            }
        }
    }

    public bool TryGetCodeSystemName(CodeSystemRef codeSystemRef, [NotNullWhen(true)]out string? url)
    {
        var libraryName = codeSystemRef.libraryName is {} libraryAlias ? _localLibraryIdentifiers[libraryAlias] : null;
        return _codeSystemIdsByCodeSystemRefs.TryGetValue(new(libraryName, codeSystemRef.name), out url);
    }

    #endregion

    IBuilderContext? IBuilderContext.OuterContext => _libsCtx;

    BuilderContextInfo IBuilderContext.ContextInfo => BuilderContextInfo.FromElement(Library);


    private readonly record struct LibraryNameAndName(string? LibraryName, string Name);

    private class ByLibraryNameAndNameDictionary<TValue> : Dictionary<LibraryNameAndName, TValue>
    {
    }
}

