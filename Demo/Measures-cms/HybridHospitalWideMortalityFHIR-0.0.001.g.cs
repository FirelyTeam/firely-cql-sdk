using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
    internal Lazy<IEnumerable<Tuple_GIbILVAdXLLNYBgcQIEiUiKaK>> __Encounter_with_First_Body_Temperature;
    internal Lazy<IEnumerable<Tuple_DhbJAfCiKIAGYKTjJXYGSKECQ>> __Encounter_with_First_Heart_Rate;
    internal Lazy<IEnumerable<Tuple_FdREYEdHOZIcMCNYCRFJYJReA>> __Encounter_with_First_Oxygen_Saturation;
    internal Lazy<IEnumerable<Observation>> __Blood_Pressure_Reading;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_First_Systolic_Blood_Pressure;
    internal Lazy<IEnumerable<Tuple_GbUHPXXHScejjXWhcHJFQQifQ>> __Encounter_with_First_Bicarbonate_Lab_Test;
    internal Lazy<IEnumerable<Tuple_FETECNQPQREfGRgPYWhOWgeWA>> __Encounter_with_First_Creatinine_Lab_Test;
    internal Lazy<IEnumerable<Tuple_DIHdhbAJeJTdiAVUAELUHRNdS>> __Encounter_with_First_Hematocrit_Lab_Test;
    internal Lazy<IEnumerable<Tuple_DAUcYHQZcDKbIfORJOEZBDgIh>> __Encounter_with_First_Platelet_Lab_Test;
    internal Lazy<IEnumerable<Tuple_GKGeLARADLGJcNcZaDhdCREMa>> __Encounter_with_First_Sodium_Lab_Test;
    internal Lazy<IEnumerable<Tuple_ChVYCdXDGgVcFTCCUefXMbCHX>> __Encounter_with_First_White_Blood_Cells_Lab_Test;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __Encounter_with_First_Body_Temperature = new Lazy<IEnumerable<Tuple_GIbILVAdXLLNYBgcQIEiUiKaK>>(this.Encounter_with_First_Body_Temperature_Value);
        __Encounter_with_First_Heart_Rate = new Lazy<IEnumerable<Tuple_DhbJAfCiKIAGYKTjJXYGSKECQ>>(this.Encounter_with_First_Heart_Rate_Value);
        __Encounter_with_First_Oxygen_Saturation = new Lazy<IEnumerable<Tuple_FdREYEdHOZIcMCNYCRFJYJReA>>(this.Encounter_with_First_Oxygen_Saturation_Value);
        __Blood_Pressure_Reading = new Lazy<IEnumerable<Observation>>(this.Blood_Pressure_Reading_Value);
        __Encounter_with_First_Systolic_Blood_Pressure = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_First_Systolic_Blood_Pressure_Value);
        __Encounter_with_First_Bicarbonate_Lab_Test = new Lazy<IEnumerable<Tuple_GbUHPXXHScejjXWhcHJFQQifQ>>(this.Encounter_with_First_Bicarbonate_Lab_Test_Value);
        __Encounter_with_First_Creatinine_Lab_Test = new Lazy<IEnumerable<Tuple_FETECNQPQREfGRgPYWhOWgeWA>>(this.Encounter_with_First_Creatinine_Lab_Test_Value);
        __Encounter_with_First_Hematocrit_Lab_Test = new Lazy<IEnumerable<Tuple_DIHdhbAJeJTdiAVUAELUHRNdS>>(this.Encounter_with_First_Hematocrit_Lab_Test_Value);
        __Encounter_with_First_Platelet_Lab_Test = new Lazy<IEnumerable<Tuple_DAUcYHQZcDKbIfORJOEZBDgIh>>(this.Encounter_with_First_Platelet_Lab_Test_Value);
        __Encounter_with_First_Sodium_Lab_Test = new Lazy<IEnumerable<Tuple_GKGeLARADLGJcNcZaDhdCREMa>>(this.Encounter_with_First_Sodium_Lab_Test_Value);
        __Encounter_with_First_White_Blood_Cells_Lab_Test = new Lazy<IEnumerable<Tuple_ChVYCdXDGgVcFTCCUefXMbCHX>>(this.Encounter_with_First_White_Blood_Cells_Lab_Test_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", c_);

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
				var p_ = context.Operators.Less(o_, 365);
				var q_ = InpatientEncounter?.StatusElement;
				var r_ = q_?.Value;
				var s_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(r_);
				var t_ = context.Operators.Equal(s_, "finished");
				var u_ = context.Operators.And(p_, t_);
				var v_ = this.Patient();
				var w_ = v_?.BirthDateElement;
				var x_ = w_?.Value;
				var y_ = context.Operators.Convert<CqlDate>(x_);
				var z_ = InpatientEncounter?.Period;
				var aa_ = FHIRHelpers_4_3_000.ToInterval(z_);
				var ab_ = context.Operators.Start(aa_);
				var ac_ = context.Operators.DateFrom(ab_);
				var ad_ = context.Operators.CalculateAgeAt(y_, ac_, "year");
				var ae_ = context.Operators.Interval(65, 94, true, true);
				var af_ = context.Operators.In<int?>(ad_, ae_, null);
				var ag_ = context.Operators.And(u_, af_);
				var ai_ = FHIRHelpers_4_3_000.ToInterval(z_);
				var aj_ = context.Operators.End(ai_);
				var ak_ = this.Measurement_Period();
				var al_ = context.Operators.In<CqlDateTime>(aj_, ak_, "day");
				var am_ = context.Operators.And(ag_, al_);

				return am_;
			};
			var k_ = context.Operators.Where<Coverage>(i_, j_);
			Encounter l_(Coverage MedicarePayer) => 
				InpatientEncounter;
			var m_ = context.Operators.Select<Coverage, Encounter>(k_, l_);

			return m_;
		};
		var d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

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

	private IEnumerable<Tuple_GIbILVAdXLLNYBgcQIEiUiKaK> Encounter_with_First_Body_Temperature_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_GIbILVAdXLLNYBgcQIEiUiKaK b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? g_(Observation temperature)
			{
				var y_ = temperature?.Effective;
				var z_ = FHIRHelpers_4_3_000.ToValue(y_);
				var aa_ = QICoreCommon_2_0_000.earliest(z_);
				var ab_ = EncounterInpatient?.Period;
				var ac_ = FHIRHelpers_4_3_000.ToInterval(ab_);
				var ad_ = context.Operators.Start(ac_);
				var ae_ = context.Operators.Quantity(1440m, "minutes");
				var af_ = context.Operators.Subtract(ad_, ae_);
				var ah_ = FHIRHelpers_4_3_000.ToInterval(ab_);
				var ai_ = context.Operators.Start(ah_);
				var aj_ = context.Operators.Quantity(120m, "minutes");
				var ak_ = context.Operators.Add(ai_, aj_);
				var al_ = context.Operators.Interval(af_, ak_, true, true);
				var am_ = context.Operators.In<CqlDateTime>(aa_, al_, null);
				var an_ = temperature?.StatusElement;
				var ao_ = an_?.Value;
				var ap_ = context.Operators.Convert<string>(ao_);
				var aq_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ar_ = context.Operators.In<string>(ap_, (aq_ as IEnumerable<string>));
				var as_ = context.Operators.And(am_, ar_);
				var at_ = temperature?.Value;
				var au_ = context.Operators.Convert<Quantity>(at_);
				var av_ = FHIRHelpers_4_3_000.ToQuantity(au_);
				var aw_ = context.Operators.Not((bool?)(av_ is null));
				var ax_ = context.Operators.And(as_, aw_);

				return ax_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				var ay_ = @this?.Effective;
				var az_ = FHIRHelpers_4_3_000.ToValue(ay_);
				var ba_ = QICoreCommon_2_0_000.earliest(az_);

				return ba_;
			};
			var j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.First<Observation>(j_);
			var l_ = k_?.Value;
			var m_ = context.Operators.Convert<Quantity>(l_);
			var n_ = FHIRHelpers_4_3_000.ToQuantity(m_);
			bool? p_(Observation temperature)
			{
				var bb_ = temperature?.Effective;
				var bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
				var bd_ = QICoreCommon_2_0_000.earliest(bc_);
				var be_ = EncounterInpatient?.Period;
				var bf_ = FHIRHelpers_4_3_000.ToInterval(be_);
				var bg_ = context.Operators.Start(bf_);
				var bh_ = context.Operators.Quantity(1440m, "minutes");
				var bi_ = context.Operators.Subtract(bg_, bh_);
				var bk_ = FHIRHelpers_4_3_000.ToInterval(be_);
				var bl_ = context.Operators.Start(bk_);
				var bm_ = context.Operators.Quantity(120m, "minutes");
				var bn_ = context.Operators.Add(bl_, bm_);
				var bo_ = context.Operators.Interval(bi_, bn_, true, true);
				var bp_ = context.Operators.In<CqlDateTime>(bd_, bo_, null);
				var bq_ = temperature?.StatusElement;
				var br_ = bq_?.Value;
				var bs_ = context.Operators.Convert<string>(br_);
				var bt_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bu_ = context.Operators.In<string>(bs_, (bt_ as IEnumerable<string>));
				var bv_ = context.Operators.And(bp_, bu_);
				var bw_ = temperature?.Value;
				var bx_ = context.Operators.Convert<Quantity>(bw_);
				var by_ = FHIRHelpers_4_3_000.ToQuantity(bx_);
				var bz_ = context.Operators.Not((bool?)(by_ is null));
				var ca_ = context.Operators.And(bv_, bz_);

				return ca_;
			};
			var q_ = context.Operators.Where<Observation>(f_, p_);
			object r_(Observation @this)
			{
				var cb_ = @this?.Effective;
				var cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
				var cd_ = QICoreCommon_2_0_000.earliest(cc_);

				return cd_;
			};
			var s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.First<Observation>(s_);
			var u_ = t_?.Effective;
			var v_ = FHIRHelpers_4_3_000.ToValue(u_);
			var w_ = QICoreCommon_2_0_000.earliest(v_);
			var x_ = new Tuple_GIbILVAdXLLNYBgcQIEiUiKaK
			{
				EncounterId = e_,
				FirstTemperatureResult = n_,
				Timing = w_,
			};

			return x_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_GIbILVAdXLLNYBgcQIEiUiKaK>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Body Temperature")]
	public IEnumerable<Tuple_GIbILVAdXLLNYBgcQIEiUiKaK> Encounter_with_First_Body_Temperature() => 
		__Encounter_with_First_Body_Temperature.Value;

	private IEnumerable<Tuple_DhbJAfCiKIAGYKTjJXYGSKECQ> Encounter_with_First_Heart_Rate_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_DhbJAfCiKIAGYKTjJXYGSKECQ b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? g_(Observation HeartRate)
			{
				var y_ = HeartRate?.Effective;
				var z_ = FHIRHelpers_4_3_000.ToValue(y_);
				var aa_ = QICoreCommon_2_0_000.earliest(z_);
				var ab_ = EncounterInpatient?.Period;
				var ac_ = FHIRHelpers_4_3_000.ToInterval(ab_);
				var ad_ = context.Operators.Start(ac_);
				var ae_ = context.Operators.Quantity(1440m, "minutes");
				var af_ = context.Operators.Subtract(ad_, ae_);
				var ah_ = FHIRHelpers_4_3_000.ToInterval(ab_);
				var ai_ = context.Operators.Start(ah_);
				var aj_ = context.Operators.Quantity(120m, "minutes");
				var ak_ = context.Operators.Add(ai_, aj_);
				var al_ = context.Operators.Interval(af_, ak_, true, true);
				var am_ = context.Operators.In<CqlDateTime>(aa_, al_, null);
				var an_ = HeartRate?.StatusElement;
				var ao_ = an_?.Value;
				var ap_ = context.Operators.Convert<string>(ao_);
				var aq_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ar_ = context.Operators.In<string>(ap_, (aq_ as IEnumerable<string>));
				var as_ = context.Operators.And(am_, ar_);
				var at_ = HeartRate?.Value;
				var au_ = context.Operators.Convert<Quantity>(at_);
				var av_ = FHIRHelpers_4_3_000.ToQuantity(au_);
				var aw_ = context.Operators.Not((bool?)(av_ is null));
				var ax_ = context.Operators.And(as_, aw_);

				return ax_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				var ay_ = @this?.Effective;
				var az_ = FHIRHelpers_4_3_000.ToValue(ay_);
				var ba_ = QICoreCommon_2_0_000.earliest(az_);

				return ba_;
			};
			var j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.First<Observation>(j_);
			var l_ = k_?.Value;
			var m_ = context.Operators.Convert<Quantity>(l_);
			var n_ = FHIRHelpers_4_3_000.ToQuantity(m_);
			bool? p_(Observation HeartRate)
			{
				var bb_ = HeartRate?.Effective;
				var bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
				var bd_ = QICoreCommon_2_0_000.earliest(bc_);
				var be_ = EncounterInpatient?.Period;
				var bf_ = FHIRHelpers_4_3_000.ToInterval(be_);
				var bg_ = context.Operators.Start(bf_);
				var bh_ = context.Operators.Quantity(1440m, "minutes");
				var bi_ = context.Operators.Subtract(bg_, bh_);
				var bk_ = FHIRHelpers_4_3_000.ToInterval(be_);
				var bl_ = context.Operators.Start(bk_);
				var bm_ = context.Operators.Quantity(120m, "minutes");
				var bn_ = context.Operators.Add(bl_, bm_);
				var bo_ = context.Operators.Interval(bi_, bn_, true, true);
				var bp_ = context.Operators.In<CqlDateTime>(bd_, bo_, null);
				var bq_ = HeartRate?.StatusElement;
				var br_ = bq_?.Value;
				var bs_ = context.Operators.Convert<string>(br_);
				var bt_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bu_ = context.Operators.In<string>(bs_, (bt_ as IEnumerable<string>));
				var bv_ = context.Operators.And(bp_, bu_);
				var bw_ = HeartRate?.Value;
				var bx_ = context.Operators.Convert<Quantity>(bw_);
				var by_ = FHIRHelpers_4_3_000.ToQuantity(bx_);
				var bz_ = context.Operators.Not((bool?)(by_ is null));
				var ca_ = context.Operators.And(bv_, bz_);

				return ca_;
			};
			var q_ = context.Operators.Where<Observation>(f_, p_);
			object r_(Observation @this)
			{
				var cb_ = @this?.Effective;
				var cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
				var cd_ = QICoreCommon_2_0_000.earliest(cc_);

				return cd_;
			};
			var s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.First<Observation>(s_);
			var u_ = t_?.Effective;
			var v_ = FHIRHelpers_4_3_000.ToValue(u_);
			var w_ = QICoreCommon_2_0_000.earliest(v_);
			var x_ = new Tuple_DhbJAfCiKIAGYKTjJXYGSKECQ
			{
				EncounterId = e_,
				FirstHeartRateResult = n_,
				Timing = w_,
			};

			return x_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_DhbJAfCiKIAGYKTjJXYGSKECQ>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Heart Rate")]
	public IEnumerable<Tuple_DhbJAfCiKIAGYKTjJXYGSKECQ> Encounter_with_First_Heart_Rate() => 
		__Encounter_with_First_Heart_Rate.Value;

	private IEnumerable<Tuple_FdREYEdHOZIcMCNYCRFJYJReA> Encounter_with_First_Oxygen_Saturation_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_FdREYEdHOZIcMCNYCRFJYJReA b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation O2Saturation)
			{
				object r_()
				{
					bool aq_()
					{
						var at_ = O2Saturation?.Effective;
						var au_ = FHIRHelpers_4_3_000.ToValue(at_);
						var av_ = au_ is CqlDateTime;

						return av_;
					};
					bool ar_()
					{
						var aw_ = O2Saturation?.Effective;
						var ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
						var ay_ = ax_ is CqlInterval<CqlDateTime>;

						return ay_;
					};
					bool as_()
					{
						var az_ = O2Saturation?.Effective;
						var ba_ = FHIRHelpers_4_3_000.ToValue(az_);
						var bb_ = ba_ is CqlDateTime;

						return bb_;
					};
					if (aq_())
					{
						var bc_ = O2Saturation?.Effective;
						var bd_ = FHIRHelpers_4_3_000.ToValue(bc_);

						return ((bd_ as CqlDateTime) as object);
					}
					else if (ar_())
					{
						var be_ = O2Saturation?.Effective;
						var bf_ = FHIRHelpers_4_3_000.ToValue(be_);

						return ((bf_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (as_())
					{
						var bg_ = O2Saturation?.Effective;
						var bh_ = FHIRHelpers_4_3_000.ToValue(bg_);

						return ((bh_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var s_ = QICoreCommon_2_0_000.earliest(r_());
				var t_ = EncounterInpatient?.Period;
				var u_ = FHIRHelpers_4_3_000.ToInterval(t_);
				var v_ = context.Operators.Start(u_);
				var w_ = context.Operators.Quantity(1440m, "minutes");
				var x_ = context.Operators.Subtract(v_, w_);
				var z_ = FHIRHelpers_4_3_000.ToInterval(t_);
				var aa_ = context.Operators.Start(z_);
				var ab_ = context.Operators.Quantity(120m, "minutes");
				var ac_ = context.Operators.Add(aa_, ab_);
				var ad_ = context.Operators.Interval(x_, ac_, true, true);
				var ae_ = context.Operators.In<CqlDateTime>(s_, ad_, null);
				var af_ = O2Saturation?.StatusElement;
				var ag_ = af_?.Value;
				var ah_ = context.Operators.Convert<Code<ObservationStatus>>(ag_);
				var ai_ = context.Operators.Convert<string>(ah_);
				var aj_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ak_ = context.Operators.In<string>(ai_, (aj_ as IEnumerable<string>));
				var al_ = context.Operators.And(ae_, ak_);
				var am_ = O2Saturation?.Value;
				var an_ = FHIRHelpers_4_3_000.ToValue(am_);
				var ao_ = context.Operators.Not((bool?)(an_ is null));
				var ap_ = context.Operators.And(al_, ao_);

				return ap_;
			};
			var i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				object bi_()
				{
					bool bk_()
					{
						var bn_ = @this?.Effective;
						var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
						var bp_ = bo_ is CqlDateTime;

						return bp_;
					};
					bool bl_()
					{
						var bq_ = @this?.Effective;
						var br_ = FHIRHelpers_4_3_000.ToValue(bq_);
						var bs_ = br_ is CqlInterval<CqlDateTime>;

						return bs_;
					};
					bool bm_()
					{
						var bt_ = @this?.Effective;
						var bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
						var bv_ = bu_ is CqlDateTime;

						return bv_;
					};
					if (bk_())
					{
						var bw_ = @this?.Effective;
						var bx_ = FHIRHelpers_4_3_000.ToValue(bw_);

						return ((bx_ as CqlDateTime) as object);
					}
					else if (bl_())
					{
						var by_ = @this?.Effective;
						var bz_ = FHIRHelpers_4_3_000.ToValue(by_);

						return ((bz_ as CqlInterval<CqlDateTime>) as object);
					}
					else if (bm_())
					{
						var ca_ = @this?.Effective;
						var cb_ = FHIRHelpers_4_3_000.ToValue(ca_);

						return ((cb_ as CqlDateTime) as object);
					}
					else
					{
						return null;
					};
				};
				var bj_ = QICoreCommon_2_0_000.earliest(bi_());

				return bj_;
			};
			var k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			var l_ = context.Operators.First<Observation>(k_);
			var m_ = l_?.Value;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			object o_()
			{
				bool cc_()
				{
					var cf_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var cg_ = context.Operators.RetrieveByValueSet<Observation>(cf_, null);
					bool? ch_(Observation O2Saturation)
					{
						object cp_()
						{
							bool do_()
							{
								var dr_ = O2Saturation?.Effective;
								var ds_ = FHIRHelpers_4_3_000.ToValue(dr_);
								var dt_ = ds_ is CqlDateTime;

								return dt_;
							};
							bool dp_()
							{
								var du_ = O2Saturation?.Effective;
								var dv_ = FHIRHelpers_4_3_000.ToValue(du_);
								var dw_ = dv_ is CqlInterval<CqlDateTime>;

								return dw_;
							};
							bool dq_()
							{
								var dx_ = O2Saturation?.Effective;
								var dy_ = FHIRHelpers_4_3_000.ToValue(dx_);
								var dz_ = dy_ is CqlDateTime;

								return dz_;
							};
							if (do_())
							{
								var ea_ = O2Saturation?.Effective;
								var eb_ = FHIRHelpers_4_3_000.ToValue(ea_);

								return ((eb_ as CqlDateTime) as object);
							}
							else if (dp_())
							{
								var ec_ = O2Saturation?.Effective;
								var ed_ = FHIRHelpers_4_3_000.ToValue(ec_);

								return ((ed_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (dq_())
							{
								var ee_ = O2Saturation?.Effective;
								var ef_ = FHIRHelpers_4_3_000.ToValue(ee_);

								return ((ef_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var cq_ = QICoreCommon_2_0_000.earliest(cp_());
						var cr_ = EncounterInpatient?.Period;
						var cs_ = FHIRHelpers_4_3_000.ToInterval(cr_);
						var ct_ = context.Operators.Start(cs_);
						var cu_ = context.Operators.Quantity(1440m, "minutes");
						var cv_ = context.Operators.Subtract(ct_, cu_);
						var cx_ = FHIRHelpers_4_3_000.ToInterval(cr_);
						var cy_ = context.Operators.Start(cx_);
						var cz_ = context.Operators.Quantity(120m, "minutes");
						var da_ = context.Operators.Add(cy_, cz_);
						var db_ = context.Operators.Interval(cv_, da_, true, true);
						var dc_ = context.Operators.In<CqlDateTime>(cq_, db_, null);
						var dd_ = O2Saturation?.StatusElement;
						var de_ = dd_?.Value;
						var df_ = context.Operators.Convert<Code<ObservationStatus>>(de_);
						var dg_ = context.Operators.Convert<string>(df_);
						var dh_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var di_ = context.Operators.In<string>(dg_, (dh_ as IEnumerable<string>));
						var dj_ = context.Operators.And(dc_, di_);
						var dk_ = O2Saturation?.Value;
						var dl_ = FHIRHelpers_4_3_000.ToValue(dk_);
						var dm_ = context.Operators.Not((bool?)(dl_ is null));
						var dn_ = context.Operators.And(dj_, dm_);

						return dn_;
					};
					var ci_ = context.Operators.Where<Observation>(cg_, ch_);
					object cj_(Observation @this)
					{
						object eg_()
						{
							bool ei_()
							{
								var el_ = @this?.Effective;
								var em_ = FHIRHelpers_4_3_000.ToValue(el_);
								var en_ = em_ is CqlDateTime;

								return en_;
							};
							bool ej_()
							{
								var eo_ = @this?.Effective;
								var ep_ = FHIRHelpers_4_3_000.ToValue(eo_);
								var eq_ = ep_ is CqlInterval<CqlDateTime>;

								return eq_;
							};
							bool ek_()
							{
								var er_ = @this?.Effective;
								var es_ = FHIRHelpers_4_3_000.ToValue(er_);
								var et_ = es_ is CqlDateTime;

								return et_;
							};
							if (ei_())
							{
								var eu_ = @this?.Effective;
								var ev_ = FHIRHelpers_4_3_000.ToValue(eu_);

								return ((ev_ as CqlDateTime) as object);
							}
							else if (ej_())
							{
								var ew_ = @this?.Effective;
								var ex_ = FHIRHelpers_4_3_000.ToValue(ew_);

								return ((ex_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (ek_())
							{
								var ey_ = @this?.Effective;
								var ez_ = FHIRHelpers_4_3_000.ToValue(ey_);

								return ((ez_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var eh_ = QICoreCommon_2_0_000.earliest(eg_());

						return eh_;
					};
					var ck_ = context.Operators.SortBy<Observation>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);
					var cl_ = context.Operators.First<Observation>(ck_);
					var cm_ = cl_?.Effective;
					var cn_ = FHIRHelpers_4_3_000.ToValue(cm_);
					var co_ = cn_ is CqlDateTime;

					return co_;
				};
				bool cd_()
				{
					var fa_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var fb_ = context.Operators.RetrieveByValueSet<Observation>(fa_, null);
					bool? fc_(Observation O2Saturation)
					{
						object fk_()
						{
							bool gj_()
							{
								var gm_ = O2Saturation?.Effective;
								var gn_ = FHIRHelpers_4_3_000.ToValue(gm_);
								var go_ = gn_ is CqlDateTime;

								return go_;
							};
							bool gk_()
							{
								var gp_ = O2Saturation?.Effective;
								var gq_ = FHIRHelpers_4_3_000.ToValue(gp_);
								var gr_ = gq_ is CqlInterval<CqlDateTime>;

								return gr_;
							};
							bool gl_()
							{
								var gs_ = O2Saturation?.Effective;
								var gt_ = FHIRHelpers_4_3_000.ToValue(gs_);
								var gu_ = gt_ is CqlDateTime;

								return gu_;
							};
							if (gj_())
							{
								var gv_ = O2Saturation?.Effective;
								var gw_ = FHIRHelpers_4_3_000.ToValue(gv_);

								return ((gw_ as CqlDateTime) as object);
							}
							else if (gk_())
							{
								var gx_ = O2Saturation?.Effective;
								var gy_ = FHIRHelpers_4_3_000.ToValue(gx_);

								return ((gy_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (gl_())
							{
								var gz_ = O2Saturation?.Effective;
								var ha_ = FHIRHelpers_4_3_000.ToValue(gz_);

								return ((ha_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var fl_ = QICoreCommon_2_0_000.earliest(fk_());
						var fm_ = EncounterInpatient?.Period;
						var fn_ = FHIRHelpers_4_3_000.ToInterval(fm_);
						var fo_ = context.Operators.Start(fn_);
						var fp_ = context.Operators.Quantity(1440m, "minutes");
						var fq_ = context.Operators.Subtract(fo_, fp_);
						var fs_ = FHIRHelpers_4_3_000.ToInterval(fm_);
						var ft_ = context.Operators.Start(fs_);
						var fu_ = context.Operators.Quantity(120m, "minutes");
						var fv_ = context.Operators.Add(ft_, fu_);
						var fw_ = context.Operators.Interval(fq_, fv_, true, true);
						var fx_ = context.Operators.In<CqlDateTime>(fl_, fw_, null);
						var fy_ = O2Saturation?.StatusElement;
						var fz_ = fy_?.Value;
						var ga_ = context.Operators.Convert<Code<ObservationStatus>>(fz_);
						var gb_ = context.Operators.Convert<string>(ga_);
						var gc_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var gd_ = context.Operators.In<string>(gb_, (gc_ as IEnumerable<string>));
						var ge_ = context.Operators.And(fx_, gd_);
						var gf_ = O2Saturation?.Value;
						var gg_ = FHIRHelpers_4_3_000.ToValue(gf_);
						var gh_ = context.Operators.Not((bool?)(gg_ is null));
						var gi_ = context.Operators.And(ge_, gh_);

						return gi_;
					};
					var fd_ = context.Operators.Where<Observation>(fb_, fc_);
					object fe_(Observation @this)
					{
						object hb_()
						{
							bool hd_()
							{
								var hg_ = @this?.Effective;
								var hh_ = FHIRHelpers_4_3_000.ToValue(hg_);
								var hi_ = hh_ is CqlDateTime;

								return hi_;
							};
							bool he_()
							{
								var hj_ = @this?.Effective;
								var hk_ = FHIRHelpers_4_3_000.ToValue(hj_);
								var hl_ = hk_ is CqlInterval<CqlDateTime>;

								return hl_;
							};
							bool hf_()
							{
								var hm_ = @this?.Effective;
								var hn_ = FHIRHelpers_4_3_000.ToValue(hm_);
								var ho_ = hn_ is CqlDateTime;

								return ho_;
							};
							if (hd_())
							{
								var hp_ = @this?.Effective;
								var hq_ = FHIRHelpers_4_3_000.ToValue(hp_);

								return ((hq_ as CqlDateTime) as object);
							}
							else if (he_())
							{
								var hr_ = @this?.Effective;
								var hs_ = FHIRHelpers_4_3_000.ToValue(hr_);

								return ((hs_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (hf_())
							{
								var ht_ = @this?.Effective;
								var hu_ = FHIRHelpers_4_3_000.ToValue(ht_);

								return ((hu_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var hc_ = QICoreCommon_2_0_000.earliest(hb_());

						return hc_;
					};
					var ff_ = context.Operators.SortBy<Observation>(fd_, fe_, System.ComponentModel.ListSortDirection.Ascending);
					var fg_ = context.Operators.First<Observation>(ff_);
					var fh_ = fg_?.Effective;
					var fi_ = FHIRHelpers_4_3_000.ToValue(fh_);
					var fj_ = fi_ is CqlInterval<CqlDateTime>;

					return fj_;
				};
				bool ce_()
				{
					var hv_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var hw_ = context.Operators.RetrieveByValueSet<Observation>(hv_, null);
					bool? hx_(Observation O2Saturation)
					{
						object if_()
						{
							bool je_()
							{
								var jh_ = O2Saturation?.Effective;
								var ji_ = FHIRHelpers_4_3_000.ToValue(jh_);
								var jj_ = ji_ is CqlDateTime;

								return jj_;
							};
							bool jf_()
							{
								var jk_ = O2Saturation?.Effective;
								var jl_ = FHIRHelpers_4_3_000.ToValue(jk_);
								var jm_ = jl_ is CqlInterval<CqlDateTime>;

								return jm_;
							};
							bool jg_()
							{
								var jn_ = O2Saturation?.Effective;
								var jo_ = FHIRHelpers_4_3_000.ToValue(jn_);
								var jp_ = jo_ is CqlDateTime;

								return jp_;
							};
							if (je_())
							{
								var jq_ = O2Saturation?.Effective;
								var jr_ = FHIRHelpers_4_3_000.ToValue(jq_);

								return ((jr_ as CqlDateTime) as object);
							}
							else if (jf_())
							{
								var js_ = O2Saturation?.Effective;
								var jt_ = FHIRHelpers_4_3_000.ToValue(js_);

								return ((jt_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (jg_())
							{
								var ju_ = O2Saturation?.Effective;
								var jv_ = FHIRHelpers_4_3_000.ToValue(ju_);

								return ((jv_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var ig_ = QICoreCommon_2_0_000.earliest(if_());
						var ih_ = EncounterInpatient?.Period;
						var ii_ = FHIRHelpers_4_3_000.ToInterval(ih_);
						var ij_ = context.Operators.Start(ii_);
						var ik_ = context.Operators.Quantity(1440m, "minutes");
						var il_ = context.Operators.Subtract(ij_, ik_);
						var in_ = FHIRHelpers_4_3_000.ToInterval(ih_);
						var io_ = context.Operators.Start(in_);
						var ip_ = context.Operators.Quantity(120m, "minutes");
						var iq_ = context.Operators.Add(io_, ip_);
						var ir_ = context.Operators.Interval(il_, iq_, true, true);
						var is_ = context.Operators.In<CqlDateTime>(ig_, ir_, null);
						var it_ = O2Saturation?.StatusElement;
						var iu_ = it_?.Value;
						var iv_ = context.Operators.Convert<Code<ObservationStatus>>(iu_);
						var iw_ = context.Operators.Convert<string>(iv_);
						var ix_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var iy_ = context.Operators.In<string>(iw_, (ix_ as IEnumerable<string>));
						var iz_ = context.Operators.And(is_, iy_);
						var ja_ = O2Saturation?.Value;
						var jb_ = FHIRHelpers_4_3_000.ToValue(ja_);
						var jc_ = context.Operators.Not((bool?)(jb_ is null));
						var jd_ = context.Operators.And(iz_, jc_);

						return jd_;
					};
					var hy_ = context.Operators.Where<Observation>(hw_, hx_);
					object hz_(Observation @this)
					{
						object jw_()
						{
							bool jy_()
							{
								var kb_ = @this?.Effective;
								var kc_ = FHIRHelpers_4_3_000.ToValue(kb_);
								var kd_ = kc_ is CqlDateTime;

								return kd_;
							};
							bool jz_()
							{
								var ke_ = @this?.Effective;
								var kf_ = FHIRHelpers_4_3_000.ToValue(ke_);
								var kg_ = kf_ is CqlInterval<CqlDateTime>;

								return kg_;
							};
							bool ka_()
							{
								var kh_ = @this?.Effective;
								var ki_ = FHIRHelpers_4_3_000.ToValue(kh_);
								var kj_ = ki_ is CqlDateTime;

								return kj_;
							};
							if (jy_())
							{
								var kk_ = @this?.Effective;
								var kl_ = FHIRHelpers_4_3_000.ToValue(kk_);

								return ((kl_ as CqlDateTime) as object);
							}
							else if (jz_())
							{
								var km_ = @this?.Effective;
								var kn_ = FHIRHelpers_4_3_000.ToValue(km_);

								return ((kn_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (ka_())
							{
								var ko_ = @this?.Effective;
								var kp_ = FHIRHelpers_4_3_000.ToValue(ko_);

								return ((kp_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var jx_ = QICoreCommon_2_0_000.earliest(jw_());

						return jx_;
					};
					var ia_ = context.Operators.SortBy<Observation>(hy_, hz_, System.ComponentModel.ListSortDirection.Ascending);
					var ib_ = context.Operators.First<Observation>(ia_);
					var ic_ = ib_?.Effective;
					var id_ = FHIRHelpers_4_3_000.ToValue(ic_);
					var ie_ = id_ is CqlDateTime;

					return ie_;
				};
				if (cc_())
				{
					var kq_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var kr_ = context.Operators.RetrieveByValueSet<Observation>(kq_, null);
					bool? ks_(Observation O2Saturation)
					{
						object kz_()
						{
							bool ly_()
							{
								var mb_ = O2Saturation?.Effective;
								var mc_ = FHIRHelpers_4_3_000.ToValue(mb_);
								var md_ = mc_ is CqlDateTime;

								return md_;
							};
							bool lz_()
							{
								var me_ = O2Saturation?.Effective;
								var mf_ = FHIRHelpers_4_3_000.ToValue(me_);
								var mg_ = mf_ is CqlInterval<CqlDateTime>;

								return mg_;
							};
							bool ma_()
							{
								var mh_ = O2Saturation?.Effective;
								var mi_ = FHIRHelpers_4_3_000.ToValue(mh_);
								var mj_ = mi_ is CqlDateTime;

								return mj_;
							};
							if (ly_())
							{
								var mk_ = O2Saturation?.Effective;
								var ml_ = FHIRHelpers_4_3_000.ToValue(mk_);

								return ((ml_ as CqlDateTime) as object);
							}
							else if (lz_())
							{
								var mm_ = O2Saturation?.Effective;
								var mn_ = FHIRHelpers_4_3_000.ToValue(mm_);

								return ((mn_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (ma_())
							{
								var mo_ = O2Saturation?.Effective;
								var mp_ = FHIRHelpers_4_3_000.ToValue(mo_);

								return ((mp_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var la_ = QICoreCommon_2_0_000.earliest(kz_());
						var lb_ = EncounterInpatient?.Period;
						var lc_ = FHIRHelpers_4_3_000.ToInterval(lb_);
						var ld_ = context.Operators.Start(lc_);
						var le_ = context.Operators.Quantity(1440m, "minutes");
						var lf_ = context.Operators.Subtract(ld_, le_);
						var lh_ = FHIRHelpers_4_3_000.ToInterval(lb_);
						var li_ = context.Operators.Start(lh_);
						var lj_ = context.Operators.Quantity(120m, "minutes");
						var lk_ = context.Operators.Add(li_, lj_);
						var ll_ = context.Operators.Interval(lf_, lk_, true, true);
						var lm_ = context.Operators.In<CqlDateTime>(la_, ll_, null);
						var ln_ = O2Saturation?.StatusElement;
						var lo_ = ln_?.Value;
						var lp_ = context.Operators.Convert<Code<ObservationStatus>>(lo_);
						var lq_ = context.Operators.Convert<string>(lp_);
						var lr_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var ls_ = context.Operators.In<string>(lq_, (lr_ as IEnumerable<string>));
						var lt_ = context.Operators.And(lm_, ls_);
						var lu_ = O2Saturation?.Value;
						var lv_ = FHIRHelpers_4_3_000.ToValue(lu_);
						var lw_ = context.Operators.Not((bool?)(lv_ is null));
						var lx_ = context.Operators.And(lt_, lw_);

						return lx_;
					};
					var kt_ = context.Operators.Where<Observation>(kr_, ks_);
					object ku_(Observation @this)
					{
						object mq_()
						{
							bool ms_()
							{
								var mv_ = @this?.Effective;
								var mw_ = FHIRHelpers_4_3_000.ToValue(mv_);
								var mx_ = mw_ is CqlDateTime;

								return mx_;
							};
							bool mt_()
							{
								var my_ = @this?.Effective;
								var mz_ = FHIRHelpers_4_3_000.ToValue(my_);
								var na_ = mz_ is CqlInterval<CqlDateTime>;

								return na_;
							};
							bool mu_()
							{
								var nb_ = @this?.Effective;
								var nc_ = FHIRHelpers_4_3_000.ToValue(nb_);
								var nd_ = nc_ is CqlDateTime;

								return nd_;
							};
							if (ms_())
							{
								var ne_ = @this?.Effective;
								var nf_ = FHIRHelpers_4_3_000.ToValue(ne_);

								return ((nf_ as CqlDateTime) as object);
							}
							else if (mt_())
							{
								var ng_ = @this?.Effective;
								var nh_ = FHIRHelpers_4_3_000.ToValue(ng_);

								return ((nh_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (mu_())
							{
								var ni_ = @this?.Effective;
								var nj_ = FHIRHelpers_4_3_000.ToValue(ni_);

								return ((nj_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var mr_ = QICoreCommon_2_0_000.earliest(mq_());

						return mr_;
					};
					var kv_ = context.Operators.SortBy<Observation>(kt_, ku_, System.ComponentModel.ListSortDirection.Ascending);
					var kw_ = context.Operators.First<Observation>(kv_);
					var kx_ = kw_?.Effective;
					var ky_ = FHIRHelpers_4_3_000.ToValue(kx_);

					return ((ky_ as CqlDateTime) as object);
				}
				else if (cd_())
				{
					var nk_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var nl_ = context.Operators.RetrieveByValueSet<Observation>(nk_, null);
					bool? nm_(Observation O2Saturation)
					{
						object nt_()
						{
							bool os_()
							{
								var ov_ = O2Saturation?.Effective;
								var ow_ = FHIRHelpers_4_3_000.ToValue(ov_);
								var ox_ = ow_ is CqlDateTime;

								return ox_;
							};
							bool ot_()
							{
								var oy_ = O2Saturation?.Effective;
								var oz_ = FHIRHelpers_4_3_000.ToValue(oy_);
								var pa_ = oz_ is CqlInterval<CqlDateTime>;

								return pa_;
							};
							bool ou_()
							{
								var pb_ = O2Saturation?.Effective;
								var pc_ = FHIRHelpers_4_3_000.ToValue(pb_);
								var pd_ = pc_ is CqlDateTime;

								return pd_;
							};
							if (os_())
							{
								var pe_ = O2Saturation?.Effective;
								var pf_ = FHIRHelpers_4_3_000.ToValue(pe_);

								return ((pf_ as CqlDateTime) as object);
							}
							else if (ot_())
							{
								var pg_ = O2Saturation?.Effective;
								var ph_ = FHIRHelpers_4_3_000.ToValue(pg_);

								return ((ph_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (ou_())
							{
								var pi_ = O2Saturation?.Effective;
								var pj_ = FHIRHelpers_4_3_000.ToValue(pi_);

								return ((pj_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var nu_ = QICoreCommon_2_0_000.earliest(nt_());
						var nv_ = EncounterInpatient?.Period;
						var nw_ = FHIRHelpers_4_3_000.ToInterval(nv_);
						var nx_ = context.Operators.Start(nw_);
						var ny_ = context.Operators.Quantity(1440m, "minutes");
						var nz_ = context.Operators.Subtract(nx_, ny_);
						var ob_ = FHIRHelpers_4_3_000.ToInterval(nv_);
						var oc_ = context.Operators.Start(ob_);
						var od_ = context.Operators.Quantity(120m, "minutes");
						var oe_ = context.Operators.Add(oc_, od_);
						var of_ = context.Operators.Interval(nz_, oe_, true, true);
						var og_ = context.Operators.In<CqlDateTime>(nu_, of_, null);
						var oh_ = O2Saturation?.StatusElement;
						var oi_ = oh_?.Value;
						var oj_ = context.Operators.Convert<Code<ObservationStatus>>(oi_);
						var ok_ = context.Operators.Convert<string>(oj_);
						var ol_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var om_ = context.Operators.In<string>(ok_, (ol_ as IEnumerable<string>));
						var on_ = context.Operators.And(og_, om_);
						var oo_ = O2Saturation?.Value;
						var op_ = FHIRHelpers_4_3_000.ToValue(oo_);
						var oq_ = context.Operators.Not((bool?)(op_ is null));
						var or_ = context.Operators.And(on_, oq_);

						return or_;
					};
					var nn_ = context.Operators.Where<Observation>(nl_, nm_);
					object no_(Observation @this)
					{
						object pk_()
						{
							bool pm_()
							{
								var pp_ = @this?.Effective;
								var pq_ = FHIRHelpers_4_3_000.ToValue(pp_);
								var pr_ = pq_ is CqlDateTime;

								return pr_;
							};
							bool pn_()
							{
								var ps_ = @this?.Effective;
								var pt_ = FHIRHelpers_4_3_000.ToValue(ps_);
								var pu_ = pt_ is CqlInterval<CqlDateTime>;

								return pu_;
							};
							bool po_()
							{
								var pv_ = @this?.Effective;
								var pw_ = FHIRHelpers_4_3_000.ToValue(pv_);
								var px_ = pw_ is CqlDateTime;

								return px_;
							};
							if (pm_())
							{
								var py_ = @this?.Effective;
								var pz_ = FHIRHelpers_4_3_000.ToValue(py_);

								return ((pz_ as CqlDateTime) as object);
							}
							else if (pn_())
							{
								var qa_ = @this?.Effective;
								var qb_ = FHIRHelpers_4_3_000.ToValue(qa_);

								return ((qb_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (po_())
							{
								var qc_ = @this?.Effective;
								var qd_ = FHIRHelpers_4_3_000.ToValue(qc_);

								return ((qd_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var pl_ = QICoreCommon_2_0_000.earliest(pk_());

						return pl_;
					};
					var np_ = context.Operators.SortBy<Observation>(nn_, no_, System.ComponentModel.ListSortDirection.Ascending);
					var nq_ = context.Operators.First<Observation>(np_);
					var nr_ = nq_?.Effective;
					var ns_ = FHIRHelpers_4_3_000.ToValue(nr_);

					return ((ns_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ce_())
				{
					var qe_ = this.Oxygen_Saturation_by_Pulse_Oximetry();
					var qf_ = context.Operators.RetrieveByValueSet<Observation>(qe_, null);
					bool? qg_(Observation O2Saturation)
					{
						object qn_()
						{
							bool rm_()
							{
								var rp_ = O2Saturation?.Effective;
								var rq_ = FHIRHelpers_4_3_000.ToValue(rp_);
								var rr_ = rq_ is CqlDateTime;

								return rr_;
							};
							bool rn_()
							{
								var rs_ = O2Saturation?.Effective;
								var rt_ = FHIRHelpers_4_3_000.ToValue(rs_);
								var ru_ = rt_ is CqlInterval<CqlDateTime>;

								return ru_;
							};
							bool ro_()
							{
								var rv_ = O2Saturation?.Effective;
								var rw_ = FHIRHelpers_4_3_000.ToValue(rv_);
								var rx_ = rw_ is CqlDateTime;

								return rx_;
							};
							if (rm_())
							{
								var ry_ = O2Saturation?.Effective;
								var rz_ = FHIRHelpers_4_3_000.ToValue(ry_);

								return ((rz_ as CqlDateTime) as object);
							}
							else if (rn_())
							{
								var sa_ = O2Saturation?.Effective;
								var sb_ = FHIRHelpers_4_3_000.ToValue(sa_);

								return ((sb_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (ro_())
							{
								var sc_ = O2Saturation?.Effective;
								var sd_ = FHIRHelpers_4_3_000.ToValue(sc_);

								return ((sd_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var qo_ = QICoreCommon_2_0_000.earliest(qn_());
						var qp_ = EncounterInpatient?.Period;
						var qq_ = FHIRHelpers_4_3_000.ToInterval(qp_);
						var qr_ = context.Operators.Start(qq_);
						var qs_ = context.Operators.Quantity(1440m, "minutes");
						var qt_ = context.Operators.Subtract(qr_, qs_);
						var qv_ = FHIRHelpers_4_3_000.ToInterval(qp_);
						var qw_ = context.Operators.Start(qv_);
						var qx_ = context.Operators.Quantity(120m, "minutes");
						var qy_ = context.Operators.Add(qw_, qx_);
						var qz_ = context.Operators.Interval(qt_, qy_, true, true);
						var ra_ = context.Operators.In<CqlDateTime>(qo_, qz_, null);
						var rb_ = O2Saturation?.StatusElement;
						var rc_ = rb_?.Value;
						var rd_ = context.Operators.Convert<Code<ObservationStatus>>(rc_);
						var re_ = context.Operators.Convert<string>(rd_);
						var rf_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var rg_ = context.Operators.In<string>(re_, (rf_ as IEnumerable<string>));
						var rh_ = context.Operators.And(ra_, rg_);
						var ri_ = O2Saturation?.Value;
						var rj_ = FHIRHelpers_4_3_000.ToValue(ri_);
						var rk_ = context.Operators.Not((bool?)(rj_ is null));
						var rl_ = context.Operators.And(rh_, rk_);

						return rl_;
					};
					var qh_ = context.Operators.Where<Observation>(qf_, qg_);
					object qi_(Observation @this)
					{
						object se_()
						{
							bool sg_()
							{
								var sj_ = @this?.Effective;
								var sk_ = FHIRHelpers_4_3_000.ToValue(sj_);
								var sl_ = sk_ is CqlDateTime;

								return sl_;
							};
							bool sh_()
							{
								var sm_ = @this?.Effective;
								var sn_ = FHIRHelpers_4_3_000.ToValue(sm_);
								var so_ = sn_ is CqlInterval<CqlDateTime>;

								return so_;
							};
							bool si_()
							{
								var sp_ = @this?.Effective;
								var sq_ = FHIRHelpers_4_3_000.ToValue(sp_);
								var sr_ = sq_ is CqlDateTime;

								return sr_;
							};
							if (sg_())
							{
								var ss_ = @this?.Effective;
								var st_ = FHIRHelpers_4_3_000.ToValue(ss_);

								return ((st_ as CqlDateTime) as object);
							}
							else if (sh_())
							{
								var su_ = @this?.Effective;
								var sv_ = FHIRHelpers_4_3_000.ToValue(su_);

								return ((sv_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (si_())
							{
								var sw_ = @this?.Effective;
								var sx_ = FHIRHelpers_4_3_000.ToValue(sw_);

								return ((sx_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var sf_ = QICoreCommon_2_0_000.earliest(se_());

						return sf_;
					};
					var qj_ = context.Operators.SortBy<Observation>(qh_, qi_, System.ComponentModel.ListSortDirection.Ascending);
					var qk_ = context.Operators.First<Observation>(qj_);
					var ql_ = qk_?.Effective;
					var qm_ = FHIRHelpers_4_3_000.ToValue(ql_);

					return ((qm_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var p_ = QICoreCommon_2_0_000.earliest(o_());
			var q_ = new Tuple_FdREYEdHOZIcMCNYCRFJYJReA
			{
				EncounterId = e_,
				FirstOxygenSatResult = (n_ as CqlQuantity),
				Timing = p_,
			};

			return q_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_FdREYEdHOZIcMCNYCRFJYJReA>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Oxygen Saturation")]
	public IEnumerable<Tuple_FdREYEdHOZIcMCNYCRFJYJReA> Encounter_with_First_Oxygen_Saturation() => 
		__Encounter_with_First_Oxygen_Saturation.Value;

	private IEnumerable<Observation> Blood_Pressure_Reading_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		bool? b_(Observation BloodPressure)
		{
			var d_ = BloodPressure?.StatusElement;
			var e_ = d_?.Value;
			var f_ = context.Operators.Convert<string>(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context.Operators.In<string>(f_, (g_ as IEnumerable<string>));

			return h_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);

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

	private IEnumerable<Tuple_GbUHPXXHScejjXWhcHJFQQifQ> Encounter_with_First_Bicarbonate_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_GbUHPXXHScejjXWhcHJFQQifQ b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.Bicarbonate_lab_test();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation BicarbonateLab)
			{
				var z_ = BicarbonateLab?.IssuedElement;
				var aa_ = z_?.Value;
				var ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				var ac_ = QICoreCommon_2_0_000.earliest((ab_ as object));
				var ad_ = EncounterInpatient?.Period;
				var ae_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Quantity(1440m, "minutes");
				var ah_ = context.Operators.Subtract(af_, ag_);
				var aj_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var ak_ = context.Operators.Start(aj_);
				var am_ = context.Operators.Add(ak_, ag_);
				var an_ = context.Operators.Interval(ah_, am_, true, true);
				var ao_ = context.Operators.In<CqlDateTime>(ac_, an_, null);
				var ap_ = BicarbonateLab?.StatusElement;
				var aq_ = ap_?.Value;
				var ar_ = context.Operators.Convert<string>(aq_);
				var as_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var at_ = context.Operators.In<string>(ar_, (as_ as IEnumerable<string>));
				var au_ = context.Operators.And(ao_, at_);
				var av_ = BicarbonateLab?.Value;
				var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
				var ax_ = context.Operators.Not((bool?)(aw_ is null));
				var ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			var i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				var az_ = @this?.IssuedElement;
				var ba_ = az_?.Value;
				var bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				var bc_ = QICoreCommon_2_0_000.earliest((bb_ as object));

				return bc_;
			};
			var k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			var l_ = context.Operators.First<Observation>(k_);
			var m_ = l_?.Value;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			var p_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? q_(Observation BicarbonateLab)
			{
				var bd_ = BicarbonateLab?.IssuedElement;
				var be_ = bd_?.Value;
				var bf_ = context.Operators.Convert<CqlDateTime>(be_);
				var bg_ = QICoreCommon_2_0_000.earliest((bf_ as object));
				var bh_ = EncounterInpatient?.Period;
				var bi_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Quantity(1440m, "minutes");
				var bl_ = context.Operators.Subtract(bj_, bk_);
				var bn_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bo_ = context.Operators.Start(bn_);
				var bq_ = context.Operators.Add(bo_, bk_);
				var br_ = context.Operators.Interval(bl_, bq_, true, true);
				var bs_ = context.Operators.In<CqlDateTime>(bg_, br_, null);
				var bt_ = BicarbonateLab?.StatusElement;
				var bu_ = bt_?.Value;
				var bv_ = context.Operators.Convert<string>(bu_);
				var bw_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bx_ = context.Operators.In<string>(bv_, (bw_ as IEnumerable<string>));
				var by_ = context.Operators.And(bs_, bx_);
				var bz_ = BicarbonateLab?.Value;
				var ca_ = FHIRHelpers_4_3_000.ToValue(bz_);
				var cb_ = context.Operators.Not((bool?)(ca_ is null));
				var cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			var r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				var cd_ = @this?.IssuedElement;
				var ce_ = cd_?.Value;
				var cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				var cg_ = QICoreCommon_2_0_000.earliest((cf_ as object));

				return cg_;
			};
			var t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.First<Observation>(t_);
			var v_ = u_?.IssuedElement;
			var w_ = v_?.Value;
			var x_ = context.Operators.Convert<CqlDateTime>(w_);
			var y_ = new Tuple_GbUHPXXHScejjXWhcHJFQQifQ
			{
				EncounterId = e_,
				FirstBicarbonateResult = (n_ as CqlQuantity),
				Timing = x_,
			};

			return y_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_GbUHPXXHScejjXWhcHJFQQifQ>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Bicarbonate Lab Test")]
	public IEnumerable<Tuple_GbUHPXXHScejjXWhcHJFQQifQ> Encounter_with_First_Bicarbonate_Lab_Test() => 
		__Encounter_with_First_Bicarbonate_Lab_Test.Value;

	private IEnumerable<Tuple_FETECNQPQREfGRgPYWhOWgeWA> Encounter_with_First_Creatinine_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_FETECNQPQREfGRgPYWhOWgeWA b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.Creatinine_lab_test();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation CreatinineLab)
			{
				var z_ = CreatinineLab?.IssuedElement;
				var aa_ = z_?.Value;
				var ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				var ac_ = QICoreCommon_2_0_000.earliest((ab_ as object));
				var ad_ = EncounterInpatient?.Period;
				var ae_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Quantity(1440m, "minutes");
				var ah_ = context.Operators.Subtract(af_, ag_);
				var aj_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var ak_ = context.Operators.Start(aj_);
				var am_ = context.Operators.Add(ak_, ag_);
				var an_ = context.Operators.Interval(ah_, am_, true, true);
				var ao_ = context.Operators.In<CqlDateTime>(ac_, an_, null);
				var ap_ = CreatinineLab?.StatusElement;
				var aq_ = ap_?.Value;
				var ar_ = context.Operators.Convert<string>(aq_);
				var as_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var at_ = context.Operators.In<string>(ar_, (as_ as IEnumerable<string>));
				var au_ = context.Operators.And(ao_, at_);
				var av_ = CreatinineLab?.Value;
				var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
				var ax_ = context.Operators.Not((bool?)(aw_ is null));
				var ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			var i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				var az_ = @this?.IssuedElement;
				var ba_ = az_?.Value;
				var bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				var bc_ = QICoreCommon_2_0_000.earliest((bb_ as object));

				return bc_;
			};
			var k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			var l_ = context.Operators.First<Observation>(k_);
			var m_ = l_?.Value;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			var p_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? q_(Observation CreatinineLab)
			{
				var bd_ = CreatinineLab?.IssuedElement;
				var be_ = bd_?.Value;
				var bf_ = context.Operators.Convert<CqlDateTime>(be_);
				var bg_ = QICoreCommon_2_0_000.earliest((bf_ as object));
				var bh_ = EncounterInpatient?.Period;
				var bi_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Quantity(1440m, "minutes");
				var bl_ = context.Operators.Subtract(bj_, bk_);
				var bn_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bo_ = context.Operators.Start(bn_);
				var bq_ = context.Operators.Add(bo_, bk_);
				var br_ = context.Operators.Interval(bl_, bq_, true, true);
				var bs_ = context.Operators.In<CqlDateTime>(bg_, br_, null);
				var bt_ = CreatinineLab?.StatusElement;
				var bu_ = bt_?.Value;
				var bv_ = context.Operators.Convert<string>(bu_);
				var bw_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bx_ = context.Operators.In<string>(bv_, (bw_ as IEnumerable<string>));
				var by_ = context.Operators.And(bs_, bx_);
				var bz_ = CreatinineLab?.Value;
				var ca_ = FHIRHelpers_4_3_000.ToValue(bz_);
				var cb_ = context.Operators.Not((bool?)(ca_ is null));
				var cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			var r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				var cd_ = @this?.IssuedElement;
				var ce_ = cd_?.Value;
				var cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				var cg_ = QICoreCommon_2_0_000.earliest((cf_ as object));

				return cg_;
			};
			var t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.First<Observation>(t_);
			var v_ = u_?.IssuedElement;
			var w_ = v_?.Value;
			var x_ = context.Operators.Convert<CqlDateTime>(w_);
			var y_ = new Tuple_FETECNQPQREfGRgPYWhOWgeWA
			{
				EncounterId = e_,
				FirstCreatinineResult = (n_ as CqlQuantity),
				Timing = x_,
			};

			return y_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_FETECNQPQREfGRgPYWhOWgeWA>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Creatinine Lab Test")]
	public IEnumerable<Tuple_FETECNQPQREfGRgPYWhOWgeWA> Encounter_with_First_Creatinine_Lab_Test() => 
		__Encounter_with_First_Creatinine_Lab_Test.Value;

	private IEnumerable<Tuple_DIHdhbAJeJTdiAVUAELUHRNdS> Encounter_with_First_Hematocrit_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_DIHdhbAJeJTdiAVUAELUHRNdS b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.Hematocrit_lab_test();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation HematocritLab)
			{
				var z_ = HematocritLab?.IssuedElement;
				var aa_ = z_?.Value;
				var ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				var ac_ = QICoreCommon_2_0_000.earliest((ab_ as object));
				var ad_ = EncounterInpatient?.Period;
				var ae_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Quantity(1440m, "minutes");
				var ah_ = context.Operators.Subtract(af_, ag_);
				var aj_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var ak_ = context.Operators.Start(aj_);
				var am_ = context.Operators.Add(ak_, ag_);
				var an_ = context.Operators.Interval(ah_, am_, true, true);
				var ao_ = context.Operators.In<CqlDateTime>(ac_, an_, null);
				var ap_ = HematocritLab?.StatusElement;
				var aq_ = ap_?.Value;
				var ar_ = context.Operators.Convert<string>(aq_);
				var as_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var at_ = context.Operators.In<string>(ar_, (as_ as IEnumerable<string>));
				var au_ = context.Operators.And(ao_, at_);
				var av_ = HematocritLab?.Value;
				var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
				var ax_ = context.Operators.Not((bool?)(aw_ is null));
				var ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			var i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				var az_ = @this?.IssuedElement;
				var ba_ = az_?.Value;
				var bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				var bc_ = QICoreCommon_2_0_000.earliest((bb_ as object));

				return bc_;
			};
			var k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			var l_ = context.Operators.First<Observation>(k_);
			var m_ = l_?.Value;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			var p_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? q_(Observation HematocritLab)
			{
				var bd_ = HematocritLab?.IssuedElement;
				var be_ = bd_?.Value;
				var bf_ = context.Operators.Convert<CqlDateTime>(be_);
				var bg_ = QICoreCommon_2_0_000.earliest((bf_ as object));
				var bh_ = EncounterInpatient?.Period;
				var bi_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Quantity(1440m, "minutes");
				var bl_ = context.Operators.Subtract(bj_, bk_);
				var bn_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bo_ = context.Operators.Start(bn_);
				var bq_ = context.Operators.Add(bo_, bk_);
				var br_ = context.Operators.Interval(bl_, bq_, true, true);
				var bs_ = context.Operators.In<CqlDateTime>(bg_, br_, null);
				var bt_ = HematocritLab?.StatusElement;
				var bu_ = bt_?.Value;
				var bv_ = context.Operators.Convert<string>(bu_);
				var bw_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bx_ = context.Operators.In<string>(bv_, (bw_ as IEnumerable<string>));
				var by_ = context.Operators.And(bs_, bx_);
				var bz_ = HematocritLab?.Value;
				var ca_ = FHIRHelpers_4_3_000.ToValue(bz_);
				var cb_ = context.Operators.Not((bool?)(ca_ is null));
				var cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			var r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				var cd_ = @this?.IssuedElement;
				var ce_ = cd_?.Value;
				var cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				var cg_ = QICoreCommon_2_0_000.earliest((cf_ as object));

				return cg_;
			};
			var t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.First<Observation>(t_);
			var v_ = u_?.IssuedElement;
			var w_ = v_?.Value;
			var x_ = context.Operators.Convert<CqlDateTime>(w_);
			var y_ = new Tuple_DIHdhbAJeJTdiAVUAELUHRNdS
			{
				EncounterId = e_,
				FirstHematocritResult = (n_ as CqlQuantity),
				Timing = x_,
			};

			return y_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_DIHdhbAJeJTdiAVUAELUHRNdS>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Hematocrit Lab Test")]
	public IEnumerable<Tuple_DIHdhbAJeJTdiAVUAELUHRNdS> Encounter_with_First_Hematocrit_Lab_Test() => 
		__Encounter_with_First_Hematocrit_Lab_Test.Value;

	private IEnumerable<Tuple_DAUcYHQZcDKbIfORJOEZBDgIh> Encounter_with_First_Platelet_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_DAUcYHQZcDKbIfORJOEZBDgIh b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.Platelet_count_lab_test();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation PlateletLab)
			{
				var z_ = PlateletLab?.IssuedElement;
				var aa_ = z_?.Value;
				var ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				var ac_ = QICoreCommon_2_0_000.earliest((ab_ as object));
				var ad_ = EncounterInpatient?.Period;
				var ae_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Quantity(1440m, "minutes");
				var ah_ = context.Operators.Subtract(af_, ag_);
				var aj_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var ak_ = context.Operators.Start(aj_);
				var am_ = context.Operators.Add(ak_, ag_);
				var an_ = context.Operators.Interval(ah_, am_, true, true);
				var ao_ = context.Operators.In<CqlDateTime>(ac_, an_, null);
				var ap_ = PlateletLab?.StatusElement;
				var aq_ = ap_?.Value;
				var ar_ = context.Operators.Convert<string>(aq_);
				var as_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var at_ = context.Operators.In<string>(ar_, (as_ as IEnumerable<string>));
				var au_ = context.Operators.And(ao_, at_);
				var av_ = PlateletLab?.Value;
				var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
				var ax_ = context.Operators.Not((bool?)(aw_ is null));
				var ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			var i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				var az_ = @this?.IssuedElement;
				var ba_ = az_?.Value;
				var bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				var bc_ = QICoreCommon_2_0_000.earliest((bb_ as object));

				return bc_;
			};
			var k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			var l_ = context.Operators.First<Observation>(k_);
			var m_ = l_?.Value;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			var p_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? q_(Observation PlateletLab)
			{
				var bd_ = PlateletLab?.IssuedElement;
				var be_ = bd_?.Value;
				var bf_ = context.Operators.Convert<CqlDateTime>(be_);
				var bg_ = QICoreCommon_2_0_000.earliest((bf_ as object));
				var bh_ = EncounterInpatient?.Period;
				var bi_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Quantity(1440m, "minutes");
				var bl_ = context.Operators.Subtract(bj_, bk_);
				var bn_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bo_ = context.Operators.Start(bn_);
				var bq_ = context.Operators.Add(bo_, bk_);
				var br_ = context.Operators.Interval(bl_, bq_, true, true);
				var bs_ = context.Operators.In<CqlDateTime>(bg_, br_, null);
				var bt_ = PlateletLab?.StatusElement;
				var bu_ = bt_?.Value;
				var bv_ = context.Operators.Convert<string>(bu_);
				var bw_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bx_ = context.Operators.In<string>(bv_, (bw_ as IEnumerable<string>));
				var by_ = context.Operators.And(bs_, bx_);
				var bz_ = PlateletLab?.Value;
				var ca_ = FHIRHelpers_4_3_000.ToValue(bz_);
				var cb_ = context.Operators.Not((bool?)(ca_ is null));
				var cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			var r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				var cd_ = @this?.IssuedElement;
				var ce_ = cd_?.Value;
				var cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				var cg_ = QICoreCommon_2_0_000.earliest((cf_ as object));

				return cg_;
			};
			var t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.First<Observation>(t_);
			var v_ = u_?.IssuedElement;
			var w_ = v_?.Value;
			var x_ = context.Operators.Convert<CqlDateTime>(w_);
			var y_ = new Tuple_DAUcYHQZcDKbIfORJOEZBDgIh
			{
				EncounterId = e_,
				FirstPlateletResult = (n_ as CqlQuantity),
				Timing = x_,
			};

			return y_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_DAUcYHQZcDKbIfORJOEZBDgIh>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Platelet Lab Test")]
	public IEnumerable<Tuple_DAUcYHQZcDKbIfORJOEZBDgIh> Encounter_with_First_Platelet_Lab_Test() => 
		__Encounter_with_First_Platelet_Lab_Test.Value;

	private IEnumerable<Tuple_GKGeLARADLGJcNcZaDhdCREMa> Encounter_with_First_Sodium_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_GKGeLARADLGJcNcZaDhdCREMa b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.Sodium_lab_test();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation SodiumLab)
			{
				var z_ = SodiumLab?.IssuedElement;
				var aa_ = z_?.Value;
				var ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				var ac_ = QICoreCommon_2_0_000.earliest((ab_ as object));
				var ad_ = EncounterInpatient?.Period;
				var ae_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Quantity(1440m, "minutes");
				var ah_ = context.Operators.Subtract(af_, ag_);
				var aj_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var ak_ = context.Operators.Start(aj_);
				var am_ = context.Operators.Add(ak_, ag_);
				var an_ = context.Operators.Interval(ah_, am_, true, true);
				var ao_ = context.Operators.In<CqlDateTime>(ac_, an_, null);
				var ap_ = SodiumLab?.StatusElement;
				var aq_ = ap_?.Value;
				var ar_ = context.Operators.Convert<string>(aq_);
				var as_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var at_ = context.Operators.In<string>(ar_, (as_ as IEnumerable<string>));
				var au_ = context.Operators.And(ao_, at_);
				var av_ = SodiumLab?.Value;
				var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
				var ax_ = context.Operators.Not((bool?)(aw_ is null));
				var ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			var i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				var az_ = @this?.IssuedElement;
				var ba_ = az_?.Value;
				var bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				var bc_ = QICoreCommon_2_0_000.earliest((bb_ as object));

				return bc_;
			};
			var k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			var l_ = context.Operators.First<Observation>(k_);
			var m_ = l_?.Value;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			var p_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? q_(Observation SodiumLab)
			{
				var bd_ = SodiumLab?.IssuedElement;
				var be_ = bd_?.Value;
				var bf_ = context.Operators.Convert<CqlDateTime>(be_);
				var bg_ = QICoreCommon_2_0_000.earliest((bf_ as object));
				var bh_ = EncounterInpatient?.Period;
				var bi_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Quantity(1440m, "minutes");
				var bl_ = context.Operators.Subtract(bj_, bk_);
				var bn_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bo_ = context.Operators.Start(bn_);
				var bq_ = context.Operators.Add(bo_, bk_);
				var br_ = context.Operators.Interval(bl_, bq_, true, true);
				var bs_ = context.Operators.In<CqlDateTime>(bg_, br_, null);
				var bt_ = SodiumLab?.StatusElement;
				var bu_ = bt_?.Value;
				var bv_ = context.Operators.Convert<string>(bu_);
				var bw_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bx_ = context.Operators.In<string>(bv_, (bw_ as IEnumerable<string>));
				var by_ = context.Operators.And(bs_, bx_);
				var bz_ = SodiumLab?.Value;
				var ca_ = FHIRHelpers_4_3_000.ToValue(bz_);
				var cb_ = context.Operators.Not((bool?)(ca_ is null));
				var cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			var r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				var cd_ = @this?.IssuedElement;
				var ce_ = cd_?.Value;
				var cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				var cg_ = QICoreCommon_2_0_000.earliest((cf_ as object));

				return cg_;
			};
			var t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.First<Observation>(t_);
			var v_ = u_?.IssuedElement;
			var w_ = v_?.Value;
			var x_ = context.Operators.Convert<CqlDateTime>(w_);
			var y_ = new Tuple_GKGeLARADLGJcNcZaDhdCREMa
			{
				EncounterId = e_,
				FirstSodiumResult = (n_ as CqlQuantity),
				Timing = x_,
			};

			return y_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_GKGeLARADLGJcNcZaDhdCREMa>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Sodium Lab Test")]
	public IEnumerable<Tuple_GKGeLARADLGJcNcZaDhdCREMa> Encounter_with_First_Sodium_Lab_Test() => 
		__Encounter_with_First_Sodium_Lab_Test.Value;

	private IEnumerable<Tuple_ChVYCdXDGgVcFTCCUefXMbCHX> Encounter_with_First_White_Blood_Cells_Lab_Test_Value()
	{
		var a_ = this.Inpatient_Encounters();
		Tuple_ChVYCdXDGgVcFTCCUefXMbCHX b_(Encounter EncounterInpatient)
		{
			var d_ = EncounterInpatient?.IdElement;
			var e_ = d_?.Value;
			var f_ = this.White_blood_cells_count_lab_test();
			var g_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? h_(Observation WhiteBloodCellLab)
			{
				var z_ = WhiteBloodCellLab?.IssuedElement;
				var aa_ = z_?.Value;
				var ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				var ac_ = QICoreCommon_2_0_000.earliest((ab_ as object));
				var ad_ = EncounterInpatient?.Period;
				var ae_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Quantity(1440m, "minutes");
				var ah_ = context.Operators.Subtract(af_, ag_);
				var aj_ = FHIRHelpers_4_3_000.ToInterval(ad_);
				var ak_ = context.Operators.Start(aj_);
				var am_ = context.Operators.Add(ak_, ag_);
				var an_ = context.Operators.Interval(ah_, am_, true, true);
				var ao_ = context.Operators.In<CqlDateTime>(ac_, an_, null);
				var ap_ = WhiteBloodCellLab?.StatusElement;
				var aq_ = ap_?.Value;
				var ar_ = context.Operators.Convert<string>(aq_);
				var as_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var at_ = context.Operators.In<string>(ar_, (as_ as IEnumerable<string>));
				var au_ = context.Operators.And(ao_, at_);
				var av_ = WhiteBloodCellLab?.Value;
				var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
				var ax_ = context.Operators.Not((bool?)(aw_ is null));
				var ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			var i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				var az_ = @this?.IssuedElement;
				var ba_ = az_?.Value;
				var bb_ = context.Operators.Convert<CqlDateTime>(ba_);
				var bc_ = QICoreCommon_2_0_000.earliest((bb_ as object));

				return bc_;
			};
			var k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			var l_ = context.Operators.First<Observation>(k_);
			var m_ = l_?.Value;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			var p_ = context.Operators.RetrieveByValueSet<Observation>(f_, null);
			bool? q_(Observation WhiteBloodCellLab)
			{
				var bd_ = WhiteBloodCellLab?.IssuedElement;
				var be_ = bd_?.Value;
				var bf_ = context.Operators.Convert<CqlDateTime>(be_);
				var bg_ = QICoreCommon_2_0_000.earliest((bf_ as object));
				var bh_ = EncounterInpatient?.Period;
				var bi_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Quantity(1440m, "minutes");
				var bl_ = context.Operators.Subtract(bj_, bk_);
				var bn_ = FHIRHelpers_4_3_000.ToInterval(bh_);
				var bo_ = context.Operators.Start(bn_);
				var bq_ = context.Operators.Add(bo_, bk_);
				var br_ = context.Operators.Interval(bl_, bq_, true, true);
				var bs_ = context.Operators.In<CqlDateTime>(bg_, br_, null);
				var bt_ = WhiteBloodCellLab?.StatusElement;
				var bu_ = bt_?.Value;
				var bv_ = context.Operators.Convert<string>(bu_);
				var bw_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bx_ = context.Operators.In<string>(bv_, (bw_ as IEnumerable<string>));
				var by_ = context.Operators.And(bs_, bx_);
				var bz_ = WhiteBloodCellLab?.Value;
				var ca_ = FHIRHelpers_4_3_000.ToValue(bz_);
				var cb_ = context.Operators.Not((bool?)(ca_ is null));
				var cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			var r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				var cd_ = @this?.IssuedElement;
				var ce_ = cd_?.Value;
				var cf_ = context.Operators.Convert<CqlDateTime>(ce_);
				var cg_ = QICoreCommon_2_0_000.earliest((cf_ as object));

				return cg_;
			};
			var t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.First<Observation>(t_);
			var v_ = u_?.IssuedElement;
			var w_ = v_?.Value;
			var x_ = context.Operators.Convert<CqlDateTime>(w_);
			var y_ = new Tuple_ChVYCdXDGgVcFTCCUefXMbCHX
			{
				EncounterId = e_,
				FirstWhiteBloodCellResult = (n_ as CqlQuantity),
				Timing = x_,
			};

			return y_;
		};
		var c_ = context.Operators.Select<Encounter, Tuple_ChVYCdXDGgVcFTCCUefXMbCHX>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First White Blood Cells Lab Test")]
	public IEnumerable<Tuple_ChVYCdXDGgVcFTCCUefXMbCHX> Encounter_with_First_White_Blood_Cells_Lab_Test() => 
		__Encounter_with_First_White_Blood_Cells_Lab_Test.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
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
