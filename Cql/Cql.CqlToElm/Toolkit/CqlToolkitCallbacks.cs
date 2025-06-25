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
    CqlToolkitCallbacks.BeforeTranslateCallback? BeforeTranslate = null,
    CqlToolkitCallbacks.AfterTranslateCallback? AfterTranslate = null,
    CqlToolkitCallbacks.TranslateErrorCallback? TranslateError = null)
{
    public delegate void BeforeTranslateCallback(CqlVersionedLibraryIdentifier libraryIdentifier, CqlLibraryString cqlLibraryString);
    public delegate void AfterTranslateCallback(CqlVersionedLibraryIdentifier libraryIdentifier, CqlLibraryString cqlLibraryString, ElmLibrary elmLibrary);
    public delegate void TranslateErrorCallback(CqlVersionedLibraryIdentifier libraryIdentifier, CqlLibraryString cqlLibraryString, Exception exception);
}