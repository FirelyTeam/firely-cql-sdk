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

    private CqlValueSet Antithrombotic_Therapy_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", null);

		return a_;
	}

    [CqlDeclaration("Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201")]
    public CqlValueSet Antithrombotic_Therapy() => __Antithrombotic_Therapy.Value;

    private CqlValueSet Comfort_Measures_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

		return a_;
	}

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
    public CqlValueSet Comfort_Measures() => __Comfort_Measures.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

		return a_;
	}

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

		return a_;
	}

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

		return a_;
	}

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

		return a_;
	}

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Hemorrhagic_Stroke_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

		return a_;
	}

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
    public CqlValueSet Hemorrhagic_Stroke() => __Hemorrhagic_Stroke.Value;

    private CqlValueSet Ischemic_Stroke_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

		return a_;
	}

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
    public CqlValueSet Ischemic_Stroke() => __Ischemic_Stroke.Value;

    private CqlValueSet Left_Against_Medical_Advice_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

		return a_;
	}

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
    public CqlValueSet Left_Against_Medical_Advice() => __Left_Against_Medical_Advice.Value;

    private CqlValueSet Medical_Reason_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

		return a_;
	}

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
    public CqlValueSet Medical_Reason() => __Medical_Reason.Value;

    private CqlValueSet Non_Elective_Inpatient_Encounter_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

		return a_;
	}

    [CqlDeclaration("Non-Elective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
    public CqlValueSet Non_Elective_Inpatient_Encounter() => __Non_Elective_Inpatient_Encounter.Value;

    private CqlValueSet Patient_Expired_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

		return a_;
	}

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Patient_Refusal_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

		return a_;
	}

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
    public CqlValueSet Patient_Refusal() => __Patient_Refusal.Value;

    private CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

		return a_;
	}

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy() => __Pharmacological_Contraindications_For_Antithrombotic_Therapy.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);
		var b_ = (CqlInterval<CqlDateTime>)a_;

		return b_;
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
		var d_ = (MedicationRequest NoAntithromboticDischarge) =>
		{
			var g_ = NoAntithromboticDischarge.DoNotPerformElement;
			var h_ = FHIRHelpers_4_0_001.ToBoolean(g_);
			var i_ = context.Operators;
			var j_ = i_.IsTrue(h_);
			var k_ = NoAntithromboticDischarge.ReasonCode;
			var l_ = (k_ as IEnumerable<CodeableConcept>);
			var m_ = (CodeableConcept X) =>
			{
				var bj_ = FHIRHelpers_4_0_001.ToConcept(X);

				return bj_;
			};
			var o_ = i_.SelectOrNull<CodeableConcept, CqlConcept>(l_, m_);
			var p_ = this.Medical_Reason();
			var r_ = i_.ConceptsInValueSet(o_, p_);
			var t_ = (k_ as IEnumerable<CodeableConcept>);
			var u_ = (CodeableConcept X) =>
			{
				var bk_ = FHIRHelpers_4_0_001.ToConcept(X);

				return bk_;
			};
			var w_ = i_.SelectOrNull<CodeableConcept, CqlConcept>(t_, u_);
			var x_ = this.Patient_Refusal();
			var z_ = i_.ConceptsInValueSet(w_, x_);
			var ab_ = i_.Or(r_, z_);
			var ad_ = i_.And(j_, ab_);
			var ae_ = NoAntithromboticDischarge.Category;
			var af_ = (ae_ as IEnumerable<CodeableConcept>);
			var ag_ = (CodeableConcept C) =>
			{
				var bl_ = FHIRHelpers_4_0_001.ToConcept(C);
				var bm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var bn_ = context.Operators;
				var bo_ = bn_.ConvertCodeToConcept(bm_);
				var bq_ = bn_.Equivalent(bl_, bo_);
				var bs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var bu_ = bn_.ConvertCodeToConcept(bs_);
				var bw_ = bn_.Equivalent(bl_, bu_);
				var by_ = bn_.Or(bq_, bw_);

				return by_;
			};
			var ai_ = i_.WhereOrNull<CodeableConcept>(af_, ag_);
			var ak_ = i_.ExistsInList<CodeableConcept>(ai_);
			var am_ = i_.And(ad_, ak_);
			var an_ = NoAntithromboticDischarge.StatusElement;
			var ao_ = new CallStackEntry("ToString", null, null);
			var ap_ = context.Deeper(ao_);
			var aq_ = ap_.Operators;
			var ar_ = aq_.TypeConverter;
			var as_ = ar_.Convert<string>(an_);
			var at_ = new string[]
			{
				"completed",
				"cancelled",
			};
			var au_ = (at_ as IEnumerable<string>);
			var aw_ = i_.InList<string>(as_, au_);
			var ay_ = i_.And(am_, aw_);
			var az_ = NoAntithromboticDischarge.IntentElement;
			var bb_ = context.Deeper(ao_);
			var bc_ = bb_.Operators;
			var bd_ = bc_.TypeConverter;
			var be_ = bd_.Convert<string>(az_);
			var bg_ = i_.Equal(be_, "order");
			var bi_ = i_.And(ay_, bg_);

			return bi_;
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
		var b_ = (Encounter IschemicStrokeEncounter) =>
		{
			var e_ = this.Antithrombotic_Not_Given_at_Discharge();
			var f_ = (MedicationRequest NoDischargeAntithrombotic) =>
			{
				var l_ = NoDischargeAntithrombotic.AuthoredOnElement;
				var m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
				var n_ = IschemicStrokeEncounter.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = context.Operators;
				var q_ = p_.ElementInInterval<CqlDateTime>(m_, o_, null);

				return q_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<MedicationRequest>(e_, f_);
			var i_ = (MedicationRequest NoDischargeAntithrombotic) => IschemicStrokeEncounter;
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
		var d_ = (MedicationRequest Pharmacological) =>
		{
			var g_ = Pharmacological.DoNotPerformElement;
			var h_ = FHIRHelpers_4_0_001.ToBoolean(g_);
			var i_ = context.Operators;
			var j_ = i_.IsTrue(h_);
			var l_ = i_.Not(j_);
			var m_ = Pharmacological.Category;
			var n_ = (m_ as IEnumerable<CodeableConcept>);
			var o_ = (CodeableConcept C) =>
			{
				var ar_ = FHIRHelpers_4_0_001.ToConcept(C);
				var as_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var at_ = context.Operators;
				var au_ = at_.ConvertCodeToConcept(as_);
				var aw_ = at_.Equivalent(ar_, au_);
				var ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ba_ = at_.ConvertCodeToConcept(ay_);
				var bc_ = at_.Equivalent(ar_, ba_);
				var be_ = at_.Or(aw_, bc_);

				return be_;
			};
			var q_ = i_.WhereOrNull<CodeableConcept>(n_, o_);
			var s_ = i_.ExistsInList<CodeableConcept>(q_);
			var u_ = i_.And(l_, s_);
			var v_ = Pharmacological.StatusElement;
			var w_ = new CallStackEntry("ToString", null, null);
			var x_ = context.Deeper(w_);
			var y_ = x_.Operators;
			var z_ = y_.TypeConverter;
			var aa_ = z_.Convert<string>(v_);
			var ab_ = new string[]
			{
				"active",
				"completed",
			};
			var ac_ = (ab_ as IEnumerable<string>);
			var ae_ = i_.InList<string>(aa_, ac_);
			var ag_ = i_.And(u_, ae_);
			var ah_ = Pharmacological.IntentElement;
			var aj_ = context.Deeper(w_);
			var ak_ = aj_.Operators;
			var al_ = ak_.TypeConverter;
			var am_ = al_.Convert<string>(ah_);
			var ao_ = i_.Equal(am_, "order");
			var aq_ = i_.And(ag_, ao_);

			return aq_;
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
		var b_ = (Encounter IschemicStrokeEncounter) =>
		{
			var e_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
			var f_ = (MedicationRequest DischargePharmacological) =>
			{
				var l_ = DischargePharmacological.AuthoredOnElement;
				var m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
				var n_ = IschemicStrokeEncounter.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = context.Operators;
				var q_ = p_.ElementInInterval<CqlDateTime>(m_, o_, null);

				return q_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<MedicationRequest>(e_, f_);
			var i_ = (MedicationRequest DischargePharmacological) => IschemicStrokeEncounter;
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
		var d_ = (MedicationRequest Antithrombotic) =>
		{
			var g_ = Antithrombotic.DoNotPerformElement;
			var h_ = FHIRHelpers_4_0_001.ToBoolean(g_);
			var i_ = context.Operators;
			var j_ = i_.IsTrue(h_);
			var l_ = i_.Not(j_);
			var m_ = Antithrombotic.Category;
			var n_ = (m_ as IEnumerable<CodeableConcept>);
			var o_ = (CodeableConcept C) =>
			{
				var ar_ = FHIRHelpers_4_0_001.ToConcept(C);
				var as_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
				var at_ = context.Operators;
				var au_ = at_.ConvertCodeToConcept(as_);
				var aw_ = at_.Equivalent(ar_, au_);
				var ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
				var ba_ = at_.ConvertCodeToConcept(ay_);
				var bc_ = at_.Equivalent(ar_, ba_);
				var be_ = at_.Or(aw_, bc_);

				return be_;
			};
			var q_ = i_.WhereOrNull<CodeableConcept>(n_, o_);
			var s_ = i_.ExistsInList<CodeableConcept>(q_);
			var u_ = i_.And(l_, s_);
			var v_ = Antithrombotic.StatusElement;
			var w_ = new CallStackEntry("ToString", null, null);
			var x_ = context.Deeper(w_);
			var y_ = x_.Operators;
			var z_ = y_.TypeConverter;
			var aa_ = z_.Convert<string>(v_);
			var ab_ = new string[]
			{
				"active",
				"completed",
			};
			var ac_ = (ab_ as IEnumerable<string>);
			var ae_ = i_.InList<string>(aa_, ac_);
			var ag_ = i_.And(u_, ae_);
			var ah_ = Antithrombotic.IntentElement;
			var aj_ = context.Deeper(w_);
			var ak_ = aj_.Operators;
			var al_ = ak_.TypeConverter;
			var am_ = al_.Convert<string>(ah_);
			var ao_ = i_.Equal(am_, "order");
			var aq_ = i_.And(ag_, ao_);

			return aq_;
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
		var b_ = (Encounter IschemicStrokeEncounter) =>
		{
			var e_ = this.Antithrombotic_Therapy_at_Discharge();
			var f_ = (MedicationRequest DischargeAntithrombotic) =>
			{
				var l_ = DischargeAntithrombotic.AuthoredOnElement;
				var m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
				var n_ = IschemicStrokeEncounter.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = context.Operators;
				var q_ = p_.ElementInInterval<CqlDateTime>(m_, o_, null);

				return q_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<MedicationRequest>(e_, f_);
			var i_ = (MedicationRequest DischargeAntithrombotic) => IschemicStrokeEncounter;
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