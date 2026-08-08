/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Iso8601;

namespace CoreTests;

/// <summary>
/// Golden expectations for the ISO 8601 types' text form, captured by running a generator against the
/// eager-formatting implementation before <c>String</c> became lazily computed - never hand-computed.
/// Laziness may only change when the string is built, never what it says, so every row here must pass
/// against develop's implementation and against the lazy one alike.
/// </summary>
/// <remarks>
/// The corpus deliberately includes the cases where the eager code formatted at a precision that does
/// not match the instance's own <c>Precision</c> property - <c>strict: true</c> combined with an explicit
/// precision argument, and an explicit <see cref="DateTimePrecision.Unknown"/> - because those are exactly
/// the rows that a naive lazy rewrite gets wrong. Some of the expectations below are therefore internally
/// inconsistent (a Day-precision instance rendering as just the year, say). That is intentional: this file
/// pins what the eager implementation DID, not what it arguably should have done. Changing that behaviour
/// is a separate, deliberate decision.
/// </remarks>
[TestClass]
[TestCategory("UnitTest")]
public class Iso8601LazyFormattingGoldenTests
{
    private const int ExpectedRowCount = 426;

    [TestMethod]
    public void TextFormMatchesTheEagerImplementationsGoldens()
    {
        var failures = new List<string>();
        var rows = 0;

        foreach (var rawLine in (Golden + "\n" + GoldenPrecisionEdges).Split('\n', StringSplitOptions.RemoveEmptyEntries))
        {
            // Trim '\r' so the corpus keeps working if this file is ever stored with CRLF line endings.
            var line = rawLine.Trim('\r');
            if (line.Length == 0)
                continue;

            rows++;
            var p = line.Split('|');
            int? N(int i) => p[i].Length == 0 ? null : int.Parse(p[i]);
            bool B(int i) => bool.Parse(p[i]);
            DateTimePrecision P(int i) => Enum.Parse<DateTimePrecision>(p[i]);

            var (actual, expected) = p[0] switch
            {
                // original corpus
                "DT" => (Render(() => new DateTimeIso8601(int.Parse(p[1]), N(2), N(3), N(4), N(5), N(6), N(7), N(8), N(9))), p[10]),
                "DTO" => (Render(() => new DateTimeIso8601(new DateTimeOffset(2024, 3, 1, 9, 23, 17, 123, TimeSpan.FromHours(1)), P(1))), p[2]),
                "D" => (Render(() => new DateIso8601(int.Parse(p[1]), N(2), N(3))), p[4]),
                "T" => (Render(() => new TimeIso8601(int.Parse(p[1]), N(2), N(3), N(4), N(5), N(6))), p[7]),
                "P" => (Render(() => DateTimeIso8601.TryParse(p[1], out var pv) ? pv! : (object)"PARSEFAIL"), p[2]),

                // strict / explicit-precision / offset / millisecond edges
                "DTS" => (Render(() => new DateTimeIso8601(int.Parse(p[1]), N(2), N(3), N(4), N(5), N(6), N(7), N(8), N(9), B(10))), p[11]),
                "DTO2" => (Render(() => new DateTimeIso8601(
                    new DateTimeOffset(2024, 3, 15, 10, 30, 45, 123, new TimeSpan(int.Parse(p[3]), int.Parse(p[4]), 0)), P(1), B(2))), p[5]),
                "DCOMP" => (Render(() => new DateTimeIso8601(
                    new DateIso8601(int.Parse(p[1]), N(2), N(3)),
                    N(4) is { } th ? new TimeIso8601(th, N(5), N(6), N(7), N(8), N(9)) : null,
                    B(10))), p[11]),
                "DS" => (Render(() => new DateIso8601(int.Parse(p[1]), N(2), N(3), B(4))), p[5]),
                "DDTO" => (Render(() => new DateIso8601(
                    new DateTimeOffset(2024, 3, 15, 10, 30, 45, 123, TimeSpan.FromHours(1)), P(1), B(2))), p[3]),
                "TS" => (Render(() => new TimeIso8601(int.Parse(p[1]), N(2), N(3), N(4), N(5), N(6), B(7))), p[8]),
                "TSPAN" => (Render(() => new TimeIso8601(
                    new TimeSpan(0, int.Parse(p[1]), int.Parse(p[2]), int.Parse(p[3]), int.Parse(p[4])), N(5), N(6), P(7), B(8))), p[9]),

                _ => ($"UNKNOWN-ROW-KIND:{p[0]}", "-")
            };

            if (actual != expected)
                failures.Add($"{line} => '{actual}' (expected '{expected}')");
        }

        // Report the diverged rows before checking the row count: someone who both adds a row and changes the
        // formatting needs the list of divergences, and a size mismatch reported first would hide it.
        if (failures.Count > 0)
        {
            var shown = string.Join(Environment.NewLine, failures.Take(10));
            if (failures.Count > 10)
                shown += $"{Environment.NewLine}... and {failures.Count - 10} more";
            Assert.Fail($"{failures.Count} of {rows} golden rows diverged:{Environment.NewLine}{shown}");
        }

        Assert.AreEqual(ExpectedRowCount, rows, "The golden corpus changed size - rows were added or lost unintentionally.");
    }

