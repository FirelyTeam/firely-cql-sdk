using FluentAssertions;
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
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        private static CqlContext CqlContext = FhirCqlContext.ForBundle();

        [DynamicData(nameof(GetTests), DynamicDataSourceType.Method,
            DynamicDataDisplayName = nameof(DisplayName))]
        //[TestMethod]
        public void Run(TestCase testCase)
        {
            if (SkippedTests.Map.TryGetValue(testCase.TestName, out var reason))
                Assert.Inconclusive($"Case {testCase.Category}: {testCase.TestName} skipped: {reason}");
            var expressionErrors = testCase.Expression.GetErrors();
            if (expressionErrors.Any())
                Assert.Fail($"Case {testCase.Category}: {testCase.TestName} expression compiled with errors: {expressionErrors.First().message}");
            var expressionLambda = ExpressionBuilder.Lambda(testCase.Expression);
            var expressionDelegate = expressionLambda.Compile();
            var expression = expressionDelegate.DynamicInvoke(CqlContext);
            if (testCase.Expectation is not null)
            {
                var expectationErrors = testCase.Expectation.GetErrors();
                if (expectationErrors.Any())
                    Assert.Fail($"Case {testCase.Category}: {testCase.TestName} expectation compiled with errors: {expressionErrors.First().message}");
                var expectationLambda = ExpressionBuilder.Lambda(testCase.Expectation);
                var expectationDelegate = expectationLambda.Compile();
                var expectation = expectationDelegate.DynamicInvoke(CqlContext);
                var comparison = CqlContext.Operators.Comparer.Equals(expression, expectation, null);
                comparison.Should().BeTrue();
            }
            else
                Assert.Inconclusive($"Case {testCase.Category}: {testCase.TestName} is inconclusive; no expectation provided.");
        }

        public static string DisplayName(MethodInfo method, object[] data)
        {
            var tc = (TestCase)data[0];
            return $"{tc.Category}: {tc.TestName}";
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
                    foreach (var test in group.test)
                    {
                        if (!test.expression.invalidSpecified)
                        {
                            TestCase testCase;
                            try
                            {
                                var expression = Expression(test.expression.Value);
                                var expected = Expression(test.output.Single().Value);
                                testCase = new TestCase(group.name, test.name, expression, expected);
                            }
                            catch(Exception ie)
                            {
                                throw new InvalidOperationException($"Could not compile file {xml.FullName}.", ie);
                            }
                            yield return new object[] { testCase };

                        }
                    }
                }
            }
        }

        public record TestCase(string Category, string TestName, Elm.Expression Expression, Elm.Expression? Expectation);
    }
}
