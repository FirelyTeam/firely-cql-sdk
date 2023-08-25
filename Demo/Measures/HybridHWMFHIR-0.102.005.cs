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

    private CqlValueSet Bicarbonate_lab_test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

		return a_;
	}

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
    public CqlValueSet Bicarbonate_lab_test() => __Bicarbonate_lab_test.Value;

    private CqlValueSet Body_temperature_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

		return a_;
	}

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
    public CqlValueSet Body_temperature() => __Body_temperature.Value;

    private CqlValueSet Creatinine_lab_test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

		return a_;
	}

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
    public CqlValueSet Creatinine_lab_test() => __Creatinine_lab_test.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

		return a_;
	}

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

		return a_;
	}

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Ethnicity_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

		return a_;
	}

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity() => __Ethnicity.Value;

    private CqlValueSet Hematocrit_lab_test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

		return a_;
	}

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
    public CqlValueSet Hematocrit_lab_test() => __Hematocrit_lab_test.Value;

    private CqlValueSet Medicare_payer_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

		return a_;
	}

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
    public CqlValueSet Medicare_payer() => __Medicare_payer.Value;

    private CqlValueSet Observation_Services_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

		return a_;
	}

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet ONC_Administrative_Sex_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

		return a_;
	}

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex() => __ONC_Administrative_Sex.Value;

    private CqlValueSet Payer_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

		return a_;
	}

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer() => __Payer.Value;

    private CqlValueSet Platelet_count_lab_test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

		return a_;
	}

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
    public CqlValueSet Platelet_count_lab_test() => __Platelet_count_lab_test.Value;

    private CqlValueSet Race_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

		return a_;
	}

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race() => __Race.Value;

    private CqlValueSet Sodium_lab_test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

		return a_;
	}

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
    public CqlValueSet Sodium_lab_test() => __Sodium_lab_test.Value;

    private CqlValueSet White_blood_cells_count_lab_test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

		return a_;
	}

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
		var a_ = (int?)2019;
		var b_ = (int?)1;
		var d_ = (int?)0;
		var h_ = context.Operators;
		var i_ = h_.ConvertIntegerToDecimal(default);
		var k_ = h_.DateTime(a_, b_, b_, d_, d_, d_, d_, i_);
		var l_ = (int?)2020;
		var t_ = h_.ConvertIntegerToDecimal(default);
		var v_ = h_.DateTime(l_, b_, b_, d_, d_, d_, d_, t_);
		var x_ = h_.Interval(k_, v_, true, false);
		var y_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", x_);
		var z_ = (CqlInterval<CqlDateTime>)y_;

		return z_;
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
		var d_ = (Encounter _InpatientEncounter) =>
		{
			var n_ = this.Medicare_payer();
			var o_ = context.DataRetriever;
			var p_ = o_.RetrieveByValueSet<Coverage>(n_, null);

			return p_;
		};
		var e_ = (Encounter _InpatientEncounter, Coverage _Payer) =>
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
		var h_ = (Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) =>
		{
			var r_ = tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;
			var s_ = r_.StatusElement;
			var t_ = new CallStackEntry("ToString", null, null);
			var u_ = context.Deeper(t_);
			var v_ = u_.Operators;
			var w_ = v_.TypeConverter;
			var x_ = w_.Convert<string>(s_);
			var y_ = context.Operators;
			var z_ = y_.Equal(x_, "finished");
			var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(r_);
			var ac_ = this.LengthInDays(ab_);
			var ad_ = ac_;
			var ae_ = (int?)365;
			var af_ = ae_;
			var ah_ = y_.Less(ad_, af_);
			var aj_ = y_.And(z_, ah_);
			var al_ = r_.Period;
			var am_ = FHIRHelpers_4_0_001.ToInterval(al_);
			var ao_ = y_.End(am_);
			var ap_ = this.Measurement_Period();
			var ar_ = y_.ElementInInterval<CqlDateTime>(ao_, ap_, "day");
			var at_ = y_.And(aj_, ar_);
			var au_ = this.Patient();
			var av_ = au_.BirthDateElement;
			var aw_ = av_.Value;
			var ay_ = y_.TypeConverter;
			var az_ = ay_.Convert<CqlDate>(aw_);
			var bb_ = r_.Period;
			var bc_ = FHIRHelpers_4_0_001.ToInterval(bb_);
			var be_ = y_.Start(bc_);
			var bg_ = y_.DateFrom(be_);
			var bi_ = y_.CalculateAgeAt(az_, bg_, "year");
			var bj_ = (int?)65;
			var bk_ = (int?)94;
			var bm_ = y_.Interval(bj_, bk_, true, true);
			var bo_ = y_.ElementInInterval<int?>(bi_, bm_, null);
			var bq_ = y_.And(at_, bo_);

			return bq_;
		};
		var j_ = f_.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(g_, h_);
		var k_ = (Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) =>
		{
			var br_ = tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;

			return br_;
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
		var b_ = (Encounter Encounter) =>
		{
			var e_ = ("\r\n" ?? "");
			var f_ = (CCDE ?? "");
			var g_ = context.Operators;
			var h_ = g_.Concatenate(e_, f_);
			var i_ = (h_ ?? "");
			var j_ = ("," ?? "");
			var l_ = g_.Concatenate(i_, j_);
			var m_ = (l_ ?? "");
			var n_ = Encounter.IdElement;
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
			var ab_ = (Observation Exam) =>
			{
				var bn_ = Exam.Effective;
				var bo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bn_);
				var bp_ = context.Operators;
				var bq_ = bp_.Start(bo_);
				var br_ = (bq_ == null);
				var bs_ = (bool?)br_;
				var bu_ = bp_.Not(bs_);
				var bw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bn_);
				var by_ = bp_.Start(bw_);
				var bz_ = Encounter.Period;
				var ca_ = FHIRHelpers_4_0_001.ToInterval(bz_);
				var cc_ = bp_.Start(ca_);
				var ce_ = bp_.Quantity(1440m, "minutes");
				var cg_ = bp_.Subtract(cc_, ce_);
				var ci_ = FHIRHelpers_4_0_001.ToInterval(bz_);
				var ck_ = bp_.Start(ci_);
				var cm_ = bp_.Quantity(120m, "minutes");
				var co_ = bp_.Add(ck_, cm_);
				var cq_ = bp_.Interval(cg_, co_, true, true);
				var cs_ = bp_.ElementInInterval<CqlDateTime>(by_, cq_, null);
				var cu_ = bp_.And(bu_, cs_);
				var cv_ = Exam.StatusElement;
				var cw_ = new CallStackEntry("ToString", null, null);
				var cx_ = context.Deeper(cw_);
				var cy_ = cx_.Operators;
				var cz_ = cy_.TypeConverter;
				var da_ = cz_.Convert<string>(cv_);
				var db_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var dc_ = (db_ as IEnumerable<string>);
				var de_ = bp_.InList<string>(da_, dc_);
				var dg_ = bp_.And(cu_, de_);
				var dh_ = Exam.Value;
				var di_ = (dh_ == null);
				var dj_ = (bool?)di_;
				var dl_ = bp_.Not(dj_);
				var dn_ = bp_.And(dg_, dl_);

				return dn_;
			};
			var ad_ = g_.WhereOrNull<Observation>(ExamList, ab_);
			var ae_ = (Observation @this) =>
			{
				var do_ = @this.Effective;
				var dp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(do_);
				var dq_ = context.Operators;
				var dr_ = dq_.Start(dp_);

				return dr_;
			};
			var ag_ = g_.ListSortBy<Observation>(ad_, ae_, System.ComponentModel.ListSortDirection.Ascending);
			var ai_ = g_.FirstOfList<Observation>(ag_);
			var aj_ = ai_.Value;
			var ak_ = (aj_ as Quantity);
			var al_ = FHIRHelpers_4_0_001.ToQuantity(ak_);
			var an_ = g_.ConvertQuantityToString(al_);
			var ao_ = (an_ ?? "");
			var aq_ = g_.Concatenate(aa_, ao_);
			var ar_ = (aq_ ?? "");
			var au_ = g_.Concatenate(ar_, j_);
			var av_ = (au_ ?? "");
			var aw_ = (Observation Exam) =>
			{
				var ds_ = Exam.Effective;
				var dt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ds_);
				var du_ = context.Operators;
				var dv_ = du_.Start(dt_);
				var dw_ = (dv_ == null);
				var dx_ = (bool?)dw_;
				var dz_ = du_.Not(dx_);
				var eb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ds_);
				var ed_ = du_.Start(eb_);
				var ee_ = Encounter.Period;
				var ef_ = FHIRHelpers_4_0_001.ToInterval(ee_);
				var eh_ = du_.Start(ef_);
				var ej_ = du_.Quantity(1440m, "minutes");
				var el_ = du_.Subtract(eh_, ej_);
				var en_ = FHIRHelpers_4_0_001.ToInterval(ee_);
				var ep_ = du_.Start(en_);
				var er_ = du_.Quantity(120m, "minutes");
				var et_ = du_.Add(ep_, er_);
				var ev_ = du_.Interval(el_, et_, true, true);
				var ex_ = du_.ElementInInterval<CqlDateTime>(ed_, ev_, null);
				var ez_ = du_.And(dz_, ex_);
				var fa_ = Exam.StatusElement;
				var fb_ = new CallStackEntry("ToString", null, null);
				var fc_ = context.Deeper(fb_);
				var fd_ = fc_.Operators;
				var fe_ = fd_.TypeConverter;
				var ff_ = fe_.Convert<string>(fa_);
				var fg_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var fh_ = (fg_ as IEnumerable<string>);
				var fj_ = du_.InList<string>(ff_, fh_);
				var fl_ = du_.And(ez_, fj_);
				var fm_ = Exam.Value;
				var fn_ = (fm_ == null);
				var fo_ = (bool?)fn_;
				var fq_ = du_.Not(fo_);
				var fs_ = du_.And(fl_, fq_);

				return fs_;
			};
			var ay_ = g_.WhereOrNull<Observation>(ExamList, aw_);
			var az_ = (Observation @this) =>
			{
				var ft_ = @this.Effective;
				var fu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ft_);
				var fv_ = context.Operators;
				var fw_ = fv_.Start(fu_);

				return fw_;
			};
			var bb_ = g_.ListSortBy<Observation>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
			var bd_ = g_.FirstOfList<Observation>(bb_);
			var be_ = bd_.Effective;
			var bf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(be_);
			var bh_ = g_.Start(bf_);
			var bj_ = g_.ConvertDateTimeToString(bh_);
			var bk_ = (bj_ ?? "");
			var bm_ = g_.Concatenate(av_, bk_);

			return bm_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter, string>(a_, b_);

		return d_;
	}


    [CqlDeclaration("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		var b_ = (Encounter Encounter) =>
		{
			var e_ = ("\r\n" ?? "");
			var f_ = (CCDE ?? "");
			var g_ = context.Operators;
			var h_ = g_.Concatenate(e_, f_);
			var i_ = (h_ ?? "");
			var j_ = ("," ?? "");
			var l_ = g_.Concatenate(i_, j_);
			var m_ = (l_ ?? "");
			var n_ = Encounter.IdElement;
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
			var ab_ = (Observation Lab) =>
			{
				var bl_ = Lab.IssuedElement;
				var bm_ = (bl_ == null);
				var bn_ = (bool?)bm_;
				var bo_ = context.Operators;
				var bp_ = bo_.Not(bn_);
				var br_ = FHIRHelpers_4_0_001.ToDateTime(bl_);
				var bs_ = Encounter.Period;
				var bt_ = FHIRHelpers_4_0_001.ToInterval(bs_);
				var bv_ = bo_.Start(bt_);
				var bx_ = bo_.Quantity(1440m, "minutes");
				var bz_ = bo_.Subtract(bv_, bx_);
				var cb_ = FHIRHelpers_4_0_001.ToInterval(bs_);
				var cd_ = bo_.Start(cb_);
				var cf_ = bo_.Quantity(1440m, "minutes");
				var ch_ = bo_.Add(cd_, cf_);
				var cj_ = bo_.Interval(bz_, ch_, true, true);
				var cl_ = bo_.ElementInInterval<CqlDateTime>(br_, cj_, null);
				var cn_ = bo_.And(bp_, cl_);
				var co_ = Lab.StatusElement;
				var cp_ = new CallStackEntry("ToString", null, null);
				var cq_ = context.Deeper(cp_);
				var cr_ = cq_.Operators;
				var cs_ = cr_.TypeConverter;
				var ct_ = cs_.Convert<string>(co_);
				var cu_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var cv_ = (cu_ as IEnumerable<string>);
				var cx_ = bo_.InList<string>(ct_, cv_);
				var cz_ = bo_.And(cn_, cx_);
				var da_ = Lab.Value;
				var db_ = (da_ == null);
				var dc_ = (bool?)db_;
				var de_ = bo_.Not(dc_);
				var dg_ = bo_.And(cz_, de_);

				return dg_;
			};
			var ad_ = g_.WhereOrNull<Observation>(LabList, ab_);
			var ae_ = (Observation @this) =>
			{
				var dh_ = @this.IssuedElement;

				return dh_;
			};
			var ag_ = g_.ListSortBy<Observation>(ad_, ae_, System.ComponentModel.ListSortDirection.Ascending);
			var ai_ = g_.FirstOfList<Observation>(ag_);
			var aj_ = ai_.Value;
			var ak_ = (aj_ as Quantity);
			var al_ = FHIRHelpers_4_0_001.ToQuantity(ak_);
			var an_ = g_.ConvertQuantityToString(al_);
			var ao_ = (an_ ?? "");
			var aq_ = g_.Concatenate(aa_, ao_);
			var ar_ = (aq_ ?? "");
			var au_ = g_.Concatenate(ar_, j_);
			var av_ = (au_ ?? "");
			var aw_ = (Observation Lab) =>
			{
				var di_ = Lab.IssuedElement;
				var dj_ = (di_ == null);
				var dk_ = (bool?)dj_;
				var dl_ = context.Operators;
				var dm_ = dl_.Not(dk_);
				var do_ = FHIRHelpers_4_0_001.ToDateTime(di_);
				var dp_ = Encounter.Period;
				var dq_ = FHIRHelpers_4_0_001.ToInterval(dp_);
				var ds_ = dl_.Start(dq_);
				var du_ = dl_.Quantity(1440m, "minutes");
				var dw_ = dl_.Subtract(ds_, du_);
				var dy_ = FHIRHelpers_4_0_001.ToInterval(dp_);
				var ea_ = dl_.Start(dy_);
				var ec_ = dl_.Quantity(1440m, "minutes");
				var ee_ = dl_.Add(ea_, ec_);
				var eg_ = dl_.Interval(dw_, ee_, true, true);
				var ei_ = dl_.ElementInInterval<CqlDateTime>(do_, eg_, null);
				var ek_ = dl_.And(dm_, ei_);
				var el_ = Lab.StatusElement;
				var em_ = new CallStackEntry("ToString", null, null);
				var en_ = context.Deeper(em_);
				var eo_ = en_.Operators;
				var ep_ = eo_.TypeConverter;
				var eq_ = ep_.Convert<string>(el_);
				var er_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var es_ = (er_ as IEnumerable<string>);
				var eu_ = dl_.InList<string>(eq_, es_);
				var ew_ = dl_.And(ek_, eu_);
				var ex_ = Lab.Value;
				var ey_ = (ex_ == null);
				var ez_ = (bool?)ey_;
				var fb_ = dl_.Not(ez_);
				var fd_ = dl_.And(ew_, fb_);

				return fd_;
			};
			var ay_ = g_.WhereOrNull<Observation>(LabList, aw_);
			var az_ = (Observation @this) =>
			{
				var fe_ = @this.IssuedElement;

				return fe_;
			};
			var bb_ = g_.ListSortBy<Observation>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
			var bd_ = g_.FirstOfList<Observation>(bb_);
			var be_ = bd_.IssuedElement;
			var bf_ = FHIRHelpers_4_0_001.ToDateTime(be_);
			var bh_ = g_.ConvertDateTimeToString(bf_);
			var bi_ = (bh_ ?? "");
			var bk_ = g_.Concatenate(av_, bi_);

			return bk_;
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
		var av_ = (au_ as IEnumerable<IEnumerable<string>>);
		var ax_ = b_.FlattenList<string>(av_);

		return ax_;
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
		var g_ = (int?)0;
		var l_ = a_.TimezoneOffsetFrom(Value);
		var n_ = a_.DateTime(b_, d_, f_, g_, g_, g_, g_, l_);

		return n_;
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
		var b_ = (Encounter Visit) =>
		{
			var g_ = this.Emergency_Department_Visit();
			var h_ = context.DataRetriever;
			var i_ = h_.RetrieveByValueSet<Encounter>(g_, null);
			var j_ = (Encounter LastED) =>
			{
				var aw_ = LastED.Period;
				var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
				var ay_ = context.Operators;
				var az_ = ay_.End(ax_);
				var ba_ = this.Observation_Services();
				var bb_ = context.DataRetriever;
				var bc_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				var bd_ = (Encounter LastObs) =>
				{
					var dw_ = LastObs.Period;
					var dx_ = FHIRHelpers_4_0_001.ToInterval(dw_);
					var dy_ = context.Operators;
					var dz_ = dy_.End(dx_);
					var ea_ = Visit.Period;
					var eb_ = FHIRHelpers_4_0_001.ToInterval(ea_);
					var ed_ = dy_.Start(eb_);
					var ef_ = dy_.Quantity(1m, "hour");
					var eh_ = dy_.Subtract(ed_, ef_);
					var ej_ = FHIRHelpers_4_0_001.ToInterval(ea_);
					var el_ = dy_.Start(ej_);
					var en_ = dy_.Interval(eh_, el_, true, true);
					var ep_ = dy_.ElementInInterval<CqlDateTime>(dz_, en_, null);
					var er_ = FHIRHelpers_4_0_001.ToInterval(ea_);
					var et_ = dy_.Start(er_);
					var eu_ = (et_ == null);
					var ev_ = (bool?)eu_;
					var ex_ = dy_.Not(ev_);
					var ez_ = dy_.And(ep_, ex_);

					return ez_;
				};
				var bf_ = ay_.WhereOrNull<Encounter>(bc_, bd_);
				var bg_ = (Encounter @this) =>
				{
					var fa_ = @this.Period;
					var fb_ = FHIRHelpers_4_0_001.ToInterval(fa_);
					var fc_ = context.Operators;
					var fd_ = fc_.End(fb_);

					return fd_;
				};
				var bi_ = ay_.ListSortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
				var bk_ = ay_.LastOfList<Encounter>(bi_);
				var bl_ = bk_.Period;
				var bm_ = FHIRHelpers_4_0_001.ToInterval(bl_);
				var bo_ = ay_.Start(bm_);
				var bp_ = Visit.Period;
				var bq_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var bs_ = ay_.Start(bq_);
				var bt_ = (bo_ ?? bs_);
				var bv_ = ay_.Quantity(1m, "hour");
				var bx_ = ay_.Subtract(bt_, bv_);
				var ca_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				var cb_ = (Encounter LastObs) =>
				{
					var fe_ = LastObs.Period;
					var ff_ = FHIRHelpers_4_0_001.ToInterval(fe_);
					var fg_ = context.Operators;
					var fh_ = fg_.End(ff_);
					var fi_ = Visit.Period;
					var fj_ = FHIRHelpers_4_0_001.ToInterval(fi_);
					var fl_ = fg_.Start(fj_);
					var fn_ = fg_.Quantity(1m, "hour");
					var fp_ = fg_.Subtract(fl_, fn_);
					var fr_ = FHIRHelpers_4_0_001.ToInterval(fi_);
					var ft_ = fg_.Start(fr_);
					var fv_ = fg_.Interval(fp_, ft_, true, true);
					var fx_ = fg_.ElementInInterval<CqlDateTime>(fh_, fv_, null);
					var fz_ = FHIRHelpers_4_0_001.ToInterval(fi_);
					var gb_ = fg_.Start(fz_);
					var gc_ = (gb_ == null);
					var gd_ = (bool?)gc_;
					var gf_ = fg_.Not(gd_);
					var gh_ = fg_.And(fx_, gf_);

					return gh_;
				};
				var cd_ = ay_.WhereOrNull<Encounter>(ca_, cb_);
				var ce_ = (Encounter @this) =>
				{
					var gi_ = @this.Period;
					var gj_ = FHIRHelpers_4_0_001.ToInterval(gi_);
					var gk_ = context.Operators;
					var gl_ = gk_.End(gj_);

					return gl_;
				};
				var cg_ = ay_.ListSortBy<Encounter>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);
				var ci_ = ay_.LastOfList<Encounter>(cg_);
				var cj_ = ci_.Period;
				var ck_ = FHIRHelpers_4_0_001.ToInterval(cj_);
				var cm_ = ay_.Start(ck_);
				var co_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var cq_ = ay_.Start(co_);
				var cr_ = (cm_ ?? cq_);
				var ct_ = ay_.Interval(bx_, cr_, true, true);
				var cv_ = ay_.ElementInInterval<CqlDateTime>(az_, ct_, null);
				var cy_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				var cz_ = (Encounter LastObs) =>
				{
					var gm_ = LastObs.Period;
					var gn_ = FHIRHelpers_4_0_001.ToInterval(gm_);
					var go_ = context.Operators;
					var gp_ = go_.End(gn_);
					var gq_ = Visit.Period;
					var gr_ = FHIRHelpers_4_0_001.ToInterval(gq_);
					var gt_ = go_.Start(gr_);
					var gv_ = go_.Quantity(1m, "hour");
					var gx_ = go_.Subtract(gt_, gv_);
					var gz_ = FHIRHelpers_4_0_001.ToInterval(gq_);
					var hb_ = go_.Start(gz_);
					var hd_ = go_.Interval(gx_, hb_, true, true);
					var hf_ = go_.ElementInInterval<CqlDateTime>(gp_, hd_, null);
					var hh_ = FHIRHelpers_4_0_001.ToInterval(gq_);
					var hj_ = go_.Start(hh_);
					var hk_ = (hj_ == null);
					var hl_ = (bool?)hk_;
					var hn_ = go_.Not(hl_);
					var hp_ = go_.And(hf_, hn_);

					return hp_;
				};
				var db_ = ay_.WhereOrNull<Encounter>(cy_, cz_);
				var dc_ = (Encounter @this) =>
				{
					var hq_ = @this.Period;
					var hr_ = FHIRHelpers_4_0_001.ToInterval(hq_);
					var hs_ = context.Operators;
					var ht_ = hs_.End(hr_);

					return ht_;
				};
				var de_ = ay_.ListSortBy<Encounter>(db_, dc_, System.ComponentModel.ListSortDirection.Ascending);
				var dg_ = ay_.LastOfList<Encounter>(de_);
				var dh_ = dg_.Period;
				var di_ = FHIRHelpers_4_0_001.ToInterval(dh_);
				var dk_ = ay_.Start(di_);
				var dm_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var do_ = ay_.Start(dm_);
				var dp_ = (dk_ ?? do_);
				var dq_ = (dp_ == null);
				var dr_ = (bool?)dq_;
				var dt_ = ay_.Not(dr_);
				var dv_ = ay_.And(cv_, dt_);

				return dv_;
			};
			var k_ = context.Operators;
			var l_ = k_.WhereOrNull<Encounter>(i_, j_);
			var m_ = (Encounter @this) =>
			{
				var hu_ = @this.Period;
				var hv_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var hw_ = context.Operators;
				var hx_ = hw_.End(hv_);

				return hx_;
			};
			var o_ = k_.ListSortBy<Encounter>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = k_.LastOfList<Encounter>(o_);
			var r_ = q_.Period;
			var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			var u_ = k_.Start(s_);
			var v_ = this.Observation_Services();
			var x_ = h_.RetrieveByValueSet<Encounter>(v_, null);
			var y_ = (Encounter LastObs) =>
			{
				var hy_ = LastObs.Period;
				var hz_ = FHIRHelpers_4_0_001.ToInterval(hy_);
				var ia_ = context.Operators;
				var ib_ = ia_.End(hz_);
				var ic_ = Visit.Period;
				var id_ = FHIRHelpers_4_0_001.ToInterval(ic_);
				var if_ = ia_.Start(id_);
				var ih_ = ia_.Quantity(1m, "hour");
				var ij_ = ia_.Subtract(if_, ih_);
				var il_ = FHIRHelpers_4_0_001.ToInterval(ic_);
				var in_ = ia_.Start(il_);
				var ip_ = ia_.Interval(ij_, in_, true, true);
				var ir_ = ia_.ElementInInterval<CqlDateTime>(ib_, ip_, null);
				var it_ = FHIRHelpers_4_0_001.ToInterval(ic_);
				var iv_ = ia_.Start(it_);
				var iw_ = (iv_ == null);
				var ix_ = (bool?)iw_;
				var iz_ = ia_.Not(ix_);
				var jb_ = ia_.And(ir_, iz_);

				return jb_;
			};
			var aa_ = k_.WhereOrNull<Encounter>(x_, y_);
			var ab_ = (Encounter @this) =>
			{
				var jc_ = @this.Period;
				var jd_ = FHIRHelpers_4_0_001.ToInterval(jc_);
				var je_ = context.Operators;
				var jf_ = je_.End(jd_);

				return jf_;
			};
			var ad_ = k_.ListSortBy<Encounter>(aa_, ab_, System.ComponentModel.ListSortDirection.Ascending);
			var af_ = k_.LastOfList<Encounter>(ad_);
			var ag_ = af_.Period;
			var ah_ = FHIRHelpers_4_0_001.ToInterval(ag_);
			var aj_ = k_.Start(ah_);
			var ak_ = Visit.Period;
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