using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.DefinitionBuilding;

#pragma warning disable CS1591
internal partial class DefinitionsBuilder
{

    private void VisitValueSetDef(
        LibraryContext libraryContext,
        ValueSetDef valueSetDef)
    {
        var @new = Expression.New(ConstructorInfos.CqlValueSet, Expression.Constant(valueSetDef.id, typeof(string)),
            Expression.Constant(valueSetDef.version, typeof(string)));
        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
        var lambda = Expression.Lambda(@new, contextParameter);
        libraryContext.AddDefinition(valueSetDef.name!, lambda);
    }
}