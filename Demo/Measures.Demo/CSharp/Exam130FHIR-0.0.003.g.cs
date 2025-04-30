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
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _laboratory]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime tzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime tzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzv_ = context.Operators.Interval(tzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzu_, true, false);
        object tzzzzzzzzzzzzzzw_ = context.ResolveParameter("Exam130FHIR-0.0.003", "Measurement Period", tzzzzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient tzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzx_);

        return tzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> tzzzzzzzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return tzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> uzzzzzzzzzzzzzza_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> uzzzzzzzzzzzzzzb_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return uzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return uzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzd_ = this.Online_Assessments(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet uzzzzzzzzzzzzzzf_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzg_);
        bool? uzzzzzzzzzzzzzzi_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzk_ = TelehealthEncounter?.StatusElement;
            string uzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzm_ = context.Operators.Equal(uzzzzzzzzzzzzzzl_, "finished");
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            Period uzzzzzzzzzzzzzzo_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzzzzzzzzzzzo_ as object);
            bool? uzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzp_, default);
            bool? uzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzq_);

            return uzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzi_);

        return uzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient uzzzzzzzzzzzzzzs_ = this.Patient(context);
        Date uzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzs_?.BirthDateElement;
        string uzzzzzzzzzzzzzzu_ = uzzzzzzzzzzzzzzt_?.Value;
        CqlDate uzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzzzzzzw_);
        CqlDate uzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzx_);
        int? uzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzy_, "year");

        return uzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient vzzzzzzzzzzzzzza_ = this.Patient(context);
        Date vzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzza_?.BirthDateElement;
        string vzzzzzzzzzzzzzzc_ = vzzzzzzzzzzzzzzb_?.Value;
        CqlDate vzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzzzzze_);
        CqlDate vzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzf_);
        int? vzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> vzzzzzzzzzzzzzzi_ = context.Operators.Interval(51, 75, true, false);
        bool? vzzzzzzzzzzzzzzj_ = context.Operators.In<int?>(vzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzi_, default);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzk_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzl_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzl_);
        bool? vzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzzm_);
        bool? vzzzzzzzzzzzzzzo_ = context.Operators.And(vzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzn_);

        return vzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return vzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzq_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? vzzzzzzzzzzzzzzs_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime vzzzzzzzzzzzzzzv_ = context.Operators.Start(vzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzx_ = context.Operators.End(vzzzzzzzzzzzzzzw_);
            bool? vzzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzx_, default);

            return vzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzs_);

        return vzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzz_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? wzzzzzzzzzzzzzzb_(Procedure Colectomy)
        {
            Code<EventStatus> wzzzzzzzzzzzzzzd_ = Colectomy?.StatusElement;
            string wzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzd_);
            bool? wzzzzzzzzzzzzzzf_ = context.Operators.Equal(wzzzzzzzzzzzzzze_, "completed");
            DataType wzzzzzzzzzzzzzzg_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzzzzzzzzzzg_);
            CqlDateTime wzzzzzzzzzzzzzzi_ = context.Operators.End(wzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzk_ = context.Operators.End(wzzzzzzzzzzzzzzj_);
            bool? wzzzzzzzzzzzzzzl_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzk_, default);
            bool? wzzzzzzzzzzzzzzm_ = context.Operators.And(wzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzl_);

            return wzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzb_);

        return wzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzn_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? wzzzzzzzzzzzzzzp_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime wzzzzzzzzzzzzzzs_ = context.Operators.Start(wzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzu_ = context.Operators.End(wzzzzzzzzzzzzzzt_);
            bool? wzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzu_, default);

            return wzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzp_);

        return wzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzw_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzx_ = this.Malignant_Neoplasm(context);
        bool? wzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzx_);
        bool? wzzzzzzzzzzzzzzz_ = context.Operators.Or(wzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzy_);
        IEnumerable<Procedure> xzzzzzzzzzzzzzza_ = this.Total_Colectomy_Performed(context);
        bool? xzzzzzzzzzzzzzzb_ = context.Operators.Exists<Procedure>(xzzzzzzzzzzzzzza_);
        bool? xzzzzzzzzzzzzzzc_ = context.Operators.Or(wzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> xzzzzzzzzzzzzzzd_ = this.Total_Colectomy_Condition(context);
        bool? xzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzzzd_);
        bool? xzzzzzzzzzzzzzzf_ = context.Operators.Or(xzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzze_);
        bool? xzzzzzzzzzzzzzzg_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? xzzzzzzzzzzzzzzh_ = context.Operators.Or(xzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzg_);
        Patient xzzzzzzzzzzzzzzi_ = this.Patient(context);
        Date xzzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzzi_?.BirthDateElement;
        string xzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzj_?.Value;
        CqlDate xzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime xzzzzzzzzzzzzzzn_ = context.Operators.Start(xzzzzzzzzzzzzzzm_);
        CqlDate xzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzn_);
        int? xzzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzo_, "year");
        bool? xzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzp_, 65);
        bool? xzzzzzzzzzzzzzzr_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? xzzzzzzzzzzzzzzs_ = context.Operators.And(xzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzr_);
        bool? xzzzzzzzzzzzzzzt_ = context.Operators.Or(xzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzs_);
        bool? xzzzzzzzzzzzzzzu_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzzv_ = context.Operators.Or(xzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzu_);

        return xzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzw_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzzzzzzzzzzy_(Observation FecalOccult)
        {
            DataType yzzzzzzzzzzzzzzd_ = FecalOccult?.Effective;
            CqlDateTime yzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, yzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzg_ = context.Operators.Start(yzzzzzzzzzzzzzzf_);
            CqlQuantity yzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "year");
            CqlDateTime yzzzzzzzzzzzzzzi_ = context.Operators.Subtract(yzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzh_);
            CqlDateTime yzzzzzzzzzzzzzzk_ = context.Operators.End(yzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzl_ = context.Operators.Interval(yzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzk_, false, false);
            bool? yzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzl_, default);

            return yzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? yzzzzzzzzzzzzzza_(Observation FecalOccult)
        {
            DataType yzzzzzzzzzzzzzzn_ = FecalOccult?.Effective;
            CqlDateTime yzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, yzzzzzzzzzzzzzzn_);
            DataType yzzzzzzzzzzzzzzp_ = FecalOccult?.Value;
            IEnumerable<Coding> yzzzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(yzzzzzzzzzzzzzzp_, "coding");
            bool? yzzzzzzzzzzzzzzr_(Coding @this)
            {
                FhirString zzzzzzzzzzzzzzzl_ = @this?.DisplayElement;
                bool? zzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzl_ is null));

                return zzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Coding> yzzzzzzzzzzzzzzs_ = context.Operators.Where<Coding>(yzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzr_);
            FhirString yzzzzzzzzzzzzzzt_(Coding @this)
            {
                FhirString zzzzzzzzzzzzzzzn_ = @this?.DisplayElement;

                return zzzzzzzzzzzzzzzn_;
            };
            IEnumerable<FhirString> yzzzzzzzzzzzzzzu_ = context.Operators.Select<Coding, FhirString>(yzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzt_);
            List<CodeableConcept> yzzzzzzzzzzzzzzv_ = FecalOccult?.Category;
            bool? yzzzzzzzzzzzzzzw_(CodeableConcept @this)
            {
                List<Coding> zzzzzzzzzzzzzzzo_ = @this?.Coding;
                bool? zzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzo_ is null));

                return zzzzzzzzzzzzzzzp_;
            };
            IEnumerable<CodeableConcept> yzzzzzzzzzzzzzzx_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzw_);
            List<Coding> yzzzzzzzzzzzzzzy_(CodeableConcept @this)
            {
                List<Coding> zzzzzzzzzzzzzzzq_ = @this?.Coding;

                return zzzzzzzzzzzzzzzq_;
            };
            IEnumerable<List<Coding>> yzzzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, List<Coding>>(yzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzy_);
            IEnumerable<Coding> zzzzzzzzzzzzzzza_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)yzzzzzzzzzzzzzzz_);
            bool? zzzzzzzzzzzzzzzb_(Coding @this)
            {
                Code zzzzzzzzzzzzzzzr_ = @this?.CodeElement;
                bool? zzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzr_ is null));

                return zzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Coding> zzzzzzzzzzzzzzzc_ = context.Operators.Where<Coding>(zzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzb_);
            Code zzzzzzzzzzzzzzzd_(Coding @this)
            {
                Code zzzzzzzzzzzzzzzt_ = @this?.CodeElement;

                return zzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Code> zzzzzzzzzzzzzzze_ = context.Operators.Select<Coding, Code>(zzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzd_);
            bool? zzzzzzzzzzzzzzzf_(Code @this)
            {
                string zzzzzzzzzzzzzzzu_ = @this?.Value;
                bool? zzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzu_ is null));

                return zzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Code> zzzzzzzzzzzzzzzg_ = context.Operators.Where<Code>(zzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzf_);
            string zzzzzzzzzzzzzzzh_(Code @this)
            {
                string zzzzzzzzzzzzzzzw_ = @this?.Value;

                return zzzzzzzzzzzzzzzw_;
            };
            IEnumerable<string> zzzzzzzzzzzzzzzi_ = context.Operators.Select<Code, string>(zzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzh_);
            Code<ObservationStatus> zzzzzzzzzzzzzzzj_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? zzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, yzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzj_);

            return zzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> yzzzzzzzzzzzzzzb_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(xzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> yzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(yzzzzzzzzzzzzzzb_);

        return yzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzx_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> zzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzzzzzzzzzzz_(Observation FecalOccult)
        {
            Code<ObservationStatus> azzzzzzzzzzzzzzzb_ = FecalOccult?.StatusElement;
            string azzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzzb_);
            string[] azzzzzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzzzzzzzzzzzze_ = context.Operators.In<string>(azzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzd_ as IEnumerable<string>);
            List<CodeableConcept> azzzzzzzzzzzzzzzf_ = FecalOccult?.Category;
            bool? azzzzzzzzzzzzzzzg_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> azzzzzzzzzzzzzzzs_ = FecalOccultCategory?.Coding;
                bool? azzzzzzzzzzzzzzzt_(Coding @this)
                {
                    Code bzzzzzzzzzzzzzzzd_ = @this?.CodeElement;
                    bool? bzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzd_ is null));

                    return bzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Coding> azzzzzzzzzzzzzzzu_ = context.Operators.Where<Coding>((IEnumerable<Coding>)azzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzt_);
                Code azzzzzzzzzzzzzzzv_(Coding @this)
                {
                    Code bzzzzzzzzzzzzzzzf_ = @this?.CodeElement;

                    return bzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Code> azzzzzzzzzzzzzzzw_ = context.Operators.Select<Coding, Code>(azzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzv_);
                bool? azzzzzzzzzzzzzzzx_(Code @this)
                {
                    string bzzzzzzzzzzzzzzzg_ = @this?.Value;
                    bool? bzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzg_ is null));

                    return bzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Code> azzzzzzzzzzzzzzzy_ = context.Operators.Where<Code>(azzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzx_);
                string azzzzzzzzzzzzzzzz_(Code @this)
                {
                    string bzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return bzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<string> bzzzzzzzzzzzzzzza_ = context.Operators.Select<Code, string>(azzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzz_);
                string[] bzzzzzzzzzzzzzzzb_ = [
                    "laboratory",
                ];
                bool? bzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent<string>(bzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzb_ as IEnumerable<string>);

                return bzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CodeableConcept> azzzzzzzzzzzzzzzh_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzg_);
            bool? azzzzzzzzzzzzzzzi_ = context.Operators.Exists<CodeableConcept>(azzzzzzzzzzzzzzzh_);
            bool? azzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzi_);
            DataType azzzzzzzzzzzzzzzk_ = FecalOccult?.Value;
            bool? azzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzk_ is null));
            bool? azzzzzzzzzzzzzzzm_ = context.Operators.And(azzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzl_);
            DataType azzzzzzzzzzzzzzzn_ = FecalOccult?.Effective;
            CqlDateTime azzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, azzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzp_, default);
            bool? azzzzzzzzzzzzzzzr_ = context.Operators.And(azzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzq_);

            return azzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzz_);

        return azzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzj_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzzzzzzzzzl_(Observation FecalOccult)
        {
            Code<ObservationStatus> bzzzzzzzzzzzzzzzn_ = FecalOccult?.StatusElement;
            string bzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzn_);
            string[] bzzzzzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            List<CodeableConcept> bzzzzzzzzzzzzzzzr_ = FecalOccult?.Category;
            bool? bzzzzzzzzzzzzzzzs_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> czzzzzzzzzzzzzzze_ = FecalOccultCategory?.Coding;
                bool? czzzzzzzzzzzzzzzf_(Coding @this)
                {
                    Code czzzzzzzzzzzzzzzp_ = @this?.CodeElement;
                    bool? czzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzp_ is null));

                    return czzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Coding> czzzzzzzzzzzzzzzg_ = context.Operators.Where<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzf_);
                Code czzzzzzzzzzzzzzzh_(Coding @this)
                {
                    Code czzzzzzzzzzzzzzzr_ = @this?.CodeElement;

                    return czzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Code> czzzzzzzzzzzzzzzi_ = context.Operators.Select<Coding, Code>(czzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzh_);
                bool? czzzzzzzzzzzzzzzj_(Code @this)
                {
                    string czzzzzzzzzzzzzzzs_ = @this?.Value;
                    bool? czzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzs_ is null));

                    return czzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Code> czzzzzzzzzzzzzzzk_ = context.Operators.Where<Code>(czzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzj_);
                string czzzzzzzzzzzzzzzl_(Code @this)
                {
                    string czzzzzzzzzzzzzzzu_ = @this?.Value;

                    return czzzzzzzzzzzzzzzu_;
                };
                IEnumerable<string> czzzzzzzzzzzzzzzm_ = context.Operators.Select<Code, string>(czzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzl_);
                string[] czzzzzzzzzzzzzzzn_ = [
                    "laboratory",
                ];
                bool? czzzzzzzzzzzzzzzo_ = context.Operators.Equivalent<string>(czzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzn_ as IEnumerable<string>);

                return czzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CodeableConcept> bzzzzzzzzzzzzzzzt_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzs_);
            bool? bzzzzzzzzzzzzzzzu_ = context.Operators.Exists<CodeableConcept>(bzzzzzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzzzzzv_ = context.Operators.And(bzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzu_);
            DataType bzzzzzzzzzzzzzzzw_ = FecalOccult?.Value;
            bool? bzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzw_ is null));
            bool? bzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzx_);
            DataType bzzzzzzzzzzzzzzzz_ = FecalOccult?.Effective;
            CqlDateTime czzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, bzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzb_, "day");
            bool? czzzzzzzzzzzzzzzd_ = context.Operators.And(bzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzc_);

            return czzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzl_);

        return bzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzv_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzzzzzzzzzzzzzx_(Observation FecalOccult)
        {
            List<CodeableConcept> czzzzzzzzzzzzzzzz_ = FecalOccult?.Category;
            bool? dzzzzzzzzzzzzzzza_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> dzzzzzzzzzzzzzzzl_ = FecalOccultCategory?.Coding;
                bool? dzzzzzzzzzzzzzzzm_(Coding @this)
                {
                    Code dzzzzzzzzzzzzzzzx_ = @this?.CodeElement;
                    bool? dzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzx_ is null));

                    return dzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Coding> dzzzzzzzzzzzzzzzn_ = context.Operators.Where<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzm_);
                Code dzzzzzzzzzzzzzzzo_(Coding @this)
                {
                    Code dzzzzzzzzzzzzzzzz_ = @this?.CodeElement;

                    return dzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Code> dzzzzzzzzzzzzzzzp_ = context.Operators.Select<Coding, Code>(dzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzo_);
                bool? dzzzzzzzzzzzzzzzq_(Code @this)
                {
                    string ezzzzzzzzzzzzzzza_ = @this?.Value;
                    bool? ezzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzza_ is null));

                    return ezzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Code> dzzzzzzzzzzzzzzzr_ = context.Operators.Where<Code>(dzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzq_);
                string dzzzzzzzzzzzzzzzs_(Code @this)
                {
                    string ezzzzzzzzzzzzzzzc_ = @this?.Value;

                    return ezzzzzzzzzzzzzzzc_;
                };
                IEnumerable<string> dzzzzzzzzzzzzzzzt_ = context.Operators.Select<Code, string>(dzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzs_);
                string[] dzzzzzzzzzzzzzzzu_ = [
                    "laboratory",
                ];
                bool? dzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent<string>(dzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzw_ = context.Operators.Not(dzzzzzzzzzzzzzzzv_);

                return dzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CodeableConcept> dzzzzzzzzzzzzzzzb_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzza_);
            bool? dzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CodeableConcept>(dzzzzzzzzzzzzzzzb_);
            DataType dzzzzzzzzzzzzzzzd_ = FecalOccult?.Value;
            bool? dzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzd_ is null));
            bool? dzzzzzzzzzzzzzzzf_ = context.Operators.And(dzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzze_);
            DataType dzzzzzzzzzzzzzzzg_ = FecalOccult?.Effective;
            CqlDateTime dzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, dzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzi_, "day");
            bool? dzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzj_);

            return dzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzx_);

        return czzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzd_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzzzzzzzzzzzf_(Observation FecalOccult)
        {
            Code<ObservationStatus> ezzzzzzzzzzzzzzzh_ = FecalOccult?.StatusElement;
            string ezzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzh_);
            string[] ezzzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzzzzzzzzzzzzzk_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzzzl_ = context.Operators.Not(ezzzzzzzzzzzzzzzk_);
            DataType ezzzzzzzzzzzzzzzm_ = FecalOccult?.Value;
            bool? ezzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzm_ is null));
            bool? ezzzzzzzzzzzzzzzo_ = context.Operators.And(ezzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzn_);
            DataType ezzzzzzzzzzzzzzzp_ = FecalOccult?.Effective;
            CqlDateTime ezzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ezzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzr_, "day");
            bool? ezzzzzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzf_);

        return ezzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzu_ = this.FIT_DNA(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzzzzzzzzzzzw_(Observation FitDNA)
        {
            DataType fzzzzzzzzzzzzzzzb_ = FitDNA?.Effective;
            CqlDateTime fzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, fzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzze_ = context.Operators.End(fzzzzzzzzzzzzzzzd_);
            CqlQuantity fzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(4m, "years");
            CqlDateTime fzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(fzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzf_);
            CqlDateTime fzzzzzzzzzzzzzzzi_ = context.Operators.End(fzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzj_ = context.Operators.Interval(fzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzi_, true, true);
            bool? fzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzj_, default);
            CqlDateTime fzzzzzzzzzzzzzzzm_ = context.Operators.End(fzzzzzzzzzzzzzzzd_);
            bool? fzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzm_ is null));
            bool? fzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzn_);

            return fzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzw_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? ezzzzzzzzzzzzzzzy_(Observation FitDNA)
        {
            DataType fzzzzzzzzzzzzzzzp_ = FitDNA?.Effective;
            CqlDateTime fzzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, fzzzzzzzzzzzzzzzp_);
            DataType fzzzzzzzzzzzzzzzr_ = FitDNA?.Value;
            IEnumerable<Coding> fzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(fzzzzzzzzzzzzzzzr_, "coding");
            bool? fzzzzzzzzzzzzzzzt_(Coding @this)
            {
                FhirString gzzzzzzzzzzzzzzzn_ = @this?.DisplayElement;
                bool? gzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzn_ is null));

                return gzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Coding> fzzzzzzzzzzzzzzzu_ = context.Operators.Where<Coding>(fzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzt_);
            FhirString fzzzzzzzzzzzzzzzv_(Coding @this)
            {
                FhirString gzzzzzzzzzzzzzzzp_ = @this?.DisplayElement;

                return gzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<FhirString> fzzzzzzzzzzzzzzzw_ = context.Operators.Select<Coding, FhirString>(fzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzv_);
            List<CodeableConcept> fzzzzzzzzzzzzzzzx_ = FitDNA?.Category;
            bool? fzzzzzzzzzzzzzzzy_(CodeableConcept @this)
            {
                List<Coding> gzzzzzzzzzzzzzzzq_ = @this?.Coding;
                bool? gzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzq_ is null));

                return gzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CodeableConcept> fzzzzzzzzzzzzzzzz_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzy_);
            List<Coding> gzzzzzzzzzzzzzzza_(CodeableConcept @this)
            {
                List<Coding> gzzzzzzzzzzzzzzzs_ = @this?.Coding;

                return gzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<List<Coding>> gzzzzzzzzzzzzzzzb_ = context.Operators.Select<CodeableConcept, List<Coding>>(fzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzza_);
            IEnumerable<Coding> gzzzzzzzzzzzzzzzc_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)gzzzzzzzzzzzzzzzb_);
            bool? gzzzzzzzzzzzzzzzd_(Coding @this)
            {
                Code gzzzzzzzzzzzzzzzt_ = @this?.CodeElement;
                bool? gzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzt_ is null));

                return gzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Coding> gzzzzzzzzzzzzzzze_ = context.Operators.Where<Coding>(gzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzd_);
            Code gzzzzzzzzzzzzzzzf_(Coding @this)
            {
                Code gzzzzzzzzzzzzzzzv_ = @this?.CodeElement;

                return gzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Code> gzzzzzzzzzzzzzzzg_ = context.Operators.Select<Coding, Code>(gzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzf_);
            bool? gzzzzzzzzzzzzzzzh_(Code @this)
            {
                string gzzzzzzzzzzzzzzzw_ = @this?.Value;
                bool? gzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzw_ is null));

                return gzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Code> gzzzzzzzzzzzzzzzi_ = context.Operators.Where<Code>(gzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzh_);
            string gzzzzzzzzzzzzzzzj_(Code @this)
            {
                string gzzzzzzzzzzzzzzzy_ = @this?.Value;

                return gzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<string> gzzzzzzzzzzzzzzzk_ = context.Operators.Select<Code, string>(gzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzj_);
            Code<ObservationStatus> gzzzzzzzzzzzzzzzl_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? gzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, fzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzl_);

            return gzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> ezzzzzzzzzzzzzzzz_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(ezzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> fzzzzzzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(ezzzzzzzzzzzzzzzz_);

        return fzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzz_ = this.FIT_DNA(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? hzzzzzzzzzzzzzzzb_(Observation FitDNA)
        {
            Code<ObservationStatus> hzzzzzzzzzzzzzzzd_ = FitDNA?.StatusElement;
            string hzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzzzd_);
            string[] hzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(hzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            List<CodeableConcept> hzzzzzzzzzzzzzzzh_ = FitDNA?.Category;
            bool? hzzzzzzzzzzzzzzzi_(CodeableConcept FitDNACategory)
            {
                List<Coding> izzzzzzzzzzzzzzze_ = FitDNACategory?.Coding;
                bool? izzzzzzzzzzzzzzzf_(Coding @this)
                {
                    Code izzzzzzzzzzzzzzzp_ = @this?.CodeElement;
                    bool? izzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzp_ is null));

                    return izzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Coding> izzzzzzzzzzzzzzzg_ = context.Operators.Where<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzf_);
                Code izzzzzzzzzzzzzzzh_(Coding @this)
                {
                    Code izzzzzzzzzzzzzzzr_ = @this?.CodeElement;

                    return izzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Code> izzzzzzzzzzzzzzzi_ = context.Operators.Select<Coding, Code>(izzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzh_);
                bool? izzzzzzzzzzzzzzzj_(Code @this)
                {
                    string izzzzzzzzzzzzzzzs_ = @this?.Value;
                    bool? izzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzs_ is null));

                    return izzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Code> izzzzzzzzzzzzzzzk_ = context.Operators.Where<Code>(izzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzj_);
                string izzzzzzzzzzzzzzzl_(Code @this)
                {
                    string izzzzzzzzzzzzzzzu_ = @this?.Value;

                    return izzzzzzzzzzzzzzzu_;
                };
                IEnumerable<string> izzzzzzzzzzzzzzzm_ = context.Operators.Select<Code, string>(izzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzl_);
                string[] izzzzzzzzzzzzzzzn_ = [
                    "laboratory",
                ];
                bool? izzzzzzzzzzzzzzzo_ = context.Operators.Equivalent<string>(izzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzn_ as IEnumerable<string>);

                return izzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CodeableConcept> hzzzzzzzzzzzzzzzj_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzi_);
            bool? hzzzzzzzzzzzzzzzk_ = context.Operators.Exists<CodeableConcept>(hzzzzzzzzzzzzzzzj_);
            bool? hzzzzzzzzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzk_);
            DataType hzzzzzzzzzzzzzzzm_ = FitDNA?.Value;
            bool? hzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzm_ is null));
            bool? hzzzzzzzzzzzzzzzo_ = context.Operators.And(hzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzn_);
            DataType hzzzzzzzzzzzzzzzp_ = FitDNA?.Effective;
            CqlDateTime hzzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, hzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzs_ = context.Operators.End(hzzzzzzzzzzzzzzzr_);
            CqlQuantity hzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(3m, "years");
            CqlDateTime hzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzt_);
            CqlDateTime hzzzzzzzzzzzzzzzw_ = context.Operators.End(hzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzx_ = context.Operators.Interval(hzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzw_, true, true);
            bool? hzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzx_, default);
            CqlDateTime izzzzzzzzzzzzzzza_ = context.Operators.End(hzzzzzzzzzzzzzzzr_);
            bool? izzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzza_ is null));
            bool? izzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzb_);
            bool? izzzzzzzzzzzzzzzd_ = context.Operators.And(hzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzc_);

            return izzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzb_);

        return hzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzv_ = this.FIT_DNA(context);
        IEnumerable<Observation> izzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? izzzzzzzzzzzzzzzx_(Observation FitDNA)
        {
            Code<ObservationStatus> izzzzzzzzzzzzzzzz_ = FitDNA?.StatusElement;
            string jzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzz_);
            string[] jzzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(jzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            List<CodeableConcept> jzzzzzzzzzzzzzzzd_ = FitDNA?.Category;
            bool? jzzzzzzzzzzzzzzze_(CodeableConcept FitDNACategory)
            {
                List<Coding> kzzzzzzzzzzzzzzza_ = FitDNACategory?.Coding;
                bool? kzzzzzzzzzzzzzzzb_(Coding @this)
                {
                    Code kzzzzzzzzzzzzzzzl_ = @this?.CodeElement;
                    bool? kzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzl_ is null));

                    return kzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<Coding> kzzzzzzzzzzzzzzzc_ = context.Operators.Where<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzb_);
                Code kzzzzzzzzzzzzzzzd_(Coding @this)
                {
                    Code kzzzzzzzzzzzzzzzn_ = @this?.CodeElement;

                    return kzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Code> kzzzzzzzzzzzzzzze_ = context.Operators.Select<Coding, Code>(kzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzd_);
                bool? kzzzzzzzzzzzzzzzf_(Code @this)
                {
                    string kzzzzzzzzzzzzzzzo_ = @this?.Value;
                    bool? kzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzo_ is null));

                    return kzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Code> kzzzzzzzzzzzzzzzg_ = context.Operators.Where<Code>(kzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzf_);
                string kzzzzzzzzzzzzzzzh_(Code @this)
                {
                    string kzzzzzzzzzzzzzzzq_ = @this?.Value;

                    return kzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<string> kzzzzzzzzzzzzzzzi_ = context.Operators.Select<Code, string>(kzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzh_);
                string[] kzzzzzzzzzzzzzzzj_ = [
                    "laboratory",
                ];
                bool? kzzzzzzzzzzzzzzzk_ = context.Operators.Equivalent<string>(kzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzj_ as IEnumerable<string>);

                return kzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CodeableConcept> jzzzzzzzzzzzzzzzf_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzze_);
            bool? jzzzzzzzzzzzzzzzg_ = context.Operators.Exists<CodeableConcept>(jzzzzzzzzzzzzzzzf_);
            bool? jzzzzzzzzzzzzzzzh_ = context.Operators.And(jzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzg_);
            DataType jzzzzzzzzzzzzzzzi_ = FitDNA?.Value;
            bool? jzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzi_ is null));
            bool? jzzzzzzzzzzzzzzzk_ = context.Operators.And(jzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzj_);
            DataType jzzzzzzzzzzzzzzzl_ = FitDNA?.Effective;
            CqlDateTime jzzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, jzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzo_ = context.Operators.End(jzzzzzzzzzzzzzzzn_);
            CqlQuantity jzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(3m, "years");
            CqlDateTime jzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzp_);
            CqlDateTime jzzzzzzzzzzzzzzzs_ = context.Operators.End(jzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzt_ = context.Operators.Interval(jzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzs_, true, true);
            bool? jzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzt_, "day");
            CqlDateTime jzzzzzzzzzzzzzzzw_ = context.Operators.End(jzzzzzzzzzzzzzzzn_);
            bool? jzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzw_ is null));
            bool? jzzzzzzzzzzzzzzzy_ = context.Operators.And(jzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzx_);
            bool? jzzzzzzzzzzzzzzzz_ = context.Operators.And(jzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzy_);

            return jzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzx_);

        return izzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzr_ = this.FIT_DNA(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzzzzzzzzzzzzzzt_(Observation FitDNA)
        {
            List<CodeableConcept> kzzzzzzzzzzzzzzzv_ = FitDNA?.Category;
            bool? kzzzzzzzzzzzzzzzw_(CodeableConcept FitDNACategory)
            {
                List<Coding> lzzzzzzzzzzzzzzzr_ = FitDNACategory?.Coding;
                bool? lzzzzzzzzzzzzzzzs_(Coding @this)
                {
                    Code mzzzzzzzzzzzzzzzd_ = @this?.CodeElement;
                    bool? mzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzd_ is null));

                    return mzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Coding> lzzzzzzzzzzzzzzzt_ = context.Operators.Where<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzs_);
                Code lzzzzzzzzzzzzzzzu_(Coding @this)
                {
                    Code mzzzzzzzzzzzzzzzf_ = @this?.CodeElement;

                    return mzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Code> lzzzzzzzzzzzzzzzv_ = context.Operators.Select<Coding, Code>(lzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzu_);
                bool? lzzzzzzzzzzzzzzzw_(Code @this)
                {
                    string mzzzzzzzzzzzzzzzg_ = @this?.Value;
                    bool? mzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzg_ is null));

                    return mzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Code> lzzzzzzzzzzzzzzzx_ = context.Operators.Where<Code>(lzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzw_);
                string lzzzzzzzzzzzzzzzy_(Code @this)
                {
                    string mzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return mzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<string> lzzzzzzzzzzzzzzzz_ = context.Operators.Select<Code, string>(lzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzy_);
                string[] mzzzzzzzzzzzzzzza_ = [
                    "laboratory",
                ];
                bool? mzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent<string>(lzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzc_ = context.Operators.Not(mzzzzzzzzzzzzzzzb_);

                return mzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CodeableConcept> kzzzzzzzzzzzzzzzx_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzzzzzy_ = context.Operators.Exists<CodeableConcept>(kzzzzzzzzzzzzzzzx_);
            DataType kzzzzzzzzzzzzzzzz_ = FitDNA?.Value;
            bool? lzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzz_ is null));
            bool? lzzzzzzzzzzzzzzzb_ = context.Operators.And(kzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzza_);
            DataType lzzzzzzzzzzzzzzzc_ = FitDNA?.Effective;
            CqlDateTime lzzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, lzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzf_ = context.Operators.End(lzzzzzzzzzzzzzzze_);
            CqlQuantity lzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(3m, "years");
            CqlDateTime lzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzg_);
            CqlDateTime lzzzzzzzzzzzzzzzj_ = context.Operators.End(lzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzk_ = context.Operators.Interval(lzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzj_, true, true);
            bool? lzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzk_, "day");
            CqlDateTime lzzzzzzzzzzzzzzzn_ = context.Operators.End(lzzzzzzzzzzzzzzze_);
            bool? lzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzn_ is null));
            bool? lzzzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzo_);
            bool? lzzzzzzzzzzzzzzzq_ = context.Operators.And(lzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzp_);

            return lzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzt_);

        return kzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzj_ = this.FIT_DNA(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? mzzzzzzzzzzzzzzzl_(Observation FitDNA)
        {
            Code<ObservationStatus> mzzzzzzzzzzzzzzzn_ = FitDNA?.StatusElement;
            string mzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzzn_);
            string[] mzzzzzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzr_ = context.Operators.Not(mzzzzzzzzzzzzzzzq_);
            DataType mzzzzzzzzzzzzzzzs_ = FitDNA?.Value;
            bool? mzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzs_ is null));
            bool? mzzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzt_);
            DataType mzzzzzzzzzzzzzzzv_ = FitDNA?.Effective;
            CqlDateTime mzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, mzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzy_ = context.Operators.End(mzzzzzzzzzzzzzzzx_);
            CqlQuantity mzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(3m, "years");
            CqlDateTime nzzzzzzzzzzzzzzza_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzz_);
            CqlDateTime nzzzzzzzzzzzzzzzc_ = context.Operators.End(mzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzd_ = context.Operators.Interval(nzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzc_, true, true);
            bool? nzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzd_, "day");
            CqlDateTime nzzzzzzzzzzzzzzzg_ = context.Operators.End(mzzzzzzzzzzzzzzzx_);
            bool? nzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzg_ is null));
            bool? nzzzzzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzh_);
            bool? nzzzzzzzzzzzzzzzj_ = context.Operators.And(mzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzi_);

            return nzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzl_);

        return mzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzk_ = this.CT_Colonography(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? nzzzzzzzzzzzzzzzm_(Observation Colonography)
        {
            DataType nzzzzzzzzzzzzzzzr_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzzzzzr_);
            CqlDateTime nzzzzzzzzzzzzzzzt_ = context.Operators.End(nzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzv_ = context.Operators.End(nzzzzzzzzzzzzzzzu_);
            CqlQuantity nzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(6m, "years");
            CqlDateTime nzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzw_);
            CqlDateTime nzzzzzzzzzzzzzzzz_ = context.Operators.End(nzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzza_ = context.Operators.Interval(nzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzz_, true, true);
            bool? ozzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzza_, default);
            CqlDateTime ozzzzzzzzzzzzzzzd_ = context.Operators.End(nzzzzzzzzzzzzzzzu_);
            bool? ozzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzd_ is null));
            bool? ozzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzze_);

            return ozzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzm_);
        CqlDateTime nzzzzzzzzzzzzzzzo_(Observation Colonography)
        {
            DataType ozzzzzzzzzzzzzzzg_ = Colonography?.Effective;
            CqlDateTime ozzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ozzzzzzzzzzzzzzzg_);

            return ozzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDateTime> nzzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, CqlDateTime>(nzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDateTime> nzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDateTime>(nzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzi_ = this.CT_Colonography(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzzzzzzzzzzzzk_(Observation Colonography)
        {
            Code<ObservationStatus> ozzzzzzzzzzzzzzzm_ = Colonography?.StatusElement;
            string ozzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzzzm_);
            string[] ozzzzzzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ozzzzzzzzzzzzzzzp_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzo_ as IEnumerable<string>);
            DataType ozzzzzzzzzzzzzzzq_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzzzq_);
            CqlDateTime ozzzzzzzzzzzzzzzs_ = context.Operators.End(ozzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzu_ = context.Operators.End(ozzzzzzzzzzzzzzzt_);
            CqlQuantity ozzzzzzzzzzzzzzzv_ = context.Operators.Quantity(5m, "years");
            CqlDateTime ozzzzzzzzzzzzzzzw_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzv_);
            CqlDateTime ozzzzzzzzzzzzzzzy_ = context.Operators.End(ozzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzz_ = context.Operators.Interval(ozzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzy_, true, true);
            bool? pzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzz_, default);
            CqlDateTime pzzzzzzzzzzzzzzzc_ = context.Operators.End(ozzzzzzzzzzzzzzzt_);
            bool? pzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzc_ is null));
            bool? pzzzzzzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzd_);
            bool? pzzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzze_);

            return pzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzk_);

        return ozzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzg_ = this.CT_Colonography(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzzzzzzzzzzzzzi_(Observation Colonography)
        {
            Code<ObservationStatus> pzzzzzzzzzzzzzzzk_ = Colonography?.StatusElement;
            string pzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzzzk_);
            string[] pzzzzzzzzzzzzzzzm_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? pzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? pzzzzzzzzzzzzzzzo_ = context.Operators.Not(pzzzzzzzzzzzzzzzn_);
            DataType pzzzzzzzzzzzzzzzp_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzzzzzzzp_);
            CqlDateTime pzzzzzzzzzzzzzzzr_ = context.Operators.End(pzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzzt_ = context.Operators.End(pzzzzzzzzzzzzzzzs_);
            CqlQuantity pzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(5m, "years");
            CqlDateTime pzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzu_);
            CqlDateTime pzzzzzzzzzzzzzzzx_ = context.Operators.End(pzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzy_ = context.Operators.Interval(pzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzx_, true, true);
            bool? pzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzy_, default);
            CqlDateTime qzzzzzzzzzzzzzzzb_ = context.Operators.End(pzzzzzzzzzzzzzzzs_);
            bool? qzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzb_ is null));
            bool? qzzzzzzzzzzzzzzzd_ = context.Operators.And(pzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzc_);
            bool? qzzzzzzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzd_);

            return qzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzi_);

        return pzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzf_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? qzzzzzzzzzzzzzzzh_(Procedure FlexibleSigmoidoscopy)
        {
            DataType qzzzzzzzzzzzzzzzm_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzzzm_);
            CqlDateTime qzzzzzzzzzzzzzzzo_ = context.Operators.End(qzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzzq_ = context.Operators.End(qzzzzzzzzzzzzzzzp_);
            CqlQuantity qzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(6m, "years");
            CqlDateTime qzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzr_);
            CqlDateTime qzzzzzzzzzzzzzzzu_ = context.Operators.End(qzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzv_ = context.Operators.Interval(qzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzu_, true, true);
            bool? qzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzv_, default);
            CqlDateTime qzzzzzzzzzzzzzzzy_ = context.Operators.End(qzzzzzzzzzzzzzzzp_);
            bool? qzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzy_ is null));
            bool? rzzzzzzzzzzzzzzza_ = context.Operators.And(qzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzz_);

            return rzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzh_);
        CqlDateTime qzzzzzzzzzzzzzzzj_(Procedure FlexibleSigmoidoscopy)
        {
            DataType rzzzzzzzzzzzzzzzb_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime rzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, rzzzzzzzzzzzzzzzb_);

            return rzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlDateTime> qzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlDateTime>(qzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDateTime> qzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDateTime>(qzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzd_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? rzzzzzzzzzzzzzzzf_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> rzzzzzzzzzzzzzzzh_ = FlexibleSigmoidoscopy?.StatusElement;
            string rzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzzzzzj_ = context.Operators.Equal(rzzzzzzzzzzzzzzzi_, "completed");
            DataType rzzzzzzzzzzzzzzzk_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzzzzzzzzzzzzk_);
            CqlDateTime rzzzzzzzzzzzzzzzm_ = context.Operators.End(rzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzo_ = context.Operators.End(rzzzzzzzzzzzzzzzn_);
            CqlQuantity rzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(5m, "years");
            CqlDateTime rzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzp_);
            CqlDateTime rzzzzzzzzzzzzzzzs_ = context.Operators.End(rzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzt_ = context.Operators.Interval(rzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzs_, true, true);
            bool? rzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzt_, default);
            CqlDateTime rzzzzzzzzzzzzzzzw_ = context.Operators.End(rzzzzzzzzzzzzzzzn_);
            bool? rzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzw_ is null));
            bool? rzzzzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzx_);
            bool? rzzzzzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzy_);

            return rzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzf_);

        return rzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzza_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? szzzzzzzzzzzzzzzc_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> szzzzzzzzzzzzzzze_ = FlexibleSigmoidoscopy?.StatusElement;
            string szzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzze_);
            bool? szzzzzzzzzzzzzzzg_ = context.Operators.Equal(szzzzzzzzzzzzzzzf_, "completed");
            bool? szzzzzzzzzzzzzzzh_ = context.Operators.Not(szzzzzzzzzzzzzzzg_);
            DataType szzzzzzzzzzzzzzzi_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzzi_);
            CqlDateTime szzzzzzzzzzzzzzzk_ = context.Operators.End(szzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzm_ = context.Operators.End(szzzzzzzzzzzzzzzl_);
            CqlQuantity szzzzzzzzzzzzzzzn_ = context.Operators.Quantity(5m, "years");
            CqlDateTime szzzzzzzzzzzzzzzo_ = context.Operators.Subtract(szzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzn_);
            CqlDateTime szzzzzzzzzzzzzzzq_ = context.Operators.End(szzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzr_ = context.Operators.Interval(szzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzq_, true, true);
            bool? szzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzr_, default);
            CqlDateTime szzzzzzzzzzzzzzzu_ = context.Operators.End(szzzzzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzu_ is null));
            bool? szzzzzzzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzv_);
            bool? szzzzzzzzzzzzzzzx_ = context.Operators.And(szzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzw_);

            return szzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzc_);

        return szzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzy_ = this.Colonoscopy(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? tzzzzzzzzzzzzzzza_(Procedure Colonoscopy)
        {
            DataType tzzzzzzzzzzzzzzzf_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzzzf_);
            CqlDateTime tzzzzzzzzzzzzzzzh_ = context.Operators.End(tzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzj_ = context.Operators.End(tzzzzzzzzzzzzzzzi_);
            CqlQuantity tzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(11m, "years");
            CqlDateTime tzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzk_);
            CqlDateTime tzzzzzzzzzzzzzzzn_ = context.Operators.End(tzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzo_ = context.Operators.Interval(tzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzn_, true, true);
            bool? tzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzo_, default);
            CqlDateTime tzzzzzzzzzzzzzzzr_ = context.Operators.End(tzzzzzzzzzzzzzzzi_);
            bool? tzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzr_ is null));
            bool? tzzzzzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzs_);

            return tzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzza_);
        CqlDateTime tzzzzzzzzzzzzzzzc_(Procedure Colonoscopy)
        {
            DataType tzzzzzzzzzzzzzzzu_ = Colonoscopy?.Performed;
            CqlDateTime tzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, tzzzzzzzzzzzzzzzu_);

            return tzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDateTime> tzzzzzzzzzzzzzzzd_ = context.Operators.Select<Procedure, CqlDateTime>(tzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDateTime> tzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDateTime>(tzzzzzzzzzzzzzzzd_);

        return tzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzw_ = this.Colonoscopy(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? tzzzzzzzzzzzzzzzy_(Procedure Colonoscopy)
        {
            Code<EventStatus> uzzzzzzzzzzzzzzza_ = Colonoscopy?.StatusElement;
            string uzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzza_);
            bool? uzzzzzzzzzzzzzzzc_ = context.Operators.Equal(uzzzzzzzzzzzzzzzb_, "completed");
            DataType uzzzzzzzzzzzzzzzd_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzzzzzzzzzzzzd_);
            CqlDateTime uzzzzzzzzzzzzzzzf_ = context.Operators.End(uzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzh_ = context.Operators.End(uzzzzzzzzzzzzzzzg_);
            CqlQuantity uzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(10m, "years");
            CqlDateTime uzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzi_);
            CqlDateTime uzzzzzzzzzzzzzzzl_ = context.Operators.End(uzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzm_ = context.Operators.Interval(uzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzl_, true, true);
            bool? uzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzm_, default);
            CqlDateTime uzzzzzzzzzzzzzzzp_ = context.Operators.End(uzzzzzzzzzzzzzzzg_);
            bool? uzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzp_ is null));
            bool? uzzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzq_);
            bool? uzzzzzzzzzzzzzzzs_ = context.Operators.And(uzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzr_);

            return uzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(tzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzy_);

        return tzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzt_ = this.Colonoscopy(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? uzzzzzzzzzzzzzzzv_(Procedure Colonoscopy)
        {
            Code<EventStatus> uzzzzzzzzzzzzzzzx_ = Colonoscopy?.StatusElement;
            string uzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzzx_);
            bool? uzzzzzzzzzzzzzzzz_ = context.Operators.Equal(uzzzzzzzzzzzzzzzy_, "completed");
            bool? vzzzzzzzzzzzzzzza_ = context.Operators.Not(uzzzzzzzzzzzzzzzz_);
            DataType vzzzzzzzzzzzzzzzb_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzzzzzb_);
            CqlDateTime vzzzzzzzzzzzzzzzd_ = context.Operators.End(vzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzf_ = context.Operators.End(vzzzzzzzzzzzzzzze_);
            CqlQuantity vzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(10m, "years");
            CqlDateTime vzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzg_);
            CqlDateTime vzzzzzzzzzzzzzzzj_ = context.Operators.End(vzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzk_ = context.Operators.Interval(vzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzj_, true, true);
            bool? vzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzk_, default);
            CqlDateTime vzzzzzzzzzzzzzzzn_ = context.Operators.End(vzzzzzzzzzzzzzzze_);
            bool? vzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzn_ is null));
            bool? vzzzzzzzzzzzzzzzp_ = context.Operators.And(vzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzv_);

        return uzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzr_ = this.Colonoscopy_Performed(context);
        bool? vzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzt_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? vzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzt_);
        bool? vzzzzzzzzzzzzzzzv_ = context.Operators.Or(vzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzu_);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzw_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? vzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzzzzzzw_);
        bool? vzzzzzzzzzzzzzzzy_ = context.Operators.Or(vzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzz_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? wzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzz_);
        bool? wzzzzzzzzzzzzzzzb_ = context.Operators.Or(vzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzc_ = this.CT_Colonography_Performed(context);
        bool? wzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(wzzzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzzzze_ = context.Operators.Or(wzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzd_);

        return wzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzzf_ = this.Numerator(context);
        bool? wzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);
        bool? wzzzzzzzzzzzzzzzh_ = context.Operators.And(wzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzg_);
        bool? wzzzzzzzzzzzzzzzi_ = this.Denominator(context);
        bool? wzzzzzzzzzzzzzzzj_ = context.Operators.And(wzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzzzk_ = this.Denominator_Exclusions(context);
        bool? wzzzzzzzzzzzzzzzl_ = context.Operators.Not(wzzzzzzzzzzzzzzzk_);
        bool? wzzzzzzzzzzzzzzzm_ = context.Operators.And(wzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
