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
public static partial class DevDays_2023_0_0ServiceCollectionExtensions
{
    public static IServiceCollection AddDevDays_2023_0_0(this IServiceCollection services)
    {
        services.TryAddSingleton<DevDays_2023_0_0>();
        services.AddFHIRHelpers_4_0_001();
        return services;
    }
}

partial class DevDays_2023_0_0 : ILibraryService
{
    static void ILibraryService.AddLibraryService(IServiceCollection services) =>
        services.AddDevDays_2023_0_0();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("DevDays", "2023.0.0")]
public partial class DevDays_2023_0_0(
    FHIRHelpers_4_0_001 fhirHelpers_4_0_001)
{

    [CqlDeclaration("Sucked into jet engine")]
	public  CqlCode Sucked_into_jet_engine(CqlContext context) => 
		new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", default, default);

    [CqlDeclaration("Sucked into jet engine, subsequent encounter")]
	public  CqlCode Sucked_into_jet_engine__subsequent_encounter(CqlContext context) => 
		new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", default, default);

    [CqlDeclaration("ICD10")]
	public  CqlCode[] ICD10(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10", default, default),
			new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Jet engine conditions")]
	public  IEnumerable<Condition> Jet_engine_conditions(CqlContext context)
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
		bool? b_(Condition c)
		{
			CodeableConcept d_ = c?.Code;
			List<Coding> e_ = d_?.Coding;
			bool? f_(Coding coding)
			{
				CqlCode n_ = fhirHelpers_4_0_001.ToCode(context, coding);
				CqlCode o_ = this.Sucked_into_jet_engine(context);
				bool? p_ = context.Operators.Equivalent(n_, o_);

				return p_;
			};
			IEnumerable<Coding> g_ = context.Operators.Where<Coding>((IEnumerable<Coding>)e_, f_);
			bool? h_ = context.Operators.Exists<Coding>(g_);
			DataType i_ = c?.Onset;
			CqlDateTime j_ = fhirHelpers_4_0_001.ToDateTime(context, i_ as FhirDateTime);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Subsequent encounters")]
	public  IEnumerable<Condition> Subsequent_encounters(CqlContext context)
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(default, default);
		bool? b_(Condition c)
		{
			CodeableConcept d_ = c?.Code;
			List<Coding> e_ = d_?.Coding;
			bool? f_(Coding coding)
			{
				CqlCode n_ = fhirHelpers_4_0_001.ToCode(context, coding);
				CqlCode o_ = this.Sucked_into_jet_engine__subsequent_encounter(context);
				bool? p_ = context.Operators.Equivalent(n_, o_);

				return p_;
			};
			IEnumerable<Coding> g_ = context.Operators.Where<Coding>((IEnumerable<Coding>)e_, f_);
			bool? h_ = context.Operators.Exists<Coding>(g_);
			DataType i_ = c?.Onset;
			CqlDateTime j_ = fhirHelpers_4_0_001.ToDateTime(context, i_ as FhirDateTime);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial population")]
	public  bool? Initial_population(CqlContext context)
	{
		IEnumerable<Condition> a_ = this.Jet_engine_conditions(context);
		bool? b_ = context.Operators.Exists<Condition>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		IEnumerable<Condition> a_ = this.Subsequent_encounters(context);
		bool? b_ = context.Operators.Exists<Condition>(a_);

		return b_;
	}

}
