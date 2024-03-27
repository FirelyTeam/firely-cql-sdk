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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("PalliativeCareFHIR", "0.6.000")]
public class PalliativeCareFHIR_0_6_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlCode> __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    internal Lazy<CqlCode> __survey;
    internal Lazy<CqlValueSet> __Palliative_Care_Encounter;
    internal Lazy<CqlValueSet> __Palliative_Care_Intervention;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Palliative_Care_in_the_Measurement_Period;

    #endregion
    public PalliativeCareFHIR_0_6_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new Lazy<CqlCode>(this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value);
        __survey = new Lazy<CqlCode>(this.survey_Value);
        __Palliative_Care_Encounter = new Lazy<CqlValueSet>(this.Palliative_Care_Encounter_Value);
        __Palliative_Care_Intervention = new Lazy<CqlValueSet>(this.Palliative_Care_Intervention_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Palliative_Care_in_the_Measurement_Period = new Lazy<bool?>(this.Palliative_Care_in_the_Measurement_Period_Value);
    }
    #region Dependencies

    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

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
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
			var s_ = FHIRHelpers_4_0_001.ToString(PalliativeAssessment?.StatusElement);
			var t_ = context.Operators.Convert<string>(s_);
			var u_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var v_ = context.Operators.InList<string>(t_, (u_ as IEnumerable<string>));
			bool? w_(CodeableConcept PalliativeAssessmentCategory)
			{
				var ae_ = this.survey();
				var af_ = FHIRHelpers_4_0_001.ToConcept(PalliativeAssessmentCategory);
				var ag_ = context.Operators.CodeInList(ae_, (af_?.codes as IEnumerable<CqlCode>));

				return ag_;
			};
			var x_ = context.Operators.WhereOrNull<CodeableConcept>((PalliativeAssessment?.Category as IEnumerable<CodeableConcept>), w_);
			var y_ = context.Operators.ExistsInList<CodeableConcept>(x_);
			var z_ = context.Operators.And(v_, y_);
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(PalliativeAssessment?.Effective);
			var ab_ = this.Measurement_Period();
			var ac_ = context.Operators.Overlaps(aa_, ab_, null);
			var ad_ = context.Operators.And(z_, ac_);

			return ad_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		var f_ = context.Operators.ExistsInList<Observation>(e_);
		var g_ = this.Palliative_Care_Encounter();
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, null);
		bool? i_(Encounter PalliativeEncounter)
		{
			var ah_ = FHIRHelpers_4_0_001.ToString(PalliativeEncounter?.StatusElement);
			var ai_ = context.Operators.EnumEqualsString(ah_, "finished");
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((PalliativeEncounter?.Period as object));
			var ak_ = this.Measurement_Period();
			var al_ = context.Operators.Overlaps(aj_, ak_, null);
			var am_ = context.Operators.And(ai_, al_);

			return am_;
		};
		var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
		var k_ = context.Operators.ExistsInList<Encounter>(j_);
		var l_ = context.Operators.Or(f_, k_);
		var m_ = this.Palliative_Care_Intervention();
		var n_ = context.Operators.RetrieveByValueSet<Procedure>(m_, null);
		bool? o_(Procedure PalliativeIntervention)
		{
			var an_ = FHIRHelpers_4_0_001.ToString(PalliativeIntervention?.StatusElement);
			var ao_ = context.Operators.Convert<string>(an_);
			var ap_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var aq_ = context.Operators.InList<string>(ao_, (ap_ as IEnumerable<string>));
			var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(PalliativeIntervention?.Performed);
			var as_ = this.Measurement_Period();
			var at_ = context.Operators.Overlaps(ar_, as_, null);
			var au_ = context.Operators.And(aq_, at_);

			return au_;
		};
		var p_ = context.Operators.WhereOrNull<Procedure>(n_, o_);
		var q_ = context.Operators.ExistsInList<Procedure>(p_);
		var r_ = context.Operators.Or(l_, q_);

		return r_;
	}

    [CqlDeclaration("Palliative Care in the Measurement Period")]
	public bool? Palliative_Care_in_the_Measurement_Period() => 
		__Palliative_Care_in_the_Measurement_Period.Value;

}
