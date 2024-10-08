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
[CqlLibrary("SevereObstetricComplicationsFHIR", "0.1.000")]
public class SevereObstetricComplicationsFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> ___20_to_42_Plus_Weeks_Gestation;
    internal Lazy<CqlValueSet> __Acute_or_Persistent_Asthma;
    internal Lazy<CqlValueSet> __Anemia;
    internal Lazy<CqlValueSet> __Autoimmune_Disease;
    internal Lazy<CqlValueSet> __Bariatric_Surgery;
    internal Lazy<CqlValueSet> __Bleeding_Disorder;
    internal Lazy<CqlValueSet> __Blood_Transfusion;
    internal Lazy<CqlValueSet> __Cardiac_Disease;
    internal Lazy<CqlValueSet> __COVID_19_Confirmed;
    internal Lazy<CqlValueSet> __Delivery_Procedures;
    internal Lazy<CqlValueSet> __Economic_Housing_Instability;
    internal Lazy<CqlValueSet> __ED_Visit_and_OB_Triage;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Gastrointestinal_Disease;
    internal Lazy<CqlValueSet> __Gestational_Diabetes;
    internal Lazy<CqlValueSet> __Hematocrit_lab_test;
    internal Lazy<CqlValueSet> __HIV_in_Pregnancy_Childbirth_and_Puerperium;
    internal Lazy<CqlValueSet> __Hypertension;
    internal Lazy<CqlValueSet> __Long_Term_Anticoagulant_Use;
    internal Lazy<CqlValueSet> __Mental_Health_Disorder;
    internal Lazy<CqlValueSet> __Mild_or_Moderate_Preeclampsia;
    internal Lazy<CqlValueSet> __Morbid_or_Severe_Obesity;
    internal Lazy<CqlValueSet> __Multiple_Pregnancy;
    internal Lazy<CqlValueSet> __Neuromuscular_Disease;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Placenta_Previa;
    internal Lazy<CqlValueSet> __Placental_Abruption;
    internal Lazy<CqlValueSet> __Placental_Accreta_Spectrum;
    internal Lazy<CqlValueSet> __Preexisting_Diabetes;
    internal Lazy<CqlValueSet> __Present_on_Admission_is_No_or_Unable_To_Determine;
    internal Lazy<CqlValueSet> __Present_On_Admission_is_Yes_or_Exempt;
    internal Lazy<CqlValueSet> __Preterm_Birth;
    internal Lazy<CqlValueSet> __Previous_Cesarean;
    internal Lazy<CqlValueSet> __Pulmonary_Hypertension;
    internal Lazy<CqlValueSet> __Renal_Disease;
    internal Lazy<CqlValueSet> __Respiratory_Conditions_Related_to_COVID_19;
    internal Lazy<CqlValueSet> __Respiratory_Support_Procedures_Related_to_COVID_19;
    internal Lazy<CqlValueSet> __Severe_Maternal_Morbidity_Diagnoses;
    internal Lazy<CqlValueSet> __Severe_Maternal_Morbidity_Procedures;
    internal Lazy<CqlValueSet> __Severe_Preeclampsia;
    internal Lazy<CqlValueSet> __Substance_Abuse;
    internal Lazy<CqlValueSet> __Thyrotoxicosis;
    internal Lazy<CqlValueSet> __Venous_Thromboembolism_in_Pregnancy;
    internal Lazy<CqlValueSet> __White_blood_cells_count_lab_test;
    internal Lazy<CqlCode> __Heart_rate;
    internal Lazy<CqlCode> __Systolic_blood_pressure;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_Expiration;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_Blood_Transfusion;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_Severe_Obstetric_Complications;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusion;
    internal Lazy<IEnumerable<Encounter>> __Stratification_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions;
    internal Lazy<IEnumerable<Encounter>> __Stratum_1;
    internal Lazy<IEnumerable<(string EncounterID, int? CalculatedCGA)?>> __Variable_Calculated_Gestational_Age;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Anemia;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Asthma;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Autoimmune_Disease;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Bariatric_Surgery;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Bleeding_Disorder;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Morbid_Obesity;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Cardiac_Disease;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Economic_Housing_Instability;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Gastrointestinal_Disease;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Gestational_Diabetes;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_HIV;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Hypertension;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Long_Term_Anticoagulant_Use;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Mental_Health_Disorder;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Multiple_Pregnancy;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Neuromuscular;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Obstetrical_VTE;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Placenta_Previa;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Placental_Abruption;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Placental_Accreta_Spectrum;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Preexisting_Diabetes;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Previous_Cesarean;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Pulmonary_Hypertension;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Renal_Disease;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Severe_Preeclampsia;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Substance_Abuse;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Thyrotoxicosis;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Other_Preeclampsia;
    internal Lazy<IEnumerable<Encounter>> __Risk_Variable_Preterm_Birth;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>> __Risk_Variable_First_Hematocrit_Lab_Test;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>> __Risk_Variable_First_White_Blood_Cell_Count_Lab_Test;
    internal Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>> __Risk_Variable_Heart_Rate;
    internal Lazy<IEnumerable<(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>> __Risk_Variable_Systolic_Blood_Pressure;

    #endregion
    public SevereObstetricComplicationsFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        PCMaternal_5_16_000 = new PCMaternal_5_16_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        ___20_to_42_Plus_Weeks_Gestation = new Lazy<CqlValueSet>(this._20_to_42_Plus_Weeks_Gestation_Value);
        __Acute_or_Persistent_Asthma = new Lazy<CqlValueSet>(this.Acute_or_Persistent_Asthma_Value);
        __Anemia = new Lazy<CqlValueSet>(this.Anemia_Value);
        __Autoimmune_Disease = new Lazy<CqlValueSet>(this.Autoimmune_Disease_Value);
        __Bariatric_Surgery = new Lazy<CqlValueSet>(this.Bariatric_Surgery_Value);
        __Bleeding_Disorder = new Lazy<CqlValueSet>(this.Bleeding_Disorder_Value);
        __Blood_Transfusion = new Lazy<CqlValueSet>(this.Blood_Transfusion_Value);
        __Cardiac_Disease = new Lazy<CqlValueSet>(this.Cardiac_Disease_Value);
        __COVID_19_Confirmed = new Lazy<CqlValueSet>(this.COVID_19_Confirmed_Value);
        __Delivery_Procedures = new Lazy<CqlValueSet>(this.Delivery_Procedures_Value);
        __Economic_Housing_Instability = new Lazy<CqlValueSet>(this.Economic_Housing_Instability_Value);
        __ED_Visit_and_OB_Triage = new Lazy<CqlValueSet>(this.ED_Visit_and_OB_Triage_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Gastrointestinal_Disease = new Lazy<CqlValueSet>(this.Gastrointestinal_Disease_Value);
        __Gestational_Diabetes = new Lazy<CqlValueSet>(this.Gestational_Diabetes_Value);
        __Hematocrit_lab_test = new Lazy<CqlValueSet>(this.Hematocrit_lab_test_Value);
        __HIV_in_Pregnancy_Childbirth_and_Puerperium = new Lazy<CqlValueSet>(this.HIV_in_Pregnancy_Childbirth_and_Puerperium_Value);
        __Hypertension = new Lazy<CqlValueSet>(this.Hypertension_Value);
        __Long_Term_Anticoagulant_Use = new Lazy<CqlValueSet>(this.Long_Term_Anticoagulant_Use_Value);
        __Mental_Health_Disorder = new Lazy<CqlValueSet>(this.Mental_Health_Disorder_Value);
        __Mild_or_Moderate_Preeclampsia = new Lazy<CqlValueSet>(this.Mild_or_Moderate_Preeclampsia_Value);
        __Morbid_or_Severe_Obesity = new Lazy<CqlValueSet>(this.Morbid_or_Severe_Obesity_Value);
        __Multiple_Pregnancy = new Lazy<CqlValueSet>(this.Multiple_Pregnancy_Value);
        __Neuromuscular_Disease = new Lazy<CqlValueSet>(this.Neuromuscular_Disease_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Placenta_Previa = new Lazy<CqlValueSet>(this.Placenta_Previa_Value);
        __Placental_Abruption = new Lazy<CqlValueSet>(this.Placental_Abruption_Value);
        __Placental_Accreta_Spectrum = new Lazy<CqlValueSet>(this.Placental_Accreta_Spectrum_Value);
        __Preexisting_Diabetes = new Lazy<CqlValueSet>(this.Preexisting_Diabetes_Value);
        __Present_on_Admission_is_No_or_Unable_To_Determine = new Lazy<CqlValueSet>(this.Present_on_Admission_is_No_or_Unable_To_Determine_Value);
        __Present_On_Admission_is_Yes_or_Exempt = new Lazy<CqlValueSet>(this.Present_On_Admission_is_Yes_or_Exempt_Value);
        __Preterm_Birth = new Lazy<CqlValueSet>(this.Preterm_Birth_Value);
        __Previous_Cesarean = new Lazy<CqlValueSet>(this.Previous_Cesarean_Value);
        __Pulmonary_Hypertension = new Lazy<CqlValueSet>(this.Pulmonary_Hypertension_Value);
        __Renal_Disease = new Lazy<CqlValueSet>(this.Renal_Disease_Value);
        __Respiratory_Conditions_Related_to_COVID_19 = new Lazy<CqlValueSet>(this.Respiratory_Conditions_Related_to_COVID_19_Value);
        __Respiratory_Support_Procedures_Related_to_COVID_19 = new Lazy<CqlValueSet>(this.Respiratory_Support_Procedures_Related_to_COVID_19_Value);
        __Severe_Maternal_Morbidity_Diagnoses = new Lazy<CqlValueSet>(this.Severe_Maternal_Morbidity_Diagnoses_Value);
        __Severe_Maternal_Morbidity_Procedures = new Lazy<CqlValueSet>(this.Severe_Maternal_Morbidity_Procedures_Value);
        __Severe_Preeclampsia = new Lazy<CqlValueSet>(this.Severe_Preeclampsia_Value);
        __Substance_Abuse = new Lazy<CqlValueSet>(this.Substance_Abuse_Value);
        __Thyrotoxicosis = new Lazy<CqlValueSet>(this.Thyrotoxicosis_Value);
        __Venous_Thromboembolism_in_Pregnancy = new Lazy<CqlValueSet>(this.Venous_Thromboembolism_in_Pregnancy_Value);
        __White_blood_cells_count_lab_test = new Lazy<CqlValueSet>(this.White_blood_cells_count_lab_test_Value);
        __Heart_rate = new Lazy<CqlCode>(this.Heart_rate_Value);
        __Systolic_blood_pressure = new Lazy<CqlCode>(this.Systolic_blood_pressure_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Value);
        __Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks_Value);
        __Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding_Value);
        __Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation_Value);
        __Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion_Value);
        __Delivery_Encounters_with_Expiration = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_Expiration_Value);
        __Delivery_Encounters_with_Blood_Transfusion = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_Blood_Transfusion_Value);
        __Delivery_Encounters_with_Severe_Obstetric_Complications = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_Severe_Obstetric_Complications_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure_Value);
        __Denominator_Exclusion = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusion_Value);
        __Stratification_Encounter = new Lazy<IEnumerable<Encounter>>(this.Stratification_Encounter_Value);
        __Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Value);
        __Stratum_1 = new Lazy<IEnumerable<Encounter>>(this.Stratum_1_Value);
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<(string EncounterID, int? CalculatedCGA)?>>(this.Variable_Calculated_Gestational_Age_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Risk_Variable_Anemia = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Anemia_Value);
        __Risk_Variable_Asthma = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Asthma_Value);
        __Risk_Variable_Autoimmune_Disease = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Autoimmune_Disease_Value);
        __Risk_Variable_Bariatric_Surgery = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Bariatric_Surgery_Value);
        __Risk_Variable_Bleeding_Disorder = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Bleeding_Disorder_Value);
        __Risk_Variable_Morbid_Obesity = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Morbid_Obesity_Value);
        __Risk_Variable_Cardiac_Disease = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Cardiac_Disease_Value);
        __Risk_Variable_Economic_Housing_Instability = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Economic_Housing_Instability_Value);
        __Risk_Variable_Gastrointestinal_Disease = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Gastrointestinal_Disease_Value);
        __Risk_Variable_Gestational_Diabetes = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Gestational_Diabetes_Value);
        __Risk_Variable_HIV = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_HIV_Value);
        __Risk_Variable_Hypertension = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Hypertension_Value);
        __Risk_Variable_Long_Term_Anticoagulant_Use = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Long_Term_Anticoagulant_Use_Value);
        __Risk_Variable_Mental_Health_Disorder = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Mental_Health_Disorder_Value);
        __Risk_Variable_Multiple_Pregnancy = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Multiple_Pregnancy_Value);
        __Risk_Variable_Neuromuscular = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Neuromuscular_Value);
        __Risk_Variable_Obstetrical_VTE = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Obstetrical_VTE_Value);
        __Risk_Variable_Placenta_Previa = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Placenta_Previa_Value);
        __Risk_Variable_Placental_Abruption = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Placental_Abruption_Value);
        __Risk_Variable_Placental_Accreta_Spectrum = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Placental_Accreta_Spectrum_Value);
        __Risk_Variable_Preexisting_Diabetes = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Preexisting_Diabetes_Value);
        __Risk_Variable_Previous_Cesarean = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Previous_Cesarean_Value);
        __Risk_Variable_Pulmonary_Hypertension = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Pulmonary_Hypertension_Value);
        __Risk_Variable_Renal_Disease = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Renal_Disease_Value);
        __Risk_Variable_Severe_Preeclampsia = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Severe_Preeclampsia_Value);
        __Risk_Variable_Substance_Abuse = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Substance_Abuse_Value);
        __Risk_Variable_Thyrotoxicosis = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Thyrotoxicosis_Value);
        __Risk_Variable_Other_Preeclampsia = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Other_Preeclampsia_Value);
        __Risk_Variable_Preterm_Birth = new Lazy<IEnumerable<Encounter>>(this.Risk_Variable_Preterm_Birth_Value);
        __Risk_Variable_First_Hematocrit_Lab_Test = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>>(this.Risk_Variable_First_Hematocrit_Lab_Test_Value);
        __Risk_Variable_First_White_Blood_Cell_Count_Lab_Test = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>>(this.Risk_Variable_First_White_Blood_Cell_Count_Lab_Test_Value);
        __Risk_Variable_Heart_Rate = new Lazy<IEnumerable<(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>>(this.Risk_Variable_Heart_Rate_Value);
        __Risk_Variable_Systolic_Blood_Pressure = new Lazy<IEnumerable<(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>>(this.Risk_Variable_Systolic_Blood_Pressure_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public PCMaternal_5_16_000 PCMaternal_5_16_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet _20_to_42_Plus_Weeks_Gestation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67", default);

    [CqlDeclaration("20 to 42 Plus Weeks Gestation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67")]
	public CqlValueSet _20_to_42_Plus_Weeks_Gestation() => 
		___20_to_42_Plus_Weeks_Gestation.Value;

	private CqlValueSet Acute_or_Persistent_Asthma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271", default);

    [CqlDeclaration("Acute or Persistent Asthma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271")]
	public CqlValueSet Acute_or_Persistent_Asthma() => 
		__Acute_or_Persistent_Asthma.Value;

	private CqlValueSet Anemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323", default);

    [CqlDeclaration("Anemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323")]
	public CqlValueSet Anemia() => 
		__Anemia.Value;

	private CqlValueSet Autoimmune_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311", default);

    [CqlDeclaration("Autoimmune Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311")]
	public CqlValueSet Autoimmune_Disease() => 
		__Autoimmune_Disease.Value;

	private CqlValueSet Bariatric_Surgery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317", default);

    [CqlDeclaration("Bariatric Surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317")]
	public CqlValueSet Bariatric_Surgery() => 
		__Bariatric_Surgery.Value;

	private CqlValueSet Bleeding_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287", default);

    [CqlDeclaration("Bleeding Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287")]
	public CqlValueSet Bleeding_Disorder() => 
		__Bleeding_Disorder.Value;

	private CqlValueSet Blood_Transfusion_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213", default);

    [CqlDeclaration("Blood Transfusion")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213")]
	public CqlValueSet Blood_Transfusion() => 
		__Blood_Transfusion.Value;

	private CqlValueSet Cardiac_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341", default);

    [CqlDeclaration("Cardiac Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341")]
	public CqlValueSet Cardiac_Disease() => 
		__Cardiac_Disease.Value;

	private CqlValueSet COVID_19_Confirmed_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373", default);

    [CqlDeclaration("COVID 19 Confirmed")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373")]
	public CqlValueSet COVID_19_Confirmed() => 
		__COVID_19_Confirmed.Value;

	private CqlValueSet Delivery_Procedures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", default);

    [CqlDeclaration("Delivery Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59")]
	public CqlValueSet Delivery_Procedures() => 
		__Delivery_Procedures.Value;

	private CqlValueSet Economic_Housing_Instability_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292", default);

    [CqlDeclaration("Economic Housing Instability")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292")]
	public CqlValueSet Economic_Housing_Instability() => 
		__Economic_Housing_Instability.Value;

	private CqlValueSet ED_Visit_and_OB_Triage_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", default);

    [CqlDeclaration("ED Visit and OB Triage")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369")]
	public CqlValueSet ED_Visit_and_OB_Triage() => 
		__ED_Visit_and_OB_Triage.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Gastrointestinal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338", default);

    [CqlDeclaration("Gastrointestinal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338")]
	public CqlValueSet Gastrointestinal_Disease() => 
		__Gastrointestinal_Disease.Value;

	private CqlValueSet Gestational_Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269", default);

    [CqlDeclaration("Gestational Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269")]
	public CqlValueSet Gestational_Diabetes() => 
		__Gestational_Diabetes.Value;

	private CqlValueSet Hematocrit_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", default);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public CqlValueSet Hematocrit_lab_test() => 
		__Hematocrit_lab_test.Value;

	private CqlValueSet HIV_in_Pregnancy_Childbirth_and_Puerperium_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272", default);

    [CqlDeclaration("HIV in Pregnancy Childbirth and Puerperium")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272")]
	public CqlValueSet HIV_in_Pregnancy_Childbirth_and_Puerperium() => 
		__HIV_in_Pregnancy_Childbirth_and_Puerperium.Value;

	private CqlValueSet Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332", default);

    [CqlDeclaration("Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332")]
	public CqlValueSet Hypertension() => 
		__Hypertension.Value;

	private CqlValueSet Long_Term_Anticoagulant_Use_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366", default);

    [CqlDeclaration("Long Term Anticoagulant Use")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366")]
	public CqlValueSet Long_Term_Anticoagulant_Use() => 
		__Long_Term_Anticoagulant_Use.Value;

	private CqlValueSet Mental_Health_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314", default);

    [CqlDeclaration("Mental Health Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314")]
	public CqlValueSet Mental_Health_Disorder() => 
		__Mental_Health_Disorder.Value;

	private CqlValueSet Mild_or_Moderate_Preeclampsia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329", default);

    [CqlDeclaration("Mild or Moderate Preeclampsia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329")]
	public CqlValueSet Mild_or_Moderate_Preeclampsia() => 
		__Mild_or_Moderate_Preeclampsia.Value;

	private CqlValueSet Morbid_or_Severe_Obesity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290", default);

    [CqlDeclaration("Morbid or Severe Obesity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290")]
	public CqlValueSet Morbid_or_Severe_Obesity() => 
		__Morbid_or_Severe_Obesity.Value;

	private CqlValueSet Multiple_Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284", default);

    [CqlDeclaration("Multiple Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284")]
	public CqlValueSet Multiple_Pregnancy() => 
		__Multiple_Pregnancy.Value;

	private CqlValueSet Neuromuscular_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308", default);

    [CqlDeclaration("Neuromuscular Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308")]
	public CqlValueSet Neuromuscular_Disease() => 
		__Neuromuscular_Disease.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Placenta_Previa_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.35", default);

    [CqlDeclaration("Placenta Previa")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.35")]
	public CqlValueSet Placenta_Previa() => 
		__Placenta_Previa.Value;

	private CqlValueSet Placental_Abruption_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305", default);

    [CqlDeclaration("Placental Abruption")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305")]
	public CqlValueSet Placental_Abruption() => 
		__Placental_Abruption.Value;

	private CqlValueSet Placental_Accreta_Spectrum_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", default);

    [CqlDeclaration("Placental Accreta Spectrum")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302")]
	public CqlValueSet Placental_Accreta_Spectrum() => 
		__Placental_Accreta_Spectrum.Value;

	private CqlValueSet Preexisting_Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275", default);

    [CqlDeclaration("Preexisting Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275")]
	public CqlValueSet Preexisting_Diabetes() => 
		__Preexisting_Diabetes.Value;

	private CqlValueSet Present_on_Admission_is_No_or_Unable_To_Determine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370", default);

    [CqlDeclaration("Present on Admission is No or Unable To Determine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370")]
	public CqlValueSet Present_on_Admission_is_No_or_Unable_To_Determine() => 
		__Present_on_Admission_is_No_or_Unable_To_Determine.Value;

	private CqlValueSet Present_On_Admission_is_Yes_or_Exempt_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63", default);

    [CqlDeclaration("Present On Admission is Yes or Exempt")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63")]
	public CqlValueSet Present_On_Admission_is_Yes_or_Exempt() => 
		__Present_On_Admission_is_Yes_or_Exempt.Value;

	private CqlValueSet Preterm_Birth_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299", default);

    [CqlDeclaration("Preterm Birth")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299")]
	public CqlValueSet Preterm_Birth() => 
		__Preterm_Birth.Value;

	private CqlValueSet Previous_Cesarean_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278", default);

    [CqlDeclaration("Previous Cesarean")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278")]
	public CqlValueSet Previous_Cesarean() => 
		__Previous_Cesarean.Value;

	private CqlValueSet Pulmonary_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281", default);

    [CqlDeclaration("Pulmonary Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281")]
	public CqlValueSet Pulmonary_Hypertension() => 
		__Pulmonary_Hypertension.Value;

	private CqlValueSet Renal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335", default);

    [CqlDeclaration("Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335")]
	public CqlValueSet Renal_Disease() => 
		__Renal_Disease.Value;

	private CqlValueSet Respiratory_Conditions_Related_to_COVID_19_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376", default);

    [CqlDeclaration("Respiratory Conditions Related to COVID 19")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376")]
	public CqlValueSet Respiratory_Conditions_Related_to_COVID_19() => 
		__Respiratory_Conditions_Related_to_COVID_19.Value;

	private CqlValueSet Respiratory_Support_Procedures_Related_to_COVID_19_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379", default);

    [CqlDeclaration("Respiratory Support Procedures Related to COVID 19")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379")]
	public CqlValueSet Respiratory_Support_Procedures_Related_to_COVID_19() => 
		__Respiratory_Support_Procedures_Related_to_COVID_19.Value;

	private CqlValueSet Severe_Maternal_Morbidity_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255", default);

    [CqlDeclaration("Severe Maternal Morbidity Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255")]
	public CqlValueSet Severe_Maternal_Morbidity_Diagnoses() => 
		__Severe_Maternal_Morbidity_Diagnoses.Value;

	private CqlValueSet Severe_Maternal_Morbidity_Procedures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256", default);

    [CqlDeclaration("Severe Maternal Morbidity Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256")]
	public CqlValueSet Severe_Maternal_Morbidity_Procedures() => 
		__Severe_Maternal_Morbidity_Procedures.Value;

	private CqlValueSet Severe_Preeclampsia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327", default);

    [CqlDeclaration("Severe Preeclampsia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327")]
	public CqlValueSet Severe_Preeclampsia() => 
		__Severe_Preeclampsia.Value;

	private CqlValueSet Substance_Abuse_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320", default);

    [CqlDeclaration("Substance Abuse")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320")]
	public CqlValueSet Substance_Abuse() => 
		__Substance_Abuse.Value;

	private CqlValueSet Thyrotoxicosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296", default);

    [CqlDeclaration("Thyrotoxicosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296")]
	public CqlValueSet Thyrotoxicosis() => 
		__Thyrotoxicosis.Value;

	private CqlValueSet Venous_Thromboembolism_in_Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363", default);

    [CqlDeclaration("Venous Thromboembolism in Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363")]
	public CqlValueSet Venous_Thromboembolism_in_Pregnancy() => 
		__Venous_Thromboembolism_in_Pregnancy.Value;

	private CqlValueSet White_blood_cells_count_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", default);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
	public CqlValueSet White_blood_cells_count_lab_test() => 
		__White_blood_cells_count_lab_test.Value;

	private CqlCode Heart_rate_Value() => 
		new CqlCode("8867-4", "http://loinc.org", default, default);

    [CqlDeclaration("Heart rate")]
	public CqlCode Heart_rate() => 
		__Heart_rate.Value;

	private CqlCode Systolic_blood_pressure_Value() => 
		new CqlCode("8480-6", "http://loinc.org", default, default);

    [CqlDeclaration("Systolic blood pressure")]
	public CqlCode Systolic_blood_pressure() => 
		__Systolic_blood_pressure.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("8867-4", "http://loinc.org", default, default),
			new CqlCode("8480-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = []
;

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
		object d_ = context.ResolveParameter("SevereObstetricComplicationsFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

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

	private IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			bool? e_ = context.Operators.GreaterOrEqual(d_, 20);

			return e_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Calculated Gestational Age Greater than or Equal to 20 Weeks")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks() => 
		__Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			CqlQuantity e_ = PCMaternal_5_16_000.lastEstimatedGestationalAge(DeliveryEncounter);
			CqlQuantity f_ = context.Operators.Quantity(20m, "weeks");
			bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
			bool? h_ = context.Operators.And((bool?)(d_ is null), g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Estimated Gestational Age Assessment Greater than or Equal to 20 Weeks")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks() => 
		__Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			CqlQuantity e_ = PCMaternal_5_16_000.lastEstimatedGestationalAge(DeliveryEncounter);
			bool? f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
			IEnumerable<Condition> g_ = CQMCommon_2_0_000.encounterDiagnosis(DeliveryEncounter);
			bool? h_(Condition EncounterDiagnosis)
			{
				CodeableConcept l_ = EncounterDiagnosis?.Code;
				CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
				CqlValueSet n_ = this._20_to_42_Plus_Weeks_Gestation();
				bool? o_ = context.Operators.ConceptInValueSet(m_, n_);

				return o_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			bool? j_ = context.Operators.Exists<Condition>(i_);
			bool? k_ = context.Operators.And(f_, j_);

			return k_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Gestational Age Greater than or Equal to 20 Weeks Based on Coding")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding() => 
		__Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding.Value;

	private IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks();
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding();
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Delivery Encounters At Greater than or Equal to 20 Weeks Gestation")]
	public IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation() => 
		__Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			List<Encounter.DiagnosisComponent> d_ = TwentyWeeksPlusEncounter?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent EncounterDiagnoses)
			{
				ResourceReference n_ = EncounterDiagnoses?.Condition;
				Condition o_ = CQMCommon_2_0_000.getCondition(n_);
				CodeableConcept p_ = o_?.Code;
				CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(p_);
				CqlValueSet r_ = this.Severe_Maternal_Morbidity_Diagnoses();
				bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
				bool? t_(Extension @this)
				{
					string ac_ = @this?.Url;
					FhirString ad_ = context.Operators.Convert<FhirString>(ac_);
					string ae_ = FHIRHelpers_4_3_000.ToString(ad_);
					bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return af_;
				};
				IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
						? (EncounterDiagnoses as Element).Extension
						: default), t_);
				object v_(Extension @this)
				{
					DataType ag_ = @this?.Value;

					return ag_;
				};
				IEnumerable<object> w_ = context.Operators.Select<Extension, object>(u_, v_);
				object x_ = context.Operators.SingletonFrom<object>(w_);
				CqlConcept y_ = FHIRHelpers_4_3_000.ToConcept(x_ as CodeableConcept);
				CqlValueSet z_ = this.Present_on_Admission_is_No_or_Unable_To_Determine();
				bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
				bool? ab_ = context.Operators.And(s_, aa_);

				return ab_;
			};
			IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);
			CqlValueSet h_ = this.Severe_Maternal_Morbidity_Procedures();
			IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? j_(Procedure EncounterSMMProcedures)
			{
				Code<EventStatus> ah_ = EncounterSMMProcedures?.StatusElement;
				EventStatus? ai_ = ah_?.Value;
				string aj_ = context.Operators.Convert<string>(ai_);
				bool? ak_ = context.Operators.Equal(aj_, "completed");
				DataType al_ = EncounterSMMProcedures?.Performed;
				object am_ = FHIRHelpers_4_3_000.ToValue(al_);
				CqlInterval<CqlDateTime> an_ = QICoreCommon_2_0_000.toInterval(am_);
				CqlDateTime ao_ = context.Operators.Start(an_);
				CqlInterval<CqlDateTime> ap_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				bool? aq_ = context.Operators.In<CqlDateTime>(ao_, ap_, "day");
				bool? ar_ = context.Operators.And(ak_, aq_);

				return ar_;
			};
			IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>(i_, j_);
			bool? l_ = context.Operators.Exists<Procedure>(k_);
			bool? m_ = context.Operators.Or(g_, l_);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Severe Obstetric Complications Diagnosis or Procedure Excluding Blood Transfusion")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion() => 
		__Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_Expiration_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Encounter.HospitalizationComponent d_ = TwentyWeeksPlusEncounter?.Hospitalization;
			CodeableConcept e_ = d_?.DischargeDisposition;
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(e_);
			CqlValueSet g_ = this.Patient_Expired();
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Expiration")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Expiration() => 
		__Delivery_Encounters_with_Expiration.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		IEnumerable<Encounter> b_(Encounter TwentyWeeksPlusEncounter)
		{
			CqlValueSet d_ = this.Blood_Transfusion();
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? f_(Procedure BloodTransfusion)
			{
				Code<EventStatus> j_ = BloodTransfusion?.StatusElement;
				EventStatus? k_ = j_?.Value;
				string l_ = context.Operators.Convert<string>(k_);
				bool? m_ = context.Operators.Equal(l_, "completed");
				DataType n_ = BloodTransfusion?.Performed;
				object o_ = FHIRHelpers_4_3_000.ToValue(n_);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.toInterval(o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				CqlInterval<CqlDateTime> r_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
				bool? t_ = context.Operators.And(m_, s_);

				return t_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure BloodTransfusion) => 
				TwentyWeeksPlusEncounter;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Blood Transfusion")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion() => 
		__Delivery_Encounters_with_Blood_Transfusion.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion();
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Expiration();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Delivery_Encounters_with_Blood_Transfusion();
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Delivery Encounters with Severe Obstetric Complications")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications() => 
		__Delivery_Encounters_with_Severe_Obstetric_Complications.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<Condition> d_ = CQMCommon_2_0_000.encounterDiagnosis(TwentyWeeksPlusEncounter);
			bool? e_(Condition EncounterDiagnosis)
			{
				CodeableConcept s_ = EncounterDiagnosis?.Code;
				CqlConcept t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				CqlValueSet u_ = this.COVID_19_Confirmed();
				bool? v_ = context.Operators.ConceptInValueSet(t_, u_);

				return v_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);
			bool? i_(Condition EncounterDiagnosis)
			{
				CodeableConcept w_ = EncounterDiagnosis?.Code;
				CqlConcept x_ = FHIRHelpers_4_3_000.ToConcept(w_);
				CqlValueSet y_ = this.Respiratory_Conditions_Related_to_COVID_19();
				bool? z_ = context.Operators.ConceptInValueSet(x_, y_);

				return z_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(d_, i_);
			bool? k_ = context.Operators.Exists<Condition>(j_);
			CqlValueSet l_ = this.Respiratory_Support_Procedures_Related_to_COVID_19();
			IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? n_(Procedure COVIDRespiratoryProcedure)
			{
				Code<EventStatus> aa_ = COVIDRespiratoryProcedure?.StatusElement;
				EventStatus? ab_ = aa_?.Value;
				string ac_ = context.Operators.Convert<string>(ab_);
				bool? ad_ = context.Operators.Equal(ac_, "completed");
				DataType ae_ = COVIDRespiratoryProcedure?.Performed;
				object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
				CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.toInterval(af_);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				CqlInterval<CqlDateTime> ai_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				bool? aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, "day");
				bool? ak_ = context.Operators.And(ad_, aj_);

				return ak_;
			};
			IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
			bool? p_ = context.Operators.Exists<Procedure>(o_);
			bool? q_ = context.Operators.Or(k_, p_);
			bool? r_ = context.Operators.And(g_, q_);

			return r_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with COVID and Respiratory Condition or Procedure")]
	public IEnumerable<Encounter> Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure() => 
		__Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure.Value;

	private IEnumerable<Encounter> Denominator_Exclusion_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure();

		return a_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public IEnumerable<Encounter> Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

	private IEnumerable<Encounter> Stratification_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.Numerator();
		IEnumerable<Encounter> b_ = this.Denominator_Exclusion();
		IEnumerable<Encounter> c_ = context.Operators.Except<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Stratification Encounter")]
	public IEnumerable<Encounter> Stratification_Encounter() => 
		__Stratification_Encounter.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion();
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Expiration();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions() => 
		__Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions.Value;

	private IEnumerable<Encounter> Stratum_1_Value()
	{
		IEnumerable<Encounter> a_ = this.Stratification_Encounter();
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions();
		IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Stratum 1")]
	public IEnumerable<Encounter> Stratum_1() => 
		__Stratum_1.Value;

	private IEnumerable<(string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age_Value()
	{
		IEnumerable<(string EncounterID, int? CalculatedCGA)?> a_ = PCMaternal_5_16_000.Variable_Calculated_Gestational_Age();

		return a_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<(string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age() => 
		__Variable_Calculated_Gestational_Age.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

    [CqlDeclaration("pOAIsYesOrExempt")]
	public IEnumerable<CqlConcept> pOAIsYesOrExempt(Encounter TheEncounter)
	{
		List<Encounter.DiagnosisComponent> a_ = TheEncounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			bool? f_(Extension @this)
			{
				string n_ = @this?.Url;
				FhirString o_ = context.Operators.Convert<FhirString>(n_);
				string p_ = FHIRHelpers_4_3_000.ToString(o_);
				bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

				return q_;
			};
			IEnumerable<Extension> g_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
					? (EncounterDiagnoses as Element).Extension
					: default), f_);
			object h_(Extension @this)
			{
				DataType r_ = @this?.Value;

				return r_;
			};
			IEnumerable<object> i_ = context.Operators.Select<Extension, object>(g_, h_);
			object j_ = context.Operators.SingletonFrom<object>(i_);
			CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_ as CodeableConcept);
			CqlValueSet l_ = this.Present_On_Admission_is_Yes_or_Exempt();
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);

			return m_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		CqlConcept d_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			ResourceReference s_ = EncounterDiagnoses?.Condition;
			Condition t_ = CQMCommon_2_0_000.getCondition(s_);
			CodeableConcept u_ = t_?.Code;
			CqlConcept v_ = FHIRHelpers_4_3_000.ToConcept(u_);

			return v_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(c_, d_);

		return e_;
	}

	private IEnumerable<Encounter> Risk_Variable_Anemia_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Anemia();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Anemia")]
	public IEnumerable<Encounter> Risk_Variable_Anemia() => 
		__Risk_Variable_Anemia.Value;

	private IEnumerable<Encounter> Risk_Variable_Asthma_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Acute_or_Persistent_Asthma();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Asthma")]
	public IEnumerable<Encounter> Risk_Variable_Asthma() => 
		__Risk_Variable_Asthma.Value;

	private IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Autoimmune_Disease();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Autoimmune Disease")]
	public IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease() => 
		__Risk_Variable_Autoimmune_Disease.Value;

	private IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Bariatric_Surgery();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Bariatric Surgery")]
	public IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery() => 
		__Risk_Variable_Bariatric_Surgery.Value;

	private IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Bleeding_Disorder();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Bleeding Disorder")]
	public IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder() => 
		__Risk_Variable_Bleeding_Disorder.Value;

	private IEnumerable<Encounter> Risk_Variable_Morbid_Obesity_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Morbid_or_Severe_Obesity();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Morbid Obesity")]
	public IEnumerable<Encounter> Risk_Variable_Morbid_Obesity() => 
		__Risk_Variable_Morbid_Obesity.Value;

	private IEnumerable<Encounter> Risk_Variable_Cardiac_Disease_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Cardiac_Disease();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Cardiac Disease")]
	public IEnumerable<Encounter> Risk_Variable_Cardiac_Disease() => 
		__Risk_Variable_Cardiac_Disease.Value;

	private IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Economic_Housing_Instability();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Economic Housing Instability")]
	public IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability() => 
		__Risk_Variable_Economic_Housing_Instability.Value;

	private IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Gastrointestinal_Disease();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Gastrointestinal Disease")]
	public IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease() => 
		__Risk_Variable_Gastrointestinal_Disease.Value;

	private IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Gestational_Diabetes();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Gestational Diabetes")]
	public IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes() => 
		__Risk_Variable_Gestational_Diabetes.Value;

	private IEnumerable<Encounter> Risk_Variable_HIV_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable HIV")]
	public IEnumerable<Encounter> Risk_Variable_HIV() => 
		__Risk_Variable_HIV.Value;

	private IEnumerable<Encounter> Risk_Variable_Hypertension_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Hypertension();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Hypertension")]
	public IEnumerable<Encounter> Risk_Variable_Hypertension() => 
		__Risk_Variable_Hypertension.Value;

	private IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Long_Term_Anticoagulant_Use();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Long Term Anticoagulant Use")]
	public IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use() => 
		__Risk_Variable_Long_Term_Anticoagulant_Use.Value;

	private IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Mental_Health_Disorder();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Mental Health Disorder")]
	public IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder() => 
		__Risk_Variable_Mental_Health_Disorder.Value;

	private IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Multiple_Pregnancy();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Multiple Pregnancy")]
	public IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy() => 
		__Risk_Variable_Multiple_Pregnancy.Value;

	private IEnumerable<Encounter> Risk_Variable_Neuromuscular_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Neuromuscular_Disease();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Neuromuscular")]
	public IEnumerable<Encounter> Risk_Variable_Neuromuscular() => 
		__Risk_Variable_Neuromuscular.Value;

	private IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Venous_Thromboembolism_in_Pregnancy();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Obstetrical VTE")]
	public IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE() => 
		__Risk_Variable_Obstetrical_VTE.Value;

	private IEnumerable<Encounter> Risk_Variable_Placenta_Previa_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Placenta_Previa();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Placenta Previa")]
	public IEnumerable<Encounter> Risk_Variable_Placenta_Previa() => 
		__Risk_Variable_Placenta_Previa.Value;

	private IEnumerable<Encounter> Risk_Variable_Placental_Abruption_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Placental_Abruption();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Placental Abruption")]
	public IEnumerable<Encounter> Risk_Variable_Placental_Abruption() => 
		__Risk_Variable_Placental_Abruption.Value;

	private IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Placental_Accreta_Spectrum();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Placental Accreta Spectrum")]
	public IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum() => 
		__Risk_Variable_Placental_Accreta_Spectrum.Value;

	private IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Preexisting_Diabetes();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Preexisting Diabetes")]
	public IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes() => 
		__Risk_Variable_Preexisting_Diabetes.Value;

	private IEnumerable<Encounter> Risk_Variable_Previous_Cesarean_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Previous_Cesarean();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Previous Cesarean")]
	public IEnumerable<Encounter> Risk_Variable_Previous_Cesarean() => 
		__Risk_Variable_Previous_Cesarean.Value;

	private IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Pulmonary_Hypertension();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Pulmonary Hypertension")]
	public IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension() => 
		__Risk_Variable_Pulmonary_Hypertension.Value;

	private IEnumerable<Encounter> Risk_Variable_Renal_Disease_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Renal_Disease();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Renal Disease")]
	public IEnumerable<Encounter> Risk_Variable_Renal_Disease() => 
		__Risk_Variable_Renal_Disease.Value;

	private IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Severe_Preeclampsia();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Severe Preeclampsia")]
	public IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia() => 
		__Risk_Variable_Severe_Preeclampsia.Value;

	private IEnumerable<Encounter> Risk_Variable_Substance_Abuse_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Substance_Abuse();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Substance Abuse")]
	public IEnumerable<Encounter> Risk_Variable_Substance_Abuse() => 
		__Risk_Variable_Substance_Abuse.Value;

	private IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Thyrotoxicosis();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Thyrotoxicosis")]
	public IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis() => 
		__Risk_Variable_Thyrotoxicosis.Value;

	private IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Mild_or_Moderate_Preeclampsia();
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Other Preeclampsia")]
	public IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia() => 
		__Risk_Variable_Other_Preeclampsia.Value;

	private IEnumerable<Encounter> Risk_Variable_Preterm_Birth_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			int? h_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			CqlInterval<int?> i_ = context.Operators.Interval(20, 36, true, true);
			bool? j_ = context.Operators.In<int?>(h_, i_, default);
			CqlQuantity l_ = PCMaternal_5_16_000.lastEstimatedGestationalAge(DeliveryEncounter);
			CqlQuantity m_ = context.Operators.Quantity(20m, "weeks");
			bool? n_ = context.Operators.GreaterOrEqual(l_, m_);
			CqlQuantity p_ = context.Operators.Quantity(36m, "weeks");
			bool? q_ = context.Operators.LessOrEqual(l_, p_);
			bool? r_ = context.Operators.And(n_, q_);
			bool? s_ = context.Operators.And((bool?)(h_ is null), r_);
			bool? t_ = context.Operators.Or(j_, s_);

			return t_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? e_(Encounter DeliveryEncounter)
		{
			int? u_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			CqlQuantity v_ = PCMaternal_5_16_000.lastEstimatedGestationalAge(DeliveryEncounter);
			bool? w_ = context.Operators.And((bool?)(u_ is null), (bool?)(v_ is null));
			IEnumerable<CqlConcept> x_ = this.pOAIsYesOrExempt(DeliveryEncounter);
			CqlValueSet y_ = this.Preterm_Birth();
			bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
			bool? aa_ = context.Operators.And(w_, z_);

			return aa_;
		};
		IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Risk Variable Preterm Birth")]
	public IEnumerable<Encounter> Risk_Variable_Preterm_Birth() => 
		__Risk_Variable_Preterm_Birth.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Id d_ = TwentyWeeksPlusEncounter?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Hematocrit_lab_test();
			IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
			bool? h_(Observation Hematocrit)
			{
				Instant z_ = Hematocrit?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlInterval<CqlDateTime> ac_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime ad_ = context.Operators.Start(ac_);
				CqlQuantity ae_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
				CqlDateTime ag_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(af_, ag_, true, false);
				bool? ai_ = context.Operators.In<CqlDateTime>(ab_, ah_, default);
				Code<ObservationStatus> aj_ = Hematocrit?.StatusElement;
				ObservationStatus? ak_ = aj_?.Value;
				string al_ = context.Operators.Convert<string>(ak_);
				string[] am_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? an_ = context.Operators.In<string>(al_, am_ as IEnumerable<string>);
				bool? ao_ = context.Operators.And(ai_, an_);
				DataType ap_ = Hematocrit?.Value;
				object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
				bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
				bool? as_ = context.Operators.And(ao_, ar_);

				return as_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant at_ = @this?.IssuedElement;
				DateTimeOffset? au_ = at_?.Value;
				CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
				CqlDateTime aw_ = QICoreCommon_2_0_000.earliest(av_ as object);

				return aw_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			IEnumerable<Observation> p_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
			bool? q_(Observation Hematocrit)
			{
				Instant ax_ = Hematocrit?.IssuedElement;
				DateTimeOffset? ay_ = ax_?.Value;
				CqlDateTime az_ = context.Operators.Convert<CqlDateTime>(ay_);
				CqlInterval<CqlDateTime> ba_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime bb_ = context.Operators.Start(ba_);
				CqlQuantity bc_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bd_ = context.Operators.Subtract(bb_, bc_);
				CqlDateTime be_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> bf_ = context.Operators.Interval(bd_, be_, true, false);
				bool? bg_ = context.Operators.In<CqlDateTime>(az_, bf_, default);
				Code<ObservationStatus> bh_ = Hematocrit?.StatusElement;
				ObservationStatus? bi_ = bh_?.Value;
				string bj_ = context.Operators.Convert<string>(bi_);
				string[] bk_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bl_ = context.Operators.In<string>(bj_, bk_ as IEnumerable<string>);
				bool? bm_ = context.Operators.And(bg_, bl_);
				DataType bn_ = Hematocrit?.Value;
				object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
				bool? bp_ = context.Operators.Not((bool?)(bo_ is null));
				bool? bq_ = context.Operators.And(bm_, bp_);

				return bq_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant br_ = @this?.IssuedElement;
				DateTimeOffset? bs_ = br_?.Value;
				CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
				CqlDateTime bu_ = QICoreCommon_2_0_000.earliest(bt_ as object);

				return bu_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable First Hematocrit Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test() => 
		__Risk_Variable_First_Hematocrit_Lab_Test.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Id d_ = TwentyWeeksPlusEncounter?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.White_blood_cells_count_lab_test();
			IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
			bool? h_(Observation WBC)
			{
				Instant z_ = WBC?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlInterval<CqlDateTime> ac_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime ad_ = context.Operators.Start(ac_);
				CqlQuantity ae_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
				CqlDateTime ag_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(af_, ag_, true, false);
				bool? ai_ = context.Operators.In<CqlDateTime>(ab_, ah_, default);
				Code<ObservationStatus> aj_ = WBC?.StatusElement;
				ObservationStatus? ak_ = aj_?.Value;
				string al_ = context.Operators.Convert<string>(ak_);
				string[] am_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? an_ = context.Operators.In<string>(al_, am_ as IEnumerable<string>);
				bool? ao_ = context.Operators.And(ai_, an_);
				DataType ap_ = WBC?.Value;
				object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
				bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
				bool? as_ = context.Operators.And(ao_, ar_);

				return as_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant at_ = @this?.IssuedElement;
				DateTimeOffset? au_ = at_?.Value;
				CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
				CqlDateTime aw_ = QICoreCommon_2_0_000.earliest(av_ as object);

				return aw_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			IEnumerable<Observation> p_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
			bool? q_(Observation WBC)
			{
				Instant ax_ = WBC?.IssuedElement;
				DateTimeOffset? ay_ = ax_?.Value;
				CqlDateTime az_ = context.Operators.Convert<CqlDateTime>(ay_);
				CqlInterval<CqlDateTime> ba_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime bb_ = context.Operators.Start(ba_);
				CqlQuantity bc_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bd_ = context.Operators.Subtract(bb_, bc_);
				CqlDateTime be_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> bf_ = context.Operators.Interval(bd_, be_, true, false);
				bool? bg_ = context.Operators.In<CqlDateTime>(az_, bf_, default);
				Code<ObservationStatus> bh_ = WBC?.StatusElement;
				ObservationStatus? bi_ = bh_?.Value;
				string bj_ = context.Operators.Convert<string>(bi_);
				string[] bk_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bl_ = context.Operators.In<string>(bj_, bk_ as IEnumerable<string>);
				bool? bm_ = context.Operators.And(bg_, bl_);
				DataType bn_ = WBC?.Value;
				object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
				bool? bp_ = context.Operators.Not((bool?)(bo_ is null));
				bool? bq_ = context.Operators.And(bm_, bp_);

				return bq_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant br_ = @this?.IssuedElement;
				DateTimeOffset? bs_ = br_?.Value;
				CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
				CqlDateTime bu_ = QICoreCommon_2_0_000.earliest(bt_ as object);

				return bu_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable First White Blood Cell Count Lab Test")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test() => 
		__Risk_Variable_First_White_Blood_Cell_Count_Lab_Test.Value;

	private IEnumerable<(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Id d_ = TwentyWeeksPlusEncounter?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
			bool? g_(Observation HeartRate)
			{
				DataType x_ = HeartRate?.Effective;
				object y_ = FHIRHelpers_4_3_000.ToValue(x_);
				CqlDateTime z_ = QICoreCommon_2_0_000.earliest(y_);
				CqlInterval<CqlDateTime> aa_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlQuantity ac_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
				CqlDateTime ae_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ad_, ae_, true, false);
				bool? ag_ = context.Operators.In<CqlDateTime>(z_, af_, default);
				Code<ObservationStatus> ah_ = HeartRate?.StatusElement;
				ObservationStatus? ai_ = ah_?.Value;
				string aj_ = context.Operators.Convert<string>(ai_);
				string[] ak_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? al_ = context.Operators.In<string>(aj_, ak_ as IEnumerable<string>);
				bool? am_ = context.Operators.And(ag_, al_);

				return am_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType an_ = @this?.Effective;
				object ao_ = FHIRHelpers_4_3_000.ToValue(an_);
				CqlDateTime ap_ = QICoreCommon_2_0_000.earliest(ao_);

				return ap_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.First<Observation>(j_);
			DataType l_ = k_?.Value;
			CqlQuantity m_ = FHIRHelpers_4_3_000.ToQuantity(l_ as Quantity);
			bool? o_(Observation HeartRate)
			{
				DataType aq_ = HeartRate?.Effective;
				object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
				CqlDateTime as_ = QICoreCommon_2_0_000.earliest(ar_);
				CqlInterval<CqlDateTime> at_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlQuantity av_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime aw_ = context.Operators.Subtract(au_, av_);
				CqlDateTime ax_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(aw_, ax_, true, false);
				bool? az_ = context.Operators.In<CqlDateTime>(as_, ay_, default);
				Code<ObservationStatus> ba_ = HeartRate?.StatusElement;
				ObservationStatus? bb_ = ba_?.Value;
				string bc_ = context.Operators.Convert<string>(bb_);
				string[] bd_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? be_ = context.Operators.In<string>(bc_, bd_ as IEnumerable<string>);
				bool? bf_ = context.Operators.And(az_, be_);

				return bf_;
			};
			IEnumerable<Observation> p_ = context.Operators.Where<Observation>(f_, o_);
			object q_(Observation @this)
			{
				DataType bg_ = @this?.Effective;
				object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
				CqlDateTime bi_ = QICoreCommon_2_0_000.earliest(bh_);

				return bi_;
			};
			IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			Observation s_ = context.Operators.First<Observation>(r_);
			DataType t_ = s_?.Effective;
			object u_ = FHIRHelpers_4_3_000.ToValue(t_);
			CqlDateTime v_ = QICoreCommon_2_0_000.earliest(u_);
			(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? w_ = (e_, m_ as CqlQuantity, v_);

			return w_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Heart Rate")]
	public IEnumerable<(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate() => 
		__Risk_Variable_Heart_Rate.Value;

	private IEnumerable<(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Id d_ = TwentyWeeksPlusEncounter?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
			bool? g_(Observation BP)
			{
				DataType aa_ = BP?.Effective;
				object ab_ = FHIRHelpers_4_3_000.ToValue(aa_);
				CqlDateTime ac_ = QICoreCommon_2_0_000.earliest(ab_);
				CqlInterval<CqlDateTime> ad_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime ae_ = context.Operators.Start(ad_);
				CqlQuantity af_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
				CqlDateTime ah_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, true, false);
				bool? aj_ = context.Operators.In<CqlDateTime>(ac_, ai_, default);
				Code<ObservationStatus> ak_ = BP?.StatusElement;
				ObservationStatus? al_ = ak_?.Value;
				string am_ = context.Operators.Convert<string>(al_);
				string[] an_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ao_ = context.Operators.In<string>(am_, an_ as IEnumerable<string>);
				bool? ap_ = context.Operators.And(aj_, ao_);

				return ap_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType aq_ = @this?.Effective;
				object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
				CqlDateTime as_ = QICoreCommon_2_0_000.earliest(ar_);

				return as_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.First<Observation>(j_);
			List<Observation.ComponentComponent> l_ = k_?.Component;
			bool? m_(Observation.ComponentComponent C)
			{
				CodeableConcept at_ = C?.Code;
				CqlConcept au_ = FHIRHelpers_4_3_000.ToConcept(at_);
				CqlCode av_ = this.Systolic_blood_pressure();
				CqlConcept aw_ = context.Operators.ConvertCodeToConcept(av_);
				bool? ax_ = context.Operators.Equivalent(au_, aw_);

				return ax_;
			};
			IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
			CqlQuantity o_(Observation.ComponentComponent C)
			{
				DataType ay_ = C?.Value;
				object az_ = FHIRHelpers_4_3_000.ToValue(ay_);

				return az_ as CqlQuantity;
			};
			IEnumerable<CqlQuantity> p_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(n_, o_);
			bool? r_(Observation BP)
			{
				DataType ba_ = BP?.Effective;
				object bb_ = FHIRHelpers_4_3_000.ToValue(ba_);
				CqlDateTime bc_ = QICoreCommon_2_0_000.earliest(bb_);
				CqlInterval<CqlDateTime> bd_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime be_ = context.Operators.Start(bd_);
				CqlQuantity bf_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
				CqlDateTime bh_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(bg_, bh_, true, false);
				bool? bj_ = context.Operators.In<CqlDateTime>(bc_, bi_, default);
				Code<ObservationStatus> bk_ = BP?.StatusElement;
				ObservationStatus? bl_ = bk_?.Value;
				string bm_ = context.Operators.Convert<string>(bl_);
				string[] bn_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bo_ = context.Operators.In<string>(bm_, bn_ as IEnumerable<string>);
				bool? bp_ = context.Operators.And(bj_, bo_);

				return bp_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(f_, r_);
			object t_(Observation @this)
			{
				DataType bq_ = @this?.Effective;
				object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
				CqlDateTime bs_ = QICoreCommon_2_0_000.earliest(br_);

				return bs_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			DataType w_ = v_?.Effective;
			object x_ = FHIRHelpers_4_3_000.ToValue(w_);
			CqlDateTime y_ = QICoreCommon_2_0_000.earliest(x_);
			(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? z_ = (e_, p_, y_);

			return z_;
		};
		IEnumerable<(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Systolic Blood Pressure")]
	public IEnumerable<(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure() => 
		__Risk_Variable_Systolic_Blood_Pressure.Value;

    [CqlDeclaration("pOAIsNoOrUTD")]
	public IEnumerable<CqlConcept> pOAIsNoOrUTD(Encounter TheEncounter)
	{
		List<Encounter.DiagnosisComponent> a_ = TheEncounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			bool? f_(Extension @this)
			{
				string n_ = @this?.Url;
				FhirString o_ = context.Operators.Convert<FhirString>(n_);
				string p_ = FHIRHelpers_4_3_000.ToString(o_);
				bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

				return q_;
			};
			IEnumerable<Extension> g_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
					? (EncounterDiagnoses as Element).Extension
					: default), f_);
			object h_(Extension @this)
			{
				DataType r_ = @this?.Value;

				return r_;
			};
			IEnumerable<object> i_ = context.Operators.Select<Extension, object>(g_, h_);
			object j_ = context.Operators.SingletonFrom<object>(i_);
			CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_ as CodeableConcept);
			CqlValueSet l_ = this.Present_on_Admission_is_No_or_Unable_To_Determine();
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);

			return m_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		CqlConcept d_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			ResourceReference s_ = EncounterDiagnoses?.Condition;
			Condition t_ = CQMCommon_2_0_000.getCondition(s_);
			CodeableConcept u_ = t_?.Code;
			CqlConcept v_ = FHIRHelpers_4_3_000.ToConcept(u_);

			return v_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(c_, d_);

		return e_;
	}

}
