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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS156FHIRHighRiskMedsElderly", "1.0.000")]
public partial class CMS156FHIRHighRiskMedsElderly_1_0_000 : ILibrary, ISingleton<CMS156FHIRHighRiskMedsElderly_1_0_000>
{
    #region ValueSets (40)

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

    #region Codes (17)

    [CqlCodeDefinition("1 ML digoxin 0.1 MG/ML Injection", codeId: "204504", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _1_ML_digoxin_0_1_MG_ML_Injection(CqlContext _) => __1_ML_digoxin_0_1_MG_ML_Injection;
    private static readonly CqlCode __1_ML_digoxin_0_1_MG_ML_Injection = new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("2 ML digoxin 0.25 MG/ML Injection", codeId: "104208", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _2_ML_digoxin_0_25_MG_ML_Injection(CqlContext _) => __2_ML_digoxin_0_25_MG_ML_Injection;
    private static readonly CqlCode __2_ML_digoxin_0_25_MG_ML_Injection = new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("digoxin 0.05 MG/ML Oral Solution", codeId: "393245", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_05_MG_ML_Oral_Solution(CqlContext _) => _digoxin_0_05_MG_ML_Oral_Solution;
    private static readonly CqlCode _digoxin_0_05_MG_ML_Oral_Solution = new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("digoxin 0.0625 MG Oral Tablet", codeId: "245273", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_0625_MG_Oral_Tablet(CqlContext _) => _digoxin_0_0625_MG_Oral_Tablet;
    private static readonly CqlCode _digoxin_0_0625_MG_Oral_Tablet = new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("digoxin 0.125 MG Oral Tablet", codeId: "197604", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_125_MG_Oral_Tablet(CqlContext _) => _digoxin_0_125_MG_Oral_Tablet;
    private static readonly CqlCode _digoxin_0_125_MG_Oral_Tablet = new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("digoxin 0.25 MG Oral Tablet", codeId: "197606", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_25_MG_Oral_Tablet(CqlContext _) => _digoxin_0_25_MG_Oral_Tablet;
    private static readonly CqlCode _digoxin_0_25_MG_Oral_Tablet = new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 10 MG Oral Capsule", codeId: "1000048", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_10_MG_Oral_Capsule(CqlContext _) => _doxepin_10_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_10_MG_Oral_Capsule = new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 10 MG/ML Oral Solution", codeId: "1000054", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_10_MG_ML_Oral_Solution(CqlContext _) => _doxepin_10_MG_ML_Oral_Solution;
    private static readonly CqlCode _doxepin_10_MG_ML_Oral_Solution = new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 100 MG Oral Capsule", codeId: "1000058", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_100_MG_Oral_Capsule(CqlContext _) => _doxepin_100_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_100_MG_Oral_Capsule = new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 150 MG Oral Capsule", codeId: "1000064", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_150_MG_Oral_Capsule(CqlContext _) => _doxepin_150_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_150_MG_Oral_Capsule = new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 25 MG Oral Capsule", codeId: "1000070", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_25_MG_Oral_Capsule(CqlContext _) => _doxepin_25_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_25_MG_Oral_Capsule = new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 3 MG Oral Tablet", codeId: "966787", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_3_MG_Oral_Tablet(CqlContext _) => _doxepin_3_MG_Oral_Tablet;
    private static readonly CqlCode _doxepin_3_MG_Oral_Tablet = new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 50 MG Oral Capsule", codeId: "1000076", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_50_MG_Oral_Capsule(CqlContext _) => _doxepin_50_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_50_MG_Oral_Capsule = new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 6 MG Oral Tablet", codeId: "966793", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_6_MG_Oral_Tablet(CqlContext _) => _doxepin_6_MG_Oral_Tablet;
    private static readonly CqlCode _doxepin_6_MG_Oral_Tablet = new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("doxepin 75 MG Oral Capsule", codeId: "1000097", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_75_MG_Oral_Capsule(CqlContext _) => _doxepin_75_MG_Oral_Capsule;
    private static readonly CqlCode _doxepin_75_MG_Oral_Capsule = new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("ergoloid mesylates, USP 1 MG Oral Tablet", codeId: "318179", codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode ergoloid_mesylates__USP_1_MG_Oral_Tablet(CqlContext _) => _ergoloid_mesylates__USP_1_MG_Oral_Tablet;
    private static readonly CqlCode _ergoloid_mesylates__USP_1_MG_Oral_Tablet = new CqlCode("318179", "http://www.nlm.nih.gov/research/umls/rxnorm");

    [CqlCodeDefinition("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional", codeId: "99211", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext _) => _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional;
    private static readonly CqlCode _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional = new CqlCode("99211", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("RXNORM", codeSystemId: "http://www.nlm.nih.gov/research/umls/rxnorm", codeSystemVersion: null)]
    public CqlCodeSystem RXNORM(CqlContext _) => _RXNORM;
    private static readonly CqlCodeSystem _RXNORM =
      new CqlCodeSystem("http://www.nlm.nih.gov/research/umls/rxnorm", null, [
          __1_ML_digoxin_0_1_MG_ML_Injection,
          __2_ML_digoxin_0_25_MG_ML_Injection,
          _digoxin_0_05_MG_ML_Oral_Solution,
          _digoxin_0_0625_MG_Oral_Tablet,
          _digoxin_0_125_MG_Oral_Tablet,
          _digoxin_0_25_MG_Oral_Tablet,
          _doxepin_10_MG_Oral_Capsule,
          _doxepin_10_MG_ML_Oral_Solution,
          _doxepin_100_MG_Oral_Capsule,
          _doxepin_150_MG_Oral_Capsule,
          _doxepin_25_MG_Oral_Capsule,
          _doxepin_3_MG_Oral_Tablet,
          _doxepin_50_MG_Oral_Capsule,
          _doxepin_6_MG_Oral_Tablet,
          _doxepin_75_MG_Oral_Capsule,
          _ergoloid_mesylates__USP_1_MG_Oral_Tablet]);

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3839642862747079336L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS156FHIRHighRiskMedsElderly-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (30)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -1712437477775746068L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = 1461678439183939324L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
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

        bool? ag_(Encounter E) {
            List<CodeableConcept> an_ = E?.Type;

            CqlConcept ao_(CodeableConcept @this) {
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return at_;
            }

            IEnumerable<CqlConcept> ap_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)an_, ao_);

            bool? aq_(CqlConcept T) {
                CqlCode au_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(T, av_);
                return aw_;
            }

            IEnumerable<CqlConcept> ar_ = context.Operators.Where<CqlConcept>(ap_, aq_);
            bool? as_ = context.Operators.Exists<CqlConcept>(ar_);
            return as_;
        }

        IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ae_, ah_);
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ac_, ai_);
        IEnumerable<Encounter> ak_ = Status_1_15_000.Instance.isEncounterPerformed(context, aj_);

        bool? al_(Encounter ValidEncounters) {
            CqlInterval<CqlDateTime> ax_ = this.Measurement_Period(context);
            Period ay_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
            bool? ba_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ax_, az_, (string)default);
            return ba_;
        }

        IEnumerable<Encounter> am_ = context.Operators.Where<Encounter>(ak_, al_);
        return am_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -4399740766800447863L;

    private bool? Initial_Population_Compute(CqlContext context)
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


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 474438247560395417L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 3566858140012574967L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("moreThanOneOrder")]
    public IEnumerable<MedicationRequest> moreThanOneOrder(CqlContext context, IEnumerable<MedicationRequest> Medication)
    {
        IEnumerable<MedicationRequest> a_ = Status_1_15_000.Instance.isMedicationOrder(context, Medication);

        bool? b_(MedicationRequest OrderMedication1) {
            IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, Medication);

            bool? h_(MedicationRequest OrderMedication2) {
                FhirDateTime k_ = OrderMedication1?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, (string)default);
                MedicationRequest.DispenseRequestComponent o_ = OrderMedication1?.DispenseRequest;
                UnsignedInt p_ = o_?.NumberOfRepeatsAllowedElement;
                int? q_ = p_?.Value;
                bool? r_ = context.Operators.GreaterOrEqual(q_, 1);
                bool? s_ = context.Operators.And(n_, r_);
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                FhirDateTime w_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                CqlDate y_ = context.Operators.DateFrom(x_);
                bool? z_ = context.Operators.Equivalent(v_, y_);
                bool? aa_ = context.Operators.Not(z_);
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(k_);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, m_, (string)default);
                bool? af_ = context.Operators.And(aa_, ae_);
                CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(w_);
                bool? aj_ = context.Operators.In<CqlDateTime>(ah_, m_, (string)default);
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.Or(s_, ak_);
                CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(w_);
                CqlDate ar_ = context.Operators.DateFrom(aq_);
                bool? as_ = context.Operators.Equivalent(ao_, ar_);
                CqlDateTime au_ = context.Operators.Convert<CqlDateTime>(k_);
                bool? aw_ = context.Operators.In<CqlDateTime>(au_, m_, (string)default);
                bool? ax_ = context.Operators.And(as_, aw_);
                CqlInterval<CqlDate> ay_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate az_ = context.Operators.Start(ay_);
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                CqlDate bb_ = context.Operators.DateFrom(ba_);
                CqlInterval<CqlDate> bc_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate bd_ = context.Operators.Start(bc_);
                CqlDateTime be_ = context.Operators.ConvertDateToDateTime(bd_);
                CqlDate bf_ = context.Operators.DateFrom(be_);
                bool? bg_ = context.Operators.Equivalent(bb_, bf_);
                bool? bh_ = context.Operators.Not(bg_);
                bool? bi_ = context.Operators.And(ax_, bh_);
                CqlDate bk_ = context.Operators.Start(ay_);
                CqlDateTime bl_ = context.Operators.ConvertDateToDateTime(bk_);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, m_, (string)default);
                bool? bo_ = context.Operators.And(bi_, bn_);
                CqlDate bq_ = context.Operators.Start(bc_);
                CqlDateTime br_ = context.Operators.ConvertDateToDateTime(bq_);
                bool? bt_ = context.Operators.In<CqlDateTime>(br_, m_, (string)default);
                bool? bu_ = context.Operators.And(bo_, bt_);
                bool? bv_ = context.Operators.Or(al_, bu_);
                return bv_;
            }

            IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
            bool? j_ = context.Operators.Exists<MedicationRequest>(i_);
            return j_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        MedicationRequest d_(MedicationRequest OrderMedication1) => OrderMedication1;
        IEnumerable<MedicationRequest> e_ = context.Operators.Select<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Distinct<MedicationRequest>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Same_High_Risk_Medications_Ordered_on_Different_Days, Same_High_Risk_Medications_Ordered_on_Different_Days_Compute);

    private const long _cacheIndex_Same_High_Risk_Medications_Ordered_on_Different_Days = 6848809231216479323L;

    private IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> eo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ep_(Medication M) {
                object es_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object et_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> eu_ = context.Operators.Split((string)et_, "/");
                string ev_ = context.Operators.Last<string>(eu_);
                bool? ew_ = context.Operators.Equal(es_, ev_);
                CodeableConcept ex_ = M?.Code;
                CqlConcept ey_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ex_);
                CqlValueSet ez_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
                bool? fa_ = context.Operators.ConceptInValueSet(ey_, ez_);
                bool? fb_ = context.Operators.And(ew_, fa_);
                return fb_;
            }

