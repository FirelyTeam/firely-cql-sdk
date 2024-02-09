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
    private void VisitCodeDefs(
        LibraryContext libraryContext,
        CodeDef[] codeDefs)
    {
        HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();
        foreach (var codeDef in codeDefs)
        {
            VisitCodeDef(libraryContext, new CodeDefContext(codeDef, foundCodeNameCodeSystemUrls));
        }
    }

    private record struct CodeDefContext(
        CodeDef CodeDef,
        HashSet<(string codeName, string codeSystemUrl)> CodeNameCodeSystemUrlsSet);

    private void VisitCodeDef(
        LibraryContext libraryContext,
        CodeDefContext codeDefContext)
    {
        if (codeDefContext.CodeDef.codeSystem == null)
            throw new InvalidOperationException("Code definition has a null codeSystem node.");

        if (!libraryContext.CodeSystemUrls.TryGetValue(codeDefContext.CodeDef.codeSystem.name, out var csUrl))
            throw new InvalidOperationException($"Undefined code system {codeDefContext.CodeDef.codeSystem.name!}");

        if (!codeDefContext.CodeNameCodeSystemUrlsSet.Add((codeDefContext.CodeDef.name, csUrl)))
            throw new InvalidOperationException(
                $"Duplicate code name detected: {codeDefContext.CodeDef.name} from {codeDefContext.CodeDef.codeSystem.name} ({csUrl})");

        var systemCode = new CqlCode(codeDefContext.CodeDef.id, csUrl);
        libraryContext.CodesByName.Add(codeDefContext.CodeDef.name, systemCode);
        if (!libraryContext.CodesByCodeSystemName.TryGetValue(codeDefContext.CodeDef.codeSystem!.name!, out var codings))
        {
            codings = new List<CqlCode>();
            libraryContext.CodesByCodeSystemName.Add(codeDefContext.CodeDef.codeSystem!.name!, codings);
        }

        codings.Add(systemCode);

        var newCodingExpression = Expression.New(
            ConstructorInfos.CqlCode,
            Expression.Constant(codeDefContext.CodeDef.id),
            Expression.Constant(csUrl),
            Expression.Constant(null, typeof(string)),
            Expression.Constant(null, typeof(string))!
        );
        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
        var lambda = Expression.Lambda(newCodingExpression, contextParameter);
        libraryContext.Definitions.Add(libraryContext.Library.NameAndVersion!, codeDefContext.CodeDef.name!, lambda);
    }

}