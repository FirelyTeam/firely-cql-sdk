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
		var a_ = context.Operators;
		var f_ = context.DataRetriever;
		var g_ = this.Palliative_Care_Assessment();
		var h_ = f_.RetrieveByValueSet<Observation>(g_, null);
		bool? i_(Observation PalliativeAssessment)
		{
			var ar_ = context.Operators;
			var av_ = PalliativeAssessment?.Effective;
			var aw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(av_);
			var ax_ = ar_.Start(aw_);
			var ay_ = ar_.DateFrom(ax_);
			var bc_ = NCQAFHIRBase_1_0_0.Normalize_Interval(av_);
			var bd_ = ar_.End(bc_);
			var be_ = ar_.DateFrom(bd_);
			var bf_ = ar_.Interval(ay_, be_, true, true);
			var bj_ = ar_.Start(Period);
			var bk_ = ar_.DateFrom(bj_);
			var bn_ = ar_.End(Period);
			var bo_ = ar_.DateFrom(bn_);
			var bp_ = ar_.Interval(bk_, bo_, true, true);
			var bq_ = ar_.Overlaps(bf_, bp_, null);

			return bq_;
		};
		var j_ = a_.WhereOrNull<Observation>(h_, i_);
		var k_ = a_.ExistsInList<Observation>(j_);
		var o_ = this.Palliative_Care_Encounter();
		var p_ = f_.RetrieveByValueSet<Encounter>(o_, null);
		var q_ = NCQAStatus_1_0_0.Finished_Encounter(p_);
		bool? r_(Encounter PalliativeEncounter)
		{
			var br_ = context.Operators;
			var bv_ = PalliativeEncounter?.Period;
			var bw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bv_);
			var bx_ = br_.Start(bw_);
			var by_ = br_.DateFrom(bx_);
			var cc_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bv_);
			var cd_ = br_.End(cc_);
			var ce_ = br_.DateFrom(cd_);
			var cf_ = br_.Interval(by_, ce_, true, true);
			var cj_ = br_.Start(Period);
			var ck_ = br_.DateFrom(cj_);
			var cn_ = br_.End(Period);
			var co_ = br_.DateFrom(cn_);
			var cp_ = br_.Interval(ck_, co_, true, true);
			var cq_ = br_.Overlaps(cf_, cp_, null);

			return cq_;
		};
		var s_ = a_.WhereOrNull<Encounter>(q_, r_);
		var t_ = a_.ExistsInList<Encounter>(s_);
		var u_ = a_.Or(k_, t_);
		var y_ = this.Palliative_Care_Intervention();
		var z_ = f_.RetrieveByValueSet<Procedure>(y_, null);
		var aa_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(z_);
		bool? ab_(Procedure PalliativeIntervention)
		{
			var cr_ = context.Operators;
			var cv_ = PalliativeIntervention?.Performed;
			var cw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cv_);
			var cx_ = cr_.Start(cw_);
			var cy_ = cr_.DateFrom(cx_);
			var dc_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cv_);
			var dd_ = cr_.End(dc_);
			var de_ = cr_.DateFrom(dd_);
			var df_ = cr_.Interval(cy_, de_, true, true);
			var dj_ = cr_.Start(Period);
			var dk_ = cr_.DateFrom(dj_);
			var dn_ = cr_.End(Period);
			var do_ = cr_.DateFrom(dn_);
			var dp_ = cr_.Interval(dk_, do_, true, true);
			var dq_ = cr_.Overlaps(df_, dp_, null);

			return dq_;
		};
		var ac_ = a_.WhereOrNull<Procedure>(aa_, ab_);
		var ad_ = a_.ExistsInList<Procedure>(ac_);
		var ae_ = a_.Or(u_, ad_);
		var aj_ = this.Encounter_for_palliative_care();
		var ak_ = a_.ToList<CqlCode>(aj_);
		var al_ = f_.RetrieveByCodes<Condition>(ak_, null);
		var am_ = NCQAStatus_1_0_0.Active_Condition(al_);
		bool? an_(Condition PalliativeDiagnosis)
		{
			var dr_ = context.Operators;
			var dv_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var dw_ = dr_.Start(dv_);
			var dx_ = dr_.DateFrom(dw_);
			var eb_ = dr_.End(dv_);
			var ec_ = dr_.DateFrom(eb_);
			var ed_ = dr_.Interval(dx_, ec_, true, true);
			var eh_ = dr_.Start(Period);
			var ei_ = dr_.DateFrom(eh_);
			var el_ = dr_.End(Period);
			var em_ = dr_.DateFrom(el_);
			var en_ = dr_.Interval(ei_, em_, true, true);
			var eo_ = dr_.Overlaps(ed_, en_, null);

			return eo_;
		};
		var ao_ = a_.WhereOrNull<Condition>(am_, an_);
		var ap_ = a_.ExistsInList<Condition>(ao_);
		var aq_ = a_.Or(ae_, ap_);

		return aq_;
	}

}