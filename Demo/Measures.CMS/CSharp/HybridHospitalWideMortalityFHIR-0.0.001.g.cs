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
						CqlDateTime bf_ = be_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

						return bf_ as object;
					}
					else if (as_())
					{
						DataType bg_ = O2Saturation?.Effective;
						object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
						CqlInterval<CqlDateTime> bi_ = bh_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

						return bi_ as object;
					}
					else if (at_())
					{
						DataType bj_ = O2Saturation?.Effective;
						object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
						CqlDateTime bl_ = bk_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

						return bl_ as object;
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
				object bm_()
				{
					bool bo_()
					{
						DataType br_ = @this?.Effective;
						object bs_ = FHIRHelpers_4_3_000.ToValue(br_);
						bool bt_ = bs_ is CqlDateTime;

						return bt_;
					};
					bool bp_()
					{
						DataType bu_ = @this?.Effective;
						object bv_ = FHIRHelpers_4_3_000.ToValue(bu_);
						bool bw_ = bv_ is CqlInterval<CqlDateTime>;

						return bw_;
					};
					bool bq_()
					{
						DataType bx_ = @this?.Effective;
						object by_ = FHIRHelpers_4_3_000.ToValue(bx_);
						bool bz_ = by_ is CqlDateTime;

						return bz_;
					};
					if (bo_())
					{
						DataType ca_ = @this?.Effective;
						object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
						CqlDateTime cc_ = cb_ switch { null => null , CqlDateTime d => d/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

						return cc_ as object;
					}
					else if (bp_())
					{
						DataType cd_ = @this?.Effective;
						object ce_ = FHIRHelpers_4_3_000.ToValue(cd_);
						CqlInterval<CqlDateTime> cf_ = ce_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

						return cf_ as object;
					}
					else if (bq_())
					{
						DataType cg_ = @this?.Effective;
						object ch_ = FHIRHelpers_4_3_000.ToValue(cg_);
						CqlDateTime ci_ = ch_ switch { null => null , CqlDateTime f => f/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

						return ci_ as object;
					}
					else
					{
						return null;
					}
				};
				CqlDateTime bn_ = QICoreCommon_2_0_000.earliest(bm_());

				return bn_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlQuantity o_ = n_ switch { null => null , CqlQuantity g => g/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			object p_()
			{
				bool cj_()
				{
					CqlValueSet cm_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> cn_ = context.Operators.RetrieveByValueSet<Observation>(cm_, default);
					bool? co_(Observation O2Saturation)
					{
						object cw_()
						{
							bool dv_()
							{
								DataType dy_ = O2Saturation?.Effective;
								object dz_ = FHIRHelpers_4_3_000.ToValue(dy_);
								bool ea_ = dz_ is CqlDateTime;

								return ea_;
							};
							bool dw_()
							{
								DataType eb_ = O2Saturation?.Effective;
								object ec_ = FHIRHelpers_4_3_000.ToValue(eb_);
								bool ed_ = ec_ is CqlInterval<CqlDateTime>;

								return ed_;
							};
							bool dx_()
							{
								DataType ee_ = O2Saturation?.Effective;
								object ef_ = FHIRHelpers_4_3_000.ToValue(ee_);
								bool eg_ = ef_ is CqlDateTime;

								return eg_;
							};
							if (dv_())
							{
								DataType eh_ = O2Saturation?.Effective;
								object ei_ = FHIRHelpers_4_3_000.ToValue(eh_);
								CqlDateTime ej_ = ei_ switch { null => null , CqlDateTime h => h/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ej_ as object;
							}
							else if (dw_())
							{
								DataType ek_ = O2Saturation?.Effective;
								object el_ = FHIRHelpers_4_3_000.ToValue(ek_);
								CqlInterval<CqlDateTime> em_ = el_ switch { null => null , CqlInterval<CqlDateTime> i => i/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return em_ as object;
							}
							else if (dx_())
							{
								DataType en_ = O2Saturation?.Effective;
								object eo_ = FHIRHelpers_4_3_000.ToValue(en_);
								CqlDateTime ep_ = eo_ switch { null => null , CqlDateTime j => j/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ep_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime cx_ = QICoreCommon_2_0_000.earliest(cw_());
						Period cy_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_3_000.ToInterval(cy_);
						CqlDateTime da_ = context.Operators.Start(cz_);
						CqlQuantity db_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime dc_ = context.Operators.Subtract(da_, db_);
						CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_3_000.ToInterval(cy_);
						CqlDateTime df_ = context.Operators.Start(de_);
						CqlQuantity dg_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime dh_ = context.Operators.Add(df_, dg_);
						CqlInterval<CqlDateTime> di_ = context.Operators.Interval(dc_, dh_, true, true);
						bool? dj_ = context.Operators.In<CqlDateTime>(cx_, di_, default);
						Code<ObservationStatus> dk_ = O2Saturation?.StatusElement;
						ObservationStatus? dl_ = dk_?.Value;
						Code<ObservationStatus> dm_ = context.Operators.Convert<Code<ObservationStatus>>(dl_);
						string dn_ = context.Operators.Convert<string>(dm_);
						string[] do_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? dp_ = context.Operators.In<string>(dn_, do_ as IEnumerable<string>);
						bool? dq_ = context.Operators.And(dj_, dp_);
						DataType dr_ = O2Saturation?.Value;
						object ds_ = FHIRHelpers_4_3_000.ToValue(dr_);
						bool? dt_ = context.Operators.Not((bool?)(ds_ is null));
						bool? du_ = context.Operators.And(dq_, dt_);

						return du_;
					};
					IEnumerable<Observation> cp_ = context.Operators.Where<Observation>(cn_, co_);
					object cq_(Observation @this)
					{
						object eq_()
						{
							bool es_()
							{
								DataType ev_ = @this?.Effective;
								object ew_ = FHIRHelpers_4_3_000.ToValue(ev_);
								bool ex_ = ew_ is CqlDateTime;

								return ex_;
							};
							bool et_()
							{
								DataType ey_ = @this?.Effective;
								object ez_ = FHIRHelpers_4_3_000.ToValue(ey_);
								bool fa_ = ez_ is CqlInterval<CqlDateTime>;

								return fa_;
							};
							bool eu_()
							{
								DataType fb_ = @this?.Effective;
								object fc_ = FHIRHelpers_4_3_000.ToValue(fb_);
								bool fd_ = fc_ is CqlDateTime;

								return fd_;
							};
							if (es_())
							{
								DataType fe_ = @this?.Effective;
								object ff_ = FHIRHelpers_4_3_000.ToValue(fe_);
								CqlDateTime fg_ = ff_ switch { null => null , CqlDateTime k => k/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return fg_ as object;
							}
							else if (et_())
							{
								DataType fh_ = @this?.Effective;
								object fi_ = FHIRHelpers_4_3_000.ToValue(fh_);
								CqlInterval<CqlDateTime> fj_ = fi_ switch { null => null , CqlInterval<CqlDateTime> l => l/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return fj_ as object;
							}
							else if (eu_())
							{
								DataType fk_ = @this?.Effective;
								object fl_ = FHIRHelpers_4_3_000.ToValue(fk_);
								CqlDateTime fm_ = fl_ switch { null => null , CqlDateTime m => m/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return fm_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime er_ = QICoreCommon_2_0_000.earliest(eq_());

						return er_;
					};
					IEnumerable<Observation> cr_ = context.Operators.SortBy<Observation>(cp_, cq_, System.ComponentModel.ListSortDirection.Ascending);
					Observation cs_ = context.Operators.First<Observation>(cr_);
					DataType ct_ = cs_?.Effective;
					object cu_ = FHIRHelpers_4_3_000.ToValue(ct_);
					bool cv_ = cu_ is CqlDateTime;

					return cv_;
				};
				bool ck_()
				{
					CqlValueSet fn_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> fo_ = context.Operators.RetrieveByValueSet<Observation>(fn_, default);
					bool? fp_(Observation O2Saturation)
					{
						object fx_()
						{
							bool gw_()
							{
								DataType gz_ = O2Saturation?.Effective;
								object ha_ = FHIRHelpers_4_3_000.ToValue(gz_);
								bool hb_ = ha_ is CqlDateTime;

								return hb_;
							};
							bool gx_()
							{
								DataType hc_ = O2Saturation?.Effective;
								object hd_ = FHIRHelpers_4_3_000.ToValue(hc_);
								bool he_ = hd_ is CqlInterval<CqlDateTime>;

								return he_;
							};
							bool gy_()
							{
								DataType hf_ = O2Saturation?.Effective;
								object hg_ = FHIRHelpers_4_3_000.ToValue(hf_);
								bool hh_ = hg_ is CqlDateTime;

								return hh_;
							};
							if (gw_())
							{
								DataType hi_ = O2Saturation?.Effective;
								object hj_ = FHIRHelpers_4_3_000.ToValue(hi_);
								CqlDateTime hk_ = hj_ switch { null => null , CqlDateTime n => n/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return hk_ as object;
							}
							else if (gx_())
							{
								DataType hl_ = O2Saturation?.Effective;
								object hm_ = FHIRHelpers_4_3_000.ToValue(hl_);
								CqlInterval<CqlDateTime> hn_ = hm_ switch { null => null , CqlInterval<CqlDateTime> o => o/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return hn_ as object;
							}
							else if (gy_())
							{
								DataType ho_ = O2Saturation?.Effective;
								object hp_ = FHIRHelpers_4_3_000.ToValue(ho_);
								CqlDateTime hq_ = hp_ switch { null => null , CqlDateTime p => p/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return hq_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime fy_ = QICoreCommon_2_0_000.earliest(fx_());
						Period fz_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> ga_ = FHIRHelpers_4_3_000.ToInterval(fz_);
						CqlDateTime gb_ = context.Operators.Start(ga_);
						CqlQuantity gc_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime gd_ = context.Operators.Subtract(gb_, gc_);
						CqlInterval<CqlDateTime> gf_ = FHIRHelpers_4_3_000.ToInterval(fz_);
						CqlDateTime gg_ = context.Operators.Start(gf_);
						CqlQuantity gh_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime gi_ = context.Operators.Add(gg_, gh_);
						CqlInterval<CqlDateTime> gj_ = context.Operators.Interval(gd_, gi_, true, true);
						bool? gk_ = context.Operators.In<CqlDateTime>(fy_, gj_, default);
						Code<ObservationStatus> gl_ = O2Saturation?.StatusElement;
						ObservationStatus? gm_ = gl_?.Value;
						Code<ObservationStatus> gn_ = context.Operators.Convert<Code<ObservationStatus>>(gm_);
						string go_ = context.Operators.Convert<string>(gn_);
						string[] gp_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? gq_ = context.Operators.In<string>(go_, gp_ as IEnumerable<string>);
						bool? gr_ = context.Operators.And(gk_, gq_);
						DataType gs_ = O2Saturation?.Value;
						object gt_ = FHIRHelpers_4_3_000.ToValue(gs_);
						bool? gu_ = context.Operators.Not((bool?)(gt_ is null));
						bool? gv_ = context.Operators.And(gr_, gu_);

						return gv_;
					};
					IEnumerable<Observation> fq_ = context.Operators.Where<Observation>(fo_, fp_);
					object fr_(Observation @this)
					{
						object hr_()
						{
							bool ht_()
							{
								DataType hw_ = @this?.Effective;
								object hx_ = FHIRHelpers_4_3_000.ToValue(hw_);
								bool hy_ = hx_ is CqlDateTime;

								return hy_;
							};
							bool hu_()
							{
								DataType hz_ = @this?.Effective;
								object ia_ = FHIRHelpers_4_3_000.ToValue(hz_);
								bool ib_ = ia_ is CqlInterval<CqlDateTime>;

								return ib_;
							};
							bool hv_()
							{
								DataType ic_ = @this?.Effective;
								object id_ = FHIRHelpers_4_3_000.ToValue(ic_);
								bool ie_ = id_ is CqlDateTime;

								return ie_;
							};
							if (ht_())
							{
								DataType if_ = @this?.Effective;
								object ig_ = FHIRHelpers_4_3_000.ToValue(if_);
								CqlDateTime ih_ = ig_ switch { null => null , CqlDateTime q => q/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ih_ as object;
							}
							else if (hu_())
							{
								DataType ii_ = @this?.Effective;
								object ij_ = FHIRHelpers_4_3_000.ToValue(ii_);
								CqlInterval<CqlDateTime> ik_ = ij_ switch { null => null , CqlInterval<CqlDateTime> r => r/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ik_ as object;
							}
							else if (hv_())
							{
								DataType il_ = @this?.Effective;
								object im_ = FHIRHelpers_4_3_000.ToValue(il_);
								CqlDateTime in_ = im_ switch { null => null , CqlDateTime s => s/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return in_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime hs_ = QICoreCommon_2_0_000.earliest(hr_());

						return hs_;
					};
					IEnumerable<Observation> fs_ = context.Operators.SortBy<Observation>(fq_, fr_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ft_ = context.Operators.First<Observation>(fs_);
					DataType fu_ = ft_?.Effective;
					object fv_ = FHIRHelpers_4_3_000.ToValue(fu_);
					bool fw_ = fv_ is CqlInterval<CqlDateTime>;

					return fw_;
				};
				bool cl_()
				{
					CqlValueSet io_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> ip_ = context.Operators.RetrieveByValueSet<Observation>(io_, default);
					bool? iq_(Observation O2Saturation)
					{
						object iy_()
						{
							bool jx_()
							{
								DataType ka_ = O2Saturation?.Effective;
								object kb_ = FHIRHelpers_4_3_000.ToValue(ka_);
								bool kc_ = kb_ is CqlDateTime;

								return kc_;
							};
							bool jy_()
							{
								DataType kd_ = O2Saturation?.Effective;
								object ke_ = FHIRHelpers_4_3_000.ToValue(kd_);
								bool kf_ = ke_ is CqlInterval<CqlDateTime>;

								return kf_;
							};
							bool jz_()
							{
								DataType kg_ = O2Saturation?.Effective;
								object kh_ = FHIRHelpers_4_3_000.ToValue(kg_);
								bool ki_ = kh_ is CqlDateTime;

								return ki_;
							};
							if (jx_())
							{
								DataType kj_ = O2Saturation?.Effective;
								object kk_ = FHIRHelpers_4_3_000.ToValue(kj_);
								CqlDateTime kl_ = kk_ switch { null => null , CqlDateTime t => t/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return kl_ as object;
							}
							else if (jy_())
							{
								DataType km_ = O2Saturation?.Effective;
								object kn_ = FHIRHelpers_4_3_000.ToValue(km_);
								CqlInterval<CqlDateTime> ko_ = kn_ switch { null => null , CqlInterval<CqlDateTime> u => u/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ko_ as object;
							}
							else if (jz_())
							{
								DataType kp_ = O2Saturation?.Effective;
								object kq_ = FHIRHelpers_4_3_000.ToValue(kp_);
								CqlDateTime kr_ = kq_ switch { null => null , CqlDateTime v => v/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return kr_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime iz_ = QICoreCommon_2_0_000.earliest(iy_());
						Period ja_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> jb_ = FHIRHelpers_4_3_000.ToInterval(ja_);
						CqlDateTime jc_ = context.Operators.Start(jb_);
						CqlQuantity jd_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime je_ = context.Operators.Subtract(jc_, jd_);
						CqlInterval<CqlDateTime> jg_ = FHIRHelpers_4_3_000.ToInterval(ja_);
						CqlDateTime jh_ = context.Operators.Start(jg_);
						CqlQuantity ji_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime jj_ = context.Operators.Add(jh_, ji_);
						CqlInterval<CqlDateTime> jk_ = context.Operators.Interval(je_, jj_, true, true);
						bool? jl_ = context.Operators.In<CqlDateTime>(iz_, jk_, default);
						Code<ObservationStatus> jm_ = O2Saturation?.StatusElement;
						ObservationStatus? jn_ = jm_?.Value;
						Code<ObservationStatus> jo_ = context.Operators.Convert<Code<ObservationStatus>>(jn_);
						string jp_ = context.Operators.Convert<string>(jo_);
						string[] jq_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? jr_ = context.Operators.In<string>(jp_, jq_ as IEnumerable<string>);
						bool? js_ = context.Operators.And(jl_, jr_);
						DataType jt_ = O2Saturation?.Value;
						object ju_ = FHIRHelpers_4_3_000.ToValue(jt_);
						bool? jv_ = context.Operators.Not((bool?)(ju_ is null));
						bool? jw_ = context.Operators.And(js_, jv_);

						return jw_;
					};
					IEnumerable<Observation> ir_ = context.Operators.Where<Observation>(ip_, iq_);
					object is_(Observation @this)
					{
						object ks_()
						{
							bool ku_()
							{
								DataType kx_ = @this?.Effective;
								object ky_ = FHIRHelpers_4_3_000.ToValue(kx_);
								bool kz_ = ky_ is CqlDateTime;

								return kz_;
							};
							bool kv_()
							{
								DataType la_ = @this?.Effective;
								object lb_ = FHIRHelpers_4_3_000.ToValue(la_);
								bool lc_ = lb_ is CqlInterval<CqlDateTime>;

								return lc_;
							};
							bool kw_()
							{
								DataType ld_ = @this?.Effective;
								object le_ = FHIRHelpers_4_3_000.ToValue(ld_);
								bool lf_ = le_ is CqlDateTime;

								return lf_;
							};
							if (ku_())
							{
								DataType lg_ = @this?.Effective;
								object lh_ = FHIRHelpers_4_3_000.ToValue(lg_);
								CqlDateTime li_ = lh_ switch { null => null , CqlDateTime w => w/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return li_ as object;
							}
							else if (kv_())
							{
								DataType lj_ = @this?.Effective;
								object lk_ = FHIRHelpers_4_3_000.ToValue(lj_);
								CqlInterval<CqlDateTime> ll_ = lk_ switch { null => null , CqlInterval<CqlDateTime> x => x/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ll_ as object;
							}
							else if (kw_())
							{
								DataType lm_ = @this?.Effective;
								object ln_ = FHIRHelpers_4_3_000.ToValue(lm_);
								CqlDateTime lo_ = ln_ switch { null => null , CqlDateTime y => y/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return lo_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime kt_ = QICoreCommon_2_0_000.earliest(ks_());

						return kt_;
					};
					IEnumerable<Observation> it_ = context.Operators.SortBy<Observation>(ir_, is_, System.ComponentModel.ListSortDirection.Ascending);
					Observation iu_ = context.Operators.First<Observation>(it_);
					DataType iv_ = iu_?.Effective;
					object iw_ = FHIRHelpers_4_3_000.ToValue(iv_);
					bool ix_ = iw_ is CqlDateTime;

					return ix_;
				};
				if (cj_())
				{
					CqlValueSet lp_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> lq_ = context.Operators.RetrieveByValueSet<Observation>(lp_, default);
					bool? lr_(Observation O2Saturation)
					{
						object lz_()
						{
							bool my_()
							{
								DataType nb_ = O2Saturation?.Effective;
								object nc_ = FHIRHelpers_4_3_000.ToValue(nb_);
								bool nd_ = nc_ is CqlDateTime;

								return nd_;
							};
							bool mz_()
							{
								DataType ne_ = O2Saturation?.Effective;
								object nf_ = FHIRHelpers_4_3_000.ToValue(ne_);
								bool ng_ = nf_ is CqlInterval<CqlDateTime>;

								return ng_;
							};
							bool na_()
							{
								DataType nh_ = O2Saturation?.Effective;
								object ni_ = FHIRHelpers_4_3_000.ToValue(nh_);
								bool nj_ = ni_ is CqlDateTime;

								return nj_;
							};
							if (my_())
							{
								DataType nk_ = O2Saturation?.Effective;
								object nl_ = FHIRHelpers_4_3_000.ToValue(nk_);
								CqlDateTime nm_ = nl_ switch { null => null , CqlDateTime z => z/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return nm_ as object;
							}
							else if (mz_())
							{
								DataType nn_ = O2Saturation?.Effective;
								object no_ = FHIRHelpers_4_3_000.ToValue(nn_);
								CqlInterval<CqlDateTime> np_ = no_ switch { null => null , CqlInterval<CqlDateTime> aa => aa/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return np_ as object;
							}
							else if (na_())
							{
								DataType nq_ = O2Saturation?.Effective;
								object nr_ = FHIRHelpers_4_3_000.ToValue(nq_);
								CqlDateTime ns_ = nr_ switch { null => null , CqlDateTime ab => ab/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ns_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ma_ = QICoreCommon_2_0_000.earliest(lz_());
						Period mb_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> mc_ = FHIRHelpers_4_3_000.ToInterval(mb_);
						CqlDateTime md_ = context.Operators.Start(mc_);
						CqlQuantity me_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime mf_ = context.Operators.Subtract(md_, me_);
						CqlInterval<CqlDateTime> mh_ = FHIRHelpers_4_3_000.ToInterval(mb_);
						CqlDateTime mi_ = context.Operators.Start(mh_);
						CqlQuantity mj_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime mk_ = context.Operators.Add(mi_, mj_);
						CqlInterval<CqlDateTime> ml_ = context.Operators.Interval(mf_, mk_, true, true);
						bool? mm_ = context.Operators.In<CqlDateTime>(ma_, ml_, default);
						Code<ObservationStatus> mn_ = O2Saturation?.StatusElement;
						ObservationStatus? mo_ = mn_?.Value;
						Code<ObservationStatus> mp_ = context.Operators.Convert<Code<ObservationStatus>>(mo_);
						string mq_ = context.Operators.Convert<string>(mp_);
						string[] mr_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? ms_ = context.Operators.In<string>(mq_, mr_ as IEnumerable<string>);
						bool? mt_ = context.Operators.And(mm_, ms_);
						DataType mu_ = O2Saturation?.Value;
						object mv_ = FHIRHelpers_4_3_000.ToValue(mu_);
						bool? mw_ = context.Operators.Not((bool?)(mv_ is null));
						bool? mx_ = context.Operators.And(mt_, mw_);

						return mx_;
					};
					IEnumerable<Observation> ls_ = context.Operators.Where<Observation>(lq_, lr_);
					object lt_(Observation @this)
					{
						object nt_()
						{
							bool nv_()
							{
								DataType ny_ = @this?.Effective;
								object nz_ = FHIRHelpers_4_3_000.ToValue(ny_);
								bool oa_ = nz_ is CqlDateTime;

								return oa_;
							};
							bool nw_()
							{
								DataType ob_ = @this?.Effective;
								object oc_ = FHIRHelpers_4_3_000.ToValue(ob_);
								bool od_ = oc_ is CqlInterval<CqlDateTime>;

								return od_;
							};
							bool nx_()
							{
								DataType oe_ = @this?.Effective;
								object of_ = FHIRHelpers_4_3_000.ToValue(oe_);
								bool og_ = of_ is CqlDateTime;

								return og_;
							};
							if (nv_())
							{
								DataType oh_ = @this?.Effective;
								object oi_ = FHIRHelpers_4_3_000.ToValue(oh_);
								CqlDateTime oj_ = oi_ switch { null => null , CqlDateTime ac => ac/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return oj_ as object;
							}
							else if (nw_())
							{
								DataType ok_ = @this?.Effective;
								object ol_ = FHIRHelpers_4_3_000.ToValue(ok_);
								CqlInterval<CqlDateTime> om_ = ol_ switch { null => null , CqlInterval<CqlDateTime> ad => ad/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return om_ as object;
							}
							else if (nx_())
							{
								DataType on_ = @this?.Effective;
								object oo_ = FHIRHelpers_4_3_000.ToValue(on_);
								CqlDateTime op_ = oo_ switch { null => null , CqlDateTime ae => ae/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return op_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime nu_ = QICoreCommon_2_0_000.earliest(nt_());

						return nu_;
					};
					IEnumerable<Observation> lu_ = context.Operators.SortBy<Observation>(ls_, lt_, System.ComponentModel.ListSortDirection.Ascending);
					Observation lv_ = context.Operators.First<Observation>(lu_);
					DataType lw_ = lv_?.Effective;
					object lx_ = FHIRHelpers_4_3_000.ToValue(lw_);
					CqlDateTime ly_ = lx_ switch { null => null , CqlDateTime af => af/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ly_ as object;
				}
				else if (ck_())
				{
					CqlValueSet oq_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> or_ = context.Operators.RetrieveByValueSet<Observation>(oq_, default);
					bool? os_(Observation O2Saturation)
					{
						object pa_()
						{
							bool pz_()
							{
								DataType qc_ = O2Saturation?.Effective;
								object qd_ = FHIRHelpers_4_3_000.ToValue(qc_);
								bool qe_ = qd_ is CqlDateTime;

								return qe_;
							};
							bool qa_()
							{
								DataType qf_ = O2Saturation?.Effective;
								object qg_ = FHIRHelpers_4_3_000.ToValue(qf_);
								bool qh_ = qg_ is CqlInterval<CqlDateTime>;

								return qh_;
							};
							bool qb_()
							{
								DataType qi_ = O2Saturation?.Effective;
								object qj_ = FHIRHelpers_4_3_000.ToValue(qi_);
								bool qk_ = qj_ is CqlDateTime;

								return qk_;
							};
							if (pz_())
							{
								DataType ql_ = O2Saturation?.Effective;
								object qm_ = FHIRHelpers_4_3_000.ToValue(ql_);
								CqlDateTime qn_ = qm_ switch { null => null , CqlDateTime ag => ag/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return qn_ as object;
							}
							else if (qa_())
							{
								DataType qo_ = O2Saturation?.Effective;
								object qp_ = FHIRHelpers_4_3_000.ToValue(qo_);
								CqlInterval<CqlDateTime> qq_ = qp_ switch { null => null , CqlInterval<CqlDateTime> ah => ah/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return qq_ as object;
							}
							else if (qb_())
							{
								DataType qr_ = O2Saturation?.Effective;
								object qs_ = FHIRHelpers_4_3_000.ToValue(qr_);
								CqlDateTime qt_ = qs_ switch { null => null , CqlDateTime ai => ai/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return qt_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime pb_ = QICoreCommon_2_0_000.earliest(pa_());
						Period pc_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> pd_ = FHIRHelpers_4_3_000.ToInterval(pc_);
						CqlDateTime pe_ = context.Operators.Start(pd_);
						CqlQuantity pf_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime pg_ = context.Operators.Subtract(pe_, pf_);
						CqlInterval<CqlDateTime> pi_ = FHIRHelpers_4_3_000.ToInterval(pc_);
						CqlDateTime pj_ = context.Operators.Start(pi_);
						CqlQuantity pk_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime pl_ = context.Operators.Add(pj_, pk_);
						CqlInterval<CqlDateTime> pm_ = context.Operators.Interval(pg_, pl_, true, true);
						bool? pn_ = context.Operators.In<CqlDateTime>(pb_, pm_, default);
						Code<ObservationStatus> po_ = O2Saturation?.StatusElement;
						ObservationStatus? pp_ = po_?.Value;
						Code<ObservationStatus> pq_ = context.Operators.Convert<Code<ObservationStatus>>(pp_);
						string pr_ = context.Operators.Convert<string>(pq_);
						string[] ps_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? pt_ = context.Operators.In<string>(pr_, ps_ as IEnumerable<string>);
						bool? pu_ = context.Operators.And(pn_, pt_);
						DataType pv_ = O2Saturation?.Value;
						object pw_ = FHIRHelpers_4_3_000.ToValue(pv_);
						bool? px_ = context.Operators.Not((bool?)(pw_ is null));
						bool? py_ = context.Operators.And(pu_, px_);

						return py_;
					};
					IEnumerable<Observation> ot_ = context.Operators.Where<Observation>(or_, os_);
					object ou_(Observation @this)
					{
						object qu_()
						{
							bool qw_()
							{
								DataType qz_ = @this?.Effective;
								object ra_ = FHIRHelpers_4_3_000.ToValue(qz_);
								bool rb_ = ra_ is CqlDateTime;

								return rb_;
							};
							bool qx_()
							{
								DataType rc_ = @this?.Effective;
								object rd_ = FHIRHelpers_4_3_000.ToValue(rc_);
								bool re_ = rd_ is CqlInterval<CqlDateTime>;

								return re_;
							};
							bool qy_()
							{
								DataType rf_ = @this?.Effective;
								object rg_ = FHIRHelpers_4_3_000.ToValue(rf_);
								bool rh_ = rg_ is CqlDateTime;

								return rh_;
							};
							if (qw_())
							{
								DataType ri_ = @this?.Effective;
								object rj_ = FHIRHelpers_4_3_000.ToValue(ri_);
								CqlDateTime rk_ = rj_ switch { null => null , CqlDateTime aj => aj/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return rk_ as object;
							}
							else if (qx_())
							{
								DataType rl_ = @this?.Effective;
								object rm_ = FHIRHelpers_4_3_000.ToValue(rl_);
								CqlInterval<CqlDateTime> rn_ = rm_ switch { null => null , CqlInterval<CqlDateTime> ak => ak/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return rn_ as object;
							}
							else if (qy_())
							{
								DataType ro_ = @this?.Effective;
								object rp_ = FHIRHelpers_4_3_000.ToValue(ro_);
								CqlDateTime rq_ = rp_ switch { null => null , CqlDateTime al => al/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return rq_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime qv_ = QICoreCommon_2_0_000.earliest(qu_());

						return qv_;
					};
					IEnumerable<Observation> ov_ = context.Operators.SortBy<Observation>(ot_, ou_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ow_ = context.Operators.First<Observation>(ov_);
					DataType ox_ = ow_?.Effective;
					object oy_ = FHIRHelpers_4_3_000.ToValue(ox_);
					CqlInterval<CqlDateTime> oz_ = oy_ switch { null => null , CqlInterval<CqlDateTime> am => am/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return oz_ as object;
				}
				else if (cl_())
				{
					CqlValueSet rr_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					IEnumerable<Observation> rs_ = context.Operators.RetrieveByValueSet<Observation>(rr_, default);
					bool? rt_(Observation O2Saturation)
					{
						object sb_()
						{
							bool ta_()
							{
								DataType td_ = O2Saturation?.Effective;
								object te_ = FHIRHelpers_4_3_000.ToValue(td_);
								bool tf_ = te_ is CqlDateTime;

								return tf_;
							};
							bool tb_()
							{
								DataType tg_ = O2Saturation?.Effective;
								object th_ = FHIRHelpers_4_3_000.ToValue(tg_);
								bool ti_ = th_ is CqlInterval<CqlDateTime>;

								return ti_;
							};
							bool tc_()
							{
								DataType tj_ = O2Saturation?.Effective;
								object tk_ = FHIRHelpers_4_3_000.ToValue(tj_);
								bool tl_ = tk_ is CqlDateTime;

								return tl_;
							};
							if (ta_())
							{
								DataType tm_ = O2Saturation?.Effective;
								object tn_ = FHIRHelpers_4_3_000.ToValue(tm_);
								CqlDateTime to_ = tn_ switch { null => null , CqlDateTime an => an/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return to_ as object;
							}
							else if (tb_())
							{
								DataType tp_ = O2Saturation?.Effective;
								object tq_ = FHIRHelpers_4_3_000.ToValue(tp_);
								CqlInterval<CqlDateTime> tr_ = tq_ switch { null => null , CqlInterval<CqlDateTime> ao => ao/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return tr_ as object;
							}
							else if (tc_())
							{
								DataType ts_ = O2Saturation?.Effective;
								object tt_ = FHIRHelpers_4_3_000.ToValue(ts_);
								CqlDateTime tu_ = tt_ switch { null => null , CqlDateTime ap => ap/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return tu_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime sc_ = QICoreCommon_2_0_000.earliest(sb_());
						Period sd_ = EncounterInpatient?.Period;
						CqlInterval<CqlDateTime> se_ = FHIRHelpers_4_3_000.ToInterval(sd_);
						CqlDateTime sf_ = context.Operators.Start(se_);
						CqlQuantity sg_ = context.Operators.Quantity(1440m, "minutes");
						CqlDateTime sh_ = context.Operators.Subtract(sf_, sg_);
						CqlInterval<CqlDateTime> sj_ = FHIRHelpers_4_3_000.ToInterval(sd_);
						CqlDateTime sk_ = context.Operators.Start(sj_);
						CqlQuantity sl_ = context.Operators.Quantity(120m, "minutes");
						CqlDateTime sm_ = context.Operators.Add(sk_, sl_);
						CqlInterval<CqlDateTime> sn_ = context.Operators.Interval(sh_, sm_, true, true);
						bool? so_ = context.Operators.In<CqlDateTime>(sc_, sn_, default);
						Code<ObservationStatus> sp_ = O2Saturation?.StatusElement;
						ObservationStatus? sq_ = sp_?.Value;
						Code<ObservationStatus> sr_ = context.Operators.Convert<Code<ObservationStatus>>(sq_);
						string ss_ = context.Operators.Convert<string>(sr_);
						string[] st_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? su_ = context.Operators.In<string>(ss_, st_ as IEnumerable<string>);
						bool? sv_ = context.Operators.And(so_, su_);
						DataType sw_ = O2Saturation?.Value;
						object sx_ = FHIRHelpers_4_3_000.ToValue(sw_);
						bool? sy_ = context.Operators.Not((bool?)(sx_ is null));
						bool? sz_ = context.Operators.And(sv_, sy_);

						return sz_;
					};
					IEnumerable<Observation> ru_ = context.Operators.Where<Observation>(rs_, rt_);
					object rv_(Observation @this)
					{
						object tv_()
						{
							bool tx_()
							{
								DataType ua_ = @this?.Effective;
								object ub_ = FHIRHelpers_4_3_000.ToValue(ua_);
								bool uc_ = ub_ is CqlDateTime;

								return uc_;
							};
							bool ty_()
							{
								DataType ud_ = @this?.Effective;
								object ue_ = FHIRHelpers_4_3_000.ToValue(ud_);
								bool uf_ = ue_ is CqlInterval<CqlDateTime>;

								return uf_;
							};
							bool tz_()
							{
								DataType ug_ = @this?.Effective;
								object uh_ = FHIRHelpers_4_3_000.ToValue(ug_);
								bool ui_ = uh_ is CqlDateTime;

								return ui_;
							};
							if (tx_())
							{
								DataType uj_ = @this?.Effective;
								object uk_ = FHIRHelpers_4_3_000.ToValue(uj_);
								CqlDateTime ul_ = uk_ switch { null => null , CqlDateTime aq => aq/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ul_ as object;
							}
							else if (ty_())
							{
								DataType um_ = @this?.Effective;
								object un_ = FHIRHelpers_4_3_000.ToValue(um_);
								CqlInterval<CqlDateTime> uo_ = un_ switch { null => null , CqlInterval<CqlDateTime> ar => ar/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return uo_ as object;
							}
							else if (tz_())
							{
								DataType up_ = @this?.Effective;
								object uq_ = FHIRHelpers_4_3_000.ToValue(up_);
								CqlDateTime ur_ = uq_ switch { null => null , CqlDateTime at => at/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ur_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime tw_ = QICoreCommon_2_0_000.earliest(tv_());

						return tw_;
					};
					IEnumerable<Observation> rw_ = context.Operators.SortBy<Observation>(ru_, rv_, System.ComponentModel.ListSortDirection.Ascending);
					Observation rx_ = context.Operators.First<Observation>(rw_);
					DataType ry_ = rx_?.Effective;
					object rz_ = FHIRHelpers_4_3_000.ToValue(ry_);
					CqlDateTime sa_ = rz_ switch { null => null , CqlDateTime au => au/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return sa_ as object;
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
			CqlQuantity o_ = n_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
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
			CqlQuantity o_ = n_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
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
			CqlQuantity o_ = n_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
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
			CqlQuantity o_ = n_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
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
			CqlQuantity o_ = n_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
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
			CqlQuantity o_ = n_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
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
