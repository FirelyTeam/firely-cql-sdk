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
[CqlLibrary("PalliativeCareFHIR", "0.6.000")]
public class PalliativeCareFHIR_0_6_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Palliative_Care_Encounter;
    internal Lazy<CqlValueSet> __Palliative_Care_Intervention;
    internal Lazy<CqlCode> __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    internal Lazy<CqlCode> __survey;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Palliative_Care_in_the_Measurement_Period;

    #endregion
    public PalliativeCareFHIR_0_6_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Palliative_Care_Encounter = new Lazy<CqlValueSet>(this.Palliative_Care_Encounter_Value);
        __Palliative_Care_Intervention = new Lazy<CqlValueSet>(this.Palliative_Care_Intervention_Value);
        __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new Lazy<CqlCode>(this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value);
        __survey = new Lazy<CqlCode>(this.survey_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Palliative_Care_in_the_Measurement_Period = new Lazy<bool?>(this.Palliative_Care_in_the_Measurement_Period_Value);
    }
    #region Dependencies

    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

    private CqlValueSet Palliative_Care_Encounter_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090")]
    public CqlValueSet Palliative_Care_Encounter() => __Palliative_Care_Encounter.Value;

    private CqlValueSet Palliative_Care_Intervention_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
    public CqlValueSet Palliative_Care_Intervention() => __Palliative_Care_Intervention.Value;

    private CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value() =>
		new CqlCode("71007-9", "http://loinc.org", null, null);

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_() => __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_.Value;

    private CqlCode survey_Value() =>
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("survey")]
    public CqlCode survey() => __survey.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("71007-9", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes() => __ObservationCategoryCodes.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Palliative_Care_in_the_Measurement_Period_Value()
	{
		var av_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
		var aw_ = context?.Operators.ToList<CqlCode>(av_);
		var ax_ = context?.DataRetriever.RetrieveByCodes<Observation>(aw_, null);
		var ay_ = (Observation PalliativeAssessment) =>
		{
			var e_ = PalliativeAssessment?.StatusElement;
			var f_ = (e_ as object);
			var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
			var h_ = "final";
			var i_ = "amended";
			var j_ = "corrected";
			var k_ = new string[]
			{
				h_,
				i_,
				j_,
			};
			var l_ = (k_ as IEnumerable<string>);
			var m_ = context?.Operators.InList<string>(g_, l_);
			var n_ = PalliativeAssessment?.Category;
			var o_ = (n_ as IEnumerable<CodeableConcept>);
			var p_ = (CodeableConcept PalliativeAssessmentCategory) =>
			{
				var a_ = this.survey();
				var b_ = FHIRHelpers_4_0_001.ToConcept(PalliativeAssessmentCategory);
				var c_ = b_?.codes;
				var d_ = (c_ as IEnumerable<CqlCode>);

				return context?.Operators.CodeInList(a_, d_);
			};
			var q_ = context?.Operators.WhereOrNull<CodeableConcept>(o_, p_);
			var r_ = context?.Operators.ExistsInList<CodeableConcept>(q_);
			var s_ = context?.Operators.And(m_, r_);
			var t_ = PalliativeAssessment?.Effective;
			var u_ = (t_ as object);
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
			var w_ = this.Measurement_Period();
			var x_ = context?.Operators.Overlaps(v_, w_, null);

			return context?.Operators.And(s_, x_);
		};
		var az_ = context?.Operators.WhereOrNull<Observation>(ax_, ay_);
		var ba_ = context?.Operators.ExistsInList<Observation>(az_);
		var bb_ = this.Palliative_Care_Encounter();
		var bc_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(bb_, null);
		var bd_ = (Encounter PalliativeEncounter) =>
		{
			var y_ = PalliativeEncounter?.StatusElement;
			var z_ = (y_ as object);
			var aa_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(z_);
			var ab_ = (aa_ as object);
			var ac_ = context?.Operators.Equal(ab_, ("finished" as object));
			var ad_ = PalliativeEncounter?.Period;
			var ae_ = (ad_ as object);
			var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context?.Operators.Overlaps(af_, ag_, null);

			return context?.Operators.And(ac_, ah_);
		};
		var be_ = context?.Operators.WhereOrNull<Encounter>(bc_, bd_);
		var bf_ = context?.Operators.ExistsInList<Encounter>(be_);
		var bg_ = context?.Operators.Or(ba_, bf_);
		var bh_ = this.Palliative_Care_Intervention();
		var bi_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(bh_, null);
		var bj_ = (Procedure PalliativeIntervention) =>
		{
			var ai_ = PalliativeIntervention?.StatusElement;
			var aj_ = (ai_ as object);
			var ak_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(aj_);
			var al_ = "completed";
			var am_ = "in-progress";
			var an_ = new string[]
			{
				al_,
				am_,
			};
			var ao_ = (an_ as IEnumerable<string>);
			var ap_ = context?.Operators.InList<string>(ak_, ao_);
			var aq_ = PalliativeIntervention?.Performed;
			var ar_ = (aq_ as object);
			var as_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ar_);
			var at_ = this.Measurement_Period();
			var au_ = context?.Operators.Overlaps(as_, at_, null);

			return context?.Operators.And(ap_, au_);
		};
		var bk_ = context?.Operators.WhereOrNull<Procedure>(bi_, bj_);
		var bl_ = context?.Operators.ExistsInList<Procedure>(bk_);

		return context?.Operators.Or(bg_, bl_);
	}

    [CqlDeclaration("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period() => __Palliative_Care_in_the_Measurement_Period.Value;

}