using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// The builder for processing the library into definitions.
/// </summary>
partial class LibraryExpressionBuilder
{
    public DefinitionDictionary<LambdaExpression> ProcessLibrary()
    {
        _logger.LogInformation("Building expressions for '{library}'", LibraryKey);

        if (Library.includes is { Length: > 0 } includeDefs)
        {
            foreach (var includeDef in includeDefs)
            {
                CreateExpressionBuilder().ProcessIncludes(includeDef);
            }
            AddLibraryDefinitionsFromIncludes();
            AddCodeSystemRefsFromIncludes();
        }

        if (Library.valueSets is { Length: > 0 } valueSetDefs)
        {
            foreach (var valueSetDef in valueSetDefs)
            {
                CreateExpressionBuilder().ProcessValueSetDef(valueSetDef);
            }
        }

        if (Library.codes is { Length: > 0 } codeDefs)
        {
            HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

            foreach (var codeDef in codeDefs)
            {
                CreateExpressionBuilder().ProcessCodeDef(codeDef, foundCodeNameCodeSystemUrls);
            }
        }

        if (Library.codeSystems is { Length: > 0 } codeSystemDefs)
        {
            foreach (var codeSystemDef in codeSystemDefs)
            {
                CreateExpressionBuilder().ProcessCodeSystemDef(codeSystemDef);
            }
        }

        if (Library.concepts is { Length: > 0 } conceptDefs)
        {
            foreach (var conceptDef in conceptDefs)
            {
                CreateExpressionBuilder().ProcessConceptDef(conceptDef);
            }
        }

        if (Library.parameters is { Length: > 0 } parameterDefs)
        {
            foreach (var parameterDef in parameterDefs)
            {
                CreateExpressionBuilder().ProcessParameterDef(parameterDef);
            }
        }

        if (Library.statements is { Length: > 0 } expressionDefs)
        {
            foreach (var expressionDef in expressionDefs)
            {
                CreateExpressionBuilder().ProcessExpressionDef(expressionDef);
            }
        }

        return LibraryDefinitions;
    }

}