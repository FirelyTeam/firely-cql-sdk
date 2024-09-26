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
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", default);

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
	public CqlValueSet Bicarbonate_lab_test() => 
		__Bicarbonate_lab_test.Value;

	private CqlValueSet Body_temperature_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", default);

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
	public CqlValueSet Body_temperature() => 
		__Body_temperature.Value;

	private CqlValueSet Creatinine_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", default);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
	public CqlValueSet Creatinine_lab_test() => 
		__Creatinine_lab_test.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Ethnicity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity.Value;

	private CqlValueSet Hematocrit_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", default);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public CqlValueSet Hematocrit_lab_test() => 
		__Hematocrit_lab_test.Value;

	private CqlValueSet Medicare_payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", default);

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
	public CqlValueSet Medicare_payer() => 
		__Medicare_payer.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex.Value;

	private CqlValueSet Payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer() => 
		__Payer.Value;

	private CqlValueSet Platelet_count_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", default);

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
	public CqlValueSet Platelet_count_lab_test() => 
		__Platelet_count_lab_test.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

	private CqlValueSet Sodium_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", default);

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
	public CqlValueSet Sodium_lab_test() => 
		__Sodium_lab_test.Value;

	private CqlValueSet White_blood_cells_count_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", default);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
	public CqlValueSet White_blood_cells_count_lab_test() => 
		__White_blood_cells_count_lab_test.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode Heart_rate_Value() => 
		new CqlCode("8867-4", "http://loinc.org", default, default);

    [CqlDeclaration("Heart rate")]
	public CqlCode Heart_rate() => 
		__Heart_rate.Value;

	private CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value() => 
		new CqlCode("59408-5", "http://loinc.org", default, default);

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
	public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry() => 
		__Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry.Value;

	private CqlCode Systolic_blood_pressure_Value() => 
		new CqlCode("8480-6", "http://loinc.org", default, default);

    [CqlDeclaration("Systolic blood pressure")]
	public CqlCode Systolic_blood_pressure() => 
		__Systolic_blood_pressure.Value;

	private CqlCode[] LOINC_2_69_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
			new CqlCode("8867-4", "http://loinc.org", default, default),
			new CqlCode("59408-5", "http://loinc.org", default, default),
			new CqlCode("8480-6", "http://loinc.org", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
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
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Medicare_payer();
		IEnumerable<Coverage> d_ = context.Operators.RetrieveByValueSet<Coverage>(c_, default);
		IEnumerable<ValueTuple<Encounter, Coverage>> e_ = context.Operators.CrossJoin<Encounter, Coverage>(b_, d_);
		(Encounter InpatientEncounter, Coverage Payer)? f_(ValueTuple<Encounter, Coverage> _valueTuple)
		{
			(Encounter InpatientEncounter, Coverage Payer)? l_ = (_valueTuple.Item1, _valueTuple.Item2);

			return l_;
		};
		IEnumerable<(Encounter InpatientEncounter, Coverage Payer)?> g_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (Encounter InpatientEncounter, Coverage Payer)?>(e_, f_);
		bool? h_((Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
		{
			Code<Encounter.EncounterStatus> m_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
			string n_ = FHIRHelpers_4_0_001.ToString(m_);
			bool? o_ = context.Operators.Equal(n_, "finished");
			CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
			int? q_ = this.LengthInDays(p_);
			bool? r_ = context.Operators.Less(q_, 365);
			bool? s_ = context.Operators.And(o_, r_);
			Period t_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			CqlDateTime v_ = context.Operators.End(u_);
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period();
			bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, "day");
			bool? y_ = context.Operators.And(s_, x_);
			Patient z_ = this.Patient();
			Date aa_ = z_?.BirthDateElement;
			string ab_ = aa_?.Value;
			CqlDate ac_ = context.Operators.ConvertStringToDate(ab_);
			CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_0_001.ToInterval(t_);
			CqlDateTime af_ = context.Operators.Start(ae_);
			CqlDate ag_ = context.Operators.DateFrom(af_);
			int? ah_ = context.Operators.CalculateAgeAt(ac_, ag_, "year");
			CqlInterval<int?> ai_ = context.Operators.Interval(65, 94, true, true);
			bool? aj_ = context.Operators.In<int?>(ah_, ai_, default);
			bool? ak_ = context.Operators.And(y_, aj_);

			return ak_;
		};
		IEnumerable<(Encounter InpatientEncounter, Coverage Payer)?> i_ = context.Operators.Where<(Encounter InpatientEncounter, Coverage Payer)?>(g_, h_);
		Encounter j_((Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) => 
			tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
		IEnumerable<Encounter> k_ = context.Operators.Select<(Encounter InpatientEncounter, Coverage Payer)?, Encounter>(i_, j_);

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
			string d_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
			string e_ = context.Operators.Concatenate(d_ ?? "", ",");
			Id f_ = Encounter?.IdElement;
			string g_ = FHIRHelpers_4_0_001.ToString(f_);
			string h_ = context.Operators.Concatenate(e_ ?? "", g_ ?? "");
			string i_ = context.Operators.Concatenate(h_ ?? "", " , ");
			bool? j_(Observation Exam)
			{
				DataType ae_ = Exam?.Effective;
				CqlInterval<CqlDateTime> af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ae_);
				CqlDateTime ag_ = context.Operators.Start(af_);
				bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
				CqlInterval<CqlDateTime> aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ae_);
				CqlDateTime ak_ = context.Operators.Start(aj_);
				Period al_ = Encounter?.Period;
				CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.ToInterval(al_);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlQuantity ao_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
				CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.ToInterval(al_);
				CqlDateTime as_ = context.Operators.Start(ar_);
				CqlQuantity at_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime au_ = context.Operators.Add(as_, at_);
				CqlInterval<CqlDateTime> av_ = context.Operators.Interval(ap_, au_, true, true);
				bool? aw_ = context.Operators.In<CqlDateTime>(ak_, av_, default);
				bool? ax_ = context.Operators.And(ah_, aw_);
				Code<ObservationStatus> ay_ = Exam?.StatusElement;
				string az_ = FHIRHelpers_4_0_001.ToString(ay_);
				string[] ba_ = [
					"final",
					"amended",
					"preliminary",
				];
				bool? bb_ = context.Operators.In<string>(az_, ba_ as IEnumerable<string>);
				bool? bc_ = context.Operators.And(ax_, bb_);
				DataType bd_ = Exam?.Value;
				bool? be_ = context.Operators.Not((bool?)(bd_ is null));
				bool? bf_ = context.Operators.And(bc_, be_);

				return bf_;
			};
			IEnumerable<Observation> k_ = context.Operators.Where<Observation>(ExamList, j_);
			object l_(Observation @this)
			{
				DataType bg_ = @this?.Effective;
				CqlInterval<CqlDateTime> bh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bg_);
				CqlDateTime bi_ = context.Operators.Start(bh_);

				return bi_;
			};
			IEnumerable<Observation> m_ = context.Operators.SortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
			Observation n_ = context.Operators.First<Observation>(m_);
			DataType o_ = n_?.Value;
			Quantity p_ = o_ switch { null => null , Quantity a => a/* , CodeableConcept => ???, FhirString => ???, FhirBoolean => ???, Integer => ???, Range => ???, Ratio => ???, SampledData => ???, Time => ???, FhirDateTime => ???, Period => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity q_ = FHIRHelpers_4_0_001.ToQuantity(p_);
			string r_ = context.Operators.ConvertQuantityToString(q_);
			string s_ = context.Operators.Concatenate(i_ ?? "", r_ ?? "");
			string t_ = context.Operators.Concatenate(s_ ?? "", ",");
			bool? u_(Observation Exam)
			{
				DataType bj_ = Exam?.Effective;
				CqlInterval<CqlDateTime> bk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bj_);
				CqlDateTime bl_ = context.Operators.Start(bk_);
				bool? bm_ = context.Operators.Not((bool?)(bl_ is null));
				CqlInterval<CqlDateTime> bo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bj_);
				CqlDateTime bp_ = context.Operators.Start(bo_);
				Period bq_ = Encounter?.Period;
				CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_0_001.ToInterval(bq_);
				CqlDateTime bs_ = context.Operators.Start(br_);
				CqlQuantity bt_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bu_ = context.Operators.Subtract(bs_, bt_);
				CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_0_001.ToInterval(bq_);
				CqlDateTime bx_ = context.Operators.Start(bw_);
				CqlQuantity by_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime bz_ = context.Operators.Add(bx_, by_);
				CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bu_, bz_, true, true);
				bool? cb_ = context.Operators.In<CqlDateTime>(bp_, ca_, default);
				bool? cc_ = context.Operators.And(bm_, cb_);
				Code<ObservationStatus> cd_ = Exam?.StatusElement;
				string ce_ = FHIRHelpers_4_0_001.ToString(cd_);
				string[] cf_ = [
					"final",
					"amended",
					"preliminary",
				];
				bool? cg_ = context.Operators.In<string>(ce_, cf_ as IEnumerable<string>);
				bool? ch_ = context.Operators.And(cc_, cg_);
				DataType ci_ = Exam?.Value;
				bool? cj_ = context.Operators.Not((bool?)(ci_ is null));
				bool? ck_ = context.Operators.And(ch_, cj_);

				return ck_;
			};
			IEnumerable<Observation> v_ = context.Operators.Where<Observation>(ExamList, u_);
			object w_(Observation @this)
			{
				DataType cl_ = @this?.Effective;
				CqlInterval<CqlDateTime> cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cl_);
				CqlDateTime cn_ = context.Operators.Start(cm_);

				return cn_;
			};
			IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			Observation y_ = context.Operators.First<Observation>(x_);
			DataType z_ = y_?.Effective;
			CqlInterval<CqlDateTime> aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
			CqlDateTime ab_ = context.Operators.Start(aa_);
			string ac_ = context.Operators.ConvertDateTimeToString(ab_);
			string ad_ = context.Operators.Concatenate(t_ ?? "", ac_ ?? "");

			return ad_;
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
			string d_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
			string e_ = context.Operators.Concatenate(d_ ?? "", ",");
			Id f_ = Encounter?.IdElement;
			string g_ = FHIRHelpers_4_0_001.ToString(f_);
			string h_ = context.Operators.Concatenate(e_ ?? "", g_ ?? "");
			string i_ = context.Operators.Concatenate(h_ ?? "", ",");
			bool? j_(Observation Lab)
			{
				Instant ad_ = Lab?.IssuedElement;
				bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
				CqlDateTime ag_ = FHIRHelpers_4_0_001.ToDateTime(ad_);
				Period ah_ = Encounter?.Period;
				CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_0_001.ToInterval(ah_);
				CqlDateTime aj_ = context.Operators.Start(ai_);
				CqlQuantity ak_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime al_ = context.Operators.Subtract(aj_, ak_);
				CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_0_001.ToInterval(ah_);
				CqlDateTime ao_ = context.Operators.Start(an_);
				CqlDateTime aq_ = context.Operators.Add(ao_, ak_);
				CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(al_, aq_, true, true);
				bool? as_ = context.Operators.In<CqlDateTime>(ag_, ar_, default);
				bool? at_ = context.Operators.And(ae_, as_);
				Code<ObservationStatus> au_ = Lab?.StatusElement;
				string av_ = FHIRHelpers_4_0_001.ToString(au_);
				string[] aw_ = [
					"final",
					"amended",
					"preliminary",
				];
				bool? ax_ = context.Operators.In<string>(av_, aw_ as IEnumerable<string>);
				bool? ay_ = context.Operators.And(at_, ax_);
				DataType az_ = Lab?.Value;
				bool? ba_ = context.Operators.Not((bool?)(az_ is null));
				bool? bb_ = context.Operators.And(ay_, ba_);

				return bb_;
			};
			IEnumerable<Observation> k_ = context.Operators.Where<Observation>(LabList, j_);
			object l_(Observation @this)
			{
				Instant bc_ = @this?.IssuedElement;

				return bc_;
			};
			IEnumerable<Observation> m_ = context.Operators.SortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
			Observation n_ = context.Operators.First<Observation>(m_);
			DataType o_ = n_?.Value;
			Quantity p_ = o_ switch { null => null , Quantity a => a/* , CodeableConcept => ???, FhirString => ???, FhirBoolean => ???, Integer => ???, Range => ???, Ratio => ???, SampledData => ???, Time => ???, FhirDateTime => ???, Period => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity q_ = FHIRHelpers_4_0_001.ToQuantity(p_);
			string r_ = context.Operators.ConvertQuantityToString(q_);
			string s_ = context.Operators.Concatenate(i_ ?? "", r_ ?? "");
			string t_ = context.Operators.Concatenate(s_ ?? "", ",");
			bool? u_(Observation Lab)
			{
				Instant bd_ = Lab?.IssuedElement;
				bool? be_ = context.Operators.Not((bool?)(bd_ is null));
				CqlDateTime bg_ = FHIRHelpers_4_0_001.ToDateTime(bd_);
				Period bh_ = Encounter?.Period;
				CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_0_001.ToInterval(bh_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
				CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_0_001.ToInterval(bh_);
				CqlDateTime bo_ = context.Operators.Start(bn_);
				CqlDateTime bq_ = context.Operators.Add(bo_, bk_);
				CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bl_, bq_, true, true);
				bool? bs_ = context.Operators.In<CqlDateTime>(bg_, br_, default);
				bool? bt_ = context.Operators.And(be_, bs_);
				Code<ObservationStatus> bu_ = Lab?.StatusElement;
				string bv_ = FHIRHelpers_4_0_001.ToString(bu_);
				string[] bw_ = [
					"final",
					"amended",
					"preliminary",
				];
				bool? bx_ = context.Operators.In<string>(bv_, bw_ as IEnumerable<string>);
				bool? by_ = context.Operators.And(bt_, bx_);
				DataType bz_ = Lab?.Value;
				bool? ca_ = context.Operators.Not((bool?)(bz_ is null));
				bool? cb_ = context.Operators.And(by_, ca_);

				return cb_;
			};
			IEnumerable<Observation> v_ = context.Operators.Where<Observation>(LabList, u_);
			object w_(Observation @this)
			{
				Instant cc_ = @this?.IssuedElement;

				return cc_;
			};
			IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			Observation y_ = context.Operators.First<Observation>(x_);
			Instant z_ = y_?.IssuedElement;
			CqlDateTime aa_ = FHIRHelpers_4_0_001.ToDateTime(z_);
			string ab_ = context.Operators.ConvertDateTimeToString(aa_);
			string ac_ = context.Operators.Concatenate(t_ ?? "", ab_ ?? "");

			return ac_;
		};
		IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);

		return c_;
	}

	private IEnumerable<string> Results_Value()
	{
		CqlCode a_ = this.Heart_rate();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<string> d_ = this.FirstPhysicalExamWithEncounterId(c_, "FirstHeartRate");
		CqlCode e_ = this.Systolic_blood_pressure();
		IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
		IEnumerable<Observation> g_ = context.Operators.RetrieveByCodes<Observation>(f_, default);
		IEnumerable<string> h_ = this.FirstPhysicalExamWithEncounterId(g_, "FirstSystolicBP");
		CqlValueSet i_ = this.Body_temperature();
		IEnumerable<Observation> j_ = context.Operators.RetrieveByValueSet<Observation>(i_, default);
		IEnumerable<string> k_ = this.FirstPhysicalExamWithEncounterId(j_, "FirstTemperature");
		CqlCode l_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
		IEnumerable<Observation> n_ = context.Operators.RetrieveByCodes<Observation>(m_, default);
		IEnumerable<string> o_ = this.FirstPhysicalExamWithEncounterId(n_, "FirstO2Saturation");
		CqlValueSet p_ = this.Hematocrit_lab_test();
		IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(p_, default);
		IEnumerable<string> r_ = this.FirstLabTestWithEncounterId(q_, "FirstHematocrit");
		CqlValueSet s_ = this.Platelet_count_lab_test();
		IEnumerable<Observation> t_ = context.Operators.RetrieveByValueSet<Observation>(s_, default);
		IEnumerable<string> u_ = this.FirstLabTestWithEncounterId(t_, "FirstPlateletCount");
		CqlValueSet v_ = this.White_blood_cells_count_lab_test();
		IEnumerable<Observation> w_ = context.Operators.RetrieveByValueSet<Observation>(v_, default);
		IEnumerable<string> x_ = this.FirstLabTestWithEncounterId(w_, "FirstWhiteBloodCell");
		CqlValueSet y_ = this.Sodium_lab_test();
		IEnumerable<Observation> z_ = context.Operators.RetrieveByValueSet<Observation>(y_, default);
		IEnumerable<string> aa_ = this.FirstLabTestWithEncounterId(z_, "FirstSodium");
		CqlValueSet ab_ = this.Bicarbonate_lab_test();
		IEnumerable<Observation> ac_ = context.Operators.RetrieveByValueSet<Observation>(ab_, default);
		IEnumerable<string> ad_ = this.FirstLabTestWithEncounterId(ac_, "FirstBicarbonate");
		CqlValueSet ae_ = this.Creatinine_lab_test();
		IEnumerable<Observation> af_ = context.Operators.RetrieveByValueSet<Observation>(ae_, default);
		IEnumerable<string> ag_ = this.FirstLabTestWithEncounterId(af_, "FirstCreatinine");
		IEnumerable<string>[] ah_ = [
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
		];
		IEnumerable<string> ai_ = context.Operators.Flatten<string>(ah_ as IEnumerable<IEnumerable<string>>);

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
		Encounter[] a_ = [
			TheEncounter,
		];
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit();
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, default);
			bool? g_(Encounter LastED)
			{
				Period af_ = LastED?.Period;
				CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
				CqlDateTime ah_ = context.Operators.End(ag_);
				CqlValueSet ai_ = this.Observation_Services();
				IEnumerable<Encounter> aj_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? ak_(Encounter LastObs)
				{
					Period cb_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_0_001.ToInterval(cb_);
					CqlDateTime cd_ = context.Operators.End(cc_);
					Period ce_ = Visit?.Period;
					CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					CqlDateTime cg_ = context.Operators.Start(cf_);
					CqlQuantity ch_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ci_ = context.Operators.Subtract(cg_, ch_);
					CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					CqlDateTime cl_ = context.Operators.Start(ck_);
					CqlInterval<CqlDateTime> cm_ = context.Operators.Interval(ci_, cl_, true, true);
					bool? cn_ = context.Operators.In<CqlDateTime>(cd_, cm_, default);
					CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					CqlDateTime cq_ = context.Operators.Start(cp_);
					bool? cr_ = context.Operators.Not((bool?)(cq_ is null));
					bool? cs_ = context.Operators.And(cn_, cr_);

					return cs_;
				};
				IEnumerable<Encounter> al_ = context.Operators.Where<Encounter>(aj_, ak_);
				object am_(Encounter @this)
				{
					Period ct_ = @this?.Period;
					CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_0_001.ToInterval(ct_);
					CqlDateTime cv_ = context.Operators.End(cu_);

					return cv_;
				};
				IEnumerable<Encounter> an_ = context.Operators.SortBy<Encounter>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ao_ = context.Operators.Last<Encounter>(an_);
				Period ap_ = ao_?.Period;
				CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_0_001.ToInterval(ap_);
				CqlDateTime ar_ = context.Operators.Start(aq_);
				Period as_ = Visit?.Period;
				CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_0_001.ToInterval(as_);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlQuantity av_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime aw_ = context.Operators.Subtract(ar_ ?? au_, av_);
				IEnumerable<Encounter> ay_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? az_(Encounter LastObs)
				{
					Period cw_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_0_001.ToInterval(cw_);
					CqlDateTime cy_ = context.Operators.End(cx_);
					Period cz_ = Visit?.Period;
					CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					CqlDateTime db_ = context.Operators.Start(da_);
					CqlQuantity dc_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dd_ = context.Operators.Subtract(db_, dc_);
					CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					CqlDateTime dg_ = context.Operators.Start(df_);
					CqlInterval<CqlDateTime> dh_ = context.Operators.Interval(dd_, dg_, true, true);
					bool? di_ = context.Operators.In<CqlDateTime>(cy_, dh_, default);
					CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					CqlDateTime dl_ = context.Operators.Start(dk_);
					bool? dm_ = context.Operators.Not((bool?)(dl_ is null));
					bool? dn_ = context.Operators.And(di_, dm_);

					return dn_;
				};
				IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(ay_, az_);
				object bb_(Encounter @this)
				{
					Period do_ = @this?.Period;
					CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_0_001.ToInterval(do_);
					CqlDateTime dq_ = context.Operators.End(dp_);

					return dq_;
				};
				IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bd_ = context.Operators.Last<Encounter>(bc_);
				Period be_ = bd_?.Period;
				CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_0_001.ToInterval(be_);
				CqlDateTime bg_ = context.Operators.Start(bf_);
				CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_0_001.ToInterval(as_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(aw_, bg_ ?? bj_, true, true);
				bool? bl_ = context.Operators.In<CqlDateTime>(ah_, bk_, default);
				IEnumerable<Encounter> bn_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, default);
				bool? bo_(Encounter LastObs)
				{
					Period dr_ = LastObs?.Period;
					CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_0_001.ToInterval(dr_);
					CqlDateTime dt_ = context.Operators.End(ds_);
					Period du_ = Visit?.Period;
					CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_0_001.ToInterval(du_);
					CqlDateTime dw_ = context.Operators.Start(dv_);
					CqlQuantity dx_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dy_ = context.Operators.Subtract(dw_, dx_);
					CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_0_001.ToInterval(du_);
					CqlDateTime eb_ = context.Operators.Start(ea_);
					CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dy_, eb_, true, true);
					bool? ed_ = context.Operators.In<CqlDateTime>(dt_, ec_, default);
					CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_0_001.ToInterval(du_);
					CqlDateTime eg_ = context.Operators.Start(ef_);
					bool? eh_ = context.Operators.Not((bool?)(eg_ is null));
					bool? ei_ = context.Operators.And(ed_, eh_);

					return ei_;
				};
				IEnumerable<Encounter> bp_ = context.Operators.Where<Encounter>(bn_, bo_);
				object bq_(Encounter @this)
				{
					Period ej_ = @this?.Period;
					CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_0_001.ToInterval(ej_);
					CqlDateTime el_ = context.Operators.End(ek_);

					return el_;
				};
				IEnumerable<Encounter> br_ = context.Operators.SortBy<Encounter>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bs_ = context.Operators.Last<Encounter>(br_);
				Period bt_ = bs_?.Period;
				CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_0_001.ToInterval(bt_);
				CqlDateTime bv_ = context.Operators.Start(bu_);
				CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_0_001.ToInterval(as_);
				CqlDateTime by_ = context.Operators.Start(bx_);
				bool? bz_ = context.Operators.Not((bool?)((bv_ ?? by_) is null));
				bool? ca_ = context.Operators.And(bl_, bz_);

				return ca_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period em_ = @this?.Period;
				CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_0_001.ToInterval(em_);
				CqlDateTime eo_ = context.Operators.End(en_);

				return eo_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.ToInterval(l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Observation_Services();
			IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
			bool? q_(Encounter LastObs)
			{
				Period ep_ = LastObs?.Period;
				CqlInterval<CqlDateTime> eq_ = FHIRHelpers_4_0_001.ToInterval(ep_);
				CqlDateTime er_ = context.Operators.End(eq_);
				Period es_ = Visit?.Period;
				CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_0_001.ToInterval(es_);
				CqlDateTime eu_ = context.Operators.Start(et_);
				CqlQuantity ev_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ew_ = context.Operators.Subtract(eu_, ev_);
				CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_0_001.ToInterval(es_);
				CqlDateTime ez_ = context.Operators.Start(ey_);
				CqlInterval<CqlDateTime> fa_ = context.Operators.Interval(ew_, ez_, true, true);
				bool? fb_ = context.Operators.In<CqlDateTime>(er_, fa_, default);
				CqlInterval<CqlDateTime> fd_ = FHIRHelpers_4_0_001.ToInterval(es_);
				CqlDateTime fe_ = context.Operators.Start(fd_);
				bool? ff_ = context.Operators.Not((bool?)(fe_ is null));
				bool? fg_ = context.Operators.And(fb_, ff_);

				return fg_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period fh_ = @this?.Period;
				CqlInterval<CqlDateTime> fi_ = FHIRHelpers_4_0_001.ToInterval(fh_);
				CqlDateTime fj_ = context.Operators.End(fi_);

				return fj_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_0_001.ToInterval(v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			Period y_ = Visit?.Period;
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_0_001.ToInterval(y_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_0_001.ToInterval(y_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ad_, true, true);

			return ae_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
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
