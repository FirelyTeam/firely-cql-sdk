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
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.0.012")]
public class HospitalHarmSevereHypoglycemiaFHIR_0_0_012
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __birth_date;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Glucose_lab_test;
    internal Lazy<CqlValueSet> __Hypoglycemics;
    internal Lazy<CqlValueSet> __Hypoglycemics_Severe_Hypoglycemia;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<IEnumerable<MedicationAdministration>> __Hypoglycemic_Medication_Administration;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_with_Hypoglycemic_Medication_Administration;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Severe_Hypoglycemic_Harm_Event;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;

    #endregion
    public HospitalHarmSevereHypoglycemiaFHIR_0_0_012(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __birth_date = new Lazy<CqlValueSet>(this.birth_date_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Glucose_lab_test = new Lazy<CqlValueSet>(this.Glucose_lab_test_Value);
        __Hypoglycemics = new Lazy<CqlValueSet>(this.Hypoglycemics_Value);
        __Hypoglycemics_Severe_Hypoglycemia = new Lazy<CqlValueSet>(this.Hypoglycemics_Severe_Hypoglycemia_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Inpatient_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_During_Measurement_Period_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Hypoglycemic_Medication_Administration = new Lazy<IEnumerable<MedicationAdministration>>(this.Hypoglycemic_Medication_Administration_Value);
        __Qualifying_Encounter_with_Hypoglycemic_Medication_Administration = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Severe_Hypoglycemic_Harm_Event = new Lazy<IEnumerable<Encounter>>(this.Severe_Hypoglycemic_Harm_Event_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

    private CqlValueSet birth_date_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
    public CqlValueSet birth_date() => __birth_date.Value;

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

    private CqlValueSet Glucose_lab_test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hypoglycemics_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", null);

    [CqlDeclaration("Hypoglycemics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3")]
    public CqlValueSet Hypoglycemics() => __Hypoglycemics.Value;

    private CqlValueSet Hypoglycemics_Severe_Hypoglycemia_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia() => __Hypoglycemics_Severe_Hypoglycemia.Value;

    private CqlValueSet Observation_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", f_);

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

    private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
	{
		var j_ = this.Encounter_Inpatient();
		var k_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(j_, null);
		var l_ = (Encounter EncounterInpatient) =>
		{
			var a_ = (EncounterInpatient?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = EncounterInpatient?.Period;
			var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.ElementInInterval<CqlDateTime>(g_, h_, null);

			return context?.Operators.And(d_, i_);
		};

		return context?.Operators.WhereOrNull<Encounter>(k_, l_);
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => __Inpatient_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var h_ = this.Inpatient_Encounter_During_Measurement_Period();
		var i_ = (Encounter InpatientEncounter) =>
		{
			var a_ = this.Patient()?.BirthDateElement?.Value;
			var b_ = context?.Operators.ConvertStringToDateTime(a_);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.CalculateAgeAt(b_, d_, "year");
			var f_ = (e_ as object);
			var g_ = ((int?)18 as object);

			return context?.Operators.GreaterOrEqual(f_, g_);
		};

		return context?.Operators.WhereOrNull<Encounter>(h_, i_);
	}

    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter() => __Qualifying_Encounter.Value;

    private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		var j_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var k_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(j_, null);
		var l_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var m_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(l_, null);
		var n_ = context?.Operators.ListUnion<MedicationAdministration>(k_, m_);
		var o_ = (MedicationAdministration HypoMedication) =>
		{
			var a_ = (HypoMedication?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = (HypoMedication?.StatusElement as object);
			var f_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(e_);
			var g_ = (f_ as object);
			var h_ = context?.Operators.Equal(g_, ("not-done" as object));
			var i_ = context?.Operators.Not(h_);

			return context?.Operators.And(d_, i_);
		};

		return context?.Operators.WhereOrNull<MedicationAdministration>(n_, o_);
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => __Hypoglycemic_Medication_Administration.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		var i_ = this.Qualifying_Encounter();
		var j_ = (Encounter QualifyingEncounter) =>
		{
			var e_ = this.Hypoglycemic_Medication_Administration();
			var f_ = (MedicationAdministration HypoglycemicMedication) =>
			{
				var a_ = (HypoglycemicMedication?.Effective as object);
				var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);
				var c_ = context?.Operators.Start(b_);
				var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);

				return context?.Operators.ElementInInterval<CqlDateTime>(c_, d_, null);
			};
			var g_ = context?.Operators.WhereOrNull<MedicationAdministration>(e_, f_);
			var h_ = (MedicationAdministration HypoglycemicMedication) => QualifyingEncounter;

			return context?.Operators.SelectOrNull<MedicationAdministration, Encounter>(g_, h_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(i_, j_);
	}

    [CqlDeclaration("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration() => __Qualifying_Encounter_with_Hypoglycemic_Medication_Administration.Value;

    private IEnumerable<Encounter> Initial_Population_Value() =>
		this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration();

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    private IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event_Value()
	{
		var er_ = this.Denominator();
		var es_ = (Encounter QualifyingEncounter) =>
		{
			var ee_ = this.Glucose_lab_test();
			var ef_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ee_, null);
			var eg_ = (Observation BloodGlucoseLab) =>
			{
				var aj_ = this.Hypoglycemic_Medication_Administration();
				var ak_ = (MedicationAdministration HypoglycemicMeds) =>
				{
					var a_ = (HypoglycemicMeds?.Effective as object);
					var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);
					var c_ = context?.Operators.Start(b_);
					var d_ = (BloodGlucoseLab?.Effective as object);
					var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(d_);
					var f_ = context?.Operators.Start(e_);
					var g_ = context?.Operators.Quantity(24m, "hours");
					var h_ = context?.Operators.Subtract(f_, g_);
					var i_ = (BloodGlucoseLab?.Effective as object);
					var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
					var k_ = context?.Operators.Start(j_);
					var l_ = context?.Operators.Interval(h_, k_, true, true);
					var m_ = context?.Operators.ElementInInterval<CqlDateTime>(c_, l_, null);
					var n_ = (BloodGlucoseLab?.Effective as object);
					var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(n_);
					var p_ = context?.Operators.Start(o_);
					var q_ = (bool?)(p_ == null);
					var r_ = context?.Operators.Not(q_);
					var s_ = context?.Operators.And(m_, r_);
					var t_ = (BloodGlucoseLab?.StatusElement as object);
					var u_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(t_);
					var v_ = (u_ as object);
					var w_ = context?.Operators.Equal(v_, ("final" as object));
					var x_ = context?.Operators.And(s_, w_);
					var y_ = (BloodGlucoseLab?.StatusElement as object);
					var z_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(y_);
					var aa_ = (z_ as object);
					var ab_ = context?.Operators.Equal(aa_, ("cancelled" as object));
					var ac_ = context?.Operators.Not(ab_);
					var ad_ = context?.Operators.And(x_, ac_);
					var ae_ = (HypoglycemicMeds?.Effective as object);
					var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ae_);
					var ag_ = context?.Operators.Start(af_);
					var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var ai_ = context?.Operators.ElementInInterval<CqlDateTime>(ag_, ah_, null);

					return context?.Operators.And(ad_, ai_);
				};
				var al_ = context?.Operators.WhereOrNull<MedicationAdministration>(aj_, ak_);
				var am_ = (MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;

				return context?.Operators.SelectOrNull<MedicationAdministration, Observation>(al_, am_);
			};
			var eh_ = context?.Operators.SelectManyOrNull<Observation, Observation>(ef_, eg_);
			var ei_ = this.Glucose_lab_test();
			var ej_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ei_, null);
			var ek_ = (Observation BloodGlucoseLab) =>
			{
				var bw_ = this.Hypoglycemic_Medication_Administration();
				var bx_ = (MedicationAdministration HypoglycemicMeds) =>
				{
					var an_ = (HypoglycemicMeds?.Effective as object);
					var ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(an_);
					var ap_ = context?.Operators.Start(ao_);
					var aq_ = (BloodGlucoseLab?.Effective as object);
					var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aq_);
					var as_ = context?.Operators.Start(ar_);
					var at_ = context?.Operators.Quantity(24m, "hours");
					var au_ = context?.Operators.Subtract(as_, at_);
					var av_ = (BloodGlucoseLab?.Effective as object);
					var aw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(av_);
					var ax_ = context?.Operators.Start(aw_);
					var ay_ = context?.Operators.Interval(au_, ax_, true, true);
					var az_ = context?.Operators.ElementInInterval<CqlDateTime>(ap_, ay_, null);
					var ba_ = (BloodGlucoseLab?.Effective as object);
					var bb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ba_);
					var bc_ = context?.Operators.Start(bb_);
					var bd_ = (bool?)(bc_ == null);
					var be_ = context?.Operators.Not(bd_);
					var bf_ = context?.Operators.And(az_, be_);
					var bg_ = (BloodGlucoseLab?.StatusElement as object);
					var bh_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(bg_);
					var bi_ = (bh_ as object);
					var bj_ = context?.Operators.Equal(bi_, ("final" as object));
					var bk_ = context?.Operators.And(bf_, bj_);
					var bl_ = (BloodGlucoseLab?.StatusElement as object);
					var bm_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(bl_);
					var bn_ = (bm_ as object);
					var bo_ = context?.Operators.Equal(bn_, ("cancelled" as object));
					var bp_ = context?.Operators.Not(bo_);
					var bq_ = context?.Operators.And(bk_, bp_);
					var br_ = (HypoglycemicMeds?.Effective as object);
					var bs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(br_);
					var bt_ = context?.Operators.Start(bs_);
					var bu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var bv_ = context?.Operators.ElementInInterval<CqlDateTime>(bt_, bu_, null);

					return context?.Operators.And(bq_, bv_);
				};
				var by_ = context?.Operators.WhereOrNull<MedicationAdministration>(bw_, bx_);
				var bz_ = (MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;

				return context?.Operators.SelectOrNull<MedicationAdministration, Observation>(by_, bz_);
			};
			var el_ = context?.Operators.SelectManyOrNull<Observation, Observation>(ej_, ek_);
			var em_ = (Observation BloodGlucoseLab) =>
			{
				var dp_ = this.Glucose_lab_test();
				var dq_ = context?.DataRetriever.RetrieveByValueSet<Observation>(dp_, null);
				var dr_ = (Observation FollowupBloodGlucoseLab) =>
				{
					var ca_ = (FollowupBloodGlucoseLab?.Effective as object);
					var cb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ca_);
					var cc_ = context?.Operators.Start(cb_);
					var cd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var ce_ = context?.Operators.ElementInInterval<CqlDateTime>(cc_, cd_, null);
					var cf_ = (FollowupBloodGlucoseLab?.Effective as object);
					var cg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cf_);
					var ch_ = context?.Operators.Start(cg_);
					var ci_ = (BloodGlucoseLab?.Effective as object);
					var cj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ci_);
					var ck_ = context?.Operators.Start(cj_);
					var cl_ = (BloodGlucoseLab?.Effective as object);
					var cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cl_);
					var cn_ = context?.Operators.Start(cm_);
					var co_ = context?.Operators.Quantity(5m, "minutes");
					var cp_ = context?.Operators.Add(cn_, co_);
					var cq_ = context?.Operators.Interval(ck_, cp_, false, true);
					var cr_ = context?.Operators.ElementInInterval<CqlDateTime>(ch_, cq_, null);
					var cs_ = (BloodGlucoseLab?.Effective as object);
					var ct_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cs_);
					var cu_ = context?.Operators.Start(ct_);
					var cv_ = (bool?)(cu_ == null);
					var cw_ = context?.Operators.Not(cv_);
					var cx_ = context?.Operators.And(cr_, cw_);
					var cy_ = context?.Operators.And(ce_, cx_);
					var cz_ = (FollowupBloodGlucoseLab?.StatusElement as object);
					var da_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(cz_);
					var db_ = (da_ as object);
					var dc_ = context?.Operators.Equal(db_, ("final" as object));
					var dd_ = context?.Operators.And(cy_, dc_);
					var de_ = (FollowupBloodGlucoseLab?.StatusElement as object);
					var df_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(de_);
					var dg_ = (df_ as object);
					var dh_ = context?.Operators.Equal(dg_, ("cancelled" as object));
					var di_ = context?.Operators.Not(dh_);
					var dj_ = context?.Operators.And(dd_, di_);
					var dk_ = ((FollowupBloodGlucoseLab?.Value as object) as Quantity);
					var dl_ = FHIRHelpers_4_0_001.ToQuantity(dk_);
					var dm_ = (dl_ as object);
					var dn_ = (context?.Operators.Quantity(80m, "mg/dL") as object);
					var do_ = context?.Operators.Greater(dm_, dn_);

					return context?.Operators.And(dj_, do_);
				};
				var ds_ = context?.Operators.WhereOrNull<Observation>(dq_, dr_);
				var dt_ = (Observation FollowupBloodGlucoseLab) => BloodGlucoseLab;

				return context?.Operators.SelectOrNull<Observation, Observation>(ds_, dt_);
			};
			var en_ = context?.Operators.SelectManyOrNull<Observation, Observation>(el_, em_);
			var eo_ = context?.Operators.ListExcept<Observation>(eh_, en_);
			var ep_ = (Observation BloodGlucoseLab) =>
			{
				var du_ = (BloodGlucoseLab?.Effective as object);
				var dv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(du_);
				var dw_ = context?.Operators.Start(dv_);
				var dx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var dy_ = context?.Operators.ElementInInterval<CqlDateTime>(dw_, dx_, null);
				var dz_ = ((BloodGlucoseLab?.Value as object) as Quantity);
				var ea_ = FHIRHelpers_4_0_001.ToQuantity(dz_);
				var eb_ = (ea_ as object);
				var ec_ = (context?.Operators.Quantity(40m, "mg/dL") as object);
				var ed_ = context?.Operators.Less(eb_, ec_);

				return context?.Operators.And(dy_, ed_);
			};
			var eq_ = context?.Operators.WhereOrNull<Observation>(eo_, ep_);

			return context?.Operators.ExistsInList<Observation>(eq_);
		};

		return context?.Operators.WhereOrNull<Encounter>(er_, es_);
	}

    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event() => __Severe_Hypoglycemic_Harm_Event.Value;

    private IEnumerable<Encounter> Numerator_Value() =>
		this.Severe_Hypoglycemic_Harm_Event();

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

}