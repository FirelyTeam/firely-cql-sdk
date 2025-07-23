/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;

namespace CoreTests.Packaging;

[TestClass]
public class FhirIdGeneratorTests
{
    [TestMethod]
    [DataRow("VTE-8.8.000", "91a0a08d-vte-8.8.000")]
    [DataRow("Status-1.8.000", "c91484f7-status-1.8.000")]
    [DataRow("Status-1.6.000", "ad01ce35-status-1.6.000")]
    [DataRow("FHIR347-0.1.021", "d333e5c3-fhir347-0.1.021")]
    [DataRow("Namespace.FHIR Helpers-4.0.1-alpha", "33456ffb-namespace-fhir-helpers-4.0.1-alpha")]
    [DataRow("Namespace.FHIR Helpers-4.3.0-alpha", "b8f5ea8d-namespace-fhir-helpers-4.3.0-alpha")]
    [DataRow("FHIRHelpers-4.0.001", "edde5879-fhir-helpers-4.0.001")]
    [DataRow("FHIRHelpers-4.3.000", "1e1cb65c-fhir-helpers-4.3.000")]
    [DataRow("POAGOpticNerveEvaluationFHIR-0.1.000", "f60da446-poag-optic-nerve-evaluation-fhir-0.1.000")]
    [DataRow("SupplementalDataElementsFHIR4-2.0.000", "c64e44fe-supplemental-data-elements-fhir4-2.0.000")]
    [DataRow("Cataracts2040BCVAwithin90DaysFHIR-0.1.000", "54e754bb-cataracts-2040-bcv-awithin-90-days-fhir-0.1.000")]
    [DataRow("StatinTherapyforthePreventionandTreatmentofCardiovascularDiseaseFHIR-0.2.000", "0fa54806-statin-therap-preven-treatm-cardio-diseas-fhir-0.2.000")]
    [DataRow("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR-0.1.001", "24d27ff1-weig-asse-coun-nutr-phys-acti-chil-adol-fhir-0.1.001")]
    // Extreme case - only using hash
    [DataRow("Short-400000000000000000000000000000.00000000000000000000000000.00000000000000000000000000000001", "c51e22d4")]
    public void GenerateFhirId_ShouldReturnValidId_WhenIdentifierIsValid(
        string test,
        string expected)
    {
        // Arrange
        var identifier = CqlVersionedLibraryIdentifier.Parse(test);

        // Act
        var result = FhirIdGenerator.GenerateFhirId(identifier);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Length <= 64);
        Assert.AreEqual(expected, result);
    }
}