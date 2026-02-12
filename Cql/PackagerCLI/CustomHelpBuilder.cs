/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.CommandLine.Builder;
using System.CommandLine.Help;

namespace Hl7.Cql.Packager;

/// <summary>
/// Custom help builder that adds exit codes section at the bottom of help output.
/// </summary>
internal class CustomHelpBuilder : HelpBuilder
{
    private static readonly Dictionary<string, string> ExitCodesByCommand = new();

    public CustomHelpBuilder(LocalizationResources localizationResources, int maxWidth = int.MaxValue) 
        : base(localizationResources, maxWidth)
    {
    }

    public static void RegisterExitCodes(string commandName, string exitCodesText)
    {
        ExitCodesByCommand[commandName] = exitCodesText;
    }

    public override void Write(HelpContext context)
    {
        base.Write(context);

        // Add exit codes section at the end if available for this command
        if (context.Command != null && ExitCodesByCommand.TryGetValue(context.Command.Name, out var exitCodes))
        {
            context.Output.WriteLine();
            context.Output.WriteLine("Exit Codes:");
            foreach (var line in exitCodes.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
            {
                context.Output.WriteLine($"  {line}");
            }
        }
    }
}
