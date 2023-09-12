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
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The ExpressionBuilderContext class maintains scope information for the traversal of ElmPackage statements during <see cref="ExpressionBuilder.Build"/>.
    /// </summary>
    /// <remarks>
    /// The scope information in this class is useful for <see cref="IExpressionMutator"/> and is supplied to <see cref="IExpressionMutator.Mutate(Expression, elm.Element, ExpressionBuilderContext)"/>.
    /// </remarks>
    internal class ExpressionBuilderContext
    {
        internal ExpressionBuilderContext(ExpressionBuilder builder,
            ParameterExpression contextParameter,
            DefinitionDictionary<LambdaExpression> definitions,
            IDictionary<string, string> localLibraryIdentifiers)
        {
            Builder = builder;
            RuntimeContextParameter = contextParameter;
            Definitions = definitions;
            LocalLibraryIdentifiers = localLibraryIdentifiers;
        }

        private ExpressionBuilderContext(ExpressionBuilderContext other)
        {
            Libraries = other.Libraries;
            Builder = other.Builder;
            RuntimeContextParameter = other.RuntimeContextParameter;
            Definitions = other.Definitions;
            LocalLibraryIdentifiers = other.LocalLibraryIdentifiers;
            Operands = other.Operands;
            Scopes = other.Scopes;
            Predecessors = other.Predecessors.ToList(); // copy it
            ImpliedAlias = other.ImpliedAlias;
        }

        private ExpressionBuilderContext(ExpressionBuilderContext other,
            Dictionary<string, (Expression, elm.Element)> scopes) : this(other)
        {
            Scopes = scopes;
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

        /// <summary>
        /// Gets the parent of the context's current expression.
        /// </summary>
        public elm.Element? Parent
        {
            get
            {
                if (Predecessors.Count < 0)
                    return null;
                else if (Predecessors.Count == 1)
                    return Predecessors[0];
                else return Predecessors[Predecessors.Count - 2];
            }
        }
        /// <summary>
        /// Gets key value pairs mapping the library identifier to its library-local alias.
        /// </summary>
        public IEnumerable<KeyValuePair<string, string>> LibraryIdentifiers
        {
            // Don't return the dictionary, to protect against cast attacks.  The source dictionary must be readonly.
            get
            {
                foreach (var kvp in LibraryIdentifiers)
                    yield return kvp;
            }
        }

        internal DefinitionDictionary<LambdaExpression> Definitions { get; }

        /// <summary>
        /// Used for mappings such as:
        ///     include canonical_id version '1.0.0' called alias
        /// The key is "alias" and the value is "canonical_id.1.0.0"
        /// </summary>
        internal readonly IDictionary<string, string> LocalLibraryIdentifiers = new Dictionary<string, string>();

        /// <summary>
        /// Parameters for function definitions.
        /// </summary>
        internal IDictionary<string, ParameterExpression> Operands { get; } = new Dictionary<string, ParameterExpression>();

        internal IDictionary<string, DefinitionDictionary<LambdaExpression>> Libraries { get; } = new Dictionary<string, DefinitionDictionary<LambdaExpression>>();

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
        internal string? ImpliedAlias { get; private set; } = null;

        private readonly IList<elm.Element> Predecessors = new List<elm.Element>();

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

        internal Expression? ImpliedAliasExpression => ImpliedAlias != null ? GetScopeExpression(ImpliedAlias) : null;

        /// <summary>
        /// Contains query aliases and let declarations, and any other symbol that is now "in scope"
        /// </summary>
        private IDictionary<string, (Expression, elm.Element)> Scopes { get; } = new Dictionary<string, (Expression, elm.Element)>();


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
                    var normalized = NormalizeIdentifier(kvp.Key);
                    if (!string.IsNullOrWhiteSpace(normalized))
                    {
                        scopes[normalized] = kvp.Value;
                    }
                    else throw new InvalidOperationException();
                }
            }
            else
            {
                foreach (var kvp in kvps)
                {
                    var normalized = NormalizeIdentifier(kvp.Key);
                    if (!string.IsNullOrWhiteSpace(normalized))
                    {
                        if (scopes.ContainsKey(normalized))
                            throw new InvalidOperationException($"Scope {kvp.Key}, normalized to {NormalizeIdentifier(kvp.Key)}, is already defined and this builder does not allow scope redefinition.  Check the CQL source, or set {nameof(ExpressionBuilderSettings.AllowScopeRedefinition)} to true");
                        scopes.Add(normalized, kvp.Value);
                    }
                    else throw new InvalidOperationException();
                }
            }
            var subContext = new ExpressionBuilderContext(this, scopes);
            return subContext;
        }

        internal ExpressionBuilderContext WithImpliedAlias(string aliasName, Expression linqExpression, elm.Element elmExpression)
        {
            var subContext = WithScopes(new KeyValuePair<string, (Expression, elm.Element)>(aliasName, (linqExpression, elmExpression)));
            subContext.ImpliedAlias = aliasName;

            return subContext;
        }

        /// <summary>
        /// Clones this ExpressionBuilderContext, adding the current context as a predecessor.
        /// </summary>
        internal ExpressionBuilderContext Deeper(elm.Element expression)
        {
            var subContext = new ExpressionBuilderContext(this);
            subContext.Predecessors.Add(expression);
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


        internal string FormatMessage(string message, elm.Element? element)
        {
            var locator = element?.locator;
            if (!string.IsNullOrWhiteSpace(locator))
            {
                return $"{Builder.ThisLibraryKey} line {locator}: {message}";
            }
            else return $"{Builder.ThisLibraryKey}: {message}";
        }

    }
}
