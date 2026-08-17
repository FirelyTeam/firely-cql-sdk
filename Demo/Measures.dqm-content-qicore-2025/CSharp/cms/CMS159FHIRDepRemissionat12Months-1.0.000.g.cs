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
            // CQL 'and' (77:5-78:76): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> h_ = DepressionAssessment?.StatusElement;
                ObservationStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                string[] k_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                return g_ & l_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = !((bool?)(b_ is null));
        // CQL 'implies' (175:3-179:3): right operand skipped when left is false
        if (c_ is false)
        {
            return true;
        }
        else
        {
            CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
            bool? f_ = context.Operators.Equivalent(b_, e_);
            bool? g_;
            // CQL 'or' (175:54-176:66): right operand skipped when left is true
            if (f_ is true)
            {
                g_ = true;
            }
            else
            {
                CodeableConcept j_ = condition?.VerificationStatus;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlCode l_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(k_, m_);
                g_ = f_ | n_;
            }
            bool? h_;
            // CQL 'or' (175:54-177:66): right operand skipped when left is true
            if (g_ is true)
            {
                h_ = true;
            }
            else
            {
                CodeableConcept o_ = condition?.VerificationStatus;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(p_, r_);
                h_ = g_ | s_;
            }
            bool? i_;
            // CQL 'or' (175:52-179:3): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                CodeableConcept t_ = condition?.VerificationStatus;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlCode v_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(u_, w_);
                i_ = h_ | x_;
            }
            return !c_ | i_;
        }
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
                Period h_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Depression);
                bool? k_ = context.Operators.Overlaps(i_, j_, (string)default);
                bool? l_;
                // CQL 'and' (90:17-91:88): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    CqlDateTime m_ = context.Operators.End(i_);
                    CqlInterval<CqlDateTime> n_ = this.Denominator_Identification_Period(context);
                    bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
                    l_ = k_ & o_;
                }
                // CQL 'and' (90:17-92:46): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> p_ = ValidEncounter?.StatusElement;
                    Encounter.EncounterStatus? q_ = p_?.Value;
                    Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
                    bool? s_ = context.Operators.Equal(r_, "finished");
                    return l_ & s_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
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
                bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, "day");
                return t_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
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
            Encounter.HospitalizationComponent i_ = InpatientEncounter?.Hospitalization;
            CodeableConcept j_ = i_?.DischargeDisposition;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlCode l_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
            bool? n_ = context.Operators.Equivalent(k_, m_);
            bool? o_;
            // CQL 'or' (117:13-119:7): right operand skipped when left is true
            if (n_ is true)
            {
                o_ = true;
            }
            else
            {
                CqlCode q_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(k_, r_);
                o_ = n_ | s_;
            }
            bool? p_;
            // CQL 'and' (117:13-120:147): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                Period t_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                CqlInterval<CqlDateTime> w_ = this.Denominator_Identification_Period(context);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlInterval<CqlDate> y_ = this.Measure_Assessment_Period(context);
                CqlDate z_ = context.Operators.End(y_);
                CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(x_, aa_, true, true);
                bool? ac_ = context.Operators.In<CqlDateTime>(v_, ab_, "day");
                p_ = o_ & ac_;
            }
            // CQL 'and' (117:7-121:50): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> ad_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? ae_ = ad_?.Value;
                Code<Encounter.EncounterStatus> af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
                bool? ag_ = context.Operators.Equal(af_, "finished");
                return p_ & ag_;
            }
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        bool? e_;
        // CQL 'or' (116:3-126:5): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            CqlValueSet ah_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> ai_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aj_(Encounter HospiceEncounter) {
                Period al_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                CqlInterval<CqlDateTime> an_ = this.Denominator_Identification_Period(context);
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlInterval<CqlDate> ap_ = this.Measure_Assessment_Period(context);
                CqlDate aq_ = context.Operators.End(ap_);
                CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ao_, ar_, true, true);
                bool? at_ = context.Operators.Overlaps(am_, as_, "day");
                // CQL 'and' (124:9-125:95): right operand skipped when left is false
                if (at_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> au_ = HospiceEncounter?.StatusElement;
                    Encounter.EncounterStatus? av_ = au_?.Value;
                    Code<Encounter.EncounterStatus> aw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(av_);
                    string ax_ = context.Operators.Convert<string>(aw_);
                    string[] ay_ = [
                        "cancelled",
                        "entered-in-error",
                        "unknown",
                    ];
                    bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
                    return at_ & !az_;
                }
            }

            bool? ak_ = context.Operators.WhereAny<Encounter>(ai_, aj_);
            e_ = d_ | ak_;
        }
        bool? f_;
        // CQL 'or' (116:3-131:5): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlCode ba_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> bb_ = context.Operators.ToList<CqlCode>(ba_);
            IEnumerable<Observation> bc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? bd_(Observation HospiceAssessment) {
                DataType bf_ = HospiceAssessment?.Value;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlCode bh_ = this.Yes__qualifier_value_(context);
                CqlConcept bi_ = context.Operators.ConvertCodeToConcept(bh_);
                bool? bj_ = context.Operators.Equivalent(bg_ as CqlConcept, bi_);
                bool? bk_;
                // CQL 'and' (128:15-129:163): right operand skipped when left is false
                if (bj_ is false)
                {
                    bk_ = false;
                }
                else
                {
                    DataType bl_ = HospiceAssessment?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.toInterval(context, bm_);
                    CqlInterval<CqlDateTime> bo_ = this.Denominator_Identification_Period(context);
                    CqlDateTime bp_ = context.Operators.Start(bo_);
                    CqlInterval<CqlDate> bq_ = this.Measure_Assessment_Period(context);
                    CqlDate br_ = context.Operators.End(bq_);
                    CqlDateTime bs_ = context.Operators.ConvertDateToDateTime(br_);
                    CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bp_, bs_, true, true);
                    bool? bu_ = context.Operators.Overlaps(bn_, bt_, "day");
                    bk_ = bj_ & bu_;
                }
                // CQL 'and' (128:9-130:77): right operand skipped when left is false
                if (bk_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> bv_ = HospiceAssessment?.StatusElement;
                    ObservationStatus? bw_ = bv_?.Value;
                    string bx_ = context.Operators.Convert<string>(bw_);
                    string[] by_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bz_ = context.Operators.In<string>(bx_, (IEnumerable<string>)by_);
                    return bk_ & bz_;
                }
            }

            bool? be_ = context.Operators.WhereAny<Observation>(bc_, bd_);
            f_ = e_ | be_;
        }
        bool? g_;
        // CQL 'or' (116:3-136:5): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlValueSet ca_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> cb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ca_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

            bool? cc_(ServiceRequest HospiceOrder) {
                FhirDateTime ce_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                CqlInterval<CqlDateTime> cg_ = this.Denominator_Identification_Period(context);
                CqlDateTime ch_ = context.Operators.Start(cg_);
                CqlInterval<CqlDate> ci_ = this.Measure_Assessment_Period(context);
                CqlDate cj_ = context.Operators.End(ci_);
                CqlDateTime ck_ = context.Operators.ConvertDateToDateTime(cj_);
                CqlInterval<CqlDateTime> cl_ = context.Operators.Interval(ch_, ck_, true, true);
                bool? cm_ = context.Operators.In<CqlDateTime>(cf_, cl_, "day");
                bool? cn_;
                // CQL 'and' (133:15-134:62): right operand skipped when left is false
                if (cm_ is false)
                {
                    cn_ = false;
                }
                else
                {
                    Code<RequestStatus> co_ = HospiceOrder?.StatusElement;
                    RequestStatus? cp_ = co_?.Value;
                    Code<RequestStatus> cq_ = context.Operators.Convert<Code<RequestStatus>>(cp_);
                    string cr_ = context.Operators.Convert<string>(cq_);
                    string[] cs_ = [
                        "active",
                        "completed",
                    ];
                    bool? ct_ = context.Operators.In<string>(cr_, (IEnumerable<string>)cs_);
                    cn_ = cm_ & ct_;
                }
                // CQL 'and' (133:9-135:116): right operand skipped when left is false
                if (cn_ is false)
                {
                    return false;
                }
                else
                {
                    Code<RequestIntent> cu_ = HospiceOrder?.IntentElement;
                    RequestIntent? cv_ = cu_?.Value;
                    Code<RequestIntent> cw_ = context.Operators.Convert<Code<RequestIntent>>(cv_);
                    string cx_ = context.Operators.Convert<string>(cw_);
                    string[] cy_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? cz_ = context.Operators.In<string>(cx_, (IEnumerable<string>)cy_);
                    return cn_ & cz_;
                }
            }

            bool? cd_ = context.Operators.WhereAny<ServiceRequest>(cb_, cc_);
            g_ = f_ | cd_;
        }
        bool? h_;
        // CQL 'or' (116:3-140:5): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlValueSet da_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<Procedure> db_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, da_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? dc_(Procedure HospicePerformed) {
                object de_;
                DataType dn_ = HospicePerformed?.Performed;
                object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                bool dp_ = do_ is CqlDateTime;
                if (dp_)
                {
                    DataType dq_ = HospicePerformed?.Performed;
                    object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    de_ = dr_ as CqlDateTime;
                }
                else
                {
                    DataType ds_ = HospicePerformed?.Performed;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    bool du_ = dt_ is CqlQuantity;
                    if (du_)
                    {
                        DataType dv_ = HospicePerformed?.Performed;
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        de_ = dw_ as CqlQuantity;
                    }
                    else
                    {
                        DataType dx_ = HospicePerformed?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        bool dz_ = dy_ is CqlInterval<CqlDateTime>;
                        if (dz_)
                        {
                            DataType ea_ = HospicePerformed?.Performed;
                            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                            de_ = eb_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ec_ = HospicePerformed?.Performed;
                            object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                            bool ee_ = ed_ is CqlInterval<CqlQuantity>;
                            if (ee_)
                            {
                                DataType ef_ = HospicePerformed?.Performed;
                                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                                de_ = eg_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                de_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_);
                CqlInterval<CqlDateTime> dg_ = this.Denominator_Identification_Period(context);
                CqlDateTime dh_ = context.Operators.Start(dg_);
                CqlInterval<CqlDate> di_ = this.Measure_Assessment_Period(context);
                CqlDate dj_ = context.Operators.End(di_);
                CqlDateTime dk_ = context.Operators.ConvertDateToDateTime(dj_);
                CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(dh_, dk_, true, true);
                bool? dm_ = context.Operators.Overlaps(df_, dl_, "day");
                // CQL 'and' (138:9-139:94): right operand skipped when left is false
                if (dm_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> eh_ = HospicePerformed?.StatusElement;
                    EventStatus? ei_ = eh_?.Value;
                    string ej_ = context.Operators.Convert<string>(ei_);
                    string[] ek_ = [
                        "not-done",
                        "entered-in-error",
                        "unknown",
                    ];
                    bool? el_ = context.Operators.In<string>(ej_, (IEnumerable<string>)ek_);
                    return dm_ & !el_;
                }
            }

            bool? dd_ = context.Operators.WhereAny<Procedure>(db_, dc_);
            h_ = g_ | dd_;
        }
        // CQL 'or' (116:3-145:5): right operand skipped when left is true
        if (h_ is true)
        {
            return true;
        }
        else
        {
            CqlValueSet em_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> en_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, em_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> eo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, em_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ep_ = context.Operators.Union<Condition>(en_ as IEnumerable<Condition>, eo_ as IEnumerable<Condition>);

            bool? eq_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> es_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlInterval<CqlDateTime> et_ = this.Denominator_Identification_Period(context);
                CqlDateTime eu_ = context.Operators.Start(et_);
                CqlInterval<CqlDate> ev_ = this.Measure_Assessment_Period(context);
                CqlDate ew_ = context.Operators.End(ev_);
                CqlDateTime ex_ = context.Operators.ConvertDateToDateTime(ew_);
                CqlInterval<CqlDateTime> ey_ = context.Operators.Interval(eu_, ex_, true, true);
                bool? ez_ = context.Operators.Overlaps(es_, ey_, "day");
                // CQL 'and' (143:9-144:49): right operand skipped when left is false
                if (ez_ is false)
                {
                    return false;
                }
                else
                {
                    bool? fa_ = this.isVerified(context, HospiceCareDiagnosis);
                    return ez_ & fa_;
                }
            }

            bool? er_ = context.Operators.WhereAny<Condition>(ep_, eq_);
            return h_ | er_;
        }
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
            DataType h_ = PalliativeAssessment?.Effective;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
            CqlInterval<CqlDateTime> k_ = this.Denominator_Identification_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlInterval<CqlDate> m_ = this.Measure_Assessment_Period(context);
            CqlDate n_ = context.Operators.End(m_);
            CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(l_, o_, true, true);
            bool? q_ = context.Operators.Overlaps(j_, p_, "day");
            // CQL 'and' (157:7-158:78): right operand skipped when left is false
            if (q_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> r_ = PalliativeAssessment?.StatusElement;
                ObservationStatus? s_ = r_?.Value;
                string t_ = context.Operators.Convert<string>(s_);
                string[] u_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
                return q_ & v_;
            }
        }

        bool? e_ = context.Operators.WhereAny<Observation>(c_, d_);
        bool? f_;
        // CQL 'or' (156:3-164:5): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlValueSet w_ = this.Palliative_Care_Diagnosis(context);
            IEnumerable<Condition> x_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> y_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> z_ = context.Operators.Union<Condition>(x_ as IEnumerable<Condition>, y_ as IEnumerable<Condition>);

            bool? aa_(Condition PalliativeDiagnosis) {
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
                CqlInterval<CqlDateTime> ad_ = this.Denominator_Identification_Period(context);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlInterval<CqlDate> af_ = this.Measure_Assessment_Period(context);
                CqlDate ag_ = context.Operators.End(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ae_, ah_, true, true);
                bool? aj_ = context.Operators.Overlaps(ac_, ai_, "day");
                // CQL 'and' (162:9-163:48): right operand skipped when left is false
                if (aj_ is false)
                {
                    return false;
                }
                else
                {
                    bool? ak_ = this.isVerified(context, PalliativeDiagnosis);
                    return aj_ & ak_;
                }
            }

            bool? ab_ = context.Operators.WhereAny<Condition>(z_, aa_);
            f_ = e_ | ab_;
        }
        bool? g_;
        // CQL 'or' (156:3-168:5): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlValueSet al_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? an_(Encounter PalliativeEncounter) {
                Period ap_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                CqlInterval<CqlDateTime> ar_ = this.Denominator_Identification_Period(context);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlInterval<CqlDate> at_ = this.Measure_Assessment_Period(context);
                CqlDate au_ = context.Operators.End(at_);
                CqlDateTime av_ = context.Operators.ConvertDateToDateTime(au_);
                CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(as_, av_, true, true);
                bool? ax_ = context.Operators.Overlaps(aq_, aw_, "day");
                // CQL 'and' (166:9-167:53): right operand skipped when left is false
                if (ax_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> ay_ = PalliativeEncounter?.StatusElement;
                    Encounter.EncounterStatus? az_ = ay_?.Value;
                    Code<Encounter.EncounterStatus> ba_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(az_);
                    bool? bb_ = context.Operators.Equal(ba_, "finished");
                    return ax_ & bb_;
                }
            }

            bool? ao_ = context.Operators.WhereAny<Encounter>(am_, an_);
            g_ = f_ | ao_;
        }
        // CQL 'or' (156:3-172:5): right operand skipped when left is true
        if (g_ is true)
        {
            return true;
        }
        else
        {
            CqlValueSet bc_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> bd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? be_(Procedure PalliativeIntervention) {
                object bg_;
                DataType bp_ = PalliativeIntervention?.Performed;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool br_ = bq_ is CqlDateTime;
                if (br_)
                {
                    DataType bs_ = PalliativeIntervention?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bg_ = bt_ as CqlDateTime;
                }
                else
                {
                    DataType bu_ = PalliativeIntervention?.Performed;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlQuantity;
                    if (bw_)
                    {
                        DataType bx_ = PalliativeIntervention?.Performed;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bg_ = by_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bz_ = PalliativeIntervention?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlInterval<CqlDateTime>;
                        if (cb_)
                        {
                            DataType cc_ = PalliativeIntervention?.Performed;
                            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                            bg_ = cd_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ce_ = PalliativeIntervention?.Performed;
                            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                            bool cg_ = cf_ is CqlInterval<CqlQuantity>;
                            if (cg_)
                            {
                                DataType ch_ = PalliativeIntervention?.Performed;
                                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                                bg_ = ci_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bg_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                CqlInterval<CqlDateTime> bi_ = this.Denominator_Identification_Period(context);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                CqlInterval<CqlDate> bk_ = this.Measure_Assessment_Period(context);
                CqlDate bl_ = context.Operators.End(bk_);
                CqlDateTime bm_ = context.Operators.ConvertDateToDateTime(bl_);
                CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bj_, bm_, true, true);
                bool? bo_ = context.Operators.Overlaps(bh_, bn_, "day");
                // CQL 'and' (170:9-171:100): right operand skipped when left is false
                if (bo_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> cj_ = PalliativeIntervention?.StatusElement;
                    EventStatus? ck_ = cj_?.Value;
                    string cl_ = context.Operators.Convert<string>(ck_);
                    string[] cm_ = [
                        "not-done",
                        "entered-in-error",
                        "unknown",
                    ];
                    bool? cn_ = context.Operators.In<string>(cl_, (IEnumerable<string>)cm_);
                    return bo_ & !cn_;
                }
            }

            bool? bf_ = context.Operators.WhereAny<Procedure>(bd_, be_);
            return g_ | bf_;
        }
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
            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MentalHealthDisorderDiagnoses);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlInterval<CqlDate> x_ = this.Measure_Assessment_Period(context);
            CqlDate y_ = context.Operators.End(x_);
            CqlDateTime z_ = context.Operators.ConvertDateToDateTime(y_);
            bool? aa_ = context.Operators.SameOrBefore(w_, z_, "day");
            // CQL 'and' (103:7-104:56): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                bool? ab_ = this.isVerified(context, MentalHealthDisorderDiagnoses);
                return aa_ & ab_;
            }
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
        bool? b_;
        // CQL 'or' (48:3-49:77): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            bool? d_ = this.Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period(context);
            b_ = a_ | d_;
        }
        bool? c_;
        // CQL 'or' (48:3-50:24): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            bool? e_ = this.Patient_Expired(context);
            c_ = b_ | e_;
        }
        // CQL 'or' (48:3-51:45): right operand skipped when left is true
        if (c_ is true)
        {
            return true;
        }
        else
        {
            bool? f_ = this.Has_Mental_Health_Disorder_Diagnoses(context);
            return c_ | f_;
        }
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
            // CQL 'and' (55:7-56:78): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> x_ = DepressionAssessment?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return w_ & ab_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType ac_ = @this?.Effective;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);
            return af_;
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
            bool? q_ = context.Operators.In<int?>(o_, p_, (string)default);
            return q_;
        }

        IEnumerable<bool?> d_ = context.Operators.SelectDistinct<Observation, bool?>((IEnumerable<Observation>)b_, c_);
        bool? e_ = context.Operators.SingletonFrom<bool?>(d_);
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
            bool? p_ = context.Operators.GreaterOrEqual(o_, 18);
            return p_;
        }

        IEnumerable<bool?> d_ = context.Operators.SelectDistinct<Observation, bool?>((IEnumerable<Observation>)b_, c_);
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
