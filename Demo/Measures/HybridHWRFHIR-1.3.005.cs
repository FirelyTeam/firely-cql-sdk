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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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

	private CqlValueSet Body_weight_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", null);

    [CqlDeclaration("Body weight")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159")]
	public CqlValueSet Body_weight() => 
		__Body_weight.Value;

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

	private CqlValueSet Glucose_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
	public CqlValueSet Glucose_lab_test() => 
		__Glucose_lab_test.Value;

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

	private CqlValueSet Potassium_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", null);

    [CqlDeclaration("Potassium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117")]
	public CqlValueSet Potassium_lab_test() => 
		__Potassium_lab_test.Value;

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

	private CqlCode Respiratory_rate_Value() => 
		new CqlCode("9279-1", "http://loinc.org", null, null);

    [CqlDeclaration("Respiratory rate")]
	public CqlCode Respiratory_rate() => 
		__Respiratory_rate.Value;

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
			new CqlCode("9279-1", "http://loinc.org", null, null),
			new CqlCode("8480-6", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC:2.69")]
	public CqlCode[] LOINC_2_69() => 
		__LOINC_2_69.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("HybridHWRFHIR-1.3.005", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
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
				var af_ = LastED?.Period;
				var ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
				var ah_ = context.Operators.End(ag_);
				var ai_ = this.Observation_Services();
				var aj_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? ak_(Encounter LastObs)
				{
					var cb_ = LastObs?.Period;
					var cc_ = FHIRHelpers_4_0_001.ToInterval(cb_);
					var cd_ = context.Operators.End(cc_);
					var ce_ = Visit?.Period;
					var cf_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					var cg_ = context.Operators.Start(cf_);
					var ch_ = context.Operators.Quantity(1m, "hour");
					var ci_ = context.Operators.Subtract(cg_, ch_);
					var ck_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					var cl_ = context.Operators.Start(ck_);
					var cm_ = context.Operators.Interval(ci_, cl_, true, true);
					var cn_ = context.Operators.ElementInInterval<CqlDateTime>(cd_, cm_, null);
					var cp_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					var cq_ = context.Operators.Start(cp_);
					var cr_ = context.Operators.Not((bool?)(cq_ is null));
					var cs_ = context.Operators.And(cn_, cr_);

					return cs_;
				};
				var al_ = context.Operators.WhereOrNull<Encounter>(aj_, ak_);
				object am_(Encounter @this)
				{
					var ct_ = @this?.Period;
					var cu_ = FHIRHelpers_4_0_001.ToInterval(ct_);
					var cv_ = context.Operators.End(cu_);

					return cv_;
				};
				var an_ = context.Operators.ListSortBy<Encounter>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);
				var ao_ = context.Operators.LastOfList<Encounter>(an_);
				var ap_ = ao_?.Period;
				var aq_ = FHIRHelpers_4_0_001.ToInterval(ap_);
				var ar_ = context.Operators.Start(aq_);
				var as_ = Visit?.Period;
				var at_ = FHIRHelpers_4_0_001.ToInterval(as_);
				var au_ = context.Operators.Start(at_);
				var av_ = context.Operators.Quantity(1m, "hour");
				var aw_ = context.Operators.Subtract((ar_ ?? au_), av_);
				var ay_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? az_(Encounter LastObs)
				{
					var cw_ = LastObs?.Period;
					var cx_ = FHIRHelpers_4_0_001.ToInterval(cw_);
					var cy_ = context.Operators.End(cx_);
					var cz_ = Visit?.Period;
					var da_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					var db_ = context.Operators.Start(da_);
					var dc_ = context.Operators.Quantity(1m, "hour");
					var dd_ = context.Operators.Subtract(db_, dc_);
					var df_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					var dg_ = context.Operators.Start(df_);
					var dh_ = context.Operators.Interval(dd_, dg_, true, true);
					var di_ = context.Operators.ElementInInterval<CqlDateTime>(cy_, dh_, null);
					var dk_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					var dl_ = context.Operators.Start(dk_);
					var dm_ = context.Operators.Not((bool?)(dl_ is null));
					var dn_ = context.Operators.And(di_, dm_);

					return dn_;
				};
				var ba_ = context.Operators.WhereOrNull<Encounter>(ay_, az_);
				object bb_(Encounter @this)
				{
					var do_ = @this?.Period;
					var dp_ = FHIRHelpers_4_0_001.ToInterval(do_);
					var dq_ = context.Operators.End(dp_);

					return dq_;
				};
				var bc_ = context.Operators.ListSortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
				var bd_ = context.Operators.LastOfList<Encounter>(bc_);
				var be_ = bd_?.Period;
				var bf_ = FHIRHelpers_4_0_001.ToInterval(be_);
				var bg_ = context.Operators.Start(bf_);
				var bi_ = FHIRHelpers_4_0_001.ToInterval(as_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Interval(aw_, (bg_ ?? bj_), true, true);
				var bl_ = context.Operators.ElementInInterval<CqlDateTime>(ah_, bk_, null);
				var bn_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? bo_(Encounter LastObs)
				{
					var dr_ = LastObs?.Period;
					var ds_ = FHIRHelpers_4_0_001.ToInterval(dr_);
					var dt_ = context.Operators.End(ds_);
					var du_ = Visit?.Period;
					var dv_ = FHIRHelpers_4_0_001.ToInterval(du_);
					var dw_ = context.Operators.Start(dv_);
					var dx_ = context.Operators.Quantity(1m, "hour");
					var dy_ = context.Operators.Subtract(dw_, dx_);
					var ea_ = FHIRHelpers_4_0_001.ToInterval(du_);
					var eb_ = context.Operators.Start(ea_);
					var ec_ = context.Operators.Interval(dy_, eb_, true, true);
					var ed_ = context.Operators.ElementInInterval<CqlDateTime>(dt_, ec_, null);
					var ef_ = FHIRHelpers_4_0_001.ToInterval(du_);
					var eg_ = context.Operators.Start(ef_);
					var eh_ = context.Operators.Not((bool?)(eg_ is null));
					var ei_ = context.Operators.And(ed_, eh_);

					return ei_;
				};
				var bp_ = context.Operators.WhereOrNull<Encounter>(bn_, bo_);
				object bq_(Encounter @this)
				{
					var ej_ = @this?.Period;
					var ek_ = FHIRHelpers_4_0_001.ToInterval(ej_);
					var el_ = context.Operators.End(ek_);

					return el_;
				};
				var br_ = context.Operators.ListSortBy<Encounter>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
				var bs_ = context.Operators.LastOfList<Encounter>(br_);
				var bt_ = bs_?.Period;
				var bu_ = FHIRHelpers_4_0_001.ToInterval(bt_);
				var bv_ = context.Operators.Start(bu_);
				var bx_ = FHIRHelpers_4_0_001.ToInterval(as_);
				var by_ = context.Operators.Start(bx_);
				var bz_ = context.Operators.Not((bool?)((bv_ ?? by_) is null));
				var ca_ = context.Operators.And(bl_, bz_);

				return ca_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var em_ = @this?.Period;
				var en_ = FHIRHelpers_4_0_001.ToInterval(em_);
				var eo_ = context.Operators.End(en_);

				return eo_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = k_?.Period;
			var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = this.Observation_Services();
			var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
			bool? q_(Encounter LastObs)
			{
				var ep_ = LastObs?.Period;
				var eq_ = FHIRHelpers_4_0_001.ToInterval(ep_);
				var er_ = context.Operators.End(eq_);
				var es_ = Visit?.Period;
				var et_ = FHIRHelpers_4_0_001.ToInterval(es_);
				var eu_ = context.Operators.Start(et_);
				var ev_ = context.Operators.Quantity(1m, "hour");
				var ew_ = context.Operators.Subtract(eu_, ev_);
				var ey_ = FHIRHelpers_4_0_001.ToInterval(es_);
				var ez_ = context.Operators.Start(ey_);
				var fa_ = context.Operators.Interval(ew_, ez_, true, true);
				var fb_ = context.Operators.ElementInInterval<CqlDateTime>(er_, fa_, null);
				var fd_ = FHIRHelpers_4_0_001.ToInterval(es_);
				var fe_ = context.Operators.Start(fd_);
				var ff_ = context.Operators.Not((bool?)(fe_ is null));
				var fg_ = context.Operators.And(fb_, ff_);

				return fg_;
			};
			var r_ = context.Operators.WhereOrNull<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				var fh_ = @this?.Period;
				var fi_ = FHIRHelpers_4_0_001.ToInterval(fh_);
				var fj_ = context.Operators.End(fi_);

				return fj_;
			};
			var t_ = context.Operators.ListSortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.LastOfList<Encounter>(t_);
			var v_ = u_?.Period;
			var w_ = FHIRHelpers_4_0_001.ToInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = Visit?.Period;
			var z_ = FHIRHelpers_4_0_001.ToInterval(y_);
			var aa_ = context.Operators.Start(z_);
			var ac_ = FHIRHelpers_4_0_001.ToInterval(y_);
			var ad_ = context.Operators.End(ac_);
			var ae_ = context.Operators.Interval((n_ ?? (x_ ?? aa_)), ad_, true, true);

			return ae_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

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
		IEnumerable<Coverage> c_(Encounter _InpatientEncounter)
		{
			var j_ = this.Medicare_payer();
			var k_ = context.Operators.RetrieveByValueSet<Coverage>(j_, null);

			return k_;
		};
		Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV d_(Encounter _InpatientEncounter, Coverage _Payer)
		{
			var l_ = new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = _InpatientEncounter,
				Payer = _Payer,
			};

			return l_;
		};
		var e_ = context.Operators.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(b_, c_, d_);
		bool? f_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv)
		{
			var m_ = tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter?.StatusElement;
			var n_ = context.Operators.Convert<string>(m_);
			var o_ = context.Operators.Equal(n_, "finished");
			var p_ = this.HospitalizationWithObservation(tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter);
			var q_ = this.LengthInDays(p_);
			var r_ = context.Operators.Less(q_, (int?)365);
			var s_ = context.Operators.And(o_, r_);
			var t_ = tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter?.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var v_ = context.Operators.End(u_);
			var w_ = this.Measurement_Period();
			var x_ = context.Operators.ElementInInterval<CqlDateTime>(v_, w_, "day");
			var y_ = context.Operators.And(s_, x_);
			var z_ = this.Patient();
			var aa_ = z_?.BirthDateElement;
			var ab_ = aa_?.Value;
			var ac_ = context.Operators.Convert<CqlDate>(ab_);
			var ae_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var af_ = context.Operators.Start(ae_);
			var ag_ = context.Operators.DateFrom(af_);
			var ah_ = context.Operators.CalculateAgeAt(ac_, ag_, "year");
			var ai_ = context.Operators.GreaterOrEqual(ah_, (int?)65);
			var aj_ = context.Operators.And(y_, ai_);

			return aj_;
		};
		var g_ = context.Operators.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(e_, f_);
		Encounter h_(Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV tuple_czdryxljaejapsirauhdxvhpv) => 
			tuple_czdryxljaejapsirauhdxvhpv.InpatientEncounter;
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(g_, h_);

		return i_;
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
			var f_ = Encounter?.IdElement;
			var g_ = context.Operators.Convert<string>(f_);
			var h_ = context.Operators.Concatenate((e_ ?? ""), (g_ ?? ""));
			var i_ = context.Operators.Concatenate((h_ ?? ""), ",");
			bool? j_(Observation Exam)
			{
				var ad_ = Exam?.Effective;
				var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Not((bool?)(af_ is null));
				var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
				var aj_ = context.Operators.Start(ai_);
				var ak_ = Encounter?.Period;
				var al_ = FHIRHelpers_4_0_001.ToInterval(ak_);
				var am_ = context.Operators.Start(al_);
				var an_ = context.Operators.Quantity(1440m, "minutes");
				var ao_ = context.Operators.Subtract(am_, an_);
				var aq_ = FHIRHelpers_4_0_001.ToInterval(ak_);
				var ar_ = context.Operators.Start(aq_);
				var as_ = context.Operators.Quantity(120m, "minutes");
				var at_ = context.Operators.Add(ar_, as_);
				var au_ = context.Operators.Interval(ao_, at_, true, true);
				var av_ = context.Operators.ElementInInterval<CqlDateTime>(aj_, au_, null);
				var aw_ = context.Operators.And(ag_, av_);
				var ax_ = Exam?.StatusElement;
				var ay_ = context.Operators.Convert<string>(ax_);
				var az_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var ba_ = context.Operators.InList<string>(ay_, (az_ as IEnumerable<string>));
				var bb_ = context.Operators.And(aw_, ba_);
				var bc_ = Exam?.Value;
				var bd_ = context.Operators.Not((bool?)(bc_ is null));
				var be_ = context.Operators.And(bb_, bd_);

				return be_;
			};
			var k_ = context.Operators.WhereOrNull<Observation>(ExamList, j_);
			object l_(Observation @this)
			{
				var bf_ = @this?.Effective;
				var bg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bf_);
				var bh_ = context.Operators.Start(bg_);

				return bh_;
			};
			var m_ = context.Operators.ListSortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
			var n_ = context.Operators.FirstOfList<Observation>(m_);
			var o_ = n_?.Value;
			var p_ = FHIRHelpers_4_0_001.ToQuantity((o_ as Quantity));
			var q_ = context.Operators.ConvertQuantityToString(p_);
			var r_ = context.Operators.Concatenate((i_ ?? ""), (q_ ?? ""));
			var s_ = context.Operators.Concatenate((r_ ?? ""), ",");
			bool? t_(Observation Exam)
			{
				var bi_ = Exam?.Effective;
				var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
				var bk_ = context.Operators.Start(bj_);
				var bl_ = context.Operators.Not((bool?)(bk_ is null));
				var bn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
				var bo_ = context.Operators.Start(bn_);
				var bp_ = Encounter?.Period;
				var bq_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var br_ = context.Operators.Start(bq_);
				var bs_ = context.Operators.Quantity(1440m, "minutes");
				var bt_ = context.Operators.Subtract(br_, bs_);
				var bv_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var bw_ = context.Operators.Start(bv_);
				var bx_ = context.Operators.Quantity(120m, "minutes");
				var by_ = context.Operators.Add(bw_, bx_);
				var bz_ = context.Operators.Interval(bt_, by_, true, true);
				var ca_ = context.Operators.ElementInInterval<CqlDateTime>(bo_, bz_, null);
				var cb_ = context.Operators.And(bl_, ca_);
				var cc_ = Exam?.StatusElement;
				var cd_ = context.Operators.Convert<string>(cc_);
				var ce_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var cf_ = context.Operators.InList<string>(cd_, (ce_ as IEnumerable<string>));
				var cg_ = context.Operators.And(cb_, cf_);
				var ch_ = Exam?.Value;
				var ci_ = context.Operators.Not((bool?)(ch_ is null));
				var cj_ = context.Operators.And(cg_, ci_);

				return cj_;
			};
			var u_ = context.Operators.WhereOrNull<Observation>(ExamList, t_);
			object v_(Observation @this)
			{
				var ck_ = @this?.Effective;
				var cl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ck_);
				var cm_ = context.Operators.Start(cl_);

				return cm_;
			};
			var w_ = context.Operators.ListSortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
			var x_ = context.Operators.FirstOfList<Observation>(w_);
			var y_ = x_?.Effective;
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(y_);
			var aa_ = context.Operators.Start(z_);
			var ab_ = context.Operators.ConvertDateTimeToString(aa_);
			var ac_ = context.Operators.Concatenate((s_ ?? ""), (ab_ ?? ""));

			return ac_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, string>(a_, b_);

		return c_;
	}

    [CqlDeclaration("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
	public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(IEnumerable<Observation> ExamList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		string b_(Encounter Encounter)
		{
			var d_ = context.Operators.Concatenate("\r\n", (CCDE ?? ""));
			var e_ = context.Operators.Concatenate((d_ ?? ""), ",");
			var f_ = Encounter?.IdElement;
			var g_ = context.Operators.Convert<string>(f_);
			var h_ = context.Operators.Concatenate((e_ ?? ""), (g_ ?? ""));
			var i_ = context.Operators.Concatenate((h_ ?? ""), ",");
			bool? j_(Observation Exam)
			{
				var ad_ = Exam?.Effective;
				var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Not((bool?)(af_ is null));
				var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
				var aj_ = context.Operators.Start(ai_);
				var ak_ = Encounter?.Period;
				var al_ = FHIRHelpers_4_0_001.ToInterval(ak_);
				var am_ = context.Operators.Start(al_);
				var an_ = context.Operators.Quantity(1440m, "minutes");
				var ao_ = context.Operators.Subtract(am_, an_);
				var aq_ = FHIRHelpers_4_0_001.ToInterval(ak_);
				var ar_ = context.Operators.Start(aq_);
				var at_ = context.Operators.Add(ar_, an_);
				var au_ = context.Operators.Interval(ao_, at_, true, true);
				var av_ = context.Operators.ElementInInterval<CqlDateTime>(aj_, au_, null);
				var aw_ = context.Operators.And(ag_, av_);
				var ax_ = Exam?.StatusElement;
				var ay_ = context.Operators.Convert<string>(ax_);
				var az_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var ba_ = context.Operators.InList<string>(ay_, (az_ as IEnumerable<string>));
				var bb_ = context.Operators.And(aw_, ba_);
				var bc_ = Exam?.Value;
				var bd_ = context.Operators.Not((bool?)(bc_ is null));
				var be_ = context.Operators.And(bb_, bd_);

				return be_;
			};
			var k_ = context.Operators.WhereOrNull<Observation>(ExamList, j_);
			object l_(Observation @this)
			{
				var bf_ = @this?.Effective;
				var bg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bf_);
				var bh_ = context.Operators.Start(bg_);

				return bh_;
			};
			var m_ = context.Operators.ListSortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
			var n_ = context.Operators.FirstOfList<Observation>(m_);
			var o_ = n_?.Value;
			var p_ = FHIRHelpers_4_0_001.ToQuantity((o_ as Quantity));
			var q_ = context.Operators.ConvertQuantityToString(p_);
			var r_ = context.Operators.Concatenate((i_ ?? ""), (q_ ?? ""));
			var s_ = context.Operators.Concatenate((r_ ?? ""), ",");
			bool? t_(Observation Exam)
			{
				var bi_ = Exam?.Effective;
				var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
				var bk_ = context.Operators.Start(bj_);
				var bl_ = context.Operators.Not((bool?)(bk_ is null));
				var bn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
				var bo_ = context.Operators.Start(bn_);
				var bp_ = Encounter?.Period;
				var bq_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var br_ = context.Operators.Start(bq_);
				var bs_ = context.Operators.Quantity(1440m, "minutes");
				var bt_ = context.Operators.Subtract(br_, bs_);
				var bv_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var bw_ = context.Operators.Start(bv_);
				var by_ = context.Operators.Add(bw_, bs_);
				var bz_ = context.Operators.Interval(bt_, by_, true, true);
				var ca_ = context.Operators.ElementInInterval<CqlDateTime>(bo_, bz_, null);
				var cb_ = context.Operators.And(bl_, ca_);
				var cc_ = Exam?.StatusElement;
				var cd_ = context.Operators.Convert<string>(cc_);
				var ce_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var cf_ = context.Operators.InList<string>(cd_, (ce_ as IEnumerable<string>));
				var cg_ = context.Operators.And(cb_, cf_);
				var ch_ = Exam?.Value;
				var ci_ = context.Operators.Not((bool?)(ch_ is null));
				var cj_ = context.Operators.And(cg_, ci_);

				return cj_;
			};
			var u_ = context.Operators.WhereOrNull<Observation>(ExamList, t_);
			object v_(Observation @this)
			{
				var ck_ = @this?.Effective;
				var cl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ck_);
				var cm_ = context.Operators.Start(cl_);

				return cm_;
			};
			var w_ = context.Operators.ListSortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
			var x_ = context.Operators.FirstOfList<Observation>(w_);
			var y_ = x_?.Effective;
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(y_);
			var aa_ = context.Operators.Start(z_);
			var ab_ = context.Operators.ConvertDateTimeToString(aa_);
			var ac_ = context.Operators.Concatenate((s_ ?? ""), (ab_ ?? ""));

			return ac_;
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
			var f_ = Encounter?.IdElement;
			var g_ = context.Operators.Convert<string>(f_);
			var h_ = context.Operators.Concatenate((e_ ?? ""), (g_ ?? ""));
			var i_ = context.Operators.Concatenate((h_ ?? ""), ",");
			bool? j_(Observation Lab)
			{
				var ac_ = Lab?.IssuedElement;
				var ad_ = context.Operators.Not((bool?)(ac_ is null));
				var af_ = FHIRHelpers_4_0_001.ToDateTime(ac_);
				var ag_ = Encounter?.Period;
				var ah_ = FHIRHelpers_4_0_001.ToInterval(ag_);
				var ai_ = context.Operators.Start(ah_);
				var aj_ = context.Operators.Quantity(1440m, "minutes");
				var ak_ = context.Operators.Subtract(ai_, aj_);
				var am_ = FHIRHelpers_4_0_001.ToInterval(ag_);
				var an_ = context.Operators.Start(am_);
				var ap_ = context.Operators.Add(an_, aj_);
				var aq_ = context.Operators.Interval(ak_, ap_, true, true);
				var ar_ = context.Operators.ElementInInterval<CqlDateTime>(af_, aq_, null);
				var as_ = context.Operators.And(ad_, ar_);
				var at_ = Lab?.StatusElement;
				var au_ = context.Operators.Convert<string>(at_);
				var av_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var aw_ = context.Operators.InList<string>(au_, (av_ as IEnumerable<string>));
				var ax_ = context.Operators.And(as_, aw_);
				var ay_ = Lab?.Value;
				var az_ = context.Operators.Not((bool?)(ay_ is null));
				var ba_ = context.Operators.And(ax_, az_);

				return ba_;
			};
			var k_ = context.Operators.WhereOrNull<Observation>(LabList, j_);
			object l_(Observation @this)
			{
				var bb_ = @this?.IssuedElement;

				return bb_;
			};
			var m_ = context.Operators.ListSortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
			var n_ = context.Operators.FirstOfList<Observation>(m_);
			var o_ = n_?.Value;
			var p_ = FHIRHelpers_4_0_001.ToQuantity((o_ as Quantity));
			var q_ = context.Operators.ConvertQuantityToString(p_);
			var r_ = context.Operators.Concatenate((i_ ?? ""), (q_ ?? ""));
			var s_ = context.Operators.Concatenate((r_ ?? ""), ",");
			bool? t_(Observation Lab)
			{
				var bc_ = Lab?.IssuedElement;
				var bd_ = context.Operators.Not((bool?)(bc_ is null));
				var bf_ = FHIRHelpers_4_0_001.ToDateTime(bc_);
				var bg_ = Encounter?.Period;
				var bh_ = FHIRHelpers_4_0_001.ToInterval(bg_);
				var bi_ = context.Operators.Start(bh_);
				var bj_ = context.Operators.Quantity(1440m, "minutes");
				var bk_ = context.Operators.Subtract(bi_, bj_);
				var bm_ = FHIRHelpers_4_0_001.ToInterval(bg_);
				var bn_ = context.Operators.Start(bm_);
				var bp_ = context.Operators.Add(bn_, bj_);
				var bq_ = context.Operators.Interval(bk_, bp_, true, true);
				var br_ = context.Operators.ElementInInterval<CqlDateTime>(bf_, bq_, null);
				var bs_ = context.Operators.And(bd_, br_);
				var bt_ = Lab?.StatusElement;
				var bu_ = context.Operators.Convert<string>(bt_);
				var bv_ = new string[]
				{
					"final",
					"amended",
					"preliminary",
				};
				var bw_ = context.Operators.InList<string>(bu_, (bv_ as IEnumerable<string>));
				var bx_ = context.Operators.And(bs_, bw_);
				var by_ = Lab?.Value;
				var bz_ = context.Operators.Not((bool?)(by_ is null));
				var ca_ = context.Operators.And(bx_, bz_);

				return ca_;
			};
			var u_ = context.Operators.WhereOrNull<Observation>(LabList, t_);
			object v_(Observation @this)
			{
				var cb_ = @this?.IssuedElement;

				return cb_;
			};
			var w_ = context.Operators.ListSortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
			var x_ = context.Operators.FirstOfList<Observation>(w_);
			var y_ = x_?.IssuedElement;
			var z_ = FHIRHelpers_4_0_001.ToDateTime(y_);
			var aa_ = context.Operators.ConvertDateTimeToString(z_);
			var ab_ = context.Operators.Concatenate((s_ ?? ""), (aa_ ?? ""));

			return ab_;
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
		var i_ = this.Respiratory_rate();
		var j_ = context.Operators.ToList<CqlCode>(i_);
		var k_ = context.Operators.RetrieveByCodes<Observation>(j_, null);
		var l_ = this.FirstPhysicalExamWithEncounterId(k_, "FirstRespRate");
		var m_ = this.Body_temperature();
		var n_ = context.Operators.RetrieveByValueSet<Observation>(m_, null);
		var o_ = this.FirstPhysicalExamWithEncounterId(n_, "FirstTemperature");
		var p_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		var q_ = context.Operators.ToList<CqlCode>(p_);
		var r_ = context.Operators.RetrieveByCodes<Observation>(q_, null);
		var s_ = this.FirstPhysicalExamWithEncounterId(r_, "FirstO2Saturation");
		var t_ = this.Body_weight();
		var u_ = context.Operators.RetrieveByValueSet<Observation>(t_, null);
		var v_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(u_, "FirstWeight");
		var w_ = this.Hematocrit_lab_test();
		var x_ = context.Operators.RetrieveByValueSet<Observation>(w_, null);
		var y_ = this.FirstLabTestWithEncounterId(x_, "FirstHematocrit");
		var z_ = this.White_blood_cells_count_lab_test();
		var aa_ = context.Operators.RetrieveByValueSet<Observation>(z_, null);
		var ab_ = this.FirstLabTestWithEncounterId(aa_, "FirstWhiteBloodCell");
		var ac_ = this.Potassium_lab_test();
		var ad_ = context.Operators.RetrieveByValueSet<Observation>(ac_, null);
		var ae_ = this.FirstLabTestWithEncounterId(ad_, "FirstPotassium");
		var af_ = this.Sodium_lab_test();
		var ag_ = context.Operators.RetrieveByValueSet<Observation>(af_, null);
		var ah_ = this.FirstLabTestWithEncounterId(ag_, "FirstSodium");
		var ai_ = this.Bicarbonate_lab_test();
		var aj_ = context.Operators.RetrieveByValueSet<Observation>(ai_, null);
		var ak_ = this.FirstLabTestWithEncounterId(aj_, "FirstBicarbonate");
		var al_ = this.Creatinine_lab_test();
		var am_ = context.Operators.RetrieveByValueSet<Observation>(al_, null);
		var an_ = this.FirstLabTestWithEncounterId(am_, "FirstCreatinine");
		var ao_ = this.Glucose_lab_test();
		var ap_ = context.Operators.RetrieveByValueSet<Observation>(ao_, null);
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
		var as_ = context.Operators.FlattenList<string>((ar_ as IEnumerable<IEnumerable<string>>));

		return as_;
	}

    [CqlDeclaration("Results")]
	public IEnumerable<string> Results() => 
		__Results.Value;

    [CqlDeclaration("CalendarAgeInYearsAt")]
	public int? CalendarAgeInYearsAt(CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		var a_ = context.Operators.ConvertDateTimeToDate(BirthDateTime);
		var b_ = context.Operators.ConvertDateTimeToDate(AsOf);
		var c_ = context.Operators.DurationBetween(a_, b_, "year");

		return c_;
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

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
	public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
	{
		var a_ = this.HospitalizationWithObservation(Encounter);
		var b_ = this.LengthInDays(a_);

		return b_;
	}

}