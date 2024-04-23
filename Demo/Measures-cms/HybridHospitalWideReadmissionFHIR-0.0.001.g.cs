using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("HybridHospitalWideReadmissionFHIR", "0.0.001")]
public class HybridHospitalWideReadmissionFHIR_0_0_001
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bicarbonate_lab_test;
    internal Lazy<CqlValueSet> __Creatinine_lab_test;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Glucose_lab_test;
    internal Lazy<CqlValueSet> __Hematocrit_lab_test;
    internal Lazy<CqlValueSet> __Medicare_Advantage_payer;
    internal Lazy<CqlValueSet> __Medicare_FFS_payer;
    internal Lazy<CqlValueSet> __Oxygen_Saturation_by_Pulse_Oximetry;
    internal Lazy<CqlValueSet> __Potassium_lab_test;
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
    internal Lazy<IEnumerable<Tuple_BJTSgXESaFEOLbMHHiDMHCcdP>> __Encounter_with_First_Body_Temperature;
    internal Lazy<IEnumerable<Tuple_DPdLURgGeOHhHAcheMAZcWfbT>> __Encounter_with_First_Heart_Rate;
    internal Lazy<IEnumerable<Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO>> __Encounter_with_First_Oxygen_Saturation;
    internal Lazy<IEnumerable<Tuple_EAccDaIgTNOHbEQUMLJiXWIJO>> __Encounter_with_First_Respiratory_Rate;
    internal Lazy<IEnumerable<Observation>> __Blood_Pressure_Reading;
    internal Lazy<IEnumerable<string>> __Encounter_with_First_Systolic_Blood_Pressure;
    internal Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>> __Encounter_with_First_Bicarbonate_Lab_Test;
    internal Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>> __Encounter_with_First_Creatinine_Lab_Test;
    internal Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>> __Encounter_with_First_Glucose_Lab_Test;
    internal Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>> __Encounter_with_First_Hematocrit_Lab_Test;
    internal Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>> __Encounter_with_First_Potassium_Lab_Test;
    internal Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>> __Encounter_with_First_Sodium_Lab_Test;
    internal Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>> __Encounter_with_First_White_Blood_Cells_Lab_Test;
    internal Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>> __Encounter_with_First_Weight_Recorded_During_Stay;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public HybridHospitalWideReadmissionFHIR_0_0_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Bicarbonate_lab_test = new Lazy<CqlValueSet>(this.Bicarbonate_lab_test_Value);
        __Creatinine_lab_test = new Lazy<CqlValueSet>(this.Creatinine_lab_test_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Glucose_lab_test = new Lazy<CqlValueSet>(this.Glucose_lab_test_Value);
        __Hematocrit_lab_test = new Lazy<CqlValueSet>(this.Hematocrit_lab_test_Value);
        __Medicare_Advantage_payer = new Lazy<CqlValueSet>(this.Medicare_Advantage_payer_Value);
        __Medicare_FFS_payer = new Lazy<CqlValueSet>(this.Medicare_FFS_payer_Value);
        __Oxygen_Saturation_by_Pulse_Oximetry = new Lazy<CqlValueSet>(this.Oxygen_Saturation_by_Pulse_Oximetry_Value);
        __Potassium_lab_test = new Lazy<CqlValueSet>(this.Potassium_lab_test_Value);
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
        __Encounter_with_First_Body_Temperature = new Lazy<IEnumerable<Tuple_BJTSgXESaFEOLbMHHiDMHCcdP>>(this.Encounter_with_First_Body_Temperature_Value);
        __Encounter_with_First_Heart_Rate = new Lazy<IEnumerable<Tuple_DPdLURgGeOHhHAcheMAZcWfbT>>(this.Encounter_with_First_Heart_Rate_Value);
        __Encounter_with_First_Oxygen_Saturation = new Lazy<IEnumerable<Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO>>(this.Encounter_with_First_Oxygen_Saturation_Value);
        __Encounter_with_First_Respiratory_Rate = new Lazy<IEnumerable<Tuple_EAccDaIgTNOHbEQUMLJiXWIJO>>(this.Encounter_with_First_Respiratory_Rate_Value);
        __Blood_Pressure_Reading = new Lazy<IEnumerable<Observation>>(this.Blood_Pressure_Reading_Value);
        __Encounter_with_First_Systolic_Blood_Pressure = new Lazy<IEnumerable<string>>(this.Encounter_with_First_Systolic_Blood_Pressure_Value);
        __Encounter_with_First_Bicarbonate_Lab_Test = new Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>>(this.Encounter_with_First_Bicarbonate_Lab_Test_Value);
        __Encounter_with_First_Creatinine_Lab_Test = new Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>>(this.Encounter_with_First_Creatinine_Lab_Test_Value);
        __Encounter_with_First_Glucose_Lab_Test = new Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>>(this.Encounter_with_First_Glucose_Lab_Test_Value);
        __Encounter_with_First_Hematocrit_Lab_Test = new Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>>(this.Encounter_with_First_Hematocrit_Lab_Test_Value);
        __Encounter_with_First_Potassium_Lab_Test = new Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>>(this.Encounter_with_First_Potassium_Lab_Test_Value);
        __Encounter_with_First_Sodium_Lab_Test = new Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>>(this.Encounter_with_First_Sodium_Lab_Test_Value);
        __Encounter_with_First_White_Blood_Cells_Lab_Test = new Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>>(this.Encounter_with_First_White_Blood_Cells_Lab_Test_Value);
        __Encounter_with_First_Weight_Recorded_During_Stay = new Lazy<IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>>(this.Encounter_with_First_Weight_Recorded_During_Stay_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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

	private CqlValueSet Potassium_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", null);

    [CqlDeclaration("Potassium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117")]
	public CqlValueSet Potassium_lab_test() => 
		__Potassium_lab_test.Value;

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
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
		var d_ = context.ResolveParameter("HybridHospitalWideReadmissionFHIR-0.0.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

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
				var z_ = context.Operators.GreaterOrEqual(y_, (int?)65);
				var aa_ = context.Operators.And(s_, z_);
				var ac_ = context.Operators.End(v_);
				var ad_ = this.Measurement_Period();
				var ae_ = context.Operators.ElementInInterval<CqlDateTime>(ac_, ad_, "day");
				var af_ = context.Operators.And(aa_, ae_);

				return af_;
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

	private IEnumerable<Tuple_BJTSgXESaFEOLbMHHiDMHCcdP> Encounter_with_First_Body_Temperature_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BJTSgXESaFEOLbMHHiDMHCcdP b_(Encounter EncounterInpatient)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation temperature)
			{
				var u_ = FHIRHelpers_4_3_000.ToValue(temperature?.Effective);
				var v_ = QICoreCommon_2_0_000.earliest(u_);
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ac_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var ad_ = context.Operators.Add(ab_, ac_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(temperature?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = context.Operators.Convert<Quantity>(temperature?.Value);
				var al_ = FHIRHelpers_4_3_000.ToQuantity(ak_);
				var am_ = context.Operators.Not((bool?)(al_ is null));
				var an_ = context.Operators.And(aj_, am_);

				return an_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var ao_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ap_ = QICoreCommon_2_0_000.earliest(ao_);

				return ap_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.FirstOfList<Observation>(h_);
			var j_ = context.Operators.Convert<Quantity>(i_?.Value);
			var k_ = FHIRHelpers_4_3_000.ToQuantity(j_);
			bool? m_(Observation temperature)
			{
				var aq_ = FHIRHelpers_4_3_000.ToValue(temperature?.Effective);
				var ar_ = QICoreCommon_2_0_000.earliest(aq_);
				var as_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var at_ = context.Operators.Start(as_);
				var au_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var av_ = context.Operators.Subtract(at_, au_);
				var ax_ = context.Operators.Start(as_);
				var ay_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var az_ = context.Operators.Add(ax_, ay_);
				var ba_ = context.Operators.Interval(av_, az_, (bool?)true, (bool?)true);
				var bb_ = context.Operators.ElementInInterval<CqlDateTime>(ar_, ba_, null);
				var bc_ = context.Operators.Convert<string>(temperature?.StatusElement?.Value);
				var bd_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var be_ = context.Operators.InList<string>(bc_, (bd_ as IEnumerable<string>));
				var bf_ = context.Operators.And(bb_, be_);
				var bg_ = context.Operators.Convert<Quantity>(temperature?.Value);
				var bh_ = FHIRHelpers_4_3_000.ToQuantity(bg_);
				var bi_ = context.Operators.Not((bool?)(bh_ is null));
				var bj_ = context.Operators.And(bf_, bi_);

				return bj_;
			};
			var n_ = context.Operators.WhereOrNull<Observation>(d_, m_);
			object o_(Observation @this)
			{
				var bk_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bl_ = QICoreCommon_2_0_000.earliest(bk_);

				return bl_;
			};
			var p_ = context.Operators.ListSortBy<Observation>(n_, o_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = context.Operators.FirstOfList<Observation>(p_);
			var r_ = FHIRHelpers_4_3_000.ToValue(q_?.Effective);
			var s_ = QICoreCommon_2_0_000.earliest(r_);
			var t_ = new Tuple_BJTSgXESaFEOLbMHHiDMHCcdP
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstTemperatureResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BJTSgXESaFEOLbMHHiDMHCcdP>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Body Temperature")]
	public IEnumerable<Tuple_BJTSgXESaFEOLbMHHiDMHCcdP> Encounter_with_First_Body_Temperature() => 
		__Encounter_with_First_Body_Temperature.Value;

	private IEnumerable<Tuple_DPdLURgGeOHhHAcheMAZcWfbT> Encounter_with_First_Heart_Rate_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_DPdLURgGeOHhHAcheMAZcWfbT b_(Encounter EncounterInpatient)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation HeartRate)
			{
				var u_ = FHIRHelpers_4_3_000.ToValue(HeartRate?.Effective);
				var v_ = QICoreCommon_2_0_000.earliest(u_);
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ac_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var ad_ = context.Operators.Add(ab_, ac_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(HeartRate?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = context.Operators.Convert<Quantity>(HeartRate?.Value);
				var al_ = FHIRHelpers_4_3_000.ToQuantity(ak_);
				var am_ = context.Operators.Not((bool?)(al_ is null));
				var an_ = context.Operators.And(aj_, am_);

				return an_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var ao_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ap_ = QICoreCommon_2_0_000.earliest(ao_);

				return ap_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.FirstOfList<Observation>(h_);
			var j_ = context.Operators.Convert<Quantity>(i_?.Value);
			var k_ = FHIRHelpers_4_3_000.ToQuantity(j_);
			bool? m_(Observation HeartRate)
			{
				var aq_ = FHIRHelpers_4_3_000.ToValue(HeartRate?.Effective);
				var ar_ = QICoreCommon_2_0_000.earliest(aq_);
				var as_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var at_ = context.Operators.Start(as_);
				var au_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var av_ = context.Operators.Subtract(at_, au_);
				var ax_ = context.Operators.Start(as_);
				var ay_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var az_ = context.Operators.Add(ax_, ay_);
				var ba_ = context.Operators.Interval(av_, az_, (bool?)true, (bool?)true);
				var bb_ = context.Operators.ElementInInterval<CqlDateTime>(ar_, ba_, null);
				var bc_ = context.Operators.Convert<string>(HeartRate?.StatusElement?.Value);
				var bd_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var be_ = context.Operators.InList<string>(bc_, (bd_ as IEnumerable<string>));
				var bf_ = context.Operators.And(bb_, be_);
				var bg_ = context.Operators.Convert<Quantity>(HeartRate?.Value);
				var bh_ = FHIRHelpers_4_3_000.ToQuantity(bg_);
				var bi_ = context.Operators.Not((bool?)(bh_ is null));
				var bj_ = context.Operators.And(bf_, bi_);

				return bj_;
			};
			var n_ = context.Operators.WhereOrNull<Observation>(d_, m_);
			object o_(Observation @this)
			{
				var bk_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bl_ = QICoreCommon_2_0_000.earliest(bk_);

				return bl_;
			};
			var p_ = context.Operators.ListSortBy<Observation>(n_, o_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = context.Operators.FirstOfList<Observation>(p_);
			var r_ = FHIRHelpers_4_3_000.ToValue(q_?.Effective);
			var s_ = QICoreCommon_2_0_000.earliest(r_);
			var t_ = new Tuple_DPdLURgGeOHhHAcheMAZcWfbT
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstHeartRateResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_DPdLURgGeOHhHAcheMAZcWfbT>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Heart Rate")]
	public IEnumerable<Tuple_DPdLURgGeOHhHAcheMAZcWfbT> Encounter_with_First_Heart_Rate() => 
		__Encounter_with_First_Heart_Rate.Value;

	private IEnumerable<Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO> Encounter_with_First_Oxygen_Saturation_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO b_(Encounter EncounterInpatient)
		{
			var d_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation O2Saturation)
			{
				object o_()
				{
					bool ai_()
					{
						var al_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
						var am_ = al_ is CqlDateTime;

						return am_;
					};
					bool aj_()
					{
						var an_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
						var ao_ = an_ is CqlInterval<CqlDateTime>;

						return ao_;
					};
					bool ak_()
					{
						var ap_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
						var aq_ = ap_ is CqlDateTime;

						return aq_;
					};
					if (ai_())
					{
						var ar_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

						return ((ar_ as CqlDateTime) as object);
					}
					else if (aj_())
					{
						var as_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

						return ((as_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (ak_())
					{
						var at_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

						return ((at_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var p_ = QICoreCommon_2_0_000.earliest(o_());
				var q_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var r_ = context.Operators.Start(q_);
				var s_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var t_ = context.Operators.Subtract(r_, s_);
				var v_ = context.Operators.Start(q_);
				var w_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var x_ = context.Operators.Add(v_, w_);
				var y_ = context.Operators.Interval(t_, x_, (bool?)true, (bool?)true);
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
				object au_()
				{
					bool aw_()
					{
						var az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						var ba_ = az_ is CqlDateTime;

						return ba_;
					};
					bool ax_()
					{
						var bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						var bc_ = bb_ is CqlInterval<CqlDateTime>;

						return bc_;
					};
					bool ay_()
					{
						var bd_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
						var be_ = bd_ is CqlDateTime;

						return be_;
					};
					if (aw_())
					{
						var bf_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((bf_ as CqlDateTime) as object);
					}
					else if (ax_())
					{
						var bg_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((bg_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (ay_())
					{
						var bh_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

						return ((bh_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var av_ = QICoreCommon_2_0_000.earliest(au_());

				return av_;
			};
			var i_ = context.Operators.ListSortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			var j_ = context.Operators.FirstOfList<Observation>(i_);
			var k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			object l_()
			{
				bool bi_()
				{
					var bl_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var bm_ = context.Operators.RetrieveByValueSet<Observation>(bl_, null);
					bool? bn_(Observation O2Saturation)
					{
						object bu_()
						{
							bool co_()
							{
								var cr_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var cs_ = cr_ is CqlDateTime;

								return cs_;
							};
							bool cp_()
							{
								var ct_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var cu_ = ct_ is CqlInterval<CqlDateTime>;

								return cu_;
							};
							bool cq_()
							{
								var cv_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var cw_ = cv_ is CqlDateTime;

								return cw_;
							};
							if (co_())
							{
								var cx_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((cx_ as CqlDateTime) as object);
							}
							else if (cp_())
							{
								var cy_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((cy_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (cq_())
							{
								var cz_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((cz_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var bv_ = QICoreCommon_2_0_000.earliest(bu_());
						var bw_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var bx_ = context.Operators.Start(bw_);
						var by_ = context.Operators.Quantity((decimal?)1440m, "minutes");
						var bz_ = context.Operators.Subtract(bx_, by_);
						var cb_ = context.Operators.Start(bw_);
						var cc_ = context.Operators.Quantity((decimal?)120m, "minutes");
						var cd_ = context.Operators.Add(cb_, cc_);
						var ce_ = context.Operators.Interval(bz_, cd_, (bool?)true, (bool?)true);
						var cf_ = context.Operators.ElementInInterval<CqlDateTime>(bv_, ce_, null);
						var cg_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var ch_ = context.Operators.Convert<string>(cg_);
						var ci_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var cj_ = context.Operators.InList<string>(ch_, (ci_ as IEnumerable<string>));
						var ck_ = context.Operators.And(cf_, cj_);
						var cl_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var cm_ = context.Operators.Not((bool?)(cl_ is null));
						var cn_ = context.Operators.And(ck_, cm_);

						return cn_;
					};
					var bo_ = context.Operators.WhereOrNull<Observation>(bm_, bn_);
					object bp_(Observation @this)
					{
						object da_()
						{
							bool dc_()
							{
								var df_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var dg_ = df_ is CqlDateTime;

								return dg_;
							};
							bool dd_()
							{
								var dh_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var di_ = dh_ is CqlInterval<CqlDateTime>;

								return di_;
							};
							bool de_()
							{
								var dj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var dk_ = dj_ is CqlDateTime;

								return dk_;
							};
							if (dc_())
							{
								var dl_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((dl_ as CqlDateTime) as object);
							}
							else if (dd_())
							{
								var dm_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((dm_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (de_())
							{
								var dn_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((dn_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var db_ = QICoreCommon_2_0_000.earliest(da_());

						return db_;
					};
					var bq_ = context.Operators.ListSortBy<Observation>(bo_, bp_, System.ComponentModel.ListSortDirection.Ascending);
					var br_ = context.Operators.FirstOfList<Observation>(bq_);
					var bs_ = FHIRHelpers_4_3_000.ToValue(br_?.Effective);
					var bt_ = bs_ is CqlDateTime;

					return bt_;
				};
				bool bj_()
				{
					var do_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var dp_ = context.Operators.RetrieveByValueSet<Observation>(do_, null);
					bool? dq_(Observation O2Saturation)
					{
						object dx_()
						{
							bool er_()
							{
								var eu_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var ev_ = eu_ is CqlDateTime;

								return ev_;
							};
							bool es_()
							{
								var ew_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var ex_ = ew_ is CqlInterval<CqlDateTime>;

								return ex_;
							};
							bool et_()
							{
								var ey_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var ez_ = ey_ is CqlDateTime;

								return ez_;
							};
							if (er_())
							{
								var fa_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((fa_ as CqlDateTime) as object);
							}
							else if (es_())
							{
								var fb_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((fb_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (et_())
							{
								var fc_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((fc_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var dy_ = QICoreCommon_2_0_000.earliest(dx_());
						var dz_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var ea_ = context.Operators.Start(dz_);
						var eb_ = context.Operators.Quantity((decimal?)1440m, "minutes");
						var ec_ = context.Operators.Subtract(ea_, eb_);
						var ee_ = context.Operators.Start(dz_);
						var ef_ = context.Operators.Quantity((decimal?)120m, "minutes");
						var eg_ = context.Operators.Add(ee_, ef_);
						var eh_ = context.Operators.Interval(ec_, eg_, (bool?)true, (bool?)true);
						var ei_ = context.Operators.ElementInInterval<CqlDateTime>(dy_, eh_, null);
						var ej_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var ek_ = context.Operators.Convert<string>(ej_);
						var el_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var em_ = context.Operators.InList<string>(ek_, (el_ as IEnumerable<string>));
						var en_ = context.Operators.And(ei_, em_);
						var eo_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var ep_ = context.Operators.Not((bool?)(eo_ is null));
						var eq_ = context.Operators.And(en_, ep_);

						return eq_;
					};
					var dr_ = context.Operators.WhereOrNull<Observation>(dp_, dq_);
					object ds_(Observation @this)
					{
						object fd_()
						{
							bool ff_()
							{
								var fi_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var fj_ = fi_ is CqlDateTime;

								return fj_;
							};
							bool fg_()
							{
								var fk_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var fl_ = fk_ is CqlInterval<CqlDateTime>;

								return fl_;
							};
							bool fh_()
							{
								var fm_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var fn_ = fm_ is CqlDateTime;

								return fn_;
							};
							if (ff_())
							{
								var fo_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((fo_ as CqlDateTime) as object);
							}
							else if (fg_())
							{
								var fp_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((fp_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (fh_())
							{
								var fq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((fq_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var fe_ = QICoreCommon_2_0_000.earliest(fd_());

						return fe_;
					};
					var dt_ = context.Operators.ListSortBy<Observation>(dr_, ds_, System.ComponentModel.ListSortDirection.Ascending);
					var du_ = context.Operators.FirstOfList<Observation>(dt_);
					var dv_ = FHIRHelpers_4_3_000.ToValue(du_?.Effective);
					var dw_ = dv_ is CqlInterval<CqlDateTime>;

					return dw_;
				};
				bool bk_()
				{
					var fr_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var fs_ = context.Operators.RetrieveByValueSet<Observation>(fr_, null);
					bool? ft_(Observation O2Saturation)
					{
						object ga_()
						{
							bool gu_()
							{
								var gx_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var gy_ = gx_ is CqlDateTime;

								return gy_;
							};
							bool gv_()
							{
								var gz_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var ha_ = gz_ is CqlInterval<CqlDateTime>;

								return ha_;
							};
							bool gw_()
							{
								var hb_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var hc_ = hb_ is CqlDateTime;

								return hc_;
							};
							if (gu_())
							{
								var hd_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((hd_ as CqlDateTime) as object);
							}
							else if (gv_())
							{
								var he_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((he_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (gw_())
							{
								var hf_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((hf_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var gb_ = QICoreCommon_2_0_000.earliest(ga_());
						var gc_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var gd_ = context.Operators.Start(gc_);
						var ge_ = context.Operators.Quantity((decimal?)1440m, "minutes");
						var gf_ = context.Operators.Subtract(gd_, ge_);
						var gh_ = context.Operators.Start(gc_);
						var gi_ = context.Operators.Quantity((decimal?)120m, "minutes");
						var gj_ = context.Operators.Add(gh_, gi_);
						var gk_ = context.Operators.Interval(gf_, gj_, (bool?)true, (bool?)true);
						var gl_ = context.Operators.ElementInInterval<CqlDateTime>(gb_, gk_, null);
						var gm_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var gn_ = context.Operators.Convert<string>(gm_);
						var go_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var gp_ = context.Operators.InList<string>(gn_, (go_ as IEnumerable<string>));
						var gq_ = context.Operators.And(gl_, gp_);
						var gr_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var gs_ = context.Operators.Not((bool?)(gr_ is null));
						var gt_ = context.Operators.And(gq_, gs_);

						return gt_;
					};
					var fu_ = context.Operators.WhereOrNull<Observation>(fs_, ft_);
					object fv_(Observation @this)
					{
						object hg_()
						{
							bool hi_()
							{
								var hl_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var hm_ = hl_ is CqlDateTime;

								return hm_;
							};
							bool hj_()
							{
								var hn_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ho_ = hn_ is CqlInterval<CqlDateTime>;

								return ho_;
							};
							bool hk_()
							{
								var hp_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var hq_ = hp_ is CqlDateTime;

								return hq_;
							};
							if (hi_())
							{
								var hr_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((hr_ as CqlDateTime) as object);
							}
							else if (hj_())
							{
								var hs_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((hs_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (hk_())
							{
								var ht_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ht_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var hh_ = QICoreCommon_2_0_000.earliest(hg_());

						return hh_;
					};
					var fw_ = context.Operators.ListSortBy<Observation>(fu_, fv_, System.ComponentModel.ListSortDirection.Ascending);
					var fx_ = context.Operators.FirstOfList<Observation>(fw_);
					var fy_ = FHIRHelpers_4_3_000.ToValue(fx_?.Effective);
					var fz_ = fy_ is CqlDateTime;

					return fz_;
				};
				if (bi_())
				{
					var hu_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var hv_ = context.Operators.RetrieveByValueSet<Observation>(hu_, null);
					bool? hw_(Observation O2Saturation)
					{
						object ic_()
						{
							bool iw_()
							{
								var iz_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var ja_ = iz_ is CqlDateTime;

								return ja_;
							};
							bool ix_()
							{
								var jb_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var jc_ = jb_ is CqlInterval<CqlDateTime>;

								return jc_;
							};
							bool iy_()
							{
								var jd_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var je_ = jd_ is CqlDateTime;

								return je_;
							};
							if (iw_())
							{
								var jf_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((jf_ as CqlDateTime) as object);
							}
							else if (ix_())
							{
								var jg_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((jg_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (iy_())
							{
								var jh_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((jh_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var id_ = QICoreCommon_2_0_000.earliest(ic_());
						var ie_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var if_ = context.Operators.Start(ie_);
						var ig_ = context.Operators.Quantity((decimal?)1440m, "minutes");
						var ih_ = context.Operators.Subtract(if_, ig_);
						var ij_ = context.Operators.Start(ie_);
						var ik_ = context.Operators.Quantity((decimal?)120m, "minutes");
						var il_ = context.Operators.Add(ij_, ik_);
						var im_ = context.Operators.Interval(ih_, il_, (bool?)true, (bool?)true);
						var in_ = context.Operators.ElementInInterval<CqlDateTime>(id_, im_, null);
						var io_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var ip_ = context.Operators.Convert<string>(io_);
						var iq_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var ir_ = context.Operators.InList<string>(ip_, (iq_ as IEnumerable<string>));
						var is_ = context.Operators.And(in_, ir_);
						var it_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var iu_ = context.Operators.Not((bool?)(it_ is null));
						var iv_ = context.Operators.And(is_, iu_);

						return iv_;
					};
					var hx_ = context.Operators.WhereOrNull<Observation>(hv_, hw_);
					object hy_(Observation @this)
					{
						object ji_()
						{
							bool jk_()
							{
								var jn_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var jo_ = jn_ is CqlDateTime;

								return jo_;
							};
							bool jl_()
							{
								var jp_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var jq_ = jp_ is CqlInterval<CqlDateTime>;

								return jq_;
							};
							bool jm_()
							{
								var jr_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var js_ = jr_ is CqlDateTime;

								return js_;
							};
							if (jk_())
							{
								var jt_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((jt_ as CqlDateTime) as object);
							}
							else if (jl_())
							{
								var ju_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ju_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (jm_())
							{
								var jv_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((jv_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var jj_ = QICoreCommon_2_0_000.earliest(ji_());

						return jj_;
					};
					var hz_ = context.Operators.ListSortBy<Observation>(hx_, hy_, System.ComponentModel.ListSortDirection.Ascending);
					var ia_ = context.Operators.FirstOfList<Observation>(hz_);
					var ib_ = FHIRHelpers_4_3_000.ToValue(ia_?.Effective);

					return ((ib_ as CqlDateTime) as object);
				}
				else if (bj_())
				{
					var jw_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var jx_ = context.Operators.RetrieveByValueSet<Observation>(jw_, null);
					bool? jy_(Observation O2Saturation)
					{
						object ke_()
						{
							bool ky_()
							{
								var lb_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var lc_ = lb_ is CqlDateTime;

								return lc_;
							};
							bool kz_()
							{
								var ld_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var le_ = ld_ is CqlInterval<CqlDateTime>;

								return le_;
							};
							bool la_()
							{
								var lf_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var lg_ = lf_ is CqlDateTime;

								return lg_;
							};
							if (ky_())
							{
								var lh_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((lh_ as CqlDateTime) as object);
							}
							else if (kz_())
							{
								var li_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((li_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (la_())
							{
								var lj_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((lj_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var kf_ = QICoreCommon_2_0_000.earliest(ke_());
						var kg_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var kh_ = context.Operators.Start(kg_);
						var ki_ = context.Operators.Quantity((decimal?)1440m, "minutes");
						var kj_ = context.Operators.Subtract(kh_, ki_);
						var kl_ = context.Operators.Start(kg_);
						var km_ = context.Operators.Quantity((decimal?)120m, "minutes");
						var kn_ = context.Operators.Add(kl_, km_);
						var ko_ = context.Operators.Interval(kj_, kn_, (bool?)true, (bool?)true);
						var kp_ = context.Operators.ElementInInterval<CqlDateTime>(kf_, ko_, null);
						var kq_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var kr_ = context.Operators.Convert<string>(kq_);
						var ks_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var kt_ = context.Operators.InList<string>(kr_, (ks_ as IEnumerable<string>));
						var ku_ = context.Operators.And(kp_, kt_);
						var kv_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var kw_ = context.Operators.Not((bool?)(kv_ is null));
						var kx_ = context.Operators.And(ku_, kw_);

						return kx_;
					};
					var jz_ = context.Operators.WhereOrNull<Observation>(jx_, jy_);
					object ka_(Observation @this)
					{
						object lk_()
						{
							bool lm_()
							{
								var lp_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var lq_ = lp_ is CqlDateTime;

								return lq_;
							};
							bool ln_()
							{
								var lr_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ls_ = lr_ is CqlInterval<CqlDateTime>;

								return ls_;
							};
							bool lo_()
							{
								var lt_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var lu_ = lt_ is CqlDateTime;

								return lu_;
							};
							if (lm_())
							{
								var lv_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((lv_ as CqlDateTime) as object);
							}
							else if (ln_())
							{
								var lw_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((lw_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (lo_())
							{
								var lx_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((lx_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var ll_ = QICoreCommon_2_0_000.earliest(lk_());

						return ll_;
					};
					var kb_ = context.Operators.ListSortBy<Observation>(jz_, ka_, System.ComponentModel.ListSortDirection.Ascending);
					var kc_ = context.Operators.FirstOfList<Observation>(kb_);
					var kd_ = FHIRHelpers_4_3_000.ToValue(kc_?.Effective);

					return ((kd_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bk_())
				{
					var ly_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var lz_ = context.Operators.RetrieveByValueSet<Observation>(ly_, null);
					bool? ma_(Observation O2Saturation)
					{
						object mg_()
						{
							bool na_()
							{
								var nd_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var ne_ = nd_ is CqlDateTime;

								return ne_;
							};
							bool nb_()
							{
								var nf_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var ng_ = nf_ is CqlInterval<CqlDateTime>;

								return ng_;
							};
							bool nc_()
							{
								var nh_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);
								var ni_ = nh_ is CqlDateTime;

								return ni_;
							};
							if (na_())
							{
								var nj_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((nj_ as CqlDateTime) as object);
							}
							else if (nb_())
							{
								var nk_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((nk_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (nc_())
							{
								var nl_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Effective);

								return ((nl_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var mh_ = QICoreCommon_2_0_000.earliest(mg_());
						var mi_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
						var mj_ = context.Operators.Start(mi_);
						var mk_ = context.Operators.Quantity((decimal?)1440m, "minutes");
						var ml_ = context.Operators.Subtract(mj_, mk_);
						var mn_ = context.Operators.Start(mi_);
						var mo_ = context.Operators.Quantity((decimal?)120m, "minutes");
						var mp_ = context.Operators.Add(mn_, mo_);
						var mq_ = context.Operators.Interval(ml_, mp_, (bool?)true, (bool?)true);
						var mr_ = context.Operators.ElementInInterval<CqlDateTime>(mh_, mq_, null);
						var ms_ = context.Operators.Convert<Code<ObservationStatus>>(O2Saturation?.StatusElement?.Value);
						var mt_ = context.Operators.Convert<string>(ms_);
						var mu_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var mv_ = context.Operators.InList<string>(mt_, (mu_ as IEnumerable<string>));
						var mw_ = context.Operators.And(mr_, mv_);
						var mx_ = FHIRHelpers_4_3_000.ToValue(O2Saturation?.Value);
						var my_ = context.Operators.Not((bool?)(mx_ is null));
						var mz_ = context.Operators.And(mw_, my_);

						return mz_;
					};
					var mb_ = context.Operators.WhereOrNull<Observation>(lz_, ma_);
					object mc_(Observation @this)
					{
						object nm_()
						{
							bool no_()
							{
								var nr_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ns_ = nr_ is CqlDateTime;

								return ns_;
							};
							bool np_()
							{
								var nt_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var nu_ = nt_ is CqlInterval<CqlDateTime>;

								return nu_;
							};
							bool nq_()
							{
								var nv_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var nw_ = nv_ is CqlDateTime;

								return nw_;
							};
							if (no_())
							{
								var nx_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((nx_ as CqlDateTime) as object);
							}
							else if (np_())
							{
								var ny_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ny_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (nq_())
							{
								var nz_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((nz_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var nn_ = QICoreCommon_2_0_000.earliest(nm_());

						return nn_;
					};
					var md_ = context.Operators.ListSortBy<Observation>(mb_, mc_, System.ComponentModel.ListSortDirection.Ascending);
					var me_ = context.Operators.FirstOfList<Observation>(md_);
					var mf_ = FHIRHelpers_4_3_000.ToValue(me_?.Effective);

					return ((mf_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var m_ = QICoreCommon_2_0_000.earliest(l_());
			var n_ = new Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstOxygenSatResult = (k_ as CqlQuantity),
				Timing = m_,
			};

			return n_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Oxygen Saturation")]
	public IEnumerable<Tuple_GWOGLWjZWOZYMaEJIOWOEZNOO> Encounter_with_First_Oxygen_Saturation() => 
		__Encounter_with_First_Oxygen_Saturation.Value;

	private IEnumerable<Tuple_EAccDaIgTNOHbEQUMLJiXWIJO> Encounter_with_First_Respiratory_Rate_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_EAccDaIgTNOHbEQUMLJiXWIJO b_(Encounter EncounterInpatient)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation RespRate)
			{
				var u_ = FHIRHelpers_4_3_000.ToValue(RespRate?.Effective);
				var v_ = QICoreCommon_2_0_000.earliest(u_);
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ac_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var ad_ = context.Operators.Add(ab_, ac_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(RespRate?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = context.Operators.Convert<Quantity>(RespRate?.Value);
				var al_ = FHIRHelpers_4_3_000.ToQuantity(ak_);
				var am_ = context.Operators.Not((bool?)(al_ is null));
				var an_ = context.Operators.And(aj_, am_);

				return an_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var ao_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ap_ = QICoreCommon_2_0_000.earliest(ao_);

				return ap_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.FirstOfList<Observation>(h_);
			var j_ = context.Operators.Convert<Quantity>(i_?.Value);
			var k_ = FHIRHelpers_4_3_000.ToQuantity(j_);
			bool? m_(Observation RespRate)
			{
				var aq_ = FHIRHelpers_4_3_000.ToValue(RespRate?.Effective);
				var ar_ = QICoreCommon_2_0_000.earliest(aq_);
				var as_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var at_ = context.Operators.Start(as_);
				var au_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var av_ = context.Operators.Subtract(at_, au_);
				var ax_ = context.Operators.Start(as_);
				var ay_ = context.Operators.Quantity((decimal?)120m, "minutes");
				var az_ = context.Operators.Add(ax_, ay_);
				var ba_ = context.Operators.Interval(av_, az_, (bool?)true, (bool?)true);
				var bb_ = context.Operators.ElementInInterval<CqlDateTime>(ar_, ba_, null);
				var bc_ = context.Operators.Convert<string>(RespRate?.StatusElement?.Value);
				var bd_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var be_ = context.Operators.InList<string>(bc_, (bd_ as IEnumerable<string>));
				var bf_ = context.Operators.And(bb_, be_);
				var bg_ = context.Operators.Convert<Quantity>(RespRate?.Value);
				var bh_ = FHIRHelpers_4_3_000.ToQuantity(bg_);
				var bi_ = context.Operators.Not((bool?)(bh_ is null));
				var bj_ = context.Operators.And(bf_, bi_);

				return bj_;
			};
			var n_ = context.Operators.WhereOrNull<Observation>(d_, m_);
			object o_(Observation @this)
			{
				var bk_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bl_ = QICoreCommon_2_0_000.earliest(bk_);

				return bl_;
			};
			var p_ = context.Operators.ListSortBy<Observation>(n_, o_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = context.Operators.FirstOfList<Observation>(p_);
			var r_ = FHIRHelpers_4_3_000.ToValue(q_?.Effective);
			var s_ = QICoreCommon_2_0_000.earliest(r_);
			var t_ = new Tuple_EAccDaIgTNOHbEQUMLJiXWIJO
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstRespRateResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_EAccDaIgTNOHbEQUMLJiXWIJO>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Respiratory Rate")]
	public IEnumerable<Tuple_EAccDaIgTNOHbEQUMLJiXWIJO> Encounter_with_First_Respiratory_Rate() => 
		__Encounter_with_First_Respiratory_Rate.Value;

	private IEnumerable<Observation> Blood_Pressure_Reading_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		bool? b_(Observation BloodPressure)
		{
			var d_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
			var e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var f_ = context.Operators.InList<string>(d_, (e_ as IEnumerable<string>));

			return f_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Blood Pressure Reading")]
	public IEnumerable<Observation> Blood_Pressure_Reading() => 
		__Blood_Pressure_Reading.Value;

	private IEnumerable<string> Encounter_with_First_Systolic_Blood_Pressure_Value()
	{
		var a_ = this.Inpatient_Encounters();
		string b_(Encounter EncounterInpatient) => 
			EncounterInpatient?.IdElement?.Value;
		var c_ = context.Operators.SelectOrNull<Encounter, string>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Systolic Blood Pressure")]
	public IEnumerable<string> Encounter_with_First_Systolic_Blood_Pressure() => 
		__Encounter_with_First_Systolic_Blood_Pressure.Value;

	private IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Bicarbonate_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BXadXcWUgfMHAjQNVhdOPQXSG b_(Encounter EncounterInpatient)
		{
			var d_ = this.Bicarbonate_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation bicarbonatelab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(bicarbonatelab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(bicarbonatelab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(bicarbonatelab?.Value);
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
			bool? n_(Observation bicarbonatelab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(bicarbonatelab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, (bool?)true, (bool?)true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(bicarbonatelab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(bicarbonatelab?.Value);
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
			var t_ = new Tuple_BXadXcWUgfMHAjQNVhdOPQXSG
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Bicarbonate Lab Test")]
	public IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Bicarbonate_Lab_Test() => 
		__Encounter_with_First_Bicarbonate_Lab_Test.Value;

	private IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Creatinine_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BXadXcWUgfMHAjQNVhdOPQXSG b_(Encounter EncounterInpatient)
		{
			var d_ = this.Creatinine_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation CreatinineLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(CreatinineLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
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
				var at_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, (bool?)true, (bool?)true);
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
			var t_ = new Tuple_BXadXcWUgfMHAjQNVhdOPQXSG
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Creatinine Lab Test")]
	public IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Creatinine_Lab_Test() => 
		__Encounter_with_First_Creatinine_Lab_Test.Value;

	private IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Glucose_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BXadXcWUgfMHAjQNVhdOPQXSG b_(Encounter EncounterInpatient)
		{
			var d_ = this.Glucose_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation GlucoseLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(GlucoseLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(GlucoseLab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(GlucoseLab?.Value);
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
			bool? n_(Observation GlucoseLab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(GlucoseLab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, (bool?)true, (bool?)true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(GlucoseLab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(GlucoseLab?.Value);
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
			var t_ = new Tuple_BXadXcWUgfMHAjQNVhdOPQXSG
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Glucose Lab Test")]
	public IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Glucose_Lab_Test() => 
		__Encounter_with_First_Glucose_Lab_Test.Value;

	private IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Hematocrit_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BXadXcWUgfMHAjQNVhdOPQXSG b_(Encounter EncounterInpatient)
		{
			var d_ = this.Hematocrit_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation HematocritLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(HematocritLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
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
				var at_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, (bool?)true, (bool?)true);
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
			var t_ = new Tuple_BXadXcWUgfMHAjQNVhdOPQXSG
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Hematocrit Lab Test")]
	public IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Hematocrit_Lab_Test() => 
		__Encounter_with_First_Hematocrit_Lab_Test.Value;

	private IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Potassium_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BXadXcWUgfMHAjQNVhdOPQXSG b_(Encounter EncounterInpatient)
		{
			var d_ = this.Potassium_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation PotassiumLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(PotassiumLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
				var af_ = context.Operators.ElementInInterval<CqlDateTime>(v_, ae_, null);
				var ag_ = context.Operators.Convert<string>(PotassiumLab?.StatusElement?.Value);
				var ah_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ai_ = context.Operators.InList<string>(ag_, (ah_ as IEnumerable<string>));
				var aj_ = context.Operators.And(af_, ai_);
				var ak_ = FHIRHelpers_4_3_000.ToValue(PotassiumLab?.Value);
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
			bool? n_(Observation PotassiumLab)
			{
				var ap_ = context.Operators.Convert<CqlDateTime>(PotassiumLab?.IssuedElement?.Value);
				var aq_ = QICoreCommon_2_0_000.earliest((ap_ as object));
				var ar_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, (bool?)true, (bool?)true);
				var ba_ = context.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
				var bb_ = context.Operators.Convert<string>(PotassiumLab?.StatusElement?.Value);
				var bc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bd_ = context.Operators.InList<string>(bb_, (bc_ as IEnumerable<string>));
				var be_ = context.Operators.And(ba_, bd_);
				var bf_ = FHIRHelpers_4_3_000.ToValue(PotassiumLab?.Value);
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
			var t_ = new Tuple_BXadXcWUgfMHAjQNVhdOPQXSG
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Potassium Lab Test")]
	public IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Potassium_Lab_Test() => 
		__Encounter_with_First_Potassium_Lab_Test.Value;

	private IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Sodium_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BXadXcWUgfMHAjQNVhdOPQXSG b_(Encounter EncounterInpatient)
		{
			var d_ = this.Sodium_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation SodiumLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(SodiumLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
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
				var at_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, (bool?)true, (bool?)true);
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
			var t_ = new Tuple_BXadXcWUgfMHAjQNVhdOPQXSG
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Sodium Lab Test")]
	public IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Sodium_Lab_Test() => 
		__Encounter_with_First_Sodium_Lab_Test.Value;

	private IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_White_Blood_Cells_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BXadXcWUgfMHAjQNVhdOPQXSG b_(Encounter EncounterInpatient)
		{
			var d_ = this.White_blood_cells_count_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation WhiteBloodCellLab)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(WhiteBloodCellLab?.IssuedElement?.Value);
				var v_ = QICoreCommon_2_0_000.earliest((u_ as object));
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterInpatient?.Period);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var z_ = context.Operators.Subtract(x_, y_);
				var ab_ = context.Operators.Start(w_);
				var ad_ = context.Operators.Add(ab_, y_);
				var ae_ = context.Operators.Interval(z_, ad_, (bool?)true, (bool?)true);
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
				var at_ = context.Operators.Quantity((decimal?)1440m, "minutes");
				var au_ = context.Operators.Subtract(as_, at_);
				var aw_ = context.Operators.Start(ar_);
				var ay_ = context.Operators.Add(aw_, at_);
				var az_ = context.Operators.Interval(au_, ay_, (bool?)true, (bool?)true);
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
			var t_ = new Tuple_BXadXcWUgfMHAjQNVhdOPQXSG
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First White Blood Cells Lab Test")]
	public IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_White_Blood_Cells_Lab_Test() => 
		__Encounter_with_First_White_Blood_Cells_Lab_Test.Value;

	private IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Weight_Recorded_During_Stay_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_BXadXcWUgfMHAjQNVhdOPQXSG b_(Encounter EncounterInpatient)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation WeightExam)
			{
				var u_ = FHIRHelpers_4_3_000.ToValue(WeightExam?.Effective);
				var v_ = QICoreCommon_2_0_000.earliest(u_);
				var w_ = CQMCommon_2_0_000.hospitalizationWithObservationAndOutpatientSurgeryService(EncounterInpatient);
				var x_ = context.Operators.ElementInInterval<CqlDateTime>(v_, w_, null);
				var y_ = context.Operators.Convert<string>(WeightExam?.StatusElement?.Value);
				var z_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var aa_ = context.Operators.InList<string>(y_, (z_ as IEnumerable<string>));
				var ab_ = context.Operators.And(x_, aa_);
				var ac_ = context.Operators.Convert<Quantity>(WeightExam?.Value);
				var ad_ = FHIRHelpers_4_3_000.ToQuantity(ac_);
				var ae_ = context.Operators.Not((bool?)(ad_ is null));
				var af_ = context.Operators.And(ab_, ae_);

				return af_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var ag_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ah_ = QICoreCommon_2_0_000.earliest(ag_);

				return ah_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.FirstOfList<Observation>(h_);
			var j_ = context.Operators.Convert<Quantity>(i_?.Value);
			var k_ = FHIRHelpers_4_3_000.ToQuantity(j_);
			bool? m_(Observation WeightExam)
			{
				var ai_ = FHIRHelpers_4_3_000.ToValue(WeightExam?.Effective);
				var aj_ = QICoreCommon_2_0_000.earliest(ai_);
				var ak_ = CQMCommon_2_0_000.hospitalizationWithObservationAndOutpatientSurgeryService(EncounterInpatient);
				var al_ = context.Operators.ElementInInterval<CqlDateTime>(aj_, ak_, null);
				var am_ = context.Operators.Convert<string>(WeightExam?.StatusElement?.Value);
				var an_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ao_ = context.Operators.InList<string>(am_, (an_ as IEnumerable<string>));
				var ap_ = context.Operators.And(al_, ao_);
				var aq_ = context.Operators.Convert<Quantity>(WeightExam?.Value);
				var ar_ = FHIRHelpers_4_3_000.ToQuantity(aq_);
				var as_ = context.Operators.Not((bool?)(ar_ is null));
				var at_ = context.Operators.And(ap_, as_);

				return at_;
			};
			var n_ = context.Operators.WhereOrNull<Observation>(d_, m_);
			object o_(Observation @this)
			{
				var au_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var av_ = QICoreCommon_2_0_000.earliest(au_);

				return av_;
			};
			var p_ = context.Operators.ListSortBy<Observation>(n_, o_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = context.Operators.FirstOfList<Observation>(p_);
			var r_ = FHIRHelpers_4_3_000.ToValue(q_?.Effective);
			var s_ = QICoreCommon_2_0_000.earliest(r_);
			var t_ = new Tuple_BXadXcWUgfMHAjQNVhdOPQXSG
			{
				EncounterId = EncounterInpatient?.IdElement?.Value,
				FirstResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, Tuple_BXadXcWUgfMHAjQNVhdOPQXSG>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Weight Recorded During Stay")]
	public IEnumerable<Tuple_BXadXcWUgfMHAjQNVhdOPQXSG> Encounter_with_First_Weight_Recorded_During_Stay() => 
		__Encounter_with_First_Weight_Recorded_During_Stay.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
