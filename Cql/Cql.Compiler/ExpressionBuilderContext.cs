/* 
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
using Hl7.Cql.Abstractions;
using elm = Hl7.Cql.Elm;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The ExpressionBuilderContext class maintains scope information for the traversal of ElmPackage statements.
    /// </summary>
    /// <remarks>
    /// The scope information in this class is useful for <see cref="IExpressionMutator"/> and is supplied to <see cref="IExpressionMutator.Mutate(Expression, Elm.Element, ExpressionBuilderContext)"/>.
    /// </remarks>
    internal partial class ExpressionBuilderContext
    {
        internal ExpressionBuilderContext(
            OperatorBinding operatorBinding, 
            ExpressionBuilder builder,
            ParameterExpression contextParameter,
            DefinitionDictionary<LambdaExpression> definitions,
            IDictionary<string, string> localLibraryIdentifiers,
            LibraryExpressionBuilderContext libContext,
            elm.Element element)
        {
            _element = element;
            _outerContext = null;
            Builder = builder ?? throw new ArgumentNullException(nameof(builder));
            RuntimeContextParameter = contextParameter ?? throw new ArgumentNullException(nameof(contextParameter));
            Definitions = definitions ?? throw new ArgumentNullException(nameof(definitions));
            _operatorBinding = new OperatorBindingRethrowDecorator(this, operatorBinding);
            LocalLibraryIdentifiers = localLibraryIdentifiers ?? throw new ArgumentNullException(nameof(localLibraryIdentifiers));
            ImpliedAlias = null;
            Operands = new Dictionary<string, ParameterExpression>();
            Libraries = new Dictionary<string, DefinitionDictionary<LambdaExpression>>();
            _scopes = new Dictionary<string, (Expression, elm.Element)>();
            LibraryContext = libContext;
            ExpressionMutators = new List<IExpressionMutator>();
            CustomImplementations = new Dictionary<string, Func<ParameterExpression[], LambdaExpression>>();
        }

        private ExpressionBuilderContext(
            ExpressionBuilderContext source)
        {
            _operatorBinding = source._operatorBinding;
            _element = source._element;
            _outerContext = source._outerContext;
            Builder = source.Builder;
            RuntimeContextParameter = source.RuntimeContextParameter;
            Definitions = source.Definitions;
            LocalLibraryIdentifiers = source.LocalLibraryIdentifiers;
            ImpliedAlias = source.ImpliedAlias;
            Operands = source.Operands;
            Libraries = source.Libraries;
            _scopes = source._scopes;
            LibraryContext = source.LibraryContext;
            ExpressionMutators = source.ExpressionMutators;
            CustomImplementations = source.CustomImplementations;
        }

        private ExpressionBuilderContext(
            ExpressionBuilderContext outer,
            Elm.Element element) : this(outer)
        {
            Debug.Assert(element != this._element);
            _outerContext = outer;
            _operatorBinding = new OperatorBindingRethrowDecorator(this, outer._operatorBinding.Inner);
            _element = element;
        }

        private ExpressionBuilderContext(
            ExpressionBuilderContext outer,
            IDictionary<string, (Expression, elm.Element)> scopes) : this(outer)
        {
            _scopes = scopes;
        }

        internal LibraryExpressionBuilderContext LibraryContext { get; }

        /// <summary>
        /// A dictionary which maps qualified definition names in the form of {<see cref="Elm.Library.NameAndVersion"/>}.{<c>Definition.name"</c>}
        /// to a factory which will produce a <see cref="LambdaExpression"/> given the values of <see cref="ParameterExpression"/>.
        /// </summary>
        /// <remarks>
        /// This function can be used to provide .NET native functions in place of ELM functions, and should also be used to implement
        /// functions defined in CQL with the <code>external</code> keyword.
        /// </remarks> 
        private IDictionary<string, Func<ParameterExpression[], LambdaExpression>> CustomImplementations { get; }


        public bool TryGetCustomImplementationByExpressionKey(
            string expressionKey,
            [NotNullWhen(true)] out Func<ParameterExpression[], LambdaExpression>? factory) =>
            CustomImplementations.TryGetValue(expressionKey, out factory);

        /// <summary>
        /// The expression visitors that will be executed (in order) on translated expressions.
        /// </summary>
        private IList<IExpressionMutator> ExpressionMutators { get; }

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

        private readonly OperatorBindingRethrowDecorator _operatorBinding;

        /// <summary>
        /// The <see cref="Compiler.OperatorBinding"/> used to invoke <see cref="CqlOperator"/>.
        /// </summary>
        public OperatorBinding OperatorBinding => _operatorBinding;

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


        /// <summary>
        /// Creates a copy with the scopes provided.
        /// </summary>
        internal ExpressionBuilderContext WithScopes(params KeyValuePair<string, (Expression, elm.Element)>[] kvps)
        {
            var scopes = new Dictionary<string, (Expression, elm.Element)>(_scopes);
            if (Builder.Settings.AllowScopeRedefinition)
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
                            $"Scope {kvp.Key}, normalized to {NormalizeIdentifier(kvp.Key)}, is already defined and this builder does not allow scope redefinition.  Check the CQL source, or set {nameof(ExpressionBuilderSettings.AllowScopeRedefinition)} to true");
                    scopes.Add(normalizedIdentifier, kvp.Value);
                }
            }
            var subContext = this.WithScopes(scopes);
            return subContext;
        }

        internal ExpressionBuilderContext WithImpliedAlias(string aliasName, Expression linqExpression, elm.Element elmExpression)
        {
            var subContext = WithScopes(new KeyValuePair<string, (Expression, elm.Element)>(aliasName, (linqExpression, elmExpression)));
            subContext.ImpliedAlias = aliasName;
            return subContext;
        }

        /// <summary>
        /// Clones this ExpressionBuilderContext
        /// </summary>
        private ExpressionBuilderContext WithScopes(
            IDictionary<string, (Expression, elm.Element)> scopes) =>
            new(this, scopes: scopes);

        /// <summary>
        /// Clones this ExpressionBuilderContext
        /// </summary>
        internal ExpressionBuilderContext Deeper(
            elm.Element element)
        {
            if (element == _element)
            {
                Debug.WriteLine("Unnecessary call to Deeper, since the current context already points to the element.");
                return this;
            }

            return new ExpressionBuilderContext(this, element);
        }

        public Expression? Mutate(elm.Element op, Expression? expression)
        {
            foreach (var visitor in ExpressionMutators)
            {
                expression = visitor.Mutate(expression!, op, this);
            }
            return expression;
        }
    }
}
