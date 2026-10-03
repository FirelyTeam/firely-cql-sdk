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
    /// <remarks>
    /// <para>
    /// A declared overload covers a concrete reference signature when each declared operand accepts the reference
    /// operand and the declared result is exactly the reference result. A declared <c>Any</c> operand accepts every
    /// type; a declared <c>T</c> operand accepts a type other than a list or interval and binds <c>T</c> to it, and
    /// every other occurrence of <c>T</c> in the overload must then be that same type. A declared result is never
    /// allowed to be wider than the reference result: a declared <c>T</c> result must be what the operands bound
    /// <c>T</c> to, and a declared <c>Any</c> result covers only a reference <c>Any</c> result.
    /// </para>
    /// <para>
    /// A reference signature in the generic type parameter <c>T</c> is covered when every instantiation of it, over a
    /// canonical set of types for <c>T</c>, is covered by some declared overload: a generic overload covers them all,
    /// a set of concrete overloads only the types it lists. The canonical set depends on the reference section the
    /// signature is in: the ordered types (Integer, Long, Decimal, Quantity, Date, DateTime, Time, String) for the
    /// comparison operators, the interval point types (the ordered types without String) for the arithmetic operators
    /// (predecessor, successor, minimum, maximum) and the interval operators, and otherwise the ordered types together
    /// with Boolean, Code and Concept. The sets are written out here, from the spec, rather than taken from
    /// <see cref="SystemTypes"/>, which is what the system library declares its overloads with; a test checks the two agree.
    /// </para>
    /// </remarks>
    [TestClass]
    public class SystemLibrarySpecTest
    {
        private static readonly Lazy<CqlReferenceSignatures> Reference = new(() =>
            CqlReferenceSignatures.Load(Path.Combine(AppContext.BaseDirectory, "SpecMirror", "09-b-cqlreference.md")));

        private static readonly SpecType[] IntervalPointTypes = Types("Integer", "Long", "Decimal", "Quantity", "Date", "DateTime", "Time");
        private static readonly SpecType[] OrderedTypes = IntervalPointTypes.Concat(Types("String")).ToArray();
        private static readonly SpecType[] SimpleTypes = OrderedTypes.Concat(Types("Boolean", "Code", "Concept")).ToArray();

        /// <summary>
        /// The canonical types the generic type parameter of a reference signature is instantiated with, by
        /// reference section; <see cref="SimpleTypes"/> for any other section.
        /// </summary>
        private static readonly Dictionary<string, SpecType[]> InstantiationsBySection = new()
        {
            ["Comparison Operators"] = OrderedTypes,
            ["Arithmetic Operators"] = IntervalPointTypes,
            ["Interval Operators"] = IntervalPointTypes,
        };

        private static SpecType[] Types(params string[] names) => names.Select(n => new SpecType(n)).ToArray();

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
            // Attributed to the section the signature is in.
            operators["Collapse"].Should().OnlyContain(s => s.Section == "Interval Operators");
            operators["Add"].Single(s => s.OperandKey == "Integer, Integer").Section.Should().Be("Arithmetic Operators");
            operators["Add"].Single(s => s.OperandKey == "Date, Quantity").Section.Should().Be("Date and Time Operators");

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

                foreach (var signature in signatures)
                {
                    var declaredText = string.Join("; ", overloads);
                    if (!signature.IsGeneric)
                    {
                        if (!overloads.Any(o => o.Covers(signature)))
                            findings.Add(signature.ToString(), $"{signature}: no overload covers '{signature.Text}' (declared: {declaredText})");
                        continue;
                    }

                    var missing = MissingInstantiations(signature, overloads);
                    if (missing.Count > 0)
                        findings.Add(signature.ToString(), $"{signature}: no overload covers '{signature.Text}' for T in {{{string.Join(", ", missing)}}} (declared: {declaredText})");
                }
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

        [TestMethod]
        public void Canonical_Instantiations_Agree_With_SystemTypes()
        {
            SystemTypes.OrderedTypes.Select(DeclaredOverload.ToSpecType).Should().BeEquivalentTo(OrderedTypes,
                "SystemTypes.OrderedTypes should list the ordered types of the spec");
            SystemTypes.IntervalPointTypes.Select(DeclaredOverload.ToSpecType).Should().BeEquivalentTo(IntervalPointTypes,
                "SystemTypes.IntervalPointTypes should list the interval point types of the spec");
        }

        [TestMethod]
        public void Matcher_Rejects_A_Wider_Declared_Result()
        {
            var add = Signature("Add", "Arithmetic Operators", "Integer", "Integer", "Integer");

            Overload("Add", "Any", "Integer", "Integer").Covers(add).Should().BeFalse();
            Overload("Add", "Integer", "Integer", "Integer").Covers(add).Should().BeTrue();

            var distinct = Signature("Distinct", "List Operators", "List<Integer>", "List<Integer>");
            Overload("Distinct", "List<Any>", "List<Integer>").Covers(distinct).Should().BeFalse();
        }

        [TestMethod]
        public void Matcher_Binds_A_Declared_Generic_Parameter()
        {
            var generic = Overload("Add", "T", "T", "T");

            generic.Covers(Signature("Add", "Arithmetic Operators", "Integer", "Integer", "Integer")).Should().BeTrue();
            generic.Covers(Signature("Add", "Arithmetic Operators", "Decimal", "Integer", "Integer")).Should().BeFalse();
            generic.Covers(Signature("Add", "Arithmetic Operators", "Integer", "Integer", "Decimal")).Should().BeFalse();
        }

        [TestMethod]
        public void Matcher_Requires_Every_Instantiation_Of_A_Generic_Reference_Signature()
        {
            var collapse = Signature("Collapse", "Interval Operators", "List<Interval<T>>", "List<Interval<T>>");
            var integerOnly = new[]
            {
                Overload("Collapse", "List<Interval<Integer>>", "List<Interval<Integer>>"),
                Overload("Collapse", "List<Interval<Integer>>", "List<Interval<Integer>>", "Quantity"),
            };

            MissingInstantiations(collapse, integerOnly).Should().Equal(Types("Long", "Decimal", "Quantity", "Date", "DateTime", "Time"));

            var everyPointType = IntervalPointTypes
                .Select(t => Overload("Collapse", $"List<Interval<{t}>>", $"List<Interval<{t}>>"))
                .ToList();
            MissingInstantiations(collapse, everyPointType).Should().BeEmpty();
            MissingInstantiations(collapse, new[] { Overload("Collapse", "List<Interval<T>>", "List<Interval<T>>") }).Should().BeEmpty();
        }

        private static SpecSignature Signature(string name, string section, string result, params string[] operands) =>
            new(name, section, name, $"{name}({string.Join(", ", operands)}) {result}", operands.Select(SpecType.Parse).ToList(), SpecType.Parse(result));

        private static DeclaredOverload Overload(string name, string result, params string[] operands) =>
            new(name, operands.Select(SpecType.Parse).ToList(), operands.Length, SpecType.Parse(result));

        /// <summary>
        /// The types of the canonical set for the section of <paramref name="signature"/> for which no overload
        /// covers the instantiation of the generic signature.
        /// </summary>
        internal static IReadOnlyList<SpecType> MissingInstantiations(SpecSignature signature, IReadOnlyCollection<DeclaredOverload> overloads)
        {
            var types = InstantiationsBySection.TryGetValue(signature.Section, out var sectionTypes) ? sectionTypes : SimpleTypes;
            return types.Where(type => !overloads.Any(o => o.Covers(signature.Instantiate(type)))).ToList();
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
        internal sealed record DeclaredOverload(string Name, IReadOnlyList<SpecType> Operands, int RequiredCount, SpecType Result)
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

            /// <summary>
            /// Whether this overload covers a reference signature: it accepts each reference operand, binding its
            /// generic parameter <c>T</c> consistently, and declares exactly the reference result. The signature is
            /// meant to be concrete (see <see cref="SpecSignature.Instantiate"/>); a reference <c>T</c> is matched
            /// only by a declared <c>T</c> or <c>Any</c>, never by a concrete declared type.
            /// </summary>
            internal bool Covers(SpecSignature signature)
            {
                var arity = signature.Operands.Count;
                if (arity < RequiredCount || arity > Operands.Count)
                    return false;
                SpecType? bound = null;
                for (var i = 0; i < arity; i++)
                {
                    if (!AcceptsOperand(signature.Operands[i], Operands[i], ref bound))
                        return false;
                }
                return signature.Result is null || MatchesResult(signature.Result, Result, bound);
            }

            /// <summary>
            /// Whether a declared operand type accepts a reference operand type. A declared <c>Any</c> accepts
            /// everything; a declared <c>T</c> accepts any type except a list or interval (it does not bind to those,
            /// see the note in <see cref="SystemLibrary"/>), and binds <c>T</c> to it: a <c>T</c> already bound to a
            /// different type does not accept it. Otherwise the names must match, and so must the type arguments.
            /// </summary>
            private static bool AcceptsOperand(SpecType reference, SpecType declared, ref SpecType? bound)
            {
                if (declared.Name == "Any" && !declared.IsConstructed)
                    return true;
                if (declared.IsGenericParameter)
                {
                    if (reference.IsConstructed)
                        return false;
                    bound ??= reference;
                    return bound == reference;
                }
                return reference.Name == declared.Name
                    && (reference.Argument is null) == (declared.Argument is null)
                    && (reference.Argument is null || AcceptsOperand(reference.Argument, declared.Argument!, ref bound));
            }

            /// <summary>
            /// Whether a declared result type is exactly the reference result type: a declared <c>T</c> must have been
            /// bound by the operands to the reference type, a declared <c>Any</c> matches only a reference <c>Any</c>,
            /// and otherwise the names and type arguments must match.
            /// </summary>
            private static bool MatchesResult(SpecType reference, SpecType declared, SpecType? bound) =>
                declared.IsGenericParameter
                    ? bound is not null && bound == reference
                    : reference.Name == declared.Name
                        && (reference.Argument is null) == (declared.Argument is null)
                        && (reference.Argument is null || MatchesResult(reference.Argument, declared.Argument!, bound));

            public override string ToString() =>
                $"{Name}({string.Join(", ", Operands.Select((o, i) => i < RequiredCount ? o.ToString() : $"[{o}]"))}) {Result}";

            internal static SpecType ToSpecType(TypeSpecifier type) => type switch
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
