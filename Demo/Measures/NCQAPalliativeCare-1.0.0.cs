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
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", 
			null);

    [CqlDeclaration("Palliative Care Assessment")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225")]
    public CqlValueSet Palliative_Care_Assessment() => __Palliative_Care_Assessment.Value;

    private CqlValueSet Palliative_Care_Encounter_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", 
			null);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450")]
    public CqlValueSet Palliative_Care_Encounter() => __Palliative_Care_Encounter.Value;

    private CqlValueSet Palliative_Care_Intervention_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", 
			null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224")]
    public CqlValueSet Palliative_Care_Intervention() => __Palliative_Care_Intervention.Value;

    private CqlCode Encounter_for_palliative_care_Value() =>
		new CqlCode("Z51.5", 
			"http://hl7.org/fhir/sid/icd-10-cm", 
			null, 
			null);

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
		var b_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, null);
		var c_ = (Observation PalliativeAssessment) =>
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
		var d_ = context?.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context?.Operators.ExistsInList<Observation>(d_);
		var f_ = this.Palliative_Care_Encounter();
		var g_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = NCQAStatus_1_0_0.Finished_Encounter(g_);
		var i_ = (Encounter PalliativeEncounter) =>
		{
			var a_ = (PalliativeEncounter?.Period as object);
			var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
			var c_ = context?.Operators.Start(b_);
			var d_ = context?.Operators.DateFrom(c_);
			var e_ = (PalliativeEncounter?.Period as object);
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
		var j_ = context?.Operators.WhereOrNull<Encounter>(h_, i_);
		var k_ = context?.Operators.ExistsInList<Encounter>(j_);
		var l_ = context?.Operators.Or(e_, k_);
		var m_ = this.Palliative_Care_Intervention();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(m_, null);
		var o_ = NCQAStatus_1_0_0.Completed_or_Ongoing_Procedure(n_);
		var p_ = (Procedure PalliativeIntervention) =>
		{
			var a_ = (PalliativeIntervention?.Performed as object);
			var b_ = NCQAFHIRBase_1_0_0.Normalize_Interval(a_);
			var c_ = context?.Operators.Start(b_);
			var d_ = context?.Operators.DateFrom(c_);
			var e_ = (PalliativeIntervention?.Performed as object);
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
		var q_ = context?.Operators.WhereOrNull<Procedure>(o_, p_);
		var r_ = context?.Operators.ExistsInList<Procedure>(q_);
		var s_ = context?.Operators.Or(l_, r_);
		var t_ = this.Encounter_for_palliative_care();
		var u_ = context?.Operators.ToList<CqlCode>(t_);
		var v_ = context?.DataRetriever.RetrieveByCodes<Condition>(u_, null);
		var w_ = NCQAStatus_1_0_0.Active_Condition(v_);
		var x_ = (Condition PalliativeDiagnosis) =>
		{
			var a_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var b_ = context?.Operators.Start(a_);
			var c_ = context?.Operators.DateFrom(b_);
			var d_ = NCQAFHIRBase_1_0_0.Prevalence_Period(PalliativeDiagnosis);
			var e_ = context?.Operators.End(d_);
			var f_ = context?.Operators.DateFrom(e_);
			var g_ = context?.Operators.Interval(c_, f_, true, true);
			var h_ = context?.Operators.Start(Period);
			var i_ = context?.Operators.DateFrom(h_);
			var j_ = context?.Operators.End(Period);
			var k_ = context?.Operators.DateFrom(j_);
			var l_ = context?.Operators.Interval(i_, k_, true, true);

			return context?.Operators.Overlaps(g_, l_, null);
		};
		var y_ = context?.Operators.WhereOrNull<Condition>(w_, x_);
		var z_ = context?.Operators.ExistsInList<Condition>(y_);

		return context?.Operators.Or(s_, z_);
	}


}