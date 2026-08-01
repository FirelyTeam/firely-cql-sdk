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
/// Golden expectations for the ISO 8601 types' text form, captured from the eager-formatting
/// implementation before <c>String</c> became lazily computed. Laziness may only change when the
/// string is built, never what it says - these cases cover every null-gating boundary, offset
/// combination and constructor overload, plus parse roundtrips, and were verified byte-identical
/// across the refactor.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class Iso8601LazyFormattingGoldenTests
{
    [TestMethod]
    public void TextFormMatchesTheEagerImplementationsGoldens()
    {
        var failures = new List<string>();

        foreach (var line in Golden.Split('\n', StringSplitOptions.RemoveEmptyEntries))
        {
            var p = line.Split('|');
            int? N(string v) => v.Length == 0 ? null : int.Parse(v);

            string actual;
            string expected;
            try
            {
                (actual, expected) = p[0] switch
                {
                    "DT" => (Render(() => new DateTimeIso8601(int.Parse(p[1]), N(p[2]), N(p[3]), N(p[4]), N(p[5]), N(p[6]), N(p[7]), N(p[8]), N(p[9]))), p[10]),
                    "DTO" => (Render(() => new DateTimeIso8601(new DateTimeOffset(2024, 3, 1, 9, 23, 17, 123, TimeSpan.FromHours(1)), Enum.Parse<DateTimePrecision>(p[1]))), p[2]),
                    "D" => (Render(() => new DateIso8601(int.Parse(p[1]), N(p[2]), N(p[3]))), p[4]),
                    "T" => (Render(() => new TimeIso8601(int.Parse(p[1]), N(p[2]), N(p[3]), N(p[4]), N(p[5]), N(p[6]))), p[7]),
                    "P" => (DateTimeIso8601.TryParse(p[1], out var pv) ? pv!.ToString() : "PARSEFAIL", p[2]),
                    _ => ("?", "?")
                };
            }
            catch (Exception e)
            {
                (actual, expected) = ($"THROW:{e.GetType().Name}", p[^1].StartsWith("THROW") ? p[^1] : p[0] == "DT" ? p[10] : p[^2]);
            }

            if (expected.StartsWith("THROW"))
            {
                if (actual != expected) failures.Add($"{line} => {actual}");
            }
            else if (actual != expected)
            {
                failures.Add($"{line} => '{actual}' (expected '{expected}')");
            }
        }

        Assert.AreEqual(0, failures.Count, string.Join(Environment.NewLine, failures.Take(10)));
    }

    private static string Render(Func<object> make) => make().ToString()!;

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
}
