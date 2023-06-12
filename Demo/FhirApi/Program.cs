using Microsoft.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Hl7.Fhir.Model;
using Hl7.Cql.Firely;

namespace FhirApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<ILibraryHandler, SimpleLibraryHandler>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapGet("/Library/$evaluate", async (HttpContext httpContext) =>
            {
                var @in = await httpContext.Request.Body.ParseFhirAsync<Parameters>();
                var handler = app.Services.GetRequiredService<ILibraryHandler>();
                var result = handler.Evaluate(@in);
                return result;
            })
            .WithName("CPGLibraryEvaluate");

            app.Run();
        }
    }
}