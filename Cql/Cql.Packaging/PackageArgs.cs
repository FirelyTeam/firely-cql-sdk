using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;


/// <summary>Arguments for the <see cref="ResourcePackager.Package(PackageArgs)"/> method.</summary>
public record PackageArgs
{
    /// <summary>Creates an instance of this type to be passed on for the <see cref="ResourcePackager.Package(PackageArgs)"/> method.</summary>
    /// <param name="elmDir">Directory to find the ELM files</param>
    /// <param name="cqlDir">Directory to find the CQL files</param>
    /// <param name="afterPackageMutator">Optional mutator for the resources prior to writing</param>
    /// <param name="resourceCanonicalRootUrl">Root part of the resource canonical; otherwise just a '#'</param>
    public PackageArgs(
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

    /// <summary>
    /// Optional mutator for the resources prior to writing.
    /// </summary>
    public Action<IEnumerable<Resource>>? AfterPackageMutator { get; init; }

    /// <summary>
    /// Root part of the resource canonical; otherwise just a '#'.
    /// </summary>
    public string? ResourceCanonicalRootUrl { get; init; }

    /// <summary>directory to find the ELM files</summary>
    public DirectoryInfo ElmDir { get; }

    /// <summary>directory to find the CQL files</summary>
    public DirectoryInfo CqlDir { get; }
}