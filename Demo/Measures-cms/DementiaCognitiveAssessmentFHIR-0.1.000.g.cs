using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("DementiaCognitiveAssessmentFHIR", "0.1.000")]
public class DementiaCognitiveAssessmentFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Behavioral_Neuropsych_Assessment;
    internal Lazy<CqlValueSet> __Care_Services_in_Long_Term_Residential_Facility;
    internal Lazy<CqlValueSet> __Cognitive_Assessment;
    internal Lazy<CqlValueSet> __Dementia_and_Mental_Degenerations;
    internal Lazy<CqlValueSet> __Face_to_Face_Interaction;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Occupational_Therapy_Evaluation;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Patient_Provider_Interaction;
    internal Lazy<CqlValueSet> __Patient_Reason;
    internal Lazy<CqlValueSet> __Psych_Visit_Diagnostic_Evaluation;
    internal Lazy<CqlValueSet> __Psych_Visit_Psychotherapy;
    internal Lazy<CqlValueSet> __Standardized_Tools_Score_for_Assessment_of_Cognition;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Encounter_to_Assess_Cognition;
    internal Lazy<IEnumerable<Encounter>> __Dementia_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_During_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Observation>> __Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods;
    internal Lazy<bool?> __Numerator;
    internal Lazy<IEnumerable<Observation>> __Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;

    #endregion
    public DementiaCognitiveAssessmentFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Behavioral_Neuropsych_Assessment = new Lazy<CqlValueSet>(this.Behavioral_Neuropsych_Assessment_Value);
        __Care_Services_in_Long_Term_Residential_Facility = new Lazy<CqlValueSet>(this.Care_Services_in_Long_Term_Residential_Facility_Value);
        __Cognitive_Assessment = new Lazy<CqlValueSet>(this.Cognitive_Assessment_Value);
        __Dementia_and_Mental_Degenerations = new Lazy<CqlValueSet>(this.Dementia_and_Mental_Degenerations_Value);
        __Face_to_Face_Interaction = new Lazy<CqlValueSet>(this.Face_to_Face_Interaction_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Occupational_Therapy_Evaluation = new Lazy<CqlValueSet>(this.Occupational_Therapy_Evaluation_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Patient_Provider_Interaction = new Lazy<CqlValueSet>(this.Patient_Provider_Interaction_Value);
        __Patient_Reason = new Lazy<CqlValueSet>(this.Patient_Reason_Value);
        __Psych_Visit_Diagnostic_Evaluation = new Lazy<CqlValueSet>(this.Psych_Visit_Diagnostic_Evaluation_Value);
        __Psych_Visit_Psychotherapy = new Lazy<CqlValueSet>(this.Psych_Visit_Psychotherapy_Value);
        __Standardized_Tools_Score_for_Assessment_of_Cognition = new Lazy<CqlValueSet>(this.Standardized_Tools_Score_for_Assessment_of_Cognition_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Encounter_to_Assess_Cognition = new Lazy<IEnumerable<Encounter>>(this.Encounter_to_Assess_Cognition_Value);
        __Dementia_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Dementia_Encounter_During_Measurement_Period_Value);
        __Qualifying_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_During_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods = new Lazy<IEnumerable<Observation>>(this.Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods = new Lazy<IEnumerable<Observation>>(this.Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Behavioral_Neuropsych_Assessment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", null);

    [CqlDeclaration("Behavioral/Neuropsych Assessment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023")]
	public CqlValueSet Behavioral_Neuropsych_Assessment() => 
		__Behavioral_Neuropsych_Assessment.Value;

	private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Cognitive_Assessment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332", null);

    [CqlDeclaration("Cognitive Assessment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332")]
	public CqlValueSet Cognitive_Assessment() => 
		__Cognitive_Assessment.Value;

	private CqlValueSet Dementia_and_Mental_Degenerations_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005", null);

    [CqlDeclaration("Dementia & Mental Degenerations")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005")]
	public CqlValueSet Dementia_and_Mental_Degenerations() => 
		__Dementia_and_Mental_Degenerations.Value;

	private CqlValueSet Face_to_Face_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public CqlValueSet Face_to_Face_Interaction() => 
		__Face_to_Face_Interaction.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

	private CqlValueSet Occupational_Therapy_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", null);

    [CqlDeclaration("Occupational Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011")]
	public CqlValueSet Occupational_Therapy_Evaluation() => 
		__Occupational_Therapy_Evaluation.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Patient_Provider_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", null);

    [CqlDeclaration("Patient Provider Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012")]
	public CqlValueSet Patient_Provider_Interaction() => 
		__Patient_Provider_Interaction.Value;

	private CqlValueSet Patient_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason() => 
		__Patient_Reason.Value;

	private CqlValueSet Psych_Visit_Diagnostic_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation() => 
		__Psych_Visit_Diagnostic_Evaluation.Value;

	private CqlValueSet Psych_Visit_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy() => 
		__Psych_Visit_Psychotherapy.Value;

	private CqlValueSet Standardized_Tools_Score_for_Assessment_of_Cognition_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006", null);

    [CqlDeclaration("Standardized Tools Score for Assessment of Cognition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006")]
	public CqlValueSet Standardized_Tools_Score_for_Assessment_of_Cognition() => 
		__Standardized_Tools_Score_for_Assessment_of_Cognition.Value;

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
		var d_ = context.ResolveParameter("DementiaCognitiveAssessmentFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private IEnumerable<Encounter> Encounter_to_Assess_Cognition_Value()
	{
		var a_ = this.Psych_Visit_Diagnostic_Evaluation();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Nursing_Facility_Visit();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Home_Healthcare_Services();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Psych_Visit_Psychotherapy();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Behavioral_Neuropsych_Assessment();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = this.Occupational_Therapy_Evaluation();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Office_Visit();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		var x_ = this.Outpatient_Consultation();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = context.Operators.ListUnion<Encounter>(w_, y_);

		return z_;
	}

    [CqlDeclaration("Encounter to Assess Cognition")]
	public IEnumerable<Encounter> Encounter_to_Assess_Cognition() => 
		__Encounter_to_Assess_Cognition.Value;

	private IEnumerable<Encounter> Dementia_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Encounter_to_Assess_Cognition();
		IEnumerable<Encounter> b_(Encounter EncounterAssessCognition)
		{
			var d_ = this.Dementia_and_Mental_Degenerations();
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			bool? f_(Condition Dementia)
			{
				var j_ = this.Measurement_Period();
				var k_ = FHIRHelpers_4_3_000.ToInterval(EncounterAssessCognition?.Period);
				var l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, k_, null);
				var m_ = QICoreCommon_2_0_000.prevalenceInterval(Dementia);
				var o_ = context.Operators.Overlaps(m_, k_, "day");
				var p_ = context.Operators.And(l_, o_);
				var q_ = QICoreCommon_2_0_000.isActive(Dementia);
				var r_ = context.Operators.And(p_, q_);
				var s_ = FHIRHelpers_4_3_000.ToConcept(Dementia?.VerificationStatus);
				var t_ = QICoreCommon_2_0_000.unconfirmed();
				var u_ = context.Operators.ConvertCodeToConcept(t_);
				var v_ = context.Operators.Equivalent(s_, u_);
				var x_ = QICoreCommon_2_0_000.refuted();
				var y_ = context.Operators.ConvertCodeToConcept(x_);
				var z_ = context.Operators.Equivalent(s_, y_);
				var aa_ = context.Operators.Or(v_, z_);
				var ac_ = QICoreCommon_2_0_000.entered_in_error();
				var ad_ = context.Operators.ConvertCodeToConcept(ac_);
				var ae_ = context.Operators.Equivalent(s_, ad_);
				var af_ = context.Operators.Or(aa_, ae_);
				var ag_ = context.Operators.Not(af_);
				var ah_ = context.Operators.And(r_, ag_);

				return ah_;
			};
			var g_ = context.Operators.WhereOrNull<Condition>(e_, f_);
			Encounter h_(Condition Dementia) => 
				EncounterAssessCognition;
			var i_ = context.Operators.SelectOrNull<Condition, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Dementia Encounter During Measurement Period")]
	public IEnumerable<Encounter> Dementia_Encounter_During_Measurement_Period() => 
		__Dementia_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Encounter_to_Assess_Cognition();
		var b_ = this.Patient_Provider_Interaction();
		var c_ = context.Operators.RetrieveByValueSet<Encounter>(b_, null);
		var d_ = context.Operators.ListUnion<Encounter>(a_, c_);
		bool? e_(Encounter ValidEncounter)
		{
			var g_ = this.Measurement_Period();
			var h_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, h_, null);
			var j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ValidEncounter?.StatusElement?.Value);
			var k_ = context.Operators.Equal(j_, "finished");
			var l_ = context.Operators.And(i_, k_);

			return l_;
		};
		var f_ = context.Operators.WhereOrNull<Encounter>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period() => 
		__Qualifying_Encounter_During_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Dementia_Encounter_During_Measurement_Period();
		var b_ = context.Operators.ExistsInList<Encounter>(a_);
		var c_ = this.Qualifying_Encounter_During_Measurement_Period();
		var d_ = context.Operators.CountOrNull<Encounter>(c_);
		var e_ = context.Operators.GreaterOrEqual(d_, (int?)2);
		var f_ = context.Operators.And(b_, e_);

		return f_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Observation> Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods_Value()
	{
		var a_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = this.Cognitive_Assessment();
		var d_ = context.Operators.RetrieveByValueSet<Observation>(c_, null);
		var e_ = context.Operators.ListUnion<Observation>(b_, d_);
		IEnumerable<Observation> f_(Observation CognitiveAssessment)
		{
			var j_ = this.Dementia_Encounter_During_Measurement_Period();
			bool? k_(Encounter EncounterDementia)
			{
				var o_ = FHIRHelpers_4_3_000.ToValue(CognitiveAssessment?.Effective);
				var p_ = QICoreCommon_2_0_000.toInterval(o_);
				var q_ = context.Operators.Start(p_);
				var r_ = FHIRHelpers_4_3_000.ToInterval(EncounterDementia?.Period);
				var s_ = context.Operators.End(r_);
				var t_ = context.Operators.Quantity((decimal?)12m, "months");
				var u_ = context.Operators.Subtract(s_, t_);
				var w_ = context.Operators.End(r_);
				var x_ = context.Operators.Interval(u_, w_, (bool?)true, (bool?)true);
				var y_ = context.Operators.ElementInInterval<CqlDateTime>(q_, x_, "day");
				var aa_ = context.Operators.End(r_);
				var ab_ = context.Operators.Not((bool?)(aa_ is null));
				var ac_ = context.Operators.And(y_, ab_);

				return ac_;
			};
			var l_ = context.Operators.WhereOrNull<Encounter>(j_, k_);
			Observation m_(Encounter EncounterDementia) => 
				CognitiveAssessment;
			var n_ = context.Operators.SelectOrNull<Encounter, Observation>(l_, m_);

			return n_;
		};
		var g_ = context.Operators.SelectManyOrNull<Observation, Observation>(e_, f_);
		bool? h_(Observation CognitiveAssessment)
		{
			var ad_ = FHIRHelpers_4_3_000.ToValue(CognitiveAssessment?.Value);
			var ae_ = context.Operators.Not((bool?)(ad_ is null));
			var af_ = context.Operators.Convert<Code<ObservationStatus>>(CognitiveAssessment?.StatusElement?.Value);
			var ag_ = context.Operators.Convert<string>(af_);
			var ah_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"preliminary",
			};
			var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
			var aj_ = context.Operators.And(ae_, ai_);

			return aj_;
		};
		var i_ = context.Operators.WhereOrNull<Observation>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Assessment of Cognition Using Standardized Tools or Alternate Methods")]
	public IEnumerable<Observation> Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods() => 
		__Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods();
		var b_ = context.Operators.ExistsInList<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private IEnumerable<Observation> Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods_Value()
	{
		var a_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = this.Cognitive_Assessment();
		var d_ = context.Operators.RetrieveByValueSet<Observation>(c_, null);
		var e_ = context.Operators.ListUnion<Observation>(b_, d_);
		IEnumerable<Observation> f_(Observation NoCognitiveAssessment)
		{
			var j_ = this.Dementia_Encounter_During_Measurement_Period();
			bool? k_(Encounter EncounterDementia)
			{
				var o_ = context.Operators.Convert<CqlDateTime>(NoCognitiveAssessment?.IssuedElement?.Value);
				var p_ = FHIRHelpers_4_3_000.ToInterval(EncounterDementia?.Period);
				var q_ = context.Operators.ElementInInterval<CqlDateTime>(o_, p_, null);

				return q_;
			};
			var l_ = context.Operators.WhereOrNull<Encounter>(j_, k_);
			Observation m_(Encounter EncounterDementia) => 
				NoCognitiveAssessment;
			var n_ = context.Operators.SelectOrNull<Encounter, Observation>(l_, m_);

			return n_;
		};
		var g_ = context.Operators.SelectManyOrNull<Observation, Observation>(e_, f_);
		bool? h_(Observation NoCognitiveAssessment)
		{
			bool? r_(Extension @this)
			{
				var aa_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

				return aa_;
			};
			var s_ = context.Operators.WhereOrNull<Extension>(((NoCognitiveAssessment is DomainResource)
					? ((NoCognitiveAssessment as DomainResource).Extension)
					: null), r_);
			DataType t_(Extension @this) => 
				@this?.Value;
			var u_ = context.Operators.SelectOrNull<Extension, DataType>(s_, t_);
			var v_ = context.Operators.SingleOrNull<DataType>(u_);
			var w_ = context.Operators.Convert<CodeableConcept>(v_);
			var x_ = FHIRHelpers_4_3_000.ToConcept(w_);
			var y_ = this.Patient_Reason();
			var z_ = context.Operators.ConceptInValueSet(x_, y_);

			return z_;
		};
		var i_ = context.Operators.WhereOrNull<Observation>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Patient Reason for Not Performing Assessment of Cognition Using Standardized Tools or Alternate Methods")]
	public IEnumerable<Observation> Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods() => 
		__Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods.Value;

	private bool? Denominator_Exceptions_Value()
	{
		var a_ = this.Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods();
		var b_ = context.Operators.ExistsInList<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

}
