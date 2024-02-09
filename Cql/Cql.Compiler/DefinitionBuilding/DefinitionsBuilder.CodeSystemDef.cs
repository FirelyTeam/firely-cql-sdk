using System.Linq;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.DefinitionBuilding;

#pragma warning disable CS1591
internal partial class DefinitionsBuilder
{
    private void VisitCodeSystemDef(
        LibraryContext libraryContext,
        CodeSystemDef codeSystem)
    {
        if (libraryContext.CodesByCodeSystemName.TryGetValue(codeSystem.name, out var codes))
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
            libraryContext.AddDefinition(codeSystem.name, lambda);
        }
        else
        {
            var newArray =
                Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
            var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
            var lambda = Expression.Lambda(newArray, contextParameter);
            libraryContext.AddDefinition(codeSystem.name, lambda);
        }
    }
}