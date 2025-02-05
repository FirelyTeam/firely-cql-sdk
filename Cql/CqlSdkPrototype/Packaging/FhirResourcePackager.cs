using System.Runtime.ExceptionServices;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Packaging.Fluent;
using CqlSdkPrototype.Packaging.Internal;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
using DateTime = System.DateTime;

namespace CqlSdkPrototype.Packaging;

public sealed class FhirResourcePackager
{
    public FhirResourcePackager(
        ILoggerFactory? loggerFactory = null,
        FhirResourcePackagerConfig? config = null)
    {
        config ??= FhirResourcePackagerConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _fhirResourcePackagings = FhirResourcePackagingDictionary.Empty;
        Config = config;
        _services = FhirResourcePackagerServices.Create(loggerFactory);
    }

    private FhirResourcePackagingDictionary _fhirResourcePackagings;
    private FhirResourcePackagerServices _services;

    /// <summary>
    /// Gets the logger factory used by extensions via <seealso cref="FluentPackagingToolkit.LoggerFactory"/>.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests via <seealso cref="FluentPackagingToolkit.ServiceProvider"/>.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;


    /// <summary>
    /// Gets the configuration settings for the resource packager.
    /// </summary>
    public FhirResourcePackagerConfig Config { get; private set; }

    /// <summary>
    /// Gets the dictionary of FHIR resource packagings.
    /// </summary>
    public FhirResourcePackagingReadOnlyDictionary FhirResourcePackagings => _fhirResourcePackagings;


    /// <summary>
    /// Reconfigures the packager with the specified configuration.
    /// </summary>
    /// <param name="config">The new configuration for the packager.</param>
    public void Reconfigure(
        FhirResourcePackagerConfig config)
    {
        if (Config == config)
            return;

        //_services.ServiceProvider.Dispose();
        Config = config;
        //_services = ElmToAssemblyProcessorServices.Create(LoggerFactory, config);
    }

    private void SetFhirResourcePackagings(FhirResourcePackagingDictionary packagings) =>
        _fhirResourcePackagings = packagings;

    /// <summary>
    /// Adds FHIR resource packaging inputs to the packager.
    /// </summary>
    /// <param name="inputs">The collection of FHIR resource packaging inputs to add.</param>
    public void AddPackagingInputs(IEnumerable<FhirResourcePackagingInput> inputs)
    {
        var builder = _fhirResourcePackagings.ToBuilder();
        var hasChanged = false;
        foreach (var input in inputs)
        {
            if (builder.TryGetValue(input.VersionedLibraryIdentifier, out var existing))
            {
                _services.Logger.LogInformation("Skipping replacing library {id} to packager.", input.VersionedLibraryIdentifier);
                continue;
            }

            var fhirResourcePackaging = new FhirResourcePackaging(input);
            builder.Add(input.VersionedLibraryIdentifier, fhirResourcePackaging);
            hasChanged = true;
        }

        if (hasChanged)
            _fhirResourcePackagings = builder.ToImmutable();
    }

