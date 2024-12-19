using Hl7.Cql.Packaging;

namespace CqlSdkPrototype;

internal static class HardcodedIgnores
{
    private static readonly string[] CqlFileNames = [
        // From Demo
        "NCQAFHIRBase.cql",                              // Object reference not set to an instance of an object.
        "NCQAClaims.cql",                                // Object reference not set to an instance of an object.
        "DischargedonAntithromboticTherapyFHIR.cql",     // Expression has a null result type specifier
        "SafeUseofOpioidsConcurrentPrescribingFHIR.cql", // Expression has a null result type specifier
    ];

    private static readonly string[] _demoElmFiles = new string[]
    {
        // Dependency missing
        "BCSEHEDISMY2022.json",
        "NCQAAdvancedIllnessandFrailty.json",
        "NCQAEncounter.json",
        "NCQAPalliativeCare.json",
        "NCQAHospice.json",
        //
        "NCQAHealthPlanEnrollment.json",
        //
        "MATGlobalCommonFunctionsFHIR4.json",
        "HospitalHarmHyperglycemiainHospitalizedPatientsFHIR.json",
        "TJCOverallFHIR.json",
        "PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR.json",
        "HospiceFHIR4.json",
        "PalliativeCareFHIR.json",
        "AdvancedIllnessandFrailtyExclusionECQMFHIR4.json",
        "CervicalCancerScreeningFHIR.json",
        "AdultOutpatientEncountersFHIR4.json",
        "FHIR347.json",
        "VTEFHIR4.json",
        "DRCommunicationWithPhysicianManagingDiabetesFHIR.json",
        "Exam125FHIR.json",
        "DiabetesHemoglobinA1cHbA1cPoorControl9FHIR.json",
        "HybridHWMFHIR.json",
        "ColorectalCancerScreeningsFHIR.json",
        "HybridHWRFHIR.json",
        "Exam130FHIR.json",
        "BreastCancerScreeningsFHIR.json",
        "HospitalHarmSevereHypoglycemiaFHIR.json",
        //
        "CumulativeMedicationDurationFHIR4.json",
        //
    };

    public static readonly HashSet<string> Identifiers =
        new(
            [
                .. HardCodedSkipElmFiles.FileNames.Select(f => f.TrimFileExtension(".json")),
                .. _demoElmFiles.Select(f => f.TrimFileExtension(".json")),
                .. CqlFileNames.Select(f => f.TrimFileExtension(".cql"))],
            StringComparer.OrdinalIgnoreCase);
}