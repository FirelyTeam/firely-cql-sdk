/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Packager;
using Hl7.Cql.Packager.Commands.CqlToFhir;
using Hl7.Cql.Packager.Commands.ElmToFhir;
using Hl7.Cql.Packager.Commands.ExtractLibraryAttachments;
using Hl7.Cql.Packager.Commands.Global;
using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Cql.Packager.Commands.ReplaceLibraryAttachments;
using Hl7.Cql.Packager.Options;
using System.CommandLine;

namespace CoreTests;

[TestClass]
public class PackagerCliCommandBindingTests
{
    private static CqlToFhirCommand? capturedCqlCommand;
    private static ElmToFhirCommand? capturedElmCommand;

    [TestMethod]
    public void CsNamespaceOption_BindsToElmCSharpNamespaceConfig_ForCqlCommand()
    {
        var namespaceValue = "Smoke.Cql.Namespace";
        var cqlInputDirPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(cqlInputDirPath);

        try
        {
            var command =
                new Command("cql")
                    .AddOptions(CqlToFhirCommand.Options)
                    .SetHandler(typeof(PackagerCliCommandBindingTests), nameof(CaptureCqlCommand));

            var exitCode = command.Invoke(["--cql", cqlInputDirPath, "--cs-namespace", namespaceValue]);

            exitCode.Should().Be(0);
            capturedCqlCommand.Should().NotBeNull();

            var csNamespaceConfig =
                capturedCqlCommand!
                    .GetConfigMapping()
                    .Single(x => x.sectionPath.SequenceEqual([ElmOptions.ConfigSection, nameof(ElmOptions.CSharpNamespace)]));

            csNamespaceConfig.value.Should().Be(namespaceValue);
        }
        finally
        {
            Directory.Delete(cqlInputDirPath, recursive: true);
        }
    }

    [TestMethod]
    public void CsNamespaceOption_BindsToElmCSharpNamespaceConfig_ForElmCommand()
    {
        var namespaceValue = "Smoke.Elm.Namespace";
        var elmInputDirPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(elmInputDirPath);

        try
        {
            var command =
                new Command("elm")
                    .AddOptions(ElmToFhirCommand.Options)
                    .SetHandler(typeof(PackagerCliCommandBindingTests), nameof(CaptureElmCommand));

            var exitCode = command.Invoke(["--elm", elmInputDirPath, "--cs-namespace", namespaceValue]);

            exitCode.Should().Be(0);
            capturedElmCommand.Should().NotBeNull();

            var csNamespaceConfig =
                capturedElmCommand!
                    .GetConfigMapping()
                    .Single(x => x.sectionPath.SequenceEqual([ElmOptions.ConfigSection, nameof(ElmOptions.CSharpNamespace)]));

            csNamespaceConfig.value.Should().Be(namespaceValue);
        }
        finally
        {
            Directory.Delete(elmInputDirPath, recursive: true);
        }
    }

    [TestMethod]
    public void OptionNames_ShouldMatchRecordConstructorParameterNames_AcrossPackagerCommands()
    {
        var commandBindingsToAudit = new (Type commandType, Option[] options)[]
        {
            (typeof(CqlToFhirCommand), CqlToFhirCommand.Options),
            (typeof(ElmToFhirCommand), ElmToFhirCommand.Options),
            (typeof(ExtractLibraryAttachmentsCommand), ExtractLibraryAttachmentsCommand.Options),
            (typeof(ReplaceLibraryAttachmentsCommand), ReplaceLibraryAttachmentsCommand.Options),
            (typeof(LoggingCommand), LoggingCommand.Options),
            (typeof(GlobalCommand), GlobalCommand.Options)
        };

        foreach (var (commandType, options) in commandBindingsToAudit)
        {
            var constructorParameterNames = commandType
                .GetConstructors()
                .Single(ctor => ctor.GetParameters().All(p => p.ParameterType != commandType))
                .GetParameters()
                .Select(p => NormalizeName(p.Name!))
                .ToHashSet(StringComparer.Ordinal);

            foreach (var option in options)
            {
                var longAlias = option.Aliases.Single(a => a.StartsWith("--", StringComparison.Ordinal));
                var normalizedOptionName = NormalizeName(longAlias);

                constructorParameterNames
                    .Contains(normalizedOptionName)
                    .Should()
                    .BeTrue($"option '{longAlias}' on {commandType.Name} must bind to a constructor parameter by normalized name");
            }
        }
    }

    private static int CaptureCqlCommand(CqlToFhirCommand cqlCommand)
    {
        capturedCqlCommand = cqlCommand;
        return 0;
    }

    private static int CaptureElmCommand(ElmToFhirCommand elmCommand)
    {
        capturedElmCommand = elmCommand;
        return 0;
    }

    private static string NormalizeName(string value) =>
        new(value
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLowerInvariant)
            .ToArray());
}
