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
[CqlLibrary("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR", "0.1.000")]
public class DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Diabetes;
    internal Lazy<CqlValueSet> __HbA1c_Laboratory_Test;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<Observation> __Most_Recent_HbA1c;
    internal Lazy<bool?> __Has_Most_Recent_HbA1c_Without_Result;
    internal Lazy<bool?> __Has_Most_Recent_Elevated_HbA1c;
    internal Lazy<bool?> __Has_No_Record_Of_HbA1c;
    internal Lazy<bool?> __Numerator;

    #endregion
    public DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);
        AdultOutpatientEncounters_4_8_000 = new AdultOutpatientEncounters_4_8_000(context);
        AdvancedIllnessandFrailty_1_8_000 = new AdvancedIllnessandFrailty_1_8_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        PalliativeCare_1_9_000 = new PalliativeCare_1_9_000(context);

        __Diabetes = new Lazy<CqlValueSet>(this.Diabetes_Value);
        __HbA1c_Laboratory_Test = new Lazy<CqlValueSet>(this.HbA1c_Laboratory_Test_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Most_Recent_HbA1c = new Lazy<Observation>(this.Most_Recent_HbA1c_Value);
        __Has_Most_Recent_HbA1c_Without_Result = new Lazy<bool?>(this.Has_Most_Recent_HbA1c_Without_Result_Value);
        __Has_Most_Recent_Elevated_HbA1c = new Lazy<bool?>(this.Has_Most_Recent_Elevated_HbA1c_Value);
        __Has_No_Record_Of_HbA1c = new Lazy<bool?>(this.Has_No_Record_Of_HbA1c_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }
    public AdultOutpatientEncounters_4_8_000 AdultOutpatientEncounters_4_8_000 { get; }
    public AdvancedIllnessandFrailty_1_8_000 AdvancedIllnessandFrailty_1_8_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public PalliativeCare_1_9_000 PalliativeCare_1_9_000 { get; }

    #endregion

	private CqlValueSet Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes() => 
		__Diabetes.Value;

	private CqlValueSet HbA1c_Laboratory_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", default);

    [CqlDeclaration("HbA1c Laboratory Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013")]
	public CqlValueSet HbA1c_Laboratory_Test() => 
		__HbA1c_Laboratory_Test.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.1.000", "Measurement Period", c_);

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
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(18, 75, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = AdultOutpatientEncounters_4_8_000.Qualifying_Encounters();
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);
		CqlValueSet n_ = this.Diabetes();
		IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? p_(Condition Diabetes)
		{
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Diabetes);
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
			bool? v_ = context.Operators.Overlaps(t_, u_, default);

			return v_;
		};
		IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
		bool? r_ = context.Operators.Exists<Condition>(q_);
		bool? s_ = context.Operators.And(m_, r_);

		return s_;
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

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		bool? b_ = AdvancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = AdvancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home();
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		bool? g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private Observation Most_Recent_HbA1c_Value()
	{
		CqlValueSet a_ = this.HbA1c_Laboratory_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.isLaboratoryTestPerformed(b_);
		bool? d_(Observation RecentHbA1c)
		{
			object i_()
			{
				bool m_()
				{
					DataType p_ = RecentHbA1c?.Effective;
					object q_ = FHIRHelpers_4_3_000.ToValue(p_);
					bool r_ = q_ is CqlDateTime;

					return r_;
				};
				bool n_()
				{
					DataType s_ = RecentHbA1c?.Effective;
					object t_ = FHIRHelpers_4_3_000.ToValue(s_);
					bool u_ = t_ is CqlInterval<CqlDateTime>;

					return u_;
				};
				bool o_()
				{
					DataType v_ = RecentHbA1c?.Effective;
					object w_ = FHIRHelpers_4_3_000.ToValue(v_);
					bool x_ = w_ is CqlDateTime;

					return x_;
				};
				if (m_())
				{
					DataType y_ = RecentHbA1c?.Effective;
					object z_ = FHIRHelpers_4_3_000.ToValue(y_);

					return (z_ as CqlDateTime) as object;
				}
				else if (n_())
				{
					DataType aa_ = RecentHbA1c?.Effective;
					object ab_ = FHIRHelpers_4_3_000.ToValue(aa_);

					return (ab_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (o_())
				{
					DataType ac_ = RecentHbA1c?.Effective;
					object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);

					return (ad_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime j_ = QICoreCommon_2_0_000.Latest(i_());
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");

			return l_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType ae_ = @this?.Effective;
			object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlDateTime ah_ = context.Operators.Start(ag_);

			return ah_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);

		return h_;
	}

    [CqlDeclaration("Most Recent HbA1c")]
	public Observation Most_Recent_HbA1c() => 
		__Most_Recent_HbA1c.Value;

	private bool? Has_Most_Recent_HbA1c_Without_Result_Value()
	{
		Observation a_ = this.Most_Recent_HbA1c();
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		DataType d_ = a_?.Value;
		object e_ = FHIRHelpers_4_3_000.ToValue(d_);
		bool? f_ = context.Operators.And(b_, (bool?)(e_ is null));

		return f_;
	}

    [CqlDeclaration("Has Most Recent HbA1c Without Result")]
	public bool? Has_Most_Recent_HbA1c_Without_Result() => 
		__Has_Most_Recent_HbA1c_Without_Result.Value;

	private bool? Has_Most_Recent_Elevated_HbA1c_Value()
	{
		Observation a_ = this.Most_Recent_HbA1c();
		DataType b_ = a_?.Value;
		object c_ = FHIRHelpers_4_3_000.ToValue(b_);
		CqlQuantity d_ = context.Operators.Quantity(9m, "%");
		bool? e_ = context.Operators.Greater(c_ as CqlQuantity, d_);

		return e_;
	}

    [CqlDeclaration("Has Most Recent Elevated HbA1c")]
	public bool? Has_Most_Recent_Elevated_HbA1c() => 
		__Has_Most_Recent_Elevated_HbA1c.Value;

	private bool? Has_No_Record_Of_HbA1c_Value()
	{
		CqlValueSet a_ = this.HbA1c_Laboratory_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.isLaboratoryTestPerformed(b_);
		bool? d_(Observation NoHbA1c)
		{
			object h_()
			{
				bool l_()
				{
					DataType o_ = NoHbA1c?.Effective;
					object p_ = FHIRHelpers_4_3_000.ToValue(o_);
					bool q_ = p_ is CqlDateTime;

					return q_;
				};
				bool m_()
				{
					DataType r_ = NoHbA1c?.Effective;
					object s_ = FHIRHelpers_4_3_000.ToValue(r_);
					bool t_ = s_ is CqlInterval<CqlDateTime>;

					return t_;
				};
				bool n_()
				{
					DataType u_ = NoHbA1c?.Effective;
					object v_ = FHIRHelpers_4_3_000.ToValue(u_);
					bool w_ = v_ is CqlDateTime;

					return w_;
				};
				if (l_())
				{
					DataType x_ = NoHbA1c?.Effective;
					object y_ = FHIRHelpers_4_3_000.ToValue(x_);

					return (y_ as CqlDateTime) as object;
				}
				else if (m_())
				{
					DataType z_ = NoHbA1c?.Effective;
					object aa_ = FHIRHelpers_4_3_000.ToValue(z_);

					return (aa_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (n_())
				{
					DataType ab_ = NoHbA1c?.Effective;
					object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);

					return (ac_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime i_ = QICoreCommon_2_0_000.Latest(h_());
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		bool? f_ = context.Operators.Exists<Observation>(e_);
		bool? g_ = context.Operators.Not(f_);

		return g_;
	}

    [CqlDeclaration("Has No Record Of HbA1c")]
	public bool? Has_No_Record_Of_HbA1c() => 
		__Has_No_Record_Of_HbA1c.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Has_Most_Recent_HbA1c_Without_Result();
		bool? b_ = this.Has_Most_Recent_Elevated_HbA1c();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_No_Record_Of_HbA1c();
		bool? e_ = context.Operators.Or(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
