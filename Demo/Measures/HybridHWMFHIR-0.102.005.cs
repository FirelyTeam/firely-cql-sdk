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
		var a_ = context.Operators;
		var d_ = a_.ConvertIntegerToDecimal(default);
		var e_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		var h_ = a_.ConvertIntegerToDecimal(default);
		var i_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, h_);
		var j_ = a_.Interval(e_, i_, true, false);
		var k_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
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
		var a_ = context.Operators;
		var c_ = a_.Start(Value);
		var e_ = a_.End(Value);
		var f_ = a_.DifferenceBetween(c_, e_, "day");

		return f_;
	}

	private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		var a_ = context.Operators;
		var d_ = context.DataRetriever;
		var e_ = this.Encounter_Inpatient();
		var f_ = d_.RetrieveByValueSet<Encounter>(e_, null);
		IEnumerable<Coverage> g_(Encounter _InpatientEncounter)
		{
			var n_ = context.DataRetriever;
			var o_ = this.Medicare_payer();
			var p_ = n_.RetrieveByValueSet<Coverage>(o_, null);

			return p_;
		};
		Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV h_(Encounter _InpatientEncounter, Coverage _Payer)
		{
			var q_ = new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = _InpatientEncounter,
				Payer = _Payer,
			};

			return q_;
		};
		var i_ = a_.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(f_, g_, h_);
		bool? j_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv)
		{
			var r_ = context.Operators;
			var v_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var w_ = v_.Operators;
			var x_ = w_.TypeConverter;
			var y_ = tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;
			var z_ = y_?.StatusElement;
			var aa_ = x_.Convert<string>(z_);
			var ab_ = r_.Equal(aa_, "finished");
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(y_);
			var af_ = this.LengthInDays(ae_);
			var ag_ = r_.Less(af_, (int?)365);
			var ah_ = r_.And(ab_, ag_);
			var al_ = y_?.Period;
			var am_ = FHIRHelpers_4_0_001.ToInterval(al_);
			var an_ = r_.End(am_);
			var ao_ = this.Measurement_Period();
			var ap_ = r_.ElementInInterval<CqlDateTime>(an_, ao_, "day");
			var aq_ = r_.And(ah_, ap_);
			var au_ = r_.TypeConverter;
			var av_ = this.Patient();
			var aw_ = av_?.BirthDateElement;
			var ax_ = aw_?.Value;
			var ay_ = au_.Convert<CqlDate>(ax_);
			var bc_ = y_?.Period;
			var bd_ = FHIRHelpers_4_0_001.ToInterval(bc_);
			var be_ = r_.Start(bd_);
			var bf_ = r_.DateFrom(be_);
			var bg_ = r_.CalculateAgeAt(ay_, bf_, "year");
			var bi_ = r_.Interval((int?)65, (int?)94, true, true);
			var bj_ = r_.ElementInInterval<int?>(bg_, bi_, null);
			var bk_ = r_.And(aq_, bj_);

			return bk_;
		};
		var k_ = a_.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(i_, j_);
		Encounter l_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv)
		{
			var bl_ = tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;

			return bl_;
		};
		var m_ = a_.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(k_, l_);

		return m_;
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
		var a_ = context.Operators;
		var b_ = this.Inpatient_Encounters();
		string c_(Encounter Encounter)
		{
			var e_ = context.Operators;
			var l_ = ("\r\n" ?? "");
			var m_ = (CCDE ?? "");
			var n_ = e_.Concatenate(l_, m_);
			var o_ = (n_ ?? "");
			var p_ = ("," ?? "");
			var q_ = e_.Concatenate(o_, p_);
			var r_ = (q_ ?? "");
			var s_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var t_ = s_.Operators;
			var u_ = t_.TypeConverter;
			var v_ = Encounter?.IdElement;
			var w_ = u_.Convert<string>(v_);
			var x_ = (w_ ?? "");
			var y_ = e_.Concatenate(r_, x_);
			var z_ = (y_ ?? "");
			var aa_ = (" , " ?? "");
			var ab_ = e_.Concatenate(z_, aa_);
			var ac_ = (ab_ ?? "");
			bool? ah_(Observation Exam)
			{
				var bl_ = context.Operators;
				var bq_ = Exam?.Effective;
				var br_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bq_);
				var bs_ = bl_.Start(br_);
				var bt_ = bl_.Not((bool?)(bs_ is null));
				var bx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bq_);
				var by_ = bl_.Start(bx_);
				var cc_ = Encounter?.Period;
				var cd_ = FHIRHelpers_4_0_001.ToInterval(cc_);
				var ce_ = bl_.Start(cd_);
				var cg_ = bl_.Quantity(1440m, "minutes");
				var ch_ = bl_.Subtract(ce_, cg_);
				var cl_ = FHIRHelpers_4_0_001.ToInterval(cc_);
				var cm_ = bl_.Start(cl_);
				var co_ = bl_.Quantity(120m, "minutes");
				var cp_ = bl_.Add(cm_, co_);
				var cq_ = bl_.Interval(ch_, cp_, true, true);
				var cr_ = bl_.ElementInInterval<CqlDateTime>(by_, cq_, null);
				var cs_ = bl_.And(bt_, cr_);
				var cu_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var cv_ = cu_.Operators;
				var cw_ = cv_.TypeConverter;
				var cx_ = Exam?.StatusElement;
				var cy_ = cw_.Convert<string>(cx_);
				var cz_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var da_ = bl_.InList<string>(cy_, (cz_ as IEnumerable<string>));
				var db_ = bl_.And(cs_, da_);
				var dd_ = Exam?.Value;
				var de_ = bl_.Not((bool?)(dd_ is null));
				var df_ = bl_.And(db_, de_);

				return df_;
			};
			var ai_ = e_.WhereOrNull<Observation>(ExamList, ah_);
			object aj_(Observation @this)
			{
				var dg_ = context.Operators;
				var dh_ = @this?.Effective;
				var di_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dh_);
				var dj_ = dg_.Start(di_);

				return dj_;
			};
			var ak_ = e_.ListSortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
			var al_ = e_.FirstOfList<Observation>(ak_);
			var am_ = al_?.Value;
			var an_ = FHIRHelpers_4_0_001.ToQuantity((am_ as Quantity));
			var ao_ = e_.ConvertQuantityToString(an_);
			var ap_ = (ao_ ?? "");
			var aq_ = e_.Concatenate(ac_, ap_);
			var ar_ = (aq_ ?? "");
			var at_ = e_.Concatenate(ar_, p_);
			var au_ = (at_ ?? "");
			bool? ba_(Observation Exam)
			{
				var dk_ = context.Operators;
				var dp_ = Exam?.Effective;
				var dq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dp_);
				var dr_ = dk_.Start(dq_);
				var ds_ = dk_.Not((bool?)(dr_ is null));
				var dw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dp_);
				var dx_ = dk_.Start(dw_);
				var eb_ = Encounter?.Period;
				var ec_ = FHIRHelpers_4_0_001.ToInterval(eb_);
				var ed_ = dk_.Start(ec_);
				var ef_ = dk_.Quantity(1440m, "minutes");
				var eg_ = dk_.Subtract(ed_, ef_);
				var ek_ = FHIRHelpers_4_0_001.ToInterval(eb_);
				var el_ = dk_.Start(ek_);
				var en_ = dk_.Quantity(120m, "minutes");
				var eo_ = dk_.Add(el_, en_);
				var ep_ = dk_.Interval(eg_, eo_, true, true);
				var eq_ = dk_.ElementInInterval<CqlDateTime>(dx_, ep_, null);
				var er_ = dk_.And(ds_, eq_);
				var et_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var eu_ = et_.Operators;
				var ev_ = eu_.TypeConverter;
				var ew_ = Exam?.StatusElement;
				var ex_ = ev_.Convert<string>(ew_);
				var ey_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var ez_ = dk_.InList<string>(ex_, (ey_ as IEnumerable<string>));
				var fa_ = dk_.And(er_, ez_);
				var fc_ = Exam?.Value;
				var fd_ = dk_.Not((bool?)(fc_ is null));
				var fe_ = dk_.And(fa_, fd_);

				return fe_;
			};
			var bb_ = e_.WhereOrNull<Observation>(ExamList, ba_);
			object bc_(Observation @this)
			{
				var ff_ = context.Operators;
				var fg_ = @this?.Effective;
				var fh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fg_);
				var fi_ = ff_.Start(fh_);

				return fi_;
			};
			var bd_ = e_.ListSortBy<Observation>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
			var be_ = e_.FirstOfList<Observation>(bd_);
			var bf_ = be_?.Effective;
			var bg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bf_);
			var bh_ = e_.Start(bg_);
			var bi_ = e_.ConvertDateTimeToString(bh_);
			var bj_ = (bi_ ?? "");
			var bk_ = e_.Concatenate(au_, bj_);

			return bk_;
		};
		var d_ = a_.SelectOrNull<Encounter, string>(b_, c_);

		return d_;
	}

    [CqlDeclaration("FirstLabTestWithEncounterId")]
	public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		var a_ = context.Operators;
		var b_ = this.Inpatient_Encounters();
		string c_(Encounter Encounter)
		{
			var e_ = context.Operators;
			var l_ = ("\r\n" ?? "");
			var m_ = (CCDE ?? "");
			var n_ = e_.Concatenate(l_, m_);
			var o_ = (n_ ?? "");
			var p_ = ("," ?? "");
			var q_ = e_.Concatenate(o_, p_);
			var r_ = (q_ ?? "");
			var s_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var t_ = s_.Operators;
			var u_ = t_.TypeConverter;
			var v_ = Encounter?.IdElement;
			var w_ = u_.Convert<string>(v_);
			var x_ = (w_ ?? "");
			var y_ = e_.Concatenate(r_, x_);
			var z_ = (y_ ?? "");
			var ab_ = e_.Concatenate(z_, p_);
			var ac_ = (ab_ ?? "");
			bool? ah_(Observation Lab)
			{
				var bj_ = context.Operators;
				var bn_ = Lab?.IssuedElement;
				var bo_ = bj_.Not((bool?)(bn_ is null));
				var br_ = FHIRHelpers_4_0_001.ToDateTime(bn_);
				var bv_ = Encounter?.Period;
				var bw_ = FHIRHelpers_4_0_001.ToInterval(bv_);
				var bx_ = bj_.Start(bw_);
				var bz_ = bj_.Quantity(1440m, "minutes");
				var ca_ = bj_.Subtract(bx_, bz_);
				var ce_ = FHIRHelpers_4_0_001.ToInterval(bv_);
				var cf_ = bj_.Start(ce_);
				var ch_ = bj_.Quantity(1440m, "minutes");
				var ci_ = bj_.Add(cf_, ch_);
				var cj_ = bj_.Interval(ca_, ci_, true, true);
				var ck_ = bj_.ElementInInterval<CqlDateTime>(br_, cj_, null);
				var cl_ = bj_.And(bo_, ck_);
				var cn_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var co_ = cn_.Operators;
				var cp_ = co_.TypeConverter;
				var cq_ = Lab?.StatusElement;
				var cr_ = cp_.Convert<string>(cq_);
				var cs_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var ct_ = bj_.InList<string>(cr_, (cs_ as IEnumerable<string>));
				var cu_ = bj_.And(cl_, ct_);
				var cw_ = Lab?.Value;
				var cx_ = bj_.Not((bool?)(cw_ is null));
				var cy_ = bj_.And(cu_, cx_);

				return cy_;
			};
			var ai_ = e_.WhereOrNull<Observation>(LabList, ah_);
			object aj_(Observation @this)
			{
				var cz_ = @this?.IssuedElement;

				return cz_;
			};
			var ak_ = e_.ListSortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
			var al_ = e_.FirstOfList<Observation>(ak_);
			var am_ = al_?.Value;
			var an_ = FHIRHelpers_4_0_001.ToQuantity((am_ as Quantity));
			var ao_ = e_.ConvertQuantityToString(an_);
			var ap_ = (ao_ ?? "");
			var aq_ = e_.Concatenate(ac_, ap_);
			var ar_ = (aq_ ?? "");
			var at_ = e_.Concatenate(ar_, p_);
			var au_ = (at_ ?? "");
			bool? az_(Observation Lab)
			{
				var da_ = context.Operators;
				var de_ = Lab?.IssuedElement;
				var df_ = da_.Not((bool?)(de_ is null));
				var di_ = FHIRHelpers_4_0_001.ToDateTime(de_);
				var dm_ = Encounter?.Period;
				var dn_ = FHIRHelpers_4_0_001.ToInterval(dm_);
				var do_ = da_.Start(dn_);
				var dq_ = da_.Quantity(1440m, "minutes");
				var dr_ = da_.Subtract(do_, dq_);
				var dv_ = FHIRHelpers_4_0_001.ToInterval(dm_);
				var dw_ = da_.Start(dv_);
				var dy_ = da_.Quantity(1440m, "minutes");
				var dz_ = da_.Add(dw_, dy_);
				var ea_ = da_.Interval(dr_, dz_, true, true);
				var eb_ = da_.ElementInInterval<CqlDateTime>(di_, ea_, null);
				var ec_ = da_.And(df_, eb_);
				var ee_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var ef_ = ee_.Operators;
				var eg_ = ef_.TypeConverter;
				var eh_ = Lab?.StatusElement;
				var ei_ = eg_.Convert<string>(eh_);
				var ej_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var ek_ = da_.InList<string>(ei_, (ej_ as IEnumerable<string>));
				var el_ = da_.And(ec_, ek_);
				var en_ = Lab?.Value;
				var eo_ = da_.Not((bool?)(en_ is null));
				var ep_ = da_.And(el_, eo_);

				return ep_;
			};
			var ba_ = e_.WhereOrNull<Observation>(LabList, az_);
			object bb_(Observation @this)
			{
				var eq_ = @this?.IssuedElement;

				return eq_;
			};
			var bc_ = e_.ListSortBy<Observation>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
			var bd_ = e_.FirstOfList<Observation>(bc_);
			var be_ = bd_?.IssuedElement;
			var bf_ = FHIRHelpers_4_0_001.ToDateTime(be_);
			var bg_ = e_.ConvertDateTimeToString(bf_);
			var bh_ = (bg_ ?? "");
			var bi_ = e_.Concatenate(au_, bh_);

			return bi_;
		};
		var d_ = a_.SelectOrNull<Encounter, string>(b_, c_);

		return d_;
	}

	private IEnumerable<string> Results_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var d_ = this.Heart_rate();
		var e_ = a_.ToList<CqlCode>(d_);
		var f_ = b_.RetrieveByCodes<Observation>(e_, null);
		var g_ = this.FirstPhysicalExamWithEncounterId(f_, "FirstHeartRate");
		var j_ = this.Systolic_blood_pressure();
		var k_ = a_.ToList<CqlCode>(j_);
		var l_ = b_.RetrieveByCodes<Observation>(k_, null);
		var m_ = this.FirstPhysicalExamWithEncounterId(l_, "FirstSystolicBP");
		var o_ = this.Body_temperature();
		var p_ = b_.RetrieveByValueSet<Observation>(o_, null);
		var q_ = this.FirstPhysicalExamWithEncounterId(p_, "FirstTemperature");
		var t_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		var u_ = a_.ToList<CqlCode>(t_);
		var v_ = b_.RetrieveByCodes<Observation>(u_, null);
		var w_ = this.FirstPhysicalExamWithEncounterId(v_, "FirstO2Saturation");
		var y_ = this.Hematocrit_lab_test();
		var z_ = b_.RetrieveByValueSet<Observation>(y_, null);
		var aa_ = this.FirstLabTestWithEncounterId(z_, "FirstHematocrit");
		var ac_ = this.Platelet_count_lab_test();
		var ad_ = b_.RetrieveByValueSet<Observation>(ac_, null);
		var ae_ = this.FirstLabTestWithEncounterId(ad_, "FirstPlateletCount");
		var ag_ = this.White_blood_cells_count_lab_test();
		var ah_ = b_.RetrieveByValueSet<Observation>(ag_, null);
		var ai_ = this.FirstLabTestWithEncounterId(ah_, "FirstWhiteBloodCell");
		var ak_ = this.Sodium_lab_test();
		var al_ = b_.RetrieveByValueSet<Observation>(ak_, null);
		var am_ = this.FirstLabTestWithEncounterId(al_, "FirstSodium");
		var ao_ = this.Bicarbonate_lab_test();
		var ap_ = b_.RetrieveByValueSet<Observation>(ao_, null);
		var aq_ = this.FirstLabTestWithEncounterId(ap_, "FirstBicarbonate");
		var as_ = this.Creatinine_lab_test();
		var at_ = b_.RetrieveByValueSet<Observation>(as_, null);
		var au_ = this.FirstLabTestWithEncounterId(at_, "FirstCreatinine");
		var av_ = new IEnumerable<string>[]
		{
			g_,
			m_,
			q_,
			w_,
			aa_,
			ae_,
			ai_,
			am_,
			aq_,
			au_,
		};
		var aw_ = a_.FlattenList<string>((av_ as IEnumerable<IEnumerable<string>>));

		return aw_;
	}

    [CqlDeclaration("Results")]
	public IEnumerable<string> Results() => 
		__Results.Value;

    [CqlDeclaration("CalendarAgeInYearsAt")]
	public int? CalendarAgeInYearsAt(CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		var a_ = context.Operators;
		var c_ = a_.ConvertDateTimeToDate(BirthDateTime);
		var e_ = a_.ConvertDateTimeToDate(AsOf);
		var f_ = a_.DurationBetween(c_, e_, "year");

		return f_;
	}

    [CqlDeclaration("ToDate")]
	public CqlDateTime ToDate(CqlDateTime Value)
	{
		var a_ = context.Operators;
		var c_ = a_.ComponentFrom(Value, "year");
		var e_ = a_.ComponentFrom(Value, "month");
		var g_ = a_.ComponentFrom(Value, "day");
		var i_ = a_.TimezoneOffsetFrom(Value);
		var j_ = a_.DateTime(c_, e_, g_, (int?)0, (int?)0, (int?)0, (int?)0, i_);

		return j_;
	}

    [CqlDeclaration("LengthOfStay")]
	public int? LengthOfStay(CqlInterval<CqlDateTime> Stay)
	{
		var a_ = context.Operators;
		var c_ = a_.Start(Stay);
		var e_ = a_.End(Stay);
		var f_ = a_.DifferenceBetween(c_, e_, "day");

		return f_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var a_ = context.Operators;
		var c_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> d_(Encounter Visit)
		{
			var g_ = context.Operators;
			var l_ = context.DataRetriever;
			var m_ = this.Emergency_Department_Visit();
			var n_ = l_.RetrieveByValueSet<Encounter>(m_, null);
			bool? o_(Encounter LastED)
			{
				var aw_ = context.Operators;
				var az_ = LastED?.Period;
				var ba_ = FHIRHelpers_4_0_001.ToInterval(az_);
				var bb_ = aw_.End(ba_);
				var bi_ = context.DataRetriever;
				var bj_ = this.Observation_Services();
				var bk_ = bi_.RetrieveByValueSet<Encounter>(bj_, null);
				bool? bl_(Encounter LastObs)
				{
					var du_ = context.Operators;
					var dx_ = LastObs?.Period;
					var dy_ = FHIRHelpers_4_0_001.ToInterval(dx_);
					var dz_ = du_.End(dy_);
					var ed_ = Visit?.Period;
					var ee_ = FHIRHelpers_4_0_001.ToInterval(ed_);
					var ef_ = du_.Start(ee_);
					var eh_ = du_.Quantity(1m, "hour");
					var ei_ = du_.Subtract(ef_, eh_);
					var el_ = FHIRHelpers_4_0_001.ToInterval(ed_);
					var em_ = du_.Start(el_);
					var en_ = du_.Interval(ei_, em_, true, true);
					var eo_ = du_.ElementInInterval<CqlDateTime>(dz_, en_, null);
					var es_ = FHIRHelpers_4_0_001.ToInterval(ed_);
					var et_ = du_.Start(es_);
					var eu_ = du_.Not((bool?)(et_ is null));
					var ev_ = du_.And(eo_, eu_);

					return ev_;
				};
				var bm_ = aw_.WhereOrNull<Encounter>(bk_, bl_);
				object bn_(Encounter @this)
				{
					var ew_ = context.Operators;
					var ex_ = @this?.Period;
					var ey_ = FHIRHelpers_4_0_001.ToInterval(ex_);
					var ez_ = ew_.End(ey_);

					return ez_;
				};
				var bo_ = aw_.ListSortBy<Encounter>(bm_, bn_, System.ComponentModel.ListSortDirection.Ascending);
				var bp_ = aw_.LastOfList<Encounter>(bo_);
				var bq_ = bp_?.Period;
				var br_ = FHIRHelpers_4_0_001.ToInterval(bq_);
				var bs_ = aw_.Start(br_);
				var bu_ = Visit?.Period;
				var bv_ = FHIRHelpers_4_0_001.ToInterval(bu_);
				var bw_ = aw_.Start(bv_);
				var bx_ = (bs_ ?? bw_);
				var bz_ = aw_.Quantity(1m, "hour");
				var ca_ = aw_.Subtract(bx_, bz_);
				var ch_ = bi_.RetrieveByValueSet<Encounter>(bj_, null);
				bool? ci_(Encounter LastObs)
				{
					var fa_ = context.Operators;
					var fd_ = LastObs?.Period;
					var fe_ = FHIRHelpers_4_0_001.ToInterval(fd_);
					var ff_ = fa_.End(fe_);
					var fj_ = Visit?.Period;
					var fk_ = FHIRHelpers_4_0_001.ToInterval(fj_);
					var fl_ = fa_.Start(fk_);
					var fn_ = fa_.Quantity(1m, "hour");
					var fo_ = fa_.Subtract(fl_, fn_);
					var fr_ = FHIRHelpers_4_0_001.ToInterval(fj_);
					var fs_ = fa_.Start(fr_);
					var ft_ = fa_.Interval(fo_, fs_, true, true);
					var fu_ = fa_.ElementInInterval<CqlDateTime>(ff_, ft_, null);
					var fy_ = FHIRHelpers_4_0_001.ToInterval(fj_);
					var fz_ = fa_.Start(fy_);
					var ga_ = fa_.Not((bool?)(fz_ is null));
					var gb_ = fa_.And(fu_, ga_);

					return gb_;
				};
				var cj_ = aw_.WhereOrNull<Encounter>(ch_, ci_);
				object ck_(Encounter @this)
				{
					var gc_ = context.Operators;
					var gd_ = @this?.Period;
					var ge_ = FHIRHelpers_4_0_001.ToInterval(gd_);
					var gf_ = gc_.End(ge_);

					return gf_;
				};
				var cl_ = aw_.ListSortBy<Encounter>(cj_, ck_, System.ComponentModel.ListSortDirection.Ascending);
				var cm_ = aw_.LastOfList<Encounter>(cl_);
				var cn_ = cm_?.Period;
				var co_ = FHIRHelpers_4_0_001.ToInterval(cn_);
				var cp_ = aw_.Start(co_);
				var cs_ = FHIRHelpers_4_0_001.ToInterval(bu_);
				var ct_ = aw_.Start(cs_);
				var cu_ = (cp_ ?? ct_);
				var cv_ = aw_.Interval(ca_, cu_, true, true);
				var cw_ = aw_.ElementInInterval<CqlDateTime>(bb_, cv_, null);
				var de_ = bi_.RetrieveByValueSet<Encounter>(bj_, null);
				bool? df_(Encounter LastObs)
				{
					var gg_ = context.Operators;
					var gj_ = LastObs?.Period;
					var gk_ = FHIRHelpers_4_0_001.ToInterval(gj_);
					var gl_ = gg_.End(gk_);
					var gp_ = Visit?.Period;
					var gq_ = FHIRHelpers_4_0_001.ToInterval(gp_);
					var gr_ = gg_.Start(gq_);
					var gt_ = gg_.Quantity(1m, "hour");
					var gu_ = gg_.Subtract(gr_, gt_);
					var gx_ = FHIRHelpers_4_0_001.ToInterval(gp_);
					var gy_ = gg_.Start(gx_);
					var gz_ = gg_.Interval(gu_, gy_, true, true);
					var ha_ = gg_.ElementInInterval<CqlDateTime>(gl_, gz_, null);
					var he_ = FHIRHelpers_4_0_001.ToInterval(gp_);
					var hf_ = gg_.Start(he_);
					var hg_ = gg_.Not((bool?)(hf_ is null));
					var hh_ = gg_.And(ha_, hg_);

					return hh_;
				};
				var dg_ = aw_.WhereOrNull<Encounter>(de_, df_);
				object dh_(Encounter @this)
				{
					var hi_ = context.Operators;
					var hj_ = @this?.Period;
					var hk_ = FHIRHelpers_4_0_001.ToInterval(hj_);
					var hl_ = hi_.End(hk_);

					return hl_;
				};
				var di_ = aw_.ListSortBy<Encounter>(dg_, dh_, System.ComponentModel.ListSortDirection.Ascending);
				var dj_ = aw_.LastOfList<Encounter>(di_);
				var dk_ = dj_?.Period;
				var dl_ = FHIRHelpers_4_0_001.ToInterval(dk_);
				var dm_ = aw_.Start(dl_);
				var dp_ = FHIRHelpers_4_0_001.ToInterval(bu_);
				var dq_ = aw_.Start(dp_);
				var dr_ = (dm_ ?? dq_);
				var ds_ = aw_.Not((bool?)(dr_ is null));
				var dt_ = aw_.And(cw_, ds_);

				return dt_;
			};
			var p_ = g_.WhereOrNull<Encounter>(n_, o_);
			object q_(Encounter @this)
			{
				var hm_ = context.Operators;
				var hn_ = @this?.Period;
				var ho_ = FHIRHelpers_4_0_001.ToInterval(hn_);
				var hp_ = hm_.End(ho_);

				return hp_;
			};
			var r_ = g_.ListSortBy<Encounter>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			var s_ = g_.LastOfList<Encounter>(r_);
			var t_ = s_?.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var v_ = g_.Start(u_);
			var ab_ = this.Observation_Services();
			var ac_ = l_.RetrieveByValueSet<Encounter>(ab_, null);
			bool? ad_(Encounter LastObs)
			{
				var hq_ = context.Operators;
				var ht_ = LastObs?.Period;
				var hu_ = FHIRHelpers_4_0_001.ToInterval(ht_);
				var hv_ = hq_.End(hu_);
				var hz_ = Visit?.Period;
				var ia_ = FHIRHelpers_4_0_001.ToInterval(hz_);
				var ib_ = hq_.Start(ia_);
				var id_ = hq_.Quantity(1m, "hour");
				var ie_ = hq_.Subtract(ib_, id_);
				var ih_ = FHIRHelpers_4_0_001.ToInterval(hz_);
				var ii_ = hq_.Start(ih_);
				var ij_ = hq_.Interval(ie_, ii_, true, true);
				var ik_ = hq_.ElementInInterval<CqlDateTime>(hv_, ij_, null);
				var io_ = FHIRHelpers_4_0_001.ToInterval(hz_);
				var ip_ = hq_.Start(io_);
				var iq_ = hq_.Not((bool?)(ip_ is null));
				var ir_ = hq_.And(ik_, iq_);

				return ir_;
			};
			var ae_ = g_.WhereOrNull<Encounter>(ac_, ad_);
			object af_(Encounter @this)
			{
				var is_ = context.Operators;
				var it_ = @this?.Period;
				var iu_ = FHIRHelpers_4_0_001.ToInterval(it_);
				var iv_ = is_.End(iu_);

				return iv_;
			};
			var ag_ = g_.ListSortBy<Encounter>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			var ah_ = g_.LastOfList<Encounter>(ag_);
			var ai_ = ah_?.Period;
			var aj_ = FHIRHelpers_4_0_001.ToInterval(ai_);
			var ak_ = g_.Start(aj_);
			var am_ = Visit?.Period;
			var an_ = FHIRHelpers_4_0_001.ToInterval(am_);
			var ao_ = g_.Start(an_);
			var ap_ = (ak_ ?? ao_);
			var aq_ = (v_ ?? ap_);
			var at_ = FHIRHelpers_4_0_001.ToInterval(am_);
			var au_ = g_.End(at_);
			var av_ = g_.Interval(aq_, au_, true, true);

			return av_;
		};
		var e_ = a_.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(c_, d_);
		var f_ = a_.SingleOrNull<CqlInterval<CqlDateTime>>(e_);

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