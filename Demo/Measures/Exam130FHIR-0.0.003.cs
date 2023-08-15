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

    private CqlValueSet Acute_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", 
			null);
    }

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", 
			null);
    }

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Annual_Wellness_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", 
			null);
    }

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit() => __Annual_Wellness_Visit.Value;

    private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", 
			null);
    }

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Colonoscopy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", 
			null);
    }

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
    public CqlValueSet Colonoscopy() => __Colonoscopy.Value;

    private CqlValueSet CT_Colonography_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", 
			null);
    }

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
    public CqlValueSet CT_Colonography() => __CT_Colonography.Value;

    private CqlValueSet Dementia_Medications_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", 
			null);
    }

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", 
			null);
    }

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", 
			null);
    }

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Fecal_Occult_Blood_Test__FOBT__Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", 
			null);
    }

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
    public CqlValueSet Fecal_Occult_Blood_Test__FOBT_() => __Fecal_Occult_Blood_Test__FOBT_.Value;

    private CqlValueSet FIT_DNA_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", 
			null);
    }

    [CqlDeclaration("FIT DNA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
    public CqlValueSet FIT_DNA() => __FIT_DNA.Value;

    private CqlValueSet Flexible_Sigmoidoscopy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", 
			null);
    }

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
    public CqlValueSet Flexible_Sigmoidoscopy() => __Flexible_Sigmoidoscopy.Value;

    private CqlValueSet Frailty_Device_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", 
			null);
    }

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", 
			null);
    }

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", 
			null);
    }

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", 
			null);
    }

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Home_Healthcare_Services_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", 
			null);
    }

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet Hospice_care_ambulatory_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", 
			null);
    }

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_care_ambulatory() => __Hospice_care_ambulatory.Value;

    private CqlValueSet Malignant_Neoplasm_of_Colon_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", 
			null);
    }

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
    public CqlValueSet Malignant_Neoplasm_of_Colon() => __Malignant_Neoplasm_of_Colon.Value;

    private CqlValueSet Nonacute_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", 
			null);
    }

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Nursing_Facility_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", 
			null);
    }

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Observation_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", 
			null);
    }

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Office_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", 
			null);
    }

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Online_Assessments_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", 
			null);
    }

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Outpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", 
			null);
    }

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
    public CqlValueSet Outpatient() => __Outpatient.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", 
			null);
    }

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", 
			null);
    }

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", 
			null);
    }

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlValueSet Total_Colectomy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", 
			null);
    }

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
    public CqlValueSet Total_Colectomy() => __Total_Colectomy.Value;

    private CqlValueSet Total_Colectomy_ICD9_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", 
			null);
    }

    [CqlDeclaration("Total Colectomy ICD9")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136")]
    public CqlValueSet Total_Colectomy_ICD9() => __Total_Colectomy_ICD9.Value;

    private CqlCode laboratory_Value()
    {
        return new CqlCode("laboratory", 
			"http://terminology.hl7.org/CodeSystem/observation-category", 
			null, 
			null);
    }

    [CqlDeclaration("laboratory")]
    public CqlCode laboratory() => __laboratory.Value;

    private CqlCode[] ObservationCategoryCodes_Value()
    {
        var a_ = new CqlCode("laboratory", 
			"http://terminology.hl7.org/CodeSystem/observation-category", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
		};
    }
    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes() => __ObservationCategoryCodes.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("Exam130FHIR-0.0.003", 
			"Measurement Period", 
			(context?.Operators.Interval(context?.Operators.DateTime(((int?)2021), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				context?.Operators.DateTime(((int?)2022), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				true, 
				false) as object)));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();
    }
    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();
    }
    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Race();
    }
    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();
    }
    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Telehealth_Services_Value()
    {
        var a_ = this.Online_Assessments();
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        var d_ = this.Telephone_Visits();
        var f_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<Encounter>(c_, 
			f_);
        Func<Encounter,bool?> p_ = (TelehealthEncounter) => 
        {
            var i_ = (TelehealthEncounter?.StatusElement as object);
            var h_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(i_) as object);
            var j_ = ("finished" as object);
            var k_ = context?.Operators.Equal(h_, 
				j_);
            var l_ = this.Measurement_Period();
            var m_ = (TelehealthEncounter?.Period as object);
            var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
            var o_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(l_, 
				n_, 
				null);
            return context?.Operators.And(k_, 
				o_);
        };
        return context?.Operators.WhereOrNull<Encounter>(g_, 
			p_);
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
        return context?.Operators.CalculateAgeAt(b_, 
			e_, 
			"year");
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
        var f_ = context?.Operators.CalculateAgeAt(b_, 
			e_, 
			"year");
        var g_ = context?.Operators.Interval(((int?)51), 
			((int?)75), 
			true, 
			false);
        var h_ = context?.Operators.ElementInInterval<int?>(f_, 
			g_, 
			null);
        var i_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
        var j_ = this.Telehealth_Services();
        var k_ = context?.Operators.ListUnion<Encounter>(i_, 
			j_);
        var l_ = context?.Operators.ExistsInList<Encounter>(k_);
        return context?.Operators.And(h_, 
			l_);
    }
    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value()
    {
        return this.Initial_Population();
    }
    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<Condition> Malignant_Neoplasm_Value()
    {
        var a_ = this.Malignant_Neoplasm_of_Colon();
        var b_ = typeof(Condition).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, 
			b_);
        Func<Condition,bool?> h_ = (ColorectalCancer) => 
        {
            var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColorectalCancer);
            var e_ = context?.Operators.Start(d_);
            var f_ = this.Measurement_Period();
            var g_ = context?.Operators.End(f_);
            return context?.Operators.SameOrBefore(e_, 
				g_, 
				null);
        };
        return context?.Operators.WhereOrNull<Condition>(c_, 
			h_);
    }
    [CqlDeclaration("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm() => __Malignant_Neoplasm.Value;

    private IEnumerable<Procedure> Total_Colectomy_Performed_Value()
    {
        var a_ = this.Total_Colectomy();
        var b_ = typeof(Procedure).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, 
			b_);
        Func<Procedure,bool?> n_ = (Colectomy) => 
        {
            var e_ = (Colectomy?.StatusElement as object);
            var d_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_) as object);
            var f_ = ("completed" as object);
            var g_ = context?.Operators.Equal(d_, 
				f_);
            var h_ = (Colectomy?.Performed as object);
            var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
            var j_ = context?.Operators.End(i_);
            var k_ = this.Measurement_Period();
            var l_ = context?.Operators.End(k_);
            var m_ = context?.Operators.SameOrBefore(j_, 
				l_, 
				null);
            return context?.Operators.And(g_, 
				m_);
        };
        return context?.Operators.WhereOrNull<Procedure>(c_, 
			n_);
    }
    [CqlDeclaration("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed() => __Total_Colectomy_Performed.Value;

    private IEnumerable<Condition> Total_Colectomy_Condition_Value()
    {
        var a_ = this.Total_Colectomy_ICD9();
        var b_ = typeof(Condition).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, 
			b_);
        Func<Condition,bool?> h_ = (ColectomyDx) => 
        {
            var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ColectomyDx);
            var e_ = context?.Operators.Start(d_);
            var f_ = this.Measurement_Period();
            var g_ = context?.Operators.End(f_);
            return context?.Operators.SameOrBefore(e_, 
				g_, 
				null);
        };
        return context?.Operators.WhereOrNull<Condition>(c_, 
			h_);
    }
    [CqlDeclaration("Total Colectomy Condition")]
    public IEnumerable<Condition> Total_Colectomy_Condition() => __Total_Colectomy_Condition.Value;

    private bool? Denominator_Exclusions_Value()
    {
        var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
        var b_ = this.Malignant_Neoplasm();
        var c_ = context?.Operators.ExistsInList<Condition>(b_);
        var d_ = context?.Operators.Or(a_, 
			c_);
        var e_ = this.Total_Colectomy_Performed();
        var f_ = context?.Operators.ExistsInList<Procedure>(e_);
        var g_ = context?.Operators.Or(d_, 
			f_);
        var h_ = this.Total_Colectomy_Condition();
        var i_ = context?.Operators.ExistsInList<Condition>(h_);
        var j_ = context?.Operators.Or(g_, 
			i_);
        var k_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
        var l_ = context?.Operators.Or(j_, 
			k_);
        var n_ = (this.Patient()?.BirthDateElement?.Value as object);
        var o_ = context?.Operators?.TypeConverter.Convert<CqlDate>(n_);
        var p_ = this.Measurement_Period();
        var q_ = context?.Operators.Start(p_);
        var r_ = context?.Operators.DateFrom(q_);
        var m_ = (context?.Operators.CalculateAgeAt(o_, 
			r_, 
			"year") as object);
        var s_ = (((int?)65) as object);
        var t_ = context?.Operators.GreaterOrEqual(m_, 
			s_);
        var u_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
        var v_ = context?.Operators.And(t_, 
			u_);
        var w_ = context?.Operators.Or(l_, 
			v_);
        var x_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
        return context?.Operators.Or(w_, 
			x_);
    }
    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value()
    {
        var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> m_ = (FecalOccult) => 
        {
            var d_ = (FecalOccult?.Effective as object);
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(d_);
            var f_ = this.Measurement_Period();
            var g_ = context?.Operators.Start(f_);
            var h_ = context?.Operators.Quantity(1m, 
				"year");
            var i_ = context?.Operators.Subtract(g_, 
				h_);
            var k_ = context?.Operators.End(f_);
            var l_ = context?.Operators.Interval(i_, 
				k_, 
				false, 
				false);
            return context?.Operators.ElementInInterval<CqlDateTime>(e_, 
				l_, 
				null);
        };
        var n_ = context?.Operators.WhereOrNull<Observation>(c_, 
			m_);
        Func<Observation,Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> ap_ = (FecalOccult) => 
        {
            var p_ = (FecalOccult?.Effective as object);
            var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(p_);
            var r_ = (FecalOccult?.Value as object);
            var s_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(r_, 
				"coding");
            Func<Coding,bool?> u_ = (@this) => 
            {
                bool? t_ = ((bool?)(@this?.DisplayElement == null));
                return context?.Operators.Not(t_);
            };
            var v_ = context?.Operators.WhereOrNull<Coding>(s_, 
				u_);
            Func<Coding,FhirString> w_ = (@this) => 
            {
                return @this?.DisplayElement;
            };
            var q_ = context?.Operators.SelectOrNull<Coding, FhirString>(v_, 
				w_);
            var y_ = (FecalOccult?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> aa_ = (@this) => 
            {
                bool? z_ = ((bool?)(@this?.Coding == null));
                return context?.Operators.Not(z_);
            };
            var ab_ = context?.Operators.WhereOrNull<CodeableConcept>(y_, 
				aa_);
            Func<CodeableConcept,List<Coding>> ac_ = (@this) => 
            {
                return @this?.Coding;
            };
            var ad_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(ab_, 
				ac_);
            var ae_ = context?.Operators.FlattenList<Coding>(ad_);
            Func<Coding,bool?> ag_ = (@this) => 
            {
                bool? af_ = ((bool?)(@this?.CodeElement == null));
                return context?.Operators.Not(af_);
            };
            var ah_ = context?.Operators.WhereOrNull<Coding>(ae_, 
				ag_);
            Func<Coding,Code> ai_ = (@this) => 
            {
                return @this?.CodeElement;
            };
            var aj_ = context?.Operators.SelectOrNull<Coding, Code>(ah_, 
				ai_);
            Func<Code,bool?> al_ = (@this) => 
            {
                bool? ak_ = ((bool?)(@this?.Value == null));
                return context?.Operators.Not(ak_);
            };
            var am_ = context?.Operators.WhereOrNull<Code>(aj_, 
				al_);
            Func<Code,string> an_ = (@this) => 
            {
                return @this?.Value;
            };
            var x_ = context?.Operators.SelectOrNull<Code, string>(am_, 
				an_);
            var ao_ = FecalOccult?.StatusElement;
            return new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = o_,
				occultResult = q_,
				occultCategoryCode = x_,
				occultStatus = ao_,
			};
        };
        return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(n_, 
			ap_);
    }
    [CqlDeclaration("Fecal Occult Blood Test Display Date, Result, Category, Status")]
    public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status() => __Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_Value()
    {
        var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> aj_ = (FecalOccult) => 
        {
            var d_ = (FecalOccult?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = (FecalOccult?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> y_ = (FecalOccultCategory) => 
            {
                var l_ = (FecalOccultCategory?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> n_ = (@this) => 
                {
                    bool? m_ = ((bool?)(@this?.CodeElement == null));
                    return context?.Operators.Not(m_);
                };
                var o_ = context?.Operators.WhereOrNull<Coding>(l_, 
					n_);
                Func<Coding,Code> p_ = (@this) => 
                {
                    return @this?.CodeElement;
                };
                var q_ = context?.Operators.SelectOrNull<Coding, Code>(o_, 
					p_);
                Func<Code,bool?> s_ = (@this) => 
                {
                    bool? r_ = ((bool?)(@this?.Value == null));
                    return context?.Operators.Not(r_);
                };
                var t_ = context?.Operators.WhereOrNull<Code>(q_, 
					s_);
                Func<Code,string> u_ = (@this) => 
                {
                    return @this?.Value;
                };
                var v_ = context?.Operators.SelectOrNull<Code, string>(t_, 
					u_);
                var x_ = "laboratory";
                var w_ = (new string[]
				{
					x_,
				} as IEnumerable<string>);
                return context?.Operators.ListEquivalent<string>(v_, 
					w_);
            };
            var z_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, 
				y_);
            var aa_ = context?.Operators.ExistsInList<CodeableConcept>(z_);
            var ab_ = context?.Operators.And(j_, 
				aa_);
            bool? ac_ = ((bool?)((FecalOccult?.Value as object) == null));
            var ad_ = context?.Operators.Not(ac_);
            var ae_ = context?.Operators.And(ab_, 
				ad_);
            var af_ = (FecalOccult?.Effective as object);
            var ag_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(af_);
            var ah_ = this.Measurement_Period();
            var ai_ = context?.Operators.ElementInInterval<CqlDateTime>(ag_, 
				ah_, 
				null);
            return context?.Operators.And(ae_, 
				ai_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			aj_);
    }
    [CqlDeclaration("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed() => __Fecal_Occult_Blood_Test_Performed.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset_Value()
    {
        var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> aj_ = (FecalOccult) => 
        {
            var d_ = (FecalOccult?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = (FecalOccult?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> y_ = (FecalOccultCategory) => 
            {
                var l_ = (FecalOccultCategory?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> n_ = (@this) => 
                {
                    bool? m_ = ((bool?)(@this?.CodeElement == null));
                    return context?.Operators.Not(m_);
                };
                var o_ = context?.Operators.WhereOrNull<Coding>(l_, 
					n_);
                Func<Coding,Code> p_ = (@this) => 
                {
                    return @this?.CodeElement;
                };
                var q_ = context?.Operators.SelectOrNull<Coding, Code>(o_, 
					p_);
                Func<Code,bool?> s_ = (@this) => 
                {
                    bool? r_ = ((bool?)(@this?.Value == null));
                    return context?.Operators.Not(r_);
                };
                var t_ = context?.Operators.WhereOrNull<Code>(q_, 
					s_);
                Func<Code,string> u_ = (@this) => 
                {
                    return @this?.Value;
                };
                var v_ = context?.Operators.SelectOrNull<Code, string>(t_, 
					u_);
                var x_ = "laboratory";
                var w_ = (new string[]
				{
					x_,
				} as IEnumerable<string>);
                return context?.Operators.ListEquivalent<string>(v_, 
					w_);
            };
            var z_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, 
				y_);
            var aa_ = context?.Operators.ExistsInList<CodeableConcept>(z_);
            var ab_ = context?.Operators.And(j_, 
				aa_);
            bool? ac_ = ((bool?)((FecalOccult?.Value as object) == null));
            var ad_ = context?.Operators.Not(ac_);
            var ae_ = context?.Operators.And(ab_, 
				ad_);
            var af_ = (FecalOccult?.Effective as object);
            var ag_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(af_);
            var ah_ = this.Measurement_Period();
            var ai_ = context?.Operators.ElementInInterval<CqlDateTime>(ag_, 
				ah_, 
				"day");
            return context?.Operators.And(ae_, 
				ai_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			aj_);
    }
    [CqlDeclaration("Fecal Occult Blood Test Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
    {
        var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> ac_ = (FecalOccult) => 
        {
            var d_ = (FecalOccult?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> s_ = (FecalOccultCategory) => 
            {
                var e_ = (FecalOccultCategory?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> g_ = (@this) => 
                {
                    bool? f_ = ((bool?)(@this?.CodeElement == null));
                    return context?.Operators.Not(f_);
                };
                var h_ = context?.Operators.WhereOrNull<Coding>(e_, 
					g_);
                Func<Coding,Code> i_ = (@this) => 
                {
                    return @this?.CodeElement;
                };
                var j_ = context?.Operators.SelectOrNull<Coding, Code>(h_, 
					i_);
                Func<Code,bool?> l_ = (@this) => 
                {
                    bool? k_ = ((bool?)(@this?.Value == null));
                    return context?.Operators.Not(k_);
                };
                var m_ = context?.Operators.WhereOrNull<Code>(j_, 
					l_);
                Func<Code,string> n_ = (@this) => 
                {
                    return @this?.Value;
                };
                var o_ = context?.Operators.SelectOrNull<Code, string>(m_, 
					n_);
                var q_ = "laboratory";
                var p_ = (new string[]
				{
					q_,
				} as IEnumerable<string>);
                var r_ = context?.Operators.ListEquivalent<string>(o_, 
					p_);
                return context?.Operators.Not(r_);
            };
            var t_ = context?.Operators.WhereOrNull<CodeableConcept>(d_, 
				s_);
            var u_ = context?.Operators.ExistsInList<CodeableConcept>(t_);
            bool? v_ = ((bool?)((FecalOccult?.Value as object) == null));
            var w_ = context?.Operators.Not(v_);
            var x_ = context?.Operators.And(u_, 
				w_);
            var y_ = (FecalOccult?.Effective as object);
            var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(y_);
            var aa_ = this.Measurement_Period();
            var ab_ = context?.Operators.ElementInInterval<CqlDateTime>(z_, 
				aa_, 
				"day");
            return context?.Operators.And(x_, 
				ab_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			ac_);
    }
    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
    {
        var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> s_ = (FecalOccult) => 
        {
            var d_ = (FecalOccult?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = context?.Operators.Not(j_);
            bool? l_ = ((bool?)((FecalOccult?.Value as object) == null));
            var m_ = context?.Operators.Not(l_);
            var n_ = context?.Operators.And(k_, 
				m_);
            var o_ = (FecalOccult?.Effective as object);
            var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(o_);
            var q_ = this.Measurement_Period();
            var r_ = context?.Operators.ElementInInterval<CqlDateTime>(p_, 
				q_, 
				"day");
            return context?.Operators.And(n_, 
				r_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			s_);
    }
    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => __Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status_Value()
    {
        var a_ = this.FIT_DNA();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> q_ = (FitDNA) => 
        {
            var d_ = (FitDNA?.Effective as object);
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(d_);
            var f_ = this.Measurement_Period();
            var g_ = context?.Operators.End(f_);
            var h_ = context?.Operators.Quantity(4m, 
				"years");
            var i_ = context?.Operators.Subtract(g_, 
				h_);
            var l_ = context?.Operators.Interval(i_, 
				g_, 
				true, 
				true);
            var m_ = context?.Operators.ElementInInterval<CqlDateTime>(e_, 
				l_, 
				null);
            bool? n_ = ((bool?)(context?.Operators.End(f_) == null));
            var p_ = context?.Operators.Not(n_);
            return context?.Operators.And(m_, 
				p_);
        };
        var r_ = context?.Operators.WhereOrNull<Observation>(c_, 
			q_);
        Func<Observation,Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> at_ = (FitDNA) => 
        {
            var t_ = (FitDNA?.Effective as object);
            var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(t_);
            var v_ = (FitDNA?.Value as object);
            var w_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(v_, 
				"coding");
            Func<Coding,bool?> y_ = (@this) => 
            {
                bool? x_ = ((bool?)(@this?.DisplayElement == null));
                return context?.Operators.Not(x_);
            };
            var z_ = context?.Operators.WhereOrNull<Coding>(w_, 
				y_);
            Func<Coding,FhirString> aa_ = (@this) => 
            {
                return @this?.DisplayElement;
            };
            var u_ = context?.Operators.SelectOrNull<Coding, FhirString>(z_, 
				aa_);
            var ac_ = (FitDNA?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> ae_ = (@this) => 
            {
                bool? ad_ = ((bool?)(@this?.Coding == null));
                return context?.Operators.Not(ad_);
            };
            var af_ = context?.Operators.WhereOrNull<CodeableConcept>(ac_, 
				ae_);
            Func<CodeableConcept,List<Coding>> ag_ = (@this) => 
            {
                return @this?.Coding;
            };
            var ah_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(af_, 
				ag_);
            var ai_ = context?.Operators.FlattenList<Coding>(ah_);
            Func<Coding,bool?> ak_ = (@this) => 
            {
                bool? aj_ = ((bool?)(@this?.CodeElement == null));
                return context?.Operators.Not(aj_);
            };
            var al_ = context?.Operators.WhereOrNull<Coding>(ai_, 
				ak_);
            Func<Coding,Code> am_ = (@this) => 
            {
                return @this?.CodeElement;
            };
            var an_ = context?.Operators.SelectOrNull<Coding, Code>(al_, 
				am_);
            Func<Code,bool?> ap_ = (@this) => 
            {
                bool? ao_ = ((bool?)(@this?.Value == null));
                return context?.Operators.Not(ao_);
            };
            var aq_ = context?.Operators.WhereOrNull<Code>(an_, 
				ap_);
            Func<Code,string> ar_ = (@this) => 
            {
                return @this?.Value;
            };
            var ab_ = context?.Operators.SelectOrNull<Code, string>(aq_, 
				ar_);
            var as_ = FitDNA?.StatusElement;
            return new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = s_,
				occultResult = u_,
				occultCategoryCode = ab_,
				occultStatus = as_,
			};
        };
        return context?.Operators.SelectOrNull<Observation, Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW>(r_, 
			at_);
    }
    [CqlDeclaration("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
    public IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status() => __Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_Value()
    {
        var a_ = this.FIT_DNA();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> at_ = (FitDNA) => 
        {
            var d_ = (FitDNA?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = (FitDNA?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> y_ = (FitDNACategory) => 
            {
                var l_ = (FitDNACategory?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> n_ = (@this) => 
                {
                    bool? m_ = ((bool?)(@this?.CodeElement == null));
                    return context?.Operators.Not(m_);
                };
                var o_ = context?.Operators.WhereOrNull<Coding>(l_, 
					n_);
                Func<Coding,Code> p_ = (@this) => 
                {
                    return @this?.CodeElement;
                };
                var q_ = context?.Operators.SelectOrNull<Coding, Code>(o_, 
					p_);
                Func<Code,bool?> s_ = (@this) => 
                {
                    bool? r_ = ((bool?)(@this?.Value == null));
                    return context?.Operators.Not(r_);
                };
                var t_ = context?.Operators.WhereOrNull<Code>(q_, 
					s_);
                Func<Code,string> u_ = (@this) => 
                {
                    return @this?.Value;
                };
                var v_ = context?.Operators.SelectOrNull<Code, string>(t_, 
					u_);
                var x_ = "laboratory";
                var w_ = (new string[]
				{
					x_,
				} as IEnumerable<string>);
                return context?.Operators.ListEquivalent<string>(v_, 
					w_);
            };
            var z_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, 
				y_);
            var aa_ = context?.Operators.ExistsInList<CodeableConcept>(z_);
            var ab_ = context?.Operators.And(j_, 
				aa_);
            bool? ac_ = ((bool?)((FitDNA?.Value as object) == null));
            var ad_ = context?.Operators.Not(ac_);
            var ae_ = context?.Operators.And(ab_, 
				ad_);
            var af_ = (FitDNA?.Effective as object);
            var ag_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(af_);
            var ah_ = this.Measurement_Period();
            var ai_ = context?.Operators.End(ah_);
            var aj_ = context?.Operators.Quantity(3m, 
				"years");
            var ak_ = context?.Operators.Subtract(ai_, 
				aj_);
            var an_ = context?.Operators.Interval(ak_, 
				ai_, 
				true, 
				true);
            var ao_ = context?.Operators.ElementInInterval<CqlDateTime>(ag_, 
				an_, 
				null);
            bool? ap_ = ((bool?)(context?.Operators.End(ah_) == null));
            var ar_ = context?.Operators.Not(ap_);
            var as_ = context?.Operators.And(ao_, 
				ar_);
            return context?.Operators.And(ae_, 
				as_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			at_);
    }
    [CqlDeclaration("Fecal Immunochemical Test DNA Performed")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed() => __Fecal_Immunochemical_Test_DNA_Performed.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset_Value()
    {
        var a_ = this.FIT_DNA();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> at_ = (FitDNA) => 
        {
            var d_ = (FitDNA?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = (FitDNA?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> y_ = (FitDNACategory) => 
            {
                var l_ = (FitDNACategory?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> n_ = (@this) => 
                {
                    bool? m_ = ((bool?)(@this?.CodeElement == null));
                    return context?.Operators.Not(m_);
                };
                var o_ = context?.Operators.WhereOrNull<Coding>(l_, 
					n_);
                Func<Coding,Code> p_ = (@this) => 
                {
                    return @this?.CodeElement;
                };
                var q_ = context?.Operators.SelectOrNull<Coding, Code>(o_, 
					p_);
                Func<Code,bool?> s_ = (@this) => 
                {
                    bool? r_ = ((bool?)(@this?.Value == null));
                    return context?.Operators.Not(r_);
                };
                var t_ = context?.Operators.WhereOrNull<Code>(q_, 
					s_);
                Func<Code,string> u_ = (@this) => 
                {
                    return @this?.Value;
                };
                var v_ = context?.Operators.SelectOrNull<Code, string>(t_, 
					u_);
                var x_ = "laboratory";
                var w_ = (new string[]
				{
					x_,
				} as IEnumerable<string>);
                return context?.Operators.ListEquivalent<string>(v_, 
					w_);
            };
            var z_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, 
				y_);
            var aa_ = context?.Operators.ExistsInList<CodeableConcept>(z_);
            var ab_ = context?.Operators.And(j_, 
				aa_);
            bool? ac_ = ((bool?)((FitDNA?.Value as object) == null));
            var ad_ = context?.Operators.Not(ac_);
            var ae_ = context?.Operators.And(ab_, 
				ad_);
            var af_ = (FitDNA?.Effective as object);
            var ag_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(af_);
            var ah_ = this.Measurement_Period();
            var ai_ = context?.Operators.End(ah_);
            var aj_ = context?.Operators.Quantity(3m, 
				"years");
            var ak_ = context?.Operators.Subtract(ai_, 
				aj_);
            var an_ = context?.Operators.Interval(ak_, 
				ai_, 
				true, 
				true);
            var ao_ = context?.Operators.ElementInInterval<CqlDateTime>(ag_, 
				an_, 
				"day");
            bool? ap_ = ((bool?)(context?.Operators.End(ah_) == null));
            var ar_ = context?.Operators.Not(ap_);
            var as_ = context?.Operators.And(ao_, 
				ar_);
            return context?.Operators.And(ae_, 
				as_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			at_);
    }
    [CqlDeclaration("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset_Value()
    {
        var a_ = this.FIT_DNA();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> am_ = (FitDNA) => 
        {
            var d_ = (FitDNA?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> s_ = (FitDNACategory) => 
            {
                var e_ = (FitDNACategory?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> g_ = (@this) => 
                {
                    bool? f_ = ((bool?)(@this?.CodeElement == null));
                    return context?.Operators.Not(f_);
                };
                var h_ = context?.Operators.WhereOrNull<Coding>(e_, 
					g_);
                Func<Coding,Code> i_ = (@this) => 
                {
                    return @this?.CodeElement;
                };
                var j_ = context?.Operators.SelectOrNull<Coding, Code>(h_, 
					i_);
                Func<Code,bool?> l_ = (@this) => 
                {
                    bool? k_ = ((bool?)(@this?.Value == null));
                    return context?.Operators.Not(k_);
                };
                var m_ = context?.Operators.WhereOrNull<Code>(j_, 
					l_);
                Func<Code,string> n_ = (@this) => 
                {
                    return @this?.Value;
                };
                var o_ = context?.Operators.SelectOrNull<Code, string>(m_, 
					n_);
                var q_ = "laboratory";
                var p_ = (new string[]
				{
					q_,
				} as IEnumerable<string>);
                var r_ = context?.Operators.ListEquivalent<string>(o_, 
					p_);
                return context?.Operators.Not(r_);
            };
            var t_ = context?.Operators.WhereOrNull<CodeableConcept>(d_, 
				s_);
            var u_ = context?.Operators.ExistsInList<CodeableConcept>(t_);
            bool? v_ = ((bool?)((FitDNA?.Value as object) == null));
            var w_ = context?.Operators.Not(v_);
            var x_ = context?.Operators.And(u_, 
				w_);
            var y_ = (FitDNA?.Effective as object);
            var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(y_);
            var aa_ = this.Measurement_Period();
            var ab_ = context?.Operators.End(aa_);
            var ac_ = context?.Operators.Quantity(3m, 
				"years");
            var ad_ = context?.Operators.Subtract(ab_, 
				ac_);
            var ag_ = context?.Operators.Interval(ad_, 
				ab_, 
				true, 
				true);
            var ah_ = context?.Operators.ElementInInterval<CqlDateTime>(z_, 
				ag_, 
				"day");
            bool? ai_ = ((bool?)(context?.Operators.End(aa_) == null));
            var ak_ = context?.Operators.Not(ai_);
            var al_ = context?.Operators.And(ah_, 
				ak_);
            return context?.Operators.And(x_, 
				al_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			am_);
    }
    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset.Value;

    private IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset_Value()
    {
        var a_ = this.FIT_DNA();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> ac_ = (FitDNA) => 
        {
            var d_ = (FitDNA?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
			} as IEnumerable<string>);
            var j_ = context?.Operators.InList<string>(e_, 
				f_);
            var k_ = context?.Operators.Not(j_);
            bool? l_ = ((bool?)((FitDNA?.Value as object) == null));
            var m_ = context?.Operators.Not(l_);
            var n_ = context?.Operators.And(k_, 
				m_);
            var o_ = (FitDNA?.Effective as object);
            var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(o_);
            var q_ = this.Measurement_Period();
            var r_ = context?.Operators.End(q_);
            var s_ = context?.Operators.Quantity(3m, 
				"years");
            var t_ = context?.Operators.Subtract(r_, 
				s_);
            var w_ = context?.Operators.Interval(t_, 
				r_, 
				true, 
				true);
            var x_ = context?.Operators.ElementInInterval<CqlDateTime>(p_, 
				w_, 
				"day");
            bool? y_ = ((bool?)(context?.Operators.End(q_) == null));
            var aa_ = context?.Operators.Not(y_);
            var ab_ = context?.Operators.And(x_, 
				aa_);
            return context?.Operators.And(n_, 
				ab_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			ac_);
    }
    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
    public IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset() => __Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset.Value;

    private IEnumerable<CqlDateTime> CT_Colonography_Display_Date_Value()
    {
        var a_ = this.CT_Colonography();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> r_ = (Colonography) => 
        {
            var d_ = (Colonography?.Effective as object);
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(d_);
            var f_ = context?.Operators.End(e_);
            var g_ = this.Measurement_Period();
            var h_ = context?.Operators.End(g_);
            var i_ = context?.Operators.Quantity(6m, 
				"years");
            var j_ = context?.Operators.Subtract(h_, 
				i_);
            var m_ = context?.Operators.Interval(j_, 
				h_, 
				true, 
				true);
            var n_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, 
				m_, 
				null);
            bool? o_ = ((bool?)(context?.Operators.End(g_) == null));
            var q_ = context?.Operators.Not(o_);
            return context?.Operators.And(n_, 
				q_);
        };
        var s_ = context?.Operators.WhereOrNull<Observation>(c_, 
			r_);
        Func<Observation,CqlDateTime> u_ = (Colonography) => 
        {
            var t_ = (Colonography?.Effective as object);
            return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(t_);
        };
        return context?.Operators.SelectOrNull<Observation, CqlDateTime>(s_, 
			u_);
    }
    [CqlDeclaration("CT Colonography Display Date")]
    public IEnumerable<CqlDateTime> CT_Colonography_Display_Date() => __CT_Colonography_Display_Date.Value;

    private IEnumerable<Observation> CT_Colonography_Performed_Value()
    {
        var a_ = this.CT_Colonography();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> aa_ = (Colonography) => 
        {
            var d_ = (Colonography?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var j_ = "appended";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
				j_,
			} as IEnumerable<string>);
            var k_ = context?.Operators.InList<string>(e_, 
				f_);
            var l_ = (Colonography?.Effective as object);
            var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(l_);
            var n_ = context?.Operators.End(m_);
            var o_ = this.Measurement_Period();
            var p_ = context?.Operators.End(o_);
            var q_ = context?.Operators.Quantity(5m, 
				"years");
            var r_ = context?.Operators.Subtract(p_, 
				q_);
            var u_ = context?.Operators.Interval(r_, 
				p_, 
				true, 
				true);
            var v_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, 
				u_, 
				null);
            bool? w_ = ((bool?)(context?.Operators.End(o_) == null));
            var y_ = context?.Operators.Not(w_);
            var z_ = context?.Operators.And(v_, 
				y_);
            return context?.Operators.And(k_, 
				z_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			aa_);
    }
    [CqlDeclaration("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed() => __CT_Colonography_Performed.Value;

    private IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status_Value()
    {
        var a_ = this.CT_Colonography();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> ab_ = (Colonography) => 
        {
            var d_ = (Colonography?.StatusElement as object);
            var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
            var g_ = "final";
            var h_ = "amended";
            var i_ = "corrected";
            var j_ = "appended";
            var f_ = (new string[]
			{
				g_,
				h_,
				i_,
				j_,
			} as IEnumerable<string>);
            var k_ = context?.Operators.InList<string>(e_, 
				f_);
            var l_ = context?.Operators.Not(k_);
            var m_ = (Colonography?.Effective as object);
            var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
            var o_ = context?.Operators.End(n_);
            var p_ = this.Measurement_Period();
            var q_ = context?.Operators.End(p_);
            var r_ = context?.Operators.Quantity(5m, 
				"years");
            var s_ = context?.Operators.Subtract(q_, 
				r_);
            var v_ = context?.Operators.Interval(s_, 
				q_, 
				true, 
				true);
            var w_ = context?.Operators.ElementInInterval<CqlDateTime>(o_, 
				v_, 
				null);
            bool? x_ = ((bool?)(context?.Operators.End(p_) == null));
            var z_ = context?.Operators.Not(x_);
            var aa_ = context?.Operators.And(w_, 
				z_);
            return context?.Operators.And(l_, 
				aa_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			ab_);
    }
    [CqlDeclaration("CT Colonography Performed without appropriate status")]
    public IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status() => __CT_Colonography_Performed_without_appropriate_status.Value;

    private IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date_Value()
    {
        var a_ = this.Flexible_Sigmoidoscopy();
        var b_ = typeof(Procedure).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, 
			b_);
        Func<Procedure,bool?> r_ = (FlexibleSigmoidoscopy) => 
        {
            var d_ = (FlexibleSigmoidoscopy?.Performed as object);
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(d_);
            var f_ = context?.Operators.End(e_);
            var g_ = this.Measurement_Period();
            var h_ = context?.Operators.End(g_);
            var i_ = context?.Operators.Quantity(6m, 
				"years");
            var j_ = context?.Operators.Subtract(h_, 
				i_);
            var m_ = context?.Operators.Interval(j_, 
				h_, 
				true, 
				true);
            var n_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, 
				m_, 
				null);
            bool? o_ = ((bool?)(context?.Operators.End(g_) == null));
            var q_ = context?.Operators.Not(o_);
            return context?.Operators.And(n_, 
				q_);
        };
        var s_ = context?.Operators.WhereOrNull<Procedure>(c_, 
			r_);
        Func<Procedure,CqlDateTime> u_ = (FlexibleSigmoidoscopy) => 
        {
            var t_ = (FlexibleSigmoidoscopy?.Performed as object);
            return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(t_);
        };
        return context?.Operators.SelectOrNull<Procedure, CqlDateTime>(s_, 
			u_);
    }
    [CqlDeclaration("Flexible Sigmoidoscopy Display Date")]
    public IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date() => __Flexible_Sigmoidoscopy_Display_Date.Value;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_Value()
    {
        var a_ = this.Flexible_Sigmoidoscopy();
        var b_ = typeof(Procedure).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, 
			b_);
        Func<Procedure,bool?> w_ = (FlexibleSigmoidoscopy) => 
        {
            var e_ = (FlexibleSigmoidoscopy?.StatusElement as object);
            var d_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_) as object);
            var f_ = ("completed" as object);
            var g_ = context?.Operators.Equal(d_, 
				f_);
            var h_ = (FlexibleSigmoidoscopy?.Performed as object);
            var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
            var j_ = context?.Operators.End(i_);
            var k_ = this.Measurement_Period();
            var l_ = context?.Operators.End(k_);
            var m_ = context?.Operators.Quantity(5m, 
				"years");
            var n_ = context?.Operators.Subtract(l_, 
				m_);
            var q_ = context?.Operators.Interval(n_, 
				l_, 
				true, 
				true);
            var r_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, 
				q_, 
				null);
            bool? s_ = ((bool?)(context?.Operators.End(k_) == null));
            var u_ = context?.Operators.Not(s_);
            var v_ = context?.Operators.And(r_, 
				u_);
            return context?.Operators.And(g_, 
				v_);
        };
        return context?.Operators.WhereOrNull<Procedure>(c_, 
			w_);
    }
    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed() => __Flexible_Sigmoidoscopy_Performed.Value;

    private IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status_Value()
    {
        var a_ = this.Flexible_Sigmoidoscopy();
        var b_ = typeof(Procedure).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, 
			b_);
        Func<Procedure,bool?> x_ = (FlexibleSigmoidoscopy) => 
        {
            var e_ = (FlexibleSigmoidoscopy?.StatusElement as object);
            var d_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_) as object);
            var f_ = ("completed" as object);
            var g_ = context?.Operators.Equal(d_, 
				f_);
            var h_ = context?.Operators.Not(g_);
            var i_ = (FlexibleSigmoidoscopy?.Performed as object);
            var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
            var k_ = context?.Operators.End(j_);
            var l_ = this.Measurement_Period();
            var m_ = context?.Operators.End(l_);
            var n_ = context?.Operators.Quantity(5m, 
				"years");
            var o_ = context?.Operators.Subtract(m_, 
				n_);
            var r_ = context?.Operators.Interval(o_, 
				m_, 
				true, 
				true);
            var s_ = context?.Operators.ElementInInterval<CqlDateTime>(k_, 
				r_, 
				null);
            bool? t_ = ((bool?)(context?.Operators.End(l_) == null));
            var v_ = context?.Operators.Not(t_);
            var w_ = context?.Operators.And(s_, 
				v_);
            return context?.Operators.And(h_, 
				w_);
        };
        return context?.Operators.WhereOrNull<Procedure>(c_, 
			x_);
    }
    [CqlDeclaration("Flexible Sigmoidoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status() => __Flexible_Sigmoidoscopy_Performed_without_appropriate_status.Value;

    private IEnumerable<CqlDateTime> Colonoscopy_Display_Date_Value()
    {
        var a_ = this.Colonoscopy();
        var b_ = typeof(Procedure).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, 
			b_);
        Func<Procedure,bool?> r_ = (Colonoscopy) => 
        {
            var d_ = (Colonoscopy?.Performed as object);
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(d_);
            var f_ = context?.Operators.End(e_);
            var g_ = this.Measurement_Period();
            var h_ = context?.Operators.End(g_);
            var i_ = context?.Operators.Quantity(11m, 
				"years");
            var j_ = context?.Operators.Subtract(h_, 
				i_);
            var m_ = context?.Operators.Interval(j_, 
				h_, 
				true, 
				true);
            var n_ = context?.Operators.ElementInInterval<CqlDateTime>(f_, 
				m_, 
				null);
            bool? o_ = ((bool?)(context?.Operators.End(g_) == null));
            var q_ = context?.Operators.Not(o_);
            return context?.Operators.And(n_, 
				q_);
        };
        var s_ = context?.Operators.WhereOrNull<Procedure>(c_, 
			r_);
        Func<Procedure,CqlDateTime> u_ = (Colonoscopy) => 
        {
            var t_ = (Colonoscopy?.Performed as object);
            return MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(t_);
        };
        return context?.Operators.SelectOrNull<Procedure, CqlDateTime>(s_, 
			u_);
    }
    [CqlDeclaration("Colonoscopy Display Date")]
    public IEnumerable<CqlDateTime> Colonoscopy_Display_Date() => __Colonoscopy_Display_Date.Value;

    private IEnumerable<Procedure> Colonoscopy_Performed_Value()
    {
        var a_ = this.Colonoscopy();
        var b_ = typeof(Procedure).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, 
			b_);
        Func<Procedure,bool?> w_ = (Colonoscopy) => 
        {
            var e_ = (Colonoscopy?.StatusElement as object);
            var d_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_) as object);
            var f_ = ("completed" as object);
            var g_ = context?.Operators.Equal(d_, 
				f_);
            var h_ = (Colonoscopy?.Performed as object);
            var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(h_);
            var j_ = context?.Operators.End(i_);
            var k_ = this.Measurement_Period();
            var l_ = context?.Operators.End(k_);
            var m_ = context?.Operators.Quantity(10m, 
				"years");
            var n_ = context?.Operators.Subtract(l_, 
				m_);
            var q_ = context?.Operators.Interval(n_, 
				l_, 
				true, 
				true);
            var r_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, 
				q_, 
				null);
            bool? s_ = ((bool?)(context?.Operators.End(k_) == null));
            var u_ = context?.Operators.Not(s_);
            var v_ = context?.Operators.And(r_, 
				u_);
            return context?.Operators.And(g_, 
				v_);
        };
        return context?.Operators.WhereOrNull<Procedure>(c_, 
			w_);
    }
    [CqlDeclaration("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed() => __Colonoscopy_Performed.Value;

    private IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status_Value()
    {
        var a_ = this.Colonoscopy();
        var b_ = typeof(Procedure).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, 
			b_);
        Func<Procedure,bool?> x_ = (Colonoscopy) => 
        {
            var e_ = (Colonoscopy?.StatusElement as object);
            var d_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(e_) as object);
            var f_ = ("completed" as object);
            var g_ = context?.Operators.Equal(d_, 
				f_);
            var h_ = context?.Operators.Not(g_);
            var i_ = (Colonoscopy?.Performed as object);
            var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
            var k_ = context?.Operators.End(j_);
            var l_ = this.Measurement_Period();
            var m_ = context?.Operators.End(l_);
            var n_ = context?.Operators.Quantity(10m, 
				"years");
            var o_ = context?.Operators.Subtract(m_, 
				n_);
            var r_ = context?.Operators.Interval(o_, 
				m_, 
				true, 
				true);
            var s_ = context?.Operators.ElementInInterval<CqlDateTime>(k_, 
				r_, 
				null);
            bool? t_ = ((bool?)(context?.Operators.End(l_) == null));
            var v_ = context?.Operators.Not(t_);
            var w_ = context?.Operators.And(s_, 
				v_);
            return context?.Operators.And(h_, 
				w_);
        };
        return context?.Operators.WhereOrNull<Procedure>(c_, 
			x_);
    }
    [CqlDeclaration("Colonoscopy Performed without appropriate status")]
    public IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status() => __Colonoscopy_Performed_without_appropriate_status.Value;

    private bool? Numerator_Value()
    {
        var a_ = this.Colonoscopy_Performed();
        var b_ = context?.Operators.ExistsInList<Procedure>(a_);
        var c_ = this.Fecal_Occult_Blood_Test_Performed();
        var d_ = context?.Operators.ExistsInList<Observation>(c_);
        var e_ = context?.Operators.Or(b_, 
			d_);
        var f_ = this.Flexible_Sigmoidoscopy_Performed();
        var g_ = context?.Operators.ExistsInList<Procedure>(f_);
        var h_ = context?.Operators.Or(e_, 
			g_);
        var i_ = this.Fecal_Immunochemical_Test_DNA_Performed();
        var j_ = context?.Operators.ExistsInList<Observation>(i_);
        var k_ = context?.Operators.Or(h_, 
			j_);
        var l_ = this.CT_Colonography_Performed();
        var m_ = context?.Operators.ExistsInList<Observation>(l_);
        return context?.Operators.Or(k_, 
			m_);
    }
    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    private bool? Final_Numerator_Population_Value()
    {
        var a_ = this.Numerator();
        var b_ = this.Initial_Population();
        var c_ = context?.Operators.And(a_, 
			b_);
        var d_ = this.Denominator();
        var e_ = context?.Operators.And(c_, 
			d_);
        var f_ = this.Denominator_Exclusions();
        var g_ = context?.Operators.Not(f_);
        return context?.Operators.And(e_, 
			g_);
    }
    [CqlDeclaration("Final Numerator Population")]
    public bool? Final_Numerator_Population() => __Final_Numerator_Population.Value;

}