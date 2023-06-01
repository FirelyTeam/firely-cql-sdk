using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Linq;
using Ncqa.Cql.Runtime.Logging;
using Ncqa.Cql.Runtime;
using Ncqa.Cql.MeasureCompiler;
using Ncqa.Elm;

namespace Ncqa.Cql.MeasureCompiler.Mutators
{

    /// <summary>
    /// An <see cref="IExpressionMutator"/> which logs values as they are computed.
    /// This is useful when attempting to debug a CQL measure.
    /// </summary>
    public class LoggerExpressionMutator : IExpressionMutator
    {
        /// <summary>
        /// Gets the key into the <see cref="RuntimeContext.Extensions"/> dictionary this mutator will use.
        /// </summary>
        public const string LoggerPropertyName = "Logger";

        /// <summary>
        /// Returns <see cref="LoggerPropertyName"/>.
        /// </summary>
        public virtual IEnumerable<(string, Type)> RuntimeContextKeys
        {
            get
            {
                yield return (LoggerPropertyName, typeof(ILogger));
            }
        }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="cqlStream">A stream of CQL source code.  This stream must be readable.</param>
        /// <exception cref="ArgumentException">If the <see cref="Stream.CanRead"/> property is false for <paramref name="cqlStream"/>.</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="cqlStream"/> is <see langword="null" />.</exception>
        public LoggerExpressionMutator(Stream cqlStream)
        {
            if (cqlStream is null)
            {
                throw new ArgumentNullException(nameof(cqlStream));
            }
            if (!cqlStream.CanRead)
                throw new ArgumentException("CQL is not readable", nameof(cqlStream));
            using var reader = new StreamReader(cqlStream, Encoding.UTF8, true, 1024, true);
            string? line = null;
            while ((line = reader.ReadLine()) != null)
            {
                CqlLines.Add(line);
            }


        }


        protected static readonly MethodInfo ToStringMethod = typeof(object).GetMethod(nameof(object.ToString));
        protected static readonly MethodInfo StringFormatMethod = (from method in typeof(string).GetMethods(BindingFlags.Public | BindingFlags.Static)
                                                                   let parameters = method.GetParameters()
                                                                   where parameters.Length == 2
                                                                   && parameters[0].ParameterType == typeof(string)
                                                                                              && parameters[1].ParameterType == typeof(object[])
                                                                   where method.Name == nameof(string.Format)
                                                                   select method).Single();

        internal IList<string> CqlLines { get; } = new List<string>();

        /// <summary>
        /// Mutates <see cref="elm.ExpressionRefExpression"/>  to call <see cref="ILogger.WriteLine(string)"/> on computed values.
        /// </summary>
        /// <param name="linqExpression">The LINQ expression.</param>
        /// <param name="elmExpression">The ELM expression.</param>
        /// <param name="context">The runtime context.</param>
        /// <returns>The unchanged value of <paramref name="linqExpression"/>.</returns>
        public virtual Expression Mutate(Expression linqExpression, Elm.Expressions.Expression elmExpression, ExpressionBuilderContext context)
        {
            var definitionsProperty = Expression.Property(context.RuntimeContextParameter, typeof(RuntimeContext).GetProperty(nameof(RuntimeContext.Extensions)));
            var itemProperty = typeof(IDictionary<string, object>).GetProperty("Item", new[] { typeof(string) });
            var indices = new[] { Expression.Constant(LoggerPropertyName) };
            var index = Expression.MakeIndex(definitionsProperty, itemProperty, indices);
            var asLogger = Expression.Convert(index, typeof(ILogger));
            // ((ILogger)runtimeContext["Logger"])
            var writeLineMethod = typeof(ILogger).GetMethod(nameof(ILogger.WriteLine));

            var variable = Expression.Variable(linqExpression.Type);
            // store a local to contain the value of the evaluated expression.
            var assign = Expression.Assign(variable, linqExpression);

            var cqlSource = CqlSource(elmExpression, context);
            var locator = elmExpression.locator ?? string.Empty;
            //var callToStringOnVariable = Expression.Call(variable, ToStringMethod);

            var arg1 = Expression.Constant(cqlSource);
            var arg2 = variable;

            const string formatString = "<{0}> {1}";
            var objectParameters = Expression.NewArrayInit(typeof(object),
                Expression.Convert(arg1, typeof(object)),
                Expression.Convert(arg2, typeof(object)));
            var callStringFormat = Expression.Call(StringFormatMethod,
                Expression.Constant(formatString),
                objectParameters);

            var callWriteLine = Expression.Call(asLogger, writeLineMethod, callStringFormat);
            var block = Expression.Block(linqExpression.Type,
                new[] { variable },
                callWriteLine,
                linqExpression);
            return block;
        }

        protected string CqlSource(Elm.Expressions.Expression elmExpression, ExpressionBuilderContext context)
        {
            string cqlSource = string.Empty;
            if (elmExpression.locator != null)
            {
                var locator = ElmPackage.ParseLocator(elmExpression.locator);
                if (locator.Item1 == locator.Item3) //Same line
                {
                    var line = CqlLines[locator.Item1 - 1];
                    cqlSource = !string.IsNullOrEmpty(line) ? line.Substring(locator.Item2 - 1, locator.Item4 - locator.Item2 + 1) : line;
                }
                else
                {
                    var sb = new StringBuilder();
                    var firstLine = CqlLines[locator.Item1 - 1];
                    sb.AppendLine(firstLine.Substring(locator.Item2 - 1));
                    for (var i = locator.Item1 + 1; i < locator.Item3; i++)
                        sb.AppendLine(CqlLines[i]);
                    var lastLine = CqlLines[locator.Item3 - 1];
                    sb.Append(lastLine.Substring(0, locator.Item4));
                    cqlSource = sb.ToString();
                }
            }

            return cqlSource;
        }
    }
}