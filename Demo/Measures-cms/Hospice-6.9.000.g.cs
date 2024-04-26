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
[CqlLibrary("Hospice", "6.9.000")]
public class Hospice_6_9_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Hospice_Care_Ambulatory;
    internal Lazy<CqlValueSet> __Hospice_Encounter;
    internal Lazy<CqlValueSet> __Hospice_Diagnosis;
    internal Lazy<CqlCode> __Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __Discharge_to_home_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __Hospice_care__Minimum_Data_Set_;
    internal Lazy<CqlCode> __Yes__qualifier_value_;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Hospice_Services;

    #endregion
    public Hospice_6_9_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Hospice_Care_Ambulatory = new Lazy<CqlValueSet>(this.Hospice_Care_Ambulatory_Value);
        __Hospice_Encounter = new Lazy<CqlValueSet>(this.Hospice_Encounter_Value);
        __Hospice_Diagnosis = new Lazy<CqlValueSet>(this.Hospice_Diagnosis_Value);
        __Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_healthcare_facility_for_hospice_care__procedure__Value);
        __Discharge_to_home_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_home_for_hospice_care__procedure__Value);
        __Hospice_care__Minimum_Data_Set_ = new Lazy<CqlCode>(this.Hospice_care__Minimum_Data_Set__Value);
        __Yes__qualifier_value_ = new Lazy<CqlCode>(this.Yes__qualifier_value__Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Hospice_Services = new Lazy<bool?>(this.Has_Hospice_Services_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

    #endregion

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Hospice_Care_Ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlDeclaration("Hospice Care Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584")]
	public CqlValueSet Hospice_Care_Ambulatory() => 
		__Hospice_Care_Ambulatory.Value;

	private CqlValueSet Hospice_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);

    [CqlDeclaration("Hospice Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003")]
	public CqlValueSet Hospice_Encounter() => 
		__Hospice_Encounter.Value;

	private CqlValueSet Hospice_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);

    [CqlDeclaration("Hospice Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165")]
	public CqlValueSet Hospice_Diagnosis() => 
		__Hospice_Diagnosis.Value;

	private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value() => 
		new CqlCode("428371000124100", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => 
		__Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

	private CqlCode Discharge_to_home_for_hospice_care__procedure__Value() => 
		new CqlCode("428361000124107", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_() => 
		__Discharge_to_home_for_hospice_care__procedure_.Value;

	private CqlCode Hospice_care__Minimum_Data_Set__Value() => 
		new CqlCode("45755-6", "http://loinc.org", null, null);

    [CqlDeclaration("Hospice care [Minimum Data Set]")]
	public CqlCode Hospice_care__Minimum_Data_Set_() => 
		__Hospice_care__Minimum_Data_Set_.Value;

	private CqlCode Yes__qualifier_value__Value() => 
		new CqlCode("373066001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Yes (qualifier value)")]
	public CqlCode Yes__qualifier_value_() => 
		__Yes__qualifier_value_.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("45755-6", "http://loinc.org", null, null),
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
			new CqlCode("428371000124100", "http://snomed.info/sct", null, null),
			new CqlCode("428361000124107", "http://snomed.info/sct", null, null),
			new CqlCode("373066001", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("Hospice-6.9.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private bool? Has_Hospice_Services_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Encounter> c_ = Status_1_6_000.isEncounterPerformed(b_);
		bool? d_(Encounter InpatientEncounter)
		{
			CqlConcept ap_ = FHIRHelpers_4_3_000.ToConcept(InpatientEncounter?.Hospitalization?.DischargeDisposition);
			CqlCode aq_ = this.Discharge_to_home_for_hospice_care__procedure_();
			CqlConcept ar_ = context.Operators.ConvertCodeToConcept(aq_);
			bool? as_ = context.Operators.Equivalent(ap_, ar_);
			CqlCode au_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
			bool? aw_ = context.Operators.Equivalent(ap_, av_);
			bool? ax_ = context.Operators.Or(as_, aw_);
			CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			CqlInterval<CqlDateTime> az_ = QICoreCommon_2_0_000.toInterval((ay_ as object));
			CqlDateTime ba_ = context.Operators.End(az_);
			CqlInterval<CqlDateTime> bb_ = this.Measurement_Period();
			bool? bc_ = context.Operators.In<CqlDateTime>(ba_, bb_, "day");
			bool? bd_ = context.Operators.And(ax_, bc_);

			return bd_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
		bool? f_ = context.Operators.Exists<Encounter>(e_);
		CqlValueSet g_ = this.Hospice_Encounter();
		IEnumerable<Encounter> h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, null);
		IEnumerable<Encounter> i_ = Status_1_6_000.isEncounterPerformed(h_);
		bool? j_(Encounter HospiceEncounter)
		{
			CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_3_000.ToInterval(HospiceEncounter?.Period);
			CqlInterval<CqlDateTime> bf_ = QICoreCommon_2_0_000.toInterval((be_ as object));
			CqlInterval<CqlDateTime> bg_ = this.Measurement_Period();
			bool? bh_ = context.Operators.Overlaps(bf_, bg_, "day");

			return bh_;
		};
		IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.Or(f_, l_);
		CqlCode n_ = this.Hospice_care__Minimum_Data_Set_();
		IEnumerable<CqlCode> o_ = context.Operators.ToList<CqlCode>(n_);
		IEnumerable<Observation> p_ = context.Operators.RetrieveByCodes<Observation>(o_, null);
		IEnumerable<Observation> q_ = Status_1_6_000.isAssessmentPerformed(p_);
		bool? r_(Observation HospiceAssessment)
		{
			object bi_ = FHIRHelpers_4_3_000.ToValue(HospiceAssessment?.Value);
			CqlCode bj_ = this.Yes__qualifier_value_();
			CqlConcept bk_ = context.Operators.ConvertCodeToConcept(bj_);
			bool? bl_ = context.Operators.Equivalent((bi_ as CqlConcept), bk_);
			object bm_ = FHIRHelpers_4_3_000.ToValue(HospiceAssessment?.Effective);
			CqlInterval<CqlDateTime> bn_ = QICoreCommon_2_0_000.toInterval(bm_);
			CqlInterval<CqlDateTime> bo_ = this.Measurement_Period();
			bool? bp_ = context.Operators.Overlaps(bn_, bo_, "day");
			bool? bq_ = context.Operators.And(bl_, bp_);

			return bq_;
		};
		IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
		bool? t_ = context.Operators.Exists<Observation>(s_);
		bool? u_ = context.Operators.Or(m_, t_);
		CqlValueSet v_ = this.Hospice_Care_Ambulatory();
		IEnumerable<ServiceRequest> w_ = context.Operators.RetrieveByValueSet<ServiceRequest>(v_, null);
		IEnumerable<ServiceRequest> x_ = Status_1_6_000.isInterventionOrder(w_);
		bool? y_(ServiceRequest HospiceOrder)
		{
			CqlInterval<CqlDateTime> br_ = this.Measurement_Period();
			CqlDateTime bs_ = context.Operators.Convert<CqlDateTime>(HospiceOrder?.AuthoredOnElement);
			CqlInterval<CqlDateTime> bt_ = QICoreCommon_2_0_000.toInterval((bs_ as object));
			bool? bu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(br_, bt_, "day");

			return bu_;
		};
		IEnumerable<ServiceRequest> z_ = context.Operators.Where<ServiceRequest>(x_, y_);
		bool? aa_ = context.Operators.Exists<ServiceRequest>(z_);
		bool? ab_ = context.Operators.Or(u_, aa_);
		IEnumerable<Procedure> ad_ = context.Operators.RetrieveByValueSet<Procedure>(v_, null);
		IEnumerable<Procedure> ae_ = Status_1_6_000.isInterventionPerformed(ad_);
		bool? af_(Procedure HospicePerformed)
		{
			object bv_ = FHIRHelpers_4_3_000.ToValue(HospicePerformed?.Performed);
			CqlInterval<CqlDateTime> bw_ = QICoreCommon_2_0_000.toInterval(bv_);
			CqlInterval<CqlDateTime> bx_ = this.Measurement_Period();
			bool? by_ = context.Operators.Overlaps(bw_, bx_, "day");

			return by_;
		};
		IEnumerable<Procedure> ag_ = context.Operators.Where<Procedure>(ae_, af_);
		bool? ah_ = context.Operators.Exists<Procedure>(ag_);
		bool? ai_ = context.Operators.Or(ab_, ah_);
		CqlValueSet aj_ = this.Hospice_Diagnosis();
		IEnumerable<Condition> ak_ = context.Operators.RetrieveByValueSet<Condition>(aj_, null);
		bool? al_(Condition HospiceCareDiagnosis)
		{
			CqlInterval<CqlDateTime> bz_ = QICoreCommon_2_0_000.prevalenceInterval(HospiceCareDiagnosis);
			CqlInterval<CqlDateTime> ca_ = this.Measurement_Period();
			bool? cb_ = context.Operators.Overlaps(bz_, ca_, "day");

			return cb_;
		};
		IEnumerable<Condition> am_ = context.Operators.Where<Condition>(ak_, al_);
		bool? an_ = context.Operators.Exists<Condition>(am_);
		bool? ao_ = context.Operators.Or(ai_, an_);

		return ao_;
	}

    [CqlDeclaration("Has Hospice Services")]
	public bool? Has_Hospice_Services() => 
		__Has_Hospice_Services.Value;

}
