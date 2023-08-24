using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
    public CqlValueSet Palliative_Care_Assessment() => __Palliative_Care_Assessment.Value;

    private CqlValueSet Palliative_Care_Encounter_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", null);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450")]
    public CqlValueSet Palliative_Care_Encounter() => __Palliative_Care_Encounter.Value;

    private CqlValueSet Palliative_Care_Intervention_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224")]
    public CqlValueSet Palliative_Care_Intervention() => __Palliative_Care_Intervention.Value;

    private CqlCode Encounter_for_palliative_care_Value() =>
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

    [CqlDeclaration("Encounter for palliative care")]
    public CqlCode Encounter_for_palliative_care() => __Encounter_for_palliative_care.Value;

    private CqlCode[] ICD_10_Value()
	{
		var a_ = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("ICD-10")]
    public CqlCode[] ICD_10() => __ICD_10.Value;

    [CqlDeclaration("Palliative Care Overlapping Period")]
    public bool? Palliative_Care_Overlapping_Period(CqlInterval<CqlDateTime> Period)
	{
		var bi_ = this.Palliative_Care_Assessment();
		var bj_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bi_, null);
		var bk_ = (Observation PalliativeAssessment) =>
		{
			var a_ = PalliativeAssessment?.Effective;
			var b_ = (a_ as object);
			var c_ = NCQAFHIRBase_1_0_0.Normalize_Interval(b_);
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.DateFrom(d_);
			var f_ = PalliativeAssessment?.Effective;
			var g_ = (f_ as object);
			var h_ = NCQAFHIRBase_1_0_0.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.DateFrom(i_);
			var k_ = context?.Operators.Interval(e_, j_, true, true);
			var l_ = context?.Operators.Start(Period);
			var m_ = context?.Operators.DateFrom(l_);
			var n_ = context?.Operators.End(Period);
			var o_ = context?.Operators.DateFrom(n_);
			var p_ = context?.Operators.Interval(m_, o_, true, true);

			return context?.Operators.Overlaps(k_, p_, null);
		};
		var bl_ = context?.Operators.WhereOrNull<Observation>(bj_, bk_);
		var bm_ = context?.Operators.ExistsInList<Observation>(bl_);
		var bn_ = this.Palliative_Care_Encounter();
		var bo_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(bn_, null);
		var bp_ = NCQAStatus_1_0_0.Finished_Encounter(bo_);
		var bq_ = (Encounter PalliativeEncounter) =>
		{
			var q_ = PalliativeEncounter?.Period;
			var r_ = (q_ as object);
			var s_ = NCQAFHIRBase_1_0_0.Normalize_Interval(r_);
			var t_ = context?.Operators.Start(s_);
			var u_ = context?.Operators.DateFrom(t_);
			var v_ = PalliativeEncounter?.Period;
			var w_ = (v_ as object);
			var x_ = NCQAFHIRBase_1_0_0.Normalize_Interval(w_);
			var y_ = context?.Operators.End(x_);
			var z_ = context?.Operators.DateFrom(y_);
			var aa_ = context?.Operators.Interval(u_, z_, true, true);
			var ab_ = context?.Operators.Start(Period);
			var ac_ = context?.Operators.DateFrom(ab_);
			var ad_ = context?.Operators.End(Period);
			var ae_ = context?.Operators.DateFrom(ad_);
			var af_ = context?.Operators.Interval(ac_, ae_, true, true);

			return context?.Operators.Overlaps(aa_, af_, null);
		};
		var br_ = context?.Operators.WhereOrNull<Encounter>(bp_, bq_);
		var bs_ = context?.Operators.ExistsInList<Encounter>(br_);
		var bt_ = context?.Operators.Or(bm_, bs_);
		var bu_ = this.Palliative_Care_Intervention();
		var bv_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(bu_, null);
		var bw_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(bv_);
		var bx_ = (Procedure PalliativeIntervention) =>
		{
			var ag_ = PalliativeIntervention?.Performed;
			var ah_ = (ag_ as object);
			var ai_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ah_);
			var aj_ = context?.Operators.Start(ai_);
			var ak_ = context?.Operators.DateFrom(aj_);
			var al_ = PalliativeIntervention?.Performed;
			var am_ = (al_ as object);
			var an_ = NCQAFHIRBase_1_0_0.Normalize_Interval(am_);
			var ao_ = context?.Operators.End(an_);
			var ap_ = context?.Operators.DateFrom(ao_);
			var aq_ = context?.Operators.Interval(ak_, ap_, true, true);
			var ar_ = context?.Operators.Start(Period);
			var as_ = context?.Operators.DateFrom(ar_);
			var at_ = context?.Operators.End(Period);
			var au_ = context?.Operators.DateFrom(at_);
			var av_ = context?.Operators.Interval(as_, au_, true, true);

			return context?.Operators.Overlaps(aq_, av_, null);
		};
		var by_ = context?.Operators.WhereOrNull<Procedure>(bw_, bx_);
		var bz_ = context?.Operators.ExistsInList<Procedure>(by_);
		var ca_ = context?.Operators.Or(bt_, bz_);
		var cb_ = this.Encounter_for_palliative_care();
		var cc_ = context?.Operators.ToList<CqlCode>(cb_);
		var cd_ = context?.DataRetriever.RetrieveByCodes<Condition>(cc_, null);
		var ce_ = NCQAStatus_1_0_0.Active_Condition(cd_);
		var cf_ = (Condition PalliativeDiagnosis) =>
		{
			var aw_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var ax_ = context?.Operators.Start(aw_);
			var ay_ = context?.Operators.DateFrom(ax_);
			var az_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var ba_ = context?.Operators.End(az_);
			var bb_ = context?.Operators.DateFrom(ba_);
			var bc_ = context?.Operators.Interval(ay_, bb_, true, true);
			var bd_ = context?.Operators.Start(Period);
			var be_ = context?.Operators.DateFrom(bd_);
			var bf_ = context?.Operators.End(Period);
			var bg_ = context?.Operators.DateFrom(bf_);
			var bh_ = context?.Operators.Interval(be_, bg_, true, true);

			return context?.Operators.Overlaps(bc_, bh_, null);
		};
		var cg_ = context?.Operators.WhereOrNull<Condition>(ce_, cf_);
		var ch_ = context?.Operators.ExistsInList<Condition>(cg_);

		return context?.Operators.Or(ca_, ch_);
	}


}