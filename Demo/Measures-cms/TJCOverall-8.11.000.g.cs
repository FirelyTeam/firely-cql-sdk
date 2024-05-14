using System;
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
[CqlLibrary("TJCOverall", "8.11.000")]
public class TJCOverall_8_11_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Comfort_Measures;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Hemorrhagic_Stroke;
    internal Lazy<CqlValueSet> __Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Left_Against_Medical_Advice;
    internal Lazy<CqlValueSet> __Nonelective_Inpatient_Encounter;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Non_Elective_Inpatient_Encounter;
    internal Lazy<IEnumerable<Encounter>> __All_Stroke_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Principal_Diagnosis_and_Age;
    internal Lazy<IEnumerable<Encounter>> __Ischemic_Stroke_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Ischemic_Stroke_Encounters_with_Discharge_Disposition;
    internal Lazy<IEnumerable<object>> __Intervention_Comfort_Measures;
    internal Lazy<IEnumerable<Encounter>> __Comfort_Measures_during_Hospitalization;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Comfort_Measures_during_Hospitalization;

    #endregion
    public TJCOverall_8_11_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Comfort_Measures = new Lazy<CqlValueSet>(this.Comfort_Measures_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Hemorrhagic_Stroke = new Lazy<CqlValueSet>(this.Hemorrhagic_Stroke_Value);
        __Ischemic_Stroke = new Lazy<CqlValueSet>(this.Ischemic_Stroke_Value);
        __Left_Against_Medical_Advice = new Lazy<CqlValueSet>(this.Left_Against_Medical_Advice_Value);
        __Nonelective_Inpatient_Encounter = new Lazy<CqlValueSet>(this.Nonelective_Inpatient_Encounter_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Non_Elective_Inpatient_Encounter = new Lazy<IEnumerable<Encounter>>(this.Non_Elective_Inpatient_Encounter_Value);
        __All_Stroke_Encounter = new Lazy<IEnumerable<Encounter>>(this.All_Stroke_Encounter_Value);
        __Encounter_with_Principal_Diagnosis_and_Age = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Principal_Diagnosis_and_Age_Value);
        __Ischemic_Stroke_Encounter = new Lazy<IEnumerable<Encounter>>(this.Ischemic_Stroke_Encounter_Value);
        __Ischemic_Stroke_Encounters_with_Discharge_Disposition = new Lazy<IEnumerable<Encounter>>(this.Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value);
        __Intervention_Comfort_Measures = new Lazy<IEnumerable<object>>(this.Intervention_Comfort_Measures_Value);
        __Comfort_Measures_during_Hospitalization = new Lazy<IEnumerable<Encounter>>(this.Comfort_Measures_during_Hospitalization_Value);
        __Encounter_with_Comfort_Measures_during_Hospitalization = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Comfort_Measures_during_Hospitalization_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

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

	private CqlValueSet Nonelective_Inpatient_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Nonelective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public CqlValueSet Nonelective_Inpatient_Encounter() => 
		__Nonelective_Inpatient_Encounter.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("TJCOverall-8.11.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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

	private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_Value()
	{
		var a_ = this.Nonelective_Inpatient_Encounter();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter NonElectiveEncounter)
		{
			var e_ = FHIRHelpers_4_3_000.ToInterval(NonElectiveEncounter?.Period);
			var f_ = context.Operators.End(e_);
			var g_ = this.Measurement_Period();
			var h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");

			return h_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Non Elective Inpatient Encounter")]
	public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter() => 
		__Non_Elective_Inpatient_Encounter.Value;

	private IEnumerable<Encounter> All_Stroke_Encounter_Value()
	{
		var a_ = this.Non_Elective_Inpatient_Encounter();
		bool? b_(Encounter NonElectiveEncounter)
		{
			var d_ = CQMCommon_2_0_000.principalDiagnosis(NonElectiveEncounter);
			var e_ = FHIRHelpers_4_3_000.ToConcept(d_?.Code);
			var f_ = this.Hemorrhagic_Stroke();
			var g_ = context.Operators.ConceptInValueSet(e_, f_);
			var i_ = FHIRHelpers_4_3_000.ToConcept(d_?.Code);
			var j_ = this.Ischemic_Stroke();
			var k_ = context.Operators.ConceptInValueSet(i_, j_);
			var l_ = context.Operators.Or(g_, k_);

			return l_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("All Stroke Encounter")]
	public IEnumerable<Encounter> All_Stroke_Encounter() => 
		__All_Stroke_Encounter.Value;

	private IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age_Value()
	{
		var a_ = this.All_Stroke_Encounter();
		bool? b_(Encounter AllStrokeEncounter)
		{
			var d_ = this.Patient();
			var e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			var f_ = FHIRHelpers_4_3_000.ToInterval(AllStrokeEncounter?.Period);
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
			var j_ = context.Operators.GreaterOrEqual(i_, 18);

			return j_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
	public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age() => 
		__Encounter_with_Principal_Diagnosis_and_Age.Value;

	private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Value()
	{
		var a_ = this.Encounter_with_Principal_Diagnosis_and_Age();
		bool? b_(Encounter EncounterWithAge)
		{
			var d_ = CQMCommon_2_0_000.principalDiagnosis(EncounterWithAge);
			var e_ = FHIRHelpers_4_3_000.ToConcept(d_?.Code);
			var f_ = this.Ischemic_Stroke();
			var g_ = context.Operators.ConceptInValueSet(e_, f_);

			return g_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounter")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounter() => 
		__Ischemic_Stroke_Encounter.Value;

	private IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value()
	{
		var a_ = this.Ischemic_Stroke_Encounter();
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = FHIRHelpers_4_3_000.ToConcept(IschemicStrokeEncounter?.Hospitalization?.DischargeDisposition);
			var e_ = this.Discharge_To_Acute_Care_Facility();
			var f_ = context.Operators.ConceptInValueSet(d_, e_);
			var h_ = this.Left_Against_Medical_Advice();
			var i_ = context.Operators.ConceptInValueSet(d_, h_);
			var j_ = context.Operators.Or(f_, i_);
			var l_ = this.Patient_Expired();
			var m_ = context.Operators.ConceptInValueSet(d_, l_);
			var n_ = context.Operators.Or(j_, m_);
			var p_ = this.Discharged_to_Home_for_Hospice_Care();
			var q_ = context.Operators.ConceptInValueSet(d_, p_);
			var r_ = context.Operators.Or(n_, q_);
			var t_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			var u_ = context.Operators.ConceptInValueSet(d_, t_);
			var v_ = context.Operators.Or(r_, u_);

			return v_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition() => 
		__Ischemic_Stroke_Encounters_with_Discharge_Disposition.Value;

	private IEnumerable<object> Intervention_Comfort_Measures_Value()
	{
		var a_ = this.Comfort_Measures();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		bool? c_(ServiceRequest SR)
		{
			var j_ = context.Operators.Convert<Code<RequestStatus>>(SR?.StatusElement?.Value);
			var k_ = context.Operators.Convert<string>(j_);
			var l_ = new string[]
			{
				"active",
				"completed",
				"on-hold",
			};
			var m_ = context.Operators.In<string>(k_, (l_ as IEnumerable<string>));
			var n_ = context.Operators.Convert<Code<RequestIntent>>(SR?.IntentElement?.Value);
			var o_ = context.Operators.Convert<string>(n_);
			var p_ = new string[]
			{
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			};
			var q_ = context.Operators.In<string>(o_, (p_ as IEnumerable<string>));
			var r_ = context.Operators.And(m_, q_);
			var s_ = context.Operators.IsTrue(SR?.DoNotPerformElement?.Value);
			var t_ = context.Operators.Not(s_);
			var u_ = context.Operators.And(r_, t_);

			return u_;
		};
		var d_ = context.Operators.Where<ServiceRequest>(b_, c_);
		var f_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? g_(Procedure InterventionPerformed)
		{
			var v_ = context.Operators.Convert<string>(InterventionPerformed?.StatusElement?.Value);
			var w_ = new string[]
			{
				"completed",
				"in-progress",
			};
			var x_ = context.Operators.In<string>(v_, (w_ as IEnumerable<string>));

			return x_;
		};
		var h_ = context.Operators.Where<Procedure>(f_, g_);
		var i_ = context.Operators.ListUnion<object>((d_ as IEnumerable<object>), (h_ as IEnumerable<object>));

		return i_;
	}

    [CqlDeclaration("Intervention Comfort Measures")]
	public IEnumerable<object> Intervention_Comfort_Measures() => 
		__Intervention_Comfort_Measures.Value;

	private IEnumerable<Encounter> Comfort_Measures_during_Hospitalization_Value()
	{
		var a_ = this.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				var i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var j_ = FHIRHelpers_4_3_000.ToValue(i_);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				var n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				var o_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
				var p_ = context.Operators.In<CqlDateTime>((l_ ?? n_), o_, null);

				return p_;
			};
			var f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization() => 
		__Comfort_Measures_during_Hospitalization.Value;

	private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Value()
	{
		var a_ = this.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				var i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var j_ = FHIRHelpers_4_3_000.ToValue(i_);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				var n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				var o_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
				var p_ = context.Operators.In<CqlDateTime>((l_ ?? n_), o_, null);

				return p_;
			};
			var f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization() => 
		__Encounter_with_Comfort_Measures_during_Hospitalization.Value;

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context.Operators.DateFrom(StartValue);
		var c_ = context.Operators.Quantity(1m, "day");
		var d_ = context.Operators.Add(a_, c_);
		var e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

}
