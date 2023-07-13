/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Diagnostics;

namespace Hl7.Cql.Elm
{
    public class Annotation
    {
        public string? translatorOptions { get; set; }
        public string? type { get; set; }
        public Tag[]? t { get; set; }
    }

    [DebuggerDisplay("@{name}: {value}")]
    public class Tag
    {
        public string? name { get; set; }
        public string? value { get; set; }
    }
}

