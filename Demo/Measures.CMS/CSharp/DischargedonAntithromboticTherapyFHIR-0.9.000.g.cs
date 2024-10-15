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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.9.000")]
public partial class DischargedonAntithromboticTherapyFHIR_0_9_000 : ILibrary, ISingleton<DischargedonAntithromboticTherapyFHIR_0_9_000>
{
    private DischargedonAntithromboticTherapyFHIR_0_9_000() {}

    public static DischargedonAntithromboticTherapyFHIR_0_9_000 Instance { get; } = new();

    #region Library Members
    public string Name => "DischargedonAntithromboticTherapyFHIR";
    public string Version => "0.9.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, CQMCommon_2_0_000.Instance, QICoreCommon_2_0_000.Instance, SupplementalDataElements_3_4_000.Instance, TJCOverall_8_11_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Antithrombotic Therapy for Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62")]
	public CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", default);


    [CqlDeclaration("Medical Reason For Not Providing Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason_For_Not_Providing_Treatment(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", default);


    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public CqlValueSet Patient_Refusal(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", default);


    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
	public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", default);


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.9.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Instance.Encounter_with_Principal_Diagnosis_and_Age(context);

		return a_;
	}


    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Instance.Ischemic_Stroke_Encounter(context);

		return a_;
	}


    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization for Patients with Documented Ischemic Stroke")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Denominator(context);
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			IEnumerable<object> d_ = TJCOverall_8_11_000.Instance.Intervention_Comfort_Measures(context);
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.Instance.toInterval(context, j_);
				CqlDateTime l_ = context.Operators.Start(k_);
				object m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.Instance.hospitalizationWithObservation(context, Encounter);
				bool? p_ = context.Operators.In<CqlDateTime>(l_ ?? n_, o_, default);

				return p_;
			};
			IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				Encounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
		IEnumerable<Encounter> b_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Instance.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			CqlValueSet d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
			IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest DischargeAntithrombotic)
			{
				FhirDateTime m_ = DischargeAntithrombotic?.AuthoredOnElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
				bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, default);

				return q_;
			};
			IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest DischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest Antithrombotic)
		{
			bool? h_ = QICoreCommon_2_0_000.Instance.isCommunity(context, Antithrombotic);
			bool? i_ = QICoreCommon_2_0_000.Instance.isDischarge(context, Antithrombotic);
			bool? j_ = context.Operators.Or(h_, i_);
			Code<MedicationRequest.MedicationrequestStatus> k_ = Antithrombotic?.StatusElement;
			MedicationRequest.MedicationrequestStatus? l_ = k_?.Value;
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = [
				"active",
				"completed",
			];
			bool? o_ = context.Operators.In<string>(m_, n_ as IEnumerable<string>);
			bool? p_ = context.Operators.And(j_, o_);
			Code<MedicationRequest.MedicationRequestIntent> q_ = Antithrombotic?.IntentElement;
			MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(p_, u_);
			FhirBoolean w_ = Antithrombotic?.DoNotPerformElement;
			bool? x_ = w_?.Value;
			bool? y_ = context.Operators.IsTrue(x_);
			bool? z_ = context.Operators.Not(y_);
			bool? aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Reason for Not Giving Antithrombotic at Discharge")]
	public IEnumerable<MedicationRequest> Reason_for_Not_Giving_Antithrombotic_at_Discharge(CqlContext context)
	{
		CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest NoAntithromboticDischarge)
		{
			List<CodeableConcept> h_ = NoAntithromboticDischarge?.ReasonCode;
			CqlConcept i_(CodeableConcept @this)
			{
				CqlConcept ac_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ac_;
			};
			IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			CqlValueSet k_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
			bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
			CqlConcept n_(CodeableConcept @this)
			{
				CqlConcept ad_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ad_;
			};
			IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, n_);
			CqlValueSet p_ = this.Patient_Refusal(context);
			bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
			bool? r_ = context.Operators.Or(l_, q_);
			bool? s_ = QICoreCommon_2_0_000.Instance.isCommunity(context, NoAntithromboticDischarge);
			bool? t_ = QICoreCommon_2_0_000.Instance.isDischarge(context, NoAntithromboticDischarge);
			bool? u_ = context.Operators.Or(s_, t_);
			bool? v_ = context.Operators.And(r_, u_);
			Code<MedicationRequest.MedicationRequestIntent> w_ = NoAntithromboticDischarge?.IntentElement;
			MedicationRequest.MedicationRequestIntent? x_ = w_?.Value;
			string y_ = context.Operators.Convert<string>(x_);
			string[] z_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? aa_ = context.Operators.In<string>(y_, z_ as IEnumerable<string>);
			bool? ab_ = context.Operators.And(v_, aa_);

			return ab_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Encounter with Documented Reason for No Antithrombotic At Discharge")]
	public IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Instance.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = this.Reason_for_Not_Giving_Antithrombotic_at_Discharge(context);
			bool? e_(MedicationRequest NoDischargeAntithrombotic)
			{
				FhirDateTime i_ = NoDischargeAntithrombotic?.AuthoredOnElement;
				CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, k_);
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
	public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		CqlValueSet a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest Pharmacological)
		{
			bool? h_ = QICoreCommon_2_0_000.Instance.isCommunity(context, Pharmacological);
			bool? i_ = QICoreCommon_2_0_000.Instance.isDischarge(context, Pharmacological);
			bool? j_ = context.Operators.Or(h_, i_);
			Code<MedicationRequest.MedicationrequestStatus> k_ = Pharmacological?.StatusElement;
			MedicationRequest.MedicationrequestStatus? l_ = k_?.Value;
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = [
				"active",
				"completed",
			];
			bool? o_ = context.Operators.In<string>(m_, n_ as IEnumerable<string>);
			bool? p_ = context.Operators.And(j_, o_);
			Code<MedicationRequest.MedicationRequestIntent> q_ = Pharmacological?.IntentElement;
			MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(p_, u_);
			FhirBoolean w_ = Pharmacological?.DoNotPerformElement;
			bool? x_ = w_?.Value;
			bool? y_ = context.Operators.IsTrue(x_);
			bool? z_ = context.Operators.Not(y_);
			bool? aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Encounter with Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Instance.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
			bool? e_(MedicationRequest DischargePharmacological)
			{
				FhirDateTime i_ = DischargePharmacological?.AuthoredOnElement;
				CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, k_);
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
	public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge(context);
		IEnumerable<Encounter> b_ = this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

}
