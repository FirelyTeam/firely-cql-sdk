using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class IfThenElseTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        private Library createLibraryForExpression(string expression, string? expectedError = null)
        {
            return MakeLibrary($@"
                library IsTest version '1.0.0'

                define private predicate: {expression}", expectedError);
        }

        [TestMethod]
        public void True_Integer_Integer()
        {
            var library = createLibraryForExpression("if true then 4 else 5");
            var ifThenElse = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();

            ifThenElse.condition.Should().BeLiteralBool(true);
            ifThenElse.then.Should().BeLiteralInteger(4);
            ifThenElse.@else.Should().BeLiteralInteger(5);

            AssertResult(ifThenElse, 4);
        }

        [TestMethod]
        public void True_Integer_Decimal()
        {
            var library = createLibraryForExpression("if true then 4 else 5.0");
            var ifThenElse = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();

            ifThenElse.condition.Should().BeLiteralBool(true);
            var castLeft = ifThenElse.then.Should().BeOfType<ToDecimal>().Subject;
            castLeft.operand.Should().BeLiteralInteger(4);
            ifThenElse.@else.Should().BeLiteralDecimal(5.0m);
            ifThenElse.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType);

            AssertResult(ifThenElse, 4.0m);
        }

        [TestMethod]
        public void True_Decimal_Integer()
        {
            var library = createLibraryForExpression("if false then 4.0 else 5");
            var ifThenElse = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();

            ifThenElse.condition.Should().BeLiteralBool(false);
            var castRight = ifThenElse.@else.Should().BeOfType<ToDecimal>().Subject;
            castRight.operand.Should().BeLiteralInteger(5);
            ifThenElse.then.Should().BeLiteralDecimal(4.0m);
            ifThenElse.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType);

            AssertResult(ifThenElse, 5.0m);
        }

        [TestMethod]
        public void True_Decimal_String()
        {
            var library = createLibraryForExpression("if false then 4.0 else 'hello'");
            var ifThenElse = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            var expectedType = new ChoiceTypeSpecifier(SystemTypes.DecimalType, SystemTypes.StringType);

            ifThenElse.condition.Should().BeLiteralBool(false);

            var castLeft = ifThenElse.then.Should().BeOfType<As>().Subject;
            castLeft.operand.Should().BeLiteralDecimal(4.0m);
            castLeft.resultTypeSpecifier.Should().Be(expectedType);

            var castRight = ifThenElse.@else.Should().BeOfType<As>().Subject;
            castRight.operand.Should().BeLiteralString("hello");
            castRight.resultTypeSpecifier.Should().Be(expectedType);

            ifThenElse.resultTypeSpecifier.Should().Be(expectedType);

            AssertResult(ifThenElse, "hello");
        }

        [TestMethod]
        public void String_Integer_Integer()
        {
            var library = createLibraryForExpression("if 'hello' then 4 else 5",
                expectedError: "The condition is of type {urn:hl7-org:elm-types:r1}String, which cannot implicitly be cast to type {urn:hl7-org:elm-types:r1}Boolean");

            var @if = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
        }
    }
}
