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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("ALARACTOQRFHIR", "0.1.001")]
public class ALARACTOQRFHIR_0_1_001
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlCode> __Calculated_CT_global_noise;
    internal Lazy<CqlCode> __Calculated_CT_size_adjusted_dose;
    internal Lazy<CqlCode> __CT_dose_and_image_quality_category;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Observation>> __Qualified_Scan;
    internal Lazy<IEnumerable<Observation>> __Initial_Population;
    internal Lazy<IEnumerable<Observation>> __Denominator;
    internal Lazy<IEnumerable<Observation>> __Denominator_Exclusion;
    internal Lazy<IEnumerable<Observation>> __Numerator;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public ALARACTOQRFHIR_0_1_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);

        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Calculated_CT_global_noise = new Lazy<CqlCode>(this.Calculated_CT_global_noise_Value);
        __Calculated_CT_size_adjusted_dose = new Lazy<CqlCode>(this.Calculated_CT_size_adjusted_dose_Value);
        __CT_dose_and_image_quality_category = new Lazy<CqlCode>(this.CT_dose_and_image_quality_category_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualified_Scan = new Lazy<IEnumerable<Observation>>(this.Qualified_Scan_Value);
        __Initial_Population = new Lazy<IEnumerable<Observation>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Observation>>(this.Denominator_Value);
        __Denominator_Exclusion = new Lazy<IEnumerable<Observation>>(this.Denominator_Exclusion_Value);
        __Numerator = new Lazy<IEnumerable<Observation>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlCode Calculated_CT_global_noise_Value() => 
		new CqlCode("96912-1", "http://loinc.org", default, default);

    [CqlDeclaration("Calculated CT global noise")]
	public CqlCode Calculated_CT_global_noise() => 
		__Calculated_CT_global_noise.Value;

	private CqlCode Calculated_CT_size_adjusted_dose_Value() => 
		new CqlCode("96913-9", "http://loinc.org", default, default);

    [CqlDeclaration("Calculated CT size-adjusted dose")]
	public CqlCode Calculated_CT_size_adjusted_dose() => 
		__Calculated_CT_size_adjusted_dose.Value;

	private CqlCode CT_dose_and_image_quality_category_Value() => 
		new CqlCode("96914-7", "http://loinc.org", default, default);

    [CqlDeclaration("CT dose and image quality category")]
	public CqlCode CT_dose_and_image_quality_category() => 
		__CT_dose_and_image_quality_category.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("96912-1", "http://loinc.org", default, default),
			new CqlCode("96913-9", "http://loinc.org", default, default),
			new CqlCode("96914-7", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ALARACTOQRFHIR-0.1.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Observation> Qualified_Scan_Value()
	{
		CqlCode a_ = this.CT_dose_and_image_quality_category();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation CTScan)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			DataType g_ = CTScan?.Effective;
			object h_ = FHIRHelpers_4_3_000.ToValue(g_);
			CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.ToInterval(h_);
			bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, default);
			Patient k_ = this.Patient();
			Date l_ = k_?.BirthDateElement;
			string m_ = l_?.Value;
			CqlDate n_ = context.Operators.ConvertStringToDate(m_);
			CqlDateTime p_ = context.Operators.Start(f_);
			CqlDate q_ = context.Operators.DateFrom(p_);
			int? r_ = context.Operators.CalculateAgeAt(n_, q_, "year");
			bool? s_ = context.Operators.GreaterOrEqual(r_, 18);
			bool? t_ = context.Operators.And(j_, s_);

			return t_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualified Scan")]
	public IEnumerable<Observation> Qualified_Scan() => 
		__Qualified_Scan.Value;

	private IEnumerable<Observation> Initial_Population_Value()
	{
		IEnumerable<Observation> a_ = this.Qualified_Scan();
		IEnumerable<Observation> c_(Observation CTScan)
		{
			CqlValueSet f_ = this.Encounter_Inpatient();
			IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
			bool? h_(Encounter InpatientEncounter)
			{
				CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
				DataType m_ = CTScan?.Effective;
				object n_ = FHIRHelpers_4_3_000.ToValue(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval(n_);
				bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, default);

				return p_;
			};
			IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
			Observation j_(Encounter InpatientEncounter) => 
				CTScan;
			IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

			return k_;
		};
		IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(a_, c_);
		IEnumerable<Observation> e_ = context.Operators.Except<Observation>(a_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Observation> Initial_Population() => 
		__Initial_Population.Value;

    [CqlDeclaration("Global Noise Value")]
	public decimal? Global_Noise_Value(Observation Obs)
	{
		List<Observation.ComponentComponent> a_ = Obs?.Component;
		bool? b_(Observation.ComponentComponent C)
		{
			CodeableConcept g_ = C?.Code;
			CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(g_);
			CqlCode i_ = this.Calculated_CT_global_noise();
			CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
			bool? k_ = context.Operators.Equivalent(h_, j_);
			DataType l_ = C?.Value;
			object m_ = FHIRHelpers_4_3_000.ToValue(l_);
			CqlQuantity n_ = m_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			string o_ = n_?.unit;
			bool? p_ = context.Operators.Equal(o_, "[hnsf'U]");
			bool? q_ = context.Operators.And(k_, p_);

			return q_;
		};
		IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
		decimal? d_(Observation.ComponentComponent C)
		{
			DataType r_ = C?.Value;
			object s_ = FHIRHelpers_4_3_000.ToValue(r_);
			CqlQuantity t_ = s_ switch { null => null , CqlQuantity b => b/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			decimal? u_ = t_?.value;

			return u_;
		};
		IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
		decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);

		return f_;
	}

    [CqlDeclaration("Size Adjusted Value")]
	public decimal? Size_Adjusted_Value(Observation Obs)
	{
		List<Observation.ComponentComponent> a_ = Obs?.Component;
		bool? b_(Observation.ComponentComponent C)
		{
			CodeableConcept g_ = C?.Code;
			CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(g_);
			CqlCode i_ = this.Calculated_CT_size_adjusted_dose();
			CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
			bool? k_ = context.Operators.Equivalent(h_, j_);
			DataType l_ = C?.Value;
			object m_ = FHIRHelpers_4_3_000.ToValue(l_);
			CqlQuantity n_ = m_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			string o_ = n_?.unit;
			bool? p_ = context.Operators.Equal(o_, "mGy.cm");
			bool? q_ = context.Operators.And(k_, p_);

			return q_;
		};
		IEnumerable<Observation.ComponentComponent> c_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)a_, b_);
		decimal? d_(Observation.ComponentComponent C)
		{
			DataType r_ = C?.Value;
			object s_ = FHIRHelpers_4_3_000.ToValue(r_);
			CqlQuantity t_ = s_ switch { null => null , CqlQuantity b => b/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			decimal? u_ = t_?.value;

			return u_;
		};
		IEnumerable<decimal?> e_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(c_, d_);
		decimal? f_ = context.Operators.SingletonFrom<decimal?>(e_);

		return f_;
	}

	private IEnumerable<Observation> Denominator_Value()
	{
		IEnumerable<Observation> a_ = this.Initial_Population();
		bool? b_(Observation IP)
		{
			decimal? d_ = this.Global_Noise_Value(IP);
			bool? e_ = context.Operators.Not((bool?)(d_ is null));
			decimal? f_ = this.Size_Adjusted_Value(IP);
			bool? g_ = context.Operators.Not((bool?)(f_ is null));
			bool? h_ = context.Operators.And(e_, g_);
			DataType i_ = IP?.Value;
			object j_ = FHIRHelpers_4_3_000.ToValue(i_);
			bool? k_ = context.Operators.Not((bool?)(j_ is null));
			bool? l_ = context.Operators.And(h_, k_);

			return l_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Observation> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Observation> Denominator_Exclusion_Value()
	{
		IEnumerable<Observation> a_ = this.Denominator();
		bool? b_(Observation Denominator)
		{
			DataType d_ = Denominator?.Value;
			object e_ = FHIRHelpers_4_3_000.ToValue(d_);
			CqlConcept f_ = e_ switch { null => null , CqlConcept a => a/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlCode[] g_ = f_?.codes;
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

		return c_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public IEnumerable<Observation> Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

    [CqlDeclaration("Qualifies")]
	public bool? Qualifies(Observation Obs, string code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
	{
		DataType a_ = Obs?.Value;
		object b_ = FHIRHelpers_4_3_000.ToValue(a_);
		CqlConcept c_ = b_ switch { null => null , CqlConcept a => a/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
		CqlCode[] d_ = c_?.codes;
		bool? e_(CqlCode @this)
		{
			string p_ = @this?.code;
			bool? q_ = context.Operators.Not((bool?)(p_ is null));

			return q_;
		};
		IEnumerable<CqlCode> f_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)d_, e_);
		string g_(CqlCode @this)
		{
			string r_ = @this?.code;

			return r_;
		};
		IEnumerable<string> h_ = context.Operators.Select<CqlCode, string>(f_, g_);
		bool? i_ = context.Operators.Contains<string>(h_, code);
		decimal? j_ = this.Global_Noise_Value(Obs);
		bool? k_ = context.Operators.GreaterOrEqual(j_, noiseThreshold);
		decimal? l_ = this.Size_Adjusted_Value(Obs);
		bool? m_ = context.Operators.GreaterOrEqual(l_, sizeDoseThreshold);
		bool? n_ = context.Operators.Or(k_, m_);
		bool? o_ = context.Operators.And(i_, n_);

		return o_;
	}

    [CqlDeclaration("CT Scan Qualifies")]
	public bool? CT_Scan_Qualifies(Observation IP)
	{
		decimal? a_ = context.Operators.ConvertIntegerToDecimal(64);
		decimal? b_ = context.Operators.ConvertIntegerToDecimal(598);
		bool? c_ = this.Qualifies(IP, "ABDOPEL LD", a_, b_);
		decimal? d_ = context.Operators.ConvertIntegerToDecimal(29);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(644);
		bool? f_ = this.Qualifies(IP, "ABDOPEL RT", d_, e_);
		bool? g_ = context.Operators.Or(c_, f_);
		decimal? i_ = context.Operators.ConvertIntegerToDecimal(1260);
		bool? j_ = this.Qualifies(IP, "ABDOPEL HD", d_, i_);
		bool? k_ = context.Operators.Or(g_, j_);
		decimal? l_ = context.Operators.ConvertIntegerToDecimal(55);
		decimal? m_ = context.Operators.ConvertIntegerToDecimal(93);
		bool? n_ = this.Qualifies(IP, "CARDIAC LD", l_, m_);
		bool? o_ = context.Operators.Or(k_, n_);
		decimal? p_ = context.Operators.ConvertIntegerToDecimal(32);
		decimal? q_ = context.Operators.ConvertIntegerToDecimal(576);
		bool? r_ = this.Qualifies(IP, "CARDIAC RT", p_, q_);
		bool? s_ = context.Operators.Or(o_, r_);
		decimal? u_ = context.Operators.ConvertIntegerToDecimal(377);
		bool? v_ = this.Qualifies(IP, "CHEST LD", l_, u_);
		bool? w_ = context.Operators.Or(s_, v_);
		decimal? x_ = context.Operators.ConvertIntegerToDecimal(49);
		bool? z_ = this.Qualifies(IP, "CHEST RT", x_, u_);
		bool? aa_ = context.Operators.Or(w_, z_);
		decimal? ac_ = context.Operators.ConvertIntegerToDecimal(1282);
		bool? ad_ = this.Qualifies(IP, "CHEST-CARDIAC HD", x_, ac_);
		bool? ae_ = context.Operators.Or(aa_, ad_);
		decimal? af_ = context.Operators.ConvertIntegerToDecimal(115);
		decimal? ag_ = context.Operators.ConvertIntegerToDecimal(582);
		bool? ah_ = this.Qualifies(IP, "HEAD LD", af_, ag_);
		bool? ai_ = context.Operators.Or(ae_, ah_);
		decimal? ak_ = context.Operators.ConvertIntegerToDecimal(1025);
		bool? al_ = this.Qualifies(IP, "HEAD RT", af_, ak_);
		bool? am_ = context.Operators.Or(ai_, al_);
		decimal? ao_ = context.Operators.ConvertIntegerToDecimal(1832);
		bool? ap_ = this.Qualifies(IP, "HEAD HD", af_, ao_);
		bool? aq_ = context.Operators.Or(am_, ap_);
		decimal? ar_ = context.Operators.ConvertIntegerToDecimal(73);
		decimal? as_ = context.Operators.ConvertIntegerToDecimal(320);
		bool? at_ = this.Qualifies(IP, "EXTREMITIES", ar_, as_);
		bool? au_ = context.Operators.Or(aq_, at_);
		decimal? av_ = context.Operators.ConvertIntegerToDecimal(25);
		bool? ax_ = this.Qualifies(IP, "NECK-CSPINE", av_, i_);
		bool? ay_ = context.Operators.Or(au_, ax_);
		bool? bb_ = this.Qualifies(IP, "TSPINE-LSPINE", av_, i_);
		bool? bc_ = context.Operators.Or(ay_, bb_);
		decimal? be_ = context.Operators.ConvertIntegerToDecimal(1637);
		bool? bf_ = this.Qualifies(IP, "CAP", d_, be_);
		bool? bg_ = context.Operators.Or(bc_, bf_);
		decimal? bi_ = context.Operators.ConvertIntegerToDecimal(2520);
		bool? bj_ = this.Qualifies(IP, "TLSPINE", av_, bi_);
		bool? bk_ = context.Operators.Or(bg_, bj_);
		decimal? bm_ = context.Operators.ConvertIntegerToDecimal(2285);
		bool? bn_ = this.Qualifies(IP, "HEADNECK RT", av_, bm_);
		bool? bo_ = context.Operators.Or(bk_, bn_);
		decimal? bq_ = context.Operators.ConvertIntegerToDecimal(3092);
		bool? br_ = this.Qualifies(IP, "HEADNECK HD", av_, bq_);
		bool? bs_ = context.Operators.Or(bo_, br_);

		return bs_;
	}

	private IEnumerable<Observation> Numerator_Value()
	{
		IEnumerable<Observation> a_ = this.Denominator();
		bool? b_(Observation Denominator)
		{
			bool? d_ = this.CT_Scan_Qualifies(Denominator);

			return d_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Observation> Numerator() => 
		__Numerator.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
