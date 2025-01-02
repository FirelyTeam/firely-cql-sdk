using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Loader;
using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Runtime;

public partial class LibrarySetInvoker : IDisposable
{

    private readonly AssemblyLoadContext _asm;

    private LibrarySetInvoker(AssemblyLoadContext asm, ILogger? logger)
    {
        _asm = asm;
        LibraryInvokers =
            _asm.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(t =>
                {
                    LibraryInvoker.TryCreateFromType(t, out var libraryInvoker, logger);
                    return libraryInvoker;
                })
                .ToImmutableDictionary(o => o.LibraryVersionedIdentifier);
    }

    public void Dispose()
    {
        _asm.Unload();
    }

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> LibraryInvokers { get; }
}

partial class LibrarySetInvoker
{
    public static void Run(
        ServiceProvider serviceProvider,
        CqlTranslator cqlTranslation,
        ElmCompiler elmCompilation)
    {
        var logger = serviceProvider.GetLogger<Program>();
        logger.LogInformation("Executing");
        if (TryCreate(out var librarySetInvoker, cqlTranslation, elmCompilation, logger))
        {
            CqlContext cqlContext = FhirCqlContext.ForBundle();
            var devDays = librarySetInvoker.LibraryInvokers[CqlVersionedLibraryIdentifier.Parse("DevDays-2023.0.0")];
            var patientDeclaration = devDays.Declarations["Patient"];
            var patient = patientDeclaration.Invoke(cqlContext);
        }
    }

    public static bool TryCreate(
        [NotNullWhen(true)] out LibrarySetInvoker? librarySetInvoker,
        CqlTranslator cqlTranslation,
        ElmCompiler elmCompilation,
        ILogger logger)
    {
        librarySetInvoker = null;
        logger.LogInformation("Creating LibrarySetInvoker");

        var alc = new AssemblyLoadContext("", true);
        foreach (byte[] bytes in elmCompilation.AssemblyBinaries.Values)
            alc.LoadFromBytes(bytes);

        librarySetInvoker = new LibrarySetInvoker(alc, logger);
        return true;
    }
}