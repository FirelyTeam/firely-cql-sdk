/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Commands.CqlToFhir;
using Hl7.Cql.Packager.Commands.ElmToFhir;
using Hl7.Cql.Packager.Commands.ExtractLibraryAttachments;
using Hl7.Cql.Packager.Commands.Global;
using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Cql.Packager.Commands.ReplaceLibraryAttachments;

namespace Hl7.Cql.Packager;

public class Program
{
    // The latest version number can be found under the releases tab of the CQL to ELM CLI repository
    // see: https://github.com/cqframework/clinical_quality_language/releases
    //
    // If you change the version here, you also need to update it in these places too:
    // * pom.xml
    // * Java-Dependencies-Vars.ps1
    // * Java-Dependencies-Vars.sh
    // * The Hl7.Cql.Packager.Program.JavaToolVersion for the Packager CLI
    private const string JavaToolVersion = "3.29.0";

    private static readonly string ApplicationName = Process.GetCurrentProcess().ProcessName;

    private static readonly string ApplicationVersion =
        typeof(Program).Assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
            .InformationalVersion.Split('+')[0] ?? "unknown";

    internal static readonly string Disclaimer =
        NewLine +
        NewLine +
        "DISCLAIMER:" +
        NewLine +
        "The cql command is a very early addition and only supports basic cql translation. " +
        "It is not yet production ready. " +
        $"If you find issues, please start from the ELM produced by the Java v{JavaToolVersion} tooling instead " +
        "as input for the elm command.";

    private static readonly string ApplicationHeader =
        $"{ApplicationName} v{ApplicationVersion} running on {RuntimeInformation.FrameworkDescription}";

    private static readonly string Description =
        ApplicationHeader +
        NewLine +
        new string('-', ApplicationHeader.Length) +
        NewLine +
        NewLine +
        "Utilities for converting CQL or ELM into other artefacts, such as C#, .NET assemblies or FHIR Resources. " +
        "Pick from a command listed below, or type [command] --help for more information on it." +
        Disclaimer;


    public static int Main(string[] args)
    {
        var rootCommand =
            new RootCommand(Description)
                {
                    Name = Process.GetCurrentProcess().ProcessName,
            }
                //.AddOptions(ElmToFhirCommand.EnumerationOptions)
                .AddGlobalOptions(LoggingCommand.Options)
                .AddGlobalOptions(GlobalCommand.Options)
                //.SetHandler(typeof(ElmToFhirProgram), nameof(ElmToFhirProgram.CommandHandler))
            ;

        rootCommand.AddCommand(ElmToFhirCommand.CreateCommand());
        rootCommand.AddCommand(CqlToFhirCommand.CreateCommand());
        rootCommand.AddCommand(ExtractLibraryAttachmentsCommand.CreateCommand());
        rootCommand.AddCommand(ReplaceLibraryAttachmentsCommand.CreateCommand());

        var systemConsole = new SystemConsole();
        var result = rootCommand.Invoke(args, systemConsole);
        return result;
    }
}