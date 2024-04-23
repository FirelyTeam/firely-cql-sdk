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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("TJCOverallFHIR", "1.8.000")]
public class TJCOverallFHIR_1_8_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Comfort_Measures;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Hemorrhagic_Stroke;
    internal Lazy<CqlValueSet> __Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Left_Against_Medical_Advice;
    internal Lazy<CqlValueSet> __Non_Elective_Inpatient;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Ticagrelor_Therapy;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
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
    public TJCOverallFHIR_1_8_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Comfort_Measures = new Lazy<CqlValueSet>(this.Comfort_Measures_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Hemorrhagic_Stroke = new Lazy<CqlValueSet>(this.Hemorrhagic_Stroke_Value);
        __Ischemic_Stroke = new Lazy<CqlValueSet>(this.Ischemic_Stroke_Value);
        __Left_Against_Medical_Advice = new Lazy<CqlValueSet>(this.Left_Against_Medical_Advice_Value);
        __Non_Elective_Inpatient = new Lazy<CqlValueSet>(this.Non_Elective_Inpatient_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Ticagrelor_Therapy = new Lazy<CqlValueSet>(this.Ticagrelor_Therapy_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
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

    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

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

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

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

	private CqlValueSet Non_Elective_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Non-Elective Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
	public CqlValueSet Non_Elective_Inpatient() => 
		__Non_Elective_Inpatient.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Ticagrelor_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", null);

    [CqlDeclaration("Ticagrelor Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39")]
	public CqlValueSet Ticagrelor_Therapy() => 
		__Ticagrelor_Therapy.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_Value()
	{
		var a_ = this.Non_Elective_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter NonElectiveEncounter)
		{
			var e_ = FHIRHelpers_4_0_001.ToInterval(NonElectiveEncounter?.Period);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.LengthInDays(e_);
			var g_ = context.Operators.LessOrEqual(f_, (int?)120);
			var i_ = context.Operators.End(e_);
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.InInterval<CqlDateTime>(i_, j_, "day");
			var l_ = context.Operators.And(g_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

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
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(NonElectiveEncounter);
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_?.Code);
			var f_ = this.Hemorrhagic_Stroke();
			var g_ = context.Operators.ConceptInValueSet(e_, f_);
			var i_ = FHIRHelpers_4_0_001.ToConcept(d_?.Code);
			var j_ = this.Ischemic_Stroke();
			var k_ = context.Operators.ConceptInValueSet(i_, j_);
			var l_ = context.Operators.Or(g_, k_);

			return l_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("All Stroke Encounter")]
	public IEnumerable<Encounter> All_Stroke_Encounter() => 
		__All_Stroke_Encounter.Value;

	private IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age_Value()
	{
		var a_ = this.All_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter AllStrokeEncounter)
		{
			var d_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
			bool? e_(Patient BirthDate)
			{
				var i_ = this.Patient();
				var j_ = context.Operators.ConvertStringToDateTime(i_?.BirthDateElement?.Value);
				var k_ = FHIRHelpers_4_0_001.ToInterval(AllStrokeEncounter?.Period);
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

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
	public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age() => 
		__Encounter_with_Principal_Diagnosis_and_Age.Value;

	private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Value()
	{
		var a_ = this.Encounter_with_Principal_Diagnosis_and_Age();
		bool? b_(Encounter EncounterWithAge)
		{
			var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(EncounterWithAge);
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_?.Code);
			var f_ = this.Ischemic_Stroke();
			var g_ = context.Operators.ConceptInValueSet(e_, f_);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

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
			var d_ = FHIRHelpers_4_0_001.ToConcept(IschemicStrokeEncounter?.Hospitalization?.DischargeDisposition);
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
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
	public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition() => 
		__Ischemic_Stroke_Encounters_with_Discharge_Disposition.Value;

	private IEnumerable<object> Intervention_Comfort_Measures_Value()
	{
		var a_ = this.Comfort_Measures();
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
				var j_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var k_ = FHIRHelpers_4_0_001.ToDateTime(((i_ as FhirDateTime) ?? j_));
				var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				var m_ = context.Operators.InInterval<CqlDateTime>(k_, l_, null);

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
				var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
				var k_ = context.Operators.Start(j_);
				var l_ = context.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var m_ = FHIRHelpers_4_0_001.ToDateTime(l_);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				var o_ = context.Operators.InInterval<CqlDateTime>((k_ ?? m_), n_, null);

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

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization() => 
		__Encounter_with_Comfort_Measures_during_Hospitalization.Value;

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context.Operators.DateFrom(StartValue);
		var b_ = context.Operators.Quantity((decimal?)1m, "day");
		var c_ = context.Operators.Add(StartValue, b_);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

}
