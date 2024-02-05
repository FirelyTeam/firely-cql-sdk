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
            var configKeyValues = GetConfigFromArgs(args);
            PackagerArgs config = ParseConfig(configKeyValues);

            if (config.ShowHelp is true
                || config.Errors.Any())
                return ShowHelp(config.Errors.ToArray());

            if (config.CSharpDir is { Exists: false } csDir) 
                EnsureDirectory(csDir);

            if (config.FhirDir is { Exists: false } fhirDir) 
                EnsureDirectory(fhirDir);


            Package(config.ElmDir!, config.CqlDir!, config.CSharpDir, config.FhirDir, config.CanonicalRootUrl);
            return 0;
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
            public HashSet<string> Errors { get; set; } = new();

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

        private static IEnumerable<(string Key, string? Value)> GetConfigFromArgs(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            return configuration
                .AsEnumerable()
                .Select(kv => (kv.Key, kv.Value));
        }

        private static PackagerArgs ParseConfig(IEnumerable<(string Key, string? Value)> configKeyValues)
        {
            PackagerArgs args = new PackagerArgs();

            HashSet<string> found = new();
            HashSet<string> duplicates = new();
            HashSet<string> unsupported = new();
            HashSet<string> errors = new();
            args.Errors = errors;

            foreach (var (key, value) in configKeyValues)
            {
                if (!found.Add(key))
                {
                    errors.Add($"Duplicate argument: {key}");
                    duplicates.Add(key);
                    continue;
                }

                switch (key)
                {
                    case "elm":
                        args.ElmDir = TryParse(value, ParseDir);
                        break;
                    case "cql":
                        args.CqlDir = TryParse(value, ParseDir);
                        break;
                    case "cs":
                        args.CSharpDir = TryParse(value, ParseDir);
                        break;
                    case "fhir":
                        args.FhirDir = TryParse(value, ParseDir);
                        break;
                    case "d":
                        args.Debug = TryParse(value, ParseBool);
                        break;
                    case "f":
                        args.Force = TryParse(value, ParseBool);
                        break;
                    case "canonical-root-url":
                        args.CanonicalRootUrl = value?.TrimEnd('/');
                        break;
                    default:
                        errors.Add($"Unsupported argument: {key}");
                        unsupported.Add(key);
                        break;
                }
            }

            if (args.ElmDir is null)
                errors.Add("Missing required argument: elm");
            else if (!args.ElmDir.Exists)
                errors.Add("Directory does not exist: elm");

            if (args.CqlDir is null)
                errors.Add("Missing required argument: cql");
            else if (!args.CqlDir.Exists)
                errors.Add("Directory does not exist: cql");

            T? TryParse<T>(string? val, Func<string, T> parse)
            {
                if (val is not { } v)
                    return default;

                try
                {
                    if (parse(v) is { } p)
                        return p;
                }
                catch (Exception e)
                {
                    errors.Add($"Unable to parse argument: {val} to a {typeof(T)} ({e.Message})");
                    return default;
                }

                errors.Add($"Unable to parse argument: {val} to a {typeof(T)}");
                return default;
            }

            static DirectoryInfo? ParseDir(string dir) => new(Path.GetFullPath(dir));

            static bool? ParseBool(string val) => bool.TryParse(val, out var result) ? result : null;

            Debug.WriteLine(
                $$"""
                  Parsed Config:
                  {{
                      string.Join(
                          Environment.NewLine,
                          from kv in args.KeyValues()
                          orderby kv.Key
                          select $"- {kv.Key}: {kv.Value}")
                  }}
                  Errors:
                  {{
                      string.Join(
                      Environment.NewLine,
                      from error in errors
                      select $"- {error}")
                  }}
                  """);


            return args;
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

        private static int ShowHelp(params string[] errors)
        {
            Console.WriteLine();
            Console.WriteLine("Packager CLI");
            if (errors.Length > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Errors:");
                foreach (var error in errors) Console.WriteLine($"\t{error}");
            }
            Console.WriteLine();
            Console.WriteLine("Usage:");
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