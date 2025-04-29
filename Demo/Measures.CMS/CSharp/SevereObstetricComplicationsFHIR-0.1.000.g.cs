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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("SevereObstetricComplicationsFHIR", "0.1.000")]
public partial class SevereObstetricComplicationsFHIR_0_1_000 : ILibrary, ISingleton<SevereObstetricComplicationsFHIR_0_1_000>
{
    private SevereObstetricComplicationsFHIR_0_1_000() {}

    public static SevereObstetricComplicationsFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "SevereObstetricComplicationsFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, PCMaternal_5_19_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: 20 to 42 Plus Weeks Gestation
    [CqlValueSetDefinition(
        definitionName: "20 to 42 Plus Weeks Gestation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67",
        valueSetVersion: null)]
    public CqlValueSet _20_to_42_Plus_Weeks_Gestation(CqlContext context) => __20_to_42_Plus_Weeks_Gestation;

    private static readonly CqlValueSet __20_to_42_Plus_Weeks_Gestation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67", null);
    #endregion

    #region ValueSet: Acute Heart Failure
    [CqlValueSetDefinition(
        definitionName: "Acute Heart Failure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.233",
        valueSetVersion: null)]
    public CqlValueSet Acute_Heart_Failure(CqlContext context) => _Acute_Heart_Failure;

    private static readonly CqlValueSet _Acute_Heart_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.233", null);
    #endregion

    #region ValueSet: Acute Myocardial Infarction
    [CqlValueSetDefinition(
        definitionName: "Acute Myocardial Infarction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.623",
        valueSetVersion: null)]
    public CqlValueSet Acute_Myocardial_Infarction(CqlContext context) => _Acute_Myocardial_Infarction;

    private static readonly CqlValueSet _Acute_Myocardial_Infarction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.623", null);
    #endregion

    #region ValueSet: Acute or Persistent Asthma
    [CqlValueSetDefinition(
        definitionName: "Acute or Persistent Asthma",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271",
        valueSetVersion: null)]
    public CqlValueSet Acute_or_Persistent_Asthma(CqlContext context) => _Acute_or_Persistent_Asthma;

    private static readonly CqlValueSet _Acute_or_Persistent_Asthma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271", null);
    #endregion

    #region ValueSet: Acute Renal Failure
    [CqlValueSetDefinition(
        definitionName: "Acute Renal Failure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.53",
        valueSetVersion: null)]
    public CqlValueSet Acute_Renal_Failure(CqlContext context) => _Acute_Renal_Failure;

    private static readonly CqlValueSet _Acute_Renal_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.53", null);
    #endregion

    #region ValueSet: Acute Respiratory Distress Syndrome
    [CqlValueSetDefinition(
        definitionName: "Acute Respiratory Distress Syndrome",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.214",
        valueSetVersion: null)]
    public CqlValueSet Acute_Respiratory_Distress_Syndrome(CqlContext context) => _Acute_Respiratory_Distress_Syndrome;

    private static readonly CqlValueSet _Acute_Respiratory_Distress_Syndrome = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.214", null);
    #endregion

    #region ValueSet: Air and Thrombotic Embolism
    [CqlValueSetDefinition(
        definitionName: "Air and Thrombotic Embolism",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.243",
        valueSetVersion: null)]
    public CqlValueSet Air_and_Thrombotic_Embolism(CqlContext context) => _Air_and_Thrombotic_Embolism;

    private static readonly CqlValueSet _Air_and_Thrombotic_Embolism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.243", null);
    #endregion

    #region ValueSet: Amniotic Fluid Embolism
    [CqlValueSetDefinition(
        definitionName: "Amniotic Fluid Embolism",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.217",
        valueSetVersion: null)]
    public CqlValueSet Amniotic_Fluid_Embolism(CqlContext context) => _Amniotic_Fluid_Embolism;

    private static readonly CqlValueSet _Amniotic_Fluid_Embolism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.217", null);
    #endregion

    #region ValueSet: Anemia
    [CqlValueSetDefinition(
        definitionName: "Anemia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323",
        valueSetVersion: null)]
    public CqlValueSet Anemia(CqlContext context) => _Anemia;

    private static readonly CqlValueSet _Anemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323", null);
    #endregion

    #region ValueSet: Aortic Aneurysm
    [CqlValueSetDefinition(
        definitionName: "Aortic Aneurysm",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.219",
        valueSetVersion: null)]
    public CqlValueSet Aortic_Aneurysm(CqlContext context) => _Aortic_Aneurysm;

    private static readonly CqlValueSet _Aortic_Aneurysm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.219", null);
    #endregion

    #region ValueSet: Autoimmune Disease
    [CqlValueSetDefinition(
        definitionName: "Autoimmune Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311",
        valueSetVersion: null)]
    public CqlValueSet Autoimmune_Disease(CqlContext context) => _Autoimmune_Disease;

    private static readonly CqlValueSet _Autoimmune_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311", null);
    #endregion

    #region ValueSet: Bariatric Surgery
    [CqlValueSetDefinition(
        definitionName: "Bariatric Surgery",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317",
        valueSetVersion: null)]
    public CqlValueSet Bariatric_Surgery(CqlContext context) => _Bariatric_Surgery;

    private static readonly CqlValueSet _Bariatric_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317", null);
    #endregion

    #region ValueSet: Bleeding Disorder
    [CqlValueSetDefinition(
        definitionName: "Bleeding Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287",
        valueSetVersion: null)]
    public CqlValueSet Bleeding_Disorder(CqlContext context) => _Bleeding_Disorder;

    private static readonly CqlValueSet _Bleeding_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287", null);
    #endregion

    #region ValueSet: Blood Transfusion
    [CqlValueSetDefinition(
        definitionName: "Blood Transfusion",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213",
        valueSetVersion: null)]
    public CqlValueSet Blood_Transfusion(CqlContext context) => _Blood_Transfusion;

    private static readonly CqlValueSet _Blood_Transfusion = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213", null);
    #endregion

    #region ValueSet: Cardiac Arrest Ventricular Fibrillation
    [CqlValueSetDefinition(
        definitionName: "Cardiac Arrest Ventricular Fibrillation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.221",
        valueSetVersion: null)]
    public CqlValueSet Cardiac_Arrest_Ventricular_Fibrillation(CqlContext context) => _Cardiac_Arrest_Ventricular_Fibrillation;

    private static readonly CqlValueSet _Cardiac_Arrest_Ventricular_Fibrillation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.221", null);
    #endregion

    #region ValueSet: Cardiac Disease
    [CqlValueSetDefinition(
        definitionName: "Cardiac Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341",
        valueSetVersion: null)]
    public CqlValueSet Cardiac_Disease(CqlContext context) => _Cardiac_Disease;

    private static readonly CqlValueSet _Cardiac_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341", null);
    #endregion

    #region ValueSet: Conversion of Cardiac Rhythm
    [CqlValueSetDefinition(
        definitionName: "Conversion of Cardiac Rhythm",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.357",
        valueSetVersion: null)]
    public CqlValueSet Conversion_of_Cardiac_Rhythm(CqlContext context) => _Conversion_of_Cardiac_Rhythm;

    private static readonly CqlValueSet _Conversion_of_Cardiac_Rhythm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.357", null);
    #endregion

    #region ValueSet: COVID 19 Confirmed
    [CqlValueSetDefinition(
        definitionName: "COVID 19 Confirmed",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373",
        valueSetVersion: null)]
    public CqlValueSet COVID_19_Confirmed(CqlContext context) => _COVID_19_Confirmed;

    private static readonly CqlValueSet _COVID_19_Confirmed = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373", null);
    #endregion

    #region ValueSet: Delivery Procedures
    [CqlValueSetDefinition(
        definitionName: "Delivery Procedures",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59",
        valueSetVersion: null)]
    public CqlValueSet Delivery_Procedures(CqlContext context) => _Delivery_Procedures;

