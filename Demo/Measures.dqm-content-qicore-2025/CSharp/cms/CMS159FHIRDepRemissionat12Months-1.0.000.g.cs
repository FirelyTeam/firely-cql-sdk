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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 4515960621490826425L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS159FHIRDepRemissionat12Months-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (22)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -5174828440479377737L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Depression Assessments Greater Than 9")]
    public IEnumerable<Observation?>? Depression_Assessments_Greater_Than_9(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Depression_Assessments_Greater_Than_9, Depression_Assessments_Greater_Than_9_Compute);

    private const long _cacheIndex_Depression_Assessments_Greater_Than_9 = -2809144784699197651L;

    private IEnumerable<Observation?>? Depression_Assessments_Greater_Than_9_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? c_(Observation? DepressionAssessment) {
            DataType? e_ = DepressionAssessment?.Value;
            object? f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Greater(f_ as int?, 9);
            Code<ObservationStatus>? h_ = DepressionAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string? j_ = context.Operators.Convert<string>(i_);
            string?[]? k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string?>?)k_);
            bool? m_ = context.Operators.And(g_, l_);
            return m_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition? condition)
    {
        CodeableConcept? a_ = condition?.VerificationStatus;
        CqlConcept? b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode? d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept? e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode? g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept? h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode? k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept? l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode? o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept? p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Depression Diagnoses")]
    public IEnumerable<Condition?>? Depression_Diagnoses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Depression_Diagnoses, Depression_Diagnoses_Compute);

    private const long _cacheIndex_Depression_Diagnoses = 5150113982553371070L;

    private IEnumerable<Condition?>? Depression_Diagnoses_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Major_Depression_Including_Remission(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition?>?, c_ as IEnumerable<Condition?>?);
        CqlValueSet? e_ = this.Dysthymia(context);
        IEnumerable<Condition?>? f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition?>?, f_ as IEnumerable<Condition?>?);
        IEnumerable<Condition?>? h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition?>?, h_ as IEnumerable<Condition?>?);

        bool? j_(Condition? Depression) {
            bool? l_ = this.isVerified(context, Depression);
            return l_;
        }

        IEnumerable<Condition?>? k_ = context.Operators.Where<Condition>(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Denominator Identification Period")]
    public CqlInterval<CqlDateTime?>? Denominator_Identification_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Identification_Period, Denominator_Identification_Period_Compute);

    private const long _cacheIndex_Denominator_Identification_Period = 721024531417181386L;

    private CqlInterval<CqlDateTime?>? Denominator_Identification_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime?>? a_ = this.Measurement_Period(context);
        CqlDateTime? b_ = context.Operators.Start(a_);
        CqlQuantity? c_ = context.Operators.Quantity(14m, "months");
        CqlDateTime? d_ = context.Operators.Subtract(b_, c_);
        CqlQuantity? e_ = context.Operators.Quantity(2m, "months");
        CqlDateTime? f_ = context.Operators.Subtract(b_, e_);
        CqlInterval<CqlDateTime?>? g_ = context.Operators.Interval(d_, f_, true, false);
        return g_;
    }


    [CqlExpressionDefinition("Depression Encounter")]
    public IEnumerable<Encounter?>? Depression_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Depression_Encounter, Depression_Encounter_Compute);

    private const long _cacheIndex_Depression_Encounter = 4681658861661132345L;

    private IEnumerable<Encounter?>? Depression_Encounter_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Contact_or_Office_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? ValidEncounter) {
            IEnumerable<Condition?>? e_ = this.Depression_Diagnoses(context);

            bool? f_(Condition? Depression) {
                Period? h_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Depression);
                bool? k_ = context.Operators.Overlaps(i_, j_, (string)default);
                CqlDateTime? l_ = context.Operators.End(i_);
                CqlInterval<CqlDateTime?>? m_ = this.Denominator_Identification_Period(context);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
                bool? o_ = context.Operators.And(k_, n_);
                Code<Encounter.EncounterStatus>? p_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? q_ = p_?.Value;
                Code<Encounter.EncounterStatus>? r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
                bool? s_ = context.Operators.Equal(r_, "finished");
                bool? t_ = context.Operators.And(o_, s_);
                return t_;
            }

            bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Index Depression Assessment")]
    public Observation? Index_Depression_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Index_Depression_Assessment, Index_Depression_Assessment_Compute);

    private const long _cacheIndex_Index_Depression_Assessment = 499571989574502589L;

    private Observation? Index_Depression_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.Depression_Assessments_Greater_Than_9(context);

        bool? b_(Observation? DepressionAssessment) {
            IEnumerable<Encounter?>? g_ = this.Depression_Encounter(context);

            bool? h_(Encounter? DepressionEncounter) {
                Period? j_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime?>? k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime? l_ = context.Operators.Start(k_);
                CqlQuantity? m_ = context.Operators.Quantity(7m, "days");
                CqlDateTime? n_ = context.Operators.Subtract(l_, m_);
                CqlDateTime? o_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(n_, o_, true, true);
                DataType? q_ = DepressionAssessment?.Effective;
                object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime?>? s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, "day");
                return t_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Observation?>? c_ = context.Operators.Where<Observation>(a_, b_);

        object? d_(Observation? @this) {
            DataType? u_ = @this?.Effective;
            object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            return x_;
        }

        IEnumerable<Observation?>? e_ = context.Operators.SortBy<Observation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? f_ = context.Operators.First<Observation>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -677507915104673588L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDateTime? d_ = context.Operators.ConvertStringToDateTime(c_);
        Observation? e_ = this.Index_Depression_Assessment(context);
        DataType? f_ = e_?.Effective;
        object? g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
        CqlInterval<CqlDateTime?>? h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
        CqlDateTime? i_ = context.Operators.Start(h_);
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
    public CqlInterval<CqlDate?>? Measure_Assessment_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measure_Assessment_Period, Measure_Assessment_Period_Compute);

    private const long _cacheIndex_Measure_Assessment_Period = -6986502766962251939L;

    private CqlInterval<CqlDate?>? Measure_Assessment_Period_Compute(CqlContext context)
    {
        Observation? a_ = this.Index_Depression_Assessment(context);
        Observation?[]? b_ = [
            a_,
        ];

        CqlInterval<CqlDate?>? c_(Observation? FirstIndexAssessment) {
            DataType? f_ = FirstIndexAssessment?.Effective;
            object? g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime?>? h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
            CqlDateTime? i_ = context.Operators.Start(h_);
            CqlDate? j_ = context.Operators.DateFrom(i_);
            CqlQuantity? k_ = context.Operators.Quantity(12m, "months");
            CqlDate? l_ = context.Operators.Add(j_, k_);
            CqlQuantity? m_ = context.Operators.Quantity(60m, "days");
            CqlDate? n_ = context.Operators.Subtract(l_, m_);
            CqlDate? o_ = context.Operators.Add(l_, m_);
            CqlInterval<CqlDate?>? p_ = context.Operators.Interval(n_, o_, true, true);
            return p_;
        }

        IEnumerable<CqlInterval<CqlDate?>?>? d_ = context.Operators.SelectDistinct<Observation, CqlInterval<CqlDate>>((IEnumerable<Observation?>?)b_, c_);
        CqlInterval<CqlDate?>? e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Has Hospice Services prior to or during the Measure Assessment Period")]
    public bool? Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period, Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period_Compute);

    private const long _cacheIndex_Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period = 7215323320960060348L;

    private bool? Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? InpatientEncounter) {
            Encounter.HospitalizationComponent? af_ = InpatientEncounter?.Hospitalization;
            CodeableConcept? ag_ = af_?.DischargeDisposition;
            CqlConcept? ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_);
            CqlCode? ai_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept? aj_ = context.Operators.ConvertCodeToConcept(ai_);
            bool? ak_ = context.Operators.Equivalent(ah_, aj_);
            CqlCode? al_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept? am_ = context.Operators.ConvertCodeToConcept(al_);
            bool? an_ = context.Operators.Equivalent(ah_, am_);
            bool? ao_ = context.Operators.Or(ak_, an_);
            Period? ap_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime?>? aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
            CqlDateTime? ar_ = context.Operators.End(aq_);
            CqlInterval<CqlDateTime?>? as_ = this.Denominator_Identification_Period(context);
            CqlDateTime? at_ = context.Operators.Start(as_);
            CqlInterval<CqlDate?>? au_ = this.Measure_Assessment_Period(context);
            CqlDate? av_ = context.Operators.End(au_);
            CqlDateTime? aw_ = context.Operators.ConvertDateToDateTime(av_);
            CqlInterval<CqlDateTime?>? ax_ = context.Operators.Interval(at_, aw_, true, true);
            bool? ay_ = context.Operators.In<CqlDateTime>(ar_, ax_, "day");
            bool? az_ = context.Operators.And(ao_, ay_);
            Code<Encounter.EncounterStatus>? ba_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? bb_ = ba_?.Value;
            Code<Encounter.EncounterStatus>? bc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bb_);
            bool? bd_ = context.Operators.Equal(bc_, "finished");
            bool? be_ = context.Operators.And(az_, bd_);
            return be_;
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        CqlValueSet? e_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter?>? f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? g_(Encounter? HospiceEncounter) {
            Period? bf_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime?>? bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
            CqlInterval<CqlDateTime?>? bh_ = this.Denominator_Identification_Period(context);
            CqlDateTime? bi_ = context.Operators.Start(bh_);
            CqlInterval<CqlDate?>? bj_ = this.Measure_Assessment_Period(context);
            CqlDate? bk_ = context.Operators.End(bj_);
            CqlDateTime? bl_ = context.Operators.ConvertDateToDateTime(bk_);
            CqlInterval<CqlDateTime?>? bm_ = context.Operators.Interval(bi_, bl_, true, true);
            bool? bn_ = context.Operators.Overlaps(bg_, bm_, "day");
            Code<Encounter.EncounterStatus>? bo_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? bp_ = bo_?.Value;
            Code<Encounter.EncounterStatus>? bq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bp_);
            string? br_ = context.Operators.Convert<string>(bq_);
            string?[]? bs_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            bool? bt_ = context.Operators.In<string>(br_, (IEnumerable<string?>?)bs_);
            bool? bu_ = context.Operators.Not(bt_);
            bool? bv_ = context.Operators.And(bn_, bu_);
            return bv_;
        }

        bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
        bool? i_ = context.Operators.Or(d_, h_);
        CqlCode? j_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode?>? k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Observation?>? l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? m_(Observation? HospiceAssessment) {
            DataType? bw_ = HospiceAssessment?.Value;
            object? bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
            CqlCode? by_ = this.Yes__qualifier_value_(context);
            CqlConcept? bz_ = context.Operators.ConvertCodeToConcept(by_);
            bool? ca_ = context.Operators.Equivalent(bx_ as CqlConcept?, bz_);
            DataType? cb_ = HospiceAssessment?.Effective;
            object? cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
            CqlInterval<CqlDateTime?>? cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
            CqlInterval<CqlDateTime?>? ce_ = this.Denominator_Identification_Period(context);
            CqlDateTime? cf_ = context.Operators.Start(ce_);
            CqlInterval<CqlDate?>? cg_ = this.Measure_Assessment_Period(context);
            CqlDate? ch_ = context.Operators.End(cg_);
            CqlDateTime? ci_ = context.Operators.ConvertDateToDateTime(ch_);
            CqlInterval<CqlDateTime?>? cj_ = context.Operators.Interval(cf_, ci_, true, true);
            bool? ck_ = context.Operators.Overlaps(cd_, cj_, "day");
            bool? cl_ = context.Operators.And(ca_, ck_);
            Code<ObservationStatus>? cm_ = HospiceAssessment?.StatusElement;
            ObservationStatus? cn_ = cm_?.Value;
            string? co_ = context.Operators.Convert<string>(cn_);
            string?[]? cp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? cq_ = context.Operators.In<string>(co_, (IEnumerable<string?>?)cp_);
            bool? cr_ = context.Operators.And(cl_, cq_);
            return cr_;
        }

        bool? n_ = context.Operators.WhereAny<Observation>(l_, m_);
        bool? o_ = context.Operators.Or(i_, n_);
        CqlValueSet? p_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest?>? q_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? r_(ServiceRequest? HospiceOrder) {
            FhirDateTime? cs_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime? ct_ = context.Operators.Convert<CqlDateTime>(cs_);
            CqlInterval<CqlDateTime?>? cu_ = this.Denominator_Identification_Period(context);
            CqlDateTime? cv_ = context.Operators.Start(cu_);
            CqlInterval<CqlDate?>? cw_ = this.Measure_Assessment_Period(context);
            CqlDate? cx_ = context.Operators.End(cw_);
            CqlDateTime? cy_ = context.Operators.ConvertDateToDateTime(cx_);
            CqlInterval<CqlDateTime?>? cz_ = context.Operators.Interval(cv_, cy_, true, true);
            bool? da_ = context.Operators.In<CqlDateTime>(ct_, cz_, "day");
            Code<RequestStatus>? db_ = HospiceOrder?.StatusElement;
            RequestStatus? dc_ = db_?.Value;
            Code<RequestStatus>? dd_ = context.Operators.Convert<Code<RequestStatus>>(dc_);
            string? de_ = context.Operators.Convert<string>(dd_);
            string?[]? df_ = [
                "active",
                "completed",
            ];
            bool? dg_ = context.Operators.In<string>(de_, (IEnumerable<string?>?)df_);
            bool? dh_ = context.Operators.And(da_, dg_);
            Code<RequestIntent>? di_ = HospiceOrder?.IntentElement;
            RequestIntent? dj_ = di_?.Value;
            Code<RequestIntent>? dk_ = context.Operators.Convert<Code<RequestIntent>>(dj_);
            string? dl_ = context.Operators.Convert<string>(dk_);
            string?[]? dm_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? dn_ = context.Operators.In<string>(dl_, (IEnumerable<string?>?)dm_);
            bool? do_ = context.Operators.And(dh_, dn_);
            return do_;
        }

        bool? s_ = context.Operators.WhereAny<ServiceRequest>(q_, r_);
        bool? t_ = context.Operators.Or(o_, s_);
        IEnumerable<Procedure?>? u_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? v_(Procedure? HospicePerformed) {
            object? dp_;
            DataType? ef_ = HospicePerformed?.Performed;
            object? eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
            bool eh_ = eg_ is CqlDateTime;
            if (eh_)
            {
                DataType? ei_ = HospicePerformed?.Performed;
                object? ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                dp_ = ej_ as CqlDateTime?;
            }
            else
            {
                DataType? ek_ = HospicePerformed?.Performed;
                object? el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlQuantity;
                if (em_)
                {
                    DataType? en_ = HospicePerformed?.Performed;
                    object? eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    dp_ = eo_ as CqlQuantity?;
                }
                else
                {
                    DataType? ep_ = HospicePerformed?.Performed;
                    object? eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlInterval<CqlDateTime>;
                    if (er_)
                    {
                        DataType? es_ = HospicePerformed?.Performed;
                        object? et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        dp_ = et_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? eu_ = HospicePerformed?.Performed;
                        object? ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        bool ew_ = ev_ is CqlInterval<CqlQuantity>;
                        if (ew_)
                        {
                            DataType? ex_ = HospicePerformed?.Performed;
                            object? ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            dp_ = ey_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            dp_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? dq_ = QICoreCommon_4_0_000.Instance.toInterval(context, dp_);
            CqlInterval<CqlDateTime?>? dr_ = this.Denominator_Identification_Period(context);
            CqlDateTime? ds_ = context.Operators.Start(dr_);
            CqlInterval<CqlDate?>? dt_ = this.Measure_Assessment_Period(context);
            CqlDate? du_ = context.Operators.End(dt_);
            CqlDateTime? dv_ = context.Operators.ConvertDateToDateTime(du_);
            CqlInterval<CqlDateTime?>? dw_ = context.Operators.Interval(ds_, dv_, true, true);
            bool? dx_ = context.Operators.Overlaps(dq_, dw_, "day");
            Code<EventStatus>? dy_ = HospicePerformed?.StatusElement;
            EventStatus? dz_ = dy_?.Value;
            string? ea_ = context.Operators.Convert<string>(dz_);
            string?[]? eb_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? ec_ = context.Operators.In<string>(ea_, (IEnumerable<string?>?)eb_);
            bool? ed_ = context.Operators.Not(ec_);
            bool? ee_ = context.Operators.And(dx_, ed_);
            return ee_;
        }

        bool? w_ = context.Operators.WhereAny<Procedure>(u_, v_);
        bool? x_ = context.Operators.Or(t_, w_);
        CqlValueSet? y_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition?>? z_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? aa_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? ab_ = context.Operators.Union<Condition>(z_ as IEnumerable<Condition?>?, aa_ as IEnumerable<Condition?>?);

        bool? ac_(Condition? HospiceCareDiagnosis) {
            CqlInterval<CqlDateTime?>? ez_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime?>? fa_ = this.Denominator_Identification_Period(context);
            CqlDateTime? fb_ = context.Operators.Start(fa_);
            CqlInterval<CqlDate?>? fc_ = this.Measure_Assessment_Period(context);
            CqlDate? fd_ = context.Operators.End(fc_);
            CqlDateTime? fe_ = context.Operators.ConvertDateToDateTime(fd_);
            CqlInterval<CqlDateTime?>? ff_ = context.Operators.Interval(fb_, fe_, true, true);
            bool? fg_ = context.Operators.Overlaps(ez_, ff_, "day");
            bool? fh_ = this.isVerified(context, HospiceCareDiagnosis);
            bool? fi_ = context.Operators.And(fg_, fh_);
            return fi_;
        }

        bool? ad_ = context.Operators.WhereAny<Condition>(ab_, ac_);
        bool? ae_ = context.Operators.Or(x_, ad_);
        return ae_;
    }


    [CqlExpressionDefinition("Has Palliative Care prior to or during the Measure Assessment Period")]
    public bool? Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period, Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period_Compute);

    private const long _cacheIndex_Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period = -8447769728516516106L;

    private bool? Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation? PalliativeAssessment) {
            DataType? w_ = PalliativeAssessment?.Effective;
            object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime?>? y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            CqlInterval<CqlDateTime?>? z_ = this.Denominator_Identification_Period(context);
            CqlDateTime? aa_ = context.Operators.Start(z_);
            CqlInterval<CqlDate?>? ab_ = this.Measure_Assessment_Period(context);
            CqlDate? ac_ = context.Operators.End(ab_);
            CqlDateTime? ad_ = context.Operators.ConvertDateToDateTime(ac_);
            CqlInterval<CqlDateTime?>? ae_ = context.Operators.Interval(aa_, ad_, true, true);
            bool? af_ = context.Operators.Overlaps(y_, ae_, "day");
            Code<ObservationStatus>? ag_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? ah_ = ag_?.Value;
            string? ai_ = context.Operators.Convert<string>(ah_);
            string?[]? aj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ak_ = context.Operators.In<string>(ai_, (IEnumerable<string?>?)aj_);
            bool? al_ = context.Operators.And(af_, ak_);
            return al_;
        }

        bool? e_ = context.Operators.WhereAny<Observation>(c_, d_);
        CqlValueSet? f_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition?>? g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition?>?, h_ as IEnumerable<Condition?>?);

        bool? j_(Condition? PalliativeDiagnosis) {
            CqlInterval<CqlDateTime?>? am_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime?>? an_ = this.Denominator_Identification_Period(context);
            CqlDateTime? ao_ = context.Operators.Start(an_);
            CqlInterval<CqlDate?>? ap_ = this.Measure_Assessment_Period(context);
            CqlDate? aq_ = context.Operators.End(ap_);
            CqlDateTime? ar_ = context.Operators.ConvertDateToDateTime(aq_);
            CqlInterval<CqlDateTime?>? as_ = context.Operators.Interval(ao_, ar_, true, true);
            bool? at_ = context.Operators.Overlaps(am_, as_, "day");
            bool? au_ = this.isVerified(context, PalliativeDiagnosis);
            bool? av_ = context.Operators.And(at_, au_);
            return av_;
        }

        bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
        bool? l_ = context.Operators.Or(e_, k_);
        CqlValueSet? m_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter?>? n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? o_(Encounter? PalliativeEncounter) {
            Period? aw_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime?>? ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
            CqlInterval<CqlDateTime?>? ay_ = this.Denominator_Identification_Period(context);
            CqlDateTime? az_ = context.Operators.Start(ay_);
            CqlInterval<CqlDate?>? ba_ = this.Measure_Assessment_Period(context);
            CqlDate? bb_ = context.Operators.End(ba_);
            CqlDateTime? bc_ = context.Operators.ConvertDateToDateTime(bb_);
            CqlInterval<CqlDateTime?>? bd_ = context.Operators.Interval(az_, bc_, true, true);
            bool? be_ = context.Operators.Overlaps(ax_, bd_, "day");
            Code<Encounter.EncounterStatus>? bf_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? bg_ = bf_?.Value;
            Code<Encounter.EncounterStatus>? bh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bg_);
            bool? bi_ = context.Operators.Equal(bh_, "finished");
            bool? bj_ = context.Operators.And(be_, bi_);
            return bj_;
        }

        bool? p_ = context.Operators.WhereAny<Encounter>(n_, o_);
        bool? q_ = context.Operators.Or(l_, p_);
        CqlValueSet? r_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure?>? s_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? t_(Procedure? PalliativeIntervention) {
            object? bk_;
            DataType? ca_ = PalliativeIntervention?.Performed;
            object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
            bool cc_ = cb_ is CqlDateTime;
            if (cc_)
            {
                DataType? cd_ = PalliativeIntervention?.Performed;
                object? ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                bk_ = ce_ as CqlDateTime?;
            }
            else
            {
                DataType? cf_ = PalliativeIntervention?.Performed;
                object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                bool ch_ = cg_ is CqlQuantity;
                if (ch_)
                {
                    DataType? ci_ = PalliativeIntervention?.Performed;
                    object? cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bk_ = cj_ as CqlQuantity?;
                }
                else
                {
                    DataType? ck_ = PalliativeIntervention?.Performed;
                    object? cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlInterval<CqlDateTime>;
                    if (cm_)
                    {
                        DataType? cn_ = PalliativeIntervention?.Performed;
                        object? co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        bk_ = co_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? cp_ = PalliativeIntervention?.Performed;
                        object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        bool cr_ = cq_ is CqlInterval<CqlQuantity>;
                        if (cr_)
                        {
                            DataType? cs_ = PalliativeIntervention?.Performed;
                            object? ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            bk_ = ct_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            bk_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
            CqlInterval<CqlDateTime?>? bm_ = this.Denominator_Identification_Period(context);
            CqlDateTime? bn_ = context.Operators.Start(bm_);
            CqlInterval<CqlDate?>? bo_ = this.Measure_Assessment_Period(context);
            CqlDate? bp_ = context.Operators.End(bo_);
            CqlDateTime? bq_ = context.Operators.ConvertDateToDateTime(bp_);
            CqlInterval<CqlDateTime?>? br_ = context.Operators.Interval(bn_, bq_, true, true);
            bool? bs_ = context.Operators.Overlaps(bl_, br_, "day");
            Code<EventStatus>? bt_ = PalliativeIntervention?.StatusElement;
            EventStatus? bu_ = bt_?.Value;
            string? bv_ = context.Operators.Convert<string>(bu_);
            string?[]? bw_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? bx_ = context.Operators.In<string>(bv_, (IEnumerable<string?>?)bw_);
            bool? by_ = context.Operators.Not(bx_);
            bool? bz_ = context.Operators.And(bs_, by_);
            return bz_;
        }

        bool? u_ = context.Operators.WhereAny<Procedure>(s_, t_);
        bool? v_ = context.Operators.Or(q_, u_);
        return v_;
    }


    [CqlExpressionDefinition("Patient Expired")]
    public bool? Patient_Expired(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Expired, Patient_Expired_Compute);

    private const long _cacheIndex_Patient_Expired = -1624622703135801016L;

    private bool? Patient_Expired_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        DataType? b_ = a_?.Deceased;
        object? c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
        CqlInterval<CqlDate?>? d_ = this.Measure_Assessment_Period(context);
        CqlDate? e_ = context.Operators.End(d_);
        CqlDateTime? f_ = context.Operators.ConvertDateToDateTime(e_);
        bool? g_ = context.Operators.SameOrBefore(c_ as CqlDateTime?, f_, "day");
        return g_;
    }


    [CqlExpressionDefinition("Has Mental Health Disorder Diagnoses")]
    public bool? Has_Mental_Health_Disorder_Diagnoses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Mental_Health_Disorder_Diagnoses, Has_Mental_Health_Disorder_Diagnoses_Compute);

    private const long _cacheIndex_Has_Mental_Health_Disorder_Diagnoses = 3318310671059399184L;

    private bool? Has_Mental_Health_Disorder_Diagnoses_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition?>?, c_ as IEnumerable<Condition?>?);
        CqlValueSet? e_ = this.Personality_Disorder_Emotionally_Labile(context);
        IEnumerable<Condition?>? f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition?>?, f_ as IEnumerable<Condition?>?);
        IEnumerable<Condition?>? h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition?>?, h_ as IEnumerable<Condition?>?);
        CqlValueSet? j_ = this.Schizophrenia_or_Psychotic_Disorder(context);
        IEnumerable<Condition?>? k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? l_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition?>?, k_ as IEnumerable<Condition?>?);
        IEnumerable<Condition?>? m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? n_ = context.Operators.Union<Condition>(l_ as IEnumerable<Condition?>?, m_ as IEnumerable<Condition?>?);
        CqlValueSet? o_ = this.Pervasive_Developmental_Disorder(context);
        IEnumerable<Condition?>? p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? q_ = context.Operators.Union<Condition>(n_ as IEnumerable<Condition?>?, p_ as IEnumerable<Condition?>?);
        IEnumerable<Condition?>? r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? s_ = context.Operators.Union<Condition>(q_ as IEnumerable<Condition?>?, r_ as IEnumerable<Condition?>?);

        bool? t_(Condition? MentalHealthDisorderDiagnoses) {
            CqlInterval<CqlDateTime?>? v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime? w_ = context.Operators.Start(v_);
            CqlInterval<CqlDate?>? x_ = this.Measure_Assessment_Period(context);
            CqlDate? y_ = context.Operators.End(x_);
            CqlDateTime? z_ = context.Operators.ConvertDateToDateTime(y_);
            bool? aa_ = context.Operators.SameOrBefore(w_, z_, "day");
            bool? ab_ = this.isVerified(context, MentalHealthDisorderDiagnoses);
            bool? ac_ = context.Operators.And(aa_, ab_);
            return ac_;
        }

        bool? u_ = context.Operators.WhereAny<Condition>(s_, t_);
        return u_;
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
        CqlValueSet? a_ = this.PHQ_9_and_PHQ_9M_Tools(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? c_(Observation? DepressionAssessment) {
            DataType? k_ = DepressionAssessment?.Effective;
            object? l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            CqlDateTime? n_ = context.Operators.Start(m_);
            CqlInterval<CqlDate?>? o_ = this.Measure_Assessment_Period(context);
            CqlDate? p_ = o_?.low;
            CqlDateTime? q_ = context.Operators.ConvertDateToDateTime(p_);
            CqlDate? r_ = o_?.high;
            CqlDateTime? s_ = context.Operators.ConvertDateToDateTime(r_);
            bool? t_ = o_?.lowClosed;
            bool? u_ = o_?.highClosed;
            CqlInterval<CqlDateTime?>? v_ = context.Operators.Interval(q_, s_, t_, u_);
            bool? w_ = context.Operators.In<CqlDateTime>(n_, v_, "day");
            Code<ObservationStatus>? x_ = DepressionAssessment?.StatusElement;
            ObservationStatus? y_ = x_?.Value;
            string? z_ = context.Operators.Convert<string>(y_);
            string?[]? aa_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string?>?)aa_);
            bool? ac_ = context.Operators.And(w_, ab_);
            return ac_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation>(b_, c_);

        object? e_(Observation? @this) {
            DataType? ad_ = @this?.Effective;
            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime?>? af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime? ag_ = context.Operators.Start(af_);
            return ag_;
        }

        IEnumerable<Observation?>? f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? g_ = context.Operators.Last<Observation>(f_);
        DataType? h_ = g_?.Value;
        object? i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        bool? j_ = context.Operators.Less(i_ as int?, 5);
        return j_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4985592431128511125L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 4176559840175856802L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -7339446756539217987L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -1428577257306360309L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = 1010167823931080299L;

    private bool? Stratification_1_Compute(CqlContext context)
    {
        Observation? a_ = this.Index_Depression_Assessment(context);
        Observation?[]? b_ = [
            a_,
        ];

        bool? c_(Observation? IndexAssessment) {
            Patient? f_ = this.Patient(context);
            Date? g_ = f_?.BirthDateElement;
            string? h_ = g_?.Value;
            CqlDate? i_ = context.Operators.ConvertStringToDate(h_);
            DataType? j_ = IndexAssessment?.Effective;
            object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlDateTime? m_ = context.Operators.Start(l_);
            CqlDate? n_ = context.Operators.DateFrom(m_);
            int? o_ = context.Operators.CalculateAgeAt(i_, n_, "year");
            CqlInterval<int?>? p_ = context.Operators.Interval(12, 17, true, true);
            bool? q_ = context.Operators.In<int?>(o_, p_, (string)default);
            return q_;
        }

        IEnumerable<bool?>? d_ = context.Operators.SelectDistinct<Observation, bool?>((IEnumerable<Observation?>?)b_, c_);
        bool? e_ = context.Operators.SingletonFrom<bool?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -7436411683980352410L;

    private bool? Stratification_2_Compute(CqlContext context)
    {
        Observation? a_ = this.Index_Depression_Assessment(context);
        Observation?[]? b_ = [
            a_,
        ];

        bool? c_(Observation? IndexAssessment) {
            Patient? f_ = this.Patient(context);
            Date? g_ = f_?.BirthDateElement;
            string? h_ = g_?.Value;
            CqlDate? i_ = context.Operators.ConvertStringToDate(h_);
            DataType? j_ = IndexAssessment?.Effective;
            object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlDateTime? m_ = context.Operators.Start(l_);
            CqlDate? n_ = context.Operators.DateFrom(m_);
            int? o_ = context.Operators.CalculateAgeAt(i_, n_, "year");
            bool? p_ = context.Operators.GreaterOrEqual(o_, 18);
            return p_;
        }

        IEnumerable<bool?>? d_ = context.Operators.SelectDistinct<Observation, bool?>((IEnumerable<Observation?>?)b_, c_);
        bool? e_ = context.Operators.SingletonFrom<bool?>(d_);
        return e_;
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
