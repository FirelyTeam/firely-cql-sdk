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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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

            bool? e_() {
                CqlQuantity f_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                CqlQuantity g_ = context.Operators.Quantity(20m, "weeks");
                bool? h_ = context.Operators.GreaterOrEqual(f_, g_);
                return (bool?)((CqlBoolean)h_);
            }

            return (bool?)(/* CQL 'and' (177:5-178:75) */ ((CqlBoolean)((bool?)(d_ is null))
                && (CqlBoolean)e_()));
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

            bool? e_() {
                List<CodeableConcept> f_ = DeliveryEncounter?.ReasonCode;

                CqlConcept g_(CodeableConcept @this) {
                    CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return l_;
                }

                IEnumerable<CqlConcept> h_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)f_, g_);
                CqlValueSet i_ = this._20_to_42_Plus_Weeks_Gestation(context);
                bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);

                bool? k_() {
                    IEnumerable<Condition> m_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

                    bool? n_(Condition @this) {
                        CodeableConcept s_ = @this?.Code;
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                        return !((bool?)(t_ is null));
                    }


                    CqlConcept o_(Condition @this) {
                        CodeableConcept u_ = @this?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        return v_;
                    }

                    IEnumerable<CqlConcept> p_ = context.Operators.WhereSelect<Condition, CqlConcept>(m_, n_, o_);
                    CqlValueSet q_ = this._20_to_42_Plus_Weeks_Gestation(context);
                    bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);
                    return (bool?)((CqlBoolean)r_);
                }

                return (bool?)(/* CQL 'or' (220:11-222:7) */ ((CqlBoolean)j_
                    || (CqlBoolean)k_()));
            }

            return (bool?)(/* CQL 'and' (218:5-222:7) */ (/* CQL 'and' (218:11-219:67) */ ((CqlBoolean)((bool?)(d_ is null))
                && (CqlBoolean)((bool?)((PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter)) is null)))
                && (CqlBoolean)e_()));
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

            bool? g_() {
                CqlValueSet h_ = this.Severe_Maternal_Morbidity_Procedures(context);
                IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? j_(Procedure SMMProcedures) {
                    Code<EventStatus> l_ = SMMProcedures?.StatusElement;
                    EventStatus? m_ = l_?.Value;
                    string n_ = context.Operators.Convert<string>(m_);
                    bool? o_ = context.Operators.Equal(n_, "completed");

                    bool? p_() {
                        object q_;
                        DataType v_ = SMMProcedures?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlDateTime;
                        if (x_)
                        {
                            q_ = w_ as CqlDateTime;
                        }
                        else
                        {
                            bool y_ = w_ is CqlQuantity;
                            if (y_)
                            {
                                q_ = w_ as CqlQuantity;
                            }
                            else
                            {
                                bool z_ = w_ is CqlInterval<CqlDateTime>;
                                if (z_)
                                {
                                    q_ = w_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool aa_ = w_ is CqlInterval<CqlQuantity>;
                                    if (aa_)
                                    {
                                        q_ = w_ as CqlInterval<CqlQuantity>;
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
                        CqlInterval<CqlDateTime> t_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                        bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, (string)default);
                        return (bool?)((CqlBoolean)u_);
                    }

                    return (bool?)(/* CQL 'and' (233:13-234:140) */ ((CqlBoolean)o_
                        && (CqlBoolean)p_()));
                }

                bool? k_ = context.Operators.WhereAny<Procedure>(i_, j_);
                return (bool?)((CqlBoolean)k_);
            }

            return (bool?)(/* CQL 'or' (231:5-236:7) */ ((CqlBoolean)f_
                || (CqlBoolean)g_()));
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

                bool? l_() {
                    object m_;
                    DataType r_ = BloodTransfusion?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool t_ = s_ is CqlDateTime;
                    if (t_)
                    {
                        m_ = s_ as CqlDateTime;
                    }
                    else
                    {
                        bool u_ = s_ is CqlQuantity;
                        if (u_)
                        {
                            m_ = s_ as CqlQuantity;
                        }
                        else
                        {
                            bool v_ = s_ is CqlInterval<CqlDateTime>;
                            if (v_)
                            {
                                m_ = s_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool w_ = s_ is CqlInterval<CqlQuantity>;
                                if (w_)
                                {
                                    m_ = s_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    m_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    CqlInterval<CqlDateTime> p_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                    bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                    return (bool?)((CqlBoolean)q_);
                }

                return (bool?)(/* CQL 'and' (409:17-410:137) */ ((CqlBoolean)k_
                    && (CqlBoolean)l_()));
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

                bool? l_() {
                    object m_;
                    DataType r_ = Hysterectomy?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool t_ = s_ is CqlDateTime;
                    if (t_)
                    {
                        m_ = s_ as CqlDateTime;
                    }
                    else
                    {
                        bool u_ = s_ is CqlQuantity;
                        if (u_)
                        {
                            m_ = s_ as CqlQuantity;
                        }
                        else
                        {
                            bool v_ = s_ is CqlInterval<CqlDateTime>;
                            if (v_)
                            {
                                m_ = s_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool w_ = s_ is CqlInterval<CqlQuantity>;
                                if (w_)
                                {
                                    m_ = s_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    m_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    CqlInterval<CqlDateTime> p_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                    bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                    return (bool?)((CqlBoolean)q_);
                }

                return (bool?)(/* CQL 'and' (209:17-210:133) */ ((CqlBoolean)k_
                    && (CqlBoolean)l_()));
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

                bool? k_() {
                    object l_;
                    DataType q_ = ConvTrachVentProcedures?.Performed;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;
                    if (s_)
                    {
                        l_ = r_ as CqlDateTime;
                    }
                    else
                    {
                        bool t_ = r_ is CqlQuantity;
                        if (t_)
                        {
                            l_ = r_ as CqlQuantity;
                        }
                        else
                        {
                            bool u_ = r_ is CqlInterval<CqlDateTime>;
                            if (u_)
                            {
                                l_ = r_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool v_ = r_ is CqlInterval<CqlQuantity>;
                                if (v_)
                                {
                                    l_ = r_ as CqlInterval<CqlQuantity>;
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
                    return (bool?)((CqlBoolean)p_);
                }

                return (bool?)(/* CQL 'and' (195:17-196:144) */ ((CqlBoolean)j_
                    && (CqlBoolean)k_()));
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
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return r_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Placenta_Increta_or_Percreta(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);

            bool? p_() {
                IEnumerable<Condition> s_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, SOCEncounter);

                bool? t_(Condition @this) {
                    CodeableConcept y_ = @this?.Code;
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                    return !((bool?)(z_ is null));
                }


                CqlConcept u_(Condition @this) {
                    CodeableConcept aa_ = @this?.Code;
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                    return ab_;
                }

                IEnumerable<CqlConcept> v_ = context.Operators.WhereSelect<Condition, CqlConcept>(s_, t_, u_);
                CqlValueSet w_ = this.Placenta_Increta_or_Percreta(context);
                bool? x_ = context.Operators.ConceptsInValueSet(v_, w_);
                return (bool?)((CqlBoolean)x_);
            }


            bool? q_() {
                IEnumerable<Encounter> ac_ = this.Delivery_Encounters_With_Blood_Transfusion(context);
                bool? ad_ = context.Operators.Exists<Encounter>(ac_);

                bool? ae_() {
                    IEnumerable<Encounter> af_ = this.Delivery_Encounters_With_Hysterectomy(context);
                    bool? ag_ = context.Operators.Exists<Encounter>(af_);
                    return (bool?)((CqlBoolean)ag_);
                }

                return (bool?)(/* CQL 'or' (151:13-153:9) */ ((CqlBoolean)ad_
                    || (CqlBoolean)ae_()));
            }

            return (bool?)(/* CQL 'and' (148:7-153:9) */ (/* CQL 'or' (148:13-150:7) */ ((CqlBoolean)o_
                || (CqlBoolean)p_())
                && (CqlBoolean)q_()));
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter SOCEncounter) {
            CqlValueSet ah_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            CqlValueSet ai_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? aj_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, SOCEncounter, ah_, ai_);
            return aj_;
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

                bool? q_() {
                    object r_;
                    DataType w_ = SMMProcedures?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;
                    if (y_)
                    {
                        r_ = x_ as CqlDateTime;
                    }
                    else
                    {
                        bool z_ = x_ is CqlQuantity;
                        if (z_)
                        {
                            r_ = x_ as CqlQuantity;
                        }
                        else
                        {
                            bool aa_ = x_ is CqlInterval<CqlDateTime>;
                            if (aa_)
                            {
                                r_ = x_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ab_ = x_ is CqlInterval<CqlQuantity>;
                                if (ab_)
                                {
                                    r_ = x_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    r_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    CqlInterval<CqlDateTime> u_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                    bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, (string)default);
                    return (bool?)((CqlBoolean)v_);
                }

                return (bool?)(/* CQL 'and' (112:7-113:119) */ ((CqlBoolean)p_
                    && (CqlBoolean)q_()));
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

                bool? r_() {
                    Condition s_ = CQMCommon_4_1_000.Instance.getCondition(context, Complication as ResourceReference);
                    CodeableConcept t_ = s_?.Code;
                    CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                    CqlValueSet v_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                    bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                    return (bool?)((CqlBoolean)w_);
                }

                return (bool?)(/* CQL 'or' (122:9-123:88) */ ((CqlBoolean)q_
                    || (CqlBoolean)r_()));
            }


            (CqlTupleMetadata, object code, string SOCDxCategory)? k_(object Complication) {
                string x_ = this.sOCDxCategory(context, Complication as CqlConcept);
                (CqlTupleMetadata, object code, string SOCDxCategory)? y_ = (CqlTupleMetadata_FiRiQVZbDYjPPThNBPPBDcKQI, Complication, x_);
                return y_;
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

            bool? l_() {
                object m_;
                DataType r_ = SMMProcedures?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    m_ = s_ as CqlDateTime;
                }
                else
                {
                    bool u_ = s_ is CqlQuantity;
                    if (u_)
                    {
                        m_ = s_ as CqlQuantity;
                    }
                    else
                    {
                        bool v_ = s_ is CqlInterval<CqlDateTime>;
                        if (v_)
                        {
                            m_ = s_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool w_ = s_ is CqlInterval<CqlQuantity>;
                            if (w_)
                            {
                                m_ = s_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                m_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDateTime> p_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                return (bool?)((CqlBoolean)q_);
            }

            return (bool?)(/* CQL 'and' (536:5-537:120) */ ((CqlBoolean)k_
                && (CqlBoolean)l_()));
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
            CqlValueSet e_ = this.Conversion_of_Cardiac_Rhythm(context);
            bool? f_ = context.Operators.ConceptInValueSet(b_, e_);
            if (f_ ?? false)
            {
                return "Conversion of cardiac rhythm";
            }
            else
            {
                CqlValueSet g_ = this.Hysterectomy(context);
                bool? h_ = context.Operators.ConceptInValueSet(b_, g_);
                if (h_ ?? false)
                {
                    return "Hysterectomy";
                }
                else
                {
                    CqlValueSet i_ = this.Tracheostomy(context);
                    bool? j_ = context.Operators.ConceptInValueSet(b_, i_);
                    if (j_ ?? false)
                    {
                        return "Tracheostomy";
                    }
                    else
                    {
                        CqlValueSet k_ = this.Ventilation(context);
                        bool? l_ = context.Operators.ConceptInValueSet(b_, k_);
                        if (l_ ?? false)
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
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return r_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Placenta_Increta_or_Percreta(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);

            bool? p_() {
                IEnumerable<Condition> s_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);

                bool? t_(Condition @this) {
                    CodeableConcept y_ = @this?.Code;
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                    return !((bool?)(z_ is null));
                }


                CqlConcept u_(Condition @this) {
                    CodeableConcept aa_ = @this?.Code;
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                    return ab_;
                }

                IEnumerable<CqlConcept> v_ = context.Operators.WhereSelect<Condition, CqlConcept>(s_, t_, u_);
                CqlValueSet w_ = this.Placenta_Increta_or_Percreta(context);
                bool? x_ = context.Operators.ConceptsInValueSet(v_, w_);
                return (bool?)((CqlBoolean)x_);
            }


            bool? q_() {
                IEnumerable<Encounter> ac_ = this.Delivery_Encounters_With_Blood_Transfusion(context);
                bool? ad_ = context.Operators.Exists<Encounter>(ac_);

                bool? ae_() {
                    IEnumerable<Encounter> af_ = this.Delivery_Encounters_With_Hysterectomy(context);
                    bool? ag_ = context.Operators.Exists<Encounter>(af_);
                    return (bool?)((CqlBoolean)ag_);
                }

                return (bool?)(/* CQL 'or' (253:13-255:9) */ ((CqlBoolean)ad_
                    || (CqlBoolean)ae_()));
            }

            return (bool?)(/* CQL 'and' (250:7-255:9) */ (/* CQL 'or' (250:13-252:7) */ ((CqlBoolean)o_
                || (CqlBoolean)p_())
                && (CqlBoolean)q_()));
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter SOCExcludingTransfusion) {
            CqlValueSet ah_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            CqlValueSet ai_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? aj_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, SOCExcludingTransfusion, ah_, ai_);
            return aj_;
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

            bool? g_() {
                CqlValueSet h_ = this.Placenta_Increta_or_Percreta(context);
                CqlValueSet i_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
                bool? j_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, TwentyWeeksPlusEncounter, h_, i_);
                return (bool?)((CqlBoolean)j_);
            }

            return (bool?)(/* CQL 'or' (354:5-355:139) */ ((CqlBoolean)f_
                || (CqlBoolean)g_()));
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

            bool? j_() {
                int? k_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);

                bool? l_() {
                    CqlQuantity m_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                    CqlQuantity n_ = context.Operators.Quantity(20m, "weeks");
                    bool? o_ = context.Operators.GreaterOrEqual(m_, n_);

                    bool? p_() {
                        CqlQuantity q_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                        CqlQuantity r_ = context.Operators.Quantity(36m, "weeks");
                        bool? s_ = context.Operators.LessOrEqual(q_, r_);
                        return (bool?)((CqlBoolean)s_);
                    }

                    return (bool?)(/* CQL 'and' (391:17-393:13) */ ((CqlBoolean)o_
                        && (CqlBoolean)p_()));
                }

                return (bool?)(/* CQL 'and' (390:12-394:9) */ ((CqlBoolean)((bool?)(k_ is null))
                    && (CqlBoolean)l_()));
            }

            return (bool?)(/* CQL 'or' (389:7-394:9) */ ((CqlBoolean)i_
                || (CqlBoolean)j_()));
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter DeliveryEncounter) {
            int? t_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);

            bool? u_() {
                IEnumerable<Claim.DiagnosisComponent> v_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, DeliveryEncounter);

                bool? w_(Claim.DiagnosisComponent CDiagnosis) {
                    CodeableConcept y_ = CDiagnosis?.OnAdmission;
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                    CqlCode aa_ = this.POA_Y(context);
                    CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
                    bool? ac_ = context.Operators.Equivalent(z_, ab_);
                    return ac_;
                }

                bool? x_ = context.Operators.WhereAny<Claim.DiagnosisComponent>(v_, w_);
                return (bool?)((CqlBoolean)x_);
            }

            return (bool?)(/* CQL 'and' (399:9-403:11) */ (/* CQL 'and' (399:15-400:25) */ ((CqlBoolean)((bool?)(t_ is null))
                && (CqlBoolean)((bool?)((PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter)) is null)))
                && (CqlBoolean)u_()));
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

                bool? ah_() {
                    Code<ObservationStatus> aj_ = Hematocrit?.StatusElement;
                    ObservationStatus? ak_ = aj_?.Value;
                    string al_ = context.Operators.Convert<string>(ak_);
                    string[] am_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? an_ = context.Operators.In<string>(al_, (IEnumerable<string>)am_);
                    return (bool?)((CqlBoolean)an_);
                }


                bool? ai_() {
                    DataType ao_ = Hematocrit?.Value;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    return (bool?)((CqlBoolean)(!((bool?)(ap_ is null))));
                }

                return (bool?)(/* CQL 'and' (421:9-423:42) */ (/* CQL 'and' (421:15-422:70) */ ((CqlBoolean)ag_
                    && (CqlBoolean)ah_())
                    && (CqlBoolean)ai_()));
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant aq_ = @this?.IssuedElement;
                DateTimeOffset? ar_ = aq_?.Value;
                CqlDateTime as_ = context.Operators.Convert<CqlDateTime>(ar_);
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                return at_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation Hematocrit) {
                Instant au_ = Hematocrit?.IssuedElement;
                DateTimeOffset? av_ = au_?.Value;
                CqlDateTime aw_ = context.Operators.Convert<CqlDateTime>(av_);
                CqlInterval<CqlDateTime> ax_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                CqlQuantity az_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ba_ = context.Operators.Subtract(ay_, az_);
                CqlDateTime bb_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ba_, bb_, true, true);
                bool? bd_ = context.Operators.In<CqlDateTime>(aw_, bc_, (string)default);

                bool? be_() {
                    Code<ObservationStatus> bg_ = Hematocrit?.StatusElement;
                    ObservationStatus? bh_ = bg_?.Value;
                    string bi_ = context.Operators.Convert<string>(bh_);
                    string[] bj_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bk_ = context.Operators.In<string>(bi_, (IEnumerable<string>)bj_);
                    return (bool?)((CqlBoolean)bk_);
                }


                bool? bf_() {
                    DataType bl_ = Hematocrit?.Value;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bool?)((CqlBoolean)(!((bool?)(bm_ is null))));
                }

                return (bool?)(/* CQL 'and' (421:9-423:42) */ (/* CQL 'and' (421:15-422:70) */ ((CqlBoolean)bd_
                    && (CqlBoolean)be_())
                    && (CqlBoolean)bf_()));
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bn_ = @this?.IssuedElement;
                DateTimeOffset? bo_ = bn_?.Value;
                CqlDateTime bp_ = context.Operators.Convert<CqlDateTime>(bo_);
                CqlDateTime bq_ = QICoreCommon_4_0_000.Instance.earliest(context, bp_);
                return bq_;
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

                bool? ah_() {
                    Code<ObservationStatus> aj_ = WBC?.StatusElement;
                    ObservationStatus? ak_ = aj_?.Value;
                    string al_ = context.Operators.Convert<string>(ak_);
                    string[] am_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? an_ = context.Operators.In<string>(al_, (IEnumerable<string>)am_);
                    return (bool?)((CqlBoolean)an_);
                }


                bool? ai_() {
                    DataType ao_ = WBC?.Value;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    return (bool?)((CqlBoolean)(!((bool?)(ap_ is null))));
                }

                return (bool?)(/* CQL 'and' (441:9-443:35) */ (/* CQL 'and' (441:15-442:63) */ ((CqlBoolean)ag_
                    && (CqlBoolean)ah_())
                    && (CqlBoolean)ai_()));
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant aq_ = @this?.IssuedElement;
                DateTimeOffset? ar_ = aq_?.Value;
                CqlDateTime as_ = context.Operators.Convert<CqlDateTime>(ar_);
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                return at_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation WBC) {
                Instant au_ = WBC?.IssuedElement;
                DateTimeOffset? av_ = au_?.Value;
                CqlDateTime aw_ = context.Operators.Convert<CqlDateTime>(av_);
                CqlInterval<CqlDateTime> ax_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                CqlQuantity az_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ba_ = context.Operators.Subtract(ay_, az_);
                CqlDateTime bb_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ba_, bb_, true, true);
                bool? bd_ = context.Operators.In<CqlDateTime>(aw_, bc_, (string)default);

                bool? be_() {
                    Code<ObservationStatus> bg_ = WBC?.StatusElement;
                    ObservationStatus? bh_ = bg_?.Value;
                    string bi_ = context.Operators.Convert<string>(bh_);
                    string[] bj_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bk_ = context.Operators.In<string>(bi_, (IEnumerable<string>)bj_);
                    return (bool?)((CqlBoolean)bk_);
                }


                bool? bf_() {
                    DataType bl_ = WBC?.Value;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bool?)((CqlBoolean)(!((bool?)(bm_ is null))));
                }

                return (bool?)(/* CQL 'and' (441:9-443:35) */ (/* CQL 'and' (441:15-442:63) */ ((CqlBoolean)bd_
                    && (CqlBoolean)be_())
                    && (CqlBoolean)bf_()));
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bn_ = @this?.IssuedElement;
                DateTimeOffset? bo_ = bn_?.Value;
                CqlDateTime bp_ = context.Operators.Convert<CqlDateTime>(bo_);
                CqlDateTime bq_ = QICoreCommon_4_0_000.Instance.earliest(context, bp_);
                return bq_;
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

                bool? ag_() {
                    Code<ObservationStatus> ah_ = HeartRate?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return (bool?)((CqlBoolean)al_);
                }

                return (bool?)(/* CQL 'and' (463:9-464:69) */ ((CqlBoolean)af_
                    && (CqlBoolean)ag_()));
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType am_ = @this?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                return ao_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            DataType l_ = k_?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation HeartRate) {
                DataType ap_ = HeartRate?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                CqlInterval<CqlDateTime> as_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlQuantity au_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime av_ = context.Operators.Subtract(at_, au_);
                CqlDateTime aw_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(av_, aw_, true, true);
                bool? ay_ = context.Operators.In<CqlDateTime>(ar_, ax_, (string)default);

                bool? az_() {
                    Code<ObservationStatus> ba_ = HeartRate?.StatusElement;
                    ObservationStatus? bb_ = ba_?.Value;
                    string bc_ = context.Operators.Convert<string>(bb_);
                    string[] bd_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? be_ = context.Operators.In<string>(bc_, (IEnumerable<string>)bd_);
                    return (bool?)((CqlBoolean)be_);
                }

                return (bool?)(/* CQL 'and' (463:9-464:69) */ ((CqlBoolean)ay_
                    && (CqlBoolean)az_()));
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(f_, n_);

            object p_(Observation @this) {
                DataType bf_ = @this?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
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

                bool? ak_() {
                    Code<ObservationStatus> am_ = BP?.StatusElement;
                    ObservationStatus? an_ = am_?.Value;
                    string ao_ = context.Operators.Convert<string>(an_);
                    string[] ap_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);
                    return (bool?)((CqlBoolean)aq_);
                }


                bool? al_() {
                    List<Observation.ComponentComponent> ar_ = BP?.Component;

                    bool? as_(Observation.ComponentComponent @this) {
                        DataType av_ = @this?.Value;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        return !((bool?)(aw_ is null));
                    }


                    object at_(Observation.ComponentComponent @this) {
                        DataType ax_ = @this?.Value;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        return ay_;
                    }

                    IEnumerable<object> au_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)ar_, as_, at_);
                    return (bool?)((CqlBoolean)(!((bool?)(au_ is null))));
                }

                return (bool?)(/* CQL 'and' (484:9-486:44) */ (/* CQL 'and' (484:15-485:62) */ ((CqlBoolean)aj_
                    && (CqlBoolean)ak_())
                    && (CqlBoolean)al_()));
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept bc_ = C?.Code;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                CqlCode be_ = this.Systolic_blood_pressure(context);
                CqlConcept bf_ = context.Operators.ConvertCodeToConcept(be_);
                bool? bg_ = context.Operators.Equivalent(bd_, bf_);
                return bg_;
            }


            CqlQuantity n_(Observation.ComponentComponent C) {
                DataType bh_ = C?.Value;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                return bi_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> o_ = context.Operators.WhereSelect<Observation.ComponentComponent, CqlQuantity>((IEnumerable<Observation.ComponentComponent>)l_, m_, n_);
            IEnumerable<CqlQuantity> p_ = context.Operators.Distinct<CqlQuantity>(o_);
            CqlQuantity q_ = context.Operators.SingletonFrom<CqlQuantity>(p_);

            bool? r_(Observation BP) {
                DataType bj_ = BP?.Effective;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_);
                CqlInterval<CqlDateTime> bm_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                CqlQuantity bo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bp_ = context.Operators.Subtract(bn_, bo_);
                CqlDateTime bq_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bp_, bq_, true, true);
                bool? bs_ = context.Operators.In<CqlDateTime>(bl_, br_, (string)default);

                bool? bt_() {
                    Code<ObservationStatus> bv_ = BP?.StatusElement;
                    ObservationStatus? bw_ = bv_?.Value;
                    string bx_ = context.Operators.Convert<string>(bw_);
                    string[] by_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bz_ = context.Operators.In<string>(bx_, (IEnumerable<string>)by_);
                    return (bool?)((CqlBoolean)bz_);
                }


                bool? bu_() {
                    List<Observation.ComponentComponent> ca_ = BP?.Component;

                    bool? cb_(Observation.ComponentComponent @this) {
                        DataType ce_ = @this?.Value;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        return !((bool?)(cf_ is null));
                    }


                    object cc_(Observation.ComponentComponent @this) {
                        DataType cg_ = @this?.Value;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        return ch_;
                    }

                    IEnumerable<object> cd_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)ca_, cb_, cc_);
                    return (bool?)((CqlBoolean)(!((bool?)(cd_ is null))));
                }

                return (bool?)(/* CQL 'and' (484:9-486:44) */ (/* CQL 'and' (484:15-485:62) */ ((CqlBoolean)bs_
                    && (CqlBoolean)bt_())
                    && (CqlBoolean)bu_()));
            }

            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(f_, r_);

            object t_(Observation @this) {
                DataType ci_ = @this?.Effective;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                CqlDateTime ck_ = QICoreCommon_4_0_000.Instance.earliest(context, cj_);
                return ck_;
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
