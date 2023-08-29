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
    public CqlValueSet Bicarbonate_lab_test() => __Bicarbonate_lab_test.Value;

    private CqlValueSet Body_temperature_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
    public CqlValueSet Body_temperature() => __Body_temperature.Value;

    private CqlValueSet Creatinine_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
    public CqlValueSet Creatinine_lab_test() => __Creatinine_lab_test.Value;

    private CqlValueSet Emergency_Department_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Ethnicity_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity() => __Ethnicity.Value;

    private CqlValueSet Hematocrit_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
    public CqlValueSet Hematocrit_lab_test() => __Hematocrit_lab_test.Value;

    private CqlValueSet Medicare_payer_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
    public CqlValueSet Medicare_payer() => __Medicare_payer.Value;

    private CqlValueSet Observation_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet ONC_Administrative_Sex_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex() => __ONC_Administrative_Sex.Value;

    private CqlValueSet Payer_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer() => __Payer.Value;

    private CqlValueSet Platelet_count_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
    public CqlValueSet Platelet_count_lab_test() => __Platelet_count_lab_test.Value;

    private CqlValueSet Race_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race() => __Race.Value;

    private CqlValueSet Sodium_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
    public CqlValueSet Sodium_lab_test() => __Sodium_lab_test.Value;

    private CqlValueSet White_blood_cells_count_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
    public CqlValueSet White_blood_cells_count_lab_test() => __White_blood_cells_count_lab_test.Value;

    private CqlCode Birth_date_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode Heart_rate_Value()
	{
		var a_ = new CqlCode("8867-4", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Heart rate")]
    public CqlCode Heart_rate() => __Heart_rate.Value;

    private CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value()
	{
		var a_ = new CqlCode("59408-5", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry() => __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry.Value;

    private CqlCode Systolic_blood_pressure_Value()
	{
		var a_ = new CqlCode("8480-6", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Systolic blood pressure")]
    public CqlCode Systolic_blood_pressure() => __Systolic_blood_pressure.Value;

    private CqlCode[] LOINC_2_69_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode("8867-4", "http://loinc.org", null, null);
		var c_ = new CqlCode("59408-5", "http://loinc.org", null, null);
		var d_ = new CqlCode("8480-6", "http://loinc.org", null, null);
		var e_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
		};

		return e_;
	}

    [CqlDeclaration("LOINC:2.69")]
    public CqlCode[] LOINC_2_69() => __LOINC_2_69.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var b_ = a_.ConvertIntegerToDecimal(default);
		var d_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, b_);
		var f_ = a_.ConvertIntegerToDecimal(default);
		var h_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, f_);
		var j_ = a_.Interval(d_, h_, true, false);
		var k_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    [CqlDeclaration("LengthInDays")]
    public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context.Operators;
		var b_ = a_.Start(Value);
		var d_ = a_.End(Value);
		var f_ = a_.DifferenceBetween(b_, d_, "day");

		return f_;
	}


    private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Coverage> d_(Encounter _InpatientEncounter)
		{
			var n_ = this.Medicare_payer();
			var o_ = context.DataRetriever;
			var p_ = o_.RetrieveByValueSet<Coverage>(n_, null);

			return p_;
		};
		Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV e_(Encounter _InpatientEncounter, Coverage _Payer)
		{
			var q_ = new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = _InpatientEncounter,
				Payer = _Payer,
			};

			return q_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(c_, d_, e_);
		bool? h_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv)
		{
			var r_ = tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;
			var s_ = r_?.StatusElement;
			var t_ = new CallStackEntry("ToString", null, null);
			var u_ = context.Deeper(t_);
			var v_ = u_.Operators;
			var w_ = v_.TypeConverter;
			var x_ = w_.Convert<string>(s_);
			var y_ = context.Operators;
			var z_ = y_.Equal(x_, "finished");
			var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(r_);
			var ac_ = this.LengthInDays(ab_);
			var ae_ = y_.Less(ac_, (int?)365);
			var ag_ = y_.And(z_, ae_);
			var ai_ = r_?.Period;
			var aj_ = FHIRHelpers_4_0_001.ToInterval(ai_);
			var al_ = y_.End(aj_);
			var am_ = this.Measurement_Period();
			var ao_ = y_.ElementInInterval<CqlDateTime>(al_, am_, "day");
			var aq_ = y_.And(ag_, ao_);
			var ar_ = this.Patient();
			var as_ = ar_?.BirthDateElement;
			var at_ = as_?.Value;
			var av_ = y_.TypeConverter;
			var aw_ = av_.Convert<CqlDate>(at_);
			var ay_ = r_?.Period;
			var az_ = FHIRHelpers_4_0_001.ToInterval(ay_);
			var bb_ = y_.Start(az_);
			var bd_ = y_.DateFrom(bb_);
			var bf_ = y_.CalculateAgeAt(aw_, bd_, "year");
			var bh_ = y_.Interval((int?)65, (int?)94, true, true);
			var bj_ = y_.ElementInInterval<int?>(bf_, bh_, null);
			var bl_ = y_.And(aq_, bj_);

			return bl_;
		};
		var j_ = f_.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(g_, h_);
		Encounter k_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv)
		{
			var bm_ = tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;

			return bm_;
		};
		var m_ = f_.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(j_, k_);

		return m_;
	}

    [CqlDeclaration("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters() => __Inpatient_Encounters.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Inpatient_Encounters();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    [CqlDeclaration("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(IEnumerable<Observation> ExamList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		string b_(Encounter Encounter)
		{
			var e_ = ("\r\n" ?? "");
			var f_ = (CCDE ?? "");
			var g_ = context.Operators;
			var h_ = g_.Concatenate(e_, f_);
			var i_ = (h_ ?? "");
			var j_ = ("," ?? "");
			var l_ = g_.Concatenate(i_, j_);
			var m_ = (l_ ?? "");
			var n_ = Encounter?.IdElement;
			var o_ = new CallStackEntry("ToString", null, null);
			var p_ = context.Deeper(o_);
			var q_ = p_.Operators;
			var r_ = q_.TypeConverter;
			var s_ = r_.Convert<string>(n_);
			var t_ = (s_ ?? "");
			var v_ = g_.Concatenate(m_, t_);
			var w_ = (v_ ?? "");
			var x_ = (" , " ?? "");
			var z_ = g_.Concatenate(w_, x_);
			var aa_ = (z_ ?? "");
			bool? ab_(Observation Exam)
			{
				var bm_ = Exam?.Effective;
				var bn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bm_);
				var bo_ = context.Operators;
				var bp_ = bo_.Start(bn_);
				var br_ = bo_.Not((bool?)(bp_ is null));
				var bt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bm_);
				var bv_ = bo_.Start(bt_);
				var bw_ = Encounter?.Period;
				var bx_ = FHIRHelpers_4_0_001.ToInterval(bw_);
				var bz_ = bo_.Start(bx_);
				var cb_ = bo_.Quantity(1440m, "minutes");
				var cd_ = bo_.Subtract(bz_, cb_);
				var cf_ = FHIRHelpers_4_0_001.ToInterval(bw_);
				var ch_ = bo_.Start(cf_);
				var cj_ = bo_.Quantity(120m, "minutes");
				var cl_ = bo_.Add(ch_, cj_);
				var cn_ = bo_.Interval(cd_, cl_, true, true);
				var cp_ = bo_.ElementInInterval<CqlDateTime>(bv_, cn_, null);
				var cr_ = bo_.And(br_, cp_);
				var cs_ = Exam?.StatusElement;
				var ct_ = new CallStackEntry("ToString", null, null);
				var cu_ = context.Deeper(ct_);
				var cv_ = cu_.Operators;
				var cw_ = cv_.TypeConverter;
				var cx_ = cw_.Convert<string>(cs_);
				var cy_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var da_ = bo_.InList<string>(cx_, (cy_ as IEnumerable<string>));
				var dc_ = bo_.And(cr_, da_);
				var dd_ = Exam?.Value;
				var df_ = bo_.Not((bool?)(dd_ is null));
				var dh_ = bo_.And(dc_, df_);

				return dh_;
			};
			var ad_ = g_.WhereOrNull<Observation>(ExamList, ab_);
			object ae_(Observation @this)
			{
				var di_ = @this?.Effective;
				var dj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(di_);
				var dk_ = context.Operators;
				var dl_ = dk_.Start(dj_);

				return dl_;
			};
			var ag_ = g_.ListSortBy<Observation>(ad_, ae_, System.ComponentModel.ListSortDirection.Ascending);
			var ai_ = g_.FirstOfList<Observation>(ag_);
			var aj_ = ai_?.Value;
			var ak_ = FHIRHelpers_4_0_001.ToQuantity((aj_ as Quantity));
			var am_ = g_.ConvertQuantityToString(ak_);
			var an_ = (am_ ?? "");
			var ap_ = g_.Concatenate(aa_, an_);
			var aq_ = (ap_ ?? "");
			var at_ = g_.Concatenate(aq_, j_);
			var au_ = (at_ ?? "");
			bool? av_(Observation Exam)
			{
				var dm_ = Exam?.Effective;
				var dn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dm_);
				var do_ = context.Operators;
				var dp_ = do_.Start(dn_);
				var dr_ = do_.Not((bool?)(dp_ is null));
				var dt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dm_);
				var dv_ = do_.Start(dt_);
				var dw_ = Encounter?.Period;
				var dx_ = FHIRHelpers_4_0_001.ToInterval(dw_);
				var dz_ = do_.Start(dx_);
				var eb_ = do_.Quantity(1440m, "minutes");
				var ed_ = do_.Subtract(dz_, eb_);
				var ef_ = FHIRHelpers_4_0_001.ToInterval(dw_);
				var eh_ = do_.Start(ef_);
				var ej_ = do_.Quantity(120m, "minutes");
				var el_ = do_.Add(eh_, ej_);
				var en_ = do_.Interval(ed_, el_, true, true);
				var ep_ = do_.ElementInInterval<CqlDateTime>(dv_, en_, null);
				var er_ = do_.And(dr_, ep_);
				var es_ = Exam?.StatusElement;
				var et_ = new CallStackEntry("ToString", null, null);
				var eu_ = context.Deeper(et_);
				var ev_ = eu_.Operators;
				var ew_ = ev_.TypeConverter;
				var ex_ = ew_.Convert<string>(es_);
				var ey_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var fa_ = do_.InList<string>(ex_, (ey_ as IEnumerable<string>));
				var fc_ = do_.And(er_, fa_);
				var fd_ = Exam?.Value;
				var ff_ = do_.Not((bool?)(fd_ is null));
				var fh_ = do_.And(fc_, ff_);

				return fh_;
			};
			var ax_ = g_.WhereOrNull<Observation>(ExamList, av_);
			object ay_(Observation @this)
			{
				var fi_ = @this?.Effective;
				var fj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fi_);
				var fk_ = context.Operators;
				var fl_ = fk_.Start(fj_);

				return fl_;
			};
			var ba_ = g_.ListSortBy<Observation>(ax_, ay_, System.ComponentModel.ListSortDirection.Ascending);
			var bc_ = g_.FirstOfList<Observation>(ba_);
			var bd_ = bc_?.Effective;
			var be_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bd_);
			var bg_ = g_.Start(be_);
			var bi_ = g_.ConvertDateTimeToString(bg_);
			var bj_ = (bi_ ?? "");
			var bl_ = g_.Concatenate(au_, bj_);

			return bl_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter, string>(a_, b_);

		return d_;
	}


    [CqlDeclaration("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		string b_(Encounter Encounter)
		{
			var e_ = ("\r\n" ?? "");
			var f_ = (CCDE ?? "");
			var g_ = context.Operators;
			var h_ = g_.Concatenate(e_, f_);
			var i_ = (h_ ?? "");
			var j_ = ("," ?? "");
			var l_ = g_.Concatenate(i_, j_);
			var m_ = (l_ ?? "");
			var n_ = Encounter?.IdElement;
			var o_ = new CallStackEntry("ToString", null, null);
			var p_ = context.Deeper(o_);
			var q_ = p_.Operators;
			var r_ = q_.TypeConverter;
			var s_ = r_.Convert<string>(n_);
			var t_ = (s_ ?? "");
			var v_ = g_.Concatenate(m_, t_);
			var w_ = (v_ ?? "");
			var z_ = g_.Concatenate(w_, j_);
			var aa_ = (z_ ?? "");
			bool? ab_(Observation Lab)
			{
				var bk_ = Lab?.IssuedElement;
				var bl_ = context.Operators;
				var bm_ = bl_.Not((bool?)(bk_ is null));
				var bo_ = FHIRHelpers_4_0_001.ToDateTime(bk_);
				var bp_ = Encounter?.Period;
				var bq_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var bs_ = bl_.Start(bq_);
				var bu_ = bl_.Quantity(1440m, "minutes");
				var bw_ = bl_.Subtract(bs_, bu_);
				var by_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var ca_ = bl_.Start(by_);
				var cc_ = bl_.Quantity(1440m, "minutes");
				var ce_ = bl_.Add(ca_, cc_);
				var cg_ = bl_.Interval(bw_, ce_, true, true);
				var ci_ = bl_.ElementInInterval<CqlDateTime>(bo_, cg_, null);
				var ck_ = bl_.And(bm_, ci_);
				var cl_ = Lab?.StatusElement;
				var cm_ = new CallStackEntry("ToString", null, null);
				var cn_ = context.Deeper(cm_);
				var co_ = cn_.Operators;
				var cp_ = co_.TypeConverter;
				var cq_ = cp_.Convert<string>(cl_);
				var cr_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var ct_ = bl_.InList<string>(cq_, (cr_ as IEnumerable<string>));
				var cv_ = bl_.And(ck_, ct_);
				var cw_ = Lab?.Value;
				var cy_ = bl_.Not((bool?)(cw_ is null));
				var da_ = bl_.And(cv_, cy_);

				return da_;
			};
			var ad_ = g_.WhereOrNull<Observation>(LabList, ab_);
			object ae_(Observation @this)
			{
				var db_ = @this?.IssuedElement;

				return db_;
			};
			var ag_ = g_.ListSortBy<Observation>(ad_, ae_, System.ComponentModel.ListSortDirection.Ascending);
			var ai_ = g_.FirstOfList<Observation>(ag_);
			var aj_ = ai_?.Value;
			var ak_ = FHIRHelpers_4_0_001.ToQuantity((aj_ as Quantity));
			var am_ = g_.ConvertQuantityToString(ak_);
			var an_ = (am_ ?? "");
			var ap_ = g_.Concatenate(aa_, an_);
			var aq_ = (ap_ ?? "");
			var at_ = g_.Concatenate(aq_, j_);
			var au_ = (at_ ?? "");
			bool? av_(Observation Lab)
			{
				var dc_ = Lab?.IssuedElement;
				var dd_ = context.Operators;
				var de_ = dd_.Not((bool?)(dc_ is null));
				var dg_ = FHIRHelpers_4_0_001.ToDateTime(dc_);
				var dh_ = Encounter?.Period;
				var di_ = FHIRHelpers_4_0_001.ToInterval(dh_);
				var dk_ = dd_.Start(di_);
				var dm_ = dd_.Quantity(1440m, "minutes");
				var do_ = dd_.Subtract(dk_, dm_);
				var dq_ = FHIRHelpers_4_0_001.ToInterval(dh_);
				var ds_ = dd_.Start(dq_);
				var du_ = dd_.Quantity(1440m, "minutes");
				var dw_ = dd_.Add(ds_, du_);
				var dy_ = dd_.Interval(do_, dw_, true, true);
				var ea_ = dd_.ElementInInterval<CqlDateTime>(dg_, dy_, null);
				var ec_ = dd_.And(de_, ea_);
				var ed_ = Lab?.StatusElement;
				var ee_ = new CallStackEntry("ToString", null, null);
				var ef_ = context.Deeper(ee_);
				var eg_ = ef_.Operators;
				var eh_ = eg_.TypeConverter;
				var ei_ = eh_.Convert<string>(ed_);
				var ej_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var el_ = dd_.InList<string>(ei_, (ej_ as IEnumerable<string>));
				var en_ = dd_.And(ec_, el_);
				var eo_ = Lab?.Value;
				var eq_ = dd_.Not((bool?)(eo_ is null));
				var es_ = dd_.And(en_, eq_);

				return es_;
			};
			var ax_ = g_.WhereOrNull<Observation>(LabList, av_);
			object ay_(Observation @this)
			{
				var et_ = @this?.IssuedElement;

				return et_;
			};
			var ba_ = g_.ListSortBy<Observation>(ax_, ay_, System.ComponentModel.ListSortDirection.Ascending);
			var bc_ = g_.FirstOfList<Observation>(ba_);
			var bd_ = bc_?.IssuedElement;
			var be_ = FHIRHelpers_4_0_001.ToDateTime(bd_);
			var bg_ = g_.ConvertDateTimeToString(be_);
			var bh_ = (bg_ ?? "");
			var bj_ = g_.Concatenate(au_, bh_);

			return bj_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter, string>(a_, b_);

		return d_;
	}


    private IEnumerable<string> Results_Value()
	{
		var a_ = this.Heart_rate();
		var b_ = context.Operators;
		var c_ = b_.ToList<CqlCode>(a_);
		var d_ = context.DataRetriever;
		var e_ = d_.RetrieveByCodes<Observation>(c_, null);
		var f_ = this.FirstPhysicalExamWithEncounterId(e_, "FirstHeartRate");
		var g_ = this.Systolic_blood_pressure();
		var i_ = b_.ToList<CqlCode>(g_);
		var k_ = d_.RetrieveByCodes<Observation>(i_, null);
		var l_ = this.FirstPhysicalExamWithEncounterId(k_, "FirstSystolicBP");
		var m_ = this.Body_temperature();
		var o_ = d_.RetrieveByValueSet<Observation>(m_, null);
		var p_ = this.FirstPhysicalExamWithEncounterId(o_, "FirstTemperature");
		var q_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		var s_ = b_.ToList<CqlCode>(q_);
		var u_ = d_.RetrieveByCodes<Observation>(s_, null);
		var v_ = this.FirstPhysicalExamWithEncounterId(u_, "FirstO2Saturation");
		var w_ = this.Hematocrit_lab_test();
		var y_ = d_.RetrieveByValueSet<Observation>(w_, null);
		var z_ = this.FirstLabTestWithEncounterId(y_, "FirstHematocrit");
		var aa_ = this.Platelet_count_lab_test();
		var ac_ = d_.RetrieveByValueSet<Observation>(aa_, null);
		var ad_ = this.FirstLabTestWithEncounterId(ac_, "FirstPlateletCount");
		var ae_ = this.White_blood_cells_count_lab_test();
		var ag_ = d_.RetrieveByValueSet<Observation>(ae_, null);
		var ah_ = this.FirstLabTestWithEncounterId(ag_, "FirstWhiteBloodCell");
		var ai_ = this.Sodium_lab_test();
		var ak_ = d_.RetrieveByValueSet<Observation>(ai_, null);
		var al_ = this.FirstLabTestWithEncounterId(ak_, "FirstSodium");
		var am_ = this.Bicarbonate_lab_test();
		var ao_ = d_.RetrieveByValueSet<Observation>(am_, null);
		var ap_ = this.FirstLabTestWithEncounterId(ao_, "FirstBicarbonate");
		var aq_ = this.Creatinine_lab_test();
		var as_ = d_.RetrieveByValueSet<Observation>(aq_, null);
		var at_ = this.FirstLabTestWithEncounterId(as_, "FirstCreatinine");
		var au_ = new IEnumerable<string>[]
		{
			f_,
			l_,
			p_,
			v_,
			z_,
			ad_,
			ah_,
			al_,
			ap_,
			at_,
		};
		var aw_ = b_.FlattenList<string>((au_ as IEnumerable<IEnumerable<string>>));

		return aw_;
	}

    [CqlDeclaration("Results")]
    public IEnumerable<string> Results() => __Results.Value;

    [CqlDeclaration("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		var a_ = context.Operators;
		var b_ = a_.ConvertDateTimeToDate(BirthDateTime);
		var d_ = a_.ConvertDateTimeToDate(AsOf);
		var f_ = a_.DurationBetween(b_, d_, "year");

		return f_;
	}


    [CqlDeclaration("ToDate")]
    public CqlDateTime ToDate(CqlDateTime Value)
	{
		var a_ = context.Operators;
		var b_ = a_.ComponentFrom(Value, "year");
		var d_ = a_.ComponentFrom(Value, "month");
		var f_ = a_.ComponentFrom(Value, "day");
		var h_ = a_.TimezoneOffsetFrom(Value);
		var j_ = a_.DateTime(b_, d_, f_, (int?)0, (int?)0, (int?)0, (int?)0, h_);

		return j_;
	}


    [CqlDeclaration("LengthOfStay")]
    public int? LengthOfStay(CqlInterval<CqlDateTime> Stay)
	{
		var a_ = context.Operators;
		var b_ = a_.Start(Stay);
		var d_ = a_.End(Stay);
		var f_ = a_.DifferenceBetween(b_, d_, "day");

		return f_;
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
			var g_ = this.Emergency_Department_Visit();
			var h_ = context.DataRetriever;
			var i_ = h_.RetrieveByValueSet<Encounter>(g_, null);
			bool? j_(Encounter LastED)
			{
				var aw_ = LastED?.Period;
				var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
				var ay_ = context.Operators;
				var az_ = ay_.End(ax_);
				var ba_ = this.Observation_Services();
				var bb_ = context.DataRetriever;
				var bc_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				bool? bd_(Encounter LastObs)
				{
					var du_ = LastObs?.Period;
					var dv_ = FHIRHelpers_4_0_001.ToInterval(du_);
					var dw_ = context.Operators;
					var dx_ = dw_.End(dv_);
					var dy_ = Visit?.Period;
					var dz_ = FHIRHelpers_4_0_001.ToInterval(dy_);
					var eb_ = dw_.Start(dz_);
					var ed_ = dw_.Quantity(1m, "hour");
					var ef_ = dw_.Subtract(eb_, ed_);
					var eh_ = FHIRHelpers_4_0_001.ToInterval(dy_);
					var ej_ = dw_.Start(eh_);
					var el_ = dw_.Interval(ef_, ej_, true, true);
					var en_ = dw_.ElementInInterval<CqlDateTime>(dx_, el_, null);
					var ep_ = FHIRHelpers_4_0_001.ToInterval(dy_);
					var er_ = dw_.Start(ep_);
					var et_ = dw_.Not((bool?)(er_ is null));
					var ev_ = dw_.And(en_, et_);

					return ev_;
				};
				var bf_ = ay_.WhereOrNull<Encounter>(bc_, bd_);
				object bg_(Encounter @this)
				{
					var ew_ = @this?.Period;
					var ex_ = FHIRHelpers_4_0_001.ToInterval(ew_);
					var ey_ = context.Operators;
					var ez_ = ey_.End(ex_);

					return ez_;
				};
				var bi_ = ay_.ListSortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
				var bk_ = ay_.LastOfList<Encounter>(bi_);
				var bl_ = bk_?.Period;
				var bm_ = FHIRHelpers_4_0_001.ToInterval(bl_);
				var bo_ = ay_.Start(bm_);
				var bp_ = Visit?.Period;
				var bq_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var bs_ = ay_.Start(bq_);
				var bt_ = (bo_ ?? bs_);
				var bv_ = ay_.Quantity(1m, "hour");
				var bx_ = ay_.Subtract(bt_, bv_);
				var ca_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				bool? cb_(Encounter LastObs)
				{
					var fa_ = LastObs?.Period;
					var fb_ = FHIRHelpers_4_0_001.ToInterval(fa_);
					var fc_ = context.Operators;
					var fd_ = fc_.End(fb_);
					var fe_ = Visit?.Period;
					var ff_ = FHIRHelpers_4_0_001.ToInterval(fe_);
					var fh_ = fc_.Start(ff_);
					var fj_ = fc_.Quantity(1m, "hour");
					var fl_ = fc_.Subtract(fh_, fj_);
					var fn_ = FHIRHelpers_4_0_001.ToInterval(fe_);
					var fp_ = fc_.Start(fn_);
					var fr_ = fc_.Interval(fl_, fp_, true, true);
					var ft_ = fc_.ElementInInterval<CqlDateTime>(fd_, fr_, null);
					var fv_ = FHIRHelpers_4_0_001.ToInterval(fe_);
					var fx_ = fc_.Start(fv_);
					var fz_ = fc_.Not((bool?)(fx_ is null));
					var gb_ = fc_.And(ft_, fz_);

					return gb_;
				};
				var cd_ = ay_.WhereOrNull<Encounter>(ca_, cb_);
				object ce_(Encounter @this)
				{
					var gc_ = @this?.Period;
					var gd_ = FHIRHelpers_4_0_001.ToInterval(gc_);
					var ge_ = context.Operators;
					var gf_ = ge_.End(gd_);

					return gf_;
				};
				var cg_ = ay_.ListSortBy<Encounter>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);
				var ci_ = ay_.LastOfList<Encounter>(cg_);
				var cj_ = ci_?.Period;
				var ck_ = FHIRHelpers_4_0_001.ToInterval(cj_);
				var cm_ = ay_.Start(ck_);
				var co_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var cq_ = ay_.Start(co_);
				var cr_ = (cm_ ?? cq_);
				var ct_ = ay_.Interval(bx_, cr_, true, true);
				var cv_ = ay_.ElementInInterval<CqlDateTime>(az_, ct_, null);
				var cy_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				bool? cz_(Encounter LastObs)
				{
					var gg_ = LastObs?.Period;
					var gh_ = FHIRHelpers_4_0_001.ToInterval(gg_);
					var gi_ = context.Operators;
					var gj_ = gi_.End(gh_);
					var gk_ = Visit?.Period;
					var gl_ = FHIRHelpers_4_0_001.ToInterval(gk_);
					var gn_ = gi_.Start(gl_);
					var gp_ = gi_.Quantity(1m, "hour");
					var gr_ = gi_.Subtract(gn_, gp_);
					var gt_ = FHIRHelpers_4_0_001.ToInterval(gk_);
					var gv_ = gi_.Start(gt_);
					var gx_ = gi_.Interval(gr_, gv_, true, true);
					var gz_ = gi_.ElementInInterval<CqlDateTime>(gj_, gx_, null);
					var hb_ = FHIRHelpers_4_0_001.ToInterval(gk_);
					var hd_ = gi_.Start(hb_);
					var hf_ = gi_.Not((bool?)(hd_ is null));
					var hh_ = gi_.And(gz_, hf_);

					return hh_;
				};
				var db_ = ay_.WhereOrNull<Encounter>(cy_, cz_);
				object dc_(Encounter @this)
				{
					var hi_ = @this?.Period;
					var hj_ = FHIRHelpers_4_0_001.ToInterval(hi_);
					var hk_ = context.Operators;
					var hl_ = hk_.End(hj_);

					return hl_;
				};
				var de_ = ay_.ListSortBy<Encounter>(db_, dc_, System.ComponentModel.ListSortDirection.Ascending);
				var dg_ = ay_.LastOfList<Encounter>(de_);
				var dh_ = dg_?.Period;
				var di_ = FHIRHelpers_4_0_001.ToInterval(dh_);
				var dk_ = ay_.Start(di_);
				var dm_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var do_ = ay_.Start(dm_);
				var dp_ = (dk_ ?? do_);
				var dr_ = ay_.Not((bool?)(dp_ is null));
				var dt_ = ay_.And(cv_, dr_);

				return dt_;
			};
			var k_ = context.Operators;
			var l_ = k_.WhereOrNull<Encounter>(i_, j_);
			object m_(Encounter @this)
			{
				var hm_ = @this?.Period;
				var hn_ = FHIRHelpers_4_0_001.ToInterval(hm_);
				var ho_ = context.Operators;
				var hp_ = ho_.End(hn_);

				return hp_;
			};
			var o_ = k_.ListSortBy<Encounter>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = k_.LastOfList<Encounter>(o_);
			var r_ = q_?.Period;
			var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			var u_ = k_.Start(s_);
			var v_ = this.Observation_Services();
			var x_ = h_.RetrieveByValueSet<Encounter>(v_, null);
			bool? y_(Encounter LastObs)
			{
				var hq_ = LastObs?.Period;
				var hr_ = FHIRHelpers_4_0_001.ToInterval(hq_);
				var hs_ = context.Operators;
				var ht_ = hs_.End(hr_);
				var hu_ = Visit?.Period;
				var hv_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var hx_ = hs_.Start(hv_);
				var hz_ = hs_.Quantity(1m, "hour");
				var ib_ = hs_.Subtract(hx_, hz_);
				var id_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var if_ = hs_.Start(id_);
				var ih_ = hs_.Interval(ib_, if_, true, true);
				var ij_ = hs_.ElementInInterval<CqlDateTime>(ht_, ih_, null);
				var il_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var in_ = hs_.Start(il_);
				var ip_ = hs_.Not((bool?)(in_ is null));
				var ir_ = hs_.And(ij_, ip_);

				return ir_;
			};
			var aa_ = k_.WhereOrNull<Encounter>(x_, y_);
			object ab_(Encounter @this)
			{
				var is_ = @this?.Period;
				var it_ = FHIRHelpers_4_0_001.ToInterval(is_);
				var iu_ = context.Operators;
				var iv_ = iu_.End(it_);

				return iv_;
			};
			var ad_ = k_.ListSortBy<Encounter>(aa_, ab_, System.ComponentModel.ListSortDirection.Ascending);
			var af_ = k_.LastOfList<Encounter>(ad_);
			var ag_ = af_?.Period;
			var ah_ = FHIRHelpers_4_0_001.ToInterval(ag_);
			var aj_ = k_.Start(ah_);
			var ak_ = Visit?.Period;
			var al_ = FHIRHelpers_4_0_001.ToInterval(ak_);
			var an_ = k_.Start(al_);
			var ao_ = (aj_ ?? an_);
			var ap_ = (u_ ?? ao_);
			var ar_ = FHIRHelpers_4_0_001.ToInterval(ak_);
			var at_ = k_.End(ar_);
			var av_ = k_.Interval(ap_, at_, true, true);

			return av_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var f_ = c_.SingleOrNull<CqlInterval<CqlDateTime>>(d_);

		return f_;
	}


    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
	{
		var a_ = this.HospitalizationWithObservation(Encounter);
		var b_ = this.LengthInDays(a_);

		return b_;
	}


}