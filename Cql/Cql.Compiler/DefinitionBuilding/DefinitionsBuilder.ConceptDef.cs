using System;
using System.Collections.Generic;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.DefinitionBuilding;

#pragma warning disable CS1591
internal partial class DefinitionsBuilder
{
    private void VisitConceptDef(
        LibraryContext libraryContext,
        ConceptDef conceptDef)
    {
        if (conceptDef.code.Length <= 0)
        {
            var newArray =
                Expression.NewArrayBounds(typeof(CqlCode), Expression.Constant(0, typeof(int)));
            var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
            var lambda = Expression.Lambda(newArray, contextParameter);
            libraryContext.AddDefinition(conceptDef.name, lambda);
        }
        else
        {
            var initMembers = new Expression[conceptDef.code.Length];
            for (int i = 0; i < conceptDef.code.Length; i++)
            {
                var codeRef = conceptDef.code[i];
                if (!libraryContext.TryGetCodeByCodeName(codeRef.name, out var systemCode))
                    throw new InvalidOperationException(
                        $"Code {codeRef.name} in concept {conceptDef.name} is not defined.");

                initMembers[i] = Expression.New(
                    ConstructorInfos.CqlCode,
                    Expression.Constant(systemCode.code),
                    Expression.Constant(systemCode.system),
                    Expression.Constant(null, typeof(string)),
                    Expression.Constant(null, typeof(string))
                );
            }

            var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
            var asEnumerable = Expression.TypeAs(arrayOfCodesInitializer, typeof(IEnumerable<CqlCode>));
            var display = Expression.Constant(conceptDef.display, typeof(string));
            var newConcept = Expression.New(ConstructorInfos.CqlConcept!, asEnumerable, display);
            var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
            var lambda = Expression.Lambda(newConcept, contextParameter);
            libraryContext.AddDefinition(conceptDef.name, lambda);
        }
    }
}