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
[CqlLibrary("VTE", "8.6.000")]
public class VTE_8_6_000(
    FHIRHelpers_4_3_000 _FHIRHelpers_4_3_000,
    CQMCommon_2_0_000 _CQMCommon_2_0_000)
{

    [CqlDeclaration("Obstetrical or Pregnancy Related Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263")]
	public  CqlValueSet Obstetrical_or_Pregnancy_Related_Conditions(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", default);

    [CqlDeclaration("Obstetrics VTE")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264")]
	public  CqlValueSet Obstetrics_VTE(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264", default);

    [CqlDeclaration("Venous Thromboembolism")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279")]
	public  CqlValueSet Venous_Thromboembolism(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", default);

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("VTE-8.6.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Admission without VTE or Obstetrical Conditions")]
	public  IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = _CQMCommon_2_0_000.Inpatient_Encounter(context);
		bool? b_(Encounter InpatientEncounter)
		{
			IEnumerable<Condition> d_ = _CQMCommon_2_0_000.encounterDiagnosis(context, InpatientEncounter);
			bool? e_(Condition EncDx)
			{
				CodeableConcept i_ = EncDx?.Code;
				CqlConcept j_ = _FHIRHelpers_4_3_000.ToConcept(context, i_);
				CqlValueSet k_ = this.Obstetrical_or_Pregnancy_Related_Conditions(context);
				bool? l_ = context.Operators.ConceptInValueSet(j_, k_);
				CqlConcept n_ = _FHIRHelpers_4_3_000.ToConcept(context, i_);
				CqlValueSet o_ = this.Venous_Thromboembolism(context);
				bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
				bool? q_ = context.Operators.Or(l_, p_);
				CqlConcept s_ = _FHIRHelpers_4_3_000.ToConcept(context, i_);
				CqlValueSet t_ = this.Obstetrics_VTE(context);
				bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
				bool? v_ = context.Operators.Or(q_, u_);

				return v_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);
			bool? h_ = context.Operators.Not(g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions")]
	public  IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = _CQMCommon_2_0_000.Inpatient_Encounter(context);
		bool? b_(Encounter InpatientEncounter)
		{
			Patient f_ = this.Patient(context);
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			Period j_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> k_ = _FHIRHelpers_4_3_000.ToInterval(context, j_);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlDate m_ = context.Operators.DateFrom(l_);
			int? n_ = context.Operators.CalculateAgeAt(i_, m_, "year");
			bool? o_ = context.Operators.GreaterOrEqual(n_, 18);

			return o_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Admission_without_VTE_or_Obstetrical_Conditions(context);
		IEnumerable<Encounter> e_ = context.Operators.Intersect<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public  IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions(context);

		return a_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
	public  CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = _CQMCommon_2_0_000.hospitalizationWithObservation(context, Encounter);
		CqlDateTime b_ = context.Operators.Start(a_);
		CqlDate c_ = context.Operators.DateFrom(b_);
		Period d_ = Encounter?.Period;
		CqlInterval<CqlDateTime> e_ = _FHIRHelpers_4_3_000.ToInterval(context, d_);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		CqlQuantity h_ = context.Operators.Quantity(1m, "days");
		CqlDate i_ = context.Operators.Add(g_, h_);
		CqlInterval<CqlDate> j_ = context.Operators.Interval(c_, i_, true, true);

		return j_;
	}

    [CqlDeclaration("StartOfFirstICU")]
	public  CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
	{
		Encounter.LocationComponent a_ = _CQMCommon_2_0_000.firstInpatientIntensiveCareUnit(context, Encounter);
		Period b_ = a_?.Period;
		CqlInterval<CqlDateTime> c_ = _FHIRHelpers_4_3_000.ToInterval(context, b_);
		CqlDateTime d_ = context.Operators.Start(c_);

		return d_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
	public  CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = _CQMCommon_2_0_000.hospitalizationWithObservation(context, Encounter);
		CqlDateTime b_ = context.Operators.Start(a_);
		CqlDate c_ = context.Operators.DateFrom(b_);
		CqlDateTime d_ = this.StartOfFirstICU(context, Encounter);
		CqlDate e_ = context.Operators.DateFrom(d_);
		CqlQuantity f_ = context.Operators.Quantity(1m, "day");
		CqlDate g_ = context.Operators.Add(e_, f_);
		CqlInterval<CqlDate> h_ = context.Operators.Interval(c_, g_, true, true);

		return h_;
	}

}
