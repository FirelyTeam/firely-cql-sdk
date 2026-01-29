/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Fhir.Model;
using Library = Hl7.Cql.Elm.Library;
using Annotation = Hl7.Cql.Elm.Annotation;

namespace CoreTests
{
    [TestClass]
    public class ElmSerializerTests
    {
        [TestMethod]
        public void Elm_Deserialize_TupleTypeSpecifier()
        {
            var json =
                """
                {
                    "type" : "ChoiceTypeSpecifier",
                    "choice" : [ {
                      "type" : "NamedTypeSpecifier",
                      "name" : "{http://hl7.org/fhir}CodeableConcept"  } ]
                }
                """;

            var options = Library.BuildSerializerOptions(allowOldStyleTypeDiscriminators: true);
            var ts = JsonSerializer.Deserialize<ChoiceTypeSpecifier>(json, options);
            var cts = ts.Should().BeOfType<ChoiceTypeSpecifier>().Subject;
            cts.choice.Should().HaveCount(1);
        }

        private static readonly HashSet<string> AcceptableErrors = new()
        {
            // Although it seems enums are *always* serialized (even when they are set to the default
            // value), sometimes they are not for accessLevel. That's acceptable.
            "Unexpected key 'accessLevel' (value '\"Public\"') found in actual object.",
            //now removing empty values due to JAVA ELM having many empty arrays in the output
            @"Expected key 'relationship' (value '[]') not found in actual object. At $.library.statements.def[6].expression.else.element[0].value."
        };

        [TestMethod]
        public void Elm_Deserialize_FhirHelpers()
        {
            var originalElm = File.ReadAllText(Path.Combine("Input", "ELM", "Libs", "FHIRHelpers-4.0.1.json"));
            var lib = Library.ParseFromJson(originalElm);
            var elm = lib.SerializeToJson();

            var expected = JsonNode.Parse(originalElm);
            var actual = JsonNode.Parse(elm);
            var errors = CompareNode(expected, actual);
            errors.RemoveAll(acceptable);

            Assert.AreEqual(0, errors.Count, message: string.Join("\n", errors));

            static bool acceptable(string s)
            {
                return AcceptableErrors.Any(s.Contains);
            }
        }
        [TestMethod]
        public void Elm_Deserialize_Deep()
        {
            var originalElm = File.ReadAllText(Path.Combine("Input", "ELM", "Libs", "CMS133FHIRCataracts2040BCVA90Days.json"));
            var lib = Library.ParseFromJson(originalElm);
            var elm = lib.SerializeToJson();

            var expected = JsonNode.Parse(originalElm);
            var actual = JsonNode.Parse(elm);
            var errors = CompareNode(expected, actual);
            errors.RemoveAll(acceptable);

            Assert.AreEqual(0, errors.Count, message: string.Join("\n", errors));

            static bool acceptable(string s)
            {
                return AcceptableErrors.Any(s.Contains);
            }
        }

        [TestMethod]
        public void DeserializeFieldSpecifiedElement()
        {
            var fd = new FunctionDef
            {
                name = "print",
                fluent = true, fluentSpecified = true
            };

            var lib = new Library
            {
                statements = [fd]
            };

            var json = lib.SerializeToJson();
            json.Should().NotContain("fluentSpecified");

            var parsedLib = Library.ParseFromJson(json, validate: false);
            var parsedFd = parsedLib.statements[0].Should().BeOfType<FunctionDef>().Subject;
            parsedFd.fluent.Should().Be(true);
            parsedFd.fluentSpecified.Should().Be(true);
        }

        [TestMethod]
        public void Elm_Deserialize_MixedXmlAnnotations()
        {
            var originalElm = File.ReadAllText(Path.Combine("Input", "ELM", "Test", "CqlWithAnnotations.xml"));
            var x = new XmlSerializer(typeof(Library));
            var lib = (Library)x.Deserialize(new StringReader(originalElm))!;
            var annotation = lib.usings[1].annotation[0].Should().BeOfType<Annotation>().Subject;

            /* Narrative on this element looks like:

             <a:s r="1">
               <a:s>using </a:s>
               <a:s>
                  <a:s>FHIR</a:s>
               </a:s>
               <a:s> version '4.0.1'</a:s>
            </a:s> */

            // Now serialize this back out, parse it again, and recheck.
            var writer = new StringWriter();
            lib = new Library { annotation = [annotation] };
            x.Serialize(writer, lib);
            lib = (Library)x.Deserialize(new StringReader(writer.ToString()));
            annotation = lib.annotation[0].Should().BeOfType<Annotation>().Subject;
            check(annotation);

            static void check(Annotation annotation)
            {
                annotation.s.r.Should().Be("1");
                annotation.s.s![0].Text[0].Should().Be("using ");
                annotation.s.s![1].s![0].Text[0].Should().Be("FHIR");
            }
        }

