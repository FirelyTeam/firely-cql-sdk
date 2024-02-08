using System;
using System.Collections.Generic;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Definitions;

#pragma warning disable CS1591
internal record DefinitionsBuilderForCodeDef(
    DefinitionsBuilderForCodeDefs OuterCodes,
    CodeDef CodeDef,
    HashSet<(string codeName, string codeSystemUrl)> CodeNameCodeSystemUrlsSet)
{
    public void Build()
    {
        var codeDef = CodeDef;
        var lib = OuterCodes.OuterLib;
        var outerLibCodeSystemUrls = lib.CodeSystemUrls;
        var outerLibCodesByName = lib.CodesByName;
        var outerLibCodesByCodeSystemName = lib.CodesByCodeSystemName;

        if (codeDef.codeSystem == null)
            throw new InvalidOperationException("Code definition has a null codeSystem node.");

        if (!outerLibCodeSystemUrls.TryGetValue(codeDef.codeSystem.name, out var csUrl))
            throw new InvalidOperationException($"Undefined code system {codeDef.codeSystem.name!}");

        if (!CodeNameCodeSystemUrlsSet.Add((codeDef.name, csUrl)))
            throw new InvalidOperationException(
                $"Duplicate code name detected: {codeDef.name} from {codeDef.codeSystem.name} ({csUrl})");

        var systemCode = new CqlCode(codeDef.id, csUrl, null, null);
        outerLibCodesByName.Add(codeDef.name, systemCode);
        if (!outerLibCodesByCodeSystemName.TryGetValue(codeDef.codeSystem!.name!, out var codings))
        {
            codings = new List<CqlCode>();
            outerLibCodesByCodeSystemName.Add(codeDef.codeSystem!.name!, codings);
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
        OuterCodes.Definitions.Add(lib.Library.NameAndVersion!, codeDef.name!, lambda);
    }
}