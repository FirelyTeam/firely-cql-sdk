/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Packager.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace CoreTests;

/// <summary>
/// Binds the Packager's <c>Cql:ModelInfoFiles</c> setting, a list of model info file paths, into <see cref="CqlOptions"/>
/// through the same options pipeline the Packager CLI uses, and reads the files with <see cref="CqlOptions.WithModelInfoFiles"/>.
/// </summary>
[TestClass]
public class PackagerCqlModelInfoFilesTests
{
    private const string WidgetModelInfo = """
        <?xml version="1.0" encoding="UTF-8"?>
        <modelInfo xmlns="urn:hl7-org:elm-modelinfo:r1" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                   name="Widgets" version="1.0.0" url="urn:example:widgets" targetQualifier="widgets">
          <typeInfo xsi:type="ClassInfo" namespace="Widgets" name="Widget" retrievable="true" baseType="System.Any">
            <element name="size" elementType="System.Integer"/>
          </typeInfo>
        </modelInfo>
        """;

    private static CqlOptions BindCqlOptions(params (string Key, string Value)[] settings)
    {
        var configuration = new ConfigurationBuilder()
                            .AddInMemoryCollection(settings.Select(s => new KeyValuePair<string, string?>(s.Key, s.Value)))
                            .Build();
        using var services = new ServiceCollection()
                             .AddSingleton<IConfiguration>(configuration)
                             .AddAndBindOptions<CqlOptions>()
                             .BuildServiceProvider();
        return services.GetRequiredService<IOptions<CqlOptions>>().Value;
    }

    [TestMethod]
    public void ModelInfoFiles_Are_Read_Next_To_The_Selected_Models()
    {
        var path = Path.Combine(Path.GetTempPath(), $"widgets-modelinfo-{Guid.NewGuid():N}.xml");
        File.WriteAllText(path, WidgetModelInfo);
        try
        {
            var options = BindCqlOptions(("Cql:Models:0", "ElmR1"), ("Cql:Models:1", "Fhir401"), ("Cql:ModelInfoFiles:0", path));

            options.ModelInfoFiles.Should().Equal(path);
            var config = options.WithModelInfoFiles();
            config.ModelInfos.Should().ContainSingle()
                  .Which.url.Should().Be("urn:example:widgets");
            config.Models.Should().BeEquivalentTo([CqlModel.ElmR1, CqlModel.Fhir401]);
        }
        finally
        {
            File.Delete(path);
        }
    }

    [TestMethod]
    public void Without_The_Setting_No_Model_Info_Is_Read()
    {
        var options = BindCqlOptions(("Cql:Models:0", "ElmR1"));

        options.ModelInfoFiles.Should().BeNull();
        options.WithModelInfoFiles().ModelInfos.Should().BeEmpty();
    }

    [TestMethod]
    public void Binding_Does_Not_Read_The_Files()
    {
        // Commands that do not translate CQL bind these options too, so a missing file must not fail them.
        var path = Path.Combine(Path.GetTempPath(), $"missing-modelinfo-{Guid.NewGuid():N}.xml");

        var options = BindCqlOptions(("Cql:ModelInfoFiles:0", path));

        options.ModelInfoFiles.Should().Equal(path);
    }

    [TestMethod]
    public void A_Missing_File_Is_Reported_With_Its_Path_And_The_Setting()
    {
        var path = Path.Combine(Path.GetTempPath(), $"missing-modelinfo-{Guid.NewGuid():N}.xml");
        var options = BindCqlOptions(("Cql:ModelInfoFiles:0", path));

        var read = () => options.WithModelInfoFiles();

        read.Should().Throw<InvalidOperationException>()
            .WithMessage($"*'{path}'*Cql:ModelInfoFiles*");
    }

    [TestMethod]
    public void A_File_That_Is_Not_A_Model_Info_Is_Reported()
    {
        var path = Path.Combine(Path.GetTempPath(), $"not-a-modelinfo-{Guid.NewGuid():N}.xml");
        File.WriteAllText(path, "<library xmlns=\"urn:hl7-org:elm:r1\"/>");
        try
        {
            var options = BindCqlOptions(("Cql:ModelInfoFiles:0", path));

            var read = () => options.WithModelInfoFiles();

            read.Should().Throw<InvalidOperationException>()
                .WithMessage($"*'{path}'*Cql:ModelInfoFiles*");
        }
        finally
        {
            File.Delete(path);
        }
    }

    [TestMethod]
    public void An_Empty_Path_Is_Reported_With_The_Setting()
    {
        var options = new CqlOptions { ModelInfoFiles = [" "] };

        var read = () => options.WithModelInfoFiles();

        read.Should().Throw<InvalidOperationException>()
            .WithMessage("Cql:ModelInfoFiles contains an empty file path.");
    }
}
