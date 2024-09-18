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
public static partial class Antibiotic_1_5_000ServiceCollectionExtensions
{
    public static IServiceCollection AddAntibiotic_1_5_000(this IServiceCollection services)
    {
        services.TryAddSingleton<Antibiotic_1_5_000>();
        services.AddFHIRHelpers_4_3_000();
        services.AddQICoreCommon_2_0_000();
        return services;
    }
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("Antibiotic", "1.5.000")]
public partial class Antibiotic_1_5_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000)
{

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("Antibiotic-1.5.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Has Comorbid Condition History")]
	public  IEnumerable<Encounter> Has_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> comorbidConditions)
	{
		IEnumerable<Encounter> a_(Encounter eDate)
		{
			bool? e_(Condition comcondition)
			{
				CqlInterval<CqlDateTime> i_ = qiCoreCommon_2_0_000.ToPrevalenceInterval(context, comcondition);
				CqlDateTime j_ = context.Operators.Start(i_);
				CqlDate k_ = context.Operators.DateFrom(j_);
				Period l_ = eDate?.Period;
				CqlInterval<CqlDateTime> m_ = fhirHelpers_4_3_000.ToInterval(context, l_);
				CqlInterval<CqlDateTime> n_ = qiCoreCommon_2_0_000.ToInterval(context, m_ as object);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlDate p_ = context.Operators.DateFrom(o_);
				CqlQuantity q_ = context.Operators.Quantity(1m, "year");
				CqlDate r_ = context.Operators.Subtract(p_, q_);
				CqlInterval<CqlDateTime> t_ = fhirHelpers_4_3_000.ToInterval(context, l_);
				CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.ToInterval(context, t_ as object);
				CqlDateTime v_ = context.Operators.Start(u_);
				CqlDate w_ = context.Operators.DateFrom(v_);
				CqlInterval<CqlDate> x_ = context.Operators.Interval(r_, w_, true, true);
				bool? y_ = context.Operators.In<CqlDate>(k_, x_, default);

				return y_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(comorbidConditions, e_);
			Encounter g_(Condition comcondition) => 
				eDate;
			IEnumerable<Encounter> h_ = context.Operators.Select<Condition, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
		Encounter c_(Encounter eDate) => 
			eDate;
		IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Competing Diagnosis History")]
	public  IEnumerable<Encounter> Has_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
	{
		IEnumerable<Encounter> a_(Encounter eDate)
		{
			bool? e_(Condition competcondition)
			{
				CqlInterval<CqlDateTime> i_ = qiCoreCommon_2_0_000.ToPrevalenceInterval(context, competcondition);
				CqlDateTime j_ = context.Operators.Start(i_);
				Period k_ = eDate?.Period;
				CqlInterval<CqlDateTime> l_ = fhirHelpers_4_3_000.ToInterval(context, k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> o_ = fhirHelpers_4_3_000.ToInterval(context, k_);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(3m, "days");
				CqlDateTime r_ = context.Operators.Add(p_, q_);
				CqlInterval<CqlDateTime> s_ = context.Operators.Interval(m_, r_, true, true);
				bool? t_ = context.Operators.In<CqlDateTime>(j_, s_, "day");
				CqlInterval<CqlDateTime> v_ = fhirHelpers_4_3_000.ToInterval(context, k_);
				CqlDateTime w_ = context.Operators.Start(v_);
				bool? x_ = context.Operators.Not((bool?)(w_ is null));
				bool? y_ = context.Operators.And(t_, x_);

				return y_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(competingConditions, e_);
			Encounter g_(Condition competcondition) => 
				eDate;
			IEnumerable<Encounter> h_ = context.Operators.Select<Condition, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
		Encounter c_(Encounter eDate) => 
			eDate;
		IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Has Antibiotic Medication History")]
	public  IEnumerable<Encounter> Has_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
	{
		IEnumerable<Encounter> a_(Encounter DateOfEpisode)
		{
			bool? c_(MedicationRequest ActiveMedication)
			{
				List<Dosage> g_ = ActiveMedication?.DosageInstruction;
				bool? h_(Dosage @this)
				{
					Timing o_ = @this?.Timing;
					bool? p_ = context.Operators.Not((bool?)(o_ is null));

					return p_;
				};
				IEnumerable<Dosage> i_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)g_, h_);
				Timing j_(Dosage @this)
				{
					Timing q_ = @this?.Timing;

					return q_;
				};
				IEnumerable<Timing> k_ = context.Operators.Select<Dosage, Timing>(i_, j_);
				bool? l_(Timing T)
				{
					Timing.RepeatComponent r_ = T?.Repeat;
					DataType s_ = r_?.Bounds;
					object t_ = fhirHelpers_4_3_000.ToValue(context, s_);
					CqlInterval<CqlDateTime> u_ = qiCoreCommon_2_0_000.ToInterval(context, t_);
					Period v_ = DateOfEpisode?.Period;
					CqlInterval<CqlDateTime> w_ = fhirHelpers_4_3_000.ToInterval(context, v_);
					CqlInterval<CqlDateTime> x_ = qiCoreCommon_2_0_000.ToInterval(context, w_ as object);
					CqlDateTime y_ = context.Operators.Start(x_);
					CqlDate z_ = context.Operators.DateFrom(y_);
					CqlQuantity aa_ = context.Operators.Quantity(30m, "days");
					CqlDate ab_ = context.Operators.Subtract(z_, aa_);
					CqlInterval<CqlDateTime> ad_ = fhirHelpers_4_3_000.ToInterval(context, v_);
					CqlInterval<CqlDateTime> ae_ = qiCoreCommon_2_0_000.ToInterval(context, ad_ as object);
					CqlDateTime af_ = context.Operators.Start(ae_);
					CqlDate ag_ = context.Operators.DateFrom(af_);
					CqlQuantity ah_ = context.Operators.Quantity(1m, "day");
					CqlDate ai_ = context.Operators.Subtract(ag_, ah_);
					CqlInterval<CqlDate> aj_ = context.Operators.Interval(ab_, ai_, true, true);
					CqlDate ak_ = aj_?.low;
					CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
					CqlInterval<CqlDateTime> an_ = fhirHelpers_4_3_000.ToInterval(context, v_);
					CqlInterval<CqlDateTime> ao_ = qiCoreCommon_2_0_000.ToInterval(context, an_ as object);
					CqlDateTime ap_ = context.Operators.Start(ao_);
					CqlDate aq_ = context.Operators.DateFrom(ap_);
					CqlDate as_ = context.Operators.Subtract(aq_, aa_);
					CqlInterval<CqlDateTime> au_ = fhirHelpers_4_3_000.ToInterval(context, v_);
					CqlInterval<CqlDateTime> av_ = qiCoreCommon_2_0_000.ToInterval(context, au_ as object);
					CqlDateTime aw_ = context.Operators.Start(av_);
					CqlDate ax_ = context.Operators.DateFrom(aw_);
					CqlDate az_ = context.Operators.Subtract(ax_, ah_);
					CqlInterval<CqlDate> ba_ = context.Operators.Interval(as_, az_, true, true);
					CqlDate bb_ = ba_?.high;
					CqlDateTime bc_ = context.Operators.ConvertDateToDateTime(bb_);
					CqlInterval<CqlDateTime> be_ = fhirHelpers_4_3_000.ToInterval(context, v_);
					CqlInterval<CqlDateTime> bf_ = qiCoreCommon_2_0_000.ToInterval(context, be_ as object);
					CqlDateTime bg_ = context.Operators.Start(bf_);
					CqlDate bh_ = context.Operators.DateFrom(bg_);
					CqlDate bj_ = context.Operators.Subtract(bh_, aa_);
					CqlInterval<CqlDateTime> bl_ = fhirHelpers_4_3_000.ToInterval(context, v_);
					CqlInterval<CqlDateTime> bm_ = qiCoreCommon_2_0_000.ToInterval(context, bl_ as object);
					CqlDateTime bn_ = context.Operators.Start(bm_);
					CqlDate bo_ = context.Operators.DateFrom(bn_);
					CqlDate bq_ = context.Operators.Subtract(bo_, ah_);
					CqlInterval<CqlDate> br_ = context.Operators.Interval(bj_, bq_, true, true);
					bool? bs_ = br_?.lowClosed;
					CqlInterval<CqlDateTime> bu_ = fhirHelpers_4_3_000.ToInterval(context, v_);
					CqlInterval<CqlDateTime> bv_ = qiCoreCommon_2_0_000.ToInterval(context, bu_ as object);
					CqlDateTime bw_ = context.Operators.Start(bv_);
					CqlDate bx_ = context.Operators.DateFrom(bw_);
					CqlDate bz_ = context.Operators.Subtract(bx_, aa_);
					CqlInterval<CqlDateTime> cb_ = fhirHelpers_4_3_000.ToInterval(context, v_);
					CqlInterval<CqlDateTime> cc_ = qiCoreCommon_2_0_000.ToInterval(context, cb_ as object);
					CqlDateTime cd_ = context.Operators.Start(cc_);
					CqlDate ce_ = context.Operators.DateFrom(cd_);
					CqlDate cg_ = context.Operators.Subtract(ce_, ah_);
					CqlInterval<CqlDate> ch_ = context.Operators.Interval(bz_, cg_, true, true);
					bool? ci_ = ch_?.highClosed;
					CqlInterval<CqlDateTime> cj_ = context.Operators.Interval(al_, bc_, bs_, ci_);
					bool? ck_ = context.Operators.Overlaps(u_, cj_, "day");

					return ck_;
				};
				IEnumerable<Timing> m_ = context.Operators.Where<Timing>(k_, l_);
				bool? n_ = context.Operators.Exists<Timing>(m_);

				return n_;
			};
			IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(antibioticMedications, c_);
			Encounter e_(MedicationRequest ActiveMedication) => 
				DateOfEpisode;
			IEnumerable<Encounter> f_ = context.Operators.Select<MedicationRequest, Encounter>(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);

		return b_;
	}

}
