using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", default);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date() => 
		__birth_date.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Glucose_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", default);

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
	public CqlValueSet Glucose_lab_test() => 
		__Glucose_lab_test.Value;

	private CqlValueSet Hypoglycemics_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", default);

    [CqlDeclaration("Hypoglycemics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3")]
	public CqlValueSet Hypoglycemics() => 
		__Hypoglycemics.Value;

	private CqlValueSet Hypoglycemics_Severe_Hypoglycemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", default);

    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
	public CqlValueSet Hypoglycemics_Severe_Hypoglycemia() => 
		__Hypoglycemics_Severe_Hypoglycemia.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
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
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		bool? c_(Encounter EncounterInpatient)
		{
			Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			bool? g_ = context.Operators.Equal(f_, "finished");
			Period h_ = EncounterInpatient?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			CqlDateTime j_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
			bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);
			bool? m_ = context.Operators.And(g_, l_);

			return m_;
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
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDateTime g_ = context.Operators.ConvertStringToDateTime(f_);
			CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			CqlDateTime i_ = context.Operators.Start(h_);
			int? j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
			bool? k_ = context.Operators.GreaterOrEqual(j_, 18);

			return k_;
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
		IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
		IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
		IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration HypoMedication)
		{
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> h_ = HypoMedication?.StatusElement;
			string i_ = FHIRHelpers_4_0_001.ToString(h_);
			bool? j_ = context.Operators.Equal(i_, "completed");
			string l_ = FHIRHelpers_4_0_001.ToString(h_);
			bool? m_ = context.Operators.Equal(l_, "not-done");
			bool? n_ = context.Operators.Not(m_);
			bool? o_ = context.Operators.And(j_, n_);

			return o_;
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
				DataType i_ = HypoglycemicMedication?.Effective;
				CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
				CqlDateTime k_ = context.Operators.Start(j_);
				CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, default);

				return m_;
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
			IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
			IEnumerable<Observation> f_(Observation BloodGlucoseLab)
			{
				IEnumerable<MedicationAdministration> r_ = this.Hypoglycemic_Medication_Administration();
				bool? s_(MedicationAdministration HypoglycemicMeds)
				{
					DataType w_ = HypoglycemicMeds?.Effective;
					CqlInterval<CqlDateTime> x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
					CqlDateTime y_ = context.Operators.Start(x_);
					DataType z_ = BloodGlucoseLab?.Effective;
					CqlInterval<CqlDateTime> aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
					CqlDateTime ab_ = context.Operators.Start(aa_);
					CqlQuantity ac_ = context.Operators.Quantity(24m, "hours");
					CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
					CqlInterval<CqlDateTime> af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
					CqlDateTime ag_ = context.Operators.Start(af_);
					CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ad_, ag_, true, true);
					bool? ai_ = context.Operators.In<CqlDateTime>(y_, ah_, default);
					CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(z_);
					CqlDateTime al_ = context.Operators.Start(ak_);
					bool? am_ = context.Operators.Not((bool?)(al_ is null));
					bool? an_ = context.Operators.And(ai_, am_);
					Code<ObservationStatus> ao_ = BloodGlucoseLab?.StatusElement;
					string ap_ = FHIRHelpers_4_0_001.ToString(ao_);
					bool? aq_ = context.Operators.Equal(ap_, "final");
					bool? ar_ = context.Operators.And(an_, aq_);
					string at_ = FHIRHelpers_4_0_001.ToString(ao_);
					bool? au_ = context.Operators.Equal(at_, "cancelled");
					bool? av_ = context.Operators.Not(au_);
					bool? aw_ = context.Operators.And(ar_, av_);
					CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(w_);
					CqlDateTime az_ = context.Operators.Start(ay_);
					CqlInterval<CqlDateTime> ba_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					bool? bb_ = context.Operators.In<CqlDateTime>(az_, ba_, default);
					bool? bc_ = context.Operators.And(aw_, bb_);

					return bc_;
				};
				IEnumerable<MedicationAdministration> t_ = context.Operators.Where<MedicationAdministration>(r_, s_);
				Observation u_(MedicationAdministration HypoglycemicMeds) => 
					BloodGlucoseLab;
				IEnumerable<Observation> v_ = context.Operators.Select<MedicationAdministration, Observation>(t_, u_);

				return v_;
			};
			IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
			IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
			IEnumerable<Observation> j_(Observation BloodGlucoseLab)
			{
				IEnumerable<MedicationAdministration> bd_ = this.Hypoglycemic_Medication_Administration();
				bool? be_(MedicationAdministration HypoglycemicMeds)
				{
					DataType bi_ = HypoglycemicMeds?.Effective;
					CqlInterval<CqlDateTime> bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
					CqlDateTime bk_ = context.Operators.Start(bj_);
					DataType bl_ = BloodGlucoseLab?.Effective;
					CqlInterval<CqlDateTime> bm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bl_);
					CqlDateTime bn_ = context.Operators.Start(bm_);
					CqlQuantity bo_ = context.Operators.Quantity(24m, "hours");
					CqlDateTime bp_ = context.Operators.Subtract(bn_, bo_);
					CqlInterval<CqlDateTime> br_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bl_);
					CqlDateTime bs_ = context.Operators.Start(br_);
					CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bp_, bs_, true, true);
					bool? bu_ = context.Operators.In<CqlDateTime>(bk_, bt_, default);
					CqlInterval<CqlDateTime> bw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bl_);
					CqlDateTime bx_ = context.Operators.Start(bw_);
					bool? by_ = context.Operators.Not((bool?)(bx_ is null));
					bool? bz_ = context.Operators.And(bu_, by_);
					Code<ObservationStatus> ca_ = BloodGlucoseLab?.StatusElement;
					string cb_ = FHIRHelpers_4_0_001.ToString(ca_);
					bool? cc_ = context.Operators.Equal(cb_, "final");
					bool? cd_ = context.Operators.And(bz_, cc_);
					string cf_ = FHIRHelpers_4_0_001.ToString(ca_);
					bool? cg_ = context.Operators.Equal(cf_, "cancelled");
					bool? ch_ = context.Operators.Not(cg_);
					bool? ci_ = context.Operators.And(cd_, ch_);
					CqlInterval<CqlDateTime> ck_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
					CqlDateTime cl_ = context.Operators.Start(ck_);
					CqlInterval<CqlDateTime> cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					bool? cn_ = context.Operators.In<CqlDateTime>(cl_, cm_, default);
					bool? co_ = context.Operators.And(ci_, cn_);

					return co_;
				};
				IEnumerable<MedicationAdministration> bf_ = context.Operators.Where<MedicationAdministration>(bd_, be_);
				Observation bg_(MedicationAdministration HypoglycemicMeds) => 
					BloodGlucoseLab;
				IEnumerable<Observation> bh_ = context.Operators.Select<MedicationAdministration, Observation>(bf_, bg_);

				return bh_;
			};
			IEnumerable<Observation> k_ = context.Operators.SelectMany<Observation, Observation>(i_, j_);
			IEnumerable<Observation> l_(Observation BloodGlucoseLab)
			{
				CqlValueSet cp_ = this.Glucose_lab_test();
				IEnumerable<Observation> cq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, cp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
				bool? cr_(Observation FollowupBloodGlucoseLab)
				{
					DataType cv_ = FollowupBloodGlucoseLab?.Effective;
					CqlInterval<CqlDateTime> cw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cv_);
					CqlDateTime cx_ = context.Operators.Start(cw_);
					CqlInterval<CqlDateTime> cy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					bool? cz_ = context.Operators.In<CqlDateTime>(cx_, cy_, default);
					CqlInterval<CqlDateTime> db_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cv_);
					CqlDateTime dc_ = context.Operators.Start(db_);
					DataType dd_ = BloodGlucoseLab?.Effective;
					CqlInterval<CqlDateTime> de_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dd_);
					CqlDateTime df_ = context.Operators.Start(de_);
					CqlInterval<CqlDateTime> dh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dd_);
					CqlDateTime di_ = context.Operators.Start(dh_);
					CqlQuantity dj_ = context.Operators.Quantity(5m, "minutes");
					CqlDateTime dk_ = context.Operators.Add(di_, dj_);
					CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(df_, dk_, false, true);
					bool? dm_ = context.Operators.In<CqlDateTime>(dc_, dl_, default);
					CqlInterval<CqlDateTime> do_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dd_);
					CqlDateTime dp_ = context.Operators.Start(do_);
					bool? dq_ = context.Operators.Not((bool?)(dp_ is null));
					bool? dr_ = context.Operators.And(dm_, dq_);
					bool? ds_ = context.Operators.And(cz_, dr_);
					Code<ObservationStatus> dt_ = FollowupBloodGlucoseLab?.StatusElement;
					string du_ = FHIRHelpers_4_0_001.ToString(dt_);
					bool? dv_ = context.Operators.Equal(du_, "final");
					bool? dw_ = context.Operators.And(ds_, dv_);
					string dy_ = FHIRHelpers_4_0_001.ToString(dt_);
					bool? dz_ = context.Operators.Equal(dy_, "cancelled");
					bool? ea_ = context.Operators.Not(dz_);
					bool? eb_ = context.Operators.And(dw_, ea_);
					DataType ec_ = FollowupBloodGlucoseLab?.Value;
					CqlQuantity ed_ = FHIRHelpers_4_0_001.ToQuantity(ec_ as Quantity);
					CqlQuantity ee_ = context.Operators.Quantity(80m, "mg/dL");
					bool? ef_ = context.Operators.Greater(ed_, ee_);
					bool? eg_ = context.Operators.And(eb_, ef_);

					return eg_;
				};
				IEnumerable<Observation> cs_ = context.Operators.Where<Observation>(cq_, cr_);
				Observation ct_(Observation FollowupBloodGlucoseLab) => 
					BloodGlucoseLab;
				IEnumerable<Observation> cu_ = context.Operators.Select<Observation, Observation>(cs_, ct_);

				return cu_;
			};
			IEnumerable<Observation> m_ = context.Operators.SelectMany<Observation, Observation>(k_, l_);
			IEnumerable<Observation> n_ = context.Operators.Except<Observation>(g_, m_);
			bool? o_(Observation BloodGlucoseLab)
			{
				DataType eh_ = BloodGlucoseLab?.Effective;
				CqlInterval<CqlDateTime> ei_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(eh_);
				CqlDateTime ej_ = context.Operators.Start(ei_);
				CqlInterval<CqlDateTime> ek_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				bool? el_ = context.Operators.In<CqlDateTime>(ej_, ek_, default);
				DataType em_ = BloodGlucoseLab?.Value;
				CqlQuantity en_ = FHIRHelpers_4_0_001.ToQuantity(em_ as Quantity);
				CqlQuantity eo_ = context.Operators.Quantity(40m, "mg/dL");
				bool? ep_ = context.Operators.Less(en_, eo_);
				bool? eq_ = context.Operators.And(el_, ep_);

				return eq_;
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
