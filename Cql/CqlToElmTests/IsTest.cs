using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class IsTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Integer_Is_Decimal()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private Integer_Is_Decimal: 1 is System.Decimal
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Literal));
                var operand = (Literal)@is.operand;
                Assert.AreEqual("1", operand.value);
                Assert.AreEqual($"{{{SystemUri}}}Integer", operand.resultTypeName?.Name);

                Assert.IsInstanceOfType(@is.isTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)@is.isTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name?.Name);

                AssertIs(@is, false);
            }
        }

        [TestMethod]
        public void True_Is_Qualified_Boolean()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private True_Is_Qualified_Boolean: true is System.Boolean
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Literal));
                var operand = (Literal)@is.operand;
                Assert.AreEqual("true", operand.value);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", operand.resultTypeName?.Name);

                Assert.IsInstanceOfType(@is.isTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)@is.isTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name?.Name);

                AssertIs(@is, true);
            }
        }

        [TestMethod]
        public void True_Is_Unqualified_Boolean()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private True_Is_Unqualified_Boolean: true is Boolean
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Literal));
                var operand = (Literal)@is.operand;
                Assert.AreEqual("true", operand.value);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", operand.resultTypeName?.Name);

                Assert.IsInstanceOfType(@is.isTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)@is.isTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name?.Name);

                AssertIs(@is, true);
            }
        }

        [TestMethod]
        public void Null_Is_Boolean()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private Null_Is_Boolean: null is Boolean
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Null));
                Assert.IsInstanceOfType(@is.isTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)@is.isTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name?.Name);

                AssertIs(@is, false);
            }
        }

        [TestMethod]
        public void Null_Is_Any()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private Null_Is_Any: null is Any
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Null));
                Assert.IsInstanceOfType(@is.isTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)@is.isTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Any", nts.name?.Name);
                AssertIs(@is, false);
            }
        }

        [TestMethod]
        public void List_Is_List_of_Qualified_Integer()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private List_Is_List_of_Qualified_Integer: { 1,2,3 } is List<System.Integer>
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(List));
                var operand = (List)@is.operand;
                Assert.IsNotNull(operand.resultTypeSpecifier);
                AssertListType(operand.resultTypeSpecifier, $"{{{SystemUri}}}Integer");
                AssertListType(@is.isTypeSpecifier, $"{{{SystemUri}}}Integer");

                AssertIs(@is, true);
            }
        }


        [TestMethod]
        public void Interval_Is_Unqualified_Integer_Interval()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private Interval_Is_Unqualified_Integer_Interval: Interval[1, 10] is Interval<Integer>
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Interval));
                var operand = (Interval)@is.operand;
                Assert.IsNotNull(operand.resultTypeSpecifier);
                AssertIntervalType(operand.resultTypeSpecifier, $"{{{SystemUri}}}Integer");
                AssertIntervalType(@is.isTypeSpecifier, $"{{{SystemUri}}}Integer");

                AssertIs(@is, true);
            }
        }

        [TestMethod]
        public void Integer_Interval_Is_Decimal_Interval_False()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private Integer_Interval_Is_Decimal_Interval_False: Interval[1, 10] is Interval<Decimal>
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Interval));
                var operand = (Interval)@is.operand;
                Assert.IsNotNull(operand.resultTypeSpecifier);
                AssertIntervalType(operand.resultTypeSpecifier, $"{{{SystemUri}}}Integer");
                AssertIntervalType(@is.isTypeSpecifier, $"{{{SystemUri}}}Decimal");

                AssertIs(@is, false);
            }
        }

        [TestMethod]
        public void Integer_Is_Choice()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private Integer_Is_Choice: 1 is Choice<Integer,Decimal>
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Literal));
                var operand = (Literal)@is.operand;
                Assert.IsNotNull(operand.resultTypeSpecifier);
                Assert.AreEqual("1", operand.value);
                Assert.AreEqual($"{{{SystemUri}}}Integer", operand.resultTypeName?.Name);

                AssertChoiceType(@is.isTypeSpecifier, $"{{{SystemUri}}}Integer", $"{{{SystemUri}}}Decimal");

                AssertIs(@is, true);
            }
        }
        [TestMethod]
        public void String_Is_Choice_False()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private String_Is_Choice_False: 'hello' is Choice<Integer,Decimal>
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Literal));
                var operand = (Literal)@is.operand;
                Assert.IsNotNull(operand.resultTypeSpecifier);
                Assert.AreEqual("hello", operand.value);
                Assert.AreEqual($"{{{SystemUri}}}String", operand.resultTypeName?.Name);

                AssertChoiceType(@is.isTypeSpecifier, $"{{{SystemUri}}}Integer", $"{{{SystemUri}}}Decimal");

                AssertIs(@is, false);
            }
        }

        [TestMethod]
        public void Tuple_Is_Tuple()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private Tuple_Is_Tuple: { x: 1, y: 2 } is Tuple { x Integer, y Integer }
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Elm.Tuple));
                var operand = (Elm.Tuple)@is.operand;
                
                AssertTupleType(@is.isTypeSpecifier, ("x", $"{{{SystemUri}}}Integer"), ("y", $"{{{SystemUri}}}Integer"));

                AssertIs(@is, true);
            }
        }

        [TestMethod]
        public void Tuple_Is_Tuple_False()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library IsTest version '1.0.0'

                define private Tuple_Is_Tuple: Tuple { x: 1, y: 2 } is Tuple { x Decimal, y Integer }
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Is));
            {
                var @is = (Is)library.statements[0].expression;
                Assert.IsNotNull(@is.operand);
                Assert.IsInstanceOfType(@is.operand, typeof(Elm.Tuple));
                var operand = (Elm.Tuple)@is.operand;

                AssertTupleType(@is.isTypeSpecifier, ("x", $"{{{SystemUri}}}Decimal"), ("y", $"{{{SystemUri}}}Integer"));

                AssertIs(@is, false);
            }
        }


        private void AssertIs(Is @is, bool? expected)
        {
            var lambda = ExpressionBuilder.Lambda(@is);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke(ctx);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(bool?));
            Assert.AreEqual(expected, result);
        }
    }
}
