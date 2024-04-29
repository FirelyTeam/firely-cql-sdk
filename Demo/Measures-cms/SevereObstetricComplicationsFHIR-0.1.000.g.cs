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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
    internal Lazy<IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM>> __Variable_Calculated_Gestational_Age;
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
    internal Lazy<IEnumerable<Tuple_BUSccGEhJLedCLcPKRPjDcPjV>> __Risk_Variable_First_Hematocrit_Lab_Test;
    internal Lazy<IEnumerable<Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA>> __Risk_Variable_First_White_Blood_Cell_Count_Lab_Test;
    internal Lazy<IEnumerable<Tuple_CYVVSdgZbMfXHMiBHjISgejQI>> __Risk_Variable_Heart_Rate;
    internal Lazy<IEnumerable<Tuple_DBZhWNcHciGGJUSXZKiOPXJYf>> __Risk_Variable_Systolic_Blood_Pressure;

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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM>>(this.Variable_Calculated_Gestational_Age_Value);
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
        __Risk_Variable_First_Hematocrit_Lab_Test = new Lazy<IEnumerable<Tuple_BUSccGEhJLedCLcPKRPjDcPjV>>(this.Risk_Variable_First_Hematocrit_Lab_Test_Value);
        __Risk_Variable_First_White_Blood_Cell_Count_Lab_Test = new Lazy<IEnumerable<Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA>>(this.Risk_Variable_First_White_Blood_Cell_Count_Lab_Test_Value);
        __Risk_Variable_Heart_Rate = new Lazy<IEnumerable<Tuple_CYVVSdgZbMfXHMiBHjISgejQI>>(this.Risk_Variable_Heart_Rate_Value);
        __Risk_Variable_Systolic_Blood_Pressure = new Lazy<IEnumerable<Tuple_DBZhWNcHciGGJUSXZKiOPXJYf>>(this.Risk_Variable_Systolic_Blood_Pressure_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public PCMaternal_5_16_000 PCMaternal_5_16_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet _20_to_42_Plus_Weeks_Gestation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67", null);

    [CqlDeclaration("20 to 42 Plus Weeks Gestation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67")]
	public CqlValueSet _20_to_42_Plus_Weeks_Gestation() => 
		___20_to_42_Plus_Weeks_Gestation.Value;

	private CqlValueSet Acute_or_Persistent_Asthma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271", null);

    [CqlDeclaration("Acute or Persistent Asthma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271")]
	public CqlValueSet Acute_or_Persistent_Asthma() => 
		__Acute_or_Persistent_Asthma.Value;

	private CqlValueSet Anemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323", null);

    [CqlDeclaration("Anemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323")]
	public CqlValueSet Anemia() => 
		__Anemia.Value;

	private CqlValueSet Autoimmune_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311", null);

    [CqlDeclaration("Autoimmune Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311")]
	public CqlValueSet Autoimmune_Disease() => 
		__Autoimmune_Disease.Value;

	private CqlValueSet Bariatric_Surgery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317", null);

    [CqlDeclaration("Bariatric Surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317")]
	public CqlValueSet Bariatric_Surgery() => 
		__Bariatric_Surgery.Value;

	private CqlValueSet Bleeding_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287", null);

    [CqlDeclaration("Bleeding Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287")]
	public CqlValueSet Bleeding_Disorder() => 
		__Bleeding_Disorder.Value;

	private CqlValueSet Blood_Transfusion_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213", null);

    [CqlDeclaration("Blood Transfusion")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213")]
	public CqlValueSet Blood_Transfusion() => 
		__Blood_Transfusion.Value;

	private CqlValueSet Cardiac_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341", null);

    [CqlDeclaration("Cardiac Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341")]
	public CqlValueSet Cardiac_Disease() => 
		__Cardiac_Disease.Value;

	private CqlValueSet COVID_19_Confirmed_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373", null);

    [CqlDeclaration("COVID 19 Confirmed")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373")]
	public CqlValueSet COVID_19_Confirmed() => 
		__COVID_19_Confirmed.Value;

	private CqlValueSet Delivery_Procedures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);

    [CqlDeclaration("Delivery Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59")]
	public CqlValueSet Delivery_Procedures() => 
		__Delivery_Procedures.Value;

	private CqlValueSet Economic_Housing_Instability_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292", null);

    [CqlDeclaration("Economic Housing Instability")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292")]
	public CqlValueSet Economic_Housing_Instability() => 
		__Economic_Housing_Instability.Value;

	private CqlValueSet ED_Visit_and_OB_Triage_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", null);

    [CqlDeclaration("ED Visit and OB Triage")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369")]
	public CqlValueSet ED_Visit_and_OB_Triage() => 
		__ED_Visit_and_OB_Triage.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Gastrointestinal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338", null);

    [CqlDeclaration("Gastrointestinal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338")]
	public CqlValueSet Gastrointestinal_Disease() => 
		__Gastrointestinal_Disease.Value;

	private CqlValueSet Gestational_Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269", null);

    [CqlDeclaration("Gestational Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269")]
	public CqlValueSet Gestational_Diabetes() => 
		__Gestational_Diabetes.Value;

	private CqlValueSet Hematocrit_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public CqlValueSet Hematocrit_lab_test() => 
		__Hematocrit_lab_test.Value;

	private CqlValueSet HIV_in_Pregnancy_Childbirth_and_Puerperium_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272", null);

    [CqlDeclaration("HIV in Pregnancy Childbirth and Puerperium")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272")]
	public CqlValueSet HIV_in_Pregnancy_Childbirth_and_Puerperium() => 
		__HIV_in_Pregnancy_Childbirth_and_Puerperium.Value;

	private CqlValueSet Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332", null);

    [CqlDeclaration("Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332")]
	public CqlValueSet Hypertension() => 
		__Hypertension.Value;

	private CqlValueSet Long_Term_Anticoagulant_Use_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366", null);

    [CqlDeclaration("Long Term Anticoagulant Use")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366")]
	public CqlValueSet Long_Term_Anticoagulant_Use() => 
		__Long_Term_Anticoagulant_Use.Value;

	private CqlValueSet Mental_Health_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314", null);

    [CqlDeclaration("Mental Health Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314")]
	public CqlValueSet Mental_Health_Disorder() => 
		__Mental_Health_Disorder.Value;

	private CqlValueSet Mild_or_Moderate_Preeclampsia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329", null);

    [CqlDeclaration("Mild or Moderate Preeclampsia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329")]
	public CqlValueSet Mild_or_Moderate_Preeclampsia() => 
		__Mild_or_Moderate_Preeclampsia.Value;

	private CqlValueSet Morbid_or_Severe_Obesity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290", null);

    [CqlDeclaration("Morbid or Severe Obesity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290")]
	public CqlValueSet Morbid_or_Severe_Obesity() => 
		__Morbid_or_Severe_Obesity.Value;

	private CqlValueSet Multiple_Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284", null);

    [CqlDeclaration("Multiple Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284")]
	public CqlValueSet Multiple_Pregnancy() => 
		__Multiple_Pregnancy.Value;

	private CqlValueSet Neuromuscular_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308", null);

    [CqlDeclaration("Neuromuscular Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308")]
	public CqlValueSet Neuromuscular_Disease() => 
		__Neuromuscular_Disease.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Placenta_Previa_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.35", null);

    [CqlDeclaration("Placenta Previa")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.35")]
	public CqlValueSet Placenta_Previa() => 
		__Placenta_Previa.Value;

	private CqlValueSet Placental_Abruption_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305", null);

    [CqlDeclaration("Placental Abruption")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305")]
	public CqlValueSet Placental_Abruption() => 
		__Placental_Abruption.Value;

	private CqlValueSet Placental_Accreta_Spectrum_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", null);

    [CqlDeclaration("Placental Accreta Spectrum")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302")]
	public CqlValueSet Placental_Accreta_Spectrum() => 
		__Placental_Accreta_Spectrum.Value;

	private CqlValueSet Preexisting_Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275", null);

    [CqlDeclaration("Preexisting Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275")]
	public CqlValueSet Preexisting_Diabetes() => 
		__Preexisting_Diabetes.Value;

	private CqlValueSet Present_on_Admission_is_No_or_Unable_To_Determine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370", null);

    [CqlDeclaration("Present on Admission is No or Unable To Determine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370")]
	public CqlValueSet Present_on_Admission_is_No_or_Unable_To_Determine() => 
		__Present_on_Admission_is_No_or_Unable_To_Determine.Value;

	private CqlValueSet Present_On_Admission_is_Yes_or_Exempt_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63", null);

    [CqlDeclaration("Present On Admission is Yes or Exempt")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63")]
	public CqlValueSet Present_On_Admission_is_Yes_or_Exempt() => 
		__Present_On_Admission_is_Yes_or_Exempt.Value;

	private CqlValueSet Preterm_Birth_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299", null);

    [CqlDeclaration("Preterm Birth")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299")]
	public CqlValueSet Preterm_Birth() => 
		__Preterm_Birth.Value;

	private CqlValueSet Previous_Cesarean_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278", null);

    [CqlDeclaration("Previous Cesarean")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278")]
	public CqlValueSet Previous_Cesarean() => 
		__Previous_Cesarean.Value;

	private CqlValueSet Pulmonary_Hypertension_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281", null);

    [CqlDeclaration("Pulmonary Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281")]
	public CqlValueSet Pulmonary_Hypertension() => 
		__Pulmonary_Hypertension.Value;

	private CqlValueSet Renal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335", null);

    [CqlDeclaration("Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335")]
	public CqlValueSet Renal_Disease() => 
		__Renal_Disease.Value;

	private CqlValueSet Respiratory_Conditions_Related_to_COVID_19_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376", null);

    [CqlDeclaration("Respiratory Conditions Related to COVID 19")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376")]
	public CqlValueSet Respiratory_Conditions_Related_to_COVID_19() => 
		__Respiratory_Conditions_Related_to_COVID_19.Value;

	private CqlValueSet Respiratory_Support_Procedures_Related_to_COVID_19_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379", null);

    [CqlDeclaration("Respiratory Support Procedures Related to COVID 19")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379")]
	public CqlValueSet Respiratory_Support_Procedures_Related_to_COVID_19() => 
		__Respiratory_Support_Procedures_Related_to_COVID_19.Value;

	private CqlValueSet Severe_Maternal_Morbidity_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255", null);

    [CqlDeclaration("Severe Maternal Morbidity Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255")]
	public CqlValueSet Severe_Maternal_Morbidity_Diagnoses() => 
		__Severe_Maternal_Morbidity_Diagnoses.Value;

	private CqlValueSet Severe_Maternal_Morbidity_Procedures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256", null);

    [CqlDeclaration("Severe Maternal Morbidity Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256")]
	public CqlValueSet Severe_Maternal_Morbidity_Procedures() => 
		__Severe_Maternal_Morbidity_Procedures.Value;

	private CqlValueSet Severe_Preeclampsia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327", null);

    [CqlDeclaration("Severe Preeclampsia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327")]
	public CqlValueSet Severe_Preeclampsia() => 
		__Severe_Preeclampsia.Value;

	private CqlValueSet Substance_Abuse_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320", null);

    [CqlDeclaration("Substance Abuse")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320")]
	public CqlValueSet Substance_Abuse() => 
		__Substance_Abuse.Value;

	private CqlValueSet Thyrotoxicosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296", null);

    [CqlDeclaration("Thyrotoxicosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296")]
	public CqlValueSet Thyrotoxicosis() => 
		__Thyrotoxicosis.Value;

	private CqlValueSet Venous_Thromboembolism_in_Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363", null);

    [CqlDeclaration("Venous Thromboembolism in Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363")]
	public CqlValueSet Venous_Thromboembolism_in_Pregnancy() => 
		__Venous_Thromboembolism_in_Pregnancy.Value;

	private CqlValueSet White_blood_cells_count_lab_test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
	public CqlValueSet White_blood_cells_count_lab_test() => 
		__White_blood_cells_count_lab_test.Value;

	private CqlCode Heart_rate_Value() => 
		new CqlCode("8867-4", "http://loinc.org", null, null);

    [CqlDeclaration("Heart rate")]
	public CqlCode Heart_rate() => 
		__Heart_rate.Value;

	private CqlCode Systolic_blood_pressure_Value() => 
		new CqlCode("8480-6", "http://loinc.org", null, null);

    [CqlDeclaration("Systolic blood pressure")]
	public CqlCode Systolic_blood_pressure() => 
		__Systolic_blood_pressure.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("8867-4", "http://loinc.org", null, null),
			new CqlCode("8480-6", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[0]
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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
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
				CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet m_ = this._20_to_42_Plus_Weeks_Gestation();
				bool? n_ = context.Operators.ConceptInValueSet(l_, m_);

				return n_;
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
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding();
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(c_, d_);

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
			bool? d_(Encounter.DiagnosisComponent EncounterDiagnoses)
			{
				Condition m_ = CQMCommon_2_0_000.getCondition(EncounterDiagnoses?.Condition);
				CqlConcept n_ = FHIRHelpers_4_3_000.ToConcept(m_?.Code);
				CqlValueSet o_ = this.Severe_Maternal_Morbidity_Diagnoses();
				bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
				bool? q_(Extension @this)
				{
					FhirUri aa_ = context.Operators.Convert<FhirUri>(@this?.Url);
					string ab_ = FHIRHelpers_4_3_000.ToString(aa_);
					bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return ac_;
				};
				IEnumerable<Extension> r_ = context.Operators.Where<Extension>(((EncounterDiagnoses is Element)
						? ((EncounterDiagnoses as Element).Extension)
						: null), q_);
				DataType s_(Extension @this) => 
					@this?.Value;
				IEnumerable<DataType> t_ = context.Operators.Select<Extension, DataType>(r_, s_);
				DataType u_ = context.Operators.SingletonFrom<DataType>(t_);
				CodeableConcept v_ = context.Operators.Convert<CodeableConcept>(u_);
				CqlConcept w_ = FHIRHelpers_4_3_000.ToConcept(v_);
				CqlValueSet x_ = this.Present_on_Admission_is_No_or_Unable_To_Determine();
				bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
				bool? z_ = context.Operators.And(p_, y_);

				return z_;
			};
			IEnumerable<Encounter.DiagnosisComponent> e_ = context.Operators.Where<Encounter.DiagnosisComponent>((TwentyWeeksPlusEncounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), d_);
			bool? f_ = context.Operators.Exists<Encounter.DiagnosisComponent>(e_);
			CqlValueSet g_ = this.Severe_Maternal_Morbidity_Procedures();
			IEnumerable<Procedure> h_ = context.Operators.RetrieveByValueSet<Procedure>(g_, null);
			bool? i_(Procedure EncounterSMMProcedures)
			{
				string ad_ = context.Operators.Convert<string>(EncounterSMMProcedures?.StatusElement?.Value);
				bool? ae_ = context.Operators.Equal(ad_, "completed");
				object af_ = FHIRHelpers_4_3_000.ToValue(EncounterSMMProcedures?.Performed);
				CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.toInterval(af_);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				CqlInterval<CqlDateTime> ai_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				bool? aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, "day");
				bool? ak_ = context.Operators.And(ae_, aj_);

				return ak_;
			};
			IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
			bool? k_ = context.Operators.Exists<Procedure>(j_);
			bool? l_ = context.Operators.Or(f_, k_);

			return l_;
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
			CqlConcept d_ = FHIRHelpers_4_3_000.ToConcept(TwentyWeeksPlusEncounter?.Hospitalization?.DischargeDisposition);
			CqlValueSet e_ = this.Patient_Expired();
			bool? f_ = context.Operators.ConceptInValueSet(d_, e_);

			return f_;
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
			IEnumerable<Procedure> e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			bool? f_(Procedure BloodTransfusion)
			{
				string j_ = context.Operators.Convert<string>(BloodTransfusion?.StatusElement?.Value);
				bool? k_ = context.Operators.Equal(j_, "completed");
				object l_ = FHIRHelpers_4_3_000.ToValue(BloodTransfusion?.Performed);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.toInterval(l_);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlInterval<CqlDateTime> o_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
				bool? q_ = context.Operators.And(k_, p_);

				return q_;
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
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Delivery_Encounters_with_Blood_Transfusion();
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(c_, d_);

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
				CqlConcept s_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet t_ = this.COVID_19_Confirmed();
				bool? u_ = context.Operators.ConceptInValueSet(s_, t_);

				return u_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);
			bool? i_(Condition EncounterDiagnosis)
			{
				CqlConcept v_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet w_ = this.Respiratory_Conditions_Related_to_COVID_19();
				bool? x_ = context.Operators.ConceptInValueSet(v_, w_);

				return x_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(d_, i_);
			bool? k_ = context.Operators.Exists<Condition>(j_);
			CqlValueSet l_ = this.Respiratory_Support_Procedures_Related_to_COVID_19();
			IEnumerable<Procedure> m_ = context.Operators.RetrieveByValueSet<Procedure>(l_, null);
			bool? n_(Procedure COVIDRespiratoryProcedure)
			{
				string y_ = context.Operators.Convert<string>(COVIDRespiratoryProcedure?.StatusElement?.Value);
				bool? z_ = context.Operators.Equal(y_, "completed");
				object aa_ = FHIRHelpers_4_3_000.ToValue(COVIDRespiratoryProcedure?.Performed);
				CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.toInterval(aa_);
				CqlDateTime ac_ = context.Operators.Start(ab_);
				CqlInterval<CqlDateTime> ad_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, "day");
				bool? af_ = context.Operators.And(z_, ae_);

				return af_;
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
		IEnumerable<Encounter> c_ = context.Operators.ListExcept<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Stratification Encounter")]
	public IEnumerable<Encounter> Stratification_Encounter() => 
		__Stratification_Encounter.Value;

	private IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion();
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Expiration();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
	public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions() => 
		__Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions.Value;

	private IEnumerable<Encounter> Stratum_1_Value()
	{
		IEnumerable<Encounter> a_ = this.Stratification_Encounter();
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions();
		IEnumerable<Encounter> c_ = context.Operators.ListIntersect<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Stratum 1")]
	public IEnumerable<Encounter> Stratum_1() => 
		__Stratum_1.Value;

	private IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age_Value()
	{
		IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> a_ = PCMaternal_5_16_000.Variable_Calculated_Gestational_Age();

		return a_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age() => 
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
		bool? a_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			bool? e_(Extension @this)
			{
				FhirUri n_ = context.Operators.Convert<FhirUri>(@this?.Url);
				string o_ = FHIRHelpers_4_3_000.ToString(n_);
				bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

				return p_;
			};
			IEnumerable<Extension> f_ = context.Operators.Where<Extension>(((EncounterDiagnoses is Element)
					? ((EncounterDiagnoses as Element).Extension)
					: null), e_);
			DataType g_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> h_ = context.Operators.Select<Extension, DataType>(f_, g_);
			DataType i_ = context.Operators.SingletonFrom<DataType>(h_);
			CodeableConcept j_ = context.Operators.Convert<CodeableConcept>(i_);
			CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_);
			CqlValueSet l_ = this.Present_On_Admission_is_Yes_or_Exempt();
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);

			return m_;
		};
		IEnumerable<Encounter.DiagnosisComponent> b_ = context.Operators.Where<Encounter.DiagnosisComponent>((TheEncounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		CqlConcept c_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			Condition q_ = CQMCommon_2_0_000.getCondition(EncounterDiagnoses?.Condition);
			CqlConcept r_ = FHIRHelpers_4_3_000.ToConcept(q_?.Code);

			return r_;
		};
		IEnumerable<CqlConcept> d_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(b_, c_);

		return d_;
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
			bool? j_ = context.Operators.In<int?>(h_, i_, null);
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
		IEnumerable<Encounter> g_ = context.Operators.ListUnion<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Risk Variable Preterm Birth")]
	public IEnumerable<Encounter> Risk_Variable_Preterm_Birth() => 
		__Risk_Variable_Preterm_Birth.Value;

	private IEnumerable<Tuple_BUSccGEhJLedCLcPKRPjDcPjV> Risk_Variable_First_Hematocrit_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		Tuple_BUSccGEhJLedCLcPKRPjDcPjV b_(Encounter TwentyWeeksPlusEncounter)
		{
			CqlValueSet d_ = this.Hematocrit_lab_test();
			IEnumerable<Observation> e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation Hematocrit)
			{
				CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(Hematocrit?.IssuedElement?.Value);
				CqlInterval<CqlDateTime> v_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlQuantity x_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime y_ = context.Operators.Subtract(w_, x_);
				CqlDateTime z_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(y_, z_, true, false);
				bool? ab_ = context.Operators.In<CqlDateTime>(u_, aa_, null);
				string ac_ = context.Operators.Convert<string>(Hematocrit?.StatusElement?.Value);
				string[] ad_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? ae_ = context.Operators.In<string>(ac_, (ad_ as IEnumerable<string>));
				bool? af_ = context.Operators.And(ab_, ae_);
				object ag_ = FHIRHelpers_4_3_000.ToValue(Hematocrit?.Value);
				bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
				bool? ai_ = context.Operators.And(af_, ah_);

				return ai_;
			};
			IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
			object h_(Observation @this)
			{
				CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				CqlDateTime ak_ = QICoreCommon_2_0_000.earliest((aj_ as object));

				return ak_;
			};
			IEnumerable<Observation> i_ = context.Operators.SortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			Observation j_ = context.Operators.First<Observation>(i_);
			object k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			IEnumerable<Observation> m_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? n_(Observation Hematocrit)
			{
				CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(Hematocrit?.IssuedElement?.Value);
				CqlInterval<CqlDateTime> am_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlQuantity ao_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
				CqlDateTime aq_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(ap_, aq_, true, false);
				bool? as_ = context.Operators.In<CqlDateTime>(al_, ar_, null);
				string at_ = context.Operators.Convert<string>(Hematocrit?.StatusElement?.Value);
				string[] au_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? av_ = context.Operators.In<string>(at_, (au_ as IEnumerable<string>));
				bool? aw_ = context.Operators.And(as_, av_);
				object ax_ = FHIRHelpers_4_3_000.ToValue(Hematocrit?.Value);
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
				bool? az_ = context.Operators.And(aw_, ay_);

				return az_;
			};
			IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
			object p_(Observation @this)
			{
				CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				CqlDateTime bb_ = QICoreCommon_2_0_000.earliest((ba_ as object));

				return bb_;
			};
			IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
			Observation r_ = context.Operators.First<Observation>(q_);
			CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_?.IssuedElement?.Value);
			Tuple_BUSccGEhJLedCLcPKRPjDcPjV t_ = new Tuple_BUSccGEhJLedCLcPKRPjDcPjV
			{
				EncounterId = TwentyWeeksPlusEncounter?.IdElement?.Value,
				FirstHematocritResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		IEnumerable<Tuple_BUSccGEhJLedCLcPKRPjDcPjV> c_ = context.Operators.Select<Encounter, Tuple_BUSccGEhJLedCLcPKRPjDcPjV>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable First Hematocrit Lab Test")]
	public IEnumerable<Tuple_BUSccGEhJLedCLcPKRPjDcPjV> Risk_Variable_First_Hematocrit_Lab_Test() => 
		__Risk_Variable_First_Hematocrit_Lab_Test.Value;

	private IEnumerable<Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA b_(Encounter TwentyWeeksPlusEncounter)
		{
			CqlValueSet d_ = this.White_blood_cells_count_lab_test();
			IEnumerable<Observation> e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation WBC)
			{
				CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(WBC?.IssuedElement?.Value);
				CqlInterval<CqlDateTime> v_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlQuantity x_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime y_ = context.Operators.Subtract(w_, x_);
				CqlDateTime z_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(y_, z_, true, false);
				bool? ab_ = context.Operators.In<CqlDateTime>(u_, aa_, null);
				string ac_ = context.Operators.Convert<string>(WBC?.StatusElement?.Value);
				string[] ad_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? ae_ = context.Operators.In<string>(ac_, (ad_ as IEnumerable<string>));
				bool? af_ = context.Operators.And(ab_, ae_);
				object ag_ = FHIRHelpers_4_3_000.ToValue(WBC?.Value);
				bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
				bool? ai_ = context.Operators.And(af_, ah_);

				return ai_;
			};
			IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
			object h_(Observation @this)
			{
				CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				CqlDateTime ak_ = QICoreCommon_2_0_000.earliest((aj_ as object));

				return ak_;
			};
			IEnumerable<Observation> i_ = context.Operators.SortBy<Observation>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
			Observation j_ = context.Operators.First<Observation>(i_);
			object k_ = FHIRHelpers_4_3_000.ToValue(j_?.Value);
			IEnumerable<Observation> m_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? n_(Observation WBC)
			{
				CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(WBC?.IssuedElement?.Value);
				CqlInterval<CqlDateTime> am_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlQuantity ao_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
				CqlDateTime aq_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(ap_, aq_, true, false);
				bool? as_ = context.Operators.In<CqlDateTime>(al_, ar_, null);
				string at_ = context.Operators.Convert<string>(WBC?.StatusElement?.Value);
				string[] au_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? av_ = context.Operators.In<string>(at_, (au_ as IEnumerable<string>));
				bool? aw_ = context.Operators.And(as_, av_);
				object ax_ = FHIRHelpers_4_3_000.ToValue(WBC?.Value);
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
				bool? az_ = context.Operators.And(aw_, ay_);

				return az_;
			};
			IEnumerable<Observation> o_ = context.Operators.Where<Observation>(m_, n_);
			object p_(Observation @this)
			{
				CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(@this?.IssuedElement?.Value);
				CqlDateTime bb_ = QICoreCommon_2_0_000.earliest((ba_ as object));

				return bb_;
			};
			IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
			Observation r_ = context.Operators.First<Observation>(q_);
			CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_?.IssuedElement?.Value);
			Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA t_ = new Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA
			{
				EncounterId = TwentyWeeksPlusEncounter?.IdElement?.Value,
				FirstWBCResult = (k_ as CqlQuantity),
				Timing = s_,
			};

			return t_;
		};
		IEnumerable<Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA> c_ = context.Operators.Select<Encounter, Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable First White Blood Cell Count Lab Test")]
	public IEnumerable<Tuple_EbcGgjOhJFXiKXEMDPcAXPAhA> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test() => 
		__Risk_Variable_First_White_Blood_Cell_Count_Lab_Test.Value;

	private IEnumerable<Tuple_CYVVSdgZbMfXHMiBHjISgejQI> Risk_Variable_Heart_Rate_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		Tuple_CYVVSdgZbMfXHMiBHjISgejQI b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation HeartRate)
			{
				object u_ = FHIRHelpers_4_3_000.ToValue(HeartRate?.Effective);
				CqlDateTime v_ = QICoreCommon_2_0_000.earliest(u_);
				CqlInterval<CqlDateTime> w_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime x_ = context.Operators.Start(w_);
				CqlQuantity y_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime z_ = context.Operators.Subtract(x_, y_);
				CqlDateTime aa_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(z_, aa_, true, false);
				bool? ac_ = context.Operators.In<CqlDateTime>(v_, ab_, null);
				string ad_ = context.Operators.Convert<string>(HeartRate?.StatusElement?.Value);
				string[] ae_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? af_ = context.Operators.In<string>(ad_, (ae_ as IEnumerable<string>));
				bool? ag_ = context.Operators.And(ac_, af_);

				return ag_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				object ah_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlDateTime ai_ = QICoreCommon_2_0_000.earliest(ah_);

				return ai_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.First<Observation>(h_);
			Quantity j_ = context.Operators.Convert<Quantity>(i_?.Value);
			CqlQuantity k_ = FHIRHelpers_4_3_000.ToQuantity(j_);
			bool? m_(Observation HeartRate)
			{
				object aj_ = FHIRHelpers_4_3_000.ToValue(HeartRate?.Effective);
				CqlDateTime ak_ = QICoreCommon_2_0_000.earliest(aj_);
				CqlInterval<CqlDateTime> al_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime am_ = context.Operators.Start(al_);
				CqlQuantity an_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ao_ = context.Operators.Subtract(am_, an_);
				CqlDateTime ap_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ao_, ap_, true, false);
				bool? ar_ = context.Operators.In<CqlDateTime>(ak_, aq_, null);
				string as_ = context.Operators.Convert<string>(HeartRate?.StatusElement?.Value);
				string[] at_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? au_ = context.Operators.In<string>(as_, (at_ as IEnumerable<string>));
				bool? av_ = context.Operators.And(ar_, au_);

				return av_;
			};
			IEnumerable<Observation> n_ = context.Operators.Where<Observation>(d_, m_);
			object o_(Observation @this)
			{
				object aw_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlDateTime ax_ = QICoreCommon_2_0_000.earliest(aw_);

				return ax_;
			};
			IEnumerable<Observation> p_ = context.Operators.SortBy<Observation>(n_, o_, System.ComponentModel.ListSortDirection.Ascending);
			Observation q_ = context.Operators.First<Observation>(p_);
			object r_ = FHIRHelpers_4_3_000.ToValue(q_?.Effective);
			CqlDateTime s_ = QICoreCommon_2_0_000.earliest(r_);
			Tuple_CYVVSdgZbMfXHMiBHjISgejQI t_ = new Tuple_CYVVSdgZbMfXHMiBHjISgejQI
			{
				EncounterId = TwentyWeeksPlusEncounter?.IdElement?.Value,
				FirstHRResult = k_,
				Timing = s_,
			};

			return t_;
		};
		IEnumerable<Tuple_CYVVSdgZbMfXHMiBHjISgejQI> c_ = context.Operators.Select<Encounter, Tuple_CYVVSdgZbMfXHMiBHjISgejQI>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Heart Rate")]
	public IEnumerable<Tuple_CYVVSdgZbMfXHMiBHjISgejQI> Risk_Variable_Heart_Rate() => 
		__Risk_Variable_Heart_Rate.Value;

	private IEnumerable<Tuple_DBZhWNcHciGGJUSXZKiOPXJYf> Risk_Variable_Systolic_Blood_Pressure_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation();
		Tuple_DBZhWNcHciGGJUSXZKiOPXJYf b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
			bool? e_(Observation BP)
			{
				object w_ = FHIRHelpers_4_3_000.ToValue(BP?.Effective);
				CqlDateTime x_ = QICoreCommon_2_0_000.earliest(w_);
				CqlInterval<CqlDateTime> y_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime z_ = context.Operators.Start(y_);
				CqlQuantity aa_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
				CqlDateTime ac_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(ab_, ac_, true, false);
				bool? ae_ = context.Operators.In<CqlDateTime>(x_, ad_, null);
				string af_ = context.Operators.Convert<string>(BP?.StatusElement?.Value);
				string[] ag_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? ah_ = context.Operators.In<string>(af_, (ag_ as IEnumerable<string>));
				bool? ai_ = context.Operators.And(ae_, ah_);

				return ai_;
			};
			IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
			object g_(Observation @this)
			{
				object aj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlDateTime ak_ = QICoreCommon_2_0_000.earliest(aj_);

				return ak_;
			};
			IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
			Observation i_ = context.Operators.First<Observation>(h_);
			bool? j_(Observation.ComponentComponent C)
			{
				CqlConcept al_ = FHIRHelpers_4_3_000.ToConcept(C?.Code);
				CqlCode am_ = this.Systolic_blood_pressure();
				CqlConcept an_ = context.Operators.ConvertCodeToConcept(am_);
				bool? ao_ = context.Operators.Equivalent(al_, an_);

				return ao_;
			};
			IEnumerable<Observation.ComponentComponent> k_ = context.Operators.Where<Observation.ComponentComponent>((i_?.Component as IEnumerable<Observation.ComponentComponent>), j_);
			CqlQuantity l_(Observation.ComponentComponent C)
			{
				object ap_ = FHIRHelpers_4_3_000.ToValue(C?.Value);

				return (ap_ as CqlQuantity);
			};
			IEnumerable<CqlQuantity> m_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(k_, l_);
			bool? o_(Observation BP)
			{
				object aq_ = FHIRHelpers_4_3_000.ToValue(BP?.Effective);
				CqlDateTime ar_ = QICoreCommon_2_0_000.earliest(aq_);
				CqlInterval<CqlDateTime> as_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(TwentyWeeksPlusEncounter);
				CqlDateTime at_ = context.Operators.Start(as_);
				CqlQuantity au_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime av_ = context.Operators.Subtract(at_, au_);
				CqlDateTime aw_ = PCMaternal_5_16_000.lastTimeOfDelivery(TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(av_, aw_, true, false);
				bool? ay_ = context.Operators.In<CqlDateTime>(ar_, ax_, null);
				string az_ = context.Operators.Convert<string>(BP?.StatusElement?.Value);
				string[] ba_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? bb_ = context.Operators.In<string>(az_, (ba_ as IEnumerable<string>));
				bool? bc_ = context.Operators.And(ay_, bb_);

				return bc_;
			};
			IEnumerable<Observation> p_ = context.Operators.Where<Observation>(d_, o_);
			object q_(Observation @this)
			{
				object bd_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
				CqlDateTime be_ = QICoreCommon_2_0_000.earliest(bd_);

				return be_;
			};
			IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			Observation s_ = context.Operators.First<Observation>(r_);
			object t_ = FHIRHelpers_4_3_000.ToValue(s_?.Effective);
			CqlDateTime u_ = QICoreCommon_2_0_000.earliest(t_);
			Tuple_DBZhWNcHciGGJUSXZKiOPXJYf v_ = new Tuple_DBZhWNcHciGGJUSXZKiOPXJYf
			{
				EncounterId = TwentyWeeksPlusEncounter?.IdElement?.Value,
				FirstSBPResult = m_,
				Timing = u_,
			};

			return v_;
		};
		IEnumerable<Tuple_DBZhWNcHciGGJUSXZKiOPXJYf> c_ = context.Operators.Select<Encounter, Tuple_DBZhWNcHciGGJUSXZKiOPXJYf>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Systolic Blood Pressure")]
	public IEnumerable<Tuple_DBZhWNcHciGGJUSXZKiOPXJYf> Risk_Variable_Systolic_Blood_Pressure() => 
		__Risk_Variable_Systolic_Blood_Pressure.Value;

    [CqlDeclaration("pOAIsNoOrUTD")]
	public IEnumerable<CqlConcept> pOAIsNoOrUTD(Encounter TheEncounter)
	{
		bool? a_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			bool? e_(Extension @this)
			{
				FhirUri n_ = context.Operators.Convert<FhirUri>(@this?.Url);
				string o_ = FHIRHelpers_4_3_000.ToString(n_);
				bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

				return p_;
			};
			IEnumerable<Extension> f_ = context.Operators.Where<Extension>(((EncounterDiagnoses is Element)
					? ((EncounterDiagnoses as Element).Extension)
					: null), e_);
			DataType g_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> h_ = context.Operators.Select<Extension, DataType>(f_, g_);
			DataType i_ = context.Operators.SingletonFrom<DataType>(h_);
			CodeableConcept j_ = context.Operators.Convert<CodeableConcept>(i_);
			CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_);
			CqlValueSet l_ = this.Present_on_Admission_is_No_or_Unable_To_Determine();
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);

			return m_;
		};
		IEnumerable<Encounter.DiagnosisComponent> b_ = context.Operators.Where<Encounter.DiagnosisComponent>((TheEncounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		CqlConcept c_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			Condition q_ = CQMCommon_2_0_000.getCondition(EncounterDiagnoses?.Condition);
			CqlConcept r_ = FHIRHelpers_4_3_000.ToConcept(q_?.Code);

			return r_;
		};
		IEnumerable<CqlConcept> d_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(b_, c_);

		return d_;
	}

}
