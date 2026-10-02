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
using Element = Hl7.Cql.Elm.Element;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Resolving a reference to a function operand, a query alias or a <c>let</c>. Translating a
/// reference, inferring its type and determining its alternatives all resolve it here, so each of
/// them sees the reference as it is where it is read: within a branch that narrows it, the narrowed
/// variable (see CodeBuilderContext.Narrowing.cs).
/// </summary>
partial class CodeBuilderContext
{
    /// <summary>A reference to a function operand, a query alias or a <c>let</c>, resolved where it is read.</summary>
    /// <param name="Value">What the reference translates to: within a branch that narrows it, the narrowed variable.</param>
    /// <param name="Bound">What the reference is bound to, outside every branch narrowing it.</param>
    /// <param name="Source">
    /// For an alias or a <c>let</c>, the element its scope stores (see <see cref="ReferenceStaticValue"/>);
    /// <see langword="null"/> for an operand.
    /// </param>
    /// <param name="DeclaredType">For an operand, the type specifier it is declared with, if any.</param>
    private readonly record struct ResolvedReference(
        CodeExpression Value,
        CodeExpression Bound,
        Element? Source,
        TypeSpecifier? DeclaredType)
    {
        /// <summary>Whether a branch being translated narrows the reference.</summary>
        public bool IsNarrowed => !ReferenceEquals(Value, Bound);
    }

    /// <summary>
    /// Resolves <paramref name="reference"/> when it is a reference to a function operand, a query
    /// alias or a <c>let</c>; <see langword="null"/> when it is none of these, or names an operand the
    /// definition does not have.
    /// </summary>
    /// <exception cref="Hl7.Cql.Exceptions.CqlException">The reference names an alias or <c>let</c> that is not in scope.</exception>
    private ResolvedReference? ResolveReference(Expression reference) =>
        reference switch
        {
            Elm.OperandRef { name: { } name } operandRef when _operands?.TryGetValue(name, out var operand) == true =>
                Resolved(operand, source: null,
                         operandRef.resultTypeSpecifier ?? (_operandTypeSpecifiers.TryGetValue(name, out var declared) ? declared : null)),
            Elm.AliasRef { name: { } alias } when !string.IsNullOrWhiteSpace(alias) => ResolveScope(alias),
            Elm.QueryLetRef { name: { } let } when !string.IsNullOrWhiteSpace(let) => ResolveScope(let),
            _ => null,
        };

    /// <summary>Resolves the query alias or <c>let</c> named <paramref name="alias"/>.</summary>
    /// <exception cref="Hl7.Cql.Exceptions.CqlException">No alias or <c>let</c> of that name is in scope.</exception>
    private ResolvedReference ResolveScope(string alias)
    {
        var normalized = IdentifierNormalizer.Normalize(alias)!;
        if (!Scopes.TryGetValue(normalized, out var scope))
            throw this.NewExpressionBuildingException(
                $"The scope alias {alias}, normalized to {normalized}, is not present in the scopes dictionary.");

        return Resolved(scope.expr, scope.element, declaredType: null);
    }

    private ResolvedReference Resolved(CodeExpression bound, Element? source, TypeSpecifier? declaredType) =>
        new(Narrowed(bound), bound, source, declaredType);

    /// <summary>
    /// What is known statically about a resolved reference: a narrowed reference has one concrete
    /// type, so it has no alternatives; an operand has those of its declared type; an alias or
    /// <c>let</c> those of the expression it ranges over or binds.
    /// </summary>
    /// <remarks>
    /// A scope whose element refers back to the scope itself would resolve forever; while a scope is
    /// being resolved, a reference back to it is answered by its .NET type alone.
    /// </remarks>
    private StaticValue ReferenceStaticValue(ResolvedReference reference)
    {
        if (reference.IsNarrowed)
            return new StaticValue(reference.Value.Type, null);

        if (reference.Source is not { } element)
            return new StaticValue(reference.Bound.Type,
                                   ChoiceAlternativesOf(reference.DeclaredType, unwrapList: _typeResolver.IsListType(reference.Bound.Type)));

        if (!_scopesBeingResolved.Add(reference.Bound))
            return new StaticValue(reference.Bound.Type, null);

        try
        {
            return ScopeStaticValue(reference.Bound, element);
        }
        finally
        {
            _scopesBeingResolved.Remove(reference.Bound);
        }
    }

    /// <summary>The scopes <see cref="ReferenceStaticValue"/> is resolving, by their expression.</summary>
    private readonly HashSet<CodeExpression> _scopesBeingResolved = new(ReferenceEqualityComparer.Instance);
}
