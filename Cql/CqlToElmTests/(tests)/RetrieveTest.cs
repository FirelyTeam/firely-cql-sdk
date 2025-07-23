/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class RetrieveTest : Base
    {
        [TestMethod]
        public async Task Retrieve_AllTerms()
        {
            var cqlToolkit = CreateCqlToolkit();
            var cqlLibraryString = CqlLibraryString.Parse("""
                                                          library RetrieveTest version '1.0.0'

                                                          using FHIR version '4.0.1'

                                                          valueset "terminology": 'http://fire.ly/ValueSet/Test'

                                                          context Patient

                                                          define private Retrieve_AllTerms: [Patient->Condition: code in "terminology"]
                                                          """);
            var library = cqlToolkit.MakeLibrary(cqlLibraryString.Cql);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(2, library.statements.Length);
            Assert.IsNotNull(library.statements[1].expression.localId);
            Assert.IsNotNull(library.statements[1].expression.locator);
            Assert.IsInstanceOfType(library.statements[1].expression, typeof(Retrieve));
            {
                var retrieve = (Retrieve)library.statements[1].expression;
                Assert.IsNotNull(retrieve.context);
                Assert.IsInstanceOfType(retrieve.context, typeof(ExpressionRef));
                {
                    var contextRef = (ExpressionRef)retrieve.context;
                    Assert.AreEqual("Patient", contextRef.name);
                }
                Assert.AreEqual("{http://hl7.org/fhir}Condition", retrieve.dataType?.Name);
                Assert.AreEqual("http://hl7.org/fhir/StructureDefinition/Condition", retrieve.templateId);
                Assert.AreEqual("code", retrieve.codeProperty);
                Assert.AreEqual("in", retrieve.codeComparator);
                Assert.IsNotNull(retrieve.codes);
                Assert.IsInstanceOfType(retrieve.codes, typeof(ValueSetRef));
                {
                    var valueSetRef = (ValueSetRef)retrieve.codes;
                    Assert.AreEqual("terminology", valueSetRef.name);
                }

                var valueSets = await (new[]
                                          {
                                              new ValueSet
                                              {
                                                  Id = "http://fire.ly/ValueSet/Test",
                                                  Url = "http://fire.ly/ValueSet/Test",
                                                  Expansion = new ValueSet.ExpansionComponent
                                                  {
                                                      Contains = new List<ValueSet.ContainsComponent>
                                                      {
                                                          new ValueSet.ContainsComponent
                                                          {
                                                              Code = "code1",
                                                              System = "http://fire.ly/CodeSystem/Test"
                                                          }
                                                      }
                                                  }
                                              }
                                          }.ToValueSetDictionaryAsync());

                var bundle = new Bundle
                {
                    Entry = new List<Bundle.EntryComponent>
                    {
                        new Bundle.EntryComponent
                        {
                            Resource = new Condition
                            {
                                Id = "1"
                            }
                        },
                        new Bundle.EntryComponent
                        {
                            Resource = new Condition
                            {
                                Id = "2",
                                Code = new CodeableConcept
                                {
                                    Coding = new List<Coding>
                                    {
                                        new Coding { Code = "code1", System = "http://fire.ly/CodeSystem/Test" }
                                    }
                                }
                            }
                        }
                    }
                };

                using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();
                var result = librarySetInvoker.InvokeLibraryDefinition(
                    FhirCqlContext.ForBundle(bundle, valueSets: valueSets),
                    cqlLibraryString.LibraryIdentifier, "Retrieve_AllTerms");
                var conditions = result as IEnumerable<Condition>;
                Assert.IsNotNull(conditions);
                var ids = conditions.Select(c => c.Id).ToArray();
                Assert.AreEqual(1, ids.Length);
                Assert.AreEqual("2", ids[0]);
            }
        }


        [TestMethod]
        public void Retrieve_FilteredByCode()
        {
            var cqlToolkit = CreateCqlToolkit();
            var cqlLibraryString = CqlLibraryString.Parse("""
                                                          library FilteredRetrieve version '1.0.0'

                                                          using FHIR version '4.0.1'
                                                          codesystem LOINC: 'http://loinc.org'
                                                          code "Body height": '8302-2' from LOINC

                                                          define "Body height observations":
                                                              [Observation: "Body height"]
                                                          """);
            var lib = cqlToolkit.MakeLibrary(cqlLibraryString.Cql);

            var r = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Retrieve>();
            r.Should().NotBeNull();

            Assert.AreEqual(1, lib.codeSystems.Length);
            Assert.AreEqual(1, lib.codes.Length);
            Assert.AreEqual(1, lib.statements.Length);
            Assert.IsInstanceOfType(lib.statements[0].expression, typeof(Retrieve));

            var retrieve = (Retrieve)lib.statements[0].expression;
            Assert.AreEqual("code", retrieve.codeProperty);
            Assert.AreEqual("~", retrieve.codeComparator);
            Assert.IsNotNull(retrieve.codes);
            Assert.IsInstanceOfType(retrieve.codes, typeof(ToList));

            var toList = (ToList)retrieve.codes;
            Assert.IsInstanceOfType(toList.operand, typeof(CodeRef));

            var codeRef = (CodeRef)toList.operand;
            Assert.AreEqual("Body height", codeRef.name);

            using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();

            var bundle = new Bundle
            {
                Entry = new List<Bundle.EntryComponent>
                {
                    new Bundle.EntryComponent
                    {
                        Resource = new Observation
                        {
                            Id = "1",
                            Code = new CodeableConcept
                            {
                                Coding = new List<Coding>
                                {
                                    new Coding { Code = "8302-2", System = "http://loinc.org" }
                                }
                            }
                        }
                    },
                    new Bundle.EntryComponent
                    {
                        Resource = new Observation
                        {
                            Id = "2",
                            Code = new CodeableConcept
                            {
                                Coding = new List<Coding>
                                {
                                    new Coding { Code = "29463-7", System = "http://loinc.org" }
                                }
                            }
                        }
                    }
                }
            };

            var result = librarySetInvoker.InvokeLibraryDefinition(
                FhirCqlContext.ForBundle(bundle),
                cqlLibraryString.LibraryIdentifier, "Body height observations");

            result.Should().NotBeNull();
            Assert.IsInstanceOfType(result, typeof(IEnumerable<Observation>));
            var observations = (IEnumerable<Observation>)result;
            Assert.AreEqual(1, observations.Count());
        }
    }
}
