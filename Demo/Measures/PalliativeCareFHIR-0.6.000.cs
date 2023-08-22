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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", 
			null);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090")]
    public CqlValueSet Palliative_Care_Encounter() => __Palliative_Care_Encounter.Value;

    private CqlValueSet Palliative_Care_Intervention_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", 
			null);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
    public CqlValueSet Palliative_Care_Intervention() => __Palliative_Care_Intervention.Value;

    private CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value() =>
		new CqlCode("71007-9", 
			"http://loinc.org", 
			null, 
			null);

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_() => __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_.Value;

    private CqlCode survey_Value() =>
		new CqlCode("survey", 
			"http://terminology.hl7.org/CodeSystem/observation-category", 
			null, 
			null);

    [CqlDeclaration("survey")]
    public CqlCode survey() => __survey.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("71007-9", 
			"http://loinc.org", 
			null, 
			null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode("survey", 
			"http://terminology.hl7.org/CodeSystem/observation-category", 
			null, 
			null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes() => __ObservationCategoryCodes.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value() =>
		(CqlInterval<CqlDateTime>)context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

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
		var a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
		var b_ = context?.Operators.ToList<CqlCode>(a_);
		var c_ = context?.DataRetriever.RetrieveByCodes<Observation>(b_, null);
		var d_ = (Observation PalliativeAssessment) =>
		{
			var a_ = (PalliativeAssessment?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = (PalliativeAssessment?.Category as IEnumerable<CodeableConcept>);
			var j_ = (CodeableConcept PalliativeAssessmentCategory) =>
			{
				var a_ = this.survey();
				var b_ = (FHIRHelpers_4_0_001.ToConcept(PalliativeAssessmentCategory)?.codes as IEnumerable<CqlCode>);

				return context?.Operators.CodeInList(a_, b_);
			};
			var k_ = context?.Operators.WhereOrNull<CodeableConcept>(i_, j_);
			var l_ = context?.Operators.ExistsInList<CodeableConcept>(k_);
			var m_ = context?.Operators.And(h_, l_);
			var n_ = (PalliativeAssessment?.Effective as object);
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(n_);
			var p_ = this.Measurement_Period();
			var q_ = context?.Operators.Overlaps(o_, p_, null);

			return context?.Operators.And(m_, q_);
		};
		var e_ = context?.Operators.WhereOrNull<Observation>(c_, d_);
		var f_ = context?.Operators.ExistsInList<Observation>(e_);
		var g_ = this.Palliative_Care_Encounter();
		var h_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(g_, null);
		var i_ = (Encounter PalliativeEncounter) =>
		{
			var a_ = (PalliativeEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = (PalliativeEncounter?.Period as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.Overlaps(f_, g_, null);

			return context?.Operators.And(d_, h_);
		};
		var j_ = context?.Operators.WhereOrNull<Encounter>(h_, i_);
		var k_ = context?.Operators.ExistsInList<Encounter>(j_);
		var l_ = context?.Operators.Or(f_, k_);
		var m_ = this.Palliative_Care_Intervention();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(m_, null);
		var o_ = (Procedure PalliativeIntervention) =>
		{
			var a_ = (PalliativeIntervention?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "completed";
			var d_ = "in-progress";
			var e_ = new string[]
			{
				c_,
				d_,
			};
			var f_ = (e_ as IEnumerable<string>);
			var g_ = context?.Operators.InList<string>(b_, f_);
			var h_ = (PalliativeIntervention?.Performed as object);
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.Overlaps(i_, j_, null);

			return context?.Operators.And(g_, k_);
		};
		var p_ = context?.Operators.WhereOrNull<Procedure>(n_, o_);
		var q_ = context?.Operators.ExistsInList<Procedure>(p_);

		return context?.Operators.Or(l_, q_);
	}

    [CqlDeclaration("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period() => __Palliative_Care_in_the_Measurement_Period.Value;

}