/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

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
    private readonly ProfiledValueSetPropertyCorrector _profiledValueSetPropertyCorrector = new(loggerFactory.CreateLogger<ProfiledValueSetPropertyCorrector>());


    public void Preprocess(Library library)
    {
        _ambiguousOverloadCorrector.Fix(library);
        _expressionRefCorrector.Fix(library);
        _profiledValueSetPropertyCorrector.Fix(library);
    }
}

internal class LibraryPreprocessorBuilder(ILoggerFactory loggerFactory)
{
    public LibraryPreprocessor Build(LibrarySet librarySet) => new(librarySet, loggerFactory);
}