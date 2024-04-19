using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

internal interface ILibraryExpressionBuilderContext : IBuilderNode
{
    Library Library { get; }
    DefinitionDictionary<LambdaExpression> LibraryDefinitions { get; }
    ILibrarySetExpressionBuilderContext? LibrarySetContext { get; }
    string LibraryKey { get; }
    bool TryGetCodesByCodeSystemName(string codeSystemName, [NotNullWhen(true)] out List<CqlCode>? codes);
    bool TryGetCodeSystemName(CodeSystemRef codeSystemRef, [NotNullWhen(true)]out string? url);
    bool TryGetCode(CodeRef codeRef, [NotNullWhen(true)] out CqlCode? systemCode);
    void AddCode(CodeDef codeDef, CqlCode cqlCode);
    void AddAliasForNameAndVersion(string alias, string libraryKey);
    string? GetNameAndVersionFromAlias(string? alias, bool throwError = true);
}