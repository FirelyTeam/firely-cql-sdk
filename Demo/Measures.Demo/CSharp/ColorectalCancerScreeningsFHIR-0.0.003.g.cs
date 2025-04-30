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
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null,
          _laboratory);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime gzzzzzo_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime gzzzzzp_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> gzzzzzq_ = context.Operators.Interval(gzzzzzo_, gzzzzzp_, true, false);
        object gzzzzzr_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", gzzzzzq_);

        return (CqlInterval<CqlDateTime>)gzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient gzzzzzt_ = context.Operators.SingletonFrom<Patient>(gzzzzzs_);

        return gzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> gzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return gzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> gzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return gzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> gzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return gzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode gzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return gzzzzzx_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet gzzzzzy_ = this.Online_Assessments(context);
        IEnumerable<Encounter> gzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet hzzzzza_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> hzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> hzzzzzc_ = context.Operators.Union<Encounter>(gzzzzzz_, hzzzzzb_);
        bool? hzzzzzd_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> hzzzzzf_ = TelehealthEncounter?.StatusElement;
            string hzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzf_);
            bool? hzzzzzh_ = context.Operators.Equal(hzzzzzg_, "finished");
            CqlInterval<CqlDateTime> hzzzzzi_ = this.Measurement_Period(context);
            Period hzzzzzj_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzj_ as object);
            bool? hzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzi_, hzzzzzk_, default);
            bool? hzzzzzm_ = context.Operators.And(hzzzzzh_, hzzzzzl_);

            return hzzzzzm_;
        };
        IEnumerable<Encounter> hzzzzze_ = context.Operators.Where<Encounter>(hzzzzzc_, hzzzzzd_);

        return hzzzzze_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient hzzzzzn_ = this.Patient(context);
        Date hzzzzzo_ = hzzzzzn_?.BirthDateElement;
        string hzzzzzp_ = hzzzzzo_?.Value;
        CqlDate hzzzzzq_ = context.Operators.ConvertStringToDate(hzzzzzp_);
        CqlInterval<CqlDateTime> hzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzs_ = context.Operators.Start(hzzzzzr_);
        CqlDate hzzzzzt_ = context.Operators.DateFrom(hzzzzzs_);
        int? hzzzzzu_ = context.Operators.CalculateAgeAt(hzzzzzq_, hzzzzzt_, "year");

        return hzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient hzzzzzv_ = this.Patient(context);
        Date hzzzzzw_ = hzzzzzv_?.BirthDateElement;
        string hzzzzzx_ = hzzzzzw_?.Value;
        CqlDate hzzzzzy_ = context.Operators.ConvertStringToDate(hzzzzzx_);
        CqlInterval<CqlDateTime> hzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime izzzzza_ = context.Operators.Start(hzzzzzz_);
        CqlDate izzzzzb_ = context.Operators.DateFrom(izzzzza_);
        int? izzzzzc_ = context.Operators.CalculateAgeAt(hzzzzzy_, izzzzzb_, "year");
        CqlInterval<int?> izzzzzd_ = context.Operators.Interval(51, 75, true, false);
        bool? izzzzze_ = context.Operators.In<int?>(izzzzzc_, izzzzzd_, default);
        IEnumerable<Encounter> izzzzzf_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> izzzzzg_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> izzzzzh_ = context.Operators.Union<Encounter>(izzzzzf_, izzzzzg_);
        bool? izzzzzi_ = context.Operators.Exists<Encounter>(izzzzzh_);
        bool? izzzzzj_ = context.Operators.And(izzzzze_, izzzzzi_);

        return izzzzzj_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? izzzzzk_ = this.Initial_Population(context);

        return izzzzzk_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet izzzzzl_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> izzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? izzzzzn_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> izzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime izzzzzq_ = context.Operators.Start(izzzzzp_);
            CqlInterval<CqlDateTime> izzzzzr_ = this.Measurement_Period(context);
            CqlDateTime izzzzzs_ = context.Operators.End(izzzzzr_);
            bool? izzzzzt_ = context.Operators.SameOrBefore(izzzzzq_, izzzzzs_, default);

            return izzzzzt_;
        };
        IEnumerable<Condition> izzzzzo_ = context.Operators.Where<Condition>(izzzzzm_, izzzzzn_);

        return izzzzzo_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet izzzzzu_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> izzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzzzzw_(Procedure Colectomy)
        {
            Code<EventStatus> izzzzzy_ = Colectomy?.StatusElement;
            string izzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzy_);
            bool? jzzzzza_ = context.Operators.Equal(izzzzzz_, "completed");
            DataType jzzzzzb_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> jzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzb_);
            CqlDateTime jzzzzzd_ = context.Operators.End(jzzzzzc_);
            CqlInterval<CqlDateTime> jzzzzze_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzf_ = context.Operators.End(jzzzzze_);
            bool? jzzzzzg_ = context.Operators.SameOrBefore(jzzzzzd_, jzzzzzf_, default);
            bool? jzzzzzh_ = context.Operators.And(jzzzzza_, jzzzzzg_);

            return jzzzzzh_;
        };
        IEnumerable<Procedure> izzzzzx_ = context.Operators.Where<Procedure>(izzzzzv_, izzzzzw_);

        return izzzzzx_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet jzzzzzi_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> jzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? jzzzzzk_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> jzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime jzzzzzn_ = context.Operators.Start(jzzzzzm_);
            CqlInterval<CqlDateTime> jzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzp_ = context.Operators.End(jzzzzzo_);
            bool? jzzzzzq_ = context.Operators.SameOrBefore(jzzzzzn_, jzzzzzp_, default);

            return jzzzzzq_;
        };
        IEnumerable<Condition> jzzzzzl_ = context.Operators.Where<Condition>(jzzzzzj_, jzzzzzk_);

        return jzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? jzzzzzr_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> jzzzzzs_ = this.Malignant_Neoplasm(context);
        bool? jzzzzzt_ = context.Operators.Exists<Condition>(jzzzzzs_);
        bool? jzzzzzu_ = context.Operators.Or(jzzzzzr_, jzzzzzt_);
        IEnumerable<Procedure> jzzzzzv_ = this.Total_Colectomy_Performed(context);
        bool? jzzzzzw_ = context.Operators.Exists<Procedure>(jzzzzzv_);
        bool? jzzzzzx_ = context.Operators.Or(jzzzzzu_, jzzzzzw_);
        IEnumerable<Condition> jzzzzzy_ = this.Total_Colectomy_Condition(context);
        bool? jzzzzzz_ = context.Operators.Exists<Condition>(jzzzzzy_);
        bool? kzzzzza_ = context.Operators.Or(jzzzzzx_, jzzzzzz_);
        bool? kzzzzzb_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? kzzzzzc_ = context.Operators.Or(kzzzzza_, kzzzzzb_);
        Patient kzzzzzd_ = this.Patient(context);
        Date kzzzzze_ = kzzzzzd_?.BirthDateElement;
        string kzzzzzf_ = kzzzzze_?.Value;
        CqlDate kzzzzzg_ = context.Operators.ConvertStringToDate(kzzzzzf_);
        CqlInterval<CqlDateTime> kzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzi_ = context.Operators.Start(kzzzzzh_);
        CqlDate kzzzzzj_ = context.Operators.DateFrom(kzzzzzi_);
        int? kzzzzzk_ = context.Operators.CalculateAgeAt(kzzzzzg_, kzzzzzj_, "year");
        bool? kzzzzzl_ = context.Operators.GreaterOrEqual(kzzzzzk_, 65);
        bool? kzzzzzm_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? kzzzzzn_ = context.Operators.And(kzzzzzl_, kzzzzzm_);
        bool? kzzzzzo_ = context.Operators.Or(kzzzzzc_, kzzzzzn_);
        bool? kzzzzzp_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? kzzzzzq_ = context.Operators.Or(kzzzzzo_, kzzzzzp_);

        return kzzzzzq_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet kzzzzzr_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> kzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzzzzt_(Observation FecalOccult)
        {
            DataType kzzzzzy_ = FecalOccult?.Effective;
            CqlDateTime kzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, kzzzzzy_);
            CqlInterval<CqlDateTime> lzzzzza_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzb_ = context.Operators.Start(lzzzzza_);
            CqlQuantity lzzzzzc_ = context.Operators.Quantity(1m, "year");
            CqlDateTime lzzzzzd_ = context.Operators.Subtract(lzzzzzb_, lzzzzzc_);
            CqlDateTime lzzzzzf_ = context.Operators.End(lzzzzza_);
            CqlInterval<CqlDateTime> lzzzzzg_ = context.Operators.Interval(lzzzzzd_, lzzzzzf_, false, false);
            bool? lzzzzzh_ = context.Operators.In<CqlDateTime>(kzzzzzz_, lzzzzzg_, default);

            return lzzzzzh_;
        };
        IEnumerable<Observation> kzzzzzu_ = context.Operators.Where<Observation>(kzzzzzs_, kzzzzzt_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? kzzzzzv_(Observation FecalOccult)
        {
            DataType lzzzzzi_ = FecalOccult?.Effective;
            CqlDateTime lzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, lzzzzzi_);
            DataType lzzzzzk_ = FecalOccult?.Value;
            IEnumerable<Coding> lzzzzzl_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(lzzzzzk_, "coding");
            bool? lzzzzzm_(Coding @this)
            {
                FhirString mzzzzzg_ = @this?.DisplayElement;
                bool? mzzzzzh_ = context.Operators.Not((bool?)(mzzzzzg_ is null));

                return mzzzzzh_;
            };
            IEnumerable<Coding> lzzzzzn_ = context.Operators.Where<Coding>(lzzzzzl_, lzzzzzm_);
            FhirString lzzzzzo_(Coding @this)
            {
                FhirString mzzzzzi_ = @this?.DisplayElement;

                return mzzzzzi_;
            };
            IEnumerable<FhirString> lzzzzzp_ = context.Operators.Select<Coding, FhirString>(lzzzzzn_, lzzzzzo_);
            List<CodeableConcept> lzzzzzq_ = FecalOccult?.Category;
            bool? lzzzzzr_(CodeableConcept @this)
            {
                List<Coding> mzzzzzj_ = @this?.Coding;
                bool? mzzzzzk_ = context.Operators.Not((bool?)(mzzzzzj_ is null));

                return mzzzzzk_;
            };
            IEnumerable<CodeableConcept> lzzzzzs_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzzzq_, lzzzzzr_);
            List<Coding> lzzzzzt_(CodeableConcept @this)
            {
                List<Coding> mzzzzzl_ = @this?.Coding;

                return mzzzzzl_;
            };
            IEnumerable<List<Coding>> lzzzzzu_ = context.Operators.Select<CodeableConcept, List<Coding>>(lzzzzzs_, lzzzzzt_);
            IEnumerable<Coding> lzzzzzv_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)lzzzzzu_);
            bool? lzzzzzw_(Coding @this)
            {
                Code mzzzzzm_ = @this?.CodeElement;
                bool? mzzzzzn_ = context.Operators.Not((bool?)(mzzzzzm_ is null));

                return mzzzzzn_;
            };
            IEnumerable<Coding> lzzzzzx_ = context.Operators.Where<Coding>(lzzzzzv_, lzzzzzw_);
            Code lzzzzzy_(Coding @this)
            {
                Code mzzzzzo_ = @this?.CodeElement;

                return mzzzzzo_;
            };
            IEnumerable<Code> lzzzzzz_ = context.Operators.Select<Coding, Code>(lzzzzzx_, lzzzzzy_);
            bool? mzzzzza_(Code @this)
            {
                string mzzzzzp_ = @this?.Value;
                bool? mzzzzzq_ = context.Operators.Not((bool?)(mzzzzzp_ is null));

                return mzzzzzq_;
            };
            IEnumerable<Code> mzzzzzb_ = context.Operators.Where<Code>(lzzzzzz_, mzzzzza_);
            string mzzzzzc_(Code @this)
            {
                string mzzzzzr_ = @this?.Value;

                return mzzzzzr_;
            };
            IEnumerable<string> mzzzzzd_ = context.Operators.Select<Code, string>(mzzzzzb_, mzzzzzc_);
            Code<ObservationStatus> mzzzzze_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? mzzzzzf_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, lzzzzzj_, lzzzzzp_, mzzzzzd_, mzzzzze_);

            return mzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> kzzzzzw_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(kzzzzzu_, kzzzzzv_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> kzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(kzzzzzw_);

        return kzzzzzx_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet mzzzzzs_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> mzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? mzzzzzu_(Observation FecalOccult)
        {
            Code<ObservationStatus> mzzzzzw_ = FecalOccult?.StatusElement;
            string mzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzw_);
            string[] mzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzz_ = context.Operators.In<string>(mzzzzzx_, mzzzzzy_ as IEnumerable<string>);
            List<CodeableConcept> nzzzzza_ = FecalOccult?.Category;
            bool? nzzzzzb_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> nzzzzzn_ = FecalOccultCategory?.Coding;
                bool? nzzzzzo_(Coding @this)
                {
                    Code nzzzzzy_ = @this?.CodeElement;
                    bool? nzzzzzz_ = context.Operators.Not((bool?)(nzzzzzy_ is null));

                    return nzzzzzz_;
                };
                IEnumerable<Coding> nzzzzzp_ = context.Operators.Where<Coding>((IEnumerable<Coding>)nzzzzzn_, nzzzzzo_);
                Code nzzzzzq_(Coding @this)
                {
                    Code ozzzzza_ = @this?.CodeElement;

                    return ozzzzza_;
                };
                IEnumerable<Code> nzzzzzr_ = context.Operators.Select<Coding, Code>(nzzzzzp_, nzzzzzq_);
                bool? nzzzzzs_(Code @this)
                {
                    string ozzzzzb_ = @this?.Value;
                    bool? ozzzzzc_ = context.Operators.Not((bool?)(ozzzzzb_ is null));

                    return ozzzzzc_;
                };
                IEnumerable<Code> nzzzzzt_ = context.Operators.Where<Code>(nzzzzzr_, nzzzzzs_);
                string nzzzzzu_(Code @this)
                {
                    string ozzzzzd_ = @this?.Value;

                    return ozzzzzd_;
                };
                IEnumerable<string> nzzzzzv_ = context.Operators.Select<Code, string>(nzzzzzt_, nzzzzzu_);
                string[] nzzzzzw_ = [
                    "laboratory",
                ];
                bool? nzzzzzx_ = context.Operators.Equivalent<string>(nzzzzzv_, nzzzzzw_ as IEnumerable<string>);

                return nzzzzzx_;
            };
            IEnumerable<CodeableConcept> nzzzzzc_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzza_, nzzzzzb_);
            bool? nzzzzzd_ = context.Operators.Exists<CodeableConcept>(nzzzzzc_);
            bool? nzzzzze_ = context.Operators.And(mzzzzzz_, nzzzzzd_);
            DataType nzzzzzf_ = FecalOccult?.Value;
            bool? nzzzzzg_ = context.Operators.Not((bool?)(nzzzzzf_ is null));
            bool? nzzzzzh_ = context.Operators.And(nzzzzze_, nzzzzzg_);
            DataType nzzzzzi_ = FecalOccult?.Effective;
            CqlDateTime nzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, nzzzzzi_);
            CqlInterval<CqlDateTime> nzzzzzk_ = this.Measurement_Period(context);
            bool? nzzzzzl_ = context.Operators.In<CqlDateTime>(nzzzzzj_, nzzzzzk_, default);
            bool? nzzzzzm_ = context.Operators.And(nzzzzzh_, nzzzzzl_);

            return nzzzzzm_;
        };
        IEnumerable<Observation> mzzzzzv_ = context.Operators.Where<Observation>(mzzzzzt_, mzzzzzu_);

        return mzzzzzv_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet ozzzzze_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> ozzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzzg_(Observation FecalOccult)
        {
            Code<ObservationStatus> ozzzzzi_ = FecalOccult?.StatusElement;
            string ozzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzi_);
            string[] ozzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzl_ = context.Operators.In<string>(ozzzzzj_, ozzzzzk_ as IEnumerable<string>);
            List<CodeableConcept> ozzzzzm_ = FecalOccult?.Category;
            bool? ozzzzzn_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> ozzzzzz_ = FecalOccultCategory?.Coding;
                bool? pzzzzza_(Coding @this)
                {
                    Code pzzzzzk_ = @this?.CodeElement;
                    bool? pzzzzzl_ = context.Operators.Not((bool?)(pzzzzzk_ is null));

                    return pzzzzzl_;
                };
                IEnumerable<Coding> pzzzzzb_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ozzzzzz_, pzzzzza_);
                Code pzzzzzc_(Coding @this)
                {
                    Code pzzzzzm_ = @this?.CodeElement;

                    return pzzzzzm_;
                };
                IEnumerable<Code> pzzzzzd_ = context.Operators.Select<Coding, Code>(pzzzzzb_, pzzzzzc_);
                bool? pzzzzze_(Code @this)
                {
                    string pzzzzzn_ = @this?.Value;
                    bool? pzzzzzo_ = context.Operators.Not((bool?)(pzzzzzn_ is null));

                    return pzzzzzo_;
                };
                IEnumerable<Code> pzzzzzf_ = context.Operators.Where<Code>(pzzzzzd_, pzzzzze_);
                string pzzzzzg_(Code @this)
                {
                    string pzzzzzp_ = @this?.Value;

                    return pzzzzzp_;
                };
                IEnumerable<string> pzzzzzh_ = context.Operators.Select<Code, string>(pzzzzzf_, pzzzzzg_);
                string[] pzzzzzi_ = [
                    "laboratory",
                ];
                bool? pzzzzzj_ = context.Operators.Equivalent<string>(pzzzzzh_, pzzzzzi_ as IEnumerable<string>);

                return pzzzzzj_;
            };
            IEnumerable<CodeableConcept> ozzzzzo_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzzm_, ozzzzzn_);
            bool? ozzzzzp_ = context.Operators.Exists<CodeableConcept>(ozzzzzo_);
            bool? ozzzzzq_ = context.Operators.And(ozzzzzl_, ozzzzzp_);
            DataType ozzzzzr_ = FecalOccult?.Value;
            bool? ozzzzzs_ = context.Operators.Not((bool?)(ozzzzzr_ is null));
            bool? ozzzzzt_ = context.Operators.And(ozzzzzq_, ozzzzzs_);
            DataType ozzzzzu_ = FecalOccult?.Effective;
            CqlDateTime ozzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ozzzzzu_);
            CqlInterval<CqlDateTime> ozzzzzw_ = this.Measurement_Period(context);
            bool? ozzzzzx_ = context.Operators.In<CqlDateTime>(ozzzzzv_, ozzzzzw_, "day");
            bool? ozzzzzy_ = context.Operators.And(ozzzzzt_, ozzzzzx_);

            return ozzzzzy_;
        };
        IEnumerable<Observation> ozzzzzh_ = context.Operators.Where<Observation>(ozzzzzf_, ozzzzzg_);

        return ozzzzzh_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet pzzzzzq_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> pzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzzzs_(Observation FecalOccult)
        {
            List<CodeableConcept> pzzzzzu_ = FecalOccult?.Category;
            bool? pzzzzzv_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> qzzzzzg_ = FecalOccultCategory?.Coding;
                bool? qzzzzzh_(Coding @this)
                {
                    Code qzzzzzs_ = @this?.CodeElement;
                    bool? qzzzzzt_ = context.Operators.Not((bool?)(qzzzzzs_ is null));

                    return qzzzzzt_;
                };
                IEnumerable<Coding> qzzzzzi_ = context.Operators.Where<Coding>((IEnumerable<Coding>)qzzzzzg_, qzzzzzh_);
                Code qzzzzzj_(Coding @this)
                {
                    Code qzzzzzu_ = @this?.CodeElement;

                    return qzzzzzu_;
                };
                IEnumerable<Code> qzzzzzk_ = context.Operators.Select<Coding, Code>(qzzzzzi_, qzzzzzj_);
                bool? qzzzzzl_(Code @this)
                {
                    string qzzzzzv_ = @this?.Value;
                    bool? qzzzzzw_ = context.Operators.Not((bool?)(qzzzzzv_ is null));

                    return qzzzzzw_;
                };
                IEnumerable<Code> qzzzzzm_ = context.Operators.Where<Code>(qzzzzzk_, qzzzzzl_);
                string qzzzzzn_(Code @this)
                {
                    string qzzzzzx_ = @this?.Value;

                    return qzzzzzx_;
                };
                IEnumerable<string> qzzzzzo_ = context.Operators.Select<Code, string>(qzzzzzm_, qzzzzzn_);
                string[] qzzzzzp_ = [
                    "laboratory",
                ];
                bool? qzzzzzq_ = context.Operators.Equivalent<string>(qzzzzzo_, qzzzzzp_ as IEnumerable<string>);
                bool? qzzzzzr_ = context.Operators.Not(qzzzzzq_);

                return qzzzzzr_;
            };
            IEnumerable<CodeableConcept> pzzzzzw_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzzu_, pzzzzzv_);
            bool? pzzzzzx_ = context.Operators.Exists<CodeableConcept>(pzzzzzw_);
            DataType pzzzzzy_ = FecalOccult?.Value;
            bool? pzzzzzz_ = context.Operators.Not((bool?)(pzzzzzy_ is null));
            bool? qzzzzza_ = context.Operators.And(pzzzzzx_, pzzzzzz_);
            DataType qzzzzzb_ = FecalOccult?.Effective;
            CqlDateTime qzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, qzzzzzb_);
            CqlInterval<CqlDateTime> qzzzzzd_ = this.Measurement_Period(context);
            bool? qzzzzze_ = context.Operators.In<CqlDateTime>(qzzzzzc_, qzzzzzd_, "day");
            bool? qzzzzzf_ = context.Operators.And(qzzzzza_, qzzzzze_);

            return qzzzzzf_;
        };
        IEnumerable<Observation> pzzzzzt_ = context.Operators.Where<Observation>(pzzzzzr_, pzzzzzs_);

        return pzzzzzt_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
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
            bool? rzzzzzg_ = context.Operators.Not(rzzzzzf_);
            DataType rzzzzzh_ = FecalOccult?.Value;
            bool? rzzzzzi_ = context.Operators.Not((bool?)(rzzzzzh_ is null));
            bool? rzzzzzj_ = context.Operators.And(rzzzzzg_, rzzzzzi_);
            DataType rzzzzzk_ = FecalOccult?.Effective;
            CqlDateTime rzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, rzzzzzk_);
            CqlInterval<CqlDateTime> rzzzzzm_ = this.Measurement_Period(context);
            bool? rzzzzzn_ = context.Operators.In<CqlDateTime>(rzzzzzl_, rzzzzzm_, "day");
            bool? rzzzzzo_ = context.Operators.And(rzzzzzj_, rzzzzzn_);

            return rzzzzzo_;
        };
        IEnumerable<Observation> rzzzzzb_ = context.Operators.Where<Observation>(qzzzzzz_, rzzzzza_);

        return rzzzzzb_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet rzzzzzp_ = this.FIT_DNA(context);
        IEnumerable<Observation> rzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzr_(Observation FitDNA)
        {
            DataType rzzzzzw_ = FitDNA?.Effective;
            CqlDateTime rzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, rzzzzzw_);
            CqlInterval<CqlDateTime> rzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzz_ = context.Operators.End(rzzzzzy_);
            CqlQuantity szzzzza_ = context.Operators.Quantity(4m, "years");
            CqlDateTime szzzzzb_ = context.Operators.Subtract(rzzzzzz_, szzzzza_);
            CqlDateTime szzzzzd_ = context.Operators.End(rzzzzzy_);
            CqlInterval<CqlDateTime> szzzzze_ = context.Operators.Interval(szzzzzb_, szzzzzd_, true, true);
            bool? szzzzzf_ = context.Operators.In<CqlDateTime>(rzzzzzx_, szzzzze_, default);
            CqlDateTime szzzzzh_ = context.Operators.End(rzzzzzy_);
            bool? szzzzzi_ = context.Operators.Not((bool?)(szzzzzh_ is null));
            bool? szzzzzj_ = context.Operators.And(szzzzzf_, szzzzzi_);

            return szzzzzj_;
        };
        IEnumerable<Observation> rzzzzzs_ = context.Operators.Where<Observation>(rzzzzzq_, rzzzzzr_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? rzzzzzt_(Observation FitDNA)
        {
            DataType szzzzzk_ = FitDNA?.Effective;
            CqlDateTime szzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzk_);
            DataType szzzzzm_ = FitDNA?.Value;
            IEnumerable<Coding> szzzzzn_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(szzzzzm_, "coding");
            bool? szzzzzo_(Coding @this)
            {
                FhirString tzzzzzi_ = @this?.DisplayElement;
                bool? tzzzzzj_ = context.Operators.Not((bool?)(tzzzzzi_ is null));

                return tzzzzzj_;
            };
            IEnumerable<Coding> szzzzzp_ = context.Operators.Where<Coding>(szzzzzn_, szzzzzo_);
            FhirString szzzzzq_(Coding @this)
            {
                FhirString tzzzzzk_ = @this?.DisplayElement;

                return tzzzzzk_;
            };
            IEnumerable<FhirString> szzzzzr_ = context.Operators.Select<Coding, FhirString>(szzzzzp_, szzzzzq_);
            List<CodeableConcept> szzzzzs_ = FitDNA?.Category;
            bool? szzzzzt_(CodeableConcept @this)
            {
                List<Coding> tzzzzzl_ = @this?.Coding;
                bool? tzzzzzm_ = context.Operators.Not((bool?)(tzzzzzl_ is null));

                return tzzzzzm_;
            };
            IEnumerable<CodeableConcept> szzzzzu_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzzs_, szzzzzt_);
            List<Coding> szzzzzv_(CodeableConcept @this)
            {
                List<Coding> tzzzzzn_ = @this?.Coding;

                return tzzzzzn_;
            };
            IEnumerable<List<Coding>> szzzzzw_ = context.Operators.Select<CodeableConcept, List<Coding>>(szzzzzu_, szzzzzv_);
            IEnumerable<Coding> szzzzzx_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)szzzzzw_);
            bool? szzzzzy_(Coding @this)
            {
                Code tzzzzzo_ = @this?.CodeElement;
                bool? tzzzzzp_ = context.Operators.Not((bool?)(tzzzzzo_ is null));

                return tzzzzzp_;
            };
            IEnumerable<Coding> szzzzzz_ = context.Operators.Where<Coding>(szzzzzx_, szzzzzy_);
            Code tzzzzza_(Coding @this)
            {
                Code tzzzzzq_ = @this?.CodeElement;

                return tzzzzzq_;
            };
            IEnumerable<Code> tzzzzzb_ = context.Operators.Select<Coding, Code>(szzzzzz_, tzzzzza_);
            bool? tzzzzzc_(Code @this)
            {
                string tzzzzzr_ = @this?.Value;
                bool? tzzzzzs_ = context.Operators.Not((bool?)(tzzzzzr_ is null));

                return tzzzzzs_;
            };
            IEnumerable<Code> tzzzzzd_ = context.Operators.Where<Code>(tzzzzzb_, tzzzzzc_);
            string tzzzzze_(Code @this)
            {
                string tzzzzzt_ = @this?.Value;

                return tzzzzzt_;
            };
            IEnumerable<string> tzzzzzf_ = context.Operators.Select<Code, string>(tzzzzzd_, tzzzzze_);
            Code<ObservationStatus> tzzzzzg_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? tzzzzzh_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, szzzzzl_, szzzzzr_, tzzzzzf_, tzzzzzg_);

            return tzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> rzzzzzu_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(rzzzzzs_, rzzzzzt_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> rzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(rzzzzzu_);

        return rzzzzzv_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet tzzzzzu_ = this.FIT_DNA(context);
        IEnumerable<Observation> tzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? tzzzzzw_(Observation FitDNA)
        {
            Code<ObservationStatus> tzzzzzy_ = FitDNA?.StatusElement;
            string tzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzy_);
            string[] uzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzb_ = context.Operators.In<string>(tzzzzzz_, uzzzzza_ as IEnumerable<string>);
            List<CodeableConcept> uzzzzzc_ = FitDNA?.Category;
            bool? uzzzzzd_(CodeableConcept FitDNACategory)
            {
                List<Coding> uzzzzzz_ = FitDNACategory?.Coding;
                bool? vzzzzza_(Coding @this)
                {
                    Code vzzzzzk_ = @this?.CodeElement;
                    bool? vzzzzzl_ = context.Operators.Not((bool?)(vzzzzzk_ is null));

                    return vzzzzzl_;
                };
                IEnumerable<Coding> vzzzzzb_ = context.Operators.Where<Coding>((IEnumerable<Coding>)uzzzzzz_, vzzzzza_);
                Code vzzzzzc_(Coding @this)
                {
                    Code vzzzzzm_ = @this?.CodeElement;

                    return vzzzzzm_;
                };
                IEnumerable<Code> vzzzzzd_ = context.Operators.Select<Coding, Code>(vzzzzzb_, vzzzzzc_);
                bool? vzzzzze_(Code @this)
                {
                    string vzzzzzn_ = @this?.Value;
                    bool? vzzzzzo_ = context.Operators.Not((bool?)(vzzzzzn_ is null));

                    return vzzzzzo_;
                };
                IEnumerable<Code> vzzzzzf_ = context.Operators.Where<Code>(vzzzzzd_, vzzzzze_);
                string vzzzzzg_(Code @this)
                {
                    string vzzzzzp_ = @this?.Value;

                    return vzzzzzp_;
                };
                IEnumerable<string> vzzzzzh_ = context.Operators.Select<Code, string>(vzzzzzf_, vzzzzzg_);
                string[] vzzzzzi_ = [
                    "laboratory",
                ];
                bool? vzzzzzj_ = context.Operators.Equivalent<string>(vzzzzzh_, vzzzzzi_ as IEnumerable<string>);

                return vzzzzzj_;
            };
            IEnumerable<CodeableConcept> uzzzzze_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzzc_, uzzzzzd_);
            bool? uzzzzzf_ = context.Operators.Exists<CodeableConcept>(uzzzzze_);
            bool? uzzzzzg_ = context.Operators.And(uzzzzzb_, uzzzzzf_);
            DataType uzzzzzh_ = FitDNA?.Value;
            bool? uzzzzzi_ = context.Operators.Not((bool?)(uzzzzzh_ is null));
            bool? uzzzzzj_ = context.Operators.And(uzzzzzg_, uzzzzzi_);
            DataType uzzzzzk_ = FitDNA?.Effective;
            CqlDateTime uzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzzzk_);
            CqlInterval<CqlDateTime> uzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzn_ = context.Operators.End(uzzzzzm_);
            CqlQuantity uzzzzzo_ = context.Operators.Quantity(3m, "years");
            CqlDateTime uzzzzzp_ = context.Operators.Subtract(uzzzzzn_, uzzzzzo_);
            CqlDateTime uzzzzzr_ = context.Operators.End(uzzzzzm_);
            CqlInterval<CqlDateTime> uzzzzzs_ = context.Operators.Interval(uzzzzzp_, uzzzzzr_, true, true);
            bool? uzzzzzt_ = context.Operators.In<CqlDateTime>(uzzzzzl_, uzzzzzs_, default);
            CqlDateTime uzzzzzv_ = context.Operators.End(uzzzzzm_);
            bool? uzzzzzw_ = context.Operators.Not((bool?)(uzzzzzv_ is null));
            bool? uzzzzzx_ = context.Operators.And(uzzzzzt_, uzzzzzw_);
            bool? uzzzzzy_ = context.Operators.And(uzzzzzj_, uzzzzzx_);

            return uzzzzzy_;
        };
        IEnumerable<Observation> tzzzzzx_ = context.Operators.Where<Observation>(tzzzzzv_, tzzzzzw_);

        return tzzzzzx_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet vzzzzzq_ = this.FIT_DNA(context);
        IEnumerable<Observation> vzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzs_(Observation FitDNA)
        {
            Code<ObservationStatus> vzzzzzu_ = FitDNA?.StatusElement;
            string vzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzu_);
            string[] vzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzx_ = context.Operators.In<string>(vzzzzzv_, vzzzzzw_ as IEnumerable<string>);
            List<CodeableConcept> vzzzzzy_ = FitDNA?.Category;
            bool? vzzzzzz_(CodeableConcept FitDNACategory)
            {
                List<Coding> wzzzzzv_ = FitDNACategory?.Coding;
                bool? wzzzzzw_(Coding @this)
                {
                    Code xzzzzzg_ = @this?.CodeElement;
                    bool? xzzzzzh_ = context.Operators.Not((bool?)(xzzzzzg_ is null));

                    return xzzzzzh_;
                };
                IEnumerable<Coding> wzzzzzx_ = context.Operators.Where<Coding>((IEnumerable<Coding>)wzzzzzv_, wzzzzzw_);
                Code wzzzzzy_(Coding @this)
                {
                    Code xzzzzzi_ = @this?.CodeElement;

                    return xzzzzzi_;
                };
                IEnumerable<Code> wzzzzzz_ = context.Operators.Select<Coding, Code>(wzzzzzx_, wzzzzzy_);
                bool? xzzzzza_(Code @this)
                {
                    string xzzzzzj_ = @this?.Value;
                    bool? xzzzzzk_ = context.Operators.Not((bool?)(xzzzzzj_ is null));

                    return xzzzzzk_;
                };
                IEnumerable<Code> xzzzzzb_ = context.Operators.Where<Code>(wzzzzzz_, xzzzzza_);
                string xzzzzzc_(Code @this)
                {
                    string xzzzzzl_ = @this?.Value;

                    return xzzzzzl_;
                };
                IEnumerable<string> xzzzzzd_ = context.Operators.Select<Code, string>(xzzzzzb_, xzzzzzc_);
                string[] xzzzzze_ = [
                    "laboratory",
                ];
                bool? xzzzzzf_ = context.Operators.Equivalent<string>(xzzzzzd_, xzzzzze_ as IEnumerable<string>);

                return xzzzzzf_;
            };
            IEnumerable<CodeableConcept> wzzzzza_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzzy_, vzzzzzz_);
            bool? wzzzzzb_ = context.Operators.Exists<CodeableConcept>(wzzzzza_);
            bool? wzzzzzc_ = context.Operators.And(vzzzzzx_, wzzzzzb_);
            DataType wzzzzzd_ = FitDNA?.Value;
            bool? wzzzzze_ = context.Operators.Not((bool?)(wzzzzzd_ is null));
            bool? wzzzzzf_ = context.Operators.And(wzzzzzc_, wzzzzze_);
            DataType wzzzzzg_ = FitDNA?.Effective;
            CqlDateTime wzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, wzzzzzg_);
            CqlInterval<CqlDateTime> wzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzj_ = context.Operators.End(wzzzzzi_);
            CqlQuantity wzzzzzk_ = context.Operators.Quantity(3m, "years");
            CqlDateTime wzzzzzl_ = context.Operators.Subtract(wzzzzzj_, wzzzzzk_);
            CqlDateTime wzzzzzn_ = context.Operators.End(wzzzzzi_);
            CqlInterval<CqlDateTime> wzzzzzo_ = context.Operators.Interval(wzzzzzl_, wzzzzzn_, true, true);
            bool? wzzzzzp_ = context.Operators.In<CqlDateTime>(wzzzzzh_, wzzzzzo_, "day");
            CqlDateTime wzzzzzr_ = context.Operators.End(wzzzzzi_);
            bool? wzzzzzs_ = context.Operators.Not((bool?)(wzzzzzr_ is null));
            bool? wzzzzzt_ = context.Operators.And(wzzzzzp_, wzzzzzs_);
            bool? wzzzzzu_ = context.Operators.And(wzzzzzf_, wzzzzzt_);

            return wzzzzzu_;
        };
        IEnumerable<Observation> vzzzzzt_ = context.Operators.Where<Observation>(vzzzzzr_, vzzzzzs_);

        return vzzzzzt_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet xzzzzzm_ = this.FIT_DNA(context);
        IEnumerable<Observation> xzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzo_(Observation FitDNA)
        {
            List<CodeableConcept> xzzzzzq_ = FitDNA?.Category;
            bool? xzzzzzr_(CodeableConcept FitDNACategory)
            {
                List<Coding> yzzzzzm_ = FitDNACategory?.Coding;
                bool? yzzzzzn_(Coding @this)
                {
                    Code yzzzzzy_ = @this?.CodeElement;
                    bool? yzzzzzz_ = context.Operators.Not((bool?)(yzzzzzy_ is null));

                    return yzzzzzz_;
                };
                IEnumerable<Coding> yzzzzzo_ = context.Operators.Where<Coding>((IEnumerable<Coding>)yzzzzzm_, yzzzzzn_);
                Code yzzzzzp_(Coding @this)
                {
                    Code zzzzzza_ = @this?.CodeElement;

                    return zzzzzza_;
                };
                IEnumerable<Code> yzzzzzq_ = context.Operators.Select<Coding, Code>(yzzzzzo_, yzzzzzp_);
                bool? yzzzzzr_(Code @this)
                {
                    string zzzzzzb_ = @this?.Value;
                    bool? zzzzzzc_ = context.Operators.Not((bool?)(zzzzzzb_ is null));

                    return zzzzzzc_;
                };
                IEnumerable<Code> yzzzzzs_ = context.Operators.Where<Code>(yzzzzzq_, yzzzzzr_);
                string yzzzzzt_(Code @this)
                {
                    string zzzzzzd_ = @this?.Value;

                    return zzzzzzd_;
                };
                IEnumerable<string> yzzzzzu_ = context.Operators.Select<Code, string>(yzzzzzs_, yzzzzzt_);
                string[] yzzzzzv_ = [
                    "laboratory",
                ];
                bool? yzzzzzw_ = context.Operators.Equivalent<string>(yzzzzzu_, yzzzzzv_ as IEnumerable<string>);
                bool? yzzzzzx_ = context.Operators.Not(yzzzzzw_);

                return yzzzzzx_;
            };
            IEnumerable<CodeableConcept> xzzzzzs_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzzzq_, xzzzzzr_);
            bool? xzzzzzt_ = context.Operators.Exists<CodeableConcept>(xzzzzzs_);
            DataType xzzzzzu_ = FitDNA?.Value;
            bool? xzzzzzv_ = context.Operators.Not((bool?)(xzzzzzu_ is null));
            bool? xzzzzzw_ = context.Operators.And(xzzzzzt_, xzzzzzv_);
            DataType xzzzzzx_ = FitDNA?.Effective;
            CqlDateTime xzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, xzzzzzx_);
            CqlInterval<CqlDateTime> xzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime yzzzzza_ = context.Operators.End(xzzzzzz_);
            CqlQuantity yzzzzzb_ = context.Operators.Quantity(3m, "years");
            CqlDateTime yzzzzzc_ = context.Operators.Subtract(yzzzzza_, yzzzzzb_);
            CqlDateTime yzzzzze_ = context.Operators.End(xzzzzzz_);
            CqlInterval<CqlDateTime> yzzzzzf_ = context.Operators.Interval(yzzzzzc_, yzzzzze_, true, true);
            bool? yzzzzzg_ = context.Operators.In<CqlDateTime>(xzzzzzy_, yzzzzzf_, "day");
            CqlDateTime yzzzzzi_ = context.Operators.End(xzzzzzz_);
            bool? yzzzzzj_ = context.Operators.Not((bool?)(yzzzzzi_ is null));
            bool? yzzzzzk_ = context.Operators.And(yzzzzzg_, yzzzzzj_);
            bool? yzzzzzl_ = context.Operators.And(xzzzzzw_, yzzzzzk_);

            return yzzzzzl_;
        };
        IEnumerable<Observation> xzzzzzp_ = context.Operators.Where<Observation>(xzzzzzn_, xzzzzzo_);

        return xzzzzzp_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet zzzzzze_ = this.FIT_DNA(context);
        IEnumerable<Observation> zzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzg_(Observation FitDNA)
        {
            Code<ObservationStatus> zzzzzzi_ = FitDNA?.StatusElement;
            string zzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzi_);
            string[] zzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzl_ = context.Operators.In<string>(zzzzzzj_, zzzzzzk_ as IEnumerable<string>);
            bool? zzzzzzm_ = context.Operators.Not(zzzzzzl_);
            DataType zzzzzzn_ = FitDNA?.Value;
            bool? zzzzzzo_ = context.Operators.Not((bool?)(zzzzzzn_ is null));
            bool? zzzzzzp_ = context.Operators.And(zzzzzzm_, zzzzzzo_);
            DataType zzzzzzq_ = FitDNA?.Effective;
            CqlDateTime zzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, zzzzzzq_);
            CqlInterval<CqlDateTime> zzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzt_ = context.Operators.End(zzzzzzs_);
            CqlQuantity zzzzzzu_ = context.Operators.Quantity(3m, "years");
            CqlDateTime zzzzzzv_ = context.Operators.Subtract(zzzzzzt_, zzzzzzu_);
            CqlDateTime zzzzzzx_ = context.Operators.End(zzzzzzs_);
            CqlInterval<CqlDateTime> zzzzzzy_ = context.Operators.Interval(zzzzzzv_, zzzzzzx_, true, true);
            bool? zzzzzzz_ = context.Operators.In<CqlDateTime>(zzzzzzr_, zzzzzzy_, "day");
            CqlDateTime azzzzzzb_ = context.Operators.End(zzzzzzs_);
            bool? azzzzzzc_ = context.Operators.Not((bool?)(azzzzzzb_ is null));
            bool? azzzzzzd_ = context.Operators.And(zzzzzzz_, azzzzzzc_);
            bool? azzzzzze_ = context.Operators.And(zzzzzzp_, azzzzzzd_);

            return azzzzzze_;
        };
        IEnumerable<Observation> zzzzzzh_ = context.Operators.Where<Observation>(zzzzzzf_, zzzzzzg_);

        return zzzzzzh_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet azzzzzzf_ = this.CT_Colonography(context);
        IEnumerable<Observation> azzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? azzzzzzh_(Observation Colonography)
        {
            DataType azzzzzzm_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> azzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzm_);
            CqlDateTime azzzzzzo_ = context.Operators.End(azzzzzzn_);
            CqlInterval<CqlDateTime> azzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzq_ = context.Operators.End(azzzzzzp_);
            CqlQuantity azzzzzzr_ = context.Operators.Quantity(6m, "years");
            CqlDateTime azzzzzzs_ = context.Operators.Subtract(azzzzzzq_, azzzzzzr_);
            CqlDateTime azzzzzzu_ = context.Operators.End(azzzzzzp_);
            CqlInterval<CqlDateTime> azzzzzzv_ = context.Operators.Interval(azzzzzzs_, azzzzzzu_, true, true);
            bool? azzzzzzw_ = context.Operators.In<CqlDateTime>(azzzzzzo_, azzzzzzv_, default);
            CqlDateTime azzzzzzy_ = context.Operators.End(azzzzzzp_);
            bool? azzzzzzz_ = context.Operators.Not((bool?)(azzzzzzy_ is null));
            bool? bzzzzzza_ = context.Operators.And(azzzzzzw_, azzzzzzz_);

            return bzzzzzza_;
        };
        IEnumerable<Observation> azzzzzzi_ = context.Operators.Where<Observation>(azzzzzzg_, azzzzzzh_);
        CqlDateTime azzzzzzj_(Observation Colonography)
        {
            DataType bzzzzzzb_ = Colonography?.Effective;
            CqlDateTime bzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, bzzzzzzb_);

            return bzzzzzzc_;
        };
        IEnumerable<CqlDateTime> azzzzzzk_ = context.Operators.Select<Observation, CqlDateTime>(azzzzzzi_, azzzzzzj_);
        IEnumerable<CqlDateTime> azzzzzzl_ = context.Operators.Distinct<CqlDateTime>(azzzzzzk_);

        return azzzzzzl_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet bzzzzzzd_ = this.CT_Colonography(context);
        IEnumerable<Observation> bzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzf_(Observation Colonography)
        {
            Code<ObservationStatus> bzzzzzzh_ = Colonography?.StatusElement;
            string bzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzh_);
            string[] bzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? bzzzzzzk_ = context.Operators.In<string>(bzzzzzzi_, bzzzzzzj_ as IEnumerable<string>);
            DataType bzzzzzzl_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> bzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzl_);
            CqlDateTime bzzzzzzn_ = context.Operators.End(bzzzzzzm_);
            CqlInterval<CqlDateTime> bzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzp_ = context.Operators.End(bzzzzzzo_);
            CqlQuantity bzzzzzzq_ = context.Operators.Quantity(5m, "years");
            CqlDateTime bzzzzzzr_ = context.Operators.Subtract(bzzzzzzp_, bzzzzzzq_);
            CqlDateTime bzzzzzzt_ = context.Operators.End(bzzzzzzo_);
            CqlInterval<CqlDateTime> bzzzzzzu_ = context.Operators.Interval(bzzzzzzr_, bzzzzzzt_, true, true);
            bool? bzzzzzzv_ = context.Operators.In<CqlDateTime>(bzzzzzzn_, bzzzzzzu_, default);
            CqlDateTime bzzzzzzx_ = context.Operators.End(bzzzzzzo_);
            bool? bzzzzzzy_ = context.Operators.Not((bool?)(bzzzzzzx_ is null));
            bool? bzzzzzzz_ = context.Operators.And(bzzzzzzv_, bzzzzzzy_);
            bool? czzzzzza_ = context.Operators.And(bzzzzzzk_, bzzzzzzz_);

            return czzzzzza_;
        };
        IEnumerable<Observation> bzzzzzzg_ = context.Operators.Where<Observation>(bzzzzzze_, bzzzzzzf_);

        return bzzzzzzg_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet czzzzzzb_ = this.CT_Colonography(context);
        IEnumerable<Observation> czzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzzzzd_(Observation Colonography)
        {
            Code<ObservationStatus> czzzzzzf_ = Colonography?.StatusElement;
            string czzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzf_);
            string[] czzzzzzh_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? czzzzzzi_ = context.Operators.In<string>(czzzzzzg_, czzzzzzh_ as IEnumerable<string>);
            bool? czzzzzzj_ = context.Operators.Not(czzzzzzi_);
            DataType czzzzzzk_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> czzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzk_);
            CqlDateTime czzzzzzm_ = context.Operators.End(czzzzzzl_);
            CqlInterval<CqlDateTime> czzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzo_ = context.Operators.End(czzzzzzn_);
            CqlQuantity czzzzzzp_ = context.Operators.Quantity(5m, "years");
            CqlDateTime czzzzzzq_ = context.Operators.Subtract(czzzzzzo_, czzzzzzp_);
            CqlDateTime czzzzzzs_ = context.Operators.End(czzzzzzn_);
            CqlInterval<CqlDateTime> czzzzzzt_ = context.Operators.Interval(czzzzzzq_, czzzzzzs_, true, true);
            bool? czzzzzzu_ = context.Operators.In<CqlDateTime>(czzzzzzm_, czzzzzzt_, default);
            CqlDateTime czzzzzzw_ = context.Operators.End(czzzzzzn_);
            bool? czzzzzzx_ = context.Operators.Not((bool?)(czzzzzzw_ is null));
            bool? czzzzzzy_ = context.Operators.And(czzzzzzu_, czzzzzzx_);
            bool? czzzzzzz_ = context.Operators.And(czzzzzzj_, czzzzzzy_);

            return czzzzzzz_;
        };
        IEnumerable<Observation> czzzzzze_ = context.Operators.Where<Observation>(czzzzzzc_, czzzzzzd_);

        return czzzzzze_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet dzzzzzza_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> dzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? dzzzzzzc_(Procedure FlexibleSigmoidoscopy)
        {
            DataType dzzzzzzh_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> dzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzh_);
            CqlDateTime dzzzzzzj_ = context.Operators.End(dzzzzzzi_);
            CqlInterval<CqlDateTime> dzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzl_ = context.Operators.End(dzzzzzzk_);
            CqlQuantity dzzzzzzm_ = context.Operators.Quantity(6m, "years");
            CqlDateTime dzzzzzzn_ = context.Operators.Subtract(dzzzzzzl_, dzzzzzzm_);
            CqlDateTime dzzzzzzp_ = context.Operators.End(dzzzzzzk_);
            CqlInterval<CqlDateTime> dzzzzzzq_ = context.Operators.Interval(dzzzzzzn_, dzzzzzzp_, true, true);
            bool? dzzzzzzr_ = context.Operators.In<CqlDateTime>(dzzzzzzj_, dzzzzzzq_, default);
            CqlDateTime dzzzzzzt_ = context.Operators.End(dzzzzzzk_);
            bool? dzzzzzzu_ = context.Operators.Not((bool?)(dzzzzzzt_ is null));
            bool? dzzzzzzv_ = context.Operators.And(dzzzzzzr_, dzzzzzzu_);

            return dzzzzzzv_;
        };
        IEnumerable<Procedure> dzzzzzzd_ = context.Operators.Where<Procedure>(dzzzzzzb_, dzzzzzzc_);
        CqlDateTime dzzzzzze_(Procedure FlexibleSigmoidoscopy)
        {
            DataType dzzzzzzw_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime dzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, dzzzzzzw_);

            return dzzzzzzx_;
        };
        IEnumerable<CqlDateTime> dzzzzzzf_ = context.Operators.Select<Procedure, CqlDateTime>(dzzzzzzd_, dzzzzzze_);
        IEnumerable<CqlDateTime> dzzzzzzg_ = context.Operators.Distinct<CqlDateTime>(dzzzzzzf_);

        return dzzzzzzg_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet dzzzzzzy_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> dzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? ezzzzzza_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> ezzzzzzc_ = FlexibleSigmoidoscopy?.StatusElement;
            string ezzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzc_);
            bool? ezzzzzze_ = context.Operators.Equal(ezzzzzzd_, "completed");
            DataType ezzzzzzf_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> ezzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzf_);
            CqlDateTime ezzzzzzh_ = context.Operators.End(ezzzzzzg_);
            CqlInterval<CqlDateTime> ezzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzj_ = context.Operators.End(ezzzzzzi_);
            CqlQuantity ezzzzzzk_ = context.Operators.Quantity(5m, "years");
            CqlDateTime ezzzzzzl_ = context.Operators.Subtract(ezzzzzzj_, ezzzzzzk_);
            CqlDateTime ezzzzzzn_ = context.Operators.End(ezzzzzzi_);
            CqlInterval<CqlDateTime> ezzzzzzo_ = context.Operators.Interval(ezzzzzzl_, ezzzzzzn_, true, true);
            bool? ezzzzzzp_ = context.Operators.In<CqlDateTime>(ezzzzzzh_, ezzzzzzo_, default);
            CqlDateTime ezzzzzzr_ = context.Operators.End(ezzzzzzi_);
            bool? ezzzzzzs_ = context.Operators.Not((bool?)(ezzzzzzr_ is null));
            bool? ezzzzzzt_ = context.Operators.And(ezzzzzzp_, ezzzzzzs_);
            bool? ezzzzzzu_ = context.Operators.And(ezzzzzze_, ezzzzzzt_);

            return ezzzzzzu_;
        };
        IEnumerable<Procedure> ezzzzzzb_ = context.Operators.Where<Procedure>(dzzzzzzz_, ezzzzzza_);

        return ezzzzzzb_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet ezzzzzzv_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> ezzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? ezzzzzzx_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> ezzzzzzz_ = FlexibleSigmoidoscopy?.StatusElement;
            string fzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzz_);
            bool? fzzzzzzb_ = context.Operators.Equal(fzzzzzza_, "completed");
            bool? fzzzzzzc_ = context.Operators.Not(fzzzzzzb_);
            DataType fzzzzzzd_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> fzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzd_);
            CqlDateTime fzzzzzzf_ = context.Operators.End(fzzzzzze_);
            CqlInterval<CqlDateTime> fzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzh_ = context.Operators.End(fzzzzzzg_);
            CqlQuantity fzzzzzzi_ = context.Operators.Quantity(5m, "years");
            CqlDateTime fzzzzzzj_ = context.Operators.Subtract(fzzzzzzh_, fzzzzzzi_);
            CqlDateTime fzzzzzzl_ = context.Operators.End(fzzzzzzg_);
            CqlInterval<CqlDateTime> fzzzzzzm_ = context.Operators.Interval(fzzzzzzj_, fzzzzzzl_, true, true);
            bool? fzzzzzzn_ = context.Operators.In<CqlDateTime>(fzzzzzzf_, fzzzzzzm_, default);
            CqlDateTime fzzzzzzp_ = context.Operators.End(fzzzzzzg_);
            bool? fzzzzzzq_ = context.Operators.Not((bool?)(fzzzzzzp_ is null));
            bool? fzzzzzzr_ = context.Operators.And(fzzzzzzn_, fzzzzzzq_);
            bool? fzzzzzzs_ = context.Operators.And(fzzzzzzc_, fzzzzzzr_);

            return fzzzzzzs_;
        };
        IEnumerable<Procedure> ezzzzzzy_ = context.Operators.Where<Procedure>(ezzzzzzw_, ezzzzzzx_);

        return ezzzzzzy_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet fzzzzzzt_ = this.Colonoscopy(context);
        IEnumerable<Procedure> fzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? fzzzzzzv_(Procedure Colonoscopy)
        {
            DataType gzzzzzza_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> gzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzza_);
            CqlDateTime gzzzzzzc_ = context.Operators.End(gzzzzzzb_);
            CqlInterval<CqlDateTime> gzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzze_ = context.Operators.End(gzzzzzzd_);
            CqlQuantity gzzzzzzf_ = context.Operators.Quantity(11m, "years");
            CqlDateTime gzzzzzzg_ = context.Operators.Subtract(gzzzzzze_, gzzzzzzf_);
            CqlDateTime gzzzzzzi_ = context.Operators.End(gzzzzzzd_);
            CqlInterval<CqlDateTime> gzzzzzzj_ = context.Operators.Interval(gzzzzzzg_, gzzzzzzi_, true, true);
            bool? gzzzzzzk_ = context.Operators.In<CqlDateTime>(gzzzzzzc_, gzzzzzzj_, default);
            CqlDateTime gzzzzzzm_ = context.Operators.End(gzzzzzzd_);
            bool? gzzzzzzn_ = context.Operators.Not((bool?)(gzzzzzzm_ is null));
            bool? gzzzzzzo_ = context.Operators.And(gzzzzzzk_, gzzzzzzn_);

            return gzzzzzzo_;
        };
        IEnumerable<Procedure> fzzzzzzw_ = context.Operators.Where<Procedure>(fzzzzzzu_, fzzzzzzv_);
        CqlDateTime fzzzzzzx_(Procedure Colonoscopy)
        {
            DataType gzzzzzzp_ = Colonoscopy?.Performed;
            CqlDateTime gzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, gzzzzzzp_);

            return gzzzzzzq_;
        };
        IEnumerable<CqlDateTime> fzzzzzzy_ = context.Operators.Select<Procedure, CqlDateTime>(fzzzzzzw_, fzzzzzzx_);
        IEnumerable<CqlDateTime> fzzzzzzz_ = context.Operators.Distinct<CqlDateTime>(fzzzzzzy_);

        return fzzzzzzz_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet gzzzzzzr_ = this.Colonoscopy(context);
        IEnumerable<Procedure> gzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? gzzzzzzt_(Procedure Colonoscopy)
        {
            Code<EventStatus> gzzzzzzv_ = Colonoscopy?.StatusElement;
            string gzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzv_);
            bool? gzzzzzzx_ = context.Operators.Equal(gzzzzzzw_, "completed");
            DataType gzzzzzzy_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> gzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzy_);
            CqlDateTime hzzzzzza_ = context.Operators.End(gzzzzzzz_);
            CqlInterval<CqlDateTime> hzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzc_ = context.Operators.End(hzzzzzzb_);
            CqlQuantity hzzzzzzd_ = context.Operators.Quantity(10m, "years");
            CqlDateTime hzzzzzze_ = context.Operators.Subtract(hzzzzzzc_, hzzzzzzd_);
            CqlDateTime hzzzzzzg_ = context.Operators.End(hzzzzzzb_);
            CqlInterval<CqlDateTime> hzzzzzzh_ = context.Operators.Interval(hzzzzzze_, hzzzzzzg_, true, true);
            bool? hzzzzzzi_ = context.Operators.In<CqlDateTime>(hzzzzzza_, hzzzzzzh_, default);
            CqlDateTime hzzzzzzk_ = context.Operators.End(hzzzzzzb_);
            bool? hzzzzzzl_ = context.Operators.Not((bool?)(hzzzzzzk_ is null));
            bool? hzzzzzzm_ = context.Operators.And(hzzzzzzi_, hzzzzzzl_);
            bool? hzzzzzzn_ = context.Operators.And(gzzzzzzx_, hzzzzzzm_);

            return hzzzzzzn_;
        };
        IEnumerable<Procedure> gzzzzzzu_ = context.Operators.Where<Procedure>(gzzzzzzs_, gzzzzzzt_);

        return gzzzzzzu_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet hzzzzzzo_ = this.Colonoscopy(context);
        IEnumerable<Procedure> hzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? hzzzzzzq_(Procedure Colonoscopy)
        {
            Code<EventStatus> hzzzzzzs_ = Colonoscopy?.StatusElement;
            string hzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzs_);
            bool? hzzzzzzu_ = context.Operators.Equal(hzzzzzzt_, "completed");
            bool? hzzzzzzv_ = context.Operators.Not(hzzzzzzu_);
            DataType hzzzzzzw_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> hzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzw_);
            CqlDateTime hzzzzzzy_ = context.Operators.End(hzzzzzzx_);
            CqlInterval<CqlDateTime> hzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime izzzzzza_ = context.Operators.End(hzzzzzzz_);
            CqlQuantity izzzzzzb_ = context.Operators.Quantity(10m, "years");
            CqlDateTime izzzzzzc_ = context.Operators.Subtract(izzzzzza_, izzzzzzb_);
            CqlDateTime izzzzzze_ = context.Operators.End(hzzzzzzz_);
            CqlInterval<CqlDateTime> izzzzzzf_ = context.Operators.Interval(izzzzzzc_, izzzzzze_, true, true);
            bool? izzzzzzg_ = context.Operators.In<CqlDateTime>(hzzzzzzy_, izzzzzzf_, default);
            CqlDateTime izzzzzzi_ = context.Operators.End(hzzzzzzz_);
            bool? izzzzzzj_ = context.Operators.Not((bool?)(izzzzzzi_ is null));
            bool? izzzzzzk_ = context.Operators.And(izzzzzzg_, izzzzzzj_);
            bool? izzzzzzl_ = context.Operators.And(hzzzzzzv_, izzzzzzk_);

            return izzzzzzl_;
        };
        IEnumerable<Procedure> hzzzzzzr_ = context.Operators.Where<Procedure>(hzzzzzzp_, hzzzzzzq_);

        return hzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> izzzzzzm_ = this.Colonoscopy_Performed(context);
        bool? izzzzzzn_ = context.Operators.Exists<Procedure>(izzzzzzm_);
        IEnumerable<Observation> izzzzzzo_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? izzzzzzp_ = context.Operators.Exists<Observation>(izzzzzzo_);
        bool? izzzzzzq_ = context.Operators.Or(izzzzzzn_, izzzzzzp_);
        IEnumerable<Procedure> izzzzzzr_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? izzzzzzs_ = context.Operators.Exists<Procedure>(izzzzzzr_);
        bool? izzzzzzt_ = context.Operators.Or(izzzzzzq_, izzzzzzs_);
        IEnumerable<Observation> izzzzzzu_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? izzzzzzv_ = context.Operators.Exists<Observation>(izzzzzzu_);
        bool? izzzzzzw_ = context.Operators.Or(izzzzzzt_, izzzzzzv_);
        IEnumerable<Observation> izzzzzzx_ = this.CT_Colonography_Performed(context);
        bool? izzzzzzy_ = context.Operators.Exists<Observation>(izzzzzzx_);
        bool? izzzzzzz_ = context.Operators.Or(izzzzzzw_, izzzzzzy_);

        return izzzzzzz_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? jzzzzzza_ = this.Numerator(context);
        bool? jzzzzzzb_ = this.Initial_Population(context);
        bool? jzzzzzzc_ = context.Operators.And(jzzzzzza_, jzzzzzzb_);
        bool? jzzzzzzd_ = this.Denominator(context);
        bool? jzzzzzze_ = context.Operators.And(jzzzzzzc_, jzzzzzzd_);
        bool? jzzzzzzf_ = this.Denominator_Exclusions(context);
        bool? jzzzzzzg_ = context.Operators.Not(jzzzzzzf_);
        bool? jzzzzzzh_ = context.Operators.And(jzzzzzze_, jzzzzzzg_);

        return jzzzzzzh_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
