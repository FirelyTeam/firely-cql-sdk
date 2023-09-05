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

    private CqlValueSet birth_date_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", 
			null);
    }

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
    public CqlValueSet birth_date() => __birth_date.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", 
			null);
    }

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Glucose_lab_test_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", 
			null);
    }

    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test() => __Glucose_lab_test.Value;

    private CqlValueSet Hypoglycemics_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", 
			null);
    }

    [CqlDeclaration("Hypoglycemics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3")]
    public CqlValueSet Hypoglycemics() => __Hypoglycemics.Value;

    private CqlValueSet Hypoglycemics_Severe_Hypoglycemia_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", 
			null);
    }

    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia() => __Hypoglycemics_Severe_Hypoglycemia.Value;

    private CqlValueSet Observation_Services_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", 
			null);
    }

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlCode Birth_date_Value()
    {
        return new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
    {
        var a_ = new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
		};
    }
    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", 
			"Measurement Period", 
			(context?.Operators.Interval(context?.Operators.DateTime(((int?)2019), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				context?.Operators.DateTime(((int?)2020), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				true, 
				false) as object)));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();
    }
    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Race();
    }
    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();
    }
    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Value()
    {
        var a_ = this.Encounter_Inpatient();
        var b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, 
			null);
        Func<Encounter,bool?> l_ = (EncounterInpatient) => 
        {
            var d_ = (EncounterInpatient?.StatusElement as object);
            var c_ = (context?.Operators.Convert<string>(d_) as object);
            var e_ = ("finished" as object);
            var f_ = context?.Operators.Equal(c_, 
				e_);
            var g_ = EncounterInpatient?.Period;
            var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
            var i_ = context?.Operators.End(h_);
            var j_ = this.Measurement_Period();
            var k_ = context?.Operators.ElementInInterval<CqlDateTime>(i_, 
				j_, 
				null);
            return context?.Operators.And(f_, 
				k_);
        };
        return context?.Operators.WhereOrNull<Encounter>(b_, 
			l_);
    }
    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period() => __Inpatient_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_Value()
    {
        var a_ = this.Inpatient_Encounter_During_Measurement_Period();
        Func<Encounter,bool?> h_ = (InpatientEncounter) => 
        {
            var c_ = this.Patient()?.BirthDateElement?.Value;
            var d_ = context?.Operators.ConvertStringToDateTime(c_);
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(InpatientEncounter);
            var f_ = context?.Operators.Start(e_);
            var b_ = (context?.Operators.CalculateAgeAt(d_, 
				f_, 
				"year") as object);
            var g_ = (((int?)18) as object);
            return context?.Operators.GreaterOrEqual(b_, 
				g_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			h_);
    }
    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter() => __Qualifying_Encounter.Value;

    private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
    {
        var a_ = this.Hypoglycemics_Severe_Hypoglycemia();
        var b_ = context?.Operators.RetrieveByValueSet<MedicationAdministration>(a_, 
			null);
        var e_ = context?.Operators.ListUnion<MedicationAdministration>(b_, 
			b_);
        Func<MedicationAdministration,bool?> o_ = (HypoMedication) => 
        {
            var g_ = (HypoMedication?.StatusElement as object);
            var f_ = (context?.Operators.Convert<string>(g_) as object);
            var h_ = ("completed" as object);
            var i_ = context?.Operators.Equal(f_, 
				h_);
            var l_ = ("not-done" as object);
            var m_ = context?.Operators.Equal(f_, 
				l_);
            var n_ = context?.Operators.Not(m_);
            return context?.Operators.And(i_, 
				n_);
        };
        return context?.Operators.WhereOrNull<MedicationAdministration>(e_, 
			o_);
    }
    [CqlDeclaration("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => __Hypoglycemic_Medication_Administration.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Value()
    {
        var a_ = this.Qualifying_Encounter();
        Func<Encounter,IEnumerable<Encounter>> j_ = (QualifyingEncounter) => 
        {
            var b_ = this.Hypoglycemic_Medication_Administration();
            Func<MedicationAdministration,bool?> g_ = (HypoglycemicMedication) => 
            {
                var c_ = (HypoglycemicMedication?.Effective as object);
                var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(c_);
                var e_ = context?.Operators.Start(d_);
                var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                return context?.Operators.ElementInInterval<CqlDateTime>(e_, 
					f_, 
					null);
            };
            var h_ = context?.Operators.WhereOrNull<MedicationAdministration>(b_, 
				g_);
            Func<MedicationAdministration,Encounter> i_ = (HypoglycemicMedication) => QualifyingEncounter;
            return context?.Operators.SelectOrNull<MedicationAdministration, Encounter>(h_, 
				i_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			j_);
    }
    [CqlDeclaration("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration() => __Qualifying_Encounter_with_Hypoglycemic_Medication_Administration.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
    {
        return this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration();
    }
    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value()
    {
        return this.Initial_Population();
    }
    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    private IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event_Value()
    {
        var a_ = this.Denominator();
        Func<Encounter,bool?> en_ = (QualifyingEncounter) => 
        {
            var b_ = this.Glucose_lab_test();
            var c_ = context?.Operators.RetrieveByValueSet<Observation>(b_, 
				null);
            Func<Observation,IEnumerable<Observation>> ap_ = (BloodGlucoseLab) => 
            {
                var d_ = this.Hypoglycemic_Medication_Administration();
                Func<MedicationAdministration,bool?> am_ = (HypoglycemicMeds) => 
                {
                    var e_ = (HypoglycemicMeds?.Effective as object);
                    var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
                    var g_ = context?.Operators.Start(f_);
                    var h_ = (BloodGlucoseLab?.Effective as object);
                    var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
                    var j_ = context?.Operators.Start(i_);
                    var k_ = context?.Operators.Quantity(24m, 
						"hours");
                    var l_ = context?.Operators.Subtract(j_, 
						k_);
                    var p_ = context?.Operators.Interval(l_, 
						j_, 
						true, 
						true);
                    var q_ = context?.Operators.ElementInInterval<CqlDateTime>(g_, 
						p_, 
						null);
                    bool? r_ = ((bool?)(context?.Operators.Start(i_) == null));
                    var u_ = context?.Operators.Not(r_);
                    var v_ = context?.Operators.And(q_, 
						u_);
                    var x_ = (BloodGlucoseLab?.StatusElement as object);
                    var w_ = (context?.Operators.Convert<string>(x_) as object);
                    var y_ = ("final" as object);
                    var z_ = context?.Operators.Equal(w_, 
						y_);
                    var aa_ = context?.Operators.And(v_, 
						z_);
                    var ad_ = ("cancelled" as object);
                    var ae_ = context?.Operators.Equal(w_, 
						ad_);
                    var af_ = context?.Operators.Not(ae_);
                    var ag_ = context?.Operators.And(aa_, 
						af_);
                    var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                    var al_ = context?.Operators.ElementInInterval<CqlDateTime>(g_, 
						ak_, 
						null);
                    return context?.Operators.And(ag_, 
						al_);
                };
                var an_ = context?.Operators.WhereOrNull<MedicationAdministration>(d_, 
					am_);
                Func<MedicationAdministration,Observation> ao_ = (HypoglycemicMeds) => BloodGlucoseLab;
                return context?.Operators.SelectOrNull<MedicationAdministration, Observation>(an_, 
					ao_);
            };
            var aq_ = context?.Operators.SelectManyOrNull<Observation, Observation>(c_, 
				ap_);
            Func<Observation,IEnumerable<Observation>> cf_ = (BloodGlucoseLab) => 
            {
                var at_ = this.Hypoglycemic_Medication_Administration();
                Func<MedicationAdministration,bool?> cc_ = (HypoglycemicMeds) => 
                {
                    var au_ = (HypoglycemicMeds?.Effective as object);
                    var av_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(au_);
                    var aw_ = context?.Operators.Start(av_);
                    var ax_ = (BloodGlucoseLab?.Effective as object);
                    var ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ax_);
                    var az_ = context?.Operators.Start(ay_);
                    var ba_ = context?.Operators.Quantity(24m, 
						"hours");
                    var bb_ = context?.Operators.Subtract(az_, 
						ba_);
                    var bf_ = context?.Operators.Interval(bb_, 
						az_, 
						true, 
						true);
                    var bg_ = context?.Operators.ElementInInterval<CqlDateTime>(aw_, 
						bf_, 
						null);
                    bool? bh_ = ((bool?)(context?.Operators.Start(ay_) == null));
                    var bk_ = context?.Operators.Not(bh_);
                    var bl_ = context?.Operators.And(bg_, 
						bk_);
                    var bn_ = (BloodGlucoseLab?.StatusElement as object);
                    var bm_ = (context?.Operators.Convert<string>(bn_) as object);
                    var bo_ = ("final" as object);
                    var bp_ = context?.Operators.Equal(bm_, 
						bo_);
                    var bq_ = context?.Operators.And(bl_, 
						bp_);
                    var bt_ = ("cancelled" as object);
                    var bu_ = context?.Operators.Equal(bm_, 
						bt_);
                    var bv_ = context?.Operators.Not(bu_);
                    var bw_ = context?.Operators.And(bq_, 
						bv_);
                    var ca_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                    var cb_ = context?.Operators.ElementInInterval<CqlDateTime>(aw_, 
						ca_, 
						null);
                    return context?.Operators.And(bw_, 
						cb_);
                };
                var cd_ = context?.Operators.WhereOrNull<MedicationAdministration>(at_, 
					cc_);
                Func<MedicationAdministration,Observation> ce_ = (HypoglycemicMeds) => BloodGlucoseLab;
                return context?.Operators.SelectOrNull<MedicationAdministration, Observation>(cd_, 
					ce_);
            };
            var cg_ = context?.Operators.SelectManyOrNull<Observation, Observation>(c_, 
				cf_);
            Func<Observation,IEnumerable<Observation>> dz_ = (BloodGlucoseLab) => 
            {
                var ch_ = this.Glucose_lab_test();
                var ci_ = context?.Operators.RetrieveByValueSet<Observation>(ch_, 
					null);
                Func<Observation,bool?> dw_ = (FollowupBloodGlucoseLab) => 
                {
                    var cj_ = (FollowupBloodGlucoseLab?.Effective as object);
                    var ck_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cj_);
                    var cl_ = context?.Operators.Start(ck_);
                    var cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                    var cn_ = context?.Operators.ElementInInterval<CqlDateTime>(cl_, 
						cm_, 
						null);
                    var cr_ = (BloodGlucoseLab?.Effective as object);
                    var cs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cr_);
                    var ct_ = context?.Operators.Start(cs_);
                    var cx_ = context?.Operators.Quantity(5m, 
						"minutes");
                    var cy_ = context?.Operators.Add(ct_, 
						cx_);
                    var cz_ = context?.Operators.Interval(ct_, 
						cy_, 
						false, 
						true);
                    var da_ = context?.Operators.ElementInInterval<CqlDateTime>(cl_, 
						cz_, 
						null);
                    bool? db_ = ((bool?)(context?.Operators.Start(cs_) == null));
                    var de_ = context?.Operators.Not(db_);
                    var df_ = context?.Operators.And(da_, 
						de_);
                    var dg_ = context?.Operators.And(cn_, 
						df_);
                    var di_ = (FollowupBloodGlucoseLab?.StatusElement as object);
                    var dh_ = (context?.Operators.Convert<string>(di_) as object);
                    var dj_ = ("final" as object);
                    var dk_ = context?.Operators.Equal(dh_, 
						dj_);
                    var dl_ = context?.Operators.And(dg_, 
						dk_);
                    var do_ = ("cancelled" as object);
                    var dp_ = context?.Operators.Equal(dh_, 
						do_);
                    var dq_ = context?.Operators.Not(dp_);
                    var dr_ = context?.Operators.And(dl_, 
						dq_);
                    var dt_ = ((FollowupBloodGlucoseLab?.Value as object) as Quantity);
                    var ds_ = (FHIRHelpers_4_0_001.ToQuantity(dt_) as object);
                    var du_ = (context?.Operators.Quantity(80m, 
						"mg/dL") as object);
                    var dv_ = context?.Operators.Greater(ds_, 
						du_);
                    return context?.Operators.And(dr_, 
						dv_);
                };
                var dx_ = context?.Operators.WhereOrNull<Observation>(ci_, 
					dw_);
                Func<Observation,Observation> dy_ = (FollowupBloodGlucoseLab) => BloodGlucoseLab;
                return context?.Operators.SelectOrNull<Observation, Observation>(dx_, 
					dy_);
            };
            var ea_ = context?.Operators.SelectManyOrNull<Observation, Observation>(cg_, 
				dz_);
            var eb_ = context?.Operators.ListExcept<Observation>(aq_, 
				ea_);
            Func<Observation,bool?> el_ = (BloodGlucoseLab) => 
            {
                var ec_ = (BloodGlucoseLab?.Effective as object);
                var ed_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ec_);
                var ee_ = context?.Operators.Start(ed_);
                var ef_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                var eg_ = context?.Operators.ElementInInterval<CqlDateTime>(ee_, 
					ef_, 
					null);
                var ei_ = ((BloodGlucoseLab?.Value as object) as Quantity);
                var eh_ = (FHIRHelpers_4_0_001.ToQuantity(ei_) as object);
                var ej_ = (context?.Operators.Quantity(40m, 
					"mg/dL") as object);
                var ek_ = context?.Operators.Less(eh_, 
					ej_);
                return context?.Operators.And(eg_, 
					ek_);
            };
            var em_ = context?.Operators.WhereOrNull<Observation>(eb_, 
				el_);
            return context?.Operators.ExistsInList<Observation>(em_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			en_);
    }
    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event() => __Severe_Hypoglycemic_Harm_Event.Value;

    private IEnumerable<Encounter> Numerator_Value()
    {
        return this.Severe_Hypoglycemic_Harm_Event();
    }
    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();
    }
    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

}