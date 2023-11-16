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
            var result = Definitions.Invoke<bool?>(ContextLibrary, "InInitialPopulation", ctx, patient);
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
            var result = Definitions.Invoke<bool?>(ContextLibrary, "InInitialPopulation", ctx, patients[0]);
            ctx.Operators.DataSource.SetRetrieveContext(patients[3]);
            result = Definitions.Invoke<bool?>(ContextLibrary, "InInitialPopulation", ctx, patients[0]);
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void Context_Unfiltered()
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
            var measure = new Context_AG_1_0_0(ctx);
            var count = measure.InitialPopulationCount();
            Assert.AreEqual(3, count);
            var result = Definitions.Invoke<int?>(ContextLibrary, "InitialPopulationCount", ctx);
            Assert.AreEqual(3, result);
        }




        [System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
        [CqlLibrary("Context_AG", "1.0.0")]
        public class Context_AG_1_0_0
        {


            internal CqlContext context;

            #region Cached values

            internal Lazy<int?> __InitialPopulationCount;

            #endregion
            public Context_AG_1_0_0(CqlContext context)
            {
                this.context = context ?? throw new ArgumentNullException("context");


                __InitialPopulationCount = new Lazy<int?>(() => InitialPopulationCount_Value());
            }
            #region Dependencies


            #endregion

            [CqlDeclaration("InInitialPopulation")]
            public bool? InInitialPopulation(Patient retrieveContext)
            {
                Patient a_()
                {
                    if ((retrieveContext != null))
                    {
                        return retrieveContext;
                    }
                    else
                    {
                        CqlValueSet f_ = null;
                        PropertyInfo g_ = null;
                        var h_ = context.Operators.RetrieveByValueSet<Patient>(f_, g_);
                        var i_ = context.Operators.SingleOrNull<Patient>(h_);

                        return i_;
                    };
                };
                var b_ = context.Operators.Convert<CqlDate>(a_()?.BirthDateElement?.Value);
                var c_ = context.Operators.Date((int?)2013, (int?)1, (int?)1);
                var d_ = context.Operators.CalculateAgeAt(b_, c_, "year");
                var e_ = context.Operators.GreaterOrEqual(d_, (int?)16);

                return e_;
            }

            private int? InitialPopulationCount_Value() =>
                context.Operators.CountOrNull<bool?>(context.Operators.WhereOrNull<bool?>(context.Operators.SelectOrNull<Patient, bool?>(context.Operators.RetrieveByValueSet<Patient>(null, null), (Patient retrieveContext) =>
                                this.InInitialPopulation(retrieveContext)), (bool? IP) =>
                            context.Operators.IsTrue(IP)));

            [CqlDeclaration("InitialPopulationCount")]
            public int? InitialPopulationCount() =>
                __InitialPopulationCount.Value;

        }

    }

}
