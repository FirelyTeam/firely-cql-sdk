namespace Hl7.Cql.Compiler.Expressions;

internal abstract class CqlDefinition(
    LambdaExpression lambda,
    string declarationName,
    params (string tagName, string[] tagValues)[] tags) : Expression
{
    public new LambdaExpression Lambda { get; } = lambda;
    public string DeclarationName { get; } = declarationName;
    public (string Name, string[] Values)[] Tags { get; } = tags;
    public override Expression Reduce() => Lambda;

    public override bool CanReduce => true;
    public override ExpressionType NodeType => (ExpressionType)(-1);
    public override Type Type => Lambda.Type;
    public Type ReturnType => Lambda.ReturnType;
}