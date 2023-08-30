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
		var a_ = context.Operators;
		var d_ = a_.ConvertIntegerToDecimal(default);
		var e_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		var h_ = a_.ConvertIntegerToDecimal(default);
		var i_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, h_);
		var j_ = a_.Interval(e_, i_, true, false);
		var k_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", j_);

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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Encounter_Inpatient();
		var d_ = b_.RetrieveByValueSet<Encounter>(c_, null);
		bool? e_(Encounter EncounterInpatient)
		{
			var g_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = EncounterInpatient?.StatusElement;
			var m_ = k_.Convert<string>(l_);
			var n_ = g_.Equal(m_, "finished");
			var q_ = EncounterInpatient?.Period;
			var r_ = FHIRHelpers_4_0_001.ToInterval(q_);
			var s_ = g_.End(r_);
			var t_ = this.Measurement_Period();
			var u_ = g_.ElementInInterval<CqlDateTime>(s_, t_, null);
			var v_ = g_.And(n_, u_);

			return v_;
		};
		var f_ = a_.WhereOrNull<Encounter>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => 
		__Inpatient_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Inpatient_Encounter_During_Measurement_Period();
		bool? c_(Encounter InpatientEncounter)
		{
			var e_ = context.Operators;
			var h_ = this.Patient();
			var i_ = h_?.BirthDateElement;
			var j_ = i_?.Value;
			var k_ = e_.ConvertStringToDateTime(j_);
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var n_ = e_.Start(m_);
			var o_ = e_.CalculateAgeAt(k_, n_, "year");
			var p_ = e_.GreaterOrEqual(o_, (int?)18);

			return p_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var e_ = c_.RetrieveByValueSet<MedicationAdministration>(d_, null);
		var h_ = c_.RetrieveByValueSet<MedicationAdministration>(d_, null);
		var i_ = a_.ListUnion<MedicationAdministration>(e_, h_);
		bool? j_(MedicationAdministration HypoMedication)
		{
			var l_ = context.Operators;
			var n_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = HypoMedication?.StatusElement;
			var r_ = p_.Convert<string>(q_);
			var s_ = l_.Equal(r_, "completed");
			var w_ = n_.Operators;
			var x_ = w_.TypeConverter;
			var z_ = x_.Convert<string>(q_);
			var aa_ = l_.Equal(z_, "not-done");
			var ab_ = l_.Not(aa_);
			var ac_ = l_.And(s_, ab_);

			return ac_;
		};
		var k_ = a_.WhereOrNull<MedicationAdministration>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
	public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => 
		__Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> c_(Encounter QualifyingEncounter)
		{
			var e_ = context.Operators;
			var g_ = this.Hypoglycemic_Medication_Administration();
			bool? h_(MedicationAdministration HypoglycemicMedication)
			{
				var l_ = context.Operators;
				var n_ = HypoglycemicMedication?.Effective;
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(n_);
				var p_ = l_.Start(o_);
				var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var r_ = l_.ElementInInterval<CqlDateTime>(p_, q_, null);

				return r_;
			};
			var i_ = e_.WhereOrNull<MedicationAdministration>(g_, h_);
			Encounter j_(MedicationAdministration HypoglycemicMedication) => 
				QualifyingEncounter;
			var k_ = e_.SelectOrNull<MedicationAdministration, Encounter>(i_, j_);

			return k_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
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
		var a_ = context.Operators;
		var b_ = this.Denominator();
		bool? c_(Encounter QualifyingEncounter)
		{
			var e_ = context.Operators;
			var i_ = context.DataRetriever;
			var j_ = this.Glucose_lab_test();
			var k_ = i_.RetrieveByValueSet<Observation>(j_, null);
			IEnumerable<Observation> l_(Observation BloodGlucoseLab)
			{
				var aa_ = context.Operators;
				var ac_ = this.Hypoglycemic_Medication_Administration();
				bool? ad_(MedicationAdministration HypoglycemicMeds)
				{
					var ah_ = context.Operators;
					var an_ = HypoglycemicMeds?.Effective;
					var ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(an_);
					var ap_ = ah_.Start(ao_);
					var at_ = BloodGlucoseLab?.Effective;
					var au_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(at_);
					var av_ = ah_.Start(au_);
					var ax_ = ah_.Quantity(24m, "hours");
					var ay_ = ah_.Subtract(av_, ax_);
					var bb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(at_);
					var bc_ = ah_.Start(bb_);
					var bd_ = ah_.Interval(ay_, bc_, true, true);
					var be_ = ah_.ElementInInterval<CqlDateTime>(ap_, bd_, null);
					var bi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(at_);
					var bj_ = ah_.Start(bi_);
					var bk_ = ah_.Not((bool?)(bj_ is null));
					var bl_ = ah_.And(be_, bk_);
					var bn_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var bo_ = bn_.Operators;
					var bp_ = bo_.TypeConverter;
					var bq_ = BloodGlucoseLab?.StatusElement;
					var br_ = bp_.Convert<string>(bq_);
					var bs_ = ah_.Equal(br_, "final");
					var bt_ = ah_.And(bl_, bs_);
					var bx_ = bn_.Operators;
					var by_ = bx_.TypeConverter;
					var ca_ = by_.Convert<string>(bq_);
					var cb_ = ah_.Equal(ca_, "cancelled");
					var cc_ = ah_.Not(cb_);
					var cd_ = ah_.And(bt_, cc_);
					var ch_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(an_);
					var ci_ = ah_.Start(ch_);
					var cj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var ck_ = ah_.ElementInInterval<CqlDateTime>(ci_, cj_, null);
					var cl_ = ah_.And(cd_, ck_);

					return cl_;
				};
				var ae_ = aa_.WhereOrNull<MedicationAdministration>(ac_, ad_);
				Observation af_(MedicationAdministration HypoglycemicMeds) => 
					BloodGlucoseLab;
				var ag_ = aa_.SelectOrNull<MedicationAdministration, Observation>(ae_, af_);

				return ag_;
			};
			var m_ = e_.SelectManyOrNull<Observation, Observation>(k_, l_);
			var r_ = i_.RetrieveByValueSet<Observation>(j_, null);
			IEnumerable<Observation> s_(Observation BloodGlucoseLab)
			{
				var cm_ = context.Operators;
				var co_ = this.Hypoglycemic_Medication_Administration();
				bool? cp_(MedicationAdministration HypoglycemicMeds)
				{
					var ct_ = context.Operators;
					var cz_ = HypoglycemicMeds?.Effective;
					var da_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cz_);
					var db_ = ct_.Start(da_);
					var df_ = BloodGlucoseLab?.Effective;
					var dg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(df_);
					var dh_ = ct_.Start(dg_);
					var dj_ = ct_.Quantity(24m, "hours");
					var dk_ = ct_.Subtract(dh_, dj_);
					var dn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(df_);
					var do_ = ct_.Start(dn_);
					var dp_ = ct_.Interval(dk_, do_, true, true);
					var dq_ = ct_.ElementInInterval<CqlDateTime>(db_, dp_, null);
					var du_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(df_);
					var dv_ = ct_.Start(du_);
					var dw_ = ct_.Not((bool?)(dv_ is null));
					var dx_ = ct_.And(dq_, dw_);
					var dz_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var ea_ = dz_.Operators;
					var eb_ = ea_.TypeConverter;
					var ec_ = BloodGlucoseLab?.StatusElement;
					var ed_ = eb_.Convert<string>(ec_);
					var ee_ = ct_.Equal(ed_, "final");
					var ef_ = ct_.And(dx_, ee_);
					var ej_ = dz_.Operators;
					var ek_ = ej_.TypeConverter;
					var em_ = ek_.Convert<string>(ec_);
					var en_ = ct_.Equal(em_, "cancelled");
					var eo_ = ct_.Not(en_);
					var ep_ = ct_.And(ef_, eo_);
					var et_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cz_);
					var eu_ = ct_.Start(et_);
					var ev_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var ew_ = ct_.ElementInInterval<CqlDateTime>(eu_, ev_, null);
					var ex_ = ct_.And(ep_, ew_);

					return ex_;
				};
				var cq_ = cm_.WhereOrNull<MedicationAdministration>(co_, cp_);
				Observation cr_(MedicationAdministration HypoglycemicMeds) => 
					BloodGlucoseLab;
				var cs_ = cm_.SelectOrNull<MedicationAdministration, Observation>(cq_, cr_);

				return cs_;
			};
			var t_ = e_.SelectManyOrNull<Observation, Observation>(r_, s_);
			IEnumerable<Observation> u_(Observation BloodGlucoseLab)
			{
				var ey_ = context.Operators;
				var fa_ = context.DataRetriever;
				var fb_ = this.Glucose_lab_test();
				var fc_ = fa_.RetrieveByValueSet<Observation>(fb_, null);
				bool? fd_(Observation FollowupBloodGlucoseLab)
				{
					var fh_ = context.Operators;
					var fn_ = FollowupBloodGlucoseLab?.Effective;
					var fo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fn_);
					var fp_ = fh_.Start(fo_);
					var fq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var fr_ = fh_.ElementInInterval<CqlDateTime>(fp_, fq_, null);
					var fw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fn_);
					var fx_ = fh_.Start(fw_);
					var ga_ = BloodGlucoseLab?.Effective;
					var gb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ga_);
					var gc_ = fh_.Start(gb_);
					var gg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ga_);
					var gh_ = fh_.Start(gg_);
					var gj_ = fh_.Quantity(5m, "minutes");
					var gk_ = fh_.Add(gh_, gj_);
					var gl_ = fh_.Interval(gc_, gk_, false, true);
					var gm_ = fh_.ElementInInterval<CqlDateTime>(fx_, gl_, null);
					var gq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ga_);
					var gr_ = fh_.Start(gq_);
					var gs_ = fh_.Not((bool?)(gr_ is null));
					var gt_ = fh_.And(gm_, gs_);
					var gu_ = fh_.And(fr_, gt_);
					var gw_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var gx_ = gw_.Operators;
					var gy_ = gx_.TypeConverter;
					var gz_ = FollowupBloodGlucoseLab?.StatusElement;
					var ha_ = gy_.Convert<string>(gz_);
					var hb_ = fh_.Equal(ha_, "final");
					var hc_ = fh_.And(gu_, hb_);
					var hg_ = gw_.Operators;
					var hh_ = hg_.TypeConverter;
					var hj_ = hh_.Convert<string>(gz_);
					var hk_ = fh_.Equal(hj_, "cancelled");
					var hl_ = fh_.Not(hk_);
					var hm_ = fh_.And(hc_, hl_);
					var ho_ = FollowupBloodGlucoseLab?.Value;
					var hp_ = FHIRHelpers_4_0_001.ToQuantity((ho_ as Quantity));
					var hr_ = fh_.Quantity(80m, "mg/dL");
					var hs_ = fh_.Greater(hp_, hr_);
					var ht_ = fh_.And(hm_, hs_);

					return ht_;
				};
				var fe_ = ey_.WhereOrNull<Observation>(fc_, fd_);
				Observation ff_(Observation FollowupBloodGlucoseLab) => 
					BloodGlucoseLab;
				var fg_ = ey_.SelectOrNull<Observation, Observation>(fe_, ff_);

				return fg_;
			};
			var v_ = e_.SelectManyOrNull<Observation, Observation>(t_, u_);
			var w_ = e_.ListExcept<Observation>(m_, v_);
			bool? x_(Observation BloodGlucoseLab)
			{
				var hu_ = context.Operators;
				var hx_ = BloodGlucoseLab?.Effective;
				var hy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(hx_);
				var hz_ = hu_.Start(hy_);
				var ia_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var ib_ = hu_.ElementInInterval<CqlDateTime>(hz_, ia_, null);
				var id_ = BloodGlucoseLab?.Value;
				var ie_ = FHIRHelpers_4_0_001.ToQuantity((id_ as Quantity));
				var ig_ = hu_.Quantity(40m, "mg/dL");
				var ih_ = hu_.Less(ie_, ig_);
				var ii_ = hu_.And(ib_, ih_);

				return ii_;
			};
			var y_ = e_.WhereOrNull<Observation>(w_, x_);
			var z_ = e_.ExistsInList<Observation>(y_);

			return z_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
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