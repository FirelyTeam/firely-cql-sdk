﻿using System;
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
public static partial class CervicalCancerScreeningFHIR_0_0_001ServiceCollectionExtensions
{
    public static IServiceCollection AddCervicalCancerScreeningFHIR_0_0_001(this IServiceCollection services)
    {
        services.TryAddSingleton<CervicalCancerScreeningFHIR_0_0_001>();
        services.AddFHIRHelpers_4_3_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddQICoreCommon_2_0_000();
        services.AddHospice_6_9_000();
        services.AddPalliativeCare_1_9_000();
        services.AddStatus_1_6_000();
        return services;
    }
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.001")]
public partial class CervicalCancerScreeningFHIR_0_0_001(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    Hospice_6_9_000 hospice_6_9_000,
    PalliativeCare_1_9_000 palliativeCare_1_9_000,
    Status_1_6_000 status_1_6_000)
{

    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
	public  CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public  CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
	public  CqlValueSet HPV_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", default);

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
	public  CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public  CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public  CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public  CqlValueSet Pap_Test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public  CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public  CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public  CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", c_);

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
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Online_Assessments(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		IEnumerable<Encounter> r_ = status_1_6_000.isEncounterPerformed(context, q_);
		bool? s_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
			Period v_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> w_ = fhirHelpers_4_3_000.ToInterval(context, v_);
			CqlInterval<CqlDateTime> x_ = qiCoreCommon_2_0_000.toInterval(context, w_ as object);
			bool? y_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, x_, "day");

			return y_;
		};
		IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);

		return t_;
	}

    [CqlDeclaration("Initial Population")]
	public  bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(24, 64, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		Code<AdministrativeGender> l_ = a_?.GenderElement;
		AdministrativeGender? m_ = l_?.Value;
		string n_ = context.Operators.Convert<string>(m_);
		bool? o_ = context.Operators.Equal(n_, "female");
		bool? p_ = context.Operators.And(j_, o_);
		IEnumerable<Encounter> q_ = this.Qualifying_Encounters(context);
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.And(p_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Absence of Cervix")]
	public  IEnumerable<object> Absence_of_Cervix(CqlContext context)
	{
		CqlValueSet a_ = this.Hysterectomy_with_No_Residual_Cervix(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = status_1_6_000.isProcedurePerformed(context, b_);
		bool? d_(Procedure NoCervixProcedure)
		{
			DataType k_ = NoCervixProcedure?.Performed;
			object l_ = fhirHelpers_4_3_000.ToValue(context, k_);
			CqlInterval<CqlDateTime> m_ = qiCoreCommon_2_0_000.toInterval(context, l_);
			CqlDateTime n_ = context.Operators.End(m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
			CqlDateTime p_ = context.Operators.End(o_);
			bool? q_ = context.Operators.SameOrBefore(n_, p_, default);

			return q_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		CqlValueSet f_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
		bool? h_(Condition NoCervixDiagnosis)
		{
			CqlInterval<CqlDateTime> r_ = qiCoreCommon_2_0_000.prevalenceInterval(context, NoCervixDiagnosis);
			CqlDateTime s_ = context.Operators.Start(r_);
			CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
			CqlDateTime u_ = context.Operators.End(t_);
			bool? v_ = context.Operators.SameOrBefore(s_, u_, default);

			return v_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
		IEnumerable<object> j_ = context.Operators.Union<object>(e_ as IEnumerable<object>, i_ as IEnumerable<object>);

		return j_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public  bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = hospice_6_9_000.Has_Hospice_Services(context);
		IEnumerable<object> b_ = this.Absence_of_Cervix(context);
		bool? c_ = context.Operators.Exists<object>(b_);
		bool? d_ = context.Operators.Or(a_, c_);
		bool? e_ = palliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period(context);
		bool? f_ = context.Operators.Or(d_, e_);

		return f_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
	public  IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
	{
		CqlValueSet a_ = this.Pap_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.isLaboratoryTestPerformed(context, b_);
		bool? d_(Observation CervicalCytology)
		{
			object f_()
			{
				bool t_()
				{
					DataType w_ = CervicalCytology?.Effective;
					object x_ = fhirHelpers_4_3_000.ToValue(context, w_);
					bool y_ = x_ is CqlDateTime;

					return y_;
				};
				bool u_()
				{
					DataType z_ = CervicalCytology?.Effective;
					object aa_ = fhirHelpers_4_3_000.ToValue(context, z_);
					bool ab_ = aa_ is CqlInterval<CqlDateTime>;

					return ab_;
				};
				bool v_()
				{
					DataType ac_ = CervicalCytology?.Effective;
					object ad_ = fhirHelpers_4_3_000.ToValue(context, ac_);
					bool ae_ = ad_ is CqlDateTime;

					return ae_;
				};
				if (t_())
				{
					DataType af_ = CervicalCytology?.Effective;
					object ag_ = fhirHelpers_4_3_000.ToValue(context, af_);

					return (ag_ as CqlDateTime) as object;
				}
				else if (u_())
				{
					DataType ah_ = CervicalCytology?.Effective;
					object ai_ = fhirHelpers_4_3_000.ToValue(context, ah_);

					return (ai_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (v_())
				{
					DataType aj_ = CervicalCytology?.Effective;
					object ak_ = fhirHelpers_4_3_000.ToValue(context, aj_);

					return (ak_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime g_ = qiCoreCommon_2_0_000.latest(context, f_());
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlQuantity j_ = context.Operators.Quantity(2m, "years");
			CqlDateTime k_ = context.Operators.Subtract(i_, j_);
			CqlDateTime m_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> n_ = context.Operators.Interval(k_, m_, true, true);
			bool? o_ = context.Operators.In<CqlDateTime>(g_, n_, "day");
			DataType p_ = CervicalCytology?.Value;
			object q_ = fhirHelpers_4_3_000.ToValue(context, p_);
			bool? r_ = context.Operators.Not((bool?)(q_ is null));
			bool? s_ = context.Operators.And(o_, r_);

			return s_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
	public  IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
	{
		CqlValueSet a_ = this.HPV_Test(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = status_1_6_000.isLaboratoryTestPerformed(context, b_);
		bool? d_(Observation HPVTest)
		{
			Patient f_ = this.Patient(context);
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			object j_()
			{
				bool ad_()
				{
					DataType ag_ = HPVTest?.Effective;
					object ah_ = fhirHelpers_4_3_000.ToValue(context, ag_);
					bool ai_ = ah_ is CqlDateTime;

					return ai_;
				};
				bool ae_()
				{
					DataType aj_ = HPVTest?.Effective;
					object ak_ = fhirHelpers_4_3_000.ToValue(context, aj_);
					bool al_ = ak_ is CqlInterval<CqlDateTime>;

					return al_;
				};
				bool af_()
				{
					DataType am_ = HPVTest?.Effective;
					object an_ = fhirHelpers_4_3_000.ToValue(context, am_);
					bool ao_ = an_ is CqlDateTime;

					return ao_;
				};
				if (ad_())
				{
					DataType ap_ = HPVTest?.Effective;
					object aq_ = fhirHelpers_4_3_000.ToValue(context, ap_);

					return (aq_ as CqlDateTime) as object;
				}
				else if (ae_())
				{
					DataType ar_ = HPVTest?.Effective;
					object as_ = fhirHelpers_4_3_000.ToValue(context, ar_);

					return (as_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (af_())
				{
					DataType at_ = HPVTest?.Effective;
					object au_ = fhirHelpers_4_3_000.ToValue(context, at_);

					return (au_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime k_ = qiCoreCommon_2_0_000.latest(context, j_());
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 30);
			object o_()
			{
				bool av_()
				{
					DataType ay_ = HPVTest?.Effective;
					object az_ = fhirHelpers_4_3_000.ToValue(context, ay_);
					bool ba_ = az_ is CqlDateTime;

					return ba_;
				};
				bool aw_()
				{
					DataType bb_ = HPVTest?.Effective;
					object bc_ = fhirHelpers_4_3_000.ToValue(context, bb_);
					bool bd_ = bc_ is CqlInterval<CqlDateTime>;

					return bd_;
				};
				bool ax_()
				{
					DataType be_ = HPVTest?.Effective;
					object bf_ = fhirHelpers_4_3_000.ToValue(context, be_);
					bool bg_ = bf_ is CqlDateTime;

					return bg_;
				};
				if (av_())
				{
					DataType bh_ = HPVTest?.Effective;
					object bi_ = fhirHelpers_4_3_000.ToValue(context, bh_);

					return (bi_ as CqlDateTime) as object;
				}
				else if (aw_())
				{
					DataType bj_ = HPVTest?.Effective;
					object bk_ = fhirHelpers_4_3_000.ToValue(context, bj_);

					return (bk_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ax_())
				{
					DataType bl_ = HPVTest?.Effective;
					object bm_ = fhirHelpers_4_3_000.ToValue(context, bl_);

					return (bm_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime p_ = qiCoreCommon_2_0_000.latest(context, o_());
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
			CqlDateTime r_ = context.Operators.Start(q_);
			CqlQuantity s_ = context.Operators.Quantity(4m, "years");
			CqlDateTime t_ = context.Operators.Subtract(r_, s_);
			CqlDateTime v_ = context.Operators.End(q_);
			CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
			bool? x_ = context.Operators.In<CqlDateTime>(p_, w_, "day");
			bool? y_ = context.Operators.And(n_, x_);
			DataType z_ = HPVTest?.Value;
			object aa_ = fhirHelpers_4_3_000.ToValue(context, z_);
			bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
			bool? ac_ = context.Operators.And(y_, ab_);

			return ac_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Cervical_Cytology_Within_3_Years(context);
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
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
