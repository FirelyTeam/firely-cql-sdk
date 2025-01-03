using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Microsoft.Extensions.DependencyInjection;

namespace CqlSdkPrototype;

public static class Extensions
{
    public static IServiceCollection AddElmCompilation(
        this IServiceCollection serviceCollection,
        Action<ElmCompilationOptions>? configureOptions = null)
    {
        ElmCompilationOptions? elmCompilationOptions = null;
        if (configureOptions is { } fn)
        {
            elmCompilationOptions = new ElmCompilationOptions();
            fn(elmCompilationOptions);
        }

        return serviceCollection
            .AddCqlCodeGenerationServices(
                ConfigureAssemblyDataWriterOptions(),
                ConfigureCSharpCodeWriterOptions());


        Action<CSharpCodeWriterOptions>? ConfigureCSharpCodeWriterOptions()
        {
            return /*elmCompilationOptions is { } o
                       ? cSharpCodeWriterOptions =>
                       {
                       }
                       : */null;
        }

        Action<AssemblyDataWriterOptions>? ConfigureAssemblyDataWriterOptions()
        {
            return elmCompilationOptions is { } o
                       ? assemblyDataWriterOptions =>
                       {
                           assemblyDataWriterOptions.DebugModeAssemblies = o.AssembliesDebugMode;
                       }
                       : null;
        }
    }

    public static IServiceCollection AddCqlTranslation(
        this IServiceCollection serviceCollection,
        Action<CqlTranslationOptions>? configureOptions = null)
    {
        // This is really annoying in debug mode
        ExpressionVisitor.EnableDebugAssertions = false;
        Library.EnableDebugAssertions = false;

        CqlTranslationOptions? cqlTranslationOptions = null;
        if (configureOptions is { } fn)
        {
            cqlTranslationOptions = new CqlTranslationOptions();
            fn(cqlTranslationOptions);
        }

        return serviceCollection
               .AddCqlToElmServices()
               .AddCqlToElmModels(ConfigureModelProvider())
               .AddCqlToElmOptions(ConfigureCqlToElmOptions())
               .AddSingleton<ILibraryProvider, MemoryLibraryProvider>()
               .AddCqlToElmMessaging();

        Action<CqlToElmOptions>? ConfigureCqlToElmOptions()
        {
            return null;
        }

        Action<IModelProvider> ConfigureModelProvider()
        {
            return cqlTranslationOptions is { } o
                       ? modelProvider =>
                       {
                           foreach (var modelInfo in o.Models)
                               modelProvider.Add(modelInfo);
                       }
                       : _ => { };
        }
    }
}

public class CqlTranslationOptions
{
    public ModelInfo[] Models { get; set; } = [];
}

public class ElmCompilationOptions
{
    //public DirectoryInfo? AssembliesOutDirectory { get; set; }
    public bool AssembliesDebugMode { get; set; }
    //public DirectoryInfo? CSharpOutDirectory { get; set; }
}