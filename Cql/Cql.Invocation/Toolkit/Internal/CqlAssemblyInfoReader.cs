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
using Hl7.Cql.Exceptions;
using Hl7.Cql.Invocation.Toolkit.Errors;
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

        AssemblyName? assemblyName = null;
        List<(string TypeName, CqlLibraryInfo CqlLibraryInfo)> declarations = [];

        try
        {
            using var peReader = new PEReader(ImmutableCollectionsMarshal.AsImmutableArray(assemblyBytes));
            if (!peReader.HasMetadata)
                return new CqlAssemblyInfo(assemblyBinary, new CqlAssemblyWithoutMetadataError());

            var metadata = peReader.GetMetadataReader();
            if (!metadata.IsAssembly)
                return new CqlAssemblyInfo(
                    assemblyBinary,
                    new CqlModuleWithoutManifestError(metadata.GetString(metadata.GetModuleDefinition().Name)));

            assemblyName = metadata.GetAssemblyDefinition().GetAssemblyName();

            foreach (var typeHandle in metadata.TypeDefinitions)
            {
                var type = metadata.GetTypeDefinition(typeHandle);
                var typeName = GetTypeName(metadata, type);
                foreach (var cqlLibraryInfo in ReadLibraryInfos(metadata, type, assemblyName.FullName, typeName))
                    declarations.Add((typeName, cqlLibraryInfo));
            }
        }
        catch (CqlException<CqlLibraryAttributeValueError> exception)
        {
            return new CqlAssemblyInfo(assemblyBinary, exception.Error);
        }
        catch (Exception exception) when (exception is not OutOfMemoryException)
        {
            // System.Reflection.Metadata reads lazily, so corrupt metadata surfaces partway through the read,
            // mostly but not always as a BadImageFormatException. Report every such failure the same way.
            return new CqlAssemblyInfo(assemblyBinary, new CqlAssemblyUnreadableError(assemblyName?.FullName, exception));
        }

        return new CqlAssemblyInfo(
            assemblyBinary,
            assemblyName,
            MergeLibrariesDeclaredMoreThanOnce(assemblyName.FullName, declarations));
    }

    /// <summary>
    /// Reads the libraries a type declares, as <see cref="CqlLibraryTypeRule.CreateLibraryInfos"/> decides them from
    /// the type's attributes, the same rule <see cref="CqlLibraryTypeRule.GetLibraryInfos"/> applies to a loaded type.
    /// </summary>
    /// <remarks>
    /// Only the SDK's and the runtime's own attribute types count, never a type of the same name from another
    /// assembly, as reflection only finds the attribute types themselves.
    /// </remarks>
    private static List<CqlLibraryInfo> ReadLibraryInfos(
        MetadataReader metadata,
        TypeDefinition type,
        string assemblyName,
        string typeName)
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
                generatedCodes.Add(ReadTwoStringArguments(metadata, attribute, assemblyName, typeName, attributeName.Name));
            else if (attributeName == CqlLibraryAttributeName
                     && string.Equals(attributeAssembly, CqlLibraryAttributeAssembly, StringComparison.OrdinalIgnoreCase))
                cqlLibraries.Add(ReadTwoStringArguments(metadata, attribute, assemblyName, typeName, attributeName.Name));
        }

        return CqlLibraryTypeRule.CreateLibraryInfos(assemblyName, typeName, cqlLibraries, generatedCodes);
    }

    /// <summary>
    /// Keeps one entry per library identifier. A library that more than one type declares becomes a single entry whose
    /// error names those types, as the invoker skips every one of them.
    /// </summary>
    private static List<CqlLibraryInfo> MergeLibrariesDeclaredMoreThanOnce(
        string assemblyName,
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
                    ReadError = new CqlLibraryDeclaredByMoreThanOneTypeError(
                        assemblyName,
                        cqlLibraryInfo.LibraryIdentifier,
                        [.. typeNames]),
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
    /// <exception cref="BadImageFormatException">The declaring types form a cycle.</exception>
    private static string GetTypeName(MetadataReader metadata, TypeDefinition type)
    {
        var typeName = metadata.GetString(type.Name);
        var declaringTypeCount = 0;
        for (var declaringType = type.GetDeclaringType(); !declaringType.IsNil; declaringType = type.GetDeclaringType())
        {
            // A corrupt NestedClass table can make the declaring types a cycle. More declaring types than the assembly
            // defines means it does, so stop there rather than walk it forever.
            if (++declaringTypeCount > metadata.TypeDefinitions.Count)
                throw new BadImageFormatException($"The declaring types of type '{typeName}' form a cycle.");

            type = metadata.GetTypeDefinition(declaringType);
            typeName = $"{metadata.GetString(type.Name)}+{typeName}";
        }

        var typeNamespace = metadata.GetString(type.Namespace);
        return typeNamespace.Length == 0 ? typeName : $"{typeNamespace}.{typeName}";
    }

    /// <summary>
    /// Reads the two arguments of an attribute whose constructor takes two strings, as both
    /// <see cref="GeneratedCodeAttribute"/> and <see cref="CqlLibraryAttribute"/> do: the value blob is the
    /// prolog <c>0x0001</c> followed by the two arguments as serialized strings.
    /// </summary>
    /// <exception cref="CqlException{TError}">
    /// A <see cref="CqlLibraryAttributeValueError"/>: the value blob does not start with the prolog, which makes the
    /// assembly's metadata corrupt. Reflection then fails to read the attribute, so the invoker cannot load the assembly.
    /// </exception>
    private static (string? First, string? Second) ReadTwoStringArguments(
        MetadataReader metadata,
        CustomAttribute attribute,
        string assemblyName,
        string typeName,
        string attributeName)
    {
        var value = metadata.GetBlobReader(attribute.Value);
        if (value.Length < 2 || value.ReadUInt16() != 0x0001)
            throw new CqlLibraryAttributeValueError(assemblyName, typeName, attributeName).ToException();

        return (value.ReadSerializedString(), value.ReadSerializedString());
    }
}
