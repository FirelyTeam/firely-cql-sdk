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
    internal Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EncounterInpatient)
		{
			string e_ = context.Operators.Convert<string>(EncounterInpatient?.StatusElement);
			bool? f_ = context.Operators.Equal(e_, "finished");
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_0_001.ToInterval(EncounterInpatient?.Period);
			CqlDateTime h_ = context.Operators.End(g_);
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period();
			bool? j_ = context.Operators.In<CqlDateTime>(h_, i_, null);
			bool? k_ = context.Operators.And(f_, j_);

			return k_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
	public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => 
		__Inpatient_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounter_During_Measurement_Period();
		bool? b_(Encounter InpatientEncounter)
		{
			Patient d_ = this.Patient();
			CqlDateTime e_ = context.Operators.ConvertStringToDateTime(d_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			CqlDateTime g_ = context.Operators.Start(f_);
			int? h_ = context.Operators.CalculateAgeAt(e_, g_, "year");
			bool? i_ = context.Operators.GreaterOrEqual(h_, 18);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		CqlValueSet a_ = this.Hypoglycemics_Severe_Hypoglycemia();
		IEnumerable<MedicationAdministration> b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		IEnumerable<MedicationAdministration> d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		IEnumerable<MedicationAdministration> e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration HypoMedication)
		{
			string h_ = context.Operators.Convert<string>(HypoMedication?.StatusElement);
			bool? i_ = context.Operators.Equal(h_, "completed");
			bool? k_ = context.Operators.Equal(h_, "not-done");
			bool? l_ = context.Operators.Not(k_);
			bool? m_ = context.Operators.And(i_, l_);

			return m_;
		};
		IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
	public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => 
		__Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			IEnumerable<MedicationAdministration> d_ = this.Hypoglycemic_Medication_Administration();
			bool? e_(MedicationAdministration HypoglycemicMedication)
			{
				CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(HypoglycemicMedication?.Effective);
				CqlDateTime j_ = context.Operators.Start(i_);
				CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, null);

				return l_;
			};
			IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
			Encounter g_(MedicationAdministration HypoglycemicMedication) => 
				QualifyingEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Qualifying Encounter with Hypoglycemic Medication Administration")]
	public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration() => 
		__Qualifying_Encounter_with_Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		bool? b_(Encounter QualifyingEncounter)
		{
			CqlValueSet d_ = this.Glucose_lab_test();
			IEnumerable<Observation> e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			IEnumerable<Observation> f_(Observation BloodGlucoseLab)
			{
				IEnumerable<MedicationAdministration> r_ = this.Hypoglycemic_Medication_Administration();
				bool? s_(MedicationAdministration HypoglycemicMeds)
				{
					CqlInterval<CqlDateTime> w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(HypoglycemicMeds?.Effective);
					CqlDateTime x_ = context.Operators.Start(w_);
					CqlInterval<CqlDateTime> y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(BloodGlucoseLab?.Effective);
					CqlDateTime z_ = context.Operators.Start(y_);
					CqlQuantity aa_ = context.Operators.Quantity(24m, "hours");
					CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
					CqlDateTime ad_ = context.Operators.Start(y_);
					CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, true);
					bool? af_ = context.Operators.In<CqlDateTime>(x_, ae_, null);
					CqlDateTime ah_ = context.Operators.Start(y_);
					bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
					bool? aj_ = context.Operators.And(af_, ai_);
					string ak_ = context.Operators.Convert<string>(BloodGlucoseLab?.StatusElement);
					bool? al_ = context.Operators.Equal(ak_, "final");
					bool? am_ = context.Operators.And(aj_, al_);
					bool? ao_ = context.Operators.Equal(ak_, "cancelled");
					bool? ap_ = context.Operators.Not(ao_);
					bool? aq_ = context.Operators.And(am_, ap_);
					CqlDateTime as_ = context.Operators.Start(w_);
					CqlInterval<CqlDateTime> at_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, null);
					bool? av_ = context.Operators.And(aq_, au_);

					return av_;
				};
				IEnumerable<MedicationAdministration> t_ = context.Operators.Where<MedicationAdministration>(r_, s_);
				Observation u_(MedicationAdministration HypoglycemicMeds) => 
					BloodGlucoseLab;
				IEnumerable<Observation> v_ = context.Operators.Select<MedicationAdministration, Observation>(t_, u_);

				return v_;
			};
			IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
			IEnumerable<Observation> i_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			IEnumerable<Observation> j_(Observation BloodGlucoseLab)
			{
				IEnumerable<MedicationAdministration> aw_ = this.Hypoglycemic_Medication_Administration();
				bool? ax_(MedicationAdministration HypoglycemicMeds)
				{
					CqlInterval<CqlDateTime> bb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(HypoglycemicMeds?.Effective);
					CqlDateTime bc_ = context.Operators.Start(bb_);
					CqlInterval<CqlDateTime> bd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(BloodGlucoseLab?.Effective);
					CqlDateTime be_ = context.Operators.Start(bd_);
					CqlQuantity bf_ = context.Operators.Quantity(24m, "hours");
					CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
					CqlDateTime bi_ = context.Operators.Start(bd_);
					CqlInterval<CqlDateTime> bj_ = context.Operators.Interval(bg_, bi_, true, true);
					bool? bk_ = context.Operators.In<CqlDateTime>(bc_, bj_, null);
					CqlDateTime bm_ = context.Operators.Start(bd_);
					bool? bn_ = context.Operators.Not((bool?)(bm_ is null));
					bool? bo_ = context.Operators.And(bk_, bn_);
					string bp_ = context.Operators.Convert<string>(BloodGlucoseLab?.StatusElement);
					bool? bq_ = context.Operators.Equal(bp_, "final");
					bool? br_ = context.Operators.And(bo_, bq_);
					bool? bt_ = context.Operators.Equal(bp_, "cancelled");
					bool? bu_ = context.Operators.Not(bt_);
					bool? bv_ = context.Operators.And(br_, bu_);
					CqlDateTime bx_ = context.Operators.Start(bb_);
					CqlInterval<CqlDateTime> by_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					bool? bz_ = context.Operators.In<CqlDateTime>(bx_, by_, null);
					bool? ca_ = context.Operators.And(bv_, bz_);

					return ca_;
				};
				IEnumerable<MedicationAdministration> ay_ = context.Operators.Where<MedicationAdministration>(aw_, ax_);
				Observation az_(MedicationAdministration HypoglycemicMeds) => 
					BloodGlucoseLab;
				IEnumerable<Observation> ba_ = context.Operators.Select<MedicationAdministration, Observation>(ay_, az_);

				return ba_;
			};
			IEnumerable<Observation> k_ = context.Operators.SelectMany<Observation, Observation>(i_, j_);
			IEnumerable<Observation> l_(Observation BloodGlucoseLab)
			{
				CqlValueSet cb_ = this.Glucose_lab_test();
				IEnumerable<Observation> cc_ = context.Operators.RetrieveByValueSet<Observation>(cb_, null);
				bool? cd_(Observation FollowupBloodGlucoseLab)
				{
					CqlInterval<CqlDateTime> ch_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(FollowupBloodGlucoseLab?.Effective);
					CqlDateTime ci_ = context.Operators.Start(ch_);
					CqlInterval<CqlDateTime> cj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					bool? ck_ = context.Operators.In<CqlDateTime>(ci_, cj_, null);
					CqlDateTime cm_ = context.Operators.Start(ch_);
					CqlInterval<CqlDateTime> cn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(BloodGlucoseLab?.Effective);
					CqlDateTime co_ = context.Operators.Start(cn_);
					CqlDateTime cq_ = context.Operators.Start(cn_);
					CqlQuantity cr_ = context.Operators.Quantity(5m, "minutes");
					CqlDateTime cs_ = context.Operators.Add(cq_, cr_);
					CqlInterval<CqlDateTime> ct_ = context.Operators.Interval(co_, cs_, false, true);
					bool? cu_ = context.Operators.In<CqlDateTime>(cm_, ct_, null);
					CqlDateTime cw_ = context.Operators.Start(cn_);
					bool? cx_ = context.Operators.Not((bool?)(cw_ is null));
					bool? cy_ = context.Operators.And(cu_, cx_);
					bool? cz_ = context.Operators.And(ck_, cy_);
					string da_ = context.Operators.Convert<string>(FollowupBloodGlucoseLab?.StatusElement);
					bool? db_ = context.Operators.Equal(da_, "final");
					bool? dc_ = context.Operators.And(cz_, db_);
					bool? de_ = context.Operators.Equal(da_, "cancelled");
					bool? df_ = context.Operators.Not(de_);
					bool? dg_ = context.Operators.And(dc_, df_);
					CqlQuantity dh_ = FHIRHelpers_4_0_001.ToQuantity((FollowupBloodGlucoseLab?.Value as Quantity));
					CqlQuantity di_ = context.Operators.Quantity(80m, "mg/dL");
					bool? dj_ = context.Operators.Greater(dh_, di_);
					bool? dk_ = context.Operators.And(dg_, dj_);

					return dk_;
				};
				IEnumerable<Observation> ce_ = context.Operators.Where<Observation>(cc_, cd_);
				Observation cf_(Observation FollowupBloodGlucoseLab) => 
					BloodGlucoseLab;
				IEnumerable<Observation> cg_ = context.Operators.Select<Observation, Observation>(ce_, cf_);

				return cg_;
			};
			IEnumerable<Observation> m_ = context.Operators.SelectMany<Observation, Observation>(k_, l_);
			IEnumerable<Observation> n_ = context.Operators.ListExcept<Observation>(g_, m_);
			bool? o_(Observation BloodGlucoseLab)
			{
				CqlInterval<CqlDateTime> dl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(BloodGlucoseLab?.Effective);
				CqlDateTime dm_ = context.Operators.Start(dl_);
				CqlInterval<CqlDateTime> dn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				bool? do_ = context.Operators.In<CqlDateTime>(dm_, dn_, null);
				CqlQuantity dp_ = FHIRHelpers_4_0_001.ToQuantity((BloodGlucoseLab?.Value as Quantity));
				CqlQuantity dq_ = context.Operators.Quantity(40m, "mg/dL");
				bool? dr_ = context.Operators.Less(dp_, dq_);
				bool? ds_ = context.Operators.And(do_, dr_);

				return ds_;
			};
			IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
			bool? q_ = context.Operators.Exists<Observation>(p_);

			return q_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
	public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event() => 
		__Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Severe_Hypoglycemic_Harm_Event();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

}
