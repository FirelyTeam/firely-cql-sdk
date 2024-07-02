using System;
using System.Collections.Generic;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using FluentAssertions;

namespace CoreTests
{
    [TestClass]
    public class ElmTests
    {
        [TestMethod]
        public void Elm_Deseriailze_TupleTypeSpecifier()
        {
            var json = @"
            {
                ""type"" : ""ChoiceTypeSpecifier"",
                ""choice"" : [ {
                  ""type"" : ""NamedTypeSpecifier"",
                  ""name"" : ""{http://hl7.org/fhir}CodeableConcept""  } ]                 
            }";

            var options = Library.BuildSerializerOptions(allowOldStyleTypeDiscriminators: true);
            var ts = JsonSerializer.Deserialize<ChoiceTypeSpecifier>(json, options);
            var cts = ts.Should().BeOfType<ChoiceTypeSpecifier>().Subject;
            cts.choice.Should().HaveCount(1);
        }

        [TestMethod]
        public void Elm_Deserialize_FhirHelpers()
        {
            var originalElm = File.ReadAllText(@"Input\ELM\Libs\FHIRHelpers-4.0.1.json");
            var lib = Library.ParseFromJson(originalElm);
            var elm = lib.SerializeToJson();

            // TODO: compare originalElm to elm.
            var expected = JsonNode.Parse(originalElm);
            var actual = JsonNode.Parse(elm);
            var result = CompareNode(expected, actual);

            Assert.AreEqual(0, result.Count, message: string.Join("\n", result));
        }

        private List<string> CompareNode(JsonNode expected, JsonNode actual)
        {
            return expected switch
            {
                JsonObject expectedObj => CompareObject(actual, expectedObj),
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
                            $"Unexpected key '{key}' (value '{actualObj[key].ToJsonString()}') found in actual object. At {actual.GetPath()}.");
                }
            }
            else
                result.Add($"Expected object, but found '{actual.GetType()}' at {actual.GetPath()}.");

            return result;
        }
    }
}