/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
namespace Hl7.Cql.Packaging;

internal partial class CqlToResourcePackagingOptions
{
	public const string ConfigSection = "Packager";

	public const string ArgNameElmDirectory = "--elm";
	public DirectoryInfo ElmDirectory { get; set; } = null!;

	public const string ArgNameCqlDirectory = "--cql";
	public DirectoryInfo CqlDirectory { get; set; } = null!;

	public const string ArgNameLogDebugEnabled = "--log-debug";
	public bool LogDebugEnabled { get; set; }

	public const string ArgNameLogDontClear = "--log-dont-clear";
	internal bool DontLogClear { get; set; }  // Internal use only!

	public const string ArgNameCanonicalRootUrl = "--canonical-root-url";
	public Uri? CanonicalRootUrl { get; set; }
}