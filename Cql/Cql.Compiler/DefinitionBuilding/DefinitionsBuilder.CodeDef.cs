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
    private void VisitCodeDef(
        LibraryContext libraryContext,
        CodeDef codeDef, 
        HashSet<(string codeName, string codeSystemUrl)> codeNameCodeSystemUrlsSet)
    {
        if (codeDef.codeSystem == null)
            throw new InvalidOperationException("Code definition has a null codeSystem node.");

        if (!libraryContext.CodeSystemUrls.TryGetValue(codeDef.codeSystem.name, out var csUrl))
            throw new InvalidOperationException($"Undefined code system {codeDef.codeSystem.name!}");

        if (!codeNameCodeSystemUrlsSet.Add((codeDef.name, csUrl)))
            throw new InvalidOperationException(
                $"Duplicate code name detected: {codeDef.name} from {codeDef.codeSystem.name} ({csUrl})");

        var systemCode = new CqlCode(codeDef.id, csUrl);
        libraryContext.CodesByName.Add(codeDef.name, systemCode);
        if (!libraryContext.CodesByCodeSystemName.TryGetValue(codeDef.codeSystem!.name!, out var codings))
        {
            codings = new List<CqlCode>();
            libraryContext.CodesByCodeSystemName.Add(codeDef.codeSystem!.name!, codings);
        }

        codings.Add(systemCode);

        var newCodingExpression = Expression.New(
            ConstructorInfos.CqlCode,
            Expression.Constant(codeDef.id),
            Expression.Constant(csUrl),
            Expression.Constant(null, typeof(string)),
            Expression.Constant(null, typeof(string))!
        );
        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
        var lambda = Expression.Lambda(newCodingExpression, contextParameter);
        libraryContext.AddDefinition(codeDef.name!, lambda);
    }
}