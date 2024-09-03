using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class XmlTest : Base
    {
        private static XmlSerializer Serializer = new(typeof(Xml.Tests));
        private static readonly DateTimeOffset NowValue = new(2020, 1, 2, 3, 4, 0, TimeSpan.Zero);

        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.AllowNullIntervals = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        private static CqlContext CqlContext = FhirCqlContext.ForBundle(now: NowValue);
        private static InvocationBuilder InvocationBuilder = CqlToElmServices.InvocationBuilder;
        private static ElmFactory ElmFactory = CqlToElmServices.ElmFactory;


        [DynamicData(nameof(GetTests), DynamicDataSourceType.Method, DynamicDataDisplayName = nameof(DisplayName))]
        [TestMethod]
        public void Run(TestCase testCase)
        {
            string testFullName = $"{testCase.Category}: {testCase.TestName}";

            if (SkippedTests.DoesNotCompile.TryGetValue(testCase.TestName, out var reason))
                Assert.Inconclusive($"Case {testFullName} skipped: {reason}");

            // If you want to test a particular case, you can uncomment the following lines
            // if (testCase.TestName != "AgeInYearsAt")
            //     Assert.Inconclusive("Skipped!");

            var expression = Expression(testCase.Expression);
            var expressionErrors = expression.GetErrors();
            if (expressionErrors.Any())
            {
                Assert.Fail($"Case {testFullName} expression compiled with errors: {expressionErrors.First().message}");
                return;
            }

            if (testCase.Expectation is null)
            {
                Assert.Inconclusive($"Case {testFullName} is inconclusive; no expectation provided.");
                return;
            }

            var expectation = Expression(testCase.Expectation);
            var expectationErrors = expectation.GetErrors();
            if (expectationErrors.Any())
            {
                Assert.Fail($"Case {testFullName} expectation compiled with errors: {expressionErrors.First().message}");
                return;
            }

            if (SkippedTests.DoesNotMatchExpectation.TryGetValue(testCase.TestName, out var doesNotMatchReason))
            {
                Assert.Inconclusive($"Cannot evaluate case {testFullName}: {testCase.TestName}: {doesNotMatchReason}");
                return;
            }

            Elm.Expression equal = Equals(expression, expectation);
            var equalLambda = LibraryExpressionBuilder.Lambda(equal);
            var equalDelegate = equalLambda.Compile();
            var equalResult = (bool?)equalDelegate.DynamicInvoke(CqlContext);
            if (equalResult != true)
            {
                var expressionValue = LibraryExpressionBuilder.Lambda(expression).Compile().DynamicInvoke(CqlContext);
                var expectationValue = LibraryExpressionBuilder.Lambda(expectation).Compile().DynamicInvoke(CqlContext);
                Assert.Fail($"Case {testFullName} assertion failed. Expected '{expectationValue}', but got '{expressionValue}'.");
            }
        }

        private static Elm.Expression Equals(Elm.Expression expression, Elm.Expression expectation)
        {
            var equal = InvocationBuilder.Invoke(SystemLibrary.Equal, expression, expectation);
            var @if = new If
            {
                condition = new And
                {
                    operand = new[]
                    {
                        new IsNull { operand = expression }.WithResultType(SystemTypes.BooleanType),
                        new IsNull { operand = expectation }.WithResultType(SystemTypes.BooleanType),
                    }
                }.WithResultType(SystemTypes.BooleanType),
                then = ElmFactory.Literal(true),
                @else = equal,
            }.WithResultType(SystemTypes.BooleanType);
            return @if;
        }

        public static string DisplayName(MethodInfo method, object[] data)
        {
            var tc = (TestCase)data[0];
            return $"{tc.File}: {tc.Category}/{tc.TestName}";
        }

        public static IEnumerable<object[]> GetTests()
        {
            var dir = new DirectoryInfo(@"Input\DQIC");
            foreach (var xml in dir.GetFiles("*.xml"))
            {
                using var file = xml.OpenRead();
                var tests = (Xml.Tests)Serializer.Deserialize(file)!;
                foreach (var group in tests.group)
                {
                    if (group.test is not null)
                        foreach (var test in group.test)
                        {
                            if (!test.expression.invalidSpecified)
                            {
                                yield return new object[] { new TestCase(xml.Name, group.name, test.name, test.expression.Value, test.output?.Single()?.Value) };
                            }
                        }
                }
            }
        }

        public record TestCase(string File, string Category, string TestName, string Expression, string? Expectation);
    }
}
