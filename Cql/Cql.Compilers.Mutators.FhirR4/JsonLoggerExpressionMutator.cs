using Ncqa.Cql.MeasureCompiler;
using Ncqa.Cql.MeasureCompiler.Mutators;
using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Ncqa.Cql.MeasureCompiler.Mutators.FhirR4
{
    public class JsonLoggerExpressionMutator : LoggerExpressionMutator
    {
        public List<string>? ExcludeList { get; set; } = null;
        public bool LogListOfCodes { get; set; } = false;

        public JsonLoggerExpressionMutator(Stream seekableCqlSourceStream, string runtimeContextKey)
            : base(seekableCqlSourceStream)
        {
            RuntimeContextKey = runtimeContextKey;
        }

        public override IEnumerable<(string, Type)> RuntimeContextKeys
        {
            get
            {
                yield return (RuntimeContextKey, typeof(Dictionary<string, List<ExpressionLog>>));
            }
        }

        public void InitializeRuntimeContext(RuntimeContext rtx)
        {
            if (!rtx.Extensions.TryGetValue(RuntimeContextKey, out var existing) || existing == null)
            {
                rtx.Extensions[RuntimeContextKey] = new Dictionary<string, List<ExpressionLog>>();
            }
        }

        public string RuntimeContextKey { get; }

        public override Expression Mutate(Expression linqExpression, Elm.Expressions.Expression elmExpression, ExpressionBuilderContext context)
        {
            if (elmExpression is Elm.Expressions.LiteralExpression || elmExpression is Elm.Expressions.ValueSetRefExpression)
            {
                return linqExpression;
            }

            if (!LogListOfCodes
                && elmExpression.resultTypeSpecifier != null
                && elmExpression.resultTypeSpecifier.type == "ListTypeSpecifier"
                && elmExpression.resultTypeSpecifier.elementType != null
                && elmExpression.resultTypeSpecifier.elementType.name == "{urn:hl7-org:elm-types:r1}Code")
            {
                return linqExpression;
            }

            if (ExcludeList != null)
            {
                if (elmExpression is Elm.Expressions.ExpressionRefExpression refExpression
                    && refExpression.libraryName == null && !string.IsNullOrWhiteSpace(refExpression.name)
                    && ExcludeList.Contains(refExpression.name!))
                    return linqExpression;
                else if (elmExpression is Elm.Expressions.FunctionRefExpression fRefExpression
                    && !string.IsNullOrWhiteSpace(fRefExpression.name)
                    && ExcludeList.Contains(fRefExpression.name!))
                    return linqExpression;
            }

            var logsByBundleId = JsonLogExpressionFromContext(context);
            var cqlSource = string.Empty; //we dont need the CQL source, only the locator info

            var localId = elmExpression.localId;
            var locator = elmExpression.locator ?? string.Empty;
            var value = linqExpression;
            var parentLocalId = context.Parent?.localId;
            var parentLocator = context.Parent?.locator;
            string? parentName = null;
            if (context.Parent is Elm.Expressions.DefinitionExpression def)
                parentName = def.name;

            var logMethod = typeof(JsonLoggerExpressionMutator)
                .GetMethod(nameof(Log), BindingFlags.Public | BindingFlags.Static)!
                .MakeGenericMethod(linqExpression.Type);

            var callLogMethod = Expression.Call(logMethod,
                logsByBundleId,
                Expression.Constant(null, typeof(string)), // bundle id
                value,
                Expression.Constant(localId, typeof(int?)),
                Expression.Constant(locator),
                Expression.Constant(cqlSource),
                Expression.Constant(parentLocalId, typeof(int?)),
                Expression.Constant(parentLocator, typeof(string)),
                Expression.Constant(parentName, typeof(string)),
                context.RuntimeContextParameter);

            return callLogMethod;
        }

        private UnaryExpression JsonLogExpressionFromContext(ExpressionBuilderContext context)
        {
            var resolveParam = Expression.Call(
             context.RuntimeContextParameter,
             typeof(RuntimeContext).GetMethod(nameof(RuntimeContext.ResolveExtension)),
             Expression.Constant(RuntimeContextKey),
             Expression.New(typeof(Dictionary<string, List<ExpressionLog>>))
            );

            var logsByBundleId = Expression.Convert(resolveParam, typeof(Dictionary<string, List<ExpressionLog>>));
            return logsByBundleId;
        }



        public static T Log<T>(Dictionary<string, List<ExpressionLog>> rootLogsByBundleId, string bundleId, T value, int? localId, string locator, string cqlSource,
            int? parentLocalId, string? parentLocator, string? parentName, RuntimeContext rtx)
        {
            var syncRoot = (rootLogsByBundleId as System.Collections.ICollection).SyncRoot;
            lock (syncRoot)
            {
                bundleId ??= "null";
                //if (!string.IsNullOrWhiteSpace(cqlSource))
                //{
                    if (!rootLogsByBundleId.TryGetValue(bundleId, out var logsForBundle))
                    {
                        logsForBundle = new List<ExpressionLog>();
                        rootLogsByBundleId.Add(bundleId, logsForBundle);
                    }
                    var thisLog = new ExpressionLog
                    {
                        cql = cqlSource,
                        localId = localId,
                        value = ResultValue(value),
                    };
                    (int, int, int, int)? parsed = null;
                    if (!string.IsNullOrWhiteSpace(locator))
                    {
                        parsed = ParseLocator(locator);
                        thisLog.locator = new Locator(parsed.Value);
                    }
                    if (rtx != null && rtx.CallStack != null && rtx.CallStack.Count > 0)
                    {
                        thisLog.callStack = rtx.CallStack.Select(cs => new ExpressionLog()
                        {
                            localId = cs.LocalId,
                            name = cs.Name,
                            locator = !string.IsNullOrWhiteSpace(cs.Locator) ? new Locator(ParseLocator(cs.Locator!)) : null,
                        }).ToList();
                    }

                    if (!HasExistingLog(logsForBundle, thisLog))
                    {
                        logsForBundle.Add(thisLog);
                    }
                //}
            }
            return value;
        }

        // Check the logs to see if one exists with same {locator + callstack}
        private static bool HasExistingLog(List<ExpressionLog> logs, ExpressionLog log)
        {
            return logs.Any(lg => lg.Equals(log));
        }

        private static JsonNode? ResultValue(object? result)
        {
            if (result == null)
                return null;
            if (result is IEnumerable<Fhir.R4.Model.Resource> arrayOfResource)
            {
                var array = new JsonArray();
                foreach (var r in arrayOfResource)
                {
                    var rjt = ResultValue(r);
                    if (rjt != null)
                        array.Add(rjt);
                }
                return array;
            }
            else
            {
                using var ms = new MemoryStream();
                Fhir.R4.FhirJson.Serialize(result, ms);
                ms.Flush();
                var resourceJson = Encoding.UTF8.GetString(ms.ToArray());
                var jsonObj = JsonNode.Parse(resourceJson!)?.AsObject();
                return jsonObj;
            }
        }
        private static (int, int, int, int) ParseLocator(string locator)
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

    }
}
