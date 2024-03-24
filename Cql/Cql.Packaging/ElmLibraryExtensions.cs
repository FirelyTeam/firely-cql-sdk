using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging
{
    /// <summary>
    /// Helpers for ELM Libraries
    /// </summary>
    public static class ElmLibraryExtensions
    {
        /// <summary>
        /// Evaluate the given expression for the given library and context
        /// </summary>
        /// <param name="library">the library</param>
        /// <param name="expression">the expression to evaluate</param>
        /// <param name="context">the context of the expression evaluation</param>
        /// <param name="logFactory">logger</param>
        /// <returns>the result of the expression</returns>
        [UsedImplicitly]
        public static object? EvaluateExpression(
            this Elm.Library library, 
            Elm.Expression expression, 
            CqlContext context,
            ILoggerFactory logFactory)
        {
            var factory = new ExpressionBuilderFactory(logFactory);
            var expressionBuilder = factory.ExpressionBuilder;
            var lambda = expressionBuilder.Lambda(library, expression);
            var func = lambda.Compile();
            return func.DynamicInvoke(context);
        }
    }
}
