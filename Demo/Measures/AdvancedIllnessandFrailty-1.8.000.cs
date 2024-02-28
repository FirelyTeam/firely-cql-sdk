using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
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
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
		var e_ = context.Operators.ListUnion<DeviceRequest>(b_, d_);
		var f_ = Status_1_6_000.isDeviceOrder(e_);
		bool? g_(DeviceRequest FrailtyDeviceOrder)
		{
			var al_ = QICoreCommon_2_0_000.doNotPerform(FrailtyDeviceOrder);
			var am_ = context.Operators.IsTrue(al_);
			var an_ = context.Operators.Not(am_);
			var ao_ = this.Measurement_Period();
			var ap_ = context.Operators.Convert<CqlDateTime>(FrailtyDeviceOrder?.AuthoredOnElement);
			var aq_ = QICoreCommon_2_0_000.toInterval((ap_ as object));
			var ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, "day");
			var as_ = context.Operators.And(an_, ar_);

			return as_;
		};
		var h_ = context.Operators.WhereOrNull<DeviceRequest>(f_, g_);
		var i_ = context.Operators.ExistsInList<DeviceRequest>(h_);
		var j_ = this.Medical_equipment_used();
		var k_ = context.Operators.ToList<CqlCode>(j_);
		var l_ = context.Operators.RetrieveByCodes<Observation>(k_, null);
		var m_ = Status_1_6_000.isAssessmentPerformed(l_);
		bool? n_(Observation EquipmentUsed)
		{
			var at_ = FHIRHelpers_4_3_000.ToValue(EquipmentUsed?.Value);
			var au_ = this.Frailty_Device();
			var av_ = context.Operators.ConceptInValueSet((at_ as CqlConcept), au_);
			var aw_ = FHIRHelpers_4_3_000.ToValue(EquipmentUsed?.Effective);
			var ax_ = QICoreCommon_2_0_000.toInterval(aw_);
			var ay_ = context.Operators.End(ax_);
			var az_ = this.Measurement_Period();
			var ba_ = context.Operators.ElementInInterval<CqlDateTime>(ay_, az_, "day");
			var bb_ = context.Operators.And(av_, ba_);

			return bb_;
		};
		var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
		var p_ = context.Operators.ExistsInList<Observation>(o_);
		var q_ = context.Operators.Or(i_, p_);
		var r_ = this.Frailty_Diagnosis();
		var s_ = context.Operators.RetrieveByValueSet<Condition>(r_, null);
		bool? t_(Condition FrailtyDiagnosis)
		{
			var bc_ = QICoreCommon_2_0_000.prevalenceInterval(FrailtyDiagnosis);
			var bd_ = this.Measurement_Period();
			var be_ = context.Operators.Overlaps(bc_, bd_, "day");

			return be_;
		};
		var u_ = context.Operators.WhereOrNull<Condition>(s_, t_);
		var v_ = context.Operators.ExistsInList<Condition>(u_);
		var w_ = context.Operators.Or(q_, v_);
		var x_ = this.Frailty_Encounter();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = Status_1_6_000.isEncounterPerformed(y_);
		bool? aa_(Encounter FrailtyEncounter)
		{
			var bf_ = FHIRHelpers_4_3_000.ToInterval(FrailtyEncounter?.Period);
			var bg_ = QICoreCommon_2_0_000.toInterval((bf_ as object));
			var bh_ = this.Measurement_Period();
			var bi_ = context.Operators.Overlaps(bg_, bh_, "day");

			return bi_;
		};
		var ab_ = context.Operators.WhereOrNull<Encounter>(z_, aa_);
		var ac_ = context.Operators.ExistsInList<Encounter>(ab_);
		var ad_ = context.Operators.Or(w_, ac_);
		var ae_ = this.Frailty_Symptom();
		var af_ = context.Operators.RetrieveByValueSet<Observation>(ae_, null);
		var ag_ = Status_1_6_000.isSymptom(af_);
		bool? ah_(Observation FrailtySymptom)
		{
			var bj_ = FHIRHelpers_4_3_000.ToValue(FrailtySymptom?.Effective);
			var bk_ = QICoreCommon_2_0_000.toInterval(bj_);
			var bl_ = this.Measurement_Period();
			var bm_ = context.Operators.Overlaps(bk_, bl_, "day");

			return bm_;
		};
		var ai_ = context.Operators.WhereOrNull<Observation>(ag_, ah_);
		var aj_ = context.Operators.ExistsInList<Observation>(ai_);
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
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Emergency_Department_Evaluation_and_Management_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Nonacute_Inpatient();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = Status_1_6_000.isEncounterPerformed(k_);
		bool? m_(Encounter OutpatientEncounter)
		{
			var o_ = CQMCommon_2_0_000.encounterDiagnosis(OutpatientEncounter);
			bool? p_(Condition Diagnosis)
			{
				var ae_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.Code);
				var af_ = this.Advanced_Illness();
				var ag_ = context.Operators.ConceptInValueSet(ae_, af_);

				return ag_;
			};
			var q_ = context.Operators.WhereOrNull<Condition>(o_, p_);
			var r_ = context.Operators.ExistsInList<Condition>(q_);
			var s_ = FHIRHelpers_4_3_000.ToInterval(OutpatientEncounter?.Period);
			var t_ = QICoreCommon_2_0_000.toInterval((s_ as object));
			var u_ = context.Operators.Start(t_);
			var v_ = this.Measurement_Period();
			var w_ = context.Operators.Start(v_);
			var x_ = context.Operators.Quantity(1m, "year");
			var y_ = context.Operators.Subtract(w_, x_);
			var aa_ = context.Operators.End(v_);
			var ab_ = context.Operators.Interval(y_, aa_, true, true);
			var ac_ = context.Operators.ElementInInterval<CqlDateTime>(u_, ab_, "day");
			var ad_ = context.Operators.And(r_, ac_);

			return ad_;
		};
		var n_ = context.Operators.WhereOrNull<Encounter>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Outpatient Encounters with Advanced Illness")]
	public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness() => 
		__Outpatient_Encounters_with_Advanced_Illness.Value;

	private bool? Has_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Value()
	{
		var a_ = this.Outpatient_Encounters_with_Advanced_Illness();
		IEnumerable<Encounter> b_(Encounter _OutpatientEncounter1)
		{
			var j_ = this.Outpatient_Encounters_with_Advanced_Illness();

			return j_;
		};
		Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe c_(Encounter _OutpatientEncounter1, Encounter _OutpatientEncounter2)
		{
			var k_ = new Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe
			{
				OutpatientEncounter1 = _OutpatientEncounter1,
				OutpatientEncounter2 = _OutpatientEncounter2,
			};

			return k_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, Encounter, Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(a_, b_, c_);
		bool? e_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe)
		{
			var l_ = FHIRHelpers_4_3_000.ToInterval(tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter2?.Period);
			var m_ = context.Operators.End(l_);
			var n_ = FHIRHelpers_4_3_000.ToInterval(tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1?.Period);
			var o_ = context.Operators.End(n_);
			var p_ = context.Operators.Quantity(1m, "day");
			var q_ = context.Operators.Add(o_, p_);
			var r_ = context.Operators.SameOrAfter(m_, q_, "day");

			return r_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe>(d_, e_);
		Encounter g_(Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe tuple_eykuvmtuwtabihheadhigbsfe) => 
			tuple_eykuvmtuwtabihheadhigbsfe.OutpatientEncounter1;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_EYKUVMTUWTABihhEAdHIGbSFe, Encounter>(f_, g_);
		var i_ = context.Operators.ExistsInList<Encounter>(h_);

		return i_;
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
				var w_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.Code);
				var x_ = this.Advanced_Illness();
				var y_ = context.Operators.ConceptInValueSet(w_, x_);

				return y_;
			};
			var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);
			var j_ = context.Operators.ExistsInList<Condition>(i_);
			var k_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			var l_ = QICoreCommon_2_0_000.toInterval((k_ as object));
			var m_ = context.Operators.Start(l_);
			var n_ = this.Measurement_Period();
			var o_ = context.Operators.Start(n_);
			var p_ = context.Operators.Quantity(1m, "year");
			var q_ = context.Operators.Subtract(o_, p_);
			var s_ = context.Operators.End(n_);
			var t_ = context.Operators.Interval(q_, s_, true, true);
			var u_ = context.Operators.ElementInInterval<CqlDateTime>(m_, t_, "day");
			var v_ = context.Operators.And(j_, u_);

			return v_;
		};
		var e_ = context.Operators.WhereOrNull<Encounter>(c_, d_);
		var f_ = context.Operators.ExistsInList<Encounter>(e_);

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
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = Status_1_6_000.isMedicationActive(e_);
		bool? g_(MedicationRequest DementiaMedication)
		{
			var j_ = context.Operators.IsTrue(DementiaMedication?.DoNotPerformElement?.Value);
			var k_ = context.Operators.Not(j_);
			var l_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(DementiaMedication);
			var m_ = context.Operators.ConvertDateToDateTime(l_?.low);
			var o_ = context.Operators.ConvertDateToDateTime(l_?.high);
			var r_ = context.Operators.Interval(m_, o_, l_?.lowClosed, l_?.highClosed);
			var s_ = this.Measurement_Period();
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.Quantity(1m, "year");
			var v_ = context.Operators.Subtract(t_, u_);
			var x_ = context.Operators.End(s_);
			var y_ = context.Operators.Interval(v_, x_, true, true);
			var z_ = context.Operators.Overlaps(r_, y_, "day");
			var aa_ = context.Operators.And(k_, z_);

			return aa_;
		};
		var h_ = context.Operators.WhereOrNull<MedicationRequest>(f_, g_);
		var i_ = context.Operators.ExistsInList<MedicationRequest>(h_);

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
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)66);
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
		var g_ = context.Operators.Interval((int?)66, (int?)80, true, true);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);
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
		var w_ = context.Operators.GreaterOrEqual(v_, (int?)81);
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
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)66);
		var h_ = this.Housing_status();
		var i_ = context.Operators.ToList<CqlCode>(h_);
		var j_ = context.Operators.RetrieveByCodes<Observation>(i_, null);
		var k_ = Status_1_6_000.isAssessmentPerformed(j_);
		bool? l_(Observation HousingStatus)
		{
			var w_ = FHIRHelpers_4_3_000.ToValue(HousingStatus?.Effective);
			var x_ = QICoreCommon_2_0_000.toInterval(w_);
			var y_ = context.Operators.End(x_);
			var z_ = this.Measurement_Period();
			var aa_ = context.Operators.End(z_);
			var ab_ = context.Operators.SameOrBefore(y_, aa_, "day");

			return ab_;
		};
		var m_ = context.Operators.WhereOrNull<Observation>(k_, l_);
		object n_(Observation @this)
		{
			var ac_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var ad_ = QICoreCommon_2_0_000.toInterval(ac_);
			var ae_ = context.Operators.End(ad_);

			return ae_;
		};
		var o_ = context.Operators.ListSortBy<Observation>(m_, n_, System.ComponentModel.ListSortDirection.Ascending);
		var p_ = context.Operators.LastOfList<Observation>(o_);
		var q_ = new Observation[]
		{
			p_,
		};
		bool? r_(Observation LastHousingStatus)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(LastHousingStatus?.Value);
			var ag_ = this.Lives_in_a_nursing_home__finding_();
			var ah_ = context.Operators.ConvertCodeToConcept(ag_);
			var ai_ = context.Operators.Equivalent((af_ as CqlConcept), ah_);

			return ai_;
		};
		var s_ = context.Operators.WhereOrNull<Observation>(q_, r_);
		var t_ = context.Operators.SingleOrNull<Observation>(s_);
		var u_ = context.Operators.Not((bool?)(t_ is null));
		var v_ = context.Operators.And(g_, u_);

		return v_;
	}

    [CqlDeclaration("Is Age 66 or Older Living Long Term in a Nursing Home")]
	public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home() => 
		__Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home.Value;

}