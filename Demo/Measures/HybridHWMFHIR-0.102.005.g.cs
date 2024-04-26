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
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

    [CqlDeclaration("LengthInDays")]
	public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context.Operators.Start(Value);
		var b_ = context.Operators.End(Value);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

	private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Medicare_payer();
		var d_ = context.Operators.RetrieveByValueSet<Coverage>(c_, null);
		var e_ = context.Operators.CrossJoin<Encounter, Coverage>(b_, d_);
		Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV f_(ValueTuple<Encounter,Coverage> _valueTuple)
		{
			var l_ = new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = _valueTuple.Item1,
				Payer = _valueTuple.Item2,
			};

			return l_;
		};
		var g_ = context.Operators.SelectOrNull<ValueTuple<Encounter,Coverage>, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(e_, f_);
		bool? h_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv)
		{
			var m_ = context.Operators.Convert<string>(tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter?.StatusElement);
			var n_ = context.Operators.Equal(m_, "finished");
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter);
			var p_ = this.LengthInDays(o_);
			var q_ = context.Operators.Less(p_, (int?)365);
			var r_ = context.Operators.And(n_, q_);
			var s_ = FHIRHelpers_4_0_001.ToInterval(tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter?.Period);
			var t_ = context.Operators.End(s_);
			var u_ = this.Measurement_Period();
			var v_ = context.Operators.ElementInInterval<CqlDateTime>(t_, u_, "day");
			var w_ = context.Operators.And(r_, v_);
			var x_ = this.Patient();
			var y_ = context.Operators.Convert<CqlDateTime>(x_?.BirthDateElement?.Value);
			var aa_ = context.Operators.Start(s_);
			var ab_ = context.Operators.DateFrom(aa_);
			var ac_ = context.Operators.Convert<CqlDateTime>(ab_);
			var ad_ = context.Operators.CalculateAgeAt(y_, ac_, "year");
			var ae_ = context.Operators.Interval((int?)65, (int?)94, true, true);
			var af_ = context.Operators.ElementInInterval<int?>(ad_, ae_, null);
			var ag_ = context.Operators.And(w_, af_);

			return ag_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(g_, h_);
		Encounter j_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) => 
			tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Inpatient Encounters")]
	public IEnumerable<Encounter> Inpatient_Encounters() => 
		__Inpatient_Encounters.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Inpatient_Encounters();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

    [CqlDeclaration("FirstPhysicalExamWithEncounterId")]
	public IEnumerable<string> FirstPhysicalExamWithEncounterId(IEnumerable<Observation> ExamList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		string b_(Encounter Encounter)
		{
			var d_ = context.Operators.Concatenate("\r\n", (CCDE ?? ""));
			var e_ = context.Operators.Concatenate((d_ ?? ""), ",");
			var f_ = context.Operators.Convert<string>(Encounter?.IdElement);
			var g_ = context.Operators.Concatenate((e_ ?? ""), (f_ ?? ""));
			var h_ = context.Operators.Concatenate((g_ ?? ""), " , ");
			bool? i_(Observation Exam)
			{
				var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(Exam?.Effective);
				var ab_ = context.Operators.Start(aa_);
				var ac_ = context.Operators.Not((bool?)(ab_ is null));
				var ae_ = context.Operators.Start(aa_);
				var af_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
				var ag_ = context.Operators.Start(af_);
				var ah_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var ai_ = context.Operators.Subtract(ag_, ah_);
				var ak_ = context.Operators.Start(af_);
				var al_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var am_ = context.Operators.Add(ak_, al_);
				var an_ = context.Operators.Interval(ai_, am_, true, true);
				var ao_ = context.Operators.ElementInInterval<CqlDateTime>(ae_, an_, null);
				var ap_ = context.Operators.And(ac_, ao_);
				var aq_ = context.Operators.Convert<string>(Exam?.StatusElement);
				var ar_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var as_ = context.Operators.InList<string>(aq_, (ar_ as IEnumerable<string>));
				var at_ = context.Operators.And(ap_, as_);
				var au_ = context.Operators.Not((bool?)(Exam?.Value is null));
				var av_ = context.Operators.And(at_, au_);

				return av_;
			};
			var j_ = context.Operators.WhereOrNull<Observation>(ExamList, i_);
			object k_(Observation @this)
			{
				var aw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(@this?.Effective);
				var ax_ = context.Operators.Start(aw_);

				return ax_;
			};
			var l_ = context.Operators.ListSortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
			var m_ = context.Operators.FirstOfList<Observation>(l_);
			var n_ = FHIRHelpers_4_0_001.ToQuantity((m_?.Value as Quantity));
			var o_ = context.Operators.ConvertQuantityToString(n_);
			var p_ = context.Operators.Concatenate((h_ ?? ""), (o_ ?? ""));
			var q_ = context.Operators.Concatenate((p_ ?? ""), ",");
			bool? r_(Observation Exam)
			{
				var ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(Exam?.Effective);
				var az_ = context.Operators.Start(ay_);
				var ba_ = context.Operators.Not((bool?)(az_ is null));
				var bc_ = context.Operators.Start(ay_);
				var bd_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
				var be_ = context.Operators.Start(bd_);
				var bf_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var bg_ = context.Operators.Subtract(be_, bf_);
				var bi_ = context.Operators.Start(bd_);
				var bj_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var bk_ = context.Operators.Add(bi_, bj_);
				var bl_ = context.Operators.Interval(bg_, bk_, true, true);
				var bm_ = context.Operators.ElementInInterval<CqlDateTime>(bc_, bl_, null);
				var bn_ = context.Operators.And(ba_, bm_);
				var bo_ = context.Operators.Convert<string>(Exam?.StatusElement);
				var bp_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var bq_ = context.Operators.InList<string>(bo_, (bp_ as IEnumerable<string>));
				var br_ = context.Operators.And(bn_, bq_);
				var bs_ = context.Operators.Not((bool?)(Exam?.Value is null));
				var bt_ = context.Operators.And(br_, bs_);

				return bt_;
			};
			var s_ = context.Operators.WhereOrNull<Observation>(ExamList, r_);
			object t_(Observation @this)
			{
				var bu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(@this?.Effective);
				var bv_ = context.Operators.Start(bu_);

				return bv_;
			};
			var u_ = context.Operators.ListSortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			var v_ = context.Operators.FirstOfList<Observation>(u_);
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(v_?.Effective);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateTimeToString(x_);
			var z_ = context.Operators.Concatenate((q_ ?? ""), (y_ ?? ""));

			return z_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, string>(a_, b_);

		return c_;
	}

    [CqlDeclaration("FirstLabTestWithEncounterId")]
	public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		string b_(Encounter Encounter)
		{
			var d_ = context.Operators.Concatenate("\r\n", (CCDE ?? ""));
			var e_ = context.Operators.Concatenate((d_ ?? ""), ",");
			var f_ = context.Operators.Convert<string>(Encounter?.IdElement);
			var g_ = context.Operators.Concatenate((e_ ?? ""), (f_ ?? ""));
			var h_ = context.Operators.Concatenate((g_ ?? ""), ",");
			bool? i_(Observation Lab)
			{
				var z_ = context.Operators.Not((bool?)(Lab?.IssuedElement is null));
				var aa_ = FHIRHelpers_4_0_001.ToDateTime(Lab?.IssuedElement);
				var ab_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
				var ac_ = context.Operators.Start(ab_);
				var ad_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var ae_ = context.Operators.Subtract(ac_, ad_);
				var ag_ = context.Operators.Start(ab_);
				var ai_ = context.Operators.Add(ag_, ad_);
				var aj_ = context.Operators.Interval(ae_, ai_, true, true);
				var ak_ = context.Operators.ElementInInterval<CqlDateTime>(aa_, aj_, null);
				var al_ = context.Operators.And(z_, ak_);
				var am_ = context.Operators.Convert<string>(Lab?.StatusElement);
				var an_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var ao_ = context.Operators.InList<string>(am_, (an_ as IEnumerable<string>));
				var ap_ = context.Operators.And(al_, ao_);
				var aq_ = context.Operators.Not((bool?)(Lab?.Value is null));
				var ar_ = context.Operators.And(ap_, aq_);

				return ar_;
			};
			var j_ = context.Operators.WhereOrNull<Observation>(LabList, i_);
			object k_(Observation @this) => 
				@this?.IssuedElement;
			var l_ = context.Operators.ListSortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
			var m_ = context.Operators.FirstOfList<Observation>(l_);
			var n_ = FHIRHelpers_4_0_001.ToQuantity((m_?.Value as Quantity));
			var o_ = context.Operators.ConvertQuantityToString(n_);
			var p_ = context.Operators.Concatenate((h_ ?? ""), (o_ ?? ""));
			var q_ = context.Operators.Concatenate((p_ ?? ""), ",");
			bool? r_(Observation Lab)
			{
				var as_ = context.Operators.Not((bool?)(Lab?.IssuedElement is null));
				var at_ = FHIRHelpers_4_0_001.ToDateTime(Lab?.IssuedElement);
				var au_ = FHIRHelpers_4_0_001.ToInterval(Encounter?.Period);
				var av_ = context.Operators.Start(au_);
				var aw_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var ax_ = context.Operators.Subtract(av_, aw_);
				var az_ = context.Operators.Start(au_);
				var bb_ = context.Operators.Add(az_, aw_);
				var bc_ = context.Operators.Interval(ax_, bb_, true, true);
				var bd_ = context.Operators.ElementInInterval<CqlDateTime>(at_, bc_, null);
				var be_ = context.Operators.And(as_, bd_);
				var bf_ = context.Operators.Convert<string>(Lab?.StatusElement);
				var bg_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var bh_ = context.Operators.InList<string>(bf_, (bg_ as IEnumerable<string>));
				var bi_ = context.Operators.And(be_, bh_);
				var bj_ = context.Operators.Not((bool?)(Lab?.Value is null));
				var bk_ = context.Operators.And(bi_, bj_);

				return bk_;
			};
			var s_ = context.Operators.WhereOrNull<Observation>(LabList, r_);
			var u_ = context.Operators.ListSortBy<Observation>(s_, k_, System.ComponentModel.ListSortDirection.Ascending);
			var v_ = context.Operators.FirstOfList<Observation>(u_);
			var w_ = FHIRHelpers_4_0_001.ToDateTime(v_?.IssuedElement);
			var x_ = context.Operators.ConvertDateTimeToString(w_);
			var y_ = context.Operators.Concatenate((q_ ?? ""), (x_ ?? ""));

			return y_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, string>(a_, b_);

		return c_;
	}

	private IEnumerable<string> Results_Value()
	{
		var a_ = this.Heart_rate();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = this.FirstPhysicalExamWithEncounterId(c_, "FirstHeartRate");
		var e_ = this.Systolic_blood_pressure();
		var f_ = context.Operators.ToList<CqlCode>(e_);
		var g_ = context.Operators.RetrieveByCodes<Observation>(f_, null);
		var h_ = this.FirstPhysicalExamWithEncounterId(g_, "FirstSystolicBP");
		var i_ = this.Body_temperature();
		var j_ = context.Operators.RetrieveByValueSet<Observation>(i_, null);
		var k_ = this.FirstPhysicalExamWithEncounterId(j_, "FirstTemperature");
		var l_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		var m_ = context.Operators.ToList<CqlCode>(l_);
		var n_ = context.Operators.RetrieveByCodes<Observation>(m_, null);
		var o_ = this.FirstPhysicalExamWithEncounterId(n_, "FirstO2Saturation");
		var p_ = this.Hematocrit_lab_test();
		var q_ = context.Operators.RetrieveByValueSet<Observation>(p_, null);
		var r_ = this.FirstLabTestWithEncounterId(q_, "FirstHematocrit");
		var s_ = this.Platelet_count_lab_test();
		var t_ = context.Operators.RetrieveByValueSet<Observation>(s_, null);
		var u_ = this.FirstLabTestWithEncounterId(t_, "FirstPlateletCount");
		var v_ = this.White_blood_cells_count_lab_test();
		var w_ = context.Operators.RetrieveByValueSet<Observation>(v_, null);
		var x_ = this.FirstLabTestWithEncounterId(w_, "FirstWhiteBloodCell");
		var y_ = this.Sodium_lab_test();
		var z_ = context.Operators.RetrieveByValueSet<Observation>(y_, null);
		var aa_ = this.FirstLabTestWithEncounterId(z_, "FirstSodium");
		var ab_ = this.Bicarbonate_lab_test();
		var ac_ = context.Operators.RetrieveByValueSet<Observation>(ab_, null);
		var ad_ = this.FirstLabTestWithEncounterId(ac_, "FirstBicarbonate");
		var ae_ = this.Creatinine_lab_test();
		var af_ = context.Operators.RetrieveByValueSet<Observation>(ae_, null);
		var ag_ = this.FirstLabTestWithEncounterId(af_, "FirstCreatinine");
		var ah_ = new IEnumerable<string>[]
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
		var ai_ = context.Operators.FlattenList<string>((ah_ as IEnumerable<IEnumerable<string>>));

		return ai_;
	}

    [CqlDeclaration("Results")]
	public IEnumerable<string> Results() => 
		__Results.Value;

    [CqlDeclaration("CalendarAgeInYearsAt")]
	public int? CalendarAgeInYearsAt(CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		var a_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
		var b_ = context.Operators.Convert<CqlDateTime>(a_);
		var c_ = context.Operators.ConvertDateTimeToDate(AsOf);
		var d_ = context.Operators.Convert<CqlDateTime>(c_);
		var e_ = context.Operators.DurationBetween(b_, d_, "year");

		return e_;
	}

    [CqlDeclaration("ToDate")]
	public CqlDateTime ToDate(CqlDateTime Value)
	{
		var a_ = context.Operators.ComponentFrom(Value, "year");
		var b_ = context.Operators.ComponentFrom(Value, "month");
		var c_ = context.Operators.ComponentFrom(Value, "day");
		var d_ = context.Operators.TimezoneOffsetFrom(Value);
		var e_ = context.Operators.DateTime(a_, b_, c_, (int?)0, (int?)0, (int?)0, (int?)0, d_);

		return e_;
	}

    [CqlDeclaration("LengthOfStay")]
	public int? LengthOfStay(CqlInterval<CqlDateTime> Stay)
	{
		var a_ = context.Operators.Start(Stay);
		var b_ = context.Operators.End(Stay);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var e_ = this.Emergency_Department_Visit();
			var f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				var ab_ = FHIRHelpers_4_0_001.ToInterval(LastED?.Period);
				var ac_ = context.Operators.End(ab_);
				var ad_ = this.Observation_Services();
				var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? af_(Encounter LastObs)
				{
					var bq_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					var br_ = context.Operators.End(bq_);
					var bs_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					var bt_ = context.Operators.Start(bs_);
					var bu_ = context.Operators.Quantity((decimal?)1m, "hour");
					var bv_ = context.Operators.Subtract(bt_, bu_);
					var bx_ = context.Operators.Start(bs_);
					var by_ = context.Operators.Interval(bv_, bx_, true, true);
					var bz_ = context.Operators.ElementInInterval<CqlDateTime>(br_, by_, null);
					var cb_ = context.Operators.Start(bs_);
					var cc_ = context.Operators.Not((bool?)(cb_ is null));
					var cd_ = context.Operators.And(bz_, cc_);

					return cd_;
				};
				var ag_ = context.Operators.WhereOrNull<Encounter>(ae_, af_);
				object ah_(Encounter @this)
				{
					var ce_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					var cf_ = context.Operators.End(ce_);

					return cf_;
				};
				var ai_ = context.Operators.ListSortBy<Encounter>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
				var aj_ = context.Operators.LastOfList<Encounter>(ai_);
				var ak_ = FHIRHelpers_4_0_001.ToInterval(aj_?.Period);
				var al_ = context.Operators.Start(ak_);
				var am_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
				var an_ = context.Operators.Start(am_);
				var ao_ = context.Operators.Quantity((decimal?)1m, "hour");
				var ap_ = context.Operators.Subtract((al_ ?? an_), ao_);
				var ar_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? as_(Encounter LastObs)
				{
					var cg_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					var ch_ = context.Operators.End(cg_);
					var ci_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					var cj_ = context.Operators.Start(ci_);
					var ck_ = context.Operators.Quantity((decimal?)1m, "hour");
					var cl_ = context.Operators.Subtract(cj_, ck_);
					var cn_ = context.Operators.Start(ci_);
					var co_ = context.Operators.Interval(cl_, cn_, true, true);
					var cp_ = context.Operators.ElementInInterval<CqlDateTime>(ch_, co_, null);
					var cr_ = context.Operators.Start(ci_);
					var cs_ = context.Operators.Not((bool?)(cr_ is null));
					var ct_ = context.Operators.And(cp_, cs_);

					return ct_;
				};
				var at_ = context.Operators.WhereOrNull<Encounter>(ar_, as_);
				object au_(Encounter @this)
				{
					var cu_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					var cv_ = context.Operators.End(cu_);

					return cv_;
				};
				var av_ = context.Operators.ListSortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
				var aw_ = context.Operators.LastOfList<Encounter>(av_);
				var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_?.Period);
				var ay_ = context.Operators.Start(ax_);
				var ba_ = context.Operators.Start(am_);
				var bb_ = context.Operators.Interval(ap_, (ay_ ?? ba_), true, true);
				var bc_ = context.Operators.ElementInInterval<CqlDateTime>(ac_, bb_, null);
				var be_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? bf_(Encounter LastObs)
				{
					var cw_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					var cx_ = context.Operators.End(cw_);
					var cy_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					var cz_ = context.Operators.Start(cy_);
					var da_ = context.Operators.Quantity((decimal?)1m, "hour");
					var db_ = context.Operators.Subtract(cz_, da_);
					var dd_ = context.Operators.Start(cy_);
					var de_ = context.Operators.Interval(db_, dd_, true, true);
					var df_ = context.Operators.ElementInInterval<CqlDateTime>(cx_, de_, null);
					var dh_ = context.Operators.Start(cy_);
					var di_ = context.Operators.Not((bool?)(dh_ is null));
					var dj_ = context.Operators.And(df_, di_);

					return dj_;
				};
				var bg_ = context.Operators.WhereOrNull<Encounter>(be_, bf_);
				object bh_(Encounter @this)
				{
					var dk_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					var dl_ = context.Operators.End(dk_);

					return dl_;
				};
				var bi_ = context.Operators.ListSortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
				var bj_ = context.Operators.LastOfList<Encounter>(bi_);
				var bk_ = FHIRHelpers_4_0_001.ToInterval(bj_?.Period);
				var bl_ = context.Operators.Start(bk_);
				var bn_ = context.Operators.Start(am_);
				var bo_ = context.Operators.Not((bool?)((bl_ ?? bn_) is null));
				var bp_ = context.Operators.And(bc_, bo_);

				return bp_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var dm_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
				var dn_ = context.Operators.End(dm_);

				return dn_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = FHIRHelpers_4_0_001.ToInterval(k_?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = this.Observation_Services();
			var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				var do_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
				var dp_ = context.Operators.End(do_);
				var dq_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
				var dr_ = context.Operators.Start(dq_);
				var ds_ = context.Operators.Quantity((decimal?)1m, "hour");
				var dt_ = context.Operators.Subtract(dr_, ds_);
				var dv_ = context.Operators.Start(dq_);
				var dw_ = context.Operators.Interval(dt_, dv_, true, true);
				var dx_ = context.Operators.ElementInInterval<CqlDateTime>(dp_, dw_, null);
				var dz_ = context.Operators.Start(dq_);
				var ea_ = context.Operators.Not((bool?)(dz_ is null));
				var eb_ = context.Operators.And(dx_, ea_);

				return eb_;
			};
			var q_ = context.Operators.WhereOrNull<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				var ec_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
				var ed_ = context.Operators.End(ec_);

				return ed_;
			};
			var s_ = context.Operators.ListSortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.LastOfList<Encounter>(s_);
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_?.Period);
			var v_ = context.Operators.Start(u_);
			var w_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
			var x_ = context.Operators.Start(w_);
			var z_ = context.Operators.End(w_);
			var aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
	public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
	{
		var a_ = this.HospitalizationWithObservation(Encounter);
		var b_ = this.LengthInDays(a_);

		return b_;
	}

}
