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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", default);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
	public CqlValueSet Acute_Inpatient() => 
		__Acute_Inpatient.Value;

	private CqlValueSet Advanced_Illness_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", default);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
	public CqlValueSet Advanced_Illness() => 
		__Advanced_Illness.Value;

	private CqlValueSet Dementia_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", default);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
	public CqlValueSet Dementia_Medications() => 
		__Dementia_Medications.Value;

	private CqlValueSet Emergency_Department_Evaluation_and_Management_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", default);

    [CqlDeclaration("Emergency Department Evaluation and Management Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit() => 
		__Emergency_Department_Evaluation_and_Management_Visit.Value;

	private CqlValueSet Frailty_Device_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", default);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
	public CqlValueSet Frailty_Device() => 
		__Frailty_Device.Value;

	private CqlValueSet Frailty_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", default);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
	public CqlValueSet Frailty_Diagnosis() => 
		__Frailty_Diagnosis.Value;

	private CqlValueSet Frailty_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", default);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
	public CqlValueSet Frailty_Encounter() => 
		__Frailty_Encounter.Value;

	private CqlValueSet Frailty_Symptom_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", default);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
	public CqlValueSet Frailty_Symptom() => 
		__Frailty_Symptom.Value;

	private CqlValueSet Nonacute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", default);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
	public CqlValueSet Nonacute_Inpatient() => 
		__Nonacute_Inpatient.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", default);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation() => 
		__Observation.Value;

	private CqlValueSet Outpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", default);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
	public CqlValueSet Outpatient() => 
		__Outpatient.Value;

	private CqlCode Housing_status_Value() => 
		new CqlCode("71802-3", "http://loinc.org", default, default);

    [CqlDeclaration("Housing status")]
	public CqlCode Housing_status() => 
		__Housing_status.Value;

	private CqlCode Lives_in_a_nursing_home__finding__Value() => 
		new CqlCode("160734000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Lives in a nursing home (finding)")]
	public CqlCode Lives_in_a_nursing_home__finding_() => 
		__Lives_in_a_nursing_home__finding_.Value;

	private CqlCode Medical_equipment_used_Value() => 
		new CqlCode("98181-1", "http://loinc.org", default, default);

    [CqlDeclaration("Medical equipment used")]
	public CqlCode Medical_equipment_used() => 
		__Medical_equipment_used.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("71802-3", "http://loinc.org", default, default),
			new CqlCode("98181-1", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("160734000", "http://snomed.info/sct", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Criteria_Indicating_Frailty_Value()
	{
		CqlValueSet a_ = this.Frailty_Device();
		IEnumerable<DeviceRequest> b_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
		IEnumerable<DeviceRequest> d_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
		IEnumerable<DeviceRequest> e_ = context.Operators.Union<DeviceRequest>(b_, d_);
		IEnumerable<DeviceRequest> f_ = Status_1_6_000.isDeviceOrder(e_);
		bool? g_(DeviceRequest FrailtyDeviceOrder)
		{
			bool? al_ = QICoreCommon_2_0_000.doNotPerform(FrailtyDeviceOrder);
			bool? am_ = context.Operators.IsTrue(al_);
			bool? an_ = context.Operators.Not(am_);
			CqlInterval<CqlDateTime> ao_ = this.Measurement_Period();
			FhirDateTime ap_ = FrailtyDeviceOrder?.AuthoredOnElement;
			CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
			CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_0_000.toInterval(aq_ as object);
			bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, "day");
			bool? at_ = context.Operators.And(an_, as_);

			return at_;
		};
		IEnumerable<DeviceRequest> h_ = context.Operators.Where<DeviceRequest>(f_, g_);
		bool? i_ = context.Operators.Exists<DeviceRequest>(h_);
		CqlCode j_ = this.Medical_equipment_used();
		IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
		IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> m_ = Status_1_6_000.isAssessmentPerformed(l_);
		bool? n_(Observation EquipmentUsed)
		{
			DataType au_ = EquipmentUsed?.Value;
			object av_ = FHIRHelpers_4_3_000.ToValue(au_);
			CqlValueSet aw_ = this.Frailty_Device();
			bool? ax_ = context.Operators.ConceptInValueSet(av_ as CqlConcept, aw_);
			DataType ay_ = EquipmentUsed?.Effective;
			object az_ = FHIRHelpers_4_3_000.ToValue(ay_);
			CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_0_000.toInterval(az_);
			CqlDateTime bb_ = context.Operators.End(ba_);
			CqlInterval<CqlDateTime> bc_ = this.Measurement_Period();
			bool? bd_ = context.Operators.In<CqlDateTime>(bb_, bc_, "day");
			bool? be_ = context.Operators.And(ax_, bd_);

			return be_;
		};
		IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
		bool? p_ = context.Operators.Exists<Observation>(o_);
		bool? q_ = context.Operators.Or(i_, p_);
		CqlValueSet r_ = this.Frailty_Diagnosis();
		IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? t_(Condition FrailtyDiagnosis)
		{
			CqlInterval<CqlDateTime> bf_ = QICoreCommon_2_0_000.prevalenceInterval(FrailtyDiagnosis);
			CqlInterval<CqlDateTime> bg_ = this.Measurement_Period();
			bool? bh_ = context.Operators.Overlaps(bf_, bg_, "day");

			return bh_;
		};
		IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
		bool? v_ = context.Operators.Exists<Condition>(u_);
		bool? w_ = context.Operators.Or(q_, v_);
		CqlValueSet x_ = this.Frailty_Encounter();
		IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> z_ = Status_1_6_000.isEncounterPerformed(y_);
		bool? aa_(Encounter FrailtyEncounter)
		{
			Period bi_ = FrailtyEncounter?.Period;
			CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_3_000.ToInterval(bi_);
			CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_0_000.toInterval(bj_ as object);
			CqlInterval<CqlDateTime> bl_ = this.Measurement_Period();
			bool? bm_ = context.Operators.Overlaps(bk_, bl_, "day");

			return bm_;
		};
		IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);
		bool? ac_ = context.Operators.Exists<Encounter>(ab_);
		bool? ad_ = context.Operators.Or(w_, ac_);
		CqlValueSet ae_ = this.Frailty_Symptom();
		IEnumerable<Observation> af_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> ag_ = Status_1_6_000.isSymptom(af_);
		bool? ah_(Observation FrailtySymptom)
		{
			DataType bn_ = FrailtySymptom?.Effective;
			object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
			CqlInterval<CqlDateTime> bp_ = QICoreCommon_2_0_000.toInterval(bo_);
			CqlInterval<CqlDateTime> bq_ = this.Measurement_Period();
			bool? br_ = context.Operators.Overlaps(bp_, bq_, "day");

			return br_;
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
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Observation();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Emergency_Department_Evaluation_and_Management_Visit();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Nonacute_Inpatient();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		IEnumerable<Encounter> l_ = Status_1_6_000.isEncounterPerformed(k_);
		bool? m_(Encounter OutpatientEncounter)
		{
			IEnumerable<Condition> o_ = CQMCommon_2_0_000.encounterDiagnosis(OutpatientEncounter);
			bool? p_(Condition Diagnosis)
			{
				CodeableConcept af_ = Diagnosis?.Code;
				CqlConcept ag_ = FHIRHelpers_4_3_000.ToConcept(af_);
				CqlValueSet ah_ = this.Advanced_Illness();
				bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);

				return ai_;
			};
			IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
			bool? r_ = context.Operators.Exists<Condition>(q_);
			Period s_ = OutpatientEncounter?.Period;
			CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.toInterval(t_ as object);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period();
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlQuantity y_ = context.Operators.Quantity(1m, "year");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlDateTime ab_ = context.Operators.End(w_);
			CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(z_, ab_, true, true);
			bool? ad_ = context.Operators.In<CqlDateTime>(v_, ac_, "day");
			bool? ae_ = context.Operators.And(r_, ad_);

			return ae_;
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
		IEnumerable<ValueTuple<Encounter, Encounter>> c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
		(Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? d_(ValueTuple<Encounter, Encounter> _valueTuple)
		{
			(Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? k_ = (_valueTuple.Item1, _valueTuple.Item2);

			return k_;
		};
		IEnumerable<(Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> e_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(c_, d_);
		bool? f_((Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia)
		{
			Period l_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(l_);
			CqlDateTime n_ = context.Operators.End(m_);
			Period o_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
			CqlDateTime q_ = context.Operators.End(p_);
			CqlQuantity r_ = context.Operators.Quantity(1m, "day");
			CqlDateTime s_ = context.Operators.Add(q_, r_);
			bool? t_ = context.Operators.SameOrAfter(n_, s_, "day");

			return t_;
		};
		IEnumerable<(Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> g_ = context.Operators.Where<(Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(e_, f_);
		Encounter h_((Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) => 
			tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
		IEnumerable<Encounter> i_ = context.Operators.Select<(Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(g_, h_);
		bool? j_ = context.Operators.Exists<Encounter>(i_);

		return j_;
	}

    [CqlDeclaration("Has Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
	public bool? Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service() => 
		__Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service.Value;

	private bool? Has_Inpatient_Encounter_with_Advanced_Illness_Value()
	{
		CqlValueSet a_ = this.Acute_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> c_ = Status_1_6_000.isEncounterPerformed(b_);
		bool? d_(Encounter InpatientEncounter)
		{
			IEnumerable<Condition> g_ = CQMCommon_2_0_000.encounterDiagnosis(InpatientEncounter);
			bool? h_(Condition Diagnosis)
			{
				CodeableConcept x_ = Diagnosis?.Code;
				CqlConcept y_ = FHIRHelpers_4_3_000.ToConcept(x_);
				CqlValueSet z_ = this.Advanced_Illness();
				bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);

				return aa_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			bool? j_ = context.Operators.Exists<Condition>(i_);
			Period k_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
			CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.toInterval(l_ as object);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period();
			CqlDateTime p_ = context.Operators.Start(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "year");
			CqlDateTime r_ = context.Operators.Subtract(p_, q_);
			CqlDateTime t_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);
			bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
			bool? w_ = context.Operators.And(j_, v_);

			return w_;
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
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.isMedicationActive(e_);
		bool? g_(MedicationRequest DementiaMedication)
		{
			FhirBoolean j_ = DementiaMedication?.DoNotPerformElement;
			bool? k_ = j_?.Value;
			bool? l_ = context.Operators.IsTrue(k_);
			bool? m_ = context.Operators.Not(l_);
			CqlInterval<CqlDate> n_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(DementiaMedication);
			CqlDate o_ = n_?.low;
			CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
			CqlDate r_ = n_?.high;
			CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
			bool? u_ = n_?.lowClosed;
			bool? w_ = n_?.highClosed;
			CqlInterval<CqlDateTime> x_ = context.Operators.Interval(p_, s_, u_, w_);
			CqlInterval<CqlDateTime> y_ = this.Measurement_Period();
			CqlDateTime z_ = context.Operators.Start(y_);
			CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
			CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
			CqlDateTime ad_ = context.Operators.End(y_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, true);
			bool? af_ = context.Operators.Overlaps(x_, ae_, "day");
			bool? ag_ = context.Operators.And(m_, af_);

			return ag_;
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
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
		bool? j_ = this.Has_Criteria_Indicating_Frailty();
		bool? k_ = context.Operators.And(i_, j_);
		bool? l_ = this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? m_ = this.Has_Inpatient_Encounter_with_Advanced_Illness();
		bool? n_ = context.Operators.Or(l_, m_);
		bool? o_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period();
		bool? p_ = context.Operators.Or(n_, o_);
		bool? q_ = context.Operators.And(k_, p_);

		return q_;
	}

    [CqlDeclaration("Is Age 66 or Older with Advanced Illness and Frailty")]
	public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty() => 
		__Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty.Value;

	private bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(66, 80, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		bool? k_ = this.Has_Criteria_Indicating_Frailty();
		bool? l_ = context.Operators.And(j_, k_);
		bool? m_ = this.Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service();
		bool? n_ = this.Has_Inpatient_Encounter_with_Advanced_Illness();
		bool? o_ = context.Operators.Or(m_, n_);
		bool? p_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period();
		bool? q_ = context.Operators.Or(o_, p_);
		bool? r_ = context.Operators.And(l_, q_);
		Date t_ = a_?.BirthDateElement;
		string u_ = t_?.Value;
		CqlDate v_ = context.Operators.ConvertStringToDate(u_);
		CqlDateTime x_ = context.Operators.End(e_);
		CqlDate y_ = context.Operators.DateFrom(x_);
		int? z_ = context.Operators.CalculateAgeAt(v_, y_, "year");
		bool? aa_ = context.Operators.GreaterOrEqual(z_, 81);
		bool? ac_ = context.Operators.And(aa_, k_);
		bool? ad_ = context.Operators.Or(r_, ac_);

		return ad_;
	}

    [CqlDeclaration("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
	public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty() => 
		__Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty.Value;

	private bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
		CqlCode j_ = this.Housing_status();
		IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
		IEnumerable<Observation> l_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> m_ = Status_1_6_000.isAssessmentPerformed(l_);
		bool? n_(Observation HousingStatus)
		{
			DataType y_ = HousingStatus?.Effective;
			object z_ = FHIRHelpers_4_3_000.ToValue(y_);
			CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_0_000.toInterval(z_);
			CqlDateTime ab_ = context.Operators.End(aa_);
			CqlInterval<CqlDateTime> ac_ = this.Measurement_Period();
			CqlDateTime ad_ = context.Operators.End(ac_);
			bool? ae_ = context.Operators.SameOrBefore(ab_, ad_, "day");

			return ae_;
		};
		IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
		object p_(Observation @this)
		{
			DataType af_ = @this?.Effective;
			object ag_ = FHIRHelpers_4_3_000.ToValue(af_);
			CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_0_000.toInterval(ag_);
			CqlDateTime ai_ = context.Operators.End(ah_);

			return ai_;
		};
		IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
		Observation r_ = context.Operators.Last<Observation>(q_);
		Observation[] s_ = [
			r_,
		];
		bool? t_(Observation LastHousingStatus)
		{
			DataType aj_ = LastHousingStatus?.Value;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlCode al_ = this.Lives_in_a_nursing_home__finding_();
			CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
			bool? an_ = context.Operators.Equivalent(ak_ as CqlConcept, am_);

			return an_;
		};
		IEnumerable<Observation> u_ = context.Operators.Where<Observation>((IEnumerable<Observation>)s_, t_);
		Observation v_ = context.Operators.SingletonFrom<Observation>(u_);
		bool? w_ = context.Operators.Not((bool?)(v_ is null));
		bool? x_ = context.Operators.And(i_, w_);

		return x_;
	}

    [CqlDeclaration("Is Age 66 or Older Living Long Term in a Nursing Home")]
	public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home() => 
		__Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home.Value;

}
