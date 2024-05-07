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
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter.Value;

	private CqlValueSet Palliative_Care_Intervention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
	public CqlValueSet Palliative_Care_Intervention() => 
		__Palliative_Care_Intervention.Value;

	private CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value() => 
		new CqlCode("71007-9", "http://loinc.org", null, null);

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
	public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_() => 
		__Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_.Value;

	private CqlCode survey_Value() => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("survey")]
	public CqlCode survey() => 
		__survey.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("71007-9", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Palliative_Care_in_the_Measurement_Period_Value()
	{
		var a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation PalliativeAssessment)
		{
			var s_ = PalliativeAssessment?.StatusElement;
			var t_ = FHIRHelpers_4_0_001.ToString(s_);
			var u_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var v_ = context.Operators.In<string>(t_, (u_ as IEnumerable<string>));
			var w_ = PalliativeAssessment?.Category;
			bool? x_(CodeableConcept PalliativeAssessmentCategory)
			{
				var ag_ = this.survey();
				var ah_ = FHIRHelpers_4_0_001.ToConcept(PalliativeAssessmentCategory);
				var ai_ = ah_?.codes;
				var aj_ = context.Operators.In<CqlCode>(ag_, (IEnumerable<CqlCode>)ai_);

				return aj_;
			};
			var y_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)w_, x_);
			var z_ = context.Operators.Exists<CodeableConcept>(y_);
			var aa_ = context.Operators.And(v_, z_);
			var ab_ = PalliativeAssessment?.Effective;
			var ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ab_);
			var ad_ = this.Measurement_Period();
			var ae_ = context.Operators.Overlaps(ac_, ad_, null);
			var af_ = context.Operators.And(aa_, ae_);

			return af_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		var f_ = context.Operators.Exists<Observation>(e_);
		var g_ = this.Palliative_Care_Encounter();
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, null);
		bool? i_(Encounter PalliativeEncounter)
		{
			var ak_ = PalliativeEncounter?.StatusElement;
			var al_ = FHIRHelpers_4_0_001.ToString(ak_);
			var am_ = context.Operators.Equal(al_, "finished");
			var an_ = PalliativeEncounter?.Period;
			var ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((an_ as object));
			var ap_ = this.Measurement_Period();
			var aq_ = context.Operators.Overlaps(ao_, ap_, null);
			var ar_ = context.Operators.And(am_, aq_);

			return ar_;
		};
		var j_ = context.Operators.Where<Encounter>(h_, i_);
		var k_ = context.Operators.Exists<Encounter>(j_);
		var l_ = context.Operators.Or(f_, k_);
		var m_ = this.Palliative_Care_Intervention();
		var n_ = context.Operators.RetrieveByValueSet<Procedure>(m_, null);
		bool? o_(Procedure PalliativeIntervention)
		{
			var as_ = PalliativeIntervention?.StatusElement;
			var at_ = FHIRHelpers_4_0_001.ToString(as_);
			var au_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var av_ = context.Operators.In<string>(at_, (au_ as IEnumerable<string>));
			var aw_ = PalliativeIntervention?.Performed;
			var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aw_);
			var ay_ = this.Measurement_Period();
			var az_ = context.Operators.Overlaps(ax_, ay_, null);
			var ba_ = context.Operators.And(av_, az_);

			return ba_;
		};
		var p_ = context.Operators.Where<Procedure>(n_, o_);
		var q_ = context.Operators.Exists<Procedure>(p_);
		var r_ = context.Operators.Or(l_, q_);

		return r_;
	}

    [CqlDeclaration("Palliative Care in the Measurement Period")]
	public bool? Palliative_Care_in_the_Measurement_Period() => 
		__Palliative_Care_in_the_Measurement_Period.Value;

}
