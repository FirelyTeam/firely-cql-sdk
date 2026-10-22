/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.Text.RegularExpressions;

namespace Hl7.Cql.CqlToElm.Test.SpecMirror
{
    /// <summary>
    /// A type as written in a signature of the CQL reference: a name with at most one type argument,
    /// e.g. <c>Integer</c>, <c>T</c>, <c>List&lt;T&gt;</c> or <c>List&lt;Interval&lt;T&gt;&gt;</c>.
    /// </summary>
    internal sealed record SpecType(string Name, SpecType? Argument = null)
    {
        /// <summary>The generic type parameter of a signature.</summary>
        public bool IsGenericParameter => Name == "T";

        /// <summary>A <c>List</c> or <c>Interval</c>.</summary>
        public bool IsConstructed => Argument is not null;

        /// <summary>Whether the type is, or has as its (nested) argument, the generic type parameter.</summary>
        public bool ContainsGenericParameter => IsGenericParameter || Argument?.ContainsGenericParameter == true;

        /// <summary>The type with every occurrence of the generic type parameter replaced by <paramref name="type"/>.</summary>
        public SpecType Substitute(SpecType type) =>
            IsGenericParameter ? type
            : Argument is null ? this
            : this with { Argument = Argument.Substitute(type) };

        public override string ToString() => Argument is null ? Name : $"{Name}<{Argument}>";

        /// <summary>
        /// Parses a type, normalizing the spelling the reference is inconsistent about
        /// (<c>list&lt;T&gt;</c>, <c>interval&lt;T&gt;</c>, <c>string</c>) and the reference types the
        /// vocabulary operators name (<c>ValueSetRef</c>, <c>CodeSystemRef</c>) to the system type they refer to.
        /// </summary>
        public static SpecType Parse(string text)
        {
            text = text.Trim();
            var open = text.IndexOf('<');
            if (open < 0)
                return new SpecType(NormalizeName(text));

            if (!text.EndsWith('>'))
                throw new FormatException($"Unbalanced type '{text}'.");
            return new SpecType(NormalizeName(text[..open]), Parse(text[(open + 1)..^1]));
        }

        private static string NormalizeName(string name)
        {
            name = name.Trim();
            if (name.Length == 0)
                throw new FormatException("Empty type name.");
            name = char.ToUpperInvariant(name[0]) + name[1..];
            return name switch
            {
                "ValueSetRef" => "ValueSet",
                "CodeSystemRef" => "CodeSystem",
                _ => name,
            };
        }
    }

    /// <summary>
    /// One signature of an operator in the CQL reference, attributed to the name the operator is
    /// declared under in the system library.
    /// </summary>
    /// <param name="Name">The system-library name the signature belongs to.</param>
    /// <param name="Section">The reference section (e.g. <c>Interval Operators</c>) the signature was found in.</param>
    /// <param name="Heading">The reference heading the signature was found under.</param>
    /// <param name="Text">The signature as written in the reference, with continuation lines joined.</param>
    /// <param name="Operands">The operand types.</param>
    /// <param name="Result">The result type, or <see langword="null"/> where the reference omits it.</param>
    internal sealed record SpecSignature(string Name, string Section, string Heading, string Text, IReadOnlyList<SpecType> Operands, SpecType? Result)
    {
        /// <summary>The identity of the signature within its name: the operand types.</summary>
        public string OperandKey => string.Join(", ", Operands);

        /// <summary>Whether an operand or the result mentions the generic type parameter.</summary>
        public bool IsGeneric => Operands.Any(o => o.ContainsGenericParameter) || Result?.ContainsGenericParameter == true;

        /// <summary>The signature with the generic type parameter replaced by <paramref name="type"/> in its operands and result.</summary>
        public SpecSignature Instantiate(SpecType type) => this with
        {
            Operands = Operands.Select(o => o.Substitute(type)).ToList(),
            Result = Result?.Substitute(type),
        };

        public override string ToString() => $"{Name}({OperandKey})" + (Result is null ? "" : $" {Result}");
    }

    /// <summary>
    /// A form listed in a signature block that is operator syntax rather than a signature with an operand list,
    /// e.g. <c>convert &lt;quantity&gt; to &lt;unit&gt;</c>.
    /// </summary>
    internal sealed record SpecSyntaxForm(string Heading, string Text);

    /// <summary>
    /// The operators of Appendix B (CQL Reference) of the spec mirror, keyed by the name the system
    /// library declares them under.
    /// </summary>
    internal sealed class CqlReferenceSignatures
    {
        /// <summary>The path of the reference in the spec mirror, relative to the repository root.</summary>
        public const string MirrorPath = "spec/cql/condensed/09-b-cqlreference.md";

        private CqlReferenceSignatures(
            IReadOnlyDictionary<string, IReadOnlyList<SpecSignature>> operators,
            IReadOnlyList<SpecSyntaxForm> syntaxForms)
        {
            Operators = operators;
            SyntaxForms = syntaxForms;
        }

