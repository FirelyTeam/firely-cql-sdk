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
[CqlLibrary("ColorectalCancerScreeningsFHIR", "0.0.003")]
public class ColorectalCancerScreeningsFHIR_0_0_003
{

    public static ColorectalCancerScreeningsFHIR_0_0_003 Instance { get; }  = new();

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
	public CqlValueSet Acute_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
	public CqlValueSet Advanced_Illness(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
	public CqlValueSet Colonoscopy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
	public CqlValueSet CT_Colonography(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
	public CqlValueSet Dementia_Medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
	public CqlValueSet Fecal_Occult_Blood_Test__FOBT_(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

    [CqlDeclaration("FIT DNA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
	public CqlValueSet FIT_DNA(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
	public CqlValueSet Flexible_Sigmoidoscopy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
	public CqlValueSet Frailty_Device(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
	public CqlValueSet Frailty_Diagnosis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
	public CqlValueSet Frailty_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
	public CqlValueSet Frailty_Symptom(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
	public CqlValueSet Malignant_Neoplasm_of_Colon(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
	public CqlValueSet Nonacute_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
	public CqlValueSet Outpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
	public CqlValueSet Total_Colectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

    [CqlDeclaration("Total Colectomy ICD9")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136")]
	public CqlValueSet Total_Colectomy_ICD9(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", null);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory(CqlContext context) => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
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

    [CqlDeclaration("Telehealth Services")]
	public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
	{
		var a_ = this.Online_Assessments(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Telephone_Visits(context);
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		bool? f_(Encounter TelehealthEncounter)
		{
			var h_ = context.Operators.Convert<string>(TelehealthEncounter?.StatusElement);
			var i_ = context.Operators.Equal(h_, "finished");
			var j_ = this.Measurement_Period(context);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (TelehealthEncounter?.Period as object));
			var l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, k_, null);
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var g_ = context.Operators.WhereOrNull<Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
	public int? Age_at_start_of_Measurement_Period(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");

		return f_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)51, (int?)75, true, false);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
		var j_ = this.Telehealth_Services(context);
		var k_ = context.Operators.ListUnion<Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);
		var m_ = context.Operators.And(h_, l_);

		return m_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		var a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Malignant Neoplasm")]
	public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
	{
		var a_ = this.Malignant_Neoplasm_of_Colon(context);
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition ColorectalCancer)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColorectalCancer);
			var f_ = context.Operators.Start(e_);
			var g_ = this.Measurement_Period(context);
			var h_ = context.Operators.End(g_);
			var i_ = context.Operators.SameOrBefore(f_, h_, null);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Total Colectomy Performed")]
	public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
	{
		var a_ = this.Total_Colectomy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure Colectomy)
		{
			var e_ = context.Operators.Convert<string>(Colectomy?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Colectomy?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.SameOrBefore(h_, j_, null);
			var l_ = context.Operators.And(f_, k_);

			return l_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Total Colectomy Condition")]
	public IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
	{
		var a_ = this.Total_Colectomy_ICD9(context);
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition ColectomyDx)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ColectomyDx);
			var f_ = context.Operators.Start(e_);
			var g_ = this.Measurement_Period(context);
			var h_ = context.Operators.End(g_);
			var i_ = context.Operators.SameOrBefore(f_, h_, null);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		var a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
		var b_ = this.Malignant_Neoplasm(context);
		var c_ = context.Operators.ExistsInList<Condition>(b_);
		var d_ = context.Operators.Or(a_, c_);
		var e_ = this.Total_Colectomy_Performed(context);
		var f_ = context.Operators.ExistsInList<Procedure>(e_);
		var g_ = context.Operators.Or(d_, f_);
		var h_ = this.Total_Colectomy_Condition(context);
		var i_ = context.Operators.ExistsInList<Condition>(h_);
		var j_ = context.Operators.Or(g_, i_);
		var k_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
		var l_ = context.Operators.Or(j_, k_);
		var m_ = this.Patient(context);
		var n_ = context.Operators.Convert<CqlDate>(m_?.BirthDateElement?.Value);
		var o_ = this.Measurement_Period(context);
		var p_ = context.Operators.Start(o_);
		var q_ = context.Operators.DateFrom(p_);
		var r_ = context.Operators.CalculateAgeAt(n_, q_, "year");
		var s_ = context.Operators.GreaterOrEqual(r_, (int?)65);
		var t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
		var u_ = context.Operators.And(s_, t_);
		var v_ = context.Operators.Or(l_, u_);
		var w_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
		var x_ = context.Operators.Or(v_, w_);

		return x_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Display Date, Result, Category, Status")]
	public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FecalOccult?.Effective);
			var h_ = this.Measurement_Period(context);
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.Quantity(1m, "year");
			var k_ = context.Operators.Subtract(i_, j_);
			var m_ = context.Operators.End(h_);
			var n_ = context.Operators.Interval(k_, m_, false, false);
			var o_ = context.Operators.ElementInInterval<CqlDateTime>(g_, n_, null);

			return o_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW e_(Observation FecalOccult)
		{
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FecalOccult?.Effective);
			var q_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(FecalOccult?.Value, "coding");
			bool? r_(Coding @this)
			{
				var aj_ = context.Operators.Not((bool?)(@this?.DisplayElement is null));

				return aj_;
			};
			var s_ = context.Operators.WhereOrNull<Coding>(q_, r_);
			FhirString t_(Coding @this) => 
				@this?.DisplayElement;
			var u_ = context.Operators.SelectOrNull<Coding, FhirString>(s_, t_);
			bool? v_(CodeableConcept @this)
			{
				var ak_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ak_;
			};
			var w_ = context.Operators.WhereOrNull<CodeableConcept>((FecalOccult?.Category as IEnumerable<CodeableConcept>), v_);
			List<Coding> x_(CodeableConcept @this) => 
				@this?.Coding;
			var y_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(w_, x_);
			var z_ = context.Operators.FlattenList<Coding>(y_);
			bool? aa_(Coding @this)
			{
				var al_ = context.Operators.Not((bool?)(@this?.CodeElement is null));

				return al_;
			};
			var ab_ = context.Operators.WhereOrNull<Coding>(z_, aa_);
			Code ac_(Coding @this) => 
				@this?.CodeElement;
			var ad_ = context.Operators.SelectOrNull<Coding, Code>(ab_, ac_);
			bool? ae_(Code @this)
			{
				var am_ = context.Operators.Not((bool?)(@this?.Value is null));

				return am_;
			};
			var af_ = context.Operators.WhereOrNull<Code>(ad_, ae_);
			string ag_(Code @this) => 
				@this?.Value;
			var ah_ = context.Operators.SelectOrNull<Code, string>(af_, ag_);
			var ai_ = new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = p_,
				occultResult = u_,
				occultCategoryCode = ah_,
				occultStatus = FecalOccult?.StatusElement,
			};

			return ai_;
		};
		var f_ = context.Operators.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var e_ = context.Operators.Convert<string>(FecalOccult?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			bool? h_(CodeableConcept FecalOccultCategory)
			{
				bool? r_(Coding @this)
				{
					var ab_ = context.Operators.Not((bool?)(@this?.CodeElement is null));

					return ab_;
				};
				var s_ = context.Operators.WhereOrNull<Coding>((FecalOccultCategory?.Coding as IEnumerable<Coding>), r_);
				Code t_(Coding @this) => 
					@this?.CodeElement;
				var u_ = context.Operators.SelectOrNull<Coding, Code>(s_, t_);
				bool? v_(Code @this)
				{
					var ac_ = context.Operators.Not((bool?)(@this?.Value is null));

					return ac_;
				};
				var w_ = context.Operators.WhereOrNull<Code>(u_, v_);
				string x_(Code @this) => 
					@this?.Value;
				var y_ = context.Operators.SelectOrNull<Code, string>(w_, x_);
				var z_ = new string[]
				{
					"laboratory",
				};
				var aa_ = context.Operators.ListEquivalent<string>(y_, (z_ as IEnumerable<string>));

				return aa_;
			};
			var i_ = context.Operators.WhereOrNull<CodeableConcept>((FecalOccult?.Category as IEnumerable<CodeableConcept>), h_);
			var j_ = context.Operators.ExistsInList<CodeableConcept>(i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = context.Operators.Not((bool?)(FecalOccult?.Value is null));
			var m_ = context.Operators.And(k_, l_);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FecalOccult?.Effective);
			var o_ = this.Measurement_Period(context);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(n_, o_, null);
			var q_ = context.Operators.And(m_, p_);

			return q_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var e_ = context.Operators.Convert<string>(FecalOccult?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			bool? h_(CodeableConcept FecalOccultCategory)
			{
				bool? r_(Coding @this)
				{
					var ab_ = context.Operators.Not((bool?)(@this?.CodeElement is null));

					return ab_;
				};
				var s_ = context.Operators.WhereOrNull<Coding>((FecalOccultCategory?.Coding as IEnumerable<Coding>), r_);
				Code t_(Coding @this) => 
					@this?.CodeElement;
				var u_ = context.Operators.SelectOrNull<Coding, Code>(s_, t_);
				bool? v_(Code @this)
				{
					var ac_ = context.Operators.Not((bool?)(@this?.Value is null));

					return ac_;
				};
				var w_ = context.Operators.WhereOrNull<Code>(u_, v_);
				string x_(Code @this) => 
					@this?.Value;
				var y_ = context.Operators.SelectOrNull<Code, string>(w_, x_);
				var z_ = new string[]
				{
					"laboratory",
				};
				var aa_ = context.Operators.ListEquivalent<string>(y_, (z_ as IEnumerable<string>));

				return aa_;
			};
			var i_ = context.Operators.WhereOrNull<CodeableConcept>((FecalOccult?.Category as IEnumerable<CodeableConcept>), h_);
			var j_ = context.Operators.ExistsInList<CodeableConcept>(i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = context.Operators.Not((bool?)(FecalOccult?.Value is null));
			var m_ = context.Operators.And(k_, l_);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FecalOccult?.Effective);
			var o_ = this.Measurement_Period(context);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(n_, o_, "day");
			var q_ = context.Operators.And(m_, p_);

			return q_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			bool? e_(CodeableConcept FecalOccultCategory)
			{
				bool? n_(Coding @this)
				{
					var y_ = context.Operators.Not((bool?)(@this?.CodeElement is null));

					return y_;
				};
				var o_ = context.Operators.WhereOrNull<Coding>((FecalOccultCategory?.Coding as IEnumerable<Coding>), n_);
				Code p_(Coding @this) => 
					@this?.CodeElement;
				var q_ = context.Operators.SelectOrNull<Coding, Code>(o_, p_);
				bool? r_(Code @this)
				{
					var z_ = context.Operators.Not((bool?)(@this?.Value is null));

					return z_;
				};
				var s_ = context.Operators.WhereOrNull<Code>(q_, r_);
				string t_(Code @this) => 
					@this?.Value;
				var u_ = context.Operators.SelectOrNull<Code, string>(s_, t_);
				var v_ = new string[]
				{
					"laboratory",
				};
				var w_ = context.Operators.ListEquivalent<string>(u_, (v_ as IEnumerable<string>));
				var x_ = context.Operators.Not(w_);

				return x_;
			};
			var f_ = context.Operators.WhereOrNull<CodeableConcept>((FecalOccult?.Category as IEnumerable<CodeableConcept>), e_);
			var g_ = context.Operators.ExistsInList<CodeableConcept>(f_);
			var h_ = context.Operators.Not((bool?)(FecalOccult?.Value is null));
			var i_ = context.Operators.And(g_, h_);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FecalOccult?.Effective);
			var k_ = this.Measurement_Period(context);
			var l_ = context.Operators.ElementInInterval<CqlDateTime>(j_, k_, "day");
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var e_ = context.Operators.Convert<string>(FecalOccult?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			var h_ = context.Operators.Not(g_);
			var i_ = context.Operators.Not((bool?)(FecalOccult?.Value is null));
			var j_ = context.Operators.And(h_, i_);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FecalOccult?.Effective);
			var l_ = this.Measurement_Period(context);
			var m_ = context.Operators.ElementInInterval<CqlDateTime>(k_, l_, "day");
			var n_ = context.Operators.And(j_, m_);

			return n_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
	public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
	{
		var a_ = this.FIT_DNA(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FitDNA?.Effective);
			var h_ = this.Measurement_Period(context);
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.Quantity(4m, "years");
			var k_ = context.Operators.Subtract(i_, j_);
			var m_ = context.Operators.End(h_);
			var n_ = context.Operators.Interval(k_, m_, true, true);
			var o_ = context.Operators.ElementInInterval<CqlDateTime>(g_, n_, null);
			var q_ = context.Operators.End(h_);
			var r_ = context.Operators.Not((bool?)(q_ is null));
			var s_ = context.Operators.And(o_, r_);

			return s_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW e_(Observation FitDNA)
		{
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FitDNA?.Effective);
			var u_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(FitDNA?.Value, "coding");
			bool? v_(Coding @this)
			{
				var an_ = context.Operators.Not((bool?)(@this?.DisplayElement is null));

				return an_;
			};
			var w_ = context.Operators.WhereOrNull<Coding>(u_, v_);
			FhirString x_(Coding @this) => 
				@this?.DisplayElement;
			var y_ = context.Operators.SelectOrNull<Coding, FhirString>(w_, x_);
			bool? z_(CodeableConcept @this)
			{
				var ao_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ao_;
			};
			var aa_ = context.Operators.WhereOrNull<CodeableConcept>((FitDNA?.Category as IEnumerable<CodeableConcept>), z_);
			List<Coding> ab_(CodeableConcept @this) => 
				@this?.Coding;
			var ac_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(aa_, ab_);
			var ad_ = context.Operators.FlattenList<Coding>(ac_);
			bool? ae_(Coding @this)
			{
				var ap_ = context.Operators.Not((bool?)(@this?.CodeElement is null));

				return ap_;
			};
			var af_ = context.Operators.WhereOrNull<Coding>(ad_, ae_);
			Code ag_(Coding @this) => 
				@this?.CodeElement;
			var ah_ = context.Operators.SelectOrNull<Coding, Code>(af_, ag_);
			bool? ai_(Code @this)
			{
				var aq_ = context.Operators.Not((bool?)(@this?.Value is null));

				return aq_;
			};
			var aj_ = context.Operators.WhereOrNull<Code>(ah_, ai_);
			string ak_(Code @this) => 
				@this?.Value;
			var al_ = context.Operators.SelectOrNull<Code, string>(aj_, ak_);
			var am_ = new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = t_,
				occultResult = y_,
				occultCategoryCode = al_,
				occultStatus = FitDNA?.StatusElement,
			};

			return am_;
		};
		var f_ = context.Operators.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
	{
		var a_ = this.FIT_DNA(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var e_ = context.Operators.Convert<string>(FitDNA?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			bool? h_(CodeableConcept FitDNACategory)
			{
				bool? ab_(Coding @this)
				{
					var al_ = context.Operators.Not((bool?)(@this?.CodeElement is null));

					return al_;
				};
				var ac_ = context.Operators.WhereOrNull<Coding>((FitDNACategory?.Coding as IEnumerable<Coding>), ab_);
				Code ad_(Coding @this) => 
					@this?.CodeElement;
				var ae_ = context.Operators.SelectOrNull<Coding, Code>(ac_, ad_);
				bool? af_(Code @this)
				{
					var am_ = context.Operators.Not((bool?)(@this?.Value is null));

					return am_;
				};
				var ag_ = context.Operators.WhereOrNull<Code>(ae_, af_);
				string ah_(Code @this) => 
					@this?.Value;
				var ai_ = context.Operators.SelectOrNull<Code, string>(ag_, ah_);
				var aj_ = new string[]
				{
					"laboratory",
				};
				var ak_ = context.Operators.ListEquivalent<string>(ai_, (aj_ as IEnumerable<string>));

				return ak_;
			};
			var i_ = context.Operators.WhereOrNull<CodeableConcept>((FitDNA?.Category as IEnumerable<CodeableConcept>), h_);
			var j_ = context.Operators.ExistsInList<CodeableConcept>(i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = context.Operators.Not((bool?)(FitDNA?.Value is null));
			var m_ = context.Operators.And(k_, l_);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FitDNA?.Effective);
			var o_ = this.Measurement_Period(context);
			var p_ = context.Operators.End(o_);
			var q_ = context.Operators.Quantity(3m, "years");
			var r_ = context.Operators.Subtract(p_, q_);
			var t_ = context.Operators.End(o_);
			var u_ = context.Operators.Interval(r_, t_, true, true);
			var v_ = context.Operators.ElementInInterval<CqlDateTime>(n_, u_, null);
			var x_ = context.Operators.End(o_);
			var y_ = context.Operators.Not((bool?)(x_ is null));
			var z_ = context.Operators.And(v_, y_);
			var aa_ = context.Operators.And(m_, z_);

			return aa_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
	{
		var a_ = this.FIT_DNA(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var e_ = context.Operators.Convert<string>(FitDNA?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			bool? h_(CodeableConcept FitDNACategory)
			{
				bool? ab_(Coding @this)
				{
					var al_ = context.Operators.Not((bool?)(@this?.CodeElement is null));

					return al_;
				};
				var ac_ = context.Operators.WhereOrNull<Coding>((FitDNACategory?.Coding as IEnumerable<Coding>), ab_);
				Code ad_(Coding @this) => 
					@this?.CodeElement;
				var ae_ = context.Operators.SelectOrNull<Coding, Code>(ac_, ad_);
				bool? af_(Code @this)
				{
					var am_ = context.Operators.Not((bool?)(@this?.Value is null));

					return am_;
				};
				var ag_ = context.Operators.WhereOrNull<Code>(ae_, af_);
				string ah_(Code @this) => 
					@this?.Value;
				var ai_ = context.Operators.SelectOrNull<Code, string>(ag_, ah_);
				var aj_ = new string[]
				{
					"laboratory",
				};
				var ak_ = context.Operators.ListEquivalent<string>(ai_, (aj_ as IEnumerable<string>));

				return ak_;
			};
			var i_ = context.Operators.WhereOrNull<CodeableConcept>((FitDNA?.Category as IEnumerable<CodeableConcept>), h_);
			var j_ = context.Operators.ExistsInList<CodeableConcept>(i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = context.Operators.Not((bool?)(FitDNA?.Value is null));
			var m_ = context.Operators.And(k_, l_);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FitDNA?.Effective);
			var o_ = this.Measurement_Period(context);
			var p_ = context.Operators.End(o_);
			var q_ = context.Operators.Quantity(3m, "years");
			var r_ = context.Operators.Subtract(p_, q_);
			var t_ = context.Operators.End(o_);
			var u_ = context.Operators.Interval(r_, t_, true, true);
			var v_ = context.Operators.ElementInInterval<CqlDateTime>(n_, u_, "day");
			var x_ = context.Operators.End(o_);
			var y_ = context.Operators.Not((bool?)(x_ is null));
			var z_ = context.Operators.And(v_, y_);
			var aa_ = context.Operators.And(m_, z_);

			return aa_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
	{
		var a_ = this.FIT_DNA(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			bool? e_(CodeableConcept FitDNACategory)
			{
				bool? x_(Coding @this)
				{
					var ai_ = context.Operators.Not((bool?)(@this?.CodeElement is null));

					return ai_;
				};
				var y_ = context.Operators.WhereOrNull<Coding>((FitDNACategory?.Coding as IEnumerable<Coding>), x_);
				Code z_(Coding @this) => 
					@this?.CodeElement;
				var aa_ = context.Operators.SelectOrNull<Coding, Code>(y_, z_);
				bool? ab_(Code @this)
				{
					var aj_ = context.Operators.Not((bool?)(@this?.Value is null));

					return aj_;
				};
				var ac_ = context.Operators.WhereOrNull<Code>(aa_, ab_);
				string ad_(Code @this) => 
					@this?.Value;
				var ae_ = context.Operators.SelectOrNull<Code, string>(ac_, ad_);
				var af_ = new string[]
				{
					"laboratory",
				};
				var ag_ = context.Operators.ListEquivalent<string>(ae_, (af_ as IEnumerable<string>));
				var ah_ = context.Operators.Not(ag_);

				return ah_;
			};
			var f_ = context.Operators.WhereOrNull<CodeableConcept>((FitDNA?.Category as IEnumerable<CodeableConcept>), e_);
			var g_ = context.Operators.ExistsInList<CodeableConcept>(f_);
			var h_ = context.Operators.Not((bool?)(FitDNA?.Value is null));
			var i_ = context.Operators.And(g_, h_);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FitDNA?.Effective);
			var k_ = this.Measurement_Period(context);
			var l_ = context.Operators.End(k_);
			var m_ = context.Operators.Quantity(3m, "years");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.End(k_);
			var q_ = context.Operators.Interval(n_, p_, true, true);
			var r_ = context.Operators.ElementInInterval<CqlDateTime>(j_, q_, "day");
			var t_ = context.Operators.End(k_);
			var u_ = context.Operators.Not((bool?)(t_ is null));
			var v_ = context.Operators.And(r_, u_);
			var w_ = context.Operators.And(i_, v_);

			return w_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
	{
		var a_ = this.FIT_DNA(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var e_ = context.Operators.Convert<string>(FitDNA?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			var h_ = context.Operators.Not(g_);
			var i_ = context.Operators.Not((bool?)(FitDNA?.Value is null));
			var j_ = context.Operators.And(h_, i_);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FitDNA?.Effective);
			var l_ = this.Measurement_Period(context);
			var m_ = context.Operators.End(l_);
			var n_ = context.Operators.Quantity(3m, "years");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.End(l_);
			var r_ = context.Operators.Interval(o_, q_, true, true);
			var s_ = context.Operators.ElementInInterval<CqlDateTime>(k_, r_, "day");
			var u_ = context.Operators.End(l_);
			var v_ = context.Operators.Not((bool?)(u_ is null));
			var w_ = context.Operators.And(s_, v_);
			var x_ = context.Operators.And(j_, w_);

			return x_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("CT Colonography Display Date")]
	public IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
	{
		var a_ = this.CT_Colonography(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Colonography)
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Colonography?.Effective);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.Quantity(6m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
			var r_ = context.Operators.End(i_);
			var s_ = context.Operators.Not((bool?)(r_ is null));
			var t_ = context.Operators.And(p_, s_);

			return t_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		CqlDateTime e_(Observation Colonography)
		{
			var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, Colonography?.Effective);

			return u_;
		};
		var f_ = context.Operators.SelectOrNull<Observation, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("CT Colonography Performed")]
	public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
	{
		var a_ = this.CT_Colonography(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Colonography)
		{
			var e_ = context.Operators.Convert<string>(Colonography?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Colonography?.Effective);
			var i_ = context.Operators.End(h_);
			var j_ = this.Measurement_Period(context);
			var k_ = context.Operators.End(j_);
			var l_ = context.Operators.Quantity(5m, "years");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.End(j_);
			var p_ = context.Operators.Interval(m_, o_, true, true);
			var q_ = context.Operators.ElementInInterval<CqlDateTime>(i_, p_, null);
			var s_ = context.Operators.End(j_);
			var t_ = context.Operators.Not((bool?)(s_ is null));
			var u_ = context.Operators.And(q_, t_);
			var v_ = context.Operators.And(g_, u_);

			return v_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("CT Colonography Performed without appropriate status")]
	public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
	{
		var a_ = this.CT_Colonography(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Colonography)
		{
			var e_ = context.Operators.Convert<string>(Colonography?.StatusElement);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));
			var h_ = context.Operators.Not(g_);
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Colonography?.Effective);
			var j_ = context.Operators.End(i_);
			var k_ = this.Measurement_Period(context);
			var l_ = context.Operators.End(k_);
			var m_ = context.Operators.Quantity(5m, "years");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.End(k_);
			var q_ = context.Operators.Interval(n_, p_, true, true);
			var r_ = context.Operators.ElementInInterval<CqlDateTime>(j_, q_, null);
			var t_ = context.Operators.End(k_);
			var u_ = context.Operators.Not((bool?)(t_ is null));
			var v_ = context.Operators.And(r_, u_);
			var w_ = context.Operators.And(h_, v_);

			return w_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Display Date")]
	public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
	{
		var a_ = this.Flexible_Sigmoidoscopy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, FlexibleSigmoidoscopy?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.Quantity(6m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
			var r_ = context.Operators.End(i_);
			var s_ = context.Operators.Not((bool?)(r_ is null));
			var t_ = context.Operators.And(p_, s_);

			return t_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);
		CqlDateTime e_(Procedure FlexibleSigmoidoscopy)
		{
			var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, FlexibleSigmoidoscopy?.Performed);

			return u_;
		};
		var f_ = context.Operators.SelectOrNull<Procedure, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
	public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
	{
		var a_ = this.Flexible_Sigmoidoscopy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			var e_ = context.Operators.Convert<string>(FlexibleSigmoidoscopy?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, FlexibleSigmoidoscopy?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.Quantity(5m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
			var r_ = context.Operators.End(i_);
			var s_ = context.Operators.Not((bool?)(r_ is null));
			var t_ = context.Operators.And(p_, s_);
			var u_ = context.Operators.And(f_, t_);

			return u_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed without appropriate status")]
	public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
	{
		var a_ = this.Flexible_Sigmoidoscopy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			var e_ = context.Operators.Convert<string>(FlexibleSigmoidoscopy?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = context.Operators.Not(f_);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, FlexibleSigmoidoscopy?.Performed);
			var i_ = context.Operators.End(h_);
			var j_ = this.Measurement_Period(context);
			var k_ = context.Operators.End(j_);
			var l_ = context.Operators.Quantity(5m, "years");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.End(j_);
			var p_ = context.Operators.Interval(m_, o_, true, true);
			var q_ = context.Operators.ElementInInterval<CqlDateTime>(i_, p_, null);
			var s_ = context.Operators.End(j_);
			var t_ = context.Operators.Not((bool?)(s_ is null));
			var u_ = context.Operators.And(q_, t_);
			var v_ = context.Operators.And(g_, u_);

			return v_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Colonoscopy Display Date")]
	public IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
	{
		var a_ = this.Colonoscopy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure Colonoscopy)
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Colonoscopy?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.Quantity(11m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
			var r_ = context.Operators.End(i_);
			var s_ = context.Operators.Not((bool?)(r_ is null));
			var t_ = context.Operators.And(p_, s_);

			return t_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);
		CqlDateTime e_(Procedure Colonoscopy)
		{
			var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, Colonoscopy?.Performed);

			return u_;
		};
		var f_ = context.Operators.SelectOrNull<Procedure, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Colonoscopy Performed")]
	public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
	{
		var a_ = this.Colonoscopy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure Colonoscopy)
		{
			var e_ = context.Operators.Convert<string>(Colonoscopy?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Colonoscopy?.Performed);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period(context);
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.Quantity(10m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
			var r_ = context.Operators.End(i_);
			var s_ = context.Operators.Not((bool?)(r_ is null));
			var t_ = context.Operators.And(p_, s_);
			var u_ = context.Operators.And(f_, t_);

			return u_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Colonoscopy Performed without appropriate status")]
	public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
	{
		var a_ = this.Colonoscopy(context);
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure Colonoscopy)
		{
			var e_ = context.Operators.Convert<string>(Colonoscopy?.StatusElement);
			var f_ = context.Operators.Equal(e_, "completed");
			var g_ = context.Operators.Not(f_);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, Colonoscopy?.Performed);
			var i_ = context.Operators.End(h_);
			var j_ = this.Measurement_Period(context);
			var k_ = context.Operators.End(j_);
			var l_ = context.Operators.Quantity(10m, "years");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.End(j_);
			var p_ = context.Operators.Interval(m_, o_, true, true);
			var q_ = context.Operators.ElementInInterval<CqlDateTime>(i_, p_, null);
			var s_ = context.Operators.End(j_);
			var t_ = context.Operators.Not((bool?)(s_ is null));
			var u_ = context.Operators.And(q_, t_);
			var v_ = context.Operators.And(g_, u_);

			return v_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		var a_ = this.Colonoscopy_Performed(context);
		var b_ = context.Operators.ExistsInList<Procedure>(a_);
		var c_ = this.Fecal_Occult_Blood_Test_Performed(context);
		var d_ = context.Operators.ExistsInList<Observation>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Flexible_Sigmoidoscopy_Performed(context);
		var g_ = context.Operators.ExistsInList<Procedure>(f_);
		var h_ = context.Operators.Or(e_, g_);
		var i_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
		var j_ = context.Operators.ExistsInList<Observation>(i_);
		var k_ = context.Operators.Or(h_, j_);
		var l_ = this.CT_Colonography_Performed(context);
		var m_ = context.Operators.ExistsInList<Observation>(l_);
		var n_ = context.Operators.Or(k_, m_);

		return n_;
	}

    [CqlDeclaration("Final Numerator Population")]
	public bool? Final_Numerator_Population(CqlContext context)
	{
		var a_ = this.Numerator(context);
		var b_ = this.Initial_Population(context);
		var c_ = context.Operators.And(a_, b_);
		var d_ = this.Denominator(context);
		var e_ = context.Operators.And(c_, d_);
		var f_ = this.Denominator_Exclusions(context);
		var g_ = context.Operators.Not(f_);
		var h_ = context.Operators.And(e_, g_);

		return h_;
	}

}