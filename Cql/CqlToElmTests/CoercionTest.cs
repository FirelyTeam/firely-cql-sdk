using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class CoercionTest : Base
    {

        internal static ElmFactory ElmFactory => ServiceProvider.GetElmFactory();
        internal static CoercionProvider CoercionProvider => _coercionProvider!;
        private static CoercionProvider? _coercionProvider;

        internal static LiteralTypes LiteralTypes => LiteralTypes!;
        private static LiteralTypes? _literalTypes;

        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter

        public static void Initialize(TestContext context)
        {
            ClassInitialize(options =>
            {
                options.EnableListPromotion = true;
                options.EnableListDemotion = true;
                options.EnableIntervalPromotion = true;
                options.EnableIntervalDemotion = true;
            });
            var modelProvider = ServiceProvider.GetRequiredService<Model.IModelProvider>() as Model.ModelProviders.BuiltInModelProvider;
            _literalTypes = ServiceProvider.GetRequiredService<LiteralTypes>();
            var systemModel = modelProvider!.Load(Model.Xml.Models.ElmR1);

            var libraryBuilder = new LibraryBuilder(new(),
                    ServiceProvider.GetRequiredService<LocalIdentifierProvider>())
                .UseModel(systemModel);
            _coercionProvider = CoercionProvider.Create(ServiceProvider, libraryBuilder);
        }
#pragma warning restore IDE0060 // Remove unused parameter

        private static Null Null() => new Null().WithResultType(LiteralTypes.AnyType);
        private static Null Null(TypeSpecifier type) => new Null().WithResultType(type);

        private static Literal String(string value = "") => ElmFactory.Literal(value);
        private static Literal Integer(int value = 1) => ElmFactory.Literal(value);
        private static Interval Interval(Expression low, Expression high) => new Interval { low = low, high = high }.WithResultType(LiteralTypes.ToIntervalType(low.resultTypeSpecifier));

        private static ValueSetRef ValueSet(string url = "http://hl7.org") => new ValueSetRef { name = "TestValueSet" }.WithResultType(LiteralTypes.ValueSetType);
        private static List List(TypeSpecifier elementType, params Expression[] elements) => new List { element = elements }.WithResultType(LiteralTypes.ToListType(elementType));
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
            var result = CoercionProvider.Coerce(expression, LiteralTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void ChoiceIsExactlyMatchesChoice()
        {
            var expression = new Null().WithResultType(Choice(LiteralTypes.IntegerType, LiteralTypes.StringType));
            var result = CoercionProvider.Coerce(expression, Choice(LiteralTypes.IntegerType, LiteralTypes.StringType));
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void TupleExactlyMatchesTuple()
        {
            var expression = Tuple(("x", Integer(1)), ("y", Integer(2)));
            var tupleType = TupleType(("y", LiteralTypes.IntegerType), ("x", LiteralTypes.IntegerType));
            var result = CoercionProvider.Coerce(expression, tupleType);
            Assert.IsTrue(result.Success);
            Assert.AreSame(expression, result.Result);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Cost);
        }

        [TestMethod]
        public void TupleDoesNotExactlMatchesTuple()
        {
            var expression = Tuple(("x", Integer(1)), ("y", Integer(2)));
            var tupleType = TupleType(("y", LiteralTypes.IntegerType), ("x", LiteralTypes.LongType));
            Assert.IsFalse(CoercionProvider.IsExactMatch(expression.resultTypeSpecifier, tupleType));
        }

        [TestMethod]
        public void IntegerIsSubtypeOfAny()
        {
            var expression = Integer();
            // <ns4:typeInfo xsi:type="ns4:SimpleTypeInfo" name="System.Integer" baseType="System.Any"/>
            var result = CoercionProvider.Coerce(expression, LiteralTypes.AnyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void AnyIsSubtypeOfAny()
        {
            Assert.IsTrue(CoercionProvider.IsSubtype(LiteralTypes.AnyType, LiteralTypes.AnyType));
        }

        [TestMethod]
        public void IntegerIsNotSubtypeOfLong()
        {
            Assert.IsFalse(CoercionProvider.IsSubtype(LiteralTypes.IntegerType, LiteralTypes.LongType));
        }

        [TestMethod]
        public void ValueSetIsSubtypeOfVocabulary()
        {
            var expression = ValueSet();
            CoercionProvider.ModelProvider.TryGetType("System.Vocabulary", out var vocabularyType).Should().BeTrue();
 

            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.ValueSet" baseType="System.Vocabulary"/>
            var result = CoercionProvider.Coerce(expression, TypeHelpers.ToElmSpecifier(vocabularyType!.ToTypeSpecifier()));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void ValueSetIsSubtypeOfAny()
        {
            var expression = ValueSet();
            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.ValueSet" baseType="System.Vocabulary"/>
            // <ns4:typeInfo xsi:type="ns4:ClassInfo" name="System.Vocabulary" baseType="System.Any">
            var result = CoercionProvider.Coerce(expression, LiteralTypes.AnyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBeCastToChoice()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, Choice(LiteralTypes.IntegerType, LiteralTypes.StringType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Cast, result.Cost);
        }

        [TestMethod]
        public void ChoiceIsCompatibleWithChoice()
        {
            var expression = new Null().WithResultType(Choice(LiteralTypes.IntegerType, LiteralTypes.StringType));
            var result = CoercionProvider.Coerce(expression, Choice(LiteralTypes.IntegerType, LiteralTypes.DecimalType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Cast, result.Cost);
        }

        [TestMethod]
        public void AnyIsCompatibleWithInteger()
        {
            var expression = Null();
            var result = CoercionProvider.Coerce(expression, LiteralTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.MoreCompatible, result.Cost);
        }

        [TestMethod]
        public void IntegerHasImplicitConversionToLong()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, LiteralTypes.LongType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBePromotedToInterval()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, LiteralTypes.ToIntervalType(LiteralTypes.IntegerType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.IntervalPromotion, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBePromotedToList()
        {
            var expression = Integer();
            var result = CoercionProvider.Coerce(expression, LiteralTypes.ToListType(LiteralTypes.IntegerType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ListPromotion, result.Cost);
        }

        [TestMethod]
        public void IntervalCanBeDemoted()
        {
            var expression = Interval(Integer(1), Integer(2));
            var result = CoercionProvider.Coerce(expression, LiteralTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.IntervalDemotion, result.Cost);
        }
        [TestMethod]
        public void ListCanBeDemoted()
        {
            var expression = List(LiteralTypes.IntegerType, Integer(1), Integer(2));
            var result = CoercionProvider.Coerce(expression, LiteralTypes.IntegerType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ListDemotion, result.Cost);
        }
        [TestMethod]
        public void IntegerPromotedToDecimal()
        {
            var expression = Integer(2);
            var result = CoercionProvider.Coerce(expression, LiteralTypes.DecimalType);
            Assert.IsTrue(result.Success);
            Assert.IsInstanceOfType(result.Result, typeof(ToDecimal));
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, result.Cost);
        }
        [TestMethod]
        public void ListAnyCanBeCastToListInteger()
        {
            var expression = List(LiteralTypes.AnyType);
            var result = CoercionProvider.Coerce(expression, LiteralTypes.ToListType(LiteralTypes.IntegerType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.MoreCompatible, result.Cost);
        }
        [TestMethod]
        public void ListIsSubtypeOfAny()
        {
            var expression = List(LiteralTypes.IntegerType);
            var result = CoercionProvider.Coerce(expression, LiteralTypes.AnyType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.Subtype, result.Cost);
        }

        [TestMethod]
        public void IntegerCanBeCastAsInteger() =>
            CoercionProvider.CanBeCast(LiteralTypes.IntegerType, LiteralTypes.IntegerType)
                .Should().BeTrue();

        [TestMethod]
        public void AnyCanBeCastAsIntervalAny() =>
            CoercionProvider.CanBeCast(LiteralTypes.AnyType, LiteralTypes.ToIntervalType(LiteralTypes.AnyType))
                .Should().BeTrue();

        [TestMethod]
        public void ListIntervalIntegerToListIntervalDecimal()
        {
            var expression = List(LiteralTypes.ToIntervalType(LiteralTypes.IntegerType),
                Interval(Integer(1), Integer(2)));
            var result = CoercionProvider.Coerce(expression,
                LiteralTypes.ToListType(LiteralTypes.ToIntervalType(LiteralTypes.DecimalType)));
            result.Success.Should().BeTrue();
            result.Cost.Should().Be(CoercionCost.ImplicitToSimpleType);
            result.Result.Should().BeOfType<Query>();
        }


        [TestMethod]
        public void IntervalIntegerToIntervalDecimal()
        {
            var expression = Interval(Integer(1), Integer(2));
            var result = CoercionProvider.Coerce(expression,
                LiteralTypes.ToIntervalType(LiteralTypes.DecimalType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, result.Cost);
        }

        [TestMethod]
        public void ValueSetToListCode()
        {
            var expression = ValueSet();
            var result = CoercionProvider.Coerce(expression,
                LiteralTypes.ToListType(LiteralTypes.CodeType));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToClassType, result.Cost);
        }

        [TestMethod]
        public void ListValueSetToListListCodes()
        {
            var expression = List(LiteralTypes.ValueSetType, ValueSet(), ValueSet());
            var llc = LiteralTypes.ToListType(LiteralTypes.ToListType(LiteralTypes.CodeType));
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
            var modelProvider = ServiceProvider.GetRequiredService<Model.IModelProvider>() as Model.ModelProviders.BuiltInModelProvider;
            var systemModel = modelProvider!.Load(Model.Xml.Models.ElmR1);
            var fhirModel = modelProvider.Load(Model.Xml.Models.Fhir401);

            fhirModel.TryGetType("FHIR.Age", out var fhirAgeType).Should().BeTrue();
            fhirModel.TryGetType("FHIR.Quantity", out var fhirQuantityType).Should().BeTrue();
            fhirAgeType!.BaseType.Should().Be(fhirQuantityType);

            fhirModel.ImplicitConversions.TryGetValue(fhirQuantityType!.ToTypeSpecifier(), out var conversionsFromFhirQuantity)
                .Should().BeTrue();
            systemModel.TryGetType("System.Quantity", out var systemQuantityType).Should().BeTrue();
            conversionsFromFhirQuantity!.TryGetValue(systemQuantityType!.ToTypeSpecifier(), out var conversionFunction)
                .Should().BeTrue();
            conversionFunction.Should().Be("FHIRHelpers.ToQuantity");

            var libraryBuilder = new LibraryBuilder(new(),
                ServiceProvider.GetRequiredService<LocalIdentifierProvider>())
            .UseModel(systemModel)
            .UseModel(fhirModel);

            _coercionProvider = CoercionProvider.Create(ServiceProvider, libraryBuilder);


            var qnts = new NamedTypeSpecifier { name = new global::System.Xml.XmlQualifiedName("{http://hl7.org/fhir}Quantity") };
            var result = CoercionProvider.Coerce(Null(qnts), LiteralTypes.QuantityType);
            Assert.IsTrue(result.Success);

            var ageNts = new NamedTypeSpecifier { name = new global::System.Xml.XmlQualifiedName("{http://hl7.org/fhir}Age") };
            result = CoercionProvider.Coerce(Null(ageNts), LiteralTypes.QuantityType);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(CoercionCost.ImplicitToClassType, result.Cost);
            Assert.IsInstanceOfType(result.Result, typeof(FunctionRef));
            var fr = (FunctionRef)result.Result;
        }

        [TestMethod]
        public void FhirDateToSystemDate()
        {

            var modelProvider = ServiceProvider.GetRequiredService<Model.IModelProvider>() as Model.ModelProviders.BuiltInModelProvider;
            var systemModel = modelProvider!.Load(Model.Xml.Models.ElmR1);
            var fhirModel = modelProvider.Load(Model.Xml.Models.Fhir401);

            fhirModel.TryGetType("FHIR.date", out var fhirDateType).Should().BeTrue();
            fhirModel.ImplicitConversions.TryGetValue(fhirDateType!.ToTypeSpecifier(), out var conversionsFromFhirDate)
                .Should().BeTrue();
            systemModel.TryGetType("System.Date", out var systemDateType).Should().BeTrue();
            conversionsFromFhirDate!.TryGetValue(systemDateType!.ToTypeSpecifier(), out var conversionFunction)
                .Should().BeTrue();
            conversionFunction.Should().Be("FHIRHelpers.ToDate");

            var libraryBuilder = new LibraryBuilder(new(),
                ServiceProvider.GetRequiredService<LocalIdentifierProvider>())
            .UseModel(systemModel)
            .UseModel(fhirModel);

            _coercionProvider = CoercionProvider.Create(ServiceProvider, libraryBuilder);

            var fdt = new NamedTypeSpecifier { name = new global::System.Xml.XmlQualifiedName("{http://hl7.org/fhir}date") };
            var cost = _coercionProvider.GetCoercionCost(fdt, LiteralTypes.DateType);
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, cost);
            var result = _coercionProvider.Coerce(Null(fdt), LiteralTypes.DateType);
            Assert.IsInstanceOfType(result.Result, typeof(FunctionRef));
            var fr = (FunctionRef)result.Result;
            Assert.AreEqual("FHIRHelpers", fr.libraryName);
            Assert.AreEqual("ToDate", fr.name);
            Assert.AreEqual(1, fr.operand?.Length);
            Assert.IsInstanceOfType(fr.operand![0], typeof(Null));
            Assert.AreEqual(LiteralTypes.DateType, fr.resultTypeSpecifier);
        }

    }
}
