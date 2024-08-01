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

namespace Hl7.Cql.Tools.BuildTasks;
internal class CqlToCSharp : Microsoft.Build.Utilities.Task
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
    public ITaskItem[] CSharp { get; set; }

    public override bool Execute()
    {
        var services = new ServiceCollection()
            .AddSystem()
            .AddModels(mp => mp.Add(Model.Models.ElmR1).Add(Model.Models.Fhir401))
            .AddConfiguration(cb => cb.WithOptions((o => { })))
            .AddMessaging()
            .AddLogging(builder => builder.AddTaskLogger(Log))
            .AddSingleton(typeof(ILibraryProvider), typeof(TaskItemLibraryProvider))
            .AddSingleton(typeof(CSharpLibrarySetToStreamsWriter))
            .AddSingleton(typeof(CqlCompilerFactory))
            .AddSingleton(isp => isp.GetRequiredService<CqlCompilerFactory>().TypeResolver)
            .BuildServiceProvider();

        var libraries = Sources.ToLibraries(services);
        var taskItems = libraries.ToCSharp(services);
        return true;
    }
}
