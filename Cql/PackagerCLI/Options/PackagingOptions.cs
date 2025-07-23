/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Runtime;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Packager.Options;

public record PackagingOptions : PackagingToolkitConfig, IBindOptions
{
    public const string ConfigSection = "Packaging";

    /// <remarks>Called by convention from <see cref="OptionsBinder"/></remarks>>
    [UsedImplicitly]
    public static bool TryBindFixedLibraryCanonicals(IConfiguration config, out IReadOnlyDictionary<CqlLibraryIdentifier, string> value)
    {
        value = config.GetChildren()
                      .SelectWhere(kv => (kv.Key, kv.Value) switch
                      {
                          ({} k,{} v) => (true, (Key:(CqlLibraryIdentifier)k, Value:v)),
                          _           => default,
                      })
                      .ToDictionary(kv => kv.Key, kv => kv.Value)
                      .AsReadOnly();
        return value.Count > 0;
    }

    public bool JsonPretty { get; init; }

    static string IBindOptions.ConfigSection => ConfigSection;
}