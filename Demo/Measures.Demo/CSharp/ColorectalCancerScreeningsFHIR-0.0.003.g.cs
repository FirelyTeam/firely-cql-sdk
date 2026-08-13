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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
[CqlLibrary("ColorectalCancerScreeningsFHIR", "0.0.003")]
public partial class ColorectalCancerScreeningsFHIR_0_0_003 : ILibrary, ISingleton<ColorectalCancerScreeningsFHIR_0_0_003>
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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -7159507046904387638L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime b_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (34)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 3779919762897934708L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -6406604527763663698L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -4633705471254048314L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 8833301461965275659L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 4634690437592936449L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Telehealth_Services, Telehealth_Services_Compute);

    private const long _cacheIndex_Telehealth_Services = 5153813602389841264L;

    private IEnumerable<Encounter> Telehealth_Services_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Online_Assessments(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);

        bool? f_(Encounter TelehealthEncounter) {
            Code<Encounter.EncounterStatus> h_ = TelehealthEncounter?.StatusElement;
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "finished");
            // CQL 'and' (74:13-75:104): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                Period l_ = TelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, l_);
                bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, (string)default);
                return j_ & n_;
            }
        }

        IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Age_at_start_of_Measurement_Period, Age_at_start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Age_at_start_of_Measurement_Period = -179096859457406355L;

    private int? Age_at_start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        return h_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 1513368315270415706L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(51, 75, true, false);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        // CQL 'and' (83:3-86:5): right operand skipped when left is false
        if (j_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> k_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
            IEnumerable<Encounter> l_ = this.Telehealth_Services(context);
            IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(k_, l_);
            bool? n_ = context.Operators.Exists<Encounter>(m_);
            return j_ & n_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -545785600920817279L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Malignant_Neoplasm, Malignant_Neoplasm_Compute);

    private const long _cacheIndex_Malignant_Neoplasm = -2013760539854403021L;

    private IEnumerable<Condition> Malignant_Neoplasm_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition ColorectalCancer) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, (string)default);
            return i_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Total_Colectomy_Performed, Total_Colectomy_Performed_Compute);

    private const long _cacheIndex_Total_Colectomy_Performed = -3878657961703101303L;

    private IEnumerable<Procedure> Total_Colectomy_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure Colectomy) {
            Code<EventStatus> e_ = Colectomy?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            // CQL 'and' (110:13-112:41): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                DataType h_ = Colectomy?.Performed;
                CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
                CqlDateTime j_ = context.Operators.End(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.End(k_);
                bool? m_ = context.Operators.SameOrBefore(j_, l_, (string)default);
                return g_ & m_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Total_Colectomy_Condition, Total_Colectomy_Condition_Compute);

    private const long _cacheIndex_Total_Colectomy_Condition = -3290120540745504141L;

    private IEnumerable<Condition> Total_Colectomy_Condition_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Total_Colectomy_ICD9(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition ColectomyDx) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, (string)default);
            return i_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -5183057673403238137L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        bool? b_;
        // CQL 'or' (93:3-94:42): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            IEnumerable<Condition> g_ = this.Malignant_Neoplasm(context);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            b_ = a_ | h_;
        }
        bool? c_;
        // CQL 'or' (93:3-95:49): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<Procedure> i_ = this.Total_Colectomy_Performed(context);
            bool? j_ = context.Operators.Exists<Procedure>(i_);
            c_ = b_ | j_;
        }
        bool? d_;
        // CQL 'or' (93:3-96:49): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            IEnumerable<Condition> k_ = this.Total_Colectomy_Condition(context);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            d_ = c_ | l_;
        }
        bool? e_;
        // CQL 'or' (93:3-97:92): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            bool? m_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
            e_ = d_ | m_;
        }
        bool? f_;
        // CQL 'or' (93:3-100:13): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            Patient n_ = this.Patient(context);
            Date o_ = n_?.BirthDateElement;
            string p_ = o_?.Value;
            CqlDate q_ = context.Operators.ConvertStringToDate(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            int? u_ = context.Operators.CalculateAgeAt(q_, t_, "year");
            bool? v_ = context.Operators.GreaterOrEqual(u_, 65);
            bool? w_;
            // CQL 'and' (98:16-100:13): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                bool? x_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
                w_ = v_ & x_;
            }
            f_ = e_ | w_;
        }
        // CQL 'or' (93:3-101:73): right operand skipped when left is true
        if (f_ is true)
        {
            return true;
        }
        else
        {
            bool? y_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
            return f_ | y_;
        }
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status, Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status = 8069040289701519478L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FecalOccult) {
            DataType g_ = FecalOccult?.Effective;
            CqlDateTime h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlQuantity k_ = context.Operators.Quantity(1m, "year");
            CqlDateTime l_ = context.Operators.Subtract(j_, k_);
            CqlDateTime m_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(l_, m_, false, false);
            bool? o_ = context.Operators.In<CqlDateTime>(h_, n_, (string)default);
            return o_;
        }


        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? d_(Observation FecalOccult) {
            DataType p_ = FecalOccult?.Effective;
            CqlDateTime q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, p_);
            DataType r_ = FecalOccult?.Value;
            IEnumerable<Coding> s_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(r_, "coding");

            bool? t_(Coding @this) {
                FhirString aj_ = @this?.DisplayElement;
                return !((bool?)(aj_ is null));
            }


            FhirString u_(Coding @this) {
                FhirString ak_ = @this?.DisplayElement;
                return ak_;
            }

            IEnumerable<FhirString> v_ = context.Operators.WhereSelect<Coding, FhirString>(s_, t_, u_);
            List<CodeableConcept> w_ = FecalOccult?.Category;

            bool? x_(CodeableConcept @this) {
                List<Coding> al_ = @this?.Coding;
                return !((bool?)(al_ is null));
            }


            List<Coding> y_(CodeableConcept @this) {
                List<Coding> am_ = @this?.Coding;
                return am_;
            }

            IEnumerable<List<Coding>> z_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>((IEnumerable<CodeableConcept>)w_, x_, y_);
            IEnumerable<Coding> aa_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)z_);

            bool? ab_(Coding @this) {
                Code an_ = @this?.CodeElement;
                return !((bool?)(an_ is null));
            }


            Code ac_(Coding @this) {
                Code ao_ = @this?.CodeElement;
                return ao_;
            }

            IEnumerable<Code> ad_ = context.Operators.WhereSelect<Coding, Code>(aa_, ab_, ac_);

            bool? ae_(Code @this) {
                string ap_ = @this?.Value;
                return !((bool?)(ap_ is null));
            }


            string af_(Code @this) {
                string aq_ = @this?.Value;
                return aq_;
            }

            IEnumerable<string> ag_ = context.Operators.WhereSelect<Code, string>(ad_, ae_, af_);
            Code<ObservationStatus> ah_ = FecalOccult?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? ai_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, q_, v_, ag_, ah_);
            return ai_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> e_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(b_, c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed, Fecal_Occult_Blood_Test_Performed_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed = -8238801997070200478L;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FecalOccult) {
            Code<ObservationStatus> e_ = FecalOccult?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_;
            // CQL 'and' (137:19-139:83): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                List<CodeableConcept> k_ = FecalOccult?.Category;

                bool? l_(CodeableConcept FecalOccultCategory) {
                    List<Coding> n_ = FecalOccultCategory?.Coding;

                    bool? o_(Coding @this) {
                        Code w_ = @this?.CodeElement;
                        return !((bool?)(w_ is null));
                    }


                    Code p_(Coding @this) {
                        Code x_ = @this?.CodeElement;
                        return x_;
                    }

                    IEnumerable<Code> q_ = context.Operators.WhereSelect<Coding, Code>((IEnumerable<Coding>)n_, o_, p_);

                    bool? r_(Code @this) {
                        string y_ = @this?.Value;
                        return !((bool?)(y_ is null));
                    }


                    string s_(Code @this) {
                        string z_ = @this?.Value;
                        return z_;
                    }

                    IEnumerable<string> t_ = context.Operators.WhereSelect<Code, string>(q_, r_, s_);
                    string[] u_ = [
                        "laboratory",
                    ];
                    bool? v_ = context.Operators.Equivalent<string>(t_, (IEnumerable<string>)u_);
                    return v_;
                }

                bool? m_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)k_, l_);
                i_ = h_ & m_;
            }
            bool? j_;
            // CQL 'and' (137:19-140:47): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType aa_ = FecalOccult?.Value;
                j_ = i_ & (!((bool?)(aa_ is null)));
            }
            // CQL 'and' (137:13-141:87): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                DataType ab_ = FecalOccult?.Effective;
                CqlDateTime ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, (string)default);
                return j_ & ae_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed__day_of_TZoffset, Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed__day_of_TZoffset = 5406181350140102432L;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FecalOccult) {
            Code<ObservationStatus> e_ = FecalOccult?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_;
            // CQL 'and' (146:19-148:83): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                List<CodeableConcept> k_ = FecalOccult?.Category;

                bool? l_(CodeableConcept FecalOccultCategory) {
                    List<Coding> n_ = FecalOccultCategory?.Coding;

                    bool? o_(Coding @this) {
                        Code w_ = @this?.CodeElement;
                        return !((bool?)(w_ is null));
                    }


                    Code p_(Coding @this) {
                        Code x_ = @this?.CodeElement;
                        return x_;
                    }

                    IEnumerable<Code> q_ = context.Operators.WhereSelect<Coding, Code>((IEnumerable<Coding>)n_, o_, p_);

                    bool? r_(Code @this) {
                        string y_ = @this?.Value;
                        return !((bool?)(y_ is null));
                    }


                    string s_(Code @this) {
                        string z_ = @this?.Value;
                        return z_;
                    }

                    IEnumerable<string> t_ = context.Operators.WhereSelect<Code, string>(q_, r_, s_);
                    string[] u_ = [
                        "laboratory",
                    ];
                    bool? v_ = context.Operators.Equivalent<string>(t_, (IEnumerable<string>)u_);
                    return v_;
                }

                bool? m_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)k_, l_);
                i_ = h_ & m_;
            }
            bool? j_;
            // CQL 'and' (146:19-149:47): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType aa_ = FecalOccult?.Value;
                j_ = i_ & (!((bool?)(aa_ is null)));
            }
            // CQL 'and' (146:13-150:94): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                DataType ab_ = FecalOccult?.Effective;
                CqlDateTime ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, "day");
                return j_ & ae_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset, Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset = -7973498713015387976L;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FecalOccult) {
            List<CodeableConcept> e_ = FecalOccult?.Category;

            bool? f_(CodeableConcept FecalOccultCategory) {
                List<Coding> i_ = FecalOccultCategory?.Coding;

                bool? j_(Coding @this) {
                    Code r_ = @this?.CodeElement;
                    return !((bool?)(r_ is null));
                }


                Code k_(Coding @this) {
                    Code s_ = @this?.CodeElement;
                    return s_;
                }

                IEnumerable<Code> l_ = context.Operators.WhereSelect<Coding, Code>((IEnumerable<Coding>)i_, j_, k_);

                bool? m_(Code @this) {
                    string t_ = @this?.Value;
                    return !((bool?)(t_ is null));
                }


                string n_(Code @this) {
                    string u_ = @this?.Value;
                    return u_;
                }

                IEnumerable<string> o_ = context.Operators.WhereSelect<Code, string>(l_, m_, n_);
                string[] p_ = [
                    "laboratory",
                ];
                bool? q_ = context.Operators.Equivalent<string>(o_, (IEnumerable<string>)p_);
                return !q_;
            }

            bool? g_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)e_, f_);
            bool? h_;
            // CQL 'and' (159:15-161:47): right operand skipped when left is false
            if (g_ is false)
            {
                h_ = false;
            }
            else
            {
                DataType v_ = FecalOccult?.Value;
                h_ = g_ & (!((bool?)(v_ is null)));
            }
            // CQL 'and' (156:13-162:94): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                DataType w_ = FecalOccult?.Effective;
                CqlDateTime x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, w_);
                CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
                bool? z_ = context.Operators.In<CqlDateTime>(x_, y_, "day");
                return h_ & z_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset, Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset = -7416992961724927074L;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FecalOccult) {
            Code<ObservationStatus> e_ = FecalOccult?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_ = !h_;
            bool? j_;
            // CQL 'and' (167:19-170:47): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType k_ = FecalOccult?.Value;
                j_ = i_ & (!((bool?)(k_ is null)));
            }
            // CQL 'and' (167:13-171:94): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                DataType l_ = FecalOccult?.Effective;
                CqlDateTime m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, l_);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
                return j_ & o_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status, Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status = -1769822955579624479L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.FIT_DNA(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FitDNA) {
            DataType g_ = FitDNA?.Effective;
            CqlDateTime h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlQuantity k_ = context.Operators.Quantity(4m, "years");
            CqlDateTime l_ = context.Operators.Subtract(j_, k_);
            CqlInterval<CqlDateTime> m_ = context.Operators.Interval(l_, j_, true, true);
            bool? n_ = context.Operators.In<CqlDateTime>(h_, m_, (string)default);
            // CQL 'and' (179:5-180:33): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                CqlDateTime p_ = context.Operators.End(o_);
                return n_ & (!((bool?)(p_ is null)));
            }
        }


        (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? d_(Observation FitDNA) {
            DataType q_ = FitDNA?.Effective;
            CqlDateTime r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, q_);
            DataType s_ = FitDNA?.Value;
            IEnumerable<Coding> t_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(s_, "coding");

            bool? u_(Coding @this) {
                FhirString ak_ = @this?.DisplayElement;
                return !((bool?)(ak_ is null));
            }


            FhirString v_(Coding @this) {
                FhirString al_ = @this?.DisplayElement;
                return al_;
            }

            IEnumerable<FhirString> w_ = context.Operators.WhereSelect<Coding, FhirString>(t_, u_, v_);
            List<CodeableConcept> x_ = FitDNA?.Category;

            bool? y_(CodeableConcept @this) {
                List<Coding> am_ = @this?.Coding;
                return !((bool?)(am_ is null));
            }


            List<Coding> z_(CodeableConcept @this) {
                List<Coding> an_ = @this?.Coding;
                return an_;
            }

            IEnumerable<List<Coding>> aa_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>((IEnumerable<CodeableConcept>)x_, y_, z_);
            IEnumerable<Coding> ab_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)aa_);

            bool? ac_(Coding @this) {
                Code ao_ = @this?.CodeElement;
                return !((bool?)(ao_ is null));
            }


            Code ad_(Coding @this) {
                Code ap_ = @this?.CodeElement;
                return ap_;
            }

            IEnumerable<Code> ae_ = context.Operators.WhereSelect<Coding, Code>(ab_, ac_, ad_);

            bool? af_(Code @this) {
                string aq_ = @this?.Value;
                return !((bool?)(aq_ is null));
            }


            string ag_(Code @this) {
                string ar_ = @this?.Value;
                return ar_;
            }

            IEnumerable<string> ah_ = context.Operators.WhereSelect<Code, string>(ae_, af_, ag_);
            Code<ObservationStatus> ai_ = FitDNA?.StatusElement;
            (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? aj_ = (CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV, r_, w_, ah_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> e_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(b_, c_, d_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Performed, Fecal_Immunochemical_Test_DNA_Performed_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Performed = -5062829886070942253L;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.FIT_DNA(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FitDNA) {
            Code<ObservationStatus> e_ = FitDNA?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_;
            // CQL 'and' (191:19-193:78): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                List<CodeableConcept> k_ = FitDNA?.Category;

                bool? l_(CodeableConcept FitDNACategory) {
                    List<Coding> n_ = FitDNACategory?.Coding;

                    bool? o_(Coding @this) {
                        Code w_ = @this?.CodeElement;
                        return !((bool?)(w_ is null));
                    }


                    Code p_(Coding @this) {
                        Code x_ = @this?.CodeElement;
                        return x_;
                    }

                    IEnumerable<Code> q_ = context.Operators.WhereSelect<Coding, Code>((IEnumerable<Coding>)n_, o_, p_);

                    bool? r_(Code @this) {
                        string y_ = @this?.Value;
                        return !((bool?)(y_ is null));
                    }


                    string s_(Code @this) {
                        string z_ = @this?.Value;
                        return z_;
                    }

                    IEnumerable<string> t_ = context.Operators.WhereSelect<Code, string>(q_, r_, s_);
                    string[] u_ = [
                        "laboratory",
                    ];
                    bool? v_ = context.Operators.Equivalent<string>(t_, (IEnumerable<string>)u_);
                    return v_;
                }

                bool? m_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)k_, l_);
                i_ = h_ & m_;
            }
            bool? j_;
            // CQL 'and' (191:19-194:42): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType aa_ = FitDNA?.Value;
                j_ = i_ & (!((bool?)(aa_ is null)));
            }
            // CQL 'and' (191:13-196:41): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                DataType ab_ = FitDNA?.Effective;
                CqlDateTime ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                CqlDateTime ae_ = context.Operators.End(ad_);
                CqlQuantity af_ = context.Operators.Quantity(3m, "years");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ag_, ae_, true, true);
                bool? ai_ = context.Operators.In<CqlDateTime>(ac_, ah_, (string)default);
                bool? aj_;
                // CQL 'and' (195:19-196:41): right operand skipped when left is false
                if (ai_ is false)
                {
                    aj_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
                    CqlDateTime al_ = context.Operators.End(ak_);
                    aj_ = ai_ & (!((bool?)(al_ is null)));
                }
                return j_ & aj_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset, Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset = 5597767078164056170L;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.FIT_DNA(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FitDNA) {
            Code<ObservationStatus> e_ = FitDNA?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_;
            // CQL 'and' (201:19-203:78): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                List<CodeableConcept> k_ = FitDNA?.Category;

                bool? l_(CodeableConcept FitDNACategory) {
                    List<Coding> n_ = FitDNACategory?.Coding;

                    bool? o_(Coding @this) {
                        Code w_ = @this?.CodeElement;
                        return !((bool?)(w_ is null));
                    }


                    Code p_(Coding @this) {
                        Code x_ = @this?.CodeElement;
                        return x_;
                    }

                    IEnumerable<Code> q_ = context.Operators.WhereSelect<Coding, Code>((IEnumerable<Coding>)n_, o_, p_);

                    bool? r_(Code @this) {
                        string y_ = @this?.Value;
                        return !((bool?)(y_ is null));
                    }


                    string s_(Code @this) {
                        string z_ = @this?.Value;
                        return z_;
                    }

                    IEnumerable<string> t_ = context.Operators.WhereSelect<Code, string>(q_, r_, s_);
                    string[] u_ = [
                        "laboratory",
                    ];
                    bool? v_ = context.Operators.Equivalent<string>(t_, (IEnumerable<string>)u_);
                    return v_;
                }

                bool? m_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)k_, l_);
                i_ = h_ & m_;
            }
            bool? j_;
            // CQL 'and' (201:19-204:42): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType aa_ = FitDNA?.Value;
                j_ = i_ & (!((bool?)(aa_ is null)));
            }
            // CQL 'and' (201:13-206:48): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                DataType ab_ = FitDNA?.Effective;
                CqlDateTime ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                CqlDateTime ae_ = context.Operators.End(ad_);
                CqlQuantity af_ = context.Operators.Quantity(3m, "years");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ag_, ae_, true, true);
                bool? ai_ = context.Operators.In<CqlDateTime>(ac_, ah_, "day");
                bool? aj_;
                // CQL 'and' (205:19-206:48): right operand skipped when left is false
                if (ai_ is false)
                {
                    aj_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
                    CqlDateTime al_ = context.Operators.End(ak_);
                    aj_ = ai_ & (!((bool?)(al_ is null)));
                }
                return j_ & aj_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset, Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset = -4793269512398557757L;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.FIT_DNA(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FitDNA) {
            List<CodeableConcept> e_ = FitDNA?.Category;

            bool? f_(CodeableConcept FitDNACategory) {
                List<Coding> i_ = FitDNACategory?.Coding;

                bool? j_(Coding @this) {
                    Code r_ = @this?.CodeElement;
                    return !((bool?)(r_ is null));
                }


                Code k_(Coding @this) {
                    Code s_ = @this?.CodeElement;
                    return s_;
                }

                IEnumerable<Code> l_ = context.Operators.WhereSelect<Coding, Code>((IEnumerable<Coding>)i_, j_, k_);

                bool? m_(Code @this) {
                    string t_ = @this?.Value;
                    return !((bool?)(t_ is null));
                }


                string n_(Code @this) {
                    string u_ = @this?.Value;
                    return u_;
                }

                IEnumerable<string> o_ = context.Operators.WhereSelect<Code, string>(l_, m_, n_);
                string[] p_ = [
                    "laboratory",
                ];
                bool? q_ = context.Operators.Equivalent<string>(o_, (IEnumerable<string>)p_);
                return !q_;
            }

            bool? g_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)e_, f_);
            bool? h_;
            // CQL 'and' (215:15-217:42): right operand skipped when left is false
            if (g_ is false)
            {
                h_ = false;
            }
            else
            {
                DataType v_ = FitDNA?.Value;
                h_ = g_ & (!((bool?)(v_ is null)));
            }
            // CQL 'and' (212:13-219:48): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                DataType w_ = FitDNA?.Effective;
                CqlDateTime x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, w_);
                CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
                CqlDateTime z_ = context.Operators.End(y_);
                CqlQuantity aa_ = context.Operators.Quantity(3m, "years");
                CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(ab_, z_, true, true);
                bool? ad_ = context.Operators.In<CqlDateTime>(x_, ac_, "day");
                bool? ae_;
                // CQL 'and' (218:19-219:48): right operand skipped when left is false
                if (ad_ is false)
                {
                    ae_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
                    CqlDateTime ag_ = context.Operators.End(af_);
                    ae_ = ad_ & (!((bool?)(ag_ is null)));
                }
                return h_ & ae_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset, Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Compute);

    private const long _cacheIndex_Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset = -5977460989936445255L;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.FIT_DNA(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FitDNA) {
            Code<ObservationStatus> e_ = FitDNA?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_ = !h_;
            bool? j_;
            // CQL 'and' (224:19-227:42): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType k_ = FitDNA?.Value;
                j_ = i_ & (!((bool?)(k_ is null)));
            }
            // CQL 'and' (224:13-229:48): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                DataType l_ = FitDNA?.Effective;
                CqlDateTime m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, l_);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                CqlDateTime o_ = context.Operators.End(n_);
                CqlQuantity p_ = context.Operators.Quantity(3m, "years");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(q_, o_, true, true);
                bool? s_ = context.Operators.In<CqlDateTime>(m_, r_, "day");
                bool? t_;
                // CQL 'and' (228:19-229:48): right operand skipped when left is false
                if (s_ is false)
                {
                    t_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                    CqlDateTime v_ = context.Operators.End(u_);
                    t_ = s_ & (!((bool?)(v_ is null)));
                }
                return j_ & t_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_CT_Colonography_Display_Date, CT_Colonography_Display_Date_Compute);

    private const long _cacheIndex_CT_Colonography_Display_Date = 1446526604675654581L;

    private IEnumerable<CqlDateTime> CT_Colonography_Display_Date_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.CT_Colonography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation Colonography) {
            DataType g_ = Colonography?.Effective;
            CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            CqlQuantity l_ = context.Operators.Quantity(6m, "years");
            CqlDateTime m_ = context.Operators.Subtract(k_, l_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(m_, k_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(i_, n_, (string)default);
            // CQL 'and' (238:13-239:41): right operand skipped when left is false
            if (o_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                CqlDateTime q_ = context.Operators.End(p_);
                return o_ & (!((bool?)(q_ is null)));
            }
        }


        CqlDateTime d_(Observation Colonography) {
            DataType r_ = Colonography?.Effective;
            CqlDateTime s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
            return s_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.WhereSelect<Observation, CqlDateTime>(b_, c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        return f_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_CT_Colonography_Performed, CT_Colonography_Performed_Compute);

    private const long _cacheIndex_CT_Colonography_Performed = -7508648807745259967L;

    private IEnumerable<Observation> CT_Colonography_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.CT_Colonography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation Colonography) {
            Code<ObservationStatus> e_ = Colonography?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            // CQL 'and' (244:13-246:41): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                DataType i_ = Colonography?.Effective;
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
                CqlDateTime k_ = context.Operators.End(j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlQuantity n_ = context.Operators.Quantity(5m, "years");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
                bool? r_;
                // CQL 'and' (245:19-246:41): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                    CqlDateTime t_ = context.Operators.End(s_);
                    r_ = q_ & (!((bool?)(t_ is null)));
                }
                return h_ & r_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_CT_Colonography_Performed_without_appropriate_status, CT_Colonography_Performed_without_appropriate_status_Compute);

    private const long _cacheIndex_CT_Colonography_Performed_without_appropriate_status = -7761967252531306620L;

    private IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.CT_Colonography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation Colonography) {
            Code<ObservationStatus> e_ = Colonography?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_ = !h_;
            // CQL 'and' (251:13-253:41): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                DataType j_ = Colonography?.Effective;
                CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlDateTime n_ = context.Operators.End(m_);
                CqlQuantity o_ = context.Operators.Quantity(5m, "years");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(p_, n_, true, true);
                bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
                bool? s_;
                // CQL 'and' (252:19-253:41): right operand skipped when left is false
                if (r_ is false)
                {
                    s_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                    CqlDateTime u_ = context.Operators.End(t_);
                    s_ = r_ & (!((bool?)(u_ is null)));
                }
                return i_ & s_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Flexible_Sigmoidoscopy_Display_Date, Flexible_Sigmoidoscopy_Display_Date_Compute);

    private const long _cacheIndex_Flexible_Sigmoidoscopy_Display_Date = -6378016023402539859L;

    private IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure FlexibleSigmoidoscopy) {
            DataType g_ = FlexibleSigmoidoscopy?.Performed;
            CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            CqlQuantity l_ = context.Operators.Quantity(6m, "years");
            CqlDateTime m_ = context.Operators.Subtract(k_, l_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(m_, k_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(i_, n_, (string)default);
            // CQL 'and' (262:5-263:33): right operand skipped when left is false
            if (o_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                CqlDateTime q_ = context.Operators.End(p_);
                return o_ & (!((bool?)(q_ is null)));
            }
        }


        CqlDateTime d_(Procedure FlexibleSigmoidoscopy) {
            DataType r_ = FlexibleSigmoidoscopy?.Performed;
            CqlDateTime s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
            return s_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.WhereSelect<Procedure, CqlDateTime>(b_, c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Flexible_Sigmoidoscopy_Performed, Flexible_Sigmoidoscopy_Performed_Compute);

    private const long _cacheIndex_Flexible_Sigmoidoscopy_Performed = 1854577308446829673L;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure FlexibleSigmoidoscopy) {
            Code<EventStatus> e_ = FlexibleSigmoidoscopy?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            // CQL 'and' (268:13-270:41): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                DataType h_ = FlexibleSigmoidoscopy?.Performed;
                CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
                CqlDateTime j_ = context.Operators.End(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlQuantity m_ = context.Operators.Quantity(5m, "years");
                CqlDateTime n_ = context.Operators.Subtract(l_, m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(n_, l_, true, true);
                bool? p_ = context.Operators.In<CqlDateTime>(j_, o_, (string)default);
                bool? q_;
                // CQL 'and' (269:19-270:41): right operand skipped when left is false
                if (p_ is false)
                {
                    q_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                    CqlDateTime s_ = context.Operators.End(r_);
                    q_ = p_ & (!((bool?)(s_ is null)));
                }
                return g_ & q_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Flexible_Sigmoidoscopy_Performed_without_appropriate_status, Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Compute);

    private const long _cacheIndex_Flexible_Sigmoidoscopy_Performed_without_appropriate_status = -1176134144124008910L;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure FlexibleSigmoidoscopy) {
            Code<EventStatus> e_ = FlexibleSigmoidoscopy?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            bool? h_ = !g_;
            // CQL 'and' (275:13-277:41): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                DataType i_ = FlexibleSigmoidoscopy?.Performed;
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
                CqlDateTime k_ = context.Operators.End(j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlQuantity n_ = context.Operators.Quantity(5m, "years");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
                bool? r_;
                // CQL 'and' (276:19-277:41): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                    CqlDateTime t_ = context.Operators.End(s_);
                    r_ = q_ & (!((bool?)(t_ is null)));
                }
                return h_ & r_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Colonoscopy_Display_Date, Colonoscopy_Display_Date_Compute);

    private const long _cacheIndex_Colonoscopy_Display_Date = 3090058787813378173L;

    private IEnumerable<CqlDateTime> Colonoscopy_Display_Date_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Colonoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure Colonoscopy) {
            DataType g_ = Colonoscopy?.Performed;
            CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.End(j_);
            CqlQuantity l_ = context.Operators.Quantity(11m, "years");
            CqlDateTime m_ = context.Operators.Subtract(k_, l_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(m_, k_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(i_, n_, (string)default);
            // CQL 'and' (286:5-287:33): right operand skipped when left is false
            if (o_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                CqlDateTime q_ = context.Operators.End(p_);
                return o_ & (!((bool?)(q_ is null)));
            }
        }


        CqlDateTime d_(Procedure Colonoscopy) {
            DataType r_ = Colonoscopy?.Performed;
            CqlDateTime s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
            return s_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.WhereSelect<Procedure, CqlDateTime>(b_, c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Colonoscopy_Performed, Colonoscopy_Performed_Compute);

    private const long _cacheIndex_Colonoscopy_Performed = -8521434728266695929L;

    private IEnumerable<Procedure> Colonoscopy_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Colonoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure Colonoscopy) {
            Code<EventStatus> e_ = Colonoscopy?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            // CQL 'and' (292:13-294:41): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                DataType h_ = Colonoscopy?.Performed;
                CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
                CqlDateTime j_ = context.Operators.End(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlQuantity m_ = context.Operators.Quantity(10m, "years");
                CqlDateTime n_ = context.Operators.Subtract(l_, m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(n_, l_, true, true);
                bool? p_ = context.Operators.In<CqlDateTime>(j_, o_, (string)default);
                bool? q_;
                // CQL 'and' (293:19-294:41): right operand skipped when left is false
                if (p_ is false)
                {
                    q_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                    CqlDateTime s_ = context.Operators.End(r_);
                    q_ = p_ & (!((bool?)(s_ is null)));
                }
                return g_ & q_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Colonoscopy_Performed_without_appropriate_status, Colonoscopy_Performed_without_appropriate_status_Compute);

    private const long _cacheIndex_Colonoscopy_Performed_without_appropriate_status = 1129739389664652957L;

    private IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Colonoscopy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure Colonoscopy) {
            Code<EventStatus> e_ = Colonoscopy?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            bool? h_ = !g_;
            // CQL 'and' (299:13-301:41): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                DataType i_ = Colonoscopy?.Performed;
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
                CqlDateTime k_ = context.Operators.End(j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlQuantity n_ = context.Operators.Quantity(10m, "years");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
                bool? r_;
                // CQL 'and' (300:19-301:41): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                    CqlDateTime t_ = context.Operators.End(s_);
                    r_ = q_ & (!((bool?)(t_ is null)));
                }
                return h_ & r_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8886411875624464507L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Colonoscopy_Performed(context);
        bool? b_ = context.Operators.Exists<Procedure>(a_);
        bool? c_;
        // CQL 'or' (304:3-305:57): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<Observation> f_ = this.Fecal_Occult_Blood_Test_Performed(context);
            bool? g_ = context.Operators.Exists<Observation>(f_);
            c_ = b_ | g_;
        }
        bool? d_;
        // CQL 'or' (304:3-306:56): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            IEnumerable<Procedure> h_ = this.Flexible_Sigmoidoscopy_Performed(context);
            bool? i_ = context.Operators.Exists<Procedure>(h_);
            d_ = c_ | i_;
        }
        bool? e_;
        // CQL 'or' (304:3-307:63): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            IEnumerable<Observation> j_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
            bool? k_ = context.Operators.Exists<Observation>(j_);
            e_ = d_ | k_;
        }
        // CQL 'or' (304:3-308:49): right operand skipped when left is true
        if (e_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<Observation> l_ = this.CT_Colonography_Performed(context);
            bool? m_ = context.Operators.Exists<Observation>(l_);
            return e_ | m_;
        }
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Final_Numerator_Population, Final_Numerator_Population_Compute);

    private const long _cacheIndex_Final_Numerator_Population = -5067012961773851374L;

    private bool? Final_Numerator_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Numerator(context);
        bool? b_;
        // CQL 'and' (312:3-313:26): right operand skipped when left is false
        if (a_ is false)
        {
            b_ = false;
        }
        else
        {
            bool? d_ = this.Initial_Population(context);
            b_ = a_ & d_;
        }
        bool? c_;
        // CQL 'and' (312:3-314:19): right operand skipped when left is false
        if (b_ is false)
        {
            c_ = false;
        }
        else
        {
            bool? e_ = this.Denominator(context);
            c_ = b_ & e_;
        }
        // CQL 'and' (312:3-315:34): right operand skipped when left is false
        if (c_ is false)
        {
            return false;
        }
        else
        {
            bool? f_ = this.Denominator_Exclusions(context);
            return c_ & !f_;
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private ColorectalCancerScreeningsFHIR_0_0_003() {}

    public static ColorectalCancerScreeningsFHIR_0_0_003 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "ColorectalCancerScreeningsFHIR";
    public string Version => "0.0.003";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, HospiceFHIR4_2_3_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, PalliativeCareFHIR_0_6_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
       [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
       ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    #endregion CqlTupleMetadata Properties

}
