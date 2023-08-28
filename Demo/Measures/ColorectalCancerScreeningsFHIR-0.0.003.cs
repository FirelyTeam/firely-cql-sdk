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

    private CqlCode laboratory_Value()
	{
		var a_ = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

		return a_;
	}

    [CqlDeclaration("laboratory")]
    public CqlCode laboratory() => __laboratory.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes() => __ObservationCategoryCodes.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var b_ = a_.ConvertIntegerToDecimal(default);
		var d_ = a_.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, b_);
		var f_ = a_.ConvertIntegerToDecimal(default);
		var h_ = a_.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, f_);
		var j_ = a_.Interval(d_, h_, true, false);
		var k_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var a_ = this.Online_Assessments();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = this.Telephone_Visits();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		bool? i_(Encounter TelehealthEncounter)
		{
			var l_ = TelehealthEncounter.StatusElement;
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var r_ = context.Operators;
			var s_ = r_.Equal(q_, "finished");
			var t_ = this.Measurement_Period();
			var u_ = TelehealthEncounter.Period;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(u_);
			var x_ = r_.IntervalIncludesInterval<CqlDateTime>(t_, v_, null);
			var z_ = r_.And(s_, x_);

			return z_;
		};
		var k_ = g_.WhereOrNull<Encounter>(h_, i_);

		return k_;
	}

    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services() => __Telehealth_Services.Value;

    private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");

		return m_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period() => __Age_at_start_of_Measurement_Period.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var o_ = d_.Interval((int?)51, (int?)75, true, false);
		var q_ = d_.ElementInInterval<int?>(m_, o_, null);
		var r_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var s_ = this.Telehealth_Services();
		var u_ = d_.ListUnion<Encounter>(r_, s_);
		var w_ = d_.ExistsInList<Encounter>(u_);
		var y_ = d_.And(q_, w_);

		return y_;
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<Condition> Malignant_Neoplasm_Value()
	{
		var a_ = this.Malignant_Neoplasm_of_Colon();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		bool? d_(Condition ColorectalCancer)
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColorectalCancer);
			var h_ = context.Operators;
			var i_ = h_.Start(g_);
			var j_ = this.Measurement_Period();
			var l_ = h_.End(j_);
			var n_ = h_.SameOrBefore(i_, l_, null);

			return n_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Condition>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm() => __Malignant_Neoplasm.Value;

    private IEnumerable<Procedure> Total_Colectomy_Performed_Value()
	{
		var a_ = this.Total_Colectomy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure Colectomy)
		{
			var g_ = Colectomy.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "completed");
			var o_ = Colectomy.Performed;
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
			var r_ = m_.End(p_);
			var s_ = this.Measurement_Period();
			var u_ = m_.End(s_);
			var w_ = m_.SameOrBefore(r_, u_, null);
			var y_ = m_.And(n_, w_);

			return y_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed() => __Total_Colectomy_Performed.Value;

    private IEnumerable<Condition> Total_Colectomy_Condition_Value()
	{
		var a_ = this.Total_Colectomy_ICD9();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		bool? d_(Condition ColectomyDx)
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColectomyDx);
			var h_ = context.Operators;
			var i_ = h_.Start(g_);
			var j_ = this.Measurement_Period();
			var l_ = h_.End(j_);
			var n_ = h_.SameOrBefore(i_, l_, null);

			return n_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Condition>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition() => __Total_Colectomy_Condition.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Malignant_Neoplasm();
		var c_ = context.Operators;
		var d_ = c_.ExistsInList<Condition>(b_);
		var f_ = c_.Or(a_, d_);
		var g_ = this.Total_Colectomy_Performed();
		var i_ = c_.ExistsInList<Procedure>(g_);
		var k_ = c_.Or(f_, i_);
		var l_ = this.Total_Colectomy_Condition();
		var n_ = c_.ExistsInList<Condition>(l_);
		var p_ = c_.Or(k_, n_);
		var q_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var s_ = c_.Or(p_, q_);
		var t_ = this.Patient();
		var u_ = t_.BirthDateElement;
		var v_ = u_.Value;
		var x_ = c_.TypeConverter;
		var y_ = x_.Convert<CqlDate>(v_);
		var z_ = this.Measurement_Period();
		var ab_ = c_.Start(z_);
		var ad_ = c_.DateFrom(ab_);
		var af_ = c_.CalculateAgeAt(y_, ad_, "year");
		var ah_ = c_.GreaterOrEqual(af_, (int?)65);
		var ai_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var ak_ = c_.And(ah_, ai_);
		var am_ = c_.Or(s_, ak_);
		var an_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var ap_ = c_.Or(am_, an_);

		return ap_;
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FecalOccult)
		{
			var j_ = FecalOccult.Effective;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(j_);
			var l_ = this.Measurement_Period();
			var m_ = context.Operators;
			var n_ = m_.Start(l_);
			var p_ = m_.Quantity(1m, "year");
			var r_ = m_.Subtract(n_, p_);
			var u_ = m_.End(l_);
			var w_ = m_.Interval(r_, u_, false, false);
			var y_ = m_.ElementInInterval<CqlDateTime>(k_, w_, null);

			return y_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW g_(Observation FecalOccult)
		{
			var z_ = FecalOccult.Effective;
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(z_);
			var ab_ = FecalOccult.Value;
			var ac_ = context.Operators;
			var ad_ = ac_.LateBoundProperty<IEnumerable<Coding>>(ab_, "coding");
			bool? ae_(Coding @this)
			{
				var bh_ = @this.DisplayElement;
				var bi_ = (bh_ == null);
				var bj_ = context.Operators;
				var bk_ = bj_.Not((bool?)bi_);

				return bk_;
			};
			var ag_ = ac_.WhereOrNull<Coding>(ad_, ae_);
			FhirString ah_(Coding @this)
			{
				var bl_ = @this.DisplayElement;

				return bl_;
			};
			var aj_ = ac_.SelectOrNull<Coding, FhirString>(ag_, ah_);
			var ak_ = FecalOccult.Category;
			bool? al_(CodeableConcept @this)
			{
				var bm_ = @this.Coding;
				var bn_ = (bm_ == null);
				var bo_ = context.Operators;
				var bp_ = bo_.Not((bool?)bn_);

				return bp_;
			};
			var an_ = ac_.WhereOrNull<CodeableConcept>((ak_ as IEnumerable<CodeableConcept>), al_);
			List<Coding> ao_(CodeableConcept @this)
			{
				var bq_ = @this.Coding;

				return bq_;
			};
			var aq_ = ac_.SelectOrNull<CodeableConcept, List<Coding>>(an_, ao_);
			var as_ = ac_.FlattenList<Coding>(aq_);
			bool? at_(Coding @this)
			{
				var br_ = @this.CodeElement;
				var bs_ = (br_ == null);
				var bt_ = context.Operators;
				var bu_ = bt_.Not((bool?)bs_);

				return bu_;
			};
			var av_ = ac_.WhereOrNull<Coding>(as_, at_);
			Code aw_(Coding @this)
			{
				var bv_ = @this.CodeElement;

				return bv_;
			};
			var ay_ = ac_.SelectOrNull<Coding, Code>(av_, aw_);
			bool? az_(Code @this)
			{
				var bw_ = @this.Value;
				var bx_ = (bw_ == null);
				var by_ = context.Operators;
				var bz_ = by_.Not((bool?)bx_);

				return bz_;
			};
			var bb_ = ac_.WhereOrNull<Code>(ay_, az_);
			string bc_(Code @this)
			{
				var ca_ = @this.Value;

				return ca_;
			};
			var be_ = ac_.SelectOrNull<Code, string>(bb_, bc_);
			var bf_ = FecalOccult.StatusElement;
			var bg_ = new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = aa_,
				occultResult = aj_,
				occultCategoryCode = be_,
				occultStatus = bf_,
			};

			return bg_;
		};
		var i_ = e_.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(f_, g_);

		return i_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status() => __Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FecalOccult)
		{
			var g_ = FecalOccult.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var p_ = FecalOccult.Category;
			bool? q_(CodeableConcept FecalOccultCategory)
			{
				var ak_ = FecalOccultCategory.Coding;
				bool? al_(Coding @this)
				{
					var ba_ = @this.CodeElement;
					var bb_ = (ba_ == null);
					var bc_ = context.Operators;
					var bd_ = bc_.Not((bool?)bb_);

					return bd_;
				};
				var am_ = context.Operators;
				var an_ = am_.WhereOrNull<Coding>((ak_ as IEnumerable<Coding>), al_);
				Code ao_(Coding @this)
				{
					var be_ = @this.CodeElement;

					return be_;
				};
				var aq_ = am_.SelectOrNull<Coding, Code>(an_, ao_);
				bool? ar_(Code @this)
				{
					var bf_ = @this.Value;
					var bg_ = (bf_ == null);
					var bh_ = context.Operators;
					var bi_ = bh_.Not((bool?)bg_);

					return bi_;
				};
				var at_ = am_.WhereOrNull<Code>(aq_, ar_);
				string au_(Code @this)
				{
					var bj_ = @this.Value;

					return bj_;
				};
				var aw_ = am_.SelectOrNull<Code, string>(at_, au_);
				var ax_ = new string[]
				{
					"laboratory",
				};
				var az_ = am_.ListEquivalent<string>(aw_, (ax_ as IEnumerable<string>));

				return az_;
			};
			var s_ = n_.WhereOrNull<CodeableConcept>((p_ as IEnumerable<CodeableConcept>), q_);
			var u_ = n_.ExistsInList<CodeableConcept>(s_);
			var w_ = n_.And(o_, u_);
			var x_ = FecalOccult.Value;
			var y_ = (x_ == null);
			var aa_ = n_.Not((bool?)y_);
			var ac_ = n_.And(w_, aa_);
			var ad_ = FecalOccult.Effective;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ad_);
			var af_ = this.Measurement_Period();
			var ah_ = n_.ElementInInterval<CqlDateTime>(ae_, af_, null);
			var aj_ = n_.And(ac_, ah_);

			return aj_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed() => __Fecal_Occult_Blood_Test_Performed.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FecalOccult)
		{
			var g_ = FecalOccult.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var p_ = FecalOccult.Category;
			bool? q_(CodeableConcept FecalOccultCategory)
			{
				var ak_ = FecalOccultCategory.Coding;
				bool? al_(Coding @this)
				{
					var ba_ = @this.CodeElement;
					var bb_ = (ba_ == null);
					var bc_ = context.Operators;
					var bd_ = bc_.Not((bool?)bb_);

					return bd_;
				};
				var am_ = context.Operators;
				var an_ = am_.WhereOrNull<Coding>((ak_ as IEnumerable<Coding>), al_);
				Code ao_(Coding @this)
				{
					var be_ = @this.CodeElement;

					return be_;
				};
				var aq_ = am_.SelectOrNull<Coding, Code>(an_, ao_);
				bool? ar_(Code @this)
				{
					var bf_ = @this.Value;
					var bg_ = (bf_ == null);
					var bh_ = context.Operators;
					var bi_ = bh_.Not((bool?)bg_);

					return bi_;
				};
				var at_ = am_.WhereOrNull<Code>(aq_, ar_);
				string au_(Code @this)
				{
					var bj_ = @this.Value;

					return bj_;
				};
				var aw_ = am_.SelectOrNull<Code, string>(at_, au_);
				var ax_ = new string[]
				{
					"laboratory",
				};
				var az_ = am_.ListEquivalent<string>(aw_, (ax_ as IEnumerable<string>));

				return az_;
			};
			var s_ = n_.WhereOrNull<CodeableConcept>((p_ as IEnumerable<CodeableConcept>), q_);
			var u_ = n_.ExistsInList<CodeableConcept>(s_);
			var w_ = n_.And(o_, u_);
			var x_ = FecalOccult.Value;
			var y_ = (x_ == null);
			var aa_ = n_.Not((bool?)y_);
			var ac_ = n_.And(w_, aa_);
			var ad_ = FecalOccult.Effective;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ad_);
			var af_ = this.Measurement_Period();
			var ah_ = n_.ElementInInterval<CqlDateTime>(ae_, af_, "day");
			var aj_ = n_.And(ac_, ah_);

			return aj_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FecalOccult)
		{
			var g_ = FecalOccult.Category;
			bool? h_(CodeableConcept FecalOccultCategory)
			{
				var z_ = FecalOccultCategory.Coding;
				bool? aa_(Coding @this)
				{
					var ar_ = @this.CodeElement;
					var as_ = (ar_ == null);
					var at_ = context.Operators;
					var au_ = at_.Not((bool?)as_);

					return au_;
				};
				var ab_ = context.Operators;
				var ac_ = ab_.WhereOrNull<Coding>((z_ as IEnumerable<Coding>), aa_);
				Code ad_(Coding @this)
				{
					var av_ = @this.CodeElement;

					return av_;
				};
				var af_ = ab_.SelectOrNull<Coding, Code>(ac_, ad_);
				bool? ag_(Code @this)
				{
					var aw_ = @this.Value;
					var ax_ = (aw_ == null);
					var ay_ = context.Operators;
					var az_ = ay_.Not((bool?)ax_);

					return az_;
				};
				var ai_ = ab_.WhereOrNull<Code>(af_, ag_);
				string aj_(Code @this)
				{
					var ba_ = @this.Value;

					return ba_;
				};
				var al_ = ab_.SelectOrNull<Code, string>(ai_, aj_);
				var am_ = new string[]
				{
					"laboratory",
				};
				var ao_ = ab_.ListEquivalent<string>(al_, (am_ as IEnumerable<string>));
				var aq_ = ab_.Not(ao_);

				return aq_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<CodeableConcept>((g_ as IEnumerable<CodeableConcept>), h_);
			var l_ = i_.ExistsInList<CodeableConcept>(j_);
			var m_ = FecalOccult.Value;
			var n_ = (m_ == null);
			var p_ = i_.Not((bool?)n_);
			var r_ = i_.And(l_, p_);
			var s_ = FecalOccult.Effective;
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(s_);
			var u_ = this.Measurement_Period();
			var w_ = i_.ElementInInterval<CqlDateTime>(t_, u_, "day");
			var y_ = i_.And(r_, w_);

			return y_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FecalOccult)
		{
			var g_ = FecalOccult.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var q_ = n_.Not(o_);
			var r_ = FecalOccult.Value;
			var s_ = (r_ == null);
			var u_ = n_.Not((bool?)s_);
			var w_ = n_.And(q_, u_);
			var x_ = FecalOccult.Effective;
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(x_);
			var z_ = this.Measurement_Period();
			var ab_ = n_.ElementInInterval<CqlDateTime>(y_, z_, "day");
			var ad_ = n_.And(w_, ab_);

			return ad_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FitDNA)
		{
			var j_ = FitDNA.Effective;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(j_);
			var l_ = this.Measurement_Period();
			var m_ = context.Operators;
			var n_ = m_.End(l_);
			var p_ = m_.Quantity(4m, "years");
			var r_ = m_.Subtract(n_, p_);
			var u_ = m_.End(l_);
			var w_ = m_.Interval(r_, u_, true, true);
			var y_ = m_.ElementInInterval<CqlDateTime>(k_, w_, null);
			var ab_ = m_.End(l_);
			var ac_ = (ab_ == null);
			var ae_ = m_.Not((bool?)ac_);
			var ag_ = m_.And(y_, ae_);

			return ag_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW g_(Observation FitDNA)
		{
			var ah_ = FitDNA.Effective;
			var ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ah_);
			var aj_ = FitDNA.Value;
			var ak_ = context.Operators;
			var al_ = ak_.LateBoundProperty<IEnumerable<Coding>>(aj_, "coding");
			bool? am_(Coding @this)
			{
				var bp_ = @this.DisplayElement;
				var bq_ = (bp_ == null);
				var br_ = context.Operators;
				var bs_ = br_.Not((bool?)bq_);

				return bs_;
			};
			var ao_ = ak_.WhereOrNull<Coding>(al_, am_);
			FhirString ap_(Coding @this)
			{
				var bt_ = @this.DisplayElement;

				return bt_;
			};
			var ar_ = ak_.SelectOrNull<Coding, FhirString>(ao_, ap_);
			var as_ = FitDNA.Category;
			bool? at_(CodeableConcept @this)
			{
				var bu_ = @this.Coding;
				var bv_ = (bu_ == null);
				var bw_ = context.Operators;
				var bx_ = bw_.Not((bool?)bv_);

				return bx_;
			};
			var av_ = ak_.WhereOrNull<CodeableConcept>((as_ as IEnumerable<CodeableConcept>), at_);
			List<Coding> aw_(CodeableConcept @this)
			{
				var by_ = @this.Coding;

				return by_;
			};
			var ay_ = ak_.SelectOrNull<CodeableConcept, List<Coding>>(av_, aw_);
			var ba_ = ak_.FlattenList<Coding>(ay_);
			bool? bb_(Coding @this)
			{
				var bz_ = @this.CodeElement;
				var ca_ = (bz_ == null);
				var cb_ = context.Operators;
				var cc_ = cb_.Not((bool?)ca_);

				return cc_;
			};
			var bd_ = ak_.WhereOrNull<Coding>(ba_, bb_);
			Code be_(Coding @this)
			{
				var cd_ = @this.CodeElement;

				return cd_;
			};
			var bg_ = ak_.SelectOrNull<Coding, Code>(bd_, be_);
			bool? bh_(Code @this)
			{
				var ce_ = @this.Value;
				var cf_ = (ce_ == null);
				var cg_ = context.Operators;
				var ch_ = cg_.Not((bool?)cf_);

				return ch_;
			};
			var bj_ = ak_.WhereOrNull<Code>(bg_, bh_);
			string bk_(Code @this)
			{
				var ci_ = @this.Value;

				return ci_;
			};
			var bm_ = ak_.SelectOrNull<Code, string>(bj_, bk_);
			var bn_ = FitDNA.StatusElement;
			var bo_ = new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = ai_,
				occultResult = ar_,
				occultCategoryCode = bm_,
				occultStatus = bn_,
			};

			return bo_;
		};
		var i_ = e_.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(f_, g_);

		return i_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status() => __Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FitDNA)
		{
			var g_ = FitDNA.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var p_ = FitDNA.Category;
			bool? q_(CodeableConcept FitDNACategory)
			{
				var bd_ = FitDNACategory.Coding;
				bool? be_(Coding @this)
				{
					var bt_ = @this.CodeElement;
					var bu_ = (bt_ == null);
					var bv_ = context.Operators;
					var bw_ = bv_.Not((bool?)bu_);

					return bw_;
				};
				var bf_ = context.Operators;
				var bg_ = bf_.WhereOrNull<Coding>((bd_ as IEnumerable<Coding>), be_);
				Code bh_(Coding @this)
				{
					var bx_ = @this.CodeElement;

					return bx_;
				};
				var bj_ = bf_.SelectOrNull<Coding, Code>(bg_, bh_);
				bool? bk_(Code @this)
				{
					var by_ = @this.Value;
					var bz_ = (by_ == null);
					var ca_ = context.Operators;
					var cb_ = ca_.Not((bool?)bz_);

					return cb_;
				};
				var bm_ = bf_.WhereOrNull<Code>(bj_, bk_);
				string bn_(Code @this)
				{
					var cc_ = @this.Value;

					return cc_;
				};
				var bp_ = bf_.SelectOrNull<Code, string>(bm_, bn_);
				var bq_ = new string[]
				{
					"laboratory",
				};
				var bs_ = bf_.ListEquivalent<string>(bp_, (bq_ as IEnumerable<string>));

				return bs_;
			};
			var s_ = n_.WhereOrNull<CodeableConcept>((p_ as IEnumerable<CodeableConcept>), q_);
			var u_ = n_.ExistsInList<CodeableConcept>(s_);
			var w_ = n_.And(o_, u_);
			var x_ = FitDNA.Value;
			var y_ = (x_ == null);
			var aa_ = n_.Not((bool?)y_);
			var ac_ = n_.And(w_, aa_);
			var ad_ = FitDNA.Effective;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ad_);
			var af_ = this.Measurement_Period();
			var ah_ = n_.End(af_);
			var aj_ = n_.Quantity(3m, "years");
			var al_ = n_.Subtract(ah_, aj_);
			var ao_ = n_.End(af_);
			var aq_ = n_.Interval(al_, ao_, true, true);
			var as_ = n_.ElementInInterval<CqlDateTime>(ae_, aq_, null);
			var av_ = n_.End(af_);
			var aw_ = (av_ == null);
			var ay_ = n_.Not((bool?)aw_);
			var ba_ = n_.And(as_, ay_);
			var bc_ = n_.And(ac_, ba_);

			return bc_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed() => __Fecal_Immunochemical_Test_DNA_Performed.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FitDNA)
		{
			var g_ = FitDNA.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var p_ = FitDNA.Category;
			bool? q_(CodeableConcept FitDNACategory)
			{
				var bd_ = FitDNACategory.Coding;
				bool? be_(Coding @this)
				{
					var bt_ = @this.CodeElement;
					var bu_ = (bt_ == null);
					var bv_ = context.Operators;
					var bw_ = bv_.Not((bool?)bu_);

					return bw_;
				};
				var bf_ = context.Operators;
				var bg_ = bf_.WhereOrNull<Coding>((bd_ as IEnumerable<Coding>), be_);
				Code bh_(Coding @this)
				{
					var bx_ = @this.CodeElement;

					return bx_;
				};
				var bj_ = bf_.SelectOrNull<Coding, Code>(bg_, bh_);
				bool? bk_(Code @this)
				{
					var by_ = @this.Value;
					var bz_ = (by_ == null);
					var ca_ = context.Operators;
					var cb_ = ca_.Not((bool?)bz_);

					return cb_;
				};
				var bm_ = bf_.WhereOrNull<Code>(bj_, bk_);
				string bn_(Code @this)
				{
					var cc_ = @this.Value;

					return cc_;
				};
				var bp_ = bf_.SelectOrNull<Code, string>(bm_, bn_);
				var bq_ = new string[]
				{
					"laboratory",
				};
				var bs_ = bf_.ListEquivalent<string>(bp_, (bq_ as IEnumerable<string>));

				return bs_;
			};
			var s_ = n_.WhereOrNull<CodeableConcept>((p_ as IEnumerable<CodeableConcept>), q_);
			var u_ = n_.ExistsInList<CodeableConcept>(s_);
			var w_ = n_.And(o_, u_);
			var x_ = FitDNA.Value;
			var y_ = (x_ == null);
			var aa_ = n_.Not((bool?)y_);
			var ac_ = n_.And(w_, aa_);
			var ad_ = FitDNA.Effective;
			var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ad_);
			var af_ = this.Measurement_Period();
			var ah_ = n_.End(af_);
			var aj_ = n_.Quantity(3m, "years");
			var al_ = n_.Subtract(ah_, aj_);
			var ao_ = n_.End(af_);
			var aq_ = n_.Interval(al_, ao_, true, true);
			var as_ = n_.ElementInInterval<CqlDateTime>(ae_, aq_, "day");
			var av_ = n_.End(af_);
			var aw_ = (av_ == null);
			var ay_ = n_.Not((bool?)aw_);
			var ba_ = n_.And(as_, ay_);
			var bc_ = n_.And(ac_, ba_);

			return bc_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FitDNA)
		{
			var g_ = FitDNA.Category;
			bool? h_(CodeableConcept FitDNACategory)
			{
				var as_ = FitDNACategory.Coding;
				bool? at_(Coding @this)
				{
					var bk_ = @this.CodeElement;
					var bl_ = (bk_ == null);
					var bm_ = context.Operators;
					var bn_ = bm_.Not((bool?)bl_);

					return bn_;
				};
				var au_ = context.Operators;
				var av_ = au_.WhereOrNull<Coding>((as_ as IEnumerable<Coding>), at_);
				Code aw_(Coding @this)
				{
					var bo_ = @this.CodeElement;

					return bo_;
				};
				var ay_ = au_.SelectOrNull<Coding, Code>(av_, aw_);
				bool? az_(Code @this)
				{
					var bp_ = @this.Value;
					var bq_ = (bp_ == null);
					var br_ = context.Operators;
					var bs_ = br_.Not((bool?)bq_);

					return bs_;
				};
				var bb_ = au_.WhereOrNull<Code>(ay_, az_);
				string bc_(Code @this)
				{
					var bt_ = @this.Value;

					return bt_;
				};
				var be_ = au_.SelectOrNull<Code, string>(bb_, bc_);
				var bf_ = new string[]
				{
					"laboratory",
				};
				var bh_ = au_.ListEquivalent<string>(be_, (bf_ as IEnumerable<string>));
				var bj_ = au_.Not(bh_);

				return bj_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<CodeableConcept>((g_ as IEnumerable<CodeableConcept>), h_);
			var l_ = i_.ExistsInList<CodeableConcept>(j_);
			var m_ = FitDNA.Value;
			var n_ = (m_ == null);
			var p_ = i_.Not((bool?)n_);
			var r_ = i_.And(l_, p_);
			var s_ = FitDNA.Effective;
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(s_);
			var u_ = this.Measurement_Period();
			var w_ = i_.End(u_);
			var y_ = i_.Quantity(3m, "years");
			var aa_ = i_.Subtract(w_, y_);
			var ad_ = i_.End(u_);
			var af_ = i_.Interval(aa_, ad_, true, true);
			var ah_ = i_.ElementInInterval<CqlDateTime>(t_, af_, "day");
			var ak_ = i_.End(u_);
			var al_ = (ak_ == null);
			var an_ = i_.Not((bool?)al_);
			var ap_ = i_.And(ah_, an_);
			var ar_ = i_.And(r_, ap_);

			return ar_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
	{
		var a_ = this.FIT_DNA();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation FitDNA)
		{
			var g_ = FitDNA.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var q_ = n_.Not(o_);
			var r_ = FitDNA.Value;
			var s_ = (r_ == null);
			var u_ = n_.Not((bool?)s_);
			var w_ = n_.And(q_, u_);
			var x_ = FitDNA.Effective;
			var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(x_);
			var z_ = this.Measurement_Period();
			var ab_ = n_.End(z_);
			var ad_ = n_.Quantity(3m, "years");
			var af_ = n_.Subtract(ab_, ad_);
			var ai_ = n_.End(z_);
			var ak_ = n_.Interval(af_, ai_, true, true);
			var am_ = n_.ElementInInterval<CqlDateTime>(y_, ak_, "day");
			var ap_ = n_.End(z_);
			var aq_ = (ap_ == null);
			var as_ = n_.Not((bool?)aq_);
			var au_ = n_.And(am_, as_);
			var aw_ = n_.And(w_, au_);

			return aw_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

    private IEnumerable<CqlDateTime> CT_Colonography_Display_Date_Value()
	{
		var a_ = this.CT_Colonography();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation Colonography)
		{
			var j_ = Colonography.Effective;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = context.Operators;
			var m_ = l_.End(k_);
			var n_ = this.Measurement_Period();
			var p_ = l_.End(n_);
			var r_ = l_.Quantity(6m, "years");
			var t_ = l_.Subtract(p_, r_);
			var w_ = l_.End(n_);
			var y_ = l_.Interval(t_, w_, true, true);
			var aa_ = l_.ElementInInterval<CqlDateTime>(m_, y_, null);
			var ad_ = l_.End(n_);
			var ae_ = (ad_ == null);
			var ag_ = l_.Not((bool?)ae_);
			var ai_ = l_.And(aa_, ag_);

			return ai_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		CqlDateTime g_(Observation Colonography)
		{
			var aj_ = Colonography.Effective;
			var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(aj_);

			return ak_;
		};
		var i_ = e_.SelectOrNull<Observation, CqlDateTime>(f_, g_);

		return i_;
	}

    [CqlDeclaration("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date() => __CT_Colonography_Display_Date.Value;

    private IEnumerable<Observation> CT_Colonography_Performed_Value()
	{
		var a_ = this.CT_Colonography();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation Colonography)
		{
			var g_ = Colonography.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var p_ = Colonography.Effective;
			var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(p_);
			var s_ = n_.End(q_);
			var t_ = this.Measurement_Period();
			var v_ = n_.End(t_);
			var x_ = n_.Quantity(5m, "years");
			var z_ = n_.Subtract(v_, x_);
			var ac_ = n_.End(t_);
			var ae_ = n_.Interval(z_, ac_, true, true);
			var ag_ = n_.ElementInInterval<CqlDateTime>(s_, ae_, null);
			var aj_ = n_.End(t_);
			var ak_ = (aj_ == null);
			var am_ = n_.Not((bool?)ak_);
			var ao_ = n_.And(ag_, am_);
			var aq_ = n_.And(o_, ao_);

			return aq_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed() => __CT_Colonography_Performed.Value;

    private IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status_Value()
	{
		var a_ = this.CT_Colonography();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		bool? d_(Observation Colonography)
		{
			var g_ = Colonography.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var n_ = context.Operators;
			var o_ = n_.InList<string>(l_, (m_ as IEnumerable<string>));
			var q_ = n_.Not(o_);
			var r_ = Colonography.Effective;
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(r_);
			var u_ = n_.End(s_);
			var v_ = this.Measurement_Period();
			var x_ = n_.End(v_);
			var z_ = n_.Quantity(5m, "years");
			var ab_ = n_.Subtract(x_, z_);
			var ae_ = n_.End(v_);
			var ag_ = n_.Interval(ab_, ae_, true, true);
			var ai_ = n_.ElementInInterval<CqlDateTime>(u_, ag_, null);
			var al_ = n_.End(v_);
			var am_ = (al_ == null);
			var ao_ = n_.Not((bool?)am_);
			var aq_ = n_.And(ai_, ao_);
			var as_ = n_.And(q_, aq_);

			return as_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status() => __CT_Colonography_Performed_without_appropriate_status.Value;

    private IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date_Value()
	{
		var a_ = this.Flexible_Sigmoidoscopy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure FlexibleSigmoidoscopy)
		{
			var j_ = FlexibleSigmoidoscopy.Performed;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = context.Operators;
			var m_ = l_.End(k_);
			var n_ = this.Measurement_Period();
			var p_ = l_.End(n_);
			var r_ = l_.Quantity(6m, "years");
			var t_ = l_.Subtract(p_, r_);
			var w_ = l_.End(n_);
			var y_ = l_.Interval(t_, w_, true, true);
			var aa_ = l_.ElementInInterval<CqlDateTime>(m_, y_, null);
			var ad_ = l_.End(n_);
			var ae_ = (ad_ == null);
			var ag_ = l_.Not((bool?)ae_);
			var ai_ = l_.And(aa_, ag_);

			return ai_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);
		CqlDateTime g_(Procedure FlexibleSigmoidoscopy)
		{
			var aj_ = FlexibleSigmoidoscopy.Performed;
			var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(aj_);

			return ak_;
		};
		var i_ = e_.SelectOrNull<Procedure, CqlDateTime>(f_, g_);

		return i_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date() => __Flexible_Sigmoidoscopy_Display_Date.Value;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Value()
	{
		var a_ = this.Flexible_Sigmoidoscopy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure FlexibleSigmoidoscopy)
		{
			var g_ = FlexibleSigmoidoscopy.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "completed");
			var o_ = FlexibleSigmoidoscopy.Performed;
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
			var r_ = m_.End(p_);
			var s_ = this.Measurement_Period();
			var u_ = m_.End(s_);
			var w_ = m_.Quantity(5m, "years");
			var y_ = m_.Subtract(u_, w_);
			var ab_ = m_.End(s_);
			var ad_ = m_.Interval(y_, ab_, true, true);
			var af_ = m_.ElementInInterval<CqlDateTime>(r_, ad_, null);
			var ai_ = m_.End(s_);
			var aj_ = (ai_ == null);
			var al_ = m_.Not((bool?)aj_);
			var an_ = m_.And(af_, al_);
			var ap_ = m_.And(n_, an_);

			return ap_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed() => __Flexible_Sigmoidoscopy_Performed.Value;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Value()
	{
		var a_ = this.Flexible_Sigmoidoscopy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure FlexibleSigmoidoscopy)
		{
			var g_ = FlexibleSigmoidoscopy.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "completed");
			var p_ = m_.Not(n_);
			var q_ = FlexibleSigmoidoscopy.Performed;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var t_ = m_.End(r_);
			var u_ = this.Measurement_Period();
			var w_ = m_.End(u_);
			var y_ = m_.Quantity(5m, "years");
			var aa_ = m_.Subtract(w_, y_);
			var ad_ = m_.End(u_);
			var af_ = m_.Interval(aa_, ad_, true, true);
			var ah_ = m_.ElementInInterval<CqlDateTime>(t_, af_, null);
			var ak_ = m_.End(u_);
			var al_ = (ak_ == null);
			var an_ = m_.Not((bool?)al_);
			var ap_ = m_.And(ah_, an_);
			var ar_ = m_.And(p_, ap_);

			return ar_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status() => __Flexible_Sigmoidoscopy_Performed_without_appropriate_status.Value;

    private IEnumerable<CqlDateTime> Colonoscopy_Display_Date_Value()
	{
		var a_ = this.Colonoscopy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure Colonoscopy)
		{
			var j_ = Colonoscopy.Performed;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = context.Operators;
			var m_ = l_.End(k_);
			var n_ = this.Measurement_Period();
			var p_ = l_.End(n_);
			var r_ = l_.Quantity(11m, "years");
			var t_ = l_.Subtract(p_, r_);
			var w_ = l_.End(n_);
			var y_ = l_.Interval(t_, w_, true, true);
			var aa_ = l_.ElementInInterval<CqlDateTime>(m_, y_, null);
			var ad_ = l_.End(n_);
			var ae_ = (ad_ == null);
			var ag_ = l_.Not((bool?)ae_);
			var ai_ = l_.And(aa_, ag_);

			return ai_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);
		CqlDateTime g_(Procedure Colonoscopy)
		{
			var aj_ = Colonoscopy.Performed;
			var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(aj_);

			return ak_;
		};
		var i_ = e_.SelectOrNull<Procedure, CqlDateTime>(f_, g_);

		return i_;
	}

    [CqlDeclaration("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date() => __Colonoscopy_Display_Date.Value;

    private IEnumerable<Procedure> Colonoscopy_Performed_Value()
	{
		var a_ = this.Colonoscopy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure Colonoscopy)
		{
			var g_ = Colonoscopy.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "completed");
			var o_ = Colonoscopy.Performed;
			var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
			var r_ = m_.End(p_);
			var s_ = this.Measurement_Period();
			var u_ = m_.End(s_);
			var w_ = m_.Quantity(10m, "years");
			var y_ = m_.Subtract(u_, w_);
			var ab_ = m_.End(s_);
			var ad_ = m_.Interval(y_, ab_, true, true);
			var af_ = m_.ElementInInterval<CqlDateTime>(r_, ad_, null);
			var ai_ = m_.End(s_);
			var aj_ = (ai_ == null);
			var al_ = m_.Not((bool?)aj_);
			var an_ = m_.And(af_, al_);
			var ap_ = m_.And(n_, an_);

			return ap_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed() => __Colonoscopy_Performed.Value;

    private IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status_Value()
	{
		var a_ = this.Colonoscopy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		bool? d_(Procedure Colonoscopy)
		{
			var g_ = Colonoscopy.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "completed");
			var p_ = m_.Not(n_);
			var q_ = Colonoscopy.Performed;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var t_ = m_.End(r_);
			var u_ = this.Measurement_Period();
			var w_ = m_.End(u_);
			var y_ = m_.Quantity(10m, "years");
			var aa_ = m_.Subtract(w_, y_);
			var ad_ = m_.End(u_);
			var af_ = m_.Interval(aa_, ad_, true, true);
			var ah_ = m_.ElementInInterval<CqlDateTime>(t_, af_, null);
			var ak_ = m_.End(u_);
			var al_ = (ak_ == null);
			var an_ = m_.Not((bool?)al_);
			var ap_ = m_.And(ah_, an_);
			var ar_ = m_.And(p_, ap_);

			return ar_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status() => __Colonoscopy_Performed_without_appropriate_status.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Colonoscopy_Performed();
		var b_ = context.Operators;
		var c_ = b_.ExistsInList<Procedure>(a_);
		var d_ = this.Fecal_Occult_Blood_Test_Performed();
		var f_ = b_.ExistsInList<Observation>(d_);
		var h_ = b_.Or(c_, f_);
		var i_ = this.Flexible_Sigmoidoscopy_Performed();
		var k_ = b_.ExistsInList<Procedure>(i_);
		var m_ = b_.Or(h_, k_);
		var n_ = this.Fecal_Immunochemical_Test_DNA_Performed();
		var p_ = b_.ExistsInList<Observation>(n_);
		var r_ = b_.Or(m_, p_);
		var s_ = this.CT_Colonography_Performed();
		var u_ = b_.ExistsInList<Observation>(s_);
		var w_ = b_.Or(r_, u_);

		return w_;
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    private bool? Final_Numerator_Population_Value()
	{
		var a_ = this.Numerator();
		var b_ = this.Initial_Population();
		var c_ = context.Operators;
		var d_ = c_.And(a_, b_);
		var e_ = this.Denominator();
		var g_ = c_.And(d_, e_);
		var h_ = this.Denominator_Exclusions();
		var j_ = c_.Not(h_);
		var l_ = c_.And(g_, j_);

		return l_;
	}

    [CqlDeclaration("Final Numerator Population")]
    public bool? Final_Numerator_Population() => __Final_Numerator_Population.Value;

}