using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal partial record DefinitionsBuilder
{
    private void Visit(
        DefinitionDictionary<LambdaExpression> definitions,
        ValueSetDef[] valueSetDefs)
    {
        foreach (ValueSetDef libraryValueSet in valueSetDefs)
        {
            Visit(definitions, libraryValueSet);
        }
    }

    private void Visit(
        DefinitionDictionary<LambdaExpression> definitions,
        ValueSetDef valueSetDef)
    {
        var @new = Expression.New(ConstructorInfos.CqlValueSet, Expression.Constant(valueSetDef.id, typeof(string)),
            Expression.Constant(valueSetDef.version, typeof(string)));
        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
        var lambda = Expression.Lambda(@new, contextParameter);
        definitions.Add(Library.NameAndVersion!, valueSetDef.name!, lambda);
    }
}