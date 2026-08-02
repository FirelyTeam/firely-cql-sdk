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

        // Nothing unfused is left in the chain.
        Assert.IsInstanceOfType<CodeConstant>(inner.Arguments[0]);
    }

    #endregion

    #region Negative cases

    /// <summary>
    /// Fusion is only sound for a producer consumed as the consumer's <em>source</em>. A
    /// <c>Where</c> result sitting in <c>Except</c>'s second argument is a different value with a
    /// different contract, and must be left alone.
    /// </summary>
    [TestMethod]
    public void WhereResultAsNonSourceArgument_DoesNotFuse()
    {
        var binder = CreateBinder();
        var left = IntSource();
        var right = IntSource();
        var predicate = Predicate(typeof(int?));

        var where = binder.BindToMethod(nameof(ICqlOperators.Where), [right, predicate], []);
        var call = AssertOperatorsInvoke(binder.BindToMethod(nameof(ICqlOperators.Except), [left, where], []));

        Assert.AreEqual(nameof(ICqlOperators.Except), call.Method.Name);
        Assert.AreSame(left, call.Arguments[0]);
        // The Where call survives untouched in the non-source position.
        var producer = AssertOperatorsInvoke(call.Arguments[1]);
        Assert.AreEqual(nameof(ICqlOperators.Where), producer.Method.Name);
        Assert.AreSame(right, producer.Arguments[0]);
        Assert.AreSame(predicate, producer.Arguments[1]);
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
}
