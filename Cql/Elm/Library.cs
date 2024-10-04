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

        _ = this.GetVersionedIdentifier(throwError: true);

        if (includes is { Length: > 0 } includeDefs)
        {
            foreach (var includeDef in includeDefs)
            {
                if (includeDef.GetVersionedIdentifier(throwError: false) == null)
                    throw new LibraryMissingIncludeDefPathError(this, includeDef).ToException();
            }
        }

        IsValidated = true;
    }

    public static IEqualityComparer<Library> EqualityComparerByVersionedIdentifier { get; } =
        EqualityComparerFactory.For<Library>.CreateByKey(lib => lib.GetVersionedIdentifier(true)!);

    internal string? OriginalFilePath { get; private set; }
}

internal class LibraryByVersionedIdentifierHashSet : HashSet<Library>
{
    public LibraryByVersionedIdentifierHashSet() : base(Library.EqualityComparerByVersionedIdentifier)
    {
    }

    public LibraryByVersionedIdentifierHashSet(IEnumerable<Library> collection) : base(collection, Library.EqualityComparerByVersionedIdentifier)
    {
    }

    public LibraryByVersionedIdentifierHashSet(int capacity) : base(capacity, Library.EqualityComparerByVersionedIdentifier)
    {
    }
}