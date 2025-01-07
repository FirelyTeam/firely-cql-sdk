/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.CodeGeneration.NET.PostProcessors;

internal class WriteToFileCSharpCodeStreamPostProcessor(
    IOptions<CSharpCodeWriterOptions> csharpCodeWriterOptions,
    ILogger<WriteToFileCSharpCodeStreamPostProcessor> logger)
    : CSharpCodeStreamPostProcessor
{
    private readonly CSharpCodeWriterOptions _csharpCodeWriterOptions = csharpCodeWriterOptions.Value;

    public override void ProcessStream(string name, Stream stream)
    {
        var file = new FileInfo($"{Path.Combine(_csharpCodeWriterOptions.OutDirectory!.FullName, name)}.g.cs");
        logger.LogInformation("Writing C# file: '{file}'", file.FullName);

        file.Directory!.Create();
        using var streamOut = file.OpenWrite();
        streamOut.SetLength(0); // Clears out previous contents
        stream.Seek(0, SeekOrigin.Begin);
        stream.CopyTo(streamOut);
    }
}