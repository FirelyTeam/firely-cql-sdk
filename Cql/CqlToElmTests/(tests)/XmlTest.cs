using Hl7.Cql.Comparers;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Test
{
    using Expression = Hl7.Cql.Elm.Expression;

    [TestClass]
    public class XmlTest : Base
    {
        static XmlTest()
        {
            CqlContext = FhirCqlContext.ForBundle(now: NowValue);

            var cqlComparers = (CqlComparers)CqlContext.Operators.Comparer;
            cqlComparers.Register(typeof(TupleBaseType), new LegacyTupleBaseTypeComparer(cqlComparers));
        }

        private static readonly XmlSerializer Serializer = new(typeof(Xml.Tests));
        private static readonly DateTimeOffset NowValue = new(2020, 1, 2, 3, 4, 0, TimeSpan.Zero);
        private static readonly CqlContext CqlContext;

        private static void WriteLineToFile(string path, string line)
        {
            //File.AppendAllLines(path, [line]);
        }


        [DynamicData(nameof(GetTests), DynamicDataSourceType.Method, DynamicDataDisplayName = nameof(DisplayName))]
        [TestMethod]
        public void Run(TestCase testCase)
        {
            string testFullName = $"{testCase.Category}: {testCase.TestName}";

            if (SkippedTests.DoesNotCompile.TryGetValue(testCase.TestName, out var reason))
                Assert.Inconclusive($"Case {testFullName} skipped: {reason}");

            var cqlToolkit = CreateCqlToolkit(AllowNullIntervals:true, EnableIntervalPromotion: true);
            var expression = cqlToolkit.Expression(testCase.Expression);
            var expressionErrors = expression.GetErrors();
            if (expressionErrors.Any())
            {
                var joinedExpressionMessages = string.Join("; ", expressionErrors.Select(e=>e.message));
                WriteLineToFile(
                    """c:\temp\XmlTest.does-not-compile.txt""",
                    $$"""{ "{{testCase.TestName}}", "{{joinedExpressionMessages}}" },"""
                );
                Assert.Fail($"Case {testFullName} expression compiled with errors: {joinedExpressionMessages}");
                return;
            }

            if (testCase.Expectation is null)
            {
                WriteLineToFile(
                    """c:\temp\XmlTest.missing-expectation.txt""",
                    $$"""{ "{{testCase.TestName}}", "Missing expectation" },"""
                );
                Assert.Inconclusive($"Case {testFullName} is inconclusive; no expectation provided");
                return;
            }

            var expectation = cqlToolkit.Expression(testCase.Expectation);
            var expectationErrors = expectation.GetErrors();
            if (expectationErrors.Any())
            {
                var joinedMessages = string.Join("; ", expectationErrors.Select(e=>e.message));
                WriteLineToFile(
                    """c:\temp\XmlTest.expectation-did-not-compile.txt""",
                    $$"""{ "{{testCase.TestName}}", "{{joinedMessages}}" },"""
                );
                Assert.Fail($"Case {testFullName} expectation compiled with errors: {joinedMessages}");
                return;
            }

            if (SkippedTests.DoesNotMatchExpectation.TryGetValue(testCase.TestName, out var doesNotMatchReason))
            {
                WriteLineToFile(
                    """c:\temp\XmlTest.expectation-did-not-match.txt""",
                    $$"""{ "{{testCase.TestName}}", "{{doesNotMatchReason}}" },"""
                );
                Assert.Inconclusive($"Cannot evaluate case {testFullName}: {testCase.TestName}: {doesNotMatchReason}");
                return;
            }

            Expression equal = Equals(expression, expectation);
            var equalLambda = CreateElmToolkit().Lambda(equal);

            var equalDelegate = equalLambda.Compile();
            // TODO: These needs to be changed to run through the AssemblyCompiler too
            var equalResult = (bool?)equalDelegate.DynamicInvoke(CqlContext);
            if (equalResult != true)
            {
                var expressionValue = CreateElmToolkit().Lambda(expression).Compile().DynamicInvoke(CqlContext);
                var expectationValue = CreateElmToolkit().Lambda(expectation).Compile().DynamicInvoke(CqlContext);
                WriteLineToFile(
                    """c:\temp\XmlTest.assertion-failed.txt""",
                    $$"""{ "{{testCase.TestName}}", "actual: {{expressionValue}} does not meet expectation: {{expectationValue}}"""
                );
                Assert.Fail($"Case {testFullName} assertion failed. Expected '{expectationValue}', but got '{expressionValue}'");
            }
        }

        private static Expression Equals(Expression expression, Expression expectation)
        {
            var fluentCqlToolkit = CreateCqlToolkit();
            var invocationBuilder = fluentCqlToolkit.GetInvocationBuilder();
            var elmFactory = fluentCqlToolkit.GetElmFactory();
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
            var dir = new DirectoryInfo(Path.Combine("Input", "DQIC"));
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

    /// <summary>
    /// Legacy tuple comparer, only needed when invoking definitions directly.
    /// When generating C#, different value tuples are generated
    /// </summary>
    file class LegacyTupleBaseTypeComparer(CqlComparers memberComparer) :
        CqlComparer<TupleBaseType?>(
            CqlComparerEqualsImplementation.Compare,
            CqlComparerEquivalentImplementation.Compare)
    {

        protected override int? CompareValues(
            TupleBaseType x,
            TupleBaseType y,
            string? precision)
        {
            var xType = x.GetType();
            var yType = y.GetType();
            if (xType != yType)
                return null;

            var joined = from xProp in xType.GetProperties()
                         join yProp in yType.GetProperties() on xProp equals yProp into g
                         from foundY in g.DefaultIfEmpty()
                         select new
                         {
                             Property = xProp,
                             XValue = xProp.GetValue(x),
                             YValue = foundY == null ? null : foundY.GetValue(y)
                         };

            foreach (var prop in joined)
            {
                var compare = memberComparer.Compare(prop.XValue, prop.YValue, precision);
                if (compare is null or not 0)
                    return compare;
            }

            return 0;
        }
    }
}