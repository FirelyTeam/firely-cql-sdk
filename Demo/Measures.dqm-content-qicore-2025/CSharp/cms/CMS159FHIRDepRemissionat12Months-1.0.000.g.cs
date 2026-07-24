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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
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
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Depression Diagnoses")]
    public IEnumerable<Condition> Depression_Diagnoses(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Depression_Diagnoses, Depression_Diagnoses_Compute);

    private const long _cacheIndex_Depression_Diagnoses = 5150113982553371070L;

    private IEnumerable<Condition> Depression_Diagnoses_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Major_Depression_Including_Remission(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.Dysthymia(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);

        bool? j_(Condition Depression) {
            bool? l_ = this.isVerified(context, Depression);
            return l_;
        }

        IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
        return k_;
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
        CqlQuantity e_ = context.Operators.Quantity(2m, "months");
        CqlDateTime f_ = context.Operators.Subtract(b_, e_);
        CqlInterval<CqlDateTime> g_ = context.Operators.Interval(d_, f_, true, false);
        return g_;
    }


    [CqlExpressionDefinition("Depression Encounter")]
    public IEnumerable<Encounter> Depression_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Depression_Encounter, Depression_Encounter_Compute);

    private const long _cacheIndex_Depression_Encounter = 4681658861661132345L;

    private IEnumerable<Encounter> Depression_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Contact_or_Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter ValidEncounter) {
            IEnumerable<Condition> e_ = this.Depression_Diagnoses(context);

            bool? f_(Condition Depression) {
                Period i_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Depression);
                bool? l_ = context.Operators.Overlaps(j_, k_, (string)default);
                CqlDateTime m_ = context.Operators.End(j_);
                CqlInterval<CqlDateTime> n_ = this.Denominator_Identification_Period(context);
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
                bool? p_ = context.Operators.And(l_, o_);
                Code<Encounter.EncounterStatus> q_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? r_ = q_?.Value;
                Code<Encounter.EncounterStatus> s_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(r_);
                bool? t_ = context.Operators.Equal(s_, "finished");
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            return h_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Index Depression Assessment")]
    public Observation Index_Depression_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Index_Depression_Assessment, Index_Depression_Assessment_Compute);

    private const long _cacheIndex_Index_Depression_Assessment = 499571989574502589L;

    private Observation Index_Depression_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Depression_Assessments_Greater_Than_9(context);

        bool? b_(Observation DepressionAssessment) {
            IEnumerable<Encounter> g_ = this.Depression_Encounter(context);

            bool? h_(Encounter DepressionEncounter) {
                Period k_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(7m, "days");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlDateTime p_ = context.Operators.End(l_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, p_, true, true);
                DataType r_ = DepressionAssessment?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                bool? u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, t_, "day");
                return u_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            return j_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType v_ = @this?.Effective;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            return y_;
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
            CqlDate p_ = context.Operators.Add(m_, n_);
            CqlInterval<CqlDate> q_ = context.Operators.Interval(o_, p_, true, true);
            return q_;
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
            Encounter.HospitalizationComponent al_ = InpatientEncounter?.Hospitalization;
            CodeableConcept am_ = al_?.DischargeDisposition;
            CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
            CqlCode ao_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
            bool? aq_ = context.Operators.Equivalent(an_, ap_);
            CqlCode ar_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
            bool? at_ = context.Operators.Equivalent(an_, as_);
            bool? au_ = context.Operators.Or(aq_, at_);
            Period av_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDateTime> ay_ = this.Denominator_Identification_Period(context);
            CqlDateTime az_ = context.Operators.Start(ay_);
            CqlInterval<CqlDate> ba_ = this.Measure_Assessment_Period(context);
            CqlDate bb_ = context.Operators.End(ba_);
            CqlDateTime bc_ = context.Operators.ConvertDateToDateTime(bb_);
            CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(az_, bc_, true, true);
            bool? be_ = context.Operators.In<CqlDateTime>(ax_, bd_, "day");
            bool? bf_ = context.Operators.And(au_, be_);
            Code<Encounter.EncounterStatus> bg_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? bh_ = bg_?.Value;
            Code<Encounter.EncounterStatus> bi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bh_);
            bool? bj_ = context.Operators.Equal(bi_, "finished");
            bool? bk_ = context.Operators.And(bf_, bj_);
            return bk_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        bool? e_ = context.Operators.Exists<Encounter>(d_);
        CqlValueSet f_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? h_(Encounter HospiceEncounter) {
            Period bl_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
            CqlInterval<CqlDateTime> bn_ = this.Denominator_Identification_Period(context);
            CqlDateTime bo_ = context.Operators.Start(bn_);
            CqlInterval<CqlDate> bp_ = this.Measure_Assessment_Period(context);
            CqlDate bq_ = context.Operators.End(bp_);
            CqlDateTime br_ = context.Operators.ConvertDateToDateTime(bq_);
            CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bo_, br_, true, true);
            bool? bt_ = context.Operators.Overlaps(bm_, bs_, "day");
            Code<Encounter.EncounterStatus> bu_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? bv_ = bu_?.Value;
            Code<Encounter.EncounterStatus> bw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bv_);
            string bx_ = context.Operators.Convert<string>(bw_);
            string[] by_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            bool? bz_ = context.Operators.In<string>(bx_, (IEnumerable<string>)by_);
            bool? ca_ = context.Operators.Not(bz_);
            bool? cb_ = context.Operators.And(bt_, ca_);
            return cb_;
        }

        IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
        bool? j_ = context.Operators.Exists<Encounter>(i_);
        bool? k_ = context.Operators.Or(e_, j_);
        CqlCode l_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
        IEnumerable<Observation> n_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, m_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? o_(Observation HospiceAssessment) {
            DataType cc_ = HospiceAssessment?.Value;
            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
            CqlCode ce_ = this.Yes__qualifier_value_(context);
            CqlConcept cf_ = context.Operators.ConvertCodeToConcept(ce_);
            bool? cg_ = context.Operators.Equivalent(cd_ as CqlConcept, cf_);
            DataType ch_ = HospiceAssessment?.Effective;
            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
            CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
            CqlInterval<CqlDateTime> ck_ = this.Denominator_Identification_Period(context);
            CqlDateTime cl_ = context.Operators.Start(ck_);
            CqlInterval<CqlDate> cm_ = this.Measure_Assessment_Period(context);
            CqlDate cn_ = context.Operators.End(cm_);
            CqlDateTime co_ = context.Operators.ConvertDateToDateTime(cn_);
            CqlInterval<CqlDateTime> cp_ = context.Operators.Interval(cl_, co_, true, true);
            bool? cq_ = context.Operators.Overlaps(cj_, cp_, "day");
            bool? cr_ = context.Operators.And(cg_, cq_);
            Code<ObservationStatus> cs_ = HospiceAssessment?.StatusElement;
            ObservationStatus? ct_ = cs_?.Value;
            string cu_ = context.Operators.Convert<string>(ct_);
            string[] cv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? cw_ = context.Operators.In<string>(cu_, (IEnumerable<string>)cv_);
            bool? cx_ = context.Operators.And(cr_, cw_);
            return cx_;
        }

        IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
        bool? q_ = context.Operators.Exists<Observation>(p_);
        bool? r_ = context.Operators.Or(k_, q_);
        CqlValueSet s_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> t_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? u_(ServiceRequest HospiceOrder) {
            FhirDateTime cy_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime cz_ = context.Operators.Convert<CqlDateTime>(cy_);
            CqlInterval<CqlDateTime> da_ = this.Denominator_Identification_Period(context);
            CqlDateTime db_ = context.Operators.Start(da_);
            CqlInterval<CqlDate> dc_ = this.Measure_Assessment_Period(context);
            CqlDate dd_ = context.Operators.End(dc_);
            CqlDateTime de_ = context.Operators.ConvertDateToDateTime(dd_);
            CqlInterval<CqlDateTime> df_ = context.Operators.Interval(db_, de_, true, true);
            bool? dg_ = context.Operators.In<CqlDateTime>(cz_, df_, "day");
            Code<RequestStatus> dh_ = HospiceOrder?.StatusElement;
            RequestStatus? di_ = dh_?.Value;
            Code<RequestStatus> dj_ = context.Operators.Convert<Code<RequestStatus>>(di_);
            string dk_ = context.Operators.Convert<string>(dj_);
            string[] dl_ = [
                "active",
                "completed",
            ];
            bool? dm_ = context.Operators.In<string>(dk_, (IEnumerable<string>)dl_);
            bool? dn_ = context.Operators.And(dg_, dm_);
            Code<RequestIntent> do_ = HospiceOrder?.IntentElement;
            RequestIntent? dp_ = do_?.Value;
            Code<RequestIntent> dq_ = context.Operators.Convert<Code<RequestIntent>>(dp_);
            string dr_ = context.Operators.Convert<string>(dq_);
            string[] ds_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? dt_ = context.Operators.In<string>(dr_, (IEnumerable<string>)ds_);
            bool? du_ = context.Operators.And(dn_, dt_);
            return du_;
        }

        IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
        bool? w_ = context.Operators.Exists<ServiceRequest>(v_);
        bool? x_ = context.Operators.Or(r_, w_);
        IEnumerable<Procedure> y_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? z_(Procedure HospicePerformed) {

            object dv_() {

                bool el_() {
                    DataType ep_ = HospicePerformed?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlDateTime;
                    return er_;
                }


                bool em_() {
                    DataType es_ = HospicePerformed?.Performed;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    bool eu_ = et_ is CqlInterval<CqlDateTime>;
                    return eu_;
                }


                bool en_() {
                    DataType ev_ = HospicePerformed?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    bool ex_ = ew_ is CqlQuantity;
                    return ex_;
                }


                bool eo_() {
                    DataType ey_ = HospicePerformed?.Performed;
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    bool fa_ = ez_ is CqlInterval<CqlQuantity>;
                    return fa_;
                }

                if (el_())
                {
                    DataType fb_ = HospicePerformed?.Performed;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    return fc_ as CqlDateTime;
                }
                else if (em_())
                {
                    DataType fd_ = HospicePerformed?.Performed;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    return fe_ as CqlInterval<CqlDateTime>;
                }
                else if (en_())
                {
                    DataType ff_ = HospicePerformed?.Performed;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    return fg_ as CqlQuantity;
                }
                else if (eo_())
                {
                    DataType fh_ = HospicePerformed?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    return fi_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> dw_ = QICoreCommon_4_0_000.Instance.toInterval(context, dv_());
            CqlInterval<CqlDateTime> dx_ = this.Denominator_Identification_Period(context);
            CqlDateTime dy_ = context.Operators.Start(dx_);
            CqlInterval<CqlDate> dz_ = this.Measure_Assessment_Period(context);
            CqlDate ea_ = context.Operators.End(dz_);
            CqlDateTime eb_ = context.Operators.ConvertDateToDateTime(ea_);
            CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dy_, eb_, true, true);
            bool? ed_ = context.Operators.Overlaps(dw_, ec_, "day");
            Code<EventStatus> ee_ = HospicePerformed?.StatusElement;
            EventStatus? ef_ = ee_?.Value;
            string eg_ = context.Operators.Convert<string>(ef_);
            string[] eh_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? ei_ = context.Operators.In<string>(eg_, (IEnumerable<string>)eh_);
            bool? ej_ = context.Operators.Not(ei_);
            bool? ek_ = context.Operators.And(ed_, ej_);
            return ek_;
        }

        IEnumerable<Procedure> aa_ = context.Operators.Where<Procedure>(y_, z_);
        bool? ab_ = context.Operators.Exists<Procedure>(aa_);
        bool? ac_ = context.Operators.Or(x_, ab_);
        CqlValueSet ad_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> ae_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> af_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> ag_ = context.Operators.Union<Condition>(ae_ as IEnumerable<Condition>, af_ as IEnumerable<Condition>);

        bool? ah_(Condition HospiceCareDiagnosis) {
            CqlInterval<CqlDateTime> fj_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> fk_ = this.Denominator_Identification_Period(context);
            CqlDateTime fl_ = context.Operators.Start(fk_);
            CqlInterval<CqlDate> fm_ = this.Measure_Assessment_Period(context);
            CqlDate fn_ = context.Operators.End(fm_);
            CqlDateTime fo_ = context.Operators.ConvertDateToDateTime(fn_);
            CqlInterval<CqlDateTime> fp_ = context.Operators.Interval(fl_, fo_, true, true);
            bool? fq_ = context.Operators.Overlaps(fj_, fp_, "day");
            bool? fr_ = this.isVerified(context, HospiceCareDiagnosis);
            bool? fs_ = context.Operators.And(fq_, fr_);
            return fs_;
        }

        IEnumerable<Condition> ai_ = context.Operators.Where<Condition>(ag_, ah_);
        bool? aj_ = context.Operators.Exists<Condition>(ai_);
        bool? ak_ = context.Operators.Or(ac_, aj_);
        return ak_;
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
            DataType aa_ = PalliativeAssessment?.Effective;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
            CqlInterval<CqlDateTime> ad_ = this.Denominator_Identification_Period(context);
            CqlDateTime ae_ = context.Operators.Start(ad_);
            CqlInterval<CqlDate> af_ = this.Measure_Assessment_Period(context);
            CqlDate ag_ = context.Operators.End(af_);
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
            CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ae_, ah_, true, true);
            bool? aj_ = context.Operators.Overlaps(ac_, ai_, "day");
            Code<ObservationStatus> ak_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? al_ = ak_?.Value;
            string am_ = context.Operators.Convert<string>(al_);
            string[] an_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
            bool? ap_ = context.Operators.And(aj_, ao_);
            return ap_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        CqlValueSet g_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(h_ as IEnumerable<Condition>, i_ as IEnumerable<Condition>);

        bool? k_(Condition PalliativeDiagnosis) {
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> ar_ = this.Denominator_Identification_Period(context);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlInterval<CqlDate> at_ = this.Measure_Assessment_Period(context);
            CqlDate au_ = context.Operators.End(at_);
            CqlDateTime av_ = context.Operators.ConvertDateToDateTime(au_);
            CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(as_, av_, true, true);
            bool? ax_ = context.Operators.Overlaps(aq_, aw_, "day");
            bool? ay_ = this.isVerified(context, PalliativeDiagnosis);
            bool? az_ = context.Operators.And(ax_, ay_);
            return az_;
        }

        IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
        bool? m_ = context.Operators.Exists<Condition>(l_);
        bool? n_ = context.Operators.Or(f_, m_);
        CqlValueSet o_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? q_(Encounter PalliativeEncounter) {
            Period ba_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
            CqlInterval<CqlDateTime> bc_ = this.Denominator_Identification_Period(context);
            CqlDateTime bd_ = context.Operators.Start(bc_);
            CqlInterval<CqlDate> be_ = this.Measure_Assessment_Period(context);
            CqlDate bf_ = context.Operators.End(be_);
            CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
            CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(bd_, bg_, true, true);
            bool? bi_ = context.Operators.Overlaps(bb_, bh_, "day");
            Code<Encounter.EncounterStatus> bj_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? bk_ = bj_?.Value;
            Code<Encounter.EncounterStatus> bl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bk_);
            bool? bm_ = context.Operators.Equal(bl_, "finished");
            bool? bn_ = context.Operators.And(bi_, bm_);
            return bn_;
        }

        IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
        bool? s_ = context.Operators.Exists<Encounter>(r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlValueSet u_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? w_(Procedure PalliativeIntervention) {

            object bo_() {

                bool ce_() {
                    DataType ci_ = PalliativeIntervention?.Performed;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlDateTime;
                    return ck_;
                }


                bool cf_() {
                    DataType cl_ = PalliativeIntervention?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlInterval<CqlDateTime>;
                    return cn_;
                }


                bool cg_() {
                    DataType co_ = PalliativeIntervention?.Performed;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlQuantity;
                    return cq_;
                }


                bool ch_() {
                    DataType cr_ = PalliativeIntervention?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bool ct_ = cs_ is CqlInterval<CqlQuantity>;
                    return ct_;
                }

                if (ce_())
                {
                    DataType cu_ = PalliativeIntervention?.Performed;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    return cv_ as CqlDateTime;
                }
                else if (cf_())
                {
                    DataType cw_ = PalliativeIntervention?.Performed;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    return cx_ as CqlInterval<CqlDateTime>;
                }
                else if (cg_())
                {
                    DataType cy_ = PalliativeIntervention?.Performed;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    return cz_ as CqlQuantity;
                }
                else if (ch_())
                {
                    DataType da_ = PalliativeIntervention?.Performed;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    return db_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_());
            CqlInterval<CqlDateTime> bq_ = this.Denominator_Identification_Period(context);
            CqlDateTime br_ = context.Operators.Start(bq_);
            CqlInterval<CqlDate> bs_ = this.Measure_Assessment_Period(context);
            CqlDate bt_ = context.Operators.End(bs_);
            CqlDateTime bu_ = context.Operators.ConvertDateToDateTime(bt_);
            CqlInterval<CqlDateTime> bv_ = context.Operators.Interval(br_, bu_, true, true);
            bool? bw_ = context.Operators.Overlaps(bp_, bv_, "day");
            Code<EventStatus> bx_ = PalliativeIntervention?.StatusElement;
            EventStatus? by_ = bx_?.Value;
            string bz_ = context.Operators.Convert<string>(by_);
            string[] ca_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            bool? cb_ = context.Operators.In<string>(bz_, (IEnumerable<string>)ca_);
            bool? cc_ = context.Operators.Not(cb_);
            bool? cd_ = context.Operators.And(bw_, cc_);
            return cd_;
        }

        IEnumerable<Procedure> x_ = context.Operators.Where<Procedure>(v_, w_);
        bool? y_ = context.Operators.Exists<Procedure>(x_);
        bool? z_ = context.Operators.Or(t_, y_);
        return z_;
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
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.Personality_Disorder_Emotionally_Labile(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);
        CqlValueSet j_ = this.Schizophrenia_or_Psychotic_Disorder(context);
        IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> l_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition>, k_ as IEnumerable<Condition>);
        IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> n_ = context.Operators.Union<Condition>(l_ as IEnumerable<Condition>, m_ as IEnumerable<Condition>);
        CqlValueSet o_ = this.Pervasive_Developmental_Disorder(context);
        IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> q_ = context.Operators.Union<Condition>(n_ as IEnumerable<Condition>, p_ as IEnumerable<Condition>);
        IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> s_ = context.Operators.Union<Condition>(q_ as IEnumerable<Condition>, r_ as IEnumerable<Condition>);

        bool? t_(Condition MentalHealthDisorderDiagnoses) {
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlInterval<CqlDate> y_ = this.Measure_Assessment_Period(context);
            CqlDate z_ = context.Operators.End(y_);
            CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
            bool? ab_ = context.Operators.SameOrBefore(x_, aa_, "day");
            bool? ac_ = this.isVerified(context, MentalHealthDisorderDiagnoses);
            bool? ad_ = context.Operators.And(ab_, ac_);
            return ad_;
        }

        IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
        bool? v_ = context.Operators.Exists<Condition>(u_);
        return v_;
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
            CqlDate r_ = o_?.high;
            CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
            bool? t_ = o_?.lowClosed;
            bool? u_ = o_?.highClosed;
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, s_, t_, u_);
            bool? w_ = context.Operators.In<CqlDateTime>(n_, v_, "day");
            Code<ObservationStatus> x_ = DepressionAssessment?.StatusElement;
            ObservationStatus? y_ = x_?.Value;
            string z_ = context.Operators.Convert<string>(y_);
            string[] aa_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
            bool? ac_ = context.Operators.And(w_, ab_);
            return ac_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType ad_ = @this?.Effective;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            return ag_;
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
