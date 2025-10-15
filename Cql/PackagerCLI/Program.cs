/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Commands.CqlToFhir;
using Hl7.Cql.Packager.Commands.ElmToFhir;
using Hl7.Cql.Packager.Commands.Global;
using Hl7.Cql.Packager.Commands.Logging;

namespace Hl7.Cql.Packager;

public class Program
{
    /// <summary>
    /// ** KEEP THIS IN SYNC WITH THE POM.XML FILE **
    /// The version of the Java CQL to ELM tool that this packager is compatible with.
    /// Keep this in sync with &lt;cql.version> in the pom.xml file in this repository.
    /// </summary>
    private const string JavaToolVersion = "3.28.0";

    internal static readonly string Disclaimer =
        Environment.NewLine +
        Environment.NewLine +
        "DISCLAIMER:" +
        Environment.NewLine +
        "The cql command is a very early addition and only supports basic cql translation. " +
        "It is not yet production ready. " +
        $"If you find issues, please start from the ELM produced by the Java v{JavaToolVersion} tooling instead " +
        "as input for the elm command.";

    private static readonly string Description =
        "Utilities for converting CQL or ELM into other artefacts, such as C#, .NET assemblies or FHIR Resources. " +
        "Pick from a command listed below, or type [command] --help for more information on it." +
        Disclaimer;


    public static int Main(string[] args)
    {
        var rootCommand =
            new RootCommand(Description)
                {
                    Name = Process.GetCurrentProcess().ProcessName, // Use the name of the executable as the command name
            }
                //.AddOptions(ElmToFhirCommand.Options)
                .AddGlobalOptions(LoggingCommand.Options)
                .AddGlobalOptions(GlobalCommand.Options)
                //.SetHandler(typeof(ElmToFhirProgram), nameof(ElmToFhirProgram.CommandHandler))
            ;

        rootCommand.AddCommand(ElmToFhirCommand.CreateCommand());
        rootCommand.AddCommand(CqlToFhirCommand.CreateCommand());

        var systemConsole = new SystemConsole();
        var result = rootCommand.Invoke(args, systemConsole);
        return result;
    }
}