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

namespace Hl7.Cql.Tools.BuildTasks
{
    /// <summary>
    /// Converts CQL libraries to ELM libraries.
    /// </summary>
    public class CqlToElm : Microsoft.Build.Utilities.Task
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
        public ITaskItem[] ELM { get; set; }

        /// <inheritdoc />
        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Converting CQL libraries to ELM libraries.");
            var services = new ServiceCollection()
                .AddSystem()
                .AddModels(mp => mp.Add(Model.Models.ElmR1).Add(Model.Models.Fhir401))
                .AddConfiguration(cb => cb.WithOptions((o => { })))
                .AddMessaging()
                .AddLogging(builder => builder.AddTaskLogger(Log))
                .AddSingleton(typeof(ILibraryProvider), typeof(TaskItemLibraryProvider))
                .BuildServiceProvider();

            var libraries = Sources.ToLibraries(services);
            var props = BuildEngine9.GetGlobalProperties();
            if (!props.TryGetValue("OutputPath", out var outputPath))
                outputPath = null;

            var elm = new ConcurrentBag<ITaskItem>();

            Parallel.ForEach(libraries, tuple =>
            {
                var lib = tuple.Item1;
                var fileInfo = tuple.Item2;
                using var ms = new MemoryStream();
                lib.WriteJson(ms);
                ms.Position = 0;
                var json = new StreamReader(ms).ReadToEnd();


                var fileName = $"{Path.GetFileNameWithoutExtension(fileInfo.Name)}.elm.json";
                var outFile = Path.Combine(outputPath ?? fileInfo.DirectoryName, fileName);

                Log.LogMessage(MessageImportance.High, $"Writing {outFile}.");

                File.WriteAllText(outFile, json);
                var ti = new TaskItem(outFile, new Dictionary<string, string>
                {
                    ["Name"] = lib.identifier.id,
                    ["Version"] = lib.identifier.version,
                });
                elm.Add(ti);
            });

            ELM = elm.ToArray();

            return !Log.HasLoggedErrors;
        }
    }
}
