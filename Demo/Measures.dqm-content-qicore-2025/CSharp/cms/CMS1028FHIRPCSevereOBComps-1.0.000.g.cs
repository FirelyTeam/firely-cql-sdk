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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("CMS1028FHIRPCSevereOBComps", "1.0.000")]
public partial class CMS1028FHIRPCSevereOBComps_1_0_000 : ILibrary, ISingleton<CMS1028FHIRPCSevereOBComps_1_0_000>
{
    #region ValueSets (61)

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

    [CqlValueSetDefinition("Disseminated Intravascular Coagulation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.223", valueSetVersion: null)]
    public CqlValueSet Disseminated_Intravascular_Coagulation(CqlContext _) => _Disseminated_Intravascular_Coagulation;
    private static readonly CqlValueSet _Disseminated_Intravascular_Coagulation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.223", null);

    [CqlValueSetDefinition("Eclampsia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.225", valueSetVersion: null)]
    public CqlValueSet Eclampsia(CqlContext _) => _Eclampsia;
    private static readonly CqlValueSet _Eclampsia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.225", null);

    [CqlValueSetDefinition("Economic Housing Instability", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292", valueSetVersion: null)]
    public CqlValueSet Economic_Housing_Instability(CqlContext _) => _Economic_Housing_Instability;
    private static readonly CqlValueSet _Economic_Housing_Instability = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292", null);

    [CqlValueSetDefinition("Federal Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.121", valueSetVersion: null)]
    public CqlValueSet Federal_Administrative_Sex(CqlContext _) => _Federal_Administrative_Sex;
    private static readonly CqlValueSet _Federal_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.121", null);

    [CqlValueSetDefinition("Gastrointestinal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338", valueSetVersion: null)]
    public CqlValueSet Gastrointestinal_Disease(CqlContext _) => _Gastrointestinal_Disease;
    private static readonly CqlValueSet _Gastrointestinal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338", null);

    [CqlValueSetDefinition("Gestational Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269", valueSetVersion: null)]
    public CqlValueSet Gestational_Diabetes(CqlContext _) => _Gestational_Diabetes;
    private static readonly CqlValueSet _Gestational_Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269", null);

    [CqlValueSetDefinition("Heart Failure Cardiac Arrest Related to Procedure or Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.227", valueSetVersion: null)]
    public CqlValueSet Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(CqlContext _) => _Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery;
    private static readonly CqlValueSet _Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.227", null);

    [CqlValueSetDefinition("Hematocrit Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_Lab_Test(CqlContext _) => _Hematocrit_Lab_Test;
    private static readonly CqlValueSet _Hematocrit_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

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

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

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

    [CqlValueSetDefinition("White Blood Cells Count Lab Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_Blood_Cells_Count_Lab_Test(CqlContext _) => _White_Blood_Cells_Count_Lab_Test;
    private static readonly CqlValueSet _White_Blood_Cells_Count_Lab_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes (4)

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    [CqlCodeDefinition("POA-Y", codeId: "Y", codeSystem: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding")]
    public CqlCode POA_Y(CqlContext _) => _POA_Y;
    private static readonly CqlCode _POA_Y = new CqlCode("Y", "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding");

    [CqlCodeDefinition("POA-1", codeId: "1", codeSystem: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding")]
    public CqlCode POA_1(CqlContext _) => _POA_1;
    private static readonly CqlCode _POA_1 = new CqlCode("1", "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Heart_rate,
          _Systolic_blood_pressure]);

    [CqlCodeSystemDefinition("Present On Admission Indicators", codeSystemId: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding", codeSystemVersion: null)]
    public CqlCodeSystem Present_On_Admission_Indicators(CqlContext _) => _Present_On_Admission_Indicators;
    private static readonly CqlCodeSystem _Present_On_Admission_Indicators =
      new CqlCodeSystem("https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding", null, [
          _POA_Y,
          _POA_1]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3054133947653297271L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1028FHIRPCSevereOBComps-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (69)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -5457495244187790411L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -5576198982135139213L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -7145789266820812834L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7165095462465786372L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 3939123815481697149L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -8324784854847133132L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Calculated Gestational Age Greater Than Or Equal To 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks, Delivery_Encounters_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks = -3825030991784224793L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? e_ = context.Operators.GreaterOrEqual(d_, 20);
            return e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Estimated Gestational Age Assessment Greater Than Or Equal To 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Estimated_Gestational_Age_Assessment_Greater_Than_Or_Equal_To_20_Weeks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Estimated_Gestational_Age_Assessment_Greater_Than_Or_Equal_To_20_Weeks, Delivery_Encounters_With_Estimated_Gestational_Age_Assessment_Greater_Than_Or_Equal_To_20_Weeks_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Estimated_Gestational_Age_Assessment_Greater_Than_Or_Equal_To_20_Weeks = -3284729660759741894L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Estimated_Gestational_Age_Assessment_Greater_Than_Or_Equal_To_20_Weeks_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity f_ = context.Operators.Quantity(20m, "weeks");
            bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
            bool? h_ = context.Operators.And((bool?)(d_ is null), g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Gestational Age Greater Than Or Equal To 20 Weeks Based On Coding")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks_Based_On_Coding(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks_Based_On_Coding, Delivery_Encounters_With_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks_Based_On_Coding_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks_Based_On_Coding = 7658504009465578179L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks_Based_On_Coding_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
            List<CodeableConcept> g_ = DeliveryEncounter?.ReasonCode;

            CqlConcept h_(CodeableConcept @this) {
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return u_;
            }

            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            CqlValueSet j_ = this._20_to_42_Plus_Weeks_Gestation(context);
            bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
            IEnumerable<object> l_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? m_(object @this) {
                object v_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                bool? x_ = context.Operators.Not((bool?)(w_ is null));
                return x_;
            }

            IEnumerable<object> n_ = context.Operators.Where<object>(l_, m_);

            CqlConcept o_(object @this) {
                object y_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                return z_;
            }

            IEnumerable<CqlConcept> p_ = context.Operators.Select<object, CqlConcept>(n_, o_);
            bool? r_ = context.Operators.ConceptsInValueSet(p_, j_);
            bool? s_ = context.Operators.Or(k_, r_);
            bool? t_ = context.Operators.And(f_, s_);
            return t_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation")]
    public IEnumerable<Encounter> Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation, Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation_Compute);

    private const long _cacheIndex_Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation = 3347643640353888106L;

    private IEnumerable<Encounter> Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounters_With_Estimated_Gestational_Age_Assessment_Greater_Than_Or_Equal_To_20_Weeks(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Delivery_Encounters_With_Gestational_Age_Greater_Than_Or_Equal_To_20_Weeks_Based_On_Coding(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Severe Obstetric Complications Diagnosis Or Procedure Excluding Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Severe_Obstetric_Complications_Diagnosis_Or_Procedure_Excluding_Blood_Transfusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Severe_Obstetric_Complications_Diagnosis_Or_Procedure_Excluding_Blood_Transfusion, Delivery_Encounters_With_Severe_Obstetric_Complications_Diagnosis_Or_Procedure_Excluding_Blood_Transfusion_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Severe_Obstetric_Complications_Diagnosis_Or_Procedure_Excluding_Blood_Transfusion = 8753301857394103144L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Severe_Obstetric_Complications_Diagnosis_Or_Procedure_Excluding_Blood_Transfusion_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            CqlValueSet e_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            CqlValueSet g_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? i_(Procedure SMMProcedures) {
                Code<EventStatus> m_ = SMMProcedures?.StatusElement;
                EventStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "completed");

                object q_() {

                    bool w_() {
                        DataType aa_ = SMMProcedures?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlDateTime;
                        return ac_;
                    }


                    bool x_() {
                        DataType ad_ = SMMProcedures?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlDateTime>;
                        return af_;
                    }


                    bool y_() {
                        DataType ag_ = SMMProcedures?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlQuantity;
                        return ai_;
                    }


                    bool z_() {
                        DataType aj_ = SMMProcedures?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlInterval<CqlQuantity>;
                        return al_;
                    }

                    if (w_())
                    {
                        DataType am_ = SMMProcedures?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return (an_ as CqlDateTime) as object;
                    }
                    else if (x_())
                    {
                        DataType ao_ = SMMProcedures?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return (ap_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (y_())
                    {
                        DataType aq_ = SMMProcedures?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        return (ar_ as CqlQuantity) as object;
                    }
                    else if (z_())
                    {
                        DataType as_ = SMMProcedures?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        return (at_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime> t_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, (string)default);
                bool? v_ = context.Operators.And(p_, u_);
                return v_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            bool? k_ = context.Operators.Exists<Procedure>(j_);
            bool? l_ = context.Operators.Or(f_, k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Expiration")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Expiration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Expiration, Delivery_Encounters_With_Expiration_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Expiration = -2794498871676819460L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Expiration_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            Encounter.HospitalizationComponent d_ = TwentyWeeksPlusEncounter?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Patient_Expired(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Blood_Transfusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Blood_Transfusion, Delivery_Encounters_With_Blood_Transfusion_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Blood_Transfusion = -4889528417638675949L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Blood_Transfusion_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        IEnumerable<Encounter> b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure BloodTransfusion) {
                Code<EventStatus> j_ = BloodTransfusion?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");

                object n_() {

                    bool t_() {
                        DataType x_ = BloodTransfusion?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlDateTime;
                        return z_;
                    }


                    bool u_() {
                        DataType aa_ = BloodTransfusion?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        return ac_;
                    }


                    bool v_() {
                        DataType ad_ = BloodTransfusion?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;
                        return af_;
                    }


                    bool w_() {
                        DataType ag_ = BloodTransfusion?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        return ai_;
                    }

                    if (t_())
                    {
                        DataType aj_ = BloodTransfusion?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        DataType al_ = BloodTransfusion?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        DataType an_ = BloodTransfusion?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        DataType ap_ = BloodTransfusion?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlInterval<CqlDateTime> q_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                return s_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure BloodTransfusion) => TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Severe Obstetric Complications")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Severe_Obstetric_Complications(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Severe_Obstetric_Complications, Delivery_Encounters_With_Severe_Obstetric_Complications_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Severe_Obstetric_Complications = -4447466805798696921L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Severe_Obstetric_Complications_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications_Diagnosis_Or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounters_With_Expiration(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Delivery_Encounters_With_Blood_Transfusion(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Hysterectomy")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Hysterectomy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Hysterectomy, Delivery_Encounters_With_Hysterectomy_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Hysterectomy = 275066854734087907L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Hysterectomy_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        IEnumerable<Encounter> b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Hysterectomy(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure Hysterectomy) {
                Code<EventStatus> j_ = Hysterectomy?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");

                object n_() {

                    bool t_() {
                        DataType x_ = Hysterectomy?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlDateTime;
                        return z_;
                    }


                    bool u_() {
                        DataType aa_ = Hysterectomy?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        return ac_;
                    }


                    bool v_() {
                        DataType ad_ = Hysterectomy?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;
                        return af_;
                    }


                    bool w_() {
                        DataType ag_ = Hysterectomy?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        return ai_;
                    }

                    if (t_())
                    {
                        DataType aj_ = Hysterectomy?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        DataType al_ = Hysterectomy?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        DataType an_ = Hysterectomy?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        DataType ap_ = Hysterectomy?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlInterval<CqlDateTime> q_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                return s_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure Hysterectomy) => TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Cardiac Conversion, Tracheostomy Or Ventilation Procedures")]
    public IEnumerable<Procedure> Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures, Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures_Compute);

    private const long _cacheIndex_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures = 6534466364735929020L;

    private IEnumerable<Procedure> Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures_Compute(CqlContext context)
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


    [CqlExpressionDefinition("Delivery Encounters With Cardiac Conversion, Tracheostomy Or Ventilation Procedures")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures, Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures = 1425442155955483845L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        IEnumerable<Encounter> b_(Encounter TwentyWeeksPlusEncounter) {
            IEnumerable<Procedure> d_ = this.Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures(context);

            bool? e_(Procedure ConvTrachVentProcedures) {
                Code<EventStatus> i_ = ConvTrachVentProcedures?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");

                object m_() {

                    bool s_() {
                        DataType w_ = ConvTrachVentProcedures?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;
                        return y_;
                    }


                    bool t_() {
                        DataType z_ = ConvTrachVentProcedures?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        return ab_;
                    }


                    bool u_() {
                        DataType ac_ = ConvTrachVentProcedures?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlQuantity;
                        return ae_;
                    }


                    bool v_() {
                        DataType af_ = ConvTrachVentProcedures?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                        return ah_;
                    }

                    if (s_())
                    {
                        DataType ai_ = ConvTrachVentProcedures?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        return (aj_ as CqlDateTime) as object;
                    }
                    else if (t_())
                    {
                        DataType ak_ = ConvTrachVentProcedures?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return (al_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (u_())
                    {
                        DataType am_ = ConvTrachVentProcedures?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return (an_ as CqlQuantity) as object;
                    }
                    else if (v_())
                    {
                        DataType ao_ = ConvTrachVentProcedures?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return (ap_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDateTime> p_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                bool? r_ = context.Operators.And(l_, q_);
                return r_;
            }

            IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
            Encounter g_(Procedure ConvTrachVentProcedures) => TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Procedure, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SOC With Hysterectomy Or Blood Transfusion With Placenta Increta Or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SOC_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC, SOC_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC_Compute);

    private const long _cacheIndex_SOC_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC = -8875041619738305098L;

    private IEnumerable<Encounter> SOC_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications(context);

        bool? b_(Encounter SOCEncounter) {
            List<CodeableConcept> l_ = SOCEncounter?.ReasonCode;

            CqlConcept m_(CodeableConcept @this) {
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ae_;
            }

            IEnumerable<CqlConcept> n_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)l_, m_);
            CqlValueSet o_ = this.Placenta_Increta_or_Percreta(context);
            bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
            IEnumerable<object> q_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, SOCEncounter);

            bool? r_(object @this) {
                object af_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_ as CodeableConcept);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                return ah_;
            }

            IEnumerable<object> s_ = context.Operators.Where<object>(q_, r_);

            CqlConcept t_(object @this) {
                object ai_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ai_ as CodeableConcept);
                return aj_;
            }

            IEnumerable<CqlConcept> u_ = context.Operators.Select<object, CqlConcept>(s_, t_);
            bool? w_ = context.Operators.ConceptsInValueSet(u_, o_);
            bool? x_ = context.Operators.Or(p_, w_);
            IEnumerable<Encounter> y_ = this.Delivery_Encounters_With_Blood_Transfusion(context);
            bool? z_ = context.Operators.Exists<Encounter>(y_);
            IEnumerable<Encounter> aa_ = this.Delivery_Encounters_With_Hysterectomy(context);
            bool? ab_ = context.Operators.Exists<Encounter>(aa_);
            bool? ac_ = context.Operators.Or(z_, ab_);
            bool? ad_ = context.Operators.And(x_, ac_);
            return ad_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? e_(Encounter SOCEncounter) {
            CqlValueSet ak_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            CqlValueSet al_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? am_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, SOCEncounter, ak_, al_);
            return am_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = this.Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures(context);
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(f_, g_);
        IEnumerable<Encounter> i_ = this.Delivery_Encounters_With_Expiration(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Except<Encounter>(c_, j_);
        return k_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters With Severe Obstetric Complication Diagnosis")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Diagnosis, SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Diagnosis_Compute);

    private const long _cacheIndex_SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Diagnosis = 3618491577793208763L;

    private IEnumerable<Encounter> SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> b_ = this.SOC_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> c_ = context.Operators.Except<Encounter>(a_, b_);

        bool? d_(Encounter Encounter) {
            CqlValueSet f_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            CqlValueSet g_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? h_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, Encounter, f_, g_);
            return h_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters With Severe Obstetric Complication Procedures")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Procedures, SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Procedures_Compute);

    private const long _cacheIndex_SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Procedures = 3788569516996412836L;

    private IEnumerable<Encounter> SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Procedures_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> b_ = this.SOC_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> c_ = context.Operators.Except<Encounter>(a_, b_);

        bool? d_(Encounter Encounter) {
            CqlValueSet f_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet h_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> j_ = context.Operators.Union<Procedure>(g_, i_);

            bool? k_(Procedure SMMProcedures) {
                Code<EventStatus> n_ = SMMProcedures?.StatusElement;
                EventStatus? o_ = n_?.Value;
                string p_ = context.Operators.Convert<string>(o_);
                bool? q_ = context.Operators.Equal(p_, "completed");

                object r_() {

                    bool x_() {
                        DataType ab_ = SMMProcedures?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlDateTime;
                        return ad_;
                    }


                    bool y_() {
                        DataType ae_ = SMMProcedures?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlDateTime>;
                        return ag_;
                    }


                    bool z_() {
                        DataType ah_ = SMMProcedures?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlQuantity;
                        return aj_;
                    }


                    bool aa_() {
                        DataType ak_ = SMMProcedures?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlInterval<CqlQuantity>;
                        return am_;
                    }

                    if (x_())
                    {
                        DataType an_ = SMMProcedures?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlDateTime) as object;
                    }
                    else if (y_())
                    {
                        DataType ap_ = SMMProcedures?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (z_())
                    {
                        DataType ar_ = SMMProcedures?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return (as_ as CqlQuantity) as object;
                    }
                    else if (aa_())
                    {
                        DataType at_ = SMMProcedures?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return (au_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlInterval<CqlDateTime> u_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, (string)default);
                bool? w_ = context.Operators.And(q_, v_);
                return w_;
            }

            IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
            bool? m_ = context.Operators.Exists<Procedure>(l_);
            return m_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlFunctionDefinition("pOAIsNoOrUTD")]
    public IEnumerable<object> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Claim.DiagnosisComponent> a_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, TheEncounter);

        bool? b_(Claim.DiagnosisComponent CDiagnoses) {
            CodeableConcept g_ = CDiagnoses?.OnAdmission;
            CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
            CqlValueSet i_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
            return j_;
        }

        IEnumerable<Claim.DiagnosisComponent> c_ = context.Operators.Where<Claim.DiagnosisComponent>(a_, b_);

        object d_(Claim.DiagnosisComponent CDiagnoses) {
            DataType k_ = CDiagnoses?.Diagnosis;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            return l_;
        }

        IEnumerable<object> e_ = context.Operators.Select<Claim.DiagnosisComponent, object>(c_, d_);
        IEnumerable<object> f_ = context.Operators.Distinct<object>(e_);
        return f_;
    }


    [CqlFunctionDefinition("sOCDxCategory")]
    public string sOCDxCategory(CqlContext context, CqlConcept Dx)
    {

        string a_() {

            bool b_() {
                CqlValueSet s_ = this.Acute_Heart_Failure(context);
                bool? t_ = context.Operators.ConceptInValueSet(Dx, s_);
                return t_ ?? false;
            }


            bool c_() {
                CqlValueSet u_ = this.Acute_Myocardial_Infarction(context);
                bool? v_ = context.Operators.ConceptInValueSet(Dx, u_);
                return v_ ?? false;
            }


            bool d_() {
                CqlValueSet w_ = this.Acute_Renal_Failure(context);
                bool? x_ = context.Operators.ConceptInValueSet(Dx, w_);
                return x_ ?? false;
            }


            bool e_() {
                CqlValueSet y_ = this.Acute_Respiratory_Distress_Syndrome(context);
                bool? z_ = context.Operators.ConceptInValueSet(Dx, y_);
                return z_ ?? false;
            }


            bool f_() {
                CqlValueSet aa_ = this.Air_and_Thrombotic_Embolism(context);
                bool? ab_ = context.Operators.ConceptInValueSet(Dx, aa_);
                return ab_ ?? false;
            }


            bool g_() {
                CqlValueSet ac_ = this.Amniotic_Fluid_Embolism(context);
                bool? ad_ = context.Operators.ConceptInValueSet(Dx, ac_);
                return ad_ ?? false;
            }


            bool h_() {
                CqlValueSet ae_ = this.Aortic_Aneurysm(context);
                bool? af_ = context.Operators.ConceptInValueSet(Dx, ae_);
                return af_ ?? false;
            }


            bool i_() {
                CqlValueSet ag_ = this.Cardiac_Arrest_Ventricular_Fibrillation(context);
                bool? ah_ = context.Operators.ConceptInValueSet(Dx, ag_);
                return ah_ ?? false;
            }


            bool j_() {
                CqlValueSet ai_ = this.Disseminated_Intravascular_Coagulation(context);
                bool? aj_ = context.Operators.ConceptInValueSet(Dx, ai_);
                return aj_ ?? false;
            }


            bool k_() {
                CqlValueSet ak_ = this.Eclampsia(context);
                bool? al_ = context.Operators.ConceptInValueSet(Dx, ak_);
                return al_ ?? false;
            }


            bool l_() {
                CqlValueSet am_ = this.Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(context);
                bool? an_ = context.Operators.ConceptInValueSet(Dx, am_);
                return an_ ?? false;
            }


            bool m_() {
                CqlValueSet ao_ = this.Puerperal_Cerebrovascular_Disorder(context);
                bool? ap_ = context.Operators.ConceptInValueSet(Dx, ao_);
                return ap_ ?? false;
            }


            bool n_() {
                CqlValueSet aq_ = this.Pulmonary_Edema(context);
                bool? ar_ = context.Operators.ConceptInValueSet(Dx, aq_);
                return ar_ ?? false;
            }


            bool o_() {
                CqlValueSet as_ = this.Sepsis(context);
                bool? at_ = context.Operators.ConceptInValueSet(Dx, as_);
                return at_ ?? false;
            }


            bool p_() {
                CqlValueSet au_ = this.Severe_Anesthesia_Complications(context);
                bool? av_ = context.Operators.ConceptInValueSet(Dx, au_);
                return av_ ?? false;
            }


            bool q_() {
                CqlValueSet aw_ = this.Shock(context);
                bool? ax_ = context.Operators.ConceptInValueSet(Dx, aw_);
                return ax_ ?? false;
            }


            bool r_() {
                CqlValueSet ay_ = this.Sickle_Cell_Disease_with_Crisis(context);
                bool? az_ = context.Operators.ConceptInValueSet(Dx, ay_);
                return az_ ?? false;
            }

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
            };
        }

        return a_();
    }


    [CqlExpressionDefinition("SDE SOC Diagnoses Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_SOC_Diagnoses_Detail, SDE_SOC_Diagnoses_Detail_Compute);

    private const long _cacheIndex_SDE_SOC_Diagnoses_Detail = 4046600195098257904L;

    private IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Diagnosis(context);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)? b_(Encounter Encounter) {
            Id e_ = Encounter?.IdElement;
            string f_ = e_?.Value;
            List<CodeableConcept> g_ = Encounter?.Type;

            CqlConcept h_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            IEnumerable<object> j_ = this.pOAIsNoOrUTD(context, Encounter);

            bool? k_(object Complication) {
                CqlValueSet r_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                bool? s_ = context.Operators.ConceptInValueSet(Complication as CqlConcept, r_);
                object t_ = CQMCommon_4_1_000.Instance.getCondition(context, Complication as ResourceReference);
                object u_ = context.Operators.LateBoundProperty<object>(t_, "code");
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
                bool? x_ = context.Operators.ConceptInValueSet(v_, r_);
                bool? y_ = context.Operators.Or(s_, x_);
                return y_;
            }

            IEnumerable<object> l_ = context.Operators.Where<object>(j_, k_);

            (CqlTupleMetadata, object code, string SOCDxCategory)? m_(object Complication) {
                string z_ = this.sOCDxCategory(context, Complication as CqlConcept);
                (CqlTupleMetadata, object code, string SOCDxCategory)? aa_ = (CqlTupleMetadata_FiRiQVZbDYjPPThNBPPBDcKQI, Complication, z_);
                return aa_;
            }

            IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> n_ = context.Operators.Select<object, (CqlTupleMetadata, object code, string SOCDxCategory)?>(l_, m_);
            IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> o_ = context.Operators.Distinct<(CqlTupleMetadata, object code, string SOCDxCategory)?>(n_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)? p_ = (CqlTupleMetadata_eabGHhAeORbEDBIGhPYhcaaC, f_, i_, o_);
            return p_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?>(c_);
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

        bool? f_(Procedure SMMProcedures) {
            Code<EventStatus> h_ = SMMProcedures?.StatusElement;
            EventStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            bool? k_ = context.Operators.Equal(j_, "completed");

            object l_() {

                bool r_() {
                    DataType v_ = SMMProcedures?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool s_() {
                    DataType y_ = SMMProcedures?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool t_() {
                    DataType ab_ = SMMProcedures?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlQuantity;
                    return ad_;
                }


                bool u_() {
                    DataType ae_ = SMMProcedures?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlInterval<CqlQuantity>;
                    return ag_;
                }

                if (r_())
                {
                    DataType ah_ = SMMProcedures?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlDateTime) as object;
                }
                else if (s_())
                {
                    DataType aj_ = SMMProcedures?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    return (ak_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (t_())
                {
                    DataType al_ = SMMProcedures?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    return (am_ as CqlQuantity) as object;
                }
                else if (u_())
                {
                    DataType an_ = SMMProcedures?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    return (ao_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_());
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlInterval<CqlDateTime> o_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
            bool? q_ = context.Operators.And(k_, p_);
            return q_;
        }

        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
        return g_;
    }


    [CqlFunctionDefinition("sOCProcedureCategory")]
    public string sOCProcedureCategory(CqlContext context, Procedure TheProcedure)
    {

        string a_() {

            bool b_() {
                CodeableConcept g_ = TheProcedure?.Code;
                CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
                CqlValueSet i_ = this.Blood_Transfusion(context);
                bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
                return j_ ?? false;
            }


            bool c_() {
                CodeableConcept k_ = TheProcedure?.Code;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                CqlValueSet m_ = this.Conversion_of_Cardiac_Rhythm(context);
                bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
                return n_ ?? false;
            }


            bool d_() {
                CodeableConcept o_ = TheProcedure?.Code;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlValueSet q_ = this.Hysterectomy(context);
                bool? r_ = context.Operators.ConceptInValueSet(p_, q_);
                return r_ ?? false;
            }


            bool e_() {
                CodeableConcept s_ = TheProcedure?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Tracheostomy(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                return v_ ?? false;
            }


            bool f_() {
                CodeableConcept w_ = TheProcedure?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlValueSet y_ = this.Ventilation(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                return z_ ?? false;
            }

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
            };
        }

        return a_();
    }


    [CqlExpressionDefinition("SDE SOC Procedure Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_SOC_Procedure_Detail, SDE_SOC_Procedure_Detail_Compute);

    private const long _cacheIndex_SDE_SOC_Procedure_Detail = 8235823818015250910L;

    private IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Procedures(context);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? b_(Encounter Encounter) {
            Id e_ = Encounter?.IdElement;
            string f_ = e_?.Value;
            List<CodeableConcept> g_ = Encounter?.Type;

            CqlConcept h_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            IEnumerable<Procedure> j_ = this.sOCProcedures(context, Encounter);

            (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? k_(Procedure P) {
                string p_ = this.sOCProcedureCategory(context, P);
                (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? q_ = (CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR, P, p_);
                return q_;
            }

            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> l_ = context.Operators.Select<Procedure, (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(j_, k_);
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> m_ = context.Operators.Distinct<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(l_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? n_ = (CqlTupleMetadata_DSCMXeIPAPIAQMOTjIfgGISOj, f_, i_, m_);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator Exclusions 1")]
    public IEnumerable<Encounter> Numerator_Exclusions_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_Exclusions_1, Numerator_Exclusions_1_Compute);

    private const long _cacheIndex_Numerator_Exclusions_1 = 4610162010644944656L;

    private IEnumerable<Encounter> Numerator_Exclusions_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.SOC_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC(context);
        return a_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Severe Obstetric Complications Excluding Blood Transfusions")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions, Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions = -1362199374808908541L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications_Diagnosis_Or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounters_With_Expiration(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = 2154861158412903177L;

    private IEnumerable<Encounter> Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Variable_Calculated_Gestational_Age, SDE_Variable_Calculated_Gestational_Age_Compute);

    private const long _cacheIndex_SDE_Variable_Calculated_Gestational_Age = 5206916030657376427L;

    private IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> a_ = PCMaternal_5_25_000.Instance.Variable_Calculated_Gestational_Age(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 3545937530845238352L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);
        return a_;
    }


    [CqlExpressionDefinition("Delivery Encounters With Severe Obstetric Complications Excluding Blood Transfusions Only")]
    public IEnumerable<Encounter> Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only, Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only_Compute);

    private const long _cacheIndex_Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only = -6698400742453710905L;

    private IEnumerable<Encounter> Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -5124973891290010877L;

    private IEnumerable<Encounter> Numerator_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(context);
        return a_;
    }


    [CqlExpressionDefinition("SOC Excluding Blood Transfusions Only With Hysterectomy Or Blood Transfusion With Placenta Increta Or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_Excluding_Blood_Transfusions_Only_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SOC_Excluding_Blood_Transfusions_Only_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC, SOC_Excluding_Blood_Transfusions_Only_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC_Compute);

    private const long _cacheIndex_SOC_Excluding_Blood_Transfusions_Only_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC = 297141924601029635L;

    private IEnumerable<Encounter> SOC_Excluding_Blood_Transfusions_Only_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_With_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(context);

        bool? b_(Encounter SOCExcludingTransfusion) {
            List<CodeableConcept> l_ = SOCExcludingTransfusion?.ReasonCode;

            CqlConcept m_(CodeableConcept @this) {
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ae_;
            }

            IEnumerable<CqlConcept> n_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)l_, m_);
            CqlValueSet o_ = this.Placenta_Increta_or_Percreta(context);
            bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
            IEnumerable<object> q_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);

            bool? r_(object @this) {
                object af_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_ as CodeableConcept);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                return ah_;
            }

            IEnumerable<object> s_ = context.Operators.Where<object>(q_, r_);

            CqlConcept t_(object @this) {
                object ai_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ai_ as CodeableConcept);
                return aj_;
            }

            IEnumerable<CqlConcept> u_ = context.Operators.Select<object, CqlConcept>(s_, t_);
            bool? w_ = context.Operators.ConceptsInValueSet(u_, o_);
            bool? x_ = context.Operators.Or(p_, w_);
            IEnumerable<Encounter> y_ = this.Delivery_Encounters_With_Blood_Transfusion(context);
            bool? z_ = context.Operators.Exists<Encounter>(y_);
            IEnumerable<Encounter> aa_ = this.Delivery_Encounters_With_Hysterectomy(context);
            bool? ab_ = context.Operators.Exists<Encounter>(aa_);
            bool? ac_ = context.Operators.Or(z_, ab_);
            bool? ad_ = context.Operators.And(x_, ac_);
            return ad_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? e_(Encounter SOCExcludingTransfusion) {
            CqlValueSet ak_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            CqlValueSet al_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? am_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, SOCExcludingTransfusion, ak_, al_);
            return am_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = this.Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures(context);
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(f_, g_);
        IEnumerable<Encounter> i_ = this.Delivery_Encounters_With_Expiration(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Except<Encounter>(c_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Numerator Exclusions 2")]
    public IEnumerable<Encounter> Numerator_Exclusions_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_Exclusions_2, Numerator_Exclusions_2_Compute);

    private const long _cacheIndex_Numerator_Exclusions_2 = 572767974419411069L;

    private IEnumerable<Encounter> Numerator_Exclusions_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.SOC_Excluding_Blood_Transfusions_Only_With_Hysterectomy_Or_Blood_Transfusion_With_Placenta_Increta_Or_Placenta_Percreta_Without_Additional_SOC(context);
        return a_;
    }


    [CqlExpressionDefinition("Risk Variable Anemia")]
    public IEnumerable<Encounter> Risk_Variable_Anemia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Anemia, Risk_Variable_Anemia_Compute);

    private const long _cacheIndex_Risk_Variable_Anemia = -2083763165921546841L;

    private IEnumerable<Encounter> Risk_Variable_Anemia_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Anemia(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Asthma")]
    public IEnumerable<Encounter> Risk_Variable_Asthma(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Asthma, Risk_Variable_Asthma_Compute);

    private const long _cacheIndex_Risk_Variable_Asthma = -5379207509324332143L;

    private IEnumerable<Encounter> Risk_Variable_Asthma_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Acute_or_Persistent_Asthma(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Autoimmune Disease")]
    public IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Autoimmune_Disease, Risk_Variable_Autoimmune_Disease_Compute);

    private const long _cacheIndex_Risk_Variable_Autoimmune_Disease = -5937282448078859714L;

    private IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Autoimmune_Disease(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Bariatric Surgery")]
    public IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Bariatric_Surgery, Risk_Variable_Bariatric_Surgery_Compute);

    private const long _cacheIndex_Risk_Variable_Bariatric_Surgery = -2423664243366207310L;

    private IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Bariatric_Surgery(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Bleeding Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Bleeding_Disorder, Risk_Variable_Bleeding_Disorder_Compute);

    private const long _cacheIndex_Risk_Variable_Bleeding_Disorder = -8509688049165530264L;

    private IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Bleeding_Disorder(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Cardiac Disease")]
    public IEnumerable<Encounter> Risk_Variable_Cardiac_Disease(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Cardiac_Disease, Risk_Variable_Cardiac_Disease_Compute);

    private const long _cacheIndex_Risk_Variable_Cardiac_Disease = -8095896995695945254L;

    private IEnumerable<Encounter> Risk_Variable_Cardiac_Disease_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Cardiac_Disease(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Economic Housing Instability")]
    public IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Economic_Housing_Instability, Risk_Variable_Economic_Housing_Instability_Compute);

    private const long _cacheIndex_Risk_Variable_Economic_Housing_Instability = -6636764886588028803L;

    private IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Economic_Housing_Instability(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Gastrointestinal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Gastrointestinal_Disease, Risk_Variable_Gastrointestinal_Disease_Compute);

    private const long _cacheIndex_Risk_Variable_Gastrointestinal_Disease = -3103034770768645482L;

    private IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Gastrointestinal_Disease(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Gestational Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Gestational_Diabetes, Risk_Variable_Gestational_Diabetes_Compute);

    private const long _cacheIndex_Risk_Variable_Gestational_Diabetes = 206032062126845318L;

    private IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Gestational_Diabetes(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable HIV")]
    public IEnumerable<Encounter> Risk_Variable_HIV(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_HIV, Risk_Variable_HIV_Compute);

    private const long _cacheIndex_Risk_Variable_HIV = -4069930958637116991L;

    private IEnumerable<Encounter> Risk_Variable_HIV_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Hypertension(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Hypertension, Risk_Variable_Hypertension_Compute);

    private const long _cacheIndex_Risk_Variable_Hypertension = 5731977825712945515L;

    private IEnumerable<Encounter> Risk_Variable_Hypertension_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Hypertension(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Long Term Anticoagulant Use")]
    public IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Long_Term_Anticoagulant_Use, Risk_Variable_Long_Term_Anticoagulant_Use_Compute);

    private const long _cacheIndex_Risk_Variable_Long_Term_Anticoagulant_Use = -954649318659483405L;

    private IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Long_Term_Anticoagulant_Use(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Maternal Age")]
    public IEnumerable<IEnumerable<object>> Risk_Variable_Maternal_Age(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Maternal_Age, Risk_Variable_Maternal_Age_Compute);

    private const long _cacheIndex_Risk_Variable_Maternal_Age = -8312435409408998474L;

    private IEnumerable<IEnumerable<object>> Risk_Variable_Maternal_Age_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        IEnumerable<object> b_(Encounter TwentyWeeksPlusEncounter) {
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
            return (IEnumerable<object>)n_;
        }

        IEnumerable<IEnumerable<object>> c_ = context.Operators.Select<Encounter, IEnumerable<object>>(a_, b_);
        IEnumerable<IEnumerable<object>> d_ = context.Operators.Distinct<IEnumerable<object>>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Mental Health Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Mental_Health_Disorder, Risk_Variable_Mental_Health_Disorder_Compute);

    private const long _cacheIndex_Risk_Variable_Mental_Health_Disorder = 1367857587353400870L;

    private IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Mental_Health_Disorder(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Morbid Obesity")]
    public IEnumerable<Encounter> Risk_Variable_Morbid_Obesity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Morbid_Obesity, Risk_Variable_Morbid_Obesity_Compute);

    private const long _cacheIndex_Risk_Variable_Morbid_Obesity = 5806686215926746319L;

    private IEnumerable<Encounter> Risk_Variable_Morbid_Obesity_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Morbid_or_Severe_Obesity(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Multiple Pregnancy")]
    public IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Multiple_Pregnancy, Risk_Variable_Multiple_Pregnancy_Compute);

    private const long _cacheIndex_Risk_Variable_Multiple_Pregnancy = -4567379069071164473L;

    private IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Multiple_Pregnancy(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Neuromuscular Disease")]
    public IEnumerable<Encounter> Risk_Variable_Neuromuscular_Disease(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Neuromuscular_Disease, Risk_Variable_Neuromuscular_Disease_Compute);

    private const long _cacheIndex_Risk_Variable_Neuromuscular_Disease = 5155414161172668380L;

    private IEnumerable<Encounter> Risk_Variable_Neuromuscular_Disease_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Neuromuscular_Disease(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Obstetrical VTE")]
    public IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Obstetrical_VTE, Risk_Variable_Obstetrical_VTE_Compute);

    private const long _cacheIndex_Risk_Variable_Obstetrical_VTE = 8002780570606629712L;

    private IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Venous_Thromboembolism_in_Pregnancy(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Other Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Other_Preeclampsia, Risk_Variable_Other_Preeclampsia_Compute);

    private const long _cacheIndex_Risk_Variable_Other_Preeclampsia = 400760625912716477L;

    private IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Mild_or_Moderate_Preeclampsia(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Placenta Previa")]
    public IEnumerable<Encounter> Risk_Variable_Placenta_Previa(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Placenta_Previa, Risk_Variable_Placenta_Previa_Compute);

    private const long _cacheIndex_Risk_Variable_Placenta_Previa = -5422546948143661752L;

    private IEnumerable<Encounter> Risk_Variable_Placenta_Previa_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Placenta_Previa(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Abruption")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Abruption(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Placental_Abruption, Risk_Variable_Placental_Abruption_Compute);

    private const long _cacheIndex_Risk_Variable_Placental_Abruption = -2361396028848159868L;

    private IEnumerable<Encounter> Risk_Variable_Placental_Abruption_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Placental_Abruption(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Accreta Spectrum")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Placental_Accreta_Spectrum, Risk_Variable_Placental_Accreta_Spectrum_Compute);

    private const long _cacheIndex_Risk_Variable_Placental_Accreta_Spectrum = -8609058513657276022L;

    private IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Placenta_Accreta(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            CqlValueSet g_ = this.Placenta_Increta_or_Percreta(context);
            bool? i_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, g_, e_);
            bool? j_ = context.Operators.Or(f_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Preexisting Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Preexisting_Diabetes, Risk_Variable_Preexisting_Diabetes_Compute);

    private const long _cacheIndex_Risk_Variable_Preexisting_Diabetes = 2480635706309875362L;

    private IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Preexisting_Diabetes(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Previous Cesarean")]
    public IEnumerable<Encounter> Risk_Variable_Previous_Cesarean(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Previous_Cesarean, Risk_Variable_Previous_Cesarean_Compute);

    private const long _cacheIndex_Risk_Variable_Previous_Cesarean = -1169825321704637143L;

    private IEnumerable<Encounter> Risk_Variable_Previous_Cesarean_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Previous_Cesarean(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Pulmonary Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Pulmonary_Hypertension, Risk_Variable_Pulmonary_Hypertension_Compute);

    private const long _cacheIndex_Risk_Variable_Pulmonary_Hypertension = -3317765136302774959L;

    private IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Pulmonary_Hypertension(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Renal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Renal_Disease(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Renal_Disease, Risk_Variable_Renal_Disease_Compute);

    private const long _cacheIndex_Risk_Variable_Renal_Disease = -4691150063242294087L;

    private IEnumerable<Encounter> Risk_Variable_Renal_Disease_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Renal_Disease(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Severe Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Severe_Preeclampsia, Risk_Variable_Severe_Preeclampsia_Compute);

    private const long _cacheIndex_Risk_Variable_Severe_Preeclampsia = -2818804355851963914L;

    private IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Severe_Preeclampsia(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Substance Abuse")]
    public IEnumerable<Encounter> Risk_Variable_Substance_Abuse(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Substance_Abuse, Risk_Variable_Substance_Abuse_Compute);

    private const long _cacheIndex_Risk_Variable_Substance_Abuse = 8129261552102530514L;

    private IEnumerable<Encounter> Risk_Variable_Substance_Abuse_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Substance_Abuse(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Thyrotoxicosis")]
    public IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Thyrotoxicosis, Risk_Variable_Thyrotoxicosis_Compute);

    private const long _cacheIndex_Risk_Variable_Thyrotoxicosis = 6827710231932231924L;

    private IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Thyrotoxicosis(context);
            CqlValueSet e_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Preterm Birth")]
    public IEnumerable<Encounter> Risk_Variable_Preterm_Birth(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Preterm_Birth, Risk_Variable_Preterm_Birth_Compute);

    private const long _cacheIndex_Risk_Variable_Preterm_Birth = 2797503933073693423L;

    private IEnumerable<Encounter> Risk_Variable_Preterm_Birth_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter DeliveryEncounter) {
            int? h_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlInterval<int?> i_ = context.Operators.Interval(20, 36, true, true);
            bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
            CqlQuantity l_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity m_ = context.Operators.Quantity(20m, "weeks");
            bool? n_ = context.Operators.GreaterOrEqual(l_, m_);
            CqlQuantity p_ = context.Operators.Quantity(36m, "weeks");
            bool? q_ = context.Operators.LessOrEqual(l_, p_);
            bool? r_ = context.Operators.And(n_, q_);
            bool? s_ = context.Operators.And((bool?)(h_ is null), r_);
            bool? t_ = context.Operators.Or(j_, s_);
            return t_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? e_(Encounter DeliveryEncounter) {
            int? u_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity v_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? w_ = context.Operators.And((bool?)(u_ is null), (bool?)(v_ is null));
            IEnumerable<Claim.DiagnosisComponent> x_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, DeliveryEncounter);

            bool? y_(Claim.DiagnosisComponent CDiagnosis) {
                CodeableConcept ac_ = CDiagnosis?.OnAdmission;
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                CqlCode ae_ = this.POA_Y(context);
                CqlConcept af_ = context.Operators.ConvertCodeToConcept(ae_);
                bool? ag_ = context.Operators.Equivalent(ad_, af_);
                return ag_;
            }

            IEnumerable<Claim.DiagnosisComponent> z_ = context.Operators.Where<Claim.DiagnosisComponent>(x_, y_);
            bool? aa_ = context.Operators.Exists<Claim.DiagnosisComponent>(z_);
            bool? ab_ = context.Operators.And(w_, aa_);
            return ab_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Hematocrit_Lab_Test, Risk_Variable_First_Hematocrit_Lab_Test_Compute);

    private const long _cacheIndex_Risk_Variable_First_Hematocrit_Lab_Test = -6532381667130087125L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter) {
            Id e_ = TwentyWeeksPlusEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Hematocrit_Lab_Test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation Hematocrit) {
                Instant aa_ = Hematocrit?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlInterval<CqlDateTime> ad_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlQuantity af_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                CqlDateTime ah_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, true, true);
                bool? aj_ = context.Operators.In<CqlDateTime>(ac_, ai_, (string)default);
                Code<ObservationStatus> ak_ = Hematocrit?.StatusElement;
                ObservationStatus? al_ = ak_?.Value;
                string am_ = context.Operators.Convert<string>(al_);
                string[] an_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                bool? ap_ = context.Operators.And(aj_, ao_);
                DataType aq_ = Hematocrit?.Value;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                bool? at_ = context.Operators.And(ap_, as_);
                return at_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                Instant au_ = @this?.IssuedElement;
                DateTimeOffset? av_ = au_?.Value;
                CqlDateTime aw_ = context.Operators.Convert<CqlDateTime>(av_);
                CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_ as object);
                return ax_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? r_(Observation Hematocrit) {
                Instant ay_ = Hematocrit?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlInterval<CqlDateTime> bb_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlQuantity bd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime be_ = context.Operators.Subtract(bc_, bd_);
                CqlDateTime bf_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(be_, bf_, true, true);
                bool? bh_ = context.Operators.In<CqlDateTime>(ba_, bg_, (string)default);
                Code<ObservationStatus> bi_ = Hematocrit?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string bk_ = context.Operators.Convert<string>(bj_);
                string[] bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string>(bk_, (IEnumerable<string>)bl_);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType bo_ = Hematocrit?.Value;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                return br_;
            }

            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);

            object t_(Observation @this) {
                Instant bs_ = @this?.IssuedElement;
                DateTimeOffset? bt_ = bs_?.Value;
                CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
                CqlDateTime bv_ = QICoreCommon_4_0_000.Instance.earliest(context, bu_ as object);
                return bv_;
            }

            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, f_, o_ as CqlQuantity, y_);
            return z_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_Lab_Test, Risk_Variable_First_White_Blood_Cell_Count_Lab_Test_Compute);

    private const long _cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_Lab_Test = 3288506537083407272L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter) {
            Id e_ = TwentyWeeksPlusEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.White_Blood_Cells_Count_Lab_Test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation WBC) {
                Instant aa_ = WBC?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlInterval<CqlDateTime> ad_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlQuantity af_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                CqlDateTime ah_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, true, true);
                bool? aj_ = context.Operators.In<CqlDateTime>(ac_, ai_, (string)default);
                Code<ObservationStatus> ak_ = WBC?.StatusElement;
                ObservationStatus? al_ = ak_?.Value;
                string am_ = context.Operators.Convert<string>(al_);
                string[] an_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                bool? ap_ = context.Operators.And(aj_, ao_);
                DataType aq_ = WBC?.Value;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                bool? at_ = context.Operators.And(ap_, as_);
                return at_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                Instant au_ = @this?.IssuedElement;
                DateTimeOffset? av_ = au_?.Value;
                CqlDateTime aw_ = context.Operators.Convert<CqlDateTime>(av_);
                CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_ as object);
                return ax_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? r_(Observation WBC) {
                Instant ay_ = WBC?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlInterval<CqlDateTime> bb_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlQuantity bd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime be_ = context.Operators.Subtract(bc_, bd_);
                CqlDateTime bf_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(be_, bf_, true, true);
                bool? bh_ = context.Operators.In<CqlDateTime>(ba_, bg_, (string)default);
                Code<ObservationStatus> bi_ = WBC?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string bk_ = context.Operators.Convert<string>(bj_);
                string[] bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string>(bk_, (IEnumerable<string>)bl_);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType bo_ = WBC?.Value;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                return br_;
            }

            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);

            object t_(Observation @this) {
                Instant bs_ = @this?.IssuedElement;
                DateTimeOffset? bt_ = bs_?.Value;
                CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
                CqlDateTime bv_ = QICoreCommon_4_0_000.Instance.earliest(context, bu_ as object);
                return bv_;
            }

            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA, f_, o_ as CqlQuantity, y_);
            return z_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Heart_Rate, Risk_Variable_Heart_Rate_Compute);

    private const long _cacheIndex_Risk_Variable_Heart_Rate = -7231162851022711395L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter) {
            Id e_ = TwentyWeeksPlusEncounter?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

            bool? h_(Observation HeartRate) {
                DataType y_ = HeartRate?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlQuantity ad_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
                CqlDateTime af_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ae_, af_, true, true);
                bool? ah_ = context.Operators.In<CqlDateTime>(aa_, ag_, (string)default);
                Code<ObservationStatus> ai_ = HeartRate?.StatusElement;
                ObservationStatus? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                string[] al_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                bool? an_ = context.Operators.And(ah_, am_);
                return an_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                DataType ao_ = @this?.Effective;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                return aq_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);

            bool? p_(Observation HeartRate) {
                DataType ar_ = HeartRate?.Effective;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ax_ = context.Operators.Subtract(av_, aw_);
                CqlDateTime ay_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> az_ = context.Operators.Interval(ax_, ay_, true, true);
                bool? ba_ = context.Operators.In<CqlDateTime>(at_, az_, (string)default);
                Code<ObservationStatus> bb_ = HeartRate?.StatusElement;
                ObservationStatus? bc_ = bb_?.Value;
                string bd_ = context.Operators.Convert<string>(bc_);
                string[] be_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bf_ = context.Operators.In<string>(bd_, (IEnumerable<string>)be_);
                bool? bg_ = context.Operators.And(ba_, bf_);
                return bg_;
            }

            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(g_, p_);

            object r_(Observation @this) {
                DataType bh_ = @this?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_);
                return bj_;
            }

            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV, f_, n_ as CqlQuantity, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Systolic_Blood_Pressure, Risk_Variable_Systolic_Blood_Pressure_Compute);

    private const long _cacheIndex_Risk_Variable_Systolic_Blood_Pressure = 4446916058428857482L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter) {
            Id e_ = TwentyWeeksPlusEncounter?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? h_(Observation BP) {
                DataType ad_ = BP?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
                CqlInterval<CqlDateTime> ag_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlQuantity ai_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime aj_ = context.Operators.Subtract(ah_, ai_);
                CqlDateTime ak_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> al_ = context.Operators.Interval(aj_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(af_, al_, (string)default);
                Code<ObservationStatus> an_ = BP?.StatusElement;
                ObservationStatus? ao_ = an_?.Value;
                string ap_ = context.Operators.Convert<string>(ao_);
                string[] aq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ar_ = context.Operators.In<string>(ap_, (IEnumerable<string>)aq_);
                bool? as_ = context.Operators.And(am_, ar_);
                List<Observation.ComponentComponent> at_ = BP?.Component;

                bool? au_(Observation.ComponentComponent @this) {
                    DataType ba_ = @this?.Value;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                    return bc_;
                }

                IEnumerable<Observation.ComponentComponent> av_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)at_, au_);

                object aw_(Observation.ComponentComponent @this) {
                    DataType bd_ = @this?.Value;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    return be_;
                }

                IEnumerable<object> ax_ = context.Operators.Select<Observation.ComponentComponent, object>(av_, aw_);
                bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                bool? az_ = context.Operators.And(as_, ay_);
                return az_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                DataType bf_ = @this?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            List<Observation.ComponentComponent> m_ = l_?.Component;

            bool? n_(Observation.ComponentComponent C) {
                CodeableConcept bi_ = C?.Code;
                CqlConcept bj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bi_);
                CqlCode bk_ = this.Systolic_blood_pressure(context);
                CqlConcept bl_ = context.Operators.ConvertCodeToConcept(bk_);
                bool? bm_ = context.Operators.Equivalent(bj_, bl_);
                return bm_;
            }

            IEnumerable<Observation.ComponentComponent> o_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)m_, n_);

            CqlQuantity p_(Observation.ComponentComponent C) {
                DataType bn_ = C?.Value;
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                return bo_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> q_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(o_, p_);
            IEnumerable<CqlQuantity> r_ = context.Operators.Distinct<CqlQuantity>(q_);
            CqlQuantity s_ = context.Operators.SingletonFrom<CqlQuantity>(r_);

            bool? u_(Observation BP) {
                DataType bp_ = BP?.Effective;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                CqlDateTime br_ = QICoreCommon_4_0_000.Instance.earliest(context, bq_);
                CqlInterval<CqlDateTime> bs_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime bt_ = context.Operators.Start(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bv_ = context.Operators.Subtract(bt_, bu_);
                CqlDateTime bw_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(bv_, bw_, true, true);
                bool? by_ = context.Operators.In<CqlDateTime>(br_, bx_, (string)default);
                Code<ObservationStatus> bz_ = BP?.StatusElement;
                ObservationStatus? ca_ = bz_?.Value;
                string cb_ = context.Operators.Convert<string>(ca_);
                string[] cc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
                bool? ce_ = context.Operators.And(by_, cd_);
                List<Observation.ComponentComponent> cf_ = BP?.Component;

                bool? cg_(Observation.ComponentComponent @this) {
                    DataType cm_ = @this?.Value;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool? co_ = context.Operators.Not((bool?)(cn_ is null));
                    return co_;
                }

                IEnumerable<Observation.ComponentComponent> ch_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)cf_, cg_);

                object ci_(Observation.ComponentComponent @this) {
                    DataType cp_ = @this?.Value;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return cq_;
                }

                IEnumerable<object> cj_ = context.Operators.Select<Observation.ComponentComponent, object>(ch_, ci_);
                bool? ck_ = context.Operators.Not((bool?)(cj_ is null));
                bool? cl_ = context.Operators.And(ce_, ck_);
                return cl_;
            }

            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(g_, u_);

            object w_(Observation @this) {
                DataType cr_ = @this?.Effective;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                CqlDateTime ct_ = QICoreCommon_4_0_000.Instance.earliest(context, cs_);
                return ct_;
            }

            IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
            Observation y_ = context.Operators.First<Observation>(x_);
            DataType z_ = y_?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)? ac_ = (CqlTupleMetadata_FJEchIHcbcHRUXZAJNSdfScQb, f_, s_, ab_);
            return ac_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1028FHIRPCSevereOBComps_1_0_000() {}

    public static CMS1028FHIRPCSevereOBComps_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1028FHIRPCSevereOBComps";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, PCMaternal_5_25_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstHematocritResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DSCMXeIPAPIAQMOTjIfgGISOj = new(
       [typeof(string), typeof(IEnumerable<CqlConcept>), typeof(IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>)],
       ["id", "code", "procedures"]);

    private static CqlTupleMetadata CqlTupleMetadata_eabGHhAeORbEDBIGhPYhcaaC = new(
       [typeof(string), typeof(IEnumerable<CqlConcept>), typeof(IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?>)],
       ["id", "code", "complications"]);

    private static CqlTupleMetadata CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstWBCResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FiRiQVZbDYjPPThNBPPBDcKQI = new(
       [typeof(object), typeof(string)],
       ["code", "SOCDxCategory"]);

    private static CqlTupleMetadata CqlTupleMetadata_FJEchIHcbcHRUXZAJNSdfScQb = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstSBPResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR = new(
       [typeof(Procedure), typeof(string)],
       ["code", "SOCProcedureCategory"]);

    private static CqlTupleMetadata CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstHRResult", "Timing"]);

    #endregion CqlTupleMetadata Properties

}
