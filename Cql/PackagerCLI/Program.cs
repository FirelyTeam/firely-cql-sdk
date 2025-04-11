/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Commands.CqlToFhir;
using Hl7.Cql.Packager.Commands.ElmToFhir;

namespace Hl7.Cql.Packager;

public class Program
{
    private const string Description =
        "Utilities for converting CQL or ELM into other types, such as C#, .NET assemblies or FHIR Resources. " +
        "Pick from a command listed below, or type [command] --help for more information on it.";

    public static int Main(string[] args)
    {
        var rootCommand =
            new RootCommand(Description)
                //.AddOptions(ElmToFhirCommand.Options)
                .AddGlobalOptions(LoggingCommand.Options)
                //.SetHandler(typeof(ElmToFhirProgram), nameof(ElmToFhirProgram.CommandHandler))
            ;

        rootCommand.AddCommand(ElmToFhirCommand.CreateCommand());
        rootCommand.AddCommand(CqlToFhirCommand.CreateCommand());

        var systemConsole = new SystemConsole();
        var result = rootCommand.Invoke(args, systemConsole);
        return result;
    }
}