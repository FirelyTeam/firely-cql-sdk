/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        public bool TryGetCustomImplementationByExpressionKey(
            string expressionKey,
            [NotNullWhen(true)] out Func<ParameterExpression[], LambdaExpression>? factory) =>
            _customImplementations.TryGetValue(expressionKey, out factory);

        internal Expression GetScopeExpression(string elmAlias)
        {
            var normalized = NormalizeIdentifier(elmAlias!)!;
            if (_scopes.TryGetValue(normalized, out var expression))
                return expression.Item1;
            else throw this.NewExpressionBuildingException($"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.");
        }

        internal (Expression, Elm.Element) GetScope(string elmAlias)
        {
            var normalized = NormalizeIdentifier(elmAlias!)!;
            if (_scopes.TryGetValue(normalized, out var expression))
                return expression;
            else throw this.NewExpressionBuildingException($"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.");
        }

        internal bool HasScope(string elmAlias) => _scopes.ContainsKey(elmAlias);

        internal ExpressionBuilder WithScope(string alias, Expression expr, Elm.Element element) =>
            WithScopes(KeyValuePair.Create(alias, (expr, element)));

        internal ExpressionBuilder WithScopes(string? alias, params KeyValuePair<string, (Expression, Elm.Element)>[] kvps)
        {
            var scopes = new Dictionary<string, (Expression, Elm.Element)>(_scopes);
            if (_libraryDefinitionBuilderSettings.AllowScopeRedefinition)
            {
                foreach (var kvp in kvps)
                {
                    string? normalizedIdentifier = NormalizeIdentifier(kvp.Key);
                    if (string.IsNullOrWhiteSpace(normalizedIdentifier))
                        throw this.NewExpressionBuildingException("The normalized identifier is not available.");

                    scopes[normalizedIdentifier] = kvp.Value;
                }
            }
            else
            {
                foreach (var kvp in kvps)
                {
                    string? normalizedIdentifier = NormalizeIdentifier(kvp.Key);
                    if (string.IsNullOrWhiteSpace(normalizedIdentifier))
                        throw this.NewExpressionBuildingException("The normalize identifier is not available.");

                    if (scopes.ContainsKey(normalizedIdentifier))
                        throw this.NewExpressionBuildingException(
                            $"Scope {kvp.Key}, normalized to {NormalizeIdentifier(kvp.Key)}, is already defined and this builder does not allow scope redefinition.  Check the CQL source, or set {nameof(_libraryDefinitionBuilderSettings.AllowScopeRedefinition)} to true");
                    scopes.Add(normalizedIdentifier, kvp.Value);
                }
            }
            var subContext = new ExpressionBuilder(this, impliedAlias:alias, scopes: scopes);
            return subContext;
        }

        /// <summary>
        /// Creates a copy with the scopes provided.
        /// </summary>
        internal ExpressionBuilder
            WithScopes(params KeyValuePair<string, (Expression, Elm.Element)>[] kvps) =>
            WithScopes(_impliedAlias, kvps);

        internal ExpressionBuilder WithImpliedAlias(string aliasName, Expression linqExpression, Elm.Element elmExpression)
        {
            var subContext = WithScopes(aliasName, new KeyValuePair<string, (Expression, Elm.Element)>(aliasName, (linqExpression, elmExpression)));
            return subContext;
        }
    }
}
