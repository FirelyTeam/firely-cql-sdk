#pragma warning disable IDE1006 // Naming Style Suppressed: So it matches the generated Elm.cs file.

namespace Hl7.Cql.Elm;

internal interface IHasName
{
    string? name { get; }
}

partial class AliasRef : IHasName { }
partial class CodeDef : IHasName { }
partial class CodeRef : IHasName { }
partial class CodeSystemDef : IHasName { }
partial class CodeSystemRef : IHasName { }
partial class ConceptDef : IHasName { }
partial class ContextDef : IHasName { }
partial class ExpressionDef: IHasName { }
partial class ExpressionRef: IHasName { }
partial class IdentifierRef : IHasName { }
partial class InstanceElement : IHasName { }
partial class OperandDef: IHasName { }
partial class OperandRef : IHasName { }
partial class ParameterDef : IHasName { }
partial class ParameterRef : IHasName { }
partial class QueryLetRef : IHasName { }
partial class Tag : IHasName { }
partial class TupleElement : IHasName { }
partial class TupleElementDefinition : IHasName { }
partial class ValueSetDef : IHasName { }
partial class ValueSetRef : IHasName { }