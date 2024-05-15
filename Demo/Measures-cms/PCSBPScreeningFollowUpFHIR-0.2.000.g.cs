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
[CqlLibrary("PCSBPScreeningFollowUpFHIR", "0.2.000")]
public class PCSBPScreeningFollowUpFHIR_0_2_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Diagnosis_of_Hypertension;
    internal Lazy<CqlValueSet> __Dietary_Recommendations;
    internal Lazy<CqlValueSet> __Encounter_to_Screen_for_Blood_Pressure;
    internal Lazy<CqlValueSet> __Finding_of_Elevated_Blood_Pressure_or_Hypertension;
    internal Lazy<CqlValueSet> __Follow_Up_Within_4_Weeks;
    internal Lazy<CqlValueSet> __Laboratory_Tests_for_Hypertension;
    internal Lazy<CqlValueSet> __Lifestyle_Recommendation;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Patient_Declined;
    internal Lazy<CqlValueSet> __Pharmacologic_Therapy_for_Hypertension;
    internal Lazy<CqlValueSet> __Recommendation_to_Increase_Physical_Activity;
    internal Lazy<CqlValueSet> __Referral_or_Counseling_for_Alcohol_Consumption;
    internal Lazy<CqlValueSet> __Referral_to_Primary_Care_or_Alternate_Provider;
    internal Lazy<CqlValueSet> __Weight_Reduction_Recommended;
    internal Lazy<CqlCode> __Diastolic_blood_pressure;
    internal Lazy<CqlCode> ___12_lead_EKG_panel;
    internal Lazy<CqlCode> __EKG_study;
    internal Lazy<CqlCode> __Follow_up_2_3_months__finding_;
    internal Lazy<CqlCode> __Follow_up_4_6_months__finding_;
    internal Lazy<CqlCode> __Systolic_blood_pressure;
    internal Lazy<CqlCode> __virtual;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_during_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Normal_Blood_Pressure_Reading;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80;
    internal Lazy<IEnumerable<ServiceRequest>> __Follow_up_with_Rescreen_in_2_to_6_Months;
    internal Lazy<IEnumerable<ServiceRequest>> __NonPharmacological_Interventions;
    internal Lazy<IEnumerable<ServiceRequest>> __Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Hypertensive_Reading_Within_Year_Prior;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80;
    internal Lazy<IEnumerable<ServiceRequest>> __First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89;
    internal Lazy<IEnumerable<ServiceRequest>> __Laboratory_Test_or_ECG_for_Hypertension;
    internal Lazy<IEnumerable<ServiceRequest>> __Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90;
    internal Lazy<IEnumerable<ServiceRequest>> __Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement;
    internal Lazy<IEnumerable<ServiceRequest>> __NonPharmacological_Intervention_Not_Ordered;
    internal Lazy<IEnumerable<ServiceRequest>> __Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered;
    internal Lazy<IEnumerable<ServiceRequest>> __Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined;
    internal Lazy<IEnumerable<object>> __Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exceptions;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public PCSBPScreeningFollowUpFHIR_0_2_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);

        __Diagnosis_of_Hypertension = new Lazy<CqlValueSet>(this.Diagnosis_of_Hypertension_Value);
        __Dietary_Recommendations = new Lazy<CqlValueSet>(this.Dietary_Recommendations_Value);
        __Encounter_to_Screen_for_Blood_Pressure = new Lazy<CqlValueSet>(this.Encounter_to_Screen_for_Blood_Pressure_Value);
        __Finding_of_Elevated_Blood_Pressure_or_Hypertension = new Lazy<CqlValueSet>(this.Finding_of_Elevated_Blood_Pressure_or_Hypertension_Value);
        __Follow_Up_Within_4_Weeks = new Lazy<CqlValueSet>(this.Follow_Up_Within_4_Weeks_Value);
        __Laboratory_Tests_for_Hypertension = new Lazy<CqlValueSet>(this.Laboratory_Tests_for_Hypertension_Value);
        __Lifestyle_Recommendation = new Lazy<CqlValueSet>(this.Lifestyle_Recommendation_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Patient_Declined = new Lazy<CqlValueSet>(this.Patient_Declined_Value);
        __Pharmacologic_Therapy_for_Hypertension = new Lazy<CqlValueSet>(this.Pharmacologic_Therapy_for_Hypertension_Value);
        __Recommendation_to_Increase_Physical_Activity = new Lazy<CqlValueSet>(this.Recommendation_to_Increase_Physical_Activity_Value);
        __Referral_or_Counseling_for_Alcohol_Consumption = new Lazy<CqlValueSet>(this.Referral_or_Counseling_for_Alcohol_Consumption_Value);
        __Referral_to_Primary_Care_or_Alternate_Provider = new Lazy<CqlValueSet>(this.Referral_to_Primary_Care_or_Alternate_Provider_Value);
        __Weight_Reduction_Recommended = new Lazy<CqlValueSet>(this.Weight_Reduction_Recommended_Value);
        __Diastolic_blood_pressure = new Lazy<CqlCode>(this.Diastolic_blood_pressure_Value);
        ___12_lead_EKG_panel = new Lazy<CqlCode>(this._12_lead_EKG_panel_Value);
        __EKG_study = new Lazy<CqlCode>(this.EKG_study_Value);
        __Follow_up_2_3_months__finding_ = new Lazy<CqlCode>(this.Follow_up_2_3_months__finding__Value);
        __Follow_up_4_6_months__finding_ = new Lazy<CqlCode>(this.Follow_up_4_6_months__finding__Value);
        __Systolic_blood_pressure = new Lazy<CqlCode>(this.Systolic_blood_pressure_Value);
        __virtual = new Lazy<CqlCode>(this.@virtual_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounter_during_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_during_Measurement_Period_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Encounter_with_Normal_Blood_Pressure_Reading = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Normal_Blood_Pressure_Reading_Value);
        __Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80 = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_Value);
        __Follow_up_with_Rescreen_in_2_to_6_Months = new Lazy<IEnumerable<ServiceRequest>>(this.Follow_up_with_Rescreen_in_2_to_6_Months_Value);
        __NonPharmacological_Interventions = new Lazy<IEnumerable<ServiceRequest>>(this.NonPharmacological_Interventions_Value);
        __Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading = new Lazy<IEnumerable<ServiceRequest>>(this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading_Value);
        __Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions_Value);
        __Encounter_with_Hypertensive_Reading_Within_Year_Prior = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Hypertensive_Reading_Within_Year_Prior_Value);
        __Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80 = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_Value);
        __First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional = new Lazy<IEnumerable<ServiceRequest>>(this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional_Value);
        __Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions_Value);
        __Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89 = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Value);
        __Laboratory_Test_or_ECG_for_Hypertension = new Lazy<IEnumerable<ServiceRequest>>(this.Laboratory_Test_or_ECG_for_Hypertension_Value);
        __Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions = new Lazy<IEnumerable<ServiceRequest>>(this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Value);
        __Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Value);
        __Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90 = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Value);
        __Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions = new Lazy<IEnumerable<ServiceRequest>>(this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Value);
        __Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement_Value);
        __NonPharmacological_Intervention_Not_Ordered = new Lazy<IEnumerable<ServiceRequest>>(this.NonPharmacological_Intervention_Not_Ordered_Value);
        __Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered = new Lazy<IEnumerable<ServiceRequest>>(this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered_Value);
        __Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined = new Lazy<IEnumerable<ServiceRequest>>(this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined_Value);
        __Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined = new Lazy<IEnumerable<object>>(this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined_Value);
        __Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient_Value);
        __Denominator_Exceptions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exceptions_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlValueSet Diagnosis_of_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263", null);

    [CqlDeclaration("Diagnosis of Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263")]
	public CqlValueSet Diagnosis_of_Hypertension() => 
		__Diagnosis_of_Hypertension.Value;

	private CqlValueSet Dietary_Recommendations_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515", null);

    [CqlDeclaration("Dietary Recommendations")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515")]
	public CqlValueSet Dietary_Recommendations() => 
		__Dietary_Recommendations.Value;

	private CqlValueSet Encounter_to_Screen_for_Blood_Pressure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920", null);

    [CqlDeclaration("Encounter to Screen for Blood Pressure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920")]
	public CqlValueSet Encounter_to_Screen_for_Blood_Pressure() => 
		__Encounter_to_Screen_for_Blood_Pressure.Value;

	private CqlValueSet Finding_of_Elevated_Blood_Pressure_or_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514", null);

    [CqlDeclaration("Finding of Elevated Blood Pressure or Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514")]
	public CqlValueSet Finding_of_Elevated_Blood_Pressure_or_Hypertension() => 
		__Finding_of_Elevated_Blood_Pressure_or_Hypertension.Value;

	private CqlValueSet Follow_Up_Within_4_Weeks_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578", null);

    [CqlDeclaration("Follow Up Within 4 Weeks")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578")]
	public CqlValueSet Follow_Up_Within_4_Weeks() => 
		__Follow_Up_Within_4_Weeks.Value;

	private CqlValueSet Laboratory_Tests_for_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482", null);

    [CqlDeclaration("Laboratory Tests for Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482")]
	public CqlValueSet Laboratory_Tests_for_Hypertension() => 
		__Laboratory_Tests_for_Hypertension.Value;

	private CqlValueSet Lifestyle_Recommendation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581", null);

    [CqlDeclaration("Lifestyle Recommendation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581")]
	public CqlValueSet Lifestyle_Recommendation() => 
		__Lifestyle_Recommendation.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Patient_Declined_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);

    [CqlDeclaration("Patient Declined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582")]
	public CqlValueSet Patient_Declined() => 
		__Patient_Declined.Value;

	private CqlValueSet Pharmacologic_Therapy_for_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577", null);

    [CqlDeclaration("Pharmacologic Therapy for Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577")]
	public CqlValueSet Pharmacologic_Therapy_for_Hypertension() => 
		__Pharmacologic_Therapy_for_Hypertension.Value;

	private CqlValueSet Recommendation_to_Increase_Physical_Activity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518", null);

    [CqlDeclaration("Recommendation to Increase Physical Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518")]
	public CqlValueSet Recommendation_to_Increase_Physical_Activity() => 
		__Recommendation_to_Increase_Physical_Activity.Value;

	private CqlValueSet Referral_or_Counseling_for_Alcohol_Consumption_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583", null);

    [CqlDeclaration("Referral or Counseling for Alcohol Consumption")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583")]
	public CqlValueSet Referral_or_Counseling_for_Alcohol_Consumption() => 
		__Referral_or_Counseling_for_Alcohol_Consumption.Value;

	private CqlValueSet Referral_to_Primary_Care_or_Alternate_Provider_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580", null);

    [CqlDeclaration("Referral to Primary Care or Alternate Provider")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580")]
	public CqlValueSet Referral_to_Primary_Care_or_Alternate_Provider() => 
		__Referral_to_Primary_Care_or_Alternate_Provider.Value;

	private CqlValueSet Weight_Reduction_Recommended_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510", null);

    [CqlDeclaration("Weight Reduction Recommended")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510")]
	public CqlValueSet Weight_Reduction_Recommended() => 
		__Weight_Reduction_Recommended.Value;

	private CqlCode Diastolic_blood_pressure_Value() => 
		new CqlCode("8462-4", "http://loinc.org", null, null);

    [CqlDeclaration("Diastolic blood pressure")]
	public CqlCode Diastolic_blood_pressure() => 
		__Diastolic_blood_pressure.Value;

	private CqlCode _12_lead_EKG_panel_Value() => 
		new CqlCode("34534-8", "http://loinc.org", null, null);

    [CqlDeclaration("12 lead EKG panel")]
	public CqlCode _12_lead_EKG_panel() => 
		___12_lead_EKG_panel.Value;

	private CqlCode EKG_study_Value() => 
		new CqlCode("11524-6", "http://loinc.org", null, null);

    [CqlDeclaration("EKG study")]
	public CqlCode EKG_study() => 
		__EKG_study.Value;

	private CqlCode Follow_up_2_3_months__finding__Value() => 
		new CqlCode("183624006", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Follow-up 2-3 months (finding)")]
	public CqlCode Follow_up_2_3_months__finding_() => 
		__Follow_up_2_3_months__finding_.Value;

	private CqlCode Follow_up_4_6_months__finding__Value() => 
		new CqlCode("183625007", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Follow-up 4-6 months (finding)")]
	public CqlCode Follow_up_4_6_months__finding_() => 
		__Follow_up_4_6_months__finding_.Value;

	private CqlCode Systolic_blood_pressure_Value() => 
		new CqlCode("8480-6", "http://loinc.org", null, null);

    [CqlDeclaration("Systolic blood pressure")]
	public CqlCode Systolic_blood_pressure() => 
		__Systolic_blood_pressure.Value;

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("8462-4", "http://loinc.org", null, null),
			new CqlCode("34534-8", "http://loinc.org", null, null),
			new CqlCode("11524-6", "http://loinc.org", null, null),
			new CqlCode("8480-6", "http://loinc.org", null, null),
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
			new CqlCode("183624006", "http://snomed.info/sct", null, null),
			new CqlCode("183625007", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("PCSBPScreeningFollowUpFHIR-0.2.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Value()
	{
		var a_ = this.Encounter_to_Screen_for_Blood_Pressure();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter ValidEncounter)
		{
			var e_ = this.Measurement_Period();
			var f_ = ValidEncounter?.Period;
			var g_ = FHIRHelpers_4_3_000.ToInterval(f_);
			var h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
			var i_ = ValidEncounter?.StatusElement;
			var j_ = i_?.Value;
			var k_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(j_);
			var l_ = context.Operators.Equivalent(k_, "finished");
			var m_ = context.Operators.And(h_, l_);
			var n_ = ValidEncounter?.Class;
			var o_ = FHIRHelpers_4_3_000.ToCode(n_);
			var p_ = this.@virtual();
			var q_ = context.Operators.Equivalent(o_, p_);
			var r_ = context.Operators.Not(q_);
			var s_ = context.Operators.And(m_, r_);

			return s_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter during Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period() => 
		__Qualifying_Encounter_during_Measurement_Period.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			var d_ = this.Patient();
			var e_ = d_?.BirthDateElement;
			var f_ = e_?.Value;
			var g_ = context.Operators.ConvertStringToDateTime(f_);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
			var k_ = context.Operators.GreaterOrEqual(j_, 18);

			return k_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			var d_ = this.Diagnosis_of_Hypertension();
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			bool? f_(Condition Hypertension)
			{
				var j_ = QICoreCommon_2_0_000.isProblemListItem(Hypertension);
				var k_ = QICoreCommon_2_0_000.isHealthConcern(Hypertension);
				var l_ = context.Operators.Or(j_, k_);
				var m_ = QICoreCommon_2_0_000.isActive(Hypertension);
				var n_ = context.Operators.And(l_, m_);
				CqlInterval<CqlDateTime> o_()
				{
					bool t_()
					{
						var u_ = QICoreCommon_2_0_000.prevalenceInterval(Hypertension);
						var v_ = context.Operators.Start(u_);

						return (v_ is null);
					};
					if (t_())
					{
						return null;
					}
					else
					{
						var w_ = QICoreCommon_2_0_000.prevalenceInterval(Hypertension);
						var x_ = context.Operators.Start(w_);
						var z_ = context.Operators.Start(w_);
						var aa_ = context.Operators.Interval(x_, z_, true, true);

						return aa_;
					}
				};
				var p_ = QualifyingEncounter?.Period;
				var q_ = FHIRHelpers_4_3_000.ToInterval(p_);
				var r_ = context.Operators.SameOrBefore(o_(), q_, "day");
				var s_ = context.Operators.And(n_, r_);

				return s_;
			};
			var g_ = context.Operators.Where<Condition>(e_, f_);
			Encounter h_(Condition Hypertension) => 
				QualifyingEncounter;
			var i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				var ak_ = BloodPressure?.Effective;
				var al_ = FHIRHelpers_4_3_000.ToValue(ak_);
				var am_ = QICoreCommon_2_0_000.toInterval(al_);
				var an_ = context.Operators.End(am_);
				var ao_ = QualifyingEncounter?.Period;
				var ap_ = FHIRHelpers_4_3_000.ToInterval(ao_);
				var aq_ = context.Operators.In<CqlDateTime>(an_, ap_, null);
				var ar_ = BloodPressure?.StatusElement;
				var as_ = ar_?.Value;
				var at_ = context.Operators.Convert<string>(as_);
				var au_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var av_ = context.Operators.In<string>(at_, (au_ as IEnumerable<string>));
				var aw_ = context.Operators.And(aq_, av_);

				return aw_;
			};
			var f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var ax_ = @this?.Effective;
				var ay_ = FHIRHelpers_4_3_000.ToValue(ax_);
				var az_ = QICoreCommon_2_0_000.toInterval(ay_);
				var ba_ = context.Operators.Start(az_);

				return ba_;
			};
			var h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.Last<Observation>(h_);
			var j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				var bb_ = @this?.Code;
				var bc_ = bb_?.Coding;
				var bd_ = context.Operators.First<Coding>((IEnumerable<Coding>)bc_);
				var be_ = bd_?.SystemElement;
				var bf_ = FHIRHelpers_4_3_000.ToString(be_);
				var bg_ = context.Operators.Equal(bf_, "http://loinc.org");
				var bi_ = bb_?.Coding;
				var bj_ = context.Operators.First<Coding>((IEnumerable<Coding>)bi_);
				var bk_ = bj_?.CodeElement;
				var bl_ = FHIRHelpers_4_3_000.ToString(bk_);
				var bm_ = context.Operators.Equal(bl_, "8480-6");
				var bn_ = context.Operators.And(bg_, bm_);

				return bn_;
			};
			var l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			var m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			var n_ = m_?.Value;
			var o_ = FHIRHelpers_4_3_000.ToValue(n_);
			var p_ = context.Operators.Quantity(1m, "mm[Hg]");
			var q_ = context.Operators.Quantity(120m, "mm[Hg]");
			var r_ = context.Operators.Interval(p_, q_, true, false);
			var s_ = context.Operators.In<CqlQuantity>((o_ as CqlQuantity), r_, null);
			bool? u_(Observation BloodPressure)
			{
				var bo_ = BloodPressure?.Effective;
				var bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
				var bq_ = QICoreCommon_2_0_000.toInterval(bp_);
				var br_ = context.Operators.End(bq_);
				var bs_ = QualifyingEncounter?.Period;
				var bt_ = FHIRHelpers_4_3_000.ToInterval(bs_);
				var bu_ = context.Operators.In<CqlDateTime>(br_, bt_, null);
				var bv_ = BloodPressure?.StatusElement;
				var bw_ = bv_?.Value;
				var bx_ = context.Operators.Convert<string>(bw_);
				var by_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bz_ = context.Operators.In<string>(bx_, (by_ as IEnumerable<string>));
				var ca_ = context.Operators.And(bu_, bz_);

				return ca_;
			};
			var v_ = context.Operators.Where<Observation>(d_, u_);
			object w_(Observation @this)
			{
				var cb_ = @this?.Effective;
				var cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
				var cd_ = QICoreCommon_2_0_000.toInterval(cc_);
				var ce_ = context.Operators.Start(cd_);

				return ce_;
			};
			var x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			var y_ = context.Operators.Last<Observation>(x_);
			var z_ = y_?.Component;
			bool? aa_(Observation.ComponentComponent @this)
			{
				var cf_ = @this?.Code;
				var cg_ = cf_?.Coding;
				var ch_ = context.Operators.First<Coding>((IEnumerable<Coding>)cg_);
				var ci_ = ch_?.SystemElement;
				var cj_ = FHIRHelpers_4_3_000.ToString(ci_);
				var ck_ = context.Operators.Equal(cj_, "http://loinc.org");
				var cm_ = cf_?.Coding;
				var cn_ = context.Operators.First<Coding>((IEnumerable<Coding>)cm_);
				var co_ = cn_?.CodeElement;
				var cp_ = FHIRHelpers_4_3_000.ToString(co_);
				var cq_ = context.Operators.Equal(cp_, "8462-4");
				var cr_ = context.Operators.And(ck_, cq_);

				return cr_;
			};
			var ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
			var ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
			var ad_ = ac_?.Value;
			var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			var ag_ = context.Operators.Quantity(80m, "mm[Hg]");
			var ah_ = context.Operators.Interval(p_, ag_, true, false);
			var ai_ = context.Operators.In<CqlQuantity>((ae_ as CqlQuantity), ah_, null);
			var aj_ = context.Operators.And(s_, ai_);

			return aj_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Normal Blood Pressure Reading")]
	public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading() => 
		__Encounter_with_Normal_Blood_Pressure_Reading.Value;

	private IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				var ak_ = BloodPressure?.Effective;
				var al_ = FHIRHelpers_4_3_000.ToValue(ak_);
				var am_ = QICoreCommon_2_0_000.toInterval(al_);
				var an_ = context.Operators.End(am_);
				var ao_ = QualifyingEncounter?.Period;
				var ap_ = FHIRHelpers_4_3_000.ToInterval(ao_);
				var aq_ = context.Operators.In<CqlDateTime>(an_, ap_, null);
				var ar_ = BloodPressure?.StatusElement;
				var as_ = ar_?.Value;
				var at_ = context.Operators.Convert<string>(as_);
				var au_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var av_ = context.Operators.In<string>(at_, (au_ as IEnumerable<string>));
				var aw_ = context.Operators.And(aq_, av_);

				return aw_;
			};
			var f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var ax_ = @this?.Effective;
				var ay_ = FHIRHelpers_4_3_000.ToValue(ax_);
				var az_ = QICoreCommon_2_0_000.toInterval(ay_);
				var ba_ = context.Operators.Start(az_);

				return ba_;
			};
			var h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.Last<Observation>(h_);
			var j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				var bb_ = @this?.Code;
				var bc_ = bb_?.Coding;
				var bd_ = context.Operators.First<Coding>((IEnumerable<Coding>)bc_);
				var be_ = bd_?.SystemElement;
				var bf_ = FHIRHelpers_4_3_000.ToString(be_);
				var bg_ = context.Operators.Equal(bf_, "http://loinc.org");
				var bi_ = bb_?.Coding;
				var bj_ = context.Operators.First<Coding>((IEnumerable<Coding>)bi_);
				var bk_ = bj_?.CodeElement;
				var bl_ = FHIRHelpers_4_3_000.ToString(bk_);
				var bm_ = context.Operators.Equal(bl_, "8480-6");
				var bn_ = context.Operators.And(bg_, bm_);

				return bn_;
			};
			var l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			var m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			var n_ = m_?.Value;
			var o_ = FHIRHelpers_4_3_000.ToValue(n_);
			var p_ = context.Operators.Quantity(120m, "mm[Hg]");
			var q_ = context.Operators.Quantity(129m, "mm[Hg]");
			var r_ = context.Operators.Interval(p_, q_, true, true);
			var s_ = context.Operators.In<CqlQuantity>((o_ as CqlQuantity), r_, null);
			bool? u_(Observation BloodPressure)
			{
				var bo_ = BloodPressure?.Effective;
				var bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
				var bq_ = QICoreCommon_2_0_000.toInterval(bp_);
				var br_ = context.Operators.End(bq_);
				var bs_ = QualifyingEncounter?.Period;
				var bt_ = FHIRHelpers_4_3_000.ToInterval(bs_);
				var bu_ = context.Operators.In<CqlDateTime>(br_, bt_, null);
				var bv_ = BloodPressure?.StatusElement;
				var bw_ = bv_?.Value;
				var bx_ = context.Operators.Convert<string>(bw_);
				var by_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bz_ = context.Operators.In<string>(bx_, (by_ as IEnumerable<string>));
				var ca_ = context.Operators.And(bu_, bz_);

				return ca_;
			};
			var v_ = context.Operators.Where<Observation>(d_, u_);
			object w_(Observation @this)
			{
				var cb_ = @this?.Effective;
				var cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
				var cd_ = QICoreCommon_2_0_000.toInterval(cc_);
				var ce_ = context.Operators.Start(cd_);

				return ce_;
			};
			var x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			var y_ = context.Operators.Last<Observation>(x_);
			var z_ = y_?.Component;
			bool? aa_(Observation.ComponentComponent @this)
			{
				var cf_ = @this?.Code;
				var cg_ = cf_?.Coding;
				var ch_ = context.Operators.First<Coding>((IEnumerable<Coding>)cg_);
				var ci_ = ch_?.SystemElement;
				var cj_ = FHIRHelpers_4_3_000.ToString(ci_);
				var ck_ = context.Operators.Equal(cj_, "http://loinc.org");
				var cm_ = cf_?.Coding;
				var cn_ = context.Operators.First<Coding>((IEnumerable<Coding>)cm_);
				var co_ = cn_?.CodeElement;
				var cp_ = FHIRHelpers_4_3_000.ToString(co_);
				var cq_ = context.Operators.Equal(cp_, "8462-4");
				var cr_ = context.Operators.And(ck_, cq_);

				return cr_;
			};
			var ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
			var ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
			var ad_ = ac_?.Value;
			var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			var af_ = context.Operators.Quantity(1m, "mm[Hg]");
			var ag_ = context.Operators.Quantity(80m, "mm[Hg]");
			var ah_ = context.Operators.Interval(af_, ag_, true, false);
			var ai_ = context.Operators.In<CqlQuantity>((ae_ as CqlQuantity), ah_, null);
			var aj_ = context.Operators.And(s_, ai_);

			return aj_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
	public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80() => 
		__Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80.Value;

	private IEnumerable<ServiceRequest> Follow_up_with_Rescreen_in_2_to_6_Months_Value()
	{
		var a_ = this.Follow_up_2_3_months__finding_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, null);
		var d_ = this.Follow_up_4_6_months__finding_();
		var e_ = context.Operators.ToList<CqlCode>(d_);
		var f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, null);
		var g_ = context.Operators.ListUnion<ServiceRequest>(c_, f_);
		bool? h_(ServiceRequest FollowUp)
		{
			var j_ = FollowUp?.IntentElement;
			var k_ = j_?.Value;
			var l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
			var m_ = context.Operators.Equivalent(l_, "order");

			return m_;
		};
		var i_ = context.Operators.Where<ServiceRequest>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Follow up with Rescreen in 2 to 6 Months")]
	public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_in_2_to_6_Months() => 
		__Follow_up_with_Rescreen_in_2_to_6_Months.Value;

	private IEnumerable<ServiceRequest> NonPharmacological_Interventions_Value()
	{
		var a_ = this.Lifestyle_Recommendation();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var c_ = this.Weight_Reduction_Recommended();
		var d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(c_, null);
		var e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		var f_ = this.Dietary_Recommendations();
		var g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		var h_ = this.Recommendation_to_Increase_Physical_Activity();
		var i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, null);
		var j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		var k_ = context.Operators.ListUnion<ServiceRequest>(e_, j_);
		var l_ = this.Referral_or_Counseling_for_Alcohol_Consumption();
		var m_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, null);
		var n_ = context.Operators.ListUnion<ServiceRequest>(k_, m_);
		bool? o_(ServiceRequest NonPharmaInterventions)
		{
			var q_ = NonPharmaInterventions?.IntentElement;
			var r_ = q_?.Value;
			var s_ = context.Operators.Convert<Code<RequestIntent>>(r_);
			var t_ = context.Operators.Equivalent(s_, "order");

			return t_;
		};
		var p_ = context.Operators.Where<ServiceRequest>(n_, o_);

		return p_;
	}

    [CqlDeclaration("NonPharmacological Interventions")]
	public IEnumerable<ServiceRequest> NonPharmacological_Interventions() => 
		__NonPharmacological_Interventions.Value;

	private IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading_Value()
	{
		var a_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		bool? c_(ServiceRequest Referral)
		{
			var e_ = Referral?.ReasonCode;
			CqlConcept f_(CodeableConcept @this)
			{
				var o_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return o_;
			};
			var g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
			var h_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension();
			var i_ = context.Operators.ConceptsInValueSet(g_, h_);
			var j_ = Referral?.IntentElement;
			var k_ = j_?.Value;
			var l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
			var m_ = context.Operators.Equivalent(l_, "order");
			var n_ = context.Operators.And(i_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<ServiceRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
	public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading() => 
		__Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading.Value;

	private IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions_Value()
	{
		var a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80();
		IEnumerable<Encounter> b_(Encounter ElevatedEncounter)
		{
			var j_ = this.Follow_up_with_Rescreen_in_2_to_6_Months();
			bool? k_(ServiceRequest Twoto6MonthRescreen)
			{
				var o_ = Twoto6MonthRescreen?.AuthoredOnElement;
				var p_ = context.Operators.Convert<CqlDateTime>(o_);
				var q_ = ElevatedEncounter?.Period;
				var r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				var s_ = context.Operators.In<CqlDateTime>(p_, r_, "day");

				return s_;
			};
			var l_ = context.Operators.Where<ServiceRequest>(j_, k_);
			Encounter m_(ServiceRequest Twoto6MonthRescreen) => 
				ElevatedEncounter;
			var n_ = context.Operators.Select<ServiceRequest, Encounter>(l_, m_);

			return n_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> d_(Encounter ElevatedEncounter)
		{
			var t_ = this.NonPharmacological_Interventions();
			bool? u_(ServiceRequest NonPharmInterventions)
			{
				var y_ = NonPharmInterventions?.AuthoredOnElement;
				var z_ = context.Operators.Convert<CqlDateTime>(y_);
				var aa_ = ElevatedEncounter?.Period;
				var ab_ = FHIRHelpers_4_3_000.ToInterval(aa_);
				var ac_ = context.Operators.In<CqlDateTime>(z_, ab_, "day");

				return ac_;
			};
			var v_ = context.Operators.Where<ServiceRequest>(t_, u_);
			Encounter w_(ServiceRequest NonPharmInterventions) => 
				ElevatedEncounter;
			var x_ = context.Operators.Select<ServiceRequest, Encounter>(v_, w_);

			return x_;
		};
		var e_ = context.Operators.SelectMany<Encounter, Encounter>(c_, d_);
		IEnumerable<Encounter> g_(Encounter ElevatedEncounter)
		{
			var ad_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? ae_(ServiceRequest Referral)
			{
				var ai_ = Referral?.AuthoredOnElement;
				var aj_ = context.Operators.Convert<CqlDateTime>(ai_);
				var ak_ = ElevatedEncounter?.Period;
				var al_ = FHIRHelpers_4_3_000.ToInterval(ak_);
				var am_ = context.Operators.In<CqlDateTime>(aj_, al_, "day");

				return am_;
			};
			var af_ = context.Operators.Where<ServiceRequest>(ad_, ae_);
			Encounter ag_(ServiceRequest Referral) => 
				ElevatedEncounter;
			var ah_ = context.Operators.Select<ServiceRequest, Encounter>(af_, ag_);

			return ah_;
		};
		var h_ = context.Operators.SelectMany<Encounter, Encounter>(a_, g_);
		var i_ = context.Operators.ListUnion<Encounter>(e_, h_);

		return i_;
	}

    [CqlDeclaration("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions() => 
		__Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				var bk_ = BloodPressure?.Effective;
				var bl_ = FHIRHelpers_4_3_000.ToValue(bk_);
				var bm_ = QICoreCommon_2_0_000.toInterval(bl_);
				var bn_ = context.Operators.End(bm_);
				var bo_ = QualifyingEncounter?.Period;
				var bp_ = FHIRHelpers_4_3_000.ToInterval(bo_);
				var bq_ = context.Operators.Start(bp_);
				var br_ = context.Operators.Quantity(1m, "year");
				var bs_ = context.Operators.Subtract(bq_, br_);
				var bu_ = FHIRHelpers_4_3_000.ToInterval(bo_);
				var bv_ = context.Operators.Start(bu_);
				var bw_ = context.Operators.Interval(bs_, bv_, true, true);
				var bx_ = context.Operators.In<CqlDateTime>(bn_, bw_, null);
				var bz_ = FHIRHelpers_4_3_000.ToInterval(bo_);
				var ca_ = context.Operators.Start(bz_);
				var cb_ = context.Operators.Not((bool?)(ca_ is null));
				var cc_ = context.Operators.And(bx_, cb_);
				var cd_ = BloodPressure?.StatusElement;
				var ce_ = cd_?.Value;
				var cf_ = context.Operators.Convert<string>(ce_);
				var cg_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ch_ = context.Operators.In<string>(cf_, (cg_ as IEnumerable<string>));
				var ci_ = context.Operators.And(cc_, ch_);

				return ci_;
			};
			var f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var cj_ = @this?.Effective;
				var ck_ = FHIRHelpers_4_3_000.ToValue(cj_);
				var cl_ = QICoreCommon_2_0_000.toInterval(ck_);
				var cm_ = context.Operators.Start(cl_);

				return cm_;
			};
			var h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.Last<Observation>(h_);
			var j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				var cn_ = @this?.Code;
				var co_ = cn_?.Coding;
				var cp_ = context.Operators.First<Coding>((IEnumerable<Coding>)co_);
				var cq_ = cp_?.SystemElement;
				var cr_ = FHIRHelpers_4_3_000.ToString(cq_);
				var cs_ = context.Operators.Equal(cr_, "http://loinc.org");
				var cu_ = cn_?.Coding;
				var cv_ = context.Operators.First<Coding>((IEnumerable<Coding>)cu_);
				var cw_ = cv_?.CodeElement;
				var cx_ = FHIRHelpers_4_3_000.ToString(cw_);
				var cy_ = context.Operators.Equal(cx_, "8480-6");
				var cz_ = context.Operators.And(cs_, cy_);

				return cz_;
			};
			var l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			var m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			var n_ = m_?.Value;
			var o_ = FHIRHelpers_4_3_000.ToValue(n_);
			var p_ = context.Operators.Quantity(0m, "mm[Hg]");
			var q_ = context.Operators.Greater((o_ as CqlQuantity), p_);
			bool? s_(Observation BloodPressure)
			{
				var da_ = BloodPressure?.Effective;
				var db_ = FHIRHelpers_4_3_000.ToValue(da_);
				var dc_ = QICoreCommon_2_0_000.toInterval(db_);
				var dd_ = context.Operators.End(dc_);
				var de_ = QualifyingEncounter?.Period;
				var df_ = FHIRHelpers_4_3_000.ToInterval(de_);
				var dg_ = context.Operators.Start(df_);
				var dh_ = context.Operators.Quantity(1m, "year");
				var di_ = context.Operators.Subtract(dg_, dh_);
				var dk_ = FHIRHelpers_4_3_000.ToInterval(de_);
				var dl_ = context.Operators.Start(dk_);
				var dm_ = context.Operators.Interval(di_, dl_, true, true);
				var dn_ = context.Operators.In<CqlDateTime>(dd_, dm_, null);
				var dp_ = FHIRHelpers_4_3_000.ToInterval(de_);
				var dq_ = context.Operators.Start(dp_);
				var dr_ = context.Operators.Not((bool?)(dq_ is null));
				var ds_ = context.Operators.And(dn_, dr_);
				var dt_ = BloodPressure?.StatusElement;
				var du_ = dt_?.Value;
				var dv_ = context.Operators.Convert<string>(du_);
				var dw_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var dx_ = context.Operators.In<string>(dv_, (dw_ as IEnumerable<string>));
				var dy_ = context.Operators.And(ds_, dx_);

				return dy_;
			};
			var t_ = context.Operators.Where<Observation>(d_, s_);
			object u_(Observation @this)
			{
				var dz_ = @this?.Effective;
				var ea_ = FHIRHelpers_4_3_000.ToValue(dz_);
				var eb_ = QICoreCommon_2_0_000.toInterval(ea_);
				var ec_ = context.Operators.Start(eb_);

				return ec_;
			};
			var v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			var w_ = context.Operators.Last<Observation>(v_);
			var x_ = w_?.Component;
			bool? y_(Observation.ComponentComponent @this)
			{
				var ed_ = @this?.Code;
				var ee_ = ed_?.Coding;
				var ef_ = context.Operators.First<Coding>((IEnumerable<Coding>)ee_);
				var eg_ = ef_?.SystemElement;
				var eh_ = FHIRHelpers_4_3_000.ToString(eg_);
				var ei_ = context.Operators.Equal(eh_, "http://loinc.org");
				var ek_ = ed_?.Coding;
				var el_ = context.Operators.First<Coding>((IEnumerable<Coding>)ek_);
				var em_ = el_?.CodeElement;
				var en_ = FHIRHelpers_4_3_000.ToString(em_);
				var eo_ = context.Operators.Equal(en_, "8462-4");
				var ep_ = context.Operators.And(ei_, eo_);

				return ep_;
			};
			var z_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)x_, y_);
			var aa_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(z_);
			var ab_ = aa_?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ae_ = context.Operators.Greater((ac_ as CqlQuantity), p_);
			var af_ = context.Operators.And(q_, ae_);
			bool? ah_(Observation BloodPressure)
			{
				var eq_ = BloodPressure?.Effective;
				var er_ = FHIRHelpers_4_3_000.ToValue(eq_);
				var es_ = QICoreCommon_2_0_000.toInterval(er_);
				var et_ = context.Operators.End(es_);
				var eu_ = QualifyingEncounter?.Period;
				var ev_ = FHIRHelpers_4_3_000.ToInterval(eu_);
				var ew_ = context.Operators.Start(ev_);
				var ex_ = context.Operators.Quantity(1m, "year");
				var ey_ = context.Operators.Subtract(ew_, ex_);
				var fa_ = FHIRHelpers_4_3_000.ToInterval(eu_);
				var fb_ = context.Operators.Start(fa_);
				var fc_ = context.Operators.Interval(ey_, fb_, true, true);
				var fd_ = context.Operators.In<CqlDateTime>(et_, fc_, null);
				var ff_ = FHIRHelpers_4_3_000.ToInterval(eu_);
				var fg_ = context.Operators.Start(ff_);
				var fh_ = context.Operators.Not((bool?)(fg_ is null));
				var fi_ = context.Operators.And(fd_, fh_);
				var fj_ = BloodPressure?.StatusElement;
				var fk_ = fj_?.Value;
				var fl_ = context.Operators.Convert<string>(fk_);
				var fm_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var fn_ = context.Operators.In<string>(fl_, (fm_ as IEnumerable<string>));
				var fo_ = context.Operators.And(fi_, fn_);

				return fo_;
			};
			var ai_ = context.Operators.Where<Observation>(d_, ah_);
			object aj_(Observation @this)
			{
				var fp_ = @this?.Effective;
				var fq_ = FHIRHelpers_4_3_000.ToValue(fp_);
				var fr_ = QICoreCommon_2_0_000.toInterval(fq_);
				var fs_ = context.Operators.Start(fr_);

				return fs_;
			};
			var ak_ = context.Operators.SortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
			var al_ = context.Operators.Last<Observation>(ak_);
			var am_ = al_?.Component;
			bool? an_(Observation.ComponentComponent @this)
			{
				var ft_ = @this?.Code;
				var fu_ = ft_?.Coding;
				var fv_ = context.Operators.First<Coding>((IEnumerable<Coding>)fu_);
				var fw_ = fv_?.SystemElement;
				var fx_ = FHIRHelpers_4_3_000.ToString(fw_);
				var fy_ = context.Operators.Equal(fx_, "http://loinc.org");
				var ga_ = ft_?.Coding;
				var gb_ = context.Operators.First<Coding>((IEnumerable<Coding>)ga_);
				var gc_ = gb_?.CodeElement;
				var gd_ = FHIRHelpers_4_3_000.ToString(gc_);
				var ge_ = context.Operators.Equal(gd_, "8480-6");
				var gf_ = context.Operators.And(fy_, ge_);

				return gf_;
			};
			var ao_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)am_, an_);
			var ap_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ao_);
			var aq_ = ap_?.Value;
			var ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
			var as_ = context.Operators.Quantity(130m, "mm[Hg]");
			var at_ = context.Operators.GreaterOrEqual((ar_ as CqlQuantity), as_);
			bool? av_(Observation BloodPressure)
			{
				var gg_ = BloodPressure?.Effective;
				var gh_ = FHIRHelpers_4_3_000.ToValue(gg_);
				var gi_ = QICoreCommon_2_0_000.toInterval(gh_);
				var gj_ = context.Operators.End(gi_);
				var gk_ = QualifyingEncounter?.Period;
				var gl_ = FHIRHelpers_4_3_000.ToInterval(gk_);
				var gm_ = context.Operators.Start(gl_);
				var gn_ = context.Operators.Quantity(1m, "year");
				var go_ = context.Operators.Subtract(gm_, gn_);
				var gq_ = FHIRHelpers_4_3_000.ToInterval(gk_);
				var gr_ = context.Operators.Start(gq_);
				var gs_ = context.Operators.Interval(go_, gr_, true, true);
				var gt_ = context.Operators.In<CqlDateTime>(gj_, gs_, null);
				var gv_ = FHIRHelpers_4_3_000.ToInterval(gk_);
				var gw_ = context.Operators.Start(gv_);
				var gx_ = context.Operators.Not((bool?)(gw_ is null));
				var gy_ = context.Operators.And(gt_, gx_);
				var gz_ = BloodPressure?.StatusElement;
				var ha_ = gz_?.Value;
				var hb_ = context.Operators.Convert<string>(ha_);
				var hc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var hd_ = context.Operators.In<string>(hb_, (hc_ as IEnumerable<string>));
				var he_ = context.Operators.And(gy_, hd_);

				return he_;
			};
			var aw_ = context.Operators.Where<Observation>(d_, av_);
			object ax_(Observation @this)
			{
				var hf_ = @this?.Effective;
				var hg_ = FHIRHelpers_4_3_000.ToValue(hf_);
				var hh_ = QICoreCommon_2_0_000.toInterval(hg_);
				var hi_ = context.Operators.Start(hh_);

				return hi_;
			};
			var ay_ = context.Operators.SortBy<Observation>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
			var az_ = context.Operators.Last<Observation>(ay_);
			var ba_ = az_?.Component;
			bool? bb_(Observation.ComponentComponent @this)
			{
				var hj_ = @this?.Code;
				var hk_ = hj_?.Coding;
				var hl_ = context.Operators.First<Coding>((IEnumerable<Coding>)hk_);
				var hm_ = hl_?.SystemElement;
				var hn_ = FHIRHelpers_4_3_000.ToString(hm_);
				var ho_ = context.Operators.Equal(hn_, "http://loinc.org");
				var hq_ = hj_?.Coding;
				var hr_ = context.Operators.First<Coding>((IEnumerable<Coding>)hq_);
				var hs_ = hr_?.CodeElement;
				var ht_ = FHIRHelpers_4_3_000.ToString(hs_);
				var hu_ = context.Operators.Equal(ht_, "8462-4");
				var hv_ = context.Operators.And(ho_, hu_);

				return hv_;
			};
			var bc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ba_, bb_);
			var bd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bc_);
			var be_ = bd_?.Value;
			var bf_ = FHIRHelpers_4_3_000.ToValue(be_);
			var bg_ = context.Operators.Quantity(80m, "mm[Hg]");
			var bh_ = context.Operators.GreaterOrEqual((bf_ as CqlQuantity), bg_);
			var bi_ = context.Operators.Or(at_, bh_);
			var bj_ = context.Operators.And(af_, bi_);

			return bj_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Hypertensive Reading Within Year Prior")]
	public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior() => 
		__Encounter_with_Hypertensive_Reading_Within_Year_Prior.Value;

	private IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			var f_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? g_(Observation BloodPressure)
			{
				var bm_ = BloodPressure?.Effective;
				var bn_ = FHIRHelpers_4_3_000.ToValue(bm_);
				var bo_ = QICoreCommon_2_0_000.toInterval(bn_);
				var bp_ = context.Operators.End(bo_);
				var bq_ = QualifyingEncounter?.Period;
				var br_ = FHIRHelpers_4_3_000.ToInterval(bq_);
				var bs_ = context.Operators.In<CqlDateTime>(bp_, br_, "day");

				return bs_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				var bt_ = @this?.Effective;
				var bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
				var bv_ = QICoreCommon_2_0_000.toInterval(bu_);
				var bw_ = context.Operators.Start(bv_);

				return bw_;
			};
			var j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.Last<Observation>(j_);
			var l_ = k_?.Component;
			bool? m_(Observation.ComponentComponent @this)
			{
				var bx_ = @this?.Code;
				var by_ = bx_?.Coding;
				var bz_ = context.Operators.First<Coding>((IEnumerable<Coding>)by_);
				var ca_ = bz_?.SystemElement;
				var cb_ = FHIRHelpers_4_3_000.ToString(ca_);
				var cc_ = context.Operators.Equal(cb_, "http://loinc.org");
				var ce_ = bx_?.Coding;
				var cf_ = context.Operators.First<Coding>((IEnumerable<Coding>)ce_);
				var cg_ = cf_?.CodeElement;
				var ch_ = FHIRHelpers_4_3_000.ToString(cg_);
				var ci_ = context.Operators.Equal(ch_, "8480-6");
				var cj_ = context.Operators.And(cc_, ci_);

				return cj_;
			};
			var n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
			var o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
			var p_ = o_?.Value;
			var q_ = FHIRHelpers_4_3_000.ToValue(p_);
			var r_ = context.Operators.Quantity(0m, "mm[Hg]");
			var s_ = context.Operators.Greater((q_ as CqlQuantity), r_);
			bool? u_(Observation BloodPressure)
			{
				var ck_ = BloodPressure?.Effective;
				var cl_ = FHIRHelpers_4_3_000.ToValue(ck_);
				var cm_ = QICoreCommon_2_0_000.toInterval(cl_);
				var cn_ = context.Operators.End(cm_);
				var co_ = QualifyingEncounter?.Period;
				var cp_ = FHIRHelpers_4_3_000.ToInterval(co_);
				var cq_ = context.Operators.In<CqlDateTime>(cn_, cp_, "day");

				return cq_;
			};
			var v_ = context.Operators.Where<Observation>(f_, u_);
			object w_(Observation @this)
			{
				var cr_ = @this?.Effective;
				var cs_ = FHIRHelpers_4_3_000.ToValue(cr_);
				var ct_ = QICoreCommon_2_0_000.toInterval(cs_);
				var cu_ = context.Operators.Start(ct_);

				return cu_;
			};
			var x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			var y_ = context.Operators.Last<Observation>(x_);
			var z_ = y_?.Component;
			bool? aa_(Observation.ComponentComponent @this)
			{
				var cv_ = @this?.Code;
				var cw_ = cv_?.Coding;
				var cx_ = context.Operators.First<Coding>((IEnumerable<Coding>)cw_);
				var cy_ = cx_?.SystemElement;
				var cz_ = FHIRHelpers_4_3_000.ToString(cy_);
				var da_ = context.Operators.Equal(cz_, "http://loinc.org");
				var dc_ = cv_?.Coding;
				var dd_ = context.Operators.First<Coding>((IEnumerable<Coding>)dc_);
				var de_ = dd_?.CodeElement;
				var df_ = FHIRHelpers_4_3_000.ToString(de_);
				var dg_ = context.Operators.Equal(df_, "8462-4");
				var dh_ = context.Operators.And(da_, dg_);

				return dh_;
			};
			var ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
			var ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
			var ad_ = ac_?.Value;
			var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			var ag_ = context.Operators.Greater((ae_ as CqlQuantity), r_);
			var ah_ = context.Operators.And(s_, ag_);
			bool? aj_(Observation BloodPressure)
			{
				var di_ = BloodPressure?.Effective;
				var dj_ = FHIRHelpers_4_3_000.ToValue(di_);
				var dk_ = QICoreCommon_2_0_000.toInterval(dj_);
				var dl_ = context.Operators.End(dk_);
				var dm_ = QualifyingEncounter?.Period;
				var dn_ = FHIRHelpers_4_3_000.ToInterval(dm_);
				var do_ = context.Operators.In<CqlDateTime>(dl_, dn_, "day");

				return do_;
			};
			var ak_ = context.Operators.Where<Observation>(f_, aj_);
			object al_(Observation @this)
			{
				var dp_ = @this?.Effective;
				var dq_ = FHIRHelpers_4_3_000.ToValue(dp_);
				var dr_ = QICoreCommon_2_0_000.toInterval(dq_);
				var ds_ = context.Operators.Start(dr_);

				return ds_;
			};
			var am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
			var an_ = context.Operators.Last<Observation>(am_);
			var ao_ = an_?.Component;
			bool? ap_(Observation.ComponentComponent @this)
			{
				var dt_ = @this?.Code;
				var du_ = dt_?.Coding;
				var dv_ = context.Operators.First<Coding>((IEnumerable<Coding>)du_);
				var dw_ = dv_?.SystemElement;
				var dx_ = FHIRHelpers_4_3_000.ToString(dw_);
				var dy_ = context.Operators.Equal(dx_, "http://loinc.org");
				var ea_ = dt_?.Coding;
				var eb_ = context.Operators.First<Coding>((IEnumerable<Coding>)ea_);
				var ec_ = eb_?.CodeElement;
				var ed_ = FHIRHelpers_4_3_000.ToString(ec_);
				var ee_ = context.Operators.Equal(ed_, "8480-6");
				var ef_ = context.Operators.And(dy_, ee_);

				return ef_;
			};
			var aq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ao_, ap_);
			var ar_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aq_);
			var as_ = ar_?.Value;
			var at_ = FHIRHelpers_4_3_000.ToValue(as_);
			var au_ = context.Operators.Quantity(130m, "mm[Hg]");
			var av_ = context.Operators.GreaterOrEqual((at_ as CqlQuantity), au_);
			bool? ax_(Observation BloodPressure)
			{
				var eg_ = BloodPressure?.Effective;
				var eh_ = FHIRHelpers_4_3_000.ToValue(eg_);
				var ei_ = QICoreCommon_2_0_000.toInterval(eh_);
				var ej_ = context.Operators.End(ei_);
				var ek_ = QualifyingEncounter?.Period;
				var el_ = FHIRHelpers_4_3_000.ToInterval(ek_);
				var em_ = context.Operators.In<CqlDateTime>(ej_, el_, "day");

				return em_;
			};
			var ay_ = context.Operators.Where<Observation>(f_, ax_);
			object az_(Observation @this)
			{
				var en_ = @this?.Effective;
				var eo_ = FHIRHelpers_4_3_000.ToValue(en_);
				var ep_ = QICoreCommon_2_0_000.toInterval(eo_);
				var eq_ = context.Operators.Start(ep_);

				return eq_;
			};
			var ba_ = context.Operators.SortBy<Observation>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
			var bb_ = context.Operators.Last<Observation>(ba_);
			var bc_ = bb_?.Component;
			bool? bd_(Observation.ComponentComponent @this)
			{
				var er_ = @this?.Code;
				var es_ = er_?.Coding;
				var et_ = context.Operators.First<Coding>((IEnumerable<Coding>)es_);
				var eu_ = et_?.SystemElement;
				var ev_ = FHIRHelpers_4_3_000.ToString(eu_);
				var ew_ = context.Operators.Equal(ev_, "http://loinc.org");
				var ey_ = er_?.Coding;
				var ez_ = context.Operators.First<Coding>((IEnumerable<Coding>)ey_);
				var fa_ = ez_?.CodeElement;
				var fb_ = FHIRHelpers_4_3_000.ToString(fa_);
				var fc_ = context.Operators.Equal(fb_, "8462-4");
				var fd_ = context.Operators.And(ew_, fc_);

				return fd_;
			};
			var be_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bc_, bd_);
			var bf_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(be_);
			var bg_ = bf_?.Value;
			var bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
			var bi_ = context.Operators.Quantity(80m, "mm[Hg]");
			var bj_ = context.Operators.GreaterOrEqual((bh_ as CqlQuantity), bi_);
			var bk_ = context.Operators.Or(av_, bj_);
			var bl_ = context.Operators.And(ah_, bk_);

			return bl_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		var d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
		var e_ = context.Operators.Except<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
	public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80() => 
		__Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80.Value;

	private IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional_Value()
	{
		var a_ = this.Follow_Up_Within_4_Weeks();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> c_(ServiceRequest FourWeekRescreen)
		{
			var g_ = this.NonPharmacological_Interventions();
			bool? h_(ServiceRequest NonPharmInterventionsHTN)
			{
				var l_ = FourWeekRescreen?.AuthoredOnElement;
				var m_ = context.Operators.Convert<CqlDateTime>(l_);
				var n_ = this.Measurement_Period();
				var o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
				var p_ = NonPharmInterventionsHTN?.AuthoredOnElement;
				var q_ = context.Operators.Convert<CqlDateTime>(p_);
				var s_ = context.Operators.In<CqlDateTime>(q_, n_, "day");
				var t_ = context.Operators.And(o_, s_);
				var u_ = FourWeekRescreen?.IntentElement;
				var v_ = u_?.Value;
				var w_ = context.Operators.Convert<Code<RequestIntent>>(v_);
				var x_ = context.Operators.Equivalent(w_, "order");
				var y_ = context.Operators.And(t_, x_);

				return y_;
			};
			var i_ = context.Operators.Where<ServiceRequest>(g_, h_);
			ServiceRequest j_(ServiceRequest NonPharmInterventionsHTN) => 
				FourWeekRescreen;
			var k_ = context.Operators.Select<ServiceRequest, ServiceRequest>(i_, j_);

			return k_;
		};
		var d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
		var e_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
		var f_ = context.Operators.ListUnion<ServiceRequest>(d_, e_);

		return f_;
	}

    [CqlDeclaration("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
	public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional() => 
		__First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional.Value;

	private IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions_Value()
	{
		var a_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80();
		IEnumerable<Encounter> b_(Encounter FirstHTNEncounter)
		{
			var d_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional();
			bool? e_(ServiceRequest FirstHTNIntervention)
			{
				var i_ = FirstHTNIntervention?.AuthoredOnElement;
				var j_ = context.Operators.Convert<CqlDateTime>(i_);
				var k_ = FirstHTNEncounter?.Period;
				var l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				var m_ = context.Operators.In<CqlDateTime>(j_, l_, "day");

				return m_;
			};
			var f_ = context.Operators.Where<ServiceRequest>(d_, e_);
			Encounter g_(ServiceRequest FirstHTNIntervention) => 
				FirstHTNEncounter;
			var h_ = context.Operators.Select<ServiceRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions() => 
		__Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				var bs_ = BloodPressure?.Effective;
				var bt_ = FHIRHelpers_4_3_000.ToValue(bs_);
				var bu_ = QICoreCommon_2_0_000.toInterval(bt_);
				var bv_ = context.Operators.End(bu_);
				var bw_ = QualifyingEncounter?.Period;
				var bx_ = FHIRHelpers_4_3_000.ToInterval(bw_);
				var by_ = context.Operators.In<CqlDateTime>(bv_, bx_, "day");
				var bz_ = BloodPressure?.StatusElement;
				var ca_ = bz_?.Value;
				var cb_ = context.Operators.Convert<string>(ca_);
				var cc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var cd_ = context.Operators.In<string>(cb_, (cc_ as IEnumerable<string>));
				var ce_ = context.Operators.And(by_, cd_);

				return ce_;
			};
			var f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var cf_ = @this?.Effective;
				var cg_ = FHIRHelpers_4_3_000.ToValue(cf_);
				var ch_ = QICoreCommon_2_0_000.toInterval(cg_);
				var ci_ = context.Operators.Start(ch_);

				return ci_;
			};
			var h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.Last<Observation>(h_);
			var j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				var cj_ = @this?.Code;
				var ck_ = cj_?.Coding;
				var cl_ = context.Operators.First<Coding>((IEnumerable<Coding>)ck_);
				var cm_ = cl_?.SystemElement;
				var cn_ = FHIRHelpers_4_3_000.ToString(cm_);
				var co_ = context.Operators.Equal(cn_, "http://loinc.org");
				var cq_ = cj_?.Coding;
				var cr_ = context.Operators.First<Coding>((IEnumerable<Coding>)cq_);
				var cs_ = cr_?.CodeElement;
				var ct_ = FHIRHelpers_4_3_000.ToString(cs_);
				var cu_ = context.Operators.Equal(ct_, "8480-6");
				var cv_ = context.Operators.And(co_, cu_);

				return cv_;
			};
			var l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			var m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			var n_ = m_?.Value;
			var o_ = FHIRHelpers_4_3_000.ToValue(n_);
			var p_ = context.Operators.Quantity(130m, "mm[Hg]");
			var q_ = context.Operators.Quantity(139m, "mm[Hg]");
			var r_ = context.Operators.Interval(p_, q_, true, true);
			var s_ = context.Operators.In<CqlQuantity>((o_ as CqlQuantity), r_, null);
			bool? u_(Observation BloodPressure)
			{
				var cw_ = BloodPressure?.Effective;
				var cx_ = FHIRHelpers_4_3_000.ToValue(cw_);
				var cy_ = QICoreCommon_2_0_000.toInterval(cx_);
				var cz_ = context.Operators.End(cy_);
				var da_ = QualifyingEncounter?.Period;
				var db_ = FHIRHelpers_4_3_000.ToInterval(da_);
				var dc_ = context.Operators.In<CqlDateTime>(cz_, db_, "day");
				var dd_ = BloodPressure?.StatusElement;
				var de_ = dd_?.Value;
				var df_ = context.Operators.Convert<string>(de_);
				var dg_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var dh_ = context.Operators.In<string>(df_, (dg_ as IEnumerable<string>));
				var di_ = context.Operators.And(dc_, dh_);

				return di_;
			};
			var v_ = context.Operators.Where<Observation>(d_, u_);
			object w_(Observation @this)
			{
				var dj_ = @this?.Effective;
				var dk_ = FHIRHelpers_4_3_000.ToValue(dj_);
				var dl_ = QICoreCommon_2_0_000.toInterval(dk_);
				var dm_ = context.Operators.Start(dl_);

				return dm_;
			};
			var x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			var y_ = context.Operators.Last<Observation>(x_);
			var z_ = y_?.Component;
			bool? aa_(Observation.ComponentComponent @this)
			{
				var dn_ = @this?.Code;
				var do_ = dn_?.Coding;
				var dp_ = context.Operators.First<Coding>((IEnumerable<Coding>)do_);
				var dq_ = dp_?.SystemElement;
				var dr_ = FHIRHelpers_4_3_000.ToString(dq_);
				var ds_ = context.Operators.Equal(dr_, "http://loinc.org");
				var du_ = dn_?.Coding;
				var dv_ = context.Operators.First<Coding>((IEnumerable<Coding>)du_);
				var dw_ = dv_?.CodeElement;
				var dx_ = FHIRHelpers_4_3_000.ToString(dw_);
				var dy_ = context.Operators.Equal(dx_, "8462-4");
				var dz_ = context.Operators.And(ds_, dy_);

				return dz_;
			};
			var ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
			var ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
			var ad_ = ac_?.Value;
			var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			var af_ = context.Operators.Quantity(80m, "mm[Hg]");
			var ag_ = context.Operators.Quantity(89m, "mm[Hg]");
			var ah_ = context.Operators.Interval(af_, ag_, true, true);
			var ai_ = context.Operators.In<CqlQuantity>((ae_ as CqlQuantity), ah_, null);
			var aj_ = context.Operators.Or(s_, ai_);
			bool? al_(Observation BloodPressure)
			{
				var ea_ = BloodPressure?.Effective;
				var eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
				var ec_ = QICoreCommon_2_0_000.toInterval(eb_);
				var ed_ = context.Operators.End(ec_);
				var ee_ = QualifyingEncounter?.Period;
				var ef_ = FHIRHelpers_4_3_000.ToInterval(ee_);
				var eg_ = context.Operators.In<CqlDateTime>(ed_, ef_, "day");
				var eh_ = BloodPressure?.StatusElement;
				var ei_ = eh_?.Value;
				var ej_ = context.Operators.Convert<string>(ei_);
				var ek_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var el_ = context.Operators.In<string>(ej_, (ek_ as IEnumerable<string>));
				var em_ = context.Operators.And(eg_, el_);

				return em_;
			};
			var am_ = context.Operators.Where<Observation>(d_, al_);
			object an_(Observation @this)
			{
				var en_ = @this?.Effective;
				var eo_ = FHIRHelpers_4_3_000.ToValue(en_);
				var ep_ = QICoreCommon_2_0_000.toInterval(eo_);
				var eq_ = context.Operators.Start(ep_);

				return eq_;
			};
			var ao_ = context.Operators.SortBy<Observation>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
			var ap_ = context.Operators.Last<Observation>(ao_);
			var aq_ = ap_?.Component;
			bool? ar_(Observation.ComponentComponent @this)
			{
				var er_ = @this?.Code;
				var es_ = er_?.Coding;
				var et_ = context.Operators.First<Coding>((IEnumerable<Coding>)es_);
				var eu_ = et_?.SystemElement;
				var ev_ = FHIRHelpers_4_3_000.ToString(eu_);
				var ew_ = context.Operators.Equal(ev_, "http://loinc.org");
				var ey_ = er_?.Coding;
				var ez_ = context.Operators.First<Coding>((IEnumerable<Coding>)ey_);
				var fa_ = ez_?.CodeElement;
				var fb_ = FHIRHelpers_4_3_000.ToString(fa_);
				var fc_ = context.Operators.Equal(fb_, "8480-6");
				var fd_ = context.Operators.And(ew_, fc_);

				return fd_;
			};
			var as_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aq_, ar_);
			var at_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(as_);
			var au_ = at_?.Value;
			var av_ = FHIRHelpers_4_3_000.ToValue(au_);
			var aw_ = context.Operators.Quantity(140m, "mm[Hg]");
			var ax_ = context.Operators.GreaterOrEqual((av_ as CqlQuantity), aw_);
			bool? az_(Observation BloodPressure)
			{
				var fe_ = BloodPressure?.Effective;
				var ff_ = FHIRHelpers_4_3_000.ToValue(fe_);
				var fg_ = QICoreCommon_2_0_000.toInterval(ff_);
				var fh_ = context.Operators.End(fg_);
				var fi_ = QualifyingEncounter?.Period;
				var fj_ = FHIRHelpers_4_3_000.ToInterval(fi_);
				var fk_ = context.Operators.In<CqlDateTime>(fh_, fj_, "day");
				var fl_ = BloodPressure?.StatusElement;
				var fm_ = fl_?.Value;
				var fn_ = context.Operators.Convert<string>(fm_);
				var fo_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var fp_ = context.Operators.In<string>(fn_, (fo_ as IEnumerable<string>));
				var fq_ = context.Operators.And(fk_, fp_);

				return fq_;
			};
			var ba_ = context.Operators.Where<Observation>(d_, az_);
			object bb_(Observation @this)
			{
				var fr_ = @this?.Effective;
				var fs_ = FHIRHelpers_4_3_000.ToValue(fr_);
				var ft_ = QICoreCommon_2_0_000.toInterval(fs_);
				var fu_ = context.Operators.Start(ft_);

				return fu_;
			};
			var bc_ = context.Operators.SortBy<Observation>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
			var bd_ = context.Operators.Last<Observation>(bc_);
			var be_ = bd_?.Component;
			bool? bf_(Observation.ComponentComponent @this)
			{
				var fv_ = @this?.Code;
				var fw_ = fv_?.Coding;
				var fx_ = context.Operators.First<Coding>((IEnumerable<Coding>)fw_);
				var fy_ = fx_?.SystemElement;
				var fz_ = FHIRHelpers_4_3_000.ToString(fy_);
				var ga_ = context.Operators.Equal(fz_, "http://loinc.org");
				var gc_ = fv_?.Coding;
				var gd_ = context.Operators.First<Coding>((IEnumerable<Coding>)gc_);
				var ge_ = gd_?.CodeElement;
				var gf_ = FHIRHelpers_4_3_000.ToString(ge_);
				var gg_ = context.Operators.Equal(gf_, "8462-4");
				var gh_ = context.Operators.And(ga_, gg_);

				return gh_;
			};
			var bg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)be_, bf_);
			var bh_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bg_);
			var bi_ = bh_?.Value;
			var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
			var bk_ = context.Operators.Quantity(90m, "mm[Hg]");
			var bl_ = context.Operators.GreaterOrEqual((bj_ as CqlQuantity), bk_);
			var bm_ = context.Operators.Or(ax_, bl_);
			var bn_ = context.Operators.Not(bm_);
			var bo_ = context.Operators.And(aj_, bn_);
			var bp_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			var bq_ = context.Operators.Exists<Encounter>(bp_);
			var br_ = context.Operators.And(bo_, bq_);

			return br_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89.Value;

	private IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Value()
	{
		var a_ = this._12_lead_EKG_panel();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, null);
		var d_ = this.EKG_study();
		var e_ = context.Operators.ToList<CqlCode>(d_);
		var f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, null);
		var g_ = context.Operators.ListUnion<ServiceRequest>(c_, f_);
		var h_ = this.Laboratory_Tests_for_Hypertension();
		var i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, null);
		var j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		bool? k_(ServiceRequest EKGLab)
		{
			var m_ = EKGLab?.IntentElement;
			var n_ = m_?.Value;
			var o_ = context.Operators.Convert<Code<RequestIntent>>(n_);
			var p_ = context.Operators.Equivalent(o_, "order");

			return p_;
		};
		var l_ = context.Operators.Where<ServiceRequest>(j_, k_);

		return l_;
	}

    [CqlDeclaration("Laboratory Test or ECG for Hypertension")]
	public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension() => 
		__Laboratory_Test_or_ECG_for_Hypertension.Value;

	private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Value()
	{
		var a_ = this.Follow_up_with_Rescreen_in_2_to_6_Months();
		IEnumerable<ServiceRequest> b_(ServiceRequest Rescreen2to6)
		{
			var f_ = this.Laboratory_Test_or_ECG_for_Hypertension();
			bool? g_(ServiceRequest LabECGIntervention)
			{
				var k_ = Rescreen2to6?.AuthoredOnElement;
				var l_ = context.Operators.Convert<CqlDateTime>(k_);
				var m_ = this.Measurement_Period();
				var n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
				var o_ = LabECGIntervention?.AuthoredOnElement;
				var p_ = context.Operators.Convert<CqlDateTime>(o_);
				var r_ = context.Operators.In<CqlDateTime>(p_, m_, "day");
				var s_ = context.Operators.And(n_, r_);

				return s_;
			};
			var h_ = context.Operators.Where<ServiceRequest>(f_, g_);
			ServiceRequest i_(ServiceRequest LabECGIntervention) => 
				Rescreen2to6;
			var j_ = context.Operators.Select<ServiceRequest, ServiceRequest>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(a_, b_);
		IEnumerable<ServiceRequest> d_(ServiceRequest Rescreen2to6)
		{
			var t_ = this.NonPharmacological_Interventions();
			bool? u_(ServiceRequest NonPharmSecondIntervention)
			{
				var y_ = NonPharmSecondIntervention?.AuthoredOnElement;
				var z_ = context.Operators.Convert<CqlDateTime>(y_);
				var aa_ = this.Measurement_Period();
				var ab_ = context.Operators.In<CqlDateTime>(z_, aa_, "day");

				return ab_;
			};
			var v_ = context.Operators.Where<ServiceRequest>(t_, u_);
			ServiceRequest w_(ServiceRequest NonPharmSecondIntervention) => 
				Rescreen2to6;
			var x_ = context.Operators.Select<ServiceRequest, ServiceRequest>(v_, w_);

			return x_;
		};
		var e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
	public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions() => 
		__Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Value()
	{
		var a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89();
		IEnumerable<Encounter> b_(Encounter SecondHTNEncounterReading)
		{
			var h_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions();
			bool? i_(ServiceRequest EncounterInterventions)
			{
				var m_ = EncounterInterventions?.AuthoredOnElement;
				var n_ = context.Operators.Convert<CqlDateTime>(m_);
				var o_ = SecondHTNEncounterReading?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");

				return q_;
			};
			var j_ = context.Operators.Where<ServiceRequest>(h_, i_);
			Encounter k_(ServiceRequest EncounterInterventions) => 
				SecondHTNEncounterReading;
			var l_ = context.Operators.Select<ServiceRequest, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading)
		{
			var r_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? s_(ServiceRequest ReferralForHTN)
			{
				var w_ = ReferralForHTN?.AuthoredOnElement;
				var x_ = context.Operators.Convert<CqlDateTime>(w_);
				var y_ = SecondHTNEncounterReading?.Period;
				var z_ = FHIRHelpers_4_3_000.ToInterval(y_);
				var aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");

				return aa_;
			};
			var t_ = context.Operators.Where<ServiceRequest>(r_, s_);
			Encounter u_(ServiceRequest ReferralForHTN) => 
				SecondHTNEncounterReading;
			var v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);

			return v_;
		};
		var f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			var d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				var bn_ = BloodPressure?.Effective;
				var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
				var bp_ = QICoreCommon_2_0_000.toInterval(bo_);
				var bq_ = context.Operators.End(bp_);
				var br_ = QualifyingEncounter?.Period;
				var bs_ = FHIRHelpers_4_3_000.ToInterval(br_);
				var bt_ = context.Operators.In<CqlDateTime>(bq_, bs_, null);
				var bu_ = BloodPressure?.StatusElement;
				var bv_ = bu_?.Value;
				var bw_ = context.Operators.Convert<string>(bv_);
				var bx_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var by_ = context.Operators.In<string>(bw_, (bx_ as IEnumerable<string>));
				var bz_ = context.Operators.And(bt_, by_);

				return bz_;
			};
			var f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var ca_ = @this?.Effective;
				var cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
				var cc_ = QICoreCommon_2_0_000.toInterval(cb_);
				var cd_ = context.Operators.Start(cc_);

				return cd_;
			};
			var h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.Last<Observation>(h_);
			var j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				var ce_ = @this?.Code;
				var cf_ = ce_?.Coding;
				var cg_ = context.Operators.First<Coding>((IEnumerable<Coding>)cf_);
				var ch_ = cg_?.SystemElement;
				var ci_ = FHIRHelpers_4_3_000.ToString(ch_);
				var cj_ = context.Operators.Equal(ci_, "http://loinc.org");
				var cl_ = ce_?.Coding;
				var cm_ = context.Operators.First<Coding>((IEnumerable<Coding>)cl_);
				var cn_ = cm_?.CodeElement;
				var co_ = FHIRHelpers_4_3_000.ToString(cn_);
				var cp_ = context.Operators.Equal(co_, "8480-6");
				var cq_ = context.Operators.And(cj_, cp_);

				return cq_;
			};
			var l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			var m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			var n_ = m_?.Value;
			var o_ = FHIRHelpers_4_3_000.ToValue(n_);
			var p_ = context.Operators.Quantity(0m, "mm[Hg]");
			var q_ = context.Operators.Greater((o_ as CqlQuantity), p_);
			bool? s_(Observation BloodPressure)
			{
				var cr_ = BloodPressure?.Effective;
				var cs_ = FHIRHelpers_4_3_000.ToValue(cr_);
				var ct_ = QICoreCommon_2_0_000.toInterval(cs_);
				var cu_ = context.Operators.End(ct_);
				var cv_ = QualifyingEncounter?.Period;
				var cw_ = FHIRHelpers_4_3_000.ToInterval(cv_);
				var cx_ = context.Operators.In<CqlDateTime>(cu_, cw_, null);
				var cy_ = BloodPressure?.StatusElement;
				var cz_ = cy_?.Value;
				var da_ = context.Operators.Convert<string>(cz_);
				var db_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var dc_ = context.Operators.In<string>(da_, (db_ as IEnumerable<string>));
				var dd_ = context.Operators.And(cx_, dc_);

				return dd_;
			};
			var t_ = context.Operators.Where<Observation>(d_, s_);
			object u_(Observation @this)
			{
				var de_ = @this?.Effective;
				var df_ = FHIRHelpers_4_3_000.ToValue(de_);
				var dg_ = QICoreCommon_2_0_000.toInterval(df_);
				var dh_ = context.Operators.Start(dg_);

				return dh_;
			};
			var v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			var w_ = context.Operators.Last<Observation>(v_);
			var x_ = w_?.Component;
			bool? y_(Observation.ComponentComponent @this)
			{
				var di_ = @this?.Code;
				var dj_ = di_?.Coding;
				var dk_ = context.Operators.First<Coding>((IEnumerable<Coding>)dj_);
				var dl_ = dk_?.SystemElement;
				var dm_ = FHIRHelpers_4_3_000.ToString(dl_);
				var dn_ = context.Operators.Equal(dm_, "http://loinc.org");
				var dp_ = di_?.Coding;
				var dq_ = context.Operators.First<Coding>((IEnumerable<Coding>)dp_);
				var dr_ = dq_?.CodeElement;
				var ds_ = FHIRHelpers_4_3_000.ToString(dr_);
				var dt_ = context.Operators.Equal(ds_, "8462-4");
				var du_ = context.Operators.And(dn_, dt_);

				return du_;
			};
			var z_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)x_, y_);
			var aa_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(z_);
			var ab_ = aa_?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ae_ = context.Operators.Greater((ac_ as CqlQuantity), p_);
			var af_ = context.Operators.And(q_, ae_);
			bool? ah_(Observation BloodPressure)
			{
				var dv_ = BloodPressure?.Effective;
				var dw_ = FHIRHelpers_4_3_000.ToValue(dv_);
				var dx_ = QICoreCommon_2_0_000.toInterval(dw_);
				var dy_ = context.Operators.End(dx_);
				var dz_ = QualifyingEncounter?.Period;
				var ea_ = FHIRHelpers_4_3_000.ToInterval(dz_);
				var eb_ = context.Operators.In<CqlDateTime>(dy_, ea_, null);
				var ec_ = BloodPressure?.StatusElement;
				var ed_ = ec_?.Value;
				var ee_ = context.Operators.Convert<string>(ed_);
				var ef_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var eg_ = context.Operators.In<string>(ee_, (ef_ as IEnumerable<string>));
				var eh_ = context.Operators.And(eb_, eg_);

				return eh_;
			};
			var ai_ = context.Operators.Where<Observation>(d_, ah_);
			object aj_(Observation @this)
			{
				var ei_ = @this?.Effective;
				var ej_ = FHIRHelpers_4_3_000.ToValue(ei_);
				var ek_ = QICoreCommon_2_0_000.toInterval(ej_);
				var el_ = context.Operators.Start(ek_);

				return el_;
			};
			var ak_ = context.Operators.SortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
			var al_ = context.Operators.Last<Observation>(ak_);
			var am_ = al_?.Component;
			bool? an_(Observation.ComponentComponent @this)
			{
				var em_ = @this?.Code;
				var en_ = em_?.Coding;
				var eo_ = context.Operators.First<Coding>((IEnumerable<Coding>)en_);
				var ep_ = eo_?.SystemElement;
				var eq_ = FHIRHelpers_4_3_000.ToString(ep_);
				var er_ = context.Operators.Equal(eq_, "http://loinc.org");
				var et_ = em_?.Coding;
				var eu_ = context.Operators.First<Coding>((IEnumerable<Coding>)et_);
				var ev_ = eu_?.CodeElement;
				var ew_ = FHIRHelpers_4_3_000.ToString(ev_);
				var ex_ = context.Operators.Equal(ew_, "8480-6");
				var ey_ = context.Operators.And(er_, ex_);

				return ey_;
			};
			var ao_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)am_, an_);
			var ap_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ao_);
			var aq_ = ap_?.Value;
			var ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
			var as_ = context.Operators.Quantity(140m, "mm[Hg]");
			var at_ = context.Operators.GreaterOrEqual((ar_ as CqlQuantity), as_);
			bool? av_(Observation BloodPressure)
			{
				var ez_ = BloodPressure?.Effective;
				var fa_ = FHIRHelpers_4_3_000.ToValue(ez_);
				var fb_ = QICoreCommon_2_0_000.toInterval(fa_);
				var fc_ = context.Operators.End(fb_);
				var fd_ = QualifyingEncounter?.Period;
				var fe_ = FHIRHelpers_4_3_000.ToInterval(fd_);
				var ff_ = context.Operators.In<CqlDateTime>(fc_, fe_, null);
				var fg_ = BloodPressure?.StatusElement;
				var fh_ = fg_?.Value;
				var fi_ = context.Operators.Convert<string>(fh_);
				var fj_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var fk_ = context.Operators.In<string>(fi_, (fj_ as IEnumerable<string>));
				var fl_ = context.Operators.And(ff_, fk_);

				return fl_;
			};
			var aw_ = context.Operators.Where<Observation>(d_, av_);
			object ax_(Observation @this)
			{
				var fm_ = @this?.Effective;
				var fn_ = FHIRHelpers_4_3_000.ToValue(fm_);
				var fo_ = QICoreCommon_2_0_000.toInterval(fn_);
				var fp_ = context.Operators.Start(fo_);

				return fp_;
			};
			var ay_ = context.Operators.SortBy<Observation>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
			var az_ = context.Operators.Last<Observation>(ay_);
			var ba_ = az_?.Component;
			bool? bb_(Observation.ComponentComponent @this)
			{
				var fq_ = @this?.Code;
				var fr_ = fq_?.Coding;
				var fs_ = context.Operators.First<Coding>((IEnumerable<Coding>)fr_);
				var ft_ = fs_?.SystemElement;
				var fu_ = FHIRHelpers_4_3_000.ToString(ft_);
				var fv_ = context.Operators.Equal(fu_, "http://loinc.org");
				var fx_ = fq_?.Coding;
				var fy_ = context.Operators.First<Coding>((IEnumerable<Coding>)fx_);
				var fz_ = fy_?.CodeElement;
				var ga_ = FHIRHelpers_4_3_000.ToString(fz_);
				var gb_ = context.Operators.Equal(ga_, "8462-4");
				var gc_ = context.Operators.And(fv_, gb_);

				return gc_;
			};
			var bc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ba_, bb_);
			var bd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bc_);
			var be_ = bd_?.Value;
			var bf_ = FHIRHelpers_4_3_000.ToValue(be_);
			var bg_ = context.Operators.Quantity(90m, "mm[Hg]");
			var bh_ = context.Operators.GreaterOrEqual((bf_ as CqlQuantity), bg_);
			var bi_ = context.Operators.Or(at_, bh_);
			var bj_ = context.Operators.And(af_, bi_);
			var bk_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			var bl_ = context.Operators.Exists<Encounter>(bk_);
			var bm_ = context.Operators.And(bj_, bl_);

			return bm_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90.Value;

	private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Value()
	{
		var a_ = this.Follow_Up_Within_4_Weeks();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> c_(ServiceRequest WeeksRescreen)
		{
			var i_ = this.Laboratory_Test_or_ECG_for_Hypertension();
			bool? j_(ServiceRequest ECGLabTest)
			{
				var n_ = WeeksRescreen?.AuthoredOnElement;
				var o_ = context.Operators.Convert<CqlDateTime>(n_);
				var p_ = this.Measurement_Period();
				var q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
				var r_ = ECGLabTest?.AuthoredOnElement;
				var s_ = context.Operators.Convert<CqlDateTime>(r_);
				var u_ = context.Operators.In<CqlDateTime>(s_, p_, "day");
				var v_ = context.Operators.And(q_, u_);
				var w_ = WeeksRescreen?.IntentElement;
				var x_ = w_?.Value;
				var y_ = context.Operators.Convert<Code<RequestIntent>>(x_);
				var z_ = context.Operators.Equivalent(y_, "order");
				var aa_ = context.Operators.And(v_, z_);
				var ab_ = ECGLabTest?.IntentElement;
				var ac_ = ab_?.Value;
				var ad_ = context.Operators.Convert<Code<RequestIntent>>(ac_);
				var ae_ = context.Operators.Equivalent(ad_, "order");
				var af_ = context.Operators.And(aa_, ae_);

				return af_;
			};
			var k_ = context.Operators.Where<ServiceRequest>(i_, j_);
			ServiceRequest l_(ServiceRequest ECGLabTest) => 
				WeeksRescreen;
			var m_ = context.Operators.Select<ServiceRequest, ServiceRequest>(k_, l_);

			return m_;
		};
		var d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
		IEnumerable<ServiceRequest> e_(ServiceRequest WeeksRescreen)
		{
			var ag_ = this.NonPharmacological_Interventions();
			bool? ah_(ServiceRequest HTNInterventions)
			{
				var al_ = HTNInterventions?.AuthoredOnElement;
				var am_ = context.Operators.Convert<CqlDateTime>(al_);
				var an_ = this.Measurement_Period();
				var ao_ = context.Operators.In<CqlDateTime>(am_, an_, "day");

				return ao_;
			};
			var ai_ = context.Operators.Where<ServiceRequest>(ag_, ah_);
			ServiceRequest aj_(ServiceRequest HTNInterventions) => 
				WeeksRescreen;
			var ak_ = context.Operators.Select<ServiceRequest, ServiceRequest>(ai_, aj_);

			return ak_;
		};
		var f_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(d_, e_);
		IEnumerable<ServiceRequest> g_(ServiceRequest WeeksRescreen)
		{
			var ap_ = this.Pharmacologic_Therapy_for_Hypertension();
			var aq_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ap_, null);
			var as_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ap_, null);
			var at_ = context.Operators.ListUnion<MedicationRequest>(aq_, as_);
			bool? au_(MedicationRequest Medications)
			{
				var ay_ = Medications?.AuthoredOnElement;
				var az_ = context.Operators.Convert<CqlDateTime>(ay_);
				var ba_ = this.Measurement_Period();
				var bb_ = context.Operators.In<CqlDateTime>(az_, ba_, "day");
				var bc_ = Medications?.StatusElement;
				var bd_ = bc_?.Value;
				var be_ = context.Operators.Convert<string>(bd_);
				var bf_ = context.Operators.Equivalent(be_, "active");
				var bg_ = context.Operators.And(bb_, bf_);

				return bg_;
			};
			var av_ = context.Operators.Where<MedicationRequest>(at_, au_);
			ServiceRequest aw_(MedicationRequest Medications) => 
				WeeksRescreen;
			var ax_ = context.Operators.Select<MedicationRequest, ServiceRequest>(av_, aw_);

			return ax_;
		};
		var h_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
	public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions() => 
		__Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions_Value()
	{
		var a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90();
		IEnumerable<Encounter> b_(Encounter SecondHTNEncounterReading140Over90)
		{
			var h_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions();
			bool? i_(ServiceRequest SecondHTN140Over90Interventions)
			{
				var m_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
				var n_ = context.Operators.Convert<CqlDateTime>(m_);
				var o_ = SecondHTNEncounterReading140Over90?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");

				return q_;
			};
			var j_ = context.Operators.Where<ServiceRequest>(h_, i_);
			Encounter k_(ServiceRequest SecondHTN140Over90Interventions) => 
				SecondHTNEncounterReading140Over90;
			var l_ = context.Operators.Select<ServiceRequest, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading140Over90)
		{
			var r_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? s_(ServiceRequest ReferralToProfessional)
			{
				var w_ = ReferralToProfessional?.AuthoredOnElement;
				var x_ = context.Operators.Convert<CqlDateTime>(w_);
				var y_ = SecondHTNEncounterReading140Over90?.Period;
				var z_ = FHIRHelpers_4_3_000.ToInterval(y_);
				var aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");

				return aa_;
			};
			var t_ = context.Operators.Where<ServiceRequest>(r_, s_);
			Encounter u_(ServiceRequest ReferralToProfessional) => 
				SecondHTNEncounterReading140Over90;
			var v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);

			return v_;
		};
		var f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Encounter_with_Normal_Blood_Pressure_Reading();
		var b_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions();
		var e_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions();
		var f_ = context.Operators.ListUnion<Encounter>(d_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		var h_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions();
		var i_ = context.Operators.ListUnion<Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement_Value()
	{
		var a_ = this.Qualifying_Encounter_during_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			var d_ = this.Systolic_blood_pressure();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			var g_ = this.Diastolic_blood_pressure();
			var h_ = context.Operators.ToList<CqlCode>(g_);
			var i_ = context.Operators.RetrieveByCodes<Observation>(h_, null);
			var j_ = context.Operators.ListUnion<Observation>(f_, i_);
			bool? k_(Observation NoBPScreen)
			{
				var o_ = NoBPScreen?.IssuedElement;
				var p_ = o_?.Value;
				var q_ = context.Operators.Convert<CqlDateTime>(p_);
				var r_ = QualifyingEncounter?.Period;
				var s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				var t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
				bool? u_(Extension @this)
				{
					var at_ = @this?.Url;
					var au_ = context.Operators.Convert<FhirUri>(at_);
					var av_ = FHIRHelpers_4_3_000.ToString(au_);
					var aw_ = context.Operators.Equal(av_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

					return aw_;
				};
				var v_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((NoBPScreen is DomainResource)
						? ((NoBPScreen as DomainResource).Extension)
						: null), u_);
				DataType w_(Extension @this)
				{
					var ax_ = @this?.Value;

					return ax_;
				};
				var x_ = context.Operators.Select<Extension, DataType>(v_, w_);
				var y_ = context.Operators.SingletonFrom<DataType>(x_);
				var z_ = context.Operators.Convert<CodeableConcept>(y_);
				var aa_ = FHIRHelpers_4_3_000.ToConcept(z_);
				var ab_ = this.Patient_Declined();
				var ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
				bool? ad_(Extension @this)
				{
					var ay_ = @this?.Url;
					var az_ = context.Operators.Convert<FhirUri>(ay_);
					var ba_ = FHIRHelpers_4_3_000.ToString(az_);
					var bb_ = context.Operators.Equal(ba_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

					return bb_;
				};
				var ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((NoBPScreen is DomainResource)
						? ((NoBPScreen as DomainResource).Extension)
						: null), ad_);
				DataType af_(Extension @this)
				{
					var bc_ = @this?.Value;

					return bc_;
				};
				var ag_ = context.Operators.Select<Extension, DataType>(ae_, af_);
				var ah_ = context.Operators.SingletonFrom<DataType>(ag_);
				var ai_ = context.Operators.Convert<CodeableConcept>(ah_);
				var aj_ = FHIRHelpers_4_3_000.ToConcept(ai_);
				var ak_ = this.Medical_Reason();
				var al_ = context.Operators.ConceptInValueSet(aj_, ak_);
				var am_ = context.Operators.Or(ac_, al_);
				var an_ = context.Operators.And(t_, am_);
				var ao_ = NoBPScreen?.StatusElement;
				var ap_ = ao_?.Value;
				var aq_ = context.Operators.Convert<Code<ObservationStatus>>(ap_);
				var ar_ = context.Operators.Equal(aq_, "cancelled");
				var as_ = context.Operators.And(an_, ar_);

				return as_;
			};
			var l_ = context.Operators.Where<Observation>(j_, k_);
			Encounter m_(Observation NoBPScreen) => 
				QualifyingEncounter;
			var n_ = context.Operators.Select<Observation, Encounter>(l_, m_);

			return n_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
	public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement() => 
		__Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement.Value;

	private IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered_Value()
	{
		var a_ = this.Lifestyle_Recommendation();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		var f_ = this.Weight_Reduction_Recommended();
		var g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		var i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		var j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		var k_ = context.Operators.ListUnion<ServiceRequest>(e_, j_);
		var l_ = this.Dietary_Recommendations();
		var m_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, null);
		var o_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, null);
		var p_ = context.Operators.ListUnion<ServiceRequest>(m_, o_);
		var q_ = context.Operators.ListUnion<ServiceRequest>(k_, p_);
		var r_ = this.Recommendation_to_Increase_Physical_Activity();
		var s_ = context.Operators.RetrieveByValueSet<ServiceRequest>(r_, null);
		var u_ = context.Operators.RetrieveByValueSet<ServiceRequest>(r_, null);
		var v_ = context.Operators.ListUnion<ServiceRequest>(s_, u_);
		var w_ = context.Operators.ListUnion<ServiceRequest>(q_, v_);
		var x_ = this.Referral_or_Counseling_for_Alcohol_Consumption();
		var y_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, null);
		var aa_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, null);
		var ab_ = context.Operators.ListUnion<ServiceRequest>(y_, aa_);
		var ac_ = context.Operators.ListUnion<ServiceRequest>(w_, ab_);
		bool? ad_(ServiceRequest NonPharmIntervention)
		{
			bool? af_(Extension @this)
			{
				var at_ = @this?.Url;
				var au_ = context.Operators.Convert<FhirUri>(at_);
				var av_ = FHIRHelpers_4_3_000.ToString(au_);
				var aw_ = context.Operators.Equal(av_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return aw_;
			};
			var ag_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((NonPharmIntervention is DomainResource)
					? ((NonPharmIntervention as DomainResource).Extension)
					: null), af_);
			DataType ah_(Extension @this)
			{
				var ax_ = @this?.Value;

				return ax_;
			};
			var ai_ = context.Operators.Select<Extension, DataType>(ag_, ah_);
			var aj_ = context.Operators.SingletonFrom<DataType>(ai_);
			var ak_ = context.Operators.Convert<CodeableConcept>(aj_);
			var al_ = FHIRHelpers_4_3_000.ToConcept(ak_);
			var am_ = this.Patient_Declined();
			var an_ = context.Operators.ConceptInValueSet(al_, am_);
			var ao_ = NonPharmIntervention?.StatusElement;
			var ap_ = ao_?.Value;
			var aq_ = context.Operators.Convert<Code<RequestStatus>>(ap_);
			var ar_ = context.Operators.Equal(aq_, "completed");
			var as_ = context.Operators.And(an_, ar_);

			return as_;
		};
		var ae_ = context.Operators.Where<ServiceRequest>(ac_, ad_);

		return ae_;
	}

    [CqlDeclaration("NonPharmacological Intervention Not Ordered")]
	public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered() => 
		__NonPharmacological_Intervention_Not_Ordered.Value;

	private IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered_Value()
	{
		var a_ = this._12_lead_EKG_panel();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, null);
		var d_ = this.EKG_study();
		var e_ = context.Operators.ToList<CqlCode>(d_);
		var f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, null);
		var g_ = context.Operators.ListUnion<ServiceRequest>(c_, f_);
		var h_ = this.Laboratory_Tests_for_Hypertension();
		var i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, null);
		var k_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, null);
		var l_ = context.Operators.ListUnion<ServiceRequest>(i_, k_);
		var m_ = context.Operators.ListUnion<ServiceRequest>(g_, l_);
		bool? n_(ServiceRequest LabECGNotDone)
		{
			bool? p_(Extension @this)
			{
				var y_ = @this?.Url;
				var z_ = context.Operators.Convert<FhirUri>(y_);
				var aa_ = FHIRHelpers_4_3_000.ToString(z_);
				var ab_ = context.Operators.Equal(aa_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return ab_;
			};
			var q_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((LabECGNotDone is DomainResource)
					? ((LabECGNotDone as DomainResource).Extension)
					: null), p_);
			DataType r_(Extension @this)
			{
				var ac_ = @this?.Value;

				return ac_;
			};
			var s_ = context.Operators.Select<Extension, DataType>(q_, r_);
			var t_ = context.Operators.SingletonFrom<DataType>(s_);
			var u_ = context.Operators.Convert<CodeableConcept>(t_);
			var v_ = FHIRHelpers_4_3_000.ToConcept(u_);
			var w_ = this.Patient_Declined();
			var x_ = context.Operators.ConceptInValueSet(v_, w_);

			return x_;
		};
		var o_ = context.Operators.Where<ServiceRequest>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Laboratory Test or ECG for Hypertension Not Ordered")]
	public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered() => 
		__Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered.Value;

	private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined_Value()
	{
		var a_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		var f_ = this.Follow_up_2_3_months__finding_();
		var g_ = context.Operators.ToList<CqlCode>(f_);
		var h_ = context.Operators.RetrieveByCodes<ServiceRequest>(g_, null);
		var i_ = this.Follow_up_4_6_months__finding_();
		var j_ = context.Operators.ToList<CqlCode>(i_);
		var k_ = context.Operators.RetrieveByCodes<ServiceRequest>(j_, null);
		var l_ = context.Operators.ListUnion<ServiceRequest>(h_, k_);
		var m_ = context.Operators.ListUnion<ServiceRequest>(e_, l_);
		bool? n_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
		{
			bool? t_(Extension @this)
			{
				var ah_ = @this?.Url;
				var ai_ = context.Operators.Convert<FhirUri>(ah_);
				var aj_ = FHIRHelpers_4_3_000.ToString(ai_);
				var ak_ = context.Operators.Equal(aj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return ak_;
			};
			var u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((SecondHTNDeclinedReferralAndFollowUp is DomainResource)
					? ((SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension)
					: null), t_);
			DataType v_(Extension @this)
			{
				var al_ = @this?.Value;

				return al_;
			};
			var w_ = context.Operators.Select<Extension, DataType>(u_, v_);
			var x_ = context.Operators.SingletonFrom<DataType>(w_);
			var y_ = context.Operators.Convert<CodeableConcept>(x_);
			var z_ = FHIRHelpers_4_3_000.ToConcept(y_);
			var aa_ = this.Patient_Declined();
			var ab_ = context.Operators.ConceptInValueSet(z_, aa_);
			var ac_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
			var ad_ = ac_?.Value;
			var ae_ = context.Operators.Convert<Code<RequestStatus>>(ad_);
			var af_ = context.Operators.Equal(ae_, "completed");
			var ag_ = context.Operators.And(ab_, af_);

			return ag_;
		};
		var o_ = context.Operators.Where<ServiceRequest>(m_, n_);
		var p_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered();
		var q_ = context.Operators.ListUnion<ServiceRequest>(o_, p_);
		var r_ = this.NonPharmacological_Intervention_Not_Ordered();
		var s_ = context.Operators.ListUnion<ServiceRequest>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
	public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined() => 
		__Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined.Value;

	private IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined_Value()
	{
		var a_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		var f_ = this.Follow_Up_Within_4_Weeks();
		var g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		var i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		var j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		var k_ = context.Operators.ListUnion<ServiceRequest>(e_, j_);
		bool? l_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
		{
			bool? z_(Extension @this)
			{
				var an_ = @this?.Url;
				var ao_ = context.Operators.Convert<FhirUri>(an_);
				var ap_ = FHIRHelpers_4_3_000.ToString(ao_);
				var aq_ = context.Operators.Equal(ap_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return aq_;
			};
			var aa_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((SecondHTN140Over90ReferralFollowUpNotDone is DomainResource)
					? ((SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension)
					: null), z_);
			DataType ab_(Extension @this)
			{
				var ar_ = @this?.Value;

				return ar_;
			};
			var ac_ = context.Operators.Select<Extension, DataType>(aa_, ab_);
			var ad_ = context.Operators.SingletonFrom<DataType>(ac_);
			var ae_ = context.Operators.Convert<CodeableConcept>(ad_);
			var af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			var ag_ = this.Patient_Declined();
			var ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			var ai_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
			var aj_ = ai_?.Value;
			var ak_ = context.Operators.Convert<Code<RequestStatus>>(aj_);
			var al_ = context.Operators.Equal(ak_, "completed");
			var am_ = context.Operators.And(ah_, al_);

			return am_;
		};
		var m_ = context.Operators.Where<ServiceRequest>(k_, l_);
		var n_ = this.Pharmacologic_Therapy_for_Hypertension();
		var o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		var q_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		var r_ = context.Operators.ListUnion<MedicationRequest>(o_, q_);
		bool? s_(MedicationRequest MedicationRequestNotOrdered)
		{
			var as_ = MedicationRequestNotOrdered?.StatusElement;
			var at_ = as_?.Value;
			var au_ = context.Operators.Convert<string>(at_);
			var av_ = context.Operators.Equal(au_, "completed");

			return av_;
		};
		var t_ = context.Operators.Where<MedicationRequest>(r_, s_);
		var u_ = context.Operators.ListUnion<object>((m_ as IEnumerable<object>), (t_ as IEnumerable<object>));
		var v_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered();
		var w_ = context.Operators.ListUnion<object>(u_, (v_ as IEnumerable<object>));
		var x_ = this.NonPharmacological_Intervention_Not_Ordered();
		var y_ = context.Operators.ListUnion<object>(w_, (x_ as IEnumerable<object>));

		return y_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
	public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined() => 
		__Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined.Value;

	private IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient_Value()
	{
		var a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80();
		IEnumerable<Encounter> b_(Encounter ElevatedBPEncounter)
		{
			var x_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
			var y_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, null);
			var aa_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, null);
			var ab_ = context.Operators.ListUnion<ServiceRequest>(y_, aa_);
			var ac_ = this.Follow_up_2_3_months__finding_();
			var ad_ = context.Operators.ToList<CqlCode>(ac_);
			var ae_ = context.Operators.RetrieveByCodes<ServiceRequest>(ad_, null);
			var af_ = this.Follow_up_4_6_months__finding_();
			var ag_ = context.Operators.ToList<CqlCode>(af_);
			var ah_ = context.Operators.RetrieveByCodes<ServiceRequest>(ag_, null);
			var ai_ = context.Operators.ListUnion<ServiceRequest>(ae_, ah_);
			var aj_ = context.Operators.ListUnion<ServiceRequest>(ab_, ai_);
			bool? ak_(ServiceRequest ElevatedBPDeclinedInterventions)
			{
				bool? ao_(Extension @this)
				{
					var bi_ = @this?.Url;
					var bj_ = context.Operators.Convert<FhirUri>(bi_);
					var bk_ = FHIRHelpers_4_3_000.ToString(bj_);
					var bl_ = context.Operators.Equal(bk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

					return bl_;
				};
				var ap_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((ElevatedBPDeclinedInterventions is DomainResource)
						? ((ElevatedBPDeclinedInterventions as DomainResource).Extension)
						: null), ao_);
				DataType aq_(Extension @this)
				{
					var bm_ = @this?.Value;

					return bm_;
				};
				var ar_ = context.Operators.Select<Extension, DataType>(ap_, aq_);
				var as_ = context.Operators.SingletonFrom<DataType>(ar_);
				var at_ = context.Operators.Convert<CodeableConcept>(as_);
				var au_ = FHIRHelpers_4_3_000.ToConcept(at_);
				var av_ = this.Patient_Declined();
				var aw_ = context.Operators.ConceptInValueSet(au_, av_);
				var ax_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
				var ay_ = context.Operators.Convert<CqlDateTime>(ax_);
				var az_ = ElevatedBPEncounter?.Period;
				var ba_ = FHIRHelpers_4_3_000.ToInterval(az_);
				var bb_ = context.Operators.In<CqlDateTime>(ay_, ba_, "day");
				var bc_ = context.Operators.And(aw_, bb_);
				var bd_ = ElevatedBPDeclinedInterventions?.StatusElement;
				var be_ = bd_?.Value;
				var bf_ = context.Operators.Convert<Code<RequestStatus>>(be_);
				var bg_ = context.Operators.Equal(bf_, "completed");
				var bh_ = context.Operators.And(bc_, bg_);

				return bh_;
			};
			var al_ = context.Operators.Where<ServiceRequest>(aj_, ak_);
			Encounter am_(ServiceRequest ElevatedBPDeclinedInterventions) => 
				ElevatedBPEncounter;
			var an_ = context.Operators.Select<ServiceRequest, Encounter>(al_, am_);

			return an_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter ElevatedBPEncounter)
		{
			var bn_ = this.NonPharmacological_Intervention_Not_Ordered();
			bool? bo_(ServiceRequest NotOrdered)
			{
				var bs_ = NotOrdered?.AuthoredOnElement;
				var bt_ = context.Operators.Convert<CqlDateTime>(bs_);
				var bu_ = ElevatedBPEncounter?.Period;
				var bv_ = FHIRHelpers_4_3_000.ToInterval(bu_);
				var bw_ = context.Operators.In<CqlDateTime>(bt_, bv_, "day");

				return bw_;
			};
			var bp_ = context.Operators.Where<ServiceRequest>(bn_, bo_);
			Encounter bq_(ServiceRequest NotOrdered) => 
				ElevatedBPEncounter;
			var br_ = context.Operators.Select<ServiceRequest, Encounter>(bp_, bq_);

			return br_;
		};
		var f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		var h_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80();
		IEnumerable<Encounter> i_(Encounter FirstHTNEncounter)
		{
			var bx_ = this.Follow_Up_Within_4_Weeks();
			var by_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bx_, null);
			var ca_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bx_, null);
			var cb_ = context.Operators.ListUnion<ServiceRequest>(by_, ca_);
			var cc_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
			var cd_ = context.Operators.RetrieveByValueSet<ServiceRequest>(cc_, null);
			var cf_ = context.Operators.RetrieveByValueSet<ServiceRequest>(cc_, null);
			var cg_ = context.Operators.ListUnion<ServiceRequest>(cd_, cf_);
			var ch_ = context.Operators.ListUnion<ServiceRequest>(cb_, cg_);
			bool? ci_(ServiceRequest FirstHTNDeclinedInterventions)
			{
				bool? cm_(Extension @this)
				{
					var dg_ = @this?.Url;
					var dh_ = context.Operators.Convert<FhirUri>(dg_);
					var di_ = FHIRHelpers_4_3_000.ToString(dh_);
					var dj_ = context.Operators.Equal(di_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

					return dj_;
				};
				var cn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((FirstHTNDeclinedInterventions is DomainResource)
						? ((FirstHTNDeclinedInterventions as DomainResource).Extension)
						: null), cm_);
				DataType co_(Extension @this)
				{
					var dk_ = @this?.Value;

					return dk_;
				};
				var cp_ = context.Operators.Select<Extension, DataType>(cn_, co_);
				var cq_ = context.Operators.SingletonFrom<DataType>(cp_);
				var cr_ = context.Operators.Convert<CodeableConcept>(cq_);
				var cs_ = FHIRHelpers_4_3_000.ToConcept(cr_);
				var ct_ = this.Patient_Declined();
				var cu_ = context.Operators.ConceptInValueSet(cs_, ct_);
				var cv_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
				var cw_ = context.Operators.Convert<CqlDateTime>(cv_);
				var cx_ = FirstHTNEncounter?.Period;
				var cy_ = FHIRHelpers_4_3_000.ToInterval(cx_);
				var cz_ = context.Operators.In<CqlDateTime>(cw_, cy_, "day");
				var da_ = context.Operators.And(cu_, cz_);
				var db_ = FirstHTNDeclinedInterventions?.StatusElement;
				var dc_ = db_?.Value;
				var dd_ = context.Operators.Convert<Code<RequestStatus>>(dc_);
				var de_ = context.Operators.Equal(dd_, "completed");
				var df_ = context.Operators.And(da_, de_);

				return df_;
			};
			var cj_ = context.Operators.Where<ServiceRequest>(ch_, ci_);
			Encounter ck_(ServiceRequest FirstHTNDeclinedInterventions) => 
				FirstHTNEncounter;
			var cl_ = context.Operators.Select<ServiceRequest, Encounter>(cj_, ck_);

			return cl_;
		};
		var j_ = context.Operators.SelectMany<Encounter, Encounter>(h_, i_);
		IEnumerable<Encounter> l_(Encounter FirstHTNEncounter)
		{
			var dl_ = this.NonPharmacological_Intervention_Not_Ordered();
			bool? dm_(ServiceRequest NoNonPharm)
			{
				var dq_ = NoNonPharm?.AuthoredOnElement;
				var dr_ = context.Operators.Convert<CqlDateTime>(dq_);
				var ds_ = FirstHTNEncounter?.Period;
				var dt_ = FHIRHelpers_4_3_000.ToInterval(ds_);
				var du_ = context.Operators.In<CqlDateTime>(dr_, dt_, "day");

				return du_;
			};
			var dn_ = context.Operators.Where<ServiceRequest>(dl_, dm_);
			Encounter do_(ServiceRequest NoNonPharm) => 
				FirstHTNEncounter;
			var dp_ = context.Operators.Select<ServiceRequest, Encounter>(dn_, do_);

			return dp_;
		};
		var m_ = context.Operators.SelectMany<Encounter, Encounter>(h_, l_);
		var n_ = context.Operators.ListUnion<Encounter>(j_, m_);
		var o_ = context.Operators.ListUnion<Encounter>(g_, n_);
		var p_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89();
		IEnumerable<Encounter> q_(Encounter SecondHTNEncounter)
		{
			var dv_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined();
			bool? dw_(ServiceRequest SecondHTNDeclinedInterventions)
			{
				var ea_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
				var eb_ = context.Operators.Convert<CqlDateTime>(ea_);
				var ec_ = SecondHTNEncounter?.Period;
				var ed_ = FHIRHelpers_4_3_000.ToInterval(ec_);
				var ee_ = context.Operators.In<CqlDateTime>(eb_, ed_, "day");

				return ee_;
			};
			var dx_ = context.Operators.Where<ServiceRequest>(dv_, dw_);
			Encounter dy_(ServiceRequest SecondHTNDeclinedInterventions) => 
				SecondHTNEncounter;
			var dz_ = context.Operators.Select<ServiceRequest, Encounter>(dx_, dy_);

			return dz_;
		};
		var r_ = context.Operators.SelectMany<Encounter, Encounter>(p_, q_);
		var s_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90();
		IEnumerable<Encounter> t_(Encounter SecondHTN140Over90Encounter)
		{
			var ef_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined();
			bool? eg_(object SecondHTN140Over90DeclinedInterventions)
			{
				var ek_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
				var el_ = context.Operators.LateBoundProperty<CqlDateTime>(ek_, "value");
				var em_ = SecondHTN140Over90Encounter?.Period;
				var en_ = FHIRHelpers_4_3_000.ToInterval(em_);
				var eo_ = context.Operators.In<CqlDateTime>(el_, en_, "day");

				return eo_;
			};
			var eh_ = context.Operators.Where<object>(ef_, eg_);
			Encounter ei_(object SecondHTN140Over90DeclinedInterventions) => 
				SecondHTN140Over90Encounter;
			var ej_ = context.Operators.Select<object, Encounter>(eh_, ei_);

			return ej_;
		};
		var u_ = context.Operators.SelectMany<Encounter, Encounter>(s_, t_);
		var v_ = context.Operators.ListUnion<Encounter>(r_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(o_, v_);

		return w_;
	}

    [CqlDeclaration("Encounter with Order for Hypertension Follow Up Declined by Patient")]
	public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient() => 
		__Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		var a_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement();
		var b_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
