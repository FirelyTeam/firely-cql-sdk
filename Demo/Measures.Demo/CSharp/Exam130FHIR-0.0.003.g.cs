using System;
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
[CqlLibrary("Exam130FHIR", "0.0.003")]
public class Exam130FHIR_0_0_003
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Acute_Inpatient;
    internal Lazy<CqlValueSet> __Advanced_Illness;
    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Care_Services_in_Long_Term_Residential_Facility;
    internal Lazy<CqlValueSet> __Colonoscopy;
    internal Lazy<CqlValueSet> __CT_Colonography;
    internal Lazy<CqlValueSet> __Dementia_Medications;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Fecal_Occult_Blood_Test__FOBT_;
    internal Lazy<CqlValueSet> __FIT_DNA;
    internal Lazy<CqlValueSet> __Flexible_Sigmoidoscopy;
    internal Lazy<CqlValueSet> __Frailty_Device;
    internal Lazy<CqlValueSet> __Frailty_Diagnosis;
    internal Lazy<CqlValueSet> __Frailty_Encounter;
    internal Lazy<CqlValueSet> __Frailty_Symptom;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Hospice_care_ambulatory;
    internal Lazy<CqlValueSet> __Malignant_Neoplasm_of_Colon;
    internal Lazy<CqlValueSet> __Nonacute_Inpatient;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Observation;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Outpatient;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Total_Colectomy;
    internal Lazy<CqlValueSet> __Total_Colectomy_ICD9;
    internal Lazy<CqlCode> __laboratory;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Telehealth_Services;
    internal Lazy<int?> __Age_at_start_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Malignant_Neoplasm;
    internal Lazy<IEnumerable<Procedure>> __Total_Colectomy_Performed;
    internal Lazy<IEnumerable<Condition>> __Total_Colectomy_Condition;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>> __Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed__day_of_TZoffset;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset;
    internal Lazy<IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>> __Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status;
    internal Lazy<IEnumerable<Observation>> __Fecal_Immunochemical_Test_DNA_Performed;
    internal Lazy<IEnumerable<Observation>> __Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset;
    internal Lazy<IEnumerable<Observation>> __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset;
    internal Lazy<IEnumerable<Observation>> __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset;
    internal Lazy<IEnumerable<CqlDateTime>> __CT_Colonography_Display_Date;
    internal Lazy<IEnumerable<Observation>> __CT_Colonography_Performed;
    internal Lazy<IEnumerable<Observation>> __CT_Colonography_Performed_without_appropriate_status;
    internal Lazy<IEnumerable<CqlDateTime>> __Flexible_Sigmoidoscopy_Display_Date;
    internal Lazy<IEnumerable<Procedure>> __Flexible_Sigmoidoscopy_Performed;
    internal Lazy<IEnumerable<Procedure>> __Flexible_Sigmoidoscopy_Performed_without_appropriate_status;
    internal Lazy<IEnumerable<CqlDateTime>> __Colonoscopy_Display_Date;
    internal Lazy<IEnumerable<Procedure>> __Colonoscopy_Performed;
    internal Lazy<IEnumerable<Procedure>> __Colonoscopy_Performed_without_appropriate_status;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Final_Numerator_Population;

    #endregion
    public Exam130FHIR_0_0_003(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        AdultOutpatientEncountersFHIR4_2_2_000 = new AdultOutpatientEncountersFHIR4_2_2_000(context);
        HospiceFHIR4_2_3_000 = new HospiceFHIR4_2_3_000(context);
        AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 = new AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000(context);
        PalliativeCareFHIR_0_6_000 = new PalliativeCareFHIR_0_6_000(context);
        CumulativeMedicationDurationFHIR4_1_0_000 = new CumulativeMedicationDurationFHIR4_1_0_000(context);

        __Acute_Inpatient = new Lazy<CqlValueSet>(this.Acute_Inpatient_Value);
        __Advanced_Illness = new Lazy<CqlValueSet>(this.Advanced_Illness_Value);
        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Care_Services_in_Long_Term_Residential_Facility = new Lazy<CqlValueSet>(this.Care_Services_in_Long_Term_Residential_Facility_Value);
        __Colonoscopy = new Lazy<CqlValueSet>(this.Colonoscopy_Value);
        __CT_Colonography = new Lazy<CqlValueSet>(this.CT_Colonography_Value);
        __Dementia_Medications = new Lazy<CqlValueSet>(this.Dementia_Medications_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Fecal_Occult_Blood_Test__FOBT_ = new Lazy<CqlValueSet>(this.Fecal_Occult_Blood_Test__FOBT__Value);
        __FIT_DNA = new Lazy<CqlValueSet>(this.FIT_DNA_Value);
        __Flexible_Sigmoidoscopy = new Lazy<CqlValueSet>(this.Flexible_Sigmoidoscopy_Value);
        __Frailty_Device = new Lazy<CqlValueSet>(this.Frailty_Device_Value);
        __Frailty_Diagnosis = new Lazy<CqlValueSet>(this.Frailty_Diagnosis_Value);
        __Frailty_Encounter = new Lazy<CqlValueSet>(this.Frailty_Encounter_Value);
        __Frailty_Symptom = new Lazy<CqlValueSet>(this.Frailty_Symptom_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Hospice_care_ambulatory = new Lazy<CqlValueSet>(this.Hospice_care_ambulatory_Value);
        __Malignant_Neoplasm_of_Colon = new Lazy<CqlValueSet>(this.Malignant_Neoplasm_of_Colon_Value);
        __Nonacute_Inpatient = new Lazy<CqlValueSet>(this.Nonacute_Inpatient_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Observation = new Lazy<CqlValueSet>(this.Observation_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Outpatient = new Lazy<CqlValueSet>(this.Outpatient_Value);
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Total_Colectomy = new Lazy<CqlValueSet>(this.Total_Colectomy_Value);
        __Total_Colectomy_ICD9 = new Lazy<CqlValueSet>(this.Total_Colectomy_ICD9_Value);
        __laboratory = new Lazy<CqlCode>(this.laboratory_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Telehealth_Services = new Lazy<IEnumerable<Encounter>>(this.Telehealth_Services_Value);
        __Age_at_start_of_Measurement_Period = new Lazy<int?>(this.Age_at_start_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Malignant_Neoplasm = new Lazy<IEnumerable<Condition>>(this.Malignant_Neoplasm_Value);
        __Total_Colectomy_Performed = new Lazy<IEnumerable<Procedure>>(this.Total_Colectomy_Performed_Value);
        __Total_Colectomy_Condition = new Lazy<IEnumerable<Condition>>(this.Total_Colectomy_Condition_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status = new Lazy<IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>>(this.Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value);
        __Fecal_Occult_Blood_Test_Performed = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed_Value);
        __Fecal_Occult_Blood_Test_Performed__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Value);
        __Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value);
        __Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value);
        __Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status = new Lazy<IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>>(this.Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Value);
        __Fecal_Immunochemical_Test_DNA_Performed = new Lazy<IEnumerable<Observation>>(this.Fecal_Immunochemical_Test_DNA_Performed_Value);
        __Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Value);
        __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value);
        __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value);
        __CT_Colonography_Display_Date = new Lazy<IEnumerable<CqlDateTime>>(this.CT_Colonography_Display_Date_Value);
        __CT_Colonography_Performed = new Lazy<IEnumerable<Observation>>(this.CT_Colonography_Performed_Value);
        __CT_Colonography_Performed_without_appropriate_status = new Lazy<IEnumerable<Observation>>(this.CT_Colonography_Performed_without_appropriate_status_Value);
        __Flexible_Sigmoidoscopy_Display_Date = new Lazy<IEnumerable<CqlDateTime>>(this.Flexible_Sigmoidoscopy_Display_Date_Value);
        __Flexible_Sigmoidoscopy_Performed = new Lazy<IEnumerable<Procedure>>(this.Flexible_Sigmoidoscopy_Performed_Value);
        __Flexible_Sigmoidoscopy_Performed_without_appropriate_status = new Lazy<IEnumerable<Procedure>>(this.Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Value);
        __Colonoscopy_Display_Date = new Lazy<IEnumerable<CqlDateTime>>(this.Colonoscopy_Display_Date_Value);
        __Colonoscopy_Performed = new Lazy<IEnumerable<Procedure>>(this.Colonoscopy_Performed_Value);
        __Colonoscopy_Performed_without_appropriate_status = new Lazy<IEnumerable<Procedure>>(this.Colonoscopy_Performed_without_appropriate_status_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Final_Numerator_Population = new Lazy<bool?>(this.Final_Numerator_Population_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public AdultOutpatientEncountersFHIR4_2_2_000 AdultOutpatientEncountersFHIR4_2_2_000 { get; }
    public HospiceFHIR4_2_3_000 HospiceFHIR4_2_3_000 { get; }
    public AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 { get; }
    public PalliativeCareFHIR_0_6_000 PalliativeCareFHIR_0_6_000 { get; }
    public CumulativeMedicationDurationFHIR4_1_0_000 CumulativeMedicationDurationFHIR4_1_0_000 { get; }

    #endregion

	private CqlValueSet Acute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
	public CqlValueSet Acute_Inpatient() => 
		__Acute_Inpatient?.Value;

	private CqlValueSet Advanced_Illness_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
	public CqlValueSet Advanced_Illness() => 
		__Advanced_Illness?.Value;

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit?.Value;

	private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility?.Value;

	private CqlValueSet Colonoscopy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
	public CqlValueSet Colonoscopy() => 
		__Colonoscopy?.Value;

	private CqlValueSet CT_Colonography_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
	public CqlValueSet CT_Colonography() => 
		__CT_Colonography?.Value;

	private CqlValueSet Dementia_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
	public CqlValueSet Dementia_Medications() => 
		__Dementia_Medications?.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care?.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care?.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient?.Value;

	private CqlValueSet Fecal_Occult_Blood_Test__FOBT__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
	public CqlValueSet Fecal_Occult_Blood_Test__FOBT_() => 
		__Fecal_Occult_Blood_Test__FOBT_?.Value;

	private CqlValueSet FIT_DNA_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

    [CqlDeclaration("FIT DNA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
	public CqlValueSet FIT_DNA() => 
		__FIT_DNA?.Value;

	private CqlValueSet Flexible_Sigmoidoscopy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
	public CqlValueSet Flexible_Sigmoidoscopy() => 
		__Flexible_Sigmoidoscopy?.Value;

	private CqlValueSet Frailty_Device_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
	public CqlValueSet Frailty_Device() => 
		__Frailty_Device?.Value;

	private CqlValueSet Frailty_Diagnosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
	public CqlValueSet Frailty_Diagnosis() => 
		__Frailty_Diagnosis?.Value;

	private CqlValueSet Frailty_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
	public CqlValueSet Frailty_Encounter() => 
		__Frailty_Encounter?.Value;

	private CqlValueSet Frailty_Symptom_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
	public CqlValueSet Frailty_Symptom() => 
		__Frailty_Symptom?.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services?.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory?.Value;

	private CqlValueSet Malignant_Neoplasm_of_Colon_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
	public CqlValueSet Malignant_Neoplasm_of_Colon() => 
		__Malignant_Neoplasm_of_Colon?.Value;

	private CqlValueSet Nonacute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
	public CqlValueSet Nonacute_Inpatient() => 
		__Nonacute_Inpatient?.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit?.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation() => 
		__Observation?.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit?.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments?.Value;

	private CqlValueSet Outpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
	public CqlValueSet Outpatient() => 
		__Outpatient?.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up?.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up?.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits?.Value;

	private CqlValueSet Total_Colectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
	public CqlValueSet Total_Colectomy() => 
		__Total_Colectomy?.Value;

	private CqlValueSet Total_Colectomy_ICD9_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", null);

    [CqlDeclaration("Total Colectomy ICD9")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136")]
	public CqlValueSet Total_Colectomy_ICD9() => 
		__Total_Colectomy_ICD9?.Value;

	private CqlCode laboratory_Value() => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory() => 
		__laboratory?.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes?.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
		var b_ = context?.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
		var c_ = context?.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("Exam130FHIR-0.0.003", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period?.Value;

	private Patient Patient_Value()
	{
		var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context?.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient?.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity?.Value;

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
		__SDE_Payer?.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race?.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex?.Value;

	private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var a_ = this.Online_Assessments();
		var b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Telephone_Visits();
		var d_ = context?.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context?.Operators.Union<Encounter>(b_, d_);
		bool? f_(Encounter TelehealthEncounter)
		{
			var h_ = TelehealthEncounter.StatusElement;
			var i_ = FHIRHelpers_4_0_001.ToString(h_);
			var j_ = context?.Operators.Equal(i_, "finished");
			var k_ = this.Measurement_Period();
			var l_ = TelehealthEncounter.Period;
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((l_ as object));
			var n_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, null);
			var o_ = context?.Operators.And(j_, n_);

			return o_;
		};
		var g_ = context?.Operators.Where<Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Telehealth Services")]
	public IEnumerable<Encounter> Telehealth_Services() => 
		__Telehealth_Services?.Value;

	private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = this.Patient();
		var b_ = context?.Operators.ConvertStringToDate(a_.BirthDateElement.Value);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");

		return f_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
	public int? Age_at_start_of_Measurement_Period() => 
		__Age_at_start_of_Measurement_Period?.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context?.Operators.ConvertStringToDate(a_.BirthDateElement.Value);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context?.Operators.Interval(51, 75, true, false);
		var h_ = context?.Operators.In<int?>(f_, g_, null);
		var i_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var j_ = this.Telehealth_Services();
		var k_ = context?.Operators.Union<Encounter>(i_, j_);
		var l_ = context?.Operators.Exists<Encounter>(k_);
		var m_ = context?.Operators.And(h_, l_);

		return m_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population?.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator?.Value;

	private IEnumerable<Condition> Malignant_Neoplasm_Value()
	{
		var a_ = this.Malignant_Neoplasm_of_Colon();
		var b_ = context?.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition ColorectalCancer)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColorectalCancer);
			var f_ = context?.Operators.Start(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.End(g_);
			var i_ = context?.Operators.SameOrBefore(f_, h_, null);

			return i_;
		};
		var d_ = context?.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Malignant Neoplasm")]
	public IEnumerable<Condition> Malignant_Neoplasm() => 
		__Malignant_Neoplasm?.Value;

	private IEnumerable<Procedure> Total_Colectomy_Performed_Value()
	{
		var a_ = this.Total_Colectomy();
		var b_ = context?.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure Colectomy)
		{
			var e_ = Colectomy.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context?.Operators.Equal(f_, "completed");
			var h_ = Colectomy.Performed;
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			var j_ = context?.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.End(k_);
			var m_ = context?.Operators.SameOrBefore(j_, l_, null);
			var n_ = context?.Operators.And(g_, m_);

			return n_;
		};
		var d_ = context?.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Total Colectomy Performed")]
	public IEnumerable<Procedure> Total_Colectomy_Performed() => 
		__Total_Colectomy_Performed?.Value;

	private IEnumerable<Condition> Total_Colectomy_Condition_Value()
	{
		var a_ = this.Total_Colectomy_ICD9();
		var b_ = context?.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition ColectomyDx)
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColectomyDx);
			var f_ = context?.Operators.Start(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.End(g_);
			var i_ = context?.Operators.SameOrBefore(f_, h_, null);

			return i_;
		};
		var d_ = context?.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Total Colectomy Condition")]
	public IEnumerable<Condition> Total_Colectomy_Condition() => 
		__Total_Colectomy_Condition?.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Malignant_Neoplasm();
		var c_ = context?.Operators.Exists<Condition>(b_);
		var d_ = context?.Operators.Or(a_, c_);
		var e_ = this.Total_Colectomy_Performed();
		var f_ = context?.Operators.Exists<Procedure>(e_);
		var g_ = context?.Operators.Or(d_, f_);
		var h_ = this.Total_Colectomy_Condition();
		var i_ = context?.Operators.Exists<Condition>(h_);
		var j_ = context?.Operators.Or(g_, i_);
		var k_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var l_ = context?.Operators.Or(j_, k_);
		var m_ = this.Patient();
		var n_ = context?.Operators.ConvertStringToDate(m_.BirthDateElement.Value);
		var o_ = this.Measurement_Period();
		var p_ = context?.Operators.Start(o_);
		var q_ = context?.Operators.DateFrom(p_);
		var r_ = context?.Operators.CalculateAgeAt(n_, q_, "year");
		var s_ = context?.Operators.GreaterOrEqual(r_, 65);
		var t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var u_ = context?.Operators.And(s_, t_);
		var v_ = context?.Operators.Or(l_, u_);
		var w_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var x_ = context?.Operators.Or(v_, w_);

		return x_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions?.Value;

	private IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var g_ = FecalOccult.Effective;
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.Start(i_);
			var k_ = context?.Operators.Quantity(1m, "year");
			var l_ = context?.Operators.Subtract(j_, k_);
			var n_ = context?.Operators.End(i_);
			var o_ = context?.Operators.Interval(l_, n_, false, false);
			var p_ = context?.Operators.In<CqlDateTime>(h_, o_, null);

			return p_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);
		(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? e_(Observation FecalOccult)
		{
			var q_ = FecalOccult.Effective;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(q_);
			var s_ = FecalOccult.Value;
			var t_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(s_, "coding");
			bool? u_(Coding @this)
			{
				var ao_ = @this.DisplayElement;
				var ap_ = context?.Operators.Not((bool?)(ao_ is null));

				return ap_;
			};
			var v_ = context?.Operators.Where<Coding>(t_, u_);
			FhirString w_(Coding @this)
			{
				var aq_ = @this.DisplayElement;

				return aq_;
			};
			var x_ = context?.Operators.Select<Coding, FhirString>(v_, w_);
			var y_ = FecalOccult.Category;
			bool? z_(CodeableConcept @this)
			{
				var ar_ = @this.Coding;
				var as_ = context?.Operators.Not((bool?)(ar_ is null));

				return as_;
			};
			var aa_ = context?.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)y_, z_);
			List<Coding> ab_(CodeableConcept @this)
			{
				var at_ = @this.Coding;

				return at_;
			};
			var ac_ = context?.Operators.Select<CodeableConcept, List<Coding>>(aa_, ab_);
			var ad_ = context?.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ac_);
			bool? ae_(Coding @this)
			{
				var au_ = @this.CodeElement;
				var av_ = context?.Operators.Not((bool?)(au_ is null));

				return av_;
			};
			var af_ = context?.Operators.Where<Coding>(ad_, ae_);
			Code ag_(Coding @this)
			{
				var aw_ = @this.CodeElement;

				return aw_;
			};
			var ah_ = context?.Operators.Select<Coding, Code>(af_, ag_);
			bool? ai_(Code @this)
			{
				var ax_ = @this.Value;
				var ay_ = context?.Operators.Not((bool?)(ax_ is null));

				return ay_;
			};
			var aj_ = context?.Operators.Where<Code>(ah_, ai_);
			string ak_(Code @this)
			{
				var az_ = @this.Value;

				return az_;
			};
			var al_ = context?.Operators.Select<Code, string>(aj_, ak_);
			var am_ = FecalOccult.StatusElement;
			var an_ = (r_, x_, al_, am_);

			return an_;
		};
		var f_ = context?.Operators.Select<Observation, (CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Display Date, Result, Category, Status")]
	public IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status() => 
		__Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status?.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var e_ = FecalOccult.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context?.Operators.In<string>(f_, (g_ as IEnumerable<string>));
			var i_ = FecalOccult.Category;
			bool? j_(CodeableConcept FecalOccultCategory)
			{
				var v_ = FecalOccultCategory.Coding;
				bool? w_(Coding @this)
				{
					var ag_ = @this.CodeElement;
					var ah_ = context?.Operators.Not((bool?)(ag_ is null));

					return ah_;
				};
				var x_ = context?.Operators.Where<Coding>((IEnumerable<Coding>)v_, w_);
				Code y_(Coding @this)
				{
					var ai_ = @this.CodeElement;

					return ai_;
				};
				var z_ = context?.Operators.Select<Coding, Code>(x_, y_);
				bool? aa_(Code @this)
				{
					var aj_ = @this.Value;
					var ak_ = context?.Operators.Not((bool?)(aj_ is null));

					return ak_;
				};
				var ab_ = context?.Operators.Where<Code>(z_, aa_);
				string ac_(Code @this)
				{
					var al_ = @this.Value;

					return al_;
				};
				var ad_ = context?.Operators.Select<Code, string>(ab_, ac_);
				var ae_ = new string[]
				{
					"laboratory",
				};
				var af_ = context?.Operators.Equivalent<string>(ad_, (ae_ as IEnumerable<string>));

				return af_;
			};
			var k_ = context?.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			var l_ = context?.Operators.Exists<CodeableConcept>(k_);
			var m_ = context?.Operators.And(h_, l_);
			var n_ = FecalOccult.Value;
			var o_ = context?.Operators.Not((bool?)(n_ is null));
			var p_ = context?.Operators.And(m_, o_);
			var q_ = FecalOccult.Effective;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(q_);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.In<CqlDateTime>(r_, s_, null);
			var u_ = context?.Operators.And(p_, t_);

			return u_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed() => 
		__Fecal_Occult_Blood_Test_Performed?.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var e_ = FecalOccult.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context?.Operators.In<string>(f_, (g_ as IEnumerable<string>));
			var i_ = FecalOccult.Category;
			bool? j_(CodeableConcept FecalOccultCategory)
			{
				var v_ = FecalOccultCategory.Coding;
				bool? w_(Coding @this)
				{
					var ag_ = @this.CodeElement;
					var ah_ = context?.Operators.Not((bool?)(ag_ is null));

					return ah_;
				};
				var x_ = context?.Operators.Where<Coding>((IEnumerable<Coding>)v_, w_);
				Code y_(Coding @this)
				{
					var ai_ = @this.CodeElement;

					return ai_;
				};
				var z_ = context?.Operators.Select<Coding, Code>(x_, y_);
				bool? aa_(Code @this)
				{
					var aj_ = @this.Value;
					var ak_ = context?.Operators.Not((bool?)(aj_ is null));

					return ak_;
				};
				var ab_ = context?.Operators.Where<Code>(z_, aa_);
				string ac_(Code @this)
				{
					var al_ = @this.Value;

					return al_;
				};
				var ad_ = context?.Operators.Select<Code, string>(ab_, ac_);
				var ae_ = new string[]
				{
					"laboratory",
				};
				var af_ = context?.Operators.Equivalent<string>(ad_, (ae_ as IEnumerable<string>));

				return af_;
			};
			var k_ = context?.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			var l_ = context?.Operators.Exists<CodeableConcept>(k_);
			var m_ = context?.Operators.And(h_, l_);
			var n_ = FecalOccult.Value;
			var o_ = context?.Operators.Not((bool?)(n_ is null));
			var p_ = context?.Operators.And(m_, o_);
			var q_ = FecalOccult.Effective;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(q_);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.In<CqlDateTime>(r_, s_, "day");
			var u_ = context?.Operators.And(p_, t_);

			return u_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset() => 
		__Fecal_Occult_Blood_Test_Performed__day_of_TZoffset?.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var e_ = FecalOccult.Category;
			bool? f_(CodeableConcept FecalOccultCategory)
			{
				var q_ = FecalOccultCategory.Coding;
				bool? r_(Coding @this)
				{
					var ac_ = @this.CodeElement;
					var ad_ = context?.Operators.Not((bool?)(ac_ is null));

					return ad_;
				};
				var s_ = context?.Operators.Where<Coding>((IEnumerable<Coding>)q_, r_);
				Code t_(Coding @this)
				{
					var ae_ = @this.CodeElement;

					return ae_;
				};
				var u_ = context?.Operators.Select<Coding, Code>(s_, t_);
				bool? v_(Code @this)
				{
					var af_ = @this.Value;
					var ag_ = context?.Operators.Not((bool?)(af_ is null));

					return ag_;
				};
				var w_ = context?.Operators.Where<Code>(u_, v_);
				string x_(Code @this)
				{
					var ah_ = @this.Value;

					return ah_;
				};
				var y_ = context?.Operators.Select<Code, string>(w_, x_);
				var z_ = new string[]
				{
					"laboratory",
				};
				var aa_ = context?.Operators.Equivalent<string>(y_, (z_ as IEnumerable<string>));
				var ab_ = context?.Operators.Not(aa_);

				return ab_;
			};
			var g_ = context?.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)e_, f_);
			var h_ = context?.Operators.Exists<CodeableConcept>(g_);
			var i_ = FecalOccult.Value;
			var j_ = context?.Operators.Not((bool?)(i_ is null));
			var k_ = context?.Operators.And(h_, j_);
			var l_ = FecalOccult.Effective;
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(l_);
			var n_ = this.Measurement_Period();
			var o_ = context?.Operators.In<CqlDateTime>(m_, n_, "day");
			var p_ = context?.Operators.And(k_, o_);

			return p_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => 
		__Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset?.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FecalOccult)
		{
			var e_ = FecalOccult.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context?.Operators.In<string>(f_, (g_ as IEnumerable<string>));
			var i_ = context?.Operators.Not(h_);
			var j_ = FecalOccult.Value;
			var k_ = context?.Operators.Not((bool?)(j_ is null));
			var l_ = context?.Operators.And(i_, k_);
			var m_ = FecalOccult.Effective;
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.In<CqlDateTime>(n_, o_, "day");
			var q_ = context?.Operators.And(l_, p_);

			return q_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => 
		__Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset?.Value;

	private IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var g_ = FitDNA.Effective;
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.End(i_);
			var k_ = context?.Operators.Quantity(4m, "years");
			var l_ = context?.Operators.Subtract(j_, k_);
			var n_ = context?.Operators.End(i_);
			var o_ = context?.Operators.Interval(l_, n_, true, true);
			var p_ = context?.Operators.In<CqlDateTime>(h_, o_, null);
			var r_ = context?.Operators.End(i_);
			var s_ = context?.Operators.Not((bool?)(r_ is null));
			var t_ = context?.Operators.And(p_, s_);

			return t_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);
		(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? e_(Observation FitDNA)
		{
			var u_ = FitDNA.Effective;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(u_);
			var w_ = FitDNA.Value;
			var x_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(w_, "coding");
			bool? y_(Coding @this)
			{
				var as_ = @this.DisplayElement;
				var at_ = context?.Operators.Not((bool?)(as_ is null));

				return at_;
			};
			var z_ = context?.Operators.Where<Coding>(x_, y_);
			FhirString aa_(Coding @this)
			{
				var au_ = @this.DisplayElement;

				return au_;
			};
			var ab_ = context?.Operators.Select<Coding, FhirString>(z_, aa_);
			var ac_ = FitDNA.Category;
			bool? ad_(CodeableConcept @this)
			{
				var av_ = @this.Coding;
				var aw_ = context?.Operators.Not((bool?)(av_ is null));

				return aw_;
			};
			var ae_ = context?.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)ac_, ad_);
			List<Coding> af_(CodeableConcept @this)
			{
				var ax_ = @this.Coding;

				return ax_;
			};
			var ag_ = context?.Operators.Select<CodeableConcept, List<Coding>>(ae_, af_);
			var ah_ = context?.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ag_);
			bool? ai_(Coding @this)
			{
				var ay_ = @this.CodeElement;
				var az_ = context?.Operators.Not((bool?)(ay_ is null));

				return az_;
			};
			var aj_ = context?.Operators.Where<Coding>(ah_, ai_);
			Code ak_(Coding @this)
			{
				var ba_ = @this.CodeElement;

				return ba_;
			};
			var al_ = context?.Operators.Select<Coding, Code>(aj_, ak_);
			bool? am_(Code @this)
			{
				var bb_ = @this.Value;
				var bc_ = context?.Operators.Not((bool?)(bb_ is null));

				return bc_;
			};
			var an_ = context?.Operators.Where<Code>(al_, am_);
			string ao_(Code @this)
			{
				var bd_ = @this.Value;

				return bd_;
			};
			var ap_ = context?.Operators.Select<Code, string>(an_, ao_);
			var aq_ = FitDNA.StatusElement;
			var ar_ = (v_, ab_, ap_, aq_);

			return ar_;
		};
		var f_ = context?.Operators.Select<Observation, (CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
	public IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status() => 
		__Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status?.Value;

	private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var e_ = FitDNA.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context?.Operators.In<string>(f_, (g_ as IEnumerable<string>));
			var i_ = FitDNA.Category;
			bool? j_(CodeableConcept FitDNACategory)
			{
				var af_ = FitDNACategory.Coding;
				bool? ag_(Coding @this)
				{
					var aq_ = @this.CodeElement;
					var ar_ = context?.Operators.Not((bool?)(aq_ is null));

					return ar_;
				};
				var ah_ = context?.Operators.Where<Coding>((IEnumerable<Coding>)af_, ag_);
				Code ai_(Coding @this)
				{
					var as_ = @this.CodeElement;

					return as_;
				};
				var aj_ = context?.Operators.Select<Coding, Code>(ah_, ai_);
				bool? ak_(Code @this)
				{
					var at_ = @this.Value;
					var au_ = context?.Operators.Not((bool?)(at_ is null));

					return au_;
				};
				var al_ = context?.Operators.Where<Code>(aj_, ak_);
				string am_(Code @this)
				{
					var av_ = @this.Value;

					return av_;
				};
				var an_ = context?.Operators.Select<Code, string>(al_, am_);
				var ao_ = new string[]
				{
					"laboratory",
				};
				var ap_ = context?.Operators.Equivalent<string>(an_, (ao_ as IEnumerable<string>));

				return ap_;
			};
			var k_ = context?.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			var l_ = context?.Operators.Exists<CodeableConcept>(k_);
			var m_ = context?.Operators.And(h_, l_);
			var n_ = FitDNA.Value;
			var o_ = context?.Operators.Not((bool?)(n_ is null));
			var p_ = context?.Operators.And(m_, o_);
			var q_ = FitDNA.Effective;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(q_);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.End(s_);
			var u_ = context?.Operators.Quantity(3m, "years");
			var v_ = context?.Operators.Subtract(t_, u_);
			var x_ = context?.Operators.End(s_);
			var y_ = context?.Operators.Interval(v_, x_, true, true);
			var z_ = context?.Operators.In<CqlDateTime>(r_, y_, null);
			var ab_ = context?.Operators.End(s_);
			var ac_ = context?.Operators.Not((bool?)(ab_ is null));
			var ad_ = context?.Operators.And(z_, ac_);
			var ae_ = context?.Operators.And(p_, ad_);

			return ae_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed() => 
		__Fecal_Immunochemical_Test_DNA_Performed?.Value;

	private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var e_ = FitDNA.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context?.Operators.In<string>(f_, (g_ as IEnumerable<string>));
			var i_ = FitDNA.Category;
			bool? j_(CodeableConcept FitDNACategory)
			{
				var af_ = FitDNACategory.Coding;
				bool? ag_(Coding @this)
				{
					var aq_ = @this.CodeElement;
					var ar_ = context?.Operators.Not((bool?)(aq_ is null));

					return ar_;
				};
				var ah_ = context?.Operators.Where<Coding>((IEnumerable<Coding>)af_, ag_);
				Code ai_(Coding @this)
				{
					var as_ = @this.CodeElement;

					return as_;
				};
				var aj_ = context?.Operators.Select<Coding, Code>(ah_, ai_);
				bool? ak_(Code @this)
				{
					var at_ = @this.Value;
					var au_ = context?.Operators.Not((bool?)(at_ is null));

					return au_;
				};
				var al_ = context?.Operators.Where<Code>(aj_, ak_);
				string am_(Code @this)
				{
					var av_ = @this.Value;

					return av_;
				};
				var an_ = context?.Operators.Select<Code, string>(al_, am_);
				var ao_ = new string[]
				{
					"laboratory",
				};
				var ap_ = context?.Operators.Equivalent<string>(an_, (ao_ as IEnumerable<string>));

				return ap_;
			};
			var k_ = context?.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			var l_ = context?.Operators.Exists<CodeableConcept>(k_);
			var m_ = context?.Operators.And(h_, l_);
			var n_ = FitDNA.Value;
			var o_ = context?.Operators.Not((bool?)(n_ is null));
			var p_ = context?.Operators.And(m_, o_);
			var q_ = FitDNA.Effective;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(q_);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.End(s_);
			var u_ = context?.Operators.Quantity(3m, "years");
			var v_ = context?.Operators.Subtract(t_, u_);
			var x_ = context?.Operators.End(s_);
			var y_ = context?.Operators.Interval(v_, x_, true, true);
			var z_ = context?.Operators.In<CqlDateTime>(r_, y_, "day");
			var ab_ = context?.Operators.End(s_);
			var ac_ = context?.Operators.Not((bool?)(ab_ is null));
			var ad_ = context?.Operators.And(z_, ac_);
			var ae_ = context?.Operators.And(p_, ad_);

			return ae_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset() => 
		__Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset?.Value;

	private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var e_ = FitDNA.Category;
			bool? f_(CodeableConcept FitDNACategory)
			{
				var aa_ = FitDNACategory.Coding;
				bool? ab_(Coding @this)
				{
					var am_ = @this.CodeElement;
					var an_ = context?.Operators.Not((bool?)(am_ is null));

					return an_;
				};
				var ac_ = context?.Operators.Where<Coding>((IEnumerable<Coding>)aa_, ab_);
				Code ad_(Coding @this)
				{
					var ao_ = @this.CodeElement;

					return ao_;
				};
				var ae_ = context?.Operators.Select<Coding, Code>(ac_, ad_);
				bool? af_(Code @this)
				{
					var ap_ = @this.Value;
					var aq_ = context?.Operators.Not((bool?)(ap_ is null));

					return aq_;
				};
				var ag_ = context?.Operators.Where<Code>(ae_, af_);
				string ah_(Code @this)
				{
					var ar_ = @this.Value;

					return ar_;
				};
				var ai_ = context?.Operators.Select<Code, string>(ag_, ah_);
				var aj_ = new string[]
				{
					"laboratory",
				};
				var ak_ = context?.Operators.Equivalent<string>(ai_, (aj_ as IEnumerable<string>));
				var al_ = context?.Operators.Not(ak_);

				return al_;
			};
			var g_ = context?.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)e_, f_);
			var h_ = context?.Operators.Exists<CodeableConcept>(g_);
			var i_ = FitDNA.Value;
			var j_ = context?.Operators.Not((bool?)(i_ is null));
			var k_ = context?.Operators.And(h_, j_);
			var l_ = FitDNA.Effective;
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(l_);
			var n_ = this.Measurement_Period();
			var o_ = context?.Operators.End(n_);
			var p_ = context?.Operators.Quantity(3m, "years");
			var q_ = context?.Operators.Subtract(o_, p_);
			var s_ = context?.Operators.End(n_);
			var t_ = context?.Operators.Interval(q_, s_, true, true);
			var u_ = context?.Operators.In<CqlDateTime>(m_, t_, "day");
			var w_ = context?.Operators.End(n_);
			var x_ = context?.Operators.Not((bool?)(w_ is null));
			var y_ = context?.Operators.And(u_, x_);
			var z_ = context?.Operators.And(k_, y_);

			return z_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => 
		__Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset?.Value;

	private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation FitDNA)
		{
			var e_ = FitDNA.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var h_ = context?.Operators.In<string>(f_, (g_ as IEnumerable<string>));
			var i_ = context?.Operators.Not(h_);
			var j_ = FitDNA.Value;
			var k_ = context?.Operators.Not((bool?)(j_ is null));
			var l_ = context?.Operators.And(i_, k_);
			var m_ = FitDNA.Effective;
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = context?.Operators.Quantity(3m, "years");
			var r_ = context?.Operators.Subtract(p_, q_);
			var t_ = context?.Operators.End(o_);
			var u_ = context?.Operators.Interval(r_, t_, true, true);
			var v_ = context?.Operators.In<CqlDateTime>(n_, u_, "day");
			var x_ = context?.Operators.End(o_);
			var y_ = context?.Operators.Not((bool?)(x_ is null));
			var z_ = context?.Operators.And(v_, y_);
			var aa_ = context?.Operators.And(l_, z_);

			return aa_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => 
		__Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset?.Value;

	private IEnumerable<CqlDateTime> CT_Colonography_Display_Date_Value()
	{
		var a_ = this.CT_Colonography();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Colonography)
		{
			var g_ = Colonography.Effective;
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.Quantity(6m, "years");
			var m_ = context?.Operators.Subtract(k_, l_);
			var o_ = context?.Operators.End(j_);
			var p_ = context?.Operators.Interval(m_, o_, true, true);
			var q_ = context?.Operators.In<CqlDateTime>(i_, p_, null);
			var s_ = context?.Operators.End(j_);
			var t_ = context?.Operators.Not((bool?)(s_ is null));
			var u_ = context?.Operators.And(q_, t_);

			return u_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);
		CqlDateTime e_(Observation Colonography)
		{
			var v_ = Colonography.Effective;
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(v_);

			return w_;
		};
		var f_ = context?.Operators.Select<Observation, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("CT Colonography Display Date")]
	public IEnumerable<CqlDateTime> CT_Colonography_Display_Date() => 
		__CT_Colonography_Display_Date?.Value;

	private IEnumerable<Observation> CT_Colonography_Performed_Value()
	{
		var a_ = this.CT_Colonography();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Colonography)
		{
			var e_ = Colonography.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var h_ = context?.Operators.In<string>(f_, (g_ as IEnumerable<string>));
			var i_ = Colonography.Effective;
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
			var k_ = context?.Operators.End(j_);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = context?.Operators.Quantity(5m, "years");
			var o_ = context?.Operators.Subtract(m_, n_);
			var q_ = context?.Operators.End(l_);
			var r_ = context?.Operators.Interval(o_, q_, true, true);
			var s_ = context?.Operators.In<CqlDateTime>(k_, r_, null);
			var u_ = context?.Operators.End(l_);
			var v_ = context?.Operators.Not((bool?)(u_ is null));
			var w_ = context?.Operators.And(s_, v_);
			var x_ = context?.Operators.And(h_, w_);

			return x_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("CT Colonography Performed")]
	public IEnumerable<Observation> CT_Colonography_Performed() => 
		__CT_Colonography_Performed?.Value;

	private IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status_Value()
	{
		var a_ = this.CT_Colonography();
		var b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation Colonography)
		{
			var e_ = Colonography.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var h_ = context?.Operators.In<string>(f_, (g_ as IEnumerable<string>));
			var i_ = context?.Operators.Not(h_);
			var j_ = Colonography.Effective;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = context?.Operators.End(k_);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = context?.Operators.Quantity(5m, "years");
			var p_ = context?.Operators.Subtract(n_, o_);
			var r_ = context?.Operators.End(m_);
			var s_ = context?.Operators.Interval(p_, r_, true, true);
			var t_ = context?.Operators.In<CqlDateTime>(l_, s_, null);
			var v_ = context?.Operators.End(m_);
			var w_ = context?.Operators.Not((bool?)(v_ is null));
			var x_ = context?.Operators.And(t_, w_);
			var y_ = context?.Operators.And(i_, x_);

			return y_;
		};
		var d_ = context?.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("CT Colonography Performed without appropriate status")]
	public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status() => 
		__CT_Colonography_Performed_without_appropriate_status?.Value;

	private IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date_Value()
	{
		var a_ = this.Flexible_Sigmoidoscopy();
		var b_ = context?.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			var g_ = FlexibleSigmoidoscopy.Performed;
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.Quantity(6m, "years");
			var m_ = context?.Operators.Subtract(k_, l_);
			var o_ = context?.Operators.End(j_);
			var p_ = context?.Operators.Interval(m_, o_, true, true);
			var q_ = context?.Operators.In<CqlDateTime>(i_, p_, null);
			var s_ = context?.Operators.End(j_);
			var t_ = context?.Operators.Not((bool?)(s_ is null));
			var u_ = context?.Operators.And(q_, t_);

			return u_;
		};
		var d_ = context?.Operators.Where<Procedure>(b_, c_);
		CqlDateTime e_(Procedure FlexibleSigmoidoscopy)
		{
			var v_ = FlexibleSigmoidoscopy.Performed;
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(v_);

			return w_;
		};
		var f_ = context?.Operators.Select<Procedure, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Display Date")]
	public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date() => 
		__Flexible_Sigmoidoscopy_Display_Date?.Value;

	private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Value()
	{
		var a_ = this.Flexible_Sigmoidoscopy();
		var b_ = context?.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			var e_ = FlexibleSigmoidoscopy.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context?.Operators.Equal(f_, "completed");
			var h_ = FlexibleSigmoidoscopy.Performed;
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			var j_ = context?.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.End(k_);
			var m_ = context?.Operators.Quantity(5m, "years");
			var n_ = context?.Operators.Subtract(l_, m_);
			var p_ = context?.Operators.End(k_);
			var q_ = context?.Operators.Interval(n_, p_, true, true);
			var r_ = context?.Operators.In<CqlDateTime>(j_, q_, null);
			var t_ = context?.Operators.End(k_);
			var u_ = context?.Operators.Not((bool?)(t_ is null));
			var v_ = context?.Operators.And(r_, u_);
			var w_ = context?.Operators.And(g_, v_);

			return w_;
		};
		var d_ = context?.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
	public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed() => 
		__Flexible_Sigmoidoscopy_Performed?.Value;

	private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Value()
	{
		var a_ = this.Flexible_Sigmoidoscopy();
		var b_ = context?.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			var e_ = FlexibleSigmoidoscopy.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context?.Operators.Equal(f_, "completed");
			var h_ = context?.Operators.Not(g_);
			var i_ = FlexibleSigmoidoscopy.Performed;
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
			var k_ = context?.Operators.End(j_);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = context?.Operators.Quantity(5m, "years");
			var o_ = context?.Operators.Subtract(m_, n_);
			var q_ = context?.Operators.End(l_);
			var r_ = context?.Operators.Interval(o_, q_, true, true);
			var s_ = context?.Operators.In<CqlDateTime>(k_, r_, null);
			var u_ = context?.Operators.End(l_);
			var v_ = context?.Operators.Not((bool?)(u_ is null));
			var w_ = context?.Operators.And(s_, v_);
			var x_ = context?.Operators.And(h_, w_);

			return x_;
		};
		var d_ = context?.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed without appropriate status")]
	public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status() => 
		__Flexible_Sigmoidoscopy_Performed_without_appropriate_status?.Value;

	private IEnumerable<CqlDateTime> Colonoscopy_Display_Date_Value()
	{
		var a_ = this.Colonoscopy();
		var b_ = context?.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure Colonoscopy)
		{
			var g_ = Colonoscopy.Performed;
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.Quantity(11m, "years");
			var m_ = context?.Operators.Subtract(k_, l_);
			var o_ = context?.Operators.End(j_);
			var p_ = context?.Operators.Interval(m_, o_, true, true);
			var q_ = context?.Operators.In<CqlDateTime>(i_, p_, null);
			var s_ = context?.Operators.End(j_);
			var t_ = context?.Operators.Not((bool?)(s_ is null));
			var u_ = context?.Operators.And(q_, t_);

			return u_;
		};
		var d_ = context?.Operators.Where<Procedure>(b_, c_);
		CqlDateTime e_(Procedure Colonoscopy)
		{
			var v_ = Colonoscopy.Performed;
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(v_);

			return w_;
		};
		var f_ = context?.Operators.Select<Procedure, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Colonoscopy Display Date")]
	public IEnumerable<CqlDateTime> Colonoscopy_Display_Date() => 
		__Colonoscopy_Display_Date?.Value;

	private IEnumerable<Procedure> Colonoscopy_Performed_Value()
	{
		var a_ = this.Colonoscopy();
		var b_ = context?.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure Colonoscopy)
		{
			var e_ = Colonoscopy.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context?.Operators.Equal(f_, "completed");
			var h_ = Colonoscopy.Performed;
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			var j_ = context?.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.End(k_);
			var m_ = context?.Operators.Quantity(10m, "years");
			var n_ = context?.Operators.Subtract(l_, m_);
			var p_ = context?.Operators.End(k_);
			var q_ = context?.Operators.Interval(n_, p_, true, true);
			var r_ = context?.Operators.In<CqlDateTime>(j_, q_, null);
			var t_ = context?.Operators.End(k_);
			var u_ = context?.Operators.Not((bool?)(t_ is null));
			var v_ = context?.Operators.And(r_, u_);
			var w_ = context?.Operators.And(g_, v_);

			return w_;
		};
		var d_ = context?.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Colonoscopy Performed")]
	public IEnumerable<Procedure> Colonoscopy_Performed() => 
		__Colonoscopy_Performed?.Value;

	private IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status_Value()
	{
		var a_ = this.Colonoscopy();
		var b_ = context?.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure Colonoscopy)
		{
			var e_ = Colonoscopy.StatusElement;
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context?.Operators.Equal(f_, "completed");
			var h_ = context?.Operators.Not(g_);
			var i_ = Colonoscopy.Performed;
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
			var k_ = context?.Operators.End(j_);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = context?.Operators.Quantity(10m, "years");
			var o_ = context?.Operators.Subtract(m_, n_);
			var q_ = context?.Operators.End(l_);
			var r_ = context?.Operators.Interval(o_, q_, true, true);
			var s_ = context?.Operators.In<CqlDateTime>(k_, r_, null);
			var u_ = context?.Operators.End(l_);
			var v_ = context?.Operators.Not((bool?)(u_ is null));
			var w_ = context?.Operators.And(s_, v_);
			var x_ = context?.Operators.And(h_, w_);

			return x_;
		};
		var d_ = context?.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Colonoscopy Performed without appropriate status")]
	public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status() => 
		__Colonoscopy_Performed_without_appropriate_status?.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Colonoscopy_Performed();
		var b_ = context?.Operators.Exists<Procedure>(a_);
		var c_ = this.Fecal_Occult_Blood_Test_Performed();
		var d_ = context?.Operators.Exists<Observation>(c_);
		var e_ = context?.Operators.Or(b_, d_);
		var f_ = this.Flexible_Sigmoidoscopy_Performed();
		var g_ = context?.Operators.Exists<Procedure>(f_);
		var h_ = context?.Operators.Or(e_, g_);
		var i_ = this.Fecal_Immunochemical_Test_DNA_Performed();
		var j_ = context?.Operators.Exists<Observation>(i_);
		var k_ = context?.Operators.Or(h_, j_);
		var l_ = this.CT_Colonography_Performed();
		var m_ = context?.Operators.Exists<Observation>(l_);
		var n_ = context?.Operators.Or(k_, m_);

		return n_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator?.Value;

	private bool? Final_Numerator_Population_Value()
	{
		var a_ = this.Numerator();
		var b_ = this.Initial_Population();
		var c_ = context?.Operators.And(a_, b_);
		var d_ = this.Denominator();
		var e_ = context?.Operators.And(c_, d_);
		var f_ = this.Denominator_Exclusions();
		var g_ = context?.Operators.Not(f_);
		var h_ = context?.Operators.And(e_, g_);

		return h_;
	}

    [CqlDeclaration("Final Numerator Population")]
	public bool? Final_Numerator_Population() => 
		__Final_Numerator_Population?.Value;

}
