/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The ExpressionBuilderContext class maintains scope information for the traversal of ElmPackage statements during <see cref="ExpressionBuilder.BuildLibraryDefinitions()"/>.
    /// </summary>
    /// <remarks>
    /// The scope information in this class is useful for <see cref="IExpressionMutator"/> and is supplied to <see cref="IExpressionMutator.Mutate(Expression, Elm.Element, ExpressionBuilderContext)"/>.
    /// </remarks>
    internal partial class ExpressionBuilderContext
    {

        internal ExpressionBuilderContext(
            ExpressionBuilder builder,
            ParameterExpression contextParameter,
            DefinitionDictionary<LambdaExpression> definitions,
            IDictionary<string, string> localLibraryIdentifiers,
            Elm.Element element)
        {
            _element = element;
            _outerContext = null;
            Builder = builder ?? throw new ArgumentNullException(nameof(builder));
            RuntimeContextParameter = contextParameter ?? throw new ArgumentNullException(nameof(contextParameter));
            Definitions = definitions ?? throw new ArgumentNullException(nameof(definitions));
            LocalLibraryIdentifiers = localLibraryIdentifiers ?? throw new ArgumentNullException(nameof(localLibraryIdentifiers));
            ImpliedAlias = null;
            Operands = new Dictionary<string, ParameterExpression>();
            Libraries = new Dictionary<string, DefinitionDictionary<LambdaExpression>>();
            Scopes = new Dictionary<string, (Expression, elm.Element)>();
        }

        private ExpressionBuilderContext(
            ExpressionBuilderContext source,
            Elm.Element? overrideElement = null,
            IDictionary<string, (Expression, elm.Element)>? overrideScopes = null)
        {
            _element = overrideElement ?? source._element;
            _outerContext = source._outerContext;
            Builder = source.Builder;
            RuntimeContextParameter = source.RuntimeContextParameter;
            Definitions = source.Definitions;
            LocalLibraryIdentifiers = source.LocalLibraryIdentifiers;
            ImpliedAlias = source.ImpliedAlias;
            Operands = source.Operands;
            Libraries = source.Libraries;
            Scopes = overrideScopes ?? source.Scopes;
        }

        /// <summary>
        /// Gets the <see cref="ExpressionBuilder"/> from which this context derives.
        /// </summary>
        public ExpressionBuilder Builder { get; }
        /// <summary>
        /// Gets the <see cref="ParameterExpression"/> which is passed to the <see cref="OperatorBinding"/> for operators to use.        
        /// </summary>
        /// <remarks>
        /// Having access to the <see cref="CqlContext"/> is almost always necessary when implementing operators because the context contains all comparers, value sets, CQL parameter values, and other data provided at runtime.
        /// </remarks>
        public ParameterExpression RuntimeContextParameter { get; }


        internal DefinitionDictionary<LambdaExpression> Definitions { get; }

        /// <summary>
        /// Used for mappings such as:
        ///     include canonical_id version '1.0.0' called alias
        /// The key is "alias" and the value is "canonical_id.1.0.0"
        /// </summary>
        internal readonly IDictionary<string, string> LocalLibraryIdentifiers;

        /// <summary>
        /// Parameters for function definitions.
        /// </summary>
        internal IDictionary<string, ParameterExpression> Operands { get; }

        private IDictionary<string, DefinitionDictionary<LambdaExpression>> Libraries { get; }

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
        internal string? ImpliedAlias { get; private set; }

        internal static string? NormalizeIdentifier(string? identifier)
        {
            if (identifier == null)
                return null;

            identifier = identifier.Replace(" ", "_");
            identifier = identifier.Replace("-", "_");
            identifier = identifier.Replace(".", "_");
            identifier = identifier.Replace(",", "_");
            identifier = identifier.Replace("[", "_");
            identifier = identifier.Replace("]", "_");
            identifier = identifier.Replace("(", "_");
            identifier = identifier.Replace(")", "_");
            identifier = identifier.Replace(":", "_");
            identifier = identifier.Replace("/", "_");
            identifier = identifier.Replace("+", "plus");
            identifier = identifier.Replace("-", "minus");
            identifier = identifier.Replace("\"", "");
            identifier = identifier.Replace("'", "");
            identifier = identifier.Replace(";", "_");
            identifier = identifier.Replace("&", "and");


            if (identifier.StartsWith("$"))
                identifier = identifier.Substring(1);
            var keyword = SyntaxFacts.GetKeywordKind(identifier);
            if (keyword != SyntaxKind.None)
            {
                identifier = $"@{identifier}";
            }
            if (char.IsDigit(identifier[0]))
                identifier = "_" + identifier;
            return identifier;
        }

        internal Expression GetScopeExpression(string elmAlias)
        {
            var normalized = NormalizeIdentifier(elmAlias!)!;
            if (Scopes.TryGetValue(normalized, out var expression))
                return expression.Item1;
            else throw new ArgumentException($"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.", nameof(elmAlias));
        }

        internal (Expression, elm.Element) GetScope(string elmAlias)
        {
            var normalized = NormalizeIdentifier(elmAlias!)!;
            if (Scopes.TryGetValue(normalized, out var expression))
                return expression;
            else throw new ArgumentException($"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.", nameof(elmAlias));
        }

        /// <summary>
        /// Contains query aliases and let declarations, and any other symbol that is now "in scope"
        /// </summary>
        private IDictionary<string, (Expression, elm.Element)> Scopes { get; init; }


        internal bool HasScope(string elmAlias) => Scopes.ContainsKey(elmAlias);


        /// <summary>
        /// Creates a copy with the scopes provided.
        /// </summary>
        internal ExpressionBuilderContext WithScopes(params KeyValuePair<string, (Expression, elm.Element)>[] kvps)
        {
            var scopes = new Dictionary<string, (Expression, elm.Element)>(Scopes);
            if (Builder.Settings.AllowScopeRedefinition)
            {
                foreach (var kvp in kvps)
                {
                    string? normalizedIdentifier = NormalizeIdentifier(kvp.Key);
                    if (string.IsNullOrWhiteSpace(normalizedIdentifier))
                        throw NewExpressionBuildingException("The normalized identifier is not available.");

                    scopes[normalizedIdentifier] = kvp.Value;
                }
            }
            else
            {
                foreach (var kvp in kvps)
                {
                    string? normalizedIdentifier = NormalizeIdentifier(kvp.Key);
                    if (string.IsNullOrWhiteSpace(normalizedIdentifier))
                        throw NewExpressionBuildingException("The normalize identifier is not available.");

                    if (scopes.ContainsKey(normalizedIdentifier))
                        throw NewExpressionBuildingException(
                            $"Scope {kvp.Key}, normalized to {NormalizeIdentifier(kvp.Key)}, is already defined and this builder does not allow scope redefinition.  Check the CQL source, or set {nameof(ExpressionBuilderSettings.AllowScopeRedefinition)} to true");
                    scopes.Add(normalizedIdentifier, kvp.Value);
                }
            }
            var subContext = this.WithScopes(scopes);
            return subContext;
        }

        /// <summary>
        /// Clones this ExpressionBuilderContext
        /// </summary>
        private ExpressionBuilderContext WithScopes(
            IDictionary<string, (Expression, elm.Element)> scopes) =>
            new(this, overrideScopes: scopes);

        /// <summary>
        /// Clones this ExpressionBuilderContext
        /// </summary>
        internal ExpressionBuilderContext Deeper(elm.Element element) => 
            new(this, overrideElement: element);

        internal ExpressionBuilderContext WithImpliedAlias(string aliasName, Expression linqExpression, elm.Element elmExpression)
        {
            var subContext = WithScopes(new KeyValuePair<string, (Expression, elm.Element)>(aliasName, (linqExpression, elmExpression)));
            subContext.ImpliedAlias = aliasName;
            return subContext;
        }

        internal void LogWarning(string message, elm.Element? expression = null)
        {
            Builder.Logger.LogWarning(FormatMessage(message, expression));
        }

        internal void LogError(string message, elm.Element? element = null)
        {
            Builder.Logger.LogError(FormatMessage(message, element));
        }


        private string FormatMessage(string message, elm.Element? element)
        {
            var locator = element?.locator;
            var libraryKey = Builder.Library.NameAndVersion;
            if (libraryKey is null)
                throw NewExpressionBuildingException("Library name and version is null");

            return string.IsNullOrWhiteSpace(locator) 
                ? $"{libraryKey}: {message}"
                : $"{libraryKey} line {locator}: {message}";
        }

        public Type TypeFor(elm.TypeSpecifier resultTypeSpecifier) => 
            Builder.TypeManager.TypeFor(resultTypeSpecifier, this);

        public Type? TypeFor(elm.Element element, bool throwIfNotFound = true) =>
            Builder.TypeManager.TypeFor(element, this, throwIfNotFound);
    }
}
