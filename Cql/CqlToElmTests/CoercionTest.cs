using FluentAssertions;
using FluentAssertions.Types;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class CoercionTest : Base
    {
        internal static CoercionProvider CoercionProvider => Services.GetRequiredService<CoercionProvider>();
        internal static ElmFactory ElmFactory => Services.GetRequiredService<ElmFactory>();

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
        private static Literal String(string value = "") => ElmFactory.Literal(value);
        private static Literal Integer(int value = 1) => ElmFactory.Literal(value); private static Interval Interval(Expression low, Expression high) => new Interval { low = low, high = high }.WithResultType(low.resultTypeSpecifier.ToIntervalType());

        private static ValueSetRef ValueSet(string url = "http://hl7.org") => new ValueSetRef { name = "TestValueSet" }.WithResultType(SystemTypes.ValueSetType);
        private static List List(TypeSpecifier elementType, params Expression[] elements) => new List { element = elements }.WithResultType(elementType.ToListType());
        private static ChoiceTypeSpecifier Choice(params TypeSpecifier[] types) => new ChoiceTypeSpecifier(types);

        private static Elm.Tuple Tuple(params (string name, Expression value)[] tuple) =>
            new Elm.Tuple { element = tuple.Select(t => new TupleElement { name = t.name, value = t.value }).ToArray() }
            .WithResultType(TupleType(tuple.Select(t=>(t.name, t.value.resultTypeSpecifier)).ToArray()));
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
            Assert.AreEqual(CoercionCost.Compatible, result.Cost);
        }

        [TestMethod]
        public void AnyIsCompatibleWithInteger()
        {
            var expression = Null();
            var result = CoercionProvider.Coerce(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Compatible, result.Cost);
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
            Assert.AreEqual(CoercionCost.Cast, result.Cost);
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

    }
}