        /// <summary>
        /// The operators by system-library name. Signatures are distinct by operand types: a synonym
        /// (<c>during</c> for <c>included in</c>, <c>&amp;</c> for <c>+</c> on strings, <c>on or after</c> for
        /// <c>same or after</c>) adds a signature only where its operand types differ.
        /// </summary>
        public IReadOnlyDictionary<string, IReadOnlyList<SpecSignature>> Operators { get; }

        /// <summary>Forms in a signature block that have no operand list.</summary>
        public IReadOnlyList<SpecSyntaxForm> SyntaxForms { get; }

        /// <summary>
        /// Headings whose system-library name is not the heading with its spaces removed.
        /// </summary>
        private static readonly Dictionary<string, string> HeadingNames = new()
        {
            ["Properly Includes"] = "ProperIncludes",
            ["Properly Included In"] = "ProperIncludedIn",
            ["Difference"] = "DifferenceBetween",
            ["Duration"] = "DurationBetween",
            ["Maximum"] = "MaxValue",
            ["Minimum"] = "MinValue",
            // The reference: "The on or after operator ... is a synonym for the same or after operator".
            ["On Or After"] = "SameOrAfter",
            ["On Or Before"] = "SameOrBefore",
            ["ExpandValueSet (ValueSet)"] = "ExpandValueSet",
            ["In (Codesystem)"] = "InCodeSystem",
            ["In (Valueset)"] = "InValueSet",
            ["Date and Time Component From"] = "DateTimeComponentFrom",
        };

        private static readonly Regex HeadingLine = new(@"^(?<level>#{3,5}) (?<title>.+?)\s*$", RegexOptions.Compiled);
        private static readonly Regex FunctionName = new(@"^[A-Z][A-Za-z]*$", RegexOptions.Compiled);

        /// <summary>Parses the reference in the spec mirror.</summary>
        public static CqlReferenceSignatures Load(string path) => Parse(File.ReadAllLines(path));

        /// <summary>Parses the lines of the reference.</summary>
        public static CqlReferenceSignatures Parse(IEnumerable<string> lines)
        {
            var operators = new Dictionary<string, List<SpecSignature>>();
            var syntaxForms = new List<SpecSyntaxForm>();

            foreach (var (section, heading, signatureTexts) in ReadSignatureBlocks(lines))
            {
                var parsed = new List<(string Prefix, IReadOnlyList<SpecType> Operands, SpecType? Result, string Text)>();
                foreach (var text in signatureTexts)
                {
                    if (TryParseSignature(text, out var prefix, out var operands, out var result))
                        parsed.Add((prefix, operands, result, text));
                    else
                        syntaxForms.Add(new SpecSyntaxForm(heading, text));
                }

                // A heading that lists several differently named functions (Age, AgeAt, CalculateAge,
                // CalculateAgeAt) declares each under its own name. Otherwise the heading names the operator:
                // its signatures are written in operator syntax, and in one case (ReplaceMatches) under the
                // wrong function name.
                var nameFromSignature = parsed.All(p => FunctionName.IsMatch(p.Prefix))
                    && parsed.Select(p => p.Prefix).Distinct().Count() > 1;

                foreach (var (prefix, operands, result, text) in parsed)
                {
                    var name = nameFromSignature ? prefix : NameFor(heading, prefix, operands);
                    if (!operators.TryGetValue(name, out var signatures))
                        operators.Add(name, signatures = new List<SpecSignature>());

                    var signature = new SpecSignature(name, section, heading, text, operands, result);
                    if (signatures.All(s => s.OperandKey != signature.OperandKey))
                        signatures.Add(signature);
                }
            }

            return new CqlReferenceSignatures(
                operators.ToDictionary(kvp => kvp.Key, kvp => (IReadOnlyList<SpecSignature>)kvp.Value.AsReadOnly()),
                syntaxForms.AsReadOnly());
        }

        /// <summary>
        /// The system-library name of a signature written under <paramref name="heading"/>, for headings
        /// whose signatures do not each carry a function name.
        /// </summary>
        private static string NameFor(string heading, string prefix, IReadOnlyList<SpecType> operands)
        {
            var name = HeadingNames.TryGetValue(heading, out var mapped) ? mapped : heading.Replace(" ", "");
            var words = prefix.ToLowerInvariant().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var pointLeft = operands.Count == 2 && !operands[0].IsConstructed && operands[1].IsConstructed;

            switch (name)
            {
                // "x included in X" and "x during X" for a point x are the reference's synonyms for "x in X".
                case "IncludedIn" when pointLeft:
                    return "In";
                case "ProperIncludedIn" when pointLeft:
                    return "ProperIn";

                // The reference lists "meets before"/"meets after" and "overlaps before"/"overlaps after"
                // under the plain heading; the system library declares each separately.
                case "Meets" or "Overlaps" when words.Contains("before"):
                    return name + "Before";
                case "Meets" or "Overlaps" when words.Contains("after"):
                    return name + "After";

                // A list on the left is the Any* form of the vocabulary membership operators.
                case "InCodeSystem" or "InValueSet" when operands.Count > 0 && operands[0].Name == "List":
                    return "Any" + name;

                // The component-from heading lists four operators.
                case "DateTimeComponentFrom" when words.FirstOrDefault() == "timezoneoffset":
                    return "TimezoneOffsetFrom";
                case "DateTimeComponentFrom" when words.FirstOrDefault() == "date":
                    return "DateFrom";
                case "DateTimeComponentFrom" when words.FirstOrDefault() == "time":
                    return "TimeFrom";

                default:
                    return name;
            }
        }

