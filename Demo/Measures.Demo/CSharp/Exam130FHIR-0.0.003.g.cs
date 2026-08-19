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
[CqlLibrary("Exam130FHIR", "0.0.003")]
public partial class Exam130FHIR_0_0_003 : ILibrary, ISingleton<Exam130FHIR_0_0_003>
{
    #region ValueSets (31)

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

    #region Codes (1)

    [CqlCodeDefinition("laboratory", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext _) => _laboratory;
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _laboratory]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -3168609378634258819L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime? b_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("Exam130FHIR-0.0.003", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (34)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 1213423124290806203L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding?>? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 1028246881791356135L;

    private IEnumerable<Coding?>? SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding?>? a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept? code, Period? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -3823562072778270125L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept? code, Period? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept? code, Period? period)?>? a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding?>? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 1660156871780566550L;

    private IEnumerable<Coding?>? SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding?>? a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -8505013189971448644L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter?>? Telehealth_Services(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Telehealth_Services, Telehealth_Services_Compute);

    private const long _cacheIndex_Telehealth_Services = 243407520683800174L;

    private IEnumerable<Encounter?>? Telehealth_Services_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Online_Assessments(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet? c_ = this.Telephone_Visits(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);

        bool? f_(Encounter? TelehealthEncounter) {
            Code<Encounter.EncounterStatus>? h_ = TelehealthEncounter?.StatusElement;
            string? i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "finished");
            CqlInterval<CqlDateTime?>? k_ = this.Measurement_Period(context);
            Period? l_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime?>? m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, l_);
            bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(k_, m_, (string?)default);
            bool? o_ = context.Operators.And(j_, n_);
            return o_;
        }

        IEnumerable<Encounter?>? g_ = context.Operators.Where<Encounter?>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Age_at_start_of_Measurement_Period, Age_at_start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Age_at_start_of_Measurement_Period = -3320262102028798373L;

    private int? Age_at_start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        return h_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 4265562303084665701L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?>? i_ = context.Operators.Interval(51, 75, true, false);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string?)default);
        IEnumerable<Encounter?>? k_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter?>? l_ = this.Telehealth_Services(context);
        IEnumerable<Encounter?>? m_ = context.Operators.Union<Encounter?>(k_, l_);
        bool? n_ = context.Operators.Exists<Encounter?>(m_);
        bool? o_ = context.Operators.And(j_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -1790896683345162469L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition?>? Malignant_Neoplasm(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Malignant_Neoplasm, Malignant_Neoplasm_Compute);

    private const long _cacheIndex_Malignant_Neoplasm = 8881159597199601056L;

    private IEnumerable<Condition?>? Malignant_Neoplasm_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition? ColorectalCancer) {
            CqlInterval<CqlDateTime?>? e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime? f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime?>? g_ = this.Measurement_Period(context);
            CqlDateTime? h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, (string?)default);
            return i_;
        }

        IEnumerable<Condition?>? d_ = context.Operators.Where<Condition?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure?>? Total_Colectomy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Total_Colectomy_Performed, Total_Colectomy_Performed_Compute);

    private const long _cacheIndex_Total_Colectomy_Performed = 2195736060216732591L;

    private IEnumerable<Procedure?>? Total_Colectomy_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Total_Colectomy(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure? Colectomy) {
            Code<EventStatus>? e_ = Colectomy?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            DataType? h_ = Colectomy?.Performed;
            CqlInterval<CqlDateTime?>? i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
            CqlDateTime? j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime?>? k_ = this.Measurement_Period(context);
            CqlDateTime? l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, (string?)default);
            bool? n_ = context.Operators.And(g_, m_);
            return n_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition?>? Total_Colectomy_Condition(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Total_Colectomy_Condition, Total_Colectomy_Condition_Compute);

    private const long _cacheIndex_Total_Colectomy_Condition = 717875751356203254L;

    private IEnumerable<Condition?>? Total_Colectomy_Condition_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition? ColectomyDx) {
            CqlInterval<CqlDateTime?>? e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime? f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime?>? g_ = this.Measurement_Period(context);
            CqlDateTime? h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, (string?)default);
            return i_;
        }

        IEnumerable<Condition?>? d_ = context.Operators.Where<Condition?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 1750655174842416784L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition?>? b_ = this.Malignant_Neoplasm(context);
        bool? c_ = context.Operators.Exists<Condition?>(b_);
        bool? d_ = context.Operators.Or(a_, c_);
        IEnumerable<Procedure?>? e_ = this.Total_Colectomy_Performed(context);
        bool? f_ = context.Operators.Exists<Procedure?>(e_);
        bool? g_ = context.Operators.Or(d_, f_);
        IEnumerable<Condition?>? h_ = this.Total_Colectomy_Condition(context);
        bool? i_ = context.Operators.Exists<Condition?>(h_);
        bool? j_ = context.Operators.Or(g_, i_);
        bool? k_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? l_ = context.Operators.Or(j_, k_);
        Patient? m_ = this.Patient(context);
        Date? n_ = m_?.BirthDateElement;
        string? o_ = n_?.Value;
        CqlDate? p_ = context.Operators.ConvertStringToDate(o_);
        CqlInterval<CqlDateTime?>? q_ = this.Measurement_Period(context);
        CqlDateTime? r_ = context.Operators.Start(q_);
        CqlDate? s_ = context.Operators.DateFrom(r_);
        int? t_ = context.Operators.CalculateAgeAt(p_, s_, "year");
        bool? u_ = context.Operators.GreaterOrEqual(t_, 65);
        bool? v_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? w_ = context.Operators.And(u_, v_);
        bool? x_ = context.Operators.Or(l_, w_);
        bool? y_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? z_ = context.Operators.Or(x_, y_);
        return z_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>? Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status, Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status = 5413131631176147754L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>? Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FecalOccult) {
            DataType? g_ = FecalOccult?.Effective;
            CqlDateTime? h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, g_);
            CqlInterval<CqlDateTime?>? i_ = this.Measurement_Period(context);
            CqlDateTime? j_ = context.Operators.Start(i_);
            CqlQuantity? k_ = context.Operators.Quantity(1m, "year");
            CqlDateTime? l_ = context.Operators.Subtract(j_, k_);
            CqlDateTime? m_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(l_, m_, false, false);
            bool? o_ = context.Operators.In<CqlDateTime?>(h_, n_, (string?)default);
            return o_;
        }


        (CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)? d_(Observation? FecalOccult) {
            DataType? p_ = FecalOccult?.Effective;
            CqlDateTime? q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, p_);
            DataType? r_ = FecalOccult?.Value;
            IEnumerable<Coding?>? s_ = context.Operators.LateBoundProperty<IEnumerable<Coding?>?>(r_, "coding");

            bool? t_(Coding? @this) {
                FhirString? aj_ = @this?.DisplayElement;
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                return ak_;
            }


            FhirString? u_(Coding? @this) {
                FhirString? al_ = @this?.DisplayElement;
                return al_;
            }

            IEnumerable<FhirString?>? v_ = context.Operators.WhereSelect<Coding?, FhirString?>(s_, t_, u_);
            List<CodeableConcept>? w_ = FecalOccult?.Category;

            bool? x_(CodeableConcept? @this) {
                List<Coding>? am_ = @this?.Coding;
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                return an_;
            }


            List<Coding?>? y_(CodeableConcept? @this) {
                List<Coding>? ao_ = @this?.Coding;
                return ao_;
            }

            IEnumerable<List<Coding?>?>? z_ = context.Operators.WhereSelect<CodeableConcept?, List<Coding?>?>((IEnumerable<CodeableConcept?>?)w_, x_, y_);
            IEnumerable<Coding?>? aa_ = context.Operators.Flatten<Coding?>((IEnumerable<IEnumerable<Coding?>?>?)z_);

            bool? ab_(Coding? @this) {
                Code? ap_ = @this?.CodeElement;
                bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
                return aq_;
            }


            Code? ac_(Coding? @this) {
                Code? ar_ = @this?.CodeElement;
                return ar_;
            }

            IEnumerable<Code?>? ad_ = context.Operators.WhereSelect<Coding?, Code?>(aa_, ab_, ac_);

            bool? ae_(Code? @this) {
                string? as_ = @this?.Value;
                bool? at_ = context.Operators.Not((bool?)(as_ is null));
                return at_;
            }


            string? af_(Code? @this) {
                string? au_ = @this?.Value;
                return au_;
            }

            IEnumerable<string?>? ag_ = context.Operators.WhereSelect<Code?, string?>(ad_, ae_, af_);
            Code<ObservationStatus>? ah_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)? ai_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, q_, v_, ag_, ah_);
            return ai_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>? e_ = context.Operators.WhereSelect<Observation?, (CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>(b_, c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>? f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation?>? Fecal_Occult_Blood_Test_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed, Fecal_Occult_Blood_Test_Performed_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed = 7844896067574964922L;

    private IEnumerable<Observation?>? Fecal_Occult_Blood_Test_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FecalOccult) {
            Code<ObservationStatus>? e_ = FecalOccult?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string?[]? g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string?>(f_, (IEnumerable<string?>?)g_);
            List<CodeableConcept>? i_ = FecalOccult?.Category;

            bool? j_(CodeableConcept? FecalOccultCategory) {
                List<Coding>? u_ = FecalOccultCategory?.Coding;

                bool? v_(Coding? @this) {
                    Code? ad_ = @this?.CodeElement;
                    bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                    return ae_;
                }


                Code? w_(Coding? @this) {
                    Code? af_ = @this?.CodeElement;
                    return af_;
                }

                IEnumerable<Code?>? x_ = context.Operators.WhereSelect<Coding?, Code?>((IEnumerable<Coding?>?)u_, v_, w_);

                bool? y_(Code? @this) {
                    string? ag_ = @this?.Value;
                    bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                    return ah_;
                }


                string? z_(Code? @this) {
                    string? ai_ = @this?.Value;
                    return ai_;
                }

                IEnumerable<string?>? aa_ = context.Operators.WhereSelect<Code?, string?>(x_, y_, z_);
                string?[]? ab_ = [
                    "laboratory",
                ];
                bool? ac_ = context.Operators.Equivalent<string?>(aa_, (IEnumerable<string?>?)ab_);
                return ac_;
            }

            bool? k_ = context.Operators.WhereAny<CodeableConcept?>((IEnumerable<CodeableConcept?>?)i_, j_);
            bool? l_ = context.Operators.And(h_, k_);
            DataType? m_ = FecalOccult?.Value;
            bool? n_ = context.Operators.Not((bool?)(m_ is null));
            bool? o_ = context.Operators.And(l_, n_);
            DataType? p_ = FecalOccult?.Effective;
            CqlDateTime? q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, p_);
            CqlInterval<CqlDateTime?>? r_ = this.Measurement_Period(context);
            bool? s_ = context.Operators.In<CqlDateTime?>(q_, r_, (string?)default);
            bool? t_ = context.Operators.And(o_, s_);
            return t_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation?>? Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed__day_of_TZoffset, Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed__day_of_TZoffset = 6696844624432456612L;

    private IEnumerable<Observation?>? Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FecalOccult) {
            Code<ObservationStatus>? e_ = FecalOccult?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string?[]? g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string?>(f_, (IEnumerable<string?>?)g_);
            List<CodeableConcept>? i_ = FecalOccult?.Category;

            bool? j_(CodeableConcept? FecalOccultCategory) {
                List<Coding>? u_ = FecalOccultCategory?.Coding;

                bool? v_(Coding? @this) {
                    Code? ad_ = @this?.CodeElement;
                    bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                    return ae_;
                }


                Code? w_(Coding? @this) {
                    Code? af_ = @this?.CodeElement;
                    return af_;
                }

                IEnumerable<Code?>? x_ = context.Operators.WhereSelect<Coding?, Code?>((IEnumerable<Coding?>?)u_, v_, w_);

                bool? y_(Code? @this) {
                    string? ag_ = @this?.Value;
                    bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                    return ah_;
                }


                string? z_(Code? @this) {
                    string? ai_ = @this?.Value;
                    return ai_;
                }

                IEnumerable<string?>? aa_ = context.Operators.WhereSelect<Code?, string?>(x_, y_, z_);
                string?[]? ab_ = [
                    "laboratory",
                ];
                bool? ac_ = context.Operators.Equivalent<string?>(aa_, (IEnumerable<string?>?)ab_);
                return ac_;
            }

            bool? k_ = context.Operators.WhereAny<CodeableConcept?>((IEnumerable<CodeableConcept?>?)i_, j_);
            bool? l_ = context.Operators.And(h_, k_);
            DataType? m_ = FecalOccult?.Value;
            bool? n_ = context.Operators.Not((bool?)(m_ is null));
            bool? o_ = context.Operators.And(l_, n_);
            DataType? p_ = FecalOccult?.Effective;
            CqlDateTime? q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, p_);
            CqlInterval<CqlDateTime?>? r_ = this.Measurement_Period(context);
            bool? s_ = context.Operators.In<CqlDateTime?>(q_, r_, "day");
            bool? t_ = context.Operators.And(o_, s_);
            return t_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation?>? Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset, Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset = 656347897891475055L;

    private IEnumerable<Observation?>? Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FecalOccult) {
            List<CodeableConcept>? e_ = FecalOccult?.Category;

            bool? f_(CodeableConcept? FecalOccultCategory) {
                List<Coding>? p_ = FecalOccultCategory?.Coding;

                bool? q_(Coding? @this) {
                    Code? z_ = @this?.CodeElement;
                    bool? aa_ = context.Operators.Not((bool?)(z_ is null));
                    return aa_;
                }


                Code? r_(Coding? @this) {
                    Code? ab_ = @this?.CodeElement;
                    return ab_;
                }

                IEnumerable<Code?>? s_ = context.Operators.WhereSelect<Coding?, Code?>((IEnumerable<Coding?>?)p_, q_, r_);

                bool? t_(Code? @this) {
                    string? ac_ = @this?.Value;
                    bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                    return ad_;
                }


                string? u_(Code? @this) {
                    string? ae_ = @this?.Value;
                    return ae_;
                }

                IEnumerable<string?>? v_ = context.Operators.WhereSelect<Code?, string?>(s_, t_, u_);
                string?[]? w_ = [
                    "laboratory",
                ];
                bool? x_ = context.Operators.Equivalent<string?>(v_, (IEnumerable<string?>?)w_);
                bool? y_ = context.Operators.Not(x_);
                return y_;
            }

            bool? g_ = context.Operators.WhereAny<CodeableConcept?>((IEnumerable<CodeableConcept?>?)e_, f_);
            DataType? h_ = FecalOccult?.Value;
            bool? i_ = context.Operators.Not((bool?)(h_ is null));
            bool? j_ = context.Operators.And(g_, i_);
            DataType? k_ = FecalOccult?.Effective;
            CqlDateTime? l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, k_);
            CqlInterval<CqlDateTime?>? m_ = this.Measurement_Period(context);
            bool? n_ = context.Operators.In<CqlDateTime?>(l_, m_, "day");
            bool? o_ = context.Operators.And(j_, n_);
            return o_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation?>? Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset, Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset = 4900355884558937485L;

    private IEnumerable<Observation?>? Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FecalOccult) {
            Code<ObservationStatus>? e_ = FecalOccult?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string?[]? g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string?>(f_, (IEnumerable<string?>?)g_);
            bool? i_ = context.Operators.Not(h_);
            DataType? j_ = FecalOccult?.Value;
            bool? k_ = context.Operators.Not((bool?)(j_ is null));
            bool? l_ = context.Operators.And(i_, k_);
            DataType? m_ = FecalOccult?.Effective;
            CqlDateTime? n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, m_);
            CqlInterval<CqlDateTime?>? o_ = this.Measurement_Period(context);
            bool? p_ = context.Operators.In<CqlDateTime?>(n_, o_, "day");
            bool? q_ = context.Operators.And(l_, p_);
            return q_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>? Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status, Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status = -4988988012396499234L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>? Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.FIT_DNA(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FitDNA) {
            DataType? g_ = FitDNA?.Effective;
            CqlDateTime? h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, g_);
            CqlInterval<CqlDateTime?>? i_ = this.Measurement_Period(context);
            CqlDateTime? j_ = context.Operators.End(i_);
            CqlQuantity? k_ = context.Operators.Quantity(4m, "years");
            CqlDateTime? l_ = context.Operators.Subtract(j_, k_);
            CqlInterval<CqlDateTime?>? m_ = context.Operators.Interval(l_, j_, true, true);
            bool? n_ = context.Operators.In<CqlDateTime?>(h_, m_, (string?)default);
            bool? o_ = context.Operators.Not((bool?)(j_ is null));
            bool? p_ = context.Operators.And(n_, o_);
            return p_;
        }


        (CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)? d_(Observation? FitDNA) {
            DataType? q_ = FitDNA?.Effective;
            CqlDateTime? r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, q_);
            DataType? s_ = FitDNA?.Value;
            IEnumerable<Coding?>? t_ = context.Operators.LateBoundProperty<IEnumerable<Coding?>?>(s_, "coding");

            bool? u_(Coding? @this) {
                FhirString? ak_ = @this?.DisplayElement;
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                return al_;
            }


            FhirString? v_(Coding? @this) {
                FhirString? am_ = @this?.DisplayElement;
                return am_;
            }

            IEnumerable<FhirString?>? w_ = context.Operators.WhereSelect<Coding?, FhirString?>(t_, u_, v_);
            List<CodeableConcept>? x_ = FitDNA?.Category;

            bool? y_(CodeableConcept? @this) {
                List<Coding>? an_ = @this?.Coding;
                bool? ao_ = context.Operators.Not((bool?)(an_ is null));
                return ao_;
            }


            List<Coding?>? z_(CodeableConcept? @this) {
                List<Coding>? ap_ = @this?.Coding;
                return ap_;
            }

            IEnumerable<List<Coding?>?>? aa_ = context.Operators.WhereSelect<CodeableConcept?, List<Coding?>?>((IEnumerable<CodeableConcept?>?)x_, y_, z_);
            IEnumerable<Coding?>? ab_ = context.Operators.Flatten<Coding?>((IEnumerable<IEnumerable<Coding?>?>?)aa_);

            bool? ac_(Coding? @this) {
                Code? aq_ = @this?.CodeElement;
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                return ar_;
            }


            Code? ad_(Coding? @this) {
                Code? as_ = @this?.CodeElement;
                return as_;
            }

            IEnumerable<Code?>? ae_ = context.Operators.WhereSelect<Coding?, Code?>(ab_, ac_, ad_);

            bool? af_(Code? @this) {
                string? at_ = @this?.Value;
                bool? au_ = context.Operators.Not((bool?)(at_ is null));
                return au_;
            }


            string? ag_(Code? @this) {
                string? av_ = @this?.Value;
                return av_;
            }

            IEnumerable<string?>? ah_ = context.Operators.WhereSelect<Code?, string?>(ae_, af_, ag_);
            Code<ObservationStatus>? ai_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)? aj_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, r_, w_, ah_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>? e_ = context.Operators.WhereSelect<Observation?, (CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>(b_, c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>? f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime? occultDate, IEnumerable<FhirString?>? occultResult, IEnumerable<string?>? occultCategoryCode, Code<ObservationStatus>? occultStatus)?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation?>? Fecal_Immunochemical_Test_DNA_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Performed, Fecal_Immunochemical_Test_DNA_Performed_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Performed = -6863072270951567862L;

    private IEnumerable<Observation?>? Fecal_Immunochemical_Test_DNA_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.FIT_DNA(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FitDNA) {
            Code<ObservationStatus>? e_ = FitDNA?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string?[]? g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string?>(f_, (IEnumerable<string?>?)g_);
            List<CodeableConcept>? i_ = FitDNA?.Category;

            bool? j_(CodeableConcept? FitDNACategory) {
                List<Coding>? aa_ = FitDNACategory?.Coding;

                bool? ab_(Coding? @this) {
                    Code? aj_ = @this?.CodeElement;
                    bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                    return ak_;
                }


                Code? ac_(Coding? @this) {
                    Code? al_ = @this?.CodeElement;
                    return al_;
                }

                IEnumerable<Code?>? ad_ = context.Operators.WhereSelect<Coding?, Code?>((IEnumerable<Coding?>?)aa_, ab_, ac_);

                bool? ae_(Code? @this) {
                    string? am_ = @this?.Value;
                    bool? an_ = context.Operators.Not((bool?)(am_ is null));
                    return an_;
                }


                string? af_(Code? @this) {
                    string? ao_ = @this?.Value;
                    return ao_;
                }

                IEnumerable<string?>? ag_ = context.Operators.WhereSelect<Code?, string?>(ad_, ae_, af_);
                string?[]? ah_ = [
                    "laboratory",
                ];
                bool? ai_ = context.Operators.Equivalent<string?>(ag_, (IEnumerable<string?>?)ah_);
                return ai_;
            }

            bool? k_ = context.Operators.WhereAny<CodeableConcept?>((IEnumerable<CodeableConcept?>?)i_, j_);
            bool? l_ = context.Operators.And(h_, k_);
            DataType? m_ = FitDNA?.Value;
            bool? n_ = context.Operators.Not((bool?)(m_ is null));
            bool? o_ = context.Operators.And(l_, n_);
            DataType? p_ = FitDNA?.Effective;
            CqlDateTime? q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, p_);
            CqlInterval<CqlDateTime?>? r_ = this.Measurement_Period(context);
            CqlDateTime? s_ = context.Operators.End(r_);
            CqlQuantity? t_ = context.Operators.Quantity(3m, "years");
            CqlDateTime? u_ = context.Operators.Subtract(s_, t_);
            CqlInterval<CqlDateTime?>? v_ = context.Operators.Interval(u_, s_, true, true);
            bool? w_ = context.Operators.In<CqlDateTime?>(q_, v_, (string?)default);
            bool? x_ = context.Operators.Not((bool?)(s_ is null));
            bool? y_ = context.Operators.And(w_, x_);
            bool? z_ = context.Operators.And(o_, y_);
            return z_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation?>? Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset, Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset = 9199119243223914922L;

    private IEnumerable<Observation?>? Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.FIT_DNA(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FitDNA) {
            Code<ObservationStatus>? e_ = FitDNA?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string?[]? g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string?>(f_, (IEnumerable<string?>?)g_);
            List<CodeableConcept>? i_ = FitDNA?.Category;

            bool? j_(CodeableConcept? FitDNACategory) {
                List<Coding>? aa_ = FitDNACategory?.Coding;

                bool? ab_(Coding? @this) {
                    Code? aj_ = @this?.CodeElement;
                    bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                    return ak_;
                }


                Code? ac_(Coding? @this) {
                    Code? al_ = @this?.CodeElement;
                    return al_;
                }

                IEnumerable<Code?>? ad_ = context.Operators.WhereSelect<Coding?, Code?>((IEnumerable<Coding?>?)aa_, ab_, ac_);

                bool? ae_(Code? @this) {
                    string? am_ = @this?.Value;
                    bool? an_ = context.Operators.Not((bool?)(am_ is null));
                    return an_;
                }


                string? af_(Code? @this) {
                    string? ao_ = @this?.Value;
                    return ao_;
                }

                IEnumerable<string?>? ag_ = context.Operators.WhereSelect<Code?, string?>(ad_, ae_, af_);
                string?[]? ah_ = [
                    "laboratory",
                ];
                bool? ai_ = context.Operators.Equivalent<string?>(ag_, (IEnumerable<string?>?)ah_);
                return ai_;
            }

            bool? k_ = context.Operators.WhereAny<CodeableConcept?>((IEnumerable<CodeableConcept?>?)i_, j_);
            bool? l_ = context.Operators.And(h_, k_);
            DataType? m_ = FitDNA?.Value;
            bool? n_ = context.Operators.Not((bool?)(m_ is null));
            bool? o_ = context.Operators.And(l_, n_);
            DataType? p_ = FitDNA?.Effective;
            CqlDateTime? q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, p_);
            CqlInterval<CqlDateTime?>? r_ = this.Measurement_Period(context);
            CqlDateTime? s_ = context.Operators.End(r_);
            CqlQuantity? t_ = context.Operators.Quantity(3m, "years");
            CqlDateTime? u_ = context.Operators.Subtract(s_, t_);
            CqlInterval<CqlDateTime?>? v_ = context.Operators.Interval(u_, s_, true, true);
            bool? w_ = context.Operators.In<CqlDateTime?>(q_, v_, "day");
            bool? x_ = context.Operators.Not((bool?)(s_ is null));
            bool? y_ = context.Operators.And(w_, x_);
            bool? z_ = context.Operators.And(o_, y_);
            return z_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation?>? Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset, Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset = 8657039245717172751L;

    private IEnumerable<Observation?>? Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.FIT_DNA(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FitDNA) {
            List<CodeableConcept>? e_ = FitDNA?.Category;

            bool? f_(CodeableConcept? FitDNACategory) {
                List<Coding>? v_ = FitDNACategory?.Coding;

                bool? w_(Coding? @this) {
                    Code? af_ = @this?.CodeElement;
                    bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                    return ag_;
                }


                Code? x_(Coding? @this) {
                    Code? ah_ = @this?.CodeElement;
                    return ah_;
                }

                IEnumerable<Code?>? y_ = context.Operators.WhereSelect<Coding?, Code?>((IEnumerable<Coding?>?)v_, w_, x_);

                bool? z_(Code? @this) {
                    string? ai_ = @this?.Value;
                    bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                    return aj_;
                }


                string? aa_(Code? @this) {
                    string? ak_ = @this?.Value;
                    return ak_;
                }

                IEnumerable<string?>? ab_ = context.Operators.WhereSelect<Code?, string?>(y_, z_, aa_);
                string?[]? ac_ = [
                    "laboratory",
                ];
                bool? ad_ = context.Operators.Equivalent<string?>(ab_, (IEnumerable<string?>?)ac_);
                bool? ae_ = context.Operators.Not(ad_);
                return ae_;
            }

            bool? g_ = context.Operators.WhereAny<CodeableConcept?>((IEnumerable<CodeableConcept?>?)e_, f_);
            DataType? h_ = FitDNA?.Value;
            bool? i_ = context.Operators.Not((bool?)(h_ is null));
            bool? j_ = context.Operators.And(g_, i_);
            DataType? k_ = FitDNA?.Effective;
            CqlDateTime? l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, k_);
            CqlInterval<CqlDateTime?>? m_ = this.Measurement_Period(context);
            CqlDateTime? n_ = context.Operators.End(m_);
            CqlQuantity? o_ = context.Operators.Quantity(3m, "years");
            CqlDateTime? p_ = context.Operators.Subtract(n_, o_);
            CqlInterval<CqlDateTime?>? q_ = context.Operators.Interval(p_, n_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime?>(l_, q_, "day");
            bool? s_ = context.Operators.Not((bool?)(n_ is null));
            bool? t_ = context.Operators.And(r_, s_);
            bool? u_ = context.Operators.And(j_, t_);
            return u_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation?>? Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset, Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset = 1767526640596192838L;

    private IEnumerable<Observation?>? Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.FIT_DNA(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? FitDNA) {
            Code<ObservationStatus>? e_ = FitDNA?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string?[]? g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string?>(f_, (IEnumerable<string?>?)g_);
            bool? i_ = context.Operators.Not(h_);
            DataType? j_ = FitDNA?.Value;
            bool? k_ = context.Operators.Not((bool?)(j_ is null));
            bool? l_ = context.Operators.And(i_, k_);
            DataType? m_ = FitDNA?.Effective;
            CqlDateTime? n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, m_);
            CqlInterval<CqlDateTime?>? o_ = this.Measurement_Period(context);
            CqlDateTime? p_ = context.Operators.End(o_);
            CqlQuantity? q_ = context.Operators.Quantity(3m, "years");
            CqlDateTime? r_ = context.Operators.Subtract(p_, q_);
            CqlInterval<CqlDateTime?>? s_ = context.Operators.Interval(r_, p_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime?>(n_, s_, "day");
            bool? u_ = context.Operators.Not((bool?)(p_ is null));
            bool? v_ = context.Operators.And(t_, u_);
            bool? w_ = context.Operators.And(l_, v_);
            return w_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime?>? CT_Colonography_Display_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_CT_Colonography_Display_Date, CT_Colonography_Display_Date_Compute);

    private const long _cacheIndex_CT_Colonography_Display_Date = 6863243112812976215L;

    private IEnumerable<CqlDateTime?>? CT_Colonography_Display_Date_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.CT_Colonography(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? Colonography) {
            DataType? g_ = Colonography?.Effective;
            CqlInterval<CqlDateTime?>? h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, g_);
            CqlDateTime? i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime?>? j_ = this.Measurement_Period(context);
            CqlDateTime? k_ = context.Operators.End(j_);
            CqlQuantity? l_ = context.Operators.Quantity(6m, "years");
            CqlDateTime? m_ = context.Operators.Subtract(k_, l_);
            CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(m_, k_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime?>(i_, n_, (string?)default);
            bool? p_ = context.Operators.Not((bool?)(k_ is null));
            bool? q_ = context.Operators.And(o_, p_);
            return q_;
        }


        CqlDateTime? d_(Observation? Colonography) {
            DataType? r_ = Colonography?.Effective;
            CqlDateTime? s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
            return s_;
        }

        IEnumerable<CqlDateTime?>? e_ = context.Operators.WhereSelect<Observation?, CqlDateTime?>(b_, c_, d_);
        IEnumerable<CqlDateTime?>? f_ = context.Operators.Distinct<CqlDateTime?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation?>? CT_Colonography_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_CT_Colonography_Performed, CT_Colonography_Performed_Compute);

    private const long _cacheIndex_CT_Colonography_Performed = -2685639117058262550L;

    private IEnumerable<Observation?>? CT_Colonography_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.CT_Colonography(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? Colonography) {
            Code<ObservationStatus>? e_ = Colonography?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string?[]? g_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? h_ = context.Operators.In<string?>(f_, (IEnumerable<string?>?)g_);
            DataType? i_ = Colonography?.Effective;
            CqlInterval<CqlDateTime?>? j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
            CqlDateTime? k_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime?>? l_ = this.Measurement_Period(context);
            CqlDateTime? m_ = context.Operators.End(l_);
            CqlQuantity? n_ = context.Operators.Quantity(5m, "years");
            CqlDateTime? o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(o_, m_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime?>(k_, p_, (string?)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            bool? t_ = context.Operators.And(h_, s_);
            return t_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation?>? CT_Colonography_Performed_without_appropriate_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_CT_Colonography_Performed_without_appropriate_status, CT_Colonography_Performed_without_appropriate_status_Compute);

    private const long _cacheIndex_CT_Colonography_Performed_without_appropriate_status = -3946986107674637045L;

    private IEnumerable<Observation?>? CT_Colonography_Performed_without_appropriate_status_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.CT_Colonography(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation? Colonography) {
            Code<ObservationStatus>? e_ = Colonography?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string?[]? g_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? h_ = context.Operators.In<string?>(f_, (IEnumerable<string?>?)g_);
            bool? i_ = context.Operators.Not(h_);
            DataType? j_ = Colonography?.Effective;
            CqlInterval<CqlDateTime?>? k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, j_);
            CqlDateTime? l_ = context.Operators.End(k_);
            CqlInterval<CqlDateTime?>? m_ = this.Measurement_Period(context);
            CqlDateTime? n_ = context.Operators.End(m_);
            CqlQuantity? o_ = context.Operators.Quantity(5m, "years");
            CqlDateTime? p_ = context.Operators.Subtract(n_, o_);
            CqlInterval<CqlDateTime?>? q_ = context.Operators.Interval(p_, n_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime?>(l_, q_, (string?)default);
            bool? s_ = context.Operators.Not((bool?)(n_ is null));
            bool? t_ = context.Operators.And(r_, s_);
            bool? u_ = context.Operators.And(i_, t_);
            return u_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime?>? Flexible_Sigmoidoscopy_Display_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Flexible_Sigmoidoscopy_Display_Date, Flexible_Sigmoidoscopy_Display_Date_Compute);

    private const long _cacheIndex_Flexible_Sigmoidoscopy_Display_Date = 7380959495112763078L;

    private IEnumerable<CqlDateTime?>? Flexible_Sigmoidoscopy_Display_Date_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure? FlexibleSigmoidoscopy) {
            DataType? g_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime?>? h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, g_);
            CqlDateTime? i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime?>? j_ = this.Measurement_Period(context);
            CqlDateTime? k_ = context.Operators.End(j_);
            CqlQuantity? l_ = context.Operators.Quantity(6m, "years");
            CqlDateTime? m_ = context.Operators.Subtract(k_, l_);
            CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(m_, k_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime?>(i_, n_, (string?)default);
            bool? p_ = context.Operators.Not((bool?)(k_ is null));
            bool? q_ = context.Operators.And(o_, p_);
            return q_;
        }


        CqlDateTime? d_(Procedure? FlexibleSigmoidoscopy) {
            DataType? r_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime? s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
            return s_;
        }

        IEnumerable<CqlDateTime?>? e_ = context.Operators.WhereSelect<Procedure?, CqlDateTime?>(b_, c_, d_);
        IEnumerable<CqlDateTime?>? f_ = context.Operators.Distinct<CqlDateTime?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure?>? Flexible_Sigmoidoscopy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Flexible_Sigmoidoscopy_Performed, Flexible_Sigmoidoscopy_Performed_Compute);

    private const long _cacheIndex_Flexible_Sigmoidoscopy_Performed = 7397457012187903040L;

    private IEnumerable<Procedure?>? Flexible_Sigmoidoscopy_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure? FlexibleSigmoidoscopy) {
            Code<EventStatus>? e_ = FlexibleSigmoidoscopy?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            DataType? h_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime?>? i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
            CqlDateTime? j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime?>? k_ = this.Measurement_Period(context);
            CqlDateTime? l_ = context.Operators.End(k_);
            CqlQuantity? m_ = context.Operators.Quantity(5m, "years");
            CqlDateTime? n_ = context.Operators.Subtract(l_, m_);
            CqlInterval<CqlDateTime?>? o_ = context.Operators.Interval(n_, l_, true, true);
            bool? p_ = context.Operators.In<CqlDateTime?>(j_, o_, (string?)default);
            bool? q_ = context.Operators.Not((bool?)(l_ is null));
            bool? r_ = context.Operators.And(p_, q_);
            bool? s_ = context.Operators.And(g_, r_);
            return s_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure?>? Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Flexible_Sigmoidoscopy_Performed_without_appropriate_status, Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Compute);

    private const long _cacheIndex_Flexible_Sigmoidoscopy_Performed_without_appropriate_status = -861024222490189513L;

    private IEnumerable<Procedure?>? Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure? FlexibleSigmoidoscopy) {
            Code<EventStatus>? e_ = FlexibleSigmoidoscopy?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            bool? h_ = context.Operators.Not(g_);
            DataType? i_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime?>? j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
            CqlDateTime? k_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime?>? l_ = this.Measurement_Period(context);
            CqlDateTime? m_ = context.Operators.End(l_);
            CqlQuantity? n_ = context.Operators.Quantity(5m, "years");
            CqlDateTime? o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(o_, m_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime?>(k_, p_, (string?)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            bool? t_ = context.Operators.And(h_, s_);
            return t_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime?>? Colonoscopy_Display_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Colonoscopy_Display_Date, Colonoscopy_Display_Date_Compute);

    private const long _cacheIndex_Colonoscopy_Display_Date = 6826331217669629588L;

    private IEnumerable<CqlDateTime?>? Colonoscopy_Display_Date_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Colonoscopy(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure? Colonoscopy) {
            DataType? g_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime?>? h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, g_);
            CqlDateTime? i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime?>? j_ = this.Measurement_Period(context);
            CqlDateTime? k_ = context.Operators.End(j_);
            CqlQuantity? l_ = context.Operators.Quantity(11m, "years");
            CqlDateTime? m_ = context.Operators.Subtract(k_, l_);
            CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(m_, k_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime?>(i_, n_, (string?)default);
            bool? p_ = context.Operators.Not((bool?)(k_ is null));
            bool? q_ = context.Operators.And(o_, p_);
            return q_;
        }


        CqlDateTime? d_(Procedure? Colonoscopy) {
            DataType? r_ = Colonoscopy?.Performed;
            CqlDateTime? s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
            return s_;
        }

        IEnumerable<CqlDateTime?>? e_ = context.Operators.WhereSelect<Procedure?, CqlDateTime?>(b_, c_, d_);
        IEnumerable<CqlDateTime?>? f_ = context.Operators.Distinct<CqlDateTime?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure?>? Colonoscopy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Colonoscopy_Performed, Colonoscopy_Performed_Compute);

    private const long _cacheIndex_Colonoscopy_Performed = -8919904835599105640L;

    private IEnumerable<Procedure?>? Colonoscopy_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Colonoscopy(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure? Colonoscopy) {
            Code<EventStatus>? e_ = Colonoscopy?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            DataType? h_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime?>? i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
            CqlDateTime? j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime?>? k_ = this.Measurement_Period(context);
            CqlDateTime? l_ = context.Operators.End(k_);
            CqlQuantity? m_ = context.Operators.Quantity(10m, "years");
            CqlDateTime? n_ = context.Operators.Subtract(l_, m_);
            CqlInterval<CqlDateTime?>? o_ = context.Operators.Interval(n_, l_, true, true);
            bool? p_ = context.Operators.In<CqlDateTime?>(j_, o_, (string?)default);
            bool? q_ = context.Operators.Not((bool?)(l_ is null));
            bool? r_ = context.Operators.And(p_, q_);
            bool? s_ = context.Operators.And(g_, r_);
            return s_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure?>? Colonoscopy_Performed_without_appropriate_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Colonoscopy_Performed_without_appropriate_status, Colonoscopy_Performed_without_appropriate_status_Compute);

    private const long _cacheIndex_Colonoscopy_Performed_without_appropriate_status = 8524973373205555058L;

    private IEnumerable<Procedure?>? Colonoscopy_Performed_without_appropriate_status_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Colonoscopy(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure? Colonoscopy) {
            Code<EventStatus>? e_ = Colonoscopy?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            bool? h_ = context.Operators.Not(g_);
            DataType? i_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime?>? j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
            CqlDateTime? k_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime?>? l_ = this.Measurement_Period(context);
            CqlDateTime? m_ = context.Operators.End(l_);
            CqlQuantity? n_ = context.Operators.Quantity(10m, "years");
            CqlDateTime? o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(o_, m_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime?>(k_, p_, (string?)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            bool? t_ = context.Operators.And(h_, s_);
            return t_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 3077402812686725189L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Procedure?>? a_ = this.Colonoscopy_Performed(context);
        bool? b_ = context.Operators.Exists<Procedure?>(a_);
        IEnumerable<Observation?>? c_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? d_ = context.Operators.Exists<Observation?>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<Procedure?>? f_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? g_ = context.Operators.Exists<Procedure?>(f_);
        bool? h_ = context.Operators.Or(e_, g_);
        IEnumerable<Observation?>? i_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
        bool? j_ = context.Operators.Exists<Observation?>(i_);
        bool? k_ = context.Operators.Or(h_, j_);
        IEnumerable<Observation?>? l_ = this.CT_Colonography_Performed(context);
        bool? m_ = context.Operators.Exists<Observation?>(l_);
        bool? n_ = context.Operators.Or(k_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Final_Numerator_Population, Final_Numerator_Population_Compute);

    private const long _cacheIndex_Final_Numerator_Population = 5499127386273478599L;

    private bool? Final_Numerator_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Numerator(context);
        bool? b_ = this.Initial_Population(context);
        bool? c_ = context.Operators.And(a_, b_);
        bool? d_ = this.Denominator(context);
        bool? e_ = context.Operators.And(c_, d_);
        bool? f_ = this.Denominator_Exclusions(context);
        bool? g_ = context.Operators.Not(f_);
        bool? h_ = context.Operators.And(e_, g_);
        return h_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private Exam130FHIR_0_0_003() {}

    public static Exam130FHIR_0_0_003 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "Exam130FHIR";
    public string Version => "0.0.003";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, HospiceFHIR4_2_3_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, PalliativeCareFHIR_0_6_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
       [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
       ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
