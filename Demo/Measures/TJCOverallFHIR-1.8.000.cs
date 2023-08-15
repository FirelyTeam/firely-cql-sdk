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

    private CqlValueSet Comfort_Measures_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", 
			null);
    }

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
    public CqlValueSet Comfort_Measures() => __Comfort_Measures.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", 
			null);
    }

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", 
			null);
    }

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", 
			null);
    }

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", 
			null);
    }

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Hemorrhagic_Stroke_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", 
			null);
    }

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
    public CqlValueSet Hemorrhagic_Stroke() => __Hemorrhagic_Stroke.Value;

    private CqlValueSet Ischemic_Stroke_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", 
			null);
    }

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
    public CqlValueSet Ischemic_Stroke() => __Ischemic_Stroke.Value;

    private CqlValueSet Left_Against_Medical_Advice_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", 
			null);
    }

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
    public CqlValueSet Left_Against_Medical_Advice() => __Left_Against_Medical_Advice.Value;

    private CqlValueSet Non_Elective_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", 
			null);
    }

    [CqlDeclaration("Non-Elective Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
    public CqlValueSet Non_Elective_Inpatient() => __Non_Elective_Inpatient.Value;

    private CqlValueSet Observation_Services_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", 
			null);
    }

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet Patient_Expired_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", 
			null);
    }

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Ticagrelor_Therapy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39", 
			null);
    }

    [CqlDeclaration("Ticagrelor Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.39")]
    public CqlValueSet Ticagrelor_Therapy() => __Ticagrelor_Therapy.Value;

    private CqlCode Birth_date_Value()
    {
        return new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
    {
        var a_ = new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
		};
    }
    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("TJCOverallFHIR-1.8.000", 
			"Measurement Period", 
			(context?.Operators.Interval(context?.Operators.DateTime(((int?)2019), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				context?.Operators.DateTime(((int?)2020), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				true, 
				false) as object)));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Encounter> Non_Elective_Inpatient_Encounter_Value()
    {
        var a_ = this.Non_Elective_Inpatient();
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        Func<Encounter,bool?> n_ = (NonElectiveEncounter) => 
        {
            var e_ = NonElectiveEncounter?.Period;
            var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
            var d_ = (MATGlobalCommonFunctionsFHIR4_6_1_000.LengthInDays(f_) as object);
            var g_ = (((int?)120) as object);
            var h_ = context?.Operators.LessOrEqual(d_, 
				g_);
            var k_ = context?.Operators.End(f_);
            var l_ = this.Measurement_Period();
            var m_ = context?.Operators.ElementInInterval<CqlDateTime>(k_, 
				l_, 
				"day");
            return context?.Operators.And(h_, 
				m_);
        };
        return context?.Operators.WhereOrNull<Encounter>(c_, 
			n_);
    }
    [CqlDeclaration("Non Elective Inpatient Encounter")]
    public IEnumerable<Encounter> Non_Elective_Inpatient_Encounter() => __Non_Elective_Inpatient_Encounter.Value;

    private IEnumerable<Encounter> All_Stroke_Encounter_Value()
    {
        var a_ = this.Non_Elective_Inpatient_Encounter();
        Func<Encounter,bool?> j_ = (NonElectiveEncounter) => 
        {
            var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(NonElectiveEncounter)?.Code;
            var c_ = FHIRHelpers_4_0_001.ToConcept(b_);
            var d_ = this.Hemorrhagic_Stroke();
            var e_ = context?.Operators.ConceptInValueSet(c_, 
				d_);
            var h_ = this.Ischemic_Stroke();
            var i_ = context?.Operators.ConceptInValueSet(c_, 
				h_);
            return context?.Operators.Or(e_, 
				i_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			j_);
    }
    [CqlDeclaration("All Stroke Encounter")]
    public IEnumerable<Encounter> All_Stroke_Encounter() => __All_Stroke_Encounter.Value;

    private IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age_Value()
    {
        var a_ = this.All_Stroke_Encounter();
        Func<Encounter,IEnumerable<Encounter>> m_ = (AllStrokeEncounter) => 
        {
            var b_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
				null);
            Func<Patient,bool?> j_ = (BirthDate) => 
            {
                var d_ = this.Patient()?.BirthDateElement?.Value;
                var e_ = context?.Operators.ConvertStringToDateTime(d_);
                var f_ = AllStrokeEncounter?.Period;
                var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
                var h_ = context?.Operators.Start(g_);
                var c_ = (context?.Operators.CalculateAgeAt(e_, 
					h_, 
					"year") as object);
                var i_ = (((int?)18) as object);
                return context?.Operators.GreaterOrEqual(c_, 
					i_);
            };
            var k_ = context?.Operators.WhereOrNull<Patient>(b_, 
				j_);
            Func<Patient,Encounter> l_ = (BirthDate) => AllStrokeEncounter;
            return context?.Operators.SelectOrNull<Patient, Encounter>(k_, 
				l_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			m_);
    }
    [CqlDeclaration("Encounter with Principal Diagnosis and Age")]
    public IEnumerable<Encounter> Encounter_with_Principal_Diagnosis_and_Age() => __Encounter_with_Principal_Diagnosis_and_Age.Value;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounter_Value()
    {
        var a_ = this.Encounter_with_Principal_Diagnosis_and_Age();
        Func<Encounter,bool?> e_ = (EncounterWithAge) => 
        {
            var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.PrincipalDiagnosis(EncounterWithAge)?.Code;
            var c_ = FHIRHelpers_4_0_001.ToConcept(b_);
            var d_ = this.Ischemic_Stroke();
            return context?.Operators.ConceptInValueSet(c_, 
				d_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			e_);
    }
    [CqlDeclaration("Ischemic Stroke Encounter")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounter() => __Ischemic_Stroke_Encounter.Value;

    private IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition_Value()
    {
        var a_ = this.Ischemic_Stroke_Encounter();
        Func<Encounter,bool?> y_ = (IschemicStrokeEncounter) => 
        {
            var b_ = IschemicStrokeEncounter?.Hospitalization?.DischargeDisposition;
            var c_ = FHIRHelpers_4_0_001.ToConcept(b_);
            var d_ = this.Discharge_To_Acute_Care_Facility();
            var e_ = context?.Operators.ConceptInValueSet(c_, 
				d_);
            var h_ = this.Left_Against_Medical_Advice();
            var i_ = context?.Operators.ConceptInValueSet(c_, 
				h_);
            var j_ = context?.Operators.Or(e_, 
				i_);
            var m_ = this.Patient_Expired();
            var n_ = context?.Operators.ConceptInValueSet(c_, 
				m_);
            var o_ = context?.Operators.Or(j_, 
				n_);
            var r_ = this.Discharged_to_Home_for_Hospice_Care();
            var s_ = context?.Operators.ConceptInValueSet(c_, 
				r_);
            var t_ = context?.Operators.Or(o_, 
				s_);
            var w_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care();
            var x_ = context?.Operators.ConceptInValueSet(c_, 
				w_);
            return context?.Operators.Or(t_, 
				x_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			y_);
    }
    [CqlDeclaration("Ischemic Stroke Encounters with Discharge Disposition")]
    public IEnumerable<Encounter> Ischemic_Stroke_Encounters_with_Discharge_Disposition() => __Ischemic_Stroke_Encounters_with_Discharge_Disposition.Value;

    private IEnumerable<object> Intervention_Comfort_Measures_Value()
    {
        var b_ = this.Comfort_Measures();
        var c_ = typeof(ServiceRequest).GetProperty("Code");
        var d_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(b_, 
			c_);
        Func<ServiceRequest,bool?> h_ = (P) => 
        {
            var f_ = (P?.IntentElement as object);
            var e_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(f_) as object);
            var g_ = ("order" as object);
            return context?.Operators.Equal(e_, 
				g_);
        };
        var a_ = (context?.Operators.WhereOrNull<ServiceRequest>(d_, 
			h_) as IEnumerable<object>);
        var k_ = typeof(Procedure).GetProperty("Code");
        var l_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(b_, 
			k_);
        Func<Procedure,bool?> r_ = (InterventionPerformed) => 
        {
            var m_ = (InterventionPerformed?.StatusElement as object);
            var n_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(m_);
            var p_ = "completed";
            var q_ = "in-progress";
            var o_ = (new string[]
			{
				p_,
				q_,
			} as IEnumerable<string>);
            return context?.Operators.InList<string>(n_, 
				o_);
        };
        var i_ = (context?.Operators.WhereOrNull<Procedure>(l_, 
			r_) as IEnumerable<object>);
        return context?.Operators.ListUnion<object>(a_, 
			i_);
    }
    [CqlDeclaration("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures() => __Intervention_Comfort_Measures.Value;

    private IEnumerable<Encounter> Comfort_Measures_during_Hospitalization_Value()
    {
        var a_ = this.Ischemic_Stroke_Encounter();
        Func<Encounter,IEnumerable<Encounter>> i_ = (IschemicStrokeEncounter) => 
        {
            var b_ = this.Intervention_Comfort_Measures();
            Func<object,bool?> f_ = (ComfortMeasure) => 
            {
                var c_ = ((context?.Operators.LateBoundProperty<object>(ComfortMeasure, 
					"performed") as FhirDateTime) ?? context?.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, 
					"authoredOn"));
                var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
                var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
                return context?.Operators.ElementInInterval<CqlDateTime>(d_, 
					e_, 
					null);
            };
            var g_ = context?.Operators.WhereOrNull<object>(b_, 
				f_);
            Func<object,Encounter> h_ = (ComfortMeasure) => IschemicStrokeEncounter;
            return context?.Operators.SelectOrNull<object, Encounter>(g_, 
				h_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			i_);
    }
    [CqlDeclaration("Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Comfort_Measures_during_Hospitalization() => __Comfort_Measures_during_Hospitalization.Value;

    private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Value()
    {
        var a_ = this.Ischemic_Stroke_Encounter();
        Func<Encounter,IEnumerable<Encounter>> k_ = (IschemicStrokeEncounter) => 
        {
            var b_ = this.Intervention_Comfort_Measures();
            Func<object,bool?> h_ = (ComfortMeasure) => 
            {
                var d_ = context?.Operators.LateBoundProperty<object>(ComfortMeasure, 
					"performed");
                var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(d_);
                var f_ = context?.Operators.LateBoundProperty<FhirDateTime>(ComfortMeasure, 
					"authoredOn");
                var c_ = (context?.Operators.Start(e_) ?? FHIRHelpers_4_0_001.ToDateTime(f_));
                var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(IschemicStrokeEncounter);
                return context?.Operators.ElementInInterval<CqlDateTime>(c_, 
					g_, 
					null);
            };
            var i_ = context?.Operators.WhereOrNull<object>(b_, 
				h_);
            Func<object,Encounter> j_ = (ComfortMeasure) => IschemicStrokeEncounter;
            return context?.Operators.SelectOrNull<object, Encounter>(i_, 
				j_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			k_);
    }
    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization() => __Encounter_with_Comfort_Measures_during_Hospitalization.Value;

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlDateTime StartValue)
    {
        var a_ = context?.Operators.DateFrom(StartValue);
        var b_ = context?.Operators.Quantity(1m, 
			"day");
        var c_ = context?.Operators.Add(StartValue, 
			b_);
        var d_ = context?.Operators.DateFrom(c_);
        return context?.Operators.Interval(a_, 
			d_, 
			true, 
			true);
    }

}