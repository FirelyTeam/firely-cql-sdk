using System.Collections.Immutable;
using System.Diagnostics;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using static CqlSdkPrototype.CqlToElm.CqlTranslation;
using DateTime = System.DateTime;

namespace CqlSdkPrototype.CqlToElm;

using CqlTranslationDictionary = ImmutableDictionary<ElmVersionedLibraryIdentifier, CqlTranslationEntry>;

public record CqlTranslationCreateOptions
{
    public static CqlTranslationCreateOptions Default { get; }

    static CqlTranslationCreateOptions()
    {
        Default = new CqlTranslationCreateOptions();
    }

    private CqlTranslationCreateOptions() { }
}

public class CqlTranslation
{
    private static readonly CqlTranslation Start;
    private static readonly DateTime TimerStarted;
    private static readonly Stopwatch Timer;

    static CqlTranslation()
    {
        Start = new CqlTranslation(serviceProvider: BuildServiceProvider());
        TimerStarted = DateTime.Now;
        Timer = Stopwatch.StartNew();
    }

    private readonly ServiceProvider _serviceProvider;
    private readonly CqlTranslationDictionary _entries;
    private readonly ImmutableList<LogEntry> _logEntries;
    private readonly CqlTranslationCreateOptions _options;

    public IReadOnlyDictionary<ElmLibraryIdentifier, ElmVersionedLibraryIdentifier> VersionedIdentifiers =>
        _entries
            .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    internal IReadOnlyDictionary<ElmVersionedLibraryIdentifier, Library> ElmLibraries =>
        _entries
            .Where(kv => kv.Value.ElmLibrary is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.ElmLibrary!);

    internal IReadOnlyDictionary<ElmVersionedLibraryIdentifier, string> ElmJsonStrings =>
        ElmLibraries
            .ToDictionary(kv => kv.Key, kv =>
            {
                var json = kv.Value.SerializeToJson(true);
                return json;
            });

    #region Nested Types

    internal readonly record struct CqlLibrary(ElmVersionedLibraryIdentifier VersionedIdentifier, string Cql);
    internal readonly record struct CqlTranslationEntry(CqlLibrary CqlLibrary, Library? ElmLibrary = null);
    private readonly record struct LogEntry(DateTime TimeStamp, ElmVersionedLibraryIdentifier VersionedIdentifier, string Message);

    #endregion

    #region Construction

