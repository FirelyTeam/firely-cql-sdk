using Hl7.Cql.CodeGeneration.NET.Hosting;
using Hl7.Cql.Compiler.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreTests;

internal static class CqlServicesInitializer
{
    public static CqlCompilerServices CreateCqlCompilerServices(DisposeContextToken disposeContextToken)
    {
        var services = new ServiceCollection()
                       .AddLogging(loggingBuilder =>
                       {
                           loggingBuilder.ClearProviders();
                           loggingBuilder.AddDebug();
                       })
                       .AddCqlCompilerServices();
        var serviceProvider = disposeContextToken.RegisterDisposable(services.BuildServiceProvider());
        return serviceProvider.GetCqlCompilerServices();
    }

    public static CqlCodeGenerationServices CreateCqlCodeGenerationServices(DisposeContextToken disposeContextToken)
    {
        var services = new ServiceCollection()
                       .AddLogging(loggingBuilder =>
                       {
                           loggingBuilder.ClearProviders();
                           loggingBuilder.AddDebug();
                       })
                       .AddCqlCodeGenerationServices();
        var serviceProvider = disposeContextToken.RegisterDisposable(services.BuildServiceProvider());
        return serviceProvider.GetCqlCodeGenerationServices();
    }
}

public readonly struct DisposeContext() : IDisposable
{
    private readonly CancellationTokenSource _cancellationTokenSource = new();

    public void Dispose()
    {
        _cancellationTokenSource.Cancel(); // This triggers registered disposables to dispose.
        _cancellationTokenSource.Dispose();
    }

    public DisposeContextToken Token => new(_cancellationTokenSource.Token);
}

public readonly struct DisposeContextToken
{
    private readonly CancellationToken _cancellationToken;

    internal DisposeContextToken(CancellationToken cancellationToken) =>
        _cancellationToken = cancellationToken;

    public TDisposable RegisterDisposable<TDisposable>(TDisposable disposable)
        where TDisposable: notnull, IDisposable
    {
        _cancellationToken.Register(disposable.Dispose);
        return disposable;
    }
}
