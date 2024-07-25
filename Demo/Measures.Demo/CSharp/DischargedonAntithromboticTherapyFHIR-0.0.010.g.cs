using System;
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
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.0.010")]
public class DischargedonAntithromboticTherapyFHIR_0_0_010
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Antithrombotic_Therapy;
    internal Lazy<CqlValueSet> __Comfort_Measures;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Hemorrhagic_Stroke;
    internal Lazy<CqlValueSet> __Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Left_Against_Medical_Advice;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Non_Elective_Inpatient_Encounter;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Patient_Refusal;
    internal Lazy<CqlValueSet> __Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<MedicationRequest>> __Antithrombotic_Not_Given_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Encounter_With_No_Antithrombotic_At_Discharge;
    internal Lazy<IEnumerable<MedicationRequest>> __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exceptions;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<MedicationRequest>> __Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public DischargedonAntithromboticTherapyFHIR_0_0_010(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        TJCOverallFHIR_1_8_000 = new TJCOverallFHIR_1_8_000(context);

        __Antithrombotic_Therapy = new Lazy<CqlValueSet>(this.Antithrombotic_Therapy_Value);
        __Comfort_Measures = new Lazy<CqlValueSet>(this.Comfort_Measures_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Hemorrhagic_Stroke = new Lazy<CqlValueSet>(this.Hemorrhagic_Stroke_Value);
        __Ischemic_Stroke = new Lazy<CqlValueSet>(this.Ischemic_Stroke_Value);
        __Left_Against_Medical_Advice = new Lazy<CqlValueSet>(this.Left_Against_Medical_Advice_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Non_Elective_Inpatient_Encounter = new Lazy<CqlValueSet>(this.Non_Elective_Inpatient_Encounter_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Patient_Refusal = new Lazy<CqlValueSet>(this.Patient_Refusal_Value);
        __Pharmacological_Contraindications_For_Antithrombotic_Therapy = new Lazy<CqlValueSet>(this.Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Antithrombotic_Not_Given_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Antithrombotic_Not_Given_at_Discharge_Value);
        __Encounter_With_No_Antithrombotic_At_Discharge = new Lazy<IEnumerable<Encounter>>(this.Encounter_With_No_Antithrombotic_At_Discharge_Value);
        __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value);
        __Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<Encounter>>(this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value);
        __Denominator_Exceptions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exceptions_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Antithrombotic_Therapy_at_Discharge_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public TJCOverallFHIR_1_8_000 TJCOverallFHIR_1_8_000 { get; }

    #endregion

	private CqlValueSet Antithrombotic_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", null);

    [CqlDeclaration("Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201")]
	public CqlValueSet Antithrombotic_Therapy() => 
		__Antithrombotic_Therapy.Value;

	private CqlValueSet Comfort_Measures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
	public CqlValueSet Comfort_Measures() => 
		__Comfort_Measures.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Hemorrhagic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
	public CqlValueSet Hemorrhagic_Stroke() => 
		__Hemorrhagic_Stroke.Value;

	private CqlValueSet Ischemic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
	public CqlValueSet Ischemic_Stroke() => 
		__Ischemic_Stroke.Value;

	private CqlValueSet Left_Against_Medical_Advice_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public CqlValueSet Left_Against_Medical_Advice() => 
		__Left_Against_Medical_Advice.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Non_Elective_Inpatient_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Non-Elective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public CqlValueSet Non_Elective_Inpatient_Encounter() => 
		__Non_Elective_Inpatient_Encounter.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Patient_Refusal_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public CqlValueSet Patient_Refusal() => 
		__Patient_Refusal.Value;

	private CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
	public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy() => 
		__Pharmacological_Contraindications_For_Antithrombotic_Therapy.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge_Value()
	{
		var a_ = this.Antithrombotic_Therapy();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest NoAntithromboticDischarge)
		{
			var e_ = NoAntithromboticDischarge.DoNotPerformElement;
			var f_ = FHIRHelpers_4_0_001.ToBoolean(e_);
			var g_ = context.Operators.IsTrue(f_);
			var h_ = NoAntithromboticDischarge.ReasonCode;
			CqlConcept i_(CodeableConcept X)
			{
				var ah_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ah_;
			};
			var j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			var k_ = this.Medical_Reason();
			var l_ = context.Operators.ConceptsInValueSet(j_, k_);
			CqlConcept n_(CodeableConcept X)
			{
				var ai_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ai_;
			};
			var o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, n_);
			var p_ = this.Patient_Refusal();
			var q_ = context.Operators.ConceptsInValueSet(o_, p_);
			var r_ = context.Operators.Or(l_, q_);
			var s_ = context.Operators.And(g_, r_);
			var t_ = NoAntithromboticDischarge.Category;
			bool? u_(CodeableConcept C)
			{
				var aj_ = FHIRHelpers_4_0_001.ToConcept(C);
				var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var al_ = context.Operators.ConvertCodeToConcept(ak_);
				var am_ = context.Operators.Equivalent(aj_, al_);
				var ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ap_ = context.Operators.ConvertCodeToConcept(ao_);
				var aq_ = context.Operators.Equivalent(aj_, ap_);
				var ar_ = context.Operators.Or(am_, aq_);

				return ar_;
			};
			var v_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)t_, u_);
			var w_ = context.Operators.Exists<CodeableConcept>(v_);
			var x_ = context.Operators.And(s_, w_);
			var y_ = NoAntithromboticDischarge.StatusElement;
			var z_ = FHIRHelpers_4_0_001.ToString(y_);
			var aa_ = new string[]
			{
				"completed",
				"cancelled",
			};
			var ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
			var ac_ = context.Operators.And(x_, ab_);
			var ad_ = NoAntithromboticDischarge.IntentElement;
			var ae_ = FHIRHelpers_4_0_001.ToString(ad_);
			var af_ = context.Operators.Equal(ae_, "order");
			var ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		var d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Antithrombotic Not Given at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge() => 
		__Antithrombotic_Not_Given_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Antithrombotic_Not_Given_at_Discharge();
			bool? e_(MedicationRequest NoDischargeAntithrombotic)
			{
				var i_ = NoDischargeAntithrombotic.AuthoredOnElement;
				var j_ = FHIRHelpers_4_0_001.ToDateTime(i_);
				var k_ = IschemicStrokeEncounter.Period;
				var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
				var m_ = context.Operators.In<CqlDateTime>(j_, l_, null);

				return m_;
			};
			var f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest NoDischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter With No Antithrombotic At Discharge")]
	public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge() => 
		__Encounter_With_No_Antithrombotic_At_Discharge.Value;

	private IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest Pharmacological)
		{
			var e_ = Pharmacological.DoNotPerformElement;
			var f_ = FHIRHelpers_4_0_001.ToBoolean(e_);
			var g_ = context.Operators.IsTrue(f_);
			var h_ = context.Operators.Not(g_);
			var i_ = Pharmacological.Category;
			bool? j_(CodeableConcept C)
			{
				var w_ = FHIRHelpers_4_0_001.ToConcept(C);
				var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var y_ = context.Operators.ConvertCodeToConcept(x_);
				var z_ = context.Operators.Equivalent(w_, y_);
				var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ac_ = context.Operators.ConvertCodeToConcept(ab_);
				var ad_ = context.Operators.Equivalent(w_, ac_);
				var ae_ = context.Operators.Or(z_, ad_);

				return ae_;
			};
			var k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			var l_ = context.Operators.Exists<CodeableConcept>(k_);
			var m_ = context.Operators.And(h_, l_);
			var n_ = Pharmacological.StatusElement;
			var o_ = FHIRHelpers_4_0_001.ToString(n_);
			var p_ = new string[]
			{
				"active",
				"completed",
			};
			var q_ = context.Operators.In<string>(o_, (p_ as IEnumerable<string>));
			var r_ = context.Operators.And(m_, q_);
			var s_ = Pharmacological.IntentElement;
			var t_ = FHIRHelpers_4_0_001.ToString(s_);
			var u_ = context.Operators.Equal(t_, "order");
			var v_ = context.Operators.And(r_, u_);

			return v_;
		};
		var d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
			bool? e_(MedicationRequest DischargePharmacological)
			{
				var i_ = DischargePharmacological.AuthoredOnElement;
				var j_ = FHIRHelpers_4_0_001.ToDateTime(i_);
				var k_ = IschemicStrokeEncounter.Period;
				var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
				var m_ = context.Operators.In<CqlDateTime>(j_, l_, null);

				return m_;
			};
			var f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest DischargePharmacological) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		var a_ = this.Encounter_With_No_Antithrombotic_At_Discharge();
		var b_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounters_with_Discharge_Disposition();
		var b_ = TJCOverallFHIR_1_8_000.Encounter_with_Comfort_Measures_during_Hospitalization();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Encounter_with_Principal_Diagnosis_and_Age();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = this.Antithrombotic_Therapy();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest Antithrombotic)
		{
			var e_ = Antithrombotic.DoNotPerformElement;
			var f_ = FHIRHelpers_4_0_001.ToBoolean(e_);
			var g_ = context.Operators.IsTrue(f_);
			var h_ = context.Operators.Not(g_);
			var i_ = Antithrombotic.Category;
			bool? j_(CodeableConcept C)
			{
				var w_ = FHIRHelpers_4_0_001.ToConcept(C);
				var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var y_ = context.Operators.ConvertCodeToConcept(x_);
				var z_ = context.Operators.Equivalent(w_, y_);
				var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ac_ = context.Operators.ConvertCodeToConcept(ab_);
				var ad_ = context.Operators.Equivalent(w_, ac_);
				var ae_ = context.Operators.Or(z_, ad_);

				return ae_;
			};
			var k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			var l_ = context.Operators.Exists<CodeableConcept>(k_);
			var m_ = context.Operators.And(h_, l_);
			var n_ = Antithrombotic.StatusElement;
			var o_ = FHIRHelpers_4_0_001.ToString(n_);
			var p_ = new string[]
			{
				"active",
				"completed",
			};
			var q_ = context.Operators.In<string>(o_, (p_ as IEnumerable<string>));
			var r_ = context.Operators.And(m_, q_);
			var s_ = Antithrombotic.IntentElement;
			var t_ = FHIRHelpers_4_0_001.ToString(s_);
			var u_ = context.Operators.Equal(t_, "order");
			var v_ = context.Operators.And(r_, u_);

			return v_;
		};
		var d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge() => 
		__Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Antithrombotic_Therapy_at_Discharge();
			bool? e_(MedicationRequest DischargeAntithrombotic)
			{
				var i_ = DischargeAntithrombotic.AuthoredOnElement;
				var j_ = FHIRHelpers_4_0_001.ToDateTime(i_);
				var k_ = IschemicStrokeEncounter.Period;
				var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
				var m_ = context.Operators.In<CqlDateTime>(j_, l_, null);

				return m_;
			};
			var f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest DischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
