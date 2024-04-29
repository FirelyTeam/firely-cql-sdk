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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Face_to_Face_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public CqlValueSet Face_to_Face_Interaction() => 
		__Face_to_Face_Interaction.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet HIV_Viral_Load_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", null);

    [CqlDeclaration("HIV Viral Load")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002")]
	public CqlValueSet HIV_Viral_Load() => 
		__HIV_Viral_Load.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", null);

    [CqlDeclaration("Preventive Care Services Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030")]
	public CqlValueSet Preventive_Care_Services_Other() => 
		__Preventive_Care_Services_Other.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Telehealth_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", null);

    [CqlDeclaration("Telehealth Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031")]
	public CqlValueSet Telehealth_Services() => 
		__Telehealth_Services.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode Below_threshold_level__qualifier_value__Value() => 
		new CqlCode("260988000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Below threshold level (qualifier value)")]
	public CqlCode Below_threshold_level__qualifier_value_() => 
		__Below_threshold_level__qualifier_value_.Value;

	private CqlCode Not_detected__qualifier_value__Value() => 
		new CqlCode("260415000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Not detected (qualifier value)")]
	public CqlCode Not_detected__qualifier_value_() => 
		__Not_detected__qualifier_value_.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("260988000", "http://snomed.info/sct", null, null),
			new CqlCode("260415000", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] CPT_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("HIVViralSuppressionFHIR-0.1.000", "Measurement Period", c_);

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

	private bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period_Value()
	{
		var a_ = this.HIV();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition HIVDx)
		{
			var f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HIVDx);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.Quantity(90m, "days");
			var k_ = context.Operators.Add(i_, j_);
			var l_ = context.Operators.Before(g_, k_, "day");

			return l_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Active HIV Diagnosis Before or in First 90 Days of Measurement Period")]
	public bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period() => 
		__Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period.Value;

	private bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Outpatient_Consultation();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Annual_Wellness_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Face_to_Face_Interaction();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Home_Healthcare_Services();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		var x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = this.Telephone_Visits();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		var ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		var ad_ = this.Preventive_Care_Services_Other();
		var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = context.Operators.ListUnion<Encounter>(ac_, ae_);
		bool? ag_(Encounter QualifyingEncounter)
		{
			var aj_ = this.Measurement_Period();
			var ak_ = context.Operators.Start(aj_);
			var am_ = context.Operators.Start(aj_);
			var an_ = context.Operators.Quantity(240m, "days");
			var ao_ = context.Operators.Add(am_, an_);
			var ap_ = context.Operators.Interval(ak_, ao_, true, true);
			var aq_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
			var ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, aq_, "day");

			return ar_;
		};
		var ah_ = context.Operators.Where<Encounter>(af_, ag_);
		var ai_ = context.Operators.Exists<Encounter>(ah_);

		return ai_;
	}

    [CqlDeclaration("Has Qualifying Encounter During First 240 Days of Measurement Period")]
	public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period() => 
		__Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period();
		var b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period();
		var c_ = context.Operators.And(a_, b_);

		return c_;
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

	private Observation Most_Recent_Viral_Load_Test_During_Measurement_Period_Value()
	{
		var a_ = this.HIV_Viral_Load();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation ViralLoad)
		{
			object h_()
			{
				bool l_()
				{
					var o_ = FHIRHelpers_4_3_000.ToValue(ViralLoad?.Effective);
					var p_ = o_ is CqlDateTime;

					return p_;
				};
				bool m_()
				{
					var q_ = FHIRHelpers_4_3_000.ToValue(ViralLoad?.Effective);
					var r_ = q_ is CqlInterval<CqlDateTime>;

					return r_;
				};
				bool n_()
				{
					var s_ = FHIRHelpers_4_3_000.ToValue(ViralLoad?.Effective);
					var t_ = s_ is CqlDateTime;

					return t_;
				};
				if (l_())
				{
					var u_ = FHIRHelpers_4_3_000.ToValue(ViralLoad?.Effective);

					return ((u_ as CqlDateTime) as object);
				}
				else if (m_())
				{
					var v_ = FHIRHelpers_4_3_000.ToValue(ViralLoad?.Effective);

					return ((v_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (n_())
				{
					var w_ = FHIRHelpers_4_3_000.ToValue(ViralLoad?.Effective);

					return ((w_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var i_ = QICoreCommon_2_0_000.Latest(h_());
			var j_ = this.Measurement_Period();
			var k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");

			return k_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			var x_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var y_ = QICoreCommon_2_0_000.ToInterval(x_);
			var z_ = context.Operators.Start(y_);

			return z_;
		};
		var f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.Last<Observation>(f_);

		return g_;
	}

    [CqlDeclaration("Most Recent Viral Load Test During Measurement Period")]
	public Observation Most_Recent_Viral_Load_Test_During_Measurement_Period() => 
		__Most_Recent_Viral_Load_Test_During_Measurement_Period.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Most_Recent_Viral_Load_Test_During_Measurement_Period();
		var b_ = FHIRHelpers_4_3_000.ToValue(a_?.Value);
		var c_ = context.Operators.Quantity(200m, "{copies}/mL");
		var d_ = context.Operators.Less((b_ as CqlQuantity), c_);
		var f_ = FHIRHelpers_4_3_000.ToValue(a_?.Value);
		var g_ = this.Below_threshold_level__qualifier_value_();
		var h_ = context.Operators.ConvertCodeToConcept(g_);
		var i_ = context.Operators.Equivalent((f_ as CqlConcept), h_);
		var j_ = context.Operators.Or(d_, i_);
		var l_ = FHIRHelpers_4_3_000.ToValue(a_?.Value);
		var m_ = this.Not_detected__qualifier_value_();
		var n_ = context.Operators.ConvertCodeToConcept(m_);
		var o_ = context.Operators.Equivalent((l_ as CqlConcept), n_);
		var p_ = context.Operators.Or(j_, o_);

		return p_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
