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
			var g_ = EncounterInpatient.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "finished");
			var o_ = EncounterInpatient.Period;
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
			var f_ = e_.BirthDateElement;
			var g_ = f_.Value;
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
			var l_ = HypoMedication.StatusElement;
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
				var l_ = HypoglycemicMedication.Effective;
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
					var ah_ = HypoglycemicMeds.Effective;
					var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ah_);
					var aj_ = context.Operators;
					var ak_ = aj_.Start(ai_);
					var al_ = BloodGlucoseLab.Effective;
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
					var bf_ = (be_ == null);
					var bh_ = aj_.Not((bool?)bf_);
					var bj_ = aj_.And(ba_, bh_);
					var bk_ = BloodGlucoseLab.StatusElement;
					var bl_ = new CallStackEntry("ToString", null, null);
					var bm_ = context.Deeper(bl_);
					var bn_ = bm_.Operators;
					var bo_ = bn_.TypeConverter;
					var bp_ = bo_.Convert<string>(bk_);
					var br_ = aj_.Equal(bp_, "final");
					var bt_ = aj_.And(bj_, br_);
					var bw_ = context.Deeper(bl_);
					var bx_ = bw_.Operators;
					var by_ = bx_.TypeConverter;
					var bz_ = by_.Convert<string>(bk_);
					var cb_ = aj_.Equal(bz_, "cancelled");
					var cd_ = aj_.Not(cb_);
					var cf_ = aj_.And(bt_, cd_);
					var ch_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ah_);
					var cj_ = aj_.Start(ch_);
					var ck_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var cm_ = aj_.ElementInInterval<CqlDateTime>(cj_, ck_, null);
					var co_ = aj_.And(cf_, cm_);

					return co_;
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
				var cp_ = this.Hypoglycemic_Medication_Administration();
				bool? cq_(MedicationAdministration HypoglycemicMeds)
				{
					var cw_ = HypoglycemicMeds.Effective;
					var cx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cw_);
					var cy_ = context.Operators;
					var cz_ = cy_.Start(cx_);
					var da_ = BloodGlucoseLab.Effective;
					var db_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(da_);
					var dd_ = cy_.Start(db_);
					var df_ = cy_.Quantity(24m, "hours");
					var dh_ = cy_.Subtract(dd_, df_);
					var dj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(da_);
					var dl_ = cy_.Start(dj_);
					var dn_ = cy_.Interval(dh_, dl_, true, true);
					var dp_ = cy_.ElementInInterval<CqlDateTime>(cz_, dn_, null);
					var dr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(da_);
					var dt_ = cy_.Start(dr_);
					var du_ = (dt_ == null);
					var dw_ = cy_.Not((bool?)du_);
					var dy_ = cy_.And(dp_, dw_);
					var dz_ = BloodGlucoseLab.StatusElement;
					var ea_ = new CallStackEntry("ToString", null, null);
					var eb_ = context.Deeper(ea_);
					var ec_ = eb_.Operators;
					var ed_ = ec_.TypeConverter;
					var ee_ = ed_.Convert<string>(dz_);
					var eg_ = cy_.Equal(ee_, "final");
					var ei_ = cy_.And(dy_, eg_);
					var el_ = context.Deeper(ea_);
					var em_ = el_.Operators;
					var en_ = em_.TypeConverter;
					var eo_ = en_.Convert<string>(dz_);
					var eq_ = cy_.Equal(eo_, "cancelled");
					var es_ = cy_.Not(eq_);
					var eu_ = cy_.And(ei_, es_);
					var ew_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cw_);
					var ey_ = cy_.Start(ew_);
					var ez_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var fb_ = cy_.ElementInInterval<CqlDateTime>(ey_, ez_, null);
					var fd_ = cy_.And(eu_, fb_);

					return fd_;
				};
				var cr_ = context.Operators;
				var cs_ = cr_.WhereOrNull<MedicationAdministration>(cp_, cq_);
				Observation ct_(MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;
				var cv_ = cr_.SelectOrNull<MedicationAdministration, Observation>(cs_, ct_);

				return cv_;
			};
			var p_ = i_.SelectManyOrNull<Observation, Observation>(m_, n_);
			IEnumerable<Observation> q_(Observation BloodGlucoseLab)
			{
				var fe_ = this.Glucose_lab_test();
				var ff_ = context.DataRetriever;
				var fg_ = ff_.RetrieveByValueSet<Observation>(fe_, null);
				bool? fh_(Observation FollowupBloodGlucoseLab)
				{
					var fn_ = FollowupBloodGlucoseLab.Effective;
					var fo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fn_);
					var fp_ = context.Operators;
					var fq_ = fp_.Start(fo_);
					var fr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var ft_ = fp_.ElementInInterval<CqlDateTime>(fq_, fr_, null);
					var fv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fn_);
					var fx_ = fp_.Start(fv_);
					var fy_ = BloodGlucoseLab.Effective;
					var fz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fy_);
					var gb_ = fp_.Start(fz_);
					var gd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fy_);
					var gf_ = fp_.Start(gd_);
					var gh_ = fp_.Quantity(5m, "minutes");
					var gj_ = fp_.Add(gf_, gh_);
					var gl_ = fp_.Interval(gb_, gj_, false, true);
					var gn_ = fp_.ElementInInterval<CqlDateTime>(fx_, gl_, null);
					var gp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fy_);
					var gr_ = fp_.Start(gp_);
					var gs_ = (gr_ == null);
					var gu_ = fp_.Not((bool?)gs_);
					var gw_ = fp_.And(gn_, gu_);
					var gy_ = fp_.And(ft_, gw_);
					var gz_ = FollowupBloodGlucoseLab.StatusElement;
					var ha_ = new CallStackEntry("ToString", null, null);
					var hb_ = context.Deeper(ha_);
					var hc_ = hb_.Operators;
					var hd_ = hc_.TypeConverter;
					var he_ = hd_.Convert<string>(gz_);
					var hg_ = fp_.Equal(he_, "final");
					var hi_ = fp_.And(gy_, hg_);
					var hl_ = context.Deeper(ha_);
					var hm_ = hl_.Operators;
					var hn_ = hm_.TypeConverter;
					var ho_ = hn_.Convert<string>(gz_);
					var hq_ = fp_.Equal(ho_, "cancelled");
					var hs_ = fp_.Not(hq_);
					var hu_ = fp_.And(hi_, hs_);
					var hv_ = FollowupBloodGlucoseLab.Value;
					var hw_ = FHIRHelpers_4_0_001.ToQuantity((hv_ as Quantity));
					var hy_ = fp_.Quantity(80m, "mg/dL");
					var ia_ = fp_.Greater(hw_, hy_);
					var ic_ = fp_.And(hu_, ia_);

					return ic_;
				};
				var fi_ = context.Operators;
				var fj_ = fi_.WhereOrNull<Observation>(fg_, fh_);
				Observation fk_(Observation FollowupBloodGlucoseLab) => BloodGlucoseLab;
				var fm_ = fi_.SelectOrNull<Observation, Observation>(fj_, fk_);

				return fm_;
			};
			var s_ = i_.SelectManyOrNull<Observation, Observation>(p_, q_);
			var u_ = i_.ListExcept<Observation>(j_, s_);
			bool? v_(Observation BloodGlucoseLab)
			{
				var id_ = BloodGlucoseLab.Effective;
				var ie_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(id_);
				var if_ = context.Operators;
				var ig_ = if_.Start(ie_);
				var ih_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var ij_ = if_.ElementInInterval<CqlDateTime>(ig_, ih_, null);
				var ik_ = BloodGlucoseLab.Value;
				var il_ = FHIRHelpers_4_0_001.ToQuantity((ik_ as Quantity));
				var in_ = if_.Quantity(40m, "mg/dL");
				var ip_ = if_.Less(il_, in_);
				var ir_ = if_.And(ij_, ip_);

				return ir_;
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