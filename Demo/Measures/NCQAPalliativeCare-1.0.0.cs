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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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

    private CqlValueSet Palliative_Care_Assessment_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", 
			null);
    }

    [CqlDeclaration("Palliative Care Assessment")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225")]
    public CqlValueSet Palliative_Care_Assessment() => __Palliative_Care_Assessment.Value;

    private CqlValueSet Palliative_Care_Encounter_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", 
			null);
    }

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450")]
    public CqlValueSet Palliative_Care_Encounter() => __Palliative_Care_Encounter.Value;

    private CqlValueSet Palliative_Care_Intervention_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", 
			null);
    }

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224")]
    public CqlValueSet Palliative_Care_Intervention() => __Palliative_Care_Intervention.Value;

    private CqlCode Encounter_for_palliative_care_Value()
    {
        return new CqlCode("Z51.5", 
			"http://hl7.org/fhir/sid/icd-10-cm", 
			null, 
			null);
    }

    [CqlDeclaration("Encounter for palliative care")]
    public CqlCode Encounter_for_palliative_care() => __Encounter_for_palliative_care.Value;

    private CqlCode[] ICD_10_Value()
    {
        var a_ = new CqlCode("Z51.5", 
			"http://hl7.org/fhir/sid/icd-10-cm", 
			null, 
			null);
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
        var a_ = this.Palliative_Care_Assessment();
        var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, 
			null);
        Func<Observation,bool?> q_ = (PalliativeAssessment) => 
        {
            var c_ = (PalliativeAssessment?.Effective as object);
            var d_ = NCQAFHIRBase_1_0_0.Normalize_Interval(c_);
            var e_ = context?.Operators.Start(d_);
            var f_ = context?.Operators.DateFrom(e_);
            var i_ = context?.Operators.End(d_);
            var j_ = context?.Operators.DateFrom(i_);
            var k_ = context?.Operators.Interval(f_, 
				j_, 
				true, 
				true);
            var l_ = context?.Operators.Start(Period);
            var m_ = context?.Operators.DateFrom(l_);
            var n_ = context?.Operators.End(Period);
            var o_ = context?.Operators.DateFrom(n_);
            var p_ = context?.Operators.Interval(m_, 
				o_, 
				true, 
				true);
            return context?.Operators.Overlaps(k_, 
				p_, 
				null);
        };
        var r_ = context?.Operators.WhereOrNull<Observation>(b_, 
			q_);
        var s_ = context?.Operators.ExistsInList<Observation>(r_);
        var t_ = this.Palliative_Care_Encounter();
        var u_ = context?.Operators.RetrieveByValueSet<Encounter>(t_, 
			null);
        var v_ = NCQAStatus_1_0_0.Finished_Encounter(u_);
        Func<Encounter,bool?> ak_ = (PalliativeEncounter) => 
        {
            var w_ = (PalliativeEncounter?.Period as object);
            var x_ = NCQAFHIRBase_1_0_0.Normalize_Interval(w_);
            var y_ = context?.Operators.Start(x_);
            var z_ = context?.Operators.DateFrom(y_);
            var ac_ = context?.Operators.End(x_);
            var ad_ = context?.Operators.DateFrom(ac_);
            var ae_ = context?.Operators.Interval(z_, 
				ad_, 
				true, 
				true);
            var af_ = context?.Operators.Start(Period);
            var ag_ = context?.Operators.DateFrom(af_);
            var ah_ = context?.Operators.End(Period);
            var ai_ = context?.Operators.DateFrom(ah_);
            var aj_ = context?.Operators.Interval(ag_, 
				ai_, 
				true, 
				true);
            return context?.Operators.Overlaps(ae_, 
				aj_, 
				null);
        };
        var al_ = context?.Operators.WhereOrNull<Encounter>(v_, 
			ak_);
        var am_ = context?.Operators.ExistsInList<Encounter>(al_);
        var an_ = context?.Operators.Or(s_, 
			am_);
        var ao_ = this.Palliative_Care_Intervention();
        var ap_ = context?.Operators.RetrieveByValueSet<Procedure>(ao_, 
			null);
        var aq_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(ap_);
        Func<Procedure,bool?> bf_ = (PalliativeIntervention) => 
        {
            var ar_ = (PalliativeIntervention?.Performed as object);
            var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
            var at_ = context?.Operators.Start(as_);
            var au_ = context?.Operators.DateFrom(at_);
            var ax_ = context?.Operators.End(as_);
            var ay_ = context?.Operators.DateFrom(ax_);
            var az_ = context?.Operators.Interval(au_, 
				ay_, 
				true, 
				true);
            var ba_ = context?.Operators.Start(Period);
            var bb_ = context?.Operators.DateFrom(ba_);
            var bc_ = context?.Operators.End(Period);
            var bd_ = context?.Operators.DateFrom(bc_);
            var be_ = context?.Operators.Interval(bb_, 
				bd_, 
				true, 
				true);
            return context?.Operators.Overlaps(az_, 
				be_, 
				null);
        };
        var bg_ = context?.Operators.WhereOrNull<Procedure>(aq_, 
			bf_);
        var bh_ = context?.Operators.ExistsInList<Procedure>(bg_);
        var bi_ = context?.Operators.Or(an_, 
			bh_);
        var bj_ = this.Encounter_for_palliative_care();
        var bk_ = context?.Operators.ToList<CqlCode>(bj_);
        var bl_ = context?.Operators.RetrieveByCodes<Condition>(bk_, 
			null);
        var bm_ = NCQAStatus_1_0_0.Active_Condition(bl_);
        Func<Condition,bool?> bz_ = (PalliativeDiagnosis) => 
        {
            var bn_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
            var bo_ = context?.Operators.Start(bn_);
            var bp_ = context?.Operators.DateFrom(bo_);
            var br_ = context?.Operators.End(bn_);
            var bs_ = context?.Operators.DateFrom(br_);
            var bt_ = context?.Operators.Interval(bp_, 
				bs_, 
				true, 
				true);
            var bu_ = context?.Operators.Start(Period);
            var bv_ = context?.Operators.DateFrom(bu_);
            var bw_ = context?.Operators.End(Period);
            var bx_ = context?.Operators.DateFrom(bw_);
            var by_ = context?.Operators.Interval(bv_, 
				bx_, 
				true, 
				true);
            return context?.Operators.Overlaps(bt_, 
				by_, 
				null);
        };
        var ca_ = context?.Operators.WhereOrNull<Condition>(bm_, 
			bz_);
        var cb_ = context?.Operators.ExistsInList<Condition>(ca_);
        return context?.Operators.Or(bi_, 
			cb_);
    }

}