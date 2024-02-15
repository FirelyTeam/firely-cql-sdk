using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packager;

internal partial class PackagerOptions
{
    public const string ConfigSection = "Packager";

    public const string Usage = 
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
         """;

    public static IDictionary<string, string> BuildSwitchMappings() =>
        new SortedDictionary<string, string>
        {
            // @formatter:off
            [ArgNameElmDirectory]     = ConfigSection + ':' + nameof(ElmDirectory),
            [ArgNameCqlDirectory]     = ConfigSection + ':' + nameof(CqlDirectory),
            [ArgNameFhirDirectory]    = ConfigSection + ':' + nameof(FhirDirectory),
            [ArgNameCSharpDirectory]  = ConfigSection + ':' + nameof(CSharpDirectory),
            [ArgNameDebug]            = ConfigSection + ':' + nameof(Debug),
            [ArgNameForce]            = ConfigSection + ':' + nameof(Force),
            [ArgNameCanonicalRootUrl] = ConfigSection + ':' + nameof(CanonicalRootUrl),
            // @formatter:on
        };

    public const string ArgNameElmDirectory = "--elm";
    public DirectoryInfo ElmDirectory { get; set; } = null!;


    public const string ArgNameCqlDirectory = "--cql";
    public DirectoryInfo CqlDirectory { get; set; } = null!;


    public const string ArgNameCSharpDirectory = "--cs";
    public DirectoryInfo? CSharpDirectory { get; set; }


    public const string ArgNameFhirDirectory = "--fhir";
    public DirectoryInfo? FhirDirectory { get; set; }


    public const string ArgNameDebug = "--d";
    public bool Debug { get; set; }


    public const string ArgNameForce = "--f";
    public bool Force { get; set; }


    public const string ArgNameCanonicalRootUrl = "--canonical-root-url";
    public Uri? CanonicalRootUrl { get; set; }
}

partial class PackagerOptions
{
    internal static void BindDirectoryInfos(IConfiguration config, PackagerOptions opt)
    {
        var section = config.GetRequiredSection(ConfigSection);
        opt.ElmDirectory = GetDirectoryInfo(nameof(ElmDirectory))!;
        opt.CqlDirectory = GetDirectoryInfo(nameof(CqlDirectory))!;
        opt.CSharpDirectory = GetDirectoryInfo(nameof(CSharpDirectory));
        opt.FhirDirectory = GetDirectoryInfo(nameof(FhirDirectory));

        DirectoryInfo? GetDirectoryInfo(string key)
        {
            var path = section[key];
            return string.IsNullOrWhiteSpace(path) ? null : new DirectoryInfo(Path.GetFullPath(path));
        }
    }
    
    internal class Validator : IValidateOptions<PackagerOptions>
    {
        public ValidateOptionsResult Validate(string? name, PackagerOptions options)
        {
            ValidateOptionsResultBuilder? builder = null;
            SemaphoreSlim slimLock = new(initialCount: 1, maxCount: 1);

            var elm = (ArgNameElmDirectory, options.ElmDirectory);
            var cql = (ArgNameCqlDirectory, options.CqlDirectory);
            var cs = (ArgNameCSharpDirectory, options.CSharpDirectory);
            var fhir = (ArgNameFhirDirectory, options.FhirDirectory);

            _ = ValidateRequired(elm) && ValidateDirectoryExists(elm);

            _ = ValidateRequired(cql) && ValidateDirectoryExists(cql);

            Task.WhenAll(
                CreateDirectoryIfNotExistsAsync(cs),
                CreateDirectoryIfNotExistsAsync(fhir))
                .GetAwaiter().GetResult();


            var result = builder?.Build() ?? ValidateOptionsResult.Success;
            return result;

            bool ValidateRequired<T>( (string name, T? value) arg)
            {
                if (arg.value is null)
                {
                    AddError($"{arg.name}: must be specified.");
                    return false;
                }

                return true;
            }

            bool ValidateDirectoryExists( (string name, DirectoryInfo? value) arg)
            {
                if (arg.value is { Exists: false } dir)
                {
                    AddError($"{arg.name}: directory '{dir}' does not exist.");
                    return false;
                }

                return true;
            }

            async Task<bool> CreateDirectoryIfNotExistsAsync((string name, DirectoryInfo? value) arg)
            {
                if (arg.value is { Exists: false } dir)
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    try
                    {
                        while (sw.ElapsedMilliseconds < 5000)
                        {
                            dir.Create();
                            dir.Refresh();
                            if (dir.Exists)
                                return true;

                            await Task.Delay(250);
                        }
                    }
                    catch (Exception e)
                    {
                        AddError($"{arg.name}: directory '{dir}' could not be created: {e.Message}");
                        return false;
                    }

                    AddError($"{arg.name}: directory '{dir}' could not be created.");
                    return false;
                }

                return true;
            }

            void AddError(string message)
            {
                if (!slimLock.Wait(Timeout.Infinite))
                    throw new InvalidOperationException("Failed to acquire lock.");

                try
                {
                    (builder ??= new()).AddError(message);
                }
                finally
                {
                    slimLock.Release();
                }
            }
        }
    }
}