using System.Diagnostics;
using CqlSdkPrototype.Advanced;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DateTime = System.DateTime;

namespace CqlSdkPrototype.CqlToElm;

public class CqlTranslation :
    ILogAccessor<CqlTranslation>
{
    private readonly record struct State
    (
        IServiceProvider ServiceProvider,
        ILogger<CqlTranslation> Logger,
        CqlTranslationDictionary Entries,
        CqlTranslationCreateOptions Options);

    private readonly State _state;

    public IReadOnlyDictionary<ElmLibraryIdentifier, ElmVersionedLibraryIdentifier> VersionedIdentifiers =>
        _state.Entries
              .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    internal IReadOnlyDictionary<ElmVersionedLibraryIdentifier, Library> ElmLibraries =>
        _state.Entries
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

    private readonly record struct LogEntry
        (DateTime TimeStamp, ElmVersionedLibraryIdentifier VersionedIdentifier, string Message);

    #endregion

    #region Construction

    private CqlTranslation(
        IServiceProvider serviceProvider,
        CqlTranslationCreateOptions options)
        : this(new State(
                   serviceProvider,
                   serviceProvider.GetLogger<CqlTranslation>(),
                   CqlTranslationDictionary.Empty.WithComparers(
                       ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer),
                   options)) { }

    private CqlTranslation(State state)
    {
        _state = state;
    }

    private CqlTranslation Mutate(
        CqlTranslationDictionary? entries = null)
    {
        return new CqlTranslation(_state with
        {
            Entries = entries ?? _state.Entries,
        });
    }

    internal static CqlTranslation Create(
        IServiceProvider serviceProvider,
        CqlTranslationCreateOptions? options = null)
    {
        return new CqlTranslation(
            serviceProvider,
            options ?? CqlTranslationCreateOptions.Default);
    }

    #endregion

    #region Loading/Adding CQL Libraries

    private CqlTranslation AddCqlLibraries(IEnumerable<CqlLibrary> cqlLibraries)
    {
        var libraryCompilationsBuilder = _state.Entries.ToBuilder();
        var hasChanged = false;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedIdentifier;

            if (libraryCompilationsBuilder.ContainsKey(versionedIdentifier))
            {
                _state.Logger.LogInformation($"Skipping adding previous cql to translation: {versionedIdentifier}");
                continue;
            }

            var libraryCompilation = new CqlTranslationEntry(cqlLibrary);
            libraryCompilationsBuilder.Add(versionedIdentifier, libraryCompilation);
            _state.Logger.LogInformation($"Adding cql library to translation: {versionedIdentifier}");
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
                .Select(f =>
                {
                    _state.Logger.LogInformation($"Loading library from file: {f}");
                    var cqlLibrary =
                        new CqlLibrary(ElmVersionedLibraryIdentifier.Parse(f.Name.TrimFileExtension(".cql")),
                                       File.ReadAllText(f.FullName));
                    return cqlLibrary;
                }); // Log errors
        return AddCqlLibraries(cqlLibraries);
    }

    #endregion

    #region Translation

    public CqlTranslation Translate()
    {
        CqlToElmConverter cqlToElmConverter = null!;
        var entriesBuilder = _state.Entries.ToBuilder();
        int changedCount = 0;
        foreach (var (versionedIdentifier, cqlTranslationEntry) in entriesBuilder
                     .Where(kv => kv.Value.ElmLibrary is null))
        {
            if (changedCount == 0)
            {
                _state.Logger.LogInformation("Translating CQL into ELM");
                cqlToElmConverter = _state.ServiceProvider.GetCqlToElmConverter();
                entriesBuilder = _state.Entries.ToBuilder();
            }

            _state.Logger.LogInformation($"Translating CQL: {versionedIdentifier}");
            try
            {
                var cql = cqlTranslationEntry.CqlLibrary.Cql;
                var library = cqlToElmConverter.ConvertLibrary(new StringReader(cql));
                entriesBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
            }
            catch (Exception e)
            {
                if (_state.Options.ShouldThrowError?.Invoke(
                        new CqlTranslationError(this, e, "Translate", versionedIdentifier.ToString())) ?? true)
                    throw;
            }

            changedCount++;
        }

        return changedCount > 0
                   ? Mutate(entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion

    ILogger<CqlTranslation> ILogAccessor<CqlTranslation>.Logger => _state.Logger;
}