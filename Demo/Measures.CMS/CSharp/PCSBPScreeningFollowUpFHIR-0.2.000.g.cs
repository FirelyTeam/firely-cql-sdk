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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Encounter_to_Screen_for_Blood_Pressure();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
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
			IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, default);
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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? e_(Observation BloodPressure)
			{
				DataType am_ = BloodPressure?.Effective;
				object an_ = FHIRHelpers_4_3_000.ToValue(am_);
				CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.toInterval(an_);
				CqlDateTime ap_ = context.Operators.End(ao_);
				Period aq_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_3_000.ToInterval(aq_);
				bool? as_ = context.Operators.In<CqlDateTime>(ap_, ar_, default);
				Code<ObservationStatus> at_ = BloodPressure?.StatusElement;
				ObservationStatus? au_ = at_?.Value;
				string av_ = context.Operators.Convert<string>(au_);
				string[] aw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ax_ = context.Operators.In<string>(av_, aw_ as IEnumerable<string>);
				bool? ay_ = context.Operators.And(as_, ax_);

				return ay_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType az_ = @this?.Effective;
				object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
				CqlInterval<CqlDateTime> bb_ = QICoreCommon_2_0_000.toInterval(ba_);
				CqlDateTime bc_ = context.Operators.Start(bb_);

				return bc_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept bd_ = @this?.Code;
				List<Coding> be_ = bd_?.Coding;
				Coding bf_ = context.Operators.First<Coding>((IEnumerable<Coding>)be_);
				FhirUri bg_ = bf_?.SystemElement;
				string bh_ = FHIRHelpers_4_3_000.ToString(bg_);
				bool? bi_ = context.Operators.Equal(bh_, "http://loinc.org");
				List<Coding> bk_ = bd_?.Coding;
				Coding bl_ = context.Operators.First<Coding>((IEnumerable<Coding>)bk_);
				Code bm_ = bl_?.CodeElement;
				string bn_ = FHIRHelpers_4_3_000.ToString(bm_);
				bool? bo_ = context.Operators.Equal(bn_, "8480-6");
				bool? bp_ = context.Operators.And(bi_, bo_);

				return bp_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = o_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity q_ = context.Operators.Quantity(1m, "mm[Hg]");
			CqlQuantity r_ = context.Operators.Quantity(120m, "mm[Hg]");
			CqlInterval<CqlQuantity> s_ = context.Operators.Interval(q_, r_, true, false);
			bool? t_ = context.Operators.In<CqlQuantity>(p_, s_, default);
			bool? v_(Observation BloodPressure)
			{
				DataType bq_ = BloodPressure?.Effective;
				object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
				CqlInterval<CqlDateTime> bs_ = QICoreCommon_2_0_000.toInterval(br_);
				CqlDateTime bt_ = context.Operators.End(bs_);
				Period bu_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_3_000.ToInterval(bu_);
				bool? bw_ = context.Operators.In<CqlDateTime>(bt_, bv_, default);
				Code<ObservationStatus> bx_ = BloodPressure?.StatusElement;
				ObservationStatus? by_ = bx_?.Value;
				string bz_ = context.Operators.Convert<string>(by_);
				string[] ca_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? cb_ = context.Operators.In<string>(bz_, ca_ as IEnumerable<string>);
				bool? cc_ = context.Operators.And(bw_, cb_);

				return cc_;
			};
			IEnumerable<Observation> w_ = context.Operators.Where<Observation>(d_, v_);
			object x_(Observation @this)
			{
				DataType cd_ = @this?.Effective;
				object ce_ = FHIRHelpers_4_3_000.ToValue(cd_);
				CqlInterval<CqlDateTime> cf_ = QICoreCommon_2_0_000.toInterval(ce_);
				CqlDateTime cg_ = context.Operators.Start(cf_);

				return cg_;
			};
			IEnumerable<Observation> y_ = context.Operators.SortBy<Observation>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
			Observation z_ = context.Operators.Last<Observation>(y_);
			List<Observation.ComponentComponent> aa_ = z_?.Component;
			bool? ab_(Observation.ComponentComponent @this)
			{
				CodeableConcept ch_ = @this?.Code;
				List<Coding> ci_ = ch_?.Coding;
				Coding cj_ = context.Operators.First<Coding>((IEnumerable<Coding>)ci_);
				FhirUri ck_ = cj_?.SystemElement;
				string cl_ = FHIRHelpers_4_3_000.ToString(ck_);
				bool? cm_ = context.Operators.Equal(cl_, "http://loinc.org");
				List<Coding> co_ = ch_?.Coding;
				Coding cp_ = context.Operators.First<Coding>((IEnumerable<Coding>)co_);
				Code cq_ = cp_?.CodeElement;
				string cr_ = FHIRHelpers_4_3_000.ToString(cq_);
				bool? cs_ = context.Operators.Equal(cr_, "8462-4");
				bool? ct_ = context.Operators.And(cm_, cs_);

				return ct_;
			};
			IEnumerable<Observation.ComponentComponent> ac_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aa_, ab_);
			Observation.ComponentComponent ad_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ac_);
			DataType ae_ = ad_?.Value;
			object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			CqlQuantity ai_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlInterval<CqlQuantity> aj_ = context.Operators.Interval(q_, ai_, true, false);
			bool? ak_ = context.Operators.In<CqlQuantity>(p_, aj_, default);
			bool? al_ = context.Operators.And(t_, ak_);

			return al_;
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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? e_(Observation BloodPressure)
			{
				DataType am_ = BloodPressure?.Effective;
				object an_ = FHIRHelpers_4_3_000.ToValue(am_);
				CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.toInterval(an_);
				CqlDateTime ap_ = context.Operators.End(ao_);
				Period aq_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_3_000.ToInterval(aq_);
				bool? as_ = context.Operators.In<CqlDateTime>(ap_, ar_, default);
				Code<ObservationStatus> at_ = BloodPressure?.StatusElement;
				ObservationStatus? au_ = at_?.Value;
				string av_ = context.Operators.Convert<string>(au_);
				string[] aw_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ax_ = context.Operators.In<string>(av_, aw_ as IEnumerable<string>);
				bool? ay_ = context.Operators.And(as_, ax_);

				return ay_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType az_ = @this?.Effective;
				object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
				CqlInterval<CqlDateTime> bb_ = QICoreCommon_2_0_000.toInterval(ba_);
				CqlDateTime bc_ = context.Operators.Start(bb_);

				return bc_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept bd_ = @this?.Code;
				List<Coding> be_ = bd_?.Coding;
				Coding bf_ = context.Operators.First<Coding>((IEnumerable<Coding>)be_);
				FhirUri bg_ = bf_?.SystemElement;
				string bh_ = FHIRHelpers_4_3_000.ToString(bg_);
				bool? bi_ = context.Operators.Equal(bh_, "http://loinc.org");
				List<Coding> bk_ = bd_?.Coding;
				Coding bl_ = context.Operators.First<Coding>((IEnumerable<Coding>)bk_);
				Code bm_ = bl_?.CodeElement;
				string bn_ = FHIRHelpers_4_3_000.ToString(bm_);
				bool? bo_ = context.Operators.Equal(bn_, "8480-6");
				bool? bp_ = context.Operators.And(bi_, bo_);

				return bp_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = o_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity q_ = context.Operators.Quantity(120m, "mm[Hg]");
			CqlQuantity r_ = context.Operators.Quantity(129m, "mm[Hg]");
			CqlInterval<CqlQuantity> s_ = context.Operators.Interval(q_, r_, true, true);
			bool? t_ = context.Operators.In<CqlQuantity>(p_, s_, default);
			bool? v_(Observation BloodPressure)
			{
				DataType bq_ = BloodPressure?.Effective;
				object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
				CqlInterval<CqlDateTime> bs_ = QICoreCommon_2_0_000.toInterval(br_);
				CqlDateTime bt_ = context.Operators.End(bs_);
				Period bu_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_3_000.ToInterval(bu_);
				bool? bw_ = context.Operators.In<CqlDateTime>(bt_, bv_, default);
				Code<ObservationStatus> bx_ = BloodPressure?.StatusElement;
				ObservationStatus? by_ = bx_?.Value;
				string bz_ = context.Operators.Convert<string>(by_);
				string[] ca_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? cb_ = context.Operators.In<string>(bz_, ca_ as IEnumerable<string>);
				bool? cc_ = context.Operators.And(bw_, cb_);

				return cc_;
			};
			IEnumerable<Observation> w_ = context.Operators.Where<Observation>(d_, v_);
			object x_(Observation @this)
			{
				DataType cd_ = @this?.Effective;
				object ce_ = FHIRHelpers_4_3_000.ToValue(cd_);
				CqlInterval<CqlDateTime> cf_ = QICoreCommon_2_0_000.toInterval(ce_);
				CqlDateTime cg_ = context.Operators.Start(cf_);

				return cg_;
			};
			IEnumerable<Observation> y_ = context.Operators.SortBy<Observation>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
			Observation z_ = context.Operators.Last<Observation>(y_);
			List<Observation.ComponentComponent> aa_ = z_?.Component;
			bool? ab_(Observation.ComponentComponent @this)
			{
				CodeableConcept ch_ = @this?.Code;
				List<Coding> ci_ = ch_?.Coding;
				Coding cj_ = context.Operators.First<Coding>((IEnumerable<Coding>)ci_);
				FhirUri ck_ = cj_?.SystemElement;
				string cl_ = FHIRHelpers_4_3_000.ToString(ck_);
				bool? cm_ = context.Operators.Equal(cl_, "http://loinc.org");
				List<Coding> co_ = ch_?.Coding;
				Coding cp_ = context.Operators.First<Coding>((IEnumerable<Coding>)co_);
				Code cq_ = cp_?.CodeElement;
				string cr_ = FHIRHelpers_4_3_000.ToString(cq_);
				bool? cs_ = context.Operators.Equal(cr_, "8462-4");
				bool? ct_ = context.Operators.And(cm_, cs_);

				return ct_;
			};
			IEnumerable<Observation.ComponentComponent> ac_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aa_, ab_);
			Observation.ComponentComponent ad_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ac_);
			DataType ae_ = ad_?.Value;
			object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			CqlQuantity ah_ = context.Operators.Quantity(1m, "mm[Hg]");
			CqlQuantity ai_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlInterval<CqlQuantity> aj_ = context.Operators.Interval(ah_, ai_, true, false);
			bool? ak_ = context.Operators.In<CqlQuantity>(p_, aj_, default);
			bool? al_ = context.Operators.And(t_, ak_);

			return al_;
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
		IEnumerable<ServiceRequest> c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, default);
		CqlCode d_ = this.Follow_up_4_6_months__finding_();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, default);
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		CqlValueSet c_ = this.Weight_Reduction_Recommended();
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(c_, default);
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Dietary_Recommendations();
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, default);
		CqlValueSet h_ = this.Recommendation_to_Increase_Physical_Activity();
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, default);
		IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
		CqlValueSet l_ = this.Referral_or_Counseling_for_Alcohol_Consumption();
		IEnumerable<ServiceRequest> m_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, default);
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? e_(Observation BloodPressure)
			{
				DataType bo_ = BloodPressure?.Effective;
				object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
				CqlInterval<CqlDateTime> bq_ = QICoreCommon_2_0_000.toInterval(bp_);
				CqlDateTime br_ = context.Operators.End(bq_);
				Period bs_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_3_000.ToInterval(bs_);
				CqlDateTime bu_ = context.Operators.Start(bt_);
				CqlQuantity bv_ = context.Operators.Quantity(1m, "year");
				CqlDateTime bw_ = context.Operators.Subtract(bu_, bv_);
				CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_3_000.ToInterval(bs_);
				CqlDateTime bz_ = context.Operators.Start(by_);
				CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bw_, bz_, true, true);
				bool? cb_ = context.Operators.In<CqlDateTime>(br_, ca_, default);
				CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_3_000.ToInterval(bs_);
				CqlDateTime ce_ = context.Operators.Start(cd_);
				bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
				bool? cg_ = context.Operators.And(cb_, cf_);
				Code<ObservationStatus> ch_ = BloodPressure?.StatusElement;
				ObservationStatus? ci_ = ch_?.Value;
				string cj_ = context.Operators.Convert<string>(ci_);
				string[] ck_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? cl_ = context.Operators.In<string>(cj_, ck_ as IEnumerable<string>);
				bool? cm_ = context.Operators.And(cg_, cl_);

				return cm_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType cn_ = @this?.Effective;
				object co_ = FHIRHelpers_4_3_000.ToValue(cn_);
				CqlInterval<CqlDateTime> cp_ = QICoreCommon_2_0_000.toInterval(co_);
				CqlDateTime cq_ = context.Operators.Start(cp_);

				return cq_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept cr_ = @this?.Code;
				List<Coding> cs_ = cr_?.Coding;
				Coding ct_ = context.Operators.First<Coding>((IEnumerable<Coding>)cs_);
				FhirUri cu_ = ct_?.SystemElement;
				string cv_ = FHIRHelpers_4_3_000.ToString(cu_);
				bool? cw_ = context.Operators.Equal(cv_, "http://loinc.org");
				List<Coding> cy_ = cr_?.Coding;
				Coding cz_ = context.Operators.First<Coding>((IEnumerable<Coding>)cy_);
				Code da_ = cz_?.CodeElement;
				string db_ = FHIRHelpers_4_3_000.ToString(da_);
				bool? dc_ = context.Operators.Equal(db_, "8480-6");
				bool? dd_ = context.Operators.And(cw_, dc_);

				return dd_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = o_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity q_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? r_ = context.Operators.Greater(p_, q_);
			bool? t_(Observation BloodPressure)
			{
				DataType de_ = BloodPressure?.Effective;
				object df_ = FHIRHelpers_4_3_000.ToValue(de_);
				CqlInterval<CqlDateTime> dg_ = QICoreCommon_2_0_000.toInterval(df_);
				CqlDateTime dh_ = context.Operators.End(dg_);
				Period di_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_3_000.ToInterval(di_);
				CqlDateTime dk_ = context.Operators.Start(dj_);
				CqlQuantity dl_ = context.Operators.Quantity(1m, "year");
				CqlDateTime dm_ = context.Operators.Subtract(dk_, dl_);
				CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_3_000.ToInterval(di_);
				CqlDateTime dp_ = context.Operators.Start(do_);
				CqlInterval<CqlDateTime> dq_ = context.Operators.Interval(dm_, dp_, true, true);
				bool? dr_ = context.Operators.In<CqlDateTime>(dh_, dq_, default);
				CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_3_000.ToInterval(di_);
				CqlDateTime du_ = context.Operators.Start(dt_);
				bool? dv_ = context.Operators.Not((bool?)(du_ is null));
				bool? dw_ = context.Operators.And(dr_, dv_);
				Code<ObservationStatus> dx_ = BloodPressure?.StatusElement;
				ObservationStatus? dy_ = dx_?.Value;
				string dz_ = context.Operators.Convert<string>(dy_);
				string[] ea_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? eb_ = context.Operators.In<string>(dz_, ea_ as IEnumerable<string>);
				bool? ec_ = context.Operators.And(dw_, eb_);

				return ec_;
			};
			IEnumerable<Observation> u_ = context.Operators.Where<Observation>(d_, t_);
			object v_(Observation @this)
			{
				DataType ed_ = @this?.Effective;
				object ee_ = FHIRHelpers_4_3_000.ToValue(ed_);
				CqlInterval<CqlDateTime> ef_ = QICoreCommon_2_0_000.toInterval(ee_);
				CqlDateTime eg_ = context.Operators.Start(ef_);

				return eg_;
			};
			IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
			Observation x_ = context.Operators.Last<Observation>(w_);
			List<Observation.ComponentComponent> y_ = x_?.Component;
			bool? z_(Observation.ComponentComponent @this)
			{
				CodeableConcept eh_ = @this?.Code;
				List<Coding> ei_ = eh_?.Coding;
				Coding ej_ = context.Operators.First<Coding>((IEnumerable<Coding>)ei_);
				FhirUri ek_ = ej_?.SystemElement;
				string el_ = FHIRHelpers_4_3_000.ToString(ek_);
				bool? em_ = context.Operators.Equal(el_, "http://loinc.org");
				List<Coding> eo_ = eh_?.Coding;
				Coding ep_ = context.Operators.First<Coding>((IEnumerable<Coding>)eo_);
				Code eq_ = ep_?.CodeElement;
				string er_ = FHIRHelpers_4_3_000.ToString(eq_);
				bool? es_ = context.Operators.Equal(er_, "8462-4");
				bool? et_ = context.Operators.And(em_, es_);

				return et_;
			};
			IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
			Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
			DataType ac_ = ab_?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			bool? ag_ = context.Operators.Greater(p_, q_);
			bool? ah_ = context.Operators.And(r_, ag_);
			bool? aj_(Observation BloodPressure)
			{
				DataType eu_ = BloodPressure?.Effective;
				object ev_ = FHIRHelpers_4_3_000.ToValue(eu_);
				CqlInterval<CqlDateTime> ew_ = QICoreCommon_2_0_000.toInterval(ev_);
				CqlDateTime ex_ = context.Operators.End(ew_);
				Period ey_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_3_000.ToInterval(ey_);
				CqlDateTime fa_ = context.Operators.Start(ez_);
				CqlQuantity fb_ = context.Operators.Quantity(1m, "year");
				CqlDateTime fc_ = context.Operators.Subtract(fa_, fb_);
				CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_3_000.ToInterval(ey_);
				CqlDateTime ff_ = context.Operators.Start(fe_);
				CqlInterval<CqlDateTime> fg_ = context.Operators.Interval(fc_, ff_, true, true);
				bool? fh_ = context.Operators.In<CqlDateTime>(ex_, fg_, default);
				CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_3_000.ToInterval(ey_);
				CqlDateTime fk_ = context.Operators.Start(fj_);
				bool? fl_ = context.Operators.Not((bool?)(fk_ is null));
				bool? fm_ = context.Operators.And(fh_, fl_);
				Code<ObservationStatus> fn_ = BloodPressure?.StatusElement;
				ObservationStatus? fo_ = fn_?.Value;
				string fp_ = context.Operators.Convert<string>(fo_);
				string[] fq_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? fr_ = context.Operators.In<string>(fp_, fq_ as IEnumerable<string>);
				bool? fs_ = context.Operators.And(fm_, fr_);

				return fs_;
			};
			IEnumerable<Observation> ak_ = context.Operators.Where<Observation>(d_, aj_);
			object al_(Observation @this)
			{
				DataType ft_ = @this?.Effective;
				object fu_ = FHIRHelpers_4_3_000.ToValue(ft_);
				CqlInterval<CqlDateTime> fv_ = QICoreCommon_2_0_000.toInterval(fu_);
				CqlDateTime fw_ = context.Operators.Start(fv_);

				return fw_;
			};
			IEnumerable<Observation> am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
			Observation an_ = context.Operators.Last<Observation>(am_);
			List<Observation.ComponentComponent> ao_ = an_?.Component;
			bool? ap_(Observation.ComponentComponent @this)
			{
				CodeableConcept fx_ = @this?.Code;
				List<Coding> fy_ = fx_?.Coding;
				Coding fz_ = context.Operators.First<Coding>((IEnumerable<Coding>)fy_);
				FhirUri ga_ = fz_?.SystemElement;
				string gb_ = FHIRHelpers_4_3_000.ToString(ga_);
				bool? gc_ = context.Operators.Equal(gb_, "http://loinc.org");
				List<Coding> ge_ = fx_?.Coding;
				Coding gf_ = context.Operators.First<Coding>((IEnumerable<Coding>)ge_);
				Code gg_ = gf_?.CodeElement;
				string gh_ = FHIRHelpers_4_3_000.ToString(gg_);
				bool? gi_ = context.Operators.Equal(gh_, "8480-6");
				bool? gj_ = context.Operators.And(gc_, gi_);

				return gj_;
			};
			IEnumerable<Observation.ComponentComponent> aq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ao_, ap_);
			Observation.ComponentComponent ar_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aq_);
			DataType as_ = ar_?.Value;
			object at_ = FHIRHelpers_4_3_000.ToValue(as_);
			CqlQuantity av_ = context.Operators.Quantity(130m, "mm[Hg]");
			bool? aw_ = context.Operators.GreaterOrEqual(p_, av_);
			bool? ay_(Observation BloodPressure)
			{
				DataType gk_ = BloodPressure?.Effective;
				object gl_ = FHIRHelpers_4_3_000.ToValue(gk_);
				CqlInterval<CqlDateTime> gm_ = QICoreCommon_2_0_000.toInterval(gl_);
				CqlDateTime gn_ = context.Operators.End(gm_);
				Period go_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> gp_ = FHIRHelpers_4_3_000.ToInterval(go_);
				CqlDateTime gq_ = context.Operators.Start(gp_);
				CqlQuantity gr_ = context.Operators.Quantity(1m, "year");
				CqlDateTime gs_ = context.Operators.Subtract(gq_, gr_);
				CqlInterval<CqlDateTime> gu_ = FHIRHelpers_4_3_000.ToInterval(go_);
				CqlDateTime gv_ = context.Operators.Start(gu_);
				CqlInterval<CqlDateTime> gw_ = context.Operators.Interval(gs_, gv_, true, true);
				bool? gx_ = context.Operators.In<CqlDateTime>(gn_, gw_, default);
				CqlInterval<CqlDateTime> gz_ = FHIRHelpers_4_3_000.ToInterval(go_);
				CqlDateTime ha_ = context.Operators.Start(gz_);
				bool? hb_ = context.Operators.Not((bool?)(ha_ is null));
				bool? hc_ = context.Operators.And(gx_, hb_);
				Code<ObservationStatus> hd_ = BloodPressure?.StatusElement;
				ObservationStatus? he_ = hd_?.Value;
				string hf_ = context.Operators.Convert<string>(he_);
				string[] hg_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? hh_ = context.Operators.In<string>(hf_, hg_ as IEnumerable<string>);
				bool? hi_ = context.Operators.And(hc_, hh_);

				return hi_;
			};
			IEnumerable<Observation> az_ = context.Operators.Where<Observation>(d_, ay_);
			object ba_(Observation @this)
			{
				DataType hj_ = @this?.Effective;
				object hk_ = FHIRHelpers_4_3_000.ToValue(hj_);
				CqlInterval<CqlDateTime> hl_ = QICoreCommon_2_0_000.toInterval(hk_);
				CqlDateTime hm_ = context.Operators.Start(hl_);

				return hm_;
			};
			IEnumerable<Observation> bb_ = context.Operators.SortBy<Observation>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);
			Observation bc_ = context.Operators.Last<Observation>(bb_);
			List<Observation.ComponentComponent> bd_ = bc_?.Component;
			bool? be_(Observation.ComponentComponent @this)
			{
				CodeableConcept hn_ = @this?.Code;
				List<Coding> ho_ = hn_?.Coding;
				Coding hp_ = context.Operators.First<Coding>((IEnumerable<Coding>)ho_);
				FhirUri hq_ = hp_?.SystemElement;
				string hr_ = FHIRHelpers_4_3_000.ToString(hq_);
				bool? hs_ = context.Operators.Equal(hr_, "http://loinc.org");
				List<Coding> hu_ = hn_?.Coding;
				Coding hv_ = context.Operators.First<Coding>((IEnumerable<Coding>)hu_);
				Code hw_ = hv_?.CodeElement;
				string hx_ = FHIRHelpers_4_3_000.ToString(hw_);
				bool? hy_ = context.Operators.Equal(hx_, "8462-4");
				bool? hz_ = context.Operators.And(hs_, hy_);

				return hz_;
			};
			IEnumerable<Observation.ComponentComponent> bf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bd_, be_);
			Observation.ComponentComponent bg_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bf_);
			DataType bh_ = bg_?.Value;
			object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
			CqlQuantity bk_ = context.Operators.Quantity(80m, "mm[Hg]");
			bool? bl_ = context.Operators.GreaterOrEqual(p_, bk_);
			bool? bm_ = context.Operators.Or(aw_, bl_);
			bool? bn_ = context.Operators.And(ah_, bm_);

			return bn_;
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
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? g_(Observation BloodPressure)
			{
				DataType bq_ = BloodPressure?.Effective;
				object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
				CqlInterval<CqlDateTime> bs_ = QICoreCommon_2_0_000.toInterval(br_);
				CqlDateTime bt_ = context.Operators.End(bs_);
				Period bu_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_3_000.ToInterval(bu_);
				bool? bw_ = context.Operators.In<CqlDateTime>(bt_, bv_, "day");

				return bw_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType bx_ = @this?.Effective;
				object by_ = FHIRHelpers_4_3_000.ToValue(bx_);
				CqlInterval<CqlDateTime> bz_ = QICoreCommon_2_0_000.toInterval(by_);
				CqlDateTime ca_ = context.Operators.Start(bz_);

				return ca_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.Last<Observation>(j_);
			List<Observation.ComponentComponent> l_ = k_?.Component;
			bool? m_(Observation.ComponentComponent @this)
			{
				CodeableConcept cb_ = @this?.Code;
				List<Coding> cc_ = cb_?.Coding;
				Coding cd_ = context.Operators.First<Coding>((IEnumerable<Coding>)cc_);
				FhirUri ce_ = cd_?.SystemElement;
				string cf_ = FHIRHelpers_4_3_000.ToString(ce_);
				bool? cg_ = context.Operators.Equal(cf_, "http://loinc.org");
				List<Coding> ci_ = cb_?.Coding;
				Coding cj_ = context.Operators.First<Coding>((IEnumerable<Coding>)ci_);
				Code ck_ = cj_?.CodeElement;
				string cl_ = FHIRHelpers_4_3_000.ToString(ck_);
				bool? cm_ = context.Operators.Equal(cl_, "8480-6");
				bool? cn_ = context.Operators.And(cg_, cm_);

				return cn_;
			};
			IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
			Observation.ComponentComponent o_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(n_);
			DataType p_ = o_?.Value;
			object q_ = FHIRHelpers_4_3_000.ToValue(p_);
			CqlQuantity r_ = q_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity s_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? t_ = context.Operators.Greater(r_, s_);
			bool? v_(Observation BloodPressure)
			{
				DataType co_ = BloodPressure?.Effective;
				object cp_ = FHIRHelpers_4_3_000.ToValue(co_);
				CqlInterval<CqlDateTime> cq_ = QICoreCommon_2_0_000.toInterval(cp_);
				CqlDateTime cr_ = context.Operators.End(cq_);
				Period cs_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_3_000.ToInterval(cs_);
				bool? cu_ = context.Operators.In<CqlDateTime>(cr_, ct_, "day");

				return cu_;
			};
			IEnumerable<Observation> w_ = context.Operators.Where<Observation>(f_, v_);
			object x_(Observation @this)
			{
				DataType cv_ = @this?.Effective;
				object cw_ = FHIRHelpers_4_3_000.ToValue(cv_);
				CqlInterval<CqlDateTime> cx_ = QICoreCommon_2_0_000.toInterval(cw_);
				CqlDateTime cy_ = context.Operators.Start(cx_);

				return cy_;
			};
			IEnumerable<Observation> y_ = context.Operators.SortBy<Observation>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
			Observation z_ = context.Operators.Last<Observation>(y_);
			List<Observation.ComponentComponent> aa_ = z_?.Component;
			bool? ab_(Observation.ComponentComponent @this)
			{
				CodeableConcept cz_ = @this?.Code;
				List<Coding> da_ = cz_?.Coding;
				Coding db_ = context.Operators.First<Coding>((IEnumerable<Coding>)da_);
				FhirUri dc_ = db_?.SystemElement;
				string dd_ = FHIRHelpers_4_3_000.ToString(dc_);
				bool? de_ = context.Operators.Equal(dd_, "http://loinc.org");
				List<Coding> dg_ = cz_?.Coding;
				Coding dh_ = context.Operators.First<Coding>((IEnumerable<Coding>)dg_);
				Code di_ = dh_?.CodeElement;
				string dj_ = FHIRHelpers_4_3_000.ToString(di_);
				bool? dk_ = context.Operators.Equal(dj_, "8462-4");
				bool? dl_ = context.Operators.And(de_, dk_);

				return dl_;
			};
			IEnumerable<Observation.ComponentComponent> ac_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aa_, ab_);
			Observation.ComponentComponent ad_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ac_);
			DataType ae_ = ad_?.Value;
			object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			bool? ai_ = context.Operators.Greater(r_, s_);
			bool? aj_ = context.Operators.And(t_, ai_);
			bool? al_(Observation BloodPressure)
			{
				DataType dm_ = BloodPressure?.Effective;
				object dn_ = FHIRHelpers_4_3_000.ToValue(dm_);
				CqlInterval<CqlDateTime> do_ = QICoreCommon_2_0_000.toInterval(dn_);
				CqlDateTime dp_ = context.Operators.End(do_);
				Period dq_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> dr_ = FHIRHelpers_4_3_000.ToInterval(dq_);
				bool? ds_ = context.Operators.In<CqlDateTime>(dp_, dr_, "day");

				return ds_;
			};
			IEnumerable<Observation> am_ = context.Operators.Where<Observation>(f_, al_);
			object an_(Observation @this)
			{
				DataType dt_ = @this?.Effective;
				object du_ = FHIRHelpers_4_3_000.ToValue(dt_);
				CqlInterval<CqlDateTime> dv_ = QICoreCommon_2_0_000.toInterval(du_);
				CqlDateTime dw_ = context.Operators.Start(dv_);

				return dw_;
			};
			IEnumerable<Observation> ao_ = context.Operators.SortBy<Observation>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ap_ = context.Operators.Last<Observation>(ao_);
			List<Observation.ComponentComponent> aq_ = ap_?.Component;
			bool? ar_(Observation.ComponentComponent @this)
			{
				CodeableConcept dx_ = @this?.Code;
				List<Coding> dy_ = dx_?.Coding;
				Coding dz_ = context.Operators.First<Coding>((IEnumerable<Coding>)dy_);
				FhirUri ea_ = dz_?.SystemElement;
				string eb_ = FHIRHelpers_4_3_000.ToString(ea_);
				bool? ec_ = context.Operators.Equal(eb_, "http://loinc.org");
				List<Coding> ee_ = dx_?.Coding;
				Coding ef_ = context.Operators.First<Coding>((IEnumerable<Coding>)ee_);
				Code eg_ = ef_?.CodeElement;
				string eh_ = FHIRHelpers_4_3_000.ToString(eg_);
				bool? ei_ = context.Operators.Equal(eh_, "8480-6");
				bool? ej_ = context.Operators.And(ec_, ei_);

				return ej_;
			};
			IEnumerable<Observation.ComponentComponent> as_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aq_, ar_);
			Observation.ComponentComponent at_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(as_);
			DataType au_ = at_?.Value;
			object av_ = FHIRHelpers_4_3_000.ToValue(au_);
			CqlQuantity ax_ = context.Operators.Quantity(130m, "mm[Hg]");
			bool? ay_ = context.Operators.GreaterOrEqual(r_, ax_);
			bool? ba_(Observation BloodPressure)
			{
				DataType ek_ = BloodPressure?.Effective;
				object el_ = FHIRHelpers_4_3_000.ToValue(ek_);
				CqlInterval<CqlDateTime> em_ = QICoreCommon_2_0_000.toInterval(el_);
				CqlDateTime en_ = context.Operators.End(em_);
				Period eo_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ep_ = FHIRHelpers_4_3_000.ToInterval(eo_);
				bool? eq_ = context.Operators.In<CqlDateTime>(en_, ep_, "day");

				return eq_;
			};
			IEnumerable<Observation> bb_ = context.Operators.Where<Observation>(f_, ba_);
			object bc_(Observation @this)
			{
				DataType er_ = @this?.Effective;
				object es_ = FHIRHelpers_4_3_000.ToValue(er_);
				CqlInterval<CqlDateTime> et_ = QICoreCommon_2_0_000.toInterval(es_);
				CqlDateTime eu_ = context.Operators.Start(et_);

				return eu_;
			};
			IEnumerable<Observation> bd_ = context.Operators.SortBy<Observation>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
			Observation be_ = context.Operators.Last<Observation>(bd_);
			List<Observation.ComponentComponent> bf_ = be_?.Component;
			bool? bg_(Observation.ComponentComponent @this)
			{
				CodeableConcept ev_ = @this?.Code;
				List<Coding> ew_ = ev_?.Coding;
				Coding ex_ = context.Operators.First<Coding>((IEnumerable<Coding>)ew_);
				FhirUri ey_ = ex_?.SystemElement;
				string ez_ = FHIRHelpers_4_3_000.ToString(ey_);
				bool? fa_ = context.Operators.Equal(ez_, "http://loinc.org");
				List<Coding> fc_ = ev_?.Coding;
				Coding fd_ = context.Operators.First<Coding>((IEnumerable<Coding>)fc_);
				Code fe_ = fd_?.CodeElement;
				string ff_ = FHIRHelpers_4_3_000.ToString(fe_);
				bool? fg_ = context.Operators.Equal(ff_, "8462-4");
				bool? fh_ = context.Operators.And(fa_, fg_);

				return fh_;
			};
			IEnumerable<Observation.ComponentComponent> bh_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bf_, bg_);
			Observation.ComponentComponent bi_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bh_);
			DataType bj_ = bi_?.Value;
			object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
			CqlQuantity bm_ = context.Operators.Quantity(80m, "mm[Hg]");
			bool? bn_ = context.Operators.GreaterOrEqual(r_, bm_);
			bool? bo_ = context.Operators.Or(ay_, bn_);
			bool? bp_ = context.Operators.And(aj_, bo_);

			return bp_;
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? e_(Observation BloodPressure)
			{
				DataType bw_ = BloodPressure?.Effective;
				object bx_ = FHIRHelpers_4_3_000.ToValue(bw_);
				CqlInterval<CqlDateTime> by_ = QICoreCommon_2_0_000.toInterval(bx_);
				CqlDateTime bz_ = context.Operators.End(by_);
				Period ca_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_3_000.ToInterval(ca_);
				bool? cc_ = context.Operators.In<CqlDateTime>(bz_, cb_, "day");
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
			CqlQuantity p_ = o_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity q_ = context.Operators.Quantity(130m, "mm[Hg]");
			CqlQuantity r_ = context.Operators.Quantity(139m, "mm[Hg]");
			CqlInterval<CqlQuantity> s_ = context.Operators.Interval(q_, r_, true, true);
			bool? t_ = context.Operators.In<CqlQuantity>(p_, s_, default);
			bool? v_(Observation BloodPressure)
			{
				DataType da_ = BloodPressure?.Effective;
				object db_ = FHIRHelpers_4_3_000.ToValue(da_);
				CqlInterval<CqlDateTime> dc_ = QICoreCommon_2_0_000.toInterval(db_);
				CqlDateTime dd_ = context.Operators.End(dc_);
				Period de_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_3_000.ToInterval(de_);
				bool? dg_ = context.Operators.In<CqlDateTime>(dd_, df_, "day");
				Code<ObservationStatus> dh_ = BloodPressure?.StatusElement;
				ObservationStatus? di_ = dh_?.Value;
				string dj_ = context.Operators.Convert<string>(di_);
				string[] dk_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? dl_ = context.Operators.In<string>(dj_, dk_ as IEnumerable<string>);
				bool? dm_ = context.Operators.And(dg_, dl_);

				return dm_;
			};
			IEnumerable<Observation> w_ = context.Operators.Where<Observation>(d_, v_);
			object x_(Observation @this)
			{
				DataType dn_ = @this?.Effective;
				object do_ = FHIRHelpers_4_3_000.ToValue(dn_);
				CqlInterval<CqlDateTime> dp_ = QICoreCommon_2_0_000.toInterval(do_);
				CqlDateTime dq_ = context.Operators.Start(dp_);

				return dq_;
			};
			IEnumerable<Observation> y_ = context.Operators.SortBy<Observation>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
			Observation z_ = context.Operators.Last<Observation>(y_);
			List<Observation.ComponentComponent> aa_ = z_?.Component;
			bool? ab_(Observation.ComponentComponent @this)
			{
				CodeableConcept dr_ = @this?.Code;
				List<Coding> ds_ = dr_?.Coding;
				Coding dt_ = context.Operators.First<Coding>((IEnumerable<Coding>)ds_);
				FhirUri du_ = dt_?.SystemElement;
				string dv_ = FHIRHelpers_4_3_000.ToString(du_);
				bool? dw_ = context.Operators.Equal(dv_, "http://loinc.org");
				List<Coding> dy_ = dr_?.Coding;
				Coding dz_ = context.Operators.First<Coding>((IEnumerable<Coding>)dy_);
				Code ea_ = dz_?.CodeElement;
				string eb_ = FHIRHelpers_4_3_000.ToString(ea_);
				bool? ec_ = context.Operators.Equal(eb_, "8462-4");
				bool? ed_ = context.Operators.And(dw_, ec_);

				return ed_;
			};
			IEnumerable<Observation.ComponentComponent> ac_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)aa_, ab_);
			Observation.ComponentComponent ad_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ac_);
			DataType ae_ = ad_?.Value;
			object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			CqlQuantity ah_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlQuantity ai_ = context.Operators.Quantity(89m, "mm[Hg]");
			CqlInterval<CqlQuantity> aj_ = context.Operators.Interval(ah_, ai_, true, true);
			bool? ak_ = context.Operators.In<CqlQuantity>(p_, aj_, default);
			bool? al_ = context.Operators.Or(t_, ak_);
			bool? an_(Observation BloodPressure)
			{
				DataType ee_ = BloodPressure?.Effective;
				object ef_ = FHIRHelpers_4_3_000.ToValue(ee_);
				CqlInterval<CqlDateTime> eg_ = QICoreCommon_2_0_000.toInterval(ef_);
				CqlDateTime eh_ = context.Operators.End(eg_);
				Period ei_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_3_000.ToInterval(ei_);
				bool? ek_ = context.Operators.In<CqlDateTime>(eh_, ej_, "day");
				Code<ObservationStatus> el_ = BloodPressure?.StatusElement;
				ObservationStatus? em_ = el_?.Value;
				string en_ = context.Operators.Convert<string>(em_);
				string[] eo_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ep_ = context.Operators.In<string>(en_, eo_ as IEnumerable<string>);
				bool? eq_ = context.Operators.And(ek_, ep_);

				return eq_;
			};
			IEnumerable<Observation> ao_ = context.Operators.Where<Observation>(d_, an_);
			object ap_(Observation @this)
			{
				DataType er_ = @this?.Effective;
				object es_ = FHIRHelpers_4_3_000.ToValue(er_);
				CqlInterval<CqlDateTime> et_ = QICoreCommon_2_0_000.toInterval(es_);
				CqlDateTime eu_ = context.Operators.Start(et_);

				return eu_;
			};
			IEnumerable<Observation> aq_ = context.Operators.SortBy<Observation>(ao_, ap_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ar_ = context.Operators.Last<Observation>(aq_);
			List<Observation.ComponentComponent> as_ = ar_?.Component;
			bool? at_(Observation.ComponentComponent @this)
			{
				CodeableConcept ev_ = @this?.Code;
				List<Coding> ew_ = ev_?.Coding;
				Coding ex_ = context.Operators.First<Coding>((IEnumerable<Coding>)ew_);
				FhirUri ey_ = ex_?.SystemElement;
				string ez_ = FHIRHelpers_4_3_000.ToString(ey_);
				bool? fa_ = context.Operators.Equal(ez_, "http://loinc.org");
				List<Coding> fc_ = ev_?.Coding;
				Coding fd_ = context.Operators.First<Coding>((IEnumerable<Coding>)fc_);
				Code fe_ = fd_?.CodeElement;
				string ff_ = FHIRHelpers_4_3_000.ToString(fe_);
				bool? fg_ = context.Operators.Equal(ff_, "8480-6");
				bool? fh_ = context.Operators.And(fa_, fg_);

				return fh_;
			};
			IEnumerable<Observation.ComponentComponent> au_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)as_, at_);
			Observation.ComponentComponent av_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(au_);
			DataType aw_ = av_?.Value;
			object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
			CqlQuantity az_ = context.Operators.Quantity(140m, "mm[Hg]");
			bool? ba_ = context.Operators.GreaterOrEqual(p_, az_);
			bool? bc_(Observation BloodPressure)
			{
				DataType fi_ = BloodPressure?.Effective;
				object fj_ = FHIRHelpers_4_3_000.ToValue(fi_);
				CqlInterval<CqlDateTime> fk_ = QICoreCommon_2_0_000.toInterval(fj_);
				CqlDateTime fl_ = context.Operators.End(fk_);
				Period fm_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> fn_ = FHIRHelpers_4_3_000.ToInterval(fm_);
				bool? fo_ = context.Operators.In<CqlDateTime>(fl_, fn_, "day");
				Code<ObservationStatus> fp_ = BloodPressure?.StatusElement;
				ObservationStatus? fq_ = fp_?.Value;
				string fr_ = context.Operators.Convert<string>(fq_);
				string[] fs_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ft_ = context.Operators.In<string>(fr_, fs_ as IEnumerable<string>);
				bool? fu_ = context.Operators.And(fo_, ft_);

				return fu_;
			};
			IEnumerable<Observation> bd_ = context.Operators.Where<Observation>(d_, bc_);
			object be_(Observation @this)
			{
				DataType fv_ = @this?.Effective;
				object fw_ = FHIRHelpers_4_3_000.ToValue(fv_);
				CqlInterval<CqlDateTime> fx_ = QICoreCommon_2_0_000.toInterval(fw_);
				CqlDateTime fy_ = context.Operators.Start(fx_);

				return fy_;
			};
			IEnumerable<Observation> bf_ = context.Operators.SortBy<Observation>(bd_, be_, System.ComponentModel.ListSortDirection.Ascending);
			Observation bg_ = context.Operators.Last<Observation>(bf_);
			List<Observation.ComponentComponent> bh_ = bg_?.Component;
			bool? bi_(Observation.ComponentComponent @this)
			{
				CodeableConcept fz_ = @this?.Code;
				List<Coding> ga_ = fz_?.Coding;
				Coding gb_ = context.Operators.First<Coding>((IEnumerable<Coding>)ga_);
				FhirUri gc_ = gb_?.SystemElement;
				string gd_ = FHIRHelpers_4_3_000.ToString(gc_);
				bool? ge_ = context.Operators.Equal(gd_, "http://loinc.org");
				List<Coding> gg_ = fz_?.Coding;
				Coding gh_ = context.Operators.First<Coding>((IEnumerable<Coding>)gg_);
				Code gi_ = gh_?.CodeElement;
				string gj_ = FHIRHelpers_4_3_000.ToString(gi_);
				bool? gk_ = context.Operators.Equal(gj_, "8462-4");
				bool? gl_ = context.Operators.And(ge_, gk_);

				return gl_;
			};
			IEnumerable<Observation.ComponentComponent> bj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bh_, bi_);
			Observation.ComponentComponent bk_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bj_);
			DataType bl_ = bk_?.Value;
			object bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
			CqlQuantity bo_ = context.Operators.Quantity(90m, "mm[Hg]");
			bool? bp_ = context.Operators.GreaterOrEqual(p_, bo_);
			bool? bq_ = context.Operators.Or(ba_, bp_);
			bool? br_ = context.Operators.Not(bq_);
			bool? bs_ = context.Operators.And(al_, br_);
			IEnumerable<Encounter> bt_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			bool? bu_ = context.Operators.Exists<Encounter>(bt_);
			bool? bv_ = context.Operators.And(bs_, bu_);

			return bv_;
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
		IEnumerable<ServiceRequest> c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, default);
		CqlCode d_ = this.EKG_study();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, default);
		IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
		CqlValueSet h_ = this.Laboratory_Tests_for_Hypertension();
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, default);
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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? e_(Observation BloodPressure)
			{
				DataType br_ = BloodPressure?.Effective;
				object bs_ = FHIRHelpers_4_3_000.ToValue(br_);
				CqlInterval<CqlDateTime> bt_ = QICoreCommon_2_0_000.toInterval(bs_);
				CqlDateTime bu_ = context.Operators.End(bt_);
				Period bv_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_3_000.ToInterval(bv_);
				bool? bx_ = context.Operators.In<CqlDateTime>(bu_, bw_, default);
				Code<ObservationStatus> by_ = BloodPressure?.StatusElement;
				ObservationStatus? bz_ = by_?.Value;
				string ca_ = context.Operators.Convert<string>(bz_);
				string[] cb_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? cc_ = context.Operators.In<string>(ca_, cb_ as IEnumerable<string>);
				bool? cd_ = context.Operators.And(bx_, cc_);

				return cd_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				DataType ce_ = @this?.Effective;
				object cf_ = FHIRHelpers_4_3_000.ToValue(ce_);
				CqlInterval<CqlDateTime> cg_ = QICoreCommon_2_0_000.toInterval(cf_);
				CqlDateTime ch_ = context.Operators.Start(cg_);

				return ch_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			List<Observation.ComponentComponent> j_ = i_?.Component;
			bool? k_(Observation.ComponentComponent @this)
			{
				CodeableConcept ci_ = @this?.Code;
				List<Coding> cj_ = ci_?.Coding;
				Coding ck_ = context.Operators.First<Coding>((IEnumerable<Coding>)cj_);
				FhirUri cl_ = ck_?.SystemElement;
				string cm_ = FHIRHelpers_4_3_000.ToString(cl_);
				bool? cn_ = context.Operators.Equal(cm_, "http://loinc.org");
				List<Coding> cp_ = ci_?.Coding;
				Coding cq_ = context.Operators.First<Coding>((IEnumerable<Coding>)cp_);
				Code cr_ = cq_?.CodeElement;
				string cs_ = FHIRHelpers_4_3_000.ToString(cr_);
				bool? ct_ = context.Operators.Equal(cs_, "8480-6");
				bool? cu_ = context.Operators.And(cn_, ct_);

				return cu_;
			};
			IEnumerable<Observation.ComponentComponent> l_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)j_, k_);
			Observation.ComponentComponent m_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(l_);
			DataType n_ = m_?.Value;
			object o_ = FHIRHelpers_4_3_000.ToValue(n_);
			CqlQuantity p_ = o_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity q_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? r_ = context.Operators.Greater(p_, q_);
			bool? t_(Observation BloodPressure)
			{
				DataType cv_ = BloodPressure?.Effective;
				object cw_ = FHIRHelpers_4_3_000.ToValue(cv_);
				CqlInterval<CqlDateTime> cx_ = QICoreCommon_2_0_000.toInterval(cw_);
				CqlDateTime cy_ = context.Operators.End(cx_);
				Period cz_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_3_000.ToInterval(cz_);
				bool? db_ = context.Operators.In<CqlDateTime>(cy_, da_, default);
				Code<ObservationStatus> dc_ = BloodPressure?.StatusElement;
				ObservationStatus? dd_ = dc_?.Value;
				string de_ = context.Operators.Convert<string>(dd_);
				string[] df_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? dg_ = context.Operators.In<string>(de_, df_ as IEnumerable<string>);
				bool? dh_ = context.Operators.And(db_, dg_);

				return dh_;
			};
			IEnumerable<Observation> u_ = context.Operators.Where<Observation>(d_, t_);
			object v_(Observation @this)
			{
				DataType di_ = @this?.Effective;
				object dj_ = FHIRHelpers_4_3_000.ToValue(di_);
				CqlInterval<CqlDateTime> dk_ = QICoreCommon_2_0_000.toInterval(dj_);
				CqlDateTime dl_ = context.Operators.Start(dk_);

				return dl_;
			};
			IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
			Observation x_ = context.Operators.Last<Observation>(w_);
			List<Observation.ComponentComponent> y_ = x_?.Component;
			bool? z_(Observation.ComponentComponent @this)
			{
				CodeableConcept dm_ = @this?.Code;
				List<Coding> dn_ = dm_?.Coding;
				Coding do_ = context.Operators.First<Coding>((IEnumerable<Coding>)dn_);
				FhirUri dp_ = do_?.SystemElement;
				string dq_ = FHIRHelpers_4_3_000.ToString(dp_);
				bool? dr_ = context.Operators.Equal(dq_, "http://loinc.org");
				List<Coding> dt_ = dm_?.Coding;
				Coding du_ = context.Operators.First<Coding>((IEnumerable<Coding>)dt_);
				Code dv_ = du_?.CodeElement;
				string dw_ = FHIRHelpers_4_3_000.ToString(dv_);
				bool? dx_ = context.Operators.Equal(dw_, "8462-4");
				bool? dy_ = context.Operators.And(dr_, dx_);

				return dy_;
			};
			IEnumerable<Observation.ComponentComponent> aa_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)y_, z_);
			Observation.ComponentComponent ab_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aa_);
			DataType ac_ = ab_?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			bool? ag_ = context.Operators.Greater(p_, q_);
			bool? ah_ = context.Operators.And(r_, ag_);
			bool? aj_(Observation BloodPressure)
			{
				DataType dz_ = BloodPressure?.Effective;
				object ea_ = FHIRHelpers_4_3_000.ToValue(dz_);
				CqlInterval<CqlDateTime> eb_ = QICoreCommon_2_0_000.toInterval(ea_);
				CqlDateTime ec_ = context.Operators.End(eb_);
				Period ed_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_3_000.ToInterval(ed_);
				bool? ef_ = context.Operators.In<CqlDateTime>(ec_, ee_, default);
				Code<ObservationStatus> eg_ = BloodPressure?.StatusElement;
				ObservationStatus? eh_ = eg_?.Value;
				string ei_ = context.Operators.Convert<string>(eh_);
				string[] ej_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ek_ = context.Operators.In<string>(ei_, ej_ as IEnumerable<string>);
				bool? el_ = context.Operators.And(ef_, ek_);

				return el_;
			};
			IEnumerable<Observation> ak_ = context.Operators.Where<Observation>(d_, aj_);
			object al_(Observation @this)
			{
				DataType em_ = @this?.Effective;
				object en_ = FHIRHelpers_4_3_000.ToValue(em_);
				CqlInterval<CqlDateTime> eo_ = QICoreCommon_2_0_000.toInterval(en_);
				CqlDateTime ep_ = context.Operators.Start(eo_);

				return ep_;
			};
			IEnumerable<Observation> am_ = context.Operators.SortBy<Observation>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
			Observation an_ = context.Operators.Last<Observation>(am_);
			List<Observation.ComponentComponent> ao_ = an_?.Component;
			bool? ap_(Observation.ComponentComponent @this)
			{
				CodeableConcept eq_ = @this?.Code;
				List<Coding> er_ = eq_?.Coding;
				Coding es_ = context.Operators.First<Coding>((IEnumerable<Coding>)er_);
				FhirUri et_ = es_?.SystemElement;
				string eu_ = FHIRHelpers_4_3_000.ToString(et_);
				bool? ev_ = context.Operators.Equal(eu_, "http://loinc.org");
				List<Coding> ex_ = eq_?.Coding;
				Coding ey_ = context.Operators.First<Coding>((IEnumerable<Coding>)ex_);
				Code ez_ = ey_?.CodeElement;
				string fa_ = FHIRHelpers_4_3_000.ToString(ez_);
				bool? fb_ = context.Operators.Equal(fa_, "8480-6");
				bool? fc_ = context.Operators.And(ev_, fb_);

				return fc_;
			};
			IEnumerable<Observation.ComponentComponent> aq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ao_, ap_);
			Observation.ComponentComponent ar_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aq_);
			DataType as_ = ar_?.Value;
			object at_ = FHIRHelpers_4_3_000.ToValue(as_);
			CqlQuantity av_ = context.Operators.Quantity(140m, "mm[Hg]");
			bool? aw_ = context.Operators.GreaterOrEqual(p_, av_);
			bool? ay_(Observation BloodPressure)
			{
				DataType fd_ = BloodPressure?.Effective;
				object fe_ = FHIRHelpers_4_3_000.ToValue(fd_);
				CqlInterval<CqlDateTime> ff_ = QICoreCommon_2_0_000.toInterval(fe_);
				CqlDateTime fg_ = context.Operators.End(ff_);
				Period fh_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> fi_ = FHIRHelpers_4_3_000.ToInterval(fh_);
				bool? fj_ = context.Operators.In<CqlDateTime>(fg_, fi_, default);
				Code<ObservationStatus> fk_ = BloodPressure?.StatusElement;
				ObservationStatus? fl_ = fk_?.Value;
				string fm_ = context.Operators.Convert<string>(fl_);
				string[] fn_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? fo_ = context.Operators.In<string>(fm_, fn_ as IEnumerable<string>);
				bool? fp_ = context.Operators.And(fj_, fo_);

				return fp_;
			};
			IEnumerable<Observation> az_ = context.Operators.Where<Observation>(d_, ay_);
			object ba_(Observation @this)
			{
				DataType fq_ = @this?.Effective;
				object fr_ = FHIRHelpers_4_3_000.ToValue(fq_);
				CqlInterval<CqlDateTime> fs_ = QICoreCommon_2_0_000.toInterval(fr_);
				CqlDateTime ft_ = context.Operators.Start(fs_);

				return ft_;
			};
			IEnumerable<Observation> bb_ = context.Operators.SortBy<Observation>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);
			Observation bc_ = context.Operators.Last<Observation>(bb_);
			List<Observation.ComponentComponent> bd_ = bc_?.Component;
			bool? be_(Observation.ComponentComponent @this)
			{
				CodeableConcept fu_ = @this?.Code;
				List<Coding> fv_ = fu_?.Coding;
				Coding fw_ = context.Operators.First<Coding>((IEnumerable<Coding>)fv_);
				FhirUri fx_ = fw_?.SystemElement;
				string fy_ = FHIRHelpers_4_3_000.ToString(fx_);
				bool? fz_ = context.Operators.Equal(fy_, "http://loinc.org");
				List<Coding> gb_ = fu_?.Coding;
				Coding gc_ = context.Operators.First<Coding>((IEnumerable<Coding>)gb_);
				Code gd_ = gc_?.CodeElement;
				string ge_ = FHIRHelpers_4_3_000.ToString(gd_);
				bool? gf_ = context.Operators.Equal(ge_, "8462-4");
				bool? gg_ = context.Operators.And(fz_, gf_);

				return gg_;
			};
			IEnumerable<Observation.ComponentComponent> bf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bd_, be_);
			Observation.ComponentComponent bg_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(bf_);
			DataType bh_ = bg_?.Value;
			object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
			CqlQuantity bk_ = context.Operators.Quantity(90m, "mm[Hg]");
			bool? bl_ = context.Operators.GreaterOrEqual(p_, bk_);
			bool? bm_ = context.Operators.Or(aw_, bl_);
			bool? bn_ = context.Operators.And(ah_, bm_);
			IEnumerable<Encounter> bo_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			bool? bp_ = context.Operators.Exists<Encounter>(bo_);
			bool? bq_ = context.Operators.And(bn_, bp_);

			return bq_;
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
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
			IEnumerable<MedicationRequest> aq_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ap_, default);
			IEnumerable<MedicationRequest> as_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ap_, default);
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
			IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, default);
			CqlCode g_ = this.Diastolic_blood_pressure();
			IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
			IEnumerable<Observation> i_ = context.Operators.RetrieveByCodes<Observation>(h_, default);
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Weight_Reduction_Recommended();
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, default);
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, default);
		IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
		CqlValueSet l_ = this.Dietary_Recommendations();
		IEnumerable<ServiceRequest> m_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, default);
		IEnumerable<ServiceRequest> o_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, default);
		IEnumerable<ServiceRequest> p_ = context.Operators.Union<ServiceRequest>(m_, o_);
		IEnumerable<ServiceRequest> q_ = context.Operators.Union<ServiceRequest>(k_, p_);
		CqlValueSet r_ = this.Recommendation_to_Increase_Physical_Activity();
		IEnumerable<ServiceRequest> s_ = context.Operators.RetrieveByValueSet<ServiceRequest>(r_, default);
		IEnumerable<ServiceRequest> u_ = context.Operators.RetrieveByValueSet<ServiceRequest>(r_, default);
		IEnumerable<ServiceRequest> v_ = context.Operators.Union<ServiceRequest>(s_, u_);
		IEnumerable<ServiceRequest> w_ = context.Operators.Union<ServiceRequest>(q_, v_);
		CqlValueSet x_ = this.Referral_or_Counseling_for_Alcohol_Consumption();
		IEnumerable<ServiceRequest> y_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, default);
		IEnumerable<ServiceRequest> aa_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, default);
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
		IEnumerable<ServiceRequest> c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, default);
		CqlCode d_ = this.EKG_study();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, default);
		IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
		CqlValueSet h_ = this.Laboratory_Tests_for_Hypertension();
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, default);
		IEnumerable<ServiceRequest> k_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, default);
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlCode f_ = this.Follow_up_2_3_months__finding_();
		IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
		IEnumerable<ServiceRequest> h_ = context.Operators.RetrieveByCodes<ServiceRequest>(g_, default);
		CqlCode i_ = this.Follow_up_4_6_months__finding_();
		IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.RetrieveByCodes<ServiceRequest>(j_, default);
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Follow_Up_Within_4_Weeks();
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, default);
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, default);
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
		IEnumerable<MedicationRequest> o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, default);
		IEnumerable<MedicationRequest> q_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, default);
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
			IEnumerable<ServiceRequest> y_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, default);
			IEnumerable<ServiceRequest> aa_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, default);
			IEnumerable<ServiceRequest> ab_ = context.Operators.Union<ServiceRequest>(y_, aa_);
			CqlCode ac_ = this.Follow_up_2_3_months__finding_();
			IEnumerable<CqlCode> ad_ = context.Operators.ToList<CqlCode>(ac_);
			IEnumerable<ServiceRequest> ae_ = context.Operators.RetrieveByCodes<ServiceRequest>(ad_, default);
			CqlCode af_ = this.Follow_up_4_6_months__finding_();
			IEnumerable<CqlCode> ag_ = context.Operators.ToList<CqlCode>(af_);
			IEnumerable<ServiceRequest> ah_ = context.Operators.RetrieveByCodes<ServiceRequest>(ag_, default);
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
			IEnumerable<ServiceRequest> bx_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bw_, default);
			IEnumerable<ServiceRequest> bz_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bw_, default);
			IEnumerable<ServiceRequest> ca_ = context.Operators.Union<ServiceRequest>(bx_, bz_);
			CqlValueSet cb_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
			IEnumerable<ServiceRequest> cc_ = context.Operators.RetrieveByValueSet<ServiceRequest>(cb_, default);
			IEnumerable<ServiceRequest> ce_ = context.Operators.RetrieveByValueSet<ServiceRequest>(cb_, default);
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
