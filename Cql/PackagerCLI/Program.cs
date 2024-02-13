#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using System.Diagnostics;
using System.Globalization;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.FhirPath.Sprache;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Hl7.Cql.Packager
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length == 0 ||
                new[] { "-?", "-h", "-help" }.Any(args.Contains))
                return ShowHelp();

            var switchMappings = new SortedDictionary<string, string>
            {
                ["--elm"] = nameof(RawPackageOptions.ElmDirectory),
                ["--cql"] = nameof(RawPackageOptions.CqlDirectory),
                ["--fhir"] = nameof(RawPackageOptions.FhirDirectory),
                ["--cs"] = nameof(RawPackageOptions.CSharpDirectory),
                ["--d"] = nameof(RawPackageOptions.Debug),
                ["--f"] = nameof(RawPackageOptions.Force),
                ["--canonical-root-url"] = nameof(RawPackageOptions.CanonicalRootUrl),
                ["--override-utc-date-time"] = nameof(RawPackageOptions.OverrideUtcDateTime)
            };

            var config = new ConfigurationBuilder()
                .AddCommandLine(args, switchMappings)
                .Build();

            var configKeyValues = config.AsEnumerable();

            if (configKeyValues
                    .Select(kv => kv.Key)
                    .Except(switchMappings.Values)
                    .ToList() is { Count: > 0 } unknownArgs)
            {
                return ShowErrorWithHelp($"Unknown args: {string.Join(", ", unknownArgs)}.");
            }

            RawPackageOptions rawOptions = new RawPackageOptions();
            config.Bind(rawOptions);

            if (string.IsNullOrEmpty(rawOptions.ElmDirectory))
                return ShowErrorWithHelp("--elm: required argument missing.");

            if (string.IsNullOrEmpty(rawOptions.CqlDirectory))
                return ShowErrorWithHelp("--cql: required argument missing.");

            string lastArgName = "";
            PackageOptions options = null!;
            try
            {
                options = new PackageOptions
                {
                    ElmDirectory = rawOptions.ElmDirectory
                        .Do(() => lastArgName = "--elm")
                        .GetDirectory()
                        .MustExist(),
                    CqlDirectory = rawOptions.CqlDirectory
                        .Do(() => lastArgName = "--cql")
                        .GetDirectory()
                        .MustExist(),
                    CSharpDirectory = rawOptions.CSharpDirectory
                        .Do(() => lastArgName = "--cs")
                        .GetDirectory()
                        .CreateIfNotExists(),
                    FhirDirectory = rawOptions.FhirDirectory
                        .Do(() => lastArgName = "--fhir")
                        .GetDirectory()
                        .CreateIfNotExists(),
                    Debug = rawOptions.Debug
                        .Do(() => lastArgName = "--d"),
                    Force = rawOptions.Force
                        .Do(() => lastArgName = "--f"),
                    CanonicalRootUrl = rawOptions.CanonicalRootUrl
                        .Do(() => lastArgName = "--canonical-root-url")
                        .Return(s => s?.TrimEnd('/')),
                    OverrideUtcDateTime = rawOptions.OverrideUtcDateTime
                        .Do(() => lastArgName = "--override-utc-date-time")
                        .GetUtcDateTime()
                };
            }
            catch (ProcessOptionsException pe)
            {
                return ShowErrorWithHelp($"{lastArgName}: {pe.Message}");
            }

            Package(options);
            return 0;
        }

        private static void Package(PackageOptions options)
        {
            var fhirDir = options.FhirDirectory;
            var csDir = options.CSharpDirectory;
            var elmDir = options.ElmDirectory;
            var cqlDir = options.CqlDirectory;
            var resourceCanonicalRootUrl = options.CanonicalRootUrl;

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
            if (fhirDir != null) resourceWriters.Add(new FhirResourceWriter(fhirDir, cliLogger, options.OverrideUtcDateTime));
            if (csDir != null) resourceWriters.Add(new CSharpResourceWriter(csDir, cliLogger));

            var resourcePackager = new ResourcePackager(logFactory, [..resourceWriters]);
            resourcePackager.Package(new PackageArgs(elmDir, cqlDir, resourceCanonicalRootUrl: resourceCanonicalRootUrl));
        }

        private static int ShowHelp()
        {
            Console.WriteLine(
                """
                Packager CLI Usage:
                
                    -?|-h|-help                   Show this help
                
                    --elm    <directory>          Library root directory
                    --cql    <directory>          CQL root directory
                    [--fhir] <file|directory>     Resource location, either file name or directory
                    [--cs]   <file|directory>     C# output location, either file name or directory
                    [--d]    <true|false>         Produce as a debug assembly
                    [--f]    <true|false>         Force an overwrite even if the output file already exists
                    [--canonical-root-url] <url>  The root url used for the resource canonical. If omitted a '#' will be used
                """);
            return -1;
        }
        private static int ShowErrorWithHelp(string error)
        {
            Console.Error.WriteLine(error);
            return ShowHelp();
        }

    }

    internal class RawPackageOptions
    {

        public string? ElmDirectory { get; set; }
        public string? CqlDirectory { get; set; }
        public string? CSharpDirectory { get; set; }
        public string? FhirDirectory { get; set; }
        public bool Debug { get; set; }
        public bool Force { get; set; }
        public string? CanonicalRootUrl { get; set;}
        public string? OverrideUtcDateTime { get; set; }
    }

    file static class Extensions
    {
        public static T Do<T>(this T value, Action action)
        {
            action();
            return value;
        }

        public static TR Return<T, TR>(this T value, Func<T, TR> func) => 
            func(value);

        public static DirectoryInfo? GetDirectory(this string? dirText) => string.IsNullOrEmpty(dirText) ? null : new DirectoryInfo(Path.GetFullPath(dirText));

        public static DateTime? GetUtcDateTime(this string? utcDateTimeText) => 
            string.IsNullOrEmpty(utcDateTimeText) 
                ? null 
                : DateTime.TryParse(utcDateTimeText, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out var utcDateTime)
                ? utcDateTime
                : throw new ProcessOptionsException("Not a Valid UTC Date Time. (example: 2000-12-31T23:59:59.99Z)");

        public static DirectoryInfo MustExist(this DirectoryInfo? dir) =>
            dir switch
            {
                { Exists: true } v => v,
                { Exists: false } v => throw new ProcessOptionsException($"Directory '{v.FullName}' does not exist."),
                _ => throw new ProcessOptionsException("Directory must be specified and exist.")
            };

        public static DirectoryInfo? CreateIfNotExists(this DirectoryInfo? dir) =>
            dir switch
            {
                { Exists: false } v => CreateDirectoryWithTimeout(v),
                _ => dir,
            };

        private static DirectoryInfo CreateDirectoryWithTimeout(DirectoryInfo d, int timeoutMs = 5000)
        {
            Stopwatch sw = Stopwatch.StartNew();
            while (!d.Exists && sw.ElapsedMilliseconds < timeoutMs)
            {
                d.Create();
                d.Refresh();
            }
            if (!d.Exists)
                throw new ProcessOptionsException($"Unable to create directory {d.FullName} after {timeoutMs}ms");
            return d;
        }
    }

    file class ProcessOptionsException(string message) : Exception(message);
}