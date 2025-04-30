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
[CqlLibrary("ColorectalCancerScreeningsFHIR", "0.0.003")]
public partial class ColorectalCancerScreeningsFHIR_0_0_003 : ILibrary, ISingleton<ColorectalCancerScreeningsFHIR_0_0_003>
{
    private ColorectalCancerScreeningsFHIR_0_0_003() {}

    public static ColorectalCancerScreeningsFHIR_0_0_003 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ColorectalCancerScreeningsFHIR";
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
        CqlDateTime kzzzzzu_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime kzzzzzv_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> kzzzzzw_ = context.Operators.Interval(kzzzzzu_, kzzzzzv_, true, false);
        object kzzzzzx_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", kzzzzzw_);

        return (CqlInterval<CqlDateTime>)kzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient kzzzzzz_ = context.Operators.SingletonFrom<Patient>(kzzzzzy_);

        return kzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> lzzzzza_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return lzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> lzzzzzb_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return lzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> lzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return lzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode lzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return lzzzzzd_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet lzzzzze_ = this.Online_Assessments(context);
        IEnumerable<Encounter> lzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet lzzzzzg_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> lzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> lzzzzzi_ = context.Operators.Union<Encounter>(lzzzzzf_, lzzzzzh_);
        bool? lzzzzzj_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> lzzzzzl_ = TelehealthEncounter?.StatusElement;
            string lzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzl_);
            bool? lzzzzzn_ = context.Operators.Equal(lzzzzzm_, "finished");
            CqlInterval<CqlDateTime> lzzzzzo_ = this.Measurement_Period(context);
            Period lzzzzzp_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzp_ as object);
            bool? lzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzo_, lzzzzzq_, default);
            bool? lzzzzzs_ = context.Operators.And(lzzzzzn_, lzzzzzr_);

            return lzzzzzs_;
        };
        IEnumerable<Encounter> lzzzzzk_ = context.Operators.Where<Encounter>(lzzzzzi_, lzzzzzj_);

        return lzzzzzk_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient lzzzzzt_ = this.Patient(context);
        Date lzzzzzu_ = lzzzzzt_?.BirthDateElement;
        string lzzzzzv_ = lzzzzzu_?.Value;
        CqlDate lzzzzzw_ = context.Operators.ConvertStringToDate(lzzzzzv_);
        CqlInterval<CqlDateTime> lzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzy_ = context.Operators.Start(lzzzzzx_);
        CqlDate lzzzzzz_ = context.Operators.DateFrom(lzzzzzy_);
        int? mzzzzza_ = context.Operators.CalculateAgeAt(lzzzzzw_, lzzzzzz_, "year");

        return mzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient mzzzzzb_ = this.Patient(context);
        Date mzzzzzc_ = mzzzzzb_?.BirthDateElement;
        string mzzzzzd_ = mzzzzzc_?.Value;
        CqlDate mzzzzze_ = context.Operators.ConvertStringToDate(mzzzzzd_);
        CqlInterval<CqlDateTime> mzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime mzzzzzg_ = context.Operators.Start(mzzzzzf_);
        CqlDate mzzzzzh_ = context.Operators.DateFrom(mzzzzzg_);
        int? mzzzzzi_ = context.Operators.CalculateAgeAt(mzzzzze_, mzzzzzh_, "year");
        CqlInterval<int?> mzzzzzj_ = context.Operators.Interval(51, 75, true, false);
        bool? mzzzzzk_ = context.Operators.In<int?>(mzzzzzi_, mzzzzzj_, default);
        IEnumerable<Encounter> mzzzzzl_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> mzzzzzm_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> mzzzzzn_ = context.Operators.Union<Encounter>(mzzzzzl_, mzzzzzm_);
        bool? mzzzzzo_ = context.Operators.Exists<Encounter>(mzzzzzn_);
        bool? mzzzzzp_ = context.Operators.And(mzzzzzk_, mzzzzzo_);

        return mzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? mzzzzzq_ = this.Initial_Population(context);

        return mzzzzzq_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet mzzzzzr_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> mzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? mzzzzzt_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> mzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime mzzzzzw_ = context.Operators.Start(mzzzzzv_);
            CqlInterval<CqlDateTime> mzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzy_ = context.Operators.End(mzzzzzx_);
            bool? mzzzzzz_ = context.Operators.SameOrBefore(mzzzzzw_, mzzzzzy_, default);

            return mzzzzzz_;
        };
        IEnumerable<Condition> mzzzzzu_ = context.Operators.Where<Condition>(mzzzzzs_, mzzzzzt_);

        return mzzzzzu_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet nzzzzza_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> nzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? nzzzzzc_(Procedure Colectomy)
        {
            Code<EventStatus> nzzzzze_ = Colectomy?.StatusElement;
            string nzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzze_);
            bool? nzzzzzg_ = context.Operators.Equal(nzzzzzf_, "completed");
            DataType nzzzzzh_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> nzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzh_);
            CqlDateTime nzzzzzj_ = context.Operators.End(nzzzzzi_);
            CqlInterval<CqlDateTime> nzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzl_ = context.Operators.End(nzzzzzk_);
            bool? nzzzzzm_ = context.Operators.SameOrBefore(nzzzzzj_, nzzzzzl_, default);
            bool? nzzzzzn_ = context.Operators.And(nzzzzzg_, nzzzzzm_);

            return nzzzzzn_;
        };
        IEnumerable<Procedure> nzzzzzd_ = context.Operators.Where<Procedure>(nzzzzzb_, nzzzzzc_);

        return nzzzzzd_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet nzzzzzo_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> nzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzzzzq_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> nzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime nzzzzzt_ = context.Operators.Start(nzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzv_ = context.Operators.End(nzzzzzu_);
            bool? nzzzzzw_ = context.Operators.SameOrBefore(nzzzzzt_, nzzzzzv_, default);

            return nzzzzzw_;
        };
        IEnumerable<Condition> nzzzzzr_ = context.Operators.Where<Condition>(nzzzzzp_, nzzzzzq_);

        return nzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? nzzzzzx_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> nzzzzzy_ = this.Malignant_Neoplasm(context);
        bool? nzzzzzz_ = context.Operators.Exists<Condition>(nzzzzzy_);
        bool? ozzzzza_ = context.Operators.Or(nzzzzzx_, nzzzzzz_);
        IEnumerable<Procedure> ozzzzzb_ = this.Total_Colectomy_Performed(context);
        bool? ozzzzzc_ = context.Operators.Exists<Procedure>(ozzzzzb_);
        bool? ozzzzzd_ = context.Operators.Or(ozzzzza_, ozzzzzc_);
        IEnumerable<Condition> ozzzzze_ = this.Total_Colectomy_Condition(context);
        bool? ozzzzzf_ = context.Operators.Exists<Condition>(ozzzzze_);
        bool? ozzzzzg_ = context.Operators.Or(ozzzzzd_, ozzzzzf_);
        bool? ozzzzzh_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? ozzzzzi_ = context.Operators.Or(ozzzzzg_, ozzzzzh_);
        Patient ozzzzzj_ = this.Patient(context);
        Date ozzzzzk_ = ozzzzzj_?.BirthDateElement;
        string ozzzzzl_ = ozzzzzk_?.Value;
        CqlDate ozzzzzm_ = context.Operators.ConvertStringToDate(ozzzzzl_);
        CqlInterval<CqlDateTime> ozzzzzn_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzo_ = context.Operators.Start(ozzzzzn_);
        CqlDate ozzzzzp_ = context.Operators.DateFrom(ozzzzzo_);
        int? ozzzzzq_ = context.Operators.CalculateAgeAt(ozzzzzm_, ozzzzzp_, "year");
        bool? ozzzzzr_ = context.Operators.GreaterOrEqual(ozzzzzq_, 65);
        bool? ozzzzzs_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? ozzzzzt_ = context.Operators.And(ozzzzzr_, ozzzzzs_);
        bool? ozzzzzu_ = context.Operators.Or(ozzzzzi_, ozzzzzt_);
        bool? ozzzzzv_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? ozzzzzw_ = context.Operators.Or(ozzzzzu_, ozzzzzv_);

        return ozzzzzw_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet ozzzzzx_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> ozzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzzz_(Observation FecalOccult)
        {
            DataType pzzzzze_ = FecalOccult?.Effective;
            CqlDateTime pzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, pzzzzze_);
            CqlInterval<CqlDateTime> pzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzh_ = context.Operators.Start(pzzzzzg_);
            CqlQuantity pzzzzzi_ = context.Operators.Quantity(1m, "year");
            CqlDateTime pzzzzzj_ = context.Operators.Subtract(pzzzzzh_, pzzzzzi_);
            CqlDateTime pzzzzzl_ = context.Operators.End(pzzzzzg_);
            CqlInterval<CqlDateTime> pzzzzzm_ = context.Operators.Interval(pzzzzzj_, pzzzzzl_, false, false);
            bool? pzzzzzn_ = context.Operators.In<CqlDateTime>(pzzzzzf_, pzzzzzm_, default);

            return pzzzzzn_;
        };
        IEnumerable<Observation> pzzzzza_ = context.Operators.Where<Observation>(ozzzzzy_, ozzzzzz_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? pzzzzzb_(Observation FecalOccult)
        {
            DataType pzzzzzo_ = FecalOccult?.Effective;
            CqlDateTime pzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, pzzzzzo_);
            DataType pzzzzzq_ = FecalOccult?.Value;
            IEnumerable<Coding> pzzzzzr_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(pzzzzzq_, "coding");
            bool? pzzzzzs_(Coding @this)
            {
                FhirString qzzzzzm_ = @this?.DisplayElement;
                bool? qzzzzzn_ = context.Operators.Not((bool?)(qzzzzzm_ is null));

                return qzzzzzn_;
            };
            IEnumerable<Coding> pzzzzzt_ = context.Operators.Where<Coding>(pzzzzzr_, pzzzzzs_);
            FhirString pzzzzzu_(Coding @this)
            {
                FhirString qzzzzzo_ = @this?.DisplayElement;

                return qzzzzzo_;
            };
            IEnumerable<FhirString> pzzzzzv_ = context.Operators.Select<Coding, FhirString>(pzzzzzt_, pzzzzzu_);
            List<CodeableConcept> pzzzzzw_ = FecalOccult?.Category;
            bool? pzzzzzx_(CodeableConcept @this)
            {
                List<Coding> qzzzzzp_ = @this?.Coding;
                bool? qzzzzzq_ = context.Operators.Not((bool?)(qzzzzzp_ is null));

                return qzzzzzq_;
            };
            IEnumerable<CodeableConcept> pzzzzzy_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzzw_, pzzzzzx_);
            List<Coding> pzzzzzz_(CodeableConcept @this)
            {
                List<Coding> qzzzzzr_ = @this?.Coding;

                return qzzzzzr_;
            };
            IEnumerable<List<Coding>> qzzzzza_ = context.Operators.Select<CodeableConcept, List<Coding>>(pzzzzzy_, pzzzzzz_);
            IEnumerable<Coding> qzzzzzb_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)qzzzzza_);
            bool? qzzzzzc_(Coding @this)
            {
                Code qzzzzzs_ = @this?.CodeElement;
                bool? qzzzzzt_ = context.Operators.Not((bool?)(qzzzzzs_ is null));

                return qzzzzzt_;
            };
            IEnumerable<Coding> qzzzzzd_ = context.Operators.Where<Coding>(qzzzzzb_, qzzzzzc_);
            Code qzzzzze_(Coding @this)
            {
                Code qzzzzzu_ = @this?.CodeElement;

                return qzzzzzu_;
            };
            IEnumerable<Code> qzzzzzf_ = context.Operators.Select<Coding, Code>(qzzzzzd_, qzzzzze_);
            bool? qzzzzzg_(Code @this)
            {
                string qzzzzzv_ = @this?.Value;
                bool? qzzzzzw_ = context.Operators.Not((bool?)(qzzzzzv_ is null));

                return qzzzzzw_;
            };
            IEnumerable<Code> qzzzzzh_ = context.Operators.Where<Code>(qzzzzzf_, qzzzzzg_);
            string qzzzzzi_(Code @this)
            {
                string qzzzzzx_ = @this?.Value;

                return qzzzzzx_;
            };
            IEnumerable<string> qzzzzzj_ = context.Operators.Select<Code, string>(qzzzzzh_, qzzzzzi_);
            Code<ObservationStatus> qzzzzzk_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? qzzzzzl_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, pzzzzzp_, pzzzzzv_, qzzzzzj_, qzzzzzk_);

            return qzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> pzzzzzc_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(pzzzzza_, pzzzzzb_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> pzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(pzzzzzc_);

        return pzzzzzd_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet qzzzzzy_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> qzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzza_(Observation FecalOccult)
        {
            Code<ObservationStatus> rzzzzzc_ = FecalOccult?.StatusElement;
            string rzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzc_);
            string[] rzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzf_ = context.Operators.In<string>(rzzzzzd_, rzzzzze_ as IEnumerable<string>);
            List<CodeableConcept> rzzzzzg_ = FecalOccult?.Category;
            bool? rzzzzzh_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> rzzzzzt_ = FecalOccultCategory?.Coding;
                bool? rzzzzzu_(Coding @this)
                {
                    Code szzzzze_ = @this?.CodeElement;
                    bool? szzzzzf_ = context.Operators.Not((bool?)(szzzzze_ is null));

                    return szzzzzf_;
                };
                IEnumerable<Coding> rzzzzzv_ = context.Operators.Where<Coding>((IEnumerable<Coding>)rzzzzzt_, rzzzzzu_);
                Code rzzzzzw_(Coding @this)
                {
                    Code szzzzzg_ = @this?.CodeElement;

                    return szzzzzg_;
                };
                IEnumerable<Code> rzzzzzx_ = context.Operators.Select<Coding, Code>(rzzzzzv_, rzzzzzw_);
                bool? rzzzzzy_(Code @this)
                {
                    string szzzzzh_ = @this?.Value;
                    bool? szzzzzi_ = context.Operators.Not((bool?)(szzzzzh_ is null));

                    return szzzzzi_;
                };
                IEnumerable<Code> rzzzzzz_ = context.Operators.Where<Code>(rzzzzzx_, rzzzzzy_);
                string szzzzza_(Code @this)
                {
                    string szzzzzj_ = @this?.Value;

                    return szzzzzj_;
                };
                IEnumerable<string> szzzzzb_ = context.Operators.Select<Code, string>(rzzzzzz_, szzzzza_);
                string[] szzzzzc_ = [
                    "laboratory",
                ];
                bool? szzzzzd_ = context.Operators.Equivalent<string>(szzzzzb_, szzzzzc_ as IEnumerable<string>);

                return szzzzzd_;
            };
            IEnumerable<CodeableConcept> rzzzzzi_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzzg_, rzzzzzh_);
            bool? rzzzzzj_ = context.Operators.Exists<CodeableConcept>(rzzzzzi_);
            bool? rzzzzzk_ = context.Operators.And(rzzzzzf_, rzzzzzj_);
            DataType rzzzzzl_ = FecalOccult?.Value;
            bool? rzzzzzm_ = context.Operators.Not((bool?)(rzzzzzl_ is null));
            bool? rzzzzzn_ = context.Operators.And(rzzzzzk_, rzzzzzm_);
            DataType rzzzzzo_ = FecalOccult?.Effective;
            CqlDateTime rzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, rzzzzzo_);
            CqlInterval<CqlDateTime> rzzzzzq_ = this.Measurement_Period(context);
            bool? rzzzzzr_ = context.Operators.In<CqlDateTime>(rzzzzzp_, rzzzzzq_, default);
            bool? rzzzzzs_ = context.Operators.And(rzzzzzn_, rzzzzzr_);

            return rzzzzzs_;
        };
        IEnumerable<Observation> rzzzzzb_ = context.Operators.Where<Observation>(qzzzzzz_, rzzzzza_);

        return rzzzzzb_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet szzzzzk_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> szzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzzzm_(Observation FecalOccult)
        {
            Code<ObservationStatus> szzzzzo_ = FecalOccult?.StatusElement;
            string szzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzo_);
            string[] szzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzr_ = context.Operators.In<string>(szzzzzp_, szzzzzq_ as IEnumerable<string>);
            List<CodeableConcept> szzzzzs_ = FecalOccult?.Category;
            bool? szzzzzt_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> tzzzzzf_ = FecalOccultCategory?.Coding;
                bool? tzzzzzg_(Coding @this)
                {
                    Code tzzzzzq_ = @this?.CodeElement;
                    bool? tzzzzzr_ = context.Operators.Not((bool?)(tzzzzzq_ is null));

                    return tzzzzzr_;
                };
                IEnumerable<Coding> tzzzzzh_ = context.Operators.Where<Coding>((IEnumerable<Coding>)tzzzzzf_, tzzzzzg_);
                Code tzzzzzi_(Coding @this)
                {
                    Code tzzzzzs_ = @this?.CodeElement;

                    return tzzzzzs_;
                };
                IEnumerable<Code> tzzzzzj_ = context.Operators.Select<Coding, Code>(tzzzzzh_, tzzzzzi_);
                bool? tzzzzzk_(Code @this)
                {
                    string tzzzzzt_ = @this?.Value;
                    bool? tzzzzzu_ = context.Operators.Not((bool?)(tzzzzzt_ is null));

                    return tzzzzzu_;
                };
                IEnumerable<Code> tzzzzzl_ = context.Operators.Where<Code>(tzzzzzj_, tzzzzzk_);
                string tzzzzzm_(Code @this)
                {
                    string tzzzzzv_ = @this?.Value;

                    return tzzzzzv_;
                };
                IEnumerable<string> tzzzzzn_ = context.Operators.Select<Code, string>(tzzzzzl_, tzzzzzm_);
                string[] tzzzzzo_ = [
                    "laboratory",
                ];
                bool? tzzzzzp_ = context.Operators.Equivalent<string>(tzzzzzn_, tzzzzzo_ as IEnumerable<string>);

                return tzzzzzp_;
            };
            IEnumerable<CodeableConcept> szzzzzu_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzzs_, szzzzzt_);
            bool? szzzzzv_ = context.Operators.Exists<CodeableConcept>(szzzzzu_);
            bool? szzzzzw_ = context.Operators.And(szzzzzr_, szzzzzv_);
            DataType szzzzzx_ = FecalOccult?.Value;
            bool? szzzzzy_ = context.Operators.Not((bool?)(szzzzzx_ is null));
            bool? szzzzzz_ = context.Operators.And(szzzzzw_, szzzzzy_);
            DataType tzzzzza_ = FecalOccult?.Effective;
            CqlDateTime tzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, tzzzzza_);
            CqlInterval<CqlDateTime> tzzzzzc_ = this.Measurement_Period(context);
            bool? tzzzzzd_ = context.Operators.In<CqlDateTime>(tzzzzzb_, tzzzzzc_, "day");
            bool? tzzzzze_ = context.Operators.And(szzzzzz_, tzzzzzd_);

            return tzzzzze_;
        };
        IEnumerable<Observation> szzzzzn_ = context.Operators.Where<Observation>(szzzzzl_, szzzzzm_);

        return szzzzzn_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet tzzzzzw_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> tzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? tzzzzzy_(Observation FecalOccult)
        {
            List<CodeableConcept> uzzzzza_ = FecalOccult?.Category;
            bool? uzzzzzb_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> uzzzzzm_ = FecalOccultCategory?.Coding;
                bool? uzzzzzn_(Coding @this)
                {
                    Code uzzzzzy_ = @this?.CodeElement;
                    bool? uzzzzzz_ = context.Operators.Not((bool?)(uzzzzzy_ is null));

                    return uzzzzzz_;
                };
                IEnumerable<Coding> uzzzzzo_ = context.Operators.Where<Coding>((IEnumerable<Coding>)uzzzzzm_, uzzzzzn_);
                Code uzzzzzp_(Coding @this)
                {
                    Code vzzzzza_ = @this?.CodeElement;

                    return vzzzzza_;
                };
                IEnumerable<Code> uzzzzzq_ = context.Operators.Select<Coding, Code>(uzzzzzo_, uzzzzzp_);
                bool? uzzzzzr_(Code @this)
                {
                    string vzzzzzb_ = @this?.Value;
                    bool? vzzzzzc_ = context.Operators.Not((bool?)(vzzzzzb_ is null));

                    return vzzzzzc_;
                };
                IEnumerable<Code> uzzzzzs_ = context.Operators.Where<Code>(uzzzzzq_, uzzzzzr_);
                string uzzzzzt_(Code @this)
                {
                    string vzzzzzd_ = @this?.Value;

                    return vzzzzzd_;
                };
                IEnumerable<string> uzzzzzu_ = context.Operators.Select<Code, string>(uzzzzzs_, uzzzzzt_);
                string[] uzzzzzv_ = [
                    "laboratory",
                ];
                bool? uzzzzzw_ = context.Operators.Equivalent<string>(uzzzzzu_, uzzzzzv_ as IEnumerable<string>);
                bool? uzzzzzx_ = context.Operators.Not(uzzzzzw_);

                return uzzzzzx_;
            };
            IEnumerable<CodeableConcept> uzzzzzc_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzza_, uzzzzzb_);
            bool? uzzzzzd_ = context.Operators.Exists<CodeableConcept>(uzzzzzc_);
            DataType uzzzzze_ = FecalOccult?.Value;
            bool? uzzzzzf_ = context.Operators.Not((bool?)(uzzzzze_ is null));
            bool? uzzzzzg_ = context.Operators.And(uzzzzzd_, uzzzzzf_);
            DataType uzzzzzh_ = FecalOccult?.Effective;
            CqlDateTime uzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzzzh_);
            CqlInterval<CqlDateTime> uzzzzzj_ = this.Measurement_Period(context);
            bool? uzzzzzk_ = context.Operators.In<CqlDateTime>(uzzzzzi_, uzzzzzj_, "day");
            bool? uzzzzzl_ = context.Operators.And(uzzzzzg_, uzzzzzk_);

            return uzzzzzl_;
        };
        IEnumerable<Observation> tzzzzzz_ = context.Operators.Where<Observation>(tzzzzzx_, tzzzzzy_);

        return tzzzzzz_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet vzzzzze_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> vzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzg_(Observation FecalOccult)
        {
            Code<ObservationStatus> vzzzzzi_ = FecalOccult?.StatusElement;
            string vzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzi_);
            string[] vzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzl_ = context.Operators.In<string>(vzzzzzj_, vzzzzzk_ as IEnumerable<string>);
            bool? vzzzzzm_ = context.Operators.Not(vzzzzzl_);
            DataType vzzzzzn_ = FecalOccult?.Value;
            bool? vzzzzzo_ = context.Operators.Not((bool?)(vzzzzzn_ is null));
            bool? vzzzzzp_ = context.Operators.And(vzzzzzm_, vzzzzzo_);
            DataType vzzzzzq_ = FecalOccult?.Effective;
            CqlDateTime vzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzzzq_);
            CqlInterval<CqlDateTime> vzzzzzs_ = this.Measurement_Period(context);
            bool? vzzzzzt_ = context.Operators.In<CqlDateTime>(vzzzzzr_, vzzzzzs_, "day");
            bool? vzzzzzu_ = context.Operators.And(vzzzzzp_, vzzzzzt_);

            return vzzzzzu_;
        };
        IEnumerable<Observation> vzzzzzh_ = context.Operators.Where<Observation>(vzzzzzf_, vzzzzzg_);

        return vzzzzzh_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet vzzzzzv_ = this.FIT_DNA(context);
        IEnumerable<Observation> vzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzx_(Observation FitDNA)
        {
            DataType wzzzzzc_ = FitDNA?.Effective;
            CqlDateTime wzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, wzzzzzc_);
            CqlInterval<CqlDateTime> wzzzzze_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzf_ = context.Operators.End(wzzzzze_);
            CqlQuantity wzzzzzg_ = context.Operators.Quantity(4m, "years");
            CqlDateTime wzzzzzh_ = context.Operators.Subtract(wzzzzzf_, wzzzzzg_);
            CqlDateTime wzzzzzj_ = context.Operators.End(wzzzzze_);
            CqlInterval<CqlDateTime> wzzzzzk_ = context.Operators.Interval(wzzzzzh_, wzzzzzj_, true, true);
            bool? wzzzzzl_ = context.Operators.In<CqlDateTime>(wzzzzzd_, wzzzzzk_, default);
            CqlDateTime wzzzzzn_ = context.Operators.End(wzzzzze_);
            bool? wzzzzzo_ = context.Operators.Not((bool?)(wzzzzzn_ is null));
            bool? wzzzzzp_ = context.Operators.And(wzzzzzl_, wzzzzzo_);

            return wzzzzzp_;
        };
        IEnumerable<Observation> vzzzzzy_ = context.Operators.Where<Observation>(vzzzzzw_, vzzzzzx_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? vzzzzzz_(Observation FitDNA)
        {
            DataType wzzzzzq_ = FitDNA?.Effective;
            CqlDateTime wzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, wzzzzzq_);
            DataType wzzzzzs_ = FitDNA?.Value;
            IEnumerable<Coding> wzzzzzt_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(wzzzzzs_, "coding");
            bool? wzzzzzu_(Coding @this)
            {
                FhirString xzzzzzo_ = @this?.DisplayElement;
                bool? xzzzzzp_ = context.Operators.Not((bool?)(xzzzzzo_ is null));

                return xzzzzzp_;
            };
            IEnumerable<Coding> wzzzzzv_ = context.Operators.Where<Coding>(wzzzzzt_, wzzzzzu_);
            FhirString wzzzzzw_(Coding @this)
            {
                FhirString xzzzzzq_ = @this?.DisplayElement;

                return xzzzzzq_;
            };
            IEnumerable<FhirString> wzzzzzx_ = context.Operators.Select<Coding, FhirString>(wzzzzzv_, wzzzzzw_);
            List<CodeableConcept> wzzzzzy_ = FitDNA?.Category;
            bool? wzzzzzz_(CodeableConcept @this)
            {
                List<Coding> xzzzzzr_ = @this?.Coding;
                bool? xzzzzzs_ = context.Operators.Not((bool?)(xzzzzzr_ is null));

                return xzzzzzs_;
            };
            IEnumerable<CodeableConcept> xzzzzza_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzzzy_, wzzzzzz_);
            List<Coding> xzzzzzb_(CodeableConcept @this)
            {
                List<Coding> xzzzzzt_ = @this?.Coding;

                return xzzzzzt_;
            };
            IEnumerable<List<Coding>> xzzzzzc_ = context.Operators.Select<CodeableConcept, List<Coding>>(xzzzzza_, xzzzzzb_);
            IEnumerable<Coding> xzzzzzd_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)xzzzzzc_);
            bool? xzzzzze_(Coding @this)
            {
                Code xzzzzzu_ = @this?.CodeElement;
                bool? xzzzzzv_ = context.Operators.Not((bool?)(xzzzzzu_ is null));

                return xzzzzzv_;
            };
            IEnumerable<Coding> xzzzzzf_ = context.Operators.Where<Coding>(xzzzzzd_, xzzzzze_);
            Code xzzzzzg_(Coding @this)
            {
                Code xzzzzzw_ = @this?.CodeElement;

                return xzzzzzw_;
            };
            IEnumerable<Code> xzzzzzh_ = context.Operators.Select<Coding, Code>(xzzzzzf_, xzzzzzg_);
            bool? xzzzzzi_(Code @this)
            {
                string xzzzzzx_ = @this?.Value;
                bool? xzzzzzy_ = context.Operators.Not((bool?)(xzzzzzx_ is null));

                return xzzzzzy_;
            };
            IEnumerable<Code> xzzzzzj_ = context.Operators.Where<Code>(xzzzzzh_, xzzzzzi_);
            string xzzzzzk_(Code @this)
            {
                string xzzzzzz_ = @this?.Value;

                return xzzzzzz_;
            };
            IEnumerable<string> xzzzzzl_ = context.Operators.Select<Code, string>(xzzzzzj_, xzzzzzk_);
            Code<ObservationStatus> xzzzzzm_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? xzzzzzn_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, wzzzzzr_, wzzzzzx_, xzzzzzl_, xzzzzzm_);

            return xzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> wzzzzza_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(vzzzzzy_, vzzzzzz_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> wzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(wzzzzza_);

        return wzzzzzb_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet yzzzzza_ = this.FIT_DNA(context);
        IEnumerable<Observation> yzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzzzc_(Observation FitDNA)
        {
            Code<ObservationStatus> yzzzzze_ = FitDNA?.StatusElement;
            string yzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzze_);
            string[] yzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzzzzh_ = context.Operators.In<string>(yzzzzzf_, yzzzzzg_ as IEnumerable<string>);
            List<CodeableConcept> yzzzzzi_ = FitDNA?.Category;
            bool? yzzzzzj_(CodeableConcept FitDNACategory)
            {
                List<Coding> zzzzzzf_ = FitDNACategory?.Coding;
                bool? zzzzzzg_(Coding @this)
                {
                    Code zzzzzzq_ = @this?.CodeElement;
                    bool? zzzzzzr_ = context.Operators.Not((bool?)(zzzzzzq_ is null));

                    return zzzzzzr_;
                };
                IEnumerable<Coding> zzzzzzh_ = context.Operators.Where<Coding>((IEnumerable<Coding>)zzzzzzf_, zzzzzzg_);
                Code zzzzzzi_(Coding @this)
                {
                    Code zzzzzzs_ = @this?.CodeElement;

                    return zzzzzzs_;
                };
                IEnumerable<Code> zzzzzzj_ = context.Operators.Select<Coding, Code>(zzzzzzh_, zzzzzzi_);
                bool? zzzzzzk_(Code @this)
                {
                    string zzzzzzt_ = @this?.Value;
                    bool? zzzzzzu_ = context.Operators.Not((bool?)(zzzzzzt_ is null));

                    return zzzzzzu_;
                };
                IEnumerable<Code> zzzzzzl_ = context.Operators.Where<Code>(zzzzzzj_, zzzzzzk_);
                string zzzzzzm_(Code @this)
                {
                    string zzzzzzv_ = @this?.Value;

                    return zzzzzzv_;
                };
                IEnumerable<string> zzzzzzn_ = context.Operators.Select<Code, string>(zzzzzzl_, zzzzzzm_);
                string[] zzzzzzo_ = [
                    "laboratory",
                ];
                bool? zzzzzzp_ = context.Operators.Equivalent<string>(zzzzzzn_, zzzzzzo_ as IEnumerable<string>);

                return zzzzzzp_;
            };
            IEnumerable<CodeableConcept> yzzzzzk_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzzzi_, yzzzzzj_);
            bool? yzzzzzl_ = context.Operators.Exists<CodeableConcept>(yzzzzzk_);
            bool? yzzzzzm_ = context.Operators.And(yzzzzzh_, yzzzzzl_);
            DataType yzzzzzn_ = FitDNA?.Value;
            bool? yzzzzzo_ = context.Operators.Not((bool?)(yzzzzzn_ is null));
            bool? yzzzzzp_ = context.Operators.And(yzzzzzm_, yzzzzzo_);
            DataType yzzzzzq_ = FitDNA?.Effective;
            CqlDateTime yzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, yzzzzzq_);
            CqlInterval<CqlDateTime> yzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzt_ = context.Operators.End(yzzzzzs_);
            CqlQuantity yzzzzzu_ = context.Operators.Quantity(3m, "years");
            CqlDateTime yzzzzzv_ = context.Operators.Subtract(yzzzzzt_, yzzzzzu_);
            CqlDateTime yzzzzzx_ = context.Operators.End(yzzzzzs_);
            CqlInterval<CqlDateTime> yzzzzzy_ = context.Operators.Interval(yzzzzzv_, yzzzzzx_, true, true);
            bool? yzzzzzz_ = context.Operators.In<CqlDateTime>(yzzzzzr_, yzzzzzy_, default);
            CqlDateTime zzzzzzb_ = context.Operators.End(yzzzzzs_);
            bool? zzzzzzc_ = context.Operators.Not((bool?)(zzzzzzb_ is null));
            bool? zzzzzzd_ = context.Operators.And(yzzzzzz_, zzzzzzc_);
            bool? zzzzzze_ = context.Operators.And(yzzzzzp_, zzzzzzd_);

            return zzzzzze_;
        };
        IEnumerable<Observation> yzzzzzd_ = context.Operators.Where<Observation>(yzzzzzb_, yzzzzzc_);

        return yzzzzzd_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet zzzzzzw_ = this.FIT_DNA(context);
        IEnumerable<Observation> zzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzy_(Observation FitDNA)
        {
            Code<ObservationStatus> azzzzzza_ = FitDNA?.StatusElement;
            string azzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzza_);
            string[] azzzzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzzzd_ = context.Operators.In<string>(azzzzzzb_, azzzzzzc_ as IEnumerable<string>);
            List<CodeableConcept> azzzzzze_ = FitDNA?.Category;
            bool? azzzzzzf_(CodeableConcept FitDNACategory)
            {
                List<Coding> bzzzzzzb_ = FitDNACategory?.Coding;
                bool? bzzzzzzc_(Coding @this)
                {
                    Code bzzzzzzm_ = @this?.CodeElement;
                    bool? bzzzzzzn_ = context.Operators.Not((bool?)(bzzzzzzm_ is null));

                    return bzzzzzzn_;
                };
                IEnumerable<Coding> bzzzzzzd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bzzzzzzb_, bzzzzzzc_);
                Code bzzzzzze_(Coding @this)
                {
                    Code bzzzzzzo_ = @this?.CodeElement;

                    return bzzzzzzo_;
                };
                IEnumerable<Code> bzzzzzzf_ = context.Operators.Select<Coding, Code>(bzzzzzzd_, bzzzzzze_);
                bool? bzzzzzzg_(Code @this)
                {
                    string bzzzzzzp_ = @this?.Value;
                    bool? bzzzzzzq_ = context.Operators.Not((bool?)(bzzzzzzp_ is null));

                    return bzzzzzzq_;
                };
                IEnumerable<Code> bzzzzzzh_ = context.Operators.Where<Code>(bzzzzzzf_, bzzzzzzg_);
                string bzzzzzzi_(Code @this)
                {
                    string bzzzzzzr_ = @this?.Value;

                    return bzzzzzzr_;
                };
                IEnumerable<string> bzzzzzzj_ = context.Operators.Select<Code, string>(bzzzzzzh_, bzzzzzzi_);
                string[] bzzzzzzk_ = [
                    "laboratory",
                ];
                bool? bzzzzzzl_ = context.Operators.Equivalent<string>(bzzzzzzj_, bzzzzzzk_ as IEnumerable<string>);

                return bzzzzzzl_;
            };
            IEnumerable<CodeableConcept> azzzzzzg_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzzze_, azzzzzzf_);
            bool? azzzzzzh_ = context.Operators.Exists<CodeableConcept>(azzzzzzg_);
            bool? azzzzzzi_ = context.Operators.And(azzzzzzd_, azzzzzzh_);
            DataType azzzzzzj_ = FitDNA?.Value;
            bool? azzzzzzk_ = context.Operators.Not((bool?)(azzzzzzj_ is null));
            bool? azzzzzzl_ = context.Operators.And(azzzzzzi_, azzzzzzk_);
            DataType azzzzzzm_ = FitDNA?.Effective;
            CqlDateTime azzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, azzzzzzm_);
            CqlInterval<CqlDateTime> azzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzp_ = context.Operators.End(azzzzzzo_);
            CqlQuantity azzzzzzq_ = context.Operators.Quantity(3m, "years");
            CqlDateTime azzzzzzr_ = context.Operators.Subtract(azzzzzzp_, azzzzzzq_);
            CqlDateTime azzzzzzt_ = context.Operators.End(azzzzzzo_);
            CqlInterval<CqlDateTime> azzzzzzu_ = context.Operators.Interval(azzzzzzr_, azzzzzzt_, true, true);
            bool? azzzzzzv_ = context.Operators.In<CqlDateTime>(azzzzzzn_, azzzzzzu_, "day");
            CqlDateTime azzzzzzx_ = context.Operators.End(azzzzzzo_);
            bool? azzzzzzy_ = context.Operators.Not((bool?)(azzzzzzx_ is null));
            bool? azzzzzzz_ = context.Operators.And(azzzzzzv_, azzzzzzy_);
            bool? bzzzzzza_ = context.Operators.And(azzzzzzl_, azzzzzzz_);

            return bzzzzzza_;
        };
        IEnumerable<Observation> zzzzzzz_ = context.Operators.Where<Observation>(zzzzzzx_, zzzzzzy_);

        return zzzzzzz_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet bzzzzzzs_ = this.FIT_DNA(context);
        IEnumerable<Observation> bzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzu_(Observation FitDNA)
        {
            List<CodeableConcept> bzzzzzzw_ = FitDNA?.Category;
            bool? bzzzzzzx_(CodeableConcept FitDNACategory)
            {
                List<Coding> czzzzzzs_ = FitDNACategory?.Coding;
                bool? czzzzzzt_(Coding @this)
                {
                    Code dzzzzzze_ = @this?.CodeElement;
                    bool? dzzzzzzf_ = context.Operators.Not((bool?)(dzzzzzze_ is null));

                    return dzzzzzzf_;
                };
                IEnumerable<Coding> czzzzzzu_ = context.Operators.Where<Coding>((IEnumerable<Coding>)czzzzzzs_, czzzzzzt_);
                Code czzzzzzv_(Coding @this)
                {
                    Code dzzzzzzg_ = @this?.CodeElement;

                    return dzzzzzzg_;
                };
                IEnumerable<Code> czzzzzzw_ = context.Operators.Select<Coding, Code>(czzzzzzu_, czzzzzzv_);
                bool? czzzzzzx_(Code @this)
                {
                    string dzzzzzzh_ = @this?.Value;
                    bool? dzzzzzzi_ = context.Operators.Not((bool?)(dzzzzzzh_ is null));

                    return dzzzzzzi_;
                };
                IEnumerable<Code> czzzzzzy_ = context.Operators.Where<Code>(czzzzzzw_, czzzzzzx_);
                string czzzzzzz_(Code @this)
                {
                    string dzzzzzzj_ = @this?.Value;

                    return dzzzzzzj_;
                };
                IEnumerable<string> dzzzzzza_ = context.Operators.Select<Code, string>(czzzzzzy_, czzzzzzz_);
                string[] dzzzzzzb_ = [
                    "laboratory",
                ];
                bool? dzzzzzzc_ = context.Operators.Equivalent<string>(dzzzzzza_, dzzzzzzb_ as IEnumerable<string>);
                bool? dzzzzzzd_ = context.Operators.Not(dzzzzzzc_);

                return dzzzzzzd_;
            };
            IEnumerable<CodeableConcept> bzzzzzzy_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzzw_, bzzzzzzx_);
            bool? bzzzzzzz_ = context.Operators.Exists<CodeableConcept>(bzzzzzzy_);
            DataType czzzzzza_ = FitDNA?.Value;
            bool? czzzzzzb_ = context.Operators.Not((bool?)(czzzzzza_ is null));
            bool? czzzzzzc_ = context.Operators.And(bzzzzzzz_, czzzzzzb_);
            DataType czzzzzzd_ = FitDNA?.Effective;
            CqlDateTime czzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, czzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzg_ = context.Operators.End(czzzzzzf_);
            CqlQuantity czzzzzzh_ = context.Operators.Quantity(3m, "years");
            CqlDateTime czzzzzzi_ = context.Operators.Subtract(czzzzzzg_, czzzzzzh_);
            CqlDateTime czzzzzzk_ = context.Operators.End(czzzzzzf_);
            CqlInterval<CqlDateTime> czzzzzzl_ = context.Operators.Interval(czzzzzzi_, czzzzzzk_, true, true);
            bool? czzzzzzm_ = context.Operators.In<CqlDateTime>(czzzzzze_, czzzzzzl_, "day");
            CqlDateTime czzzzzzo_ = context.Operators.End(czzzzzzf_);
            bool? czzzzzzp_ = context.Operators.Not((bool?)(czzzzzzo_ is null));
            bool? czzzzzzq_ = context.Operators.And(czzzzzzm_, czzzzzzp_);
            bool? czzzzzzr_ = context.Operators.And(czzzzzzc_, czzzzzzq_);

            return czzzzzzr_;
        };
        IEnumerable<Observation> bzzzzzzv_ = context.Operators.Where<Observation>(bzzzzzzt_, bzzzzzzu_);

        return bzzzzzzv_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet dzzzzzzk_ = this.FIT_DNA(context);
        IEnumerable<Observation> dzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? dzzzzzzm_(Observation FitDNA)
        {
            Code<ObservationStatus> dzzzzzzo_ = FitDNA?.StatusElement;
            string dzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzo_);
            string[] dzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzr_ = context.Operators.In<string>(dzzzzzzp_, dzzzzzzq_ as IEnumerable<string>);
            bool? dzzzzzzs_ = context.Operators.Not(dzzzzzzr_);
            DataType dzzzzzzt_ = FitDNA?.Value;
            bool? dzzzzzzu_ = context.Operators.Not((bool?)(dzzzzzzt_ is null));
            bool? dzzzzzzv_ = context.Operators.And(dzzzzzzs_, dzzzzzzu_);
            DataType dzzzzzzw_ = FitDNA?.Effective;
            CqlDateTime dzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, dzzzzzzw_);
            CqlInterval<CqlDateTime> dzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzz_ = context.Operators.End(dzzzzzzy_);
            CqlQuantity ezzzzzza_ = context.Operators.Quantity(3m, "years");
            CqlDateTime ezzzzzzb_ = context.Operators.Subtract(dzzzzzzz_, ezzzzzza_);
            CqlDateTime ezzzzzzd_ = context.Operators.End(dzzzzzzy_);
            CqlInterval<CqlDateTime> ezzzzzze_ = context.Operators.Interval(ezzzzzzb_, ezzzzzzd_, true, true);
            bool? ezzzzzzf_ = context.Operators.In<CqlDateTime>(dzzzzzzx_, ezzzzzze_, "day");
            CqlDateTime ezzzzzzh_ = context.Operators.End(dzzzzzzy_);
            bool? ezzzzzzi_ = context.Operators.Not((bool?)(ezzzzzzh_ is null));
            bool? ezzzzzzj_ = context.Operators.And(ezzzzzzf_, ezzzzzzi_);
            bool? ezzzzzzk_ = context.Operators.And(dzzzzzzv_, ezzzzzzj_);

            return ezzzzzzk_;
        };
        IEnumerable<Observation> dzzzzzzn_ = context.Operators.Where<Observation>(dzzzzzzl_, dzzzzzzm_);

        return dzzzzzzn_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet ezzzzzzl_ = this.CT_Colonography(context);
        IEnumerable<Observation> ezzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzzn_(Observation Colonography)
        {
            DataType ezzzzzzs_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> ezzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzs_);
            CqlDateTime ezzzzzzu_ = context.Operators.End(ezzzzzzt_);
            CqlInterval<CqlDateTime> ezzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzw_ = context.Operators.End(ezzzzzzv_);
            CqlQuantity ezzzzzzx_ = context.Operators.Quantity(6m, "years");
            CqlDateTime ezzzzzzy_ = context.Operators.Subtract(ezzzzzzw_, ezzzzzzx_);
            CqlDateTime fzzzzzza_ = context.Operators.End(ezzzzzzv_);
            CqlInterval<CqlDateTime> fzzzzzzb_ = context.Operators.Interval(ezzzzzzy_, fzzzzzza_, true, true);
            bool? fzzzzzzc_ = context.Operators.In<CqlDateTime>(ezzzzzzu_, fzzzzzzb_, default);
            CqlDateTime fzzzzzze_ = context.Operators.End(ezzzzzzv_);
            bool? fzzzzzzf_ = context.Operators.Not((bool?)(fzzzzzze_ is null));
            bool? fzzzzzzg_ = context.Operators.And(fzzzzzzc_, fzzzzzzf_);

            return fzzzzzzg_;
        };
        IEnumerable<Observation> ezzzzzzo_ = context.Operators.Where<Observation>(ezzzzzzm_, ezzzzzzn_);
        CqlDateTime ezzzzzzp_(Observation Colonography)
        {
            DataType fzzzzzzh_ = Colonography?.Effective;
            CqlDateTime fzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, fzzzzzzh_);

            return fzzzzzzi_;
        };
        IEnumerable<CqlDateTime> ezzzzzzq_ = context.Operators.Select<Observation, CqlDateTime>(ezzzzzzo_, ezzzzzzp_);
        IEnumerable<CqlDateTime> ezzzzzzr_ = context.Operators.Distinct<CqlDateTime>(ezzzzzzq_);

        return ezzzzzzr_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet fzzzzzzj_ = this.CT_Colonography(context);
        IEnumerable<Observation> fzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? fzzzzzzl_(Observation Colonography)
        {
            Code<ObservationStatus> fzzzzzzn_ = Colonography?.StatusElement;
            string fzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzn_);
            string[] fzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? fzzzzzzq_ = context.Operators.In<string>(fzzzzzzo_, fzzzzzzp_ as IEnumerable<string>);
            DataType fzzzzzzr_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> fzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzr_);
            CqlDateTime fzzzzzzt_ = context.Operators.End(fzzzzzzs_);
            CqlInterval<CqlDateTime> fzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzv_ = context.Operators.End(fzzzzzzu_);
            CqlQuantity fzzzzzzw_ = context.Operators.Quantity(5m, "years");
            CqlDateTime fzzzzzzx_ = context.Operators.Subtract(fzzzzzzv_, fzzzzzzw_);
            CqlDateTime fzzzzzzz_ = context.Operators.End(fzzzzzzu_);
            CqlInterval<CqlDateTime> gzzzzzza_ = context.Operators.Interval(fzzzzzzx_, fzzzzzzz_, true, true);
            bool? gzzzzzzb_ = context.Operators.In<CqlDateTime>(fzzzzzzt_, gzzzzzza_, default);
            CqlDateTime gzzzzzzd_ = context.Operators.End(fzzzzzzu_);
            bool? gzzzzzze_ = context.Operators.Not((bool?)(gzzzzzzd_ is null));
            bool? gzzzzzzf_ = context.Operators.And(gzzzzzzb_, gzzzzzze_);
            bool? gzzzzzzg_ = context.Operators.And(fzzzzzzq_, gzzzzzzf_);

            return gzzzzzzg_;
        };
        IEnumerable<Observation> fzzzzzzm_ = context.Operators.Where<Observation>(fzzzzzzk_, fzzzzzzl_);

        return fzzzzzzm_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet gzzzzzzh_ = this.CT_Colonography(context);
        IEnumerable<Observation> gzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? gzzzzzzj_(Observation Colonography)
        {
            Code<ObservationStatus> gzzzzzzl_ = Colonography?.StatusElement;
            string gzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzl_);
            string[] gzzzzzzn_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? gzzzzzzo_ = context.Operators.In<string>(gzzzzzzm_, gzzzzzzn_ as IEnumerable<string>);
            bool? gzzzzzzp_ = context.Operators.Not(gzzzzzzo_);
            DataType gzzzzzzq_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> gzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzq_);
            CqlDateTime gzzzzzzs_ = context.Operators.End(gzzzzzzr_);
            CqlInterval<CqlDateTime> gzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzu_ = context.Operators.End(gzzzzzzt_);
            CqlQuantity gzzzzzzv_ = context.Operators.Quantity(5m, "years");
            CqlDateTime gzzzzzzw_ = context.Operators.Subtract(gzzzzzzu_, gzzzzzzv_);
            CqlDateTime gzzzzzzy_ = context.Operators.End(gzzzzzzt_);
            CqlInterval<CqlDateTime> gzzzzzzz_ = context.Operators.Interval(gzzzzzzw_, gzzzzzzy_, true, true);
            bool? hzzzzzza_ = context.Operators.In<CqlDateTime>(gzzzzzzs_, gzzzzzzz_, default);
            CqlDateTime hzzzzzzc_ = context.Operators.End(gzzzzzzt_);
            bool? hzzzzzzd_ = context.Operators.Not((bool?)(hzzzzzzc_ is null));
            bool? hzzzzzze_ = context.Operators.And(hzzzzzza_, hzzzzzzd_);
            bool? hzzzzzzf_ = context.Operators.And(gzzzzzzp_, hzzzzzze_);

            return hzzzzzzf_;
        };
        IEnumerable<Observation> gzzzzzzk_ = context.Operators.Where<Observation>(gzzzzzzi_, gzzzzzzj_);

        return gzzzzzzk_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet hzzzzzzg_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> hzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? hzzzzzzi_(Procedure FlexibleSigmoidoscopy)
        {
            DataType hzzzzzzn_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> hzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzn_);
            CqlDateTime hzzzzzzp_ = context.Operators.End(hzzzzzzo_);
            CqlInterval<CqlDateTime> hzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzr_ = context.Operators.End(hzzzzzzq_);
            CqlQuantity hzzzzzzs_ = context.Operators.Quantity(6m, "years");
            CqlDateTime hzzzzzzt_ = context.Operators.Subtract(hzzzzzzr_, hzzzzzzs_);
            CqlDateTime hzzzzzzv_ = context.Operators.End(hzzzzzzq_);
            CqlInterval<CqlDateTime> hzzzzzzw_ = context.Operators.Interval(hzzzzzzt_, hzzzzzzv_, true, true);
            bool? hzzzzzzx_ = context.Operators.In<CqlDateTime>(hzzzzzzp_, hzzzzzzw_, default);
            CqlDateTime hzzzzzzz_ = context.Operators.End(hzzzzzzq_);
            bool? izzzzzza_ = context.Operators.Not((bool?)(hzzzzzzz_ is null));
            bool? izzzzzzb_ = context.Operators.And(hzzzzzzx_, izzzzzza_);

            return izzzzzzb_;
        };
        IEnumerable<Procedure> hzzzzzzj_ = context.Operators.Where<Procedure>(hzzzzzzh_, hzzzzzzi_);
        CqlDateTime hzzzzzzk_(Procedure FlexibleSigmoidoscopy)
        {
            DataType izzzzzzc_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime izzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, izzzzzzc_);

            return izzzzzzd_;
        };
        IEnumerable<CqlDateTime> hzzzzzzl_ = context.Operators.Select<Procedure, CqlDateTime>(hzzzzzzj_, hzzzzzzk_);
        IEnumerable<CqlDateTime> hzzzzzzm_ = context.Operators.Distinct<CqlDateTime>(hzzzzzzl_);

        return hzzzzzzm_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet izzzzzze_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> izzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzzzzzg_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> izzzzzzi_ = FlexibleSigmoidoscopy?.StatusElement;
            string izzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzi_);
            bool? izzzzzzk_ = context.Operators.Equal(izzzzzzj_, "completed");
            DataType izzzzzzl_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> izzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzl_);
            CqlDateTime izzzzzzn_ = context.Operators.End(izzzzzzm_);
            CqlInterval<CqlDateTime> izzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzp_ = context.Operators.End(izzzzzzo_);
            CqlQuantity izzzzzzq_ = context.Operators.Quantity(5m, "years");
            CqlDateTime izzzzzzr_ = context.Operators.Subtract(izzzzzzp_, izzzzzzq_);
            CqlDateTime izzzzzzt_ = context.Operators.End(izzzzzzo_);
            CqlInterval<CqlDateTime> izzzzzzu_ = context.Operators.Interval(izzzzzzr_, izzzzzzt_, true, true);
            bool? izzzzzzv_ = context.Operators.In<CqlDateTime>(izzzzzzn_, izzzzzzu_, default);
            CqlDateTime izzzzzzx_ = context.Operators.End(izzzzzzo_);
            bool? izzzzzzy_ = context.Operators.Not((bool?)(izzzzzzx_ is null));
            bool? izzzzzzz_ = context.Operators.And(izzzzzzv_, izzzzzzy_);
            bool? jzzzzzza_ = context.Operators.And(izzzzzzk_, izzzzzzz_);

            return jzzzzzza_;
        };
        IEnumerable<Procedure> izzzzzzh_ = context.Operators.Where<Procedure>(izzzzzzf_, izzzzzzg_);

        return izzzzzzh_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet jzzzzzzb_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> jzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? jzzzzzzd_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> jzzzzzzf_ = FlexibleSigmoidoscopy?.StatusElement;
            string jzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzf_);
            bool? jzzzzzzh_ = context.Operators.Equal(jzzzzzzg_, "completed");
            bool? jzzzzzzi_ = context.Operators.Not(jzzzzzzh_);
            DataType jzzzzzzj_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> jzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzj_);
            CqlDateTime jzzzzzzl_ = context.Operators.End(jzzzzzzk_);
            CqlInterval<CqlDateTime> jzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzn_ = context.Operators.End(jzzzzzzm_);
            CqlQuantity jzzzzzzo_ = context.Operators.Quantity(5m, "years");
            CqlDateTime jzzzzzzp_ = context.Operators.Subtract(jzzzzzzn_, jzzzzzzo_);
            CqlDateTime jzzzzzzr_ = context.Operators.End(jzzzzzzm_);
            CqlInterval<CqlDateTime> jzzzzzzs_ = context.Operators.Interval(jzzzzzzp_, jzzzzzzr_, true, true);
            bool? jzzzzzzt_ = context.Operators.In<CqlDateTime>(jzzzzzzl_, jzzzzzzs_, default);
            CqlDateTime jzzzzzzv_ = context.Operators.End(jzzzzzzm_);
            bool? jzzzzzzw_ = context.Operators.Not((bool?)(jzzzzzzv_ is null));
            bool? jzzzzzzx_ = context.Operators.And(jzzzzzzt_, jzzzzzzw_);
            bool? jzzzzzzy_ = context.Operators.And(jzzzzzzi_, jzzzzzzx_);

            return jzzzzzzy_;
        };
        IEnumerable<Procedure> jzzzzzze_ = context.Operators.Where<Procedure>(jzzzzzzc_, jzzzzzzd_);

        return jzzzzzze_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet jzzzzzzz_ = this.Colonoscopy(context);
        IEnumerable<Procedure> kzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? kzzzzzzb_(Procedure Colonoscopy)
        {
            DataType kzzzzzzg_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> kzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzg_);
            CqlDateTime kzzzzzzi_ = context.Operators.End(kzzzzzzh_);
            CqlInterval<CqlDateTime> kzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzk_ = context.Operators.End(kzzzzzzj_);
            CqlQuantity kzzzzzzl_ = context.Operators.Quantity(11m, "years");
            CqlDateTime kzzzzzzm_ = context.Operators.Subtract(kzzzzzzk_, kzzzzzzl_);
            CqlDateTime kzzzzzzo_ = context.Operators.End(kzzzzzzj_);
            CqlInterval<CqlDateTime> kzzzzzzp_ = context.Operators.Interval(kzzzzzzm_, kzzzzzzo_, true, true);
            bool? kzzzzzzq_ = context.Operators.In<CqlDateTime>(kzzzzzzi_, kzzzzzzp_, default);
            CqlDateTime kzzzzzzs_ = context.Operators.End(kzzzzzzj_);
            bool? kzzzzzzt_ = context.Operators.Not((bool?)(kzzzzzzs_ is null));
            bool? kzzzzzzu_ = context.Operators.And(kzzzzzzq_, kzzzzzzt_);

            return kzzzzzzu_;
        };
        IEnumerable<Procedure> kzzzzzzc_ = context.Operators.Where<Procedure>(kzzzzzza_, kzzzzzzb_);
        CqlDateTime kzzzzzzd_(Procedure Colonoscopy)
        {
            DataType kzzzzzzv_ = Colonoscopy?.Performed;
            CqlDateTime kzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, kzzzzzzv_);

            return kzzzzzzw_;
        };
        IEnumerable<CqlDateTime> kzzzzzze_ = context.Operators.Select<Procedure, CqlDateTime>(kzzzzzzc_, kzzzzzzd_);
        IEnumerable<CqlDateTime> kzzzzzzf_ = context.Operators.Distinct<CqlDateTime>(kzzzzzze_);

        return kzzzzzzf_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet kzzzzzzx_ = this.Colonoscopy(context);
        IEnumerable<Procedure> kzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? kzzzzzzz_(Procedure Colonoscopy)
        {
            Code<EventStatus> lzzzzzzb_ = Colonoscopy?.StatusElement;
            string lzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzb_);
            bool? lzzzzzzd_ = context.Operators.Equal(lzzzzzzc_, "completed");
            DataType lzzzzzze_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> lzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzze_);
            CqlDateTime lzzzzzzg_ = context.Operators.End(lzzzzzzf_);
            CqlInterval<CqlDateTime> lzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzi_ = context.Operators.End(lzzzzzzh_);
            CqlQuantity lzzzzzzj_ = context.Operators.Quantity(10m, "years");
            CqlDateTime lzzzzzzk_ = context.Operators.Subtract(lzzzzzzi_, lzzzzzzj_);
            CqlDateTime lzzzzzzm_ = context.Operators.End(lzzzzzzh_);
            CqlInterval<CqlDateTime> lzzzzzzn_ = context.Operators.Interval(lzzzzzzk_, lzzzzzzm_, true, true);
            bool? lzzzzzzo_ = context.Operators.In<CqlDateTime>(lzzzzzzg_, lzzzzzzn_, default);
            CqlDateTime lzzzzzzq_ = context.Operators.End(lzzzzzzh_);
            bool? lzzzzzzr_ = context.Operators.Not((bool?)(lzzzzzzq_ is null));
            bool? lzzzzzzs_ = context.Operators.And(lzzzzzzo_, lzzzzzzr_);
            bool? lzzzzzzt_ = context.Operators.And(lzzzzzzd_, lzzzzzzs_);

            return lzzzzzzt_;
        };
        IEnumerable<Procedure> lzzzzzza_ = context.Operators.Where<Procedure>(kzzzzzzy_, kzzzzzzz_);

        return lzzzzzza_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet lzzzzzzu_ = this.Colonoscopy(context);
        IEnumerable<Procedure> lzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? lzzzzzzw_(Procedure Colonoscopy)
        {
            Code<EventStatus> lzzzzzzy_ = Colonoscopy?.StatusElement;
            string lzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzy_);
            bool? mzzzzzza_ = context.Operators.Equal(lzzzzzzz_, "completed");
            bool? mzzzzzzb_ = context.Operators.Not(mzzzzzza_);
            DataType mzzzzzzc_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> mzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzzzc_);
            CqlDateTime mzzzzzze_ = context.Operators.End(mzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzg_ = context.Operators.End(mzzzzzzf_);
            CqlQuantity mzzzzzzh_ = context.Operators.Quantity(10m, "years");
            CqlDateTime mzzzzzzi_ = context.Operators.Subtract(mzzzzzzg_, mzzzzzzh_);
            CqlDateTime mzzzzzzk_ = context.Operators.End(mzzzzzzf_);
            CqlInterval<CqlDateTime> mzzzzzzl_ = context.Operators.Interval(mzzzzzzi_, mzzzzzzk_, true, true);
            bool? mzzzzzzm_ = context.Operators.In<CqlDateTime>(mzzzzzze_, mzzzzzzl_, default);
            CqlDateTime mzzzzzzo_ = context.Operators.End(mzzzzzzf_);
            bool? mzzzzzzp_ = context.Operators.Not((bool?)(mzzzzzzo_ is null));
            bool? mzzzzzzq_ = context.Operators.And(mzzzzzzm_, mzzzzzzp_);
            bool? mzzzzzzr_ = context.Operators.And(mzzzzzzb_, mzzzzzzq_);

            return mzzzzzzr_;
        };
        IEnumerable<Procedure> lzzzzzzx_ = context.Operators.Where<Procedure>(lzzzzzzv_, lzzzzzzw_);

        return lzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> mzzzzzzs_ = this.Colonoscopy_Performed(context);
        bool? mzzzzzzt_ = context.Operators.Exists<Procedure>(mzzzzzzs_);
        IEnumerable<Observation> mzzzzzzu_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? mzzzzzzv_ = context.Operators.Exists<Observation>(mzzzzzzu_);
        bool? mzzzzzzw_ = context.Operators.Or(mzzzzzzt_, mzzzzzzv_);
        IEnumerable<Procedure> mzzzzzzx_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? mzzzzzzy_ = context.Operators.Exists<Procedure>(mzzzzzzx_);
        bool? mzzzzzzz_ = context.Operators.Or(mzzzzzzw_, mzzzzzzy_);
        IEnumerable<Observation> nzzzzzza_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? nzzzzzzb_ = context.Operators.Exists<Observation>(nzzzzzza_);
        bool? nzzzzzzc_ = context.Operators.Or(mzzzzzzz_, nzzzzzzb_);
        IEnumerable<Observation> nzzzzzzd_ = this.CT_Colonography_Performed(context);
        bool? nzzzzzze_ = context.Operators.Exists<Observation>(nzzzzzzd_);
        bool? nzzzzzzf_ = context.Operators.Or(nzzzzzzc_, nzzzzzze_);

        return nzzzzzzf_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? nzzzzzzg_ = this.Numerator(context);
        bool? nzzzzzzh_ = this.Initial_Population(context);
        bool? nzzzzzzi_ = context.Operators.And(nzzzzzzg_, nzzzzzzh_);
        bool? nzzzzzzj_ = this.Denominator(context);
        bool? nzzzzzzk_ = context.Operators.And(nzzzzzzi_, nzzzzzzj_);
        bool? nzzzzzzl_ = this.Denominator_Exclusions(context);
        bool? nzzzzzzm_ = context.Operators.Not(nzzzzzzl_);
        bool? nzzzzzzn_ = context.Operators.And(nzzzzzzk_, nzzzzzzm_);

        return nzzzzzzn_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
