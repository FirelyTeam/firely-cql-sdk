using System;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Exceptions;
using Expression = System.Linq.Expressions.Expression;


namespace Hl7.Cql.Compiler;

internal sealed class OperatorBindingRethrowDecorator : OperatorBinding
{
    private readonly IContextualExpressionBuilder _owningContextualExpressionBuilder;

    public static OperatorBinding Decorate(IContextualExpressionBuilder owningContextualExpressionBuilder, OperatorBinding operatorBinding) =>
        operatorBinding switch
        {
            OperatorBindingRethrowDecorator fromSameContext when fromSameContext._owningContextualExpressionBuilder == owningContextualExpressionBuilder => fromSameContext,
            OperatorBindingRethrowDecorator fromAnotherContext => new OperatorBindingRethrowDecorator(owningContextualExpressionBuilder, fromAnotherContext.Inner),
            _ => new OperatorBindingRethrowDecorator(owningContextualExpressionBuilder, operatorBinding)
        };

    private OperatorBindingRethrowDecorator(
        IContextualExpressionBuilder owningContextualExpressionBuilder,
        OperatorBinding inner)
    {
        _owningContextualExpressionBuilder = owningContextualExpressionBuilder;
        Inner = inner;
    }

    private OperatorBinding Inner { get; }

    public override Expression Bind(CqlOperator @operator, Expression runtimeContext, params Expression[] parameters)
    {
        try
        {
            return Inner.Bind(@operator, runtimeContext, parameters);
        }
        catch (CqlException<ExpressionBuildingError>)
        {
            throw;
        }
        catch (Exception e)
        {
            throw _owningContextualExpressionBuilder.NewExpressionBuildingException(e.Message, e);
        }
    }
}