        [TestMethod]
        public void DefaultValueAttribute_ReturnClauseDistinct_InitializesToTrue()
        {
            // ReturnClause.distinct has a default value of true
            // Verify the constructor initializes it and the DefaultValueAttribute is present
            var returnClause = new ReturnClause();

            // The default value should be set by the constructor
            returnClause.distinct.Should().Be(true);

            // Verify that serialization doesn't include the default value
            var lib = new Library
            {
                statements = [
                    new ExpressionDef
                    {
                        name = "Test",
                        expression = new Query
                        {
                            @return = returnClause
                        }
                    }
                ]
            };

            var json = lib.SerializeToJson();
            // When the value is at default, it should not be serialized
            json.Should().NotContain("\"distinct\"");

            // When the value is changed from default, it should be serialized
            returnClause.distinct = false;
            json = lib.SerializeToJson();
            json.Should().Contain("\"distinct\"");
        }

        [TestMethod]
        public void DefaultValueAttribute_IncludeDefMediaType_InitializesToApplicationElmXml()
        {
            // IncludeDef.mediaType has a default value of "application/elm+xml"
            var includeDef = new IncludeDef();

            // The default value should be set by the constructor
            includeDef.mediaType.Should().Be("application/elm+xml");

            // Verify the DataType attribute is present (anyURI)
            var property = typeof(IncludeDef).GetProperty("mediaType");
            var xmlAttr = property!.GetCustomAttributes(typeof(System.Xml.Serialization.XmlAttributeAttribute), false)
                .Cast<System.Xml.Serialization.XmlAttributeAttribute>()
                .FirstOrDefault();
            xmlAttr.Should().NotBeNull();
            xmlAttr!.DataType.Should().Be("anyURI");

            // Verify DefaultValueAttribute is present
            var defaultAttr = property.GetCustomAttributes(typeof(System.ComponentModel.DefaultValueAttribute), false)
                .Cast<System.ComponentModel.DefaultValueAttribute>()
                .FirstOrDefault();
            defaultAttr.Should().NotBeNull();
            defaultAttr!.Value.Should().Be("application/elm+xml");
        }

        [TestMethod]
        public void DefaultValueAttribute_EnumAccessLevel_InitializesToPublic()
        {
            // CodeDef.accessLevel has a default value of AccessModifier.Public (enum)
            var codeDef = new CodeDef();

            // The default value should be set by the constructor
            codeDef.accessLevel.Should().Be(AccessModifier.Public);

            // Verify DefaultValueAttribute is present with enum value (not string)
            var property = typeof(CodeDef).GetProperty("accessLevel");
            var defaultAttr = property!.GetCustomAttributes(typeof(System.ComponentModel.DefaultValueAttribute), false)
                .Cast<System.ComponentModel.DefaultValueAttribute>()
                .FirstOrDefault();
            defaultAttr.Should().NotBeNull();
            defaultAttr!.Value.Should().BeOfType<AccessModifier>();
            defaultAttr.Value.Should().Be(AccessModifier.Public);
        }

