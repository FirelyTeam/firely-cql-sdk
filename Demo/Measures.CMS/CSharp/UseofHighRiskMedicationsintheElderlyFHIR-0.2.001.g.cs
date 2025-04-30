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
        CqlDateTime azzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzr_, true, true);
        object azzzzzzzzzzzzzzzzzt_ = context.ResolveParameter("UseofHighRiskMedicationsintheElderlyFHIR-0.2.001", "Measurement Period", azzzzzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzu_);

        return azzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzw_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzy_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzz_);
        CqlValueSet bzzzzzzzzzzzzzzzzzb_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzd_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzf_);
        CqlValueSet bzzzzzzzzzzzzzzzzzh_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzj_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzl_);
        CqlValueSet bzzzzzzzzzzzzzzzzzn_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzp_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzr_);
        CqlValueSet bzzzzzzzzzzzzzzzzzt_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzv_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzx_);
        CqlValueSet bzzzzzzzzzzzzzzzzzz_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? czzzzzzzzzzzzzzzzzc_(Encounter E)
        {
            List<CodeableConcept> czzzzzzzzzzzzzzzzzj_ = E?.Type;
            CqlConcept czzzzzzzzzzzzzzzzzk_(CodeableConcept @this)
            {
                CqlConcept czzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return czzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzk_);
            bool? czzzzzzzzzzzzzzzzzm_(CqlConcept T)
            {
                CqlCode czzzzzzzzzzzzzzzzzq_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept czzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzzzzzq_);
                bool? czzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(T, czzzzzzzzzzzzzzzzzr_);

                return czzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzn_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzm_);
            bool? czzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzzzzzn_);

            return czzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isEncounterPerformed(context, czzzzzzzzzzzzzzzzzf_);
        bool? czzzzzzzzzzzzzzzzzh_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            Period czzzzzzzzzzzzzzzzzu_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzu_);
            bool? czzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzv_, default);

            return czzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzh_);

        return czzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzx_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzzx_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzy_?.Value;
        CqlDate dzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzzzzzzzzzzzzzc_ = context.Operators.End(dzzzzzzzzzzzzzzzzzb_);
        CqlDate dzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzc_);
        int? dzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzd_, "year");
        bool? dzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzze_, 65);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounters(context);
        bool? dzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzg_);
        bool? dzzzzzzzzzzzzzzzzzi_ = context.Operators.And(dzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzh_);

        return dzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);

        return dzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzzzzk_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? dzzzzzzzzzzzzzzzzzl_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? dzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("moreThanOneOrder")]
    public IEnumerable<MedicationRequest> moreThanOneOrder(CqlContext context, IEnumerable<MedicationRequest> Medication)
    {
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzo_(MedicationRequest OrderMedication1)
        {
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
            bool? dzzzzzzzzzzzzzzzzzu_(MedicationRequest OrderMedication2)
            {
                FhirDateTime dzzzzzzzzzzzzzzzzzy_ = OrderMedication1?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
                bool? ezzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzza_, default);
                MedicationRequest.DispenseRequestComponent ezzzzzzzzzzzzzzzzzc_ = OrderMedication1?.DispenseRequest;
                UnsignedInt ezzzzzzzzzzzzzzzzzd_ = ezzzzzzzzzzzzzzzzzc_?.NumberOfRepeatsAllowedElement;
                int? ezzzzzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzzzzd_?.Value;
                bool? ezzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzze_, 1);
                bool? ezzzzzzzzzzzzzzzzzg_ = context.Operators.And(ezzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzf_);
                CqlDateTime ezzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzy_);
                CqlDate ezzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzi_);
                FhirDateTime ezzzzzzzzzzzzzzzzzk_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzk_);
                CqlDate ezzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzl_);
                bool? ezzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzm_);
                bool? ezzzzzzzzzzzzzzzzzo_ = context.Operators.Not(ezzzzzzzzzzzzzzzzzn_);
                CqlDateTime ezzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzy_);
                bool? ezzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzza_, default);
                bool? ezzzzzzzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzs_);
                CqlDateTime ezzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzk_);
                bool? ezzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzza_, default);
                bool? ezzzzzzzzzzzzzzzzzy_ = context.Operators.And(ezzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzx_);
                bool? ezzzzzzzzzzzzzzzzzz_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzy_);
                CqlDateTime fzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzy_);
                CqlDate fzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzb_);
                CqlDateTime fzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzk_);
                CqlDate fzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzze_);
                bool? fzzzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzf_);
                CqlDateTime fzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzy_);
                bool? fzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzza_, default);
                bool? fzzzzzzzzzzzzzzzzzl_ = context.Operators.And(fzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate fzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzm_);
                CqlDateTime fzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzzn_);
                CqlDate fzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate fzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzq_);
                CqlDateTime fzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzzr_);
                CqlDate fzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzs_);
                bool? fzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzt_);
                bool? fzzzzzzzzzzzzzzzzzv_ = context.Operators.Not(fzzzzzzzzzzzzzzzzzu_);
                bool? fzzzzzzzzzzzzzzzzzw_ = context.Operators.And(fzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzv_);
                CqlDate fzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzm_);
                CqlDateTime fzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzzy_);
                bool? gzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzza_, default);
                bool? gzzzzzzzzzzzzzzzzzc_ = context.Operators.And(fzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzb_);
                CqlDate gzzzzzzzzzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzq_);
                CqlDateTime gzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(gzzzzzzzzzzzzzzzzze_);
                bool? gzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzza_, default);
                bool? gzzzzzzzzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzh_);
                bool? gzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzi_);

                return gzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzu_);
            MedicationRequest dzzzzzzzzzzzzzzzzzw_(MedicationRequest OrderMedication2) =>
                OrderMedication1;
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<MedicationRequest, MedicationRequest>(dzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzw_);

            return dzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(dzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzo_);
        MedicationRequest dzzzzzzzzzzzzzzzzzq_(MedicationRequest OrderMedication1) =>
            OrderMedication1;
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<MedicationRequest, MedicationRequest>(dzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<MedicationRequest>(dzzzzzzzzzzzzzzzzzr_);

        return dzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzk_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzp_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzo_);
        CqlValueSet gzzzzzzzzzzzzzzzzzq_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzv_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzv_);
        CqlValueSet gzzzzzzzzzzzzzzzzzx_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzc_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzb_);
        CqlValueSet hzzzzzzzzzzzzzzzzzd_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzi_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzj_);
        CqlValueSet hzzzzzzzzzzzzzzzzzl_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzq_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzp_);
        CqlValueSet hzzzzzzzzzzzzzzzzzr_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzw_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzw_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzx_);
        CqlValueSet hzzzzzzzzzzzzzzzzzz_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzze_ = this.moreThanOneOrder(context, izzzzzzzzzzzzzzzzzd_);
        CqlValueSet izzzzzzzzzzzzzzzzzf_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzk_ = this.moreThanOneOrder(context, izzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzl_);
        CqlCode izzzzzzzzzzzzzzzzzn_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzu_ = this.moreThanOneOrder(context, izzzzzzzzzzzzzzzzzt_);
        CqlValueSet izzzzzzzzzzzzzzzzzv_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzza_ = this.moreThanOneOrder(context, izzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzb_);
        CqlValueSet jzzzzzzzzzzzzzzzzzd_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzi_ = this.moreThanOneOrder(context, jzzzzzzzzzzzzzzzzzh_);
        CqlValueSet jzzzzzzzzzzzzzzzzzj_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzm_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzo_ = this.moreThanOneOrder(context, jzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzp_);
        CqlValueSet jzzzzzzzzzzzzzzzzzr_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzw_ = this.moreThanOneOrder(context, jzzzzzzzzzzzzzzzzzv_);
        CqlValueSet jzzzzzzzzzzzzzzzzzx_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzc_ = this.moreThanOneOrder(context, kzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzd_);
        CqlValueSet kzzzzzzzzzzzzzzzzzf_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzk_ = this.moreThanOneOrder(context, kzzzzzzzzzzzzzzzzzj_);
        CqlValueSet kzzzzzzzzzzzzzzzzzl_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzq_ = this.moreThanOneOrder(context, kzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzr_);
        CqlValueSet kzzzzzzzzzzzzzzzzzt_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzw_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzy_ = this.moreThanOneOrder(context, kzzzzzzzzzzzzzzzzzx_);
        CqlValueSet kzzzzzzzzzzzzzzzzzz_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzze_ = this.moreThanOneOrder(context, lzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("MedicationRequestPeriodInDays")]
    public decimal? MedicationRequestPeriodInDays(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] lzzzzzzzzzzzzzzzzzh_ = [
            Request,
        ];
        decimal? lzzzzzzzzzzzzzzzzzi_(MedicationRequest R)
        {
            MedicationRequest.DispenseRequestComponent lzzzzzzzzzzzzzzzzzm_ = R?.DispenseRequest;
            Duration lzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzm_?.ExpectedSupplyDuration;
            CqlQuantity lzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzzzzzzzzzzzn_);
            CqlQuantity lzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertQuantity(lzzzzzzzzzzzzzzzzzo_, "d");
            decimal? lzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzp_?.value;
            Quantity lzzzzzzzzzzzzzzzzzs_ = lzzzzzzzzzzzzzzzzzm_?.Quantity;
            CqlQuantity lzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzzzzzzzzzzzs_);
            decimal? lzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzt_?.value;
            List<Dosage> lzzzzzzzzzzzzzzzzzv_ = R?.DosageInstruction;
            Dosage lzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzzzzzzzzzzv_);
            List<Dosage.DoseAndRateComponent> lzzzzzzzzzzzzzzzzzx_ = lzzzzzzzzzzzzzzzzzw_?.DoseAndRate;
            Dosage.DoseAndRateComponent lzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)lzzzzzzzzzzzzzzzzzx_);
            DataType lzzzzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzzzzy_?.Dose;
            object mzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzz_);
            CqlQuantity mzzzzzzzzzzzzzzzzzb_ = context.Operators.End(mzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlQuantity>);
            Dosage mzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzzzzzzzzzzv_);
            List<Dosage.DoseAndRateComponent> mzzzzzzzzzzzzzzzzze_ = mzzzzzzzzzzzzzzzzzd_?.DoseAndRate;
            Dosage.DoseAndRateComponent mzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)mzzzzzzzzzzzzzzzzze_);
            DataType mzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzf_?.Dose;
            object mzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzg_);
            decimal? mzzzzzzzzzzzzzzzzzi_ = (mzzzzzzzzzzzzzzzzzb_ ?? mzzzzzzzzzzzzzzzzzh_ as CqlQuantity)?.value;
            Dosage mzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzzzzzzzzzzv_);
            Timing mzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzk_?.Timing;
            Timing.RepeatComponent mzzzzzzzzzzzzzzzzzm_ = mzzzzzzzzzzzzzzzzzl_?.Repeat;
            PositiveInt mzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzm_?.FrequencyMaxElement;
            int? mzzzzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzzzzn_?.Value;
            Dosage mzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzzzzzzzzzzv_);
            Timing mzzzzzzzzzzzzzzzzzr_ = mzzzzzzzzzzzzzzzzzq_?.Timing;
            Timing.RepeatComponent mzzzzzzzzzzzzzzzzzs_ = mzzzzzzzzzzzzzzzzzr_?.Repeat;
            PositiveInt mzzzzzzzzzzzzzzzzzt_ = mzzzzzzzzzzzzzzzzzs_?.FrequencyElement;
            int? mzzzzzzzzzzzzzzzzzu_ = mzzzzzzzzzzzzzzzzzt_?.Value;
            Dosage mzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzzzzzzzzzzv_);
            Timing mzzzzzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzzzzzw_?.Timing;
            Timing.RepeatComponent mzzzzzzzzzzzzzzzzzy_ = mzzzzzzzzzzzzzzzzzx_?.Repeat;
            FhirDecimal mzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzy_?.PeriodElement;
            decimal? nzzzzzzzzzzzzzzzzza_ = mzzzzzzzzzzzzzzzzzz_?.Value;
            Dosage nzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzzzzzzzzzzv_);
            Timing nzzzzzzzzzzzzzzzzzd_ = nzzzzzzzzzzzzzzzzzc_?.Timing;
            Timing.RepeatComponent nzzzzzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzzzzzd_?.Repeat;
            Code<Timing.UnitsOfTime> nzzzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzzzze_?.PeriodUnitElement;
            Timing.UnitsOfTime? nzzzzzzzzzzzzzzzzzg_ = nzzzzzzzzzzzzzzzzzf_?.Value;
            string nzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzg_);
            CqlQuantity nzzzzzzzzzzzzzzzzzi_ = CumulativeMedicationDuration_4_1_000.Instance.Quantity(context, nzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzh_);
            decimal? nzzzzzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.ToDaily(context, mzzzzzzzzzzzzzzzzzo_ ?? mzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzi_);
            Dosage nzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzzzzzzzzzzzv_);
            Timing nzzzzzzzzzzzzzzzzzm_ = nzzzzzzzzzzzzzzzzzl_?.Timing;
            Timing.RepeatComponent nzzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzzm_?.Repeat;
            List<Time> nzzzzzzzzzzzzzzzzzo_ = nzzzzzzzzzzzzzzzzzn_?.TimeOfDayElement;
            IEnumerable<CqlTime> nzzzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(nzzzzzzzzzzzzzzzzzo_, "value");
            int? nzzzzzzzzzzzzzzzzzq_ = context.Operators.Count<CqlTime>(nzzzzzzzzzzzzzzzzzp_);
            decimal? nzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(nzzzzzzzzzzzzzzzzzq_);
            decimal? nzzzzzzzzzzzzzzzzzs_ = context.Operators.Multiply(mzzzzzzzzzzzzzzzzzi_, (nzzzzzzzzzzzzzzzzzj_ ?? nzzzzzzzzzzzzzzzzzr_) ?? 1.0m);
            decimal? nzzzzzzzzzzzzzzzzzt_ = context.Operators.Divide(lzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzs_);
            UnsignedInt nzzzzzzzzzzzzzzzzzv_ = lzzzzzzzzzzzzzzzzzm_?.NumberOfRepeatsAllowedElement;
            int? nzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzv_?.Value;
            int? nzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(1, nzzzzzzzzzzzzzzzzzw_ ?? 0);
            decimal? nzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(nzzzzzzzzzzzzzzzzzx_);
            decimal? nzzzzzzzzzzzzzzzzzz_ = context.Operators.Multiply(lzzzzzzzzzzzzzzzzzq_ ?? nzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzy_);

            return nzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<decimal?> lzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, decimal?>((IEnumerable<MedicationRequest>)lzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzi_);
        IEnumerable<decimal?> lzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<decimal?>(lzzzzzzzzzzzzzzzzzj_);
        decimal? lzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<decimal?>(lzzzzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzza_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(ozzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzf_ = this.moreThanOneOrder(context, ozzzzzzzzzzzzzzzzze_);
        decimal? ozzzzzzzzzzzzzzzzzg_(MedicationRequest AntiInfectives)
        {
            decimal? ozzzzzzzzzzzzzzzzzl_ = this.MedicationRequestPeriodInDays(context, AntiInfectives);

            return ozzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<decimal?> ozzzzzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationRequest, decimal?>(ozzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzg_);
        decimal? ozzzzzzzzzzzzzzzzzi_ = context.Operators.Sum(ozzzzzzzzzzzzzzzzzh_);
        decimal? ozzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(90);
        bool? ozzzzzzzzzzzzzzzzzk_ = context.Operators.Greater(ozzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("MedicationStrengthPerUnit")]
    public CqlQuantity MedicationStrengthPerUnit(CqlContext context, CqlConcept Strength)
    {
        CqlQuantity ozzzzzzzzzzzzzzzzzm_()
        {
            bool ozzzzzzzzzzzzzzzzzn_()
            {
                CqlCode pzzzzzzzzzzzzzzzzzc_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
                CqlConcept pzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzc_);
                bool? pzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(Strength, pzzzzzzzzzzzzzzzzzd_);

                return pzzzzzzzzzzzzzzzzze_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzo_()
            {
                CqlCode pzzzzzzzzzzzzzzzzzf_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
                CqlConcept pzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzf_);
                bool? pzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(Strength, pzzzzzzzzzzzzzzzzzg_);

                return pzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzp_()
            {
                CqlCode pzzzzzzzzzzzzzzzzzi_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
                CqlConcept pzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzi_);
                bool? pzzzzzzzzzzzzzzzzzk_ = context.Operators.Equivalent(Strength, pzzzzzzzzzzzzzzzzzj_);

                return pzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzq_()
            {
                CqlCode pzzzzzzzzzzzzzzzzzl_ = this.digoxin_0_125_MG_Oral_Tablet(context);
                CqlConcept pzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzl_);
                bool? pzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(Strength, pzzzzzzzzzzzzzzzzzm_);

                return pzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzr_()
            {
                CqlCode pzzzzzzzzzzzzzzzzzo_ = this.digoxin_0_25_MG_Oral_Tablet(context);
                CqlConcept pzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzo_);
                bool? pzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(Strength, pzzzzzzzzzzzzzzzzzp_);

                return pzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzs_()
            {
                CqlCode pzzzzzzzzzzzzzzzzzr_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
                CqlConcept pzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzr_);
                bool? pzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(Strength, pzzzzzzzzzzzzzzzzzs_);

                return pzzzzzzzzzzzzzzzzzt_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzt_()
            {
                CqlCode pzzzzzzzzzzzzzzzzzu_ = this.doxepin_3_MG_Oral_Tablet(context);
                CqlConcept pzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzu_);
                bool? pzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(Strength, pzzzzzzzzzzzzzzzzzv_);

                return pzzzzzzzzzzzzzzzzzw_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzu_()
            {
                CqlCode pzzzzzzzzzzzzzzzzzx_ = this.doxepin_6_MG_Oral_Tablet(context);
                CqlConcept pzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzx_);
                bool? pzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(Strength, pzzzzzzzzzzzzzzzzzy_);

                return pzzzzzzzzzzzzzzzzzz_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzv_()
            {
                CqlCode qzzzzzzzzzzzzzzzzza_ = this.doxepin_10_MG_Oral_Capsule(context);
                CqlConcept qzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzza_);
                bool? qzzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(Strength, qzzzzzzzzzzzzzzzzzb_);

                return qzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzw_()
            {
                CqlCode qzzzzzzzzzzzzzzzzzd_ = this.doxepin_10_MG_ML_Oral_Solution(context);
                CqlConcept qzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzd_);
                bool? qzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(Strength, qzzzzzzzzzzzzzzzzze_);

                return qzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzx_()
            {
                CqlCode qzzzzzzzzzzzzzzzzzg_ = this.doxepin_25_MG_Oral_Capsule(context);
                CqlConcept qzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzg_);
                bool? qzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(Strength, qzzzzzzzzzzzzzzzzzh_);

                return qzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzy_()
            {
                CqlCode qzzzzzzzzzzzzzzzzzj_ = this.doxepin_50_MG_Oral_Capsule(context);
                CqlConcept qzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzj_);
                bool? qzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(Strength, qzzzzzzzzzzzzzzzzzk_);

                return qzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool ozzzzzzzzzzzzzzzzzz_()
            {
                CqlCode qzzzzzzzzzzzzzzzzzm_ = this.doxepin_75_MG_Oral_Capsule(context);
                CqlConcept qzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzm_);
                bool? qzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(Strength, qzzzzzzzzzzzzzzzzzn_);

                return qzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzza_()
            {
                CqlCode qzzzzzzzzzzzzzzzzzp_ = this.doxepin_100_MG_Oral_Capsule(context);
                CqlConcept qzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzp_);
                bool? qzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(Strength, qzzzzzzzzzzzzzzzzzq_);

                return qzzzzzzzzzzzzzzzzzr_ ?? false;
            };
            bool pzzzzzzzzzzzzzzzzzb_()
            {
                CqlCode qzzzzzzzzzzzzzzzzzs_ = this.doxepin_150_MG_Oral_Capsule(context);
                CqlConcept qzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzs_);
                bool? qzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(Strength, qzzzzzzzzzzzzzzzzzt_);

                return qzzzzzzzzzzzzzzzzzu_ ?? false;
            };
            if (ozzzzzzzzzzzzzzzzzn_())
            {
                CqlQuantity qzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(0.05m, "mg/mL");

                return qzzzzzzzzzzzzzzzzzv_;
            }
            else if (ozzzzzzzzzzzzzzzzzo_())
            {
                CqlQuantity qzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(0.0625m, "mg");

                return qzzzzzzzzzzzzzzzzzw_;
            }
            else if (ozzzzzzzzzzzzzzzzzp_())
            {
                CqlQuantity qzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(0.1m, "mg/mL");

                return qzzzzzzzzzzzzzzzzzx_;
            }
            else if (ozzzzzzzzzzzzzzzzzq_())
            {
                CqlQuantity qzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(0.125m, "mg");

                return qzzzzzzzzzzzzzzzzzy_;
            }
            else if (ozzzzzzzzzzzzzzzzzr_())
            {
                CqlQuantity qzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(0.25m, "mg");

                return qzzzzzzzzzzzzzzzzzz_;
            }
            else if (ozzzzzzzzzzzzzzzzzs_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(0.25m, "mg/mL");

                return rzzzzzzzzzzzzzzzzza_;
            }
            else if (ozzzzzzzzzzzzzzzzzt_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(3m, "mg");

                return rzzzzzzzzzzzzzzzzzb_;
            }
            else if (ozzzzzzzzzzzzzzzzzu_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(6m, "mg");

                return rzzzzzzzzzzzzzzzzzc_;
            }
            else if (ozzzzzzzzzzzzzzzzzv_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(10m, "mg");

                return rzzzzzzzzzzzzzzzzzd_;
            }
            else if (ozzzzzzzzzzzzzzzzzw_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(10m, "mg/mL");

                return rzzzzzzzzzzzzzzzzze_;
            }
            else if (ozzzzzzzzzzzzzzzzzx_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(25m, "mg");

                return rzzzzzzzzzzzzzzzzzf_;
            }
            else if (ozzzzzzzzzzzzzzzzzy_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(50m, "mg");

                return rzzzzzzzzzzzzzzzzzg_;
            }
            else if (ozzzzzzzzzzzzzzzzzz_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(75m, "mg");

                return rzzzzzzzzzzzzzzzzzh_;
            }
            else if (pzzzzzzzzzzzzzzzzza_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(100m, "mg");

                return rzzzzzzzzzzzzzzzzzi_;
            }
            else if (pzzzzzzzzzzzzzzzzzb_())
            {
                CqlQuantity rzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(150m, "mg");

                return rzzzzzzzzzzzzzzzzzj_;
            }
            else
            {
                return default;
            }
        };

        return ozzzzzzzzzzzzzzzzzm_();
    }


    [CqlExpressionDefinition("averageDailyDose")]
    public CqlQuantity averageDailyDose(CqlContext context, MedicationRequest MedicationRequest)
    {
        MedicationRequest[] rzzzzzzzzzzzzzzzzzk_ = [
            MedicationRequest,
        ];
        CqlQuantity rzzzzzzzzzzzzzzzzzl_(MedicationRequest Order)
        {
            CqlQuantity rzzzzzzzzzzzzzzzzzp_()
            {
                bool rzzzzzzzzzzzzzzzzzq_()
                {
                    decimal? rzzzzzzzzzzzzzzzzzr_ = this.MedicationRequestPeriodInDays(context, Order);
                    bool? rzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzr_ is null));
                    CqlConcept rzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity rzzzzzzzzzzzzzzzzzu_ = this.MedicationStrengthPerUnit(context, rzzzzzzzzzzzzzzzzzt_);
                    string rzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzu_?.unit;
                    bool? rzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzv_, "mg");
                    CqlQuantity rzzzzzzzzzzzzzzzzzy_ = this.MedicationStrengthPerUnit(context, rzzzzzzzzzzzzzzzzzt_);
                    string rzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzy_?.unit;
                    bool? szzzzzzzzzzzzzzzzza_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzz_, "mg/mL");
                    MedicationRequest.DispenseRequestComponent szzzzzzzzzzzzzzzzzb_ = Order?.DispenseRequest;
                    Quantity szzzzzzzzzzzzzzzzzc_ = szzzzzzzzzzzzzzzzzb_?.Quantity;
                    CqlQuantity szzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzc_);
                    string szzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzd_?.unit;
                    bool? szzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(szzzzzzzzzzzzzzzzze_, "mL");
                    bool? szzzzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzf_);
                    bool? szzzzzzzzzzzzzzzzzh_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzg_);
                    bool? szzzzzzzzzzzzzzzzzi_ = context.Operators.And(rzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzh_);

                    return szzzzzzzzzzzzzzzzzi_ ?? false;
                };
                if (rzzzzzzzzzzzzzzzzzq_())
                {
                    MedicationRequest.DispenseRequestComponent szzzzzzzzzzzzzzzzzj_ = Order?.DispenseRequest;
                    Quantity szzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzj_?.Quantity;
                    CqlQuantity szzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzk_);
                    CqlConcept szzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity szzzzzzzzzzzzzzzzzn_ = this.MedicationStrengthPerUnit(context, szzzzzzzzzzzzzzzzzm_);
                    CqlQuantity szzzzzzzzzzzzzzzzzo_ = context.Operators.Multiply(szzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzn_);
                    decimal? szzzzzzzzzzzzzzzzzp_ = this.MedicationRequestPeriodInDays(context, Order);
                    CqlQuantity szzzzzzzzzzzzzzzzzq_ = context.Operators.Divide(szzzzzzzzzzzzzzzzzo_, new CqlQuantity(szzzzzzzzzzzzzzzzzp_, "d"));

                    return szzzzzzzzzzzzzzzzzq_;
                }
                else
                {
                    return default;
                }
            };

            return rzzzzzzzzzzzzzzzzzp_();
        };
        IEnumerable<CqlQuantity> rzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, CqlQuantity>((IEnumerable<MedicationRequest>)rzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlQuantity> rzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlQuantity>(rzzzzzzzzzzzzzzzzzm_);
        CqlQuantity rzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<CqlQuantity>(rzzzzzzzzzzzzzzzzzn_);

        return rzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("High Risk Medications with Average Daily Dose Criteria")]
    public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzr_ = this.Digoxin_Medications(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzw_ = this.moreThanOneOrder(context, szzzzzzzzzzzzzzzzzv_);
        bool? szzzzzzzzzzzzzzzzzx_(MedicationRequest DigoxinOrdered)
        {
            CqlQuantity tzzzzzzzzzzzzzzzzzk_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity tzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? tzzzzzzzzzzzzzzzzzm_ = context.Operators.Greater(tzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzl_);

            return tzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzx_);
        bool? szzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<MedicationRequest>(szzzzzzzzzzzzzzzzzy_);
        CqlValueSet tzzzzzzzzzzzzzzzzza_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzf_ = this.moreThanOneOrder(context, tzzzzzzzzzzzzzzzzze_);
        bool? tzzzzzzzzzzzzzzzzzg_(MedicationRequest DoxepinOrdered)
        {
            CqlQuantity tzzzzzzzzzzzzzzzzzn_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity tzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(6m, "mg/d");
            bool? tzzzzzzzzzzzzzzzzzp_ = context.Operators.Greater(tzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzo_);

            return tzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzg_);
        bool? tzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzzzzzzzzh_);
        bool? tzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(szzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzi_);

        return tzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzq_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
        bool? tzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzzzzzzzzq_);
        bool? tzzzzzzzzzzzzzzzzzs_ = this.Two_High_Risk_Medications_with_Prolonged_Duration(context);
        bool? tzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzzzzzu_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria(context);
        bool? tzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("More than One Antipsychotic Order")]
    public bool? More_than_One_Antipsychotic_Order(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzw_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzb_ = this.moreThanOneOrder(context, uzzzzzzzzzzzzzzzzza_);
        bool? uzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<MedicationRequest>(uzzzzzzzzzzzzzzzzzb_);

        return uzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Antipsychotic Index Prescription Start Date")]
    public CqlDateTime Antipsychotic_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzd_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationOrder(context, uzzzzzzzzzzzzzzzzzh_);
        bool? uzzzzzzzzzzzzzzzzzj_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime uzzzzzzzzzzzzzzzzzq_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzs_, default);

            return uzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzj_);
        CqlDateTime uzzzzzzzzzzzzzzzzzl_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime uzzzzzzzzzzzzzzzzzu_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzu_);

            return uzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDateTime> uzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, CqlDateTime>(uzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDateTime> uzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDateTime>(uzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDateTime> uzzzzzzzzzzzzzzzzzo_ = context.Operators.ListSort<CqlDateTime>(uzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime uzzzzzzzzzzzzzzzzzp_ = context.Operators.First<CqlDateTime>(uzzzzzzzzzzzzzzzzzo_);

        return uzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzw_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzb_ = this.moreThanOneOrder(context, vzzzzzzzzzzzzzzzzza_);
        bool? vzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<MedicationRequest>(vzzzzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Benzodiazepine Index Prescription Start Date")]
    public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzd_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationOrder(context, vzzzzzzzzzzzzzzzzzh_);
        bool? vzzzzzzzzzzzzzzzzzj_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime vzzzzzzzzzzzzzzzzzq_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime vzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzs_, default);

            return vzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzj_);
        CqlDateTime vzzzzzzzzzzzzzzzzzl_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime vzzzzzzzzzzzzzzzzzu_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime vzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzu_);

            return vzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDateTime> vzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, CqlDateTime>(vzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDateTime> vzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDateTime>(vzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDateTime> vzzzzzzzzzzzzzzzzzo_ = context.Operators.ListSort<CqlDateTime>(vzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime vzzzzzzzzzzzzzzzzzp_ = context.Operators.First<CqlDateTime>(vzzzzzzzzzzzzzzzzzo_);

        return vzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzw_ = this.More_than_One_Antipsychotic_Order(context);
        CqlValueSet vzzzzzzzzzzzzzzzzzx_ = this.Schizophrenia(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet vzzzzzzzzzzzzzzzzzz_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzzzzzc_(Condition AntipsychoticTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzze_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzd_);
            CqlQuantity xzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1m, "year");
            CqlDateTime xzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzf_);
            CqlDateTime xzzzzzzzzzzzzzzzzzh_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzh_, true, true);
            bool? xzzzzzzzzzzzzzzzzzj_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzi_, default);

            return xzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzd_);
        bool? wzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(wzzzzzzzzzzzzzzzzze_);
        bool? wzzzzzzzzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzf_);
        bool? wzzzzzzzzzzzzzzzzzh_ = this.More_than_One_Benzodiazepine_Order(context);
        CqlValueSet wzzzzzzzzzzzzzzzzzi_ = this.Seizure_Disorder(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet wzzzzzzzzzzzzzzzzzk_ = this.REM_Sleep_Behavior_Disorder(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzl_);
        CqlValueSet wzzzzzzzzzzzzzzzzzn_ = this.Benzodiazepine_Withdrawal(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet wzzzzzzzzzzzzzzzzzp_ = this.Alcohol_Withdrawal(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzr_);
        CqlValueSet wzzzzzzzzzzzzzzzzzt_ = this.Generalized_Anxiety_Disorder(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzu_);
        bool? wzzzzzzzzzzzzzzzzzw_(Condition BenzodiazepineTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzl_);
            CqlQuantity xzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "year");
            CqlDateTime xzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzn_);
            CqlDateTime xzzzzzzzzzzzzzzzzzp_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzp_, true, true);
            bool? xzzzzzzzzzzzzzzzzzr_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzq_, default);

            return xzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzw_);
        bool? wzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzx_);
        bool? wzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzy_);
        bool? xzzzzzzzzzzzzzzzzza_ = context.Operators.And(wzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzz_);
        bool? xzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzza_);

        return xzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzs_ = this.Numerator_2(context);
        bool? xzzzzzzzzzzzzzzzzzt_ = this.Numerator_1(context);
        bool? xzzzzzzzzzzzzzzzzzv_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzs_);
        bool? xzzzzzzzzzzzzzzzzzw_ = context.Operators.And(xzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzv_);
        bool? xzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzw_);

        return xzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return xzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> xzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return xzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

}
