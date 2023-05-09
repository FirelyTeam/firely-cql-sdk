using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    /// <summary>
    /// Adds extension methods to <see cref="DefinitionDictionary{T}"/> for specific types.
    /// </summary>
    public static class DefinitionDictionaryExtensions
    {

        /// <summary>
        /// Compiles a <see cref="DefinitionDictionary{LambdaExpression}"/> to a <see cref="DefinitionDictionary{Delegate}"/>.
        /// This is accomplished by calling <see cref="LambdaExpression.Compile"/>.
        /// </summary>
        /// <param name="expressions">The expressions to compile.</param>
        /// <param name="visitors">Expression visitors to apply before compiling, or <see langword=""="null"/>.</param>
        /// <param name="debug">The debug info generator to use, or <see langword=""="null"/>.</param>
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
                                lambda = visitor.Visit(lambda) as LambdaExpression;
                            }
                        }
                        var @delegate = lambda.Compile(debug);
                        delegates.Add(library, kvp.Key, overload.Item1, @delegate);
                    }
                }
            }
            return delegates;
        }

        /// <summary>
        /// Invokes the delegate <paramref name="define"/> in <paramref name="libraryName"/> with <paramref name="parameters"/>.
        /// </summary>
        /// <typeparam name="T">The expected return type of the delegate.</typeparam>
        /// <param name="delegates">The delegates containing this definition.</param>
        /// <param name="libraryName">The library containing this definition.</param>
        /// <param name="define">The name of the definition.</param>
        /// <param name="rtx">The runtime context to use for the execution.</param>
        /// <param name="parameters">The definition's parameters, excluding <paramref name="rtx"/>.</param>
        /// <returns></returns>
        public static T Invoke<T>(this DefinitionDictionary<Delegate> delegates, string libraryName, string define, RuntimeContext rtx, params object[] parameters)
        {
            var parameterTypes = parameters.Select(p => p.GetType()).ToArray();
            var @delegate = delegates[libraryName, define, parameterTypes];
            var combined = new object[parameters.Length + 1];
            combined[0] = rtx;
            Array.Copy(parameters, 0, combined, 1, parameters.Length);
            var result = (T)@delegate.DynamicInvoke(combined);
            return result;
        }
    }
}
