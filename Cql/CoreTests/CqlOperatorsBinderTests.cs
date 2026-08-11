/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.CodeModel;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Microsoft.Extensions.Logging.Abstractions;

namespace CoreTests;

/// <summary>
/// Unit tests for <see cref="CqlOperatorsBinder"/> (and <see cref="CqlContextBinder"/>).
/// The tests build small IR argument trees directly via the
/// <c>Hl7.Cql.Compiler.CodeModel.*</c> node constructors and assert on the resulting IR shape
/// (bound method, generic arguments, inserted conversions, null padding) — not on emitted
/// text; the binder's contract is the overload-resolution outcome.
/// </summary>
[TestClass]
public class CqlOperatorsBinderTests
{
    private static CqlOperatorsBinder CreateBinder() => new(
        NullLogger<CqlOperatorsBinder>.Instance,
        new TestTypeResolver(),
        Hl7.Cql.Conversion.TypeConverter.Create());

    /// <summary>Asserts the call is an <see cref="CodeInvoke"/> on <c>context.Operators</c>
    /// (an <see cref="CodeProperty"/> over the <see cref="CodeContextParameter"/>) and returns it.</summary>
    private static CodeInvoke AssertOperatorsInvoke(CodeExpression result)
    {
        var invoke = result as CodeInvoke;
        Assert.IsNotNull(invoke, $"Expected an CodeInvoke, got {result.GetType().Name}.");
        var receiver = invoke.Receiver as CodeProperty;
        Assert.IsNotNull(receiver, "Expected the receiver to be a property access.");
        Assert.AreEqual(nameof(CqlContext.Operators), receiver.Member.Name);
        Assert.IsInstanceOfType<CodeContextParameter>(receiver.Receiver);
        return invoke;
    }

