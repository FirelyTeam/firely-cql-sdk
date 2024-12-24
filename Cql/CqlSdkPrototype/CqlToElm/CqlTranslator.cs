using CqlSdkPrototype.Advanced;
using CqlSdkPrototype.CqlToElm.Advanced;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.CqlToElm;

using CqlTranslationEntriesMap = System.Collections.Immutable.ImmutableDictionary<
    CqlVersionedLibraryIdentifier,
    CqlTranslator.CqlTranslationEntry>;

public class CqlTranslator :
    ICqlLibraryStringContentAcceptor<CqlTranslator>,
    ILogAccessor<CqlTranslator>
{
    private readonly State _state;
    ILogger<CqlTranslator> ILogAccessor<CqlTranslator>.Logger => _state.Logger;

    public IReadOnlyDictionary<CqlLibraryIdentifier, CqlVersionedLibraryIdentifier> VersionedIdentifiers =>
        _state.Entries
              .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    internal IReadOnlyDictionary<CqlVersionedLibraryIdentifier, Library> ElmLibraries =>
        _state.Entries
              .Where(kv => kv.Value.ElmLibrary is not null)
              .ToDictionary(kv => kv.Key, kv => kv.Value.ElmLibrary!);

    internal IReadOnlyDictionary<CqlVersionedLibraryIdentifier, string> ElmJsonStrings =>
        ElmLibraries
            .ToDictionary(kv => kv.Key, kv =>
            {
                var json = kv.Value.SerializeToJson(true);
                return json;
            });

    #region Nested Types
    private readonly record struct State(
        IServiceProvider ServiceProvider,
        ILogger<CqlTranslator> Logger,
        CqlTranslationEntriesMap Entries,
        CqlTranslationCreateOptions Options);

    internal readonly record struct CqlTranslationEntry(CqlLibraryStringContent CqlLibraryStringContent, Library? ElmLibrary = null);

    #endregion

    #region Construction

    private CqlTranslator(
        IServiceProvider serviceProvider,
        CqlTranslationCreateOptions options)
        : this(new State(
                   serviceProvider,
                   serviceProvider.GetLogger<CqlTranslator>(),
                   CqlTranslationEntriesMap.Empty.WithComparers(
                       CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer),
                   options)) { }

    private CqlTranslator(State state)
    {
        _state = state;
    }

    private CqlTranslator Mutate(
        CqlTranslationEntriesMap? entries = null)
    {
        return new CqlTranslator(_state with
        {
            Entries = entries ?? _state.Entries,
        });
    }

    internal static CqlTranslator Create(
        IServiceProvider serviceProvider,
        CqlTranslationCreateOptions? options = null)
    {
        return new CqlTranslator(
            serviceProvider,
            options ?? CqlTranslationCreateOptions.Default);
    }

    #endregion

    #region Loading/Adding CQL Libraries

    CqlTranslator ICqlLibraryStringContentAcceptor<CqlTranslator>.AcceptLibraries(IEnumerable<CqlLibraryStringContent> libraries)
    {
        return AddCqlLibraries(libraries);
    }

    private CqlTranslator AddCqlLibraries(IEnumerable<CqlLibraryStringContent> cqlLibraries)
    {
        var libraryCompilationsBuilder = _state.Entries.ToBuilder();
        var hasChanged = false;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedLibraryIdentifier;

            if (libraryCompilationsBuilder.ContainsKey(versionedIdentifier))
            {
                _state.Logger.LogInformation("Skipping adding previous cql to translation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            var libraryCompilation = new CqlTranslationEntry(cqlLibrary);
            libraryCompilationsBuilder.Add(versionedIdentifier, libraryCompilation);
            _state.Logger.LogInformation("Adding cql library to translation: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        return hasChanged
                   ? Mutate(entries: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Translation

    public CqlTranslator Translate()
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

            _state.Logger.LogInformation("Translating CQL: {id}", versionedIdentifier);
            try
            {
                var cql = cqlTranslationEntry.CqlLibraryStringContent.Cql;
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
}