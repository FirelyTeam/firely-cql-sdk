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
    public class TypeConverterTests : Base
    {
        internal static TypeConverter TypeConverter => Services.GetRequiredService<TypeConverter>();

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
        private static Literal Integer(int value = 1) => new Literal { value = value.ToString() }.WithResultType(SystemTypes.IntegerType);
        private static Literal String(string value = "hello") => new Literal { value = value }.WithResultType(SystemTypes.StringType);
        private static Interval Interval(Expression low, Expression high) => new Interval { low = low, high = high }.WithResultType(low.resultTypeSpecifier.ToIntervalType());

        private static ValueSetRef ValueSet(string url = "http://hl7.org") => new ValueSetRef { name = "TestValueSet" }.WithResultType(SystemTypes.ValueSetType);
        private static List List(TypeSpecifier elementType, params Expression[] elements) => new List { element = elements }.WithResultType(elementType.ToListType());
        private static ChoiceTypeSpecifier Choice(params TypeSpecifier[] types) => new ChoiceTypeSpecifier(types);

        private static Elm.Tuple Tuple(params (string name, Expression value)[] tuple) =>
            new Elm.Tuple { element = tuple.Select(t => new TupleElement { name = t.name, value = t.value }).ToArray() }
            .WithResultType(TupleType(tuple.Select(t=>(t.name, t.value.resultTypeSpecifier)).ToArray()));
        private static TypeSpecifier TupleType(params (string name, TypeSpecifier type)[] tuple) =>
            new TupleTypeSpecifier { element = tuple.Select(t => new TupleElementDefinition { name = t.name, elementType = t.type }).ToArray() };

        [TestMethod]
        public void IntegerExactyMatchesInteger()
        {
            var expression = Integer();
            var result = TypeConverter.Convert(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(ConversionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void ChoiceIsExactlyMatchesChoice()
        {
            var expression = new Null().WithResultType(Choice(SystemTypes.IntegerType, SystemTypes.StringType));
            var result = TypeConverter.Convert(expression, Choice(SystemTypes.IntegerType, SystemTypes.StringType));
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(ConversionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void TupleExactlyMatchesTuple()
        {
            var expression = Tuple(("x", Integer(1)), ("y", Integer(2)));
            var tupleType = TupleType(("y", SystemTypes.IntegerType), ("x", SystemTypes.IntegerType));
            var result = TypeConverter.Convert(expression, tupleType);
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(ConversionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void TupleDoesNotExactlMatchesTuple()
        {
            var expression = Tuple(("x", Integer(1)), ("y", Integer(2)));
            var tupleType = TupleType(("y", SystemTypes.IntegerType), ("x", SystemTypes.LongType));
            Assert.IsFalse(TypeConverter.IsExactMatch(expression.resultTypeSpecifier, tupleType));
        }

        [TestMethod]
        public void IntegerIsSubtypeOfAny()
        {
            var expression = Integer();
            // <ns4:typeInfo xsi:type="ns4:SimpleTypeInfo" name="System.Integer" baseType="System.Any"/>
            var result = TypeConverter.Convert(expression, SystemTypes.AnyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void AnyIsNotSubtypeOfAny()
        {
            Assert.IsFalse(TypeConverter.IsSubtype(SystemTypes.AnyType, SystemTypes.AnyType));
        }

        [TestMethod]
        public void ListIsNotSubtypeOfAny()
        {
            Assert.IsFalse(TypeConverter.IsSubtype(SystemTypes.AnyType.ToListType(), SystemTypes.AnyType));
        }

        [TestMethod]
        public void IntegerIsNotSubtypeOfLong()
        {
            Assert.IsFalse(TypeConverter.IsSubtype(SystemTypes.IntegerType, SystemTypes.LongType));
        }

        [TestMethod]
        public void ValueSetIsSubtypeOfVocabulary()
        {
            var expression = ValueSet();
            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.ValueSet" baseType="System.Vocabulary"/>
            var result = TypeConverter.Convert(expression, SystemTypes.VocabularyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void ValueSetIsSubtypeOfAny()
        {
            var expression = ValueSet();
            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.ValueSet" baseType="System.Vocabulary"/>
            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.Vocabulary" baseType="System.Any">
            var result = TypeConverter.Convert(expression, SystemTypes.AnyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void IntegerIsCompatibleWithChoice()
        {
            var expression = Integer();
            var result = TypeConverter.Convert(expression, Choice(SystemTypes.IntegerType, SystemTypes.StringType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.Compatible, result.Cost);
        }

        [TestMethod]
        public void ChoiceIsCompatibleWithChoice()
        {
            var expression = new Null().WithResultType(Choice(SystemTypes.IntegerType, SystemTypes.StringType));
            var result = TypeConverter.Convert(expression, Choice(SystemTypes.IntegerType, SystemTypes.DecimalType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.Compatible, result.Cost);
        }

        [TestMethod]
        public void AnyIsCompatibleWithInteger()
        {
            var expression = Null();
            var result = TypeConverter.Convert(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.Compatible, result.Cost);
        }

        [TestMethod]
        public void IntegerHasImplicitConversionToLong()
        {
            var expression = Integer();
            var result = TypeConverter.Convert(expression, SystemTypes.LongType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.ImplicitToSimpleType, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBePromotedToInterval()
        {
            var expression = Integer();
            var result = TypeConverter.Convert(expression, SystemTypes.IntegerType.ToIntervalType());
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.IntervalPromotion, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBePromotedToList()
        {
            var expression = Integer();
            var result = TypeConverter.Convert(expression, SystemTypes.IntegerType.ToListType());
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.ListPromotion, result.Cost);
        }

        [TestMethod]
        public void IntervalCanBeDemoted()
        {
            var expression = Interval(Integer(1), Integer(2));
            var result = TypeConverter.Convert(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.IntervalDemotion, result.Cost);
        }
        [TestMethod]
        public void ListCanBeDemoted()
        {
            var expression = List(SystemTypes.IntegerType, Integer(1), Integer(2));
            var result = TypeConverter.Convert(expression, SystemTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.ListDemotion, result.Cost);
        }
        [TestMethod]
        public void IntegerPromotedToDecimal()
        {
            var expression = Integer(2);
            var result = TypeConverter.Convert(expression, SystemTypes.DecimalType);
            Assert.IsTrue(result.Success);
            Assert.IsInstanceOfType(result.Result, typeof(ToDecimal));
            Assert.AreEqual(ConversionCost.ImplicitToSimpleType, result.Cost);
        }
        [TestMethod]
        public void ListAnyCanBeCastToListInteger()
        {
            var expression = List(SystemTypes.AnyType);
            var result = TypeConverter.Convert(expression, SystemTypes.IntegerType.ToListType());
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ConversionCost.Cast, result.Cost);
        }
    }
}