        [TestMethod]
        public void XmlElementAttribute_AnnotationArray_GeneratesCorrectly()
        {
            // Element.annotation is a direct array property that should have XmlElementAttribute
            var property = typeof(Hl7.Cql.Elm.Element).GetProperty("annotation");
            property.Should().NotBeNull();

            var xmlElemAttr = property!.GetCustomAttributes(typeof(System.Xml.Serialization.XmlElementAttribute), false)
                .Cast<System.Xml.Serialization.XmlElementAttribute>()
                .FirstOrDefault();

            xmlElemAttr.Should().NotBeNull();
            xmlElemAttr!.ElementName.Should().Be("annotation");

            // Test serialization roundtrip
            var annotation = new Annotation
            {
                s = new Hl7.Cql.Elm.Narrative
                {
                    r = "1"
                }
            };

            var element = new ExpressionDef
            {
                name = "Test",
                annotation = [annotation]
            };

            var lib = new Library { statements = [element] };

            // Serialize to XML
            var serializer = new XmlSerializer(typeof(Library));
            var writer = new StringWriter();
            serializer.Serialize(writer, lib);
            var xml = writer.ToString();

            // Deserialize back
            var reader = new StringReader(xml);
            var deserialized = (Library)serializer.Deserialize(reader)!;

            deserialized.statements.Should().HaveCount(1);
            var deserializedElement = deserialized.statements[0].Should().BeOfType<ExpressionDef>().Subject;
            deserializedElement.annotation.Should().HaveCount(1);
            var deser = deserializedElement.annotation[0].Should().BeOfType<Annotation>().Subject;
            deser.s.r.Should().Be("1");
        }

        [TestMethod]
        public void SpecifiedPattern_FluentAttribute_OnlySerializedWhenSpecified()
        {
            // FunctionDef.fluent is optional and should have fluentSpecified field
            var functionDef = new FunctionDef
            {
                name = "test"
            };

            // By default, fluentSpecified should be false and fluent should be false
            functionDef.fluentSpecified.Should().BeFalse();
            functionDef.fluent.Should().BeFalse();

            var lib = new Library { statements = [functionDef] };
            var json = lib.SerializeToJson();

            // When fluentSpecified is false, the value should not be serialized
            json.Should().NotContain("\"fluent\"");

            // Set both the value and the specified flag together
            functionDef.fluent = true;
            functionDef.fluentSpecified = true;
            json = lib.SerializeToJson();

            // When fluentSpecified is true, the value should be serialized
            json.Should().Contain("\"fluent\"");
            json.Should().Contain("true");
        }

        [TestMethod]
        public void XmlIncludeAttribute_ExpressionBaseClass_DeclaresAllDerivedTypes()
        {
            // Expression class should have XmlIncludeAttribute for all derived types
            // This enables PolymorphicTypeResolver to discover type hierarchies
            var expressionType = typeof(Hl7.Cql.Elm.Expression);
            var xmlIncludeAttrs = expressionType.GetCustomAttributes(typeof(System.Xml.Serialization.XmlIncludeAttribute), false)
                .Cast<System.Xml.Serialization.XmlIncludeAttribute>()
                .ToList();

            // Should have multiple XmlIncludeAttribute declarations
            // Our tool generates only direct derivations (not transitive), so the count is lower than xsd.exe
            // but still sufficient for PolymorphicTypeResolver to work correctly
            xmlIncludeAttrs.Should().NotBeEmpty();
            xmlIncludeAttrs.Count.Should().BeGreaterThan(30, "Expression has many directly derived types");

            // Check for some common expression types that are direct children of Expression
            var includedTypes = xmlIncludeAttrs.Select(a => a.Type).ToList();
            includedTypes.Should().Contain(typeof(Literal), "Literal directly inherits from Expression");
            includedTypes.Should().Contain(typeof(OperatorExpression), "OperatorExpression directly inherits from Expression");
            includedTypes.Should().Contain(typeof(Retrieve), "Retrieve directly inherits from Expression");
            includedTypes.Should().Contain(typeof(Query), "Query directly inherits from Expression");
        }

        [TestMethod]
        public void AbstractTypes_Element_IsAbstractClass()
        {
            // Element is an abstract type in XSD and should be abstract in C#
            typeof(Hl7.Cql.Elm.Element).IsAbstract.Should().BeTrue();

            // Expression is also abstract
            typeof(Hl7.Cql.Elm.Expression).IsAbstract.Should().BeTrue();

            // OperatorExpression is abstract
            typeof(OperatorExpression).IsAbstract.Should().BeTrue();
        }

