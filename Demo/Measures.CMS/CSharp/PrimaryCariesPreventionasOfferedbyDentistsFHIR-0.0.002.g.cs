using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
public static partial class PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002ServiceCollectionExtensions
{
    public static IServiceCollection AddPrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002(this IServiceCollection services)
    {
        services.TryAddSingleton<PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002>();
        services.AddFHIRHelpers_4_3_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddQICoreCommon_2_0_000();
        services.AddHospice_6_9_000();
        services.AddStatus_1_6_000();
        return services;
    }
}

partial class PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002 : ILibraryService
{
    static void ILibraryService.AddLibraryService(IServiceCollection services) =>
        services.AddPrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("PrimaryCariesPreventionasOfferedbyDentistsFHIR", "0.0.002")]
public partial class PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    Hospice_6_9_000 hospice_6_9_000,
    Status_1_6_000 status_1_6_000)
{

    [CqlDeclaration("Clinical Oral Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003")]
	public  CqlValueSet Clinical_Oral_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public  CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Home for Hosice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public  CqlValueSet Discharged_to_Home_for_Hosice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public  CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Fluoride Varnish Application for Children")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002")]
	public  CqlValueSet Fluoride_Varnish_Application_for_Children(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", default);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public  CqlValueSet Hospice_care_ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyDentistsFHIR-0.0.002", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public  IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
	{
		CqlValueSet a_ = this.Clinical_Oral_Evaluation(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		IEnumerable<Encounter> c_ = status_1_6_000.isEncounterPerformed(context, b_);
		bool? d_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
			Period g_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> h_ = fhirHelpers_4_3_000.ToInterval(context, g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");

			return i_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

		return e_;
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
		CqlInterval<int?> i_ = context.Operators.Interval(1, 20, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = this.Qualifying_Encounters(context);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);

		return m_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public  bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = hospice_6_9_000.Has_Hospice_Services(context);

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		CqlValueSet a_ = this.Fluoride_Varnish_Application_for_Children(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = status_1_6_000.isProcedurePerformed(context, b_);
		bool? d_(Procedure FluorideApplication)
		{
			DataType j_ = FluorideApplication?.Performed;
			object k_ = fhirHelpers_4_3_000.ToValue(context, j_);
			CqlInterval<CqlDateTime> l_ = qiCoreCommon_2_0_000.toInterval(context, k_);
			CqlDateTime m_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");

			return o_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		CqlDate f_(Procedure FluorideApplication)
		{
			DataType p_ = FluorideApplication?.Performed;
			object q_ = fhirHelpers_4_3_000.ToValue(context, p_);
			CqlInterval<CqlDateTime> r_ = qiCoreCommon_2_0_000.toInterval(context, q_);
			CqlDateTime s_ = context.Operators.End(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);

			return t_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Procedure, CqlDate>(e_, f_);
		int? h_ = context.Operators.Count<CqlDate>(g_);
		bool? i_ = context.Operators.GreaterOrEqual(h_, 2);

		return i_;
	}

    [CqlDeclaration("Stratification 1")]
	public  bool? Stratification_1(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(1, 5, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratification 2")]
	public  bool? Stratification_2(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(6, 12, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratification 3")]
	public  bool? Stratification_3(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(13, 20, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = supplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = supplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

}
