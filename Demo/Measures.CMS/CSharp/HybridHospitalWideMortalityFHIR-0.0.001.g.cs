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
[CqlLibrary("HybridHospitalWideMortalityFHIR", "0.0.001")]
public class HybridHospitalWideMortalityFHIR_0_0_001
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bicarbonate_lab_test;
    internal Lazy<CqlValueSet> __Creatinine_lab_test;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Hematocrit_lab_test;
    internal Lazy<CqlValueSet> __Medicare_Advantage_payer;
    internal Lazy<CqlValueSet> __Medicare_FFS_payer;
    internal Lazy<CqlValueSet> __Oxygen_Saturation_by_Pulse_Oximetry;
    internal Lazy<CqlValueSet> __Platelet_count_lab_test;
    internal Lazy<CqlValueSet> __Sodium_lab_test;
    internal Lazy<CqlValueSet> __White_blood_cells_count_lab_test;
    internal Lazy<CqlCode> __Oxygen_saturation_in_Arterial_blood;
    internal Lazy<CqlCode> __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    internal Lazy<CqlCode> __Systolic_blood_pressure;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlCode[]> __Source_of_Payment_Typology;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounters;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>> __Encounter_with_First_Body_Temperature;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>> __Encounter_with_First_Heart_Rate;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>> __Encounter_with_First_Oxygen_Saturation;
    internal Lazy<IEnumerable<Observation>> __Blood_Pressure_Reading;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_First_Systolic_Blood_Pressure;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>> __Encounter_with_First_Bicarbonate_Lab_Test;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>> __Encounter_with_First_Creatinine_Lab_Test;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>> __Encounter_with_First_Hematocrit_Lab_Test;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>> __Encounter_with_First_Platelet_Lab_Test;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>> __Encounter_with_First_Sodium_Lab_Test;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>> __Encounter_with_First_White_Blood_Cells_Lab_Test;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public HybridHospitalWideMortalityFHIR_0_0_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Bicarbonate_lab_test = new Lazy<CqlValueSet>(this.Bicarbonate_lab_test_Value);
        __Creatinine_lab_test = new Lazy<CqlValueSet>(this.Creatinine_lab_test_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Hematocrit_lab_test = new Lazy<CqlValueSet>(this.Hematocrit_lab_test_Value);
        __Medicare_Advantage_payer = new Lazy<CqlValueSet>(this.Medicare_Advantage_payer_Value);
        __Medicare_FFS_payer = new Lazy<CqlValueSet>(this.Medicare_FFS_payer_Value);
        __Oxygen_Saturation_by_Pulse_Oximetry = new Lazy<CqlValueSet>(this.Oxygen_Saturation_by_Pulse_Oximetry_Value);
        __Platelet_count_lab_test = new Lazy<CqlValueSet>(this.Platelet_count_lab_test_Value);
        __Sodium_lab_test = new Lazy<CqlValueSet>(this.Sodium_lab_test_Value);
        __White_blood_cells_count_lab_test = new Lazy<CqlValueSet>(this.White_blood_cells_count_lab_test_Value);
        __Oxygen_saturation_in_Arterial_blood = new Lazy<CqlCode>(this.Oxygen_saturation_in_Arterial_blood_Value);
        __Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new Lazy<CqlCode>(this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry_Value);
        __Systolic_blood_pressure = new Lazy<CqlCode>(this.Systolic_blood_pressure_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __Source_of_Payment_Typology = new Lazy<CqlCode[]>(this.Source_of_Payment_Typology_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Inpatient_Encounters = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounters_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Encounter_with_First_Body_Temperature = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>>(this.Encounter_with_First_Body_Temperature_Value);
        __Encounter_with_First_Heart_Rate = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>>(this.Encounter_with_First_Heart_Rate_Value);
        __Encounter_with_First_Oxygen_Saturation = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>>(this.Encounter_with_First_Oxygen_Saturation_Value);
        __Blood_Pressure_Reading = new Lazy<IEnumerable<Observation>>(this.Blood_Pressure_Reading_Value);
        __Encounter_with_First_Systolic_Blood_Pressure = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_First_Systolic_Blood_Pressure_Value);
        __Encounter_with_First_Bicarbonate_Lab_Test = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>>(this.Encounter_with_First_Bicarbonate_Lab_Test_Value);
        __Encounter_with_First_Creatinine_Lab_Test = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>>(this.Encounter_with_First_Creatinine_Lab_Test_Value);
        __Encounter_with_First_Hematocrit_Lab_Test = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>>(this.Encounter_with_First_Hematocrit_Lab_Test_Value);
        __Encounter_with_First_Platelet_Lab_Test = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>>(this.Encounter_with_First_Platelet_Lab_Test_Value);
        __Encounter_with_First_Sodium_Lab_Test = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>>(this.Encounter_with_First_Sodium_Lab_Test_Value);
        __Encounter_with_First_White_Blood_Cells_Lab_Test = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>>(this.Encounter_with_First_White_Blood_Cells_Lab_Test_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Bicarbonate_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", default);

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
	public CqlValueSet Bicarbonate_lab_test() => 
		__Bicarbonate_lab_test.Value;

	private CqlValueSet Creatinine_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", default);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
	public CqlValueSet Creatinine_lab_test() => 
		__Creatinine_lab_test.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Hematocrit_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", default);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public CqlValueSet Hematocrit_lab_test() => 
		__Hematocrit_lab_test.Value;

	private CqlValueSet Medicare_Advantage_payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", default);

    [CqlDeclaration("Medicare Advantage payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12")]
	public CqlValueSet Medicare_Advantage_payer() => 
		__Medicare_Advantage_payer.Value;

	private CqlValueSet Medicare_FFS_payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", default);

    [CqlDeclaration("Medicare FFS payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
	public CqlValueSet Medicare_FFS_payer() => 
		__Medicare_FFS_payer.Value;

	private CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", default);

    [CqlDeclaration("Oxygen Saturation by Pulse Oximetry")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151")]
	public CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry() => 
		__Oxygen_Saturation_by_Pulse_Oximetry.Value;

	private CqlValueSet Platelet_count_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", default);

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
	public CqlValueSet Platelet_count_lab_test() => 
		__Platelet_count_lab_test.Value;

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

	private CqlCode Oxygen_saturation_in_Arterial_blood_Value() => 
		new CqlCode("2708-6", "http://loinc.org", default, default);

    [CqlDeclaration("Oxygen saturation in Arterial blood")]
	public CqlCode Oxygen_saturation_in_Arterial_blood() => 
		__Oxygen_saturation_in_Arterial_blood.Value;

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

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("2708-6", "http://loinc.org", default, default),
			new CqlCode("59408-5", "http://loinc.org", default, default),
			new CqlCode("8480-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] Source_of_Payment_Typology_Value()
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("Source of Payment Typology")]
	public CqlCode[] Source_of_Payment_Typology() => 
		__Source_of_Payment_Typology.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		IEnumerable<Encounter> c_(Encounter InpatientEncounter)
		{
			CqlValueSet e_ = this.Medicare_FFS_payer();
			IEnumerable<Coverage> f_ = context.Operators.RetrieveByValueSet<Coverage>(e_, default);
			CqlValueSet g_ = this.Medicare_Advantage_payer();
			IEnumerable<Coverage> h_ = context.Operators.RetrieveByValueSet<Coverage>(g_, default);
			IEnumerable<Coverage> i_ = context.Operators.Union<Coverage>(f_, h_);
			bool? j_(Coverage MedicarePayer)
			{
				CqlInterval<CqlDateTime> n_ = CQMCommon_2_0_000.hospitalizationWithObservationAndOutpatientSurgeryService(InpatientEncounter);
				int? o_ = CQMCommon_2_0_000.lengthInDays(n_);
				bool? p_ = context.Operators.Less(o_, 365);
				Code<Encounter.EncounterStatus> q_ = InpatientEncounter?.StatusElement;
				Encounter.EncounterStatus? r_ = q_?.Value;
				Code<Encounter.EncounterStatus> s_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(r_);
				bool? t_ = context.Operators.Equal(s_, "finished");
				bool? u_ = context.Operators.And(p_, t_);
				Patient v_ = this.Patient();
				Date w_ = v_?.BirthDateElement;
				string x_ = w_?.Value;
				CqlDate y_ = context.Operators.ConvertStringToDate(x_);
				Period z_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(z_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlDate ac_ = context.Operators.DateFrom(ab_);
				int? ad_ = context.Operators.CalculateAgeAt(y_, ac_, "year");
				CqlInterval<int?> ae_ = context.Operators.Interval(65, 94, true, true);
				bool? af_ = context.Operators.In<int?>(ad_, ae_, default);
				bool? ag_ = context.Operators.And(u_, af_);
				CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_3_000.ToInterval(z_);
				CqlDateTime aj_ = context.Operators.End(ai_);
				CqlInterval<CqlDateTime> ak_ = this.Measurement_Period();
				bool? al_ = context.Operators.In<CqlDateTime>(aj_, ak_, "day");
				bool? am_ = context.Operators.And(ag_, al_);

				return am_;
			};
			IEnumerable<Coverage> k_ = context.Operators.Where<Coverage>(i_, j_);
			Encounter l_(Coverage MedicarePayer) => 
				InpatientEncounter;
			IEnumerable<Encounter> m_ = context.Operators.Select<Coverage, Encounter>(k_, l_);

			return m_;
		};
		IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

		return d_;
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

	private IEnumerable<(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? g_(Observation temperature)
			{
				DataType x_ = temperature?.Effective;
				object y_ = FHIRHelpers_4_3_000.ToValue(x_);
				CqlDateTime z_ = QICoreCommon_2_0_000.earliest(y_);
				Period aa_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_3_000.ToInterval(aa_);
				CqlDateTime ac_ = context.Operators.Start(ab_);
				CqlQuantity ad_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
				CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.ToInterval(aa_);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				CqlQuantity ai_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime aj_ = context.Operators.Add(ah_, ai_);
				CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ae_, aj_, true, true);
				bool? al_ = context.Operators.In<CqlDateTime>(z_, ak_, default);
				Code<ObservationStatus> am_ = temperature?.StatusElement;
				ObservationStatus? an_ = am_?.Value;
				string ao_ = context.Operators.Convert<string>(an_);
				string[] ap_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? aq_ = context.Operators.In<string>(ao_, ap_ as IEnumerable<string>);
				bool? ar_ = context.Operators.And(al_, aq_);
				DataType as_ = temperature?.Value;
				CqlQuantity at_ = FHIRHelpers_4_3_000.ToQuantity(as_ as Quantity);
				bool? au_ = context.Operators.Not((bool?)(at_ is null));
				bool? av_ = context.Operators.And(ar_, au_);

				return av_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType aw_ = @this?.Effective;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				CqlDateTime ay_ = QICoreCommon_2_0_000.earliest(ax_);

				return ay_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.First<Observation>(j_);
			DataType l_ = k_?.Value;
			CqlQuantity m_ = FHIRHelpers_4_3_000.ToQuantity(l_ as Quantity);
			bool? o_(Observation temperature)
			{
				DataType az_ = temperature?.Effective;
				object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
				CqlDateTime bb_ = QICoreCommon_2_0_000.earliest(ba_);
				Period bc_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_3_000.ToInterval(bc_);
				CqlDateTime be_ = context.Operators.Start(bd_);
				CqlQuantity bf_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
				CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_3_000.ToInterval(bc_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime bl_ = context.Operators.Add(bj_, bk_);
				CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(bg_, bl_, true, true);
				bool? bn_ = context.Operators.In<CqlDateTime>(bb_, bm_, default);
				Code<ObservationStatus> bo_ = temperature?.StatusElement;
				ObservationStatus? bp_ = bo_?.Value;
				string bq_ = context.Operators.Convert<string>(bp_);
				string[] br_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bs_ = context.Operators.In<string>(bq_, br_ as IEnumerable<string>);
				bool? bt_ = context.Operators.And(bn_, bs_);
				DataType bu_ = temperature?.Value;
				CqlQuantity bv_ = FHIRHelpers_4_3_000.ToQuantity(bu_ as Quantity);
				bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
				bool? bx_ = context.Operators.And(bt_, bw_);

				return bx_;
			};
			IEnumerable<Observation> p_ = context.Operators.Where<Observation>(f_, o_);
			object q_(Observation @this)
			{
				DataType by_ = @this?.Effective;
				object bz_ = FHIRHelpers_4_3_000.ToValue(by_);
				CqlDateTime ca_ = QICoreCommon_2_0_000.earliest(bz_);

				return ca_;
			};
			IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			Observation s_ = context.Operators.First<Observation>(r_);
			DataType t_ = s_?.Effective;
			object u_ = FHIRHelpers_4_3_000.ToValue(t_);
			CqlDateTime v_ = QICoreCommon_2_0_000.earliest(u_);
			(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? w_ = (e_, m_ as CqlQuantity, v_);

			return w_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Body Temperature")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature() => 
		__Encounter_with_First_Body_Temperature.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? g_(Observation HeartRate)
			{
				DataType x_ = HeartRate?.Effective;
				object y_ = FHIRHelpers_4_3_000.ToValue(x_);
				CqlDateTime z_ = QICoreCommon_2_0_000.earliest(y_);
				Period aa_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_3_000.ToInterval(aa_);
				CqlDateTime ac_ = context.Operators.Start(ab_);
				CqlQuantity ad_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
				CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.ToInterval(aa_);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				CqlQuantity ai_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime aj_ = context.Operators.Add(ah_, ai_);
				CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ae_, aj_, true, true);
				bool? al_ = context.Operators.In<CqlDateTime>(z_, ak_, default);
				Code<ObservationStatus> am_ = HeartRate?.StatusElement;
				ObservationStatus? an_ = am_?.Value;
				string ao_ = context.Operators.Convert<string>(an_);
				string[] ap_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? aq_ = context.Operators.In<string>(ao_, ap_ as IEnumerable<string>);
				bool? ar_ = context.Operators.And(al_, aq_);
				DataType as_ = HeartRate?.Value;
				CqlQuantity at_ = FHIRHelpers_4_3_000.ToQuantity(as_ as Quantity);
				bool? au_ = context.Operators.Not((bool?)(at_ is null));
				bool? av_ = context.Operators.And(ar_, au_);

				return av_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType aw_ = @this?.Effective;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				CqlDateTime ay_ = QICoreCommon_2_0_000.earliest(ax_);

				return ay_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.First<Observation>(j_);
			DataType l_ = k_?.Value;
			CqlQuantity m_ = FHIRHelpers_4_3_000.ToQuantity(l_ as Quantity);
			bool? o_(Observation HeartRate)
			{
				DataType az_ = HeartRate?.Effective;
				object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
				CqlDateTime bb_ = QICoreCommon_2_0_000.earliest(ba_);
				Period bc_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_3_000.ToInterval(bc_);
				CqlDateTime be_ = context.Operators.Start(bd_);
				CqlQuantity bf_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
				CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_3_000.ToInterval(bc_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlQuantity bk_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime bl_ = context.Operators.Add(bj_, bk_);
				CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(bg_, bl_, true, true);
				bool? bn_ = context.Operators.In<CqlDateTime>(bb_, bm_, default);
				Code<ObservationStatus> bo_ = HeartRate?.StatusElement;
				ObservationStatus? bp_ = bo_?.Value;
				string bq_ = context.Operators.Convert<string>(bp_);
				string[] br_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bs_ = context.Operators.In<string>(bq_, br_ as IEnumerable<string>);
				bool? bt_ = context.Operators.And(bn_, bs_);
				DataType bu_ = HeartRate?.Value;
				CqlQuantity bv_ = FHIRHelpers_4_3_000.ToQuantity(bu_ as Quantity);
				bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
				bool? bx_ = context.Operators.And(bt_, bw_);

				return bx_;
			};
			IEnumerable<Observation> p_ = context.Operators.Where<Observation>(f_, o_);
			object q_(Observation @this)
			{
				DataType by_ = @this?.Effective;
				object bz_ = FHIRHelpers_4_3_000.ToValue(by_);
				CqlDateTime ca_ = QICoreCommon_2_0_000.earliest(bz_);

				return ca_;
			};
			IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			Observation s_ = context.Operators.First<Observation>(r_);
			DataType t_ = s_?.Effective;
			object u_ = FHIRHelpers_4_3_000.ToValue(t_);
			CqlDateTime v_ = QICoreCommon_2_0_000.earliest(u_);
			(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? w_ = (e_, m_ as CqlQuantity, v_);

			return w_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Heart Rate")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate() => 
		__Encounter_with_First_Heart_Rate.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation O2Saturation)
			{
				object s_()
				{
					bool ar_()
					{
						DataType au_ = O2Saturation?.Effective;
						object av_ = FHIRHelpers_4_3_000.ToValue(au_);
						bool aw_ = av_ is CqlDateTime;

						return aw_;
					};
					bool as_()
					{
						DataType ax_ = O2Saturation?.Effective;
						object ay_ = FHIRHelpers_4_3_000.ToValue(ax_);
						bool az_ = ay_ is CqlInterval<CqlDateTime>;

						return az_;
					};
					bool at_()
					{
						DataType ba_ = O2Saturation?.Effective;
						object bb_ = FHIRHelpers_4_3_000.ToValue(ba_);
						bool bc_ = bb_ is CqlDateTime;

						return bc_;
					};
					if (ar_())
					{
						DataType bd_ = O2Saturation?.Effective;
						object be_ = FHIRHelpers_4_3_000.ToValue(bd_);

						return (be_ as CqlDateTime) as object;
					}
					else if (as_())
					{
						DataType bf_ = O2Saturation?.Effective;
						object bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
						CqlInterval<CqlDateTime> bh_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(bg_);

						return bh_ as object;
					}
					else if (at_())
					{
						DataType bi_ = O2Saturation?.Effective;
						object bj_ = FHIRHelpers_4_3_000.ToValue(bi_);

						return (bj_ as CqlDateTime) as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime t_ = QICoreCommon_2_0_000.earliest(s_());
				Period u_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(u_);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlQuantity x_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime y_ = context.Operators.Subtract(w_, x_);
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(u_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlQuantity ac_ = context.Operators.Quantity(120m, "minutes");
				CqlDateTime ad_ = context.Operators.Add(ab_, ac_);
				CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(y_, ad_, true, true);
				bool? af_ = context.Operators.In<CqlDateTime>(t_, ae_, default);
				Code<ObservationStatus> ag_ = O2Saturation?.StatusElement;
				ObservationStatus? ah_ = ag_?.Value;
				Code<ObservationStatus> ai_ = context.Operators.Convert<Code<ObservationStatus>>(ah_);
				string aj_ = context.Operators.Convert<string>(ai_);
				string[] ak_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? al_ = context.Operators.In<string>(aj_, ak_ as IEnumerable<string>);
				bool? am_ = context.Operators.And(af_, al_);
				DataType an_ = O2Saturation?.Value;
				object ao_ = FHIRHelpers_4_3_000.ToValue(an_);
				bool? ap_ = context.Operators.Not((bool?)(ao_ is null));
				bool? aq_ = context.Operators.And(am_, ap_);

				return aq_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				object bk_()
				{
					bool bm_()
					{
						DataType bp_ = @this?.Effective;
						object bq_ = FHIRHelpers_4_3_000.ToValue(bp_);
						bool br_ = bq_ is CqlDateTime;

						return br_;
					};
					bool bn_()
					{
						DataType bs_ = @this?.Effective;
						object bt_ = FHIRHelpers_4_3_000.ToValue(bs_);
						bool bu_ = bt_ is CqlInterval<CqlDateTime>;

						return bu_;
					};
					bool bo_()
					{
						DataType bv_ = @this?.Effective;
						object bw_ = FHIRHelpers_4_3_000.ToValue(bv_);
						bool bx_ = bw_ is CqlDateTime;

						return bx_;
					};
					if (bm_())
					{
						DataType by_ = @this?.Effective;
						object bz_ = FHIRHelpers_4_3_000.ToValue(by_);

						return (bz_ as CqlDateTime) as object;
					}
					else if (bn_())
					{
						DataType ca_ = @this?.Effective;
						object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
						CqlInterval<CqlDateTime> cc_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(cb_);

						return cc_ as object;
					}
					else if (bo_())
					{
						DataType cd_ = @this?.Effective;
						object ce_ = FHIRHelpers_4_3_000.ToValue(cd_);

						return (ce_ as CqlDateTime) as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime bl_ = QICoreCommon_2_0_000.earliest(bk_());

				return bl_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlQuantity o_ = context.Operators.Convert<CqlQuantity>(n_);
			object p_()
			{
				bool cf_()
				{
					CqlValueSet ci_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> cj_ = context.Operators.RetrieveByValueSet<Observation>(ci_, default);
					bool? ck_(Observation O2Saturation)
					{
						object cs_()
						{
							bool dr_()
							{
								DataType du_ = O2Saturation?.Effective;
								object dv_ = FHIRHelpers_4_3_000.ToValue(du_);
								bool dw_ = dv_ is CqlDateTime;

								return dw_;
							};
							bool ds_()
							{
								DataType dx_ = O2Saturation?.Effective;
								object dy_ = FHIRHelpers_4_3_000.ToValue(dx_);
								bool dz_ = dy_ is CqlInterval<CqlDateTime>;

								return dz_;
							};
							bool dt_()
							{
								DataType ea_ = O2Saturation?.Effective;
								object eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
								bool ec_ = eb_ is CqlDateTime;

								return ec_;
							};
							if (dr_())
							{
								DataType ed_ = O2Saturation?.Effective;
								object ee_ = FHIRHelpers_4_3_000.ToValue(ed_);

								return (ee_ as CqlDateTime) as object;
							}
							else if (ds_())
							{
								DataType ef_ = O2Saturation?.Effective;
								object eg_ = FHIRHelpers_4_3_000.ToValue(ef_);
								CqlInterval<CqlDateTime> eh_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(eg_);

								return eh_ as object;
							}
							else if (dt_())
							{
								DataType ei_ = O2Saturation?.Effective;
								object ej_ = FHIRHelpers_4_3_000.ToValue(ei_);

								return (ej_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ct_ = QICoreCommon_2_0_000.earliest(cs_());
						Period cu_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_3_000.ToInterval(cu_);
						CqlDateTime cw_ = context.Operators.Start(cv_);
						CqlQuantity cx_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime cy_ = context.Operators.Subtract(cw_, cx_);
						CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_3_000.ToInterval(cu_);
						CqlDateTime db_ = context.Operators.Start(da_);
						CqlQuantity dc_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime dd_ = context.Operators.Add(db_, dc_);
						CqlInterval<CqlDateTime> de_ = context.Operators.Interval(cy_, dd_, true, true);
						bool? df_ = context.Operators.In<CqlDateTime>(ct_, de_, default);
						Code<ObservationStatus> dg_ = O2Saturation?.StatusElement;
						ObservationStatus? dh_ = dg_?.Value;
						Code<ObservationStatus> di_ = context.Operators.Convert<Code<ObservationStatus>>(dh_);
						string dj_ = context.Operators.Convert<string>(di_);
						string[] dk_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? dl_ = context.Operators.In<string>(dj_, dk_ as IEnumerable<string>);
						bool? dm_ = context.Operators.And(df_, dl_);
						DataType dn_ = O2Saturation?.Value;
						object do_ = FHIRHelpers_4_3_000.ToValue(dn_);
						bool? dp_ = context.Operators.Not((bool?)(do_ is null));
						bool? dq_ = context.Operators.And(dm_, dp_);

						return dq_;
					};
					IEnumerable<Observation> cl_ = context.Operators.Where<Observation>(cj_, ck_);
					object cm_(Observation @this)
					{
						object ek_()
						{
							bool em_()
							{
								DataType ep_ = @this?.Effective;
								object eq_ = FHIRHelpers_4_3_000.ToValue(ep_);
								bool er_ = eq_ is CqlDateTime;

								return er_;
							};
							bool en_()
							{
								DataType es_ = @this?.Effective;
								object et_ = FHIRHelpers_4_3_000.ToValue(es_);
								bool eu_ = et_ is CqlInterval<CqlDateTime>;

								return eu_;
							};
							bool eo_()
							{
								DataType ev_ = @this?.Effective;
								object ew_ = FHIRHelpers_4_3_000.ToValue(ev_);
								bool ex_ = ew_ is CqlDateTime;

								return ex_;
							};
							if (em_())
							{
								DataType ey_ = @this?.Effective;
								object ez_ = FHIRHelpers_4_3_000.ToValue(ey_);

								return (ez_ as CqlDateTime) as object;
							}
							else if (en_())
							{
								DataType fa_ = @this?.Effective;
								object fb_ = FHIRHelpers_4_3_000.ToValue(fa_);
								CqlInterval<CqlDateTime> fc_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(fb_);

								return fc_ as object;
							}
							else if (eo_())
							{
								DataType fd_ = @this?.Effective;
								object fe_ = FHIRHelpers_4_3_000.ToValue(fd_);

								return (fe_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime el_ = QICoreCommon_2_0_000.earliest(ek_());

						return el_;
					};
					IEnumerable<Observation> cn_ = context.Operators.SortBy<Observation>(cl_, cm_, System.ComponentModel.ListSortDirection.Ascending);
					Observation co_ = context.Operators.First<Observation>(cn_);
					DataType cp_ = co_?.Effective;
					object cq_ = FHIRHelpers_4_3_000.ToValue(cp_);
					bool cr_ = cq_ is CqlDateTime;

					return cr_;
				};
				bool cg_()
				{
					CqlValueSet ff_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> fg_ = context.Operators.RetrieveByValueSet<Observation>(ff_, default);
					bool? fh_(Observation O2Saturation)
					{
						object fp_()
						{
							bool go_()
							{
								DataType gr_ = O2Saturation?.Effective;
								object gs_ = FHIRHelpers_4_3_000.ToValue(gr_);
								bool gt_ = gs_ is CqlDateTime;

								return gt_;
							};
							bool gp_()
							{
								DataType gu_ = O2Saturation?.Effective;
								object gv_ = FHIRHelpers_4_3_000.ToValue(gu_);
								bool gw_ = gv_ is CqlInterval<CqlDateTime>;

								return gw_;
							};
							bool gq_()
							{
								DataType gx_ = O2Saturation?.Effective;
								object gy_ = FHIRHelpers_4_3_000.ToValue(gx_);
								bool gz_ = gy_ is CqlDateTime;

								return gz_;
							};
							if (go_())
							{
								DataType ha_ = O2Saturation?.Effective;
								object hb_ = FHIRHelpers_4_3_000.ToValue(ha_);

								return (hb_ as CqlDateTime) as object;
							}
							else if (gp_())
							{
								DataType hc_ = O2Saturation?.Effective;
								object hd_ = FHIRHelpers_4_3_000.ToValue(hc_);
								CqlInterval<CqlDateTime> he_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(hd_);

								return he_ as object;
							}
							else if (gq_())
							{
								DataType hf_ = O2Saturation?.Effective;
								object hg_ = FHIRHelpers_4_3_000.ToValue(hf_);

								return (hg_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime fq_ = QICoreCommon_2_0_000.earliest(fp_());
						Period fr_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> fs_ = FHIRHelpers_4_3_000.ToInterval(fr_);
						CqlDateTime ft_ = context.Operators.Start(fs_);
						CqlQuantity fu_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime fv_ = context.Operators.Subtract(ft_, fu_);
						CqlInterval<CqlDateTime> fx_ = FHIRHelpers_4_3_000.ToInterval(fr_);
						CqlDateTime fy_ = context.Operators.Start(fx_);
						CqlQuantity fz_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime ga_ = context.Operators.Add(fy_, fz_);
						CqlInterval<CqlDateTime> gb_ = context.Operators.Interval(fv_, ga_, true, true);
						bool? gc_ = context.Operators.In<CqlDateTime>(fq_, gb_, default);
						Code<ObservationStatus> gd_ = O2Saturation?.StatusElement;
						ObservationStatus? ge_ = gd_?.Value;
						Code<ObservationStatus> gf_ = context.Operators.Convert<Code<ObservationStatus>>(ge_);
						string gg_ = context.Operators.Convert<string>(gf_);
						string[] gh_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? gi_ = context.Operators.In<string>(gg_, gh_ as IEnumerable<string>);
						bool? gj_ = context.Operators.And(gc_, gi_);
						DataType gk_ = O2Saturation?.Value;
						object gl_ = FHIRHelpers_4_3_000.ToValue(gk_);
						bool? gm_ = context.Operators.Not((bool?)(gl_ is null));
						bool? gn_ = context.Operators.And(gj_, gm_);

						return gn_;
					};
					IEnumerable<Observation> fi_ = context.Operators.Where<Observation>(fg_, fh_);
					object fj_(Observation @this)
					{
						object hh_()
						{
							bool hj_()
							{
								DataType hm_ = @this?.Effective;
								object hn_ = FHIRHelpers_4_3_000.ToValue(hm_);
								bool ho_ = hn_ is CqlDateTime;

								return ho_;
							};
							bool hk_()
							{
								DataType hp_ = @this?.Effective;
								object hq_ = FHIRHelpers_4_3_000.ToValue(hp_);
								bool hr_ = hq_ is CqlInterval<CqlDateTime>;

								return hr_;
							};
							bool hl_()
							{
								DataType hs_ = @this?.Effective;
								object ht_ = FHIRHelpers_4_3_000.ToValue(hs_);
								bool hu_ = ht_ is CqlDateTime;

								return hu_;
							};
							if (hj_())
							{
								DataType hv_ = @this?.Effective;
								object hw_ = FHIRHelpers_4_3_000.ToValue(hv_);

								return (hw_ as CqlDateTime) as object;
							}
							else if (hk_())
							{
								DataType hx_ = @this?.Effective;
								object hy_ = FHIRHelpers_4_3_000.ToValue(hx_);
								CqlInterval<CqlDateTime> hz_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(hy_);

								return hz_ as object;
							}
							else if (hl_())
							{
								DataType ia_ = @this?.Effective;
								object ib_ = FHIRHelpers_4_3_000.ToValue(ia_);

								return (ib_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime hi_ = QICoreCommon_2_0_000.earliest(hh_());

						return hi_;
					};
					IEnumerable<Observation> fk_ = context.Operators.SortBy<Observation>(fi_, fj_, System.ComponentModel.ListSortDirection.Ascending);
					Observation fl_ = context.Operators.First<Observation>(fk_);
					DataType fm_ = fl_?.Effective;
					object fn_ = FHIRHelpers_4_3_000.ToValue(fm_);
					bool fo_ = fn_ is CqlInterval<CqlDateTime>;

					return fo_;
				};
				bool ch_()
				{
					CqlValueSet ic_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> id_ = context.Operators.RetrieveByValueSet<Observation>(ic_, default);
					bool? ie_(Observation O2Saturation)
					{
						object im_()
						{
							bool jl_()
							{
								DataType jo_ = O2Saturation?.Effective;
								object jp_ = FHIRHelpers_4_3_000.ToValue(jo_);
								bool jq_ = jp_ is CqlDateTime;

								return jq_;
							};
							bool jm_()
							{
								DataType jr_ = O2Saturation?.Effective;
								object js_ = FHIRHelpers_4_3_000.ToValue(jr_);
								bool jt_ = js_ is CqlInterval<CqlDateTime>;

								return jt_;
							};
							bool jn_()
							{
								DataType ju_ = O2Saturation?.Effective;
								object jv_ = FHIRHelpers_4_3_000.ToValue(ju_);
								bool jw_ = jv_ is CqlDateTime;

								return jw_;
							};
							if (jl_())
							{
								DataType jx_ = O2Saturation?.Effective;
								object jy_ = FHIRHelpers_4_3_000.ToValue(jx_);

								return (jy_ as CqlDateTime) as object;
							}
							else if (jm_())
							{
								DataType jz_ = O2Saturation?.Effective;
								object ka_ = FHIRHelpers_4_3_000.ToValue(jz_);
								CqlInterval<CqlDateTime> kb_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(ka_);

								return kb_ as object;
							}
							else if (jn_())
							{
								DataType kc_ = O2Saturation?.Effective;
								object kd_ = FHIRHelpers_4_3_000.ToValue(kc_);

								return (kd_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime in_ = QICoreCommon_2_0_000.earliest(im_());
						Period io_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> ip_ = FHIRHelpers_4_3_000.ToInterval(io_);
						CqlDateTime iq_ = context.Operators.Start(ip_);
						CqlQuantity ir_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime is_ = context.Operators.Subtract(iq_, ir_);
						CqlInterval<CqlDateTime> iu_ = FHIRHelpers_4_3_000.ToInterval(io_);
						CqlDateTime iv_ = context.Operators.Start(iu_);
						CqlQuantity iw_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime ix_ = context.Operators.Add(iv_, iw_);
						CqlInterval<CqlDateTime> iy_ = context.Operators.Interval(is_, ix_, true, true);
						bool? iz_ = context.Operators.In<CqlDateTime>(in_, iy_, default);
						Code<ObservationStatus> ja_ = O2Saturation?.StatusElement;
						ObservationStatus? jb_ = ja_?.Value;
						Code<ObservationStatus> jc_ = context.Operators.Convert<Code<ObservationStatus>>(jb_);
						string jd_ = context.Operators.Convert<string>(jc_);
						string[] je_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? jf_ = context.Operators.In<string>(jd_, je_ as IEnumerable<string>);
						bool? jg_ = context.Operators.And(iz_, jf_);
						DataType jh_ = O2Saturation?.Value;
						object ji_ = FHIRHelpers_4_3_000.ToValue(jh_);
						bool? jj_ = context.Operators.Not((bool?)(ji_ is null));
						bool? jk_ = context.Operators.And(jg_, jj_);

						return jk_;
					};
					IEnumerable<Observation> if_ = context.Operators.Where<Observation>(id_, ie_);
					object ig_(Observation @this)
					{
						object ke_()
						{
							bool kg_()
							{
								DataType kj_ = @this?.Effective;
								object kk_ = FHIRHelpers_4_3_000.ToValue(kj_);
								bool kl_ = kk_ is CqlDateTime;

								return kl_;
							};
							bool kh_()
							{
								DataType km_ = @this?.Effective;
								object kn_ = FHIRHelpers_4_3_000.ToValue(km_);
								bool ko_ = kn_ is CqlInterval<CqlDateTime>;

								return ko_;
							};
							bool ki_()
							{
								DataType kp_ = @this?.Effective;
								object kq_ = FHIRHelpers_4_3_000.ToValue(kp_);
								bool kr_ = kq_ is CqlDateTime;

								return kr_;
							};
							if (kg_())
							{
								DataType ks_ = @this?.Effective;
								object kt_ = FHIRHelpers_4_3_000.ToValue(ks_);

								return (kt_ as CqlDateTime) as object;
							}
							else if (kh_())
							{
								DataType ku_ = @this?.Effective;
								object kv_ = FHIRHelpers_4_3_000.ToValue(ku_);
								CqlInterval<CqlDateTime> kw_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(kv_);

								return kw_ as object;
							}
							else if (ki_())
							{
								DataType kx_ = @this?.Effective;
								object ky_ = FHIRHelpers_4_3_000.ToValue(kx_);

								return (ky_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime kf_ = QICoreCommon_2_0_000.earliest(ke_());

						return kf_;
					};
					IEnumerable<Observation> ih_ = context.Operators.SortBy<Observation>(if_, ig_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ii_ = context.Operators.First<Observation>(ih_);
					DataType ij_ = ii_?.Effective;
					object ik_ = FHIRHelpers_4_3_000.ToValue(ij_);
					bool il_ = ik_ is CqlDateTime;

					return il_;
				};
				if (cf_())
				{
					CqlValueSet kz_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> la_ = context.Operators.RetrieveByValueSet<Observation>(kz_, default);
					bool? lb_(Observation O2Saturation)
					{
						object li_()
						{
							bool mh_()
							{
								DataType mk_ = O2Saturation?.Effective;
								object ml_ = FHIRHelpers_4_3_000.ToValue(mk_);
								bool mm_ = ml_ is CqlDateTime;

								return mm_;
							};
							bool mi_()
							{
								DataType mn_ = O2Saturation?.Effective;
								object mo_ = FHIRHelpers_4_3_000.ToValue(mn_);
								bool mp_ = mo_ is CqlInterval<CqlDateTime>;

								return mp_;
							};
							bool mj_()
							{
								DataType mq_ = O2Saturation?.Effective;
								object mr_ = FHIRHelpers_4_3_000.ToValue(mq_);
								bool ms_ = mr_ is CqlDateTime;

								return ms_;
							};
							if (mh_())
							{
								DataType mt_ = O2Saturation?.Effective;
								object mu_ = FHIRHelpers_4_3_000.ToValue(mt_);

								return (mu_ as CqlDateTime) as object;
							}
							else if (mi_())
							{
								DataType mv_ = O2Saturation?.Effective;
								object mw_ = FHIRHelpers_4_3_000.ToValue(mv_);
								CqlInterval<CqlDateTime> mx_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(mw_);

								return mx_ as object;
							}
							else if (mj_())
							{
								DataType my_ = O2Saturation?.Effective;
								object mz_ = FHIRHelpers_4_3_000.ToValue(my_);

								return (mz_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime lj_ = QICoreCommon_2_0_000.earliest(li_());
						Period lk_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> ll_ = FHIRHelpers_4_3_000.ToInterval(lk_);
						CqlDateTime lm_ = context.Operators.Start(ll_);
						CqlQuantity ln_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime lo_ = context.Operators.Subtract(lm_, ln_);
						CqlInterval<CqlDateTime> lq_ = FHIRHelpers_4_3_000.ToInterval(lk_);
						CqlDateTime lr_ = context.Operators.Start(lq_);
						CqlQuantity ls_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime lt_ = context.Operators.Add(lr_, ls_);
						CqlInterval<CqlDateTime> lu_ = context.Operators.Interval(lo_, lt_, true, true);
						bool? lv_ = context.Operators.In<CqlDateTime>(lj_, lu_, default);
						Code<ObservationStatus> lw_ = O2Saturation?.StatusElement;
						ObservationStatus? lx_ = lw_?.Value;
						Code<ObservationStatus> ly_ = context.Operators.Convert<Code<ObservationStatus>>(lx_);
						string lz_ = context.Operators.Convert<string>(ly_);
						string[] ma_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? mb_ = context.Operators.In<string>(lz_, ma_ as IEnumerable<string>);
						bool? mc_ = context.Operators.And(lv_, mb_);
						DataType md_ = O2Saturation?.Value;
						object me_ = FHIRHelpers_4_3_000.ToValue(md_);
						bool? mf_ = context.Operators.Not((bool?)(me_ is null));
						bool? mg_ = context.Operators.And(mc_, mf_);

						return mg_;
					};
					IEnumerable<Observation> lc_ = context.Operators.Where<Observation>(la_, lb_);
					object ld_(Observation @this)
					{
						object na_()
						{
							bool nc_()
							{
								DataType nf_ = @this?.Effective;
								object ng_ = FHIRHelpers_4_3_000.ToValue(nf_);
								bool nh_ = ng_ is CqlDateTime;

								return nh_;
							};
							bool nd_()
							{
								DataType ni_ = @this?.Effective;
								object nj_ = FHIRHelpers_4_3_000.ToValue(ni_);
								bool nk_ = nj_ is CqlInterval<CqlDateTime>;

								return nk_;
							};
							bool ne_()
							{
								DataType nl_ = @this?.Effective;
								object nm_ = FHIRHelpers_4_3_000.ToValue(nl_);
								bool nn_ = nm_ is CqlDateTime;

								return nn_;
							};
							if (nc_())
							{
								DataType no_ = @this?.Effective;
								object np_ = FHIRHelpers_4_3_000.ToValue(no_);

								return (np_ as CqlDateTime) as object;
							}
							else if (nd_())
							{
								DataType nq_ = @this?.Effective;
								object nr_ = FHIRHelpers_4_3_000.ToValue(nq_);
								CqlInterval<CqlDateTime> ns_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(nr_);

								return ns_ as object;
							}
							else if (ne_())
							{
								DataType nt_ = @this?.Effective;
								object nu_ = FHIRHelpers_4_3_000.ToValue(nt_);

								return (nu_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime nb_ = QICoreCommon_2_0_000.earliest(na_());

						return nb_;
					};
					IEnumerable<Observation> le_ = context.Operators.SortBy<Observation>(lc_, ld_, System.ComponentModel.ListSortDirection.Ascending);
					Observation lf_ = context.Operators.First<Observation>(le_);
					DataType lg_ = lf_?.Effective;
					object lh_ = FHIRHelpers_4_3_000.ToValue(lg_);

					return (lh_ as CqlDateTime) as object;
				}
				else if (cg_())
				{
					CqlValueSet nv_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> nw_ = context.Operators.RetrieveByValueSet<Observation>(nv_, default);
					bool? nx_(Observation O2Saturation)
					{
						object of_()
						{
							bool pe_()
							{
								DataType ph_ = O2Saturation?.Effective;
								object pi_ = FHIRHelpers_4_3_000.ToValue(ph_);
								bool pj_ = pi_ is CqlDateTime;

								return pj_;
							};
							bool pf_()
							{
								DataType pk_ = O2Saturation?.Effective;
								object pl_ = FHIRHelpers_4_3_000.ToValue(pk_);
								bool pm_ = pl_ is CqlInterval<CqlDateTime>;

								return pm_;
							};
							bool pg_()
							{
								DataType pn_ = O2Saturation?.Effective;
								object po_ = FHIRHelpers_4_3_000.ToValue(pn_);
								bool pp_ = po_ is CqlDateTime;

								return pp_;
							};
							if (pe_())
							{
								DataType pq_ = O2Saturation?.Effective;
								object pr_ = FHIRHelpers_4_3_000.ToValue(pq_);

								return (pr_ as CqlDateTime) as object;
							}
							else if (pf_())
							{
								DataType ps_ = O2Saturation?.Effective;
								object pt_ = FHIRHelpers_4_3_000.ToValue(ps_);
								CqlInterval<CqlDateTime> pu_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(pt_);

								return pu_ as object;
							}
							else if (pg_())
							{
								DataType pv_ = O2Saturation?.Effective;
								object pw_ = FHIRHelpers_4_3_000.ToValue(pv_);

								return (pw_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime og_ = QICoreCommon_2_0_000.earliest(of_());
						Period oh_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> oi_ = FHIRHelpers_4_3_000.ToInterval(oh_);
						CqlDateTime oj_ = context.Operators.Start(oi_);
						CqlQuantity ok_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime ol_ = context.Operators.Subtract(oj_, ok_);
						CqlInterval<CqlDateTime> on_ = FHIRHelpers_4_3_000.ToInterval(oh_);
						CqlDateTime oo_ = context.Operators.Start(on_);
						CqlQuantity op_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime oq_ = context.Operators.Add(oo_, op_);
						CqlInterval<CqlDateTime> or_ = context.Operators.Interval(ol_, oq_, true, true);
						bool? os_ = context.Operators.In<CqlDateTime>(og_, or_, default);
						Code<ObservationStatus> ot_ = O2Saturation?.StatusElement;
						ObservationStatus? ou_ = ot_?.Value;
						Code<ObservationStatus> ov_ = context.Operators.Convert<Code<ObservationStatus>>(ou_);
						string ow_ = context.Operators.Convert<string>(ov_);
						string[] ox_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? oy_ = context.Operators.In<string>(ow_, ox_ as IEnumerable<string>);
						bool? oz_ = context.Operators.And(os_, oy_);
						DataType pa_ = O2Saturation?.Value;
						object pb_ = FHIRHelpers_4_3_000.ToValue(pa_);
						bool? pc_ = context.Operators.Not((bool?)(pb_ is null));
						bool? pd_ = context.Operators.And(oz_, pc_);

						return pd_;
					};
					IEnumerable<Observation> ny_ = context.Operators.Where<Observation>(nw_, nx_);
					object nz_(Observation @this)
					{
						object px_()
						{
							bool pz_()
							{
								DataType qc_ = @this?.Effective;
								object qd_ = FHIRHelpers_4_3_000.ToValue(qc_);
								bool qe_ = qd_ is CqlDateTime;

								return qe_;
							};
							bool qa_()
							{
								DataType qf_ = @this?.Effective;
								object qg_ = FHIRHelpers_4_3_000.ToValue(qf_);
								bool qh_ = qg_ is CqlInterval<CqlDateTime>;

								return qh_;
							};
							bool qb_()
							{
								DataType qi_ = @this?.Effective;
								object qj_ = FHIRHelpers_4_3_000.ToValue(qi_);
								bool qk_ = qj_ is CqlDateTime;

								return qk_;
							};
							if (pz_())
							{
								DataType ql_ = @this?.Effective;
								object qm_ = FHIRHelpers_4_3_000.ToValue(ql_);

								return (qm_ as CqlDateTime) as object;
							}
							else if (qa_())
							{
								DataType qn_ = @this?.Effective;
								object qo_ = FHIRHelpers_4_3_000.ToValue(qn_);
								CqlInterval<CqlDateTime> qp_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(qo_);

								return qp_ as object;
							}
							else if (qb_())
							{
								DataType qq_ = @this?.Effective;
								object qr_ = FHIRHelpers_4_3_000.ToValue(qq_);

								return (qr_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime py_ = QICoreCommon_2_0_000.earliest(px_());

						return py_;
					};
					IEnumerable<Observation> oa_ = context.Operators.SortBy<Observation>(ny_, nz_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ob_ = context.Operators.First<Observation>(oa_);
					DataType oc_ = ob_?.Effective;
					object od_ = FHIRHelpers_4_3_000.ToValue(oc_);
					CqlInterval<CqlDateTime> oe_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(od_);

					return oe_ as object;
				}
				else if (ch_())
				{
					CqlValueSet qs_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> qt_ = context.Operators.RetrieveByValueSet<Observation>(qs_, default);
					bool? qu_(Observation O2Saturation)
					{
						object rb_()
						{
							bool sa_()
							{
								DataType sd_ = O2Saturation?.Effective;
								object se_ = FHIRHelpers_4_3_000.ToValue(sd_);
								bool sf_ = se_ is CqlDateTime;

								return sf_;
							};
							bool sb_()
							{
								DataType sg_ = O2Saturation?.Effective;
								object sh_ = FHIRHelpers_4_3_000.ToValue(sg_);
								bool si_ = sh_ is CqlInterval<CqlDateTime>;

								return si_;
							};
							bool sc_()
							{
								DataType sj_ = O2Saturation?.Effective;
								object sk_ = FHIRHelpers_4_3_000.ToValue(sj_);
								bool sl_ = sk_ is CqlDateTime;

								return sl_;
							};
							if (sa_())
							{
								DataType sm_ = O2Saturation?.Effective;
								object sn_ = FHIRHelpers_4_3_000.ToValue(sm_);

								return (sn_ as CqlDateTime) as object;
							}
							else if (sb_())
							{
								DataType so_ = O2Saturation?.Effective;
								object sp_ = FHIRHelpers_4_3_000.ToValue(so_);
								CqlInterval<CqlDateTime> sq_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(sp_);

								return sq_ as object;
							}
							else if (sc_())
							{
								DataType sr_ = O2Saturation?.Effective;
								object ss_ = FHIRHelpers_4_3_000.ToValue(sr_);

								return (ss_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime rc_ = QICoreCommon_2_0_000.earliest(rb_());
						Period rd_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> re_ = FHIRHelpers_4_3_000.ToInterval(rd_);
						CqlDateTime rf_ = context.Operators.Start(re_);
						CqlQuantity rg_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime rh_ = context.Operators.Subtract(rf_, rg_);
						CqlInterval<CqlDateTime> rj_ = FHIRHelpers_4_3_000.ToInterval(rd_);
						CqlDateTime rk_ = context.Operators.Start(rj_);
						CqlQuantity rl_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime rm_ = context.Operators.Add(rk_, rl_);
						CqlInterval<CqlDateTime> rn_ = context.Operators.Interval(rh_, rm_, true, true);
						bool? ro_ = context.Operators.In<CqlDateTime>(rc_, rn_, default);
						Code<ObservationStatus> rp_ = O2Saturation?.StatusElement;
						ObservationStatus? rq_ = rp_?.Value;
						Code<ObservationStatus> rr_ = context.Operators.Convert<Code<ObservationStatus>>(rq_);
						string rs_ = context.Operators.Convert<string>(rr_);
						string[] rt_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? ru_ = context.Operators.In<string>(rs_, rt_ as IEnumerable<string>);
						bool? rv_ = context.Operators.And(ro_, ru_);
						DataType rw_ = O2Saturation?.Value;
						object rx_ = FHIRHelpers_4_3_000.ToValue(rw_);
						bool? ry_ = context.Operators.Not((bool?)(rx_ is null));
						bool? rz_ = context.Operators.And(rv_, ry_);

						return rz_;
					};
					IEnumerable<Observation> qv_ = context.Operators.Where<Observation>(qt_, qu_);
					object qw_(Observation @this)
					{
						object st_()
						{
							bool sv_()
							{
								DataType sy_ = @this?.Effective;
								object sz_ = FHIRHelpers_4_3_000.ToValue(sy_);
								bool ta_ = sz_ is CqlDateTime;

								return ta_;
							};
							bool sw_()
							{
								DataType tb_ = @this?.Effective;
								object tc_ = FHIRHelpers_4_3_000.ToValue(tb_);
								bool td_ = tc_ is CqlInterval<CqlDateTime>;

								return td_;
							};
							bool sx_()
							{
								DataType te_ = @this?.Effective;
								object tf_ = FHIRHelpers_4_3_000.ToValue(te_);
								bool tg_ = tf_ is CqlDateTime;

								return tg_;
							};
							if (sv_())
							{
								DataType th_ = @this?.Effective;
								object ti_ = FHIRHelpers_4_3_000.ToValue(th_);

								return (ti_ as CqlDateTime) as object;
							}
							else if (sw_())
							{
								DataType tj_ = @this?.Effective;
								object tk_ = FHIRHelpers_4_3_000.ToValue(tj_);
								CqlInterval<CqlDateTime> tl_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(tk_);

								return tl_ as object;
							}
							else if (sx_())
							{
								DataType tm_ = @this?.Effective;
								object tn_ = FHIRHelpers_4_3_000.ToValue(tm_);

								return (tn_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime su_ = QICoreCommon_2_0_000.earliest(st_());

						return su_;
					};
					IEnumerable<Observation> qx_ = context.Operators.SortBy<Observation>(qv_, qw_, System.ComponentModel.ListSortDirection.Ascending);
					Observation qy_ = context.Operators.First<Observation>(qx_);
					DataType qz_ = qy_?.Effective;
					object ra_ = FHIRHelpers_4_3_000.ToValue(qz_);

					return (ra_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime q_ = QICoreCommon_2_0_000.earliest(p_());
			(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? r_ = (e_, o_, q_);

			return r_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Oxygen Saturation")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation() => 
		__Encounter_with_First_Oxygen_Saturation.Value;

	private IEnumerable<Observation> Blood_Pressure_Reading_Value()
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
		bool? b_(Observation BloodPressure)
		{
			Code<ObservationStatus> d_ = BloodPressure?.StatusElement;
			ObservationStatus? e_ = d_?.Value;
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);

			return h_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Blood Pressure Reading")]
	public IEnumerable<Observation> Blood_Pressure_Reading() => 
		__Blood_Pressure_Reading.Value;

	private IEnumerable<Encounter> Encounter_with_First_Systolic_Blood_Pressure_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();

		return a_;
	}

    [CqlDeclaration("Encounter with First Systolic Blood Pressure")]
	public IEnumerable<Encounter> Encounter_with_First_Systolic_Blood_Pressure() => 
		__Encounter_with_First_Systolic_Blood_Pressure.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Bicarbonate_lab_test();
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation BicarbonateLab)
			{
				Instant aa_ = BicarbonateLab?.IssuedElement;
				DateTimeOffset? ab_ = aa_?.Value;
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
				CqlDateTime ad_ = QICoreCommon_2_0_000.earliest(ac_ as object);
				Period ae_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime ag_ = context.Operators.Start(af_);
				CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlDateTime an_ = context.Operators.Add(al_, ah_);
				CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
				bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
				Code<ObservationStatus> aq_ = BicarbonateLab?.StatusElement;
				ObservationStatus? ar_ = aq_?.Value;
				string as_ = context.Operators.Convert<string>(ar_);
				string[] at_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
				bool? av_ = context.Operators.And(ap_, au_);
				DataType aw_ = BicarbonateLab?.Value;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
				bool? az_ = context.Operators.And(av_, ay_);

				return az_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant ba_ = @this?.IssuedElement;
				DateTimeOffset? bb_ = ba_?.Value;
				CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
				CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_ as object);

				return bd_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlQuantity o_ = context.Operators.Convert<CqlQuantity>(n_);
			IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? r_(Observation BicarbonateLab)
			{
				Instant be_ = BicarbonateLab?.IssuedElement;
				DateTimeOffset? bf_ = be_?.Value;
				CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				CqlDateTime bh_ = QICoreCommon_2_0_000.earliest(bg_ as object);
				Period bi_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
				CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bp_ = context.Operators.Start(bo_);
				CqlDateTime br_ = context.Operators.Add(bp_, bl_);
				CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
				bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
				Code<ObservationStatus> bu_ = BicarbonateLab?.StatusElement;
				ObservationStatus? bv_ = bu_?.Value;
				string bw_ = context.Operators.Convert<string>(bv_);
				string[] bx_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
				bool? bz_ = context.Operators.And(bt_, by_);
				DataType ca_ = BicarbonateLab?.Value;
				object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
				bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
				bool? cd_ = context.Operators.And(bz_, cc_);

				return cd_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
			object t_(Observation @this)
			{
				Instant ce_ = @this?.IssuedElement;
				DateTimeOffset? cf_ = ce_?.Value;
				CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
				CqlDateTime ch_ = QICoreCommon_2_0_000.earliest(cg_ as object);

				return ch_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			Instant w_ = v_?.IssuedElement;
			DateTimeOffset? x_ = w_?.Value;
			CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
			(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? z_ = (e_, o_, y_);

			return z_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Bicarbonate Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test() => 
		__Encounter_with_First_Bicarbonate_Lab_Test.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Creatinine_lab_test();
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation CreatinineLab)
			{
				Instant aa_ = CreatinineLab?.IssuedElement;
				DateTimeOffset? ab_ = aa_?.Value;
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
				CqlDateTime ad_ = QICoreCommon_2_0_000.earliest(ac_ as object);
				Period ae_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime ag_ = context.Operators.Start(af_);
				CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlDateTime an_ = context.Operators.Add(al_, ah_);
				CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
				bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
				Code<ObservationStatus> aq_ = CreatinineLab?.StatusElement;
				ObservationStatus? ar_ = aq_?.Value;
				string as_ = context.Operators.Convert<string>(ar_);
				string[] at_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
				bool? av_ = context.Operators.And(ap_, au_);
				DataType aw_ = CreatinineLab?.Value;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
				bool? az_ = context.Operators.And(av_, ay_);

				return az_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant ba_ = @this?.IssuedElement;
				DateTimeOffset? bb_ = ba_?.Value;
				CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
				CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_ as object);

				return bd_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlQuantity o_ = context.Operators.Convert<CqlQuantity>(n_);
			IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? r_(Observation CreatinineLab)
			{
				Instant be_ = CreatinineLab?.IssuedElement;
				DateTimeOffset? bf_ = be_?.Value;
				CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				CqlDateTime bh_ = QICoreCommon_2_0_000.earliest(bg_ as object);
				Period bi_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
				CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bp_ = context.Operators.Start(bo_);
				CqlDateTime br_ = context.Operators.Add(bp_, bl_);
				CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
				bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
				Code<ObservationStatus> bu_ = CreatinineLab?.StatusElement;
				ObservationStatus? bv_ = bu_?.Value;
				string bw_ = context.Operators.Convert<string>(bv_);
				string[] bx_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
				bool? bz_ = context.Operators.And(bt_, by_);
				DataType ca_ = CreatinineLab?.Value;
				object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
				bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
				bool? cd_ = context.Operators.And(bz_, cc_);

				return cd_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
			object t_(Observation @this)
			{
				Instant ce_ = @this?.IssuedElement;
				DateTimeOffset? cf_ = ce_?.Value;
				CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
				CqlDateTime ch_ = QICoreCommon_2_0_000.earliest(cg_ as object);

				return ch_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			Instant w_ = v_?.IssuedElement;
			DateTimeOffset? x_ = w_?.Value;
			CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
			(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? z_ = (e_, o_, y_);

			return z_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Creatinine Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test() => 
		__Encounter_with_First_Creatinine_Lab_Test.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Hematocrit_lab_test();
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation HematocritLab)
			{
				Instant aa_ = HematocritLab?.IssuedElement;
				DateTimeOffset? ab_ = aa_?.Value;
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
				CqlDateTime ad_ = QICoreCommon_2_0_000.earliest(ac_ as object);
				Period ae_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime ag_ = context.Operators.Start(af_);
				CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlDateTime an_ = context.Operators.Add(al_, ah_);
				CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
				bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
				Code<ObservationStatus> aq_ = HematocritLab?.StatusElement;
				ObservationStatus? ar_ = aq_?.Value;
				string as_ = context.Operators.Convert<string>(ar_);
				string[] at_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
				bool? av_ = context.Operators.And(ap_, au_);
				DataType aw_ = HematocritLab?.Value;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
				bool? az_ = context.Operators.And(av_, ay_);

				return az_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant ba_ = @this?.IssuedElement;
				DateTimeOffset? bb_ = ba_?.Value;
				CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
				CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_ as object);

				return bd_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlQuantity o_ = context.Operators.Convert<CqlQuantity>(n_);
			IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? r_(Observation HematocritLab)
			{
				Instant be_ = HematocritLab?.IssuedElement;
				DateTimeOffset? bf_ = be_?.Value;
				CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				CqlDateTime bh_ = QICoreCommon_2_0_000.earliest(bg_ as object);
				Period bi_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
				CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bp_ = context.Operators.Start(bo_);
				CqlDateTime br_ = context.Operators.Add(bp_, bl_);
				CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
				bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
				Code<ObservationStatus> bu_ = HematocritLab?.StatusElement;
				ObservationStatus? bv_ = bu_?.Value;
				string bw_ = context.Operators.Convert<string>(bv_);
				string[] bx_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
				bool? bz_ = context.Operators.And(bt_, by_);
				DataType ca_ = HematocritLab?.Value;
				object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
				bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
				bool? cd_ = context.Operators.And(bz_, cc_);

				return cd_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
			object t_(Observation @this)
			{
				Instant ce_ = @this?.IssuedElement;
				DateTimeOffset? cf_ = ce_?.Value;
				CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
				CqlDateTime ch_ = QICoreCommon_2_0_000.earliest(cg_ as object);

				return ch_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			Instant w_ = v_?.IssuedElement;
			DateTimeOffset? x_ = w_?.Value;
			CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
			(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? z_ = (e_, o_, y_);

			return z_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Hematocrit Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test() => 
		__Encounter_with_First_Hematocrit_Lab_Test.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Platelet_count_lab_test();
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation PlateletLab)
			{
				Instant aa_ = PlateletLab?.IssuedElement;
				DateTimeOffset? ab_ = aa_?.Value;
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
				CqlDateTime ad_ = QICoreCommon_2_0_000.earliest(ac_ as object);
				Period ae_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime ag_ = context.Operators.Start(af_);
				CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlDateTime an_ = context.Operators.Add(al_, ah_);
				CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
				bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
				Code<ObservationStatus> aq_ = PlateletLab?.StatusElement;
				ObservationStatus? ar_ = aq_?.Value;
				string as_ = context.Operators.Convert<string>(ar_);
				string[] at_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
				bool? av_ = context.Operators.And(ap_, au_);
				DataType aw_ = PlateletLab?.Value;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
				bool? az_ = context.Operators.And(av_, ay_);

				return az_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant ba_ = @this?.IssuedElement;
				DateTimeOffset? bb_ = ba_?.Value;
				CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
				CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_ as object);

				return bd_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlQuantity o_ = context.Operators.Convert<CqlQuantity>(n_);
			IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? r_(Observation PlateletLab)
			{
				Instant be_ = PlateletLab?.IssuedElement;
				DateTimeOffset? bf_ = be_?.Value;
				CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				CqlDateTime bh_ = QICoreCommon_2_0_000.earliest(bg_ as object);
				Period bi_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
				CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bp_ = context.Operators.Start(bo_);
				CqlDateTime br_ = context.Operators.Add(bp_, bl_);
				CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
				bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
				Code<ObservationStatus> bu_ = PlateletLab?.StatusElement;
				ObservationStatus? bv_ = bu_?.Value;
				string bw_ = context.Operators.Convert<string>(bv_);
				string[] bx_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
				bool? bz_ = context.Operators.And(bt_, by_);
				DataType ca_ = PlateletLab?.Value;
				object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
				bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
				bool? cd_ = context.Operators.And(bz_, cc_);

				return cd_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
			object t_(Observation @this)
			{
				Instant ce_ = @this?.IssuedElement;
				DateTimeOffset? cf_ = ce_?.Value;
				CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
				CqlDateTime ch_ = QICoreCommon_2_0_000.earliest(cg_ as object);

				return ch_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			Instant w_ = v_?.IssuedElement;
			DateTimeOffset? x_ = w_?.Value;
			CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
			(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? z_ = (e_, o_, y_);

			return z_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Platelet Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test() => 
		__Encounter_with_First_Platelet_Lab_Test.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Sodium_lab_test();
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation SodiumLab)
			{
				Instant aa_ = SodiumLab?.IssuedElement;
				DateTimeOffset? ab_ = aa_?.Value;
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
				CqlDateTime ad_ = QICoreCommon_2_0_000.earliest(ac_ as object);
				Period ae_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime ag_ = context.Operators.Start(af_);
				CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlDateTime an_ = context.Operators.Add(al_, ah_);
				CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
				bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
				Code<ObservationStatus> aq_ = SodiumLab?.StatusElement;
				ObservationStatus? ar_ = aq_?.Value;
				string as_ = context.Operators.Convert<string>(ar_);
				string[] at_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
				bool? av_ = context.Operators.And(ap_, au_);
				DataType aw_ = SodiumLab?.Value;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
				bool? az_ = context.Operators.And(av_, ay_);

				return az_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant ba_ = @this?.IssuedElement;
				DateTimeOffset? bb_ = ba_?.Value;
				CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
				CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_ as object);

				return bd_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlQuantity o_ = context.Operators.Convert<CqlQuantity>(n_);
			IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? r_(Observation SodiumLab)
			{
				Instant be_ = SodiumLab?.IssuedElement;
				DateTimeOffset? bf_ = be_?.Value;
				CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				CqlDateTime bh_ = QICoreCommon_2_0_000.earliest(bg_ as object);
				Period bi_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
				CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bp_ = context.Operators.Start(bo_);
				CqlDateTime br_ = context.Operators.Add(bp_, bl_);
				CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
				bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
				Code<ObservationStatus> bu_ = SodiumLab?.StatusElement;
				ObservationStatus? bv_ = bu_?.Value;
				string bw_ = context.Operators.Convert<string>(bv_);
				string[] bx_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
				bool? bz_ = context.Operators.And(bt_, by_);
				DataType ca_ = SodiumLab?.Value;
				object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
				bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
				bool? cd_ = context.Operators.And(bz_, cc_);

				return cd_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
			object t_(Observation @this)
			{
				Instant ce_ = @this?.IssuedElement;
				DateTimeOffset? cf_ = ce_?.Value;
				CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
				CqlDateTime ch_ = QICoreCommon_2_0_000.earliest(cg_ as object);

				return ch_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			Instant w_ = v_?.IssuedElement;
			DateTimeOffset? x_ = w_?.Value;
			CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
			(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? z_ = (e_, o_, y_);

			return z_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Sodium Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test() => 
		__Encounter_with_First_Sodium_Lab_Test.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounters();
		(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
		{
			Id d_ = EncounterInpatient?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.White_blood_cells_count_lab_test();
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation WhiteBloodCellLab)
			{
				Instant aa_ = WhiteBloodCellLab?.IssuedElement;
				DateTimeOffset? ab_ = aa_?.Value;
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
				CqlDateTime ad_ = QICoreCommon_2_0_000.earliest(ac_ as object);
				Period ae_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime ag_ = context.Operators.Start(af_);
				CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(ae_);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlDateTime an_ = context.Operators.Add(al_, ah_);
				CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
				bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
				Code<ObservationStatus> aq_ = WhiteBloodCellLab?.StatusElement;
				ObservationStatus? ar_ = aq_?.Value;
				string as_ = context.Operators.Convert<string>(ar_);
				string[] at_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
				bool? av_ = context.Operators.And(ap_, au_);
				DataType aw_ = WhiteBloodCellLab?.Value;
				object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
				bool? az_ = context.Operators.And(av_, ay_);

				return az_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant ba_ = @this?.IssuedElement;
				DateTimeOffset? bb_ = ba_?.Value;
				CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
				CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_ as object);

				return bd_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlQuantity o_ = context.Operators.Convert<CqlQuantity>(n_);
			IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? r_(Observation WhiteBloodCellLab)
			{
				Instant be_ = WhiteBloodCellLab?.IssuedElement;
				DateTimeOffset? bf_ = be_?.Value;
				CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				CqlDateTime bh_ = QICoreCommon_2_0_000.earliest(bg_ as object);
				Period bi_ = EncounterInpatient?.Period;
				CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);
				CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
				CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_3_000.ToInterval(bi_);
				CqlDateTime bp_ = context.Operators.Start(bo_);
				CqlDateTime br_ = context.Operators.Add(bp_, bl_);
				CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
				bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
				Code<ObservationStatus> bu_ = WhiteBloodCellLab?.StatusElement;
				ObservationStatus? bv_ = bu_?.Value;
				string bw_ = context.Operators.Convert<string>(bv_);
				string[] bx_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
				bool? bz_ = context.Operators.And(bt_, by_);
				DataType ca_ = WhiteBloodCellLab?.Value;
				object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
				bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
				bool? cd_ = context.Operators.And(bz_, cc_);

				return cd_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
			object t_(Observation @this)
			{
				Instant ce_ = @this?.IssuedElement;
				DateTimeOffset? cf_ = ce_?.Value;
				CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
				CqlDateTime ch_ = QICoreCommon_2_0_000.earliest(cg_ as object);

				return ch_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			Instant w_ = v_?.IssuedElement;
			DateTimeOffset? x_ = w_?.Value;
			CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
			(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? z_ = (e_, o_, y_);

			return z_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First White Blood Cells Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test() => 
		__Encounter_with_First_White_Blood_Cells_Lab_Test.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
