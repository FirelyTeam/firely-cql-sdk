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
[CqlLibrary("HFBetaBlockerTherapyforLVSDFHIR", "1.3.000")]
public class HFBetaBlockerTherapyforLVSDFHIR_1_3_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Allergy_to_Beta_Blocker_Therapy;
    internal Lazy<CqlValueSet> __Arrhythmia;
    internal Lazy<CqlValueSet> __Asthma;
    internal Lazy<CqlValueSet> __Atrioventricular_Block;
    internal Lazy<CqlValueSet> __Beta_Blocker_Therapy_for_LVSD;
    internal Lazy<CqlValueSet> __Beta_Blocker_Therapy_Ingredient;
    internal Lazy<CqlValueSet> __Bradycardia;
    internal Lazy<CqlValueSet> __Cardiac_Pacer;
    internal Lazy<CqlValueSet> __Cardiac_Pacer_in_Situ;
    internal Lazy<CqlValueSet> __Hypotension;
    internal Lazy<CqlValueSet> __Intolerance_to_Beta_Blocker_Therapy;
    internal Lazy<CqlValueSet> __Left_Ventricular_Assist_Device_Placement;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Patient_Reason;
    internal Lazy<CqlCode> __Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<bool?> __Has_Beta_Blocker_Therapy_for_LVSD_Ordered;
    internal Lazy<bool?> __Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Has_Consecutive_Heart_Rates_Less_than_50;
    internal Lazy<bool?> __Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD;
    internal Lazy<bool?> __Has_Arrhythmia_Diagnosis;
    internal Lazy<bool?> __Has_Hypotension_Diagnosis;
    internal Lazy<bool?> __Has_Asthma_Diagnosis;
    internal Lazy<bool?> __Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy;
    internal Lazy<bool?> __Has_Bradycardia_Diagnosis;
    internal Lazy<bool?> __Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient;
    internal Lazy<bool?> __Has_Atrioventricular_Block_Diagnosis;
    internal Lazy<bool?> __Has_Diagnosis_of_Cardiac_Pacer_in_Situ;
    internal Lazy<bool?> __Has_Cardiac_Pacer_Device_Implanted;
    internal Lazy<bool?> __Atrioventricular_Block_without_Cardiac_Pacer;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public HFBetaBlockerTherapyforLVSDFHIR_1_3_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        AHAOverall_2_6_000 = new AHAOverall_2_6_000(context);

        __Allergy_to_Beta_Blocker_Therapy = new Lazy<CqlValueSet>(this.Allergy_to_Beta_Blocker_Therapy_Value);
        __Arrhythmia = new Lazy<CqlValueSet>(this.Arrhythmia_Value);
        __Asthma = new Lazy<CqlValueSet>(this.Asthma_Value);
        __Atrioventricular_Block = new Lazy<CqlValueSet>(this.Atrioventricular_Block_Value);
        __Beta_Blocker_Therapy_for_LVSD = new Lazy<CqlValueSet>(this.Beta_Blocker_Therapy_for_LVSD_Value);
        __Beta_Blocker_Therapy_Ingredient = new Lazy<CqlValueSet>(this.Beta_Blocker_Therapy_Ingredient_Value);
        __Bradycardia = new Lazy<CqlValueSet>(this.Bradycardia_Value);
        __Cardiac_Pacer = new Lazy<CqlValueSet>(this.Cardiac_Pacer_Value);
        __Cardiac_Pacer_in_Situ = new Lazy<CqlValueSet>(this.Cardiac_Pacer_in_Situ_Value);
        __Hypotension = new Lazy<CqlValueSet>(this.Hypotension_Value);
        __Intolerance_to_Beta_Blocker_Therapy = new Lazy<CqlValueSet>(this.Intolerance_to_Beta_Blocker_Therapy_Value);
        __Left_Ventricular_Assist_Device_Placement = new Lazy<CqlValueSet>(this.Left_Ventricular_Assist_Device_Placement_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Patient_Reason = new Lazy<CqlValueSet>(this.Patient_Reason_Value);
        __Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_ = new Lazy<CqlCode>(this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance__Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Has_Beta_Blocker_Therapy_for_LVSD_Ordered = new Lazy<bool?>(this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Value);
        __Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD = new Lazy<bool?>(this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Has_Consecutive_Heart_Rates_Less_than_50 = new Lazy<bool?>(this.Has_Consecutive_Heart_Rates_Less_than_50_Value);
        __Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD = new Lazy<bool?>(this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Value);
        __Has_Arrhythmia_Diagnosis = new Lazy<bool?>(this.Has_Arrhythmia_Diagnosis_Value);
        __Has_Hypotension_Diagnosis = new Lazy<bool?>(this.Has_Hypotension_Diagnosis_Value);
        __Has_Asthma_Diagnosis = new Lazy<bool?>(this.Has_Asthma_Diagnosis_Value);
        __Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy = new Lazy<bool?>(this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Value);
        __Has_Bradycardia_Diagnosis = new Lazy<bool?>(this.Has_Bradycardia_Diagnosis_Value);
        __Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient = new Lazy<bool?>(this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_Value);
        __Has_Atrioventricular_Block_Diagnosis = new Lazy<bool?>(this.Has_Atrioventricular_Block_Diagnosis_Value);
        __Has_Diagnosis_of_Cardiac_Pacer_in_Situ = new Lazy<bool?>(this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ_Value);
        __Has_Cardiac_Pacer_Device_Implanted = new Lazy<bool?>(this.Has_Cardiac_Pacer_Device_Implanted_Value);
        __Atrioventricular_Block_without_Cardiac_Pacer = new Lazy<bool?>(this.Atrioventricular_Block_without_Cardiac_Pacer_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public AHAOverall_2_6_000 AHAOverall_2_6_000 { get; }

    #endregion

	private CqlValueSet Allergy_to_Beta_Blocker_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", default);

    [CqlDeclaration("Allergy to Beta Blocker Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177")]
	public CqlValueSet Allergy_to_Beta_Blocker_Therapy() => 
		__Allergy_to_Beta_Blocker_Therapy.Value;

	private CqlValueSet Arrhythmia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", default);

    [CqlDeclaration("Arrhythmia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366")]
	public CqlValueSet Arrhythmia() => 
		__Arrhythmia.Value;

	private CqlValueSet Asthma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", default);

    [CqlDeclaration("Asthma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362")]
	public CqlValueSet Asthma() => 
		__Asthma.Value;

	private CqlValueSet Atrioventricular_Block_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", default);

    [CqlDeclaration("Atrioventricular Block")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367")]
	public CqlValueSet Atrioventricular_Block() => 
		__Atrioventricular_Block.Value;

	private CqlValueSet Beta_Blocker_Therapy_for_LVSD_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", default);

    [CqlDeclaration("Beta Blocker Therapy for LVSD")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184")]
	public CqlValueSet Beta_Blocker_Therapy_for_LVSD() => 
		__Beta_Blocker_Therapy_for_LVSD.Value;

	private CqlValueSet Beta_Blocker_Therapy_Ingredient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", default);

    [CqlDeclaration("Beta Blocker Therapy Ingredient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493")]
	public CqlValueSet Beta_Blocker_Therapy_Ingredient() => 
		__Beta_Blocker_Therapy_Ingredient.Value;

	private CqlValueSet Bradycardia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", default);

    [CqlDeclaration("Bradycardia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412")]
	public CqlValueSet Bradycardia() => 
		__Bradycardia.Value;

	private CqlValueSet Cardiac_Pacer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", default);

    [CqlDeclaration("Cardiac Pacer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53")]
	public CqlValueSet Cardiac_Pacer() => 
		__Cardiac_Pacer.Value;

	private CqlValueSet Cardiac_Pacer_in_Situ_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", default);

    [CqlDeclaration("Cardiac Pacer in Situ")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368")]
	public CqlValueSet Cardiac_Pacer_in_Situ() => 
		__Cardiac_Pacer_in_Situ.Value;

	private CqlValueSet Hypotension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", default);

    [CqlDeclaration("Hypotension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370")]
	public CqlValueSet Hypotension() => 
		__Hypotension.Value;

	private CqlValueSet Intolerance_to_Beta_Blocker_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", default);

    [CqlDeclaration("Intolerance to Beta Blocker Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178")]
	public CqlValueSet Intolerance_to_Beta_Blocker_Therapy() => 
		__Intolerance_to_Beta_Blocker_Therapy.Value;

	private CqlValueSet Left_Ventricular_Assist_Device_Placement_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", default);

    [CqlDeclaration("Left Ventricular Assist Device Placement")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61")]
	public CqlValueSet Left_Ventricular_Assist_Device_Placement() => 
		__Left_Ventricular_Assist_Device_Placement.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Patient_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", default);

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason() => 
		__Patient_Reason.Value;

	private CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance__Value() => 
		new CqlCode("373254001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Substance with beta adrenergic receptor antagonist mechanism of action (substance)")]
	public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_() => 
		__Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("373254001", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HFBetaBlockerTherapyforLVSDFHIR-1.3.000", "Measurement Period", c_);

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

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
		IEnumerable<Encounter> j_ = AHAOverall_2_6_000.Qualifying_Outpatient_Encounter_During_Measurement_Period();
		int? k_ = context.Operators.Count<Encounter>(j_);
		bool? l_ = context.Operators.GreaterOrEqual(k_, 2);
		bool? m_ = context.Operators.And(i_, l_);
		IEnumerable<Encounter> n_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter();
		bool? o_ = context.Operators.Exists<Encounter>(n_);
		bool? p_ = context.Operators.And(m_, o_);

		return p_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();
		IEnumerable<Encounter> b_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		bool? c_ = context.Operators.Exists<Encounter>(b_);
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = AHAOverall_2_6_000.Has_Heart_Transplant();
		bool? b_ = AHAOverall_2_6_000.Has_Heart_Transplant_Complications();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = AHAOverall_2_6_000.Has_Left_Ventricular_Assist_Device();
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = AHAOverall_2_6_000.Has_Left_Ventricular_Assist_Device_Complications();
		bool? g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Value()
	{
		CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest BetaBlockerOrdered)
		{
			bool? i_ = AHAOverall_2_6_000.isOrderedDuringHeartFailureOutpatientEncounter(BetaBlockerOrdered);
			Code<MedicationRequest.MedicationrequestStatus> j_ = BetaBlockerOrdered?.StatusElement;
			MedicationRequest.MedicationrequestStatus? k_ = j_?.Value;
			string l_ = context.Operators.Convert<string>(k_);
			string[] m_ = [
				"active",
				"completed",
			];
			bool? n_ = context.Operators.In<string>(l_, m_ as IEnumerable<string>);
			bool? o_ = context.Operators.And(i_, n_);
			Code<MedicationRequest.MedicationRequestIntent> p_ = BetaBlockerOrdered?.IntentElement;
			MedicationRequest.MedicationRequestIntent? q_ = p_?.Value;
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(o_, t_);

			return u_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
		bool? h_ = context.Operators.Exists<MedicationRequest>(g_);

		return h_;
	}

    [CqlDeclaration("Has Beta Blocker Therapy for LVSD Ordered")]
	public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered() => 
		__Has_Beta_Blocker_Therapy_for_LVSD_Ordered.Value;

	private bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Value()
	{
		CqlValueSet a_ = this.Beta_Blocker_Therapy_for_LVSD();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest ActiveBetaBlocker)
		{
			bool? i_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter(ActiveBetaBlocker as object);

			return i_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
		bool? h_ = context.Operators.Exists<MedicationRequest>(g_);

		return h_;
	}

    [CqlDeclaration("Is Currently Taking Beta Blocker Therapy for LVSD")]
	public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD() => 
		__Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered();
		bool? b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD();
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Has_Consecutive_Heart_Rates_Less_than_50_Value()
	{
		IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
		IEnumerable<Encounter> b_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		IEnumerable<ValueTuple<Observation, Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);
		(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? d_(ValueTuple<Observation, Encounter> _valueTuple)
		{
			(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, (Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(c_, d_);
		bool? f_((Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf)
		{
			Period l_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			DataType n_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.toInterval(o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, default);
			Code<ObservationStatus> r_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.StatusElement;
			ObservationStatus? s_ = r_?.Value;
			string t_ = context.Operators.Convert<string>(s_);
			string[] u_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? v_ = context.Operators.In<string>(t_, u_ as IEnumerable<string>);
			bool? w_ = context.Operators.And(q_, v_);
			DataType x_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Value;
			CqlQuantity y_ = FHIRHelpers_4_3_000.ToQuantity(x_ as Quantity);
			CqlQuantity z_ = context.Operators.Quantity(50m, "/min");
			bool? aa_ = context.Operators.Less(y_, z_);
			bool? ab_ = context.Operators.And(w_, aa_);
			IEnumerable<Observation> ac_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
			bool? ad_(Observation MostRecentPriorHeartRate)
			{
				Period an_ = tuple_fufpmqdratbglhghdwfuubanf?.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_3_000.ToInterval(an_);
				DataType ap_ = MostRecentPriorHeartRate?.Effective;
				object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
				CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_0_000.toInterval(aq_);
				bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, default);
				object au_ = FHIRHelpers_4_3_000.ToValue(ap_);
				CqlInterval<CqlDateTime> av_ = QICoreCommon_2_0_000.toInterval(au_);
				DataType aw_ = tuple_fufpmqdratbglhghdwfuubanf?.HeartRate?.Effective;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				CqlInterval<CqlDateTime> ay_ = QICoreCommon_2_0_000.toInterval(ax_);
				bool? az_ = context.Operators.Before(av_, ay_, default);
				bool? ba_ = context.Operators.And(as_, az_);

				return ba_;
			};
			IEnumerable<Observation> ae_ = context.Operators.Where<Observation>(ac_, ad_);
			object af_(Observation @this)
			{
				DataType bb_ = @this?.Effective;
				object bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
				CqlInterval<CqlDateTime> bd_ = QICoreCommon_2_0_000.toInterval(bc_);
				CqlDateTime be_ = context.Operators.Start(bd_);

				return be_;
			};
			IEnumerable<Observation> ag_ = context.Operators.SortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ah_ = context.Operators.Last<Observation>(ag_);
			DataType ai_ = ah_?.Value;
			CqlQuantity aj_ = FHIRHelpers_4_3_000.ToQuantity(ai_ as Quantity);
			bool? al_ = context.Operators.Less(aj_, z_);
			bool? am_ = context.Operators.And(ab_, al_);

			return am_;
		};
		IEnumerable<(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?> g_ = context.Operators.Where<(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?>(e_, f_);
		Observation h_((Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)? tuple_fufpmqdratbglhghdwfuubanf) => 
			tuple_fufpmqdratbglhghdwfuubanf?.HeartRate;
		IEnumerable<Observation> i_ = context.Operators.Select<(Observation HeartRate, Encounter ModerateOrSevereLVSDHFOutpatientEncounter)?, Observation>(g_, h_);
		bool? j_ = context.Operators.Exists<Observation>(i_);

		return j_;
	}

    [CqlDeclaration("Has Consecutive Heart Rates Less than 50")]
	public bool? Has_Consecutive_Heart_Rates_Less_than_50() => 
		__Has_Consecutive_Heart_Rates_Less_than_50.Value;

	private bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Value()
	{
		IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
		IEnumerable<MedicationRequest> b_(MedicationRequest NoBetaBlockerOrdered)
		{
			IEnumerable<Encounter> g_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? h_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				FhirDateTime l_ = NoBetaBlockerOrdered?.AuthoredOnElement;
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
				Period n_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, default);

				return p_;
			};
			IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
			MedicationRequest j_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				NoBetaBlockerOrdered;
			IEnumerable<MedicationRequest> k_ = context.Operators.Select<Encounter, MedicationRequest>(i_, j_);

			return k_;
		};
		IEnumerable<MedicationRequest> c_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(a_, b_);
		bool? d_(MedicationRequest NoBetaBlockerOrdered)
		{
			DataType q_ = NoBetaBlockerOrdered?.Medication;
			CqlConcept r_ = FHIRHelpers_4_3_000.ToConcept(q_ as CodeableConcept);
			CqlValueSet s_ = this.Beta_Blocker_Therapy_for_LVSD();
			bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
			List<CodeableConcept> u_ = NoBetaBlockerOrdered?.ReasonCode;
			CqlConcept v_(CodeableConcept @this)
			{
				CqlConcept ag_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ag_;
			};
			IEnumerable<CqlConcept> w_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)u_, v_);
			CqlValueSet x_ = this.Medical_Reason();
			bool? y_ = context.Operators.ConceptsInValueSet(w_, x_);
			CqlConcept aa_(CodeableConcept @this)
			{
				CqlConcept ah_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ah_;
			};
			IEnumerable<CqlConcept> ab_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)u_, aa_);
			CqlValueSet ac_ = this.Patient_Reason();
			bool? ad_ = context.Operators.ConceptsInValueSet(ab_, ac_);
			bool? ae_ = context.Operators.Or(y_, ad_);
			bool? af_ = context.Operators.And(t_, ae_);

			return af_;
		};
		IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
		bool? f_ = context.Operators.Exists<MedicationRequest>(e_);

		return f_;
	}

    [CqlDeclaration("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
	public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD() => 
		__Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD.Value;

	private bool? Has_Arrhythmia_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Arrhythmia();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition Arrhythmia)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Arrhythmia);
			bool? g_ = QICoreCommon_2_0_000.isActive(Arrhythmia);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = Arrhythmia?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			CqlCode k_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Arrhythmia Diagnosis")]
	public bool? Has_Arrhythmia_Diagnosis() => 
		__Has_Arrhythmia_Diagnosis.Value;

	private bool? Has_Hypotension_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Hypotension();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition Hypotension)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Hypotension);
			bool? g_ = QICoreCommon_2_0_000.isActive(Hypotension);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = Hypotension?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			CqlCode k_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Hypotension Diagnosis")]
	public bool? Has_Hypotension_Diagnosis() => 
		__Has_Hypotension_Diagnosis.Value;

	private bool? Has_Asthma_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Asthma();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition Asthma)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Asthma);
			bool? g_ = QICoreCommon_2_0_000.isActive(Asthma);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = Asthma?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			CqlCode k_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Asthma Diagnosis")]
	public bool? Has_Asthma_Diagnosis() => 
		__Has_Asthma_Diagnosis.Value;

	private bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Value()
	{
		CqlValueSet a_ = this.Allergy_to_Beta_Blocker_Therapy();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet c_ = this.Intolerance_to_Beta_Blocker_Therapy();
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		bool? f_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis)
		{
			bool? i_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter(BetaBlockerAllergyOrIntoleranceDiagnosis as object);
			bool? j_ = QICoreCommon_2_0_000.isActive(BetaBlockerAllergyOrIntoleranceDiagnosis);
			bool? k_ = context.Operators.And(i_, j_);
			CodeableConcept l_ = BetaBlockerAllergyOrIntoleranceDiagnosis?.VerificationStatus;
			CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			CqlCode n_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
			bool? p_ = context.Operators.Equivalent(m_, o_);
			bool? q_ = context.Operators.And(k_, p_);

			return q_;
		};
		IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
		bool? h_ = context.Operators.Exists<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
	public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy() => 
		__Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy.Value;

	private bool? Has_Bradycardia_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Bradycardia();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition Bradycardia)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Bradycardia);
			bool? g_ = QICoreCommon_2_0_000.isActive(Bradycardia);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = Bradycardia?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			CqlCode k_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Bradycardia Diagnosis")]
	public bool? Has_Bradycardia_Diagnosis() => 
		__Has_Bradycardia_Diagnosis.Value;

	private bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_Value()
	{
		CqlValueSet a_ = this.Beta_Blocker_Therapy_Ingredient();
		IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
		CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_();
		IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
		IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
		IEnumerable<AllergyIntolerance> f_ = context.Operators.Union<AllergyIntolerance>(b_, e_);
		bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance)
		{
			bool? j_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter(BetaBlockerAllergyIntolerance as object);
			CodeableConcept k_ = BetaBlockerAllergyIntolerance?.ClinicalStatus;
			CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlConcept n_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlCode o_ = QICoreCommon_2_0_000.allergy_active();
			CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
			bool? q_ = context.Operators.Equivalent(n_, p_);
			bool? r_ = context.Operators.Or((bool?)(l_ is null), q_);
			bool? s_ = context.Operators.And(j_, r_);

			return s_;
		};
		IEnumerable<AllergyIntolerance> h_ = context.Operators.Where<AllergyIntolerance>(f_, g_);
		bool? i_ = context.Operators.Exists<AllergyIntolerance>(h_);

		return i_;
	}

    [CqlDeclaration("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
	public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient() => 
		__Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient.Value;

	private bool? Has_Atrioventricular_Block_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Atrioventricular_Block();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition AtrioventricularBlock)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(AtrioventricularBlock);
			bool? g_ = QICoreCommon_2_0_000.isActive(AtrioventricularBlock);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = AtrioventricularBlock?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			CqlCode k_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Atrioventricular Block Diagnosis")]
	public bool? Has_Atrioventricular_Block_Diagnosis() => 
		__Has_Atrioventricular_Block_Diagnosis.Value;

	private bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_Value()
	{
		CqlValueSet a_ = this.Cardiac_Pacer_in_Situ();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition CardiacPacerDiagnosis)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter(CardiacPacerDiagnosis as object);
			bool? g_ = QICoreCommon_2_0_000.isActive(CardiacPacerDiagnosis);
			bool? h_ = context.Operators.And(f_, g_);
			CodeableConcept i_ = CardiacPacerDiagnosis?.VerificationStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			CqlCode k_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Diagnosis of Cardiac Pacer in Situ")]
	public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ() => 
		__Has_Diagnosis_of_Cardiac_Pacer_in_Situ.Value;

	private bool? Has_Cardiac_Pacer_Device_Implanted_Value()
	{
		CqlValueSet a_ = this.Cardiac_Pacer();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_(Procedure ImplantedCardiacPacer)
		{
			IEnumerable<Encounter> h_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				DataType m_ = ImplantedCardiacPacer?.Performed;
				object n_ = FHIRHelpers_4_3_000.ToValue(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.toInterval(n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				Period q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				CqlDateTime s_ = context.Operators.End(r_);
				bool? t_ = context.Operators.Before(p_, s_, default);

				return t_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				ImplantedCardiacPacer;
			IEnumerable<Procedure> l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

			return l_;
		};
		IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure ImplantedCardiacPacer)
		{
			Code<EventStatus> u_ = ImplantedCardiacPacer?.StatusElement;
			EventStatus? v_ = u_?.Value;
			string w_ = context.Operators.Convert<string>(v_);
			bool? x_ = context.Operators.Equal(w_, "completed");

			return x_;
		};
		IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
		bool? g_ = context.Operators.Exists<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("Has Cardiac Pacer Device Implanted")]
	public bool? Has_Cardiac_Pacer_Device_Implanted() => 
		__Has_Cardiac_Pacer_Device_Implanted.Value;

	private bool? Atrioventricular_Block_without_Cardiac_Pacer_Value()
	{
		bool? a_ = this.Has_Atrioventricular_Block_Diagnosis();
		bool? b_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ();
		bool? c_ = context.Operators.Not(b_);
		bool? d_ = context.Operators.And(a_, c_);
		bool? e_ = this.Has_Cardiac_Pacer_Device_Implanted();
		bool? f_ = context.Operators.Not(e_);
		bool? g_ = context.Operators.And(d_, f_);

		return g_;
	}

    [CqlDeclaration("Atrioventricular Block without Cardiac Pacer")]
	public bool? Atrioventricular_Block_without_Cardiac_Pacer() => 
		__Atrioventricular_Block_without_Cardiac_Pacer.Value;

	private bool? Denominator_Exceptions_Value()
	{
		bool? a_ = this.Has_Consecutive_Heart_Rates_Less_than_50();
		bool? b_ = this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Arrhythmia_Diagnosis();
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = this.Has_Hypotension_Diagnosis();
		bool? g_ = context.Operators.Or(e_, f_);
		bool? h_ = this.Has_Asthma_Diagnosis();
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy();
		bool? k_ = context.Operators.Or(i_, j_);
		bool? l_ = this.Has_Bradycardia_Diagnosis();
		bool? m_ = context.Operators.Or(k_, l_);
		bool? n_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient();
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = this.Atrioventricular_Block_without_Cardiac_Pacer();
		bool? q_ = context.Operators.Or(o_, p_);

		return q_;
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

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

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

}
