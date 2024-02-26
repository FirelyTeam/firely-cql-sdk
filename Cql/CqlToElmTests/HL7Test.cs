using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Serialization;
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

        internal static InvocationBuilder InvocationBuilder => Services.GetRequiredService<InvocationBuilder>();

        [DynamicData(nameof(LoadCqlFiles), DynamicDataSourceType.Method,
          DynamicDataDisplayName = nameof(DisplayName))]
        [TestMethod]
        public void ExecuteExpression(FileInfo cqlFile, 
            Library library, 
            string name,
            Func<CqlContext, bool?> equalsDef)
        {
            var context = FhirCqlContext.ForBundle();
            try
            {
                // All inputs & outputs should be Equal
                var result = equalsDef(context);
                Assert.IsTrue(result);
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
            (var library, var test) =  ((Library)data[1], (string)data[2]);
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
                    
                    // Esnure all inputs & outputs are able to be built
                    var eb = ExpressionBuilderFor(library);
                    var lambdas = eb.Build();

                    var byName = library.statements.ToDictionary(ed => ed.name);
                    foreach (var key in byName.Keys.Where(key => key.EndsWith("Input")))
                    {
                        var inputIndex = key.LastIndexOf("Input");
                        var testName = key.Substring(0, inputIndex).Trim();
                        var outputKey = $"{testName} Output";
                        if (byName.TryGetValue(outputKey, out var outputDef))
                        {
                            var inputDef = byName[key];

                            var eqr = InvocationBuilder.SelectBestOverload(SystemLibrary.Equal, new[] { inputDef.expression, outputDef.expression });
                            Assert.IsTrue(eqr.Compatible);
                            var invokeEquals = InvocationBuilder.Invoke(eqr);
                            var equalsLambda = ExpressionBuilder.Lambda(invokeEquals);
                            var @delegate = equalsLambda.Compile() as Func<CqlContext, bool?>;
                            @delegate.Should().NotBeNull();
                            yield return new object[] { file, library, testName, @delegate! };
                        }
                    }
                }
            }
        }
    }
}
