/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Test.SpecMirror;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Cross-checks the system library of the translator against the operators of Appendix B (CQL Reference)
    /// of the spec mirror: every operator must resolve in the system scope, and every signature the
    /// reference lists must be covered by a declared overload. Deliberate and tracked omissions are
    /// listed in <see cref="SystemLibrarySpecAllowlist"/>.
    /// </summary>
    [TestClass]
    public class SystemLibrarySpecTest
    {
        private static readonly Lazy<CqlReferenceSignatures> Reference = new(() =>
            CqlReferenceSignatures.Load(Path.Combine(AppContext.BaseDirectory, "SpecMirror", "09-b-cqlreference.md")));

        [TestMethod]
        public void Reference_Is_Parsed()
        {
            var operators = Reference.Value.Operators;

            // Guards the cross-check against passing vacuously on a parser that finds nothing.
            operators.Count.Should().BeGreaterThan(150);
            operators.Values.Sum(s => s.Count).Should().BeGreaterThan(400);

            // Merged across the arithmetic and date/time sections.
            operators["Add"].Select(s => s.OperandKey).Should().BeEquivalentTo(
                "Integer, Integer", "Long, Long", "Decimal, Decimal", "Quantity, Quantity",
                "Date, Quantity", "DateTime, Quantity", "Time, Quantity");
            // A signature continued over several lines.
            operators["DateTime"].Should().HaveCount(8);
            operators["DateTime"][^1].OperandKey.Should().Be("Integer, Integer, Integer, Integer, Integer, Integer, Integer, Decimal");
            // Named after the heading, not the misnamed signature.
            operators["ReplaceMatches"].Should().ContainSingle().Which.OperandKey.Should().Be("String, String, String");
            operators["Matches"].Should().ContainSingle();
            // One heading listing many differently named functions.
            operators["AgeInHoursAt"].Should().ContainSingle().Which.OperandKey.Should().Be("DateTime");
            // Synonyms add no signature; a point on the left of "included in" is "in".
            operators["IncludedIn"].Select(s => s.OperandKey).Should().BeEquivalentTo("Interval<T>, Interval<T>", "List<T>, List<T>");
            operators["In"].Select(s => s.OperandKey).Should().BeEquivalentTo("T, Interval<T>", "T, List<T>");
            operators["SameOrAfter"].Should().HaveCount(6);
            // Lower-case and reference types normalized; result type missing.
            operators["AnyInValueSet"].Select(s => s.OperandKey).Should().BeEquivalentTo("List<Code>, ValueSet", "List<String>, ValueSet", "List<Concept>, ValueSet");
            operators["CanConvertQuantity"].Should().ContainSingle().Which.Result.Should().BeNull();
            operators["DateTimeComponentFrom"].Should().HaveCount(3);
            operators["TimezoneOffsetFrom"].Should().ContainSingle();
            operators["MeetsBefore"].Should().ContainSingle();

            Reference.Value.SyntaxForms.Should().ContainSingle().Which.Text.Should().Be("convert <quantity> to <unit>");
        }

        [TestMethod]
        public void SystemLibrary_Covers_Reference()
        {
            var declared = DeclaredOverloads();
            var findings = new Dictionary<string, string>();

            foreach (var (name, signatures) in Reference.Value.Operators.OrderBy(kvp => kvp.Key, StringComparer.Ordinal))
            {
                if (!declared.TryGetValue(name, out var overloads))
                {
                    findings.Add(name, $"{name}: not declared (reference lists {string.Join("; ", signatures.Select(s => s.Text))})");
                    continue;
                }

                foreach (var signature in signatures.Where(s => !overloads.Any(o => o.Covers(s))))
                    findings.Add(signature.ToString(), $"{signature}: no overload covers '{signature.Text}' (declared: {string.Join("; ", overloads)})");
            }

            var allowlist = SystemLibrarySpecAllowlist.Entries;
            var unexpected = findings.Where(f => !allowlist.ContainsKey(f.Key)).Select(f => f.Value).ToList();
            var stale = allowlist.Keys.Where(k => !findings.ContainsKey(k)).OrderBy(k => k, StringComparer.Ordinal).ToList();

            var message = new StringBuilder();
            if (unexpected.Count > 0)
            {
                message.AppendLine($"{unexpected.Count} operator(s) or signature(s) of {CqlReferenceSignatures.MirrorPath} are not covered by SystemLibrary:");
                foreach (var line in unexpected)
                    message.AppendLine("  " + line);
            }
            if (stale.Count > 0)
            {
                message.AppendLine($"{stale.Count} entr(y/ies) of {nameof(SystemLibrarySpecAllowlist)} no longer match a gap; remove them:");
                foreach (var key in stale)
                    message.AppendLine("  " + key);
            }

            if (message.Length > 0)
                Assert.Fail(message.ToString());
        }

        /// <summary>
        /// The overloads of the system scope by name: the functions it resolves, and the
        /// <see cref="OperatorOnlyAttribute"/> symbols that only operator syntax reaches.
        /// </summary>
        private static Dictionary<string, IReadOnlyList<DeclaredOverload>> DeclaredOverloads()
        {
            var system = new SystemLibrary();
            var result = new Dictionary<string, IReadOnlyList<DeclaredOverload>>();

            foreach (var name in Reference.Value.Operators.Keys)
            {
                if (system.TryResolveFunction(name, out var function))
                    result.Add(name, Overloads(function));
            }

            var operatorOnly = typeof(SystemLibrary)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(field => field.IsDefined(typeof(OperatorOnlyAttribute), inherit: false))
                .Select(field => field.GetValue(null))
                .OfType<IFunctionElement>();
            foreach (var function in operatorOnly)
                result.TryAdd(function.Name, Overloads(function));

            return result;
        }

        private static IReadOnlyList<DeclaredOverload> Overloads(IFunctionElement function) =>
            (function switch
            {
                OverloadedFunctionDef overloaded => overloaded.Functions.OfType<SystemFunction>(),
                SystemFunction single => new[] { single },
                _ => throw new InvalidOperationException($"Unexpected system symbol {function.GetType().Name} '{function.Name}'."),
            })
            .Select(DeclaredOverload.From)
            .ToList();

        /// <summary>
        /// A declared overload, accepting every arity from its required parameter count to its operand count.
        /// </summary>
        private sealed record DeclaredOverload(string Name, IReadOnlyList<SpecType> Operands, int RequiredCount, SpecType Result)
        {
            public static DeclaredOverload From(SystemFunction function)
            {
                var operands = function.operand?.Select(o => ToSpecType(o.operandTypeSpecifier)).ToList() ?? new List<SpecType>();
                var required = function.RequiredParameterCount ?? operands.Count;

                // The trailing String operand of a *WithPrecision function carries the precision of a timing
                // phrase; the reference writes it as a _precision_ placeholder, not as an operand.
                var precision = function.ElmNodeType.GetProperty("precision")?.PropertyType == typeof(DateTimePrecision);
                if (precision && required == operands.Count - 1 && operands[^1].Name == "String")
                    operands.RemoveAt(operands.Count - 1);

                return new DeclaredOverload(function.name, operands, required, ToSpecType(function.resultTypeSpecifier));
            }

            public bool Covers(SpecSignature signature)
            {
                var arity = signature.Operands.Count;
                if (arity < RequiredCount || arity > Operands.Count)
                    return false;
                for (var i = 0; i < arity; i++)
                {
                    if (!Accepts(signature.Operands[i], Operands[i]))
                        return false;
                }
                return signature.Result is null || Accepts(signature.Result, Result);
            }

            /// <summary>
            /// Whether a declared type accepts a reference type. A declared <c>Any</c> accepts everything; a
            /// declared <c>T</c> accepts any type except a list or interval (it does not bind to those, see the
            /// note in <see cref="SystemLibrary"/>). A reference <c>T</c> is satisfied by any declared type.
            /// </summary>
            private static bool Accepts(SpecType reference, SpecType declared) =>
                declared.Name == "Any"
                || (declared.IsGenericParameter && !reference.IsConstructed)
                || reference.IsGenericParameter
                || (reference.Name == declared.Name
                    && (reference.Argument is null) == (declared.Argument is null)
                    && (reference.Argument is null || Accepts(reference.Argument, declared.Argument!)));

            public override string ToString() =>
                $"{Name}({string.Join(", ", Operands.Select((o, i) => i < RequiredCount ? o.ToString() : $"[{o}]"))}) {Result}";

            private static SpecType ToSpecType(TypeSpecifier type) => type switch
            {
                // System type names are written as "{urn:hl7-org:elm-types:r1}Integer".
                NamedTypeSpecifier named => new SpecType(named.name.Name[(named.name.Name.LastIndexOf('}') + 1)..]),
                ListTypeSpecifier list => new SpecType("List", ToSpecType(list.elementType)),
                IntervalTypeSpecifier interval => new SpecType("Interval", ToSpecType(interval.pointType)),
                ParameterTypeSpecifier parameter => new SpecType(parameter.parameterName),
                _ => new SpecType(type.GetType().Name),
            };
        }
    }
}
