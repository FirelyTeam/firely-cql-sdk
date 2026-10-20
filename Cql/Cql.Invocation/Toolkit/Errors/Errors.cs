/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit.Errors;

/// <summary>
/// The bytes are not a .NET assembly whose metadata can be read: they are not a PE file at all, or its metadata is
/// corrupt.
/// </summary>
/// <remarks>
/// Unlike the other errors, this one holds an <see cref="System.Exception"/>, which compares by reference, so two
/// reads of the same bytes give unequal instances.
/// </remarks>
public readonly record struct CqlAssemblyUnreadableError : ICqlAssemblyInfoError
{
    internal CqlAssemblyUnreadableError(string? assemblyName, Exception exception)
    {
        AssemblyName = assemblyName;
        Exception = exception;
    }

    /// <summary>
    /// Gets the full name of the assembly, when its metadata could be read far enough to learn it; otherwise,
    /// <see langword="null"/>.
    /// </summary>
    public string? AssemblyName { get; }

    /// <summary>
    /// Gets what reading the bytes threw, mostly a <see cref="BadImageFormatException"/>, with its stack trace.
    /// </summary>
    public Exception Exception { get; }

    /// <inheritdoc />
    public string GetMessage() =>
        AssemblyName is null
            ? $"The bytes are not a readable .NET assembly: {Exception?.Message}"
            : $"The metadata of assembly '{AssemblyName}' cannot be read: {Exception?.Message}";
}

/// <summary>
/// The bytes are a PE file without .NET metadata, such as a native library.
/// </summary>
public readonly record struct CqlAssemblyWithoutMetadataError : ICqlAssemblyInfoError
{
    /// <summary>
    /// Gets <see langword="null"/>: a PE file without .NET metadata has no assembly name.
    /// </summary>
    public string? AssemblyName => null;

    /// <inheritdoc />
    public string GetMessage() => "The bytes are a PE file without .NET metadata, not a .NET assembly.";
}

/// <summary>
/// The bytes are a .NET module without an assembly manifest, which cannot be loaded on its own.
/// </summary>
public readonly record struct CqlModuleWithoutManifestError : ICqlAssemblyInfoError
{
    internal CqlModuleWithoutManifestError(string moduleName) => ModuleName = moduleName;

    /// <summary>
    /// Gets the name of the module, as its metadata states it.
    /// </summary>
    public string ModuleName { get; }

    /// <summary>
    /// Gets <see langword="null"/>: a module without an assembly manifest has no assembly name.
    /// </summary>
    public string? AssemblyName => null;

    /// <inheritdoc />
    public string GetMessage() => $"The bytes are the .NET module '{ModuleName}', which has no assembly manifest.";
}

/// <summary>
/// A type that declares a CQL library carries a <see cref="Hl7.Cql.Abstractions.CqlLibraryAttribute"/> or
/// <see cref="GeneratedCodeAttribute"/> whose value is malformed, so the assembly's metadata is corrupt: the value does
/// not start with the prolog <c>0x0001</c>, or it counts named arguments, which neither attribute has. Reflection cannot
/// read that attribute either, so the toolkit cannot load the assembly.
/// </summary>
public readonly record struct CqlLibraryTypeWithMalformedAttributeError : ICqlAssemblyInfoError
{
    internal CqlLibraryTypeWithMalformedAttributeError(string assemblyName, string typeName, string attributeName)
    {
        AssemblyName = assemblyName;
        TypeName = typeName;
        AttributeName = attributeName;
    }

    /// <summary>
    /// Gets the full name of the assembly.
    /// </summary>
    public string AssemblyName { get; }

    /// <summary>
    /// Gets the full name of the type, as <see cref="Type.FullName"/> gives it.
    /// </summary>
    public string TypeName { get; }

    /// <summary>
    /// Gets the name of the attribute type.
    /// </summary>
    public string AttributeName { get; }

    /// <inheritdoc />
    public string GetMessage() =>
        $"Type '{TypeName}' in assembly '{AssemblyName}' carries a {AttributeName} whose value is malformed, so "
        + "reflection cannot read it.";
}

