/*/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 #1#
namespace Hl7.Cql.Packaging;

internal partial class CqlToResourcePackagingOptions
{
	public const string ConfigSection = "Packager";

    public DirectoryInfo ElmDirectory { get; set; } = null!;

    public DirectoryInfo CqlDirectory { get; set; } = null!;

    public bool LogDebugEnabled { get; set; }

    internal bool DontLogClear { get; set; }  // Internal use only!

    public Uri? CanonicalRootUrl { get; set; }
}*/