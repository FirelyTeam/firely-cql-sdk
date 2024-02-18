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

        private static GenericTypeSpecifier Generic(string argumentName = "T") => new GenericTypeSpecifier(argumentName);

        private static Literal Boolean(bool value = true) => new Literal { value = value.ToString() }.WithResultType(SystemTypes.BooleanType);
        private static Literal Integer(int value = 1) => new Literal { value = value.ToString() }.WithResultType(SystemTypes.IntegerType);
        private static Literal Decimal(decimal value = 1m) => new Literal { value = value.ToString() }.WithResultType(SystemTypes.DecimalType);
        private static Quantity Quantity(decimal value = 1) => new Quantity { value = value, unit = "1"}.WithResultType(SystemTypes.QuantityType);
        private static Elm.DateTime DateTime() => new Elm.DateTime { year = Integer(2024) }.WithResultType(SystemTypes.DateTimeType);

        private static List List(Expression first, params Expression[] elements) => new List { element = new[] { first }.Concat(elements).ToArray() }.WithResultType(first.resultTypeSpecifier.ToListType());
        private static Interval Interval(Expression low, Expression high) => new Interval { low = low, high = high }.WithResultType(low.resultTypeSpecifier.ToIntervalType());
        private static readonly Null Null = new Null().WithResultType(SystemTypes.AnyType);


        private static void AssertCompatible(FunctionDef function, Expression[] arguments, ConversionCost mostExpensive, int? totalCost = null)
        {
            var result = InvocationBuilder.MatchSignature(function, arguments);
            Assert.IsTrue(result.Compatible);
            Assert.AreEqual(mostExpensive, result.MostExpensive);
            if (totalCost != null)
                Assert.AreEqual(totalCost.Value, result.TotalCost);
            Assert.AreEqual(SignatureMatchFlags.None, result.Flags);
        }

        [TestMethod]
        public void MatchAnd()
        {
            var arguments = new[] { Boolean(), Boolean() };
            AssertCompatible(SystemLibrary.And, arguments, ConversionCost.ExactMatch);
        }

        [TestMethod]
        public void TooFewArguments()
        {
            var arguments = new[] { Boolean() };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.And, arguments);
            Assert.IsFalse(result.Compatible);
            Assert.IsTrue(result.HasTooFewArguments);
        }

        [TestMethod]
        public void TooManyArguments()
        {
            var arguments = new[] { Boolean(), Boolean(), Boolean() };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.And, arguments);
            Assert.IsFalse(result.Compatible);
            Assert.IsTrue(result.HasTooManyArguments);
        }

        [TestMethod]
        public void MatchNow()
        {
            var arguments = Array.Empty<Expression>();
            AssertCompatible(SystemLibrary.Now, arguments, ConversionCost.ExactMatch);

        }

        [TestMethod]
        public void MatchDate()
        {
            Expression[] arguments = new[] { Integer(2023) };
            var result = InvocationBuilder.MatchSignature(SystemLibrary.Date, arguments);
            AssertCompatible(SystemLibrary.Date, arguments, ConversionCost.ExactMatch);

            arguments = new[] { Integer(2023), Integer(1) };
            AssertCompatible(SystemLibrary.Date, arguments, ConversionCost.ExactMatch);

            arguments = new[] { Integer(2023), Integer(2), Integer(14) };
            AssertCompatible(SystemLibrary.Date, arguments, ConversionCost.ExactMatch);

            arguments = Array.Empty<Expression>();
            result = InvocationBuilder.MatchSignature(SystemLibrary.Date, arguments);
            Assert.IsFalse(result.Compatible);
            Assert.IsTrue(result.HasTooFewArguments);

            arguments = new[] { Integer(2023), Integer(2), Integer(14), Integer(10) };
            result = InvocationBuilder.MatchSignature(SystemLibrary.Date, arguments);
            Assert.IsFalse(result.Compatible);
            Assert.IsTrue(result.HasTooManyArguments);
        }
        
        [TestMethod]
        public void MatchSimpleGeneric()
        {
            var T = Generic();
            var function = new SystemFunction<Abs>(new[] { T }, T);
            var arguments = new[] { Integer(1) };
            var inference = InvocationBuilder.InferGenericArgument(function.operand[0].resultTypeSpecifier, arguments[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.typeArgumentName));
            Assert.AreEqual(SystemTypes.IntegerType, inference[T.typeArgumentName]);
            AssertCompatible(function, arguments, ConversionCost.ExactMatch);


            arguments = new[] { Decimal(1) };
            inference = InvocationBuilder.InferGenericArgument(function.operand[0].resultTypeSpecifier, arguments[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.typeArgumentName));
            Assert.AreEqual(SystemTypes.DecimalType, inference[T.typeArgumentName]);
            AssertCompatible(function, arguments, ConversionCost.ExactMatch);
        }

        [TestMethod]
        public void MatchGenericListArgument()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new[] { T.ToListType() }, T);
            var arguments = new[] { List(Integer(1)) };
            var inference = InvocationBuilder.InferGenericArgument(function.operand[0].resultTypeSpecifier, arguments[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.typeArgumentName));
            Assert.AreEqual(SystemTypes.IntegerType, inference[T.typeArgumentName]);
            AssertCompatible(function, arguments, ConversionCost.ExactMatch);
        }



        [TestMethod]
        public void MatchGenericIntervalArgument()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new[] { T.ToIntervalType() }, T);
            var arguments = new[] { Interval(Integer(1), Integer(10)) };
            var inference = InvocationBuilder.InferGenericArgument(function.operand[0].resultTypeSpecifier, arguments[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.typeArgumentName));
            Assert.AreEqual(SystemTypes.IntegerType, inference[T.typeArgumentName]);
            AssertCompatible(function, arguments, ConversionCost.ExactMatch);

        }
        [TestMethod]
        public void MatchGenericNestedListArgument()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new[] { T.ToListType().ToListType() }, T);
            var arguments = new[] { List(List(Integer(1))) };
            var inference = InvocationBuilder.InferGenericArgument(function.operand[0].resultTypeSpecifier, arguments[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.typeArgumentName));
            Assert.AreEqual(SystemTypes.IntegerType, inference[T.typeArgumentName]);
            AssertCompatible(function, arguments, ConversionCost.ExactMatch);
        }

        [TestMethod]
        public void MatchGenericListAndAny()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new TypeSpecifier[] { T.ToListType(), SystemTypes.AnyType }, SystemTypes.BooleanType);
            var arguments = new[] { List(Null), List(Null) };
            var inference = InvocationBuilder.InferGenericArgument(function.operand[0].resultTypeSpecifier, arguments[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.typeArgumentName));
            Assert.AreEqual(SystemTypes.AnyType, inference[T.typeArgumentName]);
            var result = InvocationBuilder.MatchSignature(function, arguments);
            Assert.AreEqual(ConversionCost.ExactMatch, result.Arguments[0].Cost);
            Assert.AreEqual(ConversionCost.ListDemotion, result.Arguments[1].Cost);
        }
        [TestMethod]
        public void MatchGenericListAndT()
        {
            var T = Generic();
            var function = new SystemFunction<Expression>(new TypeSpecifier[] { T.ToListType(), T }, SystemTypes.BooleanType);
            var arguments = new Expression[] { List(Null), List(Null) };
            var inference = InvocationBuilder.InferGenericArgument(function.operand[0].resultTypeSpecifier, arguments[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.typeArgumentName));
            Assert.AreEqual(SystemTypes.AnyType, inference[T.typeArgumentName]);
            var result = InvocationBuilder.MatchSignature(function, arguments);
            Assert.AreEqual(ConversionCost.ExactMatch, result.Arguments[0].Cost);
            Assert.AreEqual(ConversionCost.ListDemotion, result.Arguments[1].Cost);
            Assert.AreEqual(ConversionCost.ListDemotion, result.MostExpensive);

            // These arguments are cheaper than passing two lists.
            // Because in both cases T is inferred to be Any, in the two list case, this results in a List Demotion to T.
            // In the second case, no list demotion is necessary and Any exactly matches Any.
            arguments = new Expression[] { List(Null), Null };
            inference = InvocationBuilder.InferGenericArgument(function.operand[0].resultTypeSpecifier, arguments[0].resultTypeSpecifier);
            Assert.AreEqual(1, inference.Count);
            Assert.IsTrue(inference.ContainsKey(T.typeArgumentName));
            Assert.AreEqual(SystemTypes.AnyType, inference[T.typeArgumentName]);
            result = InvocationBuilder.MatchSignature(function, arguments);
            Assert.AreEqual(ConversionCost.ExactMatch, result.Arguments[0].Cost);
            Assert.AreEqual(ConversionCost.ExactMatch, result.Arguments[1].Cost);
            Assert.AreEqual(ConversionCost.ExactMatch, result.MostExpensive);
        }

        [TestMethod]
        public void MatchInvalidAddSignature()
        {
            var arguments = new Expression[] { Quantity(), DateTime() };
            var result = InvocationBuilder.SelectBestOverload(SystemLibrary.Add, arguments);
            Assert.IsFalse(result.Compatible);
        }
    }
}