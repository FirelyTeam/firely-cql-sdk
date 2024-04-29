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
[CqlLibrary("ColonCancerScreeningFHIR", "0.1.000")]
public class ColonCancerScreeningFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Colonoscopy;
    internal Lazy<CqlValueSet> __CT_Colonography;
    internal Lazy<CqlValueSet> __Fecal_Occult_Blood_Test__FOBT_;
    internal Lazy<CqlValueSet> __sDNA_FIT_Test;
    internal Lazy<CqlValueSet> __Flexible_Sigmoidoscopy;
    internal Lazy<CqlValueSet> __Malignant_Neoplasm_of_Colon;
    internal Lazy<CqlValueSet> __Total_Colectomy;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Malignant_Neoplasm;
    internal Lazy<IEnumerable<Procedure>> __Total_Colectomy_Performed;
    internal Lazy<bool?> __Denominator_Exclusion;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed;
    internal Lazy<IEnumerable<Observation>> __Stool_DNA_with_FIT_Test_Performed;
    internal Lazy<IEnumerable<Procedure>> __Flexible_Sigmoidoscopy_Performed;
    internal Lazy<IEnumerable<Observation>> __CT_Colonography_Performed;
    internal Lazy<IEnumerable<Procedure>> __Colonoscopy_Performed;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Stratification_1;
    internal Lazy<bool?> __Stratification_2;

    #endregion
    public ColonCancerScreeningFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        PalliativeCare_1_9_000 = new PalliativeCare_1_9_000(context);
        AdultOutpatientEncounters_4_8_000 = new AdultOutpatientEncounters_4_8_000(context);
        AdvancedIllnessandFrailty_1_8_000 = new AdvancedIllnessandFrailty_1_8_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Colonoscopy = new Lazy<CqlValueSet>(this.Colonoscopy_Value);
        __CT_Colonography = new Lazy<CqlValueSet>(this.CT_Colonography_Value);
        __Fecal_Occult_Blood_Test__FOBT_ = new Lazy<CqlValueSet>(this.Fecal_Occult_Blood_Test__FOBT__Value);
        __sDNA_FIT_Test = new Lazy<CqlValueSet>(this.sDNA_FIT_Test_Value);
        __Flexible_Sigmoidoscopy = new Lazy<CqlValueSet>(this.Flexible_Sigmoidoscopy_Value);
        __Malignant_Neoplasm_of_Colon = new Lazy<CqlValueSet>(this.Malignant_Neoplasm_of_Colon_Value);
        __Total_Colectomy = new Lazy<CqlValueSet>(this.Total_Colectomy_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Malignant_Neoplasm = new Lazy<IEnumerable<Condition>>(this.Malignant_Neoplasm_Value);
        __Total_Colectomy_Performed = new Lazy<IEnumerable<Procedure>>(this.Total_Colectomy_Performed_Value);
        __Denominator_Exclusion = new Lazy<bool?>(this.Denominator_Exclusion_Value);
        __Fecal_Occult_Blood_Test_Performed = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed_Value);
        __Stool_DNA_with_FIT_Test_Performed = new Lazy<IEnumerable<Observation>>(this.Stool_DNA_with_FIT_Test_Performed_Value);
        __Flexible_Sigmoidoscopy_Performed = new Lazy<IEnumerable<Procedure>>(this.Flexible_Sigmoidoscopy_Performed_Value);
        __CT_Colonography_Performed = new Lazy<IEnumerable<Observation>>(this.CT_Colonography_Performed_Value);
        __Colonoscopy_Performed = new Lazy<IEnumerable<Procedure>>(this.Colonoscopy_Performed_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Stratification_1 = new Lazy<bool?>(this.Stratification_1_Value);
        __Stratification_2 = new Lazy<bool?>(this.Stratification_2_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public PalliativeCare_1_9_000 PalliativeCare_1_9_000 { get; }
    public AdultOutpatientEncounters_4_8_000 AdultOutpatientEncounters_4_8_000 { get; }
    public AdvancedIllnessandFrailty_1_8_000 AdvancedIllnessandFrailty_1_8_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Colonoscopy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
	public CqlValueSet Colonoscopy() => 
		__Colonoscopy.Value;

	private CqlValueSet CT_Colonography_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
	public CqlValueSet CT_Colonography() => 
		__CT_Colonography.Value;

	private CqlValueSet Fecal_Occult_Blood_Test__FOBT__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
	public CqlValueSet Fecal_Occult_Blood_Test__FOBT_() => 
		__Fecal_Occult_Blood_Test__FOBT_.Value;

	private CqlValueSet sDNA_FIT_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

    [CqlDeclaration("sDNA FIT Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
	public CqlValueSet sDNA_FIT_Test() => 
		__sDNA_FIT_Test.Value;

	private CqlValueSet Flexible_Sigmoidoscopy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
	public CqlValueSet Flexible_Sigmoidoscopy() => 
		__Flexible_Sigmoidoscopy.Value;

	private CqlValueSet Malignant_Neoplasm_of_Colon_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
	public CqlValueSet Malignant_Neoplasm_of_Colon() => 
		__Malignant_Neoplasm_of_Colon.Value;

	private CqlValueSet Total_Colectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
	public CqlValueSet Total_Colectomy() => 
		__Total_Colectomy.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("ColonCancerScreeningFHIR-0.1.000", "Measurement Period", c_);

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

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(46, 75, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);
		var i_ = AdultOutpatientEncounters_4_8_000.Qualifying_Encounters();
		var j_ = context.Operators.Exists<Encounter>(i_);
		var k_ = context.Operators.And(h_, j_);

		return k_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Condition> Malignant_Neoplasm_Value()
	{
		var a_ = this.Malignant_Neoplasm_of_Colon();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition ColorectalCancer)
		{
			var f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(ColorectalCancer);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.SameOrBefore(g_, i_, "day");

			return j_;
		};
		var e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Malignant Neoplasm")]
	public IEnumerable<Condition> Malignant_Neoplasm() => 
		__Malignant_Neoplasm.Value;

	private IEnumerable<Procedure> Total_Colectomy_Performed_Value()
	{
		var a_ = this.Total_Colectomy();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure Colectomy)
		{
			var f_ = FHIRHelpers_4_3_000.ToValue(Colectomy?.Performed);
			var g_ = QICoreCommon_2_0_000.ToInterval(f_);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.End(i_);
			var k_ = context.Operators.SameOrBefore(h_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Total Colectomy Performed")]
	public IEnumerable<Procedure> Total_Colectomy_Performed() => 
		__Total_Colectomy_Performed.Value;

	private bool? Denominator_Exclusion_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = this.Malignant_Neoplasm();
		var c_ = context.Operators.Exists<Condition>(b_);
		var d_ = context.Operators.Or(a_, c_);
		var e_ = this.Total_Colectomy_Performed();
		var f_ = context.Operators.Exists<Procedure>(e_);
		var g_ = context.Operators.Or(d_, f_);
		var h_ = AdvancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty();
		var i_ = context.Operators.Or(g_, h_);
		var j_ = AdvancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home();
		var k_ = context.Operators.Or(i_, j_);
		var l_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		var m_ = context.Operators.Or(k_, l_);

		return m_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public bool? Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation FecalOccultResult)
		{
			var f_ = FHIRHelpers_4_3_000.ToValue(FecalOccultResult?.Value);
			var g_ = context.Operators.Not((bool?)(f_ is null));
			object h_()
			{
				bool m_()
				{
					var p_ = FHIRHelpers_4_3_000.ToValue(FecalOccultResult?.Effective);
					var q_ = p_ is CqlDateTime;

					return q_;
				};
				bool n_()
				{
					var r_ = FHIRHelpers_4_3_000.ToValue(FecalOccultResult?.Effective);
					var s_ = r_ is CqlInterval<CqlDateTime>;

					return s_;
				};
				bool o_()
				{
					var t_ = FHIRHelpers_4_3_000.ToValue(FecalOccultResult?.Effective);
					var u_ = t_ is CqlDateTime;

					return u_;
				};
				if (m_())
				{
					var v_ = FHIRHelpers_4_3_000.ToValue(FecalOccultResult?.Effective);

					return ((v_ as CqlDateTime) as object);
				}
				else if (n_())
				{
					var w_ = FHIRHelpers_4_3_000.ToValue(FecalOccultResult?.Effective);

					return ((w_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (o_())
				{
					var x_ = FHIRHelpers_4_3_000.ToValue(FecalOccultResult?.Effective);

					return ((x_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var i_ = QICoreCommon_2_0_000.Latest(h_());
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");
			var l_ = context.Operators.And(g_, k_);

			return l_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed() => 
		__Fecal_Occult_Blood_Test_Performed.Value;

	private IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed_Value()
	{
		var a_ = this.sDNA_FIT_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation sDNATest)
		{
			var f_ = FHIRHelpers_4_3_000.ToValue(sDNATest?.Value);
			var g_ = context.Operators.Not((bool?)(f_ is null));
			object h_()
			{
				bool s_()
				{
					var v_ = FHIRHelpers_4_3_000.ToValue(sDNATest?.Effective);
					var w_ = v_ is CqlDateTime;

					return w_;
				};
				bool t_()
				{
					var x_ = FHIRHelpers_4_3_000.ToValue(sDNATest?.Effective);
					var y_ = x_ is CqlInterval<CqlDateTime>;

					return y_;
				};
				bool u_()
				{
					var z_ = FHIRHelpers_4_3_000.ToValue(sDNATest?.Effective);
					var aa_ = z_ is CqlDateTime;

					return aa_;
				};
				if (s_())
				{
					var ab_ = FHIRHelpers_4_3_000.ToValue(sDNATest?.Effective);

					return ((ab_ as CqlDateTime) as object);
				}
				else if (t_())
				{
					var ac_ = FHIRHelpers_4_3_000.ToValue(sDNATest?.Effective);

					return ((ac_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (u_())
				{
					var ad_ = FHIRHelpers_4_3_000.ToValue(sDNATest?.Effective);

					return ((ad_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var i_ = QICoreCommon_2_0_000.Latest(h_());
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.Quantity(2m, "years");
			var m_ = context.Operators.Subtract(k_, l_);
			var o_ = context.Operators.End(j_);
			var p_ = context.Operators.Interval(m_, o_, true, true);
			var q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");
			var r_ = context.Operators.And(g_, q_);

			return r_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stool DNA with FIT Test Performed")]
	public IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed() => 
		__Stool_DNA_with_FIT_Test_Performed.Value;

	private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Value()
	{
		var a_ = this.Flexible_Sigmoidoscopy();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure FlexibleSigmoidoscopy)
		{
			var f_ = FHIRHelpers_4_3_000.ToValue(FlexibleSigmoidoscopy?.Performed);
			var g_ = QICoreCommon_2_0_000.ToInterval(f_);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.Start(i_);
			var k_ = context.Operators.Quantity(4m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.In<CqlDateTime>(h_, o_, "day");

			return p_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
	public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed() => 
		__Flexible_Sigmoidoscopy_Performed.Value;

	private IEnumerable<Observation> CT_Colonography_Performed_Value()
	{
		var a_ = this.CT_Colonography();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.Final_Observation(b_);
		bool? d_(Observation Colonography)
		{
			var f_ = FHIRHelpers_4_3_000.ToValue(Colonography?.Effective);
			var g_ = QICoreCommon_2_0_000.ToInterval(f_);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.Start(i_);
			var k_ = context.Operators.Quantity(4m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.In<CqlDateTime>(h_, o_, "day");

			return p_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("CT Colonography Performed")]
	public IEnumerable<Observation> CT_Colonography_Performed() => 
		__CT_Colonography_Performed.Value;

	private IEnumerable<Procedure> Colonoscopy_Performed_Value()
	{
		var a_ = this.Colonoscopy();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure Colonoscopy)
		{
			var f_ = FHIRHelpers_4_3_000.ToValue(Colonoscopy?.Performed);
			var g_ = QICoreCommon_2_0_000.ToInterval(f_);
			var h_ = context.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.Start(i_);
			var k_ = context.Operators.Quantity(9m, "years");
			var l_ = context.Operators.Subtract(j_, k_);
			var n_ = context.Operators.End(i_);
			var o_ = context.Operators.Interval(l_, n_, true, true);
			var p_ = context.Operators.In<CqlDateTime>(h_, o_, "day");

			return p_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Colonoscopy Performed")]
	public IEnumerable<Procedure> Colonoscopy_Performed() => 
		__Colonoscopy_Performed.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test_Performed();
		var b_ = context.Operators.Exists<Observation>(a_);
		var c_ = this.Stool_DNA_with_FIT_Test_Performed();
		var d_ = context.Operators.Exists<Observation>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Flexible_Sigmoidoscopy_Performed();
		var g_ = context.Operators.Exists<Procedure>(f_);
		var h_ = context.Operators.Or(e_, g_);
		var i_ = this.CT_Colonography_Performed();
		var j_ = context.Operators.Exists<Observation>(i_);
		var k_ = context.Operators.Or(h_, j_);
		var l_ = this.Colonoscopy_Performed();
		var m_ = context.Operators.Exists<Procedure>(l_);
		var n_ = context.Operators.Or(k_, m_);

		return n_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Stratification_1_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(46, 49, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);

		return h_;
	}

    [CqlDeclaration("Stratification 1")]
	public bool? Stratification_1() => 
		__Stratification_1.Value;

	private bool? Stratification_2_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(50, 75, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);

		return h_;
	}

    [CqlDeclaration("Stratification 2")]
	public bool? Stratification_2() => 
		__Stratification_2.Value;

}
