using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InvocationBuilderTest : Base
    {
        internal static InvocationBuilder InvocationBuilder => Services.GetRequiredService<InvocationBuilder>();
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

        private static ParameterTypeSpecifier Generic(string parameterName = "T") => new ParameterTypeSpecifier { parameterName = parameterName };

        private static Literal Boolean(bool value = true) => ElmFactory.Literal(value);
        private static Literal String(string value = "") => ElmFactory.Literal(value);

        private static Literal Integer(int value = 1) => ElmFactory.Literal(value);
        private static Literal Decimal(decimal value = 1m) => ElmFactory.Literal(value);
        private static Quantity Quantity(decimal value = 1) => ElmFactory.Quantity(value, "1");
        private static Elm.DateTime DateTime() => new Elm.DateTime { year = Integer(2024) }.WithResultType(SystemTypes.DateTimeType);
        private static List List(Expression first, params Expression[] elements) => new List { element = new[] { first }.Concat(elements).ToArray() }.WithResultType(first.resultTypeSpecifier.ToListType());
        private static Interval Interval(Expression low, Expression high) => new Interval { low = low, high = high }.WithResultType(low.resultTypeSpecifier.ToIntervalType());
        private static readonly Null Null = new Null().WithResultType(SystemTypes.AnyType);

        private static readonly ParameterTypeSpecifier T = new ParameterTypeSpecifier { parameterName = "T" };
        private static void AssertCompatible(FunctionDef function, Expression[] arguments, CoercionCost mostExpensive, int? totalCost = null)
        {
            var result = InvocationBuilder.MatchSignature(function, arguments);
            result.Compatible.Should().BeTrue();
            Assert.AreEqual(mostExpensive, result.MostExpensive);
            if (totalCost != null)
                Assert.AreEqual(totalCost.Value, result.TotalCost);
            Assert.AreEqual(SignatureMatchFlags.None, result.Flags);
        }

        [TestMethod]
        public void MatchAnd()
        {
            var arguments = new[] { Boolean(), Boolean() };
            AssertCompatible(SystemLibrary.And, arguments, CoercionCost.ExactMatch);
        }

        [TestMethod]
        public void TooFewArguments()
        {
            var arguments = new[] { Boolean() };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.And, arguments);
            result.Compatible.Should().BeFalse();
            Assert.IsTrue(result.HasTooFewArguments);
        }

        [TestMethod]
        public void TooManyArguments()
        {
            var arguments = new[] { Boolean(), Boolean(), Boolean() };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.And, arguments);
            result.Compatible.Should().BeFalse();
            Assert.IsTrue(result.HasTooManyArguments);
        }

        [TestMethod]
        public void MatchNow()
        {
            var arguments = Array.Empty<Expression>();
            AssertCompatible(SystemLibrary.Now, arguments, CoercionCost.ExactMatch);

        }

        [TestMethod]
        public void MatchDate()
        {
            Expression[] arguments = new[] { Integer(2023) };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.Date, arguments);
            AssertCompatible(SystemLibrary.Date, arguments, CoercionCost.ExactMatch);

            arguments = new[] { Integer(2023), Integer(1) };
            AssertCompatible(SystemLibrary.Date, arguments, CoercionCost.ExactMatch);

            arguments = new[] { Integer(2023), Integer(2), Integer(14) };
            AssertCompatible(SystemLibrary.Date, arguments, CoercionCost.ExactMatch);

            arguments = Array.Empty<Expression>();
            result = InvocationBuilder.MatchSignature(SystemLibrary.Date, arguments);
            result.Compatible.Should().BeFalse();
            Assert.IsTrue(result.HasTooFewArguments);

            arguments = new[] { Integer(2023), Integer(2), Integer(14), Integer(10) };
            result = InvocationBuilder.MatchSignature(SystemLibrary.Date, arguments);
            result.Compatible.Should().BeFalse();
            Assert.IsTrue(result.HasTooManyArguments);
        }
        
        [TestMethod]
        public void MatchSimpleGeneric()
        {
            var T = Generic();
            var function = new SystemFunction<Abs>(new[] { T }, T);
            var arguments = new[] { Integer(1) };
            var inference = InvocationBuilder.InferGenericArgument(arguments[0].resultTypeSpecifier, function.operand[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.parameterName));
            Assert.AreEqual(SystemTypes.IntegerType, inference[T.parameterName]);
            AssertCompatible(function, arguments, CoercionCost.ExactMatch);


            arguments = new[] { Decimal(1) };
            inference = InvocationBuilder.InferGenericArgument(arguments[0].resultTypeSpecifier, function.operand[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.parameterName));
            Assert.AreEqual(SystemTypes.DecimalType, inference[T.parameterName]);
            AssertCompatible(function, arguments, CoercionCost.ExactMatch);
        }

        [TestMethod]
        public void MatchGenericListArgument()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new[] { T.ToListType() }, T);
            var arguments = new[] { List(Integer(1)) };
            var inference = InvocationBuilder.InferGenericArgument(arguments[0].resultTypeSpecifier, function.operand[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.parameterName));
            Assert.AreEqual(SystemTypes.IntegerType, inference[T.parameterName]);
            AssertCompatible(function, arguments, CoercionCost.ExactMatch);
        }



        [TestMethod]
        public void MatchGenericIntervalArgument()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new[] { T.ToIntervalType() }, T);
            var arguments = new[] { Interval(Integer(1), Integer(10)) };
            var inference = InvocationBuilder.InferGenericArgument(arguments[0].resultTypeSpecifier, function.operand[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.parameterName));
            Assert.AreEqual(SystemTypes.IntegerType, inference[T.parameterName]);
            AssertCompatible(function, arguments, CoercionCost.ExactMatch);

        }
        [TestMethod]
        public void MatchGenericNestedListArgument()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new[] { T.ToListType().ToListType() }, T);
            var arguments = new[] { List(List(Integer(1))) };
            var inference = InvocationBuilder.InferGenericArgument(arguments[0].resultTypeSpecifier, function.operand[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.parameterName));
            Assert.AreEqual(SystemTypes.IntegerType, inference[T.parameterName]);
            AssertCompatible(function, arguments, CoercionCost.ExactMatch);
        }

        [TestMethod]
        public void MatchGenericListAndAny()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new TypeSpecifier[] { T.ToListType(), SystemTypes.AnyType }, SystemTypes.BooleanType);
            var arguments = new[] { List(Null), List(Null) };
            var inference = InvocationBuilder.InferGenericArgument(arguments[0].resultTypeSpecifier, function.operand[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.parameterName));
            Assert.AreEqual(SystemTypes.AnyType, inference[T.parameterName]);
            var result = InvocationBuilder.MatchSignature(function, arguments);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Arguments[0].Cost);
            Assert.AreEqual(CoercionCost.Subtype, result.Arguments[1].Cost);
        }
        [TestMethod]
        public void MatchGenericListAndT()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new TypeSpecifier[] { T.ToListType(), T }, SystemTypes.BooleanType);
            var arguments = new Expression[] { List(Null), List(Null) };
            var inference = InvocationBuilder.InferGenericArgument(arguments[0].resultTypeSpecifier, function.operand[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.parameterName));
            Assert.AreEqual(SystemTypes.AnyType, inference[T.parameterName]);
            var result = InvocationBuilder.MatchSignature(function, arguments);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Arguments[0].Cost);
            Assert.AreEqual(CoercionCost.Subtype, result.Arguments[1].Cost);
            Assert.AreEqual(CoercionCost.Subtype, result.MostExpensive);

            // These arguments are cheaper than passing two lists.
            // Because in both cases T is inferred to be Any, in the two list case, this results in a List Demotion to T.
            // In the second case, no list demotion is necessary and Any exactly matches Any.
            arguments = new Expression[] { List(Null), Null };
            inference = InvocationBuilder.InferGenericArgument(arguments[0].resultTypeSpecifier, function.operand[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.parameterName));
            Assert.AreEqual(SystemTypes.AnyType, inference[T.parameterName]);
            result = InvocationBuilder.MatchSignature(function, arguments);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Arguments[0].Cost);
            Assert.AreEqual(CoercionCost.ExactMatch, result.Arguments[1].Cost);
            Assert.AreEqual(CoercionCost.ExactMatch, result.MostExpensive);
        }

        [TestMethod]
        public void MatchInvalidAddSignature()
        {
            var arguments = new Expression[] { Quantity(), DateTime() };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.Add, arguments);
            result.Compatible.Should().BeFalse();
        }

        [TestMethod]
        public void MatchIncludesWithNullAndList()
        {
            //define"Includes Null Left Input": null includes {2}

            var arguments = new Expression[] { Null, List(Integer(2)) };
            var function = new SystemFunction<Expression>(new TypeSpecifier[] { T.ToListType(), T.ToListType() }, SystemTypes.BooleanType, "f");
            var result = InvocationBuilder.MatchSignature(function, arguments);
            result.Compatible.Should().BeTrue();
        }

        [TestMethod]
        public void MatchMessageWithListArgument()
        {
            //define "TestMessageTrace Input": Message({ 3,4,5},true,'300','Trace','This is a trace')
            var arguments = new Expression[] { List(Integer(3)), Boolean(true), String("300"), String("Trace"), String("This is a trace") };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.Message, arguments);
            result.Compatible.Should().BeTrue();
        }

        [TestMethod]
        public void MatchAnyOperandWithListArgument()
        {
            var function = new SystemFunction<Expression>(new TypeSpecifier[] { SystemTypes.AnyType }, SystemTypes.AnyType, "f");
            var arguments = new Expression[] { List(Integer(1)) };
            var result = InvocationBuilder.MatchSignature(function, arguments);
            result.Compatible.Should().BeTrue();
        }

        [TestMethod]
        public void MatchEqualWithIntervalArguments()
        {
            var arguments = new Expression[] { Interval(Integer(1), Integer(2)), Interval(Null, Null) };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.Equal, arguments);
            result.Compatible.Should().BeTrue();
        }

        [TestMethod]
        public void MatchIndexOf()
        {
            //IndexOf(null, {})
            var arguments = new Expression[] { Null, new List().WithResultType(SystemTypes.AnyType.ToListType()) };
            var match = InvocationBuilder.MatchSignature(SystemLibrary.IndexOf, arguments);
            Assert.IsTrue(match.Compatible);
            var expression = InvocationBuilder.Invoke(SystemLibrary.IndexOf, arguments);
            var result = Run(expression);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void MatchChoiceIntegerToDecimal()
        {
            var choiceType = new ChoiceTypeSpecifier(SystemTypes.IntegerType, SystemTypes.StringType);
            var @as = new As { operand = Integer(1), asTypeSpecifier = choiceType }.WithResultType(choiceType);
            var arguments = new Expression[] { @as };
            var function = new SystemFunction<Expression>(new TypeSpecifier[] { SystemTypes.DecimalType }, SystemTypes.AnyType, "f");
            var result = InvocationBuilder.MatchSignature(function, arguments);
            result.Compatible.Should().BeTrue();
            Assert.AreEqual(CoercionCost.ImplicitToSimpleType, result.MostExpensive);
        }

        [TestMethod]
        public void MatchIntegerInIntervalAny()
        {
            var arguments = new Expression[] { Integer(), Interval(Null, Null) };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.In, arguments);
            result.Compatible.Should().BeTrue();
            Assert.AreEqual(CoercionCost.Cast, result.MostExpensive);
        }
        [TestMethod]
        public void MatchNullContainsIntegerAmibugious()
        {
            // null contains 5
            var arguments = new Expression[] { Null, Integer(5) };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.Contains, arguments);
            result.Compatible.Should().BeFalse();
            result.IsAmbiguous.Should().BeTrue();
        }

        [TestMethod]
        public void MatchEqualsListIntervals()
        {
            var list = List(Interval(Integer(1), Integer(2)));
            var arguments = new Expression[] { list, list };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.Equal, arguments);
            result.Compatible.Should().BeTrue();
        }

        [TestMethod]
        public void MatchPointFromNull()
        {
            var arguments = new Expression[] { Interval(Null, Null) };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.PointFrom, arguments);
            result.Compatible.Should().BeTrue();
        }

        [TestMethod]
        public void MatchStartFromFHIRPeriod()
        {
            var fpNts = new NamedTypeSpecifier { name = new System.Xml.XmlQualifiedName("{http://hl7.org/fhir}Period") };
            var nullAsFhirPeriod = new As
            {
                operand = Null,
                asType = new System.Xml.XmlQualifiedName("{http://hl7.org/fhir}Period")
            }.WithResultType(fpNts);
            var arguments = new Expression[] { nullAsFhirPeriod };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.Start, arguments);
            result.Compatible.Should().BeTrue();
        }


    }
}