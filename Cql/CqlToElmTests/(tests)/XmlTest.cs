using CqlSdkPrototype.Cql;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using CqlSdkPrototype.Cql.Internal;

namespace Hl7.Cql.CqlToElm.Test
{
    using Expression = Hl7.Cql.Elm.Expression;

    [TestClass]
    public class XmlTest : Base
    {
        private static readonly XmlSerializer Serializer = new(typeof(Xml.Tests));
        private static readonly DateTimeOffset NowValue = new(2020, 1, 2, 3, 4, 0, TimeSpan.Zero);
        private static readonly CqlContext CqlContext = FhirCqlContext.ForBundle(now: NowValue);


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

            var cqlApi = CreateCqlApi(AllowNullIntervals:true);
            var expression = cqlApi.Expression(testCase.Expression);
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

            var expectation = cqlApi.Expression(testCase.Expectation);
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

            Expression equal = Equals(expression, expectation);
            var equalLambda = CreateElmApi().Lambda(equal);

            var equalDelegate = equalLambda.Compile();
            // TODO: These needs to be changed to run through the AssemblyCompiler too
            var equalResult = (bool?)equalDelegate.DynamicInvoke(CqlContext);
            if (equalResult != true)
            {
                var expressionValue = CreateElmApi().Lambda(expression).Compile().DynamicInvoke(CqlContext);
                var expectationValue = CreateElmApi().Lambda(expectation).Compile().DynamicInvoke(CqlContext);
                Assert.Fail($"Case {testFullName} assertion failed. Expected '{expectationValue}', but got '{expressionValue}'.");
            }
        }

        private static Expression Equals(Expression expression, Expression expectation)
        {
            var cqlApi = CreateCqlApi();
            var invocationBuilder = cqlApi.GetInvocationBuilder();
            var elmFactory = cqlApi.GetElmFactory();
            var equal = invocationBuilder.Invoke(SystemLibrary.Equal, expression, expectation);
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
                then = elmFactory.Literal(true),
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
