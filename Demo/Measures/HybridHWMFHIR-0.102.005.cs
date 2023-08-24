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

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode Heart_rate_Value() =>
		new CqlCode("8867-4", "http://loinc.org", null, null);

    [CqlDeclaration("Heart rate")]
    public CqlCode Heart_rate() => __Heart_rate.Value;

    private CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value() =>
		new CqlCode("59408-5", "http://loinc.org", null, null);

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry() => __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry.Value;

    private CqlCode Systolic_blood_pressure_Value() =>
		new CqlCode("8480-6", "http://loinc.org", null, null);

    [CqlDeclaration("Systolic blood pressure")]
    public CqlCode Systolic_blood_pressure() => __Systolic_blood_pressure.Value;

    private CqlCode[] LOINC_2_69_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode("8867-4", "http://loinc.org", null, null);
		var c_ = new CqlCode("59408-5", "http://loinc.org", null, null);
		var d_ = new CqlCode("8480-6", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
		};
	}

    [CqlDeclaration("LOINC:2.69")]
    public CqlCode[] LOINC_2_69() => __LOINC_2_69.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", f_);

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

    [CqlDeclaration("LengthInDays")]
    public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context?.Operators.Start(Value);
		var b_ = context?.Operators.End(Value);

		return context?.Operators.DifferenceBetween(a_, b_, "day");
	}


    private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		var ad_ = this.Encounter_Inpatient();
		var ae_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = (Encounter _InpatientEncounter) =>
		{
			var a_ = this.Medicare_payer();

			return context?.DataRetriever.RetrieveByValueSet<Coverage>(a_, null);
		};
		var ag_ = (Encounter _InpatientEncounter, Coverage _Payer) =>
		{
			var b_ = _InpatientEncounter;
			var c_ = _Payer;

			return new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = b_,
				Payer = c_,
			};
		};
		var ah_ = context?.Operators.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(ae_, af_, ag_);
		var ai_ = (Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) =>
		{
			var d_ = (tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.StatusElement as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = (e_ as object);
			var g_ = context?.Operators.Equal(f_, ("finished" as object));
			var h_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(h_);
			var j_ = this.LengthInDays(i_);
			var k_ = (j_ as object);
			var l_ = ((int?)365 as object);
			var m_ = context?.Operators.Less(k_, l_);
			var n_ = context?.Operators.And(g_, m_);
			var o_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.Period;
			var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var q_ = context?.Operators.End(p_);
			var r_ = this.Measurement_Period();
			var s_ = context?.Operators.ElementInInterval<CqlDateTime>(q_, r_, "day");
			var t_ = context?.Operators.And(n_, s_);
			var u_ = (this.Patient()?.BirthDateElement?.Value as object);
			var v_ = context?.Operators?.TypeConverter.Convert<CqlDate>(u_);
			var w_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.Period;
			var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
			var y_ = context?.Operators.Start(x_);
			var z_ = context?.Operators.DateFrom(y_);
			var aa_ = context?.Operators.CalculateAgeAt(v_, z_, "year");
			var ab_ = context?.Operators.Interval((int?)65, (int?)94, true, true);
			var ac_ = context?.Operators.ElementInInterval<int?>(aa_, ab_, null);

			return context?.Operators.And(t_, ac_);
		};
		var aj_ = context?.Operators.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(ah_, ai_);
		var ak_ = (Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) => tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(aj_, ak_);
	}

    [CqlDeclaration("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters() => __Inpatient_Encounters.Value;

    private IEnumerable<Encounter> Initial_Population_Value() =>
		this.Inpatient_Encounters();

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    [CqlDeclaration("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(IEnumerable<Observation> ExamList, string CCDE)
	{
		var dd_ = this.Inpatient_Encounters();
		var de_ = (Encounter Encounter) =>
		{
			var bq_ = ("\r\n" ?? "");
			var br_ = (CCDE ?? "");
			var bs_ = context?.Operators.Concatenate(bq_, br_);
			var bt_ = (bs_ ?? "");
			var bu_ = ("," ?? "");
			var bv_ = context?.Operators.Concatenate(bt_, bu_);
			var bw_ = (bv_ ?? "");
			var bx_ = (Encounter?.IdElement as object);
			var by_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(bx_);
			var bz_ = (by_ ?? "");
			var ca_ = context?.Operators.Concatenate(bw_, bz_);
			var cb_ = (ca_ ?? "");
			var cc_ = (" , " ?? "");
			var cd_ = context?.Operators.Concatenate(cb_, cc_);
			var ce_ = (cd_ ?? "");
			var cf_ = (Observation Exam) =>
			{
				var a_ = (Exam?.Effective as object);
				var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);
				var c_ = context?.Operators.Start(b_);
				var d_ = (bool?)(c_ == null);
				var e_ = context?.Operators.Not(d_);
				var f_ = (Exam?.Effective as object);
				var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
				var h_ = context?.Operators.Start(g_);
				var i_ = Encounter?.Period;
				var j_ = FHIRHelpers_4_0_001.ToInterval(i_);
				var k_ = context?.Operators.Start(j_);
				var l_ = context?.Operators.Quantity(1440m, "minutes");
				var m_ = context?.Operators.Subtract(k_, l_);
				var n_ = Encounter?.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = context?.Operators.Start(o_);
				var q_ = context?.Operators.Quantity(120m, "minutes");
				var r_ = context?.Operators.Add(p_, q_);
				var s_ = context?.Operators.Interval(m_, r_, true, true);
				var t_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, s_, null);
				var u_ = context?.Operators.And(e_, t_);
				var v_ = (Exam?.StatusElement as object);
				var w_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(v_);
				var x_ = "final";
				var y_ = "amended";
				var z_ = "preliminary";
				var aa_ = new string[]
				{
					x_,
					y_,
					z_,
				};
				var ab_ = (aa_ as IEnumerable<string>);
				var ac_ = context?.Operators.InList<string>(w_, ab_);
				var ad_ = context?.Operators.And(u_, ac_);
				var ae_ = (bool?)((Exam?.Value as object) == null);
				var af_ = context?.Operators.Not(ae_);

				return context?.Operators.And(ad_, af_);
			};
			var cg_ = context?.Operators.WhereOrNull<Observation>(ExamList, cf_);
			var ch_ = (Observation @this) =>
			{
				var ag_ = (@this?.Effective as object);
				var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ag_);

				return context?.Operators.Start(ah_);
			};
			var ci_ = context?.Operators.ListSortBy<Observation>(cg_, ch_, System.ComponentModel.ListSortDirection.Ascending);
			var cj_ = context?.Operators.FirstOfList<Observation>(ci_);
			var ck_ = ((cj_?.Value as object) as Quantity);
			var cl_ = FHIRHelpers_4_0_001.ToQuantity(ck_);
			var cm_ = context?.Operators.ConvertQuantityToString(cl_);
			var cn_ = (cm_ ?? "");
			var co_ = context?.Operators.Concatenate(ce_, cn_);
			var cp_ = (co_ ?? "");
			var cq_ = ("," ?? "");
			var cr_ = context?.Operators.Concatenate(cp_, cq_);
			var cs_ = (cr_ ?? "");
			var ct_ = (Observation Exam) =>
			{
				var ai_ = (Exam?.Effective as object);
				var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ai_);
				var ak_ = context?.Operators.Start(aj_);
				var al_ = (bool?)(ak_ == null);
				var am_ = context?.Operators.Not(al_);
				var an_ = (Exam?.Effective as object);
				var ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(an_);
				var ap_ = context?.Operators.Start(ao_);
				var aq_ = Encounter?.Period;
				var ar_ = FHIRHelpers_4_0_001.ToInterval(aq_);
				var as_ = context?.Operators.Start(ar_);
				var at_ = context?.Operators.Quantity(1440m, "minutes");
				var au_ = context?.Operators.Subtract(as_, at_);
				var av_ = Encounter?.Period;
				var aw_ = FHIRHelpers_4_0_001.ToInterval(av_);
				var ax_ = context?.Operators.Start(aw_);
				var ay_ = context?.Operators.Quantity(120m, "minutes");
				var az_ = context?.Operators.Add(ax_, ay_);
				var ba_ = context?.Operators.Interval(au_, az_, true, true);
				var bb_ = context?.Operators.ElementInInterval<CqlDateTime>(ap_, ba_, null);
				var bc_ = context?.Operators.And(am_, bb_);
				var bd_ = (Exam?.StatusElement as object);
				var be_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(bd_);
				var bf_ = "final";
				var bg_ = "amended";
				var bh_ = "preliminary";
				var bi_ = new string[]
				{
					bf_,
					bg_,
					bh_,
				};
				var bj_ = (bi_ as IEnumerable<string>);
				var bk_ = context?.Operators.InList<string>(be_, bj_);
				var bl_ = context?.Operators.And(bc_, bk_);
				var bm_ = (bool?)((Exam?.Value as object) == null);
				var bn_ = context?.Operators.Not(bm_);

				return context?.Operators.And(bl_, bn_);
			};
			var cu_ = context?.Operators.WhereOrNull<Observation>(ExamList, ct_);
			var cv_ = (Observation @this) =>
			{
				var bo_ = (@this?.Effective as object);
				var bp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bo_);

				return context?.Operators.Start(bp_);
			};
			var cw_ = context?.Operators.ListSortBy<Observation>(cu_, cv_, System.ComponentModel.ListSortDirection.Ascending);
			var cx_ = context?.Operators.FirstOfList<Observation>(cw_);
			var cy_ = (cx_?.Effective as object);
			var cz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cy_);
			var da_ = context?.Operators.Start(cz_);
			var db_ = context?.Operators.ConvertDateTimeToString(da_);
			var dc_ = (db_ ?? "");

			return context?.Operators.Concatenate(cs_, dc_);
		};

		return context?.Operators.SelectOrNull<Encounter, string>(dd_, de_);
	}


    [CqlDeclaration("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		var cq_ = this.Inpatient_Encounters();
		var cr_ = (Encounter Encounter) =>
		{
			var be_ = ("\r\n" ?? "");
			var bf_ = (CCDE ?? "");
			var bg_ = context?.Operators.Concatenate(be_, bf_);
			var bh_ = (bg_ ?? "");
			var bi_ = ("," ?? "");
			var bj_ = context?.Operators.Concatenate(bh_, bi_);
			var bk_ = (bj_ ?? "");
			var bl_ = (Encounter?.IdElement as object);
			var bm_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(bl_);
			var bn_ = (bm_ ?? "");
			var bo_ = context?.Operators.Concatenate(bk_, bn_);
			var bp_ = (bo_ ?? "");
			var bq_ = ("," ?? "");
			var br_ = context?.Operators.Concatenate(bp_, bq_);
			var bs_ = (br_ ?? "");
			var bt_ = (Observation Lab) =>
			{
				var a_ = (bool?)(Lab?.IssuedElement == null);
				var b_ = context?.Operators.Not(a_);
				var c_ = Lab?.IssuedElement;
				var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
				var e_ = Encounter?.Period;
				var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
				var g_ = context?.Operators.Start(f_);
				var h_ = context?.Operators.Quantity(1440m, "minutes");
				var i_ = context?.Operators.Subtract(g_, h_);
				var j_ = Encounter?.Period;
				var k_ = FHIRHelpers_4_0_001.ToInterval(j_);
				var l_ = context?.Operators.Start(k_);
				var m_ = context?.Operators.Quantity(1440m, "minutes");
				var n_ = context?.Operators.Add(l_, m_);
				var o_ = context?.Operators.Interval(i_, n_, true, true);
				var p_ = context?.Operators.ElementInInterval<CqlDateTime>(d_, o_, null);
				var q_ = context?.Operators.And(b_, p_);
				var r_ = (Lab?.StatusElement as object);
				var s_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(r_);
				var t_ = "final";
				var u_ = "amended";
				var v_ = "preliminary";
				var w_ = new string[]
				{
					t_,
					u_,
					v_,
				};
				var x_ = (w_ as IEnumerable<string>);
				var y_ = context?.Operators.InList<string>(s_, x_);
				var z_ = context?.Operators.And(q_, y_);
				var aa_ = (bool?)((Lab?.Value as object) == null);
				var ab_ = context?.Operators.Not(aa_);

				return context?.Operators.And(z_, ab_);
			};
			var bu_ = context?.Operators.WhereOrNull<Observation>(LabList, bt_);
			var bv_ = (Observation @this) => @this?.IssuedElement;
			var bw_ = context?.Operators.ListSortBy<Observation>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
			var bx_ = context?.Operators.FirstOfList<Observation>(bw_);
			var by_ = ((bx_?.Value as object) as Quantity);
			var bz_ = FHIRHelpers_4_0_001.ToQuantity(by_);
			var ca_ = context?.Operators.ConvertQuantityToString(bz_);
			var cb_ = (ca_ ?? "");
			var cc_ = context?.Operators.Concatenate(bs_, cb_);
			var cd_ = (cc_ ?? "");
			var ce_ = ("," ?? "");
			var cf_ = context?.Operators.Concatenate(cd_, ce_);
			var cg_ = (cf_ ?? "");
			var ch_ = (Observation Lab) =>
			{
				var ac_ = (bool?)(Lab?.IssuedElement == null);
				var ad_ = context?.Operators.Not(ac_);
				var ae_ = Lab?.IssuedElement;
				var af_ = FHIRHelpers_4_0_001.ToDateTime(ae_);
				var ag_ = Encounter?.Period;
				var ah_ = FHIRHelpers_4_0_001.ToInterval(ag_);
				var ai_ = context?.Operators.Start(ah_);
				var aj_ = context?.Operators.Quantity(1440m, "minutes");
				var ak_ = context?.Operators.Subtract(ai_, aj_);
				var al_ = Encounter?.Period;
				var am_ = FHIRHelpers_4_0_001.ToInterval(al_);
				var an_ = context?.Operators.Start(am_);
				var ao_ = context?.Operators.Quantity(1440m, "minutes");
				var ap_ = context?.Operators.Add(an_, ao_);
				var aq_ = context?.Operators.Interval(ak_, ap_, true, true);
				var ar_ = context?.Operators.ElementInInterval<CqlDateTime>(af_, aq_, null);
				var as_ = context?.Operators.And(ad_, ar_);
				var at_ = (Lab?.StatusElement as object);
				var au_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(at_);
				var av_ = "final";
				var aw_ = "amended";
				var ax_ = "preliminary";
				var ay_ = new string[]
				{
					av_,
					aw_,
					ax_,
				};
				var az_ = (ay_ as IEnumerable<string>);
				var ba_ = context?.Operators.InList<string>(au_, az_);
				var bb_ = context?.Operators.And(as_, ba_);
				var bc_ = (bool?)((Lab?.Value as object) == null);
				var bd_ = context?.Operators.Not(bc_);

				return context?.Operators.And(bb_, bd_);
			};
			var ci_ = context?.Operators.WhereOrNull<Observation>(LabList, ch_);
			var cj_ = (Observation @this) => @this?.IssuedElement;
			var ck_ = context?.Operators.ListSortBy<Observation>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);
			var cl_ = context?.Operators.FirstOfList<Observation>(ck_);
			var cm_ = cl_?.IssuedElement;
			var cn_ = FHIRHelpers_4_0_001.ToDateTime(cm_);
			var co_ = context?.Operators.ConvertDateTimeToString(cn_);
			var cp_ = (co_ ?? "");

			return context?.Operators.Concatenate(cg_, cp_);
		};

		return context?.Operators.SelectOrNull<Encounter, string>(cq_, cr_);
	}


    private IEnumerable<string> Results_Value()
	{
		var a_ = this.Heart_rate();
		var b_ = context?.Operators.ToList<CqlCode>(a_);
		var c_ = context?.DataRetriever.RetrieveByCodes<Observation>(b_, null);
		var d_ = this.FirstPhysicalExamWithEncounterId(c_, "FirstHeartRate");
		var e_ = this.Systolic_blood_pressure();
		var f_ = context?.Operators.ToList<CqlCode>(e_);
		var g_ = context?.DataRetriever.RetrieveByCodes<Observation>(f_, null);
		var h_ = this.FirstPhysicalExamWithEncounterId(g_, "FirstSystolicBP");
		var i_ = this.Body_temperature();
		var j_ = context?.DataRetriever.RetrieveByValueSet<Observation>(i_, null);
		var k_ = this.FirstPhysicalExamWithEncounterId(j_, "FirstTemperature");
		var l_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		var m_ = context?.Operators.ToList<CqlCode>(l_);
		var n_ = context?.DataRetriever.RetrieveByCodes<Observation>(m_, null);
		var o_ = this.FirstPhysicalExamWithEncounterId(n_, "FirstO2Saturation");
		var p_ = this.Hematocrit_lab_test();
		var q_ = context?.DataRetriever.RetrieveByValueSet<Observation>(p_, null);
		var r_ = this.FirstLabTestWithEncounterId(q_, "FirstHematocrit");
		var s_ = this.Platelet_count_lab_test();
		var t_ = context?.DataRetriever.RetrieveByValueSet<Observation>(s_, null);
		var u_ = this.FirstLabTestWithEncounterId(t_, "FirstPlateletCount");
		var v_ = this.White_blood_cells_count_lab_test();
		var w_ = context?.DataRetriever.RetrieveByValueSet<Observation>(v_, null);
		var x_ = this.FirstLabTestWithEncounterId(w_, "FirstWhiteBloodCell");
		var y_ = this.Sodium_lab_test();
		var z_ = context?.DataRetriever.RetrieveByValueSet<Observation>(y_, null);
		var aa_ = this.FirstLabTestWithEncounterId(z_, "FirstSodium");
		var ab_ = this.Bicarbonate_lab_test();
		var ac_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ab_, null);
		var ad_ = this.FirstLabTestWithEncounterId(ac_, "FirstBicarbonate");
		var ae_ = this.Creatinine_lab_test();
		var af_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ae_, null);
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
		var ai_ = (ah_ as IEnumerable<IEnumerable<string>>);

		return context?.Operators.FlattenList<string>(ai_);
	}

    [CqlDeclaration("Results")]
    public IEnumerable<string> Results() => __Results.Value;

    [CqlDeclaration("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		var a_ = context?.Operators.ConvertDateTimeToDate(BirthDateTime);
		var b_ = context?.Operators.ConvertDateTimeToDate(AsOf);

		return context?.Operators.DurationBetween(a_, b_, "year");
	}


    [CqlDeclaration("ToDate")]
    public CqlDateTime ToDate(CqlDateTime Value)
	{
		var a_ = context?.Operators.ComponentFrom(Value, "year");
		var b_ = context?.Operators.ComponentFrom(Value, "month");
		var c_ = context?.Operators.ComponentFrom(Value, "day");
		var d_ = context?.Operators.TimezoneOffsetFrom(Value);

		return context?.Operators.DateTime(a_, b_, c_, (int?)0, (int?)0, (int?)0, (int?)0, d_);
	}


    [CqlDeclaration("LengthOfStay")]
    public int? LengthOfStay(CqlInterval<CqlDateTime> Stay)
	{
		var a_ = context?.Operators.Start(Stay);
		var b_ = context?.Operators.End(Stay);

		return context?.Operators.DifferenceBetween(a_, b_, "day");
	}


    [CqlDeclaration("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var fd_ = TheEncounter;
		var fe_ = new Encounter[]
		{
			fd_,
		};
		var ff_ = (Encounter Visit) =>
		{
			var ec_ = this.Emergency_Department_Visit();
			var ed_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ec_, null);
			var ee_ = (Encounter LastED) =>
			{
				var bi_ = LastED?.Period;
				var bj_ = FHIRHelpers_4_0_001.ToInterval(bi_);
				var bk_ = context?.Operators.End(bj_);
				var bl_ = this.Observation_Services();
				var bm_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(bl_, null);
				var bn_ = (Encounter LastObs) =>
				{
					var a_ = LastObs?.Period;
					var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
					var c_ = context?.Operators.End(b_);
					var d_ = Visit?.Period;
					var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
					var f_ = context?.Operators.Start(e_);
					var g_ = context?.Operators.Quantity(1m, "hour");
					var h_ = context?.Operators.Subtract(f_, g_);
					var i_ = Visit?.Period;
					var j_ = FHIRHelpers_4_0_001.ToInterval(i_);
					var k_ = context?.Operators.Start(j_);
					var l_ = context?.Operators.Interval(h_, k_, true, true);
					var m_ = context?.Operators.ElementInInterval<CqlDateTime>(c_, l_, null);
					var n_ = Visit?.Period;
					var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
					var p_ = context?.Operators.Start(o_);
					var q_ = (bool?)(p_ == null);
					var r_ = context?.Operators.Not(q_);

					return context?.Operators.And(m_, r_);
				};
				var bo_ = context?.Operators.WhereOrNull<Encounter>(bm_, bn_);
				var bp_ = (Encounter @this) =>
				{
					var s_ = @this?.Period;
					var t_ = FHIRHelpers_4_0_001.ToInterval(s_);

					return context?.Operators.End(t_);
				};
				var bq_ = context?.Operators.ListSortBy<Encounter>(bo_, bp_, System.ComponentModel.ListSortDirection.Ascending);
				var br_ = context?.Operators.LastOfList<Encounter>(bq_);
				var bs_ = br_?.Period;
				var bt_ = FHIRHelpers_4_0_001.ToInterval(bs_);
				var bu_ = context?.Operators.Start(bt_);
				var bv_ = Visit?.Period;
				var bw_ = FHIRHelpers_4_0_001.ToInterval(bv_);
				var bx_ = context?.Operators.Start(bw_);
				var by_ = (bu_ ?? bx_);
				var bz_ = context?.Operators.Quantity(1m, "hour");
				var ca_ = context?.Operators.Subtract(by_, bz_);
				var cb_ = this.Observation_Services();
				var cc_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(cb_, null);
				var cd_ = (Encounter LastObs) =>
				{
					var u_ = LastObs?.Period;
					var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
					var w_ = context?.Operators.End(v_);
					var x_ = Visit?.Period;
					var y_ = FHIRHelpers_4_0_001.ToInterval(x_);
					var z_ = context?.Operators.Start(y_);
					var aa_ = context?.Operators.Quantity(1m, "hour");
					var ab_ = context?.Operators.Subtract(z_, aa_);
					var ac_ = Visit?.Period;
					var ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
					var ae_ = context?.Operators.Start(ad_);
					var af_ = context?.Operators.Interval(ab_, ae_, true, true);
					var ag_ = context?.Operators.ElementInInterval<CqlDateTime>(w_, af_, null);
					var ah_ = Visit?.Period;
					var ai_ = FHIRHelpers_4_0_001.ToInterval(ah_);
					var aj_ = context?.Operators.Start(ai_);
					var ak_ = (bool?)(aj_ == null);
					var al_ = context?.Operators.Not(ak_);

					return context?.Operators.And(ag_, al_);
				};
				var ce_ = context?.Operators.WhereOrNull<Encounter>(cc_, cd_);
				var cf_ = (Encounter @this) =>
				{
					var am_ = @this?.Period;
					var an_ = FHIRHelpers_4_0_001.ToInterval(am_);

					return context?.Operators.End(an_);
				};
				var cg_ = context?.Operators.ListSortBy<Encounter>(ce_, cf_, System.ComponentModel.ListSortDirection.Ascending);
				var ch_ = context?.Operators.LastOfList<Encounter>(cg_);
				var ci_ = ch_?.Period;
				var cj_ = FHIRHelpers_4_0_001.ToInterval(ci_);
				var ck_ = context?.Operators.Start(cj_);
				var cl_ = Visit?.Period;
				var cm_ = FHIRHelpers_4_0_001.ToInterval(cl_);
				var cn_ = context?.Operators.Start(cm_);
				var co_ = (ck_ ?? cn_);
				var cp_ = context?.Operators.Interval(ca_, co_, true, true);
				var cq_ = context?.Operators.ElementInInterval<CqlDateTime>(bk_, cp_, null);
				var cr_ = this.Observation_Services();
				var cs_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(cr_, null);
				var ct_ = (Encounter LastObs) =>
				{
					var ao_ = LastObs?.Period;
					var ap_ = FHIRHelpers_4_0_001.ToInterval(ao_);
					var aq_ = context?.Operators.End(ap_);
					var ar_ = Visit?.Period;
					var as_ = FHIRHelpers_4_0_001.ToInterval(ar_);
					var at_ = context?.Operators.Start(as_);
					var au_ = context?.Operators.Quantity(1m, "hour");
					var av_ = context?.Operators.Subtract(at_, au_);
					var aw_ = Visit?.Period;
					var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
					var ay_ = context?.Operators.Start(ax_);
					var az_ = context?.Operators.Interval(av_, ay_, true, true);
					var ba_ = context?.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
					var bb_ = Visit?.Period;
					var bc_ = FHIRHelpers_4_0_001.ToInterval(bb_);
					var bd_ = context?.Operators.Start(bc_);
					var be_ = (bool?)(bd_ == null);
					var bf_ = context?.Operators.Not(be_);

					return context?.Operators.And(ba_, bf_);
				};
				var cu_ = context?.Operators.WhereOrNull<Encounter>(cs_, ct_);
				var cv_ = (Encounter @this) =>
				{
					var bg_ = @this?.Period;
					var bh_ = FHIRHelpers_4_0_001.ToInterval(bg_);

					return context?.Operators.End(bh_);
				};
				var cw_ = context?.Operators.ListSortBy<Encounter>(cu_, cv_, System.ComponentModel.ListSortDirection.Ascending);
				var cx_ = context?.Operators.LastOfList<Encounter>(cw_);
				var cy_ = cx_?.Period;
				var cz_ = FHIRHelpers_4_0_001.ToInterval(cy_);
				var da_ = context?.Operators.Start(cz_);
				var db_ = Visit?.Period;
				var dc_ = FHIRHelpers_4_0_001.ToInterval(db_);
				var dd_ = context?.Operators.Start(dc_);
				var de_ = (bool?)((da_ ?? dd_) == null);
				var df_ = context?.Operators.Not(de_);

				return context?.Operators.And(cq_, df_);
			};
			var ef_ = context?.Operators.WhereOrNull<Encounter>(ed_, ee_);
			var eg_ = (Encounter @this) =>
			{
				var dg_ = @this?.Period;
				var dh_ = FHIRHelpers_4_0_001.ToInterval(dg_);

				return context?.Operators.End(dh_);
			};
			var eh_ = context?.Operators.ListSortBy<Encounter>(ef_, eg_, System.ComponentModel.ListSortDirection.Ascending);
			var ei_ = context?.Operators.LastOfList<Encounter>(eh_);
			var ej_ = ei_?.Period;
			var ek_ = FHIRHelpers_4_0_001.ToInterval(ej_);
			var el_ = context?.Operators.Start(ek_);
			var em_ = this.Observation_Services();
			var en_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(em_, null);
			var eo_ = (Encounter LastObs) =>
			{
				var di_ = LastObs?.Period;
				var dj_ = FHIRHelpers_4_0_001.ToInterval(di_);
				var dk_ = context?.Operators.End(dj_);
				var dl_ = Visit?.Period;
				var dm_ = FHIRHelpers_4_0_001.ToInterval(dl_);
				var dn_ = context?.Operators.Start(dm_);
				var do_ = context?.Operators.Quantity(1m, "hour");
				var dp_ = context?.Operators.Subtract(dn_, do_);
				var dq_ = Visit?.Period;
				var dr_ = FHIRHelpers_4_0_001.ToInterval(dq_);
				var ds_ = context?.Operators.Start(dr_);
				var dt_ = context?.Operators.Interval(dp_, ds_, true, true);
				var du_ = context?.Operators.ElementInInterval<CqlDateTime>(dk_, dt_, null);
				var dv_ = Visit?.Period;
				var dw_ = FHIRHelpers_4_0_001.ToInterval(dv_);
				var dx_ = context?.Operators.Start(dw_);
				var dy_ = (bool?)(dx_ == null);
				var dz_ = context?.Operators.Not(dy_);

				return context?.Operators.And(du_, dz_);
			};
			var ep_ = context?.Operators.WhereOrNull<Encounter>(en_, eo_);
			var eq_ = (Encounter @this) =>
			{
				var ea_ = @this?.Period;
				var eb_ = FHIRHelpers_4_0_001.ToInterval(ea_);

				return context?.Operators.End(eb_);
			};
			var er_ = context?.Operators.ListSortBy<Encounter>(ep_, eq_, System.ComponentModel.ListSortDirection.Ascending);
			var es_ = context?.Operators.LastOfList<Encounter>(er_);
			var et_ = es_?.Period;
			var eu_ = FHIRHelpers_4_0_001.ToInterval(et_);
			var ev_ = context?.Operators.Start(eu_);
			var ew_ = Visit?.Period;
			var ex_ = FHIRHelpers_4_0_001.ToInterval(ew_);
			var ey_ = context?.Operators.Start(ex_);
			var ez_ = (el_ ?? (ev_ ?? ey_));
			var fa_ = Visit?.Period;
			var fb_ = FHIRHelpers_4_0_001.ToInterval(fa_);
			var fc_ = context?.Operators.End(fb_);

			return context?.Operators.Interval(ez_, fc_, true, true);
		};
		var fg_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(fe_, ff_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(fg_);
	}


    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
	{
		var a_ = this.HospitalizationWithObservation(Encounter);

		return this.LengthInDays(a_);
	}


}