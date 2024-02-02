#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Hl7.Cql.Packager
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            if (args.Length == 0 || config["?"] != null || config["h"] != null || config["help"] != null)
                return ShowHelp();

            if (config.AsEnumerable()
                    .Select(kv => kv.Key)
                    .Except(supportedArgs)
                    .ToList() is { Count: > 0 } unknownArgs)
            {
                Console.Error.WriteLine($"Unknown args: {string.Join(", ", unknownArgs)}.");
                ShowHelp();
                return -1;
            }


            // elm

            if (config["elm"] is not {} elmArg)
                return ShowHelp();

            var elmDir = new DirectoryInfo(elmArg);
            if (!elmDir.Exists)
            {
                Console.Error.WriteLine($"-elm: path {elmArg} does not exist.");
                return -1;
            }

            // cql

            if (config["cql"] is not {} cqlArg )
                return ShowHelp();

            var cqlDir = new DirectoryInfo(cqlArg);
            if (!cqlDir.Exists)
            {
                Console.Error.WriteLine($"-cql: path {cqlArg} does not exist.");
                return -1;
            }

            // d

            if (config["d"] is {} dArg && !bool.TryParse(dArg, out bool debug))
            {
                Console.Error.WriteLine($"-d: expected true|false, got {dArg}");
                return -1;
            }

            // cs

            DirectoryInfo? csDir = null;
            if (config["cs"] is {} csArg)
            {
                csDir = new DirectoryInfo(csArg);
                if (!csDir.Exists)
                {
                    EnsureDirectory(csDir);
                }
            }

            // f

            if (config["f"] is {} fArg 
                && !bool.TryParse(fArg, out var force))
            {
                Console.Error.WriteLine($"-f: expected true|false, got {fArg}");
                return -1;
            }

            // fhir

            DirectoryInfo? fhirDir = null;
            if (config["fhir"] is {} fhirArg)
            {
                fhirDir = new DirectoryInfo(fhirArg);
                if (!fhirDir.Exists)
                {
                    EnsureDirectory(fhirDir);
                }
            }

            // canonical-root-url

            var resourceCanonicalRootUrl = config["canonical-root-url"]?.TrimEnd('/');

            Package(elmDir, cqlDir, csDir, fhirDir, resourceCanonicalRootUrl);
            return 0;
        }

        private static void Package(DirectoryInfo elmDir, DirectoryInfo cqlDir, DirectoryInfo? csDir, DirectoryInfo? fhirDir, string? resourceCanonicalRootUrl)
        {
            var logLevel = LogLevel.Trace;
            var logFactory = LoggerFactory
                .Create(logging =>
                {
                    logging.AddFilter(level => level >= logLevel);
                    logging.AddConsole(console =>
                    {
                        console.LogToStandardErrorThreshold = LogLevel.Error;
                    });
                    var logFile = Path.Combine(".", "build.txt");
#pragma warning disable CA1305 // Specify IFormatProvider
                    Log.Logger = new LoggerConfiguration()
                      .Enrich.FromLogContext()
                      .WriteTo
                      .File(logFile)
                      .CreateLogger();
#pragma warning restore CA1305 // Specify IFormatProvider
                    logging.AddSerilog();
                });
            var cliLogger = logFactory.CreateLogger("CLI");

            List<ResourceWriter> resourceWriters = new();
            if (fhirDir != null) resourceWriters.Add(new FhirResourceWriter(fhirDir, cliLogger));
            if (csDir != null) resourceWriters.Add(new CSharpResourceWriter(csDir, cliLogger));

            var resourcePackager = new ResourcePackager(logFactory, resourceWriters.ToArray());
            resourcePackager.Package(elmDir, cqlDir, resourceCanonicalRootUrl);
        }


        private static void EnsureDirectory(DirectoryInfo directory, int timeoutMs = 5000)
        {
            var now = DateTime.Now;
            var loop = true;
            var timeout = TimeSpan.FromMilliseconds(timeoutMs);
            while (!directory.Exists && loop)
            {
                directory.Create();
                directory.Refresh();
                if (DateTime.Now.Subtract(now) > timeout)
                    throw new InvalidOperationException($"Unable to create directory {directory.FullName} after {timeout}");
            }
        }

        private static string[] supportedArgs = new[] { "elm", "cql", "fhir", "cs", "d", "f", "canonical-root-url" };

        private static int ShowHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Packager CLI");
            Console.WriteLine();
            Console.WriteLine($"\t--elm <directory>\tLibrary root path");
            Console.WriteLine($"\t--cql <directory>\tCQL root path");
            Console.WriteLine($"\t[--fhir] <file>\tResource location, either file name or directory");
            Console.WriteLine($"\t[--cs] <file>\tC# output location, either file name or directory");
            Console.WriteLine($"\t[--d] true|false\t\tProduce as a debug assembly");
            Console.WriteLine($"\t[--f] true|false\tIf output file already exists, overwrite");
            Console.WriteLine($"\t[--canonical-root-url] <url>\tThe root url used for the resource canonical. If omitted a '#' will be used");
            Console.WriteLine();
            return -1;
        }
    }
}