using System;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Hl7.Cql.CqlToElm;
using System.IO;
using Hl7.Cql.Elm;
using System.Linq;
using Microsoft.Build.Utilities;
using Hl7.Cql.Compiler;
using Hl7.Cql.CodeGeneration.NET;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Hl7.Cql.Runtime;
using System.Linq.Expressions;

namespace Hl7.Cql.Tools.BuildTasks;
internal static class Extensions
{
    public static FileInfo[] FlattenToFiles(this ITaskItem[] taskItems) =>
        taskItems.Select(item => item.GetMetadata("FullPath"))
        .Select(path => new FileInfo(path))
        .Where(file => file != null).ToArray();

    public static void Delete(this ITaskItem[] taskItems)
    {
        foreach (var item in taskItems)
        {
            var path = item.GetMetadata("FullPath");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }

    public static (IList<TaskItem> elm, IList<TaskItem> cs) ToCSharp(this ITaskItem[] sources,
        IServiceProvider services,
        TaskLoggingHelper log,
        bool force)
    {
        var writer = services.GetRequiredService<CSharpLibrarySetToStreamsWriter>();
        var cf = services.GetRequiredService<CqlCompilerFactory>();
        var configuration = services.GetRequiredService<IConfiguration>();
        var outputPath = configuration["BuildEngine:OutputPath"];

        var loggerFactory = services.GetRequiredService<ILoggerFactory>();
        // TODO: use actual .NET services
        var eb = cf.LibrarySetExpressionBuilder;

        var libraries = toLibraries(sources, out var hasErrors);
        var elmItems = new List<TaskItem>(libraries.Length);
        foreach (var (lib, file, write) in libraries)
        {
            var elmPath = getElmPath(file);
            if (write)
            {
                using var ms = new MemoryStream();
                lib.WriteJson(ms);
                ms.Position = 0;
                var elmJson = new StreamReader(ms).ReadToEnd();
                File.WriteAllText(elmPath, elmJson, Encoding.UTF8);
            }
            elmItems.Add(new TaskItem(elmPath, new Dictionary<string, string>
            {
                ["DependentUpon"] = file.Name,
                ["Name"] = lib.identifier.id,
                ["Version"] = lib.identifier.version,
            }));
        }
        if (hasErrors)
        {
            deleteGeneratedCSharp();
            return (elmItems.ToArray(), Array.Empty<TaskItem>());
        }

        var libs = libraries.Select(lib =>
            {
                var csFile = new FileInfo(getCsPath(lib.file));
                if (!force && csFile.Exists && csFile.LastWriteTimeUtc > lib.file.LastWriteTimeUtc)
                {
                    log.LogMessage($"Skipping {lib.file.FullName} because the C# is up to date.");
                    return null;
                }
                else
                    return lib.library;

            })
            .Where(lib => lib is not null)
            .ToArray();

        // Turn our libraries into lambdas.
        var librarySet = new LibrarySet("", libs);

        log.LogMessage($"Compiling ELM to expressions.");
        DefinitionDictionary<LambdaExpression> lambdas;
        try
        {
            lambdas = eb.ProcessLibrarySet(librarySet);
        }
        catch (Exception ex)
        {
            log.LogErrorFromException(ex);
            deleteGeneratedCSharp();
            return (elmItems.ToArray(), Array.Empty<TaskItem>());
        }

        var csByNav = new Dictionary<string, string>();
        var callbacks = new CSharpSourceCodeWriterCallbacks(onAfterStep: afterWrite);

        log.LogMessage($"Writing expressions to C#.");
        try
        {
            writer.ProcessDefinitions(lambdas, librarySet, callbacks);
        }
        catch (Exception ex)
        {
            log.LogErrorFromException(ex);
            deleteGeneratedCSharp();
            return (elmItems.ToArray(), Array.Empty<TaskItem>());
        }

        var csItems = new List<TaskItem>(libraries.Length);
        foreach (var (lib, file, _) in libraries)
        {
            if (csByNav.TryGetValue(lib.NameAndVersion(), out var code))
            {
                var csPath = getCsPath(file);
                File.WriteAllText(csPath, code, Encoding.UTF8);
                csItems.Add(new TaskItem(csPath, new Dictionary<string, string>
                {
                    ["DependentUpon"] = file.Name,
                    ["Name"] = lib.identifier.id,
                    ["Version"] = lib.identifier.version,
                }));
            }
        }
        return (elmItems.ToArray(), csItems.ToArray());

        string getElmPath(FileInfo file) => Path.Combine(outputPath ?? file.DirectoryName ?? "", "obj",
            Path.ChangeExtension(file.Name, ".cql.json"));
        string getCsPath(FileInfo file) => Path.Combine(outputPath ?? file.DirectoryName ?? "",
            Path.ChangeExtension(file.Name, ".cql.cs"));

        void afterWrite(CSharpSourceCodeStep step)
        {
            switch (step)
            {
                case CSharpSourceCodeStep.OnStream onStream:
                    onStream.Stream.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(onStream.Stream))
                    {
                        var code = reader.ReadToEnd();
                        csByNav.Add(onStream.Name, code);
                    }
                    break;
                default:
                    break;
            }
        }

        (Library library, FileInfo file, bool writeLib)[] toLibraries(ITaskItem[] sources, out bool hasErrors)
        {
            hasErrors = false;
            var libraryProvider = (TaskItemLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            libraryProvider.SetItems(sources);
            var files = sources.FlattenToFiles();

            var libs = new (Library, FileInfo, bool)[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                var fileInfo = files[i];
                if (!fileInfo.Exists)
                {
                    log.LogError($"File {fileInfo.FullName} could not be found on disk.");
                    libs[i] = (null, fileInfo, false);
                    continue;
                }
                else
                {
                    var elmFile = new FileInfo(getElmPath(fileInfo));
                    if (!force && elmFile.Exists && elmFile.LastWriteTime > fileInfo.LastWriteTimeUtc)
                    {
                        log.LogMessage($"Skipping {fileInfo.FullName} because the ELM is up to date.");
                        try
                        {
                            var lib = Library.LoadFromJson(elmFile);
                            libs[i] = (lib, fileInfo, false);
                            continue;
                        }
                        catch (Exception ex)
                        {
                            log.LogErrorFromException(ex);
                        }
                    }
                    log.LogMessage($"Converting {files[i].FullName} to ELM.");
                    var cql = File.ReadAllText(fileInfo.FullName);
                    using (var scope = services.CreateScope())
                    {
                        var builder = services.GetRequiredService<CqlToElmConverter>()
                            .GetBuilder(cql, scope);
                        var lib = builder.Build();
                        libraryProvider.TryAddLibrary(lib.identifier.id, lib.identifier.version, fileInfo, builder);
                        var errors = lib.GetErrors().ToArray();
                        foreach (var error in errors)
                        {
                            var severity = error.errorSeveritySpecified ?
                                error.errorSeverity : ErrorSeverity.error;
                            object[] locators = [error.startLine, error.startChar, error.endLine, error.endChar];
                            switch (severity)
                            {
                                case ErrorSeverity.error:
                                    log.LogError(error.errorType.ToString(), null, null,
                                        fileInfo.FullName, error.startLine, error.startChar, error.endLine, error.endLine,
                                        error.message);                                    
                                    hasErrors = true;
                                    break;
                                case ErrorSeverity.warning:
                                    log.LogWarning(error.errorType.ToString(), null, null,
                                        fileInfo.FullName, error.startLine, error.startChar, error.endLine, error.endLine,
                                        error.message);
                                    break;
                                default:
                                    log.LogMessage(error.message, locators);
                                    break;
                            }

                        }

                        libs[i] = (lib, fileInfo, true);
                    }
                }
            }
            return libs;
        }

        void deleteGeneratedCSharp()
        {
            foreach (var (_, file, _) in libraries)
            {
                var csPath = getCsPath(file);
                if (File.Exists(csPath))
                    File.Delete(csPath);
            }
        }
    }
}
