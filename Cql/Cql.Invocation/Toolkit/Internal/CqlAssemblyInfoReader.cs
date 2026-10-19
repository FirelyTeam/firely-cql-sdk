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
        List<(TypeDefinitionHandle TypeHandle, string TypeName, CqlLibraryInfo CqlLibraryInfo)> declarations = [];

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
                    declarations.Add((typeHandle, typeName, cqlLibraryInfo));
            }
        }
        catch (CqlException<CqlLibraryTypeWithMalformedAttributeError> exception)
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
    /// assembly, as reflection only finds the attribute types themselves. And as reflection does, it reads the
    /// <see cref="GeneratedCodeAttribute"/>s only of a type that declares a CQL library, so a malformed one on any
    /// other type goes unnoticed by both.
    /// </remarks>
    private static List<CqlLibraryInfo> ReadLibraryInfos(
        MetadataReader metadata,
        TypeDefinition type,
        string assemblyName,
        string typeName)
    {
        List<(string? Identifier, string? Version)> cqlLibraries = [];
        List<CustomAttribute> generatedCodeAttributes = [];

        foreach (var attributeHandle in type.GetCustomAttributes())
        {
            var attribute = metadata.GetCustomAttribute(attributeHandle);
            var (attributeName, attributeAssembly) = GetAttributeType(metadata, attribute);
            if (attributeAssembly is null)
                continue;

            if (attributeName == GeneratedCodeAttributeName && GeneratedCodeAttributeAssemblies.Contains(attributeAssembly))
                generatedCodeAttributes.Add(attribute);
            else if (attributeName == CqlLibraryAttributeName
                     && string.Equals(attributeAssembly, CqlLibraryAttributeAssembly, StringComparison.OrdinalIgnoreCase))
                cqlLibraries.Add(ReadTwoStringArguments(metadata, attribute, assemblyName, typeName, attributeName.Name));
        }

        if (cqlLibraries.Count == 0)
            return [];

        List<(string? Tool, string? Version)> generatedCodes = [];
        foreach (var attribute in generatedCodeAttributes)
            generatedCodes.Add(ReadTwoStringArguments(metadata, attribute, assemblyName, typeName, GeneratedCodeAttributeName.Name));

        return CqlLibraryTypeRule.CreateLibraryInfos(assemblyName, typeName, cqlLibraries, generatedCodes);
    }

    /// <summary>
    /// Keeps one entry per library identifier. A library that more than one type declares becomes a single entry whose
    /// error names those types, as the invoker skips every one of them.
    /// </summary>
    private static List<CqlLibraryInfo> MergeLibrariesDeclaredMoreThanOnce(
        string assemblyName,
        List<(TypeDefinitionHandle TypeHandle, string TypeName, CqlLibraryInfo CqlLibraryInfo)> declarations)
    {
        Dictionary<CqlVersionedLibraryIdentifier, List<(TypeDefinitionHandle TypeHandle, string TypeName)>> typesByIdentifier = [];
        List<CqlLibraryInfo> cqlLibraryInfos = [];
        foreach (var (typeHandle, typeName, cqlLibraryInfo) in declarations)
        {
            if (typesByIdentifier.TryGetValue(cqlLibraryInfo.LibraryIdentifier, out var types))
            {
                if (!types.Any(type => type.TypeHandle == typeHandle))
                    types.Add((typeHandle, typeName));
                continue;
            }

            typesByIdentifier.Add(cqlLibraryInfo.LibraryIdentifier, [(typeHandle, typeName)]);
            cqlLibraryInfos.Add(cqlLibraryInfo);
        }

        for (var index = 0; index < cqlLibraryInfos.Count; index++)
        {
            var cqlLibraryInfo = cqlLibraryInfos[index];
            var types = typesByIdentifier[cqlLibraryInfo.LibraryIdentifier];
            if (types.Count > 1)
                cqlLibraryInfos[index] = cqlLibraryInfo with
                {
                    ReadError = new CqlLibraryDeclaredByMoreThanOneTypeError(
                        assemblyName,
                        cqlLibraryInfo.LibraryIdentifier,
                        [.. types.Select(type => type.TypeName)]),
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
        Stack<string> typeNames = new();
        typeNames.Push(metadata.GetString(type.Name));
        HashSet<TypeDefinitionHandle> declaringTypes = [];
        for (var declaringType = type.GetDeclaringType(); !declaringType.IsNil; declaringType = type.GetDeclaringType())
        {
            if (!declaringTypes.Add(declaringType))
                throw new BadImageFormatException("The declaring types form a cycle.");

            type = metadata.GetTypeDefinition(declaringType);
            typeNames.Push(metadata.GetString(type.Name));
        }

        var typeName = string.Join("+", typeNames);
        var typeNamespace = metadata.GetString(type.Namespace);
        return typeNamespace.Length == 0 ? typeName : $"{typeNamespace}.{typeName}";
    }

    /// <summary>
    /// Reads the two arguments of an attribute whose constructor takes two strings, as both
    /// <see cref="GeneratedCodeAttribute"/> and <see cref="CqlLibraryAttribute"/> do: the value blob is the
    /// prolog <c>0x0001</c>, the two arguments as serialized strings, and the count of named arguments, which is 0
    /// because neither attribute has a member that one could set.
    /// </summary>
    /// <exception cref="CqlException{TError}">
    /// A <see cref="CqlLibraryTypeWithMalformedAttributeError"/>: the value blob does not start with the prolog, or does not end
    /// with a count of no named arguments, which makes the assembly's metadata corrupt. Reflection then fails to read
    /// the attribute, so the invoker cannot load the assembly.
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
            throw new CqlLibraryTypeWithMalformedAttributeError(assemblyName, typeName, attributeName).ToException();

        var arguments = (value.ReadSerializedString(), value.ReadSerializedString());
        if (value.RemainingBytes < 2 || value.ReadUInt16() != 0)
            throw new CqlLibraryTypeWithMalformedAttributeError(assemblyName, typeName, attributeName).ToException();

        return arguments;
    }
}
