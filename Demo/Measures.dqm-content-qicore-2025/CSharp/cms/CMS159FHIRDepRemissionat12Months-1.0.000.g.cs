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

            bool? h_() {
                Code<ObservationStatus> i_ = DepressionAssessment?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                return (bool?)((CqlBoolean)m_);
            }

            return (bool?)(/* CQL 'and' (77:5-78:76) */ ((CqlBoolean)g_
                && (CqlBoolean)h_()));
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);

        bool? c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_, g_);

            bool? i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(m_, o_);
                return (bool?)((CqlBoolean)p_);
            }


            bool? j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(r_, t_);
                return (bool?)((CqlBoolean)u_);
            }


            bool? k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                return (bool?)((CqlBoolean)z_);
            }

            return (bool?)(/* CQL 'or' (175:52-179:3) */ (/* CQL 'or' (175:54-177:66) */ (/* CQL 'or' (175:54-176:66) */ ((CqlBoolean)h_
                || (CqlBoolean)i_())
                || (CqlBoolean)j_())
                || (CqlBoolean)k_()));
        }

        return (bool?)(/* CQL 'implies' (175:3-179:3) */ ((CqlBoolean)(!(!((bool?)(b_ is null))))
            || (CqlBoolean)c_()));
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

                bool? l_() {
                    Period n_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                    CqlDateTime p_ = context.Operators.End(o_);
                    CqlInterval<CqlDateTime> q_ = this.Denominator_Identification_Period(context);
                    bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");
                    return (bool?)((CqlBoolean)r_);
                }


                bool? m_() {
                    Code<Encounter.EncounterStatus> s_ = ValidEncounter?.StatusElement;
                    Encounter.EncounterStatus? t_ = s_?.Value;
                    Code<Encounter.EncounterStatus> u_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(t_);
                    bool? v_ = context.Operators.Equal(u_, "finished");
                    return (bool?)((CqlBoolean)v_);
                }

                return (bool?)(/* CQL 'and' (90:17-92:46) */ (/* CQL 'and' (90:17-91:88) */ ((CqlBoolean)k_
                    && (CqlBoolean)l_())
                    && (CqlBoolean)m_()));
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
            Encounter.HospitalizationComponent j_ = InpatientEncounter?.Hospitalization;
            CodeableConcept k_ = j_?.DischargeDisposition;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlCode m_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(l_, n_);

            bool? p_() {
                Encounter.HospitalizationComponent s_ = InpatientEncounter?.Hospitalization;
                CodeableConcept t_ = s_?.DischargeDisposition;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlCode v_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(u_, w_);
                return (bool?)((CqlBoolean)x_);
            }


            bool? q_() {
                Period y_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                CqlDateTime aa_ = context.Operators.End(z_);
                CqlInterval<CqlDateTime> ab_ = this.Denominator_Identification_Period(context);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlInterval<CqlDate> ad_ = this.Measure_Assessment_Period(context);
                CqlDate ae_ = context.Operators.End(ad_);
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ac_, af_, true, true);
                bool? ah_ = context.Operators.In<CqlDateTime>(aa_, ag_, "day");
                return (bool?)((CqlBoolean)ah_);
            }


            bool? r_() {
                Code<Encounter.EncounterStatus> ai_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? aj_ = ai_?.Value;
                Code<Encounter.EncounterStatus> ak_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(aj_);
                bool? al_ = context.Operators.Equal(ak_, "finished");
                return (bool?)((CqlBoolean)al_);
            }

            return (bool?)(/* CQL 'and' (117:7-121:50) */ (/* CQL 'and' (117:13-120:147) */ (/* CQL 'or' (117:13-119:7) */ ((CqlBoolean)o_
                || (CqlBoolean)p_())
                && (CqlBoolean)q_())
                && (CqlBoolean)r_()));
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);

        bool? e_() {
            CqlValueSet am_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> an_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? ao_(Encounter HospiceEncounter) {
                Period aq_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                CqlInterval<CqlDateTime> as_ = this.Denominator_Identification_Period(context);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlInterval<CqlDate> au_ = this.Measure_Assessment_Period(context);
                CqlDate av_ = context.Operators.End(au_);
                CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(at_, aw_, true, true);
                bool? ay_ = context.Operators.Overlaps(ar_, ax_, "day");

                bool? az_() {
                    Code<Encounter.EncounterStatus> ba_ = HospiceEncounter?.StatusElement;
                    Encounter.EncounterStatus? bb_ = ba_?.Value;
                    Code<Encounter.EncounterStatus> bc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bb_);
                    string bd_ = context.Operators.Convert<string>(bc_);
                    string[] be_ = [
                        "cancelled",
                        "entered-in-error",
                        "unknown",
                    ];
                    bool? bf_ = context.Operators.In<string>(bd_, (IEnumerable<string>)be_);
                    return (bool?)((CqlBoolean)!bf_);
                }

                return (bool?)(/* CQL 'and' (124:9-125:95) */ ((CqlBoolean)ay_
                    && (CqlBoolean)az_()));
            }

            bool? ap_ = context.Operators.WhereAny<Encounter>(an_, ao_);
            return (bool?)((CqlBoolean)ap_);
        }


        bool? f_() {
            CqlCode bg_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> bh_ = context.Operators.ToList<CqlCode>(bg_);
            IEnumerable<Observation> bi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? bj_(Observation HospiceAssessment) {
                DataType bl_ = HospiceAssessment?.Value;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                CqlCode bn_ = this.Yes__qualifier_value_(context);
                CqlConcept bo_ = context.Operators.ConvertCodeToConcept(bn_);
                bool? bp_ = context.Operators.Equivalent(bm_ as CqlConcept, bo_);

                bool? bq_() {
                    DataType bs_ = HospiceAssessment?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
                    CqlInterval<CqlDateTime> bv_ = this.Denominator_Identification_Period(context);
                    CqlDateTime bw_ = context.Operators.Start(bv_);
                    CqlInterval<CqlDate> bx_ = this.Measure_Assessment_Period(context);
                    CqlDate by_ = context.Operators.End(bx_);
                    CqlDateTime bz_ = context.Operators.ConvertDateToDateTime(by_);
                    CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bw_, bz_, true, true);
                    bool? cb_ = context.Operators.Overlaps(bu_, ca_, "day");
                    return (bool?)((CqlBoolean)cb_);
                }


                bool? br_() {
                    Code<ObservationStatus> cc_ = HospiceAssessment?.StatusElement;
                    ObservationStatus? cd_ = cc_?.Value;
                    string ce_ = context.Operators.Convert<string>(cd_);
                    string[] cf_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? cg_ = context.Operators.In<string>(ce_, (IEnumerable<string>)cf_);
                    return (bool?)((CqlBoolean)cg_);
                }

                return (bool?)(/* CQL 'and' (128:9-130:77) */ (/* CQL 'and' (128:15-129:163) */ ((CqlBoolean)bp_
                    && (CqlBoolean)bq_())
                    && (CqlBoolean)br_()));
            }

            bool? bk_ = context.Operators.WhereAny<Observation>(bi_, bj_);
            return (bool?)((CqlBoolean)bk_);
        }


        bool? g_() {
            CqlValueSet ch_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> ci_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ch_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

            bool? cj_(ServiceRequest HospiceOrder) {
                FhirDateTime cl_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime cm_ = context.Operators.Convert<CqlDateTime>(cl_);
                CqlInterval<CqlDateTime> cn_ = this.Denominator_Identification_Period(context);
                CqlDateTime co_ = context.Operators.Start(cn_);
                CqlInterval<CqlDate> cp_ = this.Measure_Assessment_Period(context);
                CqlDate cq_ = context.Operators.End(cp_);
                CqlDateTime cr_ = context.Operators.ConvertDateToDateTime(cq_);
                CqlInterval<CqlDateTime> cs_ = context.Operators.Interval(co_, cr_, true, true);
                bool? ct_ = context.Operators.In<CqlDateTime>(cm_, cs_, "day");

                bool? cu_() {
                    Code<RequestStatus> cw_ = HospiceOrder?.StatusElement;
                    RequestStatus? cx_ = cw_?.Value;
                    Code<RequestStatus> cy_ = context.Operators.Convert<Code<RequestStatus>>(cx_);
                    string cz_ = context.Operators.Convert<string>(cy_);
                    string[] da_ = [
                        "active",
                        "completed",
                    ];
                    bool? db_ = context.Operators.In<string>(cz_, (IEnumerable<string>)da_);
                    return (bool?)((CqlBoolean)db_);
                }


                bool? cv_() {
                    Code<RequestIntent> dc_ = HospiceOrder?.IntentElement;
                    RequestIntent? dd_ = dc_?.Value;
                    Code<RequestIntent> de_ = context.Operators.Convert<Code<RequestIntent>>(dd_);
                    string df_ = context.Operators.Convert<string>(de_);
                    string[] dg_ = [
                        "order",
                        "original-order",
                        "reflex-order",
                        "filler-order",
                        "instance-order",
                    ];
                    bool? dh_ = context.Operators.In<string>(df_, (IEnumerable<string>)dg_);
                    return (bool?)((CqlBoolean)dh_);
                }

                return (bool?)(/* CQL 'and' (133:9-135:116) */ (/* CQL 'and' (133:15-134:62) */ ((CqlBoolean)ct_
                    && (CqlBoolean)cu_())
                    && (CqlBoolean)cv_()));
            }

            bool? ck_ = context.Operators.WhereAny<ServiceRequest>(ci_, cj_);
            return (bool?)((CqlBoolean)ck_);
        }


        bool? h_() {
            CqlValueSet di_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<Procedure> dj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, di_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? dk_(Procedure HospicePerformed) {
                object dm_;
                DataType dw_ = HospicePerformed?.Performed;
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                bool dy_ = dx_ is CqlDateTime;
                if (dy_)
                {
                    dm_ = dx_ as CqlDateTime;
                }
                else
                {
                    bool dz_ = dx_ is CqlQuantity;
                    if (dz_)
                    {
                        dm_ = dx_ as CqlQuantity;
                    }
                    else
                    {
                        bool ea_ = dx_ is CqlInterval<CqlDateTime>;
                        if (ea_)
                        {
                            dm_ = dx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool eb_ = dx_ is CqlInterval<CqlQuantity>;
                            if (eb_)
                            {
                                dm_ = dx_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dm_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> dn_ = QICoreCommon_4_0_000.Instance.toInterval(context, dm_);
                CqlInterval<CqlDateTime> do_ = this.Denominator_Identification_Period(context);
                CqlDateTime dp_ = context.Operators.Start(do_);
                CqlInterval<CqlDate> dq_ = this.Measure_Assessment_Period(context);
                CqlDate dr_ = context.Operators.End(dq_);
                CqlDateTime ds_ = context.Operators.ConvertDateToDateTime(dr_);
                CqlInterval<CqlDateTime> dt_ = context.Operators.Interval(dp_, ds_, true, true);
                bool? du_ = context.Operators.Overlaps(dn_, dt_, "day");

                bool? dv_() {
                    Code<EventStatus> ec_ = HospicePerformed?.StatusElement;
                    EventStatus? ed_ = ec_?.Value;
                    string ee_ = context.Operators.Convert<string>(ed_);
                    string[] ef_ = [
                        "not-done",
                        "entered-in-error",
                        "unknown",
                    ];
                    bool? eg_ = context.Operators.In<string>(ee_, (IEnumerable<string>)ef_);
                    return (bool?)((CqlBoolean)!eg_);
                }

                return (bool?)(/* CQL 'and' (138:9-139:94) */ ((CqlBoolean)du_
                    && (CqlBoolean)dv_()));
            }

            bool? dl_ = context.Operators.WhereAny<Procedure>(dj_, dk_);
            return (bool?)((CqlBoolean)dl_);
        }


        bool? i_() {
            CqlValueSet eh_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> ei_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, eh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ej_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, eh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ek_ = context.Operators.Union<Condition>(ei_ as IEnumerable<Condition>, ej_ as IEnumerable<Condition>);

            bool? el_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> en_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlInterval<CqlDateTime> eo_ = this.Denominator_Identification_Period(context);
                CqlDateTime ep_ = context.Operators.Start(eo_);
                CqlInterval<CqlDate> eq_ = this.Measure_Assessment_Period(context);
                CqlDate er_ = context.Operators.End(eq_);
                CqlDateTime es_ = context.Operators.ConvertDateToDateTime(er_);
                CqlInterval<CqlDateTime> et_ = context.Operators.Interval(ep_, es_, true, true);
                bool? eu_ = context.Operators.Overlaps(en_, et_, "day");
                return (bool?)(/* CQL 'and' (143:9-144:49) */ ((CqlBoolean)eu_
                    && (CqlBoolean)(this.isVerified(context, HospiceCareDiagnosis))));
            }

            bool? em_ = context.Operators.WhereAny<Condition>(ek_, el_);
            return (bool?)((CqlBoolean)em_);
        }

        return (bool?)(/* CQL 'or' (116:3-145:5) */ (/* CQL 'or' (116:3-140:5) */ (/* CQL 'or' (116:3-136:5) */ (/* CQL 'or' (116:3-131:5) */ (/* CQL 'or' (116:3-126:5) */ ((CqlBoolean)d_
            || (CqlBoolean)e_())
            || (CqlBoolean)f_())
            || (CqlBoolean)g_())
            || (CqlBoolean)h_())
            || (CqlBoolean)i_()));
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
            DataType i_ = PalliativeAssessment?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            CqlInterval<CqlDateTime> l_ = this.Denominator_Identification_Period(context);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlInterval<CqlDate> n_ = this.Measure_Assessment_Period(context);
            CqlDate o_ = context.Operators.End(n_);
            CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(m_, p_, true, true);
            bool? r_ = context.Operators.Overlaps(k_, q_, "day");

            bool? s_() {
                Code<ObservationStatus> t_ = PalliativeAssessment?.StatusElement;
                ObservationStatus? u_ = t_?.Value;
                string v_ = context.Operators.Convert<string>(u_);
                string[] w_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                return (bool?)((CqlBoolean)x_);
            }

            return (bool?)(/* CQL 'and' (157:7-158:78) */ ((CqlBoolean)r_
                && (CqlBoolean)s_()));
        }

        bool? e_ = context.Operators.WhereAny<Observation>(c_, d_);

        bool? f_() {
            CqlValueSet y_ = this.Palliative_Care_Diagnosis(context);
            IEnumerable<Condition> z_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> aa_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ab_ = context.Operators.Union<Condition>(z_ as IEnumerable<Condition>, aa_ as IEnumerable<Condition>);

            bool? ac_(Condition PalliativeDiagnosis) {
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
                CqlInterval<CqlDateTime> af_ = this.Denominator_Identification_Period(context);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlInterval<CqlDate> ah_ = this.Measure_Assessment_Period(context);
                CqlDate ai_ = context.Operators.End(ah_);
                CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ag_, aj_, true, true);
                bool? al_ = context.Operators.Overlaps(ae_, ak_, "day");
                return (bool?)(/* CQL 'and' (162:9-163:48) */ ((CqlBoolean)al_
                    && (CqlBoolean)(this.isVerified(context, PalliativeDiagnosis))));
            }

            bool? ad_ = context.Operators.WhereAny<Condition>(ab_, ac_);
            return (bool?)((CqlBoolean)ad_);
        }


        bool? g_() {
            CqlValueSet am_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> an_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? ao_(Encounter PalliativeEncounter) {
                Period aq_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                CqlInterval<CqlDateTime> as_ = this.Denominator_Identification_Period(context);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlInterval<CqlDate> au_ = this.Measure_Assessment_Period(context);
                CqlDate av_ = context.Operators.End(au_);
                CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(at_, aw_, true, true);
                bool? ay_ = context.Operators.Overlaps(ar_, ax_, "day");

                bool? az_() {
                    Code<Encounter.EncounterStatus> ba_ = PalliativeEncounter?.StatusElement;
                    Encounter.EncounterStatus? bb_ = ba_?.Value;
                    Code<Encounter.EncounterStatus> bc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bb_);
                    bool? bd_ = context.Operators.Equal(bc_, "finished");
                    return (bool?)((CqlBoolean)bd_);
                }

                return (bool?)(/* CQL 'and' (166:9-167:53) */ ((CqlBoolean)ay_
                    && (CqlBoolean)az_()));
            }

            bool? ap_ = context.Operators.WhereAny<Encounter>(an_, ao_);
            return (bool?)((CqlBoolean)ap_);
        }


        bool? h_() {
            CqlValueSet be_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> bf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? bg_(Procedure PalliativeIntervention) {
                object bi_;
                DataType bs_ = PalliativeIntervention?.Performed;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    bi_ = bt_ as CqlDateTime;
                }
                else
                {
                    bool bv_ = bt_ is CqlQuantity;
                    if (bv_)
                    {
                        bi_ = bt_ as CqlQuantity;
                    }
                    else
                    {
                        bool bw_ = bt_ is CqlInterval<CqlDateTime>;
                        if (bw_)
                        {
                            bi_ = bt_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bx_ = bt_ is CqlInterval<CqlQuantity>;
                            if (bx_)
                            {
                                bi_ = bt_ as CqlInterval<CqlQuantity>;
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
                bool? bq_ = context.Operators.Overlaps(bj_, bp_, "day");

                bool? br_() {
                    Code<EventStatus> by_ = PalliativeIntervention?.StatusElement;
                    EventStatus? bz_ = by_?.Value;
                    string ca_ = context.Operators.Convert<string>(bz_);
                    string[] cb_ = [
                        "not-done",
                        "entered-in-error",
                        "unknown",
                    ];
                    bool? cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);
                    return (bool?)((CqlBoolean)!cc_);
                }

                return (bool?)(/* CQL 'and' (170:9-171:100) */ ((CqlBoolean)bq_
                    && (CqlBoolean)br_()));
            }

            bool? bh_ = context.Operators.WhereAny<Procedure>(bf_, bg_);
            return (bool?)((CqlBoolean)bh_);
        }

        return (bool?)(/* CQL 'or' (156:3-172:5) */ (/* CQL 'or' (156:3-168:5) */ (/* CQL 'or' (156:3-164:5) */ ((CqlBoolean)e_
            || (CqlBoolean)f_())
            || (CqlBoolean)g_())
            || (CqlBoolean)h_()));
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
            return (bool?)(/* CQL 'and' (103:7-104:56) */ ((CqlBoolean)aa_
                && (CqlBoolean)(this.isVerified(context, MentalHealthDisorderDiagnoses))));
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
        return (bool?)(/* CQL 'or' (48:3-51:45) */ (/* CQL 'or' (48:3-50:24) */ (/* CQL 'or' (48:3-49:77) */ ((CqlBoolean)a_
            || (CqlBoolean)(this.Has_Palliative_Care_prior_to_or_during_the_Measure_Assessment_Period(context)))
            || (CqlBoolean)(this.Patient_Expired(context)))
            || (CqlBoolean)(this.Has_Mental_Health_Disorder_Diagnoses(context))));
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

            bool? x_() {
                Code<ObservationStatus> y_ = DepressionAssessment?.StatusElement;
                ObservationStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                return (bool?)((CqlBoolean)ac_);
            }

            return (bool?)(/* CQL 'and' (55:7-56:78) */ ((CqlBoolean)w_
                && (CqlBoolean)x_()));
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
