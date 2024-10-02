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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlValueSet Diagnosis_of_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263", default);

    [CqlDeclaration("Diagnosis of Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263")]
	public CqlValueSet Diagnosis_of_Hypertension() => 
		__Diagnosis_of_Hypertension.Value;

	private CqlValueSet Dietary_Recommendations_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515", default);

    [CqlDeclaration("Dietary Recommendations")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515")]
	public CqlValueSet Dietary_Recommendations() => 
		__Dietary_Recommendations.Value;

	private CqlValueSet Encounter_to_Screen_for_Blood_Pressure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920", default);

    [CqlDeclaration("Encounter to Screen for Blood Pressure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920")]
	public CqlValueSet Encounter_to_Screen_for_Blood_Pressure() => 
		__Encounter_to_Screen_for_Blood_Pressure.Value;

	private CqlValueSet Finding_of_Elevated_Blood_Pressure_or_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514", default);

    [CqlDeclaration("Finding of Elevated Blood Pressure or Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514")]
	public CqlValueSet Finding_of_Elevated_Blood_Pressure_or_Hypertension() => 
		__Finding_of_Elevated_Blood_Pressure_or_Hypertension.Value;

	private CqlValueSet Follow_Up_Within_4_Weeks_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578", default);

    [CqlDeclaration("Follow Up Within 4 Weeks")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578")]
	public CqlValueSet Follow_Up_Within_4_Weeks() => 
		__Follow_Up_Within_4_Weeks.Value;

	private CqlValueSet Laboratory_Tests_for_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482", default);

    [CqlDeclaration("Laboratory Tests for Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482")]
	public CqlValueSet Laboratory_Tests_for_Hypertension() => 
		__Laboratory_Tests_for_Hypertension.Value;

	private CqlValueSet Lifestyle_Recommendation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581", default);

    [CqlDeclaration("Lifestyle Recommendation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581")]
	public CqlValueSet Lifestyle_Recommendation() => 
		__Lifestyle_Recommendation.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Patient_Declined_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", default);

    [CqlDeclaration("Patient Declined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582")]
	public CqlValueSet Patient_Declined() => 
		__Patient_Declined.Value;

	private CqlValueSet Pharmacologic_Therapy_for_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577", default);

    [CqlDeclaration("Pharmacologic Therapy for Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577")]
	public CqlValueSet Pharmacologic_Therapy_for_Hypertension() => 
		__Pharmacologic_Therapy_for_Hypertension.Value;

	private CqlValueSet Recommendation_to_Increase_Physical_Activity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518", default);

    [CqlDeclaration("Recommendation to Increase Physical Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518")]
	public CqlValueSet Recommendation_to_Increase_Physical_Activity() => 
		__Recommendation_to_Increase_Physical_Activity.Value;

	private CqlValueSet Referral_or_Counseling_for_Alcohol_Consumption_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583", default);

    [CqlDeclaration("Referral or Counseling for Alcohol Consumption")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583")]
	public CqlValueSet Referral_or_Counseling_for_Alcohol_Consumption() => 
		__Referral_or_Counseling_for_Alcohol_Consumption.Value;

	private CqlValueSet Referral_to_Primary_Care_or_Alternate_Provider_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580", default);

    [CqlDeclaration("Referral to Primary Care or Alternate Provider")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580")]
	public CqlValueSet Referral_to_Primary_Care_or_Alternate_Provider() => 
		__Referral_to_Primary_Care_or_Alternate_Provider.Value;

	private CqlValueSet Weight_Reduction_Recommended_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510", default);

    [CqlDeclaration("Weight Reduction Recommended")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510")]
	public CqlValueSet Weight_Reduction_Recommended() => 
		__Weight_Reduction_Recommended.Value;

	private CqlCode Diastolic_blood_pressure_Value() => 
		new CqlCode("8462-4", "http://loinc.org", default, default);

    [CqlDeclaration("Diastolic blood pressure")]
	public CqlCode Diastolic_blood_pressure() => 
		__Diastolic_blood_pressure.Value;

	private CqlCode _12_lead_EKG_panel_Value() => 
		new CqlCode("34534-8", "http://loinc.org", default, default);

    [CqlDeclaration("12 lead EKG panel")]
	public CqlCode _12_lead_EKG_panel() => 
		___12_lead_EKG_panel.Value;

	private CqlCode EKG_study_Value() => 
		new CqlCode("11524-6", "http://loinc.org", default, default);

    [CqlDeclaration("EKG study")]
	public CqlCode EKG_study() => 
		__EKG_study.Value;

	private CqlCode Follow_up_2_3_months__finding__Value() => 
		new CqlCode("183624006", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Follow-up 2-3 months (finding)")]
	public CqlCode Follow_up_2_3_months__finding_() => 
		__Follow_up_2_3_months__finding_.Value;

	private CqlCode Follow_up_4_6_months__finding__Value() => 
		new CqlCode("183625007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Follow-up 4-6 months (finding)")]
	public CqlCode Follow_up_4_6_months__finding_() => 
		__Follow_up_4_6_months__finding_.Value;

	private CqlCode Systolic_blood_pressure_Value() => 
		new CqlCode("8480-6", "http://loinc.org", default, default);

    [CqlDeclaration("Systolic blood pressure")]
	public CqlCode Systolic_blood_pressure() => 
		__Systolic_blood_pressure.Value;

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("8462-4", "http://loinc.org", default, default),
			new CqlCode("34534-8", "http://loinc.org", default, default),
			new CqlCode("11524-6", "http://loinc.org", default, default),
			new CqlCode("8480-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("183624006", "http://snomed.info/sct", default, default),
			new CqlCode("183625007", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("PCSBPScreeningFollowUpFHIR-0.2.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Encounter_to_Screen_for_Blood_Pressure();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
			Period f_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(f_);
			bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
			Code<Encounter.EncounterStatus> i_ = ValidEncounter?.StatusElement;
			Encounter.EncounterStatus? j_ = i_?.Value;
			Code<Encounter.EncounterStatus> k_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(j_);
			bool? l_ = context.Operators.Equivalent(k_, "finished");
			bool? m_ = context.Operators.And(h_, l_);
			Coding n_ = ValidEncounter?.Class;
			CqlCode o_ = FHIRHelpers_4_3_000.ToCode(n_);
			CqlCode p_ = this.@virtual();
			bool? q_ = context.Operators.Equivalent(o_, p_);
			bool? r_ = context.Operators.Not(q_);
			bool? s_ = context.Operators.And(m_, r_);

			return s_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter during Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period() => 
		__Qualifying_Encounter_during_Measurement_Period.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			Patient d_ = this.Patient();
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDateTime g_ = context.Operators.ConvertStringToDateTime(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			int? j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
			bool? k_ = context.Operators.GreaterOrEqual(j_, 18);

			return k_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			CqlValueSet d_ = this.Diagnosis_of_Hypertension();
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? f_(Condition Hypertension)
			{
				bool? j_ = QICoreCommon_2_0_000.isProblemListItem(Hypertension);
				bool? k_ = QICoreCommon_2_0_000.isHealthConcern(Hypertension);
				bool? l_ = context.Operators.Or(j_, k_);
				bool? m_ = QICoreCommon_2_0_000.isActive(Hypertension);
				bool? n_ = context.Operators.And(l_, m_);
				CqlInterval<CqlDateTime> o_()
				{
					bool t_()
					{
						CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.prevalenceInterval(Hypertension);
						CqlDateTime v_ = context.Operators.Start(u_);

						return v_ is null;
					};
					if (t_())
					{
						return default;
					}
					else
					{
						CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.prevalenceInterval(Hypertension);
						CqlDateTime x_ = context.Operators.Start(w_);
						CqlDateTime z_ = context.Operators.Start(w_);
						CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(x_, z_, true, true);

						return aa_;
					}
				};
				Period p_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_3_000.ToInterval(p_);
				bool? r_ = context.Operators.SameOrBefore(o_(), q_, "day");
				bool? s_ = context.Operators.And(n_, r_);

				return s_;
			};
			IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
			Encounter h_(Condition Hypertension) => 
				QualifyingEncounter;
			IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
			bool? e_(Observation BloodPressure)
			{
				DataType ak_ = BloodPressure?.Effective;
				object al_ = FHIRHelpers_4_3_000.ToValue(ak_);
				CqlInterval<CqlDateTime> am_ = QICoreCommon_2_0_000.toInterval(al_);
				CqlDateTime an_ = context.Operators.End(am_);
				Period ao_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_3_000.ToInterval(ao_);
				bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, default);
				Code<ObservationStatus> ar_ = BloodPressure?.StatusElement;
				ObservationStatus? as_ = ar_?.Value;
				string at_ = context.Operators.Convert<string>(as_);
				string[] au_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? av_ = context.Operators.In<string>(at_, au_ as IEnumerable<string>);
				bool? aw_ = context.Operators.And(aq_, av_);

				return aw_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType ax_ = @this?.Effective;
				object ay_ = FHIRHelpers_4_3_000.ToValue(ax_);
				CqlInterval<CqlDateTime> az_ = QICoreCommon_2_0_000.toInterval(ay_);
				CqlDateTime ba_ = context.Operators.Start(az_);

				return ba_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept bb_ = @this?.Code;
				List<Coding> bc_ = bb_?.Coding;
				Coding bd_ = context.Operators.First<Coding>((IEnumerable<Coding>)bc_);
				FhirUri be_ = bd_?.SystemElement;
				string bf_ = FHIRHelpers_4_3_000.ToString(be_);
				bool? bg_ = context.Operators.Equal(bf_, "http://loinc.org");
				List<Coding> bi_ = bb_?.Coding;
				Coding bj_ = context.Operators.First<Coding>((IEnumerable<Coding>)bi_);
				Code bk_ = bj_?.CodeElement;
				string bl_ = FHIRHelpers_4_3_000.ToString(bk_);
				bool? bm_ = context.Operators.Equal(bl_, "8480-6");
				bool? bn_ = context.Operators.And(bg_, bm_);

				return bn_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = context.Operators.Quantity(1m, "mm[Hg]");
			CqlQuantity q_ = context.Operators.Quantity(120m, "mm[Hg]");
			CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, false);
			bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, default);
			bool? u_(Observation BloodPressure)
			{
				DataType bo_ = BloodPressure?.Effective;
				object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
				CqlInterval<CqlDateTime> bq_ = QICoreCommon_2_0_000.toInterval(bp_);
				CqlDateTime br_ = context.Operators.End(bq_);
				Period bs_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_3_000.ToInterval(bs_);
				bool? bu_ = context.Operators.In<CqlDateTime>(br_, bt_, default);
				Code<ObservationStatus> bv_ = BloodPressure?.StatusElement;
				ObservationStatus? bw_ = bv_?.Value;
				string bx_ = context.Operators.Convert<string>(bw_);
				string[] by_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bz_ = context.Operators.In<string>(bx_, by_ as IEnumerable<string>);
				bool? ca_ = context.Operators.And(bu_, bz_);

				return ca_;
			};
			IEnumerable<Observation> v_ = context.Operators.Where<Observation>(d_, u_);
			object w_(Observation @this)
			{
				DataType cb_ = @this?.Effective;
				object cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
				CqlInterval<CqlDateTime> cd_ = QICoreCommon_2_0_000.toInterval(cc_);
				CqlDateTime ce_ = context.Operators.Start(cd_);

				return ce_;
			};
			IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			Observation y_ = context.Operators.Last<Observation>(x_);
			List<Observation.ComponentComponent> z_ = y_?.Component;
			bool? aa_(Observation.ComponentComponent @this)
			{
				CodeableConcept cf_ = @this?.Code;
				List<Coding> cg_ = cf_?.Coding;
				Coding ch_ = context.Operators.First<Coding>((IEnumerable<Coding>)cg_);
				FhirUri ci_ = ch_?.SystemElement;
				string cj_ = FHIRHelpers_4_3_000.ToString(ci_);
				bool? ck_ = context.Operators.Equal(cj_, "http://loinc.org");
				List<Coding> cm_ = cf_?.Coding;
				Coding cn_ = context.Operators.First<Coding>((IEnumerable<Coding>)cm_);
				Code co_ = cn_?.CodeElement;
				string cp_ = FHIRHelpers_4_3_000.ToString(co_);
				bool? cq_ = context.Operators.Equal(cp_, "8462-4");
				bool? cr_ = context.Operators.And(ck_, cq_);

				return cr_;
			};
			IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
			Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
			DataType ad_ = ac_?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlQuantity ag_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlInterval<CqlQuantity> ah_ = context.Operators.Interval(p_, ag_, true, false);
			bool? ai_ = context.Operators.In<CqlQuantity>(ae_ as CqlQuantity, ah_, default);
			bool? aj_ = context.Operators.And(s_, ai_);

			return aj_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Normal Blood Pressure Reading")]
	public IEnumerable<Encounter> Encounter_with_Normal_Blood_Pressure_Reading() => 
		__Encounter_with_Normal_Blood_Pressure_Reading.Value;

	private IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
			bool? e_(Observation BloodPressure)
			{
				DataType ak_ = BloodPressure?.Effective;
				object al_ = FHIRHelpers_4_3_000.ToValue(ak_);
				CqlInterval<CqlDateTime> am_ = QICoreCommon_2_0_000.toInterval(al_);
				CqlDateTime an_ = context.Operators.End(am_);
				Period ao_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_3_000.ToInterval(ao_);
				bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, default);
				Code<ObservationStatus> ar_ = BloodPressure?.StatusElement;
				ObservationStatus? as_ = ar_?.Value;
				string at_ = context.Operators.Convert<string>(as_);
				string[] au_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? av_ = context.Operators.In<string>(at_, au_ as IEnumerable<string>);
				bool? aw_ = context.Operators.And(aq_, av_);

				return aw_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType ax_ = @this?.Effective;
				object ay_ = FHIRHelpers_4_3_000.ToValue(ax_);
				CqlInterval<CqlDateTime> az_ = QICoreCommon_2_0_000.toInterval(ay_);
				CqlDateTime ba_ = context.Operators.Start(az_);

				return ba_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept bb_ = @this?.Code;
				List<Coding> bc_ = bb_?.Coding;
				Coding bd_ = context.Operators.First<Coding>((IEnumerable<Coding>)bc_);
				FhirUri be_ = bd_?.SystemElement;
				string bf_ = FHIRHelpers_4_3_000.ToString(be_);
				bool? bg_ = context.Operators.Equal(bf_, "http://loinc.org");
				List<Coding> bi_ = bb_?.Coding;
				Coding bj_ = context.Operators.First<Coding>((IEnumerable<Coding>)bi_);
				Code bk_ = bj_?.CodeElement;
				string bl_ = FHIRHelpers_4_3_000.ToString(bk_);
				bool? bm_ = context.Operators.Equal(bl_, "8480-6");
				bool? bn_ = context.Operators.And(bg_, bm_);

				return bn_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = context.Operators.Quantity(120m, "mm[Hg]");
			CqlQuantity q_ = context.Operators.Quantity(129m, "mm[Hg]");
			CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
			bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, default);
			bool? u_(Observation BloodPressure)
			{
				DataType bo_ = BloodPressure?.Effective;
				object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
				CqlInterval<CqlDateTime> bq_ = QICoreCommon_2_0_000.toInterval(bp_);
				CqlDateTime br_ = context.Operators.End(bq_);
				Period bs_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_3_000.ToInterval(bs_);
				bool? bu_ = context.Operators.In<CqlDateTime>(br_, bt_, default);
				Code<ObservationStatus> bv_ = BloodPressure?.StatusElement;
				ObservationStatus? bw_ = bv_?.Value;
				string bx_ = context.Operators.Convert<string>(bw_);
				string[] by_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bz_ = context.Operators.In<string>(bx_, by_ as IEnumerable<string>);
				bool? ca_ = context.Operators.And(bu_, bz_);

				return ca_;
			};
			IEnumerable<Observation> v_ = context.Operators.Where<Observation>(d_, u_);
			object w_(Observation @this)
			{
				DataType cb_ = @this?.Effective;
				object cc_ = FHIRHelpers_4_3_000.ToValue(cb_);
				CqlInterval<CqlDateTime> cd_ = QICoreCommon_2_0_000.toInterval(cc_);
				CqlDateTime ce_ = context.Operators.Start(cd_);

				return ce_;
			};
			IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			Observation y_ = context.Operators.Last<Observation>(x_);
			List<Observation.ComponentComponent> z_ = y_?.Component;
			bool? aa_(Observation.ComponentComponent @this)
			{
				CodeableConcept cf_ = @this?.Code;
				List<Coding> cg_ = cf_?.Coding;
				Coding ch_ = context.Operators.First<Coding>((IEnumerable<Coding>)cg_);
				FhirUri ci_ = ch_?.SystemElement;
				string cj_ = FHIRHelpers_4_3_000.ToString(ci_);
				bool? ck_ = context.Operators.Equal(cj_, "http://loinc.org");
				List<Coding> cm_ = cf_?.Coding;
				Coding cn_ = context.Operators.First<Coding>((IEnumerable<Coding>)cm_);
				Code co_ = cn_?.CodeElement;
				string cp_ = FHIRHelpers_4_3_000.ToString(co_);
				bool? cq_ = context.Operators.Equal(cp_, "8462-4");
				bool? cr_ = context.Operators.And(ck_, cq_);

				return cr_;
			};
			IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
			Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
			DataType ad_ = ac_?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlQuantity af_ = context.Operators.Quantity(1m, "mm[Hg]");
			CqlQuantity ag_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlInterval<CqlQuantity> ah_ = context.Operators.Interval(af_, ag_, true, false);
			bool? ai_ = context.Operators.In<CqlQuantity>(ae_ as CqlQuantity, ah_, default);
			bool? aj_ = context.Operators.And(s_, ai_);

			return aj_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80")]
	public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80() => 
		__Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80.Value;

	private IEnumerable<ServiceRequest> Follow_up_with_Rescreen_in_2_to_6_Months_Value()
	{
		CqlCode a_ = this.Follow_up_2_3_months__finding_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<ServiceRequest> c_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		CqlCode d_ = this.Follow_up_4_6_months__finding_();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
		bool? h_(ServiceRequest FollowUp)
		{
			Code<RequestIntent> j_ = FollowUp?.IntentElement;
			RequestIntent? k_ = j_?.Value;
			Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
			bool? m_ = context.Operators.Equivalent(l_, "order");

			return m_;
		};
		IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Follow up with Rescreen in 2 to 6 Months")]
	public IEnumerable<ServiceRequest> Follow_up_with_Rescreen_in_2_to_6_Months() => 
		__Follow_up_with_Rescreen_in_2_to_6_Months.Value;

	private IEnumerable<ServiceRequest> NonPharmacological_Interventions_Value()
	{
		CqlValueSet a_ = this.Lifestyle_Recommendation();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		CqlValueSet c_ = this.Weight_Reduction_Recommended();
		IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Dietary_Recommendations();
		IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		CqlValueSet h_ = this.Recommendation_to_Increase_Physical_Activity();
		IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
		CqlValueSet l_ = this.Referral_or_Counseling_for_Alcohol_Consumption();
		IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> n_ = context.Operators.Union<ServiceRequest>(k_, m_);
		bool? o_(ServiceRequest NonPharmaInterventions)
		{
			Code<RequestIntent> q_ = NonPharmaInterventions?.IntentElement;
			RequestIntent? r_ = q_?.Value;
			Code<RequestIntent> s_ = context.Operators.Convert<Code<RequestIntent>>(r_);
			bool? t_ = context.Operators.Equivalent(s_, "order");

			return t_;
		};
		IEnumerable<ServiceRequest> p_ = context.Operators.Where<ServiceRequest>(n_, o_);

		return p_;
	}

    [CqlDeclaration("NonPharmacological Interventions")]
	public IEnumerable<ServiceRequest> NonPharmacological_Interventions() => 
		__NonPharmacological_Interventions.Value;

	private IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading_Value()
	{
		CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		bool? c_(ServiceRequest Referral)
		{
			List<CodeableConcept> e_ = Referral?.ReasonCode;
			CqlConcept f_(CodeableConcept @this)
			{
				CqlConcept o_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return o_;
			};
			IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
			CqlValueSet h_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension();
			bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
			Code<RequestIntent> j_ = Referral?.IntentElement;
			RequestIntent? k_ = j_?.Value;
			Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
			bool? m_ = context.Operators.Equivalent(l_, "order");
			bool? n_ = context.Operators.And(i_, m_);

			return n_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading")]
	public IEnumerable<ServiceRequest> Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading() => 
		__Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading.Value;

	private IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80();
		IEnumerable<Encounter> b_(Encounter ElevatedEncounter)
		{
			IEnumerable<ServiceRequest> j_ = this.Follow_up_with_Rescreen_in_2_to_6_Months();
			bool? k_(ServiceRequest Twoto6MonthRescreen)
			{
				FhirDateTime o_ = Twoto6MonthRescreen?.AuthoredOnElement;
				CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
				Period q_ = ElevatedEncounter?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, "day");

				return s_;
			};
			IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
			Encounter m_(ServiceRequest Twoto6MonthRescreen) => 
				ElevatedEncounter;
			IEnumerable<Encounter> n_ = context.Operators.Select<ServiceRequest, Encounter>(l_, m_);

			return n_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> d_(Encounter ElevatedEncounter)
		{
			IEnumerable<ServiceRequest> t_ = this.NonPharmacological_Interventions();
			bool? u_(ServiceRequest NonPharmInterventions)
			{
				FhirDateTime y_ = NonPharmInterventions?.AuthoredOnElement;
				CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
				Period aa_ = ElevatedEncounter?.Period;
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_3_000.ToInterval(aa_);
				bool? ac_ = context.Operators.In<CqlDateTime>(z_, ab_, "day");

				return ac_;
			};
			IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
			Encounter w_(ServiceRequest NonPharmInterventions) => 
				ElevatedEncounter;
			IEnumerable<Encounter> x_ = context.Operators.Select<ServiceRequest, Encounter>(v_, w_);

			return x_;
		};
		IEnumerable<Encounter> e_ = context.Operators.SelectMany<Encounter, Encounter>(c_, d_);
		IEnumerable<Encounter> g_(Encounter ElevatedEncounter)
		{
			IEnumerable<ServiceRequest> ad_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? ae_(ServiceRequest Referral)
			{
				FhirDateTime ai_ = Referral?.AuthoredOnElement;
				CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
				Period ak_ = ElevatedEncounter?.Period;
				CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_3_000.ToInterval(ak_);
				bool? am_ = context.Operators.In<CqlDateTime>(aj_, al_, "day");

				return am_;
			};
			IEnumerable<ServiceRequest> af_ = context.Operators.Where<ServiceRequest>(ad_, ae_);
			Encounter ag_(ServiceRequest Referral) => 
				ElevatedEncounter;
			IEnumerable<Encounter> ah_ = context.Operators.Select<ServiceRequest, Encounter>(af_, ag_);

			return ah_;
		};
		IEnumerable<Encounter> h_ = context.Operators.SelectMany<Encounter, Encounter>(a_, g_);
		IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(e_, h_);

		return i_;
	}

    [CqlDeclaration("Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions() => 
		__Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
			bool? e_(Observation BloodPressure)
			{
				DataType bk_ = BloodPressure?.Effective;
				object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);
				CqlInterval<CqlDateTime> bm_ = QICoreCommon_2_0_000.toInterval(bl_);
				CqlDateTime bn_ = context.Operators.End(bm_);
				Period bo_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_3_000.ToInterval(bo_);
				CqlDateTime bq_ = context.Operators.Start(bp_);
				CqlQuantity br_ = context.Operators.Quantity(1m, "year");
				CqlDateTime bs_ = context.Operators.Subtract(bq_, br_);
				CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_3_000.ToInterval(bo_);
				CqlDateTime bv_ = context.Operators.Start(bu_);
				CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bs_, bv_, true, true);
				bool? bx_ = context.Operators.In<CqlDateTime>(bn_, bw_, default);
				CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_3_000.ToInterval(bo_);
				CqlDateTime ca_ = context.Operators.Start(bz_);
				bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
				bool? cc_ = context.Operators.And(bx_, cb_);
				Code<ObservationStatus> cd_ = BloodPressure?.StatusElement;
				ObservationStatus? ce_ = cd_?.Value;
				string cf_ = context.Operators.Convert<string>(ce_);
				string[] cg_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ch_ = context.Operators.In<string>(cf_, cg_ as IEnumerable<string>);
				bool? ci_ = context.Operators.And(cc_, ch_);

				return ci_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType cj_ = @this?.Effective;
				object ck_ = FHIRHelpers_4_3_000.ToValue(cj_);
				CqlInterval<CqlDateTime> cl_ = QICoreCommon_2_0_000.toInterval(ck_);
				CqlDateTime cm_ = context.Operators.Start(cl_);

				return cm_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept cn_ = @this?.Code;
				List<Coding> co_ = cn_?.Coding;
				Coding cp_ = context.Operators.First<Coding>((IEnumerable<Coding>)co_);
				FhirUri cq_ = cp_?.SystemElement;
				string cr_ = FHIRHelpers_4_3_000.ToString(cq_);
				bool? cs_ = context.Operators.Equal(cr_, "http://loinc.org");
				List<Coding> cu_ = cn_?.Coding;
				Coding cv_ = context.Operators.First<Coding>((IEnumerable<Coding>)cu_);
				Code cw_ = cv_?.CodeElement;
				string cx_ = FHIRHelpers_4_3_000.ToString(cw_);
				bool? cy_ = context.Operators.Equal(cx_, "8480-6");
				bool? cz_ = context.Operators.And(cs_, cy_);

				return cz_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? q_ = context.Operators.Greater(o_ as CqlQuantity, p_);
			bool? s_(Observation BloodPressure)
			{
				DataType da_ = BloodPressure?.Effective;
				object db_ = FHIRHelpers_4_3_000.ToValue(da_);
				CqlInterval<CqlDateTime> dc_ = QICoreCommon_2_0_000.toInterval(db_);
				CqlDateTime dd_ = context.Operators.End(dc_);
				Period de_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_3_000.ToInterval(de_);
				CqlDateTime dg_ = context.Operators.Start(df_);
				CqlQuantity dh_ = context.Operators.Quantity(1m, "year");
				CqlDateTime di_ = context.Operators.Subtract(dg_, dh_);
				CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_3_000.ToInterval(de_);
				CqlDateTime dl_ = context.Operators.Start(dk_);
				CqlInterval<CqlDateTime> dm_ = context.Operators.Interval(di_, dl_, true, true);
				bool? dn_ = context.Operators.In<CqlDateTime>(dd_, dm_, default);
				CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_3_000.ToInterval(de_);
				CqlDateTime dq_ = context.Operators.Start(dp_);
				bool? dr_ = context.Operators.Not((bool?)(dq_ is null));
				bool? ds_ = context.Operators.And(dn_, dr_);
				Code<ObservationStatus> dt_ = BloodPressure?.StatusElement;
				ObservationStatus? du_ = dt_?.Value;
				string dv_ = context.Operators.Convert<string>(du_);
				string[] dw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? dx_ = context.Operators.In<string>(dv_, dw_ as IEnumerable<string>);
				bool? dy_ = context.Operators.And(ds_, dx_);

				return dy_;
			};
			IEnumerable<Observation> t_ = context.Operators.Where<Observation>(d_, s_);
			object u_(Observation @this)
			{
				DataType dz_ = @this?.Effective;
				object ea_ = FHIRHelpers_4_3_000.ToValue(dz_);
				CqlInterval<CqlDateTime> eb_ = QICoreCommon_2_0_000.toInterval(ea_);
				CqlDateTime ec_ = context.Operators.Start(eb_);

				return ec_;
			};
			IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			Observation w_ = context.Operators.Last<Observation>(v_);
			List<Observation.ComponentComponent> x_ = w_?.Component;
			bool? y_(Observation.ComponentComponent @this)
			{
				CodeableConcept ed_ = @this?.Code;
				List<Coding> ee_ = ed_?.Coding;
				Coding ef_ = context.Operators.First<Coding>((IEnumerable<Coding>)ee_);
				FhirUri eg_ = ef_?.SystemElement;
				string eh_ = FHIRHelpers_4_3_000.ToString(eg_);
				bool? ei_ = context.Operators.Equal(eh_, "http://loinc.org");
				List<Coding> ek_ = ed_?.Coding;
				Coding el_ = context.Operators.First<Coding>((IEnumerable<Coding>)ek_);
				Code em_ = el_?.CodeElement;
				string en_ = FHIRHelpers_4_3_000.ToString(em_);
				bool? eo_ = context.Operators.Equal(en_, "8462-4");
				bool? ep_ = context.Operators.And(ei_, eo_);

				return ep_;
			};
			IEnumerable<Observation.ComponentComponent> z_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)x_, y_);
			Observation.ComponentComponent aa_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(z_);
			DataType ab_ = aa_?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ae_ = context.Operators.Greater(ac_ as CqlQuantity, p_);
			bool? af_ = context.Operators.And(q_, ae_);
			bool? ah_(Observation BloodPressure)
			{
				DataType eq_ = BloodPressure?.Effective;
				object er_ = FHIRHelpers_4_3_000.ToValue(eq_);
				CqlInterval<CqlDateTime> es_ = QICoreCommon_2_0_000.toInterval(er_);
				CqlDateTime et_ = context.Operators.End(es_);
				Period eu_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_3_000.ToInterval(eu_);
				CqlDateTime ew_ = context.Operators.Start(ev_);
				CqlQuantity ex_ = context.Operators.Quantity(1m, "year");
				CqlDateTime ey_ = context.Operators.Subtract(ew_, ex_);
				CqlInterval<CqlDateTime> fa_ = FHIRHelpers_4_3_000.ToInterval(eu_);
				CqlDateTime fb_ = context.Operators.Start(fa_);
				CqlInterval<CqlDateTime> fc_ = context.Operators.Interval(ey_, fb_, true, true);
				bool? fd_ = context.Operators.In<CqlDateTime>(et_, fc_, default);
				CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_3_000.ToInterval(eu_);
				CqlDateTime fg_ = context.Operators.Start(ff_);
				bool? fh_ = context.Operators.Not((bool?)(fg_ is null));
				bool? fi_ = context.Operators.And(fd_, fh_);
				Code<ObservationStatus> fj_ = BloodPressure?.StatusElement;
				ObservationStatus? fk_ = fj_?.Value;
				string fl_ = context.Operators.Convert<string>(fk_);
				string[] fm_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? fn_ = context.Operators.In<string>(fl_, fm_ as IEnumerable<string>);
				bool? fo_ = context.Operators.And(fi_, fn_);

				return fo_;
			};
			IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(d_, ah_);
			object aj_(Observation @this)
			{
				DataType fp_ = @this?.Effective;
				object fq_ = FHIRHelpers_4_3_000.ToValue(fp_);
				CqlInterval<CqlDateTime> fr_ = QICoreCommon_2_0_000.toInterval(fq_);
				CqlDateTime fs_ = context.Operators.Start(fr_);

				return fs_;
			};
			IEnumerable<Observation> ak_ = context.Operators.SortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
			Observation al_ = context.Operators.Last<Observation>(ak_);
			List<Observation.ComponentComponent> am_ = al_?.Component;
			bool? an_(Observation.ComponentComponent @this)
			{
				CodeableConcept ft_ = @this?.Code;
				List<Coding> fu_ = ft_?.Coding;
				Coding fv_ = context.Operators.First<Coding>((IEnumerable<Coding>)fu_);
				FhirUri fw_ = fv_?.SystemElement;
				string fx_ = FHIRHelpers_4_3_000.ToString(fw_);
				bool? fy_ = context.Operators.Equal(fx_, "http://loinc.org");
				List<Coding> ga_ = ft_?.Coding;
				Coding gb_ = context.Operators.First<Coding>((IEnumerable<Coding>)ga_);
				Code gc_ = gb_?.CodeElement;
				string gd_ = FHIRHelpers_4_3_000.ToString(gc_);
				bool? ge_ = context.Operators.Equal(gd_, "8480-6");
				bool? gf_ = context.Operators.And(fy_, ge_);

				return gf_;
			};
			IEnumerable<Observation.ComponentComponent> ao_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)am_, an_);
			Observation.ComponentComponent ap_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ao_);
			DataType aq_ = ap_?.Value;
			object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
			CqlQuantity as_ = context.Operators.Quantity(130m, "mm[Hg]");
			bool? at_ = context.Operators.GreaterOrEqual(ar_ as CqlQuantity, as_);
			bool? av_(Observation BloodPressure)
			{
				DataType gg_ = BloodPressure?.Effective;
				object gh_ = FHIRHelpers_4_3_000.ToValue(gg_);
				CqlInterval<CqlDateTime> gi_ = QICoreCommon_2_0_000.toInterval(gh_);
				CqlDateTime gj_ = context.Operators.End(gi_);
				Period gk_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> gl_ = FHIRHelpers_4_3_000.ToInterval(gk_);
				CqlDateTime gm_ = context.Operators.Start(gl_);
				CqlQuantity gn_ = context.Operators.Quantity(1m, "year");
				CqlDateTime go_ = context.Operators.Subtract(gm_, gn_);
				CqlInterval<CqlDateTime> gq_ = FHIRHelpers_4_3_000.ToInterval(gk_);
				CqlDateTime gr_ = context.Operators.Start(gq_);
				CqlInterval<CqlDateTime> gs_ = context.Operators.Interval(go_, gr_, true, true);
				bool? gt_ = context.Operators.In<CqlDateTime>(gj_, gs_, default);
				CqlInterval<CqlDateTime> gv_ = FHIRHelpers_4_3_000.ToInterval(gk_);
				CqlDateTime gw_ = context.Operators.Start(gv_);
				bool? gx_ = context.Operators.Not((bool?)(gw_ is null));
				bool? gy_ = context.Operators.And(gt_, gx_);
				Code<ObservationStatus> gz_ = BloodPressure?.StatusElement;
				ObservationStatus? ha_ = gz_?.Value;
				string hb_ = context.Operators.Convert<string>(ha_);
				string[] hc_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? hd_ = context.Operators.In<string>(hb_, hc_ as IEnumerable<string>);
				bool? he_ = context.Operators.And(gy_, hd_);

				return he_;
			};
			IEnumerable<Observation> aw_ = context.Operators.Where<Observation>(d_, av_);
			object ax_(Observation @this)
			{
				DataType hf_ = @this?.Effective;
				object hg_ = FHIRHelpers_4_3_000.ToValue(hf_);
				CqlInterval<CqlDateTime> hh_ = QICoreCommon_2_0_000.toInterval(hg_);
				CqlDateTime hi_ = context.Operators.Start(hh_);

				return hi_;
			};
			IEnumerable<Observation> ay_ = context.Operators.SortBy<Observation>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
			Observation az_ = context.Operators.Last<Observation>(ay_);
			List<Observation.ComponentComponent> ba_ = az_?.Component;
			bool? bb_(Observation.ComponentComponent @this)
			{
				CodeableConcept hj_ = @this?.Code;
				List<Coding> hk_ = hj_?.Coding;
				Coding hl_ = context.Operators.First<Coding>((IEnumerable<Coding>)hk_);
				FhirUri hm_ = hl_?.SystemElement;
				string hn_ = FHIRHelpers_4_3_000.ToString(hm_);
				bool? ho_ = context.Operators.Equal(hn_, "http://loinc.org");
				List<Coding> hq_ = hj_?.Coding;
				Coding hr_ = context.Operators.First<Coding>((IEnumerable<Coding>)hq_);
				Code hs_ = hr_?.CodeElement;
				string ht_ = FHIRHelpers_4_3_000.ToString(hs_);
				bool? hu_ = context.Operators.Equal(ht_, "8462-4");
				bool? hv_ = context.Operators.And(ho_, hu_);

				return hv_;
			};
			IEnumerable<Observation.ComponentComponent> bc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ba_, bb_);
			Observation.ComponentComponent bd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bc_);
			DataType be_ = bd_?.Value;
			object bf_ = FHIRHelpers_4_3_000.ToValue(be_);
			CqlQuantity bg_ = context.Operators.Quantity(80m, "mm[Hg]");
			bool? bh_ = context.Operators.GreaterOrEqual(bf_ as CqlQuantity, bg_);
			bool? bi_ = context.Operators.Or(at_, bh_);
			bool? bj_ = context.Operators.And(af_, bi_);

			return bj_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Hypertensive Reading Within Year Prior")]
	public IEnumerable<Encounter> Encounter_with_Hypertensive_Reading_Within_Year_Prior() => 
		__Encounter_with_Hypertensive_Reading_Within_Year_Prior.Value;

	private IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
			bool? g_(Observation BloodPressure)
			{
				DataType bm_ = BloodPressure?.Effective;
				object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);
				CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_0_000.toInterval(bn_);
				CqlDateTime bp_ = context.Operators.End(bo_);
				Period bq_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_3_000.ToInterval(bq_);
				bool? bs_ = context.Operators.In<CqlDateTime>(bp_, br_, "day");

				return bs_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType bt_ = @this?.Effective;
				object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
				CqlInterval<CqlDateTime> bv_ = QICoreCommon_2_0_000.toInterval(bu_);
				CqlDateTime bw_ = context.Operators.Start(bv_);

				return bw_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.Last<Observation>(j_);
			List<Observation.ComponentComponent> l_ = k_?.Component;
			bool? m_(Observation.ComponentComponent @this)
			{
				CodeableConcept bx_ = @this?.Code;
				List<Coding> by_ = bx_?.Coding;
				Coding bz_ = context.Operators.First<Coding>((IEnumerable<Coding>)by_);
				FhirUri ca_ = bz_?.SystemElement;
				string cb_ = FHIRHelpers_4_3_000.ToString(ca_);
				bool? cc_ = context.Operators.Equal(cb_, "http://loinc.org");
				List<Coding> ce_ = bx_?.Coding;
				Coding cf_ = context.Operators.First<Coding>((IEnumerable<Coding>)ce_);
				Code cg_ = cf_?.CodeElement;
				string ch_ = FHIRHelpers_4_3_000.ToString(cg_);
				bool? ci_ = context.Operators.Equal(ch_, "8480-6");
				bool? cj_ = context.Operators.And(cc_, ci_);

				return cj_;
			};
			IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
			Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
			DataType p_ = o_?.Value;
			object q_ = FHIRHelpers_4_3_000.ToValue(p_);
			CqlQuantity r_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);
			bool? u_(Observation BloodPressure)
			{
				DataType ck_ = BloodPressure?.Effective;
				object cl_ = FHIRHelpers_4_3_000.ToValue(ck_);
				CqlInterval<CqlDateTime> cm_ = QICoreCommon_2_0_000.toInterval(cl_);
				CqlDateTime cn_ = context.Operators.End(cm_);
				Period co_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_3_000.ToInterval(co_);
				bool? cq_ = context.Operators.In<CqlDateTime>(cn_, cp_, "day");

				return cq_;
			};
			IEnumerable<Observation> v_ = context.Operators.Where<Observation>(f_, u_);
			object w_(Observation @this)
			{
				DataType cr_ = @this?.Effective;
				object cs_ = FHIRHelpers_4_3_000.ToValue(cr_);
				CqlInterval<CqlDateTime> ct_ = QICoreCommon_2_0_000.toInterval(cs_);
				CqlDateTime cu_ = context.Operators.Start(ct_);

				return cu_;
			};
			IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			Observation y_ = context.Operators.Last<Observation>(x_);
			List<Observation.ComponentComponent> z_ = y_?.Component;
			bool? aa_(Observation.ComponentComponent @this)
			{
				CodeableConcept cv_ = @this?.Code;
				List<Coding> cw_ = cv_?.Coding;
				Coding cx_ = context.Operators.First<Coding>((IEnumerable<Coding>)cw_);
				FhirUri cy_ = cx_?.SystemElement;
				string cz_ = FHIRHelpers_4_3_000.ToString(cy_);
				bool? da_ = context.Operators.Equal(cz_, "http://loinc.org");
				List<Coding> dc_ = cv_?.Coding;
				Coding dd_ = context.Operators.First<Coding>((IEnumerable<Coding>)dc_);
				Code de_ = dd_?.CodeElement;
				string df_ = FHIRHelpers_4_3_000.ToString(de_);
				bool? dg_ = context.Operators.Equal(df_, "8462-4");
				bool? dh_ = context.Operators.And(da_, dg_);

				return dh_;
			};
			IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
			Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
			DataType ad_ = ac_?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			bool? ag_ = context.Operators.Greater(ae_ as CqlQuantity, r_);
			bool? ah_ = context.Operators.And(s_, ag_);
			bool? aj_(Observation BloodPressure)
			{
				DataType di_ = BloodPressure?.Effective;
				object dj_ = FHIRHelpers_4_3_000.ToValue(di_);
				CqlInterval<CqlDateTime> dk_ = QICoreCommon_2_0_000.toInterval(dj_);
				CqlDateTime dl_ = context.Operators.End(dk_);
				Period dm_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_3_000.ToInterval(dm_);
				bool? do_ = context.Operators.In<CqlDateTime>(dl_, dn_, "day");

				return do_;
			};
			IEnumerable<Observation> ak_ = context.Operators.Where<Observation>(f_, aj_);
			object al_(Observation @this)
			{
				DataType dp_ = @this?.Effective;
				object dq_ = FHIRHelpers_4_3_000.ToValue(dp_);
				CqlInterval<CqlDateTime> dr_ = QICoreCommon_2_0_000.toInterval(dq_);
				CqlDateTime ds_ = context.Operators.Start(dr_);

				return ds_;
			};
			IEnumerable<Observation> am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
			Observation an_ = context.Operators.Last<Observation>(am_);
			List<Observation.ComponentComponent> ao_ = an_?.Component;
			bool? ap_(Observation.ComponentComponent @this)
			{
				CodeableConcept dt_ = @this?.Code;
				List<Coding> du_ = dt_?.Coding;
				Coding dv_ = context.Operators.First<Coding>((IEnumerable<Coding>)du_);
				FhirUri dw_ = dv_?.SystemElement;
				string dx_ = FHIRHelpers_4_3_000.ToString(dw_);
				bool? dy_ = context.Operators.Equal(dx_, "http://loinc.org");
				List<Coding> ea_ = dt_?.Coding;
				Coding eb_ = context.Operators.First<Coding>((IEnumerable<Coding>)ea_);
				Code ec_ = eb_?.CodeElement;
				string ed_ = FHIRHelpers_4_3_000.ToString(ec_);
				bool? ee_ = context.Operators.Equal(ed_, "8480-6");
				bool? ef_ = context.Operators.And(dy_, ee_);

				return ef_;
			};
			IEnumerable<Observation.ComponentComponent> aq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ao_, ap_);
			Observation.ComponentComponent ar_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aq_);
			DataType as_ = ar_?.Value;
			object at_ = FHIRHelpers_4_3_000.ToValue(as_);
			CqlQuantity au_ = context.Operators.Quantity(130m, "mm[Hg]");
			bool? av_ = context.Operators.GreaterOrEqual(at_ as CqlQuantity, au_);
			bool? ax_(Observation BloodPressure)
			{
				DataType eg_ = BloodPressure?.Effective;
				object eh_ = FHIRHelpers_4_3_000.ToValue(eg_);
				CqlInterval<CqlDateTime> ei_ = QICoreCommon_2_0_000.toInterval(eh_);
				CqlDateTime ej_ = context.Operators.End(ei_);
				Period ek_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_3_000.ToInterval(ek_);
				bool? em_ = context.Operators.In<CqlDateTime>(ej_, el_, "day");

				return em_;
			};
			IEnumerable<Observation> ay_ = context.Operators.Where<Observation>(f_, ax_);
			object az_(Observation @this)
			{
				DataType en_ = @this?.Effective;
				object eo_ = FHIRHelpers_4_3_000.ToValue(en_);
				CqlInterval<CqlDateTime> ep_ = QICoreCommon_2_0_000.toInterval(eo_);
				CqlDateTime eq_ = context.Operators.Start(ep_);

				return eq_;
			};
			IEnumerable<Observation> ba_ = context.Operators.SortBy<Observation>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
			Observation bb_ = context.Operators.Last<Observation>(ba_);
			List<Observation.ComponentComponent> bc_ = bb_?.Component;
			bool? bd_(Observation.ComponentComponent @this)
			{
				CodeableConcept er_ = @this?.Code;
				List<Coding> es_ = er_?.Coding;
				Coding et_ = context.Operators.First<Coding>((IEnumerable<Coding>)es_);
				FhirUri eu_ = et_?.SystemElement;
				string ev_ = FHIRHelpers_4_3_000.ToString(eu_);
				bool? ew_ = context.Operators.Equal(ev_, "http://loinc.org");
				List<Coding> ey_ = er_?.Coding;
				Coding ez_ = context.Operators.First<Coding>((IEnumerable<Coding>)ey_);
				Code fa_ = ez_?.CodeElement;
				string fb_ = FHIRHelpers_4_3_000.ToString(fa_);
				bool? fc_ = context.Operators.Equal(fb_, "8462-4");
				bool? fd_ = context.Operators.And(ew_, fc_);

				return fd_;
			};
			IEnumerable<Observation.ComponentComponent> be_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bc_, bd_);
			Observation.ComponentComponent bf_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(be_);
			DataType bg_ = bf_?.Value;
			object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
			CqlQuantity bi_ = context.Operators.Quantity(80m, "mm[Hg]");
			bool? bj_ = context.Operators.GreaterOrEqual(bh_ as CqlQuantity, bi_);
			bool? bk_ = context.Operators.Or(av_, bj_);
			bool? bl_ = context.Operators.And(ah_, bk_);

			return bl_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
		IEnumerable<Encounter> e_ = context.Operators.Except<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
	public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80() => 
		__Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80.Value;

	private IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional_Value()
	{
		CqlValueSet a_ = this.Follow_Up_Within_4_Weeks();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> c_(ServiceRequest FourWeekRescreen)
		{
			IEnumerable<ServiceRequest> g_ = this.NonPharmacological_Interventions();
			bool? h_(ServiceRequest NonPharmInterventionsHTN)
			{
				FhirDateTime l_ = FourWeekRescreen?.AuthoredOnElement;
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
				CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
				bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
				FhirDateTime p_ = NonPharmInterventionsHTN?.AuthoredOnElement;
				CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
				bool? s_ = context.Operators.In<CqlDateTime>(q_, n_, "day");
				bool? t_ = context.Operators.And(o_, s_);
				Code<RequestIntent> u_ = FourWeekRescreen?.IntentElement;
				RequestIntent? v_ = u_?.Value;
				Code<RequestIntent> w_ = context.Operators.Convert<Code<RequestIntent>>(v_);
				bool? x_ = context.Operators.Equivalent(w_, "order");
				bool? y_ = context.Operators.And(t_, x_);

				return y_;
			};
			IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
			ServiceRequest j_(ServiceRequest NonPharmInterventionsHTN) => 
				FourWeekRescreen;
			IEnumerable<ServiceRequest> k_ = context.Operators.Select<ServiceRequest, ServiceRequest>(i_, j_);

			return k_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
		IEnumerable<ServiceRequest> e_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
		IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(d_, e_);

		return f_;
	}

    [CqlDeclaration("First Hypertensive Reading Interventions or Referral to Alternate Professional")]
	public IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional() => 
		__First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional.Value;

	private IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80();
		IEnumerable<Encounter> b_(Encounter FirstHTNEncounter)
		{
			IEnumerable<ServiceRequest> d_ = this.First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional();
			bool? e_(ServiceRequest FirstHTNIntervention)
			{
				FhirDateTime i_ = FirstHTNIntervention?.AuthoredOnElement;
				CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
				Period k_ = FirstHTNEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, "day");

				return m_;
			};
			IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
			Encounter g_(ServiceRequest FirstHTNIntervention) => 
				FirstHTNEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<ServiceRequest, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions() => 
		__Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
			bool? e_(Observation BloodPressure)
			{
				DataType bs_ = BloodPressure?.Effective;
				object bt_ = FHIRHelpers_4_3_000.ToValue(bs_);
				CqlInterval<CqlDateTime> bu_ = QICoreCommon_2_0_000.toInterval(bt_);
				CqlDateTime bv_ = context.Operators.End(bu_);
				Period bw_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_3_000.ToInterval(bw_);
				bool? by_ = context.Operators.In<CqlDateTime>(bv_, bx_, "day");
				Code<ObservationStatus> bz_ = BloodPressure?.StatusElement;
				ObservationStatus? ca_ = bz_?.Value;
				string cb_ = context.Operators.Convert<string>(ca_);
				string[] cc_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? cd_ = context.Operators.In<string>(cb_, cc_ as IEnumerable<string>);
				bool? ce_ = context.Operators.And(by_, cd_);

				return ce_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType cf_ = @this?.Effective;
				object cg_ = FHIRHelpers_4_3_000.ToValue(cf_);
				CqlInterval<CqlDateTime> ch_ = QICoreCommon_2_0_000.toInterval(cg_);
				CqlDateTime ci_ = context.Operators.Start(ch_);

				return ci_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept cj_ = @this?.Code;
				List<Coding> ck_ = cj_?.Coding;
				Coding cl_ = context.Operators.First<Coding>((IEnumerable<Coding>)ck_);
				FhirUri cm_ = cl_?.SystemElement;
				string cn_ = FHIRHelpers_4_3_000.ToString(cm_);
				bool? co_ = context.Operators.Equal(cn_, "http://loinc.org");
				List<Coding> cq_ = cj_?.Coding;
				Coding cr_ = context.Operators.First<Coding>((IEnumerable<Coding>)cq_);
				Code cs_ = cr_?.CodeElement;
				string ct_ = FHIRHelpers_4_3_000.ToString(cs_);
				bool? cu_ = context.Operators.Equal(ct_, "8480-6");
				bool? cv_ = context.Operators.And(co_, cu_);

				return cv_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = context.Operators.Quantity(130m, "mm[Hg]");
			CqlQuantity q_ = context.Operators.Quantity(139m, "mm[Hg]");
			CqlInterval<CqlQuantity> r_ = context.Operators.Interval(p_, q_, true, true);
			bool? s_ = context.Operators.In<CqlQuantity>(o_ as CqlQuantity, r_, default);
			bool? u_(Observation BloodPressure)
			{
				DataType cw_ = BloodPressure?.Effective;
				object cx_ = FHIRHelpers_4_3_000.ToValue(cw_);
				CqlInterval<CqlDateTime> cy_ = QICoreCommon_2_0_000.toInterval(cx_);
				CqlDateTime cz_ = context.Operators.End(cy_);
				Period da_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_3_000.ToInterval(da_);
				bool? dc_ = context.Operators.In<CqlDateTime>(cz_, db_, "day");
				Code<ObservationStatus> dd_ = BloodPressure?.StatusElement;
				ObservationStatus? de_ = dd_?.Value;
				string df_ = context.Operators.Convert<string>(de_);
				string[] dg_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? dh_ = context.Operators.In<string>(df_, dg_ as IEnumerable<string>);
				bool? di_ = context.Operators.And(dc_, dh_);

				return di_;
			};
			IEnumerable<Observation> v_ = context.Operators.Where<Observation>(d_, u_);
			object w_(Observation @this)
			{
				DataType dj_ = @this?.Effective;
				object dk_ = FHIRHelpers_4_3_000.ToValue(dj_);
				CqlInterval<CqlDateTime> dl_ = QICoreCommon_2_0_000.toInterval(dk_);
				CqlDateTime dm_ = context.Operators.Start(dl_);

				return dm_;
			};
			IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
			Observation y_ = context.Operators.Last<Observation>(x_);
			List<Observation.ComponentComponent> z_ = y_?.Component;
			bool? aa_(Observation.ComponentComponent @this)
			{
				CodeableConcept dn_ = @this?.Code;
				List<Coding> do_ = dn_?.Coding;
				Coding dp_ = context.Operators.First<Coding>((IEnumerable<Coding>)do_);
				FhirUri dq_ = dp_?.SystemElement;
				string dr_ = FHIRHelpers_4_3_000.ToString(dq_);
				bool? ds_ = context.Operators.Equal(dr_, "http://loinc.org");
				List<Coding> du_ = dn_?.Coding;
				Coding dv_ = context.Operators.First<Coding>((IEnumerable<Coding>)du_);
				Code dw_ = dv_?.CodeElement;
				string dx_ = FHIRHelpers_4_3_000.ToString(dw_);
				bool? dy_ = context.Operators.Equal(dx_, "8462-4");
				bool? dz_ = context.Operators.And(ds_, dy_);

				return dz_;
			};
			IEnumerable<Observation.ComponentComponent> ab_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)z_, aa_);
			Observation.ComponentComponent ac_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ab_);
			DataType ad_ = ac_?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlQuantity af_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlQuantity ag_ = context.Operators.Quantity(89m, "mm[Hg]");
			CqlInterval<CqlQuantity> ah_ = context.Operators.Interval(af_, ag_, true, true);
			bool? ai_ = context.Operators.In<CqlQuantity>(ae_ as CqlQuantity, ah_, default);
			bool? aj_ = context.Operators.Or(s_, ai_);
			bool? al_(Observation BloodPressure)
			{
				DataType ea_ = BloodPressure?.Effective;
				object eb_ = FHIRHelpers_4_3_000.ToValue(ea_);
				CqlInterval<CqlDateTime> ec_ = QICoreCommon_2_0_000.toInterval(eb_);
				CqlDateTime ed_ = context.Operators.End(ec_);
				Period ee_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_3_000.ToInterval(ee_);
				bool? eg_ = context.Operators.In<CqlDateTime>(ed_, ef_, "day");
				Code<ObservationStatus> eh_ = BloodPressure?.StatusElement;
				ObservationStatus? ei_ = eh_?.Value;
				string ej_ = context.Operators.Convert<string>(ei_);
				string[] ek_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? el_ = context.Operators.In<string>(ej_, ek_ as IEnumerable<string>);
				bool? em_ = context.Operators.And(eg_, el_);

				return em_;
			};
			IEnumerable<Observation> am_ = context.Operators.Where<Observation>(d_, al_);
			object an_(Observation @this)
			{
				DataType en_ = @this?.Effective;
				object eo_ = FHIRHelpers_4_3_000.ToValue(en_);
				CqlInterval<CqlDateTime> ep_ = QICoreCommon_2_0_000.toInterval(eo_);
				CqlDateTime eq_ = context.Operators.Start(ep_);

				return eq_;
			};
			IEnumerable<Observation> ao_ = context.Operators.SortBy<Observation>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ap_ = context.Operators.Last<Observation>(ao_);
			List<Observation.ComponentComponent> aq_ = ap_?.Component;
			bool? ar_(Observation.ComponentComponent @this)
			{
				CodeableConcept er_ = @this?.Code;
				List<Coding> es_ = er_?.Coding;
				Coding et_ = context.Operators.First<Coding>((IEnumerable<Coding>)es_);
				FhirUri eu_ = et_?.SystemElement;
				string ev_ = FHIRHelpers_4_3_000.ToString(eu_);
				bool? ew_ = context.Operators.Equal(ev_, "http://loinc.org");
				List<Coding> ey_ = er_?.Coding;
				Coding ez_ = context.Operators.First<Coding>((IEnumerable<Coding>)ey_);
				Code fa_ = ez_?.CodeElement;
				string fb_ = FHIRHelpers_4_3_000.ToString(fa_);
				bool? fc_ = context.Operators.Equal(fb_, "8480-6");
				bool? fd_ = context.Operators.And(ew_, fc_);

				return fd_;
			};
			IEnumerable<Observation.ComponentComponent> as_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aq_, ar_);
			Observation.ComponentComponent at_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(as_);
			DataType au_ = at_?.Value;
			object av_ = FHIRHelpers_4_3_000.ToValue(au_);
			CqlQuantity aw_ = context.Operators.Quantity(140m, "mm[Hg]");
			bool? ax_ = context.Operators.GreaterOrEqual(av_ as CqlQuantity, aw_);
			bool? az_(Observation BloodPressure)
			{
				DataType fe_ = BloodPressure?.Effective;
				object ff_ = FHIRHelpers_4_3_000.ToValue(fe_);
				CqlInterval<CqlDateTime> fg_ = QICoreCommon_2_0_000.toInterval(ff_);
				CqlDateTime fh_ = context.Operators.End(fg_);
				Period fi_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_3_000.ToInterval(fi_);
				bool? fk_ = context.Operators.In<CqlDateTime>(fh_, fj_, "day");
				Code<ObservationStatus> fl_ = BloodPressure?.StatusElement;
				ObservationStatus? fm_ = fl_?.Value;
				string fn_ = context.Operators.Convert<string>(fm_);
				string[] fo_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? fp_ = context.Operators.In<string>(fn_, fo_ as IEnumerable<string>);
				bool? fq_ = context.Operators.And(fk_, fp_);

				return fq_;
			};
			IEnumerable<Observation> ba_ = context.Operators.Where<Observation>(d_, az_);
			object bb_(Observation @this)
			{
				DataType fr_ = @this?.Effective;
				object fs_ = FHIRHelpers_4_3_000.ToValue(fr_);
				CqlInterval<CqlDateTime> ft_ = QICoreCommon_2_0_000.toInterval(fs_);
				CqlDateTime fu_ = context.Operators.Start(ft_);

				return fu_;
			};
			IEnumerable<Observation> bc_ = context.Operators.SortBy<Observation>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
			Observation bd_ = context.Operators.Last<Observation>(bc_);
			List<Observation.ComponentComponent> be_ = bd_?.Component;
			bool? bf_(Observation.ComponentComponent @this)
			{
				CodeableConcept fv_ = @this?.Code;
				List<Coding> fw_ = fv_?.Coding;
				Coding fx_ = context.Operators.First<Coding>((IEnumerable<Coding>)fw_);
				FhirUri fy_ = fx_?.SystemElement;
				string fz_ = FHIRHelpers_4_3_000.ToString(fy_);
				bool? ga_ = context.Operators.Equal(fz_, "http://loinc.org");
				List<Coding> gc_ = fv_?.Coding;
				Coding gd_ = context.Operators.First<Coding>((IEnumerable<Coding>)gc_);
				Code ge_ = gd_?.CodeElement;
				string gf_ = FHIRHelpers_4_3_000.ToString(ge_);
				bool? gg_ = context.Operators.Equal(gf_, "8462-4");
				bool? gh_ = context.Operators.And(ga_, gg_);

				return gh_;
			};
			IEnumerable<Observation.ComponentComponent> bg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)be_, bf_);
			Observation.ComponentComponent bh_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bg_);
			DataType bi_ = bh_?.Value;
			object bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
			CqlQuantity bk_ = context.Operators.Quantity(90m, "mm[Hg]");
			bool? bl_ = context.Operators.GreaterOrEqual(bj_ as CqlQuantity, bk_);
			bool? bm_ = context.Operators.Or(ax_, bl_);
			bool? bn_ = context.Operators.Not(bm_);
			bool? bo_ = context.Operators.And(aj_, bn_);
			IEnumerable<Encounter> bp_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			bool? bq_ = context.Operators.Exists<Encounter>(bp_);
			bool? br_ = context.Operators.And(bo_, bq_);

			return br_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89.Value;

	private IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Value()
	{
		CqlCode a_ = this._12_lead_EKG_panel();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<ServiceRequest> c_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		CqlCode d_ = this.EKG_study();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
		CqlValueSet h_ = this.Laboratory_Tests_for_Hypertension();
		IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
		bool? k_(ServiceRequest EKGLab)
		{
			Code<RequestIntent> m_ = EKGLab?.IntentElement;
			RequestIntent? n_ = m_?.Value;
			Code<RequestIntent> o_ = context.Operators.Convert<Code<RequestIntent>>(n_);
			bool? p_ = context.Operators.Equivalent(o_, "order");

			return p_;
		};
		IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);

		return l_;
	}

    [CqlDeclaration("Laboratory Test or ECG for Hypertension")]
	public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension() => 
		__Laboratory_Test_or_ECG_for_Hypertension.Value;

	private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Value()
	{
		IEnumerable<ServiceRequest> a_ = this.Follow_up_with_Rescreen_in_2_to_6_Months();
		IEnumerable<ServiceRequest> b_(ServiceRequest Rescreen2to6)
		{
			IEnumerable<ServiceRequest> f_ = this.Laboratory_Test_or_ECG_for_Hypertension();
			bool? g_(ServiceRequest LabECGIntervention)
			{
				FhirDateTime k_ = Rescreen2to6?.AuthoredOnElement;
				CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
				CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
				bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
				FhirDateTime o_ = LabECGIntervention?.AuthoredOnElement;
				CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
				bool? r_ = context.Operators.In<CqlDateTime>(p_, m_, "day");
				bool? s_ = context.Operators.And(n_, r_);

				return s_;
			};
			IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
			ServiceRequest i_(ServiceRequest LabECGIntervention) => 
				Rescreen2to6;
			IEnumerable<ServiceRequest> j_ = context.Operators.Select<ServiceRequest, ServiceRequest>(h_, i_);

			return j_;
		};
		IEnumerable<ServiceRequest> c_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(a_, b_);
		IEnumerable<ServiceRequest> d_(ServiceRequest Rescreen2to6)
		{
			IEnumerable<ServiceRequest> t_ = this.NonPharmacological_Interventions();
			bool? u_(ServiceRequest NonPharmSecondIntervention)
			{
				FhirDateTime y_ = NonPharmSecondIntervention?.AuthoredOnElement;
				CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
				CqlInterval<CqlDateTime> aa_ = this.Measurement_Period();
				bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, "day");

				return ab_;
			};
			IEnumerable<ServiceRequest> v_ = context.Operators.Where<ServiceRequest>(t_, u_);
			ServiceRequest w_(ServiceRequest NonPharmSecondIntervention) => 
				Rescreen2to6;
			IEnumerable<ServiceRequest> x_ = context.Operators.Select<ServiceRequest, ServiceRequest>(v_, w_);

			return x_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
	public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions() => 
		__Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89();
		IEnumerable<Encounter> b_(Encounter SecondHTNEncounterReading)
		{
			IEnumerable<ServiceRequest> h_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions();
			bool? i_(ServiceRequest EncounterInterventions)
			{
				FhirDateTime m_ = EncounterInterventions?.AuthoredOnElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = SecondHTNEncounterReading?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");

				return q_;
			};
			IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
			Encounter k_(ServiceRequest EncounterInterventions) => 
				SecondHTNEncounterReading;
			IEnumerable<Encounter> l_ = context.Operators.Select<ServiceRequest, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading)
		{
			IEnumerable<ServiceRequest> r_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? s_(ServiceRequest ReferralForHTN)
			{
				FhirDateTime w_ = ReferralForHTN?.AuthoredOnElement;
				CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
				Period y_ = SecondHTNEncounterReading?.Period;
				CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.ToInterval(y_);
				bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");

				return aa_;
			};
			IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
			Encounter u_(ServiceRequest ReferralForHTN) => 
				SecondHTNEncounterReading;
			IEnumerable<Encounter> v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);

			return v_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? b_(Encounter QualifyingEncounter)
		{
			IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
			bool? e_(Observation BloodPressure)
			{
				DataType bn_ = BloodPressure?.Effective;
				object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
				CqlInterval<CqlDateTime> bp_ = QICoreCommon_2_0_000.toInterval(bo_);
				CqlDateTime bq_ = context.Operators.End(bp_);
				Period br_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_3_000.ToInterval(br_);
				bool? bt_ = context.Operators.In<CqlDateTime>(bq_, bs_, default);
				Code<ObservationStatus> bu_ = BloodPressure?.StatusElement;
				ObservationStatus? bv_ = bu_?.Value;
				string bw_ = context.Operators.Convert<string>(bv_);
				string[] bx_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
				bool? bz_ = context.Operators.And(bt_, by_);

				return bz_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType ca_ = @this?.Effective;
				object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
				CqlInterval<CqlDateTime> cc_ = QICoreCommon_2_0_000.toInterval(cb_);
				CqlDateTime cd_ = context.Operators.Start(cc_);

				return cd_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept ce_ = @this?.Code;
				List<Coding> cf_ = ce_?.Coding;
				Coding cg_ = context.Operators.First<Coding>((IEnumerable<Coding>)cf_);
				FhirUri ch_ = cg_?.SystemElement;
				string ci_ = FHIRHelpers_4_3_000.ToString(ch_);
				bool? cj_ = context.Operators.Equal(ci_, "http://loinc.org");
				List<Coding> cl_ = ce_?.Coding;
				Coding cm_ = context.Operators.First<Coding>((IEnumerable<Coding>)cl_);
				Code cn_ = cm_?.CodeElement;
				string co_ = FHIRHelpers_4_3_000.ToString(cn_);
				bool? cp_ = context.Operators.Equal(co_, "8480-6");
				bool? cq_ = context.Operators.And(cj_, cp_);

				return cq_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? q_ = context.Operators.Greater(o_ as CqlQuantity, p_);
			bool? s_(Observation BloodPressure)
			{
				DataType cr_ = BloodPressure?.Effective;
				object cs_ = FHIRHelpers_4_3_000.ToValue(cr_);
				CqlInterval<CqlDateTime> ct_ = QICoreCommon_2_0_000.toInterval(cs_);
				CqlDateTime cu_ = context.Operators.End(ct_);
				Period cv_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_3_000.ToInterval(cv_);
				bool? cx_ = context.Operators.In<CqlDateTime>(cu_, cw_, default);
				Code<ObservationStatus> cy_ = BloodPressure?.StatusElement;
				ObservationStatus? cz_ = cy_?.Value;
				string da_ = context.Operators.Convert<string>(cz_);
				string[] db_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? dc_ = context.Operators.In<string>(da_, db_ as IEnumerable<string>);
				bool? dd_ = context.Operators.And(cx_, dc_);

				return dd_;
			};
			IEnumerable<Observation> t_ = context.Operators.Where<Observation>(d_, s_);
			object u_(Observation @this)
			{
				DataType de_ = @this?.Effective;
				object df_ = FHIRHelpers_4_3_000.ToValue(de_);
				CqlInterval<CqlDateTime> dg_ = QICoreCommon_2_0_000.toInterval(df_);
				CqlDateTime dh_ = context.Operators.Start(dg_);

				return dh_;
			};
			IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			Observation w_ = context.Operators.Last<Observation>(v_);
			List<Observation.ComponentComponent> x_ = w_?.Component;
			bool? y_(Observation.ComponentComponent @this)
			{
				CodeableConcept di_ = @this?.Code;
				List<Coding> dj_ = di_?.Coding;
				Coding dk_ = context.Operators.First<Coding>((IEnumerable<Coding>)dj_);
				FhirUri dl_ = dk_?.SystemElement;
				string dm_ = FHIRHelpers_4_3_000.ToString(dl_);
				bool? dn_ = context.Operators.Equal(dm_, "http://loinc.org");
				List<Coding> dp_ = di_?.Coding;
				Coding dq_ = context.Operators.First<Coding>((IEnumerable<Coding>)dp_);
				Code dr_ = dq_?.CodeElement;
				string ds_ = FHIRHelpers_4_3_000.ToString(dr_);
				bool? dt_ = context.Operators.Equal(ds_, "8462-4");
				bool? du_ = context.Operators.And(dn_, dt_);

				return du_;
			};
			IEnumerable<Observation.ComponentComponent> z_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)x_, y_);
			Observation.ComponentComponent aa_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(z_);
			DataType ab_ = aa_?.Value;
			object ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			bool? ae_ = context.Operators.Greater(ac_ as CqlQuantity, p_);
			bool? af_ = context.Operators.And(q_, ae_);
			bool? ah_(Observation BloodPressure)
			{
				DataType dv_ = BloodPressure?.Effective;
				object dw_ = FHIRHelpers_4_3_000.ToValue(dv_);
				CqlInterval<CqlDateTime> dx_ = QICoreCommon_2_0_000.toInterval(dw_);
				CqlDateTime dy_ = context.Operators.End(dx_);
				Period dz_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_3_000.ToInterval(dz_);
				bool? eb_ = context.Operators.In<CqlDateTime>(dy_, ea_, default);
				Code<ObservationStatus> ec_ = BloodPressure?.StatusElement;
				ObservationStatus? ed_ = ec_?.Value;
				string ee_ = context.Operators.Convert<string>(ed_);
				string[] ef_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? eg_ = context.Operators.In<string>(ee_, ef_ as IEnumerable<string>);
				bool? eh_ = context.Operators.And(eb_, eg_);

				return eh_;
			};
			IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(d_, ah_);
			object aj_(Observation @this)
			{
				DataType ei_ = @this?.Effective;
				object ej_ = FHIRHelpers_4_3_000.ToValue(ei_);
				CqlInterval<CqlDateTime> ek_ = QICoreCommon_2_0_000.toInterval(ej_);
				CqlDateTime el_ = context.Operators.Start(ek_);

				return el_;
			};
			IEnumerable<Observation> ak_ = context.Operators.SortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
			Observation al_ = context.Operators.Last<Observation>(ak_);
			List<Observation.ComponentComponent> am_ = al_?.Component;
			bool? an_(Observation.ComponentComponent @this)
			{
				CodeableConcept em_ = @this?.Code;
				List<Coding> en_ = em_?.Coding;
				Coding eo_ = context.Operators.First<Coding>((IEnumerable<Coding>)en_);
				FhirUri ep_ = eo_?.SystemElement;
				string eq_ = FHIRHelpers_4_3_000.ToString(ep_);
				bool? er_ = context.Operators.Equal(eq_, "http://loinc.org");
				List<Coding> et_ = em_?.Coding;
				Coding eu_ = context.Operators.First<Coding>((IEnumerable<Coding>)et_);
				Code ev_ = eu_?.CodeElement;
				string ew_ = FHIRHelpers_4_3_000.ToString(ev_);
				bool? ex_ = context.Operators.Equal(ew_, "8480-6");
				bool? ey_ = context.Operators.And(er_, ex_);

				return ey_;
			};
			IEnumerable<Observation.ComponentComponent> ao_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)am_, an_);
			Observation.ComponentComponent ap_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ao_);
			DataType aq_ = ap_?.Value;
			object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
			CqlQuantity as_ = context.Operators.Quantity(140m, "mm[Hg]");
			bool? at_ = context.Operators.GreaterOrEqual(ar_ as CqlQuantity, as_);
			bool? av_(Observation BloodPressure)
			{
				DataType ez_ = BloodPressure?.Effective;
				object fa_ = FHIRHelpers_4_3_000.ToValue(ez_);
				CqlInterval<CqlDateTime> fb_ = QICoreCommon_2_0_000.toInterval(fa_);
				CqlDateTime fc_ = context.Operators.End(fb_);
				Period fd_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_3_000.ToInterval(fd_);
				bool? ff_ = context.Operators.In<CqlDateTime>(fc_, fe_, default);
				Code<ObservationStatus> fg_ = BloodPressure?.StatusElement;
				ObservationStatus? fh_ = fg_?.Value;
				string fi_ = context.Operators.Convert<string>(fh_);
				string[] fj_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? fk_ = context.Operators.In<string>(fi_, fj_ as IEnumerable<string>);
				bool? fl_ = context.Operators.And(ff_, fk_);

				return fl_;
			};
			IEnumerable<Observation> aw_ = context.Operators.Where<Observation>(d_, av_);
			object ax_(Observation @this)
			{
				DataType fm_ = @this?.Effective;
				object fn_ = FHIRHelpers_4_3_000.ToValue(fm_);
				CqlInterval<CqlDateTime> fo_ = QICoreCommon_2_0_000.toInterval(fn_);
				CqlDateTime fp_ = context.Operators.Start(fo_);

				return fp_;
			};
			IEnumerable<Observation> ay_ = context.Operators.SortBy<Observation>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
			Observation az_ = context.Operators.Last<Observation>(ay_);
			List<Observation.ComponentComponent> ba_ = az_?.Component;
			bool? bb_(Observation.ComponentComponent @this)
			{
				CodeableConcept fq_ = @this?.Code;
				List<Coding> fr_ = fq_?.Coding;
				Coding fs_ = context.Operators.First<Coding>((IEnumerable<Coding>)fr_);
				FhirUri ft_ = fs_?.SystemElement;
				string fu_ = FHIRHelpers_4_3_000.ToString(ft_);
				bool? fv_ = context.Operators.Equal(fu_, "http://loinc.org");
				List<Coding> fx_ = fq_?.Coding;
				Coding fy_ = context.Operators.First<Coding>((IEnumerable<Coding>)fx_);
				Code fz_ = fy_?.CodeElement;
				string ga_ = FHIRHelpers_4_3_000.ToString(fz_);
				bool? gb_ = context.Operators.Equal(ga_, "8462-4");
				bool? gc_ = context.Operators.And(fv_, gb_);

				return gc_;
			};
			IEnumerable<Observation.ComponentComponent> bc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ba_, bb_);
			Observation.ComponentComponent bd_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bc_);
			DataType be_ = bd_?.Value;
			object bf_ = FHIRHelpers_4_3_000.ToValue(be_);
			CqlQuantity bg_ = context.Operators.Quantity(90m, "mm[Hg]");
			bool? bh_ = context.Operators.GreaterOrEqual(bf_ as CqlQuantity, bg_);
			bool? bi_ = context.Operators.Or(at_, bh_);
			bool? bj_ = context.Operators.And(af_, bi_);
			IEnumerable<Encounter> bk_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			bool? bl_ = context.Operators.Exists<Encounter>(bk_);
			bool? bm_ = context.Operators.And(bj_, bl_);

			return bm_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90.Value;

	private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Value()
	{
		CqlValueSet a_ = this.Follow_Up_Within_4_Weeks();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> c_(ServiceRequest WeeksRescreen)
		{
			IEnumerable<ServiceRequest> i_ = this.Laboratory_Test_or_ECG_for_Hypertension();
			bool? j_(ServiceRequest ECGLabTest)
			{
				FhirDateTime n_ = WeeksRescreen?.AuthoredOnElement;
				CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
				CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
				bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
				FhirDateTime r_ = ECGLabTest?.AuthoredOnElement;
				CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
				bool? u_ = context.Operators.In<CqlDateTime>(s_, p_, "day");
				bool? v_ = context.Operators.And(q_, u_);
				Code<RequestIntent> w_ = WeeksRescreen?.IntentElement;
				RequestIntent? x_ = w_?.Value;
				Code<RequestIntent> y_ = context.Operators.Convert<Code<RequestIntent>>(x_);
				bool? z_ = context.Operators.Equivalent(y_, "order");
				bool? aa_ = context.Operators.And(v_, z_);
				Code<RequestIntent> ab_ = ECGLabTest?.IntentElement;
				RequestIntent? ac_ = ab_?.Value;
				Code<RequestIntent> ad_ = context.Operators.Convert<Code<RequestIntent>>(ac_);
				bool? ae_ = context.Operators.Equivalent(ad_, "order");
				bool? af_ = context.Operators.And(aa_, ae_);

				return af_;
			};
			IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
			ServiceRequest l_(ServiceRequest ECGLabTest) => 
				WeeksRescreen;
			IEnumerable<ServiceRequest> m_ = context.Operators.Select<ServiceRequest, ServiceRequest>(k_, l_);

			return m_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
		IEnumerable<ServiceRequest> e_(ServiceRequest WeeksRescreen)
		{
			IEnumerable<ServiceRequest> ag_ = this.NonPharmacological_Interventions();
			bool? ah_(ServiceRequest HTNInterventions)
			{
				FhirDateTime al_ = HTNInterventions?.AuthoredOnElement;
				CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
				CqlInterval<CqlDateTime> an_ = this.Measurement_Period();
				bool? ao_ = context.Operators.In<CqlDateTime>(am_, an_, "day");

				return ao_;
			};
			IEnumerable<ServiceRequest> ai_ = context.Operators.Where<ServiceRequest>(ag_, ah_);
			ServiceRequest aj_(ServiceRequest HTNInterventions) => 
				WeeksRescreen;
			IEnumerable<ServiceRequest> ak_ = context.Operators.Select<ServiceRequest, ServiceRequest>(ai_, aj_);

			return ak_;
		};
		IEnumerable<ServiceRequest> f_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(d_, e_);
		IEnumerable<ServiceRequest> g_(ServiceRequest WeeksRescreen)
		{
			CqlValueSet ap_ = this.Pharmacologic_Therapy_for_Hypertension();
			IEnumerable<MedicationRequest> aq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> at_ = context.Operators.Union<MedicationRequest>(aq_, as_);
			bool? au_(MedicationRequest Medications)
			{
				FhirDateTime ay_ = Medications?.AuthoredOnElement;
				CqlDateTime az_ = context.Operators.Convert<CqlDateTime>(ay_);
				CqlInterval<CqlDateTime> ba_ = this.Measurement_Period();
				bool? bb_ = context.Operators.In<CqlDateTime>(az_, ba_, "day");
				Code<MedicationRequest.MedicationrequestStatus> bc_ = Medications?.StatusElement;
				MedicationRequest.MedicationrequestStatus? bd_ = bc_?.Value;
				string be_ = context.Operators.Convert<string>(bd_);
				bool? bf_ = context.Operators.Equivalent(be_, "active");
				bool? bg_ = context.Operators.And(bb_, bf_);

				return bg_;
			};
			IEnumerable<MedicationRequest> av_ = context.Operators.Where<MedicationRequest>(at_, au_);
			ServiceRequest aw_(MedicationRequest Medications) => 
				WeeksRescreen;
			IEnumerable<ServiceRequest> ax_ = context.Operators.Select<MedicationRequest, ServiceRequest>(av_, aw_);

			return ax_;
		};
		IEnumerable<ServiceRequest> h_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions")]
	public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions() => 
		__Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions.Value;

	private IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90();
		IEnumerable<Encounter> b_(Encounter SecondHTNEncounterReading140Over90)
		{
			IEnumerable<ServiceRequest> h_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions();
			bool? i_(ServiceRequest SecondHTN140Over90Interventions)
			{
				FhirDateTime m_ = SecondHTN140Over90Interventions?.AuthoredOnElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = SecondHTNEncounterReading140Over90?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");

				return q_;
			};
			IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
			Encounter k_(ServiceRequest SecondHTN140Over90Interventions) => 
				SecondHTNEncounterReading140Over90;
			IEnumerable<Encounter> l_ = context.Operators.Select<ServiceRequest, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading140Over90)
		{
			IEnumerable<ServiceRequest> r_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? s_(ServiceRequest ReferralToProfessional)
			{
				FhirDateTime w_ = ReferralToProfessional?.AuthoredOnElement;
				CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
				Period y_ = SecondHTNEncounterReading140Over90?.Period;
				CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.ToInterval(y_);
				bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, "day");

				return aa_;
			};
			IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
			Encounter u_(ServiceRequest ReferralToProfessional) => 
				SecondHTNEncounterReading140Over90;
			IEnumerable<Encounter> v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);

			return v_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Normal_Blood_Pressure_Reading();
		IEnumerable<Encounter> b_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions();
		IEnumerable<Encounter> e_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions();
		IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
		IEnumerable<Encounter> h_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions();
		IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			CqlCode d_ = this.Systolic_blood_pressure();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
			CqlCode g_ = this.Diastolic_blood_pressure();
			IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
			IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
			IEnumerable<Observation> j_ = context.Operators.Union<Observation>(f_, i_);
			bool? k_(Observation NoBPScreen)
			{
				Instant o_ = NoBPScreen?.IssuedElement;
				DateTimeOffset? p_ = o_?.Value;
				CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
				Period r_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
				bool? u_(Extension @this)
				{
					string ar_ = @this?.Url;
					FhirString as_ = context.Operators.Convert<FhirString>(ar_);
					string at_ = FHIRHelpers_4_3_000.ToString(as_);
					bool? au_ = context.Operators.Equal(at_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

					return au_;
				};
				IEnumerable<Extension> v_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
						? (NoBPScreen as DomainResource).Extension
						: default), u_);
				object w_(Extension @this)
				{
					DataType av_ = @this?.Value;

					return av_;
				};
				IEnumerable<object> x_ = context.Operators.Select<Extension, object>(v_, w_);
				object y_ = context.Operators.SingletonFrom<object>(x_);
				CqlConcept z_ = FHIRHelpers_4_3_000.ToConcept(y_ as CodeableConcept);
				CqlValueSet aa_ = this.Patient_Declined();
				bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
				bool? ac_(Extension @this)
				{
					string aw_ = @this?.Url;
					FhirString ax_ = context.Operators.Convert<FhirString>(aw_);
					string ay_ = FHIRHelpers_4_3_000.ToString(ax_);
					bool? az_ = context.Operators.Equal(ay_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

					return az_;
				};
				IEnumerable<Extension> ad_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoBPScreen is DomainResource
						? (NoBPScreen as DomainResource).Extension
						: default), ac_);
				object ae_(Extension @this)
				{
					DataType ba_ = @this?.Value;

					return ba_;
				};
				IEnumerable<object> af_ = context.Operators.Select<Extension, object>(ad_, ae_);
				object ag_ = context.Operators.SingletonFrom<object>(af_);
				CqlConcept ah_ = FHIRHelpers_4_3_000.ToConcept(ag_ as CodeableConcept);
				CqlValueSet ai_ = this.Medical_Reason();
				bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
				bool? ak_ = context.Operators.Or(ab_, aj_);
				bool? al_ = context.Operators.And(t_, ak_);
				Code<ObservationStatus> am_ = NoBPScreen?.StatusElement;
				ObservationStatus? an_ = am_?.Value;
				Code<ObservationStatus> ao_ = context.Operators.Convert<Code<ObservationStatus>>(an_);
				bool? ap_ = context.Operators.Equal(ao_, "cancelled");
				bool? aq_ = context.Operators.And(al_, ap_);

				return aq_;
			};
			IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
			Encounter m_(Observation NoBPScreen) => 
				QualifyingEncounter;
			IEnumerable<Encounter> n_ = context.Operators.Select<Observation, Encounter>(l_, m_);

			return n_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement")]
	public IEnumerable<Encounter> Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement() => 
		__Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement.Value;

	private IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered_Value()
	{
		CqlValueSet a_ = this.Lifestyle_Recommendation();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Weight_Reduction_Recommended();
		IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
		CqlValueSet l_ = this.Dietary_Recommendations();
		IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> o_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> p_ = context.Operators.Union<ServiceRequest>(m_, o_);
		IEnumerable<ServiceRequest> q_ = context.Operators.Union<ServiceRequest>(k_, p_);
		CqlValueSet r_ = this.Recommendation_to_Increase_Physical_Activity();
		IEnumerable<ServiceRequest> s_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> u_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> v_ = context.Operators.Union<ServiceRequest>(s_, u_);
		IEnumerable<ServiceRequest> w_ = context.Operators.Union<ServiceRequest>(q_, v_);
		CqlValueSet x_ = this.Referral_or_Counseling_for_Alcohol_Consumption();
		IEnumerable<ServiceRequest> y_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> aa_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> ab_ = context.Operators.Union<ServiceRequest>(y_, aa_);
		IEnumerable<ServiceRequest> ac_ = context.Operators.Union<ServiceRequest>(w_, ab_);
		bool? ad_(ServiceRequest NonPharmIntervention)
		{
			bool? af_(Extension @this)
			{
				string as_ = @this?.Url;
				FhirString at_ = context.Operators.Convert<FhirString>(as_);
				string au_ = FHIRHelpers_4_3_000.ToString(at_);
				bool? av_ = context.Operators.Equal(au_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return av_;
			};
			IEnumerable<Extension> ag_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NonPharmIntervention is DomainResource
					? (NonPharmIntervention as DomainResource).Extension
					: default), af_);
			object ah_(Extension @this)
			{
				DataType aw_ = @this?.Value;

				return aw_;
			};
			IEnumerable<object> ai_ = context.Operators.Select<Extension, object>(ag_, ah_);
			object aj_ = context.Operators.SingletonFrom<object>(ai_);
			CqlConcept ak_ = FHIRHelpers_4_3_000.ToConcept(aj_ as CodeableConcept);
			CqlValueSet al_ = this.Patient_Declined();
			bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
			Code<RequestStatus> an_ = NonPharmIntervention?.StatusElement;
			RequestStatus? ao_ = an_?.Value;
			Code<RequestStatus> ap_ = context.Operators.Convert<Code<RequestStatus>>(ao_);
			bool? aq_ = context.Operators.Equal(ap_, "completed");
			bool? ar_ = context.Operators.And(am_, aq_);

			return ar_;
		};
		IEnumerable<ServiceRequest> ae_ = context.Operators.Where<ServiceRequest>(ac_, ad_);

		return ae_;
	}

    [CqlDeclaration("NonPharmacological Intervention Not Ordered")]
	public IEnumerable<ServiceRequest> NonPharmacological_Intervention_Not_Ordered() => 
		__NonPharmacological_Intervention_Not_Ordered.Value;

	private IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered_Value()
	{
		CqlCode a_ = this._12_lead_EKG_panel();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<ServiceRequest> c_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		CqlCode d_ = this.EKG_study();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
		CqlValueSet h_ = this.Laboratory_Tests_for_Hypertension();
		IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> k_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> l_ = context.Operators.Union<ServiceRequest>(i_, k_);
		IEnumerable<ServiceRequest> m_ = context.Operators.Union<ServiceRequest>(g_, l_);
		bool? n_(ServiceRequest LabECGNotDone)
		{
			bool? p_(Extension @this)
			{
				string x_ = @this?.Url;
				FhirString y_ = context.Operators.Convert<FhirString>(x_);
				string z_ = FHIRHelpers_4_3_000.ToString(y_);
				bool? aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return aa_;
			};
			IEnumerable<Extension> q_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LabECGNotDone is DomainResource
					? (LabECGNotDone as DomainResource).Extension
					: default), p_);
			object r_(Extension @this)
			{
				DataType ab_ = @this?.Value;

				return ab_;
			};
			IEnumerable<object> s_ = context.Operators.Select<Extension, object>(q_, r_);
			object t_ = context.Operators.SingletonFrom<object>(s_);
			CqlConcept u_ = FHIRHelpers_4_3_000.ToConcept(t_ as CodeableConcept);
			CqlValueSet v_ = this.Patient_Declined();
			bool? w_ = context.Operators.ConceptInValueSet(u_, v_);

			return w_;
		};
		IEnumerable<ServiceRequest> o_ = context.Operators.Where<ServiceRequest>(m_, n_);

		return o_;
	}

    [CqlDeclaration("Laboratory Test or ECG for Hypertension Not Ordered")]
	public IEnumerable<ServiceRequest> Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered() => 
		__Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered.Value;

	private IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined_Value()
	{
		CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlCode f_ = this.Follow_up_2_3_months__finding_();
		IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
		IEnumerable<ServiceRequest> h_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, g_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		CqlCode i_ = this.Follow_up_4_6_months__finding_();
		IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> l_ = context.Operators.Union<ServiceRequest>(h_, k_);
		IEnumerable<ServiceRequest> m_ = context.Operators.Union<ServiceRequest>(e_, l_);
		bool? n_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
		{
			bool? t_(Extension @this)
			{
				string ag_ = @this?.Url;
				FhirString ah_ = context.Operators.Convert<FhirString>(ag_);
				string ai_ = FHIRHelpers_4_3_000.ToString(ah_);
				bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return aj_;
			};
			IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTNDeclinedReferralAndFollowUp is DomainResource
					? (SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension
					: default), t_);
			object v_(Extension @this)
			{
				DataType ak_ = @this?.Value;

				return ak_;
			};
			IEnumerable<object> w_ = context.Operators.Select<Extension, object>(u_, v_);
			object x_ = context.Operators.SingletonFrom<object>(w_);
			CqlConcept y_ = FHIRHelpers_4_3_000.ToConcept(x_ as CodeableConcept);
			CqlValueSet z_ = this.Patient_Declined();
			bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
			Code<RequestStatus> ab_ = SecondHTNDeclinedReferralAndFollowUp?.StatusElement;
			RequestStatus? ac_ = ab_?.Value;
			Code<RequestStatus> ad_ = context.Operators.Convert<Code<RequestStatus>>(ac_);
			bool? ae_ = context.Operators.Equal(ad_, "completed");
			bool? af_ = context.Operators.And(aa_, ae_);

			return af_;
		};
		IEnumerable<ServiceRequest> o_ = context.Operators.Where<ServiceRequest>(m_, n_);
		IEnumerable<ServiceRequest> p_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered();
		IEnumerable<ServiceRequest> q_ = context.Operators.Union<ServiceRequest>(o_, p_);
		IEnumerable<ServiceRequest> r_ = this.NonPharmacological_Intervention_Not_Ordered();
		IEnumerable<ServiceRequest> s_ = context.Operators.Union<ServiceRequest>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
	public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined() => 
		__Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined.Value;

	private IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined_Value()
	{
		CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Follow_Up_Within_4_Weeks();
		IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
		IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
		bool? l_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
		{
			bool? z_(Extension @this)
			{
				string am_ = @this?.Url;
				FhirString an_ = context.Operators.Convert<FhirString>(am_);
				string ao_ = FHIRHelpers_4_3_000.ToString(an_);
				bool? ap_ = context.Operators.Equal(ao_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return ap_;
			};
			IEnumerable<Extension> aa_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(SecondHTN140Over90ReferralFollowUpNotDone is DomainResource
					? (SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension
					: default), z_);
			object ab_(Extension @this)
			{
				DataType aq_ = @this?.Value;

				return aq_;
			};
			IEnumerable<object> ac_ = context.Operators.Select<Extension, object>(aa_, ab_);
			object ad_ = context.Operators.SingletonFrom<object>(ac_);
			CqlConcept ae_ = FHIRHelpers_4_3_000.ToConcept(ad_ as CodeableConcept);
			CqlValueSet af_ = this.Patient_Declined();
			bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			Code<RequestStatus> ah_ = SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement;
			RequestStatus? ai_ = ah_?.Value;
			Code<RequestStatus> aj_ = context.Operators.Convert<Code<RequestStatus>>(ai_);
			bool? ak_ = context.Operators.Equal(aj_, "completed");
			bool? al_ = context.Operators.And(ag_, ak_);

			return al_;
		};
		IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);
		CqlValueSet n_ = this.Pharmacologic_Therapy_for_Hypertension();
		IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
		IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
		IEnumerable<MedicationRequest> r_ = context.Operators.Union<MedicationRequest>(o_, q_);
		bool? s_(MedicationRequest MedicationRequestNotOrdered)
		{
			Code<MedicationRequest.MedicationrequestStatus> ar_ = MedicationRequestNotOrdered?.StatusElement;
			MedicationRequest.MedicationrequestStatus? as_ = ar_?.Value;
			string at_ = context.Operators.Convert<string>(as_);
			bool? au_ = context.Operators.Equal(at_, "completed");

			return au_;
		};
		IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
		IEnumerable<object> u_ = context.Operators.Union<object>(m_ as IEnumerable<object>, t_ as IEnumerable<object>);
		IEnumerable<ServiceRequest> v_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered();
		IEnumerable<object> w_ = context.Operators.Union<object>(u_ as IEnumerable<object>, v_ as IEnumerable<object>);
		IEnumerable<ServiceRequest> x_ = this.NonPharmacological_Intervention_Not_Ordered();
		IEnumerable<object> y_ = context.Operators.Union<object>(w_ as IEnumerable<object>, x_ as IEnumerable<object>);

		return y_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined")]
	public IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined() => 
		__Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined.Value;

	private IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80();
		IEnumerable<Encounter> b_(Encounter ElevatedBPEncounter)
		{
			CqlValueSet x_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
			IEnumerable<ServiceRequest> y_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
			IEnumerable<ServiceRequest> aa_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
			IEnumerable<ServiceRequest> ab_ = context.Operators.Union<ServiceRequest>(y_, aa_);
			CqlCode ac_ = this.Follow_up_2_3_months__finding_();
			IEnumerable<CqlCode> ad_ = context.Operators.ToList<CqlCode>(ac_);
			IEnumerable<ServiceRequest> ae_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, ad_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
			CqlCode af_ = this.Follow_up_4_6_months__finding_();
			IEnumerable<CqlCode> ag_ = context.Operators.ToList<CqlCode>(af_);
			IEnumerable<ServiceRequest> ah_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
			IEnumerable<ServiceRequest> ai_ = context.Operators.Union<ServiceRequest>(ae_, ah_);
			IEnumerable<ServiceRequest> aj_ = context.Operators.Union<ServiceRequest>(ab_, ai_);
			bool? ak_(ServiceRequest ElevatedBPDeclinedInterventions)
			{
				bool? ao_(Extension @this)
				{
					string bh_ = @this?.Url;
					FhirString bi_ = context.Operators.Convert<FhirString>(bh_);
					string bj_ = FHIRHelpers_4_3_000.ToString(bi_);
					bool? bk_ = context.Operators.Equal(bj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

					return bk_;
				};
				IEnumerable<Extension> ap_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(ElevatedBPDeclinedInterventions is DomainResource
						? (ElevatedBPDeclinedInterventions as DomainResource).Extension
						: default), ao_);
				object aq_(Extension @this)
				{
					DataType bl_ = @this?.Value;

					return bl_;
				};
				IEnumerable<object> ar_ = context.Operators.Select<Extension, object>(ap_, aq_);
				object as_ = context.Operators.SingletonFrom<object>(ar_);
				CqlConcept at_ = FHIRHelpers_4_3_000.ToConcept(as_ as CodeableConcept);
				CqlValueSet au_ = this.Patient_Declined();
				bool? av_ = context.Operators.ConceptInValueSet(at_, au_);
				FhirDateTime aw_ = ElevatedBPDeclinedInterventions?.AuthoredOnElement;
				CqlDateTime ax_ = context.Operators.Convert<CqlDateTime>(aw_);
				Period ay_ = ElevatedBPEncounter?.Period;
				CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_3_000.ToInterval(ay_);
				bool? ba_ = context.Operators.In<CqlDateTime>(ax_, az_, "day");
				bool? bb_ = context.Operators.And(av_, ba_);
				Code<RequestStatus> bc_ = ElevatedBPDeclinedInterventions?.StatusElement;
				RequestStatus? bd_ = bc_?.Value;
				Code<RequestStatus> be_ = context.Operators.Convert<Code<RequestStatus>>(bd_);
				bool? bf_ = context.Operators.Equal(be_, "completed");
				bool? bg_ = context.Operators.And(bb_, bf_);

				return bg_;
			};
			IEnumerable<ServiceRequest> al_ = context.Operators.Where<ServiceRequest>(aj_, ak_);
			Encounter am_(ServiceRequest ElevatedBPDeclinedInterventions) => 
				ElevatedBPEncounter;
			IEnumerable<Encounter> an_ = context.Operators.Select<ServiceRequest, Encounter>(al_, am_);

			return an_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter ElevatedBPEncounter)
		{
			IEnumerable<ServiceRequest> bm_ = this.NonPharmacological_Intervention_Not_Ordered();
			bool? bn_(ServiceRequest NotOrdered)
			{
				FhirDateTime br_ = NotOrdered?.AuthoredOnElement;
				CqlDateTime bs_ = context.Operators.Convert<CqlDateTime>(br_);
				Period bt_ = ElevatedBPEncounter?.Period;
				CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_3_000.ToInterval(bt_);
				bool? bv_ = context.Operators.In<CqlDateTime>(bs_, bu_, "day");

				return bv_;
			};
			IEnumerable<ServiceRequest> bo_ = context.Operators.Where<ServiceRequest>(bm_, bn_);
			Encounter bp_(ServiceRequest NotOrdered) => 
				ElevatedBPEncounter;
			IEnumerable<Encounter> bq_ = context.Operators.Select<ServiceRequest, Encounter>(bo_, bp_);

			return bq_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
		IEnumerable<Encounter> h_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80();
		IEnumerable<Encounter> i_(Encounter FirstHTNEncounter)
		{
			CqlValueSet bw_ = this.Follow_Up_Within_4_Weeks();
			IEnumerable<ServiceRequest> bx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
			IEnumerable<ServiceRequest> bz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
			IEnumerable<ServiceRequest> ca_ = context.Operators.Union<ServiceRequest>(bx_, bz_);
			CqlValueSet cb_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
			IEnumerable<ServiceRequest> cc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
			IEnumerable<ServiceRequest> ce_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
			IEnumerable<ServiceRequest> cf_ = context.Operators.Union<ServiceRequest>(cc_, ce_);
			IEnumerable<ServiceRequest> cg_ = context.Operators.Union<ServiceRequest>(ca_, cf_);
			bool? ch_(ServiceRequest FirstHTNDeclinedInterventions)
			{
				bool? cl_(Extension @this)
				{
					string de_ = @this?.Url;
					FhirString df_ = context.Operators.Convert<FhirString>(de_);
					string dg_ = FHIRHelpers_4_3_000.ToString(df_);
					bool? dh_ = context.Operators.Equal(dg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

					return dh_;
				};
				IEnumerable<Extension> cm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FirstHTNDeclinedInterventions is DomainResource
						? (FirstHTNDeclinedInterventions as DomainResource).Extension
						: default), cl_);
				object cn_(Extension @this)
				{
					DataType di_ = @this?.Value;

					return di_;
				};
				IEnumerable<object> co_ = context.Operators.Select<Extension, object>(cm_, cn_);
				object cp_ = context.Operators.SingletonFrom<object>(co_);
				CqlConcept cq_ = FHIRHelpers_4_3_000.ToConcept(cp_ as CodeableConcept);
				CqlValueSet cr_ = this.Patient_Declined();
				bool? cs_ = context.Operators.ConceptInValueSet(cq_, cr_);
				FhirDateTime ct_ = FirstHTNDeclinedInterventions?.AuthoredOnElement;
				CqlDateTime cu_ = context.Operators.Convert<CqlDateTime>(ct_);
				Period cv_ = FirstHTNEncounter?.Period;
				CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_3_000.ToInterval(cv_);
				bool? cx_ = context.Operators.In<CqlDateTime>(cu_, cw_, "day");
				bool? cy_ = context.Operators.And(cs_, cx_);
				Code<RequestStatus> cz_ = FirstHTNDeclinedInterventions?.StatusElement;
				RequestStatus? da_ = cz_?.Value;
				Code<RequestStatus> db_ = context.Operators.Convert<Code<RequestStatus>>(da_);
				bool? dc_ = context.Operators.Equal(db_, "completed");
				bool? dd_ = context.Operators.And(cy_, dc_);

				return dd_;
			};
			IEnumerable<ServiceRequest> ci_ = context.Operators.Where<ServiceRequest>(cg_, ch_);
			Encounter cj_(ServiceRequest FirstHTNDeclinedInterventions) => 
				FirstHTNEncounter;
			IEnumerable<Encounter> ck_ = context.Operators.Select<ServiceRequest, Encounter>(ci_, cj_);

			return ck_;
		};
		IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(h_, i_);
		IEnumerable<Encounter> l_(Encounter FirstHTNEncounter)
		{
			IEnumerable<ServiceRequest> dj_ = this.NonPharmacological_Intervention_Not_Ordered();
			bool? dk_(ServiceRequest NoNonPharm)
			{
				FhirDateTime do_ = NoNonPharm?.AuthoredOnElement;
				CqlDateTime dp_ = context.Operators.Convert<CqlDateTime>(do_);
				Period dq_ = FirstHTNEncounter?.Period;
				CqlInterval<CqlDateTime> dr_ = FHIRHelpers_4_3_000.ToInterval(dq_);
				bool? ds_ = context.Operators.In<CqlDateTime>(dp_, dr_, "day");

				return ds_;
			};
			IEnumerable<ServiceRequest> dl_ = context.Operators.Where<ServiceRequest>(dj_, dk_);
			Encounter dm_(ServiceRequest NoNonPharm) => 
				FirstHTNEncounter;
			IEnumerable<Encounter> dn_ = context.Operators.Select<ServiceRequest, Encounter>(dl_, dm_);

			return dn_;
		};
		IEnumerable<Encounter> m_ = context.Operators.SelectMany<Encounter, Encounter>(h_, l_);
		IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(j_, m_);
		IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(g_, n_);
		IEnumerable<Encounter> p_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89();
		IEnumerable<Encounter> q_(Encounter SecondHTNEncounter)
		{
			IEnumerable<ServiceRequest> dt_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined();
			bool? du_(ServiceRequest SecondHTNDeclinedInterventions)
			{
				FhirDateTime dy_ = SecondHTNDeclinedInterventions?.AuthoredOnElement;
				CqlDateTime dz_ = context.Operators.Convert<CqlDateTime>(dy_);
				Period ea_ = SecondHTNEncounter?.Period;
				CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_3_000.ToInterval(ea_);
				bool? ec_ = context.Operators.In<CqlDateTime>(dz_, eb_, "day");

				return ec_;
			};
			IEnumerable<ServiceRequest> dv_ = context.Operators.Where<ServiceRequest>(dt_, du_);
			Encounter dw_(ServiceRequest SecondHTNDeclinedInterventions) => 
				SecondHTNEncounter;
			IEnumerable<Encounter> dx_ = context.Operators.Select<ServiceRequest, Encounter>(dv_, dw_);

			return dx_;
		};
		IEnumerable<Encounter> r_ = context.Operators.SelectMany<Encounter, Encounter>(p_, q_);
		IEnumerable<Encounter> s_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90();
		IEnumerable<Encounter> t_(Encounter SecondHTN140Over90Encounter)
		{
			IEnumerable<object> ed_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined();
			bool? ee_(object SecondHTN140Over90DeclinedInterventions)
			{
				object ei_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
				CqlDateTime ej_ = context.Operators.LateBoundProperty<CqlDateTime>(ei_, "value");
				Period ek_ = SecondHTN140Over90Encounter?.Period;
				CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_3_000.ToInterval(ek_);
				bool? em_ = context.Operators.In<CqlDateTime>(ej_, el_, "day");

				return em_;
			};
			IEnumerable<object> ef_ = context.Operators.Where<object>(ed_, ee_);
			Encounter eg_(object SecondHTN140Over90DeclinedInterventions) => 
				SecondHTN140Over90Encounter;
			IEnumerable<Encounter> eh_ = context.Operators.Select<object, Encounter>(ef_, eg_);

			return eh_;
		};
		IEnumerable<Encounter> u_ = context.Operators.SelectMany<Encounter, Encounter>(s_, t_);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(r_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(o_, v_);

		return w_;
	}

    [CqlDeclaration("Encounter with Order for Hypertension Follow Up Declined by Patient")]
	public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient() => 
		__Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement();
		IEnumerable<Encounter> b_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

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
