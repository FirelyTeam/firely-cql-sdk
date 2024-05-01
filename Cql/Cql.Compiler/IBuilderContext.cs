using System.Globalization;
using System.Linq;

namespace Hl7.Cql.Compiler;

internal interface IBuilderContext
{
    IBuilderContext? OuterBuilderContext { get; }
    BuilderContextDebuggerInfo? DebuggerInfo { get; }

    /// <summary>
    /// A useful hash for debugging purposes.
    /// Look up a specific case from the log file,
    /// then set a conditional breakpoint on the Hash property
    /// to break when the hash matches the one from the log file.
    /// </summary>
    string Hash =>
        $"#{Hasher.Instance.Hash(
                string.Concat(
                    this.SelfAndAncestorBuilders()
                        .Select((b, i) => Hasher.Instance.Hash(b?.DebuggerInfo.ToString() ?? i.ToString(CultureInfo.InvariantCulture)))))
            [..8]}";
}