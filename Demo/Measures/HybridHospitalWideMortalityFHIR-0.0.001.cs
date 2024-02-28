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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
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
    internal Lazy<IEnumerable<Tuples.Tuple_BJTSgXESaFEOLbMHHiDMHCcdP>> __Encounter_with_First_Body_Temperature;
    internal Lazy<IEnumerable<Tuples.Tuple_DPdLURgGeOHhHAcheMAZcWfbT>> __Encounter_with_First_Heart_Rate;
    internal Lazy<IEnumerable<Tuples.Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO>> __Encounter_with_First_Oxygen_Saturation;
    internal Lazy<IEnumerable<Observation>> __Blood_Pressure_Reading;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_First_Systolic_Blood_Pressure;
    internal Lazy<IEnumerable<Tuples.Tuple_HPafMBLgKMTIEMRRLfcfNHQBV>> __Encounter_with_First_Bicarbonate_Lab_Test;
    internal Lazy<IEnumerable<Tuples.Tuple_GPTRiSLQJWYOPEAYVPRhQCIiV>> __Encounter_with_First_Creatinine_Lab_Test;
    internal Lazy<IEnumerable<Tuples.Tuple_BUSccGEhJLedCLcPKRPjDcPjV>> __Encounter_with_First_Hematocrit_Lab_Test;
    internal Lazy<IEnumerable<Tuples.Tuple_DfAYaANhHDiVRPdSaKCNbKVfZ>> __Encounter_with_First_Platelet_Lab_Test;
    internal Lazy<IEnumerable<Tuples.Tuple_BLYNRWKJOdUDPHZXcaNNjjGLE>> __Encounter_with_First_Sodium_Lab_Test;
    internal Lazy<IEnumerable<Tuples.Tuple_EHBXDbaEhdOYNSIVBgQCYjWfV>> __Encounter_with_First_White_Blood_Cells_Lab_Test;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __Encounter_with_First_Body_Temperature = new Lazy<IEnumerable<Tuples.Tuple_BJTSgXESaFEOLbMHHiDMHCcdP>>(this.Encounter_with_First_Body_Temperature_Value);
        __Encounter_with_First_Heart_Rate = new Lazy<IEnumerable<Tuples.Tuple_DPdLURgGeOHhHAcheMAZcWfbT>>(this.Encounter_with_First_Heart_Rate_Value);
        __Encounter_with_First_Oxygen_Saturation = new Lazy<IEnumerable<Tuples.Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO>>(this.Encounter_with_First_Oxygen_Saturation_Value);
        __Blood_Pressure_Reading = new Lazy<IEnumerable<Observation>>(this.Blood_Pressure_Reading_Value);
        __Encounter_with_First_Systolic_Blood_Pressure = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_First_Systolic_Blood_Pressure_Value);
        __Encounter_with_First_Bicarbonate_Lab_Test = new Lazy<IEnumerable<Tuples.Tuple_HPafMBLgKMTIEMRRLfcfNHQBV>>(this.Encounter_with_First_Bicarbonate_Lab_Test_Value);
        __Encounter_with_First_Creatinine_Lab_Test = new Lazy<IEnumerable<Tuples.Tuple_GPTRiSLQJWYOPEAYVPRhQCIiV>>(this.Encounter_with_First_Creatinine_Lab_Test_Value);
        __Encounter_with_First_Hematocrit_Lab_Test = new Lazy<IEnumerable<Tuples.Tuple_BUSccGEhJLedCLcPKRPjDcPjV>>(this.Encounter_with_First_Hematocrit_Lab_Test_Value);
        __Encounter_with_First_Platelet_Lab_Test = new Lazy<IEnumerable<Tuples.Tuple_DfAYaANhHDiVRPdSaKCNbKVfZ>>(this.Encounter_with_First_Platelet_Lab_Test_Value);
        __Encounter_with_First_Sodium_Lab_Test = new Lazy<IEnumerable<Tuples.Tuple_BLYNRWKJOdUDPHZXcaNNjjGLE>>(this.Encounter_with_First_Sodium_Lab_Test_Value);
        __Encounter_with_First_White_Blood_Cells_Lab_Test = new Lazy<IEnumerable<Tuples.Tuple_EHBXDbaEhdOYNSIVBgQCYjWfV>>(this.Encounter_with_First_White_Blood_Cells_Lab_Test_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Bicarbonate_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
	public CqlValueSet Bicarbonate_lab_test() => 
		__Bicarbonate_lab_test.Value;

	private CqlValueSet Creatinine_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
	public CqlValueSet Creatinine_lab_test() => 
		__Creatinine_lab_test.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Hematocrit_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public CqlValueSet Hematocrit_lab_test() => 
		__Hematocrit_lab_test.Value;

	private CqlValueSet Medicare_Advantage_payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", null);

    [CqlDeclaration("Medicare Advantage payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12")]
	public CqlValueSet Medicare_Advantage_payer() => 
		__Medicare_Advantage_payer.Value;

	private CqlValueSet Medicare_FFS_payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlDeclaration("Medicare FFS payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
	public CqlValueSet Medicare_FFS_payer() => 
		__Medicare_FFS_payer.Value;

	private CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", null);

    [CqlDeclaration("Oxygen Saturation by Pulse Oximetry")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151")]
	public CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry() => 
		__Oxygen_Saturation_by_Pulse_Oximetry.Value;

	private CqlValueSet Platelet_count_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
	public CqlValueSet Platelet_count_lab_test() => 
		__Platelet_count_lab_test.Value;

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

	private CqlCode Oxygen_saturation_in_Arterial_blood_Value() => 
		new CqlCode("2708-6", "http://loinc.org", null, null);

    [CqlDeclaration("Oxygen saturation in Arterial blood")]
	public CqlCode Oxygen_saturation_in_Arterial_blood() => 
		__Oxygen_saturation_in_Arterial_blood.Value;

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

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("2708-6", "http://loinc.org", null, null),
			new CqlCode("59408-5", "http://loinc.org", null, null),
			new CqlCode("8480-6", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] Source_of_Payment_Typology_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("Source of Payment Typology")]
	public CqlCode[] Source_of_Payment_Typology() => 
		__Source_of_Payment_Typology.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", e_);

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

	private IEnumerable<Encounter> Inpatient_Encounters_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Encounter> c_(Encounter InpatientEncounter)
		{
			var e_ = this.Medicare_FFS_payer();
			var f_ = context.Operators.RetrieveByValueSet<Coverage>(e_, null);
			var g_ = this.Medicare_Advantage_payer();
			var h_ = context.Operators.RetrieveByValueSet<Coverage>(g_, null);
			var i_ = context.Operators.ListUnion<Coverage>(f_, h_);
			bool? j_(Coverage MedicarePayer)
			{
				var n_ = CQMCommon_2_0_000.hospitalizationWithObservationAndOutpatientSurgeryService(InpatientEncounter);
				var o_ = CQMCommon_2_0_000.lengthInDays(n_);
				var p_ = context.Operators.Less(o_, (int?)365);
				var q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(InpatientEncounter?.StatusElement?.Value);
				var r_ = context.Operators.Equal(q_, "finished");
				var s_ = context.Operators.And(p_, r_);
				var t_ = this.Patient();
				var u_ = context.Operators.Convert<CqlDate>(t_?.BirthDateElement?.Value);
				var v_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
				var w_ = context.Operators.Start(v_);
				var x_ = context.Operators.DateFrom(w_);
				var y_ = context.Operators.CalculateAgeAt(u_, x_, "year");
				var z_ = context.Operators.Interval((int?)65, (int?)94, true, true);
				var aa_ = context.Operators.ElementInInterval<int?>(y_, z_, null);
				var ab_ = context.Operators.And(s_, aa_);
				var ad_ = context.Operators.End(v_);
				var ae_ = this.Measurement_Period();
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(ad_, ae_, "day");
				var ag_ = context.Operators.And(ab_, af_);

				return ag_;
			};
			var k_ = context.Operators.WhereOrNull<Coverage>(i_, j_);
			Encounter l_(Coverage MedicarePayer) => 
				InpatientEncounter;
			var m_ = context.Operators.SelectOrNull<Coverage, Encounter>(k_, l_);

			return m_;
		};
		var d_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
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

	private IEnumerable<Tuples.Tuple_BJTSgXESaFEOLbMHHiDMHCcdP> Encounter_with_First_Body_Temperature_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_BJTSgXESaFEOLbMHHiDMHCcdP b_(Encounter EncounterInpatient)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation temperature)
			{
				var t_ = FHIRHelpers_4_3_000.ToValue(temperature?.Effective);
				var u_ = QICoreCommon_2_0_000.earliest(t_);
				var v_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var w_ = context.Operators.Start(v_);
				var x_ = context.Operators.Quantity(1440m, "minutes");
				var y_ = context.Operators.Subtract(w_, x_);
				var aa_ = context.Operators.Start(v_);
				var ab_ = context.Operators.Quantity(120m, "minutes");
				var ac_ = context.Operators.Add(aa_, ab_);
				var ad_ = context.Operators.Interval(y_, ac_, true, true);
				var ae_ = context.Operators.ElementInInterval<CqlDateTime>(u_, ad_, null);
				var af_ = context.Operators.Convert<Code<ObservationStatus>>(temperature?.StatusElement?.Value);
				var ag_ = context.Operators.Convert<string>(af_);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(ae_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToQuantity(temperature?.Value);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(aj_, al_);

				return am_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var an_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ao_ = QICoreCommon_2_0_000.earliest(an_);

				return ao_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.FirstOfList<Observation>(h_);
			var j_ = FHIRHelpers_4_3_000.ToQuantity(i_?.Value);
			bool? l_(Observation temperature)
			{
				var ap_ = FHIRHelpers_4_3_000.ToValue(temperature?.Effective);
				var aq_ = QICoreCommon_2_0_000.earliest(ap_);
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity(1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ax_ = context.Operators.Quantity(120m, "minutes");
				var ay_ = context.Operators.Add(aw_, ax_);
				var az_ = context.Operators.Interval(au_, ay_, true, true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<Code<ObservationStatus>>(temperature?.StatusElement?.Value);
				var bc_ = context.Operators.Convert<string>(bb_);
				var bd_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var be_ = context.Operators.InList<string>(bc_, (bd_ as IEnumerable<string>));
				var bf_ = context.Operators.And(ba_, be_);
				var bg_ = FHIRHelpers_4_3_000.ToQuantity(temperature?.Value);
				var bh_ = context.Operators.Not((bool?)(bg_ is null));
				var bi_ = context.Operators.And(bf_, bh_);

				return bi_;
			};
			var m_ = context.Operators.WhereOrNull<Observation>(d_, l_);
			object n_(Observation @this)
			{
				var bj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bk_ = QICoreCommon_2_0_000.earliest(bj_);

				return bk_;
			};
			var o_ = context.Operators.ListSortBy<Observation>(m_, n_, System.ComponentModel.ListSortDirection.Ascending);
			var p_ = context.Operators.FirstOfList<Observation>(o_);
			var q_ = FHIRHelpers_4_3_000.ToValue(p_?.Effective);
			var r_ = QICoreCommon_2_0_000.earliest(q_);
			var s_ = new Tuples.Tuple_BJTSgXESaFEOLbMHHiDMHCcdP
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstTemperatureResult = (j_ as CqlQuantity),
				Timing = r_,
			};

			return s_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_BJTSgXESaFEOLbMHHiDMHCcdP>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Body Temperature")]
	public IEnumerable<Tuples.Tuple_BJTSgXESaFEOLbMHHiDMHCcdP> Encounter_with_First_Body_Temperature() => 
		__Encounter_with_First_Body_Temperature.Value;

	private IEnumerable<Tuples.Tuple_DPdLURgGeOHhHAcheMAZcWfbT> Encounter_with_First_Heart_Rate_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_DPdLURgGeOHhHAcheMAZcWfbT b_(Encounter EncounterInpatient)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation HeartRate)
			{
				var t_ = FHIRHelpers_4_3_000.ToValue(HeartRate?.Effective);
				var u_ = QICoreCommon_2_0_000.earliest(t_);
				var v_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var w_ = context.Operators.Start(v_);
				var x_ = context.Operators.Quantity(1440m, "minutes");
				var y_ = context.Operators.Subtract(w_, x_);
				var aa_ = context.Operators.Start(v_);
				var ab_ = context.Operators.Quantity(120m, "minutes");
				var ac_ = context.Operators.Add(aa_, ab_);
				var ad_ = context.Operators.Interval(y_, ac_, true, true);
				var ae_ = context.Operators.ElementInInterval<CqlDateTime>(u_, ad_, null);
				var af_ = context.Operators.Convert<Code<ObservationStatus>>(HeartRate?.StatusElement?.Value);
				var ag_ = context.Operators.Convert<string>(af_);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(ae_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToQuantity(HeartRate?.Value);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(aj_, al_);

				return am_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var an_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ao_ = QICoreCommon_2_0_000.earliest(an_);

				return ao_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.FirstOfList<Observation>(h_);
			var j_ = FHIRHelpers_4_3_000.ToQuantity(i_?.Value);
			bool? l_(Observation HeartRate)
			{
				var ap_ = FHIRHelpers_4_3_000.ToValue(HeartRate?.Effective);
				var aq_ = QICoreCommon_2_0_000.earliest(ap_);
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity(1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ax_ = context.Operators.Quantity(120m, "minutes");
				var ay_ = context.Operators.Add(aw_, ax_);
				var az_ = context.Operators.Interval(au_, ay_, true, true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<Code<ObservationStatus>>(HeartRate?.StatusElement?.Value);
				var bc_ = context.Operators.Convert<string>(bb_);
				var bd_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var be_ = context.Operators.InList<string>(bc_, (bd_ as IEnumerable<string>));
				var bf_ = context.Operators.And(ba_, be_);
				var bg_ = FHIRHelpers_4_3_000.ToQuantity(HeartRate?.Value);
				var bh_ = context.Operators.Not((bool?)(bg_ is null));
				var bi_ = context.Operators.And(bf_, bh_);

				return bi_;
			};
			var m_ = context.Operators.WhereOrNull<Observation>(d_, l_);
			object n_(Observation @this)
			{
				var bj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bk_ = QICoreCommon_2_0_000.earliest(bj_);

				return bk_;
			};
			var o_ = context.Operators.ListSortBy<Observation>(m_, n_, System.ComponentModel.ListSortDirection.Ascending);
			var p_ = context.Operators.FirstOfList<Observation>(o_);
			var q_ = FHIRHelpers_4_3_000.ToValue(p_?.Effective);
			var r_ = QICoreCommon_2_0_000.earliest(q_);
			var s_ = new Tuples.Tuple_DPdLURgGeOHhHAcheMAZcWfbT
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstHeartRateResult = (j_ as CqlQuantity),
				Timing = r_,
			};

			return s_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_DPdLURgGeOHhHAcheMAZcWfbT>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Heart Rate")]
	public IEnumerable<Tuples.Tuple_DPdLURgGeOHhHAcheMAZcWfbT> Encounter_with_First_Heart_Rate() => 
		__Encounter_with_First_Heart_Rate.Value;

	private IEnumerable<Tuples.Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO> Encounter_with_First_Oxygen_Saturation_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO b_(Encounter EncounterInpatient)
		{
			var d_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation O2Saturation)
			{
				object o_()
				{
					if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
					{
						var ai_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

						return ((ai_ as CqlDateTime) as object);
					}
					else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlInterval<CqlDateTime>)
					{
						var aj_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

						return ((aj_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
					{
						var ak_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

						return ((ak_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var p_ = QICoreCommon_2_0_000.earliest(o_());
				var q_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var r_ = context.Operators.Start(q_);
				var s_ = context.Operators.Quantity(1440m, "minutes");
				var t_ = context.Operators.Subtract(r_, s_);
				var v_ = context.Operators.Start(q_);
				var w_ = context.Operators.Quantity(120m, "minutes");
				var x_ = context.Operators.Add(v_, w_);
				var y_ = context.Operators.Interval(t_, x_, true, true);
				var z_ = context.Operators.ElementInInterval<CqlDateTime>(p_, y_, null);
				var aa_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
				var ab_ = context.Operators.Convert<string>(aa_);
				var ac_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ad_ = context.Operators.InList<string>(ab_, (ac_ as IEnumerable<string>));
				var ae_ = context.Operators.And(z_, ad_);
				var af_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
				var ag_ = context.Operators.Not((bool?)(af_ is null));
				var ah_ = context.Operators.And(ae_, ag_);

				return ah_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			object h_(Observation @this)
			{
				object al_()
				{
					if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
					{
						var an_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((an_ as CqlDateTime) as object);
					}
					else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
					{
						var ao_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((ao_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
					{
						var ap_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((ap_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var am_ = QICoreCommon_2_0_000.earliest(al_());

				return am_;
			};
			var i_ = context.Operators.ListSortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			var j_ = context.Operators.FirstOfList<Observation>(i_);
			var k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			object l_()
			{
				if (FHIRHelpers_4_3_000.ToValue((context.Operators.FirstOfList<Observation>(context.Operators.ListSortBy<Observation>(context.Operators.WhereOrNull<Observation>(context.Operators.RetrieveByValueSet<Observation>(this.Oxygen_Saturation_by_Pulse_Oximetry(), null), (Observation O2Saturation) => 
				context.Operators.And(context.Operators.And(context.Operators.ElementInInterval<CqlDateTime>(QICoreCommon_2_0_000.earliest(								if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlDateTime) as object);
								}
								else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlInterval<CqlDateTime>)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlInterval<CqlDateTime>) as object);
								}
								else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlDateTime) as object);
								}
								else
								{
									return null;
								}), context.Operators.Interval(context.Operators.Subtract(context.Operators.Start(FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period)), context.Operators.Quantity(1440m, "minutes")), context.Operators.Add(context.Operators.Start(FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period)), context.Operators.Quantity(120m, "minutes")), true, true), null), context.Operators.InList<string>(context.Operators.Convert<string>(context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value)), (new string[]
							{
								"final",
								"amended",
								"corrected",
							} as IEnumerable<string>))), context.Operators.Not((bool?)(FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value) is null)))), (Observation @this) => 
			QICoreCommon_2_0_000.earliest(				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else
				{
					return null;
				}), System.ComponentModel.ListSortDirection.Ascending)))?.Effective) is CqlDateTime)
				{
					var aq_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var ar_ = context.Operators.RetrieveByValueSet<Observation>(aq_, null);
					bool? as_(Observation O2Saturation)
					{
						object ay_()
						{
							if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
							{
								var bs_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((bs_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlInterval<CqlDateTime>)
							{
								var bt_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((bt_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
							{
								var bu_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((bu_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var az_ = QICoreCommon_2_0_000.earliest(ay_());
						var ba_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var bb_ = context.Operators.Start(ba_);
						var bc_ = context.Operators.Quantity(1440m, "minutes");
						var bd_ = context.Operators.Subtract(bb_, bc_);
						var bf_ = context.Operators.Start(ba_);
						var bg_ = context.Operators.Quantity(120m, "minutes");
						var bh_ = context.Operators.Add(bf_, bg_);
						var bi_ = context.Operators.Interval(bd_, bh_, true, true);
						var bj_ = context.Operators.ElementInInterval<CqlDateTime>(az_, bi_, null);
						var bk_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var bl_ = context.Operators.Convert<string>(bk_);
						var bm_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var bn_ = context.Operators.InList<string>(bl_, (bm_ as IEnumerable<string>));
						var bo_ = context.Operators.And(bj_, bn_);
						var bp_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var bq_ = context.Operators.Not((bool?)(bp_ is null));
						var br_ = context.Operators.And(bo_, bq_);

						return br_;
					};
					var at_ = context.Operators.WhereOrNull<Observation>(ar_, as_);
					object au_(Observation @this)
					{
						object bv_()
						{
							if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var bx_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bx_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
							{
								var by_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((by_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var bz_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bz_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var bw_ = QICoreCommon_2_0_000.earliest(bv_());

						return bw_;
					};
					var av_ = context.Operators.ListSortBy<Observation>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
					var aw_ = context.Operators.FirstOfList<Observation>(av_);
					var ax_ = FHIRHelpers_4_3_000.ToValue(aw_?.Effective);

					return ((ax_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue((context.Operators.FirstOfList<Observation>(context.Operators.ListSortBy<Observation>(context.Operators.WhereOrNull<Observation>(context.Operators.RetrieveByValueSet<Observation>(this.Oxygen_Saturation_by_Pulse_Oximetry(), null), (Observation O2Saturation) => 
				context.Operators.And(context.Operators.And(context.Operators.ElementInInterval<CqlDateTime>(QICoreCommon_2_0_000.earliest(								if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlDateTime) as object);
								}
								else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlInterval<CqlDateTime>)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlInterval<CqlDateTime>) as object);
								}
								else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlDateTime) as object);
								}
								else
								{
									return null;
								}), context.Operators.Interval(context.Operators.Subtract(context.Operators.Start(FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period)), context.Operators.Quantity(1440m, "minutes")), context.Operators.Add(context.Operators.Start(FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period)), context.Operators.Quantity(120m, "minutes")), true, true), null), context.Operators.InList<string>(context.Operators.Convert<string>(context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value)), (new string[]
							{
								"final",
								"amended",
								"corrected",
							} as IEnumerable<string>))), context.Operators.Not((bool?)(FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value) is null)))), (Observation @this) => 
			QICoreCommon_2_0_000.earliest(				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else
				{
					return null;
				}), System.ComponentModel.ListSortDirection.Ascending)))?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ca_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var cb_ = context.Operators.RetrieveByValueSet<Observation>(ca_, null);
					bool? cc_(Observation O2Saturation)
					{
						object ci_()
						{
							if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
							{
								var dc_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((dc_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlInterval<CqlDateTime>)
							{
								var dd_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((dd_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
							{
								var de_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((de_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var cj_ = QICoreCommon_2_0_000.earliest(ci_());
						var ck_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var cl_ = context.Operators.Start(ck_);
						var cm_ = context.Operators.Quantity(1440m, "minutes");
						var cn_ = context.Operators.Subtract(cl_, cm_);
						var cp_ = context.Operators.Start(ck_);
						var cq_ = context.Operators.Quantity(120m, "minutes");
						var cr_ = context.Operators.Add(cp_, cq_);
						var cs_ = context.Operators.Interval(cn_, cr_, true, true);
						var ct_ = context.Operators.ElementInInterval<CqlDateTime>(cj_, cs_, null);
						var cu_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var cv_ = context.Operators.Convert<string>(cu_);
						var cw_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var cx_ = context.Operators.InList<string>(cv_, (cw_ as IEnumerable<string>));
						var cy_ = context.Operators.And(ct_, cx_);
						var cz_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var da_ = context.Operators.Not((bool?)(cz_ is null));
						var db_ = context.Operators.And(cy_, da_);

						return db_;
					};
					var cd_ = context.Operators.WhereOrNull<Observation>(cb_, cc_);
					object ce_(Observation @this)
					{
						object df_()
						{
							if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var dh_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((dh_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
							{
								var di_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((di_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var dj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((dj_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var dg_ = QICoreCommon_2_0_000.earliest(df_());

						return dg_;
					};
					var cf_ = context.Operators.ListSortBy<Observation>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);
					var cg_ = context.Operators.FirstOfList<Observation>(cf_);
					var ch_ = FHIRHelpers_4_3_000.ToValue(cg_?.Effective);

					return ((ch_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue((context.Operators.FirstOfList<Observation>(context.Operators.ListSortBy<Observation>(context.Operators.WhereOrNull<Observation>(context.Operators.RetrieveByValueSet<Observation>(this.Oxygen_Saturation_by_Pulse_Oximetry(), null), (Observation O2Saturation) => 
				context.Operators.And(context.Operators.And(context.Operators.ElementInInterval<CqlDateTime>(QICoreCommon_2_0_000.earliest(								if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlDateTime) as object);
								}
								else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlInterval<CqlDateTime>)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlInterval<CqlDateTime>) as object);
								}
								else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
								{
									return ((FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) as CqlDateTime) as object);
								}
								else
								{
									return null;
								}), context.Operators.Interval(context.Operators.Subtract(context.Operators.Start(FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period)), context.Operators.Quantity(1440m, "minutes")), context.Operators.Add(context.Operators.Start(FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period)), context.Operators.Quantity(120m, "minutes")), true, true), null), context.Operators.InList<string>(context.Operators.Convert<string>(context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value)), (new string[]
							{
								"final",
								"amended",
								"corrected",
							} as IEnumerable<string>))), context.Operators.Not((bool?)(FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value) is null)))), (Observation @this) => 
			QICoreCommon_2_0_000.earliest(				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else
				{
					return null;
				}), System.ComponentModel.ListSortDirection.Ascending)))?.Effective) is CqlDateTime)
				{
					var dk_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var dl_ = context.Operators.RetrieveByValueSet<Observation>(dk_, null);
					bool? dm_(Observation O2Saturation)
					{
						object ds_()
						{
							if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
							{
								var em_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((em_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlInterval<CqlDateTime>)
							{
								var en_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((en_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective) is CqlDateTime)
							{
								var eo_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((eo_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var dt_ = QICoreCommon_2_0_000.earliest(ds_());
						var du_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var dv_ = context.Operators.Start(du_);
						var dw_ = context.Operators.Quantity(1440m, "minutes");
						var dx_ = context.Operators.Subtract(dv_, dw_);
						var dz_ = context.Operators.Start(du_);
						var ea_ = context.Operators.Quantity(120m, "minutes");
						var eb_ = context.Operators.Add(dz_, ea_);
						var ec_ = context.Operators.Interval(dx_, eb_, true, true);
						var ed_ = context.Operators.ElementInInterval<CqlDateTime>(dt_, ec_, null);
						var ee_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var ef_ = context.Operators.Convert<string>(ee_);
						var eg_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var eh_ = context.Operators.InList<string>(ef_, (eg_ as IEnumerable<string>));
						var ei_ = context.Operators.And(ed_, eh_);
						var ej_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var ek_ = context.Operators.Not((bool?)(ej_ is null));
						var el_ = context.Operators.And(ei_, ek_);

						return el_;
					};
					var dn_ = context.Operators.WhereOrNull<Observation>(dl_, dm_);
					object do_(Observation @this)
					{
						object ep_()
						{
							if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var er_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((er_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
							{
								var es_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((es_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var et_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((et_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var eq_ = QICoreCommon_2_0_000.earliest(ep_());

						return eq_;
					};
					var dp_ = context.Operators.ListSortBy<Observation>(dn_, do_, System.ComponentModel.ListSortDirection.Ascending);
					var dq_ = context.Operators.FirstOfList<Observation>(dp_);
					var dr_ = FHIRHelpers_4_3_000.ToValue(dq_?.Effective);

					return ((dr_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var m_ = QICoreCommon_2_0_000.earliest(l_());
			var n_ = new Tuples.Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstOxygenSatResult = (k_ as CqlQuantity),
				Timing = m_,
			};

			return n_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Oxygen Saturation")]
	public IEnumerable<Tuples.Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO> Encounter_with_First_Oxygen_Saturation() => 
		__Encounter_with_First_Oxygen_Saturation.Value;

	private IEnumerable<Observation> Blood_Pressure_Reading_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		bool? b_(Observation BloodPressure)
		{
			var d_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
			var e_ = context.Operators.Convert<string>(d_);
			var f_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var g_ = context.Operators.InList<string>(e_, (f_ as IEnumerable<string>));

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Blood Pressure Reading")]
	public IEnumerable<Observation> Blood_Pressure_Reading() => 
		__Blood_Pressure_Reading.Value;

	private IEnumerable<Encounter> Encounter_with_First_Systolic_Blood_Pressure_Value()
	{
		var a_ = this.Inpatient_Encounters();

		return a_;
	}

    [CqlDeclaration("Encounter with First Systolic Blood Pressure")]
	public IEnumerable<Encounter> Encounter_with_First_Systolic_Blood_Pressure() => 
		__Encounter_with_First_Systolic_Blood_Pressure.Value;

	private IEnumerable<Tuples.Tuple_HPafMBLgKMTIEMRRLfcfNHQBV> Encounter_with_First_Bicarbonate_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_HPafMBLgKMTIEMRRLfcfNHQBV b_(Encounter EncounterInpatient)
		{
			var d_ = this.Bicarbonate_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation BicarbonateLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(BicarbonateLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity(1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, true, true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(BicarbonateLab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(BicarbonateLab?.Value);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(aj_, al_);

				return am_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			object h_(Observation @this)
			{
				var an_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var ao_ = QICoreCommon_2_0_000.earliest((an_ as object));

				return ao_;
			};
			var i_ = context.Operators.ListSortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			var j_ = context.Operators.FirstOfList<Observation>(i_);
			var k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			var m_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? n_(Observation BicarbonateLab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(BicarbonateLab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity(1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, true, true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(BicarbonateLab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(BicarbonateLab?.Value);
				var bg_ = context.Operators.Not((bool?)(bf_ is null));
				var bh_ = context.Operators.And(be_, bg_);

				return bh_;
			};
			var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
			object p_(Observation @this)
			{
				var bi_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var bj_ = QICoreCommon_2_0_000.earliest((bi_ as object));

				return bj_;
			};
			var q_ = context.Operators.ListSortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
			var r_ = context.Operators.FirstOfList<Observation>(q_);
			var s_ = context.Operators.Convert<CqlDateTime>(r_?.IssuedElement?.Value);
			var t_ = new Tuples.Tuple_HPafMBLgKMTIEMRRLfcfNHQBV
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstBicarbonateResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_HPafMBLgKMTIEMRRLfcfNHQBV>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Bicarbonate Lab Test")]
	public IEnumerable<Tuples.Tuple_HPafMBLgKMTIEMRRLfcfNHQBV> Encounter_with_First_Bicarbonate_Lab_Test() => 
		__Encounter_with_First_Bicarbonate_Lab_Test.Value;

	private IEnumerable<Tuples.Tuple_GPTRiSLQJWYOPEAYVPRhQCIiV> Encounter_with_First_Creatinine_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_GPTRiSLQJWYOPEAYVPRhQCIiV b_(Encounter EncounterInpatient)
		{
			var d_ = this.Creatinine_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation CreatinineLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(CreatinineLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity(1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, true, true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(CreatinineLab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(CreatinineLab?.Value);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(aj_, al_);

				return am_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			object h_(Observation @this)
			{
				var an_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var ao_ = QICoreCommon_2_0_000.earliest((an_ as object));

				return ao_;
			};
			var i_ = context.Operators.ListSortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			var j_ = context.Operators.FirstOfList<Observation>(i_);
			var k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			var m_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? n_(Observation CreatinineLab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(CreatinineLab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity(1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, true, true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(CreatinineLab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(CreatinineLab?.Value);
				var bg_ = context.Operators.Not((bool?)(bf_ is null));
				var bh_ = context.Operators.And(be_, bg_);

				return bh_;
			};
			var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
			object p_(Observation @this)
			{
				var bi_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var bj_ = QICoreCommon_2_0_000.earliest((bi_ as object));

				return bj_;
			};
			var q_ = context.Operators.ListSortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
			var r_ = context.Operators.FirstOfList<Observation>(q_);
			var s_ = context.Operators.Convert<CqlDateTime>(r_?.IssuedElement?.Value);
			var t_ = new Tuples.Tuple_GPTRiSLQJWYOPEAYVPRhQCIiV
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstCreatinineResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_GPTRiSLQJWYOPEAYVPRhQCIiV>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Creatinine Lab Test")]
	public IEnumerable<Tuples.Tuple_GPTRiSLQJWYOPEAYVPRhQCIiV> Encounter_with_First_Creatinine_Lab_Test() => 
		__Encounter_with_First_Creatinine_Lab_Test.Value;

	private IEnumerable<Tuples.Tuple_BUSccGEhJLedCLcPKRPjDcPjV> Encounter_with_First_Hematocrit_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_BUSccGEhJLedCLcPKRPjDcPjV b_(Encounter EncounterInpatient)
		{
			var d_ = this.Hematocrit_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation HematocritLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(HematocritLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity(1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, true, true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(HematocritLab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(HematocritLab?.Value);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(aj_, al_);

				return am_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			object h_(Observation @this)
			{
				var an_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var ao_ = QICoreCommon_2_0_000.earliest((an_ as object));

				return ao_;
			};
			var i_ = context.Operators.ListSortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			var j_ = context.Operators.FirstOfList<Observation>(i_);
			var k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			var m_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? n_(Observation HematocritLab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(HematocritLab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity(1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, true, true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(HematocritLab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(HematocritLab?.Value);
				var bg_ = context.Operators.Not((bool?)(bf_ is null));
				var bh_ = context.Operators.And(be_, bg_);

				return bh_;
			};
			var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
			object p_(Observation @this)
			{
				var bi_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var bj_ = QICoreCommon_2_0_000.earliest((bi_ as object));

				return bj_;
			};
			var q_ = context.Operators.ListSortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
			var r_ = context.Operators.FirstOfList<Observation>(q_);
			var s_ = context.Operators.Convert<CqlDateTime>(r_?.IssuedElement?.Value);
			var t_ = new Tuples.Tuple_BUSccGEhJLedCLcPKRPjDcPjV
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstHematocritResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_BUSccGEhJLedCLcPKRPjDcPjV>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Hematocrit Lab Test")]
	public IEnumerable<Tuples.Tuple_BUSccGEhJLedCLcPKRPjDcPjV> Encounter_with_First_Hematocrit_Lab_Test() => 
		__Encounter_with_First_Hematocrit_Lab_Test.Value;

	private IEnumerable<Tuples.Tuple_DfAYaANhHDiVRPdSaKCNbKVfZ> Encounter_with_First_Platelet_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_DfAYaANhHDiVRPdSaKCNbKVfZ b_(Encounter EncounterInpatient)
		{
			var d_ = this.Platelet_count_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation PlateletLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(PlateletLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity(1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, true, true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(PlateletLab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(PlateletLab?.Value);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(aj_, al_);

				return am_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			object h_(Observation @this)
			{
				var an_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var ao_ = QICoreCommon_2_0_000.earliest((an_ as object));

				return ao_;
			};
			var i_ = context.Operators.ListSortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			var j_ = context.Operators.FirstOfList<Observation>(i_);
			var k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			var m_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? n_(Observation PlateletLab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(PlateletLab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity(1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, true, true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(PlateletLab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(PlateletLab?.Value);
				var bg_ = context.Operators.Not((bool?)(bf_ is null));
				var bh_ = context.Operators.And(be_, bg_);

				return bh_;
			};
			var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
			object p_(Observation @this)
			{
				var bi_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var bj_ = QICoreCommon_2_0_000.earliest((bi_ as object));

				return bj_;
			};
			var q_ = context.Operators.ListSortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
			var r_ = context.Operators.FirstOfList<Observation>(q_);
			var s_ = context.Operators.Convert<CqlDateTime>(r_?.IssuedElement?.Value);
			var t_ = new Tuples.Tuple_DfAYaANhHDiVRPdSaKCNbKVfZ
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstPlateletResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_DfAYaANhHDiVRPdSaKCNbKVfZ>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Platelet Lab Test")]
	public IEnumerable<Tuples.Tuple_DfAYaANhHDiVRPdSaKCNbKVfZ> Encounter_with_First_Platelet_Lab_Test() => 
		__Encounter_with_First_Platelet_Lab_Test.Value;

	private IEnumerable<Tuples.Tuple_BLYNRWKJOdUDPHZXcaNNjjGLE> Encounter_with_First_Sodium_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_BLYNRWKJOdUDPHZXcaNNjjGLE b_(Encounter EncounterInpatient)
		{
			var d_ = this.Sodium_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation SodiumLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(SodiumLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity(1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, true, true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(SodiumLab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(SodiumLab?.Value);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(aj_, al_);

				return am_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			object h_(Observation @this)
			{
				var an_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var ao_ = QICoreCommon_2_0_000.earliest((an_ as object));

				return ao_;
			};
			var i_ = context.Operators.ListSortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			var j_ = context.Operators.FirstOfList<Observation>(i_);
			var k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			var m_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? n_(Observation SodiumLab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(SodiumLab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity(1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, true, true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(SodiumLab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(SodiumLab?.Value);
				var bg_ = context.Operators.Not((bool?)(bf_ is null));
				var bh_ = context.Operators.And(be_, bg_);

				return bh_;
			};
			var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
			object p_(Observation @this)
			{
				var bi_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var bj_ = QICoreCommon_2_0_000.earliest((bi_ as object));

				return bj_;
			};
			var q_ = context.Operators.ListSortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
			var r_ = context.Operators.FirstOfList<Observation>(q_);
			var s_ = context.Operators.Convert<CqlDateTime>(r_?.IssuedElement?.Value);
			var t_ = new Tuples.Tuple_BLYNRWKJOdUDPHZXcaNNjjGLE
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstSodiumResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_BLYNRWKJOdUDPHZXcaNNjjGLE>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Sodium Lab Test")]
	public IEnumerable<Tuples.Tuple_BLYNRWKJOdUDPHZXcaNNjjGLE> Encounter_with_First_Sodium_Lab_Test() => 
		__Encounter_with_First_Sodium_Lab_Test.Value;

	private IEnumerable<Tuples.Tuple_EHBXDbaEhdOYNSIVBgQCYjWfV> Encounter_with_First_White_Blood_Cells_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuples.Tuple_EHBXDbaEhdOYNSIVBgQCYjWfV b_(Encounter EncounterInpatient)
		{
			var d_ = this.White_blood_cells_count_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation WhiteBloodCellLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(WhiteBloodCellLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity(1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, true, true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(WhiteBloodCellLab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(WhiteBloodCellLab?.Value);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(aj_, al_);

				return am_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			object h_(Observation @this)
			{
				var an_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var ao_ = QICoreCommon_2_0_000.earliest((an_ as object));

				return ao_;
			};
			var i_ = context.Operators.ListSortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			var j_ = context.Operators.FirstOfList<Observation>(i_);
			var k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			var m_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? n_(Observation WhiteBloodCellLab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(WhiteBloodCellLab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity(1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, true, true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(WhiteBloodCellLab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(WhiteBloodCellLab?.Value);
				var bg_ = context.Operators.Not((bool?)(bf_ is null));
				var bh_ = context.Operators.And(be_, bg_);

				return bh_;
			};
			var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
			object p_(Observation @this)
			{
				var bi_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				var bj_ = QICoreCommon_2_0_000.earliest((bi_ as object));

				return bj_;
			};
			var q_ = context.Operators.ListSortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
			var r_ = context.Operators.FirstOfList<Observation>(q_);
			var s_ = context.Operators.Convert<CqlDateTime>(r_?.IssuedElement?.Value);
			var t_ = new Tuples.Tuple_EHBXDbaEhdOYNSIVBgQCYjWfV
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstWhiteBloodCellResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_EHBXDbaEhdOYNSIVBgQCYjWfV>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First White Blood Cells Lab Test")]
	public IEnumerable<Tuples.Tuple_EHBXDbaEhdOYNSIVBgQCYjWfV> Encounter_with_First_White_Blood_Cells_Lab_Test() => 
		__Encounter_with_First_White_Blood_Cells_Lab_Test.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}