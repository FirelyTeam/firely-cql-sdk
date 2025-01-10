using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.CqlToElm.Visitors;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;

namespace CqlSdkPrototype;

public static class Extensions
{
    public static IServiceCollection AddElmApi(
        this IServiceCollection serviceCollection,
        Action<ElmServicesOptions>? configureOptions = null)
    {
        ElmServicesOptions? elmCompilationOptions = null;
        if (configureOptions is { } fn)
        {
            elmCompilationOptions = new ElmServicesOptions();
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

    public static IServiceCollection SuppressCqlDebugAssertions(
        this IServiceCollection serviceCollection)
    {
        // This is really annoying in debug mode
        ExpressionVisitor.EnableDebugAssertions = false;
        Library.EnableDebugAssertions = false;
        return serviceCollection;
    }

    public static IServiceCollection AddCqlApi(
        this IServiceCollection serviceCollection,
        Action<CqlServicesOptions>? configureOptions = null)
    {
        serviceCollection.SuppressCqlDebugAssertions();

        CqlServicesOptions? cqlTranslationOptions = null;
        if (configureOptions is { } fn)
        {
            cqlTranslationOptions = new CqlServicesOptions();
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