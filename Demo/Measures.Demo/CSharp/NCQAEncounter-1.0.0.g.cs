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
public static partial class NCQAEncounter_1_0_0ServiceCollectionExtensions
{
    public static IServiceCollection AddNCQAEncounter_1_0_0(this IServiceCollection services)
    {
        services.TryAddSingleton<NCQAEncounter_1_0_0>();
        services.AddFHIRHelpers_4_0_001();
        services.AddNCQAFHIRBase_1_0_0();
        services.AddNCQAStatus_1_0_0();
        services.AddNCQATerminology_1_0_0();
        return services;
    }
}

partial class NCQAEncounter_1_0_0 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddNCQAEncounter_1_0_0();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("NCQAEncounter", "1.0.0")]
public partial class NCQAEncounter_1_0_0(
    FHIRHelpers_4_0_001 fhirHelpers_4_0_001,
    NCQAFHIRBase_1_0_0 ncqafhirBase_1_0_0,
    NCQAStatus_1_0_0 ncqaStatus_1_0_0,
    NCQATerminology_1_0_0 ncqaTerminology_1_0_0)
{

    [CqlDeclaration("Encounter Has Diagnosis")]
	public bool? Encounter_Has_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		FhirString b_(Encounter.DiagnosisComponent D)
		{
			ResourceReference g_ = D?.Condition;
			FhirString h_ = g_?.ReferenceElement;

			return h_;
		};
		IEnumerable<FhirString> c_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		bool? d_(FhirString CRef)
		{
			bool? i_(Condition C)
			{
				Id l_ = C?.IdElement;
				string m_ = fhirHelpers_4_0_001.ToString(context, l_);
				string n_ = fhirHelpers_4_0_001.ToString(context, CRef);
				string o_ = ncqafhirBase_1_0_0.GetId(context, n_);
				bool? p_ = context.Operators.Equal(m_, o_);

				return p_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(Conditions, i_);
			bool? k_ = context.Operators.Exists<Condition>(j_);

			return k_;
		};
		IEnumerable<bool?> e_ = context.Operators.Select<FhirString, bool?>(c_, d_);
		bool? f_ = context.Operators.AnyTrue(e_);

		return f_;
	}

    [CqlDeclaration("Encounter Has Principal Diagnosis")]
	public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			PositiveInt i_ = D?.RankElement;
			Integer j_ = context.Operators.Convert<Integer>(i_);
			int? k_ = fhirHelpers_4_0_001.ToInteger(context, j_);
			bool? l_ = context.Operators.Equal(k_, 1);

			return l_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
		Encounter.DiagnosisComponent[] e_ = [
			d_,
		];
		bool? f_(Encounter.DiagnosisComponent PrincipalDiagnosis)
		{
			bool? m_(Condition C)
			{
				Id p_ = C?.IdElement;
				string q_ = fhirHelpers_4_0_001.ToString(context, p_);
				ResourceReference r_ = PrincipalDiagnosis?.Condition;
				FhirString s_ = r_?.ReferenceElement;
				string t_ = fhirHelpers_4_0_001.ToString(context, s_);
				string u_ = ncqafhirBase_1_0_0.GetId(context, t_);
				bool? v_ = context.Operators.Equal(q_, u_);

				return v_;
			};
			IEnumerable<Condition> n_ = context.Operators.Where<Condition>(Conditions, m_);
			bool? o_ = context.Operators.Exists<Condition>(n_);

			return o_;
		};
		IEnumerable<bool?> g_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
		bool? h_ = context.Operators.SingletonFrom<bool?>(g_);

		return h_;
	}

    [CqlDeclaration("Encounter Completed during Period")]
	public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
	{
		IEnumerable<Encounter> a_ = ncqaStatus_1_0_0.Finished_Encounter(context, Enc);
		bool? b_(Encounter EncounterPeriod)
		{
			Period e_ = EncounterPeriod?.Period;
			CqlInterval<CqlDateTime> f_ = ncqafhirBase_1_0_0.Normalize_Interval(context, e_ as object);
			CqlDateTime g_ = context.Operators.End(f_);
			bool? h_ = context.Operators.In<CqlDateTime>(g_, timeperiod, default);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Finished Encounter with Telehealth POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
	{
		IEnumerable<Encounter> a_ = ncqaStatus_1_0_0.Finished_Encounter(context, Encounter);
		bool? b_(Encounter E)
		{
			Coding d_ = E?.Class;
			bool? e_ = context.Operators.Not((bool?)(d_ is null));
			CqlCode g_ = fhirHelpers_4_0_001.ToCode(context, d_);
			CqlCode h_ = ncqaTerminology_1_0_0.@virtual(context);
			bool? i_ = context.Operators.Equivalent(g_, h_);
			bool? j_ = context.Operators.And(e_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Outpatient POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
	{
		IEnumerable<Encounter> a_ = ncqaStatus_1_0_0.Finished_Encounter(context, Encounter);
		bool? b_(Encounter E)
		{
			Coding d_ = E?.Class;
			bool? e_ = context.Operators.Not((bool?)(d_ is null));
			CqlCode g_ = fhirHelpers_4_0_001.ToCode(context, d_);
			CqlCode h_ = ncqaTerminology_1_0_0.ambulatory(context);
			bool? i_ = context.Operators.Equivalent(g_, h_);
			CqlCode k_ = fhirHelpers_4_0_001.ToCode(context, d_);
			CqlCode l_ = ncqaTerminology_1_0_0.home_health(context);
			bool? m_ = context.Operators.Equivalent(k_, l_);
			bool? n_ = context.Operators.Or(i_, m_);
			bool? o_ = context.Operators.And(e_, n_);

			return o_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Finished Encounter with Ambulatory POS")]
	public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
	{
		IEnumerable<Encounter> a_ = ncqaStatus_1_0_0.Finished_Encounter(context, Encounter);
		bool? b_(Encounter E)
		{
			Coding d_ = E?.Class;
			bool? e_ = context.Operators.Not((bool?)(d_ is null));
			CqlCode g_ = fhirHelpers_4_0_001.ToCode(context, d_);
			CqlCode h_ = ncqaTerminology_1_0_0.ambulatory(context);
			bool? i_ = context.Operators.Equivalent(g_, h_);
			bool? j_ = context.Operators.And(e_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

}
