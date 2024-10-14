/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;

namespace Hl7.Cql.CodeGeneration.NET;

internal class TupleMetadataBuilder
{
    public string GetTupleMetadataPropertyName(
        IReadOnlyCollection<(Type Type, string Name)> tupleItemsSignature)
    {
        return "default(CqlTupleMetadata)";
    }
}