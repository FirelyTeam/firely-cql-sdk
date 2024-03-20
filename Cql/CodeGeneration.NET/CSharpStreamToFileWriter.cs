using System.IO;
using Hl7.Cql.CodeGeneration.NET;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging;

internal class CSharpStreamToFileWriter
{
    private readonly CSharpCodeWriterOptions _csharpCodeWriterOptions;

    public CSharpStreamToFileWriter(IOptions<CSharpCodeWriterOptions> csharpCodeWriterOptions)
    {
        _csharpCodeWriterOptions = csharpCodeWriterOptions.Value;
    }

    public void WriteToFile(string name, Stream stream)
    {
        var file = new FileInfo($"{Path.Combine(_csharpCodeWriterOptions.OutDirectory!.FullName, name)}.cs");
        file.Directory!.Create();
        using var streamOut = file.OpenWrite();
        stream.Seek(0, SeekOrigin.Begin);
        stream.CopyTo(streamOut);
    }
}