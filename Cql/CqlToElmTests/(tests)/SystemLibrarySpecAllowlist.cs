/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Gaps between the system library and the CQL reference that <see cref="SystemLibrarySpecTest"/> accepts,
    /// each with the reason. A key is an operator name, for an operator the system scope does not declare, or a
    /// signature as the test prints it (<c>Name(Operand, Operand) Result</c>), for a signature no declared
    /// overload covers. An entry that no longer matches a gap fails the test, so remove it when the gap closes.
    /// </summary>
    internal static class SystemLibrarySpecAllowlist
    {
        internal static readonly Dictionary<string, string> Entries = new()
        {
            // Operators with a type argument: written as syntax, built directly in UnaryExpressionVisitor.
            { "As", "Operator syntax only (`as T`, `cast as T`); its type argument is a type specifier, built directly in UnaryExpressionVisitor." },
            { "Is", "Operator syntax only (`is T`); its type argument is a type specifier, built directly in UnaryExpressionVisitor." },
            { "Convert", "Operator syntax only (`convert x to T`); its type argument is a type specifier, built directly in UnaryExpressionVisitor." },
            { "MaxValue", "Operator syntax only (`maximum T`); its type argument is a type specifier, built directly in UnaryExpressionVisitor." },
            { "MinValue", "Operator syntax only (`minimum T`); its type argument is a type specifier, built directly in UnaryExpressionVisitor." },
            { "NotEquivalent", "ELM has no NotEquivalent; `!~` translates to Not(Equivalent(...)) in BinaryExpressionVisitor." },

            // Built directly by a visitor, bypassing overload resolution.
            { "Meets", "Operator syntax only, built directly in TimingExpressionVisitor (#1736)." },
            { "MeetsBefore", "Operator syntax only, built directly in TimingExpressionVisitor (#1736)." },
            { "MeetsAfter", "Operator syntax only, built directly in TimingExpressionVisitor (#1736)." },
            { "Negate", "Unary minus is built directly in LiteralVisitor (#1736)." },
            { "Indexer(List<T>, Integer) T", "Only the String overload is declared; the list indexer is built directly in BinaryExpressionVisitor (#1736)." },

            // Missing from the system library.
            { "CanConvertQuantity", "Missing (#1737)." },
            { "ConvertQuantity", "Function form missing (#1737); `convert x to unit` is built directly in UnaryExpressionVisitor." },
            { "Children", "Missing (#1737)." },
            { "Descendants", "Missing under its spec name (#1737); only the fluent `descendents` is declared." },
            { "ConvertsToBoolean", "Missing (#1737)." },
            { "ConvertsToDate", "Missing (#1737)." },
            { "ConvertsToDateTime", "Missing (#1737)." },
            { "ConvertsToDecimal", "Missing (#1737)." },
            { "ConvertsToInteger", "Missing (#1737)." },
            { "ConvertsToLong", "Missing (#1737)." },
            { "ConvertsToQuantity", "Missing (#1737)." },
            { "ConvertsToRatio", "Missing (#1737)." },
            { "ConvertsToString", "Missing (#1737)." },
            { "ConvertsToTime", "Missing (#1737)." },
            { "ToDate", "Missing (#1737); only built as an implicit conversion in CoercionProvider." },
            { "ToRatio", "Missing (#1737); only built as an implicit conversion in CoercionProvider." },
            { "SplitOnMatches", "Missing (#1737)." },
            { "GeometricMean", "Missing (#1737)." },
            { "Size", "Missing (#1737)." },
            { "InCodeSystem", "Missing (#1737)." },
            { "AnyInCodeSystem", "Missing (#1737)." },
            { "ExpandValueSet", "Missing as a callable (#1737); only built as an implicit conversion in CoercionProvider." },

            // Declared with a narrower or different signature set.
            { "ToLong(Boolean) Long", "Only the Integer overload is declared (#1738)." },
            { "ToLong(String) Long", "Only the Integer overload is declared (#1738)." },
            { "ToQuantity(Long) Quantity", "Long overload missing (#1738)." },
            { "Power(Integer, Integer) Integer", "Declared to return Decimal (#1738)." },
            { "Power(Long, Long) Long", "Declared to return Decimal (#1738)." },
            { "Between(Interval<T>, T, T) Boolean", "Interval form missing (#1738)." },
            { "AgeInHoursAt(DateTime) Integer", "Declared binary; the spec signature is unary (#1738)." },
            { "AgeInMinutesAt(DateTime) Integer", "Declared binary; the spec signature is unary (#1738)." },
            { "AgeInSecondsAt(DateTime) Integer", "Declared binary; the spec signature is unary (#1738)." },
        };
    }
}