    private static readonly CqlValueSet _Delivery_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);
    #endregion

    #region ValueSet: Disseminated Intravascular Coagulation
    [CqlValueSetDefinition(
        definitionName: "Disseminated Intravascular Coagulation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.223",
        valueSetVersion: null)]
    public CqlValueSet Disseminated_Intravascular_Coagulation(CqlContext context) => _Disseminated_Intravascular_Coagulation;

    private static readonly CqlValueSet _Disseminated_Intravascular_Coagulation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.223", null);
    #endregion

    #region ValueSet: Eclampsia
    [CqlValueSetDefinition(
        definitionName: "Eclampsia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.225",
        valueSetVersion: null)]
    public CqlValueSet Eclampsia(CqlContext context) => _Eclampsia;

    private static readonly CqlValueSet _Eclampsia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.225", null);
    #endregion

    #region ValueSet: Economic Housing Instability
    [CqlValueSetDefinition(
        definitionName: "Economic Housing Instability",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292",
        valueSetVersion: null)]
    public CqlValueSet Economic_Housing_Instability(CqlContext context) => _Economic_Housing_Instability;

    private static readonly CqlValueSet _Economic_Housing_Instability = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292", null);
    #endregion

    #region ValueSet: ED Visit and OB Triage
    [CqlValueSetDefinition(
        definitionName: "ED Visit and OB Triage",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369",
        valueSetVersion: null)]
    public CqlValueSet ED_Visit_and_OB_Triage(CqlContext context) => _ED_Visit_and_OB_Triage;

    private static readonly CqlValueSet _ED_Visit_and_OB_Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Estimated Gestational Age at Delivery
    [CqlValueSetDefinition(
        definitionName: "Estimated Gestational Age at Delivery",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26",
        valueSetVersion: null)]
    public CqlValueSet Estimated_Gestational_Age_at_Delivery(CqlContext context) => _Estimated_Gestational_Age_at_Delivery;

    private static readonly CqlValueSet _Estimated_Gestational_Age_at_Delivery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", null);
    #endregion

    #region ValueSet: Ethnicity
    [CqlValueSetDefinition(
        definitionName: "Ethnicity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837",
        valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext context) => _Ethnicity;

    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);
    #endregion

    #region ValueSet: Gastrointestinal Disease
    [CqlValueSetDefinition(
        definitionName: "Gastrointestinal Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338",
        valueSetVersion: null)]
    public CqlValueSet Gastrointestinal_Disease(CqlContext context) => _Gastrointestinal_Disease;

    private static readonly CqlValueSet _Gastrointestinal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338", null);
    #endregion

    #region ValueSet: Gestational Diabetes
    [CqlValueSetDefinition(
        definitionName: "Gestational Diabetes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269",
        valueSetVersion: null)]
    public CqlValueSet Gestational_Diabetes(CqlContext context) => _Gestational_Diabetes;

    private static readonly CqlValueSet _Gestational_Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269", null);
    #endregion

    #region ValueSet: Heart Failure Cardiac Arrest Related to Procedure or Surgery
    [CqlValueSetDefinition(
        definitionName: "Heart Failure Cardiac Arrest Related to Procedure or Surgery",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.227",
        valueSetVersion: null)]
    public CqlValueSet Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(CqlContext context) => _Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery;

    private static readonly CqlValueSet _Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.227", null);
    #endregion

    #region ValueSet: Hematocrit lab test
    [CqlValueSetDefinition(
        definitionName: "Hematocrit lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114",
        valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext context) => _Hematocrit_lab_test;

    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);
    #endregion

    #region ValueSet: HIV in Pregnancy Childbirth and Puerperium
    [CqlValueSetDefinition(
        definitionName: "HIV in Pregnancy Childbirth and Puerperium",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272",
        valueSetVersion: null)]
    public CqlValueSet HIV_in_Pregnancy_Childbirth_and_Puerperium(CqlContext context) => _HIV_in_Pregnancy_Childbirth_and_Puerperium;

    private static readonly CqlValueSet _HIV_in_Pregnancy_Childbirth_and_Puerperium = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272", null);
    #endregion

    #region ValueSet: Hypertension
    [CqlValueSetDefinition(
        definitionName: "Hypertension",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332",
        valueSetVersion: null)]
    public CqlValueSet Hypertension(CqlContext context) => _Hypertension;

    private static readonly CqlValueSet _Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332", null);
    #endregion

    #region ValueSet: Hysterectomy
    [CqlValueSetDefinition(
        definitionName: "Hysterectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.358",
        valueSetVersion: null)]
    public CqlValueSet Hysterectomy(CqlContext context) => _Hysterectomy;

    private static readonly CqlValueSet _Hysterectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.358", null);
    #endregion

    #region ValueSet: Long Term Anticoagulant Use
    [CqlValueSetDefinition(
        definitionName: "Long Term Anticoagulant Use",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366",
        valueSetVersion: null)]
    public CqlValueSet Long_Term_Anticoagulant_Use(CqlContext context) => _Long_Term_Anticoagulant_Use;

    private static readonly CqlValueSet _Long_Term_Anticoagulant_Use = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366", null);
    #endregion

    #region ValueSet: Mental Health Disorder
    [CqlValueSetDefinition(
        definitionName: "Mental Health Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314",
        valueSetVersion: null)]
    public CqlValueSet Mental_Health_Disorder(CqlContext context) => _Mental_Health_Disorder;

    private static readonly CqlValueSet _Mental_Health_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314", null);
    #endregion

    #region ValueSet: Mild or Moderate Preeclampsia
    [CqlValueSetDefinition(
        definitionName: "Mild or Moderate Preeclampsia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329",
        valueSetVersion: null)]
    public CqlValueSet Mild_or_Moderate_Preeclampsia(CqlContext context) => _Mild_or_Moderate_Preeclampsia;

    private static readonly CqlValueSet _Mild_or_Moderate_Preeclampsia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329", null);
    #endregion

    #region ValueSet: Morbid or Severe Obesity
    [CqlValueSetDefinition(
        definitionName: "Morbid or Severe Obesity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290",
        valueSetVersion: null)]
    public CqlValueSet Morbid_or_Severe_Obesity(CqlContext context) => _Morbid_or_Severe_Obesity;

    private static readonly CqlValueSet _Morbid_or_Severe_Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290", null);
    #endregion

    #region ValueSet: Multiple Pregnancy
    [CqlValueSetDefinition(
        definitionName: "Multiple Pregnancy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284",
        valueSetVersion: null)]
    public CqlValueSet Multiple_Pregnancy(CqlContext context) => _Multiple_Pregnancy;

    private static readonly CqlValueSet _Multiple_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284", null);
    #endregion

    #region ValueSet: Neuromuscular Disease
    [CqlValueSetDefinition(
        definitionName: "Neuromuscular Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308",
        valueSetVersion: null)]
    public CqlValueSet Neuromuscular_Disease(CqlContext context) => _Neuromuscular_Disease;

    private static readonly CqlValueSet _Neuromuscular_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: ONC Administrative Sex
    [CqlValueSetDefinition(
        definitionName: "ONC Administrative Sex",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1",
        valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) => _ONC_Administrative_Sex;

    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);
    #endregion

    #region ValueSet: Patient Expired
    [CqlValueSetDefinition(
        definitionName: "Patient Expired",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309",
        valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext context) => _Patient_Expired;

    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);
    #endregion

    #region ValueSet: Payer Type
    [CqlValueSetDefinition(
        definitionName: "Payer Type",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591",
        valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext context) => _Payer_Type;

    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);
    #endregion

    #region ValueSet: Placenta Accreta
    [CqlValueSetDefinition(
        definitionName: "Placenta Accreta",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302",
        valueSetVersion: null)]
    public CqlValueSet Placenta_Accreta(CqlContext context) => _Placenta_Accreta;

    private static readonly CqlValueSet _Placenta_Accreta = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", null);
    #endregion

    #region ValueSet: Placenta Increta or Percreta
    [CqlValueSetDefinition(
        definitionName: "Placenta Increta or Percreta",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.388",
        valueSetVersion: null)]
    public CqlValueSet Placenta_Increta_or_Percreta(CqlContext context) => _Placenta_Increta_or_Percreta;

    private static readonly CqlValueSet _Placenta_Increta_or_Percreta = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.388", null);
    #endregion

    #region ValueSet: Placenta Previa
    [CqlValueSetDefinition(
        definitionName: "Placenta Previa",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.78",
        valueSetVersion: null)]
    public CqlValueSet Placenta_Previa(CqlContext context) => _Placenta_Previa;

    private static readonly CqlValueSet _Placenta_Previa = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.78", null);
    #endregion

    #region ValueSet: Placental Abruption
    [CqlValueSetDefinition(
        definitionName: "Placental Abruption",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305",
        valueSetVersion: null)]
    public CqlValueSet Placental_Abruption(CqlContext context) => _Placental_Abruption;

    private static readonly CqlValueSet _Placental_Abruption = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305", null);
    #endregion

    #region ValueSet: Placental Accreta Spectrum
    [CqlValueSetDefinition(
        definitionName: "Placental Accreta Spectrum",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302",
        valueSetVersion: null)]
    public CqlValueSet Placental_Accreta_Spectrum(CqlContext context) => _Placental_Accreta_Spectrum;

    private static readonly CqlValueSet _Placental_Accreta_Spectrum = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", null);
    #endregion

    #region ValueSet: Preexisting Diabetes
    [CqlValueSetDefinition(
        definitionName: "Preexisting Diabetes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275",
        valueSetVersion: null)]
    public CqlValueSet Preexisting_Diabetes(CqlContext context) => _Preexisting_Diabetes;

    private static readonly CqlValueSet _Preexisting_Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275", null);
    #endregion

    #region ValueSet: Present on Admission is No or Unable To Determine
    [CqlValueSetDefinition(
        definitionName: "Present on Admission is No or Unable To Determine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370",
        valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_is_No_or_Unable_To_Determine(CqlContext context) => _Present_on_Admission_is_No_or_Unable_To_Determine;

    private static readonly CqlValueSet _Present_on_Admission_is_No_or_Unable_To_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370", null);
    #endregion

    #region ValueSet: Present On Admission is Yes or Exempt
    [CqlValueSetDefinition(
        definitionName: "Present On Admission is Yes or Exempt",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63",
        valueSetVersion: null)]
    public CqlValueSet Present_On_Admission_is_Yes_or_Exempt(CqlContext context) => _Present_On_Admission_is_Yes_or_Exempt;

    private static readonly CqlValueSet _Present_On_Admission_is_Yes_or_Exempt = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63", null);
    #endregion

    #region ValueSet: Preterm Birth
    [CqlValueSetDefinition(
        definitionName: "Preterm Birth",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299",
        valueSetVersion: null)]
    public CqlValueSet Preterm_Birth(CqlContext context) => _Preterm_Birth;

    private static readonly CqlValueSet _Preterm_Birth = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299", null);
    #endregion

    #region ValueSet: Previous Cesarean
    [CqlValueSetDefinition(
        definitionName: "Previous Cesarean",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278",
        valueSetVersion: null)]
    public CqlValueSet Previous_Cesarean(CqlContext context) => _Previous_Cesarean;

    private static readonly CqlValueSet _Previous_Cesarean = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278", null);
    #endregion

    #region ValueSet: Puerperal Cerebrovascular Disorder
    [CqlValueSetDefinition(
        definitionName: "Puerperal Cerebrovascular Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.229",
        valueSetVersion: null)]
    public CqlValueSet Puerperal_Cerebrovascular_Disorder(CqlContext context) => _Puerperal_Cerebrovascular_Disorder;

    private static readonly CqlValueSet _Puerperal_Cerebrovascular_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.229", null);
    #endregion

    #region ValueSet: Pulmonary Edema
    [CqlValueSetDefinition(
        definitionName: "Pulmonary Edema",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.231",
        valueSetVersion: null)]
    public CqlValueSet Pulmonary_Edema(CqlContext context) => _Pulmonary_Edema;

    private static readonly CqlValueSet _Pulmonary_Edema = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.231", null);
    #endregion

    #region ValueSet: Pulmonary Hypertension
    [CqlValueSetDefinition(
        definitionName: "Pulmonary Hypertension",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281",
        valueSetVersion: null)]
    public CqlValueSet Pulmonary_Hypertension(CqlContext context) => _Pulmonary_Hypertension;

    private static readonly CqlValueSet _Pulmonary_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281", null);
    #endregion

    #region ValueSet: Race
    [CqlValueSetDefinition(
        definitionName: "Race",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836",
        valueSetVersion: null)]
    public CqlValueSet Race(CqlContext context) => _Race;

    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);
    #endregion

    #region ValueSet: Renal Disease
    [CqlValueSetDefinition(
        definitionName: "Renal Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335",
        valueSetVersion: null)]
    public CqlValueSet Renal_Disease(CqlContext context) => _Renal_Disease;

    private static readonly CqlValueSet _Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335", null);
    #endregion

    #region ValueSet: Respiratory Conditions Related to COVID 19
    [CqlValueSetDefinition(
        definitionName: "Respiratory Conditions Related to COVID 19",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376",
        valueSetVersion: null)]
    public CqlValueSet Respiratory_Conditions_Related_to_COVID_19(CqlContext context) => _Respiratory_Conditions_Related_to_COVID_19;

    private static readonly CqlValueSet _Respiratory_Conditions_Related_to_COVID_19 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376", null);
    #endregion

    #region ValueSet: Respiratory Support Procedures Related to COVID 19
    [CqlValueSetDefinition(
        definitionName: "Respiratory Support Procedures Related to COVID 19",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379",
        valueSetVersion: null)]
    public CqlValueSet Respiratory_Support_Procedures_Related_to_COVID_19(CqlContext context) => _Respiratory_Support_Procedures_Related_to_COVID_19;

    private static readonly CqlValueSet _Respiratory_Support_Procedures_Related_to_COVID_19 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379", null);
    #endregion

    #region ValueSet: Sepsis
    [CqlValueSetDefinition(
        definitionName: "Sepsis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.237",
        valueSetVersion: null)]
    public CqlValueSet Sepsis(CqlContext context) => _Sepsis;

    private static readonly CqlValueSet _Sepsis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.237", null);
    #endregion

    #region ValueSet: Severe Anesthesia Complications
    [CqlValueSetDefinition(
        definitionName: "Severe Anesthesia Complications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.235",
        valueSetVersion: null)]
    public CqlValueSet Severe_Anesthesia_Complications(CqlContext context) => _Severe_Anesthesia_Complications;

    private static readonly CqlValueSet _Severe_Anesthesia_Complications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.235", null);
    #endregion

    #region ValueSet: Severe Maternal Morbidity Diagnoses
    [CqlValueSetDefinition(
        definitionName: "Severe Maternal Morbidity Diagnoses",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255",
        valueSetVersion: null)]
    public CqlValueSet Severe_Maternal_Morbidity_Diagnoses(CqlContext context) => _Severe_Maternal_Morbidity_Diagnoses;

    private static readonly CqlValueSet _Severe_Maternal_Morbidity_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255", null);
    #endregion

    #region ValueSet: Severe Maternal Morbidity Procedures
    [CqlValueSetDefinition(
        definitionName: "Severe Maternal Morbidity Procedures",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256",
        valueSetVersion: null)]
    public CqlValueSet Severe_Maternal_Morbidity_Procedures(CqlContext context) => _Severe_Maternal_Morbidity_Procedures;

    private static readonly CqlValueSet _Severe_Maternal_Morbidity_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256", null);
    #endregion

    #region ValueSet: Severe Preeclampsia
    [CqlValueSetDefinition(
        definitionName: "Severe Preeclampsia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327",
        valueSetVersion: null)]
    public CqlValueSet Severe_Preeclampsia(CqlContext context) => _Severe_Preeclampsia;

    private static readonly CqlValueSet _Severe_Preeclampsia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327", null);
    #endregion

    #region ValueSet: Shock
    [CqlValueSetDefinition(
        definitionName: "Shock",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.239",
        valueSetVersion: null)]
    public CqlValueSet Shock(CqlContext context) => _Shock;

    private static readonly CqlValueSet _Shock = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.239", null);
    #endregion

    #region ValueSet: Sickle Cell Disease with Crisis
    [CqlValueSetDefinition(
        definitionName: "Sickle Cell Disease with Crisis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.241",
        valueSetVersion: null)]
    public CqlValueSet Sickle_Cell_Disease_with_Crisis(CqlContext context) => _Sickle_Cell_Disease_with_Crisis;

    private static readonly CqlValueSet _Sickle_Cell_Disease_with_Crisis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.241", null);
    #endregion

    #region ValueSet: Substance Abuse
    [CqlValueSetDefinition(
        definitionName: "Substance Abuse",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320",
        valueSetVersion: null)]
    public CqlValueSet Substance_Abuse(CqlContext context) => _Substance_Abuse;

    private static readonly CqlValueSet _Substance_Abuse = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320", null);
    #endregion

    #region ValueSet: Thyrotoxicosis
    [CqlValueSetDefinition(
        definitionName: "Thyrotoxicosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296",
        valueSetVersion: null)]
    public CqlValueSet Thyrotoxicosis(CqlContext context) => _Thyrotoxicosis;

    private static readonly CqlValueSet _Thyrotoxicosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296", null);
    #endregion

    #region ValueSet: Tracheostomy
    [CqlValueSetDefinition(
        definitionName: "Tracheostomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.359",
        valueSetVersion: null)]
    public CqlValueSet Tracheostomy(CqlContext context) => _Tracheostomy;

    private static readonly CqlValueSet _Tracheostomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.359", null);
    #endregion

    #region ValueSet: Venous Thromboembolism in Pregnancy
    [CqlValueSetDefinition(
        definitionName: "Venous Thromboembolism in Pregnancy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363",
        valueSetVersion: null)]
    public CqlValueSet Venous_Thromboembolism_in_Pregnancy(CqlContext context) => _Venous_Thromboembolism_in_Pregnancy;

    private static readonly CqlValueSet _Venous_Thromboembolism_in_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363", null);
    #endregion

    #region ValueSet: Ventilation
    [CqlValueSetDefinition(
        definitionName: "Ventilation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.360",
        valueSetVersion: null)]
    public CqlValueSet Ventilation(CqlContext context) => _Ventilation;

    private static readonly CqlValueSet _Ventilation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.360", null);
    #endregion

    #region ValueSet: White blood cells count lab test
    [CqlValueSetDefinition(
        definitionName: "White blood cells count lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129",
        valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext context) => _White_blood_cells_count_lab_test;

    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Heart rate
    [CqlCodeDefinition(
        definitionName: "Heart rate",
        codeId: "8867-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext context) => _Heart_rate;

    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org", default, default);
    #endregion

    #region Code: Systolic blood pressure
    [CqlCodeDefinition(
        definitionName: "Systolic blood pressure",
        codeId: "8480-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext context) => _Systolic_blood_pressure;

    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzzzzzzzzzv_ = [
            new CqlCode("8867-4", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return mzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] mzzzzzzzzzzzzzzzzzzw_ = []
;

        return mzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzy_, true, true);
        object nzzzzzzzzzzzzzzzzzza_ = context.ResolveParameter("SevereObstetricComplicationsFHIR-0.1.000", "Measurement Period", mzzzzzzzzzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)nzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient nzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzzzzzzzzzzzb_);

        return nzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return nzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Calculated Gestational Age Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? nzzzzzzzzzzzzzzzzzzj_(Encounter DeliveryEncounter)
        {
            int? nzzzzzzzzzzzzzzzzzzl_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? nzzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzzzzl_, 20);

            return nzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzj_);

        return nzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Estimated Gestational Age Assessment Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? nzzzzzzzzzzzzzzzzzzo_(Encounter DeliveryEncounter)
        {
            int? nzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity nzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity nzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(20m, "weeks");
            bool? nzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzs_);
            bool? nzzzzzzzzzzzzzzzzzzu_ = context.Operators.And((bool?)(nzzzzzzzzzzzzzzzzzzq_ is null), nzzzzzzzzzzzzzzzzzzt_);

            return nzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Gestational Age Greater than or Equal to 20 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? nzzzzzzzzzzzzzzzzzzw_(Encounter DeliveryEncounter)
        {
            int? nzzzzzzzzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity nzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? ozzzzzzzzzzzzzzzzzza_ = context.Operators.And((bool?)(nzzzzzzzzzzzzzzzzzzy_ is null), (bool?)(nzzzzzzzzzzzzzzzzzzz_ is null));
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? ozzzzzzzzzzzzzzzzzzc_(Condition EncounterDiagnosis)
            {
                CodeableConcept ozzzzzzzzzzzzzzzzzzg_ = EncounterDiagnosis?.Code;
                CqlConcept ozzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzg_);
                CqlValueSet ozzzzzzzzzzzzzzzzzzi_ = this._20_to_42_Plus_Weeks_Gestation(context);
                bool? ozzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzi_);

                return ozzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzc_);
            bool? ozzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzze_);

            return ozzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzw_);

        return nzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters At Greater than or Equal to 20 Weeks Gestation")]
    public IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzn_);

        return ozzzzzzzzzzzzzzzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlConcept> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> ozzzzzzzzzzzzzzzzzzp_ = TheEncounter?.Diagnosis;
        bool? ozzzzzzzzzzzzzzzzzzq_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? ozzzzzzzzzzzzzzzzzzv_(Extension @this)
            {
                string pzzzzzzzzzzzzzzzzzzd_ = @this?.Url;
                FhirString pzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(pzzzzzzzzzzzzzzzzzzd_);
                string pzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzzzzze_);
                bool? pzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return pzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Extension> ozzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), ozzzzzzzzzzzzzzzzzzv_);
            object ozzzzzzzzzzzzzzzzzzx_(Extension @this)
            {
                DataType pzzzzzzzzzzzzzzzzzzh_ = @this?.Value;

                return pzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<object> ozzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(ozzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzx_);
            object ozzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(ozzzzzzzzzzzzzzzzzzy_);
            CqlConcept pzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzz_ as CodeableConcept);
            CqlValueSet pzzzzzzzzzzzzzzzzzzb_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? pzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzb_);

            return pzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter.DiagnosisComponent> ozzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)ozzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzq_);
        CqlConcept ozzzzzzzzzzzzzzzzzzs_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference pzzzzzzzzzzzzzzzzzzi_ = EncounterDiagnoses?.Condition;
            Condition pzzzzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.getCondition(context, pzzzzzzzzzzzzzzzzzzi_);
            CodeableConcept pzzzzzzzzzzzzzzzzzzk_ = pzzzzzzzzzzzzzzzzzzj_?.Code;
            CqlConcept pzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(ozzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlConcept>(ozzzzzzzzzzzzzzzzzzt_);

        return ozzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Severe Obstetric Complications Diagnosis or Procedure Excluding Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? pzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzzp_ = this.pOAIsNoOrUTD(context, TwentyWeeksPlusEncounter);
            CqlValueSet pzzzzzzzzzzzzzzzzzzq_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? pzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(pzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzs_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? pzzzzzzzzzzzzzzzzzzu_(Procedure SMMProcedures)
            {
                Code<EventStatus> pzzzzzzzzzzzzzzzzzzy_ = SMMProcedures?.StatusElement;
                EventStatus? pzzzzzzzzzzzzzzzzzzz_ = pzzzzzzzzzzzzzzzzzzy_?.Value;
                string qzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzz_);
                bool? qzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzza_, "completed");
                DataType qzzzzzzzzzzzzzzzzzzc_ = SMMProcedures?.Performed;
                object qzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzg_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? qzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzg_, "day");
                bool? qzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzh_);

                return qzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzu_);
            bool? pzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(pzzzzzzzzzzzzzzzzzzv_);
            bool? pzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzw_);

            return pzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Expiration")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Expiration(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? qzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            Encounter.HospitalizationComponent qzzzzzzzzzzzzzzzzzzm_ = TwentyWeeksPlusEncounter?.Hospitalization;
            CodeableConcept qzzzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzzzm_?.DischargeDisposition;
            CqlConcept qzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzp_ = this.Patient_Expired(context);
            bool? qzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzp_);

            return qzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzs_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzu_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? qzzzzzzzzzzzzzzzzzzw_(Procedure BloodTransfusion)
            {
                Code<EventStatus> rzzzzzzzzzzzzzzzzzza_ = BloodTransfusion?.StatusElement;
                EventStatus? rzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzza_?.Value;
                string rzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzb_);
                bool? rzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzc_, "completed");
                DataType rzzzzzzzzzzzzzzzzzze_ = BloodTransfusion?.Performed;
                object rzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? rzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzi_, "day");
                bool? rzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzj_);

                return rzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzw_);
            Encounter qzzzzzzzzzzzzzzzzzzy_(Procedure BloodTransfusion) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, Encounter>(qzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzy_);

            return qzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzs_);

        return qzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Severe Obstetric Complications")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Hysterectomy")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Hysterectomy(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzq_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzr_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet rzzzzzzzzzzzzzzzzzzt_ = this.Hysterectomy(context);
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? rzzzzzzzzzzzzzzzzzzv_(Procedure Hysterectomy)
            {
                Code<EventStatus> rzzzzzzzzzzzzzzzzzzz_ = Hysterectomy?.StatusElement;
                EventStatus? szzzzzzzzzzzzzzzzzza_ = rzzzzzzzzzzzzzzzzzzz_?.Value;
                string szzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzza_);
                bool? szzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzb_, "completed");
                DataType szzzzzzzzzzzzzzzzzzd_ = Hysterectomy?.Performed;
                object szzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzze_);
                CqlDateTime szzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? szzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzh_, "day");
                bool? szzzzzzzzzzzzzzzzzzj_ = context.Operators.And(szzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzi_);

                return szzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzv_);
            Encounter rzzzzzzzzzzzzzzzzzzx_(Procedure Hysterectomy) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, Encounter>(rzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzx_);

            return rzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzr_);

        return rzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Procedure> Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzk_ = this.Conversion_of_Cardiac_Rhythm(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet szzzzzzzzzzzzzzzzzzm_ = this.Tracheostomy(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Procedure>(szzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzn_);
        CqlValueSet szzzzzzzzzzzzzzzzzzp_ = this.Ventilation(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Procedure>(szzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzq_);

        return szzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzt_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzv_ = this.Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
            bool? szzzzzzzzzzzzzzzzzzw_(Procedure ConvTrachVentProcedures)
            {
                Code<EventStatus> tzzzzzzzzzzzzzzzzzza_ = ConvTrachVentProcedures?.StatusElement;
                EventStatus? tzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzza_?.Value;
                string tzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzb_);
                bool? tzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzc_, "completed");
                DataType tzzzzzzzzzzzzzzzzzze_ = ConvTrachVentProcedures?.Performed;
                object tzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? tzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzi_, "day");
                bool? tzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzj_);

                return tzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzw_);
            Encounter szzzzzzzzzzzzzzzzzzy_(Procedure ConvTrachVentProcedures) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, Encounter>(szzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzy_);

            return szzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzt_);

        return szzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SOC with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        bool? tzzzzzzzzzzzzzzzzzzm_(Encounter SOCEncounter)
        {
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCEncounter);
            bool? tzzzzzzzzzzzzzzzzzzx_(Condition EncounterDiagnosis)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzzzg_ = EncounterDiagnosis?.Code;
                CqlConcept uzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzg_);
                CqlValueSet uzzzzzzzzzzzzzzzzzzi_ = this.Placenta_Increta_or_Percreta(context);
                bool? uzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzi_);

                return uzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzx_);
            bool? tzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? uzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? uzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzc_);
            bool? uzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzd_);
            bool? uzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzze_);

            return uzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzm_);
        bool? tzzzzzzzzzzzzzzzzzzp_(Encounter SOCEncounter)
        {
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzk_ = this.pOAIsNoOrUTD(context, SOCEncounter);
            CqlValueSet uzzzzzzzzzzzzzzzzzzl_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? uzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzl_);

            return uzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzv_ = context.Operators.Except<Encounter>(tzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Delivery Encounters with Severe Obstetric Complication Diagnosis")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzo_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzp_ = context.Operators.Except<Encounter>(uzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzo_);
        bool? uzzzzzzzzzzzzzzzzzzq_(Encounter Encounter)
        {
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzs_ = this.pOAIsNoOrUTD(context, Encounter);
            CqlValueSet uzzzzzzzzzzzzzzzzzzt_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? uzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzt_);

            return uzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzq_);

        return uzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Delivery Encounters with Severe Obstetric Complication Procedures")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzw_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzx_ = context.Operators.Except<Encounter>(uzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzw_);
        bool? uzzzzzzzzzzzzzzzzzzy_(Encounter Encounter)
        {
            CqlValueSet vzzzzzzzzzzzzzzzzzza_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet vzzzzzzzzzzzzzzzzzzc_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Procedure>(vzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzd_);
            bool? vzzzzzzzzzzzzzzzzzzf_(Procedure SMMProcedures)
            {
                Code<EventStatus> vzzzzzzzzzzzzzzzzzzi_ = SMMProcedures?.StatusElement;
                EventStatus? vzzzzzzzzzzzzzzzzzzj_ = vzzzzzzzzzzzzzzzzzzi_?.Value;
                string vzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzj_);
                bool? vzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzk_, "completed");
                DataType vzzzzzzzzzzzzzzzzzzm_ = SMMProcedures?.Performed;
                object vzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                bool? vzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzq_, "day");
                bool? vzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzr_);

                return vzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzf_);
            bool? vzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzzzzzzzzzg_);

            return vzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzzzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string sOCDxCategory(CqlContext context, CqlConcept Dx)
    {
        string vzzzzzzzzzzzzzzzzzzt_()
        {
            bool vzzzzzzzzzzzzzzzzzzu_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzl_ = this.Acute_Heart_Failure(context);
                bool? wzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzl_);

                return wzzzzzzzzzzzzzzzzzzm_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzv_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzn_ = this.Acute_Myocardial_Infarction(context);
                bool? wzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzn_);

                return wzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzw_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzp_ = this.Acute_Renal_Failure(context);
                bool? wzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzp_);

                return wzzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzx_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzr_ = this.Acute_Respiratory_Distress_Syndrome(context);
                bool? wzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzr_);

                return wzzzzzzzzzzzzzzzzzzs_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzy_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzt_ = this.Air_and_Thrombotic_Embolism(context);
                bool? wzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzt_);

                return wzzzzzzzzzzzzzzzzzzu_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzz_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzv_ = this.Amniotic_Fluid_Embolism(context);
                bool? wzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzv_);

                return wzzzzzzzzzzzzzzzzzzw_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzza_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzx_ = this.Aortic_Aneurysm(context);
                bool? wzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzx_);

                return wzzzzzzzzzzzzzzzzzzy_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzb_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzz_ = this.Cardiac_Arrest_Ventricular_Fibrillation(context);
                bool? xzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzz_);

                return xzzzzzzzzzzzzzzzzzza_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzc_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzb_ = this.Disseminated_Intravascular_Coagulation(context);
                bool? xzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzb_);

                return xzzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzd_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzd_ = this.Eclampsia(context);
                bool? xzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzd_);

                return xzzzzzzzzzzzzzzzzzze_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzze_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzf_ = this.Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(context);
                bool? xzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzf_);

                return xzzzzzzzzzzzzzzzzzzg_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzf_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzh_ = this.Puerperal_Cerebrovascular_Disorder(context);
                bool? xzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzh_);

                return xzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzg_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzj_ = this.Pulmonary_Edema(context);
                bool? xzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzj_);

                return xzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzh_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzl_ = this.Sepsis(context);
                bool? xzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzl_);

                return xzzzzzzzzzzzzzzzzzzm_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzi_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzn_ = this.Severe_Anesthesia_Complications(context);
                bool? xzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzn_);

                return xzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzj_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzp_ = this.Shock(context);
                bool? xzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzp_);

                return xzzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzk_()
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzr_ = this.Sickle_Cell_Disease_with_Crisis(context);
                bool? xzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(Dx, xzzzzzzzzzzzzzzzzzzr_);

                return xzzzzzzzzzzzzzzzzzzs_ ?? false;
            };
            if (vzzzzzzzzzzzzzzzzzzu_())
            {
                return "Acute Heart Failure";
            }
            else if (vzzzzzzzzzzzzzzzzzzv_())
            {
                return "Acute Myocardial Infarction";
            }
            else if (vzzzzzzzzzzzzzzzzzzw_())
            {
                return "Acute Renal Failure";
            }
            else if (vzzzzzzzzzzzzzzzzzzx_())
            {
                return "Acute Respiratory Distress Syndrome";
            }
            else if (vzzzzzzzzzzzzzzzzzzy_())
            {
                return "Air and Thrombotic Embolism";
            }
            else if (vzzzzzzzzzzzzzzzzzzz_())
            {
                return "Amniotic Fluid Embolism";
            }
            else if (wzzzzzzzzzzzzzzzzzza_())
            {
                return "Aortic Aneurysm";
            }
            else if (wzzzzzzzzzzzzzzzzzzb_())
            {
                return "Cardiac Arrest Ventricular Fibrillation";
            }
            else if (wzzzzzzzzzzzzzzzzzzc_())
            {
                return "Disseminated Intravascular Coagulation";
            }
            else if (wzzzzzzzzzzzzzzzzzzd_())
            {
                return "Eclampsia";
            }
            else if (wzzzzzzzzzzzzzzzzzze_())
            {
                return "Heart Failure Cardiac Arrest Related to Procedure or Surgery";
            }
            else if (wzzzzzzzzzzzzzzzzzzf_())
            {
                return "Puerperal Cerebrovascular Disorder";
            }
            else if (wzzzzzzzzzzzzzzzzzzg_())
            {
                return "Pulmonary Edema";
            }
            else if (wzzzzzzzzzzzzzzzzzzh_())
            {
                return "Sepsis";
            }
            else if (wzzzzzzzzzzzzzzzzzzi_())
            {
                return "Severe Anesthesia Complications";
            }
            else if (wzzzzzzzzzzzzzzzzzzj_())
            {
                return "Shock";
            }
            else if (wzzzzzzzzzzzzzzzzzzk_())
            {
                return "Sickle Cell Disease with Crisis";
            }
            else
            {
                return default;
            }
        };

        return vzzzzzzzzzzzzzzzzzzt_();
    }


    [CqlExpressionDefinition(
        definitionName: "SDE SOC Diagnoses Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzt_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? xzzzzzzzzzzzzzzzzzzu_(Encounter Encounter)
        {
            Id xzzzzzzzzzzzzzzzzzzx_ = Encounter?.IdElement;
            string xzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzx_?.Value;
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzz_ = this.pOAIsNoOrUTD(context, Encounter);
            bool? yzzzzzzzzzzzzzzzzzza_(CqlConcept C)
            {
                CqlValueSet yzzzzzzzzzzzzzzzzzzg_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                bool? yzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(C, yzzzzzzzzzzzzzzzzzzg_);

                return yzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<CqlConcept>(xzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzza_);
            (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? yzzzzzzzzzzzzzzzzzzc_(CqlConcept C)
            {
                string yzzzzzzzzzzzzzzzzzzi_ = this.sOCDxCategory(context, C);
                (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? yzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_FRbAiSWEhRfKaLTXPVgFXYZAE, C, yzzzzzzzzzzzzzzzzzzi_);

                return yzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> yzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<CqlConcept, (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(yzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> yzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(yzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? yzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_RBQLXdQIRBbBEHDfOgQjdBMH, xzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzze_);

            return yzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> xzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(xzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> xzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(xzzzzzzzzzzzzzzzzzzv_);

        return xzzzzzzzzzzzzzzzzzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> sOCProcedures(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzk_ = this.Severe_Maternal_Morbidity_Procedures(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzm_ = this.Blood_Transfusion(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Procedure>(yzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzn_);
        bool? yzzzzzzzzzzzzzzzzzzp_(Procedure SMMProcedures)
        {
            Code<EventStatus> yzzzzzzzzzzzzzzzzzzr_ = SMMProcedures?.StatusElement;
            EventStatus? yzzzzzzzzzzzzzzzzzzs_ = yzzzzzzzzzzzzzzzzzzr_?.Value;
            string yzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzs_);
            bool? yzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzt_, "completed");
            DataType yzzzzzzzzzzzzzzzzzzv_ = SMMProcedures?.Performed;
            object yzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? zzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzz_, "day");
            bool? zzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzza_);

            return zzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzzzzzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string sOCProcedureCategory(CqlContext context, Procedure TheProcedure)
    {
        string zzzzzzzzzzzzzzzzzzzc_()
        {
            bool zzzzzzzzzzzzzzzzzzzd_()
            {
                CodeableConcept zzzzzzzzzzzzzzzzzzzi_ = TheProcedure?.Code;
                CqlConcept zzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzi_);
                CqlValueSet zzzzzzzzzzzzzzzzzzzk_ = this.Blood_Transfusion(context);
                bool? zzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzk_);

                return zzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool zzzzzzzzzzzzzzzzzzze_()
            {
                CodeableConcept zzzzzzzzzzzzzzzzzzzm_ = TheProcedure?.Code;
                CqlConcept zzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzm_);
                CqlValueSet zzzzzzzzzzzzzzzzzzzo_ = this.Conversion_of_Cardiac_Rhythm(context);
                bool? zzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzo_);

                return zzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            bool zzzzzzzzzzzzzzzzzzzf_()
            {
                CodeableConcept zzzzzzzzzzzzzzzzzzzq_ = TheProcedure?.Code;
                CqlConcept zzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzq_);
                CqlValueSet zzzzzzzzzzzzzzzzzzzs_ = this.Hysterectomy(context);
                bool? zzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzs_);

                return zzzzzzzzzzzzzzzzzzzt_ ?? false;
            };
            bool zzzzzzzzzzzzzzzzzzzg_()
            {
                CodeableConcept zzzzzzzzzzzzzzzzzzzu_ = TheProcedure?.Code;
                CqlConcept zzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet zzzzzzzzzzzzzzzzzzzw_ = this.Tracheostomy(context);
                bool? zzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzw_);

                return zzzzzzzzzzzzzzzzzzzx_ ?? false;
            };
            bool zzzzzzzzzzzzzzzzzzzh_()
            {
                CodeableConcept zzzzzzzzzzzzzzzzzzzy_ = TheProcedure?.Code;
                CqlConcept zzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzy_);
                CqlValueSet azzzzzzzzzzzzzzzzzzza_ = this.Ventilation(context);
                bool? azzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzza_);

                return azzzzzzzzzzzzzzzzzzzb_ ?? false;
            };
            if (zzzzzzzzzzzzzzzzzzzd_())
            {
                return "Blood Transfusion";
            }
            else if (zzzzzzzzzzzzzzzzzzze_())
            {
                return "Conversion of cardiac rhythm";
            }
            else if (zzzzzzzzzzzzzzzzzzzf_())
            {
                return "Hysterectomy";
            }
            else if (zzzzzzzzzzzzzzzzzzzg_())
            {
                return "Tracheostomy";
            }
            else if (zzzzzzzzzzzzzzzzzzzh_())
            {
                return "Ventilation";
            }
            else
            {
                return default;
            }
        };

        return zzzzzzzzzzzzzzzzzzzc_();
    }


    [CqlExpressionDefinition(
        definitionName: "SDE SOC Procedure Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzc_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? azzzzzzzzzzzzzzzzzzzd_(Encounter Encounter)
        {
            Id azzzzzzzzzzzzzzzzzzzg_ = Encounter?.IdElement;
            string azzzzzzzzzzzzzzzzzzzh_ = azzzzzzzzzzzzzzzzzzzg_?.Value;
            IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzi_ = this.sOCProcedures(context, Encounter);
            (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? azzzzzzzzzzzzzzzzzzzj_(Procedure P)
            {
                string azzzzzzzzzzzzzzzzzzzn_ = this.sOCProcedureCategory(context, P);
                (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? azzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR, P, azzzzzzzzzzzzzzzzzzzn_);

                return azzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> azzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(azzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> azzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(azzzzzzzzzzzzzzzzzzzk_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? azzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_DbihhAfJfGSKOIcQDBMEMigFK, azzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzl_);

            return azzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> azzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(azzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> azzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(azzzzzzzzzzzzzzzzzzze_);

        return azzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);

        return azzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with COVID and Respiratory Condition or Procedure")]
    public IEnumerable<Encounter> Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzq_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? azzzzzzzzzzzzzzzzzzzr_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, TwentyWeeksPlusEncounter);
            bool? azzzzzzzzzzzzzzzzzzzu_(Condition EncounterDiagnosis)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzzzi_ = EncounterDiagnosis?.Code;
                CqlConcept bzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzi_);
                CqlValueSet bzzzzzzzzzzzzzzzzzzzk_ = this.COVID_19_Confirmed(context);
                bool? bzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzk_);

                return bzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzu_);
            bool? azzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzzzv_);
            bool? azzzzzzzzzzzzzzzzzzzy_(Condition EncounterDiagnosis)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzzzm_ = EncounterDiagnosis?.Code;
                CqlConcept bzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzm_);
                CqlValueSet bzzzzzzzzzzzzzzzzzzzo_ = this.Respiratory_Conditions_Related_to_COVID_19(context);
                bool? bzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzo_);

                return bzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzy_);
            bool? bzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzb_ = this.Respiratory_Support_Procedures_Related_to_COVID_19(context);
            IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? bzzzzzzzzzzzzzzzzzzzd_(Procedure COVIDRespiratoryProcedure)
            {
                Code<EventStatus> bzzzzzzzzzzzzzzzzzzzq_ = COVIDRespiratoryProcedure?.StatusElement;
                EventStatus? bzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzq_?.Value;
                string bzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzr_);
                bool? bzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzs_, "completed");
                DataType bzzzzzzzzzzzzzzzzzzzu_ = COVIDRespiratoryProcedure?.Performed;
                object bzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? bzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzy_, "day");
                bool? czzzzzzzzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzz_);

                return czzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzd_);
            bool? bzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzzze_);
            bool? bzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzf_);
            bool? bzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzg_);

            return bzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzr_);

        return azzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(context);

        return czzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification Encounter")]
    public IEnumerable<Encounter> Stratification_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzc_ = this.Numerator(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzd_ = this.Denominator_Exclusion(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzze_ = context.Operators.Except<Encounter>(czzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratum 1")]
    public IEnumerable<Encounter> Stratum_1(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzi_ = this.Stratification_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzk_ = context.Operators.Intersect<Encounter>(czzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzj_);

        return czzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> czzzzzzzzzzzzzzzzzzzl_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return czzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);

        return czzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions Only")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzp_ = context.Operators.Intersect<Encounter>(czzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzo_);

        return czzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SOC Excluding Blood Transfusions Only with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_Excluding_Blood_Transfusions_Only_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzq_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(context);
        bool? czzzzzzzzzzzzzzzzzzzr_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);
            bool? dzzzzzzzzzzzzzzzzzzzc_(Condition EncounterDiagnoses)
            {
                CodeableConcept dzzzzzzzzzzzzzzzzzzzl_ = EncounterDiagnoses?.Code;
                CqlConcept dzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzl_);
                CqlValueSet dzzzzzzzzzzzzzzzzzzzn_ = this.Placenta_Increta_or_Percreta(context);
                bool? dzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzn_);

                return dzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(dzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? dzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? dzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzh_);
            bool? dzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzi_);
            bool? dzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzj_);

            return dzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzr_);
        bool? czzzzzzzzzzzzzzzzzzzu_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzp_ = this.pOAIsNoOrUTD(context, SOCExcludingTransfusion);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzq_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? dzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzq_);

            return dzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzza_ = context.Operators.Except<Encounter>(czzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzzzzzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlConcept> pOAIsYesOrExempt(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzzzzs_ = TheEncounter?.Diagnosis;
        bool? dzzzzzzzzzzzzzzzzzzzt_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? dzzzzzzzzzzzzzzzzzzzy_(Extension @this)
            {
                string ezzzzzzzzzzzzzzzzzzzg_ = @this?.Url;
                FhirString ezzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(ezzzzzzzzzzzzzzzzzzzg_);
                string ezzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzzzzh_);
                bool? ezzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return ezzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Extension> dzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), dzzzzzzzzzzzzzzzzzzzy_);
            object ezzzzzzzzzzzzzzzzzzza_(Extension @this)
            {
                DataType ezzzzzzzzzzzzzzzzzzzk_ = @this?.Value;

                return ezzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<object> ezzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzza_);
            object ezzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<object>(ezzzzzzzzzzzzzzzzzzzb_);
            CqlConcept ezzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzc_ as CodeableConcept);
            CqlValueSet ezzzzzzzzzzzzzzzzzzze_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? ezzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzze_);

            return ezzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzt_);
        CqlConcept dzzzzzzzzzzzzzzzzzzzv_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference ezzzzzzzzzzzzzzzzzzzl_ = EncounterDiagnoses?.Condition;
            Condition ezzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.getCondition(context, ezzzzzzzzzzzzzzzzzzzl_);
            CodeableConcept ezzzzzzzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzzzzzzzm_?.Code;
            CqlConcept ezzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzn_);

            return ezzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(dzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<CqlConcept>(dzzzzzzzzzzzzzzzzzzzw_);

        return dzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Anemia")]
    public IEnumerable<Encounter> Risk_Variable_Anemia(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzs_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzt_ = this.Anemia(context);
            bool? ezzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzt_);

            return ezzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzq_);

        return ezzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Asthma")]
    public IEnumerable<Encounter> Risk_Variable_Asthma(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzw_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzy_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzz_ = this.Acute_or_Persistent_Asthma(context);
            bool? fzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzz_);

            return fzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Autoimmune Disease")]
    public IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzc_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzze_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzf_ = this.Autoimmune_Disease(context);
            bool? fzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzf_);

            return fzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Bariatric Surgery")]
    public IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzk_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzl_ = this.Bariatric_Surgery(context);
            bool? fzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzl_);

            return fzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Bleeding Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzr_ = this.Bleeding_Disorder(context);
            bool? fzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzr_);

            return fzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Morbid Obesity")]
    public IEnumerable<Encounter> Risk_Variable_Morbid_Obesity(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzu_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzw_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzx_ = this.Morbid_or_Severe_Obesity(context);
            bool? fzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzx_);

            return fzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Cardiac Disease")]
    public IEnumerable<Encounter> Risk_Variable_Cardiac_Disease(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? gzzzzzzzzzzzzzzzzzzza_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzc_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzd_ = this.Cardiac_Disease(context);
            bool? gzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzd_);

            return gzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzza_);

        return gzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Economic Housing Instability")]
    public IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? gzzzzzzzzzzzzzzzzzzzg_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzi_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzj_ = this.Economic_Housing_Instability(context);
            bool? gzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzj_);

            return gzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzg_);

        return gzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Gastrointestinal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? gzzzzzzzzzzzzzzzzzzzm_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzo_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzp_ = this.Gastrointestinal_Disease(context);
            bool? gzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzm_);

        return gzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Gestational Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? gzzzzzzzzzzzzzzzzzzzs_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzu_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzv_ = this.Gestational_Diabetes(context);
            bool? gzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzv_);

            return gzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzs_);

        return gzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable HIV")]
    public IEnumerable<Encounter> Risk_Variable_HIV(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? gzzzzzzzzzzzzzzzzzzzy_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzza_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzb_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium(context);
            bool? hzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzb_);

            return hzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzy_);

        return gzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? hzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzh_ = this.Hypertension(context);
            bool? hzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzh_);

            return hzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzze_);

        return hzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Long Term Anticoagulant Use")]
    public IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? hzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzn_ = this.Long_Term_Anticoagulant_Use(context);
            bool? hzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzn_);

            return hzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzk_);

        return hzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Maternal Age")]
    public IEnumerable<IEnumerable<object>> Risk_Variable_Maternal_Age(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<object> hzzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            Patient hzzzzzzzzzzzzzzzzzzzt_ = this.Patient(context);
            Date hzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzt_?.BirthDateElement;
            string hzzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzzu_?.Value;
            CqlDate hzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzv_);
            Period hzzzzzzzzzzzzzzzzzzzx_ = TwentyWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzy_);
            CqlDate izzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzz_);
            int? izzzzzzzzzzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzza_, "year");
            object[] izzzzzzzzzzzzzzzzzzzc_ = [
                TwentyWeeksPlusEncounter,
izzzzzzzzzzzzzzzzzzzb_ ?? default(int),
            ];

            return izzzzzzzzzzzzzzzzzzzc_ as IEnumerable<object>;
        };
        IEnumerable<IEnumerable<object>> hzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, IEnumerable<object>>(hzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<IEnumerable<object>> hzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<IEnumerable<object>>(hzzzzzzzzzzzzzzzzzzzr_);

        return hzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Mental Health Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? izzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzg_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet izzzzzzzzzzzzzzzzzzzh_ = this.Mental_Health_Disorder(context);
            bool? izzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzh_);

            return izzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzze_);

        return izzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Multiple Pregnancy")]
    public IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? izzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet izzzzzzzzzzzzzzzzzzzn_ = this.Multiple_Pregnancy(context);
            bool? izzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzn_);

            return izzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Neuromuscular")]
    public IEnumerable<Encounter> Risk_Variable_Neuromuscular(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? izzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzs_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet izzzzzzzzzzzzzzzzzzzt_ = this.Neuromuscular_Disease(context);
            bool? izzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzt_);

            return izzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Obstetrical VTE")]
    public IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? izzzzzzzzzzzzzzzzzzzw_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzy_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet izzzzzzzzzzzzzzzzzzzz_ = this.Venous_Thromboembolism_in_Pregnancy(context);
            bool? jzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzz_);

            return jzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzw_);

        return izzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Placenta Previa")]
    public IEnumerable<Encounter> Risk_Variable_Placenta_Previa(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzc_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzze_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzf_ = this.Placenta_Previa(context);
            bool? jzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzf_);

            return jzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Placental Abruption")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Abruption(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzk_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzl_ = this.Placental_Abruption(context);
            bool? jzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzl_);

            return jzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzi_);

        return jzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Placental Accreta Spectrum")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzr_ = this.Placenta_Accreta(context);
            bool? jzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzu_ = this.Placenta_Increta_or_Percreta(context);
            bool? jzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzu_);
            bool? jzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzv_);

            return jzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzo_);

        return jzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Preexisting Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzy_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzza_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzb_ = this.Preexisting_Diabetes(context);
            bool? kzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzb_);

            return kzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzy_);

        return jzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Previous Cesarean")]
    public IEnumerable<Encounter> Risk_Variable_Previous_Cesarean(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzh_ = this.Previous_Cesarean(context);
            bool? kzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzh_);

            return kzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Pulmonary Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzn_ = this.Pulmonary_Hypertension(context);
            bool? kzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Renal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Renal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzs_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzt_ = this.Renal_Disease(context);
            bool? kzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzt_);

            return kzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzq_);

        return kzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Severe Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzw_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzy_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzz_ = this.Severe_Preeclampsia(context);
            bool? lzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzz_);

            return lzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Substance Abuse")]
    public IEnumerable<Encounter> Risk_Variable_Substance_Abuse(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? lzzzzzzzzzzzzzzzzzzzc_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzze_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzf_ = this.Substance_Abuse(context);
            bool? lzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzf_);

            return lzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzc_);

        return lzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Thyrotoxicosis")]
    public IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? lzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzk_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzl_ = this.Thyrotoxicosis(context);
            bool? lzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzl_);

            return lzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzi_);

        return lzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Other Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? lzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzr_ = this.Mild_or_Moderate_Preeclampsia(context);
            bool? lzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzr_);

            return lzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Preterm Birth")]
    public IEnumerable<Encounter> Risk_Variable_Preterm_Birth(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? lzzzzzzzzzzzzzzzzzzzu_(Encounter DeliveryEncounter)
        {
            int? mzzzzzzzzzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlInterval<int?> mzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(20, 36, true, true);
            bool? mzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<int?>(mzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzb_, default);
            CqlQuantity mzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(20m, "weeks");
            bool? mzzzzzzzzzzzzzzzzzzzg_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(36m, "weeks");
            bool? mzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LessOrEqual(mzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzj_);
            bool? mzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And((bool?)(mzzzzzzzzzzzzzzzzzzza_ is null), mzzzzzzzzzzzzzzzzzzzk_);
            bool? mzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzl_);

            return mzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzu_);
        bool? lzzzzzzzzzzzzzzzzzzzx_(Encounter DeliveryEncounter)
        {
            int? mzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? mzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And((bool?)(mzzzzzzzzzzzzzzzzzzzn_ is null), (bool?)(mzzzzzzzzzzzzzzzzzzzo_ is null));
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsYesOrExempt(context, DeliveryEncounter);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzr_ = this.Preterm_Birth(context);
            bool? mzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(mzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzr_);
            bool? mzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzs_);

            return mzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzy_);

        return lzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? mzzzzzzzzzzzzzzzzzzzv_(Encounter TwentyWeeksPlusEncounter)
        {
            Id mzzzzzzzzzzzzzzzzzzzy_ = TwentyWeeksPlusEncounter?.IdElement;
            string mzzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlValueSet nzzzzzzzzzzzzzzzzzzza_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? nzzzzzzzzzzzzzzzzzzzc_(Observation Hematocrit)
            {
                Instant nzzzzzzzzzzzzzzzzzzzu_ = Hematocrit?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzb_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzb_, true, false);
                bool? ozzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzze_ = Hematocrit?.StatusElement;
                ObservationStatus? ozzzzzzzzzzzzzzzzzzzf_ = ozzzzzzzzzzzzzzzzzzze_?.Value;
                string ozzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzf_);
                string[] ozzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzi_);
                DataType ozzzzzzzzzzzzzzzzzzzk_ = Hematocrit?.Value;
                object ozzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzk_);
                bool? ozzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzl_ is null));
                bool? ozzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzm_);

                return ozzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzc_);
            object nzzzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                Instant ozzzzzzzzzzzzzzzzzzzo_ = @this?.IssuedElement;
                DateTimeOffset? ozzzzzzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzq_ as object);

                return ozzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzf_);
            DataType nzzzzzzzzzzzzzzzzzzzh_ = nzzzzzzzzzzzzzzzzzzzg_?.Value;
            object nzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? nzzzzzzzzzzzzzzzzzzzl_(Observation Hematocrit)
            {
                Instant ozzzzzzzzzzzzzzzzzzzs_ = Hematocrit?.IssuedElement;
                DateTimeOffset? ozzzzzzzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzz_, true, false);
                bool? pzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzc_ = Hematocrit?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzzzc_?.Value;
                string pzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzd_);
                string[] pzzzzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzg_);
                DataType pzzzzzzzzzzzzzzzzzzzi_ = Hematocrit?.Value;
                object pzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzi_);
                bool? pzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzk_);

                return pzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzl_);
            object nzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                Instant pzzzzzzzzzzzzzzzzzzzm_ = @this?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzo_ as object);

                return pzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzo_);
            Instant nzzzzzzzzzzzzzzzzzzzq_ = nzzzzzzzzzzzzzzzzzzzp_?.IssuedElement;
            DateTimeOffset? nzzzzzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDateTime nzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? nzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, mzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, nzzzzzzzzzzzzzzzzzzzs_);

            return nzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzw_);

        return mzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable First White Blood Cell Count Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzq_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? pzzzzzzzzzzzzzzzzzzzr_(Encounter TwentyWeeksPlusEncounter)
        {
            Id pzzzzzzzzzzzzzzzzzzzu_ = TwentyWeeksPlusEncounter?.IdElement;
            string pzzzzzzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzzzzzzu_?.Value;
            CqlValueSet pzzzzzzzzzzzzzzzzzzzw_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? pzzzzzzzzzzzzzzzzzzzy_(Observation WBC)
            {
                Instant qzzzzzzzzzzzzzzzzzzzq_ = WBC?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzx_, true, false);
                bool? qzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzza_ = WBC?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzza_?.Value;
                string rzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzb_);
                string[] rzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzze_);
                DataType rzzzzzzzzzzzzzzzzzzzg_ = WBC?.Value;
                object rzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzg_);
                bool? rzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? rzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzi_);

                return rzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzy_);
            object qzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                Instant rzzzzzzzzzzzzzzzzzzzk_ = @this?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzl_ = rzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzm_ as object);

                return rzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzb_);
            DataType qzzzzzzzzzzzzzzzzzzzd_ = qzzzzzzzzzzzzzzzzzzzc_?.Value;
            object qzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? qzzzzzzzzzzzzzzzzzzzh_(Observation WBC)
            {
                Instant rzzzzzzzzzzzzzzzzzzzo_ = WBC?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzv_, true, false);
                bool? rzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzy_ = WBC?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzzzy_?.Value;
                string szzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzz_);
                string[] szzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzc_);
                DataType szzzzzzzzzzzzzzzzzzze_ = WBC?.Value;
                object szzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzze_);
                bool? szzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzf_ is null));
                bool? szzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzg_);

                return szzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzh_);
            object qzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                Instant szzzzzzzzzzzzzzzzzzzi_ = @this?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzj_ = szzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzk_ as object);

                return szzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzk_);
            Instant qzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzl_?.IssuedElement;
            DateTimeOffset? qzzzzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzzzzm_?.Value;
            CqlDateTime qzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzn_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? qzzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA, pzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, qzzzzzzzzzzzzzzzzzzzo_);

            return qzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> pzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(pzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> pzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(pzzzzzzzzzzzzzzzzzzzs_);

        return pzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? szzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            Id szzzzzzzzzzzzzzzzzzzq_ = TwentyWeeksPlusEncounter?.IdElement;
            string szzzzzzzzzzzzzzzzzzzr_ = szzzzzzzzzzzzzzzzzzzq_?.Value;
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? szzzzzzzzzzzzzzzzzzzt_(Observation HeartRate)
            {
                DataType tzzzzzzzzzzzzzzzzzzzk_ = HeartRate?.Effective;
                object tzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzr_, true, false);
                bool? tzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzu_ = HeartRate?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzzzzzzu_?.Value;
                string tzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzv_);
                string[] tzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzy_);

                return tzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzt_);
            object szzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                DataType uzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                object uzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzb_);

                return uzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzw_);
            DataType szzzzzzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlQuantity szzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzzzy_ as Quantity);
            bool? tzzzzzzzzzzzzzzzzzzzb_(Observation HeartRate)
            {
                DataType uzzzzzzzzzzzzzzzzzzzd_ = HeartRate?.Effective;
                object uzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzg_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzk_, true, false);
                bool? uzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzn_ = HeartRate?.StatusElement;
                ObservationStatus? uzzzzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzzzzn_?.Value;
                string uzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzo_);
                string[] uzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzr_);

                return uzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzb_);
            object tzzzzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                DataType uzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                object uzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzu_);

                return uzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Observation>(tzzzzzzzzzzzzzzzzzzze_);
            DataType tzzzzzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzzzzzf_?.Effective;
            object tzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? tzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV, szzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzz_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzi_);

            return tzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> szzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> szzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Risk Variable Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? uzzzzzzzzzzzzzzzzzzzx_(Encounter TwentyWeeksPlusEncounter)
        {
            Id vzzzzzzzzzzzzzzzzzzza_ = TwentyWeeksPlusEncounter?.IdElement;
            string vzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzza_?.Value;
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? vzzzzzzzzzzzzzzzzzzzd_(Observation BP)
            {
                DataType vzzzzzzzzzzzzzzzzzzzy_ = BP?.Effective;
                object vzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzb_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzf_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzf_, true, false);
                bool? wzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzg_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzi_ = BP?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzj_ = wzzzzzzzzzzzzzzzzzzzi_?.Value;
                string wzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzj_);
                string[] wzzzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzm_);
                List<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzo_ = BP?.Component;
                bool? wzzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
                {
                    DataType wzzzzzzzzzzzzzzzzzzzv_ = @this?.Value;
                    object wzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzv_);
                    bool? wzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzw_ is null));

                    return wzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)wzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzp_);
                object wzzzzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
                {
                    DataType wzzzzzzzzzzzzzzzzzzzy_ = @this?.Value;
                    object wzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzy_);

                    return wzzzzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<object> wzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation.ComponentComponent, object>(wzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzr_);
                bool? wzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzt_);

                return wzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzd_);
            object vzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzb_);

                return xzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzg_);
            List<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzzzzh_?.Component;
            bool? vzzzzzzzzzzzzzzzzzzzj_(Observation.ComponentComponent C)
            {
                CodeableConcept xzzzzzzzzzzzzzzzzzzzd_ = C?.Code;
                CqlConcept xzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzd_);
                CqlCode xzzzzzzzzzzzzzzzzzzzf_ = this.Systolic_blood_pressure(context);
                CqlConcept xzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzzzf_);
                bool? xzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzg_);

                return xzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzl_(Observation.ComponentComponent C)
            {
                DataType xzzzzzzzzzzzzzzzzzzzi_ = C?.Value;
                object xzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzi_);

                return xzzzzzzzzzzzzzzzzzzzj_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> vzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(vzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<CqlQuantity> vzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlQuantity>(vzzzzzzzzzzzzzzzzzzzm_);
            bool? vzzzzzzzzzzzzzzzzzzzp_(Observation BP)
            {
                DataType xzzzzzzzzzzzzzzzzzzzk_ = BP?.Effective;
                object xzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzr_, true, false);
                bool? xzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzu_ = BP?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzv_ = xzzzzzzzzzzzzzzzzzzzu_?.Value;
                string xzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzv_);
                string[] xzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzy_);
                List<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzza_ = BP?.Component;
                bool? yzzzzzzzzzzzzzzzzzzzb_(Observation.ComponentComponent @this)
                {
                    DataType yzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;
                    object yzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzh_);
                    bool? yzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzi_ is null));

                    return yzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Observation.ComponentComponent> yzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)yzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzb_);
                object yzzzzzzzzzzzzzzzzzzzd_(Observation.ComponentComponent @this)
                {
                    DataType yzzzzzzzzzzzzzzzzzzzk_ = @this?.Value;
                    object yzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzk_);

                    return yzzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<object> yzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Observation.ComponentComponent, object>(yzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzd_);
                bool? yzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzze_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzf_);

                return yzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzp_);
            object vzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object yzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzn_);

                return yzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzs_);
            DataType vzzzzzzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzzzzzzt_?.Effective;
            object vzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzv_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, vzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzw_);

            return vzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzzzzzzzzz_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DbihhAfJfGSKOIcQDBMEMigFK = new(
        [typeof(string), typeof(IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>)],
        ["id", "procedures"]);

    private static CqlTupleMetadata CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstHematocritResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstWBCResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK = new(
        [typeof(string), typeof(IEnumerable<CqlQuantity>), typeof(CqlDateTime)],
        ["EncounterId", "FirstSBPResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR = new(
        [typeof(Procedure), typeof(string)],
        ["code", "SOCProcedureCategory"]);

    private static CqlTupleMetadata CqlTupleMetadata_FRbAiSWEhRfKaLTXPVgFXYZAE = new(
        [typeof(CqlConcept), typeof(string)],
        ["code", "SOCDxCategory"]);

    private static CqlTupleMetadata CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstHRResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_RBQLXdQIRBbBEHDfOgQjdBMH = new(
        [typeof(string), typeof(IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>)],
        ["id", "complications"]);

    #endregion CqlTupleMetadata Properties

}
