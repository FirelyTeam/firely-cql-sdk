using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("HIVViralSuppressionFHIR", "0.1.000")]
public class HIVViralSuppressionFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Face_to_Face_Interaction;
    internal Lazy<CqlValueSet> __HIV;
    internal Lazy<CqlValueSet> __HIV_Viral_Load;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Other;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Telehealth_Services;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> __Below_threshold_level__qualifier_value_;
    internal Lazy<CqlCode> __Not_detected__qualifier_value_;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period;
    internal Lazy<bool?> __Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<Observation> __Most_Recent_Viral_Load_Test_During_Measurement_Period;
    internal Lazy<bool?> __Numerator;

    #endregion
    public HIVViralSuppressionFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);

        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Face_to_Face_Interaction = new Lazy<CqlValueSet>(this.Face_to_Face_Interaction_Value);
        __HIV = new Lazy<CqlValueSet>(this.HIV_Value);
        __HIV_Viral_Load = new Lazy<CqlValueSet>(this.HIV_Viral_Load_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Other = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Other_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Telehealth_Services = new Lazy<CqlValueSet>(this.Telehealth_Services_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Below_threshold_level__qualifier_value_ = new Lazy<CqlCode>(this.Below_threshold_level__qualifier_value__Value);
        __Not_detected__qualifier_value_ = new Lazy<CqlCode>(this.Not_detected__qualifier_value__Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period = new Lazy<bool?>(this.Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period_Value);
        __Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period = new Lazy<bool?>(this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Most_Recent_Viral_Load_Test_During_Measurement_Period = new Lazy<Observation>(this.Most_Recent_Viral_Load_Test_During_Measurement_Period_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Face_to_Face_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", default);

    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public CqlValueSet Face_to_Face_Interaction() => 
		__Face_to_Face_Interaction.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet HIV_Viral_Load_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", default);

    [CqlDeclaration("HIV Viral Load")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002")]
	public CqlValueSet HIV_Viral_Load() => 
		__HIV_Viral_Load.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", default);

    [CqlDeclaration("Preventive Care Services Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030")]
	public CqlValueSet Preventive_Care_Services_Other() => 
		__Preventive_Care_Services_Other.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Telehealth_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", default);

    [CqlDeclaration("Telehealth Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031")]
	public CqlValueSet Telehealth_Services() => 
		__Telehealth_Services.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode Below_threshold_level__qualifier_value__Value() => 
		new CqlCode("260988000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Below threshold level (qualifier value)")]
	public CqlCode Below_threshold_level__qualifier_value_() => 
		__Below_threshold_level__qualifier_value_.Value;

	private CqlCode Not_detected__qualifier_value__Value() => 
		new CqlCode("260415000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Not detected (qualifier value)")]
	public CqlCode Not_detected__qualifier_value_() => 
		__Not_detected__qualifier_value_.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("260988000", "http://snomed.info/sct", default, default),
			new CqlCode("260415000", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HIVViralSuppressionFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.HIV();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition HIVDx)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HIVDx);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlQuantity j_ = context.Operators.Quantity(90m, "days");
			CqlDateTime k_ = context.Operators.Add(i_, j_);
			bool? l_ = context.Operators.Before(g_, k_, "day");

			return l_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Active HIV Diagnosis Before or in First 90 Days of Measurement Period")]
	public bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period() => 
		__Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period.Value;

	private bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Face_to_Face_Interaction();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, default);
		CqlValueSet z_ = this.Telephone_Visits();
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, default);
		IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care_Services_Other();
		IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, default);
		IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ac_, ae_);
		bool? ag_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> aj_ = this.Measurement_Period();
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlDateTime am_ = context.Operators.Start(aj_);
			CqlQuantity an_ = context.Operators.Quantity(240m, "days");
			CqlDateTime ao_ = context.Operators.Add(am_, an_);
			CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, ao_, true, true);
			Period aq_ = QualifyingEncounter?.Period;
			CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_3_000.ToInterval(aq_);
			bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, "day");

			return as_;
		};
		IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
		bool? ai_ = context.Operators.Exists<Encounter>(ah_);

		return ai_;
	}

    [CqlDeclaration("Has Qualifying Encounter During First 240 Days of Measurement Period")]
	public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period() => 
		__Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		bool? a_ = this.Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period();
		bool? b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period();
		bool? c_ = context.Operators.And(a_, b_);

		return c_;
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

	private Observation Most_Recent_Viral_Load_Test_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.HIV_Viral_Load();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation ViralLoad)
		{
			object h_()
			{
				bool l_()
				{
					DataType o_ = ViralLoad?.Effective;
					object p_ = FHIRHelpers_4_3_000.ToValue(o_);
					bool q_ = p_ is CqlDateTime;

					return q_;
				};
				bool m_()
				{
					DataType r_ = ViralLoad?.Effective;
					object s_ = FHIRHelpers_4_3_000.ToValue(r_);
					bool t_ = s_ is CqlInterval<CqlDateTime>;

					return t_;
				};
				bool n_()
				{
					DataType u_ = ViralLoad?.Effective;
					object v_ = FHIRHelpers_4_3_000.ToValue(u_);
					bool w_ = v_ is CqlDateTime;

					return w_;
				};
				if (l_())
				{
					DataType x_ = ViralLoad?.Effective;
					object y_ = FHIRHelpers_4_3_000.ToValue(x_);
					CqlDateTime z_ = y_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return z_ as object;
				}
				else if (m_())
				{
					DataType aa_ = ViralLoad?.Effective;
					object ab_ = FHIRHelpers_4_3_000.ToValue(aa_);
					CqlInterval<CqlDateTime> ac_ = ab_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ac_ as object;
				}
				else if (n_())
				{
					DataType ad_ = ViralLoad?.Effective;
					object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
					CqlDateTime af_ = ae_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return af_ as object;
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
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			DataType ag_ = @this?.Effective;
			object ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
			CqlInterval<CqlDateTime> ai_ = QICoreCommon_2_0_000.ToInterval(ah_);
			CqlDateTime aj_ = context.Operators.Start(ai_);

			return aj_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.Last<Observation>(f_);

		return g_;
	}

    [CqlDeclaration("Most Recent Viral Load Test During Measurement Period")]
	public Observation Most_Recent_Viral_Load_Test_During_Measurement_Period() => 
		__Most_Recent_Viral_Load_Test_During_Measurement_Period.Value;

	private bool? Numerator_Value()
	{
		Observation a_ = this.Most_Recent_Viral_Load_Test_During_Measurement_Period();
		DataType b_ = a_?.Value;
		object c_ = FHIRHelpers_4_3_000.ToValue(b_);
		CqlQuantity d_ = c_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
		CqlQuantity e_ = context.Operators.Quantity(200m, "{copies}/mL");
		bool? f_ = context.Operators.Less(d_, e_);
		DataType h_ = a_?.Value;
		object i_ = FHIRHelpers_4_3_000.ToValue(h_);
		CqlConcept j_ = i_ switch { null => null , CqlConcept b => b/* , CqlQuantity => ???, string => ???, bool => ???, int => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
		CqlCode k_ = this.Below_threshold_level__qualifier_value_();
		CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
		bool? m_ = context.Operators.Equivalent(j_, l_);
		bool? n_ = context.Operators.Or(f_, m_);
		DataType p_ = a_?.Value;
		object q_ = FHIRHelpers_4_3_000.ToValue(p_);
		CqlCode s_ = this.Not_detected__qualifier_value_();
		CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
		bool? u_ = context.Operators.Equivalent(j_, t_);
		bool? v_ = context.Operators.Or(n_, u_);

		return v_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
