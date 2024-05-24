/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Cql.CodeGeneration.NET.PostProcessors;

internal class WriteToFileAssemblyDataPostProcessor : AssemblyDataPostProcessor
{
    private readonly AssemblyDataWriterOptions _assemblyDataWriterOptions;
    private readonly ILogger<WriteToFileAssemblyDataPostProcessor> _logger;
    private readonly Task _initTask;

    public WriteToFileAssemblyDataPostProcessor(
        IOptions<AssemblyDataWriterOptions> assemblyDataWriterOptions,
        ILogger<WriteToFileAssemblyDataPostProcessor> logger)
    {
        _logger = logger;
        _assemblyDataWriterOptions = assemblyDataWriterOptions.Value;
        _initTask = InitAsync();
    }

    private async Task InitAsync()
    {
        await Task.Yield();

        var directory = GetOutDirectory();
        if (Directory.Exists(directory))
        {
            var filesWrittenFile = GetFilesDataFileFullName(directory);
            if (File.Exists(filesWrittenFile))
            {
                var filesWritten = await File.ReadAllLinesAsync(filesWrittenFile);
                _logger.LogInformation("Deleting {count} previous Assembly files", filesWritten.Length);

                filesWritten
                    .AsParallel()
                    .ForAll(path =>
                    {
                        _logger.LogInformation("Deleting previous Assembly file: {path}", path);
                        File.Delete(path);
                    });

                _logger.LogInformation("Deleting file record of previous Assembly files: {path}", filesWrittenFile);
                File.Delete(filesWrittenFile);
            }
        }
        Directory.CreateDirectory(directory);
    }

    public override void ProcessAssemblyData(string name, AssemblyData assemblyData)
    {
        _initTask.Wait();

        var directory = GetOutDirectory();
        var assemblyFile = GetAssemblyDllFileFullName(name, directory);
        var filesWrittenFile = GetFilesDataFileFullName(directory);

        _logger.LogInformation("Writing Assembly file: '{file}'", assemblyFile);

        File.AppendAllLines(filesWrittenFile, [name]);
        File.WriteAllBytes(assemblyFile, assemblyData.Binary);
    }

    private string GetOutDirectory() =>
        _assemblyDataWriterOptions.OutDirectory!.FullName;

    private static string GetFilesDataFileFullName(string directory) =>
        Path.Combine(directory, "_files.dat");

    private static string GetAssemblyDllFileFullName(string name, string directory) =>
        Path.Combine(directory, $"{name}.dll");

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