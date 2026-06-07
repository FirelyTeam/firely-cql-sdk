#nullable enable
using System.Linq;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class ReproTests
{
    private static readonly ElmToolkitConfig ElmToolkitConfig = new ElmToolkitConfig();

    private static string DescribeTupleness(object? r)
    {
        if (r is null) return "null";
        var t = r.GetType();
        if (t.IsArray) t = t.GetElementType()!;
        var underlying = System.Nullable.GetUnderlyingType(t);
        return $"type={t.Name}, isCqlValueTuple={Hl7.Cql.Primitives.TypeExtensions.IsCqlValueTuple(t)}, underlyingIsCqlValueTuple={(underlying!=null ? Hl7.Cql.Primitives.TypeExtensions.IsCqlValueTuple(underlying).ToString() : "n/a")}";
    }

    private static void Dump(string name, object? r)
    {
        System.Console.WriteLine($"=== {name} ===");
        System.Console.WriteLine("TYPE: " + (r?.GetType().FullName ?? "null"));
        if (r is System.Collections.IEnumerable en && r is not string)
        {
            int i = 0;
            foreach (var item in en)
            { System.Console.WriteLine($"ITEM[{i++}]: " + (item?.GetType().Name ?? "null") + " => " + item); }
            System.Console.WriteLine("COUNT: " + i);
        }
        else System.Console.WriteLine("SCALAR: " + r);
    }

    [TestMethod]
    public void ReproFromConcept()
    {
        var cql = (CqlLibraryString)"""
            library Test version '1.0.0'

            codesystem "CS": 'http://example.org/cs'
            code "ExampleCode": 'ex' from "CS" display 'Example'
            concept "ExampleConcept": { "ExampleCode" } display 'ExampleConcept'

            define "FromConcept":
              ({ 1 }) X return Tuple { key: "ExampleConcept" }

            define "FromString":
              ({ 1 }) X return Tuple { key: 'ExampleConcept' }

            define "DirectTuple":
              Tuple { key: "ExampleConcept" }

            define "ListLiteralTuple":
              { Tuple { key: "ExampleConcept" } }

            define "FromConceptNoReturn":
              ({ Tuple { key: "ExampleConcept" } }) X
            """;

        var ctx = FhirCqlContext.ForBundle();
        using var librarySetInvoker =
            new CqlToolkit()
                .AddCqlLibraries(cql)
                .CreateLibrarySetInvoker(ElmToolkitConfig);

        var results = librarySetInvoker
                     .SelectExpressionsForLibrary(CqlVersionedLibraryIdentifier.Parse("Test-1.0.0"))
                     .SelectResults(ctx)
                     .ToDictionary(t => t.definitionInvoker.DefinitionName);

        foreach (var kv in results)
            Dump(kv.Key, kv.Value.invocationResult);

        var opts = new System.Text.Json.JsonSerializerOptions();
        opts.Converters.Add(new Hl7.Cql.Runtime.Serialization.CqlValueTupleJsonConverterFactory());
        foreach (var kv in results)
        {
            string json;
            try { json = System.Text.Json.JsonSerializer.Serialize(kv.Value.invocationResult, opts); }
            catch (System.Exception ex) { json = "EXC: " + ex.GetType().Name + ": " + ex.Message; }
            System.Console.WriteLine($"JSON {kv.Key}: {json}");
            System.Console.WriteLine($"IsCqlValueTuple(elemType?) {kv.Key}: {DescribeTupleness(kv.Value.invocationResult)}");
        }
    }
}
