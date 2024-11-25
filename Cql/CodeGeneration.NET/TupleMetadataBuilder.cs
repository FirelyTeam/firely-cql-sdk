/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET;

internal class TupleMetadataBuilder
{
    private readonly Dictionary<string, IReadOnlyCollection<(string Name, Type Type)>> _signaturesByHash = new();

    public string GetTupleMetadataPropertyName(
        IReadOnlyCollection<(string Name, Type Type)> tupleItemsSignature)
    {
        var propName = CqlTupleMetadata.BuildSignatureHashString(tupleItemsSignature);
        _signaturesByHash[propName] = tupleItemsSignature;
        return propName;
    }

    public IReadOnlyCollection<(string PropertyName, IReadOnlyCollection<(string Name, Type Type)> Signature)> GetAllTupleMetadataPropertySignatures() =>
        _signaturesByHash
            .SelectToArray(kv => (kv.Key, kv.Value));
}