        /// <summary>
        /// Reads the code block that follows each <c>**Signature:**</c>/<c>**Signatures:**</c> marker,
        /// returning one entry per signature with continuation lines joined, together with the heading and the
        /// section (the enclosing <c>###</c> heading) it was found under.
        /// </summary>
        private static IEnumerable<(string Section, string Heading, IReadOnlyList<string> Signatures)> ReadSignatureBlocks(IEnumerable<string> lines)
        {
            string? section = null;
            string? heading = null;
            var state = 0; // 0: prose, 1: after a signature marker, 2: inside its code block
            var signatures = new List<string>();
            var pending = new StringBuilder();

            foreach (var line in lines)
            {
                switch (state)
                {
                    case 0:
                        var match = HeadingLine.Match(line);
                        if (match.Success)
                        {
                            heading = match.Groups["title"].Value;
                            if (match.Groups["level"].Length == 3)
                                section = heading;
                        }
                        else if (line.StartsWith("**Signature", StringComparison.Ordinal))
                            state = 1;
                        break;

                    case 1:
                        if (line.StartsWith("```", StringComparison.Ordinal))
                            state = 2;
                        break;

                    case 2:
                        if (line.StartsWith("```", StringComparison.Ordinal))
                        {
                            if (pending.Length > 0)
                                throw new FormatException($"Unterminated signature '{pending}' under '{heading}'.");
                            if (heading is null || section is null)
                                throw new FormatException("Signature block before any heading.");
                            yield return (section, heading, signatures.ToList());
                            signatures.Clear();
                            state = 0;
                            break;
                        }

                        if (string.IsNullOrWhiteSpace(line))
                            break;

                        // A signature that does not fit on a line (DateTime) continues on the next.
                        if (pending.Length > 0)
                            pending.Append(' ');
                        pending.Append(line.Trim());
                        var text = pending.ToString();
                        if (text.Count(c => c == '(') <= text.Count(c => c == ')'))
                        {
                            signatures.Add(Regex.Replace(text, @"\s+", " "));
                            pending.Clear();
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Splits <c>prefix(operands) result</c>. The prefix is the function name or operator syntax with any
        /// <c>&lt;T&gt;</c> and the <c>_precision_</c>/<c>_duration_</c> placeholders removed; an operand is
        /// <c>name Type</c>, or just <c>Type</c> where the reference leaves the name out; the result may be
        /// written after a colon, or be missing.
        /// </summary>
        private static bool TryParseSignature(string text, out string prefix, out IReadOnlyList<SpecType> operands, out SpecType? result)
        {
            prefix = "";
            operands = Array.Empty<SpecType>();
            result = null;

            // The operand list opens at the first '(' outside a type argument.
            var depth = 0;
            var open = -1;
            for (var i = 0; i < text.Length && open < 0; i++)
            {
                switch (text[i])
                {
                    case '<' when i + 1 < text.Length && char.IsLetter(text[i + 1]) && text.IndexOf('>', i) > i:
                        // "<T>" after a name, but not the operators "<", "<=".
                        if (text[i..].StartsWith("<T>", StringComparison.Ordinal))
                            i += 2;
                        else
                            depth++;
                        break;
                    case '>' when depth > 0:
                        depth--;
                        break;
                    case '(' when depth == 0:
                        open = i;
                        break;
                }
            }
            if (open < 0)
                return false;

            var close = text.LastIndexOf(')');
            prefix = Regex.Replace(text[..open].Replace("<T>", ""), @"_[a-z]+_", " ");
            prefix = Regex.Replace(prefix, @"\s+", " ").Trim();

            operands = SplitTopLevel(text[(open + 1)..close])
                .Select(operand =>
                {
                    var parts = operand.Trim().Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
                    return SpecType.Parse(parts.Length == 2 ? parts[1] : parts[0]);
                })
                .ToList();

            var rest = text[(close + 1)..].Trim().TrimStart(':').Trim();
            result = rest.Length == 0 ? null : SpecType.Parse(rest);
            return true;
        }

        private static IEnumerable<string> SplitTopLevel(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                yield break;
            var depth = 0;
            var start = 0;
            for (var i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '<': depth++; break;
                    case '>': depth--; break;
                    case ',' when depth == 0:
                        yield return text[start..i];
                        start = i + 1;
                        break;
                }
            }
            yield return text[start..];
        }
    }
}
