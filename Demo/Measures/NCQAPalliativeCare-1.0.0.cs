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
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> r_ = (PalliativeAssessment) => 
        {
            var d_ = (PalliativeAssessment?.Effective as object);
            var e_ = NCQAFHIRBase_1_0_0.Normalize_Interval(d_);
            var f_ = context?.Operators.Start(e_);
            var g_ = context?.Operators.DateFrom(f_);
            var j_ = context?.Operators.End(e_);
            var k_ = context?.Operators.DateFrom(j_);
            var l_ = context?.Operators.Interval(g_, 
				k_, 
				true, 
				true);
            var m_ = context?.Operators.Start(Period);
            var n_ = context?.Operators.DateFrom(m_);
            var o_ = context?.Operators.End(Period);
            var p_ = context?.Operators.DateFrom(o_);
            var q_ = context?.Operators.Interval(n_, 
				p_, 
				true, 
				true);
            return context?.Operators.Overlaps(l_, 
				q_, 
				null);
        };
        var s_ = context?.Operators.WhereOrNull<Observation>(c_, 
			r_);
        var t_ = context?.Operators.ExistsInList<Observation>(s_);
        var u_ = this.Palliative_Care_Encounter();
        var v_ = typeof(Encounter).GetProperty("Type");
        var w_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(u_, 
			v_);
        var x_ = NCQAStatus_1_0_0.Finished_Encounter(w_);
        Func<Encounter,bool?> am_ = (PalliativeEncounter) => 
        {
            var y_ = (PalliativeEncounter?.Period as object);
            var z_ = NCQAFHIRBase_1_0_0.Normalize_Interval(y_);
            var aa_ = context?.Operators.Start(z_);
            var ab_ = context?.Operators.DateFrom(aa_);
            var ae_ = context?.Operators.End(z_);
            var af_ = context?.Operators.DateFrom(ae_);
            var ag_ = context?.Operators.Interval(ab_, 
				af_, 
				true, 
				true);
            var ah_ = context?.Operators.Start(Period);
            var ai_ = context?.Operators.DateFrom(ah_);
            var aj_ = context?.Operators.End(Period);
            var ak_ = context?.Operators.DateFrom(aj_);
            var al_ = context?.Operators.Interval(ai_, 
				ak_, 
				true, 
				true);
            return context?.Operators.Overlaps(ag_, 
				al_, 
				null);
        };
        var an_ = context?.Operators.WhereOrNull<Encounter>(x_, 
			am_);
        var ao_ = context?.Operators.ExistsInList<Encounter>(an_);
        var ap_ = context?.Operators.Or(t_, 
			ao_);
        var aq_ = this.Palliative_Care_Intervention();
        var ar_ = typeof(Procedure).GetProperty("Code");
        var as_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(aq_, 
			ar_);
        var at_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(as_);
        Func<Procedure,bool?> bi_ = (PalliativeIntervention) => 
        {
            var au_ = (PalliativeIntervention?.Performed as object);
            var av_ = NCQAFHIRBase_1_0_0.Normalize_Interval(au_);
            var aw_ = context?.Operators.Start(av_);
            var ax_ = context?.Operators.DateFrom(aw_);
            var ba_ = context?.Operators.End(av_);
            var bb_ = context?.Operators.DateFrom(ba_);
            var bc_ = context?.Operators.Interval(ax_, 
				bb_, 
				true, 
				true);
            var bd_ = context?.Operators.Start(Period);
            var be_ = context?.Operators.DateFrom(bd_);
            var bf_ = context?.Operators.End(Period);
            var bg_ = context?.Operators.DateFrom(bf_);
            var bh_ = context?.Operators.Interval(be_, 
				bg_, 
				true, 
				true);
            return context?.Operators.Overlaps(bc_, 
				bh_, 
				null);
        };
        var bj_ = context?.Operators.WhereOrNull<Procedure>(at_, 
			bi_);
        var bk_ = context?.Operators.ExistsInList<Procedure>(bj_);
        var bl_ = context?.Operators.Or(ap_, 
			bk_);
        var bm_ = this.Encounter_for_palliative_care();
        var bn_ = context?.Operators.ToList<CqlCode>(bm_);
        var bo_ = typeof(Condition).GetProperty("Code");
        var bp_ = context?.DataRetriever.RetrieveByCodes<Condition>(bn_, 
			bo_);
        var bq_ = NCQAStatus_1_0_0.Active_Condition(bp_);
        Func<Condition,bool?> cd_ = (PalliativeDiagnosis) => 
        {
            var br_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
            var bs_ = context?.Operators.Start(br_);
            var bt_ = context?.Operators.DateFrom(bs_);
            var bv_ = context?.Operators.End(br_);
            var bw_ = context?.Operators.DateFrom(bv_);
            var bx_ = context?.Operators.Interval(bt_, 
				bw_, 
				true, 
				true);
            var by_ = context?.Operators.Start(Period);
            var bz_ = context?.Operators.DateFrom(by_);
            var ca_ = context?.Operators.End(Period);
            var cb_ = context?.Operators.DateFrom(ca_);
            var cc_ = context?.Operators.Interval(bz_, 
				cb_, 
				true, 
				true);
            return context?.Operators.Overlaps(bx_, 
				cc_, 
				null);
        };
        var ce_ = context?.Operators.WhereOrNull<Condition>(bq_, 
			cd_);
        var cf_ = context?.Operators.ExistsInList<Condition>(ce_);
        return context?.Operators.Or(bl_, 
			cf_);
    }

}