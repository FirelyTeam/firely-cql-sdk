using BenchmarkDotNet.Running;
using System;
using BenchmarkDotNet.Configs;

namespace Benchmarking;

internal class Program
{
    public static void Main(string[] args) =>
        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly)
                         .Run(args);
}
