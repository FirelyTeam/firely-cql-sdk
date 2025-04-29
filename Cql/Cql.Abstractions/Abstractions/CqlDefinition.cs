namespace Hl7.Cql.Abstractions;

/// <seealso cref="CqlDefinitionAttribute"/>
internal abstract class CqlDefinition(
    LambdaExpression lambda,
    string name) : Expression
{
    public new LambdaExpression Lambda { get; } = lambda;
    public string Name { get; } = name;
    public override Expression Reduce() => Lambda;

    public override bool CanReduce => true;
    public override ExpressionType NodeType => (ExpressionType)(-1);
    public override Type Type => Lambda.Type;
    public Type ReturnType => Lambda.ReturnType;
}