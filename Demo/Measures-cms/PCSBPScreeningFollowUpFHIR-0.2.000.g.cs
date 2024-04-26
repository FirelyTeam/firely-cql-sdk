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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlCode[] a_ = new CqlCode[]
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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Encounter_to_Screen_for_Blood_Pressure();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			bool? g_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, f_, "day");
			Code<Encounter.EncounterStatus> h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ValidEncounter?.StatusElement?.Value);
			bool? i_ = context.Operators.Equivalent(h_, "finished");
			bool? j_ = context.Operators.And(g_, i_);
			CqlCode k_ = FHIRHelpers_4_3_000.ToCode(ValidEncounter?.Class);
			CqlCode l_ = this.@virtual();
			bool? m_ = context.Operators.Equivalent(k_, l_);
			bool? n_ = context.Operators.Not(m_);
			bool? o_ = context.Operators.And(j_, n_);

			return o_;
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
			CqlDateTime e_ = context.Operators.ConvertStringToDateTime(d_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			CqlDateTime g_ = context.Operators.Start(f_);
			int? h_ = context.Operators.CalculateAgeAt(e_, g_, "year");
			bool? i_ = context.Operators.GreaterOrEqual(h_, 18);

			return i_;
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
			IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			bool? f_(Condition Hypertension)
			{
				bool? j_ = QICoreCommon_2_0_000.isProblemListItem(Hypertension);
				bool? k_ = QICoreCommon_2_0_000.isHealthConcern(Hypertension);
				bool? l_ = context.Operators.Or(j_, k_);
				bool? m_ = QICoreCommon_2_0_000.isActive(Hypertension);
				bool? n_ = context.Operators.And(l_, m_);
				CqlInterval<CqlDateTime> o_()
				{
					bool s_()
					{
						CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.prevalenceInterval(Hypertension);
						CqlDateTime u_ = context.Operators.Start(t_);

						return (u_ is null);
					};
					if (s_())
					{
						return null;
					}
					else
					{
						CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.prevalenceInterval(Hypertension);
						CqlDateTime w_ = context.Operators.Start(v_);
						CqlDateTime y_ = context.Operators.Start(v_);
						CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

						return z_;
					};
				};
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? q_ = context.Operators.SameOrBefore(o_(), p_, "day");
				bool? r_ = context.Operators.And(n_, q_);

				return r_;
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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				object ag_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_0_000.toInterval(ag_);
				CqlDateTime ai_ = context.Operators.End(ah_);
				CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? ak_ = context.Operators.In<CqlDateTime>(ai_, aj_, null);
				string al_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] am_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? an_ = context.Operators.In<string>(al_, (am_ as IEnumerable<string>));
				bool? ao_ = context.Operators.And(ak_, an_);

				return ao_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				object ap_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.toInterval(ap_);
				CqlDateTime ar_ = context.Operators.Start(aq_);

				return ar_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				Coding as_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string at_ = context.Operators.Convert<string>(as_?.SystemElement);
				bool? au_ = context.Operators.Equal(at_, "http://loinc.org");
				string aw_ = context.Operators.Convert<string>(as_?.CodeElement);
				bool? ax_ = context.Operators.Equal(aw_, "8480-6");
				bool? ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			IEnumerable<Observation.ComponentComponent> k_ = context.Operators.Where<Observation.ComponentComponent>(i_?.Component, j_);
			Observation.ComponentComponent l_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(k_);
			object m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			CqlQuantity n_ = context.Operators.Quantity(1m, "mm[Hg]");
			CqlQuantity o_ = context.Operators.Quantity(120m, "mm[Hg]");
			CqlInterval<CqlQuantity> p_ = context.Operators.Interval(n_, o_, true, false);
			bool? q_ = context.Operators.In<CqlQuantity>((m_ as CqlQuantity), p_, null);
			bool? s_(Observation BloodPressure)
			{
				object az_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_0_000.toInterval(az_);
				CqlDateTime bb_ = context.Operators.End(ba_);
				CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? bd_ = context.Operators.In<CqlDateTime>(bb_, bc_, null);
				string be_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] bf_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? bg_ = context.Operators.In<string>(be_, (bf_ as IEnumerable<string>));
				bool? bh_ = context.Operators.And(bd_, bg_);

				return bh_;
			};
			IEnumerable<Observation> t_ = context.Operators.Where<Observation>(d_, s_);
			object u_(Observation @this)
			{
				object bi_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> bj_ = QICoreCommon_2_0_000.toInterval(bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);

				return bk_;
			};
			IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			Observation w_ = context.Operators.Last<Observation>(v_);
			bool? x_(Observation.ComponentComponent @this)
			{
				Coding bl_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string bm_ = context.Operators.Convert<string>(bl_?.SystemElement);
				bool? bn_ = context.Operators.Equal(bm_, "http://loinc.org");
				string bp_ = context.Operators.Convert<string>(bl_?.CodeElement);
				bool? bq_ = context.Operators.Equal(bp_, "8462-4");
				bool? br_ = context.Operators.And(bn_, bq_);

				return br_;
			};
			IEnumerable<Observation.ComponentComponent> y_ = context.Operators.Where<Observation.ComponentComponent>(w_?.Component, x_);
			Observation.ComponentComponent z_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(y_);
			object aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Value);
			CqlQuantity ac_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlInterval<CqlQuantity> ad_ = context.Operators.Interval(n_, ac_, true, false);
			bool? ae_ = context.Operators.In<CqlQuantity>((aa_ as CqlQuantity), ad_, null);
			bool? af_ = context.Operators.And(q_, ae_);

			return af_;
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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				object ag_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_0_000.toInterval(ag_);
				CqlDateTime ai_ = context.Operators.End(ah_);
				CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? ak_ = context.Operators.In<CqlDateTime>(ai_, aj_, null);
				string al_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] am_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? an_ = context.Operators.In<string>(al_, (am_ as IEnumerable<string>));
				bool? ao_ = context.Operators.And(ak_, an_);

				return ao_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				object ap_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.toInterval(ap_);
				CqlDateTime ar_ = context.Operators.Start(aq_);

				return ar_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				Coding as_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string at_ = context.Operators.Convert<string>(as_?.SystemElement);
				bool? au_ = context.Operators.Equal(at_, "http://loinc.org");
				string aw_ = context.Operators.Convert<string>(as_?.CodeElement);
				bool? ax_ = context.Operators.Equal(aw_, "8480-6");
				bool? ay_ = context.Operators.And(au_, ax_);

				return ay_;
			};
			IEnumerable<Observation.ComponentComponent> k_ = context.Operators.Where<Observation.ComponentComponent>(i_?.Component, j_);
			Observation.ComponentComponent l_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(k_);
			object m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			CqlQuantity n_ = context.Operators.Quantity(120m, "mm[Hg]");
			CqlQuantity o_ = context.Operators.Quantity(129m, "mm[Hg]");
			CqlInterval<CqlQuantity> p_ = context.Operators.Interval(n_, o_, true, true);
			bool? q_ = context.Operators.In<CqlQuantity>((m_ as CqlQuantity), p_, null);
			bool? s_(Observation BloodPressure)
			{
				object az_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_0_000.toInterval(az_);
				CqlDateTime bb_ = context.Operators.End(ba_);
				CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? bd_ = context.Operators.In<CqlDateTime>(bb_, bc_, null);
				string be_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] bf_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? bg_ = context.Operators.In<string>(be_, (bf_ as IEnumerable<string>));
				bool? bh_ = context.Operators.And(bd_, bg_);

				return bh_;
			};
			IEnumerable<Observation> t_ = context.Operators.Where<Observation>(d_, s_);
			object u_(Observation @this)
			{
				object bi_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> bj_ = QICoreCommon_2_0_000.toInterval(bi_);
				CqlDateTime bk_ = context.Operators.Start(bj_);

				return bk_;
			};
			IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			Observation w_ = context.Operators.Last<Observation>(v_);
			bool? x_(Observation.ComponentComponent @this)
			{
				Coding bl_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string bm_ = context.Operators.Convert<string>(bl_?.SystemElement);
				bool? bn_ = context.Operators.Equal(bm_, "http://loinc.org");
				string bp_ = context.Operators.Convert<string>(bl_?.CodeElement);
				bool? bq_ = context.Operators.Equal(bp_, "8462-4");
				bool? br_ = context.Operators.And(bn_, bq_);

				return br_;
			};
			IEnumerable<Observation.ComponentComponent> y_ = context.Operators.Where<Observation.ComponentComponent>(w_?.Component, x_);
			Observation.ComponentComponent z_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(y_);
			object aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Value);
			CqlQuantity ab_ = context.Operators.Quantity(1m, "mm[Hg]");
			CqlQuantity ac_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlInterval<CqlQuantity> ad_ = context.Operators.Interval(ab_, ac_, true, false);
			bool? ae_ = context.Operators.In<CqlQuantity>((aa_ as CqlQuantity), ad_, null);
			bool? af_ = context.Operators.And(q_, ae_);

			return af_;
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
		IEnumerable<ServiceRequest> c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, null);
		CqlCode d_ = this.Follow_up_4_6_months__finding_();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, null);
		IEnumerable<ServiceRequest> g_ = context.Operators.ListUnion<ServiceRequest>(c_, f_);
		bool? h_(ServiceRequest FollowUp)
		{
			Code<RequestIntent> j_ = context.Operators.Convert<Code<RequestIntent>>(FollowUp?.IntentElement?.Value);
			bool? k_ = context.Operators.Equivalent(j_, "order");

			return k_;
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		CqlValueSet c_ = this.Weight_Reduction_Recommended();
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(c_, null);
		IEnumerable<ServiceRequest> e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Dietary_Recommendations();
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		CqlValueSet h_ = this.Recommendation_to_Increase_Physical_Activity();
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, null);
		IEnumerable<ServiceRequest> j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.ListUnion<ServiceRequest>(e_, j_);
		CqlValueSet l_ = this.Referral_or_Counseling_for_Alcohol_Consumption();
		IEnumerable<ServiceRequest> m_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, null);
		IEnumerable<ServiceRequest> n_ = context.Operators.ListUnion<ServiceRequest>(k_, m_);
		bool? o_(ServiceRequest NonPharmaInterventions)
		{
			Code<RequestIntent> q_ = context.Operators.Convert<Code<RequestIntent>>(NonPharmaInterventions?.IntentElement?.Value);
			bool? r_ = context.Operators.Equivalent(q_, "order");

			return r_;
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		bool? c_(ServiceRequest Referral)
		{
			CqlConcept e_(CodeableConcept @this)
			{
				CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return l_;
			};
			IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>(Referral?.ReasonCode, e_);
			CqlValueSet g_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension();
			bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
			Code<RequestIntent> i_ = context.Operators.Convert<Code<RequestIntent>>(Referral?.IntentElement?.Value);
			bool? j_ = context.Operators.Equivalent(i_, "order");
			bool? k_ = context.Operators.And(h_, j_);

			return k_;
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
				CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(Twoto6MonthRescreen?.AuthoredOnElement);
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(ElevatedEncounter?.Period);
				bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");

				return q_;
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
			IEnumerable<ServiceRequest> r_ = this.NonPharmacological_Interventions();
			bool? s_(ServiceRequest NonPharmInterventions)
			{
				CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(NonPharmInterventions?.AuthoredOnElement);
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(ElevatedEncounter?.Period);
				bool? y_ = context.Operators.In<CqlDateTime>(w_, x_, "day");

				return y_;
			};
			IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
			Encounter u_(ServiceRequest NonPharmInterventions) => 
				ElevatedEncounter;
			IEnumerable<Encounter> v_ = context.Operators.Select<ServiceRequest, Encounter>(t_, u_);

			return v_;
		};
		IEnumerable<Encounter> e_ = context.Operators.SelectMany<Encounter, Encounter>(c_, d_);
		IEnumerable<Encounter> g_(Encounter ElevatedEncounter)
		{
			IEnumerable<ServiceRequest> z_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? aa_(ServiceRequest Referral)
			{
				CqlDateTime ae_ = context.Operators.Convert<CqlDateTime>(Referral?.AuthoredOnElement);
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_3_000.ToInterval(ElevatedEncounter?.Period);
				bool? ag_ = context.Operators.In<CqlDateTime>(ae_, af_, "day");

				return ag_;
			};
			IEnumerable<ServiceRequest> ab_ = context.Operators.Where<ServiceRequest>(z_, aa_);
			Encounter ac_(ServiceRequest Referral) => 
				ElevatedEncounter;
			IEnumerable<Encounter> ad_ = context.Operators.Select<ServiceRequest, Encounter>(ab_, ac_);

			return ad_;
		};
		IEnumerable<Encounter> h_ = context.Operators.SelectMany<Encounter, Encounter>(a_, g_);
		IEnumerable<Encounter> i_ = context.Operators.ListUnion<Encounter>(e_, h_);

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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				object bc_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> bd_ = QICoreCommon_2_0_000.toInterval(bc_);
				CqlDateTime be_ = context.Operators.End(bd_);
				CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				CqlDateTime bg_ = context.Operators.Start(bf_);
				CqlQuantity bh_ = context.Operators.Quantity(1m, "year");
				CqlDateTime bi_ = context.Operators.Subtract(bg_, bh_);
				CqlDateTime bk_ = context.Operators.Start(bf_);
				CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bi_, bk_, true, true);
				bool? bm_ = context.Operators.In<CqlDateTime>(be_, bl_, null);
				CqlDateTime bo_ = context.Operators.Start(bf_);
				bool? bp_ = context.Operators.Not((bool?)(bo_ is null));
				bool? bq_ = context.Operators.And(bm_, bp_);
				string br_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] bs_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? bt_ = context.Operators.In<string>(br_, (bs_ as IEnumerable<string>));
				bool? bu_ = context.Operators.And(bq_, bt_);

				return bu_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				object bv_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> bw_ = QICoreCommon_2_0_000.toInterval(bv_);
				CqlDateTime bx_ = context.Operators.Start(bw_);

				return bx_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				Coding by_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string bz_ = context.Operators.Convert<string>(by_?.SystemElement);
				bool? ca_ = context.Operators.Equal(bz_, "http://loinc.org");
				string cc_ = context.Operators.Convert<string>(by_?.CodeElement);
				bool? cd_ = context.Operators.Equal(cc_, "8480-6");
				bool? ce_ = context.Operators.And(ca_, cd_);

				return ce_;
			};
			IEnumerable<Observation.ComponentComponent> k_ = context.Operators.Where<Observation.ComponentComponent>(i_?.Component, j_);
			Observation.ComponentComponent l_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(k_);
			object m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			CqlQuantity n_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? o_ = context.Operators.Greater((m_ as CqlQuantity), n_);
			bool? q_(Observation BloodPressure)
			{
				object cf_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> cg_ = QICoreCommon_2_0_000.toInterval(cf_);
				CqlDateTime ch_ = context.Operators.End(cg_);
				CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				CqlDateTime cj_ = context.Operators.Start(ci_);
				CqlQuantity ck_ = context.Operators.Quantity(1m, "year");
				CqlDateTime cl_ = context.Operators.Subtract(cj_, ck_);
				CqlDateTime cn_ = context.Operators.Start(ci_);
				CqlInterval<CqlDateTime> co_ = context.Operators.Interval(cl_, cn_, true, true);
				bool? cp_ = context.Operators.In<CqlDateTime>(ch_, co_, null);
				CqlDateTime cr_ = context.Operators.Start(ci_);
				bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
				bool? ct_ = context.Operators.And(cp_, cs_);
				string cu_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] cv_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? cw_ = context.Operators.In<string>(cu_, (cv_ as IEnumerable<string>));
				bool? cx_ = context.Operators.And(ct_, cw_);

				return cx_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(d_, q_);
			object s_(Observation @this)
			{
				object cy_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> cz_ = QICoreCommon_2_0_000.toInterval(cy_);
				CqlDateTime da_ = context.Operators.Start(cz_);

				return da_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.Last<Observation>(t_);
			bool? v_(Observation.ComponentComponent @this)
			{
				Coding db_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string dc_ = context.Operators.Convert<string>(db_?.SystemElement);
				bool? dd_ = context.Operators.Equal(dc_, "http://loinc.org");
				string df_ = context.Operators.Convert<string>(db_?.CodeElement);
				bool? dg_ = context.Operators.Equal(df_, "8462-4");
				bool? dh_ = context.Operators.And(dd_, dg_);

				return dh_;
			};
			IEnumerable<Observation.ComponentComponent> w_ = context.Operators.Where<Observation.ComponentComponent>(u_?.Component, v_);
			Observation.ComponentComponent x_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(w_);
			object y_ = FHIRHelpers_4_3_000.ToValue(x_?.Value);
			bool? aa_ = context.Operators.Greater((y_ as CqlQuantity), n_);
			bool? ab_ = context.Operators.And(o_, aa_);
			bool? ad_(Observation BloodPressure)
			{
				object di_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> dj_ = QICoreCommon_2_0_000.toInterval(di_);
				CqlDateTime dk_ = context.Operators.End(dj_);
				CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				CqlDateTime dm_ = context.Operators.Start(dl_);
				CqlQuantity dn_ = context.Operators.Quantity(1m, "year");
				CqlDateTime do_ = context.Operators.Subtract(dm_, dn_);
				CqlDateTime dq_ = context.Operators.Start(dl_);
				CqlInterval<CqlDateTime> dr_ = context.Operators.Interval(do_, dq_, true, true);
				bool? ds_ = context.Operators.In<CqlDateTime>(dk_, dr_, null);
				CqlDateTime du_ = context.Operators.Start(dl_);
				bool? dv_ = context.Operators.Not((bool?)(du_ is null));
				bool? dw_ = context.Operators.And(ds_, dv_);
				string dx_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] dy_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? dz_ = context.Operators.In<string>(dx_, (dy_ as IEnumerable<string>));
				bool? ea_ = context.Operators.And(dw_, dz_);

				return ea_;
			};
			IEnumerable<Observation> ae_ = context.Operators.Where<Observation>(d_, ad_);
			object af_(Observation @this)
			{
				object eb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> ec_ = QICoreCommon_2_0_000.toInterval(eb_);
				CqlDateTime ed_ = context.Operators.Start(ec_);

				return ed_;
			};
			IEnumerable<Observation> ag_ = context.Operators.SortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ah_ = context.Operators.Last<Observation>(ag_);
			bool? ai_(Observation.ComponentComponent @this)
			{
				Coding ee_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string ef_ = context.Operators.Convert<string>(ee_?.SystemElement);
				bool? eg_ = context.Operators.Equal(ef_, "http://loinc.org");
				string ei_ = context.Operators.Convert<string>(ee_?.CodeElement);
				bool? ej_ = context.Operators.Equal(ei_, "8480-6");
				bool? ek_ = context.Operators.And(eg_, ej_);

				return ek_;
			};
			IEnumerable<Observation.ComponentComponent> aj_ = context.Operators.Where<Observation.ComponentComponent>(ah_?.Component, ai_);
			Observation.ComponentComponent ak_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aj_);
			object al_ = FHIRHelpers_4_3_000.ToValue(ak_?.Value);
			CqlQuantity am_ = context.Operators.Quantity(130m, "mm[Hg]");
			bool? an_ = context.Operators.GreaterOrEqual((al_ as CqlQuantity), am_);
			bool? ap_(Observation BloodPressure)
			{
				object el_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> em_ = QICoreCommon_2_0_000.toInterval(el_);
				CqlDateTime en_ = context.Operators.End(em_);
				CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				CqlDateTime ep_ = context.Operators.Start(eo_);
				CqlQuantity eq_ = context.Operators.Quantity(1m, "year");
				CqlDateTime er_ = context.Operators.Subtract(ep_, eq_);
				CqlDateTime et_ = context.Operators.Start(eo_);
				CqlInterval<CqlDateTime> eu_ = context.Operators.Interval(er_, et_, true, true);
				bool? ev_ = context.Operators.In<CqlDateTime>(en_, eu_, null);
				CqlDateTime ex_ = context.Operators.Start(eo_);
				bool? ey_ = context.Operators.Not((bool?)(ex_ is null));
				bool? ez_ = context.Operators.And(ev_, ey_);
				string fa_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] fb_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? fc_ = context.Operators.In<string>(fa_, (fb_ as IEnumerable<string>));
				bool? fd_ = context.Operators.And(ez_, fc_);

				return fd_;
			};
			IEnumerable<Observation> aq_ = context.Operators.Where<Observation>(d_, ap_);
			object ar_(Observation @this)
			{
				object fe_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> ff_ = QICoreCommon_2_0_000.toInterval(fe_);
				CqlDateTime fg_ = context.Operators.Start(ff_);

				return fg_;
			};
			IEnumerable<Observation> as_ = context.Operators.SortBy<Observation>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
			Observation at_ = context.Operators.Last<Observation>(as_);
			bool? au_(Observation.ComponentComponent @this)
			{
				Coding fh_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string fi_ = context.Operators.Convert<string>(fh_?.SystemElement);
				bool? fj_ = context.Operators.Equal(fi_, "http://loinc.org");
				string fl_ = context.Operators.Convert<string>(fh_?.CodeElement);
				bool? fm_ = context.Operators.Equal(fl_, "8462-4");
				bool? fn_ = context.Operators.And(fj_, fm_);

				return fn_;
			};
			IEnumerable<Observation.ComponentComponent> av_ = context.Operators.Where<Observation.ComponentComponent>(at_?.Component, au_);
			Observation.ComponentComponent aw_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(av_);
			object ax_ = FHIRHelpers_4_3_000.ToValue(aw_?.Value);
			CqlQuantity ay_ = context.Operators.Quantity(80m, "mm[Hg]");
			bool? az_ = context.Operators.GreaterOrEqual((ax_ as CqlQuantity), ay_);
			bool? ba_ = context.Operators.Or(an_, az_);
			bool? bb_ = context.Operators.And(ab_, ba_);

			return bb_;
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
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? g_(Observation BloodPressure)
			{
				object be_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> bf_ = QICoreCommon_2_0_000.toInterval(be_);
				CqlDateTime bg_ = context.Operators.End(bf_);
				CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? bi_ = context.Operators.In<CqlDateTime>(bg_, bh_, "day");

				return bi_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				object bj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> bk_ = QICoreCommon_2_0_000.toInterval(bj_);
				CqlDateTime bl_ = context.Operators.Start(bk_);

				return bl_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.Last<Observation>(j_);
			bool? l_(Observation.ComponentComponent @this)
			{
				Coding bm_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string bn_ = context.Operators.Convert<string>(bm_?.SystemElement);
				bool? bo_ = context.Operators.Equal(bn_, "http://loinc.org");
				string bq_ = context.Operators.Convert<string>(bm_?.CodeElement);
				bool? br_ = context.Operators.Equal(bq_, "8480-6");
				bool? bs_ = context.Operators.And(bo_, br_);

				return bs_;
			};
			IEnumerable<Observation.ComponentComponent> m_ = context.Operators.Where<Observation.ComponentComponent>(k_?.Component, l_);
			Observation.ComponentComponent n_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(m_);
			object o_ = FHIRHelpers_4_3_000.ToValue(n_?.Value);
			CqlQuantity p_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? q_ = context.Operators.Greater((o_ as CqlQuantity), p_);
			bool? s_(Observation BloodPressure)
			{
				object bt_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> bu_ = QICoreCommon_2_0_000.toInterval(bt_);
				CqlDateTime bv_ = context.Operators.End(bu_);
				CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? bx_ = context.Operators.In<CqlDateTime>(bv_, bw_, "day");

				return bx_;
			};
			IEnumerable<Observation> t_ = context.Operators.Where<Observation>(f_, s_);
			object u_(Observation @this)
			{
				object by_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> bz_ = QICoreCommon_2_0_000.toInterval(by_);
				CqlDateTime ca_ = context.Operators.Start(bz_);

				return ca_;
			};
			IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			Observation w_ = context.Operators.Last<Observation>(v_);
			bool? x_(Observation.ComponentComponent @this)
			{
				Coding cb_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string cc_ = context.Operators.Convert<string>(cb_?.SystemElement);
				bool? cd_ = context.Operators.Equal(cc_, "http://loinc.org");
				string cf_ = context.Operators.Convert<string>(cb_?.CodeElement);
				bool? cg_ = context.Operators.Equal(cf_, "8462-4");
				bool? ch_ = context.Operators.And(cd_, cg_);

				return ch_;
			};
			IEnumerable<Observation.ComponentComponent> y_ = context.Operators.Where<Observation.ComponentComponent>(w_?.Component, x_);
			Observation.ComponentComponent z_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(y_);
			object aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Value);
			bool? ac_ = context.Operators.Greater((aa_ as CqlQuantity), p_);
			bool? ad_ = context.Operators.And(q_, ac_);
			bool? af_(Observation BloodPressure)
			{
				object ci_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> cj_ = QICoreCommon_2_0_000.toInterval(ci_);
				CqlDateTime ck_ = context.Operators.End(cj_);
				CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? cm_ = context.Operators.In<CqlDateTime>(ck_, cl_, "day");

				return cm_;
			};
			IEnumerable<Observation> ag_ = context.Operators.Where<Observation>(f_, af_);
			object ah_(Observation @this)
			{
				object cn_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> co_ = QICoreCommon_2_0_000.toInterval(cn_);
				CqlDateTime cp_ = context.Operators.Start(co_);

				return cp_;
			};
			IEnumerable<Observation> ai_ = context.Operators.SortBy<Observation>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
			Observation aj_ = context.Operators.Last<Observation>(ai_);
			bool? ak_(Observation.ComponentComponent @this)
			{
				Coding cq_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string cr_ = context.Operators.Convert<string>(cq_?.SystemElement);
				bool? cs_ = context.Operators.Equal(cr_, "http://loinc.org");
				string cu_ = context.Operators.Convert<string>(cq_?.CodeElement);
				bool? cv_ = context.Operators.Equal(cu_, "8480-6");
				bool? cw_ = context.Operators.And(cs_, cv_);

				return cw_;
			};
			IEnumerable<Observation.ComponentComponent> al_ = context.Operators.Where<Observation.ComponentComponent>(aj_?.Component, ak_);
			Observation.ComponentComponent am_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(al_);
			object an_ = FHIRHelpers_4_3_000.ToValue(am_?.Value);
			CqlQuantity ao_ = context.Operators.Quantity(130m, "mm[Hg]");
			bool? ap_ = context.Operators.GreaterOrEqual((an_ as CqlQuantity), ao_);
			bool? ar_(Observation BloodPressure)
			{
				object cx_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> cy_ = QICoreCommon_2_0_000.toInterval(cx_);
				CqlDateTime cz_ = context.Operators.End(cy_);
				CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? db_ = context.Operators.In<CqlDateTime>(cz_, da_, "day");

				return db_;
			};
			IEnumerable<Observation> as_ = context.Operators.Where<Observation>(f_, ar_);
			object at_(Observation @this)
			{
				object dc_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> dd_ = QICoreCommon_2_0_000.toInterval(dc_);
				CqlDateTime de_ = context.Operators.Start(dd_);

				return de_;
			};
			IEnumerable<Observation> au_ = context.Operators.SortBy<Observation>(as_, at_, System.ComponentModel.ListSortDirection.Ascending);
			Observation av_ = context.Operators.Last<Observation>(au_);
			bool? aw_(Observation.ComponentComponent @this)
			{
				Coding df_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string dg_ = context.Operators.Convert<string>(df_?.SystemElement);
				bool? dh_ = context.Operators.Equal(dg_, "http://loinc.org");
				string dj_ = context.Operators.Convert<string>(df_?.CodeElement);
				bool? dk_ = context.Operators.Equal(dj_, "8462-4");
				bool? dl_ = context.Operators.And(dh_, dk_);

				return dl_;
			};
			IEnumerable<Observation.ComponentComponent> ax_ = context.Operators.Where<Observation.ComponentComponent>(av_?.Component, aw_);
			Observation.ComponentComponent ay_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(ax_);
			object az_ = FHIRHelpers_4_3_000.ToValue(ay_?.Value);
			CqlQuantity ba_ = context.Operators.Quantity(80m, "mm[Hg]");
			bool? bb_ = context.Operators.GreaterOrEqual((az_ as CqlQuantity), ba_);
			bool? bc_ = context.Operators.Or(ap_, bb_);
			bool? bd_ = context.Operators.And(ad_, bc_);

			return bd_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
		IEnumerable<Encounter> e_ = context.Operators.ListExcept<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80")]
	public IEnumerable<Encounter> Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80() => 
		__Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80.Value;

	private IEnumerable<ServiceRequest> First_Hypertensive_Reading_Interventions_or_Referral_to_Alternate_Professional_Value()
	{
		CqlValueSet a_ = this.Follow_Up_Within_4_Weeks();
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> c_(ServiceRequest FourWeekRescreen)
		{
			IEnumerable<ServiceRequest> g_ = this.NonPharmacological_Interventions();
			bool? h_(ServiceRequest NonPharmInterventionsHTN)
			{
				CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(FourWeekRescreen?.AuthoredOnElement);
				CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
				bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
				CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(NonPharmInterventionsHTN?.AuthoredOnElement);
				bool? q_ = context.Operators.In<CqlDateTime>(o_, m_, "day");
				bool? r_ = context.Operators.And(n_, q_);
				Code<RequestIntent> s_ = context.Operators.Convert<Code<RequestIntent>>(FourWeekRescreen?.IntentElement?.Value);
				bool? t_ = context.Operators.Equivalent(s_, "order");
				bool? u_ = context.Operators.And(r_, t_);

				return u_;
			};
			IEnumerable<ServiceRequest> i_ = context.Operators.Where<ServiceRequest>(g_, h_);
			ServiceRequest j_(ServiceRequest NonPharmInterventionsHTN) => 
				FourWeekRescreen;
			IEnumerable<ServiceRequest> k_ = context.Operators.Select<ServiceRequest, ServiceRequest>(i_, j_);

			return k_;
		};
		IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
		IEnumerable<ServiceRequest> e_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
		IEnumerable<ServiceRequest> f_ = context.Operators.ListUnion<ServiceRequest>(d_, e_);

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
				CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(FirstHTNIntervention?.AuthoredOnElement);
				CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(FirstHTNEncounter?.Period);
				bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");

				return k_;
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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				object bk_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> bl_ = QICoreCommon_2_0_000.toInterval(bk_);
				CqlDateTime bm_ = context.Operators.End(bl_);
				CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? bo_ = context.Operators.In<CqlDateTime>(bm_, bn_, "day");
				string bp_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] bq_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? br_ = context.Operators.In<string>(bp_, (bq_ as IEnumerable<string>));
				bool? bs_ = context.Operators.And(bo_, br_);

				return bs_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				object bt_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> bu_ = QICoreCommon_2_0_000.toInterval(bt_);
				CqlDateTime bv_ = context.Operators.Start(bu_);

				return bv_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				Coding bw_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string bx_ = context.Operators.Convert<string>(bw_?.SystemElement);
				bool? by_ = context.Operators.Equal(bx_, "http://loinc.org");
				string ca_ = context.Operators.Convert<string>(bw_?.CodeElement);
				bool? cb_ = context.Operators.Equal(ca_, "8480-6");
				bool? cc_ = context.Operators.And(by_, cb_);

				return cc_;
			};
			IEnumerable<Observation.ComponentComponent> k_ = context.Operators.Where<Observation.ComponentComponent>(i_?.Component, j_);
			Observation.ComponentComponent l_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(k_);
			object m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			CqlQuantity n_ = context.Operators.Quantity(130m, "mm[Hg]");
			CqlQuantity o_ = context.Operators.Quantity(139m, "mm[Hg]");
			CqlInterval<CqlQuantity> p_ = context.Operators.Interval(n_, o_, true, true);
			bool? q_ = context.Operators.In<CqlQuantity>((m_ as CqlQuantity), p_, null);
			bool? s_(Observation BloodPressure)
			{
				object cd_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> ce_ = QICoreCommon_2_0_000.toInterval(cd_);
				CqlDateTime cf_ = context.Operators.End(ce_);
				CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? ch_ = context.Operators.In<CqlDateTime>(cf_, cg_, "day");
				string ci_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] cj_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? ck_ = context.Operators.In<string>(ci_, (cj_ as IEnumerable<string>));
				bool? cl_ = context.Operators.And(ch_, ck_);

				return cl_;
			};
			IEnumerable<Observation> t_ = context.Operators.Where<Observation>(d_, s_);
			object u_(Observation @this)
			{
				object cm_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> cn_ = QICoreCommon_2_0_000.toInterval(cm_);
				CqlDateTime co_ = context.Operators.Start(cn_);

				return co_;
			};
			IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			Observation w_ = context.Operators.Last<Observation>(v_);
			bool? x_(Observation.ComponentComponent @this)
			{
				Coding cp_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string cq_ = context.Operators.Convert<string>(cp_?.SystemElement);
				bool? cr_ = context.Operators.Equal(cq_, "http://loinc.org");
				string ct_ = context.Operators.Convert<string>(cp_?.CodeElement);
				bool? cu_ = context.Operators.Equal(ct_, "8462-4");
				bool? cv_ = context.Operators.And(cr_, cu_);

				return cv_;
			};
			IEnumerable<Observation.ComponentComponent> y_ = context.Operators.Where<Observation.ComponentComponent>(w_?.Component, x_);
			Observation.ComponentComponent z_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(y_);
			object aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Value);
			CqlQuantity ab_ = context.Operators.Quantity(80m, "mm[Hg]");
			CqlQuantity ac_ = context.Operators.Quantity(89m, "mm[Hg]");
			CqlInterval<CqlQuantity> ad_ = context.Operators.Interval(ab_, ac_, true, true);
			bool? ae_ = context.Operators.In<CqlQuantity>((aa_ as CqlQuantity), ad_, null);
			bool? af_ = context.Operators.Or(q_, ae_);
			bool? ah_(Observation BloodPressure)
			{
				object cw_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> cx_ = QICoreCommon_2_0_000.toInterval(cw_);
				CqlDateTime cy_ = context.Operators.End(cx_);
				CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? da_ = context.Operators.In<CqlDateTime>(cy_, cz_, "day");
				string db_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] dc_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? dd_ = context.Operators.In<string>(db_, (dc_ as IEnumerable<string>));
				bool? de_ = context.Operators.And(da_, dd_);

				return de_;
			};
			IEnumerable<Observation> ai_ = context.Operators.Where<Observation>(d_, ah_);
			object aj_(Observation @this)
			{
				object df_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> dg_ = QICoreCommon_2_0_000.toInterval(df_);
				CqlDateTime dh_ = context.Operators.Start(dg_);

				return dh_;
			};
			IEnumerable<Observation> ak_ = context.Operators.SortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
			Observation al_ = context.Operators.Last<Observation>(ak_);
			bool? am_(Observation.ComponentComponent @this)
			{
				Coding di_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string dj_ = context.Operators.Convert<string>(di_?.SystemElement);
				bool? dk_ = context.Operators.Equal(dj_, "http://loinc.org");
				string dm_ = context.Operators.Convert<string>(di_?.CodeElement);
				bool? dn_ = context.Operators.Equal(dm_, "8480-6");
				bool? do_ = context.Operators.And(dk_, dn_);

				return do_;
			};
			IEnumerable<Observation.ComponentComponent> an_ = context.Operators.Where<Observation.ComponentComponent>(al_?.Component, am_);
			Observation.ComponentComponent ao_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(an_);
			object ap_ = FHIRHelpers_4_3_000.ToValue(ao_?.Value);
			CqlQuantity aq_ = context.Operators.Quantity(140m, "mm[Hg]");
			bool? ar_ = context.Operators.GreaterOrEqual((ap_ as CqlQuantity), aq_);
			bool? at_(Observation BloodPressure)
			{
				object dp_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> dq_ = QICoreCommon_2_0_000.toInterval(dp_);
				CqlDateTime dr_ = context.Operators.End(dq_);
				CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? dt_ = context.Operators.In<CqlDateTime>(dr_, ds_, "day");
				string du_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] dv_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? dw_ = context.Operators.In<string>(du_, (dv_ as IEnumerable<string>));
				bool? dx_ = context.Operators.And(dt_, dw_);

				return dx_;
			};
			IEnumerable<Observation> au_ = context.Operators.Where<Observation>(d_, at_);
			object av_(Observation @this)
			{
				object dy_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> dz_ = QICoreCommon_2_0_000.toInterval(dy_);
				CqlDateTime ea_ = context.Operators.Start(dz_);

				return ea_;
			};
			IEnumerable<Observation> aw_ = context.Operators.SortBy<Observation>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ax_ = context.Operators.Last<Observation>(aw_);
			bool? ay_(Observation.ComponentComponent @this)
			{
				Coding eb_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string ec_ = context.Operators.Convert<string>(eb_?.SystemElement);
				bool? ed_ = context.Operators.Equal(ec_, "http://loinc.org");
				string ef_ = context.Operators.Convert<string>(eb_?.CodeElement);
				bool? eg_ = context.Operators.Equal(ef_, "8462-4");
				bool? eh_ = context.Operators.And(ed_, eg_);

				return eh_;
			};
			IEnumerable<Observation.ComponentComponent> az_ = context.Operators.Where<Observation.ComponentComponent>(ax_?.Component, ay_);
			Observation.ComponentComponent ba_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(az_);
			object bb_ = FHIRHelpers_4_3_000.ToValue(ba_?.Value);
			CqlQuantity bc_ = context.Operators.Quantity(90m, "mm[Hg]");
			bool? bd_ = context.Operators.GreaterOrEqual((bb_ as CqlQuantity), bc_);
			bool? be_ = context.Operators.Or(ar_, bd_);
			bool? bf_ = context.Operators.Not(be_);
			bool? bg_ = context.Operators.And(af_, bf_);
			IEnumerable<Encounter> bh_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			bool? bi_ = context.Operators.Exists<Encounter>(bh_);
			bool? bj_ = context.Operators.And(bg_, bi_);

			return bj_;
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
		IEnumerable<ServiceRequest> c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, null);
		CqlCode d_ = this.EKG_study();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, null);
		IEnumerable<ServiceRequest> g_ = context.Operators.ListUnion<ServiceRequest>(c_, f_);
		CqlValueSet h_ = this.Laboratory_Tests_for_Hypertension();
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, null);
		IEnumerable<ServiceRequest> j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		bool? k_(ServiceRequest EKGLab)
		{
			Code<RequestIntent> m_ = context.Operators.Convert<Code<RequestIntent>>(EKGLab?.IntentElement?.Value);
			bool? n_ = context.Operators.Equivalent(m_, "order");

			return n_;
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
				CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(Rescreen2to6?.AuthoredOnElement);
				CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
				bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(LabECGIntervention?.AuthoredOnElement);
				bool? p_ = context.Operators.In<CqlDateTime>(n_, l_, "day");
				bool? q_ = context.Operators.And(m_, p_);

				return q_;
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
			IEnumerable<ServiceRequest> r_ = this.NonPharmacological_Interventions();
			bool? s_(ServiceRequest NonPharmSecondIntervention)
			{
				CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(NonPharmSecondIntervention?.AuthoredOnElement);
				CqlInterval<CqlDateTime> x_ = this.Measurement_Period();
				bool? y_ = context.Operators.In<CqlDateTime>(w_, x_, "day");

				return y_;
			};
			IEnumerable<ServiceRequest> t_ = context.Operators.Where<ServiceRequest>(r_, s_);
			ServiceRequest u_(ServiceRequest NonPharmSecondIntervention) => 
				Rescreen2to6;
			IEnumerable<ServiceRequest> v_ = context.Operators.Select<ServiceRequest, ServiceRequest>(t_, u_);

			return v_;
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
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(EncounterInterventions?.AuthoredOnElement);
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounterReading?.Period);
				bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");

				return o_;
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
			IEnumerable<ServiceRequest> p_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? q_(ServiceRequest ReferralForHTN)
			{
				CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(ReferralForHTN?.AuthoredOnElement);
				CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounterReading?.Period);
				bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");

				return w_;
			};
			IEnumerable<ServiceRequest> r_ = context.Operators.Where<ServiceRequest>(p_, q_);
			Encounter s_(ServiceRequest ReferralForHTN) => 
				SecondHTNEncounterReading;
			IEnumerable<Encounter> t_ = context.Operators.Select<ServiceRequest, Encounter>(r_, s_);

			return t_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.ListUnion<Encounter>(c_, f_);

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
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BloodPressure)
			{
				object bf_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_0_000.toInterval(bf_);
				CqlDateTime bh_ = context.Operators.End(bg_);
				CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? bj_ = context.Operators.In<CqlDateTime>(bh_, bi_, null);
				string bk_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] bl_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? bm_ = context.Operators.In<string>(bk_, (bl_ as IEnumerable<string>));
				bool? bn_ = context.Operators.And(bj_, bm_);

				return bn_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				object bo_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> bp_ = QICoreCommon_2_0_000.toInterval(bo_);
				CqlDateTime bq_ = context.Operators.Start(bp_);

				return bq_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.Last<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				Coding br_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string bs_ = context.Operators.Convert<string>(br_?.SystemElement);
				bool? bt_ = context.Operators.Equal(bs_, "http://loinc.org");
				string bv_ = context.Operators.Convert<string>(br_?.CodeElement);
				bool? bw_ = context.Operators.Equal(bv_, "8480-6");
				bool? bx_ = context.Operators.And(bt_, bw_);

				return bx_;
			};
			IEnumerable<Observation.ComponentComponent> k_ = context.Operators.Where<Observation.ComponentComponent>(i_?.Component, j_);
			Observation.ComponentComponent l_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(k_);
			object m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			CqlQuantity n_ = context.Operators.Quantity(0m, "mm[Hg]");
			bool? o_ = context.Operators.Greater((m_ as CqlQuantity), n_);
			bool? q_(Observation BloodPressure)
			{
				object by_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> bz_ = QICoreCommon_2_0_000.toInterval(by_);
				CqlDateTime ca_ = context.Operators.End(bz_);
				CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? cc_ = context.Operators.In<CqlDateTime>(ca_, cb_, null);
				string cd_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] ce_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? cf_ = context.Operators.In<string>(cd_, (ce_ as IEnumerable<string>));
				bool? cg_ = context.Operators.And(cc_, cf_);

				return cg_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(d_, q_);
			object s_(Observation @this)
			{
				object ch_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> ci_ = QICoreCommon_2_0_000.toInterval(ch_);
				CqlDateTime cj_ = context.Operators.Start(ci_);

				return cj_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.Last<Observation>(t_);
			bool? v_(Observation.ComponentComponent @this)
			{
				Coding ck_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string cl_ = context.Operators.Convert<string>(ck_?.SystemElement);
				bool? cm_ = context.Operators.Equal(cl_, "http://loinc.org");
				string co_ = context.Operators.Convert<string>(ck_?.CodeElement);
				bool? cp_ = context.Operators.Equal(co_, "8462-4");
				bool? cq_ = context.Operators.And(cm_, cp_);

				return cq_;
			};
			IEnumerable<Observation.ComponentComponent> w_ = context.Operators.Where<Observation.ComponentComponent>(u_?.Component, v_);
			Observation.ComponentComponent x_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(w_);
			object y_ = FHIRHelpers_4_3_000.ToValue(x_?.Value);
			bool? aa_ = context.Operators.Greater((y_ as CqlQuantity), n_);
			bool? ab_ = context.Operators.And(o_, aa_);
			bool? ad_(Observation BloodPressure)
			{
				object cr_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> cs_ = QICoreCommon_2_0_000.toInterval(cr_);
				CqlDateTime ct_ = context.Operators.End(cs_);
				CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? cv_ = context.Operators.In<CqlDateTime>(ct_, cu_, null);
				string cw_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] cx_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? cy_ = context.Operators.In<string>(cw_, (cx_ as IEnumerable<string>));
				bool? cz_ = context.Operators.And(cv_, cy_);

				return cz_;
			};
			IEnumerable<Observation> ae_ = context.Operators.Where<Observation>(d_, ad_);
			object af_(Observation @this)
			{
				object da_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> db_ = QICoreCommon_2_0_000.toInterval(da_);
				CqlDateTime dc_ = context.Operators.Start(db_);

				return dc_;
			};
			IEnumerable<Observation> ag_ = context.Operators.SortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			Observation ah_ = context.Operators.Last<Observation>(ag_);
			bool? ai_(Observation.ComponentComponent @this)
			{
				Coding dd_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string de_ = context.Operators.Convert<string>(dd_?.SystemElement);
				bool? df_ = context.Operators.Equal(de_, "http://loinc.org");
				string dh_ = context.Operators.Convert<string>(dd_?.CodeElement);
				bool? di_ = context.Operators.Equal(dh_, "8480-6");
				bool? dj_ = context.Operators.And(df_, di_);

				return dj_;
			};
			IEnumerable<Observation.ComponentComponent> aj_ = context.Operators.Where<Observation.ComponentComponent>(ah_?.Component, ai_);
			Observation.ComponentComponent ak_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(aj_);
			object al_ = FHIRHelpers_4_3_000.ToValue(ak_?.Value);
			CqlQuantity am_ = context.Operators.Quantity(140m, "mm[Hg]");
			bool? an_ = context.Operators.GreaterOrEqual((al_ as CqlQuantity), am_);
			bool? ap_(Observation BloodPressure)
			{
				object dk_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				CqlInterval<CqlDateTime> dl_ = QICoreCommon_2_0_000.toInterval(dk_);
				CqlDateTime dm_ = context.Operators.End(dl_);
				CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? do_ = context.Operators.In<CqlDateTime>(dm_, dn_, null);
				string dp_ = context.Operators.Convert<string>(BloodPressure?.StatusElement?.Value);
				string[] dq_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? dr_ = context.Operators.In<string>(dp_, (dq_ as IEnumerable<string>));
				bool? ds_ = context.Operators.And(do_, dr_);

				return ds_;
			};
			IEnumerable<Observation> aq_ = context.Operators.Where<Observation>(d_, ap_);
			object ar_(Observation @this)
			{
				object dt_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlInterval<CqlDateTime> du_ = QICoreCommon_2_0_000.toInterval(dt_);
				CqlDateTime dv_ = context.Operators.Start(du_);

				return dv_;
			};
			IEnumerable<Observation> as_ = context.Operators.SortBy<Observation>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
			Observation at_ = context.Operators.Last<Observation>(as_);
			bool? au_(Observation.ComponentComponent @this)
			{
				Coding dw_ = context.Operators.First<Coding>((IEnumerable<Coding>)@this?.Code?.Coding);
				string dx_ = context.Operators.Convert<string>(dw_?.SystemElement);
				bool? dy_ = context.Operators.Equal(dx_, "http://loinc.org");
				string ea_ = context.Operators.Convert<string>(dw_?.CodeElement);
				bool? eb_ = context.Operators.Equal(ea_, "8462-4");
				bool? ec_ = context.Operators.And(dy_, eb_);

				return ec_;
			};
			IEnumerable<Observation.ComponentComponent> av_ = context.Operators.Where<Observation.ComponentComponent>(at_?.Component, au_);
			Observation.ComponentComponent aw_ = context.Operators.SingletonFrom<Observation.ComponentComponent>(av_);
			object ax_ = FHIRHelpers_4_3_000.ToValue(aw_?.Value);
			CqlQuantity ay_ = context.Operators.Quantity(90m, "mm[Hg]");
			bool? az_ = context.Operators.GreaterOrEqual((ax_ as CqlQuantity), ay_);
			bool? ba_ = context.Operators.Or(an_, az_);
			bool? bb_ = context.Operators.And(ab_, ba_);
			IEnumerable<Encounter> bc_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			bool? bd_ = context.Operators.Exists<Encounter>(bc_);
			bool? be_ = context.Operators.And(bb_, bd_);

			return be_;
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> c_(ServiceRequest WeeksRescreen)
		{
			IEnumerable<ServiceRequest> i_ = this.Laboratory_Test_or_ECG_for_Hypertension();
			bool? j_(ServiceRequest ECGLabTest)
			{
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(WeeksRescreen?.AuthoredOnElement);
				CqlInterval<CqlDateTime> o_ = this.Measurement_Period();
				bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
				CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(ECGLabTest?.AuthoredOnElement);
				bool? s_ = context.Operators.In<CqlDateTime>(q_, o_, "day");
				bool? t_ = context.Operators.And(p_, s_);
				Code<RequestIntent> u_ = context.Operators.Convert<Code<RequestIntent>>(WeeksRescreen?.IntentElement?.Value);
				bool? v_ = context.Operators.Equivalent(u_, "order");
				bool? w_ = context.Operators.And(t_, v_);
				Code<RequestIntent> x_ = context.Operators.Convert<Code<RequestIntent>>(ECGLabTest?.IntentElement?.Value);
				bool? y_ = context.Operators.Equivalent(x_, "order");
				bool? z_ = context.Operators.And(w_, y_);

				return z_;
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
			IEnumerable<ServiceRequest> aa_ = this.NonPharmacological_Interventions();
			bool? ab_(ServiceRequest HTNInterventions)
			{
				CqlDateTime af_ = context.Operators.Convert<CqlDateTime>(HTNInterventions?.AuthoredOnElement);
				CqlInterval<CqlDateTime> ag_ = this.Measurement_Period();
				bool? ah_ = context.Operators.In<CqlDateTime>(af_, ag_, "day");

				return ah_;
			};
			IEnumerable<ServiceRequest> ac_ = context.Operators.Where<ServiceRequest>(aa_, ab_);
			ServiceRequest ad_(ServiceRequest HTNInterventions) => 
				WeeksRescreen;
			IEnumerable<ServiceRequest> ae_ = context.Operators.Select<ServiceRequest, ServiceRequest>(ac_, ad_);

			return ae_;
		};
		IEnumerable<ServiceRequest> f_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(d_, e_);
		IEnumerable<ServiceRequest> g_(ServiceRequest WeeksRescreen)
		{
			CqlValueSet ai_ = this.Pharmacologic_Therapy_for_Hypertension();
			IEnumerable<MedicationRequest> aj_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ai_, null);
			IEnumerable<MedicationRequest> al_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ai_, null);
			IEnumerable<MedicationRequest> am_ = context.Operators.ListUnion<MedicationRequest>(aj_, al_);
			bool? an_(MedicationRequest Medications)
			{
				CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(Medications?.AuthoredOnElement);
				CqlInterval<CqlDateTime> as_ = this.Measurement_Period();
				bool? at_ = context.Operators.In<CqlDateTime>(ar_, as_, "day");
				bool? au_ = context.Operators.Equivalent(Medications?.StatusElement?.Value, "active");
				bool? av_ = context.Operators.And(at_, au_);

				return av_;
			};
			IEnumerable<MedicationRequest> ao_ = context.Operators.Where<MedicationRequest>(am_, an_);
			ServiceRequest ap_(MedicationRequest Medications) => 
				WeeksRescreen;
			IEnumerable<ServiceRequest> aq_ = context.Operators.Select<MedicationRequest, ServiceRequest>(ao_, ap_);

			return aq_;
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
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(SecondHTN140Over90Interventions?.AuthoredOnElement);
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounterReading140Over90?.Period);
				bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");

				return o_;
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
			IEnumerable<ServiceRequest> p_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? q_(ServiceRequest ReferralToProfessional)
			{
				CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(ReferralToProfessional?.AuthoredOnElement);
				CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounterReading140Over90?.Period);
				bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");

				return w_;
			};
			IEnumerable<ServiceRequest> r_ = context.Operators.Where<ServiceRequest>(p_, q_);
			Encounter s_(ServiceRequest ReferralToProfessional) => 
				SecondHTNEncounterReading140Over90;
			IEnumerable<Encounter> t_ = context.Operators.Select<ServiceRequest, Encounter>(r_, s_);

			return t_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.ListUnion<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions")]
	public IEnumerable<Encounter> Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions() => 
		__Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Normal_Blood_Pressure_Reading();
		IEnumerable<Encounter> b_ = this.Encounter_with_Elevated_Blood_Pressure_Reading_SBP_120_to_129_AND_DBP_less_than_80_and_Interventions();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80_and_Interventions();
		IEnumerable<Encounter> e_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_and_Interventions();
		IEnumerable<Encounter> f_ = context.Operators.ListUnion<Encounter>(d_, e_);
		IEnumerable<Encounter> g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		IEnumerable<Encounter> h_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_and_Interventions();
		IEnumerable<Encounter> i_ = context.Operators.ListUnion<Encounter>(g_, h_);

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
			IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			CqlCode g_ = this.Diastolic_blood_pressure();
			IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
			IEnumerable<Observation> i_ = context.Operators.RetrieveByCodes<Observation>(h_, null);
			IEnumerable<Observation> j_ = context.Operators.ListUnion<Observation>(f_, i_);
			bool? k_(Observation NoBPScreen)
			{
				CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(NoBPScreen?.IssuedElement?.Value);
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
				bool? r_(Extension @this)
				{
					bool? ao_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

					return ao_;
				};
				IEnumerable<Extension> s_ = context.Operators.Where<Extension>(((NoBPScreen is DomainResource)
						? ((NoBPScreen as DomainResource).Extension)
						: null), r_);
				DataType t_(Extension @this) => 
					@this?.Value;
				IEnumerable<DataType> u_ = context.Operators.Select<Extension, DataType>(s_, t_);
				DataType v_ = context.Operators.SingletonFrom<DataType>(u_);
				CodeableConcept w_ = context.Operators.Convert<CodeableConcept>(v_);
				CqlConcept x_ = FHIRHelpers_4_3_000.ToConcept(w_);
				CqlValueSet y_ = this.Patient_Declined();
				bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
				bool? aa_(Extension @this)
				{
					bool? ap_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

					return ap_;
				};
				IEnumerable<Extension> ab_ = context.Operators.Where<Extension>(((NoBPScreen is DomainResource)
						? ((NoBPScreen as DomainResource).Extension)
						: null), aa_);
				IEnumerable<DataType> ad_ = context.Operators.Select<Extension, DataType>(ab_, t_);
				DataType ae_ = context.Operators.SingletonFrom<DataType>(ad_);
				CodeableConcept af_ = context.Operators.Convert<CodeableConcept>(ae_);
				CqlConcept ag_ = FHIRHelpers_4_3_000.ToConcept(af_);
				CqlValueSet ah_ = this.Medical_Reason();
				bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
				bool? aj_ = context.Operators.Or(z_, ai_);
				bool? ak_ = context.Operators.And(q_, aj_);
				Code<ObservationStatus> al_ = context.Operators.Convert<Code<ObservationStatus>>(NoBPScreen?.StatusElement?.Value);
				bool? am_ = context.Operators.Equal(al_, "cancelled");
				bool? an_ = context.Operators.And(ak_, am_);

				return an_;
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Weight_Reduction_Recommended();
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		IEnumerable<ServiceRequest> j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.ListUnion<ServiceRequest>(e_, j_);
		CqlValueSet l_ = this.Dietary_Recommendations();
		IEnumerable<ServiceRequest> m_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, null);
		IEnumerable<ServiceRequest> o_ = context.Operators.RetrieveByValueSet<ServiceRequest>(l_, null);
		IEnumerable<ServiceRequest> p_ = context.Operators.ListUnion<ServiceRequest>(m_, o_);
		IEnumerable<ServiceRequest> q_ = context.Operators.ListUnion<ServiceRequest>(k_, p_);
		CqlValueSet r_ = this.Recommendation_to_Increase_Physical_Activity();
		IEnumerable<ServiceRequest> s_ = context.Operators.RetrieveByValueSet<ServiceRequest>(r_, null);
		IEnumerable<ServiceRequest> u_ = context.Operators.RetrieveByValueSet<ServiceRequest>(r_, null);
		IEnumerable<ServiceRequest> v_ = context.Operators.ListUnion<ServiceRequest>(s_, u_);
		IEnumerable<ServiceRequest> w_ = context.Operators.ListUnion<ServiceRequest>(q_, v_);
		CqlValueSet x_ = this.Referral_or_Counseling_for_Alcohol_Consumption();
		IEnumerable<ServiceRequest> y_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, null);
		IEnumerable<ServiceRequest> aa_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, null);
		IEnumerable<ServiceRequest> ab_ = context.Operators.ListUnion<ServiceRequest>(y_, aa_);
		IEnumerable<ServiceRequest> ac_ = context.Operators.ListUnion<ServiceRequest>(w_, ab_);
		bool? ad_(ServiceRequest NonPharmIntervention)
		{
			bool? af_(Extension @this)
			{
				bool? ar_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return ar_;
			};
			IEnumerable<Extension> ag_ = context.Operators.Where<Extension>(((NonPharmIntervention is DomainResource)
					? ((NonPharmIntervention as DomainResource).Extension)
					: null), af_);
			DataType ah_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> ai_ = context.Operators.Select<Extension, DataType>(ag_, ah_);
			DataType aj_ = context.Operators.SingletonFrom<DataType>(ai_);
			CodeableConcept ak_ = context.Operators.Convert<CodeableConcept>(aj_);
			CqlConcept al_ = FHIRHelpers_4_3_000.ToConcept(ak_);
			CqlValueSet am_ = this.Patient_Declined();
			bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
			Code<RequestStatus> ao_ = context.Operators.Convert<Code<RequestStatus>>(NonPharmIntervention?.StatusElement?.Value);
			bool? ap_ = context.Operators.Equal(ao_, "completed");
			bool? aq_ = context.Operators.And(an_, ap_);

			return aq_;
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
		IEnumerable<ServiceRequest> c_ = context.Operators.RetrieveByCodes<ServiceRequest>(b_, null);
		CqlCode d_ = this.EKG_study();
		IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
		IEnumerable<ServiceRequest> f_ = context.Operators.RetrieveByCodes<ServiceRequest>(e_, null);
		IEnumerable<ServiceRequest> g_ = context.Operators.ListUnion<ServiceRequest>(c_, f_);
		CqlValueSet h_ = this.Laboratory_Tests_for_Hypertension();
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, null);
		IEnumerable<ServiceRequest> k_ = context.Operators.RetrieveByValueSet<ServiceRequest>(h_, null);
		IEnumerable<ServiceRequest> l_ = context.Operators.ListUnion<ServiceRequest>(i_, k_);
		IEnumerable<ServiceRequest> m_ = context.Operators.ListUnion<ServiceRequest>(g_, l_);
		bool? n_(ServiceRequest LabECGNotDone)
		{
			bool? p_(Extension @this)
			{
				bool? y_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return y_;
			};
			IEnumerable<Extension> q_ = context.Operators.Where<Extension>(((LabECGNotDone is DomainResource)
					? ((LabECGNotDone as DomainResource).Extension)
					: null), p_);
			DataType r_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> s_ = context.Operators.Select<Extension, DataType>(q_, r_);
			DataType t_ = context.Operators.SingletonFrom<DataType>(s_);
			CodeableConcept u_ = context.Operators.Convert<CodeableConcept>(t_);
			CqlConcept v_ = FHIRHelpers_4_3_000.ToConcept(u_);
			CqlValueSet w_ = this.Patient_Declined();
			bool? x_ = context.Operators.ConceptInValueSet(v_, w_);

			return x_;
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		CqlCode f_ = this.Follow_up_2_3_months__finding_();
		IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
		IEnumerable<ServiceRequest> h_ = context.Operators.RetrieveByCodes<ServiceRequest>(g_, null);
		CqlCode i_ = this.Follow_up_4_6_months__finding_();
		IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.RetrieveByCodes<ServiceRequest>(j_, null);
		IEnumerable<ServiceRequest> l_ = context.Operators.ListUnion<ServiceRequest>(h_, k_);
		IEnumerable<ServiceRequest> m_ = context.Operators.ListUnion<ServiceRequest>(e_, l_);
		bool? n_(ServiceRequest SecondHTNDeclinedReferralAndFollowUp)
		{
			bool? t_(Extension @this)
			{
				bool? af_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return af_;
			};
			IEnumerable<Extension> u_ = context.Operators.Where<Extension>(((SecondHTNDeclinedReferralAndFollowUp is DomainResource)
					? ((SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension)
					: null), t_);
			DataType v_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> w_ = context.Operators.Select<Extension, DataType>(u_, v_);
			DataType x_ = context.Operators.SingletonFrom<DataType>(w_);
			CodeableConcept y_ = context.Operators.Convert<CodeableConcept>(x_);
			CqlConcept z_ = FHIRHelpers_4_3_000.ToConcept(y_);
			CqlValueSet aa_ = this.Patient_Declined();
			bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
			Code<RequestStatus> ac_ = context.Operators.Convert<Code<RequestStatus>>(SecondHTNDeclinedReferralAndFollowUp?.StatusElement?.Value);
			bool? ad_ = context.Operators.Equal(ac_, "completed");
			bool? ae_ = context.Operators.And(ab_, ad_);

			return ae_;
		};
		IEnumerable<ServiceRequest> o_ = context.Operators.Where<ServiceRequest>(m_, n_);
		IEnumerable<ServiceRequest> p_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered();
		IEnumerable<ServiceRequest> q_ = context.Operators.ListUnion<ServiceRequest>(o_, p_);
		IEnumerable<ServiceRequest> r_ = this.NonPharmacological_Intervention_Not_Ordered();
		IEnumerable<ServiceRequest> s_ = context.Operators.ListUnion<ServiceRequest>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined")]
	public IEnumerable<ServiceRequest> Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined() => 
		__Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined.Value;

	private IEnumerable<object> Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined_Value()
	{
		CqlValueSet a_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> e_ = context.Operators.ListUnion<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Follow_Up_Within_4_Weeks();
		IEnumerable<ServiceRequest> g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		IEnumerable<ServiceRequest> i_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		IEnumerable<ServiceRequest> j_ = context.Operators.ListUnion<ServiceRequest>(g_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.ListUnion<ServiceRequest>(e_, j_);
		bool? l_(ServiceRequest SecondHTN140Over90ReferralFollowUpNotDone)
		{
			bool? z_(Extension @this)
			{
				bool? al_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return al_;
			};
			IEnumerable<Extension> aa_ = context.Operators.Where<Extension>(((SecondHTN140Over90ReferralFollowUpNotDone is DomainResource)
					? ((SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension)
					: null), z_);
			DataType ab_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> ac_ = context.Operators.Select<Extension, DataType>(aa_, ab_);
			DataType ad_ = context.Operators.SingletonFrom<DataType>(ac_);
			CodeableConcept ae_ = context.Operators.Convert<CodeableConcept>(ad_);
			CqlConcept af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			CqlValueSet ag_ = this.Patient_Declined();
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			Code<RequestStatus> ai_ = context.Operators.Convert<Code<RequestStatus>>(SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement?.Value);
			bool? aj_ = context.Operators.Equal(ai_, "completed");
			bool? ak_ = context.Operators.And(ah_, aj_);

			return ak_;
		};
		IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);
		CqlValueSet n_ = this.Pharmacologic_Therapy_for_Hypertension();
		IEnumerable<MedicationRequest> o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		IEnumerable<MedicationRequest> q_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		IEnumerable<MedicationRequest> r_ = context.Operators.ListUnion<MedicationRequest>(o_, q_);
		bool? s_(MedicationRequest MedicationRequestNotOrdered)
		{
			bool? am_ = context.Operators.Equal(MedicationRequestNotOrdered?.StatusElement?.Value, "completed");

			return am_;
		};
		IEnumerable<MedicationRequest> t_ = context.Operators.Where<MedicationRequest>(r_, s_);
		IEnumerable<object> u_ = context.Operators.ListUnion<object>((m_ as IEnumerable<object>), (t_ as IEnumerable<object>));
		IEnumerable<ServiceRequest> v_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered();
		IEnumerable<object> w_ = context.Operators.ListUnion<object>(u_, (v_ as IEnumerable<object>));
		IEnumerable<ServiceRequest> x_ = this.NonPharmacological_Intervention_Not_Ordered();
		IEnumerable<object> y_ = context.Operators.ListUnion<object>(w_, (x_ as IEnumerable<object>));

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
			IEnumerable<ServiceRequest> y_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, null);
			IEnumerable<ServiceRequest> aa_ = context.Operators.RetrieveByValueSet<ServiceRequest>(x_, null);
			IEnumerable<ServiceRequest> ab_ = context.Operators.ListUnion<ServiceRequest>(y_, aa_);
			CqlCode ac_ = this.Follow_up_2_3_months__finding_();
			IEnumerable<CqlCode> ad_ = context.Operators.ToList<CqlCode>(ac_);
			IEnumerable<ServiceRequest> ae_ = context.Operators.RetrieveByCodes<ServiceRequest>(ad_, null);
			CqlCode af_ = this.Follow_up_4_6_months__finding_();
			IEnumerable<CqlCode> ag_ = context.Operators.ToList<CqlCode>(af_);
			IEnumerable<ServiceRequest> ah_ = context.Operators.RetrieveByCodes<ServiceRequest>(ag_, null);
			IEnumerable<ServiceRequest> ai_ = context.Operators.ListUnion<ServiceRequest>(ae_, ah_);
			IEnumerable<ServiceRequest> aj_ = context.Operators.ListUnion<ServiceRequest>(ab_, ai_);
			bool? ak_(ServiceRequest ElevatedBPDeclinedInterventions)
			{
				bool? ao_(Extension @this)
				{
					bool? be_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

					return be_;
				};
				IEnumerable<Extension> ap_ = context.Operators.Where<Extension>(((ElevatedBPDeclinedInterventions is DomainResource)
						? ((ElevatedBPDeclinedInterventions as DomainResource).Extension)
						: null), ao_);
				DataType aq_(Extension @this) => 
					@this?.Value;
				IEnumerable<DataType> ar_ = context.Operators.Select<Extension, DataType>(ap_, aq_);
				DataType as_ = context.Operators.SingletonFrom<DataType>(ar_);
				CodeableConcept at_ = context.Operators.Convert<CodeableConcept>(as_);
				CqlConcept au_ = FHIRHelpers_4_3_000.ToConcept(at_);
				CqlValueSet av_ = this.Patient_Declined();
				bool? aw_ = context.Operators.ConceptInValueSet(au_, av_);
				CqlDateTime ax_ = context.Operators.Convert<CqlDateTime>(ElevatedBPDeclinedInterventions?.AuthoredOnElement);
				CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_3_000.ToInterval(ElevatedBPEncounter?.Period);
				bool? az_ = context.Operators.In<CqlDateTime>(ax_, ay_, "day");
				bool? ba_ = context.Operators.And(aw_, az_);
				Code<RequestStatus> bb_ = context.Operators.Convert<Code<RequestStatus>>(ElevatedBPDeclinedInterventions?.StatusElement?.Value);
				bool? bc_ = context.Operators.Equal(bb_, "completed");
				bool? bd_ = context.Operators.And(ba_, bc_);

				return bd_;
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
			IEnumerable<ServiceRequest> bf_ = this.NonPharmacological_Intervention_Not_Ordered();
			bool? bg_(ServiceRequest NotOrdered)
			{
				CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(NotOrdered?.AuthoredOnElement);
				CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_3_000.ToInterval(ElevatedBPEncounter?.Period);
				bool? bm_ = context.Operators.In<CqlDateTime>(bk_, bl_, "day");

				return bm_;
			};
			IEnumerable<ServiceRequest> bh_ = context.Operators.Where<ServiceRequest>(bf_, bg_);
			Encounter bi_(ServiceRequest NotOrdered) => 
				ElevatedBPEncounter;
			IEnumerable<Encounter> bj_ = context.Operators.Select<ServiceRequest, Encounter>(bh_, bi_);

			return bj_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		IEnumerable<Encounter> h_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80();
		IEnumerable<Encounter> i_(Encounter FirstHTNEncounter)
		{
			CqlValueSet bn_ = this.Follow_Up_Within_4_Weeks();
			IEnumerable<ServiceRequest> bo_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bn_, null);
			IEnumerable<ServiceRequest> bq_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bn_, null);
			IEnumerable<ServiceRequest> br_ = context.Operators.ListUnion<ServiceRequest>(bo_, bq_);
			CqlValueSet bs_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
			IEnumerable<ServiceRequest> bt_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bs_, null);
			IEnumerable<ServiceRequest> bv_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bs_, null);
			IEnumerable<ServiceRequest> bw_ = context.Operators.ListUnion<ServiceRequest>(bt_, bv_);
			IEnumerable<ServiceRequest> bx_ = context.Operators.ListUnion<ServiceRequest>(br_, bw_);
			bool? by_(ServiceRequest FirstHTNDeclinedInterventions)
			{
				bool? cc_(Extension @this)
				{
					bool? cs_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

					return cs_;
				};
				IEnumerable<Extension> cd_ = context.Operators.Where<Extension>(((FirstHTNDeclinedInterventions is DomainResource)
						? ((FirstHTNDeclinedInterventions as DomainResource).Extension)
						: null), cc_);
				DataType ce_(Extension @this) => 
					@this?.Value;
				IEnumerable<DataType> cf_ = context.Operators.Select<Extension, DataType>(cd_, ce_);
				DataType cg_ = context.Operators.SingletonFrom<DataType>(cf_);
				CodeableConcept ch_ = context.Operators.Convert<CodeableConcept>(cg_);
				CqlConcept ci_ = FHIRHelpers_4_3_000.ToConcept(ch_);
				CqlValueSet cj_ = this.Patient_Declined();
				bool? ck_ = context.Operators.ConceptInValueSet(ci_, cj_);
				CqlDateTime cl_ = context.Operators.Convert<CqlDateTime>(FirstHTNDeclinedInterventions?.AuthoredOnElement);
				CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_3_000.ToInterval(FirstHTNEncounter?.Period);
				bool? cn_ = context.Operators.In<CqlDateTime>(cl_, cm_, "day");
				bool? co_ = context.Operators.And(ck_, cn_);
				Code<RequestStatus> cp_ = context.Operators.Convert<Code<RequestStatus>>(FirstHTNDeclinedInterventions?.StatusElement?.Value);
				bool? cq_ = context.Operators.Equal(cp_, "completed");
				bool? cr_ = context.Operators.And(co_, cq_);

				return cr_;
			};
			IEnumerable<ServiceRequest> bz_ = context.Operators.Where<ServiceRequest>(bx_, by_);
			Encounter ca_(ServiceRequest FirstHTNDeclinedInterventions) => 
				FirstHTNEncounter;
			IEnumerable<Encounter> cb_ = context.Operators.Select<ServiceRequest, Encounter>(bz_, ca_);

			return cb_;
		};
		IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(h_, i_);
		IEnumerable<Encounter> l_(Encounter FirstHTNEncounter)
		{
			IEnumerable<ServiceRequest> ct_ = this.NonPharmacological_Intervention_Not_Ordered();
			bool? cu_(ServiceRequest NoNonPharm)
			{
				CqlDateTime cy_ = context.Operators.Convert<CqlDateTime>(NoNonPharm?.AuthoredOnElement);
				CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_3_000.ToInterval(FirstHTNEncounter?.Period);
				bool? da_ = context.Operators.In<CqlDateTime>(cy_, cz_, "day");

				return da_;
			};
			IEnumerable<ServiceRequest> cv_ = context.Operators.Where<ServiceRequest>(ct_, cu_);
			Encounter cw_(ServiceRequest NoNonPharm) => 
				FirstHTNEncounter;
			IEnumerable<Encounter> cx_ = context.Operators.Select<ServiceRequest, Encounter>(cv_, cw_);

			return cx_;
		};
		IEnumerable<Encounter> m_ = context.Operators.SelectMany<Encounter, Encounter>(h_, l_);
		IEnumerable<Encounter> n_ = context.Operators.ListUnion<Encounter>(j_, m_);
		IEnumerable<Encounter> o_ = context.Operators.ListUnion<Encounter>(g_, n_);
		IEnumerable<Encounter> p_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89();
		IEnumerable<Encounter> q_(Encounter SecondHTNEncounter)
		{
			IEnumerable<ServiceRequest> db_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined();
			bool? dc_(ServiceRequest SecondHTNDeclinedInterventions)
			{
				CqlDateTime dg_ = context.Operators.Convert<CqlDateTime>(SecondHTNDeclinedInterventions?.AuthoredOnElement);
				CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounter?.Period);
				bool? di_ = context.Operators.In<CqlDateTime>(dg_, dh_, "day");

				return di_;
			};
			IEnumerable<ServiceRequest> dd_ = context.Operators.Where<ServiceRequest>(db_, dc_);
			Encounter de_(ServiceRequest SecondHTNDeclinedInterventions) => 
				SecondHTNEncounter;
			IEnumerable<Encounter> df_ = context.Operators.Select<ServiceRequest, Encounter>(dd_, de_);

			return df_;
		};
		IEnumerable<Encounter> r_ = context.Operators.SelectMany<Encounter, Encounter>(p_, q_);
		IEnumerable<Encounter> s_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90();
		IEnumerable<Encounter> t_(Encounter SecondHTN140Over90Encounter)
		{
			IEnumerable<object> dj_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined();
			bool? dk_(object SecondHTN140Over90DeclinedInterventions)
			{
				object do_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
				CqlDateTime dp_ = context.Operators.LateBoundProperty<CqlDateTime>(do_, "value");
				CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_3_000.ToInterval(SecondHTN140Over90Encounter?.Period);
				bool? dr_ = context.Operators.In<CqlDateTime>(dp_, dq_, "day");

				return dr_;
			};
			IEnumerable<object> dl_ = context.Operators.Where<object>(dj_, dk_);
			Encounter dm_(object SecondHTN140Over90DeclinedInterventions) => 
				SecondHTN140Over90Encounter;
			IEnumerable<Encounter> dn_ = context.Operators.Select<object, Encounter>(dl_, dm_);

			return dn_;
		};
		IEnumerable<Encounter> u_ = context.Operators.SelectMany<Encounter, Encounter>(s_, t_);
		IEnumerable<Encounter> v_ = context.Operators.ListUnion<Encounter>(r_, u_);
		IEnumerable<Encounter> w_ = context.Operators.ListUnion<Encounter>(o_, v_);

		return w_;
	}

    [CqlDeclaration("Encounter with Order for Hypertension Follow Up Declined by Patient")]
	public IEnumerable<Encounter> Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient() => 
		__Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Medical_Reason_for_Not_Obtaining_or_Patient_Declined_Blood_Pressure_Measurement();
		IEnumerable<Encounter> b_ = this.Encounter_with_Order_for_Hypertension_Follow_Up_Declined_by_Patient();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
