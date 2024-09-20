using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.0.010")]
public class DischargedonAntithromboticTherapyFHIR_0_0_010
{

    public static DischargedonAntithromboticTherapyFHIR_0_0_010 Instance { get; }  = new();

    [CqlDeclaration("Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201")]
	public CqlValueSet Antithrombotic_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", null);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
	public CqlValueSet Comfort_Measures(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
	public CqlValueSet Hemorrhagic_Stroke(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
	public CqlValueSet Ischemic_Stroke(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public CqlValueSet Left_Against_Medical_Advice(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlDeclaration("Non-Elective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public CqlValueSet Non_Elective_Inpatient_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public CqlValueSet Patient_Refusal(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
	public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator(CqlContext context)
	{
		var a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

		return a_;
	}

    [CqlDeclaration("Antithrombotic Not Given at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge(CqlContext context)
	{
		var a_ = this.Antithrombotic_Therapy(context);
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest NoAntithromboticDischarge)
		{
			var e_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, NoAntithromboticDischarge?.DoNotPerformElement);
			var f_ = context.Operators.IsTrue(e_);
			CqlConcept g_(CodeableConcept X)
			{
				var ab_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return ab_;
			};
			var h_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((NoAntithromboticDischarge?.ReasonCode as IEnumerable<CodeableConcept>), g_);
			var i_ = this.Medical_Reason(context);
			var j_ = context.Operators.ConceptsInValueSet(h_, i_);
			CqlConcept k_(CodeableConcept X)
			{
				var ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

				return ac_;
			};
			var l_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>((NoAntithromboticDischarge?.ReasonCode as IEnumerable<CodeableConcept>), k_);
			var m_ = this.Patient_Refusal(context);
			var n_ = context.Operators.ConceptsInValueSet(l_, m_);
			var o_ = context.Operators.Or(j_, n_);
			var p_ = context.Operators.And(f_, o_);
			bool? q_(CodeableConcept C)
			{
				var ad_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
				var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
				var af_ = context.Operators.ConvertCodeToConcept(ae_);
				var ag_ = context.Operators.Equivalent(ad_, af_);
				var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
				var aj_ = context.Operators.ConvertCodeToConcept(ai_);
				var ak_ = context.Operators.Equivalent(ad_, aj_);
				var al_ = context.Operators.Or(ag_, ak_);

				return al_;
			};
			var r_ = context.Operators.WhereOrNull<CodeableConcept>((NoAntithromboticDischarge?.Category as IEnumerable<CodeableConcept>), q_);
			var s_ = context.Operators.ExistsInList<CodeableConcept>(r_);
			var t_ = context.Operators.And(p_, s_);
			var u_ = context.Operators.Convert<string>(NoAntithromboticDischarge?.StatusElement);
			var v_ = new string[]
			{
				"completed",
				"cancelled",
			};
			var w_ = context.Operators.InList<string>(u_, (v_ as IEnumerable<string>));
			var x_ = context.Operators.And(t_, w_);
			var y_ = context.Operators.Convert<string>(NoAntithromboticDischarge?.IntentElement);
			var z_ = context.Operators.Equal(y_, "order");
			var aa_ = context.Operators.And(x_, z_);

			return aa_;
		};
		var d_ = context.Operators.WhereOrNull<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter With No Antithrombotic At Discharge")]
	public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge(CqlContext context)
	{
		var a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Antithrombotic_Not_Given_at_Discharge(context);
			bool? e_(MedicationRequest NoDischargeAntithrombotic)
			{
				var i_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, NoDischargeAntithrombotic?.AuthoredOnElement);
				var j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, IschemicStrokeEncounter?.Period);
				var k_ = context.Operators.ElementInInterval<CqlDateTime>(i_, j_, null);

				return k_;
			};
			var f_ = context.Operators.WhereOrNull<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest NoDischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		var a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest Pharmacological)
		{
			var e_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, Pharmacological?.DoNotPerformElement);
			var f_ = context.Operators.IsTrue(e_);
			var g_ = context.Operators.Not(f_);
			bool? h_(CodeableConcept C)
			{
				var s_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
				var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
				var u_ = context.Operators.ConvertCodeToConcept(t_);
				var v_ = context.Operators.Equivalent(s_, u_);
				var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
				var y_ = context.Operators.ConvertCodeToConcept(x_);
				var z_ = context.Operators.Equivalent(s_, y_);
				var aa_ = context.Operators.Or(v_, z_);

				return aa_;
			};
			var i_ = context.Operators.WhereOrNull<CodeableConcept>((Pharmacological?.Category as IEnumerable<CodeableConcept>), h_);
			var j_ = context.Operators.ExistsInList<CodeableConcept>(i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = context.Operators.Convert<string>(Pharmacological?.StatusElement);
			var m_ = new string[]
			{
				"active",
				"completed",
			};
			var n_ = context.Operators.InList<string>(l_, (m_ as IEnumerable<string>));
			var o_ = context.Operators.And(k_, n_);
			var p_ = context.Operators.Convert<string>(Pharmacological?.IntentElement);
			var q_ = context.Operators.Equal(p_, "order");
			var r_ = context.Operators.And(o_, q_);

			return r_;
		};
		var d_ = context.Operators.WhereOrNull<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		var a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
			bool? e_(MedicationRequest DischargePharmacological)
			{
				var i_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, DischargePharmacological?.AuthoredOnElement);
				var j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, IschemicStrokeEncounter?.Period);
				var k_ = context.Operators.ElementInInterval<CqlDateTime>(i_, j_, null);

				return k_;
			};
			var f_ = context.Operators.WhereOrNull<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest DischargePharmacological) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
	{
		var a_ = this.Encounter_With_No_Antithrombotic_At_Discharge(context);
		var b_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
	{
		var a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
		var b_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Comfort_Measures_during_Hospitalization(context);
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		var a_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Principal_Diagnosis_and_Age(context);

		return a_;
	}

    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		var a_ = this.Antithrombotic_Therapy(context);
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest Antithrombotic)
		{
			var e_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, Antithrombotic?.DoNotPerformElement);
			var f_ = context.Operators.IsTrue(e_);
			var g_ = context.Operators.Not(f_);
			bool? h_(CodeableConcept C)
			{
				var s_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
				var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
				var u_ = context.Operators.ConvertCodeToConcept(t_);
				var v_ = context.Operators.Equivalent(s_, u_);
				var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
				var y_ = context.Operators.ConvertCodeToConcept(x_);
				var z_ = context.Operators.Equivalent(s_, y_);
				var aa_ = context.Operators.Or(v_, z_);

				return aa_;
			};
			var i_ = context.Operators.WhereOrNull<CodeableConcept>((Antithrombotic?.Category as IEnumerable<CodeableConcept>), h_);
			var j_ = context.Operators.ExistsInList<CodeableConcept>(i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = context.Operators.Convert<string>(Antithrombotic?.StatusElement);
			var m_ = new string[]
			{
				"active",
				"completed",
			};
			var n_ = context.Operators.InList<string>(l_, (m_ as IEnumerable<string>));
			var o_ = context.Operators.And(k_, n_);
			var p_ = context.Operators.Convert<string>(Antithrombotic?.IntentElement);
			var q_ = context.Operators.Equal(p_, "order");
			var r_ = context.Operators.And(o_, q_);

			return r_;
		};
		var d_ = context.Operators.WhereOrNull<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator(CqlContext context)
	{
		var a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Antithrombotic_Therapy_at_Discharge(context);
			bool? e_(MedicationRequest DischargeAntithrombotic)
			{
				var i_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, DischargeAntithrombotic?.AuthoredOnElement);
				var j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, IschemicStrokeEncounter?.Period);
				var k_ = context.Operators.ElementInInterval<CqlDateTime>(i_, j_, null);

				return k_;
			};
			var f_ = context.Operators.WhereOrNull<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest DischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

		return a_;
	}

}