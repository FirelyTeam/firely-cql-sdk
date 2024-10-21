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
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CodeGeneration.NET;

internal class TupleMetadataBuilder
{
    private readonly Dictionary<string, IReadOnlyCollection<(Type Type, string PropName)>> _signaturesByHash = new();

    public string GetTupleMetadataPropertyName(
        IReadOnlyCollection<(Type Type, string PropName)> tupleProps)
    {
        var propName = CqlTupleMetadata.BuildSignatureHashString(tupleProps, CqlTupleMetadata.PropertyPrefix);
        _signaturesByHash[propName] = tupleProps;
        return propName;
    }

    public IReadOnlyCollection<(string PropertyName, IReadOnlyCollection<(Type Type, string PropName)> Signature)> GetAllTupleMetadataPropertySignatures() =>
        _signaturesByHash.SelectToArray(kv => (kv.Key, kv.Value));
}