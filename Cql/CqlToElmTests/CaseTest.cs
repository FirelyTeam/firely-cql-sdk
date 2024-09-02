using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class CaseTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        private Library createLibraryForExpression(string expression)
        {
            return MakeLibrary($@"
                library CaseTest version '1.0.0'

                define private predicate: {expression}");
        }

        [TestMethod]
        public void Case_Standard()
        {
            var library = createLibraryForExpression(@"
	            case
					when 5 > 10 then 5 + 10
					when 5 = 10 then 10
					else 10 - 5
				end
            ");
            var @case = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Case>();
            @case.caseItem.Should().NotBeNull();
            @case.caseItem.Should().HaveCount(2);

            @case.caseItem[0].resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
            @case.caseItem[0].when.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);

            @case.caseItem[1].resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
            @case.caseItem[1].when.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);

            @case.@else.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);

            AssertResult(@case, 5);
        }

        [TestMethod]
        public void Case_ChoiceTypes()
        {
            var library = createLibraryForExpression(@"
	            case
					when true then 'string'
					when false then 10
                    when null then null
					else Interval[3.0,5.0]
				end
            ");
            var @case = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Case>();
            @case.caseItem.Should().NotBeNull();
            @case.caseItem.Should().HaveCount(3);

            var choiceType = new ChoiceTypeSpecifier
            {
                choice = new TypeSpecifier[]
                {
                    SystemTypes.StringType,
                    SystemTypes.IntegerType,
                    new IntervalTypeSpecifier
                    {
                        pointType = SystemTypes.DecimalType
                    }
                }
            };

            @case.caseItem[0].resultTypeSpecifier.Should().Be(choiceType);
            @case.caseItem[0].when.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);

            @case.caseItem[1].then.resultTypeSpecifier.Should().Be(choiceType);
            @case.caseItem[1].resultTypeSpecifier.Should().Be(choiceType);
            @case.caseItem[1].when.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);

            @case.caseItem[2].then.resultTypeSpecifier.Should().Be(choiceType);
            @case.caseItem[2].resultTypeSpecifier.Should().Be(choiceType);
            @case.caseItem[2].when.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);

            @case.@else.resultTypeSpecifier.Should().Be(choiceType);

        }

    }
}
