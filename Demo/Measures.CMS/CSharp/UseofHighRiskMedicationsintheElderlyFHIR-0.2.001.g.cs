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
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzu_, true, true);
        object qzzzzzzzzzzzzzzzzzzzzzw_ = context.ResolveParameter("UseofHighRiskMedicationsintheElderlyFHIR-0.2.001", "Measurement Period", qzzzzzzzzzzzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzzzzzzzzx_);

        return qzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzz_ = this.Office_Visit(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzb_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzze_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzg_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzk_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzm_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzs_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzw_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzc_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? szzzzzzzzzzzzzzzzzzzzzf_(Encounter E)
        {
            List<CodeableConcept> szzzzzzzzzzzzzzzzzzzzzm_ = E?.Type;
            CqlConcept szzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept szzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzn_);
            bool? szzzzzzzzzzzzzzzzzzzzzp_(CqlConcept T)
            {
                CqlCode szzzzzzzzzzzzzzzzzzzzzt_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept szzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzzzzzzzzzzzzzt_);
                bool? szzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(T, szzzzzzzzzzzzzzzzzzzzzu_);

                return szzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<CqlConcept>(szzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzp_);
            bool? szzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlConcept>(szzzzzzzzzzzzzzzzzzzzzq_);

            return szzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isEncounterPerformed(context, szzzzzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzzzzk_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            Period szzzzzzzzzzzzzzzzzzzzzx_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzx_);
            bool? szzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzy_, default);

            return szzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient tzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date tzzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string tzzzzzzzzzzzzzzzzzzzzzc_ = tzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate tzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzf_);
        int? tzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzg_, "year");
        bool? tzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzzzzzzzzzh_, 65);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounters(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzzzzzzzzzzzzj_);
        bool? tzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzm_ = this.Initial_Population(context);

        return tzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzn_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzo_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzo_);

        return tzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("moreThanOneOrder")]
    public IEnumerable<MedicationRequest> moreThanOneOrder(CqlContext context, IEnumerable<MedicationRequest> Medication)
    {
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzr_(MedicationRequest OrderMedication1)
        {
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
            bool? tzzzzzzzzzzzzzzzzzzzzzx_(MedicationRequest OrderMedication2)
            {
                FhirDateTime uzzzzzzzzzzzzzzzzzzzzzb_ = OrderMedication1?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
                bool? uzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzd_, default);
                MedicationRequest.DispenseRequestComponent uzzzzzzzzzzzzzzzzzzzzzf_ = OrderMedication1?.DispenseRequest;
                UnsignedInt uzzzzzzzzzzzzzzzzzzzzzg_ = uzzzzzzzzzzzzzzzzzzzzzf_?.NumberOfRepeatsAllowedElement;
                int? uzzzzzzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                bool? uzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzzzzzzh_, 1);
                bool? uzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDate uzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzl_);
                FhirDateTime uzzzzzzzzzzzzzzzzzzzzzn_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDate uzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzo_);
                bool? uzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzp_);
                bool? uzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzb_);
                bool? uzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? uzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzn_);
                bool? vzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? vzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzza_);
                bool? vzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzh_);
                bool? vzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzb_);
                bool? vzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? vzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzt_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(vzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzw_);
                bool? vzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(vzzzzzzzzzzzzzzzzzzzzzx_);
                bool? vzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzzzzzzzzb_);
                bool? wzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? wzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzze_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzzzzzzzzh_);
                bool? wzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? wzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzk_);
                bool? wzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzl_);

                return wzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzx_);
            MedicationRequest tzzzzzzzzzzzzzzzzzzzzzz_(MedicationRequest OrderMedication2) =>
                OrderMedication1;
            IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<MedicationRequest, MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzz_);

            return uzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzr_);
        MedicationRequest tzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest OrderMedication1) =>
            OrderMedication1;
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzn_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzs_ = this.moreThanOneOrder(context, wzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzt_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzy_ = this.moreThanOneOrder(context, wzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzza_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzf_ = this.moreThanOneOrder(context, xzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzg_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzl_ = this.moreThanOneOrder(context, xzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzo_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzt_ = this.moreThanOneOrder(context, xzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzu_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzz_ = this.moreThanOneOrder(context, xzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzc_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzh_ = this.moreThanOneOrder(context, yzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzi_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzn_ = this.moreThanOneOrder(context, yzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode yzzzzzzzzzzzzzzzzzzzzzq_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzx_ = this.moreThanOneOrder(context, yzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzy_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzd_ = this.moreThanOneOrder(context, zzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzg_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzl_ = this.moreThanOneOrder(context, zzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzm_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzr_ = this.moreThanOneOrder(context, zzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzu_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzz_ = this.moreThanOneOrder(context, zzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzza_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzf_ = this.moreThanOneOrder(context, azzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzi_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzn_ = this.moreThanOneOrder(context, azzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzo_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzt_ = this.moreThanOneOrder(context, azzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzw_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzb_ = this.moreThanOneOrder(context, bzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzc_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzh_ = this.moreThanOneOrder(context, bzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzi_);

        return bzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("MedicationRequestPeriodInDays")]
    public decimal? MedicationRequestPeriodInDays(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] bzzzzzzzzzzzzzzzzzzzzzzk_ = [
            Request,
        ];
        decimal? bzzzzzzzzzzzzzzzzzzzzzzl_(MedicationRequest R)
        {
            MedicationRequest.DispenseRequestComponent bzzzzzzzzzzzzzzzzzzzzzzp_ = R?.DispenseRequest;
            Duration bzzzzzzzzzzzzzzzzzzzzzzq_ = bzzzzzzzzzzzzzzzzzzzzzzp_?.ExpectedSupplyDuration;
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertQuantity(bzzzzzzzzzzzzzzzzzzzzzzr_, "d");
            decimal? bzzzzzzzzzzzzzzzzzzzzzzt_ = bzzzzzzzzzzzzzzzzzzzzzzs_?.value;
            Quantity bzzzzzzzzzzzzzzzzzzzzzzv_ = bzzzzzzzzzzzzzzzzzzzzzzp_?.Quantity;
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzzzzzzv_);
            decimal? bzzzzzzzzzzzzzzzzzzzzzzx_ = bzzzzzzzzzzzzzzzzzzzzzzw_?.value;
            List<Dosage> bzzzzzzzzzzzzzzzzzzzzzzy_ = R?.DosageInstruction;
            Dosage bzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzy_);
            List<Dosage.DoseAndRateComponent> czzzzzzzzzzzzzzzzzzzzzza_ = bzzzzzzzzzzzzzzzzzzzzzzz_?.DoseAndRate;
            Dosage.DoseAndRateComponent czzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)czzzzzzzzzzzzzzzzzzzzzza_);
            DataType czzzzzzzzzzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzzzzzzzzzb_?.Dose;
            object czzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlQuantity>);
            Dosage czzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzy_);
            List<Dosage.DoseAndRateComponent> czzzzzzzzzzzzzzzzzzzzzzh_ = czzzzzzzzzzzzzzzzzzzzzzg_?.DoseAndRate;
            Dosage.DoseAndRateComponent czzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)czzzzzzzzzzzzzzzzzzzzzzh_);
            DataType czzzzzzzzzzzzzzzzzzzzzzj_ = czzzzzzzzzzzzzzzzzzzzzzi_?.Dose;
            object czzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzj_);
            decimal? czzzzzzzzzzzzzzzzzzzzzzl_ = (czzzzzzzzzzzzzzzzzzzzzze_ ?? czzzzzzzzzzzzzzzzzzzzzzk_ as CqlQuantity)?.value;
            Dosage czzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzy_);
            Timing czzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzn_?.Timing;
            Timing.RepeatComponent czzzzzzzzzzzzzzzzzzzzzzp_ = czzzzzzzzzzzzzzzzzzzzzzo_?.Repeat;
            PositiveInt czzzzzzzzzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzzzzzzzzp_?.FrequencyMaxElement;
            int? czzzzzzzzzzzzzzzzzzzzzzr_ = czzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Dosage czzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzy_);
            Timing czzzzzzzzzzzzzzzzzzzzzzu_ = czzzzzzzzzzzzzzzzzzzzzzt_?.Timing;
            Timing.RepeatComponent czzzzzzzzzzzzzzzzzzzzzzv_ = czzzzzzzzzzzzzzzzzzzzzzu_?.Repeat;
            PositiveInt czzzzzzzzzzzzzzzzzzzzzzw_ = czzzzzzzzzzzzzzzzzzzzzzv_?.FrequencyElement;
            int? czzzzzzzzzzzzzzzzzzzzzzx_ = czzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Dosage czzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzy_);
            Timing dzzzzzzzzzzzzzzzzzzzzzza_ = czzzzzzzzzzzzzzzzzzzzzzz_?.Timing;
            Timing.RepeatComponent dzzzzzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzzzzzza_?.Repeat;
            FhirDecimal dzzzzzzzzzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzzzzzzzzzb_?.PeriodElement;
            decimal? dzzzzzzzzzzzzzzzzzzzzzzd_ = dzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            Dosage dzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzy_);
            Timing dzzzzzzzzzzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzzzzzzzzzzf_?.Timing;
            Timing.RepeatComponent dzzzzzzzzzzzzzzzzzzzzzzh_ = dzzzzzzzzzzzzzzzzzzzzzzg_?.Repeat;
            Code<Timing.UnitsOfTime> dzzzzzzzzzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzzzzzzzzzh_?.PeriodUnitElement;
            Timing.UnitsOfTime? dzzzzzzzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string dzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.Quantity(context, dzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzk_);
            decimal? dzzzzzzzzzzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.ToDaily(context, czzzzzzzzzzzzzzzzzzzzzzr_ ?? czzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzl_);
            Dosage dzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzzzzzzzzzzzzzzzzy_);
            Timing dzzzzzzzzzzzzzzzzzzzzzzp_ = dzzzzzzzzzzzzzzzzzzzzzzo_?.Timing;
            Timing.RepeatComponent dzzzzzzzzzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzzzzzzzzzp_?.Repeat;
            List<Time> dzzzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzzzq_?.TimeOfDayElement;
            IEnumerable<CqlTime> dzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(dzzzzzzzzzzzzzzzzzzzzzzr_, "value");
            int? dzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Count<CqlTime>(dzzzzzzzzzzzzzzzzzzzzzzs_);
            decimal? dzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(dzzzzzzzzzzzzzzzzzzzzzzt_);
            decimal? dzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Multiply(czzzzzzzzzzzzzzzzzzzzzzl_, (dzzzzzzzzzzzzzzzzzzzzzzm_ ?? dzzzzzzzzzzzzzzzzzzzzzzu_) ?? 1.0m);
            decimal? dzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Divide(bzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzv_);
            UnsignedInt dzzzzzzzzzzzzzzzzzzzzzzy_ = bzzzzzzzzzzzzzzzzzzzzzzp_?.NumberOfRepeatsAllowedElement;
            int? dzzzzzzzzzzzzzzzzzzzzzzz_ = dzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            int? ezzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(1, dzzzzzzzzzzzzzzzzzzzzzzz_ ?? 0);
            decimal? ezzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(ezzzzzzzzzzzzzzzzzzzzzza_);
            decimal? ezzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Multiply(bzzzzzzzzzzzzzzzzzzzzzzt_ ?? dzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzb_);

            return ezzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<decimal?> bzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, decimal?>((IEnumerable<MedicationRequest>)bzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<decimal?> bzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<decimal?>(bzzzzzzzzzzzzzzzzzzzzzzm_);
        decimal? bzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<decimal?>(bzzzzzzzzzzzzzzzzzzzzzzn_);

        return bzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzd_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzi_ = this.moreThanOneOrder(context, ezzzzzzzzzzzzzzzzzzzzzzh_);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest AntiInfectives)
        {
            decimal? ezzzzzzzzzzzzzzzzzzzzzzo_ = this.MedicationRequestPeriodInDays(context, AntiInfectives);

            return ezzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<decimal?> ezzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<MedicationRequest, decimal?>(ezzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzj_);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Sum(ezzzzzzzzzzzzzzzzzzzzzzk_);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(90);
        bool? ezzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Greater(ezzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("MedicationStrengthPerUnit")]
    public CqlQuantity MedicationStrengthPerUnit(CqlContext context, CqlConcept Strength)
    {
        CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzp_()
        {
            bool ezzzzzzzzzzzzzzzzzzzzzzq_()
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzzzf_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(Strength, fzzzzzzzzzzzzzzzzzzzzzzg_);

                return fzzzzzzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzr_()
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzzzi_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equivalent(Strength, fzzzzzzzzzzzzzzzzzzzzzzj_);

                return fzzzzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzs_()
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzzzl_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(Strength, fzzzzzzzzzzzzzzzzzzzzzzm_);

                return fzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzt_()
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzzzo_ = this.digoxin_0_125_MG_Oral_Tablet(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(Strength, fzzzzzzzzzzzzzzzzzzzzzzp_);

                return fzzzzzzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzu_()
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzzzr_ = this.digoxin_0_25_MG_Oral_Tablet(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(Strength, fzzzzzzzzzzzzzzzzzzzzzzs_);

                return fzzzzzzzzzzzzzzzzzzzzzzt_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzv_()
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzzzu_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(Strength, fzzzzzzzzzzzzzzzzzzzzzzv_);

                return fzzzzzzzzzzzzzzzzzzzzzzw_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzw_()
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzzzx_ = this.doxepin_3_MG_Oral_Tablet(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(Strength, fzzzzzzzzzzzzzzzzzzzzzzy_);

                return fzzzzzzzzzzzzzzzzzzzzzzz_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzx_()
            {
                CqlCode gzzzzzzzzzzzzzzzzzzzzzza_ = this.doxepin_6_MG_Oral_Tablet(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzza_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(Strength, gzzzzzzzzzzzzzzzzzzzzzzb_);

                return gzzzzzzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzy_()
            {
                CqlCode gzzzzzzzzzzzzzzzzzzzzzzd_ = this.doxepin_10_MG_Oral_Capsule(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(Strength, gzzzzzzzzzzzzzzzzzzzzzze_);

                return gzzzzzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            bool ezzzzzzzzzzzzzzzzzzzzzzz_()
            {
                CqlCode gzzzzzzzzzzzzzzzzzzzzzzg_ = this.doxepin_10_MG_ML_Oral_Solution(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(Strength, gzzzzzzzzzzzzzzzzzzzzzzh_);

                return gzzzzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool fzzzzzzzzzzzzzzzzzzzzzza_()
            {
                CqlCode gzzzzzzzzzzzzzzzzzzzzzzj_ = this.doxepin_25_MG_Oral_Capsule(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(Strength, gzzzzzzzzzzzzzzzzzzzzzzk_);

                return gzzzzzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool fzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                CqlCode gzzzzzzzzzzzzzzzzzzzzzzm_ = this.doxepin_50_MG_Oral_Capsule(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(Strength, gzzzzzzzzzzzzzzzzzzzzzzn_);

                return gzzzzzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            bool fzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                CqlCode gzzzzzzzzzzzzzzzzzzzzzzp_ = this.doxepin_75_MG_Oral_Capsule(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(Strength, gzzzzzzzzzzzzzzzzzzzzzzq_);

                return gzzzzzzzzzzzzzzzzzzzzzzr_ ?? false;
            };
            bool fzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                CqlCode gzzzzzzzzzzzzzzzzzzzzzzs_ = this.doxepin_100_MG_Oral_Capsule(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(Strength, gzzzzzzzzzzzzzzzzzzzzzzt_);

                return gzzzzzzzzzzzzzzzzzzzzzzu_ ?? false;
            };
            bool fzzzzzzzzzzzzzzzzzzzzzze_()
            {
                CqlCode gzzzzzzzzzzzzzzzzzzzzzzv_ = this.doxepin_150_MG_Oral_Capsule(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(Strength, gzzzzzzzzzzzzzzzzzzzzzzw_);

                return gzzzzzzzzzzzzzzzzzzzzzzx_ ?? false;
            };
            if (ezzzzzzzzzzzzzzzzzzzzzzq_())
            {
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(0.05m, "mg/mL");

                return gzzzzzzzzzzzzzzzzzzzzzzy_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzr_())
            {
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(0.0625m, "mg");

                return gzzzzzzzzzzzzzzzzzzzzzzz_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzs_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(0.1m, "mg/mL");

                return hzzzzzzzzzzzzzzzzzzzzzza_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzt_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(0.125m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzb_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzu_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(0.25m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzc_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzv_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(0.25m, "mg/mL");

                return hzzzzzzzzzzzzzzzzzzzzzzd_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzw_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(3m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzze_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzx_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(6m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzf_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzy_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(10m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzg_;
            }
            else if (ezzzzzzzzzzzzzzzzzzzzzzz_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(10m, "mg/mL");

                return hzzzzzzzzzzzzzzzzzzzzzzh_;
            }
            else if (fzzzzzzzzzzzzzzzzzzzzzza_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(25m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzi_;
            }
            else if (fzzzzzzzzzzzzzzzzzzzzzzb_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(50m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzj_;
            }
            else if (fzzzzzzzzzzzzzzzzzzzzzzc_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(75m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzk_;
            }
            else if (fzzzzzzzzzzzzzzzzzzzzzzd_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(100m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzl_;
            }
            else if (fzzzzzzzzzzzzzzzzzzzzzze_())
            {
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(150m, "mg");

                return hzzzzzzzzzzzzzzzzzzzzzzm_;
            }
            else
            {
                return default;
            }
        };

        return ezzzzzzzzzzzzzzzzzzzzzzp_();
    }


    [CqlExpressionDefinition("averageDailyDose")]
    public CqlQuantity averageDailyDose(CqlContext context, MedicationRequest MedicationRequest)
    {
        MedicationRequest[] hzzzzzzzzzzzzzzzzzzzzzzn_ = [
            MedicationRequest,
        ];
        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest Order)
        {
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                bool hzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    decimal? hzzzzzzzzzzzzzzzzzzzzzzu_ = this.MedicationRequestPeriodInDays(context, Order);
                    bool? hzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                    CqlConcept hzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzx_ = this.MedicationStrengthPerUnit(context, hzzzzzzzzzzzzzzzzzzzzzzw_);
                    string hzzzzzzzzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzzzzzzzzx_?.unit;
                    bool? hzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzy_, "mg");
                    CqlQuantity izzzzzzzzzzzzzzzzzzzzzzb_ = this.MedicationStrengthPerUnit(context, hzzzzzzzzzzzzzzzzzzzzzzw_);
                    string izzzzzzzzzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzzzzzzzzb_?.unit;
                    bool? izzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzc_, "mg/mL");
                    MedicationRequest.DispenseRequestComponent izzzzzzzzzzzzzzzzzzzzzze_ = Order?.DispenseRequest;
                    Quantity izzzzzzzzzzzzzzzzzzzzzzf_ = izzzzzzzzzzzzzzzzzzzzzze_?.Quantity;
                    CqlQuantity izzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzzzzzzzf_);
                    string izzzzzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzzzzg_?.unit;
                    bool? izzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzh_, "mL");
                    bool? izzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzi_);
                    bool? izzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzj_);
                    bool? izzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzk_);

                    return izzzzzzzzzzzzzzzzzzzzzzl_ ?? false;
                };
                if (hzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    MedicationRequest.DispenseRequestComponent izzzzzzzzzzzzzzzzzzzzzzm_ = Order?.DispenseRequest;
                    Quantity izzzzzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzzzzm_?.Quantity;
                    CqlQuantity izzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzzzzzzzn_);
                    CqlConcept izzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity izzzzzzzzzzzzzzzzzzzzzzq_ = this.MedicationStrengthPerUnit(context, izzzzzzzzzzzzzzzzzzzzzzp_);
                    CqlQuantity izzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Multiply(izzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzq_);
                    decimal? izzzzzzzzzzzzzzzzzzzzzzs_ = this.MedicationRequestPeriodInDays(context, Order);
                    CqlQuantity izzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Divide(izzzzzzzzzzzzzzzzzzzzzzr_, new CqlQuantity(izzzzzzzzzzzzzzzzzzzzzzs_, "d"));

                    return izzzzzzzzzzzzzzzzzzzzzzt_;
                }
                else
                {
                    return default;
                }
            };

            return hzzzzzzzzzzzzzzzzzzzzzzs_();
        };
        IEnumerable<CqlQuantity> hzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<MedicationRequest, CqlQuantity>((IEnumerable<MedicationRequest>)hzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlQuantity> hzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlQuantity>(hzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<CqlQuantity>(hzzzzzzzzzzzzzzzzzzzzzzq_);

        return hzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("High Risk Medications with Average Daily Dose Criteria")]
    public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzu_ = this.Digoxin_Medications(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzz_ = this.moreThanOneOrder(context, izzzzzzzzzzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest DigoxinOrdered)
        {
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzn_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? jzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Greater(jzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzo_);

            return jzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzza_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzd_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzi_ = this.moreThanOneOrder(context, jzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest DoxepinOrdered)
        {
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzq_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(6m, "mg/d");
            bool? jzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Greater(jzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzr_);

            return jzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzl_);

        return jzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzt_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzv_ = this.Two_High_Risk_Medications_with_Prolonged_Duration(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzx_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzx_);

        return jzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("More than One Antipsychotic Order")]
    public bool? More_than_One_Antipsychotic_Order(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzz_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzze_ = this.moreThanOneOrder(context, kzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Antipsychotic Index Prescription Start Date")]
    public CqlDateTime Antipsychotic_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzg_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isMedicationOrder(context, kzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime kzzzzzzzzzzzzzzzzzzzzzzt_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzv_, default);

            return kzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime kzzzzzzzzzzzzzzzzzzzzzzx_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzx_);

            return kzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<MedicationRequest, CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ListSort<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzr_);

        return kzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzz_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzze_ = this.moreThanOneOrder(context, lzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzze_);

        return lzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Benzodiazepine Index Prescription Start Date")]
    public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzg_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isMedicationOrder(context, lzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime lzzzzzzzzzzzzzzzzzzzzzzt_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzv_, default);

            return lzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime lzzzzzzzzzzzzzzzzzzzzzzx_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzx_);

            return lzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<MedicationRequest, CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ListSort<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzz_ = this.More_than_One_Antipsychotic_Order(context);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzza_ = this.Schizophrenia(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzc_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzf_(Condition AntipsychoticTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1m, "year");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzk_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzl_, default);

            return nzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not(mzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzk_ = this.More_than_One_Benzodiazepine_Order(context);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzl_ = this.Seizure_Disorder(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzn_ = this.REM_Sleep_Behavior_Disorder(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzq_ = this.Benzodiazepine_Withdrawal(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzs_ = this.Alcohol_Withdrawal(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzw_ = this.Generalized_Anxiety_Disorder(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzz_(Condition BenzodiazepineTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "year");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzs_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzt_, default);

            return nzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzzza_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(nzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? nzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzd_);

        return nzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzzzzzzzv_ = this.Numerator_2(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzw_ = this.Numerator_1(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(nzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? ozzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzz_);

        return ozzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

}
