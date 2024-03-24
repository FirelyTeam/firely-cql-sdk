﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The ExpressionBuilderContext class maintains scope information for the traversal of ElmPackage statements.
    /// </summary>
    /// <remarks>
    /// The scope information in this class is useful for <see cref="IExpressionMutator"/> and is supplied to <see cref="IExpressionMutator.Mutate(Expression, Elm.Element, ContextualExpressionBuilder)"/>.
    /// </remarks>
    internal partial class ContextualExpressionBuilder
    {
        private readonly TypeManager _typeManager;

        internal ContextualExpressionBuilder(
            ILogger<ContextualExpressionBuilder> logger,
            OperatorBinding operatorBinding,
            TypeManager typeManager,
            ExpressionBuilderSettings settings,
            ContextualLibraryExpressionBuilder libContext,
            elm.Element element)
        {
            _element = element;
            _outerContext = null;
            _expressionBuilderSettings = settings ?? throw new ArgumentNullException(nameof(settings));
            _operatorBinding = OperatorBindingRethrowDecorator.Decorate(this, operatorBinding);
            _impliedAlias = null;
            _operands = new Dictionary<string, ParameterExpression>();
            _libraries = new Dictionary<string, DefinitionDictionary<LambdaExpression>>();
            _scopes = new Dictionary<string, (Expression, elm.Element)>();
            LibraryContext = libContext;
            _typeManager = typeManager;
            _logger = logger;
            _expressionMutators = new List<IExpressionMutator>();
            _customImplementations = new Dictionary<string, Func<ParameterExpression[], LambdaExpression>>();
        }

        private ContextualExpressionBuilder(
            ContextualExpressionBuilder source)
        {
            _element = source._element;
            _outerContext = source._outerContext;
            _expressionBuilderSettings = source._expressionBuilderSettings;
            _operatorBinding = OperatorBindingRethrowDecorator.Decorate(this, source._operatorBinding);
            _impliedAlias = source._impliedAlias;
            _operands = source._operands;
            _libraries = source._libraries;
            _scopes = source._scopes;
            LibraryContext = source.LibraryContext;
            _typeManager = source._typeManager;
            _logger = source._logger;
            _expressionMutators = source._expressionMutators;
            _customImplementations = source._customImplementations;
        }

        private ContextualExpressionBuilder(
            ContextualExpressionBuilder outer,
            Elm.Element element) : this(outer)
        {
            Debug.Assert(element != _element);
            _outerContext = outer;
            _operatorBinding = OperatorBindingRethrowDecorator.Decorate(this, outer._operatorBinding);
            _element = element;
        }

        private ContextualExpressionBuilder(
            ContextualExpressionBuilder outer,
            string? impliedAlias,
            IDictionary<string, (Expression, elm.Element)> scopes) : this(outer)
        {
            _scopes = scopes;
            _impliedAlias = impliedAlias;
        }

        internal ContextualLibraryExpressionBuilder LibraryContext { get; }

        /// <summary>
        /// A dictionary which maps qualified definition names in the form of {<see cref="Elm.Library.NameAndVersion"/>}.{<c>Definition.name"</c>}
        /// to a factory which will produce a <see cref="LambdaExpression"/> given the values of <see cref="ParameterExpression"/>.
        /// </summary>
        /// <remarks>
        /// This function can be used to provide .NET native functions in place of ELM functions, and should also be used to implement
        /// functions defined in CQL with the <code>external</code> keyword.
        /// </remarks> 
        private readonly Dictionary<string, Func<ParameterExpression[], LambdaExpression>> _customImplementations;


        public bool TryGetCustomImplementationByExpressionKey(
            string expressionKey,
            [NotNullWhen(true)] out Func<ParameterExpression[], LambdaExpression>? factory) =>
            _customImplementations.TryGetValue(expressionKey, out factory);

        private readonly IList<IExpressionMutator> _expressionMutators;

        private readonly ExpressionBuilderSettings _expressionBuilderSettings;

        private readonly OperatorBinding _operatorBinding;

        /// <summary>
        /// Parameters for function definitions.
        /// </summary>
        internal IReadOnlyDictionary<string, ParameterExpression> Operands => _operands;

        private readonly Dictionary<string, ParameterExpression> _operands;
        
        private readonly Dictionary<string, DefinitionDictionary<LambdaExpression>> _libraries;

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
        private readonly string? _impliedAlias;

        internal static string NormalizeIdentifier(string identifier)
        {
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
            if (_scopes.TryGetValue(normalized, out var expression))
                return expression.Item1;
            else throw this.NewExpressionBuildingException($"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.");
        }

        internal (Expression, elm.Element) GetScope(string elmAlias)
        {
            var normalized = NormalizeIdentifier(elmAlias!)!;
            if (_scopes.TryGetValue(normalized, out var expression))
                return expression;
            else throw this.NewExpressionBuildingException($"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.");
        }

        /// <summary>
        /// Contains query aliases and let declarations, and any other symbol that is now "in scope"
        /// </summary>
        private readonly IDictionary<string, (Expression, elm.Element)> _scopes;


        internal bool HasScope(string elmAlias) => _scopes.ContainsKey(elmAlias);


        internal ContextualExpressionBuilder WithScope(string alias, Expression expr, elm.Element element) => 
            WithScopes(KeyValuePair.Create(alias, (expr, element)));

        internal ContextualExpressionBuilder WithScopes(string? alias, params KeyValuePair<string, (Expression, elm.Element)>[] kvps)
        {
            var scopes = new Dictionary<string, (Expression, elm.Element)>(_scopes);
            if (_expressionBuilderSettings.AllowScopeRedefinition)
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
                            $"Scope {kvp.Key}, normalized to {NormalizeIdentifier(kvp.Key)}, is already defined and this builder does not allow scope redefinition.  Check the CQL source, or set {nameof(_expressionBuilderSettings.AllowScopeRedefinition)} to true");
                    scopes.Add(normalizedIdentifier, kvp.Value);
                }
            }
            var subContext = new ContextualExpressionBuilder(this, impliedAlias:alias, scopes: scopes);
            return subContext;
        }

        /// <summary>
        /// Creates a copy with the scopes provided.
        /// </summary>
        internal ContextualExpressionBuilder
            WithScopes(params KeyValuePair<string, (Expression, elm.Element)>[] kvps) => 
            WithScopes(_impliedAlias, kvps);

        internal ContextualExpressionBuilder WithImpliedAlias(string aliasName, Expression linqExpression, elm.Element elmExpression)
        {
            var subContext = WithScopes(aliasName, new KeyValuePair<string, (Expression, elm.Element)>(aliasName, (linqExpression, elmExpression)));
            return subContext;
        }

        /// <summary>
        /// Clones this ExpressionBuilderContext
        /// </summary>
        internal ContextualExpressionBuilder Push(
            elm.Element element)
        {
            if (element == _element)
            {
                Debug.WriteLine($"Unnecessary call to {nameof(Push)}, since the current context already points to the element.");
                return this;
            }

            return new ContextualExpressionBuilder(this, element);
        }

        internal ContextualExpressionBuilder Pop() => _outerContext ?? throw new InvalidOperationException("Cannot pop the root context.");
        
        public Expression? Mutate(elm.Element op, Expression? expression)
        {
            foreach (var visitor in _expressionMutators)
            {
                expression = visitor.Mutate(expression!, op, this);
            }
            return expression;
        }
    }
}
