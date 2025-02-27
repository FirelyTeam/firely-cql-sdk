namespace Hl7.Cql.CodeGeneration.NET;

internal partial class LibrarySetCSharpCodeGenerator
{
    /// <summary>
    /// Gets the version of this <see cref="LibrarySetCSharpCodeGenerator"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Version"/>.
    /// </summary>
    /// <remarks>
    /// This version must be MANUALLY updated whenever the code generation logic changes.
    /// The version should be updated according to the Semantic Versioning specification.
    /// This version does not correlate to the version of the CQL SDK.
    /// </remarks>
    private const string GeneratorToolVersion = "2.1";

    /// <summary>
    /// Gets the product of this <see cref="LibrarySetCSharpCodeGenerator"/> as will appear in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
    /// </summary>
    private static string GeneratorToolName { get; } = GetGeneratorToolNameFromAssemblyProductName();
}