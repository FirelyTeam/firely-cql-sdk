/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;

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
    /// The assemblies a reference to <see cref="GeneratedCodeAttribute"/> may resolve to: the runtime assembly that
    /// defines it, which code compiled against the runtime's own assemblies references, and the reference and facade
    /// assemblies that forward to it.
    /// </summary>
    private static readonly FrozenSet<string> GeneratedCodeAttributeAssemblies =
        new[] { typeof(GeneratedCodeAttribute).Assembly.GetName().Name!, "System.Runtime", "netstandard", "mscorlib" }
            .ToFrozenSet(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// The assembly a reference to <see cref="CqlLibraryAttribute"/> resolves to.
    /// </summary>
    private static readonly string CqlLibraryAttributeAssembly = typeof(CqlLibraryAttribute).Assembly.GetName().Name!;

    /// <summary>
    /// Reads the CQL libraries that the code generator wrote into an assembly.
    /// </summary>
    /// <exception cref="ArgumentNullException"><paramref name="assemblyBinary"/> is null.</exception>
    /// <exception cref="ArgumentException"><paramref name="assemblyBinary"/> holds no assembly bytes.</exception>
    /// <remarks>
    /// Bytes that cannot be read are reported through <see cref="CqlAssemblyInfo.ReadError"/>, and a library declared in a
    /// way the toolkit does not accept through <see cref="CqlLibraryInfo.ReadError"/>, while the rest of the assembly is
    /// still read.
    /// </remarks>
    public static CqlAssemblyInfo Read(AssemblyBinary assemblyBinary)
    {
        ArgumentNullException.ThrowIfNull(assemblyBinary);
        if (assemblyBinary.AssemblyBytes is not { } assemblyBytes)
            throw new ArgumentException("The assembly binary holds no assembly bytes.", nameof(assemblyBinary));

        try
        {
            return ReadCore(assemblyBinary, assemblyBytes);
        }
        catch (BadImageFormatException exception)
        {
            return new CqlAssemblyInfo(assemblyBinary, exception);
        }
    }

    private static CqlAssemblyInfo ReadCore(AssemblyBinary assemblyBinary, byte[] assemblyBytes)
    {
        AssemblyName assemblyName;
        List<(string TypeName, CqlLibraryInfo CqlLibraryInfo)> declarations = [];

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
                var type = metadata.GetTypeDefinition(typeHandle);
                var typeName = GetTypeName(metadata, type);
                foreach (var cqlLibraryInfo in ReadLibraryInfos(metadata, type, typeName))
                    declarations.Add((typeName, cqlLibraryInfo));
            }
        }
        catch (Exception exception) when (exception is not (BadImageFormatException or OutOfMemoryException))
        {
            // System.Reflection.Metadata reads lazily, so corrupt metadata surfaces partway through the read,
            // mostly but not always as a BadImageFormatException. Report every such failure the same way.
            throw new BadImageFormatException("The bytes are not a readable .NET assembly.", exception);
        }

        return new CqlAssemblyInfo(assemblyBinary, assemblyName, MergeLibrariesDeclaredMoreThanOnce(declarations));
    }

    /// <summary>
    /// Reads the libraries a type declares, as <see cref="CqlLibraryTypeRule.CreateLibraryInfos"/> decides them from
    /// the type's attributes, the same rule <see cref="CqlLibraryTypeRule.GetLibraryInfos"/> applies to a loaded type.
    /// </summary>
    /// <remarks>
    /// Only the SDK's and the runtime's own attribute types count, never a type of the same name from another
    /// assembly, as reflection only finds the attribute types themselves.
    /// </remarks>
    private static List<CqlLibraryInfo> ReadLibraryInfos(MetadataReader metadata, TypeDefinition type, string typeName)
    {
        List<(string? Identifier, string? Version)> cqlLibraries = [];
        List<(string? Tool, string? Version)> generatedCodes = [];

        foreach (var attributeHandle in type.GetCustomAttributes())
        {
            var attribute = metadata.GetCustomAttribute(attributeHandle);
            var (attributeName, attributeAssembly) = GetAttributeType(metadata, attribute);
            if (attributeAssembly is null)
                continue;

            if (attributeName == GeneratedCodeAttributeName && GeneratedCodeAttributeAssemblies.Contains(attributeAssembly))
                generatedCodes.Add(ReadTwoStringArguments(metadata, attribute));
            else if (attributeName == CqlLibraryAttributeName
                     && string.Equals(attributeAssembly, CqlLibraryAttributeAssembly, StringComparison.OrdinalIgnoreCase))
                cqlLibraries.Add(ReadTwoStringArguments(metadata, attribute));
        }

        return CqlLibraryTypeRule.CreateLibraryInfos(typeName, cqlLibraries, generatedCodes);
    }

    /// <summary>
    /// Keeps one entry per library identifier. A library that more than one type declares becomes a single entry whose
    /// error names those types, as the invoker skips every one of them.
    /// </summary>
    private static List<CqlLibraryInfo> MergeLibrariesDeclaredMoreThanOnce(
        List<(string TypeName, CqlLibraryInfo CqlLibraryInfo)> declarations)
    {
        Dictionary<CqlVersionedLibraryIdentifier, List<string>> typeNamesByIdentifier = [];
        List<CqlLibraryInfo> cqlLibraryInfos = [];
        foreach (var (typeName, cqlLibraryInfo) in declarations)
        {
            if (typeNamesByIdentifier.TryGetValue(cqlLibraryInfo.LibraryIdentifier, out var typeNames))
            {
                if (!typeNames.Contains(typeName))
                    typeNames.Add(typeName);
                continue;
            }

            typeNamesByIdentifier.Add(cqlLibraryInfo.LibraryIdentifier, [typeName]);
            cqlLibraryInfos.Add(cqlLibraryInfo);
        }

        for (var index = 0; index < cqlLibraryInfos.Count; index++)
        {
            var cqlLibraryInfo = cqlLibraryInfos[index];
            var typeNames = typeNamesByIdentifier[cqlLibraryInfo.LibraryIdentifier];
            if (typeNames.Count > 1)
                cqlLibraryInfos[index] = cqlLibraryInfo with
                {
                    ReadError = CqlLibraryTypeRule.DeclaredByMoreThanOneType(cqlLibraryInfo.LibraryIdentifier, typeNames),
                };
        }

        return cqlLibraryInfos;
    }

    /// <summary>
    /// The namespace and name of the attribute's type, and the name of the assembly a reference to that type
    /// resolves to.
    /// </summary>
    /// <remarks>
    /// The assembly is <see langword="null"/> when the attribute type is defined in the assembly being read, which
    /// makes it neither the SDK's nor the runtime's own, or when it is not referenced through an assembly at all.
    /// </remarks>
    private static ((string Namespace, string Name) Name, string? Assembly) GetAttributeType(
        MetadataReader metadata,
        CustomAttribute attribute)
    {
        if (attribute.Constructor.Kind != HandleKind.MemberReference)
            return (("", ""), null);

        var memberReference = metadata.GetMemberReference((MemberReferenceHandle)attribute.Constructor);
        if (memberReference.Parent.Kind != HandleKind.TypeReference)
            return (("", ""), null);

        var typeReference = metadata.GetTypeReference((TypeReferenceHandle)memberReference.Parent);
        var assembly = typeReference.ResolutionScope.Kind == HandleKind.AssemblyReference
            ? metadata.GetString(metadata.GetAssemblyReference((AssemblyReferenceHandle)typeReference.ResolutionScope).Name)
            : null;
        return ((metadata.GetString(typeReference.Namespace), metadata.GetString(typeReference.Name)), assembly);
    }

    /// <summary>
    /// The type's full name, as <see cref="Type.FullName"/> gives it: qualified by its namespace when it has one, and a
    /// nested type by its declaring types, so that no two types of the assembly share it.
    /// </summary>
    private static string GetTypeName(MetadataReader metadata, TypeDefinition type)
    {
        var typeName = metadata.GetString(type.Name);
        var declaringType = type.GetDeclaringType();
        if (!declaringType.IsNil)
            return $"{GetTypeName(metadata, metadata.GetTypeDefinition(declaringType))}+{typeName}";

        var typeNamespace = metadata.GetString(type.Namespace);
        return typeNamespace.Length == 0 ? typeName : $"{typeNamespace}.{typeName}";
    }

    /// <summary>
    /// Reads the two arguments of an attribute whose constructor takes two strings, as both
    /// <see cref="GeneratedCodeAttribute"/> and <see cref="CqlLibraryAttribute"/> do: the value blob is the
    /// prolog <c>0x0001</c> followed by the two arguments as serialized strings.
    /// </summary>
    /// <exception cref="BadImageFormatException">
    /// The value blob does not start with the prolog, which makes the assembly's metadata corrupt: reflection then
    /// fails to read the attribute, so the invoker cannot load the assembly.
    /// </exception>
    private static (string? First, string? Second) ReadTwoStringArguments(MetadataReader metadata, CustomAttribute attribute)
    {
        var value = metadata.GetBlobReader(attribute.Value);
        if (value.Length < 2 || value.ReadUInt16() != 0x0001)
            throw new BadImageFormatException("A custom attribute's value does not start with the prolog 0x0001.");

        return (value.ReadSerializedString(), value.ReadSerializedString());
    }
}
