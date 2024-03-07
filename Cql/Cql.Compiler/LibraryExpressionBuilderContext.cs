using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Encapsulates the ExpressionBuilder and state dictionaries for building definitions.
/// </summary>
internal class LibraryExpressionBuilderContext
{
    private readonly ExpressionBuilder _expressionBuilder;
    private readonly OperatorBinding _operatorBinding;
    private readonly Dictionary<string, string> _localLibraryIdentifiers;
    private readonly DefinitionDictionary<LambdaExpression> _definitions;
    private readonly Library _library;
    private readonly Dictionary<string, CqlCode> _codesByName;
    private readonly Dictionary<string, List<CqlCode>> _codesByCodeSystemName;

    public LibraryExpressionBuilderContext(
        ExpressionBuilder expressionBuilder,
        OperatorBinding operatorBinding,
        DefinitionDictionary<LambdaExpression> definitions,
        Library library)
    {
        if (string.IsNullOrWhiteSpace(library.NameAndVersion))
            throw new ArgumentException("Library must have a name and version.");

        if (library.identifier is null) 
            throw new ArgumentException("Library must have an identifier.");

        _expressionBuilder = expressionBuilder;
        _operatorBinding = operatorBinding;
        _definitions = definitions;
        _library = library;
        _localLibraryIdentifiers = new();
        _codesByName = new();
        _codesByCodeSystemName = new();
    }

    public Elm.Library Library => _library;

    public string LibraryKey => _library.NameAndVersion!;

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

    public void AddIncludeAlias(string includeAlias, string includeNameAndVersion) =>
        _localLibraryIdentifiers.Add(includeAlias, includeNameAndVersion);

    public bool TryGetCodesByCodeSystemName(string codeSystemName, [NotNullWhen(true)] out List<CqlCode>? codes) =>
        _codesByCodeSystemName.TryGetValue(codeSystemName, out codes);

    public void AddCode(CodeDef codeDef, CqlCode cqlCode)
    {
        _codesByName.Add(codeDef.name, cqlCode);

        var codeSystemName = codeDef.codeSystem!.name;
        var codings = GetOrCreateCodesByCodeSystemName(codeSystemName);
        codings.Add(cqlCode);
    }

    private List<CqlCode> GetOrCreateCodesByCodeSystemName(string codeSystemName)
    {
        if (_codesByCodeSystemName.TryGetValue(codeSystemName!, out var codings))
            return codings;

        codings = new List<CqlCode>();
        _codesByCodeSystemName.Add(codeSystemName!, codings);
        return codings;
    }

    public bool TryGetCode(CodeRef codeRef, [NotNullWhen(true)] out CqlCode? systemCode) =>
        _codesByName.TryGetValue(codeRef.name, out systemCode);
}