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
		var am_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
		var an_ = context?.Operators.ToList<CqlCode>(am_);
		var ao_ = context?.DataRetriever.RetrieveByCodes<Observation>(an_, null);
		var ap_ = (Observation PalliativeAssessment) =>
		{
			var c_ = (PalliativeAssessment?.StatusElement as object);
			var d_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(c_);
			var e_ = "final";
			var f_ = "amended";
			var g_ = "corrected";
			var h_ = new string[]
			{
				e_,
				f_,
				g_,
			};
			var i_ = (h_ as IEnumerable<string>);
			var j_ = context?.Operators.InList<string>(d_, i_);
			var k_ = (PalliativeAssessment?.Category as IEnumerable<CodeableConcept>);
			var l_ = (CodeableConcept PalliativeAssessmentCategory) =>
			{
				var a_ = this.survey();
				var b_ = (FHIRHelpers_4_0_001.ToConcept(PalliativeAssessmentCategory)?.codes as IEnumerable<CqlCode>);

				return context?.Operators.CodeInList(a_, b_);
			};
			var m_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, l_);
			var n_ = context?.Operators.ExistsInList<CodeableConcept>(m_);
			var o_ = context?.Operators.And(j_, n_);
			var p_ = (PalliativeAssessment?.Effective as object);
			var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(p_);
			var r_ = this.Measurement_Period();
			var s_ = context?.Operators.Overlaps(q_, r_, null);

			return context?.Operators.And(o_, s_);
		};
		var aq_ = context?.Operators.WhereOrNull<Observation>(ao_, ap_);
		var ar_ = context?.Operators.ExistsInList<Observation>(aq_);
		var as_ = this.Palliative_Care_Encounter();
		var at_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(as_, null);
		var au_ = (Encounter PalliativeEncounter) =>
		{
			var t_ = (PalliativeEncounter?.StatusElement as object);
			var u_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(t_);
			var v_ = (u_ as object);
			var w_ = context?.Operators.Equal(v_, ("finished" as object));
			var x_ = (PalliativeEncounter?.Period as object);
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(x_);
			var z_ = this.Measurement_Period();
			var aa_ = context?.Operators.Overlaps(y_, z_, null);

			return context?.Operators.And(w_, aa_);
		};
		var av_ = context?.Operators.WhereOrNull<Encounter>(at_, au_);
		var aw_ = context?.Operators.ExistsInList<Encounter>(av_);
		var ax_ = context?.Operators.Or(ar_, aw_);
		var ay_ = this.Palliative_Care_Intervention();
		var az_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(ay_, null);
		var ba_ = (Procedure PalliativeIntervention) =>
		{
			var ab_ = (PalliativeIntervention?.StatusElement as object);
			var ac_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ab_);
			var ad_ = "completed";
			var ae_ = "in-progress";
			var af_ = new string[]
			{
				ad_,
				ae_,
			};
			var ag_ = (af_ as IEnumerable<string>);
			var ah_ = context?.Operators.InList<string>(ac_, ag_);
			var ai_ = (PalliativeIntervention?.Performed as object);
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ai_);
			var ak_ = this.Measurement_Period();
			var al_ = context?.Operators.Overlaps(aj_, ak_, null);

			return context?.Operators.And(ah_, al_);
		};
		var bb_ = context?.Operators.WhereOrNull<Procedure>(az_, ba_);
		var bc_ = context?.Operators.ExistsInList<Procedure>(bb_);

		return context?.Operators.Or(ax_, bc_);
	}

    [CqlDeclaration("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period() => __Palliative_Care_in_the_Measurement_Period.Value;

}