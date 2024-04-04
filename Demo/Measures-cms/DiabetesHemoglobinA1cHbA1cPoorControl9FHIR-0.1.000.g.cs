using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
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
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.1.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
		var g_ = context.Operators.Interval((int?)18, (int?)75, true, true);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = AdultOutpatientEncounters_4_8_000.Qualifying_Encounters();
		var j_ = context.Operators.ExistsInList<Encounter>(i_);
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
		var o_ = context.Operators.WhereOrNull<Condition>(m_, n_);
		var p_ = context.Operators.ExistsInList<Condition>(o_);
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
				if (FHIRHelpers_4_3_000.ToValue(RecentHbA1c?.Effective) is CqlDateTime)
				{
					var m_ = FHIRHelpers_4_3_000.ToValue(RecentHbA1c?.Effective);

					return ((m_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(RecentHbA1c?.Effective) is CqlInterval<CqlDateTime>)
				{
					var n_ = FHIRHelpers_4_3_000.ToValue(RecentHbA1c?.Effective);

					return ((n_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(RecentHbA1c?.Effective) is CqlDateTime)
				{
					var o_ = FHIRHelpers_4_3_000.ToValue(RecentHbA1c?.Effective);

					return ((o_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var j_ = QICoreCommon_2_0_000.Latest(i_());
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.ElementInInterval<CqlDateTime>(j_, k_, "day");

			return l_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		object f_(Observation @this)
		{
			var p_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var q_ = QICoreCommon_2_0_000.ToInterval(p_);
			var r_ = context.Operators.Start(q_);

			return r_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);

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
				if (FHIRHelpers_4_3_000.ToValue(NoHbA1c?.Effective) is CqlDateTime)
				{
					var l_ = FHIRHelpers_4_3_000.ToValue(NoHbA1c?.Effective);

					return ((l_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(NoHbA1c?.Effective) is CqlInterval<CqlDateTime>)
				{
					var m_ = FHIRHelpers_4_3_000.ToValue(NoHbA1c?.Effective);

					return ((m_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(NoHbA1c?.Effective) is CqlDateTime)
				{
					var n_ = FHIRHelpers_4_3_000.ToValue(NoHbA1c?.Effective);

					return ((n_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var i_ = QICoreCommon_2_0_000.Latest(h_());
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.ElementInInterval<CqlDateTime>(i_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		var f_ = context.Operators.ExistsInList<Observation>(e_);
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
