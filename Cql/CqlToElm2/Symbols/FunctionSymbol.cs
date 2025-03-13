using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;

internal class FunctionSymbol : Symbol
{
    public FunctionSymbol(string name, AccessModifier accessModifier, TypeSymbol returnType,
        OperandSymbol[] operands, Expression? body) : base(name)
    {
        AccessModifier = accessModifier;
        Operands = operands.AsReadOnly();
        Type = returnType;
        Body = body;
        Signature = new FunctionSignature(this);
    }

    public override TypeSymbol Type { get; }

    public override AccessModifier AccessModifier { get; }

    public override SymbolType SymbolType => SymbolType.Function;

    public IReadOnlyList<OperandSymbol> Operands { get; private set; }

    public FunctionSignature Signature { get; }

    public Expression? Body { get; private set; }

    public bool IsExternal => Body is null;

}

internal class FunctionSignature : Signature
{
    public FunctionSignature(FunctionSymbol function): base(function.Operands.Select(o => o.Type).ToArray())
    {
        Function = function;
    }
    public FunctionSymbol Function { get; }
}
