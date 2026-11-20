/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.IO;
using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Hl7.Cql.Elm;

namespace Benchmarks;

/// <summary>
/// Measures reading and writing ELM JSON. <see cref="JsonDocumentParse"/> is the baseline: the cost of just
/// tokenizing the same text, to which <see cref="ParseFromJson"/> and <see cref="SerializeToJson"/> are compared.
/// </summary>
[ShortRunJob]
[MemoryDiagnoser]
public class ElmJsonBenchmarks
{
    private string _json = null!;
    private Library _library = null!;

    /// <summary>
    /// The ELM file the benchmarks read, by file name.
    /// </summary>
    [Params("FHIRHelpers-4.0.1.json", "CMS133FHIRCataracts2040BCVA90Days.json")]
    public string FileName { get; set; } = null!;

    [GlobalSetup]
    public void Setup()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "ElmJson", FileName);
        _json = File.ReadAllText(path);
        _library = Library.ParseFromJson(_json);
    }

    [Benchmark(Baseline = true)]
    public int JsonDocumentParse()
    {
        using var document = JsonDocument.Parse(_json, new JsonDocumentOptions { MaxDepth = 4096 });
        return (int)document.RootElement.ValueKind;
    }

    [Benchmark]
    public Library ParseFromJson() => Library.ParseFromJson(_json);

    [Benchmark]
    public string SerializeToJson() => _library.SerializeToJson(writeIndented: false);
}
