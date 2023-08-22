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
[CqlLibrary("HybridHWRFHIR", "1.3.005")]
public class HybridHWRFHIR_1_3_005
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bicarbonate_lab_test;
    internal Lazy<CqlValueSet> __Body_temperature;
    internal Lazy<CqlValueSet> __Body_weight;
    internal Lazy<CqlValueSet> __Creatinine_lab_test;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Ethnicity;
    internal Lazy<CqlValueSet> __Glucose_lab_test;
    internal Lazy<CqlValueSet> __Hematocrit_lab_test;
    internal Lazy<CqlValueSet> __Medicare_payer;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __ONC_Administrative_Sex;
    internal Lazy<CqlValueSet> __Payer;
    internal Lazy<CqlValueSet> __Potassium_lab_test;
    internal Lazy<CqlValueSet> __Race;
    internal Lazy<CqlValueSet> __Sodium_lab_test;
    internal Lazy<CqlValueSet> __White_blood_cells_count_lab_test;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Heart_rate;
    internal Lazy<CqlCode> __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    internal Lazy<CqlCode> __Respiratory_rate;
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
    public HybridHWRFHIR_1_3_005(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __Bicarbonate_lab_test = new Lazy<CqlValueSet>(this.Bicarbonate_lab_test_Value);
        __Body_temperature = new Lazy<CqlValueSet>(this.Body_temperature_Value);
        __Body_weight = new Lazy<CqlValueSet>(this.Body_weight_Value);
        __Creatinine_lab_test = new Lazy<CqlValueSet>(this.Creatinine_lab_test_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Ethnicity = new Lazy<CqlValueSet>(this.Ethnicity_Value);
        __Glucose_lab_test = new Lazy<CqlValueSet>(this.Glucose_lab_test_Value);
        __Hematocrit_lab_test = new Lazy<CqlValueSet>(this.Hematocrit_lab_test_Value);
        __Medicare_payer = new Lazy<CqlValueSet>(this.Medicare_payer_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __ONC_Administrative_Sex = new Lazy<CqlValueSet>(this.ONC_Administrative_Sex_Value);
        __Payer = new Lazy<CqlValueSet>(this.Payer_Value);
        __Potassium_lab_test = new Lazy<CqlValueSet>(this.Potassium_lab_test_Value);
        __Race = new Lazy<CqlValueSet>(this.Race_Value);
        __Sodium_lab_test = new Lazy<CqlValueSet>(this.Sodium_lab_test_Value);
        __White_blood_cells_count_lab_test = new Lazy<CqlValueSet>(this.White_blood_cells_count_lab_test_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Heart_rate = new Lazy<CqlCode>(this.Heart_rate_Value);
        __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new Lazy<CqlCode>(this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value);
        __Respiratory_rate = new Lazy<CqlCode>(this.Respiratory_rate_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", 
			null);

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
    public CqlValueSet Bicarbonate_lab_test() => __Bicarbonate_lab_test.Value;

    private CqlValueSet Body_temperature_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", 
			null);

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
    public CqlValueSet Body_temperature() => __Body_temperature.Value;

    private CqlValueSet Body_weight_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", 
			null);

    [CqlDeclaration("Body weight")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159")]
    public CqlValueSet Body_weight() => __Body_weight.Value;

    private CqlValueSet Creatinine_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", 
			null);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
    public CqlValueSet Creatinine_lab_test() => __Creatinine_lab_test.Value;

    private CqlValueSet Emergency_Department_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", 
			null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Ethnicity_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", 
			null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity() => __Ethnicity.Value;

    private CqlValueSet Glucose_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", 
			null);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hematocrit_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", 
			null);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
    public CqlValueSet Hematocrit_lab_test() => __Hematocrit_lab_test.Value;

    private CqlValueSet Medicare_payer_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", 
			null);

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
    public CqlValueSet Medicare_payer() => __Medicare_payer.Value;

    private CqlValueSet Observation_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", 
			null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet ONC_Administrative_Sex_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", 
			null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex() => __ONC_Administrative_Sex.Value;

    private CqlValueSet Payer_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", 
			null);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer() => __Payer.Value;

    private CqlValueSet Potassium_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", 
			null);

    [CqlDeclaration("Potassium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117")]
    public CqlValueSet Potassium_lab_test() => __Potassium_lab_test.Value;

    private CqlValueSet Race_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", 
			null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race() => __Race.Value;

    private CqlValueSet Sodium_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", 
			null);

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
    public CqlValueSet Sodium_lab_test() => __Sodium_lab_test.Value;

    private CqlValueSet White_blood_cells_count_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", 
			null);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
    public CqlValueSet White_blood_cells_count_lab_test() => __White_blood_cells_count_lab_test.Value;

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode Heart_rate_Value() =>
		new CqlCode("8867-4", 
			"http://loinc.org", 
			null, 
			null);

    [CqlDeclaration("Heart rate")]
    public CqlCode Heart_rate() => __Heart_rate.Value;

    private CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value() =>
		new CqlCode("59408-5", 
			"http://loinc.org", 
			null, 
			null);

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry() => __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry.Value;

    private CqlCode Respiratory_rate_Value() =>
		new CqlCode("9279-1", 
			"http://loinc.org", 
			null, 
			null);

    [CqlDeclaration("Respiratory rate")]
    public CqlCode Respiratory_rate() => __Respiratory_rate.Value;

    private CqlCode Systolic_blood_pressure_Value() =>
		new CqlCode("8480-6", 
			"http://loinc.org", 
			null, 
			null);

    [CqlDeclaration("Systolic blood pressure")]
    public CqlCode Systolic_blood_pressure() => __Systolic_blood_pressure.Value;

    private CqlCode[] LOINC_2_69_Value()
	{
		var a_ = new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
		var b_ = new CqlCode("8867-4", 
			"http://loinc.org", 
			null, 
			null);
		var c_ = new CqlCode("59408-5", 
			"http://loinc.org", 
			null, 
			null);
		var d_ = new CqlCode("9279-1", 
			"http://loinc.org", 
			null, 
			null);
		var e_ = new CqlCode("8480-6", 
			"http://loinc.org", 
			null, 
			null);

		return new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
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
		var g_ = context.ResolveParameter("HybridHWRFHIR-1.3.005", "Measurement Period", f_);

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

    [CqlDeclaration("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var a_ = TheEncounter;
		var b_ = new Encounter[]
		{
			a_,
		};
		var c_ = (Encounter Visit) =>
		{
			var a_ = this.Emergency_Department_Visit();
			var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, null);
			var c_ = (Encounter LastED) =>
			{
				var a_ = LastED?.Period;
				var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
				var c_ = context?.Operators.End(b_);
				var d_ = this.Observation_Services();
				var e_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(d_, null);
				var f_ = (Encounter LastObs) =>
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
				var g_ = context?.Operators.WhereOrNull<Encounter>(e_, f_);
				var h_ = (Encounter @this) =>
				{
					var a_ = @this?.Period;
					var b_ = FHIRHelpers_4_0_001.ToInterval(a_);

					return context?.Operators.End(b_);
				};
				var i_ = context?.Operators.ListSortBy<Encounter>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
				var j_ = context?.Operators.LastOfList<Encounter>(i_);
				var k_ = j_?.Period;
				var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
				var m_ = context?.Operators.Start(l_);
				var n_ = Visit?.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = context?.Operators.Start(o_);
				var q_ = (m_ ?? p_);
				var r_ = context?.Operators.Quantity(1m, "hour");
				var s_ = context?.Operators.Subtract(q_, r_);
				var t_ = this.Observation_Services();
				var u_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(t_, null);
				var v_ = (Encounter LastObs) =>
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
				var w_ = context?.Operators.WhereOrNull<Encounter>(u_, v_);
				var x_ = (Encounter @this) =>
				{
					var a_ = @this?.Period;
					var b_ = FHIRHelpers_4_0_001.ToInterval(a_);

					return context?.Operators.End(b_);
				};
				var y_ = context?.Operators.ListSortBy<Encounter>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
				var z_ = context?.Operators.LastOfList<Encounter>(y_);
				var aa_ = z_?.Period;
				var ab_ = FHIRHelpers_4_0_001.ToInterval(aa_);
				var ac_ = context?.Operators.Start(ab_);
				var ad_ = Visit?.Period;
				var ae_ = FHIRHelpers_4_0_001.ToInterval(ad_);
				var af_ = context?.Operators.Start(ae_);
				var ag_ = (ac_ ?? af_);
				var ah_ = context?.Operators.Interval(s_, ag_, true, true);
				var ai_ = context?.Operators.ElementInInterval<CqlDateTime>(c_, ah_, null);
				var aj_ = this.Observation_Services();
				var ak_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(aj_, null);
				var al_ = (Encounter LastObs) =>
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
				var am_ = context?.Operators.WhereOrNull<Encounter>(ak_, al_);
				var an_ = (Encounter @this) =>
				{
					var a_ = @this?.Period;
					var b_ = FHIRHelpers_4_0_001.ToInterval(a_);

					return context?.Operators.End(b_);
				};
				var ao_ = context?.Operators.ListSortBy<Encounter>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
				var ap_ = context?.Operators.LastOfList<Encounter>(ao_);
				var aq_ = ap_?.Period;
				var ar_ = FHIRHelpers_4_0_001.ToInterval(aq_);
				var as_ = context?.Operators.Start(ar_);
				var at_ = Visit?.Period;
				var au_ = FHIRHelpers_4_0_001.ToInterval(at_);
				var av_ = context?.Operators.Start(au_);
				var aw_ = (bool?)((as_ ?? av_) == null);
				var ax_ = context?.Operators.Not(aw_);

				return context?.Operators.And(ai_, ax_);
			};
			var d_ = context?.Operators.WhereOrNull<Encounter>(b_, c_);
			var e_ = (Encounter @this) =>
			{
				var a_ = @this?.Period;
				var b_ = FHIRHelpers_4_0_001.ToInterval(a_);

				return context?.Operators.End(b_);
			};
			var f_ = context?.Operators.ListSortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
			var g_ = context?.Operators.LastOfList<Encounter>(f_);
			var h_ = g_?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = context?.Operators.Start(i_);
			var k_ = this.Observation_Services();
			var l_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, null);
			var m_ = (Encounter LastObs) =>
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
			var n_ = context?.Operators.WhereOrNull<Encounter>(l_, m_);
			var o_ = (Encounter @this) =>
			{
				var a_ = @this?.Period;
				var b_ = FHIRHelpers_4_0_001.ToInterval(a_);

				return context?.Operators.End(b_);
			};
			var p_ = context?.Operators.ListSortBy<Encounter>(n_, o_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = context?.Operators.LastOfList<Encounter>(p_);
			var r_ = q_?.Period;
			var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			var t_ = context?.Operators.Start(s_);
			var u_ = Visit?.Period;
			var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
			var w_ = context?.Operators.Start(v_);
			var x_ = (j_ ?? (t_ ?? w_));
			var y_ = Visit?.Period;
			var z_ = FHIRHelpers_4_0_001.ToInterval(y_);
			var aa_ = context?.Operators.End(z_);

			return context?.Operators.Interval(x_, aa_, true, true);
		};
		var d_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(b_, c_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
	}


    [CqlDeclaration("LengthInDays")]
    public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context?.Operators.Start(Value);
		var b_ = context?.Operators.End(Value);

		return context?.Operators.DifferenceBetween(a_, b_, "day");
	}


    private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = (Encounter _InpatientEncounter) =>
		{
			var a_ = this.Medicare_payer();

			return context?.DataRetriever.RetrieveByValueSet<Coverage>(a_, null);
		};
		var d_ = (Encounter _InpatientEncounter, Coverage _Payer) =>
		{
			var a_ = _InpatientEncounter;
			var b_ = _Payer;

			return new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = a_,
				Payer = b_,
			};
		};
		var e_ = context?.Operators.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(b_, c_, d_);
		var f_ = (Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) =>
		{
			var a_ = (tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
			var f_ = this.HospitalizationWithObservation(e_);
			var g_ = this.LengthInDays(f_);
			var h_ = (g_ as object);
			var i_ = ((int?)365 as object);
			var j_ = context?.Operators.Less(h_, i_);
			var k_ = context?.Operators.And(d_, j_);
			var l_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.Period;
			var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
			var n_ = context?.Operators.End(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, o_, "day");
			var q_ = context?.Operators.And(k_, p_);
			var r_ = (this.Patient()?.BirthDateElement?.Value as object);
			var s_ = context?.Operators?.TypeConverter.Convert<CqlDate>(r_);
			var t_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var v_ = context?.Operators.Start(u_);
			var w_ = context?.Operators.DateFrom(v_);
			var x_ = context?.Operators.CalculateAgeAt(s_, w_, "year");
			var y_ = (x_ as object);
			var z_ = ((int?)65 as object);
			var aa_ = context?.Operators.GreaterOrEqual(y_, z_);

			return context?.Operators.And(q_, aa_);
		};
		var g_ = context?.Operators.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(e_, f_);
		var h_ = (Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) => tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(g_, h_);
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
		var a_ = this.Inpatient_Encounters();
		var b_ = (Encounter Encounter) =>
		{
			var a_ = ("\r\n" ?? "");
			var b_ = (CCDE ?? "");
			var c_ = context?.Operators.Concatenate(a_, b_);
			var d_ = (c_ ?? "");
			var e_ = ("," ?? "");
			var f_ = context?.Operators.Concatenate(d_, e_);
			var g_ = (f_ ?? "");
			var h_ = (Encounter?.IdElement as object);
			var i_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(h_);
			var j_ = (i_ ?? "");
			var k_ = context?.Operators.Concatenate(g_, j_);
			var l_ = (k_ ?? "");
			var m_ = ("," ?? "");
			var n_ = context?.Operators.Concatenate(l_, m_);
			var o_ = (n_ ?? "");
			var p_ = (Observation Exam) =>
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
				var w_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(v_);
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
			var q_ = context?.Operators.WhereOrNull<Observation>(ExamList, p_);
			var r_ = (Observation @this) =>
			{
				var a_ = (@this?.Effective as object);
				var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);

				return context?.Operators.Start(b_);
			};
			var s_ = context?.Operators.ListSortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context?.Operators.FirstOfList<Observation>(s_);
			var u_ = ((t_?.Value as object) as Quantity);
			var v_ = FHIRHelpers_4_0_001.ToQuantity(u_);
			var w_ = context?.Operators.ConvertQuantityToString(v_);
			var x_ = (w_ ?? "");
			var y_ = context?.Operators.Concatenate(o_, x_);
			var z_ = (y_ ?? "");
			var aa_ = ("," ?? "");
			var ab_ = context?.Operators.Concatenate(z_, aa_);
			var ac_ = (ab_ ?? "");
			var ad_ = (Observation Exam) =>
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
				var w_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(v_);
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
			var ae_ = context?.Operators.WhereOrNull<Observation>(ExamList, ad_);
			var af_ = (Observation @this) =>
			{
				var a_ = (@this?.Effective as object);
				var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);

				return context?.Operators.Start(b_);
			};
			var ag_ = context?.Operators.ListSortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			var ah_ = context?.Operators.FirstOfList<Observation>(ag_);
			var ai_ = (ah_?.Effective as object);
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ai_);
			var ak_ = context?.Operators.Start(aj_);
			var al_ = context?.Operators.ConvertDateTimeToString(ak_);
			var am_ = (al_ ?? "");

			return context?.Operators.Concatenate(ac_, am_);
		};

		return context?.Operators.SelectOrNull<Encounter, string>(a_, b_);
	}


    [CqlDeclaration("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(IEnumerable<Observation> ExamList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		var b_ = (Encounter Encounter) =>
		{
			var a_ = ("\r\n" ?? "");
			var b_ = (CCDE ?? "");
			var c_ = context?.Operators.Concatenate(a_, b_);
			var d_ = (c_ ?? "");
			var e_ = ("," ?? "");
			var f_ = context?.Operators.Concatenate(d_, e_);
			var g_ = (f_ ?? "");
			var h_ = (Encounter?.IdElement as object);
			var i_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(h_);
			var j_ = (i_ ?? "");
			var k_ = context?.Operators.Concatenate(g_, j_);
			var l_ = (k_ ?? "");
			var m_ = ("," ?? "");
			var n_ = context?.Operators.Concatenate(l_, m_);
			var o_ = (n_ ?? "");
			var p_ = (Observation Exam) =>
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
				var q_ = context?.Operators.Quantity(1440m, "minutes");
				var r_ = context?.Operators.Add(p_, q_);
				var s_ = context?.Operators.Interval(m_, r_, true, true);
				var t_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, s_, null);
				var u_ = context?.Operators.And(e_, t_);
				var v_ = (Exam?.StatusElement as object);
				var w_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(v_);
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
			var q_ = context?.Operators.WhereOrNull<Observation>(ExamList, p_);
			var r_ = (Observation @this) =>
			{
				var a_ = (@this?.Effective as object);
				var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);

				return context?.Operators.Start(b_);
			};
			var s_ = context?.Operators.ListSortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context?.Operators.FirstOfList<Observation>(s_);
			var u_ = ((t_?.Value as object) as Quantity);
			var v_ = FHIRHelpers_4_0_001.ToQuantity(u_);
			var w_ = context?.Operators.ConvertQuantityToString(v_);
			var x_ = (w_ ?? "");
			var y_ = context?.Operators.Concatenate(o_, x_);
			var z_ = (y_ ?? "");
			var aa_ = ("," ?? "");
			var ab_ = context?.Operators.Concatenate(z_, aa_);
			var ac_ = (ab_ ?? "");
			var ad_ = (Observation Exam) =>
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
				var q_ = context?.Operators.Quantity(1440m, "minutes");
				var r_ = context?.Operators.Add(p_, q_);
				var s_ = context?.Operators.Interval(m_, r_, true, true);
				var t_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, s_, null);
				var u_ = context?.Operators.And(e_, t_);
				var v_ = (Exam?.StatusElement as object);
				var w_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(v_);
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
			var ae_ = context?.Operators.WhereOrNull<Observation>(ExamList, ad_);
			var af_ = (Observation @this) =>
			{
				var a_ = (@this?.Effective as object);
				var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);

				return context?.Operators.Start(b_);
			};
			var ag_ = context?.Operators.ListSortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			var ah_ = context?.Operators.FirstOfList<Observation>(ag_);
			var ai_ = (ah_?.Effective as object);
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ai_);
			var ak_ = context?.Operators.Start(aj_);
			var al_ = context?.Operators.ConvertDateTimeToString(ak_);
			var am_ = (al_ ?? "");

			return context?.Operators.Concatenate(ac_, am_);
		};

		return context?.Operators.SelectOrNull<Encounter, string>(a_, b_);
	}


    [CqlDeclaration("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		var b_ = (Encounter Encounter) =>
		{
			var a_ = ("\r\n" ?? "");
			var b_ = (CCDE ?? "");
			var c_ = context?.Operators.Concatenate(a_, b_);
			var d_ = (c_ ?? "");
			var e_ = ("," ?? "");
			var f_ = context?.Operators.Concatenate(d_, e_);
			var g_ = (f_ ?? "");
			var h_ = (Encounter?.IdElement as object);
			var i_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(h_);
			var j_ = (i_ ?? "");
			var k_ = context?.Operators.Concatenate(g_, j_);
			var l_ = (k_ ?? "");
			var m_ = ("," ?? "");
			var n_ = context?.Operators.Concatenate(l_, m_);
			var o_ = (n_ ?? "");
			var p_ = (Observation Lab) =>
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
				var s_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(r_);
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
			var q_ = context?.Operators.WhereOrNull<Observation>(LabList, p_);
			var r_ = (Observation @this) => @this?.IssuedElement;
			var s_ = context?.Operators.ListSortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context?.Operators.FirstOfList<Observation>(s_);
			var u_ = ((t_?.Value as object) as Quantity);
			var v_ = FHIRHelpers_4_0_001.ToQuantity(u_);
			var w_ = context?.Operators.ConvertQuantityToString(v_);
			var x_ = (w_ ?? "");
			var y_ = context?.Operators.Concatenate(o_, x_);
			var z_ = (y_ ?? "");
			var aa_ = ("," ?? "");
			var ab_ = context?.Operators.Concatenate(z_, aa_);
			var ac_ = (ab_ ?? "");
			var ad_ = (Observation Lab) =>
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
				var s_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(r_);
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
			var ae_ = context?.Operators.WhereOrNull<Observation>(LabList, ad_);
			var af_ = (Observation @this) => @this?.IssuedElement;
			var ag_ = context?.Operators.ListSortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			var ah_ = context?.Operators.FirstOfList<Observation>(ag_);
			var ai_ = ah_?.IssuedElement;
			var aj_ = FHIRHelpers_4_0_001.ToDateTime(ai_);
			var ak_ = context?.Operators.ConvertDateTimeToString(aj_);
			var al_ = (ak_ ?? "");

			return context?.Operators.Concatenate(ac_, al_);
		};

		return context?.Operators.SelectOrNull<Encounter, string>(a_, b_);
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
		var i_ = this.Respiratory_rate();
		var j_ = context?.Operators.ToList<CqlCode>(i_);
		var k_ = context?.DataRetriever.RetrieveByCodes<Observation>(j_, null);
		var l_ = this.FirstPhysicalExamWithEncounterId(k_, "FirstRespRate");
		var m_ = this.Body_temperature();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Observation>(m_, null);
		var o_ = this.FirstPhysicalExamWithEncounterId(n_, "FirstTemperature");
		var p_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		var q_ = context?.Operators.ToList<CqlCode>(p_);
		var r_ = context?.DataRetriever.RetrieveByCodes<Observation>(q_, null);
		var s_ = this.FirstPhysicalExamWithEncounterId(r_, "FirstO2Saturation");
		var t_ = this.Body_weight();
		var u_ = context?.DataRetriever.RetrieveByValueSet<Observation>(t_, null);
		var v_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(u_, "FirstWeight");
		var w_ = this.Hematocrit_lab_test();
		var x_ = context?.DataRetriever.RetrieveByValueSet<Observation>(w_, null);
		var y_ = this.FirstLabTestWithEncounterId(x_, "FirstHematocrit");
		var z_ = this.White_blood_cells_count_lab_test();
		var aa_ = context?.DataRetriever.RetrieveByValueSet<Observation>(z_, null);
		var ab_ = this.FirstLabTestWithEncounterId(aa_, "FirstWhiteBloodCell");
		var ac_ = this.Potassium_lab_test();
		var ad_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ac_, null);
		var ae_ = this.FirstLabTestWithEncounterId(ad_, "FirstPotassium");
		var af_ = this.Sodium_lab_test();
		var ag_ = context?.DataRetriever.RetrieveByValueSet<Observation>(af_, null);
		var ah_ = this.FirstLabTestWithEncounterId(ag_, "FirstSodium");
		var ai_ = this.Bicarbonate_lab_test();
		var aj_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ai_, null);
		var ak_ = this.FirstLabTestWithEncounterId(aj_, "FirstBicarbonate");
		var al_ = this.Creatinine_lab_test();
		var am_ = context?.DataRetriever.RetrieveByValueSet<Observation>(al_, null);
		var an_ = this.FirstLabTestWithEncounterId(am_, "FirstCreatinine");
		var ao_ = this.Glucose_lab_test();
		var ap_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ao_, null);
		var aq_ = this.FirstLabTestWithEncounterId(ap_, "FirstGlucose");
		var ar_ = new IEnumerable<string>[]
		{
			d_,
			h_,
			l_,
			o_,
			s_,
			v_,
			y_,
			ab_,
			ae_,
			ah_,
			ak_,
			an_,
			aq_,
		};
		var as_ = (ar_ as IEnumerable<IEnumerable<string>>);

		return context?.Operators.FlattenList<string>(as_);
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


    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
	{
		var a_ = this.HospitalizationWithObservation(Encounter);

		return this.LengthInDays(a_);
	}


}