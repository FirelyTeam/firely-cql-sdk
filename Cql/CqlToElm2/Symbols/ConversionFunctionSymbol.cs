using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class ConversionFunctionSymbol : FunctionSymbol
{
    internal static string FormatName(TypeSymbol from, TypeSymbol to) => $"convert({from},{to})";

    public static ConversionFunctionSymbol Implicit(OperandSymbol from, TypeSymbol to, AccessModifier access, Expression? body) =>
        new ConversionFunctionSymbol(from, to, access, body) { IsImplicit = true };
    public static ConversionFunctionSymbol Explicit(OperandSymbol from, TypeSymbol to, AccessModifier access, Expression? body) =>
        new ConversionFunctionSymbol(from, to, access, body) { IsImplicit = false };


    private ConversionFunctionSymbol(OperandSymbol from, TypeSymbol to, AccessModifier accessModifier, Expression? body)
    : base(FormatName(from.Type, to), accessModifier, to, [from], body)
    {
    }

    public bool IsImplicit { get; private set; }

    public OperandSymbol Operand => Operands[0];

    public TypeSymbol From => Operand.Type;


}
