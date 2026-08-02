/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Operator fusion (issue #1484): rewrites the four producer/consumer pairs whose intermediate
/// list exists only to be walked once and dropped into the single-pass fused operator that
/// replaces them.
///
/// <list type="table">
/// <item><term><c>Exists(Where(s, p))</c></term><description><c>WhereAny(s, p)</c></description></item>
/// <item><term><c>Select(Where(s, p), f)</c></term><description><c>WhereSelect(s, p, f)</c></description></item>
/// <item><term><c>Where(Select(s, f), p)</c></term><description><c>SelectWhere(s, f, p)</c></description></item>
/// <item><term><c>Distinct(Select(s, f))</c></term><description><c>SelectDistinct(s, f)</c></description></item>
/// </list>
///
/// <para><b>Where this lives, and why.</b> Fusion runs on the IR, at the moment
/// <see cref="CqlOperatorsBinder.BindToMethod"/> finishes building the consumer's
/// <see cref="CodeInvoke"/>. Every operator call the expression builder produces is routed through
/// there, which makes it the one place to hook. Two internal helpers construct a
/// <see cref="CodeInvoke"/> without going through it — the boxing <c>Select</c> in
/// <c>ToObjectEnumerable</c> and the conversion call in <c>CqlOperatorsBinder.Conversions.cs</c> —
/// and neither costs a fusion: what matters is that the <em>consumer</em> is bound through
/// <c>BindToMethod</c>, and both of those produce nodes that are only ever consumed by a call that
/// is.</para>
///
/// <para><b>Fixpoint.</b> The IR is built bottom-up, so the producer is fully bound before its
/// consumer is built and each consumer sees the final form of its source. That is enough to
/// collapse chains in one sweep: <c>Select→Where→Select→Distinct</c> becomes <c>SelectWhere</c> +
/// <c>SelectDistinct</c>. Note that a fused node is never itself a recognized producer — only
/// <c>Where</c> and <c>Select</c> are — so fusion never cascades into a fused node, and the result
/// is stable rather than merely converged.</para>
///
/// <para><b>Greedy, not globally optimal.</b> Because the rewrite fires in bind order, the
/// innermost fusable pair wins. <c>Exists(Where(Select(s, f), p))</c> fuses the inner pair first
/// and settles as <c>Exists(SelectWhere(s, f, p))</c> rather than <c>WhereAny</c> over a
/// <c>Select</c>; either way exactly one intermediate list disappears, so the payoff is the same.
/// This is by design, not a missed case.</para>
///
/// <para><b>Single use is structural.</b> Fusion is only sound when the producer's result is
/// consumed exactly once. Here the producer *is* the consumer's source argument node, and a tree
/// node has exactly one parent — so nesting is the single-use proof, no aliasing analysis needed.
/// This is also why the producer must sit in the <em>source</em> position specifically: a
/// <c>Where</c> result appearing as, say, <c>Except</c>'s second argument is a different value
/// with a different consumer contract, and must not fuse.</para>
///
/// <para><b>Conservatism.</b> The producer has to be the argument node itself. If overload
/// resolution wrapped it in a conversion (a cast or a <c>Convert…</c> call), the pattern does not
/// match and nothing is rewritten — a fused call would have to re-derive that conversion, and
/// getting it silently wrong is worse than not fusing. A null-conditional producer
/// (<c>x?.Where(…)</c>) is likewise skipped: its result type and its short-circuit on a null
/// receiver are not what the fused operator would reproduce. The generic arguments of the fused
/// call are taken from the two original calls and cross-checked against each other; a mismatch
/// declines the rewrite, as does any failure to close the fused generic method or to accept the
/// original argument nodes. Each of these declines is pinned by a test in
/// <c>CqlOperatorsBinderFusionTests</c> — a regression in one is a miscompile, not a lost
/// optimization.</para>
///
/// <para>Semantics are unchanged by construction: the fused operators are non-short-circuiting and
/// invoke the same lambdas over the same elements as the composition they replace (see
/// <c>CqlOperators.FusedOperators.cs</c>).</para>
/// </summary>
partial class CqlOperatorsBinder
{
    private static readonly MethodInfo WhereMethod = ICqlOperatorsMethod(nameof(ICqlOperators.Where), 2);
    private static readonly MethodInfo SelectMethod = ICqlOperatorsMethod(nameof(ICqlOperators.Select), 2);
    private static readonly MethodInfo ExistsMethod = ICqlOperatorsMethod(nameof(ICqlOperators.Exists), 1);
    private static readonly MethodInfo DistinctMethod = ICqlOperatorsMethod(nameof(ICqlOperators.Distinct), 1);
    private static readonly MethodInfo WhereAnyMethod = ICqlOperatorsMethod(nameof(ICqlOperators.WhereAny), 2);
    private static readonly MethodInfo WhereSelectMethod = ICqlOperatorsMethod(nameof(ICqlOperators.WhereSelect), 3);
    private static readonly MethodInfo SelectWhereMethod = ICqlOperatorsMethod(nameof(ICqlOperators.SelectWhere), 3);
    private static readonly MethodInfo SelectDistinctMethod = ICqlOperatorsMethod(nameof(ICqlOperators.SelectDistinct), 2);

    private static MethodInfo ICqlOperatorsMethod(string name, int parameterCount)
    {
        var candidates = ICqlOperatorsMethods.GetMethodsByNameAndParamCount(name, parameterCount);
        return candidates.Count == 1
            ? candidates.Single()
            : throw new InvalidOperationException(
                $"Operator fusion expects exactly one {nameof(ICqlOperators)}.{name} overload with {parameterCount} parameter(s), found {candidates.Count}.");
    }

    /// <summary>
    /// Returns the fused equivalent of <paramref name="expression"/> when it is one of the four
    /// fusable producer/consumer pairs, and <paramref name="expression"/> itself otherwise.
    /// </summary>
    private CodeExpression Fuse(CodeExpression expression)
    {
        if (expression is not CodeInvoke consumer || !IsOperatorsCall(consumer))
            return expression;

        // The producer must be the consumer's source argument - argument 0 for all four shapes.
        if (consumer.Arguments.Count == 0
            || consumer.Arguments[0] is not CodeInvoke producer
            || !IsOperatorsCall(producer))
            return expression;

        var consumerDefinition = GenericDefinitionOf(consumer.Method);
        var producerDefinition = GenericDefinitionOf(producer.Method);

        var fused = (consumerDefinition, producerDefinition) switch
        {
            _ when consumerDefinition == ExistsMethod && producerDefinition == WhereMethod =>
                FuseWhereAny(consumer, producer),
            _ when consumerDefinition == SelectMethod && producerDefinition == WhereMethod =>
                FuseWhereSelect(consumer, producer),
            _ when consumerDefinition == WhereMethod && producerDefinition == SelectMethod =>
                FuseSelectWhere(consumer, producer),
            _ when consumerDefinition == DistinctMethod && producerDefinition == SelectMethod =>
                FuseSelectDistinct(consumer, producer),
            _ => null,
        };

        if (fused is null)
            return expression;

        _logger.LogDebug(
            "Fused {producer} into {consumer}, emitting {fused}.",
            producer.Method.Name,
            consumer.Method.Name,
            fused.Method.Name);

        return fused;
    }

    private static bool IsOperatorsCall(CodeInvoke invoke) =>
        ReferenceEquals(invoke.Receiver, OperatorsReceiver)
        && invoke.Method.DeclaringType == typeof(ICqlOperators)
        && !invoke.NullConditional;

    private static MethodInfo? GenericDefinitionOf(MethodInfo method) =>
        method.IsGenericMethod ? method.GetGenericMethodDefinition() : method;

    /// <summary><c>Exists&lt;T&gt;(Where&lt;T&gt;(s, p))</c> → <c>WhereAny&lt;T&gt;(s, p)</c>.</summary>
    private static CodeInvoke? FuseWhereAny(CodeInvoke exists, CodeInvoke where)
    {
        var t = where.Method.GetGenericArguments()[0];

        // Exists' own type argument is the element type it read off the Where result; if overload
        // resolution landed somewhere else, the shapes are not the pair we think they are.
        if (exists.Method.GetGenericArguments()[0] != t)
            return null;

        return TryBuild(WhereAnyMethod, [t], [where.Arguments[0], where.Arguments[1]]);
    }

    /// <summary><c>Select&lt;T, TR&gt;(Where&lt;T&gt;(s, p), f)</c> → <c>WhereSelect&lt;T, TR&gt;(s, p, f)</c>.</summary>
    private static CodeInvoke? FuseWhereSelect(CodeInvoke select, CodeInvoke where)
    {
        var t = where.Method.GetGenericArguments()[0];
        var selectTypeArguments = select.Method.GetGenericArguments();
        if (selectTypeArguments[0] != t)
            return null;
        var tr = selectTypeArguments[1];

        return TryBuild(
            WhereSelectMethod,
            [t, tr],
            [where.Arguments[0], where.Arguments[1], select.Arguments[1]]);
    }

    /// <summary><c>Where&lt;TR&gt;(Select&lt;T, TR&gt;(s, f), p)</c> → <c>SelectWhere&lt;T, TR&gt;(s, f, p)</c>.</summary>
    private static CodeInvoke? FuseSelectWhere(CodeInvoke where, CodeInvoke select)
    {
        var selectTypeArguments = select.Method.GetGenericArguments();
        var (t, tr) = (selectTypeArguments[0], selectTypeArguments[1]);
        if (where.Method.GetGenericArguments()[0] != tr)
            return null;

        return TryBuild(
            SelectWhereMethod,
            [t, tr],
            [select.Arguments[0], select.Arguments[1], where.Arguments[1]]);
    }

    /// <summary><c>Distinct&lt;TR&gt;(Select&lt;T, TR&gt;(s, f))</c> → <c>SelectDistinct&lt;T, TR&gt;(s, f)</c>.</summary>
    private static CodeInvoke? FuseSelectDistinct(CodeInvoke distinct, CodeInvoke select)
    {
        var selectTypeArguments = select.Method.GetGenericArguments();
        var (t, tr) = (selectTypeArguments[0], selectTypeArguments[1]);
        if (distinct.Method.GetGenericArguments()[0] != tr)
            return null;

        return TryBuild(
            SelectDistinctMethod,
            [t, tr],
            [select.Arguments[0], select.Arguments[1]]);
    }

    /// <summary>
    /// Closes the fused generic method over <paramref name="typeArguments"/> and builds the call,
    /// declining the rewrite (rather than failing the compilation) if either step rejects what we
    /// handed it — an unsatisfiable generic constraint as much as an argument that does not fit the
    /// fused signature. The composed form the caller already holds is always a valid fallback, so a
    /// shape we did not anticipate costs a missed optimization and nothing else.
    /// </summary>
    private static CodeInvoke? TryBuild(MethodInfo fusedMethod, Type[] typeArguments, CodeExpression[] arguments)
    {
        try
        {
            return new CodeInvoke(OperatorsReceiver, fusedMethod.MakeGenericMethod(typeArguments), arguments);
        }
        catch (ArgumentException)
        {
            return null;
        }
    }
}
