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
    public CqlValueSet Comfort_Measures() => __Comfort_Measures.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Emergency_Department_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Hemorrhagic_Stroke_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
    public CqlValueSet Hemorrhagic_Stroke() => __Hemorrhagic_Stroke.Value;

    private CqlValueSet Ischemic_Stroke_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
    public CqlValueSet Ischemic_Stroke() => __Ischemic_Stroke.Value;

    private CqlValueSet Left_Against_Medical_Advice_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
    public CqlValueSet Left_Against_Medical_Advice() => __Left_Against_Medical_Advice.Value;

    private CqlValueSet Non_Elective_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlDeclaration("Non-Elective Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
    public CqlValueSet Non_Elective_Inpatient() => __Non_Elective_Inpatient.Value;

    private CqlValueSet Observation_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet Patient_Expired_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Ticagrelor_Therapy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", null);

    [CqlDeclaration("Ticagrelor Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39")]
    public CqlValueSet Ticagrelor_Therapy() => __Ticagrelor_Therapy.Value;

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("TJCOverallFHIR-1.8.000", "Measurement Period", f_);

		return (CqlInterval<CqlDateTime>)g_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_Value()
	{
		var m_ = this.Non_Elective_Inpatient();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = (Encounter NonElectiveEncounter) =>
		{
			var a_ = NonElectiveEncounter?.Period;
			var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.LengthInDays(b_);
			var d_ = c_;
			var e_ = (int?)120;
			var f_ = e_;
			var g_ = context?.Operators.LessOrEqual(d_, f_);
			var h_ = NonElectiveEncounter?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = context?.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, k_, "day");

			return context?.Operators.And(g_, l_);
		};

		return context?.Operators.WhereOrNull<Encounter>(n_, o_);
	}

    [CqlDeclaration("Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter() => __Non_Elective_Inpatient_Encounter.Value;

    private IEnumerable<Encounter> All_Stroke_Encounter_Value()
	{
		var k_ = this.Non_Elective_Inpatient_Encounter();
		var l_ = (Encounter NonElectiveEncounter) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(NonElectiveEncounter);
			var b_ = a_?.Code;
			var c_ = FHIRHelpers_4_0_001.ToConcept(b_);
			var d_ = this.Hemorrhagic_Stroke();
			var e_ = context?.Operators.ConceptInValueSet(c_, d_);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(NonElectiveEncounter);
			var g_ = f_?.Code;
			var h_ = FHIRHelpers_4_0_001.ToConcept(g_);
			var i_ = this.Ischemic_Stroke();
			var j_ = context?.Operators.ConceptInValueSet(h_, i_);

			return context?.Operators.Or(e_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(k_, l_);
	}

    [CqlDeclaration("All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter() => __All_Stroke_Encounter.Value;

    private IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age_Value()
	{
		var p_ = this.All_Stroke_Encounter();
		var q_ = (Encounter AllStrokeEncounter) =>
		{
			var l_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);
			var m_ = (Patient BirthDate) =>
			{
				var a_ = this.Patient();
				var b_ = a_?.BirthDateElement;
				var c_ = b_?.Value;
				var d_ = context?.Operators.ConvertStringToDateTime(c_);
				var e_ = AllStrokeEncounter?.Period;
				var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
				var g_ = context?.Operators.Start(f_);
				var h_ = context?.Operators.CalculateAgeAt(d_, g_, "year");
				var i_ = h_;
				var j_ = (int?)18;
				var k_ = j_;

				return context?.Operators.GreaterOrEqual(i_, k_);
			};
			var n_ = context?.Operators.WhereOrNull<Patient>(l_, m_);
			var o_ = (Patient BirthDate) => AllStrokeEncounter;

			return context?.Operators.SelectOrNull<Patient, Encounter>(n_, o_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(p_, q_);
	}

    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age() => __Encounter_with_Principal_Diagnosis_and_Age.Value;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Value()
	{
		var e_ = this.Encounter_with_Principal_Diagnosis_and_Age();
		var f_ = (Encounter EncounterWithAge) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(EncounterWithAge);
			var b_ = a_?.Code;
			var c_ = FHIRHelpers_4_0_001.ToConcept(b_);
			var d_ = this.Ischemic_Stroke();

			return context?.Operators.ConceptInValueSet(c_, d_);
		};

		return context?.Operators.WhereOrNull<Encounter>(e_, f_);
	}

    [CqlDeclaration("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter() => __Ischemic_Stroke_Encounter.Value;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value()
	{
		var ac_ = this.Ischemic_Stroke_Encounter();
		var ad_ = (Encounter IschemicStrokeEncounter) =>
		{
			var a_ = IschemicStrokeEncounter?.Hospitalization;
			var b_ = a_?.DischargeDisposition;
			var c_ = FHIRHelpers_4_0_001.ToConcept(b_);
			var d_ = this.Discharge_To_Acute_Care_Facility();
			var e_ = context?.Operators.ConceptInValueSet(c_, d_);
			var f_ = IschemicStrokeEncounter?.Hospitalization;
			var g_ = f_?.DischargeDisposition;
			var h_ = FHIRHelpers_4_0_001.ToConcept(g_);
			var i_ = this.Left_Against_Medical_Advice();
			var j_ = context?.Operators.ConceptInValueSet(h_, i_);
			var k_ = context?.Operators.Or(e_, j_);
			var l_ = IschemicStrokeEncounter?.Hospitalization;
			var m_ = l_?.DischargeDisposition;
			var n_ = FHIRHelpers_4_0_001.ToConcept(m_);
			var o_ = this.Patient_Expired();
			var p_ = context?.Operators.ConceptInValueSet(n_, o_);
			var q_ = context?.Operators.Or(k_, p_);
			var r_ = IschemicStrokeEncounter?.Hospitalization;
			var s_ = r_?.DischargeDisposition;
			var t_ = FHIRHelpers_4_0_001.ToConcept(s_);
			var u_ = this.Discharged_to_Home_for_Hospice_Care();
			var v_ = context?.Operators.ConceptInValueSet(t_, u_);
			var w_ = context?.Operators.Or(q_, v_);
			var x_ = IschemicStrokeEncounter?.Hospitalization;
			var y_ = x_?.DischargeDisposition;
			var z_ = FHIRHelpers_4_0_001.ToConcept(y_);
			var aa_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
			var ab_ = context?.Operators.ConceptInValueSet(z_, aa_);

			return context?.Operators.Or(w_, ab_);
		};

		return context?.Operators.WhereOrNull<Encounter>(ac_, ad_);
	}

    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition() => __Ischemic_Stroke_Encounters_with_Discharge_Disposition.Value;

    private IEnumerable<object> Intervention_Comfort_Measures_Value()
	{
		var l_ = this.Comfort_Measures();
		var m_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(l_, null);
		var n_ = (ServiceRequest P) =>
		{
			var a_ = P?.IntentElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);

			return context?.Operators.Equal(d_, ("order" as object));
		};
		var o_ = context?.Operators.WhereOrNull<ServiceRequest>(m_, n_);
		var p_ = (o_ as IEnumerable<object>);
		var q_ = this.Comfort_Measures();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(q_, null);
		var s_ = (Procedure InterventionPerformed) =>
		{
			var e_ = InterventionPerformed?.StatusElement;
			var f_ = (e_ as object);
			var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
			var h_ = "completed";
			var i_ = "in-progress";
			var j_ = new string[]
			{
				h_,
				i_,
			};
			var k_ = (j_ as IEnumerable<string>);

			return context?.Operators.InList<string>(g_, k_);
		};
		var t_ = context?.Operators.WhereOrNull<Procedure>(r_, s_);
		var u_ = (t_ as IEnumerable<object>);

		return context?.Operators.ListUnion<object>(p_, u_);
	}

    [CqlDeclaration("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures() => __Intervention_Comfort_Measures.Value;

    private IEnumerable<Encounter> Comfort_Measures_during_Hospitalization_Value()
	{
		var k_ = this.Ischemic_Stroke_Encounter();
		var l_ = (Encounter IschemicStrokeEncounter) =>
		{
			var g_ = this.Intervention_Comfort_Measures();
			var h_ = (object ComfortMeasure) =>
			{
				var a_ = context?.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var b_ = (a_ as FhirDateTime);
				var c_ = context?.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var d_ = (b_ ?? c_);
				var e_ = FHIRHelpers_4_0_001.ToDateTime(d_);
				var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);

				return context?.Operators.ElementInInterval<CqlDateTime>(e_, f_, null);
			};
			var i_ = context?.Operators.WhereOrNull<object>(g_, h_);
			var j_ = (object ComfortMeasure) => IschemicStrokeEncounter;

			return context?.Operators.SelectOrNull<object, Encounter>(i_, j_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(k_, l_);
	}

    [CqlDeclaration("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization() => __Comfort_Measures_during_Hospitalization.Value;

    private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Value()
	{
		var l_ = this.Ischemic_Stroke_Encounter();
		var m_ = (Encounter IschemicStrokeEncounter) =>
		{
			var h_ = this.Intervention_Comfort_Measures();
			var i_ = (object ComfortMeasure) =>
			{
				var a_ = context?.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);
				var c_ = context?.Operators.Start(b_);
				var d_ = context?.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, "authoredOn");
				var e_ = FHIRHelpers_4_0_001.ToDateTime(d_);
				var f_ = (c_ ?? e_);
				var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);

				return context?.Operators.ElementInInterval<CqlDateTime>(f_, g_, null);
			};
			var j_ = context?.Operators.WhereOrNull<object>(h_, i_);
			var k_ = (object ComfortMeasure) => IschemicStrokeEncounter;

			return context?.Operators.SelectOrNull<object, Encounter>(j_, k_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(l_, m_);
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization() => __Encounter_with_Comfort_Measures_during_Hospitalization.Value;

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
	{
		var a_ = context?.Operators.DateFrom(StartValue);
		var b_ = context?.Operators.Quantity(1m, "day");
		var c_ = context?.Operators.Add(StartValue, b_);
		var d_ = context?.Operators.DateFrom(c_);

		return context?.Operators.Interval(a_, d_, true, true);
	}


}