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
            DataType i_ = PalliativeAssessment?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.Overlaps(k_, l_, "day");
            return m_;
        }

        bool? f_ = context.Operators.WhereAny<Observation>(d_, e_);
        bool? g_;
        // CQL 'or' (22:3-28:5): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlValueSet n_ = this.Palliative_Care_Diagnosis(context);
            IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> q_ = context.Operators.Union<Condition>(o_ as IEnumerable<Condition>, p_ as IEnumerable<Condition>);
            IEnumerable<Condition> r_ = Status_1_15_000.Instance.verified(context, q_);

            bool? s_(Condition PalliativeDiagnosis) {
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
                CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                bool? w_ = context.Operators.Overlaps(u_, v_, "day");
                return w_;
            }

            bool? t_ = context.Operators.WhereAny<Condition>(r_, s_);
            g_ = f_ | t_;
        }
        bool? h_;
        // CQL 'or' (22:3-31:5): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlValueSet x_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> z_ = Status_1_15_000.Instance.isEncounterPerformed(context, y_);

            bool? aa_(Encounter PalliativeEncounter) {
                Period ac_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
                bool? af_ = context.Operators.Overlaps(ad_, ae_, "day");
                return af_;
            }

            bool? ab_ = context.Operators.WhereAny<Encounter>(z_, aa_);
            h_ = g_ | ab_;
        }
        // CQL 'or' (22:3-34:5): right operand skipped when left is true
        if (h_ is true)
        {
            return true;
        }
        else
        {
            CqlValueSet ag_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> ah_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> ai_ = Status_1_15_000.Instance.isInterventionPerformed(context, ah_);

            bool? aj_(Procedure PalliativeIntervention) {
                object al_;
                DataType ap_ = PalliativeIntervention?.Performed;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                bool ar_ = aq_ is CqlDateTime;
                if (ar_)
                {
                    DataType as_ = PalliativeIntervention?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    al_ = at_ as CqlDateTime;
                }
                else
                {
                    DataType au_ = PalliativeIntervention?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlQuantity;
                    if (aw_)
                    {
                        DataType ax_ = PalliativeIntervention?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        al_ = ay_ as CqlQuantity;
                    }
                    else
                    {
                        DataType az_ = PalliativeIntervention?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            DataType bc_ = PalliativeIntervention?.Performed;
                            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                            al_ = bd_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType be_ = PalliativeIntervention?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            bool bg_ = bf_ is CqlInterval<CqlQuantity>;
                            if (bg_)
                            {
                                DataType bh_ = PalliativeIntervention?.Performed;
                                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                                al_ = bi_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                al_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlInterval<CqlDateTime> an_ = this.Measurement_Period(context);
                bool? ao_ = context.Operators.Overlaps(am_, an_, "day");
                return ao_;
            }

            bool? ak_ = context.Operators.WhereAny<Procedure>(ai_, aj_);
            return h_ | ak_;
        }
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
