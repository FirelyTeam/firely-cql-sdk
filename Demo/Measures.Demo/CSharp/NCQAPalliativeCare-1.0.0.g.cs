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
[CqlLibrary("NCQAPalliativeCare", "1.0.0")]
public partial class NCQAPalliativeCare_1_0_0 : ILibrary, ISingleton<NCQAPalliativeCare_1_0_0>
{
    #region ValueSets (3)

    [CqlValueSetDefinition("Palliative Care Assessment", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Assessment(CqlContext _) => _Palliative_Care_Assessment;
    private static readonly CqlValueSet _Palliative_Care_Assessment = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", null);

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Encounter for palliative care", codeId: "Z51.5", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext _) => _Encounter_for_palliative_care;
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("ICD-10", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD_10(CqlContext _) => _ICD_10;
    private static readonly CqlCodeSystem _ICD_10 =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Encounter_for_palliative_care]);

    #endregion CodeSystems

    #region Functions and Expressions (1)

    [CqlFunctionDefinition("Palliative Care Overlapping Period")]
    public bool? Palliative_Care_Overlapping_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlValueSet a_ = this.Palliative_Care_Assessment(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation PalliativeAssessment) {
            DataType ab_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> ac_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ab_);
            CqlDateTime ad_ = context.Operators.Start(ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlDateTime af_ = context.Operators.End(ac_);
            CqlDate ag_ = context.Operators.DateFrom(af_);
            CqlInterval<CqlDate> ah_ = context.Operators.Interval(ae_, ag_, true, true);
            CqlDateTime ai_ = context.Operators.Start(Period);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            CqlDateTime ak_ = context.Operators.End(Period);
            CqlDate al_ = context.Operators.DateFrom(ak_);
            CqlInterval<CqlDate> am_ = context.Operators.Interval(aj_, al_, true, true);
            bool? an_ = context.Operators.Overlaps(ah_, am_, (string)default);
            return an_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        bool? e_ = context.Operators.Exists<Observation>(d_);
        CqlValueSet f_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> h_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, g_);

        bool? i_(Encounter PalliativeEncounter) {
            Period ao_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ap_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ao_);
            CqlDateTime aq_ = context.Operators.Start(ap_);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDateTime as_ = context.Operators.End(ap_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            CqlInterval<CqlDate> au_ = context.Operators.Interval(ar_, at_, true, true);
            CqlDateTime av_ = context.Operators.Start(Period);
            CqlDate aw_ = context.Operators.DateFrom(av_);
            CqlDateTime ax_ = context.Operators.End(Period);
            CqlDate ay_ = context.Operators.DateFrom(ax_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(aw_, ay_, true, true);
            bool? ba_ = context.Operators.Overlaps(au_, az_, (string)default);
            return ba_;
        }

        IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);
        bool? l_ = context.Operators.Or(e_, k_);
        CqlValueSet m_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> n_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> o_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, n_);

        bool? p_(Procedure PalliativeIntervention) {
            DataType bb_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> bc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bb_);
            CqlDateTime bd_ = context.Operators.Start(bc_);
            CqlDate be_ = context.Operators.DateFrom(bd_);
            CqlDateTime bf_ = context.Operators.End(bc_);
            CqlDate bg_ = context.Operators.DateFrom(bf_);
            CqlInterval<CqlDate> bh_ = context.Operators.Interval(be_, bg_, true, true);
            CqlDateTime bi_ = context.Operators.Start(Period);
            CqlDate bj_ = context.Operators.DateFrom(bi_);
            CqlDateTime bk_ = context.Operators.End(Period);
            CqlDate bl_ = context.Operators.DateFrom(bk_);
            CqlInterval<CqlDate> bm_ = context.Operators.Interval(bj_, bl_, true, true);
            bool? bn_ = context.Operators.Overlaps(bh_, bm_, (string)default);
            return bn_;
        }

        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        bool? r_ = context.Operators.Exists<Procedure>(q_);
        bool? s_ = context.Operators.Or(l_, r_);
        CqlCode t_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
        IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, u_, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> w_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, v_);

        bool? x_(Condition PalliativeDiagnosis) {
            CqlInterval<CqlDateTime> bo_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
            CqlDateTime bp_ = context.Operators.Start(bo_);
            CqlDate bq_ = context.Operators.DateFrom(bp_);
            CqlDateTime br_ = context.Operators.End(bo_);
            CqlDate bs_ = context.Operators.DateFrom(br_);
            CqlInterval<CqlDate> bt_ = context.Operators.Interval(bq_, bs_, true, true);
            CqlDateTime bu_ = context.Operators.Start(Period);
            CqlDate bv_ = context.Operators.DateFrom(bu_);
            CqlDateTime bw_ = context.Operators.End(Period);
            CqlDate bx_ = context.Operators.DateFrom(bw_);
            CqlInterval<CqlDate> by_ = context.Operators.Interval(bv_, bx_, true, true);
            bool? bz_ = context.Operators.Overlaps(bt_, by_, (string)default);
            return bz_;
        }

        IEnumerable<Condition> y_ = context.Operators.Where<Condition>(w_, x_);
        bool? z_ = context.Operators.Exists<Condition>(y_);
        bool? aa_ = context.Operators.Or(s_, z_);
        return aa_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAPalliativeCare_1_0_0() {}

    public static NCQAPalliativeCare_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAPalliativeCare";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance];

    #endregion ILibrary Implementation

}
