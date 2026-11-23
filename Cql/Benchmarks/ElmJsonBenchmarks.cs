/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.IO;
using System.Text;
using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Hl7.Cql.Elm;
using Hl7.Cql.Elm.Serialization;

namespace Benchmarks;

/// <summary>
/// Measures reading and writing ELM JSON. <see cref="JsonDocumentParse"/> is the baseline: the cost of just
/// tokenizing the same text, to which <see cref="ParseFromJson"/> and <see cref="SerializeToJson"/> are compared.
/// The remaining rows cover the paths the serializer's savings change: indented serialization, saving a file,
/// <c>ToJsonUtf8</c> with and without the source JSON, parsing bytes and loading a CR LF file.
/// </summary>
[ShortRunJob]
[MemoryDiagnoser]
public class ElmJsonBenchmarks
{
    private string _json = null!;
    private Library _library = null!;
    private Library _libraryWithSource = null!;
    private byte[] _utf8 = null!;
    private string _crlfPath = null!;
    private string _saveDirectory = null!;

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
        _utf8 = File.ReadAllBytes(path);

        // LoadFromJson(FileInfo) keeps the source JSON; ParseFromJson does not.
        _libraryWithSource = Library.LoadFromJson(new FileInfo(path));

        _saveDirectory = Path.Combine(Path.GetTempPath(), "ElmJsonBenchmarks-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_saveDirectory);

        // The same file with CR LF line endings, as a Windows checkout of the repository has it.
        _crlfPath = Path.Combine(_saveDirectory, "crlf-" + FileName);
        File.WriteAllText(_crlfPath, _json.Replace("\r\n", "\n").Replace("\n", "\r\n"), new UTF8Encoding(false));
    }

    [GlobalCleanup]
    public void Cleanup() => Directory.Delete(_saveDirectory, recursive: true);

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

    [Benchmark]
    public string SerializeToJsonIndented() => _library.SerializeToJson(writeIndented: true);

    // The next two rows do what SaveElmFilesToDirectoryOptions.Save does for one library: serialize it into a pooled
    // buffer, then write the file named after the library in one call.

    [Benchmark]
    public void SaveCompact() => Save(writeIndented: false);

    [Benchmark]
    public void SaveIndented() => Save(writeIndented: true);

    private void Save(bool writeIndented)
    {
        var fileName = Path.Combine(_saveDirectory, FileName);
        using var buffer = LibraryJsonSerializer.SerializeToPooledBuffer(_library, writeIndented);
        using var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
        stream.Write(buffer.WrittenSpan);
    }

    [Benchmark]
    public byte[] ToJsonUtf8CompactSourceKept() => _libraryWithSource.ToJsonUtf8(false);

    [Benchmark]
    public byte[] ToJsonUtf8IndentedSourceKept() => _libraryWithSource.ToJsonUtf8(true);

    [Benchmark]
    public byte[] ToJsonUtf8CompactNoSource() => _library.ToJsonUtf8(false);

    [Benchmark]
    public byte[] ToJsonUtf8IndentedNoSource() => _library.ToJsonUtf8(true);

    [Benchmark]
    public Library ParseBytesViaString() => Library.ParseFromJson(Encoding.UTF8.GetString(_utf8));

    [Benchmark]
    public Library ParseBytesViaStream() => Library.LoadFromJson(new MemoryStream(_utf8, writable: false));

    [Benchmark]
    public Library LoadFromJsonFileCrLf() => Library.LoadFromJson(new FileInfo(_crlfPath));
}
