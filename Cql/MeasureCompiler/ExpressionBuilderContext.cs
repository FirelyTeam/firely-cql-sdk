using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Logging;
using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public class ExpressionBuilderContext
    {
        public ExpressionBuilder Builder { get; }
        public ParameterExpression RuntimeContextParameter { get; }
        public DefinitionDictionary<LambdaExpression> Definitions { get; }

        /// <summary>
        /// Tracks the nesting level of this context.
        /// </summary>
        public int Depth => Predecessors.Count;
        public Elm.Expressions.Expression? Parent
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
        public int? ParentLocalId => Parent?.localId;

        private readonly IList<Elm.Expressions.Expression> Predecessors = new List<Elm.Expressions.Expression>();

        /// <summary>
        /// Contains query aliases and let declarations, and any other symbol that is now "in scope"
        /// </summary>
        private IDictionary<string, (Expression, elm.Expression)> Scopes { get; } = new Dictionary<string, (Expression, elm.Expression)>();

        /// <summary>
        /// In dodgy sort expressions where the properties are named using the undocumented IdentifierRef expression type,
        /// this value is the implied alias name that should qualify it, e.g. from DRR-E 2022:
        /// <code>
        ///     "PHQ-9 Assessments" PHQ
        //      where ...
        //      sort by date from start of FHIRBase."Normalize Interval"(effective) asc
        // </code> 
        // The use of "effective" here is unqualified and is implied to be PHQ.effective
        // No idea how this is supposed to work with queries with multiple sources (e.g., with let statements)
        /// </summary>
        public string? ImpliedAlias { get; private set; } = null;

        public static string? NormalizeIdentifier(string? identifier)
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

        public Expression GetScopeExpression(string elmAlias)
        {
            var normalized = NormalizeIdentifier(elmAlias!)!;
            if (Scopes.TryGetValue(normalized, out var expression))
                return expression.Item1;
            else throw new ArgumentException($"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.", nameof(elmAlias));
        }

        public (Expression, elm.Expression) GetScope(string elmAlias)
        {
            var normalized = NormalizeIdentifier(elmAlias!)!;
            if (Scopes.TryGetValue(normalized, out var expression))
                return expression;
            else throw new ArgumentException($"The scope alias {elmAlias}, normalized to {normalized}, is not present in the scopes dictionary.", nameof(elmAlias));
        }

        public Expression? ImpliedAliasExpression => ImpliedAlias != null ? GetScopeExpression(ImpliedAlias) : null;

        public bool HasScope(string elmAlias) => Scopes.ContainsKey(elmAlias);


        /// <summary>
        /// Used for mappings such as:
        ///     include NCQA_CQLBase version '1.0.0' called CQLBase
        /// The key is "CQLBase" and the value is "NCQA_CQLBase.1.0.0"
        /// </summary>
        public IDictionary<string, string> LocalLibraryIdentifiers = new Dictionary<string, string>();

        /// <summary>
        /// Parameters for function definitions.
        /// </summary>
        public IDictionary<string, ParameterExpression> Operands { get; } = new Dictionary<string, ParameterExpression>();

        public IDictionary<string, DefinitionDictionary<LambdaExpression>> Libraries { get; } = new Dictionary<string, DefinitionDictionary<LambdaExpression>>();

        public ExpressionBuilderContext(ExpressionBuilder builder, 
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
            Dictionary<string, (Expression, elm.Expression)> scopes) : this(other)
        {
            Scopes = scopes;
        }

        /// <summary>
        /// Creates a copy with the scopes provided.
        /// </summary>
        public ExpressionBuilderContext WithScopes(params KeyValuePair<string, (Expression, elm.Expression)>[] kvps)
        {
            var scopes = new Dictionary<string, (Expression, elm.Expression)>(Scopes);
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

        public ExpressionBuilderContext WithImpliedAlias(string aliasName, Expression linqExpression, elm.Expression elmExpression)
        {
            var subContext = WithScopes(new KeyValuePair<string, (Expression, elm.Expression)>(aliasName, (linqExpression, elmExpression)));
            subContext.ImpliedAlias = aliasName;

            return subContext;
        }


        /// <summary>
        /// Clones this ExpressionBuilderContext, adding the current context as a predecessor.
        /// </summary>
        public ExpressionBuilderContext Deeper(Elm.Expressions.Expression expression)
        {
            var subContext = new ExpressionBuilderContext(this);
            subContext.Predecessors.Add(expression);
            return subContext;
        }


        /// <returns>(startLine, startColumn, endLine, endColumn)</returns>
        public (int, int, int, int) ParseLocator(string locator)
        {
            var firstColon = locator.IndexOf(':');
            if (firstColon > -1)
            {
                var dash = locator.IndexOf('-', firstColon);
                if (dash > -1)
                {
                    var secondColon = locator.IndexOf(':', dash);
                    if (secondColon > -1)
                    {
                        var startLine = int.Parse(locator.Substring(0, firstColon));
                        var startCol = int.Parse(locator.Substring(firstColon + 1, dash - firstColon - 1));
                        var endline = int.Parse(locator.Substring(dash + 1, secondColon - dash - 1));
                        var endCol = int.Parse(locator.Substring(secondColon + 1));
                        return (startLine, startCol, endline, endCol);
                    }
                }
                else
                {
                    var startLine = int.Parse(locator.Substring(0, firstColon));
                    var startCol = int.Parse(locator.Substring(firstColon + 1));
                    return (startLine, startCol, startLine, startCol);
                }
            }
            throw new ArgumentException("Locator is not in the right format (dd:dd-dd:dd)", nameof(locator));
        }


        public void LogWarning(string message, Elm.Expressions.Expression? expression = null)
        {
            Builder.Logger.LogWarning(FormatMessage(message, expression));
        }

        public void LogError(string message, Elm.Expressions.Expression? expression = null)
        {
            Builder.Logger.LogError(FormatMessage(message, expression));
        }

        private string FormatMessage(string message, Elm.Expressions.Expression? expression)
        {
            var locator = expression?.locator;
            if (!string.IsNullOrWhiteSpace(locator))
            {
                return $"{Builder.ThisLibraryKey} line {locator}: {message}";
            }
            else return $"{Builder.ThisLibraryKey}: {message}";
        }
    }
}
