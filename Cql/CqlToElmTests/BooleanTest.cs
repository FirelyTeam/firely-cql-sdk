using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class BooleanTest : Base
    {
        [TestMethod]
        public void True_Is_True()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("true is true");
            var isTrue = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsTrue>();
            isTrue.operand.Should().BeLiteralBool(true);
            AssertResult(isTrue, true);
        }

        [TestMethod]
        public void True_Is_False()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("true is false");
            var isFalse = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsFalse>();
            isFalse.operand.Should().BeLiteralBool(true);
            AssertResult(isFalse, false);
        }

        [TestMethod]
        public void True_Is_Null()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("true is null");
            var isNull = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsNull>();
            var @as = isNull.operand.Should().BeOfType<As>().Subject;
            @as.Should().HaveType(SystemTypes.AnyType);
            @as.operand.Should().BeLiteralBool(true);
            AssertResult(isNull, false);
        }

        [TestMethod]
        public void Null_Is_True()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("null is true");
            var isTrue = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsTrue>();
            var @as = isTrue.operand.Should().BeOfType<As>().Subject;
            @as.operand.Should().BeNullLiteral();
            AssertResult(isTrue, false);
        }

        [TestMethod]
        public void Null_Is_Null()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("null is null");
            var isNull = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsNull>();
            isNull.operand.Should().BeNullLiteral();
            AssertResult(isNull, true);
        }

        [TestMethod]
        public void True_Is_Not_False()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("true is not false");
            var isNot = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Not>();
            var isFalse = isNot.operand.Should().BeOfType<IsFalse>().Subject;
            isFalse.operand.Should().BeLiteralBool(true);
            AssertResult(isNot, true);
        }

        [TestMethod]
        public void True_Is_Not_Null()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("true is not null");
            var isNot = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Not>();
            var isNull = isNot.operand.Should().BeOfType<IsNull>().Subject;
            AssertResult(isNot, true);
        }

        [TestMethod]
        public void Null_Is_Not_Null()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("null is not null");
            var isNot = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Not>();
            var isNull = isNot.operand.Should().BeOfType<IsNull>().Subject;
            isNull.operand.Should().BeNullLiteral();
            AssertResult(isNot, false);
        }

        [TestMethod]
        public void Null_Is_Not_False()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("null is not false");
            var isNot = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Not>();
            var isFalse = isNot.operand.Should().BeOfType<IsFalse>().Subject;
            var @as = isFalse.operand.Should().BeOfType<As>().Subject;
            @as.operand.Should().BeNullLiteral();
            AssertResult(isNot, true);
        }

        [TestMethod]
        public void TrueList_Is_True()
        {
            var library = CreateCqlApi(EnableListDemotion:true ).MakeLibraryFromExpression("{true} is true");
            var isTrue = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<IsTrue>();
            var singleton = isTrue.operand.Should().BeOfType<SingletonFrom>().Subject;
            singleton.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);
            var list = singleton.operand.Should().BeOfType<List>().Subject;
            list.element.Single().Should().BeLiteralBool(true);
            AssertResult(isTrue, true);
        }

    }
}
