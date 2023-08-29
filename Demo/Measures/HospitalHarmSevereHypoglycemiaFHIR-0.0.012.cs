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

    private CqlCode Birth_date_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var b_ = a_.ConvertIntegerToDecimal(default);
		var d_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, b_);
		var f_ = a_.ConvertIntegerToDecimal(default);
		var h_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, f_);
		var j_ = a_.Interval(d_, h_, true, false);
		var k_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		bool? d_(Encounter EncounterInpatient)
		{
			var g_ = EncounterInpatient?.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "finished");
			var o_ = EncounterInpatient?.Period;
			var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var r_ = m_.End(p_);
			var s_ = this.Measurement_Period();
			var u_ = m_.ElementInInterval<CqlDateTime>(r_, s_, null);
			var w_ = m_.And(n_, u_);

			return w_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => __Inpatient_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = this.Inpatient_Encounter_During_Measurement_Period();
		bool? b_(Encounter InpatientEncounter)
		{
			var e_ = this.Patient();
			var f_ = e_?.BirthDateElement;
			var g_ = f_?.Value;
			var h_ = context.Operators;
			var i_ = h_.ConvertStringToDateTime(g_);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var l_ = h_.Start(j_);
			var n_ = h_.CalculateAgeAt(i_, l_, "year");
			var p_ = h_.GreaterOrEqual(n_, (int?)18);

			return p_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter() => __Qualifying_Encounter.Value;

    private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var f_ = b_.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<MedicationAdministration>(c_, f_);
		bool? i_(MedicationAdministration HypoMedication)
		{
			var l_ = HypoMedication?.StatusElement;
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var r_ = context.Operators;
			var s_ = r_.Equal(q_, "completed");
			var v_ = context.Deeper(m_);
			var w_ = v_.Operators;
			var x_ = w_.TypeConverter;
			var y_ = x_.Convert<string>(l_);
			var aa_ = r_.Equal(y_, "not-done");
			var ac_ = r_.Not(aa_);
			var ae_ = r_.And(s_, ac_);

			return ae_;
		};
		var k_ = g_.WhereOrNull<MedicationAdministration>(h_, i_);

		return k_;
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => __Hypoglycemic_Medication_Administration.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			var e_ = this.Hypoglycemic_Medication_Administration();
			bool? f_(MedicationAdministration HypoglycemicMedication)
			{
				var l_ = HypoglycemicMedication?.Effective;
				var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
				var n_ = context.Operators;
				var o_ = n_.Start(m_);
				var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var r_ = n_.ElementInInterval<CqlDateTime>(o_, p_, null);

				return r_;
			};
			var g_ = context.Operators;
			var h_ = g_.WhereOrNull<MedicationAdministration>(e_, f_);
			Encounter i_(MedicationAdministration HypoglycemicMedication) => QualifyingEncounter;
			var k_ = g_.SelectOrNull<MedicationAdministration, Encounter>(h_, i_);

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration() => __Qualifying_Encounter_with_Hypoglycemic_Medication_Administration.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    private IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event_Value()
	{
		var a_ = this.Denominator();
		bool? b_(Encounter QualifyingEncounter)
		{
			var e_ = this.Glucose_lab_test();
			var f_ = context.DataRetriever;
			var g_ = f_.RetrieveByValueSet<Observation>(e_, null);
			IEnumerable<Observation> h_(Observation BloodGlucoseLab)
			{
				var aa_ = this.Hypoglycemic_Medication_Administration();
				bool? ab_(MedicationAdministration HypoglycemicMeds)
				{
					var ah_ = HypoglycemicMeds?.Effective;
					var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ah_);
					var aj_ = context.Operators;
					var ak_ = aj_.Start(ai_);
					var al_ = BloodGlucoseLab?.Effective;
					var am_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(al_);
					var ao_ = aj_.Start(am_);
					var aq_ = aj_.Quantity(24m, "hours");
					var as_ = aj_.Subtract(ao_, aq_);
					var au_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(al_);
					var aw_ = aj_.Start(au_);
					var ay_ = aj_.Interval(as_, aw_, true, true);
					var ba_ = aj_.ElementInInterval<CqlDateTime>(ak_, ay_, null);
					var bc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(al_);
					var be_ = aj_.Start(bc_);
					var bg_ = aj_.Not((bool?)(be_ is null));
					var bi_ = aj_.And(ba_, bg_);
					var bj_ = BloodGlucoseLab?.StatusElement;
					var bk_ = new CallStackEntry("ToString", null, null);
					var bl_ = context.Deeper(bk_);
					var bm_ = bl_.Operators;
					var bn_ = bm_.TypeConverter;
					var bo_ = bn_.Convert<string>(bj_);
					var bq_ = aj_.Equal(bo_, "final");
					var bs_ = aj_.And(bi_, bq_);
					var bv_ = context.Deeper(bk_);
					var bw_ = bv_.Operators;
					var bx_ = bw_.TypeConverter;
					var by_ = bx_.Convert<string>(bj_);
					var ca_ = aj_.Equal(by_, "cancelled");
					var cc_ = aj_.Not(ca_);
					var ce_ = aj_.And(bs_, cc_);
					var cg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ah_);
					var ci_ = aj_.Start(cg_);
					var cj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var cl_ = aj_.ElementInInterval<CqlDateTime>(ci_, cj_, null);
					var cn_ = aj_.And(ce_, cl_);

					return cn_;
				};
				var ac_ = context.Operators;
				var ad_ = ac_.WhereOrNull<MedicationAdministration>(aa_, ab_);
				Observation ae_(MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;
				var ag_ = ac_.SelectOrNull<MedicationAdministration, Observation>(ad_, ae_);

				return ag_;
			};
			var i_ = context.Operators;
			var j_ = i_.SelectManyOrNull<Observation, Observation>(g_, h_);
			var m_ = f_.RetrieveByValueSet<Observation>(e_, null);
			IEnumerable<Observation> n_(Observation BloodGlucoseLab)
			{
				var co_ = this.Hypoglycemic_Medication_Administration();
				bool? cp_(MedicationAdministration HypoglycemicMeds)
				{
					var cv_ = HypoglycemicMeds?.Effective;
					var cw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cv_);
					var cx_ = context.Operators;
					var cy_ = cx_.Start(cw_);
					var cz_ = BloodGlucoseLab?.Effective;
					var da_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cz_);
					var dc_ = cx_.Start(da_);
					var de_ = cx_.Quantity(24m, "hours");
					var dg_ = cx_.Subtract(dc_, de_);
					var di_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cz_);
					var dk_ = cx_.Start(di_);
					var dm_ = cx_.Interval(dg_, dk_, true, true);
					var do_ = cx_.ElementInInterval<CqlDateTime>(cy_, dm_, null);
					var dq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cz_);
					var ds_ = cx_.Start(dq_);
					var du_ = cx_.Not((bool?)(ds_ is null));
					var dw_ = cx_.And(do_, du_);
					var dx_ = BloodGlucoseLab?.StatusElement;
					var dy_ = new CallStackEntry("ToString", null, null);
					var dz_ = context.Deeper(dy_);
					var ea_ = dz_.Operators;
					var eb_ = ea_.TypeConverter;
					var ec_ = eb_.Convert<string>(dx_);
					var ee_ = cx_.Equal(ec_, "final");
					var eg_ = cx_.And(dw_, ee_);
					var ej_ = context.Deeper(dy_);
					var ek_ = ej_.Operators;
					var el_ = ek_.TypeConverter;
					var em_ = el_.Convert<string>(dx_);
					var eo_ = cx_.Equal(em_, "cancelled");
					var eq_ = cx_.Not(eo_);
					var es_ = cx_.And(eg_, eq_);
					var eu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cv_);
					var ew_ = cx_.Start(eu_);
					var ex_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var ez_ = cx_.ElementInInterval<CqlDateTime>(ew_, ex_, null);
					var fb_ = cx_.And(es_, ez_);

					return fb_;
				};
				var cq_ = context.Operators;
				var cr_ = cq_.WhereOrNull<MedicationAdministration>(co_, cp_);
				Observation cs_(MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;
				var cu_ = cq_.SelectOrNull<MedicationAdministration, Observation>(cr_, cs_);

				return cu_;
			};
			var p_ = i_.SelectManyOrNull<Observation, Observation>(m_, n_);
			IEnumerable<Observation> q_(Observation BloodGlucoseLab)
			{
				var fc_ = this.Glucose_lab_test();
				var fd_ = context.DataRetriever;
				var fe_ = fd_.RetrieveByValueSet<Observation>(fc_, null);
				bool? ff_(Observation FollowupBloodGlucoseLab)
				{
					var fl_ = FollowupBloodGlucoseLab?.Effective;
					var fm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fl_);
					var fn_ = context.Operators;
					var fo_ = fn_.Start(fm_);
					var fp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var fr_ = fn_.ElementInInterval<CqlDateTime>(fo_, fp_, null);
					var ft_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fl_);
					var fv_ = fn_.Start(ft_);
					var fw_ = BloodGlucoseLab?.Effective;
					var fx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fw_);
					var fz_ = fn_.Start(fx_);
					var gb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fw_);
					var gd_ = fn_.Start(gb_);
					var gf_ = fn_.Quantity(5m, "minutes");
					var gh_ = fn_.Add(gd_, gf_);
					var gj_ = fn_.Interval(fz_, gh_, false, true);
					var gl_ = fn_.ElementInInterval<CqlDateTime>(fv_, gj_, null);
					var gn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fw_);
					var gp_ = fn_.Start(gn_);
					var gr_ = fn_.Not((bool?)(gp_ is null));
					var gt_ = fn_.And(gl_, gr_);
					var gv_ = fn_.And(fr_, gt_);
					var gw_ = FollowupBloodGlucoseLab?.StatusElement;
					var gx_ = new CallStackEntry("ToString", null, null);
					var gy_ = context.Deeper(gx_);
					var gz_ = gy_.Operators;
					var ha_ = gz_.TypeConverter;
					var hb_ = ha_.Convert<string>(gw_);
					var hd_ = fn_.Equal(hb_, "final");
					var hf_ = fn_.And(gv_, hd_);
					var hi_ = context.Deeper(gx_);
					var hj_ = hi_.Operators;
					var hk_ = hj_.TypeConverter;
					var hl_ = hk_.Convert<string>(gw_);
					var hn_ = fn_.Equal(hl_, "cancelled");
					var hp_ = fn_.Not(hn_);
					var hr_ = fn_.And(hf_, hp_);
					var hs_ = FollowupBloodGlucoseLab?.Value;
					var ht_ = FHIRHelpers_4_0_001.ToQuantity((hs_ as Quantity));
					var hv_ = fn_.Quantity(80m, "mg/dL");
					var hx_ = fn_.Greater(ht_, hv_);
					var hz_ = fn_.And(hr_, hx_);

					return hz_;
				};
				var fg_ = context.Operators;
				var fh_ = fg_.WhereOrNull<Observation>(fe_, ff_);
				Observation fi_(Observation FollowupBloodGlucoseLab) => BloodGlucoseLab;
				var fk_ = fg_.SelectOrNull<Observation, Observation>(fh_, fi_);

				return fk_;
			};
			var s_ = i_.SelectManyOrNull<Observation, Observation>(p_, q_);
			var u_ = i_.ListExcept<Observation>(j_, s_);
			bool? v_(Observation BloodGlucoseLab)
			{
				var ia_ = BloodGlucoseLab?.Effective;
				var ib_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ia_);
				var ic_ = context.Operators;
				var id_ = ic_.Start(ib_);
				var ie_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var ig_ = ic_.ElementInInterval<CqlDateTime>(id_, ie_, null);
				var ih_ = BloodGlucoseLab?.Value;
				var ii_ = FHIRHelpers_4_0_001.ToQuantity((ih_ as Quantity));
				var ik_ = ic_.Quantity(40m, "mg/dL");
				var im_ = ic_.Less(ii_, ik_);
				var io_ = ic_.And(ig_, im_);

				return io_;
			};
			var x_ = i_.WhereOrNull<Observation>(u_, v_);
			var z_ = i_.ExistsInList<Observation>(x_);

			return z_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event() => __Severe_Hypoglycemic_Harm_Event.Value;

    private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Severe_Hypoglycemic_Harm_Event();

		return a_;
	}

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

}