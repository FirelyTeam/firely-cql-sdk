/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Fhir.ElementModel.Types;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Compiler.Preprocessing;

/// <summary>
/// Pre-processes the ELM library to correct some well-known bugs or omissions in the ELM produced by
/// the Java cql2elm tool.
/// </summary>
internal class LibraryPreprocessor(
    LibrarySet librarySet,
    ILoggerFactory loggerFactory)
{
    private readonly AmbiguousOverloadCorrector _ambiguousOverloadCorrector = new(loggerFactory.CreateLogger<AmbiguousOverloadCorrector>());
    private readonly ExpressionRefCorrector _expressionRefCorrector = new(loggerFactory.CreateLogger<ExpressionRefCorrector>(), librarySet);
    private readonly MissingResultTypeSpecifierCorrector _missingResultTypeSpecifierCorrector = new(loggerFactory.CreateLogger<MissingResultTypeSpecifierCorrector>());
    private readonly ProfiledValueSetPropertyCorrector _profiledValueSetPropertyCorrector = new(loggerFactory.CreateLogger<ProfiledValueSetPropertyCorrector>());

    public void PreprocessLibrary(Library library)
    {
        _ambiguousOverloadCorrector.Fix(library);
        _expressionRefCorrector.Fix(library);
        _missingResultTypeSpecifierCorrector.Fix(library);
        _profiledValueSetPropertyCorrector.Fix(library);
    }

    public void PreprocessLibraryDefinition(string expressionKey, Elm.Expression elmExpression)
    {
    }
}

internal class LibraryPreprocessorBuilder(ILoggerFactory loggerFactory)
{
    public LibraryPreprocessor Build(LibrarySet librarySet) => new(librarySet, loggerFactory);
}