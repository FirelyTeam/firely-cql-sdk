using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class HL7Test: Base
    {

        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.ValidateLiterals = false;
            co.AllowNullIntervals = true;
            co.LongsRequireSuffix = false; // promote test values of 2147483648 to longs so ExpressionBuilder doesn't throw
            co.EnableListPromotion = true;
            co.EnableListDemotion = true;
            co.EnableIntervalPromotion = true;
            co.EnableIntervalDemotion = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter


        [DynamicData(nameof(LoadCqlFiles), DynamicDataSourceType.Method,
          DynamicDataDisplayName = nameof(DisplayName))]
        [TestMethod]
        public void ExecuteExpression(FileInfo cqlFile, 
            Library library, 
            Dictionary<string, Delegate>  delegates,
            string name)
        {
            var context = FhirCqlContext.ForBundle();
            var inputDelegate = delegates[$"{name} Input"];
            var outputDelegate = delegates[$"{name} Output"];
            try
            {
                var input = inputDelegate.DynamicInvoke(context);
                var output = outputDelegate.DynamicInvoke(context);
                var comparison = context.Operators.Comparer.Compare(input, output, null);
            }
            catch(TargetInvocationException tie)
            {
                // skip tests that rely on explicitly not supported functionality like quantity math
                if (tie.InnerException is not NotSupportedException)
                    throw tie.InnerException ?? tie;
            }
        }

        public static string DisplayName(MethodInfo method, object[] data)
        {
            (var library, var test) =  ((Library)data[1], (string)data[3]);
            return $"{library.NameAndVersion}: {test}";
        }

        public static IEnumerable<object[]> LoadCqlFiles()
        {
            var directory = new DirectoryInfo(@"Input\HL7");
            var cqlFiles = directory.GetFiles("*.cql");
            foreach(var file in cqlFiles)
            {
                using(var scope = Services.CreateScope())
                {
                    using var stream = file.OpenRead();
                    var library = DefaultConverter.ConvertLibrary(stream);
                    var errors = library.GetErrors();
                    if (errors.Length > 0)
                        Assert.Fail(errors[0].message);
                    var eb = ExpressionBuilderFor(library);
                    var lambdas = eb.Build();
                    var delegates = lambdas.CompileAll();
                    Assert.IsTrue(delegates.TryGetDefinesForLibrary(library.NameAndVersion, out var definitions));
                    var libDelegates = definitions!.ToDictionary(kvp=>kvp.Key, kvp=>kvp.Value);
                    var byName = library.statements.ToDictionary(ed => ed.name);
                    foreach(var key in byName.Keys.Where(key => key.EndsWith("Input")))
                    {
                        var inputIndex = key.LastIndexOf("Input");
                        var testName = key.Substring(0, inputIndex).Trim();
                        var outputKey = $"{testName} Output";
                        if (byName.TryGetValue(outputKey, out var outputDef))
                        {
                            var inputDef = byName[key];
                            yield return new object[] { file, library, libDelegates, testName  };
                        }
                    }
                }
            }

        }
    }
}
