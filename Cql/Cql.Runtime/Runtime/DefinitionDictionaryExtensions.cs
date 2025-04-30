/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Adds extension methods to <see cref="DefinitionDictionary{T}"/> for specific types.
    /// </summary>
    internal static class DefinitionDictionaryExtensions
    {
        /// <summary>
        /// Compiles a <see cref="DefinitionDictionary{LambdaExpression}"/> to a <see cref="DefinitionDictionary{Delegate}"/>.
        /// This is accomplished by calling <see cref="LambdaExpression.Compile()"/>.
        /// </summary>
        /// <param name="cqlDefinitionDictionary">The expressions to compile.</param>
        /// <param name="visitors">Expression visitors to apply before compiling, or <see langword="null"/>.</param>
        /// <param name="debug">The debug info generator to use, or <see langword="null"/>.</param>
        /// <returns></returns>
        public static DelegateDefinitionDictionary CompileAll(
            this CqlDefinitionDictionary cqlDefinitionDictionary,
            IList<ExpressionVisitor>? visitors = null,
            DebugInfoGenerator? debug = null)
        {
            var delegates = new DelegateDefinitionDictionary();

            foreach (var (libraryName, definitionName, signature, expression) in cqlDefinitionDictionary.SelectDefinitions())
            {
                Expression expr = expression;
                if (visitors != null)
                    foreach (var visitor in visitors)
                        expr = visitor.Visit(expr);

                var @delegate = debug is not null
                                    ? ((CqlDefinition)expr).Lambda.Compile(debug)
                                    : ((CqlDefinition)expr).Lambda.Compile();
                delegates.Add(libraryName, definitionName, signature, @delegate);
            }

            return delegates;
        }
    }
}