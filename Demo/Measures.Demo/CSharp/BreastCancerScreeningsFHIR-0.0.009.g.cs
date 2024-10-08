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
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", default);

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005")]
	public CqlValueSet Bilateral_Mastectomy() => 
		__Bilateral_Mastectomy.Value;

	private CqlValueSet History_of_bilateral_mastectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", default);

    [CqlDeclaration("History of bilateral mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068")]
	public CqlValueSet History_of_bilateral_mastectomy() => 
		__History_of_bilateral_mastectomy.Value;

	private CqlValueSet Left_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", default);

    [CqlDeclaration("Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036")]
	public CqlValueSet Left() => 
		__Left.Value;

	private CqlValueSet Mammography_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", default);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047")]
	public CqlValueSet Mammography() => 
		__Mammography.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Right_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", default);

    [CqlDeclaration("Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035")]
	public CqlValueSet Right() => 
		__Right.Value;

	private CqlValueSet Status_Post_Left_Mastectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", default);

    [CqlDeclaration("Status Post Left Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069")]
	public CqlValueSet Status_Post_Left_Mastectomy() => 
		__Status_Post_Left_Mastectomy.Value;

	private CqlValueSet Status_Post_Right_Mastectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", default);

    [CqlDeclaration("Status Post Right Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070")]
	public CqlValueSet Status_Post_Right_Mastectomy() => 
		__Status_Post_Right_Mastectomy.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Unilateral_Mastectomy_Left_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", default);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133")]
	public CqlValueSet Unilateral_Mastectomy_Left() => 
		__Unilateral_Mastectomy_Left.Value;

	private CqlValueSet Unilateral_Mastectomy_Right_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", default);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134")]
	public CqlValueSet Unilateral_Mastectomy_Right() => 
		__Unilateral_Mastectomy_Right.Value;

	private CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", default);

    [CqlDeclaration("Unilateral Mastectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071")]
	public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality() => 
		__Unilateral_Mastectomy__Unspecified_Laterality.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		CqlValueSet a_ = this.Online_Assessments();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet c_ = this.Telephone_Visits();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		bool? f_(Encounter TelehealthEncounter)
		{
			Code<Encounter.EncounterStatus> h_ = TelehealthEncounter?.StatusElement;
			string i_ = FHIRHelpers_4_0_001.ToString(h_);
			bool? j_ = context.Operators.Equal(i_, "finished");
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			Period l_ = TelehealthEncounter?.Period;
			CqlInterval<CqlDateTime> m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_ as object);
			bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, default);
			bool? o_ = context.Operators.And(j_, n_);

			return o_;
		};
		IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Telehealth Services")]
	public IEnumerable<Encounter> Telehealth_Services() => 
		__Telehealth_Services.Value;

	private int? Age_at_start_of_Measurement_Period_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");

		return h_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
	public int? Age_at_start_of_Measurement_Period() => 
		__Age_at_start_of_Measurement_Period.Value;

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
		CqlInterval<int?> i_ = context.Operators.Interval(51, 74, true, false);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		Code<AdministrativeGender> l_ = a_?.GenderElement;
		string m_ = FHIRHelpers_4_0_001.ToString(l_);
		bool? n_ = context.Operators.Equal(m_, "female");
		bool? o_ = context.Operators.And(j_, n_);
		IEnumerable<Encounter> p_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		IEnumerable<Encounter> q_ = this.Telehealth_Services();
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(p_, q_);
		bool? s_ = context.Operators.Exists<Encounter>(r_);
		bool? t_ = context.Operators.And(o_, s_);

		return t_;
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

	private IEnumerable<Condition> Right_Mastectomy_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Status_Post_Right_Mastectomy();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		CqlValueSet c_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? e_(Condition UnilateralMastectomyDiagnosis)
		{
			List<CodeableConcept> j_ = UnilateralMastectomyDiagnosis?.BodySite;
			CqlConcept k_(CodeableConcept X)
			{
				CqlConcept o_ = FHIRHelpers_4_0_001.ToConcept(X);

				return o_;
			};
			IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
			CqlValueSet m_ = this.Right();
			bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

			return n_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
		IEnumerable<Condition> g_ = context.Operators.Union<Condition>(b_, f_);
		bool? h_(Condition RightMastectomy)
		{
			CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(RightMastectomy);
			CqlDateTime q_ = context.Operators.Start(p_);
			CqlInterval<CqlDateTime> r_ = this.Measurement_Period();
			CqlDateTime s_ = context.Operators.End(r_);
			bool? t_ = context.Operators.SameOrBefore(q_, s_, default);

			return t_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
	public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => 
		__Right_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		CqlValueSet a_ = this.Unilateral_Mastectomy_Right();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		bool? c_(Procedure UnilateralMastectomyRightPerformed)
		{
			Code<EventStatus> e_ = UnilateralMastectomyRightPerformed?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			bool? g_ = context.Operators.Equal(f_, "completed");
			DataType h_ = UnilateralMastectomyRightPerformed?.Performed;
			CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			CqlDateTime j_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			CqlDateTime l_ = context.Operators.End(k_);
			bool? m_ = context.Operators.SameOrBefore(j_, l_, default);
			bool? n_ = context.Operators.And(g_, m_);

			return n_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
	public IEnumerable<Procedure> Right_Mastectomy_Procedure() => 
		__Right_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Status_Post_Left_Mastectomy();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		CqlValueSet c_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? e_(Condition UnilateralMastectomyDiagnosis)
		{
			List<CodeableConcept> j_ = UnilateralMastectomyDiagnosis?.BodySite;
			CqlConcept k_(CodeableConcept X)
			{
				CqlConcept o_ = FHIRHelpers_4_0_001.ToConcept(X);

				return o_;
			};
			IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
			CqlValueSet m_ = this.Left();
			bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

			return n_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
		IEnumerable<Condition> g_ = context.Operators.Union<Condition>(b_, f_);
		bool? h_(Condition LeftMastectomy)
		{
			CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(LeftMastectomy);
			CqlDateTime q_ = context.Operators.Start(p_);
			CqlInterval<CqlDateTime> r_ = this.Measurement_Period();
			CqlDateTime s_ = context.Operators.End(r_);
			bool? t_ = context.Operators.SameOrBefore(q_, s_, default);

			return t_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
	public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => 
		__Left_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		CqlValueSet a_ = this.Unilateral_Mastectomy_Left();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		bool? c_(Procedure UnilateralMastectomyLeftPerformed)
		{
			Code<EventStatus> e_ = UnilateralMastectomyLeftPerformed?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			bool? g_ = context.Operators.Equal(f_, "completed");
			DataType h_ = UnilateralMastectomyLeftPerformed?.Performed;
			CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			CqlDateTime j_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			CqlDateTime l_ = context.Operators.End(k_);
			bool? m_ = context.Operators.SameOrBefore(j_, l_, default);
			bool? n_ = context.Operators.And(g_, m_);

			return n_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
	public IEnumerable<Procedure> Left_Mastectomy_Procedure() => 
		__Left_Mastectomy_Procedure.Value;

	private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		CqlValueSet a_ = this.History_of_bilateral_mastectomy();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? c_(Condition BilateralMastectomyHistory)
		{
			CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(BilateralMastectomyHistory);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.SameOrBefore(f_, h_, default);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
	public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => 
		__Bilateral_Mastectomy_Diagnosis.Value;

	private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		CqlValueSet a_ = this.Bilateral_Mastectomy();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		bool? c_(Procedure BilateralMastectomyPerformed)
		{
			Code<EventStatus> e_ = BilateralMastectomyPerformed?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			bool? g_ = context.Operators.Equal(f_, "completed");
			DataType h_ = BilateralMastectomyPerformed?.Performed;
			CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			CqlDateTime j_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			CqlDateTime l_ = context.Operators.End(k_);
			bool? m_ = context.Operators.SameOrBefore(j_, l_, default);
			bool? n_ = context.Operators.And(g_, m_);

			return n_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
	public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => 
		__Bilateral_Mastectomy_Procedure.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		IEnumerable<Condition> b_ = this.Right_Mastectomy_Diagnosis();
		bool? c_ = context.Operators.Exists<Condition>(b_);
		IEnumerable<Procedure> d_ = this.Right_Mastectomy_Procedure();
		bool? e_ = context.Operators.Exists<Procedure>(d_);
		bool? f_ = context.Operators.Or(c_, e_);
		IEnumerable<Condition> g_ = this.Left_Mastectomy_Diagnosis();
		bool? h_ = context.Operators.Exists<Condition>(g_);
		IEnumerable<Procedure> i_ = this.Left_Mastectomy_Procedure();
		bool? j_ = context.Operators.Exists<Procedure>(i_);
		bool? k_ = context.Operators.Or(h_, j_);
		bool? l_ = context.Operators.And(f_, k_);
		bool? m_ = context.Operators.Or(a_, l_);
		IEnumerable<Condition> n_ = this.Bilateral_Mastectomy_Diagnosis();
		bool? o_ = context.Operators.Exists<Condition>(n_);
		bool? p_ = context.Operators.Or(m_, o_);
		IEnumerable<Procedure> q_ = this.Bilateral_Mastectomy_Procedure();
		bool? r_ = context.Operators.Exists<Procedure>(q_);
		bool? s_ = context.Operators.Or(p_, r_);
		bool? t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		bool? u_ = context.Operators.Or(s_, t_);
		Patient v_ = this.Patient();
		Date w_ = v_?.BirthDateElement;
		string x_ = w_?.Value;
		CqlDate y_ = context.Operators.ConvertStringToDate(x_);
		CqlInterval<CqlDateTime> z_ = this.Measurement_Period();
		CqlDateTime aa_ = context.Operators.Start(z_);
		CqlDate ab_ = context.Operators.DateFrom(aa_);
		int? ac_ = context.Operators.CalculateAgeAt(y_, ab_, "year");
		bool? ad_ = context.Operators.GreaterOrEqual(ac_, 65);
		bool? ae_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		bool? af_ = context.Operators.And(ad_, ae_);
		bool? ag_ = context.Operators.Or(u_, af_);
		bool? ah_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		bool? ai_ = context.Operators.Or(ag_, ah_);

		return ai_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private bool? Observation_with_status_Value()
	{
		CqlValueSet a_ = this.Mammography();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation Mammogram)
		{
			Code<ObservationStatus> f_ = Mammogram?.StatusElement;
			string g_ = FHIRHelpers_4_0_001.ToString(f_);
			string[] h_ = [
				"final",
				"amended",
				"corrected",
				"appended",
			];
			bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);
			DataType j_ = Mammogram?.Effective;
			CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			CqlDateTime l_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			CqlDateTime n_ = context.Operators.End(m_);
			CqlQuantity o_ = context.Operators.Quantity(27m, "months");
			CqlDateTime p_ = context.Operators.Subtract(n_, o_);
			CqlDateTime r_ = context.Operators.End(m_);
			CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
			bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
			CqlDateTime v_ = context.Operators.End(m_);
			bool? w_ = context.Operators.Not((bool?)(v_ is null));
			bool? x_ = context.Operators.And(t_, w_);
			bool? y_ = context.Operators.And(i_, x_);

			return y_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Observation with status")]
	public bool? Observation_with_status() => 
		__Observation_with_status.Value;

	private bool? Diagnostic_Report_with_status_Value()
	{
		CqlValueSet a_ = this.Mammography();
		IEnumerable<DiagnosticReport> b_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
		bool? c_(DiagnosticReport Mammogram)
		{
			Code<DiagnosticReport.DiagnosticReportStatus> f_ = Mammogram?.StatusElement;
			string g_ = FHIRHelpers_4_0_001.ToString(f_);
			string[] h_ = [
				"final",
				"amended",
				"corrected",
				"appended",
			];
			bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);
			DataType j_ = Mammogram?.Effective;
			CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			CqlDateTime l_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			CqlDateTime n_ = context.Operators.End(m_);
			CqlQuantity o_ = context.Operators.Quantity(27m, "months");
			CqlDateTime p_ = context.Operators.Subtract(n_, o_);
			CqlDateTime r_ = context.Operators.End(m_);
			CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
			bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
			CqlDateTime v_ = context.Operators.End(m_);
			bool? w_ = context.Operators.Not((bool?)(v_ is null));
			bool? x_ = context.Operators.And(t_, w_);
			bool? y_ = context.Operators.And(i_, x_);

			return y_;
		};
		IEnumerable<DiagnosticReport> d_ = context.Operators.Where<DiagnosticReport>(b_, c_);
		bool? e_ = context.Operators.Exists<DiagnosticReport>(d_);

		return e_;
	}

    [CqlDeclaration("Diagnostic Report with status")]
	public bool? Diagnostic_Report_with_status() => 
		__Diagnostic_Report_with_status.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Observation_with_status();
		bool? b_ = this.Diagnostic_Report_with_status();
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Final_Numerator_Population_Value()
	{
		bool? a_ = this.Numerator();
		bool? b_ = this.Initial_Population();
		bool? c_ = context.Operators.And(a_, b_);
		bool? d_ = this.Denominator();
		bool? e_ = context.Operators.And(c_, d_);
		bool? f_ = this.Denominator_Exclusions();
		bool? g_ = context.Operators.Not(f_);
		bool? h_ = context.Operators.And(e_, g_);

		return h_;
	}

    [CqlDeclaration("Final Numerator Population")]
	public bool? Final_Numerator_Population() => 
		__Final_Numerator_Population.Value;

	private bool? Observation_without_appropriate_status_Value()
	{
		CqlValueSet a_ = this.Mammography();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation Mammogram)
		{
			Code<ObservationStatus> f_ = Mammogram?.StatusElement;
			string g_ = FHIRHelpers_4_0_001.ToString(f_);
			string[] h_ = [
				"final",
				"amended",
				"corrected",
				"appended",
			];
			bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);
			bool? j_ = context.Operators.Not(i_);
			DataType k_ = Mammogram?.Effective;
			CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(k_);
			CqlDateTime m_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			CqlDateTime o_ = context.Operators.End(n_);
			CqlQuantity p_ = context.Operators.Quantity(27m, "months");
			CqlDateTime q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
			bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, default);
			CqlDateTime w_ = context.Operators.End(n_);
			bool? x_ = context.Operators.Not((bool?)(w_ is null));
			bool? y_ = context.Operators.And(u_, x_);
			bool? z_ = context.Operators.And(j_, y_);

			return z_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Observation without appropriate status")]
	public bool? Observation_without_appropriate_status() => 
		__Observation_without_appropriate_status.Value;

	private bool? Diagnostic_Report_without_appropriate_status_Value()
	{
		CqlValueSet a_ = this.Mammography();
		IEnumerable<DiagnosticReport> b_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
		bool? c_(DiagnosticReport Mammogram)
		{
			Code<DiagnosticReport.DiagnosticReportStatus> f_ = Mammogram?.StatusElement;
			string g_ = FHIRHelpers_4_0_001.ToString(f_);
			string[] h_ = [
				"final",
				"amended",
				"corrected",
				"appended",
			];
			bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);
			bool? j_ = context.Operators.Not(i_);
			DataType k_ = Mammogram?.Effective;
			CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(k_);
			CqlDateTime m_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			CqlDateTime o_ = context.Operators.End(n_);
			CqlQuantity p_ = context.Operators.Quantity(27m, "months");
			CqlDateTime q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
			bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, default);
			CqlDateTime w_ = context.Operators.End(n_);
			bool? x_ = context.Operators.Not((bool?)(w_ is null));
			bool? y_ = context.Operators.And(u_, x_);
			bool? z_ = context.Operators.And(j_, y_);

			return z_;
		};
		IEnumerable<DiagnosticReport> d_ = context.Operators.Where<DiagnosticReport>(b_, c_);
		bool? e_ = context.Operators.Exists<DiagnosticReport>(d_);

		return e_;
	}

    [CqlDeclaration("Diagnostic Report without appropriate status")]
	public bool? Diagnostic_Report_without_appropriate_status() => 
		__Diagnostic_Report_without_appropriate_status.Value;

}
