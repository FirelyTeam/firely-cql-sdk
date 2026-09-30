/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Narrowing a reference by an <see cref="Elm.Is"/> test. Within the branch of a <c>case</c> or
/// <c>if</c> guarded by <c>x is T</c>, the value of <c>x</c> is a <c>T</c>, so the <c>case</c> is a
/// type switch over <c>x</c> whose arms bind <c>x</c> as a <c>T</c>.
/// </summary>
/// <remarks>
/// A reference is a function operand, a query alias or a <c>let</c>. ELM is free of side effects,
/// so every mention of one within a branch denotes the value the test inspected. Inside the branch
/// the reference translates to the arm's narrowed variable: <c>x as T</c> is that variable itself,
/// and a property of <c>x</c> binds against <c>T</c> rather than dispatching over the alternatives of
/// <c>x</c>'s type. This only makes static types more precise; no value changes.
/// </remarks>
partial class CodeBuilderContext
{
    /// <summary>
    /// The variable each narrowed reference stands for within the branch being translated, by the
    /// value the reference resolves to outside it (see <see cref="ResolveReference"/>). A reference
    /// narrowed again inside a branch is keyed by its outer narrowed variable.
    /// </summary>
    private readonly Dictionary<CodeExpression, CodeLocal> _narrowings = new(ReferenceEqualityComparer.Instance);

    /// <summary>What a reference bound to <paramref name="bound"/> stands for in the branch being translated.</summary>
    private CodeExpression Narrowed(CodeExpression bound)
    {
        while (_narrowings.TryGetValue(bound, out var narrowed))
            bound = narrowed;
        return bound;
    }

    /// <summary>Translates <paramref name="branch"/> with <paramref name="reference"/> standing for <paramref name="narrowed"/>.</summary>
    private CodeExpression TranslateNarrowed(Expression branch, CodeExpression reference, CodeLocal narrowed)
    {
        _narrowings.Add(reference, narrowed);
        try
        {
            return TranslateArg(branch);
        }
        finally
        {
            _narrowings.Remove(reference);
        }
    }

    /// <summary>
    /// The reference <paramref name="condition"/> tests and the type it tests for, when it is an
    /// <see cref="Elm.Is"/> test of a reference for a single type.
    /// </summary>
    private (Expression Reference, Type Tested)? NarrowingTest(Expression? condition)
    {
        if (condition is not Elm.Is { operand: Elm.OperandRef or Elm.AliasRef or Elm.QueryLetRef } @is
            || @is.isTypeSpecifier is ChoiceTypeSpecifier)
            return null;

        var tested = @is.isTypeSpecifier is { } typeSpecifier
            ? TypeFor(typeSpecifier, throwIfNotFound: false)
            : !string.IsNullOrWhiteSpace(@is.isType?.Name)
                ? _typeResolver.ResolveType(@is.isType.Name, throwError: false)
                : null;

        return tested is null ? null : (@is.operand, tested);
    }

    /// <summary>Whether two references name the same operand, alias or <c>let</c>.</summary>
    private static bool SameReference(Expression a, Expression b) =>
        (a, b) switch
        {
            (Elm.OperandRef x, Elm.OperandRef y) => x.name == y.name,
            (Elm.AliasRef x, Elm.AliasRef y) => x.name == y.name,
            (Elm.QueryLetRef x, Elm.QueryLetRef y) => x.name == y.name,
            _ => false,
        };

    /// <summary>
    /// The variable a type switch arm narrows <paramref name="subject"/> to for a test for
    /// <paramref name="tested"/>, or <see langword="null"/> when a value of the subject's static type
    /// cannot be a <paramref name="tested"/> as far as C# is concerned, which a pattern would reject.
    /// </summary>
    private static CodeLocal? NarrowedVariable(CodeExpression subject, Type tested)
    {
        var type = Nullable.GetUnderlyingType(tested) ?? tested;
        var subjectType = Nullable.GetUnderlyingType(subject.Type) ?? subject.Type;
        return subjectType.IsAssignableFrom(type) || subjectType.IsInterface || type.IsInterface
            ? new CodeLocal(type, isNotNull: true)
            : null;
    }

    /// <summary>
    /// Translates a <c>case</c> whose leading items are <see cref="Elm.Is"/> tests of one reference
    /// as a type switch over that reference, with its remaining items and <c>else</c> as the value
    /// when no arm matches; <see langword="null"/> when the first item is not such a test.
    /// </summary>
    /// <remarks>
    /// Only the leading run narrows: an item after a condition of any other kind is only reached once
    /// every test before it failed, which says nothing about the reference's type.
    /// </remarks>
    private CodeExpression? CaseAsTypeSwitch(Elm.Case ce)
    {
        if (ce.comparand != null || ce.caseItem is not { Length: > 0 } items || ce.@else is null
            || NarrowingTest(items[0].when) is not { } first
            || ResolveReference(first.Reference) is not { } reference)
            return null;

        var subject = TranslateArg(first.Reference);
        var run = new List<(CaseItem Item, CodeLocal Narrowed)>();
        var runLength = 0;
        foreach (var item in items)
        {
            if (NarrowingTest(item.when) is not { } test
                || !SameReference(test.Reference, first.Reference)
                || NarrowedVariable(subject, test.Tested) is not { } narrowed)
                break;

            runLength++;

            // A test for a type an earlier test already covers can never succeed (an Age after a
            // Quantity, or two types that resolve to one class): its branch is unreachable.
            if (run.Any(earlier => earlier.Narrowed.Type.IsAssignableFrom(narrowed.Type)))
                continue;

            run.Add((item, narrowed));
        }

        if (run.Count == 0)
            return null;

        var elseThen = TranslateArg(ce.@else);
        var resultType = elseThen.Type;

        var arms = run.Select(entry => new CodeTypeSwitchArm(
                              entry.Narrowed,
                              AssignableTo(TranslateNarrowed(entry.Item.then!, reference.Value, entry.Narrowed), resultType)))
                      .ToList();

        var rest = new List<(CodeExpression When, CodeExpression Then)>();
        foreach (var item in items.Skip(runLength))
        {
            var when = TranslateArg(item.when!);
            if (when.Type.IsNullableValueType(out _))
                when = when.Coalesce();
            rest.Add((when, AssignableTo(TranslateArg(item.then!), resultType)));
        }

        CodeExpression otherwise = rest.Count > 0 ? new CodeIfChain(rest, elseThen, resultType) : elseThen;
        return new CodeTypeSwitch(subject, arms, otherwise, resultType);
    }