    /// <summary>
    /// Renders a case, mapping a thrown exception to a comparable token so that rows whose expectation is
    /// an exception are pinned the same way as rows whose expectation is text.
    /// </summary>
    private static string Render(Func<object> make)
    {
        try
        {
            return make().ToString()!;
        }
        catch (Exception e)
        {
            return $"THROW:{e.GetType().Name}";
        }
    }

    private const string Golden = @"DT|2024|||||||||2024|Year|True
DT|2024||||||||0|2024|Year|True
DT|2024||||||||30|2024|Year|True
DT|2024|||||||0||2024|Year|True
DT|2024|||||||0|0|2024|Year|True
DT|2024|||||||0|30|2024|Year|True
DT|2024|||||||1||2024|Year|True
DT|2024|||||||1|0|2024|Year|True
DT|2024|||||||1|30|2024|Year|True
DT|2024|||||||-5||2024|Year|True
DT|2024|||||||-5|0|2024|Year|True
DT|2024|||||||-5|30|2024|Year|True
DT|2024|3||||||||2024-03|Month|True
DT|2024|3|||||||0|2024-03|Month|True
DT|2024|3|||||||30|2024-03|Month|True
DT|2024|3||||||0||2024-03|Month|True
DT|2024|3||||||0|0|2024-03|Month|True
DT|2024|3||||||0|30|2024-03|Month|True
DT|2024|3||||||1||2024-03|Month|True
DT|2024|3||||||1|0|2024-03|Month|True
DT|2024|3||||||1|30|2024-03|Month|True
DT|2024|3||||||-5||2024-03|Month|True
DT|2024|3||||||-5|0|2024-03|Month|True
DT|2024|3||||||-5|30|2024-03|Month|True
DT|2024|3|1|||||||2024-03-01|Day|True
DT|2024|3|1||||||0|2024-03-01|Day|True
DT|2024|3|1||||||30|2024-03-01|Day|True
DT|2024|3|1|||||0||2024-03-01|Day|True
DT|2024|3|1|||||0|0|2024-03-01|Day|True
DT|2024|3|1|||||0|30|2024-03-01|Day|True
DT|2024|3|1|||||1||2024-03-01|Day|True
DT|2024|3|1|||||1|0|2024-03-01|Day|True
DT|2024|3|1|||||1|30|2024-03-01|Day|True
DT|2024|3|1|||||-5||2024-03-01|Day|True
DT|2024|3|1|||||-5|0|2024-03-01|Day|True
DT|2024|3|1|||||-5|30|2024-03-01|Day|True
DT|2024|3|1|9||||||2024-03-01T09|Hour|True
DT|2024|3|1|9|||||0|2024-03-01T09|Hour|True
DT|2024|3|1|9|||||30|2024-03-01T09|Hour|True
DT|2024|3|1|9||||0||2024-03-01T09Z|Hour|True
DT|2024|3|1|9||||0|0|2024-03-01T09Z|Hour|True
DT|2024|3|1|9||||0|30|2024-03-01T09+00:30|Hour|True
DT|2024|3|1|9||||1||2024-03-01T09+01:00|Hour|True
DT|2024|3|1|9||||1|0|2024-03-01T09+01:00|Hour|True
DT|2024|3|1|9||||1|30|2024-03-01T09+01:30|Hour|True
DT|2024|3|1|9||||-5||2024-03-01T09-05:00|Hour|True
DT|2024|3|1|9||||-5|0|2024-03-01T09-05:00|Hour|True
DT|2024|3|1|9||||-5|30|2024-03-01T09-05:30|Hour|True
DT|2024|3|1|9|23|||||2024-03-01T09:23|Minute|True
DT|2024|3|1|9|23||||0|2024-03-01T09:23|Minute|True
DT|2024|3|1|9|23||||30|2024-03-01T09:23|Minute|True
DT|2024|3|1|9|23|||0||2024-03-01T09:23Z|Minute|True
DT|2024|3|1|9|23|||0|0|2024-03-01T09:23Z|Minute|True
DT|2024|3|1|9|23|||0|30|2024-03-01T09:23+00:30|Minute|True
DT|2024|3|1|9|23|||1||2024-03-01T09:23+01:00|Minute|True
DT|2024|3|1|9|23|||1|0|2024-03-01T09:23+01:00|Minute|True
DT|2024|3|1|9|23|||1|30|2024-03-01T09:23+01:30|Minute|True
DT|2024|3|1|9|23|||-5||2024-03-01T09:23-05:00|Minute|True
DT|2024|3|1|9|23|||-5|0|2024-03-01T09:23-05:00|Minute|True
DT|2024|3|1|9|23|||-5|30|2024-03-01T09:23-05:30|Minute|True
DT|2024|3|1|9|23|17||||2024-03-01T09:23:17|Second|True
DT|2024|3|1|9|23|17|||0|2024-03-01T09:23:17|Second|True
DT|2024|3|1|9|23|17|||30|2024-03-01T09:23:17|Second|True
DT|2024|3|1|9|23|17||0||2024-03-01T09:23:17Z|Second|True
DT|2024|3|1|9|23|17||0|0|2024-03-01T09:23:17Z|Second|True
DT|2024|3|1|9|23|17||0|30|2024-03-01T09:23:17+00:30|Second|True
DT|2024|3|1|9|23|17||1||2024-03-01T09:23:17+01:00|Second|True
DT|2024|3|1|9|23|17||1|0|2024-03-01T09:23:17+01:00|Second|True
DT|2024|3|1|9|23|17||1|30|2024-03-01T09:23:17+01:30|Second|True
DT|2024|3|1|9|23|17||-5||2024-03-01T09:23:17-05:00|Second|True
DT|2024|3|1|9|23|17||-5|0|2024-03-01T09:23:17-05:00|Second|True
DT|2024|3|1|9|23|17||-5|30|2024-03-01T09:23:17-05:30|Second|True
DT|2024|3|1|9|23|17|123|||2024-03-01T09:23:17.123|Millisecond|True
DT|2024|3|1|9|23|17|123||0|2024-03-01T09:23:17.123|Millisecond|True
DT|2024|3|1|9|23|17|123||30|2024-03-01T09:23:17.123|Millisecond|True
DT|2024|3|1|9|23|17|123|0||2024-03-01T09:23:17.123Z|Millisecond|True
DT|2024|3|1|9|23|17|123|0|0|2024-03-01T09:23:17.123Z|Millisecond|True
DT|2024|3|1|9|23|17|123|0|30|2024-03-01T09:23:17.123+00:30|Millisecond|True
DT|2024|3|1|9|23|17|123|1||2024-03-01T09:23:17.123+01:00|Millisecond|True
DT|2024|3|1|9|23|17|123|1|0|2024-03-01T09:23:17.123+01:00|Millisecond|True
DT|2024|3|1|9|23|17|123|1|30|2024-03-01T09:23:17.123+01:30|Millisecond|True
DT|2024|3|1|9|23|17|123|-5||2024-03-01T09:23:17.123-05:00|Millisecond|True
DT|2024|3|1|9|23|17|123|-5|0|2024-03-01T09:23:17.123-05:00|Millisecond|True
DT|2024|3|1|9|23|17|123|-5|30|2024-03-01T09:23:17.123-05:30|Millisecond|True
DTO|Year|2024|Year
DTO|Month|2024-03|Month
DTO|Day|2024-03-01|Day
DTO|Hour|2024-03-01T09+01:00|Hour
DTO|Minute|2024-03-01T09:23+01:00|Minute
DTO|Second|2024-03-01T09:23:17+01:00|Second
DTO|Millisecond|2024-03-01T09:23:17.123+01:00|Millisecond
D|2024|||2024|Year
D|2024|3||2024-03|Month
D|2024|3|1|2024-03-01|Day
D|1|1|1|0001-01-01|Day
D|9999|12|31|9999-12-31|Day
T|9||||||09|Hour
T|9|||||0|09|Hour
T|9|||||30|09|Hour
T|9||||0||09Z|Hour
T|9||||0|0|09Z|Hour
T|9||||0|30|09+00:30|Hour
T|9||||1||09+01:00|Hour
T|9||||1|0|09+01:00|Hour
T|9||||1|30|09+01:30|Hour
T|9||||-5||09-05:00|Hour
T|9||||-5|0|09-05:00|Hour
T|9||||-5|30|09-05:30|Hour
T|9|23|||||09:23|Minute
T|9|23||||0|09:23|Minute
T|9|23||||30|09:23|Minute
T|9|23|||0||09:23Z|Minute
T|9|23|||0|0|09:23Z|Minute
T|9|23|||0|30|09:23+00:30|Minute
T|9|23|||1||09:23+01:00|Minute
T|9|23|||1|0|09:23+01:00|Minute
T|9|23|||1|30|09:23+01:30|Minute
T|9|23|||-5||09:23-05:00|Minute
T|9|23|||-5|0|09:23-05:00|Minute
T|9|23|||-5|30|09:23-05:30|Minute
T|9|23|17||||09:23:17|Second
T|9|23|17|||0|09:23:17|Second
T|9|23|17|||30|09:23:17|Second
T|9|23|17||0||09:23:17Z|Second
T|9|23|17||0|0|09:23:17Z|Second
T|9|23|17||0|30|09:23:17+00:30|Second
T|9|23|17||1||09:23:17+01:00|Second
T|9|23|17||1|0|09:23:17+01:00|Second
T|9|23|17||1|30|09:23:17+01:30|Second
T|9|23|17||-5||09:23:17-05:00|Second
T|9|23|17||-5|0|09:23:17-05:00|Second
T|9|23|17||-5|30|09:23:17-05:30|Second
T|9|23|17|123|||09:23:17.123|Millisecond
T|9|23|17|123||0|09:23:17.123|Millisecond
T|9|23|17|123||30|09:23:17.123|Millisecond
T|9|23|17|123|0||09:23:17.123Z|Millisecond
T|9|23|17|123|0|0|09:23:17.123Z|Millisecond
T|9|23|17|123|0|30|09:23:17.123+00:30|Millisecond
T|9|23|17|123|1||09:23:17.123+01:00|Millisecond
T|9|23|17|123|1|0|09:23:17.123+01:00|Millisecond
T|9|23|17|123|1|30|09:23:17.123+01:30|Millisecond
T|9|23|17|123|-5||09:23:17.123-05:00|Millisecond
T|9|23|17|123|-5|0|09:23:17.123-05:00|Millisecond
T|9|23|17|123|-5|30|09:23:17.123-05:30|Millisecond
P|2024|2024|Year
P|2024-03|2024-03|Month
P|2024-03-01|2024-03-01|Day
P|2024-03-01T09|2024-03-01T09|Hour
P|2024-03-01T09:23|2024-03-01T09:23|Minute
P|2024-03-01T09:23:17|2024-03-01T09:23:17|Second
P|2024-03-01T09:23:17.123|2024-03-01T09:23:17.123|Millisecond
P|2024-03-01T09:23:17.123+01:00|2024-03-01T09:23:17.123+01:00|Millisecond
P|2024-03-01T09:23:17Z|2024-03-01T09:23:17Z|Second
P|2024-03-01T09:23:17-05:30|2024-03-01T09:23:17-05:30|Second";