    [TestMethod]
    public void Add_Int32Arguments_BindsExactOverloadWithoutConversions()
    {
        var binder = CreateBinder();
        var left = new CodeConstant(1, typeof(int?));
        var right = new CodeConstant(2, typeof(int?));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Add), [left, right], []));

        Assert.AreEqual(nameof(ICqlOperators.Add), call.Method.Name);
        Assert.IsFalse(call.Method.IsGenericMethod);
        CollectionAssert.AreEqual(
            new[] { typeof(int?), typeof(int?) },
            call.Method.GetParameters().Select(p => p.ParameterType).ToArray());
        // An exact match passes the argument nodes through unchanged (no casts inserted).
        Assert.AreEqual(2, call.Arguments.Count);
        Assert.AreSame(left, call.Arguments[0]);
        Assert.AreSame(right, call.Arguments[1]);
    }

    [TestMethod]
    public void Add_MixedIntAndDecimal_ConversionScoringPicksDecimalOverload()
    {
        // int? + decimal?: no exact overload. Add(decimal?, decimal?) wins on score (one
        // OperatorConvert + one ExactType) over Add(CqlQuantity?, CqlQuantity?) (two
        // OperatorConverts); the int? argument is wrapped in ConvertIntegerToDecimal.
        var binder = CreateBinder();
        var left = new CodeConstant(1, typeof(int?));
        var right = new CodeConstant(2.5m, typeof(decimal?));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Add), [left, right], []));

        CollectionAssert.AreEqual(
            new[] { typeof(decimal?), typeof(decimal?) },
            call.Method.GetParameters().Select(p => p.ParameterType).ToArray());
        var convert = AssertOperatorsInvoke(call.Arguments[0]);
        Assert.AreEqual(nameof(ICqlOperators.ConvertIntegerToDecimal), convert.Method.Name);
        Assert.AreSame(left, convert.Arguments[0]);
        Assert.AreSame(right, call.Arguments[1]);
    }

    [TestMethod]
    public void SingletonFrom_EnumerableArgument_InfersGenericTypeFromElement()
    {
        // SingletonFrom<T>(IEnumerable<T>?) has no explicit type args at the call site: the
        // binder infers T by trying the argument's type and then its single generic argument.
        var binder = CreateBinder();
        var source = new CodeConstant(new int?[] { 1, 2 }, typeof(IEnumerable<int?>));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.SingletonFrom), [source], []));

        Assert.AreEqual(nameof(ICqlOperators.SingletonFrom), call.Method.Name);
        Assert.IsTrue(call.Method.IsGenericMethod);
        Assert.AreEqual(typeof(int?), call.Method.GetGenericArguments().Single());
        Assert.AreEqual(typeof(int?), call.Type);
        Assert.AreSame(source, call.Arguments.Single());
    }

    [TestMethod]
    public void ListIncludesElement_NonGenericArgumentTypes_InfersElementTypeFromSecondParameter()
    {
        // Regression test for #1341. ListIncludesElement<T>(IEnumerable<T>? left, T right):
        // the left argument's type is an array (not IsGenericType) and the right argument's
        // type is a plain class (also not IsGenericType), so the only inference source is the
        // genericity of the parameter in the RIGHT argument's position (the bare T). The old
        // probe indexed methodParameters with the outer retry-pass index instead of the
        // argument index, so while probing argument 1 it checked parameter 0 (IEnumerable<T>,
        // not a bare generic parameter), yielded no candidate type arguments, and failed to
        // bind this shape at all.
        var binder = CreateBinder();
        var left = new CodeConstant(System.Array.Empty<CqlCode>(), typeof(CqlCode[]));
        var right = new CodeConstant(new CqlCode("a", "s"), typeof(CqlCode));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.ListIncludesElement), [left, right], []));

        Assert.AreEqual(nameof(ICqlOperators.ListIncludesElement), call.Method.Name);
        Assert.IsTrue(call.Method.IsGenericMethod);
        Assert.AreEqual(typeof(CqlCode), call.Method.GetGenericArguments().Single());
    }

    [TestMethod]
    public void Where_LambdaArgument_BindsGenericMethodWithInferredElementType()
    {
        // Where<T>(IEnumerable<T>?, Func<T, bool?>): the specialized Where binding infers T
        // from the source's element type, and the CodeLambda (whose Type is Func<int?, bool?>)
        // binds to the delegate parameter without conversion.
        var binder = CreateBinder();
        var source = new CodeConstant(new int?[] { 1, 2 }, typeof(IEnumerable<int?>));
        var parameter = new CodeLocal(typeof(int?), "x");
        var lambda = new CodeLambda([parameter], new CodeConstant(true, typeof(bool?)));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Where), [source, lambda], []));

        Assert.AreEqual(nameof(ICqlOperators.Where), call.Method.Name);
        Assert.IsTrue(call.Method.IsGenericMethod);
        Assert.AreEqual(typeof(int?), call.Method.GetGenericArguments().Single());
        Assert.AreEqual(typeof(Func<int?, bool?>), call.Method.GetParameters()[1].ParameterType);
        Assert.AreSame(lambda, call.Arguments[1]);
    }

    [TestMethod]
    public void Add_TrailingNullConstant_RetriesWithoutLastArgument()
    {
        // No 3-parameter Add overload exists; because the last argument is a null constant,
        // the resolver retries without it (the trailing-null precision mechanism) and binds
        // the 2-parameter overload.
        var binder = CreateBinder();
        var left = new CodeConstant(1, typeof(int?));
        var right = new CodeConstant(2, typeof(int?));
        var trailingNull = new CodeConstant(null, typeof(object));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Add), [left, right, trailingNull], []));

        Assert.AreEqual(nameof(ICqlOperators.Add), call.Method.Name);
        Assert.AreEqual(2, call.Arguments.Count);
        Assert.AreSame(left, call.Arguments[0]);
        Assert.AreSame(right, call.Arguments[1]);
    }

    [TestMethod]
    public void DurationBetween_NullPrecision_RebindsNullConstantToParameterType()
    {
        // A 3-parameter overload does exist here, so the trailing null is not dropped;
        // instead the untyped (object) null constant is re-typed to the string? precision
        // parameter during argument conversion.
        var binder = CreateBinder();
        var low = new CodeConstant(new CqlDate(2020, 1, 1), typeof(CqlDate));
        var high = new CodeConstant(new CqlDate(2021, 1, 1), typeof(CqlDate));
        var precision = new CodeConstant(null, typeof(object));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.DurationBetween), [low, high, precision], []));

        Assert.AreEqual(nameof(ICqlOperators.DurationBetween), call.Method.Name);
        CollectionAssert.AreEqual(
            new[] { typeof(CqlDate), typeof(CqlDate), typeof(string) },
            call.Method.GetParameters().Select(p => p.ParameterType).ToArray());
        Assert.AreEqual(3, call.Arguments.Count);
        var boundPrecision = call.Arguments[2] as CodeConstant;
        Assert.IsNotNull(boundPrecision);
        Assert.IsNull(boundPrecision.Value);
        Assert.AreEqual(typeof(string), boundPrecision.Type);
    }

    [TestMethod]
    public void Coalesce_StringList_DispatchesToUnconstrainedGenericCoalesce()
    {
        // Name-dispatch: "Coalesce" routes through the specialized binding, which constructs
        // Coalesce<T> with T = the list's element type.
        var binder = CreateBinder();
        var source = new CodeConstant(new string?[] { "hello", null }, typeof(IEnumerable<string>));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Coalesce), [source], []));

        Assert.AreEqual(nameof(ICqlOperators.Coalesce), call.Method.Name);
        Assert.AreEqual(typeof(string), call.Method.GetGenericArguments().Single());
        Assert.AreSame(source, call.Arguments.Single());
    }

    [TestMethod]
    public void Coalesce_NonNullableValueTypeList_Throws()
    {
        // Coalesce<T> requires T to be a reference type or Nullable<U>.
        var binder = CreateBinder();
        var source = new CodeConstant(new[] { 1, 2, 3 }, typeof(IEnumerable<int>));

        var exception = Assert.ThrowsException<ArgumentException>(() =>
            binder.BindToMethod(nameof(ICqlOperators.Coalesce), [source], []));
        StringAssert.Contains(exception.Message, "reference type or Nullable<U>");
    }

    [TestMethod]
    public void Coalesce_NullableValueTupleList_UsesCoalesceWithNullableElementType()
    {
        // Regression test (#1307/#1313): Coalesce over a list of nullable value tuples must
        // bind to the unconstrained Coalesce<T> with T = the nullable tuple type, so the
        // no-match result is null.
        var binder = CreateBinder();
        var source = new CodeConstant(
            new (int? isHighRisk, int? isInconclusive, DateOnly? eventDate)?[]
            {
                ((int?)1, null, new DateOnly(2026, 6, 11)),
                null
            },
            typeof((int?, int?, DateOnly?)?[]));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Coalesce), [source], []));

        Assert.AreEqual(nameof(ICqlOperators.Coalesce), call.Method.Name);
        Assert.AreEqual(typeof((int?, int?, DateOnly?)?), call.Method.GetGenericArguments().Single());
    }

    [TestMethod]
    public void Coalesce_HedisNullableTupleList_UsesCoalesceWithNullableElementType()
    {
        // Regression test (#1307/#1313): exact HEDIS 2025 shape that previously failed with
        // CS0452.
        var binder = CreateBinder();
        IEnumerable<(CqlTupleMetadata, bool? isInpatient, bool? isEdVisit, CqlInterval<CqlDate>? inpatientPeriod, CqlDate historyReferenceDate, CqlDate episodeDate)?> source =
        [
            (new CqlTupleMetadata(), true, false, null, new CqlDate(2026, 6, 11), new CqlDate(2026, 6, 12)),
            null
        ];

        var sourceConstant = new CodeConstant(
            source,
            typeof(IEnumerable<(CqlTupleMetadata, bool? isInpatient, bool? isEdVisit, CqlInterval<CqlDate>? inpatientPeriod, CqlDate historyReferenceDate, CqlDate episodeDate)?>));

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Coalesce), [sourceConstant], []));

        Assert.AreEqual(nameof(ICqlOperators.Coalesce), call.Method.Name);
        Assert.AreEqual(typeof((CqlTupleMetadata, bool?, bool?, CqlInterval<CqlDate>, CqlDate, CqlDate)?), call.Method.GetGenericArguments().Single());
    }

    [TestMethod]
    public void ToList_OnListTypedArgument_ReturnsOperandUnchanged()
    {
        // Name-dispatch: "ToList" over something that is already a list short-circuits and
        // returns the operand itself instead of binding an operator call.
        var binder = CreateBinder();
        var source = new CodeConstant(new int?[] { 1 }, typeof(IEnumerable<int?>));

        var result = binder.BindToMethod("ToList", [source], []);

        Assert.AreSame(source, result);
    }

    [TestMethod]
    public void UnknownMethod_Throws()
    {
        // Invalid bindings surface as CannotBindToCqlOperatorError, so the exception is a
        // typed CqlException rather than a plain InvalidOperationException.
        var binder = CreateBinder();
        var argument = new CodeConstant(1, typeof(int?));

        var exception = Assert.ThrowsException<CqlException<Hl7.Cql.Compiler.CannotBindToCqlOperatorError>>(() =>
            binder.BindToMethod("ThisMethodDoesNotExist", [argument], []));
        StringAssert.Contains(exception.Message, "No suitable method could be bound");
    }

    [TestMethod]
    public void BoundCall_ReceiverIsOperatorsPropertyOnContextParameter()
    {
        var binder = CreateBinder();
        var argument = new CodeConstant(1, typeof(int?));

        var call = (CodeInvoke)binder.BindToMethod(nameof(ICqlOperators.Abs), [argument], []);

        var receiver = call.Receiver as CodeProperty;
        Assert.IsNotNull(receiver);
        Assert.IsInstanceOfType<PropertyInfo>(receiver.Member);
        Assert.AreEqual(nameof(CqlContext.Operators), receiver.Member.Name);
        Assert.AreEqual(typeof(ICqlOperators), receiver.Type);
        Assert.AreSame(CodeContextParameter.Instance, receiver.Receiver);
    }

    [TestMethod]
    public void Union_ValueSetFacades_InsertsSafeCastsToEnumerableOfCode()
    {
        // The specialized Union binding safe-casts both IValueSetFacade operands to
        // IEnumerable<CqlCode> and binds ValueSetUnion.
        var binder = CreateBinder();
        var left = new CodeConstant(null, typeof(IValueSetFacade));
        var right = new CodeConstant(null, typeof(IValueSetFacade));

        var call = AssertOperatorsInvoke(binder.BindToMethod("Union", [left, right], []));

        Assert.AreEqual(nameof(ICqlOperators.ValueSetUnion), call.Method.Name);
        foreach (var argument in call.Arguments)
        {
            var cast = argument as CodeCast;
            Assert.IsNotNull(cast, $"Expected an CodeCast argument, got {argument.GetType().Name}.");
            Assert.AreEqual(CodeCastKind.As, cast.Kind);
            Assert.AreEqual(typeof(IEnumerable<CqlCode>), cast.Type);
        }
    }

    [TestMethod]
    public void ConvertToType_IntToDecimal_BindsConversionOperator()
    {
        // The TryConvert path: no assignment conversion exists from int? to decimal?, so the
        // binder falls back to the CqlOperators conversion function.
        var binder = CreateBinder();
        var operand = new CodeConstant(1, typeof(int?));

        var result = binder.ConvertToType(operand, typeof(decimal?));

        var convert = AssertOperatorsInvoke(result);
        Assert.AreEqual(nameof(ICqlOperators.ConvertIntegerToDecimal), convert.Method.Name);
        Assert.AreEqual(typeof(decimal?), convert.Type);
        Assert.AreSame(operand, convert.Arguments.Single());
    }

    [TestMethod]
    public void ContextBinder_ResolveParameter_BindsCqlContextMethod()
    {
        var binder = new CqlContextBinder();
        var defaultValue = new CodeConstant(null, typeof(object));

        var call = (CodeInvoke)binder.ResolveParameter("MyLib-1.0.0", "Measurement Period", defaultValue);

        Assert.AreSame(CodeContextParameter.Instance, call.Receiver);
        Assert.AreEqual(nameof(CqlContext.ResolveParameter), call.Method.Name);
        Assert.AreEqual(3, call.Arguments.Count);
        Assert.AreEqual("MyLib-1.0.0", ((CodeConstant)call.Arguments[0]).Value);
        Assert.AreEqual("Measurement Period", ((CodeConstant)call.Arguments[1]).Value);
        Assert.AreSame(defaultValue, call.Arguments[2]);
    }

    [TestMethod]
    public void Flatten_NestedList_BindsGenericFlattenWithNestedElementType()
    {
        var binder = CreateBinder();
        var source = new CodeConstant(
            new List<List<int?>>(),
            typeof(IEnumerable<IEnumerable<int?>>));

        var call = AssertOperatorsInvoke(binder.BindToMethod("Flatten", [source], []));

        Assert.AreEqual(nameof(ICqlOperators.Flatten), call.Method.Name);
        Assert.AreEqual(typeof(int?), call.Method.GetGenericArguments().Single());

        // Flatten over an already-flat list returns the operand unchanged.
        var flat = new CodeConstant(new int?[] { 1 }, typeof(IEnumerable<int?>));
        Assert.AreSame(flat, binder.BindToMethod("Flatten", [flat], []));
    }
}
