using System;
using Tuples;
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlValueSet a_ = this.Palliative_Care_Assessment();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation PalliativeAssessment)
		{
			CqlInterval<CqlDateTime> ab_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PalliativeAssessment?.Effective);
			CqlDateTime ac_ = context.Operators.Start(ab_);
			CqlDate ad_ = context.Operators.DateFrom(ac_);
			CqlDateTime af_ = context.Operators.End(ab_);
			CqlDate ag_ = context.Operators.DateFrom(af_);
			CqlInterval<CqlDate> ah_ = context.Operators.Interval(ad_, ag_, true, true);
			CqlDateTime ai_ = context.Operators.Start(Period);
			CqlDate aj_ = context.Operators.DateFrom(ai_);
			CqlDateTime ak_ = context.Operators.End(Period);
			CqlDate al_ = context.Operators.DateFrom(ak_);
			CqlInterval<CqlDate> am_ = context.Operators.Interval(aj_, al_, true, true);
			bool? an_ = context.Operators.Overlaps(ah_, am_, null);

			return an_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);
		CqlValueSet f_ = this.Palliative_Care_Encounter();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		IEnumerable<Encounter> h_ = NCQAStatus_1_0_0.Finished_Encounter(g_);
		bool? i_(Encounter PalliativeEncounter)
		{
			CqlInterval<CqlDateTime> ao_ = NCQAFHIRBase_1_0_0.Normalize_Interval((PalliativeEncounter?.Period as object));
			CqlDateTime ap_ = context.Operators.Start(ao_);
			CqlDate aq_ = context.Operators.DateFrom(ap_);
			CqlDateTime as_ = context.Operators.End(ao_);
			CqlDate at_ = context.Operators.DateFrom(as_);
			CqlInterval<CqlDate> au_ = context.Operators.Interval(aq_, at_, true, true);
			CqlDateTime av_ = context.Operators.Start(Period);
			CqlDate aw_ = context.Operators.DateFrom(av_);
			CqlDateTime ax_ = context.Operators.End(Period);
			CqlDate ay_ = context.Operators.DateFrom(ax_);
			CqlInterval<CqlDate> az_ = context.Operators.Interval(aw_, ay_, true, true);
			bool? ba_ = context.Operators.Overlaps(au_, az_, null);

			return ba_;
		};
		IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);
		bool? l_ = context.Operators.Or(e_, k_);
		CqlValueSet m_ = this.Palliative_Care_Intervention();
		IEnumerable<Procedure> n_ = context.Operators.RetrieveByValueSet<Procedure>(m_, null);
		IEnumerable<Procedure> o_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(n_);
		bool? p_(Procedure PalliativeIntervention)
		{
			CqlInterval<CqlDateTime> bb_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PalliativeIntervention?.Performed);
			CqlDateTime bc_ = context.Operators.Start(bb_);
			CqlDate bd_ = context.Operators.DateFrom(bc_);
			CqlDateTime bf_ = context.Operators.End(bb_);
			CqlDate bg_ = context.Operators.DateFrom(bf_);
			CqlInterval<CqlDate> bh_ = context.Operators.Interval(bd_, bg_, true, true);
			CqlDateTime bi_ = context.Operators.Start(Period);
			CqlDate bj_ = context.Operators.DateFrom(bi_);
			CqlDateTime bk_ = context.Operators.End(Period);
			CqlDate bl_ = context.Operators.DateFrom(bk_);
			CqlInterval<CqlDate> bm_ = context.Operators.Interval(bj_, bl_, true, true);
			bool? bn_ = context.Operators.Overlaps(bh_, bm_, null);

			return bn_;
		};
		IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
		bool? r_ = context.Operators.Exists<Procedure>(q_);
		bool? s_ = context.Operators.Or(l_, r_);
		CqlCode t_ = this.Encounter_for_palliative_care();
		IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
		IEnumerable<Condition> v_ = context.Operators.RetrieveByCodes<Condition>(u_, null);
		IEnumerable<Condition> w_ = NCQAStatus_1_0_0.Active_Condition(v_);
		bool? x_(Condition PalliativeDiagnosis)
		{
			CqlInterval<CqlDateTime> bo_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			CqlDateTime bp_ = context.Operators.Start(bo_);
			CqlDate bq_ = context.Operators.DateFrom(bp_);
			CqlDateTime bs_ = context.Operators.End(bo_);
			CqlDate bt_ = context.Operators.DateFrom(bs_);
			CqlInterval<CqlDate> bu_ = context.Operators.Interval(bq_, bt_, true, true);
			CqlDateTime bv_ = context.Operators.Start(Period);
			CqlDate bw_ = context.Operators.DateFrom(bv_);
			CqlDateTime bx_ = context.Operators.End(Period);
			CqlDate by_ = context.Operators.DateFrom(bx_);
			CqlInterval<CqlDate> bz_ = context.Operators.Interval(bw_, by_, true, true);
			bool? ca_ = context.Operators.Overlaps(bu_, bz_, null);

			return ca_;
		};
		IEnumerable<Condition> y_ = context.Operators.Where<Condition>(w_, x_);
		bool? z_ = context.Operators.Exists<Condition>(y_);
		bool? aa_ = context.Operators.Or(s_, z_);

		return aa_;
	}

}
