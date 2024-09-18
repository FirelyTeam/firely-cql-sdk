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
public static partial class AlaraCTFHIR_0_1_001ServiceCollectionExtensions
{
    public static IServiceCollection AddAlaraCTFHIR_0_1_001(this IServiceCollection services)
    {
        services.TryAddSingleton<AlaraCTFHIR_0_1_001>();
        services.AddFHIRHelpers_4_3_000();
        services.AddCQMCommon_2_0_000();
        services.AddQICoreCommon_2_0_000();
        services.AddSupplementalDataElements_3_4_000();
        return services;
    }
}

partial class AlaraCTFHIR_0_1_001 : ICqlLibrary
{
    public static void AddLibraryService(IServiceCollection services) =>
        services.AddAlaraCTFHIR_0_1_001();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("AlaraCTFHIR", "0.1.001")]
public partial class AlaraCTFHIR_0_1_001(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000)
{

    [CqlDeclaration("Birth date")]
	public  CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Calculated CT global noise")]
	public  CqlCode Calculated_CT_global_noise(CqlContext context) => 
		new CqlCode("96912-1", "http://loinc.org", default, default);

    [CqlDeclaration("Calculated CT size-adjusted dose")]
	public  CqlCode Calculated_CT_size_adjusted_dose(CqlContext context) => 
		new CqlCode("96913-9", "http://loinc.org", default, default);

    [CqlDeclaration("CT dose and image quality category")]
	public  CqlCode CT_dose_and_image_quality_category(CqlContext context) => 
		new CqlCode("96914-7", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
	public  CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
			new CqlCode("96912-1", "http://loinc.org", default, default),
			new CqlCode("96913-9", "http://loinc.org", default, default),
			new CqlCode("96914-7", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AlaraCTFHIR-0.1.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
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

    [CqlDeclaration("Qualifying CTScan")]
	public  IEnumerable<Observation> Qualifying_CTScan(CqlContext context)
	{
		CqlCode a_ = this.CT_dose_and_image_quality_category(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation CTScanResult)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
			DataType g_ = CTScanResult?.Effective;
			object h_ = fhirHelpers_4_3_000.ToValue(context, g_);
			CqlInterval<CqlDateTime> i_ = qiCoreCommon_2_0_000.ToInterval(context, h_);
			bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, default);
			Patient k_ = this.Patient(context);
			Date l_ = k_?.BirthDateElement;
			string m_ = l_?.Value;
			CqlDateTime n_ = context.Operators.ConvertStringToDateTime(m_);
			CqlDateTime p_ = context.Operators.Start(f_);
			int? q_ = context.Operators.CalculateAgeAt(n_, p_, "year");
			bool? r_ = context.Operators.GreaterOrEqual(q_, 18);
			bool? s_ = context.Operators.And(j_, r_);

			return s_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Global Noise Value")]
	public  decimal? Global_Noise_Value(CqlContext context, Observation Obs)
	{
		List<Observation.ComponentComponent> a_ = Obs?.Component;
		bool? b_(Observation.ComponentComponent C)
		{
			CodeableConcept g_ = C?.Code;
			CqlConcept h_ = fhirHelpers_4_3_000.ToConcept(context, g_);
			CqlCode i_ = this.Calculated_CT_global_noise(context);
			CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
			bool? k_ = context.Operators.Equivalent(h_, j_);
			DataType l_ = C?.Value;
			object m_ = fhirHelpers_4_3_000.ToValue(context, l_);
			string n_ = (m_ as CqlQuantity)?.unit;
			bool? o_ = context.Operators.Equal(n_, "[hnsf'U]");
			bool? p_ = context.Operators.And(k_, o_);

			return p_;
		};
		IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
		decimal? d_(Observation.ComponentComponent C)
		{
			DataType q_ = C?.Value;
			object r_ = fhirHelpers_4_3_000.ToValue(context, q_);
			decimal? s_ = (r_ as CqlQuantity)?.value;

			return s_;
		};
		IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
		decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);

		return f_;
	}

    [CqlDeclaration("Size Adjusted Value")]
	public  decimal? Size_Adjusted_Value(CqlContext context, Observation Obs)
	{
		List<Observation.ComponentComponent> a_ = Obs?.Component;
		bool? b_(Observation.ComponentComponent C)
		{
			CodeableConcept g_ = C?.Code;
			CqlConcept h_ = fhirHelpers_4_3_000.ToConcept(context, g_);
			CqlCode i_ = this.Calculated_CT_size_adjusted_dose(context);
			CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
			bool? k_ = context.Operators.Equivalent(h_, j_);
			DataType l_ = C?.Value;
			object m_ = fhirHelpers_4_3_000.ToValue(context, l_);
			string n_ = (m_ as CqlQuantity)?.unit;
			bool? o_ = context.Operators.Equal(n_, "mGy.cm");
			bool? p_ = context.Operators.And(k_, o_);

			return p_;
		};
		IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
		decimal? d_(Observation.ComponentComponent C)
		{
			DataType q_ = C?.Value;
			object r_ = fhirHelpers_4_3_000.ToValue(context, q_);
			decimal? s_ = (r_ as CqlQuantity)?.value;

			return s_;
		};
		IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
		decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);

		return f_;
	}

