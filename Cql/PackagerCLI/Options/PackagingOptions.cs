/*
 * Copyright(c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Options;

internal record PackagingOptions : IConfigureOptionsEx<PackagingOptions>
{
    public const string ConfigSection = "Packaging";
    static string IOptionsEx.ConfigSection => ConfigSection;

    public Uri? CanonicalRootUrl { get; init; }
    public DateTime? OverrideDate { get; init; }
    public bool JsonPretty { get; init; }

    public static void Configure(PackagingOptions opt, IConfiguration configuration)
    {
        // While DateTimes can be bound directly from IConfiguration, we convert to UTC
        var localTime = opt.OverrideDate?.ToLocalTime();
        typeof(PackagingOptions)
            .GetProperty(nameof(OverrideDate))!
            .SetValue(opt, localTime);
    }
}