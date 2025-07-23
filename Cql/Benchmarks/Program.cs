/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using BenchmarkDotNet.Running;

namespace Benchmarks;
public class Program
{
    public static void Main(string[] args)
    {
        // var config = DefaultConfig.Instance;
        // var summary = BenchmarkRunner.Run<Benchmarks>(config, args);

        // Use this to select benchmarks from the console:
        var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args/*, config*/);
    }
}