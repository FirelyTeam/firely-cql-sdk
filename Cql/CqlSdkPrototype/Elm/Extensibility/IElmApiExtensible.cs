using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Extensibility;

public interface IElmApiExtensible<TElmApi>
    where TElmApi : IElmApiExtensible<TElmApi>
{
    static abstract TElmApi Create(ElmApiOptions? options = null);
    ElmApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmCompilationEntry> Entries { get; }
    TElmApi WithOptions(Func<ElmApiOptions, ElmApiOptions> replaceOptions);
    TElmApi AddElmLibraries(IEnumerable<Library> libraries);
    TElmApi Compile();
    TResult UseLogger<TResult>(Func<TElmApi, ILogger<TElmApi>, TResult> action); // Useful for extensions methods
}

internal interface IElmApiInternal<TElmApi> : IElmApiExtensible<TElmApi>
    where TElmApi : IElmApiExtensible<TElmApi>
{
    T UseServices<T>(Func<(TElmApi elmApi, ILogger<TElmApi> logger, AssemblyCompiler assemblyCompiler, LibrarySetCSharpCodeGenerator librarySetCSharpCodeGenerator), T> action); // Useful for extensions methods
}