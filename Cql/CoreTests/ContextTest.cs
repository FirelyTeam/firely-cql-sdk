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
using Hl7.Cql.CodeGeneration.NET;
using Microsoft.CodeAnalysis;
using System.Reflection;
using DefinitionDictionaryExtensions = Hl7.Cql.Runtime.DefinitionDictionaryExtensions;

namespace CoreTests
{
    [TestClass]
    public class ContextTest
    {
        private static readonly TypeResolver TypeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        private static readonly TypeConverter TypeConverter = FhirTypeConverter.Create(ModelInfo.ModelInspector);
        private static DefinitionDictionary<Delegate> Definitions;
        private static Dictionary<string, MemoryStream> SourceCodeStreams = new Dictionary<string, MemoryStream>();
        private static HashValueSetDictionary ValueSets;
        private static string SourceCode;
        private const string ContextLibrary = "Context_AG-1.0.0";
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\Context_AG-1.0.0.json");
            var library = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var lf = LoggerFactory
                .Create(logging => logging.AddDebug());
               
            var eb = ExpressionBuilder.ForSingleLibrary(binding, typeManager, library, 
                lf.CreateLogger<ExpressionBuilder>());
            var expressions = eb.Build();

            Definitions = expressions
                .CompileAll();

            var scw = new CSharpSourceCodeWriter(lf.CreateLogger<CSharpSourceCodeWriter>());
            SourceCodeStreams[library.NameAndVersion] = new MemoryStream();
            scw.Write(expressions, 
                Enumerable.Empty<Type>(), 
                expressions.SingleLibraryGraph(), 
                key => SourceCodeStreams[key],
                closeStream: false);
            var stream = SourceCodeStreams[ContextLibrary];
            stream.Position = 0;
            var sr = new StreamReader(stream);
            SourceCode = sr.ReadToEnd();


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
            var result = (bool?)Definitions.Invoke(ContextLibrary, "In Initial Population", ctx, patient);
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
            object arg1 = patients[0];
            var result = (bool?)Definitions.Invoke(ContextLibrary, "In Initial Population", ctx, arg1)!;
            ctx.Operators.DataSource.SetRetrieveContext(patients[3]);
            object arg2 = patients[0];
            result = (bool?)Definitions.Invoke(ContextLibrary, "In Initial Population", ctx, arg2)!;
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Context_Unfiltered_to_Patient()
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
            var result = (int?)Definitions.Invoke(ContextLibrary, "Initial Population Count 1", ctx)!;
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Context_Unfiltered_to_Patient_List()
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
            var result = (int?)Definitions.Invoke(ContextLibrary, "Initial Population Count 2", ctx)!;
            Assert.AreEqual(3, result);
        }
    }
}
