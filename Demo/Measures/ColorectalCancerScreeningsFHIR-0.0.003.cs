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
[CqlLibrary("ColorectalCancerScreeningsFHIR", "0.0.003")]
public class ColorectalCancerScreeningsFHIR_0_0_003
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
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
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
    internal Lazy<IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>> __Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed__day_of_TZoffset;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset;
    internal Lazy<IEnumerable<Observation>> __Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset;
    internal Lazy<IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>> __Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status;
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
    public ColorectalCancerScreeningsFHIR_0_0_003(CqlContext context)
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
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
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
        __Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status = new Lazy<IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>>(this.Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value);
        __Fecal_Occult_Blood_Test_Performed = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed_Value);
        __Fecal_Occult_Blood_Test_Performed__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Value);
        __Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value);
        __Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset = new Lazy<IEnumerable<Observation>>(this.Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value);
        __Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status = new Lazy<IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>>(this.Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Value);
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
		__Acute_Inpatient.Value;

	private CqlValueSet Advanced_Illness_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
	public CqlValueSet Advanced_Illness() => 
		__Advanced_Illness.Value;

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Colonoscopy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
	public CqlValueSet Colonoscopy() => 
		__Colonoscopy.Value;

	private CqlValueSet CT_Colonography_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
	public CqlValueSet CT_Colonography() => 
		__CT_Colonography.Value;

	private CqlValueSet Dementia_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
	public CqlValueSet Dementia_Medications() => 
		__Dementia_Medications.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Fecal_Occult_Blood_Test__FOBT__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
	public CqlValueSet Fecal_Occult_Blood_Test__FOBT_() => 
		__Fecal_Occult_Blood_Test__FOBT_.Value;

	private CqlValueSet FIT_DNA_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

    [CqlDeclaration("FIT DNA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
	public CqlValueSet FIT_DNA() => 
		__FIT_DNA.Value;

	private CqlValueSet Flexible_Sigmoidoscopy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
	public CqlValueSet Flexible_Sigmoidoscopy() => 
		__Flexible_Sigmoidoscopy.Value;

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

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory.Value;

	private CqlValueSet Malignant_Neoplasm_of_Colon_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
	public CqlValueSet Malignant_Neoplasm_of_Colon() => 
		__Malignant_Neoplasm_of_Colon.Value;

	private CqlValueSet Nonacute_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
	public CqlValueSet Nonacute_Inpatient() => 
		__Nonacute_Inpatient.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

	private CqlValueSet Observation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public CqlValueSet Observation() => 
		__Observation.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Outpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
	public CqlValueSet Outpatient() => 
		__Outpatient.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Total_Colectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
	public CqlValueSet Total_Colectomy() => 
		__Total_Colectomy.Value;

	private CqlValueSet Total_Colectomy_ICD9_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", null);

    [CqlDeclaration("Total Colectomy ICD9")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136")]
	public CqlValueSet Total_Colectomy_ICD9() => 
		__Total_Colectomy_ICD9.Value;

	private CqlCode laboratory_Value() => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory() => 
		__laboratory.Value;

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
		__ObservationCategoryCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var d_ = a_.ConvertIntegerToDecimal(default);
		var e_ = a_.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		var h_ = a_.ConvertIntegerToDecimal(default);
		var i_ = a_.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, h_);
		var j_ = a_.Interval(e_, i_, true, false);
		var k_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Online_Assessments();
		var e_ = c_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = this.Telephone_Visits();
		var h_ = c_.RetrieveByValueSet<Encounter>(g_, null);
		var i_ = a_.ListUnion<Encounter>(e_, h_);
		bool? j_(Encounter TelehealthEncounter)
		{
			var l_ = context.Operators;
			var n_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = TelehealthEncounter?.StatusElement;
			var r_ = p_.Convert<string>(q_);
			var s_ = l_.Equal(r_, "finished");
			var u_ = this.Measurement_Period();
			var v_ = TelehealthEncounter?.Period;
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(v_);
			var x_ = l_.IntervalIncludesInterval<CqlDateTime>(u_, w_, null);
			var y_ = l_.And(s_, x_);

			return y_;
		};
		var k_ = a_.WhereOrNull<Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Telehealth Services")]
	public IEnumerable<Encounter> Telehealth_Services() => 
		__Telehealth_Services.Value;

	private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var c_ = a_.TypeConverter;
		var d_ = this.Patient();
		var e_ = d_?.BirthDateElement;
		var f_ = e_?.Value;
		var g_ = c_.Convert<CqlDate>(f_);
		var j_ = this.Measurement_Period();
		var k_ = a_.Start(j_);
		var l_ = a_.DateFrom(k_);
		var m_ = a_.CalculateAgeAt(g_, l_, "year");

		return m_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
	public int? Age_at_start_of_Measurement_Period() => 
		__Age_at_start_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = context.Operators;
		var e_ = a_.TypeConverter;
		var f_ = this.Patient();
		var g_ = f_?.BirthDateElement;
		var h_ = g_?.Value;
		var i_ = e_.Convert<CqlDate>(h_);
		var l_ = this.Measurement_Period();
		var m_ = a_.Start(l_);
		var n_ = a_.DateFrom(m_);
		var o_ = a_.CalculateAgeAt(i_, n_, "year");
		var q_ = a_.Interval((int?)51, (int?)75, true, false);
		var r_ = a_.ElementInInterval<int?>(o_, q_, null);
		var u_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var v_ = this.Telehealth_Services();
		var w_ = a_.ListUnion<Encounter>(u_, v_);
		var x_ = a_.ExistsInList<Encounter>(w_);
		var y_ = a_.And(r_, x_);

		return y_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Condition> Malignant_Neoplasm_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Malignant_Neoplasm_of_Colon();
		var d_ = b_.RetrieveByValueSet<Condition>(c_, null);
		bool? e_(Condition ColorectalCancer)
		{
			var g_ = context.Operators;
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColorectalCancer);
			var j_ = g_.Start(i_);
			var l_ = this.Measurement_Period();
			var m_ = g_.End(l_);
			var n_ = g_.SameOrBefore(j_, m_, null);

			return n_;
		};
		var f_ = a_.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Malignant Neoplasm")]
	public IEnumerable<Condition> Malignant_Neoplasm() => 
		__Malignant_Neoplasm.Value;

	private IEnumerable<Procedure> Total_Colectomy_Performed_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Total_Colectomy();
		var d_ = b_.RetrieveByValueSet<Procedure>(c_, null);
		bool? e_(Procedure Colectomy)
		{
			var g_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = Colectomy?.StatusElement;
			var m_ = k_.Convert<string>(l_);
			var n_ = g_.Equal(m_, "completed");
			var q_ = Colectomy?.Performed;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var s_ = g_.End(r_);
			var u_ = this.Measurement_Period();
			var v_ = g_.End(u_);
			var w_ = g_.SameOrBefore(s_, v_, null);
			var x_ = g_.And(n_, w_);

			return x_;
		};
		var f_ = a_.WhereOrNull<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Total Colectomy Performed")]
	public IEnumerable<Procedure> Total_Colectomy_Performed() => 
		__Total_Colectomy_Performed.Value;

	private IEnumerable<Condition> Total_Colectomy_Condition_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Total_Colectomy_ICD9();
		var d_ = b_.RetrieveByValueSet<Condition>(c_, null);
		bool? e_(Condition ColectomyDx)
		{
			var g_ = context.Operators;
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColectomyDx);
			var j_ = g_.Start(i_);
			var l_ = this.Measurement_Period();
			var m_ = g_.End(l_);
			var n_ = g_.SameOrBefore(j_, m_, null);

			return n_;
		};
		var f_ = a_.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Total Colectomy Condition")]
	public IEnumerable<Condition> Total_Colectomy_Condition() => 
		__Total_Colectomy_Condition.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = context.Operators;
		var g_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var i_ = this.Malignant_Neoplasm();
		var j_ = a_.ExistsInList<Condition>(i_);
		var k_ = a_.Or(g_, j_);
		var m_ = this.Total_Colectomy_Performed();
		var n_ = a_.ExistsInList<Procedure>(m_);
		var o_ = a_.Or(k_, n_);
		var q_ = this.Total_Colectomy_Condition();
		var r_ = a_.ExistsInList<Condition>(q_);
		var s_ = a_.Or(o_, r_);
		var t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var u_ = a_.Or(s_, t_);
		var z_ = a_.TypeConverter;
		var aa_ = this.Patient();
		var ab_ = aa_?.BirthDateElement;
		var ac_ = ab_?.Value;
		var ad_ = z_.Convert<CqlDate>(ac_);
		var ag_ = this.Measurement_Period();
		var ah_ = a_.Start(ag_);
		var ai_ = a_.DateFrom(ah_);
		var aj_ = a_.CalculateAgeAt(ad_, ai_, "year");
		var ak_ = a_.GreaterOrEqual(aj_, (int?)65);
		var al_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var am_ = a_.And(ak_, al_);
		var an_ = a_.Or(u_, am_);
		var ao_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var ap_ = a_.Or(an_, ao_);

		return ap_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var e_ = c_.RetrieveByValueSet<Observation>(d_, null);
		bool? f_(Observation FecalOccult)
		{
			var j_ = context.Operators;
			var k_ = FecalOccult?.Effective;
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(k_);
			var p_ = this.Measurement_Period();
			var q_ = j_.Start(p_);
			var s_ = j_.Quantity(1m, "year");
			var t_ = j_.Subtract(q_, s_);
			var w_ = j_.End(p_);
			var x_ = j_.Interval(t_, w_, false, false);
			var y_ = j_.ElementInInterval<CqlDateTime>(l_, x_, null);

			return y_;
		};
		var g_ = a_.WhereOrNull<Observation>(e_, f_);
		Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW h_(Observation FecalOccult)
		{
			var z_ = FecalOccult?.Effective;
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(z_);
			var ab_ = context.Operators;
			var ae_ = FecalOccult?.Value;
			var af_ = ab_.LateBoundProperty<IEnumerable<Coding>>(ae_, "coding");
			bool? ag_(Coding @this)
			{
				var bh_ = context.Operators;
				var bi_ = @this?.DisplayElement;
				var bj_ = bh_.Not((bool?)(bi_ is null));

				return bj_;
			};
			var ah_ = ab_.WhereOrNull<Coding>(af_, ag_);
			FhirString ai_(Coding @this)
			{
				var bk_ = @this?.DisplayElement;

				return bk_;
			};
			var aj_ = ab_.SelectOrNull<Coding, FhirString>(ah_, ai_);
			var ar_ = FecalOccult?.Category;
			bool? as_(CodeableConcept @this)
			{
				var bl_ = context.Operators;
				var bm_ = @this?.Coding;
				var bn_ = bl_.Not((bool?)(bm_ is null));

				return bn_;
			};
			var at_ = ab_.WhereOrNull<CodeableConcept>((ar_ as IEnumerable<CodeableConcept>), as_);
			List<Coding> au_(CodeableConcept @this)
			{
				var bo_ = @this?.Coding;

				return bo_;
			};
			var av_ = ab_.SelectOrNull<CodeableConcept, List<Coding>>(at_, au_);
			var aw_ = ab_.FlattenList<Coding>(av_);
			bool? ax_(Coding @this)
			{
				var bp_ = context.Operators;
				var bq_ = @this?.CodeElement;
				var br_ = bp_.Not((bool?)(bq_ is null));

				return br_;
			};
			var ay_ = ab_.WhereOrNull<Coding>(aw_, ax_);
			Code az_(Coding @this)
			{
				var bs_ = @this?.CodeElement;

				return bs_;
			};
			var ba_ = ab_.SelectOrNull<Coding, Code>(ay_, az_);
			bool? bb_(Code @this)
			{
				var bt_ = context.Operators;
				var bu_ = @this?.Value;
				var bv_ = bt_.Not((bool?)(bu_ is null));

				return bv_;
			};
			var bc_ = ab_.WhereOrNull<Code>(ba_, bb_);
			string bd_(Code @this)
			{
				var bw_ = @this?.Value;

				return bw_;
			};
			var be_ = ab_.SelectOrNull<Code, string>(bc_, bd_);
			var bf_ = FecalOccult?.StatusElement;
			var bg_ = new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = aa_,
				occultResult = aj_,
				occultCategoryCode = be_,
				occultStatus = bf_,
			};

			return bg_;
		};
		var i_ = a_.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Display Date, Result, Category, Status")]
	public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status() => 
		__Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation FecalOccult)
		{
			var g_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = FecalOccult?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var q_ = g_.InList<string>(o_, (p_ as IEnumerable<string>));
			var t_ = FecalOccult?.Category;
			bool? u_(CodeableConcept FecalOccultCategory)
			{
				var ai_ = context.Operators;
				var an_ = FecalOccultCategory?.Coding;
				bool? ao_(Coding @this)
				{
					var ay_ = context.Operators;
					var az_ = @this?.CodeElement;
					var ba_ = ay_.Not((bool?)(az_ is null));

					return ba_;
				};
				var ap_ = ai_.WhereOrNull<Coding>((an_ as IEnumerable<Coding>), ao_);
				Code aq_(Coding @this)
				{
					var bb_ = @this?.CodeElement;

					return bb_;
				};
				var ar_ = ai_.SelectOrNull<Coding, Code>(ap_, aq_);
				bool? as_(Code @this)
				{
					var bc_ = context.Operators;
					var bd_ = @this?.Value;
					var be_ = bc_.Not((bool?)(bd_ is null));

					return be_;
				};
				var at_ = ai_.WhereOrNull<Code>(ar_, as_);
				string au_(Code @this)
				{
					var bf_ = @this?.Value;

					return bf_;
				};
				var av_ = ai_.SelectOrNull<Code, string>(at_, au_);
				var aw_ = new string[]
				{
					"laboratory",
				};
				var ax_ = ai_.ListEquivalent<string>(av_, (aw_ as IEnumerable<string>));

				return ax_;
			};
			var v_ = g_.WhereOrNull<CodeableConcept>((t_ as IEnumerable<CodeableConcept>), u_);
			var w_ = g_.ExistsInList<CodeableConcept>(v_);
			var x_ = g_.And(q_, w_);
			var z_ = FecalOccult?.Value;
			var aa_ = g_.Not((bool?)(z_ is null));
			var ab_ = g_.And(x_, aa_);
			var ad_ = FecalOccult?.Effective;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ad_);
			var af_ = this.Measurement_Period();
			var ag_ = g_.ElementInInterval<CqlDateTime>(ae_, af_, null);
			var ah_ = g_.And(ab_, ag_);

			return ah_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed() => 
		__Fecal_Occult_Blood_Test_Performed.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation FecalOccult)
		{
			var g_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = FecalOccult?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var q_ = g_.InList<string>(o_, (p_ as IEnumerable<string>));
			var t_ = FecalOccult?.Category;
			bool? u_(CodeableConcept FecalOccultCategory)
			{
				var ai_ = context.Operators;
				var an_ = FecalOccultCategory?.Coding;
				bool? ao_(Coding @this)
				{
					var ay_ = context.Operators;
					var az_ = @this?.CodeElement;
					var ba_ = ay_.Not((bool?)(az_ is null));

					return ba_;
				};
				var ap_ = ai_.WhereOrNull<Coding>((an_ as IEnumerable<Coding>), ao_);
				Code aq_(Coding @this)
				{
					var bb_ = @this?.CodeElement;

					return bb_;
				};
				var ar_ = ai_.SelectOrNull<Coding, Code>(ap_, aq_);
				bool? as_(Code @this)
				{
					var bc_ = context.Operators;
					var bd_ = @this?.Value;
					var be_ = bc_.Not((bool?)(bd_ is null));

					return be_;
				};
				var at_ = ai_.WhereOrNull<Code>(ar_, as_);
				string au_(Code @this)
				{
					var bf_ = @this?.Value;

					return bf_;
				};
				var av_ = ai_.SelectOrNull<Code, string>(at_, au_);
				var aw_ = new string[]
				{
					"laboratory",
				};
				var ax_ = ai_.ListEquivalent<string>(av_, (aw_ as IEnumerable<string>));

				return ax_;
			};
			var v_ = g_.WhereOrNull<CodeableConcept>((t_ as IEnumerable<CodeableConcept>), u_);
			var w_ = g_.ExistsInList<CodeableConcept>(v_);
			var x_ = g_.And(q_, w_);
			var z_ = FecalOccult?.Value;
			var aa_ = g_.Not((bool?)(z_ is null));
			var ab_ = g_.And(x_, aa_);
			var ad_ = FecalOccult?.Effective;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ad_);
			var af_ = this.Measurement_Period();
			var ag_ = g_.ElementInInterval<CqlDateTime>(ae_, af_, "day");
			var ah_ = g_.And(ab_, ag_);

			return ah_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset() => 
		__Fecal_Occult_Blood_Test_Performed__day_of_TZoffset.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation FecalOccult)
		{
			var g_ = context.Operators;
			var k_ = FecalOccult?.Category;
			bool? l_(CodeableConcept FecalOccultCategory)
			{
				var y_ = context.Operators;
				var ae_ = FecalOccultCategory?.Coding;
				bool? af_(Coding @this)
				{
					var aq_ = context.Operators;
					var ar_ = @this?.CodeElement;
					var as_ = aq_.Not((bool?)(ar_ is null));

					return as_;
				};
				var ag_ = y_.WhereOrNull<Coding>((ae_ as IEnumerable<Coding>), af_);
				Code ah_(Coding @this)
				{
					var at_ = @this?.CodeElement;

					return at_;
				};
				var ai_ = y_.SelectOrNull<Coding, Code>(ag_, ah_);
				bool? aj_(Code @this)
				{
					var au_ = context.Operators;
					var av_ = @this?.Value;
					var aw_ = au_.Not((bool?)(av_ is null));

					return aw_;
				};
				var ak_ = y_.WhereOrNull<Code>(ai_, aj_);
				string al_(Code @this)
				{
					var ax_ = @this?.Value;

					return ax_;
				};
				var am_ = y_.SelectOrNull<Code, string>(ak_, al_);
				var an_ = new string[]
				{
					"laboratory",
				};
				var ao_ = y_.ListEquivalent<string>(am_, (an_ as IEnumerable<string>));
				var ap_ = y_.Not(ao_);

				return ap_;
			};
			var m_ = g_.WhereOrNull<CodeableConcept>((k_ as IEnumerable<CodeableConcept>), l_);
			var n_ = g_.ExistsInList<CodeableConcept>(m_);
			var p_ = FecalOccult?.Value;
			var q_ = g_.Not((bool?)(p_ is null));
			var r_ = g_.And(n_, q_);
			var t_ = FecalOccult?.Effective;
			var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(t_);
			var v_ = this.Measurement_Period();
			var w_ = g_.ElementInInterval<CqlDateTime>(u_, v_, "day");
			var x_ = g_.And(r_, w_);

			return x_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => 
		__Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

	private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation FecalOccult)
		{
			var g_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = FecalOccult?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var q_ = g_.InList<string>(o_, (p_ as IEnumerable<string>));
			var r_ = g_.Not(q_);
			var t_ = FecalOccult?.Value;
			var u_ = g_.Not((bool?)(t_ is null));
			var v_ = g_.And(r_, u_);
			var x_ = FecalOccult?.Effective;
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(x_);
			var z_ = this.Measurement_Period();
			var aa_ = g_.ElementInInterval<CqlDateTime>(y_, z_, "day");
			var ab_ = g_.And(v_, aa_);

			return ab_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => 
		__Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

	private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.FIT_DNA();
		var e_ = c_.RetrieveByValueSet<Observation>(d_, null);
		bool? f_(Observation FitDNA)
		{
			var j_ = context.Operators;
			var l_ = FitDNA?.Effective;
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(l_);
			var q_ = this.Measurement_Period();
			var r_ = j_.End(q_);
			var t_ = j_.Quantity(4m, "years");
			var u_ = j_.Subtract(r_, t_);
			var x_ = j_.End(q_);
			var y_ = j_.Interval(u_, x_, true, true);
			var z_ = j_.ElementInInterval<CqlDateTime>(m_, y_, null);
			var ad_ = j_.End(q_);
			var ae_ = j_.Not((bool?)(ad_ is null));
			var af_ = j_.And(z_, ae_);

			return af_;
		};
		var g_ = a_.WhereOrNull<Observation>(e_, f_);
		Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW h_(Observation FitDNA)
		{
			var ag_ = FitDNA?.Effective;
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ag_);
			var ai_ = context.Operators;
			var al_ = FitDNA?.Value;
			var am_ = ai_.LateBoundProperty<IEnumerable<Coding>>(al_, "coding");
			bool? an_(Coding @this)
			{
				var bo_ = context.Operators;
				var bp_ = @this?.DisplayElement;
				var bq_ = bo_.Not((bool?)(bp_ is null));

				return bq_;
			};
			var ao_ = ai_.WhereOrNull<Coding>(am_, an_);
			FhirString ap_(Coding @this)
			{
				var br_ = @this?.DisplayElement;

				return br_;
			};
			var aq_ = ai_.SelectOrNull<Coding, FhirString>(ao_, ap_);
			var ay_ = FitDNA?.Category;
			bool? az_(CodeableConcept @this)
			{
				var bs_ = context.Operators;
				var bt_ = @this?.Coding;
				var bu_ = bs_.Not((bool?)(bt_ is null));

				return bu_;
			};
			var ba_ = ai_.WhereOrNull<CodeableConcept>((ay_ as IEnumerable<CodeableConcept>), az_);
			List<Coding> bb_(CodeableConcept @this)
			{
				var bv_ = @this?.Coding;

				return bv_;
			};
			var bc_ = ai_.SelectOrNull<CodeableConcept, List<Coding>>(ba_, bb_);
			var bd_ = ai_.FlattenList<Coding>(bc_);
			bool? be_(Coding @this)
			{
				var bw_ = context.Operators;
				var bx_ = @this?.CodeElement;
				var by_ = bw_.Not((bool?)(bx_ is null));

				return by_;
			};
			var bf_ = ai_.WhereOrNull<Coding>(bd_, be_);
			Code bg_(Coding @this)
			{
				var bz_ = @this?.CodeElement;

				return bz_;
			};
			var bh_ = ai_.SelectOrNull<Coding, Code>(bf_, bg_);
			bool? bi_(Code @this)
			{
				var ca_ = context.Operators;
				var cb_ = @this?.Value;
				var cc_ = ca_.Not((bool?)(cb_ is null));

				return cc_;
			};
			var bj_ = ai_.WhereOrNull<Code>(bh_, bi_);
			string bk_(Code @this)
			{
				var cd_ = @this?.Value;

				return cd_;
			};
			var bl_ = ai_.SelectOrNull<Code, string>(bj_, bk_);
			var bm_ = FitDNA?.StatusElement;
			var bn_ = new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = ah_,
				occultResult = aq_,
				occultCategoryCode = bl_,
				occultStatus = bm_,
			};

			return bn_;
		};
		var i_ = a_.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
	public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status() => 
		__Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status.Value;

	private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.FIT_DNA();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation FitDNA)
		{
			var g_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = FitDNA?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var q_ = g_.InList<string>(o_, (p_ as IEnumerable<string>));
			var t_ = FitDNA?.Category;
			bool? u_(CodeableConcept FitDNACategory)
			{
				var ba_ = context.Operators;
				var bf_ = FitDNACategory?.Coding;
				bool? bg_(Coding @this)
				{
					var bq_ = context.Operators;
					var br_ = @this?.CodeElement;
					var bs_ = bq_.Not((bool?)(br_ is null));

					return bs_;
				};
				var bh_ = ba_.WhereOrNull<Coding>((bf_ as IEnumerable<Coding>), bg_);
				Code bi_(Coding @this)
				{
					var bt_ = @this?.CodeElement;

					return bt_;
				};
				var bj_ = ba_.SelectOrNull<Coding, Code>(bh_, bi_);
				bool? bk_(Code @this)
				{
					var bu_ = context.Operators;
					var bv_ = @this?.Value;
					var bw_ = bu_.Not((bool?)(bv_ is null));

					return bw_;
				};
				var bl_ = ba_.WhereOrNull<Code>(bj_, bk_);
				string bm_(Code @this)
				{
					var bx_ = @this?.Value;

					return bx_;
				};
				var bn_ = ba_.SelectOrNull<Code, string>(bl_, bm_);
				var bo_ = new string[]
				{
					"laboratory",
				};
				var bp_ = ba_.ListEquivalent<string>(bn_, (bo_ as IEnumerable<string>));

				return bp_;
			};
			var v_ = g_.WhereOrNull<CodeableConcept>((t_ as IEnumerable<CodeableConcept>), u_);
			var w_ = g_.ExistsInList<CodeableConcept>(v_);
			var x_ = g_.And(q_, w_);
			var z_ = FitDNA?.Value;
			var aa_ = g_.Not((bool?)(z_ is null));
			var ab_ = g_.And(x_, aa_);
			var ae_ = FitDNA?.Effective;
			var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ae_);
			var aj_ = this.Measurement_Period();
			var ak_ = g_.End(aj_);
			var am_ = g_.Quantity(3m, "years");
			var an_ = g_.Subtract(ak_, am_);
			var aq_ = g_.End(aj_);
			var ar_ = g_.Interval(an_, aq_, true, true);
			var as_ = g_.ElementInInterval<CqlDateTime>(af_, ar_, null);
			var aw_ = g_.End(aj_);
			var ax_ = g_.Not((bool?)(aw_ is null));
			var ay_ = g_.And(as_, ax_);
			var az_ = g_.And(ab_, ay_);

			return az_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed() => 
		__Fecal_Immunochemical_Test_DNA_Performed.Value;

	private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.FIT_DNA();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation FitDNA)
		{
			var g_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = FitDNA?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var q_ = g_.InList<string>(o_, (p_ as IEnumerable<string>));
			var t_ = FitDNA?.Category;
			bool? u_(CodeableConcept FitDNACategory)
			{
				var ba_ = context.Operators;
				var bf_ = FitDNACategory?.Coding;
				bool? bg_(Coding @this)
				{
					var bq_ = context.Operators;
					var br_ = @this?.CodeElement;
					var bs_ = bq_.Not((bool?)(br_ is null));

					return bs_;
				};
				var bh_ = ba_.WhereOrNull<Coding>((bf_ as IEnumerable<Coding>), bg_);
				Code bi_(Coding @this)
				{
					var bt_ = @this?.CodeElement;

					return bt_;
				};
				var bj_ = ba_.SelectOrNull<Coding, Code>(bh_, bi_);
				bool? bk_(Code @this)
				{
					var bu_ = context.Operators;
					var bv_ = @this?.Value;
					var bw_ = bu_.Not((bool?)(bv_ is null));

					return bw_;
				};
				var bl_ = ba_.WhereOrNull<Code>(bj_, bk_);
				string bm_(Code @this)
				{
					var bx_ = @this?.Value;

					return bx_;
				};
				var bn_ = ba_.SelectOrNull<Code, string>(bl_, bm_);
				var bo_ = new string[]
				{
					"laboratory",
				};
				var bp_ = ba_.ListEquivalent<string>(bn_, (bo_ as IEnumerable<string>));

				return bp_;
			};
			var v_ = g_.WhereOrNull<CodeableConcept>((t_ as IEnumerable<CodeableConcept>), u_);
			var w_ = g_.ExistsInList<CodeableConcept>(v_);
			var x_ = g_.And(q_, w_);
			var z_ = FitDNA?.Value;
			var aa_ = g_.Not((bool?)(z_ is null));
			var ab_ = g_.And(x_, aa_);
			var ae_ = FitDNA?.Effective;
			var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ae_);
			var aj_ = this.Measurement_Period();
			var ak_ = g_.End(aj_);
			var am_ = g_.Quantity(3m, "years");
			var an_ = g_.Subtract(ak_, am_);
			var aq_ = g_.End(aj_);
			var ar_ = g_.Interval(an_, aq_, true, true);
			var as_ = g_.ElementInInterval<CqlDateTime>(af_, ar_, "day");
			var aw_ = g_.End(aj_);
			var ax_ = g_.Not((bool?)(aw_ is null));
			var ay_ = g_.And(as_, ax_);
			var az_ = g_.And(ab_, ay_);

			return az_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset() => 
		__Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset.Value;

	private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.FIT_DNA();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation FitDNA)
		{
			var g_ = context.Operators;
			var k_ = FitDNA?.Category;
			bool? l_(CodeableConcept FitDNACategory)
			{
				var aq_ = context.Operators;
				var aw_ = FitDNACategory?.Coding;
				bool? ax_(Coding @this)
				{
					var bi_ = context.Operators;
					var bj_ = @this?.CodeElement;
					var bk_ = bi_.Not((bool?)(bj_ is null));

					return bk_;
				};
				var ay_ = aq_.WhereOrNull<Coding>((aw_ as IEnumerable<Coding>), ax_);
				Code az_(Coding @this)
				{
					var bl_ = @this?.CodeElement;

					return bl_;
				};
				var ba_ = aq_.SelectOrNull<Coding, Code>(ay_, az_);
				bool? bb_(Code @this)
				{
					var bm_ = context.Operators;
					var bn_ = @this?.Value;
					var bo_ = bm_.Not((bool?)(bn_ is null));

					return bo_;
				};
				var bc_ = aq_.WhereOrNull<Code>(ba_, bb_);
				string bd_(Code @this)
				{
					var bp_ = @this?.Value;

					return bp_;
				};
				var be_ = aq_.SelectOrNull<Code, string>(bc_, bd_);
				var bf_ = new string[]
				{
					"laboratory",
				};
				var bg_ = aq_.ListEquivalent<string>(be_, (bf_ as IEnumerable<string>));
				var bh_ = aq_.Not(bg_);

				return bh_;
			};
			var m_ = g_.WhereOrNull<CodeableConcept>((k_ as IEnumerable<CodeableConcept>), l_);
			var n_ = g_.ExistsInList<CodeableConcept>(m_);
			var p_ = FitDNA?.Value;
			var q_ = g_.Not((bool?)(p_ is null));
			var r_ = g_.And(n_, q_);
			var u_ = FitDNA?.Effective;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(u_);
			var z_ = this.Measurement_Period();
			var aa_ = g_.End(z_);
			var ac_ = g_.Quantity(3m, "years");
			var ad_ = g_.Subtract(aa_, ac_);
			var ag_ = g_.End(z_);
			var ah_ = g_.Interval(ad_, ag_, true, true);
			var ai_ = g_.ElementInInterval<CqlDateTime>(v_, ah_, "day");
			var am_ = g_.End(z_);
			var an_ = g_.Not((bool?)(am_ is null));
			var ao_ = g_.And(ai_, an_);
			var ap_ = g_.And(r_, ao_);

			return ap_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => 
		__Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

	private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.FIT_DNA();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation FitDNA)
		{
			var g_ = context.Operators;
			var k_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var l_ = k_.Operators;
			var m_ = l_.TypeConverter;
			var n_ = FitDNA?.StatusElement;
			var o_ = m_.Convert<string>(n_);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var q_ = g_.InList<string>(o_, (p_ as IEnumerable<string>));
			var r_ = g_.Not(q_);
			var t_ = FitDNA?.Value;
			var u_ = g_.Not((bool?)(t_ is null));
			var v_ = g_.And(r_, u_);
			var y_ = FitDNA?.Effective;
			var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(y_);
			var ad_ = this.Measurement_Period();
			var ae_ = g_.End(ad_);
			var ag_ = g_.Quantity(3m, "years");
			var ah_ = g_.Subtract(ae_, ag_);
			var ak_ = g_.End(ad_);
			var al_ = g_.Interval(ah_, ak_, true, true);
			var am_ = g_.ElementInInterval<CqlDateTime>(z_, al_, "day");
			var aq_ = g_.End(ad_);
			var ar_ = g_.Not((bool?)(aq_ is null));
			var as_ = g_.And(am_, ar_);
			var at_ = g_.And(v_, as_);

			return at_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
	public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => 
		__Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

	private IEnumerable<CqlDateTime> CT_Colonography_Display_Date_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.CT_Colonography();
		var e_ = c_.RetrieveByValueSet<Observation>(d_, null);
		bool? f_(Observation Colonography)
		{
			var j_ = context.Operators;
			var m_ = Colonography?.Effective;
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			var o_ = j_.End(n_);
			var s_ = this.Measurement_Period();
			var t_ = j_.End(s_);
			var v_ = j_.Quantity(6m, "years");
			var w_ = j_.Subtract(t_, v_);
			var z_ = j_.End(s_);
			var aa_ = j_.Interval(w_, z_, true, true);
			var ab_ = j_.ElementInInterval<CqlDateTime>(o_, aa_, null);
			var af_ = j_.End(s_);
			var ag_ = j_.Not((bool?)(af_ is null));
			var ah_ = j_.And(ab_, ag_);

			return ah_;
		};
		var g_ = a_.WhereOrNull<Observation>(e_, f_);
		CqlDateTime h_(Observation Colonography)
		{
			var ai_ = Colonography?.Effective;
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ai_);

			return aj_;
		};
		var i_ = a_.SelectOrNull<Observation, CqlDateTime>(g_, h_);

		return i_;
	}

    [CqlDeclaration("CT Colonography Display Date")]
	public IEnumerable<CqlDateTime> CT_Colonography_Display_Date() => 
		__CT_Colonography_Display_Date.Value;

	private IEnumerable<Observation> CT_Colonography_Performed_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.CT_Colonography();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation Colonography)
		{
			var g_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = Colonography?.StatusElement;
			var m_ = k_.Convert<string>(l_);
			var n_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var o_ = g_.InList<string>(m_, (n_ as IEnumerable<string>));
			var s_ = Colonography?.Effective;
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
			var u_ = g_.End(t_);
			var y_ = this.Measurement_Period();
			var z_ = g_.End(y_);
			var ab_ = g_.Quantity(5m, "years");
			var ac_ = g_.Subtract(z_, ab_);
			var af_ = g_.End(y_);
			var ag_ = g_.Interval(ac_, af_, true, true);
			var ah_ = g_.ElementInInterval<CqlDateTime>(u_, ag_, null);
			var al_ = g_.End(y_);
			var am_ = g_.Not((bool?)(al_ is null));
			var an_ = g_.And(ah_, am_);
			var ao_ = g_.And(o_, an_);

			return ao_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("CT Colonography Performed")]
	public IEnumerable<Observation> CT_Colonography_Performed() => 
		__CT_Colonography_Performed.Value;

	private IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.CT_Colonography();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation Colonography)
		{
			var g_ = context.Operators;
			var j_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var k_ = j_.Operators;
			var l_ = k_.TypeConverter;
			var m_ = Colonography?.StatusElement;
			var n_ = l_.Convert<string>(m_);
			var o_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var p_ = g_.InList<string>(n_, (o_ as IEnumerable<string>));
			var q_ = g_.Not(p_);
			var u_ = Colonography?.Effective;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
			var w_ = g_.End(v_);
			var aa_ = this.Measurement_Period();
			var ab_ = g_.End(aa_);
			var ad_ = g_.Quantity(5m, "years");
			var ae_ = g_.Subtract(ab_, ad_);
			var ah_ = g_.End(aa_);
			var ai_ = g_.Interval(ae_, ah_, true, true);
			var aj_ = g_.ElementInInterval<CqlDateTime>(w_, ai_, null);
			var an_ = g_.End(aa_);
			var ao_ = g_.Not((bool?)(an_ is null));
			var ap_ = g_.And(aj_, ao_);
			var aq_ = g_.And(q_, ap_);

			return aq_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("CT Colonography Performed without appropriate status")]
	public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status() => 
		__CT_Colonography_Performed_without_appropriate_status.Value;

	private IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Flexible_Sigmoidoscopy();
		var e_ = c_.RetrieveByValueSet<Procedure>(d_, null);
		bool? f_(Procedure FlexibleSigmoidoscopy)
		{
			var j_ = context.Operators;
			var m_ = FlexibleSigmoidoscopy?.Performed;
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			var o_ = j_.End(n_);
			var s_ = this.Measurement_Period();
			var t_ = j_.End(s_);
			var v_ = j_.Quantity(6m, "years");
			var w_ = j_.Subtract(t_, v_);
			var z_ = j_.End(s_);
			var aa_ = j_.Interval(w_, z_, true, true);
			var ab_ = j_.ElementInInterval<CqlDateTime>(o_, aa_, null);
			var af_ = j_.End(s_);
			var ag_ = j_.Not((bool?)(af_ is null));
			var ah_ = j_.And(ab_, ag_);

			return ah_;
		};
		var g_ = a_.WhereOrNull<Procedure>(e_, f_);
		CqlDateTime h_(Procedure FlexibleSigmoidoscopy)
		{
			var ai_ = FlexibleSigmoidoscopy?.Performed;
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ai_);

			return aj_;
		};
		var i_ = a_.SelectOrNull<Procedure, CqlDateTime>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Display Date")]
	public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date() => 
		__Flexible_Sigmoidoscopy_Display_Date.Value;

	private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Flexible_Sigmoidoscopy();
		var d_ = b_.RetrieveByValueSet<Procedure>(c_, null);
		bool? e_(Procedure FlexibleSigmoidoscopy)
		{
			var g_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = FlexibleSigmoidoscopy?.StatusElement;
			var m_ = k_.Convert<string>(l_);
			var n_ = g_.Equal(m_, "completed");
			var r_ = FlexibleSigmoidoscopy?.Performed;
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			var t_ = g_.End(s_);
			var x_ = this.Measurement_Period();
			var y_ = g_.End(x_);
			var aa_ = g_.Quantity(5m, "years");
			var ab_ = g_.Subtract(y_, aa_);
			var ae_ = g_.End(x_);
			var af_ = g_.Interval(ab_, ae_, true, true);
			var ag_ = g_.ElementInInterval<CqlDateTime>(t_, af_, null);
			var ak_ = g_.End(x_);
			var al_ = g_.Not((bool?)(ak_ is null));
			var am_ = g_.And(ag_, al_);
			var an_ = g_.And(n_, am_);

			return an_;
		};
		var f_ = a_.WhereOrNull<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
	public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed() => 
		__Flexible_Sigmoidoscopy_Performed.Value;

	private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Flexible_Sigmoidoscopy();
		var d_ = b_.RetrieveByValueSet<Procedure>(c_, null);
		bool? e_(Procedure FlexibleSigmoidoscopy)
		{
			var g_ = context.Operators;
			var j_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var k_ = j_.Operators;
			var l_ = k_.TypeConverter;
			var m_ = FlexibleSigmoidoscopy?.StatusElement;
			var n_ = l_.Convert<string>(m_);
			var o_ = g_.Equal(n_, "completed");
			var p_ = g_.Not(o_);
			var t_ = FlexibleSigmoidoscopy?.Performed;
			var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(t_);
			var v_ = g_.End(u_);
			var z_ = this.Measurement_Period();
			var aa_ = g_.End(z_);
			var ac_ = g_.Quantity(5m, "years");
			var ad_ = g_.Subtract(aa_, ac_);
			var ag_ = g_.End(z_);
			var ah_ = g_.Interval(ad_, ag_, true, true);
			var ai_ = g_.ElementInInterval<CqlDateTime>(v_, ah_, null);
			var am_ = g_.End(z_);
			var an_ = g_.Not((bool?)(am_ is null));
			var ao_ = g_.And(ai_, an_);
			var ap_ = g_.And(p_, ao_);

			return ap_;
		};
		var f_ = a_.WhereOrNull<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed without appropriate status")]
	public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status() => 
		__Flexible_Sigmoidoscopy_Performed_without_appropriate_status.Value;

	private IEnumerable<CqlDateTime> Colonoscopy_Display_Date_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Colonoscopy();
		var e_ = c_.RetrieveByValueSet<Procedure>(d_, null);
		bool? f_(Procedure Colonoscopy)
		{
			var j_ = context.Operators;
			var m_ = Colonoscopy?.Performed;
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			var o_ = j_.End(n_);
			var s_ = this.Measurement_Period();
			var t_ = j_.End(s_);
			var v_ = j_.Quantity(11m, "years");
			var w_ = j_.Subtract(t_, v_);
			var z_ = j_.End(s_);
			var aa_ = j_.Interval(w_, z_, true, true);
			var ab_ = j_.ElementInInterval<CqlDateTime>(o_, aa_, null);
			var af_ = j_.End(s_);
			var ag_ = j_.Not((bool?)(af_ is null));
			var ah_ = j_.And(ab_, ag_);

			return ah_;
		};
		var g_ = a_.WhereOrNull<Procedure>(e_, f_);
		CqlDateTime h_(Procedure Colonoscopy)
		{
			var ai_ = Colonoscopy?.Performed;
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ai_);

			return aj_;
		};
		var i_ = a_.SelectOrNull<Procedure, CqlDateTime>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Colonoscopy Display Date")]
	public IEnumerable<CqlDateTime> Colonoscopy_Display_Date() => 
		__Colonoscopy_Display_Date.Value;

	private IEnumerable<Procedure> Colonoscopy_Performed_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Colonoscopy();
		var d_ = b_.RetrieveByValueSet<Procedure>(c_, null);
		bool? e_(Procedure Colonoscopy)
		{
			var g_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = Colonoscopy?.StatusElement;
			var m_ = k_.Convert<string>(l_);
			var n_ = g_.Equal(m_, "completed");
			var r_ = Colonoscopy?.Performed;
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			var t_ = g_.End(s_);
			var x_ = this.Measurement_Period();
			var y_ = g_.End(x_);
			var aa_ = g_.Quantity(10m, "years");
			var ab_ = g_.Subtract(y_, aa_);
			var ae_ = g_.End(x_);
			var af_ = g_.Interval(ab_, ae_, true, true);
			var ag_ = g_.ElementInInterval<CqlDateTime>(t_, af_, null);
			var ak_ = g_.End(x_);
			var al_ = g_.Not((bool?)(ak_ is null));
			var am_ = g_.And(ag_, al_);
			var an_ = g_.And(n_, am_);

			return an_;
		};
		var f_ = a_.WhereOrNull<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Colonoscopy Performed")]
	public IEnumerable<Procedure> Colonoscopy_Performed() => 
		__Colonoscopy_Performed.Value;

	private IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Colonoscopy();
		var d_ = b_.RetrieveByValueSet<Procedure>(c_, null);
		bool? e_(Procedure Colonoscopy)
		{
			var g_ = context.Operators;
			var j_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var k_ = j_.Operators;
			var l_ = k_.TypeConverter;
			var m_ = Colonoscopy?.StatusElement;
			var n_ = l_.Convert<string>(m_);
			var o_ = g_.Equal(n_, "completed");
			var p_ = g_.Not(o_);
			var t_ = Colonoscopy?.Performed;
			var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(t_);
			var v_ = g_.End(u_);
			var z_ = this.Measurement_Period();
			var aa_ = g_.End(z_);
			var ac_ = g_.Quantity(10m, "years");
			var ad_ = g_.Subtract(aa_, ac_);
			var ag_ = g_.End(z_);
			var ah_ = g_.Interval(ad_, ag_, true, true);
			var ai_ = g_.ElementInInterval<CqlDateTime>(v_, ah_, null);
			var am_ = g_.End(z_);
			var an_ = g_.Not((bool?)(am_ is null));
			var ao_ = g_.And(ai_, an_);
			var ap_ = g_.And(p_, ao_);

			return ap_;
		};
		var f_ = a_.WhereOrNull<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Colonoscopy Performed without appropriate status")]
	public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status() => 
		__Colonoscopy_Performed_without_appropriate_status.Value;

	private bool? Numerator_Value()
	{
		var a_ = context.Operators;
		var f_ = this.Colonoscopy_Performed();
		var g_ = a_.ExistsInList<Procedure>(f_);
		var i_ = this.Fecal_Occult_Blood_Test_Performed();
		var j_ = a_.ExistsInList<Observation>(i_);
		var k_ = a_.Or(g_, j_);
		var m_ = this.Flexible_Sigmoidoscopy_Performed();
		var n_ = a_.ExistsInList<Procedure>(m_);
		var o_ = a_.Or(k_, n_);
		var q_ = this.Fecal_Immunochemical_Test_DNA_Performed();
		var r_ = a_.ExistsInList<Observation>(q_);
		var s_ = a_.Or(o_, r_);
		var u_ = this.CT_Colonography_Performed();
		var v_ = a_.ExistsInList<Observation>(u_);
		var w_ = a_.Or(s_, v_);

		return w_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Final_Numerator_Population_Value()
	{
		var a_ = context.Operators;
		var d_ = this.Numerator();
		var e_ = this.Initial_Population();
		var f_ = a_.And(d_, e_);
		var g_ = this.Denominator();
		var h_ = a_.And(f_, g_);
		var j_ = this.Denominator_Exclusions();
		var k_ = a_.Not(j_);
		var l_ = a_.And(h_, k_);

		return l_;
	}

    [CqlDeclaration("Final Numerator Population")]
	public bool? Final_Numerator_Population() => 
		__Final_Numerator_Population.Value;

}