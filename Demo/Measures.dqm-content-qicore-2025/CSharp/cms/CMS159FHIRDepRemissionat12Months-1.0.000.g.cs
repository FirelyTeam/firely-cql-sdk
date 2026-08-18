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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
            CqlBoolean g_ = context.Operators.Greater(f_ as int?, 9);
            Code<ObservationStatus> h_ = DepressionAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            CqlBoolean m_ = l_;
            return g_
                /* CQL 'and' (77:5-78:76) */ && m_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        CqlBoolean e_ = context.Operators.Equivalent(b_, d_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        CqlBoolean h_ = context.Operators.Equivalent(b_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        CqlBoolean l_ = context.Operators.Equivalent(b_, k_);
        CqlBoolean m_ = l_;
        CqlCode n_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
        CqlBoolean p_ = context.Operators.Equivalent(b_, o_);
        CqlBoolean q_ = p_;
        CqlBoolean r_ = e_
            /* CQL 'or' (175:54-176:66) */ || i_
            /* CQL 'or' (175:54-177:66) */ || m_
            /* CQL 'or' (175:52-179:3) */ || q_;
        return (CqlBoolean)(b_ is null)
            /* CQL 'implies' (175:3-179:3) */ || r_;
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
            CqlBoolean l_ = this.isVerified(context, Depression);
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
                Period h_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Depression);
                CqlBoolean k_ = context.Operators.Overlaps(i_, j_, (string)default);
                CqlDateTime l_ = context.Operators.End(i_);
                CqlInterval<CqlDateTime> m_ = this.Denominator_Identification_Period(context);
                CqlBoolean n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
                CqlBoolean o_ = n_;
                Code<Encounter.EncounterStatus> p_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? q_ = p_?.Value;
                Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
                CqlBoolean s_ = context.Operators.Equal(r_, "finished");
                CqlBoolean t_ = s_;
                return k_
                    /* CQL 'and' (90:17-91:88) */ && o_
                    /* CQL 'and' (90:17-92:46) */ && t_;
            }

            CqlBoolean g_ = context.Operators.WhereAny<Condition>(e_, f_);
            return g_;
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
                Period j_ = DepressionEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlQuantity m_ = context.Operators.Quantity(7m, "days");
                CqlDateTime n_ = context.Operators.Subtract(l_, m_);
                CqlDateTime o_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, o_, true, true);
                DataType q_ = DepressionAssessment?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlBoolean t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, "day");
                return t_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType u_ = @this?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            return x_;
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
        CqlBoolean k_ = context.Operators.GreaterOrEqual(j_, 12);
        return k_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 4924516395329346969L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
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
            DataType f_ = FirstIndexAssessment?.Effective;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlQuantity k_ = context.Operators.Quantity(12m, "months");
            CqlDate l_ = context.Operators.Add(j_, k_);
            CqlQuantity m_ = context.Operators.Quantity(60m, "days");
            CqlDate n_ = context.Operators.Subtract(l_, m_);
            CqlDate o_ = context.Operators.Add(l_, m_);
            CqlInterval<CqlDate> p_ = context.Operators.Interval(n_, o_, true, true);
            return p_;
        }

        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.SelectDistinct<Observation, CqlInterval<CqlDate>>((IEnumerable<Observation>)b_, c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);
        return e_;
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
            Encounter.HospitalizationComponent af_ = InpatientEncounter?.Hospitalization;
            CodeableConcept ag_ = af_?.DischargeDisposition;
            CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_);
            CqlCode ai_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
            CqlBoolean ak_ = context.Operators.Equivalent(ah_, aj_);
            CqlCode al_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
            CqlBoolean an_ = context.Operators.Equivalent(ah_, am_);
            CqlBoolean ao_ = an_;
            Period ap_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.End(aq_);
            CqlInterval<CqlDateTime> as_ = this.Denominator_Identification_Period(context);
            CqlDateTime at_ = context.Operators.Start(as_);
            CqlInterval<CqlDate> au_ = this.Measure_Assessment_Period(context);
            CqlDate av_ = context.Operators.End(au_);
            CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
            CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(at_, aw_, true, true);
            CqlBoolean ay_ = context.Operators.In<CqlDateTime>(ar_, ax_, "day");
            CqlBoolean az_ = ay_;
            Code<Encounter.EncounterStatus> ba_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? bb_ = ba_?.Value;
            Code<Encounter.EncounterStatus> bc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bb_);
            CqlBoolean bd_ = context.Operators.Equal(bc_, "finished");
            CqlBoolean be_ = bd_;
            return (ak_
                /* CQL 'or' (117:13-119:7) */ || ao_)
                /* CQL 'and' (117:13-120:147) */ && az_
                /* CQL 'and' (117:7-121:50) */ && be_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        CqlValueSet e_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? g_(Encounter HospiceEncounter) {
            Period bf_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
            CqlInterval<CqlDateTime> bh_ = this.Denominator_Identification_Period(context);
            CqlDateTime bi_ = context.Operators.Start(bh_);
            CqlInterval<CqlDate> bj_ = this.Measure_Assessment_Period(context);
            CqlDate bk_ = context.Operators.End(bj_);
            CqlDateTime bl_ = context.Operators.ConvertDateToDateTime(bk_);
            CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(bi_, bl_, true, true);
            CqlBoolean bn_ = context.Operators.Overlaps(bg_, bm_, "day");
            Code<Encounter.EncounterStatus> bo_ = HospiceEncounter?.StatusElement;
            Encounter.EncounterStatus? bp_ = bo_?.Value;
            Code<Encounter.EncounterStatus> bq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bp_);
            string br_ = context.Operators.Convert<string>(bq_);
            string[] bs_ = [
                "cancelled",
                "entered-in-error",
                "unknown",
            ];
            CqlBoolean bt_ = context.Operators.In<string>(br_, (IEnumerable<string>)bs_);
            CqlBoolean bu_ = (CqlBoolean)!bt_;
            return bn_
                /* CQL 'and' (124:9-125:95) */ && bu_;
        }

        CqlBoolean h_ = context.Operators.WhereAny<Encounter>(f_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? m_(Observation HospiceAssessment) {
            DataType bv_ = HospiceAssessment?.Value;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            CqlCode bx_ = this.Yes__qualifier_value_(context);
            CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
            CqlBoolean bz_ = context.Operators.Equivalent(bw_ as CqlConcept, by_);
            DataType ca_ = HospiceAssessment?.Effective;
            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
            CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
            CqlInterval<CqlDateTime> cd_ = this.Denominator_Identification_Period(context);
            CqlDateTime ce_ = context.Operators.Start(cd_);
            CqlInterval<CqlDate> cf_ = this.Measure_Assessment_Period(context);
            CqlDate cg_ = context.Operators.End(cf_);
            CqlDateTime ch_ = context.Operators.ConvertDateToDateTime(cg_);
            CqlInterval<CqlDateTime> ci_ = context.Operators.Interval(ce_, ch_, true, true);
            CqlBoolean cj_ = context.Operators.Overlaps(cc_, ci_, "day");
            CqlBoolean ck_ = cj_;
            Code<ObservationStatus> cl_ = HospiceAssessment?.StatusElement;
            ObservationStatus? cm_ = cl_?.Value;
            string cn_ = context.Operators.Convert<string>(cm_);
            string[] co_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean cp_ = context.Operators.In<string>(cn_, (IEnumerable<string>)co_);
            CqlBoolean cq_ = cp_;
            return bz_
                /* CQL 'and' (128:15-129:163) */ && ck_
                /* CQL 'and' (128:9-130:77) */ && cq_;
        }

        CqlBoolean n_ = context.Operators.WhereAny<Observation>(l_, m_);
        CqlBoolean o_ = n_;
        CqlValueSet p_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> q_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? r_(ServiceRequest HospiceOrder) {
            FhirDateTime cr_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
            CqlInterval<CqlDateTime> ct_ = this.Denominator_Identification_Period(context);
            CqlDateTime cu_ = context.Operators.Start(ct_);
            CqlInterval<CqlDate> cv_ = this.Measure_Assessment_Period(context);
            CqlDate cw_ = context.Operators.End(cv_);
            CqlDateTime cx_ = context.Operators.ConvertDateToDateTime(cw_);
            CqlInterval<CqlDateTime> cy_ = context.Operators.Interval(cu_, cx_, true, true);
            CqlBoolean cz_ = context.Operators.In<CqlDateTime>(cs_, cy_, "day");
            Code<RequestStatus> da_ = HospiceOrder?.StatusElement;
            RequestStatus? db_ = da_?.Value;
            Code<RequestStatus> dc_ = context.Operators.Convert<Code<RequestStatus>>(db_);
            string dd_ = context.Operators.Convert<string>(dc_);
            string[] de_ = [
                "active",
                "completed",
            ];
            CqlBoolean df_ = context.Operators.In<string>(dd_, (IEnumerable<string>)de_);
            CqlBoolean dg_ = df_;
            Code<RequestIntent> dh_ = HospiceOrder?.IntentElement;
            RequestIntent? di_ = dh_?.Value;
            Code<RequestIntent> dj_ = context.Operators.Convert<Code<RequestIntent>>(di_);
            string dk_ = context.Operators.Convert<string>(dj_);
            string[] dl_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean dm_ = context.Operators.In<string>(dk_, (IEnumerable<string>)dl_);
            CqlBoolean dn_ = dm_;
            return cz_
                /* CQL 'and' (133:15-134:62) */ && dg_
                /* CQL 'and' (133:9-135:116) */ && dn_;
        }

        CqlBoolean s_ = context.Operators.WhereAny<ServiceRequest>(q_, r_);
        CqlBoolean t_ = s_;
        IEnumerable<Procedure> u_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? v_(Procedure HospicePerformed) {
            object do_;
            DataType ed_ = HospicePerformed?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            bool ef_ = ee_ is CqlDateTime;
            if (ef_)
            {
                do_ = ee_ as CqlDateTime;
            }
            else
            {
                bool eg_ = ee_ is CqlQuantity;
                if (eg_)
                {
                    do_ = ee_ as CqlQuantity;
                }
                else
                {
                    bool eh_ = ee_ is CqlInterval<CqlDateTime>;
                    if (eh_)
                    {
                        do_ = ee_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ei_ = ee_ is CqlInterval<CqlQuantity>;
                        if (ei_)
                        {
                            do_ = ee_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            do_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dp_ = QICoreCommon_4_0_000.Instance.toInterval(context, do_);
            CqlInterval<CqlDateTime> dq_ = this.Denominator_Identification_Period(context);
            CqlDateTime dr_ = context.Operators.Start(dq_);
            CqlInterval<CqlDate> ds_ = this.Measure_Assessment_Period(context);
            CqlDate dt_ = context.Operators.End(ds_);
            CqlDateTime du_ = context.Operators.ConvertDateToDateTime(dt_);
            CqlInterval<CqlDateTime> dv_ = context.Operators.Interval(dr_, du_, true, true);
            CqlBoolean dw_ = context.Operators.Overlaps(dp_, dv_, "day");
            Code<EventStatus> dx_ = HospicePerformed?.StatusElement;
            EventStatus? dy_ = dx_?.Value;
            string dz_ = context.Operators.Convert<string>(dy_);
            string[] ea_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            CqlBoolean eb_ = context.Operators.In<string>(dz_, (IEnumerable<string>)ea_);
            CqlBoolean ec_ = (CqlBoolean)!eb_;
            return dw_
                /* CQL 'and' (138:9-139:94) */ && ec_;
        }

        CqlBoolean w_ = context.Operators.WhereAny<Procedure>(u_, v_);
        CqlBoolean x_ = w_;
        CqlValueSet y_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> z_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> aa_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> ab_ = context.Operators.Union<Condition>(z_ as IEnumerable<Condition>, aa_ as IEnumerable<Condition>);

        bool? ac_(Condition HospiceCareDiagnosis) {
            CqlInterval<CqlDateTime> ej_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> ek_ = this.Denominator_Identification_Period(context);
            CqlDateTime el_ = context.Operators.Start(ek_);
            CqlInterval<CqlDate> em_ = this.Measure_Assessment_Period(context);
            CqlDate en_ = context.Operators.End(em_);
            CqlDateTime eo_ = context.Operators.ConvertDateToDateTime(en_);
            CqlInterval<CqlDateTime> ep_ = context.Operators.Interval(el_, eo_, true, true);
            CqlBoolean eq_ = context.Operators.Overlaps(ej_, ep_, "day");
            return eq_
                /* CQL 'and' (143:9-144:49) */ && this.isVerified(context, HospiceCareDiagnosis);
        }

        CqlBoolean ad_ = context.Operators.WhereAny<Condition>(ab_, ac_);
        CqlBoolean ae_ = ad_;
        return d_
            /* CQL 'or' (116:3-126:5) */ || i_
            /* CQL 'or' (116:3-131:5) */ || o_
            /* CQL 'or' (116:3-136:5) */ || t_
            /* CQL 'or' (116:3-140:5) */ || x_
            /* CQL 'or' (116:3-145:5) */ || ae_;
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
            DataType w_ = PalliativeAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            CqlInterval<CqlDateTime> z_ = this.Denominator_Identification_Period(context);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlInterval<CqlDate> ab_ = this.Measure_Assessment_Period(context);
            CqlDate ac_ = context.Operators.End(ab_);
            CqlDateTime ad_ = context.Operators.ConvertDateToDateTime(ac_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
            CqlBoolean af_ = context.Operators.Overlaps(y_, ae_, "day");
            Code<ObservationStatus> ag_ = PalliativeAssessment?.StatusElement;
            ObservationStatus? ah_ = ag_?.Value;
            string ai_ = context.Operators.Convert<string>(ah_);
            string[] aj_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
            CqlBoolean al_ = ak_;
            return af_
                /* CQL 'and' (157:7-158:78) */ && al_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<Observation>(c_, d_);
        CqlValueSet f_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);

        bool? j_(Condition PalliativeDiagnosis) {
            CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> an_ = this.Denominator_Identification_Period(context);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlInterval<CqlDate> ap_ = this.Measure_Assessment_Period(context);
            CqlDate aq_ = context.Operators.End(ap_);
            CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
            CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ao_, ar_, true, true);
            CqlBoolean at_ = context.Operators.Overlaps(am_, as_, "day");
            return at_
                /* CQL 'and' (162:9-163:48) */ && this.isVerified(context, PalliativeDiagnosis);
        }

        CqlBoolean k_ = context.Operators.WhereAny<Condition>(i_, j_);
        CqlBoolean l_ = k_;
        CqlValueSet m_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? o_(Encounter PalliativeEncounter) {
            Period au_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
            CqlInterval<CqlDateTime> aw_ = this.Denominator_Identification_Period(context);
            CqlDateTime ax_ = context.Operators.Start(aw_);
            CqlInterval<CqlDate> ay_ = this.Measure_Assessment_Period(context);
            CqlDate az_ = context.Operators.End(ay_);
            CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
            CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(ax_, ba_, true, true);
            CqlBoolean bc_ = context.Operators.Overlaps(av_, bb_, "day");
            Code<Encounter.EncounterStatus> bd_ = PalliativeEncounter?.StatusElement;
            Encounter.EncounterStatus? be_ = bd_?.Value;
            Code<Encounter.EncounterStatus> bf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(be_);
            CqlBoolean bg_ = context.Operators.Equal(bf_, "finished");
            CqlBoolean bh_ = bg_;
            return bc_
                /* CQL 'and' (166:9-167:53) */ && bh_;
        }

        CqlBoolean p_ = context.Operators.WhereAny<Encounter>(n_, o_);
        CqlBoolean q_ = p_;
        CqlValueSet r_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> s_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? t_(Procedure PalliativeIntervention) {
            object bi_;
            DataType bx_ = PalliativeIntervention?.Performed;
            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                bi_ = by_ as CqlDateTime;
            }
            else
            {
                bool ca_ = by_ is CqlQuantity;
                if (ca_)
                {
                    bi_ = by_ as CqlQuantity;
                }
                else
                {
                    bool cb_ = by_ is CqlInterval<CqlDateTime>;
                    if (cb_)
                    {
                        bi_ = by_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cc_ = by_ is CqlInterval<CqlQuantity>;
                        if (cc_)
                        {
                            bi_ = by_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bi_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
            CqlInterval<CqlDateTime> bk_ = this.Denominator_Identification_Period(context);
            CqlDateTime bl_ = context.Operators.Start(bk_);
            CqlInterval<CqlDate> bm_ = this.Measure_Assessment_Period(context);
            CqlDate bn_ = context.Operators.End(bm_);
            CqlDateTime bo_ = context.Operators.ConvertDateToDateTime(bn_);
            CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bl_, bo_, true, true);
            CqlBoolean bq_ = context.Operators.Overlaps(bj_, bp_, "day");
            Code<EventStatus> br_ = PalliativeIntervention?.StatusElement;
            EventStatus? bs_ = br_?.Value;
            string bt_ = context.Operators.Convert<string>(bs_);
            string[] bu_ = [
                "not-done",
                "entered-in-error",
                "unknown",
            ];
            CqlBoolean bv_ = context.Operators.In<string>(bt_, (IEnumerable<string>)bu_);
            CqlBoolean bw_ = (CqlBoolean)!bv_;
            return bq_
                /* CQL 'and' (170:9-171:100) */ && bw_;
        }

        CqlBoolean u_ = context.Operators.WhereAny<Procedure>(s_, t_);
        CqlBoolean v_ = u_;
        return e_
            /* CQL 'or' (156:3-164:5) */ || l_
            /* CQL 'or' (156:3-168:5) */ || q_
            /* CQL 'or' (156:3-172:5) */ || v_;
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
        CqlBoolean g_ = context.Operators.SameOrBefore(c_ as CqlDateTime, f_, "day");
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
            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlInterval<CqlDate> x_ = this.Measure_Assessment_Period(context);
            CqlDate y_ = context.Operators.End(x_);
            CqlDateTime z_ = context.Operators.ConvertDateToDateTime(y_);
            CqlBoolean aa_ = context.Operators.SameOrBefore(w_, z_, "day");
            return aa_
                /* CQL 'and' (103:7-104:56) */ && this.isVerified(context, MentalHealthDisorderDiagnoses);
        }

        CqlBoolean u_ = context.Operators.WhereAny<Condition>(s_, t_);
        return u_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2559139784615991071L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Hospice_Services_prior_to_or_during_the_Measure_Assessment_Period(context);
        return a_
            /* CQL 'or' (48:3-49:77) */ || this.Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period(context)
            /* CQL 'or' (48:3-50:24) */ || this.Patient_Expired(context)
            /* CQL 'or' (48:3-51:45) */ || this.Has_Mental_Health_Disorder_Diagnoses(context);
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
            CqlBoolean t_ = o_?.lowClosed;
            CqlBoolean u_ = o_?.highClosed;
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, s_, t_, u_);
            CqlBoolean w_ = context.Operators.In<CqlDateTime>(n_, v_, "day");
            Code<ObservationStatus> x_ = DepressionAssessment?.StatusElement;
            ObservationStatus? y_ = x_?.Value;
            string z_ = context.Operators.Convert<string>(y_);
            string[] aa_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
            CqlBoolean ac_ = ab_;
            return w_
                /* CQL 'and' (55:7-56:78) */ && ac_;
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
        CqlBoolean j_ = context.Operators.Less(i_ as int?, 5);
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
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            DataType j_ = IndexAssessment?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            int? o_ = context.Operators.CalculateAgeAt(i_, n_, "year");
            CqlInterval<int?> p_ = context.Operators.Interval(12, 17, true, true);
            CqlBoolean q_ = context.Operators.In<int?>(o_, p_, (string)default);
            return q_;
        }

        IEnumerable<bool?> d_ = context.Operators.SelectDistinct<Observation, bool?>((IEnumerable<Observation>)b_, c_);
        CqlBoolean e_ = context.Operators.SingletonFrom<bool?>(d_);
        return e_;
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
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            DataType j_ = IndexAssessment?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            int? o_ = context.Operators.CalculateAgeAt(i_, n_, "year");
            CqlBoolean p_ = context.Operators.GreaterOrEqual(o_, 18);
            return p_;
        }

        IEnumerable<bool?> d_ = context.Operators.SelectDistinct<Observation, bool?>((IEnumerable<Observation>)b_, c_);
        CqlBoolean e_ = context.Operators.SingletonFrom<bool?>(d_);
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
