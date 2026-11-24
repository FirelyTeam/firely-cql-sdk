/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Elm;
using ClassInfo = Hl7.Cql.Model.ClassInfo;
using ModelInfo = Hl7.Cql.Model.ModelInfo;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Translates libraries against a model info read from a file, which is not one of the models bundled with the SDK.
    /// </summary>
    [TestClass]
    public class ModelInfoFileTest : Base
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

        [TestMethod]
        public void Model_Loaded_From_File_Resolves_Retrieve_And_Property_Types()
        {
            var path = Path.Combine(Path.GetTempPath(), $"widgets-modelinfo-{Guid.NewGuid():N}.xml");
            File.WriteAllText(path, WidgetModelInfo);
            try
            {
                var modelInfo = ModelInfo.LoadFromFile(path);
                modelInfo.name.Should().Be("Widgets");

                var library = CreateCqlToolkit(ModelInfos: [modelInfo]).MakeLibrary("""
                    library WidgetTest version '1.0.0'

                    using Widgets version '1.0.0'

                    define AllWidgets: [Widget]

                    define Sizes: [Widget] W return W.size
                    """);

                var retrieve = library.statements.Single(s => s.name == "AllWidgets").expression.Should().BeOfType<Retrieve>().Subject;
                retrieve.dataType.Name.Should().Be("{urn:example:widgets}Widget");

                var sizes = library.statements.Single(s => s.name == "Sizes").expression;
                sizes.resultTypeSpecifier.Should().BeOfType<ListTypeSpecifier>()
                     .Which.elementType.Should().BeOfType<NamedTypeSpecifier>()
                     .Which.name.Name.Should().Be("{urn:hl7-org:elm-types:r1}Integer");
            }
            finally
            {
                File.Delete(path);
            }
        }

        [TestMethod]
        public void LoadFromStream_Reads_The_Same_Model_As_LoadFromFile()
        {
            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(WidgetModelInfo));

            var modelInfo = ModelInfo.LoadFromStream(stream);

            modelInfo.url.Should().Be("urn:example:widgets");
            modelInfo.version.Should().Be("1.0.0");
            modelInfo.typeInfo.OfType<ClassInfo>().Single().name.Should().Be("Widget");
        }

        [TestMethod]
        public void LoadFromStream_Rejects_Xml_That_Is_Not_A_Model_Info()
        {
            using var stream = new MemoryStream(Encoding.UTF8.GetBytes("<library xmlns=\"urn:hl7-org:elm:r1\"/>"));

            var load = () => ModelInfo.LoadFromStream(stream);

            load.Should().Throw<InvalidOperationException>();
        }
    }
}