    [CqlDeclaration("Qualifying CTScan with Values")]
	public  IEnumerable<Observation> Qualifying_CTScan_with_Values(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Qualifying_CTScan(context);
		bool? b_(Observation CTScan)
		{
			decimal? d_ = this.Global_Noise_Value(context, CTScan);
			bool? e_ = context.Operators.Not((bool?)(d_ is null));
			decimal? f_ = this.Size_Adjusted_Value(context, CTScan);
			bool? g_ = context.Operators.Not((bool?)(f_ is null));
			bool? h_ = context.Operators.And(e_, g_);
			DataType i_ = CTScan?.Value;
			object j_ = fhirHelpers_4_3_000.ToValue(context, i_);
			bool? k_ = context.Operators.Not((bool?)(j_ is null));
			bool? l_ = context.Operators.And(h_, k_);

			return l_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public  bool? Initial_Population(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Qualifying_CTScan(context);
		bool? b_ = context.Operators.Exists<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Qualifying_CTScan_with_Values(context);
		bool? b_ = context.Operators.Exists<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public  bool? Denominator_Exclusion(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Qualifying_CTScan_with_Values(context);
		bool? b_(Observation CTScan)
		{
			DataType e_ = CTScan?.Value;
			object f_ = fhirHelpers_4_3_000.ToValue(context, e_);
			CqlCode[] g_ = (f_ as CqlConcept)?.codes;
			bool? h_(CqlCode @this)
			{
				string m_ = @this?.code;
				bool? n_ = context.Operators.Not((bool?)(m_ is null));

				return n_;
			};
			IEnumerable<CqlCode> i_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)g_, h_);
			string j_(CqlCode @this)
			{
				string o_ = @this?.code;

				return o_;
			};
			IEnumerable<string> k_ = context.Operators.Select<CqlCode, string>(i_, j_);
			bool? l_ = context.Operators.Contains<string>(k_, "FULLBODY");

			return l_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
		bool? d_ = context.Operators.Exists<Observation>(c_);

		return d_;
	}

    [CqlDeclaration("Qualifies")]
	public  bool? Qualifies(CqlContext context, Observation Obs, string code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
	{
		DataType a_ = Obs?.Value;
		object b_ = fhirHelpers_4_3_000.ToValue(context, a_);
		CqlCode[] c_ = (b_ as CqlConcept)?.codes;
		bool? d_(CqlCode @this)
		{
			string o_ = @this?.code;
			bool? p_ = context.Operators.Not((bool?)(o_ is null));

			return p_;
		};
		IEnumerable<CqlCode> e_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)c_, d_);
		string f_(CqlCode @this)
		{
			string q_ = @this?.code;

			return q_;
		};
		IEnumerable<string> g_ = context.Operators.Select<CqlCode, string>(e_, f_);
		bool? h_ = context.Operators.Contains<string>(g_, code);
		decimal? i_ = this.Global_Noise_Value(context, Obs);
		bool? j_ = context.Operators.GreaterOrEqual(i_, noiseThreshold);
		decimal? k_ = this.Size_Adjusted_Value(context, Obs);
		bool? l_ = context.Operators.GreaterOrEqual(k_, sizeDoseThreshold);
		bool? m_ = context.Operators.Or(j_, l_);
		bool? n_ = context.Operators.And(h_, m_);

		return n_;
	}

    [CqlDeclaration("CT Scan Qualifies")]
	public  bool? CT_Scan_Qualifies(CqlContext context, Observation IP)
	{
		decimal? a_ = context.Operators.ConvertIntegerToDecimal(64);
		decimal? b_ = context.Operators.ConvertIntegerToDecimal(598);
		bool? c_ = this.Qualifies(context, IP, "ABDOPEL LD", a_, b_);
		decimal? d_ = context.Operators.ConvertIntegerToDecimal(29);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(644);
		bool? f_ = this.Qualifies(context, IP, "ABDOPEL RT", d_, e_);
		bool? g_ = context.Operators.Or(c_, f_);
		decimal? i_ = context.Operators.ConvertIntegerToDecimal(1260);
		bool? j_ = this.Qualifies(context, IP, "ABDOPEL HD", d_, i_);
		bool? k_ = context.Operators.Or(g_, j_);
		decimal? l_ = context.Operators.ConvertIntegerToDecimal(55);
		decimal? m_ = context.Operators.ConvertIntegerToDecimal(93);
		bool? n_ = this.Qualifies(context, IP, "CARDIAC LD", l_, m_);
		bool? o_ = context.Operators.Or(k_, n_);
		decimal? p_ = context.Operators.ConvertIntegerToDecimal(32);
		decimal? q_ = context.Operators.ConvertIntegerToDecimal(576);
		bool? r_ = this.Qualifies(context, IP, "CARDIAC RT", p_, q_);
		bool? s_ = context.Operators.Or(o_, r_);
		decimal? u_ = context.Operators.ConvertIntegerToDecimal(377);
		bool? v_ = this.Qualifies(context, IP, "CHEST LD", l_, u_);
		bool? w_ = context.Operators.Or(s_, v_);
		decimal? x_ = context.Operators.ConvertIntegerToDecimal(49);
		bool? z_ = this.Qualifies(context, IP, "CHEST RT", x_, u_);
		bool? aa_ = context.Operators.Or(w_, z_);
		decimal? ac_ = context.Operators.ConvertIntegerToDecimal(1282);
		bool? ad_ = this.Qualifies(context, IP, "CHEST-CARDIAC HD", x_, ac_);
		bool? ae_ = context.Operators.Or(aa_, ad_);
		decimal? af_ = context.Operators.ConvertIntegerToDecimal(115);
		decimal? ag_ = context.Operators.ConvertIntegerToDecimal(582);
		bool? ah_ = this.Qualifies(context, IP, "HEAD LD", af_, ag_);
		bool? ai_ = context.Operators.Or(ae_, ah_);
		decimal? ak_ = context.Operators.ConvertIntegerToDecimal(1025);
		bool? al_ = this.Qualifies(context, IP, "HEAD RT", af_, ak_);
		bool? am_ = context.Operators.Or(ai_, al_);
		decimal? ao_ = context.Operators.ConvertIntegerToDecimal(1832);
		bool? ap_ = this.Qualifies(context, IP, "HEAD HD", af_, ao_);
		bool? aq_ = context.Operators.Or(am_, ap_);
		decimal? ar_ = context.Operators.ConvertIntegerToDecimal(73);
		decimal? as_ = context.Operators.ConvertIntegerToDecimal(320);
		bool? at_ = this.Qualifies(context, IP, "EXTREMITIES", ar_, as_);
		bool? au_ = context.Operators.Or(aq_, at_);
		decimal? av_ = context.Operators.ConvertIntegerToDecimal(25);
		bool? ax_ = this.Qualifies(context, IP, "NECK-CSPINE", av_, i_);
		bool? ay_ = context.Operators.Or(au_, ax_);
		bool? bb_ = this.Qualifies(context, IP, "TSPINE-LSPINE", av_, i_);
		bool? bc_ = context.Operators.Or(ay_, bb_);
		decimal? be_ = context.Operators.ConvertIntegerToDecimal(1637);
		bool? bf_ = this.Qualifies(context, IP, "CAP", d_, be_);
		bool? bg_ = context.Operators.Or(bc_, bf_);
		decimal? bi_ = context.Operators.ConvertIntegerToDecimal(2520);
		bool? bj_ = this.Qualifies(context, IP, "TLSPINE", av_, bi_);
		bool? bk_ = context.Operators.Or(bg_, bj_);
		decimal? bm_ = context.Operators.ConvertIntegerToDecimal(2285);
		bool? bn_ = this.Qualifies(context, IP, "HEADNECK RT", av_, bm_);
		bool? bo_ = context.Operators.Or(bk_, bn_);
		decimal? bq_ = context.Operators.ConvertIntegerToDecimal(3092);
		bool? br_ = this.Qualifies(context, IP, "HEADNECK HD", av_, bq_);
		bool? bs_ = context.Operators.Or(bo_, br_);

		return bs_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Qualifying_CTScan_with_Values(context);
		bool? b_(Observation CTScan)
		{
			bool? e_ = this.CT_Scan_Qualifies(context, CTScan);

			return e_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
		bool? d_ = context.Operators.Exists<Observation>(c_);

		return d_;
	}

}
