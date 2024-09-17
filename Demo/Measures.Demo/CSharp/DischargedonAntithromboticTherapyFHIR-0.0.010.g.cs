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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.0.010")]
public static class DischargedonAntithromboticTherapyFHIR_0_0_010
{

    [CqlDeclaration("Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201")]
	public static CqlValueSet Antithrombotic_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", default);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
	public static CqlValueSet Comfort_Measures(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", default);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public static CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public static CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public static CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public static CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
	public static CqlValueSet Hemorrhagic_Stroke(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", default);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
	public static CqlValueSet Ischemic_Stroke(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", default);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public static CqlValueSet Left_Against_Medical_Advice(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", default);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public static CqlValueSet Medical_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", default);

    [CqlDeclaration("Non-Elective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public static CqlValueSet Non_Elective_Inpatient_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public static CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public static CqlValueSet Patient_Refusal(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", default);

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
	public static CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", default);

    [CqlDeclaration("Measurement Period")]
	public static CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public static Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Denominator")]
	public static IEnumerable<Encounter> Denominator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter(context);

		return a_;
	}

    [CqlDeclaration("Antithrombotic Not Given at Discharge")]
	public static IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge(CqlContext context)
	{
		CqlValueSet a_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Antithrombotic_Therapy(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		bool? c_(MedicationRequest NoAntithromboticDischarge)
		{
			FhirBoolean e_ = NoAntithromboticDischarge?.DoNotPerformElement;
			bool? f_ = FHIRHelpers_4_0_001.ToBoolean(context, e_);
			bool? g_ = context.Operators.IsTrue(f_);
			List<CodeableConcept> h_ = NoAntithromboticDischarge?.ReasonCode;
			CqlConcept i_(CodeableConcept X)
			{
				CqlConcept ah_ = FHIRHelpers_4_0_001.ToConcept(context, X);

				return ah_;
			};
			IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			CqlValueSet k_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Medical_Reason(context);
			bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
			CqlConcept n_(CodeableConcept X)
			{
				CqlConcept ai_ = FHIRHelpers_4_0_001.ToConcept(context, X);

				return ai_;
			};
			IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, n_);
			CqlValueSet p_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Patient_Refusal(context);
			bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
			bool? r_ = context.Operators.Or(l_, q_);
			bool? s_ = context.Operators.And(g_, r_);
			List<CodeableConcept> t_ = NoAntithromboticDischarge?.Category;
			bool? u_(CodeableConcept C)
			{
				CqlConcept aj_ = FHIRHelpers_4_0_001.ToConcept(context, C);
				CqlCode ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community(context);
				CqlConcept al_ = context.Operators.ConvertCodeToConcept(ak_);
				bool? am_ = context.Operators.Equivalent(aj_, al_);
				CqlCode ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge(context);
				CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
				bool? aq_ = context.Operators.Equivalent(aj_, ap_);
				bool? ar_ = context.Operators.Or(am_, aq_);

				return ar_;
			};
			IEnumerable<CodeableConcept> v_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)t_, u_);
			bool? w_ = context.Operators.Exists<CodeableConcept>(v_);
			bool? x_ = context.Operators.And(s_, w_);
			Code<MedicationRequest.MedicationrequestStatus> y_ = NoAntithromboticDischarge?.StatusElement;
			string z_ = FHIRHelpers_4_0_001.ToString(context, y_);
			string[] aa_ = [
				"completed",
				"cancelled",
			];
			bool? ab_ = context.Operators.In<string>(z_, aa_ as IEnumerable<string>);
			bool? ac_ = context.Operators.And(x_, ab_);
			Code<MedicationRequest.MedicationRequestIntent> ad_ = NoAntithromboticDischarge?.IntentElement;
			string ae_ = FHIRHelpers_4_0_001.ToString(context, ad_);
			bool? af_ = context.Operators.Equal(ae_, "order");
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter With No Antithrombotic At Discharge")]
	public static IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Antithrombotic_Not_Given_at_Discharge(context);
			bool? e_(MedicationRequest NoDischargeAntithrombotic)
			{
				FhirDateTime i_ = NoDischargeAntithrombotic?.AuthoredOnElement;
				CqlDateTime j_ = FHIRHelpers_4_0_001.ToDateTime(context, i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(context, k_);
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

    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public static IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		CqlValueSet a_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		bool? c_(MedicationRequest Pharmacological)
		{
			FhirBoolean e_ = Pharmacological?.DoNotPerformElement;
			bool? f_ = FHIRHelpers_4_0_001.ToBoolean(context, e_);
			bool? g_ = context.Operators.IsTrue(f_);
			bool? h_ = context.Operators.Not(g_);
			List<CodeableConcept> i_ = Pharmacological?.Category;
			bool? j_(CodeableConcept C)
			{
				CqlConcept w_ = FHIRHelpers_4_0_001.ToConcept(context, C);
				CqlCode x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community(context);
				CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
				bool? z_ = context.Operators.Equivalent(w_, y_);
				CqlCode ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge(context);
				CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
				bool? ad_ = context.Operators.Equivalent(w_, ac_);
				bool? ae_ = context.Operators.Or(z_, ad_);

				return ae_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			Code<MedicationRequest.MedicationrequestStatus> n_ = Pharmacological?.StatusElement;
			string o_ = FHIRHelpers_4_0_001.ToString(context, n_);
			string[] p_ = [
				"active",
				"completed",
			];
			bool? q_ = context.Operators.In<string>(o_, p_ as IEnumerable<string>);
			bool? r_ = context.Operators.And(m_, q_);
			Code<MedicationRequest.MedicationRequestIntent> s_ = Pharmacological?.IntentElement;
			string t_ = FHIRHelpers_4_0_001.ToString(context, s_);
			bool? u_ = context.Operators.Equal(t_, "order");
			bool? v_ = context.Operators.And(r_, u_);

			return v_;
		};
		IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public static IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
			bool? e_(MedicationRequest DischargePharmacological)
			{
				FhirDateTime i_ = DischargePharmacological?.AuthoredOnElement;
				CqlDateTime j_ = FHIRHelpers_4_0_001.ToDateTime(context, i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(context, k_);
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

    [CqlDeclaration("Denominator Exceptions")]
	public static IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Encounter_With_No_Antithrombotic_At_Discharge(context);
		IEnumerable<Encounter> b_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public static IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
		IEnumerable<Encounter> b_ = TJCOverallFHIR_1_8_000.Encounter_with_Comfort_Measures_during_Hospitalization(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public static IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Encounter_with_Principal_Diagnosis_and_Age(context);

		return a_;
	}

    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
	public static IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		CqlValueSet a_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Antithrombotic_Therapy(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		bool? c_(MedicationRequest Antithrombotic)
		{
			FhirBoolean e_ = Antithrombotic?.DoNotPerformElement;
			bool? f_ = FHIRHelpers_4_0_001.ToBoolean(context, e_);
			bool? g_ = context.Operators.IsTrue(f_);
			bool? h_ = context.Operators.Not(g_);
			List<CodeableConcept> i_ = Antithrombotic?.Category;
			bool? j_(CodeableConcept C)
			{
				CqlConcept w_ = FHIRHelpers_4_0_001.ToConcept(context, C);
				CqlCode x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community(context);
				CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
				bool? z_ = context.Operators.Equivalent(w_, y_);
				CqlCode ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge(context);
				CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
				bool? ad_ = context.Operators.Equivalent(w_, ac_);
				bool? ae_ = context.Operators.Or(z_, ad_);

				return ae_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			Code<MedicationRequest.MedicationrequestStatus> n_ = Antithrombotic?.StatusElement;
			string o_ = FHIRHelpers_4_0_001.ToString(context, n_);
			string[] p_ = [
				"active",
				"completed",
			];
			bool? q_ = context.Operators.In<string>(o_, p_ as IEnumerable<string>);
			bool? r_ = context.Operators.And(m_, q_);
			Code<MedicationRequest.MedicationRequestIntent> s_ = Antithrombotic?.IntentElement;
			string t_ = FHIRHelpers_4_0_001.ToString(context, s_);
			bool? u_ = context.Operators.Equal(t_, "order");
			bool? v_ = context.Operators.And(r_, u_);

			return v_;
		};
		IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
	public static IEnumerable<Encounter> Numerator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = DischargedonAntithromboticTherapyFHIR_0_0_010.Antithrombotic_Therapy_at_Discharge(context);
			bool? e_(MedicationRequest DischargeAntithrombotic)
			{
				FhirDateTime i_ = DischargeAntithrombotic?.AuthoredOnElement;
				CqlDateTime j_ = FHIRHelpers_4_0_001.ToDateTime(context, i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(context, k_);
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

    [CqlDeclaration("SDE Ethnicity")]
	public static IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public static IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public static IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public static CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex(context);

		return a_;
	}

}
