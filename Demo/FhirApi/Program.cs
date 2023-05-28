using Hl7.Cql.Poco.Fhir.R4;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Microsoft.Net.Http.Headers;
using System.Text;

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
                var @in = await FhirJson.DeserializeAsync<Parameters>(httpContext.Request.Body);
                var result = LibraryHandler.Evaluate(@in);
                return result;
            })
            .WithName("CPGLibraryEvaluate");

            app.Run();
        }
    }
}