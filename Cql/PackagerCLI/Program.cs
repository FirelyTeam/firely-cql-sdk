#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using System.Diagnostics;
using System.Text;
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
            Dictionary<string, string?>? config2 = GetConfigFromArgs(args);
            if (config2 is null)
                return ShowHelp();

            PackagerArgs config = ParseConfig(config2);

            if (config.ShowHelp is true
                || config.ElmDir is null 
                || config.CqlDir is null)
                return ShowHelp();

            if (!config.ElmDir.Exists)
                return ShowError($"-elm: path {config.ElmDir} does not exist.");

            if (!config.CqlDir.Exists)
                return ShowError($"-elm: path {config.CqlDir} does not exist.");

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

            Package(config.ElmDir, cqlDir, csDir, fhirDir, resourceCanonicalRootUrl);
            return 0;
        }

        private static int ShowError(string error)
        {
            Console.Error.WriteLine(error);
            return -1;
        }

        private record PackagerArgs
        {
            public bool? ShowHelp { get; set; }
            public DirectoryInfo? ElmDir { get; set; }
            public DirectoryInfo? CqlDir { get; set; }
            public DirectoryInfo? CSharpDir { get; set; }
            public DirectoryInfo? FhirDir { get; set; }
            public bool? Debug { get; set; }
            public bool? Force { get; set; }
            public string? CanonicalRootUrl { get; set; }

            public IEnumerable<(string Key, object? Value)> KeyValues()
            {
                if (ShowHelp is { } showHelp) yield return (nameof(ShowHelp), showHelp);
                if (ElmDir is {} elm) yield return (nameof(ElmDir), elm);
                if (CqlDir is {} cql) yield return (nameof(CqlDir), cql);
                if (CSharpDir is {} cs) yield return (nameof(CSharpDir), cs);
                if (Debug is {} d) yield return (nameof(Debug), d);
                if (Force is {} f) yield return (nameof(Force), f);
                if (CanonicalRootUrl is {} canonicalRootUrl) yield return (nameof(CanonicalRootUrl), canonicalRootUrl);
            }
        }

        private static PackagerArgs ParseConfig(IReadOnlyDictionary<string, string?> config)
        {
            PackagerArgs args = new PackagerArgs();

            T? Get<T>(string key, Func<string,T?> parse) => config.GetValueOrDefault(key) is { Length:>0 } value ? parse(value) : default(T?);
            
            static DirectoryInfo? ParseDir(string dir) => new(Path.GetFullPath(dir));

            static bool? ParseBool(string val) => bool.TryParse(val, out var result) ? result : null;

            args.ElmDir           = Get("elm", ParseDir);
            args.CqlDir           = Get("cql", ParseDir);
            args.CSharpDir        = Get("cs", ParseDir);
            args.FhirDir          = Get("fhir", ParseDir);
            args.Debug            = Get("d", ParseBool);
            args.Force            = Get("f", ParseBool);
            args.CanonicalRootUrl = Get("canonical-root-url", s => s.TrimEnd('/'));


            Debug.WriteLine(
                $$"""
                  Parsed config:
                  {{
                      string.Join(Environment.NewLine,
                      from kv in args.KeyValues()
                      orderby kv.Key
                      select $"- {kv.Key}: {kv.Value}")
                  }}
                  """);


            return args;
        }

        private static Dictionary<string, string?>? GetConfigFromArgs(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            var config = configuration
                .AsEnumerable()
                .ToDictionary(kv => kv.Key, kv => kv.Value);

            Debug.WriteLine(
                $$"""
                  PackageCLI called with {{config.Count}} argument(s):
                  {{string.Join(Environment.NewLine,
                      from kv in config
                      orderby kv.Key
                      select $"- {kv.Key}: {kv.Value}")}}
                  """);

            if (config.Keys
                .Except(supportedArgs)
                .ToList() is { Count: > 0 } unknownArgs)
            {
                Console.Error.WriteLine($"Unknown args: {string.Join(", ", unknownArgs)}.");
                return null;
            }

            return config;
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
            resourcePackager.Package(new PackageArgs(elmDir, cqlDir, resourceCanonicalRootUrl: resourceCanonicalRootUrl));
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