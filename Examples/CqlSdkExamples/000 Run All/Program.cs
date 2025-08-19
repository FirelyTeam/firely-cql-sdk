/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace CqlSdkExamples;

partial class Program
{
    void RunAll()
    {
        string[] codes =
        [
            "210", "220", "221", "230", "240", "250", "251",
            "310", "320", "330", "400", "410", "500"
        ];

        foreach (string code in codes)
        {
            Console.WriteLine($"Running example {code}");
            PickExample(code);
            Console.WriteLine($"Done running example {code}");
            Console.ReadLine();
        }
    }
}
