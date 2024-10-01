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
[CqlLibrary("TJCOverallFHIR", "1.8.000")]
public class TJCOverallFHIR_1_8_000
{

    public static TJCOverallFHIR_1_8_000 Instance { get; }  = new();

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

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

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

    [CqlDeclaration("Non-Elective Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public CqlValueSet Non_Elective_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Ticagrelor Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39")]
	public CqlValueSet Ticagrelor_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Non Elective Inpatient Encounter")]
	public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter(CqlContext context)
	{
		var a_ = this.Non_Elective_Inpatient(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter NonElectiveEncounter)
		{
			var e_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, NonElectiveEncounter?.Period);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.LengthInDays(context, e_);
			var g_ = context.Operators.LessOrEqual(f_, (int?)120);
			var i_ = context.Operators.End(e_);
			var j_ = this.Measurement_Period(context);
			var k_ = context.Operators.ElementInInterval<CqlDateTime>(i_, j_, "day");
			var l_ = context.Operators.And(g_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("All Stroke Encounter")]
	public IEnumerable<Encounter> All_Stroke_Encounter(CqlContext context)
	{
		var a_ = this.Non_Elective_Inpatient_Encounter(context);
		bool? b_(Encounter NonElectiveEncounter)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, NonElectiveEncounter);
			var e_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, d_?.Code);
			var f_ = this.Hemorrhagic_Stroke(context);
			var g_ = context.Operators.ConceptInValueSet(e_, f_);
			var i_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, d_?.Code);
			var j_ = this.Ischemic_Stroke(context);
			var k_ = context.Operators.ConceptInValueSet(i_, j_);
			var l_ = context.Operators.Or(g_, k_);

			return l_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
	public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age(CqlContext context)
	{
		var a_ = this.All_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter AllStrokeEncounter)
		{
			var d_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
			bool? e_(Patient BirthDate)
			{
				var i_ = this.Patient(context);
				var j_ = context.Operators.ConvertStringToDateTime(i_?.BirthDateElement?.Value);
				var k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, AllStrokeEncounter?.Period);
				var l_ = context.Operators.Start(k_);
				var m_ = context.Operators.CalculateAgeAt(j_, l_, "year");
				var n_ = context.Operators.GreaterOrEqual(m_, (int?)18);

				return n_;
			};
			var f_ = context.Operators.WhereOrNull<Patient>(d_, e_);
			Encounter g_(Patient BirthDate) => 
				AllStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<Patient, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounter")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounter(CqlContext context)
	{
		var a_ = this.Encounter_with_Principal_Diagnosis_and_Age(context);
		bool? b_(Encounter EncounterWithAge)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.PrincipalDiagnosis(context, EncounterWithAge);
			var e_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, d_?.Code);
			var f_ = this.Ischemic_Stroke(context);
			var g_ = context.Operators.ConceptInValueSet(e_, f_);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition(CqlContext context)
	{
		var a_ = this.Ischemic_Stroke_Encounter(context);
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, IschemicStrokeEncounter?.Hospitalization?.DischargeDisposition);
			var e_ = this.Discharge_To_Acute_Care_Facility(context);
			var f_ = context.Operators.ConceptInValueSet(d_, e_);
			var h_ = this.Left_Against_Medical_Advice(context);
			var i_ = context.Operators.ConceptInValueSet(d_, h_);
			var j_ = context.Operators.Or(f_, i_);
			var l_ = this.Patient_Expired(context);
			var m_ = context.Operators.ConceptInValueSet(d_, l_);
			var n_ = context.Operators.Or(j_, m_);
			var p_ = this.Discharged_to_Home_for_Hospice_Care(context);
			var q_ = context.Operators.ConceptInValueSet(d_, p_);
			var r_ = context.Operators.Or(n_, q_);
			var t_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
			var u_ = context.Operators.ConceptInValueSet(d_, t_);
			var v_ = context.Operators.Or(r_, u_);

			return v_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Intervention Comfort Measures")]
	public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context)
	{
		var a_ = this.Comfort_Measures(context);
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		bool? c_(ServiceRequest P)
		{
			var j_ = context.Operators.Convert<string>(P?.IntentElement);
			var k_ = context.Operators.Equal(j_, "order");

			return k_;
		};
		var d_ = context.Operators.WhereOrNull<ServiceRequest>(b_, c_);
		var f_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? g_(Procedure InterventionPerformed)
		{
			var l_ = context.Operators.Convert<string>(InterventionPerformed?.StatusElement);
			var m_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var n_ = context.Operators.InList<string>(l_, (m_ as IEnumerable<string>));

			return n_;
		};
		var h_ = context.Operators.WhereOrNull<Procedure>(f_, g_);
		var i_ = context.Operators.ListUnion<object>((d_ as IEnumerable<object>), (h_ as IEnumerable<object>));

		return i_;
	}

    [CqlDeclaration("Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization(CqlContext context)
	{
		var a_ = this.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Intervention_Comfort_Measures(context);
			bool? e_(object ComfortMeasure)
			{
				var i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var j_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var k_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ((i_ as FhirDateTime) ?? j_));
				var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
				var m_ = context.Operators.ElementInInterval<CqlDateTime>(k_, l_, null);

				return m_;
			};
			var f_ = context.Operators.WhereOrNull<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context)
	{
		var a_ = this.Ischemic_Stroke_Encounter(context);
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Intervention_Comfort_Measures(context);
			bool? e_(object ComfortMeasure)
			{
				var i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
				var k_ = context.Operators.Start(j_);
				var l_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var m_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, l_);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, IschemicStrokeEncounter);
				var o_ = context.Operators.ElementInInterval<CqlDateTime>((k_ ?? m_), n_, null);

				return o_;
			};
			var f_ = context.Operators.WhereOrNull<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
	{
		var a_ = context.Operators.DateFrom(StartValue);
		var b_ = context.Operators.Quantity(1m, "day");
		var c_ = context.Operators.Add(StartValue, b_);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

}