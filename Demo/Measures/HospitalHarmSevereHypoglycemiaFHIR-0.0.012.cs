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
		var k_ = this.Encounter_Inpatient();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, null);
		var m_ = (Encounter EncounterInpatient) =>
		{
			var a_ = EncounterInpatient?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("finished" as object));
			var f_ = EncounterInpatient?.Period;
			var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
			var h_ = context?.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, i_, null);

			return context?.Operators.And(e_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(l_, m_);
	}

    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => __Inpatient_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var k_ = this.Inpatient_Encounter_During_Measurement_Period();
		var l_ = (Encounter InpatientEncounter) =>
		{
			var a_ = this.Patient();
			var b_ = a_?.BirthDateElement;
			var c_ = b_?.Value;
			var d_ = context?.Operators.ConvertStringToDateTime(c_);
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
			var f_ = context?.Operators.Start(e_);
			var g_ = context?.Operators.CalculateAgeAt(d_, f_, "year");
			var h_ = g_;
			var i_ = (int?)18;
			var j_ = i_;

			return context?.Operators.GreaterOrEqual(h_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(k_, l_);
	}

    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter() => __Qualifying_Encounter.Value;

    private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		var l_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var m_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(l_, null);
		var n_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var o_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(n_, null);
		var p_ = context?.Operators.ListUnion<MedicationAdministration>(m_, o_);
		var q_ = (MedicationAdministration HypoMedication) =>
		{
			var a_ = HypoMedication?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = HypoMedication?.StatusElement;
			var g_ = (f_ as object);
			var h_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(g_);
			var i_ = (h_ as object);
			var j_ = context?.Operators.Equal(i_, ("not-done" as object));
			var k_ = context?.Operators.Not(j_);

			return context?.Operators.And(e_, k_);
		};

		return context?.Operators.WhereOrNull<MedicationAdministration>(p_, q_);
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => __Hypoglycemic_Medication_Administration.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		var j_ = this.Qualifying_Encounter();
		var k_ = (Encounter QualifyingEncounter) =>
		{
			var f_ = this.Hypoglycemic_Medication_Administration();
			var g_ = (MedicationAdministration HypoglycemicMedication) =>
			{
				var a_ = HypoglycemicMedication?.Effective;
				var b_ = (a_ as object);
				var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(b_);
				var d_ = context?.Operators.Start(c_);
				var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);

				return context?.Operators.ElementInInterval<CqlDateTime>(d_, e_, null);
			};
			var h_ = context?.Operators.WhereOrNull<MedicationAdministration>(f_, g_);
			var i_ = (MedicationAdministration HypoglycemicMedication) => QualifyingEncounter;

			return context?.Operators.SelectOrNull<MedicationAdministration, Encounter>(h_, i_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(j_, k_);
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
		var fw_ = this.Denominator();
		var fx_ = (Encounter QualifyingEncounter) =>
		{
			var fj_ = this.Glucose_lab_test();
			var fk_ = context?.DataRetriever.RetrieveByValueSet<Observation>(fj_, null);
			var fl_ = (Observation BloodGlucoseLab) =>
			{
				var ar_ = this.Hypoglycemic_Medication_Administration();
				var as_ = (MedicationAdministration HypoglycemicMeds) =>
				{
					var a_ = HypoglycemicMeds?.Effective;
					var b_ = (a_ as object);
					var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(b_);
					var d_ = context?.Operators.Start(c_);
					var e_ = BloodGlucoseLab?.Effective;
					var f_ = (e_ as object);
					var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
					var h_ = context?.Operators.Start(g_);
					var i_ = context?.Operators.Quantity(24m, "hours");
					var j_ = context?.Operators.Subtract(h_, i_);
					var k_ = BloodGlucoseLab?.Effective;
					var l_ = (k_ as object);
					var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
					var n_ = context?.Operators.Start(m_);
					var o_ = context?.Operators.Interval(j_, n_, true, true);
					var p_ = context?.Operators.ElementInInterval<CqlDateTime>(d_, o_, null);
					var q_ = BloodGlucoseLab?.Effective;
					var r_ = (q_ as object);
					var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
					var t_ = context?.Operators.Start(s_);
					var u_ = (t_ == null);
					var v_ = (bool?)u_;
					var w_ = context?.Operators.Not(v_);
					var x_ = context?.Operators.And(p_, w_);
					var y_ = BloodGlucoseLab?.StatusElement;
					var z_ = (y_ as object);
					var aa_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(z_);
					var ab_ = (aa_ as object);
					var ac_ = context?.Operators.Equal(ab_, ("final" as object));
					var ad_ = context?.Operators.And(x_, ac_);
					var ae_ = BloodGlucoseLab?.StatusElement;
					var af_ = (ae_ as object);
					var ag_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(af_);
					var ah_ = (ag_ as object);
					var ai_ = context?.Operators.Equal(ah_, ("cancelled" as object));
					var aj_ = context?.Operators.Not(ai_);
					var ak_ = context?.Operators.And(ad_, aj_);
					var al_ = HypoglycemicMeds?.Effective;
					var am_ = (al_ as object);
					var an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(am_);
					var ao_ = context?.Operators.Start(an_);
					var ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var aq_ = context?.Operators.ElementInInterval<CqlDateTime>(ao_, ap_, null);

					return context?.Operators.And(ak_, aq_);
				};
				var at_ = context?.Operators.WhereOrNull<MedicationAdministration>(ar_, as_);
				var au_ = (MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;

				return context?.Operators.SelectOrNull<MedicationAdministration, Observation>(at_, au_);
			};
			var fm_ = context?.Operators.SelectManyOrNull<Observation, Observation>(fk_, fl_);
			var fn_ = this.Glucose_lab_test();
			var fo_ = context?.DataRetriever.RetrieveByValueSet<Observation>(fn_, null);
			var fp_ = (Observation BloodGlucoseLab) =>
			{
				var cm_ = this.Hypoglycemic_Medication_Administration();
				var cn_ = (MedicationAdministration HypoglycemicMeds) =>
				{
					var av_ = HypoglycemicMeds?.Effective;
					var aw_ = (av_ as object);
					var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aw_);
					var ay_ = context?.Operators.Start(ax_);
					var az_ = BloodGlucoseLab?.Effective;
					var ba_ = (az_ as object);
					var bb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ba_);
					var bc_ = context?.Operators.Start(bb_);
					var bd_ = context?.Operators.Quantity(24m, "hours");
					var be_ = context?.Operators.Subtract(bc_, bd_);
					var bf_ = BloodGlucoseLab?.Effective;
					var bg_ = (bf_ as object);
					var bh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bg_);
					var bi_ = context?.Operators.Start(bh_);
					var bj_ = context?.Operators.Interval(be_, bi_, true, true);
					var bk_ = context?.Operators.ElementInInterval<CqlDateTime>(ay_, bj_, null);
					var bl_ = BloodGlucoseLab?.Effective;
					var bm_ = (bl_ as object);
					var bn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bm_);
					var bo_ = context?.Operators.Start(bn_);
					var bp_ = (bo_ == null);
					var bq_ = (bool?)bp_;
					var br_ = context?.Operators.Not(bq_);
					var bs_ = context?.Operators.And(bk_, br_);
					var bt_ = BloodGlucoseLab?.StatusElement;
					var bu_ = (bt_ as object);
					var bv_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(bu_);
					var bw_ = (bv_ as object);
					var bx_ = context?.Operators.Equal(bw_, ("final" as object));
					var by_ = context?.Operators.And(bs_, bx_);
					var bz_ = BloodGlucoseLab?.StatusElement;
					var ca_ = (bz_ as object);
					var cb_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ca_);
					var cc_ = (cb_ as object);
					var cd_ = context?.Operators.Equal(cc_, ("cancelled" as object));
					var ce_ = context?.Operators.Not(cd_);
					var cf_ = context?.Operators.And(by_, ce_);
					var cg_ = HypoglycemicMeds?.Effective;
					var ch_ = (cg_ as object);
					var ci_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ch_);
					var cj_ = context?.Operators.Start(ci_);
					var ck_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var cl_ = context?.Operators.ElementInInterval<CqlDateTime>(cj_, ck_, null);

					return context?.Operators.And(cf_, cl_);
				};
				var co_ = context?.Operators.WhereOrNull<MedicationAdministration>(cm_, cn_);
				var cp_ = (MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;

				return context?.Operators.SelectOrNull<MedicationAdministration, Observation>(co_, cp_);
			};
			var fq_ = context?.Operators.SelectManyOrNull<Observation, Observation>(fo_, fp_);
			var fr_ = (Observation BloodGlucoseLab) =>
			{
				var eq_ = this.Glucose_lab_test();
				var er_ = context?.DataRetriever.RetrieveByValueSet<Observation>(eq_, null);
				var es_ = (Observation FollowupBloodGlucoseLab) =>
				{
					var cq_ = FollowupBloodGlucoseLab?.Effective;
					var cr_ = (cq_ as object);
					var cs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cr_);
					var ct_ = context?.Operators.Start(cs_);
					var cu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
					var cv_ = context?.Operators.ElementInInterval<CqlDateTime>(ct_, cu_, null);
					var cw_ = FollowupBloodGlucoseLab?.Effective;
					var cx_ = (cw_ as object);
					var cy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cx_);
					var cz_ = context?.Operators.Start(cy_);
					var da_ = BloodGlucoseLab?.Effective;
					var db_ = (da_ as object);
					var dc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(db_);
					var dd_ = context?.Operators.Start(dc_);
					var de_ = BloodGlucoseLab?.Effective;
					var df_ = (de_ as object);
					var dg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(df_);
					var dh_ = context?.Operators.Start(dg_);
					var di_ = context?.Operators.Quantity(5m, "minutes");
					var dj_ = context?.Operators.Add(dh_, di_);
					var dk_ = context?.Operators.Interval(dd_, dj_, false, true);
					var dl_ = context?.Operators.ElementInInterval<CqlDateTime>(cz_, dk_, null);
					var dm_ = BloodGlucoseLab?.Effective;
					var dn_ = (dm_ as object);
					var do_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(dn_);
					var dp_ = context?.Operators.Start(do_);
					var dq_ = (dp_ == null);
					var dr_ = (bool?)dq_;
					var ds_ = context?.Operators.Not(dr_);
					var dt_ = context?.Operators.And(dl_, ds_);
					var du_ = context?.Operators.And(cv_, dt_);
					var dv_ = FollowupBloodGlucoseLab?.StatusElement;
					var dw_ = (dv_ as object);
					var dx_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(dw_);
					var dy_ = (dx_ as object);
					var dz_ = context?.Operators.Equal(dy_, ("final" as object));
					var ea_ = context?.Operators.And(du_, dz_);
					var eb_ = FollowupBloodGlucoseLab?.StatusElement;
					var ec_ = (eb_ as object);
					var ed_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ec_);
					var ee_ = (ed_ as object);
					var ef_ = context?.Operators.Equal(ee_, ("cancelled" as object));
					var eg_ = context?.Operators.Not(ef_);
					var eh_ = context?.Operators.And(ea_, eg_);
					var ei_ = FollowupBloodGlucoseLab?.Value;
					var ej_ = (ei_ as object);
					var ek_ = (ej_ as Quantity);
					var el_ = FHIRHelpers_4_0_001.ToQuantity(ek_);
					var em_ = (el_ as object);
					var en_ = context?.Operators.Quantity(80m, "mg/dL");
					var eo_ = (en_ as object);
					var ep_ = context?.Operators.Greater(em_, eo_);

					return context?.Operators.And(eh_, ep_);
				};
				var et_ = context?.Operators.WhereOrNull<Observation>(er_, es_);
				var eu_ = (Observation FollowupBloodGlucoseLab) => BloodGlucoseLab;

				return context?.Operators.SelectOrNull<Observation, Observation>(et_, eu_);
			};
			var fs_ = context?.Operators.SelectManyOrNull<Observation, Observation>(fq_, fr_);
			var ft_ = context?.Operators.ListExcept<Observation>(fm_, fs_);
			var fu_ = (Observation BloodGlucoseLab) =>
			{
				var ev_ = BloodGlucoseLab?.Effective;
				var ew_ = (ev_ as object);
				var ex_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ew_);
				var ey_ = context?.Operators.Start(ex_);
				var ez_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
				var fa_ = context?.Operators.ElementInInterval<CqlDateTime>(ey_, ez_, null);
				var fb_ = BloodGlucoseLab?.Value;
				var fc_ = (fb_ as object);
				var fd_ = (fc_ as Quantity);
				var fe_ = FHIRHelpers_4_0_001.ToQuantity(fd_);
				var ff_ = (fe_ as object);
				var fg_ = context?.Operators.Quantity(40m, "mg/dL");
				var fh_ = (fg_ as object);
				var fi_ = context?.Operators.Less(ff_, fh_);

				return context?.Operators.And(fa_, fi_);
			};
			var fv_ = context?.Operators.WhereOrNull<Observation>(ft_, fu_);

			return context?.Operators.ExistsInList<Observation>(fv_);
		};

		return context?.Operators.WhereOrNull<Encounter>(fw_, fx_);
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