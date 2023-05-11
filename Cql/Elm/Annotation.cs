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

