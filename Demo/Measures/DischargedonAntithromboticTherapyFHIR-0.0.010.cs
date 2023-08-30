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
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Antithrombotic_Therapy();
		var d_ = b_.RetrieveByValueSet<MedicationRequest>(c_, null);
		bool? e_(MedicationRequest NoAntithromboticDischarge)
		{
			var g_ = context.Operators;
			var l_ = NoAntithromboticDischarge?.DoNotPerformElement;
			var m_ = FHIRHelpers_4_0_001.ToBoolean(l_);
			var n_ = g_.IsTrue(m_);
			var r_ = NoAntithromboticDischarge?.ReasonCode;
			CqlConcept s_(CodeableConcept X)
			{
				var bd_ = FHIRHelpers_4_0_001.ToConcept(X);

				return bd_;
			};
			var t_ = g_.SelectOrNull<CodeableConcept, CqlConcept>((r_ as IEnumerable<CodeableConcept>), s_);
			var u_ = this.Medical_Reason();
			var v_ = g_.ConceptsInValueSet(t_, u_);
			CqlConcept z_(CodeableConcept X)
			{
				var be_ = FHIRHelpers_4_0_001.ToConcept(X);

				return be_;
			};
			var aa_ = g_.SelectOrNull<CodeableConcept, CqlConcept>((r_ as IEnumerable<CodeableConcept>), z_);
			var ab_ = this.Patient_Refusal();
			var ac_ = g_.ConceptsInValueSet(aa_, ab_);
			var ad_ = g_.Or(v_, ac_);
			var ae_ = g_.And(n_, ad_);
			var ah_ = NoAntithromboticDischarge?.Category;
			bool? ai_(CodeableConcept C)
			{
				var bf_ = context.Operators;
				var bh_ = FHIRHelpers_4_0_001.ToConcept(C);
				var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var bk_ = bf_.ConvertCodeToConcept(bj_);
				var bl_ = bf_.Equivalent(bh_, bk_);
				var bp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var bq_ = bf_.ConvertCodeToConcept(bp_);
				var br_ = bf_.Equivalent(bh_, bq_);
				var bs_ = bf_.Or(bl_, br_);

				return bs_;
			};
			var aj_ = g_.WhereOrNull<CodeableConcept>((ah_ as IEnumerable<CodeableConcept>), ai_);
			var ak_ = g_.ExistsInList<CodeableConcept>(aj_);
			var al_ = g_.And(ae_, ak_);
			var an_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ao_ = an_.Operators;
			var ap_ = ao_.TypeConverter;
			var aq_ = NoAntithromboticDischarge?.StatusElement;
			var ar_ = ap_.Convert<string>(aq_);
			var as_ = new string[]
			{
				"completed",
				"cancelled",
			};
			var at_ = g_.InList<string>(ar_, (as_ as IEnumerable<string>));
			var au_ = g_.And(al_, at_);
			var ax_ = an_.Operators;
			var ay_ = ax_.TypeConverter;
			var az_ = NoAntithromboticDischarge?.IntentElement;
			var ba_ = ay_.Convert<string>(az_);
			var bb_ = g_.Equal(ba_, "order");
			var bc_ = g_.And(au_, bb_);

			return bc_;
		};
		var f_ = a_.WhereOrNull<MedicationRequest>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Antithrombotic Not Given at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge() => 
		__Antithrombotic_Not_Given_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge_Value()
	{
		var a_ = context.Operators;
		var b_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> c_(Encounter IschemicStrokeEncounter)
		{
			var e_ = context.Operators;
			var g_ = this.Antithrombotic_Not_Given_at_Discharge();
			bool? h_(MedicationRequest NoDischargeAntithrombotic)
			{
				var l_ = context.Operators;
				var m_ = NoDischargeAntithrombotic?.AuthoredOnElement;
				var n_ = FHIRHelpers_4_0_001.ToDateTime(m_);
				var o_ = IschemicStrokeEncounter?.Period;
				var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
				var q_ = l_.ElementInInterval<CqlDateTime>(n_, p_, null);

				return q_;
			};
			var i_ = e_.WhereOrNull<MedicationRequest>(g_, h_);
			Encounter j_(MedicationRequest NoDischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			var k_ = e_.SelectOrNull<MedicationRequest, Encounter>(i_, j_);

			return k_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter With No Antithrombotic At Discharge")]
	public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge() => 
		__Encounter_With_No_Antithrombotic_At_Discharge.Value;

	private IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy();
		var d_ = b_.RetrieveByValueSet<MedicationRequest>(c_, null);
		bool? e_(MedicationRequest Pharmacological)
		{
			var g_ = context.Operators;
			var l_ = Pharmacological?.DoNotPerformElement;
			var m_ = FHIRHelpers_4_0_001.ToBoolean(l_);
			var n_ = g_.IsTrue(m_);
			var o_ = g_.Not(n_);
			var r_ = Pharmacological?.Category;
			bool? s_(CodeableConcept C)
			{
				var an_ = context.Operators;
				var ap_ = FHIRHelpers_4_0_001.ToConcept(C);
				var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var as_ = an_.ConvertCodeToConcept(ar_);
				var at_ = an_.Equivalent(ap_, as_);
				var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ay_ = an_.ConvertCodeToConcept(ax_);
				var az_ = an_.Equivalent(ap_, ay_);
				var ba_ = an_.Or(at_, az_);

				return ba_;
			};
			var t_ = g_.WhereOrNull<CodeableConcept>((r_ as IEnumerable<CodeableConcept>), s_);
			var u_ = g_.ExistsInList<CodeableConcept>(t_);
			var v_ = g_.And(o_, u_);
			var x_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var y_ = x_.Operators;
			var z_ = y_.TypeConverter;
			var aa_ = Pharmacological?.StatusElement;
			var ab_ = z_.Convert<string>(aa_);
			var ac_ = new string[]
			{
				"active",
				"completed",
			};
			var ad_ = g_.InList<string>(ab_, (ac_ as IEnumerable<string>));
			var ae_ = g_.And(v_, ad_);
			var ah_ = x_.Operators;
			var ai_ = ah_.TypeConverter;
			var aj_ = Pharmacological?.IntentElement;
			var ak_ = ai_.Convert<string>(aj_);
			var al_ = g_.Equal(ak_, "order");
			var am_ = g_.And(ae_, al_);

			return am_;
		};
		var f_ = a_.WhereOrNull<MedicationRequest>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = context.Operators;
		var b_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> c_(Encounter IschemicStrokeEncounter)
		{
			var e_ = context.Operators;
			var g_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
			bool? h_(MedicationRequest DischargePharmacological)
			{
				var l_ = context.Operators;
				var m_ = DischargePharmacological?.AuthoredOnElement;
				var n_ = FHIRHelpers_4_0_001.ToDateTime(m_);
				var o_ = IschemicStrokeEncounter?.Period;
				var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
				var q_ = l_.ElementInInterval<CqlDateTime>(n_, p_, null);

				return q_;
			};
			var i_ = e_.WhereOrNull<MedicationRequest>(g_, h_);
			Encounter j_(MedicationRequest DischargePharmacological) => 
				IschemicStrokeEncounter;
			var k_ = e_.SelectOrNull<MedicationRequest, Encounter>(i_, j_);

			return k_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Encounter_With_No_Antithrombotic_At_Discharge();
		var c_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
		var d_ = a_.ListUnion<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = context.Operators;
		var b_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounters_with_Discharge_Disposition();
		var c_ = TJCOverallFHIR_1_8_000.Encounter_with_Comfort_Measures_during_Hospitalization();
		var d_ = a_.ListUnion<Encounter>(b_, c_);

		return d_;
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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Antithrombotic_Therapy();
		var d_ = b_.RetrieveByValueSet<MedicationRequest>(c_, null);
		bool? e_(MedicationRequest Antithrombotic)
		{
			var g_ = context.Operators;
			var l_ = Antithrombotic?.DoNotPerformElement;
			var m_ = FHIRHelpers_4_0_001.ToBoolean(l_);
			var n_ = g_.IsTrue(m_);
			var o_ = g_.Not(n_);
			var r_ = Antithrombotic?.Category;
			bool? s_(CodeableConcept C)
			{
				var an_ = context.Operators;
				var ap_ = FHIRHelpers_4_0_001.ToConcept(C);
				var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var as_ = an_.ConvertCodeToConcept(ar_);
				var at_ = an_.Equivalent(ap_, as_);
				var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ay_ = an_.ConvertCodeToConcept(ax_);
				var az_ = an_.Equivalent(ap_, ay_);
				var ba_ = an_.Or(at_, az_);

				return ba_;
			};
			var t_ = g_.WhereOrNull<CodeableConcept>((r_ as IEnumerable<CodeableConcept>), s_);
			var u_ = g_.ExistsInList<CodeableConcept>(t_);
			var v_ = g_.And(o_, u_);
			var x_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var y_ = x_.Operators;
			var z_ = y_.TypeConverter;
			var aa_ = Antithrombotic?.StatusElement;
			var ab_ = z_.Convert<string>(aa_);
			var ac_ = new string[]
			{
				"active",
				"completed",
			};
			var ad_ = g_.InList<string>(ab_, (ac_ as IEnumerable<string>));
			var ae_ = g_.And(v_, ad_);
			var ah_ = x_.Operators;
			var ai_ = ah_.TypeConverter;
			var aj_ = Antithrombotic?.IntentElement;
			var ak_ = ai_.Convert<string>(aj_);
			var al_ = g_.Equal(ak_, "order");
			var am_ = g_.And(ae_, al_);

			return am_;
		};
		var f_ = a_.WhereOrNull<MedicationRequest>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge() => 
		__Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = context.Operators;
		var b_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> c_(Encounter IschemicStrokeEncounter)
		{
			var e_ = context.Operators;
			var g_ = this.Antithrombotic_Therapy_at_Discharge();
			bool? h_(MedicationRequest DischargeAntithrombotic)
			{
				var l_ = context.Operators;
				var m_ = DischargeAntithrombotic?.AuthoredOnElement;
				var n_ = FHIRHelpers_4_0_001.ToDateTime(m_);
				var o_ = IschemicStrokeEncounter?.Period;
				var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
				var q_ = l_.ElementInInterval<CqlDateTime>(n_, p_, null);

				return q_;
			};
			var i_ = e_.WhereOrNull<MedicationRequest>(g_, h_);
			Encounter j_(MedicationRequest DischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			var k_ = e_.SelectOrNull<MedicationRequest, Encounter>(i_, j_);

			return k_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
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

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
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