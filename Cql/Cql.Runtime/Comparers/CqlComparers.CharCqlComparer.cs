/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    private class CharCqlComparer(ICqlComparer<string> stringCqlComparer) :
        CqlComparerWrapper<char?, string>(stringCqlComparer, c => c?.ToString());
}