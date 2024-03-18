using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Elm;

internal class Interfaces
{
}

internal interface IGetLibraryName
{
    string libraryName { get; }
}

partial class CodeRef : IGetLibraryName {}
partial class CodeSystemRef : IGetLibraryName {}
partial class ConceptRef : IGetLibraryName {}
partial class ExpressionRef : IGetLibraryName {}
partial class IdentifierRef : IGetLibraryName {}
partial class ParameterRef : IGetLibraryName {}
partial class ValueSetRef : IGetLibraryName {}


internal interface IGetName 
{
    string name { get; }
}
partial class AliasRef : IGetName { }
partial class CodeRef : IGetName { }
partial class CodeSystemDef : IGetName { }
partial class CodeSystemRef : IGetName { }
partial class ConceptDef : IGetName { }
partial class ConceptRef : IGetName { }
partial class ExpressionRef : IGetName { }
partial class IdentifierRef : IGetName { }
partial class InstanceElement : IGetName { }
partial class OperandDef : IGetName { }
partial class OperandRef : IGetName { }
partial class ParameterDef: IGetName { }
partial class ParameterRef: IGetName { }
partial class QueryLetRef: IGetName { }
partial class Tag: IGetName { }
partial class TupleElement: IGetName { }
partial class TupleElementDefinition: IGetName { }
partial class ValueSetDef: IGetName { }
partial class ValueSetRef: IGetName { }
