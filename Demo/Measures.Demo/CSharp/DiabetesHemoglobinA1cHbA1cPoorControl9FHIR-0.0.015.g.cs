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
[CqlLibrary("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR", "0.0.015")]
public class DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015(
    FHIRHelpers_4_0_001 _FHIRHelpers_4_0_001,
    SupplementalDataElementsFHIR4_2_0_000 _SupplementalDataElementsFHIR4_2_0_000,
    MATGlobalCommonFunctionsFHIR4_6_1_000 _MATGlobalCommonFunctionsFHIR4_6_1_000,
    PalliativeCareFHIR_0_6_000 _PalliativeCareFHIR_0_6_000,
    AdultOutpatientEncountersFHIR4_2_2_000 _AdultOutpatientEncountersFHIR4_2_2_000,
    HospiceFHIR4_2_3_000 _HospiceFHIR4_2_3_000,
    AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 _AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000,
    CumulativeMedicationDurationFHIR4_1_0_000 _CumulativeMedicationDurationFHIR4_1_0_000)
{

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public  CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public  CqlValueSet Diabetes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public  CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public  CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public  CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("HbA1c Laboratory Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013")]
	public  CqlValueSet HbA1c_Laboratory_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public  CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public  CqlValueSet Hospice_care_ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public  CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public  CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public  CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public  CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Birth date")]
	public  CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
	public  CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Coding> a_ = _SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = _SupplementalDataElementsFHIR4_2_0_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public  IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Coding> a_ = _SupplementalDataElementsFHIR4_2_0_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = _SupplementalDataElementsFHIR4_2_0_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Telehealth Services")]
	public  IEnumerable<Encounter> Telehealth_Services(CqlContext context)
	{
		CqlValueSet a_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		bool? c_(Encounter TelehealthEncounter)
		{
			Code<Encounter.EncounterStatus> e_ = TelehealthEncounter?.StatusElement;
			string f_ = _FHIRHelpers_4_0_001.ToString(context, e_);
			bool? g_ = context.Operators.Equal(f_, "finished");
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			Period i_ = TelehealthEncounter?.Period;
			CqlInterval<CqlDateTime> j_ = _MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, i_ as object);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, default);
			bool? l_ = context.Operators.And(g_, k_);

			return l_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Initial Population")]
	public  bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(18, 75, true, false);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = _AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters(context);
		IEnumerable<Encounter> l_ = this.Telehealth_Services(context);
		IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(k_, l_);
		bool? n_ = context.Operators.Exists<Encounter>(m_);
		bool? o_ = context.Operators.And(j_, n_);
		CqlValueSet p_ = this.Diabetes(context);
		IEnumerable<Condition> q_ = context.Operators.RetrieveByValueSet<Condition>(p_, default);
		bool? r_(Condition Diabetes)
		{
			CqlInterval<CqlDateTime> v_ = _MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(context, Diabetes);
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
			bool? x_ = context.Operators.Overlaps(v_, w_, default);

			return x_;
		};
		IEnumerable<Condition> s_ = context.Operators.Where<Condition>(q_, r_);
		bool? t_ = context.Operators.Exists<Condition>(s_);
		bool? u_ = context.Operators.And(o_, t_);

		return u_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Most Recent HbA1c")]
	public  Observation Most_Recent_HbA1c(CqlContext context)
	{
		CqlValueSet a_ = this.HbA1c_Laboratory_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation RecentHbA1c)
		{
			Code<ObservationStatus> h_ = RecentHbA1c?.StatusElement;
			string i_ = _FHIRHelpers_4_0_001.ToString(context, h_);
			string[] j_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? k_ = context.Operators.In<string>(i_, j_ as IEnumerable<string>);
			DataType l_ = RecentHbA1c?.Effective;
			CqlDateTime m_ = _MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
			bool? p_ = context.Operators.And(k_, o_);

			return p_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			DataType q_ = @this?.Effective;
			CqlInterval<CqlDateTime> r_ = _MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, q_);
			CqlDateTime s_ = context.Operators.Start(r_);

			return s_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.Last<Observation>(f_);

		return g_;
	}

    [CqlDeclaration("Has Most Recent HbA1c Without Result")]
	public  bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context)
	{
		Observation a_ = this.Most_Recent_HbA1c(context);
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		DataType d_ = a_?.Value;
		bool? e_ = context.Operators.And(b_, (bool?)(d_ is null));

		return e_;
	}

    [CqlDeclaration("Has Most Recent Elevated HbA1c")]
	public  bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context)
	{
		Observation a_ = this.Most_Recent_HbA1c(context);
		DataType b_ = a_?.Value;
		CqlQuantity c_ = _FHIRHelpers_4_0_001.ToQuantity(context, b_ as Quantity);
		CqlQuantity d_ = context.Operators.Quantity(9m, "%");
		bool? e_ = context.Operators.Greater(c_, d_);

		return e_;
	}

    [CqlDeclaration("Has No Record Of HbA1c")]
	public  bool? Has_No_Record_Of_HbA1c(CqlContext context)
	{
		CqlValueSet a_ = this.HbA1c_Laboratory_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation NoHbA1c)
		{
			Code<ObservationStatus> g_ = NoHbA1c?.StatusElement;
			string h_ = _FHIRHelpers_4_0_001.ToString(context, g_);
			string[] i_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? j_ = context.Operators.In<string>(h_, i_ as IEnumerable<string>);
			DataType k_ = NoHbA1c?.Effective;
			CqlDateTime l_ = _MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);
			bool? o_ = context.Operators.And(j_, n_);

			return o_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		bool? a_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
		bool? b_ = this.Has_Most_Recent_Elevated_HbA1c(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_No_Record_Of_HbA1c(context);
		bool? e_ = context.Operators.Or(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public  bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = _HospiceFHIR4_2_3_000.Has_Hospice(context);
		bool? b_ = _AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
		bool? c_ = context.Operators.Or(a_, b_);
		Patient d_ = this.Patient(context);
		Date e_ = d_?.BirthDateElement;
		string f_ = e_?.Value;
		CqlDate g_ = context.Operators.ConvertStringToDate(f_);
		CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
		CqlDateTime i_ = context.Operators.Start(h_);
		CqlDate j_ = context.Operators.DateFrom(i_);
		int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
		bool? l_ = context.Operators.GreaterOrEqual(k_, 65);
		bool? m_ = _AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
		bool? n_ = context.Operators.And(l_, m_);
		bool? o_ = context.Operators.Or(c_, n_);
		bool? p_ = _PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period(context);
		bool? q_ = context.Operators.Or(o_, p_);

		return q_;
	}

}
