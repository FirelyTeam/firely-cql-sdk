using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal partial record DefinitionsBuilder
{
    private void Visit(
        DefinitionDictionary<LambdaExpression> definitions,
        CodeSystemDef[] codeSystemDefs)
    {
        foreach (var codeSystemDef in codeSystemDefs)
        {
            Visit(definitions, codeSystemDef);
        }
    }

    private void Visit(
        DefinitionDictionary<LambdaExpression> definitions,
        CodeSystemDef codeSystem)
    {
        if (CodesByCodeSystemName.TryGetValue(codeSystem.name, out var codes))
        {
            var initMembers = codes
                .Select(coding =>
                    Expression.New(
                        ConstructorInfos.CqlCode,
                        Expression.Constant(coding.code),
                        Expression.Constant(coding.system),
                        Expression.Constant(null, typeof(string)),
                        Expression.Constant(null, typeof(string))
                    ))
                .ToArray();
            var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
            var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
            var lambda = Expression.Lambda(arrayOfCodesInitializer, contextParameter);
            definitions.Add(Library.NameAndVersion!, codeSystem.name, lambda);
        }
        else
        {
            var newArray =
                Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
            var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
            var lambda = Expression.Lambda(newArray, contextParameter);
            definitions.Add(Library.NameAndVersion!, codeSystem.name, lambda);
        }
    }
}