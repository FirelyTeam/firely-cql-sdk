using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("AlaraCTFHIR", "0.1.001")]
public class AlaraCTFHIR_0_1_001
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Calculated_CT_global_noise;
    internal Lazy<CqlCode> __Calculated_CT_size_adjusted_dose;
    internal Lazy<CqlCode> __CT_dose_and_image_quality_category;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Observation>> __Qualifying_CTScan;
    internal Lazy<IEnumerable<Observation>> __Qualifying_CTScan_with_Values;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Denominator_Exclusion;
    internal Lazy<bool?> __Numerator;

    #endregion
    public AlaraCTFHIR_0_1_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);

        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Calculated_CT_global_noise = new Lazy<CqlCode>(this.Calculated_CT_global_noise_Value);
        __Calculated_CT_size_adjusted_dose = new Lazy<CqlCode>(this.Calculated_CT_size_adjusted_dose_Value);
        __CT_dose_and_image_quality_category = new Lazy<CqlCode>(this.CT_dose_and_image_quality_category_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_CTScan = new Lazy<IEnumerable<Observation>>(this.Qualifying_CTScan_Value);
        __Qualifying_CTScan_with_Values = new Lazy<IEnumerable<Observation>>(this.Qualifying_CTScan_with_Values_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Denominator_Exclusion = new Lazy<bool?>(this.Denominator_Exclusion_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode Calculated_CT_global_noise_Value() => 
		new CqlCode("96912-1", "http://loinc.org", null, null);

    [CqlDeclaration("Calculated CT global noise")]
	public CqlCode Calculated_CT_global_noise() => 
		__Calculated_CT_global_noise.Value;

	private CqlCode Calculated_CT_size_adjusted_dose_Value() => 
		new CqlCode("96913-9", "http://loinc.org", null, null);

    [CqlDeclaration("Calculated CT size-adjusted dose")]
	public CqlCode Calculated_CT_size_adjusted_dose() => 
		__Calculated_CT_size_adjusted_dose.Value;

	private CqlCode CT_dose_and_image_quality_category_Value() => 
		new CqlCode("96914-7", "http://loinc.org", null, null);

    [CqlDeclaration("CT dose and image quality category")]
	public CqlCode CT_dose_and_image_quality_category() => 
		__CT_dose_and_image_quality_category.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
			new CqlCode("96912-1", "http://loinc.org", null, null),
			new CqlCode("96913-9", "http://loinc.org", null, null),
			new CqlCode("96914-7", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("AlaraCTFHIR-0.1.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Observation> Qualifying_CTScan_Value()
	{
		var a_ = this.CT_dose_and_image_quality_category();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation CTScanResult)
		{
			var f_ = this.Measurement_Period();
			var g_ = FHIRHelpers_4_3_000.ToValue(CTScanResult?.Effective);
			var h_ = QICoreCommon_2_0_000.ToInterval(g_);
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, null);
			var j_ = this.Patient();
			var k_ = context.Operators.ConvertStringToDateTime(j_?.BirthDateElement?.Value);
			var m_ = context.Operators.Start(f_);
			var n_ = context.Operators.CalculateAgeAt(k_, m_, "year");
			var o_ = context.Operators.GreaterOrEqual(n_, 18);
			var p_ = context.Operators.And(i_, o_);

			return p_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Qualifying CTScan")]
	public IEnumerable<Observation> Qualifying_CTScan() => 
		__Qualifying_CTScan.Value;

    [CqlDeclaration("Global Noise Value")]
	public decimal? Global_Noise_Value(Observation Obs)
	{
		bool? a_(Observation.ComponentComponent C)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(C?.Code);
			var g_ = this.Calculated_CT_global_noise();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(f_, h_);
			var j_ = FHIRHelpers_4_3_000.ToValue(C?.Value);
			var k_ = context.Operators.Equal((j_ as CqlQuantity)?.unit, "[hnsf'U]");
			var l_ = context.Operators.And(i_, k_);

			return l_;
		};
		var b_ = context.Operators.Where<Observation.ComponentComponent>((Obs?.Component as IEnumerable<Observation.ComponentComponent>), a_);
		decimal? c_(Observation.ComponentComponent C)
		{
			var m_ = FHIRHelpers_4_3_000.ToValue(C?.Value);

			return (m_ as CqlQuantity)?.value;
		};
		var d_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(b_, c_);
		var e_ = context.Operators.SingletonFrom<decimal?>(d_);

		return e_;
	}

    [CqlDeclaration("Size Adjusted Value")]
	public decimal? Size_Adjusted_Value(Observation Obs)
	{
		bool? a_(Observation.ComponentComponent C)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(C?.Code);
			var g_ = this.Calculated_CT_size_adjusted_dose();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(f_, h_);
			var j_ = FHIRHelpers_4_3_000.ToValue(C?.Value);
			var k_ = context.Operators.Equal((j_ as CqlQuantity)?.unit, "mGy.cm");
			var l_ = context.Operators.And(i_, k_);

			return l_;
		};
		var b_ = context.Operators.Where<Observation.ComponentComponent>((Obs?.Component as IEnumerable<Observation.ComponentComponent>), a_);
		decimal? c_(Observation.ComponentComponent C)
		{
			var m_ = FHIRHelpers_4_3_000.ToValue(C?.Value);

			return (m_ as CqlQuantity)?.value;
		};
		var d_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(b_, c_);
		var e_ = context.Operators.SingletonFrom<decimal?>(d_);

		return e_;
	}

	private IEnumerable<Observation> Qualifying_CTScan_with_Values_Value()
	{
		var a_ = this.Qualifying_CTScan();
		bool? b_(Observation CTScan)
		{
			var d_ = this.Global_Noise_Value(CTScan);
			var e_ = context.Operators.Not((bool?)(d_ is null));
			var f_ = this.Size_Adjusted_Value(CTScan);
			var g_ = context.Operators.Not((bool?)(f_ is null));
			var h_ = context.Operators.And(e_, g_);
			var i_ = FHIRHelpers_4_3_000.ToValue(CTScan?.Value);
			var j_ = context.Operators.Not((bool?)(i_ is null));
			var k_ = context.Operators.And(h_, j_);

			return k_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying CTScan with Values")]
	public IEnumerable<Observation> Qualifying_CTScan_with_Values() => 
		__Qualifying_CTScan_with_Values.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Qualifying_CTScan();
		var b_ = context.Operators.Exists<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Qualifying_CTScan_with_Values();
		var b_ = context.Operators.Exists<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private bool? Denominator_Exclusion_Value()
	{
		var a_ = this.Qualifying_CTScan_with_Values();
		bool? b_(Observation CTScan)
		{
			var e_ = FHIRHelpers_4_3_000.ToValue(CTScan?.Value);
			bool? f_(CqlCode @this)
			{
				var k_ = context.Operators.Not((bool?)(@this?.code is null));

				return k_;
			};
			var g_ = context.Operators.Where<CqlCode>(((e_ as CqlConcept)?.codes as IEnumerable<CqlCode>), f_);
			string h_(CqlCode @this) => 
				@this?.code;
			var i_ = context.Operators.Select<CqlCode, string>(g_, h_);
			var j_ = context.Operators.ListContains<string>(i_, "FULLBODY");

			return j_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);
		var d_ = context.Operators.Exists<Observation>(c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public bool? Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

    [CqlDeclaration("Qualifies")]
	public bool? Qualifies(Observation Obs, string code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
	{
		var a_ = FHIRHelpers_4_3_000.ToValue(Obs?.Value);
		bool? b_(CqlCode @this)
		{
			var m_ = context.Operators.Not((bool?)(@this?.code is null));

			return m_;
		};
		var c_ = context.Operators.Where<CqlCode>(((a_ as CqlConcept)?.codes as IEnumerable<CqlCode>), b_);
		string d_(CqlCode @this) => 
			@this?.code;
		var e_ = context.Operators.Select<CqlCode, string>(c_, d_);
		var f_ = context.Operators.ListContains<string>(e_, code);
		var g_ = this.Global_Noise_Value(Obs);
		var h_ = context.Operators.GreaterOrEqual(g_, noiseThreshold);
		var i_ = this.Size_Adjusted_Value(Obs);
		var j_ = context.Operators.GreaterOrEqual(i_, sizeDoseThreshold);
		var k_ = context.Operators.Or(h_, j_);
		var l_ = context.Operators.And(f_, k_);

		return l_;
	}

    [CqlDeclaration("CT Scan Qualifies")]
	public bool? CT_Scan_Qualifies(Observation IP)
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(64);
		var b_ = context.Operators.ConvertIntegerToDecimal(598);
		var c_ = this.Qualifies(IP, "ABDOPEL LD", a_, b_);
		var d_ = context.Operators.ConvertIntegerToDecimal(29);
		var e_ = context.Operators.ConvertIntegerToDecimal(644);
		var f_ = this.Qualifies(IP, "ABDOPEL RT", d_, e_);
		var g_ = context.Operators.Or(c_, f_);
		var i_ = context.Operators.ConvertIntegerToDecimal(1260);
		var j_ = this.Qualifies(IP, "ABDOPEL HD", d_, i_);
		var k_ = context.Operators.Or(g_, j_);
		var l_ = context.Operators.ConvertIntegerToDecimal(55);
		var m_ = context.Operators.ConvertIntegerToDecimal(93);
		var n_ = this.Qualifies(IP, "CARDIAC LD", l_, m_);
		var o_ = context.Operators.Or(k_, n_);
		var p_ = context.Operators.ConvertIntegerToDecimal(32);
		var q_ = context.Operators.ConvertIntegerToDecimal(576);
		var r_ = this.Qualifies(IP, "CARDIAC RT", p_, q_);
		var s_ = context.Operators.Or(o_, r_);
		var u_ = context.Operators.ConvertIntegerToDecimal(377);
		var v_ = this.Qualifies(IP, "CHEST LD", l_, u_);
		var w_ = context.Operators.Or(s_, v_);
		var x_ = context.Operators.ConvertIntegerToDecimal(49);
		var z_ = this.Qualifies(IP, "CHEST RT", x_, u_);
		var aa_ = context.Operators.Or(w_, z_);
		var ac_ = context.Operators.ConvertIntegerToDecimal(1282);
		var ad_ = this.Qualifies(IP, "CHEST-CARDIAC HD", x_, ac_);
		var ae_ = context.Operators.Or(aa_, ad_);
		var af_ = context.Operators.ConvertIntegerToDecimal(115);
		var ag_ = context.Operators.ConvertIntegerToDecimal(582);
		var ah_ = this.Qualifies(IP, "HEAD LD", af_, ag_);
		var ai_ = context.Operators.Or(ae_, ah_);
		var ak_ = context.Operators.ConvertIntegerToDecimal(1025);
		var al_ = this.Qualifies(IP, "HEAD RT", af_, ak_);
		var am_ = context.Operators.Or(ai_, al_);
		var ao_ = context.Operators.ConvertIntegerToDecimal(1832);
		var ap_ = this.Qualifies(IP, "HEAD HD", af_, ao_);
		var aq_ = context.Operators.Or(am_, ap_);
		var ar_ = context.Operators.ConvertIntegerToDecimal(73);
		var as_ = context.Operators.ConvertIntegerToDecimal(320);
		var at_ = this.Qualifies(IP, "EXTREMITIES", ar_, as_);
		var au_ = context.Operators.Or(aq_, at_);
		var av_ = context.Operators.ConvertIntegerToDecimal(25);
		var ax_ = this.Qualifies(IP, "NECK-CSPINE", av_, i_);
		var ay_ = context.Operators.Or(au_, ax_);
		var bb_ = this.Qualifies(IP, "TSPINE-LSPINE", av_, i_);
		var bc_ = context.Operators.Or(ay_, bb_);
		var be_ = context.Operators.ConvertIntegerToDecimal(1637);
		var bf_ = this.Qualifies(IP, "CAP", d_, be_);
		var bg_ = context.Operators.Or(bc_, bf_);
		var bi_ = context.Operators.ConvertIntegerToDecimal(2520);
		var bj_ = this.Qualifies(IP, "TLSPINE", av_, bi_);
		var bk_ = context.Operators.Or(bg_, bj_);
		var bm_ = context.Operators.ConvertIntegerToDecimal(2285);
		var bn_ = this.Qualifies(IP, "HEADNECK RT", av_, bm_);
		var bo_ = context.Operators.Or(bk_, bn_);
		var bq_ = context.Operators.ConvertIntegerToDecimal(3092);
		var br_ = this.Qualifies(IP, "HEADNECK HD", av_, bq_);
		var bs_ = context.Operators.Or(bo_, br_);

		return bs_;
	}

	private bool? Numerator_Value()
	{
		var a_ = this.Qualifying_CTScan_with_Values();
		bool? b_(Observation CTScan)
		{
			var e_ = this.CT_Scan_Qualifies(CTScan);

			return e_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);
		var d_ = context.Operators.Exists<Observation>(c_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
