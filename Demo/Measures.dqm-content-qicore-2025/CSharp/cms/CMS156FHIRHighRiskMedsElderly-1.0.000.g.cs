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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
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
                CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return as_;
            }


            bool? ap_(CqlConcept T) {
                CqlCode at_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
                bool? av_ = context.Operators.Equivalent(T, au_);
                return av_;
            }

            IEnumerable<CqlConcept> aq_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)an_, ao_, ap_);
            bool? ar_ = context.Operators.Exists<CqlConcept>(aq_);
            return ar_;
        }

        IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(ae_, ah_);
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ac_, ai_);
        IEnumerable<Encounter> ak_ = Status_1_15_000.Instance.isEncounterPerformed(context, aj_);

        bool? al_(Encounter ValidEncounters) {
            CqlInterval<CqlDateTime> aw_ = this.Measurement_Period(context);
            Period ax_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
            bool? az_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aw_, ay_, (string)default);
            return az_;
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
            IEnumerable<MedicationRequest> f_ = Status_1_15_000.Instance.isMedicationOrder(context, Medication);

            bool? g_(MedicationRequest OrderMedication2) {
                FhirDateTime i_ = OrderMedication1?.AuthoredOnElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, (string)default);
                MedicationRequest.DispenseRequestComponent m_ = OrderMedication1?.DispenseRequest;
                UnsignedInt n_ = m_?.NumberOfRepeatsAllowedElement;
                int? o_ = n_?.Value;
                bool? p_ = context.Operators.GreaterOrEqual(o_, 1);
                bool? q_ = context.Operators.And(l_, p_);
                CqlDate r_ = context.Operators.DateFrom(j_);
                FhirDateTime s_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                CqlDate u_ = context.Operators.DateFrom(t_);
                bool? v_ = context.Operators.Equivalent(r_, u_);
                bool? w_ = context.Operators.Not(v_);
                bool? x_ = context.Operators.And(w_, l_);
                bool? y_ = context.Operators.In<CqlDateTime>(t_, k_, (string)default);
                bool? z_ = context.Operators.And(x_, y_);
                bool? aa_ = context.Operators.Or(q_, z_);
                bool? ab_ = context.Operators.And(v_, l_);
                CqlInterval<CqlDate> ac_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate ad_ = context.Operators.Start(ac_);
                CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                CqlInterval<CqlDate> ag_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate ah_ = context.Operators.Start(ag_);
                CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
                CqlDate aj_ = context.Operators.DateFrom(ai_);
                bool? ak_ = context.Operators.Equivalent(af_, aj_);
                bool? al_ = context.Operators.Not(ak_);
                bool? am_ = context.Operators.And(ab_, al_);
                bool? an_ = context.Operators.In<CqlDateTime>(ae_, k_, (string)default);
                bool? ao_ = context.Operators.And(am_, an_);
                bool? ap_ = context.Operators.In<CqlDateTime>(ai_, k_, (string)default);
                bool? aq_ = context.Operators.And(ao_, ap_);
                bool? ar_ = context.Operators.Or(aa_, aq_);
                return ar_;
            }

            bool? h_ = context.Operators.WhereAny<MedicationRequest>(f_, g_);
            return h_;
        }

        MedicationRequest c_(MedicationRequest OrderMedication1) => OrderMedication1;
        IEnumerable<MedicationRequest> d_ = context.Operators.WhereSelect<MedicationRequest, MedicationRequest>(a_, b_, c_);
        IEnumerable<MedicationRequest> e_ = context.Operators.Distinct<MedicationRequest>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Same_High_Risk_Medications_Ordered_on_Different_Days, Same_High_Risk_Medications_Ordered_on_Different_Days_Compute);

    private const long _cacheIndex_Same_High_Risk_Medications_Ordered_on_Different_Days = 6848809231216479323L;

    private IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> dx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dy_(Medication M) {
                Id ea_ = M?.IdElement;
                string eb_ = ea_?.Value;
                FhirString ec_;
                DataType em_ = MR?.Medication;
                bool en_ = em_ is ResourceReference;
                if (en_)
                {
                    FhirString eo_ = (em_ as ResourceReference)?.ReferenceElement;
                    ec_ = eo_;
                }
                else
                {
                    ec_ = default;
                }
                string ed_ = ec_?.Value;
                IEnumerable<string> ee_ = context.Operators.Split(ed_, "/");
                string ef_ = context.Operators.Last<string>(ee_);
                bool? eg_ = context.Operators.Equal(eb_, ef_);
                CodeableConcept eh_ = M?.Code;
                CqlConcept ei_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eh_);
                CqlValueSet ej_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
                bool? ek_ = context.Operators.ConceptInValueSet(ei_, ej_);
                bool? el_ = context.Operators.And(eg_, ek_);
                return el_;
            }

            bool? dz_ = context.Operators.WhereAny<Medication>(dx_, dy_);
            return dz_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);

        bool? h_(MedicationRequest MR) {
            IEnumerable<Medication> ep_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? eq_(Medication M) {
                Id es_ = M?.IdElement;
                string et_ = es_?.Value;
                FhirString eu_;
                DataType fe_ = MR?.Medication;
                bool ff_ = fe_ is ResourceReference;
                if (ff_)
                {
                    FhirString fg_ = (fe_ as ResourceReference)?.ReferenceElement;
                    eu_ = fg_;
                }
                else
                {
                    eu_ = default;
                }
                string ev_ = eu_?.Value;
                IEnumerable<string> ew_ = context.Operators.Split(ev_, "/");
                string ex_ = context.Operators.Last<string>(ew_);
                bool? ey_ = context.Operators.Equal(et_, ex_);
                CodeableConcept ez_ = M?.Code;
                CqlConcept fa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ez_);
                CqlValueSet fb_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
                bool? fc_ = context.Operators.ConceptInValueSet(fa_, fb_);
                bool? fd_ = context.Operators.And(ey_, fc_);
                return fd_;
            }

            bool? er_ = context.Operators.WhereAny<Medication>(ep_, eq_);
            return er_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(a_, h_);
        CqlValueSet j_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(i_, k_);
        IEnumerable<MedicationRequest> m_ = this.moreThanOneOrder(context, l_);
        IEnumerable<MedicationRequest> n_ = context.Operators.Union<MedicationRequest>(g_, m_);

        bool? o_(MedicationRequest MR) {
            IEnumerable<Medication> fh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fi_(Medication M) {
                Id fk_ = M?.IdElement;
                string fl_ = fk_?.Value;
                FhirString fm_;
                DataType fw_ = MR?.Medication;
                bool fx_ = fw_ is ResourceReference;
                if (fx_)
                {
                    FhirString fy_ = (fw_ as ResourceReference)?.ReferenceElement;
                    fm_ = fy_;
                }
                else
                {
                    fm_ = default;
                }
                string fn_ = fm_?.Value;
                IEnumerable<string> fo_ = context.Operators.Split(fn_, "/");
                string fp_ = context.Operators.Last<string>(fo_);
                bool? fq_ = context.Operators.Equal(fl_, fp_);
                CodeableConcept fr_ = M?.Code;
                CqlConcept fs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fr_);
                CqlValueSet ft_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
                bool? fu_ = context.Operators.ConceptInValueSet(fs_, ft_);
                bool? fv_ = context.Operators.And(fq_, fu_);
                return fv_;
            }

            bool? fj_ = context.Operators.WhereAny<Medication>(fh_, fi_);
            return fj_;
        }

        IEnumerable<MedicationRequest> p_ = context.Operators.Where<MedicationRequest>(a_, o_);
        CqlValueSet q_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> r_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(p_, r_);
        IEnumerable<MedicationRequest> t_ = this.moreThanOneOrder(context, s_);

        bool? u_(MedicationRequest MR) {
            IEnumerable<Medication> fz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ga_(Medication M) {
                Id gc_ = M?.IdElement;
                string gd_ = gc_?.Value;
                FhirString ge_;
                DataType go_ = MR?.Medication;
                bool gp_ = go_ is ResourceReference;
                if (gp_)
                {
                    FhirString gq_ = (go_ as ResourceReference)?.ReferenceElement;
                    ge_ = gq_;
                }
                else
                {
                    ge_ = default;
                }
                string gf_ = ge_?.Value;
                IEnumerable<string> gg_ = context.Operators.Split(gf_, "/");
                string gh_ = context.Operators.Last<string>(gg_);
                bool? gi_ = context.Operators.Equal(gd_, gh_);
                CodeableConcept gj_ = M?.Code;
                CqlConcept gk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gj_);
                CqlValueSet gl_ = this.Dipyridamole_Medications(context);
                bool? gm_ = context.Operators.ConceptInValueSet(gk_, gl_);
                bool? gn_ = context.Operators.And(gi_, gm_);
                return gn_;
            }

            bool? gb_ = context.Operators.WhereAny<Medication>(fz_, ga_);
            return gb_;
        }

        IEnumerable<MedicationRequest> v_ = context.Operators.Where<MedicationRequest>(a_, u_);
        CqlValueSet w_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Union<MedicationRequest>(v_, x_);
        IEnumerable<MedicationRequest> z_ = this.moreThanOneOrder(context, y_);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(t_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(n_, aa_);

        bool? ac_(MedicationRequest MR) {
            IEnumerable<Medication> gr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gs_(Medication M) {
                Id gu_ = M?.IdElement;
                string gv_ = gu_?.Value;
                FhirString gw_;
                DataType hg_ = MR?.Medication;
                bool hh_ = hg_ is ResourceReference;
                if (hh_)
                {
                    FhirString hi_ = (hg_ as ResourceReference)?.ReferenceElement;
                    gw_ = hi_;
                }
                else
                {
                    gw_ = default;
                }
                string gx_ = gw_?.Value;
                IEnumerable<string> gy_ = context.Operators.Split(gx_, "/");
                string gz_ = context.Operators.Last<string>(gy_);
                bool? ha_ = context.Operators.Equal(gv_, gz_);
                CodeableConcept hb_ = M?.Code;
                CqlConcept hc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hb_);
                CqlValueSet hd_ = this.Guanfacine_Medications(context);
                bool? he_ = context.Operators.ConceptInValueSet(hc_, hd_);
                bool? hf_ = context.Operators.And(ha_, he_);
                return hf_;
            }

            bool? gt_ = context.Operators.WhereAny<Medication>(gr_, gs_);
            return gt_;
        }

        IEnumerable<MedicationRequest> ad_ = context.Operators.Where<MedicationRequest>(a_, ac_);
        CqlValueSet ae_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = this.moreThanOneOrder(context, ag_);

        bool? ai_(MedicationRequest MR) {
            IEnumerable<Medication> hj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hk_(Medication M) {
                Id hm_ = M?.IdElement;
                string hn_ = hm_?.Value;
                FhirString ho_;
                DataType hy_ = MR?.Medication;
                bool hz_ = hy_ is ResourceReference;
                if (hz_)
                {
                    FhirString ia_ = (hy_ as ResourceReference)?.ReferenceElement;
                    ho_ = ia_;
                }
                else
                {
                    ho_ = default;
                }
                string hp_ = ho_?.Value;
                IEnumerable<string> hq_ = context.Operators.Split(hp_, "/");
                string hr_ = context.Operators.Last<string>(hq_);
                bool? hs_ = context.Operators.Equal(hn_, hr_);
                CodeableConcept ht_ = M?.Code;
                CqlConcept hu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ht_);
                CqlValueSet hv_ = this.Nifedipine_Medications(context);
                bool? hw_ = context.Operators.ConceptInValueSet(hu_, hv_);
                bool? hx_ = context.Operators.And(hs_, hw_);
                return hx_;
            }

            bool? hl_ = context.Operators.WhereAny<Medication>(hj_, hk_);
            return hl_;
        }

        IEnumerable<MedicationRequest> aj_ = context.Operators.Where<MedicationRequest>(a_, ai_);
        CqlValueSet ak_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest> al_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> am_ = context.Operators.Union<MedicationRequest>(aj_, al_);
        IEnumerable<MedicationRequest> an_ = this.moreThanOneOrder(context, am_);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Union<MedicationRequest>(ah_, an_);
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(ab_, ao_);

        bool? aq_(MedicationRequest MR) {
            IEnumerable<Medication> ib_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ic_(Medication M) {
                Id ie_ = M?.IdElement;
                string if_ = ie_?.Value;
                FhirString ig_;
                DataType iq_ = MR?.Medication;
                bool ir_ = iq_ is ResourceReference;
                if (ir_)
                {
                    FhirString is_ = (iq_ as ResourceReference)?.ReferenceElement;
                    ig_ = is_;
                }
                else
                {
                    ig_ = default;
                }
                string ih_ = ig_?.Value;
                IEnumerable<string> ii_ = context.Operators.Split(ih_, "/");
                string ij_ = context.Operators.Last<string>(ii_);
                bool? ik_ = context.Operators.Equal(if_, ij_);
                CodeableConcept il_ = M?.Code;
                CqlConcept im_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, il_);
                CqlValueSet in_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
                bool? io_ = context.Operators.ConceptInValueSet(im_, in_);
                bool? ip_ = context.Operators.And(ik_, io_);
                return ip_;
            }

            bool? id_ = context.Operators.WhereAny<Medication>(ib_, ic_);
            return id_;
        }

        IEnumerable<MedicationRequest> ar_ = context.Operators.Where<MedicationRequest>(a_, aq_);
        CqlValueSet as_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(ar_, at_);
        IEnumerable<MedicationRequest> av_ = this.moreThanOneOrder(context, au_);

        bool? aw_(MedicationRequest MR) {
            IEnumerable<Medication> it_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? iu_(Medication M) {
                Id iw_ = M?.IdElement;
                string ix_ = iw_?.Value;
                FhirString iy_;
                DataType ji_ = MR?.Medication;
                bool jj_ = ji_ is ResourceReference;
                if (jj_)
                {
                    FhirString jk_ = (ji_ as ResourceReference)?.ReferenceElement;
                    iy_ = jk_;
                }
                else
                {
                    iy_ = default;
                }
                string iz_ = iy_?.Value;
                IEnumerable<string> ja_ = context.Operators.Split(iz_, "/");
                string jb_ = context.Operators.Last<string>(ja_);
                bool? jc_ = context.Operators.Equal(ix_, jb_);
                CodeableConcept jd_ = M?.Code;
                CqlConcept je_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jd_);
                CqlValueSet jf_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
                bool? jg_ = context.Operators.ConceptInValueSet(je_, jf_);
                bool? jh_ = context.Operators.And(jc_, jg_);
                return jh_;
            }

            bool? iv_ = context.Operators.WhereAny<Medication>(it_, iu_);
            return iv_;
        }

        IEnumerable<MedicationRequest> ax_ = context.Operators.Where<MedicationRequest>(a_, aw_);
        CqlValueSet ay_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest> az_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ba_ = context.Operators.Union<MedicationRequest>(ax_, az_);
        IEnumerable<MedicationRequest> bb_ = this.moreThanOneOrder(context, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(av_, bb_);
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(ap_, bc_);

        bool? be_(MedicationRequest MR) {
            IEnumerable<Medication> jl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jm_(Medication M) {
                Id jo_ = M?.IdElement;
                string jp_ = jo_?.Value;
                FhirString jq_;
                DataType kb_ = MR?.Medication;
                bool kc_ = kb_ is ResourceReference;
                if (kc_)
                {
                    FhirString kd_ = (kb_ as ResourceReference)?.ReferenceElement;
                    jq_ = kd_;
                }
                else
                {
                    jq_ = default;
                }
                string jr_ = jq_?.Value;
                IEnumerable<string> js_ = context.Operators.Split(jr_, "/");
                string jt_ = context.Operators.Last<string>(js_);
                bool? ju_ = context.Operators.Equal(jp_, jt_);
                CodeableConcept jv_ = M?.Code;
                CqlConcept jw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jv_);
                CqlCode jx_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
                CqlConcept jy_ = context.Operators.ConvertCodeToConcept(jx_);
                bool? jz_ = context.Operators.Equivalent(jw_, jy_);
                bool? ka_ = context.Operators.And(ju_, jz_);
                return ka_;
            }

            bool? jn_ = context.Operators.WhereAny<Medication>(jl_, jm_);
            return jn_;
        }

        IEnumerable<MedicationRequest> bf_ = context.Operators.Where<MedicationRequest>(a_, be_);
        CqlCode bg_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> bh_ = context.Operators.ToList<CqlCode>(bg_);
        IEnumerable<MedicationRequest> bi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, bh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bf_, bi_);
        IEnumerable<MedicationRequest> bk_ = this.moreThanOneOrder(context, bj_);

        bool? bl_(MedicationRequest MR) {
            IEnumerable<Medication> ke_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kf_(Medication M) {
                Id kh_ = M?.IdElement;
                string ki_ = kh_?.Value;
                FhirString kj_;
                DataType kt_ = MR?.Medication;
                bool ku_ = kt_ is ResourceReference;
                if (ku_)
                {
                    FhirString kv_ = (kt_ as ResourceReference)?.ReferenceElement;
                    kj_ = kv_;
                }
                else
                {
                    kj_ = default;
                }
                string kk_ = kj_?.Value;
                IEnumerable<string> kl_ = context.Operators.Split(kk_, "/");
                string km_ = context.Operators.Last<string>(kl_);
                bool? kn_ = context.Operators.Equal(ki_, km_);
                CodeableConcept ko_ = M?.Code;
                CqlConcept kp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ko_);
                CqlValueSet kq_ = this.Meprobamate_Medications(context);
                bool? kr_ = context.Operators.ConceptInValueSet(kp_, kq_);
                bool? ks_ = context.Operators.And(kn_, kr_);
                return ks_;
            }

            bool? kg_ = context.Operators.WhereAny<Medication>(ke_, kf_);
            return kg_;
        }

        IEnumerable<MedicationRequest> bm_ = context.Operators.Where<MedicationRequest>(a_, bl_);
        CqlValueSet bn_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest> bo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bm_, bo_);
        IEnumerable<MedicationRequest> bq_ = this.moreThanOneOrder(context, bp_);
        IEnumerable<MedicationRequest> br_ = context.Operators.Union<MedicationRequest>(bk_, bq_);
        IEnumerable<MedicationRequest> bs_ = context.Operators.Union<MedicationRequest>(bd_, br_);

        bool? bt_(MedicationRequest MR) {
            IEnumerable<Medication> kw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kx_(Medication M) {
                Id kz_ = M?.IdElement;
                string la_ = kz_?.Value;
                FhirString lb_;
                DataType ll_ = MR?.Medication;
                bool lm_ = ll_ is ResourceReference;
                if (lm_)
                {
                    FhirString ln_ = (ll_ as ResourceReference)?.ReferenceElement;
                    lb_ = ln_;
                }
                else
                {
                    lb_ = default;
                }
                string lc_ = lb_?.Value;
                IEnumerable<string> ld_ = context.Operators.Split(lc_, "/");
                string le_ = context.Operators.Last<string>(ld_);
                bool? lf_ = context.Operators.Equal(la_, le_);
                CodeableConcept lg_ = M?.Code;
                CqlConcept lh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lg_);
                CqlValueSet li_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
                bool? lj_ = context.Operators.ConceptInValueSet(lh_, li_);
                bool? lk_ = context.Operators.And(lf_, lj_);
                return lk_;
            }

            bool? ky_ = context.Operators.WhereAny<Medication>(kw_, kx_);
            return ky_;
        }

        IEnumerable<MedicationRequest> bu_ = context.Operators.Where<MedicationRequest>(a_, bt_);
        CqlValueSet bv_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest> bw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bx_ = context.Operators.Union<MedicationRequest>(bu_, bw_);
        IEnumerable<MedicationRequest> by_ = this.moreThanOneOrder(context, bx_);

        bool? bz_(MedicationRequest MR) {
            IEnumerable<Medication> lo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lp_(Medication M) {
                Id lr_ = M?.IdElement;
                string ls_ = lr_?.Value;
                FhirString lt_;
                DataType md_ = MR?.Medication;
                bool me_ = md_ is ResourceReference;
                if (me_)
                {
                    FhirString mf_ = (md_ as ResourceReference)?.ReferenceElement;
                    lt_ = mf_;
                }
                else
                {
                    lt_ = default;
                }
                string lu_ = lt_?.Value;
                IEnumerable<string> lv_ = context.Operators.Split(lu_, "/");
                string lw_ = context.Operators.Last<string>(lv_);
                bool? lx_ = context.Operators.Equal(ls_, lw_);
                CodeableConcept ly_ = M?.Code;
                CqlConcept lz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ly_);
                CqlValueSet ma_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
                bool? mb_ = context.Operators.ConceptInValueSet(lz_, ma_);
                bool? mc_ = context.Operators.And(lx_, mb_);
                return mc_;
            }

            bool? lq_ = context.Operators.WhereAny<Medication>(lo_, lp_);
            return lq_;
        }

        IEnumerable<MedicationRequest> ca_ = context.Operators.Where<MedicationRequest>(a_, bz_);
        CqlValueSet cb_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest> cc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cd_ = context.Operators.Union<MedicationRequest>(ca_, cc_);
        IEnumerable<MedicationRequest> ce_ = this.moreThanOneOrder(context, cd_);
        IEnumerable<MedicationRequest> cf_ = context.Operators.Union<MedicationRequest>(by_, ce_);
        IEnumerable<MedicationRequest> cg_ = context.Operators.Union<MedicationRequest>(bs_, cf_);

        bool? ch_(MedicationRequest MR) {
            IEnumerable<Medication> mg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? mh_(Medication M) {
                Id mj_ = M?.IdElement;
                string mk_ = mj_?.Value;
                FhirString ml_;
                DataType mv_ = MR?.Medication;
                bool mw_ = mv_ is ResourceReference;
                if (mw_)
                {
                    FhirString mx_ = (mv_ as ResourceReference)?.ReferenceElement;
                    ml_ = mx_;
                }
                else
                {
                    ml_ = default;
                }
                string mm_ = ml_?.Value;
                IEnumerable<string> mn_ = context.Operators.Split(mm_, "/");
                string mo_ = context.Operators.Last<string>(mn_);
                bool? mp_ = context.Operators.Equal(mk_, mo_);
                CodeableConcept mq_ = M?.Code;
                CqlConcept mr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mq_);
                CqlValueSet ms_ = this.Desiccated_Thyroid_Medications(context);
                bool? mt_ = context.Operators.ConceptInValueSet(mr_, ms_);
                bool? mu_ = context.Operators.And(mp_, mt_);
                return mu_;
            }

            bool? mi_ = context.Operators.WhereAny<Medication>(mg_, mh_);
            return mi_;
        }

        IEnumerable<MedicationRequest> ci_ = context.Operators.Where<MedicationRequest>(a_, ch_);
        CqlValueSet cj_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest> ck_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cl_ = context.Operators.Union<MedicationRequest>(ci_, ck_);
        IEnumerable<MedicationRequest> cm_ = this.moreThanOneOrder(context, cl_);

        bool? cn_(MedicationRequest MR) {
            IEnumerable<Medication> my_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? mz_(Medication M) {
                Id nb_ = M?.IdElement;
                string nc_ = nb_?.Value;
                FhirString nd_;
                DataType nn_ = MR?.Medication;
                bool no_ = nn_ is ResourceReference;
                if (no_)
                {
                    FhirString np_ = (nn_ as ResourceReference)?.ReferenceElement;
                    nd_ = np_;
                }
                else
                {
                    nd_ = default;
                }
                string ne_ = nd_?.Value;
                IEnumerable<string> nf_ = context.Operators.Split(ne_, "/");
                string ng_ = context.Operators.Last<string>(nf_);
                bool? nh_ = context.Operators.Equal(nc_, ng_);
                CodeableConcept ni_ = M?.Code;
                CqlConcept nj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ni_);
                CqlValueSet nk_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
                bool? nl_ = context.Operators.ConceptInValueSet(nj_, nk_);
                bool? nm_ = context.Operators.And(nh_, nl_);
                return nm_;
            }

            bool? na_ = context.Operators.WhereAny<Medication>(my_, mz_);
            return na_;
        }

        IEnumerable<MedicationRequest> co_ = context.Operators.Where<MedicationRequest>(a_, cn_);
        CqlValueSet cp_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> cq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cr_ = context.Operators.Union<MedicationRequest>(co_, cq_);
        IEnumerable<MedicationRequest> cs_ = this.moreThanOneOrder(context, cr_);
        IEnumerable<MedicationRequest> ct_ = context.Operators.Union<MedicationRequest>(cm_, cs_);
        IEnumerable<MedicationRequest> cu_ = context.Operators.Union<MedicationRequest>(cg_, ct_);

        bool? cv_(MedicationRequest MR) {
            IEnumerable<Medication> nq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? nr_(Medication M) {
                Id nt_ = M?.IdElement;
                string nu_ = nt_?.Value;
                FhirString nv_;
                DataType of_ = MR?.Medication;
                bool og_ = of_ is ResourceReference;
                if (og_)
                {
                    FhirString oh_ = (of_ as ResourceReference)?.ReferenceElement;
                    nv_ = oh_;
                }
                else
                {
                    nv_ = default;
                }
                string nw_ = nv_?.Value;
                IEnumerable<string> nx_ = context.Operators.Split(nw_, "/");
                string ny_ = context.Operators.Last<string>(nx_);
                bool? nz_ = context.Operators.Equal(nu_, ny_);
                CodeableConcept oa_ = M?.Code;
                CqlConcept ob_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, oa_);
                CqlValueSet oc_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
                bool? od_ = context.Operators.ConceptInValueSet(ob_, oc_);
                bool? oe_ = context.Operators.And(nz_, od_);
                return oe_;
            }

            bool? ns_ = context.Operators.WhereAny<Medication>(nq_, nr_);
            return ns_;
        }

        IEnumerable<MedicationRequest> cw_ = context.Operators.Where<MedicationRequest>(a_, cv_);
        CqlValueSet cx_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> cy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> cz_ = context.Operators.Union<MedicationRequest>(cw_, cy_);
        IEnumerable<MedicationRequest> da_ = this.moreThanOneOrder(context, cz_);

        bool? db_(MedicationRequest MR) {
            IEnumerable<Medication> oi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? oj_(Medication M) {
                Id ol_ = M?.IdElement;
                string om_ = ol_?.Value;
                FhirString on_;
                DataType ox_ = MR?.Medication;
                bool oy_ = ox_ is ResourceReference;
                if (oy_)
                {
                    FhirString oz_ = (ox_ as ResourceReference)?.ReferenceElement;
                    on_ = oz_;
                }
                else
                {
                    on_ = default;
                }
                string oo_ = on_?.Value;
                IEnumerable<string> op_ = context.Operators.Split(oo_, "/");
                string oq_ = context.Operators.Last<string>(op_);
                bool? or_ = context.Operators.Equal(om_, oq_);
                CodeableConcept os_ = M?.Code;
                CqlConcept ot_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, os_);
                CqlValueSet ou_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
                bool? ov_ = context.Operators.ConceptInValueSet(ot_, ou_);
                bool? ow_ = context.Operators.And(or_, ov_);
                return ow_;
            }

            bool? ok_ = context.Operators.WhereAny<Medication>(oi_, oj_);
            return ok_;
        }

        IEnumerable<MedicationRequest> dc_ = context.Operators.Where<MedicationRequest>(a_, db_);
        CqlValueSet dd_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest> de_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> df_ = context.Operators.Union<MedicationRequest>(dc_, de_);
        IEnumerable<MedicationRequest> dg_ = this.moreThanOneOrder(context, df_);
        IEnumerable<MedicationRequest> dh_ = context.Operators.Union<MedicationRequest>(da_, dg_);
        IEnumerable<MedicationRequest> di_ = context.Operators.Union<MedicationRequest>(cu_, dh_);

        bool? dj_(MedicationRequest MR) {
            IEnumerable<Medication> pa_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? pb_(Medication M) {
                Id pd_ = M?.IdElement;
                string pe_ = pd_?.Value;
                FhirString pf_;
                DataType pp_ = MR?.Medication;
                bool pq_ = pp_ is ResourceReference;
                if (pq_)
                {
                    FhirString pr_ = (pp_ as ResourceReference)?.ReferenceElement;
                    pf_ = pr_;
                }
                else
                {
                    pf_ = default;
                }
                string pg_ = pf_?.Value;
                IEnumerable<string> ph_ = context.Operators.Split(pg_, "/");
                string pi_ = context.Operators.Last<string>(ph_);
                bool? pj_ = context.Operators.Equal(pe_, pi_);
                CodeableConcept pk_ = M?.Code;
                CqlConcept pl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pk_);
                CqlValueSet pm_ = this.Megestrol_Medications(context);
                bool? pn_ = context.Operators.ConceptInValueSet(pl_, pm_);
                bool? po_ = context.Operators.And(pj_, pn_);
                return po_;
            }

            bool? pc_ = context.Operators.WhereAny<Medication>(pa_, pb_);
            return pc_;
        }

        IEnumerable<MedicationRequest> dk_ = context.Operators.Where<MedicationRequest>(a_, dj_);
        CqlValueSet dl_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest> dm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dn_ = context.Operators.Union<MedicationRequest>(dk_, dm_);
        IEnumerable<MedicationRequest> do_ = this.moreThanOneOrder(context, dn_);

        bool? dp_(MedicationRequest MR) {
            IEnumerable<Medication> ps_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? pt_(Medication M) {
                Id pv_ = M?.IdElement;
                string pw_ = pv_?.Value;
                FhirString px_;
                DataType qh_ = MR?.Medication;
                bool qi_ = qh_ is ResourceReference;
                if (qi_)
                {
                    FhirString qj_ = (qh_ as ResourceReference)?.ReferenceElement;
                    px_ = qj_;
                }
                else
                {
                    px_ = default;
                }
                string py_ = px_?.Value;
                IEnumerable<string> pz_ = context.Operators.Split(py_, "/");
                string qa_ = context.Operators.Last<string>(pz_);
                bool? qb_ = context.Operators.Equal(pw_, qa_);
                CodeableConcept qc_ = M?.Code;
                CqlConcept qd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qc_);
                CqlValueSet qe_ = this.Meperidine_Medications(context);
                bool? qf_ = context.Operators.ConceptInValueSet(qd_, qe_);
                bool? qg_ = context.Operators.And(qb_, qf_);
                return qg_;
            }

            bool? pu_ = context.Operators.WhereAny<Medication>(ps_, pt_);
            return pu_;
        }

        IEnumerable<MedicationRequest> dq_ = context.Operators.Where<MedicationRequest>(a_, dp_);
        CqlValueSet dr_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest> ds_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
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
            MedicationRequest.DispenseRequestComponent e_ = R?.DispenseRequest;
            Duration f_ = e_?.ExpectedSupplyDuration;
            CqlQuantity g_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, f_);
            CqlQuantity h_ = context.Operators.ConvertQuantity(g_, "d");
            decimal? i_ = h_?.value;
            Quantity j_ = e_?.Quantity;
            CqlQuantity k_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, j_);
            decimal? l_ = k_?.value;
            List<Dosage> m_ = R?.DosageInstruction;
            Dosage n_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)m_);
            List<Dosage.DoseAndRateComponent> o_ = n_?.DoseAndRate;
            Dosage.DoseAndRateComponent p_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)o_);
            DataType q_ = p_?.Dose;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlQuantity s_ = context.Operators.End(r_ as CqlInterval<CqlQuantity>);
            decimal? t_ = (s_ ?? r_ as CqlQuantity)?.value;
            Timing u_ = n_?.Timing;
            Timing.RepeatComponent v_ = u_?.Repeat;
            PositiveInt w_ = v_?.FrequencyMaxElement;
            int? x_ = w_?.Value;
            PositiveInt y_ = v_?.FrequencyElement;
            int? z_ = y_?.Value;
            FhirDecimal aa_ = v_?.PeriodElement;
            decimal? ab_ = aa_?.Value;
            Code<Timing.UnitsOfTime> ac_ = v_?.PeriodUnitElement;
            Timing.UnitsOfTime? ad_ = ac_?.Value;
            string ae_ = context.Operators.Convert<string>(ad_);
            CqlQuantity af_ = CumulativeMedicationDuration_6_0_000.Instance.Quantity(context, ab_, ae_);
            decimal? ag_ = CumulativeMedicationDuration_6_0_000.Instance.ToDaily(context, x_ ?? z_, af_);
            List<Time> ah_ = v_?.TimeOfDayElement;

            string ai_(Time @this) {
                string av_ = @this?.Value;
                return av_;
            }

            IEnumerable<string> aj_ = context.Operators.Select<Time, string>((IEnumerable<Time>)ah_, ai_);

            CqlTime ak_(string @string) {
                CqlTime aw_ = context.Operators.ConvertStringToTime(@string);
                return aw_;
            }

            IEnumerable<CqlTime> al_ = context.Operators.Select<string, CqlTime>(aj_, ak_);
            int? am_ = context.Operators.Count<CqlTime>(al_);
            decimal? an_ = context.Operators.ConvertIntegerToDecimal(am_);
            decimal? ao_ = context.Operators.Multiply(t_, (ag_ ?? an_) ?? 1.0m);
            decimal? ap_ = context.Operators.Divide(l_, ao_);
            UnsignedInt aq_ = e_?.NumberOfRepeatsAllowedElement;
            int? ar_ = aq_?.Value;
            int? as_ = context.Operators.Add(1, ar_ ?? 0);
            decimal? at_ = context.Operators.ConvertIntegerToDecimal(as_);
            decimal? au_ = context.Operators.Multiply(i_ ?? ap_, at_);
            return au_;
        }

        IEnumerable<decimal?> c_ = context.Operators.SelectDistinct<MedicationRequest, decimal?>((IEnumerable<MedicationRequest>)a_, b_);
        decimal? d_ = context.Operators.SingletonFrom<decimal?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_High_Risk_Medications_with_Prolonged_Duration, Two_High_Risk_Medications_with_Prolonged_Duration_Compute);

    private const long _cacheIndex_Two_High_Risk_Medications_with_Prolonged_Duration = -8402263243327309117L;

    private bool? Two_High_Risk_Medications_with_Prolonged_Duration_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? n_(Medication M) {
                Id p_ = M?.IdElement;
                string q_ = p_?.Value;
                FhirString r_;
                DataType ab_ = MR?.Medication;
                bool ac_ = ab_ is ResourceReference;
                if (ac_)
                {
                    FhirString ad_ = (ab_ as ResourceReference)?.ReferenceElement;
                    r_ = ad_;
                }
                else
                {
                    r_ = default;
                }
                string s_ = r_?.Value;
                IEnumerable<string> t_ = context.Operators.Split(s_, "/");
                string u_ = context.Operators.Last<string>(t_);
                bool? v_ = context.Operators.Equal(q_, u_);
                CodeableConcept w_ = M?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlValueSet y_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                bool? aa_ = context.Operators.And(v_, z_);
                return aa_;
            }

            bool? o_ = context.Operators.WhereAny<Medication>(m_, n_);
            return o_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);

        decimal? h_(MedicationRequest AntiInfectives) {
            decimal? ae_ = this.medicationRequestPeriodInDays(context, AntiInfectives);
            return ae_;
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
            decimal? e_ = this.medicationRequestPeriodInDays(context, Order);
            bool? f_ = context.Operators.Not((bool?)(e_ is null));
            CqlConcept g_ = CQMCommon_4_1_000.Instance.getMedicationCode(context, Order);
            CqlQuantity h_ = this.medicationStrengthPerUnit(context, g_);
            string i_ = h_?.unit;
            bool? j_ = context.Operators.Equal(i_, "mg");
            bool? k_ = context.Operators.Equal(i_, "mg/mL");
            MedicationRequest.DispenseRequestComponent l_ = Order?.DispenseRequest;
            Quantity m_ = l_?.Quantity;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_);
            string o_ = n_?.unit;
            bool? p_ = context.Operators.Equal(o_, "mL");
            bool? q_ = context.Operators.And(k_, p_);
            bool? r_ = context.Operators.Or(j_, q_);
            bool? s_ = context.Operators.And(f_, r_);
            if (s_ ?? false)
            {
                CqlQuantity t_ = context.Operators.Multiply(n_, h_);
                CqlQuantity u_ = context.Operators.Divide(t_, new CqlQuantity(e_, "d"));
                return u_;
            }
            else
            {
                return default;
            }
        }

        IEnumerable<CqlQuantity> c_ = context.Operators.SelectDistinct<MedicationRequest, CqlQuantity>((IEnumerable<MedicationRequest>)a_, b_);
        CqlQuantity d_ = context.Operators.SingletonFrom<CqlQuantity>(c_);
        return d_;
    }


    [CqlFunctionDefinition("medicationStrengthPerUnit")]
    public CqlQuantity medicationStrengthPerUnit(CqlContext context, CqlConcept Strength)
    {
        CqlCode a_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
        CqlConcept b_ = context.Operators.ConvertCodeToConcept(a_);
        bool? c_ = context.Operators.Equivalent(Strength, b_);
        if (c_ ?? false)
        {
            CqlQuantity d_ = context.Operators.Quantity(0.05m, "mg/mL");
            return d_;
        }
        else
        {
            CqlCode e_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
            CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
            bool? g_ = context.Operators.Equivalent(Strength, f_);
            if (g_ ?? false)
            {
                CqlQuantity h_ = context.Operators.Quantity(0.0625m, "mg");
                return h_;
            }
            else
            {
                CqlCode i_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
                CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
                bool? k_ = context.Operators.Equivalent(Strength, j_);
                if (k_ ?? false)
                {
                    CqlQuantity l_ = context.Operators.Quantity(0.1m, "mg/mL");
                    return l_;
                }
                else
                {
                    CqlCode m_ = this.digoxin_0_125_MG_Oral_Tablet(context);
                    CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
                    bool? o_ = context.Operators.Equivalent(Strength, n_);
                    if (o_ ?? false)
                    {
                        CqlQuantity p_ = context.Operators.Quantity(0.125m, "mg");
                        return p_;
                    }
                    else
                    {
                        CqlCode q_ = this.digoxin_0_25_MG_Oral_Tablet(context);
                        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                        bool? s_ = context.Operators.Equivalent(Strength, r_);
                        if (s_ ?? false)
                        {
                            CqlQuantity t_ = context.Operators.Quantity(0.25m, "mg");
                            return t_;
                        }
                        else
                        {
                            CqlCode u_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
                            CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                            bool? w_ = context.Operators.Equivalent(Strength, v_);
                            if (w_ ?? false)
                            {
                                CqlQuantity x_ = context.Operators.Quantity(0.25m, "mg/mL");
                                return x_;
                            }
                            else
                            {
                                CqlCode y_ = this.doxepin_3_MG_Oral_Tablet(context);
                                CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
                                bool? aa_ = context.Operators.Equivalent(Strength, z_);
                                if (aa_ ?? false)
                                {
                                    CqlQuantity ab_ = context.Operators.Quantity(3m, "mg");
                                    return ab_;
                                }
                                else
                                {
                                    CqlCode ac_ = this.doxepin_6_MG_Oral_Tablet(context);
                                    CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                                    bool? ae_ = context.Operators.Equivalent(Strength, ad_);
                                    if (ae_ ?? false)
                                    {
                                        CqlQuantity af_ = context.Operators.Quantity(6m, "mg");
                                        return af_;
                                    }
                                    else
                                    {
                                        CqlCode ag_ = this.doxepin_10_MG_Oral_Capsule(context);
                                        CqlConcept ah_ = context.Operators.ConvertCodeToConcept(ag_);
                                        bool? ai_ = context.Operators.Equivalent(Strength, ah_);
                                        if (ai_ ?? false)
                                        {
                                            CqlQuantity aj_ = context.Operators.Quantity(10m, "mg");
                                            return aj_;
                                        }
                                        else
                                        {
                                            CqlCode ak_ = this.doxepin_10_MG_ML_Oral_Solution(context);
                                            CqlConcept al_ = context.Operators.ConvertCodeToConcept(ak_);
                                            bool? am_ = context.Operators.Equivalent(Strength, al_);
                                            if (am_ ?? false)
                                            {
                                                CqlQuantity an_ = context.Operators.Quantity(10m, "mg/mL");
                                                return an_;
                                            }
                                            else
                                            {
                                                CqlCode ao_ = this.doxepin_25_MG_Oral_Capsule(context);
                                                CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                                                bool? aq_ = context.Operators.Equivalent(Strength, ap_);
                                                if (aq_ ?? false)
                                                {
                                                    CqlQuantity ar_ = context.Operators.Quantity(25m, "mg");
                                                    return ar_;
                                                }
                                                else
                                                {
                                                    CqlCode as_ = this.doxepin_50_MG_Oral_Capsule(context);
                                                    CqlConcept at_ = context.Operators.ConvertCodeToConcept(as_);
                                                    bool? au_ = context.Operators.Equivalent(Strength, at_);
                                                    if (au_ ?? false)
                                                    {
                                                        CqlQuantity av_ = context.Operators.Quantity(50m, "mg");
                                                        return av_;
                                                    }
                                                    else
                                                    {
                                                        CqlCode aw_ = this.doxepin_75_MG_Oral_Capsule(context);
                                                        CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
                                                        bool? ay_ = context.Operators.Equivalent(Strength, ax_);
                                                        if (ay_ ?? false)
                                                        {
                                                            CqlQuantity az_ = context.Operators.Quantity(75m, "mg");
                                                            return az_;
                                                        }
                                                        else
                                                        {
                                                            CqlCode ba_ = this.doxepin_100_MG_Oral_Capsule(context);
                                                            CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                                                            bool? bc_ = context.Operators.Equivalent(Strength, bb_);
                                                            if (bc_ ?? false)
                                                            {
                                                                CqlQuantity bd_ = context.Operators.Quantity(100m, "mg");
                                                                return bd_;
                                                            }
                                                            else
                                                            {
                                                                CqlCode be_ = this.doxepin_150_MG_Oral_Capsule(context);
                                                                CqlConcept bf_ = context.Operators.ConvertCodeToConcept(be_);
                                                                bool? bg_ = context.Operators.Equivalent(Strength, bf_);
                                                                if (bg_ ?? false)
                                                                {
                                                                    CqlQuantity bh_ = context.Operators.Quantity(150m, "mg");
                                                                    return bh_;
                                                                }
                                                                else
                                                                {
                                                                    return default;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }


    [CqlExpressionDefinition("High Risk Medications with Average Daily Dose Criteria")]
    public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_High_Risk_Medications_with_Average_Daily_Dose_Criteria, High_Risk_Medications_with_Average_Daily_Dose_Criteria_Compute);

    private const long _cacheIndex_High_Risk_Medications_with_Average_Daily_Dose_Criteria = -4939737892995592945L;

    private bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> u_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? v_(Medication M) {
                Id x_ = M?.IdElement;
                string y_ = x_?.Value;
                FhirString z_;
                DataType aj_ = MR?.Medication;
                bool ak_ = aj_ is ResourceReference;
                if (ak_)
                {
                    FhirString al_ = (aj_ as ResourceReference)?.ReferenceElement;
                    z_ = al_;
                }
                else
                {
                    z_ = default;
                }
                string aa_ = z_?.Value;
                IEnumerable<string> ab_ = context.Operators.Split(aa_, "/");
                string ac_ = context.Operators.Last<string>(ab_);
                bool? ad_ = context.Operators.Equal(y_, ac_);
                CodeableConcept ae_ = M?.Code;
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
                CqlValueSet ag_ = this.Digoxin_Medications(context);
                bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                bool? ai_ = context.Operators.And(ad_, ah_);
                return ai_;
            }

            bool? w_ = context.Operators.WhereAny<Medication>(u_, v_);
            return w_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Digoxin_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest DigoxinOrdered) {
            CqlQuantity am_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity an_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? ao_ = context.Operators.Greater(am_, an_);
            return ao_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        IEnumerable<MedicationRequest> i_ = this.moreThanOneOrder(context, h_);
        bool? j_ = context.Operators.Exists<MedicationRequest>(i_);

        bool? k_(MedicationRequest MR) {
            IEnumerable<Medication> ap_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? aq_(Medication M) {
                Id as_ = M?.IdElement;
                string at_ = as_?.Value;
                FhirString au_;
                DataType be_ = MR?.Medication;
                bool bf_ = be_ is ResourceReference;
                if (bf_)
                {
                    FhirString bg_ = (be_ as ResourceReference)?.ReferenceElement;
                    au_ = bg_;
                }
                else
                {
                    au_ = default;
                }
                string av_ = au_?.Value;
                IEnumerable<string> aw_ = context.Operators.Split(av_, "/");
                string ax_ = context.Operators.Last<string>(aw_);
                bool? ay_ = context.Operators.Equal(at_, ax_);
                CodeableConcept az_ = M?.Code;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlValueSet bb_ = this.Doxepin_Medications(context);
                bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
                bool? bd_ = context.Operators.And(ay_, bc_);
                return bd_;
            }

            bool? ar_ = context.Operators.WhereAny<Medication>(ap_, aq_);
            return ar_;
        }

        IEnumerable<MedicationRequest> l_ = context.Operators.Where<MedicationRequest>(a_, k_);
        CqlValueSet m_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest> n_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(l_, n_);

        bool? p_(MedicationRequest DoxepinOrdered) {
            CqlQuantity bh_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity bi_ = context.Operators.Quantity(6m, "mg/d");
            bool? bj_ = context.Operators.Greater(bh_, bi_);
            return bj_;
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
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                Id l_ = M?.IdElement;
                string m_ = l_?.Value;
                FhirString n_;
                DataType x_ = MR?.Medication;
                bool y_ = x_ is ResourceReference;
                if (y_)
                {
                    FhirString z_ = (x_ as ResourceReference)?.ReferenceElement;
                    n_ = z_;
                }
                else
                {
                    n_ = default;
                }
                string o_ = n_?.Value;
                IEnumerable<string> p_ = context.Operators.Split(o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                bool? r_ = context.Operators.Equal(m_, q_);
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context.Operators.And(r_, v_);
                return w_;
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
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
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? o_(Medication M) {
                Id q_ = M?.IdElement;
                string r_ = q_?.Value;
                FhirString s_;
                DataType ac_ = MR?.Medication;
                bool ad_ = ac_ is ResourceReference;
                if (ad_)
                {
                    FhirString ae_ = (ac_ as ResourceReference)?.ReferenceElement;
                    s_ = ae_;
                }
                else
                {
                    s_ = default;
                }
                string t_ = s_?.Value;
                IEnumerable<string> u_ = context.Operators.Split(t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(r_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                return ab_;
            }

            bool? p_ = context.Operators.WhereAny<Medication>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest AntipsychoticMedication) {
            FhirDateTime af_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime ag_ = context.Operators.Convert<CqlDateTime>(af_);
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, (string)default);
            return ai_;
        }


        CqlDateTime i_(MedicationRequest AntipsychoticMedication) {
            FhirDateTime aj_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(aj_);
            return ak_;
        }

        IEnumerable<CqlDateTime> j_ = context.Operators.WhereSelect<MedicationRequest, CqlDateTime>(g_, h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.ListSort<CqlDateTime>(k_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime m_ = context.Operators.First<CqlDateTime>(l_);
        return m_;
    }


    [CqlExpressionDefinition("More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_More_than_One_Benzodiazepine_Order, More_than_One_Benzodiazepine_Order_Compute);

    private const long _cacheIndex_More_than_One_Benzodiazepine_Order = -7787489465336773734L;

    private bool? More_than_One_Benzodiazepine_Order_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                Id l_ = M?.IdElement;
                string m_ = l_?.Value;
                FhirString n_;
                DataType x_ = MR?.Medication;
                bool y_ = x_ is ResourceReference;
                if (y_)
                {
                    FhirString z_ = (x_ as ResourceReference)?.ReferenceElement;
                    n_ = z_;
                }
                else
                {
                    n_ = default;
                }
                string o_ = n_?.Value;
                IEnumerable<string> p_ = context.Operators.Split(o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                bool? r_ = context.Operators.Equal(m_, q_);
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context.Operators.And(r_, v_);
                return w_;
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
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
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? o_(Medication M) {
                Id q_ = M?.IdElement;
                string r_ = q_?.Value;
                FhirString s_;
                DataType ac_ = MR?.Medication;
                bool ad_ = ac_ is ResourceReference;
                if (ad_)
                {
                    FhirString ae_ = (ac_ as ResourceReference)?.ReferenceElement;
                    s_ = ae_;
                }
                else
                {
                    s_ = default;
                }
                string t_ = s_?.Value;
                IEnumerable<string> u_ = context.Operators.Split(t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(r_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                return ab_;
            }

            bool? p_ = context.Operators.WhereAny<Medication>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest BenzodiazepineMedication) {
            FhirDateTime af_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime ag_ = context.Operators.Convert<CqlDateTime>(af_);
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, (string)default);
            return ai_;
        }


        CqlDateTime i_(MedicationRequest BenzodiazepineMedication) {
            FhirDateTime aj_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(aj_);
            return ak_;
        }

        IEnumerable<CqlDateTime> j_ = context.Operators.WhereSelect<MedicationRequest, CqlDateTime>(g_, h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.ListSort<CqlDateTime>(k_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime m_ = context.Operators.First<CqlDateTime>(l_);
        return m_;
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
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
            CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlDateTime ac_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(ab_, ac_, true, true);
            bool? ae_ = context.Operators.Overlaps(x_, ad_, (string)default);
            return ae_;
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        bool? g_ = context.Operators.Not(f_);
        bool? h_ = context.Operators.And(a_, g_);
        bool? i_ = this.More_than_One_Benzodiazepine_Order(context);
        IEnumerable<Condition> j_ = this.Seizure_Disorder_Diagnosis(context);
        IEnumerable<Condition> k_ = this.REM_Sleep_Behavior_Disorder_Diagnosis(context);
        IEnumerable<Condition> l_ = context.Operators.Union<Condition>(j_, k_);
        IEnumerable<Condition> m_ = this.Benzodiazepine_Withdrawal_Diagnosis(context);
        IEnumerable<Condition> n_ = this.Alcohol_Withdrawal_Diagnosis(context);
        IEnumerable<Condition> o_ = context.Operators.Union<Condition>(m_, n_);
        IEnumerable<Condition> p_ = context.Operators.Union<Condition>(l_, o_);
        IEnumerable<Condition> q_ = this.Generalized_Anxiety_Disorder_Diagnosis(context);
        IEnumerable<Condition> r_ = context.Operators.Union<Condition>(p_, q_);

        bool? s_(Condition BenzodiazepineTreatedDiagnoses) {
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            CqlQuantity ai_ = context.Operators.Quantity(1m, "year");
            CqlDateTime aj_ = context.Operators.Subtract(ah_, ai_);
            CqlDateTime ak_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> al_ = context.Operators.Interval(aj_, ak_, true, true);
            bool? am_ = context.Operators.Overlaps(af_, al_, (string)default);
            return am_;
        }

        bool? t_ = context.Operators.WhereAny<Condition>(r_, s_);
        bool? u_ = context.Operators.Not(t_);
        bool? v_ = context.Operators.And(i_, u_);
        bool? w_ = context.Operators.Or(h_, v_);
        return w_;
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
