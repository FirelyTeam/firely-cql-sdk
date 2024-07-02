using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class XmlTests : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.AllowNullIntervals = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        private static CqlContext CqlContext = FhirCqlContext.ForBundle();
        private static InvocationBuilder InvocationBuilder = Services.GetRequiredService<InvocationBuilder>();
        private static ElmFactory ElmFactory = Services.GetRequiredService<ElmFactory>();


        [DynamicData(nameof(GetTests), DynamicDataSourceType.Method,
            DynamicDataDisplayName = nameof(DisplayName))]
        [TestMethod]
        public void Run(TestCase testCase)
        {
            if (SkippedTests.DoesNotCompile.TryGetValue(testCase.TestName, out var reason))
                Assert.Inconclusive($"Case {testCase.Category}: {testCase.TestName} skipped: {reason}");
            var expression = Expression(testCase.Expression);
            var expressionErrors = expression.GetErrors();
            if (expressionErrors.Any())
                Assert.Fail($"Case {testCase.Category}: {testCase.TestName} expression compiled with errors: {expressionErrors.First().message}");
            if (testCase.Expectation is not null)
            {
                var expectation = Expression(testCase.Expectation);
                var expectationErrors = expectation.GetErrors();
                if (expectationErrors.Any())
                    Assert.Fail($"Case {testCase.Category}: {testCase.TestName} expectation compiled with errors: {expressionErrors.First().message}");
                if (SkippedTests.DoesNotMatchExpectation.TryGetValue(testCase.TestName, out var doesNotMatchReason))
                    Assert.Inconclusive($"Cannot evaluate case {testCase.Category}: {testCase.TestName}: {doesNotMatchReason}");
                Elm.Expression equal = Equals(expression, expectation);
                var equalLambda = LibraryExpressionBuilder.Lambda(equal);
                var equalDelegate = equalLambda.Compile();
                var equalResult = (bool?)equalDelegate.DynamicInvoke(CqlContext);
                if (equalResult != true)
                {
                    var expressionValue = LibraryExpressionBuilder.Lambda(expression).Compile().DynamicInvoke(CqlContext);
                    var expectationValue = LibraryExpressionBuilder.Lambda(expectation).Compile().DynamicInvoke(CqlContext);
                    Assert.Fail($"Expected {expectationValue}, but got {expressionValue}");
                }
            }
            else
                Assert.Inconclusive($"Case {testCase.Category}: {testCase.TestName} is inconclusive; no expectation provided.");
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

        private static XmlSerializer Serializer = new(typeof(Xml.Tests));
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