    /// <summary>
    /// Captured the same way as <see cref="Golden"/>, covering all seven precisions under
    /// <c>strict: true</c>, explicit <see cref="DateTimePrecision.Unknown"/>, millisecond padding
    /// (0 / 1 / 999), negative, zero, half-hour and absent offsets, and the constructor overloads the
    /// original corpus never touched (the composing date+time constructor, <c>DateIso8601(dto, precision)</c>
    /// and <c>TimeIso8601(span, ..., precision)</c>).
    /// </summary>
    private const string GoldenPrecisionEdges = @"DTS|2024|3|15|10|30|45||||False|2024-03-15T10:30:45
DTS|2024|3|15|10|30|45||||True|2024-03-15T10:30:45
DTS|2024|3|15|10|30|45||0|0|False|2024-03-15T10:30:45Z
DTS|2024|3|15|10|30|45||0|0|True|2024-03-15T10:30:45Z
DTS|2024|3|15|10|30|45||-5|30|False|2024-03-15T10:30:45-05:30
DTS|2024|3|15|10|30|45||-5|30|True|2024-03-15T10:30:45-05:30
DTS|2024|3|15|10|30|45||5|30|False|2024-03-15T10:30:45+05:30
DTS|2024|3|15|10|30|45||5|30|True|2024-03-15T10:30:45+05:30
DTS|2024|3|15|10|30|45||0|30|False|2024-03-15T10:30:45+00:30
DTS|2024|3|15|10|30|45||0|30|True|2024-03-15T10:30:45+00:30
DTS|2024|3|15|10|30|45|0|||False|2024-03-15T10:30:45.000
DTS|2024|3|15|10|30|45|0|||True|2024-03-15T10:30:45.000
DTS|2024|3|15|10|30|45|0|0|0|False|2024-03-15T10:30:45.000Z
DTS|2024|3|15|10|30|45|0|0|0|True|2024-03-15T10:30:45.000Z
DTS|2024|3|15|10|30|45|0|-5|30|False|2024-03-15T10:30:45.000-05:30
DTS|2024|3|15|10|30|45|0|-5|30|True|2024-03-15T10:30:45.000-05:30
DTS|2024|3|15|10|30|45|0|5|30|False|2024-03-15T10:30:45.000+05:30
DTS|2024|3|15|10|30|45|0|5|30|True|2024-03-15T10:30:45.000+05:30
DTS|2024|3|15|10|30|45|0|0|30|False|2024-03-15T10:30:45.000+00:30
DTS|2024|3|15|10|30|45|0|0|30|True|2024-03-15T10:30:45.000+00:30
DTS|2024|3|15|10|30|45|1|||False|2024-03-15T10:30:45.001
DTS|2024|3|15|10|30|45|1|||True|2024-03-15T10:30:45.001
DTS|2024|3|15|10|30|45|1|0|0|False|2024-03-15T10:30:45.001Z
DTS|2024|3|15|10|30|45|1|0|0|True|2024-03-15T10:30:45.001Z
DTS|2024|3|15|10|30|45|1|-5|30|False|2024-03-15T10:30:45.001-05:30
DTS|2024|3|15|10|30|45|1|-5|30|True|2024-03-15T10:30:45.001-05:30
DTS|2024|3|15|10|30|45|1|5|30|False|2024-03-15T10:30:45.001+05:30
DTS|2024|3|15|10|30|45|1|5|30|True|2024-03-15T10:30:45.001+05:30
DTS|2024|3|15|10|30|45|1|0|30|False|2024-03-15T10:30:45.001+00:30
DTS|2024|3|15|10|30|45|1|0|30|True|2024-03-15T10:30:45.001+00:30
DTS|2024|3|15|10|30|45|999|||False|2024-03-15T10:30:45.999
DTS|2024|3|15|10|30|45|999|||True|2024-03-15T10:30:45.999
DTS|2024|3|15|10|30|45|999|0|0|False|2024-03-15T10:30:45.999Z
DTS|2024|3|15|10|30|45|999|0|0|True|2024-03-15T10:30:45.999Z
DTS|2024|3|15|10|30|45|999|-5|30|False|2024-03-15T10:30:45.999-05:30
DTS|2024|3|15|10|30|45|999|-5|30|True|2024-03-15T10:30:45.999-05:30
DTS|2024|3|15|10|30|45|999|5|30|False|2024-03-15T10:30:45.999+05:30
DTS|2024|3|15|10|30|45|999|5|30|True|2024-03-15T10:30:45.999+05:30
DTS|2024|3|15|10|30|45|999|0|30|False|2024-03-15T10:30:45.999+00:30
DTS|2024|3|15|10|30|45|999|0|30|True|2024-03-15T10:30:45.999+00:30
DTS|2024|||||||||False|2024
DTS|2024|||||||||True|2024
DTS|2024|3||||||||False|2024-03
DTS|2024|3||||||||True|2024-03
DTS|2024|3|15|||||||False|2024-03-15
DTS|2024|3|15|||||||True|2024-03-15
DTS|2024|3|15|10||||||False|2024-03-15T10
DTS|2024|3|15|10||||||True|2024-03-15T10
DTS|2024|3|15|10|30|||||False|2024-03-15T10:30
DTS|2024|3|15|10|30|||||True|2024-03-15T10:30
DTS|2024|3|15|10|30|45||||False|2024-03-15T10:30:45
DTS|2024|3|15|10|30|45||||True|2024-03-15T10:30:45
DTS|2024|3|15|10|30|45|123|||False|2024-03-15T10:30:45.123
DTS|2024|3|15|10|30|45|123|||True|2024-03-15T10:30:45.123
DTO2|Unknown|False|1|0|2024
DTO2|Unknown|False|0|0|2024
DTO2|Unknown|False|-5|0|2024
DTO2|Unknown|False|-5|-30|2024
DTO2|Unknown|False|0|30|2024
DTO2|Unknown|True|1|0|2024
DTO2|Unknown|True|0|0|2024
DTO2|Unknown|True|-5|0|2024
DTO2|Unknown|True|-5|-30|2024
DTO2|Unknown|True|0|30|2024
DTO2|Year|False|1|0|2024
DTO2|Year|False|0|0|2024
DTO2|Year|False|-5|0|2024
DTO2|Year|False|-5|-30|2024
DTO2|Year|False|0|30|2024
DTO2|Year|True|1|0|2024
DTO2|Year|True|0|0|2024
DTO2|Year|True|-5|0|2024
DTO2|Year|True|-5|-30|2024
DTO2|Year|True|0|30|2024
DTO2|Month|False|1|0|2024-03
DTO2|Month|False|0|0|2024-03
DTO2|Month|False|-5|0|2024-03
DTO2|Month|False|-5|-30|2024-03
DTO2|Month|False|0|30|2024-03
DTO2|Month|True|1|0|2024-03
DTO2|Month|True|0|0|2024-03
DTO2|Month|True|-5|0|2024-03
DTO2|Month|True|-5|-30|2024-03
DTO2|Month|True|0|30|2024-03
DTO2|Day|False|1|0|2024-03-15
DTO2|Day|False|0|0|2024-03-15
DTO2|Day|False|-5|0|2024-03-15
DTO2|Day|False|-5|-30|2024-03-15
DTO2|Day|False|0|30|2024-03-15
DTO2|Day|True|1|0|2024-03-15
DTO2|Day|True|0|0|2024-03-15
DTO2|Day|True|-5|0|2024-03-15
DTO2|Day|True|-5|-30|2024-03-15
DTO2|Day|True|0|30|2024-03-15
DTO2|Hour|False|1|0|2024-03-15T10+01:00
DTO2|Hour|False|0|0|2024-03-15T10Z
DTO2|Hour|False|-5|0|2024-03-15T10-05:00
DTO2|Hour|False|-5|-30|2024-03-15T10-05:30
DTO2|Hour|False|0|30|2024-03-15T10+00:30
DTO2|Hour|True|1|0|2024-03-15T10+01:00
DTO2|Hour|True|0|0|2024-03-15T10Z
DTO2|Hour|True|-5|0|2024-03-15T10-05:00
DTO2|Hour|True|-5|-30|2024-03-15T10-05:30
DTO2|Hour|True|0|30|2024-03-15T10+00:30
DTO2|Minute|False|1|0|2024-03-15T10:30+01:00
DTO2|Minute|False|0|0|2024-03-15T10:30Z
DTO2|Minute|False|-5|0|2024-03-15T10:30-05:00
DTO2|Minute|False|-5|-30|2024-03-15T10:30-05:30
DTO2|Minute|False|0|30|2024-03-15T10:30+00:30
DTO2|Minute|True|1|0|2024-03-15T10:30+01:00
DTO2|Minute|True|0|0|2024-03-15T10:30Z
DTO2|Minute|True|-5|0|2024-03-15T10:30-05:00
DTO2|Minute|True|-5|-30|2024-03-15T10:30-05:30
DTO2|Minute|True|0|30|2024-03-15T10:30+00:30
DTO2|Second|False|1|0|2024-03-15T10:30:45+01:00
DTO2|Second|False|0|0|2024-03-15T10:30:45Z
DTO2|Second|False|-5|0|2024-03-15T10:30:45-05:00
DTO2|Second|False|-5|-30|2024-03-15T10:30:45-05:30
DTO2|Second|False|0|30|2024-03-15T10:30:45+00:30
DTO2|Second|True|1|0|2024-03-15T10:30:45+01:00
DTO2|Second|True|0|0|2024-03-15T10:30:45Z
DTO2|Second|True|-5|0|2024-03-15T10:30:45-05:00
DTO2|Second|True|-5|-30|2024-03-15T10:30:45-05:30
DTO2|Second|True|0|30|2024-03-15T10:30:45+00:30
DTO2|Millisecond|False|1|0|2024-03-15T10:30:45.123+01:00
DTO2|Millisecond|False|0|0|2024-03-15T10:30:45.123Z
DTO2|Millisecond|False|-5|0|2024-03-15T10:30:45.123-05:00
DTO2|Millisecond|False|-5|-30|2024-03-15T10:30:45.123-05:30
DTO2|Millisecond|False|0|30|2024-03-15T10:30:45.123+00:30
DTO2|Millisecond|True|1|0|2024-03-15T10:30:45.123+01:00
DTO2|Millisecond|True|0|0|2024-03-15T10:30:45.123Z
DTO2|Millisecond|True|-5|0|2024-03-15T10:30:45.123-05:00
DTO2|Millisecond|True|-5|-30|2024-03-15T10:30:45.123-05:30
DTO2|Millisecond|True|0|30|2024-03-15T10:30:45.123+00:30
DCOMP|2024|3|15|10|30|45|123|-5|30|False|2024-03-15T10:30:45.123-05:30
DCOMP|2024|3|15|10|30|45|123|-5|30|True|2024-03-15T10:30:45.123-05:30
DCOMP|2024|3|15|||||||False|2024-03-15
DCOMP|2024|3|15|||||||True|2024-03-15
DCOMP|2024|||||||||False|2024
DCOMP|2024|||||||||True|2024
DCOMP|2024|3|15|10||||||False|2024-03-15T10
DCOMP|2024|3|15|10||||||True|2024-03-15T10
DS|2024|||False|2024
DS|2024|||True|2024
DS|2024|3||False|2024-03
DS|2024|3||True|2024-03
DS|2024|3|15|False|2024-03-15
DS|2024|3|15|True|2024-03-15
DS|2024|2|29|False|2024-02-29
DS|2024|2|29|True|THROW:ArgumentException
DS|2023|2|28|False|2023-02-28
DS|2023|2|28|True|THROW:ArgumentException
DDTO|Unknown|False|2024
DDTO|Unknown|True|2024
DDTO|Year|False|2024
DDTO|Year|True|2024
DDTO|Month|False|2024-03
DDTO|Month|True|2024-03
DDTO|Day|False|2024-03-15
DDTO|Day|True|2024-03-15
DDTO|Hour|False|2024-03-15
DDTO|Hour|True|2024-03-15
DDTO|Minute|False|2024-03-15
DDTO|Minute|True|2024-03-15
DDTO|Second|False|2024-03-15
DDTO|Second|True|2024-03-15
DDTO|Millisecond|False|2024-03-15
DDTO|Millisecond|True|2024-03-15
TS|10||||||False|10
TS|10||||||True|10
TS|10||||0|0|False|10Z
TS|10||||0|0|True|10Z
TS|10||||-5|30|False|10-05:30
TS|10||||-5|30|True|10-05:30
TS|10||||0|30|False|10+00:30
TS|10||||0|30|True|10+00:30
TS|10|30|||||False|10:30
TS|10|30|||||True|10:30
TS|10|30|||0|0|False|10:30Z
TS|10|30|||0|0|True|10:30Z
TS|10|30|||-5|30|False|10:30-05:30
TS|10|30|||-5|30|True|10:30-05:30
TS|10|30|||0|30|False|10:30+00:30
TS|10|30|||0|30|True|10:30+00:30
TS|10|30|45||||False|10:30:45
TS|10|30|45||||True|10:30:45
TS|10|30|45||0|0|False|10:30:45Z
TS|10|30|45||0|0|True|10:30:45Z
TS|10|30|45||-5|30|False|10:30:45-05:30
TS|10|30|45||-5|30|True|10:30:45-05:30
TS|10|30|45||0|30|False|10:30:45+00:30
TS|10|30|45||0|30|True|10:30:45+00:30
TS|10|30|45|0|||False|10:30:45.000
TS|10|30|45|0|||True|10:30:45.000
TS|10|30|45|0|0|0|False|10:30:45.000Z
TS|10|30|45|0|0|0|True|10:30:45.000Z
TS|10|30|45|0|-5|30|False|10:30:45.000-05:30
TS|10|30|45|0|-5|30|True|10:30:45.000-05:30
TS|10|30|45|0|0|30|False|10:30:45.000+00:30
TS|10|30|45|0|0|30|True|10:30:45.000+00:30
TS|10|30|45|1|||False|10:30:45.001
TS|10|30|45|1|||True|10:30:45.001
TS|10|30|45|1|0|0|False|10:30:45.001Z
TS|10|30|45|1|0|0|True|10:30:45.001Z
TS|10|30|45|1|-5|30|False|10:30:45.001-05:30
TS|10|30|45|1|-5|30|True|10:30:45.001-05:30
TS|10|30|45|1|0|30|False|10:30:45.001+00:30
TS|10|30|45|1|0|30|True|10:30:45.001+00:30
TS|10|30|45|999|||False|10:30:45.999
TS|10|30|45|999|||True|10:30:45.999
TS|10|30|45|999|0|0|False|10:30:45.999Z
TS|10|30|45|999|0|0|True|10:30:45.999Z
TS|10|30|45|999|-5|30|False|10:30:45.999-05:30
TS|10|30|45|999|-5|30|True|10:30:45.999-05:30
TS|10|30|45|999|0|30|False|10:30:45.999+00:30
TS|10|30|45|999|0|30|True|10:30:45.999+00:30
TS|10|30|45|123|||False|10:30:45.123
TS|10|30|45|123|||True|10:30:45.123
TS|10|30|45|123|0|0|False|10:30:45.123Z
TS|10|30|45|123|0|0|True|10:30:45.123Z
TS|10|30|45|123|-5|30|False|10:30:45.123-05:30
TS|10|30|45|123|-5|30|True|10:30:45.123-05:30
TS|10|30|45|123|0|30|False|10:30:45.123+00:30
TS|10|30|45|123|0|30|True|10:30:45.123+00:30
TSPAN|10|30|45|123|||Unknown|False|10
TSPAN|10|30|45|123|||Unknown|True|10
TSPAN|10|30|45|123|||Year|False|10
TSPAN|10|30|45|123|||Year|True|10
TSPAN|10|30|45|123|||Month|False|10
TSPAN|10|30|45|123|||Month|True|10
TSPAN|10|30|45|123|||Day|False|10
TSPAN|10|30|45|123|||Day|True|10
TSPAN|10|30|45|123|||Hour|False|10
TSPAN|10|30|45|123|||Hour|True|10
TSPAN|10|30|45|123|||Minute|False|10:30
TSPAN|10|30|45|123|||Minute|True|10:30
TSPAN|10|30|45|123|||Second|False|10:30:45
TSPAN|10|30|45|123|||Second|True|10:30:45
TSPAN|10|30|45|123|||Millisecond|False|10:30:45.123
TSPAN|10|30|45|123|||Millisecond|True|10:30:45.123
TSPAN|10|30|45|123|0|0|Unknown|False|10Z
TSPAN|10|30|45|123|0|0|Unknown|True|10Z
TSPAN|10|30|45|123|0|0|Year|False|10Z
TSPAN|10|30|45|123|0|0|Year|True|10Z
TSPAN|10|30|45|123|0|0|Month|False|10Z
TSPAN|10|30|45|123|0|0|Month|True|10Z
TSPAN|10|30|45|123|0|0|Day|False|10Z
TSPAN|10|30|45|123|0|0|Day|True|10Z
TSPAN|10|30|45|123|0|0|Hour|False|10Z
TSPAN|10|30|45|123|0|0|Hour|True|10Z
TSPAN|10|30|45|123|0|0|Minute|False|10:30Z
TSPAN|10|30|45|123|0|0|Minute|True|10:30Z
TSPAN|10|30|45|123|0|0|Second|False|10:30:45Z
TSPAN|10|30|45|123|0|0|Second|True|10:30:45Z
TSPAN|10|30|45|123|0|0|Millisecond|False|10:30:45.123Z
TSPAN|10|30|45|123|0|0|Millisecond|True|10:30:45.123Z
TSPAN|10|30|45|123|-5|30|Unknown|False|10-05:30
TSPAN|10|30|45|123|-5|30|Unknown|True|10-05:30
TSPAN|10|30|45|123|-5|30|Year|False|10-05:30
TSPAN|10|30|45|123|-5|30|Year|True|10-05:30
TSPAN|10|30|45|123|-5|30|Month|False|10-05:30
TSPAN|10|30|45|123|-5|30|Month|True|10-05:30
TSPAN|10|30|45|123|-5|30|Day|False|10-05:30
TSPAN|10|30|45|123|-5|30|Day|True|10-05:30
TSPAN|10|30|45|123|-5|30|Hour|False|10-05:30
TSPAN|10|30|45|123|-5|30|Hour|True|10-05:30
TSPAN|10|30|45|123|-5|30|Minute|False|10:30-05:30
TSPAN|10|30|45|123|-5|30|Minute|True|10:30-05:30
TSPAN|10|30|45|123|-5|30|Second|False|10:30:45-05:30
TSPAN|10|30|45|123|-5|30|Second|True|10:30:45-05:30
TSPAN|10|30|45|123|-5|30|Millisecond|False|10:30:45.123-05:30
TSPAN|10|30|45|123|-5|30|Millisecond|True|10:30:45.123-05:30";
}
