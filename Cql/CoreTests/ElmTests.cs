using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Hl7.Cql.Elm.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CoreTests
{
    [TestClass]
    public class ElmTests
    {
        [TestMethod]
        public void Elm_Deserialize_TupleElementDefinition()
        {
            const string json = """
                                {
                                     "type" : "TupleElementDefinition",
                                     "elementType" : 
                                     {
                                         "type": "NamedTypeSpecifier",
                                         "name": "{urn:hl7-org:elm-types:r1}Integer"
                                     }
                                }
                                """;

            var serializer = JsonSerializer.Create();
            var ted = serializer.Deserialize<TupleElementDefinition>(new JsonTextReader(new StringReader(json)));

            Assert.IsNull(ted.type, "type is a TypeSpecifier, not a string and strict mode is off.");
            Assert.IsNotNull(ted.elementType);
            Assert.IsInstanceOfType(ted.elementType, typeof(NamedTypeSpecifier));
            var nts = (NamedTypeSpecifier)ted.elementType;
            Assert.IsNotNull(nts.name);
            Assert.AreEqual("{urn:hl7-org:elm-types:r1}Integer", nts.name.Name);
        }

        [TestMethod]
        public void Elm_Deseriailze_TupleTypeSpecifier()
        {
            // var json = @"
            // {
            //     ""type"" : ""TupleTypeSpecifier"",
            //     ""element"" :
            //      [
            //         {
            //           ""type"" : ""TupleElementDefinition"",
            //           ""elementType"" : {
            //             ""type"" : ""NamedTypeSpecifier"",
            //             ""name"" : ""{urn:hl7-org:elm-types:r1}Integer""
            //               },
            //       ""name"" : ""Id""
            //     },
            //     {
            //       ""type"" : ""TupleElementDefinition"",
            //       ""elementType"" : {
            //         ""type"" : ""NamedTypeSpecifier"",
            //         ""name"" : ""{urn:hl7-org:elm-types:r1}String""
            //       },
            //       ""name"" : ""Name""
            //     } ]
            //   }";
            //
            // var ts = JsonSerializer.Deserialize<TypeSpecifier>(json, Library.JsonSerializerOptions);
            // Assert.IsInstanceOfType(ts, typeof(TupleTypeSpecifier));
            // var tts = (TupleTypeSpecifier)ts;
            // Assert.IsNotNull(tts.element);
            // Assert.AreEqual(2, tts.element.Length);
            // var ted1 = tts.element[0];
            // Assert.IsNull(ted1.type, "type is a TypeSpecifier, not a string and strict mode is off.");
            // Assert.IsNotNull(ted1.elementType);
            // Assert.IsInstanceOfType(ted1.elementType, typeof(NamedTypeSpecifier));
            // var nts = (NamedTypeSpecifier)ted1.elementType;
            // Assert.IsNotNull(nts.name);
            // Assert.AreEqual("{urn:hl7-org:elm-types:r1}Integer", nts.name.Name);
            //
            // var ted2 = tts.element[1];
            // Assert.IsNull(ted2.type, "type is a TypeSpecifier, not a string and strict mode is off.");
            // Assert.IsNotNull(ted2.elementType);
            // Assert.IsInstanceOfType(ted2.elementType, typeof(NamedTypeSpecifier));
            // nts = (NamedTypeSpecifier)ted2.elementType;
            // Assert.IsNotNull(nts.name);
            // Assert.AreEqual("{urn:hl7-org:elm-types:r1}String", nts.name.Name);
        }

        [TestMethod]
        public void Elm_Deserialize_FhirHelpers()
        {
            var originalElm = File.ReadAllText(@"Input\ELM\Libs\FHIRHelpers-4.0.1.json");
            var lib = Library.DeserializeFromJsonSTJ(originalElm);
            var elm = lib.SerializeToJsonSTJ();

            // TODO: compare originalElm to elm.
        }
    }
}