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
[CqlLibrary("KidneyHealthEvaluationFHIR", "0.1.000")]
public class KidneyHealthEvaluationFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Acute_Inpatient;
    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Chronic_Kidney_Disease__Stage_5;
    internal Lazy<CqlValueSet> __Diabetes;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __End_Stage_Renal_Disease;
    internal Lazy<CqlValueSet> __Estimated_Glomerular_Filtration_Rate;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Hospice_Care_Ambulatory;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Palliative_or_Hospice_Care;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Urine_Albumin_Creatinine_Ratio;
    internal Lazy<CqlCode> __Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __Discharge_to_home_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __AMB;
    internal Lazy<CqlCode> __active;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlCode[]> __ConditionClinicalStatusCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Active_Diabetes_Overlaps_Measurement_Period;
    internal Lazy<bool?> __Has_Outpatient_Visit_During_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<bool?> __Has_Kidney_Panel_Performed_During_Measurement_Period;
    internal Lazy<bool?> __Numerator;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public KidneyHealthEvaluationFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        PalliativeCare_1_9_000 = new PalliativeCare_1_9_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Acute_Inpatient = new Lazy<CqlValueSet>(this.Acute_Inpatient_Value);
        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Chronic_Kidney_Disease__Stage_5 = new Lazy<CqlValueSet>(this.Chronic_Kidney_Disease__Stage_5_Value);
        __Diabetes = new Lazy<CqlValueSet>(this.Diabetes_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __End_Stage_Renal_Disease = new Lazy<CqlValueSet>(this.End_Stage_Renal_Disease_Value);
        __Estimated_Glomerular_Filtration_Rate = new Lazy<CqlValueSet>(this.Estimated_Glomerular_Filtration_Rate_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Hospice_Care_Ambulatory = new Lazy<CqlValueSet>(this.Hospice_Care_Ambulatory_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Palliative_or_Hospice_Care = new Lazy<CqlValueSet>(this.Palliative_or_Hospice_Care_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Urine_Albumin_Creatinine_Ratio = new Lazy<CqlValueSet>(this.Urine_Albumin_Creatinine_Ratio_Value);
        __Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_healthcare_facility_for_hospice_care__procedure__Value);
        __Discharge_to_home_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_home_for_hospice_care__procedure__Value);
        __AMB = new Lazy<CqlCode>(this.AMB_Value);
        __active = new Lazy<CqlCode>(this.active_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __ConditionClinicalStatusCodes = new Lazy<CqlCode[]>(this.ConditionClinicalStatusCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Active_Diabetes_Overlaps_Measurement_Period = new Lazy<bool?>(this.Has_Active_Diabetes_Overlaps_Measurement_Period_Value);
        __Has_Outpatient_Visit_During_Measurement_Period = new Lazy<bool?>(this.Has_Outpatient_Visit_During_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period = new Lazy<IEnumerable<Condition>>(this.Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Has_Kidney_Panel_Performed_During_Measurement_Period = new Lazy<bool?>(this.Has_Kidney_Panel_Performed_During_Measurement_Period_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public PalliativeCare_1_9_000 PalliativeCare_1_9_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Acute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", default);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
	public CqlValueSet Acute_Inpatient() => 
		__Acute_Inpatient.Value;

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Chronic_Kidney_Disease__Stage_5_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", default);

    [CqlDeclaration("Chronic Kidney Disease, Stage 5")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002")]
	public CqlValueSet Chronic_Kidney_Disease__Stage_5() => 
		__Chronic_Kidney_Disease__Stage_5.Value;

	private CqlValueSet Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes() => 
		__Diabetes.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet End_Stage_Renal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", default);

    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
	public CqlValueSet End_Stage_Renal_Disease() => 
		__End_Stage_Renal_Disease.Value;

	private CqlValueSet Estimated_Glomerular_Filtration_Rate_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000", default);

    [CqlDeclaration("Estimated Glomerular Filtration Rate")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000")]
	public CqlValueSet Estimated_Glomerular_Filtration_Rate() => 
		__Estimated_Glomerular_Filtration_Rate.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Hospice_Care_Ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", default);

    [CqlDeclaration("Hospice Care Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584")]
	public CqlValueSet Hospice_Care_Ambulatory() => 
		__Hospice_Care_Ambulatory.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Palliative_or_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", default);

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
	public CqlValueSet Palliative_or_Hospice_Care() => 
		__Palliative_or_Hospice_Care.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Urine_Albumin_Creatinine_Ratio_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007", default);

    [CqlDeclaration("Urine Albumin Creatinine Ratio")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007")]
	public CqlValueSet Urine_Albumin_Creatinine_Ratio() => 
		__Urine_Albumin_Creatinine_Ratio.Value;

	private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value() => 
		new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => 
		__Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

	private CqlCode Discharge_to_home_for_hospice_care__procedure__Value() => 
		new CqlCode("428361000124107", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_() => 
		__Discharge_to_home_for_hospice_care__procedure_.Value;

	private CqlCode AMB_Value() => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("AMB")]
	public CqlCode AMB() => 
		__AMB.Value;

	private CqlCode active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("active")]
	public CqlCode active() => 
		__active.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
			new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes() => 
		__ConditionClinicalStatusCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("KidneyHealthEvaluationFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private bool? Has_Active_Diabetes_Overlaps_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Diabetes();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition Diabetes)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Diabetes);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			bool? h_ = context.Operators.Overlaps(f_, g_, default);
			CodeableConcept i_ = Diabetes?.ClinicalStatus;
			CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
			CqlCode k_ = this.active();
			CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
			bool? m_ = context.Operators.Equivalent(j_, l_);
			bool? n_ = context.Operators.And(h_, m_);

			return n_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Active Diabetes Overlaps Measurement Period")]
	public bool? Has_Active_Diabetes_Overlaps_Measurement_Period() => 
		__Has_Active_Diabetes_Overlaps_Measurement_Period.Value;

	private bool? Has_Outpatient_Visit_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Office_Visit();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Telephone_Visits();
		IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> t_ = context.Operators.Union<Encounter>(q_, s_);
		bool? u_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> x_ = this.Measurement_Period();
			Period y_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.ToInterval(y_);
			bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, z_, default);
			Code<Encounter.EncounterStatus> ab_ = ValidEncounter?.StatusElement;
			Encounter.EncounterStatus? ac_ = ab_?.Value;
			Code<Encounter.EncounterStatus> ad_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ac_);
			bool? ae_ = context.Operators.Equal(ad_, "finished");
			bool? af_ = context.Operators.And(aa_, ae_);

			return af_;
		};
		IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
		bool? w_ = context.Operators.Exists<Encounter>(v_);

		return w_;
	}

    [CqlDeclaration("Has Outpatient Visit During Measurement Period")]
	public bool? Has_Outpatient_Visit_During_Measurement_Period() => 
		__Has_Outpatient_Visit_During_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(18, 85, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		bool? k_ = this.Has_Active_Diabetes_Overlaps_Measurement_Period();
		bool? l_ = context.Operators.And(j_, k_);
		bool? m_ = this.Has_Outpatient_Visit_During_Measurement_Period();
		bool? n_ = context.Operators.And(l_, m_);

		return n_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Condition> Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Chronic_Kidney_Disease__Stage_5();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet c_ = this.End_Stage_Renal_Disease();
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		bool? f_(Condition CKDOrESRD)
		{
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToPrevalenceInterval(CKDOrESRD);
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period();
			bool? j_ = context.Operators.Overlaps(h_, i_, default);
			CodeableConcept k_ = CKDOrESRD?.ClinicalStatus;
			CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			CqlCode m_ = this.active();
			CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
			bool? o_ = context.Operators.Equivalent(l_, n_);
			bool? p_ = context.Operators.And(j_, o_);

			return p_;
		};
		IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Has CKD Stage 5 or ESRD Diagnosis Overlaps Measurement Period")]
	public IEnumerable<Condition> Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period() => 
		__Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period.Value;

	private bool? Denominator_Exclusions_Value()
	{
		IEnumerable<Condition> a_ = this.Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period();
		bool? b_ = context.Operators.Exists<Condition>(a_);
		bool? c_ = Hospice_6_9_000.Has_Hospice_Services();
		bool? d_ = context.Operators.Or(b_, c_);
		bool? e_ = PalliativeCare_1_9_000.Has_Palliative_Care_in_the_Measurement_Period();
		bool? f_ = context.Operators.Or(d_, e_);

		return f_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private bool? Has_Kidney_Panel_Performed_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Estimated_Glomerular_Filtration_Rate();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? c_(Observation eGFRTest)
		{
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			DataType m_ = eGFRTest?.Effective;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval(n_);
			bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, default);
			DataType q_ = eGFRTest?.Value;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			bool? s_ = context.Operators.Not((bool?)(r_ is null));
			bool? t_ = context.Operators.And(p_, s_);
			Code<ObservationStatus> u_ = eGFRTest?.StatusElement;
			ObservationStatus? v_ = u_?.Value;
			Code<ObservationStatus> w_ = context.Operators.Convert<Code<ObservationStatus>>(v_);
			string x_ = context.Operators.Convert<string>(w_);
			string[] y_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? z_ = context.Operators.In<string>(x_, y_ as IEnumerable<string>);
			bool? aa_ = context.Operators.And(t_, z_);

			return aa_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);
		CqlValueSet f_ = this.Urine_Albumin_Creatinine_Ratio();
		IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? h_(Observation uACRTest)
		{
			CqlInterval<CqlDateTime> ab_ = this.Measurement_Period();
			DataType ac_ = uACRTest?.Effective;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval(ad_);
			bool? af_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ab_, ae_, default);
			DataType ag_ = uACRTest?.Value;
			object ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
			bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
			bool? aj_ = context.Operators.And(af_, ai_);
			Code<ObservationStatus> ak_ = uACRTest?.StatusElement;
			ObservationStatus? al_ = ak_?.Value;
			Code<ObservationStatus> am_ = context.Operators.Convert<Code<ObservationStatus>>(al_);
			string an_ = context.Operators.Convert<string>(am_);
			string[] ao_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? ap_ = context.Operators.In<string>(an_, ao_ as IEnumerable<string>);
			bool? aq_ = context.Operators.And(aj_, ap_);

			return aq_;
		};
		IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
		bool? j_ = context.Operators.Exists<Observation>(i_);
		bool? k_ = context.Operators.And(e_, j_);

		return k_;
	}

    [CqlDeclaration("Has Kidney Panel Performed During Measurement Period")]
	public bool? Has_Kidney_Panel_Performed_During_Measurement_Period() => 
		__Has_Kidney_Panel_Performed_During_Measurement_Period.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Has_Kidney_Panel_Performed_During_Measurement_Period();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
