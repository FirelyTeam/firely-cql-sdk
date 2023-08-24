using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("BreastCancerScreeningsFHIR", "0.0.009")]
public class BreastCancerScreeningsFHIR_0_0_009
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bilateral_Mastectomy;
    internal Lazy<CqlValueSet> __History_of_bilateral_mastectomy;
    internal Lazy<CqlValueSet> __Left;
    internal Lazy<CqlValueSet> __Mammography;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Right;
    internal Lazy<CqlValueSet> __Status_Post_Left_Mastectomy;
    internal Lazy<CqlValueSet> __Status_Post_Right_Mastectomy;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy_Left;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy_Right;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy__Unspecified_Laterality;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Telehealth_Services;
    internal Lazy<int?> __Age_at_start_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Right_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Right_Mastectomy_Procedure;
    internal Lazy<IEnumerable<Condition>> __Left_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Left_Mastectomy_Procedure;
    internal Lazy<IEnumerable<Condition>> __Bilateral_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Bilateral_Mastectomy_Procedure;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<bool?> __Observation_with_status;
    internal Lazy<bool?> __Diagnostic_Report_with_status;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Final_Numerator_Population;
    internal Lazy<bool?> __Observation_without_appropriate_status;
    internal Lazy<bool?> __Diagnostic_Report_without_appropriate_status;

    #endregion
    public BreastCancerScreeningsFHIR_0_0_009(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        AdultOutpatientEncountersFHIR4_2_2_000 = new AdultOutpatientEncountersFHIR4_2_2_000(context);
        AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 = new AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000(context);
        PalliativeCareFHIR_0_6_000 = new PalliativeCareFHIR_0_6_000(context);
        CumulativeMedicationDurationFHIR4_1_0_000 = new CumulativeMedicationDurationFHIR4_1_0_000(context);
        HospiceFHIR4_2_3_000 = new HospiceFHIR4_2_3_000(context);

        __Bilateral_Mastectomy = new Lazy<CqlValueSet>(this.Bilateral_Mastectomy_Value);
        __History_of_bilateral_mastectomy = new Lazy<CqlValueSet>(this.History_of_bilateral_mastectomy_Value);
        __Left = new Lazy<CqlValueSet>(this.Left_Value);
        __Mammography = new Lazy<CqlValueSet>(this.Mammography_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Right = new Lazy<CqlValueSet>(this.Right_Value);
        __Status_Post_Left_Mastectomy = new Lazy<CqlValueSet>(this.Status_Post_Left_Mastectomy_Value);
        __Status_Post_Right_Mastectomy = new Lazy<CqlValueSet>(this.Status_Post_Right_Mastectomy_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Unilateral_Mastectomy_Left = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Left_Value);
        __Unilateral_Mastectomy_Right = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Right_Value);
        __Unilateral_Mastectomy__Unspecified_Laterality = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy__Unspecified_Laterality_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Telehealth_Services = new Lazy<IEnumerable<Encounter>>(this.Telehealth_Services_Value);
        __Age_at_start_of_Measurement_Period = new Lazy<int?>(this.Age_at_start_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Right_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Right_Mastectomy_Diagnosis_Value);
        __Right_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Right_Mastectomy_Procedure_Value);
        __Left_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Left_Mastectomy_Diagnosis_Value);
        __Left_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Left_Mastectomy_Procedure_Value);
        __Bilateral_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Bilateral_Mastectomy_Diagnosis_Value);
        __Bilateral_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Bilateral_Mastectomy_Procedure_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Observation_with_status = new Lazy<bool?>(this.Observation_with_status_Value);
        __Diagnostic_Report_with_status = new Lazy<bool?>(this.Diagnostic_Report_with_status_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Final_Numerator_Population = new Lazy<bool?>(this.Final_Numerator_Population_Value);
        __Observation_without_appropriate_status = new Lazy<bool?>(this.Observation_without_appropriate_status_Value);
        __Diagnostic_Report_without_appropriate_status = new Lazy<bool?>(this.Diagnostic_Report_without_appropriate_status_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public AdultOutpatientEncountersFHIR4_2_2_000 AdultOutpatientEncountersFHIR4_2_2_000 { get; }
    public AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 { get; }
    public PalliativeCareFHIR_0_6_000 PalliativeCareFHIR_0_6_000 { get; }
    public CumulativeMedicationDurationFHIR4_1_0_000 CumulativeMedicationDurationFHIR4_1_0_000 { get; }
    public HospiceFHIR4_2_3_000 HospiceFHIR4_2_3_000 { get; }

    #endregion

    private CqlValueSet Bilateral_Mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005")]
    public CqlValueSet Bilateral_Mastectomy() => __Bilateral_Mastectomy.Value;

    private CqlValueSet History_of_bilateral_mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlDeclaration("History of bilateral mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068")]
    public CqlValueSet History_of_bilateral_mastectomy() => __History_of_bilateral_mastectomy.Value;

    private CqlValueSet Left_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", null);

    [CqlDeclaration("Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036")]
    public CqlValueSet Left() => __Left.Value;

    private CqlValueSet Mammography_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", null);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047")]
    public CqlValueSet Mammography() => __Mammography.Value;

    private CqlValueSet Online_Assessments_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Right_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", null);

    [CqlDeclaration("Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035")]
    public CqlValueSet Right() => __Right.Value;

    private CqlValueSet Status_Post_Left_Mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlDeclaration("Status Post Left Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069")]
    public CqlValueSet Status_Post_Left_Mastectomy() => __Status_Post_Left_Mastectomy.Value;

    private CqlValueSet Status_Post_Right_Mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlDeclaration("Status Post Right Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070")]
    public CqlValueSet Status_Post_Right_Mastectomy() => __Status_Post_Right_Mastectomy.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlValueSet Unilateral_Mastectomy_Left_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133")]
    public CqlValueSet Unilateral_Mastectomy_Left() => __Unilateral_Mastectomy_Left.Value;

    private CqlValueSet Unilateral_Mastectomy_Right_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134")]
    public CqlValueSet Unilateral_Mastectomy_Right() => __Unilateral_Mastectomy_Right.Value;

    private CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);

    [CqlDeclaration("Unilateral Mastectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071")]
    public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality() => __Unilateral_Mastectomy__Unspecified_Laterality.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", f_);

		return (CqlInterval<CqlDateTime>)g_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var k_ = this.Online_Assessments();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, null);
		var m_ = this.Telephone_Visits();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = context?.Operators.ListUnion<Encounter>(l_, n_);
		var p_ = (Encounter TelehealthEncounter) =>
		{
			var a_ = TelehealthEncounter?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("finished" as object));
			var f_ = this.Measurement_Period();
			var g_ = TelehealthEncounter?.Period;
			var h_ = (g_ as object);
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			var j_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, null);

			return context?.Operators.And(e_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(o_, p_);
	}

    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services() => __Telehealth_Services.Value;

    private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = (c_ as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);

		return context?.Operators.CalculateAgeAt(e_, h_, "year");
	}

    [CqlDeclaration("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period() => __Age_at_start_of_Measurement_Period.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = (c_ as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);
		var i_ = context?.Operators.CalculateAgeAt(e_, h_, "year");
		var j_ = context?.Operators.Interval((int?)51, (int?)74, true, false);
		var k_ = context?.Operators.ElementInInterval<int?>(i_, j_, null);
		var l_ = this.Patient();
		var m_ = l_?.GenderElement;
		var n_ = (m_ as object);
		var o_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(n_);
		var p_ = (o_ as object);
		var q_ = context?.Operators.Equal(p_, ("female" as object));
		var r_ = context?.Operators.And(k_, q_);
		var s_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var t_ = this.Telehealth_Services();
		var u_ = context?.Operators.ListUnion<Encounter>(s_, t_);
		var v_ = context?.Operators.ExistsInList<Encounter>(u_);

		return context?.Operators.And(r_, v_);
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<Condition> Right_Mastectomy_Diagnosis_Value()
	{
		var j_ = this.Status_Post_Right_Mastectomy();
		var k_ = context?.DataRetriever.RetrieveByValueSet<Condition>(j_, null);
		var l_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var m_ = context?.DataRetriever.RetrieveByValueSet<Condition>(l_, null);
		var n_ = (Condition UnilateralMastectomyDiagnosis) =>
		{
			var a_ = UnilateralMastectomyDiagnosis?.BodySite;
			var b_ = (a_ as IEnumerable<CodeableConcept>);
			var c_ = (CodeableConcept X) => FHIRHelpers_4_0_001.ToConcept(X);
			var d_ = context?.Operators.SelectOrNull<CodeableConcept, CqlConcept>(b_, c_);
			var e_ = this.Right();

			return context?.Operators.ConceptsInValueSet(d_, e_);
		};
		var o_ = context?.Operators.WhereOrNull<Condition>(m_, n_);
		var p_ = context?.Operators.ListUnion<Condition>(k_, o_);
		var q_ = (Condition RightMastectomy) =>
		{
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(RightMastectomy);
			var g_ = context?.Operators.Start(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);

			return context?.Operators.SameOrBefore(g_, i_, null);
		};

		return context?.Operators.WhereOrNull<Condition>(p_, q_);
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => __Right_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		var m_ = this.Unilateral_Mastectomy_Right();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(m_, null);
		var o_ = (Procedure UnilateralMastectomyRightPerformed) =>
		{
			var a_ = UnilateralMastectomyRightPerformed?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = UnilateralMastectomyRightPerformed?.Performed;
			var g_ = (f_ as object);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.SameOrBefore(i_, k_, null);

			return context?.Operators.And(e_, l_);
		};

		return context?.Operators.WhereOrNull<Procedure>(n_, o_);
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure() => __Right_Mastectomy_Procedure.Value;

    private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		var j_ = this.Status_Post_Left_Mastectomy();
		var k_ = context?.DataRetriever.RetrieveByValueSet<Condition>(j_, null);
		var l_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var m_ = context?.DataRetriever.RetrieveByValueSet<Condition>(l_, null);
		var n_ = (Condition UnilateralMastectomyDiagnosis) =>
		{
			var a_ = UnilateralMastectomyDiagnosis?.BodySite;
			var b_ = (a_ as IEnumerable<CodeableConcept>);
			var c_ = (CodeableConcept X) => FHIRHelpers_4_0_001.ToConcept(X);
			var d_ = context?.Operators.SelectOrNull<CodeableConcept, CqlConcept>(b_, c_);
			var e_ = this.Left();

			return context?.Operators.ConceptsInValueSet(d_, e_);
		};
		var o_ = context?.Operators.WhereOrNull<Condition>(m_, n_);
		var p_ = context?.Operators.ListUnion<Condition>(k_, o_);
		var q_ = (Condition LeftMastectomy) =>
		{
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(LeftMastectomy);
			var g_ = context?.Operators.Start(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);

			return context?.Operators.SameOrBefore(g_, i_, null);
		};

		return context?.Operators.WhereOrNull<Condition>(p_, q_);
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => __Left_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		var m_ = this.Unilateral_Mastectomy_Left();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(m_, null);
		var o_ = (Procedure UnilateralMastectomyLeftPerformed) =>
		{
			var a_ = UnilateralMastectomyLeftPerformed?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = UnilateralMastectomyLeftPerformed?.Performed;
			var g_ = (f_ as object);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.SameOrBefore(i_, k_, null);

			return context?.Operators.And(e_, l_);
		};

		return context?.Operators.WhereOrNull<Procedure>(n_, o_);
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure() => __Left_Mastectomy_Procedure.Value;

    private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		var e_ = this.History_of_bilateral_mastectomy();
		var f_ = context?.DataRetriever.RetrieveByValueSet<Condition>(e_, null);
		var g_ = (Condition BilateralMastectomyHistory) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(BilateralMastectomyHistory);
			var b_ = context?.Operators.Start(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.End(c_);

			return context?.Operators.SameOrBefore(b_, d_, null);
		};

		return context?.Operators.WhereOrNull<Condition>(f_, g_);
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => __Bilateral_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		var m_ = this.Bilateral_Mastectomy();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(m_, null);
		var o_ = (Procedure BilateralMastectomyPerformed) =>
		{
			var a_ = BilateralMastectomyPerformed?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = BilateralMastectomyPerformed?.Performed;
			var g_ = (f_ as object);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.SameOrBefore(i_, k_, null);

			return context?.Operators.And(e_, l_);
		};

		return context?.Operators.WhereOrNull<Procedure>(n_, o_);
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => __Bilateral_Mastectomy_Procedure.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Right_Mastectomy_Diagnosis();
		var c_ = context?.Operators.ExistsInList<Condition>(b_);
		var d_ = this.Right_Mastectomy_Procedure();
		var e_ = context?.Operators.ExistsInList<Procedure>(d_);
		var f_ = context?.Operators.Or(c_, e_);
		var g_ = this.Left_Mastectomy_Diagnosis();
		var h_ = context?.Operators.ExistsInList<Condition>(g_);
		var i_ = this.Left_Mastectomy_Procedure();
		var j_ = context?.Operators.ExistsInList<Procedure>(i_);
		var k_ = context?.Operators.Or(h_, j_);
		var l_ = context?.Operators.And(f_, k_);
		var m_ = context?.Operators.Or(a_, l_);
		var n_ = this.Bilateral_Mastectomy_Diagnosis();
		var o_ = context?.Operators.ExistsInList<Condition>(n_);
		var p_ = context?.Operators.Or(m_, o_);
		var q_ = this.Bilateral_Mastectomy_Procedure();
		var r_ = context?.Operators.ExistsInList<Procedure>(q_);
		var s_ = context?.Operators.Or(p_, r_);
		var t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var u_ = context?.Operators.Or(s_, t_);
		var v_ = this.Patient();
		var w_ = v_?.BirthDateElement;
		var x_ = w_?.Value;
		var y_ = (x_ as object);
		var z_ = context?.Operators?.TypeConverter.Convert<CqlDate>(y_);
		var aa_ = this.Measurement_Period();
		var ab_ = context?.Operators.Start(aa_);
		var ac_ = context?.Operators.DateFrom(ab_);
		var ad_ = context?.Operators.CalculateAgeAt(z_, ac_, "year");
		var ae_ = ad_;
		var af_ = (int?)65;
		var ag_ = af_;
		var ah_ = context?.Operators.GreaterOrEqual(ae_, ag_);
		var ai_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var aj_ = context?.Operators.And(ah_, ai_);
		var ak_ = context?.Operators.Or(u_, aj_);
		var al_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();

		return context?.Operators.Or(ak_, al_);
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private bool? Observation_with_status_Value()
	{
		var ac_ = this.Mammography();
		var ad_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ac_, null);
		var ae_ = (Observation Mammogram) =>
		{
			var a_ = Mammogram?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = "appended";
			var h_ = new string[]
			{
				d_,
				e_,
				f_,
				g_,
			};
			var i_ = (h_ as IEnumerable<string>);
			var j_ = context?.Operators.InList<string>(c_, i_);
			var k_ = Mammogram?.Effective;
			var l_ = (k_ as object);
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
			var n_ = context?.Operators.End(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = context?.Operators.Quantity(27m, "months");
			var r_ = context?.Operators.Subtract(p_, q_);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.End(s_);
			var u_ = context?.Operators.Interval(r_, t_, true, true);
			var v_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, u_, null);
			var w_ = this.Measurement_Period();
			var x_ = context?.Operators.End(w_);
			var y_ = (x_ == null);
			var z_ = (bool?)y_;
			var aa_ = context?.Operators.Not(z_);
			var ab_ = context?.Operators.And(v_, aa_);

			return context?.Operators.And(j_, ab_);
		};
		var af_ = context?.Operators.WhereOrNull<Observation>(ad_, ae_);

		return context?.Operators.ExistsInList<Observation>(af_);
	}

    [CqlDeclaration("Observation with status")]
    public bool? Observation_with_status() => __Observation_with_status.Value;

    private bool? Diagnostic_Report_with_status_Value()
	{
		var ac_ = this.Mammography();
		var ad_ = context?.DataRetriever.RetrieveByValueSet<DiagnosticReport>(ac_, null);
		var ae_ = (DiagnosticReport Mammogram) =>
		{
			var a_ = Mammogram?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = "appended";
			var h_ = new string[]
			{
				d_,
				e_,
				f_,
				g_,
			};
			var i_ = (h_ as IEnumerable<string>);
			var j_ = context?.Operators.InList<string>(c_, i_);
			var k_ = Mammogram?.Effective;
			var l_ = (k_ as object);
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
			var n_ = context?.Operators.End(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = context?.Operators.Quantity(27m, "months");
			var r_ = context?.Operators.Subtract(p_, q_);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.End(s_);
			var u_ = context?.Operators.Interval(r_, t_, true, true);
			var v_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, u_, null);
			var w_ = this.Measurement_Period();
			var x_ = context?.Operators.End(w_);
			var y_ = (x_ == null);
			var z_ = (bool?)y_;
			var aa_ = context?.Operators.Not(z_);
			var ab_ = context?.Operators.And(v_, aa_);

			return context?.Operators.And(j_, ab_);
		};
		var af_ = context?.Operators.WhereOrNull<DiagnosticReport>(ad_, ae_);

		return context?.Operators.ExistsInList<DiagnosticReport>(af_);
	}

    [CqlDeclaration("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status() => __Diagnostic_Report_with_status.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Observation_with_status();
		var b_ = this.Diagnostic_Report_with_status();

		return context?.Operators.Or(a_, b_);
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    private bool? Final_Numerator_Population_Value()
	{
		var a_ = this.Numerator();
		var b_ = this.Initial_Population();
		var c_ = context?.Operators.And(a_, b_);
		var d_ = this.Denominator();
		var e_ = context?.Operators.And(c_, d_);
		var f_ = this.Denominator_Exclusions();
		var g_ = context?.Operators.Not(f_);

		return context?.Operators.And(e_, g_);
	}

    [CqlDeclaration("Final Numerator Population")]
    public bool? Final_Numerator_Population() => __Final_Numerator_Population.Value;

    private bool? Observation_without_appropriate_status_Value()
	{
		var ad_ = this.Mammography();
		var ae_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ad_, null);
		var af_ = (Observation Mammogram) =>
		{
			var a_ = Mammogram?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = "appended";
			var h_ = new string[]
			{
				d_,
				e_,
				f_,
				g_,
			};
			var i_ = (h_ as IEnumerable<string>);
			var j_ = context?.Operators.InList<string>(c_, i_);
			var k_ = context?.Operators.Not(j_);
			var l_ = Mammogram?.Effective;
			var m_ = (l_ as object);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			var o_ = context?.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context?.Operators.End(p_);
			var r_ = context?.Operators.Quantity(27m, "months");
			var s_ = context?.Operators.Subtract(q_, r_);
			var t_ = this.Measurement_Period();
			var u_ = context?.Operators.End(t_);
			var v_ = context?.Operators.Interval(s_, u_, true, true);
			var w_ = context?.Operators.ElementInInterval<CqlDateTime>(o_, v_, null);
			var x_ = this.Measurement_Period();
			var y_ = context?.Operators.End(x_);
			var z_ = (y_ == null);
			var aa_ = (bool?)z_;
			var ab_ = context?.Operators.Not(aa_);
			var ac_ = context?.Operators.And(w_, ab_);

			return context?.Operators.And(k_, ac_);
		};
		var ag_ = context?.Operators.WhereOrNull<Observation>(ae_, af_);

		return context?.Operators.ExistsInList<Observation>(ag_);
	}

    [CqlDeclaration("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status() => __Observation_without_appropriate_status.Value;

    private bool? Diagnostic_Report_without_appropriate_status_Value()
	{
		var ad_ = this.Mammography();
		var ae_ = context?.DataRetriever.RetrieveByValueSet<DiagnosticReport>(ad_, null);
		var af_ = (DiagnosticReport Mammogram) =>
		{
			var a_ = Mammogram?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = "appended";
			var h_ = new string[]
			{
				d_,
				e_,
				f_,
				g_,
			};
			var i_ = (h_ as IEnumerable<string>);
			var j_ = context?.Operators.InList<string>(c_, i_);
			var k_ = context?.Operators.Not(j_);
			var l_ = Mammogram?.Effective;
			var m_ = (l_ as object);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			var o_ = context?.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context?.Operators.End(p_);
			var r_ = context?.Operators.Quantity(27m, "months");
			var s_ = context?.Operators.Subtract(q_, r_);
			var t_ = this.Measurement_Period();
			var u_ = context?.Operators.End(t_);
			var v_ = context?.Operators.Interval(s_, u_, true, true);
			var w_ = context?.Operators.ElementInInterval<CqlDateTime>(o_, v_, null);
			var x_ = this.Measurement_Period();
			var y_ = context?.Operators.End(x_);
			var z_ = (y_ == null);
			var aa_ = (bool?)z_;
			var ab_ = context?.Operators.Not(aa_);
			var ac_ = context?.Operators.And(w_, ab_);

			return context?.Operators.And(k_, ac_);
		};
		var ag_ = context?.Operators.WhereOrNull<DiagnosticReport>(ae_, af_);

		return context?.Operators.ExistsInList<DiagnosticReport>(ag_);
	}

    [CqlDeclaration("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status() => __Diagnostic_Report_without_appropriate_status.Value;

}