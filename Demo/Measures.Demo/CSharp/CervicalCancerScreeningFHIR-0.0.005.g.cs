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
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.005")]
public class CervicalCancerScreeningFHIR_0_0_005
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Congenital_or_Acquired_Absence_of_Cervix;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __HPV_Test;
    internal Lazy<CqlValueSet> __Hysterectomy_with_No_Residual_Cervix;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Pap_Test;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> __laboratory;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<object>> __Absence_of_Cervix;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Observation>> __Cervical_Cytology_Within_3_Years;
    internal Lazy<IEnumerable<Observation>> __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older;
    internal Lazy<bool?> __Numerator;
    internal Lazy<IEnumerable<Observation>> __Cervical_Cytology_Within_3_Years__2_;
    internal Lazy<IEnumerable<Observation>> __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_;

    #endregion
    public CervicalCancerScreeningFHIR_0_0_005(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        HospiceFHIR4_2_3_000 = new HospiceFHIR4_2_3_000(context);
        PalliativeCareFHIR_0_6_000 = new PalliativeCareFHIR_0_6_000(context);

        __Congenital_or_Acquired_Absence_of_Cervix = new Lazy<CqlValueSet>(this.Congenital_or_Acquired_Absence_of_Cervix_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __HPV_Test = new Lazy<CqlValueSet>(this.HPV_Test_Value);
        __Hysterectomy_with_No_Residual_Cervix = new Lazy<CqlValueSet>(this.Hysterectomy_with_No_Residual_Cervix_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Pap_Test = new Lazy<CqlValueSet>(this.Pap_Test_Value);
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __laboratory = new Lazy<CqlCode>(this.laboratory_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Absence_of_Cervix = new Lazy<IEnumerable<object>>(this.Absence_of_Cervix_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Cervical_Cytology_Within_3_Years = new Lazy<IEnumerable<Observation>>(this.Cervical_Cytology_Within_3_Years_Value);
        __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older = new Lazy<IEnumerable<Observation>>(this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Cervical_Cytology_Within_3_Years__2_ = new Lazy<IEnumerable<Observation>>(this.Cervical_Cytology_Within_3_Years__2__Value);
        __HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_ = new Lazy<IEnumerable<Observation>>(this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public HospiceFHIR4_2_3_000 HospiceFHIR4_2_3_000 { get; }
    public PalliativeCareFHIR_0_6_000 PalliativeCareFHIR_0_6_000 { get; }

    #endregion

	private CqlValueSet Congenital_or_Acquired_Absence_of_Cervix_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", default);

    [CqlDeclaration("Congenital or Acquired Absence of Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016")]
	public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix() => 
		__Congenital_or_Acquired_Absence_of_Cervix.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet HPV_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", default);

    [CqlDeclaration("HPV Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059")]
	public CqlValueSet HPV_Test() => 
		__HPV_Test.Value;

	private CqlValueSet Hysterectomy_with_No_Residual_Cervix_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", default);

    [CqlDeclaration("Hysterectomy with No Residual Cervix")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014")]
	public CqlValueSet Hysterectomy_with_No_Residual_Cervix() => 
		__Hysterectomy_with_No_Residual_Cervix.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Pap_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", default);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public CqlValueSet Pap_Test() => 
		__Pap_Test.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode laboratory_Value() => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory() => 
		__laboratory.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet c_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet h_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Telephone_Visits();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet n_ = this.Online_Assessments();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		bool? r_(Encounter ValidEncounter)
		{
			Code<Encounter.EncounterStatus> t_ = ValidEncounter?.StatusElement;
			string u_ = FHIRHelpers_4_0_001.ToString(t_);
			bool? v_ = context.Operators.Equal(u_, "finished");
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period();
			Period x_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.ToInterval(x_);
			bool? z_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, y_, default);
			bool? aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

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
		CqlInterval<int?> i_ = context.Operators.Interval(23, 64, true, false);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		Code<AdministrativeGender> l_ = a_?.GenderElement;
		string m_ = FHIRHelpers_4_0_001.ToString(l_);
		bool? n_ = context.Operators.Equal(m_, "female");
		bool? o_ = context.Operators.And(j_, n_);
		IEnumerable<Encounter> p_ = this.Qualifying_Encounters();
		bool? q_ = context.Operators.Exists<Encounter>(p_);
		bool? r_ = context.Operators.And(o_, q_);

		return r_;
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

	private IEnumerable<object> Absence_of_Cervix_Value()
	{
		CqlValueSet a_ = this.Hysterectomy_with_No_Residual_Cervix();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		bool? c_(Procedure NoCervixProcedure)
		{
			Code<EventStatus> j_ = NoCervixProcedure?.StatusElement;
			string k_ = FHIRHelpers_4_0_001.ToString(j_);
			bool? l_ = context.Operators.Equal(k_, "completed");
			DataType m_ = NoCervixProcedure?.Performed;
			CqlInterval<CqlDateTime> n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			bool? r_ = context.Operators.SameOrBefore(o_, q_, default);
			bool? s_ = context.Operators.And(l_, r_);

			return s_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
		CqlValueSet e_ = this.Congenital_or_Acquired_Absence_of_Cervix();
		IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? g_(Condition NoCervixDiagnosis)
		{
			CqlInterval<CqlDateTime> t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(NoCervixDiagnosis);
			CqlDateTime u_ = context.Operators.Start(t_);
			CqlInterval<CqlDateTime> v_ = this.Measurement_Period();
			CqlDateTime w_ = context.Operators.End(v_);
			bool? x_ = context.Operators.SameOrBefore(u_, w_, default);

			return x_;
		};
		IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
		IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);

		return i_;
	}

    [CqlDeclaration("Absence of Cervix")]
	public IEnumerable<object> Absence_of_Cervix() => 
		__Absence_of_Cervix.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		IEnumerable<object> b_ = this.Absence_of_Cervix();
		bool? c_ = context.Operators.Exists<object>(b_);
		bool? d_ = context.Operators.Or(a_, c_);
		bool? e_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		bool? f_ = context.Operators.Or(d_, e_);

		return f_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Value()
	{
		CqlValueSet a_ = this.Pap_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation CervicalCytology)
		{
			Code<ObservationStatus> e_ = CervicalCytology?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = CervicalCytology?.Category;
			bool? j_(CodeableConcept CervicalCytologyCategory)
			{
				CqlCode af_ = this.laboratory();
				CqlConcept ag_ = FHIRHelpers_4_0_001.ToConcept(CervicalCytologyCategory);
				CqlCode[] ah_ = ag_?.codes;
				bool? ai_ = context.Operators.In<CqlCode>(af_, (IEnumerable<CqlCode>)ah_);

				return ai_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			DataType n_ = CervicalCytology?.Effective;
			CqlDateTime o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(3m, "years");
			CqlDateTime s_ = context.Operators.Subtract(q_, r_);
			CqlDateTime u_ = context.Operators.End(p_);
			CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, default);
			CqlDateTime y_ = context.Operators.End(p_);
			bool? z_ = context.Operators.Not((bool?)(y_ is null));
			bool? aa_ = context.Operators.And(w_, z_);
			bool? ab_ = context.Operators.And(m_, aa_);
			DataType ac_ = CervicalCytology?.Value;
			bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years() => 
		__Cervical_Cytology_Within_3_Years.Value;

	private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Value()
	{
		CqlValueSet a_ = this.HPV_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation HPVTest)
		{
			Code<ObservationStatus> e_ = HPVTest?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = HPVTest?.Category;
			bool? j_(CodeableConcept HPVTestCategory)
			{
				CqlCode aq_ = this.laboratory();
				CqlConcept ar_ = FHIRHelpers_4_0_001.ToConcept(HPVTestCategory);
				CqlCode[] as_ = ar_?.codes;
				bool? at_ = context.Operators.In<CqlCode>(aq_, (IEnumerable<CqlCode>)as_);

				return at_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			Patient n_ = this.Patient();
			Date o_ = n_?.BirthDateElement;
			string p_ = o_?.Value;
			CqlDate q_ = context.Operators.ConvertStringToDate(p_);
			DataType r_ = HPVTest?.Effective;
			CqlInterval<CqlDateTime> s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlDate u_ = context.Operators.DateFrom(t_);
			int? v_ = context.Operators.CalculateAgeAt(q_, u_, "year");
			bool? w_ = context.Operators.GreaterOrEqual(v_, 30);
			bool? x_ = context.Operators.And(m_, w_);
			CqlDateTime z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(r_);
			CqlInterval<CqlDateTime> aa_ = this.Measurement_Period();
			CqlDateTime ab_ = context.Operators.End(aa_);
			CqlQuantity ac_ = context.Operators.Quantity(5m, "years");
			CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
			CqlDateTime af_ = context.Operators.End(aa_);
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ad_, af_, true, true);
			bool? ah_ = context.Operators.In<CqlDateTime>(z_, ag_, default);
			CqlDateTime aj_ = context.Operators.End(aa_);
			bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
			bool? al_ = context.Operators.And(ah_, ak_);
			bool? am_ = context.Operators.And(x_, al_);
			DataType an_ = HPVTest?.Value;
			bool? ao_ = context.Operators.Not((bool?)(an_ is null));
			bool? ap_ = context.Operators.And(am_, ao_);

			return ap_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older() => 
		__HPV_Test_Within_5_Years_for_Women_Age_30_and_Older.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<Observation> a_ = this.Cervical_Cytology_Within_3_Years();
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older();
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

    [CqlDeclaration("isComplete")]
	public bool? isComplete(Observation observation)
	{
		Code<ObservationStatus> a_ = observation?.StatusElement;
		string b_ = FHIRHelpers_4_0_001.ToString(a_);
		string[] c_ = [
			"final",
			"amended",
			"corrected",
		];
		bool? d_ = context.Operators.In<string>(b_, c_ as IEnumerable<string>);

		return d_;
	}

    [CqlDeclaration("isLaboratoryTest")]
	public bool? isLaboratoryTest(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		bool? b_(CodeableConcept category)
		{
			CqlCode e_ = this.laboratory();
			CqlConcept f_ = FHIRHelpers_4_0_001.ToConcept(category);
			CqlCode[] g_ = f_?.codes;
			bool? h_ = context.Operators.In<CqlCode>(e_, (IEnumerable<CqlCode>)g_);

			return h_;
		};
		IEnumerable<CodeableConcept> c_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_ = context.Operators.Exists<CodeableConcept>(c_);

		return d_;
	}

    [CqlDeclaration("latest")]
	public CqlDateTime latest(object choice)
	{
		CqlDateTime a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(choice);

		return a_;
	}

	private IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2__Value()
	{
		CqlValueSet a_ = this.Pap_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation CervicalCytology)
		{
			bool? e_ = this.isComplete(CervicalCytology);
			bool? f_ = this.isLaboratoryTest(CervicalCytology);
			bool? g_ = context.Operators.And(e_, f_);
			DataType h_ = CervicalCytology?.Effective;
			CqlDateTime i_ = this.latest(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.End(j_);
			CqlQuantity l_ = context.Operators.Quantity(3m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, default);
			CqlDateTime s_ = context.Operators.End(j_);
			bool? t_ = context.Operators.Not((bool?)(s_ is null));
			bool? u_ = context.Operators.And(q_, t_);
			bool? v_ = context.Operators.And(g_, u_);
			DataType w_ = CervicalCytology?.Value;
			bool? x_ = context.Operators.Not((bool?)(w_ is null));
			bool? y_ = context.Operators.And(v_, x_);

			return y_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Cervical Cytology Within 3 Years (2)")]
	public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_() => 
		__Cervical_Cytology_Within_3_Years__2_.Value;

    [CqlDeclaration("toInterval")]
	public CqlInterval<CqlDateTime> toInterval(object choice)
	{
		CqlInterval<CqlDateTime> a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(choice);

		return a_;
	}

	private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Value()
	{
		CqlValueSet a_ = this.HPV_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation HPVTest)
		{
			bool? e_ = this.isComplete(HPVTest);
			bool? f_ = this.isLaboratoryTest(HPVTest);
			bool? g_ = context.Operators.And(e_, f_);
			Patient h_ = this.Patient();
			Date i_ = h_?.BirthDateElement;
			string j_ = i_?.Value;
			CqlDate k_ = context.Operators.ConvertStringToDate(j_);
			DataType l_ = HPVTest?.Effective;
			CqlInterval<CqlDateTime> m_ = this.toInterval(l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlDate o_ = context.Operators.DateFrom(n_);
			int? p_ = context.Operators.CalculateAgeAt(k_, o_, "year");
			bool? q_ = context.Operators.GreaterOrEqual(p_, 30);
			bool? r_ = context.Operators.And(g_, q_);
			CqlDateTime t_ = this.latest(l_);
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
			CqlDateTime v_ = context.Operators.End(u_);
			CqlQuantity w_ = context.Operators.Quantity(5m, "years");
			CqlDateTime x_ = context.Operators.Subtract(v_, w_);
			CqlDateTime z_ = context.Operators.End(u_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(x_, z_, true, true);
			bool? ab_ = context.Operators.In<CqlDateTime>(t_, aa_, default);
			CqlDateTime ad_ = context.Operators.End(u_);
			bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
			bool? af_ = context.Operators.And(ab_, ae_);
			bool? ag_ = context.Operators.And(r_, af_);
			DataType ah_ = HPVTest?.Value;
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(ag_, ai_);

			return aj_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
	public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_() => 
		__HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_.Value;

}
