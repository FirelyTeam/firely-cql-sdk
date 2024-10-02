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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", default);

    [CqlDeclaration("Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201")]
	public CqlValueSet Antithrombotic_Therapy() => 
		__Antithrombotic_Therapy.Value;

	private CqlValueSet Comfort_Measures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", default);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
	public CqlValueSet Comfort_Measures() => 
		__Comfort_Measures.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Hemorrhagic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", default);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
	public CqlValueSet Hemorrhagic_Stroke() => 
		__Hemorrhagic_Stroke.Value;

	private CqlValueSet Ischemic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", default);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
	public CqlValueSet Ischemic_Stroke() => 
		__Ischemic_Stroke.Value;

	private CqlValueSet Left_Against_Medical_Advice_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", default);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public CqlValueSet Left_Against_Medical_Advice() => 
		__Left_Against_Medical_Advice.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", default);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Non_Elective_Inpatient_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", default);

    [CqlDeclaration("Non-Elective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public CqlValueSet Non_Elective_Inpatient_Encounter() => 
		__Non_Elective_Inpatient_Encounter.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Patient_Refusal_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", default);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public CqlValueSet Patient_Refusal() => 
		__Patient_Refusal.Value;

	private CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", default);

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
	public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy() => 
		__Pharmacological_Contraindications_For_Antithrombotic_Therapy.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge_Value()
	{
		CqlValueSet a_ = this.Antithrombotic_Therapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		bool? c_(MedicationRequest NoAntithromboticDischarge)
		{
			FhirBoolean e_ = NoAntithromboticDischarge?.DoNotPerformElement;
			bool? f_ = FHIRHelpers_4_0_001.ToBoolean(e_);
			bool? g_ = context.Operators.IsTrue(f_);
			List<CodeableConcept> h_ = NoAntithromboticDischarge?.ReasonCode;
			CqlConcept i_(CodeableConcept X)
			{
				CqlConcept ah_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ah_;
			};
			IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			CqlValueSet k_ = this.Medical_Reason();
			bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
			CqlConcept n_(CodeableConcept X)
			{
				CqlConcept ai_ = FHIRHelpers_4_0_001.ToConcept(X);

				return ai_;
			};
			IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, n_);
			CqlValueSet p_ = this.Patient_Refusal();
			bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
			bool? r_ = context.Operators.Or(l_, q_);
			bool? s_ = context.Operators.And(g_, r_);
			List<CodeableConcept> t_ = NoAntithromboticDischarge?.Category;
			bool? u_(CodeableConcept C)
			{
				CqlConcept aj_ = FHIRHelpers_4_0_001.ToConcept(C);
				CqlCode ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				CqlConcept al_ = context.Operators.ConvertCodeToConcept(ak_);
				bool? am_ = context.Operators.Equivalent(aj_, al_);
				CqlCode ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
				bool? aq_ = context.Operators.Equivalent(aj_, ap_);
				bool? ar_ = context.Operators.Or(am_, aq_);

				return ar_;
			};
			IEnumerable<CodeableConcept> v_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)t_, u_);
			bool? w_ = context.Operators.Exists<CodeableConcept>(v_);
			bool? x_ = context.Operators.And(s_, w_);
			Code<MedicationRequest.MedicationrequestStatus> y_ = NoAntithromboticDischarge?.StatusElement;
			string z_ = FHIRHelpers_4_0_001.ToString(y_);
			string[] aa_ = [
				"completed",
				"cancelled",
			];
			bool? ab_ = context.Operators.In<string>(z_, aa_ as IEnumerable<string>);
			bool? ac_ = context.Operators.And(x_, ab_);
			Code<MedicationRequest.MedicationRequestIntent> ad_ = NoAntithromboticDischarge?.IntentElement;
			string ae_ = FHIRHelpers_4_0_001.ToString(ad_);
			bool? af_ = context.Operators.Equal(ae_, "order");
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Antithrombotic Not Given at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge() => 
		__Antithrombotic_Not_Given_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = this.Antithrombotic_Not_Given_at_Discharge();
			bool? e_(MedicationRequest NoDischargeAntithrombotic)
			{
				FhirDateTime i_ = NoDischargeAntithrombotic?.AuthoredOnElement;
				CqlDateTime j_ = FHIRHelpers_4_0_001.ToDateTime(i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(k_);
				bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

				return m_;
			};
			IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest NoDischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter With No Antithrombotic At Discharge")]
	public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge() => 
		__Encounter_With_No_Antithrombotic_At_Discharge.Value;

	private IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		CqlValueSet a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		bool? c_(MedicationRequest Pharmacological)
		{
			FhirBoolean e_ = Pharmacological?.DoNotPerformElement;
			bool? f_ = FHIRHelpers_4_0_001.ToBoolean(e_);
			bool? g_ = context.Operators.IsTrue(f_);
			bool? h_ = context.Operators.Not(g_);
			List<CodeableConcept> i_ = Pharmacological?.Category;
			bool? j_(CodeableConcept C)
			{
				CqlConcept w_ = FHIRHelpers_4_0_001.ToConcept(C);
				CqlCode x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
				bool? z_ = context.Operators.Equivalent(w_, y_);
				CqlCode ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
				bool? ad_ = context.Operators.Equivalent(w_, ac_);
				bool? ae_ = context.Operators.Or(z_, ad_);

				return ae_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			Code<MedicationRequest.MedicationrequestStatus> n_ = Pharmacological?.StatusElement;
			string o_ = FHIRHelpers_4_0_001.ToString(n_);
			string[] p_ = [
				"active",
				"completed",
			];
			bool? q_ = context.Operators.In<string>(o_, p_ as IEnumerable<string>);
			bool? r_ = context.Operators.And(m_, q_);
			Code<MedicationRequest.MedicationRequestIntent> s_ = Pharmacological?.IntentElement;
			string t_ = FHIRHelpers_4_0_001.ToString(s_);
			bool? u_ = context.Operators.Equal(t_, "order");
			bool? v_ = context.Operators.And(r_, u_);

			return v_;
		};
		IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
			bool? e_(MedicationRequest DischargePharmacological)
			{
				FhirDateTime i_ = DischargePharmacological?.AuthoredOnElement;
				CqlDateTime j_ = FHIRHelpers_4_0_001.ToDateTime(i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(k_);
				bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

				return m_;
			};
			IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest DischargePharmacological) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_With_No_Antithrombotic_At_Discharge();
		IEnumerable<Encounter> b_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounters_with_Discharge_Disposition();
		IEnumerable<Encounter> b_ = TJCOverallFHIR_1_8_000.Encounter_with_Comfort_Measures_during_Hospitalization();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Encounter_with_Principal_Diagnosis_and_Age();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge_Value()
	{
		CqlValueSet a_ = this.Antithrombotic_Therapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		bool? c_(MedicationRequest Antithrombotic)
		{
			FhirBoolean e_ = Antithrombotic?.DoNotPerformElement;
			bool? f_ = FHIRHelpers_4_0_001.ToBoolean(e_);
			bool? g_ = context.Operators.IsTrue(f_);
			bool? h_ = context.Operators.Not(g_);
			List<CodeableConcept> i_ = Antithrombotic?.Category;
			bool? j_(CodeableConcept C)
			{
				CqlConcept w_ = FHIRHelpers_4_0_001.ToConcept(C);
				CqlCode x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
				bool? z_ = context.Operators.Equivalent(w_, y_);
				CqlCode ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
				bool? ad_ = context.Operators.Equivalent(w_, ac_);
				bool? ae_ = context.Operators.Or(z_, ad_);

				return ae_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			Code<MedicationRequest.MedicationrequestStatus> n_ = Antithrombotic?.StatusElement;
			string o_ = FHIRHelpers_4_0_001.ToString(n_);
			string[] p_ = [
				"active",
				"completed",
			];
			bool? q_ = context.Operators.In<string>(o_, p_ as IEnumerable<string>);
			bool? r_ = context.Operators.And(m_, q_);
			Code<MedicationRequest.MedicationRequestIntent> s_ = Antithrombotic?.IntentElement;
			string t_ = FHIRHelpers_4_0_001.ToString(s_);
			bool? u_ = context.Operators.Equal(t_, "order");
			bool? v_ = context.Operators.And(r_, u_);

			return v_;
		};
		IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge() => 
		__Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = this.Antithrombotic_Therapy_at_Discharge();
			bool? e_(MedicationRequest DischargeAntithrombotic)
			{
				FhirDateTime i_ = DischargeAntithrombotic?.AuthoredOnElement;
				CqlDateTime j_ = FHIRHelpers_4_0_001.ToDateTime(i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(k_);
				bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

				return m_;
			};
			IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest DischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
