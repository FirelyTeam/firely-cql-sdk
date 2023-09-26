using FluentAssertions;
using FluentAssertions.Primitives;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    public static class FluentTestExtensions
    {
        public static T BeACorrectlyInitializedLibraryWithStatementOfType<T>(this ObjectAssertions l)
        {
            var library = l.Subject.Should().BeOfType<Library>().Subject;
            library.statements.Should().HaveCount(1);
            library.statements[0].expression.localId.Should().NotBeNull();
            library.statements[0].expression.locator.Should().NotBeNull();

            return library.statements[0].expression.Should().BeOfType<T>().Subject;
        }


        public static void BeLiteralString(this ObjectAssertions l, string value)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(value);
            literal.resultTypeName.Should().BeEquivalentTo(new System.Xml.XmlQualifiedName("{urn:hl7-org:elm-types:r1}String"));
        }

        public static void BeLiteralBool(this ObjectAssertions l, bool b)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(b.ToString().ToLower());
            literal.resultTypeName.Should().BeEquivalentTo(new System.Xml.XmlQualifiedName("{urn:hl7-org:elm-types:r1}Boolean"));
        }

        public static void BeNullLiteral(this ObjectAssertions l)
        {
            var literal = l.Subject.Should().BeOfType<Null>().Subject;
            literal.resultTypeName.Should().BeEquivalentTo(new System.Xml.XmlQualifiedName("{urn:hl7-org:elm-types:r1}Any"));
        }
    }

    [TestClass]
    public class BooleanTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        private Library createLibraryForExpression(string expression)
        {
            return DefaultConverter.ConvertLibrary($@"
                library IsTest version '1.0.0'

                define private predicate: {expression}");
        }

        [TestMethod]
        public void True_Is_True()
        {
            var library = createLibraryForExpression("true is true");
            var isTrue = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsTrue>();
            isTrue.operand.Should().BeLiteralBool(true);
            AssertResult(isTrue, true);
        }

        [TestMethod]
        public void True_Is_False()
        {
            var library = createLibraryForExpression("true is false");
            var isFalse = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsFalse>();
            isFalse.operand.Should().BeLiteralBool(true);
            AssertResult(isFalse, false);
        }

        [TestMethod]
        public void True_Is_Null()
        {
            var library = createLibraryForExpression("true is null");
            var isNull = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsNull>();
            isNull.operand.Should().BeLiteralBool(true);
            AssertResult(isNull, false);
        }

        [TestMethod]
        public void Null_Is_True()
        {
            var library = createLibraryForExpression("null is true");
            var isTrue = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsTrue>();
            var @as = isTrue.operand.Should().BeOfType<As>().Subject;
            @as.operand.Should().BeNullLiteral();
            AssertResult(isTrue, false);
        }

        [TestMethod]
        public void Null_Is_Null()
        {
            var library = createLibraryForExpression("null is null");
            var isNull = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsNull>();
            isNull.operand.Should().BeNullLiteral();
            AssertResult(isNull, true);
        }

        [TestMethod]
        public void True_Is_Not_False()
        {
            var library = createLibraryForExpression("true is not false");
            var isNot = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Not>();
            var isFalse = isNot.operand.Should().BeOfType<IsFalse>().Subject;
            isFalse.operand.Should().BeLiteralBool(true);
            AssertResult(isNot, true);
        }

        [TestMethod]
        public void True_Is_Not_Null()
        {
            var library = createLibraryForExpression("true is not null");
            var isNot = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Not>();
            var isNull = isNot.operand.Should().BeOfType<IsNull>().Subject;
            isNull.operand.Should().BeLiteralBool(true);
            AssertResult(isNot, true);
        }

        [TestMethod]
        public void Null_Is_Not_Null()
        {
            var library = createLibraryForExpression("null is not null");
            var isNot = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Not>();
            var isNull = isNot.operand.Should().BeOfType<IsNull>().Subject;
            isNull.operand.Should().BeNullLiteral();
            AssertResult(isNot, false);
        }

        [TestMethod]
        public void Null_Is_Not_False()
        {
            var library = createLibraryForExpression("null is not false");
            var isNot = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Not>();
            var isFalse = isNot.operand.Should().BeOfType<IsFalse>().Subject;
            var @as = isFalse.operand.Should().BeOfType<As>().Subject;
            @as.operand.Should().BeNullLiteral();
            AssertResult(isNot, true);
        }

        [TestMethod]
        public void TrueList_Is_True()
        {
            var library = createLibraryForExpression("{true} is true");
            var isTrue = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsTrue>();
            var singleton = isTrue.operand.Should().BeOfType<SingletonFrom>().Subject;
            singleton.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);
            var list = singleton.operand.Should().BeOfType<List>().Subject;
            list.element.Single().Should().BeLiteralBool(true);
            AssertResult(isTrue, true);
        }

    }
}
