/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Buffers;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
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
    /// <summary>
    /// The assemblies a reference to <see cref="GeneratedCodeAttribute"/> may name: the runtime assembly that
    /// defines it, which code compiled against the runtime's own assemblies references, and the reference and facade
    /// assemblies of the runtime that forward it there.
    /// </summary>
    private static readonly string[] GeneratedCodeAttributeAssemblies =
    [
        typeof(GeneratedCodeAttribute).Assembly.GetName().Name!,
        "System.Runtime",
        "System",
        "System.Diagnostics.Tools",
        "netstandard",
    ];

    /// <summary>
    /// The assembly a reference to <see cref="CqlLibraryAttribute"/> resolves to.
    /// </summary>
    private static readonly string CqlLibraryAttributeAssembly = typeof(CqlLibraryAttribute).Assembly.GetName().Name!;

    /// <summary>
    /// The signature of a constructor that takes two strings, as both <see cref="GeneratedCodeAttribute"/> and
    /// <see cref="CqlLibraryAttribute"/> have: an instance method of two parameters that returns nothing.
    /// </summary>
    private static ReadOnlySpan<byte> TwoStringConstructorSignature =>
        [(byte)SignatureAttributes.Instance, 2, (byte)SignatureTypeCode.Void, (byte)SignatureTypeCode.String, (byte)SignatureTypeCode.String];

    /// <summary>
    /// Which of the two attributes the reader reads an attribute is.
    /// </summary>
    private enum LibraryAttribute
    {
        None,
        GeneratedCode,
        CqlLibrary,
    }

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

        AssemblyName assemblyName;
        string? assemblyFullName = null;
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

            // The full name holds the public key token, which computing throws for a malformed public key. Compute it
            // once, here, so that such an assembly reads as unreadable instead.
            assemblyName = metadata.GetAssemblyDefinition().GetAssemblyName();
            assemblyFullName = assemblyName.FullName;

            ThrowIfDeclaringTypesFormACycle(metadata);
            var typeNames = new TypeNames(metadata);
            var attributeArguments = new AttributeArguments(metadata);
            foreach (var typeHandle in metadata.TypeDefinitions)
            {
                // The first type is the module's own <Module> type, which reflection never returns among the
                // assembly's types.
                if (MetadataTokens.GetRowNumber(typeHandle) == 1)
                    continue;

                var cqlLibraryInfos = ReadLibraryInfos(metadata, typeHandle, assemblyFullName, typeNames, attributeArguments);
                foreach (var cqlLibraryInfo in cqlLibraryInfos)
                    declarations.Add((typeHandle, typeNames.Get(typeHandle), cqlLibraryInfo));
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
            return new CqlAssemblyInfo(assemblyBinary, new CqlAssemblyUnreadableError(assemblyFullName, exception));
        }

        return new CqlAssemblyInfo(
            assemblyBinary,
            assemblyName,
            MergeLibrariesDeclaredMoreThanOnce(assemblyFullName, declarations));
    }

    /// <summary>
    /// Reads the libraries a type declares, as <see cref="CqlLibraryTypeRule.CreateLibraryInfos"/> decides them from
    /// the type's attributes, the same rule <see cref="CqlLibraryTypeRule.GetLibraryInfos"/> applies to a loaded type.
    /// </summary>
    /// <remarks>
    /// Only the SDK's and the runtime's own attribute types count, never a type of the same name from another
    /// assembly, as reflection only finds the attribute types themselves. And as reflection does, it reads the
    /// <see cref="GeneratedCodeAttribute"/>s only of a type that declares a CQL library, so a malformed one on any
    /// other type goes unnoticed by both. The type's name is built only when it declares a library or has an error.
    /// </remarks>
    /// <exception cref="CqlException{TError}">
    /// A <see cref="CqlLibraryTypeWithMalformedAttributeError"/> for an attribute value that reflection cannot read
    /// either, so the invoker cannot load the assembly.
    /// </exception>
    private static List<CqlLibraryInfo> ReadLibraryInfos(
        MetadataReader metadata,
        TypeDefinitionHandle typeHandle,
        string assemblyName,
        TypeNames typeNames,
        AttributeArguments attributeArguments)
    {
        List<(string? Identifier, string? Version)> cqlLibraries = [];
        List<CustomAttribute> generatedCodeAttributes = [];

        foreach (var attributeHandle in metadata.GetTypeDefinition(typeHandle).GetCustomAttributes())
        {
            var attribute = metadata.GetCustomAttribute(attributeHandle);
            switch (GetLibraryAttribute(metadata, attribute))
            {
                case LibraryAttribute.GeneratedCode:
                    generatedCodeAttributes.Add(attribute);
                    break;
                case LibraryAttribute.CqlLibrary:
                    cqlLibraries.Add(
                        attributeArguments.Read(attribute)
                        ?? throw Malformed(assemblyName, typeNames.Get(typeHandle), nameof(CqlLibraryAttribute)));
                    break;
            }
        }

        if (cqlLibraries.Count == 0)
            return [];

        var typeName = typeNames.Get(typeHandle);
        List<(string? Tool, string? Version)> generatedCodes = [];
        foreach (var attribute in generatedCodeAttributes)
            generatedCodes.Add(
                attributeArguments.Read(attribute)
                ?? throw Malformed(assemblyName, typeName, nameof(GeneratedCodeAttribute)));

        return CqlLibraryTypeRule.CreateLibraryInfos(assemblyName, typeName, cqlLibraries, generatedCodes);
    }

    /// <summary>
    /// Throws when the declaring types of a type form a cycle, which reflection cannot load either. Each type is walked
    /// past only once, so this costs no more than the number of types, however deeply they nest.
    /// </summary>
    /// <exception cref="BadImageFormatException">The declaring types of a type form a cycle.</exception>
    private static void ThrowIfDeclaringTypesFormACycle(MetadataReader metadata)
    {
        HashSet<TypeDefinitionHandle> acyclic = [];
        HashSet<TypeDefinitionHandle> walked = [];
        foreach (var typeHandle in metadata.TypeDefinitions)
        {
            walked.Clear();
            for (var current = typeHandle;
                 !current.IsNil && !acyclic.Contains(current);
                 current = metadata.GetTypeDefinition(current).GetDeclaringType())
            {
                if (!walked.Add(current))
                    throw new BadImageFormatException("The declaring types form a cycle.");
            }

            acyclic.UnionWith(walked);
        }
    }

    private static CqlException<CqlLibraryTypeWithMalformedAttributeError> Malformed(
        string assemblyName,
        string typeName,
        string attributeName) =>
        new CqlLibraryTypeWithMalformedAttributeError(assemblyName, typeName, attributeName).ToException();

    /// <summary>
    /// Keeps one entry per library identifier, deciding as the invoker does. Of the types that declare a library, only
    /// those it would otherwise load count, as it skips the others first. More than one of those makes a single entry
    /// whose error names them, as the invoker skips them all. Exactly one makes that type's entry, which loads. None
    /// keeps the first type's entry, with its error or its unsupported generator version.
    /// </summary>
    private static List<CqlLibraryInfo> MergeLibrariesDeclaredMoreThanOnce(
        string assemblyName,
        List<(TypeDefinitionHandle TypeHandle, string TypeName, CqlLibraryInfo CqlLibraryInfo)> declarations)
    {
        Dictionary<CqlVersionedLibraryIdentifier, int> indexByIdentifier = [];
        List<(CqlLibraryInfo Entry, List<(TypeDefinitionHandle TypeHandle, string TypeName)> LoadableTypes)> libraries = [];
        foreach (var (typeHandle, typeName, cqlLibraryInfo) in declarations)
        {
            if (!indexByIdentifier.TryGetValue(cqlLibraryInfo.LibraryIdentifier, out var index))
            {
                indexByIdentifier.Add(cqlLibraryInfo.LibraryIdentifier, index = libraries.Count);
                libraries.Add((cqlLibraryInfo, []));
            }

            // A type declares a library it would load at most once, as declaring it twice is an error, so a type is
            // never counted twice.
            var loadableTypes = libraries[index].LoadableTypes;
            if (!cqlLibraryInfo.IsSupported)
                continue;

            if (loadableTypes.Count == 0)
                libraries[index] = (cqlLibraryInfo, loadableTypes);
            loadableTypes.Add((typeHandle, typeName));
        }

        List<CqlLibraryInfo> cqlLibraryInfos = [];
        foreach (var (entry, loadableTypes) in libraries)
        {
            cqlLibraryInfos.Add(loadableTypes.Count < 2
                ? entry
                : entry with
                {
                    ReadError = new CqlLibraryDeclaredByMoreThanOneTypeError(
                        assemblyName,
                        entry.LibraryIdentifier,
                        [.. loadableTypes.Select(type => type.TypeName)]),
                });
        }

        return cqlLibraryInfos;
    }

    /// <summary>
    /// Which of the two attributes the reader reads an attribute is, told by the type its constructor's reference
    /// names and the assembly that reference goes through. The strings are compared where they are, never decoded.
    /// </summary>
    /// <remarks>
    /// An attribute type defined in the assembly being read is neither, nor is one not referenced through an assembly.
    /// </remarks>
    private static LibraryAttribute GetLibraryAttribute(MetadataReader metadata, CustomAttribute attribute)
    {
        if (attribute.Constructor.Kind != HandleKind.MemberReference)
            return LibraryAttribute.None;

        var memberReference = metadata.GetMemberReference((MemberReferenceHandle)attribute.Constructor);
        if (memberReference.Parent.Kind != HandleKind.TypeReference)
            return LibraryAttribute.None;

        var typeReference = metadata.GetTypeReference((TypeReferenceHandle)memberReference.Parent);
        if (typeReference.ResolutionScope.Kind != HandleKind.AssemblyReference)
            return LibraryAttribute.None;

        var strings = metadata.StringComparer;
        var assembly = metadata.GetAssemblyReference((AssemblyReferenceHandle)typeReference.ResolutionScope).Name;
        if (strings.Equals(typeReference.Name, typeof(GeneratedCodeAttribute).Name)
            && strings.Equals(typeReference.Namespace, typeof(GeneratedCodeAttribute).Namespace!))
        {
            foreach (var generatedCodeAttributeAssembly in GeneratedCodeAttributeAssemblies)
            {
                if (strings.Equals(assembly, generatedCodeAttributeAssembly, ignoreCase: true))
                    return LibraryAttribute.GeneratedCode;
            }

            return LibraryAttribute.None;
        }

        return strings.Equals(typeReference.Name, typeof(CqlLibraryAttribute).Name)
               && strings.Equals(typeReference.Namespace, typeof(CqlLibraryAttribute).Namespace!)
               && strings.Equals(assembly, CqlLibraryAttributeAssembly, ignoreCase: true)
            ? LibraryAttribute.CqlLibrary
            : LibraryAttribute.None;
    }

    /// <summary>
    /// Reads the two arguments of attributes whose constructor takes two strings, as both
    /// <see cref="GeneratedCodeAttribute"/> and <see cref="CqlLibraryAttribute"/> do: the value blob is the
    /// prolog <c>0x0001</c>, the two arguments as serialized strings, and the count of named arguments, which is 0
    /// because neither attribute has a member that one could set.
    /// </summary>
    /// <remarks>
    /// Decodes each value blob once, however many attributes share it, so that metadata cannot make reading decode the
    /// same strings again and again, and so that the libraries read from it share the strings.
    /// </remarks>
    private sealed class AttributeArguments(MetadataReader metadata)
    {
        private readonly Dictionary<BlobHandle, (string? First, string? Second)?> _values = [];

        /// <returns>
        /// The two arguments, or <see langword="null"/> where reflection cannot read the attribute either: its
        /// constructor is not the one that takes two strings, its value does not start with the prolog, or what follows
        /// the two arguments is neither nothing nor a count of no named arguments.
        /// </returns>
        public (string? First, string? Second)? Read(CustomAttribute attribute)
        {
            var constructor = metadata.GetMemberReference((MemberReferenceHandle)attribute.Constructor);
            if (!metadata.StringComparer.Equals(constructor.Name, ".ctor")
                || !IsTwoStringConstructorSignature(metadata.GetBlobReader(constructor.Signature)))
                return null;

            if (!_values.TryGetValue(attribute.Value, out var arguments))
                _values.Add(attribute.Value, arguments = Decode(metadata.GetBlobReader(attribute.Value)));
            return arguments;
        }

        private static bool IsTwoStringConstructorSignature(BlobReader signature)
        {
            var expected = TwoStringConstructorSignature;
            if (signature.Length != expected.Length)
                return false;

            foreach (var expectedByte in expected)
            {
                if (signature.ReadByte() != expectedByte)
                    return false;
            }

            return true;
        }

        private static (string? First, string? Second)? Decode(BlobReader value)
        {
            if (value.Length < 2 || value.ReadUInt16() != 0x0001)
                return null;

            var arguments = (value.ReadSerializedString(), value.ReadSerializedString());

            // Reflection reads a value that ends right after the arguments, or with a count of no named arguments and
            // nothing after it, and rejects any other.
            return value.RemainingBytes == 0 || (value.RemainingBytes == 2 && value.ReadUInt16() == 0) ? arguments : null;
        }
    }

    /// <summary>
    /// The full names of an assembly's types, as <see cref="Type.FullName"/> gives them: a type's namespace and name
    /// with the characters that full names reserve escaped, and a nested type's declaring types before it, each
    /// followed by <c>+</c>.
    /// </summary>
    /// <remarks>
    /// Builds a type's name only when asked for it, and each name only once, from its declaring type's. Decodes and
    /// escapes each namespace and name string only once, however many types share it. A name longer than
    /// <see cref="MaxLength"/> is cut there, and a type nested in a type whose name is cut gets that same name, so that
    /// metadata of deeply nested types, or of long names, cannot make reading slow. The reader tells types apart by
    /// their handles, never by these names.
    /// </remarks>
    private sealed class TypeNames(MetadataReader metadata)
    {
        /// <summary>
        /// The length a name is cut at.
        /// </summary>
        private const int MaxLength = 512;

        /// <summary>
        /// The characters that <see cref="Type.FullName"/> escapes with a backslash.
        /// </summary>
        private static readonly SearchValues<char> ReservedCharacters = SearchValues.Create("\\+,[]&*");

        private readonly Dictionary<TypeDefinitionHandle, string> _names = [];
        private readonly Dictionary<StringHandle, string> _segments = [];

        /// <summary>
        /// The full name of the type, whose declaring types <see cref="ThrowIfDeclaringTypesFormACycle"/> has
        /// found to form no cycle.
        /// </summary>
        public string Get(TypeDefinitionHandle typeHandle)
        {
            if (_names.TryGetValue(typeHandle, out var name))
                return name;

            // Collect the type and its declaring types, up to one that already has a name or is not nested.
            Stack<TypeDefinitionHandle> unnamed = new();
            string? declaringName = null;
            for (var current = typeHandle;;)
            {
                unnamed.Push(current);
                var declaringType = metadata.GetTypeDefinition(current).GetDeclaringType();
                if (declaringType.IsNil || _names.TryGetValue(declaringType, out declaringName))
                    break;

                current = declaringType;
            }

            // Name them outermost first, each from its declaring type's name.
            while (unnamed.TryPop(out var current))
            {
                if (declaringName is not { Length: > MaxLength })
                {
                    var type = metadata.GetTypeDefinition(current);
                    var typeNamespace = Segment(type.Namespace);
                    var typeName = Segment(type.Name);
                    var qualifiedName = typeNamespace.Length == 0 ? typeName : $"{typeNamespace}.{typeName}";
                    declaringName = Cut(declaringName is null ? qualifiedName : $"{declaringName}+{qualifiedName}");
                }

                _names.Add(current, declaringName);
            }

            return declaringName!;
        }

        /// <summary>
        /// A namespace or name string, escaped and cut, decoded only the first time.
        /// </summary>
        private string Segment(StringHandle handle)
        {
            if (handle.IsNil)
                return "";

            if (!_segments.TryGetValue(handle, out var segment))
                _segments.Add(handle, segment = Cut(Escape(metadata.GetString(handle))));
            return segment;
        }

        private static string Cut(string name) => name.Length > MaxLength ? $"{name[..MaxLength]}…" : name;

        private static string Escape(string name)
        {
            if (name.AsSpan().IndexOfAny(ReservedCharacters) < 0)
                return name;

            var escaped = new StringBuilder(name.Length + 8);
            foreach (var character in name)
            {
                if (ReservedCharacters.Contains(character))
                    escaped.Append('\\');
                escaped.Append(character);
            }

            return escaped.ToString();
        }
    }
}
