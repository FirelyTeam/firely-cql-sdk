#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using System.Diagnostics;
using System.Globalization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;

namespace Hl7.Cql.Packager
{

    public static class Program
    {
        public static int Main(string[] args)
        {
            args = args.Except(new[] { "--elm" }).ToArray();

            if (args.Length == 0 ||
                new[] { "-?", "-h", "-help" }.Any(s => args.Contains(s, StringComparer.InvariantCultureIgnoreCase)))
                return ShowHelp();

            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(ConfigureConfiguration)
                .ConfigureLogging(ConfigureLogging)
                .ConfigureServices(ConfigureServices);

            using var host = hostBuilder.Build();
            using var mainScope = host.Services.CreateScope();
            var packageService = mainScope.ServiceProvider.GetRequiredService<PackagerService>();
            return packageService.Run();

            void ConfigureConfiguration(HostBuilderContext hostContext, IConfigurationBuilder config)
            {
                IDictionary<string, string> switchMappings = PackagerOptions.BuildSwitchMappings();
                config.AddCommandLine(args, switchMappings);
            }

            static void ConfigureLogging(HostBuilderContext hostContext, ILoggingBuilder logging)
            {
                logging.AddFilter(level => level >= LogLevel.Trace);
                logging.AddConsole(console =>
                {
                    console.LogToStandardErrorThreshold = LogLevel.Error;
                });
                var logFile = Path.Combine(".", "build.txt");
                Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .WriteTo
                    .File(logFile, formatProvider: CultureInfo.InvariantCulture)
                    .CreateLogger();
                logging.AddSerilog();
            }
            
            static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
            {
                services.AddTransient<PackagerService>();

                services.AddOptions<PackagerOptions>()
                    .BindConfiguration(PackagerOptions.ConfigSection, o => o.ErrorOnUnknownConfiguration = true)
                    .ValidateOnStart();
                services.AddSingleton<IValidateOptions<PackagerOptions>, PackagerOptions>();
            }
        }

        private static int ShowHelp()
        {
            Console.WriteLine(
                """
                Packager CLI Usage:
                
                    -?|-h|-help                     Show this help
                
                    --elm       <directory>         Library root directory
                    --cql       <directory>         CQL root directory
                    [--fhir]    <file|directory>    Resource location, either file name or directory
                    [--cs]      <file|directory>    C# output location, either file name or directory
                    [--d]       <true|false>        Produce as a debug assembly
                    [--f]       <true|false>        Force an overwrite even if the output file already exists
                    [--canonical-root-url] <url>    The root url used for the resource canonical.
                                                    If omitted a '#' will be used
                    [--override-utc-date-time] <utc-date-time>
                                                    The date time to use for the library and resource last updated.
                                                    (example: 2000-12-31T23:59:59.99Z)
                                                    If omitted the current date time will be used.
                """);
            return -1;
        }
    }

    internal class PackagerService
    {
        private readonly PackagerOptions _packagerOptions;

        public PackagerService(IOptions<PackagerOptions> packageArgsOptions)
        {
            _packagerOptions = packageArgsOptions.Value;
        }

        public int Run()
        {
            Console.WriteLine("Hello World!");
            return 0;
        }
    }

    /*
    public static class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length == 0 ||
                new[] { "-?", "-h", "-help" }.Any(s => args.Contains(s, StringComparer.InvariantCultureIgnoreCase)))
                return ShowHelp();

            var switchMappings = new SortedDictionary<string, string>
            {
                ["--elm"] = nameof(CommandlineArgs.ElmDirectory),
                ["--cql"] = nameof(CommandlineArgs.CqlDirectory),
                ["--fhir"] = nameof(CommandlineArgs.FhirDirectory),
                ["--cs"] = nameof(CommandlineArgs.CSharpDirectory),
                ["--d"] = nameof(CommandlineArgs.Debug),
                ["--f"] = nameof(CommandlineArgs.Force),
                ["--canonical-root-url"] = nameof(CommandlineArgs.CanonicalRootUrl),
                ["--override-utc-date-time"] = nameof(CommandlineArgs.OverrideUtcDateTime)
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

            CommandlineArgs rawOptions = new CommandlineArgs();
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

            var resourcePackager = new ResourcePackager(logFactory, resourceWriters.ToArray());
            resourcePackager.Package(new PackageArgs(elmDir, cqlDir, resourceCanonicalRootUrl: resourceCanonicalRootUrl));
        }

        private static int ShowHelp()
        {
            Console.WriteLine(
                """
                Packager CLI Usage:
                
                    -?|-h|-help                     Show this help
                
                    --elm       <directory>         Library root directory
                    --cql       <directory>         CQL root directory
                    [--fhir]    <file|directory>    Resource location, either file name or directory
                    [--cs]      <file|directory>    C# output location, either file name or directory
                    [--d]       <true|false>        Produce as a debug assembly
                    [--f]       <true|false>        Force an overwrite even if the output file already exists
                    [--canonical-root-url] <url>    The root url used for the resource canonical. 
                                                    If omitted a '#' will be used
                    [--override-utc-date-time] <utc-date-time>
                                                    The date time to use for the library and resource last updated.
                                                    (example: 2000-12-31T23:59:59.99Z) 
                                                    If omitted the current date time will be used.
                """);
            return -1;
        }
        private static int ShowErrorWithHelp(string error)
        {
            Console.Error.WriteLine(error);
            return ShowHelp();
        }

    }
    */

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

    file class ProcessOptionsException : Exception
    {
        public ProcessOptionsException(string message) : base(message)
        {
        }
    }
}