using System.Diagnostics;

namespace Ncqa.Elm
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
