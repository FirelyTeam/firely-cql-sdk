using System;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler.Expressions;

internal class ElmChoiceAsExpression(
    Expression expression,
    Expression[] switchCaseExpressions,
    Type asType,
    bool strict) : Expression {

    public Expression Expression { get; } = expression;
    public Expression[] SwitchCaseExpressions { get; } = switchCaseExpressions;
    public Type AsType { get; } = asType;
    public bool Strict { get; } = strict;
    public Type[] MissingConversionTypes { get; init; } = [];

    public override bool CanReduce => false;
    public static string SwitchCaseExpressionParamPlaceholderName => "__expr_param_placeholder__";

    public override ExpressionType NodeType => ExpressionType.Extension;
    public override Type Type => AsType;

    protected override Expression VisitChildren(ExpressionVisitor visitor) =>
        Update(visitor.Visit(Expression));

    public Expression Update(Expression expression) =>
        expression != Expression
            ? new ElmChoiceAsExpression(expression, SwitchCaseExpressions, AsType, Strict)
            {
                MissingConversionTypes = MissingConversionTypes,
            }
            : this;
}