/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace XsdToCSharpConverter;

/// <summary>
/// Command-line options for the XSD to C# converter.
/// </summary>
internal sealed class CommandLineOptions
{
    public List<string> SchemaFiles { get; set; } = [];
    public string OutputPath { get; set; } = string.Empty;
    public string OutputFile { get; set; } = string.Empty;
    public string Namespace { get; set; } = string.Empty;
    public bool GenerateClasses { get; set; } = true;
}
