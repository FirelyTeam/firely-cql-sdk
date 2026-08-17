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
            DataType j_ = PalliativeAssessment?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            bool? n_ = context.Operators.Overlaps(l_, m_, "day");
            return n_;
        }

        bool? f_ = context.Operators.WhereAny<Observation>(d_, e_);

        bool? g_() {
            CqlValueSet o_ = this.Palliative_Care_Diagnosis(context);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> r_ = context.Operators.Union<Condition>(p_ as IEnumerable<Condition>, q_ as IEnumerable<Condition>);
            IEnumerable<Condition> s_ = Status_1_15_000.Instance.verified(context, r_);

            bool? t_(Condition PalliativeDiagnosis) {
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                bool? x_ = context.Operators.Overlaps(v_, w_, "day");
                return x_;
            }

            bool? u_ = context.Operators.WhereAny<Condition>(s_, t_);
            return (bool?)((CqlBoolean)u_);
        }


        bool? h_() {
            CqlValueSet y_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> aa_ = Status_1_15_000.Instance.isEncounterPerformed(context, z_);

            bool? ab_(Encounter PalliativeEncounter) {
                Period ad_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
                bool? ag_ = context.Operators.Overlaps(ae_, af_, "day");
                return ag_;
            }

            bool? ac_ = context.Operators.WhereAny<Encounter>(aa_, ab_);
            return (bool?)((CqlBoolean)ac_);
        }


        bool? i_() {
            CqlValueSet ah_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> ai_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> aj_ = Status_1_15_000.Instance.isInterventionPerformed(context, ai_);

            bool? ak_(Procedure PalliativeIntervention) {
                object am_;
                DataType aq_ = PalliativeIntervention?.Performed;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool as_ = ar_ is CqlDateTime;
                if (as_)
                {
                    am_ = ar_ as CqlDateTime;
                }
                else
                {
                    bool at_ = ar_ is CqlQuantity;
                    if (at_)
                    {
                        am_ = ar_ as CqlQuantity;
                    }
                    else
                    {
                        bool au_ = ar_ is CqlInterval<CqlDateTime>;
                        if (au_)
                        {
                            am_ = ar_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool av_ = ar_ is CqlInterval<CqlQuantity>;
                            if (av_)
                            {
                                am_ = ar_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                am_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
                CqlInterval<CqlDateTime> ao_ = this.Measurement_Period(context);
                bool? ap_ = context.Operators.Overlaps(an_, ao_, "day");
                return ap_;
            }

            bool? al_ = context.Operators.WhereAny<Procedure>(aj_, ak_);
            return (bool?)((CqlBoolean)al_);
        }

        return (bool?)(/* CQL 'or' (22:3-34:5) */ (/* CQL 'or' (22:3-31:5) */ (/* CQL 'or' (22:3-28:5) */ ((CqlBoolean)f_
            || (CqlBoolean)g_())
            || (CqlBoolean)h_())
            || (CqlBoolean)i_()));
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
