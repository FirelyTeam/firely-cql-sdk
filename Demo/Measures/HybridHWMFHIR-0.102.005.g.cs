using System;
using Tuples;
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
[CqlLibrary("HybridHWMFHIR", "0.102.005")]
public class HybridHWMFHIR_0_102_005
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bicarbonate_lab_test;
    internal Lazy<CqlValueSet> __Body_temperature;
    internal Lazy<CqlValueSet> __Creatinine_lab_test;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Ethnicity;
    internal Lazy<CqlValueSet> __Hematocrit_lab_test;
    internal Lazy<CqlValueSet> __Medicare_payer;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __ONC_Administrative_Sex;
    internal Lazy<CqlValueSet> __Payer;
    internal Lazy<CqlValueSet> __Platelet_count_lab_test;
    internal Lazy<CqlValueSet> __Race;
    internal Lazy<CqlValueSet> __Sodium_lab_test;
    internal Lazy<CqlValueSet> __White_blood_cells_count_lab_test;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Heart_rate;
    internal Lazy<CqlCode> __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    internal Lazy<CqlCode> __Systolic_blood_pressure;
    internal Lazy<CqlCode[]> __LOINC_2_69;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounters;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<string>> __Results;

    #endregion
    public HybridHWMFHIR_0_102_005(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __Bicarbonate_lab_test = new Lazy<CqlValueSet>(this.Bicarbonate_lab_test_Value);
        __Body_temperature = new Lazy<CqlValueSet>(this.Body_temperature_Value);
        __Creatinine_lab_test = new Lazy<CqlValueSet>(this.Creatinine_lab_test_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Ethnicity = new Lazy<CqlValueSet>(this.Ethnicity_Value);
        __Hematocrit_lab_test = new Lazy<CqlValueSet>(this.Hematocrit_lab_test_Value);
        __Medicare_payer = new Lazy<CqlValueSet>(this.Medicare_payer_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __ONC_Administrative_Sex = new Lazy<CqlValueSet>(this.ONC_Administrative_Sex_Value);
        __Payer = new Lazy<CqlValueSet>(this.Payer_Value);
        __Platelet_count_lab_test = new Lazy<CqlValueSet>(this.Platelet_count_lab_test_Value);
        __Race = new Lazy<CqlValueSet>(this.Race_Value);
        __Sodium_lab_test = new Lazy<CqlValueSet>(this.Sodium_lab_test_Value);
        __White_blood_cells_count_lab_test = new Lazy<CqlValueSet>(this.White_blood_cells_count_lab_test_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Heart_rate = new Lazy<CqlCode>(this.Heart_rate_Value);
        __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new Lazy<CqlCode>(this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value);
        __Systolic_blood_pressure = new Lazy<CqlCode>(this.Systolic_blood_pressure_Value);
        __LOINC_2_69 = new Lazy<CqlCode[]>(this.LOINC_2_69_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Inpatient_Encounters = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounters_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Results = new Lazy<IEnumerable<string>>(this.Results_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

	private CqlValueSet Bicarbonate_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
	public CqlValueSet Bicarbonate_lab_test() => 
		__Bicarbonate_lab_test.Value;

	private CqlValueSet Body_temperature_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
	public CqlValueSet Body_temperature() => 
		__Body_temperature.Value;

	private CqlValueSet Creatinine_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
	public CqlValueSet Creatinine_lab_test() => 
		__Creatinine_lab_test.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Ethnicity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity.Value;

	private CqlValueSet Hematocrit_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public CqlValueSet Hematocrit_lab_test() => 
		__Hematocrit_lab_test.Value;

	private CqlValueSet Medicare_payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
	public CqlValueSet Medicare_payer() => 
		__Medicare_payer.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex.Value;

	private CqlValueSet Payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer() => 
		__Payer.Value;

	private CqlValueSet Platelet_count_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
	public CqlValueSet Platelet_count_lab_test() => 
		__Platelet_count_lab_test.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

	private CqlValueSet Sodium_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
	public CqlValueSet Sodium_lab_test() => 
		__Sodium_lab_test.Value;

	private CqlValueSet White_blood_cells_count_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
	public CqlValueSet White_blood_cells_count_lab_test() => 
		__White_blood_cells_count_lab_test.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode Heart_rate_Value() => 
		new CqlCode("8867-4", "http://loinc.org", null, null);

    [CqlDeclaration("Heart rate")]
	public CqlCode Heart_rate() => 
		__Heart_rate.Value;

	private CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value() => 
		new CqlCode("59408-5", "http://loinc.org", null, null);

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
	public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry() => 
		__Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry.Value;

	private CqlCode Systolic_blood_pressure_Value() => 
		new CqlCode("8480-6", "http://loinc.org", null, null);

    [CqlDeclaration("Systolic blood pressure")]
	public CqlCode Systolic_blood_pressure() => 
		__Systolic_blood_pressure.Value;

	private CqlCode[] LOINC_2_69_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
			new CqlCode("8867-4", "http://loinc.org", null, null),
			new CqlCode("59408-5", "http://loinc.org", null, null),
			new CqlCode("8480-6", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC:2.69")]
	public CqlCode[] LOINC_2_69() => 
		__LOINC_2_69.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
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

	private IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
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

    [CqlDeclaration("LengthInDays")]
	public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		CqlDateTime a_ = context.Operators.Start(Value);
		CqlDateTime b_ = context.Operators.End(Value);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

	private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Medicare_payer();
		IEnumerable<Coverage> d_ = context.Operators.RetrieveByValueSet<Coverage>(c_, null);
		IEnumerable<ValueTuple<Encounter,Coverage>> e_ = context.Operators.CrossJoin<Encounter, Coverage>(b_, d_);
		Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV f_(ValueTuple<Encounter,Coverage> _valueTuple)
		{
			Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV l_ = new Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = _valueTuple.Item1,
				Payer = _valueTuple.Item2,
			};

			return l_;
		};
		IEnumerable<Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV> g_ = context.Operators.Select<ValueTuple<Encounter,Coverage>, Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(e_, f_);
		bool? h_(Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv)
		{
			string m_ = context.Operators.Convert<string>(tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter?.StatusElement);
			bool? n_ = context.Operators.Equal(m_, "finished");
			CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter);
			int? p_ = this.LengthInDays(o_);
			bool? q_ = context.Operators.Less(p_, 365);
			bool? r_ = context.Operators.And(n_, q_);
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_0_001.ToInterval(tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter?.Period);
			CqlDateTime t_ = context.Operators.End(s_);
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
			bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
			bool? w_ = context.Operators.And(r_, v_);
			Patient x_ = this.Patient();
			CqlDate y_ = context.Operators.Convert<CqlDate>(x_?.BirthDateElement?.Value);
			CqlDateTime aa_ = context.Operators.Start(s_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);
			int? ac_ = context.Operators.CalculateAgeAt(y_, ab_, "year");
			CqlInterval<int?> ad_ = context.Operators.Interval(65, 94, true, true);
			bool? ae_ = context.Operators.In<int?>(ac_, ad_, null);
			bool? af_ = context.Operators.And(w_, ae_);

			return af_;
		};
		IEnumerable<Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV> i_ = context.Operators.Where<Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(g_, h_);
		Encounter j_(Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) => 
			tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;
		IEnumerable<Encounter> k_ = context.Operators.Select<Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Inpatient Encounters")]
	public IEnumerable<Encounter> Inpatient_Encounters() => 
		__Inpatient_Encounters.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

    [CqlDeclaration("FirstPhysicalExamWithEncounterId")]
	public IEnumerable<string> FirstPhysicalExamWithEncounterId(IEnumerable<Observation> ExamList, string CCDE)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		string b_(Encounter Encounter)
		{
			string d_ = context.Operators.Concatenate("\r\n", (CCDE ?? ""));
			string e_ = context.Operators.Concatenate((d_ ?? ""), ",");
			string f_ = context.Operators.Convert<string>(Encounter?.IdElement);
			string g_ = context.Operators.Concatenate((e_ ?? ""), (f_ ?? ""));
			string h_ = context.Operators.Concatenate((g_ ?? ""), " , ");
			bool? i_(Observation Exam)
			{
				CqlInterval<CqlDateTime> aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(Exam?.Effective);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
				CqlDateTime ae_ = context.Operators.Start(aa_);
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
				CqlDateTime ag_ = context.Operators.Start(af_);
				CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
				CqlDateTime ak_ = context.Operators.Start(af_);
				CqlQuantity al_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime am_ = context.Operators.Add(ak_, al_);
				CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ai_, am_, true, true);
				bool? ao_ = context.Operators.In<CqlDateTime>(ae_, an_, null);
				bool? ap_ = context.Operators.And(ac_, ao_);
				string aq_ = context.Operators.Convert<string>(Exam?.StatusElement);
				string[] ar_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				bool? as_ = context.Operators.In<string>(aq_, (ar_ as IEnumerable<string>));
				bool? at_ = context.Operators.And(ap_, as_);
				bool? au_ = context.Operators.Not((bool?)(Exam?.Value is null));
				bool? av_ = context.Operators.And(at_, au_);

				return av_;
			};
			IEnumerable<Observation> j_ = context.Operators.Where<Observation>(ExamList, i_);
			object k_(Observation @this)
			{
				CqlInterval<CqlDateTime> aw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(@this?.Effective);
				CqlDateTime ax_ = context.Operators.Start(aw_);

				return ax_;
			};
			IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
			Observation m_ = context.Operators.First<Observation>(l_);
			CqlQuantity n_ = FHIRHelpers_4_0_001.ToQuantity((m_?.Value as Quantity));
			string o_ = context.Operators.ConvertQuantityToString(n_);
			string p_ = context.Operators.Concatenate((h_ ?? ""), (o_ ?? ""));
			string q_ = context.Operators.Concatenate((p_ ?? ""), ",");
			bool? r_(Observation Exam)
			{
				CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(Exam?.Effective);
				CqlDateTime az_ = context.Operators.Start(ay_);
				bool? ba_ = context.Operators.Not((bool?)(az_ is null));
				CqlDateTime bc_ = context.Operators.Start(ay_);
				CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
				CqlDateTime be_ = context.Operators.Start(bd_);
				CqlQuantity bf_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
				CqlDateTime bi_ = context.Operators.Start(bd_);
				CqlQuantity bj_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime bk_ = context.Operators.Add(bi_, bj_);
				CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bg_, bk_, true, true);
				bool? bm_ = context.Operators.In<CqlDateTime>(bc_, bl_, null);
				bool? bn_ = context.Operators.And(ba_, bm_);
				string bo_ = context.Operators.Convert<string>(Exam?.StatusElement);
				string[] bp_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				bool? bq_ = context.Operators.In<string>(bo_, (bp_ as IEnumerable<string>));
				bool? br_ = context.Operators.And(bn_, bq_);
				bool? bs_ = context.Operators.Not((bool?)(Exam?.Value is null));
				bool? bt_ = context.Operators.And(br_, bs_);

				return bt_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(ExamList, r_);
			object t_(Observation @this)
			{
				CqlInterval<CqlDateTime> bu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(@this?.Effective);
				CqlDateTime bv_ = context.Operators.Start(bu_);

				return bv_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			CqlInterval<CqlDateTime> w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(v_?.Effective);
			CqlDateTime x_ = context.Operators.Start(w_);
			string y_ = context.Operators.ConvertDateTimeToString(x_);
			string z_ = context.Operators.Concatenate((q_ ?? ""), (y_ ?? ""));

			return z_;
		};
		IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);

		return c_;
	}

    [CqlDeclaration("FirstLabTestWithEncounterId")]
	public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		string b_(Encounter Encounter)
		{
			string d_ = context.Operators.Concatenate("\r\n", (CCDE ?? ""));
			string e_ = context.Operators.Concatenate((d_ ?? ""), ",");
			string f_ = context.Operators.Convert<string>(Encounter?.IdElement);
			string g_ = context.Operators.Concatenate((e_ ?? ""), (f_ ?? ""));
			string h_ = context.Operators.Concatenate((g_ ?? ""), ",");
			bool? i_(Observation Lab)
			{
				bool? z_ = context.Operators.Not((bool?)(Lab?.IssuedElement is null));
				CqlDateTime aa_ = FHIRHelpers_4_0_001.ToDateTime(Lab?.IssuedElement);
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
				CqlDateTime ac_ = context.Operators.Start(ab_);
				CqlQuantity ad_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
				CqlDateTime ag_ = context.Operators.Start(ab_);
				CqlDateTime ai_ = context.Operators.Add(ag_, ad_);
				CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ae_, ai_, true, true);
				bool? ak_ = context.Operators.In<CqlDateTime>(aa_, aj_, null);
				bool? al_ = context.Operators.And(z_, ak_);
				string am_ = context.Operators.Convert<string>(Lab?.StatusElement);
				string[] an_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				bool? ao_ = context.Operators.In<string>(am_, (an_ as IEnumerable<string>));
				bool? ap_ = context.Operators.And(al_, ao_);
				bool? aq_ = context.Operators.Not((bool?)(Lab?.Value is null));
				bool? ar_ = context.Operators.And(ap_, aq_);

				return ar_;
			};
			IEnumerable<Observation> j_ = context.Operators.Where<Observation>(LabList, i_);
			object k_(Observation @this) => 
				@this?.IssuedElement;
			IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
			Observation m_ = context.Operators.First<Observation>(l_);
			CqlQuantity n_ = FHIRHelpers_4_0_001.ToQuantity((m_?.Value as Quantity));
			string o_ = context.Operators.ConvertQuantityToString(n_);
			string p_ = context.Operators.Concatenate((h_ ?? ""), (o_ ?? ""));
			string q_ = context.Operators.Concatenate((p_ ?? ""), ",");
			bool? r_(Observation Lab)
			{
				bool? as_ = context.Operators.Not((bool?)(Lab?.IssuedElement is null));
				CqlDateTime at_ = FHIRHelpers_4_0_001.ToDateTime(Lab?.IssuedElement);
				CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
				CqlDateTime av_ = context.Operators.Start(au_);
				CqlQuantity aw_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ax_ = context.Operators.Subtract(av_, aw_);
				CqlDateTime az_ = context.Operators.Start(au_);
				CqlDateTime bb_ = context.Operators.Add(az_, aw_);
				CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ax_, bb_, true, true);
				bool? bd_ = context.Operators.In<CqlDateTime>(at_, bc_, null);
				bool? be_ = context.Operators.And(as_, bd_);
				string bf_ = context.Operators.Convert<string>(Lab?.StatusElement);
				string[] bg_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				bool? bh_ = context.Operators.In<string>(bf_, (bg_ as IEnumerable<string>));
				bool? bi_ = context.Operators.And(be_, bh_);
				bool? bj_ = context.Operators.Not((bool?)(Lab?.Value is null));
				bool? bk_ = context.Operators.And(bi_, bj_);

				return bk_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(LabList, r_);
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, k_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			CqlDateTime w_ = FHIRHelpers_4_0_001.ToDateTime(v_?.IssuedElement);
			string x_ = context.Operators.ConvertDateTimeToString(w_);
			string y_ = context.Operators.Concatenate((q_ ?? ""), (x_ ?? ""));

			return y_;
		};
		IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);

		return c_;
	}

	private IEnumerable<string> Results_Value()
	{
		CqlCode a_ = this.Heart_rate();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<string> d_ = this.FirstPhysicalExamWithEncounterId(c_, "FirstHeartRate");
		CqlCode e_ = this.Systolic_blood_pressure();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		IEnumerable<string> h_ = this.FirstPhysicalExamWithEncounterId(g_, "FirstSystolicBP");
		CqlValueSet i_ = this.Body_temperature();
		IEnumerable<Observation> j_ = context.Operators.RetrieveByValueSet<Observation>(i_, null);
		IEnumerable<string> k_ = this.FirstPhysicalExamWithEncounterId(j_, "FirstTemperature");
		CqlCode l_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
		IEnumerable<Observation> n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
		IEnumerable<string> o_ = this.FirstPhysicalExamWithEncounterId(n_, "FirstO2Saturation");
		CqlValueSet p_ = this.Hematocrit_lab_test();
		IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(p_, null);
		IEnumerable<string> r_ = this.FirstLabTestWithEncounterId(q_, "FirstHematocrit");
		CqlValueSet s_ = this.Platelet_count_lab_test();
		IEnumerable<Observation> t_ = context.Operators.RetrieveByValueSet<Observation>(s_, null);
		IEnumerable<string> u_ = this.FirstLabTestWithEncounterId(t_, "FirstPlateletCount");
		CqlValueSet v_ = this.White_blood_cells_count_lab_test();
		IEnumerable<Observation> w_ = context.Operators.RetrieveByValueSet<Observation>(v_, null);
		IEnumerable<string> x_ = this.FirstLabTestWithEncounterId(w_, "FirstWhiteBloodCell");
		CqlValueSet y_ = this.Sodium_lab_test();
		IEnumerable<Observation> z_ = context.Operators.RetrieveByValueSet<Observation>(y_, null);
		IEnumerable<string> aa_ = this.FirstLabTestWithEncounterId(z_, "FirstSodium");
		CqlValueSet ab_ = this.Bicarbonate_lab_test();
		IEnumerable<Observation> ac_ = context.Operators.RetrieveByValueSet<Observation>(ab_, null);
		IEnumerable<string> ad_ = this.FirstLabTestWithEncounterId(ac_, "FirstBicarbonate");
		CqlValueSet ae_ = this.Creatinine_lab_test();
		IEnumerable<Observation> af_ = context.Operators.RetrieveByValueSet<Observation>(ae_, null);
		IEnumerable<string> ag_ = this.FirstLabTestWithEncounterId(af_, "FirstCreatinine");
		IEnumerable<string>[] ah_ = new IEnumerable<string>[]
		{
			d_,
			h_,
			k_,
			o_,
			r_,
			u_,
			x_,
			aa_,
			ad_,
			ag_,
		};
		IEnumerable<string> ai_ = context.Operators.Flatten<string>((ah_ as IEnumerable<IEnumerable<string>>));

		return ai_;
	}

    [CqlDeclaration("Results")]
	public IEnumerable<string> Results() => 
		__Results.Value;

    [CqlDeclaration("CalendarAgeInYearsAt")]
	public int? CalendarAgeInYearsAt(CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		CqlDate a_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
		CqlDate b_ = context.Operators.ConvertDateTimeToDate(AsOf);
		int? c_ = context.Operators.DurationBetween(a_, b_, "year");

		return c_;
	}

    [CqlDeclaration("ToDate")]
	public CqlDateTime ToDate(CqlDateTime Value)
	{
		int? a_ = context.Operators.DateTimeComponentFrom(Value, "year");
		int? b_ = context.Operators.DateTimeComponentFrom(Value, "month");
		int? c_ = context.Operators.DateTimeComponentFrom(Value, "day");
		decimal? d_ = context.Operators.TimezoneOffsetFrom(Value);
		CqlDateTime e_ = context.Operators.DateTime(a_, b_, c_, 0, 0, 0, 0, d_);

		return e_;
	}

    [CqlDeclaration("LengthOfStay")]
	public int? LengthOfStay(CqlInterval<CqlDateTime> Stay)
	{
		CqlDateTime a_ = context.Operators.Start(Stay);
		CqlDateTime b_ = context.Operators.End(Stay);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		Encounter[] a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit();
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.ToInterval(LastED?.Period);
				CqlDateTime ac_ = context.Operators.End(ab_);
				CqlValueSet ad_ = this.Observation_Services();
				IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? af_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					CqlDateTime br_ = context.Operators.End(bq_);
					CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					CqlDateTime bt_ = context.Operators.Start(bs_);
					CqlQuantity bu_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime bv_ = context.Operators.Subtract(bt_, bu_);
					CqlDateTime bx_ = context.Operators.Start(bs_);
					CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bv_, bx_, true, true);
					bool? bz_ = context.Operators.In<CqlDateTime>(br_, by_, null);
					CqlDateTime cb_ = context.Operators.Start(bs_);
					bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
					bool? cd_ = context.Operators.And(bz_, cc_);

					return cd_;
				};
				IEnumerable<Encounter> ag_ = context.Operators.Where<Encounter>(ae_, af_);
				object ah_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					CqlDateTime cf_ = context.Operators.End(ce_);

					return cf_;
				};
				IEnumerable<Encounter> ai_ = context.Operators.SortBy<Encounter>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter aj_ = context.Operators.Last<Encounter>(ai_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_0_001.ToInterval(aj_?.Period);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlQuantity ao_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ap_ = context.Operators.Subtract((al_ ?? an_), ao_);
				IEnumerable<Encounter> ar_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? as_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					CqlDateTime ch_ = context.Operators.End(cg_);
					CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					CqlDateTime cj_ = context.Operators.Start(ci_);
					CqlQuantity ck_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime cl_ = context.Operators.Subtract(cj_, ck_);
					CqlDateTime cn_ = context.Operators.Start(ci_);
					CqlInterval<CqlDateTime> co_ = context.Operators.Interval(cl_, cn_, true, true);
					bool? cp_ = context.Operators.In<CqlDateTime>(ch_, co_, null);
					CqlDateTime cr_ = context.Operators.Start(ci_);
					bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
					bool? ct_ = context.Operators.And(cp_, cs_);

					return ct_;
				};
				IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);
				object au_(Encounter @this)
				{
					CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					CqlDateTime cv_ = context.Operators.End(cu_);

					return cv_;
				};
				IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter aw_ = context.Operators.Last<Encounter>(av_);
				CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_0_001.ToInterval(aw_?.Period);
				CqlDateTime ay_ = context.Operators.Start(ax_);
				CqlDateTime ba_ = context.Operators.Start(am_);
				CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(ap_, (ay_ ?? ba_), true, true);
				bool? bc_ = context.Operators.In<CqlDateTime>(ac_, bb_, null);
				IEnumerable<Encounter> be_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? bf_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					CqlDateTime cx_ = context.Operators.End(cw_);
					CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					CqlDateTime cz_ = context.Operators.Start(cy_);
					CqlQuantity da_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime db_ = context.Operators.Subtract(cz_, da_);
					CqlDateTime dd_ = context.Operators.Start(cy_);
					CqlInterval<CqlDateTime> de_ = context.Operators.Interval(db_, dd_, true, true);
					bool? df_ = context.Operators.In<CqlDateTime>(cx_, de_, null);
					CqlDateTime dh_ = context.Operators.Start(cy_);
					bool? di_ = context.Operators.Not((bool?)(dh_ is null));
					bool? dj_ = context.Operators.And(df_, di_);

					return dj_;
				};
				IEnumerable<Encounter> bg_ = context.Operators.Where<Encounter>(be_, bf_);
				object bh_(Encounter @this)
				{
					CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					CqlDateTime dl_ = context.Operators.End(dk_);

					return dl_;
				};
				IEnumerable<Encounter> bi_ = context.Operators.SortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bj_ = context.Operators.Last<Encounter>(bi_);
				CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_0_001.ToInterval(bj_?.Period);
				CqlDateTime bl_ = context.Operators.Start(bk_);
				CqlDateTime bn_ = context.Operators.Start(am_);
				bool? bo_ = context.Operators.Not((bool?)((bl_ ?? bn_) is null));
				bool? bp_ = context.Operators.And(bc_, bo_);

				return bp_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
				CqlDateTime dn_ = context.Operators.End(dm_);

				return dn_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(k_?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlValueSet n_ = this.Observation_Services();
			IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
				CqlDateTime dp_ = context.Operators.End(do_);
				CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
				CqlDateTime dr_ = context.Operators.Start(dq_);
				CqlQuantity ds_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime dt_ = context.Operators.Subtract(dr_, ds_);
				CqlDateTime dv_ = context.Operators.Start(dq_);
				CqlInterval<CqlDateTime> dw_ = context.Operators.Interval(dt_, dv_, true, true);
				bool? dx_ = context.Operators.In<CqlDateTime>(dp_, dw_, null);
				CqlDateTime dz_ = context.Operators.Start(dq_);
				bool? ea_ = context.Operators.Not((bool?)(dz_ is null));
				bool? eb_ = context.Operators.And(dx_, ea_);

				return eb_;
			};
			IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
				CqlDateTime ed_ = context.Operators.End(ec_);

				return ed_;
			};
			IEnumerable<Encounter> s_ = context.Operators.SortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter t_ = context.Operators.Last<Encounter>(s_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_0_001.ToInterval(t_?.Period);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlDateTime z_ = context.Operators.End(w_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
	public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = this.HospitalizationWithObservation(Encounter);
		int? b_ = this.LengthInDays(a_);

		return b_;
	}

}
