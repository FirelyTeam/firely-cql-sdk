using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Coercion;
internal class ImplicitConversionEdge: CoercionEdge
{
    public ImplicitConversionEdge(CoercionNode from, CoercionNode to, ConversionFunctionSymbol function) : base(from, to)
    {
        if(from.Type != function.From)
            throw new ArgumentException($"Type specified in {nameof(from)} must match the function's from operand ({function.From})", nameof(function));
        if (to.Type != function.Type)
            throw new ArgumentException($"Type specified in {nameof(to)} must match the function's result ({function.Type})", nameof(function));
        Function = function;
    }
    public override CoercionCost Cost => To.Type.TypeDefinition switch
    {
        SimpleTypeDefinition => CoercionCost.ImplicitToLiteralType,
        _ => CoercionCost.ImplicitToClassType,
    };

    public ConversionFunctionSymbol Function { get; }

    public override Expression Convert(Expression expression) =>
        new FunctionInvocationExpression(Function, [new ArgumentSymbol(Function.Operand, expression)], Function.Type);
}
