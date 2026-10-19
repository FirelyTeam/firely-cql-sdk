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
/// <param name="AssemblyName">
/// The full name of the assembly, when its metadata could be read far enough to learn it; otherwise,
/// <see langword="null"/>.
/// </param>
/// <param name="Exception">
/// What reading the bytes threw, mostly a <see cref="BadImageFormatException"/>, with its stack trace.
/// </param>
/// <remarks>
/// Unlike the other errors, this one holds an <see cref="System.Exception"/>, which compares by reference, so two
/// reads of the same bytes give unequal instances.
/// </remarks>
public readonly record struct CqlAssemblyUnreadableError(string? AssemblyName, Exception Exception) : ICqlAssemblyInfoError
{
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
/// <param name="ModuleName">The name of the module, as its metadata states it.</param>
public readonly record struct CqlModuleWithoutManifestError(string ModuleName) : ICqlAssemblyInfoError
{
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
/// <param name="AssemblyName">The full name of the assembly.</param>
/// <param name="TypeName">The full name of the type, as <see cref="Type.FullName"/> gives it.</param>
/// <param name="AttributeName">The name of the attribute type.</param>
public readonly record struct CqlLibraryTypeWithMalformedAttributeError(string AssemblyName, string TypeName, string AttributeName)
    : ICqlAssemblyInfoError
{
    /// <inheritdoc />
    public string GetMessage() =>
        $"Type '{TypeName}' in assembly '{AssemblyName}' carries a {AttributeName} whose value is malformed, so "
        + "reflection cannot read it.";
}

/// <summary>
/// A type carries more than one <see cref="Hl7.Cql.Abstractions.CqlLibraryAttribute"/> or
/// <see cref="GeneratedCodeAttribute"/>, while a CQL library type carries exactly one of each.
/// </summary>
/// <param name="AssemblyName">The full name of the assembly that holds the type.</param>
/// <param name="LibraryIdentifier">One of the libraries the type declares: each gets an error of its own.</param>
/// <param name="TypeName">The full name of the type, as <see cref="Type.FullName"/> gives it.</param>
/// <param name="AttributeName">The name of the attribute type it carries more than once.</param>
public readonly record struct CqlLibraryTypeWithMoreThanOneAttributeError(
    string AssemblyName,
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    string TypeName,
    string AttributeName) : ICqlLibraryInfoError
{
    /// <inheritdoc />
    public string GetMessage() =>
        $"Type '{TypeName}' in assembly '{AssemblyName}', which declares CQL library '{LibraryIdentifier}', carries "
        + $"more than one {AttributeName}. A CQL library type carries exactly one.";
}

/// <summary>
/// More than one type declares the same CQL library, while a CQL library is declared by exactly one type.
/// </summary>
/// <param name="AssemblyName">
/// The full name of the assembly that holds the types; <see langword="null"/> when they are in different assemblies.
/// </param>
/// <param name="LibraryIdentifier">The library that more than one type declares.</param>
/// <param name="TypeNames">
/// The full names of those types, as <see cref="Type.FullName"/> gives them. When they are in different assemblies,
/// each is followed by the name of its assembly, as in <c>Namespace.Type, Assembly</c>.
/// </param>
/// <remarks>
/// Two instances are equal when they name the same assembly, the same library and the same types in the same order.
/// </remarks>
public readonly record struct CqlLibraryDeclaredByMoreThanOneTypeError(
    string? AssemblyName,
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    ImmutableArray<string> TypeNames) : ICqlLibraryInfoError
{
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