    /// <summary>
    /// Translates <c>if x is T then A else B</c> as a type switch over <c>x</c> with one arm;
    /// <see langword="null"/> when the condition is not such a test.
    /// </summary>
    private CodeExpression? IfAsTypeSwitch(Elm.If @if)
    {
        if (NarrowingTest(@if.condition) is not { } test
            || ResolveReference(test.Reference) is not { } reference)
            return null;

        var subject = TranslateArg(test.Reference);
        if (NarrowedVariable(subject, test.Tested) is not { } narrowed)
            return null;

        var then = TranslateNarrowed(@if.then!, reference.Value, narrowed);

        // CQL values are nullable; a narrowed value-typed variable is not.
        if (then.Type.IsValueType && Nullable.GetUnderlyingType(then.Type) is null)
            then = then.NewAssignToTypeExpression(then.Type.MakeNullable());

        CodeExpression @else;
        if (@if.@else != null)
        {
            @else = TranslateArg(@if.@else);
            if (then.Type.IsValueType)
                @else = HandleNullable(@else, then.Type);
        }
        else
        {
            @else = new CodeConstant(null, typeof(object)).NewAssignToTypeExpression(then.Type);
        }

        // Narrowing may make the branch's type more precise than the else's.
        var resultType = then.Type == @else.Type || CodeTypeRules.CanBeAssigned(then.Type, @else.Type)
            ? @else.Type
            : CodeTypeRules.CanBeAssigned(@else.Type, then.Type)
                ? then.Type
                : throw this.NewExpressionBuildingException(
                    $"The If expression at {@if.locator} produces two branches with different types.");

        return new CodeTypeSwitch(
            subject,
            [new CodeTypeSwitchArm(narrowed, AssignableTo(then, resultType))],
            AssignableTo(@else, resultType),
            resultType);
    }

    /// <summary>
    /// <paramref name="value"/> as a value of <paramref name="type"/>: unchanged when it is of a
    /// reference type <paramref name="type"/> is assignable from, converted otherwise.
    /// </summary>
    private static CodeExpression AssignableTo(CodeExpression value, Type type) =>
        value.Type == type || (!value.Type.IsValueType && type.IsAssignableFrom(value.Type))
            ? value
            : value.NewAssignToTypeExpression(type);

    /// <summary>
    /// <c>x as T</c> on a narrowed variable, whose type is known: the variable itself when it already
    /// is a <c>T</c> (an upcast for a supertype of its type, which cannot fail); when its type cannot
    /// be a <c>T</c> at all, the cast of the reference as it is outside the branch, which yields what
    /// it would have without narrowing (null, or for a strict cast a failure). <see langword="null"/>
    /// when <paramref name="operand"/> is not a narrowed variable or the ordinary <c>as</c> applies.
    /// </summary>
    /// <remarks>
    /// The operand is recognised by its translation, not by its ELM: a translator may wrap a
    /// reference in an <c>as</c> of its own before the one being translated.
    /// </remarks>
    private CodeExpression? AsOfNarrowed(CodeExpression operand, Type type, CodeCastKind castKind, Element element)
    {
        if (operand is not CodeLocal { IsNotNull: true } narrowed || UnnarrowedOf(narrowed) is not { } unnarrowed)
            return null;

        if (type.IsAssignableFrom(narrowed.Type))
            return narrowed.Type == type ? narrowed : new CodeCast(narrowed, type, CodeCastKind.Cast);

        if (narrowed.Type.IsAssignableFrom(type) || narrowed.Type.IsInterface || type.IsInterface)
            return null;

        // E.g. a translator resolving a call on a choice to one alternative's overload, inside the
        // branch for another alternative. C# rejects the cast on the narrowed variable.
        _logger.LogWarning(FormatMessage(
            $"The value is a {narrowed.Type.Name} here, so as {type.Name} always results in null.", element));
        return new CodeCast(unnarrowed, type, castKind);
    }

    /// <summary>
    /// What a reference narrowed to <paramref name="narrowed"/> is bound to outside every branch
    /// narrowing it; <see langword="null"/> when <paramref name="narrowed"/> is no narrowed variable.
    /// </summary>
    private CodeExpression? UnnarrowedOf(CodeLocal narrowed)
    {
        CodeExpression? bound = null;
        for (CodeExpression current = narrowed;
             current is CodeLocal local && _narrowings.FirstOrDefault(entry => ReferenceEquals(entry.Value, local)).Key is { } outer;
             current = outer)
            bound = outer;
        return bound;
    }
}
