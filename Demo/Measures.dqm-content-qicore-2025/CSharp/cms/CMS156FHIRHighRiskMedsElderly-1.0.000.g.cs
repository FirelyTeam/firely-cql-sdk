#nullable enable annotations

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3839642862747079336L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS156FHIRHighRiskMedsElderly-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (30)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -1712437477775746068L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter?>? Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = 1461678439183939324L;

    private IEnumerable<Encounter?>? Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? c_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);
        CqlValueSet? f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter?>? g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? h_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter?>? i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter?>(g_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(e_, j_);
        CqlValueSet? l_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter?>? m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? n_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter?>? o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? p_ = context.Operators.Union<Encounter?>(m_, o_);
        IEnumerable<Encounter?>? q_ = context.Operators.Union<Encounter?>(k_, p_);
        CqlValueSet? r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter?>? s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? t_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter?>? u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? v_ = context.Operators.Union<Encounter?>(s_, u_);
        IEnumerable<Encounter?>? w_ = context.Operators.Union<Encounter?>(q_, v_);
        CqlValueSet? x_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter?>? y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? z_ = this.Telephone_Visits(context);
        IEnumerable<Encounter?>? aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? ab_ = context.Operators.Union<Encounter?>(y_, aa_);
        IEnumerable<Encounter?>? ac_ = context.Operators.Union<Encounter?>(w_, ab_);
        CqlValueSet? ad_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter?>? ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? af_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? ag_(Encounter? E) {
            List<CodeableConcept>? an_ = E?.Type;

            CqlConcept? ao_(CodeableConcept? @this) {
                CqlConcept? as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return as_;
            }


            bool? ap_(CqlConcept? T) {
                CqlCode? at_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept? au_ = context.Operators.ConvertCodeToConcept(at_);
                bool? av_ = context.Operators.Equivalent(T, au_);
                return av_;
            }

            IEnumerable<CqlConcept?>? aq_ = context.Operators.SelectWhere<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)an_, ao_, ap_);
            bool? ar_ = context.Operators.Exists<CqlConcept?>(aq_);
            return ar_;
        }

        IEnumerable<Encounter?>? ah_ = context.Operators.Where<Encounter?>(af_, ag_);
        IEnumerable<Encounter?>? ai_ = context.Operators.Union<Encounter?>(ae_, ah_);
        IEnumerable<Encounter?>? aj_ = context.Operators.Union<Encounter?>(ac_, ai_);
        IEnumerable<Encounter?>? ak_ = Status_1_15_000.Instance.isEncounterPerformed(context, aj_);

        bool? al_(Encounter? ValidEncounters) {
            CqlInterval<CqlDateTime?>? aw_ = this.Measurement_Period(context);
            Period? ax_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime?>? ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
            bool? az_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(aw_, ay_, (string?)default);
            return az_;
        }

        IEnumerable<Encounter?>? am_ = context.Operators.Where<Encounter?>(ak_, al_);
        return am_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -4399740766800447863L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.End(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 65);
        IEnumerable<Encounter?>? j_ = this.Qualifying_Encounters(context);
        bool? k_ = context.Operators.Exists<Encounter?>(j_);
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
    public IEnumerable<MedicationRequest?>? moreThanOneOrder(CqlContext context, IEnumerable<MedicationRequest?>? Medication)
    {
        IEnumerable<MedicationRequest?>? a_ = Status_1_15_000.Instance.isMedicationOrder(context, Medication);

        bool? b_(MedicationRequest? OrderMedication1) {
            IEnumerable<MedicationRequest?>? f_ = Status_1_15_000.Instance.isMedicationOrder(context, Medication);

            bool? g_(MedicationRequest? OrderMedication2) {
                FhirDateTime? i_ = OrderMedication1?.AuthoredOnElement;
                CqlDateTime? j_ = context.Operators.Convert<CqlDateTime?>(i_);
                CqlInterval<CqlDateTime?>? k_ = this.Measurement_Period(context);
                bool? l_ = context.Operators.In<CqlDateTime?>(j_, k_, (string?)default);
                MedicationRequest.DispenseRequestComponent? m_ = OrderMedication1?.DispenseRequest;
                UnsignedInt? n_ = m_?.NumberOfRepeatsAllowedElement;
                int? o_ = n_?.Value;
                bool? p_ = context.Operators.GreaterOrEqual(o_, 1);
                bool? q_ = context.Operators.And(l_, p_);
                CqlDate? r_ = context.Operators.DateFrom(j_);
                FhirDateTime? s_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime? t_ = context.Operators.Convert<CqlDateTime?>(s_);
                CqlDate? u_ = context.Operators.DateFrom(t_);
                bool? v_ = context.Operators.Equivalent(r_, u_);
                bool? w_ = context.Operators.Not(v_);
                bool? x_ = context.Operators.And(w_, l_);
                bool? y_ = context.Operators.In<CqlDateTime?>(t_, k_, (string?)default);
                bool? z_ = context.Operators.And(x_, y_);
                bool? aa_ = context.Operators.Or(q_, z_);
                bool? ab_ = context.Operators.And(v_, l_);
                CqlInterval<CqlDate?>? ac_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate? ad_ = context.Operators.Start(ac_);
                CqlDateTime? ae_ = context.Operators.ConvertDateToDateTime(ad_);
                CqlDate? af_ = context.Operators.DateFrom(ae_);
                CqlInterval<CqlDate?>? ag_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate? ah_ = context.Operators.Start(ag_);
                CqlDateTime? ai_ = context.Operators.ConvertDateToDateTime(ah_);
                CqlDate? aj_ = context.Operators.DateFrom(ai_);
                bool? ak_ = context.Operators.Equivalent(af_, aj_);
                bool? al_ = context.Operators.Not(ak_);
                bool? am_ = context.Operators.And(ab_, al_);
                bool? an_ = context.Operators.In<CqlDateTime?>(ae_, k_, (string?)default);
                bool? ao_ = context.Operators.And(am_, an_);
                bool? ap_ = context.Operators.In<CqlDateTime?>(ai_, k_, (string?)default);
                bool? aq_ = context.Operators.And(ao_, ap_);
                bool? ar_ = context.Operators.Or(aa_, aq_);
                return ar_;
            }

            bool? h_ = context.Operators.WhereAny<MedicationRequest?>(f_, g_);
            return h_;
        }

        MedicationRequest? c_(MedicationRequest? OrderMedication1) => OrderMedication1;
        IEnumerable<MedicationRequest?>? d_ = context.Operators.WhereSelect<MedicationRequest?, MedicationRequest?>(a_, b_, c_);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Distinct<MedicationRequest?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest?>? Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Same_High_Risk_Medications_Ordered_on_Different_Days, Same_High_Risk_Medications_Ordered_on_Different_Days_Compute);

    private const long _cacheIndex_Same_High_Risk_Medications_Ordered_on_Different_Days = 6848809231216479323L;

    private IEnumerable<MedicationRequest?>? Same_High_Risk_Medications_Ordered_on_Different_Days_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? dx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dy_(Medication? M) {
                object? ea_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? eb_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ec_ = context.Operators.Split((string?)eb_, "/");
                string? ed_ = context.Operators.Last<string?>(ec_);
                bool? ee_ = context.Operators.Equal(ea_, ed_);
                CodeableConcept? ef_ = M?.Code;
                CqlConcept? eg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ef_);
                CqlValueSet? eh_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
                bool? ei_ = context.Operators.ConceptInValueSet(eg_, eh_);
                bool? ej_ = context.Operators.And(ee_, ei_);
                return ej_;
            }

            bool? dz_ = context.Operators.WhereAny<Medication?>(dx_, dy_);
            return dz_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);
        IEnumerable<MedicationRequest?>? g_ = this.moreThanOneOrder(context, f_);

        bool? h_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ek_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? el_(Medication? M) {
                object? en_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? eo_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ep_ = context.Operators.Split((string?)eo_, "/");
                string? eq_ = context.Operators.Last<string?>(ep_);
                bool? er_ = context.Operators.Equal(en_, eq_);
                CodeableConcept? es_ = M?.Code;
                CqlConcept? et_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, es_);
                CqlValueSet? eu_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
                bool? ev_ = context.Operators.ConceptInValueSet(et_, eu_);
                bool? ew_ = context.Operators.And(er_, ev_);
                return ew_;
            }

            bool? em_ = context.Operators.WhereAny<Medication?>(ek_, el_);
            return em_;
        }

        IEnumerable<MedicationRequest?>? i_ = context.Operators.Where<MedicationRequest?>(a_, h_);
        CqlValueSet? j_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? l_ = context.Operators.Union<MedicationRequest?>(i_, k_);
        IEnumerable<MedicationRequest?>? m_ = this.moreThanOneOrder(context, l_);
        IEnumerable<MedicationRequest?>? n_ = context.Operators.Union<MedicationRequest?>(g_, m_);

        bool? o_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ex_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ey_(Medication? M) {
                object? fa_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? fb_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? fc_ = context.Operators.Split((string?)fb_, "/");
                string? fd_ = context.Operators.Last<string?>(fc_);
                bool? fe_ = context.Operators.Equal(fa_, fd_);
                CodeableConcept? ff_ = M?.Code;
                CqlConcept? fg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ff_);
                CqlValueSet? fh_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
                bool? fi_ = context.Operators.ConceptInValueSet(fg_, fh_);
                bool? fj_ = context.Operators.And(fe_, fi_);
                return fj_;
            }

            bool? ez_ = context.Operators.WhereAny<Medication?>(ex_, ey_);
            return ez_;
        }

        IEnumerable<MedicationRequest?>? p_ = context.Operators.Where<MedicationRequest?>(a_, o_);
        CqlValueSet? q_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? r_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? s_ = context.Operators.Union<MedicationRequest?>(p_, r_);
        IEnumerable<MedicationRequest?>? t_ = this.moreThanOneOrder(context, s_);

        bool? u_(MedicationRequest? MR) {
            IEnumerable<Medication?>? fk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fl_(Medication? M) {
                object? fn_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? fo_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? fp_ = context.Operators.Split((string?)fo_, "/");
                string? fq_ = context.Operators.Last<string?>(fp_);
                bool? fr_ = context.Operators.Equal(fn_, fq_);
                CodeableConcept? fs_ = M?.Code;
                CqlConcept? ft_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fs_);
                CqlValueSet? fu_ = this.Dipyridamole_Medications(context);
                bool? fv_ = context.Operators.ConceptInValueSet(ft_, fu_);
                bool? fw_ = context.Operators.And(fr_, fv_);
                return fw_;
            }

            bool? fm_ = context.Operators.WhereAny<Medication?>(fk_, fl_);
            return fm_;
        }

        IEnumerable<MedicationRequest?>? v_ = context.Operators.Where<MedicationRequest?>(a_, u_);
        CqlValueSet? w_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest?>? x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? y_ = context.Operators.Union<MedicationRequest?>(v_, x_);
        IEnumerable<MedicationRequest?>? z_ = this.moreThanOneOrder(context, y_);
        IEnumerable<MedicationRequest?>? aa_ = context.Operators.Union<MedicationRequest?>(t_, z_);
        IEnumerable<MedicationRequest?>? ab_ = context.Operators.Union<MedicationRequest?>(n_, aa_);

        bool? ac_(MedicationRequest? MR) {
            IEnumerable<Medication?>? fx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fy_(Medication? M) {
                object? ga_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? gb_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? gc_ = context.Operators.Split((string?)gb_, "/");
                string? gd_ = context.Operators.Last<string?>(gc_);
                bool? ge_ = context.Operators.Equal(ga_, gd_);
                CodeableConcept? gf_ = M?.Code;
                CqlConcept? gg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gf_);
                CqlValueSet? gh_ = this.Guanfacine_Medications(context);
                bool? gi_ = context.Operators.ConceptInValueSet(gg_, gh_);
                bool? gj_ = context.Operators.And(ge_, gi_);
                return gj_;
            }

            bool? fz_ = context.Operators.WhereAny<Medication?>(fx_, fy_);
            return fz_;
        }

        IEnumerable<MedicationRequest?>? ad_ = context.Operators.Where<MedicationRequest?>(a_, ac_);
        CqlValueSet? ae_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest?>? af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? ag_ = context.Operators.Union<MedicationRequest?>(ad_, af_);
        IEnumerable<MedicationRequest?>? ah_ = this.moreThanOneOrder(context, ag_);

        bool? ai_(MedicationRequest? MR) {
            IEnumerable<Medication?>? gk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gl_(Medication? M) {
                object? gn_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? go_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? gp_ = context.Operators.Split((string?)go_, "/");
                string? gq_ = context.Operators.Last<string?>(gp_);
                bool? gr_ = context.Operators.Equal(gn_, gq_);
                CodeableConcept? gs_ = M?.Code;
                CqlConcept? gt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gs_);
                CqlValueSet? gu_ = this.Nifedipine_Medications(context);
                bool? gv_ = context.Operators.ConceptInValueSet(gt_, gu_);
                bool? gw_ = context.Operators.And(gr_, gv_);
                return gw_;
            }

            bool? gm_ = context.Operators.WhereAny<Medication?>(gk_, gl_);
            return gm_;
        }

        IEnumerable<MedicationRequest?>? aj_ = context.Operators.Where<MedicationRequest?>(a_, ai_);
        CqlValueSet? ak_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest?>? al_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? am_ = context.Operators.Union<MedicationRequest?>(aj_, al_);
        IEnumerable<MedicationRequest?>? an_ = this.moreThanOneOrder(context, am_);
        IEnumerable<MedicationRequest?>? ao_ = context.Operators.Union<MedicationRequest?>(ah_, an_);
        IEnumerable<MedicationRequest?>? ap_ = context.Operators.Union<MedicationRequest?>(ab_, ao_);

        bool? aq_(MedicationRequest? MR) {
            IEnumerable<Medication?>? gx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gy_(Medication? M) {
                object? ha_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? hb_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? hc_ = context.Operators.Split((string?)hb_, "/");
                string? hd_ = context.Operators.Last<string?>(hc_);
                bool? he_ = context.Operators.Equal(ha_, hd_);
                CodeableConcept? hf_ = M?.Code;
                CqlConcept? hg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hf_);
                CqlValueSet? hh_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
                bool? hi_ = context.Operators.ConceptInValueSet(hg_, hh_);
                bool? hj_ = context.Operators.And(he_, hi_);
                return hj_;
            }

            bool? gz_ = context.Operators.WhereAny<Medication?>(gx_, gy_);
            return gz_;
        }

        IEnumerable<MedicationRequest?>? ar_ = context.Operators.Where<MedicationRequest?>(a_, aq_);
        CqlValueSet? as_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? au_ = context.Operators.Union<MedicationRequest?>(ar_, at_);
        IEnumerable<MedicationRequest?>? av_ = this.moreThanOneOrder(context, au_);

        bool? aw_(MedicationRequest? MR) {
            IEnumerable<Medication?>? hk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hl_(Medication? M) {
                object? hn_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ho_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? hp_ = context.Operators.Split((string?)ho_, "/");
                string? hq_ = context.Operators.Last<string?>(hp_);
                bool? hr_ = context.Operators.Equal(hn_, hq_);
                CodeableConcept? hs_ = M?.Code;
                CqlConcept? ht_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hs_);
                CqlValueSet? hu_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
                bool? hv_ = context.Operators.ConceptInValueSet(ht_, hu_);
                bool? hw_ = context.Operators.And(hr_, hv_);
                return hw_;
            }

            bool? hm_ = context.Operators.WhereAny<Medication?>(hk_, hl_);
            return hm_;
        }

        IEnumerable<MedicationRequest?>? ax_ = context.Operators.Where<MedicationRequest?>(a_, aw_);
        CqlValueSet? ay_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? az_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? ba_ = context.Operators.Union<MedicationRequest?>(ax_, az_);
        IEnumerable<MedicationRequest?>? bb_ = this.moreThanOneOrder(context, ba_);
        IEnumerable<MedicationRequest?>? bc_ = context.Operators.Union<MedicationRequest?>(av_, bb_);
        IEnumerable<MedicationRequest?>? bd_ = context.Operators.Union<MedicationRequest?>(ap_, bc_);

        bool? be_(MedicationRequest? MR) {
            IEnumerable<Medication?>? hx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hy_(Medication? M) {
                object? ia_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ib_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ic_ = context.Operators.Split((string?)ib_, "/");
                string? id_ = context.Operators.Last<string?>(ic_);
                bool? ie_ = context.Operators.Equal(ia_, id_);
                CodeableConcept? if_ = M?.Code;
                CqlConcept? ig_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, if_);
                CqlCode? ih_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
                CqlConcept? ii_ = context.Operators.ConvertCodeToConcept(ih_);
                bool? ij_ = context.Operators.Equivalent(ig_, ii_);
                bool? ik_ = context.Operators.And(ie_, ij_);
                return ik_;
            }

            bool? hz_ = context.Operators.WhereAny<Medication?>(hx_, hy_);
            return hz_;
        }

        IEnumerable<MedicationRequest?>? bf_ = context.Operators.Where<MedicationRequest?>(a_, be_);
        CqlCode? bg_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode?>? bh_ = context.Operators.ToList<CqlCode?>(bg_);
        IEnumerable<MedicationRequest?>? bi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, bh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? bj_ = context.Operators.Union<MedicationRequest?>(bf_, bi_);
        IEnumerable<MedicationRequest?>? bk_ = this.moreThanOneOrder(context, bj_);

        bool? bl_(MedicationRequest? MR) {
            IEnumerable<Medication?>? il_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? im_(Medication? M) {
                object? io_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ip_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? iq_ = context.Operators.Split((string?)ip_, "/");
                string? ir_ = context.Operators.Last<string?>(iq_);
                bool? is_ = context.Operators.Equal(io_, ir_);
                CodeableConcept? it_ = M?.Code;
                CqlConcept? iu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, it_);
                CqlValueSet? iv_ = this.Meprobamate_Medications(context);
                bool? iw_ = context.Operators.ConceptInValueSet(iu_, iv_);
                bool? ix_ = context.Operators.And(is_, iw_);
                return ix_;
            }

            bool? in_ = context.Operators.WhereAny<Medication?>(il_, im_);
            return in_;
        }

        IEnumerable<MedicationRequest?>? bm_ = context.Operators.Where<MedicationRequest?>(a_, bl_);
        CqlValueSet? bn_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest?>? bo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? bp_ = context.Operators.Union<MedicationRequest?>(bm_, bo_);
        IEnumerable<MedicationRequest?>? bq_ = this.moreThanOneOrder(context, bp_);
        IEnumerable<MedicationRequest?>? br_ = context.Operators.Union<MedicationRequest?>(bk_, bq_);
        IEnumerable<MedicationRequest?>? bs_ = context.Operators.Union<MedicationRequest?>(bd_, br_);

        bool? bt_(MedicationRequest? MR) {
            IEnumerable<Medication?>? iy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? iz_(Medication? M) {
                object? jb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? jc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? jd_ = context.Operators.Split((string?)jc_, "/");
                string? je_ = context.Operators.Last<string?>(jd_);
                bool? jf_ = context.Operators.Equal(jb_, je_);
                CodeableConcept? jg_ = M?.Code;
                CqlConcept? jh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jg_);
                CqlValueSet? ji_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
                bool? jj_ = context.Operators.ConceptInValueSet(jh_, ji_);
                bool? jk_ = context.Operators.And(jf_, jj_);
                return jk_;
            }

            bool? ja_ = context.Operators.WhereAny<Medication?>(iy_, iz_);
            return ja_;
        }

        IEnumerable<MedicationRequest?>? bu_ = context.Operators.Where<MedicationRequest?>(a_, bt_);
        CqlValueSet? bv_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? bw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? bx_ = context.Operators.Union<MedicationRequest?>(bu_, bw_);
        IEnumerable<MedicationRequest?>? by_ = this.moreThanOneOrder(context, bx_);

        bool? bz_(MedicationRequest? MR) {
            IEnumerable<Medication?>? jl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jm_(Medication? M) {
                object? jo_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? jp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? jq_ = context.Operators.Split((string?)jp_, "/");
                string? jr_ = context.Operators.Last<string?>(jq_);
                bool? js_ = context.Operators.Equal(jo_, jr_);
                CodeableConcept? jt_ = M?.Code;
                CqlConcept? ju_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jt_);
                CqlValueSet? jv_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
                bool? jw_ = context.Operators.ConceptInValueSet(ju_, jv_);
                bool? jx_ = context.Operators.And(js_, jw_);
                return jx_;
            }

            bool? jn_ = context.Operators.WhereAny<Medication?>(jl_, jm_);
            return jn_;
        }

        IEnumerable<MedicationRequest?>? ca_ = context.Operators.Where<MedicationRequest?>(a_, bz_);
        CqlValueSet? cb_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? cc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? cd_ = context.Operators.Union<MedicationRequest?>(ca_, cc_);
        IEnumerable<MedicationRequest?>? ce_ = this.moreThanOneOrder(context, cd_);
        IEnumerable<MedicationRequest?>? cf_ = context.Operators.Union<MedicationRequest?>(by_, ce_);
        IEnumerable<MedicationRequest?>? cg_ = context.Operators.Union<MedicationRequest?>(bs_, cf_);

        bool? ch_(MedicationRequest? MR) {
            IEnumerable<Medication?>? jy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? jz_(Medication? M) {
                object? kb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? kc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? kd_ = context.Operators.Split((string?)kc_, "/");
                string? ke_ = context.Operators.Last<string?>(kd_);
                bool? kf_ = context.Operators.Equal(kb_, ke_);
                CodeableConcept? kg_ = M?.Code;
                CqlConcept? kh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kg_);
                CqlValueSet? ki_ = this.Desiccated_Thyroid_Medications(context);
                bool? kj_ = context.Operators.ConceptInValueSet(kh_, ki_);
                bool? kk_ = context.Operators.And(kf_, kj_);
                return kk_;
            }

            bool? ka_ = context.Operators.WhereAny<Medication?>(jy_, jz_);
            return ka_;
        }

        IEnumerable<MedicationRequest?>? ci_ = context.Operators.Where<MedicationRequest?>(a_, ch_);
        CqlValueSet? cj_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest?>? ck_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? cl_ = context.Operators.Union<MedicationRequest?>(ci_, ck_);
        IEnumerable<MedicationRequest?>? cm_ = this.moreThanOneOrder(context, cl_);

        bool? cn_(MedicationRequest? MR) {
            IEnumerable<Medication?>? kl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? km_(Medication? M) {
                object? ko_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? kp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? kq_ = context.Operators.Split((string?)kp_, "/");
                string? kr_ = context.Operators.Last<string?>(kq_);
                bool? ks_ = context.Operators.Equal(ko_, kr_);
                CodeableConcept? kt_ = M?.Code;
                CqlConcept? ku_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kt_);
                CqlValueSet? kv_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
                bool? kw_ = context.Operators.ConceptInValueSet(ku_, kv_);
                bool? kx_ = context.Operators.And(ks_, kw_);
                return kx_;
            }

            bool? kn_ = context.Operators.WhereAny<Medication?>(kl_, km_);
            return kn_;
        }

        IEnumerable<MedicationRequest?>? co_ = context.Operators.Where<MedicationRequest?>(a_, cn_);
        CqlValueSet? cp_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? cq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? cr_ = context.Operators.Union<MedicationRequest?>(co_, cq_);
        IEnumerable<MedicationRequest?>? cs_ = this.moreThanOneOrder(context, cr_);
        IEnumerable<MedicationRequest?>? ct_ = context.Operators.Union<MedicationRequest?>(cm_, cs_);
        IEnumerable<MedicationRequest?>? cu_ = context.Operators.Union<MedicationRequest?>(cg_, ct_);

        bool? cv_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ky_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? kz_(Medication? M) {
                object? lb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? lc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ld_ = context.Operators.Split((string?)lc_, "/");
                string? le_ = context.Operators.Last<string?>(ld_);
                bool? lf_ = context.Operators.Equal(lb_, le_);
                CodeableConcept? lg_ = M?.Code;
                CqlConcept? lh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lg_);
                CqlValueSet? li_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
                bool? lj_ = context.Operators.ConceptInValueSet(lh_, li_);
                bool? lk_ = context.Operators.And(lf_, lj_);
                return lk_;
            }

            bool? la_ = context.Operators.WhereAny<Medication?>(ky_, kz_);
            return la_;
        }

        IEnumerable<MedicationRequest?>? cw_ = context.Operators.Where<MedicationRequest?>(a_, cv_);
        CqlValueSet? cx_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? cy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? cz_ = context.Operators.Union<MedicationRequest?>(cw_, cy_);
        IEnumerable<MedicationRequest?>? da_ = this.moreThanOneOrder(context, cz_);

        bool? db_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ll_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lm_(Medication? M) {
                object? lo_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? lp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? lq_ = context.Operators.Split((string?)lp_, "/");
                string? lr_ = context.Operators.Last<string?>(lq_);
                bool? ls_ = context.Operators.Equal(lo_, lr_);
                CodeableConcept? lt_ = M?.Code;
                CqlConcept? lu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lt_);
                CqlValueSet? lv_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
                bool? lw_ = context.Operators.ConceptInValueSet(lu_, lv_);
                bool? lx_ = context.Operators.And(ls_, lw_);
                return lx_;
            }

            bool? ln_ = context.Operators.WhereAny<Medication?>(ll_, lm_);
            return ln_;
        }

        IEnumerable<MedicationRequest?>? dc_ = context.Operators.Where<MedicationRequest?>(a_, db_);
        CqlValueSet? dd_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? de_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? df_ = context.Operators.Union<MedicationRequest?>(dc_, de_);
        IEnumerable<MedicationRequest?>? dg_ = this.moreThanOneOrder(context, df_);
        IEnumerable<MedicationRequest?>? dh_ = context.Operators.Union<MedicationRequest?>(da_, dg_);
        IEnumerable<MedicationRequest?>? di_ = context.Operators.Union<MedicationRequest?>(cu_, dh_);

        bool? dj_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ly_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? lz_(Medication? M) {
                object? mb_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? mc_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? md_ = context.Operators.Split((string?)mc_, "/");
                string? me_ = context.Operators.Last<string?>(md_);
                bool? mf_ = context.Operators.Equal(mb_, me_);
                CodeableConcept? mg_ = M?.Code;
                CqlConcept? mh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mg_);
                CqlValueSet? mi_ = this.Megestrol_Medications(context);
                bool? mj_ = context.Operators.ConceptInValueSet(mh_, mi_);
                bool? mk_ = context.Operators.And(mf_, mj_);
                return mk_;
            }

            bool? ma_ = context.Operators.WhereAny<Medication?>(ly_, lz_);
            return ma_;
        }

        IEnumerable<MedicationRequest?>? dk_ = context.Operators.Where<MedicationRequest?>(a_, dj_);
        CqlValueSet? dl_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest?>? dm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? dn_ = context.Operators.Union<MedicationRequest?>(dk_, dm_);
        IEnumerable<MedicationRequest?>? do_ = this.moreThanOneOrder(context, dn_);

        bool? dp_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ml_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? mm_(Medication? M) {
                object? mo_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? mp_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? mq_ = context.Operators.Split((string?)mp_, "/");
                string? mr_ = context.Operators.Last<string?>(mq_);
                bool? ms_ = context.Operators.Equal(mo_, mr_);
                CodeableConcept? mt_ = M?.Code;
                CqlConcept? mu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mt_);
                CqlValueSet? mv_ = this.Meperidine_Medications(context);
                bool? mw_ = context.Operators.ConceptInValueSet(mu_, mv_);
                bool? mx_ = context.Operators.And(ms_, mw_);
                return mx_;
            }

            bool? mn_ = context.Operators.WhereAny<Medication?>(ml_, mm_);
            return mn_;
        }

        IEnumerable<MedicationRequest?>? dq_ = context.Operators.Where<MedicationRequest?>(a_, dp_);
        CqlValueSet? dr_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest?>? ds_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? dt_ = context.Operators.Union<MedicationRequest?>(dq_, ds_);
        IEnumerable<MedicationRequest?>? du_ = this.moreThanOneOrder(context, dt_);
        IEnumerable<MedicationRequest?>? dv_ = context.Operators.Union<MedicationRequest?>(do_, du_);
        IEnumerable<MedicationRequest?>? dw_ = context.Operators.Union<MedicationRequest?>(di_, dv_);
        return dw_;
    }


    [CqlFunctionDefinition("medicationRequestPeriodInDays")]
    public decimal? medicationRequestPeriodInDays(CqlContext context, MedicationRequest? Request)
    {
        MedicationRequest?[]? a_ = [
            Request,
        ];

        decimal? b_(MedicationRequest? R) {
            MedicationRequest.DispenseRequestComponent? e_ = R?.DispenseRequest;
            Duration? f_ = e_?.ExpectedSupplyDuration;
            CqlQuantity? g_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, f_);
            CqlQuantity? h_ = context.Operators.ConvertQuantity(g_, "d");
            decimal? i_ = h_?.value;
            Quantity? j_ = e_?.Quantity;
            CqlQuantity? k_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, j_);
            decimal? l_ = k_?.value;
            List<Dosage>? m_ = R?.DosageInstruction;
            Dosage? n_ = context.Operators.SingletonFrom<Dosage?>((IEnumerable<Dosage?>?)m_);
            List<Dosage.DoseAndRateComponent>? o_ = n_?.DoseAndRate;
            Dosage.DoseAndRateComponent? p_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent?>((IEnumerable<Dosage.DoseAndRateComponent?>?)o_);
            DataType? q_ = p_?.Dose;
            object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlQuantity? s_ = context.Operators.End(r_ as CqlInterval<CqlQuantity?>);
            decimal? t_ = (s_ ?? r_ as CqlQuantity)?.value;
            Timing? u_ = n_?.Timing;
            Timing.RepeatComponent? v_ = u_?.Repeat;
            PositiveInt? w_ = v_?.FrequencyMaxElement;
            int? x_ = w_?.Value;
            PositiveInt? y_ = v_?.FrequencyElement;
            int? z_ = y_?.Value;
            FhirDecimal? aa_ = v_?.PeriodElement;
            decimal? ab_ = aa_?.Value;
            Code<Timing.UnitsOfTime>? ac_ = v_?.PeriodUnitElement;
            Timing.UnitsOfTime? ad_ = ac_?.Value;
            string? ae_ = context.Operators.Convert<string?>(ad_);
            CqlQuantity? af_ = CumulativeMedicationDuration_6_0_000.Instance.Quantity(context, ab_, ae_);
            decimal? ag_ = CumulativeMedicationDuration_6_0_000.Instance.ToDaily(context, x_ ?? z_, af_);
            List<Time>? ah_ = v_?.TimeOfDayElement;

            string? ai_(Time? @this) {
                string? av_ = @this?.Value;
                return av_;
            }

            IEnumerable<string?>? aj_ = context.Operators.Select<Time?, string?>((IEnumerable<Time?>?)ah_, ai_);

            CqlTime? ak_(string? @string) {
                CqlTime? aw_ = context.Operators.ConvertStringToTime(@string);
                return aw_;
            }

            IEnumerable<CqlTime?>? al_ = context.Operators.Select<string?, CqlTime?>(aj_, ak_);
            int? am_ = context.Operators.Count<CqlTime?>(al_);
            decimal? an_ = context.Operators.ConvertIntegerToDecimal(am_);
            decimal? ao_ = context.Operators.Multiply(t_, (ag_ ?? an_) ?? 1.0m);
            decimal? ap_ = context.Operators.Divide(l_, ao_);
            UnsignedInt? aq_ = e_?.NumberOfRepeatsAllowedElement;
            int? ar_ = aq_?.Value;
            int? as_ = context.Operators.Add(1, ar_ ?? 0);
            decimal? at_ = context.Operators.ConvertIntegerToDecimal(as_);
            decimal? au_ = context.Operators.Multiply(i_ ?? ap_, at_);
            return au_;
        }

        IEnumerable<decimal?>? c_ = context.Operators.SelectDistinct<MedicationRequest?, decimal?>((IEnumerable<MedicationRequest?>?)a_, b_);
        decimal? d_ = context.Operators.SingletonFrom<decimal?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_High_Risk_Medications_with_Prolonged_Duration, Two_High_Risk_Medications_with_Prolonged_Duration_Compute);

    private const long _cacheIndex_Two_High_Risk_Medications_with_Prolonged_Duration = -8402263243327309117L;

    private bool? Two_High_Risk_Medications_with_Prolonged_Duration_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? n_(Medication? M) {
                object? p_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? q_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? r_ = context.Operators.Split((string?)q_, "/");
                string? s_ = context.Operators.Last<string?>(r_);
                bool? t_ = context.Operators.Equal(p_, s_);
                CodeableConcept? u_ = M?.Code;
                CqlConcept? v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet? w_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            bool? o_ = context.Operators.WhereAny<Medication?>(m_, n_);
            return o_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);
        IEnumerable<MedicationRequest?>? g_ = this.moreThanOneOrder(context, f_);

        decimal? h_(MedicationRequest? AntiInfectives) {
            decimal? z_ = this.medicationRequestPeriodInDays(context, AntiInfectives);
            return z_;
        }

        IEnumerable<decimal?>? i_ = context.Operators.Select<MedicationRequest?, decimal?>(g_, h_);
        decimal? j_ = context.Operators.Sum(i_);
        decimal? k_ = context.Operators.ConvertIntegerToDecimal(90);
        bool? l_ = context.Operators.Greater(j_, k_);
        return l_;
    }


    [CqlFunctionDefinition("averageDailyDose")]
    public CqlQuantity? averageDailyDose(CqlContext context, MedicationRequest? MedicationRequest)
    {
        MedicationRequest?[]? a_ = [
            MedicationRequest,
        ];

        CqlQuantity? b_(MedicationRequest? Order) {
            decimal? e_ = this.medicationRequestPeriodInDays(context, Order);
            bool? f_ = context.Operators.Not((bool?)(e_ is null));
            CqlConcept? g_ = CQMCommon_4_1_000.Instance.getMedicationCode(context, Order);
            CqlQuantity? h_ = this.medicationStrengthPerUnit(context, g_);
            string? i_ = h_?.unit;
            bool? j_ = context.Operators.Equal(i_, "mg");
            bool? k_ = context.Operators.Equal(i_, "mg/mL");
            MedicationRequest.DispenseRequestComponent? l_ = Order?.DispenseRequest;
            Quantity? m_ = l_?.Quantity;
            CqlQuantity? n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_);
            string? o_ = n_?.unit;
            bool? p_ = context.Operators.Equal(o_, "mL");
            bool? q_ = context.Operators.And(k_, p_);
            bool? r_ = context.Operators.Or(j_, q_);
            bool? s_ = context.Operators.And(f_, r_);
            if (s_ ?? false)
            {
                MedicationRequest.DispenseRequestComponent? t_ = Order?.DispenseRequest;
                Quantity? u_ = t_?.Quantity;
                CqlQuantity? v_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, u_);
                CqlConcept? w_ = CQMCommon_4_1_000.Instance.getMedicationCode(context, Order);
                CqlQuantity? x_ = this.medicationStrengthPerUnit(context, w_);
                CqlQuantity? y_ = context.Operators.Multiply(v_, x_);
                decimal? z_ = this.medicationRequestPeriodInDays(context, Order);
                CqlQuantity? aa_ = context.Operators.Divide(y_, new CqlQuantity(z_, "d"));
                return aa_;
            }
            else
            {
                return default;
            }
        }

        IEnumerable<CqlQuantity?>? c_ = context.Operators.SelectDistinct<MedicationRequest?, CqlQuantity?>((IEnumerable<MedicationRequest?>?)a_, b_);
        CqlQuantity? d_ = context.Operators.SingletonFrom<CqlQuantity?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("medicationStrengthPerUnit")]
    public CqlQuantity? medicationStrengthPerUnit(CqlContext context, CqlConcept? Strength)
    {
        CqlCode? a_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
        CqlConcept? b_ = context.Operators.ConvertCodeToConcept(a_);
        bool? c_ = context.Operators.Equivalent(Strength, b_);
        if (c_ ?? false)
        {
            CqlQuantity? d_ = context.Operators.Quantity(0.05m, "mg/mL");
            return d_;
        }
        else
        {
            CqlCode? e_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
            CqlConcept? f_ = context.Operators.ConvertCodeToConcept(e_);
            bool? g_ = context.Operators.Equivalent(Strength, f_);
            if (g_ ?? false)
            {
                CqlQuantity? h_ = context.Operators.Quantity(0.0625m, "mg");
                return h_;
            }
            else
            {
                CqlCode? i_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
                CqlConcept? j_ = context.Operators.ConvertCodeToConcept(i_);
                bool? k_ = context.Operators.Equivalent(Strength, j_);
                if (k_ ?? false)
                {
                    CqlQuantity? l_ = context.Operators.Quantity(0.1m, "mg/mL");
                    return l_;
                }
                else
                {
                    CqlCode? m_ = this.digoxin_0_125_MG_Oral_Tablet(context);
                    CqlConcept? n_ = context.Operators.ConvertCodeToConcept(m_);
                    bool? o_ = context.Operators.Equivalent(Strength, n_);
                    if (o_ ?? false)
                    {
                        CqlQuantity? p_ = context.Operators.Quantity(0.125m, "mg");
                        return p_;
                    }
                    else
                    {
                        CqlCode? q_ = this.digoxin_0_25_MG_Oral_Tablet(context);
                        CqlConcept? r_ = context.Operators.ConvertCodeToConcept(q_);
                        bool? s_ = context.Operators.Equivalent(Strength, r_);
                        if (s_ ?? false)
                        {
                            CqlQuantity? t_ = context.Operators.Quantity(0.25m, "mg");
                            return t_;
                        }
                        else
                        {
                            CqlCode? u_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
                            CqlConcept? v_ = context.Operators.ConvertCodeToConcept(u_);
                            bool? w_ = context.Operators.Equivalent(Strength, v_);
                            if (w_ ?? false)
                            {
                                CqlQuantity? x_ = context.Operators.Quantity(0.25m, "mg/mL");
                                return x_;
                            }
                            else
                            {
                                CqlCode? y_ = this.doxepin_3_MG_Oral_Tablet(context);
                                CqlConcept? z_ = context.Operators.ConvertCodeToConcept(y_);
                                bool? aa_ = context.Operators.Equivalent(Strength, z_);
                                if (aa_ ?? false)
                                {
                                    CqlQuantity? ab_ = context.Operators.Quantity(3m, "mg");
                                    return ab_;
                                }
                                else
                                {
                                    CqlCode? ac_ = this.doxepin_6_MG_Oral_Tablet(context);
                                    CqlConcept? ad_ = context.Operators.ConvertCodeToConcept(ac_);
                                    bool? ae_ = context.Operators.Equivalent(Strength, ad_);
                                    if (ae_ ?? false)
                                    {
                                        CqlQuantity? af_ = context.Operators.Quantity(6m, "mg");
                                        return af_;
                                    }
                                    else
                                    {
                                        CqlCode? ag_ = this.doxepin_10_MG_Oral_Capsule(context);
                                        CqlConcept? ah_ = context.Operators.ConvertCodeToConcept(ag_);
                                        bool? ai_ = context.Operators.Equivalent(Strength, ah_);
                                        if (ai_ ?? false)
                                        {
                                            CqlQuantity? aj_ = context.Operators.Quantity(10m, "mg");
                                            return aj_;
                                        }
                                        else
                                        {
                                            CqlCode? ak_ = this.doxepin_10_MG_ML_Oral_Solution(context);
                                            CqlConcept? al_ = context.Operators.ConvertCodeToConcept(ak_);
                                            bool? am_ = context.Operators.Equivalent(Strength, al_);
                                            if (am_ ?? false)
                                            {
                                                CqlQuantity? an_ = context.Operators.Quantity(10m, "mg/mL");
                                                return an_;
                                            }
                                            else
                                            {
                                                CqlCode? ao_ = this.doxepin_25_MG_Oral_Capsule(context);
                                                CqlConcept? ap_ = context.Operators.ConvertCodeToConcept(ao_);
                                                bool? aq_ = context.Operators.Equivalent(Strength, ap_);
                                                if (aq_ ?? false)
                                                {
                                                    CqlQuantity? ar_ = context.Operators.Quantity(25m, "mg");
                                                    return ar_;
                                                }
                                                else
                                                {
                                                    CqlCode? as_ = this.doxepin_50_MG_Oral_Capsule(context);
                                                    CqlConcept? at_ = context.Operators.ConvertCodeToConcept(as_);
                                                    bool? au_ = context.Operators.Equivalent(Strength, at_);
                                                    if (au_ ?? false)
                                                    {
                                                        CqlQuantity? av_ = context.Operators.Quantity(50m, "mg");
                                                        return av_;
                                                    }
                                                    else
                                                    {
                                                        CqlCode? aw_ = this.doxepin_75_MG_Oral_Capsule(context);
                                                        CqlConcept? ax_ = context.Operators.ConvertCodeToConcept(aw_);
                                                        bool? ay_ = context.Operators.Equivalent(Strength, ax_);
                                                        if (ay_ ?? false)
                                                        {
                                                            CqlQuantity? az_ = context.Operators.Quantity(75m, "mg");
                                                            return az_;
                                                        }
                                                        else
                                                        {
                                                            CqlCode? ba_ = this.doxepin_100_MG_Oral_Capsule(context);
                                                            CqlConcept? bb_ = context.Operators.ConvertCodeToConcept(ba_);
                                                            bool? bc_ = context.Operators.Equivalent(Strength, bb_);
                                                            if (bc_ ?? false)
                                                            {
                                                                CqlQuantity? bd_ = context.Operators.Quantity(100m, "mg");
                                                                return bd_;
                                                            }
                                                            else
                                                            {
                                                                CqlCode? be_ = this.doxepin_150_MG_Oral_Capsule(context);
                                                                CqlConcept? bf_ = context.Operators.ConvertCodeToConcept(be_);
                                                                bool? bg_ = context.Operators.Equivalent(Strength, bf_);
                                                                if (bg_ ?? false)
                                                                {
                                                                    CqlQuantity? bh_ = context.Operators.Quantity(150m, "mg");
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
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? u_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? v_(Medication? M) {
                object? x_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? y_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? z_ = context.Operators.Split((string?)y_, "/");
                string? aa_ = context.Operators.Last<string?>(z_);
                bool? ab_ = context.Operators.Equal(x_, aa_);
                CodeableConcept? ac_ = M?.Code;
                CqlConcept? ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                CqlValueSet? ae_ = this.Digoxin_Medications(context);
                bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }

            bool? w_ = context.Operators.WhereAny<Medication?>(u_, v_);
            return w_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Digoxin_Medications(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);

        bool? g_(MedicationRequest? DigoxinOrdered) {
            CqlQuantity? ah_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity? ai_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? aj_ = context.Operators.Greater(ah_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(f_, g_);
        IEnumerable<MedicationRequest?>? i_ = this.moreThanOneOrder(context, h_);
        bool? j_ = context.Operators.Exists<MedicationRequest?>(i_);

        bool? k_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ak_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? al_(Medication? M) {
                object? an_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ao_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ap_ = context.Operators.Split((string?)ao_, "/");
                string? aq_ = context.Operators.Last<string?>(ap_);
                bool? ar_ = context.Operators.Equal(an_, aq_);
                CodeableConcept? as_ = M?.Code;
                CqlConcept? at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, as_);
                CqlValueSet? au_ = this.Doxepin_Medications(context);
                bool? av_ = context.Operators.ConceptInValueSet(at_, au_);
                bool? aw_ = context.Operators.And(ar_, av_);
                return aw_;
            }

            bool? am_ = context.Operators.WhereAny<Medication?>(ak_, al_);
            return am_;
        }

        IEnumerable<MedicationRequest?>? l_ = context.Operators.Where<MedicationRequest?>(a_, k_);
        CqlValueSet? m_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest?>? n_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? o_ = context.Operators.Union<MedicationRequest?>(l_, n_);

        bool? p_(MedicationRequest? DoxepinOrdered) {
            CqlQuantity? ax_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity? ay_ = context.Operators.Quantity(6m, "mg/d");
            bool? az_ = context.Operators.Greater(ax_, ay_);
            return az_;
        }

        IEnumerable<MedicationRequest?>? q_ = context.Operators.Where<MedicationRequest?>(o_, p_);
        IEnumerable<MedicationRequest?>? r_ = this.moreThanOneOrder(context, q_);
        bool? s_ = context.Operators.Exists<MedicationRequest?>(r_);
        bool? t_ = context.Operators.Or(j_, s_);
        return t_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = 6657473660832751437L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
        bool? b_ = context.Operators.Exists<MedicationRequest?>(a_);
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
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication? M) {
                object? l_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? m_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? n_ = context.Operators.Split((string?)m_, "/");
                string? o_ = context.Operators.Last<string?>(n_);
                bool? p_ = context.Operators.Equal(l_, o_);
                CodeableConcept? q_ = M?.Code;
                CqlConcept? r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet? s_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);
        IEnumerable<MedicationRequest?>? g_ = this.moreThanOneOrder(context, f_);
        bool? h_ = context.Operators.Exists<MedicationRequest?>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Schizophrenia Diagnosis")]
    public IEnumerable<Condition?>? Schizophrenia_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Schizophrenia_Diagnosis, Schizophrenia_Diagnosis_Compute);

    private const long _cacheIndex_Schizophrenia_Diagnosis = 2608599169925942613L;

    private IEnumerable<Condition?>? Schizophrenia_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Schizophrenia(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);
        IEnumerable<Condition?>? e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Bipolar Disorder Diagnosis")]
    public IEnumerable<Condition?>? Bipolar_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bipolar_Disorder_Diagnosis, Bipolar_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_Bipolar_Disorder_Diagnosis = 3459923094508400090L;

    private IEnumerable<Condition?>? Bipolar_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);
        IEnumerable<Condition?>? e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Antipsychotic Index Prescription Start Date")]
    public CqlDateTime? Antipsychotic_Index_Prescription_Start_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Antipsychotic_Index_Prescription_Start_Date, Antipsychotic_Index_Prescription_Start_Date_Compute);

    private const long _cacheIndex_Antipsychotic_Index_Prescription_Start_Date = -2392062725737743630L;

    private CqlDateTime? Antipsychotic_Index_Prescription_Start_Date_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? o_(Medication? M) {
                object? q_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? r_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? s_ = context.Operators.Split((string?)r_, "/");
                string? t_ = context.Operators.Last<string?>(s_);
                bool? u_ = context.Operators.Equal(q_, t_);
                CodeableConcept? v_ = M?.Code;
                CqlConcept? w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlValueSet? x_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                bool? z_ = context.Operators.And(u_, y_);
                return z_;
            }

            bool? p_ = context.Operators.WhereAny<Medication?>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);
        IEnumerable<MedicationRequest?>? g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest? AntipsychoticMedication) {
            FhirDateTime? aa_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime? ab_ = context.Operators.Convert<CqlDateTime?>(aa_);
            CqlInterval<CqlDateTime?>? ac_ = this.Measurement_Period(context);
            bool? ad_ = context.Operators.In<CqlDateTime?>(ab_, ac_, (string?)default);
            return ad_;
        }


        CqlDateTime? i_(MedicationRequest? AntipsychoticMedication) {
            FhirDateTime? ae_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime? af_ = context.Operators.Convert<CqlDateTime?>(ae_);
            return af_;
        }

        IEnumerable<CqlDateTime?>? j_ = context.Operators.WhereSelect<MedicationRequest?, CqlDateTime?>(g_, h_, i_);
        IEnumerable<CqlDateTime?>? k_ = context.Operators.Distinct<CqlDateTime?>(j_);
        IEnumerable<CqlDateTime?>? l_ = context.Operators.ListSort<CqlDateTime?>(k_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime? m_ = context.Operators.First<CqlDateTime?>(l_);
        return m_;
    }


    [CqlExpressionDefinition("More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_More_than_One_Benzodiazepine_Order, More_than_One_Benzodiazepine_Order_Compute);

    private const long _cacheIndex_More_than_One_Benzodiazepine_Order = -7787489465336773734L;

    private bool? More_than_One_Benzodiazepine_Order_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication? M) {
                object? l_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? m_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? n_ = context.Operators.Split((string?)m_, "/");
                string? o_ = context.Operators.Last<string?>(n_);
                bool? p_ = context.Operators.Equal(l_, o_);
                CodeableConcept? q_ = M?.Code;
                CqlConcept? r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet? s_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);
        IEnumerable<MedicationRequest?>? g_ = this.moreThanOneOrder(context, f_);
        bool? h_ = context.Operators.Exists<MedicationRequest?>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Seizure Disorder Diagnosis")]
    public IEnumerable<Condition?>? Seizure_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Seizure_Disorder_Diagnosis, Seizure_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_Seizure_Disorder_Diagnosis = -1131365608370837245L;

    private IEnumerable<Condition?>? Seizure_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Seizure_Disorder(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);
        IEnumerable<Condition?>? e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("REM Sleep Behavior Disorder Diagnosis")]
    public IEnumerable<Condition?>? REM_Sleep_Behavior_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_REM_Sleep_Behavior_Disorder_Diagnosis, REM_Sleep_Behavior_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_REM_Sleep_Behavior_Disorder_Diagnosis = 1960016341670198298L;

    private IEnumerable<Condition?>? REM_Sleep_Behavior_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.REM_Sleep_Behavior_Disorder(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);
        IEnumerable<Condition?>? e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Benzodiazepine Withdrawal Diagnosis")]
    public IEnumerable<Condition?>? Benzodiazepine_Withdrawal_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Benzodiazepine_Withdrawal_Diagnosis, Benzodiazepine_Withdrawal_Diagnosis_Compute);

    private const long _cacheIndex_Benzodiazepine_Withdrawal_Diagnosis = 8657316729577408796L;

    private IEnumerable<Condition?>? Benzodiazepine_Withdrawal_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Benzodiazepine_Withdrawal(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);
        IEnumerable<Condition?>? e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Alcohol Withdrawal Diagnosis")]
    public IEnumerable<Condition?>? Alcohol_Withdrawal_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Alcohol_Withdrawal_Diagnosis, Alcohol_Withdrawal_Diagnosis_Compute);

    private const long _cacheIndex_Alcohol_Withdrawal_Diagnosis = -4814865430801165110L;

    private IEnumerable<Condition?>? Alcohol_Withdrawal_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Alcohol_Withdrawal(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);
        IEnumerable<Condition?>? e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Generalized Anxiety Disorder Diagnosis")]
    public IEnumerable<Condition?>? Generalized_Anxiety_Disorder_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Generalized_Anxiety_Disorder_Diagnosis, Generalized_Anxiety_Disorder_Diagnosis_Compute);

    private const long _cacheIndex_Generalized_Anxiety_Disorder_Diagnosis = -2199162515832252667L;

    private IEnumerable<Condition?>? Generalized_Anxiety_Disorder_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Generalized_Anxiety_Disorder(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);
        IEnumerable<Condition?>? e_ = Status_1_15_000.Instance.verified(context, d_);
        return e_;
    }


    [CqlExpressionDefinition("Benzodiazepine Index Prescription Start Date")]
    public CqlDateTime? Benzodiazepine_Index_Prescription_Start_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Benzodiazepine_Index_Prescription_Start_Date, Benzodiazepine_Index_Prescription_Start_Date_Compute);

    private const long _cacheIndex_Benzodiazepine_Index_Prescription_Start_Date = -4082436594742457808L;

    private CqlDateTime? Benzodiazepine_Index_Prescription_Start_Date_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? o_(Medication? M) {
                object? q_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? r_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? s_ = context.Operators.Split((string?)r_, "/");
                string? t_ = context.Operators.Last<string?>(s_);
                bool? u_ = context.Operators.Equal(q_, t_);
                CodeableConcept? v_ = M?.Code;
                CqlConcept? w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlValueSet? x_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                bool? z_ = context.Operators.And(u_, y_);
                return z_;
            }

            bool? p_ = context.Operators.WhereAny<Medication?>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationRequest?>? c_ = context.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest?>? e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(c_, e_);
        IEnumerable<MedicationRequest?>? g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest? BenzodiazepineMedication) {
            FhirDateTime? aa_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime? ab_ = context.Operators.Convert<CqlDateTime?>(aa_);
            CqlInterval<CqlDateTime?>? ac_ = this.Measurement_Period(context);
            bool? ad_ = context.Operators.In<CqlDateTime?>(ab_, ac_, (string?)default);
            return ad_;
        }


        CqlDateTime? i_(MedicationRequest? BenzodiazepineMedication) {
            FhirDateTime? ae_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime? af_ = context.Operators.Convert<CqlDateTime?>(ae_);
            return af_;
        }

        IEnumerable<CqlDateTime?>? j_ = context.Operators.WhereSelect<MedicationRequest?, CqlDateTime?>(g_, h_, i_);
        IEnumerable<CqlDateTime?>? k_ = context.Operators.Distinct<CqlDateTime?>(j_);
        IEnumerable<CqlDateTime?>? l_ = context.Operators.ListSort<CqlDateTime?>(k_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime? m_ = context.Operators.First<CqlDateTime?>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -3712140800662252754L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        bool? a_ = this.More_than_One_Antipsychotic_Order(context);
        IEnumerable<Condition?>? b_ = this.Schizophrenia_Diagnosis(context);
        IEnumerable<Condition?>? c_ = this.Bipolar_Disorder_Diagnosis(context);
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_, c_);

        bool? e_(Condition? AntipsychoticTreatedDiagnoses) {
            CqlInterval<CqlDateTime?>? x_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
            CqlInterval<CqlDateTime?>? y_ = this.Measurement_Period(context);
            CqlDateTime? z_ = context.Operators.Start(y_);
            CqlQuantity? aa_ = context.Operators.Quantity(1m, "year");
            CqlDateTime? ab_ = context.Operators.Subtract(z_, aa_);
            CqlDateTime? ac_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime?>? ad_ = context.Operators.Interval(ab_, ac_, true, true);
            bool? ae_ = context.Operators.Overlaps(x_, ad_, (string?)default);
            return ae_;
        }

        bool? f_ = context.Operators.WhereAny<Condition?>(d_, e_);
        bool? g_ = context.Operators.Not(f_);
        bool? h_ = context.Operators.And(a_, g_);
        bool? i_ = this.More_than_One_Benzodiazepine_Order(context);
        IEnumerable<Condition?>? j_ = this.Seizure_Disorder_Diagnosis(context);
        IEnumerable<Condition?>? k_ = this.REM_Sleep_Behavior_Disorder_Diagnosis(context);
        IEnumerable<Condition?>? l_ = context.Operators.Union<Condition?>(j_, k_);
        IEnumerable<Condition?>? m_ = this.Benzodiazepine_Withdrawal_Diagnosis(context);
        IEnumerable<Condition?>? n_ = this.Alcohol_Withdrawal_Diagnosis(context);
        IEnumerable<Condition?>? o_ = context.Operators.Union<Condition?>(m_, n_);
        IEnumerable<Condition?>? p_ = context.Operators.Union<Condition?>(l_, o_);
        IEnumerable<Condition?>? q_ = this.Generalized_Anxiety_Disorder_Diagnosis(context);
        IEnumerable<Condition?>? r_ = context.Operators.Union<Condition?>(p_, q_);

        bool? s_(Condition? BenzodiazepineTreatedDiagnoses) {
            CqlInterval<CqlDateTime?>? af_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
            CqlInterval<CqlDateTime?>? ag_ = this.Measurement_Period(context);
            CqlDateTime? ah_ = context.Operators.Start(ag_);
            CqlQuantity? ai_ = context.Operators.Quantity(1m, "year");
            CqlDateTime? aj_ = context.Operators.Subtract(ah_, ai_);
            CqlDateTime? ak_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime?>? al_ = context.Operators.Interval(aj_, ak_, true, true);
            bool? am_ = context.Operators.Overlaps(af_, al_, (string?)default);
            return am_;
        }

        bool? t_ = context.Operators.WhereAny<Condition?>(r_, s_);
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
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 9018702827967443542L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 1955720262168920359L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 7680980797223397342L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -5152880206814246566L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
