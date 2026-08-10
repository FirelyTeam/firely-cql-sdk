/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.CodeModel;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging.Abstractions;

namespace CoreTests;

/// <summary>
/// Operator-fusion tests for <see cref="CqlOperatorsBinder"/> (issue #1484). Like
/// <see cref="CqlOperatorsBinderTests"/> these build small IR trees through the binder and assert
/// on the resulting IR shape — here, that the four immediately-consumed producer/consumer pairs
/// come back as a single fused call carrying the original source, predicate and selector nodes.
///
/// <para>Each test binds the producer first and feeds the resulting node to the consumer's bind,
/// which is exactly what the expression builder does when it walks nested ELM; fusion happens as
/// the consumer's call is constructed.</para>
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class CqlOperatorsBinderFusionTests
{
    private static CqlOperatorsBinder CreateBinder() => new(
        NullLogger<CqlOperatorsBinder>.Instance,
        new TestTypeResolver(),
        Hl7.Cql.Conversion.TypeConverter.Create());

    private static CodeInvoke AssertOperatorsInvoke(CodeExpression result)
    {
        var invoke = result as CodeInvoke;
        Assert.IsNotNull(invoke, $"Expected a CodeInvoke, got {result.GetType().Name}.");
        var receiver = invoke.Receiver as CodeProperty;
        Assert.IsNotNull(receiver, "Expected the receiver to be a property access.");
        Assert.AreEqual(nameof(CqlContext.Operators), receiver.Member.Name);
        Assert.IsInstanceOfType<CodeContextParameter>(receiver.Receiver);
        return invoke;
    }

    /// <summary>A source list of <c>int?</c>, the shape the corpus fuses most.</summary>
    private static CodeConstant IntSource() => new(new int?[] { 1, 2, 3 }, typeof(IEnumerable<int?>));

    /// <summary>A predicate lambda <c>Func&lt;<paramref name="over"/>, bool?&gt;</c>.</summary>
    private static CodeLambda Predicate(Type over) =>
        new([new CodeLocal(over, "x")], new CodeConstant(true, typeof(bool?)));

    /// <summary>A selector lambda <c>Func&lt;<paramref name="over"/>, string&gt;</c>.</summary>
    private static CodeLambda SelectorToString(Type over) =>
        new([new CodeLocal(over, "x")], new CodeConstant("s", typeof(string)));

    /// <summary>A selector lambda <c>Func&lt;<paramref name="over"/>, int?&gt;</c>.</summary>
    private static CodeLambda SelectorToInt(Type over) =>
        new([new CodeLocal(over, "x")], new CodeConstant(1, typeof(int?)));

    #region The four fusable shapes

    [TestMethod]
    public void Exists_OverWhere_FusesToWhereAny()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var predicate = Predicate(typeof(int?));

        var where = binder.BindToMethod(nameof(ICqlOperators.Where), [source, predicate], []);
        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Exists), [where], []));

        Assert.AreEqual(nameof(ICqlOperators.WhereAny), call.Method.Name);
        CollectionAssert.AreEqual(new[] { typeof(int?) }, call.Method.GetGenericArguments());
        Assert.AreEqual(typeof(bool?), call.Type);
        // The original nodes are carried over, not rebuilt.
        Assert.AreEqual(2, call.Arguments.Count);
        Assert.AreSame(source, call.Arguments[0]);
        Assert.AreSame(predicate, call.Arguments[1]);
    }

    [TestMethod]
    public void Select_OverWhere_FusesToWhereSelect()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var predicate = Predicate(typeof(int?));
        var selector = SelectorToString(typeof(int?));

        var where = binder.BindToMethod(nameof(ICqlOperators.Where), [source, predicate], []);
        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Select), [where, selector], []));

        Assert.AreEqual(nameof(ICqlOperators.WhereSelect), call.Method.Name);
        // T from Where, TR from Select's lambda body.
        CollectionAssert.AreEqual(new[] { typeof(int?), typeof(string) }, call.Method.GetGenericArguments());
        Assert.AreEqual(typeof(IEnumerable<string>), call.Type);
        Assert.AreEqual(3, call.Arguments.Count);
        Assert.AreSame(source, call.Arguments[0]);
        Assert.AreSame(predicate, call.Arguments[1]);
        Assert.AreSame(selector, call.Arguments[2]);
    }

    [TestMethod]
    public void Where_OverSelect_FusesToSelectWhere()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var selector = SelectorToString(typeof(int?));
        var predicate = Predicate(typeof(string));

        var select = binder.BindToMethod(nameof(ICqlOperators.Select), [source, selector], []);
        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Where), [select, predicate], []));

        Assert.AreEqual(nameof(ICqlOperators.SelectWhere), call.Method.Name);
        CollectionAssert.AreEqual(new[] { typeof(int?), typeof(string) }, call.Method.GetGenericArguments());
        Assert.AreEqual(typeof(IEnumerable<string>), call.Type);
        Assert.AreEqual(3, call.Arguments.Count);
        Assert.AreSame(source, call.Arguments[0]);
        Assert.AreSame(selector, call.Arguments[1]);
        Assert.AreSame(predicate, call.Arguments[2]);
    }

    [TestMethod]
    public void Distinct_OverSelect_FusesToSelectDistinct()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var selector = SelectorToString(typeof(int?));

        var select = binder.BindToMethod(nameof(ICqlOperators.Select), [source, selector], []);
        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Distinct), [select], []));

        Assert.AreEqual(nameof(ICqlOperators.SelectDistinct), call.Method.Name);
        CollectionAssert.AreEqual(new[] { typeof(int?), typeof(string) }, call.Method.GetGenericArguments());
        Assert.AreEqual(typeof(IEnumerable<string>), call.Type);
        Assert.AreEqual(2, call.Arguments.Count);
        Assert.AreSame(source, call.Arguments[0]);
        Assert.AreSame(selector, call.Arguments[1]);
    }

    #endregion

    #region Chains reach a fixpoint

    /// <summary>
    /// <c>Distinct(Select(Where(Select(s, f1), p), f2))</c> collapses to
    /// <c>SelectDistinct(SelectWhere(s, f1, p), f2)</c>: two fusions, four operator calls down to
    /// two. The middle <c>Select</c> cannot fuse with the <c>SelectWhere</c> beneath it (there is
    /// no <c>SelectWhereSelect</c>), so it survives as the producer the outer <c>Distinct</c> then
    /// fuses with — which is what makes the chain settle at two calls rather than one or three.
    /// </summary>
    [TestMethod]
    public void SelectWhereSelectDistinctChain_CollapsesToSelectWherePlusSelectDistinct()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var firstSelector = SelectorToString(typeof(int?));
        var predicate = Predicate(typeof(string));
        var secondSelector = SelectorToInt(typeof(string));

        var select1 = binder.BindToMethod(nameof(ICqlOperators.Select), [source, firstSelector], []);
        var where = binder.BindToMethod(nameof(ICqlOperators.Where), [select1, predicate], []);
        var select2 = binder.BindToMethod(nameof(ICqlOperators.Select), [where, secondSelector], []);
        var outer = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Distinct), [select2], []));

        Assert.AreEqual(nameof(ICqlOperators.SelectDistinct), outer.Method.Name);
        CollectionAssert.AreEqual(new[] { typeof(string), typeof(int?) }, outer.Method.GetGenericArguments());
        Assert.AreSame(secondSelector, outer.Arguments[1]);

        var inner = AssertOperatorsInvoke(outer.Arguments[0]);
        Assert.AreEqual(nameof(ICqlOperators.SelectWhere), inner.Method.Name);
        CollectionAssert.AreEqual(new[] { typeof(int?), typeof(string) }, inner.Method.GetGenericArguments());
        Assert.AreSame(source, inner.Arguments[0]);
        Assert.AreSame(firstSelector, inner.Arguments[1]);
        Assert.AreSame(predicate, inner.Arguments[2]);

        // Nothing unfused is left in the chain: the only two operator calls are the fused pair
        // above, and every argument they carry is a leaf (the source constant and the three
        // lambdas) rather than a surviving Where/Select.
        var operatorCalls = OperatorCallsIn(outer).ToList();
        CollectionAssert.AreEqual(
            new[] { nameof(ICqlOperators.SelectDistinct), nameof(ICqlOperators.SelectWhere) },
            operatorCalls.Select(c => c.Method.Name).ToArray());
    }

    /// <summary>Walks the operator calls reachable through argument positions, outermost first.</summary>
    private static IEnumerable<CodeInvoke> OperatorCallsIn(CodeExpression expression)
    {
        if (expression is not CodeInvoke invoke)
            yield break;

        yield return invoke;
        foreach (var argument in invoke.Arguments)
            foreach (var nested in OperatorCallsIn(argument))
                yield return nested;
    }

    #endregion

    #region Negative cases

    /// <summary>
    /// A <c>Where</c> result feeding an operator that has no fused equivalent stays a
    /// composition, wherever in the argument list it sits. <c>Fuse</c> declines this shape at
    /// whichever of its structural checks fires first — here that is argument 0 being a plain
    /// source constant rather than an operators call, so the consumer/producer pairing is never
    /// consulted. What this test pins is therefore the outcome, that a non-fusable consumer is
    /// left alone, and not any one check: the consumer half of the match is pinned by
    /// <see cref="WhereOverWhere_HasNoFusedEquivalent_AndIsLeftAlone"/>, the source-position guard
    /// by <see cref="ProducerInANonSourceArgument_IsUnrepresentableInTheIR"/>.
    /// </summary>
    [TestMethod]
    public void WhereResultConsumedByNonFusableOperator_DoesNotFuse()
    {
        var binder = CreateBinder();
        var left = IntSource();
        var right = IntSource();
        var predicate = Predicate(typeof(int?));

        var where = binder.BindToMethod(nameof(ICqlOperators.Where), [right, predicate], []);
        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Except), [left, where], []));

        Assert.AreEqual(nameof(ICqlOperators.Except), call.Method.Name);
        Assert.AreSame(left, call.Arguments[0]);
        // The Where call survives untouched.
        var producer = AssertOperatorsInvoke(call.Arguments[1]);
        Assert.AreEqual(nameof(ICqlOperators.Where), producer.Method.Name);
        Assert.AreSame(right, producer.Arguments[0]);
        Assert.AreSame(predicate, producer.Arguments[1]);
    }

    /// <summary>
    /// Fusion is only sound for a producer consumed as the consumer's <em>source</em>, so
    /// <c>Fuse</c> looks for the producer at argument 0 and nowhere else. That check is
    /// defence-in-depth against a future fusable consumer, not a live branch, and this test
    /// records why: all four fusable consumers take their list in position 0, and the only other
    /// parameter any of them declares is a lambda. A list-typed producer therefore cannot occupy
    /// a non-source argument of a fusable consumer — <see cref="CodeInvoke"/>'s constructor
    /// rejects the assignment, so the shape is unrepresentable in the IR rather than merely
    /// unreachable through the binder.
    ///
    /// <para>If a fused operator is ever added whose source is not argument 0, or whose second
    /// list parameter is a list, the assertions below stop holding and the source-position guard
    /// becomes load-bearing — at which point this test should be replaced by one that drives that
    /// shape through the binder.</para>
    /// </summary>
    [TestMethod]
    public void ProducerInANonSourceArgument_IsUnrepresentableInTheIR()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var selector = SelectorToString(typeof(int?));
        var predicate = Predicate(typeof(int?));

        var where = (CodeInvoke)binder.BindToMethod(nameof(ICqlOperators.Where), [source, predicate], []);
        var select = (CodeInvoke)binder.BindToMethod(nameof(ICqlOperators.Select), [source, selector], []);

        // Exists and Distinct have no non-source argument at all.
        var exists = (CodeInvoke)binder.BindToMethod(nameof(ICqlOperators.Exists), [source], []);
        var distinct = (CodeInvoke)binder.BindToMethod(nameof(ICqlOperators.Distinct), [source], []);
        Assert.AreEqual(1, exists.Method.GetParameters().Length);
        Assert.AreEqual(1, distinct.Method.GetParameters().Length);

        // Select's and Where's second parameter is a delegate, so a producer cannot be passed
        // there: the IR refuses to build the call.
        Assert.ThrowsException<ArgumentException>(
            () => new CodeInvoke(select.Receiver, select.Method, source, where),
            "Select's second parameter is a lambda; a Where result must not be assignable to it.");
        Assert.ThrowsException<ArgumentException>(
            () => new CodeInvoke(where.Receiver, where.Method, source, select),
            "Where's second parameter is a lambda; a Select result must not be assignable to it.");
    }

    /// <summary>
    /// Only the four pairs fuse. <c>Where</c> over <c>Where</c> is a real corpus shape (78 sites)
    /// with no fused equivalent yet, and must stay a composition.
    /// </summary>
    [TestMethod]
    public void WhereOverWhere_HasNoFusedEquivalent_AndIsLeftAlone()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var inner = binder.BindToMethod(nameof(ICqlOperators.Where), [source, Predicate(typeof(int?))], []);
        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Where), [inner, Predicate(typeof(int?))], []));

        Assert.AreEqual(nameof(ICqlOperators.Where), call.Method.Name);
        Assert.AreEqual(nameof(ICqlOperators.Where), AssertOperatorsInvoke(call.Arguments[0]).Method.Name);
    }

    /// <summary>
    /// A consumer whose source is not a fusable producer at all binds exactly as before.
    /// </summary>
    [TestMethod]
    public void ExistsOverPlainSource_BindsExists()
    {
        var binder = CreateBinder();
        var source = IntSource();

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Exists), [source], []));

        Assert.AreEqual(nameof(ICqlOperators.Exists), call.Method.Name);
        Assert.AreSame(source, call.Arguments.Single());
    }

    #endregion

    #region Declines — these are correctness guards, not missed optimizations

    /// <summary>
    /// A producer wrapped in a conversion must not fuse. The fused call takes the producer's own
    /// source and lambda, so it would have to re-derive the conversion the binder inserted around
    /// the producer's <em>result</em> — and there is no general way to push a result conversion
    /// back through the fused operator. Declining is the only safe answer.
    /// </summary>
    [TestMethod]
    public void CastWrappedProducer_DoesNotFuse()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var predicate = Predicate(typeof(int?));

        var where = binder.BindToMethod(nameof(ICqlOperators.Where), [source, predicate], []);
        var castWhere = new CodeCast(where, typeof(IEnumerable<int?>), CodeCastKind.Cast);

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Exists), [castWhere], []));

        Assert.AreEqual(nameof(ICqlOperators.Exists), call.Method.Name);
        Assert.AreSame(castWhere, call.Arguments.Single());
        // The Where under the cast is untouched.
        Assert.AreEqual(nameof(ICqlOperators.Where), AssertOperatorsInvoke(castWhere.Operand).Method.Name);
    }

    /// <summary>
    /// A null-conditional producer (<c>x?.Where(…)</c>) must not fuse: it short-circuits to null on
    /// a null receiver, which the fused operator — an ordinary call on the same receiver — would
    /// not reproduce.
    /// </summary>
    [TestMethod]
    public void NullConditionalProducer_DoesNotFuse()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var predicate = Predicate(typeof(int?));

        var where = (CodeInvoke)binder.BindToMethod(nameof(ICqlOperators.Where), [source, predicate], []);
        // Same receiver instance and same method — the only difference from the fusable case is
        // the null-conditional flag, so this isolates that one guard.
        var nullConditionalWhere = new CodeInvoke(
            where.Receiver,
            where.Method,
            nullConditional: true,
            [.. where.Arguments]);

        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Exists), [nullConditionalWhere], []));

        Assert.AreEqual(nameof(ICqlOperators.Exists), call.Method.Name);
        Assert.AreSame(nullConditionalWhere, call.Arguments.Single());
    }

    /// <summary>
    /// A legal but mismatched generic pair must not fuse. <c>Distinct&lt;object&gt;</c> over
    /// <c>Select&lt;int?, string&gt;</c> is a well-formed binding (<c>IEnumerable&lt;string&gt;</c>
    /// converts covariantly to <c>IEnumerable&lt;object&gt;</c>), but the consumer's element type is
    /// not the producer's projection type, so <c>SelectDistinct&lt;int?, object&gt;</c> would be the
    /// wrong operator.
    ///
    /// <para>Two independent guards cover this, and the assertions below record which one actually
    /// fires: because a covariant conversion is not an exact type match, the binder wraps the
    /// producer in a cast and the "producer must be the argument node" guard catches it first. The
    /// generic-argument cross-check in the <c>Fuse…</c> helpers is the backstop behind it, for
    /// callers that hand the fused rewrite an unwrapped mismatched pair.</para>
    /// </summary>
    [TestMethod]
    public void MismatchedGenericPair_DoesNotFuse()
    {
        var binder = CreateBinder();
        var source = IntSource();
        var selector = SelectorToString(typeof(int?));

        var select = (CodeInvoke)binder.BindToMethod(nameof(ICqlOperators.Select), [source, selector], []);
        CollectionAssert.AreEqual(new[] { typeof(int?), typeof(string) }, select.Method.GetGenericArguments());

        var call = AssertOperatorsInvoke(
            binder.BindToMethod(nameof(ICqlOperators.Distinct), [select], [typeof(object)]));

        Assert.AreEqual(nameof(ICqlOperators.Distinct), call.Method.Name);
        CollectionAssert.AreEqual(new[] { typeof(object) }, call.Method.GetGenericArguments());

        var cast = call.Arguments.Single() as CodeCast;
        Assert.IsNotNull(cast, "Expected the covariant conversion to wrap the producer in a cast.");
        Assert.AreSame(select, cast.Operand);
    }

    #endregion
}
