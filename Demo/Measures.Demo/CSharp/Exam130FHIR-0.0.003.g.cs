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
[CqlLibrary("Exam130FHIR", "0.0.003")]
public partial class Exam130FHIR_0_0_003 : ILibrary, ISingleton<Exam130FHIR_0_0_003>
{
    private Exam130FHIR_0_0_003() {}

    public static Exam130FHIR_0_0_003 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Exam130FHIR";
    public string Version => "0.0.003";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, HospiceFHIR4_2_3_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, PalliativeCareFHIR_0_6_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Acute Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext _) => _Acute_Inpatient;
    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlValueSetDefinition("Advanced Illness", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext _) => _Advanced_Illness;
    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Colonoscopy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", valueSetVersion: null)]
    public CqlValueSet Colonoscopy(CqlContext _) => _Colonoscopy;
    private static readonly CqlValueSet _Colonoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

    [CqlValueSetDefinition("CT Colonography", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", valueSetVersion: null)]
    public CqlValueSet CT_Colonography(CqlContext _) => _CT_Colonography;
    private static readonly CqlValueSet _CT_Colonography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

    [CqlValueSetDefinition("Dementia Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext _) => _Dementia_Medications;
    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Fecal Occult Blood Test (FOBT)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", valueSetVersion: null)]
    public CqlValueSet Fecal_Occult_Blood_Test__FOBT_(CqlContext _) => _Fecal_Occult_Blood_Test__FOBT_;
    private static readonly CqlValueSet _Fecal_Occult_Blood_Test__FOBT_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

    [CqlValueSetDefinition("FIT DNA", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", valueSetVersion: null)]
    public CqlValueSet FIT_DNA(CqlContext _) => _FIT_DNA;
    private static readonly CqlValueSet _FIT_DNA = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

    [CqlValueSetDefinition("Flexible Sigmoidoscopy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", valueSetVersion: null)]
    public CqlValueSet Flexible_Sigmoidoscopy(CqlContext _) => _Flexible_Sigmoidoscopy;
    private static readonly CqlValueSet _Flexible_Sigmoidoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

    [CqlValueSetDefinition("Frailty Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext _) => _Frailty_Device;
    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlValueSetDefinition("Frailty Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext _) => _Frailty_Diagnosis;
    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlValueSetDefinition("Frailty Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext _) => _Frailty_Encounter;
    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlValueSetDefinition("Frailty Symptom", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext _) => _Frailty_Symptom;
    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Hospice care ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext _) => _Hospice_care_ambulatory;
    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlValueSetDefinition("Malignant Neoplasm of Colon", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasm_of_Colon(CqlContext _) => _Malignant_Neoplasm_of_Colon;
    private static readonly CqlValueSet _Malignant_Neoplasm_of_Colon = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

    [CqlValueSetDefinition("Nonacute Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient(CqlContext _) => _Nonacute_Inpatient;
    private static readonly CqlValueSet _Nonacute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Observation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", valueSetVersion: null)]
    public CqlValueSet Observation(CqlContext _) => _Observation;
    private static readonly CqlValueSet _Observation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Outpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", valueSetVersion: null)]
    public CqlValueSet Outpatient(CqlContext _) => _Outpatient;
    private static readonly CqlValueSet _Outpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Total Colectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", valueSetVersion: null)]
    public CqlValueSet Total_Colectomy(CqlContext _) => _Total_Colectomy;
    private static readonly CqlValueSet _Total_Colectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

    [CqlValueSetDefinition("Total Colectomy ICD9", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", valueSetVersion: null)]
    public CqlValueSet Total_Colectomy_ICD9(CqlContext _) => _Total_Colectomy_ICD9;
    private static readonly CqlValueSet _Total_Colectomy_ICD9 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("laboratory", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext _) => _laboratory;
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime jzzzp_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime jzzzq_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> jzzzr_ = context.Operators.Interval(jzzzp_, jzzzq_, true, false);
        object jzzzs_ = context.ResolveParameter("Exam130FHIR-0.0.003", "Measurement Period", jzzzr_);

        return (CqlInterval<CqlDateTime>)jzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient jzzzu_ = context.Operators.SingletonFrom<Patient>(jzzzt_);

        return jzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> jzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return jzzzv_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> jzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return jzzzw_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> jzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return jzzzx_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return jzzzy_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet jzzzz_ = this.Online_Assessments(context);
        IEnumerable<Encounter> kzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet kzzzb_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> kzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> kzzzd_ = context.Operators.Union<Encounter>(kzzza_, kzzzc_);
        bool? kzzze_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> kzzzg_ = TelehealthEncounter?.StatusElement;
            string kzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzg_);
            bool? kzzzi_ = context.Operators.Equal(kzzzh_, "finished");
            CqlInterval<CqlDateTime> kzzzj_ = this.Measurement_Period(context);
            Period kzzzk_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzk_ as object);
            bool? kzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzj_, kzzzl_, default);
            bool? kzzzn_ = context.Operators.And(kzzzi_, kzzzm_);

            return kzzzn_;
        };
        IEnumerable<Encounter> kzzzf_ = context.Operators.Where<Encounter>(kzzzd_, kzzze_);

        return kzzzf_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient kzzzo_ = this.Patient(context);
        Date kzzzp_ = kzzzo_?.BirthDateElement;
        string kzzzq_ = kzzzp_?.Value;
        CqlDate kzzzr_ = context.Operators.ConvertStringToDate(kzzzq_);
        CqlInterval<CqlDateTime> kzzzs_ = this.Measurement_Period(context);
        CqlDateTime kzzzt_ = context.Operators.Start(kzzzs_);
        CqlDate kzzzu_ = context.Operators.DateFrom(kzzzt_);
        int? kzzzv_ = context.Operators.CalculateAgeAt(kzzzr_, kzzzu_, "year");

        return kzzzv_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient kzzzw_ = this.Patient(context);
        Date kzzzx_ = kzzzw_?.BirthDateElement;
        string kzzzy_ = kzzzx_?.Value;
        CqlDate kzzzz_ = context.Operators.ConvertStringToDate(kzzzy_);
        CqlInterval<CqlDateTime> lzzza_ = this.Measurement_Period(context);
        CqlDateTime lzzzb_ = context.Operators.Start(lzzza_);
        CqlDate lzzzc_ = context.Operators.DateFrom(lzzzb_);
        int? lzzzd_ = context.Operators.CalculateAgeAt(kzzzz_, lzzzc_, "year");
        CqlInterval<int?> lzzze_ = context.Operators.Interval(51, 75, true, false);
        bool? lzzzf_ = context.Operators.In<int?>(lzzzd_, lzzze_, default);
        IEnumerable<Encounter> lzzzg_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> lzzzh_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> lzzzi_ = context.Operators.Union<Encounter>(lzzzg_, lzzzh_);
        bool? lzzzj_ = context.Operators.Exists<Encounter>(lzzzi_);
        bool? lzzzk_ = context.Operators.And(lzzzf_, lzzzj_);

        return lzzzk_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? lzzzl_ = this.Initial_Population(context);

        return lzzzl_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet lzzzm_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> lzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? lzzzo_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> lzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime lzzzr_ = context.Operators.Start(lzzzq_);
            CqlInterval<CqlDateTime> lzzzs_ = this.Measurement_Period(context);
            CqlDateTime lzzzt_ = context.Operators.End(lzzzs_);
            bool? lzzzu_ = context.Operators.SameOrBefore(lzzzr_, lzzzt_, default);

            return lzzzu_;
        };
        IEnumerable<Condition> lzzzp_ = context.Operators.Where<Condition>(lzzzn_, lzzzo_);

        return lzzzp_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet lzzzv_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> lzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? lzzzx_(Procedure Colectomy)
        {
            Code<EventStatus> lzzzz_ = Colectomy?.StatusElement;
            string mzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzz_);
            bool? mzzzb_ = context.Operators.Equal(mzzza_, "completed");
            DataType mzzzc_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> mzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzc_);
            CqlDateTime mzzze_ = context.Operators.End(mzzzd_);
            CqlInterval<CqlDateTime> mzzzf_ = this.Measurement_Period(context);
            CqlDateTime mzzzg_ = context.Operators.End(mzzzf_);
            bool? mzzzh_ = context.Operators.SameOrBefore(mzzze_, mzzzg_, default);
            bool? mzzzi_ = context.Operators.And(mzzzb_, mzzzh_);

            return mzzzi_;
        };
        IEnumerable<Procedure> lzzzy_ = context.Operators.Where<Procedure>(lzzzw_, lzzzx_);

        return lzzzy_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet mzzzj_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> mzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? mzzzl_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> mzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime mzzzo_ = context.Operators.Start(mzzzn_);
            CqlInterval<CqlDateTime> mzzzp_ = this.Measurement_Period(context);
            CqlDateTime mzzzq_ = context.Operators.End(mzzzp_);
            bool? mzzzr_ = context.Operators.SameOrBefore(mzzzo_, mzzzq_, default);

            return mzzzr_;
        };
        IEnumerable<Condition> mzzzm_ = context.Operators.Where<Condition>(mzzzk_, mzzzl_);

        return mzzzm_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? mzzzs_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> mzzzt_ = this.Malignant_Neoplasm(context);
        bool? mzzzu_ = context.Operators.Exists<Condition>(mzzzt_);
        bool? mzzzv_ = context.Operators.Or(mzzzs_, mzzzu_);
        IEnumerable<Procedure> mzzzw_ = this.Total_Colectomy_Performed(context);
        bool? mzzzx_ = context.Operators.Exists<Procedure>(mzzzw_);
        bool? mzzzy_ = context.Operators.Or(mzzzv_, mzzzx_);
        IEnumerable<Condition> mzzzz_ = this.Total_Colectomy_Condition(context);
        bool? nzzza_ = context.Operators.Exists<Condition>(mzzzz_);
        bool? nzzzb_ = context.Operators.Or(mzzzy_, nzzza_);
        bool? nzzzc_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? nzzzd_ = context.Operators.Or(nzzzb_, nzzzc_);
        Patient nzzze_ = this.Patient(context);
        Date nzzzf_ = nzzze_?.BirthDateElement;
        string nzzzg_ = nzzzf_?.Value;
        CqlDate nzzzh_ = context.Operators.ConvertStringToDate(nzzzg_);
        CqlInterval<CqlDateTime> nzzzi_ = this.Measurement_Period(context);
        CqlDateTime nzzzj_ = context.Operators.Start(nzzzi_);
        CqlDate nzzzk_ = context.Operators.DateFrom(nzzzj_);
        int? nzzzl_ = context.Operators.CalculateAgeAt(nzzzh_, nzzzk_, "year");
        bool? nzzzm_ = context.Operators.GreaterOrEqual(nzzzl_, 65);
        bool? nzzzn_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? nzzzo_ = context.Operators.And(nzzzm_, nzzzn_);
        bool? nzzzp_ = context.Operators.Or(nzzzd_, nzzzo_);
        bool? nzzzq_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? nzzzr_ = context.Operators.Or(nzzzp_, nzzzq_);

        return nzzzr_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet nzzzs_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> nzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? nzzzu_(Observation FecalOccult)
        {
            DataType nzzzz_ = FecalOccult?.Effective;
            CqlDateTime ozzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, nzzzz_);
            CqlInterval<CqlDateTime> ozzzb_ = this.Measurement_Period(context);
            CqlDateTime ozzzc_ = context.Operators.Start(ozzzb_);
            CqlQuantity ozzzd_ = context.Operators.Quantity(1m, "year");
            CqlDateTime ozzze_ = context.Operators.Subtract(ozzzc_, ozzzd_);
            CqlDateTime ozzzg_ = context.Operators.End(ozzzb_);
            CqlInterval<CqlDateTime> ozzzh_ = context.Operators.Interval(ozzze_, ozzzg_, false, false);
            bool? ozzzi_ = context.Operators.In<CqlDateTime>(ozzza_, ozzzh_, default);

            return ozzzi_;
        };
        IEnumerable<Observation> nzzzv_ = context.Operators.Where<Observation>(nzzzt_, nzzzu_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? nzzzw_(Observation FecalOccult)
        {
            DataType ozzzj_ = FecalOccult?.Effective;
            CqlDateTime ozzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ozzzj_);
            DataType ozzzl_ = FecalOccult?.Value;
            IEnumerable<Coding> ozzzm_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(ozzzl_, "coding");
            bool? ozzzn_(Coding @this)
            {
                FhirString pzzzh_ = @this?.DisplayElement;
                bool? pzzzi_ = context.Operators.Not((bool?)(pzzzh_ is null));

                return pzzzi_;
            };
            IEnumerable<Coding> ozzzo_ = context.Operators.Where<Coding>(ozzzm_, ozzzn_);
            FhirString ozzzp_(Coding @this)
            {
                FhirString pzzzj_ = @this?.DisplayElement;

                return pzzzj_;
            };
            IEnumerable<FhirString> ozzzq_ = context.Operators.Select<Coding, FhirString>(ozzzo_, ozzzp_);
            List<CodeableConcept> ozzzr_ = FecalOccult?.Category;
            bool? ozzzs_(CodeableConcept @this)
            {
                List<Coding> pzzzk_ = @this?.Coding;
                bool? pzzzl_ = context.Operators.Not((bool?)(pzzzk_ is null));

                return pzzzl_;
            };
            IEnumerable<CodeableConcept> ozzzt_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzr_, ozzzs_);
            List<Coding> ozzzu_(CodeableConcept @this)
            {
                List<Coding> pzzzm_ = @this?.Coding;

                return pzzzm_;
            };
            IEnumerable<List<Coding>> ozzzv_ = context.Operators.Select<CodeableConcept, List<Coding>>(ozzzt_, ozzzu_);
            IEnumerable<Coding> ozzzw_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ozzzv_);
            bool? ozzzx_(Coding @this)
            {
                Code pzzzn_ = @this?.CodeElement;
                bool? pzzzo_ = context.Operators.Not((bool?)(pzzzn_ is null));

                return pzzzo_;
            };
            IEnumerable<Coding> ozzzy_ = context.Operators.Where<Coding>(ozzzw_, ozzzx_);
            Code ozzzz_(Coding @this)
            {
                Code pzzzp_ = @this?.CodeElement;

                return pzzzp_;
            };
            IEnumerable<Code> pzzza_ = context.Operators.Select<Coding, Code>(ozzzy_, ozzzz_);
            bool? pzzzb_(Code @this)
            {
                string pzzzq_ = @this?.Value;
                bool? pzzzr_ = context.Operators.Not((bool?)(pzzzq_ is null));

                return pzzzr_;
            };
            IEnumerable<Code> pzzzc_ = context.Operators.Where<Code>(pzzza_, pzzzb_);
            string pzzzd_(Code @this)
            {
                string pzzzs_ = @this?.Value;

                return pzzzs_;
            };
            IEnumerable<string> pzzze_ = context.Operators.Select<Code, string>(pzzzc_, pzzzd_);
            Code<ObservationStatus> pzzzf_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? pzzzg_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, ozzzk_, ozzzq_, pzzze_, pzzzf_);

            return pzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> nzzzx_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(nzzzv_, nzzzw_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> nzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(nzzzx_);

        return nzzzy_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet pzzzt_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> pzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzv_(Observation FecalOccult)
        {
            Code<ObservationStatus> pzzzx_ = FecalOccult?.StatusElement;
            string pzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzx_);
            string[] pzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzza_ = context.Operators.In<string>(pzzzy_, pzzzz_ as IEnumerable<string>);
            List<CodeableConcept> qzzzb_ = FecalOccult?.Category;
            bool? qzzzc_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> qzzzo_ = FecalOccultCategory?.Coding;
                bool? qzzzp_(Coding @this)
                {
                    Code qzzzz_ = @this?.CodeElement;
                    bool? rzzza_ = context.Operators.Not((bool?)(qzzzz_ is null));

                    return rzzza_;
                };
                IEnumerable<Coding> qzzzq_ = context.Operators.Where<Coding>((IEnumerable<Coding>)qzzzo_, qzzzp_);
                Code qzzzr_(Coding @this)
                {
                    Code rzzzb_ = @this?.CodeElement;

                    return rzzzb_;
                };
                IEnumerable<Code> qzzzs_ = context.Operators.Select<Coding, Code>(qzzzq_, qzzzr_);
                bool? qzzzt_(Code @this)
                {
                    string rzzzc_ = @this?.Value;
                    bool? rzzzd_ = context.Operators.Not((bool?)(rzzzc_ is null));

                    return rzzzd_;
                };
                IEnumerable<Code> qzzzu_ = context.Operators.Where<Code>(qzzzs_, qzzzt_);
                string qzzzv_(Code @this)
                {
                    string rzzze_ = @this?.Value;

                    return rzzze_;
                };
                IEnumerable<string> qzzzw_ = context.Operators.Select<Code, string>(qzzzu_, qzzzv_);
                string[] qzzzx_ = [
                    "laboratory",
                ];
                bool? qzzzy_ = context.Operators.Equivalent<string>(qzzzw_, qzzzx_ as IEnumerable<string>);

                return qzzzy_;
            };
            IEnumerable<CodeableConcept> qzzzd_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzb_, qzzzc_);
            bool? qzzze_ = context.Operators.Exists<CodeableConcept>(qzzzd_);
            bool? qzzzf_ = context.Operators.And(qzzza_, qzzze_);
            DataType qzzzg_ = FecalOccult?.Value;
            bool? qzzzh_ = context.Operators.Not((bool?)(qzzzg_ is null));
            bool? qzzzi_ = context.Operators.And(qzzzf_, qzzzh_);
            DataType qzzzj_ = FecalOccult?.Effective;
            CqlDateTime qzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, qzzzj_);
            CqlInterval<CqlDateTime> qzzzl_ = this.Measurement_Period(context);
            bool? qzzzm_ = context.Operators.In<CqlDateTime>(qzzzk_, qzzzl_, default);
            bool? qzzzn_ = context.Operators.And(qzzzi_, qzzzm_);

            return qzzzn_;
        };
        IEnumerable<Observation> pzzzw_ = context.Operators.Where<Observation>(pzzzu_, pzzzv_);

        return pzzzw_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet rzzzf_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> rzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzh_(Observation FecalOccult)
        {
            Code<ObservationStatus> rzzzj_ = FecalOccult?.StatusElement;
            string rzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzj_);
            string[] rzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzm_ = context.Operators.In<string>(rzzzk_, rzzzl_ as IEnumerable<string>);
            List<CodeableConcept> rzzzn_ = FecalOccult?.Category;
            bool? rzzzo_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> szzza_ = FecalOccultCategory?.Coding;
                bool? szzzb_(Coding @this)
                {
                    Code szzzl_ = @this?.CodeElement;
                    bool? szzzm_ = context.Operators.Not((bool?)(szzzl_ is null));

                    return szzzm_;
                };
                IEnumerable<Coding> szzzc_ = context.Operators.Where<Coding>((IEnumerable<Coding>)szzza_, szzzb_);
                Code szzzd_(Coding @this)
                {
                    Code szzzn_ = @this?.CodeElement;

                    return szzzn_;
                };
                IEnumerable<Code> szzze_ = context.Operators.Select<Coding, Code>(szzzc_, szzzd_);
                bool? szzzf_(Code @this)
                {
                    string szzzo_ = @this?.Value;
                    bool? szzzp_ = context.Operators.Not((bool?)(szzzo_ is null));

                    return szzzp_;
                };
                IEnumerable<Code> szzzg_ = context.Operators.Where<Code>(szzze_, szzzf_);
                string szzzh_(Code @this)
                {
                    string szzzq_ = @this?.Value;

                    return szzzq_;
                };
                IEnumerable<string> szzzi_ = context.Operators.Select<Code, string>(szzzg_, szzzh_);
                string[] szzzj_ = [
                    "laboratory",
                ];
                bool? szzzk_ = context.Operators.Equivalent<string>(szzzi_, szzzj_ as IEnumerable<string>);

                return szzzk_;
            };
            IEnumerable<CodeableConcept> rzzzp_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzn_, rzzzo_);
            bool? rzzzq_ = context.Operators.Exists<CodeableConcept>(rzzzp_);
            bool? rzzzr_ = context.Operators.And(rzzzm_, rzzzq_);
            DataType rzzzs_ = FecalOccult?.Value;
            bool? rzzzt_ = context.Operators.Not((bool?)(rzzzs_ is null));
            bool? rzzzu_ = context.Operators.And(rzzzr_, rzzzt_);
            DataType rzzzv_ = FecalOccult?.Effective;
            CqlDateTime rzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, rzzzv_);
            CqlInterval<CqlDateTime> rzzzx_ = this.Measurement_Period(context);
            bool? rzzzy_ = context.Operators.In<CqlDateTime>(rzzzw_, rzzzx_, "day");
            bool? rzzzz_ = context.Operators.And(rzzzu_, rzzzy_);

            return rzzzz_;
        };
        IEnumerable<Observation> rzzzi_ = context.Operators.Where<Observation>(rzzzg_, rzzzh_);

        return rzzzi_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet szzzr_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> szzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzt_(Observation FecalOccult)
        {
            List<CodeableConcept> szzzv_ = FecalOccult?.Category;
            bool? szzzw_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> tzzzh_ = FecalOccultCategory?.Coding;
                bool? tzzzi_(Coding @this)
                {
                    Code tzzzt_ = @this?.CodeElement;
                    bool? tzzzu_ = context.Operators.Not((bool?)(tzzzt_ is null));

                    return tzzzu_;
                };
                IEnumerable<Coding> tzzzj_ = context.Operators.Where<Coding>((IEnumerable<Coding>)tzzzh_, tzzzi_);
                Code tzzzk_(Coding @this)
                {
                    Code tzzzv_ = @this?.CodeElement;

                    return tzzzv_;
                };
                IEnumerable<Code> tzzzl_ = context.Operators.Select<Coding, Code>(tzzzj_, tzzzk_);
                bool? tzzzm_(Code @this)
                {
                    string tzzzw_ = @this?.Value;
                    bool? tzzzx_ = context.Operators.Not((bool?)(tzzzw_ is null));

                    return tzzzx_;
                };
                IEnumerable<Code> tzzzn_ = context.Operators.Where<Code>(tzzzl_, tzzzm_);
                string tzzzo_(Code @this)
                {
                    string tzzzy_ = @this?.Value;

                    return tzzzy_;
                };
                IEnumerable<string> tzzzp_ = context.Operators.Select<Code, string>(tzzzn_, tzzzo_);
                string[] tzzzq_ = [
                    "laboratory",
                ];
                bool? tzzzr_ = context.Operators.Equivalent<string>(tzzzp_, tzzzq_ as IEnumerable<string>);
                bool? tzzzs_ = context.Operators.Not(tzzzr_);

                return tzzzs_;
            };
            IEnumerable<CodeableConcept> szzzx_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)szzzv_, szzzw_);
            bool? szzzy_ = context.Operators.Exists<CodeableConcept>(szzzx_);
            DataType szzzz_ = FecalOccult?.Value;
            bool? tzzza_ = context.Operators.Not((bool?)(szzzz_ is null));
            bool? tzzzb_ = context.Operators.And(szzzy_, tzzza_);
            DataType tzzzc_ = FecalOccult?.Effective;
            CqlDateTime tzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, tzzzc_);
            CqlInterval<CqlDateTime> tzzze_ = this.Measurement_Period(context);
            bool? tzzzf_ = context.Operators.In<CqlDateTime>(tzzzd_, tzzze_, "day");
            bool? tzzzg_ = context.Operators.And(tzzzb_, tzzzf_);

            return tzzzg_;
        };
        IEnumerable<Observation> szzzu_ = context.Operators.Where<Observation>(szzzs_, szzzt_);

        return szzzu_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet tzzzz_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> uzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? uzzzb_(Observation FecalOccult)
        {
            Code<ObservationStatus> uzzzd_ = FecalOccult?.StatusElement;
            string uzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzd_);
            string[] uzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzg_ = context.Operators.In<string>(uzzze_, uzzzf_ as IEnumerable<string>);
            bool? uzzzh_ = context.Operators.Not(uzzzg_);
            DataType uzzzi_ = FecalOccult?.Value;
            bool? uzzzj_ = context.Operators.Not((bool?)(uzzzi_ is null));
            bool? uzzzk_ = context.Operators.And(uzzzh_, uzzzj_);
            DataType uzzzl_ = FecalOccult?.Effective;
            CqlDateTime uzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzl_);
            CqlInterval<CqlDateTime> uzzzn_ = this.Measurement_Period(context);
            bool? uzzzo_ = context.Operators.In<CqlDateTime>(uzzzm_, uzzzn_, "day");
            bool? uzzzp_ = context.Operators.And(uzzzk_, uzzzo_);

            return uzzzp_;
        };
        IEnumerable<Observation> uzzzc_ = context.Operators.Where<Observation>(uzzza_, uzzzb_);

        return uzzzc_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet uzzzq_ = this.FIT_DNA(context);
        IEnumerable<Observation> uzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? uzzzs_(Observation FitDNA)
        {
            DataType uzzzx_ = FitDNA?.Effective;
            CqlDateTime uzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzx_);
            CqlInterval<CqlDateTime> uzzzz_ = this.Measurement_Period(context);
            CqlDateTime vzzza_ = context.Operators.End(uzzzz_);
            CqlQuantity vzzzb_ = context.Operators.Quantity(4m, "years");
            CqlDateTime vzzzc_ = context.Operators.Subtract(vzzza_, vzzzb_);
            CqlDateTime vzzze_ = context.Operators.End(uzzzz_);
            CqlInterval<CqlDateTime> vzzzf_ = context.Operators.Interval(vzzzc_, vzzze_, true, true);
            bool? vzzzg_ = context.Operators.In<CqlDateTime>(uzzzy_, vzzzf_, default);
            CqlDateTime vzzzi_ = context.Operators.End(uzzzz_);
            bool? vzzzj_ = context.Operators.Not((bool?)(vzzzi_ is null));
            bool? vzzzk_ = context.Operators.And(vzzzg_, vzzzj_);

            return vzzzk_;
        };
        IEnumerable<Observation> uzzzt_ = context.Operators.Where<Observation>(uzzzr_, uzzzs_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? uzzzu_(Observation FitDNA)
        {
            DataType vzzzl_ = FitDNA?.Effective;
            CqlDateTime vzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzl_);
            DataType vzzzn_ = FitDNA?.Value;
            IEnumerable<Coding> vzzzo_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(vzzzn_, "coding");
            bool? vzzzp_(Coding @this)
            {
                FhirString wzzzj_ = @this?.DisplayElement;
                bool? wzzzk_ = context.Operators.Not((bool?)(wzzzj_ is null));

                return wzzzk_;
            };
            IEnumerable<Coding> vzzzq_ = context.Operators.Where<Coding>(vzzzo_, vzzzp_);
            FhirString vzzzr_(Coding @this)
            {
                FhirString wzzzl_ = @this?.DisplayElement;

                return wzzzl_;
            };
            IEnumerable<FhirString> vzzzs_ = context.Operators.Select<Coding, FhirString>(vzzzq_, vzzzr_);
            List<CodeableConcept> vzzzt_ = FitDNA?.Category;
            bool? vzzzu_(CodeableConcept @this)
            {
                List<Coding> wzzzm_ = @this?.Coding;
                bool? wzzzn_ = context.Operators.Not((bool?)(wzzzm_ is null));

                return wzzzn_;
            };
            IEnumerable<CodeableConcept> vzzzv_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzt_, vzzzu_);
            List<Coding> vzzzw_(CodeableConcept @this)
            {
                List<Coding> wzzzo_ = @this?.Coding;

                return wzzzo_;
            };
            IEnumerable<List<Coding>> vzzzx_ = context.Operators.Select<CodeableConcept, List<Coding>>(vzzzv_, vzzzw_);
            IEnumerable<Coding> vzzzy_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)vzzzx_);
            bool? vzzzz_(Coding @this)
            {
                Code wzzzp_ = @this?.CodeElement;
                bool? wzzzq_ = context.Operators.Not((bool?)(wzzzp_ is null));

                return wzzzq_;
            };
            IEnumerable<Coding> wzzza_ = context.Operators.Where<Coding>(vzzzy_, vzzzz_);
            Code wzzzb_(Coding @this)
            {
                Code wzzzr_ = @this?.CodeElement;

                return wzzzr_;
            };
            IEnumerable<Code> wzzzc_ = context.Operators.Select<Coding, Code>(wzzza_, wzzzb_);
            bool? wzzzd_(Code @this)
            {
                string wzzzs_ = @this?.Value;
                bool? wzzzt_ = context.Operators.Not((bool?)(wzzzs_ is null));

                return wzzzt_;
            };
            IEnumerable<Code> wzzze_ = context.Operators.Where<Code>(wzzzc_, wzzzd_);
            string wzzzf_(Code @this)
            {
                string wzzzu_ = @this?.Value;

                return wzzzu_;
            };
            IEnumerable<string> wzzzg_ = context.Operators.Select<Code, string>(wzzze_, wzzzf_);
            Code<ObservationStatus> wzzzh_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? wzzzi_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, vzzzm_, vzzzs_, wzzzg_, wzzzh_);

            return wzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> uzzzv_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(uzzzt_, uzzzu_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> uzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(uzzzv_);

        return uzzzw_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet wzzzv_ = this.FIT_DNA(context);
        IEnumerable<Observation> wzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? wzzzx_(Observation FitDNA)
        {
            Code<ObservationStatus> wzzzz_ = FitDNA?.StatusElement;
            string xzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzz_);
            string[] xzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xzzzc_ = context.Operators.In<string>(xzzza_, xzzzb_ as IEnumerable<string>);
            List<CodeableConcept> xzzzd_ = FitDNA?.Category;
            bool? xzzze_(CodeableConcept FitDNACategory)
            {
                List<Coding> yzzza_ = FitDNACategory?.Coding;
                bool? yzzzb_(Coding @this)
                {
                    Code yzzzl_ = @this?.CodeElement;
                    bool? yzzzm_ = context.Operators.Not((bool?)(yzzzl_ is null));

                    return yzzzm_;
                };
                IEnumerable<Coding> yzzzc_ = context.Operators.Where<Coding>((IEnumerable<Coding>)yzzza_, yzzzb_);
                Code yzzzd_(Coding @this)
                {
                    Code yzzzn_ = @this?.CodeElement;

                    return yzzzn_;
                };
                IEnumerable<Code> yzzze_ = context.Operators.Select<Coding, Code>(yzzzc_, yzzzd_);
                bool? yzzzf_(Code @this)
                {
                    string yzzzo_ = @this?.Value;
                    bool? yzzzp_ = context.Operators.Not((bool?)(yzzzo_ is null));

                    return yzzzp_;
                };
                IEnumerable<Code> yzzzg_ = context.Operators.Where<Code>(yzzze_, yzzzf_);
                string yzzzh_(Code @this)
                {
                    string yzzzq_ = @this?.Value;

                    return yzzzq_;
                };
                IEnumerable<string> yzzzi_ = context.Operators.Select<Code, string>(yzzzg_, yzzzh_);
                string[] yzzzj_ = [
                    "laboratory",
                ];
                bool? yzzzk_ = context.Operators.Equivalent<string>(yzzzi_, yzzzj_ as IEnumerable<string>);

                return yzzzk_;
            };
            IEnumerable<CodeableConcept> xzzzf_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzd_, xzzze_);
            bool? xzzzg_ = context.Operators.Exists<CodeableConcept>(xzzzf_);
            bool? xzzzh_ = context.Operators.And(xzzzc_, xzzzg_);
            DataType xzzzi_ = FitDNA?.Value;
            bool? xzzzj_ = context.Operators.Not((bool?)(xzzzi_ is null));
            bool? xzzzk_ = context.Operators.And(xzzzh_, xzzzj_);
            DataType xzzzl_ = FitDNA?.Effective;
            CqlDateTime xzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, xzzzl_);
            CqlInterval<CqlDateTime> xzzzn_ = this.Measurement_Period(context);
            CqlDateTime xzzzo_ = context.Operators.End(xzzzn_);
            CqlQuantity xzzzp_ = context.Operators.Quantity(3m, "years");
            CqlDateTime xzzzq_ = context.Operators.Subtract(xzzzo_, xzzzp_);
            CqlDateTime xzzzs_ = context.Operators.End(xzzzn_);
            CqlInterval<CqlDateTime> xzzzt_ = context.Operators.Interval(xzzzq_, xzzzs_, true, true);
            bool? xzzzu_ = context.Operators.In<CqlDateTime>(xzzzm_, xzzzt_, default);
            CqlDateTime xzzzw_ = context.Operators.End(xzzzn_);
            bool? xzzzx_ = context.Operators.Not((bool?)(xzzzw_ is null));
            bool? xzzzy_ = context.Operators.And(xzzzu_, xzzzx_);
            bool? xzzzz_ = context.Operators.And(xzzzk_, xzzzy_);

            return xzzzz_;
        };
        IEnumerable<Observation> wzzzy_ = context.Operators.Where<Observation>(wzzzw_, wzzzx_);

        return wzzzy_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet yzzzr_ = this.FIT_DNA(context);
        IEnumerable<Observation> yzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzt_(Observation FitDNA)
        {
            Code<ObservationStatus> yzzzv_ = FitDNA?.StatusElement;
            string yzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzv_);
            string[] yzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzzy_ = context.Operators.In<string>(yzzzw_, yzzzx_ as IEnumerable<string>);
            List<CodeableConcept> yzzzz_ = FitDNA?.Category;
            bool? zzzza_(CodeableConcept FitDNACategory)
            {
                List<Coding> zzzzw_ = FitDNACategory?.Coding;
                bool? zzzzx_(Coding @this)
                {
                    Code azzzzh_ = @this?.CodeElement;
                    bool? azzzzi_ = context.Operators.Not((bool?)(azzzzh_ is null));

                    return azzzzi_;
                };
                IEnumerable<Coding> zzzzy_ = context.Operators.Where<Coding>((IEnumerable<Coding>)zzzzw_, zzzzx_);
                Code zzzzz_(Coding @this)
                {
                    Code azzzzj_ = @this?.CodeElement;

                    return azzzzj_;
                };
                IEnumerable<Code> azzzza_ = context.Operators.Select<Coding, Code>(zzzzy_, zzzzz_);
                bool? azzzzb_(Code @this)
                {
                    string azzzzk_ = @this?.Value;
                    bool? azzzzl_ = context.Operators.Not((bool?)(azzzzk_ is null));

                    return azzzzl_;
                };
                IEnumerable<Code> azzzzc_ = context.Operators.Where<Code>(azzzza_, azzzzb_);
                string azzzzd_(Code @this)
                {
                    string azzzzm_ = @this?.Value;

                    return azzzzm_;
                };
                IEnumerable<string> azzzze_ = context.Operators.Select<Code, string>(azzzzc_, azzzzd_);
                string[] azzzzf_ = [
                    "laboratory",
                ];
                bool? azzzzg_ = context.Operators.Equivalent<string>(azzzze_, azzzzf_ as IEnumerable<string>);

                return azzzzg_;
            };
            IEnumerable<CodeableConcept> zzzzb_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzz_, zzzza_);
            bool? zzzzc_ = context.Operators.Exists<CodeableConcept>(zzzzb_);
            bool? zzzzd_ = context.Operators.And(yzzzy_, zzzzc_);
            DataType zzzze_ = FitDNA?.Value;
            bool? zzzzf_ = context.Operators.Not((bool?)(zzzze_ is null));
            bool? zzzzg_ = context.Operators.And(zzzzd_, zzzzf_);
            DataType zzzzh_ = FitDNA?.Effective;
            CqlDateTime zzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, zzzzh_);
            CqlInterval<CqlDateTime> zzzzj_ = this.Measurement_Period(context);
            CqlDateTime zzzzk_ = context.Operators.End(zzzzj_);
            CqlQuantity zzzzl_ = context.Operators.Quantity(3m, "years");
            CqlDateTime zzzzm_ = context.Operators.Subtract(zzzzk_, zzzzl_);
            CqlDateTime zzzzo_ = context.Operators.End(zzzzj_);
            CqlInterval<CqlDateTime> zzzzp_ = context.Operators.Interval(zzzzm_, zzzzo_, true, true);
            bool? zzzzq_ = context.Operators.In<CqlDateTime>(zzzzi_, zzzzp_, "day");
            CqlDateTime zzzzs_ = context.Operators.End(zzzzj_);
            bool? zzzzt_ = context.Operators.Not((bool?)(zzzzs_ is null));
            bool? zzzzu_ = context.Operators.And(zzzzq_, zzzzt_);
            bool? zzzzv_ = context.Operators.And(zzzzg_, zzzzu_);

            return zzzzv_;
        };
        IEnumerable<Observation> yzzzu_ = context.Operators.Where<Observation>(yzzzs_, yzzzt_);

        return yzzzu_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet azzzzn_ = this.FIT_DNA(context);
        IEnumerable<Observation> azzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? azzzzp_(Observation FitDNA)
        {
            List<CodeableConcept> azzzzr_ = FitDNA?.Category;
            bool? azzzzs_(CodeableConcept FitDNACategory)
            {
                List<Coding> bzzzzn_ = FitDNACategory?.Coding;
                bool? bzzzzo_(Coding @this)
                {
                    Code bzzzzz_ = @this?.CodeElement;
                    bool? czzzza_ = context.Operators.Not((bool?)(bzzzzz_ is null));

                    return czzzza_;
                };
                IEnumerable<Coding> bzzzzp_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bzzzzn_, bzzzzo_);
                Code bzzzzq_(Coding @this)
                {
                    Code czzzzb_ = @this?.CodeElement;

                    return czzzzb_;
                };
                IEnumerable<Code> bzzzzr_ = context.Operators.Select<Coding, Code>(bzzzzp_, bzzzzq_);
                bool? bzzzzs_(Code @this)
                {
                    string czzzzc_ = @this?.Value;
                    bool? czzzzd_ = context.Operators.Not((bool?)(czzzzc_ is null));

                    return czzzzd_;
                };
                IEnumerable<Code> bzzzzt_ = context.Operators.Where<Code>(bzzzzr_, bzzzzs_);
                string bzzzzu_(Code @this)
                {
                    string czzzze_ = @this?.Value;

                    return czzzze_;
                };
                IEnumerable<string> bzzzzv_ = context.Operators.Select<Code, string>(bzzzzt_, bzzzzu_);
                string[] bzzzzw_ = [
                    "laboratory",
                ];
                bool? bzzzzx_ = context.Operators.Equivalent<string>(bzzzzv_, bzzzzw_ as IEnumerable<string>);
                bool? bzzzzy_ = context.Operators.Not(bzzzzx_);

                return bzzzzy_;
            };
            IEnumerable<CodeableConcept> azzzzt_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzr_, azzzzs_);
            bool? azzzzu_ = context.Operators.Exists<CodeableConcept>(azzzzt_);
            DataType azzzzv_ = FitDNA?.Value;
            bool? azzzzw_ = context.Operators.Not((bool?)(azzzzv_ is null));
            bool? azzzzx_ = context.Operators.And(azzzzu_, azzzzw_);
            DataType azzzzy_ = FitDNA?.Effective;
            CqlDateTime azzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, azzzzy_);
            CqlInterval<CqlDateTime> bzzzza_ = this.Measurement_Period(context);
            CqlDateTime bzzzzb_ = context.Operators.End(bzzzza_);
            CqlQuantity bzzzzc_ = context.Operators.Quantity(3m, "years");
            CqlDateTime bzzzzd_ = context.Operators.Subtract(bzzzzb_, bzzzzc_);
            CqlDateTime bzzzzf_ = context.Operators.End(bzzzza_);
            CqlInterval<CqlDateTime> bzzzzg_ = context.Operators.Interval(bzzzzd_, bzzzzf_, true, true);
            bool? bzzzzh_ = context.Operators.In<CqlDateTime>(azzzzz_, bzzzzg_, "day");
            CqlDateTime bzzzzj_ = context.Operators.End(bzzzza_);
            bool? bzzzzk_ = context.Operators.Not((bool?)(bzzzzj_ is null));
            bool? bzzzzl_ = context.Operators.And(bzzzzh_, bzzzzk_);
            bool? bzzzzm_ = context.Operators.And(azzzzx_, bzzzzl_);

            return bzzzzm_;
        };
        IEnumerable<Observation> azzzzq_ = context.Operators.Where<Observation>(azzzzo_, azzzzp_);

        return azzzzq_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet czzzzf_ = this.FIT_DNA(context);
        IEnumerable<Observation> czzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzzh_(Observation FitDNA)
        {
            Code<ObservationStatus> czzzzj_ = FitDNA?.StatusElement;
            string czzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzj_);
            string[] czzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzm_ = context.Operators.In<string>(czzzzk_, czzzzl_ as IEnumerable<string>);
            bool? czzzzn_ = context.Operators.Not(czzzzm_);
            DataType czzzzo_ = FitDNA?.Value;
            bool? czzzzp_ = context.Operators.Not((bool?)(czzzzo_ is null));
            bool? czzzzq_ = context.Operators.And(czzzzn_, czzzzp_);
            DataType czzzzr_ = FitDNA?.Effective;
            CqlDateTime czzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, czzzzr_);
            CqlInterval<CqlDateTime> czzzzt_ = this.Measurement_Period(context);
            CqlDateTime czzzzu_ = context.Operators.End(czzzzt_);
            CqlQuantity czzzzv_ = context.Operators.Quantity(3m, "years");
            CqlDateTime czzzzw_ = context.Operators.Subtract(czzzzu_, czzzzv_);
            CqlDateTime czzzzy_ = context.Operators.End(czzzzt_);
            CqlInterval<CqlDateTime> czzzzz_ = context.Operators.Interval(czzzzw_, czzzzy_, true, true);
            bool? dzzzza_ = context.Operators.In<CqlDateTime>(czzzzs_, czzzzz_, "day");
            CqlDateTime dzzzzc_ = context.Operators.End(czzzzt_);
            bool? dzzzzd_ = context.Operators.Not((bool?)(dzzzzc_ is null));
            bool? dzzzze_ = context.Operators.And(dzzzza_, dzzzzd_);
            bool? dzzzzf_ = context.Operators.And(czzzzq_, dzzzze_);

            return dzzzzf_;
        };
        IEnumerable<Observation> czzzzi_ = context.Operators.Where<Observation>(czzzzg_, czzzzh_);

        return czzzzi_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet dzzzzg_ = this.CT_Colonography(context);
        IEnumerable<Observation> dzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? dzzzzi_(Observation Colonography)
        {
            DataType dzzzzn_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> dzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzn_);
            CqlDateTime dzzzzp_ = context.Operators.End(dzzzzo_);
            CqlInterval<CqlDateTime> dzzzzq_ = this.Measurement_Period(context);
            CqlDateTime dzzzzr_ = context.Operators.End(dzzzzq_);
            CqlQuantity dzzzzs_ = context.Operators.Quantity(6m, "years");
            CqlDateTime dzzzzt_ = context.Operators.Subtract(dzzzzr_, dzzzzs_);
            CqlDateTime dzzzzv_ = context.Operators.End(dzzzzq_);
            CqlInterval<CqlDateTime> dzzzzw_ = context.Operators.Interval(dzzzzt_, dzzzzv_, true, true);
            bool? dzzzzx_ = context.Operators.In<CqlDateTime>(dzzzzp_, dzzzzw_, default);
            CqlDateTime dzzzzz_ = context.Operators.End(dzzzzq_);
            bool? ezzzza_ = context.Operators.Not((bool?)(dzzzzz_ is null));
            bool? ezzzzb_ = context.Operators.And(dzzzzx_, ezzzza_);

            return ezzzzb_;
        };
        IEnumerable<Observation> dzzzzj_ = context.Operators.Where<Observation>(dzzzzh_, dzzzzi_);
        CqlDateTime dzzzzk_(Observation Colonography)
        {
            DataType ezzzzc_ = Colonography?.Effective;
            CqlDateTime ezzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ezzzzc_);

            return ezzzzd_;
        };
        IEnumerable<CqlDateTime> dzzzzl_ = context.Operators.Select<Observation, CqlDateTime>(dzzzzj_, dzzzzk_);
        IEnumerable<CqlDateTime> dzzzzm_ = context.Operators.Distinct<CqlDateTime>(dzzzzl_);

        return dzzzzm_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet ezzzze_ = this.CT_Colonography(context);
        IEnumerable<Observation> ezzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzg_(Observation Colonography)
        {
            Code<ObservationStatus> ezzzzi_ = Colonography?.StatusElement;
            string ezzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzi_);
            string[] ezzzzk_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ezzzzl_ = context.Operators.In<string>(ezzzzj_, ezzzzk_ as IEnumerable<string>);
            DataType ezzzzm_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> ezzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzm_);
            CqlDateTime ezzzzo_ = context.Operators.End(ezzzzn_);
            CqlInterval<CqlDateTime> ezzzzp_ = this.Measurement_Period(context);
            CqlDateTime ezzzzq_ = context.Operators.End(ezzzzp_);
            CqlQuantity ezzzzr_ = context.Operators.Quantity(5m, "years");
            CqlDateTime ezzzzs_ = context.Operators.Subtract(ezzzzq_, ezzzzr_);
            CqlDateTime ezzzzu_ = context.Operators.End(ezzzzp_);
            CqlInterval<CqlDateTime> ezzzzv_ = context.Operators.Interval(ezzzzs_, ezzzzu_, true, true);
            bool? ezzzzw_ = context.Operators.In<CqlDateTime>(ezzzzo_, ezzzzv_, default);
            CqlDateTime ezzzzy_ = context.Operators.End(ezzzzp_);
            bool? ezzzzz_ = context.Operators.Not((bool?)(ezzzzy_ is null));
            bool? fzzzza_ = context.Operators.And(ezzzzw_, ezzzzz_);
            bool? fzzzzb_ = context.Operators.And(ezzzzl_, fzzzza_);

            return fzzzzb_;
        };
        IEnumerable<Observation> ezzzzh_ = context.Operators.Where<Observation>(ezzzzf_, ezzzzg_);

        return ezzzzh_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet fzzzzc_ = this.CT_Colonography(context);
        IEnumerable<Observation> fzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? fzzzze_(Observation Colonography)
        {
            Code<ObservationStatus> fzzzzg_ = Colonography?.StatusElement;
            string fzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzg_);
            string[] fzzzzi_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? fzzzzj_ = context.Operators.In<string>(fzzzzh_, fzzzzi_ as IEnumerable<string>);
            bool? fzzzzk_ = context.Operators.Not(fzzzzj_);
            DataType fzzzzl_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> fzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzl_);
            CqlDateTime fzzzzn_ = context.Operators.End(fzzzzm_);
            CqlInterval<CqlDateTime> fzzzzo_ = this.Measurement_Period(context);
            CqlDateTime fzzzzp_ = context.Operators.End(fzzzzo_);
            CqlQuantity fzzzzq_ = context.Operators.Quantity(5m, "years");
            CqlDateTime fzzzzr_ = context.Operators.Subtract(fzzzzp_, fzzzzq_);
            CqlDateTime fzzzzt_ = context.Operators.End(fzzzzo_);
            CqlInterval<CqlDateTime> fzzzzu_ = context.Operators.Interval(fzzzzr_, fzzzzt_, true, true);
            bool? fzzzzv_ = context.Operators.In<CqlDateTime>(fzzzzn_, fzzzzu_, default);
            CqlDateTime fzzzzx_ = context.Operators.End(fzzzzo_);
            bool? fzzzzy_ = context.Operators.Not((bool?)(fzzzzx_ is null));
            bool? fzzzzz_ = context.Operators.And(fzzzzv_, fzzzzy_);
            bool? gzzzza_ = context.Operators.And(fzzzzk_, fzzzzz_);

            return gzzzza_;
        };
        IEnumerable<Observation> fzzzzf_ = context.Operators.Where<Observation>(fzzzzd_, fzzzze_);

        return fzzzzf_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet gzzzzb_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> gzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? gzzzzd_(Procedure FlexibleSigmoidoscopy)
        {
            DataType gzzzzi_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> gzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzi_);
            CqlDateTime gzzzzk_ = context.Operators.End(gzzzzj_);
            CqlInterval<CqlDateTime> gzzzzl_ = this.Measurement_Period(context);
            CqlDateTime gzzzzm_ = context.Operators.End(gzzzzl_);
            CqlQuantity gzzzzn_ = context.Operators.Quantity(6m, "years");
            CqlDateTime gzzzzo_ = context.Operators.Subtract(gzzzzm_, gzzzzn_);
            CqlDateTime gzzzzq_ = context.Operators.End(gzzzzl_);
            CqlInterval<CqlDateTime> gzzzzr_ = context.Operators.Interval(gzzzzo_, gzzzzq_, true, true);
            bool? gzzzzs_ = context.Operators.In<CqlDateTime>(gzzzzk_, gzzzzr_, default);
            CqlDateTime gzzzzu_ = context.Operators.End(gzzzzl_);
            bool? gzzzzv_ = context.Operators.Not((bool?)(gzzzzu_ is null));
            bool? gzzzzw_ = context.Operators.And(gzzzzs_, gzzzzv_);

            return gzzzzw_;
        };
        IEnumerable<Procedure> gzzzze_ = context.Operators.Where<Procedure>(gzzzzc_, gzzzzd_);
        CqlDateTime gzzzzf_(Procedure FlexibleSigmoidoscopy)
        {
            DataType gzzzzx_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime gzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, gzzzzx_);

            return gzzzzy_;
        };
        IEnumerable<CqlDateTime> gzzzzg_ = context.Operators.Select<Procedure, CqlDateTime>(gzzzze_, gzzzzf_);
        IEnumerable<CqlDateTime> gzzzzh_ = context.Operators.Distinct<CqlDateTime>(gzzzzg_);

        return gzzzzh_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet gzzzzz_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> hzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? hzzzzb_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> hzzzzd_ = FlexibleSigmoidoscopy?.StatusElement;
            string hzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzd_);
            bool? hzzzzf_ = context.Operators.Equal(hzzzze_, "completed");
            DataType hzzzzg_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> hzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzg_);
            CqlDateTime hzzzzi_ = context.Operators.End(hzzzzh_);
            CqlInterval<CqlDateTime> hzzzzj_ = this.Measurement_Period(context);
            CqlDateTime hzzzzk_ = context.Operators.End(hzzzzj_);
            CqlQuantity hzzzzl_ = context.Operators.Quantity(5m, "years");
            CqlDateTime hzzzzm_ = context.Operators.Subtract(hzzzzk_, hzzzzl_);
            CqlDateTime hzzzzo_ = context.Operators.End(hzzzzj_);
            CqlInterval<CqlDateTime> hzzzzp_ = context.Operators.Interval(hzzzzm_, hzzzzo_, true, true);
            bool? hzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzi_, hzzzzp_, default);
            CqlDateTime hzzzzs_ = context.Operators.End(hzzzzj_);
            bool? hzzzzt_ = context.Operators.Not((bool?)(hzzzzs_ is null));
            bool? hzzzzu_ = context.Operators.And(hzzzzq_, hzzzzt_);
            bool? hzzzzv_ = context.Operators.And(hzzzzf_, hzzzzu_);

            return hzzzzv_;
        };
        IEnumerable<Procedure> hzzzzc_ = context.Operators.Where<Procedure>(hzzzza_, hzzzzb_);

        return hzzzzc_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet hzzzzw_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> hzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? hzzzzy_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> izzzza_ = FlexibleSigmoidoscopy?.StatusElement;
            string izzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzza_);
            bool? izzzzc_ = context.Operators.Equal(izzzzb_, "completed");
            bool? izzzzd_ = context.Operators.Not(izzzzc_);
            DataType izzzze_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> izzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzze_);
            CqlDateTime izzzzg_ = context.Operators.End(izzzzf_);
            CqlInterval<CqlDateTime> izzzzh_ = this.Measurement_Period(context);
            CqlDateTime izzzzi_ = context.Operators.End(izzzzh_);
            CqlQuantity izzzzj_ = context.Operators.Quantity(5m, "years");
            CqlDateTime izzzzk_ = context.Operators.Subtract(izzzzi_, izzzzj_);
            CqlDateTime izzzzm_ = context.Operators.End(izzzzh_);
            CqlInterval<CqlDateTime> izzzzn_ = context.Operators.Interval(izzzzk_, izzzzm_, true, true);
            bool? izzzzo_ = context.Operators.In<CqlDateTime>(izzzzg_, izzzzn_, default);
            CqlDateTime izzzzq_ = context.Operators.End(izzzzh_);
            bool? izzzzr_ = context.Operators.Not((bool?)(izzzzq_ is null));
            bool? izzzzs_ = context.Operators.And(izzzzo_, izzzzr_);
            bool? izzzzt_ = context.Operators.And(izzzzd_, izzzzs_);

            return izzzzt_;
        };
        IEnumerable<Procedure> hzzzzz_ = context.Operators.Where<Procedure>(hzzzzx_, hzzzzy_);

        return hzzzzz_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet izzzzu_ = this.Colonoscopy(context);
        IEnumerable<Procedure> izzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzzzw_(Procedure Colonoscopy)
        {
            DataType jzzzzb_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> jzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzb_);
            CqlDateTime jzzzzd_ = context.Operators.End(jzzzzc_);
            CqlInterval<CqlDateTime> jzzzze_ = this.Measurement_Period(context);
            CqlDateTime jzzzzf_ = context.Operators.End(jzzzze_);
            CqlQuantity jzzzzg_ = context.Operators.Quantity(11m, "years");
            CqlDateTime jzzzzh_ = context.Operators.Subtract(jzzzzf_, jzzzzg_);
            CqlDateTime jzzzzj_ = context.Operators.End(jzzzze_);
            CqlInterval<CqlDateTime> jzzzzk_ = context.Operators.Interval(jzzzzh_, jzzzzj_, true, true);
            bool? jzzzzl_ = context.Operators.In<CqlDateTime>(jzzzzd_, jzzzzk_, default);
            CqlDateTime jzzzzn_ = context.Operators.End(jzzzze_);
            bool? jzzzzo_ = context.Operators.Not((bool?)(jzzzzn_ is null));
            bool? jzzzzp_ = context.Operators.And(jzzzzl_, jzzzzo_);

            return jzzzzp_;
        };
        IEnumerable<Procedure> izzzzx_ = context.Operators.Where<Procedure>(izzzzv_, izzzzw_);
        CqlDateTime izzzzy_(Procedure Colonoscopy)
        {
            DataType jzzzzq_ = Colonoscopy?.Performed;
            CqlDateTime jzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, jzzzzq_);

            return jzzzzr_;
        };
        IEnumerable<CqlDateTime> izzzzz_ = context.Operators.Select<Procedure, CqlDateTime>(izzzzx_, izzzzy_);
        IEnumerable<CqlDateTime> jzzzza_ = context.Operators.Distinct<CqlDateTime>(izzzzz_);

        return jzzzza_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet jzzzzs_ = this.Colonoscopy(context);
        IEnumerable<Procedure> jzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? jzzzzu_(Procedure Colonoscopy)
        {
            Code<EventStatus> jzzzzw_ = Colonoscopy?.StatusElement;
            string jzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzw_);
            bool? jzzzzy_ = context.Operators.Equal(jzzzzx_, "completed");
            DataType jzzzzz_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> kzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzz_);
            CqlDateTime kzzzzb_ = context.Operators.End(kzzzza_);
            CqlInterval<CqlDateTime> kzzzzc_ = this.Measurement_Period(context);
            CqlDateTime kzzzzd_ = context.Operators.End(kzzzzc_);
            CqlQuantity kzzzze_ = context.Operators.Quantity(10m, "years");
            CqlDateTime kzzzzf_ = context.Operators.Subtract(kzzzzd_, kzzzze_);
            CqlDateTime kzzzzh_ = context.Operators.End(kzzzzc_);
            CqlInterval<CqlDateTime> kzzzzi_ = context.Operators.Interval(kzzzzf_, kzzzzh_, true, true);
            bool? kzzzzj_ = context.Operators.In<CqlDateTime>(kzzzzb_, kzzzzi_, default);
            CqlDateTime kzzzzl_ = context.Operators.End(kzzzzc_);
            bool? kzzzzm_ = context.Operators.Not((bool?)(kzzzzl_ is null));
            bool? kzzzzn_ = context.Operators.And(kzzzzj_, kzzzzm_);
            bool? kzzzzo_ = context.Operators.And(jzzzzy_, kzzzzn_);

            return kzzzzo_;
        };
        IEnumerable<Procedure> jzzzzv_ = context.Operators.Where<Procedure>(jzzzzt_, jzzzzu_);

        return jzzzzv_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet kzzzzp_ = this.Colonoscopy(context);
        IEnumerable<Procedure> kzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? kzzzzr_(Procedure Colonoscopy)
        {
            Code<EventStatus> kzzzzt_ = Colonoscopy?.StatusElement;
            string kzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzt_);
            bool? kzzzzv_ = context.Operators.Equal(kzzzzu_, "completed");
            bool? kzzzzw_ = context.Operators.Not(kzzzzv_);
            DataType kzzzzx_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> kzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzx_);
            CqlDateTime kzzzzz_ = context.Operators.End(kzzzzy_);
            CqlInterval<CqlDateTime> lzzzza_ = this.Measurement_Period(context);
            CqlDateTime lzzzzb_ = context.Operators.End(lzzzza_);
            CqlQuantity lzzzzc_ = context.Operators.Quantity(10m, "years");
            CqlDateTime lzzzzd_ = context.Operators.Subtract(lzzzzb_, lzzzzc_);
            CqlDateTime lzzzzf_ = context.Operators.End(lzzzza_);
            CqlInterval<CqlDateTime> lzzzzg_ = context.Operators.Interval(lzzzzd_, lzzzzf_, true, true);
            bool? lzzzzh_ = context.Operators.In<CqlDateTime>(kzzzzz_, lzzzzg_, default);
            CqlDateTime lzzzzj_ = context.Operators.End(lzzzza_);
            bool? lzzzzk_ = context.Operators.Not((bool?)(lzzzzj_ is null));
            bool? lzzzzl_ = context.Operators.And(lzzzzh_, lzzzzk_);
            bool? lzzzzm_ = context.Operators.And(kzzzzw_, lzzzzl_);

            return lzzzzm_;
        };
        IEnumerable<Procedure> kzzzzs_ = context.Operators.Where<Procedure>(kzzzzq_, kzzzzr_);

        return kzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> lzzzzn_ = this.Colonoscopy_Performed(context);
        bool? lzzzzo_ = context.Operators.Exists<Procedure>(lzzzzn_);
        IEnumerable<Observation> lzzzzp_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? lzzzzq_ = context.Operators.Exists<Observation>(lzzzzp_);
        bool? lzzzzr_ = context.Operators.Or(lzzzzo_, lzzzzq_);
        IEnumerable<Procedure> lzzzzs_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? lzzzzt_ = context.Operators.Exists<Procedure>(lzzzzs_);
        bool? lzzzzu_ = context.Operators.Or(lzzzzr_, lzzzzt_);
        IEnumerable<Observation> lzzzzv_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? lzzzzw_ = context.Operators.Exists<Observation>(lzzzzv_);
        bool? lzzzzx_ = context.Operators.Or(lzzzzu_, lzzzzw_);
        IEnumerable<Observation> lzzzzy_ = this.CT_Colonography_Performed(context);
        bool? lzzzzz_ = context.Operators.Exists<Observation>(lzzzzy_);
        bool? mzzzza_ = context.Operators.Or(lzzzzx_, lzzzzz_);

        return mzzzza_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? mzzzzb_ = this.Numerator(context);
        bool? mzzzzc_ = this.Initial_Population(context);
        bool? mzzzzd_ = context.Operators.And(mzzzzb_, mzzzzc_);
        bool? mzzzze_ = this.Denominator(context);
        bool? mzzzzf_ = context.Operators.And(mzzzzd_, mzzzze_);
        bool? mzzzzg_ = this.Denominator_Exclusions(context);
        bool? mzzzzh_ = context.Operators.Not(mzzzzg_);
        bool? mzzzzi_ = context.Operators.And(mzzzzf_, mzzzzh_);

        return mzzzzi_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
