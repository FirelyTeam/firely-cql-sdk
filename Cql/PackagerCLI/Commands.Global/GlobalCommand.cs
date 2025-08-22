/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager.Commands.Global;

[UsedImplicitly]
public sealed record GlobalCommand(string? Profile)
{
    public static readonly Option[] Options =
        [
            Option<string?>(
                "--profile",
                """
                The name of the profile to use from the configuration file. e.g. {App}.{Profile}.appsettings.json.
                This can be used to load different profiles, for example a name of a library set.
                """
            )
        ];

    public string Profile { get; init; } = CalcProfile(Profile);

    private static string CalcProfile(string? profile) =>
        profile
        ?? Environment.GetEnvironmentVariable($"{PackagerCliServiceCollectionExtensions.EnvironmentVariablePrefix}_PROFILE")
        ?? "";
}