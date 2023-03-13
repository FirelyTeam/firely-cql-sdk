using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Linq;
using Ncqa.Cql.Runtime.Logging;
using Ncqa.Cql.Runtime;

namespace Ncqa.Cql.MeasureCompiler
{
    public class LoggerExpressionMutator : IExpressionMutator
    {
        public const string LoggerPropertyName = "Logger";
        public virtual IEnumerable<(string, Type)> RuntimeContextKeys
        {
            get
            {
                yield return (LoggerPropertyName, typeof(ILogger));
            }
        }

        public LoggerExpressionMutator(Stream seekableCqlSourceStream)
        {
            if (!seekableCqlSourceStream.CanRead)
                throw new ArgumentException("CQL is not readable", nameof(seekableCqlSourceStream));
            if (!seekableCqlSourceStream.CanSeek)
                throw new ArgumentException("CQL is not seekable", nameof(seekableCqlSourceStream));

            seekableCqlSourceStream.Seek(0, SeekOrigin.Begin);
            using var reader = new StreamReader(seekableCqlSourceStream, Encoding.UTF8, true, 1024, true);
            string? line = null;
            while ((line = reader.ReadLine()) != null)
            {
                CqlLines.Add(line);
            }


        }


        protected static readonly MethodInfo ToStringMethod = typeof(object).GetMethod(nameof(object.ToString));
        // 
        protected static readonly MethodInfo StringFormatMethod = (from method in typeof(string).GetMethods(BindingFlags.Public | BindingFlags.Static)
                                                 let parameters = method.GetParameters()
                                                 where parameters.Length == 2
                                                 && parameters[0].ParameterType == typeof(string)
                                                                            && parameters[1].ParameterType == typeof(object[])
                                                 where method.Name == nameof(string.Format)
                                                 select method).Single();

        public IList<string> CqlLines { get; } = new List<string>();

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
                var locator = context.ParseLocator(elmExpression.locator);
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
