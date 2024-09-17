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
[CqlLibrary("TJCOverallFHIR", "1.8.000")]
public static class TJCOverallFHIR_1_8_000
{

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

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public static CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

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

    [CqlDeclaration("Non-Elective Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public static CqlValueSet Non_Elective_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public static CqlValueSet Observation_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public static CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Ticagrelor Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39")]
	public static CqlValueSet Ticagrelor_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", default);

    [CqlDeclaration("Birth date")]
	public static CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
	public static CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public static CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public static Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Non Elective Inpatient Encounter")]
	public static IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context)
	{
		CqlValueSet a_ = TJCOverallFHIR_1_8_000.Non_Elective_Inpatient(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter NonElectiveEncounter)
		{
			Period e_ = NonElectiveEncounter?.Period;
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.ToInterval(context, e_);
			int? g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.LengthInDays(context, f_);
			bool? h_ = context.Operators.LessOrEqual(g_, 120);
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.ToInterval(context, e_);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = TJCOverallFHIR_1_8_000.Measurement_Period(context);
			bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("All Stroke Encounter")]
	public static IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Non_Elective_Inpatient_Encounter(context);
		bool? b_(Encounter NonElectiveEncounter)
		{
			Condition d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(context, NonElectiveEncounter);
			CodeableConcept e_ = d_?.Code;
			CqlConcept f_ = FHIRHelpers_4_0_001.ToConcept(context, e_);
			CqlValueSet g_ = TJCOverallFHIR_1_8_000.Hemorrhagic_Stroke(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
			CodeableConcept j_ = d_?.Code;
			CqlConcept k_ = FHIRHelpers_4_0_001.ToConcept(context, j_);
			CqlValueSet l_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke(context);
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
			bool? n_ = context.Operators.Or(h_, m_);

			return n_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
	public static IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.All_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter AllStrokeEncounter)
		{
			IEnumerable<Patient> d_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
			bool? e_(Patient BirthDate)
			{
				Patient i_ = TJCOverallFHIR_1_8_000.Patient(context);
				Date j_ = i_?.BirthDateElement;
				string k_ = j_?.Value;
				CqlDateTime l_ = context.Operators.ConvertStringToDateTime(k_);
				Period m_ = AllStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.ToInterval(context, m_);
				CqlDateTime o_ = context.Operators.Start(n_);
				int? p_ = context.Operators.CalculateAgeAt(l_, o_, "year");
				bool? q_ = context.Operators.GreaterOrEqual(p_, 18);

				return q_;
			};
			IEnumerable<Patient> f_ = context.Operators.Where<Patient>(d_, e_);
			Encounter g_(Patient BirthDate) => 
				AllStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<Patient, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounter")]
	public static IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Encounter_with_Principal_Diagnosis_and_Age(context);
		bool? b_(Encounter EncounterWithAge)
		{
			Condition d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(context, EncounterWithAge);
			CodeableConcept e_ = d_?.Code;
			CqlConcept f_ = FHIRHelpers_4_0_001.ToConcept(context, e_);
			CqlValueSet g_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
	public static IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter(context);
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			Encounter.HospitalizationComponent d_ = IschemicStrokeEncounter?.Hospitalization;
			CodeableConcept e_ = d_?.DischargeDisposition;
			CqlConcept f_ = FHIRHelpers_4_0_001.ToConcept(context, e_);
			CqlValueSet g_ = TJCOverallFHIR_1_8_000.Discharge_To_Acute_Care_Facility(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
			CodeableConcept j_ = d_?.DischargeDisposition;
			CqlConcept k_ = FHIRHelpers_4_0_001.ToConcept(context, j_);
			CqlValueSet l_ = TJCOverallFHIR_1_8_000.Left_Against_Medical_Advice(context);
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
			bool? n_ = context.Operators.Or(h_, m_);
			CodeableConcept p_ = d_?.DischargeDisposition;
			CqlConcept q_ = FHIRHelpers_4_0_001.ToConcept(context, p_);
			CqlValueSet r_ = TJCOverallFHIR_1_8_000.Patient_Expired(context);
			bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
			bool? t_ = context.Operators.Or(n_, s_);
			CodeableConcept v_ = d_?.DischargeDisposition;
			CqlConcept w_ = FHIRHelpers_4_0_001.ToConcept(context, v_);
			CqlValueSet x_ = TJCOverallFHIR_1_8_000.Discharged_to_Home_for_Hospice_Care(context);
			bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
			bool? z_ = context.Operators.Or(t_, y_);
			CodeableConcept ab_ = d_?.DischargeDisposition;
			CqlConcept ac_ = FHIRHelpers_4_0_001.ToConcept(context, ab_);
			CqlValueSet ad_ = TJCOverallFHIR_1_8_000.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
			bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
			bool? af_ = context.Operators.Or(z_, ae_);

			return af_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Intervention Comfort Measures")]
	public static IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
	{
		CqlValueSet a_ = TJCOverallFHIR_1_8_000.Comfort_Measures(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		bool? c_(ServiceRequest P)
		{
			Code<RequestIntent> j_ = P?.IntentElement;
			string k_ = FHIRHelpers_4_0_001.ToString(context, j_);
			bool? l_ = context.Operators.Equal(k_, "order");

			return l_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
		IEnumerable<Procedure> f_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? g_(Procedure InterventionPerformed)
		{
			Code<EventStatus> m_ = InterventionPerformed?.StatusElement;
			string n_ = FHIRHelpers_4_0_001.ToString(context, m_);
			string[] o_ = [
				"completed",
				"in-progress",
			];
			bool? p_ = context.Operators.In<string>(n_, o_ as IEnumerable<string>);

			return p_;
		};
		IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
		IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);

		return i_;
	}

    [CqlDeclaration("Comfort Measures during Hospitalization")]
	public static IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<object> d_ = TJCOverallFHIR_1_8_000.Intervention_Comfort_Measures(context);
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				FhirDateTime j_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				CqlDateTime k_ = FHIRHelpers_4_0_001.ToDateTime(context, (i_ as FhirDateTime) ?? j_);
				CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(context, IschemicStrokeEncounter);
				bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, default);

				return m_;
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
	public static IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
	{
		IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<object> d_ = TJCOverallFHIR_1_8_000.Intervention_Comfort_Measures(context);
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, i_);
				CqlDateTime k_ = context.Operators.Start(j_);
				FhirDateTime l_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				CqlDateTime m_ = FHIRHelpers_4_0_001.ToDateTime(context, l_);
				CqlInterval<CqlDateTime> n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(context, IschemicStrokeEncounter);
				bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, default);

				return o_;
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
	public static CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
	{
		CqlDate a_ = context.Operators.DateFrom(StartValue);
		CqlQuantity b_ = context.Operators.Quantity(1m, "day");
		CqlDateTime c_ = context.Operators.Add(StartValue, b_);
		CqlDate d_ = context.Operators.DateFrom(c_);
		CqlInterval<CqlDate> e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

}
