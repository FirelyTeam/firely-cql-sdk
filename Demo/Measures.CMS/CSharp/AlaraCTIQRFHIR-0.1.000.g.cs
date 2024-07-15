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
[CqlLibrary("AlaraCTIQRFHIR", "0.1.000")]
public class AlaraCTIQRFHIR_0_1_000
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
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Inpatient_Encounters;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Observation>> __Initial_Population;
    internal Lazy<IEnumerable<Observation>> __Denominator;
    internal Lazy<IEnumerable<Observation>> __Numerator;
    internal Lazy<IEnumerable<Observation>> __Denominator_Exclusion;

    #endregion
    public AlaraCTIQRFHIR_0_1_000(CqlContext context)
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
        __Qualifying_Inpatient_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Inpatient_Encounters_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Initial_Population = new Lazy<IEnumerable<Observation>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Observation>>(this.Denominator_Value);
        __Numerator = new Lazy<IEnumerable<Observation>>(this.Numerator_Value);
        __Denominator_Exclusion = new Lazy<IEnumerable<Observation>>(this.Denominator_Exclusion_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

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
		var d_ = context.ResolveParameter("AlaraCTIQRFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Inpatient_Encounters_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			var e_ = InpatientEncounter?.Period;
			var f_ = FHIRHelpers_4_3_000.ToInterval(e_);
			var g_ = this.Measurement_Period();
			var h_ = context.Operators.Overlaps(f_, g_, null);
			var i_ = this.Patient();
			var j_ = i_?.BirthDateElement;
			var k_ = j_?.Value;
			var l_ = context.Operators.ConvertStringToDate(k_);
			var n_ = context.Operators.Start(g_);
			var o_ = context.Operators.DateFrom(n_);
			var p_ = context.Operators.CalculateAgeAt(l_, o_, "year");
			var q_ = context.Operators.GreaterOrEqual(p_, 18);
			var r_ = context.Operators.And(h_, q_);

			return r_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Inpatient Encounters")]
	public IEnumerable<Encounter> Qualifying_Inpatient_Encounters() => 
		__Qualifying_Inpatient_Encounters.Value;

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

	private IEnumerable<Observation> Initial_Population_Value()
	{
		var a_ = this.CT_dose_and_image_quality_category();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_(Observation CTScan)
		{
			var f_ = this.Qualifying_Inpatient_Encounters();
			bool? g_(Encounter InpatientEncounters)
			{
				var k_ = CTScan?.Effective;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.ToInterval(l_);
				var n_ = context.Operators.Start(m_);
				var o_ = InpatientEncounters?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.In<CqlDateTime>(n_, p_, null);
				var r_ = this.Measurement_Period();
				var t_ = FHIRHelpers_4_3_000.ToValue(k_);
				var u_ = QICoreCommon_2_0_000.ToInterval(t_);
				var v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, null);
				var w_ = context.Operators.And(q_, v_);

				return w_;
			};
			var h_ = context.Operators.Where<Encounter>(f_, g_);
			Observation i_(Encounter InpatientEncounters) => 
				CTScan;
			var j_ = context.Operators.Select<Encounter, Observation>(h_, i_);

			return j_;
		};
		var e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Observation> Initial_Population() => 
		__Initial_Population.Value;

    [CqlDeclaration("Global Noise Value")]
	public decimal? Global_Noise_Value(Observation Obs)
	{
		bool? a_(Observation.ComponentComponent C)
		{
			var f_ = C?.Code;
			var g_ = FHIRHelpers_4_3_000.ToConcept(f_);
			var h_ = this.Calculated_CT_global_noise();
			var i_ = context.Operators.ConvertCodeToConcept(h_);
			var j_ = context.Operators.Equivalent(g_, i_);
			var k_ = C?.Value;
			var l_ = FHIRHelpers_4_3_000.ToValue(k_);
			var m_ = (l_ as CqlQuantity)?.unit;
			var n_ = context.Operators.Equal(m_, "[hnsf'U]");
			var o_ = context.Operators.And(j_, n_);

			return o_;
		};
		var b_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)Obs?.Component, a_);
		decimal? c_(Observation.ComponentComponent C)
		{
			var p_ = C?.Value;
			var q_ = FHIRHelpers_4_3_000.ToValue(p_);
			var r_ = (q_ as CqlQuantity)?.value;

			return r_;
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
			var f_ = C?.Code;
			var g_ = FHIRHelpers_4_3_000.ToConcept(f_);
			var h_ = this.Calculated_CT_size_adjusted_dose();
			var i_ = context.Operators.ConvertCodeToConcept(h_);
			var j_ = context.Operators.Equivalent(g_, i_);
			var k_ = C?.Value;
			var l_ = FHIRHelpers_4_3_000.ToValue(k_);
			var m_ = (l_ as CqlQuantity)?.unit;
			var n_ = context.Operators.Equal(m_, "mGy.cm");
			var o_ = context.Operators.And(j_, n_);

			return o_;
		};
		var b_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)Obs?.Component, a_);
		decimal? c_(Observation.ComponentComponent C)
		{
			var p_ = C?.Value;
			var q_ = FHIRHelpers_4_3_000.ToValue(p_);
			var r_ = (q_ as CqlQuantity)?.value;

			return r_;
		};
		var d_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(b_, c_);
		var e_ = context.Operators.SingletonFrom<decimal?>(d_);

		return e_;
	}

	private IEnumerable<Observation> Denominator_Value()
	{
		var a_ = this.Initial_Population();
		bool? b_(Observation IP)
		{
			var d_ = this.Global_Noise_Value(IP);
			var e_ = context.Operators.Not((bool?)(d_ is null));
			var f_ = this.Size_Adjusted_Value(IP);
			var g_ = context.Operators.Not((bool?)(f_ is null));
			var h_ = context.Operators.And(e_, g_);
			var i_ = IP?.Value;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = context.Operators.Not((bool?)(j_ is null));
			var l_ = context.Operators.And(h_, k_);

			return l_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Observation> Denominator() => 
		__Denominator.Value;

    [CqlDeclaration("Qualifies")]
	public bool? Qualifies(Observation Obs, string code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
	{
		var a_ = FHIRHelpers_4_3_000.ToValue(Obs?.Value);
		bool? b_(CqlCode @this)
		{
			var m_ = @this?.code;
			var n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		var c_ = context.Operators.Where<CqlCode>(((IEnumerable<CqlCode>)(a_ as CqlConcept)?.codes), b_);
		string d_(CqlCode @this)
		{
			var o_ = @this?.code;

			return o_;
		};
		var e_ = context.Operators.Select<CqlCode, string>(c_, d_);
		var f_ = context.Operators.Contains<string>(e_, code);
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

	private IEnumerable<Observation> Numerator_Value()
	{
		var a_ = this.Denominator();
		bool? b_(Observation Denom)
		{
			var d_ = this.CT_Scan_Qualifies(Denom);

			return d_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Observation> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Observation> Denominator_Exclusion_Value()
	{
		var a_ = this.Denominator();
		bool? b_(Observation Denom)
		{
			var d_ = Denom?.Value;
			var e_ = FHIRHelpers_4_3_000.ToValue(d_);
			var f_ = (e_ as CqlConcept)?.codes;
			bool? g_(CqlCode @this)
			{
				var l_ = @this?.code;
				var m_ = context.Operators.Not((bool?)(l_ is null));

				return m_;
			};
			var h_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)f_, g_);
			string i_(CqlCode @this)
			{
				var n_ = @this?.code;

				return n_;
			};
			var j_ = context.Operators.Select<CqlCode, string>(h_, i_);
			var k_ = context.Operators.Contains<string>(j_, "FULLBODY");

			return k_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public IEnumerable<Observation> Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

}
