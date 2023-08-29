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

    private CqlCode Encounter_for_palliative_care_Value()
	{
		var a_ = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

		return a_;
	}

    [CqlDeclaration("Encounter for palliative care")]
    public CqlCode Encounter_for_palliative_care() => __Encounter_for_palliative_care.Value;

    private CqlCode[] ICD_10_Value()
	{
		var a_ = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("ICD-10")]
    public CqlCode[] ICD_10() => __ICD_10.Value;

    [CqlDeclaration("Palliative Care Overlapping Period")]
    public bool? Palliative_Care_Overlapping_Period(CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Palliative_Care_Assessment();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation PalliativeAssessment)
		{
			var ar_ = PalliativeAssessment?.Effective;
			var as_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var at_ = context.Operators;
			var au_ = at_.Start(as_);
			var aw_ = at_.DateFrom(au_);
			var ay_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ar_);
			var ba_ = at_.End(ay_);
			var bc_ = at_.DateFrom(ba_);
			var be_ = at_.Interval(aw_, bc_, true, true);
			var bg_ = at_.Start(Period);
			var bi_ = at_.DateFrom(bg_);
			var bk_ = at_.End(Period);
			var bm_ = at_.DateFrom(bk_);
			var bo_ = at_.Interval(bi_, bm_, true, true);
			var bq_ = at_.Overlaps(be_, bo_, null);

			return bq_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var h_ = e_.ExistsInList<Observation>(f_);
		var i_ = this.Palliative_Care_Encounter();
		var k_ = b_.RetrieveByValueSet<Encounter>(i_, null);
		var l_ = NCQAStatus_1_0_0.Finished_Encounter(k_);
		bool? m_(Encounter PalliativeEncounter)
		{
			var br_ = PalliativeEncounter?.Period;
			var bs_ = NCQAFHIRBase_1_0_0.Normalize_Interval(br_);
			var bt_ = context.Operators;
			var bu_ = bt_.Start(bs_);
			var bw_ = bt_.DateFrom(bu_);
			var by_ = NCQAFHIRBase_1_0_0.Normalize_Interval(br_);
			var ca_ = bt_.End(by_);
			var cc_ = bt_.DateFrom(ca_);
			var ce_ = bt_.Interval(bw_, cc_, true, true);
			var cg_ = bt_.Start(Period);
			var ci_ = bt_.DateFrom(cg_);
			var ck_ = bt_.End(Period);
			var cm_ = bt_.DateFrom(ck_);
			var co_ = bt_.Interval(ci_, cm_, true, true);
			var cq_ = bt_.Overlaps(ce_, co_, null);

			return cq_;
		};
		var o_ = e_.WhereOrNull<Encounter>(l_, m_);
		var q_ = e_.ExistsInList<Encounter>(o_);
		var s_ = e_.Or(h_, q_);
		var t_ = this.Palliative_Care_Intervention();
		var v_ = b_.RetrieveByValueSet<Procedure>(t_, null);
		var w_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(v_);
		bool? x_(Procedure PalliativeIntervention)
		{
			var cr_ = PalliativeIntervention?.Performed;
			var cs_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cr_);
			var ct_ = context.Operators;
			var cu_ = ct_.Start(cs_);
			var cw_ = ct_.DateFrom(cu_);
			var cy_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cr_);
			var da_ = ct_.End(cy_);
			var dc_ = ct_.DateFrom(da_);
			var de_ = ct_.Interval(cw_, dc_, true, true);
			var dg_ = ct_.Start(Period);
			var di_ = ct_.DateFrom(dg_);
			var dk_ = ct_.End(Period);
			var dm_ = ct_.DateFrom(dk_);
			var do_ = ct_.Interval(di_, dm_, true, true);
			var dq_ = ct_.Overlaps(de_, do_, null);

			return dq_;
		};
		var z_ = e_.WhereOrNull<Procedure>(w_, x_);
		var ab_ = e_.ExistsInList<Procedure>(z_);
		var ad_ = e_.Or(s_, ab_);
		var ae_ = this.Encounter_for_palliative_care();
		var ag_ = e_.ToList<CqlCode>(ae_);
		var ai_ = b_.RetrieveByCodes<Condition>(ag_, null);
		var aj_ = NCQAStatus_1_0_0.Active_Condition(ai_);
		bool? ak_(Condition PalliativeDiagnosis)
		{
			var dr_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var ds_ = context.Operators;
			var dt_ = ds_.Start(dr_);
			var dv_ = ds_.DateFrom(dt_);
			var dy_ = ds_.End(dr_);
			var ea_ = ds_.DateFrom(dy_);
			var ec_ = ds_.Interval(dv_, ea_, true, true);
			var ee_ = ds_.Start(Period);
			var eg_ = ds_.DateFrom(ee_);
			var ei_ = ds_.End(Period);
			var ek_ = ds_.DateFrom(ei_);
			var em_ = ds_.Interval(eg_, ek_, true, true);
			var eo_ = ds_.Overlaps(ec_, em_, null);

			return eo_;
		};
		var am_ = e_.WhereOrNull<Condition>(aj_, ak_);
		var ao_ = e_.ExistsInList<Condition>(am_);
		var aq_ = e_.Or(ad_, ao_);

		return aq_;
	}


}