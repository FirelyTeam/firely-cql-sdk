using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreTests
{
    [TestClass]
    public class SpecTests
    {
        private static HashSet<string> Skip = new HashSet<string>(new[]
        {
            "DecimalMinValue", 
            "DecimalMaxValue",
            "Multiply1CMBy2CM",

            // This group of tests fails because they use two integers as operands to Pow and expect decimal results
            "Power2ToNeg2",
            "DecimalOneStep",
            "DecimalPosOneStep",
            "DecimalNegOneStep",
            "DecimalTwoStep",
            "DecimalPosTwoStep",
            "DecimalNegTwoStep",
            "DecimalTenStep",
            "DecimalPosTenStep",
            "DecimalNegTenStep",

            "Round0D5",
            "RoundNeg1D5",
            "EquivEqCM1M01",
            "QuantityNotEqCM1M01",
            "TruncatedDivide10d1ByNeg3D1Quantity",

            // these tests all return uncertainty intervals instead of integers per the spec
            "DateTimeDurationBetweenYear",
            "DateTimeDurationBetweenUncertainInterval",
            "DateTimeDurationBetweenUncertainInterval2",
            "DateTimeDurationBetweenUncertainAdd",
            "DateTimeDurationBetweenUncertainSubtract",
            "DateTimeDurationBetweenUncertainMultiply",
            "DateTimeDurationBetweenUncertainDiv",
            "DateTimeDurationBetweenMonthUncertain2",
            "DateTimeUncertain",

            "TestMeetsAfterNull",
            
            "SortDatesAsc",
            "SortDatesDesc",

            "Includes123AndEmpty",
            "IncludedInEmptyAnd123",
            "EquivalentABCAnd123",
            "Equivalent123AndABC",
            "Equivalent123AndString123",
            "NotEqualABCAnd123",
            "NotEqual123AndABC",
            "NotEqual123AndString123",
            "ProperIncludes123AndEmpty",
            "ProperIncludedInEmptyAnd123",
            "Union123AndEmpty",

            "ProperContainsNullRightFalse",
            "ProperContainsNullRightTrue",
            "ProperInNullRightFalse",
            "ProperInNullRightTrue",
            "ProperlyIncludesNullLeft",
            "ToDateTime4", // https://github.com/cqframework/clinical_quality_language/issues/1298
            "ToDateTime5"
        });


        [DynamicData(nameof(LoadSpecTests), DynamicDataSourceType.Method,
            DynamicDataDisplayName = nameof(DisplayName))]
        [TestMethod]
        public void SpecTest(string name, 
            LambdaExpression expressionLambda, 
            LambdaExpression outputLamda)
        {
            if (!Skip.Contains(name))
            {
                var ctx = FhirCqlContext.ForBundle(new Hl7.Fhir.Model.Bundle());
                var expressionDelegate = expressionLambda.Compile();
                var expressionValue = expressionDelegate.DynamicInvoke(ctx);

                var outputDelegate = outputLamda.Compile();
                var outputValue = outputDelegate.DynamicInvoke(ctx);

                if (outputValue is null)
                {
                    if (expressionValue is not null)
                    {
                        Assert.Fail($"Expected output: {outputValue}, actual: {expressionValue}");
                    }
                }
                else
                {
                    var result = ctx.Operators.Equal(expressionValue, outputValue);
                    if (result != true)
                    {
                        Assert.Fail($"Test {name} failed; expected {outputValue}, actual {expressionValue}");
                    }
                }
            }
        }



        public static string DisplayName(MethodInfo method, object[] data)
        {
            var name = data[0] as string;
            return name;
        }
        public static IEnumerable<object[]> LoadSpecTests()
        {
            ILogger<ExpressionBuilder> CreateLogger() => LoggerFactory
                .Create(logging => logging.AddDebug())
                .CreateLogger<ExpressionBuilder>();

            var xmlDir = new DirectoryInfo("Input\\ELM\\HL7");
            var files = xmlDir.GetFiles("*.json", SearchOption.TopDirectoryOnly);
            var resolver = new FhirTypeResolver(Hl7.Fhir.Model.ModelInfo.ModelInspector);
            var binding = new CqlOperatorsBinding(resolver,
                FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector),
                messageOnError: true);
            foreach (var file in files)
            {
                var library = Library.LoadFromJson(file);
                var typeManager = new TypeManager(resolver);
                var eb = ExpressionBuilder.ForSingleLibrary(binding, typeManager, library, CreateLogger());
                var lambdas = eb.Build();
                foreach (var lib in lambdas.Libraries)
                {
                    if (lambdas.TryGetDefinitionsForLibrary(lib, out var definitions))
                    {
                        var dict = definitions
                            .Where(kvp => kvp.Value.Count == 1)
                            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value[0]);
                        foreach (var kvp in dict)
                        {
                            var index = kvp.Key.IndexOf(" Input");
                            if (index > 0)
                            {
                                var name = kvp.Key.Substring(0, index);
                                var output = $"{name} Output";
                                if (dict.TryGetValue(output, out var outputLambda))
                                {
                                    yield return new object[] { name, kvp.Value.Item2, outputLambda.Item2 };
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

