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
public static partial class VTEFHIR4_4_8_000ServiceCollectionExtensions
{
    public static IServiceCollection AddVTEFHIR4_4_8_000(this IServiceCollection services)
    {
        services.TryAddSingleton<VTEFHIR4_4_8_000>(sp =>
        {
            System.IO.File.AppendAllLines("C:\\temp\\library.txt", ["VTEFHIR4_4_8_000"]);
            return ActivatorUtilities.CreateInstance<VTEFHIR4_4_8_000>(sp);
        });
        services.AddMATGlobalCommonFunctionsFHIR4_6_1_000();
        services.AddFHIRHelpers_4_0_001();
        return services;
    }
}

partial class VTEFHIR4_4_8_000 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddVTEFHIR4_4_8_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("VTEFHIR4", "4.8.000")]
public partial class VTEFHIR4_4_8_000(
    MATGlobalCommonFunctionsFHIR4_6_1_000 matGlobalCommonFunctionsFHIR4_6_1_000,
    FHIRHelpers_4_0_001 fhirHelpers_4_0_001)
{

    [CqlDeclaration("Intensive Care Unit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206")]
	public CqlValueSet Intensive_Care_Unit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", default);

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("FirstInpatientIntensiveCareUnit")]
	public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
	{
		List<Encounter.LocationComponent> a_ = Encounter?.Location;
		bool? b_(Encounter.LocationComponent HospitalLocation)
		{
			ResourceReference g_ = HospitalLocation?.Location;
			Location h_ = matGlobalCommonFunctionsFHIR4_6_1_000.GetLocation(context, g_);
			List<CodeableConcept> i_ = h_?.Type;
			CqlConcept j_(CodeableConcept X)
			{
				CqlConcept t_ = fhirHelpers_4_0_001.ToConcept(context, X);

				return t_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			CqlValueSet l_ = this.Intensive_Care_Unit(context);
			bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
			Period n_ = Encounter?.Period;
			CqlInterval<CqlDateTime> o_ = fhirHelpers_4_0_001.ToInterval(context, n_);
			Period p_ = HospitalLocation?.Period;
			CqlInterval<CqlDateTime> q_ = fhirHelpers_4_0_001.ToInterval(context, p_);
			bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, default);
			bool? s_ = context.Operators.And(m_, r_);

			return s_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
		object d_(Encounter.LocationComponent @this)
		{
			Period u_ = @this?.Period;
			CqlInterval<CqlDateTime> v_ = fhirHelpers_4_0_001.ToInterval(context, u_);
			CqlDateTime w_ = context.Operators.Start(v_);

			return w_;
		};
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent f_ = context.Operators.First<Encounter.LocationComponent>(e_);

		return f_;
	}

    [CqlDeclaration("FirstICULocationPeriod")]
	public Period FirstICULocationPeriod(CqlContext context, Encounter Encounter)
	{
		Encounter.LocationComponent a_ = this.FirstInpatientIntensiveCareUnit(context, Encounter);
		Period b_ = a_?.Period;

		return b_;
	}

    [CqlDeclaration("StartOfFirstICU")]
	public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
	{
		Period a_ = this.FirstICULocationPeriod(context, Encounter);
		CqlInterval<CqlDateTime> b_ = fhirHelpers_4_0_001.ToInterval(context, a_);
		CqlDateTime c_ = context.Operators.Start(b_);

		return c_;
	}

    [CqlDeclaration("CalendarDayOfOrDayAfter")]
	public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
	{
		CqlDate a_ = context.Operators.DateFrom(StartValue);
		CqlQuantity c_ = context.Operators.Quantity(1m, "day");
		CqlDate d_ = context.Operators.Add(a_, c_);
		CqlInterval<CqlDate> e_ = context.Operators.Interval(a_, d_, true, true);

		return e_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = matGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(context, Encounter);
		CqlDateTime b_ = context.Operators.Start(a_);
		CqlDate c_ = context.Operators.DateFrom(b_);
		Period d_ = Encounter?.Period;
		CqlInterval<CqlDateTime> e_ = fhirHelpers_4_0_001.ToInterval(context, d_);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		CqlQuantity h_ = context.Operators.Quantity(1m, "day");
		CqlDate i_ = context.Operators.Add(g_, h_);
		CqlInterval<CqlDate> j_ = context.Operators.Interval(c_, i_, true, true);

		return j_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = matGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(context, Encounter);
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
