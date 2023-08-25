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

    private CqlValueSet birth_date_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

		return a_;
	}

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
    public CqlValueSet birth_date() => __birth_date.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

		return a_;
	}

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

		return a_;
	}

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Glucose_lab_test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

		return a_;
	}

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hypoglycemics_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", null);

		return a_;
	}

    [CqlDeclaration("Hypoglycemics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3")]
    public CqlValueSet Hypoglycemics() => __Hypoglycemics.Value;

    private CqlValueSet Hypoglycemics_Severe_Hypoglycemia_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

		return a_;
	}

    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia() => __Hypoglycemics_Severe_Hypoglycemia.Value;

    private CqlValueSet Observation_Services_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

		return a_;
	}

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
		var a_ = (int?)2019;
		var b_ = (int?)1;
		var d_ = (int?)0;
		var h_ = context.Operators;
		var i_ = h_.ConvertIntegerToDecimal(default);
		var k_ = h_.DateTime(a_, b_, b_, d_, d_, d_, d_, i_);
		var l_ = (int?)2020;
		var t_ = h_.ConvertIntegerToDecimal(default);
		var v_ = h_.DateTime(l_, b_, b_, d_, d_, d_, d_, t_);
		var x_ = h_.Interval(k_, v_, true, false);
		var y_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", x_);
		var z_ = (CqlInterval<CqlDateTime>)y_;

		return z_;
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
		var d_ = (Encounter EncounterInpatient) =>
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
		var b_ = (Encounter InpatientEncounter) =>
		{
			var e_ = this.Patient();
			var f_ = e_.BirthDateElement;
			var g_ = f_.Value;
			var h_ = context.Operators;
			var i_ = h_.ConvertStringToDateTime(g_);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var l_ = h_.Start(j_);
			var n_ = h_.CalculateAgeAt(i_, l_, "year");
			var o_ = n_;
			var p_ = (int?)18;
			var q_ = p_;
			var s_ = h_.GreaterOrEqual(o_, q_);

			return s_;
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
		var i_ = (MedicationAdministration HypoMedication) =>
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
		var b_ = (Encounter QualifyingEncounter) =>
		{
			var e_ = this.Hypoglycemic_Medication_Administration();
			var f_ = (MedicationAdministration HypoglycemicMedication) =>
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
			var i_ = (MedicationAdministration HypoglycemicMedication) => QualifyingEncounter;
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
		var b_ = (Encounter QualifyingEncounter) =>
		{
			var e_ = this.Glucose_lab_test();
			var f_ = context.DataRetriever;
			var g_ = f_.RetrieveByValueSet<Observation>(e_, null);
			var h_ = (Observation BloodGlucoseLab) =>
			{
				var aa_ = this.Hypoglycemic_Medication_Administration();
				var ab_ = (MedicationAdministration HypoglycemicMeds) =>
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
					var bg_ = (bool?)bf_;
					var bi_ = aj_.Not(bg_);
					var bk_ = aj_.And(ba_, bi_);
					var bl_ = BloodGlucoseLab.StatusElement;
					var bm_ = new CallStackEntry("ToString", null, null);
					var bn_ = context.Deeper(bm_);
					var bo_ = bn_.Operators;
					var bp_ = bo_.TypeConverter;
					var bq_ = bp_.Convert<string>(bl_);
					var bs_ = aj_.Equal(bq_, "final");
					var bu_ = aj_.And(bk_, bs_);
					var bx_ = context.Deeper(bm_);
					var by_ = bx_.Operators;
					var bz_ = by_.TypeConverter;
					var ca_ = bz_.Convert<string>(bl_);
					var cc_ = aj_.Equal(ca_, "cancelled");
					var ce_ = aj_.Not(cc_);
					var cg_ = aj_.And(bu_, ce_);
					var ci_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ah_);
					var ck_ = aj_.Start(ci_);
					var cl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var cn_ = aj_.ElementInInterval<CqlDateTime>(ck_, cl_, null);
					var cp_ = aj_.And(cg_, cn_);

					return cp_;
				};
				var ac_ = context.Operators;
				var ad_ = ac_.WhereOrNull<MedicationAdministration>(aa_, ab_);
				var ae_ = (MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;
				var ag_ = ac_.SelectOrNull<MedicationAdministration, Observation>(ad_, ae_);

				return ag_;
			};
			var i_ = context.Operators;
			var j_ = i_.SelectManyOrNull<Observation, Observation>(g_, h_);
			var m_ = f_.RetrieveByValueSet<Observation>(e_, null);
			var n_ = (Observation BloodGlucoseLab) =>
			{
				var cq_ = this.Hypoglycemic_Medication_Administration();
				var cr_ = (MedicationAdministration HypoglycemicMeds) =>
				{
					var cx_ = HypoglycemicMeds.Effective;
					var cy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cx_);
					var cz_ = context.Operators;
					var da_ = cz_.Start(cy_);
					var db_ = BloodGlucoseLab.Effective;
					var dc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(db_);
					var de_ = cz_.Start(dc_);
					var dg_ = cz_.Quantity(24m, "hours");
					var di_ = cz_.Subtract(de_, dg_);
					var dk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(db_);
					var dm_ = cz_.Start(dk_);
					var do_ = cz_.Interval(di_, dm_, true, true);
					var dq_ = cz_.ElementInInterval<CqlDateTime>(da_, do_, null);
					var ds_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(db_);
					var du_ = cz_.Start(ds_);
					var dv_ = (du_ == null);
					var dw_ = (bool?)dv_;
					var dy_ = cz_.Not(dw_);
					var ea_ = cz_.And(dq_, dy_);
					var eb_ = BloodGlucoseLab.StatusElement;
					var ec_ = new CallStackEntry("ToString", null, null);
					var ed_ = context.Deeper(ec_);
					var ee_ = ed_.Operators;
					var ef_ = ee_.TypeConverter;
					var eg_ = ef_.Convert<string>(eb_);
					var ei_ = cz_.Equal(eg_, "final");
					var ek_ = cz_.And(ea_, ei_);
					var en_ = context.Deeper(ec_);
					var eo_ = en_.Operators;
					var ep_ = eo_.TypeConverter;
					var eq_ = ep_.Convert<string>(eb_);
					var es_ = cz_.Equal(eq_, "cancelled");
					var eu_ = cz_.Not(es_);
					var ew_ = cz_.And(ek_, eu_);
					var ey_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cx_);
					var fa_ = cz_.Start(ey_);
					var fb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var fd_ = cz_.ElementInInterval<CqlDateTime>(fa_, fb_, null);
					var ff_ = cz_.And(ew_, fd_);

					return ff_;
				};
				var cs_ = context.Operators;
				var ct_ = cs_.WhereOrNull<MedicationAdministration>(cq_, cr_);
				var cu_ = (MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;
				var cw_ = cs_.SelectOrNull<MedicationAdministration, Observation>(ct_, cu_);

				return cw_;
			};
			var p_ = i_.SelectManyOrNull<Observation, Observation>(m_, n_);
			var q_ = (Observation BloodGlucoseLab) =>
			{
				var fg_ = this.Glucose_lab_test();
				var fh_ = context.DataRetriever;
				var fi_ = fh_.RetrieveByValueSet<Observation>(fg_, null);
				var fj_ = (Observation FollowupBloodGlucoseLab) =>
				{
					var fp_ = FollowupBloodGlucoseLab.Effective;
					var fq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fp_);
					var fr_ = context.Operators;
					var fs_ = fr_.Start(fq_);
					var ft_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var fv_ = fr_.ElementInInterval<CqlDateTime>(fs_, ft_, null);
					var fx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(fp_);
					var fz_ = fr_.Start(fx_);
					var ga_ = BloodGlucoseLab.Effective;
					var gb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ga_);
					var gd_ = fr_.Start(gb_);
					var gf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ga_);
					var gh_ = fr_.Start(gf_);
					var gj_ = fr_.Quantity(5m, "minutes");
					var gl_ = fr_.Add(gh_, gj_);
					var gn_ = fr_.Interval(gd_, gl_, false, true);
					var gp_ = fr_.ElementInInterval<CqlDateTime>(fz_, gn_, null);
					var gr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ga_);
					var gt_ = fr_.Start(gr_);
					var gu_ = (gt_ == null);
					var gv_ = (bool?)gu_;
					var gx_ = fr_.Not(gv_);
					var gz_ = fr_.And(gp_, gx_);
					var hb_ = fr_.And(fv_, gz_);
					var hc_ = FollowupBloodGlucoseLab.StatusElement;
					var hd_ = new CallStackEntry("ToString", null, null);
					var he_ = context.Deeper(hd_);
					var hf_ = he_.Operators;
					var hg_ = hf_.TypeConverter;
					var hh_ = hg_.Convert<string>(hc_);
					var hj_ = fr_.Equal(hh_, "final");
					var hl_ = fr_.And(hb_, hj_);
					var ho_ = context.Deeper(hd_);
					var hp_ = ho_.Operators;
					var hq_ = hp_.TypeConverter;
					var hr_ = hq_.Convert<string>(hc_);
					var ht_ = fr_.Equal(hr_, "cancelled");
					var hv_ = fr_.Not(ht_);
					var hx_ = fr_.And(hl_, hv_);
					var hy_ = FollowupBloodGlucoseLab.Value;
					var hz_ = (hy_ as Quantity);
					var ia_ = FHIRHelpers_4_0_001.ToQuantity(hz_);
					var ic_ = fr_.Quantity(80m, "mg/dL");
					var ie_ = fr_.Greater(ia_, ic_);
					var ig_ = fr_.And(hx_, ie_);

					return ig_;
				};
				var fk_ = context.Operators;
				var fl_ = fk_.WhereOrNull<Observation>(fi_, fj_);
				var fm_ = (Observation FollowupBloodGlucoseLab) => BloodGlucoseLab;
				var fo_ = fk_.SelectOrNull<Observation, Observation>(fl_, fm_);

				return fo_;
			};
			var s_ = i_.SelectManyOrNull<Observation, Observation>(p_, q_);
			var u_ = i_.ListExcept<Observation>(j_, s_);
			var v_ = (Observation BloodGlucoseLab) =>
			{
				var ih_ = BloodGlucoseLab.Effective;
				var ii_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ih_);
				var ij_ = context.Operators;
				var ik_ = ij_.Start(ii_);
				var il_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var in_ = ij_.ElementInInterval<CqlDateTime>(ik_, il_, null);
				var io_ = BloodGlucoseLab.Value;
				var ip_ = (io_ as Quantity);
				var iq_ = FHIRHelpers_4_0_001.ToQuantity(ip_);
				var is_ = ij_.Quantity(40m, "mg/dL");
				var iu_ = ij_.Less(iq_, is_);
				var iw_ = ij_.And(in_, iu_);

				return iw_;
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