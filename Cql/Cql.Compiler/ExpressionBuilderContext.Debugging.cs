using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Exceptions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

partial class ExpressionBuilderContext : IBuilderContext
{
    private readonly Elm.Element _element;

    private readonly ExpressionBuilderContext? _outerContext;

    IBuilderContext? IBuilderContext.OuterContext => (IBuilderContext?)_outerContext ?? LibraryContext;

    BuilderContextInfo IBuilderContext.ContextInfo => BuilderContextInfo.FromElement(_element);

    private sealed class OperatorBindingRethrowDecorator : OperatorBinding
    {
        private readonly ExpressionBuilderContext _owningExpressionBuilderContext;

        public OperatorBindingRethrowDecorator(
            ExpressionBuilderContext owningExpressionBuilderContext,
            OperatorBinding inner)
        {
            _owningExpressionBuilderContext = owningExpressionBuilderContext;
            Inner = inner;
        }

        public OperatorBinding Inner { get; }

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
                throw _owningExpressionBuilderContext.NewExpressionBuildingException(e.Message, e);
            }
        }
    }

    public string FormatMessage(string message, elm.Element? element = null)
    {
        var locator = element?.locator;

        return string.IsNullOrWhiteSpace(locator)
            ? $"{LibraryContext.LibraryKey}: {message}"
            : $"{LibraryContext.LibraryKey} line {locator}: {message}";
    }
}