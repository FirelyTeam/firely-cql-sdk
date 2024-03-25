using System;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Exceptions;
using Expression = System.Linq.Expressions.Expression;


namespace Hl7.Cql.Compiler;

internal sealed class OperatorBindingRethrowDecorator : OperatorBinding
{
    private readonly IBuilderNode _owningBuilder;

    public static OperatorBinding Decorate(IBuilderNode owningBuilder, OperatorBinding operatorBinding) =>
        operatorBinding switch
        {
            OperatorBindingRethrowDecorator fromSameContext when fromSameContext._owningBuilder == owningBuilder => fromSameContext,
            OperatorBindingRethrowDecorator fromAnotherContext => new OperatorBindingRethrowDecorator(owningBuilder, fromAnotherContext.Inner),
            _ => new OperatorBindingRethrowDecorator(owningBuilder, operatorBinding)
        };

    private OperatorBindingRethrowDecorator(
        IBuilderNode owningBuilder,
        OperatorBinding inner)
    {
        _owningBuilder = owningBuilder;
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
            throw _owningBuilder.NewExpressionBuildingException(e.Message, e);
        }
    }
}