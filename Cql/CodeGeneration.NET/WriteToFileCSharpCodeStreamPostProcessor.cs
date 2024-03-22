using System.IO;
using Hl7.Cql.CodeGeneration.NET;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging;

internal class WriteToFileCSharpCodeStreamPostProcessor : CSharpCodeStreamPostProcessor
{
    private readonly CSharpCodeWriterOptions _csharpCodeWriterOptions;

    public WriteToFileCSharpCodeStreamPostProcessor(IOptions<CSharpCodeWriterOptions> csharpCodeWriterOptions)
    {
        _csharpCodeWriterOptions = csharpCodeWriterOptions.Value;
    }

    public override void ProcessStream(string name, Stream stream)
    {
        var file = new FileInfo($"{Path.Combine(_csharpCodeWriterOptions.OutDirectory!.FullName, name)}.cs");
        file.Directory!.Create();
        using var streamOut = file.OpenWrite(); 
        streamOut.SetLength(0); // Clears out previous contents
        stream.Seek(0, SeekOrigin.Begin);
        stream.CopyTo(streamOut);
    }
}