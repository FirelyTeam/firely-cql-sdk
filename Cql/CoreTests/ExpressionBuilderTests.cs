/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Internal;
using Hl7.Fhir.Model;
using Hl7.Cql.Compiler;
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
    public class LibraryExpressionBuilderTests
    {
        private static ServiceProvider BuildServiceProvider() => ElmToolkitServices.AddCqlCompilerServices(new ServiceCollection().AddDebugLogging()).BuildServiceProvider(validateScopes: true);

        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
            var elm = new FileInfo(Path.Combine("Input", "ELM", "Test", "Aggregates-1.0.0.json"));
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>().ProcessLibrary(elmPackage);
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
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>().ProcessLibrary(elmPackage);
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
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>().ProcessLibrary(elmPackage);
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

            var librarySetExpressionBuilder = servicesScope.ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();
            var definitions = librarySetExpressionBuilder.ProcessLibrarySet(librarySet);
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
                                           .GetRequiredService<LibraryExpressionBuilder>()
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
                                           .GetRequiredService<LibraryExpressionBuilder>()
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

        // Binding a CQL Concept into a FHIR CodeableConcept (as the ExpressionBuilder must do when a
        // measure reconciles a System Concept with a FHIR CodeableConcept, e.g. CMS108FHIRVTEProphylaxis)
        // previously threw "Cannot convert Hl7.Cql.Primitives.CqlConcept to Hl7.Fhir.Model.CodeableConcept".
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
                                           .GetRequiredService<LibraryExpressionBuilder>()
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
