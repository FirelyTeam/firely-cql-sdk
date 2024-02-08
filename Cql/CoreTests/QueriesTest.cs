using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace CoreTests
{
    [TestClass]
    public class QueriesTest
    {
        private static readonly TypeResolver TypeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
        private static readonly TypeConverter TypeConverter = FhirTypeConverter.Create(ModelInfo.ModelInspector);

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\QueriesTest-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var logger = LoggerFactory
                .Create(logging => logging.AddDebug())
                .CreateLogger<ExpressionBuilder>();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            ExpressionBuilder.LibraryDefinitionsBuilder lib1 = new(eb);
            var definitions = lib1.Build();
            QueriesDefinitions = definitions
                .CompileAll();
            ValueSets = new HashValueSetDictionary();
            ValueSets.Add("http://hl7.org/fhir/ValueSet/example-expansion",
                new CqlCode("code", "system", null, null));


            elm = new FileInfo(@"Input\ELM\Test\Aggregates-1.0.0.json");
            elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            ExpressionBuilder.LibraryDefinitionsBuilder lib = new(eb);
            definitions = lib.Build();
            AggregatesDefinitions = definitions.CompileAll();

        }

        private static DefinitionDictionary<Delegate> QueriesDefinitions;
        private static DefinitionDictionary<Delegate> AggregatesDefinitions;

        private const string QueriesLibrary = "QueriesTest-1.0.0";
        private const string AggregatesLibrary = "Aggregates-1.0.0";

        private static HashValueSetDictionary ValueSets;
        private const string TestCodeSystem = "https://www.ncqa.org/fhir/codesystem/test-cs";
        private static readonly CqlCode[] TestCodes = new CqlCode[]
        {
            new CqlCode("1", TestCodeSystem, null, null),
            new CqlCode("2", TestCodeSystem, null, null),
            new CqlCode("3", TestCodeSystem, null, null),

        };

        private CqlContext GetNewContext(Bundle bundle) => FhirCqlContext.ForBundle(
            bundle: bundle,
            valueSets: ValueSets,
            delegates: QueriesDefinitions);


        [TestMethod]
        public void Simple_Retrieve()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);

            var result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Simple retrieve", ctx);
            Assert.AreEqual(0, result.Count());

            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            ctx = GetNewContext(bundle);
            result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Simple retrieve", ctx);
            Assert.AreEqual(1, result.Count());

            bundle = new Bundle();
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            ctx = GetNewContext(bundle);
            result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Simple retrieve", ctx);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void Simple_Retrieve_with_ValueSet()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);

            var result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with ValueSet", ctx);
            Assert.AreEqual(0, result.Count());

            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            ctx = GetNewContext(bundle);
            result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with ValueSet", ctx);
            Assert.AreEqual(0, result.Count());

            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs1",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "code", System = "system" }
                        }
                    }
                }
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs2",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "bad code", System = "system" }
                        }
                    }
                }
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs3",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "code", System = "bad system" }
                        }
                    }
                }
            });
            ctx = GetNewContext(bundle);
            var resultArray = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with ValueSet", ctx)
                .ToArray();

            Assert.AreEqual(1, resultArray.Length);
            Assert.AreEqual("obs1", resultArray[0].Id);

        }

        [TestMethod]
        public void Query_source_using_define()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);

            var result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Query source using define", ctx);
            Assert.AreEqual(0, result.Count());

            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            ctx = GetNewContext(bundle);
            result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Query source using define", ctx);
            Assert.AreEqual(1, result.Count());

            bundle = new Bundle();
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            ctx = GetNewContext(bundle);
            result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Query source using define", ctx);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void Retrieve_with_inline_list_of_codes()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);

            var result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with inline list of codes", ctx);
            Assert.AreEqual(0, result.Count());
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            ctx = GetNewContext(bundle);
            result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with inline list of codes", ctx);
            Assert.AreEqual(0, result.Count());
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs1",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "1", System = TestCodeSystem }
                        }
                    }
                }
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs2",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "bad code", System = "system" }
                        }
                    }
                }
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs3",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "code", System = "bad system" }
                        }
                    }
                }
            });
            ctx = GetNewContext(bundle);
            var resultArray = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with inline list of codes", ctx)
                .ToArray();

            Assert.AreEqual(1, resultArray.Length);
            Assert.AreEqual("obs1", resultArray[0].Id);
        }

        [TestMethod]
        public void Retrieve_with_list_of_codes_and_code_path()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);

            var result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with list of codes and code path", ctx);
            Assert.AreEqual(0, result.Count());
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            ctx = GetNewContext(bundle);
            result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with list of codes and code path", ctx);
            Assert.AreEqual(0, result.Count());

            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs1",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "1", System = TestCodeSystem }
                        }
                    }
                }
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs2",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "bad code", System = "system" }
                        }
                    }
                }
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs3",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "code", System = "bad system" }
                        }
                    }
                }
            });
            ctx = GetNewContext(bundle);
            var resultArray = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with list of codes and code path", ctx)
                .ToArray();

            Assert.AreEqual(1, resultArray.Length);
            Assert.AreEqual("obs1", resultArray[0].Id);
        }

        [TestMethod]
        public void Retrieve_with_inline_list_of_codes_and_code_path()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);

            var result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with inline list of codes and code path", ctx);
            Assert.AreEqual(0, result.Count());
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
            });
            ctx = GetNewContext(bundle);
            result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with inline list of codes and code path", ctx);
            Assert.AreEqual(0, result.Count());

            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs1",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "1", System = TestCodeSystem }
                        }
                    }
                }
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs2",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "bad code", System = "system" }
                        }
                    }
                }
            });
            bundle.Entry.Add(new Bundle.EntryComponent
            {
                Resource = new Observation()
                {
                    Id = "obs3",
                    Code = new CodeableConcept
                    {
                        Coding = new List<Coding>
                        {
                            new Coding { Code = "code", System = "bad system" }
                        }
                    }
                }
            });
            ctx = GetNewContext(bundle);
            var resultArray = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with inline list of codes and code path", ctx)
                .ToArray();

            Assert.AreEqual(1, resultArray.Length);
            Assert.AreEqual("obs1", resultArray[0].Id);
        }

        [TestMethod]
        public void Retrieve_with_null_query_source()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);
            var result = QueriesDefinitions.Invoke<IEnumerable<Observation>>(QueriesLibrary, "Retrieve with null query source", ctx);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Retrieve_with_empty_query_source()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);
            // type of the query source is List<Any>
            var result = QueriesDefinitions.Invoke<IEnumerable<object>>(QueriesLibrary, "Retrieve with empty query source", ctx);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void Retrieve_with_all_null_query_source()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);
            // type of the query source is List<Any>
            var result = QueriesDefinitions.Invoke<IEnumerable<object>>(QueriesLibrary, "Retrieve with all null query source", ctx);
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void Aggregates_FactorialOfFive()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);
            var result = AggregatesDefinitions.Invoke<int?>(AggregatesLibrary, "FactorialOfFive", ctx);
            Assert.AreEqual(120, result.Value);
        }

        [TestMethod]
        public void Aggregates_With_where()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);
            var result = AggregatesDefinitions.Invoke<int?>(AggregatesLibrary, "With where", ctx);
            Assert.IsNotNull(result);
            Assert.AreEqual(6 * 4 * 2, result.Value);
        }


        [TestMethod]
        public void Aggregates_With_where_and_let()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);
            var result = AggregatesDefinitions.Invoke<int?>(AggregatesLibrary, "With where and let", ctx);
            Assert.IsNotNull(result);
            var expected = (6 + 1 + 2) * (4 + 1 + 2) * (2 + 1 + 2); // 315
            Assert.AreEqual(expected, result.Value);
        }

        [TestMethod]
        public void Aggregates_With_such_that()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);
            var result = AggregatesDefinitions.Invoke<int?>(AggregatesLibrary, "With such that", ctx);
            Assert.IsNotNull(result);
            Assert.AreEqual(24, result.Value);
        }


        [TestMethod]
        public void Aggregates_Multisource_query()
        {
            var bundle = new Bundle();
            var ctx = GetNewContext(bundle);
            var result = AggregatesDefinitions.Invoke<int?>(AggregatesLibrary, "Multisource query", ctx);
            Assert.AreEqual(12, result);
        }
    }
}