            IEnumerable<Medication> eq_ = context.Operators.Where<Medication>(eo_, ep_);
            bool? er_ = context.Operators.Exists<Medication>(eq_);
            return er_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);
        CqlValueSet h_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? k_(MedicationRequest MR) {
            IEnumerable<Medication> fc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fd_(Medication M) {
                object fg_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fh_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fi_ = context.Operators.Split((string)fh_, "/");
                string fj_ = context.Operators.Last<string>(fi_);
                bool? fk_ = context.Operators.Equal(fg_, fj_);
                CodeableConcept fl_ = M?.Code;
                CqlConcept fm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fl_);
                CqlValueSet fn_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
                bool? fo_ = context.Operators.ConceptInValueSet(fm_, fn_);
                bool? fp_ = context.Operators.And(fk_, fo_);
                return fp_;
            }

            IEnumerable<Medication> fe_ = context.Operators.Where<Medication>(fc_, fd_);
            bool? ff_ = context.Operators.Exists<Medication>(fe_);
            return ff_;
        }

        IEnumerable<MedicationRequest> l_ = context.Operators.Where<MedicationRequest>(c_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(i_, l_);
        IEnumerable<MedicationRequest> n_ = this.moreThanOneOrder(context, m_);
        IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(g_, n_);
        CqlValueSet p_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? s_(MedicationRequest MR) {
            IEnumerable<Medication> fq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fr_(Medication M) {
                object fu_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fw_ = context.Operators.Split((string)fv_, "/");
                string fx_ = context.Operators.Last<string>(fw_);
                bool? fy_ = context.Operators.Equal(fu_, fx_);
                CodeableConcept fz_ = M?.Code;
                CqlConcept ga_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fz_);
                CqlValueSet gb_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
                bool? gc_ = context.Operators.ConceptInValueSet(ga_, gb_);
                bool? gd_ = context.Operators.And(fy_, gc_);
                return gd_;
            }

            IEnumerable<Medication> fs_ = context.Operators.Where<Medication>(fq_, fr_);
            bool? ft_ = context.Operators.Exists<Medication>(fs_);
            return ft_;
        }

        IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(c_, s_);
        IEnumerable<MedicationRequest> u_ = context.Operators.Union<MedicationRequest>(q_, t_);
        IEnumerable<MedicationRequest> v_ = this.moreThanOneOrder(context, u_);
        CqlValueSet w_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? z_(MedicationRequest MR) {
            IEnumerable<Medication> ge_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gf_(Medication M) {
                object gi_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gk_ = context.Operators.Split((string)gj_, "/");
                string gl_ = context.Operators.Last<string>(gk_);
                bool? gm_ = context.Operators.Equal(gi_, gl_);
                CodeableConcept gn_ = M?.Code;
                CqlConcept go_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gn_);
                CqlValueSet gp_ = this.Dipyridamole_Medications(context);
                bool? gq_ = context.Operators.ConceptInValueSet(go_, gp_);
                bool? gr_ = context.Operators.And(gm_, gq_);
                return gr_;
            }

            IEnumerable<Medication> gg_ = context.Operators.Where<Medication>(ge_, gf_);
            bool? gh_ = context.Operators.Exists<Medication>(gg_);
            return gh_;
        }

        IEnumerable<MedicationRequest> aa_ = context.Operators.Where<MedicationRequest>(c_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(x_, aa_);
        IEnumerable<MedicationRequest> ac_ = this.moreThanOneOrder(context, ab_);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(v_, ac_);
        IEnumerable<MedicationRequest> ae_ = context.Operators.Union<MedicationRequest>(o_, ad_);
        CqlValueSet af_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ai_(MedicationRequest MR) {
            IEnumerable<Medication> gs_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gt_(Medication M) {
                object gw_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gx_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gy_ = context.Operators.Split((string)gx_, "/");
                string gz_ = context.Operators.Last<string>(gy_);
                bool? ha_ = context.Operators.Equal(gw_, gz_);
                CodeableConcept hb_ = M?.Code;
                CqlConcept hc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hb_);
                CqlValueSet hd_ = this.Guanfacine_Medications(context);
                bool? he_ = context.Operators.ConceptInValueSet(hc_, hd_);
                bool? hf_ = context.Operators.And(ha_, he_);
                return hf_;
            }

            IEnumerable<Medication> gu_ = context.Operators.Where<Medication>(gs_, gt_);
            bool? gv_ = context.Operators.Exists<Medication>(gu_);
            return gv_;
        }

        IEnumerable<MedicationRequest> aj_ = context.Operators.Where<MedicationRequest>(c_, ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ag_, aj_);
        IEnumerable<MedicationRequest> al_ = this.moreThanOneOrder(context, ak_);
        CqlValueSet am_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest> an_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ap_(MedicationRequest MR) {
            IEnumerable<Medication> hg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hh_(Medication M) {
                object hk_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hl_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hm_ = context.Operators.Split((string)hl_, "/");
                string hn_ = context.Operators.Last<string>(hm_);
                bool? ho_ = context.Operators.Equal(hk_, hn_);
                CodeableConcept hp_ = M?.Code;
                CqlConcept hq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hp_);
                CqlValueSet hr_ = this.Nifedipine_Medications(context);
                bool? hs_ = context.Operators.ConceptInValueSet(hq_, hr_);
                bool? ht_ = context.Operators.And(ho_, hs_);
                return ht_;
            }

            IEnumerable<Medication> hi_ = context.Operators.Where<Medication>(hg_, hh_);
            bool? hj_ = context.Operators.Exists<Medication>(hi_);
            return hj_;
        }

        IEnumerable<MedicationRequest> aq_ = context.Operators.Where<MedicationRequest>(c_, ap_);
        IEnumerable<MedicationRequest> ar_ = context.Operators.Union<MedicationRequest>(an_, aq_);
        IEnumerable<MedicationRequest> as_ = this.moreThanOneOrder(context, ar_);
        IEnumerable<MedicationRequest> at_ = context.Operators.Union<MedicationRequest>(al_, as_);
        IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(ae_, at_);
        CqlValueSet av_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ay_(MedicationRequest MR) {
            IEnumerable<Medication> hu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hv_(Medication M) {
                object hy_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ia_ = context.Operators.Split((string)hz_, "/");
                string ib_ = context.Operators.Last<string>(ia_);
                bool? ic_ = context.Operators.Equal(hy_, ib_);
                CodeableConcept id_ = M?.Code;
                CqlConcept ie_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, id_);
                CqlValueSet if_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
                bool? ig_ = context.Operators.ConceptInValueSet(ie_, if_);
                bool? ih_ = context.Operators.And(ic_, ig_);
                return ih_;
            }

            IEnumerable<Medication> hw_ = context.Operators.Where<Medication>(hu_, hv_);
            bool? hx_ = context.Operators.Exists<Medication>(hw_);
            return hx_;
        }

        IEnumerable<MedicationRequest> az_ = context.Operators.Where<MedicationRequest>(c_, ay_);
        IEnumerable<MedicationRequest> ba_ = context.Operators.Union<MedicationRequest>(aw_, az_);
        IEnumerable<MedicationRequest> bb_ = this.moreThanOneOrder(context, ba_);
        CqlValueSet bc_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest> bd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bf_(MedicationRequest MR) {
            IEnumerable<Medication> ii_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ij_(Medication M) {
                object im_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object in_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> io_ = context.Operators.Split((string)in_, "/");
                string ip_ = context.Operators.Last<string>(io_);
                bool? iq_ = context.Operators.Equal(im_, ip_);
                CodeableConcept ir_ = M?.Code;
                CqlConcept is_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ir_);
                CqlValueSet it_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
                bool? iu_ = context.Operators.ConceptInValueSet(is_, it_);
                bool? iv_ = context.Operators.And(iq_, iu_);
                return iv_;
            }

            IEnumerable<Medication> ik_ = context.Operators.Where<Medication>(ii_, ij_);
            bool? il_ = context.Operators.Exists<Medication>(ik_);
            return il_;
        }

        IEnumerable<MedicationRequest> bg_ = context.Operators.Where<MedicationRequest>(c_, bf_);
        IEnumerable<MedicationRequest> bh_ = context.Operators.Union<MedicationRequest>(bd_, bg_);
        IEnumerable<MedicationRequest> bi_ = this.moreThanOneOrder(context, bh_);
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bb_, bi_);
        IEnumerable<MedicationRequest> bk_ = context.Operators.Union<MedicationRequest>(au_, bj_);
        CqlCode bl_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> bm_ = context.Operators.ToList<CqlCode>(bl_);
        IEnumerable<MedicationRequest> bn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, bm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bp_(MedicationRequest MR) {
            IEnumerable<Medication> iw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ix_(Medication M) {
                object ja_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object jb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jc_ = context.Operators.Split((string)jb_, "/");
                string jd_ = context.Operators.Last<string>(jc_);
                bool? je_ = context.Operators.Equal(ja_, jd_);
                CodeableConcept jf_ = M?.Code;
                CqlConcept jg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jf_);
                CqlCode jh_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
                CqlConcept ji_ = context.Operators.ConvertCodeToConcept(jh_);
                bool? jj_ = context.Operators.Equivalent(jg_, ji_);
                bool? jk_ = context.Operators.And(je_, jj_);
                return jk_;
            }

            IEnumerable<Medication> iy_ = context.Operators.Where<Medication>(iw_, ix_);
            bool? iz_ = context.Operators.Exists<Medication>(iy_);
            return iz_;
        }

        IEnumerable<MedicationRequest> bq_ = context.Operators.Where<MedicationRequest>(c_, bp_);
        IEnumerable<MedicationRequest> br_ = context.Operators.Union<MedicationRequest>(bn_, bq_);
        IEnumerable<MedicationRequest> bs_ = this.moreThanOneOrder(context, br_);
        CqlValueSet bt_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest> bu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bw_(MedicationRequest MR) {
            IEnumerable<Medication> jl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jm_(Medication M) {
                object jp_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object jq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jr_ = context.Operators.Split((string)jq_, "/");
                string js_ = context.Operators.Last<string>(jr_);
                bool? jt_ = context.Operators.Equal(jp_, js_);
                CodeableConcept ju_ = M?.Code;
                CqlConcept jv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ju_);
                CqlValueSet jw_ = this.Meprobamate_Medications(context);
                bool? jx_ = context.Operators.ConceptInValueSet(jv_, jw_);
                bool? jy_ = context.Operators.And(jt_, jx_);
                return jy_;
            }

            IEnumerable<Medication> jn_ = context.Operators.Where<Medication>(jl_, jm_);
            bool? jo_ = context.Operators.Exists<Medication>(jn_);
            return jo_;
        }

        IEnumerable<MedicationRequest> bx_ = context.Operators.Where<MedicationRequest>(c_, bw_);
        IEnumerable<MedicationRequest> by_ = context.Operators.Union<MedicationRequest>(bu_, bx_);
        IEnumerable<MedicationRequest> bz_ = this.moreThanOneOrder(context, by_);
        IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bs_, bz_);
        IEnumerable<MedicationRequest> cb_ = context.Operators.Union<MedicationRequest>(bk_, ca_);
        CqlValueSet cc_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest> cd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? cf_(MedicationRequest MR) {
            IEnumerable<Medication> jz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ka_(Medication M) {
                object kd_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ke_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kf_ = context.Operators.Split((string)ke_, "/");
                string kg_ = context.Operators.Last<string>(kf_);
                bool? kh_ = context.Operators.Equal(kd_, kg_);
                CodeableConcept ki_ = M?.Code;
                CqlConcept kj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ki_);
                CqlValueSet kk_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
                bool? kl_ = context.Operators.ConceptInValueSet(kj_, kk_);
                bool? km_ = context.Operators.And(kh_, kl_);
                return km_;
            }

            IEnumerable<Medication> kb_ = context.Operators.Where<Medication>(jz_, ka_);
            bool? kc_ = context.Operators.Exists<Medication>(kb_);
            return kc_;
        }

        IEnumerable<MedicationRequest> cg_ = context.Operators.Where<MedicationRequest>(c_, cf_);
        IEnumerable<MedicationRequest> ch_ = context.Operators.Union<MedicationRequest>(cd_, cg_);
        IEnumerable<MedicationRequest> ci_ = this.moreThanOneOrder(context, ch_);
        CqlValueSet cj_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ck_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? cm_(MedicationRequest MR) {
            IEnumerable<Medication> kn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ko_(Medication M) {
                object kr_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ks_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kt_ = context.Operators.Split((string)ks_, "/");
                string ku_ = context.Operators.Last<string>(kt_);
                bool? kv_ = context.Operators.Equal(kr_, ku_);
                CodeableConcept kw_ = M?.Code;
                CqlConcept kx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kw_);
                CqlValueSet ky_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
                bool? kz_ = context.Operators.ConceptInValueSet(kx_, ky_);
                bool? la_ = context.Operators.And(kv_, kz_);
                return la_;
            }

            IEnumerable<Medication> kp_ = context.Operators.Where<Medication>(kn_, ko_);
            bool? kq_ = context.Operators.Exists<Medication>(kp_);
            return kq_;
        }

        IEnumerable<MedicationRequest> cn_ = context.Operators.Where<MedicationRequest>(c_, cm_);
        IEnumerable<MedicationRequest> co_ = context.Operators.Union<MedicationRequest>(ck_, cn_);
        IEnumerable<MedicationRequest> cp_ = this.moreThanOneOrder(context, co_);
        IEnumerable<MedicationRequest> cq_ = context.Operators.Union<MedicationRequest>(ci_, cp_);
        IEnumerable<MedicationRequest> cr_ = context.Operators.Union<MedicationRequest>(cb_, cq_);
        CqlValueSet cs_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest> ct_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? cv_(MedicationRequest MR) {
            IEnumerable<Medication> lb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lc_(Medication M) {
                object lf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> lh_ = context.Operators.Split((string)lg_, "/");
                string li_ = context.Operators.Last<string>(lh_);
                bool? lj_ = context.Operators.Equal(lf_, li_);
                CodeableConcept lk_ = M?.Code;
                CqlConcept ll_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lk_);
                CqlValueSet lm_ = this.Desiccated_Thyroid_Medications(context);
                bool? ln_ = context.Operators.ConceptInValueSet(ll_, lm_);
                bool? lo_ = context.Operators.And(lj_, ln_);
                return lo_;
            }

            IEnumerable<Medication> ld_ = context.Operators.Where<Medication>(lb_, lc_);
            bool? le_ = context.Operators.Exists<Medication>(ld_);
            return le_;
        }

        IEnumerable<MedicationRequest> cw_ = context.Operators.Where<MedicationRequest>(c_, cv_);
        IEnumerable<MedicationRequest> cx_ = context.Operators.Union<MedicationRequest>(ct_, cw_);
        IEnumerable<MedicationRequest> cy_ = this.moreThanOneOrder(context, cx_);
        CqlValueSet cz_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> da_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? dc_(MedicationRequest MR) {
            IEnumerable<Medication> lp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lq_(Medication M) {
                object lt_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> lv_ = context.Operators.Split((string)lu_, "/");
                string lw_ = context.Operators.Last<string>(lv_);
                bool? lx_ = context.Operators.Equal(lt_, lw_);
                CodeableConcept ly_ = M?.Code;
                CqlConcept lz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ly_);
                CqlValueSet ma_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
                bool? mb_ = context.Operators.ConceptInValueSet(lz_, ma_);
                bool? mc_ = context.Operators.And(lx_, mb_);
                return mc_;
            }

            IEnumerable<Medication> lr_ = context.Operators.Where<Medication>(lp_, lq_);
            bool? ls_ = context.Operators.Exists<Medication>(lr_);
            return ls_;
        }

        IEnumerable<MedicationRequest> dd_ = context.Operators.Where<MedicationRequest>(c_, dc_);
        IEnumerable<MedicationRequest> de_ = context.Operators.Union<MedicationRequest>(da_, dd_);
        IEnumerable<MedicationRequest> df_ = this.moreThanOneOrder(context, de_);
        IEnumerable<MedicationRequest> dg_ = context.Operators.Union<MedicationRequest>(cy_, df_);
        IEnumerable<MedicationRequest> dh_ = context.Operators.Union<MedicationRequest>(cr_, dg_);
        CqlValueSet di_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, di_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? dl_(MedicationRequest MR) {
            IEnumerable<Medication> md_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? me_(Medication M) {
                object mh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> mj_ = context.Operators.Split((string)mi_, "/");
                string mk_ = context.Operators.Last<string>(mj_);
                bool? ml_ = context.Operators.Equal(mh_, mk_);
                CodeableConcept mm_ = M?.Code;
                CqlConcept mn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mm_);
                CqlValueSet mo_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
                bool? mp_ = context.Operators.ConceptInValueSet(mn_, mo_);
                bool? mq_ = context.Operators.And(ml_, mp_);
                return mq_;
            }

            IEnumerable<Medication> mf_ = context.Operators.Where<Medication>(md_, me_);
            bool? mg_ = context.Operators.Exists<Medication>(mf_);
            return mg_;
        }

        IEnumerable<MedicationRequest> dm_ = context.Operators.Where<MedicationRequest>(c_, dl_);
        IEnumerable<MedicationRequest> dn_ = context.Operators.Union<MedicationRequest>(dj_, dm_);
        IEnumerable<MedicationRequest> do_ = this.moreThanOneOrder(context, dn_);
        CqlValueSet dp_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ds_(MedicationRequest MR) {
            IEnumerable<Medication> mr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ms_(Medication M) {
                object mv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> mx_ = context.Operators.Split((string)mw_, "/");
                string my_ = context.Operators.Last<string>(mx_);
                bool? mz_ = context.Operators.Equal(mv_, my_);
                CodeableConcept na_ = M?.Code;
                CqlConcept nb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, na_);
                CqlValueSet nc_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
                bool? nd_ = context.Operators.ConceptInValueSet(nb_, nc_);
                bool? ne_ = context.Operators.And(mz_, nd_);
                return ne_;
            }

            IEnumerable<Medication> mt_ = context.Operators.Where<Medication>(mr_, ms_);
            bool? mu_ = context.Operators.Exists<Medication>(mt_);
            return mu_;
        }

        IEnumerable<MedicationRequest> dt_ = context.Operators.Where<MedicationRequest>(c_, ds_);
        IEnumerable<MedicationRequest> du_ = context.Operators.Union<MedicationRequest>(dq_, dt_);
        IEnumerable<MedicationRequest> dv_ = this.moreThanOneOrder(context, du_);
        IEnumerable<MedicationRequest> dw_ = context.Operators.Union<MedicationRequest>(do_, dv_);
        IEnumerable<MedicationRequest> dx_ = context.Operators.Union<MedicationRequest>(dh_, dw_);
        CqlValueSet dy_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest> dz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? eb_(MedicationRequest MR) {
            IEnumerable<Medication> nf_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ng_(Medication M) {
                object nj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object nk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> nl_ = context.Operators.Split((string)nk_, "/");
                string nm_ = context.Operators.Last<string>(nl_);
                bool? nn_ = context.Operators.Equal(nj_, nm_);
                CodeableConcept no_ = M?.Code;
                CqlConcept np_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, no_);
                CqlValueSet nq_ = this.Megestrol_Medications(context);
                bool? nr_ = context.Operators.ConceptInValueSet(np_, nq_);
                bool? ns_ = context.Operators.And(nn_, nr_);
                return ns_;
            }

            IEnumerable<Medication> nh_ = context.Operators.Where<Medication>(nf_, ng_);
            bool? ni_ = context.Operators.Exists<Medication>(nh_);
            return ni_;
        }

        IEnumerable<MedicationRequest> ec_ = context.Operators.Where<MedicationRequest>(c_, eb_);
        IEnumerable<MedicationRequest> ed_ = context.Operators.Union<MedicationRequest>(dz_, ec_);
        IEnumerable<MedicationRequest> ee_ = this.moreThanOneOrder(context, ed_);
        CqlValueSet ef_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest> eg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ef_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ei_(MedicationRequest MR) {
            IEnumerable<Medication> nt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? nu_(Medication M) {
                object nx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ny_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> nz_ = context.Operators.Split((string)ny_, "/");
                string oa_ = context.Operators.Last<string>(nz_);
                bool? ob_ = context.Operators.Equal(nx_, oa_);
                CodeableConcept oc_ = M?.Code;
                CqlConcept od_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, oc_);
                CqlValueSet oe_ = this.Meperidine_Medications(context);
                bool? of_ = context.Operators.ConceptInValueSet(od_, oe_);
                bool? og_ = context.Operators.And(ob_, of_);
                return og_;
            }

            IEnumerable<Medication> nv_ = context.Operators.Where<Medication>(nt_, nu_);
            bool? nw_ = context.Operators.Exists<Medication>(nv_);
            return nw_;
        }

        IEnumerable<MedicationRequest> ej_ = context.Operators.Where<MedicationRequest>(c_, ei_);
        IEnumerable<MedicationRequest> ek_ = context.Operators.Union<MedicationRequest>(eg_, ej_);
        IEnumerable<MedicationRequest> el_ = this.moreThanOneOrder(context, ek_);
        IEnumerable<MedicationRequest> em_ = context.Operators.Union<MedicationRequest>(ee_, el_);
        IEnumerable<MedicationRequest> en_ = context.Operators.Union<MedicationRequest>(dx_, em_);
        return en_;
    }


    [CqlFunctionDefinition("medicationRequestPeriodInDays")]
    public decimal? medicationRequestPeriodInDays(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];

        decimal? b_(MedicationRequest R) {
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
            CqlQuantity bb_ = CumulativeMedicationDuration_6_0_000.Instance.Quantity(context, at_, ba_);
            decimal? bc_ = CumulativeMedicationDuration_6_0_000.Instance.ToDaily(context, ah_ ?? an_, bb_);
            Dosage be_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
            Timing bf_ = be_?.Timing;
            Timing.RepeatComponent bg_ = bf_?.Repeat;
            List<Time> bh_ = bg_?.TimeOfDayElement;

            string bi_(Time @this) {
                string bw_ = @this?.Value;
                return bw_;
            }

            IEnumerable<string> bj_ = context.Operators.Select<Time, string>((IEnumerable<Time>)bh_, bi_);

            CqlTime bk_(string @string) {
                CqlTime bx_ = context.Operators.ConvertStringToTime(@string);
                return bx_;
            }

            IEnumerable<CqlTime> bl_ = context.Operators.Select<string, CqlTime>(bj_, bk_);
            int? bm_ = context.Operators.Count<CqlTime>(bl_);
            decimal? bn_ = context.Operators.ConvertIntegerToDecimal(bm_);
            decimal? bo_ = context.Operators.Multiply(ab_, (bc_ ?? bn_) ?? 1.0m);
            decimal? bp_ = context.Operators.Divide(n_, bo_);
            UnsignedInt br_ = f_?.NumberOfRepeatsAllowedElement;
            int? bs_ = br_?.Value;
            int? bt_ = context.Operators.Add(1, bs_ ?? 0);
            decimal? bu_ = context.Operators.ConvertIntegerToDecimal(bt_);
            decimal? bv_ = context.Operators.Multiply(j_ ?? bp_, bu_);
            return bv_;
        }

        IEnumerable<decimal?> c_ = context.Operators.Select<MedicationRequest, decimal?>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<decimal?> d_ = context.Operators.Distinct<decimal?>(c_);
        decimal? e_ = context.Operators.SingletonFrom<decimal?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_High_Risk_Medications_with_Prolonged_Duration, Two_High_Risk_Medications_with_Prolonged_Duration_Compute);

    private const long _cacheIndex_Two_High_Risk_Medications_with_Prolonged_Duration = -8402263243327309117L;

    private bool? Two_High_Risk_Medications_with_Prolonged_Duration_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? n_(Medication M) {
                object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                string t_ = context.Operators.Last<string>(s_);
                bool? u_ = context.Operators.Equal(q_, t_);
                CodeableConcept v_ = M?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlValueSet x_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
                bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                bool? z_ = context.Operators.And(u_, y_);
                return z_;
            }

            IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
            bool? p_ = context.Operators.Exists<Medication>(o_);
            return p_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);

        decimal? h_(MedicationRequest AntiInfectives) {
            decimal? aa_ = this.medicationRequestPeriodInDays(context, AntiInfectives);
            return aa_;
        }

        IEnumerable<decimal?> i_ = context.Operators.Select<MedicationRequest, decimal?>(g_, h_);
        decimal? j_ = context.Operators.Sum(i_);
        decimal? k_ = context.Operators.ConvertIntegerToDecimal(90);
        bool? l_ = context.Operators.Greater(j_, k_);
        return l_;
    }


    [CqlFunctionDefinition("averageDailyDose")]
    public CqlQuantity averageDailyDose(CqlContext context, MedicationRequest MedicationRequest)
    {
        MedicationRequest[] a_ = [
            MedicationRequest,
        ];

        CqlQuantity b_(MedicationRequest Order) {

            CqlQuantity f_() {

                bool g_() {
                    decimal? h_ = this.medicationRequestPeriodInDays(context, Order);
                    bool? i_ = context.Operators.Not((bool?)(h_ is null));
                    CqlConcept j_ = CQMCommon_4_1_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity k_ = this.medicationStrengthPerUnit(context, j_);
                    string l_ = k_?.unit;
                    bool? m_ = context.Operators.Equal(l_, "mg");
                    CqlQuantity o_ = this.medicationStrengthPerUnit(context, j_);
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
                }

                if (g_())
                {
                    MedicationRequest.DispenseRequestComponent z_ = Order?.DispenseRequest;
                    Quantity aa_ = z_?.Quantity;
                    CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                    CqlConcept ac_ = CQMCommon_4_1_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity ad_ = this.medicationStrengthPerUnit(context, ac_);
                    CqlQuantity ae_ = context.Operators.Multiply(ab_, ad_);
                    decimal? af_ = this.medicationRequestPeriodInDays(context, Order);
                    CqlQuantity ag_ = context.Operators.Divide(ae_, new CqlQuantity(af_, "d"));
                    return ag_;
                }
                else
                {
                    return default;
                };
            }

            return f_();
        }

        IEnumerable<CqlQuantity> c_ = context.Operators.Select<MedicationRequest, CqlQuantity>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<CqlQuantity> d_ = context.Operators.Distinct<CqlQuantity>(c_);
        CqlQuantity e_ = context.Operators.SingletonFrom<CqlQuantity>(d_);
        return e_;
    }


    [CqlFunctionDefinition("medicationStrengthPerUnit")]
    public CqlQuantity medicationStrengthPerUnit(CqlContext context, CqlConcept Strength)
    {

        CqlQuantity a_() {

            bool b_() {
                CqlCode q_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(Strength, r_);
                return s_ ?? false;
            }


            bool c_() {
                CqlCode t_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(Strength, u_);
                return v_ ?? false;
            }


            bool d_() {
                CqlCode w_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
                CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                bool? y_ = context.Operators.Equivalent(Strength, x_);
                return y_ ?? false;
            }


            bool e_() {
                CqlCode z_ = this.digoxin_0_125_MG_Oral_Tablet(context);
                CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                bool? ab_ = context.Operators.Equivalent(Strength, aa_);
                return ab_ ?? false;
            }


            bool f_() {
                CqlCode ac_ = this.digoxin_0_25_MG_Oral_Tablet(context);
                CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                bool? ae_ = context.Operators.Equivalent(Strength, ad_);
                return ae_ ?? false;
            }


            bool g_() {
                CqlCode af_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
                CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
                bool? ah_ = context.Operators.Equivalent(Strength, ag_);
                return ah_ ?? false;
            }


            bool h_() {
                CqlCode ai_ = this.doxepin_3_MG_Oral_Tablet(context);
                CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
                bool? ak_ = context.Operators.Equivalent(Strength, aj_);
                return ak_ ?? false;
            }


            bool i_() {
                CqlCode al_ = this.doxepin_6_MG_Oral_Tablet(context);
                CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
                bool? an_ = context.Operators.Equivalent(Strength, am_);
                return an_ ?? false;
            }


            bool j_() {
                CqlCode ao_ = this.doxepin_10_MG_Oral_Capsule(context);
                CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                bool? aq_ = context.Operators.Equivalent(Strength, ap_);
                return aq_ ?? false;
            }


            bool k_() {
                CqlCode ar_ = this.doxepin_10_MG_ML_Oral_Solution(context);
                CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
                bool? at_ = context.Operators.Equivalent(Strength, as_);
                return at_ ?? false;
            }


            bool l_() {
                CqlCode au_ = this.doxepin_25_MG_Oral_Capsule(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(Strength, av_);
                return aw_ ?? false;
            }


            bool m_() {
                CqlCode ax_ = this.doxepin_50_MG_Oral_Capsule(context);
                CqlConcept ay_ = context.Operators.ConvertCodeToConcept(ax_);
                bool? az_ = context.Operators.Equivalent(Strength, ay_);
                return az_ ?? false;
            }


            bool n_() {
                CqlCode ba_ = this.doxepin_75_MG_Oral_Capsule(context);
                CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                bool? bc_ = context.Operators.Equivalent(Strength, bb_);
                return bc_ ?? false;
            }


            bool o_() {
                CqlCode bd_ = this.doxepin_100_MG_Oral_Capsule(context);
                CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                bool? bf_ = context.Operators.Equivalent(Strength, be_);
                return bf_ ?? false;
            }


            bool p_() {
                CqlCode bg_ = this.doxepin_150_MG_Oral_Capsule(context);
                CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
                bool? bi_ = context.Operators.Equivalent(Strength, bh_);
                return bi_ ?? false;
            }

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
            };
        }

        return a_();
    }


    [CqlExpressionDefinition("High Risk Medications with Average Daily Dose Criteria")]
    public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_High_Risk_Medications_with_Average_Daily_Dose_Criteria, High_Risk_Medications_with_Average_Daily_Dose_Criteria_Compute);

    private const long _cacheIndex_High_Risk_Medications_with_Average_Daily_Dose_Criteria = -4939737892995592945L;

    private bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Digoxin_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> v_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? w_(Medication M) {
                object z_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object aa_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ab_ = context.Operators.Split((string)aa_, "/");
                string ac_ = context.Operators.Last<string>(ab_);
                bool? ad_ = context.Operators.Equal(z_, ac_);
                CodeableConcept ae_ = M?.Code;
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
                CqlValueSet ag_ = this.Digoxin_Medications(context);
                bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                bool? ai_ = context.Operators.And(ad_, ah_);
                return ai_;
            }

            IEnumerable<Medication> x_ = context.Operators.Where<Medication>(v_, w_);
            bool? y_ = context.Operators.Exists<Medication>(x_);
            return y_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest DigoxinOrdered) {
            CqlQuantity aj_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity ak_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? al_ = context.Operators.Greater(aj_, ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = this.moreThanOneOrder(context, h_);
        bool? j_ = context.Operators.Exists<MedicationRequest>(i_);
        CqlValueSet k_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? n_(MedicationRequest MR) {
            IEnumerable<Medication> am_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? an_(Medication M) {
                object aq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ar_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> as_ = context.Operators.Split((string)ar_, "/");
                string at_ = context.Operators.Last<string>(as_);
                bool? au_ = context.Operators.Equal(aq_, at_);
                CodeableConcept av_ = M?.Code;
                CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
                CqlValueSet ax_ = this.Doxepin_Medications(context);
                bool? ay_ = context.Operators.ConceptInValueSet(aw_, ax_);
                bool? az_ = context.Operators.And(au_, ay_);
                return az_;
            }

            IEnumerable<Medication> ao_ = context.Operators.Where<Medication>(am_, an_);
            bool? ap_ = context.Operators.Exists<Medication>(ao_);
            return ap_;
        }

        IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(c_, n_);
        IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(l_, o_);

        bool? q_(MedicationRequest DoxepinOrdered) {
            CqlQuantity ba_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity bb_ = context.Operators.Quantity(6m, "mg/d");
            bool? bc_ = context.Operators.Greater(ba_, bb_);
            return bc_;
        }

        IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(p_, q_);
        IEnumerable<MedicationRequest> s_ = this.moreThanOneOrder(context, r_);
        bool? t_ = context.Operators.Exists<MedicationRequest>(s_);
        bool? u_ = context.Operators.Or(j_, t_);
        return u_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = 6657473660832751437L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
        bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
        bool? c_ = this.Two_High_Risk_Medications_with_Prolonged_Duration(context);
        bool? d_ = context.Operators.Or(b_, c_);
        bool? e_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria(context);
        bool? f_ = context.Operators.Or(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("More than One Antipsychotic Order")]
    public bool? More_than_One_Antipsychotic_Order(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_More_than_One_Antipsychotic_Order, More_than_One_Antipsychotic_Order_Compute);

    private const long _cacheIndex_More_than_One_Antipsychotic_Order = -5339672906553000170L;

    private bool? More_than_One_Antipsychotic_Order_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);
        bool? h_ = context.Operators.Exists<MedicationRequest>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Schizophrenia Diagnosis")]
    public IEnumerable<Condition> Schizophrenia_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Schizophrenia_Diagnosis, Schizophrenia_Diagnosis_Compute);

    private const long _cacheIndex_Schizophrenia_Diagnosis = 2608599169925942613L;

    private IEnumerable<Condition> Schizophrenia_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Schizophrenia(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("Bipolar Disorder Diagnosis")]
    public IEnumerable<Condition> Bipolar_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bipolar_Disorder_Diagnosis, Bipolar_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_Bipolar_Disorder_Diagnosis = 3459923094508400090L;

    private IEnumerable<Condition> Bipolar_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("Antipsychotic Index Prescription Start Date")]
    public CqlDateTime Antipsychotic_Index_Prescription_Start_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Antipsychotic_Index_Prescription_Start_Date, Antipsychotic_Index_Prescription_Start_Date_Compute);

    private const long _cacheIndex_Antipsychotic_Index_Prescription_Start_Date = -2392062725737743630L;

    private CqlDateTime Antipsychotic_Index_Prescription_Start_Date_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication M) {
                object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(s_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                return ab_;
            }

            IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
            bool? r_ = context.Operators.Exists<Medication>(q_);
            return r_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest AntipsychoticMedication) {
            FhirDateTime ac_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime ad_ = context.Operators.Convert<CqlDateTime>(ac_);
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            bool? af_ = context.Operators.In<CqlDateTime>(ad_, ae_, (string)default);
            return af_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);

        CqlDateTime j_(MedicationRequest AntipsychoticMedication) {
            FhirDateTime ag_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
            return ah_;
        }

        IEnumerable<CqlDateTime> k_ = context.Operators.Select<MedicationRequest, CqlDateTime>(i_, j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.Distinct<CqlDateTime>(k_);
        IEnumerable<CqlDateTime> m_ = context.Operators.ListSort<CqlDateTime>(l_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime n_ = context.Operators.First<CqlDateTime>(m_);
        return n_;
    }


    [CqlExpressionDefinition("More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_More_than_One_Benzodiazepine_Order, More_than_One_Benzodiazepine_Order_Compute);

    private const long _cacheIndex_More_than_One_Benzodiazepine_Order = -7787489465336773734L;

    private bool? More_than_One_Benzodiazepine_Order_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);
        bool? h_ = context.Operators.Exists<MedicationRequest>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Seizure Disorder Diagnosis")]
    public IEnumerable<Condition> Seizure_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Seizure_Disorder_Diagnosis, Seizure_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_Seizure_Disorder_Diagnosis = -1131365608370837245L;

    private IEnumerable<Condition> Seizure_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Seizure_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("REM Sleep Behavior Disorder Diagnosis")]
    public IEnumerable<Condition> REM_Sleep_Behavior_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_REM_Sleep_Behavior_Disorder_Diagnosis, REM_Sleep_Behavior_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_REM_Sleep_Behavior_Disorder_Diagnosis = 1960016341670198298L;

    private IEnumerable<Condition> REM_Sleep_Behavior_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.REM_Sleep_Behavior_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("Benzodiazepine Withdrawal Diagnosis")]
    public IEnumerable<Condition> Benzodiazepine_Withdrawal_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Benzodiazepine_Withdrawal_Diagnosis, Benzodiazepine_Withdrawal_Diagnosis_Compute);

    private const long _cacheIndex_Benzodiazepine_Withdrawal_Diagnosis = 8657316729577408796L;

    private IEnumerable<Condition> Benzodiazepine_Withdrawal_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Benzodiazepine_Withdrawal(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("Alcohol Withdrawal Diagnosis")]
    public IEnumerable<Condition> Alcohol_Withdrawal_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Alcohol_Withdrawal_Diagnosis, Alcohol_Withdrawal_Diagnosis_Compute);

    private const long _cacheIndex_Alcohol_Withdrawal_Diagnosis = -4814865430801165110L;

    private IEnumerable<Condition> Alcohol_Withdrawal_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Alcohol_Withdrawal(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("Generalized Anxiety Disorder Diagnosis")]
    public IEnumerable<Condition> Generalized_Anxiety_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Generalized_Anxiety_Disorder_Diagnosis, Generalized_Anxiety_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_Generalized_Anxiety_Disorder_Diagnosis = -2199162515832252667L;

    private IEnumerable<Condition> Generalized_Anxiety_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Generalized_Anxiety_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);
        return f_;
    }


    [CqlExpressionDefinition("Benzodiazepine Index Prescription Start Date")]
    public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Benzodiazepine_Index_Prescription_Start_Date, Benzodiazepine_Index_Prescription_Start_Date_Compute);

    private const long _cacheIndex_Benzodiazepine_Index_Prescription_Start_Date = -4082436594742457808L;

    private CqlDateTime Benzodiazepine_Index_Prescription_Start_Date_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? p_(Medication M) {
                object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(s_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                return ab_;
            }

            IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
            bool? r_ = context.Operators.Exists<Medication>(q_);
            return r_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest BenzodiazepineMedication) {
            FhirDateTime ac_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime ad_ = context.Operators.Convert<CqlDateTime>(ac_);
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            bool? af_ = context.Operators.In<CqlDateTime>(ad_, ae_, (string)default);
            return af_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);

        CqlDateTime j_(MedicationRequest BenzodiazepineMedication) {
            FhirDateTime ag_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
            return ah_;
        }

        IEnumerable<CqlDateTime> k_ = context.Operators.Select<MedicationRequest, CqlDateTime>(i_, j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.Distinct<CqlDateTime>(k_);
        IEnumerable<CqlDateTime> m_ = context.Operators.ListSort<CqlDateTime>(l_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime n_ = context.Operators.First<CqlDateTime>(m_);
        return n_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -3712140800662252754L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        bool? a_ = this.More_than_One_Antipsychotic_Order(context);
        IEnumerable<Condition> b_ = this.Schizophrenia_Diagnosis(context);
        IEnumerable<Condition> c_ = this.Bipolar_Disorder_Diagnosis(context);
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_, c_);

        bool? e_(Condition AntipsychoticTreatedDiagnoses) {
            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
            CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlQuantity ac_ = context.Operators.Quantity(1m, "year");
            CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
            CqlDateTime ae_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ad_, ae_, true, true);
            bool? ag_ = context.Operators.Overlaps(z_, af_, (string)default);
            return ag_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);
        bool? h_ = context.Operators.Not(g_);
        bool? i_ = context.Operators.And(a_, h_);
        bool? j_ = this.More_than_One_Benzodiazepine_Order(context);
        IEnumerable<Condition> k_ = this.Seizure_Disorder_Diagnosis(context);
        IEnumerable<Condition> l_ = this.REM_Sleep_Behavior_Disorder_Diagnosis(context);
        IEnumerable<Condition> m_ = context.Operators.Union<Condition>(k_, l_);
        IEnumerable<Condition> n_ = this.Benzodiazepine_Withdrawal_Diagnosis(context);
        IEnumerable<Condition> o_ = this.Alcohol_Withdrawal_Diagnosis(context);
        IEnumerable<Condition> p_ = context.Operators.Union<Condition>(n_, o_);
        IEnumerable<Condition> q_ = context.Operators.Union<Condition>(m_, p_);
        IEnumerable<Condition> r_ = this.Generalized_Anxiety_Disorder_Diagnosis(context);
        IEnumerable<Condition> s_ = context.Operators.Union<Condition>(q_, r_);

        bool? t_(Condition BenzodiazepineTreatedDiagnoses) {
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
            CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
            CqlDateTime al_ = context.Operators.Subtract(aj_, ak_);
            CqlDateTime am_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(al_, am_, true, true);
            bool? ao_ = context.Operators.Overlaps(ah_, an_, (string)default);
            return ao_;
        }

        IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
        bool? v_ = context.Operators.Exists<Condition>(u_);
        bool? w_ = context.Operators.Not(v_);
        bool? x_ = context.Operators.And(j_, w_);
        bool? y_ = context.Operators.Or(i_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_3, Numerator_3_Compute);

    private const long _cacheIndex_Numerator_3 = 1791115892679114642L;

    private bool? Numerator_3_Compute(CqlContext context)
    {
        bool? a_ = this.Numerator_2(context);
        bool? b_ = this.Numerator_1(context);
        bool? d_ = context.Operators.Not(a_);
        bool? e_ = context.Operators.And(b_, d_);
        bool? f_ = context.Operators.Or(a_, e_);
        return f_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 9018702827967443542L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 1955720262168920359L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 7680980797223397342L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -5152880206814246566L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS156FHIRHighRiskMedsElderly_1_0_000() {}

    public static CMS156FHIRHighRiskMedsElderly_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS156FHIRHighRiskMedsElderly";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, QICoreCommon_4_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
