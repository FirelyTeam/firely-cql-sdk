using Hl7.Cql.Packaging.ResourceWriters;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging;

internal class CSharpStreamToFileWriter
{
    private readonly CSharpResourceWriterOptions _csharpResourceWriterOptions;

    public CSharpStreamToFileWriter(IOptions<CSharpResourceWriterOptions> csharpResourceWriterOptions)
    {
        _csharpResourceWriterOptions = csharpResourceWriterOptions.Value;
    }

    public void WriteToFile(string name, Stream stream)
    {
        var file = new FileInfo($"{Path.Combine(_csharpResourceWriterOptions.OutDirectory!.FullName, name)}.cs");
        file.Directory!.Create();
        using var streamOut = file.OpenWrite();
        stream.Position = 0L;
        stream.CopyTo(streamOut);
    }
}