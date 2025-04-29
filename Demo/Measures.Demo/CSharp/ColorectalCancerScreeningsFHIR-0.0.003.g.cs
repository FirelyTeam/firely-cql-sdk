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
        CqlDateTime hzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime hzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzl_, true, false);
        object hzzzzzzzzzzzzzzzzn_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", hzzzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> hzzzzzzzzzzzzzzzzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> hzzzzzzzzzzzzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return hzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> hzzzzzzzzzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzu_ = this.Online_Assessments(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet hzzzzzzzzzzzzzzzzw_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzx_);
        bool? hzzzzzzzzzzzzzzzzz_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzb_ = TelehealthEncounter?.StatusElement;
            string izzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzzb_);
            bool? izzzzzzzzzzzzzzzzd_ = context.Operators.Equal(izzzzzzzzzzzzzzzzc_, "finished");
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            Period izzzzzzzzzzzzzzzzf_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzzzf_ as object);
            bool? izzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzg_, default);
            bool? izzzzzzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzh_);

            return izzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzz_);

        return izzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient izzzzzzzzzzzzzzzzj_ = this.Patient(context);
        Date izzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzj_?.BirthDateElement;
        string izzzzzzzzzzzzzzzzl_ = izzzzzzzzzzzzzzzzk_?.Value;
        CqlDate izzzzzzzzzzzzzzzzm_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzzzzl_);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzzzzzzzzzzzo_ = context.Operators.Start(izzzzzzzzzzzzzzzzn_);
        CqlDate izzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzo_);
        int? izzzzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzp_, "year");

        return izzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient izzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date izzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string izzzzzzzzzzzzzzzzt_ = izzzzzzzzzzzzzzzzs_?.Value;
        CqlDate izzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzzzzzzzzzzzw_ = context.Operators.Start(izzzzzzzzzzzzzzzzv_);
        CqlDate izzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzw_);
        int? izzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzx_, "year");
        CqlInterval<int?> izzzzzzzzzzzzzzzzz_ = context.Operators.Interval(51, 75, true, false);
        bool? jzzzzzzzzzzzzzzzza_ = context.Operators.In<int?>(izzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzz_, default);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzb_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzc_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzc_);
        bool? jzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzd_);
        bool? jzzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzze_);

        return jzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);

        return jzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzh_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? jzzzzzzzzzzzzzzzzj_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime jzzzzzzzzzzzzzzzzm_ = context.Operators.Start(jzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzo_ = context.Operators.End(jzzzzzzzzzzzzzzzzn_);
            bool? jzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzo_, default);

            return jzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzj_);

        return jzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzq_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? jzzzzzzzzzzzzzzzzs_(Procedure Colectomy)
        {
            Code<EventStatus> jzzzzzzzzzzzzzzzzu_ = Colectomy?.StatusElement;
            string jzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzzzzu_);
            bool? jzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzv_, "completed");
            DataType jzzzzzzzzzzzzzzzzx_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzzx_);
            CqlDateTime jzzzzzzzzzzzzzzzzz_ = context.Operators.End(jzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzb_ = context.Operators.End(kzzzzzzzzzzzzzzzza_);
            bool? kzzzzzzzzzzzzzzzzc_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzb_, default);
            bool? kzzzzzzzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzc_);

            return kzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzs_);

        return jzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzze_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? kzzzzzzzzzzzzzzzzg_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime kzzzzzzzzzzzzzzzzj_ = context.Operators.Start(kzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzl_ = context.Operators.End(kzzzzzzzzzzzzzzzzk_);
            bool? kzzzzzzzzzzzzzzzzm_ = context.Operators.SameOrBefore(kzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzl_, default);

            return kzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzg_);

        return kzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzn_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzo_ = this.Malignant_Neoplasm(context);
        bool? kzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzzzo_);
        bool? kzzzzzzzzzzzzzzzzq_ = context.Operators.Or(kzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzp_);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzr_ = this.Total_Colectomy_Performed(context);
        bool? kzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzr_);
        bool? kzzzzzzzzzzzzzzzzt_ = context.Operators.Or(kzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzu_ = this.Total_Colectomy_Condition(context);
        bool? kzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzzzu_);
        bool? kzzzzzzzzzzzzzzzzw_ = context.Operators.Or(kzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzv_);
        bool? kzzzzzzzzzzzzzzzzx_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? kzzzzzzzzzzzzzzzzy_ = context.Operators.Or(kzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzx_);
        Patient kzzzzzzzzzzzzzzzzz_ = this.Patient(context);
        Date lzzzzzzzzzzzzzzzza_ = kzzzzzzzzzzzzzzzzz_?.BirthDateElement;
        string lzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzza_?.Value;
        CqlDate lzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzzzze_ = context.Operators.Start(lzzzzzzzzzzzzzzzzd_);
        CqlDate lzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzze_);
        int? lzzzzzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzf_, "year");
        bool? lzzzzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzzg_, 65);
        bool? lzzzzzzzzzzzzzzzzi_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? lzzzzzzzzzzzzzzzzj_ = context.Operators.And(lzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzi_);
        bool? lzzzzzzzzzzzzzzzzk_ = context.Operators.Or(kzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzj_);
        bool? lzzzzzzzzzzzzzzzzl_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzzm_ = context.Operators.Or(lzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzn_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? lzzzzzzzzzzzzzzzzp_(Observation FecalOccult)
        {
            DataType lzzzzzzzzzzzzzzzzu_ = FecalOccult?.Effective;
            CqlDateTime lzzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, lzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzx_ = context.Operators.Start(lzzzzzzzzzzzzzzzzw_);
            CqlQuantity lzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "year");
            CqlDateTime lzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzy_);
            CqlDateTime mzzzzzzzzzzzzzzzzb_ = context.Operators.End(lzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzb_, false, false);
            bool? mzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzc_, default);

            return mzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzp_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? lzzzzzzzzzzzzzzzzr_(Observation FecalOccult)
        {
            DataType mzzzzzzzzzzzzzzzze_ = FecalOccult?.Effective;
            CqlDateTime mzzzzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, mzzzzzzzzzzzzzzzze_);
            DataType mzzzzzzzzzzzzzzzzg_ = FecalOccult?.Value;
            IEnumerable<Coding> mzzzzzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(mzzzzzzzzzzzzzzzzg_, "coding");
            bool? mzzzzzzzzzzzzzzzzi_(Coding @this)
            {
                FhirString nzzzzzzzzzzzzzzzzc_ = @this?.DisplayElement;
                bool? nzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzc_ is null));

                return nzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Coding> mzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Coding>(mzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzi_);
            FhirString mzzzzzzzzzzzzzzzzk_(Coding @this)
            {
                FhirString nzzzzzzzzzzzzzzzze_ = @this?.DisplayElement;

                return nzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<FhirString> mzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Coding, FhirString>(mzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzk_);
            List<CodeableConcept> mzzzzzzzzzzzzzzzzm_ = FecalOccult?.Category;
            bool? mzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
            {
                List<Coding> nzzzzzzzzzzzzzzzzf_ = @this?.Coding;
                bool? nzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzf_ is null));

                return nzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CodeableConcept> mzzzzzzzzzzzzzzzzo_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzn_);
            List<Coding> mzzzzzzzzzzzzzzzzp_(CodeableConcept @this)
            {
                List<Coding> nzzzzzzzzzzzzzzzzh_ = @this?.Coding;

                return nzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<List<Coding>> mzzzzzzzzzzzzzzzzq_ = context.Operators.Select<CodeableConcept, List<Coding>>(mzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzp_);
            IEnumerable<Coding> mzzzzzzzzzzzzzzzzr_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)mzzzzzzzzzzzzzzzzq_);
            bool? mzzzzzzzzzzzzzzzzs_(Coding @this)
            {
                Code nzzzzzzzzzzzzzzzzi_ = @this?.CodeElement;
                bool? nzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzi_ is null));

                return nzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Coding> mzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Coding>(mzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzs_);
            Code mzzzzzzzzzzzzzzzzu_(Coding @this)
            {
                Code nzzzzzzzzzzzzzzzzk_ = @this?.CodeElement;

                return nzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Code> mzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Coding, Code>(mzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzu_);
            bool? mzzzzzzzzzzzzzzzzw_(Code @this)
            {
                string nzzzzzzzzzzzzzzzzl_ = @this?.Value;
                bool? nzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzl_ is null));

                return nzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Code> mzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Code>(mzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzw_);
            string mzzzzzzzzzzzzzzzzy_(Code @this)
            {
                string nzzzzzzzzzzzzzzzzn_ = @this?.Value;

                return nzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<string> mzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Code, string>(mzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzy_);
            Code<ObservationStatus> nzzzzzzzzzzzzzzzza_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? nzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, mzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzza_);

            return nzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> lzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(lzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> lzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(lzzzzzzzzzzzzzzzzs_);

        return lzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzo_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? nzzzzzzzzzzzzzzzzq_(Observation FecalOccult)
        {
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzs_ = FecalOccult?.StatusElement;
            string nzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzzzzzzs_);
            string[] nzzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            List<CodeableConcept> nzzzzzzzzzzzzzzzzw_ = FecalOccult?.Category;
            bool? nzzzzzzzzzzzzzzzzx_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> ozzzzzzzzzzzzzzzzj_ = FecalOccultCategory?.Coding;
                bool? ozzzzzzzzzzzzzzzzk_(Coding @this)
                {
                    Code ozzzzzzzzzzzzzzzzu_ = @this?.CodeElement;
                    bool? ozzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzu_ is null));

                    return ozzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Coding> ozzzzzzzzzzzzzzzzl_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzk_);
                Code ozzzzzzzzzzzzzzzzm_(Coding @this)
                {
                    Code ozzzzzzzzzzzzzzzzw_ = @this?.CodeElement;

                    return ozzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Code> ozzzzzzzzzzzzzzzzn_ = context.Operators.Select<Coding, Code>(ozzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzm_);
                bool? ozzzzzzzzzzzzzzzzo_(Code @this)
                {
                    string ozzzzzzzzzzzzzzzzx_ = @this?.Value;
                    bool? ozzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzx_ is null));

                    return ozzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Code> ozzzzzzzzzzzzzzzzp_ = context.Operators.Where<Code>(ozzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzo_);
                string ozzzzzzzzzzzzzzzzq_(Code @this)
                {
                    string ozzzzzzzzzzzzzzzzz_ = @this?.Value;

                    return ozzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<string> ozzzzzzzzzzzzzzzzr_ = context.Operators.Select<Code, string>(ozzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzq_);
                string[] ozzzzzzzzzzzzzzzzs_ = [
                    "laboratory",
                ];
                bool? ozzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent<string>(ozzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzs_ as IEnumerable<string>);

                return ozzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CodeableConcept> nzzzzzzzzzzzzzzzzy_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzx_);
            bool? nzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CodeableConcept>(nzzzzzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzz_);
            DataType ozzzzzzzzzzzzzzzzb_ = FecalOccult?.Value;
            bool? ozzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzb_ is null));
            bool? ozzzzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzc_);
            DataType ozzzzzzzzzzzzzzzze_ = FecalOccult?.Effective;
            CqlDateTime ozzzzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ozzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzg_, default);
            bool? ozzzzzzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzh_);

            return ozzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzq_);

        return nzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzza_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzzzzzzzzzzzzzzc_(Observation FecalOccult)
        {
            Code<ObservationStatus> pzzzzzzzzzzzzzzzze_ = FecalOccult?.StatusElement;
            string pzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzzzze_);
            string[] pzzzzzzzzzzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            List<CodeableConcept> pzzzzzzzzzzzzzzzzi_ = FecalOccult?.Category;
            bool? pzzzzzzzzzzzzzzzzj_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> pzzzzzzzzzzzzzzzzv_ = FecalOccultCategory?.Coding;
                bool? pzzzzzzzzzzzzzzzzw_(Coding @this)
                {
                    Code qzzzzzzzzzzzzzzzzg_ = @this?.CodeElement;
                    bool? qzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzg_ is null));

                    return qzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Coding> pzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzw_);
                Code pzzzzzzzzzzzzzzzzy_(Coding @this)
                {
                    Code qzzzzzzzzzzzzzzzzi_ = @this?.CodeElement;

                    return qzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Code> pzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Coding, Code>(pzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzy_);
                bool? qzzzzzzzzzzzzzzzza_(Code @this)
                {
                    string qzzzzzzzzzzzzzzzzj_ = @this?.Value;
                    bool? qzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzj_ is null));

                    return qzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Code> qzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Code>(pzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzza_);
                string qzzzzzzzzzzzzzzzzc_(Code @this)
                {
                    string qzzzzzzzzzzzzzzzzl_ = @this?.Value;

                    return qzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<string> qzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Code, string>(qzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzc_);
                string[] qzzzzzzzzzzzzzzzze_ = [
                    "laboratory",
                ];
                bool? qzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent<string>(qzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzze_ as IEnumerable<string>);

                return qzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CodeableConcept> pzzzzzzzzzzzzzzzzk_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzj_);
            bool? pzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<CodeableConcept>(pzzzzzzzzzzzzzzzzk_);
            bool? pzzzzzzzzzzzzzzzzm_ = context.Operators.And(pzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzl_);
            DataType pzzzzzzzzzzzzzzzzn_ = FecalOccult?.Value;
            bool? pzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzn_ is null));
            bool? pzzzzzzzzzzzzzzzzp_ = context.Operators.And(pzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzo_);
            DataType pzzzzzzzzzzzzzzzzq_ = FecalOccult?.Effective;
            CqlDateTime pzzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, pzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzs_, "day");
            bool? pzzzzzzzzzzzzzzzzu_ = context.Operators.And(pzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzt_);

            return pzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzc_);

        return pzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzm_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? qzzzzzzzzzzzzzzzzo_(Observation FecalOccult)
        {
            List<CodeableConcept> qzzzzzzzzzzzzzzzzq_ = FecalOccult?.Category;
            bool? qzzzzzzzzzzzzzzzzr_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> rzzzzzzzzzzzzzzzzc_ = FecalOccultCategory?.Coding;
                bool? rzzzzzzzzzzzzzzzzd_(Coding @this)
                {
                    Code rzzzzzzzzzzzzzzzzo_ = @this?.CodeElement;
                    bool? rzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzo_ is null));

                    return rzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Coding> rzzzzzzzzzzzzzzzze_ = context.Operators.Where<Coding>((IEnumerable<Coding>)rzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzd_);
                Code rzzzzzzzzzzzzzzzzf_(Coding @this)
                {
                    Code rzzzzzzzzzzzzzzzzq_ = @this?.CodeElement;

                    return rzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Code> rzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Coding, Code>(rzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzf_);
                bool? rzzzzzzzzzzzzzzzzh_(Code @this)
                {
                    string rzzzzzzzzzzzzzzzzr_ = @this?.Value;
                    bool? rzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzr_ is null));

                    return rzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Code> rzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Code>(rzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzh_);
                string rzzzzzzzzzzzzzzzzj_(Code @this)
                {
                    string rzzzzzzzzzzzzzzzzt_ = @this?.Value;

                    return rzzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<string> rzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Code, string>(rzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzj_);
                string[] rzzzzzzzzzzzzzzzzl_ = [
                    "laboratory",
                ];
                bool? rzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent<string>(rzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzn_ = context.Operators.Not(rzzzzzzzzzzzzzzzzm_);

                return rzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CodeableConcept> qzzzzzzzzzzzzzzzzs_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzr_);
            bool? qzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<CodeableConcept>(qzzzzzzzzzzzzzzzzs_);
            DataType qzzzzzzzzzzzzzzzzu_ = FecalOccult?.Value;
            bool? qzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzu_ is null));
            bool? qzzzzzzzzzzzzzzzzw_ = context.Operators.And(qzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzv_);
            DataType qzzzzzzzzzzzzzzzzx_ = FecalOccult?.Effective;
            CqlDateTime qzzzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, qzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzz_, "day");
            bool? rzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzza_);

            return rzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzo_);

        return qzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzu_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzzzzzzzzzzzzw_(Observation FecalOccult)
        {
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzy_ = FecalOccult?.StatusElement;
            string rzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzzzzzy_);
            string[] szzzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzzzc_ = context.Operators.Not(szzzzzzzzzzzzzzzzb_);
            DataType szzzzzzzzzzzzzzzzd_ = FecalOccult?.Value;
            bool? szzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzd_ is null));
            bool? szzzzzzzzzzzzzzzzf_ = context.Operators.And(szzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzze_);
            DataType szzzzzzzzzzzzzzzzg_ = FecalOccult?.Effective;
            CqlDateTime szzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzi_, "day");
            bool? szzzzzzzzzzzzzzzzk_ = context.Operators.And(szzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzj_);

            return szzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzw_);

        return rzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzl_ = this.FIT_DNA(context);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzzzzzzzzzzzzzzn_(Observation FitDNA)
        {
            DataType szzzzzzzzzzzzzzzzs_ = FitDNA?.Effective;
            CqlDateTime szzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzzv_ = context.Operators.End(szzzzzzzzzzzzzzzzu_);
            CqlQuantity szzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(4m, "years");
            CqlDateTime szzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzw_);
            CqlDateTime szzzzzzzzzzzzzzzzz_ = context.Operators.End(szzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzza_ = context.Operators.Interval(szzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzz_, true, true);
            bool? tzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzza_, default);
            CqlDateTime tzzzzzzzzzzzzzzzzd_ = context.Operators.End(szzzzzzzzzzzzzzzzu_);
            bool? tzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzd_ is null));
            bool? tzzzzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzze_);

            return tzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzn_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? szzzzzzzzzzzzzzzzp_(Observation FitDNA)
        {
            DataType tzzzzzzzzzzzzzzzzg_ = FitDNA?.Effective;
            CqlDateTime tzzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, tzzzzzzzzzzzzzzzzg_);
            DataType tzzzzzzzzzzzzzzzzi_ = FitDNA?.Value;
            IEnumerable<Coding> tzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(tzzzzzzzzzzzzzzzzi_, "coding");
            bool? tzzzzzzzzzzzzzzzzk_(Coding @this)
            {
                FhirString uzzzzzzzzzzzzzzzze_ = @this?.DisplayElement;
                bool? uzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzze_ is null));

                return uzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Coding> tzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Coding>(tzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzk_);
            FhirString tzzzzzzzzzzzzzzzzm_(Coding @this)
            {
                FhirString uzzzzzzzzzzzzzzzzg_ = @this?.DisplayElement;

                return uzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<FhirString> tzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Coding, FhirString>(tzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzm_);
            List<CodeableConcept> tzzzzzzzzzzzzzzzzo_ = FitDNA?.Category;
            bool? tzzzzzzzzzzzzzzzzp_(CodeableConcept @this)
            {
                List<Coding> uzzzzzzzzzzzzzzzzh_ = @this?.Coding;
                bool? uzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzh_ is null));

                return uzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CodeableConcept> tzzzzzzzzzzzzzzzzq_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzp_);
            List<Coding> tzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
            {
                List<Coding> uzzzzzzzzzzzzzzzzj_ = @this?.Coding;

                return uzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<List<Coding>> tzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, List<Coding>>(tzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzr_);
            IEnumerable<Coding> tzzzzzzzzzzzzzzzzt_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)tzzzzzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzzzzzu_(Coding @this)
            {
                Code uzzzzzzzzzzzzzzzzk_ = @this?.CodeElement;
                bool? uzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzk_ is null));

                return uzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Coding> tzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Coding>(tzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzu_);
            Code tzzzzzzzzzzzzzzzzw_(Coding @this)
            {
                Code uzzzzzzzzzzzzzzzzm_ = @this?.CodeElement;

                return uzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Code> tzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Coding, Code>(tzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzw_);
            bool? tzzzzzzzzzzzzzzzzy_(Code @this)
            {
                string uzzzzzzzzzzzzzzzzn_ = @this?.Value;
                bool? uzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzn_ is null));

                return uzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Code> tzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Code>(tzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzy_);
            string uzzzzzzzzzzzzzzzza_(Code @this)
            {
                string uzzzzzzzzzzzzzzzzp_ = @this?.Value;

                return uzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<string> uzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Code, string>(tzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzza_);
            Code<ObservationStatus> uzzzzzzzzzzzzzzzzc_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? uzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, tzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzc_);

            return uzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> szzzzzzzzzzzzzzzzq_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(szzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> szzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(szzzzzzzzzzzzzzzzq_);

        return szzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzq_ = this.FIT_DNA(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? uzzzzzzzzzzzzzzzzs_(Observation FitDNA)
        {
            Code<ObservationStatus> uzzzzzzzzzzzzzzzzu_ = FitDNA?.StatusElement;
            string uzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzzzu_);
            string[] uzzzzzzzzzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            List<CodeableConcept> uzzzzzzzzzzzzzzzzy_ = FitDNA?.Category;
            bool? uzzzzzzzzzzzzzzzzz_(CodeableConcept FitDNACategory)
            {
                List<Coding> vzzzzzzzzzzzzzzzzv_ = FitDNACategory?.Coding;
                bool? vzzzzzzzzzzzzzzzzw_(Coding @this)
                {
                    Code wzzzzzzzzzzzzzzzzg_ = @this?.CodeElement;
                    bool? wzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzg_ is null));

                    return wzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Coding> vzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Coding>((IEnumerable<Coding>)vzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzw_);
                Code vzzzzzzzzzzzzzzzzy_(Coding @this)
                {
                    Code wzzzzzzzzzzzzzzzzi_ = @this?.CodeElement;

                    return wzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Code> vzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Coding, Code>(vzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzzza_(Code @this)
                {
                    string wzzzzzzzzzzzzzzzzj_ = @this?.Value;
                    bool? wzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzj_ is null));

                    return wzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Code> wzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Code>(vzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzza_);
                string wzzzzzzzzzzzzzzzzc_(Code @this)
                {
                    string wzzzzzzzzzzzzzzzzl_ = @this?.Value;

                    return wzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<string> wzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Code, string>(wzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzc_);
                string[] wzzzzzzzzzzzzzzzze_ = [
                    "laboratory",
                ];
                bool? wzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent<string>(wzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzze_ as IEnumerable<string>);

                return wzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CodeableConcept> vzzzzzzzzzzzzzzzza_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzz_);
            bool? vzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CodeableConcept>(vzzzzzzzzzzzzzzzza_);
            bool? vzzzzzzzzzzzzzzzzc_ = context.Operators.And(uzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzb_);
            DataType vzzzzzzzzzzzzzzzzd_ = FitDNA?.Value;
            bool? vzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzd_ is null));
            bool? vzzzzzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzze_);
            DataType vzzzzzzzzzzzzzzzzg_ = FitDNA?.Effective;
            CqlDateTime vzzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzj_ = context.Operators.End(vzzzzzzzzzzzzzzzzi_);
            CqlQuantity vzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(3m, "years");
            CqlDateTime vzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzk_);
            CqlDateTime vzzzzzzzzzzzzzzzzn_ = context.Operators.End(vzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzn_, true, true);
            bool? vzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzo_, default);
            CqlDateTime vzzzzzzzzzzzzzzzzr_ = context.Operators.End(vzzzzzzzzzzzzzzzzi_);
            bool? vzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzr_ is null));
            bool? vzzzzzzzzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzs_);
            bool? vzzzzzzzzzzzzzzzzu_ = context.Operators.And(vzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzt_);

            return vzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzs_);

        return uzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzm_ = this.FIT_DNA(context);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? wzzzzzzzzzzzzzzzzo_(Observation FitDNA)
        {
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzq_ = FitDNA?.StatusElement;
            string wzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzzq_);
            string[] wzzzzzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            List<CodeableConcept> wzzzzzzzzzzzzzzzzu_ = FitDNA?.Category;
            bool? wzzzzzzzzzzzzzzzzv_(CodeableConcept FitDNACategory)
            {
                List<Coding> xzzzzzzzzzzzzzzzzr_ = FitDNACategory?.Coding;
                bool? xzzzzzzzzzzzzzzzzs_(Coding @this)
                {
                    Code yzzzzzzzzzzzzzzzzc_ = @this?.CodeElement;
                    bool? yzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzc_ is null));

                    return yzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Coding> xzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Coding>((IEnumerable<Coding>)xzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzs_);
                Code xzzzzzzzzzzzzzzzzu_(Coding @this)
                {
                    Code yzzzzzzzzzzzzzzzze_ = @this?.CodeElement;

                    return yzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Code> xzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Coding, Code>(xzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzu_);
                bool? xzzzzzzzzzzzzzzzzw_(Code @this)
                {
                    string yzzzzzzzzzzzzzzzzf_ = @this?.Value;
                    bool? yzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzf_ is null));

                    return yzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Code> xzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Code>(xzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzw_);
                string xzzzzzzzzzzzzzzzzy_(Code @this)
                {
                    string yzzzzzzzzzzzzzzzzh_ = @this?.Value;

                    return yzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<string> xzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Code, string>(xzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzy_);
                string[] yzzzzzzzzzzzzzzzza_ = [
                    "laboratory",
                ];
                bool? yzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent<string>(xzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzza_ as IEnumerable<string>);

                return yzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CodeableConcept> wzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzv_);
            bool? wzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<CodeableConcept>(wzzzzzzzzzzzzzzzzw_);
            bool? wzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzx_);
            DataType wzzzzzzzzzzzzzzzzz_ = FitDNA?.Value;
            bool? xzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzz_ is null));
            bool? xzzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzza_);
            DataType xzzzzzzzzzzzzzzzzc_ = FitDNA?.Effective;
            CqlDateTime xzzzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, xzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzf_ = context.Operators.End(xzzzzzzzzzzzzzzzze_);
            CqlQuantity xzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(3m, "years");
            CqlDateTime xzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzg_);
            CqlDateTime xzzzzzzzzzzzzzzzzj_ = context.Operators.End(xzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzj_, true, true);
            bool? xzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzk_, "day");
            CqlDateTime xzzzzzzzzzzzzzzzzn_ = context.Operators.End(xzzzzzzzzzzzzzzzze_);
            bool? xzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzn_ is null));
            bool? xzzzzzzzzzzzzzzzzp_ = context.Operators.And(xzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzo_);
            bool? xzzzzzzzzzzzzzzzzq_ = context.Operators.And(xzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzp_);

            return xzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzo_);

        return wzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzi_ = this.FIT_DNA(context);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzzzzzzzzzzzzzzk_(Observation FitDNA)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzzzzm_ = FitDNA?.Category;
            bool? yzzzzzzzzzzzzzzzzn_(CodeableConcept FitDNACategory)
            {
                List<Coding> zzzzzzzzzzzzzzzzzi_ = FitDNACategory?.Coding;
                bool? zzzzzzzzzzzzzzzzzj_(Coding @this)
                {
                    Code zzzzzzzzzzzzzzzzzu_ = @this?.CodeElement;
                    bool? zzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzu_ is null));

                    return zzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Coding> zzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Coding>((IEnumerable<Coding>)zzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzj_);
                Code zzzzzzzzzzzzzzzzzl_(Coding @this)
                {
                    Code zzzzzzzzzzzzzzzzzw_ = @this?.CodeElement;

                    return zzzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Code> zzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Coding, Code>(zzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzl_);
                bool? zzzzzzzzzzzzzzzzzn_(Code @this)
                {
                    string zzzzzzzzzzzzzzzzzx_ = @this?.Value;
                    bool? zzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzx_ is null));

                    return zzzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Code> zzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Code>(zzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzn_);
                string zzzzzzzzzzzzzzzzzp_(Code @this)
                {
                    string zzzzzzzzzzzzzzzzzz_ = @this?.Value;

                    return zzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<string> zzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Code, string>(zzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzp_);
                string[] zzzzzzzzzzzzzzzzzr_ = [
                    "laboratory",
                ];
                bool? zzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent<string>(zzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzt_ = context.Operators.Not(zzzzzzzzzzzzzzzzzs_);

                return zzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CodeableConcept> yzzzzzzzzzzzzzzzzo_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzn_);
            bool? yzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<CodeableConcept>(yzzzzzzzzzzzzzzzzo_);
            DataType yzzzzzzzzzzzzzzzzq_ = FitDNA?.Value;
            bool? yzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzq_ is null));
            bool? yzzzzzzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzr_);
            DataType yzzzzzzzzzzzzzzzzt_ = FitDNA?.Effective;
            CqlDateTime yzzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, yzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzw_ = context.Operators.End(yzzzzzzzzzzzzzzzzv_);
            CqlQuantity yzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(3m, "years");
            CqlDateTime yzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzx_);
            CqlDateTime zzzzzzzzzzzzzzzzza_ = context.Operators.End(yzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzza_, true, true);
            bool? zzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzb_, "day");
            CqlDateTime zzzzzzzzzzzzzzzzze_ = context.Operators.End(yzzzzzzzzzzzzzzzzv_);
            bool? zzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzze_ is null));
            bool? zzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzf_);
            bool? zzzzzzzzzzzzzzzzzh_ = context.Operators.And(yzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzg_);

            return zzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzk_);

        return yzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzza_ = this.FIT_DNA(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? azzzzzzzzzzzzzzzzzc_(Observation FitDNA)
        {
            Code<ObservationStatus> azzzzzzzzzzzzzzzzze_ = FitDNA?.StatusElement;
            string azzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzzzze_);
            string[] azzzzzzzzzzzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? azzzzzzzzzzzzzzzzzi_ = context.Operators.Not(azzzzzzzzzzzzzzzzzh_);
            DataType azzzzzzzzzzzzzzzzzj_ = FitDNA?.Value;
            bool? azzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzj_ is null));
            bool? azzzzzzzzzzzzzzzzzl_ = context.Operators.And(azzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzk_);
            DataType azzzzzzzzzzzzzzzzzm_ = FitDNA?.Effective;
            CqlDateTime azzzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, azzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzp_ = context.Operators.End(azzzzzzzzzzzzzzzzzo_);
            CqlQuantity azzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(3m, "years");
            CqlDateTime azzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzq_);
            CqlDateTime azzzzzzzzzzzzzzzzzt_ = context.Operators.End(azzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzt_, true, true);
            bool? azzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzu_, "day");
            CqlDateTime azzzzzzzzzzzzzzzzzx_ = context.Operators.End(azzzzzzzzzzzzzzzzzo_);
            bool? azzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzx_ is null));
            bool? azzzzzzzzzzzzzzzzzz_ = context.Operators.And(azzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzy_);
            bool? bzzzzzzzzzzzzzzzzza_ = context.Operators.And(azzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzz_);

            return bzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzc_);

        return azzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzb_ = this.CT_Colonography(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzzzzzzzzzzzd_(Observation Colonography)
        {
            DataType bzzzzzzzzzzzzzzzzzi_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzzzzi_);
            CqlDateTime bzzzzzzzzzzzzzzzzzk_ = context.Operators.End(bzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzzzm_ = context.Operators.End(bzzzzzzzzzzzzzzzzzl_);
            CqlQuantity bzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(6m, "years");
            CqlDateTime bzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzn_);
            CqlDateTime bzzzzzzzzzzzzzzzzzq_ = context.Operators.End(bzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzq_, true, true);
            bool? bzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzr_, default);
            CqlDateTime bzzzzzzzzzzzzzzzzzu_ = context.Operators.End(bzzzzzzzzzzzzzzzzzl_);
            bool? bzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzu_ is null));
            bool? bzzzzzzzzzzzzzzzzzw_ = context.Operators.And(bzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzv_);

            return bzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzd_);
        CqlDateTime bzzzzzzzzzzzzzzzzzf_(Observation Colonography)
        {
            DataType bzzzzzzzzzzzzzzzzzx_ = Colonography?.Effective;
            CqlDateTime bzzzzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, bzzzzzzzzzzzzzzzzzx_);

            return bzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDateTime> bzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Observation, CqlDateTime>(bzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDateTime> bzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDateTime>(bzzzzzzzzzzzzzzzzzg_);

        return bzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzz_ = this.CT_Colonography(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzzzzzzzzzzzzzzzb_(Observation Colonography)
        {
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzd_ = Colonography?.StatusElement;
            string czzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzzzzd_);
            string[] czzzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? czzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            DataType czzzzzzzzzzzzzzzzzh_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzzzzh_);
            CqlDateTime czzzzzzzzzzzzzzzzzj_ = context.Operators.End(czzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzzzl_ = context.Operators.End(czzzzzzzzzzzzzzzzzk_);
            CqlQuantity czzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(5m, "years");
            CqlDateTime czzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzm_);
            CqlDateTime czzzzzzzzzzzzzzzzzp_ = context.Operators.End(czzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzp_, true, true);
            bool? czzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzq_, default);
            CqlDateTime czzzzzzzzzzzzzzzzzt_ = context.Operators.End(czzzzzzzzzzzzzzzzzk_);
            bool? czzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzt_ is null));
            bool? czzzzzzzzzzzzzzzzzv_ = context.Operators.And(czzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzu_);
            bool? czzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzb_);

        return czzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzx_ = this.CT_Colonography(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzzzzzzzzzzzzzzzz_(Observation Colonography)
        {
            Code<ObservationStatus> dzzzzzzzzzzzzzzzzzb_ = Colonography?.StatusElement;
            string dzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzzzb_);
            string[] dzzzzzzzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? dzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(dzzzzzzzzzzzzzzzzze_);
            DataType dzzzzzzzzzzzzzzzzzg_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzzzzzg_);
            CqlDateTime dzzzzzzzzzzzzzzzzzi_ = context.Operators.End(dzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzzzzk_ = context.Operators.End(dzzzzzzzzzzzzzzzzzj_);
            CqlQuantity dzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(5m, "years");
            CqlDateTime dzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzl_);
            CqlDateTime dzzzzzzzzzzzzzzzzzo_ = context.Operators.End(dzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzo_, true, true);
            bool? dzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzp_, default);
            CqlDateTime dzzzzzzzzzzzzzzzzzs_ = context.Operators.End(dzzzzzzzzzzzzzzzzzj_);
            bool? dzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzs_ is null));
            bool? dzzzzzzzzzzzzzzzzzu_ = context.Operators.And(dzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzt_);
            bool? dzzzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzu_);

            return dzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzw_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? dzzzzzzzzzzzzzzzzzy_(Procedure FlexibleSigmoidoscopy)
        {
            DataType ezzzzzzzzzzzzzzzzzd_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzzzzzzzzzd_);
            CqlDateTime ezzzzzzzzzzzzzzzzzf_ = context.Operators.End(ezzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzzzh_ = context.Operators.End(ezzzzzzzzzzzzzzzzzg_);
            CqlQuantity ezzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(6m, "years");
            CqlDateTime ezzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzi_);
            CqlDateTime ezzzzzzzzzzzzzzzzzl_ = context.Operators.End(ezzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzl_, true, true);
            bool? ezzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzm_, default);
            CqlDateTime ezzzzzzzzzzzzzzzzzp_ = context.Operators.End(ezzzzzzzzzzzzzzzzzg_);
            bool? ezzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzp_ is null));
            bool? ezzzzzzzzzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzq_);

            return ezzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzy_);
        CqlDateTime ezzzzzzzzzzzzzzzzza_(Procedure FlexibleSigmoidoscopy)
        {
            DataType ezzzzzzzzzzzzzzzzzs_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime ezzzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ezzzzzzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDateTime> ezzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Procedure, CqlDateTime>(dzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDateTime> ezzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDateTime>(ezzzzzzzzzzzzzzzzzb_);

        return ezzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzu_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? ezzzzzzzzzzzzzzzzzw_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> ezzzzzzzzzzzzzzzzzy_ = FlexibleSigmoidoscopy?.StatusElement;
            string ezzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzzzy_);
            bool? fzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzz_, "completed");
            DataType fzzzzzzzzzzzzzzzzzb_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzzzb_);
            CqlDateTime fzzzzzzzzzzzzzzzzzd_ = context.Operators.End(fzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzf_ = context.Operators.End(fzzzzzzzzzzzzzzzzze_);
            CqlQuantity fzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(5m, "years");
            CqlDateTime fzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzg_);
            CqlDateTime fzzzzzzzzzzzzzzzzzj_ = context.Operators.End(fzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzj_, true, true);
            bool? fzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzk_, default);
            CqlDateTime fzzzzzzzzzzzzzzzzzn_ = context.Operators.End(fzzzzzzzzzzzzzzzzze_);
            bool? fzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzn_ is null));
            bool? fzzzzzzzzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzo_);
            bool? fzzzzzzzzzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzp_);

            return fzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzr_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? fzzzzzzzzzzzzzzzzzt_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> fzzzzzzzzzzzzzzzzzv_ = FlexibleSigmoidoscopy?.StatusElement;
            string fzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzzzzzzzzzzv_);
            bool? fzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzw_, "completed");
            bool? fzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(fzzzzzzzzzzzzzzzzzx_);
            DataType fzzzzzzzzzzzzzzzzzz_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzzzz_);
            CqlDateTime gzzzzzzzzzzzzzzzzzb_ = context.Operators.End(gzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzzzd_ = context.Operators.End(gzzzzzzzzzzzzzzzzzc_);
            CqlQuantity gzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(5m, "years");
            CqlDateTime gzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzze_);
            CqlDateTime gzzzzzzzzzzzzzzzzzh_ = context.Operators.End(gzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzh_, true, true);
            bool? gzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzi_, default);
            CqlDateTime gzzzzzzzzzzzzzzzzzl_ = context.Operators.End(gzzzzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzl_ is null));
            bool? gzzzzzzzzzzzzzzzzzn_ = context.Operators.And(gzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzm_);
            bool? gzzzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzn_);

            return gzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzp_ = this.Colonoscopy(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? gzzzzzzzzzzzzzzzzzr_(Procedure Colonoscopy)
        {
            DataType gzzzzzzzzzzzzzzzzzw_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzzzw_);
            CqlDateTime gzzzzzzzzzzzzzzzzzy_ = context.Operators.End(gzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzza_ = context.Operators.End(gzzzzzzzzzzzzzzzzzz_);
            CqlQuantity hzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(11m, "years");
            CqlDateTime hzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzb_);
            CqlDateTime hzzzzzzzzzzzzzzzzze_ = context.Operators.End(gzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzze_, true, true);
            bool? hzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzf_, default);
            CqlDateTime hzzzzzzzzzzzzzzzzzi_ = context.Operators.End(gzzzzzzzzzzzzzzzzzz_);
            bool? hzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzi_ is null));
            bool? hzzzzzzzzzzzzzzzzzk_ = context.Operators.And(hzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzj_);

            return hzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzr_);
        CqlDateTime gzzzzzzzzzzzzzzzzzt_(Procedure Colonoscopy)
        {
            DataType hzzzzzzzzzzzzzzzzzl_ = Colonoscopy?.Performed;
            CqlDateTime hzzzzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, hzzzzzzzzzzzzzzzzzl_);

            return hzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDateTime> gzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Procedure, CqlDateTime>(gzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDateTime> gzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDateTime>(gzzzzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzn_ = this.Colonoscopy(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? hzzzzzzzzzzzzzzzzzp_(Procedure Colonoscopy)
        {
            Code<EventStatus> hzzzzzzzzzzzzzzzzzr_ = Colonoscopy?.StatusElement;
            string hzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzzzzzr_);
            bool? hzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzs_, "completed");
            DataType hzzzzzzzzzzzzzzzzzu_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzzzu_);
            CqlDateTime hzzzzzzzzzzzzzzzzzw_ = context.Operators.End(hzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzy_ = context.Operators.End(hzzzzzzzzzzzzzzzzzx_);
            CqlQuantity hzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(10m, "years");
            CqlDateTime izzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzz_);
            CqlDateTime izzzzzzzzzzzzzzzzzc_ = context.Operators.End(hzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(izzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzc_, true, true);
            bool? izzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzd_, default);
            CqlDateTime izzzzzzzzzzzzzzzzzg_ = context.Operators.End(hzzzzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzg_ is null));
            bool? izzzzzzzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzh_);
            bool? izzzzzzzzzzzzzzzzzj_ = context.Operators.And(hzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzi_);

            return izzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzp_);

        return hzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzk_ = this.Colonoscopy(context);
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzzzzzzzzzzzzzzzzm_(Procedure Colonoscopy)
        {
            Code<EventStatus> izzzzzzzzzzzzzzzzzo_ = Colonoscopy?.StatusElement;
            string izzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzzzo_);
            bool? izzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzp_, "completed");
            bool? izzzzzzzzzzzzzzzzzr_ = context.Operators.Not(izzzzzzzzzzzzzzzzzq_);
            DataType izzzzzzzzzzzzzzzzzs_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzzzzs_);
            CqlDateTime izzzzzzzzzzzzzzzzzu_ = context.Operators.End(izzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzw_ = context.Operators.End(izzzzzzzzzzzzzzzzzv_);
            CqlQuantity izzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(10m, "years");
            CqlDateTime izzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzx_);
            CqlDateTime jzzzzzzzzzzzzzzzzza_ = context.Operators.End(izzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzza_, true, true);
            bool? jzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzb_, default);
            CqlDateTime jzzzzzzzzzzzzzzzzze_ = context.Operators.End(izzzzzzzzzzzzzzzzzv_);
            bool? jzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzze_ is null));
            bool? jzzzzzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzf_);
            bool? jzzzzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzg_);

            return jzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzm_);

        return izzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzi_ = this.Colonoscopy_Performed(context);
        bool? jzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Procedure>(jzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzk_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? jzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzn_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? jzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Procedure>(jzzzzzzzzzzzzzzzzzn_);
        bool? jzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzq_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? jzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzq_);
        bool? jzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzt_ = this.CT_Colonography_Performed(context);
        bool? jzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzzzt_);
        bool? jzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzu_);

        return jzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzw_ = this.Numerator(context);
        bool? jzzzzzzzzzzzzzzzzzx_ = this.Initial_Population(context);
        bool? jzzzzzzzzzzzzzzzzzy_ = context.Operators.And(jzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzx_);
        bool? jzzzzzzzzzzzzzzzzzz_ = this.Denominator(context);
        bool? kzzzzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzz_);
        bool? kzzzzzzzzzzzzzzzzzb_ = this.Denominator_Exclusions(context);
        bool? kzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(kzzzzzzzzzzzzzzzzzb_);
        bool? kzzzzzzzzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzc_);

        return kzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