    private CqlTranslation(
        ServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _entries = CqlTranslationDictionary.Empty
                                           .WithComparers(ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        _logEntries = ImmutableList<LogEntry>.Empty;
        _options = CqlTranslationCreateOptions.Default;
    }

    private CqlTranslation(
        CqlTranslation source,
        CqlTranslationDictionary? entries,
        ImmutableList<LogEntry>? logEntries,
        CqlTranslationCreateOptions? options)
    {
        _serviceProvider = source._serviceProvider;
        _entries = entries ?? source._entries;
        _logEntries = logEntries ?? source._logEntries;
        _options = options ?? source._options;
        // Building of the service provider could possibly move here based on options
    }

    private CqlTranslation Mutate(
        CqlTranslationDictionary? entries = null,
        ImmutableList<LogEntry>? logEntries = null,
        CqlTranslationCreateOptions? options = null)
    {
        return new CqlTranslation(this, entries, logEntries, options);
    }

    internal static CqlTranslation Create(Mutator<CqlTranslationCreateOptions>? buildOptions = null)
    {
        if (buildOptions != null)
        {
            var opt = buildOptions(CqlTranslationCreateOptions.Default);
            return Start.Mutate(options: opt);
        }

        return Start;
    }

    private static ServiceProvider BuildServiceProvider()
    {
        var serviceProvider =
            new ServiceCollection()
                .AddDebugLogging()
                .AddCqlToElmServices()
                .AddCqlToElmModels(
                    mp => mp
                          .Add(Models.ElmR1)
                          .Add(Models.Fhir401)
                )
                .AddCqlToElmOptions(opt =>
                {
                    // Options
                })
                .AddSingleton<ILibraryProvider, MemoryLibraryProvider>()
                .AddCqlToElmMessaging()
                .BuildServiceProvider(validateScopes: true);
        return serviceProvider;
    }

    #endregion

    #region Logging

    private void AddLog(
        ImmutableList<LogEntry>.Builder logEntriesBuilder,
        ElmVersionedLibraryIdentifier versionedIdentifier,
        string message)
    {
        var logEntry = new LogEntry(TimerStarted + Timer.Elapsed, versionedIdentifier, message);
        logEntriesBuilder.Add(logEntry);
    }

    #endregion

    #region Loading/Adding CQL Libraries

    private CqlTranslation AddCqlLibraries(IEnumerable<CqlLibrary> cqlLibraries)
    {
        var libraryCompilationsBuilder = _entries.ToBuilder();
        var hasChanged = false;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedIdentifier;

            if (libraryCompilationsBuilder.ContainsKey(versionedIdentifier))
            {
                Console.WriteLine($"Skipping adding previous cql to translation: {versionedIdentifier}");
                continue;
            }

            var libraryCompilation = new CqlTranslationEntry(cqlLibrary);
            libraryCompilationsBuilder.Add(versionedIdentifier, libraryCompilation);
            Console.WriteLine($"Adding cql library to translation: {versionedIdentifier}");
            hasChanged = true;
        }

        return hasChanged
                   ? Mutate(entries: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    public CqlTranslation LoadCqlFilesFromDirectory(DirectoryInfo directory, EnumerationOptions options)
    {
        var files = directory.EnumerateFiles("*.cql", options);
        return LoadCqlFiles(files);
    }

    private CqlTranslation LoadCqlFiles(IEnumerable<FileInfo> files)
    {
        var cqlLibraries =
            files
                .Where(f =>
                {
                    if (HardcodedIgnores.Identifiers.Contains(f.Name.TrimFileExtension(".cql")))
                    {
                        Console.WriteLine($"Skipping file as from hardcoded names: {f.FullName}");
                        return false;
                    }

                    return true;
                }) // Log skipped files
                .Select(f =>
                {
                    Console.WriteLine($"Loading library from file: {f}");
                    var cqlLibrary = new CqlLibrary(ElmVersionedLibraryIdentifier.Parse(f.Name.TrimFileExtension(".cql")), File.ReadAllText(f.FullName));
                    return cqlLibrary;
                }); // Log errors
        return AddCqlLibraries(cqlLibraries);
    }

    #endregion

    #region Translation

    public CqlTranslation Translate()
    {
        CqlToElmConverter cqlToElmConverter = null!;
        var entriesBuilder = _entries.ToBuilder();
        var logEntriesBuilder = _logEntries.ToBuilder();
        int changedCount = 0;
        foreach (var (versionedIdentifier, cqlTranslationEntry) in entriesBuilder
                     .Where(kv => kv.Value.ElmLibrary is null))
        {
            if (changedCount == 0)
            {
                Console.WriteLine("Translating CQL into ELM");
                cqlToElmConverter = _serviceProvider.GetCqlToElmConverter();
                entriesBuilder = _entries.ToBuilder();
            }

            Console.WriteLine($"Translating CQL: {versionedIdentifier}");
            try
            {
                var library = cqlToElmConverter.ConvertLibrary(new StringReader(cqlTranslationEntry.CqlLibrary.Cql));
                entriesBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed translating CQL: {versionedIdentifier} with error: {e.Message}");
                AddLog(logEntriesBuilder, versionedIdentifier, e.ToString());
            }
            changedCount++;
        }

        return changedCount > 0
                   ? Mutate(entries: entriesBuilder.ToImmutable(), logEntries: logEntriesBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Saving Output

    public CqlTranslation SaveElmFileToDirectory(DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        foreach (var (libraryName, sourceCode) in ElmJsonStrings)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.json");
            File.WriteAllText(fileName, sourceCode);
            Console.WriteLine($"Saved ELM to file: {fileName}");
        }

        return this;
    }

    #endregion
}