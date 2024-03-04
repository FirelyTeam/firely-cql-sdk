using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class FunctionDefinitionTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        private FunctionDef shouldDefineFunction(Library l, string name) =>
            l.ShouldDefine<FunctionDef>(name);

        [TestMethod]
        public void DefinePrivateFluentFunction()
        {
            var library = MakeLibrary(@"
                library FuncTest version '1.0.0'
                using FHIR version '4.0.1'
                context Patient
                define private fluent function Two(): 2");

            var f = shouldDefineFunction(library, "Two");
            f.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
            f.expression.Should().BeLiteralInteger(2);
            f.fluent.Should().BeTrue();
            f.accessLevel.Should().Be(AccessModifier.Private);
            f.context.Should().Be("Patient");
        }

        [TestMethod]
        public void DefinePublicNonFluentExternalFunction()
        {
            var library = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define public function Ext() returns String: external");

            var f = shouldDefineFunction(library, "Ext");
            f.resultTypeSpecifier.Should().Be(SystemTypes.StringType);
            f.expression.Should().BeNull();
            f.fluent.Should().BeFalse();
            f.accessLevel.Should().Be(AccessModifier.Public);
        }

        [TestMethod]
        public void UntypedFunctionsAreIllegal()
        {
            _ = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define public function Ext(): external", "External functions must specify a return type.");
        }


        [TestMethod]
        public void OptionalReturnTypesMayBeTheSame()
        {
            var library = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define function Two() returns Integer: 2");

            var f = shouldDefineFunction(library, "Two");
            f.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
        }

        [TestMethod]
        public void OptionalReturnTypesMayBeSupertype()
        {
            var library = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define function Two() returns Any: 2");

            var f = shouldDefineFunction(library, "Two");
            f.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
        }

        [TestMethod]
        public void MakesParametersVisibleInScope()
        {
            var library = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define function Double(a Integer): a*2");

            var f = shouldDefineFunction(library, "Double");
            f.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
            var mul = f.expression.Should().BeOfType<Multiply>().Subject;
            mul.operand[0].Should().BeOfType<OperandRef>().Which.name.Should().Be("a");
        }

        [TestMethod]
        public void SignalsUnknownParameters()
        {
            _ = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define function Double(a Integer): b", "Unable to resolve identifier 'b'.");
        }

        [TestMethod]
        public void ResolvesInParentScope()
        {
            var library = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define b: 5
                define function Double(a Integer): b");

            var f = shouldDefineFunction(library, "Double");
            f.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
            var expr = f.expression.Should().BeOfType<ExpressionRef>().Subject;
            expr.name.Should().Be("b");
            expr.libraryName.Should().BeNull();
        }

        [TestMethod]
        public void ResolvesNearestScope()
        {
            var library = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define a: 5
                define function Replace(a String): a");

            var f = shouldDefineFunction(library, "Replace");
            f.resultTypeSpecifier.Should().Be(SystemTypes.StringType);
            f.expression.Should().BeOfType<OperandRef>().Which.name.Should().Be("a");
        }
    }
}
