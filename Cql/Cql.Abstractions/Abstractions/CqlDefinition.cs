namespace Hl7.Cql.Abstractions;

internal abstract class CqlDefinition(
    LambdaExpression lambda,
    string definitionName) : Expression
{
    public new LambdaExpression Lambda { get; } = lambda;
    public string DefinitionName { get; } = definitionName;
    public override Expression Reduce() => Lambda;

    public override bool CanReduce => true;
    public override ExpressionType NodeType => (ExpressionType)(-1);
    public override Type Type => Lambda.Type;
    public Type ReturnType => Lambda.ReturnType;
}