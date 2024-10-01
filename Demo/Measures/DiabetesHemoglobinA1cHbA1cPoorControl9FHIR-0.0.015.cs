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
[CqlLibrary("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR", "0.0.015")]
public class DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015
{

    public static DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015 Instance { get; }  = new();

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

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

    [CqlDeclaration("HbA1c Laboratory Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013")]
	public CqlValueSet HbA1c_Laboratory_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

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
		var a_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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
		var a_ = this.Telephone_Visits(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter TelehealthEncounter)
		{
			var e_ = context.Operators.Convert<string>(TelehealthEncounter?.StatusElement);
			var f_ = context.Operators.Equal(e_, "finished");
			var g_ = this.Measurement_Period(context);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, (TelehealthEncounter?.Period as object));
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, h_, null);
			var j_ = context.Operators.And(f_, i_);

			return j_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

		return d_;
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
		var g_ = context.Operators.Interval((int?)18, (int?)75, true, false);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
		var j_ = this.Telehealth_Services(context);
		var k_ = context.Operators.ListUnion<Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);
		var m_ = context.Operators.And(h_, l_);
		var n_ = this.Diabetes(context);
		var o_ = context.Operators.RetrieveByValueSet<Condition>(n_, null);
		bool? p_(Condition Diabetes)
		{
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
			var u_ = this.Measurement_Period(context);
			var v_ = context.Operators.Overlaps(t_, u_, null);

			return v_;
		};
		var q_ = context.Operators.WhereOrNull<Condition>(o_, p_);
		var r_ = context.Operators.ExistsInList<Condition>(q_);
		var s_ = context.Operators.And(m_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		var a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Most Recent HbA1c")]
	public Observation Most_Recent_HbA1c(CqlContext context)
	{
		var a_ = this.HbA1c_Laboratory_Test(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation RecentHbA1c)
		{
			var h_ = context.Operators.Convert<string>(RecentHbA1c?.StatusElement);
			var i_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var j_ = context.Operators.InList<string>(h_, (i_ as IEnumerable<string>));
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, RecentHbA1c?.Effective);
			var l_ = this.Measurement_Period(context);
			var m_ = context.Operators.ElementInInterval<CqlDateTime>(k_, l_, null);
			var n_ = context.Operators.And(j_, m_);

			return n_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		object e_(Observation @this)
		{
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, @this?.Effective);
			var p_ = context.Operators.Start(o_);

			return p_;
		};
		var f_ = context.Operators.ListSortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.LastOfList<Observation>(f_);

		return g_;
	}

    [CqlDeclaration("Has Most Recent HbA1c Without Result")]
	public bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context)
	{
		var a_ = this.Most_Recent_HbA1c(context);
		var b_ = context.Operators.Not((bool?)(a_ is null));
		var d_ = context.Operators.And(b_, (bool?)(a_?.Value is null));

		return d_;
	}

    [CqlDeclaration("Has Most Recent Elevated HbA1c")]
	public bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context)
	{
		var a_ = this.Most_Recent_HbA1c(context);
		var b_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (a_?.Value as Quantity));
		var c_ = context.Operators.Quantity(9m, "%");
		var d_ = context.Operators.Greater(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has No Record Of HbA1c")]
	public bool? Has_No_Record_Of_HbA1c(CqlContext context)
	{
		var a_ = this.HbA1c_Laboratory_Test(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation NoHbA1c)
		{
			var g_ = context.Operators.Convert<string>(NoHbA1c?.StatusElement);
			var h_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var i_ = context.Operators.InList<string>(g_, (h_ as IEnumerable<string>));
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, NoHbA1c?.Effective);
			var k_ = this.Measurement_Period(context);
			var l_ = context.Operators.ElementInInterval<CqlDateTime>(j_, k_, null);
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);
		var f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		var a_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
		var b_ = this.Has_Most_Recent_Elevated_HbA1c(context);
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Has_No_Record_Of_HbA1c(context);
		var e_ = context.Operators.Or(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		var a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
		var b_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Patient(context);
		var e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
		var f_ = this.Measurement_Period(context);
		var g_ = context.Operators.Start(f_);
		var h_ = context.Operators.DateFrom(g_);
		var i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
		var j_ = context.Operators.GreaterOrEqual(i_, (int?)65);
		var k_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
		var l_ = context.Operators.And(j_, k_);
		var m_ = context.Operators.Or(c_, l_);
		var n_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
		var o_ = context.Operators.Or(m_, n_);

		return o_;
	}

}