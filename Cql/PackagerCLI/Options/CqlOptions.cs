/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packager.Options;

public record CqlOptions : CqlToolkitConfig, IBindOptions
{
    public const string ConfigSection = "Cql";
    static string IBindOptions.ConfigSection => ConfigSection;

    /// <remarks>Called by convention from <see cref="OptionsBinder"/></remarks>>
    [UsedImplicitly]
    public static bool TryBindModels(IConfiguration config, out ImmutableHashSet<CqlModel>? value)
    {
        value = config.Get<CqlModel[]>()?.ToImmutableHashSet();
        return value is not null;
    }
}