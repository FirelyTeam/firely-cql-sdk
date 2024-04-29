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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public AHAOverall_2_6_000 AHAOverall_2_6_000 { get; }

    #endregion

	private CqlValueSet Allergy_to_Beta_Blocker_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177", null);

    [CqlDeclaration("Allergy to Beta Blocker Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177")]
	public CqlValueSet Allergy_to_Beta_Blocker_Therapy() => 
		__Allergy_to_Beta_Blocker_Therapy.Value;

	private CqlValueSet Arrhythmia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366", null);

    [CqlDeclaration("Arrhythmia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366")]
	public CqlValueSet Arrhythmia() => 
		__Arrhythmia.Value;

	private CqlValueSet Asthma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362", null);

    [CqlDeclaration("Asthma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362")]
	public CqlValueSet Asthma() => 
		__Asthma.Value;

	private CqlValueSet Atrioventricular_Block_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367", null);

    [CqlDeclaration("Atrioventricular Block")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367")]
	public CqlValueSet Atrioventricular_Block() => 
		__Atrioventricular_Block.Value;

	private CqlValueSet Beta_Blocker_Therapy_for_LVSD_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184", null);

    [CqlDeclaration("Beta Blocker Therapy for LVSD")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184")]
	public CqlValueSet Beta_Blocker_Therapy_for_LVSD() => 
		__Beta_Blocker_Therapy_for_LVSD.Value;

	private CqlValueSet Beta_Blocker_Therapy_Ingredient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493", null);

    [CqlDeclaration("Beta Blocker Therapy Ingredient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493")]
	public CqlValueSet Beta_Blocker_Therapy_Ingredient() => 
		__Beta_Blocker_Therapy_Ingredient.Value;

	private CqlValueSet Bradycardia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412", null);

    [CqlDeclaration("Bradycardia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412")]
	public CqlValueSet Bradycardia() => 
		__Bradycardia.Value;

	private CqlValueSet Cardiac_Pacer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53", null);

    [CqlDeclaration("Cardiac Pacer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53")]
	public CqlValueSet Cardiac_Pacer() => 
		__Cardiac_Pacer.Value;

	private CqlValueSet Cardiac_Pacer_in_Situ_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368", null);

    [CqlDeclaration("Cardiac Pacer in Situ")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368")]
	public CqlValueSet Cardiac_Pacer_in_Situ() => 
		__Cardiac_Pacer_in_Situ.Value;

	private CqlValueSet Hypotension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370", null);

    [CqlDeclaration("Hypotension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370")]
	public CqlValueSet Hypotension() => 
		__Hypotension.Value;

	private CqlValueSet Intolerance_to_Beta_Blocker_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178", null);

    [CqlDeclaration("Intolerance to Beta Blocker Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178")]
	public CqlValueSet Intolerance_to_Beta_Blocker_Therapy() => 
		__Intolerance_to_Beta_Blocker_Therapy.Value;

	private CqlValueSet Left_Ventricular_Assist_Device_Placement_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", null);

    [CqlDeclaration("Left Ventricular Assist Device Placement")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61")]
	public CqlValueSet Left_Ventricular_Assist_Device_Placement() => 
		__Left_Ventricular_Assist_Device_Placement.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Patient_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason() => 
		__Patient_Reason.Value;

	private CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance__Value() => 
		new CqlCode("373254001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Substance with beta adrenergic receptor antagonist mechanism of action (substance)")]
	public CqlCode Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_() => 
		__Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("373254001", "http://snomed.info/sct", null, null),
		};

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 18);
		IEnumerable<Encounter> h_ = AHAOverall_2_6_000.Qualifying_Outpatient_Encounter_During_Measurement_Period();
		int? i_ = context.Operators.Count<Encounter>(h_);
		bool? j_ = context.Operators.GreaterOrEqual(i_, 2);
		bool? k_ = context.Operators.And(g_, j_);
		IEnumerable<Encounter> l_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter();
		bool? m_ = context.Operators.Exists<Encounter>(l_);
		bool? n_ = context.Operators.And(k_, m_);

		return n_;
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
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest BetaBlockerOrdered)
		{
			bool? i_ = AHAOverall_2_6_000.isOrderedDuringHeartFailureOutpatientEncounter(BetaBlockerOrdered);
			string j_ = context.Operators.Convert<string>(BetaBlockerOrdered?.StatusElement?.Value);
			string[] k_ = new string[]
			{
				"active",
				"completed",
			};
			bool? l_ = context.Operators.In<string>(j_, (k_ as IEnumerable<string>));
			bool? m_ = context.Operators.And(i_, l_);
			string n_ = context.Operators.Convert<string>(BetaBlockerOrdered?.IntentElement?.Value);
			string[] o_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			bool? p_ = context.Operators.In<string>(n_, (o_ as IEnumerable<string>));
			bool? q_ = context.Operators.And(m_, p_);

			return q_;
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
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest ActiveBetaBlocker)
		{
			bool? i_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter((ActiveBetaBlocker as object));

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
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		IEnumerable<Encounter> b_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		IEnumerable<ValueTuple<Observation,Encounter>> c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);
		Tuple_FgYDjIJBhiXdBHJjiISjVeOjV d_(ValueTuple<Observation,Encounter> _valueTuple)
		{
			Tuple_FgYDjIJBhiXdBHJjiISjVeOjV k_ = new Tuple_FgYDjIJBhiXdBHJjiISjVeOjV
			{
				HeartRate = _valueTuple.Item1,
				ModerateOrSevereLVSDHFOutpatientEncounter = _valueTuple.Item2,
			};

			return k_;
		};
		IEnumerable<Tuple_FgYDjIJBhiXdBHJjiISjVeOjV> e_ = context.Operators.Select<ValueTuple<Observation,Encounter>, Tuple_FgYDjIJBhiXdBHJjiISjVeOjV>(c_, d_);
		bool? f_(Tuple_FgYDjIJBhiXdBHJjiISjVeOjV tuple_fgydjijbhixdbhjjiisjveojv)
		{
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(tuple_fgydjijbhixdbhjjiisjveojv.ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
			object m_ = FHIRHelpers_4_3_000.ToValue(tuple_fgydjijbhixdbhjjiisjveojv.HeartRate?.Effective);
			CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(m_);
			bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, null);
			string p_ = context.Operators.Convert<string>(tuple_fgydjijbhixdbhjjiisjveojv.HeartRate?.StatusElement?.Value);
			string[] q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? r_ = context.Operators.In<string>(p_, (q_ as IEnumerable<string>));
			bool? s_ = context.Operators.And(o_, r_);
			Quantity t_ = context.Operators.Convert<Quantity>(tuple_fgydjijbhixdbhjjiisjveojv.HeartRate?.Value);
			CqlQuantity u_ = FHIRHelpers_4_3_000.ToQuantity(t_);
			CqlQuantity v_ = context.Operators.Quantity(50m, "/min");
			bool? w_ = context.Operators.Less(u_, v_);
			bool? x_ = context.Operators.And(s_, w_);
			IEnumerable<Observation> y_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? z_(Observation MostRecentPriorHeartRate)
			{
				CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(tuple_fgydjijbhixdbhjjiisjveojv.ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				object ak_ = FHIRHelpers_4_3_000.ToValue(MostRecentPriorHeartRate?.Effective);
				CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.toInterval(ak_);
				bool? am_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aj_, al_, null);
				CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.toInterval(ak_);
				object ap_ = FHIRHelpers_4_3_000.ToValue(tuple_fgydjijbhixdbhjjiisjveojv.HeartRate?.Effective);
				CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.toInterval(ap_);
				bool? ar_ = context.Operators.Before(ao_, aq_, null);
				bool? as_ = context.Operators.And(am_, ar_);

				return as_;
			};
			IEnumerable<Observation> aa_ = context.Operators.Where<Observation>(y_, z_);
			object ab_(Observation @this)
			{
				object at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> au_ = QICoreCommon_2_0_000.toInterval(at_);
				CqlDateTime av_ = context.Operators.Start(au_);

				return av_;
			};
			IEnumerable<Observation> ac_ = context.Operators.SortBy<Observation>(aa_, ab_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ad_ = context.Operators.Last<Observation>(ac_);
			Quantity ae_ = context.Operators.Convert<Quantity>(ad_?.Value);
			CqlQuantity af_ = FHIRHelpers_4_3_000.ToQuantity(ae_);
			bool? ah_ = context.Operators.Less(af_, v_);
			bool? ai_ = context.Operators.And(x_, ah_);

			return ai_;
		};
		IEnumerable<Tuple_FgYDjIJBhiXdBHJjiISjVeOjV> g_ = context.Operators.Where<Tuple_FgYDjIJBhiXdBHJjiISjVeOjV>(e_, f_);
		Observation h_(Tuple_FgYDjIJBhiXdBHJjiISjVeOjV tuple_fgydjijbhixdbhjjiisjveojv) => 
			tuple_fgydjijbhixdbhjjiisjveojv.HeartRate;
		IEnumerable<Observation> i_ = context.Operators.Select<Tuple_FgYDjIJBhiXdBHJjiISjVeOjV, Observation>(g_, h_);
		bool? j_ = context.Operators.Exists<Observation>(i_);

		return j_;
	}

    [CqlDeclaration("Has Consecutive Heart Rates Less than 50")]
	public bool? Has_Consecutive_Heart_Rates_Less_than_50() => 
		__Has_Consecutive_Heart_Rates_Less_than_50.Value;

	private bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Value()
	{
		IEnumerable<MedicationRequest> a_ = context.Operators.RetrieveByValueSet<MedicationRequest>(null, null);
		IEnumerable<MedicationRequest> b_(MedicationRequest NoBetaBlockerOrdered)
		{
			IEnumerable<Encounter> g_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? h_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(NoBetaBlockerOrdered?.AuthoredOnElement);
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, null);

				return n_;
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
			CodeableConcept o_ = context.Operators.Convert<CodeableConcept>(NoBetaBlockerOrdered?.Medication);
			CqlConcept p_ = FHIRHelpers_4_3_000.ToConcept(o_);
			CqlValueSet q_ = this.Beta_Blocker_Therapy_for_LVSD();
			bool? r_ = context.Operators.ConceptInValueSet(p_, q_);
			CqlConcept s_(CodeableConcept @this)
			{
				CqlConcept ac_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ac_;
			};
			IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>(NoBetaBlockerOrdered?.ReasonCode, s_);
			CqlValueSet u_ = this.Medical_Reason();
			bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
			CqlConcept w_(CodeableConcept @this)
			{
				CqlConcept ad_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ad_;
			};
			IEnumerable<CqlConcept> x_ = context.Operators.Select<CodeableConcept, CqlConcept>(NoBetaBlockerOrdered?.ReasonCode, w_);
			CqlValueSet y_ = this.Patient_Reason();
			bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
			bool? aa_ = context.Operators.Or(v_, z_);
			bool? ab_ = context.Operators.And(r_, aa_);

			return ab_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Arrhythmia)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Arrhythmia);
			bool? g_ = QICoreCommon_2_0_000.isActive(Arrhythmia);
			bool? h_ = context.Operators.And(f_, g_);
			CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(Arrhythmia?.VerificationStatus);
			CqlCode j_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
			bool? l_ = context.Operators.Equivalent(i_, k_);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Hypotension)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Hypotension);
			bool? g_ = QICoreCommon_2_0_000.isActive(Hypotension);
			bool? h_ = context.Operators.And(f_, g_);
			CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(Hypotension?.VerificationStatus);
			CqlCode j_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
			bool? l_ = context.Operators.Equivalent(i_, k_);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Asthma)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Asthma);
			bool? g_ = QICoreCommon_2_0_000.isActive(Asthma);
			bool? h_ = context.Operators.And(f_, g_);
			CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(Asthma?.VerificationStatus);
			CqlCode j_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
			bool? l_ = context.Operators.Equivalent(i_, k_);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		CqlValueSet c_ = this.Intolerance_to_Beta_Blocker_Therapy();
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		IEnumerable<Condition> e_ = context.Operators.ListUnion<Condition>(b_, d_);
		bool? f_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis)
		{
			bool? i_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter((BetaBlockerAllergyOrIntoleranceDiagnosis as object));
			bool? j_ = QICoreCommon_2_0_000.isActive(BetaBlockerAllergyOrIntoleranceDiagnosis);
			bool? k_ = context.Operators.And(i_, j_);
			CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(BetaBlockerAllergyOrIntoleranceDiagnosis?.VerificationStatus);
			CqlCode m_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
			bool? o_ = context.Operators.Equivalent(l_, n_);
			bool? p_ = context.Operators.And(k_, o_);

			return p_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Bradycardia)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Bradycardia);
			bool? g_ = QICoreCommon_2_0_000.isActive(Bradycardia);
			bool? h_ = context.Operators.And(f_, g_);
			CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(Bradycardia?.VerificationStatus);
			CqlCode j_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
			bool? l_ = context.Operators.Equivalent(i_, k_);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
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
		IEnumerable<AllergyIntolerance> b_ = context.Operators.RetrieveByValueSet<AllergyIntolerance>(a_, null);
		CqlCode c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_();
		IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
		IEnumerable<AllergyIntolerance> e_ = context.Operators.RetrieveByCodes<AllergyIntolerance>(d_, null);
		IEnumerable<AllergyIntolerance> f_ = context.Operators.ListUnion<AllergyIntolerance>(b_, e_);
		bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance)
		{
			bool? j_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter((BetaBlockerAllergyIntolerance as object));
			CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(BetaBlockerAllergyIntolerance?.ClinicalStatus);
			CqlCode m_ = QICoreCommon_2_0_000.allergy_active();
			CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
			bool? o_ = context.Operators.Equivalent(k_, n_);
			bool? p_ = context.Operators.Or((bool?)(k_ is null), o_);
			bool? q_ = context.Operators.And(j_, p_);

			return q_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition AtrioventricularBlock)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(AtrioventricularBlock);
			bool? g_ = QICoreCommon_2_0_000.isActive(AtrioventricularBlock);
			bool? h_ = context.Operators.And(f_, g_);
			CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(AtrioventricularBlock?.VerificationStatus);
			CqlCode j_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
			bool? l_ = context.Operators.Equivalent(i_, k_);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition CardiacPacerDiagnosis)
		{
			bool? f_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter((CardiacPacerDiagnosis as object));
			bool? g_ = QICoreCommon_2_0_000.isActive(CardiacPacerDiagnosis);
			bool? h_ = context.Operators.And(f_, g_);
			CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(CardiacPacerDiagnosis?.VerificationStatus);
			CqlCode j_ = QICoreCommon_2_0_000.confirmed();
			CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
			bool? l_ = context.Operators.Equivalent(i_, k_);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
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
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_(Procedure ImplantedCardiacPacer)
		{
			IEnumerable<Encounter> h_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				object m_ = FHIRHelpers_4_3_000.ToValue(ImplantedCardiacPacer?.Performed);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(m_);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(ModerateOrSevereLVSDHFOutpatientEncounter?.Period);
				CqlDateTime q_ = context.Operators.End(p_);
				bool? r_ = context.Operators.Before(o_, q_, null);

				return r_;
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
			string s_ = context.Operators.Convert<string>(ImplantedCardiacPacer?.StatusElement?.Value);
			bool? t_ = context.Operators.Equal(s_, "completed");

			return t_;
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

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
