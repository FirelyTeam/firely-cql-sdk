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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
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
                CqlDate t_ = context.Operators.DateFrom(l_);
                FhirDateTime u_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
                CqlDate w_ = context.Operators.DateFrom(v_);
                bool? x_ = context.Operators.Equivalent(t_, w_);
                bool? y_ = context.Operators.Not(x_);
                bool? z_ = context.Operators.And(y_, n_);
                bool? aa_ = context.Operators.In<CqlDateTime>(v_, m_, (string)default);
                bool? ab_ = context.Operators.And(z_, aa_);
                bool? ac_ = context.Operators.Or(s_, ab_);
                bool? ad_ = context.Operators.And(x_, n_);
                CqlInterval<CqlDate> ae_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate af_ = context.Operators.Start(ae_);
                CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
                CqlDate ah_ = context.Operators.DateFrom(ag_);
                CqlInterval<CqlDate> ai_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate aj_ = context.Operators.Start(ai_);
                CqlDateTime ak_ = context.Operators.ConvertDateToDateTime(aj_);
                CqlDate al_ = context.Operators.DateFrom(ak_);
                bool? am_ = context.Operators.Equivalent(ah_, al_);
                bool? an_ = context.Operators.Not(am_);
                bool? ao_ = context.Operators.And(ad_, an_);
                bool? ap_ = context.Operators.In<CqlDateTime>(ag_, m_, (string)default);
                bool? aq_ = context.Operators.And(ao_, ap_);
                bool? ar_ = context.Operators.In<CqlDateTime>(ak_, m_, (string)default);
                bool? as_ = context.Operators.And(aq_, ar_);
                bool? at_ = context.Operators.Or(ac_, as_);
                return at_;
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
            IEnumerable<Medication> dx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dy_(Medication M) {
                object eb_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ec_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ed_ = context.Operators.Split((string)ec_, "/");
                string ee_ = context.Operators.Last<string>(ed_);
                bool? ef_ = context.Operators.Equal(eb_, ee_);
                CodeableConcept eg_ = M?.Code;
                CqlConcept eh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eg_);
                CqlValueSet ei_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
                bool? ej_ = context.Operators.ConceptInValueSet(eh_, ei_);
                bool? ek_ = context.Operators.And(ef_, ej_);
                return ek_;
            }

            IEnumerable<Medication> dz_ = context.Operators.Where<Medication>(dx_, dy_);
            bool? ea_ = context.Operators.Exists<Medication>(dz_);
            return ea_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);
        CqlValueSet h_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? j_(MedicationRequest MR) {
            IEnumerable<Medication> el_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? em_(Medication M) {
                object ep_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object eq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> er_ = context.Operators.Split((string)eq_, "/");
                string es_ = context.Operators.Last<string>(er_);
                bool? et_ = context.Operators.Equal(ep_, es_);
                CodeableConcept eu_ = M?.Code;
                CqlConcept ev_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eu_);
                CqlValueSet ew_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
                bool? ex_ = context.Operators.ConceptInValueSet(ev_, ew_);
                bool? ey_ = context.Operators.And(et_, ex_);
                return ey_;
            }

            IEnumerable<Medication> en_ = context.Operators.Where<Medication>(el_, em_);
            bool? eo_ = context.Operators.Exists<Medication>(en_);
            return eo_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(c_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
        IEnumerable<MedicationRequest> m_ = this.moreThanOneOrder(context, l_);
        IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(g_, m_);
        CqlValueSet o_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? q_(MedicationRequest MR) {
            IEnumerable<Medication> ez_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fa_(Medication M) {
                object fd_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fe_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ff_ = context.Operators.Split((string)fe_, "/");
                string fg_ = context.Operators.Last<string>(ff_);
                bool? fh_ = context.Operators.Equal(fd_, fg_);
                CodeableConcept fi_ = M?.Code;
                CqlConcept fj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fi_);
                CqlValueSet fk_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
                bool? fl_ = context.Operators.ConceptInValueSet(fj_, fk_);
                bool? fm_ = context.Operators.And(fh_, fl_);
                return fm_;
            }

            IEnumerable<Medication> fb_ = context.Operators.Where<Medication>(ez_, fa_);
            bool? fc_ = context.Operators.Exists<Medication>(fb_);
            return fc_;
        }

        IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(c_, q_);
        IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(p_, r_);
        IEnumerable<MedicationRequest> t_ = this.moreThanOneOrder(context, s_);
        CqlValueSet u_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? w_(MedicationRequest MR) {
            IEnumerable<Medication> fn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fo_(Medication M) {
                object fr_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fs_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ft_ = context.Operators.Split((string)fs_, "/");
                string fu_ = context.Operators.Last<string>(ft_);
                bool? fv_ = context.Operators.Equal(fr_, fu_);
                CodeableConcept fw_ = M?.Code;
                CqlConcept fx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fw_);
                CqlValueSet fy_ = this.Dipyridamole_Medications(context);
                bool? fz_ = context.Operators.ConceptInValueSet(fx_, fy_);
                bool? ga_ = context.Operators.And(fv_, fz_);
                return ga_;
            }

            IEnumerable<Medication> fp_ = context.Operators.Where<Medication>(fn_, fo_);
            bool? fq_ = context.Operators.Exists<Medication>(fp_);
            return fq_;
        }

        IEnumerable<MedicationRequest> x_ = context.Operators.Where<MedicationRequest>(c_, w_);
        IEnumerable<MedicationRequest> y_ = context.Operators.Union<MedicationRequest>(v_, x_);
        IEnumerable<MedicationRequest> z_ = this.moreThanOneOrder(context, y_);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(t_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(n_, aa_);
        CqlValueSet ac_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ae_(MedicationRequest MR) {
            IEnumerable<Medication> gb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gc_(Medication M) {
                object gf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gh_ = context.Operators.Split((string)gg_, "/");
                string gi_ = context.Operators.Last<string>(gh_);
                bool? gj_ = context.Operators.Equal(gf_, gi_);
                CodeableConcept gk_ = M?.Code;
                CqlConcept gl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gk_);
                CqlValueSet gm_ = this.Guanfacine_Medications(context);
                bool? gn_ = context.Operators.ConceptInValueSet(gl_, gm_);
                bool? go_ = context.Operators.And(gj_, gn_);
                return go_;
            }

            IEnumerable<Medication> gd_ = context.Operators.Where<Medication>(gb_, gc_);
            bool? ge_ = context.Operators.Exists<Medication>(gd_);
            return ge_;
        }

        IEnumerable<MedicationRequest> af_ = context.Operators.Where<MedicationRequest>(c_, ae_);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = this.moreThanOneOrder(context, ag_);
        CqlValueSet ai_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest> aj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ak_(MedicationRequest MR) {
            IEnumerable<Medication> gp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gq_(Medication M) {
                object gt_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gv_ = context.Operators.Split((string)gu_, "/");
                string gw_ = context.Operators.Last<string>(gv_);
                bool? gx_ = context.Operators.Equal(gt_, gw_);
                CodeableConcept gy_ = M?.Code;
                CqlConcept gz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gy_);
                CqlValueSet ha_ = this.Nifedipine_Medications(context);
                bool? hb_ = context.Operators.ConceptInValueSet(gz_, ha_);
                bool? hc_ = context.Operators.And(gx_, hb_);
                return hc_;
            }

            IEnumerable<Medication> gr_ = context.Operators.Where<Medication>(gp_, gq_);
            bool? gs_ = context.Operators.Exists<Medication>(gr_);
            return gs_;
        }

        IEnumerable<MedicationRequest> al_ = context.Operators.Where<MedicationRequest>(c_, ak_);
        IEnumerable<MedicationRequest> am_ = context.Operators.Union<MedicationRequest>(aj_, al_);
        IEnumerable<MedicationRequest> an_ = this.moreThanOneOrder(context, am_);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Union<MedicationRequest>(ah_, an_);
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(ab_, ao_);
        CqlValueSet aq_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ar_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? as_(MedicationRequest MR) {
            IEnumerable<Medication> hd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? he_(Medication M) {
                object hh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hj_ = context.Operators.Split((string)hi_, "/");
                string hk_ = context.Operators.Last<string>(hj_);
                bool? hl_ = context.Operators.Equal(hh_, hk_);
                CodeableConcept hm_ = M?.Code;
                CqlConcept hn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hm_);
                CqlValueSet ho_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
                bool? hp_ = context.Operators.ConceptInValueSet(hn_, ho_);
                bool? hq_ = context.Operators.And(hl_, hp_);
                return hq_;
            }

            IEnumerable<Medication> hf_ = context.Operators.Where<Medication>(hd_, he_);
            bool? hg_ = context.Operators.Exists<Medication>(hf_);
            return hg_;
        }

        IEnumerable<MedicationRequest> at_ = context.Operators.Where<MedicationRequest>(c_, as_);
        IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(ar_, at_);
        IEnumerable<MedicationRequest> av_ = this.moreThanOneOrder(context, au_);
        CqlValueSet aw_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ax_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, aw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ay_(MedicationRequest MR) {
            IEnumerable<Medication> hr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hs_(Medication M) {
                object hv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hx_ = context.Operators.Split((string)hw_, "/");
                string hy_ = context.Operators.Last<string>(hx_);
                bool? hz_ = context.Operators.Equal(hv_, hy_);
                CodeableConcept ia_ = M?.Code;
                CqlConcept ib_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ia_);
                CqlValueSet ic_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
                bool? id_ = context.Operators.ConceptInValueSet(ib_, ic_);
                bool? ie_ = context.Operators.And(hz_, id_);
                return ie_;
            }

            IEnumerable<Medication> ht_ = context.Operators.Where<Medication>(hr_, hs_);
            bool? hu_ = context.Operators.Exists<Medication>(ht_);
            return hu_;
        }

        IEnumerable<MedicationRequest> az_ = context.Operators.Where<MedicationRequest>(c_, ay_);
        IEnumerable<MedicationRequest> ba_ = context.Operators.Union<MedicationRequest>(ax_, az_);
        IEnumerable<MedicationRequest> bb_ = this.moreThanOneOrder(context, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(av_, bb_);
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(ap_, bc_);
        CqlCode be_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> bf_ = context.Operators.ToList<CqlCode>(be_);
        IEnumerable<MedicationRequest> bg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, bf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bh_(MedicationRequest MR) {
            IEnumerable<Medication> if_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ig_(Medication M) {
                object ij_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ik_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> il_ = context.Operators.Split((string)ik_, "/");
                string im_ = context.Operators.Last<string>(il_);
                bool? in_ = context.Operators.Equal(ij_, im_);
                CodeableConcept io_ = M?.Code;
                CqlConcept ip_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, io_);
                CqlCode iq_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
                CqlConcept ir_ = context.Operators.ConvertCodeToConcept(iq_);
                bool? is_ = context.Operators.Equivalent(ip_, ir_);
                bool? it_ = context.Operators.And(in_, is_);
                return it_;
            }

            IEnumerable<Medication> ih_ = context.Operators.Where<Medication>(if_, ig_);
            bool? ii_ = context.Operators.Exists<Medication>(ih_);
            return ii_;
        }

        IEnumerable<MedicationRequest> bi_ = context.Operators.Where<MedicationRequest>(c_, bh_);
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bg_, bi_);
        IEnumerable<MedicationRequest> bk_ = this.moreThanOneOrder(context, bj_);
        CqlValueSet bl_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bn_(MedicationRequest MR) {
            IEnumerable<Medication> iu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? iv_(Medication M) {
                object iy_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object iz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ja_ = context.Operators.Split((string)iz_, "/");
                string jb_ = context.Operators.Last<string>(ja_);
                bool? jc_ = context.Operators.Equal(iy_, jb_);
                CodeableConcept jd_ = M?.Code;
                CqlConcept je_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jd_);
                CqlValueSet jf_ = this.Meprobamate_Medications(context);
                bool? jg_ = context.Operators.ConceptInValueSet(je_, jf_);
                bool? jh_ = context.Operators.And(jc_, jg_);
                return jh_;
            }

            IEnumerable<Medication> iw_ = context.Operators.Where<Medication>(iu_, iv_);
            bool? ix_ = context.Operators.Exists<Medication>(iw_);
            return ix_;
        }

        IEnumerable<MedicationRequest> bo_ = context.Operators.Where<MedicationRequest>(c_, bn_);
        IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bm_, bo_);
        IEnumerable<MedicationRequest> bq_ = this.moreThanOneOrder(context, bp_);
        IEnumerable<MedicationRequest> br_ = context.Operators.Union<MedicationRequest>(bk_, bq_);
        IEnumerable<MedicationRequest> bs_ = context.Operators.Union<MedicationRequest>(bd_, br_);
        CqlValueSet bt_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest> bu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bv_(MedicationRequest MR) {
            IEnumerable<Medication> ji_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jj_(Medication M) {
                object jm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object jn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> jo_ = context.Operators.Split((string)jn_, "/");
                string jp_ = context.Operators.Last<string>(jo_);
                bool? jq_ = context.Operators.Equal(jm_, jp_);
                CodeableConcept jr_ = M?.Code;
                CqlConcept js_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jr_);
                CqlValueSet jt_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
                bool? ju_ = context.Operators.ConceptInValueSet(js_, jt_);
                bool? jv_ = context.Operators.And(jq_, ju_);
                return jv_;
            }

            IEnumerable<Medication> jk_ = context.Operators.Where<Medication>(ji_, jj_);
            bool? jl_ = context.Operators.Exists<Medication>(jk_);
            return jl_;
        }

        IEnumerable<MedicationRequest> bw_ = context.Operators.Where<MedicationRequest>(c_, bv_);
        IEnumerable<MedicationRequest> bx_ = context.Operators.Union<MedicationRequest>(bu_, bw_);
        IEnumerable<MedicationRequest> by_ = this.moreThanOneOrder(context, bx_);
        CqlValueSet bz_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ca_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? cb_(MedicationRequest MR) {
            IEnumerable<Medication> jw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jx_(Medication M) {
                object ka_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kc_ = context.Operators.Split((string)kb_, "/");
                string kd_ = context.Operators.Last<string>(kc_);
                bool? ke_ = context.Operators.Equal(ka_, kd_);
                CodeableConcept kf_ = M?.Code;
                CqlConcept kg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kf_);
                CqlValueSet kh_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
                bool? ki_ = context.Operators.ConceptInValueSet(kg_, kh_);
                bool? kj_ = context.Operators.And(ke_, ki_);
                return kj_;
            }

            IEnumerable<Medication> jy_ = context.Operators.Where<Medication>(jw_, jx_);
            bool? jz_ = context.Operators.Exists<Medication>(jy_);
            return jz_;
        }

        IEnumerable<MedicationRequest> cc_ = context.Operators.Where<MedicationRequest>(c_, cb_);
        IEnumerable<MedicationRequest> cd_ = context.Operators.Union<MedicationRequest>(ca_, cc_);
        IEnumerable<MedicationRequest> ce_ = this.moreThanOneOrder(context, cd_);
        IEnumerable<MedicationRequest> cf_ = context.Operators.Union<MedicationRequest>(by_, ce_);
        IEnumerable<MedicationRequest> cg_ = context.Operators.Union<MedicationRequest>(bs_, cf_);
        CqlValueSet ch_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest> ci_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ch_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? cj_(MedicationRequest MR) {
            IEnumerable<Medication> kk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kl_(Medication M) {
                object ko_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object kp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> kq_ = context.Operators.Split((string)kp_, "/");
                string kr_ = context.Operators.Last<string>(kq_);
                bool? ks_ = context.Operators.Equal(ko_, kr_);
                CodeableConcept kt_ = M?.Code;
                CqlConcept ku_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kt_);
                CqlValueSet kv_ = this.Desiccated_Thyroid_Medications(context);
                bool? kw_ = context.Operators.ConceptInValueSet(ku_, kv_);
                bool? kx_ = context.Operators.And(ks_, kw_);
                return kx_;
            }

            IEnumerable<Medication> km_ = context.Operators.Where<Medication>(kk_, kl_);
            bool? kn_ = context.Operators.Exists<Medication>(km_);
            return kn_;
        }

        IEnumerable<MedicationRequest> ck_ = context.Operators.Where<MedicationRequest>(c_, cj_);
        IEnumerable<MedicationRequest> cl_ = context.Operators.Union<MedicationRequest>(ci_, ck_);
        IEnumerable<MedicationRequest> cm_ = this.moreThanOneOrder(context, cl_);
        CqlValueSet cn_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> co_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? cp_(MedicationRequest MR) {
            IEnumerable<Medication> ky_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kz_(Medication M) {
                object lc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ld_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> le_ = context.Operators.Split((string)ld_, "/");
                string lf_ = context.Operators.Last<string>(le_);
                bool? lg_ = context.Operators.Equal(lc_, lf_);
                CodeableConcept lh_ = M?.Code;
                CqlConcept li_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lh_);
                CqlValueSet lj_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
                bool? lk_ = context.Operators.ConceptInValueSet(li_, lj_);
                bool? ll_ = context.Operators.And(lg_, lk_);
                return ll_;
            }

            IEnumerable<Medication> la_ = context.Operators.Where<Medication>(ky_, kz_);
            bool? lb_ = context.Operators.Exists<Medication>(la_);
            return lb_;
        }

        IEnumerable<MedicationRequest> cq_ = context.Operators.Where<MedicationRequest>(c_, cp_);
        IEnumerable<MedicationRequest> cr_ = context.Operators.Union<MedicationRequest>(co_, cq_);
        IEnumerable<MedicationRequest> cs_ = this.moreThanOneOrder(context, cr_);
        IEnumerable<MedicationRequest> ct_ = context.Operators.Union<MedicationRequest>(cm_, cs_);
        IEnumerable<MedicationRequest> cu_ = context.Operators.Union<MedicationRequest>(cg_, ct_);
        CqlValueSet cv_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> cw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? cx_(MedicationRequest MR) {
            IEnumerable<Medication> lm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ln_(Medication M) {
                object lq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object lr_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ls_ = context.Operators.Split((string)lr_, "/");
                string lt_ = context.Operators.Last<string>(ls_);
                bool? lu_ = context.Operators.Equal(lq_, lt_);
                CodeableConcept lv_ = M?.Code;
                CqlConcept lw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lv_);
                CqlValueSet lx_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
                bool? ly_ = context.Operators.ConceptInValueSet(lw_, lx_);
                bool? lz_ = context.Operators.And(lu_, ly_);
                return lz_;
            }

            IEnumerable<Medication> lo_ = context.Operators.Where<Medication>(lm_, ln_);
            bool? lp_ = context.Operators.Exists<Medication>(lo_);
            return lp_;
        }

        IEnumerable<MedicationRequest> cy_ = context.Operators.Where<MedicationRequest>(c_, cx_);
        IEnumerable<MedicationRequest> cz_ = context.Operators.Union<MedicationRequest>(cw_, cy_);
        IEnumerable<MedicationRequest> da_ = this.moreThanOneOrder(context, cz_);
        CqlValueSet db_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, db_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? dd_(MedicationRequest MR) {
            IEnumerable<Medication> ma_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? mb_(Medication M) {
                object me_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> mg_ = context.Operators.Split((string)mf_, "/");
                string mh_ = context.Operators.Last<string>(mg_);
                bool? mi_ = context.Operators.Equal(me_, mh_);
                CodeableConcept mj_ = M?.Code;
                CqlConcept mk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mj_);
                CqlValueSet ml_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
                bool? mm_ = context.Operators.ConceptInValueSet(mk_, ml_);
                bool? mn_ = context.Operators.And(mi_, mm_);
                return mn_;
            }

            IEnumerable<Medication> mc_ = context.Operators.Where<Medication>(ma_, mb_);
            bool? md_ = context.Operators.Exists<Medication>(mc_);
            return md_;
        }

        IEnumerable<MedicationRequest> de_ = context.Operators.Where<MedicationRequest>(c_, dd_);
        IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(dc_, de_);
        IEnumerable<MedicationRequest> dg_ = this.moreThanOneOrder(context, df_);
        IEnumerable<MedicationRequest> dh_ = context.Operators.Union<MedicationRequest>(da_, dg_);
        IEnumerable<MedicationRequest> di_ = context.Operators.Union<MedicationRequest>(cu_, dh_);
        CqlValueSet dj_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest> dk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? dl_(MedicationRequest MR) {
            IEnumerable<Medication> mo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? mp_(Medication M) {
                object ms_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object mt_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> mu_ = context.Operators.Split((string)mt_, "/");
                string mv_ = context.Operators.Last<string>(mu_);
                bool? mw_ = context.Operators.Equal(ms_, mv_);
                CodeableConcept mx_ = M?.Code;
                CqlConcept my_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mx_);
                CqlValueSet mz_ = this.Megestrol_Medications(context);
                bool? na_ = context.Operators.ConceptInValueSet(my_, mz_);
                bool? nb_ = context.Operators.And(mw_, na_);
                return nb_;
            }

            IEnumerable<Medication> mq_ = context.Operators.Where<Medication>(mo_, mp_);
            bool? mr_ = context.Operators.Exists<Medication>(mq_);
            return mr_;
        }

        IEnumerable<MedicationRequest> dm_ = context.Operators.Where<MedicationRequest>(c_, dl_);
        IEnumerable<MedicationRequest> dn_ = context.Operators.Union<MedicationRequest>(dk_, dm_);
        IEnumerable<MedicationRequest> do_ = this.moreThanOneOrder(context, dn_);
        CqlValueSet dp_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest> dq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? dr_(MedicationRequest MR) {
            IEnumerable<Medication> nc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? nd_(Medication M) {
                object ng_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object nh_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ni_ = context.Operators.Split((string)nh_, "/");
                string nj_ = context.Operators.Last<string>(ni_);
                bool? nk_ = context.Operators.Equal(ng_, nj_);
                CodeableConcept nl_ = M?.Code;
                CqlConcept nm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nl_);
                CqlValueSet nn_ = this.Meperidine_Medications(context);
                bool? no_ = context.Operators.ConceptInValueSet(nm_, nn_);
                bool? np_ = context.Operators.And(nk_, no_);
                return np_;
            }

            IEnumerable<Medication> ne_ = context.Operators.Where<Medication>(nc_, nd_);
            bool? nf_ = context.Operators.Exists<Medication>(ne_);
            return nf_;
        }

        IEnumerable<MedicationRequest> ds_ = context.Operators.Where<MedicationRequest>(c_, dr_);
        IEnumerable<MedicationRequest> dt_ = context.Operators.Union<MedicationRequest>(dq_, ds_);
        IEnumerable<MedicationRequest> du_ = this.moreThanOneOrder(context, dt_);
        IEnumerable<MedicationRequest> dv_ = context.Operators.Union<MedicationRequest>(do_, du_);
        IEnumerable<MedicationRequest> dw_ = context.Operators.Union<MedicationRequest>(di_, dv_);
        return dw_;
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
            Quantity k_ = f_?.Quantity;
            CqlQuantity l_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, k_);
            decimal? m_ = l_?.value;
            List<Dosage> n_ = R?.DosageInstruction;
            Dosage o_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
            List<Dosage.DoseAndRateComponent> p_ = o_?.DoseAndRate;
            Dosage.DoseAndRateComponent q_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)p_);
            DataType r_ = q_?.Dose;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlQuantity t_ = context.Operators.End(s_ as CqlInterval<CqlQuantity>);
            decimal? u_ = (t_ ?? s_ as CqlQuantity)?.value;
            Timing v_ = o_?.Timing;
            Timing.RepeatComponent w_ = v_?.Repeat;
            PositiveInt x_ = w_?.FrequencyMaxElement;
            int? y_ = x_?.Value;
            PositiveInt z_ = w_?.FrequencyElement;
            int? aa_ = z_?.Value;
            FhirDecimal ab_ = w_?.PeriodElement;
            decimal? ac_ = ab_?.Value;
            Code<Timing.UnitsOfTime> ad_ = w_?.PeriodUnitElement;
            Timing.UnitsOfTime? ae_ = ad_?.Value;
            string af_ = context.Operators.Convert<string>(ae_);
            CqlQuantity ag_ = CumulativeMedicationDuration_6_0_000.Instance.Quantity(context, ac_, af_);
            decimal? ah_ = CumulativeMedicationDuration_6_0_000.Instance.ToDaily(context, y_ ?? aa_, ag_);
            List<Time> ai_ = w_?.TimeOfDayElement;

            string aj_(Time @this) {
                string aw_ = @this?.Value;
                return aw_;
            }

            IEnumerable<string> ak_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ai_, aj_);

            CqlTime al_(string @string) {
                CqlTime ax_ = context.Operators.ConvertStringToTime(@string);
                return ax_;
            }

            IEnumerable<CqlTime> am_ = context.Operators.Select<string, CqlTime>(ak_, al_);
            int? an_ = context.Operators.Count<CqlTime>(am_);
            decimal? ao_ = context.Operators.ConvertIntegerToDecimal(an_);
            decimal? ap_ = context.Operators.Multiply(u_, (ah_ ?? ao_) ?? 1.0m);
            decimal? aq_ = context.Operators.Divide(m_, ap_);
            UnsignedInt ar_ = f_?.NumberOfRepeatsAllowedElement;
            int? as_ = ar_?.Value;
            int? at_ = context.Operators.Add(1, as_ ?? 0);
            decimal? au_ = context.Operators.ConvertIntegerToDecimal(at_);
            decimal? av_ = context.Operators.Multiply(j_ ?? aq_, au_);
            return av_;
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
                    bool? n_ = context.Operators.Equal(l_, "mg/mL");
                    MedicationRequest.DispenseRequestComponent o_ = Order?.DispenseRequest;
                    Quantity p_ = o_?.Quantity;
                    CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, p_);
                    string r_ = q_?.unit;
                    bool? s_ = context.Operators.Equal(r_, "mL");
                    bool? t_ = context.Operators.And(n_, s_);
                    bool? u_ = context.Operators.Or(m_, t_);
                    bool? v_ = context.Operators.And(i_, u_);
                    return v_ ?? false;
                }

                if (g_())
                {
                    MedicationRequest.DispenseRequestComponent w_ = Order?.DispenseRequest;
                    Quantity x_ = w_?.Quantity;
                    CqlQuantity y_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, x_);
                    CqlConcept z_ = CQMCommon_4_1_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity aa_ = this.medicationStrengthPerUnit(context, z_);
                    CqlQuantity ab_ = context.Operators.Multiply(y_, aa_);
                    decimal? ac_ = this.medicationRequestPeriodInDays(context, Order);
                    CqlQuantity ad_ = context.Operators.Divide(ab_, new CqlQuantity(ac_, "d"));
                    return ad_;
                }
                else
                {
                    return default;
                }
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
            }
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
            IEnumerable<Medication> u_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? v_(Medication M) {
                object y_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object z_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> aa_ = context.Operators.Split((string)z_, "/");
                string ab_ = context.Operators.Last<string>(aa_);
                bool? ac_ = context.Operators.Equal(y_, ab_);
                CodeableConcept ad_ = M?.Code;
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                CqlValueSet af_ = this.Digoxin_Medications(context);
                bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                bool? ah_ = context.Operators.And(ac_, ag_);
                return ah_;
            }

            IEnumerable<Medication> w_ = context.Operators.Where<Medication>(u_, v_);
            bool? x_ = context.Operators.Exists<Medication>(w_);
            return x_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest DigoxinOrdered) {
            CqlQuantity ai_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity aj_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? ak_ = context.Operators.Greater(ai_, aj_);
            return ak_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = this.moreThanOneOrder(context, h_);
        bool? j_ = context.Operators.Exists<MedicationRequest>(i_);
        CqlValueSet k_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? m_(MedicationRequest MR) {
            IEnumerable<Medication> al_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? am_(Medication M) {
                object ap_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object aq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ar_ = context.Operators.Split((string)aq_, "/");
                string as_ = context.Operators.Last<string>(ar_);
                bool? at_ = context.Operators.Equal(ap_, as_);
                CodeableConcept au_ = M?.Code;
                CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, au_);
                CqlValueSet aw_ = this.Doxepin_Medications(context);
                bool? ax_ = context.Operators.ConceptInValueSet(av_, aw_);
                bool? ay_ = context.Operators.And(at_, ax_);
                return ay_;
            }

            IEnumerable<Medication> an_ = context.Operators.Where<Medication>(al_, am_);
            bool? ao_ = context.Operators.Exists<Medication>(an_);
            return ao_;
        }

        IEnumerable<MedicationRequest> n_ = context.Operators.Where<MedicationRequest>(c_, m_);
        IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(l_, n_);

        bool? p_(MedicationRequest DoxepinOrdered) {
            CqlQuantity az_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity ba_ = context.Operators.Quantity(6m, "mg/d");
            bool? bb_ = context.Operators.Greater(az_, ba_);
            return bb_;
        }

        IEnumerable<MedicationRequest> q_ = context.Operators.Where<MedicationRequest>(o_, p_);
        IEnumerable<MedicationRequest> r_ = this.moreThanOneOrder(context, q_);
        bool? s_ = context.Operators.Exists<MedicationRequest>(r_);
        bool? t_ = context.Operators.Or(j_, s_);
        return t_;
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
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Bipolar Disorder Diagnosis")]
    public IEnumerable<Condition> Bipolar_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bipolar_Disorder_Diagnosis, Bipolar_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_Bipolar_Disorder_Diagnosis = 3459923094508400090L;

    private IEnumerable<Condition> Bipolar_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
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
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("REM Sleep Behavior Disorder Diagnosis")]
    public IEnumerable<Condition> REM_Sleep_Behavior_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_REM_Sleep_Behavior_Disorder_Diagnosis, REM_Sleep_Behavior_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_REM_Sleep_Behavior_Disorder_Diagnosis = 1960016341670198298L;

    private IEnumerable<Condition> REM_Sleep_Behavior_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.REM_Sleep_Behavior_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Benzodiazepine Withdrawal Diagnosis")]
    public IEnumerable<Condition> Benzodiazepine_Withdrawal_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Benzodiazepine_Withdrawal_Diagnosis, Benzodiazepine_Withdrawal_Diagnosis_Compute);

    private const long _cacheIndex_Benzodiazepine_Withdrawal_Diagnosis = 8657316729577408796L;

    private IEnumerable<Condition> Benzodiazepine_Withdrawal_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Benzodiazepine_Withdrawal(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Alcohol Withdrawal Diagnosis")]
    public IEnumerable<Condition> Alcohol_Withdrawal_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Alcohol_Withdrawal_Diagnosis, Alcohol_Withdrawal_Diagnosis_Compute);

    private const long _cacheIndex_Alcohol_Withdrawal_Diagnosis = -4814865430801165110L;

    private IEnumerable<Condition> Alcohol_Withdrawal_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Alcohol_Withdrawal(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Generalized Anxiety Disorder Diagnosis")]
    public IEnumerable<Condition> Generalized_Anxiety_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Generalized_Anxiety_Disorder_Diagnosis, Generalized_Anxiety_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_Generalized_Anxiety_Disorder_Diagnosis = -2199162515832252667L;

    private IEnumerable<Condition> Generalized_Anxiety_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Generalized_Anxiety_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
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
        bool? c_ = context.Operators.Not(a_);
        bool? d_ = context.Operators.And(b_, c_);
        bool? e_ = context.Operators.Or(a_, d_);
        return e_;
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
