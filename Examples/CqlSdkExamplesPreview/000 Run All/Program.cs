/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace CqlSdkExamplesPreview;

partial class Program
{
    void RunAll()
    {
        string[] codes =
        [
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