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
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Heart_rate,
          _Systolic_blood_pressure]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime lzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzu_, true, true);
        object lzzzzzzzzzzzzzzzzzzzw_ = context.ResolveParameter("SevereObstetricComplicationsFHIR-0.1.000", "Measurement Period", lzzzzzzzzzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzzzzzzzx_);

        return lzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzz_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);

        return lzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Calculated Gestational Age Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? mzzzzzzzzzzzzzzzzzzzf_(Encounter DeliveryEncounter)
        {
            int? mzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? mzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzzzzh_, 20);

            return mzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzf_);

        return mzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Estimated Gestational Age Assessment Greater than or Equal to 20 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzj_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? mzzzzzzzzzzzzzzzzzzzk_(Encounter DeliveryEncounter)
        {
            int? mzzzzzzzzzzzzzzzzzzzm_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(20m, "weeks");
            bool? mzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzo_);
            bool? mzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And((bool?)(mzzzzzzzzzzzzzzzzzzzm_ is null), mzzzzzzzzzzzzzzzzzzzp_);

            return mzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Gestational Age Greater than or Equal to 20 Weeks Based on Coding")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? mzzzzzzzzzzzzzzzzzzzs_(Encounter DeliveryEncounter)
        {
            int? mzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? mzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And((bool?)(mzzzzzzzzzzzzzzzzzzzu_ is null), (bool?)(mzzzzzzzzzzzzzzzzzzzv_ is null));
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? mzzzzzzzzzzzzzzzzzzzy_(Condition EncounterDiagnosis)
            {
                CodeableConcept nzzzzzzzzzzzzzzzzzzzc_ = EncounterDiagnosis?.Code;
                CqlConcept nzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet nzzzzzzzzzzzzzzzzzzze_ = this._20_to_42_Plus_Weeks_Gestation(context);
                bool? nzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzze_);

                return nzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzy_);
            bool? nzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzz_);
            bool? nzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzza_);

            return nzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzs_);

        return mzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Delivery Encounters At Greater than or Equal to 20 Weeks Gestation")]
    public IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzg_ = this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzj_);

        return nzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("pOAIsNoOrUTD")]
    public IEnumerable<CqlConcept> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> nzzzzzzzzzzzzzzzzzzzl_ = TheEncounter?.Diagnosis;
        bool? nzzzzzzzzzzzzzzzzzzzm_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? nzzzzzzzzzzzzzzzzzzzr_(Extension @this)
            {
                string nzzzzzzzzzzzzzzzzzzzz_ = @this?.Url;
                FhirString ozzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzzzzzzzzzz_);
                string ozzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzzzza_);
                bool? ozzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return ozzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Extension> nzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), nzzzzzzzzzzzzzzzzzzzr_);
            object nzzzzzzzzzzzzzzzzzzzt_(Extension @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzd_ = @this?.Value;

                return ozzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<object> nzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzt_);
            object nzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzzzzzzzzzu_);
            CqlConcept nzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzv_ as CodeableConcept);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzx_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
            bool? nzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzx_);

            return nzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter.DiagnosisComponent> nzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)nzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzm_);
        CqlConcept nzzzzzzzzzzzzzzzzzzzo_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference ozzzzzzzzzzzzzzzzzzze_ = EncounterDiagnoses?.Condition;
            Condition ozzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.getCondition(context, ozzzzzzzzzzzzzzzzzzze_);
            CodeableConcept ozzzzzzzzzzzzzzzzzzzg_ = ozzzzzzzzzzzzzzzzzzzf_?.Code;
            CqlConcept ozzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzg_);

            return ozzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(nzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlConcept> nzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlConcept>(nzzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Diagnosis or Procedure Excluding Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ozzzzzzzzzzzzzzzzzzzj_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzl_ = this.pOAIsNoOrUTD(context, TwentyWeeksPlusEncounter);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzm_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? ozzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzo_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? ozzzzzzzzzzzzzzzzzzzq_(Procedure SMMProcedures)
            {
                Code<EventStatus> ozzzzzzzzzzzzzzzzzzzu_ = SMMProcedures?.StatusElement;
                EventStatus? ozzzzzzzzzzzzzzzzzzzv_ = ozzzzzzzzzzzzzzzzzzzu_?.Value;
                string ozzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzv_);
                bool? ozzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzw_, "completed");
                DataType ozzzzzzzzzzzzzzzzzzzy_ = SMMProcedures?.Performed;
                object ozzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? pzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzc_, "day");
                bool? pzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzd_);

                return pzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzq_);
            bool? ozzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzzzzzzr_);
            bool? ozzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzs_);

            return ozzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Expiration")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Expiration(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? pzzzzzzzzzzzzzzzzzzzg_(Encounter TwentyWeeksPlusEncounter)
        {
            Encounter.HospitalizationComponent pzzzzzzzzzzzzzzzzzzzi_ = TwentyWeeksPlusEncounter?.Hospitalization;
            CodeableConcept pzzzzzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzzzzzi_?.DischargeDisposition;
            CqlConcept pzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzl_ = this.Patient_Expired(context);
            bool? pzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzl_);

            return pzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzg_);

        return pzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Blood Transfusion")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet pzzzzzzzzzzzzzzzzzzzq_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? pzzzzzzzzzzzzzzzzzzzs_(Procedure BloodTransfusion)
            {
                Code<EventStatus> pzzzzzzzzzzzzzzzzzzzw_ = BloodTransfusion?.StatusElement;
                EventStatus? pzzzzzzzzzzzzzzzzzzzx_ = pzzzzzzzzzzzzzzzzzzzw_?.Value;
                string pzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzx_);
                bool? pzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzy_, "completed");
                DataType qzzzzzzzzzzzzzzzzzzza_ = BloodTransfusion?.Performed;
                object qzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? qzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzze_, "day");
                bool? qzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzf_);

                return qzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzs_);
            Encounter pzzzzzzzzzzzzzzzzzzzu_(Procedure BloodTransfusion) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, Encounter>(pzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzu_);

            return pzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzo_);

        return pzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Hysterectomy")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Hysterectomy(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzzp_ = this.Hysterectomy(context);
            IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? qzzzzzzzzzzzzzzzzzzzr_(Procedure Hysterectomy)
            {
                Code<EventStatus> qzzzzzzzzzzzzzzzzzzzv_ = Hysterectomy?.StatusElement;
                EventStatus? qzzzzzzzzzzzzzzzzzzzw_ = qzzzzzzzzzzzzzzzzzzzv_?.Value;
                string qzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzw_);
                bool? qzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzx_, "completed");
                DataType qzzzzzzzzzzzzzzzzzzzz_ = Hysterectomy?.Performed;
                object rzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzd_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? rzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzd_, "day");
                bool? rzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzze_);

                return rzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzr_);
            Encounter qzzzzzzzzzzzzzzzzzzzt_(Procedure Hysterectomy) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Procedure, Encounter>(qzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzt_);

            return qzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Procedure> Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzg_ = this.Conversion_of_Cardiac_Rhythm(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzi_ = this.Tracheostomy(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Procedure>(rzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzl_ = this.Ventilation(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Procedure>(rzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzm_);

        return rzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Cardiac Conversion, Tracheostomy or Ventilation Procedures")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzo_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzp_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzr_ = this.Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
            bool? rzzzzzzzzzzzzzzzzzzzs_(Procedure ConvTrachVentProcedures)
            {
                Code<EventStatus> rzzzzzzzzzzzzzzzzzzzw_ = ConvTrachVentProcedures?.StatusElement;
                EventStatus? rzzzzzzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzzzzzzw_?.Value;
                string rzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzx_);
                bool? rzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzy_, "completed");
                DataType szzzzzzzzzzzzzzzzzzza_ = ConvTrachVentProcedures?.Performed;
                object szzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzze_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? szzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzze_, "day");
                bool? szzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzf_);

                return szzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzs_);
            Encounter rzzzzzzzzzzzzzzzzzzzu_(Procedure ConvTrachVentProcedures) =>
                TwentyWeeksPlusEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, Encounter>(rzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzu_);

            return rzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzp_);

        return rzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SOC with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        bool? szzzzzzzzzzzzzzzzzzzi_(Encounter SOCEncounter)
        {
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCEncounter);
            bool? szzzzzzzzzzzzzzzzzzzt_(Condition EncounterDiagnosis)
            {
                CodeableConcept tzzzzzzzzzzzzzzzzzzzc_ = EncounterDiagnosis?.Code;
                CqlConcept tzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet tzzzzzzzzzzzzzzzzzzze_ = this.Placenta_Increta_or_Percreta(context);
                bool? tzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzze_);

                return tzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzt_);
            bool? szzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzw_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? szzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzy_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? szzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzzzzy_);
            bool? tzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzza_);

            return tzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzzl_(Encounter SOCEncounter)
        {
            IEnumerable<CqlConcept> tzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsNoOrUTD(context, SOCEncounter);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzh_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? tzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(tzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzh_);

            return tzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzr_ = context.Operators.Except<Encounter>(szzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzq_);

        return szzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Diagnosis")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzk_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Except<Encounter>(tzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzk_);
        bool? tzzzzzzzzzzzzzzzzzzzm_(Encounter Encounter)
        {
            IEnumerable<CqlConcept> tzzzzzzzzzzzzzzzzzzzo_ = this.pOAIsNoOrUTD(context, Encounter);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzp_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? tzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(tzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzp_);

            return tzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzm_);

        return tzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Delivery Encounters with Severe Obstetric Complication Procedures")]
    public IEnumerable<Encounter> SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzs_ = this.SOC_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Except<Encounter>(tzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzzzzzzzu_(Encounter Encounter)
        {
            CqlValueSet tzzzzzzzzzzzzzzzzzzzw_ = this.Severe_Maternal_Morbidity_Procedures(context);
            IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet tzzzzzzzzzzzzzzzzzzzy_ = this.Blood_Transfusion(context);
            IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Procedure>(tzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzzzzzzzzzb_(Procedure SMMProcedures)
            {
                Code<EventStatus> uzzzzzzzzzzzzzzzzzzze_ = SMMProcedures?.StatusElement;
                EventStatus? uzzzzzzzzzzzzzzzzzzzf_ = uzzzzzzzzzzzzzzzzzzze_?.Value;
                string uzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzf_);
                bool? uzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzg_, "completed");
                DataType uzzzzzzzzzzzzzzzzzzzi_ = SMMProcedures?.Performed;
                object uzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzm_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, Encounter);
                bool? uzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzm_, "day");
                bool? uzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzn_);

                return uzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Procedure>(uzzzzzzzzzzzzzzzzzzzc_);

            return uzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("sOCDxCategory")]
    public string sOCDxCategory(CqlContext context, CqlConcept Dx)
    {
        string uzzzzzzzzzzzzzzzzzzzp_()
        {
            bool uzzzzzzzzzzzzzzzzzzzq_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzh_ = this.Acute_Heart_Failure(context);
                bool? vzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzh_);

                return vzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzr_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzj_ = this.Acute_Myocardial_Infarction(context);
                bool? vzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzj_);

                return vzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzs_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzl_ = this.Acute_Renal_Failure(context);
                bool? vzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzl_);

                return vzzzzzzzzzzzzzzzzzzzm_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzt_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzn_ = this.Acute_Respiratory_Distress_Syndrome(context);
                bool? vzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzn_);

                return vzzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzu_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzp_ = this.Air_and_Thrombotic_Embolism(context);
                bool? vzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzp_);

                return vzzzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzv_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzr_ = this.Amniotic_Fluid_Embolism(context);
                bool? vzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzr_);

                return vzzzzzzzzzzzzzzzzzzzs_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzw_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzt_ = this.Aortic_Aneurysm(context);
                bool? vzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzt_);

                return vzzzzzzzzzzzzzzzzzzzu_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzx_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzv_ = this.Cardiac_Arrest_Ventricular_Fibrillation(context);
                bool? vzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzv_);

                return vzzzzzzzzzzzzzzzzzzzw_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzy_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzx_ = this.Disseminated_Intravascular_Coagulation(context);
                bool? vzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzx_);

                return vzzzzzzzzzzzzzzzzzzzy_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzzz_()
            {
                CqlValueSet vzzzzzzzzzzzzzzzzzzzz_ = this.Eclampsia(context);
                bool? wzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(Dx, vzzzzzzzzzzzzzzzzzzzz_);

                return wzzzzzzzzzzzzzzzzzzza_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzza_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzzb_ = this.Heart_Failure_Cardiac_Arrest_Related_to_Procedure_or_Surgery(context);
                bool? wzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzzb_);

                return wzzzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzzb_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzzd_ = this.Puerperal_Cerebrovascular_Disorder(context);
                bool? wzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzzd_);

                return wzzzzzzzzzzzzzzzzzzze_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzzc_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzzf_ = this.Pulmonary_Edema(context);
                bool? wzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzzf_);

                return wzzzzzzzzzzzzzzzzzzzg_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzzd_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzzh_ = this.Sepsis(context);
                bool? wzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzzh_);

                return wzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzze_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzzj_ = this.Severe_Anesthesia_Complications(context);
                bool? wzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzzj_);

                return wzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzzf_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzzl_ = this.Shock(context);
                bool? wzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzzl_);

                return wzzzzzzzzzzzzzzzzzzzm_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzzg_()
            {
                CqlValueSet wzzzzzzzzzzzzzzzzzzzn_ = this.Sickle_Cell_Disease_with_Crisis(context);
                bool? wzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(Dx, wzzzzzzzzzzzzzzzzzzzn_);

                return wzzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            if (uzzzzzzzzzzzzzzzzzzzq_())
            {
                return "Acute Heart Failure";
            }
            else if (uzzzzzzzzzzzzzzzzzzzr_())
            {
                return "Acute Myocardial Infarction";
            }
            else if (uzzzzzzzzzzzzzzzzzzzs_())
            {
                return "Acute Renal Failure";
            }
            else if (uzzzzzzzzzzzzzzzzzzzt_())
            {
                return "Acute Respiratory Distress Syndrome";
            }
            else if (uzzzzzzzzzzzzzzzzzzzu_())
            {
                return "Air and Thrombotic Embolism";
            }
            else if (uzzzzzzzzzzzzzzzzzzzv_())
            {
                return "Amniotic Fluid Embolism";
            }
            else if (uzzzzzzzzzzzzzzzzzzzw_())
            {
                return "Aortic Aneurysm";
            }
            else if (uzzzzzzzzzzzzzzzzzzzx_())
            {
                return "Cardiac Arrest Ventricular Fibrillation";
            }
            else if (uzzzzzzzzzzzzzzzzzzzy_())
            {
                return "Disseminated Intravascular Coagulation";
            }
            else if (uzzzzzzzzzzzzzzzzzzzz_())
            {
                return "Eclampsia";
            }
            else if (vzzzzzzzzzzzzzzzzzzza_())
            {
                return "Heart Failure Cardiac Arrest Related to Procedure or Surgery";
            }
            else if (vzzzzzzzzzzzzzzzzzzzb_())
            {
                return "Puerperal Cerebrovascular Disorder";
            }
            else if (vzzzzzzzzzzzzzzzzzzzc_())
            {
                return "Pulmonary Edema";
            }
            else if (vzzzzzzzzzzzzzzzzzzzd_())
            {
                return "Sepsis";
            }
            else if (vzzzzzzzzzzzzzzzzzzze_())
            {
                return "Severe Anesthesia Complications";
            }
            else if (vzzzzzzzzzzzzzzzzzzzf_())
            {
                return "Shock";
            }
            else if (vzzzzzzzzzzzzzzzzzzzg_())
            {
                return "Sickle Cell Disease with Crisis";
            }
            else
            {
                return default;
            }
        };

        return uzzzzzzzzzzzzzzzzzzzp_();
    }


    [CqlExpressionDefinition("SDE SOC Diagnoses Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> SDE_SOC_Diagnoses_Detail(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzp_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Diagnosis(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? wzzzzzzzzzzzzzzzzzzzq_(Encounter Encounter)
        {
            Id wzzzzzzzzzzzzzzzzzzzt_ = Encounter?.IdElement;
            string wzzzzzzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzzzzzzt_?.Value;
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzzzzzzv_ = this.pOAIsNoOrUTD(context, Encounter);
            bool? wzzzzzzzzzzzzzzzzzzzw_(CqlConcept C)
            {
                CqlValueSet xzzzzzzzzzzzzzzzzzzzc_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
                bool? xzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(C, xzzzzzzzzzzzzzzzzzzzc_);

                return xzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<CqlConcept>(wzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzw_);
            (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? wzzzzzzzzzzzzzzzzzzzy_(CqlConcept C)
            {
                string xzzzzzzzzzzzzzzzzzzze_ = this.sOCDxCategory(context, C);
                (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)? xzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_FRbAiSWEhRfKaLTXPVgFXYZAE, C, xzzzzzzzzzzzzzzzzzzze_);

                return xzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> wzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CqlConcept, (CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(wzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> xzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?>(wzzzzzzzzzzzzzzzzzzzz_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)? xzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_RBQLXdQIRBbBEHDfOgQjdBMH, wzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> wzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(wzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?> wzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, CqlConcept code, string SOCDxCategory)?> complications)?>(wzzzzzzzzzzzzzzzzzzzr_);

        return wzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("sOCProcedures")]
    public IEnumerable<Procedure> sOCProcedures(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzg_ = this.Severe_Maternal_Morbidity_Procedures(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzi_ = this.Blood_Transfusion(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Procedure>(xzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzj_);
        bool? xzzzzzzzzzzzzzzzzzzzl_(Procedure SMMProcedures)
        {
            Code<EventStatus> xzzzzzzzzzzzzzzzzzzzn_ = SMMProcedures?.StatusElement;
            EventStatus? xzzzzzzzzzzzzzzzzzzzo_ = xzzzzzzzzzzzzzzzzzzzn_?.Value;
            string xzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzo_);
            bool? xzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzp_, "completed");
            DataType xzzzzzzzzzzzzzzzzzzzr_ = SMMProcedures?.Performed;
            object xzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? xzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzv_, "day");
            bool? xzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzw_);

            return xzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzl_);

        return xzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("sOCProcedureCategory")]
    public string sOCProcedureCategory(CqlContext context, Procedure TheProcedure)
    {
        string xzzzzzzzzzzzzzzzzzzzy_()
        {
            bool xzzzzzzzzzzzzzzzzzzzz_()
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzze_ = TheProcedure?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzze_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzg_ = this.Blood_Transfusion(context);
                bool? yzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzg_);

                return yzzzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            bool yzzzzzzzzzzzzzzzzzzza_()
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzzi_ = TheProcedure?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzi_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzk_ = this.Conversion_of_Cardiac_Rhythm(context);
                bool? yzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzk_);

                return yzzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool yzzzzzzzzzzzzzzzzzzzb_()
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzzm_ = TheProcedure?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzm_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzo_ = this.Hysterectomy(context);
                bool? yzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzo_);

                return yzzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            bool yzzzzzzzzzzzzzzzzzzzc_()
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzzq_ = TheProcedure?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzq_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzs_ = this.Tracheostomy(context);
                bool? yzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzs_);

                return yzzzzzzzzzzzzzzzzzzzt_ ?? false;
            };
            bool yzzzzzzzzzzzzzzzzzzzd_()
            {
                CodeableConcept yzzzzzzzzzzzzzzzzzzzu_ = TheProcedure?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzw_ = this.Ventilation(context);
                bool? yzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzw_);

                return yzzzzzzzzzzzzzzzzzzzx_ ?? false;
            };
            if (xzzzzzzzzzzzzzzzzzzzz_())
            {
                return "Blood Transfusion";
            }
            else if (yzzzzzzzzzzzzzzzzzzza_())
            {
                return "Conversion of cardiac rhythm";
            }
            else if (yzzzzzzzzzzzzzzzzzzzb_())
            {
                return "Hysterectomy";
            }
            else if (yzzzzzzzzzzzzzzzzzzzc_())
            {
                return "Tracheostomy";
            }
            else if (yzzzzzzzzzzzzzzzzzzzd_())
            {
                return "Ventilation";
            }
            else
            {
                return default;
            }
        };

        return xzzzzzzzzzzzzzzzzzzzy_();
    }


    [CqlExpressionDefinition("SDE SOC Procedure Detail")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> SDE_SOC_Procedure_Detail(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzy_ = this.SDE_Delivery_Encounters_with_Severe_Obstetric_Complication_Procedures(context);
        (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? yzzzzzzzzzzzzzzzzzzzz_(Encounter Encounter)
        {
            Id zzzzzzzzzzzzzzzzzzzzc_ = Encounter?.IdElement;
            string zzzzzzzzzzzzzzzzzzzzd_ = zzzzzzzzzzzzzzzzzzzzc_?.Value;
            IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzze_ = this.sOCProcedures(context, Encounter);
            (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? zzzzzzzzzzzzzzzzzzzzf_(Procedure P)
            {
                string zzzzzzzzzzzzzzzzzzzzj_ = this.sOCProcedureCategory(context, P);
                (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)? zzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_FNaSKPNeFZXSNMfSCYPJLLGSR, P, zzzzzzzzzzzzzzzzzzzzj_);

                return zzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> zzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, (CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(zzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> zzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?>(zzzzzzzzzzzzzzzzzzzzg_);
            (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)? zzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_DbihhAfJfGSKOIcQDBMEMigFK, zzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzh_);

            return zzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> zzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(yzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?> zzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<(CqlTupleMetadata, Procedure code, string SOCProcedureCategory)?> procedures)?>(zzzzzzzzzzzzzzzzzzzza_);

        return zzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);

        return zzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Delivery Encounters with COVID and Respiratory Condition or Procedure")]
    public IEnumerable<Encounter> Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? zzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, TwentyWeeksPlusEncounter);
            bool? zzzzzzzzzzzzzzzzzzzzq_(Condition EncounterDiagnosis)
            {
                CodeableConcept azzzzzzzzzzzzzzzzzzzze_ = EncounterDiagnosis?.Code;
                CqlConcept azzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzze_);
                CqlValueSet azzzzzzzzzzzzzzzzzzzzg_ = this.COVID_19_Confirmed(context);
                bool? azzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzg_);

                return azzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzq_);
            bool? zzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzr_);
            bool? zzzzzzzzzzzzzzzzzzzzu_(Condition EncounterDiagnosis)
            {
                CodeableConcept azzzzzzzzzzzzzzzzzzzzi_ = EncounterDiagnosis?.Code;
                CqlConcept azzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzi_);
                CqlValueSet azzzzzzzzzzzzzzzzzzzzk_ = this.Respiratory_Conditions_Related_to_COVID_19(context);
                bool? azzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzk_);

                return azzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzu_);
            bool? zzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzx_ = this.Respiratory_Support_Procedures_Related_to_COVID_19(context);
            IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? zzzzzzzzzzzzzzzzzzzzz_(Procedure COVIDRespiratoryProcedure)
            {
                Code<EventStatus> azzzzzzzzzzzzzzzzzzzzm_ = COVIDRespiratoryProcedure?.StatusElement;
                EventStatus? azzzzzzzzzzzzzzzzzzzzn_ = azzzzzzzzzzzzzzzzzzzzm_?.Value;
                string azzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzn_);
                bool? azzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzo_, "completed");
                DataType azzzzzzzzzzzzzzzzzzzzq_ = COVIDRespiratoryProcedure?.Performed;
                object azzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzu_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                bool? azzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzu_, "day");
                bool? azzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzv_);

                return azzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzz_);
            bool? azzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzzzzzzza_);
            bool? azzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzb_);
            bool? azzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzc_);

            return azzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzn_);

        return zzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(context);

        return azzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Stratification Encounter")]
    public IEnumerable<Encounter> Stratification_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzy_ = this.Numerator(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzz_ = this.Denominator_Exclusion(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Except<Encounter>(azzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzz_);

        return bzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzc_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Stratum 1")]
    public IEnumerable<Encounter> Stratum_1(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzze_ = this.Stratification_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Intersect<Encounter>(bzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzf_);

        return bzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> bzzzzzzzzzzzzzzzzzzzzh_ = PCMaternal_5_19_000.Instance.Variable_Calculated_Gestational_Age(context);

        return bzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);

        return bzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions Only")]
    public IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzk_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Intersect<Encounter>(bzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SOC Excluding Blood Transfusions Only with Hysterectomy or Blood Transfusion with Placenta Increta or Placenta Percreta Without Additional SOC")]
    public IEnumerable<Encounter> SOC_Excluding_Blood_Transfusions_Only_with_Hysterectomy_or_Blood_Transfusion_with_Placenta_Increta_or_Placenta_Percreta_Without_Additional_SOC(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions_Only(context);
        bool? bzzzzzzzzzzzzzzzzzzzzn_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, SOCExcludingTransfusion);
            bool? bzzzzzzzzzzzzzzzzzzzzy_(Condition EncounterDiagnoses)
            {
                CodeableConcept czzzzzzzzzzzzzzzzzzzzh_ = EncounterDiagnoses?.Code;
                CqlConcept czzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzzzzzzh_);
                CqlValueSet czzzzzzzzzzzzzzzzzzzzj_ = this.Placenta_Increta_or_Percreta(context);
                bool? czzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzj_);

                return czzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzy_);
            bool? czzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
            bool? czzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_with_Hysterectomy(context);
            bool? czzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzzzzzzzzzd_);
            bool? czzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzze_);
            bool? czzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzf_);

            return czzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzn_);
        bool? bzzzzzzzzzzzzzzzzzzzzq_(Encounter SOCExcludingTransfusion)
        {
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzl_ = this.pOAIsNoOrUTD(context, SOCExcludingTransfusion);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzm_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
            bool? czzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzm_);

            return czzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_with_Cardiac_Conversion__Tracheostomy_or_Ventilation_Procedures(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzu_ = this.Delivery_Encounters_with_Expiration(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Except<Encounter>(bzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzv_);

        return bzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("pOAIsYesOrExempt")]
    public IEnumerable<CqlConcept> pOAIsYesOrExempt(CqlContext context, Encounter TheEncounter)
    {
        List<Encounter.DiagnosisComponent> czzzzzzzzzzzzzzzzzzzzo_ = TheEncounter?.Diagnosis;
        bool? czzzzzzzzzzzzzzzzzzzzp_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            bool? czzzzzzzzzzzzzzzzzzzzu_(Extension @this)
            {
                string dzzzzzzzzzzzzzzzzzzzzc_ = @this?.Url;
                FhirString dzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzzzzzzzzzzzc_);
                string dzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzzzd_);
                bool? dzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                return dzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Extension> czzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
                    ? (EncounterDiagnoses as Element).Extension
                    : default), czzzzzzzzzzzzzzzzzzzzu_);
            object czzzzzzzzzzzzzzzzzzzzw_(Extension @this)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzg_ = @this?.Value;

                return dzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<object> czzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(czzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzw_);
            object czzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(czzzzzzzzzzzzzzzzzzzzx_);
            CqlConcept czzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzzzzzzy_ as CodeableConcept);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzza_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
            bool? dzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzza_);

            return dzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter.DiagnosisComponent> czzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)czzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzp_);
        CqlConcept czzzzzzzzzzzzzzzzzzzzr_(Encounter.DiagnosisComponent EncounterDiagnoses)
        {
            ResourceReference dzzzzzzzzzzzzzzzzzzzzh_ = EncounterDiagnoses?.Condition;
            Condition dzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.getCondition(context, dzzzzzzzzzzzzzzzzzzzzh_);
            CodeableConcept dzzzzzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzzzzzi_?.Code;
            CqlConcept dzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzj_);

            return dzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(czzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlConcept>(czzzzzzzzzzzzzzzzzzzzs_);

        return czzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Anemia")]
    public IEnumerable<Encounter> Risk_Variable_Anemia(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? dzzzzzzzzzzzzzzzzzzzzm_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzo_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzp_ = this.Anemia(context);
            bool? dzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzp_);

            return dzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzm_);

        return dzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Risk Variable Asthma")]
    public IEnumerable<Encounter> Risk_Variable_Asthma(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? dzzzzzzzzzzzzzzzzzzzzs_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzu_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzv_ = this.Acute_or_Persistent_Asthma(context);
            bool? dzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzv_);

            return dzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzs_);

        return dzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Autoimmune Disease")]
    public IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? dzzzzzzzzzzzzzzzzzzzzy_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzza_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzb_ = this.Autoimmune_Disease(context);
            bool? ezzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzb_);

            return ezzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzy_);

        return dzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Risk Variable Bariatric Surgery")]
    public IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzh_ = this.Bariatric_Surgery(context);
            bool? ezzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzh_);

            return ezzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzze_);

        return ezzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Bleeding Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzn_ = this.Bleeding_Disorder(context);
            bool? ezzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzn_);

            return ezzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzk_);

        return ezzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Morbid Obesity")]
    public IEnumerable<Encounter> Risk_Variable_Morbid_Obesity(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzp_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzzq_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzs_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzt_ = this.Morbid_or_Severe_Obesity(context);
            bool? ezzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzt_);

            return ezzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzq_);

        return ezzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Risk Variable Cardiac Disease")]
    public IEnumerable<Encounter> Risk_Variable_Cardiac_Disease(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzv_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? ezzzzzzzzzzzzzzzzzzzzw_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzy_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzz_ = this.Cardiac_Disease(context);
            bool? fzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzz_);

            return fzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Risk Variable Economic Housing Instability")]
    public IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzb_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzzc_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzze_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzf_ = this.Economic_Housing_Instability(context);
            bool? fzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzf_);

            return fzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Risk Variable Gastrointestinal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzh_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzzi_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzk_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzl_ = this.Gastrointestinal_Disease(context);
            bool? fzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzl_);

            return fzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Risk Variable Gestational Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzn_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzzo_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzq_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzr_ = this.Gestational_Diabetes(context);
            bool? fzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzr_);

            return fzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable HIV")]
    public IEnumerable<Encounter> Risk_Variable_HIV(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? fzzzzzzzzzzzzzzzzzzzzu_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzw_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzx_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium(context);
            bool? fzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzx_);

            return fzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? gzzzzzzzzzzzzzzzzzzzza_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzzc_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzd_ = this.Hypertension(context);
            bool? gzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzd_);

            return gzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzza_);

        return gzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Long Term Anticoagulant Use")]
    public IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? gzzzzzzzzzzzzzzzzzzzzg_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzzi_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzj_ = this.Long_Term_Anticoagulant_Use(context);
            bool? gzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzj_);

            return gzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzg_);

        return gzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Maternal Age")]
    public IEnumerable<IEnumerable<object>> Risk_Variable_Maternal_Age(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzm_(Encounter TwentyWeeksPlusEncounter)
        {
            Patient gzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
            Date gzzzzzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string gzzzzzzzzzzzzzzzzzzzzr_ = gzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDate gzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzzzzr_);
            Period gzzzzzzzzzzzzzzzzzzzzt_ = TwentyWeeksPlusEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzv_);
            int? gzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzw_, "year");
            object[] gzzzzzzzzzzzzzzzzzzzzy_ = [
                TwentyWeeksPlusEncounter,
gzzzzzzzzzzzzzzzzzzzzx_ ?? default(int),
            ];

            return gzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<object>;
        };
        IEnumerable<IEnumerable<object>> gzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, IEnumerable<object>>(gzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<IEnumerable<object>> gzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<IEnumerable<object>>(gzzzzzzzzzzzzzzzzzzzzn_);

        return gzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Mental Health Disorder")]
    public IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? hzzzzzzzzzzzzzzzzzzzza_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzc_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzd_ = this.Mental_Health_Disorder(context);
            bool? hzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzd_);

            return hzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzza_);

        return hzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Multiple Pregnancy")]
    public IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? hzzzzzzzzzzzzzzzzzzzzg_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzi_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzj_ = this.Multiple_Pregnancy(context);
            bool? hzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzj_);

            return hzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzg_);

        return hzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Neuromuscular")]
    public IEnumerable<Encounter> Risk_Variable_Neuromuscular(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? hzzzzzzzzzzzzzzzzzzzzm_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzo_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzp_ = this.Neuromuscular_Disease(context);
            bool? hzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzm_);

        return hzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Risk Variable Obstetrical VTE")]
    public IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? hzzzzzzzzzzzzzzzzzzzzs_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzu_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzv_ = this.Venous_Thromboembolism_in_Pregnancy(context);
            bool? hzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzv_);

            return hzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzs_);

        return hzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Placenta Previa")]
    public IEnumerable<Encounter> Risk_Variable_Placenta_Previa(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? hzzzzzzzzzzzzzzzzzzzzy_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzza_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzb_ = this.Placenta_Previa(context);
            bool? izzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzy_);

        return hzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Abruption")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Abruption(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? izzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzh_ = this.Placental_Abruption(context);
            bool? izzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzh_);

            return izzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzze_);

        return izzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Placental Accreta Spectrum")]
    public IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? izzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzn_ = this.Placenta_Accreta(context);
            bool? izzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzq_ = this.Placenta_Increta_or_Percreta(context);
            bool? izzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzr_);

            return izzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Preexisting Diabetes")]
    public IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzt_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? izzzzzzzzzzzzzzzzzzzzu_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzzzzzzzw_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzx_ = this.Preexisting_Diabetes(context);
            bool? izzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzx_);

            return izzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzu_);

        return izzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable Previous Cesarean")]
    public IEnumerable<Encounter> Risk_Variable_Previous_Cesarean(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzz_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzza_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzc_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzd_ = this.Previous_Cesarean(context);
            bool? jzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzd_);

            return jzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Pulmonary Hypertension")]
    public IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzf_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzg_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzi_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzj_ = this.Pulmonary_Hypertension(context);
            bool? jzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzj_);

            return jzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzg_);

        return jzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Renal Disease")]
    public IEnumerable<Encounter> Risk_Variable_Renal_Disease(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzl_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzm_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzo_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzp_ = this.Renal_Disease(context);
            bool? jzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzp_);

            return jzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzm_);

        return jzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Risk Variable Severe Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzr_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzs_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzu_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzv_ = this.Severe_Preeclampsia(context);
            bool? jzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzv_);

            return jzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzs_);

        return jzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Substance Abuse")]
    public IEnumerable<Encounter> Risk_Variable_Substance_Abuse(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzx_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? jzzzzzzzzzzzzzzzzzzzzy_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzza_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzb_ = this.Substance_Abuse(context);
            bool? kzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzb_);

            return kzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzy_);

        return jzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Risk Variable Thyrotoxicosis")]
    public IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzd_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzze_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzg_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzh_ = this.Thyrotoxicosis(context);
            bool? kzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzh_);

            return kzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Risk Variable Other Preeclampsia")]
    public IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzj_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        bool? kzzzzzzzzzzzzzzzzzzzzk_(Encounter TwentyWeeksPlusEncounter)
        {
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzn_ = this.Mild_or_Moderate_Preeclampsia(context);
            bool? kzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Preterm Birth")]
    public IEnumerable<Encounter> Risk_Variable_Preterm_Birth(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.Delivery_Encounter_with_Age_Range(context);
        bool? kzzzzzzzzzzzzzzzzzzzzq_(Encounter DeliveryEncounter)
        {
            int? kzzzzzzzzzzzzzzzzzzzzw_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlInterval<int?> kzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(20, 36, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<int?>(kzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzx_, default);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzza_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(20m, "weeks");
            bool? lzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(36m, "weeks");
            bool? lzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.LessOrEqual(lzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzze_);
            bool? lzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzf_);
            bool? lzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And((bool?)(kzzzzzzzzzzzzzzzzzzzzw_ is null), lzzzzzzzzzzzzzzzzzzzzg_);
            bool? lzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzh_);

            return lzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzq_);
        bool? kzzzzzzzzzzzzzzzzzzzzt_(Encounter DeliveryEncounter)
        {
            int? lzzzzzzzzzzzzzzzzzzzzj_ = PCMaternal_5_19_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzk_ = PCMaternal_5_19_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? lzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And((bool?)(lzzzzzzzzzzzzzzzzzzzzj_ is null), (bool?)(lzzzzzzzzzzzzzzzzzzzzk_ is null));
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzm_ = this.pOAIsYesOrExempt(context, DeliveryEncounter);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzn_ = this.Preterm_Birth(context);
            bool? lzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzn_);
            bool? lzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzo_);

            return lzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzu_);

        return kzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzq_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? lzzzzzzzzzzzzzzzzzzzzr_(Encounter TwentyWeeksPlusEncounter)
        {
            Id lzzzzzzzzzzzzzzzzzzzzu_ = TwentyWeeksPlusEncounter?.IdElement;
            string lzzzzzzzzzzzzzzzzzzzzv_ = lzzzzzzzzzzzzzzzzzzzzu_?.Value;
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzw_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? lzzzzzzzzzzzzzzzzzzzzy_(Observation Hematocrit)
            {
                Instant mzzzzzzzzzzzzzzzzzzzzq_ = Hematocrit?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzr_ = mzzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzx_, true, false);
                bool? mzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzza_ = Hematocrit?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzb_ = nzzzzzzzzzzzzzzzzzzzza_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzb_);
                string[] nzzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzze_);
                DataType nzzzzzzzzzzzzzzzzzzzzg_ = Hematocrit?.Value;
                object nzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzg_);
                bool? nzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? nzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzi_);

                return nzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzy_);
            object mzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                Instant nzzzzzzzzzzzzzzzzzzzzk_ = @this?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzl_ = nzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzm_ as object);

                return nzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzb_);
            DataType mzzzzzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzzzzzc_?.Value;
            object mzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? mzzzzzzzzzzzzzzzzzzzzh_(Observation Hematocrit)
            {
                Instant nzzzzzzzzzzzzzzzzzzzzo_ = Hematocrit?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzp_ = nzzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzv_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzv_, true, false);
                bool? nzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzy_ = Hematocrit?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzz_ = nzzzzzzzzzzzzzzzzzzzzy_?.Value;
                string ozzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzz_);
                string[] ozzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzc_);
                DataType ozzzzzzzzzzzzzzzzzzzze_ = Hematocrit?.Value;
                object ozzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzze_);
                bool? ozzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzf_ is null));
                bool? ozzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzg_);

                return ozzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzh_);
            object mzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                Instant ozzzzzzzzzzzzzzzzzzzzi_ = @this?.IssuedElement;
                DateTimeOffset? ozzzzzzzzzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzk_ as object);

                return ozzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzk_);
            Instant mzzzzzzzzzzzzzzzzzzzzm_ = mzzzzzzzzzzzzzzzzzzzzl_?.IssuedElement;
            DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzzzzm_?.Value;
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzn_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? mzzzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, lzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, mzzzzzzzzzzzzzzzzzzzzo_);

            return mzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> lzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(lzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> lzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(lzzzzzzzzzzzzzzzzzzzzs_);

        return lzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable First White Blood Cell Count Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzm_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? ozzzzzzzzzzzzzzzzzzzzn_(Encounter TwentyWeeksPlusEncounter)
        {
            Id ozzzzzzzzzzzzzzzzzzzzq_ = TwentyWeeksPlusEncounter?.IdElement;
            string ozzzzzzzzzzzzzzzzzzzzr_ = ozzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzs_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ozzzzzzzzzzzzzzzzzzzzu_(Observation WBC)
            {
                Instant pzzzzzzzzzzzzzzzzzzzzm_ = WBC?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzp_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzt_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzt_, true, false);
                bool? pzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzu_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzw_ = WBC?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzzzzx_ = pzzzzzzzzzzzzzzzzzzzzw_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzx_);
                string[] pzzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzza_);
                DataType qzzzzzzzzzzzzzzzzzzzzc_ = WBC?.Value;
                object qzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzc_);
                bool? qzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? qzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzze_);

                return qzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzu_);
            object ozzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzg_ = @this?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzi_ as object);

                return qzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(ozzzzzzzzzzzzzzzzzzzzx_);
            DataType ozzzzzzzzzzzzzzzzzzzzz_ = ozzzzzzzzzzzzzzzzzzzzy_?.Value;
            object pzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? pzzzzzzzzzzzzzzzzzzzzd_(Observation WBC)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzk_ = WBC?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzr_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzr_, true, false);
                bool? qzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzu_ = WBC?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzv_);
                string[] qzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzy_);
                DataType rzzzzzzzzzzzzzzzzzzzza_ = WBC?.Value;
                object rzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzza_);
                bool? rzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? rzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzc_);

                return rzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzd_);
            object pzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                Instant rzzzzzzzzzzzzzzzzzzzze_ = @this?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzf_ = rzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzg_ as object);

                return rzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzg_);
            Instant pzzzzzzzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzzzzzzzh_?.IssuedElement;
            DateTimeOffset? pzzzzzzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? pzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_ESFBYaBAeYMhOBFMjVCbeLhQA, ozzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, pzzzzzzzzzzzzzzzzzzzzk_);

            return pzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> ozzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(ozzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> ozzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(ozzzzzzzzzzzzzzzzzzzzo_);

        return ozzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzi_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? rzzzzzzzzzzzzzzzzzzzzj_(Encounter TwentyWeeksPlusEncounter)
        {
            Id rzzzzzzzzzzzzzzzzzzzzm_ = TwentyWeeksPlusEncounter?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzzn_ = rzzzzzzzzzzzzzzzzzzzzm_?.Value;
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? rzzzzzzzzzzzzzzzzzzzzp_(Observation HeartRate)
            {
                DataType szzzzzzzzzzzzzzzzzzzzg_ = HeartRate?.Effective;
                object szzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzj_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzn_, true, false);
                bool? szzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzq_ = HeartRate?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzr_ = szzzzzzzzzzzzzzzzzzzzq_?.Value;
                string szzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzr_);
                string[] szzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzu_);

                return szzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzp_);
            object rzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzx_);

                return szzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzzs_);
            DataType rzzzzzzzzzzzzzzzzzzzzu_ = rzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, rzzzzzzzzzzzzzzzzzzzzu_ as Quantity);
            bool? rzzzzzzzzzzzzzzzzzzzzx_(Observation HeartRate)
            {
                DataType szzzzzzzzzzzzzzzzzzzzz_ = HeartRate?.Effective;
                object tzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzc_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzg_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzg_, true, false);
                bool? tzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzj_ = HeartRate?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzzk_ = tzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string tzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzk_);
                string[] tzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzn_);

                return tzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzx_);
            object rzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                object tzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzq_);

                return tzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzza_);
            DataType szzzzzzzzzzzzzzzzzzzzc_ = szzzzzzzzzzzzzzzzzzzzb_?.Effective;
            object szzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? szzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_HOiMaDjifIOTXXFShNKiWLBLV, rzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzze_);

            return szzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> rzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(rzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> rzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(rzzzzzzzzzzzzzzzzzzzzk_);

        return rzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Risk Variable Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzs_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? tzzzzzzzzzzzzzzzzzzzzt_(Encounter TwentyWeeksPlusEncounter)
        {
            Id tzzzzzzzzzzzzzzzzzzzzw_ = TwentyWeeksPlusEncounter?.IdElement;
            string tzzzzzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzzzzzw_?.Value;
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
            bool? tzzzzzzzzzzzzzzzzzzzzz_(Observation BP)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzu_ = BP?.Effective;
                object uzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzx_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzb_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzb_, true, false);
                bool? vzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzze_ = BP?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzze_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzf_);
                string[] vzzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzi_);
                List<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzk_ = BP?.Component;
                bool? vzzzzzzzzzzzzzzzzzzzzl_(Observation.ComponentComponent @this)
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzr_ = @this?.Value;
                    object vzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzr_);
                    bool? vzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzs_ is null));

                    return vzzzzzzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Observation.ComponentComponent> vzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)vzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzl_);
                object vzzzzzzzzzzzzzzzzzzzzn_(Observation.ComponentComponent @this)
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzu_ = @this?.Value;
                    object vzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzu_);

                    return vzzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Observation.ComponentComponent, object>(vzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzn_);
                bool? vzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? vzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzp_);

                return vzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzz_);
            object uzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzx_);

                return vzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzc_);
            List<Observation.ComponentComponent> uzzzzzzzzzzzzzzzzzzzze_ = uzzzzzzzzzzzzzzzzzzzzd_?.Component;
            bool? uzzzzzzzzzzzzzzzzzzzzf_(Observation.ComponentComponent C)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzz_ = C?.Code;
                CqlConcept wzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzz_);
                CqlCode wzzzzzzzzzzzzzzzzzzzzb_ = this.Systolic_blood_pressure(context);
                CqlConcept wzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(wzzzzzzzzzzzzzzzzzzzzb_);
                bool? wzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzc_);

                return wzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation.ComponentComponent> uzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzh_(Observation.ComponentComponent C)
            {
                DataType wzzzzzzzzzzzzzzzzzzzze_ = C?.Value;
                object wzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzze_);

                return wzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> uzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(uzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<CqlQuantity> uzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlQuantity>(uzzzzzzzzzzzzzzzzzzzzi_);
            bool? uzzzzzzzzzzzzzzzzzzzzl_(Observation BP)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzg_ = BP?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzj_ = PCMaternal_5_19_000.Instance.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzn_ = PCMaternal_5_19_000.Instance.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzn_, true, false);
                bool? wzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzq_ = BP?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzr_ = wzzzzzzzzzzzzzzzzzzzzq_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzr_);
                string[] wzzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzu_);
                List<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzzw_ = BP?.Component;
                bool? wzzzzzzzzzzzzzzzzzzzzx_(Observation.ComponentComponent @this)
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzd_ = @this?.Value;
                    object xzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzd_);
                    bool? xzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzze_ is null));

                    return xzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Observation.ComponentComponent> wzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)wzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzx_);
                object wzzzzzzzzzzzzzzzzzzzzz_(Observation.ComponentComponent @this)
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzg_ = @this?.Value;
                    object xzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzg_);

                    return xzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> xzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Observation.ComponentComponent, object>(wzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzz_);
                bool? xzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? xzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzb_);

                return xzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzl_);
            object uzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzj_);

                return xzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzo_);
            DataType uzzzzzzzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzzzzzzzp_?.Effective;
            object uzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? uzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, tzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzs_);

            return uzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> tzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(tzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> tzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(tzzzzzzzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzzzzzzzv_;
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
