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
		var bc_ = this.Palliative_Care_Assessment();
		var bd_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bc_, null);
		var be_ = (Observation PalliativeAssessment) =>
		{
			var a_ = (PalliativeAssessment?.Effective as object);
			var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
			var c_ = context?.Operators.Start(b_);
			var d_ = context?.Operators.DateFrom(c_);
			var e_ = (PalliativeAssessment?.Effective as object);
			var f_ = NCQAFHIRBase_1_0_0.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = context?.Operators.DateFrom(g_);
			var i_ = context?.Operators.Interval(d_, h_, true, true);
			var j_ = context?.Operators.Start(Period);
			var k_ = context?.Operators.DateFrom(j_);
			var l_ = context?.Operators.End(Period);
			var m_ = context?.Operators.DateFrom(l_);
			var n_ = context?.Operators.Interval(k_, m_, true, true);

			return context?.Operators.Overlaps(i_, n_, null);
		};
		var bf_ = context?.Operators.WhereOrNull<Observation>(bd_, be_);
		var bg_ = context?.Operators.ExistsInList<Observation>(bf_);
		var bh_ = this.Palliative_Care_Encounter();
		var bi_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(bh_, null);
		var bj_ = NCQAStatus_1_0_0.Finished_Encounter(bi_);
		var bk_ = (Encounter PalliativeEncounter) =>
		{
			var o_ = (PalliativeEncounter?.Period as object);
			var p_ = NCQAFHIRBase_1_0_0.Normalize_Interval(o_);
			var q_ = context?.Operators.Start(p_);
			var r_ = context?.Operators.DateFrom(q_);
			var s_ = (PalliativeEncounter?.Period as object);
			var t_ = NCQAFHIRBase_1_0_0.Normalize_Interval(s_);
			var u_ = context?.Operators.End(t_);
			var v_ = context?.Operators.DateFrom(u_);
			var w_ = context?.Operators.Interval(r_, v_, true, true);
			var x_ = context?.Operators.Start(Period);
			var y_ = context?.Operators.DateFrom(x_);
			var z_ = context?.Operators.End(Period);
			var aa_ = context?.Operators.DateFrom(z_);
			var ab_ = context?.Operators.Interval(y_, aa_, true, true);

			return context?.Operators.Overlaps(w_, ab_, null);
		};
		var bl_ = context?.Operators.WhereOrNull<Encounter>(bj_, bk_);
		var bm_ = context?.Operators.ExistsInList<Encounter>(bl_);
		var bn_ = context?.Operators.Or(bg_, bm_);
		var bo_ = this.Palliative_Care_Intervention();
		var bp_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(bo_, null);
		var bq_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(bp_);
		var br_ = (Procedure PalliativeIntervention) =>
		{
			var ac_ = (PalliativeIntervention?.Performed as object);
			var ad_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ac_);
			var ae_ = context?.Operators.Start(ad_);
			var af_ = context?.Operators.DateFrom(ae_);
			var ag_ = (PalliativeIntervention?.Performed as object);
			var ah_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ag_);
			var ai_ = context?.Operators.End(ah_);
			var aj_ = context?.Operators.DateFrom(ai_);
			var ak_ = context?.Operators.Interval(af_, aj_, true, true);
			var al_ = context?.Operators.Start(Period);
			var am_ = context?.Operators.DateFrom(al_);
			var an_ = context?.Operators.End(Period);
			var ao_ = context?.Operators.DateFrom(an_);
			var ap_ = context?.Operators.Interval(am_, ao_, true, true);

			return context?.Operators.Overlaps(ak_, ap_, null);
		};
		var bs_ = context?.Operators.WhereOrNull<Procedure>(bq_, br_);
		var bt_ = context?.Operators.ExistsInList<Procedure>(bs_);
		var bu_ = context?.Operators.Or(bn_, bt_);
		var bv_ = this.Encounter_for_palliative_care();
		var bw_ = context?.Operators.ToList<CqlCode>(bv_);
		var bx_ = context?.DataRetriever.RetrieveByCodes<Condition>(bw_, null);
		var by_ = NCQAStatus_1_0_0.Active_Condition(bx_);
		var bz_ = (Condition PalliativeDiagnosis) =>
		{
			var aq_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var ar_ = context?.Operators.Start(aq_);
			var as_ = context?.Operators.DateFrom(ar_);
			var at_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var au_ = context?.Operators.End(at_);
			var av_ = context?.Operators.DateFrom(au_);
			var aw_ = context?.Operators.Interval(as_, av_, true, true);
			var ax_ = context?.Operators.Start(Period);
			var ay_ = context?.Operators.DateFrom(ax_);
			var az_ = context?.Operators.End(Period);
			var ba_ = context?.Operators.DateFrom(az_);
			var bb_ = context?.Operators.Interval(ay_, ba_, true, true);

			return context?.Operators.Overlaps(aw_, bb_, null);
		};
		var ca_ = context?.Operators.WhereOrNull<Condition>(by_, bz_);
		var cb_ = context?.Operators.ExistsInList<Condition>(ca_);

		return context?.Operators.Or(bu_, cb_);
	}


}