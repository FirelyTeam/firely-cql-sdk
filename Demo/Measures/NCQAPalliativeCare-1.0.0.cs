using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("NCQAPalliativeCare", "1.0.0")]
public class NCQAPalliativeCare_1_0_0
{

    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Palliative_Care_Assessment;
    internal Lazy<CqlValueSet> __Palliative_Care_Encounter;
    internal Lazy<CqlValueSet> __Palliative_Care_Intervention;
    internal Lazy<CqlCode> __Encounter_for_palliative_care;
    internal Lazy<CqlCode[]> __ICD_10;

    #endregion
    public NCQAPalliativeCare_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);
        NCQAStatus_1_0_0 = new NCQAStatus_1_0_0(context);

        __Palliative_Care_Assessment = new Lazy<CqlValueSet>(this.Palliative_Care_Assessment_Value(context));
        __Palliative_Care_Encounter = new Lazy<CqlValueSet>(this.Palliative_Care_Encounter_Value(context));
        __Palliative_Care_Intervention = new Lazy<CqlValueSet>(this.Palliative_Care_Intervention_Value(context));
        __Encounter_for_palliative_care = new Lazy<CqlCode>(this.Encounter_for_palliative_care_Value(context));
        __ICD_10 = new Lazy<CqlCode[]>(this.ICD_10_Value(context));
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }
    public NCQAStatus_1_0_0 NCQAStatus_1_0_0 { get; }

    #endregion

	private CqlValueSet Palliative_Care_Assessment_Value(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", null);

    [CqlDeclaration("Palliative Care Assessment")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225")]
	public CqlValueSet Palliative_Care_Assessment() => 
		__Palliative_Care_Assessment?.Value;

	private CqlValueSet Palliative_Care_Encounter_Value(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", null);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450")]
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter?.Value;

	private CqlValueSet Palliative_Care_Intervention_Value(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224")]
	public CqlValueSet Palliative_Care_Intervention() => 
		__Palliative_Care_Intervention?.Value;

	private CqlCode Encounter_for_palliative_care_Value(CqlContext context) => 
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

    [CqlDeclaration("Encounter for palliative care")]
	public CqlCode Encounter_for_palliative_care() => 
		__Encounter_for_palliative_care?.Value;

	private CqlCode[] ICD_10_Value(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD-10")]
	public CqlCode[] ICD_10() => 
		__ICD_10?.Value;

    [CqlDeclaration("Palliative Care Overlapping Period")]
	public bool? Palliative_Care_Overlapping_Period(CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Palliative_Care_Assessment();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation PalliativeAssessment)
		{
			var ab_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PalliativeAssessment?.Effective);
			var ac_ = context.Operators.Start(ab_);
			var ad_ = context.Operators.DateFrom(ac_);
			var af_ = context.Operators.End(ab_);
			var ag_ = context.Operators.DateFrom(af_);
			var ah_ = context.Operators.Interval(ad_, ag_, true, true);
			var ai_ = context.Operators.Start(Period);
			var aj_ = context.Operators.DateFrom(ai_);
			var ak_ = context.Operators.End(Period);
			var al_ = context.Operators.DateFrom(ak_);
			var am_ = context.Operators.Interval(aj_, al_, true, true);
			var an_ = context.Operators.Overlaps(ah_, am_, null);

			return an_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);
		var f_ = this.Palliative_Care_Encounter();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = NCQAStatus_1_0_0.Finished_Encounter(g_);
		bool? i_(Encounter PalliativeEncounter)
		{
			var ao_ = NCQAFHIRBase_1_0_0.Normalize_Interval((PalliativeEncounter?.Period as object));
			var ap_ = context.Operators.Start(ao_);
			var aq_ = context.Operators.DateFrom(ap_);
			var as_ = context.Operators.End(ao_);
			var at_ = context.Operators.DateFrom(as_);
			var au_ = context.Operators.Interval(aq_, at_, true, true);
			var av_ = context.Operators.Start(Period);
			var aw_ = context.Operators.DateFrom(av_);
			var ax_ = context.Operators.End(Period);
			var ay_ = context.Operators.DateFrom(ax_);
			var az_ = context.Operators.Interval(aw_, ay_, true, true);
			var ba_ = context.Operators.Overlaps(au_, az_, null);

			return ba_;
		};
		var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
		var k_ = context.Operators.ExistsInList<Encounter>(j_);
		var l_ = context.Operators.Or(e_, k_);
		var m_ = this.Palliative_Care_Intervention();
		var n_ = context.Operators.RetrieveByValueSet<Procedure>(m_, null);
		var o_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(n_);
		bool? p_(Procedure PalliativeIntervention)
		{
			var bb_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PalliativeIntervention?.Performed);
			var bc_ = context.Operators.Start(bb_);
			var bd_ = context.Operators.DateFrom(bc_);
			var bf_ = context.Operators.End(bb_);
			var bg_ = context.Operators.DateFrom(bf_);
			var bh_ = context.Operators.Interval(bd_, bg_, true, true);
			var bi_ = context.Operators.Start(Period);
			var bj_ = context.Operators.DateFrom(bi_);
			var bk_ = context.Operators.End(Period);
			var bl_ = context.Operators.DateFrom(bk_);
			var bm_ = context.Operators.Interval(bj_, bl_, true, true);
			var bn_ = context.Operators.Overlaps(bh_, bm_, null);

			return bn_;
		};
		var q_ = context.Operators.WhereOrNull<Procedure>(o_, p_);
		var r_ = context.Operators.ExistsInList<Procedure>(q_);
		var s_ = context.Operators.Or(l_, r_);
		var t_ = this.Encounter_for_palliative_care();
		var u_ = context.Operators.ToList<CqlCode>(t_);
		var v_ = context.Operators.RetrieveByCodes<Condition>(u_, null);
		var w_ = NCQAStatus_1_0_0.Active_Condition(v_);
		bool? x_(Condition PalliativeDiagnosis)
		{
			var bo_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var bp_ = context.Operators.Start(bo_);
			var bq_ = context.Operators.DateFrom(bp_);
			var bs_ = context.Operators.End(bo_);
			var bt_ = context.Operators.DateFrom(bs_);
			var bu_ = context.Operators.Interval(bq_, bt_, true, true);
			var bv_ = context.Operators.Start(Period);
			var bw_ = context.Operators.DateFrom(bv_);
			var bx_ = context.Operators.End(Period);
			var by_ = context.Operators.DateFrom(bx_);
			var bz_ = context.Operators.Interval(bw_, by_, true, true);
			var ca_ = context.Operators.Overlaps(bu_, bz_, null);

			return ca_;
		};
		var y_ = context.Operators.WhereOrNull<Condition>(w_, x_);
		var z_ = context.Operators.ExistsInList<Condition>(y_);
		var aa_ = context.Operators.Or(s_, z_);

		return aa_;
	}

}