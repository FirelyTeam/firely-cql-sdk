﻿using System;
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
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.9.000")]
public class DischargedonAntithromboticTherapyFHIR_0_9_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Antithrombotic_Therapy_for_Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Medical_Reason_For_Not_Providing_Treatment;
    internal Lazy<CqlValueSet> __Patient_Refusal;
    internal Lazy<CqlValueSet> __Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<MedicationRequest>> __Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<MedicationRequest>> __Reason_for_Not_Giving_Antithrombotic_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge;
    internal Lazy<IEnumerable<MedicationRequest>> __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exceptions;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public DischargedonAntithromboticTherapyFHIR_0_9_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        TJCOverall_8_11_000 = new TJCOverall_8_11_000(context);

        __Antithrombotic_Therapy_for_Ischemic_Stroke = new Lazy<CqlValueSet>(this.Antithrombotic_Therapy_for_Ischemic_Stroke_Value);
        __Medical_Reason_For_Not_Providing_Treatment = new Lazy<CqlValueSet>(this.Medical_Reason_For_Not_Providing_Treatment_Value);
        __Patient_Refusal = new Lazy<CqlValueSet>(this.Patient_Refusal_Value);
        __Pharmacological_Contraindications_For_Antithrombotic_Therapy = new Lazy<CqlValueSet>(this.Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Antithrombotic_Therapy_at_Discharge_Value);
        __Reason_for_Not_Giving_Antithrombotic_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Reason_for_Not_Giving_Antithrombotic_at_Discharge_Value);
        __Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge_Value);
        __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value);
        __Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value);
        __Denominator_Exceptions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exceptions_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public TJCOverall_8_11_000 TJCOverall_8_11_000 { get; }

    #endregion

	private CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", null);

    [CqlDeclaration("Antithrombotic Therapy for Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62")]
	public CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke() => 
		__Antithrombotic_Therapy_for_Ischemic_Stroke.Value;

	private CqlValueSet Medical_Reason_For_Not_Providing_Treatment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlDeclaration("Medical Reason For Not Providing Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason_For_Not_Providing_Treatment() => 
		__Medical_Reason_For_Not_Providing_Treatment.Value;

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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.9.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = TJCOverall_8_11_000.Encounter_with_Principal_Diagnosis_and_Age();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			var d_ = TJCOverall_8_11_000.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				var i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var j_ = FHIRHelpers_4_3_000.ToValue(i_);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				var n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				var o_ = CQMCommon_2_0_000.hospitalizationWithObservation(Encounter);
				var p_ = context.Operators.In<CqlDateTime>((l_ ?? n_), o_, null);

				return p_;
			};
			var f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				Encounter;
			var h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization for Patients with Documented Ischemic Stroke")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke() => 
		__Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounters_with_Discharge_Disposition();
		var b_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
			var e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest DischargeAntithrombotic)
			{
				var m_ = DischargeAntithrombotic?.AuthoredOnElement;
				var n_ = context.Operators.Convert<CqlDateTime>(m_);
				var o_ = IschemicStrokeEncounter?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.In<CqlDateTime>(n_, p_, null);

				return q_;
			};
			var j_ = context.Operators.Where<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest DischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			var l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest Antithrombotic)
		{
			var h_ = QICoreCommon_2_0_000.isCommunity(Antithrombotic);
			var i_ = QICoreCommon_2_0_000.isDischarge(Antithrombotic);
			var j_ = context.Operators.Or(h_, i_);
			var k_ = Antithrombotic?.StatusElement;
			var l_ = k_?.Value;
			var m_ = context.Operators.Convert<string>(l_);
			var n_ = new string[]
			{
				"active",
				"completed",
			};
			var o_ = context.Operators.In<string>(m_, (n_ as IEnumerable<string>));
			var p_ = context.Operators.And(j_, o_);
			var q_ = Antithrombotic?.IntentElement;
			var r_ = q_?.Value;
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			var u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(p_, u_);
			var w_ = Antithrombotic?.DoNotPerformElement;
			var x_ = w_?.Value;
			var y_ = context.Operators.IsTrue(x_);
			var z_ = context.Operators.Not(y_);
			var aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		var g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge() => 
		__Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<MedicationRequest> Reason_for_Not_Giving_Antithrombotic_at_Discharge_Value()
	{
		var a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest NoAntithromboticDischarge)
		{
			var h_ = NoAntithromboticDischarge?.ReasonCode;
			CqlConcept i_(CodeableConcept @this)
			{
				var ac_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ac_;
			};
			var j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			var k_ = this.Medical_Reason_For_Not_Providing_Treatment();
			var l_ = context.Operators.ConceptsInValueSet(j_, k_);
			CqlConcept n_(CodeableConcept @this)
			{
				var ad_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ad_;
			};
			var o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, n_);
			var p_ = this.Patient_Refusal();
			var q_ = context.Operators.ConceptsInValueSet(o_, p_);
			var r_ = context.Operators.Or(l_, q_);
			var s_ = QICoreCommon_2_0_000.isCommunity(NoAntithromboticDischarge);
			var t_ = QICoreCommon_2_0_000.isDischarge(NoAntithromboticDischarge);
			var u_ = context.Operators.Or(s_, t_);
			var v_ = context.Operators.And(r_, u_);
			var w_ = NoAntithromboticDischarge?.IntentElement;
			var x_ = w_?.Value;
			var y_ = context.Operators.Convert<string>(x_);
			var z_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			var aa_ = context.Operators.In<string>(y_, (z_ as IEnumerable<string>));
			var ab_ = context.Operators.And(v_, aa_);

			return ab_;
		};
		var g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Reason for Not Giving Antithrombotic at Discharge")]
	public IEnumerable<MedicationRequest> Reason_for_Not_Giving_Antithrombotic_at_Discharge() => 
		__Reason_for_Not_Giving_Antithrombotic_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Reason_for_Not_Giving_Antithrombotic_at_Discharge();
			bool? e_(MedicationRequest NoDischargeAntithrombotic)
			{
				var i_ = NoDischargeAntithrombotic?.AuthoredOnElement;
				var j_ = context.Operators.Convert<CqlDateTime>(i_);
				var k_ = IschemicStrokeEncounter?.Period;
				var l_ = FHIRHelpers_4_3_000.ToInterval(k_);
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

    [CqlDeclaration("Encounter with Documented Reason for No Antithrombotic At Discharge")]
	public IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge() => 
		__Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge.Value;

	private IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest Pharmacological)
		{
			var h_ = QICoreCommon_2_0_000.isCommunity(Pharmacological);
			var i_ = QICoreCommon_2_0_000.isDischarge(Pharmacological);
			var j_ = context.Operators.Or(h_, i_);
			var k_ = Pharmacological?.StatusElement;
			var l_ = k_?.Value;
			var m_ = context.Operators.Convert<string>(l_);
			var n_ = new string[]
			{
				"active",
				"completed",
			};
			var o_ = context.Operators.In<string>(m_, (n_ as IEnumerable<string>));
			var p_ = context.Operators.And(j_, o_);
			var q_ = Pharmacological?.IntentElement;
			var r_ = q_?.Value;
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			var u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(p_, u_);
			var w_ = Pharmacological?.DoNotPerformElement;
			var x_ = w_?.Value;
			var y_ = context.Operators.IsTrue(x_);
			var z_ = context.Operators.Not(y_);
			var aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		var g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
			bool? e_(MedicationRequest DischargePharmacological)
			{
				var i_ = DischargePharmacological?.AuthoredOnElement;
				var j_ = context.Operators.Convert<CqlDateTime>(i_);
				var k_ = IschemicStrokeEncounter?.Period;
				var l_ = FHIRHelpers_4_3_000.ToInterval(k_);
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

    [CqlDeclaration("Encounter with Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		var a_ = this.Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge();
		var b_ = this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
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