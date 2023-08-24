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
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Annual_Wellness_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit() => __Annual_Wellness_Visit.Value;

    private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Colonoscopy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
    public CqlValueSet Colonoscopy() => __Colonoscopy.Value;

    private CqlValueSet CT_Colonography_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
    public CqlValueSet CT_Colonography() => __CT_Colonography.Value;

    private CqlValueSet Dementia_Medications_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Fecal_Occult_Blood_Test__FOBT__Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
    public CqlValueSet Fecal_Occult_Blood_Test__FOBT_() => __Fecal_Occult_Blood_Test__FOBT_.Value;

    private CqlValueSet FIT_DNA_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

    [CqlDeclaration("FIT DNA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
    public CqlValueSet FIT_DNA() => __FIT_DNA.Value;

    private CqlValueSet Flexible_Sigmoidoscopy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
    public CqlValueSet Flexible_Sigmoidoscopy() => __Flexible_Sigmoidoscopy.Value;

    private CqlValueSet Frailty_Device_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Home_Healthcare_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet Hospice_care_ambulatory_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_care_ambulatory() => __Hospice_care_ambulatory.Value;

    private CqlValueSet Malignant_Neoplasm_of_Colon_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
    public CqlValueSet Malignant_Neoplasm_of_Colon() => __Malignant_Neoplasm_of_Colon.Value;

    private CqlValueSet Nonacute_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Nursing_Facility_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Observation_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Office_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Online_Assessments_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Outpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
    public CqlValueSet Outpatient() => __Outpatient.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlValueSet Total_Colectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
    public CqlValueSet Total_Colectomy() => __Total_Colectomy.Value;

    private CqlValueSet Total_Colectomy_ICD9_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", null);

    [CqlDeclaration("Total Colectomy ICD9")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136")]
    public CqlValueSet Total_Colectomy_ICD9() => __Total_Colectomy_ICD9.Value;

    private CqlCode laboratory_Value() =>
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("laboratory")]
    public CqlCode laboratory() => __laboratory.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes() => __ObservationCategoryCodes.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("Exam130FHIR-0.0.003", "Measurement Period", f_);

		return (CqlInterval<CqlDateTime>)g_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var i_ = this.Online_Assessments();
		var j_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = this.Telephone_Visits();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, null);
		var m_ = context?.Operators.ListUnion<Encounter>(j_, l_);
		var n_ = (Encounter TelehealthEncounter) =>
		{
			var a_ = (TelehealthEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = this.Measurement_Period();
			var f_ = (TelehealthEncounter?.Period as object);
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
			var h_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, null);

			return context?.Operators.And(d_, h_);
		};

		return context?.Operators.WhereOrNull<Encounter>(m_, n_);
	}

    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services() => __Telehealth_Services.Value;

    private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);

		return context?.Operators.CalculateAgeAt(b_, e_, "year");
	}

    [CqlDeclaration("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period() => __Age_at_start_of_Measurement_Period.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context?.Operators.Interval((int?)51, (int?)75, true, false);
		var h_ = context?.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var j_ = this.Telehealth_Services();
		var k_ = context?.Operators.ListUnion<Encounter>(i_, j_);
		var l_ = context?.Operators.ExistsInList<Encounter>(k_);

		return context?.Operators.And(h_, l_);
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<Condition> Malignant_Neoplasm_Value()
	{
		var e_ = this.Malignant_Neoplasm_of_Colon();
		var f_ = context?.DataRetriever.RetrieveByValueSet<Condition>(e_, null);
		var g_ = (Condition ColorectalCancer) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColorectalCancer);
			var b_ = context?.Operators.Start(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.End(c_);

			return context?.Operators.SameOrBefore(b_, d_, null);
		};

		return context?.Operators.WhereOrNull<Condition>(f_, g_);
	}

    [CqlDeclaration("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm() => __Malignant_Neoplasm.Value;

    private IEnumerable<Procedure> Total_Colectomy_Performed_Value()
	{
		var k_ = this.Total_Colectomy();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(k_, null);
		var m_ = (Procedure Colectomy) =>
		{
			var a_ = (Colectomy?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = (Colectomy?.Performed as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.SameOrBefore(g_, i_, null);

			return context?.Operators.And(d_, j_);
		};

		return context?.Operators.WhereOrNull<Procedure>(l_, m_);
	}

    [CqlDeclaration("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed() => __Total_Colectomy_Performed.Value;

    private IEnumerable<Condition> Total_Colectomy_Condition_Value()
	{
		var e_ = this.Total_Colectomy_ICD9();
		var f_ = context?.DataRetriever.RetrieveByValueSet<Condition>(e_, null);
		var g_ = (Condition ColectomyDx) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColectomyDx);
			var b_ = context?.Operators.Start(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.End(c_);

			return context?.Operators.SameOrBefore(b_, d_, null);
		};

		return context?.Operators.WhereOrNull<Condition>(f_, g_);
	}

    [CqlDeclaration("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition() => __Total_Colectomy_Condition.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Malignant_Neoplasm();
		var c_ = context?.Operators.ExistsInList<Condition>(b_);
		var d_ = context?.Operators.Or(a_, c_);
		var e_ = this.Total_Colectomy_Performed();
		var f_ = context?.Operators.ExistsInList<Procedure>(e_);
		var g_ = context?.Operators.Or(d_, f_);
		var h_ = this.Total_Colectomy_Condition();
		var i_ = context?.Operators.ExistsInList<Condition>(h_);
		var j_ = context?.Operators.Or(g_, i_);
		var k_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var l_ = context?.Operators.Or(j_, k_);
		var m_ = (this.Patient()?.BirthDateElement?.Value as object);
		var n_ = context?.Operators?.TypeConverter.Convert<CqlDate>(m_);
		var o_ = this.Measurement_Period();
		var p_ = context?.Operators.Start(o_);
		var q_ = context?.Operators.DateFrom(p_);
		var r_ = context?.Operators.CalculateAgeAt(n_, q_, "year");
		var s_ = (r_ as object);
		var t_ = ((int?)65 as object);
		var u_ = context?.Operators.GreaterOrEqual(s_, t_);
		var v_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var w_ = context?.Operators.And(u_, v_);
		var x_ = context?.Operators.Or(l_, w_);
		var y_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();

		return context?.Operators.Or(x_, y_);
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value()
	{
		var ak_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var al_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ak_, null);
		var am_ = (Observation FecalOccult) =>
		{
			var a_ = (FecalOccult?.Effective as object);
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.Start(c_);
			var e_ = context?.Operators.Quantity(1m, "year");
			var f_ = context?.Operators.Subtract(d_, e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.End(g_);
			var i_ = context?.Operators.Interval(f_, h_, false, false);

			return context?.Operators.ElementInInterval<CqlDateTime>(b_, i_, null);
		};
		var an_ = context?.Operators.WhereOrNull<Observation>(al_, am_);
		var ao_ = (Observation FecalOccult) =>
		{
			var n_ = (FecalOccult?.Effective as object);
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(n_);
			var p_ = (FecalOccult?.Value as object);
			var q_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(p_, "coding");
			var r_ = (Coding @this) =>
			{
				var j_ = (bool?)(@this?.DisplayElement == null);

				return context?.Operators.Not(j_);
			};
			var s_ = context?.Operators.WhereOrNull<Coding>(q_, r_);
			var t_ = (Coding @this) => @this?.DisplayElement;
			var u_ = context?.Operators.SelectOrNull<Coding, FhirString>(s_, t_);
			var v_ = (FecalOccult?.Category as IEnumerable<CodeableConcept>);
			var w_ = (CodeableConcept @this) =>
			{
				var k_ = (bool?)(@this?.Coding == null);

				return context?.Operators.Not(k_);
			};
			var x_ = context?.Operators.WhereOrNull<CodeableConcept>(v_, w_);
			var y_ = (CodeableConcept @this) => @this?.Coding;
			var z_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(x_, y_);
			var aa_ = context?.Operators.FlattenList<Coding>(z_);
			var ab_ = (Coding @this) =>
			{
				var l_ = (bool?)(@this?.CodeElement == null);

				return context?.Operators.Not(l_);
			};
			var ac_ = context?.Operators.WhereOrNull<Coding>(aa_, ab_);
			var ad_ = (Coding @this) => @this?.CodeElement;
			var ae_ = context?.Operators.SelectOrNull<Coding, Code>(ac_, ad_);
			var af_ = (Code @this) =>
			{
				var m_ = (bool?)(@this?.Value == null);

				return context?.Operators.Not(m_);
			};
			var ag_ = context?.Operators.WhereOrNull<Code>(ae_, af_);
			var ah_ = (Code @this) => @this?.Value;
			var ai_ = context?.Operators.SelectOrNull<Code, string>(ag_, ah_);
			var aj_ = FecalOccult?.StatusElement;

			return new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = o_,
				occultResult = u_,
				occultCategoryCode = ai_,
				occultStatus = aj_,
			};
		};

		return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(an_, ao_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status() => __Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Value()
	{
		var ai_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var aj_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ai_, null);
		var ak_ = (Observation FecalOccult) =>
		{
			var o_ = (FecalOccult?.StatusElement as object);
			var p_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(o_);
			var q_ = "final";
			var r_ = "amended";
			var s_ = "corrected";
			var t_ = new string[]
			{
				q_,
				r_,
				s_,
			};
			var u_ = (t_ as IEnumerable<string>);
			var v_ = context?.Operators.InList<string>(p_, u_);
			var w_ = (FecalOccult?.Category as IEnumerable<CodeableConcept>);
			var x_ = (CodeableConcept FecalOccultCategory) =>
			{
				var c_ = (FecalOccultCategory?.Coding as IEnumerable<Coding>);
				var d_ = (Coding @this) =>
				{
					var a_ = (bool?)(@this?.CodeElement == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Coding>(c_, d_);
				var f_ = (Coding @this) => @this?.CodeElement;
				var g_ = context?.Operators.SelectOrNull<Coding, Code>(e_, f_);
				var h_ = (Code @this) =>
				{
					var b_ = (bool?)(@this?.Value == null);

					return context?.Operators.Not(b_);
				};
				var i_ = context?.Operators.WhereOrNull<Code>(g_, h_);
				var j_ = (Code @this) => @this?.Value;
				var k_ = context?.Operators.SelectOrNull<Code, string>(i_, j_);
				var l_ = "laboratory";
				var m_ = new string[]
				{
					l_,
				};
				var n_ = (m_ as IEnumerable<string>);

				return context?.Operators.ListEquivalent<string>(k_, n_);
			};
			var y_ = context?.Operators.WhereOrNull<CodeableConcept>(w_, x_);
			var z_ = context?.Operators.ExistsInList<CodeableConcept>(y_);
			var aa_ = context?.Operators.And(v_, z_);
			var ab_ = (bool?)((FecalOccult?.Value as object) == null);
			var ac_ = context?.Operators.Not(ab_);
			var ad_ = context?.Operators.And(aa_, ac_);
			var ae_ = (FecalOccult?.Effective as object);
			var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context?.Operators.ElementInInterval<CqlDateTime>(af_, ag_, null);

			return context?.Operators.And(ad_, ah_);
		};

		return context?.Operators.WhereOrNull<Observation>(aj_, ak_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed() => __Fecal_Occult_Blood_Test_Performed.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Value()
	{
		var ai_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var aj_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ai_, null);
		var ak_ = (Observation FecalOccult) =>
		{
			var o_ = (FecalOccult?.StatusElement as object);
			var p_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(o_);
			var q_ = "final";
			var r_ = "amended";
			var s_ = "corrected";
			var t_ = new string[]
			{
				q_,
				r_,
				s_,
			};
			var u_ = (t_ as IEnumerable<string>);
			var v_ = context?.Operators.InList<string>(p_, u_);
			var w_ = (FecalOccult?.Category as IEnumerable<CodeableConcept>);
			var x_ = (CodeableConcept FecalOccultCategory) =>
			{
				var c_ = (FecalOccultCategory?.Coding as IEnumerable<Coding>);
				var d_ = (Coding @this) =>
				{
					var a_ = (bool?)(@this?.CodeElement == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Coding>(c_, d_);
				var f_ = (Coding @this) => @this?.CodeElement;
				var g_ = context?.Operators.SelectOrNull<Coding, Code>(e_, f_);
				var h_ = (Code @this) =>
				{
					var b_ = (bool?)(@this?.Value == null);

					return context?.Operators.Not(b_);
				};
				var i_ = context?.Operators.WhereOrNull<Code>(g_, h_);
				var j_ = (Code @this) => @this?.Value;
				var k_ = context?.Operators.SelectOrNull<Code, string>(i_, j_);
				var l_ = "laboratory";
				var m_ = new string[]
				{
					l_,
				};
				var n_ = (m_ as IEnumerable<string>);

				return context?.Operators.ListEquivalent<string>(k_, n_);
			};
			var y_ = context?.Operators.WhereOrNull<CodeableConcept>(w_, x_);
			var z_ = context?.Operators.ExistsInList<CodeableConcept>(y_);
			var aa_ = context?.Operators.And(v_, z_);
			var ab_ = (bool?)((FecalOccult?.Value as object) == null);
			var ac_ = context?.Operators.Not(ab_);
			var ad_ = context?.Operators.And(aa_, ac_);
			var ae_ = (FecalOccult?.Effective as object);
			var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context?.Operators.ElementInInterval<CqlDateTime>(af_, ag_, "day");

			return context?.Operators.And(ad_, ah_);
		};

		return context?.Operators.WhereOrNull<Observation>(aj_, ak_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var aa_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aa_, null);
		var ac_ = (Observation FecalOccult) =>
		{
			var p_ = (FecalOccult?.Category as IEnumerable<CodeableConcept>);
			var q_ = (CodeableConcept FecalOccultCategory) =>
			{
				var c_ = (FecalOccultCategory?.Coding as IEnumerable<Coding>);
				var d_ = (Coding @this) =>
				{
					var a_ = (bool?)(@this?.CodeElement == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Coding>(c_, d_);
				var f_ = (Coding @this) => @this?.CodeElement;
				var g_ = context?.Operators.SelectOrNull<Coding, Code>(e_, f_);
				var h_ = (Code @this) =>
				{
					var b_ = (bool?)(@this?.Value == null);

					return context?.Operators.Not(b_);
				};
				var i_ = context?.Operators.WhereOrNull<Code>(g_, h_);
				var j_ = (Code @this) => @this?.Value;
				var k_ = context?.Operators.SelectOrNull<Code, string>(i_, j_);
				var l_ = "laboratory";
				var m_ = new string[]
				{
					l_,
				};
				var n_ = (m_ as IEnumerable<string>);
				var o_ = context?.Operators.ListEquivalent<string>(k_, n_);

				return context?.Operators.Not(o_);
			};
			var r_ = context?.Operators.WhereOrNull<CodeableConcept>(p_, q_);
			var s_ = context?.Operators.ExistsInList<CodeableConcept>(r_);
			var t_ = (bool?)((FecalOccult?.Value as object) == null);
			var u_ = context?.Operators.Not(t_);
			var v_ = context?.Operators.And(s_, u_);
			var w_ = (FecalOccult?.Effective as object);
			var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(w_);
			var y_ = this.Measurement_Period();
			var z_ = context?.Operators.ElementInInterval<CqlDateTime>(x_, y_, "day");

			return context?.Operators.And(v_, z_);
		};

		return context?.Operators.WhereOrNull<Observation>(ab_, ac_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var q_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Observation>(q_, null);
		var s_ = (Observation FecalOccult) =>
		{
			var a_ = (FecalOccult?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = context?.Operators.Not(h_);
			var j_ = (bool?)((FecalOccult?.Value as object) == null);
			var k_ = context?.Operators.Not(j_);
			var l_ = context?.Operators.And(i_, k_);
			var m_ = (FecalOccult?.Effective as object);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, o_, "day");

			return context?.Operators.And(l_, p_);
		};

		return context?.Operators.WhereOrNull<Observation>(r_, s_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Value()
	{
		var ap_ = this.FIT_DNA();
		var aq_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ap_, null);
		var ar_ = (Observation FitDNA) =>
		{
			var a_ = (FitDNA?.Effective as object);
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.End(c_);
			var e_ = context?.Operators.Quantity(4m, "years");
			var f_ = context?.Operators.Subtract(d_, e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.End(g_);
			var i_ = context?.Operators.Interval(f_, h_, true, true);
			var j_ = context?.Operators.ElementInInterval<CqlDateTime>(b_, i_, null);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.End(k_);
			var m_ = (bool?)(l_ == null);
			var n_ = context?.Operators.Not(m_);

			return context?.Operators.And(j_, n_);
		};
		var as_ = context?.Operators.WhereOrNull<Observation>(aq_, ar_);
		var at_ = (Observation FitDNA) =>
		{
			var s_ = (FitDNA?.Effective as object);
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(s_);
			var u_ = (FitDNA?.Value as object);
			var v_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(u_, "coding");
			var w_ = (Coding @this) =>
			{
				var o_ = (bool?)(@this?.DisplayElement == null);

				return context?.Operators.Not(o_);
			};
			var x_ = context?.Operators.WhereOrNull<Coding>(v_, w_);
			var y_ = (Coding @this) => @this?.DisplayElement;
			var z_ = context?.Operators.SelectOrNull<Coding, FhirString>(x_, y_);
			var aa_ = (FitDNA?.Category as IEnumerable<CodeableConcept>);
			var ab_ = (CodeableConcept @this) =>
			{
				var p_ = (bool?)(@this?.Coding == null);

				return context?.Operators.Not(p_);
			};
			var ac_ = context?.Operators.WhereOrNull<CodeableConcept>(aa_, ab_);
			var ad_ = (CodeableConcept @this) => @this?.Coding;
			var ae_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(ac_, ad_);
			var af_ = context?.Operators.FlattenList<Coding>(ae_);
			var ag_ = (Coding @this) =>
			{
				var q_ = (bool?)(@this?.CodeElement == null);

				return context?.Operators.Not(q_);
			};
			var ah_ = context?.Operators.WhereOrNull<Coding>(af_, ag_);
			var ai_ = (Coding @this) => @this?.CodeElement;
			var aj_ = context?.Operators.SelectOrNull<Coding, Code>(ah_, ai_);
			var ak_ = (Code @this) =>
			{
				var r_ = (bool?)(@this?.Value == null);

				return context?.Operators.Not(r_);
			};
			var al_ = context?.Operators.WhereOrNull<Code>(aj_, ak_);
			var am_ = (Code @this) => @this?.Value;
			var an_ = context?.Operators.SelectOrNull<Code, string>(al_, am_);
			var ao_ = FitDNA?.StatusElement;

			return new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = t_,
				occultResult = z_,
				occultCategoryCode = an_,
				occultStatus = ao_,
			};
		};

		return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(as_, at_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status() => __Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_Value()
	{
		var at_ = this.FIT_DNA();
		var au_ = context?.DataRetriever.RetrieveByValueSet<Observation>(at_, null);
		var av_ = (Observation FitDNA) =>
		{
			var o_ = (FitDNA?.StatusElement as object);
			var p_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(o_);
			var q_ = "final";
			var r_ = "amended";
			var s_ = "corrected";
			var t_ = new string[]
			{
				q_,
				r_,
				s_,
			};
			var u_ = (t_ as IEnumerable<string>);
			var v_ = context?.Operators.InList<string>(p_, u_);
			var w_ = (FitDNA?.Category as IEnumerable<CodeableConcept>);
			var x_ = (CodeableConcept FitDNACategory) =>
			{
				var c_ = (FitDNACategory?.Coding as IEnumerable<Coding>);
				var d_ = (Coding @this) =>
				{
					var a_ = (bool?)(@this?.CodeElement == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Coding>(c_, d_);
				var f_ = (Coding @this) => @this?.CodeElement;
				var g_ = context?.Operators.SelectOrNull<Coding, Code>(e_, f_);
				var h_ = (Code @this) =>
				{
					var b_ = (bool?)(@this?.Value == null);

					return context?.Operators.Not(b_);
				};
				var i_ = context?.Operators.WhereOrNull<Code>(g_, h_);
				var j_ = (Code @this) => @this?.Value;
				var k_ = context?.Operators.SelectOrNull<Code, string>(i_, j_);
				var l_ = "laboratory";
				var m_ = new string[]
				{
					l_,
				};
				var n_ = (m_ as IEnumerable<string>);

				return context?.Operators.ListEquivalent<string>(k_, n_);
			};
			var y_ = context?.Operators.WhereOrNull<CodeableConcept>(w_, x_);
			var z_ = context?.Operators.ExistsInList<CodeableConcept>(y_);
			var aa_ = context?.Operators.And(v_, z_);
			var ab_ = (bool?)((FitDNA?.Value as object) == null);
			var ac_ = context?.Operators.Not(ab_);
			var ad_ = context?.Operators.And(aa_, ac_);
			var ae_ = (FitDNA?.Effective as object);
			var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context?.Operators.End(ag_);
			var ai_ = context?.Operators.Quantity(3m, "years");
			var aj_ = context?.Operators.Subtract(ah_, ai_);
			var ak_ = this.Measurement_Period();
			var al_ = context?.Operators.End(ak_);
			var am_ = context?.Operators.Interval(aj_, al_, true, true);
			var an_ = context?.Operators.ElementInInterval<CqlDateTime>(af_, am_, null);
			var ao_ = this.Measurement_Period();
			var ap_ = context?.Operators.End(ao_);
			var aq_ = (bool?)(ap_ == null);
			var ar_ = context?.Operators.Not(aq_);
			var as_ = context?.Operators.And(an_, ar_);

			return context?.Operators.And(ad_, as_);
		};

		return context?.Operators.WhereOrNull<Observation>(au_, av_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed() => __Fecal_Immunochemical_Test_DNA_Performed.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Value()
	{
		var at_ = this.FIT_DNA();
		var au_ = context?.DataRetriever.RetrieveByValueSet<Observation>(at_, null);
		var av_ = (Observation FitDNA) =>
		{
			var o_ = (FitDNA?.StatusElement as object);
			var p_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(o_);
			var q_ = "final";
			var r_ = "amended";
			var s_ = "corrected";
			var t_ = new string[]
			{
				q_,
				r_,
				s_,
			};
			var u_ = (t_ as IEnumerable<string>);
			var v_ = context?.Operators.InList<string>(p_, u_);
			var w_ = (FitDNA?.Category as IEnumerable<CodeableConcept>);
			var x_ = (CodeableConcept FitDNACategory) =>
			{
				var c_ = (FitDNACategory?.Coding as IEnumerable<Coding>);
				var d_ = (Coding @this) =>
				{
					var a_ = (bool?)(@this?.CodeElement == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Coding>(c_, d_);
				var f_ = (Coding @this) => @this?.CodeElement;
				var g_ = context?.Operators.SelectOrNull<Coding, Code>(e_, f_);
				var h_ = (Code @this) =>
				{
					var b_ = (bool?)(@this?.Value == null);

					return context?.Operators.Not(b_);
				};
				var i_ = context?.Operators.WhereOrNull<Code>(g_, h_);
				var j_ = (Code @this) => @this?.Value;
				var k_ = context?.Operators.SelectOrNull<Code, string>(i_, j_);
				var l_ = "laboratory";
				var m_ = new string[]
				{
					l_,
				};
				var n_ = (m_ as IEnumerable<string>);

				return context?.Operators.ListEquivalent<string>(k_, n_);
			};
			var y_ = context?.Operators.WhereOrNull<CodeableConcept>(w_, x_);
			var z_ = context?.Operators.ExistsInList<CodeableConcept>(y_);
			var aa_ = context?.Operators.And(v_, z_);
			var ab_ = (bool?)((FitDNA?.Value as object) == null);
			var ac_ = context?.Operators.Not(ab_);
			var ad_ = context?.Operators.And(aa_, ac_);
			var ae_ = (FitDNA?.Effective as object);
			var af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ae_);
			var ag_ = this.Measurement_Period();
			var ah_ = context?.Operators.End(ag_);
			var ai_ = context?.Operators.Quantity(3m, "years");
			var aj_ = context?.Operators.Subtract(ah_, ai_);
			var ak_ = this.Measurement_Period();
			var al_ = context?.Operators.End(ak_);
			var am_ = context?.Operators.Interval(aj_, al_, true, true);
			var an_ = context?.Operators.ElementInInterval<CqlDateTime>(af_, am_, "day");
			var ao_ = this.Measurement_Period();
			var ap_ = context?.Operators.End(ao_);
			var aq_ = (bool?)(ap_ == null);
			var ar_ = context?.Operators.Not(aq_);
			var as_ = context?.Operators.And(an_, ar_);

			return context?.Operators.And(ad_, as_);
		};

		return context?.Operators.WhereOrNull<Observation>(au_, av_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var al_ = this.FIT_DNA();
		var am_ = context?.DataRetriever.RetrieveByValueSet<Observation>(al_, null);
		var an_ = (Observation FitDNA) =>
		{
			var p_ = (FitDNA?.Category as IEnumerable<CodeableConcept>);
			var q_ = (CodeableConcept FitDNACategory) =>
			{
				var c_ = (FitDNACategory?.Coding as IEnumerable<Coding>);
				var d_ = (Coding @this) =>
				{
					var a_ = (bool?)(@this?.CodeElement == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Coding>(c_, d_);
				var f_ = (Coding @this) => @this?.CodeElement;
				var g_ = context?.Operators.SelectOrNull<Coding, Code>(e_, f_);
				var h_ = (Code @this) =>
				{
					var b_ = (bool?)(@this?.Value == null);

					return context?.Operators.Not(b_);
				};
				var i_ = context?.Operators.WhereOrNull<Code>(g_, h_);
				var j_ = (Code @this) => @this?.Value;
				var k_ = context?.Operators.SelectOrNull<Code, string>(i_, j_);
				var l_ = "laboratory";
				var m_ = new string[]
				{
					l_,
				};
				var n_ = (m_ as IEnumerable<string>);
				var o_ = context?.Operators.ListEquivalent<string>(k_, n_);

				return context?.Operators.Not(o_);
			};
			var r_ = context?.Operators.WhereOrNull<CodeableConcept>(p_, q_);
			var s_ = context?.Operators.ExistsInList<CodeableConcept>(r_);
			var t_ = (bool?)((FitDNA?.Value as object) == null);
			var u_ = context?.Operators.Not(t_);
			var v_ = context?.Operators.And(s_, u_);
			var w_ = (FitDNA?.Effective as object);
			var x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(w_);
			var y_ = this.Measurement_Period();
			var z_ = context?.Operators.End(y_);
			var aa_ = context?.Operators.Quantity(3m, "years");
			var ab_ = context?.Operators.Subtract(z_, aa_);
			var ac_ = this.Measurement_Period();
			var ad_ = context?.Operators.End(ac_);
			var ae_ = context?.Operators.Interval(ab_, ad_, true, true);
			var af_ = context?.Operators.ElementInInterval<CqlDateTime>(x_, ae_, "day");
			var ag_ = this.Measurement_Period();
			var ah_ = context?.Operators.End(ag_);
			var ai_ = (bool?)(ah_ == null);
			var aj_ = context?.Operators.Not(ai_);
			var ak_ = context?.Operators.And(af_, aj_);

			return context?.Operators.And(v_, ak_);
		};

		return context?.Operators.WhereOrNull<Observation>(am_, an_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var ab_ = this.FIT_DNA();
		var ac_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ab_, null);
		var ad_ = (Observation FitDNA) =>
		{
			var a_ = (FitDNA?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = context?.Operators.Not(h_);
			var j_ = (bool?)((FitDNA?.Value as object) == null);
			var k_ = context?.Operators.Not(j_);
			var l_ = context?.Operators.And(i_, k_);
			var m_ = (FitDNA?.Effective as object);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = context?.Operators.Quantity(3m, "years");
			var r_ = context?.Operators.Subtract(p_, q_);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.End(s_);
			var u_ = context?.Operators.Interval(r_, t_, true, true);
			var v_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, u_, "day");
			var w_ = this.Measurement_Period();
			var x_ = context?.Operators.End(w_);
			var y_ = (bool?)(x_ == null);
			var z_ = context?.Operators.Not(y_);
			var aa_ = context?.Operators.And(v_, z_);

			return context?.Operators.And(l_, aa_);
		};

		return context?.Operators.WhereOrNull<Observation>(ac_, ad_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

    private IEnumerable<CqlDateTime> CT_Colonography_Display_Date_Value()
	{
		var q_ = this.CT_Colonography();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Observation>(q_, null);
		var s_ = (Observation Colonography) =>
		{
			var a_ = (Colonography?.Effective as object);
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);
			var c_ = context?.Operators.End(b_);
			var d_ = this.Measurement_Period();
			var e_ = context?.Operators.End(d_);
			var f_ = context?.Operators.Quantity(6m, "years");
			var g_ = context?.Operators.Subtract(e_, f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.Interval(g_, i_, true, true);
			var k_ = context?.Operators.ElementInInterval<CqlDateTime>(c_, j_, null);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = (bool?)(m_ == null);
			var o_ = context?.Operators.Not(n_);

			return context?.Operators.And(k_, o_);
		};
		var t_ = context?.Operators.WhereOrNull<Observation>(r_, s_);
		var u_ = (Observation Colonography) =>
		{
			var p_ = (Colonography?.Effective as object);

			return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(p_);
		};

		return context?.Operators.SelectOrNull<Observation, CqlDateTime>(t_, u_);
	}

    [CqlDeclaration("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date() => __CT_Colonography_Display_Date.Value;

    private IEnumerable<Observation> CT_Colonography_Performed_Value()
	{
		var z_ = this.CT_Colonography();
		var aa_ = context?.DataRetriever.RetrieveByValueSet<Observation>(z_, null);
		var ab_ = (Observation Colonography) =>
		{
			var a_ = (Colonography?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = "appended";
			var g_ = new string[]
			{
				c_,
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(b_, h_);
			var j_ = (Colonography?.Effective as object);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = context?.Operators.End(k_);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = context?.Operators.Quantity(5m, "years");
			var p_ = context?.Operators.Subtract(n_, o_);
			var q_ = this.Measurement_Period();
			var r_ = context?.Operators.End(q_);
			var s_ = context?.Operators.Interval(p_, r_, true, true);
			var t_ = context?.Operators.ElementInInterval<CqlDateTime>(l_, s_, null);
			var u_ = this.Measurement_Period();
			var v_ = context?.Operators.End(u_);
			var w_ = (bool?)(v_ == null);
			var x_ = context?.Operators.Not(w_);
			var y_ = context?.Operators.And(t_, x_);

			return context?.Operators.And(i_, y_);
		};

		return context?.Operators.WhereOrNull<Observation>(aa_, ab_);
	}

    [CqlDeclaration("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed() => __CT_Colonography_Performed.Value;

    private IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status_Value()
	{
		var aa_ = this.CT_Colonography();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aa_, null);
		var ac_ = (Observation Colonography) =>
		{
			var a_ = (Colonography?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = "appended";
			var g_ = new string[]
			{
				c_,
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(b_, h_);
			var j_ = context?.Operators.Not(i_);
			var k_ = (Colonography?.Effective as object);
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(k_);
			var m_ = context?.Operators.End(l_);
			var n_ = this.Measurement_Period();
			var o_ = context?.Operators.End(n_);
			var p_ = context?.Operators.Quantity(5m, "years");
			var q_ = context?.Operators.Subtract(o_, p_);
			var r_ = this.Measurement_Period();
			var s_ = context?.Operators.End(r_);
			var t_ = context?.Operators.Interval(q_, s_, true, true);
			var u_ = context?.Operators.ElementInInterval<CqlDateTime>(m_, t_, null);
			var v_ = this.Measurement_Period();
			var w_ = context?.Operators.End(v_);
			var x_ = (bool?)(w_ == null);
			var y_ = context?.Operators.Not(x_);
			var z_ = context?.Operators.And(u_, y_);

			return context?.Operators.And(j_, z_);
		};

		return context?.Operators.WhereOrNull<Observation>(ab_, ac_);
	}

    [CqlDeclaration("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status() => __CT_Colonography_Performed_without_appropriate_status.Value;

    private IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date_Value()
	{
		var q_ = this.Flexible_Sigmoidoscopy();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(q_, null);
		var s_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var a_ = (FlexibleSigmoidoscopy?.Performed as object);
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);
			var c_ = context?.Operators.End(b_);
			var d_ = this.Measurement_Period();
			var e_ = context?.Operators.End(d_);
			var f_ = context?.Operators.Quantity(6m, "years");
			var g_ = context?.Operators.Subtract(e_, f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.Interval(g_, i_, true, true);
			var k_ = context?.Operators.ElementInInterval<CqlDateTime>(c_, j_, null);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = (bool?)(m_ == null);
			var o_ = context?.Operators.Not(n_);

			return context?.Operators.And(k_, o_);
		};
		var t_ = context?.Operators.WhereOrNull<Procedure>(r_, s_);
		var u_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var p_ = (FlexibleSigmoidoscopy?.Performed as object);

			return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(p_);
		};

		return context?.Operators.SelectOrNull<Procedure, CqlDateTime>(t_, u_);
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date() => __Flexible_Sigmoidoscopy_Display_Date.Value;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Value()
	{
		var u_ = this.Flexible_Sigmoidoscopy();
		var v_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(u_, null);
		var w_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var a_ = (FlexibleSigmoidoscopy?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = (FlexibleSigmoidoscopy?.Performed as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.Quantity(5m, "years");
			var k_ = context?.Operators.Subtract(i_, j_);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = context?.Operators.Interval(k_, m_, true, true);
			var o_ = context?.Operators.ElementInInterval<CqlDateTime>(g_, n_, null);
			var p_ = this.Measurement_Period();
			var q_ = context?.Operators.End(p_);
			var r_ = (bool?)(q_ == null);
			var s_ = context?.Operators.Not(r_);
			var t_ = context?.Operators.And(o_, s_);

			return context?.Operators.And(d_, t_);
		};

		return context?.Operators.WhereOrNull<Procedure>(v_, w_);
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed() => __Flexible_Sigmoidoscopy_Performed.Value;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Value()
	{
		var v_ = this.Flexible_Sigmoidoscopy();
		var w_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(v_, null);
		var x_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var a_ = (FlexibleSigmoidoscopy?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = context?.Operators.Not(d_);
			var f_ = (FlexibleSigmoidoscopy?.Performed as object);
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
			var h_ = context?.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.End(i_);
			var k_ = context?.Operators.Quantity(5m, "years");
			var l_ = context?.Operators.Subtract(j_, k_);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = context?.Operators.Interval(l_, n_, true, true);
			var p_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
			var q_ = this.Measurement_Period();
			var r_ = context?.Operators.End(q_);
			var s_ = (bool?)(r_ == null);
			var t_ = context?.Operators.Not(s_);
			var u_ = context?.Operators.And(p_, t_);

			return context?.Operators.And(e_, u_);
		};

		return context?.Operators.WhereOrNull<Procedure>(w_, x_);
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status() => __Flexible_Sigmoidoscopy_Performed_without_appropriate_status.Value;

    private IEnumerable<CqlDateTime> Colonoscopy_Display_Date_Value()
	{
		var q_ = this.Colonoscopy();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(q_, null);
		var s_ = (Procedure Colonoscopy) =>
		{
			var a_ = (Colonoscopy?.Performed as object);
			var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(a_);
			var c_ = context?.Operators.End(b_);
			var d_ = this.Measurement_Period();
			var e_ = context?.Operators.End(d_);
			var f_ = context?.Operators.Quantity(11m, "years");
			var g_ = context?.Operators.Subtract(e_, f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.Interval(g_, i_, true, true);
			var k_ = context?.Operators.ElementInInterval<CqlDateTime>(c_, j_, null);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = (bool?)(m_ == null);
			var o_ = context?.Operators.Not(n_);

			return context?.Operators.And(k_, o_);
		};
		var t_ = context?.Operators.WhereOrNull<Procedure>(r_, s_);
		var u_ = (Procedure Colonoscopy) =>
		{
			var p_ = (Colonoscopy?.Performed as object);

			return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(p_);
		};

		return context?.Operators.SelectOrNull<Procedure, CqlDateTime>(t_, u_);
	}

    [CqlDeclaration("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date() => __Colonoscopy_Display_Date.Value;

    private IEnumerable<Procedure> Colonoscopy_Performed_Value()
	{
		var u_ = this.Colonoscopy();
		var v_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(u_, null);
		var w_ = (Procedure Colonoscopy) =>
		{
			var a_ = (Colonoscopy?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = (Colonoscopy?.Performed as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.Quantity(10m, "years");
			var k_ = context?.Operators.Subtract(i_, j_);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = context?.Operators.Interval(k_, m_, true, true);
			var o_ = context?.Operators.ElementInInterval<CqlDateTime>(g_, n_, null);
			var p_ = this.Measurement_Period();
			var q_ = context?.Operators.End(p_);
			var r_ = (bool?)(q_ == null);
			var s_ = context?.Operators.Not(r_);
			var t_ = context?.Operators.And(o_, s_);

			return context?.Operators.And(d_, t_);
		};

		return context?.Operators.WhereOrNull<Procedure>(v_, w_);
	}

    [CqlDeclaration("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed() => __Colonoscopy_Performed.Value;

    private IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status_Value()
	{
		var v_ = this.Colonoscopy();
		var w_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(v_, null);
		var x_ = (Procedure Colonoscopy) =>
		{
			var a_ = (Colonoscopy?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = context?.Operators.Not(d_);
			var f_ = (Colonoscopy?.Performed as object);
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
			var h_ = context?.Operators.End(g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.End(i_);
			var k_ = context?.Operators.Quantity(10m, "years");
			var l_ = context?.Operators.Subtract(j_, k_);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = context?.Operators.Interval(l_, n_, true, true);
			var p_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, o_, null);
			var q_ = this.Measurement_Period();
			var r_ = context?.Operators.End(q_);
			var s_ = (bool?)(r_ == null);
			var t_ = context?.Operators.Not(s_);
			var u_ = context?.Operators.And(p_, t_);

			return context?.Operators.And(e_, u_);
		};

		return context?.Operators.WhereOrNull<Procedure>(w_, x_);
	}

    [CqlDeclaration("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status() => __Colonoscopy_Performed_without_appropriate_status.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Colonoscopy_Performed();
		var b_ = context?.Operators.ExistsInList<Procedure>(a_);
		var c_ = this.Fecal_Occult_Blood_Test_Performed();
		var d_ = context?.Operators.ExistsInList<Observation>(c_);
		var e_ = context?.Operators.Or(b_, d_);
		var f_ = this.Flexible_Sigmoidoscopy_Performed();
		var g_ = context?.Operators.ExistsInList<Procedure>(f_);
		var h_ = context?.Operators.Or(e_, g_);
		var i_ = this.Fecal_Immunochemical_Test_DNA_Performed();
		var j_ = context?.Operators.ExistsInList<Observation>(i_);
		var k_ = context?.Operators.Or(h_, j_);
		var l_ = this.CT_Colonography_Performed();
		var m_ = context?.Operators.ExistsInList<Observation>(l_);

		return context?.Operators.Or(k_, m_);
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    private bool? Final_Numerator_Population_Value()
	{
		var a_ = this.Numerator();
		var b_ = this.Initial_Population();
		var c_ = context?.Operators.And(a_, b_);
		var d_ = this.Denominator();
		var e_ = context?.Operators.And(c_, d_);
		var f_ = this.Denominator_Exclusions();
		var g_ = context?.Operators.Not(f_);

		return context?.Operators.And(e_, g_);
	}

    [CqlDeclaration("Final Numerator Population")]
    public bool? Final_Numerator_Population() => __Final_Numerator_Population.Value;

}