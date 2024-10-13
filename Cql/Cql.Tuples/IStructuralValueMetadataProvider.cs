namespace Hl7.Cql.Tuples;

#pragma warning disable RS0037
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0016

public interface IStructuralValueMetadataProvider
{
    static abstract StructuralValueMetadata Metadata { get; }
}