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

    private CqlValueSet Acute_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

		return a_;
	}

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
    public CqlValueSet Acute_Inpatient() => __Acute_Inpatient.Value;

    private CqlValueSet Advanced_Illness_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

		return a_;
	}

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
    public CqlValueSet Advanced_Illness() => __Advanced_Illness.Value;

    private CqlValueSet Annual_Wellness_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

		return a_;
	}

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit() => __Annual_Wellness_Visit.Value;

    private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

		return a_;
	}

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Colonoscopy_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

		return a_;
	}

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
    public CqlValueSet Colonoscopy() => __Colonoscopy.Value;

    private CqlValueSet CT_Colonography_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

		return a_;
	}

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
    public CqlValueSet CT_Colonography() => __CT_Colonography.Value;

    private CqlValueSet Dementia_Medications_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

		return a_;
	}

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
    public CqlValueSet Dementia_Medications() => __Dementia_Medications.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

		return a_;
	}

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

		return a_;
	}

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Encounter_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

		return a_;
	}

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Fecal_Occult_Blood_Test__FOBT__Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

		return a_;
	}

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
    public CqlValueSet Fecal_Occult_Blood_Test__FOBT_() => __Fecal_Occult_Blood_Test__FOBT_.Value;

    private CqlValueSet FIT_DNA_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

		return a_;
	}

    [CqlDeclaration("FIT DNA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
    public CqlValueSet FIT_DNA() => __FIT_DNA.Value;

    private CqlValueSet Flexible_Sigmoidoscopy_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

		return a_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
    public CqlValueSet Flexible_Sigmoidoscopy() => __Flexible_Sigmoidoscopy.Value;

    private CqlValueSet Frailty_Device_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

		return a_;
	}

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
    public CqlValueSet Frailty_Device() => __Frailty_Device.Value;

    private CqlValueSet Frailty_Diagnosis_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

		return a_;
	}

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
    public CqlValueSet Frailty_Diagnosis() => __Frailty_Diagnosis.Value;

    private CqlValueSet Frailty_Encounter_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

		return a_;
	}

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
    public CqlValueSet Frailty_Encounter() => __Frailty_Encounter.Value;

    private CqlValueSet Frailty_Symptom_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

		return a_;
	}

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
    public CqlValueSet Frailty_Symptom() => __Frailty_Symptom.Value;

    private CqlValueSet Home_Healthcare_Services_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

		return a_;
	}

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet Hospice_care_ambulatory_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

		return a_;
	}

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_care_ambulatory() => __Hospice_care_ambulatory.Value;

    private CqlValueSet Malignant_Neoplasm_of_Colon_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

		return a_;
	}

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
    public CqlValueSet Malignant_Neoplasm_of_Colon() => __Malignant_Neoplasm_of_Colon.Value;

    private CqlValueSet Nonacute_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

		return a_;
	}

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
    public CqlValueSet Nonacute_Inpatient() => __Nonacute_Inpatient.Value;

    private CqlValueSet Nursing_Facility_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

		return a_;
	}

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Observation_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

		return a_;
	}

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
    public CqlValueSet Observation() => __Observation.Value;

    private CqlValueSet Office_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

		return a_;
	}

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Online_Assessments_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

		return a_;
	}

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Outpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

		return a_;
	}

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
    public CqlValueSet Outpatient() => __Outpatient.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

		return a_;
	}

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlValueSet Total_Colectomy_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

		return a_;
	}

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
    public CqlValueSet Total_Colectomy() => __Total_Colectomy.Value;

    private CqlValueSet Total_Colectomy_ICD9_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", null);

		return a_;
	}

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
		var a_ = (int?)2021;
		var b_ = (int?)1;
		var d_ = (int?)0;
		var h_ = context.Operators;
		var i_ = h_.ConvertIntegerToDecimal(default);
		var k_ = h_.DateTime(a_, b_, b_, d_, d_, d_, d_, i_);
		var l_ = (int?)2022;
		var t_ = h_.ConvertIntegerToDecimal(default);
		var v_ = h_.DateTime(l_, b_, b_, d_, d_, d_, d_, t_);
		var x_ = h_.Interval(k_, v_, true, false);
		var y_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", x_);
		var z_ = (CqlInterval<CqlDateTime>)y_;

		return z_;
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
		var i_ = (Encounter TelehealthEncounter) =>
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
		var n_ = (int?)51;
		var o_ = (int?)75;
		var q_ = d_.Interval(n_, o_, true, false);
		var s_ = d_.ElementInInterval<int?>(m_, q_, null);
		var t_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var u_ = this.Telehealth_Services();
		var w_ = d_.ListUnion<Encounter>(t_, u_);
		var y_ = d_.ExistsInList<Encounter>(w_);
		var aa_ = d_.And(s_, y_);

		return aa_;
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
		var d_ = (Condition ColorectalCancer) =>
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
		var d_ = (Procedure Colectomy) =>
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
		var d_ = (Condition ColectomyDx) =>
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
		var ag_ = af_;
		var ah_ = (int?)65;
		var ai_ = ah_;
		var ak_ = c_.GreaterOrEqual(ag_, ai_);
		var al_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var an_ = c_.And(ak_, al_);
		var ap_ = c_.Or(s_, an_);
		var aq_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var as_ = c_.Or(ap_, aq_);

		return as_;
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status_Value()
	{
		var a_ = this.Fecal_Occult_Blood_Test__FOBT_();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation FecalOccult) =>
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
		var g_ = (Observation FecalOccult) =>
		{
			var z_ = FecalOccult.Effective;
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(z_);
			var ab_ = FecalOccult.Value;
			var ac_ = context.Operators;
			var ad_ = ac_.LateBoundProperty<IEnumerable<Coding>>(ab_, "coding");
			var ae_ = (Coding @this) =>
			{
				var bi_ = @this.DisplayElement;
				var bj_ = (bi_ == null);
				var bk_ = (bool?)bj_;
				var bl_ = context.Operators;
				var bm_ = bl_.Not(bk_);

				return bm_;
			};
			var ag_ = ac_.WhereOrNull<Coding>(ad_, ae_);
			var ah_ = (Coding @this) =>
			{
				var bn_ = @this.DisplayElement;

				return bn_;
			};
			var aj_ = ac_.SelectOrNull<Coding, FhirString>(ag_, ah_);
			var ak_ = FecalOccult.Category;
			var al_ = (ak_ as IEnumerable<CodeableConcept>);
			var am_ = (CodeableConcept @this) =>
			{
				var bo_ = @this.Coding;
				var bp_ = (bo_ == null);
				var bq_ = (bool?)bp_;
				var br_ = context.Operators;
				var bs_ = br_.Not(bq_);

				return bs_;
			};
			var ao_ = ac_.WhereOrNull<CodeableConcept>(al_, am_);
			var ap_ = (CodeableConcept @this) =>
			{
				var bt_ = @this.Coding;

				return bt_;
			};
			var ar_ = ac_.SelectOrNull<CodeableConcept, List<Coding>>(ao_, ap_);
			var at_ = ac_.FlattenList<Coding>(ar_);
			var au_ = (Coding @this) =>
			{
				var bu_ = @this.CodeElement;
				var bv_ = (bu_ == null);
				var bw_ = (bool?)bv_;
				var bx_ = context.Operators;
				var by_ = bx_.Not(bw_);

				return by_;
			};
			var aw_ = ac_.WhereOrNull<Coding>(at_, au_);
			var ax_ = (Coding @this) =>
			{
				var bz_ = @this.CodeElement;

				return bz_;
			};
			var az_ = ac_.SelectOrNull<Coding, Code>(aw_, ax_);
			var ba_ = (Code @this) =>
			{
				var ca_ = @this.Value;
				var cb_ = (ca_ == null);
				var cc_ = (bool?)cb_;
				var cd_ = context.Operators;
				var ce_ = cd_.Not(cc_);

				return ce_;
			};
			var bc_ = ac_.WhereOrNull<Code>(az_, ba_);
			var bd_ = (Code @this) =>
			{
				var cf_ = @this.Value;

				return cf_;
			};
			var bf_ = ac_.SelectOrNull<Code, string>(bc_, bd_);
			var bg_ = FecalOccult.StatusElement;
			var bh_ = new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = aa_,
				occultResult = aj_,
				occultCategoryCode = bf_,
				occultStatus = bg_,
			};

			return bh_;
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
		var d_ = (Observation FecalOccult) =>
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
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var q_ = FecalOccult.Category;
			var r_ = (q_ as IEnumerable<CodeableConcept>);
			var s_ = (CodeableConcept FecalOccultCategory) =>
			{
				var an_ = FecalOccultCategory.Coding;
				var ao_ = (an_ as IEnumerable<Coding>);
				var ap_ = (Coding @this) =>
				{
					var bf_ = @this.CodeElement;
					var bg_ = (bf_ == null);
					var bh_ = (bool?)bg_;
					var bi_ = context.Operators;
					var bj_ = bi_.Not(bh_);

					return bj_;
				};
				var aq_ = context.Operators;
				var ar_ = aq_.WhereOrNull<Coding>(ao_, ap_);
				var as_ = (Coding @this) =>
				{
					var bk_ = @this.CodeElement;

					return bk_;
				};
				var au_ = aq_.SelectOrNull<Coding, Code>(ar_, as_);
				var av_ = (Code @this) =>
				{
					var bl_ = @this.Value;
					var bm_ = (bl_ == null);
					var bn_ = (bool?)bm_;
					var bo_ = context.Operators;
					var bp_ = bo_.Not(bn_);

					return bp_;
				};
				var ax_ = aq_.WhereOrNull<Code>(au_, av_);
				var ay_ = (Code @this) =>
				{
					var bq_ = @this.Value;

					return bq_;
				};
				var ba_ = aq_.SelectOrNull<Code, string>(ax_, ay_);
				var bb_ = new string[]
				{
					"laboratory",
				};
				var bc_ = (bb_ as IEnumerable<string>);
				var be_ = aq_.ListEquivalent<string>(ba_, bc_);

				return be_;
			};
			var u_ = o_.WhereOrNull<CodeableConcept>(r_, s_);
			var w_ = o_.ExistsInList<CodeableConcept>(u_);
			var y_ = o_.And(p_, w_);
			var z_ = FecalOccult.Value;
			var aa_ = (z_ == null);
			var ab_ = (bool?)aa_;
			var ad_ = o_.Not(ab_);
			var af_ = o_.And(y_, ad_);
			var ag_ = FecalOccult.Effective;
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ag_);
			var ai_ = this.Measurement_Period();
			var ak_ = o_.ElementInInterval<CqlDateTime>(ah_, ai_, null);
			var am_ = o_.And(af_, ak_);

			return am_;
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
		var d_ = (Observation FecalOccult) =>
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
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var q_ = FecalOccult.Category;
			var r_ = (q_ as IEnumerable<CodeableConcept>);
			var s_ = (CodeableConcept FecalOccultCategory) =>
			{
				var an_ = FecalOccultCategory.Coding;
				var ao_ = (an_ as IEnumerable<Coding>);
				var ap_ = (Coding @this) =>
				{
					var bf_ = @this.CodeElement;
					var bg_ = (bf_ == null);
					var bh_ = (bool?)bg_;
					var bi_ = context.Operators;
					var bj_ = bi_.Not(bh_);

					return bj_;
				};
				var aq_ = context.Operators;
				var ar_ = aq_.WhereOrNull<Coding>(ao_, ap_);
				var as_ = (Coding @this) =>
				{
					var bk_ = @this.CodeElement;

					return bk_;
				};
				var au_ = aq_.SelectOrNull<Coding, Code>(ar_, as_);
				var av_ = (Code @this) =>
				{
					var bl_ = @this.Value;
					var bm_ = (bl_ == null);
					var bn_ = (bool?)bm_;
					var bo_ = context.Operators;
					var bp_ = bo_.Not(bn_);

					return bp_;
				};
				var ax_ = aq_.WhereOrNull<Code>(au_, av_);
				var ay_ = (Code @this) =>
				{
					var bq_ = @this.Value;

					return bq_;
				};
				var ba_ = aq_.SelectOrNull<Code, string>(ax_, ay_);
				var bb_ = new string[]
				{
					"laboratory",
				};
				var bc_ = (bb_ as IEnumerable<string>);
				var be_ = aq_.ListEquivalent<string>(ba_, bc_);

				return be_;
			};
			var u_ = o_.WhereOrNull<CodeableConcept>(r_, s_);
			var w_ = o_.ExistsInList<CodeableConcept>(u_);
			var y_ = o_.And(p_, w_);
			var z_ = FecalOccult.Value;
			var aa_ = (z_ == null);
			var ab_ = (bool?)aa_;
			var ad_ = o_.Not(ab_);
			var af_ = o_.And(y_, ad_);
			var ag_ = FecalOccult.Effective;
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ag_);
			var ai_ = this.Measurement_Period();
			var ak_ = o_.ElementInInterval<CqlDateTime>(ah_, ai_, "day");
			var am_ = o_.And(af_, ak_);

			return am_;
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
		var d_ = (Observation FecalOccult) =>
		{
			var g_ = FecalOccult.Category;
			var h_ = (g_ as IEnumerable<CodeableConcept>);
			var i_ = (CodeableConcept FecalOccultCategory) =>
			{
				var ab_ = FecalOccultCategory.Coding;
				var ac_ = (ab_ as IEnumerable<Coding>);
				var ad_ = (Coding @this) =>
				{
					var av_ = @this.CodeElement;
					var aw_ = (av_ == null);
					var ax_ = (bool?)aw_;
					var ay_ = context.Operators;
					var az_ = ay_.Not(ax_);

					return az_;
				};
				var ae_ = context.Operators;
				var af_ = ae_.WhereOrNull<Coding>(ac_, ad_);
				var ag_ = (Coding @this) =>
				{
					var ba_ = @this.CodeElement;

					return ba_;
				};
				var ai_ = ae_.SelectOrNull<Coding, Code>(af_, ag_);
				var aj_ = (Code @this) =>
				{
					var bb_ = @this.Value;
					var bc_ = (bb_ == null);
					var bd_ = (bool?)bc_;
					var be_ = context.Operators;
					var bf_ = be_.Not(bd_);

					return bf_;
				};
				var al_ = ae_.WhereOrNull<Code>(ai_, aj_);
				var am_ = (Code @this) =>
				{
					var bg_ = @this.Value;

					return bg_;
				};
				var ao_ = ae_.SelectOrNull<Code, string>(al_, am_);
				var ap_ = new string[]
				{
					"laboratory",
				};
				var aq_ = (ap_ as IEnumerable<string>);
				var as_ = ae_.ListEquivalent<string>(ao_, aq_);
				var au_ = ae_.Not(as_);

				return au_;
			};
			var j_ = context.Operators;
			var k_ = j_.WhereOrNull<CodeableConcept>(h_, i_);
			var m_ = j_.ExistsInList<CodeableConcept>(k_);
			var n_ = FecalOccult.Value;
			var o_ = (n_ == null);
			var p_ = (bool?)o_;
			var r_ = j_.Not(p_);
			var t_ = j_.And(m_, r_);
			var u_ = FecalOccult.Effective;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(u_);
			var w_ = this.Measurement_Period();
			var y_ = j_.ElementInInterval<CqlDateTime>(v_, w_, "day");
			var aa_ = j_.And(t_, y_);

			return aa_;
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
		var d_ = (Observation FecalOccult) =>
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
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var r_ = o_.Not(p_);
			var s_ = FecalOccult.Value;
			var t_ = (s_ == null);
			var u_ = (bool?)t_;
			var w_ = o_.Not(u_);
			var y_ = o_.And(r_, w_);
			var z_ = FecalOccult.Effective;
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(z_);
			var ab_ = this.Measurement_Period();
			var ad_ = o_.ElementInInterval<CqlDateTime>(aa_, ab_, "day");
			var af_ = o_.And(y_, ad_);

			return af_;
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
		var d_ = (Observation FitDNA) =>
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
			var ad_ = (bool?)ac_;
			var af_ = m_.Not(ad_);
			var ah_ = m_.And(y_, af_);

			return ah_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var g_ = (Observation FitDNA) =>
		{
			var ai_ = FitDNA.Effective;
			var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ai_);
			var ak_ = FitDNA.Value;
			var al_ = context.Operators;
			var am_ = al_.LateBoundProperty<IEnumerable<Coding>>(ak_, "coding");
			var an_ = (Coding @this) =>
			{
				var br_ = @this.DisplayElement;
				var bs_ = (br_ == null);
				var bt_ = (bool?)bs_;
				var bu_ = context.Operators;
				var bv_ = bu_.Not(bt_);

				return bv_;
			};
			var ap_ = al_.WhereOrNull<Coding>(am_, an_);
			var aq_ = (Coding @this) =>
			{
				var bw_ = @this.DisplayElement;

				return bw_;
			};
			var as_ = al_.SelectOrNull<Coding, FhirString>(ap_, aq_);
			var at_ = FitDNA.Category;
			var au_ = (at_ as IEnumerable<CodeableConcept>);
			var av_ = (CodeableConcept @this) =>
			{
				var bx_ = @this.Coding;
				var by_ = (bx_ == null);
				var bz_ = (bool?)by_;
				var ca_ = context.Operators;
				var cb_ = ca_.Not(bz_);

				return cb_;
			};
			var ax_ = al_.WhereOrNull<CodeableConcept>(au_, av_);
			var ay_ = (CodeableConcept @this) =>
			{
				var cc_ = @this.Coding;

				return cc_;
			};
			var ba_ = al_.SelectOrNull<CodeableConcept, List<Coding>>(ax_, ay_);
			var bc_ = al_.FlattenList<Coding>(ba_);
			var bd_ = (Coding @this) =>
			{
				var cd_ = @this.CodeElement;
				var ce_ = (cd_ == null);
				var cf_ = (bool?)ce_;
				var cg_ = context.Operators;
				var ch_ = cg_.Not(cf_);

				return ch_;
			};
			var bf_ = al_.WhereOrNull<Coding>(bc_, bd_);
			var bg_ = (Coding @this) =>
			{
				var ci_ = @this.CodeElement;

				return ci_;
			};
			var bi_ = al_.SelectOrNull<Coding, Code>(bf_, bg_);
			var bj_ = (Code @this) =>
			{
				var cj_ = @this.Value;
				var ck_ = (cj_ == null);
				var cl_ = (bool?)ck_;
				var cm_ = context.Operators;
				var cn_ = cm_.Not(cl_);

				return cn_;
			};
			var bl_ = al_.WhereOrNull<Code>(bi_, bj_);
			var bm_ = (Code @this) =>
			{
				var co_ = @this.Value;

				return co_;
			};
			var bo_ = al_.SelectOrNull<Code, string>(bl_, bm_);
			var bp_ = FitDNA.StatusElement;
			var bq_ = new Tuples.Tuple_GHYDcaRJOeEdWbTSSCjjBhBFW
			{
				occultDate = aj_,
				occultResult = as_,
				occultCategoryCode = bo_,
				occultStatus = bp_,
			};

			return bq_;
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
		var d_ = (Observation FitDNA) =>
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
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var q_ = FitDNA.Category;
			var r_ = (q_ as IEnumerable<CodeableConcept>);
			var s_ = (CodeableConcept FitDNACategory) =>
			{
				var bh_ = FitDNACategory.Coding;
				var bi_ = (bh_ as IEnumerable<Coding>);
				var bj_ = (Coding @this) =>
				{
					var bz_ = @this.CodeElement;
					var ca_ = (bz_ == null);
					var cb_ = (bool?)ca_;
					var cc_ = context.Operators;
					var cd_ = cc_.Not(cb_);

					return cd_;
				};
				var bk_ = context.Operators;
				var bl_ = bk_.WhereOrNull<Coding>(bi_, bj_);
				var bm_ = (Coding @this) =>
				{
					var ce_ = @this.CodeElement;

					return ce_;
				};
				var bo_ = bk_.SelectOrNull<Coding, Code>(bl_, bm_);
				var bp_ = (Code @this) =>
				{
					var cf_ = @this.Value;
					var cg_ = (cf_ == null);
					var ch_ = (bool?)cg_;
					var ci_ = context.Operators;
					var cj_ = ci_.Not(ch_);

					return cj_;
				};
				var br_ = bk_.WhereOrNull<Code>(bo_, bp_);
				var bs_ = (Code @this) =>
				{
					var ck_ = @this.Value;

					return ck_;
				};
				var bu_ = bk_.SelectOrNull<Code, string>(br_, bs_);
				var bv_ = new string[]
				{
					"laboratory",
				};
				var bw_ = (bv_ as IEnumerable<string>);
				var by_ = bk_.ListEquivalent<string>(bu_, bw_);

				return by_;
			};
			var u_ = o_.WhereOrNull<CodeableConcept>(r_, s_);
			var w_ = o_.ExistsInList<CodeableConcept>(u_);
			var y_ = o_.And(p_, w_);
			var z_ = FitDNA.Value;
			var aa_ = (z_ == null);
			var ab_ = (bool?)aa_;
			var ad_ = o_.Not(ab_);
			var af_ = o_.And(y_, ad_);
			var ag_ = FitDNA.Effective;
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ag_);
			var ai_ = this.Measurement_Period();
			var ak_ = o_.End(ai_);
			var am_ = o_.Quantity(3m, "years");
			var ao_ = o_.Subtract(ak_, am_);
			var ar_ = o_.End(ai_);
			var at_ = o_.Interval(ao_, ar_, true, true);
			var av_ = o_.ElementInInterval<CqlDateTime>(ah_, at_, null);
			var ay_ = o_.End(ai_);
			var az_ = (ay_ == null);
			var ba_ = (bool?)az_;
			var bc_ = o_.Not(ba_);
			var be_ = o_.And(av_, bc_);
			var bg_ = o_.And(af_, be_);

			return bg_;
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
		var d_ = (Observation FitDNA) =>
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
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var q_ = FitDNA.Category;
			var r_ = (q_ as IEnumerable<CodeableConcept>);
			var s_ = (CodeableConcept FitDNACategory) =>
			{
				var bh_ = FitDNACategory.Coding;
				var bi_ = (bh_ as IEnumerable<Coding>);
				var bj_ = (Coding @this) =>
				{
					var bz_ = @this.CodeElement;
					var ca_ = (bz_ == null);
					var cb_ = (bool?)ca_;
					var cc_ = context.Operators;
					var cd_ = cc_.Not(cb_);

					return cd_;
				};
				var bk_ = context.Operators;
				var bl_ = bk_.WhereOrNull<Coding>(bi_, bj_);
				var bm_ = (Coding @this) =>
				{
					var ce_ = @this.CodeElement;

					return ce_;
				};
				var bo_ = bk_.SelectOrNull<Coding, Code>(bl_, bm_);
				var bp_ = (Code @this) =>
				{
					var cf_ = @this.Value;
					var cg_ = (cf_ == null);
					var ch_ = (bool?)cg_;
					var ci_ = context.Operators;
					var cj_ = ci_.Not(ch_);

					return cj_;
				};
				var br_ = bk_.WhereOrNull<Code>(bo_, bp_);
				var bs_ = (Code @this) =>
				{
					var ck_ = @this.Value;

					return ck_;
				};
				var bu_ = bk_.SelectOrNull<Code, string>(br_, bs_);
				var bv_ = new string[]
				{
					"laboratory",
				};
				var bw_ = (bv_ as IEnumerable<string>);
				var by_ = bk_.ListEquivalent<string>(bu_, bw_);

				return by_;
			};
			var u_ = o_.WhereOrNull<CodeableConcept>(r_, s_);
			var w_ = o_.ExistsInList<CodeableConcept>(u_);
			var y_ = o_.And(p_, w_);
			var z_ = FitDNA.Value;
			var aa_ = (z_ == null);
			var ab_ = (bool?)aa_;
			var ad_ = o_.Not(ab_);
			var af_ = o_.And(y_, ad_);
			var ag_ = FitDNA.Effective;
			var ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ag_);
			var ai_ = this.Measurement_Period();
			var ak_ = o_.End(ai_);
			var am_ = o_.Quantity(3m, "years");
			var ao_ = o_.Subtract(ak_, am_);
			var ar_ = o_.End(ai_);
			var at_ = o_.Interval(ao_, ar_, true, true);
			var av_ = o_.ElementInInterval<CqlDateTime>(ah_, at_, "day");
			var ay_ = o_.End(ai_);
			var az_ = (ay_ == null);
			var ba_ = (bool?)az_;
			var bc_ = o_.Not(ba_);
			var be_ = o_.And(av_, bc_);
			var bg_ = o_.And(af_, be_);

			return bg_;
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
		var d_ = (Observation FitDNA) =>
		{
			var g_ = FitDNA.Category;
			var h_ = (g_ as IEnumerable<CodeableConcept>);
			var i_ = (CodeableConcept FitDNACategory) =>
			{
				var av_ = FitDNACategory.Coding;
				var aw_ = (av_ as IEnumerable<Coding>);
				var ax_ = (Coding @this) =>
				{
					var bp_ = @this.CodeElement;
					var bq_ = (bp_ == null);
					var br_ = (bool?)bq_;
					var bs_ = context.Operators;
					var bt_ = bs_.Not(br_);

					return bt_;
				};
				var ay_ = context.Operators;
				var az_ = ay_.WhereOrNull<Coding>(aw_, ax_);
				var ba_ = (Coding @this) =>
				{
					var bu_ = @this.CodeElement;

					return bu_;
				};
				var bc_ = ay_.SelectOrNull<Coding, Code>(az_, ba_);
				var bd_ = (Code @this) =>
				{
					var bv_ = @this.Value;
					var bw_ = (bv_ == null);
					var bx_ = (bool?)bw_;
					var by_ = context.Operators;
					var bz_ = by_.Not(bx_);

					return bz_;
				};
				var bf_ = ay_.WhereOrNull<Code>(bc_, bd_);
				var bg_ = (Code @this) =>
				{
					var ca_ = @this.Value;

					return ca_;
				};
				var bi_ = ay_.SelectOrNull<Code, string>(bf_, bg_);
				var bj_ = new string[]
				{
					"laboratory",
				};
				var bk_ = (bj_ as IEnumerable<string>);
				var bm_ = ay_.ListEquivalent<string>(bi_, bk_);
				var bo_ = ay_.Not(bm_);

				return bo_;
			};
			var j_ = context.Operators;
			var k_ = j_.WhereOrNull<CodeableConcept>(h_, i_);
			var m_ = j_.ExistsInList<CodeableConcept>(k_);
			var n_ = FitDNA.Value;
			var o_ = (n_ == null);
			var p_ = (bool?)o_;
			var r_ = j_.Not(p_);
			var t_ = j_.And(m_, r_);
			var u_ = FitDNA.Effective;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(u_);
			var w_ = this.Measurement_Period();
			var y_ = j_.End(w_);
			var aa_ = j_.Quantity(3m, "years");
			var ac_ = j_.Subtract(y_, aa_);
			var af_ = j_.End(w_);
			var ah_ = j_.Interval(ac_, af_, true, true);
			var aj_ = j_.ElementInInterval<CqlDateTime>(v_, ah_, "day");
			var am_ = j_.End(w_);
			var an_ = (am_ == null);
			var ao_ = (bool?)an_;
			var aq_ = j_.Not(ao_);
			var as_ = j_.And(aj_, aq_);
			var au_ = j_.And(t_, as_);

			return au_;
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
		var d_ = (Observation FitDNA) =>
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
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var r_ = o_.Not(p_);
			var s_ = FitDNA.Value;
			var t_ = (s_ == null);
			var u_ = (bool?)t_;
			var w_ = o_.Not(u_);
			var y_ = o_.And(r_, w_);
			var z_ = FitDNA.Effective;
			var aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(z_);
			var ab_ = this.Measurement_Period();
			var ad_ = o_.End(ab_);
			var af_ = o_.Quantity(3m, "years");
			var ah_ = o_.Subtract(ad_, af_);
			var ak_ = o_.End(ab_);
			var am_ = o_.Interval(ah_, ak_, true, true);
			var ao_ = o_.ElementInInterval<CqlDateTime>(aa_, am_, "day");
			var ar_ = o_.End(ab_);
			var as_ = (ar_ == null);
			var at_ = (bool?)as_;
			var av_ = o_.Not(at_);
			var ax_ = o_.And(ao_, av_);
			var az_ = o_.And(y_, ax_);

			return az_;
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
		var d_ = (Observation Colonography) =>
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
			var af_ = (bool?)ae_;
			var ah_ = l_.Not(af_);
			var aj_ = l_.And(aa_, ah_);

			return aj_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var g_ = (Observation Colonography) =>
		{
			var ak_ = Colonography.Effective;
			var al_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ak_);

			return al_;
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
		var d_ = (Observation Colonography) =>
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
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var q_ = Colonography.Effective;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var t_ = o_.End(r_);
			var u_ = this.Measurement_Period();
			var w_ = o_.End(u_);
			var y_ = o_.Quantity(5m, "years");
			var aa_ = o_.Subtract(w_, y_);
			var ad_ = o_.End(u_);
			var af_ = o_.Interval(aa_, ad_, true, true);
			var ah_ = o_.ElementInInterval<CqlDateTime>(t_, af_, null);
			var ak_ = o_.End(u_);
			var al_ = (ak_ == null);
			var am_ = (bool?)al_;
			var ao_ = o_.Not(am_);
			var aq_ = o_.And(ah_, ao_);
			var as_ = o_.And(p_, aq_);

			return as_;
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
		var d_ = (Observation Colonography) =>
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
			var n_ = (m_ as IEnumerable<string>);
			var o_ = context.Operators;
			var p_ = o_.InList<string>(l_, n_);
			var r_ = o_.Not(p_);
			var s_ = Colonography.Effective;
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
			var v_ = o_.End(t_);
			var w_ = this.Measurement_Period();
			var y_ = o_.End(w_);
			var aa_ = o_.Quantity(5m, "years");
			var ac_ = o_.Subtract(y_, aa_);
			var af_ = o_.End(w_);
			var ah_ = o_.Interval(ac_, af_, true, true);
			var aj_ = o_.ElementInInterval<CqlDateTime>(v_, ah_, null);
			var am_ = o_.End(w_);
			var an_ = (am_ == null);
			var ao_ = (bool?)an_;
			var aq_ = o_.Not(ao_);
			var as_ = o_.And(aj_, aq_);
			var au_ = o_.And(r_, as_);

			return au_;
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
		var d_ = (Procedure FlexibleSigmoidoscopy) =>
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
			var af_ = (bool?)ae_;
			var ah_ = l_.Not(af_);
			var aj_ = l_.And(aa_, ah_);

			return aj_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);
		var g_ = (Procedure FlexibleSigmoidoscopy) =>
		{
			var ak_ = FlexibleSigmoidoscopy.Performed;
			var al_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ak_);

			return al_;
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
		var d_ = (Procedure FlexibleSigmoidoscopy) =>
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
			var ak_ = (bool?)aj_;
			var am_ = m_.Not(ak_);
			var ao_ = m_.And(af_, am_);
			var aq_ = m_.And(n_, ao_);

			return aq_;
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
		var d_ = (Procedure FlexibleSigmoidoscopy) =>
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
			var am_ = (bool?)al_;
			var ao_ = m_.Not(am_);
			var aq_ = m_.And(ah_, ao_);
			var as_ = m_.And(p_, aq_);

			return as_;
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
		var d_ = (Procedure Colonoscopy) =>
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
			var af_ = (bool?)ae_;
			var ah_ = l_.Not(af_);
			var aj_ = l_.And(aa_, ah_);

			return aj_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Procedure>(c_, d_);
		var g_ = (Procedure Colonoscopy) =>
		{
			var ak_ = Colonoscopy.Performed;
			var al_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(ak_);

			return al_;
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
		var d_ = (Procedure Colonoscopy) =>
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
			var ak_ = (bool?)aj_;
			var am_ = m_.Not(ak_);
			var ao_ = m_.And(af_, am_);
			var aq_ = m_.And(n_, ao_);

			return aq_;
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
		var d_ = (Procedure Colonoscopy) =>
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
			var am_ = (bool?)al_;
			var ao_ = m_.Not(am_);
			var aq_ = m_.And(ah_, ao_);
			var as_ = m_.And(p_, aq_);

			return as_;
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