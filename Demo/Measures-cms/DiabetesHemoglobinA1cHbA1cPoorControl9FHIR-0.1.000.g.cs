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
[CqlLibrary("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR", "0.1.000")]
public class DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Diabetes;
    internal Lazy<CqlValueSet> __HbA1c_Laboratory_Test;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes() => 
		__Diabetes.Value;

	private CqlValueSet HbA1c_Laboratory_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);

    [CqlDeclaration("HbA1c Laboratory Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013")]
	public CqlValueSet HbA1c_Laboratory_Test() => 
		__HbA1c_Laboratory_Test.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.1.000", "Measurement Period", c_);

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

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(18, 75, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);
		var i_ = AdultOutpatientEncounters_4_8_000.Qualifying_Encounters();
		var j_ = context.Operators.Exists<Encounter>(i_);
		var k_ = context.Operators.And(h_, j_);
		var l_ = this.Diabetes();
		var m_ = context.Operators.RetrieveByValueSet<Condition>(l_, null);
		bool? n_(Condition Diabetes)
		{
			var r_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Diabetes);
			var s_ = this.Measurement_Period();
			var t_ = context.Operators.Overlaps(r_, s_, null);

			return t_;
		};
		var o_ = context.Operators.Where<Condition>(m_, n_);
		var p_ = context.Operators.Exists<Condition>(o_);
		var q_ = context.Operators.And(k_, p_);

		return q_;
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

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = AdvancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = AdvancedIllnessandFrailty_1_8_000.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home();
		var e_ = context.Operators.Or(c_, d_);
		var f_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		var g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private Observation Most_Recent_HbA1c_Value()
	{
		var a_ = this.HbA1c_Laboratory_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.isLaboratoryTestPerformed(b_);
		bool? d_(Observation RecentHbA1c)
		{
			object i_()
			{
				bool m_()
				{
					var p_ = RecentHbA1c?.Effective;
					var q_ = FHIRHelpers_4_3_000.ToValue(p_);
					var r_ = q_ is CqlDateTime;

					return r_;
				};
				bool n_()
				{
					var s_ = RecentHbA1c?.Effective;
					var t_ = FHIRHelpers_4_3_000.ToValue(s_);
					var u_ = t_ is CqlInterval<CqlDateTime>;

					return u_;
				};
				bool o_()
				{
					var v_ = RecentHbA1c?.Effective;
					var w_ = FHIRHelpers_4_3_000.ToValue(v_);
					var x_ = w_ is CqlDateTime;

					return x_;
				};
				if (m_())
				{
					var y_ = RecentHbA1c?.Effective;
					var z_ = FHIRHelpers_4_3_000.ToValue(y_);

					return ((z_ as CqlDateTime) as object);
				}
				else if (n_())
				{
					var aa_ = RecentHbA1c?.Effective;
					var ab_ = FHIRHelpers_4_3_000.ToValue(aa_);

					return ((ab_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (o_())
				{
					var ac_ = RecentHbA1c?.Effective;
					var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);

					return ((ad_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var j_ = QICoreCommon_2_0_000.Latest(i_());
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");

			return l_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			var ae_ = @this?.Effective;
			var af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = context.Operators.Start(ag_);

			return ah_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);

		return h_;
	}

    [CqlDeclaration("Most Recent HbA1c")]
	public Observation Most_Recent_HbA1c() => 
		__Most_Recent_HbA1c.Value;

	private bool? Has_Most_Recent_HbA1c_Without_Result_Value()
	{
		var a_ = this.Most_Recent_HbA1c();
		var b_ = context.Operators.Not((bool?)(a_ is null));
		var d_ = FHIRHelpers_4_3_000.ToValue(a_?.Value);
		var e_ = context.Operators.And(b_, (bool?)(d_ is null));

		return e_;
	}

    [CqlDeclaration("Has Most Recent HbA1c Without Result")]
	public bool? Has_Most_Recent_HbA1c_Without_Result() => 
		__Has_Most_Recent_HbA1c_Without_Result.Value;

	private bool? Has_Most_Recent_Elevated_HbA1c_Value()
	{
		var a_ = this.Most_Recent_HbA1c();
		var b_ = FHIRHelpers_4_3_000.ToValue(a_?.Value);
		var c_ = context.Operators.Quantity(9m, "%");
		var d_ = context.Operators.Greater((b_ as CqlQuantity), c_);

		return d_;
	}

    [CqlDeclaration("Has Most Recent Elevated HbA1c")]
	public bool? Has_Most_Recent_Elevated_HbA1c() => 
		__Has_Most_Recent_Elevated_HbA1c.Value;

	private bool? Has_No_Record_Of_HbA1c_Value()
	{
		var a_ = this.HbA1c_Laboratory_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.isLaboratoryTestPerformed(b_);
		bool? d_(Observation NoHbA1c)
		{
			object h_()
			{
				bool l_()
				{
					var o_ = NoHbA1c?.Effective;
					var p_ = FHIRHelpers_4_3_000.ToValue(o_);
					var q_ = p_ is CqlDateTime;

					return q_;
				};
				bool m_()
				{
					var r_ = NoHbA1c?.Effective;
					var s_ = FHIRHelpers_4_3_000.ToValue(r_);
					var t_ = s_ is CqlInterval<CqlDateTime>;

					return t_;
				};
				bool n_()
				{
					var u_ = NoHbA1c?.Effective;
					var v_ = FHIRHelpers_4_3_000.ToValue(u_);
					var w_ = v_ is CqlDateTime;

					return w_;
				};
				if (l_())
				{
					var x_ = NoHbA1c?.Effective;
					var y_ = FHIRHelpers_4_3_000.ToValue(x_);

					return ((y_ as CqlDateTime) as object);
				}
				else if (m_())
				{
					var z_ = NoHbA1c?.Effective;
					var aa_ = FHIRHelpers_4_3_000.ToValue(z_);

					return ((aa_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (n_())
				{
					var ab_ = NoHbA1c?.Effective;
					var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);

					return ((ac_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var i_ = QICoreCommon_2_0_000.Latest(h_());
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		var f_ = context.Operators.Exists<Observation>(e_);
		var g_ = context.Operators.Not(f_);

		return g_;
	}

    [CqlDeclaration("Has No Record Of HbA1c")]
	public bool? Has_No_Record_Of_HbA1c() => 
		__Has_No_Record_Of_HbA1c.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Has_Most_Recent_HbA1c_Without_Result();
		var b_ = this.Has_Most_Recent_Elevated_HbA1c();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Has_No_Record_Of_HbA1c();
		var e_ = context.Operators.Or(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
