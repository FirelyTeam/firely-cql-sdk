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
		var al_ = this.Encounter_Inpatient();
		var am_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(al_, null);
		var an_ = (Encounter _InpatientEncounter) =>
		{
			var a_ = this.Medicare_payer();

			return context?.DataRetriever.RetrieveByValueSet<Coverage>(a_, null);
		};
		var ao_ = (Encounter _InpatientEncounter, Coverage _Payer) =>
		{
			var b_ = _InpatientEncounter;
			var c_ = _Payer;

			return new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = b_,
				Payer = c_,
			};
		};
		var ap_ = context?.Operators.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(am_, an_, ao_);
		var aq_ = (Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) =>
		{
			var d_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
			var e_ = d_?.StatusElement;
			var f_ = (e_ as object);
			var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
			var h_ = (g_ as object);
			var i_ = context?.Operators.Equal(h_, ("finished" as object));
			var j_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(j_);
			var l_ = this.LengthInDays(k_);
			var m_ = l_;
			var n_ = (int?)365;
			var o_ = n_;
			var p_ = context?.Operators.Less(m_, o_);
			var q_ = context?.Operators.And(i_, p_);
			var r_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
			var s_ = r_?.Period;
			var t_ = FHIRHelpers_4_0_001.ToInterval(s_);
			var u_ = context?.Operators.End(t_);
			var v_ = this.Measurement_Period();
			var w_ = context?.Operators.ElementInInterval<CqlDateTime>(u_, v_, "day");
			var x_ = context?.Operators.And(q_, w_);
			var y_ = this.Patient();
			var z_ = y_?.BirthDateElement;
			var aa_ = z_?.Value;
			var ab_ = (aa_ as object);
			var ac_ = context?.Operators?.TypeConverter.Convert<CqlDate>(ab_);
			var ad_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
			var ae_ = ad_?.Period;
			var af_ = FHIRHelpers_4_0_001.ToInterval(ae_);
			var ag_ = context?.Operators.Start(af_);
			var ah_ = context?.Operators.DateFrom(ag_);
			var ai_ = context?.Operators.CalculateAgeAt(ac_, ah_, "year");
			var aj_ = context?.Operators.Interval((int?)65, (int?)94, true, true);
			var ak_ = context?.Operators.ElementInInterval<int?>(ai_, aj_, null);

			return context?.Operators.And(x_, ak_);
		};
		var ar_ = context?.Operators.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(ap_, aq_);
		var as_ = (Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) => tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;

		return context?.Operators.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(ar_, as_);
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
		var dz_ = this.Inpatient_Encounters();
		var ea_ = (Encounter Encounter) =>
		{
			var ci_ = ("\r\n" ?? "");
			var cj_ = (CCDE ?? "");
			var ck_ = context?.Operators.Concatenate(ci_, cj_);
			var cl_ = (ck_ ?? "");
			var cm_ = ("," ?? "");
			var cn_ = context?.Operators.Concatenate(cl_, cm_);
			var co_ = (cn_ ?? "");
			var cp_ = Encounter?.IdElement;
			var cq_ = (cp_ as object);
			var cr_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(cq_);
			var cs_ = (cr_ ?? "");
			var ct_ = context?.Operators.Concatenate(co_, cs_);
			var cu_ = (ct_ ?? "");
			var cv_ = (" , " ?? "");
			var cw_ = context?.Operators.Concatenate(cu_, cv_);
			var cx_ = (cw_ ?? "");
			var cy_ = (Observation Exam) =>
			{
				var a_ = Exam?.Effective;
				var b_ = (a_ as object);
				var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(b_);
				var d_ = context?.Operators.Start(c_);
				var e_ = (d_ == null);
				var f_ = (bool?)e_;
				var g_ = context?.Operators.Not(f_);
				var h_ = Exam?.Effective;
				var i_ = (h_ as object);
				var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
				var k_ = context?.Operators.Start(j_);
				var l_ = Encounter?.Period;
				var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
				var n_ = context?.Operators.Start(m_);
				var o_ = context?.Operators.Quantity(1440m, "minutes");
				var p_ = context?.Operators.Subtract(n_, o_);
				var q_ = Encounter?.Period;
				var r_ = FHIRHelpers_4_0_001.ToInterval(q_);
				var s_ = context?.Operators.Start(r_);
				var t_ = context?.Operators.Quantity(120m, "minutes");
				var u_ = context?.Operators.Add(s_, t_);
				var v_ = context?.Operators.Interval(p_, u_, true, true);
				var w_ = context?.Operators.ElementInInterval<CqlDateTime>(k_, v_, null);
				var x_ = context?.Operators.And(g_, w_);
				var y_ = Exam?.StatusElement;
				var z_ = (y_ as object);
				var aa_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(z_);
				var ab_ = "final";
				var ac_ = "amended";
				var ad_ = "preliminary";
				var ae_ = new string[]
				{
					ab_,
					ac_,
					ad_,
				};
				var af_ = (ae_ as IEnumerable<string>);
				var ag_ = context?.Operators.InList<string>(aa_, af_);
				var ah_ = context?.Operators.And(x_, ag_);
				var ai_ = Exam?.Value;
				var aj_ = (ai_ as object);
				var ak_ = (aj_ == null);
				var al_ = (bool?)ak_;
				var am_ = context?.Operators.Not(al_);

				return context?.Operators.And(ah_, am_);
			};
			var cz_ = context?.Operators.WhereOrNull<Observation>(ExamList, cy_);
			var da_ = (Observation @this) =>
			{
				var an_ = @this?.Effective;
				var ao_ = (an_ as object);
				var ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ao_);
				var aq_ = context?.Operators.Start(ap_);

				return aq_;
			};
			var db_ = context?.Operators.ListSortBy<Observation>(cz_, da_, System.ComponentModel.ListSortDirection.Ascending);
			var dc_ = context?.Operators.FirstOfList<Observation>(db_);
			var dd_ = dc_?.Value;
			var de_ = (dd_ as object);
			var df_ = (de_ as Quantity);
			var dg_ = FHIRHelpers_4_0_001.ToQuantity(df_);
			var dh_ = context?.Operators.ConvertQuantityToString(dg_);
			var di_ = (dh_ ?? "");
			var dj_ = context?.Operators.Concatenate(cx_, di_);
			var dk_ = (dj_ ?? "");
			var dl_ = ("," ?? "");
			var dm_ = context?.Operators.Concatenate(dk_, dl_);
			var dn_ = (dm_ ?? "");
			var do_ = (Observation Exam) =>
			{
				var ar_ = Exam?.Effective;
				var as_ = (ar_ as object);
				var at_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(as_);
				var au_ = context?.Operators.Start(at_);
				var av_ = (au_ == null);
				var aw_ = (bool?)av_;
				var ax_ = context?.Operators.Not(aw_);
				var ay_ = Exam?.Effective;
				var az_ = (ay_ as object);
				var ba_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(az_);
				var bb_ = context?.Operators.Start(ba_);
				var bc_ = Encounter?.Period;
				var bd_ = FHIRHelpers_4_0_001.ToInterval(bc_);
				var be_ = context?.Operators.Start(bd_);
				var bf_ = context?.Operators.Quantity(1440m, "minutes");
				var bg_ = context?.Operators.Subtract(be_, bf_);
				var bh_ = Encounter?.Period;
				var bi_ = FHIRHelpers_4_0_001.ToInterval(bh_);
				var bj_ = context?.Operators.Start(bi_);
				var bk_ = context?.Operators.Quantity(120m, "minutes");
				var bl_ = context?.Operators.Add(bj_, bk_);
				var bm_ = context?.Operators.Interval(bg_, bl_, true, true);
				var bn_ = context?.Operators.ElementInInterval<CqlDateTime>(bb_, bm_, null);
				var bo_ = context?.Operators.And(ax_, bn_);
				var bp_ = Exam?.StatusElement;
				var bq_ = (bp_ as object);
				var br_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(bq_);
				var bs_ = "final";
				var bt_ = "amended";
				var bu_ = "preliminary";
				var bv_ = new string[]
				{
					bs_,
					bt_,
					bu_,
				};
				var bw_ = (bv_ as IEnumerable<string>);
				var bx_ = context?.Operators.InList<string>(br_, bw_);
				var by_ = context?.Operators.And(bo_, bx_);
				var bz_ = Exam?.Value;
				var ca_ = (bz_ as object);
				var cb_ = (ca_ == null);
				var cc_ = (bool?)cb_;
				var cd_ = context?.Operators.Not(cc_);

				return context?.Operators.And(by_, cd_);
			};
			var dp_ = context?.Operators.WhereOrNull<Observation>(ExamList, do_);
			var dq_ = (Observation @this) =>
			{
				var ce_ = @this?.Effective;
				var cf_ = (ce_ as object);
				var cg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cf_);
				var ch_ = context?.Operators.Start(cg_);

				return ch_;
			};
			var dr_ = context?.Operators.ListSortBy<Observation>(dp_, dq_, System.ComponentModel.ListSortDirection.Ascending);
			var ds_ = context?.Operators.FirstOfList<Observation>(dr_);
			var dt_ = ds_?.Effective;
			var du_ = (dt_ as object);
			var dv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(du_);
			var dw_ = context?.Operators.Start(dv_);
			var dx_ = context?.Operators.ConvertDateTimeToString(dw_);
			var dy_ = (dx_ ?? "");

			return context?.Operators.Concatenate(dn_, dy_);
		};

		return context?.Operators.SelectOrNull<Encounter, string>(dz_, ea_);
	}


    [CqlDeclaration("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		var dh_ = this.Inpatient_Encounters();
		var di_ = (Encounter Encounter) =>
		{
			var bs_ = ("\r\n" ?? "");
			var bt_ = (CCDE ?? "");
			var bu_ = context?.Operators.Concatenate(bs_, bt_);
			var bv_ = (bu_ ?? "");
			var bw_ = ("," ?? "");
			var bx_ = context?.Operators.Concatenate(bv_, bw_);
			var by_ = (bx_ ?? "");
			var bz_ = Encounter?.IdElement;
			var ca_ = (bz_ as object);
			var cb_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ca_);
			var cc_ = (cb_ ?? "");
			var cd_ = context?.Operators.Concatenate(by_, cc_);
			var ce_ = (cd_ ?? "");
			var cf_ = ("," ?? "");
			var cg_ = context?.Operators.Concatenate(ce_, cf_);
			var ch_ = (cg_ ?? "");
			var ci_ = (Observation Lab) =>
			{
				var a_ = Lab?.IssuedElement;
				var b_ = (a_ == null);
				var c_ = (bool?)b_;
				var d_ = context?.Operators.Not(c_);
				var e_ = Lab?.IssuedElement;
				var f_ = FHIRHelpers_4_0_001.ToDateTime(e_);
				var g_ = Encounter?.Period;
				var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
				var i_ = context?.Operators.Start(h_);
				var j_ = context?.Operators.Quantity(1440m, "minutes");
				var k_ = context?.Operators.Subtract(i_, j_);
				var l_ = Encounter?.Period;
				var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
				var n_ = context?.Operators.Start(m_);
				var o_ = context?.Operators.Quantity(1440m, "minutes");
				var p_ = context?.Operators.Add(n_, o_);
				var q_ = context?.Operators.Interval(k_, p_, true, true);
				var r_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, q_, null);
				var s_ = context?.Operators.And(d_, r_);
				var t_ = Lab?.StatusElement;
				var u_ = (t_ as object);
				var v_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(u_);
				var w_ = "final";
				var x_ = "amended";
				var y_ = "preliminary";
				var z_ = new string[]
				{
					w_,
					x_,
					y_,
				};
				var aa_ = (z_ as IEnumerable<string>);
				var ab_ = context?.Operators.InList<string>(v_, aa_);
				var ac_ = context?.Operators.And(s_, ab_);
				var ad_ = Lab?.Value;
				var ae_ = (ad_ as object);
				var af_ = (ae_ == null);
				var ag_ = (bool?)af_;
				var ah_ = context?.Operators.Not(ag_);

				return context?.Operators.And(ac_, ah_);
			};
			var cj_ = context?.Operators.WhereOrNull<Observation>(LabList, ci_);
			var ck_ = (Observation @this) =>
			{
				var ai_ = @this?.IssuedElement;

				return ai_;
			};
			var cl_ = context?.Operators.ListSortBy<Observation>(cj_, ck_, System.ComponentModel.ListSortDirection.Ascending);
			var cm_ = context?.Operators.FirstOfList<Observation>(cl_);
			var cn_ = cm_?.Value;
			var co_ = (cn_ as object);
			var cp_ = (co_ as Quantity);
			var cq_ = FHIRHelpers_4_0_001.ToQuantity(cp_);
			var cr_ = context?.Operators.ConvertQuantityToString(cq_);
			var cs_ = (cr_ ?? "");
			var ct_ = context?.Operators.Concatenate(ch_, cs_);
			var cu_ = (ct_ ?? "");
			var cv_ = ("," ?? "");
			var cw_ = context?.Operators.Concatenate(cu_, cv_);
			var cx_ = (cw_ ?? "");
			var cy_ = (Observation Lab) =>
			{
				var aj_ = Lab?.IssuedElement;
				var ak_ = (aj_ == null);
				var al_ = (bool?)ak_;
				var am_ = context?.Operators.Not(al_);
				var an_ = Lab?.IssuedElement;
				var ao_ = FHIRHelpers_4_0_001.ToDateTime(an_);
				var ap_ = Encounter?.Period;
				var aq_ = FHIRHelpers_4_0_001.ToInterval(ap_);
				var ar_ = context?.Operators.Start(aq_);
				var as_ = context?.Operators.Quantity(1440m, "minutes");
				var at_ = context?.Operators.Subtract(ar_, as_);
				var au_ = Encounter?.Period;
				var av_ = FHIRHelpers_4_0_001.ToInterval(au_);
				var aw_ = context?.Operators.Start(av_);
				var ax_ = context?.Operators.Quantity(1440m, "minutes");
				var ay_ = context?.Operators.Add(aw_, ax_);
				var az_ = context?.Operators.Interval(at_, ay_, true, true);
				var ba_ = context?.Operators.ElementInInterval<CqlDateTime>(ao_, az_, null);
				var bb_ = context?.Operators.And(am_, ba_);
				var bc_ = Lab?.StatusElement;
				var bd_ = (bc_ as object);
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
				var bl_ = context?.Operators.And(bb_, bk_);
				var bm_ = Lab?.Value;
				var bn_ = (bm_ as object);
				var bo_ = (bn_ == null);
				var bp_ = (bool?)bo_;
				var bq_ = context?.Operators.Not(bp_);

				return context?.Operators.And(bl_, bq_);
			};
			var cz_ = context?.Operators.WhereOrNull<Observation>(LabList, cy_);
			var da_ = (Observation @this) =>
			{
				var br_ = @this?.IssuedElement;

				return br_;
			};
			var db_ = context?.Operators.ListSortBy<Observation>(cz_, da_, System.ComponentModel.ListSortDirection.Ascending);
			var dc_ = context?.Operators.FirstOfList<Observation>(db_);
			var dd_ = dc_?.IssuedElement;
			var de_ = FHIRHelpers_4_0_001.ToDateTime(dd_);
			var df_ = context?.Operators.ConvertDateTimeToString(de_);
			var dg_ = (df_ ?? "");

			return context?.Operators.Concatenate(cx_, dg_);
		};

		return context?.Operators.SelectOrNull<Encounter, string>(dh_, di_);
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
		var fp_ = TheEncounter;
		var fq_ = new Encounter[]
		{
			fp_,
		};
		var fr_ = (Encounter Visit) =>
		{
			var en_ = this.Emergency_Department_Visit();
			var eo_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(en_, null);
			var ep_ = (Encounter LastED) =>
			{
				var bo_ = LastED?.Period;
				var bp_ = FHIRHelpers_4_0_001.ToInterval(bo_);
				var bq_ = context?.Operators.End(bp_);
				var br_ = this.Observation_Services();
				var bs_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(br_, null);
				var bt_ = (Encounter LastObs) =>
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
					var q_ = (p_ == null);
					var r_ = (bool?)q_;
					var s_ = context?.Operators.Not(r_);

					return context?.Operators.And(m_, s_);
				};
				var bu_ = context?.Operators.WhereOrNull<Encounter>(bs_, bt_);
				var bv_ = (Encounter @this) =>
				{
					var t_ = @this?.Period;
					var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
					var v_ = context?.Operators.End(u_);

					return v_;
				};
				var bw_ = context?.Operators.ListSortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				var bx_ = context?.Operators.LastOfList<Encounter>(bw_);
				var by_ = bx_?.Period;
				var bz_ = FHIRHelpers_4_0_001.ToInterval(by_);
				var ca_ = context?.Operators.Start(bz_);
				var cb_ = Visit?.Period;
				var cc_ = FHIRHelpers_4_0_001.ToInterval(cb_);
				var cd_ = context?.Operators.Start(cc_);
				var ce_ = (ca_ ?? cd_);
				var cf_ = context?.Operators.Quantity(1m, "hour");
				var cg_ = context?.Operators.Subtract(ce_, cf_);
				var ch_ = this.Observation_Services();
				var ci_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ch_, null);
				var cj_ = (Encounter LastObs) =>
				{
					var w_ = LastObs?.Period;
					var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
					var y_ = context?.Operators.End(x_);
					var z_ = Visit?.Period;
					var aa_ = FHIRHelpers_4_0_001.ToInterval(z_);
					var ab_ = context?.Operators.Start(aa_);
					var ac_ = context?.Operators.Quantity(1m, "hour");
					var ad_ = context?.Operators.Subtract(ab_, ac_);
					var ae_ = Visit?.Period;
					var af_ = FHIRHelpers_4_0_001.ToInterval(ae_);
					var ag_ = context?.Operators.Start(af_);
					var ah_ = context?.Operators.Interval(ad_, ag_, true, true);
					var ai_ = context?.Operators.ElementInInterval<CqlDateTime>(y_, ah_, null);
					var aj_ = Visit?.Period;
					var ak_ = FHIRHelpers_4_0_001.ToInterval(aj_);
					var al_ = context?.Operators.Start(ak_);
					var am_ = (al_ == null);
					var an_ = (bool?)am_;
					var ao_ = context?.Operators.Not(an_);

					return context?.Operators.And(ai_, ao_);
				};
				var ck_ = context?.Operators.WhereOrNull<Encounter>(ci_, cj_);
				var cl_ = (Encounter @this) =>
				{
					var ap_ = @this?.Period;
					var aq_ = FHIRHelpers_4_0_001.ToInterval(ap_);
					var ar_ = context?.Operators.End(aq_);

					return ar_;
				};
				var cm_ = context?.Operators.ListSortBy<Encounter>(ck_, cl_, System.ComponentModel.ListSortDirection.Ascending);
				var cn_ = context?.Operators.LastOfList<Encounter>(cm_);
				var co_ = cn_?.Period;
				var cp_ = FHIRHelpers_4_0_001.ToInterval(co_);
				var cq_ = context?.Operators.Start(cp_);
				var cr_ = Visit?.Period;
				var cs_ = FHIRHelpers_4_0_001.ToInterval(cr_);
				var ct_ = context?.Operators.Start(cs_);
				var cu_ = (cq_ ?? ct_);
				var cv_ = context?.Operators.Interval(cg_, cu_, true, true);
				var cw_ = context?.Operators.ElementInInterval<CqlDateTime>(bq_, cv_, null);
				var cx_ = this.Observation_Services();
				var cy_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(cx_, null);
				var cz_ = (Encounter LastObs) =>
				{
					var as_ = LastObs?.Period;
					var at_ = FHIRHelpers_4_0_001.ToInterval(as_);
					var au_ = context?.Operators.End(at_);
					var av_ = Visit?.Period;
					var aw_ = FHIRHelpers_4_0_001.ToInterval(av_);
					var ax_ = context?.Operators.Start(aw_);
					var ay_ = context?.Operators.Quantity(1m, "hour");
					var az_ = context?.Operators.Subtract(ax_, ay_);
					var ba_ = Visit?.Period;
					var bb_ = FHIRHelpers_4_0_001.ToInterval(ba_);
					var bc_ = context?.Operators.Start(bb_);
					var bd_ = context?.Operators.Interval(az_, bc_, true, true);
					var be_ = context?.Operators.ElementInInterval<CqlDateTime>(au_, bd_, null);
					var bf_ = Visit?.Period;
					var bg_ = FHIRHelpers_4_0_001.ToInterval(bf_);
					var bh_ = context?.Operators.Start(bg_);
					var bi_ = (bh_ == null);
					var bj_ = (bool?)bi_;
					var bk_ = context?.Operators.Not(bj_);

					return context?.Operators.And(be_, bk_);
				};
				var da_ = context?.Operators.WhereOrNull<Encounter>(cy_, cz_);
				var db_ = (Encounter @this) =>
				{
					var bl_ = @this?.Period;
					var bm_ = FHIRHelpers_4_0_001.ToInterval(bl_);
					var bn_ = context?.Operators.End(bm_);

					return bn_;
				};
				var dc_ = context?.Operators.ListSortBy<Encounter>(da_, db_, System.ComponentModel.ListSortDirection.Ascending);
				var dd_ = context?.Operators.LastOfList<Encounter>(dc_);
				var de_ = dd_?.Period;
				var df_ = FHIRHelpers_4_0_001.ToInterval(de_);
				var dg_ = context?.Operators.Start(df_);
				var dh_ = Visit?.Period;
				var di_ = FHIRHelpers_4_0_001.ToInterval(dh_);
				var dj_ = context?.Operators.Start(di_);
				var dk_ = (dg_ ?? dj_);
				var dl_ = (dk_ == null);
				var dm_ = (bool?)dl_;
				var dn_ = context?.Operators.Not(dm_);

				return context?.Operators.And(cw_, dn_);
			};
			var eq_ = context?.Operators.WhereOrNull<Encounter>(eo_, ep_);
			var er_ = (Encounter @this) =>
			{
				var do_ = @this?.Period;
				var dp_ = FHIRHelpers_4_0_001.ToInterval(do_);
				var dq_ = context?.Operators.End(dp_);

				return dq_;
			};
			var es_ = context?.Operators.ListSortBy<Encounter>(eq_, er_, System.ComponentModel.ListSortDirection.Ascending);
			var et_ = context?.Operators.LastOfList<Encounter>(es_);
			var eu_ = et_?.Period;
			var ev_ = FHIRHelpers_4_0_001.ToInterval(eu_);
			var ew_ = context?.Operators.Start(ev_);
			var ex_ = this.Observation_Services();
			var ey_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ex_, null);
			var ez_ = (Encounter LastObs) =>
			{
				var dr_ = LastObs?.Period;
				var ds_ = FHIRHelpers_4_0_001.ToInterval(dr_);
				var dt_ = context?.Operators.End(ds_);
				var du_ = Visit?.Period;
				var dv_ = FHIRHelpers_4_0_001.ToInterval(du_);
				var dw_ = context?.Operators.Start(dv_);
				var dx_ = context?.Operators.Quantity(1m, "hour");
				var dy_ = context?.Operators.Subtract(dw_, dx_);
				var dz_ = Visit?.Period;
				var ea_ = FHIRHelpers_4_0_001.ToInterval(dz_);
				var eb_ = context?.Operators.Start(ea_);
				var ec_ = context?.Operators.Interval(dy_, eb_, true, true);
				var ed_ = context?.Operators.ElementInInterval<CqlDateTime>(dt_, ec_, null);
				var ee_ = Visit?.Period;
				var ef_ = FHIRHelpers_4_0_001.ToInterval(ee_);
				var eg_ = context?.Operators.Start(ef_);
				var eh_ = (eg_ == null);
				var ei_ = (bool?)eh_;
				var ej_ = context?.Operators.Not(ei_);

				return context?.Operators.And(ed_, ej_);
			};
			var fa_ = context?.Operators.WhereOrNull<Encounter>(ey_, ez_);
			var fb_ = (Encounter @this) =>
			{
				var ek_ = @this?.Period;
				var el_ = FHIRHelpers_4_0_001.ToInterval(ek_);
				var em_ = context?.Operators.End(el_);

				return em_;
			};
			var fc_ = context?.Operators.ListSortBy<Encounter>(fa_, fb_, System.ComponentModel.ListSortDirection.Ascending);
			var fd_ = context?.Operators.LastOfList<Encounter>(fc_);
			var fe_ = fd_?.Period;
			var ff_ = FHIRHelpers_4_0_001.ToInterval(fe_);
			var fg_ = context?.Operators.Start(ff_);
			var fh_ = Visit?.Period;
			var fi_ = FHIRHelpers_4_0_001.ToInterval(fh_);
			var fj_ = context?.Operators.Start(fi_);
			var fk_ = (fg_ ?? fj_);
			var fl_ = (ew_ ?? fk_);
			var fm_ = Visit?.Period;
			var fn_ = FHIRHelpers_4_0_001.ToInterval(fm_);
			var fo_ = context?.Operators.End(fn_);

			return context?.Operators.Interval(fl_, fo_, true, true);
		};
		var fs_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(fq_, fr_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(fs_);
	}


    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
	{
		var a_ = this.HospitalizationWithObservation(Encounter);

		return this.LengthInDays(a_);
	}


}