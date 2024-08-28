using System;
using System.IO;
using Antlr4.Runtime;
using FluentAssertions;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
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
            MakeLibrary(@"
                library FuncTest version '1.0.0'
                define function Double(a Integer): b", "Could not resolve identifier b in the current library.");
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

        [TestMethod]
        public void DoesForwardsReference()
        {
            var library = MakeLibrary(@"
                library FuncTest version '1.0.0'
                define b: a                
                define a: 5");

            var f = library.ShouldDefine<ExpressionDef>("b");
            f.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
            f.expression.Should().BeOfType<ExpressionRef>().Which.name.Should().Be("a");
        }

        [TestMethod]
        public void DetectsCycle()
        {
            _ = MakeLibrary(@"
            library FuncTest version '1.0.0'          
            define a: b                
            define b: a",
            "Cannot resolve reference to expression or function a because it results in a circular reference.");
        }

        [TestMethod]
        public void CallsFluentOnMember()
        {
            var lib = MakeLibrary(@"
            library FuncTest version '1.0.0'
            
            using FHIR version '4.0.1'

            define fluent function ""To date interval""(period FHIR.Period):
                Interval[date from start of period, date from end of period]

            define fluent function ""Interval""(coverage FHIR.Coverage):
                (coverage.period as FHIR.Period).""To date interval""()
            ");
            lib.GetErrors().Should().BeEmpty();
        }
        [TestMethod]
        public void CallsFluentOnMember_AcrossLibrary()
        {
            var services = ServiceCollection().BuildServiceProvider();
            var libraryProvider = (MemoryLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            var fluentLib = MakeLibraryBuilder(services, @"
                library FluentLib version '1.0.0'
            
                using FHIR version '4.0.1'

                define fluent function ""To date interval""(period FHIR.Period):
                    Interval[date from start of period, date from end of period]
            ");
            libraryProvider.Libraries.Add("FluentLib", "1.0.0", fluentLib);
            var testLib = MakeLibrary(services, @"
            library FuncTest version '1.0.0'
            
            using FHIR version '4.0.1'
            
            include FluentLib version '1.0.0'

            define fluent function ""Interval""(coverage FHIR.Coverage):
                (coverage.period as FHIR.Period).""To date interval""()
            ");
            testLib.GetErrors().Should().BeEmpty();
            testLib.statements.Should().NotBeNull();
            testLib.statements.Should().HaveCount(1);
            var subject = testLib.statements[0].Should().BeOfType<FunctionDef>().Subject;


        }

        [TestMethod]
        public void BirthdatePlusAge()
        {
            var services = ServiceCollection().BuildServiceProvider();
            var libraryProvider = (MemoryLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            using var scope = services.CreateScope();
            AddFHIRHelpers(libraryProvider, scope);
            var lib = MakeLibrary(services, @"
                library Test version '1.0.0'

                using FHIR version '4.0.1'

                include FHIRHelpers version '4.0.1'

                define function f(patient FHIR.Patient, condition FHIR.Condition):
                  patient.birthDate + (condition.onset as FHIR.Age)
            ");
            var add = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Add>();
            add.operand.Should().HaveCount(2);
            var toDate = add.operand[0].Should().BeOfType<FunctionRef>().Subject;
            Assert.AreEqual("FHIRHelpers", toDate.libraryName);
            Assert.AreEqual("ToDate", toDate.name);
            Assert.AreEqual(1, toDate.operand?.Length);
            Assert.AreEqual(SystemTypes.DateType, toDate.resultTypeSpecifier);
            var toQuantity = add.operand[1].Should().BeOfType<FunctionRef>().Subject;
            Assert.AreEqual("FHIRHelpers", toQuantity.libraryName);
            Assert.AreEqual("ToQuantity", toQuantity.name);
            Assert.AreEqual(1, toQuantity.operand?.Length);
            Assert.AreEqual(SystemTypes.QuantityType, toQuantity.resultTypeSpecifier);
        }

        [TestMethod]
        public void ComplexCaseStatement()
        {
            var lib = MakeLibrary(@"
                library FuncTest version '1.0.0'
            
                using FHIR version '4.0.1'

                define fluent function ""Onset date""(condition FHIR.Condition, birthDate Date):
                case
                    when condition is null or condition.onset is null then 
                        null
                    when condition.onset is FHIR.dateTime then 
                        date from (condition.onset as FHIR.dateTime)
                    when condition.onset is FHIR.Period then 
                        date from start of (condition.onset as FHIR.Period)
                    when condition.onset is FHIR.Age and birthDate is not null then 
                        birthDate + (condition.onset as FHIR.Age)
                    when condition.onset is Range and birthDate is not null then 
                        birthDate + (condition.onset as FHIR.Range).low
                    else 
                        null
                end            
            ");
            var cs = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Case>();
            cs.Should().HaveType(SystemTypes.DateType);

        }

        [TestMethod]
        public void External_Function()
        {
            var lib = MakeLibrary(@"
                library FuncTest version '1.0.0'

                define function Add(left Integer, right Integer) returns Integer: external
            ");
            lib.statements.Should().HaveCount(1);
            var fd = lib.statements[0].Should().BeOfType<FunctionDef>().Subject;
            fd.external.Should().BeTrue();
            fd.externalSpecified.Should().BeTrue();
            fd.expression.Should().BeNull();
        }
    }
}