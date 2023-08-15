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
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
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
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        Func<Encounter,bool?> m_ = (EncounterInpatient) => 
        {
            var e_ = (EncounterInpatient?.StatusElement as object);
            var d_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_) as object);
            var f_ = ("finished" as object);
            var g_ = context?.Operators.Equal(d_, 
				f_);
            var h_ = EncounterInpatient?.Period;
            var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
            var j_ = context?.Operators.End(i_);
            var k_ = this.Measurement_Period();
            var l_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, 
				k_, 
				null);
            return context?.Operators.And(g_, 
				l_);
        };
        return context?.Operators.WhereOrNull<Encounter>(c_, 
			m_);
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
        var b_ = typeof(MedicationAdministration).GetProperty("Medication");
        var c_ = context?.DataRetriever.RetrieveByValueSet<MedicationAdministration>(a_, 
			b_);
        var g_ = context?.Operators.ListUnion<MedicationAdministration>(c_, 
			c_);
        Func<MedicationAdministration,bool?> q_ = (HypoMedication) => 
        {
            var i_ = (HypoMedication?.StatusElement as object);
            var h_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(i_) as object);
            var j_ = ("completed" as object);
            var k_ = context?.Operators.Equal(h_, 
				j_);
            var n_ = ("not-done" as object);
            var o_ = context?.Operators.Equal(h_, 
				n_);
            var p_ = context?.Operators.Not(o_);
            return context?.Operators.And(k_, 
				p_);
        };
        return context?.Operators.WhereOrNull<MedicationAdministration>(g_, 
			q_);
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
        Func<Encounter,bool?> eq_ = (QualifyingEncounter) => 
        {
            var b_ = this.Glucose_lab_test();
            var c_ = typeof(Observation).GetProperty("Code");
            var d_ = context?.DataRetriever.RetrieveByValueSet<Observation>(b_, 
				c_);
            Func<Observation,IEnumerable<Observation>> aq_ = (BloodGlucoseLab) => 
            {
                var e_ = this.Hypoglycemic_Medication_Administration();
                Func<MedicationAdministration,bool?> an_ = (HypoglycemicMeds) => 
                {
                    var f_ = (HypoglycemicMeds?.Effective as object);
                    var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
                    var h_ = context?.Operators.Start(g_);
                    var i_ = (BloodGlucoseLab?.Effective as object);
                    var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
                    var k_ = context?.Operators.Start(j_);
                    var l_ = context?.Operators.Quantity(24m, 
						"hours");
                    var m_ = context?.Operators.Subtract(k_, 
						l_);
                    var q_ = context?.Operators.Interval(m_, 
						k_, 
						true, 
						true);
                    var r_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, 
						q_, 
						null);
                    bool? s_ = ((bool?)(context?.Operators.Start(j_) == null));
                    var v_ = context?.Operators.Not(s_);
                    var w_ = context?.Operators.And(r_, 
						v_);
                    var y_ = (BloodGlucoseLab?.StatusElement as object);
                    var x_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(y_) as object);
                    var z_ = ("final" as object);
                    var aa_ = context?.Operators.Equal(x_, 
						z_);
                    var ab_ = context?.Operators.And(w_, 
						aa_);
                    var ae_ = ("cancelled" as object);
                    var af_ = context?.Operators.Equal(x_, 
						ae_);
                    var ag_ = context?.Operators.Not(af_);
                    var ah_ = context?.Operators.And(ab_, 
						ag_);
                    var al_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                    var am_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, 
						al_, 
						null);
                    return context?.Operators.And(ah_, 
						am_);
                };
                var ao_ = context?.Operators.WhereOrNull<MedicationAdministration>(e_, 
					an_);
                Func<MedicationAdministration,Observation> ap_ = (HypoglycemicMeds) => BloodGlucoseLab;
                return context?.Operators.SelectOrNull<MedicationAdministration, Observation>(ao_, 
					ap_);
            };
            var ar_ = context?.Operators.SelectManyOrNull<Observation, Observation>(d_, 
				aq_);
            Func<Observation,IEnumerable<Observation>> ch_ = (BloodGlucoseLab) => 
            {
                var av_ = this.Hypoglycemic_Medication_Administration();
                Func<MedicationAdministration,bool?> ce_ = (HypoglycemicMeds) => 
                {
                    var aw_ = (HypoglycemicMeds?.Effective as object);
                    var ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aw_);
                    var ay_ = context?.Operators.Start(ax_);
                    var az_ = (BloodGlucoseLab?.Effective as object);
                    var ba_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(az_);
                    var bb_ = context?.Operators.Start(ba_);
                    var bc_ = context?.Operators.Quantity(24m, 
						"hours");
                    var bd_ = context?.Operators.Subtract(bb_, 
						bc_);
                    var bh_ = context?.Operators.Interval(bd_, 
						bb_, 
						true, 
						true);
                    var bi_ = context?.Operators.ElementInInterval<CqlDateTime>(ay_, 
						bh_, 
						null);
                    bool? bj_ = ((bool?)(context?.Operators.Start(ba_) == null));
                    var bm_ = context?.Operators.Not(bj_);
                    var bn_ = context?.Operators.And(bi_, 
						bm_);
                    var bp_ = (BloodGlucoseLab?.StatusElement as object);
                    var bo_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bp_) as object);
                    var bq_ = ("final" as object);
                    var br_ = context?.Operators.Equal(bo_, 
						bq_);
                    var bs_ = context?.Operators.And(bn_, 
						br_);
                    var bv_ = ("cancelled" as object);
                    var bw_ = context?.Operators.Equal(bo_, 
						bv_);
                    var bx_ = context?.Operators.Not(bw_);
                    var by_ = context?.Operators.And(bs_, 
						bx_);
                    var cc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                    var cd_ = context?.Operators.ElementInInterval<CqlDateTime>(ay_, 
						cc_, 
						null);
                    return context?.Operators.And(by_, 
						cd_);
                };
                var cf_ = context?.Operators.WhereOrNull<MedicationAdministration>(av_, 
					ce_);
                Func<MedicationAdministration,Observation> cg_ = (HypoglycemicMeds) => BloodGlucoseLab;
                return context?.Operators.SelectOrNull<MedicationAdministration, Observation>(cf_, 
					cg_);
            };
            var ci_ = context?.Operators.SelectManyOrNull<Observation, Observation>(d_, 
				ch_);
            Func<Observation,IEnumerable<Observation>> ec_ = (BloodGlucoseLab) => 
            {
                var cj_ = this.Glucose_lab_test();
                var ck_ = typeof(Observation).GetProperty("Code");
                var cl_ = context?.DataRetriever.RetrieveByValueSet<Observation>(cj_, 
					ck_);
                Func<Observation,bool?> dz_ = (FollowupBloodGlucoseLab) => 
                {
                    var cm_ = (FollowupBloodGlucoseLab?.Effective as object);
                    var cn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cm_);
                    var co_ = context?.Operators.Start(cn_);
                    var cp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                    var cq_ = context?.Operators.ElementInInterval<CqlDateTime>(co_, 
						cp_, 
						null);
                    var cu_ = (BloodGlucoseLab?.Effective as object);
                    var cv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(cu_);
                    var cw_ = context?.Operators.Start(cv_);
                    var da_ = context?.Operators.Quantity(5m, 
						"minutes");
                    var db_ = context?.Operators.Add(cw_, 
						da_);
                    var dc_ = context?.Operators.Interval(cw_, 
						db_, 
						false, 
						true);
                    var dd_ = context?.Operators.ElementInInterval<CqlDateTime>(co_, 
						dc_, 
						null);
                    bool? de_ = ((bool?)(context?.Operators.Start(cv_) == null));
                    var dh_ = context?.Operators.Not(de_);
                    var di_ = context?.Operators.And(dd_, 
						dh_);
                    var dj_ = context?.Operators.And(cq_, 
						di_);
                    var dl_ = (FollowupBloodGlucoseLab?.StatusElement as object);
                    var dk_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(dl_) as object);
                    var dm_ = ("final" as object);
                    var dn_ = context?.Operators.Equal(dk_, 
						dm_);
                    var do_ = context?.Operators.And(dj_, 
						dn_);
                    var dr_ = ("cancelled" as object);
                    var ds_ = context?.Operators.Equal(dk_, 
						dr_);
                    var dt_ = context?.Operators.Not(ds_);
                    var du_ = context?.Operators.And(do_, 
						dt_);
                    var dw_ = ((FollowupBloodGlucoseLab?.Value as object) as Quantity);
                    var dv_ = (FHIRHelpers_4_0_001.ToQuantity(dw_) as object);
                    var dx_ = (context?.Operators.Quantity(80m, 
						"mg/dL") as object);
                    var dy_ = context?.Operators.Greater(dv_, 
						dx_);
                    return context?.Operators.And(du_, 
						dy_);
                };
                var ea_ = context?.Operators.WhereOrNull<Observation>(cl_, 
					dz_);
                Func<Observation,Observation> eb_ = (FollowupBloodGlucoseLab) => BloodGlucoseLab;
                return context?.Operators.SelectOrNull<Observation, Observation>(ea_, 
					eb_);
            };
            var ed_ = context?.Operators.SelectManyOrNull<Observation, Observation>(ci_, 
				ec_);
            var ee_ = context?.Operators.ListExcept<Observation>(ar_, 
				ed_);
            Func<Observation,bool?> eo_ = (BloodGlucoseLab) => 
            {
                var ef_ = (BloodGlucoseLab?.Effective as object);
                var eg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ef_);
                var eh_ = context?.Operators.Start(eg_);
                var ei_ = MATGlobalCommonFunctionsFHIR4_6_1_000.HospitalizationWithObservation(QualifyingEncounter);
                var ej_ = context?.Operators.ElementInInterval<CqlDateTime>(eh_, 
					ei_, 
					null);
                var el_ = ((BloodGlucoseLab?.Value as object) as Quantity);
                var ek_ = (FHIRHelpers_4_0_001.ToQuantity(el_) as object);
                var em_ = (context?.Operators.Quantity(40m, 
					"mg/dL") as object);
                var en_ = context?.Operators.Less(ek_, 
					em_);
                return context?.Operators.And(ej_, 
					en_);
            };
            var ep_ = context?.Operators.WhereOrNull<Observation>(ee_, 
				eo_);
            return context?.Operators.ExistsInList<Observation>(ep_);
        };
        return context?.Operators.WhereOrNull<Encounter>(a_, 
			eq_);
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