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
using Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private IReadOnlyDictionary<string, (Expression expr, Elm.Element element)> Scopes =>
            _scopesStack.IsEmpty
                ? ReadOnlyDictionary<string, (Expression expr, Elm.Element element)>.Empty
                : _scopesStack.Peek().scopes;

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
        private string? ImpliedAlias =>
            _scopesStack.IsEmpty
                ? null
                : _scopesStack.Peek().impliedAlias;


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
            string? alias,
            params KeyValuePair<string, (Expression, Elm.Element)>[] kvps)
        {
            var scopes = new Dictionary<string, (Expression, Elm.Element)>(Scopes);
            if (_libraryDefinitionBuilderSettings.AllowScopeRedefinition)
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
                            $"Scope {expr}, normalized to {NormalizeIdentifier(expr)}, is already defined and this builder does not allow scope redefinition.  Check the CQL source, or set {nameof(_libraryDefinitionBuilderSettings.AllowScopeRedefinition)} to true");
                }
            }

            _scopesStack = _scopesStack.Push((alias, scopes));
            return new PopScopesToken(this);
        }



        private readonly record struct PopScopesToken : IPopToken
        {
            private readonly ExpressionBuilder _owner;/*
            private readonly Elm.Element? _previousElement;*/

            public PopScopesToken(
                ExpressionBuilder owner/*,
                Elm.Element? previousElement*/)
            {
                _owner = owner;/*
                _previousElement = previousElement;*/
            }

            void IDisposable.Dispose() => Pop();

            public void Pop()
            {
                /*var expectedPreviousElement = _owner._elementStack.ElementAtOrDefault(1);

                if (_previousElement != expectedPreviousElement)
                    throw new InvalidOperationException("Popping should be called in the correct reverse order.");*/

                _owner._scopesStack = _owner._scopesStack.Pop();
            }
        }
    }
}
