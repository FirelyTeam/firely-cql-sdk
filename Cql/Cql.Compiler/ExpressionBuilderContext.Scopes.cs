/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

partial class ExpressionBuilderContext
{
    protected IReadOnlyDictionary<string, (Expression expr, Elm.Element element)> Scopes
    {
        get
        {
            _impliedAliasAndScopesStack.TryPeek(out var item);
            return item.scopes ?? ReadOnlyDictionary<string, (Expression expr, Elm.Element element)>.Empty;
        }
    }

    /// <summary>
    /// In dodgy sort expressions where the properties are named using the undocumented IdentifierRef expression type,
    /// this value is the implied alias name that should qualify it, e.g. from DRR-E 2022:
    /// <code>
    ///     "PHQ-9 Assessments" PHQ
    ///      where ...
    ///      sort by date from start of FHIRBase."Normalize Interval"(effective) asc
    /// </code>
    /// The use of "effective" here is unqualified and is implied to be PHQ.effective
    /// No idea how this is supposed to work with queries with multiple sources (e.g., with let statements)
    /// </summary>
    protected string? ImpliedAlias =>
        _impliedAliasAndScopesStack.TryPeek(out var item)
            ? item.impliedAlias
            : null;

    protected Expression GetScopeExpression(string elmAlias)
    {
        var normalized = NormalizeIdentifier(elmAlias!)!;
        if (!Scopes.TryGetValue(normalized, out var kv))
            throw this.NewExpressionBuildingException(
                $"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.");

        return kv.expr;
    }

    protected (Expression, Elm.Element) GetScope(string elmAlias)
    {
        var normalized = NormalizeIdentifier(elmAlias!)!;
        if (!Scopes.TryGetValue(normalized, out var kv))
            throw this.NewExpressionBuildingException(
                $"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.");
        return kv;
    }

    protected bool HasScope(string elmAlias) => Scopes.ContainsKey(elmAlias);

    protected IPopToken PushScopes(
        string? alias = null,
        params ExpressionElementPairForIdentifier[] kvps)
    {
        _impliedAliasAndScopesStack.TryPeek(out var peek);

        var scopes = new Dictionary<string, (Expression, Elm.Element)>(peek.scopes ?? ReadOnlyDictionary<string, (Expression, Elm.Element)>.Empty);
        alias ??= peek.impliedAlias;

        if (_expressionBuilderOptions.AllowScopeRedefinition)
        {
            foreach (var (expr, element) in kvps)
            {
                string? normalizedIdentifier = NormalizeIdentifier(expr);
                if (string.IsNullOrWhiteSpace(normalizedIdentifier))
                    throw this.NewExpressionBuildingException("The normalized identifier is not available.");

                scopes[normalizedIdentifier] = element;
            }
        }
        else
        {
            foreach (var (expr, element) in kvps)
            {
                string? normalizedIdentifier = NormalizeIdentifier(expr);
                if (string.IsNullOrWhiteSpace(normalizedIdentifier))
                    throw this.NewExpressionBuildingException("The normalize identifier is not available.");

                if (!scopes.TryAdd(normalizedIdentifier, element))
                    throw this.NewExpressionBuildingException(
                        $"Scope {expr}, normalized to {NormalizeIdentifier(expr)}, is already defined and this builder does not allow scope redefinition.  Check the CQL source, or set {nameof(_expressionBuilderOptions.AllowScopeRedefinition)} to true");
            }
        }

        var prevId = peek.id;
        _impliedAliasAndScopesStack = _impliedAliasAndScopesStack.Push((new object(), alias, scopes));
        return new PopScopesToken(this, prevId);
    }



    private readonly record struct PopScopesToken : IPopToken
    {
        private readonly ExpressionBuilderContext _owner;
        private readonly object? _prevId;

        public PopScopesToken(ExpressionBuilderContext owner, object? prevId)
        {
            _owner = owner;
            _prevId = prevId;
        }

        void IDisposable.Dispose() => Pop();

        public void Pop()
        {
            var expectedPrevId = _owner._impliedAliasAndScopesStack.ElementAtOrDefault(1).id;

            if (_prevId != expectedPrevId)
                throw new InvalidOperationException("Popping should be called in the correct reverse order.");

            _owner._impliedAliasAndScopesStack = _owner._impliedAliasAndScopesStack.Pop();
        }
    }
}