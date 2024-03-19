using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

/// <summary>Arguments for the <see cref="ResourcePackager.Package(ResourcePackageArgs)"/> method.</summary>
public record ResourcePackageArgs
{
    /// <summary>Creates an instance of this type to be passed on for the <see cref="ResourcePackager.Package(ResourcePackageArgs)"/> method.</summary>
    /// <param name="elmDir">Directory to find the ELM files</param>
    /// <param name="cqlDir">Directory to find the CQL files</param>
    /// <param name="afterPackageMutator">Optional mutator for the resources prior to writing</param>
    /// <param name="resourceCanonicalRootUrl">Root part of the resource canonical; otherwise just a '#'</param>
    public ResourcePackageArgs(
        DirectoryInfo elmDir, 
        DirectoryInfo cqlDir,
        Action<IEnumerable<Resource>>? afterPackageMutator = null,
        string? resourceCanonicalRootUrl = null)
    {
        ElmDir = elmDir;
        CqlDir = cqlDir;
        AfterPackageMutator = afterPackageMutator;
        ResourceCanonicalRootUrl = resourceCanonicalRootUrl;
    }

    /// <summary>directory to find the ELM files</summary>
    public DirectoryInfo ElmDir { get; }

    /// <summary>directory to find the CQL files</summary>
    public DirectoryInfo CqlDir { get; }

    /// <summary>
    /// Optional mutator for the resources prior to writing.
    /// </summary>
    public Action<IEnumerable<Resource>>? AfterPackageMutator { get; init; }

    /// <summary>
    /// Root part of the resource canonical; otherwise just a '#'.
    /// </summary>
    public string? ResourceCanonicalRootUrl { get; init; }
}