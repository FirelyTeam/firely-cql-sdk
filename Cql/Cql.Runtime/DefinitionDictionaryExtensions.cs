/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

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
        /// <param name="expressions">The expressions to compile.</param>
        /// <param name="visitors">Expression visitors to apply before compiling, or <see langword="null"/>.</param>
        /// <param name="debug">The debug info generator to use, or <see langword="null"/>.</param>
        /// <returns></returns>
        public static DefinitionDictionary<Delegate> CompileAll(this DefinitionDictionary<LambdaExpression> expressions,
            IList<ExpressionVisitor>? visitors = null,
            DebugInfoGenerator? debug = null)
        {
            var delegates = new DefinitionDictionary<Delegate>();
            foreach (var library in expressions.Libraries)
            {
                foreach (var kvp in expressions.DefinitionsForLibrary(library))
                {
                    foreach (var overload in kvp.Value)
                    {
                        var lambda = overload.Item2;
                        if (visitors != null)
                        {
                            foreach (var visitor in visitors)
                            {
                                lambda = (LambdaExpression)visitor.Visit(lambda);
                            }
                        }
                        var @delegate = debug is not null ? lambda.Compile(debug) : lambda.Compile();
                        delegates.Add(library, kvp.Key, overload.Item1, @delegate);
                    }
                }
            }
            return delegates;
        }

        /// <summary>
        /// Invokes the delegate <paramref name="define"/> in <paramref name="libraryName"/>.
        /// </summary>
        /// <param name="delegates">The delegates containing this definition.</param>
        /// <param name="libraryName">The library containing this definition.</param>
        /// <param name="define">The name of the definition.</param>
        /// <param name="rtx">The runtime context to use for the execution.</param>
        public static object? Invoke(this DefinitionDictionary<Delegate> delegates, string libraryName,
            string define, CqlContext rtx) =>
            InvokeShared(delegates, libraryName, define, Type.EmptyTypes, rtx);
        
        /// <inheritdoc cref="Invoke"/>
        public static object? Invoke<TArg1>(this DefinitionDictionary<Delegate> delegates, string libraryName,
            string define, CqlContext rtx, TArg1 arg1) =>
            InvokeShared(delegates, libraryName, define, new[] { typeof(TArg1) }, rtx, arg1);

        /// <inheritdoc cref="Invoke"/>
        public static object? Invoke<TArg1, TArg2>(this DefinitionDictionary<Delegate> delegates, string libraryName,
            string define, CqlContext rtx, TArg1 arg1, TArg2 arg2) =>
            InvokeShared(delegates, libraryName, define, new[] { typeof(TArg1), typeof(TArg2) }, rtx, arg1, arg2);

        /// <inheritdoc cref="Invoke"/>
        public static object? Invoke<TArg1, TArg2, TArg3>(this DefinitionDictionary<Delegate> delegates,
            string libraryName, string define, CqlContext rtx, TArg1 arg1, TArg2 arg2, TArg3 arg3) =>
            InvokeShared(delegates, libraryName, define, new[] { typeof(TArg1), typeof(TArg2), typeof(TArg3) }, rtx, arg1, arg2, arg3);

        /// <inheritdoc cref="Invoke"/>
        private static object? InvokeShared(DefinitionDictionary<Delegate> delegates, string libraryName, string define,
            Type[] parameterTypes, params object?[] rtxWithParameters)
        {
            Delegate @delegate = delegates[libraryName, define, parameterTypes];
            var result = @delegate.DynamicInvoke(rtxWithParameters);
            return result;
        }
    }
}
