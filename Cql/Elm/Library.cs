/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters


using Hl7.Cql.Abstractions.Exceptions;
using System.Collections.Generic;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Elm;

public partial class Library
{
    public const string JsonMimeType = "application/elm+json";
    public const string XmlMimeType = "application/elm+xml";
    public const string LibraryNodeProperty = "Library";

    internal bool IsValidated { get; private set; }

    /// <exception cref="LibraryMissingIncludeDefPathError"></exception>
    private void Validate()
    {
        if (IsValidated)
            return;

        _ = NameAndVersion(throwError: true);

        if (includes is { Length: > 0 } includeDefs)
        {
            foreach (var includeDef in includeDefs)
            {
                if (includeDef.NameAndVersion(throwError: false) == null)
                    throw new LibraryMissingIncludeDefPathError(this, includeDef).ToException();
            }
        }

        IsValidated = true;
    }

    public static IEqualityComparer<Library> EqualityComparerByNameAndVersion { get; } =
        EqualityComparerFactory.For<Library>.CreateByKey(lib => lib.NameAndVersion(true)!);

    public static IComparer<Library> ComparerByNameAndVersion { get; } =
        ComparerFactory.For<Library>.CreateByKey(lib => lib.NameAndVersion(true)!);

    internal string? OriginalFilePath { get; private set; }
}

internal class LibraryByNameAndVersionHashSet : HashSet<Library>
{
    public LibraryByNameAndVersionHashSet() : base(Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionHashSet(IEnumerable<Library> collection) : base(collection, Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionHashSet(int capacity) : base(capacity, Library.EqualityComparerByNameAndVersion)
    {
    }
}

internal class LibraryByNameAndVersionDictionary<TValue> : Dictionary<Library, TValue>
{
    public LibraryByNameAndVersionDictionary() : base(Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionDictionary(IDictionary<Library, TValue> dictionary) : base(dictionary, Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionDictionary(IEnumerable<KeyValuePair<Library, TValue>> collection) : base(collection, Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionDictionary(int capacity) : base(capacity, Library.EqualityComparerByNameAndVersion)
    {
    }
}