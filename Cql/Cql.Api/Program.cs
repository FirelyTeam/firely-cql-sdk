using Hl7.Cql.Api;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.LibraryProviders;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Model;
using Microsoft.Extensions.Options;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        ConfigureCqlServices(builder.Services);

        builder.Services.AddScoped<CqlExpressionRunner>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }

    public static void ConfigureCqlServices(IServiceCollection services)
    {
        services
            .AddModels(mp => mp.Add(Models.ElmR1).Add(Models.Fhir401))
            .AddVisitors()
            .AddSystem()
            .AddLocalIdProvider()
            .AddConfiguration(cb => cb.WithOptions(o => { }))
            .AddMessaging()
            .AddLogging(builder => builder
                .AddConsole()
                .ThrowOn(LogLevel.Error))
            .AddTransient<InvocationBuilder>()
            .AddSingleton<CoercionProvider>()
            .AddSingleton<ElmFactory>()
            .AddSingleton<ILibraryProvider, MemoryLibraryProvider>()
            .AddScoped<CqlToElmConverter>();
    }

}