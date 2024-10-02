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

internal partial class LibraryExpressionBuilderContext
{
    private readonly ILogger<LibraryExpressionBuilder> _logger;
    private readonly ExpressionBuilder _expressionBuilder;
    private readonly DefinitionDictionary<LambdaExpression> _libraryDefinitions;
    private readonly LibrarySetExpressionBuilderContext? _libsCtx;

    public LibraryExpressionBuilderContext(
        ILogger<LibraryExpressionBuilder> logger,
        ExpressionBuilder expressionBuilder,
        Library library,
        DefinitionDictionary<LambdaExpression> libraryDefinitions,
        LibrarySetExpressionBuilderContext? libsCtx = null)
    {
        _libraryDefinitions = libraryDefinitions;
        _libsCtx = libsCtx;
        _logger = logger;
        _expressionBuilder = expressionBuilder;
        Library = library;
        LibraryVersionedIdentifier = Library.GetVersionedIdentifier()!;
    }

    private static readonly AmbiguousOverloadCorrector AmbiguousOverloadCorrector = new AmbiguousOverloadCorrector();

    /// <summary>
    /// Gets the library associated with the expression builder context.
    /// </summary>
    public Library Library { get; }

    /// <summary>
    /// Gets the versioned identifier of the library, which is the name and version of the library.
    /// </summary>
    /// <seealso cref="IGetVersionedIdentifierExtensions.GetVersionedIdentifier"/>
    public string LibraryVersionedIdentifier { get; }

    public DefinitionDictionary<LambdaExpression> ProcessLibrary() =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            // Make sure all overloads in the library are unique.
            // This is a fix for QICore-based CQL, where the functions only differ by profiles on the same resource.
            // We should remove this when the compiler is fixed.
            // See https://github.com/FirelyTeam/firely-cql-sdk/issues/438.
            _logger.LogInformation("Preprocessing library '{library}' - AmbiguousOverloadCorrector", LibraryVersionedIdentifier);
            AmbiguousOverloadCorrector.Fix(Library);

            _logger.LogInformation("Preprocessing library '{library}' - ElmPreprocessor", LibraryVersionedIdentifier);
            var ls = LibrarySetContext?.LibrarySet ?? new LibrarySet(LibraryVersionedIdentifier, Library);
            var processor = new ElmPreprocessor(ls);
            processor.Preprocess(Library);

            _logger.LogInformation("Building expressions for '{library}'", LibraryVersionedIdentifier);

            if (Library.includes is { Length: > 0 } includeDefs)
            {
                foreach (var includeDef in includeDefs)
                {
                    _expressionBuilder.ProcessIncludes(this, includeDef);
                }

                AddLibraryDefinitionsFromIncludes();
                AddCodeSystemRefsFromIncludes();
            }

            if (Library.valueSets is { Length: > 0 } valueSetDefs)
            {
                foreach (var valueSetDef in valueSetDefs)
                {
                    _expressionBuilder.ProcessValueSetDef(this, valueSetDef);
                }
            }

            AddCodeSystemRefs(Library);

            if (Library.codes is { Length: > 0 } codeDefs)
            {
                HashSet<(string codeName, string codeSystemUrl)> foundCodeNameCodeSystemUrls = new();

                foreach (var codeDef in codeDefs)
                {
                    _expressionBuilder.ProcessCodeDef(this, codeDef, foundCodeNameCodeSystemUrls);
                }
            }

            if (Library.codeSystems is { Length: > 0 } codeSystemDefs)
            {
                foreach (var codeSystemDef in codeSystemDefs)
                {
                    _expressionBuilder.ProcessCodeSystemDef(this, codeSystemDef);
                }
            }

            if (Library.concepts is { Length: > 0 } conceptDefs)
            {
                foreach (var conceptDef in conceptDefs)
                {
                    _expressionBuilder.ProcessConceptDef(this, conceptDef);
                }
            }

            if (Library.parameters is { Length: > 0 } parameterDefs)
            {
                foreach (var parameterDef in parameterDefs)
                {
                    _expressionBuilder.ProcessParameterDef(this, parameterDef);
                }
            }

            if (Library.statements is { Length: > 0 } expressionDefs)
            {
                foreach (var expressionDef in expressionDefs)
                {
                    _expressionBuilder.ProcessExpressionDef(this, expressionDef);
                }
            }

            return LibraryDefinitions;
        });
}