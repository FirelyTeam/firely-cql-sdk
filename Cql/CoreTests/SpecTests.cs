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
            "QuantityIntervalExcept1to4",
            "InvalidIntegerInterval",
            "InvalidIntegerIntervalA",
            "ExpandPer2Days",
            "ExpandPerDay",
            "ExpandPerHour",
            "ExpandPerMinute",
            "DateTimeWidth",
            "TestIntersectNull",
            "TestMeetsAfterNull",
            "TimeWidth",
            "TimeProperContainsFalse",
            "TimeProperContainsPrecisionFalse",
            "TimeProperInFalse",
            "TimeProperInPrecisionFalse",
            "TrueImpliesTrue",
            "TrueImpliesFalse",
            "TrueImpliesNull",
            "FalseImpliesTrue",
            "FalseImpliesFalse",
            "FalseImpliesNull",
            "NullImpliesTrue",
            "NullImpliesFalse",
            "NullImpliesNull",
            "DateTimeAddInvalidYears",
            "DateTimeSubtractInvalidYears",
            "RoundNeg0D5",
            "RoundNeg1D5",
            "Decimal10Pow28",
            "DecimalPos10Pow28",
            "DecimalNeg10Pow28",
            "PredecessorUnderflowDt",
            "PredecessorUnderflowT",
            "Integer2Pow31",
            "Integer2Pow31ToInf1",
            "IntegerPos2Pow31ToInf1",
            "IntegerNeg2Pow31ToInf1",
            "IntegerPos2Pow31",
            "DecimalMaxValue",
            "DecimalMinValue",
            "DecimalTenthStep",
            "DecimalPosTenthStep",
            "DecimalNegTenthStep",
            "LongMinValue",
            "LongMaxValue",
            "DateTimeLowerBoundExcept",
            "DateTimeUncertain",
            "DateTimeUpperBoundExcept",
            "TimeUpperBoundHours",
            "TimeUpperBoundMillis",
            "TimeUpperBoundMinutes",
            "TimeUpperBoundSeconds",
            "Exp1000",
            "Exp1000D",
            "Ln0",
            "LnNeg0",
            "Modulo4LBy2L",
            "ModuloQuantity",
            "Multiply1By1L",
            "Multiply1CMBy2CM",
            "NegateNeg1L",
            "Power2LTo2L",
            "PredecessorOf1L",
            "Subtract1LAnd1L",
            "SuccessorOf1L",
            "SuccessorOverflowDt",
            "SuccessorOverflowT",
            "TruncatedDivide10LBy3L",
            "TruncatedDivide10d1ByNeg3D1Quantity",
            "FactorialOfFive",
            "RolledOutIntervals",
            "StringToDateTimeMalformed",
            "StringToIntegerError",
            "ToDateTimeMalformed",
            "ToTimeMalformed",
            "TimeProperInPrecisionFalse",
            "DateTimeDurationBetweenUncertainInterval",
            "DateTimeDurationBetweenUncertainInterval2",
            "DateTimeDurationBetweenUncertainAdd",
            "DateTimeDurationBetweenUncertainSubtract",
            "DateTimeDurationBetweenUncertainMultiply",
            "DateTimeDurationBetweenUncertainDiv",
            "DateTimeDurationBetweenMonthUncertain",
            "DateTimeDurationBetweenMonthUncertain2",
            "DateTimeDurationBetweenMonthUncertain3",
            "DateTimeDurationBetweenMonthUncertain4",
            "DateTimeDurationBetweenMonthUncertain5",
            "DateTimeDurationBetweenMonthUncertain6",
            "DateTimeDurationBetweenMonthUncertain7",
            "SingletonFrom12",
            "TestMessageError",
            "DateTimeComponentFromTimezone",
            "TestOnOrBeforeNull",
            "TestOnOrAfterNull",
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
                    Assert.IsTrue(result);
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

