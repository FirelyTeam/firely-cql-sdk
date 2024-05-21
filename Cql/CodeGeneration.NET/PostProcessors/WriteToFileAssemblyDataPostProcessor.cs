/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.IO;
using System.Reflection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.CodeGeneration.NET.PostProcessors;

internal class WriteToFileAssemblyDataPostProcessor : AssemblyDataPostProcessor
{
    private readonly AssemblyDataWriterOptions _assemblyDataWriterOptions;
    private readonly ILogger<WriteToFileAssemblyDataPostProcessor> _logger;

    public WriteToFileAssemblyDataPostProcessor(
        IOptions<AssemblyDataWriterOptions> assemblyDataWriterOptions,
        ILogger<WriteToFileAssemblyDataPostProcessor> logger)
    {
        _logger = logger;
        _assemblyDataWriterOptions = assemblyDataWriterOptions.Value;
    }

    public override void ProcessAssemblyData(string name, AssemblyData assemblyData)
    {
        var file = new FileInfo($"{Path.Combine(_assemblyDataWriterOptions.OutDirectory!.FullName, name)}.dll");
        _logger.LogInformation("Writing Assembly file: '{file}'", file.FullName);

        file.Directory!.Create();
        File.WriteAllBytes(file.FullName, assemblyData.Binary);
    }

    public override void ProcessReferenceAssembly(Assembly referenceAssembly)
    {
        _ = referenceAssembly;
        // var file = new FileInfo($"{Path.Combine(_assemblyDataWriterOptions.OutDirectory!.FullName, referenceAssembly.GetName().Name!)}.dll");
        // _logger.LogInformation("Writing Reference Assembly file: '{file}'", file.FullName);
        //
        // file.Directory!.Create();
        // File.Copy(referenceAssembly.Location, file.FullName, true);
    }
}