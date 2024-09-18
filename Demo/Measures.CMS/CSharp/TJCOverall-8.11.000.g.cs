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

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("TJCOverall", "8.11.000")]
public class TJCOverall_8_11_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000)
{

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
	public  CqlValueSet Comfort_Measures(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", default);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public  CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public  CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public  CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
	public  CqlValueSet Hemorrhagic_Stroke(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", default);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
	public  CqlValueSet Ischemic_Stroke(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", default);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
	public  CqlValueSet Left_Against_Medical_Advice(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", default);

    [CqlDeclaration("Nonelective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public  CqlValueSet Nonelective_Inpatient_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public  CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("TJCOverall-8.11.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Non Elective Inpatient Encounter")]
	public  IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context)
	{
		CqlValueSet a_ = this.Nonelective_Inpatient_Encounter(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter NonElectiveEncounter)
		{
			Period e_ = NonElectiveEncounter?.Period;
			CqlInterval<CqlDateTime> f_ = fhirHelpers_4_3_000.ToInterval(context, e_);
			CqlDateTime g_ = context.Operators.End(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");

			return i_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("All Stroke Encounter")]
	public  IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Non_Elective_Inpatient_Encounter(context);
		bool? b_(Encounter NonElectiveEncounter)
		{
			Condition d_ = cqmCommon_2_0_000.principalDiagnosis(context, NonElectiveEncounter);
			CodeableConcept e_ = d_?.Code;
			CqlConcept f_ = fhirHelpers_4_3_000.ToConcept(context, e_);
			CqlValueSet g_ = this.Hemorrhagic_Stroke(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
			CodeableConcept j_ = d_?.Code;
			CqlConcept k_ = fhirHelpers_4_3_000.ToConcept(context, j_);
			CqlValueSet l_ = this.Ischemic_Stroke(context);
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
			bool? n_ = context.Operators.Or(h_, m_);

			return n_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
	public  IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.All_Stroke_Encounter(context);
		bool? b_(Encounter AllStrokeEncounter)
		{
			Patient d_ = this.Patient(context);
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.ConvertStringToDate(f_);
			Period h_ = AllStrokeEncounter?.Period;
			CqlInterval<CqlDateTime> i_ = fhirHelpers_4_3_000.ToInterval(context, h_);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlDate k_ = context.Operators.DateFrom(j_);
			int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
			bool? m_ = context.Operators.GreaterOrEqual(l_, 18);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounter")]
	public  IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Principal_Diagnosis_and_Age(context);
		bool? b_(Encounter EncounterWithAge)
		{
			Condition d_ = cqmCommon_2_0_000.principalDiagnosis(context, EncounterWithAge);
			CodeableConcept e_ = d_?.Code;
			CqlConcept f_ = fhirHelpers_4_3_000.ToConcept(context, e_);
			CqlValueSet g_ = this.Ischemic_Stroke(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
	public  IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			Encounter.HospitalizationComponent d_ = IschemicStrokeEncounter?.Hospitalization;
			CodeableConcept e_ = d_?.DischargeDisposition;
			CqlConcept f_ = fhirHelpers_4_3_000.ToConcept(context, e_);
			CqlValueSet g_ = this.Discharge_To_Acute_Care_Facility(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
			CodeableConcept j_ = d_?.DischargeDisposition;
			CqlConcept k_ = fhirHelpers_4_3_000.ToConcept(context, j_);
			CqlValueSet l_ = this.Left_Against_Medical_Advice(context);
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
			bool? n_ = context.Operators.Or(h_, m_);
			CodeableConcept p_ = d_?.DischargeDisposition;
			CqlConcept q_ = fhirHelpers_4_3_000.ToConcept(context, p_);
			CqlValueSet r_ = this.Patient_Expired(context);
			bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
			bool? t_ = context.Operators.Or(n_, s_);
			CodeableConcept v_ = d_?.DischargeDisposition;
			CqlConcept w_ = fhirHelpers_4_3_000.ToConcept(context, v_);
			CqlValueSet x_ = this.Discharged_to_Home_for_Hospice_Care(context);
			bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
			bool? z_ = context.Operators.Or(t_, y_);
			CodeableConcept ab_ = d_?.DischargeDisposition;
			CqlConcept ac_ = fhirHelpers_4_3_000.ToConcept(context, ab_);
			CqlValueSet ad_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
			bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
			bool? af_ = context.Operators.Or(z_, ae_);

			return af_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Intervention Comfort Measures")]
	public  IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
	{
		CqlValueSet a_ = this.Comfort_Measures(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		bool? c_(ServiceRequest SR)
		{
			Code<RequestStatus> j_ = SR?.StatusElement;
			RequestStatus? k_ = j_?.Value;
			Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = [
				"active",
				"completed",
				"on-hold",
			];
			bool? o_ = context.Operators.In<string>(m_, n_ as IEnumerable<string>);
			Code<RequestIntent> p_ = SR?.IntentElement;
			RequestIntent? q_ = p_?.Value;
			Code<RequestIntent> r_ = context.Operators.Convert<Code<RequestIntent>>(q_);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(o_, u_);
			FhirBoolean w_ = SR?.DoNotPerformElement;
			bool? x_ = w_?.Value;
			bool? y_ = context.Operators.IsTrue(x_);
			bool? z_ = context.Operators.Not(y_);
			bool? aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
		IEnumerable<Procedure> f_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? g_(Procedure InterventionPerformed)
		{
			Code<EventStatus> ab_ = InterventionPerformed?.StatusElement;
			EventStatus? ac_ = ab_?.Value;
			string ad_ = context.Operators.Convert<string>(ac_);
			string[] ae_ = [
				"completed",
				"in-progress",
			];
			bool? af_ = context.Operators.In<string>(ad_, ae_ as IEnumerable<string>);

			return af_;
		};
		IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
		IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);

		return i_;
	}

    [CqlDeclaration("Comfort Measures during Hospitalization")]
	public  IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				object j_ = fhirHelpers_4_3_000.ToValue(context, i_);
				CqlInterval<CqlDateTime> k_ = qiCoreCommon_2_0_000.toInterval(context, j_);
				CqlDateTime l_ = context.Operators.Start(k_);
				object m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				CqlInterval<CqlDateTime> o_ = cqmCommon_2_0_000.hospitalizationWithObservation(context, IschemicStrokeEncounter);
				bool? p_ = context.Operators.In<CqlDateTime>(l_ ?? n_, o_, default);

				return p_;
			};
			IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
	public  IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				object j_ = fhirHelpers_4_3_000.ToValue(context, i_);
				CqlInterval<CqlDateTime> k_ = qiCoreCommon_2_0_000.toInterval(context, j_);
				CqlDateTime l_ = context.Operators.Start(k_);
				object m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				CqlInterval<CqlDateTime> o_ = cqmCommon_2_0_000.hospitalizationWithObservation(context, IschemicStrokeEncounter);
				bool? p_ = context.Operators.In<CqlDateTime>(l_ ?? n_, o_, default);

				return p_;
			};
			IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public  CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
	{
		CqlDate a_ = context.Operators.DateFrom(StartValue);
		CqlQuantity c_ = context.Operators.Quantity(1m, "day");
		CqlDate d_ = context.Operators.Add(a_, c_);
		CqlInterval<CqlDate> e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

}