/// <summary>
/// The assembly references an assembly at a newer version than the host has, so the toolkit cannot load it: the default
/// load context, which the toolkit binds such a reference through, binds it only to an assembly of at least the version
/// referenced, and an older one can lack what the assembly uses. An assembly built by a later release of the SDK
/// references that release's assemblies, and those of the Firely .NET SDK and the .NET runtime it builds against.
/// </summary>
/// <remarks>
/// The host's assembly of a name is the one the default load context binds a reference to: the assembly of that name it
/// has loaded, or else the one its trusted platform assemblies list. Of the references newer than the host's assemblies,
/// this names the first.
/// </remarks>
public readonly record struct CqlAssemblyWithNewerReferenceError : ICqlAssemblyInfoError
{
    internal CqlAssemblyWithNewerReferenceError(
        string assemblyName,
        string referencedAssemblyName,
        Version referencedVersion,
        Version hostVersion)
    {
        AssemblyName = assemblyName;
        ReferencedAssemblyName = referencedAssemblyName;
        ReferencedVersion = referencedVersion;
        HostVersion = hostVersion;
    }

    /// <summary>
    /// Gets the full name of the assembly.
    /// </summary>
    public string AssemblyName { get; }

    /// <summary>
    /// Gets the simple name of the assembly it references, as the reference states it.
    /// </summary>
    public string ReferencedAssemblyName { get; }

    /// <summary>
    /// Gets the version of that assembly that the reference names.
    /// </summary>
    public Version ReferencedVersion { get; }

    /// <summary>
    /// Gets the version of the host's assembly of that name, which is older than <see cref="ReferencedVersion"/>.
    /// </summary>
    public Version HostVersion { get; }

    /// <inheritdoc />
    public string GetMessage() =>
        $"Assembly '{AssemblyName}' references version {ReferencedVersion} of assembly '{ReferencedAssemblyName}', "
        + $"which is newer than the version {HostVersion} this host has, so the host cannot load it.";
}

/// <summary>
/// A type carries more than one <see cref="Hl7.Cql.Abstractions.CqlLibraryAttribute"/> or
/// <see cref="GeneratedCodeAttribute"/>, while a CQL library type carries exactly one of each.
/// </summary>
public readonly record struct CqlLibraryTypeWithMoreThanOneAttributeError : ICqlLibraryInfoError
{
    internal CqlLibraryTypeWithMoreThanOneAttributeError(
        string assemblyName,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string typeName,
        string attributeName)
    {
        AssemblyName = assemblyName;
        LibraryIdentifier = libraryIdentifier;
        TypeName = typeName;
        AttributeName = attributeName;
    }

    /// <summary>
    /// Gets the full name of the assembly that holds the type.
    /// </summary>
    public string AssemblyName { get; }

    /// <summary>
    /// Gets one of the libraries the type declares: each gets an error of its own.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier { get; }

    /// <summary>
    /// Gets the full name of the type, as <see cref="Type.FullName"/> gives it.
    /// </summary>
    public string TypeName { get; }

    /// <summary>
    /// Gets the name of the attribute type it carries more than once.
    /// </summary>
    public string AttributeName { get; }

    /// <inheritdoc />
    public string GetMessage() =>
        $"Type '{TypeName}' in assembly '{AssemblyName}', which declares CQL library '{LibraryIdentifier}', carries "
        + $"more than one {AttributeName}. A CQL library type carries exactly one.";
}

/// <summary>
/// More than one type declares the same CQL library, while a CQL library is declared by exactly one type.
/// </summary>
/// <remarks>
/// Two instances are equal when they name the same assembly, the same library and the same types in the same order.
/// </remarks>
public readonly record struct CqlLibraryDeclaredByMoreThanOneTypeError : ICqlLibraryInfoError
{
    internal CqlLibraryDeclaredByMoreThanOneTypeError(
        string? assemblyName,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        ImmutableArray<string> typeNames)
    {
        AssemblyName = assemblyName;
        LibraryIdentifier = libraryIdentifier;
        TypeNames = typeNames;
    }

    /// <summary>
    /// Gets the full name of the assembly that holds the types; <see langword="null"/> when they are in different
    /// assemblies.
    /// </summary>
    public string? AssemblyName { get; }

    /// <summary>
    /// Gets the library that more than one type declares.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier { get; }

    /// <summary>
    /// Gets the full names of those types, as <see cref="Type.FullName"/> gives them. When they are in different
    /// assemblies, each is followed by the name of its assembly, as in <c>Namespace.Type, Assembly</c>.
    /// </summary>
    public ImmutableArray<string> TypeNames { get; }

    /// <inheritdoc />
    public string GetMessage() =>
        $"CQL library '{LibraryIdentifier}' is declared by more than one type"
        + (AssemblyName is null ? "" : $" in assembly '{AssemblyName}'")
        + $": '{string.Join("', '", TypeNames.AsSpan().ToArray())}'. A CQL library is declared by exactly one type.";

    /// <inheritdoc />
    public bool Equals(CqlLibraryDeclaredByMoreThanOneTypeError other) =>
        AssemblyName == other.AssemblyName
        && LibraryIdentifier.Equals(other.LibraryIdentifier)
        && TypeNames.AsSpan().SequenceEqual(other.TypeNames.AsSpan());

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(AssemblyName);
        hashCode.Add(LibraryIdentifier);
        foreach (var typeName in TypeNames.AsSpan())
            hashCode.Add(typeName);
        return hashCode.ToHashCode();
    }

    /// <summary>
    /// Lists the type names in <see cref="ToString"/>, which would otherwise show only the type of the array.
    /// </summary>
    private bool PrintMembers(StringBuilder builder)
    {
        builder.Append("AssemblyName = ").Append(AssemblyName)
               .Append(", LibraryIdentifier = ").Append(LibraryIdentifier)
               .Append(", TypeNames = [").AppendJoin(", ", TypeNames.AsSpan().ToArray()).Append(']');
        return true;
    }
}
