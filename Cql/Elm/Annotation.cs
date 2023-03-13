using System.Diagnostics;

namespace Ncqa.Elm
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

