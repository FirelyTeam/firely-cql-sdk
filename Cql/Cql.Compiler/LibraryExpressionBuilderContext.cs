/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal partial class LibraryExpressionBuilderContext(
    ILogger<LibraryExpressionBuilder> logger,
    ExpressionBuilder expressionBuilder,
    Library library,
    DefinitionDictionary<LambdaExpression> libraryDefinitions,
    LibrarySetExpressionBuilderContext? libsCtx = null)
{
    private static readonly AmbiguousOverloadCorrector AmbiguousOverloadCorrector = new AmbiguousOverloadCorrector();

    /// <summary>
    /// Gets the library associated with the expression builder context.
    /// </summary>
    public Library Library { get; } = library;

    /// <summary>
    /// Gets the key of the library, which is the name and version of the library.
    /// </summary>
    /// <seealso cref="Library.NameAndVersion"/>
    public string LibraryKey => Library.NameAndVersion()!;

    public DefinitionDictionary<LambdaExpression> ProcessLibrary() =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            // Make sure all overloads in the library are unique.
            // This is a fix for QICore-based CQL, where the functions only differ by profiles on the same resource.
            // We should remove this when the compiler is fixed.
            // See https://github.com/FirelyTeam/firely-cql-sdk/issues/438.
            logger.LogInformation("Preprocessing library '{library}' - AmbiguousOverloadCorrector", LibraryKey);
            AmbiguousOverloadCorrector.Fix(Library);

            logger.LogInformation("Preprocessing library '{library}' - ElmPreprocessor", LibraryKey);
            var ls = LibrarySetContext?.LibrarySet ?? new LibrarySet(LibraryKey, Library);
            var processor = new ElmPreprocessor(ls);
            processor.Preprocess(Library);

            logger.LogInformation("Building expressions for '{library}'", LibraryKey);

            if (Library.includes is { Length: > 0 } includeDefs)
            {
                foreach (var includeDef in includeDefs)
                {
                    expressionBuilder.ProcessIncludes(this, includeDef);
                }

                AddLibraryDefinitionsFromIncludes();
                AddCodeSystemRefsFromIncludes();
            }

            if (Library.valueSets is { Length: > 0 } valueSetDefs)
            {
                foreach (var valueSetDef in valueSetDefs)
                {
                    expressionBuilder.ProcessValueSetDef(this, valueSetDef);
                }
            }

            AddCodeSystemRefs(Library);

            if (Library.codes is { Length: > 0 } codeDefs)
            {
                HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

                foreach (var codeDef in codeDefs)
                {
                    expressionBuilder.ProcessCodeDef(this, codeDef, foundCodeNameCodeSystemUrls);
                }
            }

            if (Library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    expressionBuilder.ProcessCodeSystemDef(this, codeSystemDef);
                }
            }

            if (Library.concepts is { Length: > 0 } conceptDefs)
            {
                foreach (var conceptDef in conceptDefs)
                {
                    expressionBuilder.ProcessConceptDef(this, conceptDef);
                }
            }

            if (Library.parameters is { Length: > 0 } parameterDefs)
            {
                foreach (var parameterDef in parameterDefs)
                {
                    expressionBuilder.ProcessParameterDef(this, parameterDef);
                }
            }

            if (Library.statements is { Length: > 0 } expressionDefs)
            {
                foreach (var expressionDef in expressionDefs)
                {
                    expressionBuilder.ProcessExpressionDef(this, expressionDef);
                }
            }

            return LibraryDefinitions;
        });
}