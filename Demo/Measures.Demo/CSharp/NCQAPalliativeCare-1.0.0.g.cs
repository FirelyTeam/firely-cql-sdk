using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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

        __Palliative_Care_Assessment = new Lazy<CqlValueSet>(this.Palliative_Care_Assessment_Value);
        __Palliative_Care_Encounter = new Lazy<CqlValueSet>(this.Palliative_Care_Encounter_Value);
        __Palliative_Care_Intervention = new Lazy<CqlValueSet>(this.Palliative_Care_Intervention_Value);
        __Encounter_for_palliative_care = new Lazy<CqlCode>(this.Encounter_for_palliative_care_Value);
        __ICD_10 = new Lazy<CqlCode[]>(this.ICD_10_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }
    public NCQAStatus_1_0_0 NCQAStatus_1_0_0 { get; }

    #endregion

	private CqlValueSet Palliative_Care_Assessment_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", null);

    [CqlDeclaration("Palliative Care Assessment")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225")]
	public CqlValueSet Palliative_Care_Assessment() => 
		__Palliative_Care_Assessment.Value;

	private CqlValueSet Palliative_Care_Encounter_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", null);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450")]
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter.Value;

	private CqlValueSet Palliative_Care_Intervention_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224")]
	public CqlValueSet Palliative_Care_Intervention() => 
		__Palliative_Care_Intervention.Value;

	private CqlCode Encounter_for_palliative_care_Value() => 
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

    [CqlDeclaration("Encounter for palliative care")]
	public CqlCode Encounter_for_palliative_care() => 
		__Encounter_for_palliative_care.Value;

	private CqlCode[] ICD_10_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD-10")]
	public CqlCode[] ICD_10() => 
		__ICD_10.Value;

    [CqlDeclaration("Palliative Care Overlapping Period")]
	public bool? Palliative_Care_Overlapping_Period(CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Palliative_Care_Assessment();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation PalliativeAssessment)
		{
			var ab_ = PalliativeAssessment.Effective;
			var ac_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ab_);
			var ad_ = context.Operators.Start(ac_);
			var ae_ = context.Operators.DateFrom(ad_);
			var ag_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ab_);
			var ah_ = context.Operators.End(ag_);
			var ai_ = context.Operators.DateFrom(ah_);
			var aj_ = context.Operators.Interval(ae_, ai_, true, true);
			var ak_ = context.Operators.Start(Period);
			var al_ = context.Operators.DateFrom(ak_);
			var am_ = context.Operators.End(Period);
			var an_ = context.Operators.DateFrom(am_);
			var ao_ = context.Operators.Interval(al_, an_, true, true);
			var ap_ = context.Operators.Overlaps(aj_, ao_, null);

			return ap_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);
		var e_ = context.Operators.Exists<Observation>(d_);
		var f_ = this.Palliative_Care_Encounter();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = NCQAStatus_1_0_0.Finished_Encounter(g_);
		bool? i_(Encounter PalliativeEncounter)
		{
			var aq_ = PalliativeEncounter.Period;
			var ar_ = NCQAFHIRBase_1_0_0.Normalize_Interval((aq_ as object));
			var as_ = context.Operators.Start(ar_);
			var at_ = context.Operators.DateFrom(as_);
			var av_ = NCQAFHIRBase_1_0_0.Normalize_Interval((aq_ as object));
			var aw_ = context.Operators.End(av_);
			var ax_ = context.Operators.DateFrom(aw_);
			var ay_ = context.Operators.Interval(at_, ax_, true, true);
			var az_ = context.Operators.Start(Period);
			var ba_ = context.Operators.DateFrom(az_);
			var bb_ = context.Operators.End(Period);
			var bc_ = context.Operators.DateFrom(bb_);
			var bd_ = context.Operators.Interval(ba_, bc_, true, true);
			var be_ = context.Operators.Overlaps(ay_, bd_, null);

			return be_;
		};
		var j_ = context.Operators.Where<Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);
		var l_ = context.Operators.Or(e_, k_);
		var m_ = this.Palliative_Care_Intervention();
		var n_ = context.Operators.RetrieveByValueSet<Procedure>(m_, null);
		var o_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(n_);
		bool? p_(Procedure PalliativeIntervention)
		{
			var bf_ = PalliativeIntervention.Performed;
			var bg_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bf_);
			var bh_ = context.Operators.Start(bg_);
			var bi_ = context.Operators.DateFrom(bh_);
			var bk_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bf_);
			var bl_ = context.Operators.End(bk_);
			var bm_ = context.Operators.DateFrom(bl_);
			var bn_ = context.Operators.Interval(bi_, bm_, true, true);
			var bo_ = context.Operators.Start(Period);
			var bp_ = context.Operators.DateFrom(bo_);
			var bq_ = context.Operators.End(Period);
			var br_ = context.Operators.DateFrom(bq_);
			var bs_ = context.Operators.Interval(bp_, br_, true, true);
			var bt_ = context.Operators.Overlaps(bn_, bs_, null);

			return bt_;
		};
		var q_ = context.Operators.Where<Procedure>(o_, p_);
		var r_ = context.Operators.Exists<Procedure>(q_);
		var s_ = context.Operators.Or(l_, r_);
		var t_ = this.Encounter_for_palliative_care();
		var u_ = context.Operators.ToList<CqlCode>(t_);
		var v_ = context.Operators.RetrieveByCodes<Condition>(u_, null);
		var w_ = NCQAStatus_1_0_0.Active_Condition(v_);
		bool? x_(Condition PalliativeDiagnosis)
		{
			var bu_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var bv_ = context.Operators.Start(bu_);
			var bw_ = context.Operators.DateFrom(bv_);
			var by_ = context.Operators.End(bu_);
			var bz_ = context.Operators.DateFrom(by_);
			var ca_ = context.Operators.Interval(bw_, bz_, true, true);
			var cb_ = context.Operators.Start(Period);
			var cc_ = context.Operators.DateFrom(cb_);
			var cd_ = context.Operators.End(Period);
			var ce_ = context.Operators.DateFrom(cd_);
			var cf_ = context.Operators.Interval(cc_, ce_, true, true);
			var cg_ = context.Operators.Overlaps(ca_, cf_, null);

			return cg_;
		};
		var y_ = context.Operators.Where<Condition>(w_, x_);
		var z_ = context.Operators.Exists<Condition>(y_);
		var aa_ = context.Operators.Or(s_, z_);

		return aa_;
	}

}
