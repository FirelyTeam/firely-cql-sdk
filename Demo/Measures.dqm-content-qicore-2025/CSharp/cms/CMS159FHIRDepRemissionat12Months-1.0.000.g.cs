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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("CMS159FHIRDepRemissionat12Months", "1.0.000")]
public partial class CMS159FHIRDepRemissionat12Months_1_0_000 : ILibrary, ISingleton<CMS159FHIRDepRemissionat12Months_1_0_000>
{
    #region ValueSets (16)

    [CqlValueSetDefinition("Bipolar Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", valueSetVersion: null)]
    public CqlValueSet Bipolar_Disorder(CqlContext _) => _Bipolar_Disorder;
    private static readonly CqlValueSet _Bipolar_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", null);

    [CqlValueSetDefinition("Contact or Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5", valueSetVersion: null)]
    public CqlValueSet Contact_or_Office_Visit(CqlContext _) => _Contact_or_Office_Visit;
    private static readonly CqlValueSet _Contact_or_Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5", null);

    [CqlValueSetDefinition("Dysthymia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254", valueSetVersion: null)]
    public CqlValueSet Dysthymia(CqlContext _) => _Dysthymia;
    private static readonly CqlValueSet _Dysthymia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlValueSetDefinition("Hospice Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", valueSetVersion: null)]
    public CqlValueSet Hospice_Diagnosis(CqlContext _) => _Hospice_Diagnosis;
    private static readonly CqlValueSet _Hospice_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);

    [CqlValueSetDefinition("Major Depression Including Remission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444", valueSetVersion: null)]
    public CqlValueSet Major_Depression_Including_Remission(CqlContext _) => _Major_Depression_Including_Remission;
    private static readonly CqlValueSet _Major_Depression_Including_Remission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444", null);

    [CqlValueSetDefinition("Palliative Care Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Diagnosis(CqlContext _) => _Palliative_Care_Diagnosis;
    private static readonly CqlValueSet _Palliative_Care_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", null);

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlValueSetDefinition("Palliative or Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext _) => _Palliative_or_Hospice_Care;
    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlValueSetDefinition("Personality Disorder Emotionally Labile", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246", valueSetVersion: null)]
    public CqlValueSet Personality_Disorder_Emotionally_Labile(CqlContext _) => _Personality_Disorder_Emotionally_Labile;
    private static readonly CqlValueSet _Personality_Disorder_Emotionally_Labile = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246", null);

    [CqlValueSetDefinition("Pervasive Developmental Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152", valueSetVersion: null)]
    public CqlValueSet Pervasive_Developmental_Disorder(CqlContext _) => _Pervasive_Developmental_Disorder;
    private static readonly CqlValueSet _Pervasive_Developmental_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152", null);

    [CqlValueSetDefinition("PHQ 9 and PHQ 9M Tools", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263", valueSetVersion: null)]
    public CqlValueSet PHQ_9_and_PHQ_9M_Tools(CqlContext _) => _PHQ_9_and_PHQ_9M_Tools;
    private static readonly CqlValueSet _PHQ_9_and_PHQ_9M_Tools = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263", null);

    [CqlValueSetDefinition("Schizophrenia or Psychotic Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104", valueSetVersion: null)]
    public CqlValueSet Schizophrenia_or_Psychotic_Disorder(CqlContext _) => _Schizophrenia_or_Psychotic_Disorder;
    private static readonly CqlValueSet _Schizophrenia_or_Psychotic_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104", null);

    #endregion ValueSets

    #region Codes (5)

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct");

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_,
          _Hospice_care__Minimum_Data_Set_]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Yes__qualifier_value_]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-ver-status", codeSystemVersion: null)]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, []);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 4515960621490826425L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS159FHIRDepRemissionat12Months-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (22)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -5174828440479377737L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Depression Assessments Greater Than 9")]
    public IEnumerable<Observation> Depression_Assessments_Greater_Than_9(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Depression_Assessments_Greater_Than_9, Depression_Assessments_Greater_Than_9_Compute);

    private const long _cacheIndex_Depression_Assessments_Greater_Than_9 = -2809144784699197651L;

    private IEnumerable<Observation> Depression_Assessments_Greater_Than_9_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? c_(Observation DepressionAssessment) {
            DataType e_ = DepressionAssessment?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Greater(f_ as int?, 9);
            Code<ObservationStatus> h_ = DepressionAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            bool? m_ = context.Operators.And(g_, l_);
            return m_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Depression Diagnoses")]
    public IEnumerable<object> Depression_Diagnoses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Depression_Diagnoses, Depression_Diagnoses_Compute);

    private const long _cacheIndex_Depression_Diagnoses = 5150113982553371070L;

    private IEnumerable<object> Depression_Diagnoses_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Major_Depression_Including_Remission(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        CqlValueSet f_ = this.Dysthymia(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
        IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);

        bool? l_(object Depression) {
            bool? n_ = this.isVerified(context, Depression);
            return n_;
        }

        IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Denominator Identification Period")]
    public CqlInterval<CqlDateTime> Denominator_Identification_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Identification_Period, Denominator_Identification_Period_Compute);

    private const long _cacheIndex_Denominator_Identification_Period = 721024531417181386L;

    private CqlInterval<CqlDateTime> Denominator_Identification_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlQuantity c_ = context.Operators.Quantity(14m, "months");
        CqlDateTime d_ = context.Operators.Subtract(b_, c_);
        CqlDateTime f_ = context.Operators.Start(a_);
        CqlQuantity g_ = context.Operators.Quantity(2m, "months");
        CqlDateTime h_ = context.Operators.Subtract(f_, g_);
        CqlInterval<CqlDateTime> i_ = context.Operators.Interval(d_, h_, true, false);
        return i_;
    }


    [CqlExpressionDefinition("Depression Encounter")]
    public IEnumerable<Encounter> Depression_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Depression_Encounter, Depression_Encounter_Compute);

    private const long _cacheIndex_Depression_Encounter = 4681658861661132345L;

    private IEnumerable<Encounter> Depression_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Contact_or_Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        IEnumerable<Encounter> c_(Encounter ValidEncounter) {
            IEnumerable<object> e_ = this.Depression_Diagnoses(context);

            bool? f_(object Depression) {
                Period j_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Depression);
                bool? m_ = context.Operators.Overlaps(k_, l_, (string)default);
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Denominator_Identification_Period(context);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");
                bool? s_ = context.Operators.And(m_, r_);
                Code<Encounter.EncounterStatus> t_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? u_ = t_?.Value;
                Code<Encounter.EncounterStatus> v_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(u_);
                bool? w_ = context.Operators.Equal(v_, "finished");
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            Encounter h_(object Depression) => ValidEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<object, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Index Depression Assessment")]
    public Observation Index_Depression_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Index_Depression_Assessment, Index_Depression_Assessment_Compute);

    private const long _cacheIndex_Index_Depression_Assessment = 499571989574502589L;

    private Observation Index_Depression_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Depression_Assessments_Greater_Than_9(context);

        IEnumerable<Observation> b_(Observation DepressionAssessment) {
            IEnumerable<Encounter> g_ = this.Depression_Encounter(context);

            bool? h_(Encounter DepressionEncounter) {
                Period l_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(7m, "days");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(p_, s_, true, true);
                DataType u_ = DepressionAssessment?.Effective;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                bool? x_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, w_, "day");
                return x_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Observation j_(Encounter DepressionEncounter) => DepressionAssessment;
            IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);

        object d_(Observation @this) {
            DataType y_ = @this?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            return ab_;
        }

        IEnumerable<Observation> e_ = context.Operators.SortBy<Observation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Observation f_ = context.Operators.First<Observation>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -677507915104673588L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
        Observation e_ = this.Index_Depression_Assessment(context);
        DataType f_ = e_?.Effective;
        object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
        CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
        CqlDateTime i_ = context.Operators.Start(h_);
        int? j_ = context.Operators.CalculateAgeAt(d_, i_, "year");
        bool? k_ = context.Operators.GreaterOrEqual(j_, 12);
        return k_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 4924516395329346969L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Measure Assessment Period")]
    public CqlInterval<CqlDate> Measure_Assessment_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measure_Assessment_Period, Measure_Assessment_Period_Compute);

    private const long _cacheIndex_Measure_Assessment_Period = -6986502766962251939L;

    private CqlInterval<CqlDate> Measure_Assessment_Period_Compute(CqlContext context)
    {
        Observation a_ = this.Index_Depression_Assessment(context);
        Observation[] b_ = [
            a_,
        ];

        CqlInterval<CqlDate> c_(Observation FirstIndexAssessment) {
            DataType g_ = FirstIndexAssessment?.Effective;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlQuantity l_ = context.Operators.Quantity(12m, "months");
            CqlDate m_ = context.Operators.Add(k_, l_);
            CqlQuantity n_ = context.Operators.Quantity(60m, "days");
            CqlDate o_ = context.Operators.Subtract(m_, n_);
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            CqlDate v_ = context.Operators.Add(t_, l_);
            CqlDate x_ = context.Operators.Add(v_, n_);
            CqlInterval<CqlDate> y_ = context.Operators.Interval(o_, x_, true, true);
            return y_;
        }

        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Select<Observation, CqlInterval<CqlDate>>((IEnumerable<Observation>)b_, c_);
        IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Distinct<CqlInterval<CqlDate>>(d_);
        CqlInterval<CqlDate> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Hospice Services prior to or during the Measure Assessment Period")]
    public bool? Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period, Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period_Compute);

    private const long _cacheIndex_Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period = 7215323320960060348L;

    private bool? Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter InpatientEncounter) {
            Encounter.HospitalizationComponent an_ = InpatientEncounter?.Hospitalization;
            CodeableConcept ao_ = an_?.DischargeDisposition;
            CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ao_);
            CqlCode aq_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept ar_ = context.Operators.ConvertCodeToConcept(aq_);
            bool? as_ = context.Operators.Equivalent(ap_, ar_);
            CodeableConcept au_ = an_?.DischargeDisposition;
            CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, au_);
            CqlCode aw_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
            bool? ay_ = context.Operators.Equivalent(av_, ax_);
            bool? az_ = context.Operators.Or(as_, ay_);
            Period ba_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
            CqlDateTime bc_ = context.Operators.End(bb_);
            CqlInterval<CqlDateTime> bd_ = this.Denominator_Identification_Period(context);
            CqlDateTime be_ = context.Operators.Start(bd_);
            CqlInterval<CqlDate> bf_ = this.Measure_Assessment_Period(context);
            CqlDate bg_ = context.Operators.End(bf_);
            CqlDateTime bh_ = context.Operators.ConvertDateToDateTime(bg_);
            CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(be_, bh_, true, true);
            bool? bj_ = context.Operators.In<CqlDateTime>(bc_, bi_, "day");
            bool? bk_ = context.Operators.And(az_, bj_);
            Code<Encounter.EncounterStatus> bl_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? bm_ = bl_?.Value;
            Code<Encounter.EncounterStatus> bn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bm_);
            bool? bo_ = context.Operators.Equal(bn_, "finished");
            bool? bp_ = context.Operators.And(bk_, bo_);
            return bp_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        bool? e_ = context.Operators.Exists<Encounter>(d_);
        CqlValueSet f_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? h_(Encounter HospiceEncounter) {
            Period bq_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
            CqlInterval<CqlDateTime> bs_ = this.Denominator_Identification_Period(context);
            CqlDateTime bt_ = context.Operators.Start(bs_);
            CqlInterval<CqlDate> bu_ = this.Measure_Assessment_Period(context);
            CqlDate bv_ = context.Operators.End(bu_);
            CqlDateTime bw_ = context.Operators.ConvertDateToDateTime(bv_);
            CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(bt_, bw_, true, true);
            bool? by_ = context.Operators.Overlaps(br_, bx_, "day");
            Code<Encounter.EncounterStatus> bz_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? ca_ = bz_?.Value;
            Code<Encounter.EncounterStatus> cb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ca_);
            string cc_ = context.Operators.Convert<string>(cb_);
            string[] cd_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            bool? ce_ = context.Operators.In<string>(cc_, (IEnumerable<string>)cd_);
            bool? cf_ = context.Operators.Not(ce_);
            bool? cg_ = context.Operators.And(by_, cf_);
            return cg_;
        }

        IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
        bool? j_ = context.Operators.Exists<Encounter>(i_);
        bool? k_ = context.Operators.Or(e_, j_);
        CqlCode l_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
        IEnumerable<Observation> n_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, m_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? o_(Observation HospiceAssessment) {
            DataType ch_ = HospiceAssessment?.Value;
            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
            CqlCode cj_ = this.Yes__qualifier_value_(context);
            CqlConcept ck_ = context.Operators.ConvertCodeToConcept(cj_);
            bool? cl_ = context.Operators.Equivalent(ci_ as CqlConcept, ck_);
            DataType cm_ = HospiceAssessment?.Effective;
            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
            CqlInterval<CqlDateTime> co_ = QICoreCommon_4_0_000.Instance.toInterval(context, cn_);
            CqlInterval<CqlDateTime> cp_ = this.Denominator_Identification_Period(context);
            CqlDateTime cq_ = context.Operators.Start(cp_);
            CqlInterval<CqlDate> cr_ = this.Measure_Assessment_Period(context);
            CqlDate cs_ = context.Operators.End(cr_);
            CqlDateTime ct_ = context.Operators.ConvertDateToDateTime(cs_);
            CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(cq_, ct_, true, true);
            bool? cv_ = context.Operators.Overlaps(co_, cu_, "day");
            bool? cw_ = context.Operators.And(cl_, cv_);
            Code<ObservationStatus> cx_ = HospiceAssessment?.StatusElement;
            ObservationStatus? cy_ = cx_?.Value;
            string cz_ = context.Operators.Convert<string>(cy_);
            string[] da_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? db_ = context.Operators.In<string>(cz_, (IEnumerable<string>)da_);
            bool? dc_ = context.Operators.And(cw_, db_);
            return dc_;
        }

        IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
        bool? q_ = context.Operators.Exists<Observation>(p_);
        bool? r_ = context.Operators.Or(k_, q_);
        CqlValueSet s_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> t_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? u_(ServiceRequest HospiceOrder) {
            FhirDateTime dd_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime de_ = context.Operators.Convert<CqlDateTime>(dd_);
            CqlInterval<CqlDateTime> df_ = this.Denominator_Identification_Period(context);
            CqlDateTime dg_ = context.Operators.Start(df_);
            CqlInterval<CqlDate> dh_ = this.Measure_Assessment_Period(context);
            CqlDate di_ = context.Operators.End(dh_);
            CqlDateTime dj_ = context.Operators.ConvertDateToDateTime(di_);
            CqlInterval<CqlDateTime> dk_ = context.Operators.Interval(dg_, dj_, true, true);
            bool? dl_ = context.Operators.In<CqlDateTime>(de_, dk_, "day");
            Code<RequestStatus> dm_ = HospiceOrder?.StatusElement;
            RequestStatus? dn_ = dm_?.Value;
            Code<RequestStatus> do_ = context.Operators.Convert<Code<RequestStatus>>(dn_);
            string dp_ = context.Operators.Convert<string>(do_);
            string[] dq_ = [
                "active",
                "completed",
            ];
            bool? dr_ = context.Operators.In<string>(dp_, (IEnumerable<string>)dq_);
            bool? ds_ = context.Operators.And(dl_, dr_);
            Code<RequestIntent> dt_ = HospiceOrder?.IntentElement;
            RequestIntent? du_ = dt_?.Value;
            Code<RequestIntent> dv_ = context.Operators.Convert<Code<RequestIntent>>(du_);
            string dw_ = context.Operators.Convert<string>(dv_);
            string[] dx_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? dy_ = context.Operators.In<string>(dw_, (IEnumerable<string>)dx_);
            bool? dz_ = context.Operators.And(ds_, dy_);
            return dz_;
        }

        IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
        bool? w_ = context.Operators.Exists<ServiceRequest>(v_);
        bool? x_ = context.Operators.Or(r_, w_);
        IEnumerable<Procedure> z_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? aa_(Procedure HospicePerformed) {

            object ea_() {

                bool eq_() {
                    DataType eu_ = HospicePerformed?.Performed;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    bool ew_ = ev_ is CqlDateTime;
                    return ew_;
                }


                bool er_() {
                    DataType ex_ = HospicePerformed?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlInterval<CqlDateTime>;
                    return ez_;
                }


                bool es_() {
                    DataType fa_ = HospicePerformed?.Performed;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    bool fc_ = fb_ is CqlQuantity;
                    return fc_;
                }


                bool et_() {
                    DataType fd_ = HospicePerformed?.Performed;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlInterval<CqlQuantity>;
                    return ff_;
                }

                if (eq_())
                {
                    DataType fg_ = HospicePerformed?.Performed;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    return (fh_ as CqlDateTime) as object;
                }
                else if (er_())
                {
                    DataType fi_ = HospicePerformed?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    return (fj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (es_())
                {
                    DataType fk_ = HospicePerformed?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    return (fl_ as CqlQuantity) as object;
                }
                else if (et_())
                {
                    DataType fm_ = HospicePerformed?.Performed;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    return (fn_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> eb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ea_());
            CqlInterval<CqlDateTime> ec_ = this.Denominator_Identification_Period(context);
            CqlDateTime ed_ = context.Operators.Start(ec_);
            CqlInterval<CqlDate> ee_ = this.Measure_Assessment_Period(context);
            CqlDate ef_ = context.Operators.End(ee_);
            CqlDateTime eg_ = context.Operators.ConvertDateToDateTime(ef_);
            CqlInterval<CqlDateTime> eh_ = context.Operators.Interval(ed_, eg_, true, true);
            bool? ei_ = context.Operators.Overlaps(eb_, eh_, "day");
            Code<EventStatus> ej_ = HospicePerformed?.StatusElement;
            EventStatus? ek_ = ej_?.Value;
            string el_ = context.Operators.Convert<string>(ek_);
            string[] em_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? en_ = context.Operators.In<string>(el_, (IEnumerable<string>)em_);
            bool? eo_ = context.Operators.Not(en_);
            bool? ep_ = context.Operators.And(ei_, eo_);
            return ep_;
        }

        IEnumerable<Procedure> ab_ = context.Operators.Where<Procedure>(z_, aa_);
        bool? ac_ = context.Operators.Exists<Procedure>(ab_);
        bool? ad_ = context.Operators.Or(x_, ac_);
        CqlValueSet ae_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> af_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> ah_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> ai_ = context.Operators.Union<object>(af_ as IEnumerable<object>, ah_ as IEnumerable<object>);

        bool? aj_(object HospiceCareDiagnosis) {
            CqlInterval<CqlDateTime> fo_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> fp_ = this.Denominator_Identification_Period(context);
            CqlDateTime fq_ = context.Operators.Start(fp_);
            CqlInterval<CqlDate> fr_ = this.Measure_Assessment_Period(context);
            CqlDate fs_ = context.Operators.End(fr_);
            CqlDateTime ft_ = context.Operators.ConvertDateToDateTime(fs_);
            CqlInterval<CqlDateTime> fu_ = context.Operators.Interval(fq_, ft_, true, true);
            bool? fv_ = context.Operators.Overlaps(fo_, fu_, "day");
            bool? fw_ = this.isVerified(context, HospiceCareDiagnosis);
            bool? fx_ = context.Operators.And(fv_, fw_);
            return fx_;
        }

        IEnumerable<object> ak_ = context.Operators.Where<object>(ai_, aj_);
        bool? al_ = context.Operators.Exists<object>(ak_);
        bool? am_ = context.Operators.Or(ad_, al_);
        return am_;
    }


    [CqlExpressionDefinition("Has Palliative Care prior to or during the Measure Assessment Period")]
    public bool? Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period, Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period_Compute);

    private const long _cacheIndex_Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period = -8447769728516516106L;

    private bool? Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period_Compute(CqlContext context)
    {
        CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation PalliativeAssessment) {
            DataType ab_ = PalliativeAssessment?.Effective;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
            CqlInterval<CqlDateTime> ae_ = this.Denominator_Identification_Period(context);
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlInterval<CqlDate> ag_ = this.Measure_Assessment_Period(context);
            CqlDate ah_ = context.Operators.End(ag_);
            CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(af_, ai_, true, true);
            bool? ak_ = context.Operators.Overlaps(ad_, aj_, "day");
            Code<ObservationStatus> al_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? am_ = al_?.Value;
            string an_ = context.Operators.Convert<string>(am_);
            string[] ao_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
            bool? aq_ = context.Operators.And(ak_, ap_);
            return aq_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        CqlValueSet g_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);

        bool? l_(object PalliativeDiagnosis) {
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> as_ = this.Denominator_Identification_Period(context);
            CqlDateTime at_ = context.Operators.Start(as_);
            CqlInterval<CqlDate> au_ = this.Measure_Assessment_Period(context);
            CqlDate av_ = context.Operators.End(au_);
            CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
            CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(at_, aw_, true, true);
            bool? ay_ = context.Operators.Overlaps(ar_, ax_, "day");
            bool? az_ = this.isVerified(context, PalliativeDiagnosis);
            bool? ba_ = context.Operators.And(ay_, az_);
            return ba_;
        }

        IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
        bool? n_ = context.Operators.Exists<object>(m_);
        bool? o_ = context.Operators.Or(f_, n_);
        CqlValueSet p_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? r_(Encounter PalliativeEncounter) {
            Period bb_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
            CqlInterval<CqlDateTime> bd_ = this.Denominator_Identification_Period(context);
            CqlDateTime be_ = context.Operators.Start(bd_);
            CqlInterval<CqlDate> bf_ = this.Measure_Assessment_Period(context);
            CqlDate bg_ = context.Operators.End(bf_);
            CqlDateTime bh_ = context.Operators.ConvertDateToDateTime(bg_);
            CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(be_, bh_, true, true);
            bool? bj_ = context.Operators.Overlaps(bc_, bi_, "day");
            Code<Encounter.EncounterStatus> bk_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? bl_ = bk_?.Value;
            Code<Encounter.EncounterStatus> bm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bl_);
            bool? bn_ = context.Operators.Equal(bm_, "finished");
            bool? bo_ = context.Operators.And(bj_, bn_);
            return bo_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
        bool? t_ = context.Operators.Exists<Encounter>(s_);
        bool? u_ = context.Operators.Or(o_, t_);
        CqlValueSet v_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> w_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? x_(Procedure PalliativeIntervention) {

            object bp_() {

                bool cf_() {
                    DataType cj_ = PalliativeIntervention?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlDateTime;
                    return cl_;
                }


                bool cg_() {
                    DataType cm_ = PalliativeIntervention?.Performed;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlInterval<CqlDateTime>;
                    return co_;
                }


                bool ch_() {
                    DataType cp_ = PalliativeIntervention?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlQuantity;
                    return cr_;
                }


                bool ci_() {
                    DataType cs_ = PalliativeIntervention?.Performed;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    bool cu_ = ct_ is CqlInterval<CqlQuantity>;
                    return cu_;
                }

                if (cf_())
                {
                    DataType cv_ = PalliativeIntervention?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlDateTime) as object;
                }
                else if (cg_())
                {
                    DataType cx_ = PalliativeIntervention?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return (cy_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ch_())
                {
                    DataType cz_ = PalliativeIntervention?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    return (da_ as CqlQuantity) as object;
                }
                else if (ci_())
                {
                    DataType db_ = PalliativeIntervention?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    return (dc_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_());
            CqlInterval<CqlDateTime> br_ = this.Denominator_Identification_Period(context);
            CqlDateTime bs_ = context.Operators.Start(br_);
            CqlInterval<CqlDate> bt_ = this.Measure_Assessment_Period(context);
            CqlDate bu_ = context.Operators.End(bt_);
            CqlDateTime bv_ = context.Operators.ConvertDateToDateTime(bu_);
            CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bs_, bv_, true, true);
            bool? bx_ = context.Operators.Overlaps(bq_, bw_, "day");
            Code<EventStatus> by_ = PalliativeIntervention?.StatusElement;
            EventStatus? bz_ = by_?.Value;
            string ca_ = context.Operators.Convert<string>(bz_);
            string[] cb_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);
            bool? cd_ = context.Operators.Not(cc_);
            bool? ce_ = context.Operators.And(bx_, cd_);
            return ce_;
        }

        IEnumerable<Procedure> y_ = context.Operators.Where<Procedure>(w_, x_);
        bool? z_ = context.Operators.Exists<Procedure>(y_);
        bool? aa_ = context.Operators.Or(u_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Patient Expired")]
    public bool? Patient_Expired(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Expired, Patient_Expired_Compute);

    private const long _cacheIndex_Patient_Expired = -1624622703135801016L;

    private bool? Patient_Expired_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        DataType b_ = a_?.Deceased;
        object c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
        CqlInterval<CqlDate> d_ = this.Measure_Assessment_Period(context);
        CqlDate e_ = context.Operators.End(d_);
        CqlDateTime f_ = context.Operators.ConvertDateToDateTime(e_);
        bool? g_ = context.Operators.SameOrBefore(c_ as CqlDateTime, f_, "day");
        return g_;
    }


    [CqlExpressionDefinition("Has Mental Health Disorder Diagnoses")]
    public bool? Has_Mental_Health_Disorder_Diagnoses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Mental_Health_Disorder_Diagnoses, Has_Mental_Health_Disorder_Diagnoses_Compute);

    private const long _cacheIndex_Has_Mental_Health_Disorder_Diagnoses = 3318310671059399184L;

    private bool? Has_Mental_Health_Disorder_Diagnoses_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        CqlValueSet f_ = this.Personality_Disorder_Emotionally_Labile(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
        IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);
        CqlValueSet l_ = this.Schizophrenia_or_Psychotic_Disorder(context);
        IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> n_ = context.Operators.Union<object>(k_ as IEnumerable<object>, m_ as IEnumerable<object>);
        IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> q_ = context.Operators.Union<object>(n_ as IEnumerable<object>, p_ as IEnumerable<object>);
        CqlValueSet r_ = this.Pervasive_Developmental_Disorder(context);
        IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> t_ = context.Operators.Union<object>(q_ as IEnumerable<object>, s_ as IEnumerable<object>);
        IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> w_ = context.Operators.Union<object>(t_ as IEnumerable<object>, v_ as IEnumerable<object>);

        bool? x_(object MentalHealthDisorderDiagnoses) {
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlInterval<CqlDate> ac_ = this.Measure_Assessment_Period(context);
            CqlDate ad_ = context.Operators.End(ac_);
            CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
            bool? af_ = context.Operators.SameOrBefore(ab_, ae_, "day");
            bool? ag_ = this.isVerified(context, MentalHealthDisorderDiagnoses);
            bool? ah_ = context.Operators.And(af_, ag_);
            return ah_;
        }

        IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
        bool? z_ = context.Operators.Exists<object>(y_);
        return z_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2559139784615991071L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period(context);
        bool? b_ = this.Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Patient_Expired(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_Mental_Health_Disorder_Diagnoses(context);
        bool? g_ = context.Operators.Or(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 1707994593624416448L;

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? c_(Observation DepressionAssessment) {
            DataType k_ = DepressionAssessment?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlInterval<CqlDate> o_ = this.Measure_Assessment_Period(context);
            CqlDate p_ = o_?.low;
            CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
            CqlDate s_ = o_?.high;
            CqlDateTime t_ = context.Operators.ConvertDateToDateTime(s_);
            bool? v_ = o_?.lowClosed;
            bool? x_ = o_?.highClosed;
            CqlInterval<CqlDateTime> y_ = context.Operators.Interval(q_, t_, v_, x_);
            bool? z_ = context.Operators.In<CqlDateTime>(n_, y_, "day");
            Code<ObservationStatus> aa_ = DepressionAssessment?.StatusElement;
            ObservationStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
            bool? af_ = context.Operators.And(z_, ae_);
            return af_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType ag_ = @this?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            return aj_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        bool? j_ = context.Operators.Less(i_ as int?, 5);
        return j_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4985592431128511125L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 4176559840175856802L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -7339446756539217987L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -1428577257306360309L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = 1010167823931080299L;

    private bool? Stratification_1_Compute(CqlContext context)
    {
        Observation a_ = this.Index_Depression_Assessment(context);
        Observation[] b_ = [
            a_,
        ];

        bool? c_(Observation IndexAssessment) {
            Patient g_ = this.Patient(context);
            Date h_ = g_?.BirthDateElement;
            string i_ = h_?.Value;
            CqlDate j_ = context.Operators.ConvertStringToDate(i_);
            DataType k_ = IndexAssessment?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            int? p_ = context.Operators.CalculateAgeAt(j_, o_, "year");
            CqlInterval<int?> q_ = context.Operators.Interval(12, 17, true, true);
            bool? r_ = context.Operators.In<int?>(p_, q_, (string)default);
            return r_;
        }

        IEnumerable<bool?> d_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)b_, c_);
        IEnumerable<bool?> e_ = context.Operators.Distinct<bool?>(d_);
        bool? f_ = context.Operators.SingletonFrom<bool?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -7436411683980352410L;

    private bool? Stratification_2_Compute(CqlContext context)
    {
        Observation a_ = this.Index_Depression_Assessment(context);
        Observation[] b_ = [
            a_,
        ];

        bool? c_(Observation IndexAssessment) {
            Patient g_ = this.Patient(context);
            Date h_ = g_?.BirthDateElement;
            string i_ = h_?.Value;
            CqlDate j_ = context.Operators.ConvertStringToDate(i_);
            DataType k_ = IndexAssessment?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            int? p_ = context.Operators.CalculateAgeAt(j_, o_, "year");
            bool? q_ = context.Operators.GreaterOrEqual(p_, 18);
            return q_;
        }

        IEnumerable<bool?> d_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)b_, c_);
        IEnumerable<bool?> e_ = context.Operators.Distinct<bool?>(d_);
        bool? f_ = context.Operators.SingletonFrom<bool?>(e_);
        return f_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS159FHIRDepRemissionat12Months_1_0_000() {}

    public static CMS159FHIRDepRemissionat12Months_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS159FHIRDepRemissionat12Months";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
