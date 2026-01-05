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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS156FHIRHighRiskMedsElderly", "1.0.000")]
public partial class CMS156FHIRHighRiskMedsElderly_1_0_000 : ILibrary, ISingleton<CMS156FHIRHighRiskMedsElderly_1_0_000>
{
    private CMS156FHIRHighRiskMedsElderly_1_0_000() {}

    public static CMS156FHIRHighRiskMedsElderly_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS156FHIRHighRiskMedsElderly";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, QICoreCommon_4_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

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

    #region CodeSystems

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

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS156FHIRHighRiskMedsElderly-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounters_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        _Qualifying_Encounters_Cached.GetOrReplace(
            context,
            () => {
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
                    bool? ba_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ax_, az_, default);
                    return ba_;
                }

                IEnumerable<Encounter> am_ = context.Operators.Where<Encounter>(ak_, al_);
                return am_;
            });


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
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
            });


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<bool?> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
                bool? b_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
                bool? c_ = context.Operators.Or(a_, b_);
                return c_;
            });


    [CqlFunctionDefinition("moreThanOneOrder")]
    public IEnumerable<MedicationRequest> moreThanOneOrder(CqlContext context, IEnumerable<MedicationRequest> Medication)
    {
        IEnumerable<MedicationRequest> a_ = Status_1_15_000.Instance.isMedicationOrder(context, Medication);

        IEnumerable<MedicationRequest> b_(MedicationRequest OrderMedication1) {
            IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, Medication);

            bool? h_(MedicationRequest OrderMedication2) {
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
                CqlInterval<CqlDate> az_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate ba_ = context.Operators.Start(az_);
                CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                CqlDate bc_ = context.Operators.DateFrom(bb_);
                CqlInterval<CqlDate> bd_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OrderMedication2);
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
            }

            IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
            MedicationRequest j_(MedicationRequest OrderMedication2) => OrderMedication1;
            IEnumerable<MedicationRequest> k_ = context.Operators.Select<MedicationRequest, MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(a_, b_);
        MedicationRequest d_(MedicationRequest OrderMedication1) => OrderMedication1;
        IEnumerable<MedicationRequest> e_ = context.Operators.Select<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Distinct<MedicationRequest>(e_);
        return f_;
    }


    private Cached<IEnumerable<MedicationRequest>> _Same_High_Risk_Medications_Ordered_on_Different_Days_Cached = new();

    [CqlExpressionDefinition("Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context) =>
        _Same_High_Risk_Medications_Ordered_on_Different_Days_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> eo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? ep_(Medication M) {
                        object et_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object eu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> ev_ = context.Operators.Split((string)eu_, "/");
                        string ew_ = context.Operators.Last<string>(ev_);
                        bool? ex_ = context.Operators.Equal(et_, ew_);
                        CodeableConcept ey_ = M?.Code;
                        CqlConcept ez_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ey_);
                        CqlValueSet fa_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
                        bool? fb_ = context.Operators.ConceptInValueSet(ez_, fa_);
                        bool? fc_ = context.Operators.And(ex_, fb_);
                        return fc_;
                    }

                    IEnumerable<Medication> eq_ = context.Operators.Where<Medication>(eo_, ep_);
                    MedicationRequest er_(Medication M) => MR;
                    IEnumerable<MedicationRequest> es_ = context.Operators.Select<Medication, MedicationRequest>(eq_, er_);
                    return es_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);
                CqlValueSet h_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
                IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> k_(MedicationRequest MR) {
                    IEnumerable<Medication> fd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? fe_(Medication M) {
                        object fi_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object fj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> fk_ = context.Operators.Split((string)fj_, "/");
                        string fl_ = context.Operators.Last<string>(fk_);
                        bool? fm_ = context.Operators.Equal(fi_, fl_);
                        CodeableConcept fn_ = M?.Code;
                        CqlConcept fo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fn_);
                        CqlValueSet fp_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
                        bool? fq_ = context.Operators.ConceptInValueSet(fo_, fp_);
                        bool? fr_ = context.Operators.And(fm_, fq_);
                        return fr_;
                    }

                    IEnumerable<Medication> ff_ = context.Operators.Where<Medication>(fd_, fe_);
                    MedicationRequest fg_(Medication M) => MR;
                    IEnumerable<MedicationRequest> fh_ = context.Operators.Select<Medication, MedicationRequest>(ff_, fg_);
                    return fh_;
                }

                IEnumerable<MedicationRequest> l_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, k_);
                IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(i_, l_);
                IEnumerable<MedicationRequest> n_ = this.moreThanOneOrder(context, m_);
                IEnumerable<MedicationRequest> o_ = context.Operators.Union<MedicationRequest>(g_, n_);
                CqlValueSet p_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
                IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> s_(MedicationRequest MR) {
                    IEnumerable<Medication> fs_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? ft_(Medication M) {
                        object fx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object fy_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> fz_ = context.Operators.Split((string)fy_, "/");
                        string ga_ = context.Operators.Last<string>(fz_);
                        bool? gb_ = context.Operators.Equal(fx_, ga_);
                        CodeableConcept gc_ = M?.Code;
                        CqlConcept gd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gc_);
                        CqlValueSet ge_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
                        bool? gf_ = context.Operators.ConceptInValueSet(gd_, ge_);
                        bool? gg_ = context.Operators.And(gb_, gf_);
                        return gg_;
                    }

                    IEnumerable<Medication> fu_ = context.Operators.Where<Medication>(fs_, ft_);
                    MedicationRequest fv_(Medication M) => MR;
                    IEnumerable<MedicationRequest> fw_ = context.Operators.Select<Medication, MedicationRequest>(fu_, fv_);
                    return fw_;
                }

                IEnumerable<MedicationRequest> t_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, s_);
                IEnumerable<MedicationRequest> u_ = context.Operators.Union<MedicationRequest>(q_, t_);
                IEnumerable<MedicationRequest> v_ = this.moreThanOneOrder(context, u_);
                CqlValueSet w_ = this.Dipyridamole_Medications(context);
                IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> z_(MedicationRequest MR) {
                    IEnumerable<Medication> gh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? gi_(Medication M) {
                        object gm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object gn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> go_ = context.Operators.Split((string)gn_, "/");
                        string gp_ = context.Operators.Last<string>(go_);
                        bool? gq_ = context.Operators.Equal(gm_, gp_);
                        CodeableConcept gr_ = M?.Code;
                        CqlConcept gs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gr_);
                        CqlValueSet gt_ = this.Dipyridamole_Medications(context);
                        bool? gu_ = context.Operators.ConceptInValueSet(gs_, gt_);
                        bool? gv_ = context.Operators.And(gq_, gu_);
                        return gv_;
                    }

                    IEnumerable<Medication> gj_ = context.Operators.Where<Medication>(gh_, gi_);
                    MedicationRequest gk_(Medication M) => MR;
                    IEnumerable<MedicationRequest> gl_ = context.Operators.Select<Medication, MedicationRequest>(gj_, gk_);
                    return gl_;
                }

                IEnumerable<MedicationRequest> aa_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, z_);
                IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(x_, aa_);
                IEnumerable<MedicationRequest> ac_ = this.moreThanOneOrder(context, ab_);
                IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(v_, ac_);
                IEnumerable<MedicationRequest> ae_ = context.Operators.Union<MedicationRequest>(o_, ad_);
                CqlValueSet af_ = this.Guanfacine_Medications(context);
                IEnumerable<MedicationRequest> ag_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> ai_(MedicationRequest MR) {
                    IEnumerable<Medication> gw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? gx_(Medication M) {
                        object hb_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object hc_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> hd_ = context.Operators.Split((string)hc_, "/");
                        string he_ = context.Operators.Last<string>(hd_);
                        bool? hf_ = context.Operators.Equal(hb_, he_);
                        CodeableConcept hg_ = M?.Code;
                        CqlConcept hh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hg_);
                        CqlValueSet hi_ = this.Guanfacine_Medications(context);
                        bool? hj_ = context.Operators.ConceptInValueSet(hh_, hi_);
                        bool? hk_ = context.Operators.And(hf_, hj_);
                        return hk_;
                    }

                    IEnumerable<Medication> gy_ = context.Operators.Where<Medication>(gw_, gx_);
                    MedicationRequest gz_(Medication M) => MR;
                    IEnumerable<MedicationRequest> ha_ = context.Operators.Select<Medication, MedicationRequest>(gy_, gz_);
                    return ha_;
                }

                IEnumerable<MedicationRequest> aj_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ai_);
                IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ag_, aj_);
                IEnumerable<MedicationRequest> al_ = this.moreThanOneOrder(context, ak_);
                CqlValueSet am_ = this.Nifedipine_Medications(context);
                IEnumerable<MedicationRequest> an_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> ap_(MedicationRequest MR) {
                    IEnumerable<Medication> hl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? hm_(Medication M) {
                        object hq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object hr_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> hs_ = context.Operators.Split((string)hr_, "/");
                        string ht_ = context.Operators.Last<string>(hs_);
                        bool? hu_ = context.Operators.Equal(hq_, ht_);
                        CodeableConcept hv_ = M?.Code;
                        CqlConcept hw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hv_);
                        CqlValueSet hx_ = this.Nifedipine_Medications(context);
                        bool? hy_ = context.Operators.ConceptInValueSet(hw_, hx_);
                        bool? hz_ = context.Operators.And(hu_, hy_);
                        return hz_;
                    }

                    IEnumerable<Medication> hn_ = context.Operators.Where<Medication>(hl_, hm_);
                    MedicationRequest ho_(Medication M) => MR;
                    IEnumerable<MedicationRequest> hp_ = context.Operators.Select<Medication, MedicationRequest>(hn_, ho_);
                    return hp_;
                }

                IEnumerable<MedicationRequest> aq_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ap_);
                IEnumerable<MedicationRequest> ar_ = context.Operators.Union<MedicationRequest>(an_, aq_);
                IEnumerable<MedicationRequest> as_ = this.moreThanOneOrder(context, ar_);
                IEnumerable<MedicationRequest> at_ = context.Operators.Union<MedicationRequest>(al_, as_);
                IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(ae_, at_);
                CqlValueSet av_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
                IEnumerable<MedicationRequest> aw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> ay_(MedicationRequest MR) {
                    IEnumerable<Medication> ia_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? ib_(Medication M) {
                        object if_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object ig_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> ih_ = context.Operators.Split((string)ig_, "/");
                        string ii_ = context.Operators.Last<string>(ih_);
                        bool? ij_ = context.Operators.Equal(if_, ii_);
                        CodeableConcept ik_ = M?.Code;
                        CqlConcept il_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ik_);
                        CqlValueSet im_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
                        bool? in_ = context.Operators.ConceptInValueSet(il_, im_);
                        bool? io_ = context.Operators.And(ij_, in_);
                        return io_;
                    }

                    IEnumerable<Medication> ic_ = context.Operators.Where<Medication>(ia_, ib_);
                    MedicationRequest id_(Medication M) => MR;
                    IEnumerable<MedicationRequest> ie_ = context.Operators.Select<Medication, MedicationRequest>(ic_, id_);
                    return ie_;
                }

                IEnumerable<MedicationRequest> az_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ay_);
                IEnumerable<MedicationRequest> ba_ = context.Operators.Union<MedicationRequest>(aw_, az_);
                IEnumerable<MedicationRequest> bb_ = this.moreThanOneOrder(context, ba_);
                CqlValueSet bc_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
                IEnumerable<MedicationRequest> bd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> bf_(MedicationRequest MR) {
                    IEnumerable<Medication> ip_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? iq_(Medication M) {
                        object iu_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object iv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> iw_ = context.Operators.Split((string)iv_, "/");
                        string ix_ = context.Operators.Last<string>(iw_);
                        bool? iy_ = context.Operators.Equal(iu_, ix_);
                        CodeableConcept iz_ = M?.Code;
                        CqlConcept ja_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, iz_);
                        CqlValueSet jb_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
                        bool? jc_ = context.Operators.ConceptInValueSet(ja_, jb_);
                        bool? jd_ = context.Operators.And(iy_, jc_);
                        return jd_;
                    }

                    IEnumerable<Medication> ir_ = context.Operators.Where<Medication>(ip_, iq_);
                    MedicationRequest is_(Medication M) => MR;
                    IEnumerable<MedicationRequest> it_ = context.Operators.Select<Medication, MedicationRequest>(ir_, is_);
                    return it_;
                }

                IEnumerable<MedicationRequest> bg_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bf_);
                IEnumerable<MedicationRequest> bh_ = context.Operators.Union<MedicationRequest>(bd_, bg_);
                IEnumerable<MedicationRequest> bi_ = this.moreThanOneOrder(context, bh_);
                IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(bb_, bi_);
                IEnumerable<MedicationRequest> bk_ = context.Operators.Union<MedicationRequest>(au_, bj_);
                CqlCode bl_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
                IEnumerable<CqlCode> bm_ = context.Operators.ToList<CqlCode>(bl_);
                IEnumerable<MedicationRequest> bn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, bm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> bp_(MedicationRequest MR) {
                    IEnumerable<Medication> je_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? jf_(Medication M) {
                        object jj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object jk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> jl_ = context.Operators.Split((string)jk_, "/");
                        string jm_ = context.Operators.Last<string>(jl_);
                        bool? jn_ = context.Operators.Equal(jj_, jm_);
                        CodeableConcept jo_ = M?.Code;
                        CqlConcept jp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jo_);
                        CqlCode jq_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
                        CqlConcept jr_ = context.Operators.ConvertCodeToConcept(jq_);
                        bool? js_ = context.Operators.Equivalent(jp_, jr_);
                        bool? jt_ = context.Operators.And(jn_, js_);
                        return jt_;
                    }

                    IEnumerable<Medication> jg_ = context.Operators.Where<Medication>(je_, jf_);
                    MedicationRequest jh_(Medication M) => MR;
                    IEnumerable<MedicationRequest> ji_ = context.Operators.Select<Medication, MedicationRequest>(jg_, jh_);
                    return ji_;
                }

                IEnumerable<MedicationRequest> bq_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bp_);
                IEnumerable<MedicationRequest> br_ = context.Operators.Union<MedicationRequest>(bn_, bq_);
                IEnumerable<MedicationRequest> bs_ = this.moreThanOneOrder(context, br_);
                CqlValueSet bt_ = this.Meprobamate_Medications(context);
                IEnumerable<MedicationRequest> bu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> bw_(MedicationRequest MR) {
                    IEnumerable<Medication> ju_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? jv_(Medication M) {
                        object jz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object ka_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> kb_ = context.Operators.Split((string)ka_, "/");
                        string kc_ = context.Operators.Last<string>(kb_);
                        bool? kd_ = context.Operators.Equal(jz_, kc_);
                        CodeableConcept ke_ = M?.Code;
                        CqlConcept kf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ke_);
                        CqlValueSet kg_ = this.Meprobamate_Medications(context);
                        bool? kh_ = context.Operators.ConceptInValueSet(kf_, kg_);
                        bool? ki_ = context.Operators.And(kd_, kh_);
                        return ki_;
                    }

                    IEnumerable<Medication> jw_ = context.Operators.Where<Medication>(ju_, jv_);
                    MedicationRequest jx_(Medication M) => MR;
                    IEnumerable<MedicationRequest> jy_ = context.Operators.Select<Medication, MedicationRequest>(jw_, jx_);
                    return jy_;
                }

                IEnumerable<MedicationRequest> bx_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, bw_);
                IEnumerable<MedicationRequest> by_ = context.Operators.Union<MedicationRequest>(bu_, bx_);
                IEnumerable<MedicationRequest> bz_ = this.moreThanOneOrder(context, by_);
                IEnumerable<MedicationRequest> ca_ = context.Operators.Union<MedicationRequest>(bs_, bz_);
                IEnumerable<MedicationRequest> cb_ = context.Operators.Union<MedicationRequest>(bk_, ca_);
                CqlValueSet cc_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
                IEnumerable<MedicationRequest> cd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> cf_(MedicationRequest MR) {
                    IEnumerable<Medication> kj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? kk_(Medication M) {
                        object ko_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object kp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> kq_ = context.Operators.Split((string)kp_, "/");
                        string kr_ = context.Operators.Last<string>(kq_);
                        bool? ks_ = context.Operators.Equal(ko_, kr_);
                        CodeableConcept kt_ = M?.Code;
                        CqlConcept ku_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kt_);
                        CqlValueSet kv_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
                        bool? kw_ = context.Operators.ConceptInValueSet(ku_, kv_);
                        bool? kx_ = context.Operators.And(ks_, kw_);
                        return kx_;
                    }

                    IEnumerable<Medication> kl_ = context.Operators.Where<Medication>(kj_, kk_);
                    MedicationRequest km_(Medication M) => MR;
                    IEnumerable<MedicationRequest> kn_ = context.Operators.Select<Medication, MedicationRequest>(kl_, km_);
                    return kn_;
                }

                IEnumerable<MedicationRequest> cg_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, cf_);
                IEnumerable<MedicationRequest> ch_ = context.Operators.Union<MedicationRequest>(cd_, cg_);
                IEnumerable<MedicationRequest> ci_ = this.moreThanOneOrder(context, ch_);
                CqlValueSet cj_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
                IEnumerable<MedicationRequest> ck_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> cm_(MedicationRequest MR) {
                    IEnumerable<Medication> ky_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? kz_(Medication M) {
                        object ld_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object le_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> lf_ = context.Operators.Split((string)le_, "/");
                        string lg_ = context.Operators.Last<string>(lf_);
                        bool? lh_ = context.Operators.Equal(ld_, lg_);
                        CodeableConcept li_ = M?.Code;
                        CqlConcept lj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, li_);
                        CqlValueSet lk_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
                        bool? ll_ = context.Operators.ConceptInValueSet(lj_, lk_);
                        bool? lm_ = context.Operators.And(lh_, ll_);
                        return lm_;
                    }

                    IEnumerable<Medication> la_ = context.Operators.Where<Medication>(ky_, kz_);
                    MedicationRequest lb_(Medication M) => MR;
                    IEnumerable<MedicationRequest> lc_ = context.Operators.Select<Medication, MedicationRequest>(la_, lb_);
                    return lc_;
                }

                IEnumerable<MedicationRequest> cn_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, cm_);
                IEnumerable<MedicationRequest> co_ = context.Operators.Union<MedicationRequest>(ck_, cn_);
                IEnumerable<MedicationRequest> cp_ = this.moreThanOneOrder(context, co_);
                IEnumerable<MedicationRequest> cq_ = context.Operators.Union<MedicationRequest>(ci_, cp_);
                IEnumerable<MedicationRequest> cr_ = context.Operators.Union<MedicationRequest>(cb_, cq_);
                CqlValueSet cs_ = this.Desiccated_Thyroid_Medications(context);
                IEnumerable<MedicationRequest> ct_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> cv_(MedicationRequest MR) {
                    IEnumerable<Medication> ln_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? lo_(Medication M) {
                        object ls_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object lt_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> lu_ = context.Operators.Split((string)lt_, "/");
                        string lv_ = context.Operators.Last<string>(lu_);
                        bool? lw_ = context.Operators.Equal(ls_, lv_);
                        CodeableConcept lx_ = M?.Code;
                        CqlConcept ly_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lx_);
                        CqlValueSet lz_ = this.Desiccated_Thyroid_Medications(context);
                        bool? ma_ = context.Operators.ConceptInValueSet(ly_, lz_);
                        bool? mb_ = context.Operators.And(lw_, ma_);
                        return mb_;
                    }

                    IEnumerable<Medication> lp_ = context.Operators.Where<Medication>(ln_, lo_);
                    MedicationRequest lq_(Medication M) => MR;
                    IEnumerable<MedicationRequest> lr_ = context.Operators.Select<Medication, MedicationRequest>(lp_, lq_);
                    return lr_;
                }

                IEnumerable<MedicationRequest> cw_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, cv_);
                IEnumerable<MedicationRequest> cx_ = context.Operators.Union<MedicationRequest>(ct_, cw_);
                IEnumerable<MedicationRequest> cy_ = this.moreThanOneOrder(context, cx_);
                CqlValueSet cz_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
                IEnumerable<MedicationRequest> da_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, cz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> dc_(MedicationRequest MR) {
                    IEnumerable<Medication> mc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? md_(Medication M) {
                        object mh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object mi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> mj_ = context.Operators.Split((string)mi_, "/");
                        string mk_ = context.Operators.Last<string>(mj_);
                        bool? ml_ = context.Operators.Equal(mh_, mk_);
                        CodeableConcept mm_ = M?.Code;
                        CqlConcept mn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mm_);
                        CqlValueSet mo_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
                        bool? mp_ = context.Operators.ConceptInValueSet(mn_, mo_);
                        bool? mq_ = context.Operators.And(ml_, mp_);
                        return mq_;
                    }

                    IEnumerable<Medication> me_ = context.Operators.Where<Medication>(mc_, md_);
                    MedicationRequest mf_(Medication M) => MR;
                    IEnumerable<MedicationRequest> mg_ = context.Operators.Select<Medication, MedicationRequest>(me_, mf_);
                    return mg_;
                }

                IEnumerable<MedicationRequest> dd_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, dc_);
                IEnumerable<MedicationRequest> de_ = context.Operators.Union<MedicationRequest>(da_, dd_);
                IEnumerable<MedicationRequest> df_ = this.moreThanOneOrder(context, de_);
                IEnumerable<MedicationRequest> dg_ = context.Operators.Union<MedicationRequest>(cy_, df_);
                IEnumerable<MedicationRequest> dh_ = context.Operators.Union<MedicationRequest>(cr_, dg_);
                CqlValueSet di_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
                IEnumerable<MedicationRequest> dj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, di_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> dl_(MedicationRequest MR) {
                    IEnumerable<Medication> mr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? ms_(Medication M) {
                        object mw_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object mx_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> my_ = context.Operators.Split((string)mx_, "/");
                        string mz_ = context.Operators.Last<string>(my_);
                        bool? na_ = context.Operators.Equal(mw_, mz_);
                        CodeableConcept nb_ = M?.Code;
                        CqlConcept nc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nb_);
                        CqlValueSet nd_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
                        bool? ne_ = context.Operators.ConceptInValueSet(nc_, nd_);
                        bool? nf_ = context.Operators.And(na_, ne_);
                        return nf_;
                    }

                    IEnumerable<Medication> mt_ = context.Operators.Where<Medication>(mr_, ms_);
                    MedicationRequest mu_(Medication M) => MR;
                    IEnumerable<MedicationRequest> mv_ = context.Operators.Select<Medication, MedicationRequest>(mt_, mu_);
                    return mv_;
                }

                IEnumerable<MedicationRequest> dm_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, dl_);
                IEnumerable<MedicationRequest> dn_ = context.Operators.Union<MedicationRequest>(dj_, dm_);
                IEnumerable<MedicationRequest> do_ = this.moreThanOneOrder(context, dn_);
                CqlValueSet dp_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
                IEnumerable<MedicationRequest> dq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> ds_(MedicationRequest MR) {
                    IEnumerable<Medication> ng_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? nh_(Medication M) {
                        object nl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object nm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> nn_ = context.Operators.Split((string)nm_, "/");
                        string no_ = context.Operators.Last<string>(nn_);
                        bool? np_ = context.Operators.Equal(nl_, no_);
                        CodeableConcept nq_ = M?.Code;
                        CqlConcept nr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nq_);
                        CqlValueSet ns_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
                        bool? nt_ = context.Operators.ConceptInValueSet(nr_, ns_);
                        bool? nu_ = context.Operators.And(np_, nt_);
                        return nu_;
                    }

                    IEnumerable<Medication> ni_ = context.Operators.Where<Medication>(ng_, nh_);
                    MedicationRequest nj_(Medication M) => MR;
                    IEnumerable<MedicationRequest> nk_ = context.Operators.Select<Medication, MedicationRequest>(ni_, nj_);
                    return nk_;
                }

                IEnumerable<MedicationRequest> dt_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ds_);
                IEnumerable<MedicationRequest> du_ = context.Operators.Union<MedicationRequest>(dq_, dt_);
                IEnumerable<MedicationRequest> dv_ = this.moreThanOneOrder(context, du_);
                IEnumerable<MedicationRequest> dw_ = context.Operators.Union<MedicationRequest>(do_, dv_);
                IEnumerable<MedicationRequest> dx_ = context.Operators.Union<MedicationRequest>(dh_, dw_);
                CqlValueSet dy_ = this.Megestrol_Medications(context);
                IEnumerable<MedicationRequest> dz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> eb_(MedicationRequest MR) {
                    IEnumerable<Medication> nv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? nw_(Medication M) {
                        object oa_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object ob_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> oc_ = context.Operators.Split((string)ob_, "/");
                        string od_ = context.Operators.Last<string>(oc_);
                        bool? oe_ = context.Operators.Equal(oa_, od_);
                        CodeableConcept of_ = M?.Code;
                        CqlConcept og_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, of_);
                        CqlValueSet oh_ = this.Megestrol_Medications(context);
                        bool? oi_ = context.Operators.ConceptInValueSet(og_, oh_);
                        bool? oj_ = context.Operators.And(oe_, oi_);
                        return oj_;
                    }

                    IEnumerable<Medication> nx_ = context.Operators.Where<Medication>(nv_, nw_);
                    MedicationRequest ny_(Medication M) => MR;
                    IEnumerable<MedicationRequest> nz_ = context.Operators.Select<Medication, MedicationRequest>(nx_, ny_);
                    return nz_;
                }

                IEnumerable<MedicationRequest> ec_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, eb_);
                IEnumerable<MedicationRequest> ed_ = context.Operators.Union<MedicationRequest>(dz_, ec_);
                IEnumerable<MedicationRequest> ee_ = this.moreThanOneOrder(context, ed_);
                CqlValueSet ef_ = this.Meperidine_Medications(context);
                IEnumerable<MedicationRequest> eg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ef_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> ei_(MedicationRequest MR) {
                    IEnumerable<Medication> ok_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? ol_(Medication M) {
                        object op_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object oq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> or_ = context.Operators.Split((string)oq_, "/");
                        string os_ = context.Operators.Last<string>(or_);
                        bool? ot_ = context.Operators.Equal(op_, os_);
                        CodeableConcept ou_ = M?.Code;
                        CqlConcept ov_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ou_);
                        CqlValueSet ow_ = this.Meperidine_Medications(context);
                        bool? ox_ = context.Operators.ConceptInValueSet(ov_, ow_);
                        bool? oy_ = context.Operators.And(ot_, ox_);
                        return oy_;
                    }

                    IEnumerable<Medication> om_ = context.Operators.Where<Medication>(ok_, ol_);
                    MedicationRequest on_(Medication M) => MR;
                    IEnumerable<MedicationRequest> oo_ = context.Operators.Select<Medication, MedicationRequest>(om_, on_);
                    return oo_;
                }

                IEnumerable<MedicationRequest> ej_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, ei_);
                IEnumerable<MedicationRequest> ek_ = context.Operators.Union<MedicationRequest>(eg_, ej_);
                IEnumerable<MedicationRequest> el_ = this.moreThanOneOrder(context, ek_);
                IEnumerable<MedicationRequest> em_ = context.Operators.Union<MedicationRequest>(ee_, el_);
                IEnumerable<MedicationRequest> en_ = context.Operators.Union<MedicationRequest>(dx_, em_);
                return en_;
            });


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


    private Cached<bool?> _Two_High_Risk_Medications_with_Prolonged_Duration_Cached = new();

    [CqlExpressionDefinition("Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context) =>
        _Two_High_Risk_Medications_with_Prolonged_Duration_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? n_(Medication M) {
                        object r_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object s_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> t_ = context.Operators.Split((string)s_, "/");
                        string u_ = context.Operators.Last<string>(t_);
                        bool? v_ = context.Operators.Equal(r_, u_);
                        CodeableConcept w_ = M?.Code;
                        CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                        CqlValueSet y_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
                        bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                        bool? aa_ = context.Operators.And(v_, z_);
                        return aa_;
                    }

                    IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                    MedicationRequest p_(Medication M) => MR;
                    IEnumerable<MedicationRequest> q_ = context.Operators.Select<Medication, MedicationRequest>(o_, p_);
                    return q_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);

                decimal? h_(MedicationRequest AntiInfectives) {
                    decimal? ab_ = this.medicationRequestPeriodInDays(context, AntiInfectives);
                    return ab_;
                }

                IEnumerable<decimal?> i_ = context.Operators.Select<MedicationRequest, decimal?>(g_, h_);
                decimal? j_ = context.Operators.Sum(i_);
                decimal? k_ = context.Operators.ConvertIntegerToDecimal(90);
                bool? l_ = context.Operators.Greater(j_, k_);
                return l_;
            });


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


    private Cached<bool?> _High_Risk_Medications_with_Average_Daily_Dose_Criteria_Cached = new();

    [CqlExpressionDefinition("High Risk Medications with Average Daily Dose Criteria")]
    public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context) =>
        _High_Risk_Medications_with_Average_Daily_Dose_Criteria_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Digoxin_Medications(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> v_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? w_(Medication M) {
                        object aa_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object ab_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> ac_ = context.Operators.Split((string)ab_, "/");
                        string ad_ = context.Operators.Last<string>(ac_);
                        bool? ae_ = context.Operators.Equal(aa_, ad_);
                        CodeableConcept af_ = M?.Code;
                        CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_);
                        CqlValueSet ah_ = this.Digoxin_Medications(context);
                        bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                        bool? aj_ = context.Operators.And(ae_, ai_);
                        return aj_;
                    }

                    IEnumerable<Medication> x_ = context.Operators.Where<Medication>(v_, w_);
                    MedicationRequest y_(Medication M) => MR;
                    IEnumerable<MedicationRequest> z_ = context.Operators.Select<Medication, MedicationRequest>(x_, y_);
                    return z_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

                bool? g_(MedicationRequest DigoxinOrdered) {
                    CqlQuantity ak_ = this.averageDailyDose(context, DigoxinOrdered);
                    CqlQuantity al_ = context.Operators.Quantity(0.125m, "mg/d");
                    bool? am_ = context.Operators.Greater(ak_, al_);
                    return am_;
                }

                IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
                IEnumerable<MedicationRequest> i_ = this.moreThanOneOrder(context, h_);
                bool? j_ = context.Operators.Exists<MedicationRequest>(i_);
                CqlValueSet k_ = this.Doxepin_Medications(context);
                IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> n_(MedicationRequest MR) {
                    IEnumerable<Medication> an_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? ao_(Medication M) {
                        object as_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object at_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> au_ = context.Operators.Split((string)at_, "/");
                        string av_ = context.Operators.Last<string>(au_);
                        bool? aw_ = context.Operators.Equal(as_, av_);
                        CodeableConcept ax_ = M?.Code;
                        CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                        CqlValueSet az_ = this.Doxepin_Medications(context);
                        bool? ba_ = context.Operators.ConceptInValueSet(ay_, az_);
                        bool? bb_ = context.Operators.And(aw_, ba_);
                        return bb_;
                    }

                    IEnumerable<Medication> ap_ = context.Operators.Where<Medication>(an_, ao_);
                    MedicationRequest aq_(Medication M) => MR;
                    IEnumerable<MedicationRequest> ar_ = context.Operators.Select<Medication, MedicationRequest>(ap_, aq_);
                    return ar_;
                }

                IEnumerable<MedicationRequest> o_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, n_);
                IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(l_, o_);

                bool? q_(MedicationRequest DoxepinOrdered) {
                    CqlQuantity bc_ = this.averageDailyDose(context, DoxepinOrdered);
                    CqlQuantity bd_ = context.Operators.Quantity(6m, "mg/d");
                    bool? be_ = context.Operators.Greater(bc_, bd_);
                    return be_;
                }

                IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(p_, q_);
                IEnumerable<MedicationRequest> s_ = this.moreThanOneOrder(context, r_);
                bool? t_ = context.Operators.Exists<MedicationRequest>(s_);
                bool? u_ = context.Operators.Or(j_, t_);
                return u_;
            });


    private Cached<bool?> _Numerator_1_Cached = new();

    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        _Numerator_1_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<MedicationRequest> a_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
                bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
                bool? c_ = this.Two_High_Risk_Medications_with_Prolonged_Duration(context);
                bool? d_ = context.Operators.Or(b_, c_);
                bool? e_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria(context);
                bool? f_ = context.Operators.Or(d_, e_);
                return f_;
            });


    private Cached<bool?> _More_than_One_Antipsychotic_Order_Cached = new();

    [CqlExpressionDefinition("More than One Antipsychotic Order")]
    public bool? More_than_One_Antipsychotic_Order(CqlContext context) =>
        _More_than_One_Antipsychotic_Order_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? j_(Medication M) {
                        object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                        string q_ = context.Operators.Last<string>(p_);
                        bool? r_ = context.Operators.Equal(n_, q_);
                        CodeableConcept s_ = M?.Code;
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                        CqlValueSet u_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                        bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                        bool? w_ = context.Operators.And(r_, v_);
                        return w_;
                    }

                    IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
                    MedicationRequest l_(Medication M) => MR;
                    IEnumerable<MedicationRequest> m_ = context.Operators.Select<Medication, MedicationRequest>(k_, l_);
                    return m_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);
                bool? h_ = context.Operators.Exists<MedicationRequest>(g_);
                return h_;
            });


    private Cached<IEnumerable<object>> _Schizophrenia_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Schizophrenia Diagnosis")]
    public IEnumerable<object> Schizophrenia_Diagnosis(CqlContext context) =>
        _Schizophrenia_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Schizophrenia(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
                return f_;
            });


    private Cached<IEnumerable<object>> _Bipolar_Disorder_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Bipolar Disorder Diagnosis")]
    public IEnumerable<object> Bipolar_Disorder_Diagnosis(CqlContext context) =>
        _Bipolar_Disorder_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Bipolar_Disorder(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
                return f_;
            });


    private Cached<CqlDateTime> _Antipsychotic_Index_Prescription_Start_Date_Cached = new();

    [CqlExpressionDefinition("Antipsychotic Index Prescription Start Date")]
    public CqlDateTime Antipsychotic_Index_Prescription_Start_Date(CqlContext context) =>
        _Antipsychotic_Index_Prescription_Start_Date_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? p_(Medication M) {
                        object t_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object u_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> v_ = context.Operators.Split((string)u_, "/");
                        string w_ = context.Operators.Last<string>(v_);
                        bool? x_ = context.Operators.Equal(t_, w_);
                        CodeableConcept y_ = M?.Code;
                        CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                        CqlValueSet aa_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
                        bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                        bool? ac_ = context.Operators.And(x_, ab_);
                        return ac_;
                    }

                    IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
                    MedicationRequest r_(Medication M) => MR;
                    IEnumerable<MedicationRequest> s_ = context.Operators.Select<Medication, MedicationRequest>(q_, r_);
                    return s_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

                bool? h_(MedicationRequest AntipsychoticMedication) {
                    FhirDateTime ad_ = AntipsychoticMedication?.AuthoredOnElement;
                    CqlDateTime ae_ = context.Operators.Convert<CqlDateTime>(ad_);
                    CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
                    bool? ag_ = context.Operators.In<CqlDateTime>(ae_, af_, default);
                    return ag_;
                }

                IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);

                CqlDateTime j_(MedicationRequest AntipsychoticMedication) {
                    FhirDateTime ah_ = AntipsychoticMedication?.AuthoredOnElement;
                    CqlDateTime ai_ = context.Operators.Convert<CqlDateTime>(ah_);
                    return ai_;
                }

                IEnumerable<CqlDateTime> k_ = context.Operators.Select<MedicationRequest, CqlDateTime>(i_, j_);
                IEnumerable<CqlDateTime> l_ = context.Operators.Distinct<CqlDateTime>(k_);
                IEnumerable<CqlDateTime> m_ = context.Operators.ListSort<CqlDateTime>(l_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime n_ = context.Operators.First<CqlDateTime>(m_);
                return n_;
            });


    private Cached<bool?> _More_than_One_Benzodiazepine_Order_Cached = new();

    [CqlExpressionDefinition("More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context) =>
        _More_than_One_Benzodiazepine_Order_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? j_(Medication M) {
                        object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                        string q_ = context.Operators.Last<string>(p_);
                        bool? r_ = context.Operators.Equal(n_, q_);
                        CodeableConcept s_ = M?.Code;
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                        CqlValueSet u_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                        bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                        bool? w_ = context.Operators.And(r_, v_);
                        return w_;
                    }

                    IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
                    MedicationRequest l_(Medication M) => MR;
                    IEnumerable<MedicationRequest> m_ = context.Operators.Select<Medication, MedicationRequest>(k_, l_);
                    return m_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                IEnumerable<MedicationRequest> g_ = this.moreThanOneOrder(context, f_);
                bool? h_ = context.Operators.Exists<MedicationRequest>(g_);
                return h_;
            });


    private Cached<IEnumerable<object>> _Seizure_Disorder_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Seizure Disorder Diagnosis")]
    public IEnumerable<object> Seizure_Disorder_Diagnosis(CqlContext context) =>
        _Seizure_Disorder_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Seizure_Disorder(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
                return f_;
            });


    private Cached<IEnumerable<object>> _REM_Sleep_Behavior_Disorder_Diagnosis_Cached = new();

    [CqlExpressionDefinition("REM Sleep Behavior Disorder Diagnosis")]
    public IEnumerable<object> REM_Sleep_Behavior_Disorder_Diagnosis(CqlContext context) =>
        _REM_Sleep_Behavior_Disorder_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.REM_Sleep_Behavior_Disorder(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
                return f_;
            });


    private Cached<IEnumerable<object>> _Benzodiazepine_Withdrawal_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Benzodiazepine Withdrawal Diagnosis")]
    public IEnumerable<object> Benzodiazepine_Withdrawal_Diagnosis(CqlContext context) =>
        _Benzodiazepine_Withdrawal_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Benzodiazepine_Withdrawal(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
                return f_;
            });


    private Cached<IEnumerable<object>> _Alcohol_Withdrawal_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Alcohol Withdrawal Diagnosis")]
    public IEnumerable<object> Alcohol_Withdrawal_Diagnosis(CqlContext context) =>
        _Alcohol_Withdrawal_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Alcohol_Withdrawal(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
                return f_;
            });


    private Cached<IEnumerable<object>> _Generalized_Anxiety_Disorder_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Generalized Anxiety Disorder Diagnosis")]
    public IEnumerable<object> Generalized_Anxiety_Disorder_Diagnosis(CqlContext context) =>
        _Generalized_Anxiety_Disorder_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Generalized_Anxiety_Disorder(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);
                return f_;
            });


    private Cached<CqlDateTime> _Benzodiazepine_Index_Prescription_Start_Date_Cached = new();

    [CqlExpressionDefinition("Benzodiazepine Index Prescription Start Date")]
    public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date(CqlContext context) =>
        _Benzodiazepine_Index_Prescription_Start_Date_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                    IEnumerable<Medication> o_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? p_(Medication M) {
                        object t_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object u_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> v_ = context.Operators.Split((string)u_, "/");
                        string w_ = context.Operators.Last<string>(v_);
                        bool? x_ = context.Operators.Equal(t_, w_);
                        CodeableConcept y_ = M?.Code;
                        CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                        CqlValueSet aa_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
                        bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                        bool? ac_ = context.Operators.And(x_, ab_);
                        return ac_;
                    }

                    IEnumerable<Medication> q_ = context.Operators.Where<Medication>(o_, p_);
                    MedicationRequest r_(Medication M) => MR;
                    IEnumerable<MedicationRequest> s_ = context.Operators.Select<Medication, MedicationRequest>(q_, r_);
                    return s_;
                }

                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

                bool? h_(MedicationRequest BenzodiazepineMedication) {
                    FhirDateTime ad_ = BenzodiazepineMedication?.AuthoredOnElement;
                    CqlDateTime ae_ = context.Operators.Convert<CqlDateTime>(ad_);
                    CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
                    bool? ag_ = context.Operators.In<CqlDateTime>(ae_, af_, default);
                    return ag_;
                }

                IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);

                CqlDateTime j_(MedicationRequest BenzodiazepineMedication) {
                    FhirDateTime ah_ = BenzodiazepineMedication?.AuthoredOnElement;
                    CqlDateTime ai_ = context.Operators.Convert<CqlDateTime>(ah_);
                    return ai_;
                }

                IEnumerable<CqlDateTime> k_ = context.Operators.Select<MedicationRequest, CqlDateTime>(i_, j_);
                IEnumerable<CqlDateTime> l_ = context.Operators.Distinct<CqlDateTime>(k_);
                IEnumerable<CqlDateTime> m_ = context.Operators.ListSort<CqlDateTime>(l_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime n_ = context.Operators.First<CqlDateTime>(m_);
                return n_;
            });


    private Cached<bool?> _Numerator_2_Cached = new();

    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        _Numerator_2_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.More_than_One_Antipsychotic_Order(context);
                IEnumerable<object> b_ = this.Schizophrenia_Diagnosis(context);
                IEnumerable<object> c_ = this.Bipolar_Disorder_Diagnosis(context);
                IEnumerable<object> d_ = context.Operators.Union<object>(b_, c_);

                bool? e_(object AntipsychoticTreatedDiagnoses) {
                    CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
                    CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlQuantity ac_ = context.Operators.Quantity(1m, "year");
                    CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
                    CqlDateTime ae_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
                    CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ad_, ae_, true, true);
                    bool? ag_ = context.Operators.Overlaps(z_, af_, default);
                    return ag_;
                }

                IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
                bool? g_ = context.Operators.Exists<object>(f_);
                bool? h_ = context.Operators.Not(g_);
                bool? i_ = context.Operators.And(a_, h_);
                bool? j_ = this.More_than_One_Benzodiazepine_Order(context);
                IEnumerable<object> k_ = this.Seizure_Disorder_Diagnosis(context);
                IEnumerable<object> l_ = this.REM_Sleep_Behavior_Disorder_Diagnosis(context);
                IEnumerable<object> m_ = context.Operators.Union<object>(k_, l_);
                IEnumerable<object> n_ = this.Benzodiazepine_Withdrawal_Diagnosis(context);
                IEnumerable<object> o_ = this.Alcohol_Withdrawal_Diagnosis(context);
                IEnumerable<object> p_ = context.Operators.Union<object>(n_, o_);
                IEnumerable<object> q_ = context.Operators.Union<object>(m_, p_);
                IEnumerable<object> r_ = this.Generalized_Anxiety_Disorder_Diagnosis(context);
                IEnumerable<object> s_ = context.Operators.Union<object>(q_, r_);

                bool? t_(object BenzodiazepineTreatedDiagnoses) {
                    CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
                    CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
                    CqlDateTime al_ = context.Operators.Subtract(aj_, ak_);
                    CqlDateTime am_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
                    CqlInterval<CqlDateTime> an_ = context.Operators.Interval(al_, am_, true, true);
                    bool? ao_ = context.Operators.Overlaps(ah_, an_, default);
                    return ao_;
                }

                IEnumerable<object> u_ = context.Operators.Where<object>(s_, t_);
                bool? v_ = context.Operators.Exists<object>(u_);
                bool? w_ = context.Operators.Not(v_);
                bool? x_ = context.Operators.And(j_, w_);
                bool? y_ = context.Operators.Or(i_, x_);
                return y_;
            });


    private Cached<bool?> _Numerator_3_Cached = new();

    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context) =>
        _Numerator_3_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Numerator_2(context);
                bool? b_ = this.Numerator_1(context);
                bool? d_ = context.Operators.Not(a_);
                bool? e_ = context.Operators.And(b_, d_);
                bool? f_ = context.Operators.Or(a_, e_);
                return f_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    #endregion Functions and Expressions

}
