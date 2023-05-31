using Hl7.Cql.Operators;
using Hl7.Cql.Conversion;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System;
using System.Collections.Generic;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Elm;
using System.IO;
using Hl7.Cql.Compiler;
using Hl7.Cql.Poco.Fhir.R4;
using System.Linq;

namespace Hl7.Cql.Runtime.FhirR4
{
    public static class FhirRuntimeContext
    {
        public static RuntimeContext Create(Bundle? bundle = null, 
            IDictionary<string,object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null)
        {
            valueSets ??= new HashValueSetDictionary();
            var unitConverter = new UnitConverter();
            IDataRetriever dataRetriever = bundle != null
                ? new BundleDataRetriever(bundle, FhirTypeResolver.Default, valueSets)
                : new CompositeDataRetriever();

            var operators = CqlOperators.Create(FhirTypeResolver.Default,
                FhirTypeConverter.Default,
                dataRetriever,
                null,
                valueSets,
                null,
                new DateTimeIso8601(now ?? DateTimeOffset.UtcNow, DateTimePrecision.Millisecond));
            var ctx = new RuntimeContext(operators, delegates, parameters);
            return ctx;
        }

        /// <summary>
        /// Runs a single library.
        /// </summary>
        /// <param name="elmDirectory">The location of the ELM library packages, which must include the named library and all its dependencies.</param>
        /// <param name="name">The library's identifier.</param>
        /// <param name="version">The library's version.</param>
        /// <param name="rtx">The runtime context.</param>
        /// <returns>A dictionary of the values of the <code>define</code>s in the named library.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static IDictionary<string, object?> Run(DirectoryInfo elmDirectory,
            string name, string version,
            RuntimeContext rtx)
        {
            var elmPackages = new List<ElmPackage>();
            foreach (var file in new DirectoryInfo("Resources").GetFiles("*.json"))
            {
                using var fs = file.OpenRead();
                var resource = FhirJson.Deserialize<Resource>(fs);
                if (resource is Hl7.Cql.Poco.Fhir.R4.Model.Library lib)
                {
                    var attachment = lib.content
                        .SingleOrDefault(att =>
                            System.Text.Json.Nodes.JsonNode.Parse($"\"{att.contentType.value}\"")!.ToString()
                                == "application/elm+json");
                    if (attachment != null)
                    {
                        var bytes = attachment.data.Decode();
                        using var ms = new MemoryStream(bytes);
                        var package = ElmPackage.LoadFrom(ms)
                            ?? throw new InvalidOperationException($"Library {lib.id} does not have a valid elm attachment");
                        elmPackages.Add(package);
                    }
                }
            }
            var result = RunOnce(elmPackages, name, version, rtx);
            return result;
        }
        public static IDictionary<string, object?> RunOnce(IEnumerable<ElmPackage> packages,
            string name, string version,
            RuntimeContext rtx)
        {
            var binding = new CqlOperatorsBinding(FhirTypeResolver.Default,
                           FhirTypeConverter.Default);
            var compiler = new AssemblyCompiler(FhirTypeResolver.Default,
                operatorBinding: binding);
            var asmContext = compiler.Load(packages);
            var results = asmContext.Run(name, version, rtx);
            return results;
        }
    }
}
