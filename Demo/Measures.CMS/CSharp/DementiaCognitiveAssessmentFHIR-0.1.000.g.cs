using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;

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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Behavioral_Neuropsych_Assessment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", default);

    [CqlDeclaration("Behavioral/Neuropsych Assessment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023")]
	public CqlValueSet Behavioral_Neuropsych_Assessment() => 
		__Behavioral_Neuropsych_Assessment.Value;

	private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);

    [CqlDeclaration("Care Services in Long Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Cognitive_Assessment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332", default);

    [CqlDeclaration("Cognitive Assessment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332")]
	public CqlValueSet Cognitive_Assessment() => 
		__Cognitive_Assessment.Value;

	private CqlValueSet Dementia_and_Mental_Degenerations_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005", default);

    [CqlDeclaration("Dementia & Mental Degenerations")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005")]
	public CqlValueSet Dementia_and_Mental_Degenerations() => 
		__Dementia_and_Mental_Degenerations.Value;

	private CqlValueSet Face_to_Face_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", default);

    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public CqlValueSet Face_to_Face_Interaction() => 
		__Face_to_Face_Interaction.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

	private CqlValueSet Occupational_Therapy_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", default);

    [CqlDeclaration("Occupational Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011")]
	public CqlValueSet Occupational_Therapy_Evaluation() => 
		__Occupational_Therapy_Evaluation.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Patient_Provider_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", default);

    [CqlDeclaration("Patient Provider Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012")]
	public CqlValueSet Patient_Provider_Interaction() => 
		__Patient_Provider_Interaction.Value;

	private CqlValueSet Patient_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", default);

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason() => 
		__Patient_Reason.Value;

	private CqlValueSet Psych_Visit_Diagnostic_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", default);

    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation() => 
		__Psych_Visit_Diagnostic_Evaluation.Value;

	private CqlValueSet Psych_Visit_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", default);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy() => 
		__Psych_Visit_Psychotherapy.Value;

	private CqlValueSet Standardized_Tools_Score_for_Assessment_of_Cognition_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006", default);

    [CqlDeclaration("Standardized Tools Score for Assessment of Cognition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006")]
	public CqlValueSet Standardized_Tools_Score_for_Assessment_of_Cognition() => 
		__Standardized_Tools_Score_for_Assessment_of_Cognition.Value;

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("DementiaCognitiveAssessmentFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Encounter_to_Assess_Cognition_Value()
	{
		CqlValueSet a_ = this.Psych_Visit_Diagnostic_Evaluation();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Psych_Visit_Psychotherapy();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Behavioral_Neuropsych_Assessment();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Occupational_Therapy_Evaluation();
		IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet t_ = this.Office_Visit();
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> z_ = context.Operators.Union<Encounter>(w_, y_);

		return z_;
	}

    [CqlDeclaration("Encounter to Assess Cognition")]
	public IEnumerable<Encounter> Encounter_to_Assess_Cognition() => 
		__Encounter_to_Assess_Cognition.Value;

	private IEnumerable<Encounter> Dementia_Encounter_During_Measurement_Period_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_to_Assess_Cognition();
		IEnumerable<Encounter> b_(Encounter EncounterAssessCognition)
		{
			CqlValueSet d_ = this.Dementia_and_Mental_Degenerations();
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? f_(Condition Dementia)
			{
				CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
				Period k_ = EncounterAssessCognition?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, default);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.prevalenceInterval(Dementia);
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(k_);
				bool? q_ = context.Operators.Overlaps(n_, p_, "day");
				bool? r_ = context.Operators.And(m_, q_);
				bool? s_ = QICoreCommon_2_0_000.isActive(Dementia);
				bool? t_ = context.Operators.And(r_, s_);
				CodeableConcept u_ = Dementia?.VerificationStatus;
				CqlConcept v_ = FHIRHelpers_4_3_000.ToConcept(u_);
				CqlCode w_ = QICoreCommon_2_0_000.unconfirmed();
				CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
				bool? y_ = context.Operators.Equivalent(v_, x_);
				CqlConcept aa_ = FHIRHelpers_4_3_000.ToConcept(u_);
				CqlCode ab_ = QICoreCommon_2_0_000.refuted();
				CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
				bool? ad_ = context.Operators.Equivalent(aa_, ac_);
				bool? ae_ = context.Operators.Or(y_, ad_);
				CqlConcept ag_ = FHIRHelpers_4_3_000.ToConcept(u_);
				CqlCode ah_ = QICoreCommon_2_0_000.entered_in_error();
				CqlConcept ai_ = context.Operators.ConvertCodeToConcept(ah_);
				bool? aj_ = context.Operators.Equivalent(ag_, ai_);
				bool? ak_ = context.Operators.Or(ae_, aj_);
				bool? al_ = context.Operators.Not(ak_);
				bool? am_ = context.Operators.And(t_, al_);

				return am_;
			};
			IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
			Encounter h_(Condition Dementia) => 
				EncounterAssessCognition;
			IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Dementia Encounter During Measurement Period")]
	public IEnumerable<Encounter> Dementia_Encounter_During_Measurement_Period() => 
		__Dementia_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_to_Assess_Cognition();
		CqlValueSet b_ = this.Patient_Provider_Interaction();
		IEnumerable<Encounter> c_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> d_ = context.Operators.Union<Encounter>(a_, c_);
		bool? e_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			Period h_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.ToInterval(h_);
			bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, i_, default);
			Code<Encounter.EncounterStatus> k_ = ValidEncounter?.StatusElement;
			Encounter.EncounterStatus? l_ = k_?.Value;
			Code<Encounter.EncounterStatus> m_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(l_);
			bool? n_ = context.Operators.Equal(m_, "finished");
			bool? o_ = context.Operators.And(j_, n_);

			return o_;
		};
		IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period() => 
		__Qualifying_Encounter_During_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Dementia_Encounter_During_Measurement_Period();
		bool? b_ = context.Operators.Exists<Encounter>(a_);
		IEnumerable<Encounter> c_ = this.Qualifying_Encounter_During_Measurement_Period();
		int? d_ = context.Operators.Count<Encounter>(c_);
		bool? e_ = context.Operators.GreaterOrEqual(d_, 2);
		bool? f_ = context.Operators.And(b_, e_);

		return f_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Observation> Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods_Value()
	{
		CqlValueSet a_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		CqlValueSet c_ = this.Cognitive_Assessment();
		IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> e_ = context.Operators.Union<Observation>(b_, d_);
		IEnumerable<Observation> f_(Observation CognitiveAssessment)
		{
			IEnumerable<Encounter> j_ = this.Dementia_Encounter_During_Measurement_Period();
			bool? k_(Encounter EncounterDementia)
			{
				DataType o_ = CognitiveAssessment?.Effective;
				object p_ = FHIRHelpers_4_3_000.ToValue(o_);
				CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.toInterval(p_);
				CqlDateTime r_ = context.Operators.Start(q_);
				Period s_ = EncounterDementia?.Period;
				CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(s_);
				CqlDateTime u_ = context.Operators.End(t_);
				CqlQuantity v_ = context.Operators.Quantity(12m, "months");
				CqlDateTime w_ = context.Operators.Subtract(u_, v_);
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.ToInterval(s_);
				CqlDateTime z_ = context.Operators.End(y_);
				CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(w_, z_, true, true);
				bool? ab_ = context.Operators.In<CqlDateTime>(r_, aa_, "day");
				CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(s_);
				CqlDateTime ae_ = context.Operators.End(ad_);
				bool? af_ = context.Operators.Not((bool?)(ae_ is null));
				bool? ag_ = context.Operators.And(ab_, af_);

				return ag_;
			};
			IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
			Observation m_(Encounter EncounterDementia) => 
				CognitiveAssessment;
			IEnumerable<Observation> n_ = context.Operators.Select<Encounter, Observation>(l_, m_);

			return n_;
		};
		IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
		bool? h_(Observation CognitiveAssessment)
		{
			DataType ah_ = CognitiveAssessment?.Value;
			object ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
			bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
			Code<ObservationStatus> ak_ = CognitiveAssessment?.StatusElement;
			ObservationStatus? al_ = ak_?.Value;
			Code<ObservationStatus> am_ = context.Operators.Convert<Code<ObservationStatus>>(al_);
			string an_ = context.Operators.Convert<string>(am_);
			string[] ao_ = [
				"final",
				"amended",
				"corrected",
				"preliminary",
			];
			bool? ap_ = context.Operators.In<string>(an_, ao_ as IEnumerable<string>);
			bool? aq_ = context.Operators.And(aj_, ap_);

			return aq_;
		};
		IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Assessment of Cognition Using Standardized Tools or Alternate Methods")]
	public IEnumerable<Observation> Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods() => 
		__Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<Observation> a_ = this.Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods();
		bool? b_ = context.Operators.Exists<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private IEnumerable<Observation> Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods_Value()
	{
		CqlValueSet a_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
		CqlValueSet c_ = this.Cognitive_Assessment();
		IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
		IEnumerable<Observation> e_ = context.Operators.Union<Observation>(b_, d_);
		IEnumerable<Observation> f_(Observation NoCognitiveAssessment)
		{
			IEnumerable<Encounter> j_ = this.Dementia_Encounter_During_Measurement_Period();
			bool? k_(Encounter EncounterDementia)
			{
				Instant o_ = NoCognitiveAssessment?.IssuedElement;
				DateTimeOffset? p_ = o_?.Value;
				CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
				Period r_ = EncounterDementia?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, default);

				return t_;
			};
			IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
			Observation m_(Encounter EncounterDementia) => 
				NoCognitiveAssessment;
			IEnumerable<Observation> n_ = context.Operators.Select<Encounter, Observation>(l_, m_);

			return n_;
		};
		IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
		bool? h_(Observation NoCognitiveAssessment)
		{
			bool? u_(Extension @this)
			{
				string ac_ = @this?.Url;
				FhirString ad_ = context.Operators.Convert<FhirString>(ac_);
				string ae_ = FHIRHelpers_4_3_000.ToString(ad_);
				bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

				return af_;
			};
			IEnumerable<Extension> v_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoCognitiveAssessment is DomainResource
					? (NoCognitiveAssessment as DomainResource).Extension
					: default), u_);
			object w_(Extension @this)
			{
				DataType ag_ = @this?.Value;

				return ag_;
			};
			IEnumerable<object> x_ = context.Operators.Select<Extension, object>(v_, w_);
			object y_ = context.Operators.SingletonFrom<object>(x_);
			CqlConcept z_ = FHIRHelpers_4_3_000.ToConcept(y_ as CodeableConcept);
			CqlValueSet aa_ = this.Patient_Reason();
			bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);

			return ab_;
		};
		IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Patient Reason for Not Performing Assessment of Cognition Using Standardized Tools or Alternate Methods")]
	public IEnumerable<Observation> Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods() => 
		__Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods.Value;

	private bool? Denominator_Exceptions_Value()
	{
		IEnumerable<Observation> a_ = this.Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods();
		bool? b_ = context.Operators.Exists<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

}
