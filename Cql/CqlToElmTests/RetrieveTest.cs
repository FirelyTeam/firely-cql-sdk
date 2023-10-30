using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class RetrieveTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Retrieve_AllTerms()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library RetrieveTest version '1.0.0'

                using FHIR version '4.0.1'

                valueset ""terminology"": 'http://fire.ly/ValueSet/Test'

                context Patient

                define private Retrieve_AllTerms: [Patient->Condition: code in ""terminology""]
            ");
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

                var valueSets = new[] {
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
                }.ToValueSetDictionary();

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
                                        new Coding { Code = "code1",  System = "http://fire.ly/CodeSystem/Test" }
                                    }
                                }
                            }
                        }
                    }
                };
                var result = Run(library,
                    (delegates) => FhirCqlContext.ForBundle(bundle, valueSets: valueSets, delegates: delegates),
                    "Retrieve_AllTerms");
                var conditions = result as IEnumerable<Condition>;
                Assert.IsNotNull(conditions);
                var ids = conditions.Select(c => c.Id).ToArray();
                Assert.AreEqual(1, ids.Length);
                Assert.AreEqual("2", ids[0]);
            }
        }

    }
}
