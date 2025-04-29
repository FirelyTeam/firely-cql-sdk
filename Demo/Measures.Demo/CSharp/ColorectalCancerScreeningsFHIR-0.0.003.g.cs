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
        CqlDateTime tzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime tzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzn_ = context.Operators.Interval(tzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzm_, true, false);
        object tzzzzzzzzzzzzzzo_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", tzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient tzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzp_);

        return tzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> tzzzzzzzzzzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return tzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> tzzzzzzzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return tzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> tzzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzv_ = this.Online_Assessments(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet tzzzzzzzzzzzzzzx_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzy_);
        bool? uzzzzzzzzzzzzzza_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzc_ = TelehealthEncounter?.StatusElement;
            string uzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzc_);
            bool? uzzzzzzzzzzzzzze_ = context.Operators.Equal(uzzzzzzzzzzzzzzd_, "finished");
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            Period uzzzzzzzzzzzzzzg_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzzzzzzzzzzzg_ as object);
            bool? uzzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzh_, default);
            bool? uzzzzzzzzzzzzzzj_ = context.Operators.And(uzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzi_);

            return uzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzza_);

        return uzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient uzzzzzzzzzzzzzzk_ = this.Patient(context);
        Date uzzzzzzzzzzzzzzl_ = uzzzzzzzzzzzzzzk_?.BirthDateElement;
        string uzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzl_?.Value;
        CqlDate uzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzm_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzzzzp_ = context.Operators.Start(uzzzzzzzzzzzzzzo_);
        CqlDate uzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzp_);
        int? uzzzzzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzq_, "year");

        return uzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient uzzzzzzzzzzzzzzs_ = this.Patient(context);
        Date uzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzs_?.BirthDateElement;
        string uzzzzzzzzzzzzzzu_ = uzzzzzzzzzzzzzzt_?.Value;
        CqlDate uzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzzzzzzw_);
        CqlDate uzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzx_);
        int? uzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzy_, "year");
        CqlInterval<int?> vzzzzzzzzzzzzzza_ = context.Operators.Interval(51, 75, true, false);
        bool? vzzzzzzzzzzzzzzb_ = context.Operators.In<int?>(uzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzza_, default);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzc_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzd_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzd_);
        bool? vzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzze_);
        bool? vzzzzzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzf_);

        return vzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzh_ = this.Initial_Population(context);

        return vzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzi_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? vzzzzzzzzzzzzzzk_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime vzzzzzzzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzp_ = context.Operators.End(vzzzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzp_, default);

            return vzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzk_);

        return vzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzr_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? vzzzzzzzzzzzzzzt_(Procedure Colectomy)
        {
            Code<EventStatus> vzzzzzzzzzzzzzzv_ = Colectomy?.StatusElement;
            string vzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzzzzv_);
            bool? vzzzzzzzzzzzzzzx_ = context.Operators.Equal(vzzzzzzzzzzzzzzw_, "completed");
            DataType vzzzzzzzzzzzzzzy_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzzzzy_);
            CqlDateTime wzzzzzzzzzzzzzza_ = context.Operators.End(vzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzc_ = context.Operators.End(wzzzzzzzzzzzzzzb_);
            bool? wzzzzzzzzzzzzzzd_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzc_, default);
            bool? wzzzzzzzzzzzzzze_ = context.Operators.And(vzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzd_);

            return wzzzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzt_);

        return vzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzf_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? wzzzzzzzzzzzzzzh_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime wzzzzzzzzzzzzzzk_ = context.Operators.Start(wzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzm_ = context.Operators.End(wzzzzzzzzzzzzzzl_);
            bool? wzzzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzm_, default);

            return wzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzh_);

        return wzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzo_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzp_ = this.Malignant_Neoplasm(context);
        bool? wzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzp_);
        bool? wzzzzzzzzzzzzzzr_ = context.Operators.Or(wzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzq_);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzs_ = this.Total_Colectomy_Performed(context);
        bool? wzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(wzzzzzzzzzzzzzzs_);
        bool? wzzzzzzzzzzzzzzu_ = context.Operators.Or(wzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzv_ = this.Total_Colectomy_Condition(context);
        bool? wzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzzx_ = context.Operators.Or(wzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzw_);
        bool? wzzzzzzzzzzzzzzy_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? wzzzzzzzzzzzzzzz_ = context.Operators.Or(wzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzy_);
        Patient xzzzzzzzzzzzzzza_ = this.Patient(context);
        Date xzzzzzzzzzzzzzzb_ = xzzzzzzzzzzzzzza_?.BirthDateElement;
        string xzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzb_?.Value;
        CqlDate xzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime xzzzzzzzzzzzzzzf_ = context.Operators.Start(xzzzzzzzzzzzzzze_);
        CqlDate xzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzf_);
        int? xzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzg_, "year");
        bool? xzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzh_, 65);
        bool? xzzzzzzzzzzzzzzj_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? xzzzzzzzzzzzzzzk_ = context.Operators.And(xzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzj_);
        bool? xzzzzzzzzzzzzzzl_ = context.Operators.Or(wzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzk_);
        bool? xzzzzzzzzzzzzzzm_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzzn_ = context.Operators.Or(xzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzm_);

        return xzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzo_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzzzzzzzzzzq_(Observation FecalOccult)
        {
            DataType xzzzzzzzzzzzzzzv_ = FecalOccult?.Effective;
            CqlDateTime xzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, xzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzy_ = context.Operators.Start(xzzzzzzzzzzzzzzx_);
            CqlQuantity xzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "year");
            CqlDateTime yzzzzzzzzzzzzzza_ = context.Operators.Subtract(xzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzz_);
            CqlDateTime yzzzzzzzzzzzzzzc_ = context.Operators.End(xzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzd_ = context.Operators.Interval(yzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzc_, false, false);
            bool? yzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzd_, default);

            return yzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? xzzzzzzzzzzzzzzs_(Observation FecalOccult)
        {
            DataType yzzzzzzzzzzzzzzf_ = FecalOccult?.Effective;
            CqlDateTime yzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, yzzzzzzzzzzzzzzf_);
            DataType yzzzzzzzzzzzzzzh_ = FecalOccult?.Value;
            IEnumerable<Coding> yzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(yzzzzzzzzzzzzzzh_, "coding");
            bool? yzzzzzzzzzzzzzzj_(Coding @this)
            {
                FhirString zzzzzzzzzzzzzzzd_ = @this?.DisplayElement;
                bool? zzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzd_ is null));

                return zzzzzzzzzzzzzzze_;
            };
            IEnumerable<Coding> yzzzzzzzzzzzzzzk_ = context.Operators.Where<Coding>(yzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzj_);
            FhirString yzzzzzzzzzzzzzzl_(Coding @this)
            {
                FhirString zzzzzzzzzzzzzzzf_ = @this?.DisplayElement;

                return zzzzzzzzzzzzzzzf_;
            };
            IEnumerable<FhirString> yzzzzzzzzzzzzzzm_ = context.Operators.Select<Coding, FhirString>(yzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzl_);
            List<CodeableConcept> yzzzzzzzzzzzzzzn_ = FecalOccult?.Category;
            bool? yzzzzzzzzzzzzzzo_(CodeableConcept @this)
            {
                List<Coding> zzzzzzzzzzzzzzzg_ = @this?.Coding;
                bool? zzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzg_ is null));

                return zzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CodeableConcept> yzzzzzzzzzzzzzzp_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzo_);
            List<Coding> yzzzzzzzzzzzzzzq_(CodeableConcept @this)
            {
                List<Coding> zzzzzzzzzzzzzzzi_ = @this?.Coding;

                return zzzzzzzzzzzzzzzi_;
            };
            IEnumerable<List<Coding>> yzzzzzzzzzzzzzzr_ = context.Operators.Select<CodeableConcept, List<Coding>>(yzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzq_);
            IEnumerable<Coding> yzzzzzzzzzzzzzzs_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)yzzzzzzzzzzzzzzr_);
            bool? yzzzzzzzzzzzzzzt_(Coding @this)
            {
                Code zzzzzzzzzzzzzzzj_ = @this?.CodeElement;
                bool? zzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzj_ is null));

                return zzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Coding> yzzzzzzzzzzzzzzu_ = context.Operators.Where<Coding>(yzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzt_);
            Code yzzzzzzzzzzzzzzv_(Coding @this)
            {
                Code zzzzzzzzzzzzzzzl_ = @this?.CodeElement;

                return zzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Code> yzzzzzzzzzzzzzzw_ = context.Operators.Select<Coding, Code>(yzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzzzzx_(Code @this)
            {
                string zzzzzzzzzzzzzzzm_ = @this?.Value;
                bool? zzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzm_ is null));

                return zzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Code> yzzzzzzzzzzzzzzy_ = context.Operators.Where<Code>(yzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzx_);
            string yzzzzzzzzzzzzzzz_(Code @this)
            {
                string zzzzzzzzzzzzzzzo_ = @this?.Value;

                return zzzzzzzzzzzzzzzo_;
            };
            IEnumerable<string> zzzzzzzzzzzzzzza_ = context.Operators.Select<Code, string>(yzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzz_);
            Code<ObservationStatus> zzzzzzzzzzzzzzzb_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? zzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, yzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzb_);

            return zzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> xzzzzzzzzzzzzzzt_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(xzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> xzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(xzzzzzzzzzzzzzzt_);

        return xzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzp_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> zzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzzzzzzzzzzr_(Observation FecalOccult)
        {
            Code<ObservationStatus> zzzzzzzzzzzzzzzt_ = FecalOccult?.StatusElement;
            string zzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzt_);
            string[] zzzzzzzzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzzzzw_ = context.Operators.In<string>(zzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            List<CodeableConcept> zzzzzzzzzzzzzzzx_ = FecalOccult?.Category;
            bool? zzzzzzzzzzzzzzzy_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> azzzzzzzzzzzzzzzk_ = FecalOccultCategory?.Coding;
                bool? azzzzzzzzzzzzzzzl_(Coding @this)
                {
                    Code azzzzzzzzzzzzzzzv_ = @this?.CodeElement;
                    bool? azzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzv_ is null));

                    return azzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Coding> azzzzzzzzzzzzzzzm_ = context.Operators.Where<Coding>((IEnumerable<Coding>)azzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzl_);
                Code azzzzzzzzzzzzzzzn_(Coding @this)
                {
                    Code azzzzzzzzzzzzzzzx_ = @this?.CodeElement;

                    return azzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Code> azzzzzzzzzzzzzzzo_ = context.Operators.Select<Coding, Code>(azzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzn_);
                bool? azzzzzzzzzzzzzzzp_(Code @this)
                {
                    string azzzzzzzzzzzzzzzy_ = @this?.Value;
                    bool? azzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzy_ is null));

                    return azzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Code> azzzzzzzzzzzzzzzq_ = context.Operators.Where<Code>(azzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzp_);
                string azzzzzzzzzzzzzzzr_(Code @this)
                {
                    string bzzzzzzzzzzzzzzza_ = @this?.Value;

                    return bzzzzzzzzzzzzzzza_;
                };
                IEnumerable<string> azzzzzzzzzzzzzzzs_ = context.Operators.Select<Code, string>(azzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzr_);
                string[] azzzzzzzzzzzzzzzt_ = [
                    "laboratory",
                ];
                bool? azzzzzzzzzzzzzzzu_ = context.Operators.Equivalent<string>(azzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzt_ as IEnumerable<string>);

                return azzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CodeableConcept> zzzzzzzzzzzzzzzz_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzy_);
            bool? azzzzzzzzzzzzzzza_ = context.Operators.Exists<CodeableConcept>(zzzzzzzzzzzzzzzz_);
            bool? azzzzzzzzzzzzzzzb_ = context.Operators.And(zzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzza_);
            DataType azzzzzzzzzzzzzzzc_ = FecalOccult?.Value;
            bool? azzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzc_ is null));
            bool? azzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzd_);
            DataType azzzzzzzzzzzzzzzf_ = FecalOccult?.Effective;
            CqlDateTime azzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, azzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzh_, default);
            bool? azzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzi_);

            return azzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzr_);

        return zzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzb_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzzzzzzzzzd_(Observation FecalOccult)
        {
            Code<ObservationStatus> bzzzzzzzzzzzzzzzf_ = FecalOccult?.StatusElement;
            string bzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzf_);
            string[] bzzzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            List<CodeableConcept> bzzzzzzzzzzzzzzzj_ = FecalOccult?.Category;
            bool? bzzzzzzzzzzzzzzzk_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> bzzzzzzzzzzzzzzzw_ = FecalOccultCategory?.Coding;
                bool? bzzzzzzzzzzzzzzzx_(Coding @this)
                {
                    Code czzzzzzzzzzzzzzzh_ = @this?.CodeElement;
                    bool? czzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzh_ is null));

                    return czzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Coding> bzzzzzzzzzzzzzzzy_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzx_);
                Code bzzzzzzzzzzzzzzzz_(Coding @this)
                {
                    Code czzzzzzzzzzzzzzzj_ = @this?.CodeElement;

                    return czzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Code> czzzzzzzzzzzzzzza_ = context.Operators.Select<Coding, Code>(bzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzz_);
                bool? czzzzzzzzzzzzzzzb_(Code @this)
                {
                    string czzzzzzzzzzzzzzzk_ = @this?.Value;
                    bool? czzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzk_ is null));

                    return czzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Code> czzzzzzzzzzzzzzzc_ = context.Operators.Where<Code>(czzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzb_);
                string czzzzzzzzzzzzzzzd_(Code @this)
                {
                    string czzzzzzzzzzzzzzzm_ = @this?.Value;

                    return czzzzzzzzzzzzzzzm_;
                };
                IEnumerable<string> czzzzzzzzzzzzzzze_ = context.Operators.Select<Code, string>(czzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzd_);
                string[] czzzzzzzzzzzzzzzf_ = [
                    "laboratory",
                ];
                bool? czzzzzzzzzzzzzzzg_ = context.Operators.Equivalent<string>(czzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzf_ as IEnumerable<string>);

                return czzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CodeableConcept> bzzzzzzzzzzzzzzzl_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzk_);
            bool? bzzzzzzzzzzzzzzzm_ = context.Operators.Exists<CodeableConcept>(bzzzzzzzzzzzzzzzl_);
            bool? bzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzm_);
            DataType bzzzzzzzzzzzzzzzo_ = FecalOccult?.Value;
            bool? bzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzo_ is null));
            bool? bzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzp_);
            DataType bzzzzzzzzzzzzzzzr_ = FecalOccult?.Effective;
            CqlDateTime bzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, bzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzt_, "day");
            bool? bzzzzzzzzzzzzzzzv_ = context.Operators.And(bzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzd_);

        return bzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzn_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzzzzzzzzzzzzzp_(Observation FecalOccult)
        {
            List<CodeableConcept> czzzzzzzzzzzzzzzr_ = FecalOccult?.Category;
            bool? czzzzzzzzzzzzzzzs_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> dzzzzzzzzzzzzzzzd_ = FecalOccultCategory?.Coding;
                bool? dzzzzzzzzzzzzzzze_(Coding @this)
                {
                    Code dzzzzzzzzzzzzzzzp_ = @this?.CodeElement;
                    bool? dzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzp_ is null));

                    return dzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Coding> dzzzzzzzzzzzzzzzf_ = context.Operators.Where<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzze_);
                Code dzzzzzzzzzzzzzzzg_(Coding @this)
                {
                    Code dzzzzzzzzzzzzzzzr_ = @this?.CodeElement;

                    return dzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Code> dzzzzzzzzzzzzzzzh_ = context.Operators.Select<Coding, Code>(dzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzg_);
                bool? dzzzzzzzzzzzzzzzi_(Code @this)
                {
                    string dzzzzzzzzzzzzzzzs_ = @this?.Value;
                    bool? dzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzs_ is null));

                    return dzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Code> dzzzzzzzzzzzzzzzj_ = context.Operators.Where<Code>(dzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzi_);
                string dzzzzzzzzzzzzzzzk_(Code @this)
                {
                    string dzzzzzzzzzzzzzzzu_ = @this?.Value;

                    return dzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<string> dzzzzzzzzzzzzzzzl_ = context.Operators.Select<Code, string>(dzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzk_);
                string[] dzzzzzzzzzzzzzzzm_ = [
                    "laboratory",
                ];
                bool? dzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent<string>(dzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzo_ = context.Operators.Not(dzzzzzzzzzzzzzzzn_);

                return dzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CodeableConcept> czzzzzzzzzzzzzzzt_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzs_);
            bool? czzzzzzzzzzzzzzzu_ = context.Operators.Exists<CodeableConcept>(czzzzzzzzzzzzzzzt_);
            DataType czzzzzzzzzzzzzzzv_ = FecalOccult?.Value;
            bool? czzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzv_ is null));
            bool? czzzzzzzzzzzzzzzx_ = context.Operators.And(czzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzw_);
            DataType czzzzzzzzzzzzzzzy_ = FecalOccult?.Effective;
            CqlDateTime czzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, czzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzza_, "day");
            bool? dzzzzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzb_);

            return dzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzv_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? dzzzzzzzzzzzzzzzx_(Observation FecalOccult)
        {
            Code<ObservationStatus> dzzzzzzzzzzzzzzzz_ = FecalOccult?.StatusElement;
            string ezzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzz_);
            string[] ezzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzzzzzzzzzzzzzc_ = context.Operators.In<string>(ezzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzzzd_ = context.Operators.Not(ezzzzzzzzzzzzzzzc_);
            DataType ezzzzzzzzzzzzzzze_ = FecalOccult?.Value;
            bool? ezzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzze_ is null));
            bool? ezzzzzzzzzzzzzzzg_ = context.Operators.And(ezzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzf_);
            DataType ezzzzzzzzzzzzzzzh_ = FecalOccult?.Effective;
            CqlDateTime ezzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ezzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzj_, "day");
            bool? ezzzzzzzzzzzzzzzl_ = context.Operators.And(ezzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzk_);

            return ezzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzx_);

        return dzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzm_ = this.FIT_DNA(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzzzzzzzzzzzo_(Observation FitDNA)
        {
            DataType ezzzzzzzzzzzzzzzt_ = FitDNA?.Effective;
            CqlDateTime ezzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ezzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzw_ = context.Operators.End(ezzzzzzzzzzzzzzzv_);
            CqlQuantity ezzzzzzzzzzzzzzzx_ = context.Operators.Quantity(4m, "years");
            CqlDateTime ezzzzzzzzzzzzzzzy_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzx_);
            CqlDateTime fzzzzzzzzzzzzzzza_ = context.Operators.End(ezzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzb_ = context.Operators.Interval(ezzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzza_, true, true);
            bool? fzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzb_, default);
            CqlDateTime fzzzzzzzzzzzzzzze_ = context.Operators.End(ezzzzzzzzzzzzzzzv_);
            bool? fzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzze_ is null));
            bool? fzzzzzzzzzzzzzzzg_ = context.Operators.And(fzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzf_);

            return fzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzo_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? ezzzzzzzzzzzzzzzq_(Observation FitDNA)
        {
            DataType fzzzzzzzzzzzzzzzh_ = FitDNA?.Effective;
            CqlDateTime fzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, fzzzzzzzzzzzzzzzh_);
            DataType fzzzzzzzzzzzzzzzj_ = FitDNA?.Value;
            IEnumerable<Coding> fzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(fzzzzzzzzzzzzzzzj_, "coding");
            bool? fzzzzzzzzzzzzzzzl_(Coding @this)
            {
                FhirString gzzzzzzzzzzzzzzzf_ = @this?.DisplayElement;
                bool? gzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzf_ is null));

                return gzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Coding> fzzzzzzzzzzzzzzzm_ = context.Operators.Where<Coding>(fzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzl_);
            FhirString fzzzzzzzzzzzzzzzn_(Coding @this)
            {
                FhirString gzzzzzzzzzzzzzzzh_ = @this?.DisplayElement;

                return gzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<FhirString> fzzzzzzzzzzzzzzzo_ = context.Operators.Select<Coding, FhirString>(fzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzn_);
            List<CodeableConcept> fzzzzzzzzzzzzzzzp_ = FitDNA?.Category;
            bool? fzzzzzzzzzzzzzzzq_(CodeableConcept @this)
            {
                List<Coding> gzzzzzzzzzzzzzzzi_ = @this?.Coding;
                bool? gzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzi_ is null));

                return gzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CodeableConcept> fzzzzzzzzzzzzzzzr_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzq_);
            List<Coding> fzzzzzzzzzzzzzzzs_(CodeableConcept @this)
            {
                List<Coding> gzzzzzzzzzzzzzzzk_ = @this?.Coding;

                return gzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<List<Coding>> fzzzzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, List<Coding>>(fzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzs_);
            IEnumerable<Coding> fzzzzzzzzzzzzzzzu_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)fzzzzzzzzzzzzzzzt_);
            bool? fzzzzzzzzzzzzzzzv_(Coding @this)
            {
                Code gzzzzzzzzzzzzzzzl_ = @this?.CodeElement;
                bool? gzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzl_ is null));

                return gzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Coding> fzzzzzzzzzzzzzzzw_ = context.Operators.Where<Coding>(fzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzv_);
            Code fzzzzzzzzzzzzzzzx_(Coding @this)
            {
                Code gzzzzzzzzzzzzzzzn_ = @this?.CodeElement;

                return gzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Code> fzzzzzzzzzzzzzzzy_ = context.Operators.Select<Coding, Code>(fzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzx_);
            bool? fzzzzzzzzzzzzzzzz_(Code @this)
            {
                string gzzzzzzzzzzzzzzzo_ = @this?.Value;
                bool? gzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzo_ is null));

                return gzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Code> gzzzzzzzzzzzzzzza_ = context.Operators.Where<Code>(fzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzz_);
            string gzzzzzzzzzzzzzzzb_(Code @this)
            {
                string gzzzzzzzzzzzzzzzq_ = @this?.Value;

                return gzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<string> gzzzzzzzzzzzzzzzc_ = context.Operators.Select<Code, string>(gzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzb_);
            Code<ObservationStatus> gzzzzzzzzzzzzzzzd_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? gzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, fzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzd_);

            return gzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> ezzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(ezzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> ezzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(ezzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzr_ = this.FIT_DNA(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? gzzzzzzzzzzzzzzzt_(Observation FitDNA)
        {
            Code<ObservationStatus> gzzzzzzzzzzzzzzzv_ = FitDNA?.StatusElement;
            string gzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzzzv_);
            string[] gzzzzzzzzzzzzzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? gzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
            List<CodeableConcept> gzzzzzzzzzzzzzzzz_ = FitDNA?.Category;
            bool? hzzzzzzzzzzzzzzza_(CodeableConcept FitDNACategory)
            {
                List<Coding> hzzzzzzzzzzzzzzzw_ = FitDNACategory?.Coding;
                bool? hzzzzzzzzzzzzzzzx_(Coding @this)
                {
                    Code izzzzzzzzzzzzzzzh_ = @this?.CodeElement;
                    bool? izzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzh_ is null));

                    return izzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Coding> hzzzzzzzzzzzzzzzy_ = context.Operators.Where<Coding>((IEnumerable<Coding>)hzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzx_);
                Code hzzzzzzzzzzzzzzzz_(Coding @this)
                {
                    Code izzzzzzzzzzzzzzzj_ = @this?.CodeElement;

                    return izzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Code> izzzzzzzzzzzzzzza_ = context.Operators.Select<Coding, Code>(hzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzz_);
                bool? izzzzzzzzzzzzzzzb_(Code @this)
                {
                    string izzzzzzzzzzzzzzzk_ = @this?.Value;
                    bool? izzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzk_ is null));

                    return izzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Code> izzzzzzzzzzzzzzzc_ = context.Operators.Where<Code>(izzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzb_);
                string izzzzzzzzzzzzzzzd_(Code @this)
                {
                    string izzzzzzzzzzzzzzzm_ = @this?.Value;

                    return izzzzzzzzzzzzzzzm_;
                };
                IEnumerable<string> izzzzzzzzzzzzzzze_ = context.Operators.Select<Code, string>(izzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzd_);
                string[] izzzzzzzzzzzzzzzf_ = [
                    "laboratory",
                ];
                bool? izzzzzzzzzzzzzzzg_ = context.Operators.Equivalent<string>(izzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzf_ as IEnumerable<string>);

                return izzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CodeableConcept> hzzzzzzzzzzzzzzzb_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzza_);
            bool? hzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CodeableConcept>(hzzzzzzzzzzzzzzzb_);
            bool? hzzzzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzc_);
            DataType hzzzzzzzzzzzzzzze_ = FitDNA?.Value;
            bool? hzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzze_ is null));
            bool? hzzzzzzzzzzzzzzzg_ = context.Operators.And(hzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzf_);
            DataType hzzzzzzzzzzzzzzzh_ = FitDNA?.Effective;
            CqlDateTime hzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, hzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzk_ = context.Operators.End(hzzzzzzzzzzzzzzzj_);
            CqlQuantity hzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(3m, "years");
            CqlDateTime hzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzl_);
            CqlDateTime hzzzzzzzzzzzzzzzo_ = context.Operators.End(hzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzp_ = context.Operators.Interval(hzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzo_, true, true);
            bool? hzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzp_, default);
            CqlDateTime hzzzzzzzzzzzzzzzs_ = context.Operators.End(hzzzzzzzzzzzzzzzj_);
            bool? hzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzs_ is null));
            bool? hzzzzzzzzzzzzzzzu_ = context.Operators.And(hzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzt_);
            bool? hzzzzzzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzu_);

            return hzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzt_);

        return gzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzn_ = this.FIT_DNA(context);
        IEnumerable<Observation> izzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? izzzzzzzzzzzzzzzp_(Observation FitDNA)
        {
            Code<ObservationStatus> izzzzzzzzzzzzzzzr_ = FitDNA?.StatusElement;
            string izzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzr_);
            string[] izzzzzzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzzzu_ = context.Operators.In<string>(izzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzt_ as IEnumerable<string>);
            List<CodeableConcept> izzzzzzzzzzzzzzzv_ = FitDNA?.Category;
            bool? izzzzzzzzzzzzzzzw_(CodeableConcept FitDNACategory)
            {
                List<Coding> jzzzzzzzzzzzzzzzs_ = FitDNACategory?.Coding;
                bool? jzzzzzzzzzzzzzzzt_(Coding @this)
                {
                    Code kzzzzzzzzzzzzzzzd_ = @this?.CodeElement;
                    bool? kzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzd_ is null));

                    return kzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Coding> jzzzzzzzzzzzzzzzu_ = context.Operators.Where<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzt_);
                Code jzzzzzzzzzzzzzzzv_(Coding @this)
                {
                    Code kzzzzzzzzzzzzzzzf_ = @this?.CodeElement;

                    return kzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Code> jzzzzzzzzzzzzzzzw_ = context.Operators.Select<Coding, Code>(jzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzv_);
                bool? jzzzzzzzzzzzzzzzx_(Code @this)
                {
                    string kzzzzzzzzzzzzzzzg_ = @this?.Value;
                    bool? kzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzg_ is null));

                    return kzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Code> jzzzzzzzzzzzzzzzy_ = context.Operators.Where<Code>(jzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzx_);
                string jzzzzzzzzzzzzzzzz_(Code @this)
                {
                    string kzzzzzzzzzzzzzzzi_ = @this?.Value;

                    return kzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<string> kzzzzzzzzzzzzzzza_ = context.Operators.Select<Code, string>(jzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzz_);
                string[] kzzzzzzzzzzzzzzzb_ = [
                    "laboratory",
                ];
                bool? kzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent<string>(kzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzb_ as IEnumerable<string>);

                return kzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CodeableConcept> izzzzzzzzzzzzzzzx_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzw_);
            bool? izzzzzzzzzzzzzzzy_ = context.Operators.Exists<CodeableConcept>(izzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzz_ = context.Operators.And(izzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzy_);
            DataType jzzzzzzzzzzzzzzza_ = FitDNA?.Value;
            bool? jzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzza_ is null));
            bool? jzzzzzzzzzzzzzzzc_ = context.Operators.And(izzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzb_);
            DataType jzzzzzzzzzzzzzzzd_ = FitDNA?.Effective;
            CqlDateTime jzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, jzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzg_ = context.Operators.End(jzzzzzzzzzzzzzzzf_);
            CqlQuantity jzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(3m, "years");
            CqlDateTime jzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzh_);
            CqlDateTime jzzzzzzzzzzzzzzzk_ = context.Operators.End(jzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzl_ = context.Operators.Interval(jzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzk_, true, true);
            bool? jzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzl_, "day");
            CqlDateTime jzzzzzzzzzzzzzzzo_ = context.Operators.End(jzzzzzzzzzzzzzzzf_);
            bool? jzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzo_ is null));
            bool? jzzzzzzzzzzzzzzzq_ = context.Operators.And(jzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzp_);
            bool? jzzzzzzzzzzzzzzzr_ = context.Operators.And(jzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzj_ = this.FIT_DNA(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzzzzzzzzzzzzzzl_(Observation FitDNA)
        {
            List<CodeableConcept> kzzzzzzzzzzzzzzzn_ = FitDNA?.Category;
            bool? kzzzzzzzzzzzzzzzo_(CodeableConcept FitDNACategory)
            {
                List<Coding> lzzzzzzzzzzzzzzzj_ = FitDNACategory?.Coding;
                bool? lzzzzzzzzzzzzzzzk_(Coding @this)
                {
                    Code lzzzzzzzzzzzzzzzv_ = @this?.CodeElement;
                    bool? lzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzv_ is null));

                    return lzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Coding> lzzzzzzzzzzzzzzzl_ = context.Operators.Where<Coding>((IEnumerable<Coding>)lzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzk_);
                Code lzzzzzzzzzzzzzzzm_(Coding @this)
                {
                    Code lzzzzzzzzzzzzzzzx_ = @this?.CodeElement;

                    return lzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Code> lzzzzzzzzzzzzzzzn_ = context.Operators.Select<Coding, Code>(lzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzm_);
                bool? lzzzzzzzzzzzzzzzo_(Code @this)
                {
                    string lzzzzzzzzzzzzzzzy_ = @this?.Value;
                    bool? lzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzy_ is null));

                    return lzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Code> lzzzzzzzzzzzzzzzp_ = context.Operators.Where<Code>(lzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzo_);
                string lzzzzzzzzzzzzzzzq_(Code @this)
                {
                    string mzzzzzzzzzzzzzzza_ = @this?.Value;

                    return mzzzzzzzzzzzzzzza_;
                };
                IEnumerable<string> lzzzzzzzzzzzzzzzr_ = context.Operators.Select<Code, string>(lzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzq_);
                string[] lzzzzzzzzzzzzzzzs_ = [
                    "laboratory",
                ];
                bool? lzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent<string>(lzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzu_ = context.Operators.Not(lzzzzzzzzzzzzzzzt_);

                return lzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CodeableConcept> kzzzzzzzzzzzzzzzp_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzo_);
            bool? kzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CodeableConcept>(kzzzzzzzzzzzzzzzp_);
            DataType kzzzzzzzzzzzzzzzr_ = FitDNA?.Value;
            bool? kzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzr_ is null));
            bool? kzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzs_);
            DataType kzzzzzzzzzzzzzzzu_ = FitDNA?.Effective;
            CqlDateTime kzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, kzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzx_ = context.Operators.End(kzzzzzzzzzzzzzzzw_);
            CqlQuantity kzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(3m, "years");
            CqlDateTime kzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzy_);
            CqlDateTime lzzzzzzzzzzzzzzzb_ = context.Operators.End(kzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzc_ = context.Operators.Interval(kzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzb_, true, true);
            bool? lzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzc_, "day");
            CqlDateTime lzzzzzzzzzzzzzzzf_ = context.Operators.End(kzzzzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzf_ is null));
            bool? lzzzzzzzzzzzzzzzh_ = context.Operators.And(lzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzg_);
            bool? lzzzzzzzzzzzzzzzi_ = context.Operators.And(kzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzh_);

            return lzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzl_);

        return kzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzb_ = this.FIT_DNA(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? mzzzzzzzzzzzzzzzd_(Observation FitDNA)
        {
            Code<ObservationStatus> mzzzzzzzzzzzzzzzf_ = FitDNA?.StatusElement;
            string mzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzzf_);
            string[] mzzzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzj_ = context.Operators.Not(mzzzzzzzzzzzzzzzi_);
            DataType mzzzzzzzzzzzzzzzk_ = FitDNA?.Value;
            bool? mzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzk_ is null));
            bool? mzzzzzzzzzzzzzzzm_ = context.Operators.And(mzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzl_);
            DataType mzzzzzzzzzzzzzzzn_ = FitDNA?.Effective;
            CqlDateTime mzzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, mzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzq_ = context.Operators.End(mzzzzzzzzzzzzzzzp_);
            CqlQuantity mzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(3m, "years");
            CqlDateTime mzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzr_);
            CqlDateTime mzzzzzzzzzzzzzzzu_ = context.Operators.End(mzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzv_ = context.Operators.Interval(mzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzu_, true, true);
            bool? mzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzv_, "day");
            CqlDateTime mzzzzzzzzzzzzzzzy_ = context.Operators.End(mzzzzzzzzzzzzzzzp_);
            bool? mzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzy_ is null));
            bool? nzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzz_);
            bool? nzzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzza_);

            return nzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzc_ = this.CT_Colonography(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? nzzzzzzzzzzzzzzze_(Observation Colonography)
        {
            DataType nzzzzzzzzzzzzzzzj_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzzzzzj_);
            CqlDateTime nzzzzzzzzzzzzzzzl_ = context.Operators.End(nzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzn_ = context.Operators.End(nzzzzzzzzzzzzzzzm_);
            CqlQuantity nzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(6m, "years");
            CqlDateTime nzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzo_);
            CqlDateTime nzzzzzzzzzzzzzzzr_ = context.Operators.End(nzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzs_ = context.Operators.Interval(nzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzr_, true, true);
            bool? nzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzs_, default);
            CqlDateTime nzzzzzzzzzzzzzzzv_ = context.Operators.End(nzzzzzzzzzzzzzzzm_);
            bool? nzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzv_ is null));
            bool? nzzzzzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzw_);

            return nzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzze_);
        CqlDateTime nzzzzzzzzzzzzzzzg_(Observation Colonography)
        {
            DataType nzzzzzzzzzzzzzzzy_ = Colonography?.Effective;
            CqlDateTime nzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, nzzzzzzzzzzzzzzzy_);

            return nzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDateTime> nzzzzzzzzzzzzzzzh_ = context.Operators.Select<Observation, CqlDateTime>(nzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDateTime> nzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDateTime>(nzzzzzzzzzzzzzzzh_);

        return nzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzza_ = this.CT_Colonography(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzzzzzzzzzzzzc_(Observation Colonography)
        {
            Code<ObservationStatus> ozzzzzzzzzzzzzzze_ = Colonography?.StatusElement;
            string ozzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzzze_);
            string[] ozzzzzzzzzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ozzzzzzzzzzzzzzzh_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            DataType ozzzzzzzzzzzzzzzi_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzzzi_);
            CqlDateTime ozzzzzzzzzzzzzzzk_ = context.Operators.End(ozzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzm_ = context.Operators.End(ozzzzzzzzzzzzzzzl_);
            CqlQuantity ozzzzzzzzzzzzzzzn_ = context.Operators.Quantity(5m, "years");
            CqlDateTime ozzzzzzzzzzzzzzzo_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzn_);
            CqlDateTime ozzzzzzzzzzzzzzzq_ = context.Operators.End(ozzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzr_ = context.Operators.Interval(ozzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzq_, true, true);
            bool? ozzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzr_, default);
            CqlDateTime ozzzzzzzzzzzzzzzu_ = context.Operators.End(ozzzzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzu_ is null));
            bool? ozzzzzzzzzzzzzzzw_ = context.Operators.And(ozzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzv_);
            bool? ozzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzw_);

            return ozzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzc_);

        return ozzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzy_ = this.CT_Colonography(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzzzzzzzzzzzzza_(Observation Colonography)
        {
            Code<ObservationStatus> pzzzzzzzzzzzzzzzc_ = Colonography?.StatusElement;
            string pzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzzzc_);
            string[] pzzzzzzzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? pzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            bool? pzzzzzzzzzzzzzzzg_ = context.Operators.Not(pzzzzzzzzzzzzzzzf_);
            DataType pzzzzzzzzzzzzzzzh_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzzzzzzzh_);
            CqlDateTime pzzzzzzzzzzzzzzzj_ = context.Operators.End(pzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzzl_ = context.Operators.End(pzzzzzzzzzzzzzzzk_);
            CqlQuantity pzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(5m, "years");
            CqlDateTime pzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzm_);
            CqlDateTime pzzzzzzzzzzzzzzzp_ = context.Operators.End(pzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzq_ = context.Operators.Interval(pzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzp_, true, true);
            bool? pzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzq_, default);
            CqlDateTime pzzzzzzzzzzzzzzzt_ = context.Operators.End(pzzzzzzzzzzzzzzzk_);
            bool? pzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzt_ is null));
            bool? pzzzzzzzzzzzzzzzv_ = context.Operators.And(pzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzu_);
            bool? pzzzzzzzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzv_);

            return pzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzza_);

        return pzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzx_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? pzzzzzzzzzzzzzzzz_(Procedure FlexibleSigmoidoscopy)
        {
            DataType qzzzzzzzzzzzzzzze_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzzze_);
            CqlDateTime qzzzzzzzzzzzzzzzg_ = context.Operators.End(qzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzzi_ = context.Operators.End(qzzzzzzzzzzzzzzzh_);
            CqlQuantity qzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(6m, "years");
            CqlDateTime qzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzj_);
            CqlDateTime qzzzzzzzzzzzzzzzm_ = context.Operators.End(qzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzn_ = context.Operators.Interval(qzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzm_, true, true);
            bool? qzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzn_, default);
            CqlDateTime qzzzzzzzzzzzzzzzq_ = context.Operators.End(qzzzzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzq_ is null));
            bool? qzzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzr_);

            return qzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzz_);
        CqlDateTime qzzzzzzzzzzzzzzzb_(Procedure FlexibleSigmoidoscopy)
        {
            DataType qzzzzzzzzzzzzzzzt_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime qzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, qzzzzzzzzzzzzzzzt_);

            return qzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDateTime> qzzzzzzzzzzzzzzzc_ = context.Operators.Select<Procedure, CqlDateTime>(qzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDateTime> qzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDateTime>(qzzzzzzzzzzzzzzzc_);

        return qzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzv_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? qzzzzzzzzzzzzzzzx_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> qzzzzzzzzzzzzzzzz_ = FlexibleSigmoidoscopy?.StatusElement;
            string rzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzzzzzz_);
            bool? rzzzzzzzzzzzzzzzb_ = context.Operators.Equal(rzzzzzzzzzzzzzzza_, "completed");
            DataType rzzzzzzzzzzzzzzzc_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzzzzzzzzzzzzc_);
            CqlDateTime rzzzzzzzzzzzzzzze_ = context.Operators.End(rzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzg_ = context.Operators.End(rzzzzzzzzzzzzzzzf_);
            CqlQuantity rzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(5m, "years");
            CqlDateTime rzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzh_);
            CqlDateTime rzzzzzzzzzzzzzzzk_ = context.Operators.End(rzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzl_ = context.Operators.Interval(rzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzk_, true, true);
            bool? rzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzl_, default);
            CqlDateTime rzzzzzzzzzzzzzzzo_ = context.Operators.End(rzzzzzzzzzzzzzzzf_);
            bool? rzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzo_ is null));
            bool? rzzzzzzzzzzzzzzzq_ = context.Operators.And(rzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzp_);
            bool? rzzzzzzzzzzzzzzzr_ = context.Operators.And(rzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzq_);

            return rzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzx_);

        return qzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzs_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? rzzzzzzzzzzzzzzzu_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> rzzzzzzzzzzzzzzzw_ = FlexibleSigmoidoscopy?.StatusElement;
            string rzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzzzzw_);
            bool? rzzzzzzzzzzzzzzzy_ = context.Operators.Equal(rzzzzzzzzzzzzzzzx_, "completed");
            bool? rzzzzzzzzzzzzzzzz_ = context.Operators.Not(rzzzzzzzzzzzzzzzy_);
            DataType szzzzzzzzzzzzzzza_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzza_);
            CqlDateTime szzzzzzzzzzzzzzzc_ = context.Operators.End(szzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzze_ = context.Operators.End(szzzzzzzzzzzzzzzd_);
            CqlQuantity szzzzzzzzzzzzzzzf_ = context.Operators.Quantity(5m, "years");
            CqlDateTime szzzzzzzzzzzzzzzg_ = context.Operators.Subtract(szzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzf_);
            CqlDateTime szzzzzzzzzzzzzzzi_ = context.Operators.End(szzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzj_ = context.Operators.Interval(szzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzi_, true, true);
            bool? szzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzj_, default);
            CqlDateTime szzzzzzzzzzzzzzzm_ = context.Operators.End(szzzzzzzzzzzzzzzd_);
            bool? szzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzm_ is null));
            bool? szzzzzzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzn_);
            bool? szzzzzzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzo_);

            return szzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzu_);

        return rzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzq_ = this.Colonoscopy(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? szzzzzzzzzzzzzzzs_(Procedure Colonoscopy)
        {
            DataType szzzzzzzzzzzzzzzx_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzzx_);
            CqlDateTime szzzzzzzzzzzzzzzz_ = context.Operators.End(szzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzb_ = context.Operators.End(tzzzzzzzzzzzzzzza_);
            CqlQuantity tzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(11m, "years");
            CqlDateTime tzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzc_);
            CqlDateTime tzzzzzzzzzzzzzzzf_ = context.Operators.End(tzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzg_ = context.Operators.Interval(tzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzf_, true, true);
            bool? tzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzg_, default);
            CqlDateTime tzzzzzzzzzzzzzzzj_ = context.Operators.End(tzzzzzzzzzzzzzzza_);
            bool? tzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzj_ is null));
            bool? tzzzzzzzzzzzzzzzl_ = context.Operators.And(tzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzk_);

            return tzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzs_);
        CqlDateTime szzzzzzzzzzzzzzzu_(Procedure Colonoscopy)
        {
            DataType tzzzzzzzzzzzzzzzm_ = Colonoscopy?.Performed;
            CqlDateTime tzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, tzzzzzzzzzzzzzzzm_);

            return tzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, CqlDateTime>(szzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDateTime>(szzzzzzzzzzzzzzzv_);

        return szzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzo_ = this.Colonoscopy(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? tzzzzzzzzzzzzzzzq_(Procedure Colonoscopy)
        {
            Code<EventStatus> tzzzzzzzzzzzzzzzs_ = Colonoscopy?.StatusElement;
            string tzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzzzzu_ = context.Operators.Equal(tzzzzzzzzzzzzzzzt_, "completed");
            DataType tzzzzzzzzzzzzzzzv_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzzzv_);
            CqlDateTime tzzzzzzzzzzzzzzzx_ = context.Operators.End(tzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzz_ = context.Operators.End(tzzzzzzzzzzzzzzzy_);
            CqlQuantity uzzzzzzzzzzzzzzza_ = context.Operators.Quantity(10m, "years");
            CqlDateTime uzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzza_);
            CqlDateTime uzzzzzzzzzzzzzzzd_ = context.Operators.End(tzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzze_ = context.Operators.Interval(uzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzd_, true, true);
            bool? uzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzze_, default);
            CqlDateTime uzzzzzzzzzzzzzzzh_ = context.Operators.End(tzzzzzzzzzzzzzzzy_);
            bool? uzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzh_ is null));
            bool? uzzzzzzzzzzzzzzzj_ = context.Operators.And(uzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzi_);
            bool? uzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzj_);

            return uzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(tzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzq_);

        return tzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzl_ = this.Colonoscopy(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? uzzzzzzzzzzzzzzzn_(Procedure Colonoscopy)
        {
            Code<EventStatus> uzzzzzzzzzzzzzzzp_ = Colonoscopy?.StatusElement;
            string uzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzzp_);
            bool? uzzzzzzzzzzzzzzzr_ = context.Operators.Equal(uzzzzzzzzzzzzzzzq_, "completed");
            bool? uzzzzzzzzzzzzzzzs_ = context.Operators.Not(uzzzzzzzzzzzzzzzr_);
            DataType uzzzzzzzzzzzzzzzt_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzzzzzzzzzzzzt_);
            CqlDateTime uzzzzzzzzzzzzzzzv_ = context.Operators.End(uzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzx_ = context.Operators.End(uzzzzzzzzzzzzzzzw_);
            CqlQuantity uzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(10m, "years");
            CqlDateTime uzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzy_);
            CqlDateTime vzzzzzzzzzzzzzzzb_ = context.Operators.End(uzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzc_ = context.Operators.Interval(uzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzb_, true, true);
            bool? vzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzc_, default);
            CqlDateTime vzzzzzzzzzzzzzzzf_ = context.Operators.End(uzzzzzzzzzzzzzzzw_);
            bool? vzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzf_ is null));
            bool? vzzzzzzzzzzzzzzzh_ = context.Operators.And(vzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzg_);
            bool? vzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzh_);

            return vzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzn_);

        return uzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzj_ = this.Colonoscopy_Performed(context);
        bool? vzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzl_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? vzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzl_);
        bool? vzzzzzzzzzzzzzzzn_ = context.Operators.Or(vzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzm_);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzo_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? vzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzzzzzzo_);
        bool? vzzzzzzzzzzzzzzzq_ = context.Operators.Or(vzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzr_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? vzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzr_);
        bool? vzzzzzzzzzzzzzzzt_ = context.Operators.Or(vzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzu_ = this.CT_Colonography_Performed(context);
        bool? vzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzu_);
        bool? vzzzzzzzzzzzzzzzw_ = context.Operators.Or(vzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzv_);

        return vzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzx_ = this.Numerator(context);
        bool? vzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);
        bool? vzzzzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzy_);
        bool? wzzzzzzzzzzzzzzza_ = this.Denominator(context);
        bool? wzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzzzc_ = this.Denominator_Exclusions(context);
        bool? wzzzzzzzzzzzzzzzd_ = context.Operators.Not(wzzzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzzzze_ = context.Operators.And(wzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzd_);

        return wzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