    public void PackageFhirResources(Uri? canonicalRootUrl, DateTime? overrideDate)
    {
        var builder = _fhirResourcePackagings.ToBuilder();

        var libraries = builder.Values.Select(o => o.Input.ElmLibrary);

        var nodes = libraries.ToUnresolvedLibraryDependencyNodesDictionary();

        // var mermaid = nodes.Values.BuildMermaidFlowChart(
        //     n => n.Dependencies,
        //     node => $"{node.VersionedIdentifier}{(node.Library is null ? "?" : "")}{(node.HasMissingDependenciesRecursive ? "!" : "")}");

        var librariesToPackage =
            nodes.Values
                 .Where(n => !n.HasMissingDependenciesRecursive)
                 .Select(n => n.Library!)
                 .ToArray();
        LibrarySet librarySet = new LibrarySet("", librariesToPackage);

        IEnumerable<ResourcePackager.Input> resourcePackagerInputs = builder.Values
                                                                            .SelectResourcePackagerInputs()
                                                                            .Select(o =>
                                                                            {
                                                                                _services.Logger.LogInformation(
                                                                                    "Packaging resource for {id}.", o.VersionedLibraryIdentifier);
                                                                                return o;
                                                                            });
        var inputsById = resourcePackagerInputs.ToDictionary(o => o.VersionedLibraryIdentifier);
        var count =
            librarySet
                .PackageResources(
                    inputsById: id => inputsById[id],
                    resourcePackager: _services.ResourcePackager,
                    exceptionHandlingStrategy: EnumerationExceptionHandlingStrategy.Delegated<ElmLibrary>((input, e) =>
                    {
                        switch (Config.EnumerationExceptionHandling)
                        {
                            case EnumerationExceptionHandling.Continue:
                                _services.Logger.LogWarning(e.SourceException, "An error occurred while packaging resource for {id}.",
                                                            input.identifier);
                                return true;
                            case EnumerationExceptionHandling.Break:
                                _services.Logger.LogWarning(e.SourceException, "An error occurred while packaging resource for {id}.",
                                                            input.identifier);
                                return false;
                        }

                        _services.Logger.LogError(e.SourceException, "An error occurred while packaging resource for {id}.",
                                                  input.identifier);
                        e.Throw();
                        throw new UnreachableException();
                    }), canonicalRootUrl: canonicalRootUrl, overrideDate: overrideDate)
                .SelectWhere(o =>
                {
                    var cqlVersionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(o.versionedLibraryIdentifier);
                    var fhirResourcePackaging = builder[cqlVersionedLibraryIdentifier];
                    if (fhirResourcePackaging.FhirResource is null)
                    {
                        _services.Logger.LogInformation("Packaged resource for {id}.", o.versionedLibraryIdentifier);
                        builder[cqlVersionedLibraryIdentifier] = fhirResourcePackaging with { FhirResource = o.fhirResource };
                        return (true, o);
                    }

                    _services.Logger.LogWarning("Skipping replacing existing resource for {id}.", o.versionedLibraryIdentifier);
                    return (false, default);
                })
                .Count();

        if (count > 0)
            SetFhirResourcePackagings(builder.ToImmutable());
    }
}

file static class Extensions
{
    public static IEnumerable<(string versionedLibraryIdentifier, FhirResource fhirResource)> PackageResources(
        this LibrarySet librarySet,
        Func<string, ResourcePackager.Input> inputsById,
        ResourcePackager resourcePackager,
        EnumerationExceptionHandlingStrategy<ElmLibrary>? exceptionHandlingStrategy,
        Uri? canonicalRootUrl,
        DateTime? overrideDate) =>
        resourcePackager.PackageResourcesV2(
            librarySet,
            inputsById,
            exceptionHandlingStrategy,
            canonicalRootUrl?.ToString(),
            overrideDate);

    public static IEnumerable<ResourcePackager.Input> SelectResourcePackagerInputs(
        this IEnumerable<FhirResourcePackaging> resourcePackagings)
    {
        foreach (var (((versionedLibraryIdentifier, cql), elmLibrary, cSharpSourceCode, assemblyBinary), _) in resourcePackagings)
            yield return new ResourcePackager.Input(versionedLibraryIdentifier.ToString(), cql, elmLibrary, cSharpSourceCode, assemblyBinary);
    }

    public static IEnumerable<TOutput> Select<TInput, TOutput>(
        this IEnumerable<TInput> source,
        Func<TInput, TOutput> selector,
        EnumerationExceptionHandlingStrategy<TInput> exceptionHandlingStrategy)
    {
        using var enumerator = source.GetEnumerator();
        while (true)
        {
            try
            {
                if (!enumerator.MoveNext())
                    break;
            }
            catch (Exception e)
            {
                if (!exceptionHandlingStrategy.HandleException(enumerator.Current, ExceptionDispatchInfo.Capture(e)))
                    break;
                continue;
            }

            TOutput output;
            try
            {
                output = selector(enumerator.Current);
            }
            catch (Exception e)
            {
                if (!exceptionHandlingStrategy.HandleException(enumerator.Current, ExceptionDispatchInfo.Capture(e)))
                    break;
                continue;
            }

            yield return output;
        }
    }

    public static (bool movedNext, T result, ExceptionDispatchInfo? exception) TryMoveNext<T>(this IEnumerator<T> enumerator)
    {
        try
        {
            if (enumerator.MoveNext())
                return (true, enumerator.Current, null);
            return (false, default!, null);
        }
        catch (Exception e)
        {
            return (true, default!, ExceptionDispatchInfo.Capture(e));
        }
    }
}

file readonly record struct IdentifierValue<TValue>(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, TValue value);

file readonly record struct IdentifierDeferred<TValue>(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, Func<TValue> getNextValue);