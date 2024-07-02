/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Graph
{
    internal class RecordTypeAndField
    {
        public string RecordType { get; set; } = string.Empty;
        public string Field { get; set; } = string.Empty;

        public override string ToString() => string.IsNullOrWhiteSpace(RecordType) ? Field : $"{RecordType}.{Field}";
    }
}
