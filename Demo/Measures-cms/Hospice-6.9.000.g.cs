using System;
using Tuples;
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
		var d_ = context.ResolveParameter("Hospice-6.9.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private bool? Has_Hospice_Services_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = Status_1_6_000.isEncounterPerformed(b_);
		bool? d_(Encounter InpatientEncounter)
		{
			var ap_ = FHIRHelpers_4_3_000.ToConcept(InpatientEncounter?.Hospitalization?.DischargeDisposition);
			var aq_ = this.Discharge_to_home_for_hospice_care__procedure_();
			var ar_ = context.Operators.ConvertCodeToConcept(aq_);
			var as_ = context.Operators.Equivalent(ap_, ar_);
			var au_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_();
			var av_ = context.Operators.ConvertCodeToConcept(au_);
			var aw_ = context.Operators.Equivalent(ap_, av_);
			var ax_ = context.Operators.Or(as_, aw_);
			var ay_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			var az_ = QICoreCommon_2_0_000.toInterval((ay_ as object));
			var ba_ = context.Operators.End(az_);
			var bb_ = this.Measurement_Period();
			var bc_ = context.Operators.ElementInInterval<CqlDateTime>(ba_, bb_, "day");
			var bd_ = context.Operators.And(ax_, bc_);

			return bd_;
		};
		var e_ = context.Operators.WhereOrNull<Encounter>(c_, d_);
		var f_ = context.Operators.ExistsInList<Encounter>(e_);
		var g_ = this.Hospice_Encounter();
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, null);
		var i_ = Status_1_6_000.isEncounterPerformed(h_);
		bool? j_(Encounter HospiceEncounter)
		{
			var be_ = FHIRHelpers_4_3_000.ToInterval(HospiceEncounter?.Period);
			var bf_ = QICoreCommon_2_0_000.toInterval((be_ as object));
			var bg_ = this.Measurement_Period();
			var bh_ = context.Operators.Overlaps(bf_, bg_, "day");

			return bh_;
		};
		var k_ = context.Operators.WhereOrNull<Encounter>(i_, j_);
		var l_ = context.Operators.ExistsInList<Encounter>(k_);
		var m_ = context.Operators.Or(f_, l_);
		var n_ = this.Hospice_care__Minimum_Data_Set_();
		var o_ = context.Operators.ToList<CqlCode>(n_);
		var p_ = context.Operators.RetrieveByCodes<Observation>(o_, null);
		var q_ = Status_1_6_000.isAssessmentPerformed(p_);
		bool? r_(Observation HospiceAssessment)
		{
			var bi_ = FHIRHelpers_4_3_000.ToValue(HospiceAssessment?.Value);
			var bj_ = this.Yes__qualifier_value_();
			var bk_ = context.Operators.ConvertCodeToConcept(bj_);
			var bl_ = context.Operators.Equivalent((bi_ as CqlConcept), bk_);
			var bm_ = FHIRHelpers_4_3_000.ToValue(HospiceAssessment?.Effective);
			var bn_ = QICoreCommon_2_0_000.toInterval(bm_);
			var bo_ = this.Measurement_Period();
			var bp_ = context.Operators.Overlaps(bn_, bo_, "day");
			var bq_ = context.Operators.And(bl_, bp_);

			return bq_;
		};
		var s_ = context.Operators.WhereOrNull<Observation>(q_, r_);
		var t_ = context.Operators.ExistsInList<Observation>(s_);
		var u_ = context.Operators.Or(m_, t_);
		var v_ = this.Hospice_Care_Ambulatory();
		var w_ = context.Operators.RetrieveByValueSet<ServiceRequest>(v_, null);
		var x_ = Status_1_6_000.isInterventionOrder(w_);
		bool? y_(ServiceRequest HospiceOrder)
		{
			var br_ = this.Measurement_Period();
			var bs_ = context.Operators.Convert<CqlDateTime>(HospiceOrder?.AuthoredOnElement);
			var bt_ = QICoreCommon_2_0_000.toInterval((bs_ as object));
			var bu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(br_, bt_, "day");

			return bu_;
		};
		var z_ = context.Operators.WhereOrNull<ServiceRequest>(x_, y_);
		var aa_ = context.Operators.ExistsInList<ServiceRequest>(z_);
		var ab_ = context.Operators.Or(u_, aa_);
		var ad_ = context.Operators.RetrieveByValueSet<Procedure>(v_, null);
		var ae_ = Status_1_6_000.isInterventionPerformed(ad_);
		bool? af_(Procedure HospicePerformed)
		{
			var bv_ = FHIRHelpers_4_3_000.ToValue(HospicePerformed?.Performed);
			var bw_ = QICoreCommon_2_0_000.toInterval(bv_);
			var bx_ = this.Measurement_Period();
			var by_ = context.Operators.Overlaps(bw_, bx_, "day");

			return by_;
		};
		var ag_ = context.Operators.WhereOrNull<Procedure>(ae_, af_);
		var ah_ = context.Operators.ExistsInList<Procedure>(ag_);
		var ai_ = context.Operators.Or(ab_, ah_);
		var aj_ = this.Hospice_Diagnosis();
		var ak_ = context.Operators.RetrieveByValueSet<Condition>(aj_, null);
		bool? al_(Condition HospiceCareDiagnosis)
		{
			var bz_ = QICoreCommon_2_0_000.prevalenceInterval(HospiceCareDiagnosis);
			var ca_ = this.Measurement_Period();
			var cb_ = context.Operators.Overlaps(bz_, ca_, "day");

			return cb_;
		};
		var am_ = context.Operators.WhereOrNull<Condition>(ak_, al_);
		var an_ = context.Operators.ExistsInList<Condition>(am_);
		var ao_ = context.Operators.Or(ai_, an_);

		return ao_;
	}

    [CqlDeclaration("Has Hospice Services")]
	public bool? Has_Hospice_Services() => 
		__Has_Hospice_Services.Value;

}
