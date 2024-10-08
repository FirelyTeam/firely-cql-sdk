using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", default);

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
	public CqlValueSet Colonoscopy() => 
		__Colonoscopy.Value;

	private CqlValueSet CT_Colonography_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", default);

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
	public CqlValueSet CT_Colonography() => 
		__CT_Colonography.Value;

	private CqlValueSet Fecal_Occult_Blood_Test__FOBT__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", default);

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
	public CqlValueSet Fecal_Occult_Blood_Test__FOBT_() => 
		__Fecal_Occult_Blood_Test__FOBT_.Value;

	private CqlValueSet sDNA_FIT_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", default);

    [CqlDeclaration("sDNA FIT Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
	public CqlValueSet sDNA_FIT_Test() => 
		__sDNA_FIT_Test.Value;

	private CqlValueSet Flexible_Sigmoidoscopy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", default);

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
	public CqlValueSet Flexible_Sigmoidoscopy() => 
		__Flexible_Sigmoidoscopy.Value;

	private CqlValueSet Malignant_Neoplasm_of_Colon_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", default);

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
	public CqlValueSet Malignant_Neoplasm_of_Colon() => 
		__Malignant_Neoplasm_of_Colon.Value;

	private CqlValueSet Total_Colectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", default);

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
	public CqlValueSet Total_Colectomy() => 
		__Total_Colectomy.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ColonCancerScreeningFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

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

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(46, 75, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = AdultOutpatientEncounters_4_8_000.Qualifying_Encounters();
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);

		return m_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Condition> Malignant_Neoplasm_Value()
	{
		CqlValueSet a_ = this.Malignant_Neoplasm_of_Colon();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition ColorectalCancer)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(ColorectalCancer);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.End(h_);
			bool? j_ = context.Operators.SameOrBefore(g_, i_, "day");

			return j_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Malignant Neoplasm")]
	public IEnumerable<Condition> Malignant_Neoplasm() => 
		__Malignant_Neoplasm.Value;

	private IEnumerable<Procedure> Total_Colectomy_Performed_Value()
	{
		CqlValueSet a_ = this.Total_Colectomy();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure Colectomy)
		{
			DataType f_ = Colectomy?.Performed;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.End(j_);
			bool? l_ = context.Operators.SameOrBefore(i_, k_, "day");

			return l_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Total Colectomy Performed")]
	public IEnumerable<Procedure> Total_Colectomy_Performed() => 
		__Total_Colectomy_Performed.Value;

	private bool? Denominator_Exclusion_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		IEnumerable<Condition> b_ = this.Malignant_Neoplasm();
		bool? c_ = context.Operators.Exists<Condition>(b_);
		bool? d_ = context.Operators.Or(a_, c_);
		IEnumerable<Procedure> e_ = this.Total_Colectomy_Performed();
		bool? f_ = context.Operators.Exists<Procedure>(e_);
		bool? g_ = context.Operators.Or(d_, f_);
		bool? h_ = AdvancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty();
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = AdvancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home();
		bool? k_ = context.Operators.Or(i_, j_);
		bool? l_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		bool? m_ = context.Operators.Or(k_, l_);

		return m_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public bool? Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Value()
	{
		CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation FecalOccultResult)
		{
			DataType f_ = FecalOccultResult?.Value;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			bool? h_ = context.Operators.Not((bool?)(g_ is null));
			object i_()
			{
				bool n_()
				{
					DataType q_ = FecalOccultResult?.Effective;
					object r_ = FHIRHelpers_4_3_000.ToValue(q_);
					bool s_ = r_ is CqlDateTime;

					return s_;
				};
				bool o_()
				{
					DataType t_ = FecalOccultResult?.Effective;
					object u_ = FHIRHelpers_4_3_000.ToValue(t_);
					bool v_ = u_ is CqlInterval<CqlDateTime>;

					return v_;
				};
				bool p_()
				{
					DataType w_ = FecalOccultResult?.Effective;
					object x_ = FHIRHelpers_4_3_000.ToValue(w_);
					bool y_ = x_ is CqlDateTime;

					return y_;
				};
				if (n_())
				{
					DataType z_ = FecalOccultResult?.Effective;
					object aa_ = FHIRHelpers_4_3_000.ToValue(z_);

					return (aa_ as CqlDateTime) as object;
				}
				else if (o_())
				{
					DataType ab_ = FecalOccultResult?.Effective;
					object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);

					return (ac_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (p_())
				{
					DataType ad_ = FecalOccultResult?.Effective;
					object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);

					return (ae_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime j_ = QICoreCommon_2_0_000.Latest(i_());
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed() => 
		__Fecal_Occult_Blood_Test_Performed.Value;

	private IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed_Value()
	{
		CqlValueSet a_ = this.sDNA_FIT_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation sDNATest)
		{
			DataType f_ = sDNATest?.Value;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			bool? h_ = context.Operators.Not((bool?)(g_ is null));
			object i_()
			{
				bool t_()
				{
					DataType w_ = sDNATest?.Effective;
					object x_ = FHIRHelpers_4_3_000.ToValue(w_);
					bool y_ = x_ is CqlDateTime;

					return y_;
				};
				bool u_()
				{
					DataType z_ = sDNATest?.Effective;
					object aa_ = FHIRHelpers_4_3_000.ToValue(z_);
					bool ab_ = aa_ is CqlInterval<CqlDateTime>;

					return ab_;
				};
				bool v_()
				{
					DataType ac_ = sDNATest?.Effective;
					object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
					bool ae_ = ad_ is CqlDateTime;

					return ae_;
				};
				if (t_())
				{
					DataType af_ = sDNATest?.Effective;
					object ag_ = FHIRHelpers_4_3_000.ToValue(af_);

					return (ag_ as CqlDateTime) as object;
				}
				else if (u_())
				{
					DataType ah_ = sDNATest?.Effective;
					object ai_ = FHIRHelpers_4_3_000.ToValue(ah_);

					return (ai_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (v_())
				{
					DataType aj_ = sDNATest?.Effective;
					object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);

					return (ak_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime j_ = QICoreCommon_2_0_000.Latest(i_());
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlQuantity m_ = context.Operators.Quantity(2m, "years");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlDateTime p_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");
			bool? s_ = context.Operators.And(h_, r_);

			return s_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Stool DNA with FIT Test Performed")]
	public IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed() => 
		__Stool_DNA_with_FIT_Test_Performed.Value;

	private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Value()
	{
		CqlValueSet a_ = this.Flexible_Sigmoidoscopy();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure FlexibleSigmoidoscopy)
		{
			DataType f_ = FlexibleSigmoidoscopy?.Performed;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlQuantity l_ = context.Operators.Quantity(4m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

			return q_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
	public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed() => 
		__Flexible_Sigmoidoscopy_Performed.Value;

	private IEnumerable<Observation> CT_Colonography_Performed_Value()
	{
		CqlValueSet a_ = this.CT_Colonography();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.Final_Observation(b_);
		bool? d_(Observation Colonography)
		{
			DataType f_ = Colonography?.Effective;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlQuantity l_ = context.Operators.Quantity(4m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

			return q_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("CT Colonography Performed")]
	public IEnumerable<Observation> CT_Colonography_Performed() => 
		__CT_Colonography_Performed.Value;

	private IEnumerable<Procedure> Colonoscopy_Performed_Value()
	{
		CqlValueSet a_ = this.Colonoscopy();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure Colonoscopy)
		{
			DataType f_ = Colonoscopy?.Performed;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlQuantity l_ = context.Operators.Quantity(9m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, "day");

			return q_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Colonoscopy Performed")]
	public IEnumerable<Procedure> Colonoscopy_Performed() => 
		__Colonoscopy_Performed.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<Observation> a_ = this.Fecal_Occult_Blood_Test_Performed();
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.Stool_DNA_with_FIT_Test_Performed();
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<Procedure> f_ = this.Flexible_Sigmoidoscopy_Performed();
		bool? g_ = context.Operators.Exists<Procedure>(f_);
		bool? h_ = context.Operators.Or(e_, g_);
		IEnumerable<Observation> i_ = this.CT_Colonography_Performed();
		bool? j_ = context.Operators.Exists<Observation>(i_);
		bool? k_ = context.Operators.Or(h_, j_);
		IEnumerable<Procedure> l_ = this.Colonoscopy_Performed();
		bool? m_ = context.Operators.Exists<Procedure>(l_);
		bool? n_ = context.Operators.Or(k_, m_);

		return n_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Stratification_1_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(46, 49, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratification 1")]
	public bool? Stratification_1() => 
		__Stratification_1.Value;

	private bool? Stratification_2_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(50, 75, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratification 2")]
	public bool? Stratification_2() => 
		__Stratification_2.Value;

}
