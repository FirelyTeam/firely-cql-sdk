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
    [DebuggerDisplay("{identifier.id}-{identifier.version}")]
    public class Library
    {
        public Annotation[]? annotation { get; set; }
        public Identifier? identifier { get; set; }
        public SchemaIdentifier? schemaIdentifier { get; set; }
        public Usings? usings { get; set; }
        public IncludesExpression? includes { get; set; }
        public Statements? statements { get; set; }
        public ValueSets? valueSets { get; set; }
        public Parameters? parameters { get; set; }
        public CodeSystems? codeSystems { get; set; }
        public Codes? codes { get; set; }
    }
}
