using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public static class DefinitionDictionaryExtensions
    {

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
