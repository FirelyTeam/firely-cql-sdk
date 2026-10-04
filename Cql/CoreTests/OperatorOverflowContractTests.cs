/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests
{
    /// <summary>
    /// "Operations that cause arithmetic overflow or underflow, or otherwise cannot be performed (such as division by
    /// 0) will result in null, rather than a run-time error" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section
    /// "Arithmetic Operators"). Errors the specification does mandate are signalled as <see cref="CqlException{TError}"/>.
    /// This test states that contract once for every <see cref="ICqlOperators"/> method over Integer, Long, Decimal,
    /// Quantity, Date, DateTime, Time and intervals of those, by invoking each one with the extremes of its argument types.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class OperatorOverflowContractTests
    {
        /// <summary>
        /// Operator signatures that do not honour the contract yet; tracked by
        /// https://github.com/FirelyTeam/firely-cql-sdk/issues/1783.
        /// </summary>
        private static readonly HashSet<string> KnownGaps = new(StringComparer.Ordinal)
        {
        };

        /// <summary>
        /// Operator signatures that do not return for a quantity argument whose value has a fractional part, and whose
        /// invocations with such an argument are therefore not executed; tracked by
        /// https://github.com/FirelyTeam/firely-cql-sdk/issues/1783.
        /// </summary>
        private static readonly HashSet<string> KnownNonTerminating = new(StringComparer.Ordinal)
        {
        };

        /// <summary>
        /// A method with more value arguments than this is invoked with the extreme values of each type only.
        /// </summary>
        private const int MaxValueParametersForFullDomain = 2;

        /// <summary>
        /// A method taking an interval whose full argument space holds more combinations than this is invoked with the
        /// extreme values of each type only.
        /// </summary>
        private const int MaxCombinationsForFullDomain = 15_000;

        /// <summary>
        /// The same limit for a method taking only points, whose combinations are cheaper to invoke; it admits every
        /// pair of quantities.
        /// </summary>
        private const int MaxPointCombinationsForFullDomain = 25_000;

        /// <summary>
        /// A returned sequence is enumerated up to this many items, so deferred work also runs.
        /// </summary>
        private const int MaxItemsEnumerated = 10_000;

        private static readonly string[] Units =
        [
            "1", "mg", "mL", "cm", "a", "mo",
            "year", "years", "month", "months", "week", "weeks", "day", "days",
            "hour", "hours", "minute", "minutes", "second", "seconds", "millisecond", "milliseconds",
        ];

        /// <summary>
        /// The units of the extreme quantities. A plural calendar word takes the same paths as its singular form.
        /// </summary>
        private static readonly string[] ExtremeUnits =
        [
            "1", "mg", "mL", "cm", "a", "mo",
            "year", "month", "week", "day", "hour", "minute", "second", "millisecond",
        ];

        /// <summary>
        /// Values below one in magnitude, which divide into a quotient larger than the dividend.
        /// </summary>
        private static readonly decimal[] FractionalValues = [0.5m, -0.5m];

        private static readonly string[] Precisions =
            ["year", "month", "week", "day", "hour", "minute", "second", "millisecond"];

        private static readonly Type[] PointTypes =
        [
            typeof(int?), typeof(long?), typeof(decimal?),
            typeof(CqlQuantity), typeof(CqlDate), typeof(CqlDateTime), typeof(CqlTime),
        ];

        public TestContext TestContext { get; set; } = null!;

        [TestMethod]
        public void Operators_InvokedWithBoundaryArguments_ReturnValueOrNullOrThrowCqlException()
        {
            var operators = FhirCqlContext.WithDataSource().Operators;
            var domains = new Domains();

            var methods = typeof(ICqlOperators).GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var covered = new List<MethodInfo>();
            var skipped = new List<string>();
            foreach (var method in methods)
            {
                if (method.IsGenericMethodDefinition
                    || method.IsSpecialName
                    || method.GetParameters() is not { Length: > 0 } parameters
                    || !parameters.All(IsInScope))
                    skipped.Add(Signature(method));
                else
                    covered.Add(method);
            }

            var violations = new List<string>();
            var knownViolations = new Dictionary<string, (int Count, string Example)>(StringComparer.Ordinal);
            var violatingSignatures = new HashSet<string>(StringComparer.Ordinal);
            var timings = new List<(string Signature, int Calls, TimeSpan Elapsed)>();
            var total = Stopwatch.StartNew();
            var invocations = 0;
            var notExecuted = 0;

            foreach (var method in covered.OrderBy(Signature, StringComparer.Ordinal))
            {
                var signature = Signature(method);
                var parameters = method.GetParameters();
                var argumentSets = parameters
                    .Select(p => domains.For(p, method, extremesOnly: false))
                    .ToArray();
                if (parameters.Count(p => p.ParameterType != typeof(string)) > MaxValueParametersForFullDomain
                    || argumentSets.Aggregate(1L, (product, set) => product * set.Count)
                        > (parameters.Any(p => p.ParameterType.IsGenericType) ? MaxCombinationsForFullDomain : MaxPointCombinationsForFullDomain))
                {
                    argumentSets = parameters
                        .Select(p => domains.For(p, method, extremesOnly: true))
                        .ToArray();
                }

                var watch = Stopwatch.StartNew();
                var calls = 0;
                foreach (var arguments in CartesianProduct(argumentSets))
                {
                    calls++;
                    if (KnownNonTerminating.Contains(signature) && arguments.Any(IsFractionalQuantity))
                    {
                        notExecuted++;
                        continue;
                    }

                    if (Invoke(operators, method, arguments) is not { } exception || IsAllowed(exception, arguments))
                        continue;

                    var line = $"{method.Name}({string.Join(", ", arguments.Select(Format))}) threw {exception.GetType().Name}: {exception.Message}";
                    violatingSignatures.Add(signature);
                    if (!KnownGaps.Contains(signature))
                        violations.Add(line);
                    else if (knownViolations.TryGetValue(signature, out var known))
                        knownViolations[signature] = (known.Count + 1, known.Example);
                    else
                        knownViolations[signature] = (1, line);
                }

                invocations += calls;
                timings.Add((signature, calls, watch.Elapsed));
            }

            total.Stop();

            var unknownGaps = KnownGaps.Concat(KnownNonTerminating).Where(g => !covered.Any(m => Signature(m) == g)).ToList();
            var staleGaps = KnownGaps.Where(g => !violatingSignatures.Contains(g)).Except(unknownGaps).ToList();

            TestContext.WriteLine($"Covered {covered.Count} operators with {invocations} invocations in {total.Elapsed.TotalSeconds:F1} s.");
            TestContext.WriteLine($"Not executed: {notExecuted} invocations of the {KnownNonTerminating.Count} known non-terminating operators.");
            TestContext.WriteLine($"Skipped {skipped.Count} members that are generic, parameterless or take a parameter outside the covered types:");
            foreach (var s in skipped.Distinct().OrderBy(s => s, StringComparer.Ordinal))
                TestContext.WriteLine($"  {s}");
            TestContext.WriteLine("Slowest operators:");
            foreach (var (signature, calls, elapsed) in timings.OrderByDescending(t => t.Elapsed).Take(10))
                TestContext.WriteLine($"  {signature}: {calls} calls in {elapsed.TotalMilliseconds:F0} ms");
            TestContext.WriteLine($"Known gaps ({KnownGaps.Count}), with the number of violating invocations and the first of them:");
            foreach (var (signature, (count, example)) in knownViolations.OrderBy(k => k.Key, StringComparer.Ordinal))
                TestContext.WriteLine($"  {signature}: {count}, e.g. {example}");

            var failures = new StringBuilder();
            if (violations.Count > 0)
            {
                failures.AppendLine($"{violations.Count} invocations violate the null-on-overflow contract in "
                    + $"{violatingSignatures.Count(s => !KnownGaps.Contains(s))} operators:");
                foreach (var s in violatingSignatures.Where(s => !KnownGaps.Contains(s)).OrderBy(s => s, StringComparer.Ordinal))
                    failures.AppendLine($"  {s}");
                foreach (var line in violations.OrderBy(l => l, StringComparer.Ordinal))
                    failures.AppendLine(line);
            }

            if (staleGaps.Count > 0)
            {
                failures.AppendLine("Known gaps that no longer violate the contract; remove them from KnownGaps:");
                foreach (var g in staleGaps.OrderBy(g => g, StringComparer.Ordinal))
                    failures.AppendLine($"  {g}");
            }

            if (unknownGaps.Count > 0)
            {
                failures.AppendLine("Known gaps that name no covered operator; remove them from KnownGaps:");
                foreach (var g in unknownGaps.OrderBy(g => g, StringComparer.Ordinal))
                    failures.AppendLine($"  {g}");
            }

            if (failures.Length > 0)
                Assert.Fail(failures.ToString());
        }

        private static bool IsFractionalQuantity(object? argument) =>
            argument is CqlQuantity { value: { } value } && decimal.Truncate(value) != value;

        private static bool IsInScope(ParameterInfo parameter)
        {
            var type = parameter.ParameterType;
            if (type == typeof(string))
                return parameter.Name is "precision" or "unit";
            if (PointTypes.Contains(type))
                return true;
            return type.IsGenericType
                && type.GetGenericTypeDefinition() == typeof(CqlInterval<>)
                && PointTypes.Contains(type.GetGenericArguments()[0]);
        }

        /// <summary>
        /// Invokes <paramref name="method"/> and returns the exception it throws, or <see langword="null"/> when it
        /// returns. A returned sequence is enumerated so that deferred work runs as well.
        /// </summary>
        private static Exception? Invoke(ICqlOperators operators, MethodInfo method, object?[] arguments)
        {
            try
            {
                var result = method.Invoke(operators, arguments);
                if (result is IEnumerable sequence and not string)
                {
                    var count = 0;
                    var enumerator = sequence.GetEnumerator();
                    while (count++ < MaxItemsEnumerated && enumerator.MoveNext()) { }
                }

                return null;
            }
            catch (TargetInvocationException e) when (e.InnerException is not null)
            {
                return e.InnerException;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        /// <summary>
        /// A <see cref="CqlException{TError}"/> is the error the specification mandates. A plain
        /// <see cref="ArgumentException"/> naming a unit or precision string passed in is the programming-error contract
        /// for a string the operator does not accept. Anything else is a violation.
        /// </summary>
        private static bool IsAllowed(Exception exception, object?[] arguments)
        {
            for (var type = exception.GetType(); type is not null; type = type.BaseType)
            {
                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(CqlException<>))
                    return true;
            }

            return exception.GetType() == typeof(ArgumentException)
                && StringsIn(arguments).Any(s => Regex.IsMatch(exception.Message, $@"(?<![\w']){Regex.Escape(s)}(?![\w'])")
                    || exception.Message.Contains($"'{s}'", StringComparison.Ordinal));
        }

        private static IEnumerable<string> StringsIn(IEnumerable<object?> arguments)
        {
            foreach (var argument in arguments)
            {
                switch (argument)
                {
                    case string s when s.Length > 0:
                        yield return s;
                        break;
                    case CqlQuantity { unit: { Length: > 0 } unit }:
                        yield return unit;
                        break;
                    case ICqlInterval interval:
                        var points = interval.ToCqlIntervalOfObject();
                        foreach (var s in StringsIn([points.low, points.high]))
                            yield return s;
                        break;
                }
            }
        }

        private static IEnumerable<object?[]> CartesianProduct(IReadOnlyList<object?>[] sets)
        {
            var indices = new int[sets.Length];
            if (sets.Any(s => s.Count == 0))
                yield break;

            while (true)
            {
                yield return indices.Select((index, position) => sets[position][index]).ToArray();

                var p = sets.Length - 1;
                while (p >= 0 && ++indices[p] == sets[p].Count)
                {
                    indices[p] = 0;
                    p--;
                }

                if (p < 0)
                    yield break;
            }
        }

        private static string Signature(MethodInfo method) =>
            $"{method.Name}({string.Join(", ", method.GetParameters().Select(p => TypeName(p.ParameterType)))})";

        private static string TypeName(Type type)
        {
            if (Nullable.GetUnderlyingType(type) is { } underlying)
                return TypeName(underlying) + "?";
            if (type == typeof(int)) return "int";
            if (type == typeof(long)) return "long";
            if (type == typeof(decimal)) return "decimal";
            if (type == typeof(string)) return "string";
            if (type == typeof(bool)) return "bool";
            if (type == typeof(object)) return "object";
            if (!type.IsGenericType)
                return type.Name;

            var name = type.Name[..type.Name.IndexOf('`')];
            return $"{name}<{string.Join(", ", type.GetGenericArguments().Select(TypeName))}>";
        }

        private static string Format(object? argument) => argument switch
        {
            null => "null",
            string s => $"'{s}'",
            decimal d => d.ToString(CultureInfo.InvariantCulture),
            IFormattable f => f.ToString(null, CultureInfo.InvariantCulture),
            CqlQuantity q => $"{Format(q.value)} '{q.unit}'",
            ICqlInterval interval => FormatInterval(interval.ToCqlIntervalOfObject()),
            _ => argument.ToString() ?? "",
        };

        private static string FormatInterval(CqlInterval<object> interval) =>
            $"Interval{(interval.lowClosed == true ? "[" : "(")}{Format(interval.low)}, {Format(interval.high)}{(interval.highClosed == true ? "]" : ")")}";

        /// <summary>
        /// The boundary values per parameter type, in a full and an extremes-only variant.
        /// </summary>
        private sealed class Domains
        {
            private readonly Dictionary<Type, (IReadOnlyList<object?> Full, IReadOnlyList<object?> Extremes)> _points = new()
            {
                [typeof(int?)] = Numbers(int.MinValue, int.MaxValue, 0, 1, -1),
                [typeof(long?)] = Numbers(long.MinValue, long.MaxValue, 0L, 1L, -1L),
                [typeof(decimal?)] = Numbers(decimal.MinValue, decimal.MaxValue, 0m, 1m, -1m, FractionalValues),
                [typeof(CqlQuantity)] = (
                    [.. Units.SelectMany(u => new decimal[] { decimal.MaxValue, decimal.MinValue, 0m, 1m, -1m }.Concat(FractionalValues).Select(v => new CqlQuantity(v, u))), null],
                    [.. ExtremeUnits.SelectMany(u => new decimal[] { decimal.MaxValue, decimal.MinValue }.Select(v => new CqlQuantity(v, u))), null]),
                [typeof(CqlDate)] = Temporal(
                    CqlDate.MinValue,
                    CqlDate.MaxValue,
                    new CqlDate(2020, 6, 15),
                    new CqlDate(2020, null, null)),
                [typeof(CqlDateTime)] = Temporal(
                    CqlDateTime.MinValue,
                    CqlDateTime.MaxValue,
                    new CqlDateTime(2020, 6, 15, 12, 30, 45, 500, 0, 0),
                    new CqlDateTime(2020, null, null, null, null, null, null, null, null)),
                [typeof(CqlTime)] = Temporal(
                    CqlTime.MinValue,
                    CqlTime.MaxValue,
                    new CqlTime(12, 30, 45, 500, null, null),
                    new CqlTime(12, null, null, null, null, null)),
            };

            private readonly Dictionary<(Type, bool Narrow), (IReadOnlyList<object?> Full, IReadOnlyList<object?> Extremes)> _intervals = new();

            private static readonly IReadOnlyList<object?> PrecisionDomain = [null, .. Precisions];

            /// <summary>
            /// A precision only qualifies temporal values, so an operator over other types gets null and one precision.
            /// </summary>
            private static readonly IReadOnlyList<object?> NonTemporalPrecisionDomain = [null, Precisions[0]];

            private static readonly IReadOnlyList<object?> UnitDomain = [null, .. Units];

            public IReadOnlyList<object?> For(ParameterInfo parameter, MethodInfo method, bool extremesOnly)
            {
                var type = parameter.ParameterType;
                if (type == typeof(string))
                    return parameter.Name == "unit" ? UnitDomain
                        : method.GetParameters().Any(p => IsTemporal(p.ParameterType)) ? PrecisionDomain
                        : NonTemporalPrecisionDomain;

                if (_points.TryGetValue(type, out var points))
                    return extremesOnly ? points.Extremes : points.Full;

                // Expansion enumerates every point of the interval, so it gets only intervals of a few points.
                var narrow = method.Name == nameof(ICqlOperators.Expand);
                var key = (type.GetGenericArguments()[0], narrow);
                if (!_intervals.TryGetValue(key, out var intervals))
                    _intervals[key] = intervals = Intervals(type, _points[key.Item1], narrow);
                return extremesOnly ? intervals.Extremes : intervals.Full;
            }

            private static bool IsTemporal(Type type) =>
                type == typeof(CqlDate) || type == typeof(CqlDateTime) || type == typeof(CqlTime)
                || (type.IsGenericType && IsTemporal(type.GetGenericArguments()[0]));

            private static (IReadOnlyList<object?>, IReadOnlyList<object?>) Numbers<T>(T min, T max, T zero, T one, T minusOne, params T[] more) where T : struct =>
                ([min, max, zero, one, minusOne, .. more.Cast<object?>(), null], [min, max, null]);

            private static (IReadOnlyList<object?>, IReadOnlyList<object?>) Temporal(object min, object max, object mid, object coarse) =>
                ([min, max, mid, coarse, null], [min, max, null]);

            /// <summary>
            /// Closed and open intervals at the extremes of the point type, and intervals with a null boundary. For a
            /// quantity point type the intervals are built per unit from that unit's extreme quantities.
            /// </summary>
            private static (IReadOnlyList<object?>, IReadOnlyList<object?>) Intervals(
                Type intervalType,
                (IReadOnlyList<object?> Full, IReadOnlyList<object?> Extremes) points,
                bool narrow)
            {
                var full = new List<object?>();
                var extremes = new List<object?>();

                if (intervalType.GetGenericArguments()[0] == typeof(CqlQuantity))
                {
                    foreach (var unit in Units)
                    {
                        var q = points.Full.OfType<CqlQuantity>().Where(q => q.unit == unit).ToArray();
                        AddQuantityIntervals(full, ExtremeUnits.Contains(unit) ? extremes : null, intervalType, q[1], q[0], q[2], q[3], narrow);
                    }
                }
                else
                {
                    // Numbers get Interval[0, 1]; temporal types get a point interval at full and at coarse precision.
                    var p = points.Full;
                    var temporal = p[2] is not ValueType;
                    Add(full, extremes, intervalType, p[0], p[1], p[2], temporal ? p[2] : p[3], narrow);
                    if (temporal)
                        full.Add(MakeInterval(intervalType, p[3], p[3], true, true));

                    // Adding a fractional per to a Decimal this large rounds the per away, so expansion does not advance.
                    if (narrow && p[0] is decimal)
                        full.Add(MakeInterval(intervalType, decimal.MaxValue - 1, decimal.MaxValue - 1, true, true));
                }

                full.Add(null);
                extremes.Add(null);
                return (full, extremes);
            }

            private static object MakeInterval(Type intervalType, object? low, object? high, bool lowClosed, bool highClosed)
            {
                var pointType = intervalType.GetGenericArguments()[0];
                var constructor = intervalType.GetConstructor([pointType, pointType, typeof(bool), typeof(bool)])!;
                return constructor.Invoke([low, high, lowClosed, highClosed]);
            }

            /// <summary>
            /// Quantity intervals come in every unit, so they get fewer shapes per unit than the other point types.
            /// </summary>
            private static void AddQuantityIntervals(List<object?> full, List<object?>? extremes, Type intervalType, object min, object max, object zero, object one, bool narrow)
            {
                object Make(object? low, object? high, bool lowClosed, bool highClosed) =>
                    MakeInterval(intervalType, low, high, lowClosed, highClosed);

                var openAtMax = Make(max, max, false, true);
                if (!narrow)
                {
                    var minToMax = Make(min, max, true, true);
                    full.Add(minToMax);
                    extremes?.Add(minToMax);
                }

                full.AddRange([openAtMax, Make(min, min, true, false), Make(zero, one, true, true), Make(min, null, true, false), Make(null, max, false, true)]);
                extremes?.Add(openAtMax);
            }

            private static void Add(List<object?> full, List<object?> extremes, Type intervalType, object? min, object? max, object? a, object? b, bool narrow)
            {
                object Make(object? low, object? high, bool lowClosed, bool highClosed) =>
                    MakeInterval(intervalType, low, high, lowClosed, highClosed);

                if (!narrow)
                {
                    var minToMax = Make(min, max, true, true);
                    full.Add(minToMax);
                    extremes.Add(minToMax);
                    full.Add(Make(min, max, false, false));
                }

                var atMax = Make(max, max, true, true);
                var atMin = Make(min, min, true, true);
                var openAtMax = Make(max, max, false, true);
                var openAtMin = Make(min, min, true, false);
                full.AddRange([atMax, atMin, openAtMax, openAtMin, Make(a, b, true, true)]);
                extremes.AddRange([atMax, atMin, openAtMax, openAtMin]);

                var openNullHigh = Make(min, null, true, false);
                var openNullLow = Make(null, max, false, true);
                full.AddRange([openNullHigh, openNullLow, Make(min, null, true, true), Make(null, max, true, true)]);
                extremes.AddRange([openNullHigh, openNullLow]);
            }
        }
    }
}
