/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Globalization;
using System.Linq;
using Hl7.Cql.Abstractions;

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