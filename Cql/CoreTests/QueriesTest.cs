using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ncqa.Cql.MeasureCompiler;
using Ncqa.Cql.Runtime.FhirR4;
using Ncqa.Elm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncqa.Cql.Runtime;
using Ncqa.Fhir.R4.Model;
using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Fhir.R4;

namespace CoreTests
{
    [TestClass]
    public class QueriesTest
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            var binding = new FhirOperatorsBinding(FhirTypeConverter.Default, FhirTypeResolver.Default);
            var typeManager = new TypeManager(FhirTypeResolver.Default);
            var elm = new FileInfo(@"Input\ELM\QueriesTest-1.0.0.json");
            var elmPackage = ElmPackage.LoadFrom(elm);
            var logger = LoggerFactory
                .Create(logging => logging.AddDebug())
                .CreateLogger<ExpressionBuilder>();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
            Definitions = expressions
                .CompileAll();
            ValueSets = new CqlValueSetDictionary();
            ValueSets.Add("http://hl7.org/fhir/ValueSet/example-expansion",
                new CqlCode("code", "system", null, null));

        }

        private static DefinitionDictionary<Delegate> Definitions;
        private const string LibraryName = "QueriesTest-1.0.0";
        private static IValueSetDictionary ValueSets;
        private const string TestCodeSystem = "https://www.ncqa.org/fhir/codesystem/test-cs";
        private static readonly CqlCode[] TestCodes = new CqlCode[]
        {
            new CqlCode("1", TestCodeSystem, null, null),
            new CqlCode("2", TestCodeSystem, null, null),
            new CqlCode("3", TestCodeSystem, null, null),

        };

        private FhirRuntimeContext Context(Bundle bundle) =>
            new FhirRuntimeContext(bundle,
                Definitions,
                ValueSets,
                new Dictionary<string, object>(),
                DateTimeOffset.UtcNow);

        [TestMethod]
        public void Simple_Retrieve()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);

            var result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Simple retrieve", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            ctx = Context(bundle);
            result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Simple retrieve", ctx);
            Assert.AreEqual(1, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            ctx = Context(bundle);
            result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Simple retrieve", ctx);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void Simple_Retrieve_with_ValueSet()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);

            var result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with ValueSet", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            ctx = Context(bundle);
            result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with ValueSet", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs1",
                    code = new CodeableConcept
                    {
                        coding = new []
                        {
                            new Coding { code = "code", system = "system" }
                        }
                    }
                }
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs2",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "bad code", system = "system" }
                        }
                    }
                }
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs3",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "code", system = "bad system" }
                        }
                    }
                }
            });
            ctx = Context(bundle);
            var resultArray = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with ValueSet", ctx)
                .ToArray();
            
            Assert.AreEqual(1, resultArray.Length);
            Assert.AreEqual("obs1", resultArray[0].id.value);

        }

        [TestMethod]
        public void Query_source_using_define()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);

            var result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Query source using define", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            ctx = Context(bundle);
            result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Query source using define", ctx);
            Assert.AreEqual(1, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            ctx = Context(bundle);
            result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Query source using define", ctx);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void Retrieve_with_inline_list_of_codes()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);

            var result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with inline list of codes", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            ctx = Context(bundle);
            result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with inline list of codes", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs1",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "1", system = TestCodeSystem }
                        }
                    }
                }
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs2",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "bad code", system = "system" }
                        }
                    }
                }
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs3",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "code", system = "bad system" }
                        }
                    }
                }
            });
            ctx = Context(bundle);
            var resultArray = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with inline list of codes", ctx)
                .ToArray();

            Assert.AreEqual(1, resultArray.Length);
            Assert.AreEqual("obs1", resultArray[0].id.value);
        }

        [TestMethod]
        public void Retrieve_with_list_of_codes_and_code_path()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);

            var result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with list of codes and code path", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            ctx = Context(bundle);
            result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with list of codes and code path", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs1",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "1", system = TestCodeSystem }
                        }
                    }
                }
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs2",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "bad code", system = "system" }
                        }
                    }
                }
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs3",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "code", system = "bad system" }
                        }
                    }
                }
            });
            ctx = Context(bundle);
            var resultArray = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with list of codes and code path", ctx)
                .ToArray();

            Assert.AreEqual(1, resultArray.Length);
            Assert.AreEqual("obs1", resultArray[0].id.value);
        }

        [TestMethod]
        public void Retrieve_with_inline_list_of_codes_and_code_path()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);

            var result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with inline list of codes and code path", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
            });
            ctx = Context(bundle);
            result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with inline list of codes and code path", ctx);
            Assert.AreEqual(0, result.Count());

            bundle = new Bundle()
            {
                entry = new R4EntryCollection()
                {
                }
            };
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs1",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "1", system = TestCodeSystem }
                        }
                    }
                }
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs2",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "bad code", system = "system" }
                        }
                    }
                }
            });
            bundle.entry.Add(new Bundle.EntryComponent
            {
                resource = new Observation()
                {
                    id = "obs3",
                    code = new CodeableConcept
                    {
                        coding = new[]
                        {
                            new Coding { code = "code", system = "bad system" }
                        }
                    }
                }
            });
            ctx = Context(bundle);
            var resultArray = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with inline list of codes and code path", ctx)
                .ToArray();

            Assert.AreEqual(1, resultArray.Length);
            Assert.AreEqual("obs1", resultArray[0].id.value);
        }

        [TestMethod]
        public void Retrieve_with_null_query_source()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);
            var result = Definitions.Invoke<IEnumerable<Observation>>(LibraryName, "Retrieve with null query source", ctx);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Retrieve_with_empty_query_source()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);
            // type of the query source is List<Any>
            var result = Definitions.Invoke<IEnumerable<object>>(LibraryName, "Retrieve with empty query source", ctx);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void Retrieve_with_all_null_query_source()
        {
            var bundle = new Bundle();
            var ctx = Context(bundle);
            // type of the query source is List<Any>
            var result = Definitions.Invoke<IEnumerable<object>>(LibraryName, "Retrieve with all null query source", ctx);
            Assert.AreEqual(3, result.Count());
        }
    }
}
