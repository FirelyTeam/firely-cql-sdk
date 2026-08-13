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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
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
            bool? e_ = (bool?)(d_ is null);
            // CQL 'and' (177:5-178:75): right operand skipped when left is false
            if (e_ is false)
            {
                return false;
            }
            else
            {
                CqlQuantity f_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                CqlQuantity g_ = context.Operators.Quantity(20m, "weeks");
                bool? h_ = context.Operators.GreaterOrEqual(f_, g_);
                return e_ & h_;
            }
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
            bool? e_ = (bool?)(d_ is null);
            bool? f_;
            // CQL 'and' (218:11-219:67): right operand skipped when left is false
            if (e_ is false)
            {
                f_ = false;
            }
            else
            {
                CqlQuantity g_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                f_ = e_ & ((bool?)(g_ is null));
            }
            // CQL 'and' (218:5-222:7): right operand skipped when left is false
            if (f_ is false)
            {
                return false;
            }
            else
            {
                List<CodeableConcept> h_ = DeliveryEncounter?.ReasonCode;

                CqlConcept i_(CodeableConcept @this) {
                    CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return n_;
                }

                IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
                CqlValueSet k_ = this._20_to_42_Plus_Weeks_Gestation(context);
                bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
                bool? m_;
                // CQL 'or' (220:11-222:7): right operand skipped when left is true
                if (l_ is true)
                {
                    m_ = true;
                }
                else
                {
                    IEnumerable<Condition> o_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

                    bool? p_(Condition @this) {
                        CodeableConcept u_ = @this?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        return !((bool?)(v_ is null));
                    }


                    CqlConcept q_(Condition @this) {
                        CodeableConcept w_ = @this?.Code;
                        CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                        return x_;
                    }

                    IEnumerable<CqlConcept> r_ = context.Operators.WhereSelect<Condition, CqlConcept>(o_, p_, q_);
                    CqlValueSet s_ = this._20_to_42_Plus_Weeks_Gestation(context);
                    bool? t_ = context.Operators.ConceptsInValueSet(r_, s_);
                    m_ = l_ | t_;
                }
                return f_ & m_;
            }
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
            // CQL 'or' (231:5-236:7): right operand skipped when left is true
            if (f_ is true)
            {
                return true;
            }
            else
            {
                CqlValueSet g_ = this.Severe_Maternal_Morbidity_Procedures(context);
                IEnumerable<Procedure> h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? i_(Procedure SMMProcedures) {
                    Code<EventStatus> k_ = SMMProcedures?.StatusElement;
                    EventStatus? l_ = k_?.Value;
                    string m_ = context.Operators.Convert<string>(l_);
                    bool? n_ = context.Operators.Equal(m_, "completed");
                    // CQL 'and' (233:13-234:140): right operand skipped when left is false
                    if (n_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        object o_;
                        DataType t_ = SMMProcedures?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        bool v_ = u_ is CqlDateTime;
                        if (v_)
                        {
                            DataType w_ = SMMProcedures?.Performed;
                            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                            o_ = x_ as CqlDateTime;
                        }
                        else
                        {
                            DataType y_ = SMMProcedures?.Performed;
                            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                            bool aa_ = z_ is CqlQuantity;
                            if (aa_)
                            {
                                DataType ab_ = SMMProcedures?.Performed;
                                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                                o_ = ac_ as CqlQuantity;
                            }
                            else
                            {
                                DataType ad_ = SMMProcedures?.Performed;
                                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                                bool af_ = ae_ is CqlInterval<CqlDateTime>;
                                if (af_)
                                {
                                    DataType ag_ = SMMProcedures?.Performed;
                                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                                    o_ = ah_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    DataType ai_ = SMMProcedures?.Performed;
                                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                    bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                                    if (ak_)
                                    {
                                        DataType al_ = SMMProcedures?.Performed;
                                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                        o_ = am_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        o_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                        CqlDateTime q_ = context.Operators.Start(p_);
                        CqlInterval<CqlDateTime> r_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                        bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, (string)default);
                        return n_ & s_;
                    }
                }

                bool? j_ = context.Operators.WhereAny<Procedure>(h_, i_);
                return f_ | j_;
            }
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

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure BloodTransfusion) {
                Code<EventStatus> h_ = BloodTransfusion?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                // CQL 'and' (409:17-410:137): right operand skipped when left is false
                if (k_ is false)
                {
                    return false;
                }
                else
                {
                    object l_;
                    DataType q_ = BloodTransfusion?.Performed;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;
                    if (s_)
                    {
                        DataType t_ = BloodTransfusion?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        l_ = u_ as CqlDateTime;
                    }
                    else
                    {
                        DataType v_ = BloodTransfusion?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlQuantity;
                        if (x_)
                        {
                            DataType y_ = BloodTransfusion?.Performed;
                            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                            l_ = z_ as CqlQuantity;
                        }
                        else
                        {
                            DataType aa_ = BloodTransfusion?.Performed;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                            if (ac_)
                            {
                                DataType ad_ = BloodTransfusion?.Performed;
                                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                                l_ = ae_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType af_ = BloodTransfusion?.Performed;
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                                if (ah_)
                                {
                                    DataType ai_ = BloodTransfusion?.Performed;
                                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                    l_ = aj_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    l_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    CqlInterval<CqlDateTime> o_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                    bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                    return k_ & p_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
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

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            CqlValueSet d_ = this.Hysterectomy(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure Hysterectomy) {
                Code<EventStatus> h_ = Hysterectomy?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");
                // CQL 'and' (209:17-210:133): right operand skipped when left is false
                if (k_ is false)
                {
                    return false;
                }
                else
                {
                    object l_;
                    DataType q_ = Hysterectomy?.Performed;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;
                    if (s_)
                    {
                        DataType t_ = Hysterectomy?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        l_ = u_ as CqlDateTime;
                    }
                    else
                    {
                        DataType v_ = Hysterectomy?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlQuantity;
                        if (x_)
                        {
                            DataType y_ = Hysterectomy?.Performed;
                            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                            l_ = z_ as CqlQuantity;
                        }
                        else
                        {
                            DataType aa_ = Hysterectomy?.Performed;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                            if (ac_)
                            {
                                DataType ad_ = Hysterectomy?.Performed;
                                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                                l_ = ae_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType af_ = Hysterectomy?.Performed;
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                                if (ah_)
                                {
                                    DataType ai_ = Hysterectomy?.Performed;
                                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                    l_ = aj_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    l_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    CqlInterval<CqlDateTime> o_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                    bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                    return k_ & p_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
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

        bool? b_(Encounter TwentyWeeksPlusEncounter) {
            IEnumerable<Procedure> d_ = this.Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures(context);

            bool? e_(Procedure ConvTrachVentProcedures) {
                Code<EventStatus> g_ = ConvTrachVentProcedures?.StatusElement;
                EventStatus? h_ = g_?.Value;
                string i_ = context.Operators.Convert<string>(h_);
                bool? j_ = context.Operators.Equal(i_, "completed");
                // CQL 'and' (195:17-196:144): right operand skipped when left is false
                if (j_ is false)
                {
                    return false;
                }
                else
                {
                    object k_;
                    DataType p_ = ConvTrachVentProcedures?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    if (r_)
                    {
                        DataType s_ = ConvTrachVentProcedures?.Performed;
                        object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                        k_ = t_ as CqlDateTime;
                    }
                    else
                    {
                        DataType u_ = ConvTrachVentProcedures?.Performed;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        bool w_ = v_ is CqlQuantity;
                        if (w_)
                        {
                            DataType x_ = ConvTrachVentProcedures?.Performed;
                            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                            k_ = y_ as CqlQuantity;
                        }
                        else
                        {
                            DataType z_ = ConvTrachVentProcedures?.Performed;
                            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                            bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                            if (ab_)
                            {
                                DataType ac_ = ConvTrachVentProcedures?.Performed;
                                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                                k_ = ad_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ae_ = ConvTrachVentProcedures?.Performed;
                                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                                bool ag_ = af_ is CqlInterval<CqlQuantity>;
                                if (ag_)
                                {
                                    DataType ah_ = ConvTrachVentProcedures?.Performed;
                                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                    k_ = ai_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    k_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                    CqlDateTime m_ = context.Operators.Start(l_);
                    CqlInterval<CqlDateTime> n_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                    bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, (string)default);
                    return j_ & o_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Procedure>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
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
            List<CodeableConcept> k_ = SOCEncounter?.ReasonCode;

            CqlConcept l_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Placenta_Increta_or_Percreta(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
            bool? p_;
            // CQL 'or' (148:13-150:7): right operand skipped when left is true
            if (o_ is true)
            {
                p_ = true;
            }
            else
            {
                IEnumerable<Condition> r_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, SOCEncounter);

                bool? s_(Condition @this) {
                    CodeableConcept x_ = @this?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    return !((bool?)(y_ is null));
                }


                CqlConcept t_(Condition @this) {
                    CodeableConcept z_ = @this?.Code;
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                    return aa_;
                }

                IEnumerable<CqlConcept> u_ = context.Operators.WhereSelect<Condition, CqlConcept>(r_, s_, t_);
                CqlValueSet v_ = this.Placenta_Increta_or_Percreta(context);
                bool? w_ = context.Operators.ConceptsInValueSet(u_, v_);
                p_ = o_ | w_;
            }
            // CQL 'and' (148:7-153:9): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Encounter> ab_ = this.Delivery_Encounters_With_Blood_Transfusion(context);
                bool? ac_ = context.Operators.Exists<Encounter>(ab_);
                bool? ad_;
                // CQL 'or' (151:13-153:9): right operand skipped when left is true
                if (ac_ is true)
                {
                    ad_ = true;
                }
                else
                {
                    IEnumerable<Encounter> ae_ = this.Delivery_Encounters_With_Hysterectomy(context);
                    bool? af_ = context.Operators.Exists<Encounter>(ae_);
                    ad_ = ac_ | af_;
                }
                return p_ & ad_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter SOCEncounter) {
            CqlValueSet ag_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            CqlValueSet ah_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? ai_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, SOCEncounter, ag_, ah_);
            return ai_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = this.Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures(context);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(e_, f_);
        IEnumerable<Encounter> h_ = this.Delivery_Encounters_With_Expiration(context);
        IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Except<Encounter>(c_, i_);
        return j_;
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
                Code<EventStatus> m_ = SMMProcedures?.StatusElement;
                EventStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "completed");
                // CQL 'and' (112:7-113:119): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    object q_;
                    DataType v_ = SMMProcedures?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    if (x_)
                    {
                        DataType y_ = SMMProcedures?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        q_ = z_ as CqlDateTime;
                    }
                    else
                    {
                        DataType aa_ = SMMProcedures?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlQuantity;
                        if (ac_)
                        {
                            DataType ad_ = SMMProcedures?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            q_ = ae_ as CqlQuantity;
                        }
                        else
                        {
                            DataType af_ = SMMProcedures?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                            if (ah_)
                            {
                                DataType ai_ = SMMProcedures?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                q_ = aj_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ak_ = SMMProcedures?.Performed;
                                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                                bool am_ = al_ is CqlInterval<CqlQuantity>;
                                if (am_)
                                {
                                    DataType an_ = SMMProcedures?.Performed;
                                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                    q_ = ao_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    q_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    CqlDateTime s_ = context.Operators.Start(r_);
                    CqlInterval<CqlDateTime> t_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                    bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, (string)default);
                    return p_ & u_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Procedure>(j_, k_);
            return l_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlFunctionDefinition("pOAIsNoOrUTD")]
    public IEnumerable<object> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Claim.DiagnosisComponent> a_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, TheEncounter);

        bool? b_(Claim.DiagnosisComponent CDiagnoses) {
            CodeableConcept f_ = CDiagnoses?.OnAdmission;
            CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, f_);
            CqlValueSet h_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? i_ = context.Operators.ConceptInValueSet(g_, h_);
            return i_;
        }


        object c_(Claim.DiagnosisComponent CDiagnoses) {
            DataType j_ = CDiagnoses?.Diagnosis;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            return k_;
        }

        IEnumerable<object> d_ = context.Operators.WhereSelect<Claim.DiagnosisComponent, object>(a_, b_, c_);
        IEnumerable<object> e_ = context.Operators.Distinct<object>(d_);
        return e_;
    }


    [CqlFunctionDefinition("sOCDxCategory")]
    public string sOCDxCategory(CqlContext context, CqlConcept Dx)
    {
        CqlValueSet a_ = this.Acute_Heart_Failure(context);
        bool? b_ = context.Operators.ConceptInValueSet(Dx, a_);
        if (b_ ?? false)
        {
            return "Acute Heart Failure";
        }
        else
        {
            CqlValueSet c_ = this.Acute_Myocardial_Infarction(context);
            bool? d_ = context.Operators.ConceptInValueSet(Dx, c_);
            if (d_ ?? false)
            {
                return "Acute Myocardial Infarction";
            }
            else
            {
                CqlValueSet e_ = this.Acute_Renal_Failure(context);
                bool? f_ = context.Operators.ConceptInValueSet(Dx, e_);
                if (f_ ?? false)
                {
                    return "Acute Renal Failure";
                }
                else
                {
                    CqlValueSet g_ = this.Acute_Respiratory_Distress_Syndrome(context);
                    bool? h_ = context.Operators.ConceptInValueSet(Dx, g_);
                    if (h_ ?? false)
                    {
                        return "Acute Respiratory Distress Syndrome";
                    }
                    else
                    {
                        CqlValueSet i_ = this.Air_and_Thrombotic_Embolism(context);
                        bool? j_ = context.Operators.ConceptInValueSet(Dx, i_);
                        if (j_ ?? false)
                        {
                            return "Air and Thrombotic Embolism";
                        }
                        else
                        {
                            CqlValueSet k_ = this.Amniotic_Fluid_Embolism(context);
                            bool? l_ = context.Operators.ConceptInValueSet(Dx, k_);
                            if (l_ ?? false)
                            {
                                return "Amniotic Fluid Embolism";
                            }
                            else
                            {
                                CqlValueSet m_ = this.Aortic_Aneurysm(context);
                                bool? n_ = context.Operators.ConceptInValueSet(Dx, m_);
                                if (n_ ?? false)
                                {
                                    return "Aortic Aneurysm";
                                }
                                else
                                {
                                    CqlValueSet o_ = this.Cardiac_Arrest_Ventricular_Fibrillation(context);
                                    bool? p_ = context.Operators.ConceptInValueSet(Dx, o_);
                                    if (p_ ?? false)
                                    {
                                        return "Cardiac Arrest Ventricular Fibrillation";
                                    }
                                    else
                                    {
                                        CqlValueSet q_ = this.Disseminated_Intravascular_Coagulation(context);
                                        bool? r_ = context.Operators.ConceptInValueSet(Dx, q_);
                                        if (r_ ?? false)
                                        {
                                            return "Disseminated Intravascular Coagulation";
                                        }
                                        else
                                        {
                                            CqlValueSet s_ = this.Eclampsia(context);
                                            bool? t_ = context.Operators.ConceptInValueSet(Dx, s_);
                                            if (t_ ?? false)
                                            {
                                                return "Eclampsia";
                                            }
                                            else
                                            {
                                                CqlValueSet u_ = this.Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(context);
                                                bool? v_ = context.Operators.ConceptInValueSet(Dx, u_);
                                                if (v_ ?? false)
                                                {
                                                    return "Heart Failure Cardiac Arrest Related to Procedure or Surgery";
                                                }
                                                else
                                                {
                                                    CqlValueSet w_ = this.Puerperal_Cerebrovascular_Disorder(context);
                                                    bool? x_ = context.Operators.ConceptInValueSet(Dx, w_);
                                                    if (x_ ?? false)
                                                    {
                                                        return "Puerperal Cerebrovascular Disorder";
                                                    }
                                                    else
                                                    {
                                                        CqlValueSet y_ = this.Pulmonary_Edema(context);
                                                        bool? z_ = context.Operators.ConceptInValueSet(Dx, y_);
                                                        if (z_ ?? false)
                                                        {
                                                            return "Pulmonary Edema";
                                                        }
                                                        else
                                                        {
                                                            CqlValueSet aa_ = this.Sepsis(context);
                                                            bool? ab_ = context.Operators.ConceptInValueSet(Dx, aa_);
                                                            if (ab_ ?? false)
                                                            {
                                                                return "Sepsis";
                                                            }
                                                            else
                                                            {
                                                                CqlValueSet ac_ = this.Severe_Anesthesia_Complications(context);
                                                                bool? ad_ = context.Operators.ConceptInValueSet(Dx, ac_);
                                                                if (ad_ ?? false)
                                                                {
                                                                    return "Severe Anesthesia Complications";
                                                                }
                                                                else
                                                                {
                                                                    CqlValueSet ae_ = this.Shock(context);
                                                                    bool? af_ = context.Operators.ConceptInValueSet(Dx, ae_);
                                                                    if (af_ ?? false)
                                                                    {
                                                                        return "Shock";
                                                                    }
                                                                    else
                                                                    {
                                                                        CqlValueSet ag_ = this.Sickle_Cell_Disease_with_Crisis(context);
                                                                        bool? ah_ = context.Operators.ConceptInValueSet(Dx, ag_);
                                                                        if (ah_ ?? false)
                                                                        {
                                                                            return "Sickle Cell Disease with Crisis";
                                                                        }
                                                                        else
                                                                        {
                                                                            return default;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }


    [CqlExpressionDefinition("SDE SOC Diagnoses Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_SOC_Diagnoses_Detail, SDE_SOC_Diagnoses_Detail_Compute);

    private const long _cacheIndex_SDE_SOC_Diagnoses_Detail = 4046600195098257904L;

    private IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Diagnosis(context);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)? b_(Encounter Encounter) {
            Id d_ = Encounter?.IdElement;
            string e_ = d_?.Value;
            List<CodeableConcept> f_ = Encounter?.Type;

            CqlConcept g_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> h_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)f_, g_);
            IEnumerable<object> i_ = this.pOAIsNoOrUTD(context, Encounter);

            bool? j_(object Complication) {
                CqlValueSet p_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                bool? q_ = context.Operators.ConceptInValueSet(Complication as CqlConcept, p_);
                // CQL 'or' (122:9-123:88): right operand skipped when left is true
                if (q_ is true)
                {
                    return true;
                }
                else
                {
                    Condition r_ = CQMCommon_4_1_000.Instance.getCondition(context, Complication as ResourceReference);
                    CodeableConcept s_ = r_?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    CqlValueSet u_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                    bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                    return q_ | v_;
                }
            }


            (CqlTupleMetadata, object code, string SOCDxCategory)? k_(object Complication) {
                string w_ = this.sOCDxCategory(context, Complication as CqlConcept);
                (CqlTupleMetadata, object code, string SOCDxCategory)? x_ = (CqlTupleMetadata_FiRiQVZbDYjPPThNBPPBDcKQI, Complication, w_);
                return x_;
            }

            IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> l_ = context.Operators.WhereSelect<object, (CqlTupleMetadata, object code, string SOCDxCategory)?>(i_, j_, k_);
            IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> m_ = context.Operators.Distinct<(CqlTupleMetadata, object code, string SOCDxCategory)?>(l_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)? n_ = (CqlTupleMetadata_eabGHhAeORbEDBIGhPYhcaaC, e_, h_, m_);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, object code, string SOCDxCategory)?> complications)?>(a_, b_);
        return c_;
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
            // CQL 'and' (536:5-537:120): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                object l_;
                DataType q_ = SMMProcedures?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    DataType t_ = SMMProcedures?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    l_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType v_ = SMMProcedures?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = SMMProcedures?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        l_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = SMMProcedures?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType ad_ = SMMProcedures?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            l_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType af_ = SMMProcedures?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType ai_ = SMMProcedures?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                l_ = aj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                l_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                return k_ & p_;
            }
        }

        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
        return g_;
    }


    [CqlFunctionDefinition("sOCProcedureCategory")]
    public string sOCProcedureCategory(CqlContext context, Procedure TheProcedure)
    {
        CodeableConcept a_ = TheProcedure?.Code;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlValueSet c_ = this.Blood_Transfusion(context);
        bool? d_ = context.Operators.ConceptInValueSet(b_, c_);
        if (d_ ?? false)
        {
            return "Blood Transfusion";
        }
        else
        {
            CodeableConcept e_ = TheProcedure?.Code;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Conversion_of_Cardiac_Rhythm(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            if (h_ ?? false)
            {
                return "Conversion of cardiac rhythm";
            }
            else
            {
                CodeableConcept i_ = TheProcedure?.Code;
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, i_);
                CqlValueSet k_ = this.Hysterectomy(context);
                bool? l_ = context.Operators.ConceptInValueSet(j_, k_);
                if (l_ ?? false)
                {
                    return "Hysterectomy";
                }
                else
                {
                    CodeableConcept m_ = TheProcedure?.Code;
                    CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                    CqlValueSet o_ = this.Tracheostomy(context);
                    bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
                    if (p_ ?? false)
                    {
                        return "Tracheostomy";
                    }
                    else
                    {
                        CodeableConcept q_ = TheProcedure?.Code;
                        CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                        CqlValueSet s_ = this.Ventilation(context);
                        bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                        if (t_ ?? false)
                        {
                            return "Ventilation";
                        }
                        else
                        {
                            return default;
                        }
                    }
                }
            }
        }
    }


    [CqlExpressionDefinition("SDE SOC Procedure Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_SOC_Procedure_Detail, SDE_SOC_Procedure_Detail_Compute);

    private const long _cacheIndex_SDE_SOC_Procedure_Detail = 8235823818015250910L;

    private IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.SDE_Delivery_Encounters_With_Severe_Obstetric_Complication_Procedures(context);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? b_(Encounter Encounter) {
            Id d_ = Encounter?.IdElement;
            string e_ = d_?.Value;
            List<CodeableConcept> f_ = Encounter?.Type;

            CqlConcept g_(CodeableConcept @this) {
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return m_;
            }

            IEnumerable<CqlConcept> h_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)f_, g_);
            IEnumerable<Procedure> i_ = this.sOCProcedures(context, Encounter);

            (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? j_(Procedure P) {
                string n_ = this.sOCProcedureCategory(context, P);
                (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? o_ = (CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR, P, n_);
                return o_;
            }

            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> k_ = context.Operators.SelectDistinct<Procedure, (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(i_, j_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? l_ = (CqlTupleMetadata_DSCMXeIPAPIAQMOTjIfgGISOj, e_, h_, k_);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> code, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(a_, b_);
        return c_;
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
            List<CodeableConcept> k_ = SOCExcludingTransfusion?.ReasonCode;

            CqlConcept l_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Placenta_Increta_or_Percreta(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
            bool? p_;
            // CQL 'or' (250:13-252:7): right operand skipped when left is true
            if (o_ is true)
            {
                p_ = true;
            }
            else
            {
                IEnumerable<Condition> r_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);

                bool? s_(Condition @this) {
                    CodeableConcept x_ = @this?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    return !((bool?)(y_ is null));
                }


                CqlConcept t_(Condition @this) {
                    CodeableConcept z_ = @this?.Code;
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                    return aa_;
                }

                IEnumerable<CqlConcept> u_ = context.Operators.WhereSelect<Condition, CqlConcept>(r_, s_, t_);
                CqlValueSet v_ = this.Placenta_Increta_or_Percreta(context);
                bool? w_ = context.Operators.ConceptsInValueSet(u_, v_);
                p_ = o_ | w_;
            }
            // CQL 'and' (250:7-255:9): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Encounter> ab_ = this.Delivery_Encounters_With_Blood_Transfusion(context);
                bool? ac_ = context.Operators.Exists<Encounter>(ab_);
                bool? ad_;
                // CQL 'or' (253:13-255:9): right operand skipped when left is true
                if (ac_ is true)
                {
                    ad_ = true;
                }
                else
                {
                    IEnumerable<Encounter> ae_ = this.Delivery_Encounters_With_Hysterectomy(context);
                    bool? af_ = context.Operators.Exists<Encounter>(ae_);
                    ad_ = ac_ | af_;
                }
                return p_ & ad_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter SOCExcludingTransfusion) {
            CqlValueSet ag_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            CqlValueSet ah_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? ai_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, SOCExcludingTransfusion, ag_, ah_);
            return ai_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = this.Delivery_Encounters_With_Cardiac_Conversion__Tracheostomy_Or_Ventilation_Procedures(context);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(e_, f_);
        IEnumerable<Encounter> h_ = this.Delivery_Encounters_With_Expiration(context);
        IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Except<Encounter>(c_, i_);
        return j_;
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
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = TwentyWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            object[] m_ = [
                TwentyWeeksPlusEncounter,
                l_ ?? default(int),
            ];
            return (IEnumerable<object>)m_;
        }

        IEnumerable<IEnumerable<object>> c_ = context.Operators.SelectDistinct<Encounter, IEnumerable<object>>(a_, b_);
        return c_;
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
            // CQL 'or' (354:5-355:139): right operand skipped when left is true
            if (f_ is true)
            {
                return true;
            }
            else
            {
                CqlValueSet g_ = this.Placenta_Increta_or_Percreta(context);
                CqlValueSet h_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
                bool? i_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, g_, h_);
                return f_ | i_;
            }
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
            int? g_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlInterval<int?> h_ = context.Operators.Interval(20, 36, true, true);
            bool? i_ = context.Operators.In<int?>(g_, h_, (string)default);
            // CQL 'or' (389:7-394:9): right operand skipped when left is true
            if (i_ is true)
            {
                return true;
            }
            else
            {
                int? j_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
                bool? k_ = (bool?)(j_ is null);
                bool? l_;
                // CQL 'and' (390:12-394:9): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    CqlQuantity m_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                    CqlQuantity n_ = context.Operators.Quantity(20m, "weeks");
                    bool? o_ = context.Operators.GreaterOrEqual(m_, n_);
                    bool? p_;
                    // CQL 'and' (391:17-393:13): right operand skipped when left is false
                    if (o_ is false)
                    {
                        p_ = false;
                    }
                    else
                    {
                        CqlQuantity q_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                        CqlQuantity r_ = context.Operators.Quantity(36m, "weeks");
                        bool? s_ = context.Operators.LessOrEqual(q_, r_);
                        p_ = o_ & s_;
                    }
                    l_ = k_ & p_;
                }
                return i_ | l_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter DeliveryEncounter) {
            int? t_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? u_ = (bool?)(t_ is null);
            bool? v_;
            // CQL 'and' (399:15-400:25): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                CqlQuantity w_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                v_ = u_ & ((bool?)(w_ is null));
            }
            // CQL 'and' (399:9-403:11): right operand skipped when left is false
            if (v_ is false)
            {
                return false;
            }
            else
            {
                IEnumerable<Claim.DiagnosisComponent> x_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, DeliveryEncounter);

                bool? y_(Claim.DiagnosisComponent CDiagnosis) {
                    CodeableConcept aa_ = CDiagnosis?.OnAdmission;
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                    CqlCode ac_ = this.POA_Y(context);
                    CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                    bool? ae_ = context.Operators.Equivalent(ab_, ad_);
                    return ae_;
                }

                bool? z_ = context.Operators.WhereAny<Claim.DiagnosisComponent>(x_, y_);
                return v_ & z_;
            }
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Hematocrit_Lab_Test, Risk_Variable_First_Hematocrit_Lab_Test_Compute);

    private const long _cacheIndex_Risk_Variable_First_Hematocrit_Lab_Test = -6532381667130087125L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter) {
            Id d_ = TwentyWeeksPlusEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Hematocrit_Lab_Test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation Hematocrit) {
                Instant x_ = Hematocrit?.IssuedElement;
                DateTimeOffset? y_ = x_?.Value;
                CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
                CqlInterval<CqlDateTime> aa_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlQuantity ac_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
                CqlDateTime ae_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ad_, ae_, true, true);
                bool? ag_ = context.Operators.In<CqlDateTime>(z_, af_, (string)default);
                bool? ah_;
                // CQL 'and' (421:15-422:70): right operand skipped when left is false
                if (ag_ is false)
                {
                    ah_ = false;
                }
                else
                {
                    Code<ObservationStatus> ai_ = Hematocrit?.StatusElement;
                    ObservationStatus? aj_ = ai_?.Value;
                    string ak_ = context.Operators.Convert<string>(aj_);
                    string[] al_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                    ah_ = ag_ & am_;
                }
                // CQL 'and' (421:9-423:42): right operand skipped when left is false
                if (ah_ is false)
                {
                    return false;
                }
                else
                {
                    DataType an_ = Hematocrit?.Value;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    return ah_ & (!((bool?)(ao_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                return as_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation Hematocrit) {
                Instant at_ = Hematocrit?.IssuedElement;
                DateTimeOffset? au_ = at_?.Value;
                CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
                CqlInterval<CqlDateTime> aw_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ax_ = context.Operators.Start(aw_);
                CqlQuantity ay_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime az_ = context.Operators.Subtract(ax_, ay_);
                CqlDateTime ba_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(az_, ba_, true, true);
                bool? bc_ = context.Operators.In<CqlDateTime>(av_, bb_, (string)default);
                bool? bd_;
                // CQL 'and' (421:15-422:70): right operand skipped when left is false
                if (bc_ is false)
                {
                    bd_ = false;
                }
                else
                {
                    Code<ObservationStatus> be_ = Hematocrit?.StatusElement;
                    ObservationStatus? bf_ = be_?.Value;
                    string bg_ = context.Operators.Convert<string>(bf_);
                    string[] bh_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bi_ = context.Operators.In<string>(bg_, (IEnumerable<string>)bh_);
                    bd_ = bc_ & bi_;
                }
                // CQL 'and' (421:9-423:42): right operand skipped when left is false
                if (bd_ is false)
                {
                    return false;
                }
                else
                {
                    DataType bj_ = Hematocrit?.Value;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return bd_ & (!((bool?)(bk_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bl_ = @this?.IssuedElement;
                DateTimeOffset? bm_ = bl_?.Value;
                CqlDateTime bn_ = context.Operators.Convert<CqlDateTime>(bm_);
                CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_);
                return bo_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_Lab_Test, Risk_Variable_First_White_Blood_Cell_Count_Lab_Test_Compute);

    private const long _cacheIndex_Risk_Variable_First_White_Blood_Cell_Count_Lab_Test = 3288506537083407272L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter) {
            Id d_ = TwentyWeeksPlusEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.White_Blood_Cells_Count_Lab_Test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation WBC) {
                Instant x_ = WBC?.IssuedElement;
                DateTimeOffset? y_ = x_?.Value;
                CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
                CqlInterval<CqlDateTime> aa_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlQuantity ac_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
                CqlDateTime ae_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ad_, ae_, true, true);
                bool? ag_ = context.Operators.In<CqlDateTime>(z_, af_, (string)default);
                bool? ah_;
                // CQL 'and' (441:15-442:63): right operand skipped when left is false
                if (ag_ is false)
                {
                    ah_ = false;
                }
                else
                {
                    Code<ObservationStatus> ai_ = WBC?.StatusElement;
                    ObservationStatus? aj_ = ai_?.Value;
                    string ak_ = context.Operators.Convert<string>(aj_);
                    string[] al_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                    ah_ = ag_ & am_;
                }
                // CQL 'and' (441:9-443:35): right operand skipped when left is false
                if (ah_ is false)
                {
                    return false;
                }
                else
                {
                    DataType an_ = WBC?.Value;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    return ah_ & (!((bool?)(ao_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                return as_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation WBC) {
                Instant at_ = WBC?.IssuedElement;
                DateTimeOffset? au_ = at_?.Value;
                CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
                CqlInterval<CqlDateTime> aw_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ax_ = context.Operators.Start(aw_);
                CqlQuantity ay_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime az_ = context.Operators.Subtract(ax_, ay_);
                CqlDateTime ba_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(az_, ba_, true, true);
                bool? bc_ = context.Operators.In<CqlDateTime>(av_, bb_, (string)default);
                bool? bd_;
                // CQL 'and' (441:15-442:63): right operand skipped when left is false
                if (bc_ is false)
                {
                    bd_ = false;
                }
                else
                {
                    Code<ObservationStatus> be_ = WBC?.StatusElement;
                    ObservationStatus? bf_ = be_?.Value;
                    string bg_ = context.Operators.Convert<string>(bf_);
                    string[] bh_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bi_ = context.Operators.In<string>(bg_, (IEnumerable<string>)bh_);
                    bd_ = bc_ & bi_;
                }
                // CQL 'and' (441:9-443:35): right operand skipped when left is false
                if (bd_ is false)
                {
                    return false;
                }
                else
                {
                    DataType bj_ = WBC?.Value;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return bd_ & (!((bool?)(bk_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bl_ = @this?.IssuedElement;
                DateTimeOffset? bm_ = bl_?.Value;
                CqlDateTime bn_ = context.Operators.Convert<CqlDateTime>(bm_);
                CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_);
                return bo_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Heart_Rate, Risk_Variable_Heart_Rate_Compute);

    private const long _cacheIndex_Risk_Variable_Heart_Rate = -7231162851022711395L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter) {
            Id d_ = TwentyWeeksPlusEncounter?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

            bool? g_(Observation HeartRate) {
                DataType w_ = HeartRate?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlQuantity ab_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
                CqlDateTime ad_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ac_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(y_, ae_, (string)default);
                // CQL 'and' (463:9-464:69): right operand skipped when left is false
                if (af_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> ag_ = HeartRate?.StatusElement;
                    ObservationStatus? ah_ = ag_?.Value;
                    string ai_ = context.Operators.Convert<string>(ah_);
                    string[] aj_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
                    return af_ & ak_;
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType al_ = @this?.Effective;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
                return an_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            DataType l_ = k_?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation HeartRate) {
                DataType ao_ = HeartRate?.Effective;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                CqlInterval<CqlDateTime> ar_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlQuantity at_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime au_ = context.Operators.Subtract(as_, at_);
                CqlDateTime av_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(au_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDateTime>(aq_, aw_, (string)default);
                // CQL 'and' (463:9-464:69): right operand skipped when left is false
                if (ax_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> ay_ = HeartRate?.StatusElement;
                    ObservationStatus? az_ = ay_?.Value;
                    string ba_ = context.Operators.Convert<string>(az_);
                    string[] bb_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                    return ax_ & bc_;
                }
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(f_, n_);

            object p_(Observation @this) {
                DataType bd_ = @this?.Effective;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                CqlDateTime bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                return bf_;
            }

            IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
            Observation r_ = context.Operators.First<Observation>(q_);
            DataType s_ = r_?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? v_ = (CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV, e_, m_ as CqlQuantity, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Systolic_Blood_Pressure, Risk_Variable_Systolic_Blood_Pressure_Compute);

    private const long _cacheIndex_Risk_Variable_Systolic_Blood_Pressure = 4446916058428857482L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_Than_Or_Equal_To_20_Weeks_Gestation(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter) {
            Id d_ = TwentyWeeksPlusEncounter?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? g_(Observation BP) {
                DataType aa_ = BP?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_4_0_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlQuantity af_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                CqlDateTime ah_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, true, true);
                bool? aj_ = context.Operators.In<CqlDateTime>(ac_, ai_, (string)default);
                bool? ak_;
                // CQL 'and' (484:15-485:62): right operand skipped when left is false
                if (aj_ is false)
                {
                    ak_ = false;
                }
                else
                {
                    Code<ObservationStatus> al_ = BP?.StatusElement;
                    ObservationStatus? am_ = al_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    string[] ao_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
                    ak_ = aj_ & ap_;
                }
                // CQL 'and' (484:9-486:44): right operand skipped when left is false
                if (ak_ is false)
                {
                    return false;
                }
                else
                {
                    List<Observation.ComponentComponent> aq_ = BP?.Component;

                    bool? ar_(Observation.ComponentComponent @this) {
                        DataType au_ = @this?.Value;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        return !((bool?)(av_ is null));
                    }


                    object as_(Observation.ComponentComponent @this) {
                        DataType aw_ = @this?.Value;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return ax_;
                    }

                    IEnumerable<object> at_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)aq_, ar_, as_);
                    return ak_ & (!((bool?)(at_ is null)));
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ay_ = @this?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_);
                return ba_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept bb_ = C?.Code;
                CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                CqlCode bd_ = this.Systolic_blood_pressure(context);
                CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                bool? bf_ = context.Operators.Equivalent(bc_, be_);
                return bf_;
            }


            CqlQuantity n_(Observation.ComponentComponent C) {
                DataType bg_ = C?.Value;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                return bh_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> o_ = context.Operators.WhereSelect<Observation.ComponentComponent, CqlQuantity>((IEnumerable<Observation.ComponentComponent>)l_, m_, n_);
            IEnumerable<CqlQuantity> p_ = context.Operators.Distinct<CqlQuantity>(o_);
            CqlQuantity q_ = context.Operators.SingletonFrom<CqlQuantity>(p_);

            bool? r_(Observation BP) {
                DataType bi_ = BP?.Effective;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                CqlDateTime bk_ = QICoreCommon_4_0_000.Instance.earliest(context, bj_);
                CqlInterval<CqlDateTime> bl_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlQuantity bn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bo_ = context.Operators.Subtract(bm_, bn_);
                CqlDateTime bp_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bq_ = context.Operators.Interval(bo_, bp_, true, true);
                bool? br_ = context.Operators.In<CqlDateTime>(bk_, bq_, (string)default);
                bool? bs_;
                // CQL 'and' (484:15-485:62): right operand skipped when left is false
                if (br_ is false)
                {
                    bs_ = false;
                }
                else
                {
                    Code<ObservationStatus> bt_ = BP?.StatusElement;
                    ObservationStatus? bu_ = bt_?.Value;
                    string bv_ = context.Operators.Convert<string>(bu_);
                    string[] bw_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bx_ = context.Operators.In<string>(bv_, (IEnumerable<string>)bw_);
                    bs_ = br_ & bx_;
                }
                // CQL 'and' (484:9-486:44): right operand skipped when left is false
                if (bs_ is false)
                {
                    return false;
                }
                else
                {
                    List<Observation.ComponentComponent> by_ = BP?.Component;

                    bool? bz_(Observation.ComponentComponent @this) {
                        DataType cc_ = @this?.Value;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        return !((bool?)(cd_ is null));
                    }


                    object ca_(Observation.ComponentComponent @this) {
                        DataType ce_ = @this?.Value;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        return cf_;
                    }

                    IEnumerable<object> cb_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)by_, bz_, ca_);
                    return bs_ & (!((bool?)(cb_ is null)));
                }
            }

            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(f_, r_);

            object t_(Observation @this) {
                DataType cg_ = @this?.Effective;
                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                CqlDateTime ci_ = QICoreCommon_4_0_000.Instance.earliest(context, ch_);
                return ci_;
            }

            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            DataType w_ = v_?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_FJEchIHcbcHRUXZAJNSdfScQb, e_, q_, y_);
            return z_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSBPResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
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
