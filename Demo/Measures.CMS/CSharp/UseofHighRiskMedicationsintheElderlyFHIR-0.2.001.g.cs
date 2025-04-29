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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("UseofHighRiskMedicationsintheElderlyFHIR", "0.2.001")]
public partial class UseofHighRiskMedicationsintheElderlyFHIR_0_2_001 : ILibrary, ISingleton<UseofHighRiskMedicationsintheElderlyFHIR_0_2_001>
{
    private UseofHighRiskMedicationsintheElderlyFHIR_0_2_001() {}

    public static UseofHighRiskMedicationsintheElderlyFHIR_0_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "UseofHighRiskMedicationsintheElderlyFHIR";
    public string Version => "0.2.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, QICoreCommon_2_1_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Alcohol Withdrawal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209", valueSetVersion: null)]
    public CqlValueSet Alcohol_Withdrawal(CqlContext _) => _Alcohol_Withdrawal;
    private static readonly CqlValueSet _Alcohol_Withdrawal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209", null);

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Benzodiazepine Withdrawal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208", valueSetVersion: null)]
    public CqlValueSet Benzodiazepine_Withdrawal(CqlContext _) => _Benzodiazepine_Withdrawal;
    private static readonly CqlValueSet _Benzodiazepine_Withdrawal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208", null);

    [CqlValueSetDefinition("Bipolar Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", valueSetVersion: null)]
    public CqlValueSet Bipolar_Disorder(CqlContext _) => _Bipolar_Disorder;
    private static readonly CqlValueSet _Bipolar_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", null);

    [CqlValueSetDefinition("Care Services in Long Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Desiccated Thyroid Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060", valueSetVersion: null)]
    public CqlValueSet Desiccated_Thyroid_Medications(CqlContext _) => _Desiccated_Thyroid_Medications;
    private static readonly CqlValueSet _Desiccated_Thyroid_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060", null);

    [CqlValueSetDefinition("Digoxin Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065", valueSetVersion: null)]
    public CqlValueSet Digoxin_Medications(CqlContext _) => _Digoxin_Medications;
    private static readonly CqlValueSet _Digoxin_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065", null);

    [CqlValueSetDefinition("Dipyridamole Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051", valueSetVersion: null)]
    public CqlValueSet Dipyridamole_Medications(CqlContext _) => _Dipyridamole_Medications;
    private static readonly CqlValueSet _Dipyridamole_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051", null);

    [CqlValueSetDefinition("Discharge Services Nursing Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Nursing_Facility(CqlContext _) => _Discharge_Services_Nursing_Facility;
    private static readonly CqlValueSet _Discharge_Services_Nursing_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", null);

    [CqlValueSetDefinition("Doxepin Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067", valueSetVersion: null)]
    public CqlValueSet Doxepin_Medications(CqlContext _) => _Doxepin_Medications;
    private static readonly CqlValueSet _Doxepin_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067", null);

    [CqlValueSetDefinition("Generalized Anxiety Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210", valueSetVersion: null)]
    public CqlValueSet Generalized_Anxiety_Disorder(CqlContext _) => _Generalized_Anxiety_Disorder;
    private static readonly CqlValueSet _Generalized_Anxiety_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210", null);

    [CqlValueSetDefinition("Guanfacine Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", valueSetVersion: null)]
    public CqlValueSet Guanfacine_Medications(CqlContext _) => _Guanfacine_Medications;
    private static readonly CqlValueSet _Guanfacine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Megestrol Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1247", valueSetVersion: null)]
    public CqlValueSet Megestrol_Medications(CqlContext _) => _Megestrol_Medications;
    private static readonly CqlValueSet _Megestrol_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1247", null);

    [CqlValueSetDefinition("Meperidine Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1248", valueSetVersion: null)]
    public CqlValueSet Meperidine_Medications(CqlContext _) => _Meperidine_Medications;
    private static readonly CqlValueSet _Meperidine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1248", null);

    [CqlValueSetDefinition("Meprobamate Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057", valueSetVersion: null)]
    public CqlValueSet Meprobamate_Medications(CqlContext _) => _Meprobamate_Medications;
    private static readonly CqlValueSet _Meprobamate_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057", null);

    [CqlValueSetDefinition("Nifedipine Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053", valueSetVersion: null)]
    public CqlValueSet Nifedipine_Medications(CqlContext _) => _Nifedipine_Medications;
    private static readonly CqlValueSet _Nifedipine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Potentially Harmful Antidepressants for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antidepressants_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Antidepressants_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Antidepressants_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054", null);

    [CqlValueSetDefinition("Potentially Harmful Antihistamines for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antihistamines_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Antihistamines_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Antihistamines_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043", null);

    [CqlValueSetDefinition("Potentially Harmful Antiinfectives for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antiinfectives_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Antiinfectives_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Antiinfectives_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481", null);

    [CqlValueSetDefinition("Potentially Harmful Antiparkinsonian Agents for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049", null);

    [CqlValueSetDefinition("Potentially Harmful Antipsychotics for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antipsychotics_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Antipsychotics_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Antipsychotics_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523", null);

    [CqlValueSetDefinition("Potentially Harmful Barbiturates for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Barbiturates_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Barbiturates_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Barbiturates_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055", null);

    [CqlValueSetDefinition("Potentially Harmful Benzodiazepines for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Benzodiazepines_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Benzodiazepines_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Benzodiazepines_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522", null);

    [CqlValueSetDefinition("Potentially Harmful Estrogens for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Estrogens_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Estrogens_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Estrogens_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058", null);

    [CqlValueSetDefinition("Potentially Harmful Gastrointestinal Antispasmodics for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050", null);

    [CqlValueSetDefinition("Potentially Harmful Nonbenzodiazepine Hypnotics for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480", null);

    [CqlValueSetDefinition("Potentially Harmful Pain Medications for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Pain_Medications_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Pain_Medications_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Pain_Medications_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063", null);

    [CqlValueSetDefinition("Potentially Harmful Skeletal Muscle Relaxants for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062", null);

    [CqlValueSetDefinition("Potentially Harmful Sulfonylureas for Older Adults", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059", valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Sulfonylureas_for_Older_Adults(CqlContext _) => _Potentially_Harmful_Sulfonylureas_for_Older_Adults;
    private static readonly CqlValueSet _Potentially_Harmful_Sulfonylureas_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("REM Sleep Behavior Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207", valueSetVersion: null)]
    public CqlValueSet REM_Sleep_Behavior_Disorder(CqlContext _) => _REM_Sleep_Behavior_Disorder;
    private static readonly CqlValueSet _REM_Sleep_Behavior_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207", null);

    [CqlValueSetDefinition("Schizophrenia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205", valueSetVersion: null)]
    public CqlValueSet Schizophrenia(CqlContext _) => _Schizophrenia;
    private static readonly CqlValueSet _Schizophrenia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205", null);

    [CqlValueSetDefinition("Seizure Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206", valueSetVersion: null)]
    public CqlValueSet Seizure_Disorder(CqlContext _) => _Seizure_Disorder;
    private static readonly CqlValueSet _Seizure_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("1 ML digoxin 0.1 MG/ML Injection", codeId: "204504", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _1_ML_digoxin_0_1_MG_ML_Injection(CqlContext _) => __1_ML_digoxin_0_1_MG_ML_Injection;
    private static readonly CqlCode __1_ML_digoxin_0_1_MG_ML_Injection = new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("2 ML digoxin 0.25 MG/ML Injection", codeId: "104208", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _2_ML_digoxin_0_25_MG_ML_Injection(CqlContext _) => __2_ML_digoxin_0_25_MG_ML_Injection;
    private static readonly CqlCode __2_ML_digoxin_0_25_MG_ML_Injection = new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("digoxin 0.05 MG/ML Oral Solution", codeId: "393245", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_05_MG_ML_Oral_Solution(CqlContext _) => _digoxin_0_05_MG_ML_Oral_Solution;
    private static readonly CqlCode _digoxin_0_05_MG_ML_Oral_Solution = new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("digoxin 0.0625 MG Oral Tablet", codeId: "245273", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_0625_MG_Oral_Tablet(CqlContext _) => _digoxin_0_0625_MG_Oral_Tablet;
    private static readonly CqlCode _digoxin_0_0625_MG_Oral_Tablet = new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("digoxin 0.125 MG Oral Tablet", codeId: "197604", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_125_MG_Oral_Tablet(CqlContext _) => _digoxin_0_125_MG_Oral_Tablet;
    private static readonly CqlCode _digoxin_0_125_MG_Oral_Tablet = new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("digoxin 0.25 MG Oral Tablet", codeId: "197606", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_25_MG_Oral_Tablet(CqlContext _) => _digoxin_0_25_MG_Oral_Tablet;
    private static readonly CqlCode _digoxin_0_25_MG_Oral_Tablet = new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 10 MG Oral Capsule", codeId: "1000048", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_10_MG_Oral_Capsule(CqlContext _) => _doxepin_10_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_10_MG_Oral_Capsule = new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 10 MG/ML Oral Solution", codeId: "1000054", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_10_MG_ML_Oral_Solution(CqlContext _) => _doxepin_10_MG_ML_Oral_Solution;
    private static readonly CqlCode _doxepin_10_MG_ML_Oral_Solution = new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 100 MG Oral Capsule", codeId: "1000058", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_100_MG_Oral_Capsule(CqlContext _) => _doxepin_100_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_100_MG_Oral_Capsule = new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 150 MG Oral Capsule", codeId: "1000064", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_150_MG_Oral_Capsule(CqlContext _) => _doxepin_150_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_150_MG_Oral_Capsule = new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 25 MG Oral Capsule", codeId: "1000070", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_25_MG_Oral_Capsule(CqlContext _) => _doxepin_25_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_25_MG_Oral_Capsule = new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 3 MG Oral Tablet", codeId: "966787", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_3_MG_Oral_Tablet(CqlContext _) => _doxepin_3_MG_Oral_Tablet;
    private static readonly CqlCode _doxepin_3_MG_Oral_Tablet = new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 50 MG Oral Capsule", codeId: "1000076", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_50_MG_Oral_Capsule(CqlContext _) => _doxepin_50_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_50_MG_Oral_Capsule = new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 6 MG Oral Tablet", codeId: "966793", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_6_MG_Oral_Tablet(CqlContext _) => _doxepin_6_MG_Oral_Tablet;
    private static readonly CqlCode _doxepin_6_MG_Oral_Tablet = new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("doxepin 75 MG Oral Capsule", codeId: "1000097", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_75_MG_Oral_Capsule(CqlContext _) => _doxepin_75_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_75_MG_Oral_Capsule = new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("ergoloid mesylates, USP 1 MG Oral Tablet", codeId: "318179", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode ergoloid_mesylates__USP_1_MG_Oral_Tablet(CqlContext _) => _ergoloid_mesylates__USP_1_MG_Oral_Tablet;
    private static readonly CqlCode _ergoloid_mesylates__USP_1_MG_Oral_Tablet = new CqlCode("318179", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);

    [CqlCodeDefinition("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional", codeId: "99211", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext _) => _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional;
    private static readonly CqlCode _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional = new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("RXNORM")]
    public CqlCodeSystem RXNORM(CqlContext _) => _RXNORM;
    private static readonly CqlCodeSystem _RXNORM = new CqlCodeSystem();

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzg_, true, true);
        object xzzzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("UseofHighRiskMedicationsintheElderlyFHIR-0.2.001", "Measurement Period", xzzzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzj_);

        return xzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzl_ = this.Office_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzn_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzs_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzw_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzy_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzza_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzc_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzze_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzi_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzk_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzo_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? yzzzzzzzzzzzzzzzzzzr_(Encounter E)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzzzzzzy_ = E?.Type;
            CqlConcept yzzzzzzzzzzzzzzzzzzz_(CodeableConcept @this)
            {
                CqlConcept zzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzz_);
            bool? zzzzzzzzzzzzzzzzzzzb_(CqlConcept T)
            {
                CqlCode zzzzzzzzzzzzzzzzzzzf_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept zzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzf_);
                bool? zzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(T, zzzzzzzzzzzzzzzzzzzg_);

                return zzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<CqlConcept>(zzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzb_);
            bool? zzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<CqlConcept>(zzzzzzzzzzzzzzzzzzzc_);

            return zzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isEncounterPerformed(context, yzzzzzzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzzzzzzw_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            Period zzzzzzzzzzzzzzzzzzzj_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzj_);
            bool? zzzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzk_, default);

            return zzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzw_);

        return yzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzzzzzn_ = zzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzzzzn_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzq_);
        CqlDate zzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzr_);
        int? zzzzzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzs_, "year");
        bool? zzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzt_, 65);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounters(context);
        bool? zzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzw_);

        return zzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return zzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzzzzz_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? azzzzzzzzzzzzzzzzzzza_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? azzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzza_);

        return azzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("moreThanOneOrder")]
    public IEnumerable<MedicationRequest> moreThanOneOrder(CqlContext context, IEnumerable<MedicationRequest> Medication)
    {
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzd_(MedicationRequest OrderMedication1)
        {
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
            bool? azzzzzzzzzzzzzzzzzzzj_(MedicationRequest OrderMedication2)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzn_ = OrderMedication1?.AuthoredOnElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
                bool? azzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzp_, default);
                MedicationRequest.DispenseRequestComponent azzzzzzzzzzzzzzzzzzzr_ = OrderMedication1?.DispenseRequest;
                UnsignedInt azzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzr_?.NumberOfRepeatsAllowedElement;
                int? azzzzzzzzzzzzzzzzzzzt_ = azzzzzzzzzzzzzzzzzzzs_?.Value;
                bool? azzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzt_, 1);
                bool? azzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzn_);
                CqlDate azzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzx_);
                FhirDateTime azzzzzzzzzzzzzzzzzzzz_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzz_);
                CqlDate bzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzza_);
                bool? bzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(azzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzb_);
                bool? bzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzn_);
                bool? bzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzp_, default);
                bool? bzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzz_);
                bool? bzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzp_, default);
                bool? bzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzm_);
                bool? bzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzn_);
                CqlDate bzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzz_);
                CqlDate bzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzt_);
                bool? bzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzn_);
                bool? bzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzp_, default);
                bool? czzzzzzzzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzb_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate czzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzc_);
                CqlDate czzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate czzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzg_);
                CqlDate czzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzh_);
                bool? czzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzi_);
                bool? czzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(czzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzk_);
                CqlDate czzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzn_);
                bool? czzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzp_, default);
                bool? czzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzq_);
                CqlDate czzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzt_);
                bool? czzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzp_, default);
                bool? czzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzw_);
                bool? czzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzx_);

                return czzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzj_);
            MedicationRequest azzzzzzzzzzzzzzzzzzzl_(MedicationRequest OrderMedication2) =>
                OrderMedication1;
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, MedicationRequest>(azzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzl_);

            return azzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(azzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzd_);
        MedicationRequest azzzzzzzzzzzzzzzzzzzf_(MedicationRequest OrderMedication1) =>
            OrderMedication1;
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<MedicationRequest, MedicationRequest>(azzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<MedicationRequest>(azzzzzzzzzzzzzzzzzzzg_);

        return azzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzz_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzze_ = this.moreThanOneOrder(context, dzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzf_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzk_ = this.moreThanOneOrder(context, dzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzm_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzr_ = this.moreThanOneOrder(context, dzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzs_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzx_ = this.moreThanOneOrder(context, dzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzza_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzf_ = this.moreThanOneOrder(context, ezzzzzzzzzzzzzzzzzzze_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzg_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzl_ = this.moreThanOneOrder(context, ezzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzo_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzt_ = this.moreThanOneOrder(context, ezzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzu_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzz_ = this.moreThanOneOrder(context, ezzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzza_);
        CqlCode fzzzzzzzzzzzzzzzzzzzc_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzj_ = this.moreThanOneOrder(context, fzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzk_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzp_ = this.moreThanOneOrder(context, fzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzs_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzx_ = this.moreThanOneOrder(context, fzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzy_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzd_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzg_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzl_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzm_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzr_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzu_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzz_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzza_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzf_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzi_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzn_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzo_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzt_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzu_);

        return hzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("MedicationRequestPeriodInDays")]
    public decimal? MedicationRequestPeriodInDays(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] hzzzzzzzzzzzzzzzzzzzw_ = [
            Request,
        ];
        decimal? hzzzzzzzzzzzzzzzzzzzx_(MedicationRequest R)
        {
            MedicationRequest.DispenseRequestComponent izzzzzzzzzzzzzzzzzzzb_ = R?.DispenseRequest;
            Duration izzzzzzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzzzzzb_?.ExpectedSupplyDuration;
            CqlQuantity izzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity izzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertQuantity(izzzzzzzzzzzzzzzzzzzd_, "d");
            decimal? izzzzzzzzzzzzzzzzzzzf_ = izzzzzzzzzzzzzzzzzzze_?.value;
            Quantity izzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzb_?.Quantity;
            CqlQuantity izzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzzzzh_);
            decimal? izzzzzzzzzzzzzzzzzzzj_ = izzzzzzzzzzzzzzzzzzzi_?.value;
            List<Dosage> izzzzzzzzzzzzzzzzzzzk_ = R?.DosageInstruction;
            Dosage izzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzk_);
            List<Dosage.DoseAndRateComponent> izzzzzzzzzzzzzzzzzzzm_ = izzzzzzzzzzzzzzzzzzzl_?.DoseAndRate;
            Dosage.DoseAndRateComponent izzzzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)izzzzzzzzzzzzzzzzzzzm_);
            DataType izzzzzzzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzzzzzzn_?.Dose;
            object izzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlQuantity>);
            Dosage izzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzk_);
            List<Dosage.DoseAndRateComponent> izzzzzzzzzzzzzzzzzzzt_ = izzzzzzzzzzzzzzzzzzzs_?.DoseAndRate;
            Dosage.DoseAndRateComponent izzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)izzzzzzzzzzzzzzzzzzzt_);
            DataType izzzzzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzzzzu_?.Dose;
            object izzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzv_);
            decimal? izzzzzzzzzzzzzzzzzzzx_ = (izzzzzzzzzzzzzzzzzzzq_ ?? izzzzzzzzzzzzzzzzzzzw_ as CqlQuantity)?.value;
            Dosage izzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzk_);
            Timing jzzzzzzzzzzzzzzzzzzza_ = izzzzzzzzzzzzzzzzzzzz_?.Timing;
            Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzza_?.Repeat;
            PositiveInt jzzzzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzzzzb_?.FrequencyMaxElement;
            int? jzzzzzzzzzzzzzzzzzzzd_ = jzzzzzzzzzzzzzzzzzzzc_?.Value;
            Dosage jzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzk_);
            Timing jzzzzzzzzzzzzzzzzzzzg_ = jzzzzzzzzzzzzzzzzzzzf_?.Timing;
            Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzg_?.Repeat;
            PositiveInt jzzzzzzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzzzzzzh_?.FrequencyElement;
            int? jzzzzzzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzzzzzzi_?.Value;
            Dosage jzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzk_);
            Timing jzzzzzzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzzzzzzl_?.Timing;
            Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzzzzzm_?.Repeat;
            FhirDecimal jzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzn_?.PeriodElement;
            decimal? jzzzzzzzzzzzzzzzzzzzp_ = jzzzzzzzzzzzzzzzzzzzo_?.Value;
            Dosage jzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzk_);
            Timing jzzzzzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzzzzzr_?.Timing;
            Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzzzzzzzs_?.Repeat;
            Code<Timing.UnitsOfTime> jzzzzzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzzzzzt_?.PeriodUnitElement;
            Timing.UnitsOfTime? jzzzzzzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzzzzzzu_?.Value;
            string jzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzx_ = CumulativeMedicationDuration_4_1_000.Instance.Quantity(context, jzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzw_);
            decimal? jzzzzzzzzzzzzzzzzzzzy_ = CumulativeMedicationDuration_4_1_000.Instance.ToDaily(context, jzzzzzzzzzzzzzzzzzzzd_ ?? jzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzx_);
            Dosage kzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzk_);
            Timing kzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzza_?.Timing;
            Timing.RepeatComponent kzzzzzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzzzzzb_?.Repeat;
            List<Time> kzzzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzzzc_?.TimeOfDayElement;
            IEnumerable<CqlTime> kzzzzzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(kzzzzzzzzzzzzzzzzzzzd_, "value");
            int? kzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Count<CqlTime>(kzzzzzzzzzzzzzzzzzzze_);
            decimal? kzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzzzzzzzzzzzzzf_);
            decimal? kzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Multiply(izzzzzzzzzzzzzzzzzzzx_, (jzzzzzzzzzzzzzzzzzzzy_ ?? kzzzzzzzzzzzzzzzzzzzg_) ?? 1.0m);
            decimal? kzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Divide(izzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzh_);
            UnsignedInt kzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzb_?.NumberOfRepeatsAllowedElement;
            int? kzzzzzzzzzzzzzzzzzzzl_ = kzzzzzzzzzzzzzzzzzzzk_?.Value;
            int? kzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(1, kzzzzzzzzzzzzzzzzzzzl_ ?? 0);
            decimal? kzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzzzzzzzzzzzzzm_);
            decimal? kzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Multiply(izzzzzzzzzzzzzzzzzzzf_ ?? kzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<decimal?> hzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<MedicationRequest, decimal?>((IEnumerable<MedicationRequest>)hzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<decimal?> hzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<decimal?>(hzzzzzzzzzzzzzzzzzzzy_);
        decimal? izzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<decimal?>(hzzzzzzzzzzzzzzzzzzzz_);

        return izzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzp_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzu_ = this.moreThanOneOrder(context, kzzzzzzzzzzzzzzzzzzzt_);
        decimal? kzzzzzzzzzzzzzzzzzzzv_(MedicationRequest AntiInfectives)
        {
            decimal? lzzzzzzzzzzzzzzzzzzza_ = this.MedicationRequestPeriodInDays(context, AntiInfectives);

            return lzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<decimal?> kzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<MedicationRequest, decimal?>(kzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzv_);
        decimal? kzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Sum(kzzzzzzzzzzzzzzzzzzzw_);
        decimal? kzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(90);
        bool? kzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Greater(kzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzy_);

        return kzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("MedicationStrengthPerUnit")]
    public CqlQuantity MedicationStrengthPerUnit(CqlContext context, CqlConcept Strength)
    {
        CqlQuantity lzzzzzzzzzzzzzzzzzzzb_()
        {
            bool lzzzzzzzzzzzzzzzzzzzc_()
            {
                CqlCode lzzzzzzzzzzzzzzzzzzzr_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
                CqlConcept lzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzr_);
                bool? lzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(Strength, lzzzzzzzzzzzzzzzzzzzs_);

                return lzzzzzzzzzzzzzzzzzzzt_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzd_()
            {
                CqlCode lzzzzzzzzzzzzzzzzzzzu_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
                CqlConcept lzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzu_);
                bool? lzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(Strength, lzzzzzzzzzzzzzzzzzzzv_);

                return lzzzzzzzzzzzzzzzzzzzw_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzze_()
            {
                CqlCode lzzzzzzzzzzzzzzzzzzzx_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
                CqlConcept lzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzx_);
                bool? lzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(Strength, lzzzzzzzzzzzzzzzzzzzy_);

                return lzzzzzzzzzzzzzzzzzzzz_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzf_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzza_ = this.digoxin_0_125_MG_Oral_Tablet(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzza_);
                bool? mzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzb_);

                return mzzzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzg_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzd_ = this.digoxin_0_25_MG_Oral_Tablet(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzd_);
                bool? mzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzze_);

                return mzzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzh_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzg_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzg_);
                bool? mzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzh_);

                return mzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzi_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzj_ = this.doxepin_3_MG_Oral_Tablet(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzj_);
                bool? mzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzk_);

                return mzzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzj_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzm_ = this.doxepin_6_MG_Oral_Tablet(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzm_);
                bool? mzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzn_);

                return mzzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzk_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzp_ = this.doxepin_10_MG_Oral_Capsule(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzp_);
                bool? mzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzq_);

                return mzzzzzzzzzzzzzzzzzzzr_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzl_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzs_ = this.doxepin_10_MG_ML_Oral_Solution(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzs_);
                bool? mzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzt_);

                return mzzzzzzzzzzzzzzzzzzzu_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzm_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzv_ = this.doxepin_25_MG_Oral_Capsule(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzv_);
                bool? mzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzw_);

                return mzzzzzzzzzzzzzzzzzzzx_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzn_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzy_ = this.doxepin_50_MG_Oral_Capsule(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzy_);
                bool? nzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzz_);

                return nzzzzzzzzzzzzzzzzzzza_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzo_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzb_ = this.doxepin_75_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzb_);
                bool? nzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzc_);

                return nzzzzzzzzzzzzzzzzzzzd_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzp_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzze_ = this.doxepin_100_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzze_);
                bool? nzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzf_);

                return nzzzzzzzzzzzzzzzzzzzg_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzq_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzh_ = this.doxepin_150_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzh_);
                bool? nzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzi_);

                return nzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            if (lzzzzzzzzzzzzzzzzzzzc_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(0.05m, "mg/mL");

                return nzzzzzzzzzzzzzzzzzzzk_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzd_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(0.0625m, "mg");

                return nzzzzzzzzzzzzzzzzzzzl_;
            }
            else if (lzzzzzzzzzzzzzzzzzzze_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(0.1m, "mg/mL");

                return nzzzzzzzzzzzzzzzzzzzm_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzf_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(0.125m, "mg");

                return nzzzzzzzzzzzzzzzzzzzn_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzg_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(0.25m, "mg");

                return nzzzzzzzzzzzzzzzzzzzo_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzh_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(0.25m, "mg/mL");

                return nzzzzzzzzzzzzzzzzzzzp_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzi_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(3m, "mg");

                return nzzzzzzzzzzzzzzzzzzzq_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzj_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(6m, "mg");

                return nzzzzzzzzzzzzzzzzzzzr_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzk_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(10m, "mg");

                return nzzzzzzzzzzzzzzzzzzzs_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzl_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(10m, "mg/mL");

                return nzzzzzzzzzzzzzzzzzzzt_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzm_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(25m, "mg");

                return nzzzzzzzzzzzzzzzzzzzu_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzn_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(50m, "mg");

                return nzzzzzzzzzzzzzzzzzzzv_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzo_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(75m, "mg");

                return nzzzzzzzzzzzzzzzzzzzw_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzp_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(100m, "mg");

                return nzzzzzzzzzzzzzzzzzzzx_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzq_())
            {
                CqlQuantity nzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(150m, "mg");

                return nzzzzzzzzzzzzzzzzzzzy_;
            }
            else
            {
                return default;
            }
        };

        return lzzzzzzzzzzzzzzzzzzzb_();
    }


    [CqlExpressionDefinition("averageDailyDose")]
    public CqlQuantity averageDailyDose(CqlContext context, MedicationRequest MedicationRequest)
    {
        MedicationRequest[] nzzzzzzzzzzzzzzzzzzzz_ = [
            MedicationRequest,
        ];
        CqlQuantity ozzzzzzzzzzzzzzzzzzza_(MedicationRequest Order)
        {
            CqlQuantity ozzzzzzzzzzzzzzzzzzze_()
            {
                bool ozzzzzzzzzzzzzzzzzzzf_()
                {
                    decimal? ozzzzzzzzzzzzzzzzzzzg_ = this.MedicationRequestPeriodInDays(context, Order);
                    bool? ozzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzg_ is null));
                    CqlConcept ozzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzj_ = this.MedicationStrengthPerUnit(context, ozzzzzzzzzzzzzzzzzzzi_);
                    string ozzzzzzzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzzzzzzj_?.unit;
                    bool? ozzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzk_, "mg");
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzn_ = this.MedicationStrengthPerUnit(context, ozzzzzzzzzzzzzzzzzzzi_);
                    string ozzzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzzn_?.unit;
                    bool? ozzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzo_, "mg/mL");
                    MedicationRequest.DispenseRequestComponent ozzzzzzzzzzzzzzzzzzzq_ = Order?.DispenseRequest;
                    Quantity ozzzzzzzzzzzzzzzzzzzr_ = ozzzzzzzzzzzzzzzzzzzq_?.Quantity;
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ozzzzzzzzzzzzzzzzzzzr_);
                    string ozzzzzzzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzzzzzzs_?.unit;
                    bool? ozzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzt_, "mL");
                    bool? ozzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzu_);
                    bool? ozzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzv_);
                    bool? ozzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzw_);

                    return ozzzzzzzzzzzzzzzzzzzx_ ?? false;
                };
                if (ozzzzzzzzzzzzzzzzzzzf_())
                {
                    MedicationRequest.DispenseRequestComponent ozzzzzzzzzzzzzzzzzzzy_ = Order?.DispenseRequest;
                    Quantity ozzzzzzzzzzzzzzzzzzzz_ = ozzzzzzzzzzzzzzzzzzzy_?.Quantity;
                    CqlQuantity pzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ozzzzzzzzzzzzzzzzzzzz_);
                    CqlConcept pzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzc_ = this.MedicationStrengthPerUnit(context, pzzzzzzzzzzzzzzzzzzzb_);
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Multiply(pzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzc_);
                    decimal? pzzzzzzzzzzzzzzzzzzze_ = this.MedicationRequestPeriodInDays(context, Order);
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Divide(pzzzzzzzzzzzzzzzzzzzd_, new CqlQuantity(pzzzzzzzzzzzzzzzzzzze_, "d"));

                    return pzzzzzzzzzzzzzzzzzzzf_;
                }
                else
                {
                    return default;
                }
            };

            return ozzzzzzzzzzzzzzzzzzze_();
        };
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, CqlQuantity>((IEnumerable<MedicationRequest>)nzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlQuantity>(ozzzzzzzzzzzzzzzzzzzb_);
        CqlQuantity ozzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<CqlQuantity>(ozzzzzzzzzzzzzzzzzzzc_);

        return ozzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("High Risk Medications with Average Daily Dose Criteria")]
    public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzg_ = this.Digoxin_Medications(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzl_ = this.moreThanOneOrder(context, pzzzzzzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzzzzzzm_(MedicationRequest DigoxinOrdered)
        {
            CqlQuantity pzzzzzzzzzzzzzzzzzzzz_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity qzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? qzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Greater(pzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzza_);

            return qzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzm_);
        bool? pzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzp_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzu_ = this.moreThanOneOrder(context, pzzzzzzzzzzzzzzzzzzzt_);
        bool? pzzzzzzzzzzzzzzzzzzzv_(MedicationRequest DoxepinOrdered)
        {
            CqlQuantity qzzzzzzzzzzzzzzzzzzzc_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(6m, "mg/d");
            bool? qzzzzzzzzzzzzzzzzzzze_ = context.Operators.Greater(qzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzd_);

            return qzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzv_);
        bool? pzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzx_);

        return pzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzf_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
        bool? qzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzf_);
        bool? qzzzzzzzzzzzzzzzzzzzh_ = this.Two_High_Risk_Medications_with_Prolonged_Duration(context);
        bool? qzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzzzzzzj_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria(context);
        bool? qzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzj_);

        return qzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("More than One Antipsychotic Order")]
    public bool? More_than_One_Antipsychotic_Order(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzl_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzq_ = this.moreThanOneOrder(context, qzzzzzzzzzzzzzzzzzzzp_);
        bool? qzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzq_);

        return qzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Antipsychotic Index Prescription Start Date")]
    public CqlDateTime Antipsychotic_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzs_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isMedicationOrder(context, qzzzzzzzzzzzzzzzzzzzw_);
        bool? qzzzzzzzzzzzzzzzzzzzy_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime rzzzzzzzzzzzzzzzzzzzf_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime rzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzh_, default);

            return rzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzy_);
        CqlDateTime rzzzzzzzzzzzzzzzzzzza_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime rzzzzzzzzzzzzzzzzzzzj_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime rzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDateTime> rzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, CqlDateTime>(qzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDateTime> rzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDateTime> rzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ListSort<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime rzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzd_);

        return rzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzl_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzq_ = this.moreThanOneOrder(context, rzzzzzzzzzzzzzzzzzzzp_);
        bool? rzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzq_);

        return rzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Benzodiazepine Index Prescription Start Date")]
    public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzs_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isMedicationOrder(context, rzzzzzzzzzzzzzzzzzzzw_);
        bool? rzzzzzzzzzzzzzzzzzzzy_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime szzzzzzzzzzzzzzzzzzzf_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime szzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzh_, default);

            return szzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzy_);
        CqlDateTime szzzzzzzzzzzzzzzzzzza_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime szzzzzzzzzzzzzzzzzzzj_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime szzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzj_);

            return szzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, CqlDateTime>(rzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDateTime>(szzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzd_ = context.Operators.ListSort<CqlDateTime>(szzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime szzzzzzzzzzzzzzzzzzze_ = context.Operators.First<CqlDateTime>(szzzzzzzzzzzzzzzzzzzd_);

        return szzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzl_ = this.More_than_One_Antipsychotic_Order(context);
        CqlValueSet szzzzzzzzzzzzzzzzzzzm_ = this.Schizophrenia(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzo_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzp_);
        bool? szzzzzzzzzzzzzzzzzzzr_(Condition AntipsychoticTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "year");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzw_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzw_, true, true);
            bool? tzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Overlaps(tzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzx_, default);

            return tzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzr_);
        bool? szzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzs_);
        bool? szzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzt_);
        bool? szzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzu_);
        bool? szzzzzzzzzzzzzzzzzzzw_ = this.More_than_One_Benzodiazepine_Order(context);
        CqlValueSet szzzzzzzzzzzzzzzzzzzx_ = this.Seizure_Disorder(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzz_ = this.REM_Sleep_Behavior_Disorder(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzc_ = this.Benzodiazepine_Withdrawal(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzze_ = this.Alcohol_Withdrawal(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzi_ = this.Generalized_Anxiety_Disorder(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzj_);
        bool? tzzzzzzzzzzzzzzzzzzzl_(Condition BenzodiazepineTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "year");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzze_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzze_, true, true);
            bool? uzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Overlaps(tzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzf_, default);

            return uzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzl_);
        bool? tzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzm_);
        bool? tzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not(tzzzzzzzzzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzo_);
        bool? tzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzp_);

        return tzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzh_ = this.Numerator_2(context);
        bool? uzzzzzzzzzzzzzzzzzzzi_ = this.Numerator_1(context);
        bool? uzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzh_);
        bool? uzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzk_);
        bool? uzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzl_);

        return uzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> uzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return uzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return uzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
