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

    [CqlValueSetDefinition("COVID 19 Confirmed", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373", valueSetVersion: null)]
    public CqlValueSet COVID_19_Confirmed(CqlContext _) => _COVID_19_Confirmed;
    private static readonly CqlValueSet _COVID_19_Confirmed = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373", null);

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

    [CqlValueSetDefinition("Respiratory Conditions Related to COVID 19", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376", valueSetVersion: null)]
    public CqlValueSet Respiratory_Conditions_Related_to_COVID_19(CqlContext _) => _Respiratory_Conditions_Related_to_COVID_19;
    private static readonly CqlValueSet _Respiratory_Conditions_Related_to_COVID_19 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376", null);

    [CqlValueSetDefinition("Respiratory Support Procedures Related to COVID 19", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379", valueSetVersion: null)]
    public CqlValueSet Respiratory_Support_Procedures_Related_to_COVID_19(CqlContext _) => _Respiratory_Support_Procedures_Related_to_COVID_19;
    private static readonly CqlValueSet _Respiratory_Support_Procedures_Related_to_COVID_19 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379", null);

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
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
        object rzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.ResolveParameter("SevereObstetricComplicationsFHIR-0.1.000", "Measurement Period", rzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Calculated Gestational Age Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzza_(Encounter DeliveryEncounter)
        {
            int? szzzzzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzzzzzzzzzzc_, 20);

            return szzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzza_);

        return szzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Estimated Gestational Age Assessment Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter DeliveryEncounter)
        {
            int? szzzzzzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(20m, "weeks");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzh_ is null), szzzzzzzzzzzzzzzzzzzzzzzzk_);

            return szzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzf_);

        return szzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Gestational Age Greater than or Equal to 20 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzm_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter DeliveryEncounter)
        {
            int? szzzzzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzp_ is null), (bool?)(szzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzt_(Condition EncounterDiagnosis)
            {
                CodeableConcept szzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterDiagnosis?.Code;
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzz_ = this._20_to_42_Plus_Weeks_Gestation(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzzz_);

                return tzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzv_);

            return szzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzn_);

        return szzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Delivery Encounters At Greater than or Equal to 20 Weeks Gestation")]
    public IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzze_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("pOAIsNoOrUTD")]
    public IEnumerable<CqlConcept> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> tzzzzzzzzzzzzzzzzzzzzzzzzg_ = TheEncounter?.Diagnosis;
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzm_(Extension @this)
            {
                string tzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Url;
                FhirString tzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string tzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return tzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Extension> tzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), tzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzo_(Extension @this)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Value;

                return tzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<object> tzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Extension, object>(tzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<object>(tzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzzzzzzq_ as CodeableConcept);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter.DiagnosisComponent> tzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)tzzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference tzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterDiagnoses?.Condition;
            Condition uzzzzzzzzzzzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.getCondition(context, tzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzb_ = uzzzzzzzzzzzzzzzzzzzzzzzza_?.Code;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlConcept> tzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(tzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlConcept> tzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlConcept>(tzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Diagnosis or Procedure Excluding Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsNoOrUTD(context, TwentyWeeksPlusEncounter);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzl_(Procedure SMMProcedures)
            {
                Code<EventStatus> uzzzzzzzzzzzzzzzzzzzzzzzzp_ = SMMProcedures?.StatusElement;
                EventStatus? uzzzzzzzzzzzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzr_, "completed");
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzt_ = SMMProcedures?.Performed;
                object uzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzze_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Expiration")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Expiration(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter TwentyWeeksPlusEncounter)
        {
            Encounter.HospitalizationComponent vzzzzzzzzzzzzzzzzzzzzzzzzd_ = TwentyWeeksPlusEncounter?.Hospitalization;
            CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzze_ = vzzzzzzzzzzzzzzzzzzzzzzzzd_?.DischargeDisposition;
            CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient_Expired(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure BloodTransfusion)
            {
                Code<EventStatus> vzzzzzzzzzzzzzzzzzzzzzzzzr_ = BloodTransfusion?.StatusElement;
                EventStatus? vzzzzzzzzzzzzzzzzzzzzzzzzs_ = vzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzt_, "completed");
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzv_ = BloodTransfusion?.Performed;
                object vzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzza_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter vzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure BloodTransfusion) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Hysterectomy")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Hysterectomy(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Hysterectomy(context);
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzm_(Procedure Hysterectomy)
            {
                Code<EventStatus> wzzzzzzzzzzzzzzzzzzzzzzzzq_ = Hysterectomy?.StatusElement;
                EventStatus? wzzzzzzzzzzzzzzzzzzzzzzzzr_ = wzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzs_, "completed");
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzu_ = Hysterectomy?.Performed;
                object wzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzy_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
                bool? xzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return xzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure Hysterectomy) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Procedure, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Procedure> Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Conversion_of_Cardiac_Rhythm(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Tracheostomy(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Ventilation(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure ConvTrachVentProcedures)
            {
                Code<EventStatus> xzzzzzzzzzzzzzzzzzzzzzzzzr_ = ConvTrachVentProcedures?.StatusElement;
                EventStatus? xzzzzzzzzzzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzt_, "completed");
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzv_ = ConvTrachVentProcedures?.Performed;
                object xzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzza_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter xzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure ConvTrachVentProcedures) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SOC with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter SOCEncounter)
        {
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCEncounter);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition EncounterDiagnosis)
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterDiagnosis?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Placenta_Increta_or_Percreta(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return zzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter SOCEncounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsNoOrUTD(context, SOCEncounter);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Except<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Diagnosis")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Except<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter Encounter)
        {
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.pOAIsNoOrUTD(context, Encounter);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Procedures")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Except<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter Encounter)
        {
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure SMMProcedures)
            {
                Code<EventStatus> zzzzzzzzzzzzzzzzzzzzzzzzzz_ = SMMProcedures?.StatusElement;
                EventStatus? azzzzzzzzzzzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string azzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzb_, "completed");
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzd_ = SMMProcedures?.Performed;
                object azzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("sOCDxCategory")]
    public string sOCDxCategory(CqlContext context, CqlConcept Dx)
    {
        string azzzzzzzzzzzzzzzzzzzzzzzzzk_()
        {
            bool azzzzzzzzzzzzzzzzzzzzzzzzzl_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Acute_Heart_Failure(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzd_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzm_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Acute_Myocardial_Infarction(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzn_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Acute_Renal_Failure(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzo_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Acute_Respiratory_Distress_Syndrome(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzp_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Air_and_Thrombotic_Embolism(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzq_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Amniotic_Fluid_Embolism(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Aortic_Aneurysm(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Cardiac_Arrest_Ventricular_Fibrillation(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzr_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Disseminated_Intravascular_Coagulation(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzt_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Eclampsia(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzv_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzx_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Puerperal_Cerebrovascular_Disorder(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(Dx, bzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzz_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzx_()
            {
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Pulmonary_Edema(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(Dx, czzzzzzzzzzzzzzzzzzzzzzzzza_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzb_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Sepsis(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(Dx, czzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzd_ ?? false;
            };
            bool azzzzzzzzzzzzzzzzzzzzzzzzzz_()
            {
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Severe_Anesthesia_Complications(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(Dx, czzzzzzzzzzzzzzzzzzzzzzzzze_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            bool bzzzzzzzzzzzzzzzzzzzzzzzzza_()
            {
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Shock(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(Dx, czzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            bool bzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Sickle_Cell_Disease_with_Crisis(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(Dx, czzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            if (azzzzzzzzzzzzzzzzzzzzzzzzzl_())
            {
                return "Acute Heart Failure";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzm_())
            {
                return "Acute Myocardial Infarction";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzn_())
            {
                return "Acute Renal Failure";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzo_())
            {
                return "Acute Respiratory Distress Syndrome";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzp_())
            {
                return "Air and Thrombotic Embolism";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzq_())
            {
                return "Amniotic Fluid Embolism";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzr_())
            {
                return "Aortic Aneurysm";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzs_())
            {
                return "Cardiac Arrest Ventricular Fibrillation";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzt_())
            {
                return "Disseminated Intravascular Coagulation";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzu_())
            {
                return "Eclampsia";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzv_())
            {
                return "Heart Failure Cardiac Arrest Related to Procedure or Surgery";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzw_())
            {
                return "Puerperal Cerebrovascular Disorder";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzx_())
            {
                return "Pulmonary Edema";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzy_())
            {
                return "Sepsis";
            }
            else if (azzzzzzzzzzzzzzzzzzzzzzzzzz_())
            {
                return "Severe Anesthesia Complications";
            }
            else if (bzzzzzzzzzzzzzzzzzzzzzzzzza_())
            {
                return "Shock";
            }
            else if (bzzzzzzzzzzzzzzzzzzzzzzzzzb_())
            {
                return "Sickle Cell Disease with Crisis";
            }
            else
            {
                return default;
            }
        };

        return azzzzzzzzzzzzzzzzzzzzzzzzzk_();
    }


    [CqlExpressionDefinition("SDE SOC Diagnoses Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? czzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter Encounter)
        {
            Id czzzzzzzzzzzzzzzzzzzzzzzzzo_ = Encounter?.IdElement;
            string czzzzzzzzzzzzzzzzzzzzzzzzzp_ = czzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsNoOrUTD(context, Encounter);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzr_(CqlConcept C)
            {
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(C, czzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? czzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlConcept C)
            {
                string czzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.sOCDxCategory(context, C);
                (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? dzzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_FRbAiSWEhRfKaLTXPVgFXYZAE, C, czzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> czzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CqlConcept, (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(czzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> czzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(czzzzzzzzzzzzzzzzzzzzzzzzzu_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? czzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_RBQLXdQIRBbBEHDfOgQjdBMH, czzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> czzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(czzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> czzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(czzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("sOCProcedures")]
    public IEnumerable<Procedure> sOCProcedures(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Severe_Maternal_Morbidity_Procedures(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Blood_Transfusion(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure SMMProcedures)
        {
            Code<EventStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SMMProcedures?.StatusElement;
            EventStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string dzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzzzzk_, "completed");
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SMMProcedures?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("sOCProcedureCategory")]
    public string sOCProcedureCategory(CqlContext context, Procedure TheProcedure)
    {
        string dzzzzzzzzzzzzzzzzzzzzzzzzzt_()
        {
            bool dzzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                CodeableConcept dzzzzzzzzzzzzzzzzzzzzzzzzzz_ = TheProcedure?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Blood_Transfusion(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            bool dzzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzd_ = TheProcedure?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Conversion_of_Cardiac_Rhythm(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzg_ ?? false;
            };
            bool dzzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzh_ = TheProcedure?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Hysterectomy(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool dzzzzzzzzzzzzzzzzzzzzzzzzzx_()
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzl_ = TheProcedure?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Tracheostomy(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            bool dzzzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzp_ = TheProcedure?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Ventilation(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzs_ ?? false;
            };
            if (dzzzzzzzzzzzzzzzzzzzzzzzzzu_())
            {
                return "Blood Transfusion";
            }
            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzv_())
            {
                return "Conversion of cardiac rhythm";
            }
            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzw_())
            {
                return "Hysterectomy";
            }
            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzx_())
            {
                return "Tracheostomy";
            }
            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzy_())
            {
                return "Ventilation";
            }
            else
            {
                return default;
            }
        };

        return dzzzzzzzzzzzzzzzzzzzzzzzzzt_();
    }


    [CqlExpressionDefinition("SDE SOC Procedure Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? ezzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter Encounter)
        {
            Id ezzzzzzzzzzzzzzzzzzzzzzzzzx_ = Encounter?.IdElement;
            string ezzzzzzzzzzzzzzzzzzzzzzzzzy_ = ezzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.sOCProcedures(context, Encounter);
            (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? fzzzzzzzzzzzzzzzzzzzzzzzzza_(Procedure P)
            {
                string fzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.sOCProcedureCategory(context, P);
                (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? fzzzzzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR, P, fzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> fzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Procedure, (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> fzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? fzzzzzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_DbihhAfJfGSKOIcQDBMEMigFK, ezzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> ezzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> ezzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Delivery Encounters with COVID and Respiratory Condition or Procedure")]
    public IEnumerable<Encounter> Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, TwentyWeeksPlusEncounter);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition EncounterDiagnosis)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterDiagnosis?.Code;
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.COVID_19_Confirmed(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzp_(Condition EncounterDiagnosis)
            {
                CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterDiagnosis?.Code;
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Respiratory_Conditions_Related_to_COVID_19(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Respiratory_Support_Procedures_Related_to_COVID_19(context);
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure COVIDRespiratoryProcedure)
            {
                Code<EventStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzh_ = COVIDRespiratoryProcedure?.StatusElement;
                EventStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzi_ = gzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzj_, "completed");
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzl_ = COVIDRespiratoryProcedure?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Stratification Encounter")]
    public IEnumerable<Encounter> Stratification_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Numerator(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Denominator_Exclusion(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Except<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Stratum 1")]
    public IEnumerable<Encounter> Stratum_1(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Stratification_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Intersect<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> hzzzzzzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions Only")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Intersect<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SOC Excluding Blood Transfusions Only with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_Excluding_Blood_Transfusions_Only_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition EncounterDiagnoses)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterDiagnoses?.Code;
                CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Placenta_Increta_or_Percreta(context);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzze_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzza_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsNoOrUTD(context, SOCExcludingTransfusion);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Except<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("pOAIsYesOrExempt")]
    public IEnumerable<CqlConcept> pOAIsYesOrExempt(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzzzzzzzzzzj_ = TheEncounter?.Diagnosis;
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzp_(Extension @this)
            {
                string izzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Url;
                FhirString izzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzzzzzzzzzzzzzx_);
                string izzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return jzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Extension> izzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), izzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzr_(Extension @this)
            {
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Value;

                return jzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzzzr_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzt_ as CodeableConcept);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter.DiagnosisComponent> izzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference jzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterDiagnoses?.Condition;
            Condition jzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.getCondition(context, jzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Code;
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(izzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlConcept>(izzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Anemia")]
    public IEnumerable<Encounter> Risk_Variable_Anemia(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Anemia(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Asthma")]
    public IEnumerable<Encounter> Risk_Variable_Asthma(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Acute_or_Persistent_Asthma(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Autoimmune Disease")]
    public IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Autoimmune_Disease(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Bariatric Surgery")]
    public IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Bariatric_Surgery(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Bleeding Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Bleeding_Disorder(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Morbid Obesity")]
    public IEnumerable<Encounter> Risk_Variable_Morbid_Obesity(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Morbid_or_Severe_Obesity(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Risk Variable Cardiac Disease")]
    public IEnumerable<Encounter> Risk_Variable_Cardiac_Disease(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Cardiac_Disease(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Risk Variable Economic Housing Instability")]
    public IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Economic_Housing_Instability(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Risk Variable Gastrointestinal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Gastrointestinal_Disease(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Risk Variable Gestational Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Gestational_Diabetes(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable HIV")]
    public IEnumerable<Encounter> Risk_Variable_HIV(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Hypertension(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable Long Term Anticoagulant Use")]
    public IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Long_Term_Anticoagulant_Use(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptsInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Maternal Age")]
    public IEnumerable<IEnumerable<object>> Risk_Variable_Maternal_Age(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            Patient mzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patient(context);
            Date mzzzzzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzzzzzk_?.BirthDateElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzm_ = mzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Period mzzzzzzzzzzzzzzzzzzzzzzzzzo_ = TwentyWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            int? mzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzr_, "year");
            object[] mzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                TwentyWeeksPlusEncounter,
mzzzzzzzzzzzzzzzzzzzzzzzzzs_ ?? default(int),
            ];

            return mzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<object>;
        };
        IEnumerable<IEnumerable<object>> mzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, IEnumerable<object>>(mzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<IEnumerable<object>> mzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<IEnumerable<object>>(mzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Mental Health Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Mental_Health_Disorder(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable Multiple Pregnancy")]
    public IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Multiple_Pregnancy(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Neuromuscular")]
    public IEnumerable<Encounter> Risk_Variable_Neuromuscular(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Neuromuscular_Disease(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Obstetrical VTE")]
    public IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Venous_Thromboembolism_in_Pregnancy(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Placenta Previa")]
    public IEnumerable<Encounter> Risk_Variable_Placenta_Previa(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Placenta_Previa(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Abruption")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Abruption(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Placental_Abruption(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Accreta Spectrum")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Placenta_Accreta(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Placenta_Increta_or_Percreta(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Preexisting Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Preexisting_Diabetes(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable Previous Cesarean")]
    public IEnumerable<Encounter> Risk_Variable_Previous_Cesarean(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Previous_Cesarean(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable Pulmonary Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Pulmonary_Hypertension(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptsInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Renal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Renal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Renal_Disease(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Risk Variable Severe Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Severe_Preeclampsia(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Substance Abuse")]
    public IEnumerable<Encounter> Risk_Variable_Substance_Abuse(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Substance_Abuse(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Thyrotoxicosis")]
    public IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Thyrotoxicosis(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Other Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Mild_or_Moderate_Preeclampsia(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Preterm Birth")]
    public IEnumerable<Encounter> Risk_Variable_Preterm_Birth(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter DeliveryEncounter)
        {
            int? qzzzzzzzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlInterval<int?> qzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(20, 36, true, true);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<int?>(qzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(20m, "weeks");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(36m, "weeks");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.LessOrEqual(qzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null), rzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter DeliveryEncounter)
        {
            int? rzzzzzzzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And((bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzze_ is null), (bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.pOAIsYesOrExempt(context, DeliveryEncounter);
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Preterm_Birth(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? rzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter TwentyWeeksPlusEncounter)
        {
            Id rzzzzzzzzzzzzzzzzzzzzzzzzzp_ = TwentyWeeksPlusEncounter?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation Hematocrit)
            {
                Instant szzzzzzzzzzzzzzzzzzzzzzzzzl_ = Hematocrit?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzs_, true, false);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzv_ = Hematocrit?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] szzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Hematocrit?.Value;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object rzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                Instant tzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.IssuedElement;
                DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation Hematocrit)
            {
                Instant tzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Hematocrit?.IssuedElement;
                DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzm_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, false);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Hematocrit?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string tzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] tzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Hematocrit?.Value;
                object uzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzc_);
            object szzzzzzzzzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                Instant uzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;
                DateTimeOffset? uzzzzzzzzzzzzzzzzzzzzzzzzze_ = uzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Instant szzzzzzzzzzzzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzzzzzzzzzzzg_?.IssuedElement;
            DateTimeOffset? szzzzzzzzzzzzzzzzzzzzzzzzzi_ = szzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzi_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? szzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, rzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> rzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> rzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? uzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            Id uzzzzzzzzzzzzzzzzzzzzzzzzzl_ = TwentyWeeksPlusEncounter?.IdElement;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation WBC)
            {
                Instant vzzzzzzzzzzzzzzzzzzzzzzzzzh_ = WBC?.IssuedElement;
                DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzo_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, false);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzr_ = WBC?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzs_ = vzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] vzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzx_ = WBC?.Value;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object uzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);

                return wzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzu_ = uzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation WBC)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzzzzf_ = WBC?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzzzzg_ = wzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzm_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, false);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzp_ = WBC?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string[] wzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzv_ = WBC?.Value;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Instant vzzzzzzzzzzzzzzzzzzzzzzzzzd_ = vzzzzzzzzzzzzzzzzzzzzzzzzzc_?.IssuedElement;
            DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzzzze_ = vzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzze_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA, uzzzzzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            Id xzzzzzzzzzzzzzzzzzzzzzzzzzh_ = TwentyWeeksPlusEncounter?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation HeartRate)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzb_ = HeartRate?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, false);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzl_ = HeartRate?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzp_ = xzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzzzzzzzzzzp_ as Quantity);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation HeartRate)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzu_ = HeartRate?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzb_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, false);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzze_ = HeartRate?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzf_ = zzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV, xzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            Id zzzzzzzzzzzzzzzzzzzzzzzzzzr_ = TwentyWeeksPlusEncounter?.IdElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzs_ = zzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation BP)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BP?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, false);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BP?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzza_ = azzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                List<Observation.ComponentComponent> bzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = BP?.Component;
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation.ComponentComponent @this)
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Value;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Observation.ComponentComponent> bzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation.ComponentComponent @this)
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Value;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Observation.ComponentComponent, object>(bzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            List<Observation.ComponentComponent> zzzzzzzzzzzzzzzzzzzzzzzzzzz_ = zzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Component;
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation.ComponentComponent C)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = C?.Code;
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Systolic_blood_pressure(context);
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation.ComponentComponent> azzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)zzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation.ComponentComponent C)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = C?.Value;
                object czzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> azzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(azzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<CqlQuantity> azzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlQuantity>(azzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation BP)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzb_ = BP?.Effective;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzi_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, false);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BP?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzm_ = czzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string czzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] czzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                List<Observation.ComponentComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzr_ = BP?.Component;
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation.ComponentComponent @this)
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Value;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                IEnumerable<Observation.ComponentComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)czzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                object czzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation.ComponentComponent @this)
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Value;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<object> czzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Observation.ComponentComponent, object>(czzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object azzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzl_ = azzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Effective;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, zzzzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> zzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> zzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzq_;
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
