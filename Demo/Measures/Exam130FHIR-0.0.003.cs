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
		var k_ = this.Online_Assessments();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, null);
		var m_ = this.Telephone_Visits();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(m_, null);
		var o_ = context?.Operators.ListUnion<Encounter>(l_, n_);
		var p_ = (Encounter TelehealthEncounter) =>
		{
			var a_ = TelehealthEncounter?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("finished" as object));
			var f_ = this.Measurement_Period();
			var g_ = TelehealthEncounter?.Period;
			var h_ = (g_ as object);
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			var j_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, null);

			return context?.Operators.And(e_, j_);
		};

		return context?.Operators.WhereOrNull<Encounter>(o_, p_);
	}

    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services() => __Telehealth_Services.Value;

    private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = (c_ as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);

		return context?.Operators.CalculateAgeAt(e_, h_, "year");
	}

    [CqlDeclaration("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period() => __Age_at_start_of_Measurement_Period.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = (c_ as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);
		var i_ = context?.Operators.CalculateAgeAt(e_, h_, "year");
		var j_ = context?.Operators.Interval((int?)51, (int?)75, true, false);
		var k_ = context?.Operators.ElementInInterval<int?>(i_, j_, null);
		var l_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var m_ = this.Telehealth_Services();
		var n_ = context?.Operators.ListUnion<Encounter>(l_, m_);
		var o_ = context?.Operators.ExistsInList<Encounter>(n_);

		return context?.Operators.And(k_, o_);
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
		var m_ = this.Total_Colectomy();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(m_, null);
		var o_ = (Procedure Colectomy) =>
		{
			var a_ = Colectomy?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = Colectomy?.Performed;
			var g_ = (f_ as object);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.SameOrBefore(i_, k_, null);

			return context?.Operators.And(e_, l_);
		};

		return context?.Operators.WhereOrNull<Procedure>(n_, o_);
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
		var m_ = this.Patient();
		var n_ = m_?.BirthDateElement;
		var o_ = n_?.Value;
		var p_ = (o_ as object);
		var q_ = context?.Operators?.TypeConverter.Convert<CqlDate>(p_);
		var r_ = this.Measurement_Period();
		var s_ = context?.Operators.Start(r_);
		var t_ = context?.Operators.DateFrom(s_);
		var u_ = context?.Operators.CalculateAgeAt(q_, t_, "year");
		var v_ = u_;
		var w_ = (int?)65;
		var x_ = w_;
		var y_ = context?.Operators.GreaterOrEqual(v_, x_);
		var z_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var aa_ = context?.Operators.And(y_, z_);
		var ab_ = context?.Operators.Or(l_, aa_);
		var ac_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();

		return context?.Operators.Or(ab_, ac_);
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value()
	{
		var aw_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var ax_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aw_, null);
		var ay_ = (Observation FecalOccult) =>
		{
			var a_ = FecalOccult?.Effective;
			var b_ = (a_ as object);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(b_);
			var d_ = this.Measurement_Period();
			var e_ = context?.Operators.Start(d_);
			var f_ = context?.Operators.Quantity(1m, "year");
			var g_ = context?.Operators.Subtract(e_, f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.Interval(g_, i_, false, false);

			return context?.Operators.ElementInInterval<CqlDateTime>(c_, j_, null);
		};
		var az_ = context?.Operators.WhereOrNull<Observation>(ax_, ay_);
		var ba_ = (Observation FecalOccult) =>
		{
			var w_ = FecalOccult?.Effective;
			var x_ = (w_ as object);
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(x_);
			var z_ = FecalOccult?.Value;
			var aa_ = (z_ as object);
			var ab_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(aa_, "coding");
			var ac_ = (Coding @this) =>
			{
				var k_ = @this?.DisplayElement;
				var l_ = (k_ == null);
				var m_ = (bool?)l_;

				return context?.Operators.Not(m_);
			};
			var ad_ = context?.Operators.WhereOrNull<Coding>(ab_, ac_);
			var ae_ = (Coding @this) => @this?.DisplayElement;
			var af_ = context?.Operators.SelectOrNull<Coding, FhirString>(ad_, ae_);
			var ag_ = FecalOccult?.Category;
			var ah_ = (ag_ as IEnumerable<CodeableConcept>);
			var ai_ = (CodeableConcept @this) =>
			{
				var n_ = @this?.Coding;
				var o_ = (n_ == null);
				var p_ = (bool?)o_;

				return context?.Operators.Not(p_);
			};
			var aj_ = context?.Operators.WhereOrNull<CodeableConcept>(ah_, ai_);
			var ak_ = (CodeableConcept @this) => @this?.Coding;
			var al_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(aj_, ak_);
			var am_ = context?.Operators.FlattenList<Coding>(al_);
			var an_ = (Coding @this) =>
			{
				var q_ = @this?.CodeElement;
				var r_ = (q_ == null);
				var s_ = (bool?)r_;

				return context?.Operators.Not(s_);
			};
			var ao_ = context?.Operators.WhereOrNull<Coding>(am_, an_);
			var ap_ = (Coding @this) => @this?.CodeElement;
			var aq_ = context?.Operators.SelectOrNull<Coding, Code>(ao_, ap_);
			var ar_ = (Code @this) =>
			{
				var t_ = @this?.Value;
				var u_ = (t_ == null);
				var v_ = (bool?)u_;

				return context?.Operators.Not(v_);
			};
			var as_ = context?.Operators.WhereOrNull<Code>(aq_, ar_);
			var at_ = (Code @this) => @this?.Value;
			var au_ = context?.Operators.SelectOrNull<Code, string>(as_, at_);
			var av_ = FecalOccult?.StatusElement;

			return new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = y_,
				occultResult = af_,
				occultCategoryCode = au_,
				occultStatus = av_,
			};
		};

		return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(az_, ba_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status() => __Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Value()
	{
		var at_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var au_ = context?.DataRetriever.RetrieveByValueSet<Observation>(at_, null);
		var av_ = (Observation FecalOccult) =>
		{
			var t_ = FecalOccult?.StatusElement;
			var u_ = (t_ as object);
			var v_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(u_);
			var w_ = "final";
			var x_ = "amended";
			var y_ = "corrected";
			var z_ = new string[]
			{
				w_,
				x_,
				y_,
			};
			var aa_ = (z_ as IEnumerable<string>);
			var ab_ = context?.Operators.InList<string>(v_, aa_);
			var ac_ = FecalOccult?.Category;
			var ad_ = (ac_ as IEnumerable<CodeableConcept>);
			var ae_ = (CodeableConcept FecalOccultCategory) =>
			{
				var g_ = FecalOccultCategory?.Coding;
				var h_ = (g_ as IEnumerable<Coding>);
				var i_ = (Coding @this) =>
				{
					var a_ = @this?.CodeElement;
					var b_ = (a_ == null);
					var c_ = (bool?)b_;

					return context?.Operators.Not(c_);
				};
				var j_ = context?.Operators.WhereOrNull<Coding>(h_, i_);
				var k_ = (Coding @this) => @this?.CodeElement;
				var l_ = context?.Operators.SelectOrNull<Coding, Code>(j_, k_);
				var m_ = (Code @this) =>
				{
					var d_ = @this?.Value;
					var e_ = (d_ == null);
					var f_ = (bool?)e_;

					return context?.Operators.Not(f_);
				};
				var n_ = context?.Operators.WhereOrNull<Code>(l_, m_);
				var o_ = (Code @this) => @this?.Value;
				var p_ = context?.Operators.SelectOrNull<Code, string>(n_, o_);
				var q_ = "laboratory";
				var r_ = new string[]
				{
					q_,
				};
				var s_ = (r_ as IEnumerable<string>);

				return context?.Operators.ListEquivalent<string>(p_, s_);
			};
			var af_ = context?.Operators.WhereOrNull<CodeableConcept>(ad_, ae_);
			var ag_ = context?.Operators.ExistsInList<CodeableConcept>(af_);
			var ah_ = context?.Operators.And(ab_, ag_);
			var ai_ = FecalOccult?.Value;
			var aj_ = (ai_ as object);
			var ak_ = (aj_ == null);
			var al_ = (bool?)ak_;
			var am_ = context?.Operators.Not(al_);
			var an_ = context?.Operators.And(ah_, am_);
			var ao_ = FecalOccult?.Effective;
			var ap_ = (ao_ as object);
			var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ap_);
			var ar_ = this.Measurement_Period();
			var as_ = context?.Operators.ElementInInterval<CqlDateTime>(aq_, ar_, null);

			return context?.Operators.And(an_, as_);
		};

		return context?.Operators.WhereOrNull<Observation>(au_, av_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed() => __Fecal_Occult_Blood_Test_Performed.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Value()
	{
		var at_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var au_ = context?.DataRetriever.RetrieveByValueSet<Observation>(at_, null);
		var av_ = (Observation FecalOccult) =>
		{
			var t_ = FecalOccult?.StatusElement;
			var u_ = (t_ as object);
			var v_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(u_);
			var w_ = "final";
			var x_ = "amended";
			var y_ = "corrected";
			var z_ = new string[]
			{
				w_,
				x_,
				y_,
			};
			var aa_ = (z_ as IEnumerable<string>);
			var ab_ = context?.Operators.InList<string>(v_, aa_);
			var ac_ = FecalOccult?.Category;
			var ad_ = (ac_ as IEnumerable<CodeableConcept>);
			var ae_ = (CodeableConcept FecalOccultCategory) =>
			{
				var g_ = FecalOccultCategory?.Coding;
				var h_ = (g_ as IEnumerable<Coding>);
				var i_ = (Coding @this) =>
				{
					var a_ = @this?.CodeElement;
					var b_ = (a_ == null);
					var c_ = (bool?)b_;

					return context?.Operators.Not(c_);
				};
				var j_ = context?.Operators.WhereOrNull<Coding>(h_, i_);
				var k_ = (Coding @this) => @this?.CodeElement;
				var l_ = context?.Operators.SelectOrNull<Coding, Code>(j_, k_);
				var m_ = (Code @this) =>
				{
					var d_ = @this?.Value;
					var e_ = (d_ == null);
					var f_ = (bool?)e_;

					return context?.Operators.Not(f_);
				};
				var n_ = context?.Operators.WhereOrNull<Code>(l_, m_);
				var o_ = (Code @this) => @this?.Value;
				var p_ = context?.Operators.SelectOrNull<Code, string>(n_, o_);
				var q_ = "laboratory";
				var r_ = new string[]
				{
					q_,
				};
				var s_ = (r_ as IEnumerable<string>);

				return context?.Operators.ListEquivalent<string>(p_, s_);
			};
			var af_ = context?.Operators.WhereOrNull<CodeableConcept>(ad_, ae_);
			var ag_ = context?.Operators.ExistsInList<CodeableConcept>(af_);
			var ah_ = context?.Operators.And(ab_, ag_);
			var ai_ = FecalOccult?.Value;
			var aj_ = (ai_ as object);
			var ak_ = (aj_ == null);
			var al_ = (bool?)ak_;
			var am_ = context?.Operators.Not(al_);
			var an_ = context?.Operators.And(ah_, am_);
			var ao_ = FecalOccult?.Effective;
			var ap_ = (ao_ as object);
			var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ap_);
			var ar_ = this.Measurement_Period();
			var as_ = context?.Operators.ElementInInterval<CqlDateTime>(aq_, ar_, "day");

			return context?.Operators.And(an_, as_);
		};

		return context?.Operators.WhereOrNull<Observation>(au_, av_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var ak_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var al_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ak_, null);
		var am_ = (Observation FecalOccult) =>
		{
			var u_ = FecalOccult?.Category;
			var v_ = (u_ as IEnumerable<CodeableConcept>);
			var w_ = (CodeableConcept FecalOccultCategory) =>
			{
				var g_ = FecalOccultCategory?.Coding;
				var h_ = (g_ as IEnumerable<Coding>);
				var i_ = (Coding @this) =>
				{
					var a_ = @this?.CodeElement;
					var b_ = (a_ == null);
					var c_ = (bool?)b_;

					return context?.Operators.Not(c_);
				};
				var j_ = context?.Operators.WhereOrNull<Coding>(h_, i_);
				var k_ = (Coding @this) => @this?.CodeElement;
				var l_ = context?.Operators.SelectOrNull<Coding, Code>(j_, k_);
				var m_ = (Code @this) =>
				{
					var d_ = @this?.Value;
					var e_ = (d_ == null);
					var f_ = (bool?)e_;

					return context?.Operators.Not(f_);
				};
				var n_ = context?.Operators.WhereOrNull<Code>(l_, m_);
				var o_ = (Code @this) => @this?.Value;
				var p_ = context?.Operators.SelectOrNull<Code, string>(n_, o_);
				var q_ = "laboratory";
				var r_ = new string[]
				{
					q_,
				};
				var s_ = (r_ as IEnumerable<string>);
				var t_ = context?.Operators.ListEquivalent<string>(p_, s_);

				return context?.Operators.Not(t_);
			};
			var x_ = context?.Operators.WhereOrNull<CodeableConcept>(v_, w_);
			var y_ = context?.Operators.ExistsInList<CodeableConcept>(x_);
			var z_ = FecalOccult?.Value;
			var aa_ = (z_ as object);
			var ab_ = (aa_ == null);
			var ac_ = (bool?)ab_;
			var ad_ = context?.Operators.Not(ac_);
			var ae_ = context?.Operators.And(y_, ad_);
			var af_ = FecalOccult?.Effective;
			var ag_ = (af_ as object);
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ag_);
			var ai_ = this.Measurement_Period();
			var aj_ = context?.Operators.ElementInInterval<CqlDateTime>(ah_, ai_, "day");

			return context?.Operators.And(ae_, aj_);
		};

		return context?.Operators.WhereOrNull<Observation>(al_, am_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var v_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var w_ = context?.DataRetriever.RetrieveByValueSet<Observation>(v_, null);
		var x_ = (Observation FecalOccult) =>
		{
			var a_ = FecalOccult?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = new string[]
			{
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(c_, h_);
			var j_ = context?.Operators.Not(i_);
			var k_ = FecalOccult?.Value;
			var l_ = (k_ as object);
			var m_ = (l_ == null);
			var n_ = (bool?)m_;
			var o_ = context?.Operators.Not(n_);
			var p_ = context?.Operators.And(j_, o_);
			var q_ = FecalOccult?.Effective;
			var r_ = (q_ as object);
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(r_);
			var t_ = this.Measurement_Period();
			var u_ = context?.Operators.ElementInInterval<CqlDateTime>(s_, t_, "day");

			return context?.Operators.And(p_, u_);
		};

		return context?.Operators.WhereOrNull<Observation>(w_, x_);
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Value()
	{
		var bc_ = this.FIT_DNA();
		var bd_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bc_, null);
		var be_ = (Observation FitDNA) =>
		{
			var a_ = FitDNA?.Effective;
			var b_ = (a_ as object);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(b_);
			var d_ = this.Measurement_Period();
			var e_ = context?.Operators.End(d_);
			var f_ = context?.Operators.Quantity(4m, "years");
			var g_ = context?.Operators.Subtract(e_, f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.Interval(g_, i_, true, true);
			var k_ = context?.Operators.ElementInInterval<CqlDateTime>(c_, j_, null);
			var l_ = this.Measurement_Period();
			var m_ = context?.Operators.End(l_);
			var n_ = (m_ == null);
			var o_ = (bool?)n_;
			var p_ = context?.Operators.Not(o_);

			return context?.Operators.And(k_, p_);
		};
		var bf_ = context?.Operators.WhereOrNull<Observation>(bd_, be_);
		var bg_ = (Observation FitDNA) =>
		{
			var ac_ = FitDNA?.Effective;
			var ad_ = (ac_ as object);
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ad_);
			var af_ = FitDNA?.Value;
			var ag_ = (af_ as object);
			var ah_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(ag_, "coding");
			var ai_ = (Coding @this) =>
			{
				var q_ = @this?.DisplayElement;
				var r_ = (q_ == null);
				var s_ = (bool?)r_;

				return context?.Operators.Not(s_);
			};
			var aj_ = context?.Operators.WhereOrNull<Coding>(ah_, ai_);
			var ak_ = (Coding @this) => @this?.DisplayElement;
			var al_ = context?.Operators.SelectOrNull<Coding, FhirString>(aj_, ak_);
			var am_ = FitDNA?.Category;
			var an_ = (am_ as IEnumerable<CodeableConcept>);
			var ao_ = (CodeableConcept @this) =>
			{
				var t_ = @this?.Coding;
				var u_ = (t_ == null);
				var v_ = (bool?)u_;

				return context?.Operators.Not(v_);
			};
			var ap_ = context?.Operators.WhereOrNull<CodeableConcept>(an_, ao_);
			var aq_ = (CodeableConcept @this) => @this?.Coding;
			var ar_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(ap_, aq_);
			var as_ = context?.Operators.FlattenList<Coding>(ar_);
			var at_ = (Coding @this) =>
			{
				var w_ = @this?.CodeElement;
				var x_ = (w_ == null);
				var y_ = (bool?)x_;

				return context?.Operators.Not(y_);
			};
			var au_ = context?.Operators.WhereOrNull<Coding>(as_, at_);
			var av_ = (Coding @this) => @this?.CodeElement;
			var aw_ = context?.Operators.SelectOrNull<Coding, Code>(au_, av_);
			var ax_ = (Code @this) =>
			{
				var z_ = @this?.Value;
				var aa_ = (z_ == null);
				var ab_ = (bool?)aa_;

				return context?.Operators.Not(ab_);
			};
			var ay_ = context?.Operators.WhereOrNull<Code>(aw_, ax_);
			var az_ = (Code @this) => @this?.Value;
			var ba_ = context?.Operators.SelectOrNull<Code, string>(ay_, az_);
			var bb_ = FitDNA?.StatusElement;

			return new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = ae_,
				occultResult = al_,
				occultCategoryCode = ba_,
				occultStatus = bb_,
			};
		};

		return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(bf_, bg_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status() => __Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_Value()
	{
		var bf_ = this.FIT_DNA();
		var bg_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bf_, null);
		var bh_ = (Observation FitDNA) =>
		{
			var t_ = FitDNA?.StatusElement;
			var u_ = (t_ as object);
			var v_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(u_);
			var w_ = "final";
			var x_ = "amended";
			var y_ = "corrected";
			var z_ = new string[]
			{
				w_,
				x_,
				y_,
			};
			var aa_ = (z_ as IEnumerable<string>);
			var ab_ = context?.Operators.InList<string>(v_, aa_);
			var ac_ = FitDNA?.Category;
			var ad_ = (ac_ as IEnumerable<CodeableConcept>);
			var ae_ = (CodeableConcept FitDNACategory) =>
			{
				var g_ = FitDNACategory?.Coding;
				var h_ = (g_ as IEnumerable<Coding>);
				var i_ = (Coding @this) =>
				{
					var a_ = @this?.CodeElement;
					var b_ = (a_ == null);
					var c_ = (bool?)b_;

					return context?.Operators.Not(c_);
				};
				var j_ = context?.Operators.WhereOrNull<Coding>(h_, i_);
				var k_ = (Coding @this) => @this?.CodeElement;
				var l_ = context?.Operators.SelectOrNull<Coding, Code>(j_, k_);
				var m_ = (Code @this) =>
				{
					var d_ = @this?.Value;
					var e_ = (d_ == null);
					var f_ = (bool?)e_;

					return context?.Operators.Not(f_);
				};
				var n_ = context?.Operators.WhereOrNull<Code>(l_, m_);
				var o_ = (Code @this) => @this?.Value;
				var p_ = context?.Operators.SelectOrNull<Code, string>(n_, o_);
				var q_ = "laboratory";
				var r_ = new string[]
				{
					q_,
				};
				var s_ = (r_ as IEnumerable<string>);

				return context?.Operators.ListEquivalent<string>(p_, s_);
			};
			var af_ = context?.Operators.WhereOrNull<CodeableConcept>(ad_, ae_);
			var ag_ = context?.Operators.ExistsInList<CodeableConcept>(af_);
			var ah_ = context?.Operators.And(ab_, ag_);
			var ai_ = FitDNA?.Value;
			var aj_ = (ai_ as object);
			var ak_ = (aj_ == null);
			var al_ = (bool?)ak_;
			var am_ = context?.Operators.Not(al_);
			var an_ = context?.Operators.And(ah_, am_);
			var ao_ = FitDNA?.Effective;
			var ap_ = (ao_ as object);
			var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ap_);
			var ar_ = this.Measurement_Period();
			var as_ = context?.Operators.End(ar_);
			var at_ = context?.Operators.Quantity(3m, "years");
			var au_ = context?.Operators.Subtract(as_, at_);
			var av_ = this.Measurement_Period();
			var aw_ = context?.Operators.End(av_);
			var ax_ = context?.Operators.Interval(au_, aw_, true, true);
			var ay_ = context?.Operators.ElementInInterval<CqlDateTime>(aq_, ax_, null);
			var az_ = this.Measurement_Period();
			var ba_ = context?.Operators.End(az_);
			var bb_ = (ba_ == null);
			var bc_ = (bool?)bb_;
			var bd_ = context?.Operators.Not(bc_);
			var be_ = context?.Operators.And(ay_, bd_);

			return context?.Operators.And(an_, be_);
		};

		return context?.Operators.WhereOrNull<Observation>(bg_, bh_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed() => __Fecal_Immunochemical_Test_DNA_Performed.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Value()
	{
		var bf_ = this.FIT_DNA();
		var bg_ = context?.DataRetriever.RetrieveByValueSet<Observation>(bf_, null);
		var bh_ = (Observation FitDNA) =>
		{
			var t_ = FitDNA?.StatusElement;
			var u_ = (t_ as object);
			var v_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(u_);
			var w_ = "final";
			var x_ = "amended";
			var y_ = "corrected";
			var z_ = new string[]
			{
				w_,
				x_,
				y_,
			};
			var aa_ = (z_ as IEnumerable<string>);
			var ab_ = context?.Operators.InList<string>(v_, aa_);
			var ac_ = FitDNA?.Category;
			var ad_ = (ac_ as IEnumerable<CodeableConcept>);
			var ae_ = (CodeableConcept FitDNACategory) =>
			{
				var g_ = FitDNACategory?.Coding;
				var h_ = (g_ as IEnumerable<Coding>);
				var i_ = (Coding @this) =>
				{
					var a_ = @this?.CodeElement;
					var b_ = (a_ == null);
					var c_ = (bool?)b_;

					return context?.Operators.Not(c_);
				};
				var j_ = context?.Operators.WhereOrNull<Coding>(h_, i_);
				var k_ = (Coding @this) => @this?.CodeElement;
				var l_ = context?.Operators.SelectOrNull<Coding, Code>(j_, k_);
				var m_ = (Code @this) =>
				{
					var d_ = @this?.Value;
					var e_ = (d_ == null);
					var f_ = (bool?)e_;

					return context?.Operators.Not(f_);
				};
				var n_ = context?.Operators.WhereOrNull<Code>(l_, m_);
				var o_ = (Code @this) => @this?.Value;
				var p_ = context?.Operators.SelectOrNull<Code, string>(n_, o_);
				var q_ = "laboratory";
				var r_ = new string[]
				{
					q_,
				};
				var s_ = (r_ as IEnumerable<string>);

				return context?.Operators.ListEquivalent<string>(p_, s_);
			};
			var af_ = context?.Operators.WhereOrNull<CodeableConcept>(ad_, ae_);
			var ag_ = context?.Operators.ExistsInList<CodeableConcept>(af_);
			var ah_ = context?.Operators.And(ab_, ag_);
			var ai_ = FitDNA?.Value;
			var aj_ = (ai_ as object);
			var ak_ = (aj_ == null);
			var al_ = (bool?)ak_;
			var am_ = context?.Operators.Not(al_);
			var an_ = context?.Operators.And(ah_, am_);
			var ao_ = FitDNA?.Effective;
			var ap_ = (ao_ as object);
			var aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ap_);
			var ar_ = this.Measurement_Period();
			var as_ = context?.Operators.End(ar_);
			var at_ = context?.Operators.Quantity(3m, "years");
			var au_ = context?.Operators.Subtract(as_, at_);
			var av_ = this.Measurement_Period();
			var aw_ = context?.Operators.End(av_);
			var ax_ = context?.Operators.Interval(au_, aw_, true, true);
			var ay_ = context?.Operators.ElementInInterval<CqlDateTime>(aq_, ax_, "day");
			var az_ = this.Measurement_Period();
			var ba_ = context?.Operators.End(az_);
			var bb_ = (ba_ == null);
			var bc_ = (bool?)bb_;
			var bd_ = context?.Operators.Not(bc_);
			var be_ = context?.Operators.And(ay_, bd_);

			return context?.Operators.And(an_, be_);
		};

		return context?.Operators.WhereOrNull<Observation>(bg_, bh_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var aw_ = this.FIT_DNA();
		var ax_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aw_, null);
		var ay_ = (Observation FitDNA) =>
		{
			var u_ = FitDNA?.Category;
			var v_ = (u_ as IEnumerable<CodeableConcept>);
			var w_ = (CodeableConcept FitDNACategory) =>
			{
				var g_ = FitDNACategory?.Coding;
				var h_ = (g_ as IEnumerable<Coding>);
				var i_ = (Coding @this) =>
				{
					var a_ = @this?.CodeElement;
					var b_ = (a_ == null);
					var c_ = (bool?)b_;

					return context?.Operators.Not(c_);
				};
				var j_ = context?.Operators.WhereOrNull<Coding>(h_, i_);
				var k_ = (Coding @this) => @this?.CodeElement;
				var l_ = context?.Operators.SelectOrNull<Coding, Code>(j_, k_);
				var m_ = (Code @this) =>
				{
					var d_ = @this?.Value;
					var e_ = (d_ == null);
					var f_ = (bool?)e_;

					return context?.Operators.Not(f_);
				};
				var n_ = context?.Operators.WhereOrNull<Code>(l_, m_);
				var o_ = (Code @this) => @this?.Value;
				var p_ = context?.Operators.SelectOrNull<Code, string>(n_, o_);
				var q_ = "laboratory";
				var r_ = new string[]
				{
					q_,
				};
				var s_ = (r_ as IEnumerable<string>);
				var t_ = context?.Operators.ListEquivalent<string>(p_, s_);

				return context?.Operators.Not(t_);
			};
			var x_ = context?.Operators.WhereOrNull<CodeableConcept>(v_, w_);
			var y_ = context?.Operators.ExistsInList<CodeableConcept>(x_);
			var z_ = FitDNA?.Value;
			var aa_ = (z_ as object);
			var ab_ = (aa_ == null);
			var ac_ = (bool?)ab_;
			var ad_ = context?.Operators.Not(ac_);
			var ae_ = context?.Operators.And(y_, ad_);
			var af_ = FitDNA?.Effective;
			var ag_ = (af_ as object);
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ag_);
			var ai_ = this.Measurement_Period();
			var aj_ = context?.Operators.End(ai_);
			var ak_ = context?.Operators.Quantity(3m, "years");
			var al_ = context?.Operators.Subtract(aj_, ak_);
			var am_ = this.Measurement_Period();
			var an_ = context?.Operators.End(am_);
			var ao_ = context?.Operators.Interval(al_, an_, true, true);
			var ap_ = context?.Operators.ElementInInterval<CqlDateTime>(ah_, ao_, "day");
			var aq_ = this.Measurement_Period();
			var ar_ = context?.Operators.End(aq_);
			var as_ = (ar_ == null);
			var at_ = (bool?)as_;
			var au_ = context?.Operators.Not(at_);
			var av_ = context?.Operators.And(ap_, au_);

			return context?.Operators.And(ae_, av_);
		};

		return context?.Operators.WhereOrNull<Observation>(ax_, ay_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var ah_ = this.FIT_DNA();
		var ai_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ah_, null);
		var aj_ = (Observation FitDNA) =>
		{
			var a_ = FitDNA?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = new string[]
			{
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(c_, h_);
			var j_ = context?.Operators.Not(i_);
			var k_ = FitDNA?.Value;
			var l_ = (k_ as object);
			var m_ = (l_ == null);
			var n_ = (bool?)m_;
			var o_ = context?.Operators.Not(n_);
			var p_ = context?.Operators.And(j_, o_);
			var q_ = FitDNA?.Effective;
			var r_ = (q_ as object);
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(r_);
			var t_ = this.Measurement_Period();
			var u_ = context?.Operators.End(t_);
			var v_ = context?.Operators.Quantity(3m, "years");
			var w_ = context?.Operators.Subtract(u_, v_);
			var x_ = this.Measurement_Period();
			var y_ = context?.Operators.End(x_);
			var z_ = context?.Operators.Interval(w_, y_, true, true);
			var aa_ = context?.Operators.ElementInInterval<CqlDateTime>(s_, z_, "day");
			var ab_ = this.Measurement_Period();
			var ac_ = context?.Operators.End(ab_);
			var ad_ = (ac_ == null);
			var ae_ = (bool?)ad_;
			var af_ = context?.Operators.Not(ae_);
			var ag_ = context?.Operators.And(aa_, af_);

			return context?.Operators.And(p_, ag_);
		};

		return context?.Operators.WhereOrNull<Observation>(ai_, aj_);
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

    private IEnumerable<CqlDateTime> CT_Colonography_Display_Date_Value()
	{
		var t_ = this.CT_Colonography();
		var u_ = context?.DataRetriever.RetrieveByValueSet<Observation>(t_, null);
		var v_ = (Observation Colonography) =>
		{
			var a_ = Colonography?.Effective;
			var b_ = (a_ as object);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(b_);
			var d_ = context?.Operators.End(c_);
			var e_ = this.Measurement_Period();
			var f_ = context?.Operators.End(e_);
			var g_ = context?.Operators.Quantity(6m, "years");
			var h_ = context?.Operators.Subtract(f_, g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.End(i_);
			var k_ = context?.Operators.Interval(h_, j_, true, true);
			var l_ = context?.Operators.ElementInInterval<CqlDateTime>(d_, k_, null);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = (n_ == null);
			var p_ = (bool?)o_;
			var q_ = context?.Operators.Not(p_);

			return context?.Operators.And(l_, q_);
		};
		var w_ = context?.Operators.WhereOrNull<Observation>(u_, v_);
		var x_ = (Observation Colonography) =>
		{
			var r_ = Colonography?.Effective;
			var s_ = (r_ as object);

			return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(s_);
		};

		return context?.Operators.SelectOrNull<Observation, CqlDateTime>(w_, x_);
	}

    [CqlDeclaration("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date() => __CT_Colonography_Display_Date.Value;

    private IEnumerable<Observation> CT_Colonography_Performed_Value()
	{
		var ac_ = this.CT_Colonography();
		var ad_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ac_, null);
		var ae_ = (Observation Colonography) =>
		{
			var a_ = Colonography?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = "appended";
			var h_ = new string[]
			{
				d_,
				e_,
				f_,
				g_,
			};
			var i_ = (h_ as IEnumerable<string>);
			var j_ = context?.Operators.InList<string>(c_, i_);
			var k_ = Colonography?.Effective;
			var l_ = (k_ as object);
			var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
			var n_ = context?.Operators.End(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = context?.Operators.Quantity(5m, "years");
			var r_ = context?.Operators.Subtract(p_, q_);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.End(s_);
			var u_ = context?.Operators.Interval(r_, t_, true, true);
			var v_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, u_, null);
			var w_ = this.Measurement_Period();
			var x_ = context?.Operators.End(w_);
			var y_ = (x_ == null);
			var z_ = (bool?)y_;
			var aa_ = context?.Operators.Not(z_);
			var ab_ = context?.Operators.And(v_, aa_);

			return context?.Operators.And(j_, ab_);
		};

		return context?.Operators.WhereOrNull<Observation>(ad_, ae_);
	}

    [CqlDeclaration("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed() => __CT_Colonography_Performed.Value;

    private IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status_Value()
	{
		var ad_ = this.CT_Colonography();
		var ae_ = context?.DataRetriever.RetrieveByValueSet<Observation>(ad_, null);
		var af_ = (Observation Colonography) =>
		{
			var a_ = Colonography?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "final";
			var e_ = "amended";
			var f_ = "corrected";
			var g_ = "appended";
			var h_ = new string[]
			{
				d_,
				e_,
				f_,
				g_,
			};
			var i_ = (h_ as IEnumerable<string>);
			var j_ = context?.Operators.InList<string>(c_, i_);
			var k_ = context?.Operators.Not(j_);
			var l_ = Colonography?.Effective;
			var m_ = (l_ as object);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
			var o_ = context?.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context?.Operators.End(p_);
			var r_ = context?.Operators.Quantity(5m, "years");
			var s_ = context?.Operators.Subtract(q_, r_);
			var t_ = this.Measurement_Period();
			var u_ = context?.Operators.End(t_);
			var v_ = context?.Operators.Interval(s_, u_, true, true);
			var w_ = context?.Operators.ElementInInterval<CqlDateTime>(o_, v_, null);
			var x_ = this.Measurement_Period();
			var y_ = context?.Operators.End(x_);
			var z_ = (y_ == null);
			var aa_ = (bool?)z_;
			var ab_ = context?.Operators.Not(aa_);
			var ac_ = context?.Operators.And(w_, ab_);

			return context?.Operators.And(k_, ac_);
		};

		return context?.Operators.WhereOrNull<Observation>(ae_, af_);
	}

    [CqlDeclaration("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status() => __CT_Colonography_Performed_without_appropriate_status.Value;

    private IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date_Value()
	{
		var t_ = this.Flexible_Sigmoidoscopy();
		var u_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(t_, null);
		var v_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var a_ = FlexibleSigmoidoscopy?.Performed;
			var b_ = (a_ as object);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(b_);
			var d_ = context?.Operators.End(c_);
			var e_ = this.Measurement_Period();
			var f_ = context?.Operators.End(e_);
			var g_ = context?.Operators.Quantity(6m, "years");
			var h_ = context?.Operators.Subtract(f_, g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.End(i_);
			var k_ = context?.Operators.Interval(h_, j_, true, true);
			var l_ = context?.Operators.ElementInInterval<CqlDateTime>(d_, k_, null);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = (n_ == null);
			var p_ = (bool?)o_;
			var q_ = context?.Operators.Not(p_);

			return context?.Operators.And(l_, q_);
		};
		var w_ = context?.Operators.WhereOrNull<Procedure>(u_, v_);
		var x_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var r_ = FlexibleSigmoidoscopy?.Performed;
			var s_ = (r_ as object);

			return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(s_);
		};

		return context?.Operators.SelectOrNull<Procedure, CqlDateTime>(w_, x_);
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date() => __Flexible_Sigmoidoscopy_Display_Date.Value;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Value()
	{
		var x_ = this.Flexible_Sigmoidoscopy();
		var y_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(x_, null);
		var z_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var a_ = FlexibleSigmoidoscopy?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = FlexibleSigmoidoscopy?.Performed;
			var g_ = (f_ as object);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.Quantity(5m, "years");
			var m_ = context?.Operators.Subtract(k_, l_);
			var n_ = this.Measurement_Period();
			var o_ = context?.Operators.End(n_);
			var p_ = context?.Operators.Interval(m_, o_, true, true);
			var q_ = context?.Operators.ElementInInterval<CqlDateTime>(i_, p_, null);
			var r_ = this.Measurement_Period();
			var s_ = context?.Operators.End(r_);
			var t_ = (s_ == null);
			var u_ = (bool?)t_;
			var v_ = context?.Operators.Not(u_);
			var w_ = context?.Operators.And(q_, v_);

			return context?.Operators.And(e_, w_);
		};

		return context?.Operators.WhereOrNull<Procedure>(y_, z_);
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed() => __Flexible_Sigmoidoscopy_Performed.Value;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Value()
	{
		var y_ = this.Flexible_Sigmoidoscopy();
		var z_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(y_, null);
		var aa_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var a_ = FlexibleSigmoidoscopy?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = context?.Operators.Not(e_);
			var g_ = FlexibleSigmoidoscopy?.Performed;
			var h_ = (g_ as object);
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			var j_ = context?.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.End(k_);
			var m_ = context?.Operators.Quantity(5m, "years");
			var n_ = context?.Operators.Subtract(l_, m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = context?.Operators.Interval(n_, p_, true, true);
			var r_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, q_, null);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.End(s_);
			var u_ = (t_ == null);
			var v_ = (bool?)u_;
			var w_ = context?.Operators.Not(v_);
			var x_ = context?.Operators.And(r_, w_);

			return context?.Operators.And(f_, x_);
		};

		return context?.Operators.WhereOrNull<Procedure>(z_, aa_);
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status() => __Flexible_Sigmoidoscopy_Performed_without_appropriate_status.Value;

    private IEnumerable<CqlDateTime> Colonoscopy_Display_Date_Value()
	{
		var t_ = this.Colonoscopy();
		var u_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(t_, null);
		var v_ = (Procedure Colonoscopy) =>
		{
			var a_ = Colonoscopy?.Performed;
			var b_ = (a_ as object);
			var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(b_);
			var d_ = context?.Operators.End(c_);
			var e_ = this.Measurement_Period();
			var f_ = context?.Operators.End(e_);
			var g_ = context?.Operators.Quantity(11m, "years");
			var h_ = context?.Operators.Subtract(f_, g_);
			var i_ = this.Measurement_Period();
			var j_ = context?.Operators.End(i_);
			var k_ = context?.Operators.Interval(h_, j_, true, true);
			var l_ = context?.Operators.ElementInInterval<CqlDateTime>(d_, k_, null);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = (n_ == null);
			var p_ = (bool?)o_;
			var q_ = context?.Operators.Not(p_);

			return context?.Operators.And(l_, q_);
		};
		var w_ = context?.Operators.WhereOrNull<Procedure>(u_, v_);
		var x_ = (Procedure Colonoscopy) =>
		{
			var r_ = Colonoscopy?.Performed;
			var s_ = (r_ as object);

			return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(s_);
		};

		return context?.Operators.SelectOrNull<Procedure, CqlDateTime>(w_, x_);
	}

    [CqlDeclaration("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date() => __Colonoscopy_Display_Date.Value;

    private IEnumerable<Procedure> Colonoscopy_Performed_Value()
	{
		var x_ = this.Colonoscopy();
		var y_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(x_, null);
		var z_ = (Procedure Colonoscopy) =>
		{
			var a_ = Colonoscopy?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = Colonoscopy?.Performed;
			var g_ = (f_ as object);
			var h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(g_);
			var i_ = context?.Operators.End(h_);
			var j_ = this.Measurement_Period();
			var k_ = context?.Operators.End(j_);
			var l_ = context?.Operators.Quantity(10m, "years");
			var m_ = context?.Operators.Subtract(k_, l_);
			var n_ = this.Measurement_Period();
			var o_ = context?.Operators.End(n_);
			var p_ = context?.Operators.Interval(m_, o_, true, true);
			var q_ = context?.Operators.ElementInInterval<CqlDateTime>(i_, p_, null);
			var r_ = this.Measurement_Period();
			var s_ = context?.Operators.End(r_);
			var t_ = (s_ == null);
			var u_ = (bool?)t_;
			var v_ = context?.Operators.Not(u_);
			var w_ = context?.Operators.And(q_, v_);

			return context?.Operators.And(e_, w_);
		};

		return context?.Operators.WhereOrNull<Procedure>(y_, z_);
	}

    [CqlDeclaration("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed() => __Colonoscopy_Performed.Value;

    private IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status_Value()
	{
		var y_ = this.Colonoscopy();
		var z_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(y_, null);
		var aa_ = (Procedure Colonoscopy) =>
		{
			var a_ = Colonoscopy?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("completed" as object));
			var f_ = context?.Operators.Not(e_);
			var g_ = Colonoscopy?.Performed;
			var h_ = (g_ as object);
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
			var j_ = context?.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.End(k_);
			var m_ = context?.Operators.Quantity(10m, "years");
			var n_ = context?.Operators.Subtract(l_, m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.End(o_);
			var q_ = context?.Operators.Interval(n_, p_, true, true);
			var r_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, q_, null);
			var s_ = this.Measurement_Period();
			var t_ = context?.Operators.End(s_);
			var u_ = (t_ == null);
			var v_ = (bool?)u_;
			var w_ = context?.Operators.Not(v_);
			var x_ = context?.Operators.And(r_, w_);

			return context?.Operators.And(f_, x_);
		};

		return context?.Operators.WhereOrNull<Procedure>(z_, aa_);
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