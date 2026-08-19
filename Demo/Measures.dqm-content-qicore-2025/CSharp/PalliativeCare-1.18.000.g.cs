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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -4886154237025043938L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        object? a_ = context.ResolveParameter("PalliativeCare-1.18.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime?>?)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (2)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4588885595111730164L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Palliative_Care_in_the_Measurement_Period, Has_Palliative_Care_in_the_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Palliative_Care_in_the_Measurement_Period = -7555297037410945889L;

    private bool? Has_Palliative_Care_in_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

        bool? e_(Observation? PalliativeAssessment) {
            DataType? aa_ = PalliativeAssessment?.Effective;
            object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlInterval<CqlDateTime?>? ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
            CqlInterval<CqlDateTime?>? ad_ = this.Measurement_Period(context);
            bool? ae_ = context.Operators.Overlaps(ac_, ad_, "day");
            return ae_;
        }

        bool? f_ = context.Operators.WhereAny<Observation>(d_, e_);
        CqlValueSet? g_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition?>? h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? j_ = context.Operators.Union<Condition>(h_ as IEnumerable<Condition?>?, i_ as IEnumerable<Condition?>?);
        IEnumerable<Condition?>? k_ = Status_1_15_000.Instance.verified(context, j_);

        bool? l_(Condition? PalliativeDiagnosis) {
            CqlInterval<CqlDateTime?>? af_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime?>? ag_ = this.Measurement_Period(context);
            bool? ah_ = context.Operators.Overlaps(af_, ag_, "day");
            return ah_;
        }

        bool? m_ = context.Operators.WhereAny<Condition>(k_, l_);
        bool? n_ = context.Operators.Or(f_, m_);
        CqlValueSet? o_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter?>? p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? q_ = Status_1_15_000.Instance.isEncounterPerformed(context, p_);

        bool? r_(Encounter? PalliativeEncounter) {
            Period? ai_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime?>? aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
            CqlInterval<CqlDateTime?>? ak_ = this.Measurement_Period(context);
            bool? al_ = context.Operators.Overlaps(aj_, ak_, "day");
            return al_;
        }

        bool? s_ = context.Operators.WhereAny<Encounter>(q_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlValueSet? u_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure?>? v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure?>? w_ = Status_1_15_000.Instance.isInterventionPerformed(context, v_);

        bool? x_(Procedure? PalliativeIntervention) {
            object? am_;
            DataType? aq_ = PalliativeIntervention?.Performed;
            object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            bool as_ = ar_ is CqlDateTime;
            if (as_)
            {
                DataType? at_ = PalliativeIntervention?.Performed;
                object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                am_ = au_ as CqlDateTime?;
            }
            else
            {
                DataType? av_ = PalliativeIntervention?.Performed;
                object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                bool ax_ = aw_ is CqlQuantity;
                if (ax_)
                {
                    DataType? ay_ = PalliativeIntervention?.Performed;
                    object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    am_ = az_ as CqlQuantity?;
                }
                else
                {
                    DataType? ba_ = PalliativeIntervention?.Performed;
                    object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlInterval<CqlDateTime>;
                    if (bc_)
                    {
                        DataType? bd_ = PalliativeIntervention?.Performed;
                        object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        am_ = be_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? bf_ = PalliativeIntervention?.Performed;
                        object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlInterval<CqlQuantity>;
                        if (bh_)
                        {
                            DataType? bi_ = PalliativeIntervention?.Performed;
                            object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            am_ = bj_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            am_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlInterval<CqlDateTime?>? ao_ = this.Measurement_Period(context);
            bool? ap_ = context.Operators.Overlaps(an_, ao_, "day");
            return ap_;
        }

        bool? y_ = context.Operators.WhereAny<Procedure>(w_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        return z_;
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
