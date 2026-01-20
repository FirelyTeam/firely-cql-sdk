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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("PalliativeCare", "1.18.000")]
public partial class PalliativeCare_1_18_000 : ILibrary, ILibraryInternals, ISingleton<PalliativeCare_1_18_000>
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
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(
            _cacheIndex_Measurement_Period,
            Measurement_Period_Compute);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("PalliativeCare-1.18.000", "Measurement Period", null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (2)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(
            _cacheIndex_Patient,
            Patient_Compute);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_Has_Palliative_Care_in_the_Measurement_Period,
            Has_Palliative_Care_in_the_Measurement_Period_Compute);

    private bool? Has_Palliative_Care_in_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

        bool? e_(Observation PalliativeAssessment) {
            DataType af_ = PalliativeAssessment?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
            bool? aj_ = context.Operators.Overlaps(ah_, ai_, "day");
            return aj_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        CqlValueSet h_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> l_ = context.Operators.Union<object>(i_ as IEnumerable<object>, k_ as IEnumerable<object>);
        IEnumerable<object> m_ = Status_1_15_000.Instance.verified(context, l_);

        bool? n_(object PalliativeDiagnosis) {
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> al_ = this.Measurement_Period(context);
            bool? am_ = context.Operators.Overlaps(ak_, al_, "day");
            return am_;
        }

        IEnumerable<object> o_ = context.Operators.Where<object>(m_, n_);
        bool? p_ = context.Operators.Exists<object>(o_);
        bool? q_ = context.Operators.Or(g_, p_);
        CqlValueSet r_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> t_ = Status_1_15_000.Instance.isEncounterPerformed(context, s_);

        bool? u_(Encounter PalliativeEncounter) {
            Period an_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
            CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
            bool? aq_ = context.Operators.Overlaps(ao_, ap_, "day");
            return aq_;
        }

        IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
        bool? w_ = context.Operators.Exists<Encounter>(v_);
        bool? x_ = context.Operators.Or(q_, w_);
        CqlValueSet y_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> z_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> aa_ = Status_1_15_000.Instance.isInterventionPerformed(context, z_);

        bool? ab_(Procedure PalliativeIntervention) {

            object ar_() {

                bool av_() {
                    DataType az_ = PalliativeIntervention?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlDateTime;
                    return bb_;
                }


                bool aw_() {
                    DataType bc_ = PalliativeIntervention?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlInterval<CqlDateTime>;
                    return be_;
                }


                bool ax_() {
                    DataType bf_ = PalliativeIntervention?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlQuantity;
                    return bh_;
                }


                bool ay_() {
                    DataType bi_ = PalliativeIntervention?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlInterval<CqlQuantity>;
                    return bk_;
                }

                if (av_())
                {
                    DataType bl_ = PalliativeIntervention?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bm_ as CqlDateTime) as object;
                }
                else if (aw_())
                {
                    DataType bn_ = PalliativeIntervention?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return (bo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ax_())
                {
                    DataType bp_ = PalliativeIntervention?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return (bq_ as CqlQuantity) as object;
                }
                else if (ay_())
                {
                    DataType br_ = PalliativeIntervention?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    return (bs_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_());
            CqlInterval<CqlDateTime> at_ = this.Measurement_Period(context);
            bool? au_ = context.Operators.Overlaps(as_, at_, "day");
            return au_;
        }

        IEnumerable<Procedure> ac_ = context.Operators.Where<Procedure>(aa_, ab_);
        bool? ad_ = context.Operators.Exists<Procedure>(ac_);
        bool? ae_ = context.Operators.Or(x_, ad_);
        return ae_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (3)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Has_Palliative_Care_in_the_Measurement_Period = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    bool ILibraryInternals.CacheIndicesInitialized { get; set; }

    int ILibraryInternals.InitializeCacheIndices(CacheIndexInitializer initializer)
    {
        // Skip if already processed
        if (!initializer.MarkAsProcessed(this))
            return 0;

        var count = 0;

        // Process dependencies first (depth-first traversal)
        if (Dependencies is { Length: > 0 })
        {
            foreach (var dependency in Dependencies)
            {
                if (dependency is ILibraryInternals internals)
                {
                    count += internals.InitializeCacheIndices(initializer);
                }
            }
        }

        // Initialize cache indices for this library
        if (_cacheIndex_Measurement_Period != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Measurement_Period' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Measurement_Period}}. Cache indices can only be initialized once.");
        _cacheIndex_Measurement_Period = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Patient != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Patient' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Patient}}. Cache indices can only be initialized once.");
        _cacheIndex_Patient = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Has_Palliative_Care_in_the_Measurement_Period != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Has_Palliative_Care_in_the_Measurement_Period' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Has_Palliative_Care_in_the_Measurement_Period}}. Cache indices can only be initialized once.");
        _cacheIndex_Has_Palliative_Care_in_the_Measurement_Period = initializer.GetNextIndex();
        count++;

        return count;
    }

    #endregion ILibraryInternals Implementation

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
