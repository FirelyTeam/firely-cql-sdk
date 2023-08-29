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

    private CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value()
	{
		var a_ = new CqlCode("71007-9", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_() => __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_.Value;

    private CqlCode survey_Value()
	{
		var a_ = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

		return a_;
	}

    [CqlDeclaration("survey")]
    public CqlCode survey() => __survey.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("71007-9", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
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
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Palliative_Care_in_the_Measurement_Period_Value()
	{
		var a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
		var b_ = context.Operators;
		var c_ = b_.ToList<CqlCode>(a_);
		var d_ = context.DataRetriever;
		var e_ = d_.RetrieveByCodes<Observation>(c_, null);
		bool? f_(Observation PalliativeAssessment)
		{
			var ae_ = PalliativeAssessment?.StatusElement;
			var af_ = new CallStackEntry("ToString", null, null);
			var ag_ = context.Deeper(af_);
			var ah_ = ag_.Operators;
			var ai_ = ah_.TypeConverter;
			var aj_ = ai_.Convert<string>(ae_);
			var ak_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var al_ = context.Operators;
			var am_ = al_.InList<string>(aj_, (ak_ as IEnumerable<string>));
			var an_ = PalliativeAssessment?.Category;
			bool? ao_(CodeableConcept PalliativeAssessmentCategory)
			{
				var bc_ = this.survey();
				var bd_ = FHIRHelpers_4_0_001.ToConcept(PalliativeAssessmentCategory);
				var be_ = bd_?.codes;
				var bf_ = context.Operators;
				var bg_ = bf_.CodeInList(bc_, (be_ as IEnumerable<CqlCode>));

				return bg_;
			};
			var aq_ = al_.WhereOrNull<CodeableConcept>((an_ as IEnumerable<CodeableConcept>), ao_);
			var as_ = al_.ExistsInList<CodeableConcept>(aq_);
			var au_ = al_.And(am_, as_);
			var av_ = PalliativeAssessment?.Effective;
			var aw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(av_);
			var ax_ = this.Measurement_Period();
			var az_ = al_.Overlaps(aw_, ax_, null);
			var bb_ = al_.And(au_, az_);

			return bb_;
		};
		var h_ = b_.WhereOrNull<Observation>(e_, f_);
		var j_ = b_.ExistsInList<Observation>(h_);
		var k_ = this.Palliative_Care_Encounter();
		var m_ = d_.RetrieveByValueSet<Encounter>(k_, null);
		bool? n_(Encounter PalliativeEncounter)
		{
			var bh_ = PalliativeEncounter?.StatusElement;
			var bi_ = new CallStackEntry("ToString", null, null);
			var bj_ = context.Deeper(bi_);
			var bk_ = bj_.Operators;
			var bl_ = bk_.TypeConverter;
			var bm_ = bl_.Convert<string>(bh_);
			var bn_ = context.Operators;
			var bo_ = bn_.Equal(bm_, "finished");
			var bp_ = PalliativeEncounter?.Period;
			var bq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bp_);
			var br_ = this.Measurement_Period();
			var bt_ = bn_.Overlaps(bq_, br_, null);
			var bv_ = bn_.And(bo_, bt_);

			return bv_;
		};
		var p_ = b_.WhereOrNull<Encounter>(m_, n_);
		var r_ = b_.ExistsInList<Encounter>(p_);
		var t_ = b_.Or(j_, r_);
		var u_ = this.Palliative_Care_Intervention();
		var w_ = d_.RetrieveByValueSet<Procedure>(u_, null);
		bool? x_(Procedure PalliativeIntervention)
		{
			var bw_ = PalliativeIntervention?.StatusElement;
			var bx_ = new CallStackEntry("ToString", null, null);
			var by_ = context.Deeper(bx_);
			var bz_ = by_.Operators;
			var ca_ = bz_.TypeConverter;
			var cb_ = ca_.Convert<string>(bw_);
			var cc_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var cd_ = context.Operators;
			var ce_ = cd_.InList<string>(cb_, (cc_ as IEnumerable<string>));
			var cf_ = PalliativeIntervention?.Performed;
			var cg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cf_);
			var ch_ = this.Measurement_Period();
			var cj_ = cd_.Overlaps(cg_, ch_, null);
			var cl_ = cd_.And(ce_, cj_);

			return cl_;
		};
		var z_ = b_.WhereOrNull<Procedure>(w_, x_);
		var ab_ = b_.ExistsInList<Procedure>(z_);
		var ad_ = b_.Or(t_, ab_);

		return ad_;
	}

    [CqlDeclaration("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period() => __Palliative_Care_in_the_Measurement_Period.Value;

}