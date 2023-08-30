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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Palliative_Care_in_the_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var g_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
		var h_ = a_.ToList<CqlCode>(g_);
		var i_ = e_.RetrieveByCodes<Observation>(h_, null);
		bool? j_(Observation PalliativeAssessment)
		{
			var ae_ = context.Operators;
			var ah_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ai_ = ah_.Operators;
			var aj_ = ai_.TypeConverter;
			var ak_ = PalliativeAssessment?.StatusElement;
			var al_ = aj_.Convert<string>(ak_);
			var am_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var an_ = ae_.InList<string>(al_, (am_ as IEnumerable<string>));
			var aq_ = PalliativeAssessment?.Category;
			bool? ar_(CodeableConcept PalliativeAssessmentCategory)
			{
				var bb_ = context.Operators;
				var bc_ = this.survey();
				var bd_ = FHIRHelpers_4_0_001.ToConcept(PalliativeAssessmentCategory);
				var be_ = bd_?.codes;
				var bf_ = bb_.CodeInList(bc_, (be_ as IEnumerable<CqlCode>));

				return bf_;
			};
			var as_ = ae_.WhereOrNull<CodeableConcept>((aq_ as IEnumerable<CodeableConcept>), ar_);
			var at_ = ae_.ExistsInList<CodeableConcept>(as_);
			var au_ = ae_.And(an_, at_);
			var aw_ = PalliativeAssessment?.Effective;
			var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aw_);
			var ay_ = this.Measurement_Period();
			var az_ = ae_.Overlaps(ax_, ay_, null);
			var ba_ = ae_.And(au_, az_);

			return ba_;
		};
		var k_ = a_.WhereOrNull<Observation>(i_, j_);
		var l_ = a_.ExistsInList<Observation>(k_);
		var p_ = this.Palliative_Care_Encounter();
		var q_ = e_.RetrieveByValueSet<Encounter>(p_, null);
		bool? r_(Encounter PalliativeEncounter)
		{
			var bg_ = context.Operators;
			var bi_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var bj_ = bi_.Operators;
			var bk_ = bj_.TypeConverter;
			var bl_ = PalliativeEncounter?.StatusElement;
			var bm_ = bk_.Convert<string>(bl_);
			var bn_ = bg_.Equal(bm_, "finished");
			var bp_ = PalliativeEncounter?.Period;
			var bq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bp_);
			var br_ = this.Measurement_Period();
			var bs_ = bg_.Overlaps(bq_, br_, null);
			var bt_ = bg_.And(bn_, bs_);

			return bt_;
		};
		var s_ = a_.WhereOrNull<Encounter>(q_, r_);
		var t_ = a_.ExistsInList<Encounter>(s_);
		var u_ = a_.Or(l_, t_);
		var y_ = this.Palliative_Care_Intervention();
		var z_ = e_.RetrieveByValueSet<Procedure>(y_, null);
		bool? aa_(Procedure PalliativeIntervention)
		{
			var bu_ = context.Operators;
			var bw_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var bx_ = bw_.Operators;
			var by_ = bx_.TypeConverter;
			var bz_ = PalliativeIntervention?.StatusElement;
			var ca_ = by_.Convert<string>(bz_);
			var cb_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var cc_ = bu_.InList<string>(ca_, (cb_ as IEnumerable<string>));
			var ce_ = PalliativeIntervention?.Performed;
			var cf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ce_);
			var cg_ = this.Measurement_Period();
			var ch_ = bu_.Overlaps(cf_, cg_, null);
			var ci_ = bu_.And(cc_, ch_);

			return ci_;
		};
		var ab_ = a_.WhereOrNull<Procedure>(z_, aa_);
		var ac_ = a_.ExistsInList<Procedure>(ab_);
		var ad_ = a_.Or(u_, ac_);

		return ad_;
	}

    [CqlDeclaration("Palliative Care in the Measurement Period")]
	public bool? Palliative_Care_in_the_Measurement_Period() => 
		__Palliative_Care_in_the_Measurement_Period.Value;

}