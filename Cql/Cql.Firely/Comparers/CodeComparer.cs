/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers;

internal class CodeOfEnumCqlComparer<TEnum> :
    CqlComparerWrapper<Code<TEnum>, TEnum?>,
    ISingleton<CodeOfEnumCqlComparer<TEnum>>
    where TEnum : struct, Enum
{
    private CodeOfEnumCqlComparer() :
        base(DefaultCqlComparer<TEnum?>.Instance, code => code.Value)
    { }

    public static CodeOfEnumCqlComparer<TEnum> Instance { get; } = new();
}
