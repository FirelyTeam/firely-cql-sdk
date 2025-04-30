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
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null,
          _laboratory);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime lzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime mzzzzzzzzzzzzzza_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzb_ = context.Operators.Interval(lzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzza_, true, false);
        object mzzzzzzzzzzzzzzc_ = context.ResolveParameter("Exam130FHIR-0.0.003", "Measurement Period", mzzzzzzzzzzzzzzb_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> mzzzzzzzzzzzzzzg_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzzh_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzj_ = this.Online_Assessments(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet mzzzzzzzzzzzzzzl_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzm_);
        bool? mzzzzzzzzzzzzzzo_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> mzzzzzzzzzzzzzzq_ = TelehealthEncounter?.StatusElement;
            string mzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzq_);
            bool? mzzzzzzzzzzzzzzs_ = context.Operators.Equal(mzzzzzzzzzzzzzzr_, "finished");
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            Period mzzzzzzzzzzzzzzu_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzzzzzzzzzzzu_ as object);
            bool? mzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzv_, default);
            bool? mzzzzzzzzzzzzzzx_ = context.Operators.And(mzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzw_);

            return mzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzo_);

        return mzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient mzzzzzzzzzzzzzzy_ = this.Patient(context);
        Date mzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzy_?.BirthDateElement;
        string nzzzzzzzzzzzzzza_ = mzzzzzzzzzzzzzzz_?.Value;
        CqlDate nzzzzzzzzzzzzzzb_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzza_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzzzzzd_ = context.Operators.Start(nzzzzzzzzzzzzzzc_);
        CqlDate nzzzzzzzzzzzzzze_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzd_);
        int? nzzzzzzzzzzzzzzf_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzze_, "year");

        return nzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient nzzzzzzzzzzzzzzg_ = this.Patient(context);
        Date nzzzzzzzzzzzzzzh_ = nzzzzzzzzzzzzzzg_?.BirthDateElement;
        string nzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzh_?.Value;
        CqlDate nzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzzzzzl_ = context.Operators.Start(nzzzzzzzzzzzzzzk_);
        CqlDate nzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzl_);
        int? nzzzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzm_, "year");
        CqlInterval<int?> nzzzzzzzzzzzzzzo_ = context.Operators.Interval(51, 75, true, false);
        bool? nzzzzzzzzzzzzzzp_ = context.Operators.In<int?>(nzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzo_, default);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzq_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzr_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzr_);
        bool? nzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzs_);
        bool? nzzzzzzzzzzzzzzu_ = context.Operators.And(nzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzt_);

        return nzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzv_ = this.Initial_Population(context);

        return nzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzw_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzzzzzzzzzzzzzy_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime ozzzzzzzzzzzzzzb_ = context.Operators.Start(ozzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzd_ = context.Operators.End(ozzzzzzzzzzzzzzc_);
            bool? ozzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzd_, default);

            return ozzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzy_);

        return nzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzf_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? ozzzzzzzzzzzzzzh_(Procedure Colectomy)
        {
            Code<EventStatus> ozzzzzzzzzzzzzzj_ = Colectomy?.StatusElement;
            string ozzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzzj_);
            bool? ozzzzzzzzzzzzzzl_ = context.Operators.Equal(ozzzzzzzzzzzzzzk_, "completed");
            DataType ozzzzzzzzzzzzzzm_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzzm_);
            CqlDateTime ozzzzzzzzzzzzzzo_ = context.Operators.End(ozzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzq_ = context.Operators.End(ozzzzzzzzzzzzzzp_);
            bool? ozzzzzzzzzzzzzzr_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzq_, default);
            bool? ozzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzr_);

            return ozzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzh_);

        return ozzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzt_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ozzzzzzzzzzzzzzv_(Condition ColectomyDx)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime ozzzzzzzzzzzzzzy_ = context.Operators.Start(ozzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzza_ = context.Operators.End(ozzzzzzzzzzzzzzz_);
            bool? pzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzza_, default);

            return pzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzc_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzd_ = this.Malignant_Neoplasm(context);
        bool? pzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzd_);
        bool? pzzzzzzzzzzzzzzf_ = context.Operators.Or(pzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzze_);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzg_ = this.Total_Colectomy_Performed(context);
        bool? pzzzzzzzzzzzzzzh_ = context.Operators.Exists<Procedure>(pzzzzzzzzzzzzzzg_);
        bool? pzzzzzzzzzzzzzzi_ = context.Operators.Or(pzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzj_ = this.Total_Colectomy_Condition(context);
        bool? pzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzj_);
        bool? pzzzzzzzzzzzzzzl_ = context.Operators.Or(pzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzm_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? pzzzzzzzzzzzzzzn_ = context.Operators.Or(pzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzm_);
        Patient pzzzzzzzzzzzzzzo_ = this.Patient(context);
        Date pzzzzzzzzzzzzzzp_ = pzzzzzzzzzzzzzzo_?.BirthDateElement;
        string pzzzzzzzzzzzzzzq_ = pzzzzzzzzzzzzzzp_?.Value;
        CqlDate pzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzt_ = context.Operators.Start(pzzzzzzzzzzzzzzs_);
        CqlDate pzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzt_);
        int? pzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzu_, "year");
        bool? pzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzv_, 65);
        bool? pzzzzzzzzzzzzzzx_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? pzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzx_);
        bool? pzzzzzzzzzzzzzzz_ = context.Operators.Or(pzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzzzza_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? qzzzzzzzzzzzzzzb_ = context.Operators.Or(pzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzc_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? qzzzzzzzzzzzzzze_(Observation FecalOccult)
        {
            DataType qzzzzzzzzzzzzzzj_ = FecalOccult?.Effective;
            CqlDateTime qzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, qzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzm_ = context.Operators.Start(qzzzzzzzzzzzzzzl_);
            CqlQuantity qzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "year");
            CqlDateTime qzzzzzzzzzzzzzzo_ = context.Operators.Subtract(qzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzn_);
            CqlDateTime qzzzzzzzzzzzzzzq_ = context.Operators.End(qzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzr_ = context.Operators.Interval(qzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzq_, false, false);
            bool? qzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzr_, default);

            return qzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzze_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? qzzzzzzzzzzzzzzg_(Observation FecalOccult)
        {
            DataType qzzzzzzzzzzzzzzt_ = FecalOccult?.Effective;
            CqlDateTime qzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, qzzzzzzzzzzzzzzt_);
            DataType qzzzzzzzzzzzzzzv_ = FecalOccult?.Value;
            IEnumerable<Coding> qzzzzzzzzzzzzzzw_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(qzzzzzzzzzzzzzzv_, "coding");
            bool? qzzzzzzzzzzzzzzx_(Coding @this)
            {
                FhirString rzzzzzzzzzzzzzzr_ = @this?.DisplayElement;
                bool? rzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzr_ is null));

                return rzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Coding> qzzzzzzzzzzzzzzy_ = context.Operators.Where<Coding>(qzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzx_);
            FhirString qzzzzzzzzzzzzzzz_(Coding @this)
            {
                FhirString rzzzzzzzzzzzzzzt_ = @this?.DisplayElement;

                return rzzzzzzzzzzzzzzt_;
            };
            IEnumerable<FhirString> rzzzzzzzzzzzzzza_ = context.Operators.Select<Coding, FhirString>(qzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzz_);
            List<CodeableConcept> rzzzzzzzzzzzzzzb_ = FecalOccult?.Category;
            bool? rzzzzzzzzzzzzzzc_(CodeableConcept @this)
            {
                List<Coding> rzzzzzzzzzzzzzzu_ = @this?.Coding;
                bool? rzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzu_ is null));

                return rzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CodeableConcept> rzzzzzzzzzzzzzzd_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzc_);
            List<Coding> rzzzzzzzzzzzzzze_(CodeableConcept @this)
            {
                List<Coding> rzzzzzzzzzzzzzzw_ = @this?.Coding;

                return rzzzzzzzzzzzzzzw_;
            };
            IEnumerable<List<Coding>> rzzzzzzzzzzzzzzf_ = context.Operators.Select<CodeableConcept, List<Coding>>(rzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzze_);
            IEnumerable<Coding> rzzzzzzzzzzzzzzg_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)rzzzzzzzzzzzzzzf_);
            bool? rzzzzzzzzzzzzzzh_(Coding @this)
            {
                Code rzzzzzzzzzzzzzzx_ = @this?.CodeElement;
                bool? rzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzx_ is null));

                return rzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Coding> rzzzzzzzzzzzzzzi_ = context.Operators.Where<Coding>(rzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzh_);
            Code rzzzzzzzzzzzzzzj_(Coding @this)
            {
                Code rzzzzzzzzzzzzzzz_ = @this?.CodeElement;

                return rzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Code> rzzzzzzzzzzzzzzk_ = context.Operators.Select<Coding, Code>(rzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzj_);
            bool? rzzzzzzzzzzzzzzl_(Code @this)
            {
                string szzzzzzzzzzzzzza_ = @this?.Value;
                bool? szzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzza_ is null));

                return szzzzzzzzzzzzzzb_;
            };
            IEnumerable<Code> rzzzzzzzzzzzzzzm_ = context.Operators.Where<Code>(rzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzl_);
            string rzzzzzzzzzzzzzzn_(Code @this)
            {
                string szzzzzzzzzzzzzzc_ = @this?.Value;

                return szzzzzzzzzzzzzzc_;
            };
            IEnumerable<string> rzzzzzzzzzzzzzzo_ = context.Operators.Select<Code, string>(rzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzn_);
            Code<ObservationStatus> rzzzzzzzzzzzzzzp_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? rzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, qzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzp_);

            return rzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> qzzzzzzzzzzzzzzh_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(qzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> qzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(qzzzzzzzzzzzzzzh_);

        return qzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzd_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> szzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzzzzzzzzzzzzf_(Observation FecalOccult)
        {
            Code<ObservationStatus> szzzzzzzzzzzzzzh_ = FecalOccult?.StatusElement;
            string szzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzh_);
            string[] szzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzzzzzzk_ = context.Operators.In<string>(szzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzj_ as IEnumerable<string>);
            List<CodeableConcept> szzzzzzzzzzzzzzl_ = FecalOccult?.Category;
            bool? szzzzzzzzzzzzzzm_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> szzzzzzzzzzzzzzy_ = FecalOccultCategory?.Coding;
                bool? szzzzzzzzzzzzzzz_(Coding @this)
                {
                    Code tzzzzzzzzzzzzzzj_ = @this?.CodeElement;
                    bool? tzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzj_ is null));

                    return tzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Coding> tzzzzzzzzzzzzzza_ = context.Operators.Where<Coding>((IEnumerable<Coding>)szzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzz_);
                Code tzzzzzzzzzzzzzzb_(Coding @this)
                {
                    Code tzzzzzzzzzzzzzzl_ = @this?.CodeElement;

                    return tzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Code> tzzzzzzzzzzzzzzc_ = context.Operators.Select<Coding, Code>(tzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzb_);
                bool? tzzzzzzzzzzzzzzd_(Code @this)
                {
                    string tzzzzzzzzzzzzzzm_ = @this?.Value;
                    bool? tzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzm_ is null));

                    return tzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Code> tzzzzzzzzzzzzzze_ = context.Operators.Where<Code>(tzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzd_);
                string tzzzzzzzzzzzzzzf_(Code @this)
                {
                    string tzzzzzzzzzzzzzzo_ = @this?.Value;

                    return tzzzzzzzzzzzzzzo_;
                };
                IEnumerable<string> tzzzzzzzzzzzzzzg_ = context.Operators.Select<Code, string>(tzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzf_);
                string[] tzzzzzzzzzzzzzzh_ = [
                    "laboratory",
                ];
                bool? tzzzzzzzzzzzzzzi_ = context.Operators.Equivalent<string>(tzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzh_ as IEnumerable<string>);

                return tzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CodeableConcept> szzzzzzzzzzzzzzn_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzm_);
            bool? szzzzzzzzzzzzzzo_ = context.Operators.Exists<CodeableConcept>(szzzzzzzzzzzzzzn_);
            bool? szzzzzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzo_);
            DataType szzzzzzzzzzzzzzq_ = FecalOccult?.Value;
            bool? szzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzq_ is null));
            bool? szzzzzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzr_);
            DataType szzzzzzzzzzzzzzt_ = FecalOccult?.Effective;
            CqlDateTime szzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzv_, default);
            bool? szzzzzzzzzzzzzzx_ = context.Operators.And(szzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzw_);

            return szzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzze_, szzzzzzzzzzzzzzf_);

        return szzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzp_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> tzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? tzzzzzzzzzzzzzzr_(Observation FecalOccult)
        {
            Code<ObservationStatus> tzzzzzzzzzzzzzzt_ = FecalOccult?.StatusElement;
            string tzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzzzzt_);
            string[] tzzzzzzzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzzzzzw_ = context.Operators.In<string>(tzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            List<CodeableConcept> tzzzzzzzzzzzzzzx_ = FecalOccult?.Category;
            bool? tzzzzzzzzzzzzzzy_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> uzzzzzzzzzzzzzzk_ = FecalOccultCategory?.Coding;
                bool? uzzzzzzzzzzzzzzl_(Coding @this)
                {
                    Code uzzzzzzzzzzzzzzv_ = @this?.CodeElement;
                    bool? uzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzv_ is null));

                    return uzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Coding> uzzzzzzzzzzzzzzm_ = context.Operators.Where<Coding>((IEnumerable<Coding>)uzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzl_);
                Code uzzzzzzzzzzzzzzn_(Coding @this)
                {
                    Code uzzzzzzzzzzzzzzx_ = @this?.CodeElement;

                    return uzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Code> uzzzzzzzzzzzzzzo_ = context.Operators.Select<Coding, Code>(uzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzn_);
                bool? uzzzzzzzzzzzzzzp_(Code @this)
                {
                    string uzzzzzzzzzzzzzzy_ = @this?.Value;
                    bool? uzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzy_ is null));

                    return uzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Code> uzzzzzzzzzzzzzzq_ = context.Operators.Where<Code>(uzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzp_);
                string uzzzzzzzzzzzzzzr_(Code @this)
                {
                    string vzzzzzzzzzzzzzza_ = @this?.Value;

                    return vzzzzzzzzzzzzzza_;
                };
                IEnumerable<string> uzzzzzzzzzzzzzzs_ = context.Operators.Select<Code, string>(uzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzr_);
                string[] uzzzzzzzzzzzzzzt_ = [
                    "laboratory",
                ];
                bool? uzzzzzzzzzzzzzzu_ = context.Operators.Equivalent<string>(uzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzt_ as IEnumerable<string>);

                return uzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CodeableConcept> tzzzzzzzzzzzzzzz_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzy_);
            bool? uzzzzzzzzzzzzzza_ = context.Operators.Exists<CodeableConcept>(tzzzzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzza_);
            DataType uzzzzzzzzzzzzzzc_ = FecalOccult?.Value;
            bool? uzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzc_ is null));
            bool? uzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzd_);
            DataType uzzzzzzzzzzzzzzf_ = FecalOccult?.Effective;
            CqlDateTime uzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzh_, "day");
            bool? uzzzzzzzzzzzzzzj_ = context.Operators.And(uzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzi_);

            return uzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzr_);

        return tzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzb_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzzzzzzzzd_(Observation FecalOccult)
        {
            List<CodeableConcept> vzzzzzzzzzzzzzzf_ = FecalOccult?.Category;
            bool? vzzzzzzzzzzzzzzg_(CodeableConcept FecalOccultCategory)
            {
                List<Coding> vzzzzzzzzzzzzzzr_ = FecalOccultCategory?.Coding;
                bool? vzzzzzzzzzzzzzzs_(Coding @this)
                {
                    Code wzzzzzzzzzzzzzzd_ = @this?.CodeElement;
                    bool? wzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzd_ is null));

                    return wzzzzzzzzzzzzzze_;
                };
                IEnumerable<Coding> vzzzzzzzzzzzzzzt_ = context.Operators.Where<Coding>((IEnumerable<Coding>)vzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzs_);
                Code vzzzzzzzzzzzzzzu_(Coding @this)
                {
                    Code wzzzzzzzzzzzzzzf_ = @this?.CodeElement;

                    return wzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Code> vzzzzzzzzzzzzzzv_ = context.Operators.Select<Coding, Code>(vzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzu_);
                bool? vzzzzzzzzzzzzzzw_(Code @this)
                {
                    string wzzzzzzzzzzzzzzg_ = @this?.Value;
                    bool? wzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzg_ is null));

                    return wzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Code> vzzzzzzzzzzzzzzx_ = context.Operators.Where<Code>(vzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzw_);
                string vzzzzzzzzzzzzzzy_(Code @this)
                {
                    string wzzzzzzzzzzzzzzi_ = @this?.Value;

                    return wzzzzzzzzzzzzzzi_;
                };
                IEnumerable<string> vzzzzzzzzzzzzzzz_ = context.Operators.Select<Code, string>(vzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzy_);
                string[] wzzzzzzzzzzzzzza_ = [
                    "laboratory",
                ];
                bool? wzzzzzzzzzzzzzzb_ = context.Operators.Equivalent<string>(vzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzc_ = context.Operators.Not(wzzzzzzzzzzzzzzb_);

                return wzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CodeableConcept> vzzzzzzzzzzzzzzh_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzg_);
            bool? vzzzzzzzzzzzzzzi_ = context.Operators.Exists<CodeableConcept>(vzzzzzzzzzzzzzzh_);
            DataType vzzzzzzzzzzzzzzj_ = FecalOccult?.Value;
            bool? vzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzj_ is null));
            bool? vzzzzzzzzzzzzzzl_ = context.Operators.And(vzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzk_);
            DataType vzzzzzzzzzzzzzzm_ = FecalOccult?.Effective;
            CqlDateTime vzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzo_, "day");
            bool? vzzzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzj_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> wzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? wzzzzzzzzzzzzzzl_(Observation FecalOccult)
        {
            Code<ObservationStatus> wzzzzzzzzzzzzzzn_ = FecalOccult?.StatusElement;
            string wzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzn_);
            string[] wzzzzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzzzzzzzzzzzzzq_ = context.Operators.In<string>(wzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzr_ = context.Operators.Not(wzzzzzzzzzzzzzzq_);
            DataType wzzzzzzzzzzzzzzs_ = FecalOccult?.Value;
            bool? wzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzs_ is null));
            bool? wzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzt_);
            DataType wzzzzzzzzzzzzzzv_ = FecalOccult?.Effective;
            CqlDateTime wzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, wzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? wzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzx_, "day");
            bool? wzzzzzzzzzzzzzzz_ = context.Operators.And(wzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzy_);

            return wzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzza_ = this.FIT_DNA(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzzzzzzzzzzc_(Observation FitDNA)
        {
            DataType xzzzzzzzzzzzzzzh_ = FitDNA?.Effective;
            CqlDateTime xzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, xzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzk_ = context.Operators.End(xzzzzzzzzzzzzzzj_);
            CqlQuantity xzzzzzzzzzzzzzzl_ = context.Operators.Quantity(4m, "years");
            CqlDateTime xzzzzzzzzzzzzzzm_ = context.Operators.Subtract(xzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzl_);
            CqlDateTime xzzzzzzzzzzzzzzo_ = context.Operators.End(xzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzp_ = context.Operators.Interval(xzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzo_, true, true);
            bool? xzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzp_, default);
            CqlDateTime xzzzzzzzzzzzzzzs_ = context.Operators.End(xzzzzzzzzzzzzzzj_);
            bool? xzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzs_ is null));
            bool? xzzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzt_);

            return xzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzc_);
        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? xzzzzzzzzzzzzzze_(Observation FitDNA)
        {
            DataType xzzzzzzzzzzzzzzv_ = FitDNA?.Effective;
            CqlDateTime xzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, xzzzzzzzzzzzzzzv_);
            DataType xzzzzzzzzzzzzzzx_ = FitDNA?.Value;
            IEnumerable<Coding> xzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(xzzzzzzzzzzzzzzx_, "coding");
            bool? xzzzzzzzzzzzzzzz_(Coding @this)
            {
                FhirString yzzzzzzzzzzzzzzt_ = @this?.DisplayElement;
                bool? yzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzt_ is null));

                return yzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Coding> yzzzzzzzzzzzzzza_ = context.Operators.Where<Coding>(xzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzz_);
            FhirString yzzzzzzzzzzzzzzb_(Coding @this)
            {
                FhirString yzzzzzzzzzzzzzzv_ = @this?.DisplayElement;

                return yzzzzzzzzzzzzzzv_;
            };
            IEnumerable<FhirString> yzzzzzzzzzzzzzzc_ = context.Operators.Select<Coding, FhirString>(yzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzb_);
            List<CodeableConcept> yzzzzzzzzzzzzzzd_ = FitDNA?.Category;
            bool? yzzzzzzzzzzzzzze_(CodeableConcept @this)
            {
                List<Coding> yzzzzzzzzzzzzzzw_ = @this?.Coding;
                bool? yzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzw_ is null));

                return yzzzzzzzzzzzzzzx_;
            };
            IEnumerable<CodeableConcept> yzzzzzzzzzzzzzzf_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzze_);
            List<Coding> yzzzzzzzzzzzzzzg_(CodeableConcept @this)
            {
                List<Coding> yzzzzzzzzzzzzzzy_ = @this?.Coding;

                return yzzzzzzzzzzzzzzy_;
            };
            IEnumerable<List<Coding>> yzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, List<Coding>>(yzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzg_);
            IEnumerable<Coding> yzzzzzzzzzzzzzzi_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)yzzzzzzzzzzzzzzh_);
            bool? yzzzzzzzzzzzzzzj_(Coding @this)
            {
                Code yzzzzzzzzzzzzzzz_ = @this?.CodeElement;
                bool? zzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzz_ is null));

                return zzzzzzzzzzzzzzza_;
            };
            IEnumerable<Coding> yzzzzzzzzzzzzzzk_ = context.Operators.Where<Coding>(yzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzj_);
            Code yzzzzzzzzzzzzzzl_(Coding @this)
            {
                Code zzzzzzzzzzzzzzzb_ = @this?.CodeElement;

                return zzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Code> yzzzzzzzzzzzzzzm_ = context.Operators.Select<Coding, Code>(yzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzl_);
            bool? yzzzzzzzzzzzzzzn_(Code @this)
            {
                string zzzzzzzzzzzzzzzc_ = @this?.Value;
                bool? zzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzc_ is null));

                return zzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Code> yzzzzzzzzzzzzzzo_ = context.Operators.Where<Code>(yzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzn_);
            string yzzzzzzzzzzzzzzp_(Code @this)
            {
                string zzzzzzzzzzzzzzze_ = @this?.Value;

                return zzzzzzzzzzzzzzze_;
            };
            IEnumerable<string> yzzzzzzzzzzzzzzq_ = context.Operators.Select<Code, string>(yzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzp_);
            Code<ObservationStatus> yzzzzzzzzzzzzzzr_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? yzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, xzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzr_);

            return yzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> xzzzzzzzzzzzzzzf_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(xzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> xzzzzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(xzzzzzzzzzzzzzzf_);

        return xzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzf_ = this.FIT_DNA(context);
        IEnumerable<Observation> zzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzzzzzzzzzzh_(Observation FitDNA)
        {
            Code<ObservationStatus> zzzzzzzzzzzzzzzj_ = FitDNA?.StatusElement;
            string zzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzj_);
            string[] zzzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzzzzzzzzzzzzm_ = context.Operators.In<string>(zzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            List<CodeableConcept> zzzzzzzzzzzzzzzn_ = FitDNA?.Category;
            bool? zzzzzzzzzzzzzzzo_(CodeableConcept FitDNACategory)
            {
                List<Coding> azzzzzzzzzzzzzzzk_ = FitDNACategory?.Coding;
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
            IEnumerable<CodeableConcept> zzzzzzzzzzzzzzzp_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzo_);
            bool? zzzzzzzzzzzzzzzq_ = context.Operators.Exists<CodeableConcept>(zzzzzzzzzzzzzzzp_);
            bool? zzzzzzzzzzzzzzzr_ = context.Operators.And(zzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzq_);
            DataType zzzzzzzzzzzzzzzs_ = FitDNA?.Value;
            bool? zzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzs_ is null));
            bool? zzzzzzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzt_);
            DataType zzzzzzzzzzzzzzzv_ = FitDNA?.Effective;
            CqlDateTime zzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, zzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzy_ = context.Operators.End(zzzzzzzzzzzzzzzx_);
            CqlQuantity zzzzzzzzzzzzzzzz_ = context.Operators.Quantity(3m, "years");
            CqlDateTime azzzzzzzzzzzzzzza_ = context.Operators.Subtract(zzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzz_);
            CqlDateTime azzzzzzzzzzzzzzzc_ = context.Operators.End(zzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzd_ = context.Operators.Interval(azzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzc_, true, true);
            bool? azzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzd_, default);
            CqlDateTime azzzzzzzzzzzzzzzg_ = context.Operators.End(zzzzzzzzzzzzzzzx_);
            bool? azzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzg_ is null));
            bool? azzzzzzzzzzzzzzzi_ = context.Operators.And(azzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzh_);
            bool? azzzzzzzzzzzzzzzj_ = context.Operators.And(zzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzi_);

            return azzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzh_);

        return zzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzb_ = this.FIT_DNA(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzzzzzzzzzd_(Observation FitDNA)
        {
            Code<ObservationStatus> bzzzzzzzzzzzzzzzf_ = FitDNA?.StatusElement;
            string bzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzf_);
            string[] bzzzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            List<CodeableConcept> bzzzzzzzzzzzzzzzj_ = FitDNA?.Category;
            bool? bzzzzzzzzzzzzzzzk_(CodeableConcept FitDNACategory)
            {
                List<Coding> czzzzzzzzzzzzzzzg_ = FitDNACategory?.Coding;
                bool? czzzzzzzzzzzzzzzh_(Coding @this)
                {
                    Code czzzzzzzzzzzzzzzr_ = @this?.CodeElement;
                    bool? czzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzr_ is null));

                    return czzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Coding> czzzzzzzzzzzzzzzi_ = context.Operators.Where<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzh_);
                Code czzzzzzzzzzzzzzzj_(Coding @this)
                {
                    Code czzzzzzzzzzzzzzzt_ = @this?.CodeElement;

                    return czzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Code> czzzzzzzzzzzzzzzk_ = context.Operators.Select<Coding, Code>(czzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzl_(Code @this)
                {
                    string czzzzzzzzzzzzzzzu_ = @this?.Value;
                    bool? czzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzu_ is null));

                    return czzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Code> czzzzzzzzzzzzzzzm_ = context.Operators.Where<Code>(czzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzl_);
                string czzzzzzzzzzzzzzzn_(Code @this)
                {
                    string czzzzzzzzzzzzzzzw_ = @this?.Value;

                    return czzzzzzzzzzzzzzzw_;
                };
                IEnumerable<string> czzzzzzzzzzzzzzzo_ = context.Operators.Select<Code, string>(czzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzn_);
                string[] czzzzzzzzzzzzzzzp_ = [
                    "laboratory",
                ];
                bool? czzzzzzzzzzzzzzzq_ = context.Operators.Equivalent<string>(czzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzp_ as IEnumerable<string>);

                return czzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CodeableConcept> bzzzzzzzzzzzzzzzl_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzk_);
            bool? bzzzzzzzzzzzzzzzm_ = context.Operators.Exists<CodeableConcept>(bzzzzzzzzzzzzzzzl_);
            bool? bzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzm_);
            DataType bzzzzzzzzzzzzzzzo_ = FitDNA?.Value;
            bool? bzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzo_ is null));
            bool? bzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzp_);
            DataType bzzzzzzzzzzzzzzzr_ = FitDNA?.Effective;
            CqlDateTime bzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, bzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzu_ = context.Operators.End(bzzzzzzzzzzzzzzzt_);
            CqlQuantity bzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(3m, "years");
            CqlDateTime bzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzv_);
            CqlDateTime bzzzzzzzzzzzzzzzy_ = context.Operators.End(bzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzz_ = context.Operators.Interval(bzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzy_, true, true);
            bool? czzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzz_, "day");
            CqlDateTime czzzzzzzzzzzzzzzc_ = context.Operators.End(bzzzzzzzzzzzzzzzt_);
            bool? czzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzc_ is null));
            bool? czzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzd_);
            bool? czzzzzzzzzzzzzzzf_ = context.Operators.And(bzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzze_);

            return czzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzd_);

        return bzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzx_ = this.FIT_DNA(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzzzzzzzzzzzzzz_(Observation FitDNA)
        {
            List<CodeableConcept> dzzzzzzzzzzzzzzzb_ = FitDNA?.Category;
            bool? dzzzzzzzzzzzzzzzc_(CodeableConcept FitDNACategory)
            {
                List<Coding> dzzzzzzzzzzzzzzzx_ = FitDNACategory?.Coding;
                bool? dzzzzzzzzzzzzzzzy_(Coding @this)
                {
                    Code ezzzzzzzzzzzzzzzj_ = @this?.CodeElement;
                    bool? ezzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzj_ is null));

                    return ezzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Coding> dzzzzzzzzzzzzzzzz_ = context.Operators.Where<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzy_);
                Code ezzzzzzzzzzzzzzza_(Coding @this)
                {
                    Code ezzzzzzzzzzzzzzzl_ = @this?.CodeElement;

                    return ezzzzzzzzzzzzzzzl_;
                };
                IEnumerable<Code> ezzzzzzzzzzzzzzzb_ = context.Operators.Select<Coding, Code>(dzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzza_);
                bool? ezzzzzzzzzzzzzzzc_(Code @this)
                {
                    string ezzzzzzzzzzzzzzzm_ = @this?.Value;
                    bool? ezzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzm_ is null));

                    return ezzzzzzzzzzzzzzzn_;
                };
                IEnumerable<Code> ezzzzzzzzzzzzzzzd_ = context.Operators.Where<Code>(ezzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzc_);
                string ezzzzzzzzzzzzzzze_(Code @this)
                {
                    string ezzzzzzzzzzzzzzzo_ = @this?.Value;

                    return ezzzzzzzzzzzzzzzo_;
                };
                IEnumerable<string> ezzzzzzzzzzzzzzzf_ = context.Operators.Select<Code, string>(ezzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzze_);
                string[] ezzzzzzzzzzzzzzzg_ = [
                    "laboratory",
                ];
                bool? ezzzzzzzzzzzzzzzh_ = context.Operators.Equivalent<string>(ezzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzi_ = context.Operators.Not(ezzzzzzzzzzzzzzzh_);

                return ezzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CodeableConcept> dzzzzzzzzzzzzzzzd_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzzzzze_ = context.Operators.Exists<CodeableConcept>(dzzzzzzzzzzzzzzzd_);
            DataType dzzzzzzzzzzzzzzzf_ = FitDNA?.Value;
            bool? dzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzf_ is null));
            bool? dzzzzzzzzzzzzzzzh_ = context.Operators.And(dzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzg_);
            DataType dzzzzzzzzzzzzzzzi_ = FitDNA?.Effective;
            CqlDateTime dzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, dzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzzl_ = context.Operators.End(dzzzzzzzzzzzzzzzk_);
            CqlQuantity dzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(3m, "years");
            CqlDateTime dzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzm_);
            CqlDateTime dzzzzzzzzzzzzzzzp_ = context.Operators.End(dzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzq_ = context.Operators.Interval(dzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzp_, true, true);
            bool? dzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzq_, "day");
            CqlDateTime dzzzzzzzzzzzzzzzt_ = context.Operators.End(dzzzzzzzzzzzzzzzk_);
            bool? dzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzt_ is null));
            bool? dzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzu_);
            bool? dzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzv_);

            return dzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzp_ = this.FIT_DNA(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzzzzzzzzzzzr_(Observation FitDNA)
        {
            Code<ObservationStatus> ezzzzzzzzzzzzzzzt_ = FitDNA?.StatusElement;
            string ezzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzt_);
            string[] ezzzzzzzzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzzzzzzzzzzzzzw_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzzzx_ = context.Operators.Not(ezzzzzzzzzzzzzzzw_);
            DataType ezzzzzzzzzzzzzzzy_ = FitDNA?.Value;
            bool? ezzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzy_ is null));
            bool? fzzzzzzzzzzzzzzza_ = context.Operators.And(ezzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzz_);
            DataType fzzzzzzzzzzzzzzzb_ = FitDNA?.Effective;
            CqlDateTime fzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, fzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzze_ = context.Operators.End(fzzzzzzzzzzzzzzzd_);
            CqlQuantity fzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(3m, "years");
            CqlDateTime fzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(fzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzf_);
            CqlDateTime fzzzzzzzzzzzzzzzi_ = context.Operators.End(fzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzj_ = context.Operators.Interval(fzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzi_, true, true);
            bool? fzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzj_, "day");
            CqlDateTime fzzzzzzzzzzzzzzzm_ = context.Operators.End(fzzzzzzzzzzzzzzzd_);
            bool? fzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzm_ is null));
            bool? fzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzn_);
            bool? fzzzzzzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzo_);

            return fzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzq_ = this.CT_Colonography(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? fzzzzzzzzzzzzzzzs_(Observation Colonography)
        {
            DataType fzzzzzzzzzzzzzzzx_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzx_);
            CqlDateTime fzzzzzzzzzzzzzzzz_ = context.Operators.End(fzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzb_ = context.Operators.End(gzzzzzzzzzzzzzzza_);
            CqlQuantity gzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(6m, "years");
            CqlDateTime gzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzc_);
            CqlDateTime gzzzzzzzzzzzzzzzf_ = context.Operators.End(gzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzg_ = context.Operators.Interval(gzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzf_, true, true);
            bool? gzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzg_, default);
            CqlDateTime gzzzzzzzzzzzzzzzj_ = context.Operators.End(gzzzzzzzzzzzzzzza_);
            bool? gzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzj_ is null));
            bool? gzzzzzzzzzzzzzzzl_ = context.Operators.And(gzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzk_);

            return gzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzs_);
        CqlDateTime fzzzzzzzzzzzzzzzu_(Observation Colonography)
        {
            DataType gzzzzzzzzzzzzzzzm_ = Colonography?.Effective;
            CqlDateTime gzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, gzzzzzzzzzzzzzzzm_);

            return gzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDateTime> fzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation, CqlDateTime>(fzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDateTime> fzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDateTime>(fzzzzzzzzzzzzzzzv_);

        return fzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzo_ = this.CT_Colonography(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? gzzzzzzzzzzzzzzzq_(Observation Colonography)
        {
            Code<ObservationStatus> gzzzzzzzzzzzzzzzs_ = Colonography?.StatusElement;
            string gzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzzzs_);
            string[] gzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? gzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            DataType gzzzzzzzzzzzzzzzw_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzw_);
            CqlDateTime gzzzzzzzzzzzzzzzy_ = context.Operators.End(gzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzza_ = context.Operators.End(gzzzzzzzzzzzzzzzz_);
            CqlQuantity hzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(5m, "years");
            CqlDateTime hzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(hzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzb_);
            CqlDateTime hzzzzzzzzzzzzzzze_ = context.Operators.End(gzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzf_ = context.Operators.Interval(hzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzze_, true, true);
            bool? hzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzf_, default);
            CqlDateTime hzzzzzzzzzzzzzzzi_ = context.Operators.End(gzzzzzzzzzzzzzzzz_);
            bool? hzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzi_ is null));
            bool? hzzzzzzzzzzzzzzzk_ = context.Operators.And(hzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzj_);
            bool? hzzzzzzzzzzzzzzzl_ = context.Operators.And(gzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzk_);

            return hzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzq_);

        return gzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzm_ = this.CT_Colonography(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? hzzzzzzzzzzzzzzzo_(Observation Colonography)
        {
            Code<ObservationStatus> hzzzzzzzzzzzzzzzq_ = Colonography?.StatusElement;
            string hzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzzzq_);
            string[] hzzzzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? hzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? hzzzzzzzzzzzzzzzu_ = context.Operators.Not(hzzzzzzzzzzzzzzzt_);
            DataType hzzzzzzzzzzzzzzzv_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzv_);
            CqlDateTime hzzzzzzzzzzzzzzzx_ = context.Operators.End(hzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzz_ = context.Operators.End(hzzzzzzzzzzzzzzzy_);
            CqlQuantity izzzzzzzzzzzzzzza_ = context.Operators.Quantity(5m, "years");
            CqlDateTime izzzzzzzzzzzzzzzb_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzza_);
            CqlDateTime izzzzzzzzzzzzzzzd_ = context.Operators.End(hzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzze_ = context.Operators.Interval(izzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzd_, true, true);
            bool? izzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzze_, default);
            CqlDateTime izzzzzzzzzzzzzzzh_ = context.Operators.End(hzzzzzzzzzzzzzzzy_);
            bool? izzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzh_ is null));
            bool? izzzzzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzi_);
            bool? izzzzzzzzzzzzzzzk_ = context.Operators.And(hzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzj_);

            return izzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzl_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> izzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzzzzzzzzzzzzzzn_(Procedure FlexibleSigmoidoscopy)
        {
            DataType izzzzzzzzzzzzzzzs_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzzs_);
            CqlDateTime izzzzzzzzzzzzzzzu_ = context.Operators.End(izzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzw_ = context.Operators.End(izzzzzzzzzzzzzzzv_);
            CqlQuantity izzzzzzzzzzzzzzzx_ = context.Operators.Quantity(6m, "years");
            CqlDateTime izzzzzzzzzzzzzzzy_ = context.Operators.Subtract(izzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzx_);
            CqlDateTime jzzzzzzzzzzzzzzza_ = context.Operators.End(izzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzb_ = context.Operators.Interval(izzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzza_, true, true);
            bool? jzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzb_, default);
            CqlDateTime jzzzzzzzzzzzzzzze_ = context.Operators.End(izzzzzzzzzzzzzzzv_);
            bool? jzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzze_ is null));
            bool? jzzzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzf_);

            return jzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzn_);
        CqlDateTime izzzzzzzzzzzzzzzp_(Procedure FlexibleSigmoidoscopy)
        {
            DataType jzzzzzzzzzzzzzzzh_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime jzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, jzzzzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, CqlDateTime>(izzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDateTime>(izzzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzj_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? jzzzzzzzzzzzzzzzl_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> jzzzzzzzzzzzzzzzn_ = FlexibleSigmoidoscopy?.StatusElement;
            string jzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzzzn_);
            bool? jzzzzzzzzzzzzzzzp_ = context.Operators.Equal(jzzzzzzzzzzzzzzzo_, "completed");
            DataType jzzzzzzzzzzzzzzzq_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzq_);
            CqlDateTime jzzzzzzzzzzzzzzzs_ = context.Operators.End(jzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzu_ = context.Operators.End(jzzzzzzzzzzzzzzzt_);
            CqlQuantity jzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(5m, "years");
            CqlDateTime jzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzv_);
            CqlDateTime jzzzzzzzzzzzzzzzy_ = context.Operators.End(jzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzz_ = context.Operators.Interval(jzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzy_, true, true);
            bool? kzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzz_, default);
            CqlDateTime kzzzzzzzzzzzzzzzc_ = context.Operators.End(jzzzzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzc_ is null));
            bool? kzzzzzzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzd_);
            bool? kzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzze_);

            return kzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzl_);

        return jzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzg_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? kzzzzzzzzzzzzzzzi_(Procedure FlexibleSigmoidoscopy)
        {
            Code<EventStatus> kzzzzzzzzzzzzzzzk_ = FlexibleSigmoidoscopy?.StatusElement;
            string kzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzzzk_);
            bool? kzzzzzzzzzzzzzzzm_ = context.Operators.Equal(kzzzzzzzzzzzzzzzl_, "completed");
            bool? kzzzzzzzzzzzzzzzn_ = context.Operators.Not(kzzzzzzzzzzzzzzzm_);
            DataType kzzzzzzzzzzzzzzzo_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzo_);
            CqlDateTime kzzzzzzzzzzzzzzzq_ = context.Operators.End(kzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzs_ = context.Operators.End(kzzzzzzzzzzzzzzzr_);
            CqlQuantity kzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(5m, "years");
            CqlDateTime kzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzt_);
            CqlDateTime kzzzzzzzzzzzzzzzw_ = context.Operators.End(kzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzx_ = context.Operators.Interval(kzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzw_, true, true);
            bool? kzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzx_, default);
            CqlDateTime lzzzzzzzzzzzzzzza_ = context.Operators.End(kzzzzzzzzzzzzzzzr_);
            bool? lzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzza_ is null));
            bool? lzzzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzb_);
            bool? lzzzzzzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzc_);

            return lzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzi_);

        return kzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzze_ = this.Colonoscopy(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? lzzzzzzzzzzzzzzzg_(Procedure Colonoscopy)
        {
            DataType lzzzzzzzzzzzzzzzl_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzl_);
            CqlDateTime lzzzzzzzzzzzzzzzn_ = context.Operators.End(lzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzp_ = context.Operators.End(lzzzzzzzzzzzzzzzo_);
            CqlQuantity lzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(11m, "years");
            CqlDateTime lzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzq_);
            CqlDateTime lzzzzzzzzzzzzzzzt_ = context.Operators.End(lzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzu_ = context.Operators.Interval(lzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzt_, true, true);
            bool? lzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzu_, default);
            CqlDateTime lzzzzzzzzzzzzzzzx_ = context.Operators.End(lzzzzzzzzzzzzzzzo_);
            bool? lzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzx_ is null));
            bool? lzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzy_);

            return lzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzg_);
        CqlDateTime lzzzzzzzzzzzzzzzi_(Procedure Colonoscopy)
        {
            DataType mzzzzzzzzzzzzzzza_ = Colonoscopy?.Performed;
            CqlDateTime mzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, mzzzzzzzzzzzzzzza_);

            return mzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDateTime> lzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlDateTime>(lzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDateTime> lzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDateTime>(lzzzzzzzzzzzzzzzj_);

        return lzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzc_ = this.Colonoscopy(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? mzzzzzzzzzzzzzzze_(Procedure Colonoscopy)
        {
            Code<EventStatus> mzzzzzzzzzzzzzzzg_ = Colonoscopy?.StatusElement;
            string mzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzzg_);
            bool? mzzzzzzzzzzzzzzzi_ = context.Operators.Equal(mzzzzzzzzzzzzzzzh_, "completed");
            DataType mzzzzzzzzzzzzzzzj_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzzzzzzzzzzzzj_);
            CqlDateTime mzzzzzzzzzzzzzzzl_ = context.Operators.End(mzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzn_ = context.Operators.End(mzzzzzzzzzzzzzzzm_);
            CqlQuantity mzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(10m, "years");
            CqlDateTime mzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzo_);
            CqlDateTime mzzzzzzzzzzzzzzzr_ = context.Operators.End(mzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzs_ = context.Operators.Interval(mzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzr_, true, true);
            bool? mzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzs_, default);
            CqlDateTime mzzzzzzzzzzzzzzzv_ = context.Operators.End(mzzzzzzzzzzzzzzzm_);
            bool? mzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzv_ is null));
            bool? mzzzzzzzzzzzzzzzx_ = context.Operators.And(mzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzw_);
            bool? mzzzzzzzzzzzzzzzy_ = context.Operators.And(mzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzx_);

            return mzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzz_ = this.Colonoscopy(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? nzzzzzzzzzzzzzzzb_(Procedure Colonoscopy)
        {
            Code<EventStatus> nzzzzzzzzzzzzzzzd_ = Colonoscopy?.StatusElement;
            string nzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzzzzzd_);
            bool? nzzzzzzzzzzzzzzzf_ = context.Operators.Equal(nzzzzzzzzzzzzzzze_, "completed");
            bool? nzzzzzzzzzzzzzzzg_ = context.Operators.Not(nzzzzzzzzzzzzzzzf_);
            DataType nzzzzzzzzzzzzzzzh_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzzzzzh_);
            CqlDateTime nzzzzzzzzzzzzzzzj_ = context.Operators.End(nzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzl_ = context.Operators.End(nzzzzzzzzzzzzzzzk_);
            CqlQuantity nzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(10m, "years");
            CqlDateTime nzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzm_);
            CqlDateTime nzzzzzzzzzzzzzzzp_ = context.Operators.End(nzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzq_ = context.Operators.Interval(nzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzp_, true, true);
            bool? nzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzq_, default);
            CqlDateTime nzzzzzzzzzzzzzzzt_ = context.Operators.End(nzzzzzzzzzzzzzzzk_);
            bool? nzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzt_ is null));
            bool? nzzzzzzzzzzzzzzzv_ = context.Operators.And(nzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzu_);
            bool? nzzzzzzzzzzzzzzzw_ = context.Operators.And(nzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzv_);

            return nzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzb_);

        return nzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzx_ = this.Colonoscopy_Performed(context);
        bool? nzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(nzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzz_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? ozzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(nzzzzzzzzzzzzzzzz_);
        bool? ozzzzzzzzzzzzzzzb_ = context.Operators.Or(nzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzza_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzc_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? ozzzzzzzzzzzzzzzd_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzzc_);
        bool? ozzzzzzzzzzzzzzze_ = context.Operators.Or(ozzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzf_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? ozzzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(ozzzzzzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzzzzzh_ = context.Operators.Or(ozzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzi_ = this.CT_Colonography_Performed(context);
        bool? ozzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(ozzzzzzzzzzzzzzzi_);
        bool? ozzzzzzzzzzzzzzzk_ = context.Operators.Or(ozzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzl_ = this.Numerator(context);
        bool? ozzzzzzzzzzzzzzzm_ = this.Initial_Population(context);
        bool? ozzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzm_);
        bool? ozzzzzzzzzzzzzzzo_ = this.Denominator(context);
        bool? ozzzzzzzzzzzzzzzp_ = context.Operators.And(ozzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzzzzq_ = this.Denominator_Exclusions(context);
        bool? ozzzzzzzzzzzzzzzr_ = context.Operators.Not(ozzzzzzzzzzzzzzzq_);
        bool? ozzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzr_);

        return ozzzzzzzzzzzzzzzs_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
