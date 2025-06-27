/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit;

[Experimental("FirelyCqlSdkPreview")]
internal record CqlToolkitCallbacks(
    CqlToolkitCallbacks.TranslateBeforeCallback? TranslateBefore = null,
    CqlToolkitCallbacks.TranslateSuccessCallback? TranslateSuccess = null,
    CqlToolkitCallbacks.TranslateErrorCallback? TranslateError = null)
{
    public delegate void TranslateBeforeCallback(CqlVersionedLibraryIdentifier libraryIdentifier, CqlLibraryString cqlLibraryString);
    public delegate void TranslateSuccessCallback(CqlVersionedLibraryIdentifier libraryIdentifier, CqlLibraryString cqlLibraryString, ElmLibrary elmLibrary);
    public delegate void TranslateErrorCallback(CqlVersionedLibraryIdentifier libraryIdentifier, CqlLibraryString cqlLibraryString, Exception exception);
}