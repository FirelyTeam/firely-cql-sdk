using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("AdvancedIllnessandFrailty", "1.8.000")]
public class AdvancedIllnessandFrailty_1_8_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Acute_Inpatient;
    internal Lazy<CqlValueSet> __Advanced_Illness;
    internal Lazy<CqlValueSet> __Dementia_Medications;
    internal Lazy<CqlValueSet> __Emergency_Department_Evaluation_and_Management_Visit;
    internal Lazy<CqlValueSet> __Frailty_Device;
    internal Lazy<CqlValueSet> __Frailty_Diagnosis;
    internal Lazy<CqlValueSet> __Frailty_Encounter;
    internal Lazy<CqlValueSet> __Frailty_Symptom;
    internal Lazy<CqlValueSet> __Nonacute_Inpatient;
    internal Lazy<CqlValueSet> __Observation;
    internal Lazy<CqlValueSet> __Outpatient;
    internal Lazy<CqlCode> __Housing_status;
    internal Lazy<CqlCode> __Lives_in_a_nursing_home__finding_;
    internal Lazy<CqlCode> __Medical_equipment_used;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Criteria_Indicating_Frailty;
    internal Lazy<IEnumerable<Encounter>> __Outpatient_Encounters_with_Advanced_Illness;
    internal Lazy<bool?> __Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service;
    internal Lazy<bool?> __Has_Inpatient_Encounter_with_Advanced_Illness;
    internal Lazy<bool?> __Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period;
    internal Lazy<bool?> __Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty;
    internal Lazy<bool?> __Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty;
    internal Lazy<bool?> __Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home;

    #endregion
    public AdvancedIllnessandFrailty_1_8_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __Acute_Inpatient = new Lazy<CqlValueSet>(this.Acute_Inpatient_Value);
        __Advanced_Illness = new Lazy<CqlValueSet>(this.Advanced_Illness_Value);
        __Dementia_Medications = new Lazy<CqlValueSet>(this.Dementia_Medications_Value);
        __Emergency_Department_Evaluation_and_Management_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Evaluation_and_Management_Visit_Value);
        __Frailty_Device = new Lazy<CqlValueSet>(this.Frailty_Device_Value);
        __Frailty_Diagnosis = new Lazy<CqlValueSet>(this.Frailty_Diagnosis_Value);
        __Frailty_Encounter = new Lazy<CqlValueSet>(this.Frailty_Encounter_Value);
        __Frailty_Symptom = new Lazy<CqlValueSet>(this.Frailty_Symptom_Value);
        __Nonacute_Inpatient = new Lazy<CqlValueSet>(this.Nonacute_Inpatient_Value);
        __Observation = new Lazy<CqlValueSet>(this.Observation_Value);
        __Outpatient = new Lazy<CqlValueSet>(this.Outpatient_Value);
        __Housing_status = new Lazy<CqlCode>(this.Housing_status_Value);
        __Lives_in_a_nursing_home__finding_ = new Lazy<CqlCode>(this.Lives_in_a_nursing_home__finding__Value);
        __Medical_equipment_used = new Lazy<CqlCode>(this.Medical_equipment_used_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Criteria_Indicating_Frailty = new Lazy<bool?>(this.Has_Criteria_Indicating_Frailty_Value);
        __Outpatient_Encounters_with_Advanced_Illness = new Lazy<IEnumerable<Encounter>>(this.Outpatient_Encounters_with_Advanced_Illness_Value);
        __Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service = new Lazy<bool?>(this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value);
        __Has_Inpatient_Encounter_with_Advanced_Illness = new Lazy<bool?>(this.Has_Inpatient_Encounter_with_Advanced_Illness_Value);
        __Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period = new Lazy<bool?>(this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period_Value);
        __Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty = new Lazy<bool?>(this.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty_Value);
        __Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty = new Lazy<bool?>(this.Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty_Value);
        __Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home = new Lazy<bool?>(this.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

    #endregion

	private CqlValueSet Acute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
	public CqlValueSet Acute_Inpatient() => 
		__Acute_Inpatient.Value;

	private CqlValueSet Advanced_Illness_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
	public CqlValueSet Advanced_Illness() => 
		__Advanced_Illness.Value;

	private CqlValueSet Dementia_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
	public CqlValueSet Dementia_Medications() => 
		__Dementia_Medications.Value;

	private CqlValueSet Emergency_Department_Evaluation_and_Management_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlDeclaration("Emergency Department Evaluation and Management Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit() => 
		__Emergency_Department_Evaluation_and_Management_Visit.Value;

	private CqlValueSet Frailty_Device_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
	public CqlValueSet Frailty_Device() => 
		__Frailty_Device.Value;

	private CqlValueSet Frailty_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
	public CqlValueSet Frailty_Diagnosis() => 
		__Frailty_Diagnosis.Value;

	private CqlValueSet Frailty_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
	public CqlValueSet Frailty_Encounter() => 
		__Frailty_Encounter.Value;

	private CqlValueSet Frailty_Symptom_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
	public CqlValueSet Frailty_Symptom() => 
		__Frailty_Symptom.Value;

	private CqlValueSet Nonacute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
	public CqlValueSet Nonacute_Inpatient() => 
		__Nonacute_Inpatient.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation() => 
		__Observation.Value;

	private CqlValueSet Outpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
	public CqlValueSet Outpatient() => 
		__Outpatient.Value;

	private CqlCode Housing_status_Value() => 
		new CqlCode("71802-3", "http://loinc.org", null, null);

    [CqlDeclaration("Housing status")]
	public CqlCode Housing_status() => 
		__Housing_status.Value;

	private CqlCode Lives_in_a_nursing_home__finding__Value() => 
		new CqlCode("160734000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Lives in a nursing home (finding)")]
	public CqlCode Lives_in_a_nursing_home__finding_() => 
		__Lives_in_a_nursing_home__finding_.Value;

	private CqlCode Medical_equipment_used_Value() => 
		new CqlCode("98181-1", "http://loinc.org", null, null);

    [CqlDeclaration("Medical equipment used")]
	public CqlCode Medical_equipment_used() => 
		__Medical_equipment_used.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("71802-3", "http://loinc.org", null, null),
			new CqlCode("98181-1", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("160734000", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.8.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		var a_ = this.Frailty_Device();
		var b_ = context.Operators.RetrieveByValueSet<DeviceRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<DeviceRequest>(a_, null);
		var e_ = context.Operators.Union<DeviceRequest>(b_, d_);
		var f_ = Status_1_6_000.isDeviceOrder(e_);
		bool? g_(DeviceRequest FrailtyDeviceOrder)
		{
			var al_ = QICoreCommon_2_0_000.doNotPerform(FrailtyDeviceOrder);
			var am_ = context.Operators.IsTrue(al_);
			var an_ = context.Operators.Not(am_);
			var ao_ = this.Measurement_Period();
			var ap_ = FrailtyDeviceOrder?.AuthoredOnElement;
			var aq_ = context.Operators.Convert<CqlDateTime>(ap_);
			var ar_ = QICoreCommon_2_0_000.toInterval((aq_ as object));
			var as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, "day");
			var at_ = context.Operators.And(an_, as_);

			return at_;
		};
		var h_ = context.Operators.Where<DeviceRequest>(f_, g_);
		var i_ = context.Operators.Exists<DeviceRequest>(h_);
		var j_ = this.Medical_equipment_used();
		var k_ = context.Operators.ToList<CqlCode>(j_);
		var l_ = context.Operators.RetrieveByCodes<Observation>(k_, null);
		var m_ = Status_1_6_000.isAssessmentPerformed(l_);
		bool? n_(Observation EquipmentUsed)
		{
			var au_ = EquipmentUsed?.Value;
			var av_ = FHIRHelpers_4_3_000.ToValue(au_);
			var aw_ = this.Frailty_Device();
			var ax_ = context.Operators.ConceptInValueSet((av_ as CqlConcept), aw_);
			var ay_ = EquipmentUsed?.Effective;
			var az_ = FHIRHelpers_4_3_000.ToValue(ay_);
			var ba_ = QICoreCommon_2_0_000.toInterval(az_);
			var bb_ = context.Operators.End(ba_);
			var bc_ = this.Measurement_Period();
			var bd_ = context.Operators.In<CqlDateTime>(bb_, bc_, "day");
			var be_ = context.Operators.And(ax_, bd_);

			return be_;
		};
		var o_ = context.Operators.Where<Observation>(m_, n_);
		var p_ = context.Operators.Exists<Observation>(o_);
		var q_ = context.Operators.Or(i_, p_);
		var r_ = this.Frailty_Diagnosis();
		var s_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
		bool? t_(Condition FrailtyDiagnosis)
		{
			var bf_ = QICoreCommon_2_0_000.prevalenceInterval(FrailtyDiagnosis);
			var bg_ = this.Measurement_Period();
			var bh_ = context.Operators.Overlaps(bf_, bg_, "day");

			return bh_;
		};
		var u_ = context.Operators.Where<Condition>(s_, t_);
		var v_ = context.Operators.Exists<Condition>(u_);
		var w_ = context.Operators.Or(q_, v_);
		var x_ = this.Frailty_Encounter();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = Status_1_6_000.isEncounterPerformed(y_);
		bool? aa_(Encounter FrailtyEncounter)
		{
			var bi_ = FrailtyEncounter?.Period;
			var bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
			var bk_ = QICoreCommon_2_0_000.toInterval((bj_ as object));
			var bl_ = this.Measurement_Period();
			var bm_ = context.Operators.Overlaps(bk_, bl_, "day");

			return bm_;
		};
		var ab_ = context.Operators.Where<Encounter>(z_, aa_);
		var ac_ = context.Operators.Exists<Encounter>(ab_);
		var ad_ = context.Operators.Or(w_, ac_);
		var ae_ = this.Frailty_Symptom();
		var af_ = context.Operators.RetrieveByValueSet<Observation>(ae_, null);
		var ag_ = Status_1_6_000.isSymptom(af_);
		bool? ah_(Observation FrailtySymptom)
		{
			var bn_ = FrailtySymptom?.Effective;
			var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
			var bp_ = QICoreCommon_2_0_000.toInterval(bo_);
			var bq_ = this.Measurement_Period();
			var br_ = context.Operators.Overlaps(bp_, bq_, "day");

			return br_;
		};
		var ai_ = context.Operators.Where<Observation>(ag_, ah_);
		var aj_ = context.Operators.Exists<Observation>(ai_);
		var ak_ = context.Operators.Or(ad_, aj_);

		return ak_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty() => 
		__Has_Criteria_Indicating_Frailty.Value;

	private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		var a_ = this.Outpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Observation();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Emergency_Department_Evaluation_and_Management_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Nonacute_Inpatient();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = Status_1_6_000.isEncounterPerformed(k_);
		bool? m_(Encounter OutpatientEncounter)
		{
			var o_ = CQMCommon_2_0_000.encounterDiagnosis(OutpatientEncounter);
			bool? p_(Condition Diagnosis)
			{
				var af_ = Diagnosis?.Code;
				var ag_ = FHIRHelpers_4_3_000.ToConcept(af_);
				var ah_ = this.Advanced_Illness();
				var ai_ = context.Operators.ConceptInValueSet(ag_, ah_);

				return ai_;
			};
			var q_ = context.Operators.Where<Condition>(o_, p_);
			var r_ = context.Operators.Exists<Condition>(q_);
			var s_ = OutpatientEncounter?.Period;
			var t_ = FHIRHelpers_4_3_000.ToInterval(s_);
			var u_ = QICoreCommon_2_0_000.toInterval((t_ as object));
			var v_ = context.Operators.Start(u_);
			var w_ = this.Measurement_Period();
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.Quantity(1m, "year");
			var z_ = context.Operators.Subtract(x_, y_);
			var ab_ = context.Operators.End(w_);
			var ac_ = context.Operators.Interval(z_, ab_, true, true);
			var ad_ = context.Operators.In<CqlDateTime>(v_, ac_, "day");
			var ae_ = context.Operators.And(r_, ad_);

			return ae_;
		};
		var n_ = context.Operators.Where<Encounter>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private bool? Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = this.Outpatient_Encounters_with_Advanced_Illness();
		var c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
		Tuple_EaLaedgLDgRRYaLbKIIcBTOiA d_(ValueTuple<Encounter, Encounter> _valueTuple)
		{
			var k_ = new Tuple_EaLaedgLDgRRYaLbKIIcBTOiA
			{
				OutpatientEncounter1 = _valueTuple.Item1,
				OutpatientEncounter2 = _valueTuple.Item2,
			};

			return k_;
		};
		var e_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, Tuple_EaLaedgLDgRRYaLbKIIcBTOiA>(c_, d_);
		bool? f_(Tuple_EaLaedgLDgRRYaLbKIIcBTOiA tuple_ealaedgldgrryalbkiicbtoia)
		{
			var l_ = tuple_ealaedgldgrryalbkiicbtoia.OutpatientEncounter2?.Period;
			var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			var n_ = context.Operators.End(m_);
			var o_ = tuple_ealaedgldgrryalbkiicbtoia.OutpatientEncounter1?.Period;
			var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			var q_ = context.Operators.End(p_);
			var r_ = context.Operators.Quantity(1m, "day");
			var s_ = context.Operators.Add(q_, r_);
			var t_ = context.Operators.SameOrAfter(n_, s_, "day");

			return t_;
		};
		var g_ = context.Operators.Where<Tuple_EaLaedgLDgRRYaLbKIIcBTOiA>(e_, f_);
		Encounter h_(Tuple_EaLaedgLDgRRYaLbKIIcBTOiA tuple_ealaedgldgrryalbkiicbtoia) => 
			tuple_ealaedgldgrryalbkiicbtoia.OutpatientEncounter1;
		var i_ = context.Operators.Select<Tuple_EaLaedgLDgRRYaLbKIIcBTOiA, Encounter>(g_, h_);
		var j_ = context.Operators.Exists<Encounter>(i_);

		return j_;
	}

    [CqlDeclaration("Has Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
	public bool? Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private bool? Has_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		var a_ = this.Acute_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = Status_1_6_000.isEncounterPerformed(b_);
		bool? d_(Encounter InpatientEncounter)
		{
			var g_ = CQMCommon_2_0_000.encounterDiagnosis(InpatientEncounter);
			bool? h_(Condition Diagnosis)
			{
				var x_ = Diagnosis?.Code;
				var y_ = FHIRHelpers_4_3_000.ToConcept(x_);
				var z_ = this.Advanced_Illness();
				var aa_ = context.Operators.ConceptInValueSet(y_, z_);

				return aa_;
			};
			var i_ = context.Operators.Where<Condition>(g_, h_);
			var j_ = context.Operators.Exists<Condition>(i_);
			var k_ = InpatientEncounter?.Period;
			var l_ = FHIRHelpers_4_3_000.ToInterval(k_);
			var m_ = QICoreCommon_2_0_000.toInterval((l_ as object));
			var n_ = context.Operators.Start(m_);
			var o_ = this.Measurement_Period();
			var p_ = context.Operators.Start(o_);
			var q_ = context.Operators.Quantity(1m, "year");
			var r_ = context.Operators.Subtract(p_, q_);
			var t_ = context.Operators.End(o_);
			var u_ = context.Operators.Interval(r_, t_, true, true);
			var v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
			var w_ = context.Operators.And(j_, v_);

			return w_;
		};
		var e_ = context.Operators.Where<Encounter>(c_, d_);
		var f_ = context.Operators.Exists<Encounter>(e_);

		return f_;
	}

    [CqlDeclaration("Has Inpatient Encounter with Advanced Illness")]
	public bool? Has_Inpatient_Encounter_with_Advanced_Illness() => 
		__Has_Inpatient_Encounter_with_Advanced_Illness.Value;

	private bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period_Value()
	{
		var a_ = this.Dementia_Medications();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		var f_ = Status_1_6_000.isMedicationActive(e_);
		bool? g_(MedicationRequest DementiaMedication)
		{
			var j_ = DementiaMedication?.DoNotPerformElement;
			var k_ = j_?.Value;
			var l_ = context.Operators.IsTrue(k_);
			var m_ = context.Operators.Not(l_);
			var n_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(DementiaMedication);
			var o_ = n_?.low;
			var p_ = context.Operators.ConvertDateToDateTime(o_);
			var r_ = n_?.high;
			var s_ = context.Operators.ConvertDateToDateTime(r_);
			var u_ = n_?.lowClosed;
			var w_ = n_?.highClosed;
			var x_ = context.Operators.Interval(p_, s_, u_, w_);
			var y_ = this.Measurement_Period();
			var z_ = context.Operators.Start(y_);
			var aa_ = context.Operators.Quantity(1m, "year");
			var ab_ = context.Operators.Subtract(z_, aa_);
			var ad_ = context.Operators.End(y_);
			var ae_ = context.Operators.Interval(ab_, ad_, true, true);
			var af_ = context.Operators.Overlaps(x_, ae_, "day");
			var ag_ = context.Operators.And(m_, af_);

			return ag_;
		};
		var h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		var i_ = context.Operators.Exists<MedicationRequest>(h_);

		return i_;
	}

    [CqlDeclaration("Has Dementia Medications in Year Before or During Measurement Period")]
	public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period() => 
		__Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period.Value;

	private bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, 66);
		var h_ = this.Has_Criteria_Indicating_Frailty();
		var i_ = context.Operators.And(g_, h_);
		var j_ = this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var k_ = this.Has_Inpatient_Encounter_with_Advanced_Illness();
		var l_ = context.Operators.Or(j_, k_);
		var m_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period();
		var n_ = context.Operators.Or(l_, m_);
		var o_ = context.Operators.And(i_, n_);

		return o_;
	}

    [CqlDeclaration("Is Age 66 or Older with Advanced Illness and Frailty")]
	public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty() => 
		__Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty.Value;

	private bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(66, 80, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);
		var i_ = this.Has_Criteria_Indicating_Frailty();
		var j_ = context.Operators.And(h_, i_);
		var k_ = this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		var l_ = this.Has_Inpatient_Encounter_with_Advanced_Illness();
		var m_ = context.Operators.Or(k_, l_);
		var n_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period();
		var o_ = context.Operators.Or(m_, n_);
		var p_ = context.Operators.And(j_, o_);
		var r_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var t_ = context.Operators.End(c_);
		var u_ = context.Operators.DateFrom(t_);
		var v_ = context.Operators.CalculateAgeAt(r_, u_, "year");
		var w_ = context.Operators.GreaterOrEqual(v_, 81);
		var y_ = context.Operators.And(w_, i_);
		var z_ = context.Operators.Or(p_, y_);

		return z_;
	}

    [CqlDeclaration("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
	public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty() => 
		__Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty.Value;

	private bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, 66);
		var h_ = this.Housing_status();
		var i_ = context.Operators.ToList<CqlCode>(h_);
		var j_ = context.Operators.RetrieveByCodes<Observation>(i_, null);
		var k_ = Status_1_6_000.isAssessmentPerformed(j_);
		bool? l_(Observation HousingStatus)
		{
			var w_ = HousingStatus?.Effective;
			var x_ = FHIRHelpers_4_3_000.ToValue(w_);
			var y_ = QICoreCommon_2_0_000.toInterval(x_);
			var z_ = context.Operators.End(y_);
			var aa_ = this.Measurement_Period();
			var ab_ = context.Operators.End(aa_);
			var ac_ = context.Operators.SameOrBefore(z_, ab_, "day");

			return ac_;
		};
		var m_ = context.Operators.Where<Observation>(k_, l_);
		object n_(Observation @this)
		{
			var ad_ = @this?.Effective;
			var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			var af_ = QICoreCommon_2_0_000.toInterval(ae_);
			var ag_ = context.Operators.End(af_);

			return ag_;
		};
		var o_ = context.Operators.SortBy<Observation>(m_, n_, System.ComponentModel.ListSortDirection.Ascending);
		var p_ = context.Operators.Last<Observation>(o_);
		var q_ = new Observation[]
		{
			p_,
		};
		bool? r_(Observation LastHousingStatus)
		{
			var ah_ = LastHousingStatus?.Value;
			var ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
			var aj_ = this.Lives_in_a_nursing_home__finding_();
			var ak_ = context.Operators.ConvertCodeToConcept(aj_);
			var al_ = context.Operators.Equivalent((ai_ as CqlConcept), ak_);

			return al_;
		};
		var s_ = context.Operators.Where<Observation>((IEnumerable<Observation>)q_, r_);
		var t_ = context.Operators.SingletonFrom<Observation>(s_);
		var u_ = context.Operators.Not((bool?)(t_ is null));
		var v_ = context.Operators.And(g_, u_);

		return v_;
	}

    [CqlDeclaration("Is Age 66 or Older Living Long Term in a Nursing Home")]
	public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home() => 
		__Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home.Value;

}
