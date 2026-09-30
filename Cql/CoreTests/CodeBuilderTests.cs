/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable disable

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Internal;
using Hl7.Fhir.Model;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.CodeModel;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime.Hosting;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests
{
    [TestClass]
    public class LibraryCodeBuilderTests
    {
        private static ServiceProvider BuildServiceProvider() => ElmToolkitServices.AddCqlCompilerServices(new ServiceCollection().AddDebugLogging()).BuildServiceProvider(validateScopes: true);

        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
            var elm = new FileInfo(Path.Combine("Input", "ELM", "Test", "Aggregates-1.0.0.json"));
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryCodeBuilder>().ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void FHIRConversionTest_1_0_0()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
            var elm = new FileInfo(Path.Combine("Input", "ELM", "HL7", "FHIRConversionTest.json"));
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryCodeBuilder>().ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
            var elm = new FileInfo(Path.Combine("Input", "ELM", "Test", "QueriesTest-1.0.0.json"));
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryCodeBuilder>().ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        // https://github.com/FirelyTeam/firely-cql-sdk/issues/129
        [TestMethod]
        public void Medication_Request_Example_Test()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
            FileInfo[] files =
            [
                new(Path.Combine("Input", "ELM", "Test", "Medication_Request_Example.json")),
                new(Path.Combine("Input", "ELM", "Libs", "FHIRHelpers-4.0.1.json"))
            ];
            var librarySet = new LibrarySet();
            librarySet.LoadLibraries(files);

            var librarySetCodeBuilder = servicesScope.ServiceProvider.GetRequiredService<LibrarySetCodeBuilder>();
            var definitions = librarySetCodeBuilder.ProcessLibrarySet(librarySet);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void ObservationStatus_Test()
        {
            // Arrange
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();

            var libraryString = CqlLibraryString.Parse("""
               library CreateObservation version '1.0.0'

               using FHIR version '4.0.1'

               define newObservation:
                   Observation {
                       status: FHIR.ObservationStatus { value: 'final' }
                   }
               """);
            var elmLibrary = CreateElmLibrary(libraryString);

            // Act
            var definitions = servicesScope.ServiceProvider
                                           .GetRequiredService<LibraryCodeBuilder>()
                                           .ProcessLibrary(elmLibrary);
            // Assert
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());

            var result = InvokeLibrary(elmLibrary, "newObservation");
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType<Observation>(result);
            var observation = (Observation)result;
            Assert.AreEqual(ObservationStatus.Final, observation.Status);
        }

        [TestMethod]
        public void AdministrativeGender_Test()
        {
            // Arrange
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();

            var libraryString = CqlLibraryString.Parse("""
               library CreatePatient version '1.0.0'

               using FHIR version '4.0.1'

               define newPatient:
                   Patient {
                       gender: FHIR.AdministrativeGender { value: 'female' }
                   }
               """);
            var elmLibrary = CreateElmLibrary(libraryString);

            // Act
            var definitions = servicesScope.ServiceProvider
                                           .GetRequiredService<LibraryCodeBuilder>()
                                           .ProcessLibrary(elmLibrary);
            // Assert
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());

            var result = InvokeLibrary(elmLibrary, "newPatient");
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType<Patient>(result);
            var patient = (Patient)result;
            Assert.AreEqual(AdministrativeGender.Female, patient.Gender);
        }

        [TestMethod]
        public void Concept_To_CodeableConcept_Test()
        {
            // Arrange
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();

            var libraryString = CqlLibraryString.Parse("""
               library ConceptToCodeableConcept version '1.0.0'

               using FHIR version '4.0.1'

               codesystem "Example": 'http://example.org'

               code "ExampleCode": '123' from "Example" display 'Example display'

               concept "ExampleConcept": { "ExampleCode" } display 'Concept display'

               define ConceptAsCodeableConcept:
                   "ExampleConcept" as FHIR.CodeableConcept
               """);
            var elmLibrary = CreateElmLibrary(libraryString);

            // Act - building the library exercises the CqlConcept -> CodeableConcept conversion
            var definitions = servicesScope.ServiceProvider
                                           .GetRequiredService<LibraryCodeBuilder>()
                                           .ProcessLibrary(elmLibrary);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());

            // Assert - running it yields a CodeableConcept carrying the concept's codes and display
            var result = InvokeLibrary(elmLibrary, "ConceptAsCodeableConcept");
            Assert.IsInstanceOfType<CodeableConcept>(result);
            var codeableConcept = (CodeableConcept)result;
            Assert.AreEqual("Concept display", codeableConcept.Text);
            Assert.AreEqual(1, codeableConcept.Coding.Count);
            Assert.AreEqual("123", codeableConcept.Coding[0].Code);
            Assert.AreEqual("http://example.org", codeableConcept.Coding[0].System);
        }

        [TestMethod]
        public void Coalesce_WithNullsAndList_ReturnsFirstNonNullList()
        {
            // Arrange
            var libraryString = CqlLibraryString.Parse("""
                library CoalesceTest version '1.0.0'

                define CoalesceLastList: Coalesce(null, null, {'a'})
                """);
            var elmLibrary = CreateElmLibrary(libraryString);

            // Act
            var result = InvokeLibrary(elmLibrary, "CoalesceLastList");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType<IEnumerable<string>>(result);
            var list = ((IEnumerable<string>)result).ToList();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("a", list[0]);
        }

        [TestMethod]
        public void Long_0_Greater_10_Returns_False()
        {
            // Arrange
            var libraryString = CqlLibraryString.Parse("""
                library LongGreaterTest version '1.0.0'

                define Long_0_Greater_10: 0L > 10L
                """);
            var elmLibrary = CreateElmLibrary(libraryString);

            // Act
            var result = InvokeLibrary(elmLibrary, "Long_0_Greater_10");

            // Assert - "0L > 10L" should return false, not null
            Assert.AreEqual(false, (bool?)result);
        }

        [TestMethod]
        public void ChoiceType_WithSingleDistinctType_CollapsesToThatType()
        {
            // ELM produced by some translators contains choice types whose alternatives are all the
            // same type, e.g. Choice<Condition, Condition> (see CMS125 "Right Mastectomy Diagnosis").
            // Such a choice should keep the strong type instead of falling back to object.
            var definitions = ProcessLibraryWithChoiceResult(
                new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                    new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "Condition"),
                    new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "Condition")));

            var (_, lambda) = definitions.SelectDefinitionsByLibraryName("ChoiceTypeTest-1.0.0").Single();
            Assert.AreEqual(typeof(IEnumerable<Condition>), lambda.ReturnType);
        }

        [TestMethod]
        public void Interval_WithChoiceTypedOperands_AnchorsPointType()
        {
            // Mirrors CMS1173 (issue #1350): the interval's ELM point type is
            // Choice<DateTime, Interval<DateTime>> (e.g. resulting from FHIRHelpers.ToValue)
            // and the operands are choice-typed, i.e. object in C#. With no type to anchor
            // overload resolution on, the binder used to pick Interval(CqlDate, ...)
            // arbitrarily and emit casts that threw InvalidCastException at runtime.
            var choiceType = new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                new Hl7.Cql.Elm.NamedTypeSpecifier("urn:hl7-org:elm-types:r1", "DateTime"),
                new Hl7.Cql.Elm.IntervalTypeSpecifier
                {
                    pointType = new Hl7.Cql.Elm.NamedTypeSpecifier("urn:hl7-org:elm-types:r1", "DateTime"),
                });

            Hl7.Cql.Elm.Expression AsChoice() =>
                new Hl7.Cql.Elm.As { asTypeSpecifier = choiceType, operand = new Hl7.Cql.Elm.Now() };

            var elmLibrary = new Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "ChoiceIntervalTest", version = "1.0.0" },
                schemaIdentifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                usings =
                [
                    new Hl7.Cql.Elm.UsingDef { localIdentifier = "FHIR", uri = "http://hl7.org/fhir", version = "4.0.1" },
                ],
                statements =
                [
                    new Hl7.Cql.Elm.ExpressionDef
                    {
                        name = "ChoiceInterval",
                        context = "Patient",
                        expression = new Hl7.Cql.Elm.Interval
                        {
                            low = AsChoice(),
                            high = AsChoice(),
                            lowClosed = true,
                            highClosed = true,
                            resultTypeSpecifier = new Hl7.Cql.Elm.IntervalTypeSpecifier { pointType = choiceType },
                        },
                    },
                ],
            };

            var result = InvokeLibrary(elmLibrary, "ChoiceInterval");

            Assert.IsInstanceOfType<Hl7.Cql.Primitives.CqlInterval<object>>(result);
            var interval = (Hl7.Cql.Primitives.CqlInterval<object>)result;
            Assert.IsInstanceOfType<Hl7.Cql.Primitives.CqlDateTime>(interval.low);
            Assert.IsInstanceOfType<Hl7.Cql.Primitives.CqlDateTime>(interval.high);
        }

        [TestMethod]
        public void Interval_WithChoiceTypedOperandAndNonNullableOperand_AnchorsNullablePointType()
        {
            // The point type anchored on the other operand can be a non-nullable value type:
            // NegateLiteral translates Negate(2147483648) to an int-typed constant, not int?,
            // and an ELM node without a result type of its own is not converted afterwards.
            // 'as int' is not legal C# (CodeCast rejects it), so the anchored type has to be
            // lifted to int? before the choice-typed operand is converted.
            var integerChoiceType = new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                Hl7.Cql.Elm.SystemTypes.IntegerType,
                new Hl7.Cql.Elm.IntervalTypeSpecifier { pointType = Hl7.Cql.Elm.SystemTypes.IntegerType });

            var elmLibrary = new Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "ChoiceIntervalIntTest", version = "1.0.0" },
                schemaIdentifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                usings =
                [
                    new Hl7.Cql.Elm.UsingDef { localIdentifier = "FHIR", uri = "http://hl7.org/fhir", version = "4.0.1" },
                ],
                statements =
                [
                    new Hl7.Cql.Elm.ExpressionDef
                    {
                        name = "ChoiceIntervalWithIntLow",
                        context = "Patient",
                        expression = new Hl7.Cql.Elm.Interval
                        {
                            low = new Hl7.Cql.Elm.Negate
                            {
                                operand = new Hl7.Cql.Elm.Literal
                                {
                                    value = "2147483648",
                                    valueType = Hl7.Cql.Elm.SystemTypes.IntegerType.name,
                                    resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name,
                                },
                            },
                            high = new Hl7.Cql.Elm.As
                            {
                                asTypeSpecifier = integerChoiceType,
                                operand = new Hl7.Cql.Elm.Literal
                                {
                                    value = "5",
                                    valueType = Hl7.Cql.Elm.SystemTypes.IntegerType.name,
                                    resultTypeSpecifier = Hl7.Cql.Elm.SystemTypes.IntegerType,
                                    resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name,
                                },
                                resultTypeSpecifier = integerChoiceType,
                            },
                            lowClosed = true,
                            highClosed = true,
                            resultTypeSpecifier = new Hl7.Cql.Elm.IntervalTypeSpecifier { pointType = integerChoiceType },
                        },
                    },
                ],
            };

            var result = InvokeLibrary(elmLibrary, "ChoiceIntervalWithIntLow");

            Assert.IsInstanceOfType<Hl7.Cql.Primitives.CqlInterval<object>>(result);
            var interval = (Hl7.Cql.Primitives.CqlInterval<object>)result;
            Assert.AreEqual(int.MinValue, interval.low);
            Assert.AreEqual(5, interval.high);
        }

        [TestMethod]
        public void ChoiceType_WithDifferentTypes_MapsToObject()
        {
            var definitions = ProcessLibraryWithChoiceResult(
                new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                    new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "Condition"),
                    new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "Observation")));

            var (_, lambda) = definitions.SelectDefinitionsByLibraryName("ChoiceTypeTest-1.0.0").Single();
            Assert.AreEqual(typeof(IEnumerable<object>), lambda.ReturnType);
        }

        [TestMethod]
        public void Union_OfCompatibleTuplesWithDifferentElementTypes_KeepsAllElements()
        {
            // Regression test for https://github.com/FirelyTeam/firely-cql-sdk/issues/1354:
            // a union of two structurally compatible tuple lists whose element types differ
            // (here FHIR.dateTime vs System.DateTime) was bound as
            // Union<object>(left as IEnumerable<object>, right as IEnumerable<object>).
            // The C# code generator lowers the compiler-generated tuple types to value
            // tuples, for which IEnumerable<T> covariance does not apply, so both casts
            // yielded null at runtime and the whole define silently evaluated to empty.
            var stringType = new Hl7.Cql.Elm.NamedTypeSpecifier("urn:hl7-org:elm-types:r1", "String");
            var dateTimeType = new Hl7.Cql.Elm.NamedTypeSpecifier("urn:hl7-org:elm-types:r1", "DateTime");
            var fhirDateTimeType = new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "dateTime");

            Hl7.Cql.Elm.TupleTypeSpecifier TupleTypeWith(Hl7.Cql.Elm.TypeSpecifier whenType) => new()
            {
                element =
                [
                    new Hl7.Cql.Elm.TupleElementDefinition { name = "id", elementType = stringType },
                    new Hl7.Cql.Elm.TupleElementDefinition { name = "when", elementType = whenType },
                ],
            };

            Hl7.Cql.Elm.List TupleListWith(string id, Hl7.Cql.Elm.TypeSpecifier whenType)
            {
                var tupleType = TupleTypeWith(whenType);
                return new Hl7.Cql.Elm.List
                {
                    resultTypeSpecifier = new Hl7.Cql.Elm.ListTypeSpecifier { elementType = tupleType },
                    element =
                    [
                        new Hl7.Cql.Elm.Tuple
                        {
                            resultTypeSpecifier = tupleType,
                            element =
                            [
                                new Hl7.Cql.Elm.TupleElement
                                {
                                    name = "id",
                                    value = new Hl7.Cql.Elm.Literal
                                    {
                                        value = id,
                                        valueType = new System.Xml.XmlQualifiedName("{urn:hl7-org:elm-types:r1}String"),
                                        resultTypeSpecifier = stringType,
                                    },
                                },
                                new Hl7.Cql.Elm.TupleElement
                                {
                                    name = "when",
                                    value = new Hl7.Cql.Elm.Null { resultTypeSpecifier = whenType },
                                },
                            ],
                        },
                    ],
                };
            }

            var elmLibrary = new Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "TupleUnionTest", version = "1.0.0" },
                schemaIdentifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                usings =
                [
                    new Hl7.Cql.Elm.UsingDef { localIdentifier = "FHIR", uri = "http://hl7.org/fhir", version = "4.0.1" },
                ],
                statements =
                [
                    new Hl7.Cql.Elm.ExpressionDef
                    {
                        name = "MixedTupleUnion",
                        context = "Unfiltered",
                        expression = new Hl7.Cql.Elm.Union
                        {
                            resultTypeSpecifier = new Hl7.Cql.Elm.ListTypeSpecifier { elementType = TupleTypeWith(dateTimeType) },
                            operand =
                            [
                                TupleListWith("a", fhirDateTimeType),
                                TupleListWith("b", dateTimeType),
                            ],
                        },
                    },
                ],
            };

            var result = InvokeLibrary(elmLibrary, "MixedTupleUnion");

            Assert.IsNotNull(result, "The union of two compatible tuple lists must not evaluate to null.");
            var items = ((System.Collections.IEnumerable)result).Cast<object>().Where(item => item is not null).ToList();
            Assert.AreEqual(2, items.Count);

            // Both elements must have been converted to a single tuple type whose second
            // item is the id; the generated code represents tuples as value tuples.
            var ids = items
                      .Select(item => item.GetType().GetField("Item2")?.GetValue(item) as string
                                      ?? item.GetType().GetProperty("id")?.GetValue(item) as string)
                      .OrderBy(id => id)
                      .ToList();
            CollectionAssert.AreEqual(new List<string> { "a", "b" }, ids);
        }

        [TestMethod]
        public void ScopedProperty_QualifiedPathOnTypedAlias_BindsEverySegmentStatically()
        {
            // The MADiE translator emits a scoped Property whose path is qualified and carries no
            // result type, e.g. M.id.value inside a query over [Medication]. Every segment is known
            // on the alias's static type, so the path binds as a typed member chain: no late binding.
            var elmLibrary = QualifiedPathLibrary("QualifiedPathTypedAlias", "Medication", "id.value");

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            StringAssert.Contains(cSharp, "IdElement");

            var bundle = BundleOf(new Medication { Id = "med-1" });
            CollectionAssert.AreEqual(new[] { "med-1" }, ((System.Collections.IEnumerable)invoke(bundle)).Cast<object>().ToList());
        }

        [TestMethod]
        public void ScopedProperty_QualifiedPathAcrossChoiceElement_DispatchesOnTheModelsAlternatives()
        {
            // MR.medication.reference.value: 'medication' is a FHIR choice element, statically
            // DataType. The ELM carries no type for the read, so the alternatives come from the
            // model (CodeableConcept | Reference); only Reference has 'reference', so the read is
            // a single typed branch and the result is a plain string. No late binding remains.
            var elmLibrary = QualifiedPathLibrary("QualifiedPathChoiceElement", "MedicationRequest", "medication.reference.value");

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "ResourceReference"), cSharp);
            StringAssert.Contains(cSharp, "ReferenceElement");
            StringAssert.Contains(cSharp, "IEnumerable<string>");

            var bundle = BundleOf(
                new MedicationRequest { Id = "mr-1", Medication = new ResourceReference("Medication/med-1") },
                new MedicationRequest { Id = "mr-2", Medication = new CodeableConcept("http://example.org", "coded") });
            CollectionAssert.AreEqual(
                new object[] { "Medication/med-1", null },
                ((System.Collections.IEnumerable)invoke(bundle)).Cast<object>().ToList(),
                "a reference resolves to its string; a coded medication has no reference and yields null");
        }

        [TestMethod]
        public void Property_OnUnionAlias_DispatchesOnTheAlternativesThatHaveTheElement()
        {
            // [Procedure] union [ServiceRequest] is Choice<Procedure, ServiceRequest>; only
            // ServiceRequest has authoredOn. The read is a single typed branch, null for a
            // Procedure, and the ELM's DateTime result type converts the FHIR dateTime per branch.
            var union = new Hl7.Cql.Elm.Union
            {
                operand = [RetrieveOf("Procedure"), RetrieveOf("ServiceRequest")],
                resultTypeSpecifier = new Hl7.Cql.Elm.ListTypeSpecifier
                {
                    elementType = new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                        new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "Procedure"),
                        new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "ServiceRequest")),
                },
            };
            var authoredOnValue = new Hl7.Cql.Elm.Property
            {
                path = "value",
                resultTypeSpecifier = new Hl7.Cql.Elm.NamedTypeSpecifier("urn:hl7-org:elm-types:r1", "DateTime"),
                source = new Hl7.Cql.Elm.Property { path = "authoredOn", scope = "R" },
            };
            var elmLibrary = QueryLibrary("UnionAliasDispatch", union, authoredOnValue);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "ServiceRequest"), cSharp);
            StringAssert.Contains(cSharp, "AuthoredOnElement");
            StringAssert.Contains(cSharp, "IEnumerable<CqlDateTime>");

            var bundle = BundleOf(
                new Procedure { Id = "p-1", Status = EventStatus.Completed, Subject = new ResourceReference("Patient/1") },
                new ServiceRequest
                {
                    Id = "sr-1",
                    Status = RequestStatus.Completed,
                    Intent = RequestIntent.Order,
                    Subject = new ResourceReference("Patient/1"),
                    AuthoredOnElement = new FhirDateTime("2026-01-15T10:00:00Z"),
                });
            var values = ((System.Collections.IEnumerable)invoke(bundle)).Cast<object>().ToList();
            Assert.AreEqual(2, values.Count);
            Assert.IsTrue(values.Contains(null), "the Procedure has no authoredOn");
            var authoredOn = values.OfType<Hl7.Cql.Primitives.CqlDateTime>().Single();
            Assert.AreEqual(2026, authoredOn.Value.Year);
            Assert.AreEqual(15, authoredOn.Value.Day);
        }

        [TestMethod]
        public void Property_OnChoiceWithDifferentElementTypes_DispatchesToObject()
        {
            // Condition.onset is Age | Period | Range | dateTime | string per the model. Only Age,
            // dateTime and string have a value, and their value types differ, so the result is the
            // choice of those types - object - and alternatives without the element yield null.
            var onsetValue = new Hl7.Cql.Elm.Property
            {
                path = "value",
                source = new Hl7.Cql.Elm.Property { path = "onset", scope = "R" },
            };
            var elmLibrary = QueryLibrary("ChoiceValueDispatch", RetrieveOf("Condition"), onsetValue);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "Age"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirDateTime"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirString"), cSharp);
            Assert.AreEqual(0, ArmsTesting(cSharp, "Period"), "Period has no value element, so it gets no branch:\n" + cSharp);

            var bundle = BundleOf(
                new Condition { Id = "c-1", Subject = new ResourceReference("Patient/1"), Onset = new FhirDateTime("2026-02-01") },
                new Condition { Id = "c-2", Subject = new ResourceReference("Patient/1"), Onset = new Period { Start = "2026-01-01" } });
            var values = ((System.Collections.IEnumerable)invoke(bundle)).Cast<object>().ToList();
            Assert.AreEqual(2, values.Count);
            Assert.AreEqual(1, values.Count(v => v is null), "an onset Period has no value");
            var onset = values.OfType<Hl7.Cql.Primitives.CqlDateTime>().Single();
            Assert.AreEqual(2026, onset.Value.Year, "the value of a dateTime is the System.DateTime the model declares");
        }

        [TestMethod]
        public void Property_OnChoiceOfPrimitives_ReadsEachValueAsTheTypeTheModelDeclares()
        {
            // Observation.effective is dateTime | Period | Timing | instant per the model. The model
            // declares the value of both dateTime and instant as a System.DateTime, so the element
            // types agree and the result is a CqlDateTime, although the .NET model holds a dateTime's
            // value as a string and an instant's as a DateTimeOffset.
            var effectiveValue = new Hl7.Cql.Elm.Property
            {
                path = "value",
                source = new Hl7.Cql.Elm.Property { path = "effective", scope = "R" },
            };
            var elmLibrary = QueryLibrary("PrimitiveValueDispatch", RetrieveOf("Observation"), effectiveValue);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            StringAssert.Contains(cSharp, "IEnumerable<CqlDateTime> Values(");
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirDateTime"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "Instant"), cSharp);

            var bundle = BundleOf(
                new Observation { Id = "o-1", Status = ObservationStatus.Final, Code = new CodeableConcept(), Subject = new ResourceReference("Patient/1"), Effective = new FhirDateTime("2026-02-01") },
                new Observation { Id = "o-2", Status = ObservationStatus.Final, Code = new CodeableConcept(), Subject = new ResourceReference("Patient/1"), Effective = new Instant(new DateTimeOffset(2026, 3, 4, 5, 6, 7, TimeSpan.Zero)) });
            var values = ((System.Collections.IEnumerable)invoke(bundle)).Cast<Hl7.Cql.Primitives.CqlDateTime>().ToList();
            CollectionAssert.AreEquivalent(new[] { 2, 3 }, values.Select(v => v.Value.Month).ToArray());
        }

        [TestMethod]
        public void Property_OnQiCoreExtensionValue_IsTheSystemDateTimeTheProfileDeclares()
        {
            // The translator's rendering of QI-Core's ProcedureNotDone.recorded: the value's value
            // of the qicore-recorded extension, typed QICore.NotDoneRecorded, which QI-Core declares
            // as a System.DateTime. The read itself carries no result type; its consumer (here an
            // As, in the corpus the operator it feeds) takes it as a NotDoneRecorded.
            const string recordedUrl = "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded";
            var recorded = new Hl7.Cql.Elm.SingletonFrom
            {
                resultTypeName = new System.Xml.XmlQualifiedName("NotDoneRecorded", "http://hl7.org/fhir"),
                operand = new Hl7.Cql.Elm.Query
                {
                    source =
                    [
                        new Hl7.Cql.Elm.AliasedQuerySource
                        {
                            alias = "$this",
                            expression = new Hl7.Cql.Elm.Property { path = "extension", source = new Hl7.Cql.Elm.AliasRef { name = "R" } },
                        },
                    ],
                    where = new Hl7.Cql.Elm.Equal
                    {
                        operand =
                        [
                            new Hl7.Cql.Elm.Property { path = "url", scope = "$this" },
                            new Hl7.Cql.Elm.Literal { valueType = Hl7.Cql.Elm.SystemTypes.StringType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.StringType.name, value = recordedUrl },
                        ],
                    },
                    @return = new Hl7.Cql.Elm.ReturnClause
                    {
                        distinct = false,
                        expression = new Hl7.Cql.Elm.Property { path = "value.value", source = new Hl7.Cql.Elm.AliasRef { name = "$this" } },
                    },
                },
            };
            var asRecorded = new Hl7.Cql.Elm.As
            {
                asTypeSpecifier = new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "NotDoneRecorded"),
                operand = recorded,
            };
            var elmLibrary = QueryLibrary("QiCoreRecorded", RetrieveOf("Procedure"), asRecorded);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            StringAssert.Contains(cSharp, "IEnumerable<CqlDateTime> Values(");
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirDateTime"), cSharp);

            var procedure = new Procedure { Id = "p-1", Status = EventStatus.NotDone, Subject = new ResourceReference("Patient/1") };
            procedure.Extension.Add(new Extension(recordedUrl, new FhirDateTime("2026-04-05T06:07:08Z")));
            var value = ((System.Collections.IEnumerable)invoke(BundleOf(procedure))).Cast<Hl7.Cql.Primitives.CqlDateTime>().Single();
            Assert.AreEqual(4, value.Value.Month);
            Assert.AreEqual(5, value.Value.Day);
        }

        [TestMethod]
        public void Property_OnOpenChoice_SharesOneArmBetweenAlternativesThatReadTheElementAlike()
        {
            // Extension.value is an open value[x]. Its string-valued primitives all read their value
            // through IValue<string>, its integers through one integer interface, and Age, Count,
            // Distance and Duration inherit Quantity's value, so each group shares one arm. Date also
            // implements IValue<string> but reads as a CqlDate, so it keeps its own arm, tested first.
            var extensionValues = new Hl7.Cql.Elm.Query
            {
                source =
                [
                    new Hl7.Cql.Elm.AliasedQuerySource
                    {
                        alias = "$this",
                        expression = new Hl7.Cql.Elm.Property { path = "extension", source = new Hl7.Cql.Elm.AliasRef { name = "R" } },
                    },
                ],
                @return = new Hl7.Cql.Elm.ReturnClause
                {
                    distinct = false,
                    expression = new Hl7.Cql.Elm.Property { path = "value.value", source = new Hl7.Cql.Elm.AliasRef { name = "$this" } },
                },
            };
            var elmLibrary = QueryLibrary("OpenChoiceValues", RetrieveOf("Patient"), extensionValues);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "IValue<string>"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "Quantity"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "Date"), cSharp);
            foreach (var merged in new[] { "Oid", "Uuid", "FhirString", "Code", "Integer", "PositiveInt", "Age", "Duration" })
                Assert.AreEqual(0, ArmsTesting(cSharp, merged), $"{merged} shares an arm:\n" + cSharp);
            Assert.IsTrue(cSharp.IndexOf(" Date ", StringComparison.Ordinal) < cSharp.IndexOf("IValue<string> ", StringComparison.Ordinal),
                "Date is an IValue<string> too, so its arm must come first:\n" + cSharp);

            var patient = new Patient { Id = "1" };
            patient.Extension.Add(new Extension("http://example.org/oid", new Oid("urn:oid:1.2.3")));
            patient.Extension.Add(new Extension("http://example.org/integer", new PositiveInt(5)));
            patient.Extension.Add(new Extension("http://example.org/age", new Age { Value = 3, Unit = "a" }));
            patient.Extension.Add(new Extension("http://example.org/date", new Date("2026-01-02")));
            var values = ((System.Collections.IEnumerable)((System.Collections.IEnumerable)invoke(BundleOf(patient))).Cast<object>().Single()).Cast<object>().ToList();

            Assert.AreEqual("urn:oid:1.2.3", values[0]);
            Assert.AreEqual(5, values[1]);
            Assert.AreEqual(3m, ((FhirDecimal)values[2]).Value, "Quantity.value is a FHIR.decimal element");
            Assert.AreEqual(2, ((Hl7.Cql.Primitives.CqlDate)values[3]).Value.Day);
        }

        [TestMethod]
        public void Case_OfIsTestsOnAnAlias_NarrowsTheAliasInEachBranch()
        {
            // from ([Condition] X return X.onset) R return case when R is Age then R.value
            // when R is dateTime then R.value when R is Period then R as Period else null end.
            // Within each branch R is known to be the tested type, so its value binds statically
            // and the as-cast is the narrowed value itself: one type switch, no dispatch inside it.
            var r = new Hl7.Cql.Elm.AliasRef { name = "R" };
            var narrowing = new Hl7.Cql.Elm.Case
            {
                caseItem =
                [
                    new Hl7.Cql.Elm.CaseItem { when = IsOf(r, "Age"), then = new Hl7.Cql.Elm.Property { path = "value", scope = "R" } },
                    new Hl7.Cql.Elm.CaseItem { when = IsOf(r, "dateTime"), then = new Hl7.Cql.Elm.Property { path = "value", scope = "R" } },
                    new Hl7.Cql.Elm.CaseItem { when = IsOf(r, "Period"), then = new Hl7.Cql.Elm.As { operand = r, asTypeSpecifier = new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "Period") } },
                ],
                @else = new Hl7.Cql.Elm.Null { resultTypeName = Hl7.Cql.Elm.SystemTypes.AnyType.name },
            };
            var elmLibrary = QueryLibrary("NarrowedCase", OnsetsOfConditions(), narrowing);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, SwitchExpressionsIn(cSharp), "one type switch over R, nothing dispatched inside it:\n" + cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "Age"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirDateTime"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "Period"), cSharp);
            Assert.IsFalse(cSharp.Contains(" as Period") || cSharp.Contains(" as Age"), "an as-cast of the narrowed value is the value itself:\n" + cSharp);

            var period = new Period { Start = "2026-01-01" };
            var values = ((System.Collections.IEnumerable)invoke(BundleOf(
                new Condition { Id = "c-1", Subject = new ResourceReference("Patient/1"), Onset = new Age { Value = 3, Unit = "a" } },
                new Condition { Id = "c-2", Subject = new ResourceReference("Patient/1"), Onset = new FhirDateTime("2026-02-01") },
                new Condition { Id = "c-3", Subject = new ResourceReference("Patient/1"), Onset = period },
                new Condition { Id = "c-4", Subject = new ResourceReference("Patient/1"), Onset = new FhirString("childhood") }))).Cast<object>().ToList();

            Assert.AreEqual(3m, ((FhirDecimal)values[0]).Value);
            Assert.AreEqual(2, ((Hl7.Cql.Primitives.CqlDateTime)values[1]).Value.Month);
            Assert.AreSame(period, values[2]);
            Assert.IsNull(values[3], "a string onset matches no branch");
        }

        [TestMethod]
        public void If_OnAnIsTestOfAnAlias_NarrowsTheAliasInTheThenBranch()
        {
            // ... return if R is Age then R.value else null: one arm, as a conditional over a
            // declaration pattern, and R.value is Age's value rather than a dispatch.
            var r = new Hl7.Cql.Elm.AliasRef { name = "R" };
            var narrowing = new Hl7.Cql.Elm.If
            {
                condition = IsOf(r, "Age"),
                then = new Hl7.Cql.Elm.Property { path = "value", scope = "R" },
                @else = new Hl7.Cql.Elm.Null { resultTypeSpecifier = new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "decimal") },
            };
            var elmLibrary = QueryLibrary("NarrowedIf", OnsetsOfConditions(), narrowing);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "Age"), cSharp);
            Assert.AreEqual(0, SwitchExpressionsIn(cSharp), "R.value on the narrowed R is not dispatched:\n" + cSharp);

            var values = ((System.Collections.IEnumerable)invoke(BundleOf(
                new Condition { Id = "c-1", Subject = new ResourceReference("Patient/1"), Onset = new Age { Value = 3, Unit = "a" } },
                new Condition { Id = "c-2", Subject = new ResourceReference("Patient/1"), Onset = new FhirDateTime("2026-02-01") }))).Cast<object>().ToList();

            Assert.AreEqual(3m, ((FhirDecimal)values[0]).Value);
            Assert.IsNull(values[1]);
        }

        [TestMethod]
        public void Case_WithAConditionOtherThanAnIsTest_NarrowsOnlyTheLeadingIsTests()
        {
            // case when R is Age then R.value when true then 'reached' when R is dateTime then ...
            // A branch after the unrelated condition is reached only once every earlier test failed,
            // which says nothing about R's type, so only the first branch narrows.
            var r = new Hl7.Cql.Elm.AliasRef { name = "R" };
            var mixed = new Hl7.Cql.Elm.Case
            {
                caseItem =
                [
                    new Hl7.Cql.Elm.CaseItem { when = IsOf(r, "Age"), then = new Hl7.Cql.Elm.Property { path = "value", scope = "R" } },
                    new Hl7.Cql.Elm.CaseItem
                    {
                        when = new Hl7.Cql.Elm.Literal { valueType = Hl7.Cql.Elm.SystemTypes.BooleanType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.BooleanType.name, value = "true" },
                        then = new Hl7.Cql.Elm.Literal { valueType = Hl7.Cql.Elm.SystemTypes.StringType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.StringType.name, value = "reached" },
                    },
                    new Hl7.Cql.Elm.CaseItem { when = IsOf(r, "dateTime"), then = new Hl7.Cql.Elm.Property { path = "value", scope = "R" } },
                ],
                @else = new Hl7.Cql.Elm.Null { resultTypeName = Hl7.Cql.Elm.SystemTypes.AnyType.name },
            };
            var elmLibrary = QueryLibrary("PartlyNarrowedCase", OnsetsOfConditions(), mixed);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, System.Text.RegularExpressions.Regex.Matches(cSharp, @"\bis Age \w+\)").Count, "the leading Is test narrows:\n" + cSharp);
            Assert.AreEqual(0, System.Text.RegularExpressions.Regex.Matches(cSharp, @"\bis FhirDateTime \w+\)").Count,
                "the Is test after the unrelated condition is an ordinary condition:\n" + cSharp);

            var values = ((System.Collections.IEnumerable)invoke(BundleOf(
                new Condition { Id = "c-1", Subject = new ResourceReference("Patient/1"), Onset = new Age { Value = 3, Unit = "a" } },
                new Condition { Id = "c-2", Subject = new ResourceReference("Patient/1"), Onset = new FhirDateTime("2026-02-01") }))).Cast<object>().ToList();

            Assert.AreEqual(3m, ((FhirDecimal)values[0]).Value);
            Assert.AreEqual("reached", values[1], "the unrelated condition is tested before the later Is test");
        }

        [TestMethod]
        public void Case_OfIsTestsOnAFunctionOperand_NarrowsTheOperandInEachBranch()
        {
            // The QICoreCommon toInterval shape: a choice-typed function operand, tested with is and
            // read with an explicit as. The translator types the operand reference as the choice, and
            // the narrowed operand must keep its narrowed type through that. The second branch casts
            // to the other alternative, which always yields null; it compiles on the un-narrowed
            // operand, as without narrowing.
            var libraryString = CqlLibraryString.Parse("""
               library NarrowedOperand version '1.0.0'

               using FHIR version '4.0.1'

               context Patient

               define function RecordedOf(E Choice<FHIR.Condition, FHIR.AllergyIntolerance>):
                 case
                   when E is FHIR.Condition then (E as FHIR.Condition).recordedDate
                   when E is FHIR.AllergyIntolerance then (E as FHIR.Condition).recordedDate
                   else null
                 end

               define "Recorded Dates": [Condition] C return RecordedOf(C)
               """);
            var elmLibrary = CreateElmLibrary(libraryString);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Recorded Dates");

            Assert.AreEqual(1, ArmsTesting(cSharp, "Condition"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "AllergyIntolerance"), cSharp);
            Assert.AreEqual(1, System.Text.RegularExpressions.Regex.Matches(cSharp, @"\bE as Condition\b").Count,
                "only the cast to the other alternative remains, on the un-narrowed operand:\n" + cSharp);
            Assert.IsFalse(System.Text.RegularExpressions.Regex.IsMatch(cSharp, @"\w+_ as Condition"), "no cast of a narrowed variable:\n" + cSharp);

            var recorded = ((System.Collections.IEnumerable)invoke(BundleOf(
                new Condition { Id = "c-1", Subject = new ResourceReference("Patient/1"), RecordedDateElement = new FhirDateTime("2026-03-04") }))).Cast<object>().Single();
            Assert.IsNotNull(recorded, "a Condition's recorded date is read off the narrowed operand");
        }

        [TestMethod]
        public void As_OverAnAsOfANarrowedOperand_CastsTheUnnarrowedOperand()
        {
            // A translator may wrap a reference in an as of its own (CMS145 has
            // (Event as Condition) as Choice<Condition, Condition>). The inner as is the narrowed
            // variable itself; the outer one, to a type that variable cannot have, compiles on the
            // un-narrowed operand, since C# rejects the cast of the narrowed variable (CS0039).
            var libraryString = CqlLibraryString.Parse("""
               library NestedAs version '1.0.0'

               using FHIR version '4.0.1'

               context Patient

               define function RecordedOf(E Choice<FHIR.Condition, FHIR.AllergyIntolerance>):
                 case
                   when E is FHIR.AllergyIntolerance then ((E as FHIR.AllergyIntolerance) as FHIR.Condition).recordedDate
                   else null
                 end

               define "Recorded Dates": [AllergyIntolerance] A return RecordedOf(A)
               """);
            var elmLibrary = CreateElmLibrary(libraryString);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Recorded Dates");

            Assert.AreEqual(1, ArmsTesting(cSharp, "AllergyIntolerance"), cSharp);
            Assert.AreEqual(1, System.Text.RegularExpressions.Regex.Matches(cSharp, @"\bE as Condition\b").Count,
                "the outer as compiles on the un-narrowed operand:\n" + cSharp);

            var recorded = ((System.Collections.IEnumerable)invoke(BundleOf(
                new AllergyIntolerance { Id = "a-1", Patient = new ResourceReference("Patient/1") }))).Cast<object>().Single();
            Assert.IsNull(recorded, "an AllergyIntolerance is no Condition");
        }

        [TestMethod]
        public void As_ToTheTypeTheOperandHas_EmitsNoCast()
        {
            // The QICoreCommon toInterval shape: within the branch for Interval<Quantity>, the low of
            // the narrowed choice already is a Quantity, so an as Quantity on it is the value itself.
            var libraryString = CqlLibraryString.Parse("""
               library IdentityAs version '1.0.0'

               using FHIR version '4.0.1'

               context Patient

               define function LowOf(choice Choice<System.Quantity, Interval<System.Quantity>>):
                 case
                   when choice is Interval<System.Quantity> then (choice as Interval<System.Quantity>).low as System.Quantity
                   else null
                 end

               define "Low": LowOf(Interval[1 'mg', 2 'mg'])
               """);
            var elmLibrary = CreateElmLibrary(libraryString);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Low");

            Assert.AreEqual(1, ArmsTesting(cSharp, "CqlInterval<CqlQuantity>"), cSharp);
            Assert.IsFalse(cSharp.Contains(".low as CqlQuantity"), "the low of the narrowed interval already is a CqlQuantity:\n" + cSharp);

            var low = (Hl7.Cql.Primitives.CqlQuantity)invoke(BundleOf())!;
            Assert.AreEqual(1m, low.value);
            Assert.AreEqual("mg", low.unit);
        }

        [TestMethod]
        public void As_OfAChoiceTypedValueToTheTypeItHas_EmitsNoCast()
        {
            // from { Interval[1, 2], 5 } (as Choice<Interval<Integer>, Integer>) R
            // return if R is Interval<Integer> then R.low as Integer else null, with R.low typed as
            // the choice Choice<Integer, String>, as a MADiE translator types choice.low in
            // QICoreCommon. The low of the narrowed R is an int?, upcast to that choice; the as
            // undoes the upcast, so it is the value itself.
            var integerInterval = new Hl7.Cql.Elm.IntervalTypeSpecifier { pointType = Hl7.Cql.Elm.SystemTypes.IntegerType };
            var choice = new Hl7.Cql.Elm.ChoiceTypeSpecifier(integerInterval, Hl7.Cql.Elm.SystemTypes.IntegerType);
            Hl7.Cql.Elm.Literal Integer(string value) =>
                new() { valueType = Hl7.Cql.Elm.SystemTypes.IntegerType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name, value = value };
            var values = new Hl7.Cql.Elm.List
            {
                resultTypeSpecifier = new Hl7.Cql.Elm.ListTypeSpecifier { elementType = choice },
                element =
                [
                    new Hl7.Cql.Elm.As
                    {
                        asTypeSpecifier = choice,
                        resultTypeSpecifier = choice,
                        operand = new Hl7.Cql.Elm.Interval { low = Integer("1"), high = Integer("2"), lowClosed = true, highClosed = true, resultTypeSpecifier = integerInterval },
                    },
                    new Hl7.Cql.Elm.As { asTypeSpecifier = choice, resultTypeSpecifier = choice, operand = Integer("5") },
                ],
            };
            var r = new Hl7.Cql.Elm.AliasRef { name = "R" };
            var low = new Hl7.Cql.Elm.If
            {
                condition = new Hl7.Cql.Elm.Is { operand = r, isTypeSpecifier = integerInterval },
                then = new Hl7.Cql.Elm.As
                {
                    operand = new Hl7.Cql.Elm.Property
                    {
                        path = "low",
                        source = r,
                        resultTypeSpecifier = new Hl7.Cql.Elm.ChoiceTypeSpecifier(Hl7.Cql.Elm.SystemTypes.IntegerType, Hl7.Cql.Elm.SystemTypes.StringType),
                    },
                    asTypeSpecifier = Hl7.Cql.Elm.SystemTypes.IntegerType,
                    resultTypeSpecifier = Hl7.Cql.Elm.SystemTypes.IntegerType,
                },
                @else = new Hl7.Cql.Elm.Null { resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name },
            };
            var elmLibrary = QueryLibrary("UpcastAs", values, low);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "CqlInterval<int?>"), cSharp);
            Assert.IsFalse(cSharp.Contains(".low as int?"), "the low of the narrowed interval already is an int?:\n" + cSharp);

            var results = ((System.Collections.IEnumerable)invoke(BundleOf())).Cast<object>().ToList();
            CollectionAssert.AreEqual(new object[] { 1, null }, results);
        }

        [TestMethod]
        public void Case_WithAnIsTestAnEarlierOneCovers_DropsTheUnreachableBranch()
        {
            // case when R is Quantity then 'quantity' when R is Age then 'age' else null: an Age is a
            // Quantity, so the second branch can never be taken, and a switch arm for it would not
            // compile (CS8510).
            var r = new Hl7.Cql.Elm.AliasRef { name = "R" };
            Hl7.Cql.Elm.Literal Text(string value) =>
                new() { valueType = Hl7.Cql.Elm.SystemTypes.StringType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.StringType.name, value = value };
            var covered = new Hl7.Cql.Elm.Case
            {
                caseItem =
                [
                    new Hl7.Cql.Elm.CaseItem { when = IsOf(r, "Quantity"), then = Text("quantity") },
                    new Hl7.Cql.Elm.CaseItem { when = IsOf(r, "Age"), then = Text("age") },
                ],
                @else = new Hl7.Cql.Elm.Null { resultTypeName = Hl7.Cql.Elm.SystemTypes.StringType.name },
            };
            var elmLibrary = QueryLibrary("CoveredCase", OnsetsOfConditions(), covered);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "Quantity"), cSharp);
            Assert.AreEqual(0, ArmsTesting(cSharp, "Age"), "the branch an earlier test covers is dropped:\n" + cSharp);

            var values = ((System.Collections.IEnumerable)invoke(BundleOf(
                new Condition { Id = "c-1", Subject = new ResourceReference("Patient/1"), Onset = new Age { Value = 3, Unit = "a" } }))).Cast<object>().ToList();
            CollectionAssert.AreEqual(new object[] { "quantity" }, values);
        }

        [TestMethod]
        public void If_OnAnIsTestForAValueType_NarrowsToTheValue()
        {
            // from { 5, 'five' } (as Choice<Integer, String>) R return if R is Integer then R + 1 else null
            var choice = new Hl7.Cql.Elm.ChoiceTypeSpecifier(Hl7.Cql.Elm.SystemTypes.IntegerType, Hl7.Cql.Elm.SystemTypes.StringType);
            var values = new Hl7.Cql.Elm.List
            {
                resultTypeSpecifier = new Hl7.Cql.Elm.ListTypeSpecifier { elementType = choice },
                element =
                [
                    new Hl7.Cql.Elm.As { asTypeSpecifier = choice, resultTypeSpecifier = choice, operand = new Hl7.Cql.Elm.Literal { valueType = Hl7.Cql.Elm.SystemTypes.IntegerType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name, value = "5" } },
                    new Hl7.Cql.Elm.As { asTypeSpecifier = choice, resultTypeSpecifier = choice, operand = new Hl7.Cql.Elm.Literal { valueType = Hl7.Cql.Elm.SystemTypes.StringType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.StringType.name, value = "five" } },
                ],
            };
            var r = new Hl7.Cql.Elm.AliasRef { name = "R" };
            var plusOne = new Hl7.Cql.Elm.If
            {
                condition = new Hl7.Cql.Elm.Is { operand = r, isTypeSpecifier = Hl7.Cql.Elm.SystemTypes.IntegerType },
                then = new Hl7.Cql.Elm.Add
                {
                    resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name,
                    operand =
                    [
                        new Hl7.Cql.Elm.As { operand = r, asTypeSpecifier = Hl7.Cql.Elm.SystemTypes.IntegerType, resultTypeSpecifier = Hl7.Cql.Elm.SystemTypes.IntegerType },
                        new Hl7.Cql.Elm.Literal { valueType = Hl7.Cql.Elm.SystemTypes.IntegerType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name, value = "1" },
                    ],
                },
                @else = new Hl7.Cql.Elm.Null { resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name },
            };
            var elmLibrary = QueryLibrary("NarrowedValueType", values, plusOne);

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "int"), cSharp);

            var results = ((System.Collections.IEnumerable)invoke(BundleOf())).Cast<object>().ToList();
            CollectionAssert.AreEqual(new object[] { 6, null }, results);
        }

        /// <summary>The number of switch expressions in <paramref name="cSharp"/>.</summary>
        private static int SwitchExpressionsIn(string cSharp) =>
            System.Text.RegularExpressions.Regex.Matches(cSharp, @" switch\r?$", System.Text.RegularExpressions.RegexOptions.Multiline).Count;

        /// <summary><c>x is FHIR.<paramref name="fhirType"/></c>.</summary>
        private static Hl7.Cql.Elm.Is IsOf(Hl7.Cql.Elm.Expression operand, string fhirType) =>
            new() { operand = operand, isTypeSpecifier = new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", fhirType) };

        /// <summary><c>[Condition] X return X.onset</c>: a query whose elements are Condition.onset values.</summary>
        private static Hl7.Cql.Elm.Query OnsetsOfConditions() =>
            new()
            {
                source = [new Hl7.Cql.Elm.AliasedQuerySource { alias = "X", expression = RetrieveOf("Condition") }],
                @return = new Hl7.Cql.Elm.ReturnClause
                {
                    distinct = false,
                    expression = new Hl7.Cql.Elm.Property { path = "onset", scope = "X" },
                },
            };

        [TestMethod]
        public void Property_OnPrimitiveValueWithoutAResultType_HasTheTypeTheModelDeclares()
        {
            // P.birthDate.value, with no result type in the ELM (MADiE output): the model declares
            // the value of a FHIR date as a System.Date, not the string the .NET model holds it as.
            var elmLibrary = QualifiedPathLibrary("PrimitiveValueStatic", "Patient", "birthDate.value");

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            StringAssert.Contains(cSharp, "IEnumerable<CqlDate> Values(");

            var bundle = BundleOf(new Patient { Id = "1", BirthDate = "1990-06-15" });
            var birthDate = ((System.Collections.IEnumerable)invoke(bundle)).Cast<Hl7.Cql.Primitives.CqlDate>().Single();
            Assert.AreEqual(1990, birthDate.Value.Year);
        }

        [TestMethod]
        public void Property_OnAliasOverAQueryReturningAChoiceElement_DispatchesOnWhatTheQueryReturns()
        {
            // from ([Condition] X return X.onset) R return R.value: the outer alias ranges over a
            // query whose elements are Condition.onset values. Nothing in the ELM types either
            // read, so the alternatives come from what was learned translating the inner query.
            var onsets = new Hl7.Cql.Elm.Query
            {
                source = [new Hl7.Cql.Elm.AliasedQuerySource { alias = "X", expression = RetrieveOf("Condition") }],
                @return = new Hl7.Cql.Elm.ReturnClause
                {
                    distinct = false,
                    expression = new Hl7.Cql.Elm.Property { path = "onset", scope = "X" },
                },
            };
            var elmLibrary = QueryLibrary("QueryElementDispatch", onsets, new Hl7.Cql.Elm.Property { path = "value", scope = "R" });

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "Age"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirDateTime"), cSharp);

            var bundle = BundleOf(new Condition { Id = "c-1", Subject = new ResourceReference("Patient/1"), Onset = new FhirDateTime("2026-02-01") });
            var values = ((System.Collections.IEnumerable)invoke(bundle)).Cast<object>().ToList();
            Assert.AreEqual(1, values.Count);
            Assert.IsNotNull(values[0], "an onset dateTime has a value");
        }

        [TestMethod]
        public void Property_OnChoiceWhoseAlternativesShareAType_EmitsOneBranchPerType()
        {
            // SimpleQuantity is a profile of Quantity, and its values are Quantity instances, so both
            // resolve to Quantity. With a string alternative (so the choice itself stays object), the
            // two must yield one type test for Quantity, not two identical ones.
            const string fhir = "http://hl7.org/fhir";
            var choiceType = new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "SimpleQuantity"),
                new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "Quantity"),
                new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "string"));
            var elmLibrary = QueryLibrary("DedupedAlternatives", RetrieveOf("Patient"), ExtensionValuesAs(choiceType, "value"));

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "Quantity"), "both quantity alternatives resolve to Quantity, so there is one branch for it:\n" + cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirString"), cSharp);

            var patient = new Patient { Id = "1" };
            patient.Extension.Add(new Extension("http://example.org/quantity", new Quantity(3m, "mg")));
            patient.Extension.Add(new Extension("http://example.org/string", new FhirString("three")));
            var values = ExtensionValuesOf(invoke, patient);
            Assert.AreEqual(3m, ((FhirDecimal)values[0]).Value);
            Assert.AreEqual("three", values[1]);
        }

        [TestMethod]
        public void Sort_ByAnIdentifierWithoutAResultType_ResolvesAgainstTheQuerysElements()
        {
            // [Condition] R sort by recordedDate, with no result types (MADiE output). The identifier
            // names an element of the sorted elements, @this; resolving it must not loop back into the
            // sort expression itself.
            var elmLibrary = new Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "SortByIdentifier", version = "1.0.0" },
                schemaIdentifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                usings = [new Hl7.Cql.Elm.UsingDef { localIdentifier = "FHIR", uri = "http://hl7.org/fhir", version = "4.0.1" }],
                statements =
                [
                    new Hl7.Cql.Elm.ExpressionDef
                    {
                        name = "Values",
                        context = "Patient",
                        expression = new Hl7.Cql.Elm.Query
                        {
                            source = [new Hl7.Cql.Elm.AliasedQuerySource { alias = "R", expression = RetrieveOf("Condition") }],
                            sort = new Hl7.Cql.Elm.SortClause
                            {
                                by =
                                [
                                    new Hl7.Cql.Elm.ByExpression
                                    {
                                        direction = Hl7.Cql.Elm.SortDirection.desc,
                                        expression = new Hl7.Cql.Elm.IdentifierRef { name = "recordedDate" },
                                    },
                                ],
                            },
                        },
                    },
                ],
            };

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            StringAssert.Contains(cSharp, "SortBy");
            var sorted = ((System.Collections.IEnumerable)invoke(BundleOf(
                new Condition { Id = "early", Subject = new ResourceReference("Patient/1"), RecordedDateElement = new FhirDateTime("2026-01-01") },
                new Condition { Id = "late", Subject = new ResourceReference("Patient/1"), RecordedDateElement = new FhirDateTime("2026-06-01") }))).Cast<Condition>();
            CollectionAssert.AreEqual(new[] { "late", "early" }, sorted.Select(c => c.Id).ToArray());
        }

        [TestMethod]
        public void Property_OnChoiceOfSpecializedIntegers_ReadsEachAlternativesValue()
        {
            // FHIR positiveInt and unsignedInt have classes of their own, PositiveInt and UnsignedInt,
            // which are not Integers: each value must match an arm for its own class. Both read their
            // value through IValue<int?>, so they share one arm.
            const string fhir = "http://hl7.org/fhir";
            var choiceType = new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "positiveInt"),
                new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "unsignedInt"),
                new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "string"));
            var elmLibrary = QueryLibrary("SpecializedIntegers", RetrieveOf("Patient"), ExtensionValuesAs(choiceType, "value"));

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(0, ArmsTesting(cSharp, "Integer"), "no alternative is an Integer:\n" + cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "IValue<int?>"), cSharp);

            var patient = new Patient { Id = "1" };
            patient.Extension.Add(new Extension("http://example.org/positive", new PositiveInt(5)));
            patient.Extension.Add(new Extension("http://example.org/unsigned", new UnsignedInt(0)));
            patient.Extension.Add(new Extension("http://example.org/string", new FhirString("five")));
            CollectionAssert.AreEqual(new object[] { 5, 0, "five" }, ExtensionValuesOf(invoke, patient).ToArray());
        }

        /// <summary>
        /// For each element <c>R</c>: <c>R.extension $this return ($this.value as <paramref name="choice"/>).<paramref name="path"/></c>,
        /// reading off extension values the ELM declares as <paramref name="choice"/>.
        /// </summary>
        private static Hl7.Cql.Elm.Query ExtensionValuesAs(Hl7.Cql.Elm.ChoiceTypeSpecifier choice, string path) =>
            new()
            {
                source =
                [
                    new Hl7.Cql.Elm.AliasedQuerySource
                    {
                        alias = "$this",
                        expression = new Hl7.Cql.Elm.Property { path = "extension", source = new Hl7.Cql.Elm.AliasRef { name = "R" } },
                    },
                ],
                @return = new Hl7.Cql.Elm.ReturnClause
                {
                    distinct = false,
                    expression = new Hl7.Cql.Elm.Property
                    {
                        path = path,
                        source = new Hl7.Cql.Elm.As
                        {
                            asTypeSpecifier = choice,
                            resultTypeSpecifier = choice,
                            operand = new Hl7.Cql.Elm.Property { path = "value", source = new Hl7.Cql.Elm.AliasRef { name = "$this" } },
                        },
                    },
                },
            };

        /// <summary>The values <see cref="ExtensionValuesAs"/> reads off <paramref name="patient"/>'s extensions.</summary>
        private static List<object> ExtensionValuesOf(Func<Bundle, object> invoke, Patient patient) =>
            ((System.Collections.IEnumerable)((System.Collections.IEnumerable)invoke(BundleOf(patient))).Cast<object>().Single()).Cast<object>().ToList();

        [TestMethod]
        public void Property_OnChoiceDeclaredInTheElm_DispatchesOnTheDeclaredAlternatives()
        {
            // The same read as the test above, but typed the way the CQL translator types it: the
            // choice element carries Choice<Age, Period, Range, string, dateTime> and the value
            // read carries the sum of the alternatives' value types. The alternatives are taken
            // from the ELM, not the model, and the result stays object.
            const string fhir = "http://hl7.org/fhir";
            const string system = "urn:hl7-org:elm-types:r1";
            var onsetValue = new Hl7.Cql.Elm.Property
            {
                path = "value",
                resultTypeSpecifier = new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                    new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "decimal"),
                    new Hl7.Cql.Elm.NamedTypeSpecifier(system, "DateTime"),
                    new Hl7.Cql.Elm.NamedTypeSpecifier(system, "String")),
                source = new Hl7.Cql.Elm.Property
                {
                    path = "onset",
                    scope = "R",
                    resultTypeSpecifier = new Hl7.Cql.Elm.ChoiceTypeSpecifier(
                        new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "Age"),
                        new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "Period"),
                        new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "Range"),
                        new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "string"),
                        new Hl7.Cql.Elm.NamedTypeSpecifier(fhir, "dateTime")),
                },
            };
            var elmLibrary = QueryLibrary("ElmChoiceValueDispatch", RetrieveOf("Condition"), onsetValue);

            var (cSharp, _) = CompileLibrary(elmLibrary, "Values");

            Assert.AreEqual(1, ArmsTesting(cSharp, "Age"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirDateTime"), cSharp);
            Assert.AreEqual(1, ArmsTesting(cSharp, "FhirString"), cSharp);
        }

        [TestMethod]
        public void SourcedProperty_QualifiedPathWithUnresolvableSegment_DoesNotReturnThePartiallyWalkedValue()
        {
            // The source-based form of Property already walked a qualified path, but skipped a
            // segment it could not resolve and returned the value walked so far: for
            // medication.reference.value that is the DataType held by 'medication', not the string.
            var retrieve = RetrieveOf("MedicationRequest");
            var elmLibrary = new Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "QualifiedPathSourced", version = "1.0.0" },
                schemaIdentifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                usings =
                [
                    new Hl7.Cql.Elm.UsingDef { localIdentifier = "FHIR", uri = "http://hl7.org/fhir", version = "4.0.1" },
                ],
                statements =
                [
                    new Hl7.Cql.Elm.ExpressionDef
                    {
                        name = "Value",
                        context = "Patient",
                        expression = new Hl7.Cql.Elm.Property
                        {
                            path = "medication.reference.value",
                            source = new Hl7.Cql.Elm.SingletonFrom
                            {
                                operand = retrieve,
                                resultTypeSpecifier = new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", "MedicationRequest"),
                            },
                        },
                    },
                ],
            };

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Value");

            Assert.IsFalse(cSharp.Contains("\"medication.reference"), "The path binds segment by segment:\n" + cSharp);

            var bundle = BundleOf(new MedicationRequest { Id = "mr-1", Medication = new ResourceReference("Medication/med-1") });
            Assert.AreEqual("Medication/med-1", invoke(bundle));
        }

        [TestMethod]
        public void Property_ThatTheSourcesTypeDoesNotHave_FailsTheBuild()
        {
            // [Condition] R return R.nonexistent
            var elmLibrary = QueryLibrary("UnboundOnType", RetrieveOf("Condition"), new Hl7.Cql.Elm.Property { scope = "R", path = "nonexistent" });

            AssertUnboundProperty(elmLibrary, "nonexistent", "Condition has no such element");
        }

        [TestMethod]
        public void Property_OnASourceOfUnknownType_FailsTheBuild()
        {
            // from { 5 as Any } R return R.code: R is an Any, which is no choice with known alternatives.
            var values = new Hl7.Cql.Elm.List
            {
                resultTypeSpecifier = new Hl7.Cql.Elm.ListTypeSpecifier { elementType = Hl7.Cql.Elm.SystemTypes.AnyType },
                element =
                [
                    new Hl7.Cql.Elm.As
                    {
                        asTypeSpecifier = Hl7.Cql.Elm.SystemTypes.AnyType,
                        resultTypeSpecifier = Hl7.Cql.Elm.SystemTypes.AnyType,
                        operand = new Hl7.Cql.Elm.Literal { valueType = Hl7.Cql.Elm.SystemTypes.IntegerType.name, resultTypeName = Hl7.Cql.Elm.SystemTypes.IntegerType.name, value = "5" },
                    },
                ],
            };
            var elmLibrary = QueryLibrary("UnboundOnAny", values, new Hl7.Cql.Elm.Property { scope = "R", path = "code" });

            AssertUnboundProperty(elmLibrary, "code", "the type of its source is not known");
        }

        [TestMethod]
        public void Property_OnChoiceWhoseElementDoesNotConvertToTheExpectedType_FailsTheBuild()
        {
            // ([Condition] X return X.onset) R return R.value, typed by the ELM as a Boolean, which the
            // value of no alternative converts to.
            var elmLibrary = QueryLibrary(
                "UnboundConversion",
                OnsetsOfConditions(),
                new Hl7.Cql.Elm.Property { scope = "R", path = "value", resultTypeSpecifier = Hl7.Cql.Elm.SystemTypes.BooleanType });

            AssertUnboundProperty(elmLibrary, "value", "its type on ");
        }

        [TestMethod]
        public void Sort_ByAColumnTheElementsDoNotHave_FailsTheBuild()
        {
            // [Condition] R sort by nonexistent
            var elmLibrary = new Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "UnboundSortColumn", version = "1.0.0" },
                schemaIdentifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                usings = [new Hl7.Cql.Elm.UsingDef { localIdentifier = "FHIR", uri = "http://hl7.org/fhir", version = "4.0.1" }],
                statements =
                [
                    new Hl7.Cql.Elm.ExpressionDef
                    {
                        name = "Values",
                        context = "Patient",
                        expression = new Hl7.Cql.Elm.Query
                        {
                            source = [new Hl7.Cql.Elm.AliasedQuerySource { alias = "R", expression = RetrieveOf("Condition") }],
                            sort = new Hl7.Cql.Elm.SortClause
                            {
                                by =
                                [
                                    new Hl7.Cql.Elm.ByColumn
                                    {
                                        direction = Hl7.Cql.Elm.SortDirection.asc,
                                        path = "nonexistent",
                                        resultTypeName = Hl7.Cql.Elm.SystemTypes.StringType.name,
                                    },
                                ],
                            },
                        },
                    },
                ],
            };

            AssertUnboundProperty(elmLibrary, "nonexistent", "Condition has no such element");
        }

        /// <summary>
        /// Asserts that compiling <paramref name="elmLibrary"/> fails because <paramref name="property"/>
        /// cannot be bound at compile time, for a reason that starts with <paramref name="reason"/>.
        /// </summary>
        private static void AssertUnboundProperty(Library elmLibrary, string property, string reason)
        {
            var exception = Assert.ThrowsException<Hl7.Cql.Exceptions.CqlException<Hl7.Cql.Compiler.ExpressionBuildingError>>(
                () => CompileLibrary(elmLibrary, "Values"));
            StringAssert.Contains(exception.Message, $"Property {property} cannot be bound at compile time: {reason}");
        }

        /// <summary>
        /// A library with one definition, <c>Values</c>: a query over a retrieve of
        /// <paramref name="resourceType"/> aliased <c>R</c>, returning the scoped property
        /// <paramref name="path"/> of each element. The property node deliberately carries no result
        /// type, matching what the MADiE translator emits for a qualified path.
        /// </summary>
        private static Library QualifiedPathLibrary(string libraryName, string resourceType, string path) =>
            QueryLibrary(libraryName, RetrieveOf(resourceType), new Hl7.Cql.Elm.Property { scope = "R", path = path });

        /// <summary>
        /// A library with one definition, <c>Values</c>: a query over <paramref name="source"/>
        /// aliased <c>R</c>, returning <paramref name="returnExpression"/> for each element.
        /// </summary>
        private static Library QueryLibrary(string libraryName, Hl7.Cql.Elm.Expression source, Hl7.Cql.Elm.Expression returnExpression) =>
            new()
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier { id = libraryName, version = "1.0.0" },
                schemaIdentifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                usings =
                [
                    new Hl7.Cql.Elm.UsingDef { localIdentifier = "FHIR", uri = "http://hl7.org/fhir", version = "4.0.1" },
                ],
                statements =
                [
                    new Hl7.Cql.Elm.ExpressionDef
                    {
                        name = "Values",
                        context = "Patient",
                        expression = new Hl7.Cql.Elm.Query
                        {
                            source =
                            [
                                new Hl7.Cql.Elm.AliasedQuerySource { alias = "R", expression = source },
                            ],
                            @return = new Hl7.Cql.Elm.ReturnClause
                            {
                                distinct = false,
                                expression = returnExpression,
                            },
                        },
                    },
                ],
            };

        private static Hl7.Cql.Elm.Retrieve RetrieveOf(string resourceType) =>
            new()
            {
                dataType = new System.Xml.XmlQualifiedName(resourceType, "http://hl7.org/fhir"),
                templateId = $"http://hl7.org/fhir/StructureDefinition/{resourceType}",
                resultTypeSpecifier = new Hl7.Cql.Elm.ListTypeSpecifier
                {
                    elementType = new Hl7.Cql.Elm.NamedTypeSpecifier("http://hl7.org/fhir", resourceType),
                },
            };

        private static Bundle BundleOf(params Resource[] resources)
        {
            var bundle = new Bundle();
            foreach (var resource in resources)
                bundle.Entry.Add(new Bundle.EntryComponent { Resource = resource });
            return bundle;
        }

        /// <summary>
        /// Compiles <paramref name="elmLibrary"/> once and returns both the generated C# and a
        /// function that evaluates <paramref name="definition"/> against a bundle.
        /// </summary>
        private static (string cSharp, Func<Bundle, object> invoke) CompileLibrary(Library elmLibrary, string definition)
        {
            var elmToolkit = new ElmToolkit()
                            .AddElmLibraries([elmLibrary])
                            .CompileToAssemblies();

            var cSharp = elmToolkit.GetElmToCSharpResults().Single().cSharp;

            var (libraryIdentifier, _, _, assemblyBinary, debugSymbols) = elmToolkit.GetElmToAssemblyResults().First();
            var assembly = new AssemblyBinary(assemblyBinary, debugSymbols);
            var invoker = new InvocationToolkit()
                           .AddAssemblyBinaries([assembly])
                           .CreateLibrarySetInvoker();

            return (cSharp, bundle => invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(bundle: bundle), libraryIdentifier, definition));
        }

        /// <summary>
        /// The number of type switch arms in <paramref name="cSharp"/> that test for
        /// <paramref name="typeName"/>, in whichever form the emitter printed them: a declaration
        /// pattern (<c>is T v</c>) or a switch expression arm (<c>T v =></c>).
        /// </summary>
        private static int ArmsTesting(string cSharp, string typeName) =>
            System.Text.RegularExpressions.Regex.Matches(
                cSharp,
                $@"\bis {System.Text.RegularExpressions.Regex.Escape(typeName)} \w+\b|^\s*{System.Text.RegularExpressions.Regex.Escape(typeName)} \w+ =>",
                System.Text.RegularExpressions.RegexOptions.Multiline).Count;

        private static CqlDefinitionDictionary ProcessLibraryWithChoiceResult(
            Hl7.Cql.Elm.ChoiceTypeSpecifier choiceType)
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();

            var elmLibrary = new Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "ChoiceTypeTest", version = "1.0.0" },
                schemaIdentifier = new Hl7.Cql.Elm.VersionedIdentifier { id = "urn:hl7-org:elm", version = "r1" },
                usings =
                [
                    new Hl7.Cql.Elm.UsingDef { localIdentifier = "FHIR", uri = "http://hl7.org/fhir", version = "4.0.1" },
                ],
                statements =
                [
                    new Hl7.Cql.Elm.ExpressionDef
                    {
                        name = "ChoiceList",
                        context = "Patient",
                        expression = new Hl7.Cql.Elm.Null
                        {
                            resultTypeSpecifier = new Hl7.Cql.Elm.ListTypeSpecifier { elementType = choiceType },
                        },
                    },
                ],
            };

            return servicesScope.ServiceProvider.GetRequiredService<LibraryCodeBuilder>().ProcessLibrary(elmLibrary);
        }

        private static Library CreateElmLibrary(CqlLibraryString libraryString)
        {
            var cqlToolkitConfig = new CqlToolkitConfig([CqlModel.ElmR1, CqlModel.Fhir401]);
            var cqlToolkit = new CqlToolkit(config: cqlToolkitConfig)
                             .AddCqlLibraries([libraryString])
                             .TranslateToElm();
            var elmLibrary = cqlToolkit.GetCqlToolkitResults().First().elmLibrary;

            return elmLibrary;
        }

        private static object InvokeLibrary(Library elmLibrary, string definition)
        {
            var elmToolkit = new ElmToolkit()
                            .AddElmLibraries([elmLibrary])
                            .CompileToAssemblies();

            var (libraryIdentifier, _, _, assemblyBinary, debugSymbols) = elmToolkit.GetElmToAssemblyResults().First();
            var assembly = new AssemblyBinary(assemblyBinary, debugSymbols);

            var invoker = new InvocationToolkit()
                           .AddAssemblyBinaries([assembly])
                           .CreateLibrarySetInvoker();

            var result = invoker.InvokeLibraryDefinition(
                FhirCqlContext.ForBundle(),
                libraryIdentifier,
                definition);

            return result;
        }
    }
}
