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
    public CqlValueSet Antithrombotic_Therapy() => __Antithrombotic_Therapy.Value;

    private CqlValueSet Comfort_Measures_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
    public CqlValueSet Comfort_Measures() => __Comfort_Measures.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Emergency_Department_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Hemorrhagic_Stroke_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
    public CqlValueSet Hemorrhagic_Stroke() => __Hemorrhagic_Stroke.Value;

    private CqlValueSet Ischemic_Stroke_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
    public CqlValueSet Ischemic_Stroke() => __Ischemic_Stroke.Value;

    private CqlValueSet Left_Against_Medical_Advice_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
    public CqlValueSet Left_Against_Medical_Advice() => __Left_Against_Medical_Advice.Value;

    private CqlValueSet Medical_Reason_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
    public CqlValueSet Medical_Reason() => __Medical_Reason.Value;

    private CqlValueSet Non_Elective_Inpatient_Encounter_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Non-Elective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
    public CqlValueSet Non_Elective_Inpatient_Encounter() => __Non_Elective_Inpatient_Encounter.Value;

    private CqlValueSet Patient_Expired_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Patient_Refusal_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
    public CqlValueSet Patient_Refusal() => __Patient_Refusal.Value;

    private CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy() => __Pharmacological_Contraindications_For_Antithrombotic_Therapy.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    private IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge_Value()
	{
		var a_ = this.Antithrombotic_Therapy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? d_(MedicationRequest NoAntithromboticDischarge)
		{
			var g_ = NoAntithromboticDischarge?.DoNotPerformElement;
			var h_ = FHIRHelpers_4_0_001.ToBoolean(g_);
			var i_ = context.Operators;
			var j_ = i_.IsTrue(h_);
			var k_ = NoAntithromboticDischarge?.ReasonCode;
			CqlConcept l_(CodeableConcept X)
			{
				var bf_ = FHIRHelpers_4_0_001.ToConcept(X);

				return bf_;
			};
			var n_ = i_.SelectOrNull<CodeableConcept, CqlConcept>((k_ as IEnumerable<CodeableConcept>), l_);
			var o_ = this.Medical_Reason();
			var q_ = i_.ConceptsInValueSet(n_, o_);
			CqlConcept s_(CodeableConcept X)
			{
				var bg_ = FHIRHelpers_4_0_001.ToConcept(X);

				return bg_;
			};
			var u_ = i_.SelectOrNull<CodeableConcept, CqlConcept>((k_ as IEnumerable<CodeableConcept>), s_);
			var v_ = this.Patient_Refusal();
			var x_ = i_.ConceptsInValueSet(u_, v_);
			var z_ = i_.Or(q_, x_);
			var ab_ = i_.And(j_, z_);
			var ac_ = NoAntithromboticDischarge?.Category;
			bool? ad_(CodeableConcept C)
			{
				var bh_ = FHIRHelpers_4_0_001.ToConcept(C);
				var bi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var bj_ = context.Operators;
				var bk_ = bj_.ConvertCodeToConcept(bi_);
				var bm_ = bj_.Equivalent(bh_, bk_);
				var bo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var bq_ = bj_.ConvertCodeToConcept(bo_);
				var bs_ = bj_.Equivalent(bh_, bq_);
				var bu_ = bj_.Or(bm_, bs_);

				return bu_;
			};
			var af_ = i_.WhereOrNull<CodeableConcept>((ac_ as IEnumerable<CodeableConcept>), ad_);
			var ah_ = i_.ExistsInList<CodeableConcept>(af_);
			var aj_ = i_.And(ab_, ah_);
			var ak_ = NoAntithromboticDischarge?.StatusElement;
			var al_ = new CallStackEntry("ToString", null, null);
			var am_ = context.Deeper(al_);
			var an_ = am_.Operators;
			var ao_ = an_.TypeConverter;
			var ap_ = ao_.Convert<string>(ak_);
			var aq_ = new string[]
			{
				"completed",
				"cancelled",
			};
			var as_ = i_.InList<string>(ap_, (aq_ as IEnumerable<string>));
			var au_ = i_.And(aj_, as_);
			var av_ = NoAntithromboticDischarge?.IntentElement;
			var ax_ = context.Deeper(al_);
			var ay_ = ax_.Operators;
			var az_ = ay_.TypeConverter;
			var ba_ = az_.Convert<string>(av_);
			var bc_ = i_.Equal(ba_, "order");
			var be_ = i_.And(au_, bc_);

			return be_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<MedicationRequest>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Antithrombotic Not Given at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge() => __Antithrombotic_Not_Given_at_Discharge.Value;

    private IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var e_ = this.Antithrombotic_Not_Given_at_Discharge();
			bool? f_(MedicationRequest NoDischargeAntithrombotic)
			{
				var l_ = NoDischargeAntithrombotic?.AuthoredOnElement;
				var m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
				var n_ = IschemicStrokeEncounter?.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = context.Operators;
				var q_ = p_.ElementInInterval<CqlDateTime>(m_, o_, null);

				return q_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<MedicationRequest>(e_, f_);
			Encounter i_(MedicationRequest NoDischargeAntithrombotic) => IschemicStrokeEncounter;
			var k_ = g_.SelectOrNull<MedicationRequest, Encounter>(h_, i_);

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Encounter With No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge() => __Encounter_With_No_Antithrombotic_At_Discharge.Value;

    private IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? d_(MedicationRequest Pharmacological)
		{
			var g_ = Pharmacological?.DoNotPerformElement;
			var h_ = FHIRHelpers_4_0_001.ToBoolean(g_);
			var i_ = context.Operators;
			var j_ = i_.IsTrue(h_);
			var l_ = i_.Not(j_);
			var m_ = Pharmacological?.Category;
			bool? n_(CodeableConcept C)
			{
				var ap_ = FHIRHelpers_4_0_001.ToConcept(C);
				var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var ar_ = context.Operators;
				var as_ = ar_.ConvertCodeToConcept(aq_);
				var au_ = ar_.Equivalent(ap_, as_);
				var aw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ay_ = ar_.ConvertCodeToConcept(aw_);
				var ba_ = ar_.Equivalent(ap_, ay_);
				var bc_ = ar_.Or(au_, ba_);

				return bc_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>((m_ as IEnumerable<CodeableConcept>), n_);
			var r_ = i_.ExistsInList<CodeableConcept>(p_);
			var t_ = i_.And(l_, r_);
			var u_ = Pharmacological?.StatusElement;
			var v_ = new CallStackEntry("ToString", null, null);
			var w_ = context.Deeper(v_);
			var x_ = w_.Operators;
			var y_ = x_.TypeConverter;
			var z_ = y_.Convert<string>(u_);
			var aa_ = new string[]
			{
				"active",
				"completed",
			};
			var ac_ = i_.InList<string>(z_, (aa_ as IEnumerable<string>));
			var ae_ = i_.And(t_, ac_);
			var af_ = Pharmacological?.IntentElement;
			var ah_ = context.Deeper(v_);
			var ai_ = ah_.Operators;
			var aj_ = ai_.TypeConverter;
			var ak_ = aj_.Convert<string>(af_);
			var am_ = i_.Equal(ak_, "order");
			var ao_ = i_.And(ae_, am_);

			return ao_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<MedicationRequest>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

    private IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var e_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
			bool? f_(MedicationRequest DischargePharmacological)
			{
				var l_ = DischargePharmacological?.AuthoredOnElement;
				var m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
				var n_ = IschemicStrokeEncounter?.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = context.Operators;
				var q_ = p_.ElementInInterval<CqlDateTime>(m_, o_, null);

				return q_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<MedicationRequest>(e_, f_);
			Encounter i_(MedicationRequest DischargePharmacological) => IschemicStrokeEncounter;
			var k_ = g_.SelectOrNull<MedicationRequest, Encounter>(h_, i_);

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => __Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

    private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		var a_ = this.Encounter_With_No_Antithrombotic_At_Discharge();
		var b_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
		var c_ = context.Operators;
		var d_ = c_.ListUnion<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions() => __Denominator_Exceptions.Value;

    private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounters_with_Discharge_Disposition();
		var b_ = TJCOverallFHIR_1_8_000.Encounter_with_Comfort_Measures_during_Hospitalization();
		var c_ = context.Operators;
		var d_ = c_.ListUnion<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Encounter_with_Principal_Diagnosis_and_Age();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = this.Antithrombotic_Therapy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? d_(MedicationRequest Antithrombotic)
		{
			var g_ = Antithrombotic?.DoNotPerformElement;
			var h_ = FHIRHelpers_4_0_001.ToBoolean(g_);
			var i_ = context.Operators;
			var j_ = i_.IsTrue(h_);
			var l_ = i_.Not(j_);
			var m_ = Antithrombotic?.Category;
			bool? n_(CodeableConcept C)
			{
				var ap_ = FHIRHelpers_4_0_001.ToConcept(C);
				var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var ar_ = context.Operators;
				var as_ = ar_.ConvertCodeToConcept(aq_);
				var au_ = ar_.Equivalent(ap_, as_);
				var aw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ay_ = ar_.ConvertCodeToConcept(aw_);
				var ba_ = ar_.Equivalent(ap_, ay_);
				var bc_ = ar_.Or(au_, ba_);

				return bc_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>((m_ as IEnumerable<CodeableConcept>), n_);
			var r_ = i_.ExistsInList<CodeableConcept>(p_);
			var t_ = i_.And(l_, r_);
			var u_ = Antithrombotic?.StatusElement;
			var v_ = new CallStackEntry("ToString", null, null);
			var w_ = context.Deeper(v_);
			var x_ = w_.Operators;
			var y_ = x_.TypeConverter;
			var z_ = y_.Convert<string>(u_);
			var aa_ = new string[]
			{
				"active",
				"completed",
			};
			var ac_ = i_.InList<string>(z_, (aa_ as IEnumerable<string>));
			var ae_ = i_.And(t_, ac_);
			var af_ = Antithrombotic?.IntentElement;
			var ah_ = context.Deeper(v_);
			var ai_ = ah_.Operators;
			var aj_ = ai_.TypeConverter;
			var ak_ = aj_.Convert<string>(af_);
			var am_ = i_.Equal(ak_, "order");
			var ao_ = i_.And(ae_, am_);

			return ao_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<MedicationRequest>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge() => __Antithrombotic_Therapy_at_Discharge.Value;

    private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var e_ = this.Antithrombotic_Therapy_at_Discharge();
			bool? f_(MedicationRequest DischargeAntithrombotic)
			{
				var l_ = DischargeAntithrombotic?.AuthoredOnElement;
				var m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
				var n_ = IschemicStrokeEncounter?.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = context.Operators;
				var q_ = p_.ElementInInterval<CqlDateTime>(m_, o_, null);

				return q_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<MedicationRequest>(e_, f_);
			Encounter i_(MedicationRequest DischargeAntithrombotic) => IschemicStrokeEncounter;
			var k_ = g_.SelectOrNull<MedicationRequest, Encounter>(h_, i_);

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

}