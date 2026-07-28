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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("PalliativeCare", "1.18.000")]
public partial class PalliativeCare_1_18_000 : ILibrary, ISingleton<PalliativeCare_1_18_000>
{
    #region ValueSets (3)

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlValueSetDefinition("Palliative Care Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Diagnosis(CqlContext _) => _Palliative_Care_Diagnosis;
    private static readonly CqlValueSet _Palliative_Care_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -4886154237025043938L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("PalliativeCare-1.18.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (2)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4588885595111730164L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Palliative_Care_in_the_Measurement_Period, Has_Palliative_Care_in_the_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Palliative_Care_in_the_Measurement_Period = -7555297037410945889L;

    private bool? Has_Palliative_Care_in_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

        bool? e_(Observation PalliativeAssessment) {
            DataType ae_ = PalliativeAssessment?.Effective;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            bool? ai_ = context.Operators.Overlaps(ag_, ah_, "day");
            return ai_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        CqlValueSet h_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> k_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition>, j_ as IEnumerable<Condition>);
        IEnumerable<Condition> l_ = Status_1_15_000.Instance.verified(context, k_);

        bool? m_(Condition PalliativeDiagnosis) {
            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
            bool? al_ = context.Operators.Overlaps(aj_, ak_, "day");
            return al_;
        }

        IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
        bool? o_ = context.Operators.Exists<Condition>(n_);
        bool? p_ = context.Operators.Or(g_, o_);
        CqlValueSet q_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> r_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> s_ = Status_1_15_000.Instance.isEncounterPerformed(context, r_);

        bool? t_(Encounter PalliativeEncounter) {
            Period am_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
            CqlInterval<CqlDateTime> ao_ = this.Measurement_Period(context);
            bool? ap_ = context.Operators.Overlaps(an_, ao_, "day");
            return ap_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        bool? v_ = context.Operators.Exists<Encounter>(u_);
        bool? w_ = context.Operators.Or(p_, v_);
        CqlValueSet x_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> y_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> z_ = Status_1_15_000.Instance.isInterventionPerformed(context, y_);

        bool? aa_(Procedure PalliativeIntervention) {

            object aq_() {

                bool au_() {
                    DataType ay_ = PalliativeIntervention?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlDateTime;
                    return ba_;
                }


                bool av_() {
                    DataType bb_ = PalliativeIntervention?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlQuantity;
                    return bd_;
                }


                bool aw_() {
                    DataType be_ = PalliativeIntervention?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    return bg_;
                }


                bool ax_() {
                    DataType bh_ = PalliativeIntervention?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                    return bj_;
                }

                if (au_())
                {
                    DataType bk_ = PalliativeIntervention?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return bl_ as CqlDateTime;
                }
                else if (av_())
                {
                    DataType bm_ = PalliativeIntervention?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    return bn_ as CqlQuantity;
                }
                else if (aw_())
                {
                    DataType bo_ = PalliativeIntervention?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return bp_ as CqlInterval<CqlDateTime>;
                }
                else if (ax_())
                {
                    DataType bq_ = PalliativeIntervention?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    return br_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_());
            CqlInterval<CqlDateTime> as_ = this.Measurement_Period(context);
            bool? at_ = context.Operators.Overlaps(ar_, as_, "day");
            return at_;
        }

        IEnumerable<Procedure> ab_ = context.Operators.Where<Procedure>(z_, aa_);
        bool? ac_ = context.Operators.Exists<Procedure>(ab_);
        bool? ad_ = context.Operators.Or(w_, ac_);
        return ad_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private PalliativeCare_1_18_000() {}

    public static PalliativeCare_1_18_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "PalliativeCare";
    public string Version => "1.18.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
