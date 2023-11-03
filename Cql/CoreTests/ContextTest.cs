using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Cql.Operators;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CoreTests
{
    [TestClass]
    public class ContextTest
    {
        private static readonly TypeResolver TypeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        private static readonly TypeConverter TypeConverter = FhirTypeConverter.Create(ModelInfo.ModelInspector);
        private static DefinitionDictionary<Delegate> Definitions;
        private static HashValueSetDictionary ValueSets;
        private const string ContextLibrary = "Context_AG-1.0.0";
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\Context_AG-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var logger = LoggerFactory
                .Create(logging => logging.AddDebug())
                .CreateLogger<ExpressionBuilder>();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
            Definitions = expressions
                .CompileAll();
            ValueSets = new HashValueSetDictionary();
            ValueSets.Add("http://hl7.org/fhir/ValueSet/example-expansion",
                new CqlCode("code", "system", null, null));
        }


        [TestMethod]
        public void Context_AutomaticContext()
        {
            var bundle = new Bundle();
            var patient = new Patient
            {
                BirthDate = "1995-01-01"
            };
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = patient
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Encounter { },
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Encounter { },
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Encounter { },
            });

            var ctx = FhirCqlContext.ForBundle(bundle, delegates: Definitions);
            // since only 1 patient in bundle, context automatically set
            var patientContext = ctx.Operators.DataSource.GetRetrieveContext<Patient>();
            Assert.IsNotNull(patientContext);
            Assert.AreSame(patient, patientContext);
            var encounterCountext = ctx.Operators.DataSource.GetRetrieveContext<Encounter>();
            Assert.IsNull(encounterCountext);
            var result = Definitions.Invoke<bool?>(ContextLibrary, "InInitialPopulation", ctx);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Context_SetPatientRetrieveContext()
        {
            var bundle = new Bundle();
            var patients = new[] {
                new Patient
                {
                    BirthDate = "1995-01-01"
                },
                new Patient
                {
                    BirthDate = "1996-01-01"
                },
                new Patient
                {
                    BirthDate = "1997-01-01"
                },
                new Patient
                {
                    BirthDate = "2002-01-01"
                }
            };
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = patients[0],
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = patients[1],
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = patients[2],
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = patients[3],
            });

            var ctx = FhirCqlContext.ForBundle(bundle, delegates: Definitions);
            ctx.Operators.DataSource.SetRetrieveContext(patients[0]);
            var result = Definitions.Invoke<bool?>(ContextLibrary, "InInitialPopulation", ctx);
            ctx.Operators.DataSource.SetRetrieveContext(patients[3]);
            result = Definitions.Invoke<bool?>(ContextLibrary, "InInitialPopulation", ctx);
            Assert.AreEqual(false, result);
        }

    }

}
