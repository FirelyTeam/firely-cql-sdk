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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AlaraCTIQRFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Inpatient_Encounters_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			bool? g_ = context.Operators.Overlaps(e_, f_, null);
			Patient h_ = this.Patient();
			CqlDate i_ = context.Operators.Convert<CqlDate>(h_?.BirthDateElement?.Value);
			CqlDateTime k_ = context.Operators.Start(f_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
			bool? o_ = context.Operators.And(g_, n_);

			return o_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Inpatient Encounters")]
	public IEnumerable<Encounter> Qualifying_Inpatient_Encounters() => 
		__Qualifying_Inpatient_Encounters.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Observation> Initial_Population_Value()
	{
		CqlCode a_ = this.CT_dose_and_image_quality_category();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_(Observation CTScan)
		{
			IEnumerable<Encounter> f_ = this.Qualifying_Inpatient_Encounters();
			bool? g_(Encounter InpatientEncounters)
			{
				object k_ = FHIRHelpers_4_3_000.ToValue(CTScan?.Effective);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounters?.Period);
				bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, null);
				CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
				CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(k_);
				bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, r_, null);
				bool? t_ = context.Operators.And(o_, s_);

				return t_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			Observation i_(Encounter InpatientEncounters) => 
				CTScan;
			IEnumerable<Observation> j_ = context.Operators.Select<Encounter, Observation>(h_, i_);

			return j_;
		};
		IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

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
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(C?.Code);
			CqlCode g_ = this.Calculated_CT_global_noise();
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
			bool? i_ = context.Operators.Equivalent(f_, h_);
			object j_ = FHIRHelpers_4_3_000.ToValue(C?.Value);
			bool? k_ = context.Operators.Equal((j_ as CqlQuantity)?.unit, "[hnsf'U]");
			bool? l_ = context.Operators.And(i_, k_);

			return l_;
		};
		IEnumerable<Observation.ComponentComponent> b_ = context.Operators.Where<Observation.ComponentComponent>((Obs?.Component as IEnumerable<Observation.ComponentComponent>), a_);
		decimal? c_(Observation.ComponentComponent C)
		{
			object m_ = FHIRHelpers_4_3_000.ToValue(C?.Value);

			return (m_ as CqlQuantity)?.value;
		};
		IEnumerable<decimal?> d_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(b_, c_);
		decimal? e_ = context.Operators.SingletonFrom<decimal?>(d_);

		return e_;
	}

    [CqlDeclaration("Size Adjusted Value")]
	public decimal? Size_Adjusted_Value(Observation Obs)
	{
		bool? a_(Observation.ComponentComponent C)
		{
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(C?.Code);
			CqlCode g_ = this.Calculated_CT_size_adjusted_dose();
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
			bool? i_ = context.Operators.Equivalent(f_, h_);
			object j_ = FHIRHelpers_4_3_000.ToValue(C?.Value);
			bool? k_ = context.Operators.Equal((j_ as CqlQuantity)?.unit, "mGy.cm");
			bool? l_ = context.Operators.And(i_, k_);

			return l_;
		};
		IEnumerable<Observation.ComponentComponent> b_ = context.Operators.Where<Observation.ComponentComponent>((Obs?.Component as IEnumerable<Observation.ComponentComponent>), a_);
		decimal? c_(Observation.ComponentComponent C)
		{
			object m_ = FHIRHelpers_4_3_000.ToValue(C?.Value);

			return (m_ as CqlQuantity)?.value;
		};
		IEnumerable<decimal?> d_ = context.Operators.Select<Observation.ComponentComponent, decimal?>(b_, c_);
		decimal? e_ = context.Operators.SingletonFrom<decimal?>(d_);

		return e_;
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
			object i_ = FHIRHelpers_4_3_000.ToValue(IP?.Value);
			bool? j_ = context.Operators.Not((bool?)(i_ is null));
			bool? k_ = context.Operators.And(h_, j_);

			return k_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Observation> Denominator() => 
		__Denominator.Value;

    [CqlDeclaration("Qualifies")]
	public bool? Qualifies(Observation Obs, string code, decimal? noiseThreshold, decimal? sizeDoseThreshold)
	{
		object a_ = FHIRHelpers_4_3_000.ToValue(Obs?.Value);
		bool? b_(CqlCode @this)
		{
			bool? m_ = context.Operators.Not((bool?)(@this?.code is null));

			return m_;
		};
		IEnumerable<CqlCode> c_ = context.Operators.Where<CqlCode>(((a_ as CqlConcept)?.codes as IEnumerable<CqlCode>), b_);
		string d_(CqlCode @this) => 
			@this?.code;
		IEnumerable<string> e_ = context.Operators.Select<CqlCode, string>(c_, d_);
		bool? f_ = context.Operators.ListContains<string>(e_, code);
		decimal? g_ = this.Global_Noise_Value(Obs);
		bool? h_ = context.Operators.GreaterOrEqual(g_, noiseThreshold);
		decimal? i_ = this.Size_Adjusted_Value(Obs);
		bool? j_ = context.Operators.GreaterOrEqual(i_, sizeDoseThreshold);
		bool? k_ = context.Operators.Or(h_, j_);
		bool? l_ = context.Operators.And(f_, k_);

		return l_;
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
		bool? b_(Observation Denom)
		{
			bool? d_ = this.CT_Scan_Qualifies(Denom);

			return d_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Observation> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Observation> Denominator_Exclusion_Value()
	{
		IEnumerable<Observation> a_ = this.Denominator();
		bool? b_(Observation Denom)
		{
			object d_ = FHIRHelpers_4_3_000.ToValue(Denom?.Value);
			bool? e_(CqlCode @this)
			{
				bool? j_ = context.Operators.Not((bool?)(@this?.code is null));

				return j_;
			};
			IEnumerable<CqlCode> f_ = context.Operators.Where<CqlCode>(((d_ as CqlConcept)?.codes as IEnumerable<CqlCode>), e_);
			string g_(CqlCode @this) => 
				@this?.code;
			IEnumerable<string> h_ = context.Operators.Select<CqlCode, string>(f_, g_);
			bool? i_ = context.Operators.ListContains<string>(h_, "FULLBODY");

			return i_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public IEnumerable<Observation> Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

}
