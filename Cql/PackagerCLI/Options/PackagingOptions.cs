/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Options;

internal record PackagingBindOptions : IConfigureBindOptions<PackagingBindOptions>
{
    public const string ConfigSection = "Packaging";
    static string IBindOptions.ConfigSection => ConfigSection;

    public Uri? CanonicalRootUrl { get; init; }
    public DateTime? OverrideDate { get; init; }
    public bool JsonPretty { get; init; }

    public static void Configure(PackagingBindOptions opt, IConfiguration configuration)
    {
        // While DateTimes can be bound directly from IConfiguration, we convert to UTC
        var localTime = opt.OverrideDate?.ToLocalTime();
        typeof(PackagingBindOptions)
            .GetProperty(nameof(OverrideDate))!
            .SetValue(opt, localTime);
    }
}