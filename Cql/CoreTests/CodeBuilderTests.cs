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
            Assert.IsFalse(cSharp.Contains("LateBoundProperty"), "A path known on the static type must not be late-bound:\n" + cSharp);

            var bundle = BundleOf(new Medication { Id = "med-1" });
            CollectionAssert.AreEqual(new[] { "med-1" }, ((System.Collections.IEnumerable)invoke(bundle)).Cast<object>().ToList());
        }

        [TestMethod]
        public void ScopedProperty_QualifiedPathAcrossChoiceElement_LateBindsRemainderOneSegmentPerCall()
        {
            // MR.medication.reference.value: 'medication' is a choice element, statically DataType,
            // so 'reference' cannot be bound at design time. The bound prefix stays typed and the
            // remainder is late-bound one segment per call; no emitted call carries a dotted name.
            var elmLibrary = QualifiedPathLibrary("QualifiedPathChoiceElement", "MedicationRequest", "medication.reference.value");

            var (cSharp, invoke) = CompileLibrary(elmLibrary, "Values");

            StringAssert.Contains(cSharp, "?.Medication");
            StringAssert.Contains(cSharp, "\"reference\")");
            StringAssert.Contains(cSharp, "\"value\")");
            Assert.IsFalse(cSharp.Contains("\"medication.reference"), "No late-bound call may carry a dotted name:\n" + cSharp);

            var bundle = BundleOf(new MedicationRequest { Id = "mr-1", Medication = new ResourceReference("Medication/med-1") });
            CollectionAssert.AreEqual(new[] { "Medication/med-1" }, ((System.Collections.IEnumerable)invoke(bundle)).Cast<object>().ToList());
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

            Assert.IsFalse(cSharp.Contains("\"medication.reference"), "No late-bound call may carry a dotted name:\n" + cSharp);

            var bundle = BundleOf(new MedicationRequest { Id = "mr-1", Medication = new ResourceReference("Medication/med-1") });
            Assert.AreEqual("Medication/med-1", invoke(bundle));
        }

        /// <summary>
        /// A library with one definition, <c>Values</c>: a query over a retrieve of
        /// <paramref name="resourceType"/> aliased <c>R</c>, returning the scoped property
        /// <paramref name="path"/> of each element. The property node deliberately carries no result
        /// type, matching what the MADiE translator emits for a qualified path.
        /// </summary>
        private static Library QualifiedPathLibrary(string libraryName, string resourceType, string path) =>
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
                                new Hl7.Cql.Elm.AliasedQuerySource { alias = "R", expression = RetrieveOf(resourceType) },
                            ],
                            @return = new Hl7.Cql.Elm.ReturnClause
                            {
                                distinct = false,
                                expression = new Hl7.Cql.Elm.Property { scope = "R", path = path },
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
