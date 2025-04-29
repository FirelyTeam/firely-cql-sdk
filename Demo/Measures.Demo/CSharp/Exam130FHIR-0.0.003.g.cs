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
        CqlDateTime ozzzzzzd_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime ozzzzzze_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> ozzzzzzf_ = context.Operators.Interval(ozzzzzzd_, ozzzzzze_, true, false);
        object ozzzzzzg_ = context.ResolveParameter("Exam130FHIR-0.0.003", "Measurement Period", ozzzzzzf_);

        return (CqlInterval<CqlDateTime>)ozzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzzzzzi_ = context.Operators.SingletonFrom<Patient>(ozzzzzzh_);

        return ozzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> ozzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return ozzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return ozzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return ozzzzzzm_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet ozzzzzzn_ = this.Online_Assessments(context);
        IEnumerable<Encounter> ozzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ozzzzzzp_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ozzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ozzzzzzr_ = context.Operators.Union<Encounter>(ozzzzzzo_, ozzzzzzq_);
        bool? ozzzzzzs_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> ozzzzzzu_ = TelehealthEncounter?.StatusElement;
            string ozzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzu_);
            bool? ozzzzzzw_ = context.Operators.Equal(ozzzzzzv_, "finished");
            CqlInterval<CqlDateTime> ozzzzzzx_ = this.Measurement_Period(context);
            Period ozzzzzzy_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzy_ as object);
            bool? pzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzx_, ozzzzzzz_, default);
            bool? pzzzzzzb_ = context.Operators.And(ozzzzzzw_, pzzzzzza_);

            return pzzzzzzb_;
        };
        IEnumerable<Encounter> ozzzzzzt_ = context.Operators.Where<Encounter>(ozzzzzzr_, ozzzzzzs_);

        return ozzzzzzt_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient pzzzzzzc_ = this.Patient(context);
        Date pzzzzzzd_ = pzzzzzzc_?.BirthDateElement;
        string pzzzzzze_ = pzzzzzzd_?.Value;
        CqlDate pzzzzzzf_ = context.Operators.ConvertStringToDate(pzzzzzze_);
        CqlInterval<CqlDateTime> pzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzh_ = context.Operators.Start(pzzzzzzg_);
        CqlDate pzzzzzzi_ = context.Operators.DateFrom(pzzzzzzh_);
        int? pzzzzzzj_ = context.Operators.CalculateAgeAt(pzzzzzzf_, pzzzzzzi_, "year");

        return pzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient pzzzzzzk_ = this.Patient(context);
        Date pzzzzzzl_ = pzzzzzzk_?.BirthDateElement;
        string pzzzzzzm_ = pzzzzzzl_?.Value;
        CqlDate pzzzzzzn_ = context.Operators.ConvertStringToDate(pzzzzzzm_);
        CqlInterval<CqlDateTime> pzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzp_ = context.Operators.Start(pzzzzzzo_);
        CqlDate pzzzzzzq_ = context.Operators.DateFrom(pzzzzzzp_);
        int? pzzzzzzr_ = context.Operators.CalculateAgeAt(pzzzzzzn_, pzzzzzzq_, "year");
        CqlInterval<int?> pzzzzzzs_ = context.Operators.Interval(51, 75, true, false);
        bool? pzzzzzzt_ = context.Operators.In<int?>(pzzzzzzr_, pzzzzzzs_, default);
        IEnumerable<Encounter> pzzzzzzu_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> pzzzzzzv_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> pzzzzzzw_ = context.Operators.Union<Encounter>(pzzzzzzu_, pzzzzzzv_);
        bool? pzzzzzzx_ = context.Operators.Exists<Encounter>(pzzzzzzw_);
        bool? pzzzzzzy_ = context.Operators.And(pzzzzzzt_, pzzzzzzx_);

        return pzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? pzzzzzzz_ = this.Initial_Population(context);

        return pzzzzzzz_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet qzzzzzza_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> qzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? qzzzzzzc_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> qzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime qzzzzzzf_ = context.Operators.Start(qzzzzzze_);
            CqlInterval<CqlDateTime> qzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzh_ = context.Operators.End(qzzzzzzg_);
            bool? qzzzzzzi_ = context.Operators.SameOrBefore(qzzzzzzf_, qzzzzzzh_, default);

            return qzzzzzzi_;
        };
        IEnumerable<Condition> qzzzzzzd_ = context.Operators.Where<Condition>(qzzzzzzb_, qzzzzzzc_);

        return qzzzzzzd_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet qzzzzzzj_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> qzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? qzzzzzzl_(Procedure Colectomy)
        {
            Code<EventStatus> qzzzzzzn_ = Colectomy?.StatusElement;
            string qzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzn_);
            bool? qzzzzzzp_ = context.Operators.Equal(qzzzzzzo_, "completed");
            DataType qzzzzzzq_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> qzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzq_);
            CqlDateTime qzzzzzzs_ = context.Operators.End(qzzzzzzr_);
            CqlInterval<CqlDateTime> qzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzu_ = context.Operators.End(qzzzzzzt_);
            bool? qzzzzzzv_ = context.Operators.SameOrBefore(qzzzzzzs_, qzzzzzzu_, default);
            bool? qzzzzzzw_ = context.Operators.And(qzzzzzzp_, qzzzzzzv_);

            return qzzzzzzw_;
        };
        IEnumerable<Procedure> qzzzzzzm_ = context.Operators.Where<Procedure>(qzzzzzzk_, qzzzzzzl_);

        return qzzzzzzm_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet qzzzzzzx_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> qzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? qzzzzzzz_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> rzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime rzzzzzzc_ = context.Operators.Start(rzzzzzzb_);
            CqlInterval<CqlDateTime> rzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzze_ = context.Operators.End(rzzzzzzd_);
            bool? rzzzzzzf_ = context.Operators.SameOrBefore(rzzzzzzc_, rzzzzzze_, default);

            return rzzzzzzf_;
        };
        IEnumerable<Condition> rzzzzzza_ = context.Operators.Where<Condition>(qzzzzzzy_, qzzzzzzz_);

        return rzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? rzzzzzzg_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> rzzzzzzh_ = this.Malignant_Neoplasm(context);
        bool? rzzzzzzi_ = context.Operators.Exists<Condition>(rzzzzzzh_);
        bool? rzzzzzzj_ = context.Operators.Or(rzzzzzzg_, rzzzzzzi_);
        IEnumerable<Procedure> rzzzzzzk_ = this.Total_Colectomy_Performed(context);
        bool? rzzzzzzl_ = context.Operators.Exists<Procedure>(rzzzzzzk_);
        bool? rzzzzzzm_ = context.Operators.Or(rzzzzzzj_, rzzzzzzl_);
        IEnumerable<Condition> rzzzzzzn_ = this.Total_Colectomy_Condition(context);
        bool? rzzzzzzo_ = context.Operators.Exists<Condition>(rzzzzzzn_);
        bool? rzzzzzzp_ = context.Operators.Or(rzzzzzzm_, rzzzzzzo_);
        bool? rzzzzzzq_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? rzzzzzzr_ = context.Operators.Or(rzzzzzzp_, rzzzzzzq_);
        Patient rzzzzzzs_ = this.Patient(context);
        Date rzzzzzzt_ = rzzzzzzs_?.BirthDateElement;
        string rzzzzzzu_ = rzzzzzzt_?.Value;
        CqlDate rzzzzzzv_ = context.Operators.ConvertStringToDate(rzzzzzzu_);
        CqlInterval<CqlDateTime> rzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzx_ = context.Operators.Start(rzzzzzzw_);
        CqlDate rzzzzzzy_ = context.Operators.DateFrom(rzzzzzzx_);
        int? rzzzzzzz_ = context.Operators.CalculateAgeAt(rzzzzzzv_, rzzzzzzy_, "year");
        bool? szzzzzza_ = context.Operators.GreaterOrEqual(rzzzzzzz_, 65);
        bool? szzzzzzb_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? szzzzzzc_ = context.Operators.And(szzzzzza_, szzzzzzb_);
        bool? szzzzzzd_ = context.Operators.Or(rzzzzzzr_, szzzzzzc_);
        bool? szzzzzze_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? szzzzzzf_ = context.Operators.Or(szzzzzzd_, szzzzzze_);

        return szzzzzzf_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet szzzzzzg_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> szzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzzzzi_(Observation FecalOccult)
        {
            DataType szzzzzzn_ = FecalOccult?.Effective;
            CqlDateTime szzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzn_);
            CqlInterval<CqlDateTime> szzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzq_ = context.Operators.Start(szzzzzzp_);
            CqlQuantity szzzzzzr_ = context.Operators.Quantity(1m, "year");
            CqlDateTime szzzzzzs_ = context.Operators.Subtract(szzzzzzq_, szzzzzzr_);
            CqlDateTime szzzzzzu_ = context.Operators.End(szzzzzzp_);
            CqlInterval<CqlDateTime> szzzzzzv_ = context.Operators.Interval(szzzzzzs_, szzzzzzu_, false, false);
            bool? szzzzzzw_ = context.Operators.In<CqlDateTime>(szzzzzzo_, szzzzzzv_, default);

            return szzzzzzw_;
        };
        IEnumerable<Observation> szzzzzzj_ = context.Operators.Where<Observation>(szzzzzzh_, szzzzzzi_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? szzzzzzk_(Observation FecalOccult)
        {
            DataType szzzzzzx_ = FecalOccult?.Effective;
            CqlDateTime szzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzx_);
            DataType szzzzzzz_ = FecalOccult?.Value;
            IEnumerable<Coding> tzzzzzza_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(szzzzzzz_, "coding");
            bool? tzzzzzzb_(Coding @this)
            {
                FhirString tzzzzzzv_ = @this?.DisplayElement;
                bool? tzzzzzzw_ = context.Operators.Not((bool?)(tzzzzzzv_ is null));

                return tzzzzzzw_;
            };
            IEnumerable<Coding> tzzzzzzc_ = context.Operators.Where<Coding>(tzzzzzza_, tzzzzzzb_);
            FhirString tzzzzzzd_(Coding @this)
            {
                FhirString tzzzzzzx_ = @this?.DisplayElement;

                return tzzzzzzx_;
            };
            IEnumerable<FhirString> tzzzzzze_ = context.Operators.Select<Coding, FhirString>(tzzzzzzc_, tzzzzzzd_);
            List<CodeableConcept> tzzzzzzf_ = FecalOccult?.Category;
            bool? tzzzzzzg_(CodeableConcept @this)
            {
                List<Coding> tzzzzzzy_ = @this?.Coding;
                bool? tzzzzzzz_ = context.Operators.Not((bool?)(tzzzzzzy_ is null));

                return tzzzzzzz_;
            };
            IEnumerable<CodeableConcept> tzzzzzzh_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzzzf_, tzzzzzzg_);
            List<Coding> tzzzzzzi_(CodeableConcept @this)
            {
                List<Coding> uzzzzzza_ = @this?.Coding;

                return uzzzzzza_;
            };
            IEnumerable<List<Coding>> tzzzzzzj_ = context.Operators.Select<CodeableConcept, List<Coding>>(tzzzzzzh_, tzzzzzzi_);
            IEnumerable<Coding> tzzzzzzk_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)tzzzzzzj_);
            bool? tzzzzzzl_(Coding @this)
            {
                Code uzzzzzzb_ = @this?.CodeElement;
                bool? uzzzzzzc_ = context.Operators.Not((bool?)(uzzzzzzb_ is null));

                return uzzzzzzc_;
            };
            IEnumerable<Coding> tzzzzzzm_ = context.Operators.Where<Coding>(tzzzzzzk_, tzzzzzzl_);
            Code tzzzzzzn_(Coding @this)
            {
                Code uzzzzzzd_ = @this?.CodeElement;

                return uzzzzzzd_;
            };
            IEnumerable<Code> tzzzzzzo_ = context.Operators.Select<Coding, Code>(tzzzzzzm_, tzzzzzzn_);
            bool? tzzzzzzp_(Code @this)
            {
                string uzzzzzze_ = @this?.Value;
                bool? uzzzzzzf_ = context.Operators.Not((bool?)(uzzzzzze_ is null));

                return uzzzzzzf_;
            };
            IEnumerable<Code> tzzzzzzq_ = context.Operators.Where<Code>(tzzzzzzo_, tzzzzzzp_);
            string tzzzzzzr_(Code @this)
            {
                string uzzzzzzg_ = @this?.Value;

                return uzzzzzzg_;
            };
            IEnumerable<string> tzzzzzzs_ = context.Operators.Select<Code, string>(tzzzzzzq_, tzzzzzzr_);
            Code<ObservationStatus> tzzzzzzt_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? tzzzzzzu_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, szzzzzzy_, tzzzzzze_, tzzzzzzs_, tzzzzzzt_);

            return tzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> szzzzzzl_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(szzzzzzj_, szzzzzzk_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> szzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(szzzzzzl_);

        return szzzzzzm_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet uzzzzzzh_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> uzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? uzzzzzzj_(Observation FecalOccult)
        {
            Code<ObservationStatus> uzzzzzzl_ = FecalOccult?.StatusElement;
            string uzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzl_);
            string[] uzzzzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzo_ = context.Operators.In<string>(uzzzzzzm_, uzzzzzzn_ as IEnumerable<string>);
            List<CodeableConcept> uzzzzzzp_ = FecalOccult?.Category;
            bool? uzzzzzzq_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> vzzzzzzc_ = FecalOccultCategory?.Coding;
                bool? vzzzzzzd_(Coding @this)
                {
                    Code vzzzzzzn_ = @this?.CodeElement;
                    bool? vzzzzzzo_ = context.Operators.Not((bool?)(vzzzzzzn_ is null));

                    return vzzzzzzo_;
                };
                IEnumerable<Coding> vzzzzzze_ = context.Operators.Where<Coding>((IEnumerable<Coding>)vzzzzzzc_, vzzzzzzd_);
                Code vzzzzzzf_(Coding @this)
                {
                    Code vzzzzzzp_ = @this?.CodeElement;

                    return vzzzzzzp_;
                };
                IEnumerable<Code> vzzzzzzg_ = context.Operators.Select<Coding, Code>(vzzzzzze_, vzzzzzzf_);
                bool? vzzzzzzh_(Code @this)
                {
                    string vzzzzzzq_ = @this?.Value;
                    bool? vzzzzzzr_ = context.Operators.Not((bool?)(vzzzzzzq_ is null));

                    return vzzzzzzr_;
                };
                IEnumerable<Code> vzzzzzzi_ = context.Operators.Where<Code>(vzzzzzzg_, vzzzzzzh_);
                string vzzzzzzj_(Code @this)
                {
                    string vzzzzzzs_ = @this?.Value;

                    return vzzzzzzs_;
                };
                IEnumerable<string> vzzzzzzk_ = context.Operators.Select<Code, string>(vzzzzzzi_, vzzzzzzj_);
                string[] vzzzzzzl_ = [
                    "laboratory",
                ];
                bool? vzzzzzzm_ = context.Operators.Equivalent<string>(vzzzzzzk_, vzzzzzzl_ as IEnumerable<string>);

                return vzzzzzzm_;
            };
            IEnumerable<CodeableConcept> uzzzzzzr_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzzzp_, uzzzzzzq_);
            bool? uzzzzzzs_ = context.Operators.Exists<CodeableConcept>(uzzzzzzr_);
            bool? uzzzzzzt_ = context.Operators.And(uzzzzzzo_, uzzzzzzs_);
            DataType uzzzzzzu_ = FecalOccult?.Value;
            bool? uzzzzzzv_ = context.Operators.Not((bool?)(uzzzzzzu_ is null));
            bool? uzzzzzzw_ = context.Operators.And(uzzzzzzt_, uzzzzzzv_);
            DataType uzzzzzzx_ = FecalOccult?.Effective;
            CqlDateTime uzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzzzzx_);
            CqlInterval<CqlDateTime> uzzzzzzz_ = this.Measurement_Period(context);
            bool? vzzzzzza_ = context.Operators.In<CqlDateTime>(uzzzzzzy_, uzzzzzzz_, default);
            bool? vzzzzzzb_ = context.Operators.And(uzzzzzzw_, vzzzzzza_);

            return vzzzzzzb_;
        };
        IEnumerable<Observation> uzzzzzzk_ = context.Operators.Where<Observation>(uzzzzzzi_, uzzzzzzj_);

        return uzzzzzzk_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet vzzzzzzt_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> vzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzv_(Observation FecalOccult)
        {
            Code<ObservationStatus> vzzzzzzx_ = FecalOccult?.StatusElement;
            string vzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzx_);
            string[] vzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzzzzza_ = context.Operators.In<string>(vzzzzzzy_, vzzzzzzz_ as IEnumerable<string>);
            List<CodeableConcept> wzzzzzzb_ = FecalOccult?.Category;
            bool? wzzzzzzc_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> wzzzzzzo_ = FecalOccultCategory?.Coding;
                bool? wzzzzzzp_(Coding @this)
                {
                    Code wzzzzzzz_ = @this?.CodeElement;
                    bool? xzzzzzza_ = context.Operators.Not((bool?)(wzzzzzzz_ is null));

                    return xzzzzzza_;
                };
                IEnumerable<Coding> wzzzzzzq_ = context.Operators.Where<Coding>((IEnumerable<Coding>)wzzzzzzo_, wzzzzzzp_);
                Code wzzzzzzr_(Coding @this)
                {
                    Code xzzzzzzb_ = @this?.CodeElement;

                    return xzzzzzzb_;
                };
                IEnumerable<Code> wzzzzzzs_ = context.Operators.Select<Coding, Code>(wzzzzzzq_, wzzzzzzr_);
                bool? wzzzzzzt_(Code @this)
                {
                    string xzzzzzzc_ = @this?.Value;
                    bool? xzzzzzzd_ = context.Operators.Not((bool?)(xzzzzzzc_ is null));

                    return xzzzzzzd_;
                };
                IEnumerable<Code> wzzzzzzu_ = context.Operators.Where<Code>(wzzzzzzs_, wzzzzzzt_);
                string wzzzzzzv_(Code @this)
                {
                    string xzzzzzze_ = @this?.Value;

                    return xzzzzzze_;
                };
                IEnumerable<string> wzzzzzzw_ = context.Operators.Select<Code, string>(wzzzzzzu_, wzzzzzzv_);
                string[] wzzzzzzx_ = [
                    "laboratory",
                ];
                bool? wzzzzzzy_ = context.Operators.Equivalent<string>(wzzzzzzw_, wzzzzzzx_ as IEnumerable<string>);

                return wzzzzzzy_;
            };
            IEnumerable<CodeableConcept> wzzzzzzd_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzzzzb_, wzzzzzzc_);
            bool? wzzzzzze_ = context.Operators.Exists<CodeableConcept>(wzzzzzzd_);
            bool? wzzzzzzf_ = context.Operators.And(wzzzzzza_, wzzzzzze_);
            DataType wzzzzzzg_ = FecalOccult?.Value;
            bool? wzzzzzzh_ = context.Operators.Not((bool?)(wzzzzzzg_ is null));
            bool? wzzzzzzi_ = context.Operators.And(wzzzzzzf_, wzzzzzzh_);
            DataType wzzzzzzj_ = FecalOccult?.Effective;
            CqlDateTime wzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, wzzzzzzj_);
            CqlInterval<CqlDateTime> wzzzzzzl_ = this.Measurement_Period(context);
            bool? wzzzzzzm_ = context.Operators.In<CqlDateTime>(wzzzzzzk_, wzzzzzzl_, "day");
            bool? wzzzzzzn_ = context.Operators.And(wzzzzzzi_, wzzzzzzm_);

            return wzzzzzzn_;
        };
        IEnumerable<Observation> vzzzzzzw_ = context.Operators.Where<Observation>(vzzzzzzu_, vzzzzzzv_);

        return vzzzzzzw_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet xzzzzzzf_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> xzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzzh_(Observation FecalOccult)
        {
            List<CodeableConcept> xzzzzzzj_ = FecalOccult?.Category;
            bool? xzzzzzzk_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> xzzzzzzv_ = FecalOccultCategory?.Coding;
                bool? xzzzzzzw_(Coding @this)
                {
                    Code yzzzzzzh_ = @this?.CodeElement;
                    bool? yzzzzzzi_ = context.Operators.Not((bool?)(yzzzzzzh_ is null));

                    return yzzzzzzi_;
                };
                IEnumerable<Coding> xzzzzzzx_ = context.Operators.Where<Coding>((IEnumerable<Coding>)xzzzzzzv_, xzzzzzzw_);
                Code xzzzzzzy_(Coding @this)
                {
                    Code yzzzzzzj_ = @this?.CodeElement;

                    return yzzzzzzj_;
                };
                IEnumerable<Code> xzzzzzzz_ = context.Operators.Select<Coding, Code>(xzzzzzzx_, xzzzzzzy_);
                bool? yzzzzzza_(Code @this)
                {
                    string yzzzzzzk_ = @this?.Value;
                    bool? yzzzzzzl_ = context.Operators.Not((bool?)(yzzzzzzk_ is null));

                    return yzzzzzzl_;
                };
                IEnumerable<Code> yzzzzzzb_ = context.Operators.Where<Code>(xzzzzzzz_, yzzzzzza_);
                string yzzzzzzc_(Code @this)
                {
                    string yzzzzzzm_ = @this?.Value;

                    return yzzzzzzm_;
                };
                IEnumerable<string> yzzzzzzd_ = context.Operators.Select<Code, string>(yzzzzzzb_, yzzzzzzc_);
                string[] yzzzzzze_ = [
                    "laboratory",
                ];
                bool? yzzzzzzf_ = context.Operators.Equivalent<string>(yzzzzzzd_, yzzzzzze_ as IEnumerable<string>);
                bool? yzzzzzzg_ = context.Operators.Not(yzzzzzzf_);

                return yzzzzzzg_;
            };
            IEnumerable<CodeableConcept> xzzzzzzl_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzzzzj_, xzzzzzzk_);
            bool? xzzzzzzm_ = context.Operators.Exists<CodeableConcept>(xzzzzzzl_);
            DataType xzzzzzzn_ = FecalOccult?.Value;
            bool? xzzzzzzo_ = context.Operators.Not((bool?)(xzzzzzzn_ is null));
            bool? xzzzzzzp_ = context.Operators.And(xzzzzzzm_, xzzzzzzo_);
            DataType xzzzzzzq_ = FecalOccult?.Effective;
            CqlDateTime xzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, xzzzzzzq_);
            CqlInterval<CqlDateTime> xzzzzzzs_ = this.Measurement_Period(context);
            bool? xzzzzzzt_ = context.Operators.In<CqlDateTime>(xzzzzzzr_, xzzzzzzs_, "day");
            bool? xzzzzzzu_ = context.Operators.And(xzzzzzzp_, xzzzzzzt_);

            return xzzzzzzu_;
        };
        IEnumerable<Observation> xzzzzzzi_ = context.Operators.Where<Observation>(xzzzzzzg_, xzzzzzzh_);

        return xzzzzzzi_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet yzzzzzzn_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> yzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzzzzp_(Observation FecalOccult)
        {
            Code<ObservationStatus> yzzzzzzr_ = FecalOccult?.StatusElement;
            string yzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzr_);
            string[] yzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzzzzzu_ = context.Operators.In<string>(yzzzzzzs_, yzzzzzzt_ as IEnumerable<string>);
            bool? yzzzzzzv_ = context.Operators.Not(yzzzzzzu_);
            DataType yzzzzzzw_ = FecalOccult?.Value;
            bool? yzzzzzzx_ = context.Operators.Not((bool?)(yzzzzzzw_ is null));
            bool? yzzzzzzy_ = context.Operators.And(yzzzzzzv_, yzzzzzzx_);
            DataType yzzzzzzz_ = FecalOccult?.Effective;
            CqlDateTime zzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, yzzzzzzz_);
            CqlInterval<CqlDateTime> zzzzzzzb_ = this.Measurement_Period(context);
            bool? zzzzzzzc_ = context.Operators.In<CqlDateTime>(zzzzzzza_, zzzzzzzb_, "day");
            bool? zzzzzzzd_ = context.Operators.And(yzzzzzzy_, zzzzzzzc_);

            return zzzzzzzd_;
        };
        IEnumerable<Observation> yzzzzzzq_ = context.Operators.Where<Observation>(yzzzzzzo_, yzzzzzzp_);

        return yzzzzzzq_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet zzzzzzze_ = this.FIT_DNA(context);
        IEnumerable<Observation> zzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzzg_(Observation FitDNA)
        {
            DataType zzzzzzzl_ = FitDNA?.Effective;
            CqlDateTime zzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, zzzzzzzl_);
            CqlInterval<CqlDateTime> zzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzo_ = context.Operators.End(zzzzzzzn_);
            CqlQuantity zzzzzzzp_ = context.Operators.Quantity(4m, "years");
            CqlDateTime zzzzzzzq_ = context.Operators.Subtract(zzzzzzzo_, zzzzzzzp_);
            CqlDateTime zzzzzzzs_ = context.Operators.End(zzzzzzzn_);
            CqlInterval<CqlDateTime> zzzzzzzt_ = context.Operators.Interval(zzzzzzzq_, zzzzzzzs_, true, true);
            bool? zzzzzzzu_ = context.Operators.In<CqlDateTime>(zzzzzzzm_, zzzzzzzt_, default);
            CqlDateTime zzzzzzzw_ = context.Operators.End(zzzzzzzn_);
            bool? zzzzzzzx_ = context.Operators.Not((bool?)(zzzzzzzw_ is null));
            bool? zzzzzzzy_ = context.Operators.And(zzzzzzzu_, zzzzzzzx_);

            return zzzzzzzy_;
        };
        IEnumerable<Observation> zzzzzzzh_ = context.Operators.Where<Observation>(zzzzzzzf_, zzzzzzzg_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? zzzzzzzi_(Observation FitDNA)
        {
            DataType zzzzzzzz_ = FitDNA?.Effective;
            CqlDateTime azzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, zzzzzzzz_);
            DataType azzzzzzzb_ = FitDNA?.Value;
            IEnumerable<Coding> azzzzzzzc_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(azzzzzzzb_, "coding");
            bool? azzzzzzzd_(Coding @this)
            {
                FhirString azzzzzzzx_ = @this?.DisplayElement;
                bool? azzzzzzzy_ = context.Operators.Not((bool?)(azzzzzzzx_ is null));

                return azzzzzzzy_;
            };
            IEnumerable<Coding> azzzzzzze_ = context.Operators.Where<Coding>(azzzzzzzc_, azzzzzzzd_);
            FhirString azzzzzzzf_(Coding @this)
            {
                FhirString azzzzzzzz_ = @this?.DisplayElement;

                return azzzzzzzz_;
            };
            IEnumerable<FhirString> azzzzzzzg_ = context.Operators.Select<Coding, FhirString>(azzzzzzze_, azzzzzzzf_);
            List<CodeableConcept> azzzzzzzh_ = FitDNA?.Category;
            bool? azzzzzzzi_(CodeableConcept @this)
            {
                List<Coding> bzzzzzzza_ = @this?.Coding;
                bool? bzzzzzzzb_ = context.Operators.Not((bool?)(bzzzzzzza_ is null));

                return bzzzzzzzb_;
            };
            IEnumerable<CodeableConcept> azzzzzzzj_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzzzzh_, azzzzzzzi_);
            List<Coding> azzzzzzzk_(CodeableConcept @this)
            {
                List<Coding> bzzzzzzzc_ = @this?.Coding;

                return bzzzzzzzc_;
            };
            IEnumerable<List<Coding>> azzzzzzzl_ = context.Operators.Select<CodeableConcept, List<Coding>>(azzzzzzzj_, azzzzzzzk_);
            IEnumerable<Coding> azzzzzzzm_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)azzzzzzzl_);
            bool? azzzzzzzn_(Coding @this)
            {
                Code bzzzzzzzd_ = @this?.CodeElement;
                bool? bzzzzzzze_ = context.Operators.Not((bool?)(bzzzzzzzd_ is null));

                return bzzzzzzze_;
            };
            IEnumerable<Coding> azzzzzzzo_ = context.Operators.Where<Coding>(azzzzzzzm_, azzzzzzzn_);
            Code azzzzzzzp_(Coding @this)
            {
                Code bzzzzzzzf_ = @this?.CodeElement;

                return bzzzzzzzf_;
            };
            IEnumerable<Code> azzzzzzzq_ = context.Operators.Select<Coding, Code>(azzzzzzzo_, azzzzzzzp_);
            bool? azzzzzzzr_(Code @this)
            {
                string bzzzzzzzg_ = @this?.Value;
                bool? bzzzzzzzh_ = context.Operators.Not((bool?)(bzzzzzzzg_ is null));

                return bzzzzzzzh_;
            };
            IEnumerable<Code> azzzzzzzs_ = context.Operators.Where<Code>(azzzzzzzq_, azzzzzzzr_);
            string azzzzzzzt_(Code @this)
            {
                string bzzzzzzzi_ = @this?.Value;

                return bzzzzzzzi_;
            };
            IEnumerable<string> azzzzzzzu_ = context.Operators.Select<Code, string>(azzzzzzzs_, azzzzzzzt_);
            Code<ObservationStatus> azzzzzzzv_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? azzzzzzzw_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, azzzzzzza_, azzzzzzzg_, azzzzzzzu_, azzzzzzzv_);

            return azzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> zzzzzzzj_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(zzzzzzzh_, zzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> zzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(zzzzzzzj_);

        return zzzzzzzk_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet bzzzzzzzj_ = this.FIT_DNA(context);
        IEnumerable<Observation> bzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzl_(Observation FitDNA)
        {
            Code<ObservationStatus> bzzzzzzzn_ = FitDNA?.StatusElement;
            string bzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzn_);
            string[] bzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzzzq_ = context.Operators.In<string>(bzzzzzzzo_, bzzzzzzzp_ as IEnumerable<string>);
            List<CodeableConcept> bzzzzzzzr_ = FitDNA?.Category;
            bool? bzzzzzzzs_(CodeableConcept FitDNACategory)
            {
                List<Coding> czzzzzzzo_ = FitDNACategory?.Coding;
                bool? czzzzzzzp_(Coding @this)
                {
                    Code czzzzzzzz_ = @this?.CodeElement;
                    bool? dzzzzzzza_ = context.Operators.Not((bool?)(czzzzzzzz_ is null));

                    return dzzzzzzza_;
                };
                IEnumerable<Coding> czzzzzzzq_ = context.Operators.Where<Coding>((IEnumerable<Coding>)czzzzzzzo_, czzzzzzzp_);
                Code czzzzzzzr_(Coding @this)
                {
                    Code dzzzzzzzb_ = @this?.CodeElement;

                    return dzzzzzzzb_;
                };
                IEnumerable<Code> czzzzzzzs_ = context.Operators.Select<Coding, Code>(czzzzzzzq_, czzzzzzzr_);
                bool? czzzzzzzt_(Code @this)
                {
                    string dzzzzzzzc_ = @this?.Value;
                    bool? dzzzzzzzd_ = context.Operators.Not((bool?)(dzzzzzzzc_ is null));

                    return dzzzzzzzd_;
                };
                IEnumerable<Code> czzzzzzzu_ = context.Operators.Where<Code>(czzzzzzzs_, czzzzzzzt_);
                string czzzzzzzv_(Code @this)
                {
                    string dzzzzzzze_ = @this?.Value;

                    return dzzzzzzze_;
                };
                IEnumerable<string> czzzzzzzw_ = context.Operators.Select<Code, string>(czzzzzzzu_, czzzzzzzv_);
                string[] czzzzzzzx_ = [
                    "laboratory",
                ];
                bool? czzzzzzzy_ = context.Operators.Equivalent<string>(czzzzzzzw_, czzzzzzzx_ as IEnumerable<string>);

                return czzzzzzzy_;
            };
            IEnumerable<CodeableConcept> bzzzzzzzt_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzzzr_, bzzzzzzzs_);
            bool? bzzzzzzzu_ = context.Operators.Exists<CodeableConcept>(bzzzzzzzt_);
            bool? bzzzzzzzv_ = context.Operators.And(bzzzzzzzq_, bzzzzzzzu_);
            DataType bzzzzzzzw_ = FitDNA?.Value;
            bool? bzzzzzzzx_ = context.Operators.Not((bool?)(bzzzzzzzw_ is null));
            bool? bzzzzzzzy_ = context.Operators.And(bzzzzzzzv_, bzzzzzzzx_);
            DataType bzzzzzzzz_ = FitDNA?.Effective;
            CqlDateTime czzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, bzzzzzzzz_);
            CqlInterval<CqlDateTime> czzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzc_ = context.Operators.End(czzzzzzzb_);
            CqlQuantity czzzzzzzd_ = context.Operators.Quantity(3m, "years");
            CqlDateTime czzzzzzze_ = context.Operators.Subtract(czzzzzzzc_, czzzzzzzd_);
            CqlDateTime czzzzzzzg_ = context.Operators.End(czzzzzzzb_);
            CqlInterval<CqlDateTime> czzzzzzzh_ = context.Operators.Interval(czzzzzzze_, czzzzzzzg_, true, true);
            bool? czzzzzzzi_ = context.Operators.In<CqlDateTime>(czzzzzzza_, czzzzzzzh_, default);
            CqlDateTime czzzzzzzk_ = context.Operators.End(czzzzzzzb_);
            bool? czzzzzzzl_ = context.Operators.Not((bool?)(czzzzzzzk_ is null));
            bool? czzzzzzzm_ = context.Operators.And(czzzzzzzi_, czzzzzzzl_);
            bool? czzzzzzzn_ = context.Operators.And(bzzzzzzzy_, czzzzzzzm_);

            return czzzzzzzn_;
        };
        IEnumerable<Observation> bzzzzzzzm_ = context.Operators.Where<Observation>(bzzzzzzzk_, bzzzzzzzl_);

        return bzzzzzzzm_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet dzzzzzzzf_ = this.FIT_DNA(context);
        IEnumerable<Observation> dzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? dzzzzzzzh_(Observation FitDNA)
        {
            Code<ObservationStatus> dzzzzzzzj_ = FitDNA?.StatusElement;
            string dzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzj_);
            string[] dzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzm_ = context.Operators.In<string>(dzzzzzzzk_, dzzzzzzzl_ as IEnumerable<string>);
            List<CodeableConcept> dzzzzzzzn_ = FitDNA?.Category;
            bool? dzzzzzzzo_(CodeableConcept FitDNACategory)
            {
                List<Coding> ezzzzzzzk_ = FitDNACategory?.Coding;
                bool? ezzzzzzzl_(Coding @this)
                {
                    Code ezzzzzzzv_ = @this?.CodeElement;
                    bool? ezzzzzzzw_ = context.Operators.Not((bool?)(ezzzzzzzv_ is null));

                    return ezzzzzzzw_;
                };
                IEnumerable<Coding> ezzzzzzzm_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ezzzzzzzk_, ezzzzzzzl_);
                Code ezzzzzzzn_(Coding @this)
                {
                    Code ezzzzzzzx_ = @this?.CodeElement;

                    return ezzzzzzzx_;
                };
                IEnumerable<Code> ezzzzzzzo_ = context.Operators.Select<Coding, Code>(ezzzzzzzm_, ezzzzzzzn_);
                bool? ezzzzzzzp_(Code @this)
                {
                    string ezzzzzzzy_ = @this?.Value;
                    bool? ezzzzzzzz_ = context.Operators.Not((bool?)(ezzzzzzzy_ is null));

                    return ezzzzzzzz_;
                };
                IEnumerable<Code> ezzzzzzzq_ = context.Operators.Where<Code>(ezzzzzzzo_, ezzzzzzzp_);
                string ezzzzzzzr_(Code @this)
                {
                    string fzzzzzzza_ = @this?.Value;

                    return fzzzzzzza_;
                };
                IEnumerable<string> ezzzzzzzs_ = context.Operators.Select<Code, string>(ezzzzzzzq_, ezzzzzzzr_);
                string[] ezzzzzzzt_ = [
                    "laboratory",
                ];
                bool? ezzzzzzzu_ = context.Operators.Equivalent<string>(ezzzzzzzs_, ezzzzzzzt_ as IEnumerable<string>);

                return ezzzzzzzu_;
            };
            IEnumerable<CodeableConcept> dzzzzzzzp_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzzzzn_, dzzzzzzzo_);
            bool? dzzzzzzzq_ = context.Operators.Exists<CodeableConcept>(dzzzzzzzp_);
            bool? dzzzzzzzr_ = context.Operators.And(dzzzzzzzm_, dzzzzzzzq_);
            DataType dzzzzzzzs_ = FitDNA?.Value;
            bool? dzzzzzzzt_ = context.Operators.Not((bool?)(dzzzzzzzs_ is null));
            bool? dzzzzzzzu_ = context.Operators.And(dzzzzzzzr_, dzzzzzzzt_);
            DataType dzzzzzzzv_ = FitDNA?.Effective;
            CqlDateTime dzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, dzzzzzzzv_);
            CqlInterval<CqlDateTime> dzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzy_ = context.Operators.End(dzzzzzzzx_);
            CqlQuantity dzzzzzzzz_ = context.Operators.Quantity(3m, "years");
            CqlDateTime ezzzzzzza_ = context.Operators.Subtract(dzzzzzzzy_, dzzzzzzzz_);
            CqlDateTime ezzzzzzzc_ = context.Operators.End(dzzzzzzzx_);
            CqlInterval<CqlDateTime> ezzzzzzzd_ = context.Operators.Interval(ezzzzzzza_, ezzzzzzzc_, true, true);
            bool? ezzzzzzze_ = context.Operators.In<CqlDateTime>(dzzzzzzzw_, ezzzzzzzd_, "day");
            CqlDateTime ezzzzzzzg_ = context.Operators.End(dzzzzzzzx_);
            bool? ezzzzzzzh_ = context.Operators.Not((bool?)(ezzzzzzzg_ is null));
            bool? ezzzzzzzi_ = context.Operators.And(ezzzzzzze_, ezzzzzzzh_);
            bool? ezzzzzzzj_ = context.Operators.And(dzzzzzzzu_, ezzzzzzzi_);

            return ezzzzzzzj_;
        };
        IEnumerable<Observation> dzzzzzzzi_ = context.Operators.Where<Observation>(dzzzzzzzg_, dzzzzzzzh_);

        return dzzzzzzzi_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet fzzzzzzzb_ = this.FIT_DNA(context);
        IEnumerable<Observation> fzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? fzzzzzzzd_(Observation FitDNA)
        {
            List<CodeableConcept> fzzzzzzzf_ = FitDNA?.Category;
            bool? fzzzzzzzg_(CodeableConcept FitDNACategory)
            {
                List<Coding> gzzzzzzzb_ = FitDNACategory?.Coding;
                bool? gzzzzzzzc_(Coding @this)
                {
                    Code gzzzzzzzn_ = @this?.CodeElement;
                    bool? gzzzzzzzo_ = context.Operators.Not((bool?)(gzzzzzzzn_ is null));

                    return gzzzzzzzo_;
                };
                IEnumerable<Coding> gzzzzzzzd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)gzzzzzzzb_, gzzzzzzzc_);
                Code gzzzzzzze_(Coding @this)
                {
                    Code gzzzzzzzp_ = @this?.CodeElement;

                    return gzzzzzzzp_;
                };
                IEnumerable<Code> gzzzzzzzf_ = context.Operators.Select<Coding, Code>(gzzzzzzzd_, gzzzzzzze_);
                bool? gzzzzzzzg_(Code @this)
                {
                    string gzzzzzzzq_ = @this?.Value;
                    bool? gzzzzzzzr_ = context.Operators.Not((bool?)(gzzzzzzzq_ is null));

                    return gzzzzzzzr_;
                };
                IEnumerable<Code> gzzzzzzzh_ = context.Operators.Where<Code>(gzzzzzzzf_, gzzzzzzzg_);
                string gzzzzzzzi_(Code @this)
                {
                    string gzzzzzzzs_ = @this?.Value;

                    return gzzzzzzzs_;
                };
                IEnumerable<string> gzzzzzzzj_ = context.Operators.Select<Code, string>(gzzzzzzzh_, gzzzzzzzi_);
                string[] gzzzzzzzk_ = [
                    "laboratory",
                ];
                bool? gzzzzzzzl_ = context.Operators.Equivalent<string>(gzzzzzzzj_, gzzzzzzzk_ as IEnumerable<string>);
                bool? gzzzzzzzm_ = context.Operators.Not(gzzzzzzzl_);

                return gzzzzzzzm_;
            };
            IEnumerable<CodeableConcept> fzzzzzzzh_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzzzf_, fzzzzzzzg_);
            bool? fzzzzzzzi_ = context.Operators.Exists<CodeableConcept>(fzzzzzzzh_);
            DataType fzzzzzzzj_ = FitDNA?.Value;
            bool? fzzzzzzzk_ = context.Operators.Not((bool?)(fzzzzzzzj_ is null));
            bool? fzzzzzzzl_ = context.Operators.And(fzzzzzzzi_, fzzzzzzzk_);
            DataType fzzzzzzzm_ = FitDNA?.Effective;
            CqlDateTime fzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, fzzzzzzzm_);
            CqlInterval<CqlDateTime> fzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzp_ = context.Operators.End(fzzzzzzzo_);
            CqlQuantity fzzzzzzzq_ = context.Operators.Quantity(3m, "years");
            CqlDateTime fzzzzzzzr_ = context.Operators.Subtract(fzzzzzzzp_, fzzzzzzzq_);
            CqlDateTime fzzzzzzzt_ = context.Operators.End(fzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzu_ = context.Operators.Interval(fzzzzzzzr_, fzzzzzzzt_, true, true);
            bool? fzzzzzzzv_ = context.Operators.In<CqlDateTime>(fzzzzzzzn_, fzzzzzzzu_, "day");
            CqlDateTime fzzzzzzzx_ = context.Operators.End(fzzzzzzzo_);
            bool? fzzzzzzzy_ = context.Operators.Not((bool?)(fzzzzzzzx_ is null));
            bool? fzzzzzzzz_ = context.Operators.And(fzzzzzzzv_, fzzzzzzzy_);
            bool? gzzzzzzza_ = context.Operators.And(fzzzzzzzl_, fzzzzzzzz_);

            return gzzzzzzza_;
        };
        IEnumerable<Observation> fzzzzzzze_ = context.Operators.Where<Observation>(fzzzzzzzc_, fzzzzzzzd_);

        return fzzzzzzze_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet gzzzzzzzt_ = this.FIT_DNA(context);
        IEnumerable<Observation> gzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? gzzzzzzzv_(Observation FitDNA)
        {
            Code<ObservationStatus> gzzzzzzzx_ = FitDNA?.StatusElement;
            string gzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzx_);
            string[] gzzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzza_ = context.Operators.In<string>(gzzzzzzzy_, gzzzzzzzz_ as IEnumerable<string>);
            bool? hzzzzzzzb_ = context.Operators.Not(hzzzzzzza_);
            DataType hzzzzzzzc_ = FitDNA?.Value;
            bool? hzzzzzzzd_ = context.Operators.Not((bool?)(hzzzzzzzc_ is null));
            bool? hzzzzzzze_ = context.Operators.And(hzzzzzzzb_, hzzzzzzzd_);
            DataType hzzzzzzzf_ = FitDNA?.Effective;
            CqlDateTime hzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, hzzzzzzzf_);
            CqlInterval<CqlDateTime> hzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzi_ = context.Operators.End(hzzzzzzzh_);
            CqlQuantity hzzzzzzzj_ = context.Operators.Quantity(3m, "years");
            CqlDateTime hzzzzzzzk_ = context.Operators.Subtract(hzzzzzzzi_, hzzzzzzzj_);
            CqlDateTime hzzzzzzzm_ = context.Operators.End(hzzzzzzzh_);
            CqlInterval<CqlDateTime> hzzzzzzzn_ = context.Operators.Interval(hzzzzzzzk_, hzzzzzzzm_, true, true);
            bool? hzzzzzzzo_ = context.Operators.In<CqlDateTime>(hzzzzzzzg_, hzzzzzzzn_, "day");
            CqlDateTime hzzzzzzzq_ = context.Operators.End(hzzzzzzzh_);
            bool? hzzzzzzzr_ = context.Operators.Not((bool?)(hzzzzzzzq_ is null));
            bool? hzzzzzzzs_ = context.Operators.And(hzzzzzzzo_, hzzzzzzzr_);
            bool? hzzzzzzzt_ = context.Operators.And(hzzzzzzze_, hzzzzzzzs_);

            return hzzzzzzzt_;
        };
        IEnumerable<Observation> gzzzzzzzw_ = context.Operators.Where<Observation>(gzzzzzzzu_, gzzzzzzzv_);

        return gzzzzzzzw_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet hzzzzzzzu_ = this.CT_Colonography(context);
        IEnumerable<Observation> hzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? hzzzzzzzw_(Observation Colonography)
        {
            DataType izzzzzzzb_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> izzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzb_);
            CqlDateTime izzzzzzzd_ = context.Operators.End(izzzzzzzc_);
            CqlInterval<CqlDateTime> izzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzf_ = context.Operators.End(izzzzzzze_);
            CqlQuantity izzzzzzzg_ = context.Operators.Quantity(6m, "years");
            CqlDateTime izzzzzzzh_ = context.Operators.Subtract(izzzzzzzf_, izzzzzzzg_);
            CqlDateTime izzzzzzzj_ = context.Operators.End(izzzzzzze_);
            CqlInterval<CqlDateTime> izzzzzzzk_ = context.Operators.Interval(izzzzzzzh_, izzzzzzzj_, true, true);
            bool? izzzzzzzl_ = context.Operators.In<CqlDateTime>(izzzzzzzd_, izzzzzzzk_, default);
            CqlDateTime izzzzzzzn_ = context.Operators.End(izzzzzzze_);
            bool? izzzzzzzo_ = context.Operators.Not((bool?)(izzzzzzzn_ is null));
            bool? izzzzzzzp_ = context.Operators.And(izzzzzzzl_, izzzzzzzo_);

            return izzzzzzzp_;
        };
        IEnumerable<Observation> hzzzzzzzx_ = context.Operators.Where<Observation>(hzzzzzzzv_, hzzzzzzzw_);
        CqlDateTime hzzzzzzzy_(Observation Colonography)
        {
            DataType izzzzzzzq_ = Colonography?.Effective;
            CqlDateTime izzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, izzzzzzzq_);

            return izzzzzzzr_;
        };
        IEnumerable<CqlDateTime> hzzzzzzzz_ = context.Operators.Select<Observation, CqlDateTime>(hzzzzzzzx_, hzzzzzzzy_);
        IEnumerable<CqlDateTime> izzzzzzza_ = context.Operators.Distinct<CqlDateTime>(hzzzzzzzz_);

        return izzzzzzza_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet izzzzzzzs_ = this.CT_Colonography(context);
        IEnumerable<Observation> izzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? izzzzzzzu_(Observation Colonography)
        {
            Code<ObservationStatus> izzzzzzzw_ = Colonography?.StatusElement;
            string izzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzw_);
            string[] izzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? izzzzzzzz_ = context.Operators.In<string>(izzzzzzzx_, izzzzzzzy_ as IEnumerable<string>);
            DataType jzzzzzzza_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> jzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzza_);
            CqlDateTime jzzzzzzzc_ = context.Operators.End(jzzzzzzzb_);
            CqlInterval<CqlDateTime> jzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzze_ = context.Operators.End(jzzzzzzzd_);
            CqlQuantity jzzzzzzzf_ = context.Operators.Quantity(5m, "years");
            CqlDateTime jzzzzzzzg_ = context.Operators.Subtract(jzzzzzzze_, jzzzzzzzf_);
            CqlDateTime jzzzzzzzi_ = context.Operators.End(jzzzzzzzd_);
            CqlInterval<CqlDateTime> jzzzzzzzj_ = context.Operators.Interval(jzzzzzzzg_, jzzzzzzzi_, true, true);
            bool? jzzzzzzzk_ = context.Operators.In<CqlDateTime>(jzzzzzzzc_, jzzzzzzzj_, default);
            CqlDateTime jzzzzzzzm_ = context.Operators.End(jzzzzzzzd_);
            bool? jzzzzzzzn_ = context.Operators.Not((bool?)(jzzzzzzzm_ is null));
            bool? jzzzzzzzo_ = context.Operators.And(jzzzzzzzk_, jzzzzzzzn_);
            bool? jzzzzzzzp_ = context.Operators.And(izzzzzzzz_, jzzzzzzzo_);

            return jzzzzzzzp_;
        };
        IEnumerable<Observation> izzzzzzzv_ = context.Operators.Where<Observation>(izzzzzzzt_, izzzzzzzu_);

        return izzzzzzzv_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet jzzzzzzzq_ = this.CT_Colonography(context);
        IEnumerable<Observation> jzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? jzzzzzzzs_(Observation Colonography)
        {
            Code<ObservationStatus> jzzzzzzzu_ = Colonography?.StatusElement;
            string jzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzu_);
            string[] jzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? jzzzzzzzx_ = context.Operators.In<string>(jzzzzzzzv_, jzzzzzzzw_ as IEnumerable<string>);
            bool? jzzzzzzzy_ = context.Operators.Not(jzzzzzzzx_);
            DataType jzzzzzzzz_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> kzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzz_);
            CqlDateTime kzzzzzzzb_ = context.Operators.End(kzzzzzzza_);
            CqlInterval<CqlDateTime> kzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzd_ = context.Operators.End(kzzzzzzzc_);
            CqlQuantity kzzzzzzze_ = context.Operators.Quantity(5m, "years");
            CqlDateTime kzzzzzzzf_ = context.Operators.Subtract(kzzzzzzzd_, kzzzzzzze_);
            CqlDateTime kzzzzzzzh_ = context.Operators.End(kzzzzzzzc_);
            CqlInterval<CqlDateTime> kzzzzzzzi_ = context.Operators.Interval(kzzzzzzzf_, kzzzzzzzh_, true, true);
            bool? kzzzzzzzj_ = context.Operators.In<CqlDateTime>(kzzzzzzzb_, kzzzzzzzi_, default);
            CqlDateTime kzzzzzzzl_ = context.Operators.End(kzzzzzzzc_);
            bool? kzzzzzzzm_ = context.Operators.Not((bool?)(kzzzzzzzl_ is null));
            bool? kzzzzzzzn_ = context.Operators.And(kzzzzzzzj_, kzzzzzzzm_);
            bool? kzzzzzzzo_ = context.Operators.And(jzzzzzzzy_, kzzzzzzzn_);

            return kzzzzzzzo_;
        };
        IEnumerable<Observation> jzzzzzzzt_ = context.Operators.Where<Observation>(jzzzzzzzr_, jzzzzzzzs_);

        return jzzzzzzzt_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet kzzzzzzzp_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> kzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? kzzzzzzzr_(Procedure FlexibleSigmoidoscopy)
        {
            DataType kzzzzzzzw_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> kzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzw_);
            CqlDateTime kzzzzzzzy_ = context.Operators.End(kzzzzzzzx_);
            CqlInterval<CqlDateTime> kzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzza_ = context.Operators.End(kzzzzzzzz_);
            CqlQuantity lzzzzzzzb_ = context.Operators.Quantity(6m, "years");
            CqlDateTime lzzzzzzzc_ = context.Operators.Subtract(lzzzzzzza_, lzzzzzzzb_);
            CqlDateTime lzzzzzzze_ = context.Operators.End(kzzzzzzzz_);
            CqlInterval<CqlDateTime> lzzzzzzzf_ = context.Operators.Interval(lzzzzzzzc_, lzzzzzzze_, true, true);
            bool? lzzzzzzzg_ = context.Operators.In<CqlDateTime>(kzzzzzzzy_, lzzzzzzzf_, default);
            CqlDateTime lzzzzzzzi_ = context.Operators.End(kzzzzzzzz_);
            bool? lzzzzzzzj_ = context.Operators.Not((bool?)(lzzzzzzzi_ is null));
            bool? lzzzzzzzk_ = context.Operators.And(lzzzzzzzg_, lzzzzzzzj_);

            return lzzzzzzzk_;
        };
        IEnumerable<Procedure> kzzzzzzzs_ = context.Operators.Where<Procedure>(kzzzzzzzq_, kzzzzzzzr_);
        CqlDateTime kzzzzzzzt_(Procedure FlexibleSigmoidoscopy)
        {
            DataType lzzzzzzzl_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime lzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, lzzzzzzzl_);

            return lzzzzzzzm_;
        };
        IEnumerable<CqlDateTime> kzzzzzzzu_ = context.Operators.Select<Procedure, CqlDateTime>(kzzzzzzzs_, kzzzzzzzt_);
        IEnumerable<CqlDateTime> kzzzzzzzv_ = context.Operators.Distinct<CqlDateTime>(kzzzzzzzu_);

        return kzzzzzzzv_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet lzzzzzzzn_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> lzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? lzzzzzzzp_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> lzzzzzzzr_ = FlexibleSigmoidoscopy?.StatusElement;
            string lzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzr_);
            bool? lzzzzzzzt_ = context.Operators.Equal(lzzzzzzzs_, "completed");
            DataType lzzzzzzzu_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> lzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzu_);
            CqlDateTime lzzzzzzzw_ = context.Operators.End(lzzzzzzzv_);
            CqlInterval<CqlDateTime> lzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzy_ = context.Operators.End(lzzzzzzzx_);
            CqlQuantity lzzzzzzzz_ = context.Operators.Quantity(5m, "years");
            CqlDateTime mzzzzzzza_ = context.Operators.Subtract(lzzzzzzzy_, lzzzzzzzz_);
            CqlDateTime mzzzzzzzc_ = context.Operators.End(lzzzzzzzx_);
            CqlInterval<CqlDateTime> mzzzzzzzd_ = context.Operators.Interval(mzzzzzzza_, mzzzzzzzc_, true, true);
            bool? mzzzzzzze_ = context.Operators.In<CqlDateTime>(lzzzzzzzw_, mzzzzzzzd_, default);
            CqlDateTime mzzzzzzzg_ = context.Operators.End(lzzzzzzzx_);
            bool? mzzzzzzzh_ = context.Operators.Not((bool?)(mzzzzzzzg_ is null));
            bool? mzzzzzzzi_ = context.Operators.And(mzzzzzzze_, mzzzzzzzh_);
            bool? mzzzzzzzj_ = context.Operators.And(lzzzzzzzt_, mzzzzzzzi_);

            return mzzzzzzzj_;
        };
        IEnumerable<Procedure> lzzzzzzzq_ = context.Operators.Where<Procedure>(lzzzzzzzo_, lzzzzzzzp_);

        return lzzzzzzzq_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet mzzzzzzzk_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> mzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? mzzzzzzzm_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> mzzzzzzzo_ = FlexibleSigmoidoscopy?.StatusElement;
            string mzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzo_);
            bool? mzzzzzzzq_ = context.Operators.Equal(mzzzzzzzp_, "completed");
            bool? mzzzzzzzr_ = context.Operators.Not(mzzzzzzzq_);
            DataType mzzzzzzzs_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> mzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzzzzs_);
            CqlDateTime mzzzzzzzu_ = context.Operators.End(mzzzzzzzt_);
            CqlInterval<CqlDateTime> mzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzw_ = context.Operators.End(mzzzzzzzv_);
            CqlQuantity mzzzzzzzx_ = context.Operators.Quantity(5m, "years");
            CqlDateTime mzzzzzzzy_ = context.Operators.Subtract(mzzzzzzzw_, mzzzzzzzx_);
            CqlDateTime nzzzzzzza_ = context.Operators.End(mzzzzzzzv_);
            CqlInterval<CqlDateTime> nzzzzzzzb_ = context.Operators.Interval(mzzzzzzzy_, nzzzzzzza_, true, true);
            bool? nzzzzzzzc_ = context.Operators.In<CqlDateTime>(mzzzzzzzu_, nzzzzzzzb_, default);
            CqlDateTime nzzzzzzze_ = context.Operators.End(mzzzzzzzv_);
            bool? nzzzzzzzf_ = context.Operators.Not((bool?)(nzzzzzzze_ is null));
            bool? nzzzzzzzg_ = context.Operators.And(nzzzzzzzc_, nzzzzzzzf_);
            bool? nzzzzzzzh_ = context.Operators.And(mzzzzzzzr_, nzzzzzzzg_);

            return nzzzzzzzh_;
        };
        IEnumerable<Procedure> mzzzzzzzn_ = context.Operators.Where<Procedure>(mzzzzzzzl_, mzzzzzzzm_);

        return mzzzzzzzn_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet nzzzzzzzi_ = this.Colonoscopy(context);
        IEnumerable<Procedure> nzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? nzzzzzzzk_(Procedure Colonoscopy)
        {
            DataType nzzzzzzzp_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> nzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzp_);
            CqlDateTime nzzzzzzzr_ = context.Operators.End(nzzzzzzzq_);
            CqlInterval<CqlDateTime> nzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzt_ = context.Operators.End(nzzzzzzzs_);
            CqlQuantity nzzzzzzzu_ = context.Operators.Quantity(11m, "years");
            CqlDateTime nzzzzzzzv_ = context.Operators.Subtract(nzzzzzzzt_, nzzzzzzzu_);
            CqlDateTime nzzzzzzzx_ = context.Operators.End(nzzzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzzzy_ = context.Operators.Interval(nzzzzzzzv_, nzzzzzzzx_, true, true);
            bool? nzzzzzzzz_ = context.Operators.In<CqlDateTime>(nzzzzzzzr_, nzzzzzzzy_, default);
            CqlDateTime ozzzzzzzb_ = context.Operators.End(nzzzzzzzs_);
            bool? ozzzzzzzc_ = context.Operators.Not((bool?)(ozzzzzzzb_ is null));
            bool? ozzzzzzzd_ = context.Operators.And(nzzzzzzzz_, ozzzzzzzc_);

            return ozzzzzzzd_;
        };
        IEnumerable<Procedure> nzzzzzzzl_ = context.Operators.Where<Procedure>(nzzzzzzzj_, nzzzzzzzk_);
        CqlDateTime nzzzzzzzm_(Procedure Colonoscopy)
        {
            DataType ozzzzzzze_ = Colonoscopy?.Performed;
            CqlDateTime ozzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ozzzzzzze_);

            return ozzzzzzzf_;
        };
        IEnumerable<CqlDateTime> nzzzzzzzn_ = context.Operators.Select<Procedure, CqlDateTime>(nzzzzzzzl_, nzzzzzzzm_);
        IEnumerable<CqlDateTime> nzzzzzzzo_ = context.Operators.Distinct<CqlDateTime>(nzzzzzzzn_);

        return nzzzzzzzo_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet ozzzzzzzg_ = this.Colonoscopy(context);
        IEnumerable<Procedure> ozzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? ozzzzzzzi_(Procedure Colonoscopy)
        {
            Code<EventStatus> ozzzzzzzk_ = Colonoscopy?.StatusElement;
            string ozzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzk_);
            bool? ozzzzzzzm_ = context.Operators.Equal(ozzzzzzzl_, "completed");
            DataType ozzzzzzzn_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> ozzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzn_);
            CqlDateTime ozzzzzzzp_ = context.Operators.End(ozzzzzzzo_);
            CqlInterval<CqlDateTime> ozzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzr_ = context.Operators.End(ozzzzzzzq_);
            CqlQuantity ozzzzzzzs_ = context.Operators.Quantity(10m, "years");
            CqlDateTime ozzzzzzzt_ = context.Operators.Subtract(ozzzzzzzr_, ozzzzzzzs_);
            CqlDateTime ozzzzzzzv_ = context.Operators.End(ozzzzzzzq_);
            CqlInterval<CqlDateTime> ozzzzzzzw_ = context.Operators.Interval(ozzzzzzzt_, ozzzzzzzv_, true, true);
            bool? ozzzzzzzx_ = context.Operators.In<CqlDateTime>(ozzzzzzzp_, ozzzzzzzw_, default);
            CqlDateTime ozzzzzzzz_ = context.Operators.End(ozzzzzzzq_);
            bool? pzzzzzzza_ = context.Operators.Not((bool?)(ozzzzzzzz_ is null));
            bool? pzzzzzzzb_ = context.Operators.And(ozzzzzzzx_, pzzzzzzza_);
            bool? pzzzzzzzc_ = context.Operators.And(ozzzzzzzm_, pzzzzzzzb_);

            return pzzzzzzzc_;
        };
        IEnumerable<Procedure> ozzzzzzzj_ = context.Operators.Where<Procedure>(ozzzzzzzh_, ozzzzzzzi_);

        return ozzzzzzzj_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet pzzzzzzzd_ = this.Colonoscopy(context);
        IEnumerable<Procedure> pzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? pzzzzzzzf_(Procedure Colonoscopy)
        {
            Code<EventStatus> pzzzzzzzh_ = Colonoscopy?.StatusElement;
            string pzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzh_);
            bool? pzzzzzzzj_ = context.Operators.Equal(pzzzzzzzi_, "completed");
            bool? pzzzzzzzk_ = context.Operators.Not(pzzzzzzzj_);
            DataType pzzzzzzzl_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> pzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzl_);
            CqlDateTime pzzzzzzzn_ = context.Operators.End(pzzzzzzzm_);
            CqlInterval<CqlDateTime> pzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzp_ = context.Operators.End(pzzzzzzzo_);
            CqlQuantity pzzzzzzzq_ = context.Operators.Quantity(10m, "years");
            CqlDateTime pzzzzzzzr_ = context.Operators.Subtract(pzzzzzzzp_, pzzzzzzzq_);
            CqlDateTime pzzzzzzzt_ = context.Operators.End(pzzzzzzzo_);
            CqlInterval<CqlDateTime> pzzzzzzzu_ = context.Operators.Interval(pzzzzzzzr_, pzzzzzzzt_, true, true);
            bool? pzzzzzzzv_ = context.Operators.In<CqlDateTime>(pzzzzzzzn_, pzzzzzzzu_, default);
            CqlDateTime pzzzzzzzx_ = context.Operators.End(pzzzzzzzo_);
            bool? pzzzzzzzy_ = context.Operators.Not((bool?)(pzzzzzzzx_ is null));
            bool? pzzzzzzzz_ = context.Operators.And(pzzzzzzzv_, pzzzzzzzy_);
            bool? qzzzzzzza_ = context.Operators.And(pzzzzzzzk_, pzzzzzzzz_);

            return qzzzzzzza_;
        };
        IEnumerable<Procedure> pzzzzzzzg_ = context.Operators.Where<Procedure>(pzzzzzzze_, pzzzzzzzf_);

        return pzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> qzzzzzzzb_ = this.Colonoscopy_Performed(context);
        bool? qzzzzzzzc_ = context.Operators.Exists<Procedure>(qzzzzzzzb_);
        IEnumerable<Observation> qzzzzzzzd_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? qzzzzzzze_ = context.Operators.Exists<Observation>(qzzzzzzzd_);
        bool? qzzzzzzzf_ = context.Operators.Or(qzzzzzzzc_, qzzzzzzze_);
        IEnumerable<Procedure> qzzzzzzzg_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? qzzzzzzzh_ = context.Operators.Exists<Procedure>(qzzzzzzzg_);
        bool? qzzzzzzzi_ = context.Operators.Or(qzzzzzzzf_, qzzzzzzzh_);
        IEnumerable<Observation> qzzzzzzzj_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? qzzzzzzzk_ = context.Operators.Exists<Observation>(qzzzzzzzj_);
        bool? qzzzzzzzl_ = context.Operators.Or(qzzzzzzzi_, qzzzzzzzk_);
        IEnumerable<Observation> qzzzzzzzm_ = this.CT_Colonography_Performed(context);
        bool? qzzzzzzzn_ = context.Operators.Exists<Observation>(qzzzzzzzm_);
        bool? qzzzzzzzo_ = context.Operators.Or(qzzzzzzzl_, qzzzzzzzn_);

        return qzzzzzzzo_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? qzzzzzzzp_ = this.Numerator(context);
        bool? qzzzzzzzq_ = this.Initial_Population(context);
        bool? qzzzzzzzr_ = context.Operators.And(qzzzzzzzp_, qzzzzzzzq_);
        bool? qzzzzzzzs_ = this.Denominator(context);
        bool? qzzzzzzzt_ = context.Operators.And(qzzzzzzzr_, qzzzzzzzs_);
        bool? qzzzzzzzu_ = this.Denominator_Exclusions(context);
        bool? qzzzzzzzv_ = context.Operators.Not(qzzzzzzzu_);
        bool? qzzzzzzzw_ = context.Operators.And(qzzzzzzzt_, qzzzzzzzv_);

        return qzzzzzzzw_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
