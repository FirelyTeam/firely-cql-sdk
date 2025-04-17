/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packaging.Toolkit;

namespace Hl7.Cql.Packager.Options;

public record FhirOptions : PackagingToolkitConfig, IBindOptions
{
    public const string ConfigSection = "Packaging";

    static string IBindOptions.ConfigSection => ConfigSection;
}