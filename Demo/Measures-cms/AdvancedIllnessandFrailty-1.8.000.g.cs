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
		CqlCode[] a_ = new CqlCode[]
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
		CqlCode[] a_ = new CqlCode[]
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
		object a_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.8.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		CqlValueSet a_ = this.Frailty_Device();
		IEnumerable<DeviceRequest> b_ = context.Operators.RetrieveByValueSet<DeviceRequest>(a_, null);
		IEnumerable<DeviceRequest> d_ = context.Operators.RetrieveByValueSet<DeviceRequest>(a_, null);
		IEnumerable<DeviceRequest> e_ = context.Operators.ListUnion<DeviceRequest>(b_, d_);
		IEnumerable<DeviceRequest> f_ = Status_1_6_000.isDeviceOrder(e_);
		bool? g_(DeviceRequest FrailtyDeviceOrder)
		{
			bool? al_ = QICoreCommon_2_0_000.doNotPerform(FrailtyDeviceOrder);
			bool? am_ = context.Operators.IsTrue(al_);
			bool? an_ = context.Operators.Not(am_);
			CqlInterval<CqlDateTime> ao_ = this.Measurement_Period();
			CqlDateTime ap_ = context.Operators.Convert<CqlDateTime>(FrailtyDeviceOrder?.AuthoredOnElement);
			CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.toInterval((ap_ as object));
			bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, "day");
			bool? as_ = context.Operators.And(an_, ar_);

			return as_;
		};
		IEnumerable<DeviceRequest> h_ = context.Operators.Where<DeviceRequest>(f_, g_);
		bool? i_ = context.Operators.Exists<DeviceRequest>(h_);
		CqlCode j_ = this.Medical_equipment_used();
		IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
		IEnumerable<Observation> l_ = context.Operators.RetrieveByCodes<Observation>(k_, null);
		IEnumerable<Observation> m_ = Status_1_6_000.isAssessmentPerformed(l_);
		bool? n_(Observation EquipmentUsed)
		{
			object at_ = FHIRHelpers_4_3_000.ToValue(EquipmentUsed?.Value);
			CqlValueSet au_ = this.Frailty_Device();
			bool? av_ = context.Operators.ConceptInValueSet((at_ as CqlConcept), au_);
			object aw_ = FHIRHelpers_4_3_000.ToValue(EquipmentUsed?.Effective);
			CqlInterval<CqlDateTime> ax_ = QICoreCommon_2_0_000.toInterval(aw_);
			CqlDateTime ay_ = context.Operators.End(ax_);
			CqlInterval<CqlDateTime> az_ = this.Measurement_Period();
			bool? ba_ = context.Operators.In<CqlDateTime>(ay_, az_, "day");
			bool? bb_ = context.Operators.And(av_, ba_);

			return bb_;
		};
		IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
		bool? p_ = context.Operators.Exists<Observation>(o_);
		bool? q_ = context.Operators.Or(i_, p_);
		CqlValueSet r_ = this.Frailty_Diagnosis();
		IEnumerable<Condition> s_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
		bool? t_(Condition FrailtyDiagnosis)
		{
			CqlInterval<CqlDateTime> bc_ = QICoreCommon_2_0_000.prevalenceInterval(FrailtyDiagnosis);
			CqlInterval<CqlDateTime> bd_ = this.Measurement_Period();
			bool? be_ = context.Operators.Overlaps(bc_, bd_, "day");

			return be_;
		};
		IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
		bool? v_ = context.Operators.Exists<Condition>(u_);
		bool? w_ = context.Operators.Or(q_, v_);
		CqlValueSet x_ = this.Frailty_Encounter();
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		IEnumerable<Encounter> z_ = Status_1_6_000.isEncounterPerformed(y_);
		bool? aa_(Encounter FrailtyEncounter)
		{
			CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_3_000.ToInterval(FrailtyEncounter?.Period);
			CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_0_000.toInterval((bf_ as object));
			CqlInterval<CqlDateTime> bh_ = this.Measurement_Period();
			bool? bi_ = context.Operators.Overlaps(bg_, bh_, "day");

			return bi_;
		};
		IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
		bool? ac_ = context.Operators.Exists<Encounter>(ab_);
		bool? ad_ = context.Operators.Or(w_, ac_);
		CqlValueSet ae_ = this.Frailty_Symptom();
		IEnumerable<Observation> af_ = context.Operators.RetrieveByValueSet<Observation>(ae_, null);
		IEnumerable<Observation> ag_ = Status_1_6_000.isSymptom(af_);
		bool? ah_(Observation FrailtySymptom)
		{
			object bj_ = FHIRHelpers_4_3_000.ToValue(FrailtySymptom?.Effective);
			CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_0_000.toInterval(bj_);
			CqlInterval<CqlDateTime> bl_ = this.Measurement_Period();
			bool? bm_ = context.Operators.Overlaps(bk_, bl_, "day");

			return bm_;
		};
		IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(ag_, ah_);
		bool? aj_ = context.Operators.Exists<Observation>(ai_);
		bool? ak_ = context.Operators.Or(ad_, aj_);

		return ak_;
	}

    [CqlDeclaration("Has Criteria Indicating Frailty")]
	public bool? Has_Criteria_Indicating_Frailty() => 
		__Has_Criteria_Indicating_Frailty.Value;

	private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Value()
	{
		CqlValueSet a_ = this.Outpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Observation();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Emergency_Department_Evaluation_and_Management_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Nonacute_Inpatient();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		IEnumerable<Encounter> l_ = Status_1_6_000.isEncounterPerformed(k_);
		bool? m_(Encounter OutpatientEncounter)
		{
			IEnumerable<Condition> o_ = CQMCommon_2_0_000.encounterDiagnosis(OutpatientEncounter);
			bool? p_(Condition Diagnosis)
			{
				CqlConcept ae_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.Code);
				CqlValueSet af_ = this.Advanced_Illness();
				bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);

				return ag_;
			};
			IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
			bool? r_ = context.Operators.Exists<Condition>(q_);
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(OutpatientEncounter?.Period);
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.toInterval((s_ as object));
			CqlDateTime u_ = context.Operators.Start(t_);
			CqlInterval<CqlDateTime> v_ = this.Measurement_Period();
			CqlDateTime w_ = context.Operators.Start(v_);
			CqlQuantity x_ = context.Operators.Quantity(1m, "year");
			CqlDateTime y_ = context.Operators.Subtract(w_, x_);
			CqlDateTime aa_ = context.Operators.End(v_);
			CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(y_, aa_, true, true);
			bool? ac_ = context.Operators.In<CqlDateTime>(u_, ab_, "day");
			bool? ad_ = context.Operators.And(r_, ac_);

			return ad_;
		};
		IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private bool? Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		IEnumerable<Encounter> a_ = this.Outpatient_Encounters_with_Advanced_Illness();
		IEnumerable<ValueTuple<Encounter,Encounter>> c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
		Tuple_EYKUVMTUWTABihhEAdHIGbSFe d_(ValueTuple<Encounter,Encounter> _valueTuple)
		{
			Tuple_EYKUVMTUWTABihhEAdHIGbSFe k_ = new Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = _valueTuple.Item1,
				OutpatientEncounter2 = _valueTuple.Item2,
			};

			return k_;
		};
		IEnumerable<Tuple_EYKUVMTUWTABihhEAdHIGbSFe> e_ = context.Operators.Select<ValueTuple<Encounter,Encounter>, Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(c_, d_);
		bool? f_(Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2?.Period);
			CqlDateTime m_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1?.Period);
			CqlDateTime o_ = context.Operators.End(n_);
			CqlQuantity p_ = context.Operators.Quantity(1m, "day");
			CqlDateTime q_ = context.Operators.Add(o_, p_);
			bool? r_ = context.Operators.SameOrAfter(m_, q_, "day");

			return r_;
		};
		IEnumerable<Tuple_EYKUVMTUWTABihhEAdHIGbSFe> g_ = context.Operators.Where<Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(e_, f_);
		Encounter h_(Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => 
			tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
		IEnumerable<Encounter> i_ = context.Operators.Select<Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(g_, h_);
		bool? j_ = context.Operators.Exists<Encounter>(i_);

		return j_;
	}

    [CqlDeclaration("Has Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
	public bool? Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private bool? Has_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		CqlValueSet a_ = this.Acute_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Encounter> c_ = Status_1_6_000.isEncounterPerformed(b_);
		bool? d_(Encounter InpatientEncounter)
		{
			IEnumerable<Condition> g_ = CQMCommon_2_0_000.encounterDiagnosis(InpatientEncounter);
			bool? h_(Condition Diagnosis)
			{
				CqlConcept w_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.Code);
				CqlValueSet x_ = this.Advanced_Illness();
				bool? y_ = context.Operators.ConceptInValueSet(w_, x_);

				return y_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			bool? j_ = context.Operators.Exists<Condition>(i_);
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval((k_ as object));
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			CqlDateTime o_ = context.Operators.Start(n_);
			CqlQuantity p_ = context.Operators.Quantity(1m, "year");
			CqlDateTime q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
			bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, "day");
			bool? v_ = context.Operators.And(j_, u_);

			return v_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
		bool? f_ = context.Operators.Exists<Encounter>(e_);

		return f_;
	}

    [CqlDeclaration("Has Inpatient Encounter with Advanced Illness")]
	public bool? Has_Inpatient_Encounter_with_Advanced_Illness() => 
		__Has_Inpatient_Encounter_with_Advanced_Illness.Value;

	private bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Dementia_Medications();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.isMedicationActive(e_);
		bool? g_(MedicationRequest DementiaMedication)
		{
			bool? j_ = context.Operators.IsTrue(DementiaMedication?.DoNotPerformElement?.Value);
			bool? k_ = context.Operators.Not(j_);
			CqlInterval<CqlDate> l_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(DementiaMedication);
			CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_?.low);
			CqlDateTime o_ = context.Operators.ConvertDateToDateTime(l_?.high);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(m_, o_, l_?.lowClosed, l_?.highClosed);
			CqlInterval<CqlDateTime> s_ = this.Measurement_Period();
			CqlDateTime t_ = context.Operators.Start(s_);
			CqlQuantity u_ = context.Operators.Quantity(1m, "year");
			CqlDateTime v_ = context.Operators.Subtract(t_, u_);
			CqlDateTime x_ = context.Operators.End(s_);
			CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, true);
			bool? z_ = context.Operators.Overlaps(r_, y_, "day");
			bool? aa_ = context.Operators.And(k_, z_);

			return aa_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		bool? i_ = context.Operators.Exists<MedicationRequest>(h_);

		return i_;
	}

    [CqlDeclaration("Has Dementia Medications in Year Before or During Measurement Period")]
	public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period() => 
		__Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period.Value;

	private bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.End(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 66);
		bool? h_ = this.Has_Criteria_Indicating_Frailty();
		bool? i_ = context.Operators.And(g_, h_);
		bool? j_ = this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? k_ = this.Has_Inpatient_Encounter_with_Advanced_Illness();
		bool? l_ = context.Operators.Or(j_, k_);
		bool? m_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period();
		bool? n_ = context.Operators.Or(l_, m_);
		bool? o_ = context.Operators.And(i_, n_);

		return o_;
	}

    [CqlDeclaration("Is Age 66 or Older with Advanced Illness and Frailty")]
	public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty() => 
		__Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty.Value;

	private bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.End(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		CqlInterval<int?> g_ = context.Operators.Interval(66, 80, true, true);
		bool? h_ = context.Operators.In<int?>(f_, g_, null);
		bool? i_ = this.Has_Criteria_Indicating_Frailty();
		bool? j_ = context.Operators.And(h_, i_);
		bool? k_ = this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? l_ = this.Has_Inpatient_Encounter_with_Advanced_Illness();
		bool? m_ = context.Operators.Or(k_, l_);
		bool? n_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period();
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = context.Operators.And(j_, o_);
		CqlDate r_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlDateTime t_ = context.Operators.End(c_);
		CqlDate u_ = context.Operators.DateFrom(t_);
		int? v_ = context.Operators.CalculateAgeAt(r_, u_, "year");
		bool? w_ = context.Operators.GreaterOrEqual(v_, 81);
		bool? y_ = context.Operators.And(w_, i_);
		bool? z_ = context.Operators.Or(p_, y_);

		return z_;
	}

    [CqlDeclaration("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
	public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty() => 
		__Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty.Value;

	private bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.End(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 66);
		CqlCode h_ = this.Housing_status();
		IEnumerable<CqlCode> i_ = context.Operators.ToList<CqlCode>(h_);
		IEnumerable<Observation> j_ = context.Operators.RetrieveByCodes<Observation>(i_, null);
		IEnumerable<Observation> k_ = Status_1_6_000.isAssessmentPerformed(j_);
		bool? l_(Observation HousingStatus)
		{
			object w_ = FHIRHelpers_4_3_000.ToValue(HousingStatus?.Effective);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.toInterval(w_);
			CqlDateTime y_ = context.Operators.End(x_);
			CqlInterval<CqlDateTime> z_ = this.Measurement_Period();
			CqlDateTime aa_ = context.Operators.End(z_);
			bool? ab_ = context.Operators.SameOrBefore(y_, aa_, "day");

			return ab_;
		};
		IEnumerable<Observation> m_ = context.Operators.Where<Observation>(k_, l_);
		object n_(Observation @this)
		{
			object ac_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_0_000.toInterval(ac_);
			CqlDateTime ae_ = context.Operators.End(ad_);

			return ae_;
		};
		IEnumerable<Observation> o_ = context.Operators.SortBy<Observation>(m_, n_, System.ComponentModel.ListSortDirection.Ascending);
		Observation p_ = context.Operators.Last<Observation>(o_);
		Observation[] q_ = new Observation[]
		{
			p_,
		};
		bool? r_(Observation LastHousingStatus)
		{
			object af_ = FHIRHelpers_4_3_000.ToValue(LastHousingStatus?.Value);
			CqlCode ag_ = this.Lives_in_a_nursing_home__finding_();
			CqlConcept ah_ = context.Operators.ConvertCodeToConcept(ag_);
			bool? ai_ = context.Operators.Equivalent((af_ as CqlConcept), ah_);

			return ai_;
		};
		IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
		Observation t_ = context.Operators.SingletonFrom<Observation>(s_);
		bool? u_ = context.Operators.Not((bool?)(t_ is null));
		bool? v_ = context.Operators.And(g_, u_);

		return v_;
	}

    [CqlDeclaration("Is Age 66 or Older Living Long Term in a Nursing Home")]
	public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home() => 
		__Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home.Value;

}
