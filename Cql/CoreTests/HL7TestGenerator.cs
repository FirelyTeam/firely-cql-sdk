using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreTests
{
    [TestClass]
    public class HL7TestGenerator
    {
        [TestMethod]
        public void Generate_HL7_Cql()
        {
            var hl7TestDirectory = new DirectoryInfo(@"Input\Xml");
            var xmlDeserializer = new XmlSerializer(typeof(TestSchema.Tests));
            var outPath = new DirectoryInfo(@"C:\Code\Ncqa.HT\Hedis2023\Cql\input\test");
            if (outPath.Exists == false)
                outPath.Create();
            var skiplist = File.ReadAllLines(@"Input\Xml\skiplist.txt");
            foreach (var file in hl7TestDirectory.GetFiles("*.xml"))
            {
                using var fs = file.OpenRead();
                var tests = (TestSchema.Tests)xmlDeserializer.Deserialize(fs);
                var cql = new StringBuilder();
                cql.AppendLine($"library {tests.name}");
                cql.AppendLine();
                cql.AppendLine($"context Unfiltered");
                cql.AppendLine();
                var writeFile = false;
                if (tests.group != null && tests.group.Length > 0)
                {
                    foreach (var group in tests.group)
                    {
                        if (group.name != "Collapse" && group.test != null && group.test.Length > 0)
                        {
                            foreach (var test in group.test.Where(t=> !skiplist.Contains(t.name)))
                            {
                                if (!string.IsNullOrWhiteSpace(test.expression?.Value))
                                {
                                    WriteTestToStringBuilder(cql, test);
                                    writeFile = true;
                                }
                            }
                        }
                    }
                }
                if (writeFile)
                    File.WriteAllText(Path.Combine(outPath.FullName, $"{tests.name}.cql"), cql.ToString());
            }
        }

        private static void WriteTestToStringBuilder(StringBuilder cql, TestSchema.Test test)
        {
            if (test.expression.invalid == TestSchema.InvalidType.@true)
            {
                cql.AppendLine();
                if (!test.expression.Value.StartsWith("define"))
                {
                    cql.AppendLine($"define \"{test.name}\":");
                    cql.AppendLine($"\t{test.expression.Value}");
                }
                else
                    cql.AppendLine($"{test.expression.Value}");
            }
            else if (test.output?.Length == 1)
            {
                cql.AppendLine();
                if (!test.expression.Value.StartsWith("define"))
                {
                    cql.AppendLine($"define \"{test.name} Input\":");
                    cql.AppendLine($"\t{test.expression.Value}");
                    cql.AppendLine($"define \"{test.name} Output\":");
                    cql.AppendLine($"\t{test.output[0].Value}");
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Skipping test {test.name}");
            }

        }

        private void Generate_Hl7_UnitTests()
        {
            var skiplist = File.ReadAllLines(@"Input\Xml\skiplist.txt");

            var hl7TestDirectory = new DirectoryInfo(@"Input\Xml");
            var xmlDeserializer = new XmlSerializer(typeof(TestSchema.Tests));
            var outPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent;

            foreach (var file in hl7TestDirectory.GetFiles("*.xml"))
            {
                using var fs = file.OpenRead();
                var tests = (TestSchema.Tests)xmlDeserializer.Deserialize(fs);
                var csharp = new StringBuilder();
                csharp.AppendLine(@"
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {");
                var writeFile = false;
                if (tests.group != null && tests.group.Length > 0)
                {
                    foreach (var group in tests.group)
                    {
                        if (group.test != null && group.test.Length > 0)
                        {
                            foreach (var test in group.test)
                            {
                                var sb = new StringBuilder();
                                WriteTestToStringBuilder(sb, test);
                                var lines = sb.ToString().Split('\n', '\r');
                                var commentSb = new StringBuilder();
                                foreach (var line in lines)
                                {
                                    if (!string.IsNullOrWhiteSpace(line))
                                    {
                                        var withComment = $"\t\t///{line}";
                                        commentSb.AppendLine(withComment);
                                    }
                                }
                                if (!string.IsNullOrWhiteSpace(test.expression?.Value) && test.output != null)
                                {
                                    var output = test.output.Single();
                                    writeFile = true;
                                    csharp.AppendLine($@"
        /// <summaray>");
                                    csharp.Append(commentSb);
                                    csharp.Append("\t\t");
                                    csharp.Append(@"/// </summary>");
                                    if (skiplist.Contains(test.name))
                                    {
                                        csharp.Append(@"
        [Ignore(NotTestedByReferenceEngine)]");
                                    }

                                    csharp.Append($@"
        [TestCategory(""{tests.name}"")]
        [TestMethod]
        public void {test.name}_Test()
        {{

            var result = Definitions.Invoke<bool?>(""{tests.name}"", ""{test.name}"", Context);
            Assert.AreEqual({(output.Value.StartsWith("null") ? "null" : "true")}, result);
        }}
                                        ");
                                }
                            }
                        }
                    }
                }

                csharp.AppendLine(@"
    }
}
                ");
                if (writeFile)
                    File.WriteAllText(Path.Combine(outPath.FullName, $"HL7Tests.{tests.name}.cs"), csharp.ToString());
            }
        }
    }
}
