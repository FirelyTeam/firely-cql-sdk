/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CodeGeneration.NET;

internal class TupleMetadataBuilder
{
    private readonly Dictionary<string, IReadOnlyCollection<(Type Type, string PropName)>> _signaturesByHashedPropertyName = new();
    private readonly Dictionary<string, SortedSet<string>> _hashedPropertyNamesUsedByLibrary = new();

    public string GetTupleMetadataPropertyName(
        IReadOnlyCollection<(Type Type, string PropName)> tupleProps,
        string libraryName)
    {
        var hashedPropertyName = CqlTupleMetadata.BuildSignatureHashString(tupleProps, CqlTupleMetadata.PropertyPrefix);
        _signaturesByHashedPropertyName[hashedPropertyName] = tupleProps;
        _hashedPropertyNamesUsedByLibrary.GetOrAdd(libraryName, _ => []).Add(hashedPropertyName);
        return hashedPropertyName;
    }

    public IReadOnlyCollection<(string PropertyName, IReadOnlyCollection<(Type Type, string PropName)> Signature)>
        GetLibraryTupleMetadataPropertySignatures(string libraryName)
    {
        return _hashedPropertyNamesUsedByLibrary
               .GetValueOrDefault(libraryName)
               ?.Select(hashedPropertyName => (hashedPropertyName, _signaturesByHashedPropertyName[hashedPropertyName]))
               .ToArray()
               ?? [];
    }
}