﻿using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.CodeGeneration.NET.PostProcessors;

internal class WriteToFileCSharpCodeStreamPostProcessor : CSharpCodeStreamPostProcessor
{
    private readonly CSharpCodeWriterOptions _csharpCodeWriterOptions;
    private readonly ILogger<WriteToFileCSharpCodeStreamPostProcessor> _logger;

    public WriteToFileCSharpCodeStreamPostProcessor(
        IOptions<CSharpCodeWriterOptions> csharpCodeWriterOptions,
        ILogger<WriteToFileCSharpCodeStreamPostProcessor> logger)
    {
        _logger = logger;
        _csharpCodeWriterOptions = csharpCodeWriterOptions.Value;
    }

    public override void ProcessStream(string name, Stream stream)
    {
        var file = new FileInfo($"{Path.Combine(_csharpCodeWriterOptions.OutDirectory!.FullName, name)}.cs");
        _logger.LogInformation("Writing C# file: '{file}'", file.FullName);

        file.Directory!.Create();
        using var streamOut = file.OpenWrite();
        streamOut.SetLength(0); // Clears out previous contents
        stream.Seek(0, SeekOrigin.Begin);
        stream.CopyTo(streamOut);
    }
}