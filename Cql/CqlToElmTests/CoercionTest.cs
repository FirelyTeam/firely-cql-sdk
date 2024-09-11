using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Hl7.Cql.CqlToElm.Hosting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class CoercionTest : Base
    {
        internal static CoercionProvider CoercionProvider => ServiceProvider.GetCoercionProvider();
        internal static ElmFactory ElmFactory =>  ServiceProvider.GetElmFactory();

        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(options =>
        {
            options.EnableListPromotion = true;
            options.EnableListDemotion = true;
            options.EnableIntervalPromotion = true;
            options.EnableIntervalDemotion = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        private static Null Null() => new Null().WithResultType(SystemTypes.AnyType);
        private static Null Null(TypeSpecifier type) => new Null().WithResultType(type);

        private static Literal String(string value = "") => ElmFactory.Literal(value);
        private static Literal Integer(int value = 1) => ElmFactory.Literal(value); private static Interval Interval(Expression low, Expression high) => new Interval { low = low, high = high }.WithResultType(low.resultTypeSpecifier.ToIntervalType());

        private static ValueSetRef ValueSet(string url = "http://hl7.org") => new ValueSetRef { name = "TestValueSet" }.WithResultType(SystemTypes.ValueSetType);
        private static List List(TypeSpecifier elementType, params Expression[] elements) => new List { element = elements }.WithResultType(elementType.ToListType());
        private static ChoiceTypeSpecifier Choice(params TypeSpecifier[] types) => new ChoiceTypeSpecifier(types);

        private static Elm.Tuple Tuple(params (string name, Expression value)[] tuple) =>
            new Elm.Tuple { element = tuple.Select(t => new TupleElement { name = t.name, value = t.value }).ToArray() }
            .WithResultType(TupleType(tuple.Select(t => (t.name, t.value.resultTypeSpecifier)).ToArray()));
        private static TypeSpecifier TupleType(params (string name, TypeSpecifier type)[] tuple) =>
            new TupleTypeSpecifier { element = tuple.Select(t => new TupleElementDefinition { name = t.name, elementType = t.type }).ToArray() };

        private static ParameterTypeSpecifier T = new ParameterTypeSpecifier { parameterName = "T" };

        [TestMethod]
        public void IntegerExactyMatchesInteger()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void ChoiceIsExactlyMatchesChoice()
        {
            var expression = new Null().WithResultType(Choice(SystemTypes.IntegerType, SystemTypes.StringType));
            var result = CoercionProvider.Coerce(expression, Choice(SystemTypes.IntegerType, SystemTypes.StringType));
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void TupleExactlyMatchesTuple()
        {
            var expression = Tuple(("x", Integer(1)), ("y", Integer(2)));
            var tupleType = TupleType(("y", SystemTypes.IntegerType), ("x", SystemTypes.IntegerType));
            var result = CoercionProvider.Coerce(expression, tupleType);
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void TupleDoesNotExactlMatchesTuple()
        {
            var expression = Tuple(("x", Integer(1)), ("y", Integer(2)));
            var tupleType = TupleType(("y", SystemTypes.IntegerType), ("x", SystemTypes.LongType));
            Assert.IsFalse(CoercionProvider.IsExactMatch(expression.resultTypeSpecifier, tupleType));
        }

        [TestMethod]
        public void IntegerIsSubtypeOfAny()
        {
            var expression = Integer();
            // <ns4:typeInfo xsi:type="ns4:SimpleTypeInfo" name="System.Integer" baseType="System.Any"/>
            var result = CoercionProvider.Coerce(expression, SystemTypes.AnyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void AnyIsSubtypeOfAny()
        {
            Assert.IsTrue(CoercionProvider.IsSubtype(SystemTypes.AnyType, SystemTypes.AnyType));
        }

        [TestMethod]
        public void IntegerIsNotSubtypeOfLong()
        {
            Assert.IsFalse(CoercionProvider.IsSubtype(SystemTypes.IntegerType, SystemTypes.LongType));
        }

        [TestMethod]
        public void ValueSetIsSubtypeOfVocabulary()
        {
            var expression = ValueSet();
            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.ValueSet" baseType="System.Vocabulary"/>
            var result = CoercionProvider.Coerce(expression, SystemTypes.VocabularyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void ValueSetIsSubtypeOfAny()
        {
            var expression = ValueSet();
            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.ValueSet" baseType="System.Vocabulary"/>
            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.Vocabulary" baseType="System.Any">
            var result = CoercionProvider.Coerce(expression, SystemTypes.AnyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBeCastToChoice()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, Choice(SystemTypes.IntegerType, SystemTypes.StringType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Cast, result.Cost);
        }

        [TestMethod]
        public void ChoiceIsCompatibleWithChoice()
        {
            var expression = new Null().WithResultType(Choice(SystemTypes.IntegerType, SystemTypes.StringType));
            var result = CoercionProvider.Coerce(expression, Choice(SystemTypes.IntegerType, SystemTypes.DecimalType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Cast, result.Cost);
        }

        [TestMethod]
        public void AnyIsCompatibleWithInteger()
        {
            var expression = Null();
            var result = CoercionProvider.Coerce(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.MoreCompatible, result.Cost);
        }

        [TestMethod]
        public void IntegerHasImplicitConversionToLong()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, SystemTypes.LongType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBePromotedToInterval()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, SystemTypes.IntegerType.ToIntervalType());
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.IntervalPromotion, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBePromotedToList()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, SystemTypes.IntegerType.ToListType());
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ListPromotion, result.Cost);
        }

        [TestMethod]
        public void IntervalCanBeDemoted()
        {
            var expression = Interval(Integer(1), Integer(2));
            var result = CoercionProvider.Coerce(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.IntervalDemotion, result.Cost);
        }
        [TestMethod]
        public void ListCanBeDemoted()
        {
            var expression = List(SystemTypes.IntegerType, Integer(1), Integer(2));
            var result = CoercionProvider.Coerce(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ListDemotion, result.Cost);
        }
        [TestMethod]
        public void IntegerPromotedToDecimal()
        {
            var expression = Integer(2);
            var result = CoercionProvider.Coerce(expression, SystemTypes.DecimalType);
            Assert.IsTrue(result.Success);
            Assert.IsInstanceOfType(result.Result, typeof(ToDecimal));
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, result.Cost);
        }
        [TestMethod]
        public void ListAnyCanBeCastToListInteger()
        {
            var expression = List(SystemTypes.AnyType);
            var result = CoercionProvider.Coerce(expression, SystemTypes.IntegerType.ToListType());
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.MoreCompatible, result.Cost);
        }
        [TestMethod]
        public void ListIsSubtypeOfAny()
        {
            var expression = List(SystemTypes.IntegerType);
            var result = CoercionProvider.Coerce(expression, SystemTypes.AnyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBeCastAsInteger() =>
            CoercionProvider.CanBeCast(SystemTypes.IntegerType, SystemTypes.IntegerType)
                .Should().BeTrue();

        [TestMethod]
        public void AnyCanBeCastAsIntervalAny() =>
            CoercionProvider.CanBeCast(SystemTypes.AnyType, SystemTypes.AnyType.ToIntervalType())
                .Should().BeTrue();

        [TestMethod]
        public void ListIntervalIntegerToListIntervalDecimal()
        {
            var expression = List(SystemTypes.IntegerType.ToIntervalType(),
                Interval(Integer(1), Integer(2)));
            var result = CoercionProvider.Coerce(expression,
                SystemTypes.DecimalType.ToIntervalType().ToListType());
            result.Success.Should().BeTrue();
            result.Cost.Should().Be(CoercionCost.ImplicitToSimpleType);
            result.Result.Should().BeOfType<Query>();
        }


        [TestMethod]
        public void IntervalIntegerToIntervalDecimal()
        {
            var expression = Interval(Integer(1), Integer(2));
            var result = CoercionProvider.Coerce(expression,
                SystemTypes.DecimalType.ToIntervalType());
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, result.Cost);
        }

        [TestMethod]
        public void ValueSetToListCode()
        {
            var expression = ValueSet();
            var result = CoercionProvider.Coerce(expression,
                SystemTypes.CodeType.ToListType());
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToClassType, result.Cost);
        }

        [TestMethod]
        public void ListValueSetToListListCodes()
        {
            var expression = List(SystemTypes.ValueSetType, ValueSet(), ValueSet());
            var llc = SystemTypes.CodeType.ToListType().ToListType();
            var result = CoercionProvider.Coerce(expression, llc);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToClassType, result.Cost);
            Assert.AreEqual(llc, result.Result.resultTypeSpecifier);
        }

        [TestMethod]
        public void FhirAgeToQuantity()
        {
            // This conversion is defined
            // <conversionInfo functionName="FHIRHelpers.ToQuantity" fromType="FHIR.Quantity" toType="System.Quantity"/>
            // Age is a subtype of FHIR.Quantity

            var qnts = new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("{http://hl7.org/fhir}Quantity") };
            var result = CoercionProvider.Coerce(Null(qnts), SystemTypes.QuantityType);
            Assert.IsTrue(result.Success);

            var ageNts = new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("{http://hl7.org/fhir}Age") };
            result = CoercionProvider.Coerce(Null(ageNts), SystemTypes.QuantityType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToClassType, result.Cost);
            Assert.IsInstanceOfType(result.Result, typeof(FunctionRef));
            var fr = (FunctionRef)result.Result;
        }

        [TestMethod]
        public void FhirDateToSystemDate()
        {
            var fdt = new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("{http://hl7.org/fhir}date") };
            var cost = CoercionProvider.GetCoercionCost(fdt, SystemTypes.DateType);
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, cost);
            var result = CoercionProvider.Coerce(Null(fdt), SystemTypes.DateType);
            Assert.IsInstanceOfType(result.Result, typeof(FunctionRef));
            var fr = (FunctionRef)result.Result;
            Assert.AreEqual("FHIRHelpers", fr.libraryName);
            Assert.AreEqual("ToDate", fr.name);
            Assert.AreEqual(1, fr.operand?.Length);
            Assert.IsInstanceOfType(fr.operand![0], typeof(Null));
            Assert.AreEqual(SystemTypes.DateType, fr.resultTypeSpecifier);
        }

    }
}