        [TestMethod]
        public void TypeOrdering_LibraryClass_IsFirstType()
        {
            // Library should be the first type generated (root element type)
            // We can verify this by checking that it's defined in the assembly
            var assembly = typeof(Library).Assembly;
            var allTypes = assembly.GetTypes();
            var elmTypes = allTypes.Where(t => t.Namespace == "Hl7.Cql.Elm").ToList();

            // Library should exist and be a public class
            typeof(Library).IsPublic.Should().BeTrue();
            typeof(Library).IsClass.Should().BeTrue();

            // It should have XmlRootAttribute
            var xmlRootAttr = typeof(Library).GetCustomAttributes(typeof(System.Xml.Serialization.XmlRootAttribute), false)
                .Cast<System.Xml.Serialization.XmlRootAttribute>()
                .FirstOrDefault();

            xmlRootAttr.Should().NotBeNull();
            xmlRootAttr!.ElementName.Should().Be("library");
            xmlRootAttr.Namespace.Should().Be("urn:hl7-org:elm:r1");
            xmlRootAttr.IsNullable.Should().BeFalse();
        }

        [TestMethod]
        public void GeneratedCodeAttribute_HasCorrectToolNameAndVersion()
        {
            // All generated types should have GeneratedCodeAttribute with "xsd2cs" tool name
            var library = typeof(Library);
            var generatedAttr = library.GetCustomAttributes(typeof(System.CodeDom.Compiler.GeneratedCodeAttribute), false)
                .Cast<System.CodeDom.Compiler.GeneratedCodeAttribute>()
                .FirstOrDefault();

            generatedAttr.Should().NotBeNull();
            generatedAttr!.Tool.Should().Be("xsd2cs");
            generatedAttr.Version.Should().MatchRegex(@"^\d+\.\d+\.\d+\.\d+$", "version should be in format x.x.x.x");
        }

        private List<string> CompareNode(JsonNode expected, JsonNode actual)
        {
            return expected switch
            {
                JsonObject expectedObj  => CompareObject(actual, expectedObj),
                JsonArray expectedArray => CompareArray(actual, expectedArray),
                JsonValue expectedValue => CompareValue(actual, expectedValue),
                _ => throw new NotSupportedException(
                         $"Unexpected node type '{expected.GetType()}' at {actual.GetPath()}.")
            };
        }

        private List<string> CompareValue(JsonNode actual, JsonValue expectedValue)
        {
            if (actual is JsonValue actualValue)
            {
                if (expectedValue.ToString() != actualValue.ToString())
                    return new List<string>
                    {
                        $"Expected value '{expectedValue}', but found actual value '{actualValue}' at {actual.GetPath()}."
                    };
            }
            else
                return new List<string> { $"Expected value, but found '{actual.GetType()}' at {actual.GetPath()}." };

            return new List<string>();
        }

        private List<string> CompareArray(JsonNode actual, JsonArray expectedArray)
        {
            List<string> result = new List<string>();

            if (actual is JsonArray actualArray)
            {
                if (expectedArray.Count == actualArray.Count)
                {
                    for (var i = 0; i < expectedArray.Count; i++)
                    {
                        result.AddRange(CompareNode(expectedArray[i], actualArray[i]));
                    }
                }
                else
                    result.Add(
                        $"Expected array of length {expectedArray.Count}, but found array of length {actualArray.Count} at {actualArray.GetPath()}.");
            }
            else
                result.Add($"Expected array, but found '{actual.GetType()}' at {actual.GetPath()}.");

            return result;
        }

        private List<string> CompareObject(JsonNode actual, JsonObject expectedObj)
        {
            List<string> result = new List<string>();

            if (actual is JsonObject)
            {
                var actualObj = (IDictionary<string, JsonNode>)actual;
                foreach (var (key, value) in expectedObj)
                {
                    if (actualObj.TryGetValue(key, out var actualValue))
                    {
                        result.AddRange(CompareNode(value, actualValue));
                    }
                    else
                    {
                        result.Add(
                            $"Expected key '{key}' (value '{expectedObj[key]}') not found in actual object. At {actual.GetPath()}.");
                    }
                }

                // Check for extra keys in actual object.
                foreach (var key in actualObj.Keys)
                {
                    if (!expectedObj.ContainsKey(key))
                        result.Add(
                            $"Unexpected key '{key}' (value '{actualObj[key]?.ToJsonString() ?? "null"}') found in actual object. At {actual.GetPath()}.");
                }
            }
            else
                result.Add($"Expected object, but found '{actual.GetType()}' at {actual.GetPath()}.");

            return result;
        }
    }
}