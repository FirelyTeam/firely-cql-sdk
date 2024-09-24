using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Logging;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.Logging;

namespace Measures.RR23.Test;

public class TestProgram
{
    public static void Main()
    {
        // To run this:
        // 1. Set this project as the startup project
        // 2. Open the Intermediate Window in Visual Studio (View > Other Windows > C# Interactive)
        // 3. Type Measures.RR23.Test.TestRunner.Main() and press Enter

        new TestProgram().Run();
    }

    private void Run()
    {
        /*
           ReadEmbeddedJson("RR23_QM_Umbrella_Measure"),
           ReadEmbeddedJson("RR23_EX_Amy_Johnson_transaction"),
           ReadEmbeddedJson("RR23_EX_erin_p_supper_transaction"),
           ReadEmbeddedJson("RR23_EX_pete_w_amadillo_no_supply_transaction"),
           ReadEmbeddedJson("RR23_EX_wile_e_coyote_falling_rock_transaction"),
         */
        string dir = """C:\Dev\Vonk\test\Vonk.Plugin.Cql.Tests\Resources-RR23\""";

        Bundle bundle = LoadBundle(
            new FileInfo($"""{dir}RR23_EX_wile_e_coyote_falling_rock_transaction.json""")
            );

        List<ValueSet> valueSetsList = LoadValueSets(
            new FileInfo($"""{dir}RR23_TX_Injury_due_to_falling_rock_diagnosis_codes.json"""),
            new FileInfo($"""{dir}RR23_TX_RoadRunner_Syndrome_Diagnosis_codes.json""")
            );
        IValueSetDictionary valueSets = valueSetsList.ToValueSetDictionary();

        Dictionary<string, object> parameters = new()
        {
            { "Measurement period", CqlDateTimeIntervalForYear(2023) },
        };

        DateTimeOffset? now = null;

        CqlContext cqlContext = FhirCqlContext.ForBundle(
            bundle,
            parameters,
            valueSets,
            now);

        ILoggerFactory loggerFactory = LoggerFactory.Create(loggingBuilder =>
        {
            loggingBuilder.AddConsole();
        });
        ILogger<CqlContext> cqlContextLogger = loggerFactory.CreateLogger<CqlContext>();
        cqlContext.AddMessageLogging(cqlContextLogger);

        RR23_1_0_0 rr23 = new(cqlContext);
        bool? denominator = rr23.Denominator();
        SupplyDelivery[] umbrellas = rr23.Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock().ToArray();
        bool? numerator= rr23.Numerator();
        bool? initialPopulation = rr23.Initial_Population();

        Trace.Assert(denominator == true, "denominator must be true");
        Trace.Assert(initialPopulation == true, "initialPopulation must be true");
        Trace.Assert(numerator == false, "numerator must be false");
        Trace.Assert(umbrellas is [], "umbrellas must be empty");

        // var results = rr23.GetType()!
        //     .GetMethods(BindingFlags.Instance | BindingFlags.Public)
        //     .Where(m => m.GetParameters() is [])
        //     .Where(m => m.GetCustomAttributes<CqlDeclarationAttribute>().Any())
        //     .Select(m => new { Name = m.Name, Type = m.ReturnType, Value = m.Invoke(rr23, []) })
        //     .ToList();
        //
        // var results2 = JsonSerializer.Serialize(
        //     results.ToDictionary(r => r.Name, r => r.Value),
        //     JsonSerializerOptions);
        // Console.WriteLine(results2);
    }

    private static string? ParameterComponentToString(object? value, Type fallbackType) =>
        value switch
        {
            null          => null,
            // FhirString s  => s?.ToString(),
            // FhirBoolean b => b?.ToString(),
            // Integer i     => i?.ToString(),
            // Coding c      => $"{c.Code} ({c.System})",
            // Period p      => $"{p.Start} .. {p.End}",
            var v         => $"{v} : {fallbackType.Name}"
        };

    protected static readonly JsonSerializerOptions JsonSerializerOptions =
        new JsonSerializerOptions(){ WriteIndented = true }
            .ForFhir(new FhirJsonPocoDeserializerSettings
            {
                Validator = null
            });

    private static Bundle LoadBundle(FileInfo file)
    {
        using FileStream fs = file.OpenRead();
        return JsonSerializer.Deserialize<Bundle>(fs, JsonSerializerOptions)
               ?? throw new InvalidOperationException($"{file.FullName} is not a bundle");

    }

    protected static CqlInterval<CqlDateTime> CqlDateTimeIntervalForYear(int year) =>
        new CqlInterval<CqlDateTime>(
            CqlDateTime(year, 1, 1),
            CqlDateTime(year, 12, 31),
            true,
            true);

    private static CqlDateTime CqlDateTime(int year, int month, int day) =>
        new(year, month, day, default, default, default, default, default, default);

    private List<ValueSet> LoadValueSets(params FileInfo[] files)
    {
        List<ValueSet> valueSets = new();

        foreach (FileInfo file in files)
        {
            using FileStream fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
            Resource resource = JsonSerializer.Deserialize<Resource>(fs, JsonSerializerOptions)
                                ?? throw new InvalidOperationException($"{file.FullName} is not a Resource");
            switch (resource)
            {
                case ValueSet valueSet:
                    valueSets.Add(valueSet);
                    break;
                case Bundle bundle:
                    valueSets.AddRange(bundle.Entry.Select(e => e.Resource).OfType<ValueSet>());
                    break;
                default:
                    throw new InvalidOperationException($"{file.FullName} is not a ValueSet or Bundle");
            }
        }

        return valueSets;
    }
}
