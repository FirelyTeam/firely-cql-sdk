/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

internal partial class LibrarySetCSharpCodeGenerator
{
    /// <summary>
    /// Gets the version of this <see cref="LibrarySetCSharpCodeGenerator"/> as will appear
    /// in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Version"/>.
    /// </summary>
    /// <remarks>
    /// This version must be MANUALLY updated whenever the code generation logic changes.
    /// The version should be updated according to the Semantic Versioning specification (although text is not allowed, e.g. alpha).
    /// This version does not correlate to the version of the CQL SDK.
    /// When the version is updated, the libraries must be regenerated as well as part of the pull request.
    /// Also, it is important to ensure the library invoker toolkit is updated to support the new version,
    /// for this you need to update the LibraryInvoker.SupportsVersion method, or create a new version of the LibraryInvoker.
    /// </remarks>
    internal const string GeneratorToolVersion = "4.1.0.0";
}
