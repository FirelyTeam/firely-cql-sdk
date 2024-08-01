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

namespace Hl7.Cql.Tools.BuildTasks;
internal static class Extensions
{
    public static FileInfo[] FlattenToFiles(this ITaskItem[] taskItems) =>
        taskItems.Select(item => item.GetMetadata("FullPath"))
        .Select(path => new FileInfo(path))
        .Where(file => file != null).ToArray();


    public static (Library, FileInfo)[] ToLibraries(this ITaskItem[] sources, IServiceProvider services)
    {
        var libraryProvider = (TaskItemLibraryProvider)services.GetRequiredService<ILibraryProvider>();
        libraryProvider.SetItems(sources);
        var files = sources.FlattenToFiles();
        var logger = services.GetRequiredService<ILogger<TaskItemLibraryProvider>>();

        var libs = new (Library, FileInfo)[files.Length];
        for(int i = 0; i < files.Length; i++)
        {
            logger.LogInformation($"Converting {files[i].FullName} to ELM.");
            var fileInfo = files[i];
            if (!fileInfo.Exists)
            {
                logger.LogError($"File {fileInfo.FullName} could not be found on disk.");
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
                                logger.LogError(error.message, locators);
                                break;
                            case ErrorSeverity.warning:
                                logger.LogWarning(error.message, locators);
                                break;
                            default:
                                logger.LogInformation(error.message, locators);
                                break;
                        }

                    }

                    libs[i] = (lib, fileInfo);
                }
            }
        }
        return libs;
    }

    public static TaskItem[] ToCSharp(this Library[] libraries, IServiceProvider services)
    {
        var writer = services.GetRequiredService<CSharpLibrarySetToStreamsWriter>();
        var cf = services.GetRequiredService<CqlCompilerFactory>();

        var loggerFactory = services.GetRequiredService<ILoggerFactory>();
        // TODO: use actual .NET services
        var eb = cf.LibrarySetExpressionBuilder;
        var typeManager = cf.TypeManager;

        // Turn our libraries into lambdas.
        var librarySet = new LibrarySet("", libraries);
        var lambdas = eb.ProcessLibrarySet(librarySet);

        var libraryToCode = new Dictionary<string, string>();

        var callbacks = new CSharpSourceCodeWriterCallbacks(onAfterStep: afterWrite);

        writer.ProcessDefinitions(lambdas, librarySet, typeManager.TupleTypes, callbacks);

        var items = new TaskItem[libraries.Length];
        // Preserve the order of the libraries to their corresponding soure code.
        for (int i = 0; i < libraries.Length; i++)
        {
            var lib = libraries[i];
        }

        return items;

        void afterWrite(CSharpSourceCodeStep step)
        {
            switch (step)
            {
                case CSharpSourceCodeStep.OnStream onStream:
                    onStream.Stream.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(onStream.Stream)) {
                        var code = reader.ReadToEnd();
                        libraryToCode.Add(onStream.Name, code);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
