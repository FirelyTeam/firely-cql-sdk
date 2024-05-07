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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("HFBetaBlockerTherapyforLVSDFHIR-1.3.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, 18);
		var h_ = AHAOverall_2_6_000.Qualifying_Outpatient_Encounter_During_Measurement_Period();
		var i_ = context.Operators.Count<Encounter>(h_);
		var j_ = context.Operators.GreaterOrEqual(i_, 2);
		var k_ = context.Operators.And(g_, j_);
		var l_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter();
		var m_ = context.Operators.Exists<Encounter>(l_);
		var n_ = context.Operators.And(k_, m_);

		return n_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();
		var b_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		var c_ = context.Operators.Exists<Encounter>(b_);
		var d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = AHAOverall_2_6_000.Has_Heart_Transplant();
		var b_ = AHAOverall_2_6_000.Has_Heart_Transplant_Complications();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = AHAOverall_2_6_000.Has_Left_Ventricular_Assist_Device();
		var e_ = context.Operators.Or(c_, d_);
		var f_ = AHAOverall_2_6_000.Has_Left_Ventricular_Assist_Device_Complications();
		var g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered_Value()
	{
		var a_ = this.Beta_Blocker_Therapy_for_LVSD();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest BetaBlockerOrdered)
		{
			var i_ = AHAOverall_2_6_000.isOrderedDuringHeartFailureOutpatientEncounter(BetaBlockerOrdered);
			var j_ = BetaBlockerOrdered?.StatusElement;
			var k_ = j_?.Value;
			var l_ = context.Operators.Convert<string>(k_);
			var m_ = new string[]
			{
				"active",
				"completed",
			};
			var n_ = context.Operators.In<string>(l_, (m_ as IEnumerable<string>));
			var o_ = context.Operators.And(i_, n_);
			var p_ = BetaBlockerOrdered?.IntentElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<string>(q_);
			var s_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			var t_ = context.Operators.In<string>(r_, (s_ as IEnumerable<string>));
			var u_ = context.Operators.And(o_, t_);

			return u_;
		};
		var g_ = context.Operators.Where<MedicationRequest>(e_, f_);
		var h_ = context.Operators.Exists<MedicationRequest>(g_);

		return h_;
	}

    [CqlDeclaration("Has Beta Blocker Therapy for LVSD Ordered")]
	public bool? Has_Beta_Blocker_Therapy_for_LVSD_Ordered() => 
		__Has_Beta_Blocker_Therapy_for_LVSD_Ordered.Value;

	private bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD_Value()
	{
		var a_ = this.Beta_Blocker_Therapy_for_LVSD();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest ActiveBetaBlocker)
		{
			var i_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter((ActiveBetaBlocker as object));

			return i_;
		};
		var g_ = context.Operators.Where<MedicationRequest>(e_, f_);
		var h_ = context.Operators.Exists<MedicationRequest>(g_);

		return h_;
	}

    [CqlDeclaration("Is Currently Taking Beta Blocker Therapy for LVSD")]
	public bool? Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD() => 
		__Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Has_Beta_Blocker_Therapy_for_LVSD_Ordered();
		var b_ = this.Is_Currently_Taking_Beta_Blocker_Therapy_for_LVSD();
		var c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Has_Consecutive_Heart_Rates_Less_than_50_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		var b_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
		var c_ = context.Operators.CrossJoin<Observation, Encounter>(a_, b_);
		Tuple_FUFPMQdRaTBgLhghDWfUUBaNF d_(ValueTuple<Observation, Encounter> _valueTuple)
		{
			var k_ = new Tuple_FUFPMQdRaTBgLhghDWfUUBaNF
			{
				HeartRate = _valueTuple.Item1,
				ModerateOrSevereLVSDHFOutpatientEncounter = _valueTuple.Item2,
			};

			return k_;
		};
		var e_ = context.Operators.Select<ValueTuple<Observation, Encounter>, Tuple_FUFPMQdRaTBgLhghDWfUUBaNF>(c_, d_);
		bool? f_(Tuple_FUFPMQdRaTBgLhghDWfUUBaNF tuple_fufpmqdratbglhghdwfuubanf)
		{
			var l_ = tuple_fufpmqdratbglhghdwfuubanf.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = tuple_fufpmqdratbglhghdwfuubanf.HeartRate?.Effective;
			var o_ = FHIRHelpers_4_3_000.ToValue(n_);
			var p_ = QICoreCommon_2_0_000.toInterval(o_);
			var q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, null);
			var r_ = tuple_fufpmqdratbglhghdwfuubanf.HeartRate?.StatusElement;
			var s_ = r_?.Value;
			var t_ = context.Operators.Convert<string>(s_);
			var u_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var v_ = context.Operators.In<string>(t_, (u_ as IEnumerable<string>));
			var w_ = context.Operators.And(q_, v_);
			var x_ = tuple_fufpmqdratbglhghdwfuubanf.HeartRate?.Value;
			var y_ = context.Operators.Convert<Quantity>(x_);
			var z_ = FHIRHelpers_4_3_000.ToQuantity(y_);
			var aa_ = context.Operators.Quantity(50m, "/min");
			var ab_ = context.Operators.Less(z_, aa_);
			var ac_ = context.Operators.And(w_, ab_);
			var ad_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? ae_(Observation MostRecentPriorHeartRate)
			{
				var ap_ = tuple_fufpmqdratbglhghdwfuubanf.ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				var aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				var ar_ = MostRecentPriorHeartRate?.Effective;
				var as_ = FHIRHelpers_4_3_000.ToValue(ar_);
				var at_ = QICoreCommon_2_0_000.toInterval(as_);
				var au_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aq_, at_, null);
				var aw_ = FHIRHelpers_4_3_000.ToValue(ar_);
				var ax_ = QICoreCommon_2_0_000.toInterval(aw_);
				var ay_ = tuple_fufpmqdratbglhghdwfuubanf.HeartRate?.Effective;
				var az_ = FHIRHelpers_4_3_000.ToValue(ay_);
				var ba_ = QICoreCommon_2_0_000.toInterval(az_);
				var bb_ = context.Operators.Before(ax_, ba_, null);
				var bc_ = context.Operators.And(au_, bb_);

				return bc_;
			};
			var af_ = context.Operators.Where<Observation>(ad_, ae_);
			object ag_(Observation @this)
			{
				var bd_ = @this?.Effective;
				var be_ = FHIRHelpers_4_3_000.ToValue(bd_);
				var bf_ = QICoreCommon_2_0_000.toInterval(be_);
				var bg_ = context.Operators.Start(bf_);

				return bg_;
			};
			var ah_ = context.Operators.SortBy<Observation>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);
			var ai_ = context.Operators.Last<Observation>(ah_);
			var aj_ = ai_?.Value;
			var ak_ = context.Operators.Convert<Quantity>(aj_);
			var al_ = FHIRHelpers_4_3_000.ToQuantity(ak_);
			var an_ = context.Operators.Less(al_, aa_);
			var ao_ = context.Operators.And(ac_, an_);

			return ao_;
		};
		var g_ = context.Operators.Where<Tuple_FUFPMQdRaTBgLhghDWfUUBaNF>(e_, f_);
		Observation h_(Tuple_FUFPMQdRaTBgLhghDWfUUBaNF tuple_fufpmqdratbglhghdwfuubanf) => 
			tuple_fufpmqdratbglhghdwfuubanf.HeartRate;
		var i_ = context.Operators.Select<Tuple_FUFPMQdRaTBgLhghDWfUUBaNF, Observation>(g_, h_);
		var j_ = context.Operators.Exists<Observation>(i_);

		return j_;
	}

    [CqlDeclaration("Has Consecutive Heart Rates Less than 50")]
	public bool? Has_Consecutive_Heart_Rates_Less_than_50() => 
		__Has_Consecutive_Heart_Rates_Less_than_50.Value;

	private bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<MedicationRequest>(null, null);
		IEnumerable<MedicationRequest> b_(MedicationRequest NoBetaBlockerOrdered)
		{
			var g_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? h_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				var l_ = NoBetaBlockerOrdered?.AuthoredOnElement;
				var m_ = context.Operators.Convert<CqlDateTime>(l_);
				var n_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				var o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				var p_ = context.Operators.In<CqlDateTime>(m_, o_, null);

				return p_;
			};
			var i_ = context.Operators.Where<Encounter>(g_, h_);
			MedicationRequest j_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				NoBetaBlockerOrdered;
			var k_ = context.Operators.Select<Encounter, MedicationRequest>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(a_, b_);
		bool? d_(MedicationRequest NoBetaBlockerOrdered)
		{
			var q_ = NoBetaBlockerOrdered?.Medication;
			var r_ = context.Operators.Convert<CodeableConcept>(q_);
			var s_ = FHIRHelpers_4_3_000.ToConcept(r_);
			var t_ = this.Beta_Blocker_Therapy_for_LVSD();
			var u_ = context.Operators.ConceptInValueSet(s_, t_);
			var v_ = NoBetaBlockerOrdered?.ReasonCode;
			CqlConcept w_(CodeableConcept @this)
			{
				var ah_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ah_;
			};
			var x_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)v_, w_);
			var y_ = this.Medical_Reason();
			var z_ = context.Operators.ConceptsInValueSet(x_, y_);
			CqlConcept ab_(CodeableConcept @this)
			{
				var ai_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ai_;
			};
			var ac_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)v_, ab_);
			var ad_ = this.Patient_Reason();
			var ae_ = context.Operators.ConceptsInValueSet(ac_, ad_);
			var af_ = context.Operators.Or(z_, ae_);
			var ag_ = context.Operators.And(u_, af_);

			return ag_;
		};
		var e_ = context.Operators.Where<MedicationRequest>(c_, d_);
		var f_ = context.Operators.Exists<MedicationRequest>(e_);

		return f_;
	}

    [CqlDeclaration("Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD")]
	public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD() => 
		__Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD.Value;

	private bool? Has_Arrhythmia_Diagnosis_Value()
	{
		var a_ = this.Arrhythmia();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Arrhythmia)
		{
			var f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Arrhythmia);
			var g_ = QICoreCommon_2_0_000.isActive(Arrhythmia);
			var h_ = context.Operators.And(f_, g_);
			var i_ = Arrhythmia?.VerificationStatus;
			var j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			var k_ = QICoreCommon_2_0_000.confirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var n_ = context.Operators.And(h_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Arrhythmia Diagnosis")]
	public bool? Has_Arrhythmia_Diagnosis() => 
		__Has_Arrhythmia_Diagnosis.Value;

	private bool? Has_Hypotension_Diagnosis_Value()
	{
		var a_ = this.Hypotension();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Hypotension)
		{
			var f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Hypotension);
			var g_ = QICoreCommon_2_0_000.isActive(Hypotension);
			var h_ = context.Operators.And(f_, g_);
			var i_ = Hypotension?.VerificationStatus;
			var j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			var k_ = QICoreCommon_2_0_000.confirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var n_ = context.Operators.And(h_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Hypotension Diagnosis")]
	public bool? Has_Hypotension_Diagnosis() => 
		__Has_Hypotension_Diagnosis.Value;

	private bool? Has_Asthma_Diagnosis_Value()
	{
		var a_ = this.Asthma();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Asthma)
		{
			var f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Asthma);
			var g_ = QICoreCommon_2_0_000.isActive(Asthma);
			var h_ = context.Operators.And(f_, g_);
			var i_ = Asthma?.VerificationStatus;
			var j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			var k_ = QICoreCommon_2_0_000.confirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var n_ = context.Operators.And(h_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Asthma Diagnosis")]
	public bool? Has_Asthma_Diagnosis() => 
		__Has_Asthma_Diagnosis.Value;

	private bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Value()
	{
		var a_ = this.Allergy_to_Beta_Blocker_Therapy();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Intolerance_to_Beta_Blocker_Therapy();
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		var e_ = context.Operators.ListUnion<Condition>(b_, d_);
		bool? f_(Condition BetaBlockerAllergyOrIntoleranceDiagnosis)
		{
			var i_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter((BetaBlockerAllergyOrIntoleranceDiagnosis as object));
			var j_ = QICoreCommon_2_0_000.isActive(BetaBlockerAllergyOrIntoleranceDiagnosis);
			var k_ = context.Operators.And(i_, j_);
			var l_ = BetaBlockerAllergyOrIntoleranceDiagnosis?.VerificationStatus;
			var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
			var n_ = QICoreCommon_2_0_000.confirmed();
			var o_ = context.Operators.ConvertCodeToConcept(n_);
			var p_ = context.Operators.Equivalent(m_, o_);
			var q_ = context.Operators.And(k_, p_);

			return q_;
		};
		var g_ = context.Operators.Where<Condition>(e_, f_);
		var h_ = context.Operators.Exists<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy")]
	public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy() => 
		__Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy.Value;

	private bool? Has_Bradycardia_Diagnosis_Value()
	{
		var a_ = this.Bradycardia();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition Bradycardia)
		{
			var f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(Bradycardia);
			var g_ = QICoreCommon_2_0_000.isActive(Bradycardia);
			var h_ = context.Operators.And(f_, g_);
			var i_ = Bradycardia?.VerificationStatus;
			var j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			var k_ = QICoreCommon_2_0_000.confirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var n_ = context.Operators.And(h_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Bradycardia Diagnosis")]
	public bool? Has_Bradycardia_Diagnosis() => 
		__Has_Bradycardia_Diagnosis.Value;

	private bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient_Value()
	{
		var a_ = this.Beta_Blocker_Therapy_Ingredient();
		var b_ = context.Operators.RetrieveByValueSet<AllergyIntolerance>(a_, null);
		var c_ = this.Substance_with_beta_adrenergic_receptor_antagonist_mechanism_of_action__substance_();
		var d_ = context.Operators.ToList<CqlCode>(c_);
		var e_ = context.Operators.RetrieveByCodes<AllergyIntolerance>(d_, null);
		var f_ = context.Operators.ListUnion<AllergyIntolerance>(b_, e_);
		bool? g_(AllergyIntolerance BetaBlockerAllergyIntolerance)
		{
			var j_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter((BetaBlockerAllergyIntolerance as object));
			var k_ = BetaBlockerAllergyIntolerance?.ClinicalStatus;
			var l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var n_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var o_ = QICoreCommon_2_0_000.allergy_active();
			var p_ = context.Operators.ConvertCodeToConcept(o_);
			var q_ = context.Operators.Equivalent(n_, p_);
			var r_ = context.Operators.Or((bool?)(l_ is null), q_);
			var s_ = context.Operators.And(j_, r_);

			return s_;
		};
		var h_ = context.Operators.Where<AllergyIntolerance>(f_, g_);
		var i_ = context.Operators.Exists<AllergyIntolerance>(h_);

		return i_;
	}

    [CqlDeclaration("Has Allergy or Intolerance to Beta Blocker Therapy Ingredient")]
	public bool? Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient() => 
		__Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient.Value;

	private bool? Has_Atrioventricular_Block_Diagnosis_Value()
	{
		var a_ = this.Atrioventricular_Block();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition AtrioventricularBlock)
		{
			var f_ = AHAOverall_2_6_000.overlapsHeartFailureOutpatientEncounter(AtrioventricularBlock);
			var g_ = QICoreCommon_2_0_000.isActive(AtrioventricularBlock);
			var h_ = context.Operators.And(f_, g_);
			var i_ = AtrioventricularBlock?.VerificationStatus;
			var j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			var k_ = QICoreCommon_2_0_000.confirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var n_ = context.Operators.And(h_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Atrioventricular Block Diagnosis")]
	public bool? Has_Atrioventricular_Block_Diagnosis() => 
		__Has_Atrioventricular_Block_Diagnosis.Value;

	private bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ_Value()
	{
		var a_ = this.Cardiac_Pacer_in_Situ();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition CardiacPacerDiagnosis)
		{
			var f_ = AHAOverall_2_6_000.overlapsAfterHeartFailureOutpatientEncounter((CardiacPacerDiagnosis as object));
			var g_ = QICoreCommon_2_0_000.isActive(CardiacPacerDiagnosis);
			var h_ = context.Operators.And(f_, g_);
			var i_ = CardiacPacerDiagnosis?.VerificationStatus;
			var j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			var k_ = QICoreCommon_2_0_000.confirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var n_ = context.Operators.And(h_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Diagnosis of Cardiac Pacer in Situ")]
	public bool? Has_Diagnosis_of_Cardiac_Pacer_in_Situ() => 
		__Has_Diagnosis_of_Cardiac_Pacer_in_Situ.Value;

	private bool? Has_Cardiac_Pacer_Device_Implanted_Value()
	{
		var a_ = this.Cardiac_Pacer();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_(Procedure ImplantedCardiacPacer)
		{
			var h_ = AHAOverall_2_6_000.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD();
			bool? i_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
			{
				var m_ = ImplantedCardiacPacer?.Performed;
				var n_ = FHIRHelpers_4_3_000.ToValue(m_);
				var o_ = QICoreCommon_2_0_000.toInterval(n_);
				var p_ = context.Operators.Start(o_);
				var q_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
				var r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				var s_ = context.Operators.End(r_);
				var t_ = context.Operators.Before(p_, s_, null);

				return t_;
			};
			var j_ = context.Operators.Where<Encounter>(h_, i_);
			Procedure k_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) => 
				ImplantedCardiacPacer;
			var l_ = context.Operators.Select<Encounter, Procedure>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure ImplantedCardiacPacer)
		{
			var u_ = ImplantedCardiacPacer?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<string>(v_);
			var x_ = context.Operators.Equal(w_, "completed");

			return x_;
		};
		var f_ = context.Operators.Where<Procedure>(d_, e_);
		var g_ = context.Operators.Exists<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("Has Cardiac Pacer Device Implanted")]
	public bool? Has_Cardiac_Pacer_Device_Implanted() => 
		__Has_Cardiac_Pacer_Device_Implanted.Value;

	private bool? Atrioventricular_Block_without_Cardiac_Pacer_Value()
	{
		var a_ = this.Has_Atrioventricular_Block_Diagnosis();
		var b_ = this.Has_Diagnosis_of_Cardiac_Pacer_in_Situ();
		var c_ = context.Operators.Not(b_);
		var d_ = context.Operators.And(a_, c_);
		var e_ = this.Has_Cardiac_Pacer_Device_Implanted();
		var f_ = context.Operators.Not(e_);
		var g_ = context.Operators.And(d_, f_);

		return g_;
	}

    [CqlDeclaration("Atrioventricular Block without Cardiac Pacer")]
	public bool? Atrioventricular_Block_without_Cardiac_Pacer() => 
		__Atrioventricular_Block_without_Cardiac_Pacer.Value;

	private bool? Denominator_Exceptions_Value()
	{
		var a_ = this.Has_Consecutive_Heart_Rates_Less_than_50();
		var b_ = this.Has_Medical_or_Patient_Reason_for_Not_Ordering_Beta_Blocker_for_LVSD();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Has_Arrhythmia_Diagnosis();
		var e_ = context.Operators.Or(c_, d_);
		var f_ = this.Has_Hypotension_Diagnosis();
		var g_ = context.Operators.Or(e_, f_);
		var h_ = this.Has_Asthma_Diagnosis();
		var i_ = context.Operators.Or(g_, h_);
		var j_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_Beta_Blocker_Therapy();
		var k_ = context.Operators.Or(i_, j_);
		var l_ = this.Has_Bradycardia_Diagnosis();
		var m_ = context.Operators.Or(k_, l_);
		var n_ = this.Has_Allergy_or_Intolerance_to_Beta_Blocker_Therapy_Ingredient();
		var o_ = context.Operators.Or(m_, n_);
		var p_ = this.Atrioventricular_Block_without_Cardiac_Pacer();
		var q_ = context.Operators.Or(o_, p_);

		return q_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
