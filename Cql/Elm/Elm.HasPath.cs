#pragma warning disable IDE1006 // Naming Style Suppressed: So it matches the generated Elm.cs file.

namespace Hl7.Cql.Elm;

internal interface IHasPath
{
    string? path { get; }
}

partial class IncludeDef : IHasPath { }
partial class ByColumn : IHasPath { }
partial class AggregateExpression : IHasPath { }
partial class Property : IHasPath { }


internal interface IHasExpressionSource
{
    Expression? source { get; } // Type is either Expression / AliasedQuerySource[]
}

partial class Property : IHasExpressionSource { }