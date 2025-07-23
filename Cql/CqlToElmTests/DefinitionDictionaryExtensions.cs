/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Runtime.CompilerServices;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Test;

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

        foreach (var (libraryName, definitionSignature, expression) in cqlDefinitionDictionary.SelectDefinitions())
        {
            Expression expr = expression;
            if (visitors != null)
                foreach (var visitor in visitors)
                    expr = visitor.Visit(expr);

            var @delegate = debug is not null
                                ? ((CqlLambdaDefinition)expr).LambdaExpression.Compile(debug)
                                : ((CqlLambdaDefinition)expr).LambdaExpression.Compile();
            delegates.AddDefinition(libraryName, definitionSignature, @delegate);
        }

        return delegates;
    }
}