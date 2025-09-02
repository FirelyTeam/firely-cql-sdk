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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS1028FHIRPCSevereOBComps", "0.1.002")]
public partial class CMS1028FHIRPCSevereOBComps_0_1_002 : ILibrary, ISingleton<CMS1028FHIRPCSevereOBComps_0_1_002>
{
    private CMS1028FHIRPCSevereOBComps_0_1_002() {}

    public static CMS1028FHIRPCSevereOBComps_0_1_002 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS1028FHIRPCSevereOBComps";
    public string Version => "0.1.002";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, PCMaternal_5_19_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("20 to 42 Plus Weeks Gestation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67", valueSetVersion: null)]
    public CqlValueSet _20_to_42_Plus_Weeks_Gestation(CqlContext _) => __20_to_42_Plus_Weeks_Gestation;
    private static readonly CqlValueSet __20_to_42_Plus_Weeks_Gestation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67", null);

    [CqlValueSetDefinition("Acute Heart Failure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.233", valueSetVersion: null)]
    public CqlValueSet Acute_Heart_Failure(CqlContext _) => _Acute_Heart_Failure;
    private static readonly CqlValueSet _Acute_Heart_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.233", null);

    [CqlValueSetDefinition("Acute Myocardial Infarction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.623", valueSetVersion: null)]
    public CqlValueSet Acute_Myocardial_Infarction(CqlContext _) => _Acute_Myocardial_Infarction;
    private static readonly CqlValueSet _Acute_Myocardial_Infarction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.623", null);

    [CqlValueSetDefinition("Acute or Persistent Asthma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271", valueSetVersion: null)]
    public CqlValueSet Acute_or_Persistent_Asthma(CqlContext _) => _Acute_or_Persistent_Asthma;
    private static readonly CqlValueSet _Acute_or_Persistent_Asthma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271", null);

    [CqlValueSetDefinition("Acute Renal Failure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.53", valueSetVersion: null)]
    public CqlValueSet Acute_Renal_Failure(CqlContext _) => _Acute_Renal_Failure;
    private static readonly CqlValueSet _Acute_Renal_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.53", null);

    [CqlValueSetDefinition("Acute Respiratory Distress Syndrome", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.214", valueSetVersion: null)]
    public CqlValueSet Acute_Respiratory_Distress_Syndrome(CqlContext _) => _Acute_Respiratory_Distress_Syndrome;
    private static readonly CqlValueSet _Acute_Respiratory_Distress_Syndrome = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.214", null);

    [CqlValueSetDefinition("Air and Thrombotic Embolism", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.243", valueSetVersion: null)]
    public CqlValueSet Air_and_Thrombotic_Embolism(CqlContext _) => _Air_and_Thrombotic_Embolism;
    private static readonly CqlValueSet _Air_and_Thrombotic_Embolism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.243", null);

    [CqlValueSetDefinition("Amniotic Fluid Embolism", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.217", valueSetVersion: null)]
    public CqlValueSet Amniotic_Fluid_Embolism(CqlContext _) => _Amniotic_Fluid_Embolism;
    private static readonly CqlValueSet _Amniotic_Fluid_Embolism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.217", null);

    [CqlValueSetDefinition("Anemia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323", valueSetVersion: null)]
    public CqlValueSet Anemia(CqlContext _) => _Anemia;
    private static readonly CqlValueSet _Anemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323", null);

    [CqlValueSetDefinition("Aortic Aneurysm", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.219", valueSetVersion: null)]
    public CqlValueSet Aortic_Aneurysm(CqlContext _) => _Aortic_Aneurysm;
    private static readonly CqlValueSet _Aortic_Aneurysm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.219", null);

    [CqlValueSetDefinition("Autoimmune Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311", valueSetVersion: null)]
    public CqlValueSet Autoimmune_Disease(CqlContext _) => _Autoimmune_Disease;
    private static readonly CqlValueSet _Autoimmune_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311", null);

    [CqlValueSetDefinition("Bariatric Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317", valueSetVersion: null)]
    public CqlValueSet Bariatric_Surgery(CqlContext _) => _Bariatric_Surgery;
    private static readonly CqlValueSet _Bariatric_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317", null);

    [CqlValueSetDefinition("Bleeding Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287", valueSetVersion: null)]
    public CqlValueSet Bleeding_Disorder(CqlContext _) => _Bleeding_Disorder;
    private static readonly CqlValueSet _Bleeding_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287", null);

    [CqlValueSetDefinition("Blood Transfusion", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213", valueSetVersion: null)]
    public CqlValueSet Blood_Transfusion(CqlContext _) => _Blood_Transfusion;
    private static readonly CqlValueSet _Blood_Transfusion = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213", null);

    [CqlValueSetDefinition("Cardiac Arrest Ventricular Fibrillation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.221", valueSetVersion: null)]
    public CqlValueSet Cardiac_Arrest_Ventricular_Fibrillation(CqlContext _) => _Cardiac_Arrest_Ventricular_Fibrillation;
    private static readonly CqlValueSet _Cardiac_Arrest_Ventricular_Fibrillation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.221", null);

    [CqlValueSetDefinition("Cardiac Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341", valueSetVersion: null)]
    public CqlValueSet Cardiac_Disease(CqlContext _) => _Cardiac_Disease;
    private static readonly CqlValueSet _Cardiac_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341", null);

    [CqlValueSetDefinition("Conversion of Cardiac Rhythm", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.357", valueSetVersion: null)]
    public CqlValueSet Conversion_of_Cardiac_Rhythm(CqlContext _) => _Conversion_of_Cardiac_Rhythm;
    private static readonly CqlValueSet _Conversion_of_Cardiac_Rhythm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.357", null);

    [CqlValueSetDefinition("Delivery Procedures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", valueSetVersion: null)]
    public CqlValueSet Delivery_Procedures(CqlContext _) => _Delivery_Procedures;
    private static readonly CqlValueSet _Delivery_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);

    [CqlValueSetDefinition("Disseminated Intravascular Coagulation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.223", valueSetVersion: null)]
    public CqlValueSet Disseminated_Intravascular_Coagulation(CqlContext _) => _Disseminated_Intravascular_Coagulation;
    private static readonly CqlValueSet _Disseminated_Intravascular_Coagulation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.223", null);

    [CqlValueSetDefinition("Eclampsia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.225", valueSetVersion: null)]
    public CqlValueSet Eclampsia(CqlContext _) => _Eclampsia;
    private static readonly CqlValueSet _Eclampsia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.225", null);

    [CqlValueSetDefinition("Economic Housing Instability", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292", valueSetVersion: null)]
    public CqlValueSet Economic_Housing_Instability(CqlContext _) => _Economic_Housing_Instability;
    private static readonly CqlValueSet _Economic_Housing_Instability = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292", null);

    [CqlValueSetDefinition("ED Visit and OB Triage", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", valueSetVersion: null)]
    public CqlValueSet ED_Visit_and_OB_Triage(CqlContext _) => _ED_Visit_and_OB_Triage;
    private static readonly CqlValueSet _ED_Visit_and_OB_Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Estimated Gestational Age at Delivery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", valueSetVersion: null)]
    public CqlValueSet Estimated_Gestational_Age_at_Delivery(CqlContext _) => _Estimated_Gestational_Age_at_Delivery;
    private static readonly CqlValueSet _Estimated_Gestational_Age_at_Delivery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Gastrointestinal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338", valueSetVersion: null)]
    public CqlValueSet Gastrointestinal_Disease(CqlContext _) => _Gastrointestinal_Disease;
    private static readonly CqlValueSet _Gastrointestinal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338", null);

    [CqlValueSetDefinition("Gestational Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269", valueSetVersion: null)]
    public CqlValueSet Gestational_Diabetes(CqlContext _) => _Gestational_Diabetes;
    private static readonly CqlValueSet _Gestational_Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269", null);

    [CqlValueSetDefinition("Heart Failure Cardiac Arrest Related to Procedure or Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.227", valueSetVersion: null)]
    public CqlValueSet Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(CqlContext _) => _Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery;
    private static readonly CqlValueSet _Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.227", null);

    [CqlValueSetDefinition("Hematocrit lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext _) => _Hematocrit_lab_test;
    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("HIV in Pregnancy Childbirth and Puerperium", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272", valueSetVersion: null)]
    public CqlValueSet HIV_in_Pregnancy_Childbirth_and_Puerperium(CqlContext _) => _HIV_in_Pregnancy_Childbirth_and_Puerperium;
    private static readonly CqlValueSet _HIV_in_Pregnancy_Childbirth_and_Puerperium = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272", null);

    [CqlValueSetDefinition("Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332", valueSetVersion: null)]
    public CqlValueSet Hypertension(CqlContext _) => _Hypertension;
    private static readonly CqlValueSet _Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332", null);

    [CqlValueSetDefinition("Hysterectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.358", valueSetVersion: null)]
    public CqlValueSet Hysterectomy(CqlContext _) => _Hysterectomy;
    private static readonly CqlValueSet _Hysterectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.358", null);

    [CqlValueSetDefinition("Long Term Anticoagulant Use", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366", valueSetVersion: null)]
    public CqlValueSet Long_Term_Anticoagulant_Use(CqlContext _) => _Long_Term_Anticoagulant_Use;
    private static readonly CqlValueSet _Long_Term_Anticoagulant_Use = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366", null);

    [CqlValueSetDefinition("Mental Health Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314", valueSetVersion: null)]
    public CqlValueSet Mental_Health_Disorder(CqlContext _) => _Mental_Health_Disorder;
    private static readonly CqlValueSet _Mental_Health_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314", null);

    [CqlValueSetDefinition("Mild or Moderate Preeclampsia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329", valueSetVersion: null)]
    public CqlValueSet Mild_or_Moderate_Preeclampsia(CqlContext _) => _Mild_or_Moderate_Preeclampsia;
    private static readonly CqlValueSet _Mild_or_Moderate_Preeclampsia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329", null);

    [CqlValueSetDefinition("Morbid or Severe Obesity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290", valueSetVersion: null)]
    public CqlValueSet Morbid_or_Severe_Obesity(CqlContext _) => _Morbid_or_Severe_Obesity;
    private static readonly CqlValueSet _Morbid_or_Severe_Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290", null);

    [CqlValueSetDefinition("Multiple Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284", valueSetVersion: null)]
    public CqlValueSet Multiple_Pregnancy(CqlContext _) => _Multiple_Pregnancy;
    private static readonly CqlValueSet _Multiple_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284", null);

    [CqlValueSetDefinition("Neuromuscular Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308", valueSetVersion: null)]
    public CqlValueSet Neuromuscular_Disease(CqlContext _) => _Neuromuscular_Disease;
    private static readonly CqlValueSet _Neuromuscular_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Placenta Accreta", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", valueSetVersion: null)]
    public CqlValueSet Placenta_Accreta(CqlContext _) => _Placenta_Accreta;
    private static readonly CqlValueSet _Placenta_Accreta = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", null);

    [CqlValueSetDefinition("Placenta Increta or Percreta", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.388", valueSetVersion: null)]
    public CqlValueSet Placenta_Increta_or_Percreta(CqlContext _) => _Placenta_Increta_or_Percreta;
    private static readonly CqlValueSet _Placenta_Increta_or_Percreta = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.388", null);

    [CqlValueSetDefinition("Placenta Previa", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.78", valueSetVersion: null)]
    public CqlValueSet Placenta_Previa(CqlContext _) => _Placenta_Previa;
    private static readonly CqlValueSet _Placenta_Previa = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.78", null);

    [CqlValueSetDefinition("Placental Abruption", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305", valueSetVersion: null)]
    public CqlValueSet Placental_Abruption(CqlContext _) => _Placental_Abruption;
    private static readonly CqlValueSet _Placental_Abruption = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305", null);

    [CqlValueSetDefinition("Placental Accreta Spectrum", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", valueSetVersion: null)]
    public CqlValueSet Placental_Accreta_Spectrum(CqlContext _) => _Placental_Accreta_Spectrum;
    private static readonly CqlValueSet _Placental_Accreta_Spectrum = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", null);

    [CqlValueSetDefinition("Preexisting Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275", valueSetVersion: null)]
    public CqlValueSet Preexisting_Diabetes(CqlContext _) => _Preexisting_Diabetes;
    private static readonly CqlValueSet _Preexisting_Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275", null);

    [CqlValueSetDefinition("Present on Admission is No or Unable To Determine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_is_No_or_Unable_To_Determine(CqlContext _) => _Present_on_Admission_is_No_or_Unable_To_Determine;
    private static readonly CqlValueSet _Present_on_Admission_is_No_or_Unable_To_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370", null);

    [CqlValueSetDefinition("Present On Admission is Yes or Exempt", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63", valueSetVersion: null)]
    public CqlValueSet Present_On_Admission_is_Yes_or_Exempt(CqlContext _) => _Present_On_Admission_is_Yes_or_Exempt;
    private static readonly CqlValueSet _Present_On_Admission_is_Yes_or_Exempt = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63", null);

    [CqlValueSetDefinition("Preterm Birth", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299", valueSetVersion: null)]
    public CqlValueSet Preterm_Birth(CqlContext _) => _Preterm_Birth;
    private static readonly CqlValueSet _Preterm_Birth = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299", null);

    [CqlValueSetDefinition("Previous Cesarean", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278", valueSetVersion: null)]
    public CqlValueSet Previous_Cesarean(CqlContext _) => _Previous_Cesarean;
    private static readonly CqlValueSet _Previous_Cesarean = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278", null);

    [CqlValueSetDefinition("Puerperal Cerebrovascular Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.229", valueSetVersion: null)]
    public CqlValueSet Puerperal_Cerebrovascular_Disorder(CqlContext _) => _Puerperal_Cerebrovascular_Disorder;
    private static readonly CqlValueSet _Puerperal_Cerebrovascular_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.229", null);

    [CqlValueSetDefinition("Pulmonary Edema", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.231", valueSetVersion: null)]
    public CqlValueSet Pulmonary_Edema(CqlContext _) => _Pulmonary_Edema;
    private static readonly CqlValueSet _Pulmonary_Edema = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.231", null);

    [CqlValueSetDefinition("Pulmonary Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281", valueSetVersion: null)]
    public CqlValueSet Pulmonary_Hypertension(CqlContext _) => _Pulmonary_Hypertension;
    private static readonly CqlValueSet _Pulmonary_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlValueSetDefinition("Renal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335", valueSetVersion: null)]
    public CqlValueSet Renal_Disease(CqlContext _) => _Renal_Disease;
    private static readonly CqlValueSet _Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335", null);

    [CqlValueSetDefinition("Sepsis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.237", valueSetVersion: null)]
    public CqlValueSet Sepsis(CqlContext _) => _Sepsis;
    private static readonly CqlValueSet _Sepsis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.237", null);

    [CqlValueSetDefinition("Severe Anesthesia Complications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.235", valueSetVersion: null)]
    public CqlValueSet Severe_Anesthesia_Complications(CqlContext _) => _Severe_Anesthesia_Complications;
    private static readonly CqlValueSet _Severe_Anesthesia_Complications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.235", null);

    [CqlValueSetDefinition("Severe Maternal Morbidity Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255", valueSetVersion: null)]
    public CqlValueSet Severe_Maternal_Morbidity_Diagnoses(CqlContext _) => _Severe_Maternal_Morbidity_Diagnoses;
    private static readonly CqlValueSet _Severe_Maternal_Morbidity_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255", null);

    [CqlValueSetDefinition("Severe Maternal Morbidity Procedures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256", valueSetVersion: null)]
    public CqlValueSet Severe_Maternal_Morbidity_Procedures(CqlContext _) => _Severe_Maternal_Morbidity_Procedures;
    private static readonly CqlValueSet _Severe_Maternal_Morbidity_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256", null);

    [CqlValueSetDefinition("Severe Preeclampsia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327", valueSetVersion: null)]
    public CqlValueSet Severe_Preeclampsia(CqlContext _) => _Severe_Preeclampsia;
    private static readonly CqlValueSet _Severe_Preeclampsia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327", null);

    [CqlValueSetDefinition("Shock", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.239", valueSetVersion: null)]
    public CqlValueSet Shock(CqlContext _) => _Shock;
    private static readonly CqlValueSet _Shock = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.239", null);

    [CqlValueSetDefinition("Sickle Cell Disease with Crisis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.241", valueSetVersion: null)]
    public CqlValueSet Sickle_Cell_Disease_with_Crisis(CqlContext _) => _Sickle_Cell_Disease_with_Crisis;
    private static readonly CqlValueSet _Sickle_Cell_Disease_with_Crisis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.241", null);

    [CqlValueSetDefinition("Substance Abuse", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320", valueSetVersion: null)]
    public CqlValueSet Substance_Abuse(CqlContext _) => _Substance_Abuse;
    private static readonly CqlValueSet _Substance_Abuse = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320", null);

    [CqlValueSetDefinition("Thyrotoxicosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296", valueSetVersion: null)]
    public CqlValueSet Thyrotoxicosis(CqlContext _) => _Thyrotoxicosis;
    private static readonly CqlValueSet _Thyrotoxicosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296", null);

    [CqlValueSetDefinition("Tracheostomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.359", valueSetVersion: null)]
    public CqlValueSet Tracheostomy(CqlContext _) => _Tracheostomy;
    private static readonly CqlValueSet _Tracheostomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.359", null);

    [CqlValueSetDefinition("Venous Thromboembolism in Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363", valueSetVersion: null)]
    public CqlValueSet Venous_Thromboembolism_in_Pregnancy(CqlContext _) => _Venous_Thromboembolism_in_Pregnancy;
    private static readonly CqlValueSet _Venous_Thromboembolism_in_Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363", null);

    [CqlValueSetDefinition("Ventilation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.360", valueSetVersion: null)]
    public CqlValueSet Ventilation(CqlContext _) => _Ventilation;
    private static readonly CqlValueSet _Ventilation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.360", null);

    [CqlValueSetDefinition("White blood cells count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext _) => _White_blood_cells_count_lab_test;
    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Heart_rate,
          _Systolic_blood_pressure]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("CMS1028FHIRPCSevereOBComps-0.1.002", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Calculated Gestational Age Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? b_(Encounter DeliveryEncounter)
        {
            int? d_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? e_ = context.Operators.GreaterOrEqual(d_, 20);

            return e_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Estimated Gestational Age Assessment Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? b_(Encounter DeliveryEncounter)
        {
            int? d_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity e_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity f_ = context.Operators.Quantity(20m, "weeks");
            bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
            bool? h_ = context.Operators.And((bool?)(d_ is null), g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Gestational Age Greater than or Equal to 20 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? b_(Encounter DeliveryEncounter)
        {
            int? d_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity e_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
            IEnumerable<Condition> g_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? h_(Condition EncounterDiagnosis)
            {
                CodeableConcept l_ = EncounterDiagnosis?.Code;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlValueSet n_ = this._20_to_42_Plus_Weeks_Gestation(context);
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


    [CqlExpressionDefinition("Delivery Encounters At Greater than or Equal to 20 Weeks Gestation")]
    public IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlFunctionDefinition("pOAIsNoOrUTD")]
    public IEnumerable<CqlConcept> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> a_ = TheEncounter?.Diagnosis;
        bool? b_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? g_(Extension @this)
            {
                string o_ = @this?.Url;
                FhirString p_ = context.Operators.Convert<FhirString>(o_);
                string q_ = FHIRHelpers_4_4_000.Instance.ToString(context, p_);
                bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return r_;
            };
            IEnumerable<Extension> h_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), g_);
            object i_(Extension @this)
            {
                DataType s_ = @this?.Value;

                return s_;
            };
            IEnumerable<object> j_ = context.Operators.Select<Extension, object>(h_, i_);
            object k_ = context.Operators.SingletonFrom<object>(j_);
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_ as CodeableConcept);
            CqlValueSet m_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? n_ = context.Operators.ConceptInValueSet(l_, m_);

            return n_;
        };
        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        CqlConcept d_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference t_ = EncounterDiagnoses?.Condition;
            Condition u_ = CQMCommon_2_2_000.Instance.getCondition(context, t_);
            CodeableConcept v_ = u_?.Code;
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);

            return w_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(c_, d_);
        IEnumerable<CqlConcept> f_ = context.Operators.Distinct<CqlConcept>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Diagnosis or Procedure Excluding Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsNoOrUTD(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);
            CqlValueSet g_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? i_(Procedure SMMProcedures)
            {
                Code<EventStatus> m_ = SMMProcedures?.StatusElement;
                EventStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "completed");
                DataType q_ = SMMProcedures?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_2_1_000.Instance.toInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlInterval<CqlDateTime> u_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
                bool? w_ = context.Operators.And(p_, v_);

                return w_;
            };
            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            bool? k_ = context.Operators.Exists<Procedure>(j_);
            bool? l_ = context.Operators.Or(f_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Expiration")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Expiration(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            Encounter.HospitalizationComponent d_ = TwentyWeeksPlusEncounter?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Patient_Expired(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> b_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet d_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure BloodTransfusion)
            {
                Code<EventStatus> j_ = BloodTransfusion?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");
                DataType n_ = BloodTransfusion?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlInterval<CqlDateTime> r_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
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


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Hysterectomy")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Hysterectomy(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> b_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet d_ = this.Hysterectomy(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure Hysterectomy)
            {
                Code<EventStatus> j_ = Hysterectomy?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");
                DataType n_ = Hysterectomy?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlInterval<CqlDateTime> r_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
                bool? t_ = context.Operators.And(m_, s_);

                return t_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure Hysterectomy) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Procedure> Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Conversion_of_Cardiac_Rhythm(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Tracheostomy(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        CqlValueSet f_ = this.Ventilation(context);
        IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Procedure> d_ = this.Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
            bool? e_(Procedure ConvTrachVentProcedures)
            {
                Code<EventStatus> i_ = ConvTrachVentProcedures?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                DataType m_ = ConvTrachVentProcedures?.Performed;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlInterval<CqlDateTime> q_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");
                bool? s_ = context.Operators.And(l_, r_);

                return s_;
            };
            IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
            Encounter g_(Procedure ConvTrachVentProcedures) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Procedure, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("SOC with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        bool? b_(Encounter SOCEncounter)
        {
            IEnumerable<Condition> l_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCEncounter);
            bool? m_(Condition EncounterDiagnosis)
            {
                CodeableConcept v_ = EncounterDiagnosis?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlValueSet x_ = this.Placenta_Increta_or_Percreta(context);
                bool? y_ = context.Operators.ConceptInValueSet(w_, x_);

                return y_;
            };
            IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
            bool? o_ = context.Operators.Exists<Condition>(n_);
            IEnumerable<Encounter> p_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? q_ = context.Operators.Exists<Encounter>(p_);
            IEnumerable<Encounter> r_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? s_ = context.Operators.Exists<Encounter>(r_);
            bool? t_ = context.Operators.Or(q_, s_);
            bool? u_ = context.Operators.And(o_, t_);

            return u_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? e_(Encounter SOCEncounter)
        {
            IEnumerable<CqlConcept> z_ = this.pOAIsNoOrUTD(context, SOCEncounter);
            CqlValueSet aa_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? ab_ = context.Operators.ConceptsInValueSet(z_, aa_);

            return ab_;
        };
        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(f_, g_);
        IEnumerable<Encounter> i_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Except<Encounter>(c_, j_);

        return k_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Diagnosis")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> b_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> c_ = context.Operators.Except<Encounter>(a_, b_);
        bool? d_(Encounter Encounter)
        {
            IEnumerable<CqlConcept> f_ = this.pOAIsNoOrUTD(context, Encounter);
            CqlValueSet g_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Procedures")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> b_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> c_ = context.Operators.Except<Encounter>(a_, b_);
        bool? d_(Encounter Encounter)
        {
            CqlValueSet f_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet h_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> j_ = context.Operators.Union<Procedure>(g_, i_);
            bool? k_(Procedure SMMProcedures)
            {
                Code<EventStatus> n_ = SMMProcedures?.StatusElement;
                EventStatus? o_ = n_?.Value;
                string p_ = context.Operators.Convert<string>(o_);
                bool? q_ = context.Operators.Equal(p_, "completed");
                DataType r_ = SMMProcedures?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlInterval<CqlDateTime> v_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");
                bool? x_ = context.Operators.And(q_, w_);

                return x_;
            };
            IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
            bool? m_ = context.Operators.Exists<Procedure>(l_);

            return m_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        return e_;
    }


    [CqlFunctionDefinition("sOCDxCategory")]
    public string sOCDxCategory(CqlContext context, CqlConcept Dx)
    {
        string a_()
        {
            bool b_()
            {
                CqlValueSet s_ = this.Acute_Heart_Failure(context);
                bool? t_ = context.Operators.ConceptInValueSet(Dx, s_);

                return t_ ?? false;
            };
            bool c_()
            {
                CqlValueSet u_ = this.Acute_Myocardial_Infarction(context);
                bool? v_ = context.Operators.ConceptInValueSet(Dx, u_);

                return v_ ?? false;
            };
            bool d_()
            {
                CqlValueSet w_ = this.Acute_Renal_Failure(context);
                bool? x_ = context.Operators.ConceptInValueSet(Dx, w_);

                return x_ ?? false;
            };
            bool e_()
            {
                CqlValueSet y_ = this.Acute_Respiratory_Distress_Syndrome(context);
                bool? z_ = context.Operators.ConceptInValueSet(Dx, y_);

                return z_ ?? false;
            };
            bool f_()
            {
                CqlValueSet aa_ = this.Air_and_Thrombotic_Embolism(context);
                bool? ab_ = context.Operators.ConceptInValueSet(Dx, aa_);

                return ab_ ?? false;
            };
            bool g_()
            {
                CqlValueSet ac_ = this.Amniotic_Fluid_Embolism(context);
                bool? ad_ = context.Operators.ConceptInValueSet(Dx, ac_);

                return ad_ ?? false;
            };
            bool h_()
            {
                CqlValueSet ae_ = this.Aortic_Aneurysm(context);
                bool? af_ = context.Operators.ConceptInValueSet(Dx, ae_);

                return af_ ?? false;
            };
            bool i_()
            {
                CqlValueSet ag_ = this.Cardiac_Arrest_Ventricular_Fibrillation(context);
                bool? ah_ = context.Operators.ConceptInValueSet(Dx, ag_);

                return ah_ ?? false;
            };
            bool j_()
            {
                CqlValueSet ai_ = this.Disseminated_Intravascular_Coagulation(context);
                bool? aj_ = context.Operators.ConceptInValueSet(Dx, ai_);

                return aj_ ?? false;
            };
            bool k_()
            {
                CqlValueSet ak_ = this.Eclampsia(context);
                bool? al_ = context.Operators.ConceptInValueSet(Dx, ak_);

                return al_ ?? false;
            };
            bool l_()
            {
                CqlValueSet am_ = this.Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(context);
                bool? an_ = context.Operators.ConceptInValueSet(Dx, am_);

                return an_ ?? false;
            };
            bool m_()
            {
                CqlValueSet ao_ = this.Puerperal_Cerebrovascular_Disorder(context);
                bool? ap_ = context.Operators.ConceptInValueSet(Dx, ao_);

                return ap_ ?? false;
            };
            bool n_()
            {
                CqlValueSet aq_ = this.Pulmonary_Edema(context);
                bool? ar_ = context.Operators.ConceptInValueSet(Dx, aq_);

                return ar_ ?? false;
            };
            bool o_()
            {
                CqlValueSet as_ = this.Sepsis(context);
                bool? at_ = context.Operators.ConceptInValueSet(Dx, as_);

                return at_ ?? false;
            };
            bool p_()
            {
                CqlValueSet au_ = this.Severe_Anesthesia_Complications(context);
                bool? av_ = context.Operators.ConceptInValueSet(Dx, au_);

                return av_ ?? false;
            };
            bool q_()
            {
                CqlValueSet aw_ = this.Shock(context);
                bool? ax_ = context.Operators.ConceptInValueSet(Dx, aw_);

                return ax_ ?? false;
            };
            bool r_()
            {
                CqlValueSet ay_ = this.Sickle_Cell_Disease_with_Crisis(context);
                bool? az_ = context.Operators.ConceptInValueSet(Dx, ay_);

                return az_ ?? false;
            };
            if (b_())
            {
                return "Acute Heart Failure";
            }
            else if (c_())
            {
                return "Acute Myocardial Infarction";
            }
            else if (d_())
            {
                return "Acute Renal Failure";
            }
            else if (e_())
            {
                return "Acute Respiratory Distress Syndrome";
            }
            else if (f_())
            {
                return "Air and Thrombotic Embolism";
            }
            else if (g_())
            {
                return "Amniotic Fluid Embolism";
            }
            else if (h_())
            {
                return "Aortic Aneurysm";
            }
            else if (i_())
            {
                return "Cardiac Arrest Ventricular Fibrillation";
            }
            else if (j_())
            {
                return "Disseminated Intravascular Coagulation";
            }
            else if (k_())
            {
                return "Eclampsia";
            }
            else if (l_())
            {
                return "Heart Failure Cardiac Arrest Related to Procedure or Surgery";
            }
            else if (m_())
            {
                return "Puerperal Cerebrovascular Disorder";
            }
            else if (n_())
            {
                return "Pulmonary Edema";
            }
            else if (o_())
            {
                return "Sepsis";
            }
            else if (p_())
            {
                return "Severe Anesthesia Complications";
            }
            else if (q_())
            {
                return "Shock";
            }
            else if (r_())
            {
                return "Sickle Cell Disease with Crisis";
            }
            else
            {
                return default;
            }
        };

        return a_();
    }


    [CqlExpressionDefinition("SDE SOC Diagnoses Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? b_(Encounter Encounter)
        {
            Id e_ = Encounter?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<CqlConcept> g_ = this.pOAIsNoOrUTD(context, Encounter);
            bool? h_(CqlConcept C)
            {
                CqlValueSet n_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                bool? o_ = context.Operators.ConceptInValueSet(C, n_);

                return o_;
            };
            IEnumerable<CqlConcept> i_ = context.Operators.Where<CqlConcept>(g_, h_);
            (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? j_(CqlConcept C)
            {
                string p_ = this.sOCDxCategory(context, C);
                (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? q_ = (CqlTupleMetadata_FRbAiSWEhRfKaLTXPVgFXYZAE, C, p_);

                return q_;
            };
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> k_ = context.Operators.Select<CqlConcept, (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(k_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? m_ = (CqlTupleMetadata_RBQLXdQIRBbBEHDfOgQjdBMH, f_, l_);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("sOCProcedures")]
    public IEnumerable<Procedure> sOCProcedures(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet a_ = this.Severe_Maternal_Morbidity_Procedures(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Blood_Transfusion(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        bool? f_(Procedure SMMProcedures)
        {
            Code<EventStatus> h_ = SMMProcedures?.StatusElement;
            EventStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            bool? k_ = context.Operators.Equal(j_, "completed");
            DataType l_ = SMMProcedures?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.toInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlInterval<CqlDateTime> p_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
            bool? r_ = context.Operators.And(k_, q_);

            return r_;
        };
        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);

        return g_;
    }


    [CqlFunctionDefinition("sOCProcedureCategory")]
    public string sOCProcedureCategory(CqlContext context, Procedure TheProcedure)
    {
        string a_()
        {
            bool b_()
            {
                CodeableConcept g_ = TheProcedure?.Code;
                CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
                CqlValueSet i_ = this.Blood_Transfusion(context);
                bool? j_ = context.Operators.ConceptInValueSet(h_, i_);

                return j_ ?? false;
            };
            bool c_()
            {
                CodeableConcept k_ = TheProcedure?.Code;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                CqlValueSet m_ = this.Conversion_of_Cardiac_Rhythm(context);
                bool? n_ = context.Operators.ConceptInValueSet(l_, m_);

                return n_ ?? false;
            };
            bool d_()
            {
                CodeableConcept o_ = TheProcedure?.Code;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlValueSet q_ = this.Hysterectomy(context);
                bool? r_ = context.Operators.ConceptInValueSet(p_, q_);

                return r_ ?? false;
            };
            bool e_()
            {
                CodeableConcept s_ = TheProcedure?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Tracheostomy(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);

                return v_ ?? false;
            };
            bool f_()
            {
                CodeableConcept w_ = TheProcedure?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlValueSet y_ = this.Ventilation(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);

                return z_ ?? false;
            };
            if (b_())
            {
                return "Blood Transfusion";
            }
            else if (c_())
            {
                return "Conversion of cardiac rhythm";
            }
            else if (d_())
            {
                return "Hysterectomy";
            }
            else if (e_())
            {
                return "Tracheostomy";
            }
            else if (f_())
            {
                return "Ventilation";
            }
            else
            {
                return default;
            }
        };

        return a_();
    }


    [CqlExpressionDefinition("SDE SOC Procedure Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? b_(Encounter Encounter)
        {
            Id e_ = Encounter?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Procedure> g_ = this.sOCProcedures(context, Encounter);
            (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? h_(Procedure P)
            {
                string l_ = this.sOCProcedureCategory(context, P);
                (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? m_ = (CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR, P, l_);

                return m_;
            };
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> i_ = context.Operators.Select<Procedure, (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(g_, h_);
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(i_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? k_ = (CqlTupleMetadata_DbihhAfJfGSKOIcQDBMEMigFK, f_, j_);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> a_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);

        return a_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions Only")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("SOC Excluding Blood Transfusions Only with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_Excluding_Blood_Transfusions_Only_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(context);
        bool? b_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<Condition> l_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);
            bool? m_(Condition EncounterDiagnoses)
            {
                CodeableConcept v_ = EncounterDiagnoses?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlValueSet x_ = this.Placenta_Increta_or_Percreta(context);
                bool? y_ = context.Operators.ConceptInValueSet(w_, x_);

                return y_;
            };
            IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
            bool? o_ = context.Operators.Exists<Condition>(n_);
            IEnumerable<Encounter> p_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? q_ = context.Operators.Exists<Encounter>(p_);
            IEnumerable<Encounter> r_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? s_ = context.Operators.Exists<Encounter>(r_);
            bool? t_ = context.Operators.Or(q_, s_);
            bool? u_ = context.Operators.And(o_, t_);

            return u_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? e_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<CqlConcept> z_ = this.pOAIsNoOrUTD(context, SOCExcludingTransfusion);
            CqlValueSet aa_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? ab_ = context.Operators.ConceptsInValueSet(z_, aa_);

            return ab_;
        };
        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(f_, g_);
        IEnumerable<Encounter> i_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Except<Encounter>(c_, j_);

        return k_;
    }


    [CqlFunctionDefinition("pOAIsYesOrExempt")]
    public IEnumerable<CqlConcept> pOAIsYesOrExempt(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> a_ = TheEncounter?.Diagnosis;
        bool? b_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? g_(Extension @this)
            {
                string o_ = @this?.Url;
                FhirString p_ = context.Operators.Convert<FhirString>(o_);
                string q_ = FHIRHelpers_4_4_000.Instance.ToString(context, p_);
                bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return r_;
            };
            IEnumerable<Extension> h_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), g_);
            object i_(Extension @this)
            {
                DataType s_ = @this?.Value;

                return s_;
            };
            IEnumerable<object> j_ = context.Operators.Select<Extension, object>(h_, i_);
            object k_ = context.Operators.SingletonFrom<object>(j_);
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_ as CodeableConcept);
            CqlValueSet m_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? n_ = context.Operators.ConceptInValueSet(l_, m_);

            return n_;
        };
        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        CqlConcept d_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference t_ = EncounterDiagnoses?.Condition;
            Condition u_ = CQMCommon_2_2_000.Instance.getCondition(context, t_);
            CodeableConcept v_ = u_?.Code;
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);

            return w_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(c_, d_);
        IEnumerable<CqlConcept> f_ = context.Operators.Distinct<CqlConcept>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Risk Variable Anemia")]
    public IEnumerable<Encounter> Risk_Variable_Anemia(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Anemia(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Asthma")]
    public IEnumerable<Encounter> Risk_Variable_Asthma(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Acute_or_Persistent_Asthma(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Autoimmune Disease")]
    public IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Autoimmune_Disease(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Bariatric Surgery")]
    public IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Bariatric_Surgery(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Bleeding Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Bleeding_Disorder(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Morbid Obesity")]
    public IEnumerable<Encounter> Risk_Variable_Morbid_Obesity(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Morbid_or_Severe_Obesity(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Cardiac Disease")]
    public IEnumerable<Encounter> Risk_Variable_Cardiac_Disease(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Cardiac_Disease(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Economic Housing Instability")]
    public IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Economic_Housing_Instability(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Gastrointestinal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Gastrointestinal_Disease(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Gestational Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Gestational_Diabetes(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable HIV")]
    public IEnumerable<Encounter> Risk_Variable_HIV(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Hypertension(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Long Term Anticoagulant Use")]
    public IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Long_Term_Anticoagulant_Use(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Maternal Age")]
    public IEnumerable<IEnumerable<object>> Risk_Variable_Maternal_Age(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<object> b_(Encounter TwentyWeeksPlusEncounter)
        {
            Patient e_ = this.Patient(context);
            Date f_ = e_?.BirthDateElement;
            string g_ = f_?.Value;
            CqlDate h_ = context.Operators.ConvertStringToDate(g_);
            Period i_ = TwentyWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            object[] n_ = [
                TwentyWeeksPlusEncounter,
    m_ ?? default(int),
            ];

            return n_ as IEnumerable<object>;
        };
        IEnumerable<IEnumerable<object>> c_ = context.Operators.Select<Encounter, IEnumerable<object>>(a_, b_);
        IEnumerable<IEnumerable<object>> d_ = context.Operators.Distinct<IEnumerable<object>>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Mental Health Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Mental_Health_Disorder(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Multiple Pregnancy")]
    public IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Multiple_Pregnancy(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Neuromuscular")]
    public IEnumerable<Encounter> Risk_Variable_Neuromuscular(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Neuromuscular_Disease(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Obstetrical VTE")]
    public IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Venous_Thromboembolism_in_Pregnancy(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Placenta Previa")]
    public IEnumerable<Encounter> Risk_Variable_Placenta_Previa(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Placenta_Previa(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Abruption")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Abruption(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Placental_Abruption(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Accreta Spectrum")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Placenta_Accreta(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);
            CqlValueSet h_ = this.Placenta_Increta_or_Percreta(context);
            bool? i_ = context.Operators.ConceptsInValueSet(d_, h_);
            bool? j_ = context.Operators.Or(f_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Preexisting Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Preexisting_Diabetes(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Previous Cesarean")]
    public IEnumerable<Encounter> Risk_Variable_Previous_Cesarean(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Previous_Cesarean(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Pulmonary Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Pulmonary_Hypertension(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Renal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Renal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Renal_Disease(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Severe Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Severe_Preeclampsia(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Substance Abuse")]
    public IEnumerable<Encounter> Risk_Variable_Substance_Abuse(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Substance_Abuse(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Thyrotoxicosis")]
    public IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Thyrotoxicosis(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Other Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? b_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet e_ = this.Mild_or_Moderate_Preeclampsia(context);
            bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Preterm Birth")]
    public IEnumerable<Encounter> Risk_Variable_Preterm_Birth(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? b_(Encounter DeliveryEncounter)
        {
            int? h_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlInterval<int?> i_ = context.Operators.Interval(20, 36, true, true);
            bool? j_ = context.Operators.In<int?>(h_, i_, default);
            CqlQuantity l_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
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
            int? u_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity v_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? w_ = context.Operators.And((bool?)(u_ is null), (bool?)(v_ is null));
            IEnumerable<CqlConcept> x_ = this.pOAIsYesOrExempt(context, DeliveryEncounter);
            CqlValueSet y_ = this.Preterm_Birth(context);
            bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
            bool? aa_ = context.Operators.And(w_, z_);

            return aa_;
        };
        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
        {
            Id e_ = TwentyWeeksPlusEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation Hematocrit)
            {
                Instant aa_ = Hematocrit?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlInterval<CqlDateTime> ad_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlQuantity af_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                CqlDateTime ah_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, true, true);
                bool? aj_ = context.Operators.In<CqlDateTime>(ac_, ai_, default);
                Code<ObservationStatus> ak_ = Hematocrit?.StatusElement;
                ObservationStatus? al_ = ak_?.Value;
                string am_ = context.Operators.Convert<string>(al_);
                string[] an_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ao_ = context.Operators.In<string>(am_, an_ as IEnumerable<string>);
                bool? ap_ = context.Operators.And(aj_, ao_);
                DataType aq_ = Hematocrit?.Value;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                bool? at_ = context.Operators.And(ap_, as_);

                return at_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant au_ = @this?.IssuedElement;
                DateTimeOffset? av_ = au_?.Value;
                CqlDateTime aw_ = context.Operators.Convert<CqlDateTime>(av_);
                CqlDateTime ax_ = QICoreCommon_2_1_000.Instance.earliest(context, aw_ as object);

                return ax_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation Hematocrit)
            {
                Instant ay_ = Hematocrit?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlInterval<CqlDateTime> bb_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlQuantity bd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime be_ = context.Operators.Subtract(bc_, bd_);
                CqlDateTime bf_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(be_, bf_, true, true);
                bool? bh_ = context.Operators.In<CqlDateTime>(ba_, bg_, default);
                Code<ObservationStatus> bi_ = Hematocrit?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string bk_ = context.Operators.Convert<string>(bj_);
                string[] bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string>(bk_, bl_ as IEnumerable<string>);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType bo_ = Hematocrit?.Value;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);

                return br_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bs_ = @this?.IssuedElement;
                DateTimeOffset? bt_ = bs_?.Value;
                CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
                CqlDateTime bv_ = QICoreCommon_2_1_000.Instance.earliest(context, bu_ as object);

                return bv_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
        {
            Id e_ = TwentyWeeksPlusEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation WBC)
            {
                Instant aa_ = WBC?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlInterval<CqlDateTime> ad_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlQuantity af_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                CqlDateTime ah_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, true, true);
                bool? aj_ = context.Operators.In<CqlDateTime>(ac_, ai_, default);
                Code<ObservationStatus> ak_ = WBC?.StatusElement;
                ObservationStatus? al_ = ak_?.Value;
                string am_ = context.Operators.Convert<string>(al_);
                string[] an_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ao_ = context.Operators.In<string>(am_, an_ as IEnumerable<string>);
                bool? ap_ = context.Operators.And(aj_, ao_);
                DataType aq_ = WBC?.Value;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                bool? at_ = context.Operators.And(ap_, as_);

                return at_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant au_ = @this?.IssuedElement;
                DateTimeOffset? av_ = au_?.Value;
                CqlDateTime aw_ = context.Operators.Convert<CqlDateTime>(av_);
                CqlDateTime ax_ = QICoreCommon_2_1_000.Instance.earliest(context, aw_ as object);

                return ax_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation WBC)
            {
                Instant ay_ = WBC?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlInterval<CqlDateTime> bb_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlQuantity bd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime be_ = context.Operators.Subtract(bc_, bd_);
                CqlDateTime bf_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(be_, bf_, true, true);
                bool? bh_ = context.Operators.In<CqlDateTime>(ba_, bg_, default);
                Code<ObservationStatus> bi_ = WBC?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string bk_ = context.Operators.Convert<string>(bj_);
                string[] bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string>(bk_, bl_ as IEnumerable<string>);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType bo_ = WBC?.Value;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);

                return br_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bs_ = @this?.IssuedElement;
                DateTimeOffset? bt_ = bs_?.Value;
                CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
                CqlDateTime bv_ = QICoreCommon_2_1_000.Instance.earliest(context, bu_ as object);

                return bv_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
        {
            Id e_ = TwentyWeeksPlusEncounter?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? h_(Observation HeartRate)
            {
                DataType y_ = HeartRate?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlQuantity ad_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
                CqlDateTime af_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ae_, af_, true, true);
                bool? ah_ = context.Operators.In<CqlDateTime>(aa_, ag_, default);
                Code<ObservationStatus> ai_ = HeartRate?.StatusElement;
                ObservationStatus? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                string[] al_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? am_ = context.Operators.In<string>(ak_, al_ as IEnumerable<string>);
                bool? an_ = context.Operators.And(ah_, am_);

                return an_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType ao_ = @this?.Effective;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlDateTime aq_ = QICoreCommon_2_1_000.Instance.earliest(context, ap_);

                return aq_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? p_(Observation HeartRate)
            {
                DataType ar_ = HeartRate?.Effective;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                CqlDateTime at_ = QICoreCommon_2_1_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ax_ = context.Operators.Subtract(av_, aw_);
                CqlDateTime ay_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> az_ = context.Operators.Interval(ax_, ay_, true, true);
                bool? ba_ = context.Operators.In<CqlDateTime>(at_, az_, default);
                Code<ObservationStatus> bb_ = HeartRate?.StatusElement;
                ObservationStatus? bc_ = bb_?.Value;
                string bd_ = context.Operators.Convert<string>(bc_);
                string[] be_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bf_ = context.Operators.In<string>(bd_, be_ as IEnumerable<string>);
                bool? bg_ = context.Operators.And(ba_, bf_);

                return bg_;
            };
            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(g_, p_);
            object r_(Observation @this)
            {
                DataType bh_ = @this?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                CqlDateTime bj_ = QICoreCommon_2_1_000.Instance.earliest(context, bi_);

                return bj_;
            };
            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV, f_, n_ as CqlQuantity, w_);

            return x_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
        {
            Id e_ = TwentyWeeksPlusEncounter?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? h_(Observation BP)
            {
                DataType ac_ = BP?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlDateTime ae_ = QICoreCommon_2_1_000.Instance.earliest(context, ad_);
                CqlInterval<CqlDateTime> af_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                CqlDateTime aj_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ai_, aj_, true, true);
                bool? al_ = context.Operators.In<CqlDateTime>(ae_, ak_, default);
                Code<ObservationStatus> am_ = BP?.StatusElement;
                ObservationStatus? an_ = am_?.Value;
                string ao_ = context.Operators.Convert<string>(an_);
                string[] ap_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aq_ = context.Operators.In<string>(ao_, ap_ as IEnumerable<string>);
                bool? ar_ = context.Operators.And(al_, aq_);
                List<Observation.ComponentComponent> as_ = BP?.Component;
                bool? at_(Observation.ComponentComponent @this)
                {
                    DataType az_ = @this?.Value;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool? bb_ = context.Operators.Not((bool?)(ba_ is null));

                    return bb_;
                };
                IEnumerable<Observation.ComponentComponent> au_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)as_, at_);
                object av_(Observation.ComponentComponent @this)
                {
                    DataType bc_ = @this?.Value;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                    return bd_;
                };
                IEnumerable<object> aw_ = context.Operators.Select<Observation.ComponentComponent, object>(au_, av_);
                bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
                bool? ay_ = context.Operators.And(ar_, ax_);

                return ay_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType be_ = @this?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                CqlDateTime bg_ = QICoreCommon_2_1_000.Instance.earliest(context, bf_);

                return bg_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            List<Observation.ComponentComponent> m_ = l_?.Component;
            bool? n_(Observation.ComponentComponent C)
            {
                CodeableConcept bh_ = C?.Code;
                CqlConcept bi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bh_);
                CqlCode bj_ = this.Systolic_blood_pressure(context);
                CqlConcept bk_ = context.Operators.ConvertCodeToConcept(bj_);
                bool? bl_ = context.Operators.Equivalent(bi_, bk_);

                return bl_;
            };
            IEnumerable<Observation.ComponentComponent> o_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)m_, n_);
            CqlQuantity p_(Observation.ComponentComponent C)
            {
                DataType bm_ = C?.Value;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);

                return bn_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> q_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(o_, p_);
            IEnumerable<CqlQuantity> r_ = context.Operators.Distinct<CqlQuantity>(q_);
            bool? t_(Observation BP)
            {
                DataType bo_ = BP?.Effective;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                CqlDateTime bq_ = QICoreCommon_2_1_000.Instance.earliest(context, bp_);
                CqlInterval<CqlDateTime> br_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime bs_ = context.Operators.Start(br_);
                CqlQuantity bt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bu_ = context.Operators.Subtract(bs_, bt_);
                CqlDateTime bv_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bu_, bv_, true, true);
                bool? bx_ = context.Operators.In<CqlDateTime>(bq_, bw_, default);
                Code<ObservationStatus> by_ = BP?.StatusElement;
                ObservationStatus? bz_ = by_?.Value;
                string ca_ = context.Operators.Convert<string>(bz_);
                string[] cb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cc_ = context.Operators.In<string>(ca_, cb_ as IEnumerable<string>);
                bool? cd_ = context.Operators.And(bx_, cc_);
                List<Observation.ComponentComponent> ce_ = BP?.Component;
                bool? cf_(Observation.ComponentComponent @this)
                {
                    DataType cl_ = @this?.Value;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool? cn_ = context.Operators.Not((bool?)(cm_ is null));

                    return cn_;
                };
                IEnumerable<Observation.ComponentComponent> cg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ce_, cf_);
                object ch_(Observation.ComponentComponent @this)
                {
                    DataType co_ = @this?.Value;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                    return cp_;
                };
                IEnumerable<object> ci_ = context.Operators.Select<Observation.ComponentComponent, object>(cg_, ch_);
                bool? cj_ = context.Operators.Not((bool?)(ci_ is null));
                bool? ck_ = context.Operators.And(cd_, cj_);

                return ck_;
            };
            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(g_, t_);
            object v_(Observation @this)
            {
                DataType cq_ = @this?.Effective;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                CqlDateTime cs_ = QICoreCommon_2_1_000.Instance.earliest(context, cr_);

                return cs_;
            };
            IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            Observation x_ = context.Operators.First<Observation>(w_);
            DataType y_ = x_?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, z_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? ab_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, f_, r_, aa_);

            return ab_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    #endregion Functions and Expressions

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
