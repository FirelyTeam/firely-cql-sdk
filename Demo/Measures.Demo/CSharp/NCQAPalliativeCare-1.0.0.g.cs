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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", default);

    [CqlDeclaration("Palliative Care Assessment")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225")]
	public CqlValueSet Palliative_Care_Assessment() => 
		__Palliative_Care_Assessment.Value;

	private CqlValueSet Palliative_Care_Encounter_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", default);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450")]
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter.Value;

	private CqlValueSet Palliative_Care_Intervention_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", default);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224")]
	public CqlValueSet Palliative_Care_Intervention() => 
		__Palliative_Care_Intervention.Value;

	private CqlCode Encounter_for_palliative_care_Value() => 
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlDeclaration("Encounter for palliative care")]
	public CqlCode Encounter_for_palliative_care() => 
		__Encounter_for_palliative_care.Value;

	private CqlCode[] ICD_10_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD-10")]
	public CqlCode[] ICD_10() => 
		__ICD_10.Value;

    [CqlDeclaration("Palliative Care Overlapping Period")]
	public bool? Palliative_Care_Overlapping_Period(CqlInterval<CqlDateTime> Period)
	{
		CqlValueSet a_ = this.Palliative_Care_Assessment();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation PalliativeAssessment)
		{
			DataType ab_ = PalliativeAssessment?.Effective;
			CqlInterval<CqlDateTime> ac_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ab_);
			CqlDateTime ad_ = context.Operators.Start(ac_);
			CqlDate ae_ = context.Operators.DateFrom(ad_);
			CqlInterval<CqlDateTime> ag_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ab_);
			CqlDateTime ah_ = context.Operators.End(ag_);
			CqlDate ai_ = context.Operators.DateFrom(ah_);
			CqlInterval<CqlDate> aj_ = context.Operators.Interval(ae_, ai_, true, true);
			CqlDateTime ak_ = context.Operators.Start(Period);
			CqlDate al_ = context.Operators.DateFrom(ak_);
			CqlDateTime am_ = context.Operators.End(Period);
			CqlDate an_ = context.Operators.DateFrom(am_);
			CqlInterval<CqlDate> ao_ = context.Operators.Interval(al_, an_, true, true);
			bool? ap_ = context.Operators.Overlaps(aj_, ao_, default);

			return ap_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);
		CqlValueSet f_ = this.Palliative_Care_Encounter();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> h_ = NCQAStatus_1_0_0.Finished_Encounter(g_);
		bool? i_(Encounter PalliativeEncounter)
		{
			Period aq_ = PalliativeEncounter?.Period;
			CqlInterval<CqlDateTime> ar_ = NCQAFHIRBase_1_0_0.Normalize_Interval(aq_ as object);
			CqlDateTime as_ = context.Operators.Start(ar_);
			CqlDate at_ = context.Operators.DateFrom(as_);
			CqlInterval<CqlDateTime> av_ = NCQAFHIRBase_1_0_0.Normalize_Interval(aq_ as object);
			CqlDateTime aw_ = context.Operators.End(av_);
			CqlDate ax_ = context.Operators.DateFrom(aw_);
			CqlInterval<CqlDate> ay_ = context.Operators.Interval(at_, ax_, true, true);
			CqlDateTime az_ = context.Operators.Start(Period);
			CqlDate ba_ = context.Operators.DateFrom(az_);
			CqlDateTime bb_ = context.Operators.End(Period);
			CqlDate bc_ = context.Operators.DateFrom(bb_);
			CqlInterval<CqlDate> bd_ = context.Operators.Interval(ba_, bc_, true, true);
			bool? be_ = context.Operators.Overlaps(ay_, bd_, default);

			return be_;
		};
		IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
		bool? k_ = context.Operators.Exists<Encounter>(j_);
		bool? l_ = context.Operators.Or(e_, k_);
		CqlValueSet m_ = this.Palliative_Care_Intervention();
		IEnumerable<Procedure> n_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		IEnumerable<Procedure> o_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(n_);
		bool? p_(Procedure PalliativeIntervention)
		{
			DataType bf_ = PalliativeIntervention?.Performed;
			CqlInterval<CqlDateTime> bg_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bf_);
			CqlDateTime bh_ = context.Operators.Start(bg_);
			CqlDate bi_ = context.Operators.DateFrom(bh_);
			CqlInterval<CqlDateTime> bk_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bf_);
			CqlDateTime bl_ = context.Operators.End(bk_);
			CqlDate bm_ = context.Operators.DateFrom(bl_);
			CqlInterval<CqlDate> bn_ = context.Operators.Interval(bi_, bm_, true, true);
			CqlDateTime bo_ = context.Operators.Start(Period);
			CqlDate bp_ = context.Operators.DateFrom(bo_);
			CqlDateTime bq_ = context.Operators.End(Period);
			CqlDate br_ = context.Operators.DateFrom(bq_);
			CqlInterval<CqlDate> bs_ = context.Operators.Interval(bp_, br_, true, true);
			bool? bt_ = context.Operators.Overlaps(bn_, bs_, default);

			return bt_;
		};
		IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
		bool? r_ = context.Operators.Exists<Procedure>(q_);
		bool? s_ = context.Operators.Or(l_, r_);
		CqlCode t_ = this.Encounter_for_palliative_care();
		IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
		IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, u_, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> w_ = NCQAStatus_1_0_0.Active_Condition(v_);
		bool? x_(Condition PalliativeDiagnosis)
		{
			CqlInterval<CqlDateTime> bu_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			CqlDateTime bv_ = context.Operators.Start(bu_);
			CqlDate bw_ = context.Operators.DateFrom(bv_);
			CqlDateTime by_ = context.Operators.End(bu_);
			CqlDate bz_ = context.Operators.DateFrom(by_);
			CqlInterval<CqlDate> ca_ = context.Operators.Interval(bw_, bz_, true, true);
			CqlDateTime cb_ = context.Operators.Start(Period);
			CqlDate cc_ = context.Operators.DateFrom(cb_);
			CqlDateTime cd_ = context.Operators.End(Period);
			CqlDate ce_ = context.Operators.DateFrom(cd_);
			CqlInterval<CqlDate> cf_ = context.Operators.Interval(cc_, ce_, true, true);
			bool? cg_ = context.Operators.Overlaps(ca_, cf_, default);

			return cg_;
		};
		IEnumerable<Condition> y_ = context.Operators.Where<Condition>(w_, x_);
		bool? z_ = context.Operators.Exists<Condition>(y_);
		bool? aa_ = context.Operators.Or(s_, z_);

		return aa_;
	}

}
