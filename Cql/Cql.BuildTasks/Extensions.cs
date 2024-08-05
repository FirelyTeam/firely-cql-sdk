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



    public static (IList<TaskItem> elm, IList<TaskItem> cs) ToCSharp(this ITaskItem[] sources, IServiceProvider services)
    {
        var writer = services.GetRequiredService<CSharpLibrarySetToStreamsWriter>();
        var cf = services.GetRequiredService<CqlCompilerFactory>();
        var configuration = services.GetRequiredService<IConfiguration>();
        var outputPath = configuration["BuildEngine:OutputPath"];
        var taskLogger = services.GetRequiredService<ILogger<TaskItemLibraryProvider>>();

        var loggerFactory = services.GetRequiredService<ILoggerFactory>();
        // TODO: use actual .NET services
        var eb = cf.LibrarySetExpressionBuilder;

        var libraries = toLibraries(sources, out var hasErrors);
        var elmItems = new List<TaskItem>(libraries.Length);
        foreach (var (lib, file) in libraries)
        {
            using var ms = new MemoryStream();
            lib.WriteJson(ms);
            ms.Position = 0;
            var elmJson = new StreamReader(ms).ReadToEnd();

            var elmPath = Path.Combine(outputPath ?? file.DirectoryName ?? "",
                 Path.ChangeExtension(file.Name, ".cql.json"));
            File.WriteAllText(elmPath, elmJson, Encoding.UTF8);

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

        // Turn our libraries into lambdas.

        var librarySet = new LibrarySet("", libraries.Select(l=>l.library).ToArray());
        taskLogger.LogInformation($"Compiling ELM to expressions.");
        DefinitionDictionary<LambdaExpression> lambdas;
        try
        {
            lambdas = eb.ProcessLibrarySet(librarySet);
        }
        catch(Exception ex)
        {
            taskLogger.LogError(ex, "Error compiling ELM to expressions.");
            deleteGeneratedCSharp();
            return (elmItems.ToArray(), Array.Empty<TaskItem>());
        }

        var csByNav = new Dictionary<string, string>();
        var callbacks = new CSharpSourceCodeWriterCallbacks(onAfterStep: afterWrite);

        taskLogger.LogInformation($"Writing expressions to C#.");
        try
        {
            writer.ProcessDefinitions(lambdas, librarySet, callbacks);
        }
        catch(Exception ex)
        {
            taskLogger.LogError(ex, "Error writing expressions to C#.");
            deleteGeneratedCSharp();
            return (elmItems.ToArray(), Array.Empty<TaskItem>());
        }

        var csItems = new List<TaskItem>(libraries.Length);
        foreach(var (lib, file) in libraries)
        { 
            if (csByNav.TryGetValue(lib.NameAndVersion(), out var code))
            {
                var csPath = Path.Combine(outputPath ?? file.DirectoryName ?? "",
                    Path.ChangeExtension(file.Name, ".cql.cs"));
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

        void afterWrite(CSharpSourceCodeStep step)
        {
            switch (step)
            {
                case CSharpSourceCodeStep.OnStream onStream:
                    onStream.Stream.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(onStream.Stream)) {
                        var code = reader.ReadToEnd();
                        csByNav.Add(onStream.Name, code);
                    }
                    break;
                default:
                    break;
            }
        }

        (Library library, FileInfo file)[] toLibraries(ITaskItem[] sources, out bool hasErrors)
        {
            hasErrors = false;
            var libraryProvider = (TaskItemLibraryProvider)services.GetRequiredService<ILibraryProvider>();
            libraryProvider.SetItems(sources);
            var files = sources.FlattenToFiles();

            var libs = new (Library, FileInfo)[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                taskLogger.LogInformation($"Converting {files[i].FullName} to ELM.");
                var fileInfo = files[i];
                if (!fileInfo.Exists)
                {
                    taskLogger.LogError($"File {fileInfo.FullName} could not be found on disk.");
                    libs[i] = (null, fileInfo);
                    continue;
                }
                else
                {
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
                                    taskLogger.LogError(error.message, locators);
                                    hasErrors = true;
                                    break;
                                case ErrorSeverity.warning:
                                    taskLogger.LogWarning(error.message, locators);
                                    break;
                                default:
                                    taskLogger.LogInformation(error.message, locators);
                                    break;
                            }

                        }

                        libs[i] = (lib, fileInfo);
                    }
                }
            }
            return libs;
        }

        void deleteGeneratedCSharp()
        {
            foreach (var (_, file) in libraries)
            {
                var csPath = Path.Combine(outputPath ?? file.DirectoryName ?? "",
                    Path.ChangeExtension(file.Name, ".cql.cs"));
                if (File.Exists(csPath))
                    File.Delete(csPath);
            }
        }
    }
}
