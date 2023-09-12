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
	public CqlValueSet birth_date() => 
		__birth_date.Value;

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

	private CqlValueSet Glucose_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
	public CqlValueSet Glucose_lab_test() => 
		__Glucose_lab_test.Value;

	private CqlValueSet Hypoglycemics_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", null);

    [CqlDeclaration("Hypoglycemics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3")]
	public CqlValueSet Hypoglycemics() => 
		__Hypoglycemics.Value;

	private CqlValueSet Hypoglycemics_Severe_Hypoglycemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
	public CqlValueSet Hypoglycemics_Severe_Hypoglycemia() => 
		__Hypoglycemics_Severe_Hypoglycemia.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", e_);

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

	private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EncounterInpatient)
		{
			var e_ = EncounterInpatient?.StatusElement;
			var f_ = context.Operators.Convert<string>(e_);
			var g_ = context.Operators.Equal(f_, "finished");
			var h_ = EncounterInpatient?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = context.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.ElementInInterval<CqlDateTime>(j_, k_, null);
			var m_ = context.Operators.And(g_, l_);

			return m_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => 
		__Inpatient_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = this.Inpatient_Encounter_During_Measurement_Period();
		bool? b_(Encounter InpatientEncounter)
		{
			var d_ = this.Patient();
			var e_ = d_?.BirthDateElement;
			var f_ = e_?.Value;
			var g_ = context.Operators.ConvertStringToDateTime(f_);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
			var k_ = context.Operators.GreaterOrEqual(j_, (int?)18);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration HypoMedication)
		{
			var h_ = HypoMedication?.StatusElement;
			var i_ = context.Operators.Convert<string>(h_);
			var j_ = context.Operators.Equal(i_, "completed");
			var l_ = context.Operators.Convert<string>(h_);
			var m_ = context.Operators.Equal(l_, "not-done");
			var n_ = context.Operators.Not(m_);
			var o_ = context.Operators.And(j_, n_);

			return o_;
		};
		var g_ = context.Operators.WhereOrNull<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
	public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => 
		__Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			var d_ = this.Hypoglycemic_Medication_Administration();
			bool? e_(MedicationAdministration HypoglycemicMedication)
			{
				var i_ = HypoglycemicMedication?.Effective;
				var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
				var k_ = context.Operators.Start(j_);
				var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var m_ = context.Operators.ElementInInterval<CqlDateTime>(k_, l_, null);

				return m_;
			};
			var f_ = context.Operators.WhereOrNull<MedicationAdministration>(d_, e_);
			Encounter g_(MedicationAdministration HypoglycemicMedication) => 
				QualifyingEncounter;
			var h_ = context.Operators.SelectOrNull<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounter with Hypoglycemic Medication Administration")]
	public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration() => 
		__Qualifying_Encounter_with_Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event_Value()
	{
		var a_ = this.Denominator();
		bool? b_(Encounter QualifyingEncounter)
		{
			var d_ = this.Glucose_lab_test();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			IEnumerable<Observation> f_(Observation BloodGlucoseLab)
			{
				var r_ = this.Hypoglycemic_Medication_Administration();
				bool? s_(MedicationAdministration HypoglycemicMeds)
				{
					var w_ = HypoglycemicMeds?.Effective;
					var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
					var y_ = context.Operators.Start(x_);
					var z_ = BloodGlucoseLab?.Effective;
					var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
					var ab_ = context.Operators.Start(aa_);
					var ac_ = context.Operators.Quantity(24m, "hours");
					var ad_ = context.Operators.Subtract(ab_, ac_);
					var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
					var ag_ = context.Operators.Start(af_);
					var ah_ = context.Operators.Interval(ad_, ag_, true, true);
					var ai_ = context.Operators.ElementInInterval<CqlDateTime>(y_, ah_, null);
					var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
					var al_ = context.Operators.Start(ak_);
					var am_ = context.Operators.Not((bool?)(al_ is null));
					var an_ = context.Operators.And(ai_, am_);
					var ao_ = BloodGlucoseLab?.StatusElement;
					var ap_ = context.Operators.Convert<string>(ao_);
					var aq_ = context.Operators.Equal(ap_, "final");
					var ar_ = context.Operators.And(an_, aq_);
					var at_ = context.Operators.Convert<string>(ao_);
					var au_ = context.Operators.Equal(at_, "cancelled");
					var av_ = context.Operators.Not(au_);
					var aw_ = context.Operators.And(ar_, av_);
					var ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
					var az_ = context.Operators.Start(ay_);
					var ba_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var bb_ = context.Operators.ElementInInterval<CqlDateTime>(az_, ba_, null);
					var bc_ = context.Operators.And(aw_, bb_);

					return bc_;
				};
				var t_ = context.Operators.WhereOrNull<MedicationAdministration>(r_, s_);
				Observation u_(MedicationAdministration HypoglycemicMeds) => 
					BloodGlucoseLab;
				var v_ = context.Operators.SelectOrNull<MedicationAdministration, Observation>(t_, u_);

				return v_;
			};
			var g_ = context.Operators.SelectManyOrNull<Observation, Observation>(e_, f_);
			var i_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			IEnumerable<Observation> j_(Observation BloodGlucoseLab)
			{
				var bd_ = this.Hypoglycemic_Medication_Administration();
				bool? be_(MedicationAdministration HypoglycemicMeds)
				{
					var bi_ = HypoglycemicMeds?.Effective;
					var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
					var bk_ = context.Operators.Start(bj_);
					var bl_ = BloodGlucoseLab?.Effective;
					var bm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bl_);
					var bn_ = context.Operators.Start(bm_);
					var bo_ = context.Operators.Quantity(24m, "hours");
					var bp_ = context.Operators.Subtract(bn_, bo_);
					var br_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bl_);
					var bs_ = context.Operators.Start(br_);
					var bt_ = context.Operators.Interval(bp_, bs_, true, true);
					var bu_ = context.Operators.ElementInInterval<CqlDateTime>(bk_, bt_, null);
					var bw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bl_);
					var bx_ = context.Operators.Start(bw_);
					var by_ = context.Operators.Not((bool?)(bx_ is null));
					var bz_ = context.Operators.And(bu_, by_);
					var ca_ = BloodGlucoseLab?.StatusElement;
					var cb_ = context.Operators.Convert<string>(ca_);
					var cc_ = context.Operators.Equal(cb_, "final");
					var cd_ = context.Operators.And(bz_, cc_);
					var cf_ = context.Operators.Convert<string>(ca_);
					var cg_ = context.Operators.Equal(cf_, "cancelled");
					var ch_ = context.Operators.Not(cg_);
					var ci_ = context.Operators.And(cd_, ch_);
					var ck_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
					var cl_ = context.Operators.Start(ck_);
					var cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var cn_ = context.Operators.ElementInInterval<CqlDateTime>(cl_, cm_, null);
					var co_ = context.Operators.And(ci_, cn_);

					return co_;
				};
				var bf_ = context.Operators.WhereOrNull<MedicationAdministration>(bd_, be_);
				Observation bg_(MedicationAdministration HypoglycemicMeds) => 
					BloodGlucoseLab;
				var bh_ = context.Operators.SelectOrNull<MedicationAdministration, Observation>(bf_, bg_);

				return bh_;
			};
			var k_ = context.Operators.SelectManyOrNull<Observation, Observation>(i_, j_);
			IEnumerable<Observation> l_(Observation BloodGlucoseLab)
			{
				var cp_ = this.Glucose_lab_test();
				var cq_ = context.Operators.RetrieveByValueSet<Observation>(cp_, null);
				bool? cr_(Observation FollowupBloodGlucoseLab)
				{
					var cv_ = FollowupBloodGlucoseLab?.Effective;
					var cw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cv_);
					var cx_ = context.Operators.Start(cw_);
					var cy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var cz_ = context.Operators.ElementInInterval<CqlDateTime>(cx_, cy_, null);
					var db_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cv_);
					var dc_ = context.Operators.Start(db_);
					var dd_ = BloodGlucoseLab?.Effective;
					var de_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dd_);
					var df_ = context.Operators.Start(de_);
					var dh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dd_);
					var di_ = context.Operators.Start(dh_);
					var dj_ = context.Operators.Quantity(5m, "minutes");
					var dk_ = context.Operators.Add(di_, dj_);
					var dl_ = context.Operators.Interval(df_, dk_, false, true);
					var dm_ = context.Operators.ElementInInterval<CqlDateTime>(dc_, dl_, null);
					var do_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dd_);
					var dp_ = context.Operators.Start(do_);
					var dq_ = context.Operators.Not((bool?)(dp_ is null));
					var dr_ = context.Operators.And(dm_, dq_);
					var ds_ = context.Operators.And(cz_, dr_);
					var dt_ = FollowupBloodGlucoseLab?.StatusElement;
					var du_ = context.Operators.Convert<string>(dt_);
					var dv_ = context.Operators.Equal(du_, "final");
					var dw_ = context.Operators.And(ds_, dv_);
					var dy_ = context.Operators.Convert<string>(dt_);
					var dz_ = context.Operators.Equal(dy_, "cancelled");
					var ea_ = context.Operators.Not(dz_);
					var eb_ = context.Operators.And(dw_, ea_);
					var ec_ = FollowupBloodGlucoseLab?.Value;
					var ed_ = FHIRHelpers_4_0_001.ToQuantity((ec_ as Quantity));
					var ee_ = context.Operators.Quantity(80m, "mg/dL");
					var ef_ = context.Operators.Greater(ed_, ee_);
					var eg_ = context.Operators.And(eb_, ef_);

					return eg_;
				};
				var cs_ = context.Operators.WhereOrNull<Observation>(cq_, cr_);
				Observation ct_(Observation FollowupBloodGlucoseLab) => 
					BloodGlucoseLab;
				var cu_ = context.Operators.SelectOrNull<Observation, Observation>(cs_, ct_);

				return cu_;
			};
			var m_ = context.Operators.SelectManyOrNull<Observation, Observation>(k_, l_);
			var n_ = context.Operators.ListExcept<Observation>(g_, m_);
			bool? o_(Observation BloodGlucoseLab)
			{
				var eh_ = BloodGlucoseLab?.Effective;
				var ei_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(eh_);
				var ej_ = context.Operators.Start(ei_);
				var ek_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var el_ = context.Operators.ElementInInterval<CqlDateTime>(ej_, ek_, null);
				var em_ = BloodGlucoseLab?.Value;
				var en_ = FHIRHelpers_4_0_001.ToQuantity((em_ as Quantity));
				var eo_ = context.Operators.Quantity(40m, "mg/dL");
				var ep_ = context.Operators.Less(en_, eo_);
				var eq_ = context.Operators.And(el_, ep_);

				return eq_;
			};
			var p_ = context.Operators.WhereOrNull<Observation>(n_, o_);
			var q_ = context.Operators.ExistsInList<Observation>(p_);

			return q_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
	public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event() => 
		__Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Severe_Hypoglycemic_Harm_Event();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

}