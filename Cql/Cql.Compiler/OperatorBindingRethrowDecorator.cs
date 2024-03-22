using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Compiler;

internal sealed class OperatorBindingRethrowDecorator : OperatorBinding
{
    private readonly IBuilderContext _owningBuilderContext;

    public static OperatorBinding Decorate(IBuilderContext owningBuilderContext, OperatorBinding operatorBinding) =>
        operatorBinding switch
        {
            OperatorBindingRethrowDecorator fromSameContext when fromSameContext._owningBuilderContext == owningBuilderContext => fromSameContext,
            OperatorBindingRethrowDecorator fromAnotherContext => new OperatorBindingRethrowDecorator(owningBuilderContext, fromAnotherContext.Inner),
            _ => new OperatorBindingRethrowDecorator(owningBuilderContext, operatorBinding)
        };

    private OperatorBindingRethrowDecorator(
        IBuilderContext owningBuilderContext,
        OperatorBinding inner)
    {
        _owningBuilderContext = owningBuilderContext;
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
            throw _owningBuilderContext.NewExpressionBuildingException(e.Message, e);
        }
    }
}