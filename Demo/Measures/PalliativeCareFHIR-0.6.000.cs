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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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

    private CqlValueSet Palliative_Care_Encounter_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", 
			null);
    }

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090")]
    public CqlValueSet Palliative_Care_Encounter() => __Palliative_Care_Encounter.Value;

    private CqlValueSet Palliative_Care_Intervention_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", 
			null);
    }

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135")]
    public CqlValueSet Palliative_Care_Intervention() => __Palliative_Care_Intervention.Value;

    private CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal__Value()
    {
        return new CqlCode("71007-9", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_() => __Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_.Value;

    private CqlCode survey_Value()
    {
        return new CqlCode("survey", 
			"http://terminology.hl7.org/CodeSystem/observation-category", 
			null, 
			null);
    }

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

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("PalliativeCareFHIR-0.6.000", 
			"Measurement Period", 
			null));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private bool? Palliative_Care_in_the_Measurement_Period_Value()
    {
        var a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_();
        var b_ = context?.Operators.ToList<CqlCode>(a_);
        var c_ = context?.Operators.RetrieveByCodes<Observation>(b_, 
			typeof(Observation).GetProperty("Code"));
        Func<Observation,bool?> v_ = (PalliativeAssessment) => 
        {
            var d_ = (PalliativeAssessment?.StatusElement as object);
            var e_ = context?.Operators.Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = (PalliativeAssessment?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> n_ = (PalliativeAssessmentCategory) => 
            {
                var l_ = this.survey();
                var m_ = (FHIRHelpers_4_0_001.ToConcept(PalliativeAssessmentCategory)?.codes as IEnumerable<CqlCode>);
                return context?.Operators.CodeInList(l_, 
					m_);
            };
            var o_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, 
				n_);
            var p_ = context?.Operators.ExistsInList<CodeableConcept>(o_);
            var q_ = context?.Operators.And(j_, 
				p_);
            var r_ = (PalliativeAssessment?.Effective as object);
            var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
            var t_ = this.Measurement_Period();
            var u_ = context?.Operators.Overlaps(s_, 
				t_, 
				null);
            return context?.Operators.And(q_, 
				u_);
        };
        var w_ = context?.Operators.WhereOrNull<Observation>(c_, 
			v_);
        var x_ = context?.Operators.ExistsInList<Observation>(w_);
        var y_ = this.Palliative_Care_Encounter();
        var z_ = context?.Operators.RetrieveByValueSet<Encounter>(y_, 
			typeof(Encounter).GetProperty("Type"));
        Func<Encounter,bool?> ai_ = (PalliativeEncounter) => 
        {
            var ab_ = (PalliativeEncounter?.StatusElement as object);
            var aa_ = (context?.Operators.Convert<string>(ab_) as object);
            var ac_ = ("finished" as object);
            var ad_ = context?.Operators.Equal(aa_, 
				ac_);
            var ae_ = (PalliativeEncounter?.Period as object);
            var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ae_);
            var ag_ = this.Measurement_Period();
            var ah_ = context?.Operators.Overlaps(af_, 
				ag_, 
				null);
            return context?.Operators.And(ad_, 
				ah_);
        };
        var aj_ = context?.Operators.WhereOrNull<Encounter>(z_, 
			ai_);
        var ak_ = context?.Operators.ExistsInList<Encounter>(aj_);
        var al_ = context?.Operators.Or(x_, 
			ak_);
        var am_ = this.Palliative_Care_Intervention();
        var an_ = context?.Operators.RetrieveByValueSet<Procedure>(am_, 
			typeof(Procedure).GetProperty("Code"));
        Func<Procedure,bool?> ay_ = (PalliativeIntervention) => 
        {
            var ao_ = (PalliativeIntervention?.StatusElement as object);
            var ap_ = context?.Operators.Convert<string>(ao_);
            var ar_ = "completed";
            var as_ = "in-progress";
            var aq_ = (new string[]
			{
				ar_,
				as_,
			} as IEnumerable<string>);
            var at_ = context?.Operators.InList<string>(ap_, 
				aq_);
            var au_ = (PalliativeIntervention?.Performed as object);
            var av_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(au_);
            var aw_ = this.Measurement_Period();
            var ax_ = context?.Operators.Overlaps(av_, 
				aw_, 
				null);
            return context?.Operators.And(at_, 
				ax_);
        };
        var az_ = context?.Operators.WhereOrNull<Procedure>(an_, 
			ay_);
        var ba_ = context?.Operators.ExistsInList<Procedure>(az_);
        return context?.Operators.Or(al_, 
			ba_);
    }
    [CqlDeclaration("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period() => __Palliative_Care_in_the_Measurement_Period.Value;

}