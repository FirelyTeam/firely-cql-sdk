using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
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
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("PCSBPScreeningFollowUpFHIR-0.2.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
			var f_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var g_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, f_, "day");
			var h_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ValidEncounter?.StatusElement?.Value);
			var i_ = context.Operators.Equivalent(h_, "finished");
			var j_ = context.Operators.And(g_, i_);
			var k_ = FHIRHelpers_4_3_000.ToCode(ValidEncounter?.Class);
			var l_ = this.@virtual();
			var m_ = context.Operators.Equivalent(k_, l_);
			var n_ = context.Operators.Not(m_);
			var o_ = context.Operators.And(j_, n_);

			return o_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

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
			var e_ = context.Operators.ConvertStringToDateTime(d_?.BirthDateElement?.Value);
			var f_ = this.Measurement_Period();
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.CalculateAgeAt(e_, g_, "year");
			var i_ = context.Operators.GreaterOrEqual(h_, (int?)18);

			return i_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

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
					if ((context.Operators.Start(QICoreCommon_2_0_000.prevalenceInterval(Hypertension)) is null))
					{
						return null;
					}
					else
					{
						var s_ = QICoreCommon_2_0_000.prevalenceInterval(Hypertension);
						var t_ = context.Operators.Start(s_);
						var v_ = context.Operators.Start(s_);
						var w_ = context.Operators.Interval(t_, v_, true, true);

						return w_;
					};
				};
				var p_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var q_ = context.Operators.IntervalSameOrBefore(o_(), p_, "day");
				var r_ = context.Operators.And(n_, q_);

				return r_;
			};
			var g_ = context.Operators.WhereOrNull<Condition>(e_, f_);
			Encounter h_(Condition Hypertension) => 
				QualifyingEncounter;
			var i_ = context.Operators.SelectOrNull<Condition, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

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
				var ag_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var ah_ = QICoreCommon_2_0_000.toInterval(ag_);
				var ai_ = context.Operators.End(ah_);
				var aj_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var ak_ = context.Operators.ElementInInterval<CqlDateTime>(ai_, aj_, null);
				var al_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var am_ = context.Operators.Convert<string>(al_);
				var an_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ao_ = context.Operators.InList<string>(am_, (an_ as IEnumerable<string>));
				var ap_ = context.Operators.And(ak_, ao_);

				return ap_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var aq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ar_ = QICoreCommon_2_0_000.toInterval(aq_);
				var as_ = context.Operators.Start(ar_);

				return as_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.LastOfList<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				var at_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var au_ = context.Operators.Convert<string>(at_?.SystemElement);
				var av_ = context.Operators.Equal(au_, "http://loinc.org");
				var ax_ = context.Operators.Convert<string>(at_?.CodeElement);
				var ay_ = context.Operators.Equal(ax_, "8480-6");
				var az_ = context.Operators.And(av_, ay_);

				return az_;
			};
			var k_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(i_?.Component, j_);
			var l_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(k_);
			var m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			var n_ = context.Operators.Quantity(1m, "mm[Hg]");
			var o_ = context.Operators.Quantity(120m, "mm[Hg]");
			var p_ = context.Operators.Interval(n_, o_, true, false);
			var q_ = context.Operators.ElementInInterval<CqlQuantity>((m_ as CqlQuantity), p_, null);
			bool? s_(Observation BloodPressure)
			{
				var ba_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var bb_ = QICoreCommon_2_0_000.toInterval(ba_);
				var bc_ = context.Operators.End(bb_);
				var bd_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var be_ = context.Operators.ElementInInterval<CqlDateTime>(bc_, bd_, null);
				var bf_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var bg_ = context.Operators.Convert<string>(bf_);
				var bh_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bi_ = context.Operators.InList<string>(bg_, (bh_ as IEnumerable<string>));
				var bj_ = context.Operators.And(be_, bi_);

				return bj_;
			};
			var t_ = context.Operators.WhereOrNull<Observation>(d_, s_);
			object u_(Observation @this)
			{
				var bk_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bl_ = QICoreCommon_2_0_000.toInterval(bk_);
				var bm_ = context.Operators.Start(bl_);

				return bm_;
			};
			var v_ = context.Operators.ListSortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			var w_ = context.Operators.LastOfList<Observation>(v_);
			bool? x_(Observation.ComponentComponent @this)
			{
				var bn_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var bo_ = context.Operators.Convert<string>(bn_?.SystemElement);
				var bp_ = context.Operators.Equal(bo_, "http://loinc.org");
				var br_ = context.Operators.Convert<string>(bn_?.CodeElement);
				var bs_ = context.Operators.Equal(br_, "8462-4");
				var bt_ = context.Operators.And(bp_, bs_);

				return bt_;
			};
			var y_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(w_?.Component, x_);
			var z_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(y_);
			var aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Value);
			var ac_ = context.Operators.Quantity(80m, "mm[Hg]");
			var ad_ = context.Operators.Interval(n_, ac_, true, false);
			var ae_ = context.Operators.ElementInInterval<CqlQuantity>((aa_ as CqlQuantity), ad_, null);
			var af_ = context.Operators.And(q_, ae_);

			return af_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

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
				var ag_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var ah_ = QICoreCommon_2_0_000.toInterval(ag_);
				var ai_ = context.Operators.End(ah_);
				var aj_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var ak_ = context.Operators.ElementInInterval<CqlDateTime>(ai_, aj_, null);
				var al_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var am_ = context.Operators.Convert<string>(al_);
				var an_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ao_ = context.Operators.InList<string>(am_, (an_ as IEnumerable<string>));
				var ap_ = context.Operators.And(ak_, ao_);

				return ap_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var aq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ar_ = QICoreCommon_2_0_000.toInterval(aq_);
				var as_ = context.Operators.Start(ar_);

				return as_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.LastOfList<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				var at_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var au_ = context.Operators.Convert<string>(at_?.SystemElement);
				var av_ = context.Operators.Equal(au_, "http://loinc.org");
				var ax_ = context.Operators.Convert<string>(at_?.CodeElement);
				var ay_ = context.Operators.Equal(ax_, "8480-6");
				var az_ = context.Operators.And(av_, ay_);

				return az_;
			};
			var k_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(i_?.Component, j_);
			var l_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(k_);
			var m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			var n_ = context.Operators.Quantity(120m, "mm[Hg]");
			var o_ = context.Operators.Quantity(129m, "mm[Hg]");
			var p_ = context.Operators.Interval(n_, o_, true, true);
			var q_ = context.Operators.ElementInInterval<CqlQuantity>((m_ as CqlQuantity), p_, null);
			bool? s_(Observation BloodPressure)
			{
				var ba_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var bb_ = QICoreCommon_2_0_000.toInterval(ba_);
				var bc_ = context.Operators.End(bb_);
				var bd_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var be_ = context.Operators.ElementInInterval<CqlDateTime>(bc_, bd_, null);
				var bf_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var bg_ = context.Operators.Convert<string>(bf_);
				var bh_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bi_ = context.Operators.InList<string>(bg_, (bh_ as IEnumerable<string>));
				var bj_ = context.Operators.And(be_, bi_);

				return bj_;
			};
			var t_ = context.Operators.WhereOrNull<Observation>(d_, s_);
			object u_(Observation @this)
			{
				var bk_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bl_ = QICoreCommon_2_0_000.toInterval(bk_);
				var bm_ = context.Operators.Start(bl_);

				return bm_;
			};
			var v_ = context.Operators.ListSortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			var w_ = context.Operators.LastOfList<Observation>(v_);
			bool? x_(Observation.ComponentComponent @this)
			{
				var bn_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var bo_ = context.Operators.Convert<string>(bn_?.SystemElement);
				var bp_ = context.Operators.Equal(bo_, "http://loinc.org");
				var br_ = context.Operators.Convert<string>(bn_?.CodeElement);
				var bs_ = context.Operators.Equal(br_, "8462-4");
				var bt_ = context.Operators.And(bp_, bs_);

				return bt_;
			};
			var y_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(w_?.Component, x_);
			var z_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(y_);
			var aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Value);
			var ab_ = context.Operators.Quantity(1m, "mm[Hg]");
			var ac_ = context.Operators.Quantity(80m, "mm[Hg]");
			var ad_ = context.Operators.Interval(ab_, ac_, true, false);
			var ae_ = context.Operators.ElementInInterval<CqlQuantity>((aa_ as CqlQuantity), ad_, null);
			var af_ = context.Operators.And(q_, ae_);

			return af_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

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
			var j_ = context.Operators.Convert<Code<RequestIntent>>(FollowUp?.IntentElement?.Value);
			var k_ = context.Operators.Equivalent(j_, "order");

			return k_;
		};
		var i_ = context.Operators.WhereOrNull<ServiceRequest>(g_, h_);

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
			var q_ = context.Operators.Convert<Code<RequestIntent>>(NonPharmaInterventions?.IntentElement?.Value);
			var r_ = context.Operators.Equivalent(q_, "order");

			return r_;
		};
		var p_ = context.Operators.WhereOrNull<ServiceRequest>(n_, o_);

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
			CqlConcept e_(CodeableConcept @this)
			{
				var l_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return l_;
			};
			var f_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(Referral?.ReasonCode, e_);
			var g_ = this.Finding_of_Elevated_Blood_Pressure_or_Hypertension();
			var h_ = context.Operators.ConceptsInValueSet(f_, g_);
			var i_ = context.Operators.Convert<Code<RequestIntent>>(Referral?.IntentElement?.Value);
			var j_ = context.Operators.Equivalent(i_, "order");
			var k_ = context.Operators.And(h_, j_);

			return k_;
		};
		var d_ = context.Operators.WhereOrNull<ServiceRequest>(b_, c_);

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
				var o_ = context.Operators.Convert<CqlDateTime>(Twoto6MonthRescreen?.AuthoredOnElement);
				var p_ = FHIRHelpers_4_3_000.ToInterval(ElevatedEncounter?.Period);
				var q_ = context.Operators.ElementInInterval<CqlDateTime>(o_, p_, "day");

				return q_;
			};
			var l_ = context.Operators.WhereOrNull<ServiceRequest>(j_, k_);
			Encounter m_(ServiceRequest Twoto6MonthRescreen) => 
				ElevatedEncounter;
			var n_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(l_, m_);

			return n_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> d_(Encounter ElevatedEncounter)
		{
			var r_ = this.NonPharmacological_Interventions();
			bool? s_(ServiceRequest NonPharmInterventions)
			{
				var w_ = context.Operators.Convert<CqlDateTime>(NonPharmInterventions?.AuthoredOnElement);
				var x_ = FHIRHelpers_4_3_000.ToInterval(ElevatedEncounter?.Period);
				var y_ = context.Operators.ElementInInterval<CqlDateTime>(w_, x_, "day");

				return y_;
			};
			var t_ = context.Operators.WhereOrNull<ServiceRequest>(r_, s_);
			Encounter u_(ServiceRequest NonPharmInterventions) => 
				ElevatedEncounter;
			var v_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(t_, u_);

			return v_;
		};
		var e_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(c_, d_);
		IEnumerable<Encounter> g_(Encounter ElevatedEncounter)
		{
			var z_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? aa_(ServiceRequest Referral)
			{
				var ae_ = context.Operators.Convert<CqlDateTime>(Referral?.AuthoredOnElement);
				var af_ = FHIRHelpers_4_3_000.ToInterval(ElevatedEncounter?.Period);
				var ag_ = context.Operators.ElementInInterval<CqlDateTime>(ae_, af_, "day");

				return ag_;
			};
			var ab_ = context.Operators.WhereOrNull<ServiceRequest>(z_, aa_);
			Encounter ac_(ServiceRequest Referral) => 
				ElevatedEncounter;
			var ad_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(ab_, ac_);

			return ad_;
		};
		var h_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, g_);
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
				var bc_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var bd_ = QICoreCommon_2_0_000.toInterval(bc_);
				var be_ = context.Operators.End(bd_);
				var bf_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var bg_ = context.Operators.Start(bf_);
				var bh_ = context.Operators.Quantity(1m, "year");
				var bi_ = context.Operators.Subtract(bg_, bh_);
				var bk_ = context.Operators.Start(bf_);
				var bl_ = context.Operators.Interval(bi_, bk_, true, true);
				var bm_ = context.Operators.ElementInInterval<CqlDateTime>(be_, bl_, null);
				var bo_ = context.Operators.Start(bf_);
				var bp_ = context.Operators.Not((bool?)(bo_ is null));
				var bq_ = context.Operators.And(bm_, bp_);
				var br_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var bs_ = context.Operators.Convert<string>(br_);
				var bt_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bu_ = context.Operators.InList<string>(bs_, (bt_ as IEnumerable<string>));
				var bv_ = context.Operators.And(bq_, bu_);

				return bv_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var bw_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bx_ = QICoreCommon_2_0_000.toInterval(bw_);
				var by_ = context.Operators.Start(bx_);

				return by_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.LastOfList<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				var bz_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var ca_ = context.Operators.Convert<string>(bz_?.SystemElement);
				var cb_ = context.Operators.Equal(ca_, "http://loinc.org");
				var cd_ = context.Operators.Convert<string>(bz_?.CodeElement);
				var ce_ = context.Operators.Equal(cd_, "8480-6");
				var cf_ = context.Operators.And(cb_, ce_);

				return cf_;
			};
			var k_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(i_?.Component, j_);
			var l_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(k_);
			var m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			var n_ = context.Operators.Quantity(0m, "mm[Hg]");
			var o_ = context.Operators.Greater((m_ as CqlQuantity), n_);
			bool? q_(Observation BloodPressure)
			{
				var cg_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var ch_ = QICoreCommon_2_0_000.toInterval(cg_);
				var ci_ = context.Operators.End(ch_);
				var cj_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var ck_ = context.Operators.Start(cj_);
				var cl_ = context.Operators.Quantity(1m, "year");
				var cm_ = context.Operators.Subtract(ck_, cl_);
				var co_ = context.Operators.Start(cj_);
				var cp_ = context.Operators.Interval(cm_, co_, true, true);
				var cq_ = context.Operators.ElementInInterval<CqlDateTime>(ci_, cp_, null);
				var cs_ = context.Operators.Start(cj_);
				var ct_ = context.Operators.Not((bool?)(cs_ is null));
				var cu_ = context.Operators.And(cq_, ct_);
				var cv_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var cw_ = context.Operators.Convert<string>(cv_);
				var cx_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var cy_ = context.Operators.InList<string>(cw_, (cx_ as IEnumerable<string>));
				var cz_ = context.Operators.And(cu_, cy_);

				return cz_;
			};
			var r_ = context.Operators.WhereOrNull<Observation>(d_, q_);
			object s_(Observation @this)
			{
				var da_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var db_ = QICoreCommon_2_0_000.toInterval(da_);
				var dc_ = context.Operators.Start(db_);

				return dc_;
			};
			var t_ = context.Operators.ListSortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.LastOfList<Observation>(t_);
			bool? v_(Observation.ComponentComponent @this)
			{
				var dd_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var de_ = context.Operators.Convert<string>(dd_?.SystemElement);
				var df_ = context.Operators.Equal(de_, "http://loinc.org");
				var dh_ = context.Operators.Convert<string>(dd_?.CodeElement);
				var di_ = context.Operators.Equal(dh_, "8462-4");
				var dj_ = context.Operators.And(df_, di_);

				return dj_;
			};
			var w_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(u_?.Component, v_);
			var x_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(w_);
			var y_ = FHIRHelpers_4_3_000.ToValue(x_?.Value);
			var aa_ = context.Operators.Greater((y_ as CqlQuantity), n_);
			var ab_ = context.Operators.And(o_, aa_);
			bool? ad_(Observation BloodPressure)
			{
				var dk_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var dl_ = QICoreCommon_2_0_000.toInterval(dk_);
				var dm_ = context.Operators.End(dl_);
				var dn_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var do_ = context.Operators.Start(dn_);
				var dp_ = context.Operators.Quantity(1m, "year");
				var dq_ = context.Operators.Subtract(do_, dp_);
				var ds_ = context.Operators.Start(dn_);
				var dt_ = context.Operators.Interval(dq_, ds_, true, true);
				var du_ = context.Operators.ElementInInterval<CqlDateTime>(dm_, dt_, null);
				var dw_ = context.Operators.Start(dn_);
				var dx_ = context.Operators.Not((bool?)(dw_ is null));
				var dy_ = context.Operators.And(du_, dx_);
				var dz_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var ea_ = context.Operators.Convert<string>(dz_);
				var eb_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ec_ = context.Operators.InList<string>(ea_, (eb_ as IEnumerable<string>));
				var ed_ = context.Operators.And(dy_, ec_);

				return ed_;
			};
			var ae_ = context.Operators.WhereOrNull<Observation>(d_, ad_);
			object af_(Observation @this)
			{
				var ee_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ef_ = QICoreCommon_2_0_000.toInterval(ee_);
				var eg_ = context.Operators.Start(ef_);

				return eg_;
			};
			var ag_ = context.Operators.ListSortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			var ah_ = context.Operators.LastOfList<Observation>(ag_);
			bool? ai_(Observation.ComponentComponent @this)
			{
				var eh_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var ei_ = context.Operators.Convert<string>(eh_?.SystemElement);
				var ej_ = context.Operators.Equal(ei_, "http://loinc.org");
				var el_ = context.Operators.Convert<string>(eh_?.CodeElement);
				var em_ = context.Operators.Equal(el_, "8480-6");
				var en_ = context.Operators.And(ej_, em_);

				return en_;
			};
			var aj_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(ah_?.Component, ai_);
			var ak_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(aj_);
			var al_ = FHIRHelpers_4_3_000.ToValue(ak_?.Value);
			var am_ = context.Operators.Quantity(130m, "mm[Hg]");
			var an_ = context.Operators.GreaterOrEqual((al_ as CqlQuantity), am_);
			bool? ap_(Observation BloodPressure)
			{
				var eo_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var ep_ = QICoreCommon_2_0_000.toInterval(eo_);
				var eq_ = context.Operators.End(ep_);
				var er_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var es_ = context.Operators.Start(er_);
				var et_ = context.Operators.Quantity(1m, "year");
				var eu_ = context.Operators.Subtract(es_, et_);
				var ew_ = context.Operators.Start(er_);
				var ex_ = context.Operators.Interval(eu_, ew_, true, true);
				var ey_ = context.Operators.ElementInInterval<CqlDateTime>(eq_, ex_, null);
				var fa_ = context.Operators.Start(er_);
				var fb_ = context.Operators.Not((bool?)(fa_ is null));
				var fc_ = context.Operators.And(ey_, fb_);
				var fd_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var fe_ = context.Operators.Convert<string>(fd_);
				var ff_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var fg_ = context.Operators.InList<string>(fe_, (ff_ as IEnumerable<string>));
				var fh_ = context.Operators.And(fc_, fg_);

				return fh_;
			};
			var aq_ = context.Operators.WhereOrNull<Observation>(d_, ap_);
			object ar_(Observation @this)
			{
				var fi_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var fj_ = QICoreCommon_2_0_000.toInterval(fi_);
				var fk_ = context.Operators.Start(fj_);

				return fk_;
			};
			var as_ = context.Operators.ListSortBy<Observation>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
			var at_ = context.Operators.LastOfList<Observation>(as_);
			bool? au_(Observation.ComponentComponent @this)
			{
				var fl_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var fm_ = context.Operators.Convert<string>(fl_?.SystemElement);
				var fn_ = context.Operators.Equal(fm_, "http://loinc.org");
				var fp_ = context.Operators.Convert<string>(fl_?.CodeElement);
				var fq_ = context.Operators.Equal(fp_, "8462-4");
				var fr_ = context.Operators.And(fn_, fq_);

				return fr_;
			};
			var av_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(at_?.Component, au_);
			var aw_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(av_);
			var ax_ = FHIRHelpers_4_3_000.ToValue(aw_?.Value);
			var ay_ = context.Operators.Quantity(80m, "mm[Hg]");
			var az_ = context.Operators.GreaterOrEqual((ax_ as CqlQuantity), ay_);
			var ba_ = context.Operators.Or(an_, az_);
			var bb_ = context.Operators.And(ab_, ba_);

			return bb_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

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
				var be_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var bf_ = QICoreCommon_2_0_000.toInterval(be_);
				var bg_ = context.Operators.End(bf_);
				var bh_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var bi_ = context.Operators.ElementInInterval<CqlDateTime>(bg_, bh_, "day");

				return bi_;
			};
			var h_ = context.Operators.WhereOrNull<Observation>(f_, g_);
			object i_(Observation @this)
			{
				var bj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bk_ = QICoreCommon_2_0_000.toInterval(bj_);
				var bl_ = context.Operators.Start(bk_);

				return bl_;
			};
			var j_ = context.Operators.ListSortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Observation>(j_);
			bool? l_(Observation.ComponentComponent @this)
			{
				var bm_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var bn_ = context.Operators.Convert<string>(bm_?.SystemElement);
				var bo_ = context.Operators.Equal(bn_, "http://loinc.org");
				var bq_ = context.Operators.Convert<string>(bm_?.CodeElement);
				var br_ = context.Operators.Equal(bq_, "8480-6");
				var bs_ = context.Operators.And(bo_, br_);

				return bs_;
			};
			var m_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(k_?.Component, l_);
			var n_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(m_);
			var o_ = FHIRHelpers_4_3_000.ToValue(n_?.Value);
			var p_ = context.Operators.Quantity(0m, "mm[Hg]");
			var q_ = context.Operators.Greater((o_ as CqlQuantity), p_);
			bool? s_(Observation BloodPressure)
			{
				var bt_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var bu_ = QICoreCommon_2_0_000.toInterval(bt_);
				var bv_ = context.Operators.End(bu_);
				var bw_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var bx_ = context.Operators.ElementInInterval<CqlDateTime>(bv_, bw_, "day");

				return bx_;
			};
			var t_ = context.Operators.WhereOrNull<Observation>(f_, s_);
			object u_(Observation @this)
			{
				var by_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bz_ = QICoreCommon_2_0_000.toInterval(by_);
				var ca_ = context.Operators.Start(bz_);

				return ca_;
			};
			var v_ = context.Operators.ListSortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			var w_ = context.Operators.LastOfList<Observation>(v_);
			bool? x_(Observation.ComponentComponent @this)
			{
				var cb_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var cc_ = context.Operators.Convert<string>(cb_?.SystemElement);
				var cd_ = context.Operators.Equal(cc_, "http://loinc.org");
				var cf_ = context.Operators.Convert<string>(cb_?.CodeElement);
				var cg_ = context.Operators.Equal(cf_, "8462-4");
				var ch_ = context.Operators.And(cd_, cg_);

				return ch_;
			};
			var y_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(w_?.Component, x_);
			var z_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(y_);
			var aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Value);
			var ac_ = context.Operators.Greater((aa_ as CqlQuantity), p_);
			var ad_ = context.Operators.And(q_, ac_);
			bool? af_(Observation BloodPressure)
			{
				var ci_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var cj_ = QICoreCommon_2_0_000.toInterval(ci_);
				var ck_ = context.Operators.End(cj_);
				var cl_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var cm_ = context.Operators.ElementInInterval<CqlDateTime>(ck_, cl_, "day");

				return cm_;
			};
			var ag_ = context.Operators.WhereOrNull<Observation>(f_, af_);
			object ah_(Observation @this)
			{
				var cn_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var co_ = QICoreCommon_2_0_000.toInterval(cn_);
				var cp_ = context.Operators.Start(co_);

				return cp_;
			};
			var ai_ = context.Operators.ListSortBy<Observation>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
			var aj_ = context.Operators.LastOfList<Observation>(ai_);
			bool? ak_(Observation.ComponentComponent @this)
			{
				var cq_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var cr_ = context.Operators.Convert<string>(cq_?.SystemElement);
				var cs_ = context.Operators.Equal(cr_, "http://loinc.org");
				var cu_ = context.Operators.Convert<string>(cq_?.CodeElement);
				var cv_ = context.Operators.Equal(cu_, "8480-6");
				var cw_ = context.Operators.And(cs_, cv_);

				return cw_;
			};
			var al_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(aj_?.Component, ak_);
			var am_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(al_);
			var an_ = FHIRHelpers_4_3_000.ToValue(am_?.Value);
			var ao_ = context.Operators.Quantity(130m, "mm[Hg]");
			var ap_ = context.Operators.GreaterOrEqual((an_ as CqlQuantity), ao_);
			bool? ar_(Observation BloodPressure)
			{
				var cx_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var cy_ = QICoreCommon_2_0_000.toInterval(cx_);
				var cz_ = context.Operators.End(cy_);
				var da_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var db_ = context.Operators.ElementInInterval<CqlDateTime>(cz_, da_, "day");

				return db_;
			};
			var as_ = context.Operators.WhereOrNull<Observation>(f_, ar_);
			object at_(Observation @this)
			{
				var dc_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var dd_ = QICoreCommon_2_0_000.toInterval(dc_);
				var de_ = context.Operators.Start(dd_);

				return de_;
			};
			var au_ = context.Operators.ListSortBy<Observation>(as_, at_, System.ComponentModel.ListSortDirection.Ascending);
			var av_ = context.Operators.LastOfList<Observation>(au_);
			bool? aw_(Observation.ComponentComponent @this)
			{
				var df_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var dg_ = context.Operators.Convert<string>(df_?.SystemElement);
				var dh_ = context.Operators.Equal(dg_, "http://loinc.org");
				var dj_ = context.Operators.Convert<string>(df_?.CodeElement);
				var dk_ = context.Operators.Equal(dj_, "8462-4");
				var dl_ = context.Operators.And(dh_, dk_);

				return dl_;
			};
			var ax_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(av_?.Component, aw_);
			var ay_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(ax_);
			var az_ = FHIRHelpers_4_3_000.ToValue(ay_?.Value);
			var ba_ = context.Operators.Quantity(80m, "mm[Hg]");
			var bb_ = context.Operators.GreaterOrEqual((az_ as CqlQuantity), ba_);
			var bc_ = context.Operators.Or(ap_, bb_);
			var bd_ = context.Operators.And(ad_, bc_);

			return bd_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		var d_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
		var e_ = context.Operators.ListExcept<Encounter>(c_, d_);

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
				var l_ = context.Operators.Convert<CqlDateTime>(FourWeekRescreen?.AuthoredOnElement);
				var m_ = this.Measurement_Period();
				var n_ = context.Operators.ElementInInterval<CqlDateTime>(l_, m_, "day");
				var o_ = context.Operators.Convert<CqlDateTime>(NonPharmInterventionsHTN?.AuthoredOnElement);
				var q_ = context.Operators.ElementInInterval<CqlDateTime>(o_, m_, "day");
				var r_ = context.Operators.And(n_, q_);
				var s_ = context.Operators.Convert<Code<RequestIntent>>(FourWeekRescreen?.IntentElement?.Value);
				var t_ = context.Operators.Equivalent(s_, "order");
				var u_ = context.Operators.And(r_, t_);

				return u_;
			};
			var i_ = context.Operators.WhereOrNull<ServiceRequest>(g_, h_);
			ServiceRequest j_(ServiceRequest NonPharmInterventionsHTN) => 
				FourWeekRescreen;
			var k_ = context.Operators.SelectOrNull<ServiceRequest, ServiceRequest>(i_, j_);

			return k_;
		};
		var d_ = context.Operators.SelectManyOrNull<ServiceRequest, ServiceRequest>(b_, c_);
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
				var i_ = context.Operators.Convert<CqlDateTime>(FirstHTNIntervention?.AuthoredOnElement);
				var j_ = FHIRHelpers_4_3_000.ToInterval(FirstHTNEncounter?.Period);
				var k_ = context.Operators.ElementInInterval<CqlDateTime>(i_, j_, "day");

				return k_;
			};
			var f_ = context.Operators.WhereOrNull<ServiceRequest>(d_, e_);
			Encounter g_(ServiceRequest FirstHTNIntervention) => 
				FirstHTNEncounter;
			var h_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

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
				var bk_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var bl_ = QICoreCommon_2_0_000.toInterval(bk_);
				var bm_ = context.Operators.End(bl_);
				var bn_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var bo_ = context.Operators.ElementInInterval<CqlDateTime>(bm_, bn_, "day");
				var bp_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var bq_ = context.Operators.Convert<string>(bp_);
				var br_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bs_ = context.Operators.InList<string>(bq_, (br_ as IEnumerable<string>));
				var bt_ = context.Operators.And(bo_, bs_);

				return bt_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var bu_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bv_ = QICoreCommon_2_0_000.toInterval(bu_);
				var bw_ = context.Operators.Start(bv_);

				return bw_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.LastOfList<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				var bx_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var by_ = context.Operators.Convert<string>(bx_?.SystemElement);
				var bz_ = context.Operators.Equal(by_, "http://loinc.org");
				var cb_ = context.Operators.Convert<string>(bx_?.CodeElement);
				var cc_ = context.Operators.Equal(cb_, "8480-6");
				var cd_ = context.Operators.And(bz_, cc_);

				return cd_;
			};
			var k_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(i_?.Component, j_);
			var l_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(k_);
			var m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			var n_ = context.Operators.Quantity(130m, "mm[Hg]");
			var o_ = context.Operators.Quantity(139m, "mm[Hg]");
			var p_ = context.Operators.Interval(n_, o_, true, true);
			var q_ = context.Operators.ElementInInterval<CqlQuantity>((m_ as CqlQuantity), p_, null);
			bool? s_(Observation BloodPressure)
			{
				var ce_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var cf_ = QICoreCommon_2_0_000.toInterval(ce_);
				var cg_ = context.Operators.End(cf_);
				var ch_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var ci_ = context.Operators.ElementInInterval<CqlDateTime>(cg_, ch_, "day");
				var cj_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var ck_ = context.Operators.Convert<string>(cj_);
				var cl_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var cm_ = context.Operators.InList<string>(ck_, (cl_ as IEnumerable<string>));
				var cn_ = context.Operators.And(ci_, cm_);

				return cn_;
			};
			var t_ = context.Operators.WhereOrNull<Observation>(d_, s_);
			object u_(Observation @this)
			{
				var co_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var cp_ = QICoreCommon_2_0_000.toInterval(co_);
				var cq_ = context.Operators.Start(cp_);

				return cq_;
			};
			var v_ = context.Operators.ListSortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
			var w_ = context.Operators.LastOfList<Observation>(v_);
			bool? x_(Observation.ComponentComponent @this)
			{
				var cr_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var cs_ = context.Operators.Convert<string>(cr_?.SystemElement);
				var ct_ = context.Operators.Equal(cs_, "http://loinc.org");
				var cv_ = context.Operators.Convert<string>(cr_?.CodeElement);
				var cw_ = context.Operators.Equal(cv_, "8462-4");
				var cx_ = context.Operators.And(ct_, cw_);

				return cx_;
			};
			var y_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(w_?.Component, x_);
			var z_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(y_);
			var aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Value);
			var ab_ = context.Operators.Quantity(80m, "mm[Hg]");
			var ac_ = context.Operators.Quantity(89m, "mm[Hg]");
			var ad_ = context.Operators.Interval(ab_, ac_, true, true);
			var ae_ = context.Operators.ElementInInterval<CqlQuantity>((aa_ as CqlQuantity), ad_, null);
			var af_ = context.Operators.Or(q_, ae_);
			bool? ah_(Observation BloodPressure)
			{
				var cy_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var cz_ = QICoreCommon_2_0_000.toInterval(cy_);
				var da_ = context.Operators.End(cz_);
				var db_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var dc_ = context.Operators.ElementInInterval<CqlDateTime>(da_, db_, "day");
				var dd_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var de_ = context.Operators.Convert<string>(dd_);
				var df_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var dg_ = context.Operators.InList<string>(de_, (df_ as IEnumerable<string>));
				var dh_ = context.Operators.And(dc_, dg_);

				return dh_;
			};
			var ai_ = context.Operators.WhereOrNull<Observation>(d_, ah_);
			object aj_(Observation @this)
			{
				var di_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var dj_ = QICoreCommon_2_0_000.toInterval(di_);
				var dk_ = context.Operators.Start(dj_);

				return dk_;
			};
			var ak_ = context.Operators.ListSortBy<Observation>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
			var al_ = context.Operators.LastOfList<Observation>(ak_);
			bool? am_(Observation.ComponentComponent @this)
			{
				var dl_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var dm_ = context.Operators.Convert<string>(dl_?.SystemElement);
				var dn_ = context.Operators.Equal(dm_, "http://loinc.org");
				var dp_ = context.Operators.Convert<string>(dl_?.CodeElement);
				var dq_ = context.Operators.Equal(dp_, "8480-6");
				var dr_ = context.Operators.And(dn_, dq_);

				return dr_;
			};
			var an_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(al_?.Component, am_);
			var ao_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(an_);
			var ap_ = FHIRHelpers_4_3_000.ToValue(ao_?.Value);
			var aq_ = context.Operators.Quantity(140m, "mm[Hg]");
			var ar_ = context.Operators.GreaterOrEqual((ap_ as CqlQuantity), aq_);
			bool? at_(Observation BloodPressure)
			{
				var ds_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var dt_ = QICoreCommon_2_0_000.toInterval(ds_);
				var du_ = context.Operators.End(dt_);
				var dv_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var dw_ = context.Operators.ElementInInterval<CqlDateTime>(du_, dv_, "day");
				var dx_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var dy_ = context.Operators.Convert<string>(dx_);
				var dz_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ea_ = context.Operators.InList<string>(dy_, (dz_ as IEnumerable<string>));
				var eb_ = context.Operators.And(dw_, ea_);

				return eb_;
			};
			var au_ = context.Operators.WhereOrNull<Observation>(d_, at_);
			object av_(Observation @this)
			{
				var ec_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ed_ = QICoreCommon_2_0_000.toInterval(ec_);
				var ee_ = context.Operators.Start(ed_);

				return ee_;
			};
			var aw_ = context.Operators.ListSortBy<Observation>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
			var ax_ = context.Operators.LastOfList<Observation>(aw_);
			bool? ay_(Observation.ComponentComponent @this)
			{
				var ef_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var eg_ = context.Operators.Convert<string>(ef_?.SystemElement);
				var eh_ = context.Operators.Equal(eg_, "http://loinc.org");
				var ej_ = context.Operators.Convert<string>(ef_?.CodeElement);
				var ek_ = context.Operators.Equal(ej_, "8462-4");
				var el_ = context.Operators.And(eh_, ek_);

				return el_;
			};
			var az_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(ax_?.Component, ay_);
			var ba_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(az_);
			var bb_ = FHIRHelpers_4_3_000.ToValue(ba_?.Value);
			var bc_ = context.Operators.Quantity(90m, "mm[Hg]");
			var bd_ = context.Operators.GreaterOrEqual((bb_ as CqlQuantity), bc_);
			var be_ = context.Operators.Or(ar_, bd_);
			var bf_ = context.Operators.Not(be_);
			var bg_ = context.Operators.And(af_, bf_);
			var bh_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			var bi_ = context.Operators.ExistsInList<Encounter>(bh_);
			var bj_ = context.Operators.And(bg_, bi_);

			return bj_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

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
			var m_ = context.Operators.Convert<Code<RequestIntent>>(EKGLab?.IntentElement?.Value);
			var n_ = context.Operators.Equivalent(m_, "order");

			return n_;
		};
		var l_ = context.Operators.WhereOrNull<ServiceRequest>(j_, k_);

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
				var k_ = context.Operators.Convert<CqlDateTime>(Rescreen2to6?.AuthoredOnElement);
				var l_ = this.Measurement_Period();
				var m_ = context.Operators.ElementInInterval<CqlDateTime>(k_, l_, "day");
				var n_ = context.Operators.Convert<CqlDateTime>(LabECGIntervention?.AuthoredOnElement);
				var p_ = context.Operators.ElementInInterval<CqlDateTime>(n_, l_, "day");
				var q_ = context.Operators.And(m_, p_);

				return q_;
			};
			var h_ = context.Operators.WhereOrNull<ServiceRequest>(f_, g_);
			ServiceRequest i_(ServiceRequest LabECGIntervention) => 
				Rescreen2to6;
			var j_ = context.Operators.SelectOrNull<ServiceRequest, ServiceRequest>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectManyOrNull<ServiceRequest, ServiceRequest>(a_, b_);
		IEnumerable<ServiceRequest> d_(ServiceRequest Rescreen2to6)
		{
			var r_ = this.NonPharmacological_Interventions();
			bool? s_(ServiceRequest NonPharmSecondIntervention)
			{
				var w_ = context.Operators.Convert<CqlDateTime>(NonPharmSecondIntervention?.AuthoredOnElement);
				var x_ = this.Measurement_Period();
				var y_ = context.Operators.ElementInInterval<CqlDateTime>(w_, x_, "day");

				return y_;
			};
			var t_ = context.Operators.WhereOrNull<ServiceRequest>(r_, s_);
			ServiceRequest u_(ServiceRequest NonPharmSecondIntervention) => 
				Rescreen2to6;
			var v_ = context.Operators.SelectOrNull<ServiceRequest, ServiceRequest>(t_, u_);

			return v_;
		};
		var e_ = context.Operators.SelectManyOrNull<ServiceRequest, ServiceRequest>(c_, d_);

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
				var m_ = context.Operators.Convert<CqlDateTime>(EncounterInterventions?.AuthoredOnElement);
				var n_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounterReading?.Period);
				var o_ = context.Operators.ElementInInterval<CqlDateTime>(m_, n_, "day");

				return o_;
			};
			var j_ = context.Operators.WhereOrNull<ServiceRequest>(h_, i_);
			Encounter k_(ServiceRequest EncounterInterventions) => 
				SecondHTNEncounterReading;
			var l_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading)
		{
			var p_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? q_(ServiceRequest ReferralForHTN)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(ReferralForHTN?.AuthoredOnElement);
				var v_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounterReading?.Period);
				var w_ = context.Operators.ElementInInterval<CqlDateTime>(u_, v_, "day");

				return w_;
			};
			var r_ = context.Operators.WhereOrNull<ServiceRequest>(p_, q_);
			Encounter s_(ServiceRequest ReferralForHTN) => 
				SecondHTNEncounterReading;
			var t_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(r_, s_);

			return t_;
		};
		var f_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, e_);
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
				var bf_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var bg_ = QICoreCommon_2_0_000.toInterval(bf_);
				var bh_ = context.Operators.End(bg_);
				var bi_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var bj_ = context.Operators.ElementInInterval<CqlDateTime>(bh_, bi_, null);
				var bk_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var bl_ = context.Operators.Convert<string>(bk_);
				var bm_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var bn_ = context.Operators.InList<string>(bl_, (bm_ as IEnumerable<string>));
				var bo_ = context.Operators.And(bj_, bn_);

				return bo_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			object g_(Observation @this)
			{
				var bp_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var bq_ = QICoreCommon_2_0_000.toInterval(bp_);
				var br_ = context.Operators.Start(bq_);

				return br_;
			};
			var h_ = context.Operators.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			var i_ = context.Operators.LastOfList<Observation>(h_);
			bool? j_(Observation.ComponentComponent @this)
			{
				var bs_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var bt_ = context.Operators.Convert<string>(bs_?.SystemElement);
				var bu_ = context.Operators.Equal(bt_, "http://loinc.org");
				var bw_ = context.Operators.Convert<string>(bs_?.CodeElement);
				var bx_ = context.Operators.Equal(bw_, "8480-6");
				var by_ = context.Operators.And(bu_, bx_);

				return by_;
			};
			var k_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(i_?.Component, j_);
			var l_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(k_);
			var m_ = FHIRHelpers_4_3_000.ToValue(l_?.Value);
			var n_ = context.Operators.Quantity(0m, "mm[Hg]");
			var o_ = context.Operators.Greater((m_ as CqlQuantity), n_);
			bool? q_(Observation BloodPressure)
			{
				var bz_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var ca_ = QICoreCommon_2_0_000.toInterval(bz_);
				var cb_ = context.Operators.End(ca_);
				var cc_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var cd_ = context.Operators.ElementInInterval<CqlDateTime>(cb_, cc_, null);
				var ce_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var cf_ = context.Operators.Convert<string>(ce_);
				var cg_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ch_ = context.Operators.InList<string>(cf_, (cg_ as IEnumerable<string>));
				var ci_ = context.Operators.And(cd_, ch_);

				return ci_;
			};
			var r_ = context.Operators.WhereOrNull<Observation>(d_, q_);
			object s_(Observation @this)
			{
				var cj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var ck_ = QICoreCommon_2_0_000.toInterval(cj_);
				var cl_ = context.Operators.Start(ck_);

				return cl_;
			};
			var t_ = context.Operators.ListSortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.LastOfList<Observation>(t_);
			bool? v_(Observation.ComponentComponent @this)
			{
				var cm_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var cn_ = context.Operators.Convert<string>(cm_?.SystemElement);
				var co_ = context.Operators.Equal(cn_, "http://loinc.org");
				var cq_ = context.Operators.Convert<string>(cm_?.CodeElement);
				var cr_ = context.Operators.Equal(cq_, "8462-4");
				var cs_ = context.Operators.And(co_, cr_);

				return cs_;
			};
			var w_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(u_?.Component, v_);
			var x_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(w_);
			var y_ = FHIRHelpers_4_3_000.ToValue(x_?.Value);
			var aa_ = context.Operators.Greater((y_ as CqlQuantity), n_);
			var ab_ = context.Operators.And(o_, aa_);
			bool? ad_(Observation BloodPressure)
			{
				var ct_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var cu_ = QICoreCommon_2_0_000.toInterval(ct_);
				var cv_ = context.Operators.End(cu_);
				var cw_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var cx_ = context.Operators.ElementInInterval<CqlDateTime>(cv_, cw_, null);
				var cy_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var cz_ = context.Operators.Convert<string>(cy_);
				var da_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var db_ = context.Operators.InList<string>(cz_, (da_ as IEnumerable<string>));
				var dc_ = context.Operators.And(cx_, db_);

				return dc_;
			};
			var ae_ = context.Operators.WhereOrNull<Observation>(d_, ad_);
			object af_(Observation @this)
			{
				var dd_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var de_ = QICoreCommon_2_0_000.toInterval(dd_);
				var df_ = context.Operators.Start(de_);

				return df_;
			};
			var ag_ = context.Operators.ListSortBy<Observation>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			var ah_ = context.Operators.LastOfList<Observation>(ag_);
			bool? ai_(Observation.ComponentComponent @this)
			{
				var dg_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var dh_ = context.Operators.Convert<string>(dg_?.SystemElement);
				var di_ = context.Operators.Equal(dh_, "http://loinc.org");
				var dk_ = context.Operators.Convert<string>(dg_?.CodeElement);
				var dl_ = context.Operators.Equal(dk_, "8480-6");
				var dm_ = context.Operators.And(di_, dl_);

				return dm_;
			};
			var aj_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(ah_?.Component, ai_);
			var ak_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(aj_);
			var al_ = FHIRHelpers_4_3_000.ToValue(ak_?.Value);
			var am_ = context.Operators.Quantity(140m, "mm[Hg]");
			var an_ = context.Operators.GreaterOrEqual((al_ as CqlQuantity), am_);
			bool? ap_(Observation BloodPressure)
			{
				var dn_ = FHIRHelpers_4_3_000.ToValue(BloodPressure?.Effective);
				var do_ = QICoreCommon_2_0_000.toInterval(dn_);
				var dp_ = context.Operators.End(do_);
				var dq_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var dr_ = context.Operators.ElementInInterval<CqlDateTime>(dp_, dq_, null);
				var ds_ = context.Operators.Convert<Code<ObservationStatus>>(BloodPressure?.StatusElement?.Value);
				var dt_ = context.Operators.Convert<string>(ds_);
				var du_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var dv_ = context.Operators.InList<string>(dt_, (du_ as IEnumerable<string>));
				var dw_ = context.Operators.And(dr_, dv_);

				return dw_;
			};
			var aq_ = context.Operators.WhereOrNull<Observation>(d_, ap_);
			object ar_(Observation @this)
			{
				var dx_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				var dy_ = QICoreCommon_2_0_000.toInterval(dx_);
				var dz_ = context.Operators.Start(dy_);

				return dz_;
			};
			var as_ = context.Operators.ListSortBy<Observation>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
			var at_ = context.Operators.LastOfList<Observation>(as_);
			bool? au_(Observation.ComponentComponent @this)
			{
				var ea_ = context.Operators.FirstOfList<Coding>(@this?.Code?.Coding);
				var eb_ = context.Operators.Convert<string>(ea_?.SystemElement);
				var ec_ = context.Operators.Equal(eb_, "http://loinc.org");
				var ee_ = context.Operators.Convert<string>(ea_?.CodeElement);
				var ef_ = context.Operators.Equal(ee_, "8462-4");
				var eg_ = context.Operators.And(ec_, ef_);

				return eg_;
			};
			var av_ = context.Operators.WhereOrNull<Observation.ComponentComponent>(at_?.Component, au_);
			var aw_ = context.Operators.SingleOrNull<Observation.ComponentComponent>(av_);
			var ax_ = FHIRHelpers_4_3_000.ToValue(aw_?.Value);
			var ay_ = context.Operators.Quantity(90m, "mm[Hg]");
			var az_ = context.Operators.GreaterOrEqual((ax_ as CqlQuantity), ay_);
			var ba_ = context.Operators.Or(an_, az_);
			var bb_ = context.Operators.And(ab_, ba_);
			var bc_ = this.Encounter_with_Hypertensive_Reading_Within_Year_Prior();
			var bd_ = context.Operators.ExistsInList<Encounter>(bc_);
			var be_ = context.Operators.And(bb_, bd_);

			return be_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

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
				var n_ = context.Operators.Convert<CqlDateTime>(WeeksRescreen?.AuthoredOnElement);
				var o_ = this.Measurement_Period();
				var p_ = context.Operators.ElementInInterval<CqlDateTime>(n_, o_, "day");
				var q_ = context.Operators.Convert<CqlDateTime>(ECGLabTest?.AuthoredOnElement);
				var s_ = context.Operators.ElementInInterval<CqlDateTime>(q_, o_, "day");
				var t_ = context.Operators.And(p_, s_);
				var u_ = context.Operators.Convert<Code<RequestIntent>>(WeeksRescreen?.IntentElement?.Value);
				var v_ = context.Operators.Equivalent(u_, "order");
				var w_ = context.Operators.And(t_, v_);
				var x_ = context.Operators.Convert<Code<RequestIntent>>(ECGLabTest?.IntentElement?.Value);
				var y_ = context.Operators.Equivalent(x_, "order");
				var z_ = context.Operators.And(w_, y_);

				return z_;
			};
			var k_ = context.Operators.WhereOrNull<ServiceRequest>(i_, j_);
			ServiceRequest l_(ServiceRequest ECGLabTest) => 
				WeeksRescreen;
			var m_ = context.Operators.SelectOrNull<ServiceRequest, ServiceRequest>(k_, l_);

			return m_;
		};
		var d_ = context.Operators.SelectManyOrNull<ServiceRequest, ServiceRequest>(b_, c_);
		IEnumerable<ServiceRequest> e_(ServiceRequest WeeksRescreen)
		{
			var aa_ = this.NonPharmacological_Interventions();
			bool? ab_(ServiceRequest HTNInterventions)
			{
				var af_ = context.Operators.Convert<CqlDateTime>(HTNInterventions?.AuthoredOnElement);
				var ag_ = this.Measurement_Period();
				var ah_ = context.Operators.ElementInInterval<CqlDateTime>(af_, ag_, "day");

				return ah_;
			};
			var ac_ = context.Operators.WhereOrNull<ServiceRequest>(aa_, ab_);
			ServiceRequest ad_(ServiceRequest HTNInterventions) => 
				WeeksRescreen;
			var ae_ = context.Operators.SelectOrNull<ServiceRequest, ServiceRequest>(ac_, ad_);

			return ae_;
		};
		var f_ = context.Operators.SelectManyOrNull<ServiceRequest, ServiceRequest>(d_, e_);
		IEnumerable<ServiceRequest> g_(ServiceRequest WeeksRescreen)
		{
			var ai_ = this.Pharmacologic_Therapy_for_Hypertension();
			var aj_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ai_, null);
			var al_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ai_, null);
			var am_ = context.Operators.ListUnion<MedicationRequest>(aj_, al_);
			bool? an_(MedicationRequest Medications)
			{
				var ar_ = context.Operators.Convert<CqlDateTime>(Medications?.AuthoredOnElement);
				var as_ = this.Measurement_Period();
				var at_ = context.Operators.ElementInInterval<CqlDateTime>(ar_, as_, "day");
				var au_ = context.Operators.Equivalent(Medications?.StatusElement?.Value, "active");
				var av_ = context.Operators.And(at_, au_);

				return av_;
			};
			var ao_ = context.Operators.WhereOrNull<MedicationRequest>(am_, an_);
			ServiceRequest ap_(MedicationRequest Medications) => 
				WeeksRescreen;
			var aq_ = context.Operators.SelectOrNull<MedicationRequest, ServiceRequest>(ao_, ap_);

			return aq_;
		};
		var h_ = context.Operators.SelectManyOrNull<ServiceRequest, ServiceRequest>(f_, g_);

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
				var m_ = context.Operators.Convert<CqlDateTime>(SecondHTN140Over90Interventions?.AuthoredOnElement);
				var n_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounterReading140Over90?.Period);
				var o_ = context.Operators.ElementInInterval<CqlDateTime>(m_, n_, "day");

				return o_;
			};
			var j_ = context.Operators.WhereOrNull<ServiceRequest>(h_, i_);
			Encounter k_(ServiceRequest SecondHTN140Over90Interventions) => 
				SecondHTNEncounterReading140Over90;
			var l_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter SecondHTNEncounterReading140Over90)
		{
			var p_ = this.Referral_to_Alternate_or_Primary_Healthcare_Professional_for_Hypertensive_Reading();
			bool? q_(ServiceRequest ReferralToProfessional)
			{
				var u_ = context.Operators.Convert<CqlDateTime>(ReferralToProfessional?.AuthoredOnElement);
				var v_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounterReading140Over90?.Period);
				var w_ = context.Operators.ElementInInterval<CqlDateTime>(u_, v_, "day");

				return w_;
			};
			var r_ = context.Operators.WhereOrNull<ServiceRequest>(p_, q_);
			Encounter s_(ServiceRequest ReferralToProfessional) => 
				SecondHTNEncounterReading140Over90;
			var t_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(r_, s_);

			return t_;
		};
		var f_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, e_);
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
				var o_ = context.Operators.Convert<CqlDateTime>(NoBPScreen?.IssuedElement?.Value);
				var p_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
				var q_ = context.Operators.ElementInInterval<CqlDateTime>(o_, p_, "day");
				bool? r_(Extension @this)
				{
					var am_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

					return am_;
				};
				var s_ = context.Operators.WhereOrNull<Extension>(((NoBPScreen is DomainResource)
						? ((NoBPScreen as DomainResource).Extension)
						: null), r_);
				DataType t_(Extension @this) => 
					@this?.Value;
				var u_ = context.Operators.SelectOrNull<Extension, DataType>(s_, t_);
				var v_ = context.Operators.SingleOrNull<DataType>(u_);
				var w_ = FHIRHelpers_4_3_000.ToConcept(v_);
				var x_ = this.Patient_Declined();
				var y_ = context.Operators.ConceptInValueSet(w_, x_);
				bool? z_(Extension @this)
				{
					var an_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

					return an_;
				};
				var aa_ = context.Operators.WhereOrNull<Extension>(((NoBPScreen is DomainResource)
						? ((NoBPScreen as DomainResource).Extension)
						: null), z_);
				var ac_ = context.Operators.SelectOrNull<Extension, DataType>(aa_, t_);
				var ad_ = context.Operators.SingleOrNull<DataType>(ac_);
				var ae_ = FHIRHelpers_4_3_000.ToConcept(ad_);
				var af_ = this.Medical_Reason();
				var ag_ = context.Operators.ConceptInValueSet(ae_, af_);
				var ah_ = context.Operators.Or(y_, ag_);
				var ai_ = context.Operators.And(q_, ah_);
				var aj_ = context.Operators.Convert<Code<ObservationStatus>>(NoBPScreen?.StatusElement?.Value);
				var ak_ = context.Operators.Equal(aj_, "cancelled");
				var al_ = context.Operators.And(ai_, ak_);

				return al_;
			};
			var l_ = context.Operators.WhereOrNull<Observation>(j_, k_);
			Encounter m_(Observation NoBPScreen) => 
				QualifyingEncounter;
			var n_ = context.Operators.SelectOrNull<Observation, Encounter>(l_, m_);

			return n_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

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
				var aq_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return aq_;
			};
			var ag_ = context.Operators.WhereOrNull<Extension>(((NonPharmIntervention is DomainResource)
					? ((NonPharmIntervention as DomainResource).Extension)
					: null), af_);
			DataType ah_(Extension @this) => 
				@this?.Value;
			var ai_ = context.Operators.SelectOrNull<Extension, DataType>(ag_, ah_);
			var aj_ = context.Operators.SingleOrNull<DataType>(ai_);
			var ak_ = FHIRHelpers_4_3_000.ToConcept(aj_);
			var al_ = this.Patient_Declined();
			var am_ = context.Operators.ConceptInValueSet(ak_, al_);
			var an_ = context.Operators.Convert<Code<RequestStatus>>(NonPharmIntervention?.StatusElement?.Value);
			var ao_ = context.Operators.Equal(an_, "completed");
			var ap_ = context.Operators.And(am_, ao_);

			return ap_;
		};
		var ae_ = context.Operators.WhereOrNull<ServiceRequest>(ac_, ad_);

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
				var x_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return x_;
			};
			var q_ = context.Operators.WhereOrNull<Extension>(((LabECGNotDone is DomainResource)
					? ((LabECGNotDone as DomainResource).Extension)
					: null), p_);
			DataType r_(Extension @this) => 
				@this?.Value;
			var s_ = context.Operators.SelectOrNull<Extension, DataType>(q_, r_);
			var t_ = context.Operators.SingleOrNull<DataType>(s_);
			var u_ = FHIRHelpers_4_3_000.ToConcept(t_);
			var v_ = this.Patient_Declined();
			var w_ = context.Operators.ConceptInValueSet(u_, v_);

			return w_;
		};
		var o_ = context.Operators.WhereOrNull<ServiceRequest>(m_, n_);

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
				var ae_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return ae_;
			};
			var u_ = context.Operators.WhereOrNull<Extension>(((SecondHTNDeclinedReferralAndFollowUp is DomainResource)
					? ((SecondHTNDeclinedReferralAndFollowUp as DomainResource).Extension)
					: null), t_);
			DataType v_(Extension @this) => 
				@this?.Value;
			var w_ = context.Operators.SelectOrNull<Extension, DataType>(u_, v_);
			var x_ = context.Operators.SingleOrNull<DataType>(w_);
			var y_ = FHIRHelpers_4_3_000.ToConcept(x_);
			var z_ = this.Patient_Declined();
			var aa_ = context.Operators.ConceptInValueSet(y_, z_);
			var ab_ = context.Operators.Convert<Code<RequestStatus>>(SecondHTNDeclinedReferralAndFollowUp?.StatusElement?.Value);
			var ac_ = context.Operators.Equal(ab_, "completed");
			var ad_ = context.Operators.And(aa_, ac_);

			return ad_;
		};
		var o_ = context.Operators.WhereOrNull<ServiceRequest>(m_, n_);
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
				var ak_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

				return ak_;
			};
			var aa_ = context.Operators.WhereOrNull<Extension>(((SecondHTN140Over90ReferralFollowUpNotDone is DomainResource)
					? ((SecondHTN140Over90ReferralFollowUpNotDone as DomainResource).Extension)
					: null), z_);
			DataType ab_(Extension @this) => 
				@this?.Value;
			var ac_ = context.Operators.SelectOrNull<Extension, DataType>(aa_, ab_);
			var ad_ = context.Operators.SingleOrNull<DataType>(ac_);
			var ae_ = FHIRHelpers_4_3_000.ToConcept(ad_);
			var af_ = this.Patient_Declined();
			var ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			var ah_ = context.Operators.Convert<Code<RequestStatus>>(SecondHTN140Over90ReferralFollowUpNotDone?.StatusElement?.Value);
			var ai_ = context.Operators.Equal(ah_, "completed");
			var aj_ = context.Operators.And(ag_, ai_);

			return aj_;
		};
		var m_ = context.Operators.WhereOrNull<ServiceRequest>(k_, l_);
		var n_ = this.Pharmacologic_Therapy_for_Hypertension();
		var o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		var q_ = context.Operators.RetrieveByValueSet<MedicationRequest>(n_, null);
		var r_ = context.Operators.ListUnion<MedicationRequest>(o_, q_);
		bool? s_(MedicationRequest MedicationRequestNotOrdered)
		{
			var al_ = context.Operators.EnumEqualsString(MedicationRequestNotOrdered?.StatusElement?.Value, "completed");

			return al_;
		};
		var t_ = context.Operators.WhereOrNull<MedicationRequest>(r_, s_);
		var u_ = context.Operators.ListUnion<object>((m_ as IEnumerable<object>), (t_ as IEnumerable<object>));
		var v_ = this.Laboratory_Test_or_ECG_for_Hypertension_Not_Ordered();
		var w_ = context.Operators.ListUnion<object>((u_ as IEnumerable<object>), (v_ as IEnumerable<object>));
		var x_ = this.NonPharmacological_Intervention_Not_Ordered();
		var y_ = context.Operators.ListUnion<object>((w_ as IEnumerable<object>), (x_ as IEnumerable<object>));

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
					var bd_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

					return bd_;
				};
				var ap_ = context.Operators.WhereOrNull<Extension>(((ElevatedBPDeclinedInterventions is DomainResource)
						? ((ElevatedBPDeclinedInterventions as DomainResource).Extension)
						: null), ao_);
				DataType aq_(Extension @this) => 
					@this?.Value;
				var ar_ = context.Operators.SelectOrNull<Extension, DataType>(ap_, aq_);
				var as_ = context.Operators.SingleOrNull<DataType>(ar_);
				var at_ = FHIRHelpers_4_3_000.ToConcept(as_);
				var au_ = this.Patient_Declined();
				var av_ = context.Operators.ConceptInValueSet(at_, au_);
				var aw_ = context.Operators.Convert<CqlDateTime>(ElevatedBPDeclinedInterventions?.AuthoredOnElement);
				var ax_ = FHIRHelpers_4_3_000.ToInterval(ElevatedBPEncounter?.Period);
				var ay_ = context.Operators.ElementInInterval<CqlDateTime>(aw_, ax_, "day");
				var az_ = context.Operators.And(av_, ay_);
				var ba_ = context.Operators.Convert<Code<RequestStatus>>(ElevatedBPDeclinedInterventions?.StatusElement?.Value);
				var bb_ = context.Operators.Equal(ba_, "completed");
				var bc_ = context.Operators.And(az_, bb_);

				return bc_;
			};
			var al_ = context.Operators.WhereOrNull<ServiceRequest>(aj_, ak_);
			Encounter am_(ServiceRequest ElevatedBPDeclinedInterventions) => 
				ElevatedBPEncounter;
			var an_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(al_, am_);

			return an_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter ElevatedBPEncounter)
		{
			var be_ = this.NonPharmacological_Intervention_Not_Ordered();
			bool? bf_(ServiceRequest NotOrdered)
			{
				var bj_ = context.Operators.Convert<CqlDateTime>(NotOrdered?.AuthoredOnElement);
				var bk_ = FHIRHelpers_4_3_000.ToInterval(ElevatedBPEncounter?.Period);
				var bl_ = context.Operators.ElementInInterval<CqlDateTime>(bj_, bk_, "day");

				return bl_;
			};
			var bg_ = context.Operators.WhereOrNull<ServiceRequest>(be_, bf_);
			Encounter bh_(ServiceRequest NotOrdered) => 
				ElevatedBPEncounter;
			var bi_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(bg_, bh_);

			return bi_;
		};
		var f_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		var h_ = this.Encounter_with_First_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_130_OR_DBP_Greater_than_or_Equal_to_80();
		IEnumerable<Encounter> i_(Encounter FirstHTNEncounter)
		{
			var bm_ = this.Follow_Up_Within_4_Weeks();
			var bn_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bm_, null);
			var bp_ = context.Operators.RetrieveByValueSet<ServiceRequest>(bm_, null);
			var bq_ = context.Operators.ListUnion<ServiceRequest>(bn_, bp_);
			var br_ = this.Referral_to_Primary_Care_or_Alternate_Provider();
			var bs_ = context.Operators.RetrieveByValueSet<ServiceRequest>(br_, null);
			var bu_ = context.Operators.RetrieveByValueSet<ServiceRequest>(br_, null);
			var bv_ = context.Operators.ListUnion<ServiceRequest>(bs_, bu_);
			var bw_ = context.Operators.ListUnion<ServiceRequest>(bq_, bv_);
			bool? bx_(ServiceRequest FirstHTNDeclinedInterventions)
			{
				bool? cb_(Extension @this)
				{
					var cq_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

					return cq_;
				};
				var cc_ = context.Operators.WhereOrNull<Extension>(((FirstHTNDeclinedInterventions is DomainResource)
						? ((FirstHTNDeclinedInterventions as DomainResource).Extension)
						: null), cb_);
				DataType cd_(Extension @this) => 
					@this?.Value;
				var ce_ = context.Operators.SelectOrNull<Extension, DataType>(cc_, cd_);
				var cf_ = context.Operators.SingleOrNull<DataType>(ce_);
				var cg_ = FHIRHelpers_4_3_000.ToConcept(cf_);
				var ch_ = this.Patient_Declined();
				var ci_ = context.Operators.ConceptInValueSet(cg_, ch_);
				var cj_ = context.Operators.Convert<CqlDateTime>(FirstHTNDeclinedInterventions?.AuthoredOnElement);
				var ck_ = FHIRHelpers_4_3_000.ToInterval(FirstHTNEncounter?.Period);
				var cl_ = context.Operators.ElementInInterval<CqlDateTime>(cj_, ck_, "day");
				var cm_ = context.Operators.And(ci_, cl_);
				var cn_ = context.Operators.Convert<Code<RequestStatus>>(FirstHTNDeclinedInterventions?.StatusElement?.Value);
				var co_ = context.Operators.Equal(cn_, "completed");
				var cp_ = context.Operators.And(cm_, co_);

				return cp_;
			};
			var by_ = context.Operators.WhereOrNull<ServiceRequest>(bw_, bx_);
			Encounter bz_(ServiceRequest FirstHTNDeclinedInterventions) => 
				FirstHTNEncounter;
			var ca_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(by_, bz_);

			return ca_;
		};
		var j_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(h_, i_);
		IEnumerable<Encounter> l_(Encounter FirstHTNEncounter)
		{
			var cr_ = this.NonPharmacological_Intervention_Not_Ordered();
			bool? cs_(ServiceRequest NoNonPharm)
			{
				var cw_ = context.Operators.Convert<CqlDateTime>(NoNonPharm?.AuthoredOnElement);
				var cx_ = FHIRHelpers_4_3_000.ToInterval(FirstHTNEncounter?.Period);
				var cy_ = context.Operators.ElementInInterval<CqlDateTime>(cw_, cx_, "day");

				return cy_;
			};
			var ct_ = context.Operators.WhereOrNull<ServiceRequest>(cr_, cs_);
			Encounter cu_(ServiceRequest NoNonPharm) => 
				FirstHTNEncounter;
			var cv_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(ct_, cu_);

			return cv_;
		};
		var m_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(h_, l_);
		var n_ = context.Operators.ListUnion<Encounter>(j_, m_);
		var o_ = context.Operators.ListUnion<Encounter>(g_, n_);
		var p_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89();
		IEnumerable<Encounter> q_(Encounter SecondHTNEncounter)
		{
			var cz_ = this.Second_Hypertensive_Reading_SBP_130_to_139_OR_DBP_80_to_89_Interventions_Declined();
			bool? da_(ServiceRequest SecondHTNDeclinedInterventions)
			{
				var de_ = context.Operators.Convert<CqlDateTime>(SecondHTNDeclinedInterventions?.AuthoredOnElement);
				var df_ = FHIRHelpers_4_3_000.ToInterval(SecondHTNEncounter?.Period);
				var dg_ = context.Operators.ElementInInterval<CqlDateTime>(de_, df_, "day");

				return dg_;
			};
			var db_ = context.Operators.WhereOrNull<ServiceRequest>(cz_, da_);
			Encounter dc_(ServiceRequest SecondHTNDeclinedInterventions) => 
				SecondHTNEncounter;
			var dd_ = context.Operators.SelectOrNull<ServiceRequest, Encounter>(db_, dc_);

			return dd_;
		};
		var r_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(p_, q_);
		var s_ = this.Encounter_with_Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90();
		IEnumerable<Encounter> t_(Encounter SecondHTN140Over90Encounter)
		{
			var dh_ = this.Second_Hypertensive_Reading_SBP_Greater_than_or_Equal_to_140_OR_DBP_Greater_than_or_Equal_to_90_Interventions_Declined();
			bool? di_(object SecondHTN140Over90DeclinedInterventions)
			{
				var dm_ = context.Operators.LateBoundProperty<object>(SecondHTN140Over90DeclinedInterventions, "authoredOn");
				var dn_ = context.Operators.LateBoundProperty<CqlDateTime>(dm_, "value");
				var do_ = FHIRHelpers_4_3_000.ToInterval(SecondHTN140Over90Encounter?.Period);
				var dp_ = context.Operators.ElementInInterval<CqlDateTime>(dn_, do_, "day");

				return dp_;
			};
			var dj_ = context.Operators.WhereOrNull<object>(dh_, di_);
			Encounter dk_(object SecondHTN140Over90DeclinedInterventions) => 
				SecondHTN140Over90Encounter;
			var dl_ = context.Operators.SelectOrNull<object, Encounter>(dj_, dk_);

			return dl_;
		};
		var u_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(s_, t_);
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

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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