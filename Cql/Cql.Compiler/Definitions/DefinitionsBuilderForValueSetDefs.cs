using System;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal record DefinitionsBuilderForValueSetDefs(
    DefinitionsBuilderForLibrary OuterLib,
    DefinitionDictionary<LambdaExpression> Definitions, 
    ValueSetDef[] LibraryValueSets)
{
    public void AddToDefinitions(DefinitionDictionary<LambdaExpression> definitions)
    {
        foreach (ValueSetDef libraryValueSet in LibraryValueSets)
        {
            var @new = Expression.New(ConstructorInfos.CqlValueSet, Expression.Constant(libraryValueSet.id, typeof(string)),
                Expression.Constant(libraryValueSet.version, typeof(string)));
            var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
            var lambda = Expression.Lambda(@new, contextParameter);
            Definitions.Add(OuterLib.Library.NameAndVersion!, libraryValueSet.name!, lambda);
        }
    }
}