using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("UseofHighRiskMedicationsintheElderlyFHIR", "0.2.001")]
public partial class UseofHighRiskMedicationsintheElderlyFHIR_0_2_001 : ILibrary, ISingleton<UseofHighRiskMedicationsintheElderlyFHIR_0_2_001>
{
    private UseofHighRiskMedicationsintheElderlyFHIR_0_2_001() {}

    public static UseofHighRiskMedicationsintheElderlyFHIR_0_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    string ILibrary.Name => "UseofHighRiskMedicationsintheElderlyFHIR";
    string ILibrary.Version => "0.2.001";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, QICoreCommon_2_1_000.Instance, Status_1_8_000.Instance];

    #endregion Library Members

    #region Definition Methods

    [CqlDeclaration("Alcohol Withdrawal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209")]
    public CqlValueSet Alcohol_Withdrawal(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209", default);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);

    [CqlDeclaration("Benzodiazepine Withdrawal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208")]
    public CqlValueSet Benzodiazepine_Withdrawal(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208", default);

    [CqlDeclaration("Bipolar Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128")]
    public CqlValueSet Bipolar_Disorder(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", default);

    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);

    [CqlDeclaration("Desiccated Thyroid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060")]
    public CqlValueSet Desiccated_Thyroid_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060", default);

    [CqlDeclaration("Digoxin Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065")]
    public CqlValueSet Digoxin_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065", default);

    [CqlDeclaration("Dipyridamole Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051")]
    public CqlValueSet Dipyridamole_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051", default);

    [CqlDeclaration("Discharge Services Nursing Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013")]
    public CqlValueSet Discharge_Services_Nursing_Facility(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", default);

    [CqlDeclaration("Doxepin Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067")]
    public CqlValueSet Doxepin_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067", default);

    [CqlDeclaration("Generalized Anxiety Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210")]
    public CqlValueSet Generalized_Anxiety_Disorder(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210", default);

    [CqlDeclaration("Guanfacine Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252")]
    public CqlValueSet Guanfacine_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Megestrol Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1247")]
    public CqlValueSet Megestrol_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1247", default);

    [CqlDeclaration("Meperidine Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1248")]
    public CqlValueSet Meperidine_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1248", default);

    [CqlDeclaration("Meprobamate Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057")]
    public CqlValueSet Meprobamate_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057", default);

    [CqlDeclaration("Nifedipine Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053")]
    public CqlValueSet Nifedipine_Medications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053", default);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
    public CqlValueSet Ophthalmological_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);

    [CqlDeclaration("Potentially Harmful Antidepressants for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054")]
    public CqlValueSet Potentially_Harmful_Antidepressants_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054", default);

    [CqlDeclaration("Potentially Harmful Antihistamines for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043")]
    public CqlValueSet Potentially_Harmful_Antihistamines_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043", default);

    [CqlDeclaration("Potentially Harmful Antiinfectives for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481")]
    public CqlValueSet Potentially_Harmful_Antiinfectives_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481", default);

    [CqlDeclaration("Potentially Harmful Antiparkinsonian Agents for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049")]
    public CqlValueSet Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049", default);

    [CqlDeclaration("Potentially Harmful Antipsychotics for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523")]
    public CqlValueSet Potentially_Harmful_Antipsychotics_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523", default);

    [CqlDeclaration("Potentially Harmful Barbiturates for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055")]
    public CqlValueSet Potentially_Harmful_Barbiturates_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055", default);

    [CqlDeclaration("Potentially Harmful Benzodiazepines for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522")]
    public CqlValueSet Potentially_Harmful_Benzodiazepines_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522", default);

    [CqlDeclaration("Potentially Harmful Estrogens for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058")]
    public CqlValueSet Potentially_Harmful_Estrogens_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058", default);

    [CqlDeclaration("Potentially Harmful Gastrointestinal Antispasmodics for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050")]
    public CqlValueSet Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050", default);

    [CqlDeclaration("Potentially Harmful Nonbenzodiazepine Hypnotics for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480")]
    public CqlValueSet Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480", default);

    [CqlDeclaration("Potentially Harmful Pain Medications for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063")]
    public CqlValueSet Potentially_Harmful_Pain_Medications_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063", default);

    [CqlDeclaration("Potentially Harmful Skeletal Muscle Relaxants for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062")]
    public CqlValueSet Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062", default);

    [CqlDeclaration("Potentially Harmful Sulfonylureas for Older Adults")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059")]
    public CqlValueSet Potentially_Harmful_Sulfonylureas_for_Older_Adults(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("REM Sleep Behavior Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207")]
    public CqlValueSet REM_Sleep_Behavior_Disorder(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207", default);

    [CqlDeclaration("Schizophrenia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205")]
    public CqlValueSet Schizophrenia(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205", default);

    [CqlDeclaration("Seizure Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206")]
    public CqlValueSet Seizure_Disorder(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Virtual Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Virtual_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("1 ML digoxin 0.1 MG/ML Injection")]
    public CqlCode _1_ML_digoxin_0_1_MG_ML_Injection(CqlContext context) =>
        new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("2 ML digoxin 0.25 MG/ML Injection")]
    public CqlCode _2_ML_digoxin_0_25_MG_ML_Injection(CqlContext context) =>
        new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("digoxin 0.05 MG/ML Oral Solution")]
    public CqlCode digoxin_0_05_MG_ML_Oral_Solution(CqlContext context) =>
        new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("digoxin 0.0625 MG Oral Tablet")]
    public CqlCode digoxin_0_0625_MG_Oral_Tablet(CqlContext context) =>
        new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("digoxin 0.125 MG Oral Tablet")]
    public CqlCode digoxin_0_125_MG_Oral_Tablet(CqlContext context) =>
        new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("digoxin 0.25 MG Oral Tablet")]
    public CqlCode digoxin_0_25_MG_Oral_Tablet(CqlContext context) =>
        new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 10 MG Oral Capsule")]
    public CqlCode doxepin_10_MG_Oral_Capsule(CqlContext context) =>
        new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 10 MG/ML Oral Solution")]
    public CqlCode doxepin_10_MG_ML_Oral_Solution(CqlContext context) =>
        new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 100 MG Oral Capsule")]
    public CqlCode doxepin_100_MG_Oral_Capsule(CqlContext context) =>
        new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 150 MG Oral Capsule")]
    public CqlCode doxepin_150_MG_Oral_Capsule(CqlContext context) =>
        new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 25 MG Oral Capsule")]
    public CqlCode doxepin_25_MG_Oral_Capsule(CqlContext context) =>
        new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 3 MG Oral Tablet")]
    public CqlCode doxepin_3_MG_Oral_Tablet(CqlContext context) =>
        new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 50 MG Oral Capsule")]
    public CqlCode doxepin_50_MG_Oral_Capsule(CqlContext context) =>
        new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 6 MG Oral Tablet")]
    public CqlCode doxepin_6_MG_Oral_Tablet(CqlContext context) =>
        new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("doxepin 75 MG Oral Capsule")]
    public CqlCode doxepin_75_MG_Oral_Capsule(CqlContext context) =>
        new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("ergoloid mesylates, USP 1 MG Oral Tablet")]
    public CqlCode ergoloid_mesylates__USP_1_MG_Oral_Tablet(CqlContext context) =>
        new CqlCode("318179", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlDeclaration("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext context) =>
        new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("RXNORM")]
    public CqlCode[] RXNORM(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("318179", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("UseofHighRiskMedicationsintheElderlyFHIR-0.2.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }

    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        CqlValueSet x_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet z_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
        CqlValueSet ad_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> af_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ag_(Encounter E)
        {
            List<CodeableConcept> an_ = E?.Type;
            CqlConcept ao_(CodeableConcept @this)
            {
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return at_;
            };
            IEnumerable<CqlConcept> ap_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)an_, ao_);
            bool? aq_(CqlConcept T)
            {
                CqlCode au_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(T, av_);

                return aw_;
            };
            IEnumerable<CqlConcept> ar_ = context.Operators.Where<CqlConcept>(ap_, aq_);
            bool? as_ = context.Operators.Exists<CqlConcept>(ar_);

            return as_;
        };
        IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ae_, ah_);
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ac_, ai_);
        IEnumerable<Encounter> ak_ = Status_1_8_000.Instance.isEncounterPerformed(context, aj_);
        bool? al_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> ax_ = this.Measurement_Period(context);
            Period ay_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
            bool? ba_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ax_, az_, default);

            return ba_;
        };
        IEnumerable<Encounter> am_ = context.Operators.Where<Encounter>(ak_, al_);

        return am_;
    }

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 65);
        IEnumerable<Encounter> j_ = this.Qualifying_Encounters(context);
        bool? k_ = context.Operators.Exists<Encounter>(j_);
        bool? l_ = context.Operators.And(i_, k_);

        return l_;
    }

    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? b_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);

        return c_;
    }

    public IEnumerable<MedicationRequest> moreThanOneOrder(CqlContext context, IEnumerable<MedicationRequest> Medication)
    {
        IEnumerable<MedicationRequest> a_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
        IEnumerable<MedicationRequest> b_(MedicationRequest OrderMedication1)
        {
            IEnumerable<MedicationRequest> g_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
            bool? h_(MedicationRequest OrderMedication2)
            {
                FhirDateTime l_ = OrderMedication1?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
                MedicationRequest.DispenseRequestComponent p_ = OrderMedication1?.DispenseRequest;
                UnsignedInt q_ = p_?.NumberOfRepeatsAllowedElement;
                int? r_ = q_?.Value;
                bool? s_ = context.Operators.GreaterOrEqual(r_, 1);
                bool? t_ = context.Operators.And(o_, s_);
                CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlDate w_ = context.Operators.DateFrom(v_);
                FhirDateTime x_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
                CqlDate z_ = context.Operators.DateFrom(y_);
                bool? aa_ = context.Operators.Equivalent(w_, z_);
                bool? ab_ = context.Operators.Not(aa_);
                CqlDateTime ad_ = context.Operators.Convert<CqlDateTime>(l_);
                bool? af_ = context.Operators.In<CqlDateTime>(ad_, n_, default);
                bool? ag_ = context.Operators.And(ab_, af_);
                CqlDateTime ai_ = context.Operators.Convert<CqlDateTime>(x_);
                bool? ak_ = context.Operators.In<CqlDateTime>(ai_, n_, default);
                bool? al_ = context.Operators.And(ag_, ak_);
                bool? am_ = context.Operators.Or(t_, al_);
                CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlDate ap_ = context.Operators.DateFrom(ao_);
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(x_);
                CqlDate as_ = context.Operators.DateFrom(ar_);
                bool? at_ = context.Operators.Equivalent(ap_, as_);
                CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(l_);
                bool? ax_ = context.Operators.In<CqlDateTime>(av_, n_, default);
                bool? ay_ = context.Operators.And(at_, ax_);
                CqlInterval<CqlDate> az_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate ba_ = context.Operators.Start(az_);
                CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                CqlDate bc_ = context.Operators.DateFrom(bb_);
                CqlInterval<CqlDate> bd_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate be_ = context.Operators.Start(bd_);
                CqlDateTime bf_ = context.Operators.ConvertDateToDateTime(be_);
                CqlDate bg_ = context.Operators.DateFrom(bf_);
                bool? bh_ = context.Operators.Equivalent(bc_, bg_);
                bool? bi_ = context.Operators.Not(bh_);
                bool? bj_ = context.Operators.And(ay_, bi_);
                CqlDate bl_ = context.Operators.Start(az_);
                CqlDateTime bm_ = context.Operators.ConvertDateToDateTime(bl_);
                bool? bo_ = context.Operators.In<CqlDateTime>(bm_, n_, default);
                bool? bp_ = context.Operators.And(bj_, bo_);
                CqlDate br_ = context.Operators.Start(bd_);
                CqlDateTime bs_ = context.Operators.ConvertDateToDateTime(br_);
                bool? bu_ = context.Operators.In<CqlDateTime>(bs_, n_, default);
                bool? bv_ = context.Operators.And(bp_, bu_);
                bool? bw_ = context.Operators.Or(am_, bv_);

                return bw_;
            };
            IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
            MedicationRequest j_(MedicationRequest OrderMedication2) =>
                OrderMedication1;
            IEnumerable<MedicationRequest> k_ = context.Operators.Select<MedicationRequest, MedicationRequest>(i_, j_);

            return k_;
        };
        IEnumerable<MedicationRequest> c_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(a_, b_);
        MedicationRequest d_(MedicationRequest OrderMedication1) =>
            OrderMedication1;
        IEnumerable<MedicationRequest> e_ = context.Operators.Select<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Distinct<MedicationRequest>(e_);

        return f_;
    }

    [CqlDeclaration("Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = this.moreThanOneOrder(context, e_);
        CqlValueSet g_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(h_, j_);
        IEnumerable<MedicationRequest> l_ = this.moreThanOneOrder(context, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(f_, l_);
        CqlValueSet n_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(o_, q_);
        IEnumerable<MedicationRequest> s_ = this.moreThanOneOrder(context, r_);
        CqlValueSet t_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest> u_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> x_ = context.Operators.Union<MedicationRequest>(u_, w_);
        IEnumerable<MedicationRequest> y_ = this.moreThanOneOrder(context, x_);
        IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(s_, y_);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(m_, z_);
        CqlValueSet ab_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> ac_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ae_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> af_ = context.Operators.Union<MedicationRequest>(ac_, ae_);
        IEnumerable<MedicationRequest> ag_ = this.moreThanOneOrder(context, af_);
        CqlValueSet ah_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ak_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> al_ = context.Operators.Union<MedicationRequest>(ai_, ak_);
        IEnumerable<MedicationRequest> am_ = this.moreThanOneOrder(context, al_);
        IEnumerable<MedicationRequest> an_ = context.Operators.Union<MedicationRequest>(ag_, am_);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Union<MedicationRequest>(aa_, an_);
        CqlValueSet ap_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> at_ = context.Operators.Union<MedicationRequest>(aq_, as_);
        IEnumerable<MedicationRequest> au_ = this.moreThanOneOrder(context, at_);
        CqlValueSet av_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(aw_, ay_);
        IEnumerable<MedicationRequest> ba_ = this.moreThanOneOrder(context, az_);
        IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(au_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ao_, bb_);
        CqlCode bd_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> be_ = context.Operators.ToList<CqlCode>(bd_);
        IEnumerable<MedicationRequest> bf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, be_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> bh_ = context.Operators.ToList<CqlCode>(bd_);
        IEnumerable<MedicationRequest> bi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, bh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bf_, bi_);
        IEnumerable<MedicationRequest> bk_ = this.moreThanOneOrder(context, bj_);
        CqlValueSet bl_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bm_, bo_);
        IEnumerable<MedicationRequest> bq_ = this.moreThanOneOrder(context, bp_);
        IEnumerable<MedicationRequest> br_ = context.Operators.Union<MedicationRequest>(bk_, bq_);
        IEnumerable<MedicationRequest> bs_ = context.Operators.Union<MedicationRequest>(bc_, br_);
        CqlValueSet bt_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest> bu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bx_ = context.Operators.Union<MedicationRequest>(bu_, bw_);
        IEnumerable<MedicationRequest> by_ = this.moreThanOneOrder(context, bx_);
        CqlValueSet bz_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ca_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cd_ = context.Operators.Union<MedicationRequest>(ca_, cc_);
        IEnumerable<MedicationRequest> ce_ = this.moreThanOneOrder(context, cd_);
        IEnumerable<MedicationRequest> cf_ = context.Operators.Union<MedicationRequest>(by_, ce_);
        IEnumerable<MedicationRequest> cg_ = context.Operators.Union<MedicationRequest>(bs_, cf_);
        CqlValueSet ch_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest> ci_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ch_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ck_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ch_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cl_ = context.Operators.Union<MedicationRequest>(ci_, ck_);
        IEnumerable<MedicationRequest> cm_ = this.moreThanOneOrder(context, cl_);
        CqlValueSet cn_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> co_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cr_ = context.Operators.Union<MedicationRequest>(co_, cq_);
        IEnumerable<MedicationRequest> cs_ = this.moreThanOneOrder(context, cr_);
        IEnumerable<MedicationRequest> ct_ = context.Operators.Union<MedicationRequest>(cm_, cs_);
        IEnumerable<MedicationRequest> cu_ = context.Operators.Union<MedicationRequest>(cg_, ct_);
        CqlValueSet cv_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> cw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cz_ = context.Operators.Union<MedicationRequest>(cw_, cy_);
        IEnumerable<MedicationRequest> da_ = this.moreThanOneOrder(context, cz_);
        CqlValueSet db_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, db_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> de_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, db_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(dc_, de_);
        IEnumerable<MedicationRequest> dg_ = this.moreThanOneOrder(context, df_);
        IEnumerable<MedicationRequest> dh_ = context.Operators.Union<MedicationRequest>(da_, dg_);
        IEnumerable<MedicationRequest> di_ = context.Operators.Union<MedicationRequest>(cu_, dh_);
        CqlValueSet dj_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest> dk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dn_ = context.Operators.Union<MedicationRequest>(dk_, dm_);
        IEnumerable<MedicationRequest> do_ = this.moreThanOneOrder(context, dn_);
        CqlValueSet dp_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest> dq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ds_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dt_ = context.Operators.Union<MedicationRequest>(dq_, ds_);
        IEnumerable<MedicationRequest> du_ = this.moreThanOneOrder(context, dt_);
        IEnumerable<MedicationRequest> dv_ = context.Operators.Union<MedicationRequest>(do_, du_);
        IEnumerable<MedicationRequest> dw_ = context.Operators.Union<MedicationRequest>(di_, dv_);

        return dw_;
    }

    public decimal? MedicationRequestPeriodInDays(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];
        decimal? b_(MedicationRequest R)
        {
            MedicationRequest.DispenseRequestComponent f_ = R?.DispenseRequest;
            Duration g_ = f_?.ExpectedSupplyDuration;
            CqlQuantity h_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, g_);
            CqlQuantity i_ = context.Operators.ConvertQuantity(h_, "d");
            decimal? j_ = i_?.value;
            Quantity l_ = f_?.Quantity;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_);
            decimal? n_ = m_?.value;
            List<Dosage> o_ = R?.DosageInstruction;
            Dosage p_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
            List<Dosage.DoseAndRateComponent> q_ = p_?.DoseAndRate;
            Dosage.DoseAndRateComponent r_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)q_);
            DataType s_ = r_?.Dose;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlQuantity u_ = context.Operators.End(t_ as CqlInterval<CqlQuantity>);
            Dosage w_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
            List<Dosage.DoseAndRateComponent> x_ = w_?.DoseAndRate;
            Dosage.DoseAndRateComponent y_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)x_);
            DataType z_ = y_?.Dose;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            decimal? ab_ = (u_ ?? aa_ as CqlQuantity)?.value;
            Dosage ad_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
            Timing ae_ = ad_?.Timing;
            Timing.RepeatComponent af_ = ae_?.Repeat;
            PositiveInt ag_ = af_?.FrequencyMaxElement;
            int? ah_ = ag_?.Value;
            Dosage aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
            Timing ak_ = aj_?.Timing;
            Timing.RepeatComponent al_ = ak_?.Repeat;
            PositiveInt am_ = al_?.FrequencyElement;
            int? an_ = am_?.Value;
            Dosage ap_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
            Timing aq_ = ap_?.Timing;
            Timing.RepeatComponent ar_ = aq_?.Repeat;
            FhirDecimal as_ = ar_?.PeriodElement;
            decimal? at_ = as_?.Value;
            Dosage av_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
            Timing aw_ = av_?.Timing;
            Timing.RepeatComponent ax_ = aw_?.Repeat;
            Code<Timing.UnitsOfTime> ay_ = ax_?.PeriodUnitElement;
            Timing.UnitsOfTime? az_ = ay_?.Value;
            string ba_ = context.Operators.Convert<string>(az_);
            CqlQuantity bb_ = CumulativeMedicationDuration_4_1_000.Instance.Quantity(context, at_, ba_);
            decimal? bc_ = CumulativeMedicationDuration_4_1_000.Instance.ToDaily(context, ah_ ?? an_, bb_);
            Dosage be_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
            Timing bf_ = be_?.Timing;
            Timing.RepeatComponent bg_ = bf_?.Repeat;
            List<Time> bh_ = bg_?.TimeOfDayElement;
            IEnumerable<CqlTime> bi_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bh_, "value");
            int? bj_ = context.Operators.Count<CqlTime>(bi_);
            decimal? bk_ = context.Operators.ConvertIntegerToDecimal(bj_);
            decimal? bl_ = context.Operators.Multiply(ab_, (bc_ ?? bk_) ?? 1.0m);
            decimal? bm_ = context.Operators.Divide(n_, bl_);
            UnsignedInt bo_ = f_?.NumberOfRepeatsAllowedElement;
            int? bp_ = bo_?.Value;
            int? bq_ = context.Operators.Add(1, bp_ ?? 0);
            decimal? br_ = context.Operators.ConvertIntegerToDecimal(bq_);
            decimal? bs_ = context.Operators.Multiply(j_ ?? bm_, br_);

            return bs_;
        };
        IEnumerable<decimal?> c_ = context.Operators.Select<MedicationRequest, decimal?>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<decimal?> d_ = context.Operators.Distinct<decimal?>(c_);
        decimal? e_ = context.Operators.SingletonFrom<decimal?>(d_);

        return e_;
    }

    [CqlDeclaration("Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = this.moreThanOneOrder(context, e_);
        decimal? g_(MedicationRequest AntiInfectives)
        {
            decimal? l_ = this.MedicationRequestPeriodInDays(context, AntiInfectives);

            return l_;
        };
        IEnumerable<decimal?> h_ = context.Operators.Select<MedicationRequest, decimal?>(f_, g_);
        decimal? i_ = context.Operators.Sum(h_);
        decimal? j_ = context.Operators.ConvertIntegerToDecimal(90);
        bool? k_ = context.Operators.Greater(i_, j_);

        return k_;
    }

    public CqlQuantity MedicationStrengthPerUnit(CqlContext context, CqlConcept Strength)
    {
        CqlQuantity a_()
        {
            bool b_()
            {
                CqlCode q_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(Strength, r_);

                return s_ ?? false;
            };
            bool c_()
            {
                CqlCode t_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(Strength, u_);

                return v_ ?? false;
            };
            bool d_()
            {
                CqlCode w_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
                CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                bool? y_ = context.Operators.Equivalent(Strength, x_);

                return y_ ?? false;
            };
            bool e_()
            {
                CqlCode z_ = this.digoxin_0_125_MG_Oral_Tablet(context);
                CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                bool? ab_ = context.Operators.Equivalent(Strength, aa_);

                return ab_ ?? false;
            };
            bool f_()
            {
                CqlCode ac_ = this.digoxin_0_25_MG_Oral_Tablet(context);
                CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                bool? ae_ = context.Operators.Equivalent(Strength, ad_);

                return ae_ ?? false;
            };
            bool g_()
            {
                CqlCode af_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
                CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
                bool? ah_ = context.Operators.Equivalent(Strength, ag_);

                return ah_ ?? false;
            };
            bool h_()
            {
                CqlCode ai_ = this.doxepin_3_MG_Oral_Tablet(context);
                CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
                bool? ak_ = context.Operators.Equivalent(Strength, aj_);

                return ak_ ?? false;
            };
            bool i_()
            {
                CqlCode al_ = this.doxepin_6_MG_Oral_Tablet(context);
                CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
                bool? an_ = context.Operators.Equivalent(Strength, am_);

                return an_ ?? false;
            };
            bool j_()
            {
                CqlCode ao_ = this.doxepin_10_MG_Oral_Capsule(context);
                CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                bool? aq_ = context.Operators.Equivalent(Strength, ap_);

                return aq_ ?? false;
            };
            bool k_()
            {
                CqlCode ar_ = this.doxepin_10_MG_ML_Oral_Solution(context);
                CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
                bool? at_ = context.Operators.Equivalent(Strength, as_);

                return at_ ?? false;
            };
            bool l_()
            {
                CqlCode au_ = this.doxepin_25_MG_Oral_Capsule(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(Strength, av_);

                return aw_ ?? false;
            };
            bool m_()
            {
                CqlCode ax_ = this.doxepin_50_MG_Oral_Capsule(context);
                CqlConcept ay_ = context.Operators.ConvertCodeToConcept(ax_);
                bool? az_ = context.Operators.Equivalent(Strength, ay_);

                return az_ ?? false;
            };
            bool n_()
            {
                CqlCode ba_ = this.doxepin_75_MG_Oral_Capsule(context);
                CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                bool? bc_ = context.Operators.Equivalent(Strength, bb_);

                return bc_ ?? false;
            };
            bool o_()
            {
                CqlCode bd_ = this.doxepin_100_MG_Oral_Capsule(context);
                CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                bool? bf_ = context.Operators.Equivalent(Strength, be_);

                return bf_ ?? false;
            };
            bool p_()
            {
                CqlCode bg_ = this.doxepin_150_MG_Oral_Capsule(context);
                CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
                bool? bi_ = context.Operators.Equivalent(Strength, bh_);

                return bi_ ?? false;
            };
            if (b_())
            {
                CqlQuantity bj_ = context.Operators.Quantity(0.05m, "mg/mL");

                return bj_;
            }
            else if (c_())
            {
                CqlQuantity bk_ = context.Operators.Quantity(0.0625m, "mg");

                return bk_;
            }
            else if (d_())
            {
                CqlQuantity bl_ = context.Operators.Quantity(0.1m, "mg/mL");

                return bl_;
            }
            else if (e_())
            {
                CqlQuantity bm_ = context.Operators.Quantity(0.125m, "mg");

                return bm_;
            }
            else if (f_())
            {
                CqlQuantity bn_ = context.Operators.Quantity(0.25m, "mg");

                return bn_;
            }
            else if (g_())
            {
                CqlQuantity bo_ = context.Operators.Quantity(0.25m, "mg/mL");

                return bo_;
            }
            else if (h_())
            {
                CqlQuantity bp_ = context.Operators.Quantity(3m, "mg");

                return bp_;
            }
            else if (i_())
            {
                CqlQuantity bq_ = context.Operators.Quantity(6m, "mg");

                return bq_;
            }
            else if (j_())
            {
                CqlQuantity br_ = context.Operators.Quantity(10m, "mg");

                return br_;
            }
            else if (k_())
            {
                CqlQuantity bs_ = context.Operators.Quantity(10m, "mg/mL");

                return bs_;
            }
            else if (l_())
            {
                CqlQuantity bt_ = context.Operators.Quantity(25m, "mg");

                return bt_;
            }
            else if (m_())
            {
                CqlQuantity bu_ = context.Operators.Quantity(50m, "mg");

                return bu_;
            }
            else if (n_())
            {
                CqlQuantity bv_ = context.Operators.Quantity(75m, "mg");

                return bv_;
            }
            else if (o_())
            {
                CqlQuantity bw_ = context.Operators.Quantity(100m, "mg");

                return bw_;
            }
            else if (p_())
            {
                CqlQuantity bx_ = context.Operators.Quantity(150m, "mg");

                return bx_;
            }
            else
            {
                return default;
            }
        };

        return a_();
    }

    public CqlQuantity averageDailyDose(CqlContext context, MedicationRequest MedicationRequest)
    {
        MedicationRequest[] a_ = [
            MedicationRequest,
        ];
        CqlQuantity b_(MedicationRequest Order)
        {
            CqlQuantity f_()
            {
                bool g_()
                {
                    decimal? h_ = this.MedicationRequestPeriodInDays(context, Order);
                    bool? i_ = context.Operators.Not((bool?)(h_ is null));
                    CqlConcept j_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity k_ = this.MedicationStrengthPerUnit(context, j_);
                    string l_ = k_?.unit;
                    bool? m_ = context.Operators.Equal(l_, "mg");
                    CqlQuantity o_ = this.MedicationStrengthPerUnit(context, j_);
                    string p_ = o_?.unit;
                    bool? q_ = context.Operators.Equal(p_, "mg/mL");
                    MedicationRequest.DispenseRequestComponent r_ = Order?.DispenseRequest;
                    Quantity s_ = r_?.Quantity;
                    CqlQuantity t_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, s_);
                    string u_ = t_?.unit;
                    bool? v_ = context.Operators.Equal(u_, "mL");
                    bool? w_ = context.Operators.And(q_, v_);
                    bool? x_ = context.Operators.Or(m_, w_);
                    bool? y_ = context.Operators.And(i_, x_);

                    return y_ ?? false;
                };
                if (g_())
                {
                    MedicationRequest.DispenseRequestComponent z_ = Order?.DispenseRequest;
                    Quantity aa_ = z_?.Quantity;
                    CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                    CqlConcept ac_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity ad_ = this.MedicationStrengthPerUnit(context, ac_);
                    CqlQuantity ae_ = context.Operators.Multiply(ab_, ad_);
                    decimal? af_ = this.MedicationRequestPeriodInDays(context, Order);
                    CqlQuantity ag_ = context.Operators.Divide(ae_, new CqlQuantity(af_, "d"));

                    return ag_;
                }
                else
                {
                    return default;
                }
            };

            return f_();
        };
        IEnumerable<CqlQuantity> c_ = context.Operators.Select<MedicationRequest, CqlQuantity>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<CqlQuantity> d_ = context.Operators.Distinct<CqlQuantity>(c_);
        CqlQuantity e_ = context.Operators.SingletonFrom<CqlQuantity>(d_);

        return e_;
    }

    [CqlDeclaration("High Risk Medications with Average Daily Dose Criteria")]
    public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context)
    {
        CqlValueSet a_ = this.Digoxin_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = this.moreThanOneOrder(context, e_);
        bool? g_(MedicationRequest DigoxinOrdered)
        {
            CqlQuantity t_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity u_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? v_ = context.Operators.Greater(t_, u_);

            return v_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        bool? i_ = context.Operators.Exists<MedicationRequest>(h_);
        CqlValueSet j_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(k_, m_);
        IEnumerable<MedicationRequest> o_ = this.moreThanOneOrder(context, n_);
        bool? p_(MedicationRequest DoxepinOrdered)
        {
            CqlQuantity w_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity x_ = context.Operators.Quantity(6m, "mg/d");
            bool? y_ = context.Operators.Greater(w_, x_);

            return y_;
        };
        IEnumerable<MedicationRequest> q_ = context.Operators.Where<MedicationRequest>(o_, p_);
        bool? r_ = context.Operators.Exists<MedicationRequest>(q_);
        bool? s_ = context.Operators.Or(i_, r_);

        return s_;
    }

    [CqlDeclaration("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
        bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
        bool? c_ = this.Two_High_Risk_Medications_with_Prolonged_Duration(context);
        bool? d_ = context.Operators.Or(b_, c_);
        bool? e_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria(context);
        bool? f_ = context.Operators.Or(d_, e_);

        return f_;
    }

    [CqlDeclaration("More than One Antipsychotic Order")]
    public bool? More_than_One_Antipsychotic_Order(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = this.moreThanOneOrder(context, e_);
        bool? g_ = context.Operators.Exists<MedicationRequest>(f_);

        return g_;
    }

    [CqlDeclaration("Antipsychotic Index Prescription Start Date")]
    public CqlDateTime Antipsychotic_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = Status_1_8_000.Instance.isMedicationOrder(context, e_);
        bool? g_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime n_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
            CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, default);

            return q_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlDateTime i_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime r_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);

            return s_;
        };
        IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.ListSort<CqlDateTime>(k_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime m_ = context.Operators.First<CqlDateTime>(l_);

        return m_;
    }

    [CqlDeclaration("More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = this.moreThanOneOrder(context, e_);
        bool? g_ = context.Operators.Exists<MedicationRequest>(f_);

        return g_;
    }

    [CqlDeclaration("Benzodiazepine Index Prescription Start Date")]
    public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = Status_1_8_000.Instance.isMedicationOrder(context, e_);
        bool? g_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime n_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
            CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, default);

            return q_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlDateTime i_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime r_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);

            return s_;
        };
        IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.ListSort<CqlDateTime>(k_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime m_ = context.Operators.First<CqlDateTime>(l_);

        return m_;
    }

    [CqlDeclaration("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? a_ = this.More_than_One_Antipsychotic_Order(context);
        CqlValueSet b_ = this.Schizophrenia(context);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet d_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> f_ = context.Operators.Union<Condition>(c_, e_);
        bool? g_(Condition AntipsychoticTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
            CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
            CqlDateTime al_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ak_, al_, true, true);
            bool? an_ = context.Operators.Overlaps(ag_, am_, default);

            return an_;
        };
        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        bool? i_ = context.Operators.Exists<Condition>(h_);
        bool? j_ = context.Operators.Not(i_);
        bool? k_ = context.Operators.And(a_, j_);
        bool? l_ = this.More_than_One_Benzodiazepine_Order(context);
        CqlValueSet m_ = this.Seizure_Disorder(context);
        IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet o_ = this.REM_Sleep_Behavior_Disorder(context);
        IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> q_ = context.Operators.Union<Condition>(n_, p_);
        CqlValueSet r_ = this.Benzodiazepine_Withdrawal(context);
        IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet t_ = this.Alcohol_Withdrawal(context);
        IEnumerable<Condition> u_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> v_ = context.Operators.Union<Condition>(s_, u_);
        IEnumerable<Condition> w_ = context.Operators.Union<Condition>(q_, v_);
        CqlValueSet x_ = this.Generalized_Anxiety_Disorder(context);
        IEnumerable<Condition> y_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> z_ = context.Operators.Union<Condition>(w_, y_);
        bool? aa_(Condition BenzodiazepineTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
            CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
            CqlDateTime aq_ = context.Operators.Start(ap_);
            CqlQuantity ar_ = context.Operators.Quantity(1m, "year");
            CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);
            CqlDateTime at_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(as_, at_, true, true);
            bool? av_ = context.Operators.Overlaps(ao_, au_, default);

            return av_;
        };
        IEnumerable<Condition> ab_ = context.Operators.Where<Condition>(z_, aa_);
        bool? ac_ = context.Operators.Exists<Condition>(ab_);
        bool? ad_ = context.Operators.Not(ac_);
        bool? ae_ = context.Operators.And(l_, ad_);
        bool? af_ = context.Operators.Or(k_, ae_);

        return af_;
    }

    [CqlDeclaration("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        bool? a_ = this.Numerator_2(context);
        bool? b_ = this.Numerator_1(context);
        bool? d_ = context.Operators.Not(a_);
        bool? e_ = context.Operators.And(b_, d_);
        bool? f_ = context.Operators.Or(a_, e_);

        return f_;
    }

    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }

    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }

    #endregion Definition Methods

}
