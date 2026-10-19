/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;

namespace Hl7.Cql.Invocation.Toolkit.Internal;

/// <summary>
/// Reads the CQL libraries that the code generator wrote into an assembly from the assembly's metadata,
/// with <c>System.Reflection.Metadata</c>, so that the assembly is never loaded.
/// </summary>
internal static class CqlAssemblyInfoReader
{
    private static readonly (string Namespace, string Name) GeneratedCodeAttributeName =
        (typeof(GeneratedCodeAttribute).Namespace!, typeof(GeneratedCodeAttribute).Name);

    private static readonly (string Namespace, string Name) CqlLibraryAttributeName =
        (typeof(CqlLibraryAttribute).Namespace!, typeof(CqlLibraryAttribute).Name);

    /// <summary>
    /// Reads the CQL libraries that the code generator wrote into an assembly.
    /// </summary>
    /// <exception cref="ArgumentNullException"><paramref name="assemblyBinary"/> is null.</exception>
    /// <exception cref="ArgumentException"><paramref name="assemblyBinary"/> holds no assembly bytes.</exception>
    /// <exception cref="BadImageFormatException">The bytes are not a .NET assembly, or its metadata cannot be read.</exception>
    /// <exception cref="InvalidOperationException">The assembly holds two library types with the same identifier.</exception>
    public static CqlAssemblyInfo Read(AssemblyBinary assemblyBinary)
    {
        ArgumentNullException.ThrowIfNull(assemblyBinary);
        if (assemblyBinary.AssemblyBytes is not { } assemblyBytes)
            throw new ArgumentException("The assembly binary holds no assembly bytes.", nameof(assemblyBinary));

        return ReadCore(assemblyBinary, assemblyBytes);
    }

    /// <summary>
    /// Reads the CQL libraries that the code generator wrote into an assembly, returning <see langword="false"/>
    /// wherever <see cref="Read"/> throws.
    /// </summary>
    public static bool TryRead(
        AssemblyBinary? assemblyBinary,
        [NotNullWhen(true)] out CqlAssemblyInfo? assemblyInfo)
    {
        assemblyInfo = null;
        if (assemblyBinary?.AssemblyBytes is not { } assemblyBytes)
            return false;

        try
        {
            assemblyInfo = ReadCore(assemblyBinary, assemblyBytes);
            return true;
        }
        catch (Exception exception) when (exception is BadImageFormatException or InvalidOperationException)
        {
            return false;
        }
    }

    private static CqlAssemblyInfo ReadCore(AssemblyBinary assemblyBinary, byte[] assemblyBytes)
    {
        AssemblyName assemblyName;
        List<CqlLibraryInfo> libraryInfos = [];

        try
        {
            using var peReader = new PEReader(ImmutableCollectionsMarshal.AsImmutableArray(assemblyBytes));
            if (!peReader.HasMetadata)
                throw new BadImageFormatException("The bytes hold no .NET metadata.");

            var metadata = peReader.GetMetadataReader();
            if (!metadata.IsAssembly)
                throw new BadImageFormatException("The bytes hold a .NET module without an assembly manifest.");

            assemblyName = metadata.GetAssemblyDefinition().GetAssemblyName();

            foreach (var typeHandle in metadata.TypeDefinitions)
            {
                if (ReadLibraryInfo(metadata, metadata.GetTypeDefinition(typeHandle)) is { } libraryInfo)
                    libraryInfos.Add(libraryInfo);
            }
        }
        catch (Exception exception) when (exception is not (BadImageFormatException or OutOfMemoryException))
        {
            // System.Reflection.Metadata reads lazily, so corrupt metadata surfaces partway through the read,
            // mostly but not always as a BadImageFormatException. Report every such failure the same way.
            throw new BadImageFormatException("The bytes are not a readable .NET assembly.", exception);
        }

        return new CqlAssemblyInfo(assemblyBinary, assemblyName, libraryInfos);
    }

    /// <summary>
    /// Reads the library a type declares, or <see langword="null"/> when the type is not a CQL library the
    /// code generator wrote.
    /// </summary>
    private static CqlLibraryInfo? ReadLibraryInfo(MetadataReader metadata, TypeDefinition type)
    {
        (string? Tool, string? Version)? generatedCode = null;
        (string? Identifier, string? Version)? cqlLibrary = null;

        foreach (var attributeHandle in type.GetCustomAttributes())
        {
            var attribute = metadata.GetCustomAttribute(attributeHandle);
            var attributeName = GetAttributeTypeName(metadata, attribute);
            if (attributeName == GeneratedCodeAttributeName)
                generatedCode ??= ReadTwoStringArguments(metadata, attribute);
            else if (attributeName == CqlLibraryAttributeName)
                cqlLibrary ??= ReadTwoStringArguments(metadata, attribute);
        }

        return cqlLibrary is { } library
               && generatedCode is { } generator
               && CqlLibraryTypeRule.TryCreateLibraryInfo(library.Identifier, library.Version, generator.Tool, generator.Version, out var libraryInfo)
            ? libraryInfo
            : null;
    }

    /// <summary>
    /// The namespace and name of the attribute's type, or empty strings when its constructor is not one this
    /// reader can resolve.
    /// </summary>
    private static (string Namespace, string Name) GetAttributeTypeName(MetadataReader metadata, CustomAttribute attribute)
    {
        switch (attribute.Constructor.Kind)
        {
            case HandleKind.MemberReference:
                var memberReference = metadata.GetMemberReference((MemberReferenceHandle)attribute.Constructor);
                if (memberReference.Parent.Kind != HandleKind.TypeReference)
                    return ("", "");

                var typeReference = metadata.GetTypeReference((TypeReferenceHandle)memberReference.Parent);
                return (metadata.GetString(typeReference.Namespace), metadata.GetString(typeReference.Name));

            case HandleKind.MethodDefinition:
                var methodDefinition = metadata.GetMethodDefinition((MethodDefinitionHandle)attribute.Constructor);
                var typeDefinition = metadata.GetTypeDefinition(methodDefinition.GetDeclaringType());
                return (metadata.GetString(typeDefinition.Namespace), metadata.GetString(typeDefinition.Name));

            default:
                return ("", "");
        }
    }

    /// <summary>
    /// Reads the two arguments of an attribute whose constructor takes two strings, as both
    /// <see cref="GeneratedCodeAttribute"/> and <see cref="CqlLibraryAttribute"/> do: the value blob is the
    /// prolog <c>0x0001</c> followed by the two arguments as serialized strings.
    /// </summary>
    private static (string? First, string? Second)? ReadTwoStringArguments(MetadataReader metadata, CustomAttribute attribute)
    {
        var value = metadata.GetBlobReader(attribute.Value);
        if (value.Length < 2 || value.ReadUInt16() != 0x0001)
            return null;

        return (value.ReadSerializedString(), value.ReadSerializedString());
    }
}
