/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

// Relocated (phase 6 of the Linq.Expressions removal, docs/linq-expression-removal-plan.md) from
// the old (deleted) LibrarySetCSharpCodeGenerator onto its IR successor, the sole surviving
// C# generator, so ElmToolkit.GeneratorToolVersion and Cql.Packaging's
// AddGeneratorToolVersionToParameters keep a value to read.
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
    /// Whoever raises the invocation toolkit's minimum supported version above 6.0.3.0 also removes
    /// <see cref="LegacyGeneratorToolName"/>.
    /// </remarks>
    internal const string GeneratorToolVersion = "6.2.2.0";

    /// <summary>
    /// Gets the name of this <see cref="LibrarySetCSharpCodeGenerator"/> as will appear
    /// in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
    /// </summary>
    /// <remarks>
    /// The invocation toolkit recognizes the library types this generator wrote by this name,
    /// so it must not change without also changing what the toolkit accepts.
    /// </remarks>
    internal const string GeneratorToolName = "Hl7.Cql.CodeGeneration.NET";

    /// <summary>
    /// Gets the name this <see cref="LibrarySetCSharpCodeGenerator"/> wrote in the
    /// <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/> up to and including version 6.0.3.0.
    /// </summary>
    /// <remarks>
    /// The invocation toolkit still recognizes this name, so that libraries generated before the name changed keep
    /// loading. Remove it, and its acceptance by the invocation toolkit, once the toolkit no longer supports any
    /// generator version that wrote it: when its minimum supported generator version rises above 6.0.3.0. A test
    /// in <c>CoreTests</c> fails at that point as a reminder.
    /// </remarks>
    internal const string LegacyGeneratorToolName = ".NET Code Generation";
}
