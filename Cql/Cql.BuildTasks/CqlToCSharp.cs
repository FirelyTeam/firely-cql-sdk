using System;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using System.IO;
using Hl7.Cql.Elm;
using System.Linq;
using Microsoft.Build.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Hl7.Cql.Tools.BuildTasks;

/// <summary>
/// Creates ELM and C# files from CQL files.
/// </summary>
public class CqlToCSharp : Microsoft.Build.Utilities.Task
{

    /// <summary>
    /// Specifies one or more CQL library files.
    /// </summary>
    [Required]
    public ITaskItem[] Sources { get; set; }

    /// <summary>
    /// Optionally specifies the options file.
    /// </summary>
    public ITaskItem Options { get; set; }

    /// <summary>
    /// Specifies the output items.
    /// </summary>
    [Output]
    public ITaskItem[] Elm { get; set; }

    /// <summary>
    /// Specifies the output items.
    /// </summary>
    [Output]
    public ITaskItem[] CSharp { get; set; }

    /// <summary>
    /// When <see clang="true" />, recompile all CQL files , even if the output files are up to date.
    /// </summary>
    public bool Force { get; set; }

    /// <inheritdoc />
    public override bool Execute()
    {
        var globalProperties = BuildEngine9.GetGlobalProperties()
            .Select(kvp => KeyValuePair.Create($"BuildEngine:{kvp.Key}", kvp.Value));
        var services = new ServiceCollection()
            .AddSystem()
            .AddModels(mp => mp.Add(Model.Models.ElmR1).Add(Model.Models.Fhir401))
            .AddConfiguration(cb =>
                cb.WithOptions(o => { })
                .AddInMemoryCollection(globalProperties))
            .AddMessaging()
            .AddLogging(builder => builder.AddTaskLogger(Log))
            .AddSingleton(typeof(ILibraryProvider), typeof(TaskItemLibraryProvider))
            .AddSingleton(typeof(CSharpLibrarySetToStreamsWriter))
            .AddSingleton(typeof(TypeToCSharpConverter))
            .AddSingleton(typeof(CqlCompilerFactory))
            .AddSingleton(isp => isp.GetRequiredService<CqlCompilerFactory>().TypeResolver)
            .BuildServiceProvider();


        var configuration = services.GetRequiredService<IConfiguration>();
        var outputDir = configuration["BuildEngine:OutputPath"];
        if (outputDir is not null && !Directory.Exists(outputDir))
        {
            Log.LogError($"OutputPath {outputDir} could not be found on disk.");
            return false;
        }

        var taskItems = Sources.ToCSharp(services, Force);
        Elm = taskItems.elm.ToArray();
        CSharp = taskItems.cs.ToArray();

        return !Log.HasLoggedErrors;
    }
}
