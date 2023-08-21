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

    private CqlValueSet Bicarbonate_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", 
			null);
    }

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
    public CqlValueSet Bicarbonate_lab_test() => __Bicarbonate_lab_test.Value;

    private CqlValueSet Body_temperature_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", 
			null);
    }

    [CqlDeclaration("Body temperature")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152")]
    public CqlValueSet Body_temperature() => __Body_temperature.Value;

    private CqlValueSet Body_weight_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", 
			null);
    }

    [CqlDeclaration("Body weight")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159")]
    public CqlValueSet Body_weight() => __Body_weight.Value;

    private CqlValueSet Creatinine_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", 
			null);
    }

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
    public CqlValueSet Creatinine_lab_test() => __Creatinine_lab_test.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", 
			null);
    }

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Ethnicity_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", 
			null);
    }

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity() => __Ethnicity.Value;

    private CqlValueSet Glucose_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", 
			null);
    }

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hematocrit_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", 
			null);
    }

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
    public CqlValueSet Hematocrit_lab_test() => __Hematocrit_lab_test.Value;

    private CqlValueSet Medicare_payer_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", 
			null);
    }

    [CqlDeclaration("Medicare payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
    public CqlValueSet Medicare_payer() => __Medicare_payer.Value;

    private CqlValueSet Observation_Services_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", 
			null);
    }

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet ONC_Administrative_Sex_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", 
			null);
    }

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex() => __ONC_Administrative_Sex.Value;

    private CqlValueSet Payer_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", 
			null);
    }

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer() => __Payer.Value;

    private CqlValueSet Potassium_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", 
			null);
    }

    [CqlDeclaration("Potassium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117")]
    public CqlValueSet Potassium_lab_test() => __Potassium_lab_test.Value;

    private CqlValueSet Race_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", 
			null);
    }

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race() => __Race.Value;

    private CqlValueSet Sodium_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", 
			null);
    }

    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
    public CqlValueSet Sodium_lab_test() => __Sodium_lab_test.Value;

    private CqlValueSet White_blood_cells_count_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", 
			null);
    }

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
    public CqlValueSet White_blood_cells_count_lab_test() => __White_blood_cells_count_lab_test.Value;

    private CqlCode Birth_date_Value()
    {
        return new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode Heart_rate_Value()
    {
        return new CqlCode("8867-4", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Heart rate")]
    public CqlCode Heart_rate() => __Heart_rate.Value;

    private CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value()
    {
        return new CqlCode("59408-5", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry() => __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry.Value;

    private CqlCode Respiratory_rate_Value()
    {
        return new CqlCode("9279-1", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Respiratory rate")]
    public CqlCode Respiratory_rate() => __Respiratory_rate.Value;

    private CqlCode Systolic_blood_pressure_Value()
    {
        return new CqlCode("8480-6", 
			"http://loinc.org", 
			null, 
			null);
    }

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
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("HybridHWRFHIR-1.3.005", 
			"Measurement Period", 
			(context?.Operators.Interval(context?.Operators.DateTime(((int?)2019), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				context?.Operators.DateTime(((int?)2020), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				true, 
				false) as object)));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		return SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		return SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		return SupplementalDataElementsFHIR4_2_0_000.SDE_Race();
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		return SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    [CqlDeclaration("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var b_ = TheEncounter;
		var a_ = new Encounter[]
		{
			b_,
		};
		Func<Encounter,CqlInterval<CqlDateTime>> ed_ = (Visit) => 
		{
			var e_ = this.Emergency_Department_Visit();
			var f_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(e_, 
				null);
			Func<Encounter,bool?> cu_ = (LastED) => 
			{
				var g_ = LastED?.Period;
				var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
				var i_ = context?.Operators.End(h_);
				var l_ = this.Observation_Services();
				var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(l_, 
					null);
				Func<Encounter,bool?> ae_ = (LastObs) => 
				{
					var n_ = LastObs?.Period;
					var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
					var p_ = context?.Operators.End(o_);
					var q_ = Visit?.Period;
					var r_ = FHIRHelpers_4_0_001.ToInterval(q_);
					var s_ = context?.Operators.Start(r_);
					var t_ = context?.Operators.Quantity(1m, 
						"hour");
					var u_ = context?.Operators.Subtract(s_, 
						t_);
					var y_ = context?.Operators.Interval(u_, 
						s_, 
						true, 
						true);
					var z_ = context?.Operators.ElementInInterval<CqlDateTime>(p_, 
						y_, 
						null);
					bool? aa_ = ((bool?)(context?.Operators.Start(r_) == null));
					var ad_ = context?.Operators.Not(aa_);
					return context?.Operators.And(z_, 
						ad_);
				};
				var af_ = context?.Operators.WhereOrNull<Encounter>(m_, 
					ae_);
				Func<Encounter,object> ag_ = (@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period));
				var ah_ = context?.Operators.ListSortBy<Encounter>(af_, 
					ag_, 
					System.ComponentModel.ListSortDirection.Ascending);
				var k_ = context?.Operators.LastOfList<Encounter>(ah_)?.Period;
				var ai_ = FHIRHelpers_4_0_001.ToInterval(k_);
				var aj_ = Visit?.Period;
				var ak_ = FHIRHelpers_4_0_001.ToInterval(aj_);
				var j_ = (context?.Operators.Start(ai_) ?? context?.Operators.Start(ak_));
				var al_ = context?.Operators.Quantity(1m, 
					"hour");
				var am_ = context?.Operators.Subtract(j_, 
					al_);
				Func<Encounter,bool?> bi_ = (LastObs) => 
				{
					var ar_ = LastObs?.Period;
					var as_ = FHIRHelpers_4_0_001.ToInterval(ar_);
					var at_ = context?.Operators.End(as_);
					var au_ = Visit?.Period;
					var av_ = FHIRHelpers_4_0_001.ToInterval(au_);
					var aw_ = context?.Operators.Start(av_);
					var ax_ = context?.Operators.Quantity(1m, 
						"hour");
					var ay_ = context?.Operators.Subtract(aw_, 
						ax_);
					var bc_ = context?.Operators.Interval(ay_, 
						aw_, 
						true, 
						true);
					var bd_ = context?.Operators.ElementInInterval<CqlDateTime>(at_, 
						bc_, 
						null);
					bool? be_ = ((bool?)(context?.Operators.Start(av_) == null));
					var bh_ = context?.Operators.Not(be_);
					return context?.Operators.And(bd_, 
						bh_);
				};
				var bj_ = context?.Operators.WhereOrNull<Encounter>(m_, 
					bi_);
				var bl_ = context?.Operators.ListSortBy<Encounter>(bj_, 
					ag_, 
					System.ComponentModel.ListSortDirection.Ascending);
				var ao_ = context?.Operators.LastOfList<Encounter>(bl_)?.Period;
				var bm_ = FHIRHelpers_4_0_001.ToInterval(ao_);
				var an_ = (context?.Operators.Start(bm_) ?? context?.Operators.Start(ak_));
				var bp_ = context?.Operators.Interval(am_, 
					an_, 
					true, 
					true);
				var bq_ = context?.Operators.ElementInInterval<CqlDateTime>(i_, 
					bp_, 
					null);
				Func<Encounter,bool?> cm_ = (LastObs) => 
				{
					var bv_ = LastObs?.Period;
					var bw_ = FHIRHelpers_4_0_001.ToInterval(bv_);
					var bx_ = context?.Operators.End(bw_);
					var by_ = Visit?.Period;
					var bz_ = FHIRHelpers_4_0_001.ToInterval(by_);
					var ca_ = context?.Operators.Start(bz_);
					var cb_ = context?.Operators.Quantity(1m, 
						"hour");
					var cc_ = context?.Operators.Subtract(ca_, 
						cb_);
					var cg_ = context?.Operators.Interval(cc_, 
						ca_, 
						true, 
						true);
					var ch_ = context?.Operators.ElementInInterval<CqlDateTime>(bx_, 
						cg_, 
						null);
					bool? ci_ = ((bool?)(context?.Operators.Start(bz_) == null));
					var cl_ = context?.Operators.Not(ci_);
					return context?.Operators.And(ch_, 
						cl_);
				};
				var cn_ = context?.Operators.WhereOrNull<Encounter>(m_, 
					cm_);
				var cp_ = context?.Operators.ListSortBy<Encounter>(cn_, 
					ag_, 
					System.ComponentModel.ListSortDirection.Ascending);
				var bs_ = context?.Operators.LastOfList<Encounter>(cp_)?.Period;
				var cq_ = FHIRHelpers_4_0_001.ToInterval(bs_);
				bool? br_ = ((bool?)((context?.Operators.Start(cq_) ?? context?.Operators.Start(ak_)) == null));
				var ct_ = context?.Operators.Not(br_);
				return context?.Operators.And(bq_, 
					ct_);
			};
			var cv_ = context?.Operators.WhereOrNull<Encounter>(f_, 
				cu_);
			Func<Encounter,object> cw_ = (@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period));
			var cx_ = context?.Operators.ListSortBy<Encounter>(cv_, 
				cw_, 
				System.ComponentModel.ListSortDirection.Ascending);
			var d_ = context?.Operators.LastOfList<Encounter>(cx_)?.Period;
			var cy_ = FHIRHelpers_4_0_001.ToInterval(d_);
			var da_ = this.Observation_Services();
			var db_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(da_, 
				null);
			Func<Encounter,bool?> dt_ = (LastObs) => 
			{
				var dc_ = LastObs?.Period;
				var dd_ = FHIRHelpers_4_0_001.ToInterval(dc_);
				var de_ = context?.Operators.End(dd_);
				var df_ = Visit?.Period;
				var dg_ = FHIRHelpers_4_0_001.ToInterval(df_);
				var dh_ = context?.Operators.Start(dg_);
				var di_ = context?.Operators.Quantity(1m, 
					"hour");
				var dj_ = context?.Operators.Subtract(dh_, 
					di_);
				var dn_ = context?.Operators.Interval(dj_, 
					dh_, 
					true, 
					true);
				var do_ = context?.Operators.ElementInInterval<CqlDateTime>(de_, 
					dn_, 
					null);
				bool? dp_ = ((bool?)(context?.Operators.Start(dg_) == null));
				var ds_ = context?.Operators.Not(dp_);
				return context?.Operators.And(do_, 
					ds_);
			};
			var du_ = context?.Operators.WhereOrNull<Encounter>(db_, 
				dt_);
			var dw_ = context?.Operators.ListSortBy<Encounter>(du_, 
				cw_, 
				System.ComponentModel.ListSortDirection.Ascending);
			var cz_ = context?.Operators.LastOfList<Encounter>(dw_)?.Period;
			var dx_ = FHIRHelpers_4_0_001.ToInterval(cz_);
			var dy_ = Visit?.Period;
			var dz_ = FHIRHelpers_4_0_001.ToInterval(dy_);
			var c_ = (context?.Operators.Start(cy_) ?? (context?.Operators.Start(dx_) ?? context?.Operators.Start(dz_)));
			var ec_ = context?.Operators.End(dz_);
			return context?.Operators.Interval(c_, 
				ec_, 
				true, 
				true);
		};
		var ee_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, 
			ed_);
		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(ee_);
	}

    [CqlDeclaration("LengthInDays")]
    public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context?.Operators.Start(Value);
		var b_ = context?.Operators.End(Value);
		return context?.Operators.DifferenceBetween(a_, 
			b_, 
			"day");
	}

    private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			null);
		Func<Encounter,IEnumerable<Coverage>> d_ = (_InpatientEncounter) => 
		{
			var c_ = this.Medicare_payer();
			return context?.DataRetriever.RetrieveByValueSet<Coverage>(c_, 
				null);
		};
		Func<Encounter,Coverage,Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV> g_ = (_InpatientEncounter, _Payer) => 
		{
			var e_ = _InpatientEncounter;
			var f_ = _Payer;
			return new Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV
			{
				InpatientEncounter = e_,
				Payer = f_,
			};
		};
		var h_ = context?.Operators.SelectManyResultsOrNull<Encounter, Coverage, Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(b_, 
			d_, 
			g_);
		Func<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV,bool?> ah_ = (tuple_czdryxljaejapsirauhdxvhpv) => 
		{
			var j_ = (tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.StatusElement as object);
			var i_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(j_) as object);
			var k_ = ("finished" as object);
			var l_ = context?.Operators.Equal(i_, 
				k_);
			var n_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
			var o_ = this.HospitalizationWithObservation(n_);
			var m_ = (this.LengthInDays(o_) as object);
			var p_ = (((int?)365) as object);
			var q_ = context?.Operators.Less(m_, 
				p_);
			var r_ = context?.Operators.And(l_, 
				q_);
			var s_ = tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter?.Period;
			var t_ = FHIRHelpers_4_0_001.ToInterval(s_);
			var u_ = context?.Operators.End(t_);
			var v_ = this.Measurement_Period();
			var w_ = context?.Operators.ElementInInterval<CqlDateTime>(u_, 
				v_, 
				"day");
			var x_ = context?.Operators.And(r_, 
				w_);
			var z_ = (this.Patient()?.BirthDateElement?.Value as object);
			var aa_ = context?.Operators?.TypeConverter.Convert<CqlDate>(z_);
			var ad_ = context?.Operators.Start(t_);
			var ae_ = context?.Operators.DateFrom(ad_);
			var y_ = (context?.Operators.CalculateAgeAt(aa_, 
				ae_, 
				"year") as object);
			var af_ = (((int?)65) as object);
			var ag_ = context?.Operators.GreaterOrEqual(y_, 
				af_);
			return context?.Operators.And(x_, 
				ag_);
		};
		var ai_ = context?.Operators.WhereOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV>(h_, 
			ah_);
		Func<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV,Encounter> aj_ = (tuple_czdryxljaejapsirauhdxvhpv) => tuple_czdryxljaejapsirauhdxvhpv?.InpatientEncounter;
		return context?.Operators.SelectOrNull<Tuples.Tuple_CZdRYXLJAeJaPSIRaUHDXVHPV, Encounter>(ai_, 
			aj_);
	}

    [CqlDeclaration("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters() => __Inpatient_Encounters.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		return this.Inpatient_Encounters();
	}

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    [CqlDeclaration("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(IEnumerable<Observation> ExamList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		Func<Encounter,string> cl_ = (Encounter) => 
		{
			var h_ = ("\r\n" ?? "");
			var i_ = (CCDE ?? "");
			var g_ = (context?.Operators.Concatenate(h_, 
				i_) ?? "");
			var j_ = ("," ?? "");
			var f_ = (context?.Operators.Concatenate(g_, 
				j_) ?? "");
			var l_ = (Encounter?.IdElement as object);
			var k_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(l_) ?? "");
			var e_ = (context?.Operators.Concatenate(f_, 
				k_) ?? "");
			var d_ = (context?.Operators.Concatenate(e_, 
				j_) ?? "");
			Func<Observation,bool?> at_ = (Exam) => 
			{
				var q_ = (Exam?.Effective as object);
				var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
				bool? p_ = ((bool?)(context?.Operators.Start(r_) == null));
				var s_ = context?.Operators.Not(p_);
				var v_ = context?.Operators.Start(r_);
				var w_ = Encounter?.Period;
				var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
				var y_ = context?.Operators.Start(x_);
				var z_ = context?.Operators.Quantity(1440m, 
					"minutes");
				var aa_ = context?.Operators.Subtract(y_, 
					z_);
				var ae_ = context?.Operators.Quantity(120m, 
					"minutes");
				var af_ = context?.Operators.Add(y_, 
					ae_);
				var ag_ = context?.Operators.Interval(aa_, 
					af_, 
					true, 
					true);
				var ah_ = context?.Operators.ElementInInterval<CqlDateTime>(v_, 
					ag_, 
					null);
				var ai_ = context?.Operators.And(s_, 
					ah_);
				var aj_ = (Exam?.StatusElement as object);
				var ak_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(aj_);
				var am_ = "final";
				var an_ = "amended";
				var ao_ = "preliminary";
				var al_ = (new string[]
				{
					am_,
					an_,
					ao_,
				} as IEnumerable<string>);
				var ap_ = context?.Operators.InList<string>(ak_, 
					al_);
				var aq_ = context?.Operators.And(ai_, 
					ap_);
				bool? ar_ = ((bool?)((Exam?.Value as object) == null));
				var as_ = context?.Operators.Not(ar_);
				return context?.Operators.And(aq_, 
					as_);
			};
			var au_ = context?.Operators.WhereOrNull<Observation>(ExamList, 
				at_);
			Func<Observation,object> av_ = (@this) => context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((@this?.Effective as object)));
			var aw_ = context?.Operators.ListSortBy<Observation>(au_, 
				av_, 
				System.ComponentModel.ListSortDirection.Ascending);
			var o_ = ((context?.Operators.FirstOfList<Observation>(aw_)?.Value as object) as Quantity);
			var ax_ = FHIRHelpers_4_0_001.ToQuantity(o_);
			var n_ = (context?.Operators.ConvertQuantityToString(ax_) ?? "");
			var c_ = (context?.Operators.Concatenate(d_, 
				n_) ?? "");
			var b_ = (context?.Operators.Concatenate(c_, 
				j_) ?? "");
			Func<Observation,bool?> cf_ = (Exam) => 
			{
				var bc_ = (Exam?.Effective as object);
				var bd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bc_);
				bool? bb_ = ((bool?)(context?.Operators.Start(bd_) == null));
				var be_ = context?.Operators.Not(bb_);
				var bh_ = context?.Operators.Start(bd_);
				var bi_ = Encounter?.Period;
				var bj_ = FHIRHelpers_4_0_001.ToInterval(bi_);
				var bk_ = context?.Operators.Start(bj_);
				var bl_ = context?.Operators.Quantity(1440m, 
					"minutes");
				var bm_ = context?.Operators.Subtract(bk_, 
					bl_);
				var bq_ = context?.Operators.Quantity(120m, 
					"minutes");
				var br_ = context?.Operators.Add(bk_, 
					bq_);
				var bs_ = context?.Operators.Interval(bm_, 
					br_, 
					true, 
					true);
				var bt_ = context?.Operators.ElementInInterval<CqlDateTime>(bh_, 
					bs_, 
					null);
				var bu_ = context?.Operators.And(be_, 
					bt_);
				var bv_ = (Exam?.StatusElement as object);
				var bw_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bv_);
				var by_ = "final";
				var bz_ = "amended";
				var ca_ = "preliminary";
				var bx_ = (new string[]
				{
					by_,
					bz_,
					ca_,
				} as IEnumerable<string>);
				var cb_ = context?.Operators.InList<string>(bw_, 
					bx_);
				var cc_ = context?.Operators.And(bu_, 
					cb_);
				bool? cd_ = ((bool?)((Exam?.Value as object) == null));
				var ce_ = context?.Operators.Not(cd_);
				return context?.Operators.And(cc_, 
					ce_);
			};
			var cg_ = context?.Operators.WhereOrNull<Observation>(ExamList, 
				cf_);
			var ci_ = context?.Operators.ListSortBy<Observation>(cg_, 
				av_, 
				System.ComponentModel.ListSortDirection.Ascending);
			var ba_ = (context?.Operators.FirstOfList<Observation>(ci_)?.Effective as object);
			var cj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ba_);
			var ck_ = context?.Operators.Start(cj_);
			var az_ = (context?.Operators.ConvertDateTimeToString(ck_) ?? "");
			return context?.Operators.Concatenate(b_, 
				az_);
		};
		return context?.Operators.SelectOrNull<Encounter, string>(a_, 
			cl_);
	}

    [CqlDeclaration("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(IEnumerable<Observation> ExamList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		Func<Encounter,string> cl_ = (Encounter) => 
		{
			var h_ = ("\r\n" ?? "");
			var i_ = (CCDE ?? "");
			var g_ = (context?.Operators.Concatenate(h_, 
				i_) ?? "");
			var j_ = ("," ?? "");
			var f_ = (context?.Operators.Concatenate(g_, 
				j_) ?? "");
			var l_ = (Encounter?.IdElement as object);
			var k_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(l_) ?? "");
			var e_ = (context?.Operators.Concatenate(f_, 
				k_) ?? "");
			var d_ = (context?.Operators.Concatenate(e_, 
				j_) ?? "");
			Func<Observation,bool?> at_ = (Exam) => 
			{
				var q_ = (Exam?.Effective as object);
				var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
				bool? p_ = ((bool?)(context?.Operators.Start(r_) == null));
				var s_ = context?.Operators.Not(p_);
				var v_ = context?.Operators.Start(r_);
				var w_ = Encounter?.Period;
				var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
				var y_ = context?.Operators.Start(x_);
				var z_ = context?.Operators.Quantity(1440m, 
					"minutes");
				var aa_ = context?.Operators.Subtract(y_, 
					z_);
				var af_ = context?.Operators.Add(y_, 
					z_);
				var ag_ = context?.Operators.Interval(aa_, 
					af_, 
					true, 
					true);
				var ah_ = context?.Operators.ElementInInterval<CqlDateTime>(v_, 
					ag_, 
					null);
				var ai_ = context?.Operators.And(s_, 
					ah_);
				var aj_ = (Exam?.StatusElement as object);
				var ak_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(aj_);
				var am_ = "final";
				var an_ = "amended";
				var ao_ = "preliminary";
				var al_ = (new string[]
				{
					am_,
					an_,
					ao_,
				} as IEnumerable<string>);
				var ap_ = context?.Operators.InList<string>(ak_, 
					al_);
				var aq_ = context?.Operators.And(ai_, 
					ap_);
				bool? ar_ = ((bool?)((Exam?.Value as object) == null));
				var as_ = context?.Operators.Not(ar_);
				return context?.Operators.And(aq_, 
					as_);
			};
			var au_ = context?.Operators.WhereOrNull<Observation>(ExamList, 
				at_);
			Func<Observation,object> av_ = (@this) => context?.Operators.Start(MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((@this?.Effective as object)));
			var aw_ = context?.Operators.ListSortBy<Observation>(au_, 
				av_, 
				System.ComponentModel.ListSortDirection.Ascending);
			var o_ = ((context?.Operators.FirstOfList<Observation>(aw_)?.Value as object) as Quantity);
			var ax_ = FHIRHelpers_4_0_001.ToQuantity(o_);
			var n_ = (context?.Operators.ConvertQuantityToString(ax_) ?? "");
			var c_ = (context?.Operators.Concatenate(d_, 
				n_) ?? "");
			var b_ = (context?.Operators.Concatenate(c_, 
				j_) ?? "");
			Func<Observation,bool?> cf_ = (Exam) => 
			{
				var bc_ = (Exam?.Effective as object);
				var bd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bc_);
				bool? bb_ = ((bool?)(context?.Operators.Start(bd_) == null));
				var be_ = context?.Operators.Not(bb_);
				var bh_ = context?.Operators.Start(bd_);
				var bi_ = Encounter?.Period;
				var bj_ = FHIRHelpers_4_0_001.ToInterval(bi_);
				var bk_ = context?.Operators.Start(bj_);
				var bl_ = context?.Operators.Quantity(1440m, 
					"minutes");
				var bm_ = context?.Operators.Subtract(bk_, 
					bl_);
				var br_ = context?.Operators.Add(bk_, 
					bl_);
				var bs_ = context?.Operators.Interval(bm_, 
					br_, 
					true, 
					true);
				var bt_ = context?.Operators.ElementInInterval<CqlDateTime>(bh_, 
					bs_, 
					null);
				var bu_ = context?.Operators.And(be_, 
					bt_);
				var bv_ = (Exam?.StatusElement as object);
				var bw_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bv_);
				var by_ = "final";
				var bz_ = "amended";
				var ca_ = "preliminary";
				var bx_ = (new string[]
				{
					by_,
					bz_,
					ca_,
				} as IEnumerable<string>);
				var cb_ = context?.Operators.InList<string>(bw_, 
					bx_);
				var cc_ = context?.Operators.And(bu_, 
					cb_);
				bool? cd_ = ((bool?)((Exam?.Value as object) == null));
				var ce_ = context?.Operators.Not(cd_);
				return context?.Operators.And(cc_, 
					ce_);
			};
			var cg_ = context?.Operators.WhereOrNull<Observation>(ExamList, 
				cf_);
			var ci_ = context?.Operators.ListSortBy<Observation>(cg_, 
				av_, 
				System.ComponentModel.ListSortDirection.Ascending);
			var ba_ = (context?.Operators.FirstOfList<Observation>(ci_)?.Effective as object);
			var cj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ba_);
			var ck_ = context?.Operators.Start(cj_);
			var az_ = (context?.Operators.ConvertDateTimeToString(ck_) ?? "");
			return context?.Operators.Concatenate(b_, 
				az_);
		};
		return context?.Operators.SelectOrNull<Encounter, string>(a_, 
			cl_);
	}

    [CqlDeclaration("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(IEnumerable<Observation> LabList, string CCDE)
	{
		var a_ = this.Inpatient_Encounters();
		Func<Encounter,string> ce_ = (Encounter) => 
		{
			var h_ = ("\r\n" ?? "");
			var i_ = (CCDE ?? "");
			var g_ = (context?.Operators.Concatenate(h_, 
				i_) ?? "");
			var j_ = ("," ?? "");
			var f_ = (context?.Operators.Concatenate(g_, 
				j_) ?? "");
			var l_ = (Encounter?.IdElement as object);
			var k_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(l_) ?? "");
			var e_ = (context?.Operators.Concatenate(f_, 
				k_) ?? "");
			var d_ = (context?.Operators.Concatenate(e_, 
				j_) ?? "");
			Func<Observation,bool?> aq_ = (Lab) => 
			{
				bool? p_ = ((bool?)(Lab?.IssuedElement == null));
				var q_ = context?.Operators.Not(p_);
				var r_ = Lab?.IssuedElement;
				var s_ = FHIRHelpers_4_0_001.ToDateTime(r_);
				var t_ = Encounter?.Period;
				var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
				var v_ = context?.Operators.Start(u_);
				var w_ = context?.Operators.Quantity(1440m, 
					"minutes");
				var x_ = context?.Operators.Subtract(v_, 
					w_);
				var ac_ = context?.Operators.Add(v_, 
					w_);
				var ad_ = context?.Operators.Interval(x_, 
					ac_, 
					true, 
					true);
				var ae_ = context?.Operators.ElementInInterval<CqlDateTime>(s_, 
					ad_, 
					null);
				var af_ = context?.Operators.And(q_, 
					ae_);
				var ag_ = (Lab?.StatusElement as object);
				var ah_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ag_);
				var aj_ = "final";
				var ak_ = "amended";
				var al_ = "preliminary";
				var ai_ = (new string[]
				{
					aj_,
					ak_,
					al_,
				} as IEnumerable<string>);
				var am_ = context?.Operators.InList<string>(ah_, 
					ai_);
				var an_ = context?.Operators.And(af_, 
					am_);
				bool? ao_ = ((bool?)((Lab?.Value as object) == null));
				var ap_ = context?.Operators.Not(ao_);
				return context?.Operators.And(an_, 
					ap_);
			};
			var ar_ = context?.Operators.WhereOrNull<Observation>(LabList, 
				aq_);
			Func<Observation,object> as_ = (@this) => @this?.IssuedElement;
			var at_ = context?.Operators.ListSortBy<Observation>(ar_, 
				as_, 
				System.ComponentModel.ListSortDirection.Ascending);
			var o_ = ((context?.Operators.FirstOfList<Observation>(at_)?.Value as object) as Quantity);
			var au_ = FHIRHelpers_4_0_001.ToQuantity(o_);
			var n_ = (context?.Operators.ConvertQuantityToString(au_) ?? "");
			var c_ = (context?.Operators.Concatenate(d_, 
				n_) ?? "");
			var b_ = (context?.Operators.Concatenate(c_, 
				j_) ?? "");
			Func<Observation,bool?> bz_ = (Lab) => 
			{
				bool? ay_ = ((bool?)(Lab?.IssuedElement == null));
				var az_ = context?.Operators.Not(ay_);
				var ba_ = Lab?.IssuedElement;
				var bb_ = FHIRHelpers_4_0_001.ToDateTime(ba_);
				var bc_ = Encounter?.Period;
				var bd_ = FHIRHelpers_4_0_001.ToInterval(bc_);
				var be_ = context?.Operators.Start(bd_);
				var bf_ = context?.Operators.Quantity(1440m, 
					"minutes");
				var bg_ = context?.Operators.Subtract(be_, 
					bf_);
				var bl_ = context?.Operators.Add(be_, 
					bf_);
				var bm_ = context?.Operators.Interval(bg_, 
					bl_, 
					true, 
					true);
				var bn_ = context?.Operators.ElementInInterval<CqlDateTime>(bb_, 
					bm_, 
					null);
				var bo_ = context?.Operators.And(az_, 
					bn_);
				var bp_ = (Lab?.StatusElement as object);
				var bq_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bp_);
				var bs_ = "final";
				var bt_ = "amended";
				var bu_ = "preliminary";
				var br_ = (new string[]
				{
					bs_,
					bt_,
					bu_,
				} as IEnumerable<string>);
				var bv_ = context?.Operators.InList<string>(bq_, 
					br_);
				var bw_ = context?.Operators.And(bo_, 
					bv_);
				bool? bx_ = ((bool?)((Lab?.Value as object) == null));
				var by_ = context?.Operators.Not(bx_);
				return context?.Operators.And(bw_, 
					by_);
			};
			var ca_ = context?.Operators.WhereOrNull<Observation>(LabList, 
				bz_);
			var cc_ = context?.Operators.ListSortBy<Observation>(ca_, 
				as_, 
				System.ComponentModel.ListSortDirection.Ascending);
			var ax_ = context?.Operators.FirstOfList<Observation>(cc_)?.IssuedElement;
			var cd_ = FHIRHelpers_4_0_001.ToDateTime(ax_);
			var aw_ = (context?.Operators.ConvertDateTimeToString(cd_) ?? "");
			return context?.Operators.Concatenate(b_, 
				aw_);
		};
		return context?.Operators.SelectOrNull<Encounter, string>(a_, 
			ce_);
	}

    private IEnumerable<string> Results_Value()
	{
		var c_ = this.Heart_rate();
		var d_ = context?.Operators.ToList<CqlCode>(c_);
		var e_ = context?.DataRetriever.RetrieveByCodes<Observation>(d_, 
			null);
		var b_ = this.FirstPhysicalExamWithEncounterId(e_, 
			"FirstHeartRate");
		var g_ = this.Systolic_blood_pressure();
		var h_ = context?.Operators.ToList<CqlCode>(g_);
		var i_ = context?.DataRetriever.RetrieveByCodes<Observation>(h_, 
			null);
		var f_ = this.FirstPhysicalExamWithEncounterId(i_, 
			"FirstSystolicBP");
		var k_ = this.Respiratory_rate();
		var l_ = context?.Operators.ToList<CqlCode>(k_);
		var m_ = context?.DataRetriever.RetrieveByCodes<Observation>(l_, 
			null);
		var j_ = this.FirstPhysicalExamWithEncounterId(m_, 
			"FirstRespRate");
		var o_ = this.Body_temperature();
		var p_ = context?.DataRetriever.RetrieveByValueSet<Observation>(o_, 
			null);
		var n_ = this.FirstPhysicalExamWithEncounterId(p_, 
			"FirstTemperature");
		var r_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry();
		var s_ = context?.Operators.ToList<CqlCode>(r_);
		var t_ = context?.DataRetriever.RetrieveByCodes<Observation>(s_, 
			null);
		var q_ = this.FirstPhysicalExamWithEncounterId(t_, 
			"FirstO2Saturation");
		var v_ = this.Body_weight();
		var w_ = context?.DataRetriever.RetrieveByValueSet<Observation>(v_, 
			null);
		var u_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(w_, 
			"FirstWeight");
		var y_ = this.Hematocrit_lab_test();
		var z_ = context?.DataRetriever.RetrieveByValueSet<Observation>(y_, 
			null);
		var x_ = this.FirstLabTestWithEncounterId(z_, 
			"FirstHematocrit");
		var ab_ = this.White_blood_cells_count_lab_test();
		var ac_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ab_, 
			null);
		var aa_ = this.FirstLabTestWithEncounterId(ac_, 
			"FirstWhiteBloodCell");
		var ae_ = this.Potassium_lab_test();
		var af_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ae_, 
			null);
		var ad_ = this.FirstLabTestWithEncounterId(af_, 
			"FirstPotassium");
		var ah_ = this.Sodium_lab_test();
		var ai_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ah_, 
			null);
		var ag_ = this.FirstLabTestWithEncounterId(ai_, 
			"FirstSodium");
		var ak_ = this.Bicarbonate_lab_test();
		var al_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ak_, 
			null);
		var aj_ = this.FirstLabTestWithEncounterId(al_, 
			"FirstBicarbonate");
		var an_ = this.Creatinine_lab_test();
		var ao_ = context?.DataRetriever.RetrieveByValueSet<Observation>(an_, 
			null);
		var am_ = this.FirstLabTestWithEncounterId(ao_, 
			"FirstCreatinine");
		var aq_ = this.Glucose_lab_test();
		var ar_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aq_, 
			null);
		var ap_ = this.FirstLabTestWithEncounterId(ar_, 
			"FirstGlucose");
		var a_ = (new IEnumerable<string>[]
		{
			b_,
			f_,
			j_,
			n_,
			q_,
			u_,
			x_,
			aa_,
			ad_,
			ag_,
			aj_,
			am_,
			ap_,
		} as IEnumerable<IEnumerable<string>>);
		return context?.Operators.FlattenList<string>(a_);
	}

    [CqlDeclaration("Results")]
    public IEnumerable<string> Results() => __Results.Value;

    [CqlDeclaration("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlDateTime BirthDateTime, CqlDateTime AsOf)
	{
		var a_ = context?.Operators.ConvertDateTimeToDate(BirthDateTime);
		var b_ = context?.Operators.ConvertDateTimeToDate(AsOf);
		return context?.Operators.DurationBetween(a_, 
			b_, 
			"year");
	}

    [CqlDeclaration("ToDate")]
    public CqlDateTime ToDate(CqlDateTime Value)
	{
		var a_ = context?.Operators.ComponentFrom(Value, 
			"year");
		var b_ = context?.Operators.ComponentFrom(Value, 
			"month");
		var c_ = context?.Operators.ComponentFrom(Value, 
			"day");
		int? d_ = ((int?)0);
		var h_ = context?.Operators.TimezoneOffsetFrom(Value);
		return context?.Operators.DateTime(a_, 
			b_, 
			c_, 
			d_, 
			d_, 
			d_, 
			d_, 
			h_);
	}

    [CqlDeclaration("LengthOfStay")]
    public int? LengthOfStay(CqlInterval<CqlDateTime> Stay)
	{
		var a_ = context?.Operators.Start(Stay);
		var b_ = context?.Operators.End(Stay);
		return context?.Operators.DifferenceBetween(a_, 
			b_, 
			"day");
	}

    [CqlDeclaration("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(Encounter Encounter)
	{
		var a_ = this.HospitalizationWithObservation(Encounter);
		return this.LengthInDays(a_);
	}

}